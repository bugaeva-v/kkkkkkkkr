using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x02000227 RID: 551
public class AnimationPress : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
{
	// Token: 0x06004570 RID: 17776 RVA: 0x001E1072 File Offset: 0x001DF272
	public void LJDJNBEBLKH(float BKPGAOLEOKB)
	{
		this.FNHAIFIHADL = BKPGAOLEOKB;
	}

	// Token: 0x06004571 RID: 17777 RVA: 0x001E107B File Offset: 0x001DF27B
	private void ONJMBHKDOGD()
	{
		this.DGAAFGDHHHJ.DOKill(true);
	}

	// Token: 0x06004572 RID: 17778 RVA: 0x001E108C File Offset: 0x001DF28C
	private void EJCFKOHELJO()
	{
		if (NarrowScreenScaler.ScreenIsTooNarrow(1621f) && null != this.NLIEPAHCJLO)
		{
			Vector3 vector = NarrowScreenScaler.CalculateNewScaleUtil(this.DGAAFGDHHHJ.localScale, 1245f, (IMBLFHMKMAD)67);
			this.DGAAFGDHHHJ.AMPMCKEAACJ(vector.x, vector.y, vector.z);
			this.FNHAIFIHADL = this.DGAAFGDHHHJ.localScale.x;
		}
	}

	// Token: 0x06004573 RID: 17779 RVA: 0x001E1104 File Offset: 0x001DF304
	private void GANNEJBHDIM()
	{
		if (NarrowScreenScaler.ScreenIsTooNarrow(1526f) && null != this.NLIEPAHCJLO)
		{
			Vector3 vector = NarrowScreenScaler.CalculateNewScaleUtil(this.DGAAFGDHHHJ.localScale, 1272f, (IMBLFHMKMAD)196);
			this.DGAAFGDHHHJ.AMPMCKEAACJ(vector.x, vector.y, vector.z);
			this.FNHAIFIHADL = this.DGAAFGDHHHJ.localScale.x;
		}
	}

	// Token: 0x06004574 RID: 17780 RVA: 0x001E107B File Offset: 0x001DF27B
	private void DNANKPMNMIF()
	{
		this.DGAAFGDHHHJ.DOKill(true);
	}

	// Token: 0x06004575 RID: 17781 RVA: 0x001E1072 File Offset: 0x001DF272
	public void PLBIPOILIJA(float BKPGAOLEOKB)
	{
		this.FNHAIFIHADL = BKPGAOLEOKB;
	}

	// Token: 0x06004576 RID: 17782 RVA: 0x001E117C File Offset: 0x001DF37C
	private void FDOPMEKNMEA()
	{
		if (NarrowScreenScaler.ScreenIsTooNarrow(1397f) && null != this.NLIEPAHCJLO)
		{
			Vector3 vector = NarrowScreenScaler.CalculateNewScaleUtil(this.DGAAFGDHHHJ.localScale, 252f, (IMBLFHMKMAD)44);
			this.DGAAFGDHHHJ.AMPMCKEAACJ(vector.x, vector.y, vector.z);
			this.FNHAIFIHADL = this.DGAAFGDHHHJ.localScale.x;
		}
	}

