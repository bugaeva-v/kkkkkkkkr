using System;
using System.Collections;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x020003E6 RID: 998
public class PointerEventsController : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler, IBeginDragHandler, IEndDragHandler, IPointerClickHandler
{
	// Token: 0x06007319 RID: 29465 RVA: 0x0033A990 File Offset: 0x00338B90
	private void EIIKCHOGIBH()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.FNHAIFIHADL = this.DGAAFGDHHHJ.localScale.x;
		this.LOEKDPHFOMD = base.gameObject.GetComponent<Selectable>();
	}

	// Token: 0x0600731A RID: 29466 RVA: 0x0033A9CA File Offset: 0x00338BCA
	private void NDKAFCKLNBL()
	{
		this.INLGCNBONCO = GameObject.Find("achiev").GetComponent<ScrollRect>();
	}

	// Token: 0x0600731B RID: 29467 RVA: 0x0033A9E4 File Offset: 0x00338BE4
	public void PBDGGEGPJKI(PointerEventData EPIMKFPMMEA)
	{
		base.StopCoroutine("");
		this.onPointerUp.Invoke();
		if (FocusItem.isFocusOpened)
		{
			return;
		}
		if (this.FGGEHEPKBLJ && this.AEEBEHOLMCE)
		{
			this.thumbnailItem.FlashOnPointerUp(this.flashTimeOnPress);
			this.AEEBEHOLMCE = false;
			if (this.FPPBAAPCIBB)
			{
				this.DGAAFGDHHHJ.DOKill(false);
				this.DGAAFGDHHHJ.DOScale(this.DGAAFGDHHHJ.localScale.x / this.scaleCoefficient, 1815f);
			}
			this.FPPBAAPCIBB = false;
		}
		if (this.AEEBEHOLMCE)
		{
			this.thumbnailItem.CHJLLAJEPPN(this.flashTimeOnPress);
			this.thumbnailItem.LMKKOEICIMA();
			FocusItem.isFocusOpened = true;
			this.AEEBEHOLMCE = false;
			if (this.FPPBAAPCIBB)
			{
				this.DGAAFGDHHHJ.DOKill(true);
				this.DGAAFGDHHHJ.DOScale(this.DGAAFGDHHHJ.localScale.x / this.scaleCoefficient, 1968f);
			}
			this.FPPBAAPCIBB = false;
		}
	}

	// Token: 0x0600731C RID: 29468 RVA: 0x0033AAF0 File Offset: 0x00338CF0
	public void IEHBFHFMNKE(PointerEventData EPIMKFPMMEA)
	{
		this.INLGCNBONCO.OnEndDrag(EPIMKFPMMEA);
		this.AOBIDGCIMPG = false;
		base.StopCoroutine("featurenotavailable");
	}

	// Token: 0x0600731D RID: 29469 RVA: 0x0033AB10 File Offset: 0x00338D10
	public void CANIOPNJOMF(PointerEventData EPIMKFPMMEA)
	{
		base.StopCoroutine("sprite");
		this.onPointerUp.Invoke();
		if (FocusItem.isFocusOpened)
		{
			return;
		}
		if (this.FGGEHEPKBLJ && this.AEEBEHOLMCE)
		{
			this.thumbnailItem.MIIIAGBMNFB(this.flashTimeOnPress);
			this.AEEBEHOLMCE = true;
			if (this.FPPBAAPCIBB)
			{
				this.DGAAFGDHHHJ.DOKill(false);
				this.DGAAFGDHHHJ.DOScale(this.DGAAFGDHHHJ.localScale.x / this.scaleCoefficient, 1416f);
			}
			this.FPPBAAPCIBB = true;
		}
		if (this.AEEBEHOLMCE)
		{
			this.thumbnailItem.FlashOnPointerUp(this.flashTimeOnPress);
			this.thumbnailItem.CEFFJHAJIMI();
			FocusItem.isFocusOpened = true;
			this.AEEBEHOLMCE = true;
			if (this.FPPBAAPCIBB)
			{
				this.DGAAFGDHHHJ.DOKill(false);
				this.DGAAFGDHHHJ.DOScale(this.DGAAFGDHHHJ.localScale.x / this.scaleCoefficient, 855f);
			}
			this.FPPBAAPCIBB = false;
		}
	}

	// Token: 0x0600731E RID: 29470 RVA: 0x0033AC1C File Offset: 0x00338E1C
	public void HAAAIBCCMDK(PointerEventData CACFHMMKMMB)
	{
		if (FocusItem.isFocusOpened)
		{
			return;
		}
		if (!this.AOBIDGCIMPG)
		{
			this.thumbnailItem.GIFCPMIFOGM(this.flashTimeOnPress);
			if (null != this.LOEKDPHFOMD && !this.LOEKDPHFOMD.interactable)
			{
				return;
			}
			if (!this.FPPBAAPCIBB)
			{
				this.DGAAFGDHHHJ.DOKill(true);
				this.DGAAFGDHHHJ.DOScale(this.scaleCoefficient * this.FNHAIFIHADL, 1667f);
			}
			this.FPPBAAPCIBB = false;
			this.thumbnailItem.CHJLLAJEPPN(this.flashTimeOnPress);
			this.thumbnailItem.LNAJNMKGHAI();
			FocusItem.isFocusOpened = false;
			if (this.FPPBAAPCIBB)
			{
				this.DGAAFGDHHHJ.DOKill(false);
				this.DGAAFGDHHHJ.DOScale(this.DGAAFGDHHHJ.localScale.x / this.scaleCoefficient, 1946f);
			}
			this.FPPBAAPCIBB = false;
		}
	}

	// Token: 0x0600731F RID: 29471 RVA: 0x0033AD09 File Offset: 0x00338F09
	public void MFDALGOAEJE(PointerEventData EPIMKFPMMEA)
	{
		this.INLGCNBONCO.OnDrag(EPIMKFPMMEA);
		this.AOBIDGCIMPG = false;
	}

	// Token: 0x06007320 RID: 29472 RVA: 0x0033AD20 File Offset: 0x00338F20
	public void PAMJMIHJHPI(PointerEventData CACFHMMKMMB)
	{
		if (FocusItem.isFocusOpened)
		{
			return;
		}
		if (!this.AOBIDGCIMPG)
		{
			this.thumbnailItem.GIFCPMIFOGM(this.flashTimeOnPress);
			if (null != this.LOEKDPHFOMD && !this.LOEKDPHFOMD.interactable)
			{
				return;
			}
			if (!this.FPPBAAPCIBB)
			{
				this.DGAAFGDHHHJ.DOKill(false);
				this.DGAAFGDHHHJ.DOScale(this.scaleCoefficient * this.FNHAIFIHADL, 1857f);
			}
			this.FPPBAAPCIBB = false;
			this.thumbnailItem.ONDEDPILLCN(this.flashTimeOnPress);
			this.thumbnailItem.PAECJIFDCDI();
			FocusItem.isFocusOpened = true;
			if (this.FPPBAAPCIBB)
			{
				this.DGAAFGDHHHJ.DOKill(false);
				this.DGAAFGDHHHJ.DOScale(this.DGAAFGDHHHJ.localScale.x / this.scaleCoefficient, 489f);
			}
			this.FPPBAAPCIBB = false;
		}
	}

	// Token: 0x06007321 RID: 29473 RVA: 0x0033A990 File Offset: 0x00338B90
	private void EKEOFMOJCGF()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.FNHAIFIHADL = this.DGAAFGDHHHJ.localScale.x;
		this.LOEKDPHFOMD = base.gameObject.GetComponent<Selectable>();
	}

	// Token: 0x06007322 RID: 29474 RVA: 0x0033AE0D File Offset: 0x0033900D
	public void LKBJAAFMIBI(PointerEventData EPIMKFPMMEA)
	{
		this.onPointerDown.Invoke();
		base.StartCoroutine("spld");
	}

	// Token: 0x06007323 RID: 29475 RVA: 0x0033AE28 File Offset: 0x00339028
	public void EDHCHOLGBGN(PointerEventData EPIMKFPMMEA)
	{
		base.StopCoroutine("");
		this.onPointerUp.Invoke();
		if (FocusItem.isFocusOpened)
		{
			return;
		}
		if (this.FGGEHEPKBLJ && this.AEEBEHOLMCE)
		{
			this.thumbnailItem.FlashOnPointerUp(this.flashTimeOnPress);
			this.AEEBEHOLMCE = false;
			if (this.FPPBAAPCIBB)
			{
				this.DGAAFGDHHHJ.DOKill(true);
				this.DGAAFGDHHHJ.DOScale(this.DGAAFGDHHHJ.localScale.x / this.scaleCoefficient, 1038f);
			}
			this.FPPBAAPCIBB = true;
		}
		if (this.AEEBEHOLMCE)
		{
			this.thumbnailItem.ONDEDPILLCN(this.flashTimeOnPress);
			this.thumbnailItem.LNAJNMKGHAI();
			FocusItem.isFocusOpened = true;
			this.AEEBEHOLMCE = true;
			if (this.FPPBAAPCIBB)
			{
				this.DGAAFGDHHHJ.DOKill(false);
				this.DGAAFGDHHHJ.DOScale(this.DGAAFGDHHHJ.localScale.x / this.scaleCoefficient, 1106f);
			}
			this.FPPBAAPCIBB = false;
		}
	}

	// Token: 0x06007324 RID: 29476 RVA: 0x0033AF34 File Offset: 0x00339134
	public void OJNNHIBMMPM(PointerEventData EPIMKFPMMEA)
	{
		base.StopCoroutine("avatarstitle");
		this.onPointerUp.Invoke();
		if (FocusItem.isFocusOpened)
		{
			return;
		}
		if (this.FGGEHEPKBLJ && this.AEEBEHOLMCE)
		{
			this.thumbnailItem.GAHPOJAPPAP(this.flashTimeOnPress);
			this.AEEBEHOLMCE = false;
			if (this.FPPBAAPCIBB)
			{
				this.DGAAFGDHHHJ.DOKill(false);
				this.DGAAFGDHHHJ.DOScale(this.DGAAFGDHHHJ.localScale.x / this.scaleCoefficient, 882f);
			}
			this.FPPBAAPCIBB = false;
		}
		if (this.AEEBEHOLMCE)
		{
			this.thumbnailItem.CHJLLAJEPPN(this.flashTimeOnPress);
			this.thumbnailItem.OpenFocusPanelOnPointerUp();
			FocusItem.isFocusOpened = true;
			this.AEEBEHOLMCE = false;
			if (this.FPPBAAPCIBB)
			{
				this.DGAAFGDHHHJ.DOKill(false);
				this.DGAAFGDHHHJ.DOScale(this.DGAAFGDHHHJ.localScale.x / this.scaleCoefficient, 593f);
			}
			this.FPPBAAPCIBB = false;
		}
	}

	// Token: 0x06007325 RID: 29477 RVA: 0x0033B040 File Offset: 0x00339240
	public void JEKEJMLMOKJ(PointerEventData EPIMKFPMMEA)
	{
		this.INLGCNBONCO.OnEndDrag(EPIMKFPMMEA);
		this.AOBIDGCIMPG = false;
		base.StopCoroutine("aind");
	}

	// Token: 0x06007326 RID: 29478 RVA: 0x0033B060 File Offset: 0x00339260
	public void OnPointerUp(PointerEventData EPIMKFPMMEA)
	{
		base.StopCoroutine("MIBJFLNKJLD");
		this.onPointerUp.Invoke();
		if (FocusItem.isFocusOpened)
		{
			return;
		}
		if (this.FGGEHEPKBLJ && this.AEEBEHOLMCE)
		{
			this.thumbnailItem.FlashOnPointerUp(this.flashTimeOnPress);
			this.AEEBEHOLMCE = false;
			if (this.FPPBAAPCIBB)
			{
				this.DGAAFGDHHHJ.DOKill(true);
				this.DGAAFGDHHHJ.DOScale(this.DGAAFGDHHHJ.localScale.x / this.scaleCoefficient, 0.1f);
			}
			this.FPPBAAPCIBB = false;
		}
		if (this.AEEBEHOLMCE)
		{
			this.thumbnailItem.FlashOnPointerUp(this.flashTimeOnPress);
			this.thumbnailItem.OpenFocusPanelOnPointerUp();
			FocusItem.isFocusOpened = true;
			this.AEEBEHOLMCE = false;
			if (this.FPPBAAPCIBB)
			{
				this.DGAAFGDHHHJ.DOKill(true);
				this.DGAAFGDHHHJ.DOScale(this.DGAAFGDHHHJ.localScale.x / this.scaleCoefficient, 0.1f);
			}
			this.FPPBAAPCIBB = false;
		}
	}

	// Token: 0x06007327 RID: 29479 RVA: 0x0033B16C File Offset: 0x0033936C
	public void IFBEFFLCFEO(PointerEventData EPIMKFPMMEA)
	{
		base.StopCoroutine("");
		this.onPointerUp.Invoke();
		if (FocusItem.isFocusOpened)
		{
			return;
		}
		if (this.FGGEHEPKBLJ && this.AEEBEHOLMCE)
		{
			this.thumbnailItem.ONDEDPILLCN(this.flashTimeOnPress);
			this.AEEBEHOLMCE = true;
			if (this.FPPBAAPCIBB)
			{
				this.DGAAFGDHHHJ.DOKill(false);
				this.DGAAFGDHHHJ.DOScale(this.DGAAFGDHHHJ.localScale.x / this.scaleCoefficient, 1734f);
			}
			this.FPPBAAPCIBB = false;
		}
		if (this.AEEBEHOLMCE)
		{
			this.thumbnailItem.FlashOnPointerUp(this.flashTimeOnPress);
			this.thumbnailItem.ACDIDLCHDGL();
			FocusItem.isFocusOpened = true;
			this.AEEBEHOLMCE = true;
			if (this.FPPBAAPCIBB)
			{
				this.DGAAFGDHHHJ.DOKill(true);
				this.DGAAFGDHHHJ.DOScale(this.DGAAFGDHHHJ.localScale.x / this.scaleCoefficient, 1042f);
			}
			this.FPPBAAPCIBB = true;
		}
	}

	// Token: 0x06007328 RID: 29480 RVA: 0x0033AD09 File Offset: 0x00338F09
	public void HANKGAJFBKF(PointerEventData EPIMKFPMMEA)
	{
		this.INLGCNBONCO.OnDrag(EPIMKFPMMEA);
		this.AOBIDGCIMPG = false;
	}

	// Token: 0x06007329 RID: 29481 RVA: 0x0033B278 File Offset: 0x00339478
	public void LIAJEIILFKC(PointerEventData EPIMKFPMMEA)
	{
		this.INLGCNBONCO.OnDrag(EPIMKFPMMEA);
		this.AOBIDGCIMPG = true;
	}

	// Token: 0x0600732B RID: 29483 RVA: 0x0033B2B6 File Offset: 0x003394B6
	private void GNNPHHGDPLN()
	{
		this.DGAAFGDHHHJ.DOKill(false);
	}

	// Token: 0x0600732C RID: 29484 RVA: 0x0033B2C5 File Offset: 0x003394C5
	private void AIFMKCMOHNJ()
	{
		this.INLGCNBONCO = GameObject.Find("), cost hidden").GetComponent<ScrollRect>();
	}

	// Token: 0x0600732D RID: 29485 RVA: 0x0033A990 File Offset: 0x00338B90
	private void EHEMIEJJNIO()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.FNHAIFIHADL = this.DGAAFGDHHHJ.localScale.x;
		this.LOEKDPHFOMD = base.gameObject.GetComponent<Selectable>();
	}

	// Token: 0x0600732E RID: 29486 RVA: 0x0033B2DC File Offset: 0x003394DC
	public void BCPMOFCBNGG(PointerEventData EPIMKFPMMEA)
	{
		this.INLGCNBONCO.OnEndDrag(EPIMKFPMMEA);
		this.AOBIDGCIMPG = true;
		base.StopCoroutine("p");
	}

	// Token: 0x0600732F RID: 29487 RVA: 0x0033B2FC File Offset: 0x003394FC
	private void LBDOGJFKKAB()
	{
		this.DGAAFGDHHHJ.DOKill(true);
	}

	// Token: 0x06007330 RID: 29488 RVA: 0x0033B2FC File Offset: 0x003394FC
	private void EIHABGEFOLK()
	{
		this.DGAAFGDHHHJ.DOKill(true);
	}

	// Token: 0x06007331 RID: 29489 RVA: 0x0033B30B File Offset: 0x0033950B
	private void HPGLEEHELDN()
	{
		this.INLGCNBONCO = GameObject.Find("collect").GetComponent<ScrollRect>();
	}

	// Token: 0x06007332 RID: 29490 RVA: 0x0033B322 File Offset: 0x00339522
	private IEnumerator BANIMICEJOL()
	{
		PointerEventsController.ILHADPDOALL ilhadpdoall = new PointerEventsController.ILHADPDOALL(1);
		ilhadpdoall.<>4__this = this;
		return ilhadpdoall;
	}

	// Token: 0x06007333 RID: 29491 RVA: 0x0033A990 File Offset: 0x00338B90
	private void JNCLGOBJGJD()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.FNHAIFIHADL = this.DGAAFGDHHHJ.localScale.x;
		this.LOEKDPHFOMD = base.gameObject.GetComponent<Selectable>();
	}

	// Token: 0x06007334 RID: 29492 RVA: 0x0033B331 File Offset: 0x00339531
	public void PIPEINLNACK(PointerEventData EPIMKFPMMEA)
	{
		this.INLGCNBONCO.OnBeginDrag(EPIMKFPMMEA);
		this.AOBIDGCIMPG = false;
		this.FGGEHEPKBLJ = false;
	}

	// Token: 0x06007335 RID: 29493 RVA: 0x0033B34D File Offset: 0x0033954D
	public void BGFLGNHDPKO(PointerEventData EPIMKFPMMEA)
	{
		this.onPointerDown.Invoke();
		base.StartCoroutine("t");
	}

	// Token: 0x06007336 RID: 29494 RVA: 0x0033B366 File Offset: 0x00339566
	public void PANLNGKLNMO(PointerEventData EPIMKFPMMEA)
	{
		this.onPointerDown.Invoke();
		base.StartCoroutine("…");
	}

	// Token: 0x06007337 RID: 29495 RVA: 0x0033B2B6 File Offset: 0x003394B6
	private void OnDestroy()
	{
		this.DGAAFGDHHHJ.DOKill(false);
	}

	// Token: 0x06007338 RID: 29496 RVA: 0x0033AD09 File Offset: 0x00338F09
	public void JJKGGBGIJOB(PointerEventData EPIMKFPMMEA)
	{
		this.INLGCNBONCO.OnDrag(EPIMKFPMMEA);
		this.AOBIDGCIMPG = false;
	}

	// Token: 0x06007339 RID: 29497 RVA: 0x0033B37F File Offset: 0x0033957F
	public void JHEFOIFOLIJ(PointerEventData EPIMKFPMMEA)
	{
		this.INLGCNBONCO.OnEndDrag(EPIMKFPMMEA);
		this.AOBIDGCIMPG = true;
		base.StopCoroutine("OnLanguageChange");
	}

	// Token: 0x0600733A RID: 29498 RVA: 0x0033B3A0 File Offset: 0x003395A0
	public void CCOEAMJKBOJ(PointerEventData CACFHMMKMMB)
	{
		if (FocusItem.isFocusOpened)
		{
			return;
		}
		if (!this.AOBIDGCIMPG)
		{
			this.thumbnailItem.GIFCPMIFOGM(this.flashTimeOnPress);
			if (null != this.LOEKDPHFOMD && !this.LOEKDPHFOMD.interactable)
			{
				return;
			}
			if (!this.FPPBAAPCIBB)
			{
				this.DGAAFGDHHHJ.DOKill(false);
				this.DGAAFGDHHHJ.DOScale(this.scaleCoefficient * this.FNHAIFIHADL, 712f);
			}
			this.FPPBAAPCIBB = true;
			this.thumbnailItem.CHJLLAJEPPN(this.flashTimeOnPress);
			this.thumbnailItem.IBCPJMGNNIH();
			FocusItem.isFocusOpened = false;
			if (this.FPPBAAPCIBB)
			{
				this.DGAAFGDHHHJ.DOKill(false);
				this.DGAAFGDHHHJ.DOScale(this.DGAAFGDHHHJ.localScale.x / this.scaleCoefficient, 1081f);
			}
			this.FPPBAAPCIBB = false;
		}
	}

	// Token: 0x0600733B RID: 29499 RVA: 0x0033B48D File Offset: 0x0033968D
	private void EAKEDEEHEDD()
	{
		this.INLGCNBONCO = GameObject.Find("").GetComponent<ScrollRect>();
	}

	// Token: 0x0600733C RID: 29500 RVA: 0x0033B4A4 File Offset: 0x003396A4
	public void OnEndDrag(PointerEventData EPIMKFPMMEA)
	{
		this.INLGCNBONCO.OnEndDrag(EPIMKFPMMEA);
		this.AOBIDGCIMPG = false;
		base.StopCoroutine("MIBJFLNKJLD");
	}

	// Token: 0x0600733D RID: 29501 RVA: 0x0033B322 File Offset: 0x00339522
	private IEnumerator GFEEEIIIJNB()
	{
		PointerEventsController.ILHADPDOALL ilhadpdoall = new PointerEventsController.ILHADPDOALL(1);
		ilhadpdoall.<>4__this = this;
		return ilhadpdoall;
	}

	// Token: 0x0600733E RID: 29502 RVA: 0x0033B4C4 File Offset: 0x003396C4
	public void GEGBBIELLDO(PointerEventData EPIMKFPMMEA)
	{
		this.INLGCNBONCO.OnEndDrag(EPIMKFPMMEA);
		this.AOBIDGCIMPG = true;
		base.StopCoroutine("</i>");
	}

	// Token: 0x0600733F RID: 29503 RVA: 0x0033AD09 File Offset: 0x00338F09
	public void EIDBPGPFIBH(PointerEventData EPIMKFPMMEA)
	{
		this.INLGCNBONCO.OnDrag(EPIMKFPMMEA);
		this.AOBIDGCIMPG = false;
	}

	// Token: 0x06007340 RID: 29504 RVA: 0x0033B4E4 File Offset: 0x003396E4
	private IEnumerator JJDACCDKDFB()
	{
		yield return new WaitForSeconds(0.05f);
		if (!this.AOBIDGCIMPG)
		{
			this.thumbnailItem.FlashOnPointerDown(this.flashTimeOnPress);
			this.AEEBEHOLMCE = true;
			if (null != this.LOEKDPHFOMD && !this.LOEKDPHFOMD.interactable)
			{
				yield return null;
			}
			if (!this.FPPBAAPCIBB)
			{
				this.DGAAFGDHHHJ.DOKill(true);
				this.DGAAFGDHHHJ.DOScale(this.scaleCoefficient * this.FNHAIFIHADL, 0.1f);
			}
			this.FPPBAAPCIBB = true;
		}
		yield break;
	}

	// Token: 0x06007341 RID: 29505 RVA: 0x0033B4F4 File Offset: 0x003396F4
	public void POAOEFNDLJP(PointerEventData EPIMKFPMMEA)
	{
		base.StopCoroutine("{sp}");
		this.onPointerUp.Invoke();
		if (FocusItem.isFocusOpened)
		{
			return;
		}
		if (this.FGGEHEPKBLJ && this.AEEBEHOLMCE)
		{
			this.thumbnailItem.JCFDCBHKNLN(this.flashTimeOnPress);
			this.AEEBEHOLMCE = false;
			if (this.FPPBAAPCIBB)
			{
				this.DGAAFGDHHHJ.DOKill(true);
				this.DGAAFGDHHHJ.DOScale(this.DGAAFGDHHHJ.localScale.x / this.scaleCoefficient, 1306f);
			}
			this.FPPBAAPCIBB = true;
		}
		if (this.AEEBEHOLMCE)
		{
			this.thumbnailItem.MIIIAGBMNFB(this.flashTimeOnPress);
			this.thumbnailItem.LPBAJBCOFJF();
			FocusItem.isFocusOpened = false;
			this.AEEBEHOLMCE = true;
			if (this.FPPBAAPCIBB)
			{
				this.DGAAFGDHHHJ.DOKill(true);
				this.DGAAFGDHHHJ.DOScale(this.DGAAFGDHHHJ.localScale.x / this.scaleCoefficient, 1875f);
			}
			this.FPPBAAPCIBB = false;
		}
	}

	// Token: 0x06007342 RID: 29506 RVA: 0x0033B322 File Offset: 0x00339522
	private IEnumerator COCOEOKHDAG()
	{
		PointerEventsController.ILHADPDOALL ilhadpdoall = new PointerEventsController.ILHADPDOALL(1);
		ilhadpdoall.<>4__this = this;
		return ilhadpdoall;
	}

	// Token: 0x06007343 RID: 29507 RVA: 0x0033A990 File Offset: 0x00338B90
	private void KDHJKIJKBMN()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.FNHAIFIHADL = this.DGAAFGDHHHJ.localScale.x;
		this.LOEKDPHFOMD = base.gameObject.GetComponent<Selectable>();
	}

	// Token: 0x06007344 RID: 29508 RVA: 0x0033B322 File Offset: 0x00339522
	private IEnumerator NIMIHJDFHJN()
	{
		PointerEventsController.ILHADPDOALL ilhadpdoall = new PointerEventsController.ILHADPDOALL(1);
		ilhadpdoall.<>4__this = this;
		return ilhadpdoall;
	}

	// Token: 0x06007345 RID: 29509 RVA: 0x0033B600 File Offset: 0x00339800
	public void MDIGPFEJDDF(PointerEventData EPIMKFPMMEA)
	{
		this.INLGCNBONCO.OnEndDrag(EPIMKFPMMEA);
		this.AOBIDGCIMPG = true;
		base.StopCoroutine("Account.DuplicateAnthologySaveSlot(), wrong slot indices, from:");
	}

	// Token: 0x06007346 RID: 29510 RVA: 0x0033B620 File Offset: 0x00339820
	public void CIMLJLJIIME(PointerEventData EPIMKFPMMEA)
	{
		base.StopCoroutine("w");
		this.onPointerUp.Invoke();
		if (FocusItem.isFocusOpened)
		{
			return;
		}
		if (this.FGGEHEPKBLJ && this.AEEBEHOLMCE)
		{
			this.thumbnailItem.GECGIALBBBL(this.flashTimeOnPress);
			this.AEEBEHOLMCE = false;
			if (this.FPPBAAPCIBB)
			{
				this.DGAAFGDHHHJ.DOKill(false);
				this.DGAAFGDHHHJ.DOScale(this.DGAAFGDHHHJ.localScale.x / this.scaleCoefficient, 340f);
			}
			this.FPPBAAPCIBB = true;
		}
		if (this.AEEBEHOLMCE)
		{
			this.thumbnailItem.CHJLLAJEPPN(this.flashTimeOnPress);
			this.thumbnailItem.LNAJNMKGHAI();
			FocusItem.isFocusOpened = false;
			this.AEEBEHOLMCE = true;
			if (this.FPPBAAPCIBB)
			{
				this.DGAAFGDHHHJ.DOKill(false);
				this.DGAAFGDHHHJ.DOScale(this.DGAAFGDHHHJ.localScale.x / this.scaleCoefficient, 1141f);
			}
			this.FPPBAAPCIBB = false;
		}
	}

	// Token: 0x06007347 RID: 29511 RVA: 0x0033B72C File Offset: 0x0033992C
	public void FIPKMDBNJNI(PointerEventData EPIMKFPMMEA)
	{
		this.INLGCNBONCO.OnEndDrag(EPIMKFPMMEA);
		this.AOBIDGCIMPG = false;
		base.StopCoroutine("OnChapterSnapshotRestore");
	}

	// Token: 0x06007348 RID: 29512 RVA: 0x0033B74C File Offset: 0x0033994C
	public void HPKBGKDJLML(PointerEventData EPIMKFPMMEA)
	{
		base.StopCoroutine("");
		this.onPointerUp.Invoke();
		if (FocusItem.isFocusOpened)
		{
			return;
		}
		if (this.FGGEHEPKBLJ && this.AEEBEHOLMCE)
		{
			this.thumbnailItem.MIIIAGBMNFB(this.flashTimeOnPress);
			this.AEEBEHOLMCE = true;
			if (this.FPPBAAPCIBB)
			{
				this.DGAAFGDHHHJ.DOKill(false);
				this.DGAAFGDHHHJ.DOScale(this.DGAAFGDHHHJ.localScale.x / this.scaleCoefficient, 1591f);
			}
			this.FPPBAAPCIBB = false;
		}
		if (this.AEEBEHOLMCE)
		{
			this.thumbnailItem.ONDEDPILLCN(this.flashTimeOnPress);
			this.thumbnailItem.CEFFJHAJIMI();
			FocusItem.isFocusOpened = false;
			this.AEEBEHOLMCE = false;
			if (this.FPPBAAPCIBB)
			{
				this.DGAAFGDHHHJ.DOKill(false);
				this.DGAAFGDHHHJ.DOScale(this.DGAAFGDHHHJ.localScale.x / this.scaleCoefficient, 780f);
			}
			this.FPPBAAPCIBB = false;
		}
	}

	// Token: 0x06007349 RID: 29513 RVA: 0x0033A990 File Offset: 0x00338B90
	private void LIHMCECHLOI()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.FNHAIFIHADL = this.DGAAFGDHHHJ.localScale.x;
		this.LOEKDPHFOMD = base.gameObject.GetComponent<Selectable>();
	}

	// Token: 0x0600734A RID: 29514 RVA: 0x0033B4E4 File Offset: 0x003396E4
	private IEnumerator MIBJFLNKJLD()
	{
		yield return new WaitForSeconds(0.05f);
		if (!this.AOBIDGCIMPG)
		{
			this.thumbnailItem.FlashOnPointerDown(this.flashTimeOnPress);
			this.AEEBEHOLMCE = true;
			if (null != this.LOEKDPHFOMD && !this.LOEKDPHFOMD.interactable)
			{
				yield return null;
			}
			if (!this.FPPBAAPCIBB)
			{
				this.DGAAFGDHHHJ.DOKill(true);
				this.DGAAFGDHHHJ.DOScale(this.scaleCoefficient * this.FNHAIFIHADL, 0.1f);
			}
			this.FPPBAAPCIBB = true;
		}
		yield break;
	}

	// Token: 0x0600734B RID: 29515 RVA: 0x0033B858 File Offset: 0x00339A58
	public void GFFKGDIHLAA(PointerEventData EPIMKFPMMEA)
	{
		this.INLGCNBONCO.OnEndDrag(EPIMKFPMMEA);
		this.AOBIDGCIMPG = false;
		base.StopCoroutine("OnStoryInterfaceAutoReaderActivate");
	}

	// Token: 0x0600734C RID: 29516 RVA: 0x0033B4E4 File Offset: 0x003396E4
	private IEnumerator ANDNAFOAHAO()
	{
		yield return new WaitForSeconds(0.05f);
		if (!this.AOBIDGCIMPG)
		{
			this.thumbnailItem.FlashOnPointerDown(this.flashTimeOnPress);
			this.AEEBEHOLMCE = true;
			if (null != this.LOEKDPHFOMD && !this.LOEKDPHFOMD.interactable)
			{
				yield return null;
			}
			if (!this.FPPBAAPCIBB)
			{
				this.DGAAFGDHHHJ.DOKill(true);
				this.DGAAFGDHHHJ.DOScale(this.scaleCoefficient * this.FNHAIFIHADL, 0.1f);
			}
			this.FPPBAAPCIBB = true;
		}
		yield break;
	}

	// Token: 0x0600734D RID: 29517 RVA: 0x0033B878 File Offset: 0x00339A78
	public void LEMLIODDKJP(PointerEventData EPIMKFPMMEA)
	{
		this.INLGCNBONCO.OnEndDrag(EPIMKFPMMEA);
		this.AOBIDGCIMPG = true;
		base.StopCoroutine(" scene load issued for ");
	}

	// Token: 0x0600734E RID: 29518 RVA: 0x0033B898 File Offset: 0x00339A98
	public void HFOHDCILLPO(PointerEventData EPIMKFPMMEA)
	{
		base.StopCoroutine(" order ");
		this.onPointerUp.Invoke();
		if (FocusItem.isFocusOpened)
		{
			return;
		}
		if (this.FGGEHEPKBLJ && this.AEEBEHOLMCE)
		{
			this.thumbnailItem.CHJLLAJEPPN(this.flashTimeOnPress);
			this.AEEBEHOLMCE = false;
			if (this.FPPBAAPCIBB)
			{
				this.DGAAFGDHHHJ.DOKill(true);
				this.DGAAFGDHHHJ.DOScale(this.DGAAFGDHHHJ.localScale.x / this.scaleCoefficient, 965f);
			}
			this.FPPBAAPCIBB = false;
		}
		if (this.AEEBEHOLMCE)
		{
			this.thumbnailItem.FlashOnPointerUp(this.flashTimeOnPress);
			this.thumbnailItem.LPBAJBCOFJF();
			FocusItem.isFocusOpened = false;
			this.AEEBEHOLMCE = true;
			if (this.FPPBAAPCIBB)
			{
				this.DGAAFGDHHHJ.DOKill(true);
				this.DGAAFGDHHHJ.DOScale(this.DGAAFGDHHHJ.localScale.x / this.scaleCoefficient, 11f);
			}
			this.FPPBAAPCIBB = false;
		}
	}

	// Token: 0x0600734F RID: 29519 RVA: 0x0033B4E4 File Offset: 0x003396E4
	private IEnumerator GKBKNOLGJOI()
	{
		yield return new WaitForSeconds(0.05f);
		if (!this.AOBIDGCIMPG)
		{
			this.thumbnailItem.FlashOnPointerDown(this.flashTimeOnPress);
			this.AEEBEHOLMCE = true;
			if (null != this.LOEKDPHFOMD && !this.LOEKDPHFOMD.interactable)
			{
				yield return null;
			}
			if (!this.FPPBAAPCIBB)
			{
				this.DGAAFGDHHHJ.DOKill(true);
				this.DGAAFGDHHHJ.DOScale(this.scaleCoefficient * this.FNHAIFIHADL, 0.1f);
			}
			this.FPPBAAPCIBB = true;
		}
		yield break;
	}

	// Token: 0x06007350 RID: 29520 RVA: 0x0033B9A4 File Offset: 0x00339BA4
	public void NDBIBBBHMKE(PointerEventData EPIMKFPMMEA)
	{
		base.StopCoroutine("$USEMAPPINGV2");
		this.onPointerUp.Invoke();
		if (FocusItem.isFocusOpened)
		{
			return;
		}
		if (this.FGGEHEPKBLJ && this.AEEBEHOLMCE)
		{
			this.thumbnailItem.FlashOnPointerUp(this.flashTimeOnPress);
			this.AEEBEHOLMCE = false;
			if (this.FPPBAAPCIBB)
			{
				this.DGAAFGDHHHJ.DOKill(false);
				this.DGAAFGDHHHJ.DOScale(this.DGAAFGDHHHJ.localScale.x / this.scaleCoefficient, 672f);
			}
			this.FPPBAAPCIBB = true;
		}
		if (this.AEEBEHOLMCE)
		{
			this.thumbnailItem.MIIIAGBMNFB(this.flashTimeOnPress);
			this.thumbnailItem.ACDIDLCHDGL();
			FocusItem.isFocusOpened = true;
			this.AEEBEHOLMCE = true;
			if (this.FPPBAAPCIBB)
			{
				this.DGAAFGDHHHJ.DOKill(true);
				this.DGAAFGDHHHJ.DOScale(this.DGAAFGDHHHJ.localScale.x / this.scaleCoefficient, 1711f);
			}
			this.FPPBAAPCIBB = true;
		}
	}

	// Token: 0x06007351 RID: 29521 RVA: 0x0033BAB0 File Offset: 0x00339CB0
	public void BJHHCPKGBIA(PointerEventData CACFHMMKMMB)
	{
		if (FocusItem.isFocusOpened)
		{
			return;
		}
		if (!this.AOBIDGCIMPG)
		{
			this.thumbnailItem.NJGKKHNJOEN(this.flashTimeOnPress);
			if (null != this.LOEKDPHFOMD && !this.LOEKDPHFOMD.interactable)
			{
				return;
			}
			if (!this.FPPBAAPCIBB)
			{
				this.DGAAFGDHHHJ.DOKill(false);
				this.DGAAFGDHHHJ.DOScale(this.scaleCoefficient * this.FNHAIFIHADL, 1308f);
			}
			this.FPPBAAPCIBB = true;
			this.thumbnailItem.ONDEDPILLCN(this.flashTimeOnPress);
			this.thumbnailItem.LNAJNMKGHAI();
			FocusItem.isFocusOpened = true;
			if (this.FPPBAAPCIBB)
			{
				this.DGAAFGDHHHJ.DOKill(false);
				this.DGAAFGDHHHJ.DOScale(this.DGAAFGDHHHJ.localScale.x / this.scaleCoefficient, 428f);
			}
			this.FPPBAAPCIBB = false;
		}
	}

	// Token: 0x06007352 RID: 29522 RVA: 0x0033BBA0 File Offset: 0x00339DA0
	public void EKEIBPDKPIK(PointerEventData EPIMKFPMMEA)
	{
		base.StopCoroutine("+");
		this.onPointerUp.Invoke();
		if (FocusItem.isFocusOpened)
		{
			return;
		}
		if (this.FGGEHEPKBLJ && this.AEEBEHOLMCE)
		{
			this.thumbnailItem.MIIIAGBMNFB(this.flashTimeOnPress);
			this.AEEBEHOLMCE = true;
			if (this.FPPBAAPCIBB)
			{
				this.DGAAFGDHHHJ.DOKill(false);
				this.DGAAFGDHHHJ.DOScale(this.DGAAFGDHHHJ.localScale.x / this.scaleCoefficient, 240f);
			}
			this.FPPBAAPCIBB = true;
		}
		if (this.AEEBEHOLMCE)
		{
			this.thumbnailItem.GECGIALBBBL(this.flashTimeOnPress);
			this.thumbnailItem.LNAJNMKGHAI();
			FocusItem.isFocusOpened = false;
			this.AEEBEHOLMCE = false;
			if (this.FPPBAAPCIBB)
			{
				this.DGAAFGDHHHJ.DOKill(false);
				this.DGAAFGDHHHJ.DOScale(this.DGAAFGDHHHJ.localScale.x / this.scaleCoefficient, 938f);
			}
			this.FPPBAAPCIBB = true;
		}
	}

	// Token: 0x06007353 RID: 29523 RVA: 0x0033B278 File Offset: 0x00339478
	public void JPKGLJGHJKN(PointerEventData EPIMKFPMMEA)
	{
		this.INLGCNBONCO.OnDrag(EPIMKFPMMEA);
		this.AOBIDGCIMPG = true;
	}

	// Token: 0x06007354 RID: 29524 RVA: 0x0033B4E4 File Offset: 0x003396E4
	private IEnumerator OCHHHJEOCED()
	{
		yield return new WaitForSeconds(0.05f);
		if (!this.AOBIDGCIMPG)
		{
			this.thumbnailItem.FlashOnPointerDown(this.flashTimeOnPress);
			this.AEEBEHOLMCE = true;
			if (null != this.LOEKDPHFOMD && !this.LOEKDPHFOMD.interactable)
			{
				yield return null;
			}
			if (!this.FPPBAAPCIBB)
			{
				this.DGAAFGDHHHJ.DOKill(true);
				this.DGAAFGDHHHJ.DOScale(this.scaleCoefficient * this.FNHAIFIHADL, 0.1f);
			}
			this.FPPBAAPCIBB = true;
		}
		yield break;
	}

	// Token: 0x06007355 RID: 29525 RVA: 0x0033B48D File Offset: 0x0033968D
	private void CEDGALPCOLA()
	{
		this.INLGCNBONCO = GameObject.Find("").GetComponent<ScrollRect>();
	}

	// Token: 0x06007356 RID: 29526 RVA: 0x0033BCAC File Offset: 0x00339EAC
	public void IFLKLJCNOLI(PointerEventData CACFHMMKMMB)
	{
		if (FocusItem.isFocusOpened)
		{
			return;
		}
		if (!this.AOBIDGCIMPG)
		{
			this.thumbnailItem.GIFCPMIFOGM(this.flashTimeOnPress);
			if (null != this.LOEKDPHFOMD && !this.LOEKDPHFOMD.interactable)
			{
				return;
			}
			if (!this.FPPBAAPCIBB)
			{
				this.DGAAFGDHHHJ.DOKill(false);
				this.DGAAFGDHHHJ.DOScale(this.scaleCoefficient * this.FNHAIFIHADL, 351f);
			}
			this.FPPBAAPCIBB = true;
			this.thumbnailItem.GAHPOJAPPAP(this.flashTimeOnPress);
			this.thumbnailItem.LMKKOEICIMA();
			FocusItem.isFocusOpened = false;
			if (this.FPPBAAPCIBB)
			{
				this.DGAAFGDHHHJ.DOKill(true);
				this.DGAAFGDHHHJ.DOScale(this.DGAAFGDHHHJ.localScale.x / this.scaleCoefficient, 544f);
			}
			this.FPPBAAPCIBB = false;
		}
	}

	// Token: 0x06007357 RID: 29527 RVA: 0x0033B322 File Offset: 0x00339522
	private IEnumerator HFKFEEADCIP()
	{
		PointerEventsController.ILHADPDOALL ilhadpdoall = new PointerEventsController.ILHADPDOALL(1);
		ilhadpdoall.<>4__this = this;
		return ilhadpdoall;
	}

	// Token: 0x06007358 RID: 29528 RVA: 0x0033B322 File Offset: 0x00339522
	private IEnumerator KONJCHKHJBE()
	{
		PointerEventsController.ILHADPDOALL ilhadpdoall = new PointerEventsController.ILHADPDOALL(1);
		ilhadpdoall.<>4__this = this;
		return ilhadpdoall;
	}

	// Token: 0x06007359 RID: 29529 RVA: 0x0033B2FC File Offset: 0x003394FC
	private void MOCDMCLPBKC()
	{
		this.DGAAFGDHHHJ.DOKill(true);
	}

	// Token: 0x0600735A RID: 29530 RVA: 0x0033B278 File Offset: 0x00339478
	public void CILJMGGJHDL(PointerEventData EPIMKFPMMEA)
	{
		this.INLGCNBONCO.OnDrag(EPIMKFPMMEA);
		this.AOBIDGCIMPG = true;
	}

	// Token: 0x0600735B RID: 29531 RVA: 0x0033B278 File Offset: 0x00339478
	public void MOGGIOPDKBL(PointerEventData EPIMKFPMMEA)
	{
		this.INLGCNBONCO.OnDrag(EPIMKFPMMEA);
		this.AOBIDGCIMPG = true;
	}

	// Token: 0x0600735C RID: 29532 RVA: 0x0033B2FC File Offset: 0x003394FC
	private void INJJOHNFBKH()
	{
		this.DGAAFGDHHHJ.DOKill(true);
	}

	// Token: 0x0600735D RID: 29533 RVA: 0x0033B322 File Offset: 0x00339522
	private IEnumerator NMIOAOFCFOK()
	{
		PointerEventsController.ILHADPDOALL ilhadpdoall = new PointerEventsController.ILHADPDOALL(1);
		ilhadpdoall.<>4__this = this;
		return ilhadpdoall;
	}

	// Token: 0x0600735E RID: 29534 RVA: 0x0033AD09 File Offset: 0x00338F09
	public void ICFAPKLFIFD(PointerEventData EPIMKFPMMEA)
	{
		this.INLGCNBONCO.OnDrag(EPIMKFPMMEA);
		this.AOBIDGCIMPG = false;
	}

	// Token: 0x0600735F RID: 29535 RVA: 0x0033A990 File Offset: 0x00338B90
	private void AOOANKECKCJ()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.FNHAIFIHADL = this.DGAAFGDHHHJ.localScale.x;
		this.LOEKDPHFOMD = base.gameObject.GetComponent<Selectable>();
	}

	// Token: 0x06007360 RID: 29536 RVA: 0x0033BD9C File Offset: 0x00339F9C
	public void JMDFFDMDOJD(PointerEventData CACFHMMKMMB)
	{
		if (FocusItem.isFocusOpened)
		{
			return;
		}
		if (!this.AOBIDGCIMPG)
		{
			this.thumbnailItem.NJGKKHNJOEN(this.flashTimeOnPress);
			if (null != this.LOEKDPHFOMD && !this.LOEKDPHFOMD.interactable)
			{
				return;
			}
			if (!this.FPPBAAPCIBB)
			{
				this.DGAAFGDHHHJ.DOKill(true);
				this.DGAAFGDHHHJ.DOScale(this.scaleCoefficient * this.FNHAIFIHADL, 569f);
			}
			this.FPPBAAPCIBB = true;
			this.thumbnailItem.MIIIAGBMNFB(this.flashTimeOnPress);
			this.thumbnailItem.ACDIDLCHDGL();
			FocusItem.isFocusOpened = false;
			if (this.FPPBAAPCIBB)
			{
				this.DGAAFGDHHHJ.DOKill(true);
				this.DGAAFGDHHHJ.DOScale(this.DGAAFGDHHHJ.localScale.x / this.scaleCoefficient, 1294f);
			}
			this.FPPBAAPCIBB = false;
		}
	}

	// Token: 0x06007361 RID: 29537 RVA: 0x0033BE89 File Offset: 0x0033A089
	public void BFLHFHAJPEA(PointerEventData EPIMKFPMMEA)
	{
		this.INLGCNBONCO.OnEndDrag(EPIMKFPMMEA);
		this.AOBIDGCIMPG = false;
		base.StopCoroutine("tbits");
	}

	// Token: 0x06007362 RID: 29538 RVA: 0x0033BEAC File Offset: 0x0033A0AC
	public void JDBOFEHOBEI(PointerEventData CACFHMMKMMB)
	{
		if (FocusItem.isFocusOpened)
		{
			return;
		}
		if (!this.AOBIDGCIMPG)
		{
			this.thumbnailItem.NJGKKHNJOEN(this.flashTimeOnPress);
			if (null != this.LOEKDPHFOMD && !this.LOEKDPHFOMD.interactable)
			{
				return;
			}
			if (!this.FPPBAAPCIBB)
			{
				this.DGAAFGDHHHJ.DOKill(true);
				this.DGAAFGDHHHJ.DOScale(this.scaleCoefficient * this.FNHAIFIHADL, 993f);
			}
			this.FPPBAAPCIBB = true;
			this.thumbnailItem.FlashOnPointerUp(this.flashTimeOnPress);
			this.thumbnailItem.LMKKOEICIMA();
			FocusItem.isFocusOpened = false;
			if (this.FPPBAAPCIBB)
			{
				this.DGAAFGDHHHJ.DOKill(false);
				this.DGAAFGDHHHJ.DOScale(this.DGAAFGDHHHJ.localScale.x / this.scaleCoefficient, 1651f);
			}
			this.FPPBAAPCIBB = true;
		}
	}

	// Token: 0x06007363 RID: 29539 RVA: 0x0033B322 File Offset: 0x00339522
	private IEnumerator MLFPAOOCFDB()
	{
		PointerEventsController.ILHADPDOALL ilhadpdoall = new PointerEventsController.ILHADPDOALL(1);
		ilhadpdoall.<>4__this = this;
		return ilhadpdoall;
	}

	// Token: 0x06007364 RID: 29540 RVA: 0x0033B278 File Offset: 0x00339478
	public void OnDrag(PointerEventData EPIMKFPMMEA)
	{
		this.INLGCNBONCO.OnDrag(EPIMKFPMMEA);
		this.AOBIDGCIMPG = true;
	}

	// Token: 0x06007365 RID: 29541 RVA: 0x0033BF99 File Offset: 0x0033A199
	public void OnPointerDown(PointerEventData EPIMKFPMMEA)
	{
		this.onPointerDown.Invoke();
		base.StartCoroutine("MIBJFLNKJLD");
	}

	// Token: 0x06007366 RID: 29542 RVA: 0x0033BFB2 File Offset: 0x0033A1B2
	public void OIOKAGPELDI(PointerEventData EPIMKFPMMEA)
	{
		this.INLGCNBONCO.OnBeginDrag(EPIMKFPMMEA);
		this.AOBIDGCIMPG = true;
		this.FGGEHEPKBLJ = true;
	}

	// Token: 0x06007367 RID: 29543 RVA: 0x0033A990 File Offset: 0x00338B90
	private void Awake()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.FNHAIFIHADL = this.DGAAFGDHHHJ.localScale.x;
		this.LOEKDPHFOMD = base.gameObject.GetComponent<Selectable>();
	}

	// Token: 0x06007368 RID: 29544 RVA: 0x0033BFD0 File Offset: 0x0033A1D0
	public void IEKKFKIEPEH(PointerEventData EPIMKFPMMEA)
	{
		base.StopCoroutine("null");
		this.onPointerUp.Invoke();
		if (FocusItem.isFocusOpened)
		{
			return;
		}
		if (this.FGGEHEPKBLJ && this.AEEBEHOLMCE)
		{
			this.thumbnailItem.JCFDCBHKNLN(this.flashTimeOnPress);
			this.AEEBEHOLMCE = false;
			if (this.FPPBAAPCIBB)
			{
				this.DGAAFGDHHHJ.DOKill(true);
				this.DGAAFGDHHHJ.DOScale(this.DGAAFGDHHHJ.localScale.x / this.scaleCoefficient, 1309f);
			}
			this.FPPBAAPCIBB = false;
		}
		if (this.AEEBEHOLMCE)
		{
			this.thumbnailItem.ONDEDPILLCN(this.flashTimeOnPress);
			this.thumbnailItem.ACDIDLCHDGL();
			FocusItem.isFocusOpened = false;
			this.AEEBEHOLMCE = false;
			if (this.FPPBAAPCIBB)
			{
				this.DGAAFGDHHHJ.DOKill(true);
				this.DGAAFGDHHHJ.DOScale(this.DGAAFGDHHHJ.localScale.x / this.scaleCoefficient, 1343f);
			}
			this.FPPBAAPCIBB = true;
		}
	}

	// Token: 0x06007369 RID: 29545 RVA: 0x0033BFB2 File Offset: 0x0033A1B2
	public void OnBeginDrag(PointerEventData EPIMKFPMMEA)
	{
		this.INLGCNBONCO.OnBeginDrag(EPIMKFPMMEA);
		this.AOBIDGCIMPG = true;
		this.FGGEHEPKBLJ = true;
	}

	// Token: 0x0600736A RID: 29546 RVA: 0x0033C0DC File Offset: 0x0033A2DC
	public void DKCAIPCHACI(PointerEventData CACFHMMKMMB)
	{
		if (FocusItem.isFocusOpened)
		{
			return;
		}
		if (!this.AOBIDGCIMPG)
		{
			this.thumbnailItem.GIFCPMIFOGM(this.flashTimeOnPress);
			if (null != this.LOEKDPHFOMD && !this.LOEKDPHFOMD.interactable)
			{
				return;
			}
			if (!this.FPPBAAPCIBB)
			{
				this.DGAAFGDHHHJ.DOKill(true);
				this.DGAAFGDHHHJ.DOScale(this.scaleCoefficient * this.FNHAIFIHADL, 347f);
			}
			this.FPPBAAPCIBB = false;
			this.thumbnailItem.GECGIALBBBL(this.flashTimeOnPress);
			this.thumbnailItem.LMKKOEICIMA();
			FocusItem.isFocusOpened = false;
			if (this.FPPBAAPCIBB)
			{
				this.DGAAFGDHHHJ.DOKill(false);
				this.DGAAFGDHHHJ.DOScale(this.DGAAFGDHHHJ.localScale.x / this.scaleCoefficient, 707f);
			}
			this.FPPBAAPCIBB = true;
		}
	}

	// Token: 0x0600736B RID: 29547 RVA: 0x0033C1CC File Offset: 0x0033A3CC
	public void HDPKPFJKEML(PointerEventData CACFHMMKMMB)
	{
		if (FocusItem.isFocusOpened)
		{
			return;
		}
		if (!this.AOBIDGCIMPG)
		{
			this.thumbnailItem.IKIMGINENCO(this.flashTimeOnPress);
			if (null != this.LOEKDPHFOMD && !this.LOEKDPHFOMD.interactable)
			{
				return;
			}
			if (!this.FPPBAAPCIBB)
			{
				this.DGAAFGDHHHJ.DOKill(true);
				this.DGAAFGDHHHJ.DOScale(this.scaleCoefficient * this.FNHAIFIHADL, 578f);
			}
			this.FPPBAAPCIBB = false;
			this.thumbnailItem.GECGIALBBBL(this.flashTimeOnPress);
			this.thumbnailItem.LPBAJBCOFJF();
			FocusItem.isFocusOpened = true;
			if (this.FPPBAAPCIBB)
			{
				this.DGAAFGDHHHJ.DOKill(false);
				this.DGAAFGDHHHJ.DOScale(this.DGAAFGDHHHJ.localScale.x / this.scaleCoefficient, 1901f);
			}
			this.FPPBAAPCIBB = false;
		}
	}

	// Token: 0x0600736C RID: 29548 RVA: 0x0033C2B9 File Offset: 0x0033A4B9
	public void OKBIDFLKHKK(PointerEventData EPIMKFPMMEA)
	{
		this.INLGCNBONCO.OnEndDrag(EPIMKFPMMEA);
		this.AOBIDGCIMPG = true;
		base.StopCoroutine("");
	}

	// Token: 0x0600736D RID: 29549 RVA: 0x0033B278 File Offset: 0x00339478
	public void BOPDOMDFDCC(PointerEventData EPIMKFPMMEA)
	{
		this.INLGCNBONCO.OnDrag(EPIMKFPMMEA);
		this.AOBIDGCIMPG = true;
	}

	// Token: 0x0600736E RID: 29550 RVA: 0x0033C2D9 File Offset: 0x0033A4D9
	public void IOLINCPHFGG(PointerEventData EPIMKFPMMEA)
	{
		this.INLGCNBONCO.OnBeginDrag(EPIMKFPMMEA);
		this.AOBIDGCIMPG = true;
		this.FGGEHEPKBLJ = false;
	}

	// Token: 0x0600736F RID: 29551 RVA: 0x0033C2F5 File Offset: 0x0033A4F5
	public void MMPAGHLGONC(PointerEventData EPIMKFPMMEA)
	{
		this.INLGCNBONCO.OnBeginDrag(EPIMKFPMMEA);
		this.AOBIDGCIMPG = false;
		this.FGGEHEPKBLJ = true;
	}

	// Token: 0x06007370 RID: 29552 RVA: 0x0033B2B6 File Offset: 0x003394B6
	private void CODLJCAKBLI()
	{
		this.DGAAFGDHHHJ.DOKill(false);
	}

	// Token: 0x06007371 RID: 29553 RVA: 0x0033C311 File Offset: 0x0033A511
	public void HINDBOLLBOG(PointerEventData EPIMKFPMMEA)
	{
		this.INLGCNBONCO.OnEndDrag(EPIMKFPMMEA);
		this.AOBIDGCIMPG = true;
		base.StopCoroutine("avtssnap1");
	}

	// Token: 0x06007372 RID: 29554 RVA: 0x0033AD09 File Offset: 0x00338F09
	public void AJKPDMLGNGM(PointerEventData EPIMKFPMMEA)
	{
		this.INLGCNBONCO.OnDrag(EPIMKFPMMEA);
		this.AOBIDGCIMPG = false;
	}

	// Token: 0x06007373 RID: 29555 RVA: 0x0033C2D9 File Offset: 0x0033A4D9
	public void LLEPHDHEMHP(PointerEventData EPIMKFPMMEA)
	{
		this.INLGCNBONCO.OnBeginDrag(EPIMKFPMMEA);
		this.AOBIDGCIMPG = true;
		this.FGGEHEPKBLJ = false;
	}

	// Token: 0x06007374 RID: 29556 RVA: 0x0033AD09 File Offset: 0x00338F09
	public void KBKLHFAKGEO(PointerEventData EPIMKFPMMEA)
	{
		this.INLGCNBONCO.OnDrag(EPIMKFPMMEA);
		this.AOBIDGCIMPG = false;
	}

	// Token: 0x06007375 RID: 29557 RVA: 0x0033C331 File Offset: 0x0033A531
	public void BOJNHMKPLGI(PointerEventData EPIMKFPMMEA)
	{
		this.INLGCNBONCO.OnEndDrag(EPIMKFPMMEA);
		this.AOBIDGCIMPG = false;
		base.StopCoroutine("chass");
	}

	// Token: 0x06007376 RID: 29558 RVA: 0x0033A990 File Offset: 0x00338B90
	private void OADBEGOCCBA()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.FNHAIFIHADL = this.DGAAFGDHHHJ.localScale.x;
		this.LOEKDPHFOMD = base.gameObject.GetComponent<Selectable>();
	}

	// Token: 0x06007377 RID: 29559 RVA: 0x0033C354 File Offset: 0x0033A554
	public void CDCNONEHLCC(PointerEventData EPIMKFPMMEA)
	{
		base.StopCoroutine("sfxtimeoutwarning");
		this.onPointerUp.Invoke();
		if (FocusItem.isFocusOpened)
		{
			return;
		}
		if (this.FGGEHEPKBLJ && this.AEEBEHOLMCE)
		{
			this.thumbnailItem.CHJLLAJEPPN(this.flashTimeOnPress);
			this.AEEBEHOLMCE = true;
			if (this.FPPBAAPCIBB)
			{
				this.DGAAFGDHHHJ.DOKill(true);
				this.DGAAFGDHHHJ.DOScale(this.DGAAFGDHHHJ.localScale.x / this.scaleCoefficient, 977f);
			}
			this.FPPBAAPCIBB = true;
		}
		if (this.AEEBEHOLMCE)
		{
			this.thumbnailItem.FlashOnPointerUp(this.flashTimeOnPress);
			this.thumbnailItem.LMKKOEICIMA();
			FocusItem.isFocusOpened = true;
			this.AEEBEHOLMCE = false;
			if (this.FPPBAAPCIBB)
			{
				this.DGAAFGDHHHJ.DOKill(true);
				this.DGAAFGDHHHJ.DOScale(this.DGAAFGDHHHJ.localScale.x / this.scaleCoefficient, 228f);
			}
			this.FPPBAAPCIBB = false;
		}
	}

	// Token: 0x06007378 RID: 29560 RVA: 0x0033B2B6 File Offset: 0x003394B6
	private void LAPDFFGEDMH()
	{
		this.DGAAFGDHHHJ.DOKill(false);
	}

	// Token: 0x06007379 RID: 29561 RVA: 0x0033C460 File Offset: 0x0033A660
	public void NPFLJNKFLMJ(PointerEventData EPIMKFPMMEA)
	{
		base.StopCoroutine("ach");
		this.onPointerUp.Invoke();
		if (FocusItem.isFocusOpened)
		{
			return;
		}
		if (this.FGGEHEPKBLJ && this.AEEBEHOLMCE)
		{
			this.thumbnailItem.MIIIAGBMNFB(this.flashTimeOnPress);
			this.AEEBEHOLMCE = true;
			if (this.FPPBAAPCIBB)
			{
				this.DGAAFGDHHHJ.DOKill(false);
				this.DGAAFGDHHHJ.DOScale(this.DGAAFGDHHHJ.localScale.x / this.scaleCoefficient, 415f);
			}
			this.FPPBAAPCIBB = false;
		}
		if (this.AEEBEHOLMCE)
		{
			this.thumbnailItem.JCFDCBHKNLN(this.flashTimeOnPress);
			this.thumbnailItem.LPBAJBCOFJF();
			FocusItem.isFocusOpened = false;
			this.AEEBEHOLMCE = false;
			if (this.FPPBAAPCIBB)
			{
				this.DGAAFGDHHHJ.DOKill(false);
				this.DGAAFGDHHHJ.DOScale(this.DGAAFGDHHHJ.localScale.x / this.scaleCoefficient, 941f);
			}
			this.FPPBAAPCIBB = false;
		}
	}

	// Token: 0x0600737A RID: 29562 RVA: 0x0033AD09 File Offset: 0x00338F09
	public void JOGHLDALOMB(PointerEventData EPIMKFPMMEA)
	{
		this.INLGCNBONCO.OnDrag(EPIMKFPMMEA);
		this.AOBIDGCIMPG = false;
	}

	// Token: 0x0600737B RID: 29563 RVA: 0x0033B2FC File Offset: 0x003394FC
	private void HLKKMONAIMG()
	{
		this.DGAAFGDHHHJ.DOKill(true);
	}

	// Token: 0x0600737C RID: 29564 RVA: 0x0033B48D File Offset: 0x0033968D
	private void ODOOIGEDLKB()
	{
		this.INLGCNBONCO = GameObject.Find("").GetComponent<ScrollRect>();
	}

	// Token: 0x0600737D RID: 29565 RVA: 0x0033C56C File Offset: 0x0033A76C
	private void Start()
	{
		this.INLGCNBONCO = GameObject.Find("ScrollView0").GetComponent<ScrollRect>();
	}

	// Token: 0x0600737E RID: 29566 RVA: 0x0033C583 File Offset: 0x0033A783
	public void GDFFBIDLAFL(PointerEventData EPIMKFPMMEA)
	{
		this.INLGCNBONCO.OnEndDrag(EPIMKFPMMEA);
		this.AOBIDGCIMPG = true;
		base.StopCoroutine("SKIPPED loading of SFX bundles due to override or because SFX is off in settings.");
	}

	// Token: 0x0600737F RID: 29567 RVA: 0x0033AD09 File Offset: 0x00338F09
	public void LKHBNGIDPGB(PointerEventData EPIMKFPMMEA)
	{
		this.INLGCNBONCO.OnDrag(EPIMKFPMMEA);
		this.AOBIDGCIMPG = false;
	}

	// Token: 0x06007380 RID: 29568 RVA: 0x0033C5A3 File Offset: 0x0033A7A3
	public void BOPOBNBDEJB(PointerEventData EPIMKFPMMEA)
	{
		this.onPointerDown.Invoke();
		base.StartCoroutine("openUrlOnClick");
	}

	// Token: 0x06007381 RID: 29569 RVA: 0x0033C5BC File Offset: 0x0033A7BC
	public void OnPointerClick(PointerEventData CACFHMMKMMB)
	{
		if (FocusItem.isFocusOpened)
		{
			return;
		}
		if (!this.AOBIDGCIMPG)
		{
			this.thumbnailItem.FlashOnPointerDown(this.flashTimeOnPress);
			if (null != this.LOEKDPHFOMD && !this.LOEKDPHFOMD.interactable)
			{
				return;
			}
			if (!this.FPPBAAPCIBB)
			{
				this.DGAAFGDHHHJ.DOKill(true);
				this.DGAAFGDHHHJ.DOScale(this.scaleCoefficient * this.FNHAIFIHADL, 0.1f);
			}
			this.FPPBAAPCIBB = true;
			this.thumbnailItem.FlashOnPointerUp(this.flashTimeOnPress);
			this.thumbnailItem.OpenFocusPanelOnPointerUp();
			FocusItem.isFocusOpened = true;
			if (this.FPPBAAPCIBB)
			{
				this.DGAAFGDHHHJ.DOKill(true);
				this.DGAAFGDHHHJ.DOScale(this.DGAAFGDHHHJ.localScale.x / this.scaleCoefficient, 0.1f);
			}
			this.FPPBAAPCIBB = false;
		}
	}

	// Token: 0x06007382 RID: 29570 RVA: 0x0033C6A9 File Offset: 0x0033A8A9
	public void FHNKKAONOAH(PointerEventData EPIMKFPMMEA)
	{
		this.INLGCNBONCO.OnEndDrag(EPIMKFPMMEA);
		this.AOBIDGCIMPG = true;
		base.StopCoroutine("credo");
	}

	// Token: 0x06007383 RID: 29571 RVA: 0x0033C6C9 File Offset: 0x0033A8C9
	public void CCLOKBLGMIF(PointerEventData EPIMKFPMMEA)
	{
		this.INLGCNBONCO.OnEndDrag(EPIMKFPMMEA);
		this.AOBIDGCIMPG = true;
		base.StopCoroutine("timeoutwarning");
	}

	// Token: 0x06007384 RID: 29572 RVA: 0x0033B322 File Offset: 0x00339522
	private IEnumerator DNHNAJPBCLG()
	{
		PointerEventsController.ILHADPDOALL ilhadpdoall = new PointerEventsController.ILHADPDOALL(1);
		ilhadpdoall.<>4__this = this;
		return ilhadpdoall;
	}

	// Token: 0x06007385 RID: 29573 RVA: 0x0033C6E9 File Offset: 0x0033A8E9
	public void DCJIOCAAECB(PointerEventData EPIMKFPMMEA)
	{
		this.INLGCNBONCO.OnEndDrag(EPIMKFPMMEA);
		this.AOBIDGCIMPG = false;
		base.StopCoroutine("OnApplicationFocusNeedToUpdateCurrency");
	}

	// Token: 0x06007386 RID: 29574 RVA: 0x0033A990 File Offset: 0x00338B90
	private void ANPIDDAIALE()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.FNHAIFIHADL = this.DGAAFGDHHHJ.localScale.x;
		this.LOEKDPHFOMD = base.gameObject.GetComponent<Selectable>();
	}

	// Token: 0x06007387 RID: 29575 RVA: 0x0033C709 File Offset: 0x0033A909
	public void GDIKEEGFNON(PointerEventData EPIMKFPMMEA)
	{
		this.onPointerDown.Invoke();
		base.StartCoroutine(" | Caching.ready=");
	}

	// Token: 0x06007388 RID: 29576 RVA: 0x0033C724 File Offset: 0x0033A924
	public void PGIFJOCDGCL(PointerEventData CACFHMMKMMB)
	{
		if (FocusItem.isFocusOpened)
		{
			return;
		}
		if (!this.AOBIDGCIMPG)
		{
			this.thumbnailItem.INDEFCKPHHC(this.flashTimeOnPress);
			if (null != this.LOEKDPHFOMD && !this.LOEKDPHFOMD.interactable)
			{
				return;
			}
			if (!this.FPPBAAPCIBB)
			{
				this.DGAAFGDHHHJ.DOKill(true);
				this.DGAAFGDHHHJ.DOScale(this.scaleCoefficient * this.FNHAIFIHADL, 14f);
			}
			this.FPPBAAPCIBB = true;
			this.thumbnailItem.GECGIALBBBL(this.flashTimeOnPress);
			this.thumbnailItem.CEFFJHAJIMI();
			FocusItem.isFocusOpened = false;
			if (this.FPPBAAPCIBB)
			{
				this.DGAAFGDHHHJ.DOKill(true);
				this.DGAAFGDHHHJ.DOScale(this.DGAAFGDHHHJ.localScale.x / this.scaleCoefficient, 1222f);
			}
			this.FPPBAAPCIBB = false;
		}
	}

	// Token: 0x04002248 RID: 8776
	public ThumbnailItem thumbnailItem;

	// Token: 0x04002249 RID: 8777
	public float flashTimeOnPress = 0.1f;

	// Token: 0x0400224A RID: 8778
	public UnityEvent onPointerDown;

	// Token: 0x0400224B RID: 8779
	public UnityEvent onPointerUp;

	// Token: 0x0400224C RID: 8780
	private bool AEEBEHOLMCE;

	// Token: 0x0400224D RID: 8781
	private bool AOBIDGCIMPG;

	// Token: 0x0400224E RID: 8782
	private bool FGGEHEPKBLJ;

	// Token: 0x0400224F RID: 8783
	private ScrollRect INLGCNBONCO;

	// Token: 0x04002250 RID: 8784
	public float scaleCoefficient = 0.97f;

	// Token: 0x04002251 RID: 8785
	private float FNHAIFIHADL = 1f;

	// Token: 0x04002252 RID: 8786
	private bool FPPBAAPCIBB;

	// Token: 0x04002253 RID: 8787
	private RectTransform DGAAFGDHHHJ;

	// Token: 0x04002254 RID: 8788
	private Selectable LOEKDPHFOMD;
}
