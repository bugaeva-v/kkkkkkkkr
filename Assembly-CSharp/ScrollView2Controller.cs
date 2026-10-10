using System;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x02000434 RID: 1076
public class ScrollView2Controller : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
{
	// Token: 0x060082BE RID: 33470 RVA: 0x0039A938 File Offset: 0x00398B38
	public void OnBeginDrag(PointerEventData EPIMKFPMMEA)
	{
		this.LAIPGIECKDL = true;
		Vector3 vector = (EPIMKFPMMEA.position - EPIMKFPMMEA.pressPosition).normalized;
		float num = Mathf.Abs(vector.x);
		float num2 = Mathf.Abs(vector.y);
		if (num > num2)
		{
			this.scrollView0.velocity = Vector2.zero;
			this.scrollView2.horizontal = true;
			this.scrollView2.movementType = ScrollRect.MovementType.Elastic;
			return;
		}
		this.KILJECMJIPL = true;
		this.scrollView2.velocity = Vector2.zero;
		this.scrollView2.horizontal = false;
		this.scrollView0.OnBeginDrag(EPIMKFPMMEA);
	}

	// Token: 0x060082BF RID: 33471 RVA: 0x0039A9E0 File Offset: 0x00398BE0
	public void LLEPHDHEMHP(PointerEventData EPIMKFPMMEA)
	{
		this.LAIPGIECKDL = false;
		Vector3 vector = (EPIMKFPMMEA.position - EPIMKFPMMEA.pressPosition).normalized;
		float num = Mathf.Abs(vector.x);
		float num2 = Mathf.Abs(vector.y);
		if (num > num2)
		{
			this.scrollView0.velocity = Vector2.zero;
			this.scrollView2.horizontal = false;
			this.scrollView2.movementType = ScrollRect.MovementType.Unrestricted;
			return;
		}
		this.KILJECMJIPL = false;
		this.scrollView2.velocity = Vector2.zero;
		this.scrollView2.horizontal = false;
		this.scrollView0.OnBeginDrag(EPIMKFPMMEA);
	}

	// Token: 0x060082C0 RID: 33472 RVA: 0x0039AA88 File Offset: 0x00398C88
	public void SetItemOnCenter(Transform BAMGIPAINNF, bool GHPDJJCLHGM)
	{
		base.StopCoroutine("OFOBPMFKCNN");
		base.StopCoroutine("JFNHCLBJOCH");
		base.StopCoroutine("FilterAnimationScrollMoveSmooth");
		if (!GHPDJJCLHGM)
		{
			base.StartCoroutine(this.JFNHCLBJOCH());
		}
		Vector3 vector = this.filterItemsParent.anchoredPosition;
		Vector3 hllifdmenkh = this.scrollView2.transform.InverseTransformPoint(this.filterItemsParent.position) - this.scrollView2.transform.InverseTransformPoint(BAMGIPAINNF.position);
		hllifdmenkh.y = vector.y;
		this.LAIPGIECKDL = true;
		base.StartCoroutine(this.OFOBPMFKCNN(vector, hllifdmenkh, this.timeOfFiltersTransition));
	}

	// Token: 0x060082C1 RID: 33473 RVA: 0x0039AB46 File Offset: 0x00398D46
	private IEnumerator OPIMAPLBAOL()
	{
		ScrollView2Controller.NBEMHMLHOKM nbemhmlhokm = new ScrollView2Controller.NBEMHMLHOKM(1);
		nbemhmlhokm.<>4__this = this;
		return nbemhmlhokm;
	}

	// Token: 0x060082C2 RID: 33474 RVA: 0x0039AB55 File Offset: 0x00398D55
	public void AILFLGDHMEO(PointerEventData EPIMKFPMMEA)
	{
		this.LAIPGIECKDL = false;
		if (this.KILJECMJIPL)
		{
			this.scrollView0.OnEndDrag(EPIMKFPMMEA);
		}
		this.scrollView2.horizontal = false;
		this.KILJECMJIPL = false;
		this.scrollView2.movementType = ScrollRect.MovementType.Clamped;
	}

	// Token: 0x060082C3 RID: 33475 RVA: 0x0039AB91 File Offset: 0x00398D91
	public void JKBFBANPIMO(PointerEventData EPIMKFPMMEA)
	{
		this.LAIPGIECKDL = true;
		if (this.KILJECMJIPL)
		{
			this.scrollView0.OnDrag(EPIMKFPMMEA);
		}
	}

	// Token: 0x060082C4 RID: 33476 RVA: 0x0039ABAE File Offset: 0x00398DAE
	public void OKBIDFLKHKK(PointerEventData EPIMKFPMMEA)
	{
		this.LAIPGIECKDL = false;
		if (this.KILJECMJIPL)
		{
			this.scrollView0.OnEndDrag(EPIMKFPMMEA);
		}
		this.scrollView2.horizontal = true;
		this.KILJECMJIPL = true;
		this.scrollView2.movementType = ScrollRect.MovementType.Elastic;
	}

	// Token: 0x060082C5 RID: 33477 RVA: 0x0039ABEA File Offset: 0x00398DEA
	public void StartFiltersAnimation()
	{
		this.OGHBEJEAOJM = bool.Parse(PlayerPrefs.GetString("filtersAnimation", "true"));
		PlayerPrefs.SetString("filtersAnimation", "false");
	}

