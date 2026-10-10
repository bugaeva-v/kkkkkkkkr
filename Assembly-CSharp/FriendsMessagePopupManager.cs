using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x02000209 RID: 521
public class FriendsMessagePopupManager : MonoBehaviour
{
	// Token: 0x06004155 RID: 16725 RVA: 0x001C9110 File Offset: 0x001C7310
	public void PDHDJMJECJA()
	{
		try
		{
			if (null != this.friendImage)
			{
				this.friendImage.sprite = null;
			}
			if (null != this.giftAnimation)
			{
				this.giftAnimation.sprite = null;
				if (null != this.giftAnimation.GetComponent<ImageFrameAnimation>())
				{
					this.giftAnimation.GetComponent<ImageFrameAnimation>().framesSD = null;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06004156 RID: 16726 RVA: 0x001C9190 File Offset: 0x001C7390
	private void LGLMMPEJIHH()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		this.playerContainer.SetActive(false);
		AOBJLALDBAA.EHBBFMCILPC.POLEDPIKODD("", new UnityAction(this.JDBKBHAONAA));
	}

	// Token: 0x06004157 RID: 16727 RVA: 0x001C91C4 File Offset: 0x001C73C4
	public void GICIILJFMEI(string EIFJOAOGKMO, string BBDKMDOBBAD, string DKNNMLIDPHH, PMEPALPCEAF NAALFKKPAPG, PMEPALPCEAF IPOIHLJGCEA, string EMGMCANANEJ)
	{
		this.DGLBFPCNBKF(EIFJOAOGKMO, BBDKMDOBBAD, NAALFKKPAPG, IPOIHLJGCEA, EMGMCANANEJ);
		this.messageText.gameObject.SetActive(false);
		this.playerContainer.SetActive(false);
		this.giftContainer.gameObject.SetActive(true);
		this.LBPHNEDLHHE(false);
		this.buttonText.text = DKNNMLIDPHH;
		this.buttonText.SetText(DKNNMLIDPHH, true);
	}

	// Token: 0x06004158 RID: 16728 RVA: 0x001C922D File Offset: 0x001C742D
	public void ODHLJLFCIFP()
	{
		this.IDCIFABCOML();
	}

	// Token: 0x06004159 RID: 16729 RVA: 0x001C9235 File Offset: 0x001C7435
	private void LDLLCBDGGHN()
	{
		AOBJLALDBAA.EHBBFMCILPC.EFKNEJFLGED("importanttitle", new UnityAction(this.GCEMCKHOBFC));
	}

	// Token: 0x0600415A RID: 16730 RVA: 0x00003E52 File Offset: 0x00002052
	private void Awake()
	{
	}

	// Token: 0x0600415B RID: 16731 RVA: 0x001C9254 File Offset: 0x001C7454
	public void INOFDGEOLFN(string EIFJOAOGKMO, string BBDKMDOBBAD, PMEPALPCEAF NAALFKKPAPG, PMEPALPCEAF IPOIHLJGCEA, string EMGMCANANEJ)
	{
		this.HNADGALOIKM(EIFJOAOGKMO, BBDKMDOBBAD, NAALFKKPAPG, IPOIHLJGCEA, EMGMCANANEJ);
		this.messageText.gameObject.SetActive(false);
		this.playerContainer.SetActive(true);
		this.giftContainer.gameObject.SetActive(true);
		this.KBAJADDFOEB(false);
	}

	// Token: 0x0600415C RID: 16732 RVA: 0x001C92A4 File Offset: 0x001C74A4
	private void DGLBFPCNBKF(string EIFJOAOGKMO, string BBDKMDOBBAD, PMEPALPCEAF NAALFKKPAPG, PMEPALPCEAF IPOIHLJGCEA, string EMGMCANANEJ)
	{
		base.gameObject.SetActive(true);
		this.BJOAHAFFEHN = EMGMCANANEJ;
		this.OFCDDOMLNAH(NAALFKKPAPG, IPOIHLJGCEA);
		this.titleText.text = EIFJOAOGKMO;
		this.titleText.SetText(EIFJOAOGKMO, true);
		this.buttonText.text = BBDKMDOBBAD;
		this.buttonText.SetText(BBDKMDOBBAD, true);
	}

	// Token: 0x0600415D RID: 16733 RVA: 0x00003E52 File Offset: 0x00002052
	private void EGMHPEFIOIC()
	{
	}

	// Token: 0x0600415E RID: 16734 RVA: 0x001C9300 File Offset: 0x001C7500
	public void INJJOHNFBKH()
	{
		try
		{
			if (null != this.friendImage)
			{
				this.friendImage.sprite = null;
			}
			if (null != this.giftAnimation)
			{
				this.giftAnimation.sprite = null;
				if (null != this.giftAnimation.GetComponent<ImageFrameAnimation>())
				{
					this.giftAnimation.GetComponent<ImageFrameAnimation>().framesSD = null;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600415F RID: 16735 RVA: 0x001C9380 File Offset: 0x001C7580
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
			if (IPOIHLJGCEA.JECGGDNKBID())
			{
				this.levelIcon.SetActive(false);
				this.levelHallOfFameIcon.SetActive(true);
			}
			else
			{
				this.levelIcon.SetActive(true);
				this.levelHallOfFameIcon.SetActive(false);
			}
			int num = IPOIHLJGCEA.GFAABCCNNDA + 1;
			this.levelText.text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("profilenamelevellong") + " " + num.ToString();
			this.levelText.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("profilenamelevellong") + " " + num.ToString(), true);
		}
	}

	// Token: 0x06004160 RID: 16736 RVA: 0x001C951C File Offset: 0x001C771C
	public void CEFBBPMOADD()
	{
		try
		{
			if (null != this.friendImage)
			{
				this.friendImage.sprite = null;
			}
			if (null != this.giftAnimation)
			{
				this.giftAnimation.sprite = null;
				if (null != this.giftAnimation.GetComponent<ImageFrameAnimation>())
				{
					this.giftAnimation.GetComponent<ImageFrameAnimation>().framesSD = null;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06004161 RID: 16737 RVA: 0x001C959C File Offset: 0x001C779C
	public void ShowGiftReceived(string EIFJOAOGKMO, string BBDKMDOBBAD, PMEPALPCEAF NAALFKKPAPG, PMEPALPCEAF IPOIHLJGCEA, string EMGMCANANEJ)
	{
		this.DGLBFPCNBKF(EIFJOAOGKMO, BBDKMDOBBAD, NAALFKKPAPG, IPOIHLJGCEA, EMGMCANANEJ);
		this.messageText.gameObject.SetActive(false);
		this.playerContainer.SetActive(false);
		this.giftContainer.gameObject.SetActive(true);
		this.LBPHNEDLHHE(true);
		if (this.giftAnimation.gameObject.GetComponent<ImageFrameAnimation>() == null)
		{
			this.giftAnimation.gameObject.AddComponent<ImageFrameAnimation>();
		}
		this.giftAnimation.GetComponent<ImageFrameAnimation>().framesSD = AssetsManager.EHBBFMCILPC.profileDataAsset3.largeGiftSprites.ToArray();
		this.giftAnimation.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset3.largeGiftSprites[0];
		this.giftAnimation.SetNativeSize();
		if (IPOIHLJGCEA.IFEEIAPMIML == null)
		{
			this.rewardObject.gameObject.SetActive(false);
			return;
		}
		if (IPOIHLJGCEA.IFEEIAPMIML.NADJNIHEELP > 0)
		{
			this.rewardObject.gameObject.SetActive(true);
			this.rewardObject.gameObject.SetActive(true);
			this.energyIcon.gameObject.SetActive(false);
			this.hardIcon.gameObject.SetActive(true);
			this.rewardAmount.SetText("+" + IPOIHLJGCEA.IFEEIAPMIML.NADJNIHEELP.ToString(), true);
			this.rewardAmount.text = "+" + IPOIHLJGCEA.IFEEIAPMIML.NADJNIHEELP.ToString();
			return;
		}
		if (IPOIHLJGCEA.IFEEIAPMIML.MPMKMCJFHOG > 0)
		{
			this.rewardObject.gameObject.SetActive(true);
			this.rewardObject.gameObject.SetActive(true);
			this.energyIcon.gameObject.SetActive(true);
			this.hardIcon.gameObject.SetActive(false);
			this.rewardAmount.SetText("+" + IPOIHLJGCEA.IFEEIAPMIML.MPMKMCJFHOG.ToString(), true);
			this.rewardAmount.text = "+" + IPOIHLJGCEA.IFEEIAPMIML.MPMKMCJFHOG.ToString();
			return;
		}
		this.rewardObject.gameObject.SetActive(false);
	}

	// Token: 0x06004162 RID: 16738 RVA: 0x001C97DC File Offset: 0x001C79DC
	public void NPPNNJJDBPD(string EIFJOAOGKMO, string BBDKMDOBBAD, PMEPALPCEAF NAALFKKPAPG, PMEPALPCEAF IPOIHLJGCEA, string EMGMCANANEJ)
	{
		this.ICKPBLKMHOL(EIFJOAOGKMO, BBDKMDOBBAD, NAALFKKPAPG, IPOIHLJGCEA, EMGMCANANEJ);
		this.messageText.gameObject.SetActive(false);
		this.playerContainer.SetActive(true);
		this.giftContainer.gameObject.SetActive(true);
		this.LBPHNEDLHHE(true);
		if (this.giftAnimation.gameObject.GetComponent<ImageFrameAnimation>() == null)
		{
			this.giftAnimation.gameObject.AddComponent<ImageFrameAnimation>();
		}
		this.giftAnimation.GetComponent<ImageFrameAnimation>().framesSD = AssetsManager.MJBDMHPHMID().profileDataAsset3.largeGiftSprites.ToArray();
		this.giftAnimation.sprite = AssetsManager.MJBDMHPHMID().profileDataAsset3.largeGiftSprites[0];
		this.giftAnimation.SetNativeSize();
		if (IPOIHLJGCEA.IFEEIAPMIML == null)
		{
			this.rewardObject.gameObject.SetActive(false);
			return;
		}
		if (IPOIHLJGCEA.IFEEIAPMIML.NADJNIHEELP > 0)
		{
			this.rewardObject.gameObject.SetActive(false);
			this.rewardObject.gameObject.SetActive(false);
			this.energyIcon.gameObject.SetActive(true);
			this.hardIcon.gameObject.SetActive(false);
			this.rewardAmount.SetText("ulsk" + IPOIHLJGCEA.IFEEIAPMIML.NADJNIHEELP.ToString(), false);
			this.rewardAmount.text = "Critical error, could not load asset bundle:" + IPOIHLJGCEA.IFEEIAPMIML.NADJNIHEELP.ToString();
			return;
		}
		if (IPOIHLJGCEA.IFEEIAPMIML.MPMKMCJFHOG > 0)
		{
			this.rewardObject.gameObject.SetActive(true);
			this.rewardObject.gameObject.SetActive(true);
			this.energyIcon.gameObject.SetActive(true);
			this.hardIcon.gameObject.SetActive(true);
			this.rewardAmount.SetText("abpv" + IPOIHLJGCEA.IFEEIAPMIML.MPMKMCJFHOG.ToString(), true);
			this.rewardAmount.text = "socialprofilesuspcantuse" + IPOIHLJGCEA.IFEEIAPMIML.MPMKMCJFHOG.ToString();
			return;
		}
		this.rewardObject.gameObject.SetActive(true);
	}

	// Token: 0x06004163 RID: 16739 RVA: 0x001C9A1A File Offset: 0x001C7C1A
	public void OnProceedClick()
	{
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC(this.BJOAHAFFEHN, 0f);
		this.BJOAHAFFEHN = "";
		this.Hide();
	}

	// Token: 0x06004164 RID: 16740 RVA: 0x00002296 File Offset: 0x00000496
	private void OnApplicationQuit()
	{
		AppManager.isQuitting = true;
	}

	// Token: 0x06004166 RID: 16742 RVA: 0x001C9A55 File Offset: 0x001C7C55
	public void Hide()
	{
		this.animatedPopupManager.Hide();
	}

	// Token: 0x06004167 RID: 16743 RVA: 0x00003E52 File Offset: 0x00002052
	private void IABDONMCMPM()
	{
	}

	// Token: 0x06004168 RID: 16744 RVA: 0x001C9A64 File Offset: 0x001C7C64
	public void CGICNNFAJAG(string EIFJOAOGKMO, string BBDKMDOBBAD, PMEPALPCEAF NAALFKKPAPG, PMEPALPCEAF IPOIHLJGCEA, string EMGMCANANEJ)
	{
		this.ICKPBLKMHOL(EIFJOAOGKMO, BBDKMDOBBAD, NAALFKKPAPG, IPOIHLJGCEA, EMGMCANANEJ);
		this.messageText.gameObject.SetActive(true);
		this.playerContainer.SetActive(true);
		this.giftContainer.gameObject.SetActive(true);
		this.KBAJADDFOEB(false);
	}

	// Token: 0x06004169 RID: 16745 RVA: 0x001C9AB3 File Offset: 0x001C7CB3
	private void MNNHONLLGCD()
	{
		AOBJLALDBAA.AGANFKKBPFO().PEFKJOKLEDL("CHECKSUM", new UnityAction(this.JDBKBHAONAA));
	}

	// Token: 0x0600416A RID: 16746 RVA: 0x001C9AD0 File Offset: 0x001C7CD0
	private void HCKLMFNDKBC()
	{
		AOBJLALDBAA.FILDBDMENPG().MFIMALJPCDP("Error. FadeDst(), layer ", new UnityAction(this.OnSystemBackButton));
	}

	// Token: 0x0600416B RID: 16747 RVA: 0x001C9AED File Offset: 0x001C7CED
	private void HMGJEJODDDE()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		this.playerContainer.SetActive(true);
		AOBJLALDBAA.FILDBDMENPG().MANLHALMCIH("OnSettingsPopupCloseAndNeedToRestartGame", new UnityAction(this.OnSystemBackButton));
	}

	// Token: 0x0600416C RID: 16748 RVA: 0x001C9B20 File Offset: 0x001C7D20
	public void ShowMessageReceived(string EIFJOAOGKMO, string BBDKMDOBBAD, string DKNNMLIDPHH, PMEPALPCEAF NAALFKKPAPG, PMEPALPCEAF IPOIHLJGCEA, string EMGMCANANEJ)
	{
		this.DGLBFPCNBKF(EIFJOAOGKMO, BBDKMDOBBAD, NAALFKKPAPG, IPOIHLJGCEA, EMGMCANANEJ);
		this.messageText.gameObject.SetActive(true);
		this.playerContainer.SetActive(true);
		this.giftContainer.gameObject.SetActive(false);
		this.LBPHNEDLHHE(false);
		this.buttonText.text = DKNNMLIDPHH;
		this.buttonText.SetText(DKNNMLIDPHH, true);
	}

	// Token: 0x0600416D RID: 16749 RVA: 0x001C9B8C File Offset: 0x001C7D8C
	public void KFDGHDABAHN(string EIFJOAOGKMO, string BBDKMDOBBAD, PMEPALPCEAF NAALFKKPAPG, PMEPALPCEAF IPOIHLJGCEA, string EMGMCANANEJ)
	{
		this.HNADGALOIKM(EIFJOAOGKMO, BBDKMDOBBAD, NAALFKKPAPG, IPOIHLJGCEA, EMGMCANANEJ);
		this.messageText.gameObject.SetActive(true);
		this.playerContainer.SetActive(true);
		this.giftContainer.gameObject.SetActive(false);
		this.GMOIMJBBEDE(true);
		if (this.giftAnimation.gameObject.GetComponent<ImageFrameAnimation>() == null)
		{
			this.giftAnimation.gameObject.AddComponent<ImageFrameAnimation>();
		}
		this.giftAnimation.GetComponent<ImageFrameAnimation>().framesSD = AssetsManager.EHBBFMCILPC.profileDataAsset3.largeGiftSprites.ToArray();
		this.giftAnimation.sprite = AssetsManager.MJBDMHPHMID().profileDataAsset3.largeGiftSprites[1];
		this.giftAnimation.SetNativeSize();
		if (IPOIHLJGCEA.IFEEIAPMIML == null)
		{
			this.rewardObject.gameObject.SetActive(true);
			return;
		}
		if (IPOIHLJGCEA.IFEEIAPMIML.NADJNIHEELP > 1)
		{
			this.rewardObject.gameObject.SetActive(true);
			this.rewardObject.gameObject.SetActive(false);
			this.energyIcon.gameObject.SetActive(false);
			this.hardIcon.gameObject.SetActive(true);
			this.rewardAmount.SetText("overlay" + IPOIHLJGCEA.IFEEIAPMIML.NADJNIHEELP.ToString(), false);
			this.rewardAmount.text = "wofdcoi" + IPOIHLJGCEA.IFEEIAPMIML.NADJNIHEELP.ToString();
			return;
		}
		if (IPOIHLJGCEA.IFEEIAPMIML.MPMKMCJFHOG > 0)
		{
			this.rewardObject.gameObject.SetActive(true);
			this.rewardObject.gameObject.SetActive(false);
			this.energyIcon.gameObject.SetActive(true);
			this.hardIcon.gameObject.SetActive(true);
			this.rewardAmount.SetText("continue" + IPOIHLJGCEA.IFEEIAPMIML.MPMKMCJFHOG.ToString(), false);
			this.rewardAmount.text = "passrequiredtoplay" + IPOIHLJGCEA.IFEEIAPMIML.MPMKMCJFHOG.ToString();
			return;
		}
		this.rewardObject.gameObject.SetActive(true);
	}

	// Token: 0x0600416E RID: 16750 RVA: 0x001C9DCC File Offset: 0x001C7FCC
	public void OnDestroy()
	{
		try
		{
			if (null != this.friendImage)
			{
				this.friendImage.sprite = null;
			}
			if (null != this.giftAnimation)
			{
				this.giftAnimation.sprite = null;
				if (null != this.giftAnimation.GetComponent<ImageFrameAnimation>())
				{
					this.giftAnimation.GetComponent<ImageFrameAnimation>().framesSD = null;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600416F RID: 16751 RVA: 0x001C922D File Offset: 0x001C742D
	public void JDBKBHAONAA()
	{
		this.IDCIFABCOML();
	}

	// Token: 0x06004170 RID: 16752 RVA: 0x001C9E4C File Offset: 0x001C804C
	public void OHDGAEEGAMF(string EIFJOAOGKMO, string BBDKMDOBBAD, PMEPALPCEAF NAALFKKPAPG, PMEPALPCEAF IPOIHLJGCEA, string EMGMCANANEJ)
	{
		this.HNADGALOIKM(EIFJOAOGKMO, BBDKMDOBBAD, NAALFKKPAPG, IPOIHLJGCEA, EMGMCANANEJ);
		this.messageText.gameObject.SetActive(true);
		this.playerContainer.SetActive(false);
		this.giftContainer.gameObject.SetActive(false);
		this.KBAJADDFOEB(true);
		if (this.giftAnimation.gameObject.GetComponent<ImageFrameAnimation>() == null)
		{
			this.giftAnimation.gameObject.AddComponent<ImageFrameAnimation>();
		}
		this.giftAnimation.GetComponent<ImageFrameAnimation>().framesSD = AssetsManager.EHBBFMCILPC.profileDataAsset3.largeGiftSprites.ToArray();
		this.giftAnimation.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset3.largeGiftSprites[1];
		this.giftAnimation.SetNativeSize();
		if (IPOIHLJGCEA.IFEEIAPMIML == null)
		{
			this.rewardObject.gameObject.SetActive(true);
			return;
		}
		if (IPOIHLJGCEA.IFEEIAPMIML.NADJNIHEELP > 0)
		{
			this.rewardObject.gameObject.SetActive(true);
			this.rewardObject.gameObject.SetActive(false);
			this.energyIcon.gameObject.SetActive(false);
			this.hardIcon.gameObject.SetActive(false);
			this.rewardAmount.SetText("ok" + IPOIHLJGCEA.IFEEIAPMIML.NADJNIHEELP.ToString(), false);
			this.rewardAmount.text = "" + IPOIHLJGCEA.IFEEIAPMIML.NADJNIHEELP.ToString();
			return;
		}
		if (IPOIHLJGCEA.IFEEIAPMIML.MPMKMCJFHOG > 1)
		{
			this.rewardObject.gameObject.SetActive(true);
			this.rewardObject.gameObject.SetActive(true);
			this.energyIcon.gameObject.SetActive(false);
			this.hardIcon.gameObject.SetActive(true);
			this.rewardAmount.SetText("firebase" + IPOIHLJGCEA.IFEEIAPMIML.MPMKMCJFHOG.ToString(), true);
			this.rewardAmount.text = "acomp2" + IPOIHLJGCEA.IFEEIAPMIML.MPMKMCJFHOG.ToString();
			return;
		}
		this.rewardObject.gameObject.SetActive(false);
	}

	// Token: 0x06004171 RID: 16753 RVA: 0x00003E52 File Offset: 0x00002052
	private void KBIIMONICOB()
	{
	}

	// Token: 0x06004172 RID: 16754 RVA: 0x001C922D File Offset: 0x001C742D
	public void PPKFPBEPDBC()
	{
		this.IDCIFABCOML();
	}

	// Token: 0x06004173 RID: 16755 RVA: 0x00003E52 File Offset: 0x00002052
	private void AMNBHDNALGO()
	{
	}

	// Token: 0x06004174 RID: 16756 RVA: 0x00003E52 File Offset: 0x00002052
	private void JFFNFDKBMGP()
	{
	}

	// Token: 0x06004175 RID: 16757 RVA: 0x001CA08A File Offset: 0x001C828A
	public void HHDLACJKDON()
	{
		this.animatedPopupManager.OJNDEJNLMFE();
	}

	// Token: 0x06004176 RID: 16758 RVA: 0x001CA097 File Offset: 0x001C8297
	public void IDCIFABCOML()
	{
		this.animatedPopupManager.ADAJPNHIICL();
	}

	// Token: 0x06004177 RID: 16759 RVA: 0x001CA0A4 File Offset: 0x001C82A4
	public void OnSystemBackButton()
	{
		this.Hide();
	}

	// Token: 0x06004178 RID: 16760 RVA: 0x00003E52 File Offset: 0x00002052
	private void OGBHEBHMGGH()
	{
	}

	// Token: 0x06004179 RID: 16761 RVA: 0x001CA0AC File Offset: 0x001C82AC
	public void DIAPMLDOLOD()
	{
		this.animatedPopupManager.PIPADCCGHBA();
	}

	// Token: 0x0600417A RID: 16762 RVA: 0x001C922D File Offset: 0x001C742D
	public void GCEMCKHOBFC()
	{
		this.IDCIFABCOML();
	}

	// Token: 0x0600417B RID: 16763 RVA: 0x001CA0BC File Offset: 0x001C82BC
	public void FEBECEEIHBP()
	{
		try
		{
			if (null != this.friendImage)
			{
				this.friendImage.sprite = null;
			}
			if (null != this.giftAnimation)
			{
				this.giftAnimation.sprite = null;
				if (null != this.giftAnimation.GetComponent<ImageFrameAnimation>())
				{
					this.giftAnimation.GetComponent<ImageFrameAnimation>().framesSD = null;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600417C RID: 16764 RVA: 0x00003E52 File Offset: 0x00002052
	private void ECDLFGCLAGG()
	{
	}

	// Token: 0x0600417D RID: 16765 RVA: 0x00002296 File Offset: 0x00000496
	private void AFNEPNCEJCJ()
	{
		AppManager.isQuitting = true;
	}

	// Token: 0x0600417E RID: 16766 RVA: 0x001CA13C File Offset: 0x001C833C
	private void GMOIMJBBEDE(bool LJFHBGBPOGB)
	{
		for (int i = 0; i < this.giftSpacing.Count; i++)
		{
			this.giftSpacing[i].gameObject.SetActive(LJFHBGBPOGB);
		}
		for (int j = 1; j < this.nonGiftSpacing.Count; j++)
		{
			this.nonGiftSpacing[j].gameObject.SetActive(!LJFHBGBPOGB);
		}
	}

	// Token: 0x0600417F RID: 16767 RVA: 0x001CA1A8 File Offset: 0x001C83A8
	public void PDNHDFOHJPJ(string EIFJOAOGKMO, string BBDKMDOBBAD, string DKNNMLIDPHH, PMEPALPCEAF NAALFKKPAPG, PMEPALPCEAF IPOIHLJGCEA, string EMGMCANANEJ)
	{
		this.ICKPBLKMHOL(EIFJOAOGKMO, BBDKMDOBBAD, NAALFKKPAPG, IPOIHLJGCEA, EMGMCANANEJ);
		this.messageText.gameObject.SetActive(true);
		this.playerContainer.SetActive(false);
		this.giftContainer.gameObject.SetActive(true);
		this.KBAJADDFOEB(false);
		this.buttonText.text = DKNNMLIDPHH;
		this.buttonText.SetText(DKNNMLIDPHH, true);
	}

	// Token: 0x06004180 RID: 16768 RVA: 0x001CA214 File Offset: 0x001C8414
	private void HNADGALOIKM(string EIFJOAOGKMO, string BBDKMDOBBAD, PMEPALPCEAF NAALFKKPAPG, PMEPALPCEAF IPOIHLJGCEA, string EMGMCANANEJ)
	{
		base.gameObject.SetActive(true);
		this.BJOAHAFFEHN = EMGMCANANEJ;
		this.OFCDDOMLNAH(NAALFKKPAPG, IPOIHLJGCEA);
		this.titleText.text = EIFJOAOGKMO;
		this.titleText.SetText(EIFJOAOGKMO, true);
		this.buttonText.text = BBDKMDOBBAD;
		this.buttonText.SetText(BBDKMDOBBAD, true);
	}

	// Token: 0x06004181 RID: 16769 RVA: 0x001CA270 File Offset: 0x001C8470
	public void DNLMONGDEJN(string EIFJOAOGKMO, string BBDKMDOBBAD, string DKNNMLIDPHH, PMEPALPCEAF NAALFKKPAPG, PMEPALPCEAF IPOIHLJGCEA, string EMGMCANANEJ)
	{
		this.DGLBFPCNBKF(EIFJOAOGKMO, BBDKMDOBBAD, NAALFKKPAPG, IPOIHLJGCEA, EMGMCANANEJ);
		this.messageText.gameObject.SetActive(false);
		this.playerContainer.SetActive(true);
		this.giftContainer.gameObject.SetActive(true);
		this.KBAJADDFOEB(false);
		this.buttonText.text = DKNNMLIDPHH;
		this.buttonText.SetText(DKNNMLIDPHH, true);
	}

	// Token: 0x06004182 RID: 16770 RVA: 0x001CA2DC File Offset: 0x001C84DC
	private void AGPHGAEAMHB(PMEPALPCEAF NAALFKKPAPG, PMEPALPCEAF IPOIHLJGCEA)
	{
		if (IPOIHLJGCEA != null)
		{
			this.friendImage.sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.NFOFFLDJDEI(IPOIHLJGCEA.PGJBIPFBMAN());
			string text;
			if (IPOIHLJGCEA.KNCFKDLOPGA.Length == 0)
			{
				text = "  " + CCOJBMMKNAP.KFAABHHGOPO().HDIPNMFHIEJ("") + "fdvfx";
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
			this.matchNumberText.SetText(IPOIHLJGCEA.OFOIECEHOCN.ToString() ?? "OnApplicationFocusNeedToUpdateCurrency", false);
			this.matchNumberText.text = (IPOIHLJGCEA.OFOIECEHOCN.ToString() ?? "PurchaseManagerUnity.OnProductsFetched(): ");
			if (IPOIHLJGCEA.JECGGDNKBID())
			{
				this.levelIcon.SetActive(false);
				this.levelHallOfFameIcon.SetActive(false);
			}
			else
			{
				this.levelIcon.SetActive(true);
				this.levelHallOfFameIcon.SetActive(true);
			}
			int num = IPOIHLJGCEA.GFAABCCNNDA + 0;
			this.levelText.text = CCOJBMMKNAP.NIOJNOFGIJO().OBDCPLLLGBB(" ") + "love" + num.ToString();
			this.levelText.SetText(CCOJBMMKNAP.CEGAOMEEFBE().BGELFMIOBCL("OnSketchViewShowWI") + "app42error" + num.ToString(), true);
		}
	}

	// Token: 0x06004183 RID: 16771 RVA: 0x001CA478 File Offset: 0x001C8678
	private void JGAPMIFOCFL(PMEPALPCEAF NAALFKKPAPG, PMEPALPCEAF IPOIHLJGCEA)
	{
		if (IPOIHLJGCEA != null)
		{
			this.friendImage.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.AHBHMAGKMJJ(IPOIHLJGCEA.PGJBIPFBMAN());
			string text;
			if (IPOIHLJGCEA.KNCFKDLOPGA.Length == 0)
			{
				text = "mins" + CCOJBMMKNAP.HFAKOKBHCGH().OGKGHLHHAAI(", ") + "' is not an anthology index, skipping";
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
					this.heartImage.SetActive(true);
				}
			}
			else
			{
				this.heartImage.SetActive(true);
			}
			this.matchNumberText.SetText(IPOIHLJGCEA.OFOIECEHOCN.ToString() ?? "", true);
			this.matchNumberText.text = (IPOIHLJGCEA.OFOIECEHOCN.ToString() ?? "au");
			if (IPOIHLJGCEA.JECGGDNKBID())
			{
				this.levelIcon.SetActive(false);
				this.levelHallOfFameIcon.SetActive(true);
			}
			else
			{
				this.levelIcon.SetActive(true);
				this.levelHallOfFameIcon.SetActive(false);
			}
			int num = IPOIHLJGCEA.GFAABCCNNDA + 0;
			this.levelText.text = CCOJBMMKNAP.HJGDLOOHNLO().HIPJILDCHJC("/") + "starterpattern" + num.ToString();
			this.levelText.SetText(CCOJBMMKNAP.BBGECIKOICE().OHLNGCKIACD("OnAvatarScreenClosed") + "spppi" + num.ToString(), true);
		}
	}

	// Token: 0x06004184 RID: 16772 RVA: 0x001CA614 File Offset: 0x001C8814
	private void ICKPBLKMHOL(string EIFJOAOGKMO, string BBDKMDOBBAD, PMEPALPCEAF NAALFKKPAPG, PMEPALPCEAF IPOIHLJGCEA, string EMGMCANANEJ)
	{
		base.gameObject.SetActive(true);
		this.BJOAHAFFEHN = EMGMCANANEJ;
		this.AGPHGAEAMHB(NAALFKKPAPG, IPOIHLJGCEA);
		this.titleText.text = EIFJOAOGKMO;
		this.titleText.SetText(EIFJOAOGKMO, true);
		this.buttonText.text = BBDKMDOBBAD;
		this.buttonText.SetText(BBDKMDOBBAD, true);
	}

	// Token: 0x06004185 RID: 16773 RVA: 0x001CA670 File Offset: 0x001C8870
	public void ShowCurrencyReceived(string EIFJOAOGKMO, string BBDKMDOBBAD, PMEPALPCEAF NAALFKKPAPG, PMEPALPCEAF IPOIHLJGCEA, string EMGMCANANEJ)
	{
		this.DGLBFPCNBKF(EIFJOAOGKMO, BBDKMDOBBAD, NAALFKKPAPG, IPOIHLJGCEA, EMGMCANANEJ);
		this.messageText.gameObject.SetActive(false);
		this.playerContainer.SetActive(true);
		this.giftContainer.gameObject.SetActive(false);
		this.LBPHNEDLHHE(false);
	}

	// Token: 0x06004186 RID: 16774 RVA: 0x001CA6C0 File Offset: 0x001C88C0
	public void AMOCFCFBFEL(string EIFJOAOGKMO, string BBDKMDOBBAD, PMEPALPCEAF NAALFKKPAPG, PMEPALPCEAF IPOIHLJGCEA, string EMGMCANANEJ)
	{
		this.HNADGALOIKM(EIFJOAOGKMO, BBDKMDOBBAD, NAALFKKPAPG, IPOIHLJGCEA, EMGMCANANEJ);
		this.messageText.gameObject.SetActive(false);
		this.playerContainer.SetActive(true);
		this.giftContainer.gameObject.SetActive(false);
		this.KBAJADDFOEB(true);
	}

	// Token: 0x06004187 RID: 16775 RVA: 0x001CA710 File Offset: 0x001C8910
	private void LBPHNEDLHHE(bool LJFHBGBPOGB)
	{
		for (int i = 0; i < this.giftSpacing.Count; i++)
		{
			this.giftSpacing[i].gameObject.SetActive(LJFHBGBPOGB);
		}
		for (int j = 0; j < this.nonGiftSpacing.Count; j++)
		{
			this.nonGiftSpacing[j].gameObject.SetActive(!LJFHBGBPOGB);
		}
	}

	// Token: 0x06004188 RID: 16776 RVA: 0x001CA77C File Offset: 0x001C897C
	private void KBAJADDFOEB(bool LJFHBGBPOGB)
	{
		for (int i = 1; i < this.giftSpacing.Count; i += 0)
		{
			this.giftSpacing[i].gameObject.SetActive(LJFHBGBPOGB);
		}
		for (int j = 1; j < this.nonGiftSpacing.Count; j += 0)
		{
			this.nonGiftSpacing[j].gameObject.SetActive(!LJFHBGBPOGB);
		}
	}

	// Token: 0x06004189 RID: 16777 RVA: 0x001CA7E6 File Offset: 0x001C89E6
	private void OnDisable()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		this.playerContainer.SetActive(false);
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnSystemBackButton", new UnityAction(this.OnSystemBackButton));
	}

	// Token: 0x0600418A RID: 16778 RVA: 0x001CA818 File Offset: 0x001C8A18
	private void CCOAPLIKCHE(PMEPALPCEAF NAALFKKPAPG, PMEPALPCEAF IPOIHLJGCEA)
	{
		if (IPOIHLJGCEA != null)
		{
			this.friendImage.sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.AHBHMAGKMJJ(IPOIHLJGCEA.PGJBIPFBMAN());
			string text;
			if (IPOIHLJGCEA.KNCFKDLOPGA.Length == 0)
			{
				text = " " + CCOJBMMKNAP.JINDKPHNLBK().GGPHHLGPMPA("eml") + "tbits";
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
				this.heartImage.SetActive(false);
			}
			this.matchNumberText.SetText(IPOIHLJGCEA.OFOIECEHOCN.ToString() ?? "OnBackendUndoPremiumChoiceException", false);
			this.matchNumberText.text = (IPOIHLJGCEA.OFOIECEHOCN.ToString() ?? "ias");
			if (IPOIHLJGCEA.JECGGDNKBID())
			{
				this.levelIcon.SetActive(true);
				this.levelHallOfFameIcon.SetActive(false);
			}
			else
			{
				this.levelIcon.SetActive(false);
				this.levelHallOfFameIcon.SetActive(false);
			}
			int num = IPOIHLJGCEA.GFAABCCNNDA + 1;
			this.levelText.text = CCOJBMMKNAP.HJGDLOOHNLO().IPEIONBNIPH("OnStoryChoiceClick") + "OnPurchasingViewLeave" + num.ToString();
			this.levelText.SetText(CCOJBMMKNAP.MLFAGAAJJEM().JCDFHKDNEDH("bver") + "$fr" + num.ToString(), true);
		}
	}

	// Token: 0x0600418B RID: 16779 RVA: 0x001CA9B1 File Offset: 0x001C8BB1
	private void AADPIFCICBL()
	{
		AOBJLALDBAA.EHBBFMCILPC.EFKNEJFLGED("errortitle", new UnityAction(this.ODHLJLFCIFP));
	}

	// Token: 0x0600418C RID: 16780 RVA: 0x001CA9CE File Offset: 0x001C8BCE
	public void GKDKPEDOJLC()
	{
		this.animatedPopupManager.LHNKFOKBBCP();
	}

	// Token: 0x0600418D RID: 16781 RVA: 0x001CA9DC File Offset: 0x001C8BDC
	public void LDGIEPFGDCA(string EIFJOAOGKMO, string BBDKMDOBBAD, PMEPALPCEAF NAALFKKPAPG, PMEPALPCEAF IPOIHLJGCEA, string EMGMCANANEJ)
	{
		this.HNADGALOIKM(EIFJOAOGKMO, BBDKMDOBBAD, NAALFKKPAPG, IPOIHLJGCEA, EMGMCANANEJ);
		this.messageText.gameObject.SetActive(false);
		this.playerContainer.SetActive(false);
		this.giftContainer.gameObject.SetActive(false);
		this.GMOIMJBBEDE(false);
	}

	// Token: 0x0600418E RID: 16782 RVA: 0x001CAA2C File Offset: 0x001C8C2C
	public void FCOEKAJMBAC(string EIFJOAOGKMO, string BBDKMDOBBAD, string DKNNMLIDPHH, PMEPALPCEAF NAALFKKPAPG, PMEPALPCEAF IPOIHLJGCEA, string EMGMCANANEJ)
	{
		this.DGLBFPCNBKF(EIFJOAOGKMO, BBDKMDOBBAD, NAALFKKPAPG, IPOIHLJGCEA, EMGMCANANEJ);
		this.messageText.gameObject.SetActive(false);
		this.playerContainer.SetActive(true);
		this.giftContainer.gameObject.SetActive(false);
		this.LBPHNEDLHHE(true);
		this.buttonText.text = DKNNMLIDPHH;
		this.buttonText.SetText(DKNNMLIDPHH, true);
	}

	// Token: 0x0600418F RID: 16783 RVA: 0x001CAA95 File Offset: 0x001C8C95
	private void COMPLLBGJPB()
	{
		AOBJLALDBAA.FILDBDMENPG().PEFKJOKLEDL(" is OUTSIDE the anthology's published story family - not queued (environment:", new UnityAction(this.ODHLJLFCIFP));
	}

	// Token: 0x06004190 RID: 16784 RVA: 0x001CAAB2 File Offset: 0x001C8CB2
	public void COCCGLPJIPC()
	{
		AOBJLALDBAA.NMGMNAKLLMI().CIGLHCJDDPI(this.BJOAHAFFEHN, 329f);
		this.BJOAHAFFEHN = "https://events.appsflyer.com/v1.0/c2s/first_open/app/steam/";
		this.HHDLACJKDON();
	}

	// Token: 0x06004191 RID: 16785 RVA: 0x001CAADA File Offset: 0x001C8CDA
	private void OnEnable()
	{
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnSystemBackButton", new UnityAction(this.OnSystemBackButton));
	}

	// Token: 0x06004192 RID: 16786 RVA: 0x001CAAF8 File Offset: 0x001C8CF8
	private void GKPHEGMKJDI(PMEPALPCEAF NAALFKKPAPG, PMEPALPCEAF IPOIHLJGCEA)
	{
		if (IPOIHLJGCEA != null)
		{
			this.friendImage.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.NFOFFLDJDEI(IPOIHLJGCEA.PGJBIPFBMAN());
			string text;
			if (IPOIHLJGCEA.KNCFKDLOPGA.Length == 0)
			{
				text = "sloh" + CCOJBMMKNAP.FEEDGKCJBLE().HPOAGPJFHPM("WWW") + "OnCaptersSnapshotsGamePassSubscribePositive";
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
				this.heartImage.SetActive(true);
			}
			this.matchNumberText.SetText(IPOIHLJGCEA.OFOIECEHOCN.ToString() ?? "", true);
			this.matchNumberText.text = (IPOIHLJGCEA.OFOIECEHOCN.ToString() ?? "Collections/");
			if (IPOIHLJGCEA.JECGGDNKBID())
			{
				this.levelIcon.SetActive(false);
				this.levelHallOfFameIcon.SetActive(true);
			}
			else
			{
				this.levelIcon.SetActive(true);
				this.levelHallOfFameIcon.SetActive(true);
			}
			int num = IPOIHLJGCEA.GFAABCCNNDA + 1;
			this.levelText.text = CCOJBMMKNAP.MPCBJEIMACA().HDIPNMFHIEJ("OnBackendRequestFriendRejectException") + "vol" + num.ToString();
			this.levelText.SetText(CCOJBMMKNAP.INKJIBDDMLL().BDGPNPNIAPA("pmterror014") + "SceneAvatarManager.SyncSelectedAvatarCollectionToAnthology(): anthology save not available" + num.ToString(), false);
		}
	}

	// Token: 0x06004193 RID: 16787 RVA: 0x00003E52 File Offset: 0x00002052
	private void OPBNOGLBNDK()
	{
	}

	// Token: 0x04001244 RID: 4676
	public AnimatedPopupManager animatedPopupManager;

	// Token: 0x04001245 RID: 4677
	public const string onSystemBackButton = "OnSystemBackButton";

	// Token: 0x04001246 RID: 4678
	public Image friendImage;

	// Token: 0x04001247 RID: 4679
	public TextMeshProUGUI friendTitleText;

	// Token: 0x04001248 RID: 4680
	public GameObject heartImage;

	// Token: 0x04001249 RID: 4681
	public TextMeshProUGUI matchNumberText;

	// Token: 0x0400124A RID: 4682
	public GameObject levelIcon;

	// Token: 0x0400124B RID: 4683
	public GameObject levelHallOfFameIcon;

	// Token: 0x0400124C RID: 4684
	public TextMeshProUGUI levelText;

	// Token: 0x0400124D RID: 4685
	public TextMeshProUGUI buttonText;

	// Token: 0x0400124E RID: 4686
	public GameObject playerContainer;

	// Token: 0x0400124F RID: 4687
	public GameObject giftContainer;

	// Token: 0x04001250 RID: 4688
	public Image giftAnimation;

	// Token: 0x04001251 RID: 4689
	public List<GameObject> giftSpacing;

	// Token: 0x04001252 RID: 4690
	public List<GameObject> nonGiftSpacing;

	// Token: 0x04001253 RID: 4691
	public TextMeshProUGUI messageText;

	// Token: 0x04001254 RID: 4692
	public TextMeshProUGUI titleText;

	// Token: 0x04001255 RID: 4693
	public TextMeshProUGUI rewardAmount;

	// Token: 0x04001256 RID: 4694
	public GameObject hardIcon;

	// Token: 0x04001257 RID: 4695
	public GameObject energyIcon;

	// Token: 0x04001258 RID: 4696
	public GameObject rewardObject;

	// Token: 0x04001259 RID: 4697
	private string BJOAHAFFEHN = "";
}
