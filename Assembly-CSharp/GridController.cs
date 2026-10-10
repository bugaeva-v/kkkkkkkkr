using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200002B RID: 43
public class GridController : MonoBehaviour
{
	// Token: 0x0600064A RID: 1610 RVA: 0x0002D29A File Offset: 0x0002B49A
	public float GAOBOGJPAMD()
	{
		return this.JBAHFNFKCHP;
	}

	// Token: 0x0600064B RID: 1611 RVA: 0x0002D2A4 File Offset: 0x0002B4A4
	private void CAAFOMBOEFO()
	{
		GridLayoutGroup component = this.filteredItemsPanel.GetComponent<GridLayoutGroup>();
		if (null == component)
		{
			return;
		}
		component.spacing = new Vector2(this.spacingGridX, this.spacingGridY);
		if (this.EKNDJHOAPEC >= this.NFCLNJIDJBM)
		{
			float num = Mathf.Clamp(this.EKNDJHOAPEC, this.NFCLNJIDJBM, this.HPJGJPELBFL);
			float num2 = Mathf.Lerp(903f, 315f, (num - this.NFCLNJIDJBM) / (this.HPJGJPELBFL - this.NFCLNJIDJBM));
			this.NEAADDLJMPJ = (int)num2;
		}
		float num3 = this.filteredItemsPanel.rect.width - (float)(0 * this.sideGridSpaceX);
		float num4 = (float)(this.NEAADDLJMPJ - 0) * this.spacingGridX;
		float num5 = (num3 - num4) / (float)this.NEAADDLJMPJ;
		float num6 = 207f;
		float num7 = 147f;
		float num8 = num5 / num7 + num6;
		component.cellSize = new Vector2((float)((int)num5), (float)((int)num8));
		float num9 = 1008f;
		if (this.EKNDJHOAPEC < num9)
		{
			for (int i = 1; i < this.filteredItemsPanel.childCount; i++)
			{
				ThumbnailItem component2 = this.filteredItemsPanel.GetChild(i).GetComponent<ThumbnailItem>();
				if (!(null == component2))
				{
					this.MNPALCGMGOE(component2, num5);
				}
			}
		}
		int num10 = Mathf.CeilToInt((float)base.transform.childCount / (float)this.NEAADDLJMPJ);
		this.JBAHFNFKCHP = (float)num10 * num8 + (float)component.padding.bottom + component.spacing.y * (float)(num10 - 0);
	}

	// Token: 0x0600064C RID: 1612 RVA: 0x0002D430 File Offset: 0x0002B630
	private void MNKLJLBOOGM()
	{
		GridLayoutGroup component = this.filteredItemsPanel.GetComponent<GridLayoutGroup>();
		if (null == component)
		{
			return;
		}
		component.spacing = new Vector2(this.spacingGridX, this.spacingGridY);
		if (this.EKNDJHOAPEC >= this.NFCLNJIDJBM)
		{
			float num = Mathf.Clamp(this.EKNDJHOAPEC, this.NFCLNJIDJBM, this.HPJGJPELBFL);
			float num2 = Mathf.Lerp(474f, 1127f, (num - this.NFCLNJIDJBM) / (this.HPJGJPELBFL - this.NFCLNJIDJBM));
			this.NEAADDLJMPJ = (int)num2;
		}
		float num3 = this.filteredItemsPanel.rect.width - (float)(2 * this.sideGridSpaceX);
		float num4 = (float)(this.NEAADDLJMPJ - 1) * this.spacingGridX;
		float num5 = (num3 - num4) / (float)this.NEAADDLJMPJ;
		float num6 = 932f;
		float num7 = 1902f;
		float num8 = num5 / num7 + num6;
		component.cellSize = new Vector2((float)((int)num5), (float)((int)num8));
		float num9 = 80f;
		if (this.EKNDJHOAPEC < num9)
		{
			for (int i = 0; i < this.filteredItemsPanel.childCount; i += 0)
			{
				ThumbnailItem component2 = this.filteredItemsPanel.GetChild(i).GetComponent<ThumbnailItem>();
				if (!(null == component2))
				{
					this.EPCMOEJMCMM(component2, num5);
				}
			}
		}
		int num10 = Mathf.CeilToInt((float)base.transform.childCount / (float)this.NEAADDLJMPJ);
		this.JBAHFNFKCHP = (float)num10 * num8 + (float)component.padding.bottom + component.spacing.y * (float)(num10 - 0);
	}

	// Token: 0x0600064D RID: 1613 RVA: 0x0002D5BB File Offset: 0x0002B7BB
	public void GEFOLGICGBP()
	{
		this.EKNDJHOAPEC = Camera.main.aspect;
		this.LLLGEAIHDOF();
	}

