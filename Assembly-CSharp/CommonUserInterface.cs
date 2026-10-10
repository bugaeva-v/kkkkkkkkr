using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x0200035B RID: 859
public class CommonUserInterface : MonoBehaviour
{
	// Token: 0x0600660D RID: 26125 RVA: 0x002F62A3 File Offset: 0x002F44A3
	public void CAFEBMPJBJA()
	{
		this.popupProfileCredoInput.BNHNOHLINDK();
	}

	// Token: 0x0600660E RID: 26126 RVA: 0x002F62B0 File Offset: 0x002F44B0
	public GenericPopupManager ShowGenericPopup(string EEMPGLHPKJG, string DPJINBCGNGN, string CAGMDHNGAEH, DFGILFBGPLN LAPLGLHKEJE, float BICHMDEIFKI = 0f, int LINDILPPNNK = 28)
	{
		FirebaseAnalyticsManager.EHBBFMCILPC.LogScreen(LAPLGLHKEJE.ToString());
		this.delayedFullScreenBlock.SetActive(true);
		base.StartCoroutine(this.LNANDNHLIOP(EEMPGLHPKJG, DPJINBCGNGN, CAGMDHNGAEH, BICHMDEIFKI, LINDILPPNNK));
		return this.genericPopup;
	}

	// Token: 0x0600660F RID: 26127 RVA: 0x002F62EF File Offset: 0x002F44EF
	public void ResumeUX()
	{
		this.fullScreenBlock.SetActive(false);
	}

	// Token: 0x06006610 RID: 26128 RVA: 0x002F62FD File Offset: 0x002F44FD
	public SketchViewManager GetSketchViewManager()
	{
		return AssetsManager.EHBBFMCILPC.sketchViewManager;
	}

	// Token: 0x06006611 RID: 26129 RVA: 0x002F6309 File Offset: 0x002F4509
	private IEnumerator LNANDNHLIOP(string EEMPGLHPKJG, string DPJINBCGNGN, string CAGMDHNGAEH, float BICHMDEIFKI, int LINDILPPNNK)
	{
		if (BICHMDEIFKI > 0.01f)
		{
			yield return new WaitForSeconds(BICHMDEIFKI);
		}
		yield return new WaitForEndOfFrame();
		this.genericPopup.SetFontSize(LINDILPPNNK);
		this.genericPopup.ShowOneButton(EEMPGLHPKJG, DPJINBCGNGN, CAGMDHNGAEH);
		this.delayedFullScreenBlock.SetActive(false);
		yield break;
	}

	// Token: 0x06006612 RID: 26130 RVA: 0x002F6340 File Offset: 0x002F4540
	public GenericPopupManager NLFBAJCKKAN(string EEMPGLHPKJG, string DPJINBCGNGN, string FNEAAEFOOEJ, string MCDCGPAADJA, UnityAction OIOPFHOHKDC, UnityAction KIDLMPIPKHL, UnityAction NHCNLLNPAJP, DFGILFBGPLN LAPLGLHKEJE, float BICHMDEIFKI = 0f, int LINDILPPNNK = 28)
	{
		FirebaseAnalyticsManager.JMDJBFAEHBM().PDPAKIJICNL(LAPLGLHKEJE.ToString());
		this.delayedFullScreenBlock.SetActive(true);
		base.StartCoroutine(this.MIPLACDGPEH(EEMPGLHPKJG, DPJINBCGNGN, FNEAAEFOOEJ, MCDCGPAADJA, OIOPFHOHKDC, KIDLMPIPKHL, NHCNLLNPAJP, BICHMDEIFKI, LINDILPPNNK));
		return this.genericPopupTwoButtonsBlack;
	}

	// Token: 0x06006613 RID: 26131 RVA: 0x002F6392 File Offset: 0x002F4592
	public void GCHLHEIAGBP()
	{
		this.popupPasswordInput.NOBOPEABJHA();
	}

	// Token: 0x06006614 RID: 26132 RVA: 0x002F63A0 File Offset: 0x002F45A0
	public void ShowConnectingAnimationTopWithHint(string CNAEPCMCFMD, byte IGLCKLCKDKO = 0)
	{
		this.connectingAnimationTopTextProgress.gameObject.SetActive(false);
		this.connectingAnimationTopTextHint.gameObject.SetActive(true);
		this.connectingAnimationTopTextHint.SetText(CNAEPCMCFMD, true);
		this.connectingAnimationTopFade.color = new Color32(0, 0, 0, IGLCKLCKDKO);
		bool activeSelf = this.connectingAnimationTop.gameObject.activeSelf;
		this.connectingAnimationTop.gameObject.SetActive(true);
		if (!activeSelf || this.GFAMDMIEPFG)
		{
			this.connectingAnimationTop.SetDirection(false);
			this.connectingAnimationTop.PlayAnimation(false);
		}
		this.GFAMDMIEPFG = false;
	}

	// Token: 0x06006615 RID: 26133 RVA: 0x002F6440 File Offset: 0x002F4640
	public GenericPopupManager DAEBECANADA(string EEMPGLHPKJG, string DPJINBCGNGN, string DCBPPPGKHEJ, string NENGGAECHKF, string HDOAPHHFMAP, string PODLGPEGNLJ, UnityAction JBCIIEJDGJB, UnityAction HDNDIOMNBBJ, UnityAction CHMMLHPJJJL, UnityAction ACOCOEFNJBH, UnityAction KIDLMPIPKHL, DFGILFBGPLN LAPLGLHKEJE, float BICHMDEIFKI = 0f, int LINDILPPNNK = 28)
	{
		FirebaseAnalyticsManager.DEALKJPEMMH().FAEMDBGLPDF(LAPLGLHKEJE.ToString());
		this.delayedFullScreenBlock.SetActive(true);
		base.StartCoroutine(this.LNMGOCFPJEP(EEMPGLHPKJG, DPJINBCGNGN, DCBPPPGKHEJ, NENGGAECHKF, HDOAPHHFMAP, PODLGPEGNLJ, JBCIIEJDGJB, HDNDIOMNBBJ, CHMMLHPJJJL, ACOCOEFNJBH, KIDLMPIPKHL, BICHMDEIFKI, LINDILPPNNK));
		return this.genericPopupFourButtonsInsideBlack;
	}

	// Token: 0x06006616 RID: 26134 RVA: 0x002F649A File Offset: 0x002F469A
	public void PCCJEIHBIBD()
	{
		this.gamePassSettingsPopup.BNHNOHLINDK();
	}

	// Token: 0x06006617 RID: 26135 RVA: 0x002F64A8 File Offset: 0x002F46A8
	private IEnumerator HHHGGINAFFB(string EEMPGLHPKJG, string DPJINBCGNGN, string DCBPPPGKHEJ, string NENGGAECHKF, string HDOAPHHFMAP, string PODLGPEGNLJ, UnityAction JBCIIEJDGJB, UnityAction HDNDIOMNBBJ, UnityAction CHMMLHPJJJL, UnityAction ACOCOEFNJBH, UnityAction KIDLMPIPKHL, float BICHMDEIFKI, int LINDILPPNNK)
	{
		CommonUserInterface.ECLCGNIDEBE eclcgnidebe = new CommonUserInterface.ECLCGNIDEBE(1);
		eclcgnidebe.<>4__this = this;
		eclcgnidebe._textTitle = EEMPGLHPKJG;
		eclcgnidebe._textBody = DPJINBCGNGN;
		eclcgnidebe._button1Text = DCBPPPGKHEJ;
		eclcgnidebe._button2Text = NENGGAECHKF;
		eclcgnidebe._button3Text = HDOAPHHFMAP;
		eclcgnidebe._button4Text = PODLGPEGNLJ;
		eclcgnidebe._button1Listener = JBCIIEJDGJB;
		eclcgnidebe._button2Listener = HDNDIOMNBBJ;
		eclcgnidebe._button3Listener = CHMMLHPJJJL;
		eclcgnidebe._button4Listener = ACOCOEFNJBH;
		eclcgnidebe._negativeButtonListener = KIDLMPIPKHL;
		eclcgnidebe._delay = BICHMDEIFKI;
		eclcgnidebe._fontSizeOverride = LINDILPPNNK;
		return eclcgnidebe;
	}

	// Token: 0x06006618 RID: 26136 RVA: 0x002F6528 File Offset: 0x002F4728
	public GenericPopupManager ShowGenericPopupWithTwoButtonsGreen(string EEMPGLHPKJG, string DPJINBCGNGN, string FNEAAEFOOEJ, string MCDCGPAADJA, UnityAction OIOPFHOHKDC, UnityAction KIDLMPIPKHL, DFGILFBGPLN LAPLGLHKEJE, float BICHMDEIFKI = 0f, int LINDILPPNNK = 28)
	{
		FirebaseAnalyticsManager.EHBBFMCILPC.LogScreen(LAPLGLHKEJE.ToString());
		this.delayedFullScreenBlock.SetActive(true);
		base.StartCoroutine(this.EKFPODLDMFP(EEMPGLHPKJG, DPJINBCGNGN, FNEAAEFOOEJ, MCDCGPAADJA, OIOPFHOHKDC, KIDLMPIPKHL, BICHMDEIFKI, LINDILPPNNK));
		return this.genericPopupTwoButtonsGreen;
	}

	// Token: 0x06006619 RID: 26137 RVA: 0x002F6578 File Offset: 0x002F4778
	public PopupProfileMessageInput GetPopupProfileMessageInput()
	{
		return this.popupProfileMessageInput;
	}

	// Token: 0x0600661A RID: 26138 RVA: 0x002F6580 File Offset: 0x002F4780
	public void ShowConnectingAnimationWithHint(string CNAEPCMCFMD, byte IGLCKLCKDKO = 0)
	{
		this.connectingAnimationTextProgress.gameObject.SetActive(false);
		this.connectingAnimationTextHint.gameObject.SetActive(true);
		this.connectingAnimationTextHint.SetText(CNAEPCMCFMD, true);
		this.connectingAnimationFade.color = new Color32(0, 0, 0, IGLCKLCKDKO);
		this.connectingAnimationShadow.gameObject.SetActive(false);
		bool activeSelf = this.connectingAnimation.gameObject.activeSelf;
		this.connectingAnimation.gameObject.SetActive(true);
		if (!activeSelf || this.DFEEFCBHMLF)
		{
			this.connectingAnimation.SetDirection(false);
			this.connectingAnimation.PlayAnimation(false);
		}
		this.DFEEFCBHMLF = false;
	}

	// Token: 0x0600661B RID: 26139 RVA: 0x002F6630 File Offset: 0x002F4830
	public void HMAEIKNBJFO(int CPKFEMAOOBH)
	{
		this.popupProfileUIDInput.OOIAGHBAFIC(CPKFEMAOOBH);
	}

	// Token: 0x0600661C RID: 26140 RVA: 0x002F663E File Offset: 0x002F483E
	public void JCGBJNDNAMH()
	{
		this.popupPasswordInput.Show();
	}

	// Token: 0x0600661D RID: 26141 RVA: 0x002F664B File Offset: 0x002F484B
	public PopupStoryRestartManager OHNDEGNEMIB()
	{
		return this.storyRestartPopup;
	}

	// Token: 0x0600661E RID: 26142 RVA: 0x002F6653 File Offset: 0x002F4853
	public CutsceneViewManager GetCutsceneViewManager()
	{
		return AssetsManager.EHBBFMCILPC.cutsceneViewManager;
	}

	// Token: 0x0600661F RID: 26143 RVA: 0x002F6660 File Offset: 0x002F4860
	private IEnumerator DPPDBFOAPJO(string EEMPGLHPKJG, string DPJINBCGNGN, string FNEAAEFOOEJ, string MCDCGPAADJA, UnityAction OIOPFHOHKDC, UnityAction KIDLMPIPKHL, float BICHMDEIFKI, int LINDILPPNNK)
	{
		if (BICHMDEIFKI > 0.01f)
		{
			yield return new WaitForSeconds(BICHMDEIFKI);
		}
		yield return new WaitForEndOfFrame();
		if (OIOPFHOHKDC != null)
		{
			this.genericPopupTwoButtonsBlack.SetOnClickListenerButtonPositive(OIOPFHOHKDC);
		}
		if (KIDLMPIPKHL != null)
		{
			this.genericPopupTwoButtonsBlack.SetOnClickListenerButtonNegativeAndClose(KIDLMPIPKHL);
		}
		this.genericPopupTwoButtonsBlack.SetFontSize(LINDILPPNNK);
		this.genericPopupTwoButtonsBlack.ShowTwoButtons(EEMPGLHPKJG, DPJINBCGNGN, FNEAAEFOOEJ, MCDCGPAADJA);
		this.delayedFullScreenBlock.SetActive(false);
		yield break;
	}

	// Token: 0x06006620 RID: 26144 RVA: 0x002F66B7 File Offset: 0x002F48B7
	public void CHOPDCGDFNJ()
	{
		this.connectingAnimationShadow.gameObject.SetActive(false);
	}

	// Token: 0x06006621 RID: 26145 RVA: 0x002F66CC File Offset: 0x002F48CC
	private IEnumerator MIPLACDGPEH(string EEMPGLHPKJG, string DPJINBCGNGN, string FNEAAEFOOEJ, string MCDCGPAADJA, UnityAction OIOPFHOHKDC, UnityAction KIDLMPIPKHL, UnityAction NHCNLLNPAJP, float BICHMDEIFKI, int LINDILPPNNK)
	{
		if (BICHMDEIFKI > 0.01f)
		{
			yield return new WaitForSeconds(BICHMDEIFKI);
		}
		yield return new WaitForEndOfFrame();
		if (OIOPFHOHKDC != null)
		{
			this.genericPopupTwoButtonsBlack.SetOnClickListenerButtonPositive(OIOPFHOHKDC);
		}
		if (KIDLMPIPKHL != null)
		{
			this.genericPopupTwoButtonsBlack.SetOnClickListenerButtonNegative(KIDLMPIPKHL);
		}
		if (NHCNLLNPAJP != null)
		{
			this.genericPopupTwoButtonsBlack.SetOnClickListenerButtonClose(NHCNLLNPAJP);
		}
		this.genericPopupTwoButtonsBlack.SetFontSize(LINDILPPNNK);
		this.genericPopupTwoButtonsBlack.ShowTwoButtons(EEMPGLHPKJG, DPJINBCGNGN, FNEAAEFOOEJ, MCDCGPAADJA);
		this.delayedFullScreenBlock.SetActive(false);
		yield break;
	}

	// Token: 0x06006622 RID: 26146 RVA: 0x002F672B File Offset: 0x002F492B
	public void ShowPopupOffer(string IHCGMFBCMOO, ProducThumbnailGraphics DHAGPIAMELI)
	{
		this.popupOfferManager.Show(IHCGMFBCMOO, DHAGPIAMELI);
	}

	// Token: 0x06006623 RID: 26147 RVA: 0x002F673C File Offset: 0x002F493C
	public GenericPopupManager ShowGenericPopupWithTwoButtonsAndCloseOverrideGreen(string EEMPGLHPKJG, string DPJINBCGNGN, string FNEAAEFOOEJ, string MCDCGPAADJA, UnityAction OIOPFHOHKDC, UnityAction KIDLMPIPKHL, UnityAction NHCNLLNPAJP, DFGILFBGPLN LAPLGLHKEJE, float BICHMDEIFKI = 0f, int LINDILPPNNK = 28)
	{
		FirebaseAnalyticsManager.EHBBFMCILPC.LogScreen(LAPLGLHKEJE.ToString());
		this.delayedFullScreenBlock.SetActive(true);
		base.StartCoroutine(this.DAOONFOOENP(EEMPGLHPKJG, DPJINBCGNGN, FNEAAEFOOEJ, MCDCGPAADJA, OIOPFHOHKDC, KIDLMPIPKHL, NHCNLLNPAJP, BICHMDEIFKI, LINDILPPNNK));
		return this.genericPopupTwoButtonsGreen;
	}

	// Token: 0x06006624 RID: 26148 RVA: 0x002F678E File Offset: 0x002F498E
	public void ShowSettings(bool NJIFMMKNDOP, bool MFKDFMNLHEP, bool KDGPDKKDPJD)
	{
		this.settingsPopup.Show(NJIFMMKNDOP, MFKDFMNLHEP, KDGPDKKDPJD);
	}

	// Token: 0x06006625 RID: 26149 RVA: 0x002F67A0 File Offset: 0x002F49A0
	public void OJMOLBCCBEH(string CNAEPCMCFMD, byte IGLCKLCKDKO = 0)
	{
		this.connectingAnimationTopTextProgress.gameObject.SetActive(true);
		this.connectingAnimationTopTextHint.gameObject.SetActive(false);
		this.connectingAnimationTopTextHint.SetText(CNAEPCMCFMD, true);
		this.connectingAnimationTopFade.color = new Color32(0, 0, 0, IGLCKLCKDKO);
		bool activeSelf = this.connectingAnimationTop.gameObject.activeSelf;
		this.connectingAnimationTop.gameObject.SetActive(true);
		if (!activeSelf || this.GFAMDMIEPFG)
		{
			this.connectingAnimationTop.HOCMCDHLIAE(true);
			this.connectingAnimationTop.PGKFNLNMIHN(false);
		}
		this.GFAMDMIEPFG = true;
	}

