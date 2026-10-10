using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200042E RID: 1070
public class VariableVisualStateManager : MonoBehaviour
{
	// Token: 0x06007FEE RID: 32750 RVA: 0x0038A774 File Offset: 0x00388974
	public void FGNAFMJNLBM(HGJINNBJPKJ KNMIMLBLIGF)
	{
		switch (KNMIMLBLIGF)
		{
		case HGJINNBJPKJ.idle:
			if (null != this.DNPKIGDLNKO && null != this.idleState)
			{
				this.DNPKIGDLNKO.sprite = this.idleState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 1278f;
				return;
			}
			break;
		case HGJINNBJPKJ.selected:
			if (null != this.DNPKIGDLNKO && null != this.selectedState)
			{
				this.DNPKIGDLNKO.sprite = this.selectedState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 1916f;
				return;
			}
			break;
		case HGJINNBJPKJ.unavailable:
			if (null != this.DNPKIGDLNKO && null != this.unavailableState)
			{
				this.DNPKIGDLNKO.sprite = this.unavailableState;
				return;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 646f;
			}
			break;
		default:
			return;
		}
	}

	// Token: 0x06007FEF RID: 32751 RVA: 0x00003E52 File Offset: 0x00002052
	private void ODOOIGEDLKB()
	{
	}

