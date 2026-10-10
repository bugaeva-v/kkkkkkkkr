using System;
using System.Collections;
using DG.Tweening;
using TMPro;
using UnityEngine;

// Token: 0x0200027C RID: 636
public class PopupPasswordInput : MonoBehaviour
{
	// Token: 0x06004F56 RID: 20310 RVA: 0x002300D6 File Offset: 0x0022E2D6
	private IEnumerator CJAHEBHPJDB()
	{
		this.inputField.Select();
		yield return new WaitForSeconds(0.5f);
		this.inputField.ActivateInputField();
		yield break;
	}

	// Token: 0x06004F57 RID: 20311 RVA: 0x002300E8 File Offset: 0x0022E2E8
	public void OnEndEdit()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(false);
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnPopupPasswordInputEndEdit", this.textInput.text);
			this.animatedPopupManager.Hide();
			return;
		}
		this.OnCloseClick();
	}

	// Token: 0x06004F58 RID: 20312 RVA: 0x0023013A File Offset: 0x0022E33A
	public void MDEJKKFMEJC()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(66f, 1672f);
		}
	}

	// Token: 0x06004F59 RID: 20313 RVA: 0x00230160 File Offset: 0x0022E360
	public void GMGJGENNGGF()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1838f, 1237f);
		}
	}

	// Token: 0x06004F5A RID: 20314 RVA: 0x00230186 File Offset: 0x0022E386
	private void Awake()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 0f;
		}
	}

	// Token: 0x06004F5B RID: 20315 RVA: 0x002300D6 File Offset: 0x0022E2D6
	private IEnumerator NFEOJFBOLHO()
	{
		this.inputField.Select();
		yield return new WaitForSeconds(0.5f);
		this.inputField.ActivateInputField();
		yield break;
	}

	// Token: 0x06004F5C RID: 20316 RVA: 0x002301B7 File Offset: 0x0022E3B7
	public void Show()
	{
		base.gameObject.SetActive(true);
		this.HDKFBJIMKBK();
		this.textInput.SetText("", true);
		base.StartCoroutine(this.CJAHEBHPJDB());
	}

	// Token: 0x06004F5D RID: 20317 RVA: 0x002301E9 File Offset: 0x0022E3E9
	private void OnDestroy()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
	}

	// Token: 0x06004F5E RID: 20318 RVA: 0x00230206 File Offset: 0x0022E406
	public void NOBOPEABJHA()
	{
		base.gameObject.SetActive(true);
		this.HDKFBJIMKBK();
		this.textInput.SetText("friendsmaxlimitdefault", false);
		base.StartCoroutine(this.IDLIFAEGDEA());
	}

	// Token: 0x06004F5F RID: 20319 RVA: 0x00003E52 File Offset: 0x00002052
	private void EMIOCJMCLHC()
	{
	}

	// Token: 0x06004F60 RID: 20320 RVA: 0x00230238 File Offset: 0x0022E438
	public void NLMMEHKFONK()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(true);
			AOBJLALDBAA.AGANFKKBPFO().IDEALDBPGJE("\n\n", this.textInput.text);
			this.animatedPopupManager.ADAJPNHIICL();
			return;
		}
		this.OnCloseClick();
	}

	// Token: 0x06004F61 RID: 20321 RVA: 0x002300D6 File Offset: 0x0022E2D6
	private IEnumerator IDLIFAEGDEA()
	{
		this.inputField.Select();
		yield return new WaitForSeconds(0.5f);
		this.inputField.ActivateInputField();
		yield break;
	}

	// Token: 0x06004F62 RID: 20322 RVA: 0x0023028A File Offset: 0x0022E48A
	public void OnCloseClick()
	{
		this.inputField.DeactivateInputField(false);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnPopupPasswordInputCancel", 0f);
		this.animatedPopupManager.Hide();
	}

	// Token: 0x06004F63 RID: 20323 RVA: 0x002302B7 File Offset: 0x0022E4B7
	public void IAKHHLIJGOF()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1995f, 972f);
		}
	}

	// Token: 0x06004F64 RID: 20324 RVA: 0x002302DD File Offset: 0x0022E4DD
	private void OnEnable()
	{
		this.HDKFBJIMKBK();
		this.textInput.SetText("", true);
		this.textInput.text = "";
	}

	// Token: 0x06004F65 RID: 20325 RVA: 0x00230306 File Offset: 0x0022E506
	private void FGJEJGKOLON()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1974f, 167f);
		}
	}

	// Token: 0x06004F66 RID: 20326 RVA: 0x00003E52 File Offset: 0x00002052
	private void Start()
	{
	}

	// Token: 0x06004F67 RID: 20327 RVA: 0x0023032C File Offset: 0x0022E52C
	public void OHFBLNAMOCE()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(417f, 1085f);
		}
	}

	// Token: 0x06004F68 RID: 20328 RVA: 0x00230352 File Offset: 0x0022E552
	private void FPFIBFONEFK()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(914f, 1005f);
		}
	}

	// Token: 0x06004F69 RID: 20329 RVA: 0x00230378 File Offset: 0x0022E578
	private void HDKFBJIMKBK()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1f, 0.5f);
		}
	}

	// Token: 0x06004F6A RID: 20330 RVA: 0x0023039E File Offset: 0x0022E59E
	private void KNGLLGJEFGJ()
	{
		this.HDKFBJIMKBK();
		this.textInput.SetText("tmo", true);
		this.textInput.text = "gpsku";
	}

	// Token: 0x06004F6B RID: 20331 RVA: 0x002303C8 File Offset: 0x0022E5C8
	public void LLGLLCMPDGK()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(true);
			AOBJLALDBAA.FILDBDMENPG().NAHENFMHKAG("OnStoryChoiceClick", this.textInput.text);
			this.animatedPopupManager.GLIAGHMNMMP();
			return;
		}
		this.OnCloseClick();
	}

	// Token: 0x06004F6C RID: 20332 RVA: 0x0023041A File Offset: 0x0022E61A
	public void DisappearAnimation()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(0f, 0.5f);
		}
	}

	// Token: 0x06004F6D RID: 20333 RVA: 0x00230440 File Offset: 0x0022E640
	private void LIPLGPPPJCJ()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1333f;
		}
	}

	// Token: 0x0400165B RID: 5723
	public const string onPopupPasswordInputEndEdit = "OnPopupPasswordInputEndEdit";

	// Token: 0x0400165C RID: 5724
	public const string onPopupPasswordInputCancel = "OnPopupPasswordInputCancel";

	// Token: 0x0400165D RID: 5725
	public const float fadeInTime = 0.5f;

	// Token: 0x0400165E RID: 5726
	public const float fadeOutTime = 0.5f;

	// Token: 0x0400165F RID: 5727
	public TextMeshProUGUI textInput;

	// Token: 0x04001660 RID: 5728
	public TMP_InputField inputField;

	// Token: 0x04001661 RID: 5729
	public AnimatedPopupManager animatedPopupManager;

	// Token: 0x04001662 RID: 5730
	private CanvasGroup PANMNKKODPC;
}