	// Token: 0x06004577 RID: 17783 RVA: 0x001E11F4 File Offset: 0x001DF3F4
	private void GOLKPDKALNC()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		if (NarrowScreenScaler.ScreenIsTooNarrow(1104f))
		{
			this.NLIEPAHCJLO = base.gameObject.GetComponent<NarrowScreenScaler>();
		}
		this.FNHAIFIHADL = this.DGAAFGDHHHJ.localScale.x;
		this.LOEKDPHFOMD = base.gameObject.GetComponent<Selectable>();
	}

	// Token: 0x06004578 RID: 17784 RVA: 0x001E1258 File Offset: 0x001DF458
	private void BPDHPMKCLNB()
	{
		if (NarrowScreenScaler.ScreenIsTooNarrow(965f) && null != this.NLIEPAHCJLO)
		{
			Vector3 vector = NarrowScreenScaler.CalculateNewScaleUtil(this.DGAAFGDHHHJ.localScale, 1174f, (IMBLFHMKMAD)190);
			this.DGAAFGDHHHJ.AMPMCKEAACJ(vector.x, vector.y, vector.z);
			this.FNHAIFIHADL = this.DGAAFGDHHHJ.localScale.x;
		}
	}

	// Token: 0x06004579 RID: 17785 RVA: 0x001E1072 File Offset: 0x001DF272
	public void OFLIALFOJKA(float BKPGAOLEOKB)
	{
		this.FNHAIFIHADL = BKPGAOLEOKB;
	}

	// Token: 0x0600457A RID: 17786 RVA: 0x001E12D0 File Offset: 0x001DF4D0
	public void FBBMEJACOAG(PointerEventData EPIMKFPMMEA)
	{
		if (this.FPPBAAPCIBB)
		{
			this.DGAAFGDHHHJ.DOKill(false);
			this.DGAAFGDHHHJ.DOScale(this.DGAAFGDHHHJ.localScale.x / (this.scaleCoefficient * 1371f), 1257f);
		}
		this.FPPBAAPCIBB = false;
	}

	// Token: 0x0600457B RID: 17787 RVA: 0x001E1328 File Offset: 0x001DF528
	private void JFEKHEIGPJD()
	{
		if (NarrowScreenScaler.ScreenIsTooNarrow(1745f) && null != this.NLIEPAHCJLO)
		{
			Vector3 vector = NarrowScreenScaler.CalculateNewScaleUtil(this.DGAAFGDHHHJ.localScale, 7f, (IMBLFHMKMAD)(-6));
			this.DGAAFGDHHHJ.AMPMCKEAACJ(vector.x, vector.y, vector.z);
			this.FNHAIFIHADL = this.DGAAFGDHHHJ.localScale.x;
		}
	}

	// Token: 0x0600457C RID: 17788 RVA: 0x001E13A0 File Offset: 0x001DF5A0
	private void FNNKDFGKAEH()
	{
		if (NarrowScreenScaler.ScreenIsTooNarrow(1062f) && null != this.NLIEPAHCJLO)
		{
			Vector3 vector = NarrowScreenScaler.CalculateNewScaleUtil(this.DGAAFGDHHHJ.localScale, 1166f, (IMBLFHMKMAD)(-150));
			this.DGAAFGDHHHJ.AMPMCKEAACJ(vector.x, vector.y, vector.z);
			this.FNHAIFIHADL = this.DGAAFGDHHHJ.localScale.x;
		}
	}

	// Token: 0x0600457D RID: 17789 RVA: 0x001E1418 File Offset: 0x001DF618
	public void JPPJENLPAAK(PointerEventData EPIMKFPMMEA)
	{
		if (null != this.LOEKDPHFOMD && !this.LOEKDPHFOMD.interactable)
		{
			return;
		}
		if (!this.FPPBAAPCIBB)
		{
			this.DGAAFGDHHHJ.DOKill(true);
			this.DGAAFGDHHHJ.DOScale(this.scaleCoefficient * 1695f * this.FNHAIFIHADL, 1837f);
		}
		this.FPPBAAPCIBB = true;
	}

	// Token: 0x0600457E RID: 17790 RVA: 0x001E1484 File Offset: 0x001DF684
	private void CJOOOIECMAE()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		if (NarrowScreenScaler.ScreenIsTooNarrow(839f))
		{
			this.NLIEPAHCJLO = base.gameObject.GetComponent<NarrowScreenScaler>();
		}
		this.FNHAIFIHADL = this.DGAAFGDHHHJ.localScale.x;
		this.LOEKDPHFOMD = base.gameObject.GetComponent<Selectable>();
	}

	// Token: 0x0600457F RID: 17791 RVA: 0x001E14E8 File Offset: 0x001DF6E8
	private void PIHONDPKDBB()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		if (NarrowScreenScaler.ScreenIsTooNarrow(904f))
		{
			this.NLIEPAHCJLO = base.gameObject.GetComponent<NarrowScreenScaler>();
		}
		this.FNHAIFIHADL = this.DGAAFGDHHHJ.localScale.x;
		this.LOEKDPHFOMD = base.gameObject.GetComponent<Selectable>();
	}

	// Token: 0x06004580 RID: 17792 RVA: 0x001E154C File Offset: 0x001DF74C
	private void PMDCMEKGFNN()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		if (NarrowScreenScaler.ScreenIsTooNarrow(670f))
		{
			this.NLIEPAHCJLO = base.gameObject.GetComponent<NarrowScreenScaler>();
		}
		this.FNHAIFIHADL = this.DGAAFGDHHHJ.localScale.x;
		this.LOEKDPHFOMD = base.gameObject.GetComponent<Selectable>();
	}

	// Token: 0x06004581 RID: 17793 RVA: 0x001E15B0 File Offset: 0x001DF7B0
	public void IMILEMCBKLB(PointerEventData EPIMKFPMMEA)
	{
		if (this.FPPBAAPCIBB)
		{
			this.DGAAFGDHHHJ.DOKill(true);
			this.DGAAFGDHHHJ.DOScale(this.DGAAFGDHHHJ.localScale.x / (this.scaleCoefficient * 266f), 295f);
		}
		this.FPPBAAPCIBB = true;
	}

	// Token: 0x06004582 RID: 17794 RVA: 0x001E1608 File Offset: 0x001DF808
	public void OnPointerUp(PointerEventData EPIMKFPMMEA)
	{
		if (this.FPPBAAPCIBB)
		{
			this.DGAAFGDHHHJ.DOKill(true);
			this.DGAAFGDHHHJ.DOScale(this.DGAAFGDHHHJ.localScale.x / (this.scaleCoefficient * 0.97f), 0.1f);
		}
		this.FPPBAAPCIBB = false;
	}

	// Token: 0x06004583 RID: 17795 RVA: 0x001E165F File Offset: 0x001DF85F
	private void OnDestroy()
	{
		this.DGAAFGDHHHJ.DOKill(false);
	}

	// Token: 0x06004584 RID: 17796 RVA: 0x001E1670 File Offset: 0x001DF870
	public void IFEODKBCPGE(PointerEventData EPIMKFPMMEA)
	{
		if (null != this.LOEKDPHFOMD && !this.LOEKDPHFOMD.interactable)
		{
			return;
		}
		if (!this.FPPBAAPCIBB)
		{
			this.DGAAFGDHHHJ.DOKill(true);
			this.DGAAFGDHHHJ.DOScale(this.scaleCoefficient * 1581f * this.FNHAIFIHADL, 1151f);
		}
		this.FPPBAAPCIBB = false;
	}

	// Token: 0x06004585 RID: 17797 RVA: 0x001E16DC File Offset: 0x001DF8DC
	private void HPDHFIHPKGP()
	{
		if (NarrowScreenScaler.ScreenIsTooNarrow(1675f) && null != this.NLIEPAHCJLO)
		{
			Vector3 vector = NarrowScreenScaler.CalculateNewScaleUtil(this.DGAAFGDHHHJ.localScale, 1264f, (IMBLFHMKMAD)(-150));
			this.DGAAFGDHHHJ.AMPMCKEAACJ(vector.x, vector.y, vector.z);
			this.FNHAIFIHADL = this.DGAAFGDHHHJ.localScale.x;
		}
	}

	// Token: 0x06004586 RID: 17798 RVA: 0x001E1072 File Offset: 0x001DF272
	public void BKGJJEPCLCH(float BKPGAOLEOKB)
	{
		this.FNHAIFIHADL = BKPGAOLEOKB;
	}

	// Token: 0x06004587 RID: 17799 RVA: 0x001E1072 File Offset: 0x001DF272
	public void FGLELHFAOHL(float BKPGAOLEOKB)
	{
		this.FNHAIFIHADL = BKPGAOLEOKB;
	}

	// Token: 0x06004588 RID: 17800 RVA: 0x001E1754 File Offset: 0x001DF954
	public void HOACDNMJBML(PointerEventData EPIMKFPMMEA)
	{
		if (null != this.LOEKDPHFOMD && !this.LOEKDPHFOMD.interactable)
		{
			return;
		}
		if (!this.FPPBAAPCIBB)
		{
			this.DGAAFGDHHHJ.DOKill(false);
			this.DGAAFGDHHHJ.DOScale(this.scaleCoefficient * 917f * this.FNHAIFIHADL, 432f);
		}
		this.FPPBAAPCIBB = true;
	}

	// Token: 0x06004589 RID: 17801 RVA: 0x001E17C0 File Offset: 0x001DF9C0
	public void DNOCMFAKIDI(PointerEventData EPIMKFPMMEA)
	{
		if (null != this.LOEKDPHFOMD && !this.LOEKDPHFOMD.interactable)
		{
			return;
		}
		if (!this.FPPBAAPCIBB)
		{
			this.DGAAFGDHHHJ.DOKill(true);
			this.DGAAFGDHHHJ.DOScale(this.scaleCoefficient * 531f * this.FNHAIFIHADL, 1852f);
		}
		this.FPPBAAPCIBB = true;
	}

	// Token: 0x0600458A RID: 17802 RVA: 0x001E1072 File Offset: 0x001DF272
	public void NPOODGELPOE(float BKPGAOLEOKB)
	{
		this.FNHAIFIHADL = BKPGAOLEOKB;
	}

	// Token: 0x0600458B RID: 17803 RVA: 0x001E107B File Offset: 0x001DF27B
	private void KLGMKIJJDFN()
	{
		this.DGAAFGDHHHJ.DOKill(true);
	}

	// Token: 0x0600458C RID: 17804 RVA: 0x001E182C File Offset: 0x001DFA2C
	private void Awake()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		if (NarrowScreenScaler.ScreenIsTooNarrow(822f))
		{
			this.NLIEPAHCJLO = base.gameObject.GetComponent<NarrowScreenScaler>();
		}
		this.FNHAIFIHADL = this.DGAAFGDHHHJ.localScale.x;
		this.LOEKDPHFOMD = base.gameObject.GetComponent<Selectable>();
	}

	// Token: 0x0600458D RID: 17805 RVA: 0x001E1072 File Offset: 0x001DF272
	public void HICEABIIEJE(float BKPGAOLEOKB)
	{
		this.FNHAIFIHADL = BKPGAOLEOKB;
	}

	// Token: 0x0600458E RID: 17806 RVA: 0x001E1890 File Offset: 0x001DFA90
	private void PCMFCIDHKCL()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		if (NarrowScreenScaler.ScreenIsTooNarrow(1253f))
		{
			this.NLIEPAHCJLO = base.gameObject.GetComponent<NarrowScreenScaler>();
		}
		this.FNHAIFIHADL = this.DGAAFGDHHHJ.localScale.x;
		this.LOEKDPHFOMD = base.gameObject.GetComponent<Selectable>();
	}

	// Token: 0x0600458F RID: 17807 RVA: 0x001E18F4 File Offset: 0x001DFAF4
	private void JCOIBJANCMG()
	{
		if (NarrowScreenScaler.ScreenIsTooNarrow(1350f) && null != this.NLIEPAHCJLO)
		{
			Vector3 vector = NarrowScreenScaler.CalculateNewScaleUtil(this.DGAAFGDHHHJ.localScale, 432f, (IMBLFHMKMAD)33);
			this.DGAAFGDHHHJ.AMPMCKEAACJ(vector.x, vector.y, vector.z);
			this.FNHAIFIHADL = this.DGAAFGDHHHJ.localScale.x;
		}
	}

	// Token: 0x06004590 RID: 17808 RVA: 0x001E1072 File Offset: 0x001DF272
	public void OBGFECODCBO(float BKPGAOLEOKB)
	{
		this.FNHAIFIHADL = BKPGAOLEOKB;
	}

	// Token: 0x06004591 RID: 17809 RVA: 0x001E196C File Offset: 0x001DFB6C
	private void ODPDLANJNIP()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		if (NarrowScreenScaler.ScreenIsTooNarrow(360f))
		{
			this.NLIEPAHCJLO = base.gameObject.GetComponent<NarrowScreenScaler>();
		}
		this.FNHAIFIHADL = this.DGAAFGDHHHJ.localScale.x;
		this.LOEKDPHFOMD = base.gameObject.GetComponent<Selectable>();
	}

	// Token: 0x06004592 RID: 17810 RVA: 0x001E19D0 File Offset: 0x001DFBD0
	private void EHECBKECKPA()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		if (NarrowScreenScaler.ScreenIsTooNarrow(1206f))
		{
			this.NLIEPAHCJLO = base.gameObject.GetComponent<NarrowScreenScaler>();
		}
		this.FNHAIFIHADL = this.DGAAFGDHHHJ.localScale.x;
		this.LOEKDPHFOMD = base.gameObject.GetComponent<Selectable>();
	}

	// Token: 0x06004593 RID: 17811 RVA: 0x001E1A34 File Offset: 0x001DFC34
	private void OHPNGFAIGEM()
	{
		if (NarrowScreenScaler.ScreenIsTooNarrow(405f) && null != this.NLIEPAHCJLO)
		{
			Vector3 vector = NarrowScreenScaler.CalculateNewScaleUtil(this.DGAAFGDHHHJ.localScale, 1621f, (IMBLFHMKMAD)(-145));
			this.DGAAFGDHHHJ.AMPMCKEAACJ(vector.x, vector.y, vector.z);
			this.FNHAIFIHADL = this.DGAAFGDHHHJ.localScale.x;
		}
	}

	// Token: 0x06004594 RID: 17812 RVA: 0x001E1072 File Offset: 0x001DF272
	public void FCMFKIFKNMA(float BKPGAOLEOKB)
	{
		this.FNHAIFIHADL = BKPGAOLEOKB;
	}

	// Token: 0x06004595 RID: 17813 RVA: 0x001E1AAC File Offset: 0x001DFCAC
	public void KKDLLFCMEDG(PointerEventData EPIMKFPMMEA)
	{
		if (null != this.LOEKDPHFOMD && !this.LOEKDPHFOMD.interactable)
		{
			return;
		}
		if (!this.FPPBAAPCIBB)
		{
			this.DGAAFGDHHHJ.DOKill(true);
			this.DGAAFGDHHHJ.DOScale(this.scaleCoefficient * 936f * this.FNHAIFIHADL, 1360f);
		}
		this.FPPBAAPCIBB = false;
	}

	// Token: 0x06004596 RID: 17814 RVA: 0x001E1B18 File Offset: 0x001DFD18
	private void EKEOFMOJCGF()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		if (NarrowScreenScaler.ScreenIsTooNarrow(256f))
		{
			this.NLIEPAHCJLO = base.gameObject.GetComponent<NarrowScreenScaler>();
		}
		this.FNHAIFIHADL = this.DGAAFGDHHHJ.localScale.x;
		this.LOEKDPHFOMD = base.gameObject.GetComponent<Selectable>();
	}

	// Token: 0x06004597 RID: 17815 RVA: 0x001E1072 File Offset: 0x001DF272
	public void CGNGGNJCPMI(float BKPGAOLEOKB)
	{
		this.FNHAIFIHADL = BKPGAOLEOKB;
	}

	// Token: 0x06004598 RID: 17816 RVA: 0x001E1B7C File Offset: 0x001DFD7C
	public void PKCJNIPHFHI(PointerEventData EPIMKFPMMEA)
	{
		if (null != this.LOEKDPHFOMD && !this.LOEKDPHFOMD.interactable)
		{
			return;
		}
		if (!this.FPPBAAPCIBB)
		{
			this.DGAAFGDHHHJ.DOKill(false);
			this.DGAAFGDHHHJ.DOScale(this.scaleCoefficient * 993f * this.FNHAIFIHADL, 1147f);
		}
		this.FPPBAAPCIBB = false;
	}

	// Token: 0x06004599 RID: 17817 RVA: 0x001E1BE8 File Offset: 0x001DFDE8
	private void JDBJMNMBOMK()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		if (NarrowScreenScaler.ScreenIsTooNarrow(388f))
		{
			this.NLIEPAHCJLO = base.gameObject.GetComponent<NarrowScreenScaler>();
		}
		this.FNHAIFIHADL = this.DGAAFGDHHHJ.localScale.x;
		this.LOEKDPHFOMD = base.gameObject.GetComponent<Selectable>();
	}

	// Token: 0x0600459A RID: 17818 RVA: 0x001E1072 File Offset: 0x001DF272
	public void LEKNPNMNAOJ(float BKPGAOLEOKB)
	{
		this.FNHAIFIHADL = BKPGAOLEOKB;
	}

	// Token: 0x0600459B RID: 17819 RVA: 0x001E1C4C File Offset: 0x001DFE4C
	public void FFOFBNMBIAG(PointerEventData EPIMKFPMMEA)
	{
		if (null != this.LOEKDPHFOMD && !this.LOEKDPHFOMD.interactable)
		{
			return;
		}
		if (!this.FPPBAAPCIBB)
		{
			this.DGAAFGDHHHJ.DOKill(false);
			this.DGAAFGDHHHJ.DOScale(this.scaleCoefficient * 1831f * this.FNHAIFIHADL, 15f);
		}
		this.FPPBAAPCIBB = false;
	}

	// Token: 0x0600459C RID: 17820 RVA: 0x001E1CB8 File Offset: 0x001DFEB8
	private void Start()
	{
		if (NarrowScreenScaler.ScreenIsTooNarrow(822f) && null != this.NLIEPAHCJLO)
		{
			Vector3 vector = NarrowScreenScaler.CalculateNewScaleUtil(this.DGAAFGDHHHJ.localScale, 822f, IMBLFHMKMAD.doNotOverride);
			this.DGAAFGDHHHJ.AMPMCKEAACJ(vector.x, vector.y, vector.z);
			this.FNHAIFIHADL = this.DGAAFGDHHHJ.localScale.x;
		}
	}

	// Token: 0x0600459D RID: 17821 RVA: 0x001E1D30 File Offset: 0x001DFF30
	public void CMNGOFMOCCN(PointerEventData EPIMKFPMMEA)
	{
		if (this.FPPBAAPCIBB)
		{
			this.DGAAFGDHHHJ.DOKill(true);
			this.DGAAFGDHHHJ.DOScale(this.DGAAFGDHHHJ.localScale.x / (this.scaleCoefficient * 1340f), 794f);
		}
		this.FPPBAAPCIBB = true;
	}

	// Token: 0x0600459E RID: 17822 RVA: 0x001E165F File Offset: 0x001DF85F
	private void CFHFGNOIPEC()
	{
		this.DGAAFGDHHHJ.DOKill(false);
	}

	// Token: 0x0600459F RID: 17823 RVA: 0x001E1D88 File Offset: 0x001DFF88
	public void HFMJGJKDHGO(PointerEventData EPIMKFPMMEA)
	{
		if (this.FPPBAAPCIBB)
		{
			this.DGAAFGDHHHJ.DOKill(false);
			this.DGAAFGDHHHJ.DOScale(this.DGAAFGDHHHJ.localScale.x / (this.scaleCoefficient * 668f), 407f);
		}
		this.FPPBAAPCIBB = true;
	}

	// Token: 0x060045A0 RID: 17824 RVA: 0x001E107B File Offset: 0x001DF27B
	private void NKIEJIHEADI()
	{
		this.DGAAFGDHHHJ.DOKill(true);
	}

	// Token: 0x060045A1 RID: 17825 RVA: 0x001E1DE0 File Offset: 0x001DFFE0
	private void IFHJKBHODGG()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		if (NarrowScreenScaler.ScreenIsTooNarrow(940f))
		{
			this.NLIEPAHCJLO = base.gameObject.GetComponent<NarrowScreenScaler>();
		}
		this.FNHAIFIHADL = this.DGAAFGDHHHJ.localScale.x;
		this.LOEKDPHFOMD = base.gameObject.GetComponent<Selectable>();
	}

	// Token: 0x060045A2 RID: 17826 RVA: 0x001E1E44 File Offset: 0x001E0044
	public void OMDBPOPONJB(PointerEventData EPIMKFPMMEA)
	{
		if (this.FPPBAAPCIBB)
		{
			this.DGAAFGDHHHJ.DOKill(false);
			this.DGAAFGDHHHJ.DOScale(this.DGAAFGDHHHJ.localScale.x / (this.scaleCoefficient * 1529f), 799f);
		}
		this.FPPBAAPCIBB = false;
	}

	// Token: 0x060045A3 RID: 17827 RVA: 0x001E1E9C File Offset: 0x001E009C
	private void PKMPOFOOGFK()
	{
		if (NarrowScreenScaler.ScreenIsTooNarrow(1226f) && null != this.NLIEPAHCJLO)
		{
			Vector3 vector = NarrowScreenScaler.CalculateNewScaleUtil(this.DGAAFGDHHHJ.localScale, 1896f, (IMBLFHMKMAD)(-33));
			this.DGAAFGDHHHJ.AMPMCKEAACJ(vector.x, vector.y, vector.z);
			this.FNHAIFIHADL = this.DGAAFGDHHHJ.localScale.x;
		}
	}

	// Token: 0x060045A4 RID: 17828 RVA: 0x001E165F File Offset: 0x001DF85F
	private void LGEJJBINCJP()
	{
		this.DGAAFGDHHHJ.DOKill(false);
	}

	// Token: 0x060045A5 RID: 17829 RVA: 0x001E1F14 File Offset: 0x001E0114
	public void EDHBNOMCLIB(PointerEventData EPIMKFPMMEA)
	{
		if (null != this.LOEKDPHFOMD && !this.LOEKDPHFOMD.interactable)
		{
			return;
		}
		if (!this.FPPBAAPCIBB)
		{
			this.DGAAFGDHHHJ.DOKill(false);
			this.DGAAFGDHHHJ.DOScale(this.scaleCoefficient * 52f * this.FNHAIFIHADL, 568f);
		}
		this.FPPBAAPCIBB = true;
	}

	// Token: 0x060045A6 RID: 17830 RVA: 0x001E1F80 File Offset: 0x001E0180
	private void JDMOENJPHOE()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		if (NarrowScreenScaler.ScreenIsTooNarrow(435f))
		{
			this.NLIEPAHCJLO = base.gameObject.GetComponent<NarrowScreenScaler>();
		}
		this.FNHAIFIHADL = this.DGAAFGDHHHJ.localScale.x;
		this.LOEKDPHFOMD = base.gameObject.GetComponent<Selectable>();
	}

	// Token: 0x060045A7 RID: 17831 RVA: 0x001E1FE4 File Offset: 0x001E01E4
	private void MDNEOMGLGIN()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		if (NarrowScreenScaler.ScreenIsTooNarrow(1335f))
		{
			this.NLIEPAHCJLO = base.gameObject.GetComponent<NarrowScreenScaler>();
		}
		this.FNHAIFIHADL = this.DGAAFGDHHHJ.localScale.x;
		this.LOEKDPHFOMD = base.gameObject.GetComponent<Selectable>();
	}

	// Token: 0x060045A8 RID: 17832 RVA: 0x001E2048 File Offset: 0x001E0248
	public void OnPointerDown(PointerEventData EPIMKFPMMEA)
	{
		if (null != this.LOEKDPHFOMD && !this.LOEKDPHFOMD.interactable)
		{
			return;
		}
		if (!this.FPPBAAPCIBB)
		{
			this.DGAAFGDHHHJ.DOKill(true);
			this.DGAAFGDHHHJ.DOScale(this.scaleCoefficient * 0.97f * this.FNHAIFIHADL, 0.1f);
		}
		this.FPPBAAPCIBB = true;
	}

	// Token: 0x060045A9 RID: 17833 RVA: 0x001E20B4 File Offset: 0x001E02B4
	public void MEOEEOBPKMH(PointerEventData EPIMKFPMMEA)
	{
		if (this.FPPBAAPCIBB)
		{
			this.DGAAFGDHHHJ.DOKill(false);
			this.DGAAFGDHHHJ.DOScale(this.DGAAFGDHHHJ.localScale.x / (this.scaleCoefficient * 141f), 1333f);
		}
		this.FPPBAAPCIBB = false;
	}

	// Token: 0x060045AA RID: 17834 RVA: 0x001E210C File Offset: 0x001E030C
	public void ALCBKEPJBGJ(PointerEventData EPIMKFPMMEA)
	{
		if (this.FPPBAAPCIBB)
		{
			this.DGAAFGDHHHJ.DOKill(false);
			this.DGAAFGDHHHJ.DOScale(this.DGAAFGDHHHJ.localScale.x / (this.scaleCoefficient * 1344f), 146f);
		}
		this.FPPBAAPCIBB = true;
	}

	// Token: 0x060045AB RID: 17835 RVA: 0x001E165F File Offset: 0x001DF85F
	private void GALHNFOLOAK()
	{
		this.DGAAFGDHHHJ.DOKill(false);
	}

	// Token: 0x060045AC RID: 17836 RVA: 0x001E2164 File Offset: 0x001E0364
	public void PLJPLCMDNLI(PointerEventData EPIMKFPMMEA)
	{
		if (this.FPPBAAPCIBB)
		{
			this.DGAAFGDHHHJ.DOKill(true);
			this.DGAAFGDHHHJ.DOScale(this.DGAAFGDHHHJ.localScale.x / (this.scaleCoefficient * 1065f), 1787f);
		}
		this.FPPBAAPCIBB = true;
	}

	// Token: 0x060045AD RID: 17837 RVA: 0x001E1072 File Offset: 0x001DF272
	public void KCIDELHCGID(float BKPGAOLEOKB)
	{
		this.FNHAIFIHADL = BKPGAOLEOKB;
	}

	// Token: 0x060045AE RID: 17838 RVA: 0x001E21BC File Offset: 0x001E03BC
	public void NPFLJNKFLMJ(PointerEventData EPIMKFPMMEA)
	{
		if (this.FPPBAAPCIBB)
		{
			this.DGAAFGDHHHJ.DOKill(true);
			this.DGAAFGDHHHJ.DOScale(this.DGAAFGDHHHJ.localScale.x / (this.scaleCoefficient * 1761f), 1961f);
		}
		this.FPPBAAPCIBB = true;
	}

	// Token: 0x060045AF RID: 17839 RVA: 0x001E2214 File Offset: 0x001E0414
	private void OPPNHGEMHAB()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		if (NarrowScreenScaler.ScreenIsTooNarrow(89f))
		{
			this.NLIEPAHCJLO = base.gameObject.GetComponent<NarrowScreenScaler>();
		}
		this.FNHAIFIHADL = this.DGAAFGDHHHJ.localScale.x;
		this.LOEKDPHFOMD = base.gameObject.GetComponent<Selectable>();
	}

	// Token: 0x060045B0 RID: 17840 RVA: 0x001E2278 File Offset: 0x001E0478
	public void HINPAJFGOFH(PointerEventData EPIMKFPMMEA)
	{
		if (this.FPPBAAPCIBB)
		{
			this.DGAAFGDHHHJ.DOKill(true);
			this.DGAAFGDHHHJ.DOScale(this.DGAAFGDHHHJ.localScale.x / (this.scaleCoefficient * 1832f), 7f);
		}
		this.FPPBAAPCIBB = false;
	}

	// Token: 0x060045B1 RID: 17841 RVA: 0x001E107B File Offset: 0x001DF27B
	private void EHLOONNKOPB()
	{
		this.DGAAFGDHHHJ.DOKill(true);
	}

	// Token: 0x060045B2 RID: 17842 RVA: 0x001E22D0 File Offset: 0x001E04D0
	public void KDEHINMFAEL(PointerEventData EPIMKFPMMEA)
	{
		if (this.FPPBAAPCIBB)
		{
			this.DGAAFGDHHHJ.DOKill(true);
			this.DGAAFGDHHHJ.DOScale(this.DGAAFGDHHHJ.localScale.x / (this.scaleCoefficient * 965f), 507f);
		}
		this.FPPBAAPCIBB = false;
	}

	// Token: 0x060045B3 RID: 17843 RVA: 0x001E2328 File Offset: 0x001E0528
	public void KMAOLPNDCEM(PointerEventData EPIMKFPMMEA)
	{
		if (null != this.LOEKDPHFOMD && !this.LOEKDPHFOMD.interactable)
		{
			return;
		}
		if (!this.FPPBAAPCIBB)
		{
			this.DGAAFGDHHHJ.DOKill(false);
			this.DGAAFGDHHHJ.DOScale(this.scaleCoefficient * 1159f * this.FNHAIFIHADL, 1704f);
		}
		this.FPPBAAPCIBB = true;
	}

	// Token: 0x060045B4 RID: 17844 RVA: 0x001E2394 File Offset: 0x001E0594
	public void HJALDEAPCPI(PointerEventData EPIMKFPMMEA)
	{
		if (null != this.LOEKDPHFOMD && !this.LOEKDPHFOMD.interactable)
		{
			return;
		}
		if (!this.FPPBAAPCIBB)
		{
			this.DGAAFGDHHHJ.DOKill(false);
			this.DGAAFGDHHHJ.DOScale(this.scaleCoefficient * 561f * this.FNHAIFIHADL, 344f);
		}
		this.FPPBAAPCIBB = false;
	}

	// Token: 0x060045B5 RID: 17845 RVA: 0x001E2400 File Offset: 0x001E0600
	public void MBCEFFONHAL(PointerEventData EPIMKFPMMEA)
	{
		if (this.FPPBAAPCIBB)
		{
			this.DGAAFGDHHHJ.DOKill(true);
			this.DGAAFGDHHHJ.DOScale(this.DGAAFGDHHHJ.localScale.x / (this.scaleCoefficient * 620f), 1107f);
		}
		this.FPPBAAPCIBB = false;
	}

	// Token: 0x060045B6 RID: 17846 RVA: 0x001E2458 File Offset: 0x001E0658
	private void MAIBLFFBJAA()
	{
		if (NarrowScreenScaler.ScreenIsTooNarrow(626f) && null != this.NLIEPAHCJLO)
		{
			Vector3 vector = NarrowScreenScaler.CalculateNewScaleUtil(this.DGAAFGDHHHJ.localScale, 483f, (IMBLFHMKMAD)(-6));
			this.DGAAFGDHHHJ.AMPMCKEAACJ(vector.x, vector.y, vector.z);
			this.FNHAIFIHADL = this.DGAAFGDHHHJ.localScale.x;
		}
	}

	// Token: 0x060045B7 RID: 17847 RVA: 0x001E107B File Offset: 0x001DF27B
	private void HKFKOMMEMCN()
	{
		this.DGAAFGDHHHJ.DOKill(true);
	}

	// Token: 0x060045B9 RID: 17849 RVA: 0x001E24EC File Offset: 0x001E06EC
	private void AALDINEPEHJ()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		if (NarrowScreenScaler.ScreenIsTooNarrow(1320f))
		{
			this.NLIEPAHCJLO = base.gameObject.GetComponent<NarrowScreenScaler>();
		}
		this.FNHAIFIHADL = this.DGAAFGDHHHJ.localScale.x;
		this.LOEKDPHFOMD = base.gameObject.GetComponent<Selectable>();
	}

	// Token: 0x060045BA RID: 17850 RVA: 0x001E2550 File Offset: 0x001E0750
	private void DHDEDOICCHC()
	{
		if (NarrowScreenScaler.ScreenIsTooNarrow(904f) && null != this.NLIEPAHCJLO)
		{
			Vector3 vector = NarrowScreenScaler.CalculateNewScaleUtil(this.DGAAFGDHHHJ.localScale, 44f, (IMBLFHMKMAD)(-80));
			this.DGAAFGDHHHJ.AMPMCKEAACJ(vector.x, vector.y, vector.z);
			this.FNHAIFIHADL = this.DGAAFGDHHHJ.localScale.x;
		}
	}

	// Token: 0x060045BB RID: 17851 RVA: 0x001E1072 File Offset: 0x001DF272
	public void SetOriginalScaleCoefficient(float BKPGAOLEOKB)
	{
		this.FNHAIFIHADL = BKPGAOLEOKB;
	}

	// Token: 0x060045BC RID: 17852 RVA: 0x001E1072 File Offset: 0x001DF272
	public void PBMFHBLNAIM(float BKPGAOLEOKB)
	{
		this.FNHAIFIHADL = BKPGAOLEOKB;
	}

	// Token: 0x060045BD RID: 17853 RVA: 0x001E1072 File Offset: 0x001DF272
	public void GKDGAMLNIIB(float BKPGAOLEOKB)
	{
		this.FNHAIFIHADL = BKPGAOLEOKB;
	}

	// Token: 0x060045BE RID: 17854 RVA: 0x001E165F File Offset: 0x001DF85F
	private void LEEEOAHDCJD()
	{
		this.DGAAFGDHHHJ.DOKill(false);
	}

	// Token: 0x04001387 RID: 4999
	public float scaleCoefficient = 0.97f;

	// Token: 0x04001388 RID: 5000
	private float FNHAIFIHADL = 1f;

	// Token: 0x04001389 RID: 5001
	private bool FPPBAAPCIBB;

	// Token: 0x0400138A RID: 5002
	private RectTransform DGAAFGDHHHJ;

	// Token: 0x0400138B RID: 5003
	private Selectable LOEKDPHFOMD;

	// Token: 0x0400138C RID: 5004
	private NarrowScreenScaler NLIEPAHCJLO;
}
