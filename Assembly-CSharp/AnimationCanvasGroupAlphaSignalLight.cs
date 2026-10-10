using System;
using System.Collections;
using UnityEngine;

// Token: 0x02000151 RID: 337
[ExecuteInEditMode]
public class AnimationCanvasGroupAlphaSignalLight : MonoBehaviour
{
	// Token: 0x06002C87 RID: 11399 RVA: 0x00138D61 File Offset: 0x00136F61
	private void GMPHANBKGBK()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.DDGJDNLINFI = this.timeOffsetAtStart;
	}

	// Token: 0x06002C88 RID: 11400 RVA: 0x00138D80 File Offset: 0x00136F80
	private void EFIBBLFAMGD()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1286f;
			this.timeOffsetAtStart = this.DDGJDNLINFI;
			this.GLCDOCAPLHJ = base.StartCoroutine(this.IDAKBODNEPK());
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("length");
	}

	// Token: 0x06002C89 RID: 11401 RVA: 0x00138DD4 File Offset: 0x00136FD4
	private void FBACIBOFHJO()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 734f;
			this.timeOffsetAtStart = this.DDGJDNLINFI;
			this.GLCDOCAPLHJ = base.StartCoroutine(this.GFCMDIDKMHO());
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("%>");
	}

	// Token: 0x06002C8A RID: 11402 RVA: 0x00138D61 File Offset: 0x00136F61
	private void KBIIMONICOB()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.DDGJDNLINFI = this.timeOffsetAtStart;
	}

	// Token: 0x06002C8B RID: 11403 RVA: 0x00138D61 File Offset: 0x00136F61
	private void AMNBHDNALGO()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.DDGJDNLINFI = this.timeOffsetAtStart;
	}

	// Token: 0x06002C8C RID: 11404 RVA: 0x00138D61 File Offset: 0x00136F61
	private void OPBNOGLBNDK()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.DDGJDNLINFI = this.timeOffsetAtStart;
	}

	// Token: 0x06002C8D RID: 11405 RVA: 0x00138D61 File Offset: 0x00136F61
	private void EGMHPEFIOIC()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.DDGJDNLINFI = this.timeOffsetAtStart;
	}

	// Token: 0x06002C8E RID: 11406 RVA: 0x00138E28 File Offset: 0x00137028
	private void HMGJEJODDDE()
	{
		if (this.GLCDOCAPLHJ != null)
		{
			base.StopCoroutine(this.GLCDOCAPLHJ);
		}
		this.GLCDOCAPLHJ = null;
	}

	// Token: 0x06002C8F RID: 11407 RVA: 0x00138E45 File Offset: 0x00137045
	private IEnumerator IDAKBODNEPK()
	{
		AnimationCanvasGroupAlphaSignalLight.FLBBHJKLCOH flbbhjklcoh = new AnimationCanvasGroupAlphaSignalLight.FLBBHJKLCOH(1);
		flbbhjklcoh.<>4__this = this;
		return flbbhjklcoh;
	}

	// Token: 0x06002C90 RID: 11408 RVA: 0x00138E54 File Offset: 0x00137054
	private IEnumerator CBCGLCHICIJ()
	{
		int signalCounter = 0;
		float timeBetweenSignals = Mathf.Abs(this.timeUpdateInterval - this.lightTimelifeAtEnd) / (float)this.signals;
		yield return new WaitForSeconds(this.timeOffsetAtStart);
		while (signalCounter < this.signals)
		{
			this.PANMNKKODPC.alpha = 1f;
			yield return new WaitForSeconds(timeBetweenSignals);
			this.PANMNKKODPC.alpha = 0f;
			yield return new WaitForSeconds(timeBetweenSignals);
			int num = signalCounter;
			signalCounter = num + 1;
		}
		signalCounter = 0;
		this.PANMNKKODPC.alpha = 1f;
		yield return new WaitForSeconds(this.lightTimelifeAtEnd);
		if (base.gameObject.activeSelf)
		{
			this.timeOffsetAtStart = 0f;
			yield return base.StartCoroutine(this.DFLOOPAJOIK());
		}
		yield break;
	}

	// Token: 0x06002C91 RID: 11409 RVA: 0x00138E54 File Offset: 0x00137054
	private IEnumerator GEIPPGAHADH()
	{
		signalCounter = 0;
		timeBetweenSignals = Mathf.Abs(this.timeUpdateInterval - this.lightTimelifeAtEnd) / (float)this.signals;
		yield return new WaitForSeconds(this.timeOffsetAtStart);
		while (signalCounter < this.signals)
		{
			this.PANMNKKODPC.alpha = 1f;
			yield return new WaitForSeconds(timeBetweenSignals);
			this.PANMNKKODPC.alpha = 0f;
			yield return new WaitForSeconds(timeBetweenSignals);
			int num = signalCounter;
			signalCounter = num + 1;
		}
		signalCounter = 0;
		this.PANMNKKODPC.alpha = 1f;
		yield return new WaitForSeconds(this.lightTimelifeAtEnd);
		if (base.gameObject.activeSelf)
		{
			this.timeOffsetAtStart = 0f;
			yield return base.StartCoroutine(this.DFLOOPAJOIK());
		}
		yield break;
	}

	// Token: 0x06002C92 RID: 11410 RVA: 0x00138E64 File Offset: 0x00137064
	private void JLCMPGICMDC()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 297f;
			this.timeOffsetAtStart = this.DDGJDNLINFI;
			this.GLCDOCAPLHJ = base.StartCoroutine(this.IDAKBODNEPK());
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("socialrequestwarnyou");
	}

	// Token: 0x06002C93 RID: 11411 RVA: 0x00138E54 File Offset: 0x00137054
	private IEnumerator GFCMDIDKMHO()
	{
		signalCounter = 0;
		timeBetweenSignals = Mathf.Abs(this.timeUpdateInterval - this.lightTimelifeAtEnd) / (float)this.signals;
		yield return new WaitForSeconds(this.timeOffsetAtStart);
		while (signalCounter < this.signals)
		{
			this.PANMNKKODPC.alpha = 1f;
			yield return new WaitForSeconds(timeBetweenSignals);
			this.PANMNKKODPC.alpha = 0f;
			yield return new WaitForSeconds(timeBetweenSignals);
			int num = signalCounter;
			signalCounter = num + 1;
		}
		signalCounter = 0;
		this.PANMNKKODPC.alpha = 1f;
		yield return new WaitForSeconds(this.lightTimelifeAtEnd);
		if (base.gameObject.activeSelf)
		{
			this.timeOffsetAtStart = 0f;
			yield return base.StartCoroutine(this.DFLOOPAJOIK());
		}
		yield break;
	}

	// Token: 0x06002C94 RID: 11412 RVA: 0x00138EB8 File Offset: 0x001370B8
	private void ALBKMBOKICH()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1312f;
			this.timeOffsetAtStart = this.DDGJDNLINFI;
			this.GLCDOCAPLHJ = base.StartCoroutine(this.ABFOJLIAMOC());
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("OnSocialModeChanged");
	}

	// Token: 0x06002C95 RID: 11413 RVA: 0x00138D61 File Offset: 0x00136F61
	private void Awake()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.DDGJDNLINFI = this.timeOffsetAtStart;
	}

	// Token: 0x06002C96 RID: 11414 RVA: 0x00138E45 File Offset: 0x00137045
	private IEnumerator ABFOJLIAMOC()
	{
		AnimationCanvasGroupAlphaSignalLight.FLBBHJKLCOH flbbhjklcoh = new AnimationCanvasGroupAlphaSignalLight.FLBBHJKLCOH(1);
		flbbhjklcoh.<>4__this = this;
		return flbbhjklcoh;
	}

	// Token: 0x06002C97 RID: 11415 RVA: 0x00138F0C File Offset: 0x0013710C
	private void PADHAHCNFNM()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 650f;
			this.timeOffsetAtStart = this.DDGJDNLINFI;
			this.GLCDOCAPLHJ = base.StartCoroutine(this.GFCMDIDKMHO());
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("OnSketchThumbnailPlay");
	}

	// Token: 0x06002C98 RID: 11416 RVA: 0x00138E54 File Offset: 0x00137054
	private IEnumerator JLHHJLPDDEG()
	{
		signalCounter = 0;
		timeBetweenSignals = Mathf.Abs(this.timeUpdateInterval - this.lightTimelifeAtEnd) / (float)this.signals;
		yield return new WaitForSeconds(this.timeOffsetAtStart);
		while (signalCounter < this.signals)
		{
			this.PANMNKKODPC.alpha = 1f;
			yield return new WaitForSeconds(timeBetweenSignals);
			this.PANMNKKODPC.alpha = 0f;
			yield return new WaitForSeconds(timeBetweenSignals);
			int num = signalCounter;
			signalCounter = num + 1;
		}
		signalCounter = 0;
		this.PANMNKKODPC.alpha = 1f;
		yield return new WaitForSeconds(this.lightTimelifeAtEnd);
		if (base.gameObject.activeSelf)
		{
			this.timeOffsetAtStart = 0f;
			yield return base.StartCoroutine(this.DFLOOPAJOIK());
		}
		yield break;
	}

	// Token: 0x06002C99 RID: 11417 RVA: 0x00138D61 File Offset: 0x00136F61
	private void LDDEIAOCBGB()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.DDGJDNLINFI = this.timeOffsetAtStart;
	}

	// Token: 0x06002C9A RID: 11418 RVA: 0x00138E28 File Offset: 0x00137028
	private void LGLMMPEJIHH()
	{
		if (this.GLCDOCAPLHJ != null)
		{
			base.StopCoroutine(this.GLCDOCAPLHJ);
		}
		this.GLCDOCAPLHJ = null;
	}

	// Token: 0x06002C9B RID: 11419 RVA: 0x00138E28 File Offset: 0x00137028
	private void CNEGBHKEMPL()
	{
		if (this.GLCDOCAPLHJ != null)
		{
			base.StopCoroutine(this.GLCDOCAPLHJ);
		}
		this.GLCDOCAPLHJ = null;
	}

	// Token: 0x06002C9C RID: 11420 RVA: 0x00138D61 File Offset: 0x00136F61
	private void JFFNFDKBMGP()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.DDGJDNLINFI = this.timeOffsetAtStart;
	}

	// Token: 0x06002C9D RID: 11421 RVA: 0x00138F60 File Offset: 0x00137160
	private void LDLLCBDGGHN()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1490f;
			this.timeOffsetAtStart = this.DDGJDNLINFI;
			this.GLCDOCAPLHJ = base.StartCoroutine(this.GFCMDIDKMHO());
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("saveslotstitleempty");
	}

	// Token: 0x06002C9E RID: 11422 RVA: 0x00138E45 File Offset: 0x00137045
	private IEnumerator EFFAAFDGKCN()
	{
		AnimationCanvasGroupAlphaSignalLight.FLBBHJKLCOH flbbhjklcoh = new AnimationCanvasGroupAlphaSignalLight.FLBBHJKLCOH(1);
		flbbhjklcoh.<>4__this = this;
		return flbbhjklcoh;
	}

	// Token: 0x06002C9F RID: 11423 RVA: 0x00138FB4 File Offset: 0x001371B4
	private void KHOLJLKNAPJ()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 432f;
			this.timeOffsetAtStart = this.DDGJDNLINFI;
			this.GLCDOCAPLHJ = base.StartCoroutine(this.PMPHAHMBPCC());
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("flame");
	}

	// Token: 0x06002CA0 RID: 11424 RVA: 0x00138D61 File Offset: 0x00136F61
	private void OPPNHGEMHAB()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.DDGJDNLINFI = this.timeOffsetAtStart;
	}

	// Token: 0x06002CA1 RID: 11425 RVA: 0x00138E28 File Offset: 0x00137028
	private void DNLGACANBLN()
	{
		if (this.GLCDOCAPLHJ != null)
		{
			base.StopCoroutine(this.GLCDOCAPLHJ);
		}
		this.GLCDOCAPLHJ = null;
	}

	// Token: 0x06002CA2 RID: 11426 RVA: 0x00138E54 File Offset: 0x00137054
	private IEnumerator DFLOOPAJOIK()
	{
		signalCounter = 0;
		timeBetweenSignals = Mathf.Abs(this.timeUpdateInterval - this.lightTimelifeAtEnd) / (float)this.signals;
		yield return new WaitForSeconds(this.timeOffsetAtStart);
		while (signalCounter < this.signals)
		{
			this.PANMNKKODPC.alpha = 1f;
			yield return new WaitForSeconds(timeBetweenSignals);
			this.PANMNKKODPC.alpha = 0f;
			yield return new WaitForSeconds(timeBetweenSignals);
			int num = signalCounter;
			signalCounter = num + 1;
		}
		signalCounter = 0;
		this.PANMNKKODPC.alpha = 1f;
		yield return new WaitForSeconds(this.lightTimelifeAtEnd);
		if (base.gameObject.activeSelf)
		{
			this.timeOffsetAtStart = 0f;
			yield return base.StartCoroutine(this.DFLOOPAJOIK());
		}
		yield break;
	}

	// Token: 0x06002CA3 RID: 11427 RVA: 0x00138E28 File Offset: 0x00137028
	private void AIGAAPBGLMN()
	{
		if (this.GLCDOCAPLHJ != null)
		{
			base.StopCoroutine(this.GLCDOCAPLHJ);
		}
		this.GLCDOCAPLHJ = null;
	}

	// Token: 0x06002CA4 RID: 11428 RVA: 0x00138E28 File Offset: 0x00137028
	private void NINHFENBENF()
	{
		if (this.GLCDOCAPLHJ != null)
		{
			base.StopCoroutine(this.GLCDOCAPLHJ);
		}
		this.GLCDOCAPLHJ = null;
	}

	// Token: 0x06002CA5 RID: 11429 RVA: 0x00138D61 File Offset: 0x00136F61
	private void HGEODIPIBPG()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.DDGJDNLINFI = this.timeOffsetAtStart;
	}

	// Token: 0x06002CA6 RID: 11430 RVA: 0x00138E28 File Offset: 0x00137028
	private void OnDisable()
	{
		if (this.GLCDOCAPLHJ != null)
		{
			base.StopCoroutine(this.GLCDOCAPLHJ);
		}
		this.GLCDOCAPLHJ = null;
	}

	// Token: 0x06002CA7 RID: 11431 RVA: 0x00138D61 File Offset: 0x00136F61
	private void CDHHGBKGGDG()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.DDGJDNLINFI = this.timeOffsetAtStart;
	}

	// Token: 0x06002CA8 RID: 11432 RVA: 0x00138E28 File Offset: 0x00137028
	private void OKKPNPECJKH()
	{
		if (this.GLCDOCAPLHJ != null)
		{
			base.StopCoroutine(this.GLCDOCAPLHJ);
		}
		this.GLCDOCAPLHJ = null;
	}

	// Token: 0x06002CA9 RID: 11433 RVA: 0x00138E28 File Offset: 0x00137028
	private void GBIDDHNBECB()
	{
		if (this.GLCDOCAPLHJ != null)
		{
			base.StopCoroutine(this.GLCDOCAPLHJ);
		}
		this.GLCDOCAPLHJ = null;
	}

	// Token: 0x06002CAA RID: 11434 RVA: 0x00139008 File Offset: 0x00137208
	private void IJMPLMMFIEP()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 2f;
			this.timeOffsetAtStart = this.DDGJDNLINFI;
			this.GLCDOCAPLHJ = base.StartCoroutine(this.GFCMDIDKMHO());
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("\f");
	}

	// Token: 0x06002CAB RID: 11435 RVA: 0x00138E28 File Offset: 0x00137028
	private void EBEGEDOJCLC()
	{
		if (this.GLCDOCAPLHJ != null)
		{
			base.StopCoroutine(this.GLCDOCAPLHJ);
		}
		this.GLCDOCAPLHJ = null;
	}

	// Token: 0x06002CAC RID: 11436 RVA: 0x00138E54 File Offset: 0x00137054
	private IEnumerator PMPHAHMBPCC()
	{
		signalCounter = 0;
		timeBetweenSignals = Mathf.Abs(this.timeUpdateInterval - this.lightTimelifeAtEnd) / (float)this.signals;
		yield return new WaitForSeconds(this.timeOffsetAtStart);
		while (signalCounter < this.signals)
		{
			this.PANMNKKODPC.alpha = 1f;
			yield return new WaitForSeconds(timeBetweenSignals);
			this.PANMNKKODPC.alpha = 0f;
			yield return new WaitForSeconds(timeBetweenSignals);
			int num = signalCounter;
			signalCounter = num + 1;
		}
		signalCounter = 0;
		this.PANMNKKODPC.alpha = 1f;
		yield return new WaitForSeconds(this.lightTimelifeAtEnd);
		if (base.gameObject.activeSelf)
		{
			this.timeOffsetAtStart = 0f;
			yield return base.StartCoroutine(this.DFLOOPAJOIK());
		}
		yield break;
	}

	// Token: 0x06002CAD RID: 11437 RVA: 0x0013905C File Offset: 0x0013725C
	private void DJDLHIOMGJB()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 360f;
			this.timeOffsetAtStart = this.DDGJDNLINFI;
			this.GLCDOCAPLHJ = base.StartCoroutine(this.JLHHJLPDDEG());
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("OnFullscreenCardOptionClick");
	}

	// Token: 0x06002CAE RID: 11438 RVA: 0x001390B0 File Offset: 0x001372B0
	private void OnEnable()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 0f;
			this.timeOffsetAtStart = this.DDGJDNLINFI;
			this.GLCDOCAPLHJ = base.StartCoroutine(this.DFLOOPAJOIK());
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("Forgot to attach a CanvasGroup script to game object before using AnimationCanvasGroupAlphaSignalLight?");
	}

	// Token: 0x04000D2E RID: 3374
	public int signals = 3;

	// Token: 0x04000D2F RID: 3375
	public float timeOffsetAtStart = 2f;

	// Token: 0x04000D30 RID: 3376
	public float lightTimelifeAtEnd = 2f;

	// Token: 0x04000D31 RID: 3377
	public float timeUpdateInterval = 3f;

	// Token: 0x04000D32 RID: 3378
	private CanvasGroup PANMNKKODPC;

	// Token: 0x04000D33 RID: 3379
	private float DDGJDNLINFI;

	// Token: 0x04000D34 RID: 3380
	private Coroutine GLCDOCAPLHJ;
}
