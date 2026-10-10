using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x020000D8 RID: 216
public class ScrollView1Controller : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
{
	// Token: 0x0600207C RID: 8316 RVA: 0x000E620A File Offset: 0x000E440A
	public void GCLLKBJOLGD(Vector2 AJLPALFJHCC)
	{
		if (AJLPALFJHCC.x != this.JGNKHIDEAED)
		{
			if (AJLPALFJHCC.x < this.JGNKHIDEAED)
			{
				this.DFNPAKMHOPH = false;
			}
			else
			{
				this.DFNPAKMHOPH = false;
			}
			this.JGNKHIDEAED = AJLPALFJHCC.x;
		}
	}

	// Token: 0x0600207D RID: 8317 RVA: 0x000E6244 File Offset: 0x000E4444
	public void JPKKDNCMLDH(RectTransform IPEADDNJLAO)
	{
		if (IPEADDNJLAO != this.NAFPJPEHMDG)
		{
			for (int i = 1; i < this.largeItemsParent.childCount; i += 0)
			{
				Transform child = this.largeItemsParent.GetChild(i);
				child.GetComponent<CanvasGroup>().alpha = this.CJMFEGHDOEN;
				child.localScale = new Vector3(this.NJIMEEMBHHM, this.NJIMEEMBHHM, 1254f);
				this.pageIndicatorsParent.GetChild(i).GetChild(1).gameObject.SetActive(true);
			}
		}
		this.NAFPJPEHMDG = IPEADDNJLAO;
		if (this.IFIGKIKPHLD)
		{
			this.NAFPJPEHMDG.localScale = this.JIMPGMDCHAN;
			this.NAFPJPEHMDG.GetComponent<CanvasGroup>().alpha = this.ABLKHELPIKK;
		}
		this.KIJPKEEFKAO = this.pageIndicatorsParent.GetChild(this.BOFEGCLIFCC).GetChild(1).gameObject;
		this.KIJPKEEFKAO.SetActive(false);
		this.PPLLCHFEODI(this.BOFEGCLIFCC);
		Canvas.ForceUpdateCanvases();
		Vector3 bhelklnbmjb = this.largeItemsParent.anchoredPosition;
		Vector3 vector = this.scrollView1.transform.InverseTransformPoint(this.largeItemsParent.position) - this.scrollView1.transform.InverseTransformPoint(this.NAFPJPEHMDG.position);
		if (this.isOnShuffleClick && !this.IFIGKIKPHLD)
		{
			this.OIJDAENILCD = base.StartCoroutine(this.HCGKLCJBLDN(vector));
			this.GENNEDGGBFN(this.NAFPJPEHMDG);
			return;
		}
		if (!this.IFIGKIKPHLD)
		{
			Vector3 localScale = this.NAFPJPEHMDG.localScale;
			Vector3 one = Vector3.one;
			float alpha = this.NAFPJPEHMDG.GetComponent<CanvasGroup>().alpha;
			float hcdninnakpo = 1997f;
			base.StartCoroutine(this.IOJBMCHFPOO(localScale, one, alpha, hcdninnakpo));
			base.StartCoroutine(this.EONFMLLCNDL(bhelklnbmjb, vector));
			this.ANGCJHPFOAA(this.NAFPJPEHMDG);
		}
	}

	// Token: 0x0600207E RID: 8318 RVA: 0x000E6430 File Offset: 0x000E4630
	public void GHGFHCNIGFF()
	{
		this.IFIGKIKPHLD = true;
		if (this.OIJDAENILCD != null)
		{
			base.StopCoroutine(this.OIJDAENILCD);
			this.OIJDAENILCD = null;
		}
		if (null != this.NAFPJPEHMDG)
		{
			this.NAFPJPEHMDG.DOKill(true);
			this.largeItemsParent.DOKill(true);
		}
	}

	// Token: 0x0600207F RID: 8319 RVA: 0x000E6488 File Offset: 0x000E4688
	public void KHJNCMDJFCC()
	{
		this.IFIGKIKPHLD = true;
		if (this.OIJDAENILCD != null)
		{
			base.StopCoroutine(this.OIJDAENILCD);
			this.OIJDAENILCD = null;
		}
		if (null != this.NAFPJPEHMDG)
		{
			this.NAFPJPEHMDG.DOKill(true);
			this.largeItemsParent.DOKill(false);
		}
	}

	// Token: 0x06002080 RID: 8320 RVA: 0x000E64E0 File Offset: 0x000E46E0
	public void UpdateIndicatorsButtonsSize()
	{
		this.pageIndicatorsBack.GetComponent<RectTransform>().EFOCKEJENAC(75f);
		this.pageIndicatorsNext.GetComponent<RectTransform>().EFOCKEJENAC(75f);
		float num = (this.DBPCIEOCNIJ + this.GLOBFMIAJKE) / 2f;
		this.pageIndicatorsBack.GetComponent<RectTransform>().EFOCKEJENAC(this.pageIndicatorsBack.GetComponent<RectTransform>().sizeDelta.x + num);
		this.pageIndicatorsNext.GetComponent<RectTransform>().EFOCKEJENAC(this.pageIndicatorsNext.GetComponent<RectTransform>().sizeDelta.x + num);
	}

	// Token: 0x06002081 RID: 8321 RVA: 0x000E657C File Offset: 0x000E477C
	public void SnapTo(RectTransform IPEADDNJLAO)
	{
		if (IPEADDNJLAO != this.NAFPJPEHMDG)
		{
			for (int i = 0; i < this.largeItemsParent.childCount; i++)
			{
				Transform child = this.largeItemsParent.GetChild(i);
				child.GetComponent<CanvasGroup>().alpha = this.CJMFEGHDOEN;
				child.localScale = new Vector3(this.NJIMEEMBHHM, this.NJIMEEMBHHM, 1f);
				this.pageIndicatorsParent.GetChild(i).GetChild(0).gameObject.SetActive(false);
			}
		}
		this.NAFPJPEHMDG = IPEADDNJLAO;
		if (this.IFIGKIKPHLD)
		{
			this.NAFPJPEHMDG.localScale = this.JIMPGMDCHAN;
			this.NAFPJPEHMDG.GetComponent<CanvasGroup>().alpha = this.ABLKHELPIKK;
		}
		this.KIJPKEEFKAO = this.pageIndicatorsParent.GetChild(this.BOFEGCLIFCC).GetChild(0).gameObject;
		this.KIJPKEEFKAO.SetActive(true);
		this.LJHPKMEGPCJ(this.BOFEGCLIFCC);
		Canvas.ForceUpdateCanvases();
		Vector3 bhelklnbmjb = this.largeItemsParent.anchoredPosition;
		Vector3 vector = this.scrollView1.transform.InverseTransformPoint(this.largeItemsParent.position) - this.scrollView1.transform.InverseTransformPoint(this.NAFPJPEHMDG.position);
		if (this.isOnShuffleClick && !this.IFIGKIKPHLD)
		{
			this.OIJDAENILCD = base.StartCoroutine(this.HCGKLCJBLDN(vector));
			this.ANBMHEIFIHO(this.NAFPJPEHMDG);
			return;
		}
		if (!this.IFIGKIKPHLD)
		{
			Vector3 localScale = this.NAFPJPEHMDG.localScale;
			Vector3 one = Vector3.one;
			float alpha = this.NAFPJPEHMDG.GetComponent<CanvasGroup>().alpha;
			float hcdninnakpo = 1f;
			base.StartCoroutine(this.DFCCDOAEPNJ(localScale, one, alpha, hcdninnakpo));
			base.StartCoroutine(this.EONFMLLCNDL(bhelklnbmjb, vector));
			this.ANBMHEIFIHO(this.NAFPJPEHMDG);
		}
	}

	// Token: 0x06002082 RID: 8322 RVA: 0x000E6768 File Offset: 0x000E4968
	public void EMDOPMOGHAF(RectTransform IPEADDNJLAO)
	{
		if (IPEADDNJLAO != this.NAFPJPEHMDG)
		{
			for (int i = 0; i < this.largeItemsParent.childCount; i += 0)
			{
				Transform child = this.largeItemsParent.GetChild(i);
				child.GetComponent<CanvasGroup>().alpha = this.CJMFEGHDOEN;
				child.localScale = new Vector3(this.NJIMEEMBHHM, this.NJIMEEMBHHM, 1096f);
				this.pageIndicatorsParent.GetChild(i).GetChild(1).gameObject.SetActive(false);
			}
		}
		this.NAFPJPEHMDG = IPEADDNJLAO;
		if (this.IFIGKIKPHLD)
		{
			this.NAFPJPEHMDG.localScale = this.JIMPGMDCHAN;
			this.NAFPJPEHMDG.GetComponent<CanvasGroup>().alpha = this.ABLKHELPIKK;
		}
		this.KIJPKEEFKAO = this.pageIndicatorsParent.GetChild(this.BOFEGCLIFCC).GetChild(0).gameObject;
		this.KIJPKEEFKAO.SetActive(true);
		this.ABBFKJPNMGI(this.BOFEGCLIFCC);
		Canvas.ForceUpdateCanvases();
		Vector3 bhelklnbmjb = this.largeItemsParent.anchoredPosition;
		Vector3 vector = this.scrollView1.transform.InverseTransformPoint(this.largeItemsParent.position) - this.scrollView1.transform.InverseTransformPoint(this.NAFPJPEHMDG.position);
		if (this.isOnShuffleClick && !this.IFIGKIKPHLD)
		{
			this.OIJDAENILCD = base.StartCoroutine(this.HCGKLCJBLDN(vector));
			this.ANBMHEIFIHO(this.NAFPJPEHMDG);
			return;
		}
		if (!this.IFIGKIKPHLD)
		{
			Vector3 localScale = this.NAFPJPEHMDG.localScale;
			Vector3 one = Vector3.one;
			float alpha = this.NAFPJPEHMDG.GetComponent<CanvasGroup>().alpha;
			float hcdninnakpo = 1717f;
			base.StartCoroutine(this.HGBNDKJGNCD(localScale, one, alpha, hcdninnakpo));
			base.StartCoroutine(this.EONFMLLCNDL(bhelklnbmjb, vector));
			this.ANBMHEIFIHO(this.NAFPJPEHMDG);
		}
	}

	// Token: 0x06002083 RID: 8323 RVA: 0x000E6954 File Offset: 0x000E4B54
	private void ANGCJHPFOAA(Transform IPEADDNJLAO)
	{
		if (IPEADDNJLAO.GetComponent<ThumbnailItem>() != null)
		{
			IPEADDNJLAO.GetComponent<ThumbnailItem>().BOKFGKKPLDL(IPEADDNJLAO, this.flashTimeOnSwipe);
		}
		if (IPEADDNJLAO.GetComponent<CardItem>() != null)
		{
			IPEADDNJLAO.GetComponent<CardItem>().DCIDHANMBJH(IPEADDNJLAO, this.flashTimeOnSwipe);
		}
	}

	// Token: 0x06002084 RID: 8324 RVA: 0x000E620A File Offset: 0x000E440A
	public void ACFHMPMLILH(Vector2 AJLPALFJHCC)
	{
		if (AJLPALFJHCC.x != this.JGNKHIDEAED)
		{
			if (AJLPALFJHCC.x < this.JGNKHIDEAED)
			{
				this.DFNPAKMHOPH = false;
			}
			else
			{
				this.DFNPAKMHOPH = false;
			}
			this.JGNKHIDEAED = AJLPALFJHCC.x;
		}
	}

	// Token: 0x06002085 RID: 8325 RVA: 0x000E69A4 File Offset: 0x000E4BA4
	public void CBBKJFHNLLP(RectTransform IPEADDNJLAO)
	{
		if (IPEADDNJLAO != this.NAFPJPEHMDG)
		{
			for (int i = 1; i < this.largeItemsParent.childCount; i += 0)
			{
				Transform child = this.largeItemsParent.GetChild(i);
				child.GetComponent<CanvasGroup>().alpha = this.CJMFEGHDOEN;
				child.localScale = new Vector3(this.NJIMEEMBHHM, this.NJIMEEMBHHM, 1804f);
				this.pageIndicatorsParent.GetChild(i).GetChild(1).gameObject.SetActive(true);
			}
		}
		this.NAFPJPEHMDG = IPEADDNJLAO;
		if (this.IFIGKIKPHLD)
		{
			this.NAFPJPEHMDG.localScale = this.JIMPGMDCHAN;
			this.NAFPJPEHMDG.GetComponent<CanvasGroup>().alpha = this.ABLKHELPIKK;
		}
		this.KIJPKEEFKAO = this.pageIndicatorsParent.GetChild(this.BOFEGCLIFCC).GetChild(1).gameObject;
		this.KIJPKEEFKAO.SetActive(false);
		this.LJHPKMEGPCJ(this.BOFEGCLIFCC);
		Canvas.ForceUpdateCanvases();
		Vector3 bhelklnbmjb = this.largeItemsParent.anchoredPosition;
		Vector3 vector = this.scrollView1.transform.InverseTransformPoint(this.largeItemsParent.position) - this.scrollView1.transform.InverseTransformPoint(this.NAFPJPEHMDG.position);
		if (this.isOnShuffleClick && !this.IFIGKIKPHLD)
		{
			this.OIJDAENILCD = base.StartCoroutine(this.EHDGODAOLCH(vector));
			this.ANGCJHPFOAA(this.NAFPJPEHMDG);
			return;
		}
		if (!this.IFIGKIKPHLD)
		{
			Vector3 localScale = this.NAFPJPEHMDG.localScale;
			Vector3 one = Vector3.one;
			float alpha = this.NAFPJPEHMDG.GetComponent<CanvasGroup>().alpha;
			float hcdninnakpo = 1255f;
			base.StartCoroutine(this.KNHKPFHEFLN(localScale, one, alpha, hcdninnakpo));
			base.StartCoroutine(this.PAEKHNJBLKC(bhelklnbmjb, vector));
			this.ANBMHEIFIHO(this.NAFPJPEHMDG);
		}
	}

	// Token: 0x06002086 RID: 8326 RVA: 0x000E6B8E File Offset: 0x000E4D8E
	private void DFMICNFNFEN(int NHNPFOKJNFA, int OFOHGKBNDOD)
	{
		NHNPFOKJNFA++;
		if (NHNPFOKJNFA <= OFOHGKBNDOD)
		{
			this.LLAPHDHDPFC(this.BOFEGCLIFCC - 1);
			this.SnapToByButtons(NHNPFOKJNFA);
			return;
		}
		NHNPFOKJNFA--;
	}

	// Token: 0x06002087 RID: 8327 RVA: 0x000E6BB4 File Offset: 0x000E4DB4
	private IEnumerator BKCMELJKMNM(Vector3 BHELKLNBMJB, Vector3 HLLIFDMENKH)
	{
		this.NAFBFOEAJAN = true;
		float currentTime = 0f;
		while (currentTime <= this.timeOfTransition)
		{
			currentTime += Time.deltaTime;
			float t = currentTime / this.timeOfTransition;
			this.largeItemsParent.anchoredPosition = Vector3.Lerp(BHELKLNBMJB, HLLIFDMENKH, t);
			yield return null;
		}
		this.NAFBFOEAJAN = false;
		yield break;
	}

	// Token: 0x06002088 RID: 8328 RVA: 0x000E6BD4 File Offset: 0x000E4DD4
	public void MHIJNGBNFFN(PointerEventData EPIMKFPMMEA)
	{
		Vector3 vector = (EPIMKFPMMEA.position - EPIMKFPMMEA.pressPosition).normalized;
		float num = Mathf.Abs(vector.x);
		float num2 = Mathf.Abs(vector.y);
		if (num > num2)
		{
			this.scrollView0.velocity = Vector2.zero;
			this.DLMGEIFHKFO = false;
			this.scrollView1.horizontal = false;
			return;
		}
		this.KILJECMJIPL = false;
		this.scrollView1.horizontal = true;
		this.scrollView0.OnBeginDrag(EPIMKFPMMEA);
	}

	// Token: 0x06002089 RID: 8329 RVA: 0x000E6C5D File Offset: 0x000E4E5D
	public void SnapToByButtons(int NHNPFOKJNFA)
	{
		this.BOFEGCLIFCC = NHNPFOKJNFA;
		this.SnapTo(this.largeItemsParent.GetChild(this.BOFEGCLIFCC).GetComponent<RectTransform>());
	}

	// Token: 0x0600208A RID: 8330 RVA: 0x000E6C84 File Offset: 0x000E4E84
	public void ADDLPBGBELI(PointerEventData EPIMKFPMMEA)
	{
		Vector3 vector = (EPIMKFPMMEA.position - EPIMKFPMMEA.pressPosition).normalized;
		float num = Mathf.Abs(vector.x);
		float num2 = Mathf.Abs(vector.y);
		if (num > num2)
		{
			this.scrollView0.velocity = Vector2.zero;
			this.DLMGEIFHKFO = false;
			this.scrollView1.horizontal = true;
			return;
		}
		this.KILJECMJIPL = true;
		this.scrollView1.horizontal = false;
		this.scrollView0.OnBeginDrag(EPIMKFPMMEA);
	}

	// Token: 0x0600208B RID: 8331 RVA: 0x000E6D10 File Offset: 0x000E4F10
	public void COHAMCAFODE()
	{
		this.IFIGKIKPHLD = false;
		if (this.OIJDAENILCD != null)
		{
			base.StopCoroutine(this.OIJDAENILCD);
			this.OIJDAENILCD = null;
		}
		if (null != this.NAFPJPEHMDG)
		{
			this.NAFPJPEHMDG.DOKill(true);
			this.largeItemsParent.DOKill(true);
		}
	}