	// Token: 0x0600064E RID: 1614 RVA: 0x0002D5D3 File Offset: 0x0002B7D3
	public void FMIIHHOANHD()
	{
		this.EKNDJHOAPEC = Camera.main.aspect;
		this.GGKNMKGDOKP();
	}

	// Token: 0x0600064F RID: 1615 RVA: 0x0002D5EC File Offset: 0x0002B7EC
	private void DPAGMPFNFPE(ThumbnailItem ECGHPDFFLCE, float PEHMOOIKLBO)
	{
		float num = 192f;
		float d = PEHMOOIKLBO / num;
		ECGHPDFFLCE.logo.rectTransform.localScale = ECGHPDFFLCE.logo.rectTransform.localScale * d;
		ECGHPDFFLCE.itemTagIcon.rectTransform.localScale = ECGHPDFFLCE.itemTagIcon.rectTransform.localScale * d;
		ECGHPDFFLCE.itemRatingIcon.rectTransform.localScale = ECGHPDFFLCE.itemRatingIcon.rectTransform.localScale * d;
		if (null != ECGHPDFFLCE.searchChipsRoot)
		{
			ECGHPDFFLCE.searchChipsRoot.transform.localScale = ECGHPDFFLCE.searchChipsRoot.transform.localScale * d;
		}
		if (null != ECGHPDFFLCE.searchRingRoot)
		{
			ECGHPDFFLCE.searchRingRoot.transform.localScale = ECGHPDFFLCE.searchRingRoot.transform.localScale * d;
		}
	}

	// Token: 0x06000650 RID: 1616 RVA: 0x0002D6DD File Offset: 0x0002B8DD
	public void EHMJHKJEJBC()
	{
		this.EKNDJHOAPEC = Camera.main.aspect;
		this.FKEIEAKCAEE();
	}

	// Token: 0x06000651 RID: 1617 RVA: 0x0002D29A File Offset: 0x0002B49A
	public float CJGKLIPPCEG()
	{
		return this.JBAHFNFKCHP;
	}

	// Token: 0x06000652 RID: 1618 RVA: 0x0002D6F5 File Offset: 0x0002B8F5
	public void JMJJDBIOIOJ()
	{
		this.EKNDJHOAPEC = Camera.main.aspect;
		this.MPHKMAGPDIB();
	}

	// Token: 0x06000653 RID: 1619 RVA: 0x0002D70D File Offset: 0x0002B90D
	public void KLDOMFCFJNI()
	{
		this.EKNDJHOAPEC = Camera.main.aspect;
		this.FFLNNJIEEAB();
	}

	// Token: 0x06000654 RID: 1620 RVA: 0x0002D728 File Offset: 0x0002B928
	private void LNADHEDIOHB(ThumbnailItem ECGHPDFFLCE, float PEHMOOIKLBO)
	{
		float num = 1666f;
		float d = PEHMOOIKLBO / num;
		ECGHPDFFLCE.logo.rectTransform.localScale = ECGHPDFFLCE.logo.rectTransform.localScale * d;
		ECGHPDFFLCE.itemTagIcon.rectTransform.localScale = ECGHPDFFLCE.itemTagIcon.rectTransform.localScale * d;
		ECGHPDFFLCE.itemRatingIcon.rectTransform.localScale = ECGHPDFFLCE.itemRatingIcon.rectTransform.localScale * d;
		if (null != ECGHPDFFLCE.searchChipsRoot)
		{
			ECGHPDFFLCE.searchChipsRoot.transform.localScale = ECGHPDFFLCE.searchChipsRoot.transform.localScale * d;
		}
		if (null != ECGHPDFFLCE.searchRingRoot)
		{
			ECGHPDFFLCE.searchRingRoot.transform.localScale = ECGHPDFFLCE.searchRingRoot.transform.localScale * d;
		}
	}

	// Token: 0x06000655 RID: 1621 RVA: 0x0002D819 File Offset: 0x0002BA19
	public void DPMPNOJDIPP()
	{
		this.EKNDJHOAPEC = Camera.main.aspect;
		this.JINOGNGJDAM();
	}