	// Token: 0x060082C6 RID: 33478 RVA: 0x0039AC18 File Offset: 0x00398E18
	private void NFFGMDALKCE()
	{
		if (this.OGHBEJEAOJM)
		{
			this.OGHBEJEAOJM = false;
			if (PlayerPrefs.GetString("yes") == JBBNEEHANHL.filterNew.ToString() || ((JBBNEEHANHL)104).ToString() == PlayerPrefs.GetString("afs"))
			{
				this.LAIPGIECKDL = false;
				Vector3 bhelklnbmjb = this.filterItemsParent.anchoredPosition;
				Vector3 hllifdmenkh = new Vector2(this.filterItemsParent.anchoredPosition.x - (float)this.shakeDistance, this.filterItemsParent.anchoredPosition.y);
				base.StartCoroutine(this.KNPMADHJGDM(bhelklnbmjb, hllifdmenkh, this.shakeSpeed));
			}
		}
	}

	// Token: 0x060082C7 RID: 33479 RVA: 0x0039AB91 File Offset: 0x00398D91
	public void FBOJPJJMEEL(PointerEventData EPIMKFPMMEA)
	{
		this.LAIPGIECKDL = true;
		if (this.KILJECMJIPL)
		{
			this.scrollView0.OnDrag(EPIMKFPMMEA);
		}
	}

	// Token: 0x060082C8 RID: 33480 RVA: 0x0039ACD8 File Offset: 0x00398ED8
	private void NAJNKMAHMMI()
	{
		PlayerPrefs.SetString("p", "OnApplicationRestart");
	}

	// Token: 0x060082C9 RID: 33481 RVA: 0x0039ACE9 File Offset: 0x00398EE9
	public void FEHCLJIOAOK(PointerEventData EPIMKFPMMEA)
	{
		this.LAIPGIECKDL = false;
		if (this.KILJECMJIPL)
		{
			this.scrollView0.OnDrag(EPIMKFPMMEA);
		}
	}

	// Token: 0x060082CA RID: 33482 RVA: 0x0039AD08 File Offset: 0x00398F08
	private void Update()
	{
		if (this.OGHBEJEAOJM)
		{
			this.OGHBEJEAOJM = false;
			if (PlayerPrefs.GetString("lastFilter") == JBBNEEHANHL.filterNew.ToString() || JBBNEEHANHL.filterStarter.ToString() == PlayerPrefs.GetString("lastFilter"))
			{
				this.LAIPGIECKDL = false;
				Vector3 bhelklnbmjb = this.filterItemsParent.anchoredPosition;
				Vector3 hllifdmenkh = new Vector2(this.filterItemsParent.anchoredPosition.x - (float)this.shakeDistance, this.filterItemsParent.anchoredPosition.y);
				base.StartCoroutine(this.HFIJPPEFEIB(bhelklnbmjb, hllifdmenkh, this.shakeSpeed));
			}
		}
	}

	// Token: 0x060082CB RID: 33483 RVA: 0x0039ADC8 File Offset: 0x00398FC8
	public void EAAEMCBDOHD()
	{
		this.OGHBEJEAOJM = bool.Parse(PlayerPrefs.GetString("OnFriendPlusUpgradeClick", "common"));
		PlayerPrefs.SetString("%", "StoryChatManager.Initialize(), _chatMeta is null");
	}

	// Token: 0x060082CC RID: 33484 RVA: 0x0039ACE9 File Offset: 0x00398EE9
	public void HLBOJGCFOBN(PointerEventData EPIMKFPMMEA)
	{
		this.LAIPGIECKDL = false;
		if (this.KILJECMJIPL)
		{
			this.scrollView0.OnDrag(EPIMKFPMMEA);
		}
	}

	// Token: 0x060082CD RID: 33485 RVA: 0x0039ADF4 File Offset: 0x00398FF4
	private void MJBIDAKAFEN()
	{
		if (this.OGHBEJEAOJM)
		{
			this.OGHBEJEAOJM = true;
			if (PlayerPrefs.GetString(";") == JBBNEEHANHL.newFilterSupernatural.ToString() || ((JBBNEEHANHL)(-116)).ToString() == PlayerPrefs.GetString("msUntilExpireAuto"))
			{
				this.LAIPGIECKDL = false;
				Vector3 bhelklnbmjb = this.filterItemsParent.anchoredPosition;
				Vector3 hllifdmenkh = new Vector2(this.filterItemsParent.anchoredPosition.x - (float)this.shakeDistance, this.filterItemsParent.anchoredPosition.y);
				base.StartCoroutine(this.HFIJPPEFEIB(bhelklnbmjb, hllifdmenkh, this.shakeSpeed));
			}
		}
	}

