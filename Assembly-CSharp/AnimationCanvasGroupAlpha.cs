using System;
using DG.Tweening;
using UnityEngine;

// Token: 0x020003F2 RID: 1010
[ExecuteInEditMode]
public class AnimationCanvasGroupAlpha : MonoBehaviour
{
	// Token: 0x06007619 RID: 30233 RVA: 0x00358628 File Offset: 0x00356828
	public void OENEEPHFNGD(bool IFJFCJGMAEG = false)
	{
		if (null == this.PANMNKKODPC)
		{
			try
			{
				this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
			if (null == this.PANMNKKODPC)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("getLiveOffers");
				return;
			}
		}
		this.HNJLPANEDFP = IFJFCJGMAEG;
		this.DCCKDJLAFPP = false;
		this.PANMNKKODPC.DOKill(false);
		float endValue = this.HFICFHBCJGH;
		if (this.LNGMMALCMPF)
		{
			if (this.BBHHFLFJCNL)
			{
				this.PANMNKKODPC.alpha = this.HFICFHBCJGH;
				endValue = this.KMNHLNIHKJF;
			}
			else
			{
				this.PANMNKKODPC.alpha = this.KMNHLNIHKJF;
				endValue = this.HFICFHBCJGH;
			}
		}
		else
		{
			this.PANMNKKODPC.alpha = this.KMNHLNIHKJF;
		}
		if (this.looped)
		{
			this.DENHGKHKLHF = this.PANMNKKODPC.DOFade(endValue, this.animationTime).SetEase(this.animationEase).OnComplete(new TweenCallback(this.EMOPHBIMFLI)).SetLoops(-166, this.cycleType);
			return;
		}
		if (this.cycleType != LoopType.Restart)
		{
			this.DENHGKHKLHF = this.PANMNKKODPC.DOFade(endValue, this.animationTime).SetEase(this.animationEase).OnComplete(new TweenCallback(this.MELPFEKINFG)).SetLoops(6, this.cycleType);
			return;
		}
		this.DENHGKHKLHF = this.PANMNKKODPC.DOFade(endValue, this.animationTime).SetEase(this.animationEase).OnComplete(new TweenCallback(this.MELPFEKINFG));
	}

	// Token: 0x0600761A RID: 30234 RVA: 0x003587C8 File Offset: 0x003569C8
	private void FBACIBOFHJO()
	{
		this.JONEGFEOLKJ = this.repeatTimes;
		this.FOLIHFAJOCP(false);
		this.LNGMMALCMPF = true;
		this.BBHHFLFJCNL = false;
		if (this.playOnEnable)
		{
			this.DLAFBOCNONH = this.delayAtStart;
		}
		else
		{
			this.DLAFBOCNONH = 1444f;
		}
		this.POCDJMKBPAK();
		this.DDNDCPJPBHL();
	}

	// Token: 0x0600761B RID: 30235 RVA: 0x00358823 File Offset: 0x00356A23
	private void ODPDLANJNIP()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x0600761C RID: 30236 RVA: 0x00358838 File Offset: 0x00356A38
	public void BKCIEFBJBLA(bool GEAPJFPNBIM = false)
	{
		if (null == this.PANMNKKODPC)
		{
			try
			{
				this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
			if (null == this.PANMNKKODPC)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("");
				return;
			}
		}
		if (GEAPJFPNBIM)
		{
			this.KMNHLNIHKJF = this.endAlpha;
			this.HFICFHBCJGH = this.startAlpha;
		}
		else
		{
			this.KMNHLNIHKJF = this.startAlpha;
			this.HFICFHBCJGH = this.endAlpha;
		}
		this.PANMNKKODPC.alpha = this.KMNHLNIHKJF;
	}

