using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x02000138 RID: 312
public class FriendsLetterPopupManager : MonoBehaviour
{
	// Token: 0x06002929 RID: 10537 RVA: 0x001274A0 File Offset: 0x001256A0
	private void OFCDDOMLNAH(PMEPALPCEAF NAALFKKPAPG, PMEPALPCEAF IPOIHLJGCEA)
	{
		if (IPOIHLJGCEA != null)
		{
			this.friendImage.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.DJNLJPFFMBG(IPOIHLJGCEA.PGJBIPFBMAN());
			string text;
			if (IPOIHLJGCEA.KNCFKDLOPGA.Length == 0)
			{
				text = "<" + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("profilenametitleshort") + ">";
			}
			else
			{
				text = IPOIHLJGCEA.KNCFKDLOPGA;
			}
			this.friendTitleText.SetText(text, true);
			this.friendTitleText.text = text;
			if (NAALFKKPAPG != null)
			{
				if (NAALFKKPAPG.JNNBNNDOGIM.FNDNDILCFNN(IPOIHLJGCEA))
				{
					this.heartImage.SetActive(true);
				}
				else
				{
					this.heartImage.SetActive(false);
				}
			}
			else
			{
				this.heartImage.SetActive(false);
			}
			this.matchNumberText.SetText(IPOIHLJGCEA.OFOIECEHOCN.ToString() ?? "", true);
			this.matchNumberText.text = (IPOIHLJGCEA.OFOIECEHOCN.ToString() ?? "");
		}
	}

	// Token: 0x0600292A RID: 10538 RVA: 0x0012759F File Offset: 0x0012579F
	private IEnumerator AHFFNJNGGAD(string DKNNMLIDPHH, string BBDKMDOBBAD, PMEPALPCEAF NAALFKKPAPG, PMEPALPCEAF IPOIHLJGCEA)
	{
		yield return new WaitForSeconds(1f);
		this.messageContainer.SetActive(true);
		this.DGLBFPCNBKF(DKNNMLIDPHH, BBDKMDOBBAD, NAALFKKPAPG, IPOIHLJGCEA);
		yield return new WaitForSeconds(2f);
		this.buttonObject.gameObject.SetActive(true);
		this.buttonText.text = BBDKMDOBBAD;
		this.buttonText.SetText(BBDKMDOBBAD, true);
		yield break;
	}

	// Token: 0x0600292B RID: 10539 RVA: 0x001275CB File Offset: 0x001257CB
	public void ShowLetterDisappearAnimation()
	{
		this.OnProceedClick();
	}

	// Token: 0x0600292C RID: 10540 RVA: 0x001275D3 File Offset: 0x001257D3
	public void CKNCEKFOLKD()
	{
		this.friendImage.sprite = null;
	}

	// Token: 0x0600292D RID: 10541 RVA: 0x001275E1 File Offset: 0x001257E1
	public void LMGPLCEBGIF()
	{
		this.Hide();
	}

	// Token: 0x0600292E RID: 10542 RVA: 0x001275E9 File Offset: 0x001257E9
	private void NBPOEPLJMJD(string DKNNMLIDPHH, string BBDKMDOBBAD, PMEPALPCEAF NAALFKKPAPG, PMEPALPCEAF IPOIHLJGCEA)
	{
		this.BBCBACCJJKG(NAALFKKPAPG, IPOIHLJGCEA);
		this.messageText.text = DKNNMLIDPHH;
		this.messageText.SetText(DKNNMLIDPHH, false);
	}

	// Token: 0x0600292F RID: 10543 RVA: 0x0012760D File Offset: 0x0012580D
	private IEnumerator BFHDBIKLCFD(string DKNNMLIDPHH, string BBDKMDOBBAD, PMEPALPCEAF NAALFKKPAPG, PMEPALPCEAF IPOIHLJGCEA)
	{
		FriendsLetterPopupManager.CFIACOODNFM cfiacoodnfm = new FriendsLetterPopupManager.CFIACOODNFM(1);
		cfiacoodnfm.<>4__this = this;
		cfiacoodnfm._message = DKNNMLIDPHH;
		cfiacoodnfm._button = BBDKMDOBBAD;
		cfiacoodnfm._oursProfile = NAALFKKPAPG;
		cfiacoodnfm._theirsProfile = IPOIHLJGCEA;
		return cfiacoodnfm;
	}

	// Token: 0x06002930 RID: 10544 RVA: 0x00127639 File Offset: 0x00125839
	public void Hide()
	{
		this.animatedPopupManager.Hide();
	}