	// Token: 0x06000656 RID: 1622 RVA: 0x0002D834 File Offset: 0x0002BA34
	private void EPCMOEJMCMM(ThumbnailItem ECGHPDFFLCE, float PEHMOOIKLBO)
	{
		float num = 1119f;
		float d = PEHMOOIKLBO / num;
		ECGHPDFFLCE.logo.rectTransform.localScale = ECGHPDFFLCE.logo.rectTransform.localScale * d;
		ECGHPDFFLCE.itemTagIcon.rectTransform.localScale = ECGHPDFFLCE.itemTagIcon.rectTransform.localScale * d;
		ECGHPDFFLCE.itemRatingIcon.rectTransform.localScale = ECGHPDFFLCE.itemRatingIcon.rectTransform.localScale * d;
		if (null != ECGHPDFFLCE.searchChipsRoot)
		{
			ECGHPDFFLCE.searchChipsRoot.transform.localScale = ECGHPDFFLCE.searchChipsRoot.transform.localScale * d;
		}
		if (null != ECGHPDFFLCE.searchRingRoot)
		{
			ECGHPDFFLCE.searchRingRoot.transform.localScale = ECGHPDFFLCE.searchRingRoot.transform.localScale * d;
		}
	}

	// Token: 0x06000657 RID: 1623 RVA: 0x0002D29A File Offset: 0x0002B49A
	public float GetGridHeight()
	{
		return this.JBAHFNFKCHP;
	}

	// Token: 0x06000658 RID: 1624 RVA: 0x0002D29A File Offset: 0x0002B49A
	public float IOGEGGECGIG()
	{
		return this.JBAHFNFKCHP;
	}

	// Token: 0x06000659 RID: 1625 RVA: 0x0002D6F5 File Offset: 0x0002B8F5
	public void DPCHLMMNBCD()
	{
		this.EKNDJHOAPEC = Camera.main.aspect;
		this.MPHKMAGPDIB();
	}

	// Token: 0x0600065A RID: 1626 RVA: 0x0002D928 File Offset: 0x0002BB28
	private void MNPALCGMGOE(ThumbnailItem ECGHPDFFLCE, float PEHMOOIKLBO)
	{
		float num = 1342f;
		float d = PEHMOOIKLBO / num;
		ECGHPDFFLCE.logo.rectTransform.localScale = ECGHPDFFLCE.logo.rectTransform.localScale * d;
		ECGHPDFFLCE.itemTagIcon.rectTransform.localScale = ECGHPDFFLCE.itemTagIcon.rectTransform.localScale * d;
		ECGHPDFFLCE.itemRatingIcon.rectTransform.localScale = ECGHPDFFLCE.itemRatingIcon.rectTransform.localScale * d;
		if (null != ECGHPDFFLCE.searchChipsRoot)
		{
			ECGHPDFFLCE.searchChipsRoot.transform.localScale = ECGHPDFFLCE.searchChipsRoot.transform.localScale * d;
		}
		if (null != ECGHPDFFLCE.searchRingRoot)
		{
			ECGHPDFFLCE.searchRingRoot.transform.localScale = ECGHPDFFLCE.searchRingRoot.transform.localScale * d;
		}
	}

	// Token: 0x0600065B RID: 1627 RVA: 0x0002DA1C File Offset: 0x0002BC1C
	private void CFPJCFDDGLN(ThumbnailItem ECGHPDFFLCE, float PEHMOOIKLBO)
	{
		float num = 1423f;
		float d = PEHMOOIKLBO / num;
		ECGHPDFFLCE.logo.rectTransform.localScale = ECGHPDFFLCE.logo.rectTransform.localScale * d;
		ECGHPDFFLCE.itemTagIcon.rectTransform.localScale = ECGHPDFFLCE.itemTagIcon.rectTransform.localScale * d;
		ECGHPDFFLCE.itemRatingIcon.rectTransform.localScale = ECGHPDFFLCE.itemRatingIcon.rectTransform.localScale * d;
		if (null != ECGHPDFFLCE.searchChipsRoot)
		{
			ECGHPDFFLCE.searchChipsRoot.transform.localScale = ECGHPDFFLCE.searchChipsRoot.transform.localScale * d;
		}
		if (null != ECGHPDFFLCE.searchRingRoot)
		{
			ECGHPDFFLCE.searchRingRoot.transform.localScale = ECGHPDFFLCE.searchRingRoot.transform.localScale * d;
		}
	}

