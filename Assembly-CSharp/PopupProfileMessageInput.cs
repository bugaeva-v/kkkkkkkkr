using System;
using System.Collections;
using DG.Tweening;
using TMPro;
using UnityEngine;

// Token: 0x020002F1 RID: 753
public class PopupProfileMessageInput : MonoBehaviour
{
	// Token: 0x06005C22 RID: 23586 RVA: 0x002A26C3 File Offset: 0x002A08C3
	private void BMNDCBEKEPD()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
	}

	// Token: 0x06005C23 RID: 23587 RVA: 0x002A26E0 File Offset: 0x002A08E0
	private void GHIDMBEKDJP()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(923f, 42f);
		}
	}

	// Token: 0x06005C24 RID: 23588 RVA: 0x002A2706 File Offset: 0x002A0906
	private void JCBDPHJHHPD()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1694f;
		}
	}

	// Token: 0x06005C25 RID: 23589 RVA: 0x002A2737 File Offset: 0x002A0937
	private IEnumerator OPBBIHJPLGI()
	{
		this.inputField.Select();
		yield return new WaitForSeconds(0.5f);
		this.inputField.ActivateInputField();
		yield break;
	}

	// Token: 0x06005C26 RID: 23590 RVA: 0x002A2746 File Offset: 0x002A0946
	public void OHKFINOHAII()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(763f, 828f);
		}
	}

	// Token: 0x06005C27 RID: 23591 RVA: 0x002A276C File Offset: 0x002A096C
	private IEnumerator KOGKAKKLIMO()
	{
		PopupProfileMessageInput.KKLFDNABPGB kklfdnabpgb = new PopupProfileMessageInput.KKLFDNABPGB(1);
		kklfdnabpgb.<>4__this = this;
		return kklfdnabpgb;
	}

	// Token: 0x06005C28 RID: 23592 RVA: 0x002A277B File Offset: 0x002A097B
	private void IFHJKBHODGG()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1754f;
		}
	}

	// Token: 0x06005C2A RID: 23594 RVA: 0x002A27AC File Offset: 0x002A09AC
	public void CAHCJPJOMKN()
	{
		this.inputField.DeactivateInputField(false);
		AOBJLALDBAA.NMGMNAKLLMI().KMAGHMCCMPG("", 528f);
		this.animatedPopupManager.GLIAGHMNMMP();
	}

	// Token: 0x06005C2B RID: 23595 RVA: 0x002A27D9 File Offset: 0x002A09D9
	private void DOECDMINNOK()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 531f;
		}
	}

	// Token: 0x06005C2C RID: 23596 RVA: 0x002A280A File Offset: 0x002A0A0A
	private void IPLLPHBHCPO()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 697f;
		}
	}

	// Token: 0x06005C2D RID: 23597 RVA: 0x002A283B File Offset: 0x002A0A3B
	public void NCNHIJNLFNB()
	{
		this.inputField.DeactivateInputField(true);
		AOBJLALDBAA.AGANFKKBPFO().CIGLHCJDDPI("Value:", 196f);
		this.animatedPopupManager.HFFJACPIHKE();
	}

	// Token: 0x06005C2E RID: 23598 RVA: 0x002A2868 File Offset: 0x002A0A68
	public void Show(int CPKFEMAOOBH)
	{
		this.MLKELKKMBLF = CPKFEMAOOBH;
		base.gameObject.SetActive(true);
		this.HDKFBJIMKBK();
		this.textInput.SetText("", true);
		base.StartCoroutine(this.CJAHEBHPJDB());
	}

	// Token: 0x06005C2F RID: 23599 RVA: 0x002A28A1 File Offset: 0x002A0AA1
	public void NJMNDHIJFII()
	{
		this.inputField.DeactivateInputField(false);
		AOBJLALDBAA.CEGAOMEEFBE().DCGCFPHHDDG("yes", 1681f);
		this.animatedPopupManager.FJAAHFFLGFF();
	}

	// Token: 0x06005C30 RID: 23600 RVA: 0x002A28D0 File Offset: 0x002A0AD0
	public void IMECHDOHCDM()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(false);
			AOBJLALDBAA.BIAEAOMHBMM().PMDEKGAFCCL("spinWheel", this.textInput.text);
			this.animatedPopupManager.NBDMOONDIHO();
			return;
		}
		this.CAHCJPJOMKN();
	}

	// Token: 0x06005C31 RID: 23601 RVA: 0x002A2737 File Offset: 0x002A0937
	private IEnumerator MCDNMBEDAFG()
	{
		this.inputField.Select();
		yield return new WaitForSeconds(0.5f);
		this.inputField.ActivateInputField();
		yield break;
	}

	// Token: 0x06005C32 RID: 23602 RVA: 0x00003E52 File Offset: 0x00002052
	private void CDGGIMPDMMA()
	{
	}

	// Token: 0x06005C33 RID: 23603 RVA: 0x002A2922 File Offset: 0x002A0B22
	private void KMKJELFDOCF()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(379f, 1291f);
		}
	}

	// Token: 0x06005C34 RID: 23604 RVA: 0x00003E52 File Offset: 0x00002052
	private void BDMGHFPMOAG()
	{
	}

	// Token: 0x06005C35 RID: 23605 RVA: 0x002A2948 File Offset: 0x002A0B48
	public void CPAGHIEJPBC(int CPKFEMAOOBH)
	{
		this.MLKELKKMBLF = CPKFEMAOOBH;
		base.gameObject.SetActive(false);
		this.LLALBILAMOP();
		this.textInput.SetText("ok", true);
		base.StartCoroutine(this.ADDOKDEFBLB());
	}

	// Token: 0x06005C36 RID: 23606 RVA: 0x002A2737 File Offset: 0x002A0937
	private IEnumerator CPBEEPAGHAK()
	{
		this.inputField.Select();
		yield return new WaitForSeconds(0.5f);
		this.inputField.ActivateInputField();
		yield break;
	}

	// Token: 0x06005C37 RID: 23607 RVA: 0x002A2737 File Offset: 0x002A0937
	private IEnumerator FBPGAIDHECC()
	{
		this.inputField.Select();
		yield return new WaitForSeconds(0.5f);
		this.inputField.ActivateInputField();
		yield break;
	}

	// Token: 0x06005C38 RID: 23608 RVA: 0x002A2981 File Offset: 0x002A0B81
	public void HAMCDKDLJKO()
	{
		this.inputField.DeactivateInputField(true);
		AOBJLALDBAA.FILDBDMENPG().FDKBIBKABCM("ttlfind", 58f);
		this.animatedPopupManager.KCAPIILJKDN();
	}

	// Token: 0x06005C39 RID: 23609 RVA: 0x002A29AE File Offset: 0x002A0BAE
	private void GMKJOIDPAIE()
	{
		this.KBDOBELHACC();
		this.textInput.SetText("", true);
		this.textInput.text = "UIEnvironmentsFront";
	}

	// Token: 0x06005C3A RID: 23610 RVA: 0x002A29D7 File Offset: 0x002A0BD7
	public void EOFOLPLJLOA()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1803f, 1585f);
		}
	}

	// Token: 0x06005C3B RID: 23611 RVA: 0x002A29FD File Offset: 0x002A0BFD
	private void Awake()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 0f;
		}
	}

	// Token: 0x06005C3C RID: 23612 RVA: 0x002A2A2E File Offset: 0x002A0C2E
	private void ECDLFGCLAGG()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 403f;
		}
	}

	// Token: 0x06005C3D RID: 23613 RVA: 0x002A2A5F File Offset: 0x002A0C5F
	public int AGHELFHILAP()
	{
		return this.MLKELKKMBLF;
	}

	// Token: 0x06005C3E RID: 23614 RVA: 0x002A2A67 File Offset: 0x002A0C67
	private void GMGJONBEDNE()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(true);
		}
	}

	// Token: 0x06005C3F RID: 23615 RVA: 0x00003E52 File Offset: 0x00002052
	private void BHDHJLIBHCJ()
	{
	}

	// Token: 0x06005C40 RID: 23616 RVA: 0x00003E52 File Offset: 0x00002052
	private void CJPNMBNKLOO()
	{
	}

	// Token: 0x06005C41 RID: 23617 RVA: 0x002A2A84 File Offset: 0x002A0C84
	private void DCMMAADPBPM()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 470f;
		}
	}

	// Token: 0x06005C42 RID: 23618 RVA: 0x002A276C File Offset: 0x002A096C
	private IEnumerator IMOBJFMDOAI()
	{
		PopupProfileMessageInput.KKLFDNABPGB kklfdnabpgb = new PopupProfileMessageInput.KKLFDNABPGB(1);
		kklfdnabpgb.<>4__this = this;
		return kklfdnabpgb;
	}

	// Token: 0x06005C43 RID: 23619 RVA: 0x002A2AB5 File Offset: 0x002A0CB5
	public void DisappearAnimation()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(0f, 0.5f);
		}
	}

	// Token: 0x06005C44 RID: 23620 RVA: 0x002A2ADB File Offset: 0x002A0CDB
	private void GBPFDKIIHJG()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1640f;
		}
	}

	// Token: 0x06005C45 RID: 23621 RVA: 0x002A2B0C File Offset: 0x002A0D0C
	public void JMNFGJJJNMI(int CPKFEMAOOBH)
	{
		this.MLKELKKMBLF = CPKFEMAOOBH;
		base.gameObject.SetActive(false);
		this.NMDHIPOJIGL();
		this.textInput.SetText("", true);
		base.StartCoroutine(this.KOGKAKKLIMO());
	}

	// Token: 0x06005C46 RID: 23622 RVA: 0x002A2B45 File Offset: 0x002A0D45
	private void AFGGOFOIFLC()
	{
		this.BDDOEBOPCFD();
		this.textInput.SetText("face", true);
		this.textInput.text = "ratd";
	}

	// Token: 0x06005C47 RID: 23623 RVA: 0x002A2B6E File Offset: 0x002A0D6E
	private void PHHELAPHLOK()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1221f;
		}
	}

	// Token: 0x06005C48 RID: 23624 RVA: 0x002A2B9F File Offset: 0x002A0D9F
	private void KBDOBELHACC()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(947f, 1538f);
		}
	}

	// Token: 0x06005C49 RID: 23625 RVA: 0x002A2BC5 File Offset: 0x002A0DC5
	public void NNNIMAAFAKL()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1799f, 572f);
		}
	}

	// Token: 0x06005C4A RID: 23626 RVA: 0x002A2A5F File Offset: 0x002A0C5F
	public int MIEDOPAKLCF()
	{
		return this.MLKELKKMBLF;
	}

	// Token: 0x06005C4B RID: 23627 RVA: 0x002A2BEC File Offset: 0x002A0DEC
	public void NPIPCPNBLDH()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(true);
			AOBJLALDBAA.NMGMNAKLLMI().FLLPDFLFEDA("OnToolsPopupSaveToCloudException", this.textInput.text);
			this.animatedPopupManager.PIPADCCGHBA();
			return;
		}
		this.CPFDJNKPJBF();
	}

	// Token: 0x06005C4C RID: 23628 RVA: 0x002A2C3E File Offset: 0x002A0E3E
	public void PCBCNGIDLMH(int CPKFEMAOOBH)
	{
		this.MLKELKKMBLF = CPKFEMAOOBH;
		base.gameObject.SetActive(false);
		this.MKCLBDDCDNM();
		this.textInput.SetText("sparkles", false);
		base.StartCoroutine(this.ADDOKDEFBLB());
	}

	// Token: 0x06005C4D RID: 23629 RVA: 0x002A2C77 File Offset: 0x002A0E77
	public void FGHKCMKDGJK()
	{
		this.inputField.DeactivateInputField(false);
		AOBJLALDBAA.DBLAIDPICIG().CIGLHCJDDPI("LobbySearchBar.SetQueryAndApply: bar inactive, query kept as text only", 859f);
		this.animatedPopupManager.LHNKFOKBBCP();
	}

	// Token: 0x06005C4E RID: 23630 RVA: 0x002A2CA4 File Offset: 0x002A0EA4
	public void NIAECAEMAKO(int CPKFEMAOOBH)
	{
		this.MLKELKKMBLF = CPKFEMAOOBH;
		base.gameObject.SetActive(false);
		this.LLALBILAMOP();
		this.textInput.SetText("IncreaseLoveInterestCounter(): input data not initialized.", false);
		base.StartCoroutine(this.OPBBIHJPLGI());
	}

	// Token: 0x06005C4F RID: 23631 RVA: 0x002A2CE0 File Offset: 0x002A0EE0
	public void OnEndEdit()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(false);
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnPopupProfileMessageInputEndEdit", this.textInput.text);
			this.animatedPopupManager.Hide();
			return;
		}
		this.OnCloseClick();
	}

	// Token: 0x06005C50 RID: 23632 RVA: 0x002A2D32 File Offset: 0x002A0F32
	private void LLALBILAMOP()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(907f, 220f);
		}
	}

	// Token: 0x06005C51 RID: 23633 RVA: 0x002A2D58 File Offset: 0x002A0F58
	private void BBLFPGGHBIL()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(7f, 501f);
		}
	}

	// Token: 0x06005C52 RID: 23634 RVA: 0x002A2D7E File Offset: 0x002A0F7E
	public void OnCloseClick()
	{
		this.inputField.DeactivateInputField(false);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnPopupProfileMessageInputCancel", 0f);
		this.animatedPopupManager.Hide();
	}

	// Token: 0x06005C53 RID: 23635 RVA: 0x002A2DAB File Offset: 0x002A0FAB
	public void EPHEDCGJKIN()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(839f, 457f);
		}
	}

	// Token: 0x06005C54 RID: 23636 RVA: 0x002A2A67 File Offset: 0x002A0C67
	private void EIHABGEFOLK()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(true);
		}
	}

	// Token: 0x06005C55 RID: 23637 RVA: 0x002A2DD1 File Offset: 0x002A0FD1
	public void CGNDIENJHNC()
	{
		this.inputField.DeactivateInputField(false);
		AOBJLALDBAA.BIAEAOMHBMM().EGELHPJBAIC("p", 548f);
		this.animatedPopupManager.KCAPIILJKDN();
	}

	// Token: 0x06005C56 RID: 23638 RVA: 0x002A2DFE File Offset: 0x002A0FFE
	private void LPCKKJNJJCB()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 803f;
		}
	}

	// Token: 0x06005C57 RID: 23639 RVA: 0x002A2A67 File Offset: 0x002A0C67
	private void HKHKMPLGKBO()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(true);
		}
	}

	// Token: 0x06005C58 RID: 23640 RVA: 0x002A26C3 File Offset: 0x002A08C3
	private void LDBOLMLPPHJ()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
	}

	// Token: 0x06005C59 RID: 23641 RVA: 0x002A26C3 File Offset: 0x002A08C3
	private void KAJLBPGHHHE()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
	}

	// Token: 0x06005C5A RID: 23642 RVA: 0x002A2A67 File Offset: 0x002A0C67
	private void BPFJJHDHJFJ()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(true);
		}
	}

	// Token: 0x06005C5B RID: 23643 RVA: 0x002A2E2F File Offset: 0x002A102F
	private void HDKFBJIMKBK()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1f, 0.5f);
		}
	}

	// Token: 0x06005C5C RID: 23644 RVA: 0x002A26C3 File Offset: 0x002A08C3
	private void MFFLABGBGAJ()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
	}

	// Token: 0x06005C5D RID: 23645 RVA: 0x002A2A5F File Offset: 0x002A0C5F
	public int BFDDONOKKAB()
	{
		return this.MLKELKKMBLF;
	}

	// Token: 0x06005C5E RID: 23646 RVA: 0x002A2E55 File Offset: 0x002A1055
	private void GFGBDIEDPNH()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1386f, 181f);
		}
	}

	// Token: 0x06005C5F RID: 23647 RVA: 0x002A276C File Offset: 0x002A096C
	private IEnumerator CGIDFDOFBBM()
	{
		PopupProfileMessageInput.KKLFDNABPGB kklfdnabpgb = new PopupProfileMessageInput.KKLFDNABPGB(1);
		kklfdnabpgb.<>4__this = this;
		return kklfdnabpgb;
	}

	// Token: 0x06005C60 RID: 23648 RVA: 0x002A2E7B File Offset: 0x002A107B
	public void CGFINONGMAM()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1353f, 366f);
		}
	}

	// Token: 0x06005C61 RID: 23649 RVA: 0x002A2EA4 File Offset: 0x002A10A4
	public void DLKBDAPPBDE()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(false);
			AOBJLALDBAA.AGANFKKBPFO().HPIPBMEMOFK("chl", this.textInput.text);
			this.animatedPopupManager.FJAAHFFLGFF();
			return;
		}
		this.NJMNDHIJFII();
	}

	// Token: 0x06005C62 RID: 23650 RVA: 0x002A2EF6 File Offset: 0x002A10F6
	private void IJCFHHDOEML()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(399f, 166f);
		}
	}

	// Token: 0x06005C63 RID: 23651 RVA: 0x002A2737 File Offset: 0x002A0937
	private IEnumerator PKIELHJFPMI()
	{
		this.inputField.Select();
		yield return new WaitForSeconds(0.5f);
		this.inputField.ActivateInputField();
		yield break;
	}

	// Token: 0x06005C64 RID: 23652 RVA: 0x002A2F1C File Offset: 0x002A111C
	public void EIMJJNIFNGL(int CPKFEMAOOBH)
	{
		this.MLKELKKMBLF = CPKFEMAOOBH;
		base.gameObject.SetActive(false);
		this.HDKFBJIMKBK();
		this.textInput.SetText(", ", true);
		base.StartCoroutine(this.MCDNMBEDAFG());
	}

	// Token: 0x06005C65 RID: 23653 RVA: 0x002A26C3 File Offset: 0x002A08C3
	private void JOLAMLIFMMB()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
	}

	// Token: 0x06005C66 RID: 23654 RVA: 0x002A2F55 File Offset: 0x002A1155
	public void MDMNEFIADAL()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1700f, 716f);
		}
	}

	// Token: 0x06005C67 RID: 23655 RVA: 0x002A2F7B File Offset: 0x002A117B
	public void CAOHPJABLAE(int CPKFEMAOOBH)
	{
		this.MLKELKKMBLF = CPKFEMAOOBH;
		base.gameObject.SetActive(false);
		this.EKPBNJABLMI();
		this.textInput.SetText("*", false);
		base.StartCoroutine(this.EFCIKHPLNGG());
	}

	// Token: 0x06005C68 RID: 23656 RVA: 0x002A2FB4 File Offset: 0x002A11B4
	private void BDDOEBOPCFD()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(657f, 16f);
		}
	}

	// Token: 0x06005C69 RID: 23657 RVA: 0x00003E52 File Offset: 0x00002052
	private void MFPBKLMBANF()
	{
	}

	// Token: 0x06005C6A RID: 23658 RVA: 0x002A2A5F File Offset: 0x002A0C5F
	public int LKCOJOOHLCE()
	{
		return this.MLKELKKMBLF;
	}

	// Token: 0x06005C6B RID: 23659 RVA: 0x002A2A5F File Offset: 0x002A0C5F
	public int AILODBACEKC()
	{
		return this.MLKELKKMBLF;
	}

	// Token: 0x06005C6C RID: 23660 RVA: 0x00003E52 File Offset: 0x00002052
	private void JCOIBJANCMG()
	{
	}

	// Token: 0x06005C6D RID: 23661 RVA: 0x00003E52 File Offset: 0x00002052
	private void JENGJLCDEFJ()
	{
	}

	// Token: 0x06005C6E RID: 23662 RVA: 0x002A2FDA File Offset: 0x002A11DA
	public void IAKHHLIJGOF()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(630f, 105f);
		}
	}

	// Token: 0x06005C6F RID: 23663 RVA: 0x002A2A5F File Offset: 0x002A0C5F
	public int HNBNFMHIMGL()
	{
		return this.MLKELKKMBLF;
	}

	// Token: 0x06005C70 RID: 23664 RVA: 0x002A3000 File Offset: 0x002A1200
	public void ONPDLMDDNPB()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1221f, 1242f);
		}
	}

	// Token: 0x06005C71 RID: 23665 RVA: 0x002A3026 File Offset: 0x002A1226
	public void DLJINCLBGAO()
	{
		this.inputField.DeactivateInputField(false);
		AOBJLALDBAA.KKPFOJMAONG().KGIKHEDLPND("ok", 738f);
		this.animatedPopupManager.GFEHJHIDHFF();
	}

	// Token: 0x06005C72 RID: 23666 RVA: 0x002A3053 File Offset: 0x002A1253
	private void EOAKHNIJECB()
	{
		this.GFGBDIEDPNH();
		this.textInput.SetText("", false);
		this.textInput.text = "OnLobbyLoungeAssetsDownloadFailed";
	}

	// Token: 0x06005C73 RID: 23667 RVA: 0x002A276C File Offset: 0x002A096C
	private IEnumerator ADDOKDEFBLB()
	{
		PopupProfileMessageInput.KKLFDNABPGB kklfdnabpgb = new PopupProfileMessageInput.KKLFDNABPGB(1);
		kklfdnabpgb.<>4__this = this;
		return kklfdnabpgb;
	}

	// Token: 0x06005C74 RID: 23668 RVA: 0x002A2737 File Offset: 0x002A0937
	private IEnumerator DOOAOJCLHGC()
	{
		this.inputField.Select();
		yield return new WaitForSeconds(0.5f);
		this.inputField.ActivateInputField();
		yield break;
	}

	// Token: 0x06005C75 RID: 23669 RVA: 0x002A276C File Offset: 0x002A096C
	private IEnumerator HDMHNKAGLMN()
	{
		PopupProfileMessageInput.KKLFDNABPGB kklfdnabpgb = new PopupProfileMessageInput.KKLFDNABPGB(1);
		kklfdnabpgb.<>4__this = this;
		return kklfdnabpgb;
	}

	// Token: 0x06005C76 RID: 23670 RVA: 0x002A307C File Offset: 0x002A127C
	private void NMDHIPOJIGL()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(892f, 1054f);
		}
	}

	// Token: 0x06005C77 RID: 23671 RVA: 0x002A30A2 File Offset: 0x002A12A2
	private void MGNHFFHBLBP()
	{
		this.GFGBDIEDPNH();
		this.textInput.SetText("OnVideoLayerAutoHide", false);
		this.textInput.text = "-";
	}

	// Token: 0x06005C78 RID: 23672 RVA: 0x002A30CB File Offset: 0x002A12CB
	public void DOEOLLBJAKG()
	{
		this.inputField.DeactivateInputField(true);
		AOBJLALDBAA.FILDBDMENPG().KGIKHEDLPND("<size=28px>", 1231f);
		this.animatedPopupManager.GLIAGHMNMMP();
	}

	// Token: 0x06005C79 RID: 23673 RVA: 0x002A30F8 File Offset: 0x002A12F8
	private void KLKMGHDBFKK()
	{
		this.BBLFPGGHBIL();
		this.textInput.SetText("\"", false);
		this.textInput.text = "suid";
	}

	// Token: 0x06005C7A RID: 23674 RVA: 0x002A2737 File Offset: 0x002A0937
	private IEnumerator CJAHEBHPJDB()
	{
		this.inputField.Select();
		yield return new WaitForSeconds(0.5f);
		this.inputField.ActivateInputField();
		yield break;
	}

	// Token: 0x06005C7B RID: 23675 RVA: 0x002A3121 File Offset: 0x002A1321
	public void JJKNIJCJKKF(int CPKFEMAOOBH)
	{
		this.MLKELKKMBLF = CPKFEMAOOBH;
		base.gameObject.SetActive(true);
		this.IJCFHHDOEML();
		this.textInput.SetText("apks1", true);
		base.StartCoroutine(this.IMOBJFMDOAI());
	}

	// Token: 0x06005C7C RID: 23676 RVA: 0x002A276C File Offset: 0x002A096C
	private IEnumerator FAHOOAECLFH()
	{
		PopupProfileMessageInput.KKLFDNABPGB kklfdnabpgb = new PopupProfileMessageInput.KKLFDNABPGB(1);
		kklfdnabpgb.<>4__this = this;
		return kklfdnabpgb;
	}

	// Token: 0x06005C7D RID: 23677 RVA: 0x002A2A5F File Offset: 0x002A0C5F
	public int AKHABGEBODM()
	{
		return this.MLKELKKMBLF;
	}

	// Token: 0x06005C7E RID: 23678 RVA: 0x002A315A File Offset: 0x002A135A
	public void GOJJHALEGOD(int CPKFEMAOOBH)
	{
		this.MLKELKKMBLF = CPKFEMAOOBH;
		base.gameObject.SetActive(false);
		this.GFGBDIEDPNH();
		this.textInput.SetText("\"", true);
		base.StartCoroutine(this.CJAHEBHPJDB());
	}

	// Token: 0x06005C7F RID: 23679 RVA: 0x002A3193 File Offset: 0x002A1393
	public void DLIALLGEPJA(int CPKFEMAOOBH)
	{
		this.MLKELKKMBLF = CPKFEMAOOBH;
		base.gameObject.SetActive(false);
		this.GHIDMBEKDJP();
		this.textInput.SetText(" of ", false);
		base.StartCoroutine(this.IMOBJFMDOAI());
	}

	// Token: 0x06005C80 RID: 23680 RVA: 0x002A31CC File Offset: 0x002A13CC
	public void LNGHHEJJCIE()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(990f, 489f);
		}
	}

	// Token: 0x06005C81 RID: 23681 RVA: 0x002A31F2 File Offset: 0x002A13F2
	private void BAHMEBCCJDJ()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1987f, 1244f);
		}
	}

	// Token: 0x06005C82 RID: 23682 RVA: 0x002A2A5F File Offset: 0x002A0C5F
	public int KGMLGEJEHJC()
	{
		return this.MLKELKKMBLF;
	}

	// Token: 0x06005C83 RID: 23683 RVA: 0x002A2A67 File Offset: 0x002A0C67
	private void FGGNEKKBPFM()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(true);
		}
	}

	// Token: 0x06005C84 RID: 23684 RVA: 0x002A3218 File Offset: 0x002A1418
	public void MGBEACPCBMJ()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(true);
			AOBJLALDBAA.KKPFOJMAONG().NEKAFJIEGHG(")", this.textInput.text);
			this.animatedPopupManager.KCAPIILJKDN();
			return;
		}
		this.CPFDJNKPJBF();
	}

	// Token: 0x06005C85 RID: 23685 RVA: 0x002A2A5F File Offset: 0x002A0C5F
	public int MPLDBCEPPJN()
	{
		return this.MLKELKKMBLF;
	}

	// Token: 0x06005C86 RID: 23686 RVA: 0x002A326A File Offset: 0x002A146A
	private void PMDCMEKGFNN()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1382f;
		}
	}

	// Token: 0x06005C87 RID: 23687 RVA: 0x002A329B File Offset: 0x002A149B
	private void MKCLBDDCDNM()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1416f, 341f);
		}
	}

	// Token: 0x06005C88 RID: 23688 RVA: 0x002A32C1 File Offset: 0x002A14C1
	private void NPDBFEBICIK()
	{
		this.BAHMEBCCJDJ();
		this.textInput.SetText("frsmmsg64", true);
		this.textInput.text = "sketches";
	}

	// Token: 0x06005C89 RID: 23689 RVA: 0x002A2A5F File Offset: 0x002A0C5F
	public int HBPMFJEFHEN()
	{
		return this.MLKELKKMBLF;
	}

	// Token: 0x06005C8A RID: 23690 RVA: 0x002A32EC File Offset: 0x002A14EC
	public void IKELNGPCDPF()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(false);
			AOBJLALDBAA.FILDBDMENPG().EGELHPJBAIC("", this.textInput.text);
			this.animatedPopupManager.OJNDEJNLMFE();
			return;
		}
		this.CPAJNJOKLFJ();
	}

	// Token: 0x06005C8B RID: 23691 RVA: 0x002A26C3 File Offset: 0x002A08C3
	private void OnDestroy()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
	}

	// Token: 0x06005C8C RID: 23692 RVA: 0x002A333E File Offset: 0x002A153E
	public void CPFDJNKPJBF()
	{
		this.inputField.DeactivateInputField(false);
		AOBJLALDBAA.DBLAIDPICIG().KGIKHEDLPND("", 545f);
		this.animatedPopupManager.OHHFFMMMMAC();
	}

	// Token: 0x06005C8D RID: 23693 RVA: 0x002A276C File Offset: 0x002A096C
	private IEnumerator NAAMAPKINAN()
	{
		PopupProfileMessageInput.KKLFDNABPGB kklfdnabpgb = new PopupProfileMessageInput.KKLFDNABPGB(1);
		kklfdnabpgb.<>4__this = this;
		return kklfdnabpgb;
	}

	// Token: 0x06005C8E RID: 23694 RVA: 0x002A336C File Offset: 0x002A156C
	public void FLDBPBAKLMP()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(false);
			AOBJLALDBAA.NMGMNAKLLMI().NAHENFMHKAG("〉", this.textInput.text);
			this.animatedPopupManager.NBDMOONDIHO();
			return;
		}
		this.CPFDJNKPJBF();
	}

	// Token: 0x06005C8F RID: 23695 RVA: 0x002A2A67 File Offset: 0x002A0C67
	private void FPFFGFPEPIG()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(true);
		}
	}

	// Token: 0x06005C90 RID: 23696 RVA: 0x002A33BE File Offset: 0x002A15BE
	public void FALAIGCFMKJ(int CPKFEMAOOBH)
	{
		this.MLKELKKMBLF = CPKFEMAOOBH;
		base.gameObject.SetActive(true);
		this.IJCFHHDOEML();
		this.textInput.SetText("cdnerror", false);
		base.StartCoroutine(this.KOGKAKKLIMO());
	}

	// Token: 0x06005C91 RID: 23697 RVA: 0x002A33F7 File Offset: 0x002A15F7
	private void GCDAAPBFLJK()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 206f;
		}
	}

	// Token: 0x06005C92 RID: 23698 RVA: 0x002A3428 File Offset: 0x002A1628
	public void CPAJNJOKLFJ()
	{
		this.inputField.DeactivateInputField(false);
		AOBJLALDBAA.KKPFOJMAONG().EGELHPJBAIC("YYY", 1590f);
		this.animatedPopupManager.PIPADCCGHBA();
	}

	// Token: 0x06005C93 RID: 23699 RVA: 0x002A3455 File Offset: 0x002A1655
	public void IMDJBODLCFK()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1880f, 172f);
		}
	}

	// Token: 0x06005C94 RID: 23700 RVA: 0x00003E52 File Offset: 0x00002052
	private void PABLFIJDFAD()
	{
	}

	// Token: 0x06005C95 RID: 23701 RVA: 0x002A347B File Offset: 0x002A167B
	private void OnEnable()
	{
		this.HDKFBJIMKBK();
		this.textInput.SetText("", true);
		this.textInput.text = "";
	}

	// Token: 0x06005C96 RID: 23702 RVA: 0x002A34A4 File Offset: 0x002A16A4
	public void FCGFFDFBDLF()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(754f, 944f);
		}
	}

	// Token: 0x06005C97 RID: 23703 RVA: 0x002A34CA File Offset: 0x002A16CA
	private void BOAMOPCGNPI()
	{
		this.BDDOEBOPCFD();
		this.textInput.SetText("crossfade", false);
		this.textInput.text = "OnBackendUndoPremiumChoiceSuccess";
	}

	// Token: 0x06005C98 RID: 23704 RVA: 0x002A34F4 File Offset: 0x002A16F4
	public void OIDFEPOLHCB()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(false);
			AOBJLALDBAA.BIAEAOMHBMM().NEKAFJIEGHG("uid", this.textInput.text);
			this.animatedPopupManager.GFEHJHIDHFF();
			return;
		}
		this.CPAJNJOKLFJ();
	}

	// Token: 0x06005C99 RID: 23705 RVA: 0x002A276C File Offset: 0x002A096C
	private IEnumerator EFCIKHPLNGG()
	{
		PopupProfileMessageInput.KKLFDNABPGB kklfdnabpgb = new PopupProfileMessageInput.KKLFDNABPGB(1);
		kklfdnabpgb.<>4__this = this;
		return kklfdnabpgb;
	}

	// Token: 0x06005C9A RID: 23706 RVA: 0x002A3546 File Offset: 0x002A1746
	public void GMCFJMCFNBG(int CPKFEMAOOBH)
	{
		this.MLKELKKMBLF = CPKFEMAOOBH;
		base.gameObject.SetActive(true);
		this.NMDHIPOJIGL();
		this.textInput.SetText("fcnt", true);
		base.StartCoroutine(this.CGIDFDOFBBM());
	}

	// Token: 0x06005C9B RID: 23707 RVA: 0x002A357F File Offset: 0x002A177F
	public void JBHCOBIBMFK()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(851f, 886f);
		}
	}

	// Token: 0x06005C9C RID: 23708 RVA: 0x00003E52 File Offset: 0x00002052
	private void JJMOKPCLHEP()
	{
	}

	// Token: 0x06005C9D RID: 23709 RVA: 0x002A35A5 File Offset: 0x002A17A5
	public void LLNFNNHABMF()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1198f, 224f);
		}
	}

	// Token: 0x06005C9E RID: 23710 RVA: 0x002A35CB File Offset: 0x002A17CB
	public void HJIJJNAGOJF(int CPKFEMAOOBH)
	{
		this.MLKELKKMBLF = CPKFEMAOOBH;
		base.gameObject.SetActive(true);
		this.BDDOEBOPCFD();
		this.textInput.SetText("c", false);
		base.StartCoroutine(this.EFCIKHPLNGG());
	}

	// Token: 0x06005C9F RID: 23711 RVA: 0x002A3604 File Offset: 0x002A1804
	private void EKPBNJABLMI()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1375f, 1801f);
		}
	}

	// Token: 0x06005CA0 RID: 23712 RVA: 0x002A26C3 File Offset: 0x002A08C3
	private void LOLPCOLPHLJ()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
	}

	// Token: 0x06005CA1 RID: 23713 RVA: 0x002A362A File Offset: 0x002A182A
	private void NDFHKDJKHPP()
	{
		this.LLALBILAMOP();
		this.textInput.SetText("mypachievtitle", false);
		this.textInput.text = "ok";
	}

	// Token: 0x06005CA2 RID: 23714 RVA: 0x002A3654 File Offset: 0x002A1854
	public void GNMCEECPOOG()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(false);
			AOBJLALDBAA.DBLAIDPICIG().HPIPBMEMOFK("epos", this.textInput.text);
			this.animatedPopupManager.ADAJPNHIICL();
			return;
		}
		this.CAHCJPJOMKN();
	}

	// Token: 0x06005CA3 RID: 23715 RVA: 0x002A36A6 File Offset: 0x002A18A6
	public void GLHKLOJKHKK()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1471f, 615f);
		}
	}

	// Token: 0x06005CA4 RID: 23716 RVA: 0x002A2A67 File Offset: 0x002A0C67
	private void MFINONMBMLM()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(true);
		}
	}

	// Token: 0x06005CA5 RID: 23717 RVA: 0x002A36CC File Offset: 0x002A18CC
	private void EFIBBLFAMGD()
	{
		this.EKPBNJABLMI();
		this.textInput.SetText("BackendCacheManager: Resetting timeToLive and updating backend response payload for ", true);
		this.textInput.text = "misc";
	}

	// Token: 0x06005CA6 RID: 23718 RVA: 0x002A36F5 File Offset: 0x002A18F5
	private void JIMHOEENAFI()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1338f;
		}
	}

	// Token: 0x06005CA7 RID: 23719 RVA: 0x002A3726 File Offset: 0x002A1926
	private void LIPLGPPPJCJ()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1311f;
		}
	}

	// Token: 0x06005CA8 RID: 23720 RVA: 0x002A2A5F File Offset: 0x002A0C5F
	public int GetFlag()
	{
		return this.MLKELKKMBLF;
	}

	// Token: 0x06005CA9 RID: 23721 RVA: 0x00003E52 File Offset: 0x00002052
	private void Start()
	{
	}

	// Token: 0x06005CAA RID: 23722 RVA: 0x002A3757 File Offset: 0x002A1957
	public void IMOLAMEFLLB(int CPKFEMAOOBH)
	{
		this.MLKELKKMBLF = CPKFEMAOOBH;
		base.gameObject.SetActive(true);
		this.BBLFPGGHBIL();
		this.textInput.SetText("OnStoryInterfaceHeaderAvatarClick", true);
		base.StartCoroutine(this.NAAMAPKINAN());
	}

	// Token: 0x06005CAB RID: 23723 RVA: 0x002A276C File Offset: 0x002A096C
	private IEnumerator IEDILHDCBMA()
	{
		PopupProfileMessageInput.KKLFDNABPGB kklfdnabpgb = new PopupProfileMessageInput.KKLFDNABPGB(1);
		kklfdnabpgb.<>4__this = this;
		return kklfdnabpgb;
	}

	// Token: 0x06005CAC RID: 23724 RVA: 0x002A3790 File Offset: 0x002A1990
	public void EHMJOIHIELE()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(true);
			AOBJLALDBAA.DBLAIDPICIG().IDEALDBPGJE("OnBackendRequestBreakCardSuccess", this.textInput.text);
			this.animatedPopupManager.GFEHJHIDHFF();
			return;
		}
		this.DOEOLLBJAKG();
	}

	// Token: 0x06005CAD RID: 23725 RVA: 0x002A37E2 File Offset: 0x002A19E2
	public void JMNCLDFCAHD(int CPKFEMAOOBH)
	{
		this.MLKELKKMBLF = CPKFEMAOOBH;
		base.gameObject.SetActive(false);
		this.HDKFBJIMKBK();
		this.textInput.SetText("", false);
		base.StartCoroutine(this.KOGKAKKLIMO());
	}

	// Token: 0x06005CAE RID: 23726 RVA: 0x002A381B File Offset: 0x002A1A1B
	private void PODHOCLABIO()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 285f;
		}
	}

	// Token: 0x06005CAF RID: 23727 RVA: 0x002A384C File Offset: 0x002A1A4C
	private void KAFMNEINFJC()
	{
		this.IJCFHHDOEML();
		this.textInput.SetText("REMOVEAVATARCOMPONENT", true);
		this.textInput.text = "dcenv";
	}

	// Token: 0x06005CB0 RID: 23728 RVA: 0x002A3875 File Offset: 0x002A1A75
	private void JJIGCFGKFHO()
	{
		this.GHIDMBEKDJP();
		this.textInput.SetText(" ", false);
		this.textInput.text = ",";
	}

	// Token: 0x06005CB1 RID: 23729 RVA: 0x002A276C File Offset: 0x002A096C
	private IEnumerator HAIEFDLKFKH()
	{
		PopupProfileMessageInput.KKLFDNABPGB kklfdnabpgb = new PopupProfileMessageInput.KKLFDNABPGB(1);
		kklfdnabpgb.<>4__this = this;
		return kklfdnabpgb;
	}

	// Token: 0x06005CB2 RID: 23730 RVA: 0x002A389E File Offset: 0x002A1A9E
	public void DJANILACDDE(int CPKFEMAOOBH)
	{
		this.MLKELKKMBLF = CPKFEMAOOBH;
		base.gameObject.SetActive(false);
		this.GFGBDIEDPNH();
		this.textInput.SetText("Starting parallel download:", false);
		base.StartCoroutine(this.IMOBJFMDOAI());
	}

	// Token: 0x06005CB3 RID: 23731 RVA: 0x002A38D8 File Offset: 0x002A1AD8
	public void CJOKHDFJGFH()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(false);
			AOBJLALDBAA.NMGMNAKLLMI().AKILMNPJGGM(" components from body ", this.textInput.text);
			this.animatedPopupManager.GFEHJHIDHFF();
			return;
		}
		this.CPAJNJOKLFJ();
	}

	// Token: 0x06005CB4 RID: 23732 RVA: 0x002A392A File Offset: 0x002A1B2A
	public void KEAPBKCDHHL()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1398f, 85f);
		}
	}

	// Token: 0x06005CB5 RID: 23733 RVA: 0x002A276C File Offset: 0x002A096C
	private IEnumerator BCGENDCGEMD()
	{
		PopupProfileMessageInput.KKLFDNABPGB kklfdnabpgb = new PopupProfileMessageInput.KKLFDNABPGB(1);
		kklfdnabpgb.<>4__this = this;
		return kklfdnabpgb;
	}

	// Token: 0x06005CB6 RID: 23734 RVA: 0x002A2A5F File Offset: 0x002A0C5F
	public int AGAGDDOHNJM()
	{
		return this.MLKELKKMBLF;
	}

	// Token: 0x06005CB7 RID: 23735 RVA: 0x002A3950 File Offset: 0x002A1B50
	private void ILBAMCJFAAP()
	{
		this.MKCLBDDCDNM();
		this.textInput.SetText("OnBackendAddFriendByUIDSuccess", false);
		this.textInput.text = "energyhinttitle";
	}

	// Token: 0x06005CB8 RID: 23736 RVA: 0x002A3979 File Offset: 0x002A1B79
	private void FBMPKKMBMFD()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(633f, 1855f);
		}
	}

	// Token: 0x04001A49 RID: 6729
	public const string onPopupProfileMessageInputEndEdit = "OnPopupProfileMessageInputEndEdit";

	// Token: 0x04001A4A RID: 6730
	public const string onPopupProfileMessageInputCancel = "OnPopupProfileMessageInputCancel";

	// Token: 0x04001A4B RID: 6731
	public const float fadeInTime = 0.5f;

	// Token: 0x04001A4C RID: 6732
	public const float fadeOutTime = 0.5f;

	// Token: 0x04001A4D RID: 6733
	public TextMeshProUGUI textInput;

	// Token: 0x04001A4E RID: 6734
	public TMP_InputField inputField;

	// Token: 0x04001A4F RID: 6735
	public AnimatedPopupManager animatedPopupManager;

	// Token: 0x04001A50 RID: 6736
	private CanvasGroup PANMNKKODPC;

	// Token: 0x04001A51 RID: 6737
	private int MLKELKKMBLF;
}