	// Token: 0x06006626 RID: 26150 RVA: 0x002F683F File Offset: 0x002F4A3F
	public void SetStandardFaderParams()
	{
		this.fader.SetFadeInDuration(0.5f);
		this.fader.SetFadeOutDuration(0.5f);
	}

	// Token: 0x06006627 RID: 26151 RVA: 0x002F6861 File Offset: 0x002F4A61
	private IEnumerator JKHDFBJEEBA(string EEMPGLHPKJG, string DPJINBCGNGN, float BICHMDEIFKI, int LINDILPPNNK)
	{
		CommonUserInterface.EAJDDIDFNEJ eajddidfnej = new CommonUserInterface.EAJDDIDFNEJ(1);
		eajddidfnej.<>4__this = this;
		eajddidfnej._textTitle = EEMPGLHPKJG;
		eajddidfnej._textBody = DPJINBCGNGN;
		eajddidfnej._delay = BICHMDEIFKI;
		eajddidfnej._fontSizeOverride = LINDILPPNNK;
		return eajddidfnej;
	}

	// Token: 0x06006628 RID: 26152 RVA: 0x002F6890 File Offset: 0x002F4A90
	public void HideConnectingAnimation()
	{
		this.DFEEFCBHMLF = true;
		this.connectingAnimation.SetDirection(true);
		this.connectingAnimation.PlayAnimation(true);
		this.connectingAnimationShadow.gameObject.SetActive(false);
		this.GFAMDMIEPFG = true;
		this.connectingAnimationTop.SetDirection(true);
		this.connectingAnimationTop.PlayAnimation(true);
	}

	// Token: 0x06006629 RID: 26153 RVA: 0x002F68EC File Offset: 0x002F4AEC
	public void HidePurchasingView()
	{
		AssetsManager.EHBBFMCILPC.purchasingViewManager.Hide();
	}

	// Token: 0x0600662A RID: 26154 RVA: 0x002F68FD File Offset: 0x002F4AFD
	public void ShowPopupProfileNickNameInput()
	{
		this.popupProfileNicknameInput.Show();
	}

	// Token: 0x0600662B RID: 26155 RVA: 0x002F690A File Offset: 0x002F4B0A
	public void MBPKEDKNGAF()
	{
		this.GFAMDMIEPFG = false;
		this.connectingAnimationTop.BKCIEFBJBLA(false);
		this.connectingAnimationTop.IFBEGMNMGMP(true);
	}

	// Token: 0x0600662C RID: 26156 RVA: 0x002F692B File Offset: 0x002F4B2B
	public PurchasingViewManager GetPurchasingViewManager()
	{
		return AssetsManager.EHBBFMCILPC.purchasingViewManager;
	}

	// Token: 0x0600662D RID: 26157 RVA: 0x002F6937 File Offset: 0x002F4B37
	public AvatarCollectionsItem CKJLONADNLA()
	{
		return this.avatarCollectionsItem;
	}

	// Token: 0x0600662E RID: 26158 RVA: 0x002F693F File Offset: 0x002F4B3F
	public void EONPGFAALHF()
	{
		this.popupGenericNotification.ShowUpdateWelcomeNotification(AssetsManager.MJBDMHPHMID().lobbyDataAsset, CCOJBMMKNAP.BBGECIKOICE().GGPHHLGPMPA("Account.ResolveSaveSlots(): Start"), "", 98);
	}

	// Token: 0x0600662F RID: 26159 RVA: 0x002F696C File Offset: 0x002F4B6C
	public GenericPopupManager ShowGenericPopupWithFourButtonsInside(string EEMPGLHPKJG, string DPJINBCGNGN, string DCBPPPGKHEJ, string NENGGAECHKF, string HDOAPHHFMAP, string PODLGPEGNLJ, UnityAction JBCIIEJDGJB, UnityAction HDNDIOMNBBJ, UnityAction CHMMLHPJJJL, UnityAction ACOCOEFNJBH, UnityAction KIDLMPIPKHL, DFGILFBGPLN LAPLGLHKEJE, float BICHMDEIFKI = 0f, int LINDILPPNNK = 28)
	{
		FirebaseAnalyticsManager.EHBBFMCILPC.LogScreen(LAPLGLHKEJE.ToString());
		this.delayedFullScreenBlock.SetActive(true);
		base.StartCoroutine(this.LPCJNIKDHDG(EEMPGLHPKJG, DPJINBCGNGN, DCBPPPGKHEJ, NENGGAECHKF, HDOAPHHFMAP, PODLGPEGNLJ, JBCIIEJDGJB, HDNDIOMNBBJ, CHMMLHPJJJL, ACOCOEFNJBH, KIDLMPIPKHL, BICHMDEIFKI, LINDILPPNNK));
		return this.genericPopupFourButtonsInside;
	}

	// Token: 0x06006630 RID: 26160 RVA: 0x002F69C6 File Offset: 0x002F4BC6
	public void FreezeUX()
	{
		this.fullScreenBlock.SetActive(true);
	}

	// Token: 0x06006631 RID: 26161 RVA: 0x002F69D4 File Offset: 0x002F4BD4
	public GenericPopupManager BGJFCEEDGFJ(string EEMPGLHPKJG, string DPJINBCGNGN, string CAGMDHNGAEH, UnityAction OIOPFHOHKDC, DFGILFBGPLN LAPLGLHKEJE, float BICHMDEIFKI = 0f, int LINDILPPNNK = 28)
	{
		FirebaseAnalyticsManager.ANCEKPONIFI().OJDGAFEBPLC(LAPLGLHKEJE.ToString());
		this.delayedFullScreenBlock.SetActive(false);
		base.StartCoroutine(this.BBLMAKPOKBA(EEMPGLHPKJG, DPJINBCGNGN, CAGMDHNGAEH, OIOPFHOHKDC, BICHMDEIFKI, LINDILPPNNK));
		return this.genericPopup;
	}

	// Token: 0x06006632 RID: 26162 RVA: 0x002F6A20 File Offset: 0x002F4C20
	private IEnumerator NIAEGOGIPAB(string EEMPGLHPKJG, string DPJINBCGNGN, string DCBPPPGKHEJ, string NENGGAECHKF, string HDOAPHHFMAP, UnityAction JBCIIEJDGJB, UnityAction HDNDIOMNBBJ, UnityAction CHMMLHPJJJL, UnityAction KIDLMPIPKHL, float BICHMDEIFKI, int LINDILPPNNK)
	{
		if (BICHMDEIFKI > 0.01f)
		{
			yield return new WaitForSeconds(BICHMDEIFKI);
		}
		yield return new WaitForEndOfFrame();
		if (JBCIIEJDGJB != null)
		{
			this.genericPopupThreeButtonsInside.SetOnClickListenerButtonPositive(JBCIIEJDGJB);
		}
		if (HDNDIOMNBBJ != null)
		{
			this.genericPopupThreeButtonsInside.SetOnClickListenerButtonOptional1(HDNDIOMNBBJ);
		}
		if (CHMMLHPJJJL != null)
		{
			this.genericPopupThreeButtonsInside.SetOnClickListenerButtonOptional2(CHMMLHPJJJL);
		}
		if (KIDLMPIPKHL != null)
		{
			this.genericPopupThreeButtonsInside.SetOnClickListenerButtonNegativeAndClose(KIDLMPIPKHL);
		}
		this.genericPopupTwoButtonsGreen.SetFontSize(LINDILPPNNK);
		this.genericPopupThreeButtonsInside.ShowThreeButtons(EEMPGLHPKJG, DPJINBCGNGN, DCBPPPGKHEJ, NENGGAECHKF, HDOAPHHFMAP);
		this.delayedFullScreenBlock.SetActive(false);
		yield break;
	}

	// Token: 0x06006633 RID: 26163 RVA: 0x002F6A90 File Offset: 0x002F4C90
	private IEnumerator DAOONFOOENP(string EEMPGLHPKJG, string DPJINBCGNGN, string FNEAAEFOOEJ, string MCDCGPAADJA, UnityAction OIOPFHOHKDC, UnityAction KIDLMPIPKHL, UnityAction NHCNLLNPAJP, float BICHMDEIFKI, int LINDILPPNNK)
	{
		if (BICHMDEIFKI > 0.01f)
		{
			yield return new WaitForSeconds(BICHMDEIFKI);
		}
		yield return new WaitForEndOfFrame();
		if (OIOPFHOHKDC != null)
		{
			this.genericPopupTwoButtonsGreen.SetOnClickListenerButtonPositive(OIOPFHOHKDC);
		}
		if (KIDLMPIPKHL != null)
		{
			this.genericPopupTwoButtonsGreen.SetOnClickListenerButtonNegative(KIDLMPIPKHL);
		}
		if (NHCNLLNPAJP != null)
		{
			this.genericPopupTwoButtonsGreen.SetOnClickListenerButtonClose(NHCNLLNPAJP);
		}
		this.genericPopupTwoButtonsGreen.SetFontSize(LINDILPPNNK);
		this.genericPopupTwoButtonsGreen.ShowTwoButtons(EEMPGLHPKJG, DPJINBCGNGN, FNEAAEFOOEJ, MCDCGPAADJA);
		this.delayedFullScreenBlock.SetActive(false);
		yield break;
	}

	// Token: 0x06006634 RID: 26164 RVA: 0x002F6AF0 File Offset: 0x002F4CF0
	public void Reset()
	{
		this.mainGroup.SetActive(true);
		this.fader.Reset();
		this.SetStandardFaderParams();
		this.fullScreenBlock.SetActive(false);
		this.genericPopup.gameObject.SetActive(false);
		this.genericPopupNoButtons.gameObject.SetActive(false);
		this.genericPopupTwoButtons.gameObject.SetActive(false);
		this.genericPopupTwoButtonsBlack.gameObject.SetActive(false);
		this.genericPopupTwoButtonsGreen.gameObject.SetActive(false);
		this.genericPopupThreeButtonsInside.gameObject.SetActive(false);
		this.genericPopupThreeButtonsInsideBlack.gameObject.SetActive(false);
		this.genericPopupFourButtonsInside.gameObject.SetActive(false);
		this.genericPopupFourButtonsInsideBlack.gameObject.SetActive(false);
		this.connectingAnimation.gameObject.SetActive(false);
		this.connectingAnimationShadow.gameObject.SetActive(false);
		this.connectingAnimationTextProgress.gameObject.SetActive(false);
		this.connectingAnimationTextHint.gameObject.SetActive(false);
		this.connectingAnimationTop.gameObject.SetActive(false);
		this.connectingAnimationTopTextProgress.gameObject.SetActive(false);
		this.connectingAnimationTopTextHint.gameObject.SetActive(false);
		this.settingsPopup.gameObject.SetActive(false);
		this.gamePassSettingsPopup.gameObject.SetActive(false);
		this.socialPopup.gameObject.SetActive(false);
		this.popupRemoveAds.gameObject.SetActive(false);
		this.popupOnlineResources.gameObject.SetActive(false);
		this.popupPromoCodes.gameObject.SetActive(false);
		this.popupGenericNotification.gameObject.SetActive(false);
		this.popupOfferManager.gameObject.SetActive(false);
		this.popupGamePasses.gameObject.SetActive(false);
		if (null != this.popupSkinShop)
		{
			this.popupSkinShop.gameObject.SetActive(false);
		}
		this.avatarCollectionsItem.gameObject.SetActive(false);
		this.delayedFullScreenBlock.SetActive(false);
		this.fullScreenLiveOffer.gameObject.SetActive(false);
	}

	// Token: 0x06006635 RID: 26165 RVA: 0x002F6D1C File Offset: 0x002F4F1C
	public PassesItem FNJLJKLJONA()
	{
		return this.popupGamePasses;
	}

	// Token: 0x06006636 RID: 26166 RVA: 0x002F6D24 File Offset: 0x002F4F24
	public void NDBDMEDBEID()
	{
		this.popupProfileCredoInput.CIIJDOELKBJ();
	}

	// Token: 0x06006637 RID: 26167 RVA: 0x002F6D34 File Offset: 0x002F4F34
	private IEnumerator DLGLKPEJBPC(string EEMPGLHPKJG, string DPJINBCGNGN, string FNEAAEFOOEJ, string MCDCGPAADJA, UnityAction OIOPFHOHKDC, UnityAction KIDLMPIPKHL, float BICHMDEIFKI, int LINDILPPNNK)
	{
		CommonUserInterface.FCKFJPLDKBH fckfjpldkbh = new CommonUserInterface.FCKFJPLDKBH(1);
		fckfjpldkbh.<>4__this = this;
		fckfjpldkbh._textTitle = EEMPGLHPKJG;
		fckfjpldkbh._textBody = DPJINBCGNGN;
		fckfjpldkbh._positiveTextButton = FNEAAEFOOEJ;
		fckfjpldkbh._negativeTextButton = MCDCGPAADJA;
		fckfjpldkbh._positiveButtonListener = OIOPFHOHKDC;
		fckfjpldkbh._negativeButtonListener = KIDLMPIPKHL;
		fckfjpldkbh._delay = BICHMDEIFKI;
		fckfjpldkbh._fontSizeOverride = LINDILPPNNK;
		return fckfjpldkbh;
	}

	// Token: 0x06006638 RID: 26168 RVA: 0x002F6D8C File Offset: 0x002F4F8C
	public GenericPopupManager ShowGenericPopupWithTwoButtonsAndCloseOverrideBlack(string EEMPGLHPKJG, string DPJINBCGNGN, string FNEAAEFOOEJ, string MCDCGPAADJA, UnityAction OIOPFHOHKDC, UnityAction KIDLMPIPKHL, UnityAction NHCNLLNPAJP, DFGILFBGPLN LAPLGLHKEJE, float BICHMDEIFKI = 0f, int LINDILPPNNK = 28)
	{
		FirebaseAnalyticsManager.EHBBFMCILPC.LogScreen(LAPLGLHKEJE.ToString());
		this.delayedFullScreenBlock.SetActive(true);
		base.StartCoroutine(this.KMIAJNOEMPO(EEMPGLHPKJG, DPJINBCGNGN, FNEAAEFOOEJ, MCDCGPAADJA, OIOPFHOHKDC, KIDLMPIPKHL, NHCNLLNPAJP, BICHMDEIFKI, LINDILPPNNK));
		return this.genericPopupTwoButtonsBlack;
	}

	// Token: 0x06006639 RID: 26169 RVA: 0x002F6DE0 File Offset: 0x002F4FE0
	public GenericPopupManager DHAMNNMDHGG(string EEMPGLHPKJG, string DPJINBCGNGN, string DCBPPPGKHEJ, string NENGGAECHKF, string HDOAPHHFMAP, UnityAction JBCIIEJDGJB, UnityAction HDNDIOMNBBJ, UnityAction CHMMLHPJJJL, UnityAction KIDLMPIPKHL, DFGILFBGPLN LAPLGLHKEJE, float BICHMDEIFKI = 0f, int LINDILPPNNK = 28)
	{
		FirebaseAnalyticsManager.DEALKJPEMMH().NFFGLCIFMML(LAPLGLHKEJE.ToString());
		this.delayedFullScreenBlock.SetActive(false);
		base.StartCoroutine(this.LEPMPHJGJDO(EEMPGLHPKJG, DPJINBCGNGN, DCBPPPGKHEJ, NENGGAECHKF, HDOAPHHFMAP, JBCIIEJDGJB, HDNDIOMNBBJ, CHMMLHPJJJL, KIDLMPIPKHL, BICHMDEIFKI, LINDILPPNNK));
		return this.genericPopupThreeButtonsInsideBlack;
	}

	// Token: 0x0600663A RID: 26170 RVA: 0x002F6E36 File Offset: 0x002F5036
	public void CKIEJOAILCF()
	{
		this.popupSketchesInput.MKOGEEDJDOL();
	}

	// Token: 0x0600663C RID: 26172 RVA: 0x002F6E44 File Offset: 0x002F5044
	private IEnumerator LNMGOCFPJEP(string EEMPGLHPKJG, string DPJINBCGNGN, string DCBPPPGKHEJ, string NENGGAECHKF, string HDOAPHHFMAP, string PODLGPEGNLJ, UnityAction JBCIIEJDGJB, UnityAction HDNDIOMNBBJ, UnityAction CHMMLHPJJJL, UnityAction ACOCOEFNJBH, UnityAction KIDLMPIPKHL, float BICHMDEIFKI, int LINDILPPNNK)
	{
		if (BICHMDEIFKI > 0.01f)
		{
			yield return new WaitForSeconds(BICHMDEIFKI);
		}
		yield return new WaitForEndOfFrame();
		if (JBCIIEJDGJB != null)
		{
			this.genericPopupFourButtonsInsideBlack.SetOnClickListenerButtonPositive(JBCIIEJDGJB);
		}
		if (HDNDIOMNBBJ != null)
		{
			this.genericPopupFourButtonsInsideBlack.SetOnClickListenerButtonOptional1(HDNDIOMNBBJ);
		}
		if (CHMMLHPJJJL != null)
		{
			this.genericPopupFourButtonsInsideBlack.SetOnClickListenerButtonOptional2(CHMMLHPJJJL);
		}
		if (ACOCOEFNJBH != null)
		{
			this.genericPopupFourButtonsInsideBlack.SetOnClickListenerButtonOptional3(ACOCOEFNJBH);
		}
		if (KIDLMPIPKHL != null)
		{
			this.genericPopupFourButtonsInsideBlack.SetOnClickListenerButtonNegativeAndClose(KIDLMPIPKHL);
		}
		this.genericPopupTwoButtonsGreen.SetFontSize(LINDILPPNNK);
		this.genericPopupFourButtonsInsideBlack.ShowFourButtons(EEMPGLHPKJG, DPJINBCGNGN, DCBPPPGKHEJ, NENGGAECHKF, HDOAPHHFMAP, PODLGPEGNLJ);
		this.delayedFullScreenBlock.SetActive(false);
		yield break;
	}

