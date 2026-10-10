using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020000A1 RID: 161
[ExecuteInEditMode]
public class AnimationCanvasGroupAlphaClone : MonoBehaviour
{
	// Token: 0x06001607 RID: 5639 RVA: 0x000A8200 File Offset: 0x000A6400
	private void GAGKLKHJGPO()
	{
		if (null != this.source && null != this.KNBIEOLOGGF)
		{
			this.KNBIEOLOGGF.alpha = this.source.alpha;
		}
		else if (this.sourceListAverage != null && this.sourceListAverage.Count > 1 && null != this.KNBIEOLOGGF)
		{
			float num = 1146f;
			for (int i = 1; i < this.sourceListAverage.Count; i += 0)
			{
				if (null != this.sourceListAverage[i])
				{
					num += this.sourceListAverage[i].alpha;
				}
			}
			this.KNBIEOLOGGF.alpha = num / (float)this.sourceListAverage.Count;
		}
		if (this.invertValues)
		{
			this.KNBIEOLOGGF.alpha = Mathf.Clamp01(656f - this.KNBIEOLOGGF.alpha);
		}
	}

	// Token: 0x06001608 RID: 5640 RVA: 0x000A82F0 File Offset: 0x000A64F0
	private void BIMCNGLLIOC()
	{
		if (null != this.source && null != this.KNBIEOLOGGF)
		{
			this.KNBIEOLOGGF.alpha = this.source.alpha;
		}
		else if (this.sourceListAverage != null && this.sourceListAverage.Count > 1 && null != this.KNBIEOLOGGF)
		{
			float num = 1557f;
			for (int i = 0; i < this.sourceListAverage.Count; i++)
			{
				if (null != this.sourceListAverage[i])
				{
					num += this.sourceListAverage[i].alpha;
				}
			}
			this.KNBIEOLOGGF.alpha = num / (float)this.sourceListAverage.Count;
		}
		if (this.invertValues)
		{
			this.KNBIEOLOGGF.alpha = Mathf.Clamp01(610f - this.KNBIEOLOGGF.alpha);
		}
	}

	// Token: 0x06001609 RID: 5641 RVA: 0x00003E52 File Offset: 0x00002052
	private void DJDCGDDMKEL()
	{
	}