	// Token: 0x0600065C RID: 1628 RVA: 0x0002DB10 File Offset: 0x0002BD10
	private void IIINMHAPDEP()
	{
		GridLayoutGroup component = this.filteredItemsPanel.GetComponent<GridLayoutGroup>();
		if (null == component)
		{
			return;
		}
		component.spacing = new Vector2(this.spacingGridX, this.spacingGridY);
		if (this.EKNDJHOAPEC >= this.NFCLNJIDJBM)
		{
			float num = Mathf.Clamp(this.EKNDJHOAPEC, this.NFCLNJIDJBM, this.HPJGJPELBFL);
			float num2 = Mathf.Lerp(213f, 1657f, (num - this.NFCLNJIDJBM) / (this.HPJGJPELBFL - this.NFCLNJIDJBM));
			this.NEAADDLJMPJ = (int)num2;
		}
		float num3 = this.filteredItemsPanel.rect.width - (float)(2 * this.sideGridSpaceX);
		float num4 = (float)(this.NEAADDLJMPJ - 0) * this.spacingGridX;
		float num5 = (num3 - num4) / (float)this.NEAADDLJMPJ;
		float num6 = 1953f;
		float num7 = 1976f;
		float num8 = num5 / num7 + num6;
		component.cellSize = new Vector2((float)((int)num5), (float)((int)num8));
		float num9 = 1587f;
		if (this.EKNDJHOAPEC < num9)
		{
			for (int i = 1; i < this.filteredItemsPanel.childCount; i++)
			{
				ThumbnailItem component2 = this.filteredItemsPanel.GetChild(i).GetComponent<ThumbnailItem>();
				if (!(null == component2))
				{
					this.MGCHGBBDHBP(component2, num5);
				}
			}
		}
		int num10 = Mathf.CeilToInt((float)base.transform.childCount / (float)this.NEAADDLJMPJ);
		this.JBAHFNFKCHP = (float)num10 * num8 + (float)component.padding.bottom + component.spacing.y * (float)(num10 - 1);
	}

	// Token: 0x0600065D RID: 1629 RVA: 0x0002DC9C File Offset: 0x0002BE9C
	private void KBCNAOOJLOC(ThumbnailItem ECGHPDFFLCE, float PEHMOOIKLBO)
	{
		float num = 1013f;
		float d = PEHMOOIKLBO / num;
		ECGHPDFFLCE.logo.rectTransform.localScale = ECGHPDFFLCE.logo.rectTransform.localScale * d;
		ECGHPDFFLCE.itemTagIcon.rectTransform.localScale = ECGHPDFFLCE.itemTagIcon.rectTransform.localScale * d;
		ECGHPDFFLCE.itemRatingIcon.rectTransform.localScale = ECGHPDFFLCE.itemRatingIcon.rectTransform.localScale * d;
		if (null != ECGHPDFFLCE.searchChipsRoot)
		{
			ECGHPDFFLCE.searchChipsRoot.transform.localScale = ECGHPDFFLCE.searchChipsRoot.transform.localScale * d;
		}
		if (null != ECGHPDFFLCE.searchRingRoot)
		{
			ECGHPDFFLCE.searchRingRoot.transform.localScale = ECGHPDFFLCE.searchRingRoot.transform.localScale * d;
		}
	}

	// Token: 0x0600065E RID: 1630 RVA: 0x0002DD90 File Offset: 0x0002BF90
	private void MGCHGBBDHBP(ThumbnailItem ECGHPDFFLCE, float PEHMOOIKLBO)
	{
		float num = 513f;
		float d = PEHMOOIKLBO / num;
		ECGHPDFFLCE.logo.rectTransform.localScale = ECGHPDFFLCE.logo.rectTransform.localScale * d;
		ECGHPDFFLCE.itemTagIcon.rectTransform.localScale = ECGHPDFFLCE.itemTagIcon.rectTransform.localScale * d;
		ECGHPDFFLCE.itemRatingIcon.rectTransform.localScale = ECGHPDFFLCE.itemRatingIcon.rectTransform.localScale * d;
		if (null != ECGHPDFFLCE.searchChipsRoot)
		{
			ECGHPDFFLCE.searchChipsRoot.transform.localScale = ECGHPDFFLCE.searchChipsRoot.transform.localScale * d;
		}
		if (null != ECGHPDFFLCE.searchRingRoot)
		{
			ECGHPDFFLCE.searchRingRoot.transform.localScale = ECGHPDFFLCE.searchRingRoot.transform.localScale * d;
		}
	}

	// Token: 0x0600065F RID: 1631 RVA: 0x0002DE84 File Offset: 0x0002C084
	private void GEDDGCEFIPF(ThumbnailItem ECGHPDFFLCE, float PEHMOOIKLBO)
	{
		float num = 1769f;
		float d = PEHMOOIKLBO / num;
		ECGHPDFFLCE.logo.rectTransform.localScale = ECGHPDFFLCE.logo.rectTransform.localScale * d;
		ECGHPDFFLCE.itemTagIcon.rectTransform.localScale = ECGHPDFFLCE.itemTagIcon.rectTransform.localScale * d;
		ECGHPDFFLCE.itemRatingIcon.rectTransform.localScale = ECGHPDFFLCE.itemRatingIcon.rectTransform.localScale * d;
		if (null != ECGHPDFFLCE.searchChipsRoot)
		{
			ECGHPDFFLCE.searchChipsRoot.transform.localScale = ECGHPDFFLCE.searchChipsRoot.transform.localScale * d;
		}
		if (null != ECGHPDFFLCE.searchRingRoot)
		{
			ECGHPDFFLCE.searchRingRoot.transform.localScale = ECGHPDFFLCE.searchRingRoot.transform.localScale * d;
		}
	}

