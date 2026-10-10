using System;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x020002BC RID: 700
public class LobbySearchBarTapCatcher : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler
{
	// Token: 0x06005869 RID: 22633 RVA: 0x002805F5 File Offset: 0x0027E7F5
	public void CNOJGCCCGMD(PointerEventData CDMNCPMIDJP)
	{
		this.JCNHDDNLFHD = true;
	}

	// Token: 0x0600586A RID: 22634 RVA: 0x002805FE File Offset: 0x0027E7FE
	public void EBKGEKCIALK(PointerEventData CDMNCPMIDJP)
	{
		this.JCNHDDNLFHD = true;
		if (null != this.scrollRect)
		{
			this.scrollRect.OnBeginDrag(CDMNCPMIDJP);
		}
	}

	// Token: 0x0600586B RID: 22635 RVA: 0x00280621 File Offset: 0x0027E821
	public void OOOLKLJEBPO(PointerEventData CDMNCPMIDJP)
	{
		this.JCNHDDNLFHD = false;
		if (null != this.scrollRect)
		{
			this.scrollRect.OnBeginDrag(CDMNCPMIDJP);
		}
	}

	// Token: 0x0600586C RID: 22636 RVA: 0x00280644 File Offset: 0x0027E844
	public void DCJIOCAAECB(PointerEventData CDMNCPMIDJP)
	{
		if (null != this.scrollRect)
		{
			this.scrollRect.OnEndDrag(CDMNCPMIDJP);
		}
	}

	// Token: 0x0600586D RID: 22637 RVA: 0x002805FE File Offset: 0x0027E7FE
	public void LNBBPHAKGOM(PointerEventData CDMNCPMIDJP)
	{
		this.JCNHDDNLFHD = true;
		if (null != this.scrollRect)
		{
			this.scrollRect.OnBeginDrag(CDMNCPMIDJP);
		}
	}

	// Token: 0x0600586E RID: 22638 RVA: 0x00280621 File Offset: 0x0027E821
	public void MMGAAFGBHKL(PointerEventData CDMNCPMIDJP)
	{
		this.JCNHDDNLFHD = false;
		if (null != this.scrollRect)
		{
			this.scrollRect.OnBeginDrag(CDMNCPMIDJP);
		}
	}

	// Token: 0x0600586F RID: 22639 RVA: 0x00280644 File Offset: 0x0027E844
	public void IDBDNHKNEKP(PointerEventData CDMNCPMIDJP)
	{
		if (null != this.scrollRect)
		{
			this.scrollRect.OnEndDrag(CDMNCPMIDJP);
		}
	}