	// Token: 0x0600663D RID: 26173 RVA: 0x002F6EC3 File Offset: 0x002F50C3
	public void ShowGamePasses()
	{
		this.popupGamePasses.Show();
	}

	// Token: 0x0600663E RID: 26174 RVA: 0x002F6ED0 File Offset: 0x002F50D0
	public void ShowPopupUsernameInput()
	{
		this.popupUsernameInput.Show();
	}

	// Token: 0x0600663F RID: 26175 RVA: 0x002F6EDD File Offset: 0x002F50DD
	public void LOLEBJBNJCG()
	{
		this.popupSketchesInput.DAAHILOMCGL();
	}

	// Token: 0x06006640 RID: 26176 RVA: 0x002F6D1C File Offset: 0x002F4F1C
	public PassesItem GetGamePasses()
	{
		return this.popupGamePasses;
	}

	// Token: 0x06006641 RID: 26177 RVA: 0x002F6EEA File Offset: 0x002F50EA
	public void ShowPopupGenericNotification(AGNOEOKAFHL ABDCGCFAMBI, string EMGMCANANEJ)
	{
		this.popupGenericNotification.ShowGenericNotification(ABDCGCFAMBI.CHLENHBEPFO, ABDCGCFAMBI.LLFCANBKDEN, ABDCGCFAMBI.FCJJLCPKIHA, ABDCGCFAMBI.PFMBDEPNAJE, EMGMCANANEJ, 28);
	}

	// Token: 0x06006642 RID: 26178 RVA: 0x002F6F12 File Offset: 0x002F5112
	public void MODOOBNJOAP()
	{
		this.mainGroup.SetActive(true);
	}

	// Token: 0x06006643 RID: 26179 RVA: 0x002F6F20 File Offset: 0x002F5120
	public GenericPopupManager IBMNDMIFOCB(string EEMPGLHPKJG, string DPJINBCGNGN, string DCBPPPGKHEJ, string NENGGAECHKF, string HDOAPHHFMAP, string PODLGPEGNLJ, UnityAction JBCIIEJDGJB, UnityAction HDNDIOMNBBJ, UnityAction CHMMLHPJJJL, UnityAction ACOCOEFNJBH, UnityAction KIDLMPIPKHL, DFGILFBGPLN LAPLGLHKEJE, float BICHMDEIFKI = 0f, int LINDILPPNNK = 28)
	{
		FirebaseAnalyticsManager.COKDLDOAACJ().LogScreen(LAPLGLHKEJE.ToString());
		this.delayedFullScreenBlock.SetActive(true);
		base.StartCoroutine(this.HHHGGINAFFB(EEMPGLHPKJG, DPJINBCGNGN, DCBPPPGKHEJ, NENGGAECHKF, HDOAPHHFMAP, PODLGPEGNLJ, JBCIIEJDGJB, HDNDIOMNBBJ, CHMMLHPJJJL, ACOCOEFNJBH, KIDLMPIPKHL, BICHMDEIFKI, LINDILPPNNK));
		return this.genericPopupFourButtonsInsideBlack;
	}

	// Token: 0x06006644 RID: 26180 RVA: 0x002F6F7A File Offset: 0x002F517A
	public void ShowSkinShop(int PLKMJJIIJNO, List<string> MKLBDPIIBNE)
	{
		if (null != this.popupSkinShop)
		{
			this.popupSkinShop.Show(PLKMJJIIJNO, MKLBDPIIBNE);
		}
	}

	// Token: 0x06006645 RID: 26181 RVA: 0x002F6F98 File Offset: 0x002F5198
	private IEnumerator JCELKMKAANH(string EEMPGLHPKJG, string DPJINBCGNGN, string CAGMDHNGAEH, UnityAction OIOPFHOHKDC, UnityAction KIDLMPIPKHL, float BICHMDEIFKI, int LINDILPPNNK)
	{
		CommonUserInterface.NODPLKPOHGN nodplkpohgn = new CommonUserInterface.NODPLKPOHGN(1);
		nodplkpohgn.<>4__this = this;
		nodplkpohgn._textTitle = EEMPGLHPKJG;
		nodplkpohgn._textBody = DPJINBCGNGN;
		nodplkpohgn._textButton = CAGMDHNGAEH;
		nodplkpohgn._positiveButtonListener = OIOPFHOHKDC;
		nodplkpohgn._negativeButtonListener = KIDLMPIPKHL;
		nodplkpohgn._delay = BICHMDEIFKI;
		nodplkpohgn._fontSizeOverride = LINDILPPNNK;
		return nodplkpohgn;
	}

	// Token: 0x06006646 RID: 26182 RVA: 0x002F6FE8 File Offset: 0x002F51E8
	public GenericPopupManager CPAFJIOCIAJ(string EEMPGLHPKJG, string DPJINBCGNGN, string FNEAAEFOOEJ, string MCDCGPAADJA, UnityAction OIOPFHOHKDC, UnityAction KIDLMPIPKHL, DFGILFBGPLN LAPLGLHKEJE, float BICHMDEIFKI = 0f, int LINDILPPNNK = 28)
	{
		FirebaseAnalyticsManager.DEALKJPEMMH().JCBJENBEBCL(LAPLGLHKEJE.ToString());
		this.delayedFullScreenBlock.SetActive(false);
		base.StartCoroutine(this.DPPDBFOAPJO(EEMPGLHPKJG, DPJINBCGNGN, FNEAAEFOOEJ, MCDCGPAADJA, OIOPFHOHKDC, KIDLMPIPKHL, BICHMDEIFKI, LINDILPPNNK));
		return this.genericPopupTwoButtonsBlack;
	}

	// Token: 0x06006647 RID: 26183 RVA: 0x002F7038 File Offset: 0x002F5238
	private IEnumerator DBPGCFMONBO(string EEMPGLHPKJG, string DPJINBCGNGN, float BICHMDEIFKI, int LINDILPPNNK)
	{
		if (BICHMDEIFKI > 0.01f)
		{
			yield return new WaitForSeconds(BICHMDEIFKI);
		}
		yield return new WaitForEndOfFrame();
		this.genericPopupNoButtons.SetFontSize(LINDILPPNNK);
		this.genericPopupNoButtons.ShowNoButtons(EEMPGLHPKJG, DPJINBCGNGN);
		this.delayedFullScreenBlock.SetActive(false);
		yield break;
	}

	// Token: 0x06006648 RID: 26184 RVA: 0x002F7064 File Offset: 0x002F5264
	public void ShowPopupUpdateWelcome()
	{
		this.popupGenericNotification.ShowUpdateWelcomeNotification(AssetsManager.EHBBFMCILPC.lobbyDataAsset, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("seewhatsnew"), "OnPopupUpdateWelcomeWhatsMoreClick", 25);
	}

	// Token: 0x06006649 RID: 26185 RVA: 0x002F7094 File Offset: 0x002F5294
	public GenericPopupManager CEGLPJNLBHL(string EEMPGLHPKJG, string DPJINBCGNGN, string CAGMDHNGAEH, UnityAction OIOPFHOHKDC, UnityAction KIDLMPIPKHL, DFGILFBGPLN LAPLGLHKEJE, float BICHMDEIFKI = 0f, int LINDILPPNNK = 28)
	{
		FirebaseAnalyticsManager.ANCEKPONIFI().KDHCDAEGNDN(LAPLGLHKEJE.ToString());
		this.delayedFullScreenBlock.SetActive(false);
		base.StartCoroutine(this.JCELKMKAANH(EEMPGLHPKJG, DPJINBCGNGN, CAGMDHNGAEH, OIOPFHOHKDC, KIDLMPIPKHL, BICHMDEIFKI, LINDILPPNNK));
		return this.genericPopup;
	}

	// Token: 0x0600664A RID: 26186 RVA: 0x002F70E2 File Offset: 0x002F52E2
	public void HideConnectingAnimationTop()
	{
		this.GFAMDMIEPFG = true;
		this.connectingAnimationTop.SetDirection(true);
		this.connectingAnimationTop.PlayAnimation(true);
	}

	// Token: 0x0600664B RID: 26187 RVA: 0x002F7104 File Offset: 0x002F5304
	public GenericPopupManager ShowGenericPopupWithFourButtonsInsideBlack(string EEMPGLHPKJG, string DPJINBCGNGN, string DCBPPPGKHEJ, string NENGGAECHKF, string HDOAPHHFMAP, string PODLGPEGNLJ, UnityAction JBCIIEJDGJB, UnityAction HDNDIOMNBBJ, UnityAction CHMMLHPJJJL, UnityAction ACOCOEFNJBH, UnityAction KIDLMPIPKHL, DFGILFBGPLN LAPLGLHKEJE, float BICHMDEIFKI = 0f, int LINDILPPNNK = 28)
	{
		FirebaseAnalyticsManager.EHBBFMCILPC.LogScreen(LAPLGLHKEJE.ToString());
		this.delayedFullScreenBlock.SetActive(true);
		base.StartCoroutine(this.PKHBGENBOOL(EEMPGLHPKJG, DPJINBCGNGN, DCBPPPGKHEJ, NENGGAECHKF, HDOAPHHFMAP, PODLGPEGNLJ, JBCIIEJDGJB, HDNDIOMNBBJ, CHMMLHPJJJL, ACOCOEFNJBH, KIDLMPIPKHL, BICHMDEIFKI, LINDILPPNNK));
		return this.genericPopupFourButtonsInsideBlack;
	}

	// Token: 0x0600664C RID: 26188 RVA: 0x002F715E File Offset: 0x002F535E
	public PopupProfileUIDInput GetPopupProfileUIDInput()
	{
		return this.popupProfileUIDInput;
	}

	// Token: 0x0600664D RID: 26189 RVA: 0x002F7168 File Offset: 0x002F5368
	public GenericPopupManager DAAMGCMILMB(string EEMPGLHPKJG, string DPJINBCGNGN, string DCBPPPGKHEJ, string NENGGAECHKF, string HDOAPHHFMAP, string PODLGPEGNLJ, UnityAction JBCIIEJDGJB, UnityAction HDNDIOMNBBJ, UnityAction CHMMLHPJJJL, UnityAction ACOCOEFNJBH, UnityAction KIDLMPIPKHL, DFGILFBGPLN LAPLGLHKEJE, float BICHMDEIFKI = 0f, int LINDILPPNNK = 28)
	{
		FirebaseAnalyticsManager.JMDJBFAEHBM().NFFGLCIFMML(LAPLGLHKEJE.ToString());
		this.delayedFullScreenBlock.SetActive(true);
		base.StartCoroutine(this.PKHBGENBOOL(EEMPGLHPKJG, DPJINBCGNGN, DCBPPPGKHEJ, NENGGAECHKF, HDOAPHHFMAP, PODLGPEGNLJ, JBCIIEJDGJB, HDNDIOMNBBJ, CHMMLHPJJJL, ACOCOEFNJBH, KIDLMPIPKHL, BICHMDEIFKI, LINDILPPNNK));
		return this.genericPopupFourButtonsInsideBlack;
	}

	// Token: 0x0600664E RID: 26190 RVA: 0x002F71C2 File Offset: 0x002F53C2
	public void ShowPopupAvatarCollectionsInput(string MLGOOHIENNO)
	{
		this.avatarCollectionsInput.Show(MLGOOHIENNO);
	}

	// Token: 0x0600664F RID: 26191 RVA: 0x002F71D0 File Offset: 0x002F53D0
	public void HCLKABEJBHI(string IHCGMFBCMOO, ProducThumbnailGraphics DHAGPIAMELI)
	{
		this.popupOfferManager.LIKHHKBBFBG(IHCGMFBCMOO, DHAGPIAMELI);
	}

	// Token: 0x06006650 RID: 26192 RVA: 0x002F71E0 File Offset: 0x002F53E0
	public GenericPopupManager ShowGenericPopupOneOverrideWithCloseOverride(string EEMPGLHPKJG, string DPJINBCGNGN, string CAGMDHNGAEH, UnityAction OIOPFHOHKDC, UnityAction NHCNLLNPAJP, DFGILFBGPLN LAPLGLHKEJE, float BICHMDEIFKI = 0f, int LINDILPPNNK = 28)
	{
		FirebaseAnalyticsManager.EHBBFMCILPC.LogScreen(LAPLGLHKEJE.ToString());
		this.delayedFullScreenBlock.SetActive(true);
		base.StartCoroutine(this.NKBCDHKKBGL(EEMPGLHPKJG, DPJINBCGNGN, CAGMDHNGAEH, OIOPFHOHKDC, NHCNLLNPAJP, BICHMDEIFKI, LINDILPPNNK));
		return this.genericPopup;
	}