	// Token: 0x060082CE RID: 33486 RVA: 0x0039AEB4 File Offset: 0x003990B4
	public void GFFAJPIGOHG(Transform BAMGIPAINNF, bool GHPDJJCLHGM)
	{
		base.StopCoroutine("chapterrewindhint0");
		base.StopCoroutine("_Strength");
		base.StopCoroutine("");
		if (!GHPDJJCLHGM)
		{
			base.StartCoroutine(this.JFNHCLBJOCH());
		}
		Vector3 vector = this.filterItemsParent.anchoredPosition;
		Vector3 hllifdmenkh = this.scrollView2.transform.InverseTransformPoint(this.filterItemsParent.position) - this.scrollView2.transform.InverseTransformPoint(BAMGIPAINNF.position);
		hllifdmenkh.y = vector.y;
		this.LAIPGIECKDL = false;
		base.StartCoroutine(this.ODKGJFLDGGE(vector, hllifdmenkh, this.timeOfFiltersTransition));
	}

	// Token: 0x060082CF RID: 33487 RVA: 0x0039AF72 File Offset: 0x00399172
	public void AOGCNEDJEBI()
	{
		this.OGHBEJEAOJM = bool.Parse(PlayerPrefs.GetString("…", "============== USING PRODUCTION DB SERVER ==============="));
		PlayerPrefs.SetString("onThemeChange", "yes");
	}

	// Token: 0x060082D0 RID: 33488 RVA: 0x0039AF9D File Offset: 0x0039919D
	private IEnumerator MPDBHMBOBAH(Vector3 BHELKLNBMJB, Vector3 HLLIFDMENKH, float KLGHLMMKJJC)
	{
		yield return new WaitForEndOfFrame();
		float currentTime = 0f;
		while (currentTime <= KLGHLMMKJJC)
		{
			currentTime += Time.deltaTime;
			float t = currentTime / KLGHLMMKJJC;
			this.filterItemsParent.anchoredPosition = Vector3.Lerp(BHELKLNBMJB, HLLIFDMENKH, t);
			yield return null;
		}
		yield break;
	}

	// Token: 0x060082D1 RID: 33489 RVA: 0x0039AFC4 File Offset: 0x003991C4
	public void PFAPIFJIDFA(Transform BAMGIPAINNF, bool GHPDJJCLHGM)
	{
		base.StopCoroutine("");
		base.StopCoroutine("ant");
		base.StopCoroutine("p");
		if (!GHPDJJCLHGM)
		{
			base.StartCoroutine(this.PGPKJOBNAFH());
		}
		Vector3 vector = this.filterItemsParent.anchoredPosition;
		Vector3 hllifdmenkh = this.scrollView2.transform.InverseTransformPoint(this.filterItemsParent.position) - this.scrollView2.transform.InverseTransformPoint(BAMGIPAINNF.position);
		hllifdmenkh.y = vector.y;
		this.LAIPGIECKDL = true;
		base.StartCoroutine(this.ODKGJFLDGGE(vector, hllifdmenkh, this.timeOfFiltersTransition));
	}

	// Token: 0x060082D2 RID: 33490 RVA: 0x0039B084 File Offset: 0x00399284
	public void JHAABKGFEDC(Transform BAMGIPAINNF, bool GHPDJJCLHGM)
	{
		base.StopCoroutine("socialJoinRequest");
		base.StopCoroutine("rand");
		base.StopCoroutine(" ");
		if (!GHPDJJCLHGM)
		{
			base.StartCoroutine(this.OPIMAPLBAOL());
		}
		Vector3 vector = this.filterItemsParent.anchoredPosition;
		Vector3 hllifdmenkh = this.scrollView2.transform.InverseTransformPoint(this.filterItemsParent.position) - this.scrollView2.transform.InverseTransformPoint(BAMGIPAINNF.position);
		hllifdmenkh.y = vector.y;
		this.LAIPGIECKDL = false;
		base.StartCoroutine(this.EOKHKBNMLBN(vector, hllifdmenkh, this.timeOfFiltersTransition));
	}

	// Token: 0x060082D3 RID: 33491 RVA: 0x0039ACE9 File Offset: 0x00398EE9
	public void AGFHHEEGHBN(PointerEventData EPIMKFPMMEA)
	{
		this.LAIPGIECKDL = false;
		if (this.KILJECMJIPL)
		{
			this.scrollView0.OnDrag(EPIMKFPMMEA);
		}
	}

	// Token: 0x060082D4 RID: 33492 RVA: 0x0039B142 File Offset: 0x00399342
	private void MNMBFHCBJEO()
	{
		PlayerPrefs.SetString("profilenamelevellong", "");
	}

	// Token: 0x060082D5 RID: 33493 RVA: 0x0039AB46 File Offset: 0x00398D46
	private IEnumerator HOMHMPIMFCJ()
	{
		ScrollView2Controller.NBEMHMLHOKM nbemhmlhokm = new ScrollView2Controller.NBEMHMLHOKM(1);
		nbemhmlhokm.<>4__this = this;
		return nbemhmlhokm;
	}

	// Token: 0x060082D6 RID: 33494 RVA: 0x0039B153 File Offset: 0x00399353
	private void OLGCHEOIOGM()
	{
		PlayerPrefs.SetString("OnFriendsPopupSendMessageClick", "$SETPOV");
	}