	// Token: 0x0600761D RID: 30237 RVA: 0x003588DC File Offset: 0x00356ADC
	public void PHEMOGNOFFI(bool GEAPJFPNBIM = false)
	{
		if (null == this.PANMNKKODPC)
		{
			try
			{
				this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			}
			if (null == this.PANMNKKODPC)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("OnNeedToRestartProfileItemAnimation");
				return;
			}
		}
		if (GEAPJFPNBIM)
		{
			this.KMNHLNIHKJF = this.endAlpha;
			this.HFICFHBCJGH = this.startAlpha;
		}
		else
		{
			this.KMNHLNIHKJF = this.startAlpha;
			this.HFICFHBCJGH = this.endAlpha;
		}
		this.PANMNKKODPC.alpha = this.KMNHLNIHKJF;
	}

	// Token: 0x0600761E RID: 30238 RVA: 0x00358980 File Offset: 0x00356B80
	private void IMHILNMKAIN()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(true);
		}
		this.DENHGKHKLHF = null;
	}

	// Token: 0x0600761F RID: 30239 RVA: 0x003589A4 File Offset: 0x00356BA4
	private void KCIHDOMDINL()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
		this.DENHGKHKLHF = null;
	}

	// Token: 0x06007620 RID: 30240 RVA: 0x003589C8 File Offset: 0x00356BC8
	private void IPLDJLJCPLL()
	{
		if (this.DCCKDJLAFPP)
		{
			this.NIMLCJHAAHN -= Time.deltaTime;
			if (this.NIMLCJHAAHN < 1527f)
			{
				this.POCDJMKBPAK();
				this.PGKFNLNMIHN(false);
				return;
			}
		}
		else
		{
			this.DLAFBOCNONH -= Time.deltaTime;
			if (this.DLAFBOCNONH <= 1204f)
			{
				this.DLAFBOCNONH = 1294f;
				this.BEDPNJBGGEB();
				this.PlayAnimation(true);
			}
		}
	}

	// Token: 0x06007621 RID: 30241 RVA: 0x003589A4 File Offset: 0x00356BA4
	private void OnDestroy()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
		this.DENHGKHKLHF = null;
	}

	// Token: 0x06007622 RID: 30242 RVA: 0x00358A44 File Offset: 0x00356C44
	private void LDLLCBDGGHN()
	{
		this.JONEGFEOLKJ = this.repeatTimes;
		this.HAEAIGMGGOA(true);
		this.LNGMMALCMPF = false;
		this.BBHHFLFJCNL = false;
		if (this.playOnEnable)
		{
			this.DLAFBOCNONH = this.delayAtStart;
		}
		else
		{
			this.DLAFBOCNONH = 312f;
		}
		this.BEDPNJBGGEB();
		this.DDNDCPJPBHL();
	}

	// Token: 0x06007623 RID: 30243 RVA: 0x00358AA0 File Offset: 0x00356CA0
	private void BIMCNGLLIOC()
	{
		if (this.DCCKDJLAFPP)
		{
			this.NIMLCJHAAHN -= Time.deltaTime;
			if (this.NIMLCJHAAHN < 1491f)
			{
				this.NBGKIJLIMLD();
				this.MPICIBINNCP(false);
				return;
			}
		}
		else
		{
			this.DLAFBOCNONH -= Time.deltaTime;
			if (this.DLAFBOCNONH <= 1409f)
			{
				this.DLAFBOCNONH = 591f;
				this.OLBFHAEICAC();
				this.IFBEGMNMGMP(true);
			}
		}
	}

	// Token: 0x06007624 RID: 30244 RVA: 0x00358B1C File Offset: 0x00356D1C
	public void BPCOKLEABJD(bool GEAPJFPNBIM = false)
	{
		if (null == this.PANMNKKODPC)
		{
			try
			{
				this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			}
			if (null == this.PANMNKKODPC)
			{
				DPGJIJGOCIC.ANOPFDLPKGC(">");
				return;
			}
		}
		if (GEAPJFPNBIM)
		{
			this.KMNHLNIHKJF = this.endAlpha;
			this.HFICFHBCJGH = this.startAlpha;
		}
		else
		{
			this.KMNHLNIHKJF = this.startAlpha;
			this.HFICFHBCJGH = this.endAlpha;
		}
		this.PANMNKKODPC.alpha = this.KMNHLNIHKJF;
	}

	// Token: 0x06007625 RID: 30245 RVA: 0x00358BC0 File Offset: 0x00356DC0
	public void KBMPFNHNADD(bool IFJFCJGMAEG = false)
	{
		if (null == this.PANMNKKODPC)
		{
			try
			{
				this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			}
			if (null == this.PANMNKKODPC)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("dynamic");
				return;
			}
		}
		this.HNJLPANEDFP = IFJFCJGMAEG;
		this.DCCKDJLAFPP = true;
		this.PANMNKKODPC.DOKill(false);
		float endValue = this.HFICFHBCJGH;
		if (this.LNGMMALCMPF)
		{
			if (this.BBHHFLFJCNL)
			{
				this.PANMNKKODPC.alpha = this.HFICFHBCJGH;
				endValue = this.KMNHLNIHKJF;
			}
			else
			{
				this.PANMNKKODPC.alpha = this.KMNHLNIHKJF;
				endValue = this.HFICFHBCJGH;
			}
		}
		else
		{
			this.PANMNKKODPC.alpha = this.KMNHLNIHKJF;
		}
		if (this.looped)
		{
			this.DENHGKHKLHF = this.PANMNKKODPC.DOFade(endValue, this.animationTime).SetEase(this.animationEase).OnComplete(new TweenCallback(this.EMOPHBIMFLI)).SetLoops(81, this.cycleType);
			return;
		}
		if (this.cycleType != LoopType.Restart)
		{
			this.DENHGKHKLHF = this.PANMNKKODPC.DOFade(endValue, this.animationTime).SetEase(this.animationEase).OnComplete(new TweenCallback(this.EMOPHBIMFLI)).SetLoops(3, this.cycleType);
			return;
		}
		this.DENHGKHKLHF = this.PANMNKKODPC.DOFade(endValue, this.animationTime).SetEase(this.animationEase).OnComplete(new TweenCallback(this.EAABCAMGPKG));
	}

	// Token: 0x06007626 RID: 30246 RVA: 0x00358D60 File Offset: 0x00356F60
	public void OIGNMAPLGIK(bool GEAPJFPNBIM = false)
	{
		if (null == this.PANMNKKODPC)
		{
			try
			{
				this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
			if (null == this.PANMNKKODPC)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("SceneLobbyManager2.DownloadMissingLowPreview2Assets(): Exit!");
				return;
			}
		}
		if (GEAPJFPNBIM)
		{
			this.KMNHLNIHKJF = this.endAlpha;
			this.HFICFHBCJGH = this.startAlpha;
		}
		else
		{
			this.KMNHLNIHKJF = this.startAlpha;
			this.HFICFHBCJGH = this.endAlpha;
		}
		this.PANMNKKODPC.alpha = this.KMNHLNIHKJF;
	}

	// Token: 0x06007627 RID: 30247 RVA: 0x00358E04 File Offset: 0x00357004
	public bool OCKJDKEKKFA()
	{
		return this.DENHGKHKLHF == null || this.DENHGKHKLHF.IsComplete();
	}

	// Token: 0x06007628 RID: 30248 RVA: 0x00358E1E File Offset: 0x0035701E
	public bool JEFKFHBIDKI()
	{
		return this.DENHGKHKLHF != null && !this.DENHGKHKLHF.IsComplete();
	}

	// Token: 0x06007629 RID: 30249 RVA: 0x00358E38 File Offset: 0x00357038
	public void HOCMCDHLIAE(bool GEAPJFPNBIM = false)
	{
		if (null == this.PANMNKKODPC)
		{
			try
			{
				this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			}
			if (null == this.PANMNKKODPC)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("");
				return;
			}
		}
		if (GEAPJFPNBIM)
		{
			this.KMNHLNIHKJF = this.endAlpha;
			this.HFICFHBCJGH = this.startAlpha;
		}
		else
		{
			this.KMNHLNIHKJF = this.startAlpha;
			this.HFICFHBCJGH = this.endAlpha;
		}
		this.PANMNKKODPC.alpha = this.KMNHLNIHKJF;
	}

	// Token: 0x0600762A RID: 30250 RVA: 0x00358EDC File Offset: 0x003570DC
	private void KLAMAKNLPKE()
	{
		this.DCCKDJLAFPP = false;
		this.NIMLCJHAAHN = 102f;
	}

	// Token: 0x0600762B RID: 30251 RVA: 0x00358EF0 File Offset: 0x003570F0
	private void ALOEGNGEFMM()
	{
		this.JONEGFEOLKJ = this.repeatTimes;
		this.ODFEPCFMPJB(false);
		this.LNGMMALCMPF = true;
		this.BBHHFLFJCNL = true;
		if (this.playOnEnable)
		{
			this.DLAFBOCNONH = this.delayAtStart;
		}
		else
		{
			this.DLAFBOCNONH = 1130f;
		}
		this.KLAMAKNLPKE();
		this.Update();
	}

	// Token: 0x0600762C RID: 30252 RVA: 0x00358F4C File Offset: 0x0035714C
	private void LPPBMJLKGCB()
	{
		if (this.HNJLPANEDFP || this.disableOnComplete)
		{
			base.gameObject.SetActive(true);
			return;
		}
		if (!this.repeatOnComplete)
		{
			this.NIMLCJHAAHN = 561f;
			return;
		}
		if (this.JONEGFEOLKJ > 0)
		{
			this.DCCKDJLAFPP = true;
			this.NIMLCJHAAHN = this.repeatOnCompleteDelay;
			this.JONEGFEOLKJ--;
		}
		else
		{
			this.NIMLCJHAAHN = 448f;
		}
		if (this.flipAnimationOnComplete)
		{
			this.LNGMMALCMPF = true;
			this.BBHHFLFJCNL = !this.BBHHFLFJCNL;
		}
	}

	// Token: 0x0600762D RID: 30253 RVA: 0x00358FE0 File Offset: 0x003571E0
	public void PLHKMIGGEHB(bool GEAPJFPNBIM = false)
	{
		if (null == this.PANMNKKODPC)
		{
			try
			{
				this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
			if (null == this.PANMNKKODPC)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("{skin}");
				return;
			}
		}
		if (GEAPJFPNBIM)
		{
			this.KMNHLNIHKJF = this.endAlpha;
			this.HFICFHBCJGH = this.startAlpha;
		}
		else
		{
			this.KMNHLNIHKJF = this.startAlpha;
			this.HFICFHBCJGH = this.endAlpha;
		}
		this.PANMNKKODPC.alpha = this.KMNHLNIHKJF;
	}

	// Token: 0x0600762E RID: 30254 RVA: 0x00359084 File Offset: 0x00357284
	public void PKEELDKHLHN(bool IFJFCJGMAEG = false)
	{
		if (null == this.PANMNKKODPC)
		{
			try
			{
				this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
			if (null == this.PANMNKKODPC)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("lsvv");
				return;
			}
		}
		this.HNJLPANEDFP = IFJFCJGMAEG;
		this.DCCKDJLAFPP = false;
		this.PANMNKKODPC.DOKill(true);
		float endValue = this.HFICFHBCJGH;
		if (this.LNGMMALCMPF)
		{
			if (this.BBHHFLFJCNL)
			{
				this.PANMNKKODPC.alpha = this.HFICFHBCJGH;
				endValue = this.KMNHLNIHKJF;
			}
			else
			{
				this.PANMNKKODPC.alpha = this.KMNHLNIHKJF;
				endValue = this.HFICFHBCJGH;
			}
		}
		else
		{
			this.PANMNKKODPC.alpha = this.KMNHLNIHKJF;
		}
		if (this.looped)
		{
			this.DENHGKHKLHF = this.PANMNKKODPC.DOFade(endValue, this.animationTime).SetEase(this.animationEase).OnComplete(new TweenCallback(this.EAABCAMGPKG)).SetLoops(-134, this.cycleType);
			return;
		}
		if (this.cycleType != LoopType.Restart)
		{
			this.DENHGKHKLHF = this.PANMNKKODPC.DOFade(endValue, this.animationTime).SetEase(this.animationEase).OnComplete(new TweenCallback(this.MELPFEKINFG)).SetLoops(7, this.cycleType);
			return;
		}
		this.DENHGKHKLHF = this.PANMNKKODPC.DOFade(endValue, this.animationTime).SetEase(this.animationEase).OnComplete(new TweenCallback(this.EMOPHBIMFLI));
	}

	// Token: 0x0600762F RID: 30255 RVA: 0x00359224 File Offset: 0x00357424
	private void NBGKIJLIMLD()
	{
		this.DCCKDJLAFPP = true;
		this.NIMLCJHAAHN = 515f;
	}

	// Token: 0x06007630 RID: 30256 RVA: 0x00359238 File Offset: 0x00357438
	public void SetDirection(bool GEAPJFPNBIM = false)
	{
		if (null == this.PANMNKKODPC)
		{
			try
			{
				this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
			if (null == this.PANMNKKODPC)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("AnimationCanvasGroupAlpha - no canvas group attached.");
				return;
			}
		}
		if (GEAPJFPNBIM)
		{
			this.KMNHLNIHKJF = this.endAlpha;
			this.HFICFHBCJGH = this.startAlpha;
		}
		else
		{
			this.KMNHLNIHKJF = this.startAlpha;
			this.HFICFHBCJGH = this.endAlpha;
		}
		this.PANMNKKODPC.alpha = this.KMNHLNIHKJF;
	}

	// Token: 0x06007631 RID: 30257 RVA: 0x00358823 File Offset: 0x00356A23
	private void LPEDJEOJIFP()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06007632 RID: 30258 RVA: 0x003592DC File Offset: 0x003574DC
	private void DDNDCPJPBHL()
	{
		if (this.DCCKDJLAFPP)
		{
			this.NIMLCJHAAHN -= Time.deltaTime;
			if (this.NIMLCJHAAHN < 693f)
			{
				this.NBGKIJLIMLD();
				this.OENEEPHFNGD(true);
				return;
			}
		}
		else
		{
			this.DLAFBOCNONH -= Time.deltaTime;
			if (this.DLAFBOCNONH <= 94f)
			{
				this.DLAFBOCNONH = 1813f;
				this.JHGFOKOFMHB();
				this.IFBEGMNMGMP(false);
			}
		}
	}

	// Token: 0x06007633 RID: 30259 RVA: 0x003589A4 File Offset: 0x00356BA4
	private void KDKPPDMCEBF()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
		this.DENHGKHKLHF = null;
	}

	// Token: 0x06007634 RID: 30260 RVA: 0x00358823 File Offset: 0x00356A23
	private void NPFILNGGHGH()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06007635 RID: 30261 RVA: 0x00359358 File Offset: 0x00357558
	private void BDILEIAPNIM()
	{
		this.JONEGFEOLKJ = this.repeatTimes;
		this.ODFEPCFMPJB(true);
		this.LNGMMALCMPF = true;
		this.BBHHFLFJCNL = true;
		if (this.playOnEnable)
		{
			this.DLAFBOCNONH = this.delayAtStart;
		}
		else
		{
			this.DLAFBOCNONH = 46f;
		}
		this.BEDPNJBGGEB();
		this.OPAPLDKCLPO();
	}

	// Token: 0x06007636 RID: 30262 RVA: 0x00358823 File Offset: 0x00356A23
	private void KDNKCFGANFN()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06007637 RID: 30263 RVA: 0x003593B3 File Offset: 0x003575B3
	private void BEDPNJBGGEB()
	{
		this.DCCKDJLAFPP = true;
		this.NIMLCJHAAHN = 1461f;
	}

	// Token: 0x06007639 RID: 30265 RVA: 0x00359418 File Offset: 0x00357618
	private void FGILNOIHMCJ()
	{
		this.JONEGFEOLKJ = this.repeatTimes;
		this.PLHKMIGGEHB(false);
		this.LNGMMALCMPF = true;
		this.BBHHFLFJCNL = false;
		if (this.playOnEnable)
		{
			this.DLAFBOCNONH = this.delayAtStart;
		}
		else
		{
			this.DLAFBOCNONH = 1229f;
		}
		this.NBGKIJLIMLD();
		this.GPOPCNMGNGD();
	}

	// Token: 0x0600763A RID: 30266 RVA: 0x003589A4 File Offset: 0x00356BA4
	private void LNKJIJJJGIA()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
		this.DENHGKHKLHF = null;
	}

	// Token: 0x0600763B RID: 30267 RVA: 0x00359474 File Offset: 0x00357674
	public void HAEEBFCHLIK(bool GEAPJFPNBIM = false)
	{
		if (null == this.PANMNKKODPC)
		{
			try
			{
				this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
			if (null == this.PANMNKKODPC)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("OnPopupProfileMessageInputEndEdit");
				return;
			}
		}
		if (GEAPJFPNBIM)
		{
			this.KMNHLNIHKJF = this.endAlpha;
			this.HFICFHBCJGH = this.startAlpha;
		}
		else
		{
			this.KMNHLNIHKJF = this.startAlpha;
			this.HFICFHBCJGH = this.endAlpha;
		}
		this.PANMNKKODPC.alpha = this.KMNHLNIHKJF;
	}

	// Token: 0x0600763C RID: 30268 RVA: 0x003589A4 File Offset: 0x00356BA4
	private void BHAMDIHNJNA()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
		this.DENHGKHKLHF = null;
	}

	// Token: 0x0600763D RID: 30269 RVA: 0x00359518 File Offset: 0x00357718
	public void CHOGMCMNIKA(bool IFJFCJGMAEG = false)
	{
		if (null == this.PANMNKKODPC)
		{
			try
			{
				this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			}
			if (null == this.PANMNKKODPC)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Set Value For {0}");
				return;
			}
		}
		this.HNJLPANEDFP = IFJFCJGMAEG;
		this.DCCKDJLAFPP = true;
		this.PANMNKKODPC.DOKill(false);
		float endValue = this.HFICFHBCJGH;
		if (this.LNGMMALCMPF)
		{
			if (this.BBHHFLFJCNL)
			{
				this.PANMNKKODPC.alpha = this.HFICFHBCJGH;
				endValue = this.KMNHLNIHKJF;
			}
			else
			{
				this.PANMNKKODPC.alpha = this.KMNHLNIHKJF;
				endValue = this.HFICFHBCJGH;
			}
		}
		else
		{
			this.PANMNKKODPC.alpha = this.KMNHLNIHKJF;
		}
		if (this.looped)
		{
			this.DENHGKHKLHF = this.PANMNKKODPC.DOFade(endValue, this.animationTime).SetEase(this.animationEase).OnComplete(new TweenCallback(this.LPPBMJLKGCB)).SetLoops(-187, this.cycleType);
			return;
		}
		if (this.cycleType != LoopType.Restart)
		{
			this.DENHGKHKLHF = this.PANMNKKODPC.DOFade(endValue, this.animationTime).SetEase(this.animationEase).OnComplete(new TweenCallback(this.MELPFEKINFG)).SetLoops(7, this.cycleType);
			return;
		}
		this.DENHGKHKLHF = this.PANMNKKODPC.DOFade(endValue, this.animationTime).SetEase(this.animationEase).OnComplete(new TweenCallback(this.IGLGJHKMPEG));
	}

	// Token: 0x0600763E RID: 30270 RVA: 0x00358823 File Offset: 0x00356A23
	private void AALDINEPEHJ()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x0600763F RID: 30271 RVA: 0x003589A4 File Offset: 0x00356BA4
	private void CEJFHEBCHGK()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
		this.DENHGKHKLHF = null;
	}

	// Token: 0x06007640 RID: 30272 RVA: 0x003596B8 File Offset: 0x003578B8
	private void HBELNHOMGCI()
	{
		this.JONEGFEOLKJ = this.repeatTimes;
		this.JKMGEALFGLB(true);
		this.LNGMMALCMPF = true;
		this.BBHHFLFJCNL = false;
		if (this.playOnEnable)
		{
			this.DLAFBOCNONH = this.delayAtStart;
		}
		else
		{
			this.DLAFBOCNONH = 1625f;
		}
		this.BEDPNJBGGEB();
		this.KGJJLDJBEON();
	}

	// Token: 0x06007641 RID: 30273 RVA: 0x00359714 File Offset: 0x00357914
	private void IGLGJHKMPEG()
	{
		if (this.HNJLPANEDFP || this.disableOnComplete)
		{
			base.gameObject.SetActive(false);
			return;
		}
		if (!this.repeatOnComplete)
		{
			this.NIMLCJHAAHN = -1f;
			return;
		}
		if (this.JONEGFEOLKJ > 0)
		{
			this.DCCKDJLAFPP = true;
			this.NIMLCJHAAHN = this.repeatOnCompleteDelay;
			this.JONEGFEOLKJ--;
		}
		else
		{
			this.NIMLCJHAAHN = -1f;
		}
		if (this.flipAnimationOnComplete)
		{
			this.LNGMMALCMPF = true;
			this.BBHHFLFJCNL = !this.BBHHFLFJCNL;
		}
	}

	// Token: 0x06007642 RID: 30274 RVA: 0x00358823 File Offset: 0x00356A23
	private void MDNEOMGLGIN()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06007643 RID: 30275 RVA: 0x003597A8 File Offset: 0x003579A8
	public void JNMIPNKPAHC(bool GEAPJFPNBIM = false)
	{
		if (null == this.PANMNKKODPC)
		{
			try
			{
				this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
			if (null == this.PANMNKKODPC)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("$");
				return;
			}
		}
		if (GEAPJFPNBIM)
		{
			this.KMNHLNIHKJF = this.endAlpha;
			this.HFICFHBCJGH = this.startAlpha;
		}
		else
		{
			this.KMNHLNIHKJF = this.startAlpha;
			this.HFICFHBCJGH = this.endAlpha;
		}
		this.PANMNKKODPC.alpha = this.KMNHLNIHKJF;
	}

	// Token: 0x06007644 RID: 30276 RVA: 0x003589A4 File Offset: 0x00356BA4
	private void NAAFHFFELKK()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
		this.DENHGKHKLHF = null;
	}

	// Token: 0x06007645 RID: 30277 RVA: 0x0035984C File Offset: 0x00357A4C
	private void MELPFEKINFG()
	{
		if (this.HNJLPANEDFP || this.disableOnComplete)
		{
			base.gameObject.SetActive(true);
			return;
		}
		if (!this.repeatOnComplete)
		{
			this.NIMLCJHAAHN = 1053f;
			return;
		}
		if (this.JONEGFEOLKJ > 1)
		{
			this.DCCKDJLAFPP = true;
			this.NIMLCJHAAHN = this.repeatOnCompleteDelay;
			this.JONEGFEOLKJ--;
		}
		else
		{
			this.NIMLCJHAAHN = 1904f;
		}
		if (this.flipAnimationOnComplete)
		{
			this.LNGMMALCMPF = true;
			this.BBHHFLFJCNL = this.BBHHFLFJCNL;
		}
	}

	// Token: 0x06007646 RID: 30278 RVA: 0x00358E1E File Offset: 0x0035701E
	public bool IsPlaying()
	{
		return this.DENHGKHKLHF != null && !this.DENHGKHKLHF.IsComplete();
	}

	// Token: 0x06007647 RID: 30279 RVA: 0x003598E0 File Offset: 0x00357AE0
	private void HIHJOJADNOH()
	{
		this.JONEGFEOLKJ = this.repeatTimes;
		this.MKLBGNMEOHH(false);
		this.LNGMMALCMPF = true;
		this.BBHHFLFJCNL = false;
		if (this.playOnEnable)
		{
			this.DLAFBOCNONH = this.delayAtStart;
		}
		else
		{
			this.DLAFBOCNONH = 850f;
		}
		this.OLBFHAEICAC();
		this.GPOPCNMGNGD();
	}

	// Token: 0x06007648 RID: 30280 RVA: 0x0035993C File Offset: 0x00357B3C
	private void OnEnable()
	{
		this.JONEGFEOLKJ = this.repeatTimes;
		this.SetDirection(false);
		this.LNGMMALCMPF = false;
		this.BBHHFLFJCNL = false;
		if (this.playOnEnable)
		{
			this.DLAFBOCNONH = this.delayAtStart;
		}
		else
		{
			this.DLAFBOCNONH = 10000000f;
		}
		this.JHGFOKOFMHB();
		this.Update();
	}

	// Token: 0x06007649 RID: 30281 RVA: 0x00359997 File Offset: 0x00357B97
	private void KAAEMJNFDGJ()
	{
		this.DCCKDJLAFPP = true;
		this.NIMLCJHAAHN = 1235f;
	}

	// Token: 0x0600764A RID: 30282 RVA: 0x00358980 File Offset: 0x00356B80
	private void BBCLLACKJDC()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(true);
		}
		this.DENHGKHKLHF = null;
	}

	// Token: 0x0600764B RID: 30283 RVA: 0x003599AC File Offset: 0x00357BAC
	public void JKMGEALFGLB(bool GEAPJFPNBIM = false)
	{
		if (null == this.PANMNKKODPC)
		{
			try
			{
				this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			}
			if (null == this.PANMNKKODPC)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("</i>");
				return;
			}
		}
		if (GEAPJFPNBIM)
		{
			this.KMNHLNIHKJF = this.endAlpha;
			this.HFICFHBCJGH = this.startAlpha;
		}
		else
		{
			this.KMNHLNIHKJF = this.startAlpha;
			this.HFICFHBCJGH = this.endAlpha;
		}
		this.PANMNKKODPC.alpha = this.KMNHLNIHKJF;
	}

	// Token: 0x0600764C RID: 30284 RVA: 0x00358823 File Offset: 0x00356A23
	private void LFOJBMBCOFP()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x0600764D RID: 30285 RVA: 0x00359A50 File Offset: 0x00357C50
	public void BADLBNOCCFC(bool GEAPJFPNBIM = false)
	{
		if (null == this.PANMNKKODPC)
		{
			try
			{
				this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
			if (null == this.PANMNKKODPC)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("AssetAnthologyHeader.IsAvatarScreenAvatarPack(), unsupported wardrobe index:");
				return;
			}
		}
		if (GEAPJFPNBIM)
		{
			this.KMNHLNIHKJF = this.endAlpha;
			this.HFICFHBCJGH = this.startAlpha;
		}
		else
		{
			this.KMNHLNIHKJF = this.startAlpha;
			this.HFICFHBCJGH = this.endAlpha;
		}
		this.PANMNKKODPC.alpha = this.KMNHLNIHKJF;
	}

	// Token: 0x0600764E RID: 30286 RVA: 0x00359AF4 File Offset: 0x00357CF4
	public void KAJGHDCFLKB(bool GEAPJFPNBIM = false)
	{
		if (null == this.PANMNKKODPC)
		{
			try
			{
				this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			}
			if (null == this.PANMNKKODPC)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("WWW");
				return;
			}
		}
		if (GEAPJFPNBIM)
		{
			this.KMNHLNIHKJF = this.endAlpha;
			this.HFICFHBCJGH = this.startAlpha;
		}
		else
		{
			this.KMNHLNIHKJF = this.startAlpha;
			this.HFICFHBCJGH = this.endAlpha;
		}
		this.PANMNKKODPC.alpha = this.KMNHLNIHKJF;
	}

	// Token: 0x0600764F RID: 30287 RVA: 0x00359B98 File Offset: 0x00357D98
	private void MNNHONLLGCD()
	{
		this.JONEGFEOLKJ = this.repeatTimes;
		this.HAEAIGMGGOA(false);
		this.LNGMMALCMPF = true;
		this.BBHHFLFJCNL = true;
		if (this.playOnEnable)
		{
			this.DLAFBOCNONH = this.delayAtStart;
		}
		else
		{
			this.DLAFBOCNONH = 315f;
		}
		this.POCDJMKBPAK();
		this.KGJJLDJBEON();
	}

	// Token: 0x06007650 RID: 30288 RVA: 0x00359BF4 File Offset: 0x00357DF4
	private void KGJJLDJBEON()
	{
		if (this.DCCKDJLAFPP)
		{
			this.NIMLCJHAAHN -= Time.deltaTime;
			if (this.NIMLCJHAAHN < 1948f)
			{
				this.KLAMAKNLPKE();
				this.PGKFNLNMIHN(true);
				return;
			}
		}
		else
		{
			this.DLAFBOCNONH -= Time.deltaTime;
			if (this.DLAFBOCNONH <= 410f)
			{
				this.DLAFBOCNONH = 817f;
				this.KAAEMJNFDGJ();
				this.PKEELDKHLHN(true);
			}
		}
	}

	// Token: 0x06007651 RID: 30289 RVA: 0x00358823 File Offset: 0x00356A23
	private void DBCGAKFDLGD()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06007652 RID: 30290 RVA: 0x00359C6D File Offset: 0x00357E6D
	private void JHGFOKOFMHB()
	{
		this.DCCKDJLAFPP = false;
		this.NIMLCJHAAHN = -1f;
	}

	// Token: 0x06007653 RID: 30291 RVA: 0x00358823 File Offset: 0x00356A23
	private void LBDIDHDKHGO()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06007654 RID: 30292 RVA: 0x00359C84 File Offset: 0x00357E84
	private void PABMEBKPBJO()
	{
		this.JONEGFEOLKJ = this.repeatTimes;
		this.SetDirection(false);
		this.LNGMMALCMPF = false;
		this.BBHHFLFJCNL = true;
		if (this.playOnEnable)
		{
			this.DLAFBOCNONH = this.delayAtStart;
		}
		else
		{
			this.DLAFBOCNONH = 35f;
		}
		this.KLAMAKNLPKE();
		this.GPOPCNMGNGD();
	}

	// Token: 0x06007655 RID: 30293 RVA: 0x00359CDF File Offset: 0x00357EDF
	public bool IJJLNNPCGOK()
	{
		return this.DENHGKHKLHF == null || !this.DENHGKHKLHF.IsComplete();
	}

	// Token: 0x06007656 RID: 30294 RVA: 0x00359CFC File Offset: 0x00357EFC
	public void PlayAnimation(bool IFJFCJGMAEG = false)
	{
		if (null == this.PANMNKKODPC)
		{
			try
			{
				this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
			if (null == this.PANMNKKODPC)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("AnimationCanvasGroupAlpha - no canvas group attached.");
				return;
			}
		}
		this.HNJLPANEDFP = IFJFCJGMAEG;
		this.DCCKDJLAFPP = false;
		this.PANMNKKODPC.DOKill(false);
		float endValue = this.HFICFHBCJGH;
		if (this.LNGMMALCMPF)
		{
			if (this.BBHHFLFJCNL)
			{
				this.PANMNKKODPC.alpha = this.HFICFHBCJGH;
				endValue = this.KMNHLNIHKJF;
			}
			else
			{
				this.PANMNKKODPC.alpha = this.KMNHLNIHKJF;
				endValue = this.HFICFHBCJGH;
			}
		}
		else
		{
			this.PANMNKKODPC.alpha = this.KMNHLNIHKJF;
		}
		if (this.looped)
		{
			this.DENHGKHKLHF = this.PANMNKKODPC.DOFade(endValue, this.animationTime).SetEase(this.animationEase).OnComplete(new TweenCallback(this.IGLGJHKMPEG)).SetLoops(100000, this.cycleType);
			return;
		}
		if (this.cycleType != LoopType.Restart)
		{
			this.DENHGKHKLHF = this.PANMNKKODPC.DOFade(endValue, this.animationTime).SetEase(this.animationEase).OnComplete(new TweenCallback(this.IGLGJHKMPEG)).SetLoops(2, this.cycleType);
			return;
		}
		this.DENHGKHKLHF = this.PANMNKKODPC.DOFade(endValue, this.animationTime).SetEase(this.animationEase).OnComplete(new TweenCallback(this.IGLGJHKMPEG));
	}

	// Token: 0x06007657 RID: 30295 RVA: 0x00359E9C File Offset: 0x0035809C
	public void ODFEPCFMPJB(bool GEAPJFPNBIM = false)
	{
		if (null == this.PANMNKKODPC)
		{
			try
			{
				this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
			if (null == this.PANMNKKODPC)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("fvrt");
				return;
			}
		}
		if (GEAPJFPNBIM)
		{
			this.KMNHLNIHKJF = this.endAlpha;
			this.HFICFHBCJGH = this.startAlpha;
		}
		else
		{
			this.KMNHLNIHKJF = this.startAlpha;
			this.HFICFHBCJGH = this.endAlpha;
		}
		this.PANMNKKODPC.alpha = this.KMNHLNIHKJF;
	}

	// Token: 0x06007658 RID: 30296 RVA: 0x00359F40 File Offset: 0x00358140
	public bool APCBHBJKEME()
	{
		return this.DENHGKHKLHF != null && this.DENHGKHKLHF.IsComplete();
	}

	// Token: 0x06007659 RID: 30297 RVA: 0x00359F5C File Offset: 0x0035815C
	public void MKLBGNMEOHH(bool GEAPJFPNBIM = false)
	{
		if (null == this.PANMNKKODPC)
		{
			try
			{
				this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
			if (null == this.PANMNKKODPC)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Stripes opacity");
				return;
			}
		}
		if (GEAPJFPNBIM)
		{
			this.KMNHLNIHKJF = this.endAlpha;
			this.HFICFHBCJGH = this.startAlpha;
		}
		else
		{
			this.KMNHLNIHKJF = this.startAlpha;
			this.HFICFHBCJGH = this.endAlpha;
		}
		this.PANMNKKODPC.alpha = this.KMNHLNIHKJF;
	}

	// Token: 0x0600765A RID: 30298 RVA: 0x003589A4 File Offset: 0x00356BA4
	private void BHGOKICGBKO()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
		this.DENHGKHKLHF = null;
	}

	// Token: 0x0600765B RID: 30299 RVA: 0x00358E04 File Offset: 0x00357004
	public bool MMDIMCFBFGF()
	{
		return this.DENHGKHKLHF == null || this.DENHGKHKLHF.IsComplete();
	}

	// Token: 0x0600765C RID: 30300 RVA: 0x0035A000 File Offset: 0x00358200
	private void POCDJMKBPAK()
	{
		this.DCCKDJLAFPP = false;
		this.NIMLCJHAAHN = 1672f;
	}

	// Token: 0x0600765D RID: 30301 RVA: 0x0035A014 File Offset: 0x00358214
	public void EHGLPNPAHDC(bool IFJFCJGMAEG = false)
	{
		if (null == this.PANMNKKODPC)
		{
			try
			{
				this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			}
			if (null == this.PANMNKKODPC)
			{
				DPGJIJGOCIC.ANOPFDLPKGC(" ");
				return;
			}
		}
		this.HNJLPANEDFP = IFJFCJGMAEG;
		this.DCCKDJLAFPP = false;
		this.PANMNKKODPC.DOKill(false);
		float endValue = this.HFICFHBCJGH;
		if (this.LNGMMALCMPF)
		{
			if (this.BBHHFLFJCNL)
			{
				this.PANMNKKODPC.alpha = this.HFICFHBCJGH;
				endValue = this.KMNHLNIHKJF;
			}
			else
			{
				this.PANMNKKODPC.alpha = this.KMNHLNIHKJF;
				endValue = this.HFICFHBCJGH;
			}
		}
		else
		{
			this.PANMNKKODPC.alpha = this.KMNHLNIHKJF;
		}
		if (this.looped)
		{
			this.DENHGKHKLHF = this.PANMNKKODPC.DOFade(endValue, this.animationTime).SetEase(this.animationEase).OnComplete(new TweenCallback(this.EMOPHBIMFLI)).SetLoops(-92, this.cycleType);
			return;
		}
		if (this.cycleType != LoopType.Restart)
		{
			this.DENHGKHKLHF = this.PANMNKKODPC.DOFade(endValue, this.animationTime).SetEase(this.animationEase).OnComplete(new TweenCallback(this.MELPFEKINFG)).SetLoops(4, this.cycleType);
			return;
		}
		this.DENHGKHKLHF = this.PANMNKKODPC.DOFade(endValue, this.animationTime).SetEase(this.animationEase).OnComplete(new TweenCallback(this.LPPBMJLKGCB));
	}

	// Token: 0x0600765E RID: 30302 RVA: 0x0035A1B4 File Offset: 0x003583B4
	private void EMOPHBIMFLI()
	{
		if (this.HNJLPANEDFP || this.disableOnComplete)
		{
			base.gameObject.SetActive(true);
			return;
		}
		if (!this.repeatOnComplete)
		{
			this.NIMLCJHAAHN = 1622f;
			return;
		}
		if (this.JONEGFEOLKJ > 1)
		{
			this.DCCKDJLAFPP = true;
			this.NIMLCJHAAHN = this.repeatOnCompleteDelay;
			this.JONEGFEOLKJ -= 0;
		}
		else
		{
			this.NIMLCJHAAHN = 1978f;
		}
		if (this.flipAnimationOnComplete)
		{
			this.LNGMMALCMPF = false;
			this.BBHHFLFJCNL = this.BBHHFLFJCNL;
		}
	}

	// Token: 0x0600765F RID: 30303 RVA: 0x00358823 File Offset: 0x00356A23
	private void CDHHGBKGGDG()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06007660 RID: 30304 RVA: 0x0035A248 File Offset: 0x00358448
	public void FOLIHFAJOCP(bool GEAPJFPNBIM = false)
	{
		if (null == this.PANMNKKODPC)
		{
			try
			{
				this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			}
			if (null == this.PANMNKKODPC)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("ok");
				return;
			}
		}
		if (GEAPJFPNBIM)
		{
			this.KMNHLNIHKJF = this.endAlpha;
			this.HFICFHBCJGH = this.startAlpha;
		}
		else
		{
			this.KMNHLNIHKJF = this.startAlpha;
			this.HFICFHBCJGH = this.endAlpha;
		}
		this.PANMNKKODPC.alpha = this.KMNHLNIHKJF;
	}

	// Token: 0x06007661 RID: 30305 RVA: 0x0035A2EC File Offset: 0x003584EC
	private void Update()
	{
		if (this.DCCKDJLAFPP)
		{
			this.NIMLCJHAAHN -= Time.deltaTime;
			if (this.NIMLCJHAAHN < 0f)
			{
				this.JHGFOKOFMHB();
				this.PlayAnimation(false);
				return;
			}
		}
		else
		{
			this.DLAFBOCNONH -= Time.deltaTime;
			if (this.DLAFBOCNONH <= 0f)
			{
				this.DLAFBOCNONH = 10000000f;
				this.JHGFOKOFMHB();
				this.PlayAnimation(false);
			}
		}
	}

	// Token: 0x06007662 RID: 30306 RVA: 0x00359F40 File Offset: 0x00358140
	public bool EMHJFNHAGLO()
	{
		return this.DENHGKHKLHF != null && this.DENHGKHKLHF.IsComplete();
	}

	// Token: 0x06007663 RID: 30307 RVA: 0x00359CDF File Offset: 0x00357EDF
	public bool OMDDHIAGHOF()
	{
		return this.DENHGKHKLHF == null || !this.DENHGKHKLHF.IsComplete();
	}

	// Token: 0x06007664 RID: 30308 RVA: 0x00358823 File Offset: 0x00356A23
	private void HJMKOELKODM()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06007665 RID: 30309 RVA: 0x00358E04 File Offset: 0x00357004
	public bool HDOJNNHHNND()
	{
		return this.DENHGKHKLHF == null || this.DENHGKHKLHF.IsComplete();
	}

	// Token: 0x06007666 RID: 30310 RVA: 0x0035A368 File Offset: 0x00358568
	private void DHNDICIEGEE()
	{
		this.JONEGFEOLKJ = this.repeatTimes;
		this.PLHKMIGGEHB(true);
		this.LNGMMALCMPF = false;
		this.BBHHFLFJCNL = false;
		if (this.playOnEnable)
		{
			this.DLAFBOCNONH = this.delayAtStart;
		}
		else
		{
			this.DLAFBOCNONH = 1890f;
		}
		this.POCDJMKBPAK();
		this.GPOPCNMGNGD();
	}

	// Token: 0x06007667 RID: 30311 RVA: 0x0035A3C4 File Offset: 0x003585C4
	private void NIKBFENFMID()
	{
		this.JONEGFEOLKJ = this.repeatTimes;
		this.BPCOKLEABJD(true);
		this.LNGMMALCMPF = true;
		this.BBHHFLFJCNL = true;
		if (this.playOnEnable)
		{
			this.DLAFBOCNONH = this.delayAtStart;
		}
		else
		{
			this.DLAFBOCNONH = 618f;
		}
		this.JHGFOKOFMHB();
		this.IPLDJLJCPLL();
	}

	// Token: 0x06007668 RID: 30312 RVA: 0x00358823 File Offset: 0x00356A23
	private void JIMHOEENAFI()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06007669 RID: 30313 RVA: 0x00358E1E File Offset: 0x0035701E
	public bool NLHJAABGPHH()
	{
		return this.DENHGKHKLHF != null && !this.DENHGKHKLHF.IsComplete();
	}

	// Token: 0x0600766A RID: 30314 RVA: 0x0035A420 File Offset: 0x00358620
	public void DGKOHLKMEEC(bool GEAPJFPNBIM = false)
	{
		if (null == this.PANMNKKODPC)
		{
			try
			{
				this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
			if (null == this.PANMNKKODPC)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("importanttitle");
				return;
			}
		}
		if (GEAPJFPNBIM)
		{
			this.KMNHLNIHKJF = this.endAlpha;
			this.HFICFHBCJGH = this.startAlpha;
		}
		else
		{
			this.KMNHLNIHKJF = this.startAlpha;
			this.HFICFHBCJGH = this.endAlpha;
		}
		this.PANMNKKODPC.alpha = this.KMNHLNIHKJF;
	}

	// Token: 0x0600766B RID: 30315 RVA: 0x00358823 File Offset: 0x00356A23
	private void PKJBCFKMGHE()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x0600766C RID: 30316 RVA: 0x00358823 File Offset: 0x00356A23
	private void Awake()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x0600766D RID: 30317 RVA: 0x0035A4C4 File Offset: 0x003586C4
	public void IFBEGMNMGMP(bool IFJFCJGMAEG = false)
	{
		if (null == this.PANMNKKODPC)
		{
			try
			{
				this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
			if (null == this.PANMNKKODPC)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("length");
				return;
			}
		}
		this.HNJLPANEDFP = IFJFCJGMAEG;
		this.DCCKDJLAFPP = false;
		this.PANMNKKODPC.DOKill(false);
		float endValue = this.HFICFHBCJGH;
		if (this.LNGMMALCMPF)
		{
			if (this.BBHHFLFJCNL)
			{
				this.PANMNKKODPC.alpha = this.HFICFHBCJGH;
				endValue = this.KMNHLNIHKJF;
			}
			else
			{
				this.PANMNKKODPC.alpha = this.KMNHLNIHKJF;
				endValue = this.HFICFHBCJGH;
			}
		}
		else
		{
			this.PANMNKKODPC.alpha = this.KMNHLNIHKJF;
		}
		if (this.looped)
		{
			this.DENHGKHKLHF = this.PANMNKKODPC.DOFade(endValue, this.animationTime).SetEase(this.animationEase).OnComplete(new TweenCallback(this.EMOPHBIMFLI)).SetLoops(-153, this.cycleType);
			return;
		}
		if (this.cycleType != LoopType.Restart)
		{
			this.DENHGKHKLHF = this.PANMNKKODPC.DOFade(endValue, this.animationTime).SetEase(this.animationEase).OnComplete(new TweenCallback(this.LPPBMJLKGCB)).SetLoops(4, this.cycleType);
			return;
		}
		this.DENHGKHKLHF = this.PANMNKKODPC.DOFade(endValue, this.animationTime).SetEase(this.animationEase).OnComplete(new TweenCallback(this.IGLGJHKMPEG));
	}

	// Token: 0x0600766E RID: 30318 RVA: 0x0035A664 File Offset: 0x00358864
	private void GPOPCNMGNGD()
	{
		if (this.DCCKDJLAFPP)
		{
			this.NIMLCJHAAHN -= Time.deltaTime;
			if (this.NIMLCJHAAHN < 1553f)
			{
				this.POCDJMKBPAK();
				this.CHOGMCMNIKA(true);
				return;
			}
		}
		else
		{
			this.DLAFBOCNONH -= Time.deltaTime;
			if (this.DLAFBOCNONH <= 709f)
			{
				this.DLAFBOCNONH = 480f;
				this.BEDPNJBGGEB();
				this.EHGLPNPAHDC(false);
			}
		}
	}

	// Token: 0x0600766F RID: 30319 RVA: 0x0035A6E0 File Offset: 0x003588E0
	public void PGKFNLNMIHN(bool IFJFCJGMAEG = false)
	{
		if (null == this.PANMNKKODPC)
		{
			try
			{
				this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
			if (null == this.PANMNKKODPC)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("avatarstitle");
				return;
			}
		}
		this.HNJLPANEDFP = IFJFCJGMAEG;
		this.DCCKDJLAFPP = true;
		this.PANMNKKODPC.DOKill(false);
		float endValue = this.HFICFHBCJGH;
		if (this.LNGMMALCMPF)
		{
			if (this.BBHHFLFJCNL)
			{
				this.PANMNKKODPC.alpha = this.HFICFHBCJGH;
				endValue = this.KMNHLNIHKJF;
			}
			else
			{
				this.PANMNKKODPC.alpha = this.KMNHLNIHKJF;
				endValue = this.HFICFHBCJGH;
			}
		}
		else
		{
			this.PANMNKKODPC.alpha = this.KMNHLNIHKJF;
		}
		if (this.looped)
		{
			this.DENHGKHKLHF = this.PANMNKKODPC.DOFade(endValue, this.animationTime).SetEase(this.animationEase).OnComplete(new TweenCallback(this.EMOPHBIMFLI)).SetLoops(-176, this.cycleType);
			return;
		}
		if (this.cycleType != LoopType.Restart)
		{
			this.DENHGKHKLHF = this.PANMNKKODPC.DOFade(endValue, this.animationTime).SetEase(this.animationEase).OnComplete(new TweenCallback(this.EMOPHBIMFLI)).SetLoops(2, this.cycleType);
			return;
		}
		this.DENHGKHKLHF = this.PANMNKKODPC.DOFade(endValue, this.animationTime).SetEase(this.animationEase).OnComplete(new TweenCallback(this.LPPBMJLKGCB));
	}

	// Token: 0x06007670 RID: 30320 RVA: 0x003589A4 File Offset: 0x00356BA4
	private void OnDisable()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
		this.DENHGKHKLHF = null;
	}

	// Token: 0x06007671 RID: 30321 RVA: 0x003589A4 File Offset: 0x00356BA4
	private void INODDOOLMMB()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
		this.DENHGKHKLHF = null;
	}

	// Token: 0x06007672 RID: 30322 RVA: 0x0035A880 File Offset: 0x00358A80
	private void EAABCAMGPKG()
	{
		if (this.HNJLPANEDFP || this.disableOnComplete)
		{
			base.gameObject.SetActive(true);
			return;
		}
		if (!this.repeatOnComplete)
		{
			this.NIMLCJHAAHN = 1915f;
			return;
		}
		if (this.JONEGFEOLKJ > 1)
		{
			this.DCCKDJLAFPP = false;
			this.NIMLCJHAAHN = this.repeatOnCompleteDelay;
			this.JONEGFEOLKJ--;
		}
		else
		{
			this.NIMLCJHAAHN = 1514f;
		}
		if (this.flipAnimationOnComplete)
		{
			this.LNGMMALCMPF = false;
			this.BBHHFLFJCNL = this.BBHHFLFJCNL;
		}
	}

	// Token: 0x06007673 RID: 30323 RVA: 0x0035A914 File Offset: 0x00358B14
	private void OPAPLDKCLPO()
	{
		if (this.DCCKDJLAFPP)
		{
			this.NIMLCJHAAHN -= Time.deltaTime;
			if (this.NIMLCJHAAHN < 511f)
			{
				this.KAAEMJNFDGJ();
				this.CHOGMCMNIKA(true);
				return;
			}
		}
		else
		{
			this.DLAFBOCNONH -= Time.deltaTime;
			if (this.DLAFBOCNONH <= 1564f)
			{
				this.DLAFBOCNONH = 52f;
				this.BEDPNJBGGEB();
				this.EHGLPNPAHDC(true);
			}
		}
	}

	// Token: 0x06007674 RID: 30324 RVA: 0x0035A98D File Offset: 0x00358B8D
	private void OLBFHAEICAC()
	{
		this.DCCKDJLAFPP = true;
		this.NIMLCJHAAHN = 1265f;
	}

	// Token: 0x06007675 RID: 30325 RVA: 0x0035A9A4 File Offset: 0x00358BA4
	public void MPICIBINNCP(bool IFJFCJGMAEG = false)
	{
		if (null == this.PANMNKKODPC)
		{
			try
			{
				this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			}
			if (null == this.PANMNKKODPC)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("no");
				return;
			}
		}
		this.HNJLPANEDFP = IFJFCJGMAEG;
		this.DCCKDJLAFPP = true;
		this.PANMNKKODPC.DOKill(false);
		float endValue = this.HFICFHBCJGH;
		if (this.LNGMMALCMPF)
		{
			if (this.BBHHFLFJCNL)
			{
				this.PANMNKKODPC.alpha = this.HFICFHBCJGH;
				endValue = this.KMNHLNIHKJF;
			}
			else
			{
				this.PANMNKKODPC.alpha = this.KMNHLNIHKJF;
				endValue = this.HFICFHBCJGH;
			}
		}
		else
		{
			this.PANMNKKODPC.alpha = this.KMNHLNIHKJF;
		}
		if (this.looped)
		{
			this.DENHGKHKLHF = this.PANMNKKODPC.DOFade(endValue, this.animationTime).SetEase(this.animationEase).OnComplete(new TweenCallback(this.LPPBMJLKGCB)).SetLoops(-54, this.cycleType);
			return;
		}
		if (this.cycleType != LoopType.Restart)
		{
			this.DENHGKHKLHF = this.PANMNKKODPC.DOFade(endValue, this.animationTime).SetEase(this.animationEase).OnComplete(new TweenCallback(this.EMOPHBIMFLI)).SetLoops(5, this.cycleType);
			return;
		}
		this.DENHGKHKLHF = this.PANMNKKODPC.DOFade(endValue, this.animationTime).SetEase(this.animationEase).OnComplete(new TweenCallback(this.IGLGJHKMPEG));
	}

	// Token: 0x06007676 RID: 30326 RVA: 0x0035AB44 File Offset: 0x00358D44
	public void HAEAIGMGGOA(bool GEAPJFPNBIM = false)
	{
		if (null == this.PANMNKKODPC)
		{
			try
			{
				this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
			if (null == this.PANMNKKODPC)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("apks1");
				return;
			}
		}
		if (GEAPJFPNBIM)
		{
			this.KMNHLNIHKJF = this.endAlpha;
			this.HFICFHBCJGH = this.startAlpha;
		}
		else
		{
			this.KMNHLNIHKJF = this.startAlpha;
			this.HFICFHBCJGH = this.endAlpha;
		}
		this.PANMNKKODPC.alpha = this.KMNHLNIHKJF;
	}

	// Token: 0x06007677 RID: 30327 RVA: 0x00358E1E File Offset: 0x0035701E
	public bool CIIMDLIFCNL()
	{
		return this.DENHGKHKLHF != null && !this.DENHGKHKLHF.IsComplete();
	}

	// Token: 0x040022F0 RID: 8944
	public Ease animationEase = Ease.OutQuad;

	// Token: 0x040022F1 RID: 8945
	public float animationTime = 1f;

	// Token: 0x040022F2 RID: 8946
	public float startAlpha;

	// Token: 0x040022F3 RID: 8947
	public float endAlpha;

	// Token: 0x040022F4 RID: 8948
	public bool looped;

	// Token: 0x040022F5 RID: 8949
	public LoopType cycleType;

	// Token: 0x040022F6 RID: 8950
	public bool repeatOnComplete;

	// Token: 0x040022F7 RID: 8951
	public float repeatOnCompleteDelay = 1f;

	// Token: 0x040022F8 RID: 8952
	public int repeatTimes = 1000000;

	// Token: 0x040022F9 RID: 8953
	public float delayAtStart;

	// Token: 0x040022FA RID: 8954
	public bool playOnEnable = true;

	// Token: 0x040022FB RID: 8955
	public bool disableOnComplete;

	// Token: 0x040022FC RID: 8956
	public bool flipAnimationOnComplete;

	// Token: 0x040022FD RID: 8957
	private CanvasGroup PANMNKKODPC;

	// Token: 0x040022FE RID: 8958
	private float NIMLCJHAAHN = -1f;

	// Token: 0x040022FF RID: 8959
	private float DLAFBOCNONH;

	// Token: 0x04002300 RID: 8960
	private bool DCCKDJLAFPP;

	// Token: 0x04002301 RID: 8961
	private float KMNHLNIHKJF;

	// Token: 0x04002302 RID: 8962
	private float HFICFHBCJGH;

	// Token: 0x04002303 RID: 8963
	private bool HNJLPANEDFP;

	// Token: 0x04002304 RID: 8964
	private int JONEGFEOLKJ;

	// Token: 0x04002305 RID: 8965
	private bool LNGMMALCMPF;

	// Token: 0x04002306 RID: 8966
	private bool BBHHFLFJCNL;

	// Token: 0x04002307 RID: 8967
	private Tweener DENHGKHKLHF;
}