	// Token: 0x06006651 RID: 26193 RVA: 0x002F722E File Offset: 0x002F542E
	private void OnDestroy()
	{
		if (CommonUserInterface.IKLAPGJDMNA == this)
		{
			CommonUserInterface.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x06006652 RID: 26194 RVA: 0x002F7244 File Offset: 0x002F5444
	public GenericPopupManager ShowGenericPopupWithTwoButtons(string EEMPGLHPKJG, string DPJINBCGNGN, string FNEAAEFOOEJ, string MCDCGPAADJA, UnityAction OIOPFHOHKDC, UnityAction KIDLMPIPKHL, DFGILFBGPLN LAPLGLHKEJE, float BICHMDEIFKI = 0f, int LINDILPPNNK = 28)
	{
		FirebaseAnalyticsManager.EHBBFMCILPC.LogScreen(LAPLGLHKEJE.ToString());
		this.delayedFullScreenBlock.SetActive(true);
		base.StartCoroutine(this.DMJFLJBNBED(EEMPGLHPKJG, DPJINBCGNGN, FNEAAEFOOEJ, MCDCGPAADJA, OIOPFHOHKDC, KIDLMPIPKHL, BICHMDEIFKI, LINDILPPNNK));
		return this.genericPopupTwoButtons;
	}

	// Token: 0x06006653 RID: 26195 RVA: 0x002F7294 File Offset: 0x002F5494
	public void BJLFAHKFHCM()
	{
		this.popupSaveSlotInput.MBKCINPJKML();
	}

	// Token: 0x06006654 RID: 26196 RVA: 0x002F72A1 File Offset: 0x002F54A1
	public void ShowPopupOnlineResources(string IDEKNBNKKJF, int CDPOGMJFOGB = -1)
	{
		this.popupOnlineResources.Show(IDEKNBNKKJF, CDPOGMJFOGB);
	}

	// Token: 0x06006655 RID: 26197 RVA: 0x002F72B0 File Offset: 0x002F54B0
	public void HideCutsceneViewManager()
	{
		AssetsManager.EHBBFMCILPC.cutsceneViewManager.Hide(false);
	}

	// Token: 0x06006656 RID: 26198 RVA: 0x002F72C2 File Offset: 0x002F54C2
	public void IMGGNMBFKHO()
	{
		this.restartFade.SetActive(false);
	}

	// Token: 0x06006657 RID: 26199 RVA: 0x002F72D0 File Offset: 0x002F54D0
	public void ShowGamePassSettings()
	{
		this.gamePassSettingsPopup.Show();
	}

	// Token: 0x06006658 RID: 26200 RVA: 0x002F72DD File Offset: 0x002F54DD
	public void ShowSkinShop(int PLKMJJIIJNO)
	{
		if (null != this.popupSkinShop)
		{
			this.popupSkinShop.Show(PLKMJJIIJNO);
		}
	}

	// Token: 0x06006659 RID: 26201 RVA: 0x002F72F9 File Offset: 0x002F54F9
	private IEnumerator PCFCLBMKDAC(string EEMPGLHPKJG, string DPJINBCGNGN, string CAGMDHNGAEH, UnityAction OIOPFHOHKDC, float BICHMDEIFKI, int LINDILPPNNK)
	{
		if (BICHMDEIFKI > 0.01f)
		{
			yield return new WaitForSeconds(BICHMDEIFKI);
		}
		yield return new WaitForEndOfFrame();
		if (OIOPFHOHKDC != null)
		{
			this.genericPopup.SetOnClickListenerButtonPositive(OIOPFHOHKDC);
		}
		this.genericPopup.SetFontSize(LINDILPPNNK);
		this.genericPopup.ShowOneButton(EEMPGLHPKJG, DPJINBCGNGN, CAGMDHNGAEH);
		this.delayedFullScreenBlock.SetActive(false);
		yield break;
	}

	// Token: 0x0600665A RID: 26202 RVA: 0x002F7335 File Offset: 0x002F5535
	public void ShowPopupProfileUIDInput(int CPKFEMAOOBH)
	{
		this.popupProfileUIDInput.Show(CPKFEMAOOBH);
	}

	// Token: 0x0600665B RID: 26203 RVA: 0x002F7343 File Offset: 0x002F5543
	public static bool FFJPNCFBLLH()
	{
		return CommonUserInterface.IKLAPGJDMNA;
	}

	// Token: 0x0600665C RID: 26204 RVA: 0x002F7354 File Offset: 0x002F5554
	public void ShowPopupSketchesInput()
	{
		this.popupSketchesInput.Show();
	}

	// Token: 0x0600665D RID: 26205 RVA: 0x002F7364 File Offset: 0x002F5564
	private IEnumerator LEPMPHJGJDO(string EEMPGLHPKJG, string DPJINBCGNGN, string DCBPPPGKHEJ, string NENGGAECHKF, string HDOAPHHFMAP, UnityAction JBCIIEJDGJB, UnityAction HDNDIOMNBBJ, UnityAction CHMMLHPJJJL, UnityAction KIDLMPIPKHL, float BICHMDEIFKI, int LINDILPPNNK)
	{
		CommonUserInterface.NPFMKLGCBLA npfmklgcbla = new CommonUserInterface.NPFMKLGCBLA(1);
		npfmklgcbla.<>4__this = this;
		npfmklgcbla._textTitle = EEMPGLHPKJG;
		npfmklgcbla._textBody = DPJINBCGNGN;
		npfmklgcbla._button1Text = DCBPPPGKHEJ;
		npfmklgcbla._button2Text = NENGGAECHKF;
		npfmklgcbla._button3Text = HDOAPHHFMAP;
		npfmklgcbla._button1Listener = JBCIIEJDGJB;
		npfmklgcbla._button2Listener = HDNDIOMNBBJ;
		npfmklgcbla._button3Listener = CHMMLHPJJJL;
		npfmklgcbla._negativeButtonListener = KIDLMPIPKHL;
		npfmklgcbla._delay = BICHMDEIFKI;
		npfmklgcbla._fontSizeOverride = LINDILPPNNK;
		return npfmklgcbla;
	}

	// Token: 0x0600665E RID: 26206 RVA: 0x002F73D4 File Offset: 0x002F55D4
	private IEnumerator DJEGCJJFOHL(string EEMPGLHPKJG, string DPJINBCGNGN, string FNEAAEFOOEJ, string MCDCGPAADJA, UnityAction OIOPFHOHKDC, UnityAction KIDLMPIPKHL, float BICHMDEIFKI, int LINDILPPNNK)
	{
		CommonUserInterface.FCKFJPLDKBH fckfjpldkbh = new CommonUserInterface.FCKFJPLDKBH(1);
		fckfjpldkbh.<>4__this = this;
		fckfjpldkbh._textTitle = EEMPGLHPKJG;
		fckfjpldkbh._textBody = DPJINBCGNGN;
		fckfjpldkbh._positiveTextButton = FNEAAEFOOEJ;
		fckfjpldkbh._negativeTextButton = MCDCGPAADJA;
		fckfjpldkbh._positiveButtonListener = OIOPFHOHKDC;
		fckfjpldkbh._negativeButtonListener = KIDLMPIPKHL;
		fckfjpldkbh._delay = BICHMDEIFKI;
		fckfjpldkbh._fontSizeOverride = LINDILPPNNK;
		return fckfjpldkbh;
	}

	// Token: 0x0600665F RID: 26207 RVA: 0x002F742B File Offset: 0x002F562B
	public FullscreenLiveOfferManager FIPDOHJMNHK()
	{
		return this.fullScreenLiveOffer;
	}

	// Token: 0x06006660 RID: 26208 RVA: 0x002F6937 File Offset: 0x002F4B37
	public AvatarCollectionsItem GNBNHFFLIPE()
	{
		return this.avatarCollectionsItem;
	}

	// Token: 0x06006661 RID: 26209 RVA: 0x002F7433 File Offset: 0x002F5633
	public void DPJBIGPDLMB(string IDEKNBNKKJF, int CDPOGMJFOGB = -1)
	{
		this.popupOnlineResources.FJAEAFOLLII(IDEKNBNKKJF, CDPOGMJFOGB);
	}

	// Token: 0x06006662 RID: 26210 RVA: 0x002F72F9 File Offset: 0x002F54F9
	private IEnumerator BBLMAKPOKBA(string EEMPGLHPKJG, string DPJINBCGNGN, string CAGMDHNGAEH, UnityAction OIOPFHOHKDC, float BICHMDEIFKI, int LINDILPPNNK)
	{
		if (BICHMDEIFKI > 0.01f)
		{
			yield return new WaitForSeconds(BICHMDEIFKI);
		}
		yield return new WaitForEndOfFrame();
		if (OIOPFHOHKDC != null)
		{
			this.genericPopup.SetOnClickListenerButtonPositive(OIOPFHOHKDC);
		}
		this.genericPopup.SetFontSize(LINDILPPNNK);
		this.genericPopup.ShowOneButton(EEMPGLHPKJG, DPJINBCGNGN, CAGMDHNGAEH);
		this.delayedFullScreenBlock.SetActive(false);
		yield break;
	}

	// Token: 0x06006663 RID: 26211 RVA: 0x002F7444 File Offset: 0x002F5644
	public GenericPopupManager EHKIPAGEOMI(string EEMPGLHPKJG, string DPJINBCGNGN, string DCBPPPGKHEJ, string NENGGAECHKF, string HDOAPHHFMAP, string PODLGPEGNLJ, UnityAction JBCIIEJDGJB, UnityAction HDNDIOMNBBJ, UnityAction CHMMLHPJJJL, UnityAction ACOCOEFNJBH, UnityAction KIDLMPIPKHL, DFGILFBGPLN LAPLGLHKEJE, float BICHMDEIFKI = 0f, int LINDILPPNNK = 28)
	{
		FirebaseAnalyticsManager.DEALKJPEMMH().NFFGLCIFMML(LAPLGLHKEJE.ToString());
		this.delayedFullScreenBlock.SetActive(false);
		base.StartCoroutine(this.LPCJNIKDHDG(EEMPGLHPKJG, DPJINBCGNGN, DCBPPPGKHEJ, NENGGAECHKF, HDOAPHHFMAP, PODLGPEGNLJ, JBCIIEJDGJB, HDNDIOMNBBJ, CHMMLHPJJJL, ACOCOEFNJBH, KIDLMPIPKHL, BICHMDEIFKI, LINDILPPNNK));
		return this.genericPopupFourButtonsInside;
	}

	// Token: 0x06006664 RID: 26212 RVA: 0x002F6861 File Offset: 0x002F4A61
	private IEnumerator GKHBMBLKANO(string EEMPGLHPKJG, string DPJINBCGNGN, float BICHMDEIFKI, int LINDILPPNNK)
	{
		CommonUserInterface.EAJDDIDFNEJ eajddidfnej = new CommonUserInterface.EAJDDIDFNEJ(1);
		eajddidfnej.<>4__this = this;
		eajddidfnej._textTitle = EEMPGLHPKJG;
		eajddidfnej._textBody = DPJINBCGNGN;
		eajddidfnej._delay = BICHMDEIFKI;
		eajddidfnej._fontSizeOverride = LINDILPPNNK;
		return eajddidfnej;
	}

	// Token: 0x06006665 RID: 26213 RVA: 0x002F72DD File Offset: 0x002F54DD
	public void ILGILKNEBDM(int PLKMJJIIJNO)
	{
		if (null != this.popupSkinShop)
		{
			this.popupSkinShop.Show(PLKMJJIIJNO);
		}
	}

	// Token: 0x06006666 RID: 26214 RVA: 0x002F74A0 File Offset: 0x002F56A0
	private IEnumerator DMJFLJBNBED(string EEMPGLHPKJG, string DPJINBCGNGN, string FNEAAEFOOEJ, string MCDCGPAADJA, UnityAction OIOPFHOHKDC, UnityAction KIDLMPIPKHL, float BICHMDEIFKI, int LINDILPPNNK)
	{
		if (BICHMDEIFKI > 0.01f)
		{
			yield return new WaitForSeconds(BICHMDEIFKI);
		}
		yield return new WaitForEndOfFrame();
		if (OIOPFHOHKDC != null)
		{
			this.genericPopupTwoButtons.SetOnClickListenerButtonPositive(OIOPFHOHKDC);
		}
		if (KIDLMPIPKHL != null)
		{
			this.genericPopupTwoButtons.SetOnClickListenerButtonNegativeAndClose(KIDLMPIPKHL);
		}
		this.genericPopupTwoButtons.SetFontSize(LINDILPPNNK);
		this.genericPopupTwoButtons.ShowTwoButtons(EEMPGLHPKJG, DPJINBCGNGN, FNEAAEFOOEJ, MCDCGPAADJA);
		this.delayedFullScreenBlock.SetActive(false);
		yield break;
	}

	// Token: 0x06006667 RID: 26215 RVA: 0x002F74F7 File Offset: 0x002F56F7
	public void ShowPopupProfileLoveInput()
	{
		this.popupProfileLoveInput.Show();
	}

	// Token: 0x06006668 RID: 26216 RVA: 0x002F7504 File Offset: 0x002F5704
	public GenericPopupManager ShowGenericPopupWithTwoButtonsAndCloseOverride(string EEMPGLHPKJG, string DPJINBCGNGN, string FNEAAEFOOEJ, string MCDCGPAADJA, UnityAction OIOPFHOHKDC, UnityAction KIDLMPIPKHL, UnityAction NHCNLLNPAJP, DFGILFBGPLN LAPLGLHKEJE, float BICHMDEIFKI = 0f, int LINDILPPNNK = 28)
	{
		FirebaseAnalyticsManager.EHBBFMCILPC.LogScreen(LAPLGLHKEJE.ToString());
		this.delayedFullScreenBlock.SetActive(true);
		base.StartCoroutine(this.CEFLPOFLJOG(EEMPGLHPKJG, DPJINBCGNGN, FNEAAEFOOEJ, MCDCGPAADJA, OIOPFHOHKDC, KIDLMPIPKHL, NHCNLLNPAJP, BICHMDEIFKI, LINDILPPNNK));
		return this.genericPopupTwoButtons;
	}

	// Token: 0x06006669 RID: 26217 RVA: 0x002F7558 File Offset: 0x002F5758
	private IEnumerator AEMOOLJCPHM(string EEMPGLHPKJG, string DPJINBCGNGN, string FNEAAEFOOEJ, string MCDCGPAADJA, UnityAction OIOPFHOHKDC, UnityAction KIDLMPIPKHL, UnityAction NHCNLLNPAJP, float BICHMDEIFKI, int LINDILPPNNK)
	{
		CommonUserInterface.IPCMHBIPOFG ipcmhbipofg = new CommonUserInterface.IPCMHBIPOFG(1);
		ipcmhbipofg.<>4__this = this;
		ipcmhbipofg._textTitle = EEMPGLHPKJG;
		ipcmhbipofg._textBody = DPJINBCGNGN;
		ipcmhbipofg._positiveTextButton = FNEAAEFOOEJ;
		ipcmhbipofg._negativeTextButton = MCDCGPAADJA;
		ipcmhbipofg._positiveButtonListener = OIOPFHOHKDC;
		ipcmhbipofg._negativeButtonListener = KIDLMPIPKHL;
		ipcmhbipofg._closeButtonListener = NHCNLLNPAJP;
		ipcmhbipofg._delay = BICHMDEIFKI;
		ipcmhbipofg._fontSizeOverride = LINDILPPNNK;
		return ipcmhbipofg;
	}

	// Token: 0x0600666A RID: 26218 RVA: 0x002F75B8 File Offset: 0x002F57B8
	public void DCFCCNKGEJD()
	{
		this.mainGroup.SetActive(false);
		this.fader.JDPKNGACIJL();
		this.SetStandardFaderParams();
		this.fullScreenBlock.SetActive(true);
		this.genericPopup.gameObject.SetActive(true);
		this.genericPopupNoButtons.gameObject.SetActive(true);
		this.genericPopupTwoButtons.gameObject.SetActive(false);
		this.genericPopupTwoButtonsBlack.gameObject.SetActive(false);
		this.genericPopupTwoButtonsGreen.gameObject.SetActive(false);
		this.genericPopupThreeButtonsInside.gameObject.SetActive(true);
		this.genericPopupThreeButtonsInsideBlack.gameObject.SetActive(false);
		this.genericPopupFourButtonsInside.gameObject.SetActive(false);
		this.genericPopupFourButtonsInsideBlack.gameObject.SetActive(false);
		this.connectingAnimation.gameObject.SetActive(false);
		this.connectingAnimationShadow.gameObject.SetActive(true);
		this.connectingAnimationTextProgress.gameObject.SetActive(true);
		this.connectingAnimationTextHint.gameObject.SetActive(true);
		this.connectingAnimationTop.gameObject.SetActive(false);
		this.connectingAnimationTopTextProgress.gameObject.SetActive(false);
		this.connectingAnimationTopTextHint.gameObject.SetActive(false);
		this.settingsPopup.gameObject.SetActive(true);
		this.gamePassSettingsPopup.gameObject.SetActive(false);
		this.socialPopup.gameObject.SetActive(true);
		this.popupRemoveAds.gameObject.SetActive(false);
		this.popupOnlineResources.gameObject.SetActive(false);
		this.popupPromoCodes.gameObject.SetActive(false);
		this.popupGenericNotification.gameObject.SetActive(true);
		this.popupOfferManager.gameObject.SetActive(true);
		this.popupGamePasses.gameObject.SetActive(true);
		if (null != this.popupSkinShop)
		{
			this.popupSkinShop.gameObject.SetActive(true);
		}
		this.avatarCollectionsItem.gameObject.SetActive(true);
		this.delayedFullScreenBlock.SetActive(true);
		this.fullScreenLiveOffer.gameObject.SetActive(true);
	}

	// Token: 0x0600666B RID: 26219 RVA: 0x002F77E4 File Offset: 0x002F59E4
	public GenericPopupManager JOHIHCPEBPL(string EEMPGLHPKJG, string DPJINBCGNGN, string DCBPPPGKHEJ, string NENGGAECHKF, string HDOAPHHFMAP, string PODLGPEGNLJ, UnityAction JBCIIEJDGJB, UnityAction HDNDIOMNBBJ, UnityAction CHMMLHPJJJL, UnityAction ACOCOEFNJBH, UnityAction KIDLMPIPKHL, DFGILFBGPLN LAPLGLHKEJE, float BICHMDEIFKI = 0f, int LINDILPPNNK = 28)
	{
		FirebaseAnalyticsManager.JMDJBFAEHBM().LogScreen(LAPLGLHKEJE.ToString());
		this.delayedFullScreenBlock.SetActive(false);
		base.StartCoroutine(this.LPCJNIKDHDG(EEMPGLHPKJG, DPJINBCGNGN, DCBPPPGKHEJ, NENGGAECHKF, HDOAPHHFMAP, PODLGPEGNLJ, JBCIIEJDGJB, HDNDIOMNBBJ, CHMMLHPJJJL, ACOCOEFNJBH, KIDLMPIPKHL, BICHMDEIFKI, LINDILPPNNK));
		return this.genericPopupFourButtonsInside;
	}

	// Token: 0x0600666C RID: 26220 RVA: 0x002F7840 File Offset: 0x002F5A40
	public GenericPopupManager ShowGenericPopupOneOverride(string EEMPGLHPKJG, string DPJINBCGNGN, string CAGMDHNGAEH, UnityAction OIOPFHOHKDC, DFGILFBGPLN LAPLGLHKEJE, float BICHMDEIFKI = 0f, int LINDILPPNNK = 28)
	{
		FirebaseAnalyticsManager.EHBBFMCILPC.LogScreen(LAPLGLHKEJE.ToString());
		this.delayedFullScreenBlock.SetActive(true);
		base.StartCoroutine(this.PCFCLBMKDAC(EEMPGLHPKJG, DPJINBCGNGN, CAGMDHNGAEH, OIOPFHOHKDC, BICHMDEIFKI, LINDILPPNNK));
		return this.genericPopup;
	}

	// Token: 0x0600666D RID: 26221 RVA: 0x002F788C File Offset: 0x002F5A8C
	public void DJBLEEEEGOL()
	{
		this.socialPopup.Show();
	}

	// Token: 0x0600666E RID: 26222 RVA: 0x002F7899 File Offset: 0x002F5A99
	public void Disable()
	{
		this.mainGroup.SetActive(false);
	}

	// Token: 0x0600666F RID: 26223 RVA: 0x002F78A7 File Offset: 0x002F5AA7
	public void ShowPopupSaveSlotInput()
	{
		this.popupSaveSlotInput.Show();
	}

	// Token: 0x06006670 RID: 26224 RVA: 0x00003E52 File Offset: 0x00002052
	private void EJCFKOHELJO()
	{
	}

	// Token: 0x06006671 RID: 26225 RVA: 0x002F78B4 File Offset: 0x002F5AB4
	public void ShowConnectingAnimationWithProgress(byte IGLCKLCKDKO = 0)
	{
		this.connectingAnimationTextProgress.gameObject.SetActive(true);
		this.connectingAnimationTextProgress.SetText("", true);
		this.connectingAnimationTextHint.gameObject.SetActive(false);
		this.connectingAnimationFade.color = new Color32(0, 0, 0, IGLCKLCKDKO);
		this.connectingAnimationShadow.gameObject.SetActive(false);
		bool activeSelf = this.connectingAnimation.gameObject.activeSelf;
		this.connectingAnimation.gameObject.SetActive(true);
		if (!activeSelf || this.DFEEFCBHMLF)
		{
			this.connectingAnimation.SetDirection(false);
			this.connectingAnimation.PlayAnimation(false);
		}
		this.DFEEFCBHMLF = false;
	}

	// Token: 0x06006672 RID: 26226 RVA: 0x002F7968 File Offset: 0x002F5B68
	private IEnumerator PKCMJBOCADP(string EEMPGLHPKJG, string DPJINBCGNGN, string FNEAAEFOOEJ, string MCDCGPAADJA, UnityAction OIOPFHOHKDC, UnityAction KIDLMPIPKHL, UnityAction NHCNLLNPAJP, float BICHMDEIFKI, int LINDILPPNNK)
	{
		if (BICHMDEIFKI > 0.01f)
		{
			yield return new WaitForSeconds(BICHMDEIFKI);
		}
		yield return new WaitForEndOfFrame();
		if (OIOPFHOHKDC != null)
		{
			this.genericPopupTwoButtonsGreen.SetOnClickListenerButtonPositive(OIOPFHOHKDC);
		}
		if (KIDLMPIPKHL != null)
		{
			this.genericPopupTwoButtonsGreen.SetOnClickListenerButtonNegative(KIDLMPIPKHL);
		}
		if (NHCNLLNPAJP != null)
		{
			this.genericPopupTwoButtonsGreen.SetOnClickListenerButtonClose(NHCNLLNPAJP);
		}
		this.genericPopupTwoButtonsGreen.SetFontSize(LINDILPPNNK);
		this.genericPopupTwoButtonsGreen.ShowTwoButtons(EEMPGLHPKJG, DPJINBCGNGN, FNEAAEFOOEJ, MCDCGPAADJA);
		this.delayedFullScreenBlock.SetActive(false);
		yield break;
	}

	// Token: 0x06006673 RID: 26227 RVA: 0x002F6937 File Offset: 0x002F4B37
	public AvatarCollectionsItem JDJPBCGKBOO()
	{
		return this.avatarCollectionsItem;
	}

	// Token: 0x06006674 RID: 26228 RVA: 0x002F79C8 File Offset: 0x002F5BC8
	public GenericPopupManager ShowGenericPopupWithTwoButtonsBlack(string EEMPGLHPKJG, string DPJINBCGNGN, string FNEAAEFOOEJ, string MCDCGPAADJA, UnityAction OIOPFHOHKDC, UnityAction KIDLMPIPKHL, DFGILFBGPLN LAPLGLHKEJE, float BICHMDEIFKI = 0f, int LINDILPPNNK = 28)
	{
		FirebaseAnalyticsManager.EHBBFMCILPC.LogScreen(LAPLGLHKEJE.ToString());
		this.delayedFullScreenBlock.SetActive(true);
		base.StartCoroutine(this.DPPDBFOAPJO(EEMPGLHPKJG, DPJINBCGNGN, FNEAAEFOOEJ, MCDCGPAADJA, OIOPFHOHKDC, KIDLMPIPKHL, BICHMDEIFKI, LINDILPPNNK));
		return this.genericPopupTwoButtonsBlack;
	}

	// Token: 0x06006675 RID: 26229 RVA: 0x002F7A18 File Offset: 0x002F5C18
	public void UpdateConnectionAnimationProgress(string DIMBCOBNMAM)
	{
		if (this.connectingAnimation.gameObject.activeSelf)
		{
			this.connectingAnimationTextProgress.SetText(DIMBCOBNMAM, true);
		}
	}

	// Token: 0x06006676 RID: 26230 RVA: 0x002F7A39 File Offset: 0x002F5C39
	public void NOHJDJIAJMH()
	{
		this.restartFade.SetActive(true);
	}

	// Token: 0x06006677 RID: 26231 RVA: 0x002F7A47 File Offset: 0x002F5C47
	public void ShowPopupPromoCodes()
	{
		this.popupPromoCodes.Show();
	}

	// Token: 0x06006678 RID: 26232 RVA: 0x002F7A54 File Offset: 0x002F5C54
	private IEnumerator LPCJNIKDHDG(string EEMPGLHPKJG, string DPJINBCGNGN, string DCBPPPGKHEJ, string NENGGAECHKF, string HDOAPHHFMAP, string PODLGPEGNLJ, UnityAction JBCIIEJDGJB, UnityAction HDNDIOMNBBJ, UnityAction CHMMLHPJJJL, UnityAction ACOCOEFNJBH, UnityAction KIDLMPIPKHL, float BICHMDEIFKI, int LINDILPPNNK)
	{
		if (BICHMDEIFKI > 0.01f)
		{
			yield return new WaitForSeconds(BICHMDEIFKI);
		}
		yield return new WaitForEndOfFrame();
		if (JBCIIEJDGJB != null)
		{
			this.genericPopupFourButtonsInside.SetOnClickListenerButtonPositive(JBCIIEJDGJB);
		}
		if (HDNDIOMNBBJ != null)
		{
			this.genericPopupFourButtonsInside.SetOnClickListenerButtonOptional1(HDNDIOMNBBJ);
		}
		if (CHMMLHPJJJL != null)
		{
			this.genericPopupFourButtonsInside.SetOnClickListenerButtonOptional2(CHMMLHPJJJL);
		}
		if (ACOCOEFNJBH != null)
		{
			this.genericPopupFourButtonsInside.SetOnClickListenerButtonOptional3(ACOCOEFNJBH);
		}
		if (KIDLMPIPKHL != null)
		{
			this.genericPopupFourButtonsInside.SetOnClickListenerButtonNegativeAndClose(KIDLMPIPKHL);
		}
		this.genericPopupTwoButtonsGreen.SetFontSize(LINDILPPNNK);
		this.genericPopupFourButtonsInside.ShowFourButtons(EEMPGLHPKJG, DPJINBCGNGN, DCBPPPGKHEJ, NENGGAECHKF, HDOAPHHFMAP, PODLGPEGNLJ);
		this.delayedFullScreenBlock.SetActive(false);
		yield break;
	}

	// Token: 0x06006679 RID: 26233 RVA: 0x002F7AD4 File Offset: 0x002F5CD4
	public void ShowConnectingAnimation(byte IGLCKLCKDKO = 0)
	{
		this.connectingAnimationTextProgress.gameObject.SetActive(false);
		this.connectingAnimationTextHint.gameObject.SetActive(false);
		this.connectingAnimationFade.color = new Color32(0, 0, 0, IGLCKLCKDKO);
		this.connectingAnimationShadow.gameObject.SetActive(false);
		bool activeSelf = this.connectingAnimation.gameObject.activeSelf;
		this.connectingAnimation.gameObject.SetActive(true);
		if (!activeSelf || this.DFEEFCBHMLF)
		{
			this.connectingAnimation.SetDirection(false);
			this.connectingAnimation.PlayAnimation(false);
		}
		this.DFEEFCBHMLF = false;
	}

	// Token: 0x0600667A RID: 26234 RVA: 0x002F742B File Offset: 0x002F562B
	public FullscreenLiveOfferManager AOLMLLCPJEG()
	{
		return this.fullScreenLiveOffer;
	}

	// Token: 0x0600667B RID: 26235 RVA: 0x002F66B7 File Offset: 0x002F48B7
	public void OLBFMGNGPJA()
	{
		this.connectingAnimationShadow.gameObject.SetActive(false);
	}

	// Token: 0x0600667C RID: 26236 RVA: 0x002F6578 File Offset: 0x002F4778
	public PopupProfileMessageInput JINIOBCNALO()
	{
		return this.popupProfileMessageInput;
	}

	// Token: 0x170001F0 RID: 496
	// (get) Token: 0x0600667D RID: 26237 RVA: 0x002F7B78 File Offset: 0x002F5D78
	public static CommonUserInterface EHBBFMCILPC
	{
		get
		{
			if (!CommonUserInterface.IKLAPGJDMNA)
			{
				CommonUserInterface.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(CommonUserInterface)) as CommonUserInterface);
				if (!CommonUserInterface.IKLAPGJDMNA)
				{
					DPGJIJGOCIC.ANOPFDLPKGC("There needs to be one active CommonUserInterface script on a GameObject in your scene.");
				}
			}
			return CommonUserInterface.IKLAPGJDMNA;
		}
	}