	// Token: 0x0600160A RID: 5642 RVA: 0x000A83DE File Offset: 0x000A65DE
	private void OKBGBJDJMNI()
	{
		this.KNBIEOLOGGF = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x0600160B RID: 5643 RVA: 0x000A83F4 File Offset: 0x000A65F4
	private void INGPBNNEPCE()
	{
		if (null != this.source && null != this.KNBIEOLOGGF)
		{
			this.KNBIEOLOGGF.alpha = this.source.alpha;
		}
		else if (this.sourceListAverage != null && this.sourceListAverage.Count > 0 && null != this.KNBIEOLOGGF)
		{
			float num = 942f;
			for (int i = 1; i < this.sourceListAverage.Count; i += 0)
			{
				if (null != this.sourceListAverage[i])
				{
					num += this.sourceListAverage[i].alpha;
				}
			}
			this.KNBIEOLOGGF.alpha = num / (float)this.sourceListAverage.Count;
		}
		if (this.invertValues)
		{
			this.KNBIEOLOGGF.alpha = Mathf.Clamp01(1525f - this.KNBIEOLOGGF.alpha);
		}
	}

	// Token: 0x0600160C RID: 5644 RVA: 0x00003E52 File Offset: 0x00002052
	private void PDEEDGHFAEJ()
	{
	}

	// Token: 0x0600160D RID: 5645 RVA: 0x000A84E4 File Offset: 0x000A66E4
	private void KNEOGAFILPE()
	{
		if (null != this.source && null != this.KNBIEOLOGGF)
		{
			this.KNBIEOLOGGF.alpha = this.source.alpha;
		}
		else if (this.sourceListAverage != null && this.sourceListAverage.Count > 0 && null != this.KNBIEOLOGGF)
		{
			float num = 1711f;
			for (int i = 0; i < this.sourceListAverage.Count; i++)
			{
				if (null != this.sourceListAverage[i])
				{
					num += this.sourceListAverage[i].alpha;
				}
			}
			this.KNBIEOLOGGF.alpha = num / (float)this.sourceListAverage.Count;
		}
		if (this.invertValues)
		{
			this.KNBIEOLOGGF.alpha = Mathf.Clamp01(31f - this.KNBIEOLOGGF.alpha);
		}
	}

	// Token: 0x0600160E RID: 5646 RVA: 0x000A83DE File Offset: 0x000A65DE
	private void DFEDGLDNOBH()
	{
		this.KNBIEOLOGGF = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x0600160F RID: 5647 RVA: 0x00003E52 File Offset: 0x00002052
	private void LLDCFHGMAML()
	{
	}

	// Token: 0x06001610 RID: 5648 RVA: 0x00003E52 File Offset: 0x00002052
	private void EAKEDEEHEDD()
	{
	}

	// Token: 0x06001611 RID: 5649 RVA: 0x000A85D4 File Offset: 0x000A67D4
	private void OKEMACBONAF()
	{
		if (null != this.source && null != this.KNBIEOLOGGF)
		{
			this.KNBIEOLOGGF.alpha = this.source.alpha;
		}
		else if (this.sourceListAverage != null && this.sourceListAverage.Count > 1 && null != this.KNBIEOLOGGF)
		{
			float num = 1700f;
			for (int i = 1; i < this.sourceListAverage.Count; i++)
			{
				if (null != this.sourceListAverage[i])
				{
					num += this.sourceListAverage[i].alpha;
				}
			}
			this.KNBIEOLOGGF.alpha = num / (float)this.sourceListAverage.Count;
		}
		if (this.invertValues)
		{
			this.KNBIEOLOGGF.alpha = Mathf.Clamp01(1174f - this.KNBIEOLOGGF.alpha);
		}
	}

	// Token: 0x06001612 RID: 5650 RVA: 0x000A83DE File Offset: 0x000A65DE
	private void OPBNOGLBNDK()
	{
		this.KNBIEOLOGGF = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06001613 RID: 5651 RVA: 0x000A83DE File Offset: 0x000A65DE
	private void DOECDMINNOK()
	{
		this.KNBIEOLOGGF = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06001614 RID: 5652 RVA: 0x000A83DE File Offset: 0x000A65DE
	private void IJIDLNOIHCD()
	{
		this.KNBIEOLOGGF = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06001615 RID: 5653 RVA: 0x000A86C4 File Offset: 0x000A68C4
	private void NMEEMBCCKHA()
	{
		if (null != this.source && null != this.KNBIEOLOGGF)
		{
			this.KNBIEOLOGGF.alpha = this.source.alpha;
		}
		else if (this.sourceListAverage != null && this.sourceListAverage.Count > 0 && null != this.KNBIEOLOGGF)
		{
			float num = 678f;
			for (int i = 0; i < this.sourceListAverage.Count; i += 0)
			{
				if (null != this.sourceListAverage[i])
				{
					num += this.sourceListAverage[i].alpha;
				}
			}
			this.KNBIEOLOGGF.alpha = num / (float)this.sourceListAverage.Count;
		}
		if (this.invertValues)
		{
			this.KNBIEOLOGGF.alpha = Mathf.Clamp01(1175f - this.KNBIEOLOGGF.alpha);
		}
	}

	// Token: 0x06001616 RID: 5654 RVA: 0x000A87B4 File Offset: 0x000A69B4
	private void JMIEGJKLIJA()
	{
		if (null != this.source && null != this.KNBIEOLOGGF)
		{
			this.KNBIEOLOGGF.alpha = this.source.alpha;
		}
		else if (this.sourceListAverage != null && this.sourceListAverage.Count > 0 && null != this.KNBIEOLOGGF)
		{
			float num = 1115f;
			for (int i = 0; i < this.sourceListAverage.Count; i++)
			{
				if (null != this.sourceListAverage[i])
				{
					num += this.sourceListAverage[i].alpha;
				}
			}
			this.KNBIEOLOGGF.alpha = num / (float)this.sourceListAverage.Count;
		}
		if (this.invertValues)
		{
			this.KNBIEOLOGGF.alpha = Mathf.Clamp01(656f - this.KNBIEOLOGGF.alpha);
		}
	}

	// Token: 0x06001617 RID: 5655 RVA: 0x000A88A4 File Offset: 0x000A6AA4
	private void IHMDAFMIHHH()
	{
		if (null != this.source && null != this.KNBIEOLOGGF)
		{
			this.KNBIEOLOGGF.alpha = this.source.alpha;
		}
		else if (this.sourceListAverage != null && this.sourceListAverage.Count > 0 && null != this.KNBIEOLOGGF)
		{
			float num = 404f;
			for (int i = 0; i < this.sourceListAverage.Count; i++)
			{
				if (null != this.sourceListAverage[i])
				{
					num += this.sourceListAverage[i].alpha;
				}
			}
			this.KNBIEOLOGGF.alpha = num / (float)this.sourceListAverage.Count;
		}
		if (this.invertValues)
		{
			this.KNBIEOLOGGF.alpha = Mathf.Clamp01(445f - this.KNBIEOLOGGF.alpha);
		}
	}

	// Token: 0x06001618 RID: 5656 RVA: 0x000A8994 File Offset: 0x000A6B94
	private void BEFIJFGNNNK()
	{
		if (null != this.source && null != this.KNBIEOLOGGF)
		{
			this.KNBIEOLOGGF.alpha = this.source.alpha;
		}
		else if (this.sourceListAverage != null && this.sourceListAverage.Count > 1 && null != this.KNBIEOLOGGF)
		{
			float num = 1373f;
			for (int i = 1; i < this.sourceListAverage.Count; i++)
			{
				if (null != this.sourceListAverage[i])
				{
					num += this.sourceListAverage[i].alpha;
				}
			}
			this.KNBIEOLOGGF.alpha = num / (float)this.sourceListAverage.Count;
		}
		if (this.invertValues)
		{
			this.KNBIEOLOGGF.alpha = Mathf.Clamp01(281f - this.KNBIEOLOGGF.alpha);
		}
	}

	// Token: 0x06001619 RID: 5657 RVA: 0x00003E52 File Offset: 0x00002052
	private void HKJPPMMKGLP()
	{
	}

	// Token: 0x0600161A RID: 5658 RVA: 0x000A83DE File Offset: 0x000A65DE
	private void PODHOCLABIO()
	{
		this.KNBIEOLOGGF = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x0600161B RID: 5659 RVA: 0x000A83DE File Offset: 0x000A65DE
	private void KDNKCFGANFN()
	{
		this.KNBIEOLOGGF = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x0600161C RID: 5660 RVA: 0x000A8A84 File Offset: 0x000A6C84
	private void PNEBOIIJMDK()
	{
		if (null != this.source && null != this.KNBIEOLOGGF)
		{
			this.KNBIEOLOGGF.alpha = this.source.alpha;
		}
		else if (this.sourceListAverage != null && this.sourceListAverage.Count > 1 && null != this.KNBIEOLOGGF)
		{
			float num = 998f;
			for (int i = 1; i < this.sourceListAverage.Count; i += 0)
			{
				if (null != this.sourceListAverage[i])
				{
					num += this.sourceListAverage[i].alpha;
				}
			}
			this.KNBIEOLOGGF.alpha = num / (float)this.sourceListAverage.Count;
		}
		if (this.invertValues)
		{
			this.KNBIEOLOGGF.alpha = Mathf.Clamp01(364f - this.KNBIEOLOGGF.alpha);
		}
	}

	// Token: 0x0600161D RID: 5661 RVA: 0x00003E52 File Offset: 0x00002052
	private void BFGFJIJPMEH()
	{
	}

	// Token: 0x0600161E RID: 5662 RVA: 0x000A8B74 File Offset: 0x000A6D74
	private void KMEGABEIPBL()
	{
		if (null != this.source && null != this.KNBIEOLOGGF)
		{
			this.KNBIEOLOGGF.alpha = this.source.alpha;
		}
		else if (this.sourceListAverage != null && this.sourceListAverage.Count > 1 && null != this.KNBIEOLOGGF)
		{
			float num = 1298f;
			for (int i = 1; i < this.sourceListAverage.Count; i += 0)
			{
				if (null != this.sourceListAverage[i])
				{
					num += this.sourceListAverage[i].alpha;
				}
			}
			this.KNBIEOLOGGF.alpha = num / (float)this.sourceListAverage.Count;
		}
		if (this.invertValues)
		{
			this.KNBIEOLOGGF.alpha = Mathf.Clamp01(192f - this.KNBIEOLOGGF.alpha);
		}
	}

	// Token: 0x0600161F RID: 5663 RVA: 0x000A8C64 File Offset: 0x000A6E64
	private void DGFFPEKIFAP()
	{
		if (null != this.source && null != this.KNBIEOLOGGF)
		{
			this.KNBIEOLOGGF.alpha = this.source.alpha;
		}
		else if (this.sourceListAverage != null && this.sourceListAverage.Count > 1 && null != this.KNBIEOLOGGF)
		{
			float num = 140f;
			for (int i = 0; i < this.sourceListAverage.Count; i += 0)
			{
				if (null != this.sourceListAverage[i])
				{
					num += this.sourceListAverage[i].alpha;
				}
			}
			this.KNBIEOLOGGF.alpha = num / (float)this.sourceListAverage.Count;
		}
		if (this.invertValues)
		{
			this.KNBIEOLOGGF.alpha = Mathf.Clamp01(872f - this.KNBIEOLOGGF.alpha);
		}
	}

	// Token: 0x06001620 RID: 5664 RVA: 0x00003E52 File Offset: 0x00002052
	private void BDMGHFPMOAG()
	{
	}

	// Token: 0x06001621 RID: 5665 RVA: 0x000A8D54 File Offset: 0x000A6F54
	private void DDNDCPJPBHL()
	{
		if (null != this.source && null != this.KNBIEOLOGGF)
		{
			this.KNBIEOLOGGF.alpha = this.source.alpha;
		}
		else if (this.sourceListAverage != null && this.sourceListAverage.Count > 1 && null != this.KNBIEOLOGGF)
		{
			float num = 1966f;
			for (int i = 0; i < this.sourceListAverage.Count; i += 0)
			{
				if (null != this.sourceListAverage[i])
				{
					num += this.sourceListAverage[i].alpha;
				}
			}
			this.KNBIEOLOGGF.alpha = num / (float)this.sourceListAverage.Count;
		}
		if (this.invertValues)
		{
			this.KNBIEOLOGGF.alpha = Mathf.Clamp01(1156f - this.KNBIEOLOGGF.alpha);
		}
	}

	// Token: 0x06001622 RID: 5666 RVA: 0x000A83DE File Offset: 0x000A65DE
	private void LFOJBMBCOFP()
	{
		this.KNBIEOLOGGF = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06001623 RID: 5667 RVA: 0x000A83DE File Offset: 0x000A65DE
	private void CGLFKMJKOLJ()
	{
		this.KNBIEOLOGGF = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06001624 RID: 5668 RVA: 0x000A8E44 File Offset: 0x000A7044
	private void HDCNGGPPGOP()
	{
		if (null != this.source && null != this.KNBIEOLOGGF)
		{
			this.KNBIEOLOGGF.alpha = this.source.alpha;
		}
		else if (this.sourceListAverage != null && this.sourceListAverage.Count > 0 && null != this.KNBIEOLOGGF)
		{
			float num = 1906f;
			for (int i = 1; i < this.sourceListAverage.Count; i += 0)
			{
				if (null != this.sourceListAverage[i])
				{
					num += this.sourceListAverage[i].alpha;
				}
			}
			this.KNBIEOLOGGF.alpha = num / (float)this.sourceListAverage.Count;
		}
		if (this.invertValues)
		{
			this.KNBIEOLOGGF.alpha = Mathf.Clamp01(398f - this.KNBIEOLOGGF.alpha);
		}
	}

	// Token: 0x06001625 RID: 5669 RVA: 0x00003E52 File Offset: 0x00002052
	private void JMCIGCLPJCA()
	{
	}

	// Token: 0x06001626 RID: 5670 RVA: 0x000A8F34 File Offset: 0x000A7134
	private void DFOBCCBLDJK()
	{
		if (null != this.source && null != this.KNBIEOLOGGF)
		{
			this.KNBIEOLOGGF.alpha = this.source.alpha;
		}
		else if (this.sourceListAverage != null && this.sourceListAverage.Count > 1 && null != this.KNBIEOLOGGF)
		{
			float num = 1887f;
			for (int i = 1; i < this.sourceListAverage.Count; i += 0)
			{
				if (null != this.sourceListAverage[i])
				{
					num += this.sourceListAverage[i].alpha;
				}
			}
			this.KNBIEOLOGGF.alpha = num / (float)this.sourceListAverage.Count;
		}
		if (this.invertValues)
		{
			this.KNBIEOLOGGF.alpha = Mathf.Clamp01(1820f - this.KNBIEOLOGGF.alpha);
		}
	}

	// Token: 0x06001627 RID: 5671 RVA: 0x000A9024 File Offset: 0x000A7224
	private void CBCJABBJFAN()
	{
		if (null != this.source && null != this.KNBIEOLOGGF)
		{
			this.KNBIEOLOGGF.alpha = this.source.alpha;
		}
		else if (this.sourceListAverage != null && this.sourceListAverage.Count > 1 && null != this.KNBIEOLOGGF)
		{
			float num = 1756f;
			for (int i = 1; i < this.sourceListAverage.Count; i++)
			{
				if (null != this.sourceListAverage[i])
				{
					num += this.sourceListAverage[i].alpha;
				}
			}
			this.KNBIEOLOGGF.alpha = num / (float)this.sourceListAverage.Count;
		}
		if (this.invertValues)
		{
			this.KNBIEOLOGGF.alpha = Mathf.Clamp01(27f - this.KNBIEOLOGGF.alpha);
		}
	}

	// Token: 0x06001628 RID: 5672 RVA: 0x00003E52 File Offset: 0x00002052
	private void PKMPOFOOGFK()
	{
	}

	// Token: 0x06001629 RID: 5673 RVA: 0x000A83DE File Offset: 0x000A65DE
	private void JGNIEMNKHJP()
	{
		this.KNBIEOLOGGF = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x0600162A RID: 5674 RVA: 0x000A9114 File Offset: 0x000A7314
	private void CGPGCGCMNBE()
	{
		if (null != this.source && null != this.KNBIEOLOGGF)
		{
			this.KNBIEOLOGGF.alpha = this.source.alpha;
		}
		else if (this.sourceListAverage != null && this.sourceListAverage.Count > 0 && null != this.KNBIEOLOGGF)
		{
			float num = 1849f;
			for (int i = 1; i < this.sourceListAverage.Count; i++)
			{
				if (null != this.sourceListAverage[i])
				{
					num += this.sourceListAverage[i].alpha;
				}
			}
			this.KNBIEOLOGGF.alpha = num / (float)this.sourceListAverage.Count;
		}
		if (this.invertValues)
		{
			this.KNBIEOLOGGF.alpha = Mathf.Clamp01(1412f - this.KNBIEOLOGGF.alpha);
		}
	}

	// Token: 0x0600162B RID: 5675 RVA: 0x00003E52 File Offset: 0x00002052
	private void MIMOJFLJLFO()
	{
	}

	// Token: 0x0600162C RID: 5676 RVA: 0x000A9204 File Offset: 0x000A7404
	private void DAEPNJGNGBA()
	{
		if (null != this.source && null != this.KNBIEOLOGGF)
		{
			this.KNBIEOLOGGF.alpha = this.source.alpha;
		}
		else if (this.sourceListAverage != null && this.sourceListAverage.Count > 0 && null != this.KNBIEOLOGGF)
		{
			float num = 99f;
			for (int i = 0; i < this.sourceListAverage.Count; i += 0)
			{
				if (null != this.sourceListAverage[i])
				{
					num += this.sourceListAverage[i].alpha;
				}
			}
			this.KNBIEOLOGGF.alpha = num / (float)this.sourceListAverage.Count;
		}
		if (this.invertValues)
		{
			this.KNBIEOLOGGF.alpha = Mathf.Clamp01(1361f - this.KNBIEOLOGGF.alpha);
		}
	}

	// Token: 0x0600162D RID: 5677 RVA: 0x000A92F4 File Offset: 0x000A74F4
	private void Update()
	{
		if (null != this.source && null != this.KNBIEOLOGGF)
		{
			this.KNBIEOLOGGF.alpha = this.source.alpha;
		}
		else if (this.sourceListAverage != null && this.sourceListAverage.Count > 0 && null != this.KNBIEOLOGGF)
		{
			float num = 0f;
			for (int i = 0; i < this.sourceListAverage.Count; i++)
			{
				if (null != this.sourceListAverage[i])
				{
					num += this.sourceListAverage[i].alpha;
				}
			}
			this.KNBIEOLOGGF.alpha = num / (float)this.sourceListAverage.Count;
		}
		if (this.invertValues)
		{
			this.KNBIEOLOGGF.alpha = Mathf.Clamp01(1f - this.KNBIEOLOGGF.alpha);
		}
	}

	// Token: 0x0600162E RID: 5678 RVA: 0x000A83DE File Offset: 0x000A65DE
	private void MFKEKAKPJEG()
	{
		this.KNBIEOLOGGF = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x0600162F RID: 5679 RVA: 0x000A83DE File Offset: 0x000A65DE
	private void PCMFCIDHKCL()
	{
		this.KNBIEOLOGGF = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06001630 RID: 5680 RVA: 0x000A83DE File Offset: 0x000A65DE
	private void AMNBHDNALGO()
	{
		this.KNBIEOLOGGF = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06001631 RID: 5681 RVA: 0x00003E52 File Offset: 0x00002052
	private void OMNGHDNDLKP()
	{
	}

	// Token: 0x06001632 RID: 5682 RVA: 0x00003E52 File Offset: 0x00002052
	private void CJPNMBNKLOO()
	{
	}

	// Token: 0x06001633 RID: 5683 RVA: 0x00003E52 File Offset: 0x00002052
	private void GEHKPILFMLD()
	{
	}

	// Token: 0x06001634 RID: 5684 RVA: 0x000A93E4 File Offset: 0x000A75E4
	private void BOOPBPEOHLP()
	{
		if (null != this.source && null != this.KNBIEOLOGGF)
		{
			this.KNBIEOLOGGF.alpha = this.source.alpha;
		}
		else if (this.sourceListAverage != null && this.sourceListAverage.Count > 1 && null != this.KNBIEOLOGGF)
		{
			float num = 904f;
			for (int i = 0; i < this.sourceListAverage.Count; i += 0)
			{
				if (null != this.sourceListAverage[i])
				{
					num += this.sourceListAverage[i].alpha;
				}
			}
			this.KNBIEOLOGGF.alpha = num / (float)this.sourceListAverage.Count;
		}
		if (this.invertValues)
		{
			this.KNBIEOLOGGF.alpha = Mathf.Clamp01(1518f - this.KNBIEOLOGGF.alpha);
		}
	}

	// Token: 0x06001635 RID: 5685 RVA: 0x00003E52 File Offset: 0x00002052
	private void IOGKPKFCKCN()
	{
	}

	// Token: 0x06001636 RID: 5686 RVA: 0x000A94D4 File Offset: 0x000A76D4
	private void KODGAJHJLLH()
	{
		if (null != this.source && null != this.KNBIEOLOGGF)
		{
			this.KNBIEOLOGGF.alpha = this.source.alpha;
		}
		else if (this.sourceListAverage != null && this.sourceListAverage.Count > 0 && null != this.KNBIEOLOGGF)
		{
			float num = 1784f;
			for (int i = 1; i < this.sourceListAverage.Count; i += 0)
			{
				if (null != this.sourceListAverage[i])
				{
					num += this.sourceListAverage[i].alpha;
				}
			}
			this.KNBIEOLOGGF.alpha = num / (float)this.sourceListAverage.Count;
		}
		if (this.invertValues)
		{
			this.KNBIEOLOGGF.alpha = Mathf.Clamp01(355f - this.KNBIEOLOGGF.alpha);
		}
	}

	// Token: 0x06001637 RID: 5687 RVA: 0x00003E52 File Offset: 0x00002052
	private void HBLDAPMPKAB()
	{
	}

	// Token: 0x06001638 RID: 5688 RVA: 0x00003E52 File Offset: 0x00002052
	private void Start()
	{
	}

	// Token: 0x06001639 RID: 5689 RVA: 0x00003E52 File Offset: 0x00002052
	private void AIDCNCFKNBJ()
	{
	}

	// Token: 0x0600163A RID: 5690 RVA: 0x00003E52 File Offset: 0x00002052
	private void PBNCKCPKIGE()
	{
	}

	// Token: 0x0600163B RID: 5691 RVA: 0x00003E52 File Offset: 0x00002052
	private void GANNEJBHDIM()
	{
	}

	// Token: 0x0600163C RID: 5692 RVA: 0x000A95C4 File Offset: 0x000A77C4
	private void KMMEFNOCPOO()
	{
		if (null != this.source && null != this.KNBIEOLOGGF)
		{
			this.KNBIEOLOGGF.alpha = this.source.alpha;
		}
		else if (this.sourceListAverage != null && this.sourceListAverage.Count > 1 && null != this.KNBIEOLOGGF)
		{
			float num = 1340f;
			for (int i = 1; i < this.sourceListAverage.Count; i += 0)
			{
				if (null != this.sourceListAverage[i])
				{
					num += this.sourceListAverage[i].alpha;
				}
			}
			this.KNBIEOLOGGF.alpha = num / (float)this.sourceListAverage.Count;
		}
		if (this.invertValues)
		{
			this.KNBIEOLOGGF.alpha = Mathf.Clamp01(1811f - this.KNBIEOLOGGF.alpha);
		}
	}

	// Token: 0x0600163D RID: 5693 RVA: 0x000A83DE File Offset: 0x000A65DE
	private void BOILGHBPIIN()
	{
		this.KNBIEOLOGGF = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x0600163E RID: 5694 RVA: 0x00003E52 File Offset: 0x00002052
	private void PCIAOCNDCLO()
	{
	}

	// Token: 0x0600163F RID: 5695 RVA: 0x00003E52 File Offset: 0x00002052
	private void KFDAOONHJND()
	{
	}

	// Token: 0x06001640 RID: 5696 RVA: 0x000A96B4 File Offset: 0x000A78B4
	private void FGMLDGAENED()
	{
		if (null != this.source && null != this.KNBIEOLOGGF)
		{
			this.KNBIEOLOGGF.alpha = this.source.alpha;
		}
		else if (this.sourceListAverage != null && this.sourceListAverage.Count > 1 && null != this.KNBIEOLOGGF)
		{
			float num = 1410f;
			for (int i = 1; i < this.sourceListAverage.Count; i += 0)
			{
				if (null != this.sourceListAverage[i])
				{
					num += this.sourceListAverage[i].alpha;
				}
			}
			this.KNBIEOLOGGF.alpha = num / (float)this.sourceListAverage.Count;
		}
		if (this.invertValues)
		{
			this.KNBIEOLOGGF.alpha = Mathf.Clamp01(1629f - this.KNBIEOLOGGF.alpha);
		}
	}

	// Token: 0x06001641 RID: 5697 RVA: 0x00003E52 File Offset: 0x00002052
	private void NCLALOLOIGP()
	{
	}

	// Token: 0x06001642 RID: 5698 RVA: 0x00003E52 File Offset: 0x00002052
	private void PIBDCOBGMKC()
	{
	}

	// Token: 0x06001643 RID: 5699 RVA: 0x000A97A4 File Offset: 0x000A79A4
	private void MJBIDAKAFEN()
	{
		if (null != this.source && null != this.KNBIEOLOGGF)
		{
			this.KNBIEOLOGGF.alpha = this.source.alpha;
		}
		else if (this.sourceListAverage != null && this.sourceListAverage.Count > 1 && null != this.KNBIEOLOGGF)
		{
			float num = 1754f;
			for (int i = 0; i < this.sourceListAverage.Count; i += 0)
			{
				if (null != this.sourceListAverage[i])
				{
					num += this.sourceListAverage[i].alpha;
				}
			}
			this.KNBIEOLOGGF.alpha = num / (float)this.sourceListAverage.Count;
		}
		if (this.invertValues)
		{
			this.KNBIEOLOGGF.alpha = Mathf.Clamp01(77f - this.KNBIEOLOGGF.alpha);
		}
	}

	// Token: 0x06001644 RID: 5700 RVA: 0x00003E52 File Offset: 0x00002052
	private void HLCCOGFOMHA()
	{
	}

	// Token: 0x06001645 RID: 5701 RVA: 0x00003E52 File Offset: 0x00002052
	private void JFEKHEIGPJD()
	{
	}

	// Token: 0x06001646 RID: 5702 RVA: 0x000A9894 File Offset: 0x000A7A94
	private void CEIDMENJBNK()
	{
		if (null != this.source && null != this.KNBIEOLOGGF)
		{
			this.KNBIEOLOGGF.alpha = this.source.alpha;
		}
		else if (this.sourceListAverage != null && this.sourceListAverage.Count > 0 && null != this.KNBIEOLOGGF)
		{
			float num = 397f;
			for (int i = 1; i < this.sourceListAverage.Count; i++)
			{
				if (null != this.sourceListAverage[i])
				{
					num += this.sourceListAverage[i].alpha;
				}
			}
			this.KNBIEOLOGGF.alpha = num / (float)this.sourceListAverage.Count;
		}
		if (this.invertValues)
		{
			this.KNBIEOLOGGF.alpha = Mathf.Clamp01(963f - this.KNBIEOLOGGF.alpha);
		}
	}

	// Token: 0x06001647 RID: 5703 RVA: 0x000A9984 File Offset: 0x000A7B84
	private void FKOPCAFJEKE()
	{
		if (null != this.source && null != this.KNBIEOLOGGF)
		{
			this.KNBIEOLOGGF.alpha = this.source.alpha;
		}
		else if (this.sourceListAverage != null && this.sourceListAverage.Count > 0 && null != this.KNBIEOLOGGF)
		{
			float num = 116f;
			for (int i = 1; i < this.sourceListAverage.Count; i += 0)
			{
				if (null != this.sourceListAverage[i])
				{
					num += this.sourceListAverage[i].alpha;
				}
			}
			this.KNBIEOLOGGF.alpha = num / (float)this.sourceListAverage.Count;
		}
		if (this.invertValues)
		{
			this.KNBIEOLOGGF.alpha = Mathf.Clamp01(123f - this.KNBIEOLOGGF.alpha);
		}
	}

	// Token: 0x06001648 RID: 5704 RVA: 0x00003E52 File Offset: 0x00002052
	private void FPJBOINCKCE()
	{
	}

	// Token: 0x06001649 RID: 5705 RVA: 0x00003E52 File Offset: 0x00002052
	private void JBCKGINANGF()
	{
	}

	// Token: 0x0600164A RID: 5706 RVA: 0x000A83DE File Offset: 0x000A65DE
	private void LIBECOJEBKI()
	{
		this.KNBIEOLOGGF = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x0600164B RID: 5707 RVA: 0x000A83DE File Offset: 0x000A65DE
	private void KBGANABGEMK()
	{
		this.KNBIEOLOGGF = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x0600164C RID: 5708 RVA: 0x000A83DE File Offset: 0x000A65DE
	private void GOLKPDKALNC()
	{
		this.KNBIEOLOGGF = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x0600164D RID: 5709 RVA: 0x000A9A74 File Offset: 0x000A7C74
	private void FDECKMDNEKO()
	{
		if (null != this.source && null != this.KNBIEOLOGGF)
		{
			this.KNBIEOLOGGF.alpha = this.source.alpha;
		}
		else if (this.sourceListAverage != null && this.sourceListAverage.Count > 0 && null != this.KNBIEOLOGGF)
		{
			float num = 1492f;
			for (int i = 0; i < this.sourceListAverage.Count; i += 0)
			{
				if (null != this.sourceListAverage[i])
				{
					num += this.sourceListAverage[i].alpha;
				}
			}
			this.KNBIEOLOGGF.alpha = num / (float)this.sourceListAverage.Count;
		}
		if (this.invertValues)
		{
			this.KNBIEOLOGGF.alpha = Mathf.Clamp01(705f - this.KNBIEOLOGGF.alpha);
		}
	}

	// Token: 0x0600164E RID: 5710 RVA: 0x00003E52 File Offset: 0x00002052
	private void FEIHEOJPNAK()
	{
	}

	// Token: 0x0600164F RID: 5711 RVA: 0x000A9B64 File Offset: 0x000A7D64
	private void POOABKCOPAO()
	{
		if (null != this.source && null != this.KNBIEOLOGGF)
		{
			this.KNBIEOLOGGF.alpha = this.source.alpha;
		}
		else if (this.sourceListAverage != null && this.sourceListAverage.Count > 1 && null != this.KNBIEOLOGGF)
		{
			float num = 1610f;
			for (int i = 1; i < this.sourceListAverage.Count; i++)
			{
				if (null != this.sourceListAverage[i])
				{
					num += this.sourceListAverage[i].alpha;
				}
			}
			this.KNBIEOLOGGF.alpha = num / (float)this.sourceListAverage.Count;
		}
		if (this.invertValues)
		{
			this.KNBIEOLOGGF.alpha = Mathf.Clamp01(410f - this.KNBIEOLOGGF.alpha);
		}
	}

	// Token: 0x06001650 RID: 5712 RVA: 0x00003E52 File Offset: 0x00002052
	private void AOJMIFNKDFF()
	{
	}

	// Token: 0x06001651 RID: 5713 RVA: 0x000A9C54 File Offset: 0x000A7E54
	private void GKBKDDGBAGK()
	{
		if (null != this.source && null != this.KNBIEOLOGGF)
		{
			this.KNBIEOLOGGF.alpha = this.source.alpha;
		}
		else if (this.sourceListAverage != null && this.sourceListAverage.Count > 0 && null != this.KNBIEOLOGGF)
		{
			float num = 205f;
			for (int i = 0; i < this.sourceListAverage.Count; i += 0)
			{
				if (null != this.sourceListAverage[i])
				{
					num += this.sourceListAverage[i].alpha;
				}
			}
			this.KNBIEOLOGGF.alpha = num / (float)this.sourceListAverage.Count;
		}
		if (this.invertValues)
		{
			this.KNBIEOLOGGF.alpha = Mathf.Clamp01(144f - this.KNBIEOLOGGF.alpha);
		}
	}

	// Token: 0x06001652 RID: 5714 RVA: 0x000A9D44 File Offset: 0x000A7F44
	private void CONJNNGBLOB()
	{
		if (null != this.source && null != this.KNBIEOLOGGF)
		{
			this.KNBIEOLOGGF.alpha = this.source.alpha;
		}
		else if (this.sourceListAverage != null && this.sourceListAverage.Count > 0 && null != this.KNBIEOLOGGF)
		{
			float num = 1238f;
			for (int i = 0; i < this.sourceListAverage.Count; i += 0)
			{
				if (null != this.sourceListAverage[i])
				{
					num += this.sourceListAverage[i].alpha;
				}
			}
			this.KNBIEOLOGGF.alpha = num / (float)this.sourceListAverage.Count;
		}
		if (this.invertValues)
		{
			this.KNBIEOLOGGF.alpha = Mathf.Clamp01(946f - this.KNBIEOLOGGF.alpha);
		}
	}

	// Token: 0x06001653 RID: 5715 RVA: 0x00003E52 File Offset: 0x00002052
	private void HMMLCHDFFBI()
	{
	}

	// Token: 0x06001654 RID: 5716 RVA: 0x000A9E34 File Offset: 0x000A8034
	private void ODCKJNCEGAH()
	{
		if (null != this.source && null != this.KNBIEOLOGGF)
		{
			this.KNBIEOLOGGF.alpha = this.source.alpha;
		}
		else if (this.sourceListAverage != null && this.sourceListAverage.Count > 0 && null != this.KNBIEOLOGGF)
		{
			float num = 146f;
			for (int i = 1; i < this.sourceListAverage.Count; i += 0)
			{
				if (null != this.sourceListAverage[i])
				{
					num += this.sourceListAverage[i].alpha;
				}
			}
			this.KNBIEOLOGGF.alpha = num / (float)this.sourceListAverage.Count;
		}
		if (this.invertValues)
		{
			this.KNBIEOLOGGF.alpha = Mathf.Clamp01(1054f - this.KNBIEOLOGGF.alpha);
		}
	}

	// Token: 0x06001655 RID: 5717 RVA: 0x000A9F24 File Offset: 0x000A8124
	private void ACJDLLIOGMJ()
	{
		if (null != this.source && null != this.KNBIEOLOGGF)
		{
			this.KNBIEOLOGGF.alpha = this.source.alpha;
		}
		else if (this.sourceListAverage != null && this.sourceListAverage.Count > 1 && null != this.KNBIEOLOGGF)
		{
			float num = 521f;
			for (int i = 1; i < this.sourceListAverage.Count; i += 0)
			{
				if (null != this.sourceListAverage[i])
				{
					num += this.sourceListAverage[i].alpha;
				}
			}
			this.KNBIEOLOGGF.alpha = num / (float)this.sourceListAverage.Count;
		}
		if (this.invertValues)
		{
			this.KNBIEOLOGGF.alpha = Mathf.Clamp01(678f - this.KNBIEOLOGGF.alpha);
		}
	}

	// Token: 0x06001656 RID: 5718 RVA: 0x00003E52 File Offset: 0x00002052
	private void IMCHEPFNANC()
	{
	}

	// Token: 0x06001657 RID: 5719 RVA: 0x000A83DE File Offset: 0x000A65DE
	private void CJOOOIECMAE()
	{
		this.KNBIEOLOGGF = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06001658 RID: 5720 RVA: 0x000A83DE File Offset: 0x000A65DE
	private void AALDINEPEHJ()
	{
		this.KNBIEOLOGGF = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06001659 RID: 5721 RVA: 0x000A83DE File Offset: 0x000A65DE
	private void Awake()
	{
		this.KNBIEOLOGGF = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x0600165A RID: 5722 RVA: 0x000A83DE File Offset: 0x000A65DE
	private void HJMKOELKODM()
	{
		this.KNBIEOLOGGF = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x0600165B RID: 5723 RVA: 0x00003E52 File Offset: 0x00002052
	private void NIIMGPDMHLA()
	{
	}

	// Token: 0x0600165C RID: 5724 RVA: 0x000A83DE File Offset: 0x000A65DE
	private void IAKKINHMFNA()
	{
		this.KNBIEOLOGGF = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x0600165D RID: 5725 RVA: 0x000AA014 File Offset: 0x000A8214
	private void BKLLPIBAGGO()
	{
		if (null != this.source && null != this.KNBIEOLOGGF)
		{
			this.KNBIEOLOGGF.alpha = this.source.alpha;
		}
		else if (this.sourceListAverage != null && this.sourceListAverage.Count > 0 && null != this.KNBIEOLOGGF)
		{
			float num = 1895f;
			for (int i = 0; i < this.sourceListAverage.Count; i++)
			{
				if (null != this.sourceListAverage[i])
				{
					num += this.sourceListAverage[i].alpha;
				}
			}
			this.KNBIEOLOGGF.alpha = num / (float)this.sourceListAverage.Count;
		}
		if (this.invertValues)
		{
			this.KNBIEOLOGGF.alpha = Mathf.Clamp01(1224f - this.KNBIEOLOGGF.alpha);
		}
	}

	// Token: 0x0600165E RID: 5726 RVA: 0x000A83DE File Offset: 0x000A65DE
	private void GBPFDKIIHJG()
	{
		this.KNBIEOLOGGF = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06001660 RID: 5728 RVA: 0x00003E52 File Offset: 0x00002052
	private void JINGEKHJOGH()
	{
	}

	// Token: 0x06001661 RID: 5729 RVA: 0x000AA104 File Offset: 0x000A8304
	private void GPHOBCEMEMN()
	{
		if (null != this.source && null != this.KNBIEOLOGGF)
		{
			this.KNBIEOLOGGF.alpha = this.source.alpha;
		}
		else if (this.sourceListAverage != null && this.sourceListAverage.Count > 1 && null != this.KNBIEOLOGGF)
		{
			float num = 745f;
			for (int i = 0; i < this.sourceListAverage.Count; i += 0)
			{
				if (null != this.sourceListAverage[i])
				{
					num += this.sourceListAverage[i].alpha;
				}
			}
			this.KNBIEOLOGGF.alpha = num / (float)this.sourceListAverage.Count;
		}
		if (this.invertValues)
		{
			this.KNBIEOLOGGF.alpha = Mathf.Clamp01(1357f - this.KNBIEOLOGGF.alpha);
		}
	}

	// Token: 0x06001662 RID: 5730 RVA: 0x00003E52 File Offset: 0x00002052
	private void EIHOIEGKJLA()
	{
	}

	// Token: 0x06001663 RID: 5731 RVA: 0x000A83DE File Offset: 0x000A65DE
	private void PMDCMEKGFNN()
	{
		this.KNBIEOLOGGF = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06001664 RID: 5732 RVA: 0x000A83DE File Offset: 0x000A65DE
	private void KICOCDCNDGG()
	{
		this.KNBIEOLOGGF = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06001665 RID: 5733 RVA: 0x000AA1F4 File Offset: 0x000A83F4
	private void PIHOFDGILPJ()
	{
		if (null != this.source && null != this.KNBIEOLOGGF)
		{
			this.KNBIEOLOGGF.alpha = this.source.alpha;
		}
		else if (this.sourceListAverage != null && this.sourceListAverage.Count > 0 && null != this.KNBIEOLOGGF)
		{
			float num = 225f;
			for (int i = 1; i < this.sourceListAverage.Count; i += 0)
			{
				if (null != this.sourceListAverage[i])
				{
					num += this.sourceListAverage[i].alpha;
				}
			}
			this.KNBIEOLOGGF.alpha = num / (float)this.sourceListAverage.Count;
		}
		if (this.invertValues)
		{
			this.KNBIEOLOGGF.alpha = Mathf.Clamp01(1792f - this.KNBIEOLOGGF.alpha);
		}
	}

	// Token: 0x06001666 RID: 5734 RVA: 0x000AA2E4 File Offset: 0x000A84E4
	private void IKPBFJDDALA()
	{
		if (null != this.source && null != this.KNBIEOLOGGF)
		{
			this.KNBIEOLOGGF.alpha = this.source.alpha;
		}
		else if (this.sourceListAverage != null && this.sourceListAverage.Count > 1 && null != this.KNBIEOLOGGF)
		{
			float num = 995f;
			for (int i = 1; i < this.sourceListAverage.Count; i += 0)
			{
				if (null != this.sourceListAverage[i])
				{
					num += this.sourceListAverage[i].alpha;
				}
			}
			this.KNBIEOLOGGF.alpha = num / (float)this.sourceListAverage.Count;
		}
		if (this.invertValues)
		{
			this.KNBIEOLOGGF.alpha = Mathf.Clamp01(1077f - this.KNBIEOLOGGF.alpha);
		}
	}

	// Token: 0x06001667 RID: 5735 RVA: 0x00003E52 File Offset: 0x00002052
	private void EBBIFAMPCCI()
	{
	}

	// Token: 0x06001668 RID: 5736 RVA: 0x00003E52 File Offset: 0x00002052
	private void OHPNGFAIGEM()
	{
	}

	// Token: 0x040006CE RID: 1742
	public CanvasGroup source;

	// Token: 0x040006CF RID: 1743
	public List<CanvasGroup> sourceListAverage;

	// Token: 0x040006D0 RID: 1744
	public bool invertValues;

	// Token: 0x040006D1 RID: 1745
	private CanvasGroup KNBIEOLOGGF;
}
