using System;
using System.Collections;
using DG.Tweening;
using TMPro;
using UnityEngine;

// Token: 0x0200025C RID: 604
public class PopupSketchesInput : MonoBehaviour
{
	// Token: 0x06004A56 RID: 19030 RVA: 0x00214713 File Offset: 0x00212913
	private void IJPIIOECDGL()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
	}

	// Token: 0x06004A58 RID: 19032 RVA: 0x00214730 File Offset: 0x00212930
	public void OnCloseClick()
	{
		this.inputField.DeactivateInputField(false);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnPopupSketchesInputCancel", 0f);
		this.animatedPopupManager.Hide();
	}

	// Token: 0x06004A59 RID: 19033 RVA: 0x00003E52 File Offset: 0x00002052
	private void Start()
	{
	}

	// Token: 0x06004A5A RID: 19034 RVA: 0x0021475D File Offset: 0x0021295D
	public void CPAJNJOKLFJ()
	{
		this.inputField.DeactivateInputField(true);
		AOBJLALDBAA.BIAEAOMHBMM().KGIKHEDLPND("OnBackendGetDropChancesException2", 468f);
		this.animatedPopupManager.LHNKFOKBBCP();
	}

	// Token: 0x06004A5B RID: 19035 RVA: 0x0021478A File Offset: 0x0021298A
	private IEnumerator GOCCKEGOKGN()
	{
		PopupSketchesInput.KKLFDNABPGB kklfdnabpgb = new PopupSketchesInput.KKLFDNABPGB(1);
		kklfdnabpgb.<>4__this = this;
		return kklfdnabpgb;
	}

	// Token: 0x06004A5C RID: 19036 RVA: 0x00214799 File Offset: 0x00212999
	private void APLBAENGMJH()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 892f;
		}
	}

	// Token: 0x06004A5D RID: 19037 RVA: 0x002147CC File Offset: 0x002129CC
	public void LLGLLCMPDGK()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(true);
			AOBJLALDBAA.FILDBDMENPG().BDEMEIKEJHF("layervideo", this.textInput.text);
			this.animatedPopupManager.OJNDEJNLMFE();
			return;
		}
		this.OnCloseClick();
	}

	// Token: 0x06004A5E RID: 19038 RVA: 0x0021481E File Offset: 0x00212A1E
	public void ICBMLPDONAD()
	{
		base.gameObject.SetActive(true);
		this.FPFIBFONEFK();
		this.textInput.SetText("noiseanalogovr_1", true);
		base.StartCoroutine(this.NABNDKLHMCE());
	}

	// Token: 0x06004A5F RID: 19039 RVA: 0x00214850 File Offset: 0x00212A50
	public void BJJPDCOPGOG()
	{
		this.inputField.DeactivateInputField(true);
		AOBJLALDBAA.CEGAOMEEFBE().EFBNBFIDEOK("AssetProfileData.GetThemeSprite(): anthologyIndex (", 1611f);
		this.animatedPopupManager.LHNKFOKBBCP();
	}

	// Token: 0x06004A60 RID: 19040 RVA: 0x0021478A File Offset: 0x0021298A
	private IEnumerator NABNDKLHMCE()
	{
		PopupSketchesInput.KKLFDNABPGB kklfdnabpgb = new PopupSketchesInput.KKLFDNABPGB(1);
		kklfdnabpgb.<>4__this = this;
		return kklfdnabpgb;
	}

	// Token: 0x06004A61 RID: 19041 RVA: 0x0021487D File Offset: 0x00212A7D
	private void DJDLHIOMGJB()
	{
		this.PLFNBKMMIGJ();
		this.textInput.SetText("ratePopupResult", true);
		this.textInput.text = "Speed";
	}

	// Token: 0x06004A62 RID: 19042 RVA: 0x002148A6 File Offset: 0x00212AA6
	public void DAAHILOMCGL()
	{
		base.gameObject.SetActive(false);
		this.FPFIBFONEFK();
		this.textInput.SetText("max", true);
		base.StartCoroutine(this.GOCCKEGOKGN());
	}

	// Token: 0x06004A63 RID: 19043 RVA: 0x002148D8 File Offset: 0x00212AD8
	public void Show()
	{
		base.gameObject.SetActive(true);
		this.HDKFBJIMKBK();
		this.textInput.SetText("", true);
		base.StartCoroutine(this.CJAHEBHPJDB());
	}

	// Token: 0x06004A64 RID: 19044 RVA: 0x00003E52 File Offset: 0x00002052
	private void PIBDCOBGMKC()
	{
	}

	// Token: 0x06004A65 RID: 19045 RVA: 0x0021490A File Offset: 0x00212B0A
	public void MKOGEEDJDOL()
	{
		base.gameObject.SetActive(true);
		this.FPFIBFONEFK();
		this.textInput.SetText("", true);
		base.StartCoroutine(this.NABNDKLHMCE());
	}

	// Token: 0x06004A66 RID: 19046 RVA: 0x0021493C File Offset: 0x00212B3C
	private void FPFIBFONEFK()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1675f, 515f);
		}
	}

	// Token: 0x06004A67 RID: 19047 RVA: 0x00214713 File Offset: 0x00212913
	private void OnDestroy()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
	}

	// Token: 0x06004A68 RID: 19048 RVA: 0x00214962 File Offset: 0x00212B62
	private void OnEnable()
	{
		this.HDKFBJIMKBK();
		this.textInput.SetText("", true);
		this.textInput.text = "";
	}

	// Token: 0x06004A69 RID: 19049 RVA: 0x0021498B File Offset: 0x00212B8B
	private void PLFNBKMMIGJ()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(652f, 558f);
		}
	}

	// Token: 0x06004A6A RID: 19050 RVA: 0x002149B1 File Offset: 0x00212BB1
	private IEnumerator CJAHEBHPJDB()
	{
		this.inputField.Select();
		yield return new WaitForSeconds(0.5f);
		this.inputField.ActivateInputField();
		yield break;
	}

	// Token: 0x06004A6B RID: 19051 RVA: 0x0021478A File Offset: 0x0021298A
	private IEnumerator FBDCLJMDOCA()
	{
		PopupSketchesInput.KKLFDNABPGB kklfdnabpgb = new PopupSketchesInput.KKLFDNABPGB(1);
		kklfdnabpgb.<>4__this = this;
		return kklfdnabpgb;
	}

	// Token: 0x06004A6C RID: 19052 RVA: 0x002149C0 File Offset: 0x00212BC0
	private void HKFKOMMEMCN()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(true);
		}
	}

	// Token: 0x06004A6D RID: 19053 RVA: 0x002149E0 File Offset: 0x00212BE0
	public void OnEndEdit()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(false);
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnPopupSketchesInputEndEdit", this.textInput.text);
			this.animatedPopupManager.Hide();
			return;
		}
		this.OnCloseClick();
	}

	// Token: 0x06004A6E RID: 19054 RVA: 0x00214A32 File Offset: 0x00212C32
	public void AIEDJEMEAKC()
	{
		base.gameObject.SetActive(false);
		this.HDKFBJIMKBK();
		this.textInput.SetText("chass", true);
		base.StartCoroutine(this.NABNDKLHMCE());
	}

	// Token: 0x06004A6F RID: 19055 RVA: 0x0021478A File Offset: 0x0021298A
	private IEnumerator IPDBKMJGAPH()
	{
		PopupSketchesInput.KKLFDNABPGB kklfdnabpgb = new PopupSketchesInput.KKLFDNABPGB(1);
		kklfdnabpgb.<>4__this = this;
		return kklfdnabpgb;
	}

	// Token: 0x06004A70 RID: 19056 RVA: 0x00214A64 File Offset: 0x00212C64
	private void Awake()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 0f;
		}
	}

	// Token: 0x06004A71 RID: 19057 RVA: 0x00214A95 File Offset: 0x00212C95
	public void DisappearAnimation()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(0f, 0.5f);
		}
	}

	// Token: 0x06004A72 RID: 19058 RVA: 0x00214ABB File Offset: 0x00212CBB
	private void HDKFBJIMKBK()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1f, 0.5f);
		}
	}

	// Token: 0x06004A73 RID: 19059 RVA: 0x00003E52 File Offset: 0x00002052
	private void NCLALOLOIGP()
	{
	}

	// Token: 0x0400154C RID: 5452
	public static int extraData = -1;

	// Token: 0x0400154D RID: 5453
	public const string onPopupSketchesInputEndEdit = "OnPopupSketchesInputEndEdit";

	// Token: 0x0400154E RID: 5454
	public const string onPopupSketchesInputCancel = "OnPopupSketchesInputCancel";

	// Token: 0x0400154F RID: 5455
	public const float fadeInTime = 0.5f;

	// Token: 0x04001550 RID: 5456
	public const float fadeOutTime = 0.5f;

	// Token: 0x04001551 RID: 5457
	public TextMeshProUGUI textInput;

	// Token: 0x04001552 RID: 5458
	public TMP_InputField inputField;

	// Token: 0x04001553 RID: 5459
	public AnimatedPopupManager animatedPopupManager;

	// Token: 0x04001554 RID: 5460
	private CanvasGroup PANMNKKODPC;
}