	// Token: 0x0600667E RID: 26238 RVA: 0x002F7BC8 File Offset: 0x002F5DC8
	private IEnumerator ABEGLBJCAHJ(string EEMPGLHPKJG, string DPJINBCGNGN, string FNEAAEFOOEJ, string MCDCGPAADJA, UnityAction OIOPFHOHKDC, UnityAction KIDLMPIPKHL, float BICHMDEIFKI, int LINDILPPNNK)
	{
		CommonUserInterface.FCKFJPLDKBH fckfjpldkbh = new CommonUserInterface.FCKFJPLDKBH(1);
		fckfjpldkbh.<>4__this = this;
		fckfjpldkbh._textTitle = EEMPGLHPKJG;
		fckfjpldkbh._textBody = DPJINBCGNGN;
		fckfjpldkbh._positiveTextButton = FNEAAEFOOEJ;
		fckfjpldkbh._negativeTextButton = MCDCGPAADJA;
		fckfjpldkbh._positiveButtonListener = OIOPFHOHKDC;
		fckfjpldkbh._negativeButtonListener = KIDLMPIPKHL;
		fckfjpldkbh._delay = BICHMDEIFKI;
		fckfjpldkbh._fontSizeOverride = LINDILPPNNK;
		return fckfjpldkbh;
	}

	// Token: 0x0600667F RID: 26239 RVA: 0x002F7C20 File Offset: 0x002F5E20
	private IEnumerator LBKPICCNGCO(string EEMPGLHPKJG, string DPJINBCGNGN, string DCBPPPGKHEJ, string NENGGAECHKF, string HDOAPHHFMAP, UnityAction JBCIIEJDGJB, UnityAction HDNDIOMNBBJ, UnityAction CHMMLHPJJJL, UnityAction KIDLMPIPKHL, float BICHMDEIFKI, int LINDILPPNNK)
	{
		if (BICHMDEIFKI > 0.01f)
		{
			yield return new WaitForSeconds(BICHMDEIFKI);
		}
		yield return new WaitForEndOfFrame();
		if (JBCIIEJDGJB != null)
		{
			this.genericPopupThreeButtonsInside.SetOnClickListenerButtonPositive(JBCIIEJDGJB);
		}
		if (HDNDIOMNBBJ != null)
		{
			this.genericPopupThreeButtonsInside.SetOnClickListenerButtonOptional1(HDNDIOMNBBJ);
		}
		if (CHMMLHPJJJL != null)
		{
			this.genericPopupThreeButtonsInside.SetOnClickListenerButtonOptional2(CHMMLHPJJJL);
		}
		if (KIDLMPIPKHL != null)
		{
			this.genericPopupThreeButtonsInside.SetOnClickListenerButtonNegativeAndClose(KIDLMPIPKHL);
		}
		this.genericPopupTwoButtonsGreen.SetFontSize(LINDILPPNNK);
		this.genericPopupThreeButtonsInside.ShowThreeButtons(EEMPGLHPKJG, DPJINBCGNGN, DCBPPPGKHEJ, NENGGAECHKF, HDOAPHHFMAP);
		this.delayedFullScreenBlock.SetActive(false);
		yield break;
	}

	// Token: 0x06006680 RID: 26240 RVA: 0x002F66B7 File Offset: 0x002F48B7
	public void BMMMJEJAIMI()
	{
		this.connectingAnimationShadow.gameObject.SetActive(false);
	}

	// Token: 0x06006681 RID: 26241 RVA: 0x002F7C8F File Offset: 0x002F5E8F
	public void EADCJOPEBDM()
	{
		this.popupSaveSlotInput.FCICFAJMPND();
	}

	// Token: 0x06006682 RID: 26242 RVA: 0x002F7C9C File Offset: 0x002F5E9C
	private IEnumerator CEFLPOFLJOG(string EEMPGLHPKJG, string DPJINBCGNGN, string FNEAAEFOOEJ, string MCDCGPAADJA, UnityAction OIOPFHOHKDC, UnityAction KIDLMPIPKHL, UnityAction NHCNLLNPAJP, float BICHMDEIFKI, int LINDILPPNNK)
	{
		if (BICHMDEIFKI > 0.01f)
		{
			yield return new WaitForSeconds(BICHMDEIFKI);
		}
		yield return new WaitForEndOfFrame();
		if (OIOPFHOHKDC != null)
		{
			this.genericPopupTwoButtons.SetOnClickListenerButtonPositive(OIOPFHOHKDC);
		}
		if (KIDLMPIPKHL != null)
		{
			this.genericPopupTwoButtons.SetOnClickListenerButtonNegative(KIDLMPIPKHL);
		}
		if (NHCNLLNPAJP != null)
		{
			this.genericPopupTwoButtons.SetOnClickListenerButtonClose(NHCNLLNPAJP);
		}
		this.genericPopupTwoButtons.SetFontSize(LINDILPPNNK);
		this.genericPopupTwoButtons.ShowTwoButtons(EEMPGLHPKJG, DPJINBCGNGN, FNEAAEFOOEJ, MCDCGPAADJA);
		this.delayedFullScreenBlock.SetActive(false);
		yield break;
	}

	// Token: 0x06006683 RID: 26243 RVA: 0x002F7CFB File Offset: 0x002F5EFB
	public void PLNOMHKNKEB()
	{
		this.avatarCollectionsItem.Show();
	}

	// Token: 0x06006684 RID: 26244 RVA: 0x002F663E File Offset: 0x002F483E
	public void ShowPopupPasswordInput()
	{
		this.popupPasswordInput.Show();
	}

	// Token: 0x06006685 RID: 26245 RVA: 0x002F7343 File Offset: 0x002F5543
	public static bool IsInitialized()
	{
		return CommonUserInterface.IKLAPGJDMNA;
	}

	// Token: 0x06006686 RID: 26246 RVA: 0x002F7D08 File Offset: 0x002F5F08
	public GenericPopupManager JDBDCFCFPPO(string EEMPGLHPKJG, string DPJINBCGNGN, string FNEAAEFOOEJ, string MCDCGPAADJA, UnityAction OIOPFHOHKDC, UnityAction KIDLMPIPKHL, DFGILFBGPLN LAPLGLHKEJE, float BICHMDEIFKI = 0f, int LINDILPPNNK = 28)
	{
		FirebaseAnalyticsManager.DEALKJPEMMH().PDPAKIJICNL(LAPLGLHKEJE.ToString());
		this.delayedFullScreenBlock.SetActive(true);
		base.StartCoroutine(this.ABEGLBJCAHJ(EEMPGLHPKJG, DPJINBCGNGN, FNEAAEFOOEJ, MCDCGPAADJA, OIOPFHOHKDC, KIDLMPIPKHL, BICHMDEIFKI, LINDILPPNNK));
		return this.genericPopupTwoButtonsBlack;
	}

	// Token: 0x06006687 RID: 26247 RVA: 0x002F7D58 File Offset: 0x002F5F58
	public void NOGIOMLHCHN(int CPKFEMAOOBH)
	{
		this.popupProfileUIDInput.DFPLEDLEPKO(CPKFEMAOOBH);
	}

	// Token: 0x06006688 RID: 26248 RVA: 0x002F7D66 File Offset: 0x002F5F66
	public void DNGKBJKCIBB(AGNOEOKAFHL ABDCGCFAMBI, string EMGMCANANEJ)
	{
		this.popupGenericNotification.CMJLOJIDPBP(ABDCGCFAMBI.CHLENHBEPFO, ABDCGCFAMBI.LLFCANBKDEN, ABDCGCFAMBI.FCJJLCPKIHA, ABDCGCFAMBI.PFMBDEPNAJE, EMGMCANANEJ, 4);
	}

	// Token: 0x06006689 RID: 26249 RVA: 0x002F6937 File Offset: 0x002F4B37
	public AvatarCollectionsItem GetAvatarCollectionsItem()
	{
		return this.avatarCollectionsItem;
	}

	// Token: 0x0600668A RID: 26250 RVA: 0x002F7D90 File Offset: 0x002F5F90
	public bool AnyGenericPopupIsActive()
	{
		return this.genericPopupNoButtons.gameObject.activeSelf || this.genericPopup.gameObject.activeSelf || this.genericPopupTwoButtons.gameObject.activeSelf || this.genericPopupTwoButtonsBlack.gameObject.activeSelf || this.genericPopupTwoButtonsGreen.gameObject.activeSelf || this.genericPopupThreeButtonsInside.gameObject.activeSelf || this.genericPopupThreeButtonsInsideBlack.gameObject.activeSelf || this.genericPopupFourButtonsInside.gameObject.activeSelf || this.genericPopupFourButtonsInsideBlack.gameObject.activeSelf;
	}

	// Token: 0x0600668B RID: 26251 RVA: 0x002F7E42 File Offset: 0x002F6042
	public void ShowPopupProfileCredoInput()
	{
		this.popupProfileCredoInput.Show();
	}

	// Token: 0x0600668C RID: 26252 RVA: 0x002F7E4F File Offset: 0x002F604F
	public void HideGenericPopupNoButtons()
	{
		this.genericPopupNoButtons.HideSilent();
	}

