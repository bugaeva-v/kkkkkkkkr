using System;
using System.Collections;
using DG.Tweening;
using TMPro;
using UnityEngine;

// Token: 0x020000C6 RID: 198
public class PopupUsernameInput : MonoBehaviour
{
	// Token: 0x06001CCE RID: 7374 RVA: 0x000CC3F8 File Offset: 0x000CA5F8
	private void OGCMKEEJDGN()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(257f, 493f);
		}
	}

	// Token: 0x06001CCF RID: 7375 RVA: 0x000CC41E File Offset: 0x000CA61E
	private void HDKFBJIMKBK()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1f, 0.5f);
		}
	}

	// Token: 0x06001CD0 RID: 7376 RVA: 0x000CC444 File Offset: 0x000CA644
	private void OnDestroy()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
	}

	// Token: 0x06001CD2 RID: 7378 RVA: 0x000CC461 File Offset: 0x000CA661
	private IEnumerator CJAHEBHPJDB()
	{
		this.inputField.Select();
		yield return new WaitForSeconds(0.5f);
		this.inputField.ActivateInputField();
		yield break;
	}

	// Token: 0x06001CD3 RID: 7379 RVA: 0x000CC470 File Offset: 0x000CA670
	private void LBDIDHDKHGO()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 237f;
		}
	}

	// Token: 0x06001CD4 RID: 7380 RVA: 0x000CC4A4 File Offset: 0x000CA6A4
	public void GKIHNIOMHON()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(false);
			AOBJLALDBAA.FILDBDMENPG().OIMGLKLHNMO("fsharv2", this.textInput.text);
			this.animatedPopupManager.PIPADCCGHBA();
			return;
		}
		this.OnCloseClick();
	}

	// Token: 0x06001CD5 RID: 7381 RVA: 0x000CC444 File Offset: 0x000CA644
	private void CDLEEFPLPLN()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
	}

	// Token: 0x06001CD6 RID: 7382 RVA: 0x000CC444 File Offset: 0x000CA644
	private void CFHFGNOIPEC()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
	}

	// Token: 0x06001CD7 RID: 7383 RVA: 0x00003E52 File Offset: 0x00002052
	private void MFPBKLMBANF()
	{
	}

	// Token: 0x06001CD8 RID: 7384 RVA: 0x00003E52 File Offset: 0x00002052
	private void IOGKPKFCKCN()
	{
	}

	// Token: 0x06001CD9 RID: 7385 RVA: 0x00003E52 File Offset: 0x00002052
	private void Start()
	{
	}

	// Token: 0x06001CDA RID: 7386 RVA: 0x000CC4F6 File Offset: 0x000CA6F6
	private void JJIGCFGKFHO()
	{
		this.OGCMKEEJDGN();
		this.textInput.SetText("", false);
		this.textInput.text = "OnSettingsPopupClose";
	}

	// Token: 0x06001CDB RID: 7387 RVA: 0x000CC51F File Offset: 0x000CA71F
	private void Awake()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 0f;
		}
	}

	// Token: 0x06001CDC RID: 7388 RVA: 0x000CC550 File Offset: 0x000CA750
	public void FNAHNGLLLCP()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1918f, 1760f);
		}
	}

	// Token: 0x06001CDD RID: 7389 RVA: 0x000CC578 File Offset: 0x000CA778
	public void KMFMJKLIOEP()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(true);
			AOBJLALDBAA.FILDBDMENPG().NAHENFMHKAG("SceneLobbyManager.InstantiateLargeItems() - could not find AssetAnthologyPreview2 for anthology with index:", this.textInput.text);
			this.animatedPopupManager.GLIAGHMNMMP();
			return;
		}
		this.OnCloseClick();
	}

	// Token: 0x06001CDE RID: 7390 RVA: 0x000CC5CA File Offset: 0x000CA7CA
	private IEnumerator GOCCKEGOKGN()
	{
		PopupUsernameInput.FCOAINIEGLB fcoainieglb = new PopupUsernameInput.FCOAINIEGLB(1);
		fcoainieglb.<>4__this = this;
		return fcoainieglb;
	}

	// Token: 0x06001CDF RID: 7391 RVA: 0x000CC5CA File Offset: 0x000CA7CA
	private IEnumerator IDLIFAEGDEA()
	{
		PopupUsernameInput.FCOAINIEGLB fcoainieglb = new PopupUsernameInput.FCOAINIEGLB(1);
		fcoainieglb.<>4__this = this;
		return fcoainieglb;
	}

	// Token: 0x06001CE0 RID: 7392 RVA: 0x000CC5D9 File Offset: 0x000CA7D9
	public void OHFBLNAMOCE()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1022f, 1558f);
		}
	}

	// Token: 0x06001CE1 RID: 7393 RVA: 0x000CC5FF File Offset: 0x000CA7FF
	public void Show()
	{
		base.gameObject.SetActive(true);
		this.HDKFBJIMKBK();
		this.textInput.SetText("", true);
		base.StartCoroutine(this.CJAHEBHPJDB());
	}

	// Token: 0x06001CE2 RID: 7394 RVA: 0x000CC631 File Offset: 0x000CA831
	private void OnEnable()
	{
		this.HDKFBJIMKBK();
		this.textInput.SetText("", true);
		this.textInput.text = "";
	}

	// Token: 0x06001CE3 RID: 7395 RVA: 0x000CC65A File Offset: 0x000CA85A
	private void LDDEIAOCBGB()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 144f;
		}
	}

	// Token: 0x06001CE4 RID: 7396 RVA: 0x000CC68B File Offset: 0x000CA88B
	public void OnCloseClick()
	{
		this.inputField.DeactivateInputField(false);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnPopupUsernameInputCancel", 0f);
		this.animatedPopupManager.Hide();
	}

	// Token: 0x06001CE5 RID: 7397 RVA: 0x000CC6B8 File Offset: 0x000CA8B8
	private void CJOOOIECMAE()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 871f;
		}
	}

	// Token: 0x06001CE6 RID: 7398 RVA: 0x000CC6EC File Offset: 0x000CA8EC
	public void NAFBEPPCAGK()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(true);
			AOBJLALDBAA.CEGAOMEEFBE().FIJKIAKDCNO("_notif", this.textInput.text);
			this.animatedPopupManager.OJNDEJNLMFE();
			return;
		}
		this.OnCloseClick();
	}

	// Token: 0x06001CE7 RID: 7399 RVA: 0x000CC73E File Offset: 0x000CA93E
	public void MBKCINPJKML()
	{
		base.gameObject.SetActive(true);
		this.OGCMKEEJDGN();
		this.textInput.SetText("'", false);
		base.StartCoroutine(this.CJAHEBHPJDB());
	}

	// Token: 0x06001CE8 RID: 7400 RVA: 0x000CC770 File Offset: 0x000CA970
	public void DisappearAnimation()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(0f, 0.5f);
		}
	}

	// Token: 0x06001CE9 RID: 7401 RVA: 0x000CC798 File Offset: 0x000CA998
	public void OnEndEdit()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(false);
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnPopupUsernameInputEndEdit", this.textInput.text);
			this.animatedPopupManager.Hide();
			return;
		}
		this.OnCloseClick();
	}

	// Token: 0x06001CEA RID: 7402 RVA: 0x000CC7EA File Offset: 0x000CA9EA
	public void LNGANLKDOPB()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(595f, 47f);
		}
	}

	// Token: 0x06001CEB RID: 7403 RVA: 0x000CC810 File Offset: 0x000CAA10
	private void IFBCKJLCCAK()
	{
		this.OGCMKEEJDGN();
		this.textInput.SetText("%", true);
		this.textInput.text = "OnSketchViewAssetBundleFolderInitializeSuccess";
	}

	// Token: 0x0400086A RID: 2154
	public const string onPopupUsernameInputEndEdit = "OnPopupUsernameInputEndEdit";

	// Token: 0x0400086B RID: 2155
	public const string onPopupUsernameInputCancel = "OnPopupUsernameInputCancel";

	// Token: 0x0400086C RID: 2156
	public const float fadeInTime = 0.5f;

	// Token: 0x0400086D RID: 2157
	public const float fadeOutTime = 0.5f;

	// Token: 0x0400086E RID: 2158
	public TextMeshProUGUI textInput;

	// Token: 0x0400086F RID: 2159
	public TMP_InputField inputField;

	// Token: 0x04000870 RID: 2160
	public AnimatedPopupManager animatedPopupManager;

	// Token: 0x04000871 RID: 2161
	private CanvasGroup PANMNKKODPC;
}