	// Token: 0x06005870 RID: 22640 RVA: 0x00280660 File Offset: 0x0027E860
	public void KNFENKKDJNA(PointerEventData CDMNCPMIDJP)
	{
		try
		{
			if (!this.JCNHDDNLFHD && CDMNCPMIDJP.button == PointerEventData.InputButton.Left)
			{
				if (!(null == this.inputField) && this.inputField.interactable)
				{
					ExecuteEvents.Execute<IPointerDownHandler>(this.inputField.gameObject, CDMNCPMIDJP, ExecuteEvents.pointerDownHandler);
					ExecuteEvents.Execute<IPointerUpHandler>(this.inputField.gameObject, CDMNCPMIDJP, ExecuteEvents.pointerUpHandler);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06005871 RID: 22641 RVA: 0x002806E4 File Offset: 0x0027E8E4
	public void HGAOOJGAEGL(PointerEventData CDMNCPMIDJP)
	{
		try
		{
			if (!this.JCNHDDNLFHD && CDMNCPMIDJP.button == PointerEventData.InputButton.Left)
			{
				if (!(null == this.inputField) && this.inputField.interactable)
				{
					ExecuteEvents.Execute<IPointerDownHandler>(this.inputField.gameObject, CDMNCPMIDJP, ExecuteEvents.pointerDownHandler);
					ExecuteEvents.Execute<IPointerUpHandler>(this.inputField.gameObject, CDMNCPMIDJP, ExecuteEvents.pointerUpHandler);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06005872 RID: 22642 RVA: 0x00280768 File Offset: 0x0027E968
	public void OnDrag(PointerEventData CDMNCPMIDJP)
	{
		this.JCNHDDNLFHD = true;
		if (null != this.scrollRect)
		{
			this.scrollRect.OnDrag(CDMNCPMIDJP);
		}
	}

	// Token: 0x06005873 RID: 22643 RVA: 0x0028078C File Offset: 0x0027E98C
	public void GOGEJEJHAEJ(PointerEventData CDMNCPMIDJP)
	{
		try
		{
			if (!this.JCNHDDNLFHD && CDMNCPMIDJP.button == PointerEventData.InputButton.Left)
			{
				if (!(null == this.inputField) && this.inputField.interactable)
				{
					ExecuteEvents.Execute<IPointerDownHandler>(this.inputField.gameObject, CDMNCPMIDJP, ExecuteEvents.pointerDownHandler);
					ExecuteEvents.Execute<IPointerUpHandler>(this.inputField.gameObject, CDMNCPMIDJP, ExecuteEvents.pointerUpHandler);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06005874 RID: 22644 RVA: 0x00280768 File Offset: 0x0027E968
	public void BMBBCHDFJHG(PointerEventData CDMNCPMIDJP)
	{
		this.JCNHDDNLFHD = true;
		if (null != this.scrollRect)
		{
			this.scrollRect.OnDrag(CDMNCPMIDJP);
		}
	}

	// Token: 0x06005875 RID: 22645 RVA: 0x00280621 File Offset: 0x0027E821
	public void ADDLPBGBELI(PointerEventData CDMNCPMIDJP)
	{
		this.JCNHDDNLFHD = false;
		if (null != this.scrollRect)
		{
			this.scrollRect.OnBeginDrag(CDMNCPMIDJP);
		}
	}

	// Token: 0x06005876 RID: 22646 RVA: 0x00280810 File Offset: 0x0027EA10
	private void IAKKINHMFNA()
	{
		try
		{
			if (null == this.inputField)
			{
				this.inputField = base.GetComponentInParent<TMP_InputField>();
			}
			if (null == this.scrollRect)
			{
				this.scrollRect = base.GetComponentInParent<ScrollRect>();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06005877 RID: 22647 RVA: 0x0028086C File Offset: 0x0027EA6C
	private void Awake()
	{
		try
		{
			if (null == this.inputField)
			{
				this.inputField = base.GetComponentInParent<TMP_InputField>();
			}
			if (null == this.scrollRect)
			{
				this.scrollRect = base.GetComponentInParent<ScrollRect>();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06005878 RID: 22648 RVA: 0x002808C8 File Offset: 0x0027EAC8
	private void AALDINEPEHJ()
	{
		try
		{
			if (null == this.inputField)
			{
				this.inputField = base.GetComponentInParent<TMP_InputField>();
			}
			if (null == this.scrollRect)
			{
				this.scrollRect = base.GetComponentInParent<ScrollRect>();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06005879 RID: 22649 RVA: 0x00280924 File Offset: 0x0027EB24
	public void LKPNDONEAPA(PointerEventData CDMNCPMIDJP)
	{
		this.JCNHDDNLFHD = false;
		if (null != this.scrollRect)
		{
			this.scrollRect.OnDrag(CDMNCPMIDJP);
		}
	}

	// Token: 0x0600587A RID: 22650 RVA: 0x00280947 File Offset: 0x0027EB47
	public void EDHBNOMCLIB(PointerEventData CDMNCPMIDJP)
	{
		this.JCNHDDNLFHD = false;
	}

	// Token: 0x0600587B RID: 22651 RVA: 0x002805F5 File Offset: 0x0027E7F5
	public void PKCJNIPHFHI(PointerEventData CDMNCPMIDJP)
	{
		this.JCNHDDNLFHD = true;
	}

	// Token: 0x0600587C RID: 22652 RVA: 0x00280621 File Offset: 0x0027E821
	public void NHHPIEOCBBM(PointerEventData CDMNCPMIDJP)
	{
		this.JCNHDDNLFHD = false;
		if (null != this.scrollRect)
		{
			this.scrollRect.OnBeginDrag(CDMNCPMIDJP);
		}
	}

	// Token: 0x0600587D RID: 22653 RVA: 0x00280950 File Offset: 0x0027EB50
	public void LFKLPLEAJFO(PointerEventData CDMNCPMIDJP)
	{
		try
		{
			if (!this.JCNHDDNLFHD && CDMNCPMIDJP.button == PointerEventData.InputButton.Left)
			{
				if (!(null == this.inputField) && this.inputField.interactable)
				{
					ExecuteEvents.Execute<IPointerDownHandler>(this.inputField.gameObject, CDMNCPMIDJP, ExecuteEvents.pointerDownHandler);
					ExecuteEvents.Execute<IPointerUpHandler>(this.inputField.gameObject, CDMNCPMIDJP, ExecuteEvents.pointerUpHandler);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600587E RID: 22654 RVA: 0x002809D4 File Offset: 0x0027EBD4
	public void DGDMAIIBKNA(PointerEventData CDMNCPMIDJP)
	{
		try
		{
			if (!this.JCNHDDNLFHD && CDMNCPMIDJP.button == PointerEventData.InputButton.Left)
			{
				if (!(null == this.inputField) && this.inputField.interactable)
				{
					ExecuteEvents.Execute<IPointerDownHandler>(this.inputField.gameObject, CDMNCPMIDJP, ExecuteEvents.pointerDownHandler);
					ExecuteEvents.Execute<IPointerUpHandler>(this.inputField.gameObject, CDMNCPMIDJP, ExecuteEvents.pointerUpHandler);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600587F RID: 22655 RVA: 0x00280947 File Offset: 0x0027EB47
	public void OnPointerDown(PointerEventData CDMNCPMIDJP)
	{
		this.JCNHDDNLFHD = false;
	}

	// Token: 0x06005880 RID: 22656 RVA: 0x002805FE File Offset: 0x0027E7FE
	public void IGFGHADKOIG(PointerEventData CDMNCPMIDJP)
	{
		this.JCNHDDNLFHD = true;
		if (null != this.scrollRect)
		{
			this.scrollRect.OnBeginDrag(CDMNCPMIDJP);
		}
	}

	// Token: 0x06005881 RID: 22657 RVA: 0x00280A58 File Offset: 0x0027EC58
	public void OnPointerClick(PointerEventData CDMNCPMIDJP)
	{
		try
		{
			if (!this.JCNHDDNLFHD && CDMNCPMIDJP.button == PointerEventData.InputButton.Left)
			{
				if (!(null == this.inputField) && this.inputField.interactable)
				{
					ExecuteEvents.Execute<IPointerDownHandler>(this.inputField.gameObject, CDMNCPMIDJP, ExecuteEvents.pointerDownHandler);
					ExecuteEvents.Execute<IPointerUpHandler>(this.inputField.gameObject, CDMNCPMIDJP, ExecuteEvents.pointerUpHandler);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06005882 RID: 22658 RVA: 0x002805F5 File Offset: 0x0027E7F5
	public void PNEDLDEIMBE(PointerEventData CDMNCPMIDJP)
	{
		this.JCNHDDNLFHD = true;
	}

	// Token: 0x06005883 RID: 22659 RVA: 0x00280947 File Offset: 0x0027EB47
	public void OJPMDCHBNOC(PointerEventData CDMNCPMIDJP)
	{
		this.JCNHDDNLFHD = false;
	}

	// Token: 0x06005884 RID: 22660 RVA: 0x00280ADC File Offset: 0x0027ECDC
	public void IBGMMAHGBAB(PointerEventData CDMNCPMIDJP)
	{
		try
		{
			if (!this.JCNHDDNLFHD && CDMNCPMIDJP.button == PointerEventData.InputButton.Left)
			{
				if (!(null == this.inputField) && this.inputField.interactable)
				{
					ExecuteEvents.Execute<IPointerDownHandler>(this.inputField.gameObject, CDMNCPMIDJP, ExecuteEvents.pointerDownHandler);
					ExecuteEvents.Execute<IPointerUpHandler>(this.inputField.gameObject, CDMNCPMIDJP, ExecuteEvents.pointerUpHandler);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06005885 RID: 22661 RVA: 0x00280644 File Offset: 0x0027E844
	public void MNGNIJECPKP(PointerEventData CDMNCPMIDJP)
	{
		if (null != this.scrollRect)
		{
			this.scrollRect.OnEndDrag(CDMNCPMIDJP);
		}
	}

	// Token: 0x06005886 RID: 22662 RVA: 0x002805FE File Offset: 0x0027E7FE
	public void NJEDDKCBCLE(PointerEventData CDMNCPMIDJP)
	{
		this.JCNHDDNLFHD = true;
		if (null != this.scrollRect)
		{
			this.scrollRect.OnBeginDrag(CDMNCPMIDJP);
		}
	}

	// Token: 0x06005887 RID: 22663 RVA: 0x002805F5 File Offset: 0x0027E7F5
	public void AOPHBANILPK(PointerEventData CDMNCPMIDJP)
	{
		this.JCNHDDNLFHD = true;
	}

	// Token: 0x06005889 RID: 22665 RVA: 0x00280B60 File Offset: 0x0027ED60
	private void NEAKAMJNFNJ()
	{
		try
		{
			if (null == this.inputField)
			{
				this.inputField = base.GetComponentInParent<TMP_InputField>();
			}
			if (null == this.scrollRect)
			{
				this.scrollRect = base.GetComponentInParent<ScrollRect>();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600588A RID: 22666 RVA: 0x002805F5 File Offset: 0x0027E7F5
	public void HOACDNMJBML(PointerEventData CDMNCPMIDJP)
	{
		this.JCNHDDNLFHD = true;
	}

	// Token: 0x0600588B RID: 22667 RVA: 0x00280BBC File Offset: 0x0027EDBC
	public void LGOIGFAFILI(PointerEventData CDMNCPMIDJP)
	{
		try
		{
			if (!this.JCNHDDNLFHD && CDMNCPMIDJP.button == PointerEventData.InputButton.Left)
			{
				if (!(null == this.inputField) && this.inputField.interactable)
				{
					ExecuteEvents.Execute<IPointerDownHandler>(this.inputField.gameObject, CDMNCPMIDJP, ExecuteEvents.pointerDownHandler);
					ExecuteEvents.Execute<IPointerUpHandler>(this.inputField.gameObject, CDMNCPMIDJP, ExecuteEvents.pointerUpHandler);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600588C RID: 22668 RVA: 0x00280C40 File Offset: 0x0027EE40
	public void NDPKHNKOLDL(PointerEventData CDMNCPMIDJP)
	{
		try
		{
			if (!this.JCNHDDNLFHD && CDMNCPMIDJP.button == PointerEventData.InputButton.Left)
			{
				if (!(null == this.inputField) && this.inputField.interactable)
				{
					ExecuteEvents.Execute<IPointerDownHandler>(this.inputField.gameObject, CDMNCPMIDJP, ExecuteEvents.pointerDownHandler);
					ExecuteEvents.Execute<IPointerUpHandler>(this.inputField.gameObject, CDMNCPMIDJP, ExecuteEvents.pointerUpHandler);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600588D RID: 22669 RVA: 0x002805F5 File Offset: 0x0027E7F5
	public void NCELEJBJEKP(PointerEventData CDMNCPMIDJP)
	{
		this.JCNHDDNLFHD = true;
	}

	// Token: 0x0600588E RID: 22670 RVA: 0x00280947 File Offset: 0x0027EB47
	public void HOKJEDBBDGB(PointerEventData CDMNCPMIDJP)
	{
		this.JCNHDDNLFHD = false;
	}

	// Token: 0x0600588F RID: 22671 RVA: 0x00280CC4 File Offset: 0x0027EEC4
	public void HAAAIBCCMDK(PointerEventData CDMNCPMIDJP)
	{
		try
		{
			if (!this.JCNHDDNLFHD && CDMNCPMIDJP.button == PointerEventData.InputButton.Left)
			{
				if (!(null == this.inputField) && this.inputField.interactable)
				{
					ExecuteEvents.Execute<IPointerDownHandler>(this.inputField.gameObject, CDMNCPMIDJP, ExecuteEvents.pointerDownHandler);
					ExecuteEvents.Execute<IPointerUpHandler>(this.inputField.gameObject, CDMNCPMIDJP, ExecuteEvents.pointerUpHandler);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06005890 RID: 22672 RVA: 0x00280644 File Offset: 0x0027E844
	public void FHNKKAONOAH(PointerEventData CDMNCPMIDJP)
	{
		if (null != this.scrollRect)
		{
			this.scrollRect.OnEndDrag(CDMNCPMIDJP);
		}
	}

	// Token: 0x06005891 RID: 22673 RVA: 0x00280D48 File Offset: 0x0027EF48
	private void MDNEOMGLGIN()
	{
		try
		{
			if (null == this.inputField)
			{
				this.inputField = base.GetComponentInParent<TMP_InputField>();
			}
			if (null == this.scrollRect)
			{
				this.scrollRect = base.GetComponentInParent<ScrollRect>();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06005892 RID: 22674 RVA: 0x00280644 File Offset: 0x0027E844
	public void CJCNPBAEDFN(PointerEventData CDMNCPMIDJP)
	{
		if (null != this.scrollRect)
		{
			this.scrollRect.OnEndDrag(CDMNCPMIDJP);
		}
	}

	// Token: 0x06005893 RID: 22675 RVA: 0x002805FE File Offset: 0x0027E7FE
	public void DCHNILAKGCI(PointerEventData CDMNCPMIDJP)
	{
		this.JCNHDDNLFHD = true;
		if (null != this.scrollRect)
		{
			this.scrollRect.OnBeginDrag(CDMNCPMIDJP);
		}
	}

	// Token: 0x06005894 RID: 22676 RVA: 0x00280DA4 File Offset: 0x0027EFA4
	public void BGIPLHEGDGO(PointerEventData CDMNCPMIDJP)
	{
		try
		{
			if (!this.JCNHDDNLFHD && CDMNCPMIDJP.button == PointerEventData.InputButton.Left)
			{
				if (!(null == this.inputField) && this.inputField.interactable)
				{
					ExecuteEvents.Execute<IPointerDownHandler>(this.inputField.gameObject, CDMNCPMIDJP, ExecuteEvents.pointerDownHandler);
					ExecuteEvents.Execute<IPointerUpHandler>(this.inputField.gameObject, CDMNCPMIDJP, ExecuteEvents.pointerUpHandler);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06005895 RID: 22677 RVA: 0x00280768 File Offset: 0x0027E968
	public void LDFBAHECCCH(PointerEventData CDMNCPMIDJP)
	{
		this.JCNHDDNLFHD = true;
		if (null != this.scrollRect)
		{
			this.scrollRect.OnDrag(CDMNCPMIDJP);
		}
	}

	// Token: 0x06005896 RID: 22678 RVA: 0x00280E28 File Offset: 0x0027F028
	private void CJOOOIECMAE()
	{
		try
		{
			if (null == this.inputField)
			{
				this.inputField = base.GetComponentInParent<TMP_InputField>();
			}
			if (null == this.scrollRect)
			{
				this.scrollRect = base.GetComponentInParent<ScrollRect>();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06005897 RID: 22679 RVA: 0x00280768 File Offset: 0x0027E968
	public void JPKGLJGHJKN(PointerEventData CDMNCPMIDJP)
	{
		this.JCNHDDNLFHD = true;
		if (null != this.scrollRect)
		{
			this.scrollRect.OnDrag(CDMNCPMIDJP);
		}
	}

	// Token: 0x06005898 RID: 22680 RVA: 0x00280E84 File Offset: 0x0027F084
	public void HDPKPFJKEML(PointerEventData CDMNCPMIDJP)
	{
		try
		{
			if (!this.JCNHDDNLFHD && CDMNCPMIDJP.button == PointerEventData.InputButton.Left)
			{
				if (!(null == this.inputField) && this.inputField.interactable)
				{
					ExecuteEvents.Execute<IPointerDownHandler>(this.inputField.gameObject, CDMNCPMIDJP, ExecuteEvents.pointerDownHandler);
					ExecuteEvents.Execute<IPointerUpHandler>(this.inputField.gameObject, CDMNCPMIDJP, ExecuteEvents.pointerUpHandler);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06005899 RID: 22681 RVA: 0x00280947 File Offset: 0x0027EB47
	public void DDKHPPJGPKN(PointerEventData CDMNCPMIDJP)
	{
		this.JCNHDDNLFHD = false;
	}

	// Token: 0x0600589A RID: 22682 RVA: 0x00280F08 File Offset: 0x0027F108
	private void CGLFKMJKOLJ()
	{
		try
		{
			if (null == this.inputField)
			{
				this.inputField = base.GetComponentInParent<TMP_InputField>();
			}
			if (null == this.scrollRect)
			{
				this.scrollRect = base.GetComponentInParent<ScrollRect>();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600589B RID: 22683 RVA: 0x00280F64 File Offset: 0x0027F164
	private void OPPNHGEMHAB()
	{
		try
		{
			if (null == this.inputField)
			{
				this.inputField = base.GetComponentInParent<TMP_InputField>();
			}
			if (null == this.scrollRect)
			{
				this.scrollRect = base.GetComponentInParent<ScrollRect>();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600589C RID: 22684 RVA: 0x00280947 File Offset: 0x0027EB47
	public void EGADABBLFNC(PointerEventData CDMNCPMIDJP)
	{
		this.JCNHDDNLFHD = false;
	}

	// Token: 0x0600589D RID: 22685 RVA: 0x00280FC0 File Offset: 0x0027F1C0
	public void FFLHGFNOELB(PointerEventData CDMNCPMIDJP)
	{
		try
		{
			if (!this.JCNHDDNLFHD && CDMNCPMIDJP.button == PointerEventData.InputButton.Left)
			{
				if (!(null == this.inputField) && this.inputField.interactable)
				{
					ExecuteEvents.Execute<IPointerDownHandler>(this.inputField.gameObject, CDMNCPMIDJP, ExecuteEvents.pointerDownHandler);
					ExecuteEvents.Execute<IPointerUpHandler>(this.inputField.gameObject, CDMNCPMIDJP, ExecuteEvents.pointerUpHandler);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600589E RID: 22686 RVA: 0x00280644 File Offset: 0x0027E844
	public void NCNGFOBLPMI(PointerEventData CDMNCPMIDJP)
	{
		if (null != this.scrollRect)
		{
			this.scrollRect.OnEndDrag(CDMNCPMIDJP);
		}
	}

	// Token: 0x0600589F RID: 22687 RVA: 0x00280768 File Offset: 0x0027E968
	public void FBOJPJJMEEL(PointerEventData CDMNCPMIDJP)
	{
		this.JCNHDDNLFHD = true;
		if (null != this.scrollRect)
		{
			this.scrollRect.OnDrag(CDMNCPMIDJP);
		}
	}

	// Token: 0x060058A0 RID: 22688 RVA: 0x00281044 File Offset: 0x0027F244
	public void NHLKIGADKMO(PointerEventData CDMNCPMIDJP)
	{
		try
		{
			if (!this.JCNHDDNLFHD && CDMNCPMIDJP.button == PointerEventData.InputButton.Left)
			{
				if (!(null == this.inputField) && this.inputField.interactable)
				{
					ExecuteEvents.Execute<IPointerDownHandler>(this.inputField.gameObject, CDMNCPMIDJP, ExecuteEvents.pointerDownHandler);
					ExecuteEvents.Execute<IPointerUpHandler>(this.inputField.gameObject, CDMNCPMIDJP, ExecuteEvents.pointerUpHandler);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060058A1 RID: 22689 RVA: 0x00280644 File Offset: 0x0027E844
	public void MPMHLEFEFBC(PointerEventData CDMNCPMIDJP)
	{
		if (null != this.scrollRect)
		{
			this.scrollRect.OnEndDrag(CDMNCPMIDJP);
		}
	}

	// Token: 0x060058A2 RID: 22690 RVA: 0x00280644 File Offset: 0x0027E844
	public void FADACNCJFDL(PointerEventData CDMNCPMIDJP)
	{
		if (null != this.scrollRect)
		{
			this.scrollRect.OnEndDrag(CDMNCPMIDJP);
		}
	}

	// Token: 0x060058A3 RID: 22691 RVA: 0x00280644 File Offset: 0x0027E844
	public void MKLGFIOFDDA(PointerEventData CDMNCPMIDJP)
	{
		if (null != this.scrollRect)
		{
			this.scrollRect.OnEndDrag(CDMNCPMIDJP);
		}
	}

	// Token: 0x060058A4 RID: 22692 RVA: 0x002805FE File Offset: 0x0027E7FE
	public void JFOBJCGMJIE(PointerEventData CDMNCPMIDJP)
	{
		this.JCNHDDNLFHD = true;
		if (null != this.scrollRect)
		{
			this.scrollRect.OnBeginDrag(CDMNCPMIDJP);
		}
	}

	// Token: 0x060058A5 RID: 22693 RVA: 0x002810C8 File Offset: 0x0027F2C8
	public void LLIKANLFHJD(PointerEventData CDMNCPMIDJP)
	{
		try
		{
			if (!this.JCNHDDNLFHD && CDMNCPMIDJP.button == PointerEventData.InputButton.Left)
			{
				if (!(null == this.inputField) && this.inputField.interactable)
				{
					ExecuteEvents.Execute<IPointerDownHandler>(this.inputField.gameObject, CDMNCPMIDJP, ExecuteEvents.pointerDownHandler);
					ExecuteEvents.Execute<IPointerUpHandler>(this.inputField.gameObject, CDMNCPMIDJP, ExecuteEvents.pointerUpHandler);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060058A6 RID: 22694 RVA: 0x0028114C File Offset: 0x0027F34C
	public void MJDGGALACFI(PointerEventData CDMNCPMIDJP)
	{
		try
		{
			if (!this.JCNHDDNLFHD && CDMNCPMIDJP.button == PointerEventData.InputButton.Left)
			{
				if (!(null == this.inputField) && this.inputField.interactable)
				{
					ExecuteEvents.Execute<IPointerDownHandler>(this.inputField.gameObject, CDMNCPMIDJP, ExecuteEvents.pointerDownHandler);
					ExecuteEvents.Execute<IPointerUpHandler>(this.inputField.gameObject, CDMNCPMIDJP, ExecuteEvents.pointerUpHandler);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060058A7 RID: 22695 RVA: 0x002805FE File Offset: 0x0027E7FE
	public void ODIDDPDIPHG(PointerEventData CDMNCPMIDJP)
	{
		this.JCNHDDNLFHD = true;
		if (null != this.scrollRect)
		{
			this.scrollRect.OnBeginDrag(CDMNCPMIDJP);
		}
	}

	// Token: 0x060058A8 RID: 22696 RVA: 0x002811D0 File Offset: 0x0027F3D0
	public void IALBEPHACLD(PointerEventData CDMNCPMIDJP)
	{
		try
		{
			if (!this.JCNHDDNLFHD && CDMNCPMIDJP.button == PointerEventData.InputButton.Left)
			{
				if (!(null == this.inputField) && this.inputField.interactable)
				{
					ExecuteEvents.Execute<IPointerDownHandler>(this.inputField.gameObject, CDMNCPMIDJP, ExecuteEvents.pointerDownHandler);
					ExecuteEvents.Execute<IPointerUpHandler>(this.inputField.gameObject, CDMNCPMIDJP, ExecuteEvents.pointerUpHandler);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060058A9 RID: 22697 RVA: 0x00281254 File Offset: 0x0027F454
	private void AMNBHDNALGO()
	{
		try
		{
			if (null == this.inputField)
			{
				this.inputField = base.GetComponentInParent<TMP_InputField>();
			}
			if (null == this.scrollRect)
			{
				this.scrollRect = base.GetComponentInParent<ScrollRect>();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060058AA RID: 22698 RVA: 0x002812B0 File Offset: 0x0027F4B0
	public void GCPBPMBFCNB(PointerEventData CDMNCPMIDJP)
	{
		try
		{
			if (!this.JCNHDDNLFHD && CDMNCPMIDJP.button == PointerEventData.InputButton.Left)
			{
				if (!(null == this.inputField) && this.inputField.interactable)
				{
					ExecuteEvents.Execute<IPointerDownHandler>(this.inputField.gameObject, CDMNCPMIDJP, ExecuteEvents.pointerDownHandler);
					ExecuteEvents.Execute<IPointerUpHandler>(this.inputField.gameObject, CDMNCPMIDJP, ExecuteEvents.pointerUpHandler);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060058AB RID: 22699 RVA: 0x00281334 File Offset: 0x0027F534
	public void FAMIFGNOICN(PointerEventData CDMNCPMIDJP)
	{
		try
		{
			if (!this.JCNHDDNLFHD && CDMNCPMIDJP.button == PointerEventData.InputButton.Left)
			{
				if (!(null == this.inputField) && this.inputField.interactable)
				{
					ExecuteEvents.Execute<IPointerDownHandler>(this.inputField.gameObject, CDMNCPMIDJP, ExecuteEvents.pointerDownHandler);
					ExecuteEvents.Execute<IPointerUpHandler>(this.inputField.gameObject, CDMNCPMIDJP, ExecuteEvents.pointerUpHandler);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060058AC RID: 22700 RVA: 0x002813B8 File Offset: 0x0027F5B8
	private void LIBECOJEBKI()
	{
		try
		{
			if (null == this.inputField)
			{
				this.inputField = base.GetComponentInParent<TMP_InputField>();
			}
			if (null == this.scrollRect)
			{
				this.scrollRect = base.GetComponentInParent<ScrollRect>();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060058AD RID: 22701 RVA: 0x00280644 File Offset: 0x0027E844
	public void KBFIOIICJHF(PointerEventData CDMNCPMIDJP)
	{
		if (null != this.scrollRect)
		{
			this.scrollRect.OnEndDrag(CDMNCPMIDJP);
		}
	}

	// Token: 0x060058AE RID: 22702 RVA: 0x00280947 File Offset: 0x0027EB47
	public void IJLHFAACGCB(PointerEventData CDMNCPMIDJP)
	{
		this.JCNHDDNLFHD = false;
	}

	// Token: 0x060058AF RID: 22703 RVA: 0x00281414 File Offset: 0x0027F614
	public void JDGGLILDNKG(PointerEventData CDMNCPMIDJP)
	{
		try
		{
			if (!this.JCNHDDNLFHD && CDMNCPMIDJP.button == PointerEventData.InputButton.Left)
			{
				if (!(null == this.inputField) && this.inputField.interactable)
				{
					ExecuteEvents.Execute<IPointerDownHandler>(this.inputField.gameObject, CDMNCPMIDJP, ExecuteEvents.pointerDownHandler);
					ExecuteEvents.Execute<IPointerUpHandler>(this.inputField.gameObject, CDMNCPMIDJP, ExecuteEvents.pointerUpHandler);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060058B0 RID: 22704 RVA: 0x00280644 File Offset: 0x0027E844
	public void INMHIJDCCGD(PointerEventData CDMNCPMIDJP)
	{
		if (null != this.scrollRect)
		{
			this.scrollRect.OnEndDrag(CDMNCPMIDJP);
		}
	}

	// Token: 0x060058B1 RID: 22705 RVA: 0x00281498 File Offset: 0x0027F698
	private void GBPFDKIIHJG()
	{
		try
		{
			if (null == this.inputField)
			{
				this.inputField = base.GetComponentInParent<TMP_InputField>();
			}
			if (null == this.scrollRect)
			{
				this.scrollRect = base.GetComponentInParent<ScrollRect>();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060058B2 RID: 22706 RVA: 0x002814F4 File Offset: 0x0027F6F4
	public void DONBLCNOGNB(PointerEventData CDMNCPMIDJP)
	{
		try
		{
			if (!this.JCNHDDNLFHD && CDMNCPMIDJP.button == PointerEventData.InputButton.Left)
			{
				if (!(null == this.inputField) && this.inputField.interactable)
				{
					ExecuteEvents.Execute<IPointerDownHandler>(this.inputField.gameObject, CDMNCPMIDJP, ExecuteEvents.pointerDownHandler);
					ExecuteEvents.Execute<IPointerUpHandler>(this.inputField.gameObject, CDMNCPMIDJP, ExecuteEvents.pointerUpHandler);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060058B3 RID: 22707 RVA: 0x002805FE File Offset: 0x0027E7FE
	public void CDOFJIKEAJJ(PointerEventData CDMNCPMIDJP)
	{
		this.JCNHDDNLFHD = true;
		if (null != this.scrollRect)
		{
			this.scrollRect.OnBeginDrag(CDMNCPMIDJP);
		}
	}

	// Token: 0x060058B4 RID: 22708 RVA: 0x00280644 File Offset: 0x0027E844
	public void OnEndDrag(PointerEventData CDMNCPMIDJP)
	{
		if (null != this.scrollRect)
		{
			this.scrollRect.OnEndDrag(CDMNCPMIDJP);
		}
	}

	// Token: 0x060058B5 RID: 22709 RVA: 0x002805FE File Offset: 0x0027E7FE
	public void OnBeginDrag(PointerEventData CDMNCPMIDJP)
	{
		this.JCNHDDNLFHD = true;
		if (null != this.scrollRect)
		{
			this.scrollRect.OnBeginDrag(CDMNCPMIDJP);
		}
	}

	// Token: 0x060058B6 RID: 22710 RVA: 0x002805F5 File Offset: 0x0027E7F5
	public void OGGINCPBBOF(PointerEventData CDMNCPMIDJP)
	{
		this.JCNHDDNLFHD = true;
	}

	// Token: 0x040018C0 RID: 6336
	public TMP_InputField inputField;

	// Token: 0x040018C1 RID: 6337
	public ScrollRect scrollRect;

	// Token: 0x040018C2 RID: 6338
	private bool JCNHDDNLFHD;
}