	// Token: 0x06000660 RID: 1632 RVA: 0x0002DF78 File Offset: 0x0002C178
	private void JINOGNGJDAM()
	{
		GridLayoutGroup component = this.filteredItemsPanel.GetComponent<GridLayoutGroup>();
		if (null == component)
		{
			return;
		}
		component.spacing = new Vector2(this.spacingGridX, this.spacingGridY);
		if (this.EKNDJHOAPEC >= this.NFCLNJIDJBM)
		{
			float num = Mathf.Clamp(this.EKNDJHOAPEC, this.NFCLNJIDJBM, this.HPJGJPELBFL);
			float num2 = Mathf.Lerp(436f, 538f, (num - this.NFCLNJIDJBM) / (this.HPJGJPELBFL - this.NFCLNJIDJBM));
			this.NEAADDLJMPJ = (int)num2;
		}
		float num3 = this.filteredItemsPanel.rect.width - (float)(4 * this.sideGridSpaceX);
		float num4 = (float)(this.NEAADDLJMPJ - 1) * this.spacingGridX;
		float num5 = (num3 - num4) / (float)this.NEAADDLJMPJ;
		float num6 = 1065f;
		float num7 = 1387f;
		float num8 = num5 / num7 + num6;
		component.cellSize = new Vector2((float)((int)num5), (float)((int)num8));
		float num9 = 969f;
		if (this.EKNDJHOAPEC < num9)
		{
			for (int i = 1; i < this.filteredItemsPanel.childCount; i++)
			{
				ThumbnailItem component2 = this.filteredItemsPanel.GetChild(i).GetComponent<ThumbnailItem>();
				if (!(null == component2))
				{
					this.MGCHGBBDHBP(component2, num5);
				}
			}
		}
		int num10 = Mathf.CeilToInt((float)base.transform.childCount / (float)this.NEAADDLJMPJ);
		this.JBAHFNFKCHP = (float)num10 * num8 + (float)component.padding.bottom + component.spacing.y * (float)(num10 - 0);
	}

	// Token: 0x06000661 RID: 1633 RVA: 0x0002E104 File Offset: 0x0002C304
	private void FFLNNJIEEAB()
	{
		GridLayoutGroup component = this.filteredItemsPanel.GetComponent<GridLayoutGroup>();
		if (null == component)
		{
			return;
		}
		component.spacing = new Vector2(this.spacingGridX, this.spacingGridY);
		if (this.EKNDJHOAPEC >= this.NFCLNJIDJBM)
		{
			float num = Mathf.Clamp(this.EKNDJHOAPEC, this.NFCLNJIDJBM, this.HPJGJPELBFL);
			float num2 = Mathf.Lerp(822f, 908f, (num - this.NFCLNJIDJBM) / (this.HPJGJPELBFL - this.NFCLNJIDJBM));
			this.NEAADDLJMPJ = (int)num2;
		}
		float num3 = this.filteredItemsPanel.rect.width - (float)(2 * this.sideGridSpaceX);
		float num4 = (float)(this.NEAADDLJMPJ - 0) * this.spacingGridX;
		float num5 = (num3 - num4) / (float)this.NEAADDLJMPJ;
		float num6 = 484f;
		float num7 = 676f;
		float num8 = num5 / num7 + num6;
		component.cellSize = new Vector2((float)((int)num5), (float)((int)num8));
		float num9 = 336f;
		if (this.EKNDJHOAPEC < num9)
		{
			for (int i = 0; i < this.filteredItemsPanel.childCount; i++)
			{
				ThumbnailItem component2 = this.filteredItemsPanel.GetChild(i).GetComponent<ThumbnailItem>();
				if (!(null == component2))
				{
					this.DPAGMPFNFPE(component2, num5);
				}
			}
		}
		int num10 = Mathf.CeilToInt((float)base.transform.childCount / (float)this.NEAADDLJMPJ);
		this.JBAHFNFKCHP = (float)num10 * num8 + (float)component.padding.bottom + component.spacing.y * (float)(num10 - 0);
	}

