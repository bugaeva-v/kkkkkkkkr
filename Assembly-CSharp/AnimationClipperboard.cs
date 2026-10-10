using System;
using System.Collections;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020003E2 RID: 994
public class AnimationClipperboard : MonoBehaviour
{
	// Token: 0x060072AB RID: 29355 RVA: 0x0033A2AE File Offset: 0x003384AE
	private void JPPBJKKNIED()
	{
		if (null != this.DGAAFGDHHHJ)
		{
			this.DGAAFGDHHHJ.DOKill(false);
		}
	}

	// Token: 0x060072AC RID: 29356 RVA: 0x0033A2CB File Offset: 0x003384CB
	private void KDHJKIJKBMN()
	{
		this.ADEMLNLMNBD = base.gameObject.GetComponent<Image>();
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
	}

	// Token: 0x060072AD RID: 29357 RVA: 0x0033A2CB File Offset: 0x003384CB
	private void AALDINEPEHJ()
	{
		this.ADEMLNLMNBD = base.gameObject.GetComponent<Image>();
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
	}

	// Token: 0x060072AE RID: 29358 RVA: 0x00003E52 File Offset: 0x00002052
	private void OKBABBBHMIP()
	{
	}

	// Token: 0x060072AF RID: 29359 RVA: 0x0033A300 File Offset: 0x00338500
	private IEnumerator ECDILLNILIP()
	{
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2((float)this.translationAmount, 0f), this.animationTime * 0.1f, false).SetEase(Ease.OutQuad);
		yield return new WaitForSeconds(this.animationTime * 0.5f);
		if (this.sfxId != null && this.sfxId.Length > 0)
		{
			AudioManager.EHBBFMCILPC.PlaySfx(this.sfxId, false);
		}
		this.ADEMLNLMNBD.sprite = this.closedState;
		yield return new WaitForSeconds(this.animationTime * 0.3f);
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2((float)(-(float)this.translationAmount), 0f), this.animationTime * 0.1f, false).SetEase(Ease.OutQuad);
		yield break;
	}

	// Token: 0x060072B0 RID: 29360 RVA: 0x00003E52 File Offset: 0x00002052
	private void JLCMPLIMAEI()
	{
	}

	// Token: 0x060072B1 RID: 29361 RVA: 0x0033A300 File Offset: 0x00338500
	private IEnumerator CADADPHKADJ()
	{
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2((float)this.translationAmount, 0f), this.animationTime * 0.1f, false).SetEase(Ease.OutQuad);
		yield return new WaitForSeconds(this.animationTime * 0.5f);
		if (this.sfxId != null && this.sfxId.Length > 0)
		{
			AudioManager.EHBBFMCILPC.PlaySfx(this.sfxId, false);
		}
		this.ADEMLNLMNBD.sprite = this.closedState;
		yield return new WaitForSeconds(this.animationTime * 0.3f);
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2((float)(-(float)this.translationAmount), 0f), this.animationTime * 0.1f, false).SetEase(Ease.OutQuad);
		yield break;
	}

	// Token: 0x060072B2 RID: 29362 RVA: 0x0033A30F File Offset: 0x0033850F
	private IEnumerator FNNJAFDDBHH()
	{
		AnimationClipperboard.PGOJLDBKDGJ pgojldbkdgj = new AnimationClipperboard.PGOJLDBKDGJ(1);
		pgojldbkdgj.<>4__this = this;
		return pgojldbkdgj;
	}

	// Token: 0x060072B3 RID: 29363 RVA: 0x0033A320 File Offset: 0x00338520
	private void EDANCCNNDMN()
	{
		this.ADEMLNLMNBD.sprite = this.openState;
		this.DGAAFGDHHHJ.OGOFACPLOGO((int)this.HCOLPEBENOF.x, (int)this.HCOLPEBENOF.y);
		base.StartCoroutine(this.CADADPHKADJ());
	}

	// Token: 0x060072B4 RID: 29364 RVA: 0x00003E52 File Offset: 0x00002052
	private void AOIJOKHACJL()
	{
	}

	// Token: 0x060072B5 RID: 29365 RVA: 0x0033A30F File Offset: 0x0033850F
	private IEnumerator MNDGJFCNIGO()
	{
		AnimationClipperboard.PGOJLDBKDGJ pgojldbkdgj = new AnimationClipperboard.PGOJLDBKDGJ(1);
		pgojldbkdgj.<>4__this = this;
		return pgojldbkdgj;
	}

	// Token: 0x060072B6 RID: 29366 RVA: 0x0033A370 File Offset: 0x00338570
	private void OnEnable()
	{
		this.ADEMLNLMNBD.sprite = this.openState;
		this.DGAAFGDHHHJ.OGOFACPLOGO((int)this.HCOLPEBENOF.x, (int)this.HCOLPEBENOF.y);
		base.StartCoroutine(this.LAKIJEGLFHJ());
	}

	// Token: 0x060072B7 RID: 29367 RVA: 0x0033A3BE File Offset: 0x003385BE
	private void GOKDPNLEJBE()
	{
		if (null != this.DGAAFGDHHHJ)
		{
			this.DGAAFGDHHHJ.DOKill(true);
		}
	}

	// Token: 0x060072B8 RID: 29368 RVA: 0x0033A3BE File Offset: 0x003385BE
	private void CEFBBPMOADD()
	{
		if (null != this.DGAAFGDHHHJ)
		{
			this.DGAAFGDHHHJ.DOKill(true);
		}
	}

	// Token: 0x060072B9 RID: 29369 RVA: 0x0033A3BE File Offset: 0x003385BE
	private void JNKPKECPLCB()
	{
		if (null != this.DGAAFGDHHHJ)
		{
			this.DGAAFGDHHHJ.DOKill(true);
		}
	}

	// Token: 0x060072BA RID: 29370 RVA: 0x0033A3DC File Offset: 0x003385DC
	private void MFFEIHJPAMF()
	{
		this.ADEMLNLMNBD.sprite = this.openState;
		this.DGAAFGDHHHJ.OGOFACPLOGO((int)this.HCOLPEBENOF.x, (int)this.HCOLPEBENOF.y);
		base.StartCoroutine(this.MNDGJFCNIGO());
	}

	// Token: 0x060072BB RID: 29371 RVA: 0x00003E52 File Offset: 0x00002052
	private void LIMPPDFLOOC()
	{
	}

	// Token: 0x060072BC RID: 29372 RVA: 0x0033A2CB File Offset: 0x003384CB
	private void KICOCDCNDGG()
	{
		this.ADEMLNLMNBD = base.gameObject.GetComponent<Image>();
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
	}

	// Token: 0x060072BD RID: 29373 RVA: 0x0033A42C File Offset: 0x0033862C
	private void NDFHKDJKHPP()
	{
		this.ADEMLNLMNBD.sprite = this.openState;
		this.DGAAFGDHHHJ.OGOFACPLOGO((int)this.HCOLPEBENOF.x, (int)this.HCOLPEBENOF.y);
		base.StartCoroutine(this.MPICIBINNCP());
	}

	// Token: 0x060072BE RID: 29374 RVA: 0x0033A2CB File Offset: 0x003384CB
	private void BNMJABILOKK()
	{
		this.ADEMLNLMNBD = base.gameObject.GetComponent<Image>();
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
	}

	// Token: 0x060072BF RID: 29375 RVA: 0x0033A47C File Offset: 0x0033867C
	private void KONNFPPNJKM()
	{
		this.ADEMLNLMNBD.sprite = this.openState;
		this.DGAAFGDHHHJ.OGOFACPLOGO((int)this.HCOLPEBENOF.x, (int)this.HCOLPEBENOF.y);
		base.StartCoroutine(this.MCAAEBBNIMO());
	}

	// Token: 0x060072C0 RID: 29376 RVA: 0x0033A2CB File Offset: 0x003384CB
	private void DBCGAKFDLGD()
	{
		this.ADEMLNLMNBD = base.gameObject.GetComponent<Image>();
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
	}

	// Token: 0x060072C1 RID: 29377 RVA: 0x0033A3BE File Offset: 0x003385BE
	private void EHLOONNKOPB()
	{
		if (null != this.DGAAFGDHHHJ)
		{
			this.DGAAFGDHHHJ.DOKill(true);
		}
	}

	// Token: 0x060072C2 RID: 29378 RVA: 0x00003E52 File Offset: 0x00002052
	private void NDKAFCKLNBL()
	{
	}

	// Token: 0x060072C3 RID: 29379 RVA: 0x0033A300 File Offset: 0x00338500
	private IEnumerator DMIIBEKEPFK()
	{
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2((float)this.translationAmount, 0f), this.animationTime * 0.1f, false).SetEase(Ease.OutQuad);
		yield return new WaitForSeconds(this.animationTime * 0.5f);
		if (this.sfxId != null && this.sfxId.Length > 0)
		{
			AudioManager.EHBBFMCILPC.PlaySfx(this.sfxId, false);
		}
		this.ADEMLNLMNBD.sprite = this.closedState;
		yield return new WaitForSeconds(this.animationTime * 0.3f);
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2((float)(-(float)this.translationAmount), 0f), this.animationTime * 0.1f, false).SetEase(Ease.OutQuad);
		yield break;
	}

	// Token: 0x060072C4 RID: 29380 RVA: 0x0033A4CC File Offset: 0x003386CC
	private void JLCMPGICMDC()
	{
		this.ADEMLNLMNBD.sprite = this.openState;
		this.DGAAFGDHHHJ.OGOFACPLOGO((int)this.HCOLPEBENOF.x, (int)this.HCOLPEBENOF.y);
		base.StartCoroutine(this.MPICIBINNCP());
	}

	// Token: 0x060072C5 RID: 29381 RVA: 0x0033A2CB File Offset: 0x003384CB
	private void Awake()
	{
		this.ADEMLNLMNBD = base.gameObject.GetComponent<Image>();
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
	}

	// Token: 0x060072C6 RID: 29382 RVA: 0x0033A51C File Offset: 0x0033871C
	private void IJMPLMMFIEP()
	{
		this.ADEMLNLMNBD.sprite = this.openState;
		this.DGAAFGDHHHJ.OGOFACPLOGO((int)this.HCOLPEBENOF.x, (int)this.HCOLPEBENOF.y);
		base.StartCoroutine(this.MNDGJFCNIGO());
	}

	// Token: 0x060072C7 RID: 29383 RVA: 0x0033A300 File Offset: 0x00338500
	private IEnumerator APBFKBEMKKE()
	{
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2((float)this.translationAmount, 0f), this.animationTime * 0.1f, false).SetEase(Ease.OutQuad);
		yield return new WaitForSeconds(this.animationTime * 0.5f);
		if (this.sfxId != null && this.sfxId.Length > 0)
		{
			AudioManager.EHBBFMCILPC.PlaySfx(this.sfxId, false);
		}
		this.ADEMLNLMNBD.sprite = this.closedState;
		yield return new WaitForSeconds(this.animationTime * 0.3f);
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2((float)(-(float)this.translationAmount), 0f), this.animationTime * 0.1f, false).SetEase(Ease.OutQuad);
		yield break;
	}

	// Token: 0x060072C8 RID: 29384 RVA: 0x0033A56C File Offset: 0x0033876C
	private void DJDLHIOMGJB()
	{
		this.ADEMLNLMNBD.sprite = this.openState;
		this.DGAAFGDHHHJ.OGOFACPLOGO((int)this.HCOLPEBENOF.x, (int)this.HCOLPEBENOF.y);
		base.StartCoroutine(this.CCALONJDJBK());
	}

	// Token: 0x060072C9 RID: 29385 RVA: 0x00003E52 File Offset: 0x00002052
	private void BPCIIBNLBAL()
	{
	}

	// Token: 0x060072CA RID: 29386 RVA: 0x0033A2CB File Offset: 0x003384CB
	private void CGLFKMJKOLJ()
	{
		this.ADEMLNLMNBD = base.gameObject.GetComponent<Image>();
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
	}

	// Token: 0x060072CB RID: 29387 RVA: 0x0033A3BE File Offset: 0x003385BE
	private void MDLNNHHGIAB()
	{
		if (null != this.DGAAFGDHHHJ)
		{
			this.DGAAFGDHHHJ.DOKill(true);
		}
	}

	// Token: 0x060072CC RID: 29388 RVA: 0x0033A2CB File Offset: 0x003384CB
	private void DCMMAADPBPM()
	{
		this.ADEMLNLMNBD = base.gameObject.GetComponent<Image>();
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
	}

	// Token: 0x060072CD RID: 29389 RVA: 0x00003E52 File Offset: 0x00002052
	private void EBBIFAMPCCI()
	{
	}

	// Token: 0x060072CE RID: 29390 RVA: 0x00003E52 File Offset: 0x00002052
	private void NIIMGPDMHLA()
	{
	}

	// Token: 0x060072CF RID: 29391 RVA: 0x00003E52 File Offset: 0x00002052
	private void CPDNJAKBOBC()
	{
	}

	// Token: 0x060072D0 RID: 29392 RVA: 0x00003E52 File Offset: 0x00002052
	private void BFGFJIJPMEH()
	{
	}

	// Token: 0x060072D1 RID: 29393 RVA: 0x00003E52 File Offset: 0x00002052
	private void PKMPOFOOGFK()
	{
	}

	// Token: 0x060072D2 RID: 29394 RVA: 0x0033A2CB File Offset: 0x003384CB
	private void HJMKOELKODM()
	{
		this.ADEMLNLMNBD = base.gameObject.GetComponent<Image>();
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
	}

	// Token: 0x060072D3 RID: 29395 RVA: 0x0033A5BC File Offset: 0x003387BC
	private void ILBAMCJFAAP()
	{
		this.ADEMLNLMNBD.sprite = this.openState;
		this.DGAAFGDHHHJ.OGOFACPLOGO((int)this.HCOLPEBENOF.x, (int)this.HCOLPEBENOF.y);
		base.StartCoroutine(this.HJPJNKFJJPA());
	}

	// Token: 0x060072D4 RID: 29396 RVA: 0x0033A3BE File Offset: 0x003385BE
	private void NKPBKBHKJMA()
	{
		if (null != this.DGAAFGDHHHJ)
		{
			this.DGAAFGDHHHJ.DOKill(true);
		}
	}

	// Token: 0x060072D6 RID: 29398 RVA: 0x0033A2CB File Offset: 0x003384CB
	private void ECDLFGCLAGG()
	{
		this.ADEMLNLMNBD = base.gameObject.GetComponent<Image>();
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
	}

	// Token: 0x060072D7 RID: 29399 RVA: 0x0033A30F File Offset: 0x0033850F
	private IEnumerator AJNPGHHFNOH()
	{
		AnimationClipperboard.PGOJLDBKDGJ pgojldbkdgj = new AnimationClipperboard.PGOJLDBKDGJ(1);
		pgojldbkdgj.<>4__this = this;
		return pgojldbkdgj;
	}

	// Token: 0x060072D8 RID: 29400 RVA: 0x0033A628 File Offset: 0x00338828
	private void EOAKHNIJECB()
	{
		this.ADEMLNLMNBD.sprite = this.openState;
		this.DGAAFGDHHHJ.OGOFACPLOGO((int)this.HCOLPEBENOF.x, (int)this.HCOLPEBENOF.y);
		base.StartCoroutine(this.HJPJNKFJJPA());
	}

	// Token: 0x060072D9 RID: 29401 RVA: 0x0033A2CB File Offset: 0x003384CB
	private void LFPPGGLOOHJ()
	{
		this.ADEMLNLMNBD = base.gameObject.GetComponent<Image>();
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
	}

	// Token: 0x060072DA RID: 29402 RVA: 0x0033A2CB File Offset: 0x003384CB
	private void KDLMMHEAPNH()
	{
		this.ADEMLNLMNBD = base.gameObject.GetComponent<Image>();
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
	}

	// Token: 0x060072DB RID: 29403 RVA: 0x0033A30F File Offset: 0x0033850F
	private IEnumerator MOBCCDIKBEL()
	{
		AnimationClipperboard.PGOJLDBKDGJ pgojldbkdgj = new AnimationClipperboard.PGOJLDBKDGJ(1);
		pgojldbkdgj.<>4__this = this;
		return pgojldbkdgj;
	}

	// Token: 0x060072DC RID: 29404 RVA: 0x0033A2AE File Offset: 0x003384AE
	private void LBDOGJFKKAB()
	{
		if (null != this.DGAAFGDHHHJ)
		{
			this.DGAAFGDHHHJ.DOKill(false);
		}
	}

	// Token: 0x060072DD RID: 29405 RVA: 0x0033A2AE File Offset: 0x003384AE
	private void OnDestroy()
	{
		if (null != this.DGAAFGDHHHJ)
		{
			this.DGAAFGDHHHJ.DOKill(false);
		}
	}

	// Token: 0x060072DE RID: 29406 RVA: 0x00003E52 File Offset: 0x00002052
	private void HPGLEEHELDN()
	{
	}

	// Token: 0x060072DF RID: 29407 RVA: 0x0033A300 File Offset: 0x00338500
	private IEnumerator AABOODECOAG()
	{
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2((float)this.translationAmount, 0f), this.animationTime * 0.1f, false).SetEase(Ease.OutQuad);
		yield return new WaitForSeconds(this.animationTime * 0.5f);
		if (this.sfxId != null && this.sfxId.Length > 0)
		{
			AudioManager.EHBBFMCILPC.PlaySfx(this.sfxId, false);
		}
		this.ADEMLNLMNBD.sprite = this.closedState;
		yield return new WaitForSeconds(this.animationTime * 0.3f);
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2((float)(-(float)this.translationAmount), 0f), this.animationTime * 0.1f, false).SetEase(Ease.OutQuad);
		yield break;
	}

	// Token: 0x060072E0 RID: 29408 RVA: 0x0033A2CB File Offset: 0x003384CB
	private void MDNEOMGLGIN()
	{
		this.ADEMLNLMNBD = base.gameObject.GetComponent<Image>();
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
	}

	// Token: 0x060072E1 RID: 29409 RVA: 0x0033A2AE File Offset: 0x003384AE
	private void FEBECEEIHBP()
	{
		if (null != this.DGAAFGDHHHJ)
		{
			this.DGAAFGDHHHJ.DOKill(false);
		}
	}

	// Token: 0x060072E2 RID: 29410 RVA: 0x0033A2CB File Offset: 0x003384CB
	private void KBGOLEGBMAP()
	{
		this.ADEMLNLMNBD = base.gameObject.GetComponent<Image>();
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
	}

	// Token: 0x060072E3 RID: 29411 RVA: 0x0033A300 File Offset: 0x00338500
	private IEnumerator LAKIJEGLFHJ()
	{
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2((float)this.translationAmount, 0f), this.animationTime * 0.1f, false).SetEase(Ease.OutQuad);
		yield return new WaitForSeconds(this.animationTime * 0.5f);
		if (this.sfxId != null && this.sfxId.Length > 0)
		{
			AudioManager.EHBBFMCILPC.PlaySfx(this.sfxId, false);
		}
		this.ADEMLNLMNBD.sprite = this.closedState;
		yield return new WaitForSeconds(this.animationTime * 0.3f);
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2((float)(-(float)this.translationAmount), 0f), this.animationTime * 0.1f, false).SetEase(Ease.OutQuad);
		yield break;
	}

	// Token: 0x060072E4 RID: 29412 RVA: 0x0033A2CB File Offset: 0x003384CB
	private void LFOJBMBCOFP()
	{
		this.ADEMLNLMNBD = base.gameObject.GetComponent<Image>();
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
	}

	// Token: 0x060072E5 RID: 29413 RVA: 0x0033A2CB File Offset: 0x003384CB
	private void OPPNHGEMHAB()
	{
		this.ADEMLNLMNBD = base.gameObject.GetComponent<Image>();
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
	}

	// Token: 0x060072E6 RID: 29414 RVA: 0x0033A2AE File Offset: 0x003384AE
	private void LFEEHGLHJDN()
	{
		if (null != this.DGAAFGDHHHJ)
		{
			this.DGAAFGDHHHJ.DOKill(false);
		}
	}

	// Token: 0x060072E7 RID: 29415 RVA: 0x0033A2CB File Offset: 0x003384CB
	private void CJOOOIECMAE()
	{
		this.ADEMLNLMNBD = base.gameObject.GetComponent<Image>();
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
	}

	// Token: 0x060072E8 RID: 29416 RVA: 0x00003E52 File Offset: 0x00002052
	private void Start()
	{
	}

	// Token: 0x060072E9 RID: 29417 RVA: 0x0033A3BE File Offset: 0x003385BE
	private void GMBGAPAGAHB()
	{
		if (null != this.DGAAFGDHHHJ)
		{
			this.DGAAFGDHHHJ.DOKill(true);
		}
	}

	// Token: 0x060072EA RID: 29418 RVA: 0x0033A2AE File Offset: 0x003384AE
	private void CKNCEKFOLKD()
	{
		if (null != this.DGAAFGDHHHJ)
		{
			this.DGAAFGDHHHJ.DOKill(false);
		}
	}

	// Token: 0x060072EB RID: 29419 RVA: 0x00003E52 File Offset: 0x00002052
	private void EJCFKOHELJO()
	{
	}

	// Token: 0x060072EC RID: 29420 RVA: 0x0033A678 File Offset: 0x00338878
	private void IKBLOOGEPJB()
	{
		this.ADEMLNLMNBD.sprite = this.openState;
		this.DGAAFGDHHHJ.OGOFACPLOGO((int)this.HCOLPEBENOF.x, (int)this.HCOLPEBENOF.y);
		base.StartCoroutine(this.FNNJAFDDBHH());
	}

	// Token: 0x060072ED RID: 29421 RVA: 0x0033A2AE File Offset: 0x003384AE
	private void AODCOGNJPAD()
	{
		if (null != this.DGAAFGDHHHJ)
		{
			this.DGAAFGDHHHJ.DOKill(false);
		}
	}

	// Token: 0x060072EE RID: 29422 RVA: 0x00003E52 File Offset: 0x00002052
	private void GEHKPILFMLD()
	{
	}

	// Token: 0x060072EF RID: 29423 RVA: 0x0033A2CB File Offset: 0x003384CB
	private void LBDIDHDKHGO()
	{
		this.ADEMLNLMNBD = base.gameObject.GetComponent<Image>();
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
	}

	// Token: 0x060072F0 RID: 29424 RVA: 0x0033A6C8 File Offset: 0x003388C8
	private void MDFOBFFGDAB()
	{
		this.ADEMLNLMNBD.sprite = this.openState;
		this.DGAAFGDHHHJ.OGOFACPLOGO((int)this.HCOLPEBENOF.x, (int)this.HCOLPEBENOF.y);
		base.StartCoroutine(this.FNNJAFDDBHH());
	}

	// Token: 0x060072F1 RID: 29425 RVA: 0x0033A300 File Offset: 0x00338500
	private IEnumerator HJPJNKFJJPA()
	{
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2((float)this.translationAmount, 0f), this.animationTime * 0.1f, false).SetEase(Ease.OutQuad);
		yield return new WaitForSeconds(this.animationTime * 0.5f);
		if (this.sfxId != null && this.sfxId.Length > 0)
		{
			AudioManager.EHBBFMCILPC.PlaySfx(this.sfxId, false);
		}
		this.ADEMLNLMNBD.sprite = this.closedState;
		yield return new WaitForSeconds(this.animationTime * 0.3f);
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2((float)(-(float)this.translationAmount), 0f), this.animationTime * 0.1f, false).SetEase(Ease.OutQuad);
		yield break;
	}

	// Token: 0x060072F2 RID: 29426 RVA: 0x0033A30F File Offset: 0x0033850F
	private IEnumerator MCAAEBBNIMO()
	{
		AnimationClipperboard.PGOJLDBKDGJ pgojldbkdgj = new AnimationClipperboard.PGOJLDBKDGJ(1);
		pgojldbkdgj.<>4__this = this;
		return pgojldbkdgj;
	}

	// Token: 0x060072F3 RID: 29427 RVA: 0x0033A3BE File Offset: 0x003385BE
	private void HLKKMONAIMG()
	{
		if (null != this.DGAAFGDHHHJ)
		{
			this.DGAAFGDHHHJ.DOKill(true);
		}
	}

	// Token: 0x060072F4 RID: 29428 RVA: 0x00003E52 File Offset: 0x00002052
	private void HPDHFIHPKGP()
	{
	}

	// Token: 0x060072F5 RID: 29429 RVA: 0x0033A300 File Offset: 0x00338500
	private IEnumerator PCDNIHCKIHL()
	{
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2((float)this.translationAmount, 0f), this.animationTime * 0.1f, false).SetEase(Ease.OutQuad);
		yield return new WaitForSeconds(this.animationTime * 0.5f);
		if (this.sfxId != null && this.sfxId.Length > 0)
		{
			AudioManager.EHBBFMCILPC.PlaySfx(this.sfxId, false);
		}
		this.ADEMLNLMNBD.sprite = this.closedState;
		yield return new WaitForSeconds(this.animationTime * 0.3f);
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2((float)(-(float)this.translationAmount), 0f), this.animationTime * 0.1f, false).SetEase(Ease.OutQuad);
		yield break;
	}

	// Token: 0x060072F6 RID: 29430 RVA: 0x0033A30F File Offset: 0x0033850F
	private IEnumerator MPICIBINNCP()
	{
		AnimationClipperboard.PGOJLDBKDGJ pgojldbkdgj = new AnimationClipperboard.PGOJLDBKDGJ(1);
		pgojldbkdgj.<>4__this = this;
		return pgojldbkdgj;
	}

	// Token: 0x060072F7 RID: 29431 RVA: 0x0033A2CB File Offset: 0x003384CB
	private void APLBAENGMJH()
	{
		this.ADEMLNLMNBD = base.gameObject.GetComponent<Image>();
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
	}

	// Token: 0x060072F8 RID: 29432 RVA: 0x0033A30F File Offset: 0x0033850F
	private IEnumerator CCALONJDJBK()
	{
		AnimationClipperboard.PGOJLDBKDGJ pgojldbkdgj = new AnimationClipperboard.PGOJLDBKDGJ(1);
		pgojldbkdgj.<>4__this = this;
		return pgojldbkdgj;
	}

	// Token: 0x060072F9 RID: 29433 RVA: 0x0033A3BE File Offset: 0x003385BE
	private void BGELMCDMGKP()
	{
		if (null != this.DGAAFGDHHHJ)
		{
			this.DGAAFGDHHHJ.DOKill(true);
		}
	}

	// Token: 0x060072FA RID: 29434 RVA: 0x0033A3BE File Offset: 0x003385BE
	private void CEJFHEBCHGK()
	{
		if (null != this.DGAAFGDHHHJ)
		{
			this.DGAAFGDHHHJ.DOKill(true);
		}
	}

	// Token: 0x060072FB RID: 29435 RVA: 0x00003E52 File Offset: 0x00002052
	private void EIHOIEGKJLA()
	{
	}

	// Token: 0x060072FC RID: 29436 RVA: 0x0033A2CB File Offset: 0x003384CB
	private void OJLALFAEEKP()
	{
		this.ADEMLNLMNBD = base.gameObject.GetComponent<Image>();
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
	}

	// Token: 0x060072FD RID: 29437 RVA: 0x00003E52 File Offset: 0x00002052
	private void DDMCLNDOHCK()
	{
	}

	// Token: 0x060072FE RID: 29438 RVA: 0x0033A300 File Offset: 0x00338500
	private IEnumerator JPLPCCIBIBH()
	{
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2((float)this.translationAmount, 0f), this.animationTime * 0.1f, false).SetEase(Ease.OutQuad);
		yield return new WaitForSeconds(this.animationTime * 0.5f);
		if (this.sfxId != null && this.sfxId.Length > 0)
		{
			AudioManager.EHBBFMCILPC.PlaySfx(this.sfxId, false);
		}
		this.ADEMLNLMNBD.sprite = this.closedState;
		yield return new WaitForSeconds(this.animationTime * 0.3f);
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2((float)(-(float)this.translationAmount), 0f), this.animationTime * 0.1f, false).SetEase(Ease.OutQuad);
		yield break;
	}

	// Token: 0x060072FF RID: 29439 RVA: 0x0033A2AE File Offset: 0x003384AE
	private void LDBOLMLPPHJ()
	{
		if (null != this.DGAAFGDHHHJ)
		{
			this.DGAAFGDHHHJ.DOKill(false);
		}
	}

	// Token: 0x06007300 RID: 29440 RVA: 0x0033A300 File Offset: 0x00338500
	private IEnumerator HEGKDADPNNG()
	{
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2((float)this.translationAmount, 0f), this.animationTime * 0.1f, false).SetEase(Ease.OutQuad);
		yield return new WaitForSeconds(this.animationTime * 0.5f);
		if (this.sfxId != null && this.sfxId.Length > 0)
		{
			AudioManager.EHBBFMCILPC.PlaySfx(this.sfxId, false);
		}
		this.ADEMLNLMNBD.sprite = this.closedState;
		yield return new WaitForSeconds(this.animationTime * 0.3f);
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2((float)(-(float)this.translationAmount), 0f), this.animationTime * 0.1f, false).SetEase(Ease.OutQuad);
		yield break;
	}

	// Token: 0x06007301 RID: 29441 RVA: 0x0033A300 File Offset: 0x00338500
	private IEnumerator CHOGMCMNIKA()
	{
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2((float)this.translationAmount, 0f), this.animationTime * 0.1f, false).SetEase(Ease.OutQuad);
		yield return new WaitForSeconds(this.animationTime * 0.5f);
		if (this.sfxId != null && this.sfxId.Length > 0)
		{
			AudioManager.EHBBFMCILPC.PlaySfx(this.sfxId, false);
		}
		this.ADEMLNLMNBD.sprite = this.closedState;
		yield return new WaitForSeconds(this.animationTime * 0.3f);
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2((float)(-(float)this.translationAmount), 0f), this.animationTime * 0.1f, false).SetEase(Ease.OutQuad);
		yield break;
	}

	// Token: 0x06007302 RID: 29442 RVA: 0x00003E52 File Offset: 0x00002052
	private void FEIFMJKGGBO()
	{
	}

	// Token: 0x06007303 RID: 29443 RVA: 0x0033A2AE File Offset: 0x003384AE
	private void PLOEIJIANMM()
	{
		if (null != this.DGAAFGDHHHJ)
		{
			this.DGAAFGDHHHJ.DOKill(false);
		}
	}

	// Token: 0x06007304 RID: 29444 RVA: 0x0033A3BE File Offset: 0x003385BE
	private void LPMPMAJGALN()
	{
		if (null != this.DGAAFGDHHHJ)
		{
			this.DGAAFGDHHHJ.DOKill(true);
		}
	}

	// Token: 0x06007305 RID: 29445 RVA: 0x0033A300 File Offset: 0x00338500
	private IEnumerator KBFKEIMPCDJ()
	{
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2((float)this.translationAmount, 0f), this.animationTime * 0.1f, false).SetEase(Ease.OutQuad);
		yield return new WaitForSeconds(this.animationTime * 0.5f);
		if (this.sfxId != null && this.sfxId.Length > 0)
		{
			AudioManager.EHBBFMCILPC.PlaySfx(this.sfxId, false);
		}
		this.ADEMLNLMNBD.sprite = this.closedState;
		yield return new WaitForSeconds(this.animationTime * 0.3f);
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2((float)(-(float)this.translationAmount), 0f), this.animationTime * 0.1f, false).SetEase(Ease.OutQuad);
		yield break;
	}

	// Token: 0x06007306 RID: 29446 RVA: 0x0033A2CB File Offset: 0x003384CB
	private void OAPJBCOGOMK()
	{
		this.ADEMLNLMNBD = base.gameObject.GetComponent<Image>();
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
	}

	// Token: 0x06007307 RID: 29447 RVA: 0x0033A2CB File Offset: 0x003384CB
	private void EIIKCHOGIBH()
	{
		this.ADEMLNLMNBD = base.gameObject.GetComponent<Image>();
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
	}

	// Token: 0x06007308 RID: 29448 RVA: 0x0033A2AE File Offset: 0x003384AE
	private void JLCJJONEBIB()
	{
		if (null != this.DGAAFGDHHHJ)
		{
			this.DGAAFGDHHHJ.DOKill(false);
		}
	}

	// Token: 0x06007309 RID: 29449 RVA: 0x0033A2AE File Offset: 0x003384AE
	private void ONJMBHKDOGD()
	{
		if (null != this.DGAAFGDHHHJ)
		{
			this.DGAAFGDHHHJ.DOKill(false);
		}
	}

	// Token: 0x0600730A RID: 29450 RVA: 0x00003E52 File Offset: 0x00002052
	private void EAKEDEEHEDD()
	{
	}

	// Token: 0x0600730B RID: 29451 RVA: 0x0033A718 File Offset: 0x00338918
	private void FIIMDIKHIHG()
	{
		this.ADEMLNLMNBD.sprite = this.openState;
		this.DGAAFGDHHHJ.OGOFACPLOGO((int)this.HCOLPEBENOF.x, (int)this.HCOLPEBENOF.y);
		base.StartCoroutine(this.FNNJAFDDBHH());
	}

	// Token: 0x0600730C RID: 29452 RVA: 0x0033A300 File Offset: 0x00338500
	private IEnumerator ECGLANFCPKB()
	{
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2((float)this.translationAmount, 0f), this.animationTime * 0.1f, false).SetEase(Ease.OutQuad);
		yield return new WaitForSeconds(this.animationTime * 0.5f);
		if (this.sfxId != null && this.sfxId.Length > 0)
		{
			AudioManager.EHBBFMCILPC.PlaySfx(this.sfxId, false);
		}
		this.ADEMLNLMNBD.sprite = this.closedState;
		yield return new WaitForSeconds(this.animationTime * 0.3f);
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2((float)(-(float)this.translationAmount), 0f), this.animationTime * 0.1f, false).SetEase(Ease.OutQuad);
		yield break;
	}

	// Token: 0x0600730D RID: 29453 RVA: 0x0033A768 File Offset: 0x00338968
	private void HCKLMFNDKBC()
	{
		this.ADEMLNLMNBD.sprite = this.openState;
		this.DGAAFGDHHHJ.OGOFACPLOGO((int)this.HCOLPEBENOF.x, (int)this.HCOLPEBENOF.y);
		base.StartCoroutine(this.ECDILLNILIP());
	}

	// Token: 0x0600730E RID: 29454 RVA: 0x00003E52 File Offset: 0x00002052
	private void KJFHBHJPFFI()
	{
	}

	// Token: 0x0600730F RID: 29455 RVA: 0x0033A7B8 File Offset: 0x003389B8
	private void HCDMJPIENDB()
	{
		this.ADEMLNLMNBD.sprite = this.openState;
		this.DGAAFGDHHHJ.OGOFACPLOGO((int)this.HCOLPEBENOF.x, (int)this.HCOLPEBENOF.y);
		base.StartCoroutine(this.ECGLANFCPKB());
	}

	// Token: 0x06007310 RID: 29456 RVA: 0x00003E52 File Offset: 0x00002052
	private void OHPNGFAIGEM()
	{
	}

	// Token: 0x04002234 RID: 8756
	public Sprite openState;

	// Token: 0x04002235 RID: 8757
	public Sprite closedState;

	// Token: 0x04002236 RID: 8758
	public int translationAmount = 300;

	// Token: 0x04002237 RID: 8759
	public float animationTime = 1f;

	// Token: 0x04002238 RID: 8760
	public string sfxId;

	// Token: 0x04002239 RID: 8761
	private Image ADEMLNLMNBD;

	// Token: 0x0400223A RID: 8762
	private Vector2 HCOLPEBENOF;

	// Token: 0x0400223B RID: 8763
	private RectTransform DGAAFGDHHHJ;
}