	// Token: 0x06002931 RID: 10545 RVA: 0x00127648 File Offset: 0x00125848
	public void NCCDIMGKFGA(bool DHLAMFCAHPJ, string EMGMCANANEJ)
	{
		this.BJOAHAFFEHN = EMGMCANANEJ;
		this.animatedPopupManager.NBLIPHEJOPH(1, 0, true);
		base.gameObject.SetActive(false);
		if (DHLAMFCAHPJ)
		{
			this.closedLetter.gameObject.SetActive(false);
			this.openLetter.gameObject.SetActive(false);
			return;
		}
		this.closedLetter.gameObject.SetActive(false);
		this.openLetter.gameObject.SetActive(false);
	}

	// Token: 0x06002932 RID: 10546 RVA: 0x001276BE File Offset: 0x001258BE
	public void OnProceedClick()
	{
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC(this.BJOAHAFFEHN, 0f);
		this.BJOAHAFFEHN = "";
		this.Hide();
	}

	// Token: 0x06002933 RID: 10547 RVA: 0x001276E6 File Offset: 0x001258E6
	private void OnEnable()
	{
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnSystemBackButton", new UnityAction(this.OnSystemBackButton));
		this.messageContainer.SetActive(false);
		this.buttonObject.SetActive(false);
	}

	// Token: 0x06002934 RID: 10548 RVA: 0x0012771C File Offset: 0x0012591C
	public void ShowLetterAppearAnimation(bool DHLAMFCAHPJ, string EMGMCANANEJ)
	{
		this.BJOAHAFFEHN = EMGMCANANEJ;
		this.animatedPopupManager.SetAnimationProperties(1, 1, false);
		base.gameObject.SetActive(true);
		if (DHLAMFCAHPJ)
		{
			this.closedLetter.gameObject.SetActive(true);
			this.openLetter.gameObject.SetActive(false);
			return;
		}
		this.closedLetter.gameObject.SetActive(false);
		this.openLetter.gameObject.SetActive(true);
	}

	// Token: 0x06002935 RID: 10549 RVA: 0x001275D3 File Offset: 0x001257D3
	public void PFEIKOLDANA()
	{
		this.friendImage.sprite = null;
	}

	// Token: 0x06002936 RID: 10550 RVA: 0x00127792 File Offset: 0x00125992
	public void JPGFBBKJMIA()
	{
		this.CIPJGJJBAML();
	}

	// Token: 0x06002937 RID: 10551 RVA: 0x00003E52 File Offset: 0x00002052
	private void GBPFDKIIHJG()
	{
	}

	// Token: 0x06002938 RID: 10552 RVA: 0x000022C3 File Offset: 0x000004C3
	private void GBKJFCMFOHA()
	{
		AppManager.isQuitting = false;
	}

	// Token: 0x06002939 RID: 10553 RVA: 0x0012779C File Offset: 0x0012599C
	public void ShowLetterReceivedAnimation(bool DHLAMFCAHPJ, string DKNNMLIDPHH, string BBDKMDOBBAD, PMEPALPCEAF NAALFKKPAPG, PMEPALPCEAF IPOIHLJGCEA, string EMGMCANANEJ)
	{
		this.BJOAHAFFEHN = EMGMCANANEJ;
		this.animatedPopupManager.SetAnimationProperties(1, -1, false);
		base.gameObject.SetActive(true);
		if (DHLAMFCAHPJ)
		{
			this.closedLetter.gameObject.SetActive(true);
			this.openLetter.gameObject.SetActive(false);
		}
		else
		{
			this.closedLetter.gameObject.SetActive(false);
			this.openLetter.gameObject.SetActive(true);
		}
		base.StartCoroutine(this.MPJOIFCFIOE(DKNNMLIDPHH, BBDKMDOBBAD, NAALFKKPAPG, IPOIHLJGCEA));
	}

	// Token: 0x0600293A RID: 10554 RVA: 0x00002296 File Offset: 0x00000496
	private void OnApplicationQuit()
	{
		AppManager.isQuitting = true;
	}