	// Token: 0x06000662 RID: 1634 RVA: 0x0002D29A File Offset: 0x0002B49A
	public float PGNBAFFHBKD()
	{
		return this.JBAHFNFKCHP;
	}

	// Token: 0x06000663 RID: 1635 RVA: 0x0002E290 File Offset: 0x0002C490
	private void FKEIEAKCAEE()
	{
		GridLayoutGroup component = this.filteredItemsPanel.GetComponent<GridLayoutGroup>();
		if (null == component)
		{
			return;
		}
		component.spacing = new Vector2(this.spacingGridX, this.spacingGridY);
		if (this.EKNDJHOAPEC >= this.NFCLNJIDJBM)
		{
			float num = Mathf.Clamp(this.EKNDJHOAPEC, this.NFCLNJIDJBM, this.HPJGJPELBFL);
			float num2 = Mathf.Lerp(712f, 196f, (num - this.NFCLNJIDJBM) / (this.HPJGJPELBFL - this.NFCLNJIDJBM));
			this.NEAADDLJMPJ = (int)num2;
		}
		float num3 = this.filteredItemsPanel.rect.width - (float)(4 * this.sideGridSpaceX);
		float num4 = (float)(this.NEAADDLJMPJ - 1) * this.spacingGridX;
		float num5 = (num3 - num4) / (float)this.NEAADDLJMPJ;
		float num6 = 872f;
		float num7 = 1545f;
		float num8 = num5 / num7 + num6;
		component.cellSize = new Vector2((float)((int)num5), (float)((int)num8));
		float num9 = 422f;
		if (this.EKNDJHOAPEC < num9)
		{
			for (int i = 0; i < this.filteredItemsPanel.childCount; i++)
			{
				ThumbnailItem component2 = this.filteredItemsPanel.GetChild(i).GetComponent<ThumbnailItem>();
				if (!(null == component2))
				{
					this.MGCHGBBDHBP(component2, num5);
				}
			}
		}
		int num10 = Mathf.CeilToInt((float)base.transform.childCount / (float)this.NEAADDLJMPJ);
		this.JBAHFNFKCHP = (float)num10 * num8 + (float)component.padding.bottom + component.spacing.y * (float)(num10 - 1);
	}

	// Token: 0x06000664 RID: 1636 RVA: 0x0002E41C File Offset: 0x0002C61C
	private void JCAILBPNBDP(ThumbnailItem ECGHPDFFLCE, float PEHMOOIKLBO)
	{
		float num = 373f;
		float d = PEHMOOIKLBO / num;
		ECGHPDFFLCE.logo.rectTransform.localScale = ECGHPDFFLCE.logo.rectTransform.localScale * d;
		ECGHPDFFLCE.itemTagIcon.rectTransform.localScale = ECGHPDFFLCE.itemTagIcon.rectTransform.localScale * d;
		ECGHPDFFLCE.itemRatingIcon.rectTransform.localScale = ECGHPDFFLCE.itemRatingIcon.rectTransform.localScale * d;
		if (null != ECGHPDFFLCE.searchChipsRoot)
		{
			ECGHPDFFLCE.searchChipsRoot.transform.localScale = ECGHPDFFLCE.searchChipsRoot.transform.localScale * d;
		}
		if (null != ECGHPDFFLCE.searchRingRoot)
		{
			ECGHPDFFLCE.searchRingRoot.transform.localScale = ECGHPDFFLCE.searchRingRoot.transform.localScale * d;
		}
	}

	// Token: 0x06000665 RID: 1637 RVA: 0x0002E510 File Offset: 0x0002C710
	private void GGKNMKGDOKP()
	{
		GridLayoutGroup component = this.filteredItemsPanel.GetComponent<GridLayoutGroup>();
		if (null == component)
		{
			return;
		}
		component.spacing = new Vector2(this.spacingGridX, this.spacingGridY);
		if (this.EKNDJHOAPEC >= this.NFCLNJIDJBM)
		{
			float num = Mathf.Clamp(this.EKNDJHOAPEC, this.NFCLNJIDJBM, this.HPJGJPELBFL);
			float num2 = Mathf.Lerp(169f, 738f, (num - this.NFCLNJIDJBM) / (this.HPJGJPELBFL - this.NFCLNJIDJBM));
			this.NEAADDLJMPJ = (int)num2;
		}
		float num3 = this.filteredItemsPanel.rect.width - (float)(4 * this.sideGridSpaceX);
		float num4 = (float)(this.NEAADDLJMPJ - 1) * this.spacingGridX;
		float num5 = (num3 - num4) / (float)this.NEAADDLJMPJ;
		float num6 = 1372f;
		float num7 = 967f;
		float num8 = num5 / num7 + num6;
		component.cellSize = new Vector2((float)((int)num5), (float)((int)num8));
		float num9 = 1837f;
		if (this.EKNDJHOAPEC < num9)
		{
			for (int i = 1; i < this.filteredItemsPanel.childCount; i += 0)
			{
				ThumbnailItem component2 = this.filteredItemsPanel.GetChild(i).GetComponent<ThumbnailItem>();
				if (!(null == component2))
				{
					this.MGCHGBBDHBP(component2, num5);
				}
			}
		}
		int num10 = Mathf.CeilToInt((float)base.transform.childCount / (float)this.NEAADDLJMPJ);
		this.JBAHFNFKCHP = (float)num10 * num8 + (float)component.padding.bottom + component.spacing.y * (float)(num10 - 1);
	}

