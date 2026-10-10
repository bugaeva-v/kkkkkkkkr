using System;
using System.Collections;
using DG.Tweening;
using TMPro;
using UnityEngine;

// Token: 0x020004D0 RID: 1232
public class PopupProfileNicknameInput : MonoBehaviour
{
	// Token: 0x06009484 RID: 38020 RVA: 0x00416DC4 File Offset: 0x00414FC4
	public void HEILCIEEIPG()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(false);
			AOBJLALDBAA.BIAEAOMHBMM().NEKAFJIEGHG("SceneLobbyManager2.AppendGroupBatch() - ", this.textInput.text);
			this.animatedPopupManager.DDPHFKOHDJB();
			return;
		}
		this.NAKODHJDKEL();
	}

	// Token: 0x06009485 RID: 38021 RVA: 0x00416E16 File Offset: 0x00415016
	private void HDKFBJIMKBK()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1f, 0.5f);
		}
	}

	// Token: 0x06009486 RID: 38022 RVA: 0x00416E3C File Offset: 0x0041503C
	private void INLMEILMIBD()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(584f, 343f);
		}
	}

	// Token: 0x06009487 RID: 38023 RVA: 0x00416E62 File Offset: 0x00415062
	private void KCGJDLHHJPG()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(232f, 1049f);
		}
	}

	// Token: 0x06009488 RID: 38024 RVA: 0x00416E88 File Offset: 0x00415088
	public void NCHPFPLIOOP()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1803f, 1839f);
		}
	}

	// Token: 0x06009489 RID: 38025 RVA: 0x00416EAE File Offset: 0x004150AE
	public void DisappearAnimation()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(0f, 0.5f);
		}
	}

	// Token: 0x0600948A RID: 38026 RVA: 0x00416ED4 File Offset: 0x004150D4
	public void HKGPGGKCEOF()
	{
		this.inputField.DeactivateInputField(true);
		AOBJLALDBAA.BIAEAOMHBMM().EGELHPJBAIC("youreceived", 1546f);
		this.animatedPopupManager.GLIAGHMNMMP();
	}

	// Token: 0x0600948B RID: 38027 RVA: 0x00416F04 File Offset: 0x00415104
	public void JMIIKJLHPJM()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(true);
			AOBJLALDBAA.FILDBDMENPG().PAODLAFIKBG("OnStorySplashManagerAssetBundleFolderInitializeSuccess", this.textInput.text);
			this.animatedPopupManager.KCAPIILJKDN();
			return;
		}
		this.KCPOKKLNMAD();
	}

	// Token: 0x0600948C RID: 38028 RVA: 0x00416F56 File Offset: 0x00415156
	private void LFOJBMBCOFP()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1459f;
		}
	}

	// Token: 0x0600948D RID: 38029 RVA: 0x00416F87 File Offset: 0x00415187
	public void IMDJBODLCFK()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(661f, 1212f);
		}
	}

	// Token: 0x0600948E RID: 38030 RVA: 0x00416FAD File Offset: 0x004151AD
	private void GDKFOLEGMLF()
	{
		this.FGJEJGKOLON();
		this.textInput.SetText("SceneAvatarManager.AddOrUpdateAvatarCollection(): no free collection index left for this wardrobe", true);
		this.textInput.text = "CLIENT.POSTEFFECTS.ANALOGGLITCH20.OVR";
	}

	// Token: 0x0600948F RID: 38031 RVA: 0x00416FD6 File Offset: 0x004151D6
	private void DBMGIICFOGK()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(896f, 1645f);
		}
	}

	// Token: 0x06009490 RID: 38032 RVA: 0x00003E52 File Offset: 0x00002052
	private void LKLNNDNCNOK()
	{
	}

	// Token: 0x06009491 RID: 38033 RVA: 0x00416FFC File Offset: 0x004151FC
	public void JJKHJFBPIFC()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1262f, 952f);
		}
	}

	// Token: 0x06009492 RID: 38034 RVA: 0x00417024 File Offset: 0x00415224
	public void JJKJGBJHABC()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(false);
			AOBJLALDBAA.FILDBDMENPG().NEKAFJIEGHG("", this.textInput.text);
			this.animatedPopupManager.OJNDEJNLMFE();
			return;
		}
		this.NFPFAOEDKIO();
	}

	// Token: 0x06009493 RID: 38035 RVA: 0x00417076 File Offset: 0x00415276
	private void MOOGCGPMILI()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(508f, 486f);
		}
	}

	// Token: 0x06009494 RID: 38036 RVA: 0x0041709C File Offset: 0x0041529C
	private void LPCKKJNJJCB()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 662f;
		}
	}

	// Token: 0x06009495 RID: 38037 RVA: 0x00003E52 File Offset: 0x00002052
	private void Start()
	{
	}

	// Token: 0x06009496 RID: 38038 RVA: 0x004170CD File Offset: 0x004152CD
	private void MBAJBIPOFCB()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(true);
		}
	}

	// Token: 0x06009497 RID: 38039 RVA: 0x004170EA File Offset: 0x004152EA
	private void AILHMCGEMOG()
	{
		this.DBMGIICFOGK();
		this.textInput.SetText("OnRestorePurchasesFailedInvalidPlatform", true);
		this.textInput.text = "</nobr>";
	}

	// Token: 0x06009498 RID: 38040 RVA: 0x00003E52 File Offset: 0x00002052
	private void FPJBOINCKCE()
	{
	}

	// Token: 0x06009499 RID: 38041 RVA: 0x00417113 File Offset: 0x00415313
	private void FGJEJGKOLON()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(992f, 550f);
		}
	}

	// Token: 0x0600949A RID: 38042 RVA: 0x0041713C File Offset: 0x0041533C
	public void OKNLPNJICFH()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(true);
			AOBJLALDBAA.AGANFKKBPFO().OIMGLKLHNMO("en", this.textInput.text);
			this.animatedPopupManager.ADAJPNHIICL();
			return;
		}
		this.KCPOKKLNMAD();
	}

	// Token: 0x0600949B RID: 38043 RVA: 0x0041718E File Offset: 0x0041538E
	public void DLKJCDLEHAA()
	{
		base.gameObject.SetActive(true);
		this.INLMEILMIBD();
		this.textInput.SetText("youreceived", false);
		base.StartCoroutine(this.HLGFOMDPNIH());
	}

	// Token: 0x0600949C RID: 38044 RVA: 0x00003E52 File Offset: 0x00002052
	private void OOHKGEPBDIG()
	{
	}

	// Token: 0x0600949D RID: 38045 RVA: 0x004171C0 File Offset: 0x004153C0
	private void KHMPBJOOHEG()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(405f, 386f);
		}
	}

	// Token: 0x0600949E RID: 38046 RVA: 0x004171E6 File Offset: 0x004153E6
	private void KEJHBFINMJN()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
	}

	// Token: 0x0600949F RID: 38047 RVA: 0x004171E6 File Offset: 0x004153E6
	private void DPGJDANLGIO()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
	}

	// Token: 0x060094A0 RID: 38048 RVA: 0x00417203 File Offset: 0x00415403
	private void EHECBKECKPA()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 849f;
		}
	}

	// Token: 0x060094A1 RID: 38049 RVA: 0x00417234 File Offset: 0x00415434
	private void GCOKAPGFIFJ()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1994f, 1015f);
		}
	}

	// Token: 0x060094A2 RID: 38050 RVA: 0x0041725A File Offset: 0x0041545A
	public void MLANIKPFIMA()
	{
		base.gameObject.SetActive(true);
		this.KHMPBJOOHEG();
		this.textInput.SetText("no", true);
		base.StartCoroutine(this.CCDOFEINKJH());
	}

	// Token: 0x060094A3 RID: 38051 RVA: 0x0041728C File Offset: 0x0041548C
	private void PHHELAPHLOK()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1270f;
		}
	}

	// Token: 0x060094A4 RID: 38052 RVA: 0x004172BD File Offset: 0x004154BD
	public void EINCGCELPML()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(103f, 741f);
		}
	}

	// Token: 0x060094A5 RID: 38053 RVA: 0x004171E6 File Offset: 0x004153E6
	private void JPPBJKKNIED()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
	}

	// Token: 0x060094A6 RID: 38054 RVA: 0x004172E3 File Offset: 0x004154E3
	private void COMPLLBGJPB()
	{
		this.GCOKAPGFIFJ();
		this.textInput.SetText("collect", false);
		this.textInput.text = "ind";
	}

	// Token: 0x060094A7 RID: 38055 RVA: 0x0041730C File Offset: 0x0041550C
	private IEnumerator PKIELHJFPMI()
	{
		this.inputField.Select();
		yield return new WaitForSeconds(0.5f);
		this.inputField.ActivateInputField();
		yield break;
	}

	// Token: 0x060094A8 RID: 38056 RVA: 0x0041731C File Offset: 0x0041551C
	public void MHHIPFMAOJC()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(true);
			AOBJLALDBAA.AGANFKKBPFO().IDEALDBPGJE("OnSceneLobbyManagerExitSyncSuccess", this.textInput.text);
			this.animatedPopupManager.PIPADCCGHBA();
			return;
		}
		this.NAKODHJDKEL();
	}

	// Token: 0x060094A9 RID: 38057 RVA: 0x00417370 File Offset: 0x00415570
	public void HLBGDNEAIJN()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(true);
			AOBJLALDBAA.KKPFOJMAONG().NAHENFMHKAG("anthology", this.textInput.text);
			this.animatedPopupManager.ADAJPNHIICL();
			return;
		}
		this.NFPFAOEDKIO();
	}

	// Token: 0x060094AA RID: 38058 RVA: 0x00003E52 File Offset: 0x00002052
	private void BHDHJLIBHCJ()
	{
	}

	// Token: 0x060094AB RID: 38059 RVA: 0x004173C2 File Offset: 0x004155C2
	private void LDDEIAOCBGB()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1165f;
		}
	}

	// Token: 0x060094AC RID: 38060 RVA: 0x004173F3 File Offset: 0x004155F3
	private void OnEnable()
	{
		this.HDKFBJIMKBK();
		this.textInput.SetText("", true);
		this.textInput.text = "";
	}

	// Token: 0x060094AD RID: 38061 RVA: 0x0041741C File Offset: 0x0041561C
	public void KCPOKKLNMAD()
	{
		this.inputField.DeactivateInputField(true);
		AOBJLALDBAA.KKPFOJMAONG().KMAGHMCCMPG("cut", 1051f);
		this.animatedPopupManager.Hide();
	}

	// Token: 0x060094AE RID: 38062 RVA: 0x004171E6 File Offset: 0x004153E6
	private void PDHDJMJECJA()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
	}

	// Token: 0x060094AF RID: 38063 RVA: 0x00417449 File Offset: 0x00415649
	public void OJGDJMENKHC()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(627f, 1328f);
		}
	}

	// Token: 0x060094B0 RID: 38064 RVA: 0x00003E52 File Offset: 0x00002052
	private void GEHKPILFMLD()
	{
	}

	// Token: 0x060094B1 RID: 38065 RVA: 0x0041746F File Offset: 0x0041566F
	public void BLAHIILHNPC()
	{
		base.gameObject.SetActive(false);
		this.KCGJDLHHJPG();
		this.textInput.SetText("searchpattern", true);
		base.StartCoroutine(this.CCDOFEINKJH());
	}

	// Token: 0x060094B2 RID: 38066 RVA: 0x004174A1 File Offset: 0x004156A1
	private void GHLIAECIGCN()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1697f, 1145f);
		}
	}

	// Token: 0x060094B3 RID: 38067 RVA: 0x0041730C File Offset: 0x0041550C
	private IEnumerator CCDOFEINKJH()
	{
		this.inputField.Select();
		yield return new WaitForSeconds(0.5f);
		this.inputField.ActivateInputField();
		yield break;
	}

	// Token: 0x060094B4 RID: 38068 RVA: 0x0041730C File Offset: 0x0041550C
	private IEnumerator HKIKHLGCBFH()
	{
		this.inputField.Select();
		yield return new WaitForSeconds(0.5f);
		this.inputField.ActivateInputField();
		yield break;
	}

	// Token: 0x060094B5 RID: 38069 RVA: 0x004174C7 File Offset: 0x004156C7
	private void MFLCLDAGFNK()
	{
		this.DBMGIICFOGK();
		this.textInput.SetText("", false);
		this.textInput.text = "Npc animation bundle loaded but its asset is missing or mis-named:";
	}

	// Token: 0x060094B6 RID: 38070 RVA: 0x004174F0 File Offset: 0x004156F0
	public void MFHIDMJGONK()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1139f, 699f);
		}
	}

	// Token: 0x060094B7 RID: 38071 RVA: 0x00417516 File Offset: 0x00415716
	private void MOCOELNLIJG()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1201f, 347f);
		}
	}

	// Token: 0x060094B8 RID: 38072 RVA: 0x0041753C File Offset: 0x0041573C
	public void HMOHIGEBFDE()
	{
		base.gameObject.SetActive(false);
		this.GCOKAPGFIFJ();
		this.textInput.SetText("cbp", true);
		base.StartCoroutine(this.KMJAIOPHLAL());
	}

	// Token: 0x060094B9 RID: 38073 RVA: 0x004171E6 File Offset: 0x004153E6
	private void AKANLCOCAPH()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
	}

	// Token: 0x060094BA RID: 38074 RVA: 0x0041756E File Offset: 0x0041576E
	public void NFPFAOEDKIO()
	{
		this.inputField.DeactivateInputField(false);
		AOBJLALDBAA.KKPFOJMAONG().LPNCDPHNBJK("<nobr>", 276f);
		this.animatedPopupManager.GFEHJHIDHFF();
	}

	// Token: 0x060094BB RID: 38075 RVA: 0x0041759B File Offset: 0x0041579B
	public void OHFBLNAMOCE()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(384f, 628f);
		}
	}

	// Token: 0x060094BC RID: 38076 RVA: 0x0041730C File Offset: 0x0041550C
	private IEnumerator NMCAOHNPGLO()
	{
		this.inputField.Select();
		yield return new WaitForSeconds(0.5f);
		this.inputField.ActivateInputField();
		yield break;
	}

	// Token: 0x060094BD RID: 38077 RVA: 0x004175C1 File Offset: 0x004157C1
	public void NAKODHJDKEL()
	{
		this.inputField.DeactivateInputField(false);
		AOBJLALDBAA.BIAEAOMHBMM().CIGLHCJDDPI("PlayerCharacterManager.UpdateComponentLink() - invalid custom hierarchy for ", 428f);
		this.animatedPopupManager.FJAAHFFLGFF();
	}

	// Token: 0x060094BE RID: 38078 RVA: 0x004175F0 File Offset: 0x004157F0
	public void LBAJNHKNEEO()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(false);
			AOBJLALDBAA.KKPFOJMAONG().EGELHPJBAIC("", this.textInput.text);
			this.animatedPopupManager.DDPHFKOHDJB();
			return;
		}
		this.NAKODHJDKEL();
	}

	// Token: 0x060094BF RID: 38079 RVA: 0x00417642 File Offset: 0x00415842
	public void MDEJKKFMEJC()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(736f, 1871f);
		}
	}

	// Token: 0x060094C0 RID: 38080 RVA: 0x004171E6 File Offset: 0x004153E6
	private void OnDestroy()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
	}

	// Token: 0x060094C1 RID: 38081 RVA: 0x004170CD File Offset: 0x004152CD
	private void DMGCMLIGFCG()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(true);
		}
	}

	// Token: 0x060094C2 RID: 38082 RVA: 0x004171E6 File Offset: 0x004153E6
	private void NLOFDEFADCL()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
	}

	// Token: 0x060094C3 RID: 38083 RVA: 0x00417668 File Offset: 0x00415868
	private void AKIFACAINPL()
	{
		this.HFKMDGNDCGD();
		this.textInput.SetText("spinres", true);
		this.textInput.text = "";
	}

	// Token: 0x060094C4 RID: 38084 RVA: 0x00417691 File Offset: 0x00415891
	private void LLGBJHCIIGA()
	{
		this.MOCOELNLIJG();
		this.textInput.SetText("XXX", false);
		this.textInput.text = "";
	}

	// Token: 0x060094C5 RID: 38085 RVA: 0x004176BA File Offset: 0x004158BA
	public void KFLFFOPPNEO()
	{
		base.gameObject.SetActive(false);
		this.KCGJDLHHJPG();
		this.textInput.SetText("SaveSlotsItem.GetLocalizedCostData() - productData is null.", false);
		base.StartCoroutine(this.HLGFOMDPNIH());
	}

	// Token: 0x060094C6 RID: 38086 RVA: 0x00003E52 File Offset: 0x00002052
	private void GANNEJBHDIM()
	{
	}

	// Token: 0x060094C7 RID: 38087 RVA: 0x004176EC File Offset: 0x004158EC
	private void LOACLFMGICF()
	{
		this.IMHOJNPNKMJ();
		this.textInput.SetText("errortitle", false);
		this.textInput.text = "aind";
	}

	// Token: 0x060094C8 RID: 38088 RVA: 0x00417715 File Offset: 0x00415915
	public void CFOBMDOIGOD()
	{
		base.gameObject.SetActive(false);
		this.KCGJDLHHJPG();
		this.textInput.SetText("cardsvolchancestitle", true);
		base.StartCoroutine(this.HLGFOMDPNIH());
	}

	// Token: 0x060094C9 RID: 38089 RVA: 0x00417747 File Offset: 0x00415947
	public void JBBMOJLEPKF()
	{
		base.gameObject.SetActive(true);
		this.LBDPGIGNEDC();
		this.textInput.SetText("", false);
		base.StartCoroutine(this.HKIKHLGCBFH());
	}

	// Token: 0x060094CA RID: 38090 RVA: 0x0041777C File Offset: 0x0041597C
	public void OnEndEdit()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(false);
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnPopupProfileNicknameInputEndEdit", this.textInput.text);
			this.animatedPopupManager.Hide();
			return;
		}
		this.OnCloseClick();
	}

	// Token: 0x060094CB RID: 38091 RVA: 0x004177CE File Offset: 0x004159CE
	public void JAIBKPNINFE()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(633f, 1365f);
		}
	}

	// Token: 0x060094CC RID: 38092 RVA: 0x004177F4 File Offset: 0x004159F4
	private void GKINGMGGLLP()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1593f, 435f);
		}
	}

	// Token: 0x060094CD RID: 38093 RVA: 0x00003E52 File Offset: 0x00002052
	private void IOGKPKFCKCN()
	{
	}

	// Token: 0x060094CE RID: 38094 RVA: 0x0041781C File Offset: 0x00415A1C
	public void JJMOHDALEAD()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(true);
			AOBJLALDBAA.FILDBDMENPG().IDEALDBPGJE("musvol", this.textInput.text);
			this.animatedPopupManager.HFFJACPIHKE();
			return;
		}
		this.NFPFAOEDKIO();
	}

	// Token: 0x060094CF RID: 38095 RVA: 0x00417870 File Offset: 0x00415A70
	public void HGFKDAJINHH()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(false);
			AOBJLALDBAA.AGANFKKBPFO().AKILMNPJGGM("tmo", this.textInput.text);
			this.animatedPopupManager.PIPADCCGHBA();
			return;
		}
		this.NAKODHJDKEL();
	}

	// Token: 0x060094D0 RID: 38096 RVA: 0x004170CD File Offset: 0x004152CD
	private void CDNMKPKIHIH()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(true);
		}
	}

	// Token: 0x060094D1 RID: 38097 RVA: 0x00003E52 File Offset: 0x00002052
	private void PKMPOFOOGFK()
	{
	}

	// Token: 0x060094D2 RID: 38098 RVA: 0x004178C2 File Offset: 0x00415AC2
	public void MGGIGIDJENE()
	{
		base.gameObject.SetActive(true);
		this.MOCOELNLIJG();
		this.textInput.SetText("congratstitle", false);
		base.StartCoroutine(this.CJAHEBHPJDB());
	}

	// Token: 0x060094D4 RID: 38100 RVA: 0x004178F4 File Offset: 0x00415AF4
	public void BNMPAKBEIKG()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1761f, 1015f);
		}
	}

	// Token: 0x060094D5 RID: 38101 RVA: 0x0041791A File Offset: 0x00415B1A
	private void PMDCMEKGFNN()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1687f;
		}
	}

	// Token: 0x060094D6 RID: 38102 RVA: 0x00003E52 File Offset: 0x00002052
	private void KLFNFIFOHFD()
	{
	}

	// Token: 0x060094D7 RID: 38103 RVA: 0x0041794B File Offset: 0x00415B4B
	public void MNBGBKOJBLO()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1790f, 1502f);
		}
	}

	// Token: 0x060094D8 RID: 38104 RVA: 0x00417971 File Offset: 0x00415B71
	public void CIENEJHIDBN()
	{
		this.inputField.DeactivateInputField(false);
		AOBJLALDBAA.EHBBFMCILPC.FDKBIBKABCM("needtorestartgeneric", 1922f);
		this.animatedPopupManager.DDPHFKOHDJB();
	}

	// Token: 0x060094D9 RID: 38105 RVA: 0x004179A0 File Offset: 0x00415BA0
	public void PGJLGCJDFPB()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(true);
			AOBJLALDBAA.EHBBFMCILPC.AKILMNPJGGM("asp", this.textInput.text);
			this.animatedPopupManager.KCAPIILJKDN();
			return;
		}
		this.NAKODHJDKEL();
	}

	// Token: 0x060094DA RID: 38106 RVA: 0x004179F2 File Offset: 0x00415BF2
	private void JPOJGNHEJAI()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(264f, 443f);
		}
	}

	// Token: 0x060094DB RID: 38107 RVA: 0x00417A18 File Offset: 0x00415C18
	public void Show()
	{
		base.gameObject.SetActive(true);
		this.HDKFBJIMKBK();
		this.textInput.SetText("", true);
		base.StartCoroutine(this.CJAHEBHPJDB());
	}

	// Token: 0x060094DC RID: 38108 RVA: 0x00417A4A File Offset: 0x00415C4A
	private void LBDPGIGNEDC()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1201f, 1104f);
		}
	}

	// Token: 0x060094DD RID: 38109 RVA: 0x004170CD File Offset: 0x004152CD
	private void LOCANABKJEE()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(true);
		}
	}

	// Token: 0x060094DE RID: 38110 RVA: 0x00417A70 File Offset: 0x00415C70
	public void PAMPANGOMPE()
	{
		base.gameObject.SetActive(false);
		this.LBDPGIGNEDC();
		this.textInput.SetText("yes", true);
		base.StartCoroutine(this.HKIKHLGCBFH());
	}

	// Token: 0x060094DF RID: 38111 RVA: 0x0041730C File Offset: 0x0041550C
	private IEnumerator KMJAIOPHLAL()
	{
		this.inputField.Select();
		yield return new WaitForSeconds(0.5f);
		this.inputField.ActivateInputField();
		yield break;
	}

	// Token: 0x060094E0 RID: 38112 RVA: 0x00417AA2 File Offset: 0x00415CA2
	private IEnumerator EFCIKHPLNGG()
	{
		PopupProfileNicknameInput.FCOAINIEGLB fcoainieglb = new PopupProfileNicknameInput.FCOAINIEGLB(1);
		fcoainieglb.<>4__this = this;
		return fcoainieglb;
	}

	// Token: 0x060094E1 RID: 38113 RVA: 0x00417AB1 File Offset: 0x00415CB1
	public void JBHCOBIBMFK()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(34f, 1066f);
		}
	}

	// Token: 0x060094E2 RID: 38114 RVA: 0x004171E6 File Offset: 0x004153E6
	private void CODLJCAKBLI()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
	}

	// Token: 0x060094E3 RID: 38115 RVA: 0x004171E6 File Offset: 0x004153E6
	private void GMGJONBEDNE()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
	}

	// Token: 0x060094E4 RID: 38116 RVA: 0x0041730C File Offset: 0x0041550C
	private IEnumerator CJAHEBHPJDB()
	{
		this.inputField.Select();
		yield return new WaitForSeconds(0.5f);
		this.inputField.ActivateInputField();
		yield break;
	}

	// Token: 0x060094E5 RID: 38117 RVA: 0x004170CD File Offset: 0x004152CD
	private void JPNDEHBIOGC()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(true);
		}
	}

	// Token: 0x060094E6 RID: 38118 RVA: 0x00417AD7 File Offset: 0x00415CD7
	private void HFKMDGNDCGD()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(765f, 1397f);
		}
	}

	// Token: 0x060094E7 RID: 38119 RVA: 0x00417B00 File Offset: 0x00415D00
	public void GNMCEECPOOG()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(true);
			AOBJLALDBAA.BIAEAOMHBMM().PAODLAFIKBG("", this.textInput.text);
			this.animatedPopupManager.Hide();
			return;
		}
		this.OnCloseClick();
	}

	// Token: 0x060094E8 RID: 38120 RVA: 0x00417B52 File Offset: 0x00415D52
	private void IMHOJNPNKMJ()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1197f, 132f);
		}
	}

	// Token: 0x060094E9 RID: 38121 RVA: 0x00417B78 File Offset: 0x00415D78
	public void OnCloseClick()
	{
		this.inputField.DeactivateInputField(false);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnPopupProfileNicknameInputCancel", 0f);
		this.animatedPopupManager.Hide();
	}

	// Token: 0x060094EA RID: 38122 RVA: 0x00417BA5 File Offset: 0x00415DA5
	private void Awake()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 0f;
		}
	}

	// Token: 0x060094EB RID: 38123 RVA: 0x00417BD6 File Offset: 0x00415DD6
	private void FPGEBMIFOPK()
	{
		this.JPOJGNHEJAI();
		this.textInput.SetText("CustomCodeCallback - lastCallbackObj not confirmed. Killing response execution.", false);
		this.textInput.text = ">";
	}

	// Token: 0x060094EC RID: 38124 RVA: 0x0041730C File Offset: 0x0041550C
	private IEnumerator HLGFOMDPNIH()
	{
		this.inputField.Select();
		yield return new WaitForSeconds(0.5f);
		this.inputField.ActivateInputField();
		yield break;
	}

	// Token: 0x0400295E RID: 10590
	public const string onPopupProfileNicknameInputEndEdit = "OnPopupProfileNicknameInputEndEdit";

	// Token: 0x0400295F RID: 10591
	public const string onPopupProfileNicknameInputCancel = "OnPopupProfileNicknameInputCancel";

	// Token: 0x04002960 RID: 10592
	public const float fadeInTime = 0.5f;

	// Token: 0x04002961 RID: 10593
	public const float fadeOutTime = 0.5f;

	// Token: 0x04002962 RID: 10594
	public TextMeshProUGUI textInput;

	// Token: 0x04002963 RID: 10595
	public TMP_InputField inputField;

	// Token: 0x04002964 RID: 10596
	public AnimatedPopupManager animatedPopupManager;

	// Token: 0x04002965 RID: 10597
	private CanvasGroup PANMNKKODPC;
}