	// Token: 0x0600293B RID: 10555 RVA: 0x00127828 File Offset: 0x00125A28
	private void GIHIKHJGOHN()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		this.messageContainer.SetActive(true);
		this.buttonObject.SetActive(true);
		this.friendImage.sprite = null;
		AOBJLALDBAA.FILDBDMENPG().NAMMLDPCHJO("lsc", new UnityAction(this.LMGPLCEBGIF));
	}

	// Token: 0x0600293C RID: 10556 RVA: 0x0012787C File Offset: 0x00125A7C
	private void MGCNIABEDNL()
	{
		AOBJLALDBAA.NMGMNAKLLMI().MFIMALJPCDP("", new UnityAction(this.LMGPLCEBGIF));
		this.messageContainer.SetActive(true);
		this.buttonObject.SetActive(false);
	}

	// Token: 0x0600293D RID: 10557 RVA: 0x001275D3 File Offset: 0x001257D3
	public void CEFBBPMOADD()
	{
		this.friendImage.sprite = null;
	}

	// Token: 0x0600293E RID: 10558 RVA: 0x0012759F File Offset: 0x0012579F
	private IEnumerator MPJOIFCFIOE(string DKNNMLIDPHH, string BBDKMDOBBAD, PMEPALPCEAF NAALFKKPAPG, PMEPALPCEAF IPOIHLJGCEA)
	{
		yield return new WaitForSeconds(1f);
		this.messageContainer.SetActive(true);
		this.DGLBFPCNBKF(DKNNMLIDPHH, BBDKMDOBBAD, NAALFKKPAPG, IPOIHLJGCEA);
		yield return new WaitForSeconds(2f);
		this.buttonObject.gameObject.SetActive(true);
		this.buttonText.text = BBDKMDOBBAD;
		this.buttonText.SetText(BBDKMDOBBAD, true);
		yield break;
	}

	// Token: 0x0600293F RID: 10559 RVA: 0x0012760D File Offset: 0x0012580D
	private IEnumerator DDHCPEKFIFD(string DKNNMLIDPHH, string BBDKMDOBBAD, PMEPALPCEAF NAALFKKPAPG, PMEPALPCEAF IPOIHLJGCEA)
	{
		FriendsLetterPopupManager.CFIACOODNFM cfiacoodnfm = new FriendsLetterPopupManager.CFIACOODNFM(1);
		cfiacoodnfm.<>4__this = this;
		cfiacoodnfm._message = DKNNMLIDPHH;
		cfiacoodnfm._button = BBDKMDOBBAD;
		cfiacoodnfm._oursProfile = NAALFKKPAPG;
		cfiacoodnfm._theirsProfile = IPOIHLJGCEA;
		return cfiacoodnfm;
	}

	// Token: 0x06002941 RID: 10561 RVA: 0x001275E1 File Offset: 0x001257E1
	public void ODHLJLFCIFP()
	{
		this.Hide();
	}

	// Token: 0x06002942 RID: 10562 RVA: 0x001275D3 File Offset: 0x001257D3
	public void OHNEKLLPBDN()
	{
		this.friendImage.sprite = null;
	}

	// Token: 0x06002943 RID: 10563 RVA: 0x001275D3 File Offset: 0x001257D3
	public void LFEEHGLHJDN()
	{
		this.friendImage.sprite = null;
	}

	// Token: 0x06002944 RID: 10564 RVA: 0x001278C4 File Offset: 0x00125AC4
	private void OnDisable()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		this.messageContainer.SetActive(false);
		this.buttonObject.SetActive(false);
		this.friendImage.sprite = null;
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnSystemBackButton", new UnityAction(this.OnSystemBackButton));
	}

	// Token: 0x06002945 RID: 10565 RVA: 0x001275E1 File Offset: 0x001257E1
	public void OnSystemBackButton()
	{
		this.Hide();
	}

	// Token: 0x06002946 RID: 10566 RVA: 0x001275D3 File Offset: 0x001257D3
	public void OnDestroy()
	{
		this.friendImage.sprite = null;
	}

	// Token: 0x06002947 RID: 10567 RVA: 0x00127918 File Offset: 0x00125B18
	private void BBCBACCJJKG(PMEPALPCEAF NAALFKKPAPG, PMEPALPCEAF IPOIHLJGCEA)
	{
		if (IPOIHLJGCEA != null)
		{
			this.friendImage.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.NFOFFLDJDEI(IPOIHLJGCEA.PGJBIPFBMAN());
			string text;
			if (IPOIHLJGCEA.KNCFKDLOPGA.Length == 0)
			{
				text = " " + CCOJBMMKNAP.CEGAOMEEFBE().OHLNGCKIACD("e") + "copyrightlobby";
			}
			else
			{
				text = IPOIHLJGCEA.KNCFKDLOPGA;
			}
			this.friendTitleText.SetText(text, false);
			this.friendTitleText.text = text;
			if (NAALFKKPAPG != null)
			{
				if (NAALFKKPAPG.JNNBNNDOGIM.FNDNDILCFNN(IPOIHLJGCEA))
				{
					this.heartImage.SetActive(false);
				}
				else
				{
					this.heartImage.SetActive(true);
				}
			}
			else
			{
				this.heartImage.SetActive(true);
			}
			this.matchNumberText.SetText(IPOIHLJGCEA.OFOIECEHOCN.ToString() ?? "spinsbuttoncustomize", true);
			this.matchNumberText.text = (IPOIHLJGCEA.OFOIECEHOCN.ToString() ?? "$nl");
		}
	}

	// Token: 0x06002948 RID: 10568 RVA: 0x00127A18 File Offset: 0x00125C18
	private void FOHMEJDIILN()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		this.messageContainer.SetActive(true);
		this.buttonObject.SetActive(false);
		this.friendImage.sprite = null;
		AOBJLALDBAA.FILDBDMENPG().POLEDPIKODD("cardcollectcardismissingbody", new UnityAction(this.OnSystemBackButton));
	}

	// Token: 0x06002949 RID: 10569 RVA: 0x00127792 File Offset: 0x00125992
	public void NNMNCAFENAP()
	{
		this.CIPJGJJBAML();
	}

	// Token: 0x0600294A RID: 10570 RVA: 0x00127A6C File Offset: 0x00125C6C
	private void DGLBFPCNBKF(string DKNNMLIDPHH, string BBDKMDOBBAD, PMEPALPCEAF NAALFKKPAPG, PMEPALPCEAF IPOIHLJGCEA)
	{
		this.OFCDDOMLNAH(NAALFKKPAPG, IPOIHLJGCEA);
		this.messageText.text = DKNNMLIDPHH;
		this.messageText.SetText(DKNNMLIDPHH, true);
	}

	// Token: 0x0600294B RID: 10571 RVA: 0x00003E52 File Offset: 0x00002052
	private void Awake()
	{
	}

	// Token: 0x0600294C RID: 10572 RVA: 0x00127A90 File Offset: 0x00125C90
	private void BAKEPAJJBOK(PMEPALPCEAF NAALFKKPAPG, PMEPALPCEAF IPOIHLJGCEA)
	{
		if (IPOIHLJGCEA != null)
		{
			this.friendImage.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.AHBHMAGKMJJ(IPOIHLJGCEA.PGJBIPFBMAN());
			string text;
			if (IPOIHLJGCEA.KNCFKDLOPGA.Length == 0)
			{
				text = "" + CCOJBMMKNAP.MLFAGAAJJEM().DNILNCLIHAP("") + "OnPopupSketchesInputEndEdit";
			}
			else
			{
				text = IPOIHLJGCEA.KNCFKDLOPGA;
			}
			this.friendTitleText.SetText(text, false);
			this.friendTitleText.text = text;
			if (NAALFKKPAPG != null)
			{
				if (NAALFKKPAPG.JNNBNNDOGIM.FNDNDILCFNN(IPOIHLJGCEA))
				{
					this.heartImage.SetActive(true);
				}
				else
				{
					this.heartImage.SetActive(false);
				}
			}
			else
			{
				this.heartImage.SetActive(false);
			}
			this.matchNumberText.SetText(IPOIHLJGCEA.OFOIECEHOCN.ToString() ?? "BackendOperationsManager.RequestGetHallOfFame, exception while initializing RSACryptoServiceProvider:", true);
			this.matchNumberText.text = (IPOIHLJGCEA.OFOIECEHOCN.ToString() ?? "eval");
		}
	}

	// Token: 0x0600294D RID: 10573 RVA: 0x00127B8F File Offset: 0x00125D8F
	public void CIPJGJJBAML()
	{
		AOBJLALDBAA.KKPFOJMAONG().EFBNBFIDEOK(this.BJOAHAFFEHN, 1998f);
		this.BJOAHAFFEHN = "body";
		this.Hide();
	}

	// Token: 0x04000C9C RID: 3228
	public AnimatedPopupManager animatedPopupManager;

	// Token: 0x04000C9D RID: 3229
	public const string onSystemBackButton = "OnSystemBackButton";

	// Token: 0x04000C9E RID: 3230
	public Image friendImage;

	// Token: 0x04000C9F RID: 3231
	public TextMeshProUGUI friendTitleText;

	// Token: 0x04000CA0 RID: 3232
	public GameObject heartImage;

	// Token: 0x04000CA1 RID: 3233
	public TextMeshProUGUI matchNumberText;

	// Token: 0x04000CA2 RID: 3234
	public TextMeshProUGUI buttonText;

	// Token: 0x04000CA3 RID: 3235
	public GameObject messageContainer;

	// Token: 0x04000CA4 RID: 3236
	public TextMeshProUGUI messageText;

	// Token: 0x04000CA5 RID: 3237
	public GameObject buttonObject;

	// Token: 0x04000CA6 RID: 3238
	public GameObject closedLetter;

	// Token: 0x04000CA7 RID: 3239
	public GameObject openLetter;

	// Token: 0x04000CA8 RID: 3240
	private string BJOAHAFFEHN = "";
}