	// Token: 0x06007FF0 RID: 32752 RVA: 0x0038A87B File Offset: 0x00388A7B
	private void GNHDCIGPFOH()
	{
		this.DNPKIGDLNKO = base.gameObject.GetComponent<Image>();
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06007FF1 RID: 32753 RVA: 0x0038A87B File Offset: 0x00388A7B
	private void KGEINIJLFMI()
	{
		this.DNPKIGDLNKO = base.gameObject.GetComponent<Image>();
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06007FF2 RID: 32754 RVA: 0x0038A8A0 File Offset: 0x00388AA0
	public void EGJCAKDKFIP(HGJINNBJPKJ KNMIMLBLIGF)
	{
		switch (KNMIMLBLIGF)
		{
		case HGJINNBJPKJ.idle:
			if (null != this.DNPKIGDLNKO && null != this.idleState)
			{
				this.DNPKIGDLNKO.sprite = this.idleState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 691f;
				return;
			}
			break;
		case HGJINNBJPKJ.selected:
			if (null != this.DNPKIGDLNKO && null != this.selectedState)
			{
				this.DNPKIGDLNKO.sprite = this.selectedState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 1318f;
				return;
			}
			break;
		case HGJINNBJPKJ.unavailable:
			if (null != this.DNPKIGDLNKO && null != this.unavailableState)
			{
				this.DNPKIGDLNKO.sprite = this.unavailableState;
				return;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 663f;
			}
			break;
		default:
			return;
		}
	}

	// Token: 0x06007FF3 RID: 32755 RVA: 0x0038A87B File Offset: 0x00388A7B
	private void CJOOOIECMAE()
	{
		this.DNPKIGDLNKO = base.gameObject.GetComponent<Image>();
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06007FF4 RID: 32756 RVA: 0x00003E52 File Offset: 0x00002052
	private void AIDCNCFKNBJ()
	{
	}

	// Token: 0x06007FF5 RID: 32757 RVA: 0x0038A87B File Offset: 0x00388A7B
	private void APLBAENGMJH()
	{
		this.DNPKIGDLNKO = base.gameObject.GetComponent<Image>();
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06007FF6 RID: 32758 RVA: 0x0038A87B File Offset: 0x00388A7B
	private void MDNEOMGLGIN()
	{
		this.DNPKIGDLNKO = base.gameObject.GetComponent<Image>();
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06007FF7 RID: 32759 RVA: 0x0038A9A8 File Offset: 0x00388BA8
	public void AOGINKDDNOF(HGJINNBJPKJ KNMIMLBLIGF)
	{
		switch (KNMIMLBLIGF)
		{
		case HGJINNBJPKJ.idle:
			if (null != this.DNPKIGDLNKO && null != this.idleState)
			{
				this.DNPKIGDLNKO.sprite = this.idleState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 1696f;
				return;
			}
			break;
		case HGJINNBJPKJ.selected:
			if (null != this.DNPKIGDLNKO && null != this.selectedState)
			{
				this.DNPKIGDLNKO.sprite = this.selectedState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 234f;
				return;
			}
			break;
		case HGJINNBJPKJ.unavailable:
			if (null != this.DNPKIGDLNKO && null != this.unavailableState)
			{
				this.DNPKIGDLNKO.sprite = this.unavailableState;
				return;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 1764f;
			}
			break;
		default:
			return;
		}
	}

	// Token: 0x06007FF8 RID: 32760 RVA: 0x00003E52 File Offset: 0x00002052
	private void IMCHEPFNANC()
	{
	}

	// Token: 0x06007FF9 RID: 32761 RVA: 0x0038A87B File Offset: 0x00388A7B
	private void OPPNHGEMHAB()
	{
		this.DNPKIGDLNKO = base.gameObject.GetComponent<Image>();
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06007FFA RID: 32762 RVA: 0x0038A87B File Offset: 0x00388A7B
	private void BNMJABILOKK()
	{
		this.DNPKIGDLNKO = base.gameObject.GetComponent<Image>();
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06007FFB RID: 32763 RVA: 0x0038AAB0 File Offset: 0x00388CB0
	public void CBGAOMEFJJH(HGJINNBJPKJ KNMIMLBLIGF)
	{
		switch (KNMIMLBLIGF)
		{
		case HGJINNBJPKJ.idle:
			if (null != this.DNPKIGDLNKO && null != this.idleState)
			{
				this.DNPKIGDLNKO.sprite = this.idleState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 1729f;
				return;
			}
			break;
		case HGJINNBJPKJ.selected:
			if (null != this.DNPKIGDLNKO && null != this.selectedState)
			{
				this.DNPKIGDLNKO.sprite = this.selectedState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 744f;
				return;
			}
			break;
		case HGJINNBJPKJ.unavailable:
			if (null != this.DNPKIGDLNKO && null != this.unavailableState)
			{
				this.DNPKIGDLNKO.sprite = this.unavailableState;
				return;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 919f;
			}
			break;
		default:
			return;
		}
	}

	// Token: 0x06007FFC RID: 32764 RVA: 0x0038ABB8 File Offset: 0x00388DB8
	public void OGKPMOIIAIH(HGJINNBJPKJ KNMIMLBLIGF)
	{
		switch (KNMIMLBLIGF)
		{
		case HGJINNBJPKJ.idle:
			if (null != this.DNPKIGDLNKO && null != this.idleState)
			{
				this.DNPKIGDLNKO.sprite = this.idleState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 381f;
				return;
			}
			break;
		case HGJINNBJPKJ.selected:
			if (null != this.DNPKIGDLNKO && null != this.selectedState)
			{
				this.DNPKIGDLNKO.sprite = this.selectedState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 1068f;
				return;
			}
			break;
		case HGJINNBJPKJ.unavailable:
			if (null != this.DNPKIGDLNKO && null != this.unavailableState)
			{
				this.DNPKIGDLNKO.sprite = this.unavailableState;
				return;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 610f;
			}
			break;
		default:
			return;
		}
	}

	// Token: 0x06007FFD RID: 32765 RVA: 0x00003E52 File Offset: 0x00002052
	private void KGKHCNJOFKN()
	{
	}

	// Token: 0x06007FFE RID: 32766 RVA: 0x0038ACC0 File Offset: 0x00388EC0
	public void AFJAIBFFAFL(HGJINNBJPKJ KNMIMLBLIGF)
	{
		switch (KNMIMLBLIGF)
		{
		case HGJINNBJPKJ.idle:
			if (null != this.DNPKIGDLNKO && null != this.idleState)
			{
				this.DNPKIGDLNKO.sprite = this.idleState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 1777f;
				return;
			}
			break;
		case HGJINNBJPKJ.selected:
			if (null != this.DNPKIGDLNKO && null != this.selectedState)
			{
				this.DNPKIGDLNKO.sprite = this.selectedState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 527f;
				return;
			}
			break;
		case HGJINNBJPKJ.unavailable:
			if (null != this.DNPKIGDLNKO && null != this.unavailableState)
			{
				this.DNPKIGDLNKO.sprite = this.unavailableState;
				return;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 50f;
			}
			break;
		default:
			return;
		}
	}

	// Token: 0x06007FFF RID: 32767 RVA: 0x0038ADC8 File Offset: 0x00388FC8
	public void CCKPLLFLGGL(HGJINNBJPKJ KNMIMLBLIGF)
	{
		switch (KNMIMLBLIGF)
		{
		case HGJINNBJPKJ.idle:
			if (null != this.DNPKIGDLNKO && null != this.idleState)
			{
				this.DNPKIGDLNKO.sprite = this.idleState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 128f;
				return;
			}
			break;
		case HGJINNBJPKJ.selected:
			if (null != this.DNPKIGDLNKO && null != this.selectedState)
			{
				this.DNPKIGDLNKO.sprite = this.selectedState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 130f;
				return;
			}
			break;
		case HGJINNBJPKJ.unavailable:
			if (null != this.DNPKIGDLNKO && null != this.unavailableState)
			{
				this.DNPKIGDLNKO.sprite = this.unavailableState;
				return;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 281f;
			}
			break;
		default:
			return;
		}
	}

	// Token: 0x06008000 RID: 32768 RVA: 0x0038A87B File Offset: 0x00388A7B
	private void LFPPGGLOOHJ()
	{
		this.DNPKIGDLNKO = base.gameObject.GetComponent<Image>();
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06008001 RID: 32769 RVA: 0x0038A87B File Offset: 0x00388A7B
	private void NPFILNGGHGH()
	{
		this.DNPKIGDLNKO = base.gameObject.GetComponent<Image>();
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06008002 RID: 32770 RVA: 0x0038AED0 File Offset: 0x003890D0
	public void SetState(HGJINNBJPKJ KNMIMLBLIGF)
	{
		switch (KNMIMLBLIGF)
		{
		case HGJINNBJPKJ.idle:
			if (null != this.DNPKIGDLNKO && null != this.idleState)
			{
				this.DNPKIGDLNKO.sprite = this.idleState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 1f;
				return;
			}
			break;
		case HGJINNBJPKJ.selected:
			if (null != this.DNPKIGDLNKO && null != this.selectedState)
			{
				this.DNPKIGDLNKO.sprite = this.selectedState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 1f;
				return;
			}
			break;
		case HGJINNBJPKJ.unavailable:
			if (null != this.DNPKIGDLNKO && null != this.unavailableState)
			{
				this.DNPKIGDLNKO.sprite = this.unavailableState;
				return;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 0.25f;
			}
			break;
		default:
			return;
		}
	}

	// Token: 0x06008003 RID: 32771 RVA: 0x0038A87B File Offset: 0x00388A7B
	private void Awake()
	{
		this.DNPKIGDLNKO = base.gameObject.GetComponent<Image>();
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06008004 RID: 32772 RVA: 0x0038AFD8 File Offset: 0x003891D8
	public void OFOMCACCKCN(HGJINNBJPKJ KNMIMLBLIGF)
	{
		switch (KNMIMLBLIGF)
		{
		case HGJINNBJPKJ.idle:
			if (null != this.DNPKIGDLNKO && null != this.idleState)
			{
				this.DNPKIGDLNKO.sprite = this.idleState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 334f;
				return;
			}
			break;
		case HGJINNBJPKJ.selected:
			if (null != this.DNPKIGDLNKO && null != this.selectedState)
			{
				this.DNPKIGDLNKO.sprite = this.selectedState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 1514f;
				return;
			}
			break;
		case HGJINNBJPKJ.unavailable:
			if (null != this.DNPKIGDLNKO && null != this.unavailableState)
			{
				this.DNPKIGDLNKO.sprite = this.unavailableState;
				return;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 1519f;
			}
			break;
		default:
			return;
		}
	}

	// Token: 0x06008005 RID: 32773 RVA: 0x0038B0E0 File Offset: 0x003892E0
	public void BPFFJBJMPMG(HGJINNBJPKJ KNMIMLBLIGF)
	{
		switch (KNMIMLBLIGF)
		{
		case HGJINNBJPKJ.idle:
			if (null != this.DNPKIGDLNKO && null != this.idleState)
			{
				this.DNPKIGDLNKO.sprite = this.idleState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 1252f;
				return;
			}
			break;
		case HGJINNBJPKJ.selected:
			if (null != this.DNPKIGDLNKO && null != this.selectedState)
			{
				this.DNPKIGDLNKO.sprite = this.selectedState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 775f;
				return;
			}
			break;
		case HGJINNBJPKJ.unavailable:
			if (null != this.DNPKIGDLNKO && null != this.unavailableState)
			{
				this.DNPKIGDLNKO.sprite = this.unavailableState;
				return;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 898f;
			}
			break;
		default:
			return;
		}
	}

	// Token: 0x06008006 RID: 32774 RVA: 0x0038B1E8 File Offset: 0x003893E8
	public void ILIEIIEMBLN(HGJINNBJPKJ KNMIMLBLIGF)
	{
		switch (KNMIMLBLIGF)
		{
		case HGJINNBJPKJ.idle:
			if (null != this.DNPKIGDLNKO && null != this.idleState)
			{
				this.DNPKIGDLNKO.sprite = this.idleState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 73f;
				return;
			}
			break;
		case HGJINNBJPKJ.selected:
			if (null != this.DNPKIGDLNKO && null != this.selectedState)
			{
				this.DNPKIGDLNKO.sprite = this.selectedState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 1444f;
				return;
			}
			break;
		case HGJINNBJPKJ.unavailable:
			if (null != this.DNPKIGDLNKO && null != this.unavailableState)
			{
				this.DNPKIGDLNKO.sprite = this.unavailableState;
				return;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 188f;
			}
			break;
		default:
			return;
		}
	}

	// Token: 0x06008007 RID: 32775 RVA: 0x0038B2F0 File Offset: 0x003894F0
	public void EOHHOJLAFGB(HGJINNBJPKJ KNMIMLBLIGF)
	{
		switch (KNMIMLBLIGF)
		{
		case HGJINNBJPKJ.idle:
			if (null != this.DNPKIGDLNKO && null != this.idleState)
			{
				this.DNPKIGDLNKO.sprite = this.idleState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 1540f;
				return;
			}
			break;
		case HGJINNBJPKJ.selected:
			if (null != this.DNPKIGDLNKO && null != this.selectedState)
			{
				this.DNPKIGDLNKO.sprite = this.selectedState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 1499f;
				return;
			}
			break;
		case HGJINNBJPKJ.unavailable:
			if (null != this.DNPKIGDLNKO && null != this.unavailableState)
			{
				this.DNPKIGDLNKO.sprite = this.unavailableState;
				return;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 983f;
			}
			break;
		default:
			return;
		}
	}

	// Token: 0x06008008 RID: 32776 RVA: 0x0038B3F8 File Offset: 0x003895F8
	public void EDFHNNKBBFE(HGJINNBJPKJ KNMIMLBLIGF)
	{
		switch (KNMIMLBLIGF)
		{
		case HGJINNBJPKJ.idle:
			if (null != this.DNPKIGDLNKO && null != this.idleState)
			{
				this.DNPKIGDLNKO.sprite = this.idleState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 387f;
				return;
			}
			break;
		case HGJINNBJPKJ.selected:
			if (null != this.DNPKIGDLNKO && null != this.selectedState)
			{
				this.DNPKIGDLNKO.sprite = this.selectedState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 132f;
				return;
			}
			break;
		case HGJINNBJPKJ.unavailable:
			if (null != this.DNPKIGDLNKO && null != this.unavailableState)
			{
				this.DNPKIGDLNKO.sprite = this.unavailableState;
				return;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 382f;
			}
			break;
		default:
			return;
		}
	}

	// Token: 0x06008009 RID: 32777 RVA: 0x00003E52 File Offset: 0x00002052
	private void GOCGNPBBCIO()
	{
	}

	// Token: 0x0600800A RID: 32778 RVA: 0x0038A87B File Offset: 0x00388A7B
	private void LPCKKJNJJCB()
	{
		this.DNPKIGDLNKO = base.gameObject.GetComponent<Image>();
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x0600800B RID: 32779 RVA: 0x0038B500 File Offset: 0x00389700
	public void IBHEGFNAIPC(HGJINNBJPKJ KNMIMLBLIGF)
	{
		switch (KNMIMLBLIGF)
		{
		case HGJINNBJPKJ.idle:
			if (null != this.DNPKIGDLNKO && null != this.idleState)
			{
				this.DNPKIGDLNKO.sprite = this.idleState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 81f;
				return;
			}
			break;
		case HGJINNBJPKJ.selected:
			if (null != this.DNPKIGDLNKO && null != this.selectedState)
			{
				this.DNPKIGDLNKO.sprite = this.selectedState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 1305f;
				return;
			}
			break;
		case HGJINNBJPKJ.unavailable:
			if (null != this.DNPKIGDLNKO && null != this.unavailableState)
			{
				this.DNPKIGDLNKO.sprite = this.unavailableState;
				return;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 65f;
			}
			break;
		default:
			return;
		}
	}

	// Token: 0x0600800C RID: 32780 RVA: 0x00003E52 File Offset: 0x00002052
	private void OOHKGEPBDIG()
	{
	}

	// Token: 0x0600800D RID: 32781 RVA: 0x0038A87B File Offset: 0x00388A7B
	private void GEJFLNPODAD()
	{
		this.DNPKIGDLNKO = base.gameObject.GetComponent<Image>();
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x0600800E RID: 32782 RVA: 0x0038B608 File Offset: 0x00389808
	public void BNMAGKFBANO(HGJINNBJPKJ KNMIMLBLIGF)
	{
		switch (KNMIMLBLIGF)
		{
		case HGJINNBJPKJ.idle:
			if (null != this.DNPKIGDLNKO && null != this.idleState)
			{
				this.DNPKIGDLNKO.sprite = this.idleState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 1393f;
				return;
			}
			break;
		case HGJINNBJPKJ.selected:
			if (null != this.DNPKIGDLNKO && null != this.selectedState)
			{
				this.DNPKIGDLNKO.sprite = this.selectedState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 520f;
				return;
			}
			break;
		case HGJINNBJPKJ.unavailable:
			if (null != this.DNPKIGDLNKO && null != this.unavailableState)
			{
				this.DNPKIGDLNKO.sprite = this.unavailableState;
				return;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 1740f;
			}
			break;
		default:
			return;
		}
	}

	// Token: 0x0600800F RID: 32783 RVA: 0x0038A87B File Offset: 0x00388A7B
	private void IJIDLNOIHCD()
	{
		this.DNPKIGDLNKO = base.gameObject.GetComponent<Image>();
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06008010 RID: 32784 RVA: 0x0038A87B File Offset: 0x00388A7B
	private void LPEDJEOJIFP()
	{
		this.DNPKIGDLNKO = base.gameObject.GetComponent<Image>();
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06008011 RID: 32785 RVA: 0x0038B710 File Offset: 0x00389910
	public void ALJBOCJHCDD(HGJINNBJPKJ KNMIMLBLIGF)
	{
		switch (KNMIMLBLIGF)
		{
		case HGJINNBJPKJ.idle:
			if (null != this.DNPKIGDLNKO && null != this.idleState)
			{
				this.DNPKIGDLNKO.sprite = this.idleState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 962f;
				return;
			}
			break;
		case HGJINNBJPKJ.selected:
			if (null != this.DNPKIGDLNKO && null != this.selectedState)
			{
				this.DNPKIGDLNKO.sprite = this.selectedState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 481f;
				return;
			}
			break;
		case HGJINNBJPKJ.unavailable:
			if (null != this.DNPKIGDLNKO && null != this.unavailableState)
			{
				this.DNPKIGDLNKO.sprite = this.unavailableState;
				return;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 825f;
			}
			break;
		default:
			return;
		}
	}

	// Token: 0x06008012 RID: 32786 RVA: 0x00003E52 File Offset: 0x00002052
	private void DCOGIJMKHMJ()
	{
	}

	// Token: 0x06008013 RID: 32787 RVA: 0x00003E52 File Offset: 0x00002052
	private void FDFMDEOMJBH()
	{
	}

	// Token: 0x06008014 RID: 32788 RVA: 0x00003E52 File Offset: 0x00002052
	private void CEDGALPCOLA()
	{
	}

	// Token: 0x06008015 RID: 32789 RVA: 0x0038B818 File Offset: 0x00389A18
	public void EFLFAIBLLEM(HGJINNBJPKJ KNMIMLBLIGF)
	{
		switch (KNMIMLBLIGF)
		{
		case HGJINNBJPKJ.idle:
			if (null != this.DNPKIGDLNKO && null != this.idleState)
			{
				this.DNPKIGDLNKO.sprite = this.idleState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 1515f;
				return;
			}
			break;
		case HGJINNBJPKJ.selected:
			if (null != this.DNPKIGDLNKO && null != this.selectedState)
			{
				this.DNPKIGDLNKO.sprite = this.selectedState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 486f;
				return;
			}
			break;
		case HGJINNBJPKJ.unavailable:
			if (null != this.DNPKIGDLNKO && null != this.unavailableState)
			{
				this.DNPKIGDLNKO.sprite = this.unavailableState;
				return;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 276f;
			}
			break;
		default:
			return;
		}
	}

	// Token: 0x06008016 RID: 32790 RVA: 0x0038B920 File Offset: 0x00389B20
	public void LMDABBDGFAH(HGJINNBJPKJ KNMIMLBLIGF)
	{
		switch (KNMIMLBLIGF)
		{
		case HGJINNBJPKJ.idle:
			if (null != this.DNPKIGDLNKO && null != this.idleState)
			{
				this.DNPKIGDLNKO.sprite = this.idleState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 627f;
				return;
			}
			break;
		case HGJINNBJPKJ.selected:
			if (null != this.DNPKIGDLNKO && null != this.selectedState)
			{
				this.DNPKIGDLNKO.sprite = this.selectedState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 1140f;
				return;
			}
			break;
		case HGJINNBJPKJ.unavailable:
			if (null != this.DNPKIGDLNKO && null != this.unavailableState)
			{
				this.DNPKIGDLNKO.sprite = this.unavailableState;
				return;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 1195f;
			}
			break;
		default:
			return;
		}
	}

	// Token: 0x06008017 RID: 32791 RVA: 0x00003E52 File Offset: 0x00002052
	private void LLDCFHGMAML()
	{
	}

	// Token: 0x06008018 RID: 32792 RVA: 0x0038A87B File Offset: 0x00388A7B
	private void JDBJMNMBOMK()
	{
		this.DNPKIGDLNKO = base.gameObject.GetComponent<Image>();
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06008019 RID: 32793 RVA: 0x0038A87B File Offset: 0x00388A7B
	private void KDNKCFGANFN()
	{
		this.DNPKIGDLNKO = base.gameObject.GetComponent<Image>();
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x0600801A RID: 32794 RVA: 0x00003E52 File Offset: 0x00002052
	private void FDOPMEKNMEA()
	{
	}

	// Token: 0x0600801B RID: 32795 RVA: 0x00003E52 File Offset: 0x00002052
	private void GKMBPHPJAAP()
	{
	}

	// Token: 0x0600801C RID: 32796 RVA: 0x0038A87B File Offset: 0x00388A7B
	private void OOMMKGMBAGK()
	{
		this.DNPKIGDLNKO = base.gameObject.GetComponent<Image>();
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x0600801D RID: 32797 RVA: 0x0038A87B File Offset: 0x00388A7B
	private void APICKNHCEDC()
	{
		this.DNPKIGDLNKO = base.gameObject.GetComponent<Image>();
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x0600801E RID: 32798 RVA: 0x00003E52 File Offset: 0x00002052
	private void HBLDAPMPKAB()
	{
	}

	// Token: 0x0600801F RID: 32799 RVA: 0x0038A87B File Offset: 0x00388A7B
	private void ANPIDDAIALE()
	{
		this.DNPKIGDLNKO = base.gameObject.GetComponent<Image>();
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06008020 RID: 32800 RVA: 0x00003E52 File Offset: 0x00002052
	private void PKMPOFOOGFK()
	{
	}

	// Token: 0x06008021 RID: 32801 RVA: 0x00003E52 File Offset: 0x00002052
	private void GEHKPILFMLD()
	{
	}

	// Token: 0x06008022 RID: 32802 RVA: 0x0038BA28 File Offset: 0x00389C28
	public void KENPEEBPNNA(HGJINNBJPKJ KNMIMLBLIGF)
	{
		switch (KNMIMLBLIGF)
		{
		case HGJINNBJPKJ.idle:
			if (null != this.DNPKIGDLNKO && null != this.idleState)
			{
				this.DNPKIGDLNKO.sprite = this.idleState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 635f;
				return;
			}
			break;
		case HGJINNBJPKJ.selected:
			if (null != this.DNPKIGDLNKO && null != this.selectedState)
			{
				this.DNPKIGDLNKO.sprite = this.selectedState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 1875f;
				return;
			}
			break;
		case HGJINNBJPKJ.unavailable:
			if (null != this.DNPKIGDLNKO && null != this.unavailableState)
			{
				this.DNPKIGDLNKO.sprite = this.unavailableState;
				return;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 1035f;
			}
			break;
		default:
			return;
		}
	}

	// Token: 0x06008023 RID: 32803 RVA: 0x0038BB30 File Offset: 0x00389D30
	public void CMNCGBDJEIA(HGJINNBJPKJ KNMIMLBLIGF)
	{
		switch (KNMIMLBLIGF)
		{
		case HGJINNBJPKJ.idle:
			if (null != this.DNPKIGDLNKO && null != this.idleState)
			{
				this.DNPKIGDLNKO.sprite = this.idleState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 1899f;
				return;
			}
			break;
		case HGJINNBJPKJ.selected:
			if (null != this.DNPKIGDLNKO && null != this.selectedState)
			{
				this.DNPKIGDLNKO.sprite = this.selectedState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 586f;
				return;
			}
			break;
		case HGJINNBJPKJ.unavailable:
			if (null != this.DNPKIGDLNKO && null != this.unavailableState)
			{
				this.DNPKIGDLNKO.sprite = this.unavailableState;
				return;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 1391f;
			}
			break;
		default:
			return;
		}
	}

	// Token: 0x06008024 RID: 32804 RVA: 0x0038A87B File Offset: 0x00388A7B
	private void HONBHBCFLNF()
	{
		this.DNPKIGDLNKO = base.gameObject.GetComponent<Image>();
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06008025 RID: 32805 RVA: 0x0038BC38 File Offset: 0x00389E38
	public void FMBBHFKHKLB(HGJINNBJPKJ KNMIMLBLIGF)
	{
		switch (KNMIMLBLIGF)
		{
		case HGJINNBJPKJ.idle:
			if (null != this.DNPKIGDLNKO && null != this.idleState)
			{
				this.DNPKIGDLNKO.sprite = this.idleState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 1107f;
				return;
			}
			break;
		case HGJINNBJPKJ.selected:
			if (null != this.DNPKIGDLNKO && null != this.selectedState)
			{
				this.DNPKIGDLNKO.sprite = this.selectedState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 1180f;
				return;
			}
			break;
		case HGJINNBJPKJ.unavailable:
			if (null != this.DNPKIGDLNKO && null != this.unavailableState)
			{
				this.DNPKIGDLNKO.sprite = this.unavailableState;
				return;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 443f;
			}
			break;
		default:
			return;
		}
	}

	// Token: 0x06008026 RID: 32806 RVA: 0x0038A87B File Offset: 0x00388A7B
	private void GFOCPBFLJFC()
	{
		this.DNPKIGDLNKO = base.gameObject.GetComponent<Image>();
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06008027 RID: 32807 RVA: 0x0038A87B File Offset: 0x00388A7B
	private void DBMENPFHHCM()
	{
		this.DNPKIGDLNKO = base.gameObject.GetComponent<Image>();
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06008028 RID: 32808 RVA: 0x00003E52 File Offset: 0x00002052
	private void JCOIBJANCMG()
	{
	}

	// Token: 0x06008029 RID: 32809 RVA: 0x00003E52 File Offset: 0x00002052
	private void MDBCIDKEFAI()
	{
	}

	// Token: 0x0600802A RID: 32810 RVA: 0x0038BD40 File Offset: 0x00389F40
	public void GPFAEBDDMBH(HGJINNBJPKJ KNMIMLBLIGF)
	{
		switch (KNMIMLBLIGF)
		{
		case HGJINNBJPKJ.idle:
			if (null != this.DNPKIGDLNKO && null != this.idleState)
			{
				this.DNPKIGDLNKO.sprite = this.idleState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 490f;
				return;
			}
			break;
		case HGJINNBJPKJ.selected:
			if (null != this.DNPKIGDLNKO && null != this.selectedState)
			{
				this.DNPKIGDLNKO.sprite = this.selectedState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 1761f;
				return;
			}
			break;
		case HGJINNBJPKJ.unavailable:
			if (null != this.DNPKIGDLNKO && null != this.unavailableState)
			{
				this.DNPKIGDLNKO.sprite = this.unavailableState;
				return;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 642f;
			}
			break;
		default:
			return;
		}
	}

	// Token: 0x0600802B RID: 32811 RVA: 0x00003E52 File Offset: 0x00002052
	private void HMMLCHDFFBI()
	{
	}

	// Token: 0x0600802C RID: 32812 RVA: 0x00003E52 File Offset: 0x00002052
	private void Start()
	{
	}

	// Token: 0x0600802D RID: 32813 RVA: 0x0038BE48 File Offset: 0x0038A048
	public void PDLEANIIBLO(HGJINNBJPKJ KNMIMLBLIGF)
	{
		switch (KNMIMLBLIGF)
		{
		case HGJINNBJPKJ.idle:
			if (null != this.DNPKIGDLNKO && null != this.idleState)
			{
				this.DNPKIGDLNKO.sprite = this.idleState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 1628f;
				return;
			}
			break;
		case HGJINNBJPKJ.selected:
			if (null != this.DNPKIGDLNKO && null != this.selectedState)
			{
				this.DNPKIGDLNKO.sprite = this.selectedState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 1225f;
				return;
			}
			break;
		case HGJINNBJPKJ.unavailable:
			if (null != this.DNPKIGDLNKO && null != this.unavailableState)
			{
				this.DNPKIGDLNKO.sprite = this.unavailableState;
				return;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 1226f;
			}
			break;
		default:
			return;
		}
	}

	// Token: 0x0600802E RID: 32814 RVA: 0x0038A87B File Offset: 0x00388A7B
	private void PHHELAPHLOK()
	{
		this.DNPKIGDLNKO = base.gameObject.GetComponent<Image>();
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x0600802F RID: 32815 RVA: 0x0038BF50 File Offset: 0x0038A150
	public void DNCEEIFLMJC(HGJINNBJPKJ KNMIMLBLIGF)
	{
		switch (KNMIMLBLIGF)
		{
		case HGJINNBJPKJ.idle:
			if (null != this.DNPKIGDLNKO && null != this.idleState)
			{
				this.DNPKIGDLNKO.sprite = this.idleState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 355f;
				return;
			}
			break;
		case HGJINNBJPKJ.selected:
			if (null != this.DNPKIGDLNKO && null != this.selectedState)
			{
				this.DNPKIGDLNKO.sprite = this.selectedState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 875f;
				return;
			}
			break;
		case HGJINNBJPKJ.unavailable:
			if (null != this.DNPKIGDLNKO && null != this.unavailableState)
			{
				this.DNPKIGDLNKO.sprite = this.unavailableState;
				return;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 1044f;
			}
			break;
		default:
			return;
		}
	}

	// Token: 0x06008030 RID: 32816 RVA: 0x0038C058 File Offset: 0x0038A258
	public void BBPFEIEJIMG(HGJINNBJPKJ KNMIMLBLIGF)
	{
		switch (KNMIMLBLIGF)
		{
		case HGJINNBJPKJ.idle:
			if (null != this.DNPKIGDLNKO && null != this.idleState)
			{
				this.DNPKIGDLNKO.sprite = this.idleState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 1539f;
				return;
			}
			break;
		case HGJINNBJPKJ.selected:
			if (null != this.DNPKIGDLNKO && null != this.selectedState)
			{
				this.DNPKIGDLNKO.sprite = this.selectedState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 750f;
				return;
			}
			break;
		case HGJINNBJPKJ.unavailable:
			if (null != this.DNPKIGDLNKO && null != this.unavailableState)
			{
				this.DNPKIGDLNKO.sprite = this.unavailableState;
				return;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 1111f;
			}
			break;
		default:
			return;
		}
	}

	// Token: 0x06008031 RID: 32817 RVA: 0x0038C160 File Offset: 0x0038A360
	public void BPKDHBCCKLK(HGJINNBJPKJ KNMIMLBLIGF)
	{
		switch (KNMIMLBLIGF)
		{
		case HGJINNBJPKJ.idle:
			if (null != this.DNPKIGDLNKO && null != this.idleState)
			{
				this.DNPKIGDLNKO.sprite = this.idleState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 221f;
				return;
			}
			break;
		case HGJINNBJPKJ.selected:
			if (null != this.DNPKIGDLNKO && null != this.selectedState)
			{
				this.DNPKIGDLNKO.sprite = this.selectedState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 1116f;
				return;
			}
			break;
		case HGJINNBJPKJ.unavailable:
			if (null != this.DNPKIGDLNKO && null != this.unavailableState)
			{
				this.DNPKIGDLNKO.sprite = this.unavailableState;
				return;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 1304f;
			}
			break;
		default:
			return;
		}
	}

	// Token: 0x06008032 RID: 32818 RVA: 0x0038C268 File Offset: 0x0038A468
	public void GEJBFNJIKBF(HGJINNBJPKJ KNMIMLBLIGF)
	{
		switch (KNMIMLBLIGF)
		{
		case HGJINNBJPKJ.idle:
			if (null != this.DNPKIGDLNKO && null != this.idleState)
			{
				this.DNPKIGDLNKO.sprite = this.idleState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 171f;
				return;
			}
			break;
		case HGJINNBJPKJ.selected:
			if (null != this.DNPKIGDLNKO && null != this.selectedState)
			{
				this.DNPKIGDLNKO.sprite = this.selectedState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 117f;
				return;
			}
			break;
		case HGJINNBJPKJ.unavailable:
			if (null != this.DNPKIGDLNKO && null != this.unavailableState)
			{
				this.DNPKIGDLNKO.sprite = this.unavailableState;
				return;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 563f;
			}
			break;
		default:
			return;
		}
	}

	// Token: 0x06008033 RID: 32819 RVA: 0x0038C370 File Offset: 0x0038A570
	public void GLFABMBEKJD(HGJINNBJPKJ KNMIMLBLIGF)
	{
		switch (KNMIMLBLIGF)
		{
		case HGJINNBJPKJ.idle:
			if (null != this.DNPKIGDLNKO && null != this.idleState)
			{
				this.DNPKIGDLNKO.sprite = this.idleState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 1518f;
				return;
			}
			break;
		case HGJINNBJPKJ.selected:
			if (null != this.DNPKIGDLNKO && null != this.selectedState)
			{
				this.DNPKIGDLNKO.sprite = this.selectedState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 1229f;
				return;
			}
			break;
		case HGJINNBJPKJ.unavailable:
			if (null != this.DNPKIGDLNKO && null != this.unavailableState)
			{
				this.DNPKIGDLNKO.sprite = this.unavailableState;
				return;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 363f;
			}
			break;
		default:
			return;
		}
	}

	// Token: 0x06008034 RID: 32820 RVA: 0x00003E52 File Offset: 0x00002052
	private void PBNCKCPKIGE()
	{
	}

	// Token: 0x06008035 RID: 32821 RVA: 0x0038C478 File Offset: 0x0038A678
	public void NAKMLFPPMME(HGJINNBJPKJ KNMIMLBLIGF)
	{
		switch (KNMIMLBLIGF)
		{
		case HGJINNBJPKJ.idle:
			if (null != this.DNPKIGDLNKO && null != this.idleState)
			{
				this.DNPKIGDLNKO.sprite = this.idleState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 109f;
				return;
			}
			break;
		case HGJINNBJPKJ.selected:
			if (null != this.DNPKIGDLNKO && null != this.selectedState)
			{
				this.DNPKIGDLNKO.sprite = this.selectedState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 1990f;
				return;
			}
			break;
		case HGJINNBJPKJ.unavailable:
			if (null != this.DNPKIGDLNKO && null != this.unavailableState)
			{
				this.DNPKIGDLNKO.sprite = this.unavailableState;
				return;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 645f;
			}
			break;
		default:
			return;
		}
	}

	// Token: 0x06008036 RID: 32822 RVA: 0x00003E52 File Offset: 0x00002052
	private void AIFMKCMOHNJ()
	{
	}

	// Token: 0x06008037 RID: 32823 RVA: 0x00003E52 File Offset: 0x00002052
	private void JIJOFPBPBFP()
	{
	}

	// Token: 0x06008038 RID: 32824 RVA: 0x00003E52 File Offset: 0x00002052
	private void IOGKPKFCKCN()
	{
	}

	// Token: 0x06008039 RID: 32825 RVA: 0x0038C580 File Offset: 0x0038A780
	public void BICNGDJFPDK(HGJINNBJPKJ KNMIMLBLIGF)
	{
		switch (KNMIMLBLIGF)
		{
		case HGJINNBJPKJ.idle:
			if (null != this.DNPKIGDLNKO && null != this.idleState)
			{
				this.DNPKIGDLNKO.sprite = this.idleState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 262f;
				return;
			}
			break;
		case HGJINNBJPKJ.selected:
			if (null != this.DNPKIGDLNKO && null != this.selectedState)
			{
				this.DNPKIGDLNKO.sprite = this.selectedState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 1493f;
				return;
			}
			break;
		case HGJINNBJPKJ.unavailable:
			if (null != this.DNPKIGDLNKO && null != this.unavailableState)
			{
				this.DNPKIGDLNKO.sprite = this.unavailableState;
				return;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 641f;
			}
			break;
		default:
			return;
		}
	}

	// Token: 0x0600803A RID: 32826 RVA: 0x0038A87B File Offset: 0x00388A7B
	private void ECDLFGCLAGG()
	{
		this.DNPKIGDLNKO = base.gameObject.GetComponent<Image>();
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x0600803B RID: 32827 RVA: 0x0038A87B File Offset: 0x00388A7B
	private void JGNIEMNKHJP()
	{
		this.DNPKIGDLNKO = base.gameObject.GetComponent<Image>();
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x0600803C RID: 32828 RVA: 0x0038A87B File Offset: 0x00388A7B
	private void OJGELECJGJC()
	{
		this.DNPKIGDLNKO = base.gameObject.GetComponent<Image>();
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x0600803D RID: 32829 RVA: 0x0038A87B File Offset: 0x00388A7B
	private void JNCLGOBJGJD()
	{
		this.DNPKIGDLNKO = base.gameObject.GetComponent<Image>();
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x0600803E RID: 32830 RVA: 0x0038A87B File Offset: 0x00388A7B
	private void EIIKCHOGIBH()
	{
		this.DNPKIGDLNKO = base.gameObject.GetComponent<Image>();
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x0600803F RID: 32831 RVA: 0x0038A87B File Offset: 0x00388A7B
	private void FFHLHFLBJIN()
	{
		this.DNPKIGDLNKO = base.gameObject.GetComponent<Image>();
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06008040 RID: 32832 RVA: 0x0038A87B File Offset: 0x00388A7B
	private void FLGIOJBKGIM()
	{
		this.DNPKIGDLNKO = base.gameObject.GetComponent<Image>();
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06008041 RID: 32833 RVA: 0x00003E52 File Offset: 0x00002052
	private void PABLFIJDFAD()
	{
	}

	// Token: 0x06008042 RID: 32834 RVA: 0x0038A87B File Offset: 0x00388A7B
	private void KBIIMONICOB()
	{
		this.DNPKIGDLNKO = base.gameObject.GetComponent<Image>();
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06008043 RID: 32835 RVA: 0x00003E52 File Offset: 0x00002052
	private void BDMGHFPMOAG()
	{
	}

	// Token: 0x06008044 RID: 32836 RVA: 0x0038A87B File Offset: 0x00388A7B
	private void AMAKEBJMCLG()
	{
		this.DNPKIGDLNKO = base.gameObject.GetComponent<Image>();
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06008045 RID: 32837 RVA: 0x0038A87B File Offset: 0x00388A7B
	private void LJCOLPBKBBH()
	{
		this.DNPKIGDLNKO = base.gameObject.GetComponent<Image>();
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06008046 RID: 32838 RVA: 0x0038A87B File Offset: 0x00388A7B
	private void GMPHANBKGBK()
	{
		this.DNPKIGDLNKO = base.gameObject.GetComponent<Image>();
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06008047 RID: 32839 RVA: 0x0038C688 File Offset: 0x0038A888
	public void NHFHNHADJHH(HGJINNBJPKJ KNMIMLBLIGF)
	{
		switch (KNMIMLBLIGF)
		{
		case HGJINNBJPKJ.idle:
			if (null != this.DNPKIGDLNKO && null != this.idleState)
			{
				this.DNPKIGDLNKO.sprite = this.idleState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 1502f;
				return;
			}
			break;
		case HGJINNBJPKJ.selected:
			if (null != this.DNPKIGDLNKO && null != this.selectedState)
			{
				this.DNPKIGDLNKO.sprite = this.selectedState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 1673f;
				return;
			}
			break;
		case HGJINNBJPKJ.unavailable:
			if (null != this.DNPKIGDLNKO && null != this.unavailableState)
			{
				this.DNPKIGDLNKO.sprite = this.unavailableState;
				return;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 556f;
			}
			break;
		default:
			return;
		}
	}

	// Token: 0x06008048 RID: 32840 RVA: 0x00003E52 File Offset: 0x00002052
	private void LIMPPDFLOOC()
	{
	}

	// Token: 0x06008049 RID: 32841 RVA: 0x0038C790 File Offset: 0x0038A990
	public void GHINJEGCFDO(HGJINNBJPKJ KNMIMLBLIGF)
	{
		switch (KNMIMLBLIGF)
		{
		case HGJINNBJPKJ.idle:
			if (null != this.DNPKIGDLNKO && null != this.idleState)
			{
				this.DNPKIGDLNKO.sprite = this.idleState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 1538f;
				return;
			}
			break;
		case HGJINNBJPKJ.selected:
			if (null != this.DNPKIGDLNKO && null != this.selectedState)
			{
				this.DNPKIGDLNKO.sprite = this.selectedState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 716f;
				return;
			}
			break;
		case HGJINNBJPKJ.unavailable:
			if (null != this.DNPKIGDLNKO && null != this.unavailableState)
			{
				this.DNPKIGDLNKO.sprite = this.unavailableState;
				return;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 667f;
			}
			break;
		default:
			return;
		}
	}

	// Token: 0x0600804A RID: 32842 RVA: 0x0038C898 File Offset: 0x0038AA98
	public void AKHNJAGCNCI(HGJINNBJPKJ KNMIMLBLIGF)
	{
		switch (KNMIMLBLIGF)
		{
		case HGJINNBJPKJ.idle:
			if (null != this.DNPKIGDLNKO && null != this.idleState)
			{
				this.DNPKIGDLNKO.sprite = this.idleState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 637f;
				return;
			}
			break;
		case HGJINNBJPKJ.selected:
			if (null != this.DNPKIGDLNKO && null != this.selectedState)
			{
				this.DNPKIGDLNKO.sprite = this.selectedState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 1145f;
				return;
			}
			break;
		case HGJINNBJPKJ.unavailable:
			if (null != this.DNPKIGDLNKO && null != this.unavailableState)
			{
				this.DNPKIGDLNKO.sprite = this.unavailableState;
				return;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 1969f;
			}
			break;
		default:
			return;
		}
	}

	// Token: 0x0600804B RID: 32843 RVA: 0x00003E52 File Offset: 0x00002052
	private void OHPNGFAIGEM()
	{
	}

	// Token: 0x0600804C RID: 32844 RVA: 0x00003E52 File Offset: 0x00002052
	private void LJJJIPGIJJC()
	{
	}

	// Token: 0x0600804D RID: 32845 RVA: 0x00003E52 File Offset: 0x00002052
	private void PDEEDGHFAEJ()
	{
	}

	// Token: 0x0600804E RID: 32846 RVA: 0x0038C9A0 File Offset: 0x0038ABA0
	public void CGKHNPAAJII(HGJINNBJPKJ KNMIMLBLIGF)
	{
		switch (KNMIMLBLIGF)
		{
		case HGJINNBJPKJ.idle:
			if (null != this.DNPKIGDLNKO && null != this.idleState)
			{
				this.DNPKIGDLNKO.sprite = this.idleState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 1405f;
				return;
			}
			break;
		case HGJINNBJPKJ.selected:
			if (null != this.DNPKIGDLNKO && null != this.selectedState)
			{
				this.DNPKIGDLNKO.sprite = this.selectedState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 773f;
				return;
			}
			break;
		case HGJINNBJPKJ.unavailable:
			if (null != this.DNPKIGDLNKO && null != this.unavailableState)
			{
				this.DNPKIGDLNKO.sprite = this.unavailableState;
				return;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 816f;
			}
			break;
		default:
			return;
		}
	}

	// Token: 0x0600804F RID: 32847 RVA: 0x00003E52 File Offset: 0x00002052
	private void MIMOJFLJLFO()
	{
	}

	// Token: 0x06008050 RID: 32848 RVA: 0x00003E52 File Offset: 0x00002052
	private void CHIODHJHKLG()
	{
	}

	// Token: 0x06008051 RID: 32849 RVA: 0x0038A87B File Offset: 0x00388A7B
	private void NGPCCGAKIHA()
	{
		this.DNPKIGDLNKO = base.gameObject.GetComponent<Image>();
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06008052 RID: 32850 RVA: 0x0038A87B File Offset: 0x00388A7B
	private void CIHNHBCEAMI()
	{
		this.DNPKIGDLNKO = base.gameObject.GetComponent<Image>();
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06008053 RID: 32851 RVA: 0x0038CAA8 File Offset: 0x0038ACA8
	public void DCCGKIMGACF(HGJINNBJPKJ KNMIMLBLIGF)
	{
		switch (KNMIMLBLIGF)
		{
		case HGJINNBJPKJ.idle:
			if (null != this.DNPKIGDLNKO && null != this.idleState)
			{
				this.DNPKIGDLNKO.sprite = this.idleState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 1068f;
				return;
			}
			break;
		case HGJINNBJPKJ.selected:
			if (null != this.DNPKIGDLNKO && null != this.selectedState)
			{
				this.DNPKIGDLNKO.sprite = this.selectedState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 523f;
				return;
			}
			break;
		case HGJINNBJPKJ.unavailable:
			if (null != this.DNPKIGDLNKO && null != this.unavailableState)
			{
				this.DNPKIGDLNKO.sprite = this.unavailableState;
				return;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 1260f;
			}
			break;
		default:
			return;
		}
	}

	// Token: 0x06008054 RID: 32852 RVA: 0x00003E52 File Offset: 0x00002052
	private void KLFNFIFOHFD()
	{
	}

	// Token: 0x06008055 RID: 32853 RVA: 0x0038A87B File Offset: 0x00388A7B
	private void CGLFKMJKOLJ()
	{
		this.DNPKIGDLNKO = base.gameObject.GetComponent<Image>();
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06008057 RID: 32855 RVA: 0x0038A87B File Offset: 0x00388A7B
	private void EPHNKBBGCAK()
	{
		this.DNPKIGDLNKO = base.gameObject.GetComponent<Image>();
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06008058 RID: 32856 RVA: 0x0038CBB0 File Offset: 0x0038ADB0
	public void OEPEBEOMBPI(HGJINNBJPKJ KNMIMLBLIGF)
	{
		switch (KNMIMLBLIGF)
		{
		case HGJINNBJPKJ.idle:
			if (null != this.DNPKIGDLNKO && null != this.idleState)
			{
				this.DNPKIGDLNKO.sprite = this.idleState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 861f;
				return;
			}
			break;
		case HGJINNBJPKJ.selected:
			if (null != this.DNPKIGDLNKO && null != this.selectedState)
			{
				this.DNPKIGDLNKO.sprite = this.selectedState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 784f;
				return;
			}
			break;
		case HGJINNBJPKJ.unavailable:
			if (null != this.DNPKIGDLNKO && null != this.unavailableState)
			{
				this.DNPKIGDLNKO.sprite = this.unavailableState;
				return;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 201f;
			}
			break;
		default:
			return;
		}
	}

	// Token: 0x06008059 RID: 32857 RVA: 0x0038CCB8 File Offset: 0x0038AEB8
	public void EOANFHCIOIB(HGJINNBJPKJ KNMIMLBLIGF)
	{
		switch (KNMIMLBLIGF)
		{
		case HGJINNBJPKJ.idle:
			if (null != this.DNPKIGDLNKO && null != this.idleState)
			{
				this.DNPKIGDLNKO.sprite = this.idleState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 728f;
				return;
			}
			break;
		case HGJINNBJPKJ.selected:
			if (null != this.DNPKIGDLNKO && null != this.selectedState)
			{
				this.DNPKIGDLNKO.sprite = this.selectedState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 1872f;
				return;
			}
			break;
		case HGJINNBJPKJ.unavailable:
			if (null != this.DNPKIGDLNKO && null != this.unavailableState)
			{
				this.DNPKIGDLNKO.sprite = this.unavailableState;
				return;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 1370f;
			}
			break;
		default:
			return;
		}
	}

	// Token: 0x0600805A RID: 32858 RVA: 0x0038CDC0 File Offset: 0x0038AFC0
	public void CFEKBKLODOG(HGJINNBJPKJ KNMIMLBLIGF)
	{
		switch (KNMIMLBLIGF)
		{
		case HGJINNBJPKJ.idle:
			if (null != this.DNPKIGDLNKO && null != this.idleState)
			{
				this.DNPKIGDLNKO.sprite = this.idleState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 1358f;
				return;
			}
			break;
		case HGJINNBJPKJ.selected:
			if (null != this.DNPKIGDLNKO && null != this.selectedState)
			{
				this.DNPKIGDLNKO.sprite = this.selectedState;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 1783f;
				return;
			}
			break;
		case HGJINNBJPKJ.unavailable:
			if (null != this.DNPKIGDLNKO && null != this.unavailableState)
			{
				this.DNPKIGDLNKO.sprite = this.unavailableState;
				return;
			}
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 1677f;
			}
			break;
		default:
			return;
		}
	}

	// Token: 0x0600805B RID: 32859 RVA: 0x0038A87B File Offset: 0x00388A7B
	private void KICOCDCNDGG()
	{
		this.DNPKIGDLNKO = base.gameObject.GetComponent<Image>();
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x0600805C RID: 32860 RVA: 0x00003E52 File Offset: 0x00002052
	private void HLCCOGFOMHA()
	{
	}

	// Token: 0x0600805D RID: 32861 RVA: 0x0038A87B File Offset: 0x00388A7B
	private void DFEDGLDNOBH()
	{
		this.DNPKIGDLNKO = base.gameObject.GetComponent<Image>();
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x0600805E RID: 32862 RVA: 0x0038A87B File Offset: 0x00388A7B
	private void FIGJOFLIKKI()
	{
		this.DNPKIGDLNKO = base.gameObject.GetComponent<Image>();
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x0600805F RID: 32863 RVA: 0x0038A87B File Offset: 0x00388A7B
	private void PCMFCIDHKCL()
	{
		this.DNPKIGDLNKO = base.gameObject.GetComponent<Image>();
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x040024D8 RID: 9432
	public Sprite idleState;

	// Token: 0x040024D9 RID: 9433
	public Sprite selectedState;

	// Token: 0x040024DA RID: 9434
	public Sprite unavailableState;

	// Token: 0x040024DB RID: 9435
	private Image DNPKIGDLNKO;

	// Token: 0x040024DC RID: 9436
	private CanvasGroup PANMNKKODPC;
}