	// Token: 0x060082D7 RID: 33495 RVA: 0x0039AF9D File Offset: 0x0039919D
	private IEnumerator ODKGJFLDGGE(Vector3 BHELKLNBMJB, Vector3 HLLIFDMENKH, float KLGHLMMKJJC)
	{
		yield return new WaitForEndOfFrame();
		currentTime = 0f;
		while (currentTime <= KLGHLMMKJJC)
		{
			currentTime += Time.deltaTime;
			float t = currentTime / KLGHLMMKJJC;
			this.filterItemsParent.anchoredPosition = Vector3.Lerp(BHELKLNBMJB, HLLIFDMENKH, t);
			yield return null;
		}
		yield break;
	}

	// Token: 0x060082D8 RID: 33496 RVA: 0x0039B164 File Offset: 0x00399364
	public void KMBCHAPBDAA()
	{
		this.OGHBEJEAOJM = bool.Parse(PlayerPrefs.GetString("{0} is not a valid asset bundle.", "discount"));
		PlayerPrefs.SetString("friendsmaxlimitdefault", ".");
	}

	// Token: 0x060082D9 RID: 33497 RVA: 0x0039B18F File Offset: 0x0039938F
	private void LOMIBNKDJBL()
	{
		PlayerPrefs.SetString("〉", "<alpha=#C0>");
	}