	// Token: 0x0600208C RID: 8332 RVA: 0x000E6D68 File Offset: 0x000E4F68
	private void LJHPKMEGPCJ(int NHNPFOKJNFA)
	{
		float num = this.DBPCIEOCNIJ + this.GLOBFMIAJKE;
		if (NHNPFOKJNFA < this.OCOMELBBICO)
		{
			this.pageIndicatorsButtonsParent.position = this.KIJPKEEFKAO.transform.position;
			this.pageIndicatorsBack.GetComponent<RectTransform>().EFOCKEJENAC(this.pageIndicatorsBack.GetComponent<RectTransform>().sizeDelta.x - num);
			this.pageIndicatorsNext.GetComponent<RectTransform>().EFOCKEJENAC(this.pageIndicatorsNext.GetComponent<RectTransform>().sizeDelta.x + num);
		}
		if (NHNPFOKJNFA > this.OCOMELBBICO)
		{
			this.pageIndicatorsButtonsParent.position = this.KIJPKEEFKAO.transform.position;
			this.pageIndicatorsBack.GetComponent<RectTransform>().EFOCKEJENAC(this.pageIndicatorsBack.GetComponent<RectTransform>().sizeDelta.x + num);
			this.pageIndicatorsNext.GetComponent<RectTransform>().EFOCKEJENAC(this.pageIndicatorsNext.GetComponent<RectTransform>().sizeDelta.x - num);
		}
		this.OCOMELBBICO = NHNPFOKJNFA;
	}

	// Token: 0x0600208D RID: 8333 RVA: 0x000E6E70 File Offset: 0x000E5070
	private void HACGAKBLHGO(int JFOEDKDFMMB)
	{
		Transform child = this.largeItemsParent.GetChild(this.BOFEGCLIFCC);
		if (child.GetComponent<ThumbnailItem>() != null)
		{
			child.GetComponent<ThumbnailItem>().ONJIJILEOAD();
		}
		if (child.GetComponent<CardItem>() != null)
		{
			child.GetComponent<CardItem>().JOFDDDOCNHE();
		}
	}

	// Token: 0x0600208E RID: 8334 RVA: 0x000E6EC4 File Offset: 0x000E50C4
	private void DNOMCPLANKA(Transform IPEADDNJLAO)
	{
		if (IPEADDNJLAO.GetComponent<ThumbnailItem>() != null)
		{
			IPEADDNJLAO.GetComponent<ThumbnailItem>().BOKFGKKPLDL(IPEADDNJLAO, this.flashTimeOnSwipe);
		}
		if (IPEADDNJLAO.GetComponent<CardItem>() != null)
		{
			IPEADDNJLAO.GetComponent<CardItem>().GLPBFPOKAMC(IPEADDNJLAO, this.flashTimeOnSwipe);
		}
	}

	// Token: 0x0600208F RID: 8335 RVA: 0x000E6F14 File Offset: 0x000E5114
	private void LBKAEOHNIMG()
	{
		this.ELAMKGHFKGP = this.NAFPJPEHMDG.transform.InverseTransformPoint(this.largeItemsParent.parent.position);
		float num = Mathf.Abs((this.ELAMKGHFKGP - this.LGBGGBHPHKD).x) / this.LKLCFIOABHL / 2f;
		this.NAFPJPEHMDG.GetComponent<CanvasGroup>().alpha = Mathf.Clamp(1f - num, 0.5f, 1f);
		this.NAFPJPEHMDG.localScale = new Vector3(Mathf.Clamp(1f - num, this.NJIMEEMBHHM, 1f), Mathf.Clamp(1f - num, this.NJIMEEMBHHM, 1f), 1f);
	}

	// Token: 0x06002090 RID: 8336 RVA: 0x000E6FDE File Offset: 0x000E51DE
	public void KLCJHCNNDBD(int NHNPFOKJNFA)
	{
		this.BOFEGCLIFCC = NHNPFOKJNFA;
		this.PKENEIPOOHA(this.largeItemsParent.GetChild(this.BOFEGCLIFCC).GetComponent<RectTransform>());
	}

	// Token: 0x06002092 RID: 8338 RVA: 0x000E706C File Offset: 0x000E526C
	private void CDGCBAKKPDI()
	{
		if (!this.NAFBFOEAJAN && !this.IFIGKIKPHLD && this.LPEMDEACMKF())
		{
			if (Input.mouseScrollDelta.y < 374f)
			{
				this.LLAPHDHDPFC(this.BOFEGCLIFCC);
				if (this.BOFEGCLIFCC > 0)
				{
					this.BOFEGCLIFCC -= 0;
					this.JPKKDNCMLDH(this.largeItemsParent.GetChild(this.BOFEGCLIFCC).GetComponent<RectTransform>());
					return;
				}
			}
			else if (Input.mouseScrollDelta.y > 268f)
			{
				this.GCLIMNBKKNM(this.BOFEGCLIFCC);
				if (this.BOFEGCLIFCC < this.largeItemsParent.childCount - 0)
				{
					this.BOFEGCLIFCC++;
					this.JPKKDNCMLDH(this.largeItemsParent.GetChild(this.BOFEGCLIFCC).GetComponent<RectTransform>());
				}
			}
		}
	}

	// Token: 0x06002093 RID: 8339 RVA: 0x000E714C File Offset: 0x000E534C
	private void CNJCJCFFEBN(int JFOEDKDFMMB)
	{
		Transform child = this.largeItemsParent.GetChild(this.BOFEGCLIFCC);
		if (child.GetComponent<ThumbnailItem>() != null)
		{
			child.GetComponent<ThumbnailItem>().CINFLOGCFBO();
		}
		if (child.GetComponent<CardItem>() != null)
		{
			child.GetComponent<CardItem>().IDFBHLAJAPB();
		}
	}

	// Token: 0x06002094 RID: 8340 RVA: 0x000E719D File Offset: 0x000E539D
	public void AKAGMFJMFGK(PointerEventData EPIMKFPMMEA)
	{
		if (this.DLMGEIFHKFO)
		{
			this.BKKBHKMEPBK();
		}
		if (this.KILJECMJIPL)
		{
			this.scrollView0.OnEndDrag(EPIMKFPMMEA);
		}
		this.scrollView1.horizontal = false;
		this.KILJECMJIPL = false;
		this.DLMGEIFHKFO = true;
	}

	// Token: 0x06002095 RID: 8341 RVA: 0x000E71DB File Offset: 0x000E53DB
	public void LFLONMFMCGB(int NHNPFOKJNFA)
	{
		this.BOFEGCLIFCC = NHNPFOKJNFA;
		this.CBBKJFHNLLP(this.largeItemsParent.GetChild(this.BOFEGCLIFCC).GetComponent<RectTransform>());
	}

