using System;
using System.Collections;
using DG.Tweening;
using TMPro;
using UnityEngine;

// Token: 0x02000257 RID: 599
public class PopupProfileCredoInput : MonoBehaviour
{
	// Token: 0x06004970 RID: 18800 RVA: 0x002121E1 File Offset: 0x002103E1
	public void IAKHHLIJGOF()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1290f, 1521f);
		}
	}

	// Token: 0x06004971 RID: 18801 RVA: 0x00212207 File Offset: 0x00210407
	public void GLFNFLLAJLN()
	{
		this.inputField.DeactivateInputField(false);
		AOBJLALDBAA.AGANFKKBPFO().EFBNBFIDEOK("<size=28px>", 1623f);
		this.animatedPopupManager.PIPADCCGHBA();
	}

	// Token: 0x06004972 RID: 18802 RVA: 0x00212234 File Offset: 0x00210434
	private void GPGCCIIOKON()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1661f, 909f);
		}
	}

	// Token: 0x06004973 RID: 18803 RVA: 0x0021225A File Offset: 0x0021045A
	private void OnDestroy()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
	}

	// Token: 0x06004974 RID: 18804 RVA: 0x00212277 File Offset: 0x00210477
	private void BHHNFCEKGCP()
	{
		this.ACHOIKBDFBP();
		this.textInput.SetText(" not found.", false);
		this.textInput.text = ".";
	}

	// Token: 0x06004975 RID: 18805 RVA: 0x002122A0 File Offset: 0x002104A0
	public void BJJPDCOPGOG()
	{
		this.inputField.DeactivateInputField(false);
		AOBJLALDBAA.EHBBFMCILPC.EFBNBFIDEOK("lobby", 1946f);
		this.animatedPopupManager.OHHFFMMMMAC();
	}

	// Token: 0x06004976 RID: 18806 RVA: 0x002122CD File Offset: 0x002104CD
	private void HDKFBJIMKBK()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1f, 0.5f);
		}
	}

	// Token: 0x06004977 RID: 18807 RVA: 0x002122F3 File Offset: 0x002104F3
	private void Awake()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 0f;
		}
	}

	// Token: 0x06004978 RID: 18808 RVA: 0x00212324 File Offset: 0x00210524
	public void HEILCIEEIPG()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(true);
			AOBJLALDBAA.BIAEAOMHBMM().OIMGLKLHNMO("OnAccountSignInRequestException", this.textInput.text);
			this.animatedPopupManager.FJAAHFFLGFF();
			return;
		}
		this.BJJPDCOPGOG();
	}

	// Token: 0x06004979 RID: 18809 RVA: 0x00212376 File Offset: 0x00210576
	public void GMCFJMCFNBG()
	{
		base.gameObject.SetActive(false);
		this.HDKFBJIMKBK();
		this.textInput.SetText("PurchaseManagerUnity.Initialize(): Unity Gaming Services not initialized.", false);
		base.StartCoroutine(this.EFCIKHPLNGG());
	}

	// Token: 0x0600497A RID: 18810 RVA: 0x002123A8 File Offset: 0x002105A8
	private IEnumerator IPHPBOPNANC()
	{
		PopupProfileCredoInput.FCOAINIEGLB fcoainieglb = new PopupProfileCredoInput.FCOAINIEGLB(1);
		fcoainieglb.<>4__this = this;
		return fcoainieglb;
	}

	// Token: 0x0600497B RID: 18811 RVA: 0x002123B7 File Offset: 0x002105B7
	public void GKJHLGICBKI()
	{
		this.inputField.DeactivateInputField(false);
		AOBJLALDBAA.FILDBDMENPG().DCGCFPHHDDG("continue", 405f);
		this.animatedPopupManager.Hide();
	}

	// Token: 0x0600497D RID: 18813 RVA: 0x002123E4 File Offset: 0x002105E4
	public void OnCloseClick()
	{
		this.inputField.DeactivateInputField(false);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnPopupProfileCredoInputCancel", 0f);
		this.animatedPopupManager.Hide();
	}

	// Token: 0x0600497E RID: 18814 RVA: 0x00212411 File Offset: 0x00210611
	private void JLCJJONEBIB()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(true);
		}
	}

	// Token: 0x0600497F RID: 18815 RVA: 0x00003E52 File Offset: 0x00002052
	private void CPDNJAKBOBC()
	{
	}

	// Token: 0x06004980 RID: 18816 RVA: 0x0021242E File Offset: 0x0021062E
	public void CIIJDOELKBJ()
	{
		base.gameObject.SetActive(false);
		this.HDKFBJIMKBK();
		this.textInput.SetText("", true);
		base.StartCoroutine(this.CJAHEBHPJDB());
	}

	// Token: 0x06004981 RID: 18817 RVA: 0x00212460 File Offset: 0x00210660
	public void HGNNOJIBLIN()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(false);
			AOBJLALDBAA.NMGMNAKLLMI().BDEMEIKEJHF("frsendhres2", this.textInput.text);
			this.animatedPopupManager.NBDMOONDIHO();
			return;
		}
		this.OnCloseClick();
	}

	// Token: 0x06004982 RID: 18818 RVA: 0x00003E52 File Offset: 0x00002052
	private void JEFCHJAKBFI()
	{
	}

	// Token: 0x06004983 RID: 18819 RVA: 0x002124B2 File Offset: 0x002106B2
	public void NAKODHJDKEL()
	{
		this.inputField.DeactivateInputField(true);
		AOBJLALDBAA.KKPFOJMAONG().EGELHPJBAIC("OnStoryScreenChoiceExtendedManagerLayerChangeComplete", 1337f);
		this.animatedPopupManager.NBDMOONDIHO();
	}

	// Token: 0x06004984 RID: 18820 RVA: 0x002124DF File Offset: 0x002106DF
	private void OnEnable()
	{
		this.HDKFBJIMKBK();
		this.textInput.SetText("", true);
		this.textInput.text = "";
	}

	// Token: 0x06004985 RID: 18821 RVA: 0x00212508 File Offset: 0x00210708
	public void HAMOIGHDKDL()
	{
		this.inputField.DeactivateInputField(true);
		AOBJLALDBAA.KKPFOJMAONG().KMAGHMCCMPG("instd", 425f);
		this.animatedPopupManager.GLIAGHMNMMP();
	}

	// Token: 0x06004986 RID: 18822 RVA: 0x00212538 File Offset: 0x00210738
	public void OnEndEdit()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(false);
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnPopupProfileCredoInputEndEdit", this.textInput.text);
			this.animatedPopupManager.Hide();
			return;
		}
		this.OnCloseClick();
	}

	// Token: 0x06004987 RID: 18823 RVA: 0x002123A8 File Offset: 0x002105A8
	private IEnumerator EFCIKHPLNGG()
	{
		PopupProfileCredoInput.FCOAINIEGLB fcoainieglb = new PopupProfileCredoInput.FCOAINIEGLB(1);
		fcoainieglb.<>4__this = this;
		return fcoainieglb;
	}

	// Token: 0x06004988 RID: 18824 RVA: 0x00003E52 File Offset: 0x00002052
	private void Start()
	{
	}

	// Token: 0x06004989 RID: 18825 RVA: 0x00003E52 File Offset: 0x00002052
	private void HPDHFIHPKGP()
	{
	}

	// Token: 0x0600498A RID: 18826 RVA: 0x0021225A File Offset: 0x0021045A
	private void INJJOHNFBKH()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
	}

	// Token: 0x0600498B RID: 18827 RVA: 0x0021225A File Offset: 0x0021045A
	private void CODLJCAKBLI()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
	}

	// Token: 0x0600498C RID: 18828 RVA: 0x00003E52 File Offset: 0x00002052
	private void ODOOIGEDLKB()
	{
	}

	// Token: 0x0600498D RID: 18829 RVA: 0x0021258A File Offset: 0x0021078A
	private void LGOJJBHPIBG()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(60f, 307f);
		}
	}

	// Token: 0x0600498E RID: 18830 RVA: 0x002125B0 File Offset: 0x002107B0
	public void NDDOLHPKCDO()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(false);
			AOBJLALDBAA.NMGMNAKLLMI().NAHENFMHKAG("F2", this.textInput.text);
			this.animatedPopupManager.DDPHFKOHDJB();
			return;
		}
		this.NAKODHJDKEL();
	}

	// Token: 0x0600498F RID: 18831 RVA: 0x00212411 File Offset: 0x00210611
	private void MFINONMBMLM()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(true);
		}
	}

	// Token: 0x06004990 RID: 18832 RVA: 0x00212602 File Offset: 0x00210802
	public void Show()
	{
		base.gameObject.SetActive(true);
		this.HDKFBJIMKBK();
		this.textInput.SetText("", true);
		base.StartCoroutine(this.CJAHEBHPJDB());
	}

	// Token: 0x06004991 RID: 18833 RVA: 0x00212634 File Offset: 0x00210834
	public void MOLFJIOCFIC()
	{
		base.gameObject.SetActive(true);
		this.GPGCCIIOKON();
		this.textInput.SetText("c", true);
		base.StartCoroutine(this.FFKCEJPBEEG());
	}

	// Token: 0x06004992 RID: 18834 RVA: 0x00212666 File Offset: 0x00210866
	private void IBMHJOGCNHO()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1241f, 1509f);
		}
	}

	// Token: 0x06004993 RID: 18835 RVA: 0x0021268C File Offset: 0x0021088C
	public void ICBMLPDONAD()
	{
		base.gameObject.SetActive(true);
		this.LGOJJBHPIBG();
		this.textInput.SetText("abld", false);
		base.StartCoroutine(this.OPBBIHJPLGI());
	}

	// Token: 0x06004994 RID: 18836 RVA: 0x002126BE File Offset: 0x002108BE
	public void HNLNOCNAMOK()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1092f, 730f);
		}
	}

	// Token: 0x06004995 RID: 18837 RVA: 0x002123A8 File Offset: 0x002105A8
	private IEnumerator IOFJCENBBAP()
	{
		PopupProfileCredoInput.FCOAINIEGLB fcoainieglb = new PopupProfileCredoInput.FCOAINIEGLB(1);
		fcoainieglb.<>4__this = this;
		return fcoainieglb;
	}

	// Token: 0x06004996 RID: 18838 RVA: 0x002123A8 File Offset: 0x002105A8
	private IEnumerator OPBBIHJPLGI()
	{
		PopupProfileCredoInput.FCOAINIEGLB fcoainieglb = new PopupProfileCredoInput.FCOAINIEGLB(1);
		fcoainieglb.<>4__this = this;
		return fcoainieglb;
	}

	// Token: 0x06004997 RID: 18839 RVA: 0x002126E4 File Offset: 0x002108E4
	public void DisappearAnimation()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(0f, 0.5f);
		}
	}

	// Token: 0x06004998 RID: 18840 RVA: 0x00003E52 File Offset: 0x00002052
	private void BHDHJLIBHCJ()
	{
	}

	// Token: 0x06004999 RID: 18841 RVA: 0x00212411 File Offset: 0x00210611
	private void DJIFHJDBBHN()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(true);
		}
	}

	// Token: 0x0600499A RID: 18842 RVA: 0x0021225A File Offset: 0x0021045A
	private void NAKFGFJPBBK()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
	}

	// Token: 0x0600499B RID: 18843 RVA: 0x0021270A File Offset: 0x0021090A
	public void NABADENNICC()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1780f, 593f);
		}
	}

	// Token: 0x0600499C RID: 18844 RVA: 0x00212730 File Offset: 0x00210930
	private void ACHOIKBDFBP()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1028f, 263f);
		}
	}

	// Token: 0x0600499D RID: 18845 RVA: 0x00212756 File Offset: 0x00210956
	private void KHOLJLKNAPJ()
	{
		this.HDKFBJIMKBK();
		this.textInput.SetText("nam", true);
		this.textInput.text = "<size=28px>";
	}

	// Token: 0x0600499E RID: 18846 RVA: 0x0021277F File Offset: 0x0021097F
	public void GHCCIIHEBLG()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1456f, 1974f);
		}
	}

	// Token: 0x0600499F RID: 18847 RVA: 0x002123A8 File Offset: 0x002105A8
	private IEnumerator FFKCEJPBEEG()
	{
		PopupProfileCredoInput.FCOAINIEGLB fcoainieglb = new PopupProfileCredoInput.FCOAINIEGLB(1);
		fcoainieglb.<>4__this = this;
		return fcoainieglb;
	}

	// Token: 0x060049A0 RID: 18848 RVA: 0x002123A8 File Offset: 0x002105A8
	private IEnumerator HDMHNKAGLMN()
	{
		PopupProfileCredoInput.FCOAINIEGLB fcoainieglb = new PopupProfileCredoInput.FCOAINIEGLB(1);
		fcoainieglb.<>4__this = this;
		return fcoainieglb;
	}

	// Token: 0x060049A1 RID: 18849 RVA: 0x002127A5 File Offset: 0x002109A5
	public void AKHDMIEEEHF()
	{
		base.gameObject.SetActive(false);
		this.ACHOIKBDFBP();
		this.textInput.SetText("focusavatarloungeicon", false);
		base.StartCoroutine(this.EFCIKHPLNGG());
	}

	// Token: 0x060049A2 RID: 18850 RVA: 0x002127D7 File Offset: 0x002109D7
	public void PALGHIMMKKI()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(396f, 572f);
		}
	}

	// Token: 0x060049A3 RID: 18851 RVA: 0x00212411 File Offset: 0x00210611
	private void BNJLIDFJOGD()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(true);
		}
	}

	// Token: 0x060049A4 RID: 18852 RVA: 0x002127FD File Offset: 0x002109FD
	public void BNHNOHLINDK()
	{
		base.gameObject.SetActive(true);
		this.IBMHJOGCNHO();
		this.textInput.SetText("oid", false);
		base.StartCoroutine(this.EFCIKHPLNGG());
	}

	// Token: 0x060049A5 RID: 18853 RVA: 0x0021282F File Offset: 0x00210A2F
	private void GNHDCIGPFOH()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1532f;
		}
	}

	// Token: 0x060049A6 RID: 18854 RVA: 0x00212860 File Offset: 0x00210A60
	private IEnumerator CJAHEBHPJDB()
	{
		this.inputField.Select();
		yield return new WaitForSeconds(0.5f);
		this.inputField.ActivateInputField();
		yield break;
	}

	// Token: 0x060049A7 RID: 18855 RVA: 0x00212411 File Offset: 0x00210611
	private void HKFKOMMEMCN()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(true);
		}
	}

	// Token: 0x060049A8 RID: 18856 RVA: 0x0021286F File Offset: 0x00210A6F
	public void GEOIHPGMDJM()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(138f, 1669f);
		}
	}

	// Token: 0x0400152A RID: 5418
	public const string onPopupProfileCredoInputEndEdit = "OnPopupProfileCredoInputEndEdit";

	// Token: 0x0400152B RID: 5419
	public const string onPopupProfileCredoInputCancel = "OnPopupProfileCredoInputCancel";

	// Token: 0x0400152C RID: 5420
	public const float fadeInTime = 0.5f;

	// Token: 0x0400152D RID: 5421
	public const float fadeOutTime = 0.5f;

	// Token: 0x0400152E RID: 5422
	public TextMeshProUGUI textInput;

	// Token: 0x0400152F RID: 5423
	public TMP_InputField inputField;

	// Token: 0x04001530 RID: 5424
	public AnimatedPopupManager animatedPopupManager;

	// Token: 0x04001531 RID: 5425
	private CanvasGroup PANMNKKODPC;
}