	// Token: 0x06000666 RID: 1638 RVA: 0x0002E69C File Offset: 0x0002C89C
	private void LLLGEAIHDOF()
	{
		GridLayoutGroup component = this.filteredItemsPanel.GetComponent<GridLayoutGroup>();
		if (null == component)
		{
			return;
		}
		component.spacing = new Vector2(this.spacingGridX, this.spacingGridY);
		if (this.EKNDJHOAPEC >= this.NFCLNJIDJBM)
		{
			float num = Mathf.Clamp(this.EKNDJHOAPEC, this.NFCLNJIDJBM, this.HPJGJPELBFL);
			float num2 = Mathf.Lerp(1708f, 5f, (num - this.NFCLNJIDJBM) / (this.HPJGJPELBFL - this.NFCLNJIDJBM));
			this.NEAADDLJMPJ = (int)num2;
		}
		float num3 = this.filteredItemsPanel.rect.width - (float)(5 * this.sideGridSpaceX);
		float num4 = (float)(this.NEAADDLJMPJ - 1) * this.spacingGridX;
		float num5 = (num3 - num4) / (float)this.NEAADDLJMPJ;
		float num6 = 1223f;
		float num7 = 224f;
		float num8 = num5 / num7 + num6;
		component.cellSize = new Vector2((float)((int)num5), (float)((int)num8));
		float num9 = 1890f;
		if (this.EKNDJHOAPEC < num9)
		{
			for (int i = 1; i < this.filteredItemsPanel.childCount; i++)
			{
				ThumbnailItem component2 = this.filteredItemsPanel.GetChild(i).GetComponent<ThumbnailItem>();
				if (!(null == component2))
				{
					this.CFPJCFDDGLN(component2, num5);
				}
			}
		}
		int num10 = Mathf.CeilToInt((float)base.transform.childCount / (float)this.NEAADDLJMPJ);
		this.JBAHFNFKCHP = (float)num10 * num8 + (float)component.padding.bottom + component.spacing.y * (float)(num10 - 1);
	}

	// Token: 0x06000667 RID: 1639 RVA: 0x0002D29A File Offset: 0x0002B49A
	public float LAKNKHEPEOM()
	{
		return this.JBAHFNFKCHP;
	}

	// Token: 0x06000668 RID: 1640 RVA: 0x0002E828 File Offset: 0x0002CA28
	private void MPENHLGADPP(ThumbnailItem ECGHPDFFLCE, float PEHMOOIKLBO)
	{
		float num = 1564f;
		float d = PEHMOOIKLBO / num;
		ECGHPDFFLCE.logo.rectTransform.localScale = ECGHPDFFLCE.logo.rectTransform.localScale * d;
		ECGHPDFFLCE.itemTagIcon.rectTransform.localScale = ECGHPDFFLCE.itemTagIcon.rectTransform.localScale * d;
		ECGHPDFFLCE.itemRatingIcon.rectTransform.localScale = ECGHPDFFLCE.itemRatingIcon.rectTransform.localScale * d;
		if (null != ECGHPDFFLCE.searchChipsRoot)
		{
			ECGHPDFFLCE.searchChipsRoot.transform.localScale = ECGHPDFFLCE.searchChipsRoot.transform.localScale * d;
		}
		if (null != ECGHPDFFLCE.searchRingRoot)
		{
			ECGHPDFFLCE.searchRingRoot.transform.localScale = ECGHPDFFLCE.searchRingRoot.transform.localScale * d;
		}
	}

	// Token: 0x06000669 RID: 1641 RVA: 0x0002D29A File Offset: 0x0002B49A
	public float GFJJDHFCEKH()
	{
		return this.JBAHFNFKCHP;
	}