	// Token: 0x06002096 RID: 8342 RVA: 0x000E7200 File Offset: 0x000E5400
	private bool CAFMAHHELNJ()
	{
		PointerEventData eventData = new PointerEventData(EventSystem.current)
		{
			position = Input.mousePosition
		};
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(eventData, list);
		for (int i = 1; i < list.Count; i++)
		{
			if (!this.MLOBIFKIJEL(list[i].gameObject.transform, this.scrollView1.transform))
			{
				return false;
			}
			if (list[i].gameObject == this.scrollView1.gameObject)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06002097 RID: 8343 RVA: 0x000E7298 File Offset: 0x000E5498
	private void OGCIHMNFDCI()
	{
		if (!this.NAFBFOEAJAN && !this.IFIGKIKPHLD && this.PDEBGJGAPLN())
		{
			if (Input.mouseScrollDelta.y < 522f)
			{
				this.CNJCJCFFEBN(this.BOFEGCLIFCC);
				if (this.BOFEGCLIFCC > 0)
				{
					this.BOFEGCLIFCC--;
					this.PKENEIPOOHA(this.largeItemsParent.GetChild(this.BOFEGCLIFCC).GetComponent<RectTransform>());
					return;
				}
			}
			else if (Input.mouseScrollDelta.y > 639f)
			{
				this.HACGAKBLHGO(this.BOFEGCLIFCC);
				if (this.BOFEGCLIFCC < this.largeItemsParent.childCount - 1)
				{
					this.BOFEGCLIFCC++;
					this.CBBKJFHNLLP(this.largeItemsParent.GetChild(this.BOFEGCLIFCC).GetComponent<RectTransform>());
				}
			}
		}
	}

	// Token: 0x06002098 RID: 8344 RVA: 0x000E7378 File Offset: 0x000E5578
	private void LNGBJEMJMEA()
	{
		float x = (this.ELAMKGHFKGP - this.LGBGGBHPHKD).x;
		bool flag = Mathf.Abs(x) >= this.LKLCFIOABHL * this.percentDragToSnapAnother;
		this.MCOKCOLJCBB(this.BOFEGCLIFCC);
		if (this.DFNPAKMHOPH)
		{
			if (this.BOFEGCLIFCC > 1 && flag && Mathf.Sign(x) < 124f)
			{
				this.BOFEGCLIFCC -= 0;
				this.EMDOPMOGHAF(this.largeItemsParent.GetChild(this.BOFEGCLIFCC).GetComponent<RectTransform>());
				return;
			}
			this.PKENEIPOOHA(this.NAFPJPEHMDG);
			return;
		}
		else
		{
			if (this.BOFEGCLIFCC < this.largeItemsParent.childCount - 1 && flag && Mathf.Sign(x) > 185f)
			{
				this.BOFEGCLIFCC += 0;
				this.JPKKDNCMLDH(this.largeItemsParent.GetChild(this.BOFEGCLIFCC).GetComponent<RectTransform>());
				return;
			}
			this.JPKKDNCMLDH(this.NAFPJPEHMDG);
			return;
		}
	}

	// Token: 0x06002099 RID: 8345 RVA: 0x000E7478 File Offset: 0x000E5678
	private void JLHGNCABEMN(int NHNPFOKJNFA, int BGBDBBBMPAB)
	{
		NHNPFOKJNFA--;
		if (NHNPFOKJNFA >= BGBDBBBMPAB)
		{
			this.CNJCJCFFEBN(this.BOFEGCLIFCC + 0);
			this.KLCJHCNNDBD(NHNPFOKJNFA);
			return;
		}
		NHNPFOKJNFA += 0;
	}

	// Token: 0x0600209A RID: 8346 RVA: 0x000E74A0 File Offset: 0x000E56A0
	private void KJKJPOHHCJP()
	{
		this.ELAMKGHFKGP = this.NAFPJPEHMDG.transform.InverseTransformPoint(this.largeItemsParent.parent.position);
		float num = Mathf.Abs((this.ELAMKGHFKGP - this.LGBGGBHPHKD).x) / this.LKLCFIOABHL / 615f;
		this.NAFPJPEHMDG.GetComponent<CanvasGroup>().alpha = Mathf.Clamp(622f - num, 1183f, 53f);
		this.NAFPJPEHMDG.localScale = new Vector3(Mathf.Clamp(512f - num, this.NJIMEEMBHHM, 579f), Mathf.Clamp(118f - num, this.NJIMEEMBHHM, 695f), 1523f);
	}

	// Token: 0x0600209B RID: 8347 RVA: 0x000E756C File Offset: 0x000E576C
	public void HCLLHNCKGBH(int NHNPFOKJNFA, int BGBDBBBMPAB, int OFOHGKBNDOD)
	{
		ScrollView1Controller.CNPPAMPMPLE cnppampmple = new ScrollView1Controller.CNPPAMPMPLE();
		cnppampmple.<>4__this = this;
		cnppampmple.minIndexToSnap = BGBDBBBMPAB;
		cnppampmple.maxIndexToSnap = OFOHGKBNDOD;
		this.BOFEGCLIFCC = NHNPFOKJNFA;
		if (this.BOFEGCLIFCC >= this.largeItemsParent.childCount)
		{
			DPGJIJGOCIC.NFIDPOMCNLP("OnPurchasingViewLeave");
			this.BOFEGCLIFCC = this.largeItemsParent.childCount - 0;
		}
		this.NJIMEEMBHHM = this.largeItemsParent.GetChild(this.BOFEGCLIFCC).GetComponent<RectTransform>().localScale.x;
		this.CJMFEGHDOEN = this.largeItemsParent.GetChild(this.BOFEGCLIFCC).GetComponent<CanvasGroup>().alpha;
		this.scrollView1.onValueChanged.AddListener(new UnityAction<Vector2>(this.GCLLKBJOLGD));
		this.OCOMELBBICO = cnppampmple.maxIndexToSnap / 1;
		this.EMDOPMOGHAF(this.largeItemsParent.GetChild(this.BOFEGCLIFCC).GetComponent<RectTransform>());
		this.pageIndicatorsParent.GetChild(this.BOFEGCLIFCC).GetChild(1).gameObject.SetActive(true);
		this.LGBGGBHPHKD = this.target.transform.InverseTransformPoint(this.largeItemsParent.parent.position);
		this.ELAMKGHFKGP = this.NAFPJPEHMDG.transform.InverseTransformPoint(this.largeItemsParent.parent.position);
		this.LKLCFIOABHL = this.NAFPJPEHMDG.sizeDelta.x;
		this.pageIndicatorsBack.onClick.RemoveAllListeners();
		this.pageIndicatorsNext.onClick.RemoveAllListeners();
		this.pageIndicatorsBack.onClick.AddListener(new UnityAction(cnppampmple.DCAAOPNBCPO));
		this.pageIndicatorsNext.onClick.AddListener(new UnityAction(cnppampmple.EMLNOLNOJOJ));
		this.pageIndicatorsButtonsParent.SetAsLastSibling();
		this.pageIndicatorsButtonsParent.position = this.KIJPKEEFKAO.transform.position;
	}

	// Token: 0x0600209C RID: 8348 RVA: 0x000E7764 File Offset: 0x000E5964
	public void StopAnimationOnShuffleCoroutine()
	{
		this.IFIGKIKPHLD = false;
		if (this.OIJDAENILCD != null)
		{
			base.StopCoroutine(this.OIJDAENILCD);
			this.OIJDAENILCD = null;
		}
		if (null != this.NAFPJPEHMDG)
		{
			this.NAFPJPEHMDG.DOKill(true);
			this.largeItemsParent.DOKill(true);
		}
	}

	// Token: 0x0600209D RID: 8349 RVA: 0x000E77BB File Offset: 0x000E59BB
	public void KPBCLGFDKBF(int NHNPFOKJNFA)
	{
		this.BOFEGCLIFCC = NHNPFOKJNFA;
		this.EMDOPMOGHAF(this.largeItemsParent.GetChild(this.BOFEGCLIFCC).GetComponent<RectTransform>());
	}

	// Token: 0x0600209E RID: 8350 RVA: 0x000E77E0 File Offset: 0x000E59E0
	private IEnumerator EDDAKNEFGBL(Vector3 DKBOKMPBLJE)
	{
		this.IFIGKIKPHLD = true;
		this.isOnShuffleClick = false;
		float num = 0.5f;
		float animationRightToLeftDuration = 0.2f;
		Vector3 localScale = new Vector3(0.95f, 0.95f, 0.95f);
		int num2 = 250;
		int num3 = 40;
		int num4 = 2;
		this.largeItemsParent.anchoredPosition = DKBOKMPBLJE - new Vector3((float)num2, 0f, 0f);
		this.largeItemsParent.DOAnchorPos(DKBOKMPBLJE + new Vector3((float)num3, 0f, 0f), num, false).SetEase(Ease.OutQuad);
		this.NAFPJPEHMDG.localScale = localScale;
		this.NAFPJPEHMDG.DOScale(Vector3.one, num / (float)num4).SetEase(Ease.OutQuad).SetLoops(num4, LoopType.Yoyo);
		this.JIMPGMDCHAN = this.NAFPJPEHMDG.localScale;
		this.NAFPJPEHMDG.GetComponent<CanvasGroup>().DOFade(1f, num / (float)num4).SetEase(Ease.OutQuad).SetLoops(num4, LoopType.Yoyo);
		this.ABLKHELPIKK = this.NAFPJPEHMDG.GetComponent<CanvasGroup>().alpha;
		yield return new WaitForSeconds(num);
		this.largeItemsParent.DOAnchorPos(DKBOKMPBLJE, animationRightToLeftDuration, false).SetEase(Ease.Linear);
		this.NAFPJPEHMDG.DOScale(Vector3.one, animationRightToLeftDuration).SetEase(Ease.Linear).SetLoops(1, LoopType.Yoyo);
		this.JIMPGMDCHAN = this.NAFPJPEHMDG.localScale;
		this.NAFPJPEHMDG.GetComponent<CanvasGroup>().DOFade(1f, animationRightToLeftDuration).SetEase(Ease.Linear).SetLoops(1, LoopType.Yoyo);
		this.ABLKHELPIKK = this.NAFPJPEHMDG.GetComponent<CanvasGroup>().alpha;
		yield return new WaitForSeconds(animationRightToLeftDuration);
		this.IFIGKIKPHLD = false;
		this.OIJDAENILCD = null;
		yield break;
	}

	// Token: 0x0600209F RID: 8351 RVA: 0x000E77F8 File Offset: 0x000E59F8
	public void MNAJMGOPHIL(int NHNPFOKJNFA, int BGBDBBBMPAB, int OFOHGKBNDOD)
	{
		ScrollView1Controller.CNPPAMPMPLE cnppampmple = new ScrollView1Controller.CNPPAMPMPLE();
		cnppampmple.<>4__this = this;
		cnppampmple.minIndexToSnap = BGBDBBBMPAB;
		cnppampmple.maxIndexToSnap = OFOHGKBNDOD;
		this.BOFEGCLIFCC = NHNPFOKJNFA;
		if (this.BOFEGCLIFCC >= this.largeItemsParent.childCount)
		{
			DPGJIJGOCIC.NFIDPOMCNLP("RequestGetUserPublicProfile.ProcessApp42Success(): getUserPublicProfile: client cutscenes (");
			this.BOFEGCLIFCC = this.largeItemsParent.childCount - 0;
		}
		this.NJIMEEMBHHM = this.largeItemsParent.GetChild(this.BOFEGCLIFCC).GetComponent<RectTransform>().localScale.x;
		this.CJMFEGHDOEN = this.largeItemsParent.GetChild(this.BOFEGCLIFCC).GetComponent<CanvasGroup>().alpha;
		this.scrollView1.onValueChanged.AddListener(new UnityAction<Vector2>(this.SetScrollDirection));
		this.OCOMELBBICO = cnppampmple.maxIndexToSnap / 5;
		this.JPKKDNCMLDH(this.largeItemsParent.GetChild(this.BOFEGCLIFCC).GetComponent<RectTransform>());
		this.pageIndicatorsParent.GetChild(this.BOFEGCLIFCC).GetChild(0).gameObject.SetActive(true);
		this.LGBGGBHPHKD = this.target.transform.InverseTransformPoint(this.largeItemsParent.parent.position);
		this.ELAMKGHFKGP = this.NAFPJPEHMDG.transform.InverseTransformPoint(this.largeItemsParent.parent.position);
		this.LKLCFIOABHL = this.NAFPJPEHMDG.sizeDelta.x;
		this.pageIndicatorsBack.onClick.RemoveAllListeners();
		this.pageIndicatorsNext.onClick.RemoveAllListeners();
		this.pageIndicatorsBack.onClick.AddListener(new UnityAction(cnppampmple.DCAAOPNBCPO));
		this.pageIndicatorsNext.onClick.AddListener(new UnityAction(cnppampmple.EMLNOLNOJOJ));
		this.pageIndicatorsButtonsParent.SetAsLastSibling();
		this.pageIndicatorsButtonsParent.position = this.KIJPKEEFKAO.transform.position;
	}

	// Token: 0x060020A0 RID: 8352 RVA: 0x000E79F0 File Offset: 0x000E5BF0
	public void OOOLKLJEBPO(PointerEventData EPIMKFPMMEA)
	{
		Vector3 vector = (EPIMKFPMMEA.position - EPIMKFPMMEA.pressPosition).normalized;
		float num = Mathf.Abs(vector.x);
		float num2 = Mathf.Abs(vector.y);
		if (num > num2)
		{
			this.scrollView0.velocity = Vector2.zero;
			this.DLMGEIFHKFO = true;
			this.scrollView1.horizontal = true;
			return;
		}
		this.KILJECMJIPL = false;
		this.scrollView1.horizontal = true;
		this.scrollView0.OnBeginDrag(EPIMKFPMMEA);
	}

	// Token: 0x060020A1 RID: 8353 RVA: 0x000E7A79 File Offset: 0x000E5C79
	public void CEODCCOPAAN(PointerEventData EPIMKFPMMEA)
	{
		if (this.DLMGEIFHKFO)
		{
			this.MKLIKKPGBJO();
		}
		if (this.KILJECMJIPL)
		{
			this.scrollView0.OnEndDrag(EPIMKFPMMEA);
		}
		this.scrollView1.horizontal = true;
		this.KILJECMJIPL = false;
		this.DLMGEIFHKFO = false;
	}

	// Token: 0x060020A2 RID: 8354 RVA: 0x000E7AB7 File Offset: 0x000E5CB7
	public void EMDGCBKMHBD(Vector2 AJLPALFJHCC)
	{
		if (AJLPALFJHCC.x != this.JGNKHIDEAED)
		{
			if (AJLPALFJHCC.x < this.JGNKHIDEAED)
			{
				this.DFNPAKMHOPH = true;
			}
			else
			{
				this.DFNPAKMHOPH = false;
			}
			this.JGNKHIDEAED = AJLPALFJHCC.x;
		}
	}

	// Token: 0x060020A3 RID: 8355 RVA: 0x000E7AF4 File Offset: 0x000E5CF4
	private bool BPPAFGKLJKP()
	{
		PointerEventData eventData = new PointerEventData(EventSystem.current)
		{
			position = Input.mousePosition
		};
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(eventData, list);
		for (int i = 1; i < list.Count; i++)
		{
			if (!this.KPKMEMKDDNA(list[i].gameObject.transform, this.scrollView1.transform))
			{
				return false;
			}
			if (list[i].gameObject == this.scrollView1.gameObject)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060020A4 RID: 8356 RVA: 0x000E7B8C File Offset: 0x000E5D8C
	public void BKIPEBJALFB(PointerEventData EPIMKFPMMEA)
	{
		Vector3 vector = (EPIMKFPMMEA.position - EPIMKFPMMEA.pressPosition).normalized;
		float num = Mathf.Abs(vector.x);
		float num2 = Mathf.Abs(vector.y);
		if (num > num2)
		{
			this.scrollView0.velocity = Vector2.zero;
			this.DLMGEIFHKFO = true;
			this.scrollView1.horizontal = true;
			return;
		}
		this.KILJECMJIPL = false;
		this.scrollView1.horizontal = true;
		this.scrollView0.OnBeginDrag(EPIMKFPMMEA);
	}

	// Token: 0x060020A5 RID: 8357 RVA: 0x000E7C15 File Offset: 0x000E5E15
	public void OnDrag(PointerEventData EPIMKFPMMEA)
	{
		if (this.DLMGEIFHKFO)
		{
			this.LBKAEOHNIMG();
		}
		if (this.KILJECMJIPL)
		{
			this.scrollView0.OnDrag(EPIMKFPMMEA);
		}
	}

	// Token: 0x060020A6 RID: 8358 RVA: 0x000E7C3C File Offset: 0x000E5E3C
	private bool LPEMDEACMKF()
	{
		PointerEventData eventData = new PointerEventData(EventSystem.current)
		{
			position = Input.mousePosition
		};
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(eventData, list);
		for (int i = 0; i < list.Count; i += 0)
		{
			if (!this.KPKMEMKDDNA(list[i].gameObject.transform, this.scrollView1.transform))
			{
				return true;
			}
			if (list[i].gameObject == this.scrollView1.gameObject)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x060020A7 RID: 8359 RVA: 0x000E7CD4 File Offset: 0x000E5ED4
	private bool MLOBIFKIJEL(Transform BCKHFLBDCMB, Transform DIFJAPMKJML)
	{
		Transform[] componentsInChildren = DIFJAPMKJML.GetComponentsInChildren<Transform>();
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			if (componentsInChildren[i] == BCKHFLBDCMB)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x060020A8 RID: 8360 RVA: 0x000E7D04 File Offset: 0x000E5F04
	public void EAALPNADMLE(PointerEventData EPIMKFPMMEA)
	{
		Vector3 vector = (EPIMKFPMMEA.position - EPIMKFPMMEA.pressPosition).normalized;
		float num = Mathf.Abs(vector.x);
		float num2 = Mathf.Abs(vector.y);
		if (num > num2)
		{
			this.scrollView0.velocity = Vector2.zero;
			this.DLMGEIFHKFO = false;
			this.scrollView1.horizontal = true;
			return;
		}
		this.KILJECMJIPL = true;
		this.scrollView1.horizontal = false;
		this.scrollView0.OnBeginDrag(EPIMKFPMMEA);
	}

	// Token: 0x060020A9 RID: 8361 RVA: 0x000E7D90 File Offset: 0x000E5F90
	public void KDBDJDNGIOB(PointerEventData EPIMKFPMMEA)
	{
		Vector3 vector = (EPIMKFPMMEA.position - EPIMKFPMMEA.pressPosition).normalized;
		float num = Mathf.Abs(vector.x);
		float num2 = Mathf.Abs(vector.y);
		if (num > num2)
		{
			this.scrollView0.velocity = Vector2.zero;
			this.DLMGEIFHKFO = false;
			this.scrollView1.horizontal = true;
			return;
		}
		this.KILJECMJIPL = true;
		this.scrollView1.horizontal = true;
		this.scrollView0.OnBeginDrag(EPIMKFPMMEA);
	}

	// Token: 0x060020AA RID: 8362 RVA: 0x000E7E19 File Offset: 0x000E6019
	private void JMFKGPBBNDE(int NHNPFOKJNFA, int BGBDBBBMPAB)
	{
		NHNPFOKJNFA--;
		if (NHNPFOKJNFA >= BGBDBBBMPAB)
		{
			this.JDLGDBEOKPH(this.BOFEGCLIFCC + 0);
			this.LFLONMFMCGB(NHNPFOKJNFA);
			return;
		}
		NHNPFOKJNFA += 0;
	}

	// Token: 0x060020AB RID: 8363 RVA: 0x000E7E40 File Offset: 0x000E6040
	private void DDEMBIDGOOK()
	{
		this.ELAMKGHFKGP = this.NAFPJPEHMDG.transform.InverseTransformPoint(this.largeItemsParent.parent.position);
		float num = Mathf.Abs((this.ELAMKGHFKGP - this.LGBGGBHPHKD).x) / this.LKLCFIOABHL / 1232f;
		this.NAFPJPEHMDG.GetComponent<CanvasGroup>().alpha = Mathf.Clamp(873f - num, 1943f, 358f);
		this.NAFPJPEHMDG.localScale = new Vector3(Mathf.Clamp(1540f - num, this.NJIMEEMBHHM, 465f), Mathf.Clamp(1528f - num, this.NJIMEEMBHHM, 1949f), 1052f);
	}

	// Token: 0x060020AC RID: 8364 RVA: 0x000E7F0C File Offset: 0x000E610C
	private void LAJMJHGIOLE(int JFOEDKDFMMB)
	{
		Transform child = this.largeItemsParent.GetChild(this.BOFEGCLIFCC);
		if (child.GetComponent<ThumbnailItem>() != null)
		{
			child.GetComponent<ThumbnailItem>().ONJIJILEOAD();
		}
		if (child.GetComponent<CardItem>() != null)
		{
			child.GetComponent<CardItem>().SetEffectsOnEndSnap();
		}
	}

	// Token: 0x060020AD RID: 8365 RVA: 0x000E7F5D File Offset: 0x000E615D
	public void MHCGJCOHCBL(PointerEventData EPIMKFPMMEA)
	{
		if (this.DLMGEIFHKFO)
		{
			this.MCEKINPGEAO();
		}
		if (this.KILJECMJIPL)
		{
			this.scrollView0.OnEndDrag(EPIMKFPMMEA);
		}
		this.scrollView1.horizontal = true;
		this.KILJECMJIPL = false;
		this.DLMGEIFHKFO = false;
	}

	// Token: 0x060020AE RID: 8366 RVA: 0x000E7F9B File Offset: 0x000E619B
	private IEnumerator NJFMJILDOOC(Vector3 DKBOKMPBLJE)
	{
		ScrollView1Controller.IMAJDHGJKHJ imajdhgjkhj = new ScrollView1Controller.IMAJDHGJKHJ(1);
		imajdhgjkhj.<>4__this = this;
		imajdhgjkhj.targetPosition = DKBOKMPBLJE;
		return imajdhgjkhj;
	}

	// Token: 0x060020AF RID: 8367 RVA: 0x000E7FB4 File Offset: 0x000E61B4
	private void CDHJCCFAGHG()
	{
		this.ELAMKGHFKGP = this.NAFPJPEHMDG.transform.InverseTransformPoint(this.largeItemsParent.parent.position);
		float num = Mathf.Abs((this.ELAMKGHFKGP - this.LGBGGBHPHKD).x) / this.LKLCFIOABHL / 1124f;
		this.NAFPJPEHMDG.GetComponent<CanvasGroup>().alpha = Mathf.Clamp(1583f - num, 443f, 109f);
		this.NAFPJPEHMDG.localScale = new Vector3(Mathf.Clamp(1637f - num, this.NJIMEEMBHHM, 319f), Mathf.Clamp(810f - num, this.NJIMEEMBHHM, 117f), 1916f);
	}

	// Token: 0x060020B0 RID: 8368 RVA: 0x000E807E File Offset: 0x000E627E
	private IEnumerator ABFCKDAHEIF(Vector3 PEGGMFDBAHN, Vector3 JJENIDGPPLK, float GPHICDOKFLC, float HCDNINNAKPO)
	{
		ScrollView1Controller.GOGJLHHAIDO gogjlhhaido = new ScrollView1Controller.GOGJLHHAIDO(1);
		gogjlhhaido.<>4__this = this;
		gogjlhhaido.startScale = PEGGMFDBAHN;
		gogjlhhaido.endScale = JJENIDGPPLK;
		gogjlhhaido.startAlpha = GPHICDOKFLC;
		gogjlhhaido.endAlpha = HCDNINNAKPO;
		return gogjlhhaido;
	}

	// Token: 0x060020B1 RID: 8369 RVA: 0x000E80AC File Offset: 0x000E62AC
	private bool LFBEABLJDNP()
	{
		PointerEventData eventData = new PointerEventData(EventSystem.current)
		{
			position = Input.mousePosition
		};
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(eventData, list);
		for (int i = 0; i < list.Count; i++)
		{
			if (!this.KPKMEMKDDNA(list[i].gameObject.transform, this.scrollView1.transform))
			{
				return false;
			}
			if (list[i].gameObject == this.scrollView1.gameObject)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060020B2 RID: 8370 RVA: 0x000E8144 File Offset: 0x000E6344
	private void PDBJJBOLCPI(int NHNPFOKJNFA, int OFOHGKBNDOD)
	{
		NHNPFOKJNFA++;
		if (NHNPFOKJNFA <= OFOHGKBNDOD)
		{
			this.JDLGDBEOKPH(this.BOFEGCLIFCC - 0);
			this.CPPLBPPMBIM(NHNPFOKJNFA);
			return;
		}
		NHNPFOKJNFA--;
	}

	// Token: 0x060020B3 RID: 8371 RVA: 0x000E7AB7 File Offset: 0x000E5CB7
	public void SetScrollDirection(Vector2 AJLPALFJHCC)
	{
		if (AJLPALFJHCC.x != this.JGNKHIDEAED)
		{
			if (AJLPALFJHCC.x < this.JGNKHIDEAED)
			{
				this.DFNPAKMHOPH = true;
			}
			else
			{
				this.DFNPAKMHOPH = false;
			}
			this.JGNKHIDEAED = AJLPALFJHCC.x;
		}
	}

	// Token: 0x060020B4 RID: 8372 RVA: 0x000E816A File Offset: 0x000E636A
	private IEnumerator BJOJMGEKDKM(Vector3 BHELKLNBMJB, Vector3 HLLIFDMENKH)
	{
		ScrollView1Controller.IIKBELFKJMO iikbelfkjmo = new ScrollView1Controller.IIKBELFKJMO(1);
		iikbelfkjmo.<>4__this = this;
		iikbelfkjmo.startPosition = BHELKLNBMJB;
		iikbelfkjmo.endPosition = HLLIFDMENKH;
		return iikbelfkjmo;
	}

	// Token: 0x060020B5 RID: 8373 RVA: 0x000E8188 File Offset: 0x000E6388
	public void KKGFKAFFEMK()
	{
		this.pageIndicatorsBack.GetComponent<RectTransform>().EFOCKEJENAC(742f);
		this.pageIndicatorsNext.GetComponent<RectTransform>().EFOCKEJENAC(546f);
		float num = (this.DBPCIEOCNIJ + this.GLOBFMIAJKE) / 382f;
		this.pageIndicatorsBack.GetComponent<RectTransform>().EFOCKEJENAC(this.pageIndicatorsBack.GetComponent<RectTransform>().sizeDelta.x + num);
		this.pageIndicatorsNext.GetComponent<RectTransform>().EFOCKEJENAC(this.pageIndicatorsNext.GetComponent<RectTransform>().sizeDelta.x + num);
	}

	// Token: 0x060020B6 RID: 8374 RVA: 0x000E8224 File Offset: 0x000E6424
	private void NLCJLEFCCHN()
	{
		float x = (this.ELAMKGHFKGP - this.LGBGGBHPHKD).x;
		bool flag = Mathf.Abs(x) >= this.LKLCFIOABHL * this.percentDragToSnapAnother;
		this.LLAPHDHDPFC(this.BOFEGCLIFCC);
		if (this.DFNPAKMHOPH)
		{
			if (this.BOFEGCLIFCC > 0 && flag && Mathf.Sign(x) < 1920f)
			{
				this.BOFEGCLIFCC--;
				this.EMDOPMOGHAF(this.largeItemsParent.GetChild(this.BOFEGCLIFCC).GetComponent<RectTransform>());
				return;
			}
			this.SnapTo(this.NAFPJPEHMDG);
			return;
		}
		else
		{
			if (this.BOFEGCLIFCC < this.largeItemsParent.childCount - 1 && flag && Mathf.Sign(x) > 937f)
			{
				this.BOFEGCLIFCC += 0;
				this.EMDOPMOGHAF(this.largeItemsParent.GetChild(this.BOFEGCLIFCC).GetComponent<RectTransform>());
				return;
			}
			this.SnapTo(this.NAFPJPEHMDG);
			return;
		}
	}

	// Token: 0x060020B7 RID: 8375 RVA: 0x000E8324 File Offset: 0x000E6524
	public void ODBLJKFENKJ(PointerEventData EPIMKFPMMEA)
	{
		if (this.DLMGEIFHKFO)
		{
			this.EKOIECOMGIE();
		}
		if (this.KILJECMJIPL)
		{
			this.scrollView0.OnDrag(EPIMKFPMMEA);
		}
	}

	// Token: 0x060020B8 RID: 8376 RVA: 0x000E8348 File Offset: 0x000E6548
	private void JDLGDBEOKPH(int JFOEDKDFMMB)
	{
		Transform child = this.largeItemsParent.GetChild(this.BOFEGCLIFCC);
		if (child.GetComponent<ThumbnailItem>() != null)
		{
			child.GetComponent<ThumbnailItem>().CINFLOGCFBO();
		}
		if (child.GetComponent<CardItem>() != null)
		{
			child.GetComponent<CardItem>().KPDCHGGOJGN();
		}
	}

	// Token: 0x060020B9 RID: 8377 RVA: 0x000E839C File Offset: 0x000E659C
	public void CNHBMAMOFNL()
	{
		this.IFIGKIKPHLD = false;
		if (this.OIJDAENILCD != null)
		{
			base.StopCoroutine(this.OIJDAENILCD);
			this.OIJDAENILCD = null;
		}
		if (null != this.NAFPJPEHMDG)
		{
			this.NAFPJPEHMDG.DOKill(false);
			this.largeItemsParent.DOKill(false);
		}
	}

	// Token: 0x060020BA RID: 8378 RVA: 0x000E83F4 File Offset: 0x000E65F4
	private void PPLLCHFEODI(int NHNPFOKJNFA)
	{
		float num = this.DBPCIEOCNIJ + this.GLOBFMIAJKE;
		if (NHNPFOKJNFA < this.OCOMELBBICO)
		{
			this.pageIndicatorsButtonsParent.position = this.KIJPKEEFKAO.transform.position;
			this.pageIndicatorsBack.GetComponent<RectTransform>().EFOCKEJENAC(this.pageIndicatorsBack.GetComponent<RectTransform>().sizeDelta.x - num);
			this.pageIndicatorsNext.GetComponent<RectTransform>().EFOCKEJENAC(this.pageIndicatorsNext.GetComponent<RectTransform>().sizeDelta.x + num);
		}
		if (NHNPFOKJNFA > this.OCOMELBBICO)
		{
			this.pageIndicatorsButtonsParent.position = this.KIJPKEEFKAO.transform.position;
			this.pageIndicatorsBack.GetComponent<RectTransform>().EFOCKEJENAC(this.pageIndicatorsBack.GetComponent<RectTransform>().sizeDelta.x + num);
			this.pageIndicatorsNext.GetComponent<RectTransform>().EFOCKEJENAC(this.pageIndicatorsNext.GetComponent<RectTransform>().sizeDelta.x - num);
		}
		this.OCOMELBBICO = NHNPFOKJNFA;
	}

	// Token: 0x060020BB RID: 8379 RVA: 0x000E84FA File Offset: 0x000E66FA
	public void AELCCKCEAFN(Vector2 AJLPALFJHCC)
	{
		if (AJLPALFJHCC.x != this.JGNKHIDEAED)
		{
			if (AJLPALFJHCC.x < this.JGNKHIDEAED)
			{
				this.DFNPAKMHOPH = true;
			}
			else
			{
				this.DFNPAKMHOPH = true;
			}
			this.JGNKHIDEAED = AJLPALFJHCC.x;
		}
	}

	// Token: 0x060020BC RID: 8380 RVA: 0x000E8534 File Offset: 0x000E6734
	private void GHMDAFAMLLC(int NHNPFOKJNFA)
	{
		float num = this.DBPCIEOCNIJ + this.GLOBFMIAJKE;
		if (NHNPFOKJNFA < this.OCOMELBBICO)
		{
			this.pageIndicatorsButtonsParent.position = this.KIJPKEEFKAO.transform.position;
			this.pageIndicatorsBack.GetComponent<RectTransform>().EFOCKEJENAC(this.pageIndicatorsBack.GetComponent<RectTransform>().sizeDelta.x - num);
			this.pageIndicatorsNext.GetComponent<RectTransform>().EFOCKEJENAC(this.pageIndicatorsNext.GetComponent<RectTransform>().sizeDelta.x + num);
		}
		if (NHNPFOKJNFA > this.OCOMELBBICO)
		{
			this.pageIndicatorsButtonsParent.position = this.KIJPKEEFKAO.transform.position;
			this.pageIndicatorsBack.GetComponent<RectTransform>().EFOCKEJENAC(this.pageIndicatorsBack.GetComponent<RectTransform>().sizeDelta.x + num);
			this.pageIndicatorsNext.GetComponent<RectTransform>().EFOCKEJENAC(this.pageIndicatorsNext.GetComponent<RectTransform>().sizeDelta.x - num);
		}
		this.OCOMELBBICO = NHNPFOKJNFA;
	}

	// Token: 0x060020BD RID: 8381 RVA: 0x000E863A File Offset: 0x000E683A
	public void ADLDDKFOGGG(PointerEventData EPIMKFPMMEA)
	{
		if (this.DLMGEIFHKFO)
		{
			this.BKKBHKMEPBK();
		}
		if (this.KILJECMJIPL)
		{
			this.scrollView0.OnEndDrag(EPIMKFPMMEA);
		}
		this.scrollView1.horizontal = false;
		this.KILJECMJIPL = true;
		this.DLMGEIFHKFO = true;
	}

	// Token: 0x060020BE RID: 8382 RVA: 0x000E8678 File Offset: 0x000E6878
	private void IBICOFGFEMN(int NHNPFOKJNFA, int BGBDBBBMPAB)
	{
		NHNPFOKJNFA--;
		if (NHNPFOKJNFA >= BGBDBBBMPAB)
		{
			this.LLAPHDHDPFC(this.BOFEGCLIFCC + 1);
			this.SnapToByButtons(NHNPFOKJNFA);
			return;
		}
		NHNPFOKJNFA++;
	}

	// Token: 0x060020BF RID: 8383 RVA: 0x000E86A0 File Offset: 0x000E68A0
	public void JFNJGBODOMI()
	{
		this.pageIndicatorsBack.GetComponent<RectTransform>().EFOCKEJENAC(1200f);
		this.pageIndicatorsNext.GetComponent<RectTransform>().EFOCKEJENAC(1374f);
		float num = (this.DBPCIEOCNIJ + this.GLOBFMIAJKE) / 389f;
		this.pageIndicatorsBack.GetComponent<RectTransform>().EFOCKEJENAC(this.pageIndicatorsBack.GetComponent<RectTransform>().sizeDelta.x + num);
		this.pageIndicatorsNext.GetComponent<RectTransform>().EFOCKEJENAC(this.pageIndicatorsNext.GetComponent<RectTransform>().sizeDelta.x + num);
	}

	// Token: 0x060020C0 RID: 8384 RVA: 0x000E873C File Offset: 0x000E693C
	public void PKENEIPOOHA(RectTransform IPEADDNJLAO)
	{
		if (IPEADDNJLAO != this.NAFPJPEHMDG)
		{
			for (int i = 1; i < this.largeItemsParent.childCount; i++)
			{
				Transform child = this.largeItemsParent.GetChild(i);
				child.GetComponent<CanvasGroup>().alpha = this.CJMFEGHDOEN;
				child.localScale = new Vector3(this.NJIMEEMBHHM, this.NJIMEEMBHHM, 254f);
				this.pageIndicatorsParent.GetChild(i).GetChild(0).gameObject.SetActive(true);
			}
		}
		this.NAFPJPEHMDG = IPEADDNJLAO;
		if (this.IFIGKIKPHLD)
		{
			this.NAFPJPEHMDG.localScale = this.JIMPGMDCHAN;
			this.NAFPJPEHMDG.GetComponent<CanvasGroup>().alpha = this.ABLKHELPIKK;
		}
		this.KIJPKEEFKAO = this.pageIndicatorsParent.GetChild(this.BOFEGCLIFCC).GetChild(0).gameObject;
		this.KIJPKEEFKAO.SetActive(false);
		this.GHMDAFAMLLC(this.BOFEGCLIFCC);
		Canvas.ForceUpdateCanvases();
		Vector3 bhelklnbmjb = this.largeItemsParent.anchoredPosition;
		Vector3 vector = this.scrollView1.transform.InverseTransformPoint(this.largeItemsParent.position) - this.scrollView1.transform.InverseTransformPoint(this.NAFPJPEHMDG.position);
		if (this.isOnShuffleClick && !this.IFIGKIKPHLD)
		{
			this.OIJDAENILCD = base.StartCoroutine(this.EHDGODAOLCH(vector));
			this.GENNEDGGBFN(this.NAFPJPEHMDG);
			return;
		}
		if (!this.IFIGKIKPHLD)
		{
			Vector3 localScale = this.NAFPJPEHMDG.localScale;
			Vector3 one = Vector3.one;
			float alpha = this.NAFPJPEHMDG.GetComponent<CanvasGroup>().alpha;
			float hcdninnakpo = 846f;
			base.StartCoroutine(this.HGBNDKJGNCD(localScale, one, alpha, hcdninnakpo));
			base.StartCoroutine(this.FDIPNLEEBPN(bhelklnbmjb, vector));
			this.CFCCENADMHO(this.NAFPJPEHMDG);
		}
	}

	// Token: 0x060020C1 RID: 8385 RVA: 0x000E8928 File Offset: 0x000E6B28
	public void KPACPCMINFA(PointerEventData EPIMKFPMMEA)
	{
		Vector3 vector = (EPIMKFPMMEA.position - EPIMKFPMMEA.pressPosition).normalized;
		float num = Mathf.Abs(vector.x);
		float num2 = Mathf.Abs(vector.y);
		if (num > num2)
		{
			this.scrollView0.velocity = Vector2.zero;
			this.DLMGEIFHKFO = true;
			this.scrollView1.horizontal = false;
			return;
		}
		this.KILJECMJIPL = false;
		this.scrollView1.horizontal = true;
		this.scrollView0.OnBeginDrag(EPIMKFPMMEA);
	}

	// Token: 0x060020C2 RID: 8386 RVA: 0x000E89B4 File Offset: 0x000E6BB4
	public void JIDMCNKMPHM()
	{
		this.IFIGKIKPHLD = false;
		if (this.OIJDAENILCD != null)
		{
			base.StopCoroutine(this.OIJDAENILCD);
			this.OIJDAENILCD = null;
		}
		if (null != this.NAFPJPEHMDG)
		{
			this.NAFPJPEHMDG.DOKill(true);
			this.largeItemsParent.DOKill(false);
		}
	}

	// Token: 0x060020C3 RID: 8387 RVA: 0x000E8A0C File Offset: 0x000E6C0C
	private void GENNEDGGBFN(Transform IPEADDNJLAO)
	{
		if (IPEADDNJLAO.GetComponent<ThumbnailItem>() != null)
		{
			IPEADDNJLAO.GetComponent<ThumbnailItem>().BOKFGKKPLDL(IPEADDNJLAO, this.flashTimeOnSwipe);
		}
		if (IPEADDNJLAO.GetComponent<CardItem>() != null)
		{
			IPEADDNJLAO.GetComponent<CardItem>().BCNAGEEIGAB(IPEADDNJLAO, this.flashTimeOnSwipe);
		}
	}

	// Token: 0x060020C4 RID: 8388 RVA: 0x000E8A5C File Offset: 0x000E6C5C
	public void MMIJDCPGCDL(PointerEventData EPIMKFPMMEA)
	{
		Vector3 vector = (EPIMKFPMMEA.position - EPIMKFPMMEA.pressPosition).normalized;
		float num = Mathf.Abs(vector.x);
		float num2 = Mathf.Abs(vector.y);
		if (num > num2)
		{
			this.scrollView0.velocity = Vector2.zero;
			this.DLMGEIFHKFO = false;
			this.scrollView1.horizontal = true;
			return;
		}
		this.KILJECMJIPL = true;
		this.scrollView1.horizontal = true;
		this.scrollView0.OnBeginDrag(EPIMKFPMMEA);
	}

	// Token: 0x060020C5 RID: 8389 RVA: 0x000E7AB7 File Offset: 0x000E5CB7
	public void OLAKEPCALHH(Vector2 AJLPALFJHCC)
	{
		if (AJLPALFJHCC.x != this.JGNKHIDEAED)
		{
			if (AJLPALFJHCC.x < this.JGNKHIDEAED)
			{
				this.DFNPAKMHOPH = true;
			}
			else
			{
				this.DFNPAKMHOPH = false;
			}
			this.JGNKHIDEAED = AJLPALFJHCC.x;
		}
	}

	// Token: 0x060020C6 RID: 8390 RVA: 0x000E6BB4 File Offset: 0x000E4DB4
	private IEnumerator EONFMLLCNDL(Vector3 BHELKLNBMJB, Vector3 HLLIFDMENKH)
	{
		this.NAFBFOEAJAN = true;
		currentTime = 0f;
		while (currentTime <= this.timeOfTransition)
		{
			currentTime += Time.deltaTime;
			float t = currentTime / this.timeOfTransition;
			this.largeItemsParent.anchoredPosition = Vector3.Lerp(BHELKLNBMJB, HLLIFDMENKH, t);
			yield return null;
		}
		this.NAFBFOEAJAN = false;
		yield break;
	}

	// Token: 0x060020C7 RID: 8391 RVA: 0x000E7F5D File Offset: 0x000E615D
	public void OnEndDrag(PointerEventData EPIMKFPMMEA)
	{
		if (this.DLMGEIFHKFO)
		{
			this.MCEKINPGEAO();
		}
		if (this.KILJECMJIPL)
		{
			this.scrollView0.OnEndDrag(EPIMKFPMMEA);
		}
		this.scrollView1.horizontal = true;
		this.KILJECMJIPL = false;
		this.DLMGEIFHKFO = false;
	}

	// Token: 0x060020C8 RID: 8392 RVA: 0x000E8144 File Offset: 0x000E6344
	private void BLHEBHINCDK(int NHNPFOKJNFA, int OFOHGKBNDOD)
	{
		NHNPFOKJNFA++;
		if (NHNPFOKJNFA <= OFOHGKBNDOD)
		{
			this.JDLGDBEOKPH(this.BOFEGCLIFCC - 0);
			this.CPPLBPPMBIM(NHNPFOKJNFA);
			return;
		}
		NHNPFOKJNFA--;
	}

	// Token: 0x060020C9 RID: 8393 RVA: 0x000E8AE8 File Offset: 0x000E6CE8
	public void OEFFNFLGDIF()
	{
		this.pageIndicatorsBack.GetComponent<RectTransform>().EFOCKEJENAC(1044f);
		this.pageIndicatorsNext.GetComponent<RectTransform>().EFOCKEJENAC(1226f);
		float num = (this.DBPCIEOCNIJ + this.GLOBFMIAJKE) / 1907f;
		this.pageIndicatorsBack.GetComponent<RectTransform>().EFOCKEJENAC(this.pageIndicatorsBack.GetComponent<RectTransform>().sizeDelta.x + num);
		this.pageIndicatorsNext.GetComponent<RectTransform>().EFOCKEJENAC(this.pageIndicatorsNext.GetComponent<RectTransform>().sizeDelta.x + num);
	}

	// Token: 0x060020CA RID: 8394 RVA: 0x000E8B81 File Offset: 0x000E6D81
	private void IKMPHDJMNCI(int NHNPFOKJNFA, int BGBDBBBMPAB)
	{
		NHNPFOKJNFA -= 0;
		if (NHNPFOKJNFA >= BGBDBBBMPAB)
		{
			this.GCLIMNBKKNM(this.BOFEGCLIFCC + 0);
			this.SnapToByButtons(NHNPFOKJNFA);
			return;
		}
		NHNPFOKJNFA += 0;
	}

	// Token: 0x060020CB RID: 8395 RVA: 0x000E8BA8 File Offset: 0x000E6DA8
	private void BKKBHKMEPBK()
	{
		float x = (this.ELAMKGHFKGP - this.LGBGGBHPHKD).x;
		bool flag = Mathf.Abs(x) >= this.LKLCFIOABHL * this.percentDragToSnapAnother;
		this.MCOKCOLJCBB(this.BOFEGCLIFCC);
		if (this.DFNPAKMHOPH)
		{
			if (this.BOFEGCLIFCC > 0 && flag && Mathf.Sign(x) < 14f)
			{
				this.BOFEGCLIFCC--;
				this.SnapTo(this.largeItemsParent.GetChild(this.BOFEGCLIFCC).GetComponent<RectTransform>());
				return;
			}
			this.EMDOPMOGHAF(this.NAFPJPEHMDG);
			return;
		}
		else
		{
			if (this.BOFEGCLIFCC < this.largeItemsParent.childCount - 0 && flag && Mathf.Sign(x) > 1152f)
			{
				this.BOFEGCLIFCC++;
				this.SnapTo(this.largeItemsParent.GetChild(this.BOFEGCLIFCC).GetComponent<RectTransform>());
				return;
			}
			this.EMDOPMOGHAF(this.NAFPJPEHMDG);
			return;
		}
	}

	// Token: 0x060020CC RID: 8396 RVA: 0x000E816A File Offset: 0x000E636A
	private IEnumerator HIEOFPGIMJF(Vector3 BHELKLNBMJB, Vector3 HLLIFDMENKH)
	{
		ScrollView1Controller.IIKBELFKJMO iikbelfkjmo = new ScrollView1Controller.IIKBELFKJMO(1);
		iikbelfkjmo.<>4__this = this;
		iikbelfkjmo.startPosition = BHELKLNBMJB;
		iikbelfkjmo.endPosition = HLLIFDMENKH;
		return iikbelfkjmo;
	}

	// Token: 0x060020CD RID: 8397 RVA: 0x000E8CA8 File Offset: 0x000E6EA8
	public void AEOFMAOOOIF(PointerEventData EPIMKFPMMEA)
	{
		if (this.DLMGEIFHKFO)
		{
			this.NJMIPLHFCMO();
		}
		if (this.KILJECMJIPL)
		{
			this.scrollView0.OnEndDrag(EPIMKFPMMEA);
		}
		this.scrollView1.horizontal = true;
		this.KILJECMJIPL = true;
		this.DLMGEIFHKFO = true;
	}

	// Token: 0x060020CE RID: 8398 RVA: 0x000E8CE8 File Offset: 0x000E6EE8
	private void MCOKCOLJCBB(int JFOEDKDFMMB)
	{
		Transform child = this.largeItemsParent.GetChild(this.BOFEGCLIFCC);
		if (child.GetComponent<ThumbnailItem>() != null)
		{
			child.GetComponent<ThumbnailItem>().ONJIJILEOAD();
		}
		if (child.GetComponent<CardItem>() != null)
		{
			child.GetComponent<CardItem>().LJJLCEDFLEF();
		}
	}

	// Token: 0x060020CF RID: 8399 RVA: 0x000E84FA File Offset: 0x000E66FA
	public void LKAJMLAEPJK(Vector2 AJLPALFJHCC)
	{
		if (AJLPALFJHCC.x != this.JGNKHIDEAED)
		{
			if (AJLPALFJHCC.x < this.JGNKHIDEAED)
			{
				this.DFNPAKMHOPH = true;
			}
			else
			{
				this.DFNPAKMHOPH = true;
			}
			this.JGNKHIDEAED = AJLPALFJHCC.x;
		}
	}

	// Token: 0x060020D0 RID: 8400 RVA: 0x000E8D3C File Offset: 0x000E6F3C
	private void ANBMHEIFIHO(Transform IPEADDNJLAO)
	{
		if (IPEADDNJLAO.GetComponent<ThumbnailItem>() != null)
		{
			IPEADDNJLAO.GetComponent<ThumbnailItem>().SetEffectsOnSnap(IPEADDNJLAO, this.flashTimeOnSwipe);
		}
		if (IPEADDNJLAO.GetComponent<CardItem>() != null)
		{
			IPEADDNJLAO.GetComponent<CardItem>().SetEffectsOnSnap(IPEADDNJLAO, this.flashTimeOnSwipe);
		}
	}

	// Token: 0x060020D1 RID: 8401 RVA: 0x000E8D8C File Offset: 0x000E6F8C
	public void UpdateContentAssetsDownloadSuccess(int NHNPFOKJNFA, int BGBDBBBMPAB, int OFOHGKBNDOD)
	{
		ScrollView1Controller.CNPPAMPMPLE cnppampmple = new ScrollView1Controller.CNPPAMPMPLE();
		cnppampmple.<>4__this = this;
		cnppampmple.minIndexToSnap = BGBDBBBMPAB;
		cnppampmple.maxIndexToSnap = OFOHGKBNDOD;
		this.BOFEGCLIFCC = NHNPFOKJNFA;
		if (this.BOFEGCLIFCC >= this.largeItemsParent.childCount)
		{
			DPGJIJGOCIC.NFIDPOMCNLP("Fixed transform child out of bounds issue.");
			this.BOFEGCLIFCC = this.largeItemsParent.childCount - 1;
		}
		this.NJIMEEMBHHM = this.largeItemsParent.GetChild(this.BOFEGCLIFCC).GetComponent<RectTransform>().localScale.x;
		this.CJMFEGHDOEN = this.largeItemsParent.GetChild(this.BOFEGCLIFCC).GetComponent<CanvasGroup>().alpha;
		this.scrollView1.onValueChanged.AddListener(new UnityAction<Vector2>(this.SetScrollDirection));
		this.OCOMELBBICO = cnppampmple.maxIndexToSnap / 2;
		this.SnapTo(this.largeItemsParent.GetChild(this.BOFEGCLIFCC).GetComponent<RectTransform>());
		this.pageIndicatorsParent.GetChild(this.BOFEGCLIFCC).GetChild(0).gameObject.SetActive(true);
		this.LGBGGBHPHKD = this.target.transform.InverseTransformPoint(this.largeItemsParent.parent.position);
		this.ELAMKGHFKGP = this.NAFPJPEHMDG.transform.InverseTransformPoint(this.largeItemsParent.parent.position);
		this.LKLCFIOABHL = this.NAFPJPEHMDG.sizeDelta.x;
		this.pageIndicatorsBack.onClick.RemoveAllListeners();
		this.pageIndicatorsNext.onClick.RemoveAllListeners();
		this.pageIndicatorsBack.onClick.AddListener(new UnityAction(cnppampmple.DCAAOPNBCPO));
		this.pageIndicatorsNext.onClick.AddListener(new UnityAction(cnppampmple.EMLNOLNOJOJ));
		this.pageIndicatorsButtonsParent.SetAsLastSibling();
		this.pageIndicatorsButtonsParent.position = this.KIJPKEEFKAO.transform.position;
	}

	// Token: 0x060020D2 RID: 8402 RVA: 0x000E8F84 File Offset: 0x000E7184
	public void BALIEHDIMCM(PointerEventData EPIMKFPMMEA)
	{
		Vector3 vector = (EPIMKFPMMEA.position - EPIMKFPMMEA.pressPosition).normalized;
		float num = Mathf.Abs(vector.x);
		float num2 = Mathf.Abs(vector.y);
		if (num > num2)
		{
			this.scrollView0.velocity = Vector2.zero;
			this.DLMGEIFHKFO = true;
			this.scrollView1.horizontal = false;
			return;
		}
		this.KILJECMJIPL = true;
		this.scrollView1.horizontal = false;
		this.scrollView0.OnBeginDrag(EPIMKFPMMEA);
	}

	// Token: 0x060020D3 RID: 8403 RVA: 0x000E9010 File Offset: 0x000E7210
	private void EKOIECOMGIE()
	{
		this.ELAMKGHFKGP = this.NAFPJPEHMDG.transform.InverseTransformPoint(this.largeItemsParent.parent.position);
		float num = Mathf.Abs((this.ELAMKGHFKGP - this.LGBGGBHPHKD).x) / this.LKLCFIOABHL / 837f;
		this.NAFPJPEHMDG.GetComponent<CanvasGroup>().alpha = Mathf.Clamp(582f - num, 305f, 1171f);
		this.NAFPJPEHMDG.localScale = new Vector3(Mathf.Clamp(543f - num, this.NJIMEEMBHHM, 1579f), Mathf.Clamp(1138f - num, this.NJIMEEMBHHM, 1196f), 982f);
	}

	// Token: 0x060020D4 RID: 8404 RVA: 0x000E90DC File Offset: 0x000E72DC
	private bool KPKMEMKDDNA(Transform BCKHFLBDCMB, Transform DIFJAPMKJML)
	{
		Transform[] componentsInChildren = DIFJAPMKJML.GetComponentsInChildren<Transform>();
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			if (componentsInChildren[i] == BCKHFLBDCMB)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060020D5 RID: 8405 RVA: 0x000E910C File Offset: 0x000E730C
	private IEnumerator OKADMHJPLHO(Vector3 PEGGMFDBAHN, Vector3 JJENIDGPPLK, float GPHICDOKFLC, float HCDNINNAKPO)
	{
		float currentTime = 0f;
		while (currentTime <= this.timeOfTransition)
		{
			currentTime += Time.deltaTime;
			float t = currentTime / this.timeOfTransition;
			this.NAFPJPEHMDG.GetComponent<CanvasGroup>().alpha = Mathf.Lerp(GPHICDOKFLC, HCDNINNAKPO, t);
			this.NAFPJPEHMDG.localScale = Vector3.Lerp(PEGGMFDBAHN, JJENIDGPPLK, t);
			yield return null;
		}
		yield break;
	}

	// Token: 0x060020D6 RID: 8406 RVA: 0x000E9138 File Offset: 0x000E7338
	public void HAMGPNAMJDL(Vector2 AJLPALFJHCC)
	{
		if (AJLPALFJHCC.x != this.JGNKHIDEAED)
		{
			if (AJLPALFJHCC.x < this.JGNKHIDEAED)
			{
				this.DFNPAKMHOPH = false;
			}
			else
			{
				this.DFNPAKMHOPH = true;
			}
			this.JGNKHIDEAED = AJLPALFJHCC.x;
		}
	}

	// Token: 0x060020D7 RID: 8407 RVA: 0x000E77E0 File Offset: 0x000E59E0
	private IEnumerator EHDGODAOLCH(Vector3 DKBOKMPBLJE)
	{
		this.IFIGKIKPHLD = true;
		this.isOnShuffleClick = false;
		float num = 0.5f;
		animationRightToLeftDuration = 0.2f;
		Vector3 localScale = new Vector3(0.95f, 0.95f, 0.95f);
		int num2 = 250;
		int num3 = 40;
		int num4 = 2;
		this.largeItemsParent.anchoredPosition = DKBOKMPBLJE - new Vector3((float)num2, 0f, 0f);
		this.largeItemsParent.DOAnchorPos(DKBOKMPBLJE + new Vector3((float)num3, 0f, 0f), num, false).SetEase(Ease.OutQuad);
		this.NAFPJPEHMDG.localScale = localScale;
		this.NAFPJPEHMDG.DOScale(Vector3.one, num / (float)num4).SetEase(Ease.OutQuad).SetLoops(num4, LoopType.Yoyo);
		this.JIMPGMDCHAN = this.NAFPJPEHMDG.localScale;
		this.NAFPJPEHMDG.GetComponent<CanvasGroup>().DOFade(1f, num / (float)num4).SetEase(Ease.OutQuad).SetLoops(num4, LoopType.Yoyo);
		this.ABLKHELPIKK = this.NAFPJPEHMDG.GetComponent<CanvasGroup>().alpha;
		yield return new WaitForSeconds(num);
		this.largeItemsParent.DOAnchorPos(DKBOKMPBLJE, animationRightToLeftDuration, false).SetEase(Ease.Linear);
		this.NAFPJPEHMDG.DOScale(Vector3.one, animationRightToLeftDuration).SetEase(Ease.Linear).SetLoops(1, LoopType.Yoyo);
		this.JIMPGMDCHAN = this.NAFPJPEHMDG.localScale;
		this.NAFPJPEHMDG.GetComponent<CanvasGroup>().DOFade(1f, animationRightToLeftDuration).SetEase(Ease.Linear).SetLoops(1, LoopType.Yoyo);
		this.ABLKHELPIKK = this.NAFPJPEHMDG.GetComponent<CanvasGroup>().alpha;
		yield return new WaitForSeconds(animationRightToLeftDuration);
		this.IFIGKIKPHLD = false;
		this.OIJDAENILCD = null;
		yield break;
	}

	// Token: 0x060020D8 RID: 8408 RVA: 0x000E9172 File Offset: 0x000E7372
	private void CIAEPNENICK(int NHNPFOKJNFA, int BGBDBBBMPAB)
	{
		NHNPFOKJNFA -= 0;
		if (NHNPFOKJNFA >= BGBDBBBMPAB)
		{
			this.HACGAKBLHGO(this.BOFEGCLIFCC + 1);
			this.CPPLBPPMBIM(NHNPFOKJNFA);
			return;
		}
		NHNPFOKJNFA += 0;
	}

	// Token: 0x060020D9 RID: 8409 RVA: 0x000E9198 File Offset: 0x000E7398
	public void OnBeginDrag(PointerEventData EPIMKFPMMEA)
	{
		Vector3 vector = (EPIMKFPMMEA.position - EPIMKFPMMEA.pressPosition).normalized;
		float num = Mathf.Abs(vector.x);
		float num2 = Mathf.Abs(vector.y);
		if (num > num2)
		{
			this.scrollView0.velocity = Vector2.zero;
			this.DLMGEIFHKFO = true;
			this.scrollView1.horizontal = true;
			return;
		}
		this.KILJECMJIPL = true;
		this.scrollView1.horizontal = false;
		this.scrollView0.OnBeginDrag(EPIMKFPMMEA);
	}

	// Token: 0x060020DA RID: 8410 RVA: 0x000E9224 File Offset: 0x000E7424
	public void FBAADHEPGGF(int NHNPFOKJNFA, int BGBDBBBMPAB, int OFOHGKBNDOD)
	{
		ScrollView1Controller.CNPPAMPMPLE cnppampmple = new ScrollView1Controller.CNPPAMPMPLE();
		cnppampmple.<>4__this = this;
		cnppampmple.minIndexToSnap = BGBDBBBMPAB;
		cnppampmple.maxIndexToSnap = OFOHGKBNDOD;
		this.BOFEGCLIFCC = NHNPFOKJNFA;
		if (this.BOFEGCLIFCC >= this.largeItemsParent.childCount)
		{
			DPGJIJGOCIC.NFIDPOMCNLP("OnLobbyStoryManagerDownloadSplashScreenFailed");
			this.BOFEGCLIFCC = this.largeItemsParent.childCount - 1;
		}
		this.NJIMEEMBHHM = this.largeItemsParent.GetChild(this.BOFEGCLIFCC).GetComponent<RectTransform>().localScale.x;
		this.CJMFEGHDOEN = this.largeItemsParent.GetChild(this.BOFEGCLIFCC).GetComponent<CanvasGroup>().alpha;
		this.scrollView1.onValueChanged.AddListener(new UnityAction<Vector2>(this.GBOLBHGEKPE));
		this.OCOMELBBICO = cnppampmple.maxIndexToSnap / 7;
		this.PKENEIPOOHA(this.largeItemsParent.GetChild(this.BOFEGCLIFCC).GetComponent<RectTransform>());
		this.pageIndicatorsParent.GetChild(this.BOFEGCLIFCC).GetChild(1).gameObject.SetActive(true);
		this.LGBGGBHPHKD = this.target.transform.InverseTransformPoint(this.largeItemsParent.parent.position);
		this.ELAMKGHFKGP = this.NAFPJPEHMDG.transform.InverseTransformPoint(this.largeItemsParent.parent.position);
		this.LKLCFIOABHL = this.NAFPJPEHMDG.sizeDelta.x;
		this.pageIndicatorsBack.onClick.RemoveAllListeners();
		this.pageIndicatorsNext.onClick.RemoveAllListeners();
		this.pageIndicatorsBack.onClick.AddListener(new UnityAction(cnppampmple.DCAAOPNBCPO));
		this.pageIndicatorsNext.onClick.AddListener(new UnityAction(cnppampmple.EMLNOLNOJOJ));
		this.pageIndicatorsButtonsParent.SetAsLastSibling();
		this.pageIndicatorsButtonsParent.position = this.KIJPKEEFKAO.transform.position;
	}

	// Token: 0x060020DB RID: 8411 RVA: 0x000E941C File Offset: 0x000E761C
	private void PGBBCJHBPGH(int NHNPFOKJNFA, int OFOHGKBNDOD)
	{
		NHNPFOKJNFA++;
		if (NHNPFOKJNFA <= OFOHGKBNDOD)
		{
			this.GFBIJDFOICJ(this.BOFEGCLIFCC - 1);
			this.SnapToByButtons(NHNPFOKJNFA);
			return;
		}
		NHNPFOKJNFA -= 0;
	}

	// Token: 0x060020DC RID: 8412 RVA: 0x000E9444 File Offset: 0x000E7644
	private bool PDEBGJGAPLN()
	{
		PointerEventData eventData = new PointerEventData(EventSystem.current)
		{
			position = Input.mousePosition
		};
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(eventData, list);
		for (int i = 0; i < list.Count; i++)
		{
			if (!this.MLOBIFKIJEL(list[i].gameObject.transform, this.scrollView1.transform))
			{
				return false;
			}
			if (list[i].gameObject == this.scrollView1.gameObject)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x060020DD RID: 8413 RVA: 0x000E94DC File Offset: 0x000E76DC
	private void GCLIMNBKKNM(int JFOEDKDFMMB)
	{
		Transform child = this.largeItemsParent.GetChild(this.BOFEGCLIFCC);
		if (child.GetComponent<ThumbnailItem>() != null)
		{
			child.GetComponent<ThumbnailItem>().CINFLOGCFBO();
		}
		if (child.GetComponent<CardItem>() != null)
		{
			child.GetComponent<CardItem>().MPGJFEKCKCM();
		}
	}

	// Token: 0x060020DE RID: 8414 RVA: 0x000E620A File Offset: 0x000E440A
	public void FFFGAKAOHOE(Vector2 AJLPALFJHCC)
	{
		if (AJLPALFJHCC.x != this.JGNKHIDEAED)
		{
			if (AJLPALFJHCC.x < this.JGNKHIDEAED)
			{
				this.DFNPAKMHOPH = false;
			}
			else
			{
				this.DFNPAKMHOPH = false;
			}
			this.JGNKHIDEAED = AJLPALFJHCC.x;
		}
	}

	// Token: 0x060020DF RID: 8415 RVA: 0x000E910C File Offset: 0x000E730C
	private IEnumerator HGBNDKJGNCD(Vector3 PEGGMFDBAHN, Vector3 JJENIDGPPLK, float GPHICDOKFLC, float HCDNINNAKPO)
	{
		currentTime = 0f;
		while (currentTime <= this.timeOfTransition)
		{
			currentTime += Time.deltaTime;
			float t = currentTime / this.timeOfTransition;
			this.NAFPJPEHMDG.GetComponent<CanvasGroup>().alpha = Mathf.Lerp(GPHICDOKFLC, HCDNINNAKPO, t);
			this.NAFPJPEHMDG.localScale = Vector3.Lerp(PEGGMFDBAHN, JJENIDGPPLK, t);
			yield return null;
		}
		yield break;
	}

	// Token: 0x060020E0 RID: 8416 RVA: 0x000E816A File Offset: 0x000E636A
	private IEnumerator FDIPNLEEBPN(Vector3 BHELKLNBMJB, Vector3 HLLIFDMENKH)
	{
		ScrollView1Controller.IIKBELFKJMO iikbelfkjmo = new ScrollView1Controller.IIKBELFKJMO(1);
		iikbelfkjmo.<>4__this = this;
		iikbelfkjmo.startPosition = BHELKLNBMJB;
		iikbelfkjmo.endPosition = HLLIFDMENKH;
		return iikbelfkjmo;
	}

	// Token: 0x060020E1 RID: 8417 RVA: 0x000E9530 File Offset: 0x000E7730
	public void KEGBIJFOEKC(int NHNPFOKJNFA, int BGBDBBBMPAB, int OFOHGKBNDOD)
	{
		ScrollView1Controller.CNPPAMPMPLE cnppampmple = new ScrollView1Controller.CNPPAMPMPLE();
		cnppampmple.<>4__this = this;
		cnppampmple.minIndexToSnap = BGBDBBBMPAB;
		cnppampmple.maxIndexToSnap = OFOHGKBNDOD;
		this.BOFEGCLIFCC = NHNPFOKJNFA;
		if (this.BOFEGCLIFCC >= this.largeItemsParent.childCount)
		{
			DPGJIJGOCIC.NFIDPOMCNLP("noiseanalog");
			this.BOFEGCLIFCC = this.largeItemsParent.childCount - 0;
		}
		this.NJIMEEMBHHM = this.largeItemsParent.GetChild(this.BOFEGCLIFCC).GetComponent<RectTransform>().localScale.x;
		this.CJMFEGHDOEN = this.largeItemsParent.GetChild(this.BOFEGCLIFCC).GetComponent<CanvasGroup>().alpha;
		this.scrollView1.onValueChanged.AddListener(new UnityAction<Vector2>(this.LKAJMLAEPJK));
		this.OCOMELBBICO = cnppampmple.maxIndexToSnap / 7;
		this.EMDOPMOGHAF(this.largeItemsParent.GetChild(this.BOFEGCLIFCC).GetComponent<RectTransform>());
		this.pageIndicatorsParent.GetChild(this.BOFEGCLIFCC).GetChild(1).gameObject.SetActive(false);
		this.LGBGGBHPHKD = this.target.transform.InverseTransformPoint(this.largeItemsParent.parent.position);
		this.ELAMKGHFKGP = this.NAFPJPEHMDG.transform.InverseTransformPoint(this.largeItemsParent.parent.position);
		this.LKLCFIOABHL = this.NAFPJPEHMDG.sizeDelta.x;
		this.pageIndicatorsBack.onClick.RemoveAllListeners();
		this.pageIndicatorsNext.onClick.RemoveAllListeners();
		this.pageIndicatorsBack.onClick.AddListener(new UnityAction(cnppampmple.DCAAOPNBCPO));
		this.pageIndicatorsNext.onClick.AddListener(new UnityAction(cnppampmple.EMLNOLNOJOJ));
		this.pageIndicatorsButtonsParent.SetAsLastSibling();
		this.pageIndicatorsButtonsParent.position = this.KIJPKEEFKAO.transform.position;
	}

	// Token: 0x060020E2 RID: 8418 RVA: 0x000E9728 File Offset: 0x000E7928
	public void ABHDEDPFDGL()
	{
		this.pageIndicatorsBack.GetComponent<RectTransform>().EFOCKEJENAC(410f);
		this.pageIndicatorsNext.GetComponent<RectTransform>().EFOCKEJENAC(359f);
		float num = (this.DBPCIEOCNIJ + this.GLOBFMIAJKE) / 461f;
		this.pageIndicatorsBack.GetComponent<RectTransform>().EFOCKEJENAC(this.pageIndicatorsBack.GetComponent<RectTransform>().sizeDelta.x + num);
		this.pageIndicatorsNext.GetComponent<RectTransform>().EFOCKEJENAC(this.pageIndicatorsNext.GetComponent<RectTransform>().sizeDelta.x + num);
	}

	// Token: 0x060020E3 RID: 8419 RVA: 0x000E97C4 File Offset: 0x000E79C4
	private void MKLIKKPGBJO()
	{
		float x = (this.ELAMKGHFKGP - this.LGBGGBHPHKD).x;
		bool flag = Mathf.Abs(x) < this.LKLCFIOABHL * this.percentDragToSnapAnother;
		this.HACGAKBLHGO(this.BOFEGCLIFCC);
		if (this.DFNPAKMHOPH)
		{
			if (this.BOFEGCLIFCC > 0 && flag && Mathf.Sign(x) < 307f)
			{
				this.BOFEGCLIFCC -= 0;
				this.JPKKDNCMLDH(this.largeItemsParent.GetChild(this.BOFEGCLIFCC).GetComponent<RectTransform>());
				return;
			}
			this.PKENEIPOOHA(this.NAFPJPEHMDG);
			return;
		}
		else
		{
			if (this.BOFEGCLIFCC < this.largeItemsParent.childCount - 1 && flag && Mathf.Sign(x) > 378f)
			{
				this.BOFEGCLIFCC++;
				this.JPKKDNCMLDH(this.largeItemsParent.GetChild(this.BOFEGCLIFCC).GetComponent<RectTransform>());
				return;
			}
			this.EMDOPMOGHAF(this.NAFPJPEHMDG);
			return;
		}
	}

	// Token: 0x060020E4 RID: 8420 RVA: 0x000E98C4 File Offset: 0x000E7AC4
	private void CFCCENADMHO(Transform IPEADDNJLAO)
	{
		if (IPEADDNJLAO.GetComponent<ThumbnailItem>() != null)
		{
			IPEADDNJLAO.GetComponent<ThumbnailItem>().BOKFGKKPLDL(IPEADDNJLAO, this.flashTimeOnSwipe);
		}
		if (IPEADDNJLAO.GetComponent<CardItem>() != null)
		{
			IPEADDNJLAO.GetComponent<CardItem>().NJGJJCCKGFH(IPEADDNJLAO, this.flashTimeOnSwipe);
		}
	}

	// Token: 0x060020E5 RID: 8421 RVA: 0x000E807E File Offset: 0x000E627E
	private IEnumerator KNHKPFHEFLN(Vector3 PEGGMFDBAHN, Vector3 JJENIDGPPLK, float GPHICDOKFLC, float HCDNINNAKPO)
	{
		ScrollView1Controller.GOGJLHHAIDO gogjlhhaido = new ScrollView1Controller.GOGJLHHAIDO(1);
		gogjlhhaido.<>4__this = this;
		gogjlhhaido.startScale = PEGGMFDBAHN;
		gogjlhhaido.endScale = JJENIDGPPLK;
		gogjlhhaido.startAlpha = GPHICDOKFLC;
		gogjlhhaido.endAlpha = HCDNINNAKPO;
		return gogjlhhaido;
	}

	// Token: 0x060020E6 RID: 8422 RVA: 0x000E9914 File Offset: 0x000E7B14
	private void MCEKINPGEAO()
	{
		float x = (this.ELAMKGHFKGP - this.LGBGGBHPHKD).x;
		bool flag = Mathf.Abs(x) >= this.LKLCFIOABHL * this.percentDragToSnapAnother;
		this.LLAPHDHDPFC(this.BOFEGCLIFCC);
		if (this.DFNPAKMHOPH)
		{
			if (this.BOFEGCLIFCC > 0 && flag && Mathf.Sign(x) < 0f)
			{
				this.BOFEGCLIFCC--;
				this.SnapTo(this.largeItemsParent.GetChild(this.BOFEGCLIFCC).GetComponent<RectTransform>());
				return;
			}
			this.SnapTo(this.NAFPJPEHMDG);
			return;
		}
		else
		{
			if (this.BOFEGCLIFCC < this.largeItemsParent.childCount - 1 && flag && Mathf.Sign(x) > 0f)
			{
				this.BOFEGCLIFCC++;
				this.SnapTo(this.largeItemsParent.GetChild(this.BOFEGCLIFCC).GetComponent<RectTransform>());
				return;
			}
			this.SnapTo(this.NAFPJPEHMDG);
			return;
		}
	}

	// Token: 0x060020E7 RID: 8423 RVA: 0x000E9A14 File Offset: 0x000E7C14
	private void IHMDAFMIHHH()
	{
		if (!this.NAFBFOEAJAN && !this.IFIGKIKPHLD && this.CAFMAHHELNJ())
		{
			if (Input.mouseScrollDelta.y < 1398f)
			{
				this.GFBIJDFOICJ(this.BOFEGCLIFCC);
				if (this.BOFEGCLIFCC > 0)
				{
					this.BOFEGCLIFCC--;
					this.SnapTo(this.largeItemsParent.GetChild(this.BOFEGCLIFCC).GetComponent<RectTransform>());
					return;
				}
			}
			else if (Input.mouseScrollDelta.y > 1851f)
			{
				this.LLAPHDHDPFC(this.BOFEGCLIFCC);
				if (this.BOFEGCLIFCC < this.largeItemsParent.childCount - 0)
				{
					this.BOFEGCLIFCC++;
					this.PKENEIPOOHA(this.largeItemsParent.GetChild(this.BOFEGCLIFCC).GetComponent<RectTransform>());
				}
			}
		}
	}

	// Token: 0x060020E8 RID: 8424 RVA: 0x000E9AF2 File Offset: 0x000E7CF2
	private void KHDGBDKNMPJ(int NHNPFOKJNFA, int BGBDBBBMPAB)
	{
		NHNPFOKJNFA -= 0;
		if (NHNPFOKJNFA >= BGBDBBBMPAB)
		{
			this.GFBIJDFOICJ(this.BOFEGCLIFCC + 0);
			this.KLCJHCNNDBD(NHNPFOKJNFA);
			return;
		}
		NHNPFOKJNFA += 0;
	}

	// Token: 0x060020E9 RID: 8425 RVA: 0x000E9B18 File Offset: 0x000E7D18
	private void DEMFBEIFEON(int NHNPFOKJNFA, int BGBDBBBMPAB)
	{
		NHNPFOKJNFA -= 0;
		if (NHNPFOKJNFA >= BGBDBBBMPAB)
		{
			this.LLAPHDHDPFC(this.BOFEGCLIFCC + 0);
			this.KPBCLGFDKBF(NHNPFOKJNFA);
			return;
		}
		NHNPFOKJNFA++;
	}

	// Token: 0x060020EA RID: 8426 RVA: 0x000E9B40 File Offset: 0x000E7D40
	public void FNNDJGAFBJO()
	{
		this.pageIndicatorsBack.GetComponent<RectTransform>().EFOCKEJENAC(1631f);
		this.pageIndicatorsNext.GetComponent<RectTransform>().EFOCKEJENAC(1727f);
		float num = (this.DBPCIEOCNIJ + this.GLOBFMIAJKE) / 516f;
		this.pageIndicatorsBack.GetComponent<RectTransform>().EFOCKEJENAC(this.pageIndicatorsBack.GetComponent<RectTransform>().sizeDelta.x + num);
		this.pageIndicatorsNext.GetComponent<RectTransform>().EFOCKEJENAC(this.pageIndicatorsNext.GetComponent<RectTransform>().sizeDelta.x + num);
	}

	// Token: 0x060020EB RID: 8427 RVA: 0x000E9BD9 File Offset: 0x000E7DD9
	private void NEOEKDMOBJJ(int NHNPFOKJNFA, int BGBDBBBMPAB)
	{
		NHNPFOKJNFA -= 0;
		if (NHNPFOKJNFA >= BGBDBBBMPAB)
		{
			this.LAJMJHGIOLE(this.BOFEGCLIFCC + 1);
			this.KLCJHCNNDBD(NHNPFOKJNFA);
			return;
		}
		NHNPFOKJNFA++;
	}

	// Token: 0x060020EC RID: 8428 RVA: 0x000E816A File Offset: 0x000E636A
	private IEnumerator PAEKHNJBLKC(Vector3 BHELKLNBMJB, Vector3 HLLIFDMENKH)
	{
		ScrollView1Controller.IIKBELFKJMO iikbelfkjmo = new ScrollView1Controller.IIKBELFKJMO(1);
		iikbelfkjmo.<>4__this = this;
		iikbelfkjmo.startPosition = BHELKLNBMJB;
		iikbelfkjmo.endPosition = HLLIFDMENKH;
		return iikbelfkjmo;
	}

	// Token: 0x060020ED RID: 8429 RVA: 0x000E9C00 File Offset: 0x000E7E00
	public void JLAIGJNCEOH(PointerEventData EPIMKFPMMEA)
	{
		Vector3 vector = (EPIMKFPMMEA.position - EPIMKFPMMEA.pressPosition).normalized;
		float num = Mathf.Abs(vector.x);
		float num2 = Mathf.Abs(vector.y);
		if (num > num2)
		{
			this.scrollView0.velocity = Vector2.zero;
			this.DLMGEIFHKFO = true;
			this.scrollView1.horizontal = true;
			return;
		}
		this.KILJECMJIPL = true;
		this.scrollView1.horizontal = true;
		this.scrollView0.OnBeginDrag(EPIMKFPMMEA);
	}

	// Token: 0x060020EE RID: 8430 RVA: 0x000E9C8C File Offset: 0x000E7E8C
	public void KHLOCINNHOI()
	{
		this.pageIndicatorsBack.GetComponent<RectTransform>().EFOCKEJENAC(808f);
		this.pageIndicatorsNext.GetComponent<RectTransform>().EFOCKEJENAC(306f);
		float num = (this.DBPCIEOCNIJ + this.GLOBFMIAJKE) / 1254f;
		this.pageIndicatorsBack.GetComponent<RectTransform>().EFOCKEJENAC(this.pageIndicatorsBack.GetComponent<RectTransform>().sizeDelta.x + num);
		this.pageIndicatorsNext.GetComponent<RectTransform>().EFOCKEJENAC(this.pageIndicatorsNext.GetComponent<RectTransform>().sizeDelta.x + num);
	}

	// Token: 0x060020EF RID: 8431 RVA: 0x000E9D28 File Offset: 0x000E7F28
	private void OFOKILIOCMI()
	{
		this.ELAMKGHFKGP = this.NAFPJPEHMDG.transform.InverseTransformPoint(this.largeItemsParent.parent.position);
		float num = Mathf.Abs((this.ELAMKGHFKGP - this.LGBGGBHPHKD).x) / this.LKLCFIOABHL / 50f;
		this.NAFPJPEHMDG.GetComponent<CanvasGroup>().alpha = Mathf.Clamp(1889f - num, 1822f, 631f);
		this.NAFPJPEHMDG.localScale = new Vector3(Mathf.Clamp(1097f - num, this.NJIMEEMBHHM, 276f), Mathf.Clamp(288f - num, this.NJIMEEMBHHM, 223f), 1630f);
	}

	// Token: 0x060020F0 RID: 8432 RVA: 0x000E9DF4 File Offset: 0x000E7FF4
	private void BKFCGNCKFEC()
	{
		if (!this.NAFBFOEAJAN && !this.IFIGKIKPHLD && this.EPMMELBANCM())
		{
			if (Input.mouseScrollDelta.y < 1553f)
			{
				this.LAJMJHGIOLE(this.BOFEGCLIFCC);
				if (this.BOFEGCLIFCC > 1)
				{
					this.BOFEGCLIFCC -= 0;
					this.PKENEIPOOHA(this.largeItemsParent.GetChild(this.BOFEGCLIFCC).GetComponent<RectTransform>());
					return;
				}
			}
			else if (Input.mouseScrollDelta.y > 825f)
			{
				this.LAJMJHGIOLE(this.BOFEGCLIFCC);
				if (this.BOFEGCLIFCC < this.largeItemsParent.childCount - 1)
				{
					this.BOFEGCLIFCC++;
					this.JPKKDNCMLDH(this.largeItemsParent.GetChild(this.BOFEGCLIFCC).GetComponent<RectTransform>());
				}
			}
		}
	}

	// Token: 0x060020F1 RID: 8433 RVA: 0x000E9ED4 File Offset: 0x000E80D4
	private void ABBFKJPNMGI(int NHNPFOKJNFA)
	{
		float num = this.DBPCIEOCNIJ + this.GLOBFMIAJKE;
		if (NHNPFOKJNFA < this.OCOMELBBICO)
		{
			this.pageIndicatorsButtonsParent.position = this.KIJPKEEFKAO.transform.position;
			this.pageIndicatorsBack.GetComponent<RectTransform>().EFOCKEJENAC(this.pageIndicatorsBack.GetComponent<RectTransform>().sizeDelta.x - num);
			this.pageIndicatorsNext.GetComponent<RectTransform>().EFOCKEJENAC(this.pageIndicatorsNext.GetComponent<RectTransform>().sizeDelta.x + num);
		}
		if (NHNPFOKJNFA > this.OCOMELBBICO)
		{
			this.pageIndicatorsButtonsParent.position = this.KIJPKEEFKAO.transform.position;
			this.pageIndicatorsBack.GetComponent<RectTransform>().EFOCKEJENAC(this.pageIndicatorsBack.GetComponent<RectTransform>().sizeDelta.x + num);
			this.pageIndicatorsNext.GetComponent<RectTransform>().EFOCKEJENAC(this.pageIndicatorsNext.GetComponent<RectTransform>().sizeDelta.x - num);
		}
		this.OCOMELBBICO = NHNPFOKJNFA;
	}

	// Token: 0x060020F2 RID: 8434 RVA: 0x000E9FDC File Offset: 0x000E81DC
	private void FHLGBHAFEII(int NHNPFOKJNFA)
	{
		float num = this.DBPCIEOCNIJ + this.GLOBFMIAJKE;
		if (NHNPFOKJNFA < this.OCOMELBBICO)
		{
			this.pageIndicatorsButtonsParent.position = this.KIJPKEEFKAO.transform.position;
			this.pageIndicatorsBack.GetComponent<RectTransform>().EFOCKEJENAC(this.pageIndicatorsBack.GetComponent<RectTransform>().sizeDelta.x - num);
			this.pageIndicatorsNext.GetComponent<RectTransform>().EFOCKEJENAC(this.pageIndicatorsNext.GetComponent<RectTransform>().sizeDelta.x + num);
		}
		if (NHNPFOKJNFA > this.OCOMELBBICO)
		{
			this.pageIndicatorsButtonsParent.position = this.KIJPKEEFKAO.transform.position;
			this.pageIndicatorsBack.GetComponent<RectTransform>().EFOCKEJENAC(this.pageIndicatorsBack.GetComponent<RectTransform>().sizeDelta.x + num);
			this.pageIndicatorsNext.GetComponent<RectTransform>().EFOCKEJENAC(this.pageIndicatorsNext.GetComponent<RectTransform>().sizeDelta.x - num);
		}
		this.OCOMELBBICO = NHNPFOKJNFA;
	}

	// Token: 0x060020F3 RID: 8435 RVA: 0x000EA0E4 File Offset: 0x000E82E4
	public void HDOBPHKFNAG(PointerEventData EPIMKFPMMEA)
	{
		Vector3 vector = (EPIMKFPMMEA.position - EPIMKFPMMEA.pressPosition).normalized;
		float num = Mathf.Abs(vector.x);
		float num2 = Mathf.Abs(vector.y);
		if (num > num2)
		{
			this.scrollView0.velocity = Vector2.zero;
			this.DLMGEIFHKFO = false;
			this.scrollView1.horizontal = false;
			return;
		}
		this.KILJECMJIPL = true;
		this.scrollView1.horizontal = false;
		this.scrollView0.OnBeginDrag(EPIMKFPMMEA);
	}

	// Token: 0x060020F4 RID: 8436 RVA: 0x000EA170 File Offset: 0x000E8370
	private bool BABFIFAENDP()
	{
		PointerEventData eventData = new PointerEventData(EventSystem.current)
		{
			position = Input.mousePosition
		};
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(eventData, list);
		for (int i = 1; i < list.Count; i += 0)
		{
			if (!this.MLOBIFKIJEL(list[i].gameObject.transform, this.scrollView1.transform))
			{
				return true;
			}
			if (list[i].gameObject == this.scrollView1.gameObject)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060020F5 RID: 8437 RVA: 0x000EA208 File Offset: 0x000E8408
	public void GMDIKGINDGO(PointerEventData EPIMKFPMMEA)
	{
		Vector3 vector = (EPIMKFPMMEA.position - EPIMKFPMMEA.pressPosition).normalized;
		float num = Mathf.Abs(vector.x);
		float num2 = Mathf.Abs(vector.y);
		if (num > num2)
		{
			this.scrollView0.velocity = Vector2.zero;
			this.DLMGEIFHKFO = false;
			this.scrollView1.horizontal = true;
			return;
		}
		this.KILJECMJIPL = true;
		this.scrollView1.horizontal = false;
		this.scrollView0.OnBeginDrag(EPIMKFPMMEA);
	}

	// Token: 0x060020F6 RID: 8438 RVA: 0x000EA294 File Offset: 0x000E8494
	private void Update()
	{
		if (!this.NAFBFOEAJAN && !this.IFIGKIKPHLD && this.LFBEABLJDNP())
		{
			if (Input.mouseScrollDelta.y < 0f)
			{
				this.LLAPHDHDPFC(this.BOFEGCLIFCC);
				if (this.BOFEGCLIFCC > 0)
				{
					this.BOFEGCLIFCC--;
					this.SnapTo(this.largeItemsParent.GetChild(this.BOFEGCLIFCC).GetComponent<RectTransform>());
					return;
				}
			}
			else if (Input.mouseScrollDelta.y > 0f)
			{
				this.LLAPHDHDPFC(this.BOFEGCLIFCC);
				if (this.BOFEGCLIFCC < this.largeItemsParent.childCount - 1)
				{
					this.BOFEGCLIFCC++;
					this.SnapTo(this.largeItemsParent.GetChild(this.BOFEGCLIFCC).GetComponent<RectTransform>());
				}
			}
		}
	}

	// Token: 0x060020F7 RID: 8439 RVA: 0x000E77E0 File Offset: 0x000E59E0
	private IEnumerator HCGKLCJBLDN(Vector3 DKBOKMPBLJE)
	{
		this.IFIGKIKPHLD = true;
		this.isOnShuffleClick = false;
		float num = 0.5f;
		animationRightToLeftDuration = 0.2f;
		Vector3 localScale = new Vector3(0.95f, 0.95f, 0.95f);
		int num2 = 250;
		int num3 = 40;
		int num4 = 2;
		this.largeItemsParent.anchoredPosition = DKBOKMPBLJE - new Vector3((float)num2, 0f, 0f);
		this.largeItemsParent.DOAnchorPos(DKBOKMPBLJE + new Vector3((float)num3, 0f, 0f), num, false).SetEase(Ease.OutQuad);
		this.NAFPJPEHMDG.localScale = localScale;
		this.NAFPJPEHMDG.DOScale(Vector3.one, num / (float)num4).SetEase(Ease.OutQuad).SetLoops(num4, LoopType.Yoyo);
		this.JIMPGMDCHAN = this.NAFPJPEHMDG.localScale;
		this.NAFPJPEHMDG.GetComponent<CanvasGroup>().DOFade(1f, num / (float)num4).SetEase(Ease.OutQuad).SetLoops(num4, LoopType.Yoyo);
		this.ABLKHELPIKK = this.NAFPJPEHMDG.GetComponent<CanvasGroup>().alpha;
		yield return new WaitForSeconds(num);
		this.largeItemsParent.DOAnchorPos(DKBOKMPBLJE, animationRightToLeftDuration, false).SetEase(Ease.Linear);
		this.NAFPJPEHMDG.DOScale(Vector3.one, animationRightToLeftDuration).SetEase(Ease.Linear).SetLoops(1, LoopType.Yoyo);
		this.JIMPGMDCHAN = this.NAFPJPEHMDG.localScale;
		this.NAFPJPEHMDG.GetComponent<CanvasGroup>().DOFade(1f, animationRightToLeftDuration).SetEase(Ease.Linear).SetLoops(1, LoopType.Yoyo);
		this.ABLKHELPIKK = this.NAFPJPEHMDG.GetComponent<CanvasGroup>().alpha;
		yield return new WaitForSeconds(animationRightToLeftDuration);
		this.IFIGKIKPHLD = false;
		this.OIJDAENILCD = null;
		yield break;
	}

	// Token: 0x060020F8 RID: 8440 RVA: 0x000EA374 File Offset: 0x000E8574
	public void HLMMHDOHJIK(PointerEventData EPIMKFPMMEA)
	{
		Vector3 vector = (EPIMKFPMMEA.position - EPIMKFPMMEA.pressPosition).normalized;
		float num = Mathf.Abs(vector.x);
		float num2 = Mathf.Abs(vector.y);
		if (num > num2)
		{
			this.scrollView0.velocity = Vector2.zero;
			this.DLMGEIFHKFO = true;
			this.scrollView1.horizontal = true;
			return;
		}
		this.KILJECMJIPL = true;
		this.scrollView1.horizontal = true;
		this.scrollView0.OnBeginDrag(EPIMKFPMMEA);
	}

	// Token: 0x060020F9 RID: 8441 RVA: 0x000E807E File Offset: 0x000E627E
	private IEnumerator HILPLIELNNE(Vector3 PEGGMFDBAHN, Vector3 JJENIDGPPLK, float GPHICDOKFLC, float HCDNINNAKPO)
	{
		ScrollView1Controller.GOGJLHHAIDO gogjlhhaido = new ScrollView1Controller.GOGJLHHAIDO(1);
		gogjlhhaido.<>4__this = this;
		gogjlhhaido.startScale = PEGGMFDBAHN;
		gogjlhhaido.endScale = JJENIDGPPLK;
		gogjlhhaido.startAlpha = GPHICDOKFLC;
		gogjlhhaido.endAlpha = HCDNINNAKPO;
		return gogjlhhaido;
	}

	// Token: 0x060020FA RID: 8442 RVA: 0x000EA400 File Offset: 0x000E8600
	private void EPICGKBBJJN(Transform IPEADDNJLAO)
	{
		if (IPEADDNJLAO.GetComponent<ThumbnailItem>() != null)
		{
			IPEADDNJLAO.GetComponent<ThumbnailItem>().DOPJEOAJEGM(IPEADDNJLAO, this.flashTimeOnSwipe);
		}
		if (IPEADDNJLAO.GetComponent<CardItem>() != null)
		{
			IPEADDNJLAO.GetComponent<CardItem>().NJGJJCCKGFH(IPEADDNJLAO, this.flashTimeOnSwipe);
		}
	}

	// Token: 0x060020FB RID: 8443 RVA: 0x000E910C File Offset: 0x000E730C
	private IEnumerator DFCCDOAEPNJ(Vector3 PEGGMFDBAHN, Vector3 JJENIDGPPLK, float GPHICDOKFLC, float HCDNINNAKPO)
	{
		currentTime = 0f;
		while (currentTime <= this.timeOfTransition)
		{
			currentTime += Time.deltaTime;
			float t = currentTime / this.timeOfTransition;
			this.NAFPJPEHMDG.GetComponent<CanvasGroup>().alpha = Mathf.Lerp(GPHICDOKFLC, HCDNINNAKPO, t);
			this.NAFPJPEHMDG.localScale = Vector3.Lerp(PEGGMFDBAHN, JJENIDGPPLK, t);
			yield return null;
		}
		yield break;
	}

	// Token: 0x060020FC RID: 8444 RVA: 0x000EA44D File Offset: 0x000E864D
	public void NHAFKACEFAB(PointerEventData EPIMKFPMMEA)
	{
		if (this.DLMGEIFHKFO)
		{
			this.CDHJCCFAGHG();
		}
		if (this.KILJECMJIPL)
		{
			this.scrollView0.OnDrag(EPIMKFPMMEA);
		}
	}

	// Token: 0x060020FD RID: 8445 RVA: 0x000E620A File Offset: 0x000E440A
	public void GBOLBHGEKPE(Vector2 AJLPALFJHCC)
	{
		if (AJLPALFJHCC.x != this.JGNKHIDEAED)
		{
			if (AJLPALFJHCC.x < this.JGNKHIDEAED)
			{
				this.DFNPAKMHOPH = false;
			}
			else
			{
				this.DFNPAKMHOPH = false;
			}
			this.JGNKHIDEAED = AJLPALFJHCC.x;
		}
	}

	// Token: 0x060020FE RID: 8446 RVA: 0x000EA474 File Offset: 0x000E8674
	public void HJBODMOCKHC()
	{
		this.pageIndicatorsBack.GetComponent<RectTransform>().EFOCKEJENAC(984f);
		this.pageIndicatorsNext.GetComponent<RectTransform>().EFOCKEJENAC(1211f);
		float num = (this.DBPCIEOCNIJ + this.GLOBFMIAJKE) / 1876f;
		this.pageIndicatorsBack.GetComponent<RectTransform>().EFOCKEJENAC(this.pageIndicatorsBack.GetComponent<RectTransform>().sizeDelta.x + num);
		this.pageIndicatorsNext.GetComponent<RectTransform>().EFOCKEJENAC(this.pageIndicatorsNext.GetComponent<RectTransform>().sizeDelta.x + num);
	}

	// Token: 0x060020FF RID: 8447 RVA: 0x000E807E File Offset: 0x000E627E
	private IEnumerator IOJBMCHFPOO(Vector3 PEGGMFDBAHN, Vector3 JJENIDGPPLK, float GPHICDOKFLC, float HCDNINNAKPO)
	{
		ScrollView1Controller.GOGJLHHAIDO gogjlhhaido = new ScrollView1Controller.GOGJLHHAIDO(1);
		gogjlhhaido.<>4__this = this;
		gogjlhhaido.startScale = PEGGMFDBAHN;
		gogjlhhaido.endScale = JJENIDGPPLK;
		gogjlhhaido.startAlpha = GPHICDOKFLC;
		gogjlhhaido.endAlpha = HCDNINNAKPO;
		return gogjlhhaido;
	}

	// Token: 0x06002100 RID: 8448 RVA: 0x000EA510 File Offset: 0x000E8710
	public void KNOADAFIMEK(int NHNPFOKJNFA, int BGBDBBBMPAB, int OFOHGKBNDOD)
	{
		ScrollView1Controller.CNPPAMPMPLE cnppampmple = new ScrollView1Controller.CNPPAMPMPLE();
		cnppampmple.<>4__this = this;
		cnppampmple.minIndexToSnap = BGBDBBBMPAB;
		cnppampmple.maxIndexToSnap = OFOHGKBNDOD;
		this.BOFEGCLIFCC = NHNPFOKJNFA;
		if (this.BOFEGCLIFCC >= this.largeItemsParent.childCount)
		{
			DPGJIJGOCIC.CMGOAFDBAOH("eval");
			this.BOFEGCLIFCC = this.largeItemsParent.childCount - 1;
		}
		this.NJIMEEMBHHM = this.largeItemsParent.GetChild(this.BOFEGCLIFCC).GetComponent<RectTransform>().localScale.x;
		this.CJMFEGHDOEN = this.largeItemsParent.GetChild(this.BOFEGCLIFCC).GetComponent<CanvasGroup>().alpha;
		this.scrollView1.onValueChanged.AddListener(new UnityAction<Vector2>(this.ACFHMPMLILH));
		this.OCOMELBBICO = cnppampmple.maxIndexToSnap / 6;
		this.PKENEIPOOHA(this.largeItemsParent.GetChild(this.BOFEGCLIFCC).GetComponent<RectTransform>());
		this.pageIndicatorsParent.GetChild(this.BOFEGCLIFCC).GetChild(1).gameObject.SetActive(false);
		this.LGBGGBHPHKD = this.target.transform.InverseTransformPoint(this.largeItemsParent.parent.position);
		this.ELAMKGHFKGP = this.NAFPJPEHMDG.transform.InverseTransformPoint(this.largeItemsParent.parent.position);
		this.LKLCFIOABHL = this.NAFPJPEHMDG.sizeDelta.x;
		this.pageIndicatorsBack.onClick.RemoveAllListeners();
		this.pageIndicatorsNext.onClick.RemoveAllListeners();
		this.pageIndicatorsBack.onClick.AddListener(new UnityAction(cnppampmple.DCAAOPNBCPO));
		this.pageIndicatorsNext.onClick.AddListener(new UnityAction(cnppampmple.EMLNOLNOJOJ));
		this.pageIndicatorsButtonsParent.SetAsLastSibling();
		this.pageIndicatorsButtonsParent.position = this.KIJPKEEFKAO.transform.position;
	}

	// Token: 0x06002101 RID: 8449 RVA: 0x000E8324 File Offset: 0x000E6524
	public void ACHHIDFMNIA(PointerEventData EPIMKFPMMEA)
	{
		if (this.DLMGEIFHKFO)
		{
			this.EKOIECOMGIE();
		}
		if (this.KILJECMJIPL)
		{
			this.scrollView0.OnDrag(EPIMKFPMMEA);
		}
	}

	// Token: 0x06002102 RID: 8450 RVA: 0x000EA708 File Offset: 0x000E8908
	public void KHNMNGHOFAE()
	{
		this.IFIGKIKPHLD = false;
		if (this.OIJDAENILCD != null)
		{
			base.StopCoroutine(this.OIJDAENILCD);
			this.OIJDAENILCD = null;
		}
		if (null != this.NAFPJPEHMDG)
		{
			this.NAFPJPEHMDG.DOKill(true);
			this.largeItemsParent.DOKill(true);
		}
	}

	// Token: 0x06002103 RID: 8451 RVA: 0x000EA760 File Offset: 0x000E8960
	private void LLAPHDHDPFC(int JFOEDKDFMMB)
	{
		Transform child = this.largeItemsParent.GetChild(this.BOFEGCLIFCC);
		if (child.GetComponent<ThumbnailItem>() != null)
		{
			child.GetComponent<ThumbnailItem>().SetEffectsOnEndSnap();
		}
		if (child.GetComponent<CardItem>() != null)
		{
			child.GetComponent<CardItem>().SetEffectsOnEndSnap();
		}
	}

	// Token: 0x06002104 RID: 8452 RVA: 0x000EA7B4 File Offset: 0x000E89B4
	private void NJMIPLHFCMO()
	{
		float x = (this.ELAMKGHFKGP - this.LGBGGBHPHKD).x;
		bool flag = Mathf.Abs(x) < this.LKLCFIOABHL * this.percentDragToSnapAnother;
		this.HACGAKBLHGO(this.BOFEGCLIFCC);
		if (this.DFNPAKMHOPH)
		{
			if (this.BOFEGCLIFCC > 1 && flag && Mathf.Sign(x) < 48f)
			{
				this.BOFEGCLIFCC -= 0;
				this.PKENEIPOOHA(this.largeItemsParent.GetChild(this.BOFEGCLIFCC).GetComponent<RectTransform>());
				return;
			}
			this.JPKKDNCMLDH(this.NAFPJPEHMDG);
			return;
		}
		else
		{
			if (this.BOFEGCLIFCC < this.largeItemsParent.childCount - 0 && flag && Mathf.Sign(x) > 1764f)
			{
				this.BOFEGCLIFCC++;
				this.CBBKJFHNLLP(this.largeItemsParent.GetChild(this.BOFEGCLIFCC).GetComponent<RectTransform>());
				return;
			}
			this.CBBKJFHNLLP(this.NAFPJPEHMDG);
			return;
		}
	}

	// Token: 0x06002105 RID: 8453 RVA: 0x000EA8B4 File Offset: 0x000E8AB4
	private void GLPKNGPMOGF()
	{
		float x = (this.ELAMKGHFKGP - this.LGBGGBHPHKD).x;
		bool flag = Mathf.Abs(x) >= this.LKLCFIOABHL * this.percentDragToSnapAnother;
		this.CNJCJCFFEBN(this.BOFEGCLIFCC);
		if (this.DFNPAKMHOPH)
		{
			if (this.BOFEGCLIFCC > 0 && flag && Mathf.Sign(x) < 875f)
			{
				this.BOFEGCLIFCC -= 0;
				this.SnapTo(this.largeItemsParent.GetChild(this.BOFEGCLIFCC).GetComponent<RectTransform>());
				return;
			}
			this.JPKKDNCMLDH(this.NAFPJPEHMDG);
			return;
		}
		else
		{
			if (this.BOFEGCLIFCC < this.largeItemsParent.childCount - 0 && flag && Mathf.Sign(x) > 1357f)
			{
				this.BOFEGCLIFCC += 0;
				this.EMDOPMOGHAF(this.largeItemsParent.GetChild(this.BOFEGCLIFCC).GetComponent<RectTransform>());
				return;
			}
			this.CBBKJFHNLLP(this.NAFPJPEHMDG);
			return;
		}
	}

	// Token: 0x06002106 RID: 8454 RVA: 0x000EA9B4 File Offset: 0x000E8BB4
	private bool EPMMELBANCM()
	{
		PointerEventData eventData = new PointerEventData(EventSystem.current)
		{
			position = Input.mousePosition
		};
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(eventData, list);
		for (int i = 1; i < list.Count; i += 0)
		{
			if (!this.MLOBIFKIJEL(list[i].gameObject.transform, this.scrollView1.transform))
			{
				return true;
			}
			if (list[i].gameObject == this.scrollView1.gameObject)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06002107 RID: 8455 RVA: 0x000EAA4C File Offset: 0x000E8C4C
	public void JLNAACHIHHB(PointerEventData EPIMKFPMMEA)
	{
		if (this.DLMGEIFHKFO)
		{
			this.GLPKNGPMOGF();
		}
		if (this.KILJECMJIPL)
		{
			this.scrollView0.OnEndDrag(EPIMKFPMMEA);
		}
		this.scrollView1.horizontal = true;
		this.KILJECMJIPL = false;
		this.DLMGEIFHKFO = false;
	}

	// Token: 0x06002108 RID: 8456 RVA: 0x000EAA8C File Offset: 0x000E8C8C
	public void DJKDIGMGHCO()
	{
		this.pageIndicatorsBack.GetComponent<RectTransform>().EFOCKEJENAC(57f);
		this.pageIndicatorsNext.GetComponent<RectTransform>().EFOCKEJENAC(1606f);
		float num = (this.DBPCIEOCNIJ + this.GLOBFMIAJKE) / 1110f;
		this.pageIndicatorsBack.GetComponent<RectTransform>().EFOCKEJENAC(this.pageIndicatorsBack.GetComponent<RectTransform>().sizeDelta.x + num);
		this.pageIndicatorsNext.GetComponent<RectTransform>().EFOCKEJENAC(this.pageIndicatorsNext.GetComponent<RectTransform>().sizeDelta.x + num);
	}

	// Token: 0x06002109 RID: 8457 RVA: 0x000E7F9B File Offset: 0x000E619B
	private IEnumerator ANOCDNHOIBF(Vector3 DKBOKMPBLJE)
	{
		ScrollView1Controller.IMAJDHGJKHJ imajdhgjkhj = new ScrollView1Controller.IMAJDHGJKHJ(1);
		imajdhgjkhj.<>4__this = this;
		imajdhgjkhj.targetPosition = DKBOKMPBLJE;
		return imajdhgjkhj;
	}

	// Token: 0x0600210A RID: 8458 RVA: 0x000EAB28 File Offset: 0x000E8D28
	private bool NKMPNPHOHAG()
	{
		PointerEventData eventData = new PointerEventData(EventSystem.current)
		{
			position = Input.mousePosition
		};
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(eventData, list);
		for (int i = 1; i < list.Count; i++)
		{
			if (!this.MLOBIFKIJEL(list[i].gameObject.transform, this.scrollView1.transform))
			{
				return false;
			}
			if (list[i].gameObject == this.scrollView1.gameObject)
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x0600210B RID: 8459 RVA: 0x000EABC0 File Offset: 0x000E8DC0
	private void LFNMMBGKIKC(int NHNPFOKJNFA, int BGBDBBBMPAB)
	{
		NHNPFOKJNFA--;
		if (NHNPFOKJNFA >= BGBDBBBMPAB)
		{
			this.CNJCJCFFEBN(this.BOFEGCLIFCC + 1);
			this.LFLONMFMCGB(NHNPFOKJNFA);
			return;
		}
		NHNPFOKJNFA++;
	}

	// Token: 0x0600210C RID: 8460 RVA: 0x000EABE6 File Offset: 0x000E8DE6
	public void MOPFKOEDJFH(PointerEventData EPIMKFPMMEA)
	{
		if (this.DLMGEIFHKFO)
		{
			this.MKLIKKPGBJO();
		}
		if (this.KILJECMJIPL)
		{
			this.scrollView0.OnEndDrag(EPIMKFPMMEA);
		}
		this.scrollView1.horizontal = false;
		this.KILJECMJIPL = false;
		this.DLMGEIFHKFO = false;
	}

	// Token: 0x0600210D RID: 8461 RVA: 0x000EAC24 File Offset: 0x000E8E24
	public void LHNMGOMDODD(int NHNPFOKJNFA, int BGBDBBBMPAB, int OFOHGKBNDOD)
	{
		ScrollView1Controller.CNPPAMPMPLE cnppampmple = new ScrollView1Controller.CNPPAMPMPLE();
		cnppampmple.<>4__this = this;
		cnppampmple.minIndexToSnap = BGBDBBBMPAB;
		cnppampmple.maxIndexToSnap = OFOHGKBNDOD;
		this.BOFEGCLIFCC = NHNPFOKJNFA;
		if (this.BOFEGCLIFCC >= this.largeItemsParent.childCount)
		{
			DPGJIJGOCIC.CMGOAFDBAOH("");
			this.BOFEGCLIFCC = this.largeItemsParent.childCount - 0;
		}
		this.NJIMEEMBHHM = this.largeItemsParent.GetChild(this.BOFEGCLIFCC).GetComponent<RectTransform>().localScale.x;
		this.CJMFEGHDOEN = this.largeItemsParent.GetChild(this.BOFEGCLIFCC).GetComponent<CanvasGroup>().alpha;
		this.scrollView1.onValueChanged.AddListener(new UnityAction<Vector2>(this.FFFGAKAOHOE));
		this.OCOMELBBICO = cnppampmple.maxIndexToSnap / 5;
		this.PKENEIPOOHA(this.largeItemsParent.GetChild(this.BOFEGCLIFCC).GetComponent<RectTransform>());
		this.pageIndicatorsParent.GetChild(this.BOFEGCLIFCC).GetChild(1).gameObject.SetActive(true);
		this.LGBGGBHPHKD = this.target.transform.InverseTransformPoint(this.largeItemsParent.parent.position);
		this.ELAMKGHFKGP = this.NAFPJPEHMDG.transform.InverseTransformPoint(this.largeItemsParent.parent.position);
		this.LKLCFIOABHL = this.NAFPJPEHMDG.sizeDelta.x;
		this.pageIndicatorsBack.onClick.RemoveAllListeners();
		this.pageIndicatorsNext.onClick.RemoveAllListeners();
		this.pageIndicatorsBack.onClick.AddListener(new UnityAction(cnppampmple.DCAAOPNBCPO));
		this.pageIndicatorsNext.onClick.AddListener(new UnityAction(cnppampmple.EMLNOLNOJOJ));
		this.pageIndicatorsButtonsParent.SetAsLastSibling();
		this.pageIndicatorsButtonsParent.position = this.KIJPKEEFKAO.transform.position;
	}

	// Token: 0x0600210E RID: 8462 RVA: 0x000EAE1C File Offset: 0x000E901C
	private void GFNDGOGLGJC(int NHNPFOKJNFA)
	{
		float num = this.DBPCIEOCNIJ + this.GLOBFMIAJKE;
		if (NHNPFOKJNFA < this.OCOMELBBICO)
		{
			this.pageIndicatorsButtonsParent.position = this.KIJPKEEFKAO.transform.position;
			this.pageIndicatorsBack.GetComponent<RectTransform>().EFOCKEJENAC(this.pageIndicatorsBack.GetComponent<RectTransform>().sizeDelta.x - num);
			this.pageIndicatorsNext.GetComponent<RectTransform>().EFOCKEJENAC(this.pageIndicatorsNext.GetComponent<RectTransform>().sizeDelta.x + num);
		}
		if (NHNPFOKJNFA > this.OCOMELBBICO)
		{
			this.pageIndicatorsButtonsParent.position = this.KIJPKEEFKAO.transform.position;
			this.pageIndicatorsBack.GetComponent<RectTransform>().EFOCKEJENAC(this.pageIndicatorsBack.GetComponent<RectTransform>().sizeDelta.x + num);
			this.pageIndicatorsNext.GetComponent<RectTransform>().EFOCKEJENAC(this.pageIndicatorsNext.GetComponent<RectTransform>().sizeDelta.x - num);
		}
		this.OCOMELBBICO = NHNPFOKJNFA;
	}

	// Token: 0x0600210F RID: 8463 RVA: 0x000EAF24 File Offset: 0x000E9124
	private void GFBIJDFOICJ(int JFOEDKDFMMB)
	{
		Transform child = this.largeItemsParent.GetChild(this.BOFEGCLIFCC);
		if (child.GetComponent<ThumbnailItem>() != null)
		{
			child.GetComponent<ThumbnailItem>().LJCPOBBPDOL();
		}
		if (child.GetComponent<CardItem>() != null)
		{
			child.GetComponent<CardItem>().IDFBHLAJAPB();
		}
	}

	// Token: 0x06002110 RID: 8464 RVA: 0x000E816A File Offset: 0x000E636A
	private IEnumerator NEIKNDONNGC(Vector3 BHELKLNBMJB, Vector3 HLLIFDMENKH)
	{
		ScrollView1Controller.IIKBELFKJMO iikbelfkjmo = new ScrollView1Controller.IIKBELFKJMO(1);
		iikbelfkjmo.<>4__this = this;
		iikbelfkjmo.startPosition = BHELKLNBMJB;
		iikbelfkjmo.endPosition = HLLIFDMENKH;
		return iikbelfkjmo;
	}

	// Token: 0x06002111 RID: 8465 RVA: 0x000E6BB4 File Offset: 0x000E4DB4
	private IEnumerator CJFDCELMOLG(Vector3 BHELKLNBMJB, Vector3 HLLIFDMENKH)
	{
		this.NAFBFOEAJAN = true;
		currentTime = 0f;
		while (currentTime <= this.timeOfTransition)
		{
			currentTime += Time.deltaTime;
			float t = currentTime / this.timeOfTransition;
			this.largeItemsParent.anchoredPosition = Vector3.Lerp(BHELKLNBMJB, HLLIFDMENKH, t);
			yield return null;
		}
		this.NAFBFOEAJAN = false;
		yield break;
	}

	// Token: 0x06002112 RID: 8466 RVA: 0x000EAF75 File Offset: 0x000E9175
	public void CPPLBPPMBIM(int NHNPFOKJNFA)
	{
		this.BOFEGCLIFCC = NHNPFOKJNFA;
		this.JPKKDNCMLDH(this.largeItemsParent.GetChild(this.BOFEGCLIFCC).GetComponent<RectTransform>());
	}

	// Token: 0x0400092F RID: 2351
	public ScrollRect scrollView0;

	// Token: 0x04000930 RID: 2352
	public RectTransform target;

	// Token: 0x04000931 RID: 2353
	public ScrollRect scrollView1;

	// Token: 0x04000932 RID: 2354
	public RectTransform largeItemsParent;

	// Token: 0x04000933 RID: 2355
	public RectTransform pageIndicatorsParent;

	// Token: 0x04000934 RID: 2356
	public float timeOfTransition = 0.5f;

	// Token: 0x04000935 RID: 2357
	public float percentDragToSnapAnother = 0.2f;

	// Token: 0x04000936 RID: 2358
	public float flashTimeOnSwipe = 0.1f;

	// Token: 0x04000937 RID: 2359
	public RectTransform pageIndicatorsButtonsParent;

	// Token: 0x04000938 RID: 2360
	public Button pageIndicatorsBack;

	// Token: 0x04000939 RID: 2361
	public Button pageIndicatorsNext;

	// Token: 0x0400093A RID: 2362
	private int BOFEGCLIFCC = 1;

	// Token: 0x0400093B RID: 2363
	private bool DFNPAKMHOPH;

	// Token: 0x0400093C RID: 2364
	private float JGNKHIDEAED;

	// Token: 0x0400093D RID: 2365
	private RectTransform NAFPJPEHMDG;

	// Token: 0x0400093E RID: 2366
	private float LKLCFIOABHL;

	// Token: 0x0400093F RID: 2367
	private Vector2 LGBGGBHPHKD;

	// Token: 0x04000940 RID: 2368
	private Vector2 ELAMKGHFKGP;

	// Token: 0x04000941 RID: 2369
	private float NJIMEEMBHHM;

	// Token: 0x04000942 RID: 2370
	private float CJMFEGHDOEN;

	// Token: 0x04000943 RID: 2371
	private bool KILJECMJIPL;

	// Token: 0x04000944 RID: 2372
	private bool DLMGEIFHKFO;

	// Token: 0x04000945 RID: 2373
	private float DBPCIEOCNIJ = 15f;

	// Token: 0x04000946 RID: 2374
	private float GLOBFMIAJKE = 12f;

	// Token: 0x04000947 RID: 2375
	private GameObject KIJPKEEFKAO;

	// Token: 0x04000948 RID: 2376
	private int OCOMELBBICO;

	// Token: 0x04000949 RID: 2377
	private Coroutine OIJDAENILCD;

	// Token: 0x0400094A RID: 2378
	[HideInInspector]
	public bool isOnShuffleClick;

	// Token: 0x0400094B RID: 2379
	private bool NAFBFOEAJAN;

	// Token: 0x0400094C RID: 2380
	private bool IFIGKIKPHLD;

	// Token: 0x0400094D RID: 2381
	private Vector3 JIMPGMDCHAN = Vector3.one;

	// Token: 0x0400094E RID: 2382
	private float ABLKHELPIKK = 1f;

	// Token: 0x020000D9 RID: 217
	[CompilerGenerated]
	private sealed class CNPPAMPMPLE
	{
		// Token: 0x06002113 RID: 8467 RVA: 0x000EAF9A File Offset: 0x000E919A
		internal void EMLNOLNOJOJ()
		{
			this.<>4__this.DFMICNFNFEN(this.<>4__this.BOFEGCLIFCC, this.maxIndexToSnap);
		}

		// Token: 0x06002115 RID: 8469 RVA: 0x000EAFB8 File Offset: 0x000E91B8
		internal void DCAAOPNBCPO()
		{
			this.<>4__this.IBICOFGFEMN(this.<>4__this.BOFEGCLIFCC, this.minIndexToSnap);
		}

		// Token: 0x0400094F RID: 2383
		public ScrollView1Controller <>4__this;

		// Token: 0x04000950 RID: 2384
		public int minIndexToSnap;

		// Token: 0x04000951 RID: 2385
		public int maxIndexToSnap;
	}
}