	// Token: 0x0600668D RID: 26253 RVA: 0x002F722E File Offset: 0x002F542E
	private void HGNPNNKGNLG()
	{
		if (CommonUserInterface.IKLAPGJDMNA == this)
		{
			CommonUserInterface.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x0600668E RID: 26254 RVA: 0x002F62EF File Offset: 0x002F44EF
	public void OJINMMFOCAG()
	{
		this.fullScreenBlock.SetActive(false);
	}

	// Token: 0x0600668F RID: 26255 RVA: 0x002F678E File Offset: 0x002F498E
	public void CLOBADKFEOG(bool NJIFMMKNDOP, bool MFKDFMNLHEP, bool KDGPDKKDPJD)
	{
		this.settingsPopup.Show(NJIFMMKNDOP, MFKDFMNLHEP, KDGPDKKDPJD);
	}

	// Token: 0x06006690 RID: 26256 RVA: 0x002F7E5C File Offset: 0x002F605C
	public GenericPopupManager PEBIFCENHAL(string EEMPGLHPKJG, string DPJINBCGNGN, string CAGMDHNGAEH, UnityAction OIOPFHOHKDC, DFGILFBGPLN LAPLGLHKEJE, float BICHMDEIFKI = 0f, int LINDILPPNNK = 28)
	{
		FirebaseAnalyticsManager.EHBBFMCILPC.OJDGAFEBPLC(LAPLGLHKEJE.ToString());
		this.delayedFullScreenBlock.SetActive(true);
		base.StartCoroutine(this.KEINOGJEHKB(EEMPGLHPKJG, DPJINBCGNGN, CAGMDHNGAEH, OIOPFHOHKDC, BICHMDEIFKI, LINDILPPNNK));
		return this.genericPopup;
	}

	// Token: 0x06006691 RID: 26257 RVA: 0x002F7EA8 File Offset: 0x002F60A8
	public GenericPopupManager ShowGenericPopupWithThreeButtonsInside(string EEMPGLHPKJG, string DPJINBCGNGN, string DCBPPPGKHEJ, string NENGGAECHKF, string HDOAPHHFMAP, UnityAction JBCIIEJDGJB, UnityAction HDNDIOMNBBJ, UnityAction CHMMLHPJJJL, UnityAction KIDLMPIPKHL, DFGILFBGPLN LAPLGLHKEJE, float BICHMDEIFKI = 0f, int LINDILPPNNK = 28)
	{
		FirebaseAnalyticsManager.EHBBFMCILPC.LogScreen(LAPLGLHKEJE.ToString());
		this.delayedFullScreenBlock.SetActive(true);
		base.StartCoroutine(this.LBKPICCNGCO(EEMPGLHPKJG, DPJINBCGNGN, DCBPPPGKHEJ, NENGGAECHKF, HDOAPHHFMAP, JBCIIEJDGJB, HDNDIOMNBBJ, CHMMLHPJJJL, KIDLMPIPKHL, BICHMDEIFKI, LINDILPPNNK));
		return this.genericPopupThreeButtonsInside;
	}

	// Token: 0x06006692 RID: 26258 RVA: 0x002F7F00 File Offset: 0x002F6100
	public GenericPopupManager NPIOKKDPALC(string EEMPGLHPKJG, string DPJINBCGNGN, string FNEAAEFOOEJ, string MCDCGPAADJA, UnityAction OIOPFHOHKDC, UnityAction KIDLMPIPKHL, UnityAction NHCNLLNPAJP, DFGILFBGPLN LAPLGLHKEJE, float BICHMDEIFKI = 0f, int LINDILPPNNK = 28)
	{
		FirebaseAnalyticsManager.DMAAFFFEJGA().FAPDDMCLHHE(LAPLGLHKEJE.ToString());
		this.delayedFullScreenBlock.SetActive(true);
		base.StartCoroutine(this.CEFLPOFLJOG(EEMPGLHPKJG, DPJINBCGNGN, FNEAAEFOOEJ, MCDCGPAADJA, OIOPFHOHKDC, KIDLMPIPKHL, NHCNLLNPAJP, BICHMDEIFKI, LINDILPPNNK));
		return this.genericPopupTwoButtons;
	}

	// Token: 0x06006693 RID: 26259 RVA: 0x002F7F54 File Offset: 0x002F6154
	private IEnumerator DCGDEMHBBOE(string EEMPGLHPKJG, string DPJINBCGNGN, string CAGMDHNGAEH, UnityAction OIOPFHOHKDC, UnityAction KIDLMPIPKHL, float BICHMDEIFKI, int LINDILPPNNK)
	{
		if (BICHMDEIFKI > 0.01f)
		{
			yield return new WaitForSeconds(BICHMDEIFKI);
		}
		yield return new WaitForEndOfFrame();
		if (OIOPFHOHKDC != null)
		{
			this.genericPopup.SetOnClickListenerButtonPositive(OIOPFHOHKDC);
		}
		if (KIDLMPIPKHL != null)
		{
			this.genericPopup.SetOnClickListenerButtonNegativeAndClose(KIDLMPIPKHL);
		}
		this.genericPopupTwoButtons.SetFontSize(LINDILPPNNK);
		this.genericPopup.ShowOneButton(EEMPGLHPKJG, DPJINBCGNGN, CAGMDHNGAEH);
		this.delayedFullScreenBlock.SetActive(false);
		yield break;
	}

	// Token: 0x06006694 RID: 26260 RVA: 0x002F72C2 File Offset: 0x002F54C2
	public void DisableRestartFade()
	{
		this.restartFade.SetActive(false);
	}

	// Token: 0x06006695 RID: 26261 RVA: 0x002F7FA3 File Offset: 0x002F61A3
	public void ShowPopupAvatarCollectionsInput()
	{
		this.avatarCollectionsInput.Show();
	}

	// Token: 0x06006696 RID: 26262 RVA: 0x002F7FB0 File Offset: 0x002F61B0
	public void FPHNBOHOJOB()
	{
		this.popupPromoCodes.PCHHIDICLPI();
	}

	// Token: 0x06006697 RID: 26263 RVA: 0x002F7FC0 File Offset: 0x002F61C0
	public GenericPopupManager NBEELFNLGJM(string EEMPGLHPKJG, string DPJINBCGNGN, string DCBPPPGKHEJ, string NENGGAECHKF, string HDOAPHHFMAP, string PODLGPEGNLJ, UnityAction JBCIIEJDGJB, UnityAction HDNDIOMNBBJ, UnityAction CHMMLHPJJJL, UnityAction ACOCOEFNJBH, UnityAction KIDLMPIPKHL, DFGILFBGPLN LAPLGLHKEJE, float BICHMDEIFKI = 0f, int LINDILPPNNK = 28)
	{
		FirebaseAnalyticsManager.DEALKJPEMMH().FAEMDBGLPDF(LAPLGLHKEJE.ToString());
		this.delayedFullScreenBlock.SetActive(false);
		base.StartCoroutine(this.PKHBGENBOOL(EEMPGLHPKJG, DPJINBCGNGN, DCBPPPGKHEJ, NENGGAECHKF, HDOAPHHFMAP, PODLGPEGNLJ, JBCIIEJDGJB, HDNDIOMNBBJ, CHMMLHPJJJL, ACOCOEFNJBH, KIDLMPIPKHL, BICHMDEIFKI, LINDILPPNNK));
		return this.genericPopupFourButtonsInsideBlack;
	}

	// Token: 0x06006698 RID: 26264 RVA: 0x002F801C File Offset: 0x002F621C
	public GenericPopupManager GAEIBLLCBGK(string EEMPGLHPKJG, string DPJINBCGNGN, string DCBPPPGKHEJ, string NENGGAECHKF, string HDOAPHHFMAP, UnityAction JBCIIEJDGJB, UnityAction HDNDIOMNBBJ, UnityAction CHMMLHPJJJL, UnityAction KIDLMPIPKHL, DFGILFBGPLN LAPLGLHKEJE, float BICHMDEIFKI = 0f, int LINDILPPNNK = 28)
	{
		FirebaseAnalyticsManager.EHBBFMCILPC.MDIKINNMNBK(LAPLGLHKEJE.ToString());
		this.delayedFullScreenBlock.SetActive(true);
		base.StartCoroutine(this.LBKPICCNGCO(EEMPGLHPKJG, DPJINBCGNGN, DCBPPPGKHEJ, NENGGAECHKF, HDOAPHHFMAP, JBCIIEJDGJB, HDNDIOMNBBJ, CHMMLHPJJJL, KIDLMPIPKHL, BICHMDEIFKI, LINDILPPNNK));
		return this.genericPopupThreeButtonsInside;
	}

	// Token: 0x06006699 RID: 26265 RVA: 0x002F8072 File Offset: 0x002F6272
	public void FOGCCMFOOHJ()
	{
		AssetsManager.EHBBFMCILPC.purchasingViewManager.HELGKFOCIJC();
	}

	// Token: 0x0600669A RID: 26266 RVA: 0x002F8084 File Offset: 0x002F6284
	public GenericPopupManager ShowGenericPopupTwoOverride(string EEMPGLHPKJG, string DPJINBCGNGN, string CAGMDHNGAEH, UnityAction OIOPFHOHKDC, UnityAction KIDLMPIPKHL, DFGILFBGPLN LAPLGLHKEJE, float BICHMDEIFKI = 0f, int LINDILPPNNK = 28)
	{
		FirebaseAnalyticsManager.EHBBFMCILPC.LogScreen(LAPLGLHKEJE.ToString());
		this.delayedFullScreenBlock.SetActive(true);
		base.StartCoroutine(this.DCGDEMHBBOE(EEMPGLHPKJG, DPJINBCGNGN, CAGMDHNGAEH, OIOPFHOHKDC, KIDLMPIPKHL, BICHMDEIFKI, LINDILPPNNK));
		return this.genericPopup;
	}

	// Token: 0x0600669B RID: 26267 RVA: 0x002F80D2 File Offset: 0x002F62D2
	public void ShowPopupProfileSaveCutsceneInput()
	{
		this.popupProfileSaveCutsceneInput.Show();
	}

	// Token: 0x0600669C RID: 26268 RVA: 0x002F72C2 File Offset: 0x002F54C2
	public void AMMFHBBIFJB()
	{
		this.restartFade.SetActive(false);
	}

	// Token: 0x0600669D RID: 26269 RVA: 0x002F80E0 File Offset: 0x002F62E0
	private IEnumerator FEEBAGJDMMM(string EEMPGLHPKJG, string DPJINBCGNGN, string DCBPPPGKHEJ, string NENGGAECHKF, string HDOAPHHFMAP, string PODLGPEGNLJ, UnityAction JBCIIEJDGJB, UnityAction HDNDIOMNBBJ, UnityAction CHMMLHPJJJL, UnityAction ACOCOEFNJBH, UnityAction KIDLMPIPKHL, float BICHMDEIFKI, int LINDILPPNNK)
	{
		if (BICHMDEIFKI > 0.01f)
		{
			yield return new WaitForSeconds(BICHMDEIFKI);
		}
		yield return new WaitForEndOfFrame();
		if (JBCIIEJDGJB != null)
		{
			this.genericPopupFourButtonsInsideBlack.SetOnClickListenerButtonPositive(JBCIIEJDGJB);
		}
		if (HDNDIOMNBBJ != null)
		{
			this.genericPopupFourButtonsInsideBlack.SetOnClickListenerButtonOptional1(HDNDIOMNBBJ);
		}
		if (CHMMLHPJJJL != null)
		{
			this.genericPopupFourButtonsInsideBlack.SetOnClickListenerButtonOptional2(CHMMLHPJJJL);
		}
		if (ACOCOEFNJBH != null)
		{
			this.genericPopupFourButtonsInsideBlack.SetOnClickListenerButtonOptional3(ACOCOEFNJBH);
		}
		if (KIDLMPIPKHL != null)
		{
			this.genericPopupFourButtonsInsideBlack.SetOnClickListenerButtonNegativeAndClose(KIDLMPIPKHL);
		}
		this.genericPopupTwoButtonsGreen.SetFontSize(LINDILPPNNK);
		this.genericPopupFourButtonsInsideBlack.ShowFourButtons(EEMPGLHPKJG, DPJINBCGNGN, DCBPPPGKHEJ, NENGGAECHKF, HDOAPHHFMAP, PODLGPEGNLJ);
		this.delayedFullScreenBlock.SetActive(false);
		yield break;
	}

	// Token: 0x0600669E RID: 26270 RVA: 0x002F7CFB File Offset: 0x002F5EFB
	public void FCICLHHAGJD()
	{
		this.avatarCollectionsItem.Show();
	}

	// Token: 0x0600669F RID: 26271 RVA: 0x002F815F File Offset: 0x002F635F
	public FaderManager GetFader()
	{
		return this.fader;
	}

	// Token: 0x060066A0 RID: 26272 RVA: 0x002F8168 File Offset: 0x002F6368
	private IEnumerator OMBHBOIGLIE(string EEMPGLHPKJG, string DPJINBCGNGN, string FNEAAEFOOEJ, string MCDCGPAADJA, UnityAction OIOPFHOHKDC, UnityAction KIDLMPIPKHL, UnityAction NHCNLLNPAJP, float BICHMDEIFKI, int LINDILPPNNK)
	{
		CommonUserInterface.MKACCNEEJDO mkaccneejdo = new CommonUserInterface.MKACCNEEJDO(1);
		mkaccneejdo.<>4__this = this;
		mkaccneejdo._textTitle = EEMPGLHPKJG;
		mkaccneejdo._textBody = DPJINBCGNGN;
		mkaccneejdo._positiveTextButton = FNEAAEFOOEJ;
		mkaccneejdo._negativeTextButton = MCDCGPAADJA;
		mkaccneejdo._positiveButtonListener = OIOPFHOHKDC;
		mkaccneejdo._negativeButtonListener = KIDLMPIPKHL;
		mkaccneejdo._closeButtonListener = NHCNLLNPAJP;
		mkaccneejdo._delay = BICHMDEIFKI;
		mkaccneejdo._fontSizeOverride = LINDILPPNNK;
		return mkaccneejdo;
	}

	// Token: 0x060066A1 RID: 26273 RVA: 0x002F6392 File Offset: 0x002F4592
	public void NJOCGDNOFPJ()
	{
		this.popupPasswordInput.NOBOPEABJHA();
	}

	// Token: 0x060066A2 RID: 26274 RVA: 0x002F81C8 File Offset: 0x002F63C8
	public bool LHBOBMDENGJ()
	{
		return !this.genericPopupNoButtons.gameObject.activeSelf && !this.genericPopup.gameObject.activeSelf && !this.genericPopupTwoButtons.gameObject.activeSelf && !this.genericPopupTwoButtonsBlack.gameObject.activeSelf && !this.genericPopupTwoButtonsGreen.gameObject.activeSelf && !this.genericPopupThreeButtonsInside.gameObject.activeSelf && !this.genericPopupThreeButtonsInsideBlack.gameObject.activeSelf && !this.genericPopupFourButtonsInside.gameObject.activeSelf && this.genericPopupFourButtonsInsideBlack.gameObject.activeSelf;
	}

	// Token: 0x060066A3 RID: 26275 RVA: 0x002F827A File Offset: 0x002F647A
	private void FDLCNFDHAAM()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		this.DCFCCNKGEJD();
	}

	// Token: 0x060066A4 RID: 26276 RVA: 0x002F8290 File Offset: 0x002F6490
	private IEnumerator MAHBLJDOCIK(string EEMPGLHPKJG, string DPJINBCGNGN, string FNEAAEFOOEJ, string MCDCGPAADJA, UnityAction OIOPFHOHKDC, UnityAction KIDLMPIPKHL, float BICHMDEIFKI, int LINDILPPNNK)
	{
		CommonUserInterface.ACHHAMAGHFD achhamaghfd = new CommonUserInterface.ACHHAMAGHFD(1);
		achhamaghfd.<>4__this = this;
		achhamaghfd._textTitle = EEMPGLHPKJG;
		achhamaghfd._textBody = DPJINBCGNGN;
		achhamaghfd._positiveTextButton = FNEAAEFOOEJ;
		achhamaghfd._negativeTextButton = MCDCGPAADJA;
		achhamaghfd._positiveButtonListener = OIOPFHOHKDC;
		achhamaghfd._negativeButtonListener = KIDLMPIPKHL;
		achhamaghfd._delay = BICHMDEIFKI;
		achhamaghfd._fontSizeOverride = LINDILPPNNK;
		return achhamaghfd;
	}

	// Token: 0x060066A5 RID: 26277 RVA: 0x002F82E8 File Offset: 0x002F64E8
	public GenericPopupManager PNLBEGGKCFL(string EEMPGLHPKJG, string DPJINBCGNGN, string CAGMDHNGAEH, UnityAction OIOPFHOHKDC, UnityAction NHCNLLNPAJP, DFGILFBGPLN LAPLGLHKEJE, float BICHMDEIFKI = 0f, int LINDILPPNNK = 28)
	{
		FirebaseAnalyticsManager.JMDJBFAEHBM().OJDGAFEBPLC(LAPLGLHKEJE.ToString());
		this.delayedFullScreenBlock.SetActive(true);
		base.StartCoroutine(this.NKBCDHKKBGL(EEMPGLHPKJG, DPJINBCGNGN, CAGMDHNGAEH, OIOPFHOHKDC, NHCNLLNPAJP, BICHMDEIFKI, LINDILPPNNK));
		return this.genericPopup;
	}

	// Token: 0x060066A6 RID: 26278 RVA: 0x002F8336 File Offset: 0x002F6536
	public void ShowPopupProfileMessageInput(int CPKFEMAOOBH)
	{
		this.popupProfileMessageInput.Show(CPKFEMAOOBH);
	}

	// Token: 0x060066A7 RID: 26279 RVA: 0x002F8344 File Offset: 0x002F6544
	public GenericPopupManager MJNDCBAPEOP(string EEMPGLHPKJG, string DPJINBCGNGN, DFGILFBGPLN LAPLGLHKEJE, float BICHMDEIFKI = 0f, int LINDILPPNNK = 28)
	{
		FirebaseAnalyticsManager.DMAAFFFEJGA().FAEMDBGLPDF(LAPLGLHKEJE.ToString());
		this.delayedFullScreenBlock.SetActive(true);
		base.StartCoroutine(this.DBPGCFMONBO(EEMPGLHPKJG, DPJINBCGNGN, BICHMDEIFKI, LINDILPPNNK));
		return this.genericPopupNoButtons;
	}

	// Token: 0x060066A8 RID: 26280 RVA: 0x002F8384 File Offset: 0x002F6584
	public void LANLNOLFHMG(byte IGLCKLCKDKO = 0)
	{
		this.connectingAnimationTextProgress.gameObject.SetActive(true);
		this.connectingAnimationTextProgress.SetText(" (", true);
		this.connectingAnimationTextHint.gameObject.SetActive(true);
		this.connectingAnimationFade.color = new Color32(0, 1, 1, IGLCKLCKDKO);
		this.connectingAnimationShadow.gameObject.SetActive(true);
		bool activeSelf = this.connectingAnimation.gameObject.activeSelf;
		this.connectingAnimation.gameObject.SetActive(true);
		if (!activeSelf || this.DFEEFCBHMLF)
		{
			this.connectingAnimation.SetDirection(true);
			this.connectingAnimation.KBMPFNHNADD(true);
		}
		this.DFEEFCBHMLF = true;
	}

	// Token: 0x060066A9 RID: 26281 RVA: 0x002F8438 File Offset: 0x002F6638
	public GenericPopupManager ShowGenericPopupWithThreeButtonsInsideBlack(string EEMPGLHPKJG, string DPJINBCGNGN, string DCBPPPGKHEJ, string NENGGAECHKF, string HDOAPHHFMAP, UnityAction JBCIIEJDGJB, UnityAction HDNDIOMNBBJ, UnityAction CHMMLHPJJJL, UnityAction KIDLMPIPKHL, DFGILFBGPLN LAPLGLHKEJE, float BICHMDEIFKI = 0f, int LINDILPPNNK = 28)
	{
		FirebaseAnalyticsManager.EHBBFMCILPC.LogScreen(LAPLGLHKEJE.ToString());
		this.delayedFullScreenBlock.SetActive(true);
		base.StartCoroutine(this.NDCLCFDOHEH(EEMPGLHPKJG, DPJINBCGNGN, DCBPPPGKHEJ, NENGGAECHKF, HDOAPHHFMAP, JBCIIEJDGJB, HDNDIOMNBBJ, CHMMLHPJJJL, KIDLMPIPKHL, BICHMDEIFKI, LINDILPPNNK));
		return this.genericPopupThreeButtonsInsideBlack;
	}

	// Token: 0x060066AA RID: 26282 RVA: 0x002F7CFB File Offset: 0x002F5EFB
	public void ShowAvatarCollectionsItem()
	{
		this.avatarCollectionsItem.Show();
	}

	// Token: 0x060066AB RID: 26283 RVA: 0x002F8490 File Offset: 0x002F6690
	private IEnumerator NKBCDHKKBGL(string EEMPGLHPKJG, string DPJINBCGNGN, string CAGMDHNGAEH, UnityAction OIOPFHOHKDC, UnityAction NHCNLLNPAJP, float BICHMDEIFKI, int LINDILPPNNK)
	{
		if (BICHMDEIFKI > 0.01f)
		{
			yield return new WaitForSeconds(BICHMDEIFKI);
		}
		yield return new WaitForEndOfFrame();
		if (OIOPFHOHKDC != null)
		{
			this.genericPopup.SetOnClickListenerButtonPositive(OIOPFHOHKDC);
		}
		if (NHCNLLNPAJP != null)
		{
			this.genericPopup.SetOnClickListenerButtonClose(NHCNLLNPAJP);
		}
		this.genericPopup.SetFontSize(LINDILPPNNK);
		this.genericPopup.ShowOneButton(EEMPGLHPKJG, DPJINBCGNGN, CAGMDHNGAEH);
		this.delayedFullScreenBlock.SetActive(false);
		yield break;
	}

	// Token: 0x060066AC RID: 26284 RVA: 0x002F84E0 File Offset: 0x002F66E0
	public GenericPopupManager JJPNFAAPFBI(string EEMPGLHPKJG, string DPJINBCGNGN, string CAGMDHNGAEH, UnityAction OIOPFHOHKDC, UnityAction KIDLMPIPKHL, DFGILFBGPLN LAPLGLHKEJE, float BICHMDEIFKI = 0f, int LINDILPPNNK = 28)
	{
		FirebaseAnalyticsManager.ANCEKPONIFI().AHILBLIMLGJ(LAPLGLHKEJE.ToString());
		this.delayedFullScreenBlock.SetActive(true);
		base.StartCoroutine(this.DCGDEMHBBOE(EEMPGLHPKJG, DPJINBCGNGN, CAGMDHNGAEH, OIOPFHOHKDC, KIDLMPIPKHL, BICHMDEIFKI, LINDILPPNNK));
		return this.genericPopup;
	}

	// Token: 0x060066AD RID: 26285 RVA: 0x002F8530 File Offset: 0x002F6730
	public void CDNICMFGIID(float JFCAINFOEHJ)
	{
		if (this.connectingAnimation.gameObject.activeSelf && this.connectingAnimationTextProgress.gameObject.activeSelf)
		{
			this.connectingAnimationTextProgress.SetText((JFCAINFOEHJ * 764f).ToString("OnAccountForgetException") + "ERROR: StoryStep.StoryStepType.avatarConfig - firstAvailableFaceAsset is null.", false);
		}
	}

	// Token: 0x060066AE RID: 26286 RVA: 0x002F858C File Offset: 0x002F678C
	public void KLEJAGLPCNM(string CNAEPCMCFMD, byte IGLCKLCKDKO = 0)
	{
		this.connectingAnimationTextProgress.gameObject.SetActive(true);
		this.connectingAnimationTextHint.gameObject.SetActive(true);
		this.connectingAnimationTextHint.SetText(CNAEPCMCFMD, false);
		this.connectingAnimationFade.color = new Color32(1, 1, 0, IGLCKLCKDKO);
		this.connectingAnimationShadow.gameObject.SetActive(false);
		bool activeSelf = this.connectingAnimation.gameObject.activeSelf;
		this.connectingAnimation.gameObject.SetActive(false);
		if (!activeSelf || this.DFEEFCBHMLF)
		{
			this.connectingAnimation.FOLIHFAJOCP(false);
			this.connectingAnimation.PlayAnimation(true);
		}
		this.DFEEFCBHMLF = false;
	}

	// Token: 0x060066AF RID: 26287 RVA: 0x002F7A39 File Offset: 0x002F5C39
	public void EnableRestartFade()
	{
		this.restartFade.SetActive(true);
	}

	// Token: 0x060066B0 RID: 26288 RVA: 0x00003E52 File Offset: 0x00002052
	private void Start()
	{
	}

	// Token: 0x060066B1 RID: 26289 RVA: 0x002F72D0 File Offset: 0x002F54D0
	public void EPOPLLBAKEH()
	{
		this.gamePassSettingsPopup.Show();
	}

	// Token: 0x060066B2 RID: 26290 RVA: 0x002F663E File Offset: 0x002F483E
	public void GMFLJNBADGO()
	{
		this.popupPasswordInput.Show();
	}

	// Token: 0x060066B3 RID: 26291 RVA: 0x002F62EF File Offset: 0x002F44EF
	public void CGNDPJCDCFP()
	{
		this.fullScreenBlock.SetActive(false);
	}

	// Token: 0x060066B4 RID: 26292 RVA: 0x002F863C File Offset: 0x002F683C
	public void MCJIGJMFBMI()
	{
		this.DFEEFCBHMLF = false;
		this.connectingAnimation.FOLIHFAJOCP(true);
		this.connectingAnimation.PKEELDKHLHN(true);
		this.connectingAnimationShadow.gameObject.SetActive(false);
		this.GFAMDMIEPFG = false;
		this.connectingAnimationTop.JNMIPNKPAHC(false);
		this.connectingAnimationTop.MPICIBINNCP(true);
	}

	// Token: 0x060066B5 RID: 26293 RVA: 0x002F6D1C File Offset: 0x002F4F1C
	public PassesItem PJFDODCHHHK()
	{
		return this.popupGamePasses;
	}

	// Token: 0x060066B6 RID: 26294 RVA: 0x002F664B File Offset: 0x002F484B
	public PopupStoryRestartManager GetStoryRestartPopup()
	{
		return this.storyRestartPopup;
	}

	// Token: 0x060066B7 RID: 26295 RVA: 0x002F8698 File Offset: 0x002F6898
	public SkinShopItem GetSkinShop()
	{
		return this.popupSkinShop;
	}

	// Token: 0x060066B8 RID: 26296 RVA: 0x002F86A0 File Offset: 0x002F68A0
	public bool BPAKOKECKAK()
	{
		return !this.connectingAnimation.gameObject.activeSelf && this.connectingAnimationTop.gameObject.activeSelf;
	}

	// Token: 0x060066B9 RID: 26297 RVA: 0x002F6937 File Offset: 0x002F4B37
	public AvatarCollectionsItem EOKAGMBGELB()
	{
		return this.avatarCollectionsItem;
	}

	// Token: 0x060066BA RID: 26298 RVA: 0x002F86C8 File Offset: 0x002F68C8
	private IEnumerator EKFPODLDMFP(string EEMPGLHPKJG, string DPJINBCGNGN, string FNEAAEFOOEJ, string MCDCGPAADJA, UnityAction OIOPFHOHKDC, UnityAction KIDLMPIPKHL, float BICHMDEIFKI, int LINDILPPNNK)
	{
		if (BICHMDEIFKI > 0.01f)
		{
			yield return new WaitForSeconds(BICHMDEIFKI);
		}
		yield return new WaitForEndOfFrame();
		if (OIOPFHOHKDC != null)
		{
			this.genericPopupTwoButtonsGreen.SetOnClickListenerButtonPositive(OIOPFHOHKDC);
		}
		if (KIDLMPIPKHL != null)
		{
			this.genericPopupTwoButtonsGreen.SetOnClickListenerButtonNegativeAndClose(KIDLMPIPKHL);
		}
		this.genericPopupTwoButtonsGreen.SetFontSize(LINDILPPNNK);
		this.genericPopupTwoButtonsGreen.ShowTwoButtons(EEMPGLHPKJG, DPJINBCGNGN, FNEAAEFOOEJ, MCDCGPAADJA);
		this.delayedFullScreenBlock.SetActive(false);
		yield break;
	}

	// Token: 0x060066BB RID: 26299 RVA: 0x002F7A18 File Offset: 0x002F5C18
	public void MAOHHNGMFFB(string DIMBCOBNMAM)
	{
		if (this.connectingAnimation.gameObject.activeSelf)
		{
			this.connectingAnimationTextProgress.SetText(DIMBCOBNMAM, true);
		}
	}

	// Token: 0x060066BC RID: 26300 RVA: 0x002F8720 File Offset: 0x002F6920
	public GenericPopupManager BABMOGBECOD(string EEMPGLHPKJG, string DPJINBCGNGN, string DCBPPPGKHEJ, string NENGGAECHKF, string HDOAPHHFMAP, string PODLGPEGNLJ, UnityAction JBCIIEJDGJB, UnityAction HDNDIOMNBBJ, UnityAction CHMMLHPJJJL, UnityAction ACOCOEFNJBH, UnityAction KIDLMPIPKHL, DFGILFBGPLN LAPLGLHKEJE, float BICHMDEIFKI = 0f, int LINDILPPNNK = 28)
	{
		FirebaseAnalyticsManager.DMAAFFFEJGA().HMCOBPDJEEA(LAPLGLHKEJE.ToString());
		this.delayedFullScreenBlock.SetActive(true);
		base.StartCoroutine(this.HHHGGINAFFB(EEMPGLHPKJG, DPJINBCGNGN, DCBPPPGKHEJ, NENGGAECHKF, HDOAPHHFMAP, PODLGPEGNLJ, JBCIIEJDGJB, HDNDIOMNBBJ, CHMMLHPJJJL, ACOCOEFNJBH, KIDLMPIPKHL, BICHMDEIFKI, LINDILPPNNK));
		return this.genericPopupFourButtonsInsideBlack;
	}

	// Token: 0x060066BD RID: 26301 RVA: 0x002F877A File Offset: 0x002F697A
	public void GFCLJAPOPLI()
	{
		this.popupProfileNicknameInput.DLKJCDLEHAA();
	}

	// Token: 0x060066BE RID: 26302 RVA: 0x002F8788 File Offset: 0x002F6988
	public void UpdateConnectionAnimationProgress(float JFCAINFOEHJ)
	{
		if (this.connectingAnimation.gameObject.activeSelf && this.connectingAnimationTextProgress.gameObject.activeSelf)
		{
			this.connectingAnimationTextProgress.SetText((JFCAINFOEHJ * 100f).ToString("0") + "%", true);
		}
	}

	// Token: 0x060066BF RID: 26303 RVA: 0x002F87E3 File Offset: 0x002F69E3
	public void ShowPopupRemoveAds()
	{
		this.popupRemoveAds.Show();
	}

	// Token: 0x060066C0 RID: 26304 RVA: 0x002F87F0 File Offset: 0x002F69F0
	public void PGCDDPPKBFF(byte IGLCKLCKDKO = 0)
	{
		this.connectingAnimationTextProgress.gameObject.SetActive(false);
		this.connectingAnimationTextProgress.SetText("ScreenStack ", true);
		this.connectingAnimationTextHint.gameObject.SetActive(true);
		this.connectingAnimationFade.color = new Color32(1, 0, 0, IGLCKLCKDKO);
		this.connectingAnimationShadow.gameObject.SetActive(false);
		bool activeSelf = this.connectingAnimation.gameObject.activeSelf;
		this.connectingAnimation.gameObject.SetActive(false);
		if (!activeSelf || this.DFEEFCBHMLF)
		{
			this.connectingAnimation.HAEAIGMGGOA(false);
			this.connectingAnimation.OENEEPHFNGD(true);
		}
		this.DFEEFCBHMLF = true;
	}

	// Token: 0x060066C1 RID: 26305 RVA: 0x002F88A4 File Offset: 0x002F6AA4
	public static CommonUserInterface IKNOFBFMPGA()
	{
		if (!CommonUserInterface.IKLAPGJDMNA)
		{
			CommonUserInterface.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(CommonUserInterface)) as CommonUserInterface);
			if (!CommonUserInterface.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("StoriesSearchRanker: nothing to search (anthologies ");
			}
		}
		return CommonUserInterface.IKLAPGJDMNA;
	}

	// Token: 0x060066C2 RID: 26306 RVA: 0x002F88F1 File Offset: 0x002F6AF1
	public GenericPopupManager NFBMHHPIGFA(string EEMPGLHPKJG, string DPJINBCGNGN, string CAGMDHNGAEH, DFGILFBGPLN LAPLGLHKEJE, float BICHMDEIFKI = 0f, int LINDILPPNNK = 28)
	{
		FirebaseAnalyticsManager.JMDJBFAEHBM().HMCOBPDJEEA(LAPLGLHKEJE.ToString());
		this.delayedFullScreenBlock.SetActive(true);
		base.StartCoroutine(this.LNANDNHLIOP(EEMPGLHPKJG, DPJINBCGNGN, CAGMDHNGAEH, BICHMDEIFKI, LINDILPPNNK));
		return this.genericPopup;
	}

	// Token: 0x060066C3 RID: 26307 RVA: 0x002F8930 File Offset: 0x002F6B30
	public void GIFCDFKBBCN(string IDEKNBNKKJF, int CDPOGMJFOGB = -1)
	{
		this.popupOnlineResources.IEDNDIONFCM(IDEKNBNKKJF, CDPOGMJFOGB);
	}

	// Token: 0x060066C4 RID: 26308 RVA: 0x002F8940 File Offset: 0x002F6B40
	private IEnumerator PKHBGENBOOL(string EEMPGLHPKJG, string DPJINBCGNGN, string DCBPPPGKHEJ, string NENGGAECHKF, string HDOAPHHFMAP, string PODLGPEGNLJ, UnityAction JBCIIEJDGJB, UnityAction HDNDIOMNBBJ, UnityAction CHMMLHPJJJL, UnityAction ACOCOEFNJBH, UnityAction KIDLMPIPKHL, float BICHMDEIFKI, int LINDILPPNNK)
	{
		if (BICHMDEIFKI > 0.01f)
		{
			yield return new WaitForSeconds(BICHMDEIFKI);
		}
		yield return new WaitForEndOfFrame();
		if (JBCIIEJDGJB != null)
		{
			this.genericPopupFourButtonsInsideBlack.SetOnClickListenerButtonPositive(JBCIIEJDGJB);
		}
		if (HDNDIOMNBBJ != null)
		{
			this.genericPopupFourButtonsInsideBlack.SetOnClickListenerButtonOptional1(HDNDIOMNBBJ);
		}
		if (CHMMLHPJJJL != null)
		{
			this.genericPopupFourButtonsInsideBlack.SetOnClickListenerButtonOptional2(CHMMLHPJJJL);
		}
		if (ACOCOEFNJBH != null)
		{
			this.genericPopupFourButtonsInsideBlack.SetOnClickListenerButtonOptional3(ACOCOEFNJBH);
		}
		if (KIDLMPIPKHL != null)
		{
			this.genericPopupFourButtonsInsideBlack.SetOnClickListenerButtonNegativeAndClose(KIDLMPIPKHL);
		}
		this.genericPopupTwoButtonsGreen.SetFontSize(LINDILPPNNK);
		this.genericPopupFourButtonsInsideBlack.ShowFourButtons(EEMPGLHPKJG, DPJINBCGNGN, DCBPPPGKHEJ, NENGGAECHKF, HDOAPHHFMAP, PODLGPEGNLJ);
		this.delayedFullScreenBlock.SetActive(false);
		yield break;
	}

	// Token: 0x060066C5 RID: 26309 RVA: 0x002F89BF File Offset: 0x002F6BBF
	public void ShowConnectingAnimationShadow()
	{
		this.connectingAnimationShadow.gameObject.SetActive(true);
	}

	// Token: 0x060066C6 RID: 26310 RVA: 0x002F6392 File Offset: 0x002F4592
	public void POLENLOOOAP()
	{
		this.popupPasswordInput.NOBOPEABJHA();
	}

	// Token: 0x060066C7 RID: 26311 RVA: 0x002F89D4 File Offset: 0x002F6BD4
	public GenericPopupManager OJAGDHDOBMD(string EEMPGLHPKJG, string DPJINBCGNGN, string FNEAAEFOOEJ, string MCDCGPAADJA, UnityAction OIOPFHOHKDC, UnityAction KIDLMPIPKHL, DFGILFBGPLN LAPLGLHKEJE, float BICHMDEIFKI = 0f, int LINDILPPNNK = 28)
	{
		FirebaseAnalyticsManager.EHBBFMCILPC.HMCOBPDJEEA(LAPLGLHKEJE.ToString());
		this.delayedFullScreenBlock.SetActive(false);
		base.StartCoroutine(this.EKFPODLDMFP(EEMPGLHPKJG, DPJINBCGNGN, FNEAAEFOOEJ, MCDCGPAADJA, OIOPFHOHKDC, KIDLMPIPKHL, BICHMDEIFKI, LINDILPPNNK));
		return this.genericPopupTwoButtonsGreen;
	}

	// Token: 0x060066C8 RID: 26312 RVA: 0x002F8A24 File Offset: 0x002F6C24
	private IEnumerator KEINOGJEHKB(string EEMPGLHPKJG, string DPJINBCGNGN, string CAGMDHNGAEH, UnityAction OIOPFHOHKDC, float BICHMDEIFKI, int LINDILPPNNK)
	{
		CommonUserInterface.BKPLMBIMJJO bkplmbimjjo = new CommonUserInterface.BKPLMBIMJJO(1);
		bkplmbimjjo.<>4__this = this;
		bkplmbimjjo._textTitle = EEMPGLHPKJG;
		bkplmbimjjo._textBody = DPJINBCGNGN;
		bkplmbimjjo._textButton = CAGMDHNGAEH;
		bkplmbimjjo._positiveButtonListener = OIOPFHOHKDC;
		bkplmbimjjo._delay = BICHMDEIFKI;
		bkplmbimjjo._fontSizeOverride = LINDILPPNNK;
		return bkplmbimjjo;
	}

	// Token: 0x060066C9 RID: 26313 RVA: 0x002F788C File Offset: 0x002F5A8C
	public void ShowSocialSelect()
	{
		this.socialPopup.Show();
	}

	// Token: 0x060066CA RID: 26314 RVA: 0x002F7335 File Offset: 0x002F5535
	public void ADEDBJIGEHP(int CPKFEMAOOBH)
	{
		this.popupProfileUIDInput.Show(CPKFEMAOOBH);
	}

	// Token: 0x060066CB RID: 26315 RVA: 0x002F8A60 File Offset: 0x002F6C60
	public bool PopupGenericNotificationActive()
	{
		return this.popupGenericNotification.gameObject.activeSelf;
	}

	// Token: 0x060066CC RID: 26316 RVA: 0x002F8A74 File Offset: 0x002F6C74
	public GenericPopupManager MHEOEIHHNPJ(string EEMPGLHPKJG, string DPJINBCGNGN, string FNEAAEFOOEJ, string MCDCGPAADJA, UnityAction OIOPFHOHKDC, UnityAction KIDLMPIPKHL, UnityAction NHCNLLNPAJP, DFGILFBGPLN LAPLGLHKEJE, float BICHMDEIFKI = 0f, int LINDILPPNNK = 28)
	{
		FirebaseAnalyticsManager.HJGDLOOHNLO().PDPAKIJICNL(LAPLGLHKEJE.ToString());
		this.delayedFullScreenBlock.SetActive(true);
		base.StartCoroutine(this.PKCMJBOCADP(EEMPGLHPKJG, DPJINBCGNGN, FNEAAEFOOEJ, MCDCGPAADJA, OIOPFHOHKDC, KIDLMPIPKHL, NHCNLLNPAJP, BICHMDEIFKI, LINDILPPNNK));
		return this.genericPopupTwoButtonsGreen;
	}

	// Token: 0x060066CD RID: 26317 RVA: 0x002F8AC6 File Offset: 0x002F6CC6
	public void KPAIHLBPFMJ()
	{
		this.socialPopup.KCOEPHGAGJD();
	}

	// Token: 0x060066CE RID: 26318 RVA: 0x002F8AD3 File Offset: 0x002F6CD3
	private void Awake()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		this.Reset();
	}

	// Token: 0x060066CF RID: 26319 RVA: 0x002F7899 File Offset: 0x002F5A99
	public void DENONIECGPO()
	{
		this.mainGroup.SetActive(false);
	}

	// Token: 0x060066D0 RID: 26320 RVA: 0x002F742B File Offset: 0x002F562B
	public FullscreenLiveOfferManager GetFullscreenLiveOffer()
	{
		return this.fullScreenLiveOffer;
	}

	// Token: 0x060066D1 RID: 26321 RVA: 0x002F6937 File Offset: 0x002F4B37
	public AvatarCollectionsItem FAOAICFDKLP()
	{
		return this.avatarCollectionsItem;
	}

	// Token: 0x060066D2 RID: 26322 RVA: 0x002F8AE8 File Offset: 0x002F6CE8
	private IEnumerator KMIAJNOEMPO(string EEMPGLHPKJG, string DPJINBCGNGN, string FNEAAEFOOEJ, string MCDCGPAADJA, UnityAction OIOPFHOHKDC, UnityAction KIDLMPIPKHL, UnityAction NHCNLLNPAJP, float BICHMDEIFKI, int LINDILPPNNK)
	{
		if (BICHMDEIFKI > 0.01f)
		{
			yield return new WaitForSeconds(BICHMDEIFKI);
		}
		yield return new WaitForEndOfFrame();
		if (OIOPFHOHKDC != null)
		{
			this.genericPopupTwoButtonsBlack.SetOnClickListenerButtonPositive(OIOPFHOHKDC);
		}
		if (KIDLMPIPKHL != null)
		{
			this.genericPopupTwoButtonsBlack.SetOnClickListenerButtonNegative(KIDLMPIPKHL);
		}
		if (NHCNLLNPAJP != null)
		{
			this.genericPopupTwoButtonsBlack.SetOnClickListenerButtonClose(NHCNLLNPAJP);
		}
		this.genericPopupTwoButtonsBlack.SetFontSize(LINDILPPNNK);
		this.genericPopupTwoButtonsBlack.ShowTwoButtons(EEMPGLHPKJG, DPJINBCGNGN, FNEAAEFOOEJ, MCDCGPAADJA);
		this.delayedFullScreenBlock.SetActive(false);
		yield break;
	}

	// Token: 0x060066D3 RID: 26323 RVA: 0x002F7A18 File Offset: 0x002F5C18
	public void MPELPKNEPOO(string DIMBCOBNMAM)
	{
		if (this.connectingAnimation.gameObject.activeSelf)
		{
			this.connectingAnimationTextProgress.SetText(DIMBCOBNMAM, true);
		}
	}

	// Token: 0x060066D4 RID: 26324 RVA: 0x002F8B48 File Offset: 0x002F6D48
	private IEnumerator NDCLCFDOHEH(string EEMPGLHPKJG, string DPJINBCGNGN, string DCBPPPGKHEJ, string NENGGAECHKF, string HDOAPHHFMAP, UnityAction JBCIIEJDGJB, UnityAction HDNDIOMNBBJ, UnityAction CHMMLHPJJJL, UnityAction KIDLMPIPKHL, float BICHMDEIFKI, int LINDILPPNNK)
	{
		if (BICHMDEIFKI > 0.01f)
		{
			yield return new WaitForSeconds(BICHMDEIFKI);
		}
		yield return new WaitForEndOfFrame();
		if (JBCIIEJDGJB != null)
		{
			this.genericPopupThreeButtonsInsideBlack.SetOnClickListenerButtonPositive(JBCIIEJDGJB);
		}
		if (HDNDIOMNBBJ != null)
		{
			this.genericPopupThreeButtonsInsideBlack.SetOnClickListenerButtonOptional1(HDNDIOMNBBJ);
		}
		if (CHMMLHPJJJL != null)
		{
			this.genericPopupThreeButtonsInsideBlack.SetOnClickListenerButtonOptional2(CHMMLHPJJJL);
		}
		if (KIDLMPIPKHL != null)
		{
			this.genericPopupThreeButtonsInsideBlack.SetOnClickListenerButtonNegativeAndClose(KIDLMPIPKHL);
		}
		this.genericPopupTwoButtonsGreen.SetFontSize(LINDILPPNNK);
		this.genericPopupThreeButtonsInsideBlack.ShowThreeButtons(EEMPGLHPKJG, DPJINBCGNGN, DCBPPPGKHEJ, NENGGAECHKF, HDOAPHHFMAP);
		this.delayedFullScreenBlock.SetActive(false);
		yield break;
	}

	// Token: 0x060066D5 RID: 26325 RVA: 0x002F8BB7 File Offset: 0x002F6DB7
	public GenericPopupManager ShowGenericPopupNoButtons(string EEMPGLHPKJG, string DPJINBCGNGN, DFGILFBGPLN LAPLGLHKEJE, float BICHMDEIFKI = 0f, int LINDILPPNNK = 28)
	{
		FirebaseAnalyticsManager.EHBBFMCILPC.LogScreen(LAPLGLHKEJE.ToString());
		this.delayedFullScreenBlock.SetActive(true);
		base.StartCoroutine(this.DBPGCFMONBO(EEMPGLHPKJG, DPJINBCGNGN, BICHMDEIFKI, LINDILPPNNK));
		return this.genericPopupNoButtons;
	}

	// Token: 0x060066D6 RID: 26326 RVA: 0x002F8BF8 File Offset: 0x002F6DF8
	public GenericPopupManager GMCKGPCGDGK(string EEMPGLHPKJG, string DPJINBCGNGN, string FNEAAEFOOEJ, string MCDCGPAADJA, UnityAction OIOPFHOHKDC, UnityAction KIDLMPIPKHL, UnityAction NHCNLLNPAJP, DFGILFBGPLN LAPLGLHKEJE, float BICHMDEIFKI = 0f, int LINDILPPNNK = 28)
	{
		FirebaseAnalyticsManager.HJGDLOOHNLO().PPMBJGAHAEA(LAPLGLHKEJE.ToString());
		this.delayedFullScreenBlock.SetActive(true);
		base.StartCoroutine(this.KMIAJNOEMPO(EEMPGLHPKJG, DPJINBCGNGN, FNEAAEFOOEJ, MCDCGPAADJA, OIOPFHOHKDC, KIDLMPIPKHL, NHCNLLNPAJP, BICHMDEIFKI, LINDILPPNNK));
		return this.genericPopupTwoButtonsBlack;
	}

	// Token: 0x060066D7 RID: 26327 RVA: 0x002F8C4A File Offset: 0x002F6E4A
	public bool ConnectionAnimationEnabled()
	{
		return this.connectingAnimation.gameObject.activeSelf || this.connectingAnimationTop.gameObject.activeSelf;
	}

	// Token: 0x04001D61 RID: 7521
	private static CommonUserInterface IKLAPGJDMNA;

	// Token: 0x04001D62 RID: 7522
	public GameObject mainGroup;

	// Token: 0x04001D63 RID: 7523
	public AnimationCanvasGroupAlpha connectingAnimation;

	// Token: 0x04001D64 RID: 7524
	public TextMeshProUGUI connectingAnimationTextProgress;

	// Token: 0x04001D65 RID: 7525
	public TextMeshProUGUI connectingAnimationTextHint;

	// Token: 0x04001D66 RID: 7526
	public Image connectingAnimationFade;

	// Token: 0x04001D67 RID: 7527
	public Image connectingAnimationShadow;

	// Token: 0x04001D68 RID: 7528
	public AnimationCanvasGroupAlpha connectingAnimationTop;

	// Token: 0x04001D69 RID: 7529
	public TextMeshProUGUI connectingAnimationTopTextProgress;

	// Token: 0x04001D6A RID: 7530
	public TextMeshProUGUI connectingAnimationTopTextHint;

	// Token: 0x04001D6B RID: 7531
	public Image connectingAnimationTopFade;

	// Token: 0x04001D6C RID: 7532
	public GenericPopupManager genericPopup;

	// Token: 0x04001D6D RID: 7533
	public GenericPopupManager genericPopupNoButtons;

	// Token: 0x04001D6E RID: 7534
	public GenericPopupManager genericPopupTwoButtons;

	// Token: 0x04001D6F RID: 7535
	public GenericPopupManager genericPopupTwoButtonsBlack;

	// Token: 0x04001D70 RID: 7536
	public GenericPopupManager genericPopupTwoButtonsGreen;

	// Token: 0x04001D71 RID: 7537
	public GenericPopupManager genericPopupThreeButtonsInside;

	// Token: 0x04001D72 RID: 7538
	public GenericPopupManager genericPopupThreeButtonsInsideBlack;

	// Token: 0x04001D73 RID: 7539
	public GenericPopupManager genericPopupFourButtonsInside;

	// Token: 0x04001D74 RID: 7540
	public GenericPopupManager genericPopupFourButtonsInsideBlack;

	// Token: 0x04001D75 RID: 7541
	public PopupSettingsManager settingsPopup;

	// Token: 0x04001D76 RID: 7542
	public PopupGamePassSettingsManager gamePassSettingsPopup;

	// Token: 0x04001D77 RID: 7543
	public PopupSocialSelect socialPopup;

	// Token: 0x04001D78 RID: 7544
	public PopupRemoveAdsManager popupRemoveAds;

	// Token: 0x04001D79 RID: 7545
	public PopupOnlineResources popupOnlineResources;

	// Token: 0x04001D7A RID: 7546
	public PopupGenericNotification popupGenericNotification;

	// Token: 0x04001D7B RID: 7547
	public PopupPromoCodes popupPromoCodes;

	// Token: 0x04001D7C RID: 7548
	public PopupUsernameInput popupUsernameInput;

	// Token: 0x04001D7D RID: 7549
	public PopupPasswordInput popupPasswordInput;

	// Token: 0x04001D7E RID: 7550
	public PopupProfileNicknameInput popupProfileNicknameInput;

	// Token: 0x04001D7F RID: 7551
	public PopupProfileUIDInput popupProfileUIDInput;

	// Token: 0x04001D80 RID: 7552
	public PopupSaveSlotInput popupSaveSlotInput;

	// Token: 0x04001D81 RID: 7553
	public PopupSketchesInput popupSketchesInput;

	// Token: 0x04001D82 RID: 7554
	public PopupAvatarCollectionsInput avatarCollectionsInput;

	// Token: 0x04001D83 RID: 7555
	public PopupProfileCredoInput popupProfileCredoInput;

	// Token: 0x04001D84 RID: 7556
	public PopupProfileLoveInput popupProfileLoveInput;

	// Token: 0x04001D85 RID: 7557
	public PopupProfileMessageInput popupProfileMessageInput;

	// Token: 0x04001D86 RID: 7558
	public PopupProfileSaveCutsceneInput popupProfileSaveCutsceneInput;

	// Token: 0x04001D87 RID: 7559
	public PopupOfferManager popupOfferManager;

	// Token: 0x04001D88 RID: 7560
	public PassesItem popupGamePasses;

	// Token: 0x04001D89 RID: 7561
	public SkinShopItem popupSkinShop;

	// Token: 0x04001D8A RID: 7562
	public AvatarCollectionsItem avatarCollectionsItem;

	// Token: 0x04001D8B RID: 7563
	public GameObject fullScreenBlock;

	// Token: 0x04001D8C RID: 7564
	public GameObject delayedFullScreenBlock;

	// Token: 0x04001D8D RID: 7565
	public GameObject restartFade;

	// Token: 0x04001D8E RID: 7566
	public FaderManager fader;

	// Token: 0x04001D8F RID: 7567
	public PopupStoryRestartManager storyRestartPopup;

	// Token: 0x04001D90 RID: 7568
	public FullscreenLiveOfferManager fullScreenLiveOffer;

	// Token: 0x04001D91 RID: 7569
	private bool DFEEFCBHMLF;

	// Token: 0x04001D92 RID: 7570
	private bool GFAMDMIEPFG;
}