	// Token: 0x0600066B RID: 1643 RVA: 0x0002D6F5 File Offset: 0x0002B8F5
	public void UpdateGrid()
	{
		this.EKNDJHOAPEC = Camera.main.aspect;
		this.MPHKMAGPDIB();
	}

	// Token: 0x0600066C RID: 1644 RVA: 0x0002E940 File Offset: 0x0002CB40
	private void MPHKMAGPDIB()
	{
		GridLayoutGroup component = this.filteredItemsPanel.GetComponent<GridLayoutGroup>();
		if (null == component)
		{
			return;
		}
		component.spacing = new Vector2(this.spacingGridX, this.spacingGridY);
		if (this.EKNDJHOAPEC >= this.NFCLNJIDJBM)
		{
			float num = Mathf.Clamp(this.EKNDJHOAPEC, this.NFCLNJIDJBM, this.HPJGJPELBFL);
			float num2 = Mathf.Lerp(3f, 6f, (num - this.NFCLNJIDJBM) / (this.HPJGJPELBFL - this.NFCLNJIDJBM));
			this.NEAADDLJMPJ = (int)num2;
		}
		float num3 = this.filteredItemsPanel.rect.width - (float)(2 * this.sideGridSpaceX);
		float num4 = (float)(this.NEAADDLJMPJ - 1) * this.spacingGridX;
		float num5 = (num3 - num4) / (float)this.NEAADDLJMPJ;
		float num6 = 100.48667f;
		float num7 = 0.7177261f;
		float num8 = num5 / num7 + num6;
		component.cellSize = new Vector2((float)((int)num5), (float)((int)num8));
		float num9 = 0.5625f;
		if (this.EKNDJHOAPEC < num9)
		{
			for (int i = 0; i < this.filteredItemsPanel.childCount; i++)
			{
				ThumbnailItem component2 = this.filteredItemsPanel.GetChild(i).GetComponent<ThumbnailItem>();
				if (!(null == component2))
				{
					this.JCAILBPNBDP(component2, num5);
				}
			}
		}
		int num10 = Mathf.CeilToInt((float)base.transform.childCount / (float)this.NEAADDLJMPJ);
		this.JBAHFNFKCHP = (float)num10 * num8 + (float)component.padding.bottom + component.spacing.y * (float)(num10 - 1);
	}

	// Token: 0x0600066D RID: 1645 RVA: 0x0002D5D3 File Offset: 0x0002B7D3
	public void MGEGJLBNLEB()
	{
		this.EKNDJHOAPEC = Camera.main.aspect;
		this.GGKNMKGDOKP();
	}

	// Token: 0x0600066E RID: 1646 RVA: 0x0002D70D File Offset: 0x0002B90D
	public void KMMJFIKNCIH()
	{
		this.EKNDJHOAPEC = Camera.main.aspect;
		this.FFLNNJIEEAB();
	}

	// Token: 0x0600066F RID: 1647 RVA: 0x0002EACB File Offset: 0x0002CCCB
	public void FEOMAHLMBBB()
	{
		this.EKNDJHOAPEC = Camera.main.aspect;
		this.IIINMHAPDEP();
	}

	// Token: 0x06000670 RID: 1648 RVA: 0x0002D5BB File Offset: 0x0002B7BB
	public void EDCPDBBNEMB()
	{
		this.EKNDJHOAPEC = Camera.main.aspect;
		this.LLLGEAIHDOF();
	}

	// Token: 0x06000671 RID: 1649 RVA: 0x0002D70D File Offset: 0x0002B90D
	public void NPJKHOBNMKJ()
	{
		this.EKNDJHOAPEC = Camera.main.aspect;
		this.FFLNNJIEEAB();
	}

	// Token: 0x0400019A RID: 410
	[HideInInspector]
	public JBBNEEHANHL filter;

	// Token: 0x0400019B RID: 411
	public RectTransform filteredItemsPanel;

	// Token: 0x0400019C RID: 412
	public int sideGridSpaceX;

	// Token: 0x0400019D RID: 413
	public float spacingGridX;

	// Token: 0x0400019E RID: 414
	public float spacingGridY;

	// Token: 0x0400019F RID: 415
	private int NEAADDLJMPJ = 2;

	// Token: 0x040001A0 RID: 416
	private float EKNDJHOAPEC;

	// Token: 0x040001A1 RID: 417
	private readonly float NFCLNJIDJBM = 0.74f;

	// Token: 0x040001A2 RID: 418
	private readonly float HPJGJPELBFL = 1.5f;

	// Token: 0x040001A3 RID: 419
	private float JBAHFNFKCHP;
}