	// Token: 0x060082DA RID: 33498 RVA: 0x0039B1A0 File Offset: 0x003993A0
	public void SetItemOnCenterImmediate(Transform BAMGIPAINNF)
	{
		base.StopCoroutine("OFOBPMFKCNN");
		base.StopCoroutine("JFNHCLBJOCH");
		base.StopCoroutine("FilterAnimationScrollMoveSmooth");
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.filterItemsParent);
		Vector3 vector = this.filterItemsParent.anchoredPosition;
		Vector3 v = this.scrollView2.transform.InverseTransformPoint(this.filterItemsParent.position) - this.scrollView2.transform.InverseTransformPoint(BAMGIPAINNF.position);
		v.y = vector.y;
		this.LAIPGIECKDL = true;
		this.scrollView2.velocity = Vector2.zero;
		this.filterItemsParent.anchoredPosition = v;
		this.scrollView2.horizontalNormalizedPosition = Mathf.Clamp01(this.scrollView2.horizontalNormalizedPosition);
	}

	// Token: 0x060082DB RID: 33499 RVA: 0x0039AB91 File Offset: 0x00398D91
	public void OnDrag(PointerEventData EPIMKFPMMEA)
	{
		this.LAIPGIECKDL = true;
		if (this.KILJECMJIPL)
		{
			this.scrollView0.OnDrag(EPIMKFPMMEA);
		}
	}

	// Token: 0x060082DC RID: 33500 RVA: 0x0039AB46 File Offset: 0x00398D46
	private IEnumerator PGPKJOBNAFH()
	{
		ScrollView2Controller.NBEMHMLHOKM nbemhmlhokm = new ScrollView2Controller.NBEMHMLHOKM(1);
		nbemhmlhokm.<>4__this = this;
		return nbemhmlhokm;
	}

	// Token: 0x060082DE RID: 33502 RVA: 0x0039B2D0 File Offset: 0x003994D0
	public void PMCDDHKLHCD(PointerEventData EPIMKFPMMEA)
	{
		this.LAIPGIECKDL = true;
		Vector3 vector = (EPIMKFPMMEA.position - EPIMKFPMMEA.pressPosition).normalized;
		float num = Mathf.Abs(vector.x);
		float num2 = Mathf.Abs(vector.y);
		if (num > num2)
		{
			this.scrollView0.velocity = Vector2.zero;
			this.scrollView2.horizontal = false;
			this.scrollView2.movementType = ScrollRect.MovementType.Elastic;
			return;
		}
		this.KILJECMJIPL = false;
		this.scrollView2.velocity = Vector2.zero;
		this.scrollView2.horizontal = true;
		this.scrollView0.OnBeginDrag(EPIMKFPMMEA);
	}

	// Token: 0x060082DF RID: 33503 RVA: 0x0039AB91 File Offset: 0x00398D91
	public void PMCKPNGLPCL(PointerEventData EPIMKFPMMEA)
	{
		this.LAIPGIECKDL = true;
		if (this.KILJECMJIPL)
		{
			this.scrollView0.OnDrag(EPIMKFPMMEA);
		}
	}

	// Token: 0x060082E0 RID: 33504 RVA: 0x0039B375 File Offset: 0x00399575
	public void NNCOCNAKIKJ(PointerEventData EPIMKFPMMEA)
	{
		this.LAIPGIECKDL = true;
		if (this.KILJECMJIPL)
		{
			this.scrollView0.OnEndDrag(EPIMKFPMMEA);
		}
		this.scrollView2.horizontal = true;
		this.KILJECMJIPL = true;
		this.scrollView2.movementType = ScrollRect.MovementType.Clamped;
	}

	// Token: 0x060082E1 RID: 33505 RVA: 0x0039B3B4 File Offset: 0x003995B4
	public void GOJJEEIILJN(Transform BAMGIPAINNF, bool GHPDJJCLHGM)
	{
		base.StopCoroutine("");
		base.StopCoroutine("socialJoinRequest");
		base.StopCoroutine("nick");
		if (!GHPDJJCLHGM)
		{
			base.StartCoroutine(this.HOMHMPIMFCJ());
		}
		Vector3 vector = this.filterItemsParent.anchoredPosition;
		Vector3 hllifdmenkh = this.scrollView2.transform.InverseTransformPoint(this.filterItemsParent.position) - this.scrollView2.transform.InverseTransformPoint(BAMGIPAINNF.position);
		hllifdmenkh.y = vector.y;
		this.LAIPGIECKDL = false;
		base.StartCoroutine(this.ODKGJFLDGGE(vector, hllifdmenkh, this.timeOfFiltersTransition));
	}

	// Token: 0x060082E2 RID: 33506 RVA: 0x0039B472 File Offset: 0x00399672
	private IEnumerator EOKHKBNMLBN(Vector3 BHELKLNBMJB, Vector3 HLLIFDMENKH, float KLGHLMMKJJC)
	{
		ScrollView2Controller.GNOBAIEDNFN gnobaiednfn = new ScrollView2Controller.GNOBAIEDNFN(1);
		gnobaiednfn.<>4__this = this;
		gnobaiednfn.startPosition = BHELKLNBMJB;
		gnobaiednfn.endPosition = HLLIFDMENKH;
		gnobaiednfn.transitionTime = KLGHLMMKJJC;
		return gnobaiednfn;
	}

	// Token: 0x060082E3 RID: 33507 RVA: 0x0039B498 File Offset: 0x00399698
	public void PAIFHIEHLNN(Transform BAMGIPAINNF)
	{
		base.StopCoroutine(" is OUTSIDE the anthology's story family - not queued (clip:");
		base.StopCoroutine("KKK");
		base.StopCoroutine("sid");
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.filterItemsParent);
		Vector3 vector = this.filterItemsParent.anchoredPosition;
		Vector3 v = this.scrollView2.transform.InverseTransformPoint(this.filterItemsParent.position) - this.scrollView2.transform.InverseTransformPoint(BAMGIPAINNF.position);
		v.y = vector.y;
		this.LAIPGIECKDL = false;
		this.scrollView2.velocity = Vector2.zero;
		this.filterItemsParent.anchoredPosition = v;
		this.scrollView2.horizontalNormalizedPosition = Mathf.Clamp01(this.scrollView2.horizontalNormalizedPosition);
	}

	// Token: 0x060082E4 RID: 33508 RVA: 0x0039B578 File Offset: 0x00399778
	private void ODCKJNCEGAH()
	{
		if (this.OGHBEJEAOJM)
		{
			this.OGHBEJEAOJM = true;
			if (PlayerPrefs.GetString("$TAKEAVATARSNAPSHOT") == JBBNEEHANHL.newFilterSupernatural.ToString() || ((JBBNEEHANHL)54).ToString() == PlayerPrefs.GetString("strtd"))
			{
				this.LAIPGIECKDL = true;
				Vector3 bhelklnbmjb = this.filterItemsParent.anchoredPosition;
				Vector3 hllifdmenkh = new Vector2(this.filterItemsParent.anchoredPosition.x - (float)this.shakeDistance, this.filterItemsParent.anchoredPosition.y);
				base.StartCoroutine(this.KNPMADHJGDM(bhelklnbmjb, hllifdmenkh, this.shakeSpeed));
			}
		}
	}

	// Token: 0x060082E5 RID: 33509 RVA: 0x0039B638 File Offset: 0x00399838
	public void MKEDDKIGDKL(Transform BAMGIPAINNF)
	{
		base.StopCoroutine("Loaded asset bundle:");
		base.StopCoroutine("def");
		base.StopCoroutine("hintprocessing");
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.filterItemsParent);
		Vector3 vector = this.filterItemsParent.anchoredPosition;
		Vector3 v = this.scrollView2.transform.InverseTransformPoint(this.filterItemsParent.position) - this.scrollView2.transform.InverseTransformPoint(BAMGIPAINNF.position);
		v.y = vector.y;
		this.LAIPGIECKDL = false;
		this.scrollView2.velocity = Vector2.zero;
		this.filterItemsParent.anchoredPosition = v;
		this.scrollView2.horizontalNormalizedPosition = Mathf.Clamp01(this.scrollView2.horizontalNormalizedPosition);
	}

	// Token: 0x060082E6 RID: 33510 RVA: 0x0039B472 File Offset: 0x00399672
	private IEnumerator HGALBLKJPEI(Vector3 BHELKLNBMJB, Vector3 HLLIFDMENKH, float KLGHLMMKJJC)
	{
		ScrollView2Controller.GNOBAIEDNFN gnobaiednfn = new ScrollView2Controller.GNOBAIEDNFN(1);
		gnobaiednfn.<>4__this = this;
		gnobaiednfn.startPosition = BHELKLNBMJB;
		gnobaiednfn.endPosition = HLLIFDMENKH;
		gnobaiednfn.transitionTime = KLGHLMMKJJC;
		return gnobaiednfn;
	}

	// Token: 0x060082E7 RID: 33511 RVA: 0x0039B718 File Offset: 0x00399918
	private void OnApplicationQuit()
	{
		PlayerPrefs.SetString("filtersAnimation", "true");
	}

	// Token: 0x060082E8 RID: 33512 RVA: 0x0039B729 File Offset: 0x00399929
	public void HDONNFIHOKC(PointerEventData EPIMKFPMMEA)
	{
		this.LAIPGIECKDL = false;
		if (this.KILJECMJIPL)
		{
			this.scrollView0.OnEndDrag(EPIMKFPMMEA);
		}
		this.scrollView2.horizontal = true;
		this.KILJECMJIPL = true;
		this.scrollView2.movementType = (ScrollRect.MovementType)4;
	}

	// Token: 0x060082E9 RID: 33513 RVA: 0x0039B768 File Offset: 0x00399968
	public void NMHHDHDNPIM(PointerEventData EPIMKFPMMEA)
	{
		this.LAIPGIECKDL = false;
		Vector3 vector = (EPIMKFPMMEA.position - EPIMKFPMMEA.pressPosition).normalized;
		float num = Mathf.Abs(vector.x);
		float num2 = Mathf.Abs(vector.y);
		if (num > num2)
		{
			this.scrollView0.velocity = Vector2.zero;
			this.scrollView2.horizontal = false;
			this.scrollView2.movementType = ScrollRect.MovementType.Unrestricted;
			return;
		}
		this.KILJECMJIPL = false;
		this.scrollView2.velocity = Vector2.zero;
		this.scrollView2.horizontal = false;
		this.scrollView0.OnBeginDrag(EPIMKFPMMEA);
	}

	// Token: 0x060082EA RID: 33514 RVA: 0x0039AF9D File Offset: 0x0039919D
	private IEnumerator OFOBPMFKCNN(Vector3 BHELKLNBMJB, Vector3 HLLIFDMENKH, float KLGHLMMKJJC)
	{
		yield return new WaitForEndOfFrame();
		currentTime = 0f;
		while (currentTime <= KLGHLMMKJJC)
		{
			currentTime += Time.deltaTime;
			float t = currentTime / KLGHLMMKJJC;
			this.filterItemsParent.anchoredPosition = Vector3.Lerp(BHELKLNBMJB, HLLIFDMENKH, t);
			yield return null;
		}
		yield break;
	}

	// Token: 0x060082EB RID: 33515 RVA: 0x0039B810 File Offset: 0x00399A10
	public void DLAKLPBJDMO(Transform BAMGIPAINNF)
	{
		base.StopCoroutine("oldvhs");
		base.StopCoroutine("sltind");
		base.StopCoroutine("assetbundlestory");
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.filterItemsParent);
		Vector3 vector = this.filterItemsParent.anchoredPosition;
		Vector3 v = this.scrollView2.transform.InverseTransformPoint(this.filterItemsParent.position) - this.scrollView2.transform.InverseTransformPoint(BAMGIPAINNF.position);
		v.y = vector.y;
		this.LAIPGIECKDL = false;
		this.scrollView2.velocity = Vector2.zero;
		this.filterItemsParent.anchoredPosition = v;
		this.scrollView2.horizontalNormalizedPosition = Mathf.Clamp01(this.scrollView2.horizontalNormalizedPosition);
	}

	// Token: 0x060082EC RID: 33516 RVA: 0x0039B8F0 File Offset: 0x00399AF0
	public void CJCNPBAEDFN(PointerEventData EPIMKFPMMEA)
	{
		this.LAIPGIECKDL = false;
		if (this.KILJECMJIPL)
		{
			this.scrollView0.OnEndDrag(EPIMKFPMMEA);
		}
		this.scrollView2.horizontal = true;
		this.KILJECMJIPL = false;
		this.scrollView2.movementType = (ScrollRect.MovementType)4;
	}

	// Token: 0x060082ED RID: 33517 RVA: 0x0039B92C File Offset: 0x00399B2C
	public void LNBBPHAKGOM(PointerEventData EPIMKFPMMEA)
	{
		this.LAIPGIECKDL = true;
		Vector3 vector = (EPIMKFPMMEA.position - EPIMKFPMMEA.pressPosition).normalized;
		float num = Mathf.Abs(vector.x);
		float num2 = Mathf.Abs(vector.y);
		if (num > num2)
		{
			this.scrollView0.velocity = Vector2.zero;
			this.scrollView2.horizontal = true;
			this.scrollView2.movementType = ScrollRect.MovementType.Unrestricted;
			return;
		}
		this.KILJECMJIPL = false;
		this.scrollView2.velocity = Vector2.zero;
		this.scrollView2.horizontal = false;
		this.scrollView0.OnBeginDrag(EPIMKFPMMEA);
	}

	// Token: 0x060082EE RID: 33518 RVA: 0x0039B9D1 File Offset: 0x00399BD1
	private IEnumerator KNPMADHJGDM(Vector3 BHELKLNBMJB, Vector3 HLLIFDMENKH, float ANGEKMILGLF)
	{
		ScrollView2Controller.MDMLPOKHEAA mdmlpokheaa = new ScrollView2Controller.MDMLPOKHEAA(1);
		mdmlpokheaa.<>4__this = this;
		mdmlpokheaa.startPosition = BHELKLNBMJB;
		mdmlpokheaa.endPosition = HLLIFDMENKH;
		mdmlpokheaa.speed = ANGEKMILGLF;
		return mdmlpokheaa;
	}

	// Token: 0x060082EF RID: 33519 RVA: 0x0039B9F5 File Offset: 0x00399BF5
	public void OnEndDrag(PointerEventData EPIMKFPMMEA)
	{
		this.LAIPGIECKDL = true;
		if (this.KILJECMJIPL)
		{
			this.scrollView0.OnEndDrag(EPIMKFPMMEA);
		}
		this.scrollView2.horizontal = true;
		this.KILJECMJIPL = false;
		this.scrollView2.movementType = ScrollRect.MovementType.Clamped;
	}

	// Token: 0x060082F0 RID: 33520 RVA: 0x0039BA31 File Offset: 0x00399C31
	public void HCKKFLFKAKB(PointerEventData EPIMKFPMMEA)
	{
		this.LAIPGIECKDL = true;
		if (this.KILJECMJIPL)
		{
			this.scrollView0.OnEndDrag(EPIMKFPMMEA);
		}
		this.scrollView2.horizontal = true;
		this.KILJECMJIPL = false;
		this.scrollView2.movementType = (ScrollRect.MovementType)4;
	}

	// Token: 0x060082F1 RID: 33521 RVA: 0x0039AB91 File Offset: 0x00398D91
	public void LDFBAHECCCH(PointerEventData EPIMKFPMMEA)
	{
		this.LAIPGIECKDL = true;
		if (this.KILJECMJIPL)
		{
			this.scrollView0.OnDrag(EPIMKFPMMEA);
		}
	}

	// Token: 0x060082F2 RID: 33522 RVA: 0x0039BA6D File Offset: 0x00399C6D
	private void IDNIMMANONC()
	{
		PlayerPrefs.SetString("@", "$STOPSFX");
	}

	// Token: 0x060082F3 RID: 33523 RVA: 0x0039BA7E File Offset: 0x00399C7E
	private void CCEAFBHKFMM()
	{
		PlayerPrefs.SetString("OnFriendsPopupSendSimpleClick", "PurchaseManagerUnity.InvalidateUnityStoreController()");
	}

	// Token: 0x060082F4 RID: 33524 RVA: 0x0039BA8F File Offset: 0x00399C8F
	public void INHBHBOMKEB()
	{
		this.OGHBEJEAOJM = bool.Parse(PlayerPrefs.GetString(", already present in top match list. But modifying the locked love interest condition to true.", "$USEDELAYV2"));
		PlayerPrefs.SetString("congratstitle", "");
	}

	// Token: 0x060082F5 RID: 33525 RVA: 0x0039BABA File Offset: 0x00399CBA
	private IEnumerator JFNHCLBJOCH()
	{
		yield return new WaitForEndOfFrame();
		float y = this.pageIndicatorContent.sizeDelta.y;
		float y2 = this.scrollView2.GetComponent<RectTransform>().sizeDelta.y;
		float num = y + y2;
		if (null != this.extraFixedContent && this.extraFixedContent.gameObject.activeInHierarchy)
		{
			num += this.extraFixedContent.sizeDelta.y;
		}
		Transform child = this.scrollView0Content.GetChild(this.scrollView0Content.childCount - 1);
		if (null == child.GetComponent<GridController>())
		{
			yield break;
		}
		if (child.childCount == 0)
		{
			yield break;
		}
		float y3 = child.GetChild(0).GetComponent<RectTransform>().sizeDelta.y;
		if (null == child.GetChild(0).GetComponent<ThumbnailItem>())
		{
			ThumbnailItem componentInChildren = child.GetComponentInChildren<ThumbnailItem>(true);
			if (null != componentInChildren)
			{
				y3 = componentInChildren.GetComponent<RectTransform>().sizeDelta.y;
			}
		}
		this.MHGNFDFLMJG = y3 - num;
		Vector3 startPosition = this.scrollView0Content.anchoredPosition;
		Vector3 endPosition = new Vector2(this.scrollView0Content.anchoredPosition.x, this.MHGNFDFLMJG);
		float currentTime = 0f;
		if (startPosition.y < this.MHGNFDFLMJG * this.minPercentsOfVisibleSmallItem)
		{
			while (currentTime <= this.timeOfSmallItemsTransition)
			{
				currentTime += Time.deltaTime;
				float t = currentTime / this.timeOfSmallItemsTransition;
				this.scrollView0Content.anchoredPosition = Vector3.Lerp(startPosition, endPosition, t);
				yield return null;
			}
		}
		yield break;
	}

	// Token: 0x060082F6 RID: 33526 RVA: 0x0039BAC9 File Offset: 0x00399CC9
	private IEnumerator HFIJPPEFEIB(Vector3 BHELKLNBMJB, Vector3 HLLIFDMENKH, float ANGEKMILGLF)
	{
		float currentTime = 0f;
		float transitionTime = Mathf.Abs(HLLIFDMENKH.x - BHELKLNBMJB.x) / ANGEKMILGLF;
		int num;
		for (int i = 0; i < this.shakeTimes; i = num + 1)
		{
			if (i % 2 == 0)
			{
				currentTime = 0f;
				while (currentTime <= transitionTime)
				{
					if (this.LAIPGIECKDL)
					{
						yield break;
					}
					currentTime += Time.deltaTime;
					float t = currentTime / transitionTime;
					this.filterItemsParent.anchoredPosition = Vector3.Lerp(BHELKLNBMJB, HLLIFDMENKH, t);
					yield return null;
				}
			}
			else
			{
				currentTime = 0f;
				while (currentTime <= transitionTime)
				{
					if (this.LAIPGIECKDL)
					{
						yield break;
					}
					currentTime += Time.deltaTime;
					float t = currentTime / transitionTime;
					this.filterItemsParent.anchoredPosition = Vector3.Lerp(HLLIFDMENKH, BHELKLNBMJB, t);
					yield return null;
				}
			}
			num = i;
		}
		yield break;
	}

	// Token: 0x060082F7 RID: 33527 RVA: 0x0039BAF0 File Offset: 0x00399CF0
	public void EIPJJBCMAKK(Transform BAMGIPAINNF)
	{
		base.StopCoroutine("PurchaseManagerXiaomi.OnBackendValidateTransactionException().");
		base.StopCoroutine("liveeventcontent");
		base.StopCoroutine("continue");
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.filterItemsParent);
		Vector3 vector = this.filterItemsParent.anchoredPosition;
		Vector3 v = this.scrollView2.transform.InverseTransformPoint(this.filterItemsParent.position) - this.scrollView2.transform.InverseTransformPoint(BAMGIPAINNF.position);
		v.y = vector.y;
		this.LAIPGIECKDL = false;
		this.scrollView2.velocity = Vector2.zero;
		this.filterItemsParent.anchoredPosition = v;
		this.scrollView2.horizontalNormalizedPosition = Mathf.Clamp01(this.scrollView2.horizontalNormalizedPosition);
	}

	// Token: 0x060082F8 RID: 33528 RVA: 0x0039BBD0 File Offset: 0x00399DD0
	private void KGJJLDJBEON()
	{
		if (this.OGHBEJEAOJM)
		{
			this.OGHBEJEAOJM = false;
			if (PlayerPrefs.GetString("assetbundlestory") == JBBNEEHANHL.newFilterSupernatural.ToString() || ((JBBNEEHANHL)37).ToString() == PlayerPrefs.GetString("socialjoinbody"))
			{
				this.LAIPGIECKDL = true;
				Vector3 bhelklnbmjb = this.filterItemsParent.anchoredPosition;
				Vector3 hllifdmenkh = new Vector2(this.filterItemsParent.anchoredPosition.x - (float)this.shakeDistance, this.filterItemsParent.anchoredPosition.y);
				base.StartCoroutine(this.HFIJPPEFEIB(bhelklnbmjb, hllifdmenkh, this.shakeSpeed));
			}
		}
	}

	// Token: 0x060082F9 RID: 33529 RVA: 0x0039BC90 File Offset: 0x00399E90
	public void DIDJHEAAOHJ(PointerEventData EPIMKFPMMEA)
	{
		this.LAIPGIECKDL = false;
		if (this.KILJECMJIPL)
		{
			this.scrollView0.OnEndDrag(EPIMKFPMMEA);
		}
		this.scrollView2.horizontal = true;
		this.KILJECMJIPL = true;
		this.scrollView2.movementType = (ScrollRect.MovementType)8;
	}

	// Token: 0x060082FA RID: 33530 RVA: 0x0039ACE9 File Offset: 0x00398EE9
	public void HONDFOJOEBB(PointerEventData EPIMKFPMMEA)
	{
		this.LAIPGIECKDL = false;
		if (this.KILJECMJIPL)
		{
			this.scrollView0.OnDrag(EPIMKFPMMEA);
		}
	}

	// Token: 0x060082FB RID: 33531 RVA: 0x0039AB91 File Offset: 0x00398D91
	public void GKFJFODMIMN(PointerEventData EPIMKFPMMEA)
	{
		this.LAIPGIECKDL = true;
		if (this.KILJECMJIPL)
		{
			this.scrollView0.OnDrag(EPIMKFPMMEA);
		}
	}

	// Token: 0x0400251A RID: 9498
	public ScrollRect scrollView0;

	// Token: 0x0400251B RID: 9499
	public RectTransform scrollView0Content;

	// Token: 0x0400251C RID: 9500
	public ScrollRect scrollView2;

	// Token: 0x0400251D RID: 9501
	public RectTransform filterItemsParent;

	// Token: 0x0400251E RID: 9502
	public RectTransform pageIndicatorContent;

	// Token: 0x0400251F RID: 9503
	public RectTransform extraFixedContent;

	// Token: 0x04002520 RID: 9504
	public float timeOfFiltersTransition = 0.2f;

	// Token: 0x04002521 RID: 9505
	public float timeOfSmallItemsTransition = 0.15f;

	// Token: 0x04002522 RID: 9506
	public float minPercentsOfVisibleSmallItem = 0.2f;

	// Token: 0x04002523 RID: 9507
	[Header("Filters Animation")]
	public float shakeSpeed = 200f;

	// Token: 0x04002524 RID: 9508
	public int shakeTimes = 4;

	// Token: 0x04002525 RID: 9509
	[Range(0f, 25f)]
	public int shakeDistance = 25;

	// Token: 0x04002526 RID: 9510
	private bool KILJECMJIPL;

	// Token: 0x04002527 RID: 9511
	private float MHGNFDFLMJG;

	// Token: 0x04002528 RID: 9512
	private bool OGHBEJEAOJM;

	// Token: 0x04002529 RID: 9513
	private bool LAIPGIECKDL;
}
