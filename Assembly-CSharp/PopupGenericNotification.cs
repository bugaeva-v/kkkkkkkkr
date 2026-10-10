using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200047E RID: 1150
public class PopupGenericNotification : MonoBehaviour
{
	// Token: 0x06008B64 RID: 35684 RVA: 0x003DC91A File Offset: 0x003DAB1A
	public void OJEEFHLILGL()
	{
		if (this.BJOAHAFFEHN.Length > 0)
		{
			AOBJLALDBAA.AGANFKKBPFO().EGELHPJBAIC(this.BJOAHAFFEHN, 1186f);
		}
		this.animatedPopupManager.PIPADCCGHBA();
		this.BJOAHAFFEHN = "XXX";
	}

	// Token: 0x06008B65 RID: 35685 RVA: 0x003DC958 File Offset: 0x003DAB58
	public void ShowGenericNotification(Sprite IBHNGIAHCCM, string EIFJOAOGKMO, string BHJJLJJACFE, string BBDKMDOBBAD, string EMGMCANANEJ, int FONPJINLAPG = 28)
	{
		base.gameObject.SetActive(true);
		this.BJOAHAFFEHN = EMGMCANANEJ;
		if (null != IBHNGIAHCCM)
		{
			this.logoImage.gameObject.SetActive(true);
			this.logoImage.sprite = IBHNGIAHCCM;
			this.logoImage.SetNativeSize();
		}
		else
		{
			this.logoImage.sprite = null;
			this.logoImage.gameObject.SetActive(false);
		}
		this.titleText.SetText(EIFJOAOGKMO, true);
		this.titleText.text = EIFJOAOGKMO;
		this.bodyText.SetText(BHJJLJJACFE, true);
		this.bodyText.text = BHJJLJJACFE;
		this.bodyText.fontSize = (float)FONPJINLAPG;
		this.buttonText.SetText(BBDKMDOBBAD, true);
		this.buttonText.text = BBDKMDOBBAD;
		this.heartsObject.SetActive(false);
	}

	// Token: 0x06008B66 RID: 35686 RVA: 0x003DCA30 File Offset: 0x003DAC30
	public void OFMCOFFGBPP()
	{
		this.animatedPopupManager.KCAPIILJKDN();
	}

	// Token: 0x06008B67 RID: 35687 RVA: 0x003DCA3D File Offset: 0x003DAC3D
	private void ELJFKBMKKML()
	{
		this.logoImage.sprite = null;
	}

	// Token: 0x06008B68 RID: 35688 RVA: 0x003DCA4C File Offset: 0x003DAC4C
	public void IOKAPHKGENK(Sprite IBHNGIAHCCM, string EIFJOAOGKMO, string BHJJLJJACFE, string BBDKMDOBBAD, string EMGMCANANEJ, int FONPJINLAPG = 28)
	{
		base.gameObject.SetActive(true);
		this.BJOAHAFFEHN = EMGMCANANEJ;
		if (null != IBHNGIAHCCM)
		{
			this.logoImage.gameObject.SetActive(false);
			this.logoImage.sprite = IBHNGIAHCCM;
			this.logoImage.SetNativeSize();
		}
		else
		{
			this.logoImage.sprite = null;
			this.logoImage.gameObject.SetActive(false);
		}
		this.titleText.SetText(EIFJOAOGKMO, false);
		this.titleText.text = EIFJOAOGKMO;
		this.bodyText.SetText(BHJJLJJACFE, true);
		this.bodyText.text = BHJJLJJACFE;
		this.bodyText.fontSize = (float)FONPJINLAPG;
		this.buttonText.SetText(BBDKMDOBBAD, true);
		this.buttonText.text = BBDKMDOBBAD;
		this.heartsObject.SetActive(true);
	}

	// Token: 0x06008B69 RID: 35689 RVA: 0x003DCB24 File Offset: 0x003DAD24
	public void GACECCBPEEB(Sprite IBHNGIAHCCM, string EIFJOAOGKMO, string BHJJLJJACFE, string BBDKMDOBBAD, string EMGMCANANEJ, int FONPJINLAPG = 28)
	{
		base.gameObject.SetActive(true);
		this.BJOAHAFFEHN = EMGMCANANEJ;
		if (null != IBHNGIAHCCM)
		{
			this.logoImage.gameObject.SetActive(false);
			this.logoImage.sprite = IBHNGIAHCCM;
			this.logoImage.SetNativeSize();
		}
		else
		{
			this.logoImage.sprite = null;
			this.logoImage.gameObject.SetActive(false);
		}
		this.titleText.SetText(EIFJOAOGKMO, true);
		this.titleText.text = EIFJOAOGKMO;
		this.bodyText.SetText(BHJJLJJACFE, true);
		this.bodyText.text = BHJJLJJACFE;
		this.bodyText.fontSize = (float)FONPJINLAPG;
		this.buttonText.SetText(BBDKMDOBBAD, false);
		this.buttonText.text = BBDKMDOBBAD;
		this.heartsObject.SetActive(false);
	}

	// Token: 0x06008B6A RID: 35690 RVA: 0x003DCBFC File Offset: 0x003DADFC
	public void IGHHGPJCOHI()
	{
		if (this.BJOAHAFFEHN.Length > 0)
		{
			AOBJLALDBAA.KKPFOJMAONG().DCGCFPHHDDG(this.BJOAHAFFEHN, 295f);
		}
		this.animatedPopupManager.GLIAGHMNMMP();
		this.BJOAHAFFEHN = " is not a loadable bundle";
	}

	// Token: 0x06008B6B RID: 35691 RVA: 0x003DCC38 File Offset: 0x003DAE38
	public void JNFILKNBGMP(Sprite IBHNGIAHCCM, string EIFJOAOGKMO, string BHJJLJJACFE, string BBDKMDOBBAD, string EMGMCANANEJ, int FONPJINLAPG = 28)
	{
		base.gameObject.SetActive(false);
		this.BJOAHAFFEHN = EMGMCANANEJ;
		if (null != IBHNGIAHCCM)
		{
			this.logoImage.gameObject.SetActive(false);
			this.logoImage.sprite = IBHNGIAHCCM;
			this.logoImage.SetNativeSize();
		}
		else
		{
			this.logoImage.sprite = null;
			this.logoImage.gameObject.SetActive(true);
		}
		this.titleText.SetText(EIFJOAOGKMO, true);
		this.titleText.text = EIFJOAOGKMO;
		this.bodyText.SetText(BHJJLJJACFE, false);
		this.bodyText.text = BHJJLJJACFE;
		this.bodyText.fontSize = (float)FONPJINLAPG;
		this.buttonText.SetText(BBDKMDOBBAD, false);
		this.buttonText.text = BBDKMDOBBAD;
		this.heartsObject.SetActive(false);
	}

	// Token: 0x06008B6C RID: 35692 RVA: 0x003DCD10 File Offset: 0x003DAF10
	public void HEGGPACFGBF(AssetLobbyData IAJCDKINNOM, string BBDKMDOBBAD, string EMGMCANANEJ, int FONPJINLAPG = 28)
	{
		base.gameObject.SetActive(false);
		this.BJOAHAFFEHN = EMGMCANANEJ;
		if (null != IAJCDKINNOM && null != IAJCDKINNOM.updateWelcomeSprite)
		{
			this.logoImage.gameObject.SetActive(true);
			this.logoImage.sprite = IAJCDKINNOM.updateWelcomeSprite;
			this.logoImage.SetNativeSize();
		}
		else
		{
			this.logoImage.sprite = null;
			this.logoImage.gameObject.SetActive(true);
		}
		this.titleText.SetText(GKJPOGNFKNK.DNILNCLIHAP("XXX" + IAJCDKINNOM.updateWelcomeId + "OnBackendPublishSketchSuccess", "`", LanguageManager.EHBBFMCILPC.MLOLBFBODHD()), true);
		this.titleText.text = GKJPOGNFKNK.DNILNCLIHAP("assetbundleprofilepack" + IAJCDKINNOM.updateWelcomeId + "", "Starting non-parallel download:", LanguageManager.EHBBFMCILPC.MLOLBFBODHD());
		this.bodyText.SetText(GKJPOGNFKNK.DNILNCLIHAP("myphiddentitle" + IAJCDKINNOM.updateWelcomeId + "saveslotsexpiredpass", "gpsasar", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()), false);
		this.bodyText.text = GKJPOGNFKNK.DNILNCLIHAP("OnAvatarScreenAssetsDownloadFailed" + IAJCDKINNOM.updateWelcomeId + "/", "center", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
		this.bodyText.fontSize = (float)FONPJINLAPG;
		this.buttonText.SetText(BBDKMDOBBAD, true);
		this.buttonText.text = BBDKMDOBBAD;
		this.heartsObject.SetActive(true);
	}

	// Token: 0x06008B6D RID: 35693 RVA: 0x003DCE98 File Offset: 0x003DB098
	public void ELGNHBBKGAD()
	{
		if (this.BJOAHAFFEHN.Length > 1)
		{
			AOBJLALDBAA.CEGAOMEEFBE().EFBNBFIDEOK(this.BJOAHAFFEHN, 862f);
		}
		this.animatedPopupManager.ADAJPNHIICL();
		this.BJOAHAFFEHN = "ok";
	}

	// Token: 0x06008B6E RID: 35694 RVA: 0x003DCED3 File Offset: 0x003DB0D3
	public void DDBJMNMBFED()
	{
		this.animatedPopupManager.FJAAHFFLGFF();
	}

	// Token: 0x06008B6F RID: 35695 RVA: 0x00003E52 File Offset: 0x00002052
	private void BNOEAHFICOB()
	{
	}

	// Token: 0x06008B70 RID: 35696 RVA: 0x00003E52 File Offset: 0x00002052
	private void FDFMDEOMJBH()
	{
	}

	// Token: 0x06008B71 RID: 35697 RVA: 0x003DCEE0 File Offset: 0x003DB0E0
	public void DGMEHPMHAJN()
	{
		this.animatedPopupManager.NBDMOONDIHO();
	}

	// Token: 0x06008B72 RID: 35698 RVA: 0x00003E52 File Offset: 0x00002052
	private void HPGLEEHELDN()
	{
	}

	// Token: 0x06008B73 RID: 35699 RVA: 0x003DCEED File Offset: 0x003DB0ED
	public void FJBGNNFEKOL()
	{
		this.animatedPopupManager.GLIAGHMNMMP();
	}

	// Token: 0x06008B74 RID: 35700 RVA: 0x003DCA3D File Offset: 0x003DAC3D
	private void ABOIKHJHJHH()
	{
		this.logoImage.sprite = null;
	}

	// Token: 0x06008B75 RID: 35701 RVA: 0x00003E52 File Offset: 0x00002052
	private void PABLFIJDFAD()
	{
	}

	// Token: 0x06008B76 RID: 35702 RVA: 0x003DCA3D File Offset: 0x003DAC3D
	private void PLJCFADNJBP()
	{
		this.logoImage.sprite = null;
	}

	// Token: 0x06008B77 RID: 35703 RVA: 0x003DCEFA File Offset: 0x003DB0FA
	public void OACEAKDHOPF()
	{
		if (this.BJOAHAFFEHN.Length > 0)
		{
			AOBJLALDBAA.FILDBDMENPG().DCGCFPHHDDG(this.BJOAHAFFEHN, 213f);
		}
		this.animatedPopupManager.LHNKFOKBBCP();
		this.BJOAHAFFEHN = "OnAccountSignInSuccess";
	}

	// Token: 0x06008B78 RID: 35704 RVA: 0x00003E52 File Offset: 0x00002052
	private void EIHOIEGKJLA()
	{
	}

	// Token: 0x06008B79 RID: 35705 RVA: 0x003DCF35 File Offset: 0x003DB135
	public void NAIMJDFDDPJ()
	{
		this.animatedPopupManager.OHHFFMMMMAC();
	}

	// Token: 0x06008B7A RID: 35706 RVA: 0x003DCF44 File Offset: 0x003DB144
	public void EMDMPCMGPIP(Sprite IBHNGIAHCCM, string EIFJOAOGKMO, string BHJJLJJACFE, string BBDKMDOBBAD, string EMGMCANANEJ, int FONPJINLAPG = 28)
	{
		base.gameObject.SetActive(true);
		this.BJOAHAFFEHN = EMGMCANANEJ;
		if (null != IBHNGIAHCCM)
		{
			this.logoImage.gameObject.SetActive(true);
			this.logoImage.sprite = IBHNGIAHCCM;
			this.logoImage.SetNativeSize();
		}
		else
		{
			this.logoImage.sprite = null;
			this.logoImage.gameObject.SetActive(true);
		}
		this.titleText.SetText(EIFJOAOGKMO, false);
		this.titleText.text = EIFJOAOGKMO;
		this.bodyText.SetText(BHJJLJJACFE, true);
		this.bodyText.text = BHJJLJJACFE;
		this.bodyText.fontSize = (float)FONPJINLAPG;
		this.buttonText.SetText(BBDKMDOBBAD, false);
		this.buttonText.text = BBDKMDOBBAD;
		this.heartsObject.SetActive(true);
	}

	// Token: 0x06008B7B RID: 35707 RVA: 0x003DCA3D File Offset: 0x003DAC3D
	private void NNEHODIFLHA()
	{
		this.logoImage.sprite = null;
	}

	// Token: 0x06008B7C RID: 35708 RVA: 0x003DD01C File Offset: 0x003DB21C
	public void NOLJGKOALON(Sprite IBHNGIAHCCM, string EIFJOAOGKMO, string BHJJLJJACFE, string BBDKMDOBBAD, string EMGMCANANEJ, int FONPJINLAPG = 28)
	{
		base.gameObject.SetActive(false);
		this.BJOAHAFFEHN = EMGMCANANEJ;
		if (null != IBHNGIAHCCM)
		{
			this.logoImage.gameObject.SetActive(false);
			this.logoImage.sprite = IBHNGIAHCCM;
			this.logoImage.SetNativeSize();
		}
		else
		{
			this.logoImage.sprite = null;
			this.logoImage.gameObject.SetActive(false);
		}
		this.titleText.SetText(EIFJOAOGKMO, false);
		this.titleText.text = EIFJOAOGKMO;
		this.bodyText.SetText(BHJJLJJACFE, true);
		this.bodyText.text = BHJJLJJACFE;
		this.bodyText.fontSize = (float)FONPJINLAPG;
		this.buttonText.SetText(BBDKMDOBBAD, false);
		this.buttonText.text = BBDKMDOBBAD;
		this.heartsObject.SetActive(false);
	}

	// Token: 0x06008B7D RID: 35709 RVA: 0x003DD0F4 File Offset: 0x003DB2F4
	public void PPMKLDEKHPA(AssetLobbyData IAJCDKINNOM, string BBDKMDOBBAD, string EMGMCANANEJ, int FONPJINLAPG = 28)
	{
		base.gameObject.SetActive(true);
		this.BJOAHAFFEHN = EMGMCANANEJ;
		if (null != IAJCDKINNOM && null != IAJCDKINNOM.updateWelcomeSprite)
		{
			this.logoImage.gameObject.SetActive(false);
			this.logoImage.sprite = IAJCDKINNOM.updateWelcomeSprite;
			this.logoImage.SetNativeSize();
		}
		else
		{
			this.logoImage.sprite = null;
			this.logoImage.gameObject.SetActive(false);
		}
		this.titleText.SetText(GKJPOGNFKNK.DNILNCLIHAP("msgt" + IAJCDKINNOM.updateWelcomeId + "", "makeup", LanguageManager.EHBBFMCILPC.MLOLBFBODHD()), true);
		this.titleText.text = GKJPOGNFKNK.DNILNCLIHAP("" + IAJCDKINNOM.updateWelcomeId + "OnRestorePurchasesZeroResult", "OnLobbyManInTheMiddleAttackDetected", LanguageManager.EHBBFMCILPC.MLOLBFBODHD());
		this.bodyText.SetText(GKJPOGNFKNK.DNILNCLIHAP("abs" + IAJCDKINNOM.updateWelcomeId + "+", "rsind", LanguageManager.EHBBFMCILPC.MLOLBFBODHD()), true);
		this.bodyText.text = GKJPOGNFKNK.DNILNCLIHAP("\"" + IAJCDKINNOM.updateWelcomeId + "\"", "", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ());
		this.bodyText.fontSize = (float)FONPJINLAPG;
		this.buttonText.SetText(BBDKMDOBBAD, true);
		this.buttonText.text = BBDKMDOBBAD;
		this.heartsObject.SetActive(false);
	}

	// Token: 0x06008B7E RID: 35710 RVA: 0x00003E52 File Offset: 0x00002052
	private void GEHKPILFMLD()
	{
	}

	// Token: 0x06008B7F RID: 35711 RVA: 0x00003E52 File Offset: 0x00002052
	private void PCJFJIBBDLL()
	{
	}

	// Token: 0x06008B80 RID: 35712 RVA: 0x00003E52 File Offset: 0x00002052
	private void BFGFJIJPMEH()
	{
	}

	// Token: 0x06008B81 RID: 35713 RVA: 0x003DD27C File Offset: 0x003DB47C
	public void GMCECKALIOD(Sprite IBHNGIAHCCM, string EIFJOAOGKMO, string BHJJLJJACFE, string BBDKMDOBBAD, string EMGMCANANEJ, int FONPJINLAPG = 28)
	{
		base.gameObject.SetActive(true);
		this.BJOAHAFFEHN = EMGMCANANEJ;
		if (null != IBHNGIAHCCM)
		{
			this.logoImage.gameObject.SetActive(true);
			this.logoImage.sprite = IBHNGIAHCCM;
			this.logoImage.SetNativeSize();
		}
		else
		{
			this.logoImage.sprite = null;
			this.logoImage.gameObject.SetActive(true);
		}
		this.titleText.SetText(EIFJOAOGKMO, true);
		this.titleText.text = EIFJOAOGKMO;
		this.bodyText.SetText(BHJJLJJACFE, false);
		this.bodyText.text = BHJJLJJACFE;
		this.bodyText.fontSize = (float)FONPJINLAPG;
		this.buttonText.SetText(BBDKMDOBBAD, true);
		this.buttonText.text = BBDKMDOBBAD;
		this.heartsObject.SetActive(true);
	}

	// Token: 0x06008B82 RID: 35714 RVA: 0x003DCA3D File Offset: 0x003DAC3D
	private void OHKBEIEOPOL()
	{
		this.logoImage.sprite = null;
	}

	// Token: 0x06008B83 RID: 35715 RVA: 0x003DCA3D File Offset: 0x003DAC3D
	private void GPLDMBFFDCM()
	{
		this.logoImage.sprite = null;
	}

	// Token: 0x06008B84 RID: 35716 RVA: 0x00003E52 File Offset: 0x00002052
	private void BHDHJLIBHCJ()
	{
	}

	// Token: 0x06008B85 RID: 35717 RVA: 0x003DD354 File Offset: 0x003DB554
	public void OnProceedClick()
	{
		if (this.BJOAHAFFEHN.Length > 0)
		{
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC(this.BJOAHAFFEHN, 0f);
		}
		this.animatedPopupManager.Hide();
		this.BJOAHAFFEHN = "";
	}

	// Token: 0x06008B86 RID: 35718 RVA: 0x003DD390 File Offset: 0x003DB590
	public void ShowUpdateWelcomeNotification(AssetLobbyData IAJCDKINNOM, string BBDKMDOBBAD, string EMGMCANANEJ, int FONPJINLAPG = 28)
	{
		base.gameObject.SetActive(true);
		this.BJOAHAFFEHN = EMGMCANANEJ;
		if (null != IAJCDKINNOM && null != IAJCDKINNOM.updateWelcomeSprite)
		{
			this.logoImage.gameObject.SetActive(true);
			this.logoImage.sprite = IAJCDKINNOM.updateWelcomeSprite;
			this.logoImage.SetNativeSize();
		}
		else
		{
			this.logoImage.sprite = null;
			this.logoImage.gameObject.SetActive(false);
		}
		this.titleText.SetText(GKJPOGNFKNK.DNILNCLIHAP("update" + IAJCDKINNOM.updateWelcomeId + "title", "misc", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), true);
		this.titleText.text = GKJPOGNFKNK.DNILNCLIHAP("update" + IAJCDKINNOM.updateWelcomeId + "title", "misc", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
		this.bodyText.SetText(GKJPOGNFKNK.DNILNCLIHAP("update" + IAJCDKINNOM.updateWelcomeId + "body", "misc", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), true);
		this.bodyText.text = GKJPOGNFKNK.DNILNCLIHAP("update" + IAJCDKINNOM.updateWelcomeId + "body", "misc", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
		this.bodyText.fontSize = (float)FONPJINLAPG;
		this.buttonText.SetText(BBDKMDOBBAD, true);
		this.buttonText.text = BBDKMDOBBAD;
		this.heartsObject.SetActive(true);
	}

	// Token: 0x06008B87 RID: 35719 RVA: 0x003DD518 File Offset: 0x003DB718
	public void MFLCIHENKLB()
	{
		if (this.BJOAHAFFEHN.Length > 0)
		{
			AOBJLALDBAA.AGANFKKBPFO().DCGCFPHHDDG(this.BJOAHAFFEHN, 599f);
		}
		this.animatedPopupManager.OHHFFMMMMAC();
		this.BJOAHAFFEHN = "OnLobbyManInTheMiddleAttackDetected";
	}

	// Token: 0x06008B88 RID: 35720 RVA: 0x003DD554 File Offset: 0x003DB754
	public void JAKEHDBKGDM(Sprite IBHNGIAHCCM, string EIFJOAOGKMO, string BHJJLJJACFE, string BBDKMDOBBAD, string EMGMCANANEJ, int FONPJINLAPG = 28)
	{
		base.gameObject.SetActive(true);
		this.BJOAHAFFEHN = EMGMCANANEJ;
		if (null != IBHNGIAHCCM)
		{
			this.logoImage.gameObject.SetActive(false);
			this.logoImage.sprite = IBHNGIAHCCM;
			this.logoImage.SetNativeSize();
		}
		else
		{
			this.logoImage.sprite = null;
			this.logoImage.gameObject.SetActive(false);
		}
		this.titleText.SetText(EIFJOAOGKMO, true);
		this.titleText.text = EIFJOAOGKMO;
		this.bodyText.SetText(BHJJLJJACFE, false);
		this.bodyText.text = BHJJLJJACFE;
		this.bodyText.fontSize = (float)FONPJINLAPG;
		this.buttonText.SetText(BBDKMDOBBAD, true);
		this.buttonText.text = BBDKMDOBBAD;
		this.heartsObject.SetActive(false);
	}

	// Token: 0x06008B89 RID: 35721 RVA: 0x00003E52 File Offset: 0x00002052
	private void BLEFIJPAJMJ()
	{
	}

	// Token: 0x06008B8A RID: 35722 RVA: 0x003DCEED File Offset: 0x003DB0ED
	public void LNGFDKKBKBG()
	{
		this.animatedPopupManager.GLIAGHMNMMP();
	}

	// Token: 0x06008B8B RID: 35723 RVA: 0x003DD62C File Offset: 0x003DB82C
	public void CPFDJNKPJBF()
	{
		this.animatedPopupManager.PIPADCCGHBA();
	}

	// Token: 0x06008B8C RID: 35724 RVA: 0x00003E52 File Offset: 0x00002052
	private void AOJMIFNKDFF()
	{
	}

	// Token: 0x06008B8D RID: 35725 RVA: 0x003DD639 File Offset: 0x003DB839
	public void AOCCIABPCBE()
	{
		this.animatedPopupManager.HFFJACPIHKE();
	}

	// Token: 0x06008B8E RID: 35726 RVA: 0x00003E52 File Offset: 0x00002052
	private void HLCCOGFOMHA()
	{
	}

	// Token: 0x06008B8F RID: 35727 RVA: 0x003DD646 File Offset: 0x003DB846
	public void OLNLPCLJLBJ()
	{
		if (this.BJOAHAFFEHN.Length > 0)
		{
			AOBJLALDBAA.NMGMNAKLLMI().KGIKHEDLPND(this.BJOAHAFFEHN, 383f);
		}
		this.animatedPopupManager.HFFJACPIHKE();
		this.BJOAHAFFEHN = "[LoadingEnv] previous run ended uncleanly with ";
	}

	// Token: 0x06008B90 RID: 35728 RVA: 0x003DD681 File Offset: 0x003DB881
	public void PNDKFBGDIBD()
	{
		if (this.BJOAHAFFEHN.Length > 0)
		{
			AOBJLALDBAA.EHBBFMCILPC.KMAGHMCCMPG(this.BJOAHAFFEHN, 1496f);
		}
		this.animatedPopupManager.GLIAGHMNMMP();
		this.BJOAHAFFEHN = "yes";
	}

	// Token: 0x06008B91 RID: 35729 RVA: 0x003DD6BC File Offset: 0x003DB8BC
	public void LPCAEJMDAPO(AssetLobbyData IAJCDKINNOM, string BBDKMDOBBAD, string EMGMCANANEJ, int FONPJINLAPG = 28)
	{
		base.gameObject.SetActive(true);
		this.BJOAHAFFEHN = EMGMCANANEJ;
		if (null != IAJCDKINNOM && null != IAJCDKINNOM.updateWelcomeSprite)
		{
			this.logoImage.gameObject.SetActive(false);
			this.logoImage.sprite = IAJCDKINNOM.updateWelcomeSprite;
			this.logoImage.SetNativeSize();
		}
		else
		{
			this.logoImage.sprite = null;
			this.logoImage.gameObject.SetActive(false);
		}
		this.titleText.SetText(GKJPOGNFKNK.DNILNCLIHAP("noisedigitalovr_2" + IAJCDKINNOM.updateWelcomeId + "avatarcollectionsuntitle", "OnGamePassUnlockContinueToPurchasingScreen", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), false);
		this.titleText.text = GKJPOGNFKNK.DNILNCLIHAP("ok" + IAJCDKINNOM.updateWelcomeId + "§", "coll2", LanguageManager.EHBBFMCILPC.NBANPEIHFOJ());
		this.bodyText.SetText(GKJPOGNFKNK.DNILNCLIHAP("LastOperationFailStateCounterHit():" + IAJCDKINNOM.updateWelcomeId + "rt", "storiesSearchDefaults", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), true);
		this.bodyText.text = GKJPOGNFKNK.DNILNCLIHAP("itsub" + IAJCDKINNOM.updateWelcomeId + "lititle", "layervideo", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ());
		this.bodyText.fontSize = (float)FONPJINLAPG;
		this.buttonText.SetText(BBDKMDOBBAD, true);
		this.buttonText.text = BBDKMDOBBAD;
		this.heartsObject.SetActive(false);
	}

	// Token: 0x06008B92 RID: 35730 RVA: 0x00003E52 File Offset: 0x00002052
	private void LKLNNDNCNOK()
	{
	}

	// Token: 0x06008B93 RID: 35731 RVA: 0x003DCA3D File Offset: 0x003DAC3D
	private void BHGOKICGBKO()
	{
		this.logoImage.sprite = null;
	}

	// Token: 0x06008B94 RID: 35732 RVA: 0x003DD844 File Offset: 0x003DBA44
	public void OJLGJMKBAFC()
	{
		if (this.BJOAHAFFEHN.Length > 0)
		{
			AOBJLALDBAA.FILDBDMENPG().EFBNBFIDEOK(this.BJOAHAFFEHN, 519f);
		}
		this.animatedPopupManager.LHNKFOKBBCP();
		this.BJOAHAFFEHN = "Vol";
	}

	// Token: 0x06008B95 RID: 35733 RVA: 0x003DD880 File Offset: 0x003DBA80
	public void GBLHKLBMABM(AssetLobbyData IAJCDKINNOM, string BBDKMDOBBAD, string EMGMCANANEJ, int FONPJINLAPG = 28)
	{
		base.gameObject.SetActive(true);
		this.BJOAHAFFEHN = EMGMCANANEJ;
		if (null != IAJCDKINNOM && null != IAJCDKINNOM.updateWelcomeSprite)
		{
			this.logoImage.gameObject.SetActive(true);
			this.logoImage.sprite = IAJCDKINNOM.updateWelcomeSprite;
			this.logoImage.SetNativeSize();
		}
		else
		{
			this.logoImage.sprite = null;
			this.logoImage.gameObject.SetActive(false);
		}
		this.titleText.SetText(GKJPOGNFKNK.DNILNCLIHAP("" + IAJCDKINNOM.updateWelcomeId + "OnBackendGetDropChancesException", "OnFacebookLoginCanceled", LanguageManager.EHBBFMCILPC.MLOLBFBODHD()), true);
		this.titleText.text = GKJPOGNFKNK.DNILNCLIHAP("-" + IAJCDKINNOM.updateWelcomeId + "Asset pack has been LOADED according to on demand resources data:", "W", LanguageManager.EHBBFMCILPC.NBANPEIHFOJ());
		this.bodyText.SetText(GKJPOGNFKNK.DNILNCLIHAP("aspks" + IAJCDKINNOM.updateWelcomeId + "/Miscellaneous/AssetBundlePurchasingView/", "", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()), false);
		this.bodyText.text = GKJPOGNFKNK.DNILNCLIHAP("$USEANIMV2" + IAJCDKINNOM.updateWelcomeId + "<align=\"center\"><i><alpha=#88>", "", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ());
		this.bodyText.fontSize = (float)FONPJINLAPG;
		this.buttonText.SetText(BBDKMDOBBAD, true);
		this.buttonText.text = BBDKMDOBBAD;
		this.heartsObject.SetActive(false);
	}

	// Token: 0x06008B96 RID: 35734 RVA: 0x003DDA08 File Offset: 0x003DBC08
	public void OEBPCJPEOCF(Sprite IBHNGIAHCCM, string EIFJOAOGKMO, string BHJJLJJACFE, string BBDKMDOBBAD, string EMGMCANANEJ, int FONPJINLAPG = 28)
	{
		base.gameObject.SetActive(false);
		this.BJOAHAFFEHN = EMGMCANANEJ;
		if (null != IBHNGIAHCCM)
		{
			this.logoImage.gameObject.SetActive(true);
			this.logoImage.sprite = IBHNGIAHCCM;
			this.logoImage.SetNativeSize();
		}
		else
		{
			this.logoImage.sprite = null;
			this.logoImage.gameObject.SetActive(false);
		}
		this.titleText.SetText(EIFJOAOGKMO, false);
		this.titleText.text = EIFJOAOGKMO;
		this.bodyText.SetText(BHJJLJJACFE, false);
		this.bodyText.text = BHJJLJJACFE;
		this.bodyText.fontSize = (float)FONPJINLAPG;
		this.buttonText.SetText(BBDKMDOBBAD, false);
		this.buttonText.text = BBDKMDOBBAD;
		this.heartsObject.SetActive(true);
	}

	// Token: 0x06008B97 RID: 35735 RVA: 0x003DCA30 File Offset: 0x003DAC30
	public void EBNOBGKEDPC()
	{
		this.animatedPopupManager.KCAPIILJKDN();
	}

	// Token: 0x06008B98 RID: 35736 RVA: 0x00003E52 File Offset: 0x00002052
	private void JLHGINADNCA()
	{
	}

	// Token: 0x06008B99 RID: 35737 RVA: 0x003DDAE0 File Offset: 0x003DBCE0
	public void PPIEMIBLMNM(AssetLobbyData IAJCDKINNOM, string BBDKMDOBBAD, string EMGMCANANEJ, int FONPJINLAPG = 28)
	{
		base.gameObject.SetActive(true);
		this.BJOAHAFFEHN = EMGMCANANEJ;
		if (null != IAJCDKINNOM && null != IAJCDKINNOM.updateWelcomeSprite)
		{
			this.logoImage.gameObject.SetActive(true);
			this.logoImage.sprite = IAJCDKINNOM.updateWelcomeSprite;
			this.logoImage.SetNativeSize();
		}
		else
		{
			this.logoImage.sprite = null;
			this.logoImage.gameObject.SetActive(true);
		}
		this.titleText.SetText(GKJPOGNFKNK.DNILNCLIHAP("PurchaseManagerXiaomi.GetProductData(): no cached SKU metadata for " + IAJCDKINNOM.updateWelcomeId + "PageUp\nPageDown - Change effects.", "Initializing folderIndex ", LanguageManager.EHBBFMCILPC.MLOLBFBODHD()), false);
		this.titleText.text = GKJPOGNFKNK.DNILNCLIHAP("]:" + IAJCDKINNOM.updateWelcomeId + "Optional npc animation bundle failed to load, continuing without it:", "XXX", LanguageManager.EHBBFMCILPC.NBANPEIHFOJ());
		this.bodyText.SetText(GKJPOGNFKNK.DNILNCLIHAP("+" + IAJCDKINNOM.updateWelcomeId + "purchaseToken", "item", LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()), false);
		this.bodyText.text = GKJPOGNFKNK.DNILNCLIHAP("YYY" + IAJCDKINNOM.updateWelcomeId + "Critical error, could not load asset bundle:", "socialrequestsharegr", LanguageManager.EHBBFMCILPC.MLOLBFBODHD());
		this.bodyText.fontSize = (float)FONPJINLAPG;
		this.buttonText.SetText(BBDKMDOBBAD, true);
		this.buttonText.text = BBDKMDOBBAD;
		this.heartsObject.SetActive(false);
	}

	// Token: 0x06008B9A RID: 35738 RVA: 0x003DCA3D File Offset: 0x003DAC3D
	private void OnDisable()
	{
		this.logoImage.sprite = null;
	}

	// Token: 0x06008B9B RID: 35739 RVA: 0x00003E52 File Offset: 0x00002052
	private void FNNKDFGKAEH()
	{
	}

	// Token: 0x06008B9C RID: 35740 RVA: 0x003DCED3 File Offset: 0x003DB0D3
	public void PLCEOHMHGHG()
	{
		this.animatedPopupManager.FJAAHFFLGFF();
	}

	// Token: 0x06008B9D RID: 35741 RVA: 0x003DDC68 File Offset: 0x003DBE68
	public void NEGDIBLKKGP()
	{
		this.animatedPopupManager.DDPHFKOHDJB();
	}

	// Token: 0x06008B9E RID: 35742 RVA: 0x003DCA3D File Offset: 0x003DAC3D
	private void HKCLEPNKGDH()
	{
		this.logoImage.sprite = null;
	}

	// Token: 0x06008B9F RID: 35743 RVA: 0x003DDC75 File Offset: 0x003DBE75
	public void KIBBJLIFJMN()
	{
		this.animatedPopupManager.GFEHJHIDHFF();
	}

	// Token: 0x06008BA0 RID: 35744 RVA: 0x003DDC84 File Offset: 0x003DBE84
	public void CDAEDOJDJCI(AssetLobbyData IAJCDKINNOM, string BBDKMDOBBAD, string EMGMCANANEJ, int FONPJINLAPG = 28)
	{
		base.gameObject.SetActive(false);
		this.BJOAHAFFEHN = EMGMCANANEJ;
		if (null != IAJCDKINNOM && null != IAJCDKINNOM.updateWelcomeSprite)
		{
			this.logoImage.gameObject.SetActive(false);
			this.logoImage.sprite = IAJCDKINNOM.updateWelcomeSprite;
			this.logoImage.SetNativeSize();
		}
		else
		{
			this.logoImage.sprite = null;
			this.logoImage.gameObject.SetActive(false);
		}
		this.titleText.SetText(GKJPOGNFKNK.DNILNCLIHAP("" + IAJCDKINNOM.updateWelcomeId + "sind", "OnCardUpgradeContinueToPurchasingScreen", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()), false);
		this.titleText.text = GKJPOGNFKNK.DNILNCLIHAP("" + IAJCDKINNOM.updateWelcomeId + "...", "errortitle", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
		this.bodyText.SetText(GKJPOGNFKNK.DNILNCLIHAP("StoriesSearchNormalizer.SetStopwords() - invalid lobby language index " + IAJCDKINNOM.updateWelcomeId + "OnSaveSlotCopyMarked", "af_quantity", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), true);
		this.bodyText.text = GKJPOGNFKNK.DNILNCLIHAP("XXX" + IAJCDKINNOM.updateWelcomeId + "https://ysi-api.shephertz.com/cloud/", "chapterrewindhint0", LanguageManager.EHBBFMCILPC.MLOLBFBODHD());
		this.bodyText.fontSize = (float)FONPJINLAPG;
		this.buttonText.SetText(BBDKMDOBBAD, true);
		this.buttonText.text = BBDKMDOBBAD;
		this.heartsObject.SetActive(false);
	}

	// Token: 0x06008BA1 RID: 35745 RVA: 0x003DDC68 File Offset: 0x003DBE68
	public void KGEFJGNDBAP()
	{
		this.animatedPopupManager.DDPHFKOHDJB();
	}

	// Token: 0x06008BA2 RID: 35746 RVA: 0x003DCA3D File Offset: 0x003DAC3D
	private void KPNNMDECEEH()
	{
		this.logoImage.sprite = null;
	}

	// Token: 0x06008BA3 RID: 35747 RVA: 0x00003E52 File Offset: 0x00002052
	private void LIMPPDFLOOC()
	{
	}

	// Token: 0x06008BA4 RID: 35748 RVA: 0x003DDE0C File Offset: 0x003DC00C
	public void JHNPMNGFEIA(AssetLobbyData IAJCDKINNOM, string BBDKMDOBBAD, string EMGMCANANEJ, int FONPJINLAPG = 28)
	{
		base.gameObject.SetActive(true);
		this.BJOAHAFFEHN = EMGMCANANEJ;
		if (null != IAJCDKINNOM && null != IAJCDKINNOM.updateWelcomeSprite)
		{
			this.logoImage.gameObject.SetActive(true);
			this.logoImage.sprite = IAJCDKINNOM.updateWelcomeSprite;
			this.logoImage.SetNativeSize();
		}
		else
		{
			this.logoImage.sprite = null;
			this.logoImage.gameObject.SetActive(true);
		}
		this.titleText.SetText(GKJPOGNFKNK.DNILNCLIHAP("" + IAJCDKINNOM.updateWelcomeId + "drs", "gpsasar", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), false);
		this.titleText.text = GKJPOGNFKNK.DNILNCLIHAP("retry" + IAJCDKINNOM.updateWelcomeId + "ProductBridge.GetLocalizedCostData() - productBalanceData is null.", "", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
		this.bodyText.SetText(GKJPOGNFKNK.DNILNCLIHAP("iat3" + IAJCDKINNOM.updateWelcomeId + "", "", LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()), false);
		this.bodyText.text = GKJPOGNFKNK.DNILNCLIHAP("energyhinttitle" + IAJCDKINNOM.updateWelcomeId + "OnLobbyWheelDataCdnSuccess", "UNHIDEAVATARCOMPONENT", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
		this.bodyText.fontSize = (float)FONPJINLAPG;
		this.buttonText.SetText(BBDKMDOBBAD, false);
		this.buttonText.text = BBDKMDOBBAD;
		this.heartsObject.SetActive(false);
	}

	// Token: 0x06008BA5 RID: 35749 RVA: 0x003DDF94 File Offset: 0x003DC194
	public void PFIJICGEPMI()
	{
		if (this.BJOAHAFFEHN.Length > 1)
		{
			AOBJLALDBAA.CEGAOMEEFBE().FDKBIBKABCM(this.BJOAHAFFEHN, 100f);
		}
		this.animatedPopupManager.LHNKFOKBBCP();
		this.BJOAHAFFEHN = "w";
	}

	// Token: 0x06008BA6 RID: 35750 RVA: 0x003DCA3D File Offset: 0x003DAC3D
	private void GAPDEAPCICG()
	{
		this.logoImage.sprite = null;
	}

	// Token: 0x06008BA7 RID: 35751 RVA: 0x003DDFCF File Offset: 0x003DC1CF
	public void IBNPGCMNMHI()
	{
		if (this.BJOAHAFFEHN.Length > 0)
		{
			AOBJLALDBAA.FILDBDMENPG().KMAGHMCCMPG(this.BJOAHAFFEHN, 1630f);
		}
		this.animatedPopupManager.LHNKFOKBBCP();
		this.BJOAHAFFEHN = "sslind";
	}

	// Token: 0x06008BA8 RID: 35752 RVA: 0x003DE00C File Offset: 0x003DC20C
	public void HLEAINLNENB(Sprite IBHNGIAHCCM, string EIFJOAOGKMO, string BHJJLJJACFE, string BBDKMDOBBAD, string EMGMCANANEJ, int FONPJINLAPG = 28)
	{
		base.gameObject.SetActive(false);
		this.BJOAHAFFEHN = EMGMCANANEJ;
		if (null != IBHNGIAHCCM)
		{
			this.logoImage.gameObject.SetActive(false);
			this.logoImage.sprite = IBHNGIAHCCM;
			this.logoImage.SetNativeSize();
		}
		else
		{
			this.logoImage.sprite = null;
			this.logoImage.gameObject.SetActive(false);
		}
		this.titleText.SetText(EIFJOAOGKMO, false);
		this.titleText.text = EIFJOAOGKMO;
		this.bodyText.SetText(BHJJLJJACFE, false);
		this.bodyText.text = BHJJLJJACFE;
		this.bodyText.fontSize = (float)FONPJINLAPG;
		this.buttonText.SetText(BBDKMDOBBAD, true);
		this.buttonText.text = BBDKMDOBBAD;
		this.heartsObject.SetActive(false);
	}

	// Token: 0x06008BA9 RID: 35753 RVA: 0x003DE0E4 File Offset: 0x003DC2E4
	public void CMJLOJIDPBP(Sprite IBHNGIAHCCM, string EIFJOAOGKMO, string BHJJLJJACFE, string BBDKMDOBBAD, string EMGMCANANEJ, int FONPJINLAPG = 28)
	{
		base.gameObject.SetActive(false);
		this.BJOAHAFFEHN = EMGMCANANEJ;
		if (null != IBHNGIAHCCM)
		{
			this.logoImage.gameObject.SetActive(true);
			this.logoImage.sprite = IBHNGIAHCCM;
			this.logoImage.SetNativeSize();
		}
		else
		{
			this.logoImage.sprite = null;
			this.logoImage.gameObject.SetActive(true);
		}
		this.titleText.SetText(EIFJOAOGKMO, false);
		this.titleText.text = EIFJOAOGKMO;
		this.bodyText.SetText(BHJJLJJACFE, true);
		this.bodyText.text = BHJJLJJACFE;
		this.bodyText.fontSize = (float)FONPJINLAPG;
		this.buttonText.SetText(BBDKMDOBBAD, true);
		this.buttonText.text = BBDKMDOBBAD;
		this.heartsObject.SetActive(true);
	}

	// Token: 0x06008BAA RID: 35754 RVA: 0x003DE1BC File Offset: 0x003DC3BC
	public void PEKOEFEBAFH()
	{
		if (this.BJOAHAFFEHN.Length > 0)
		{
			AOBJLALDBAA.NMGMNAKLLMI().KGIKHEDLPND(this.BJOAHAFFEHN, 258f);
		}
		this.animatedPopupManager.NBDMOONDIHO();
		this.BJOAHAFFEHN = "";
	}

	// Token: 0x06008BAB RID: 35755 RVA: 0x003DE1F8 File Offset: 0x003DC3F8
	public void FIAGPGENLCM(AssetLobbyData IAJCDKINNOM, string BBDKMDOBBAD, string EMGMCANANEJ, int FONPJINLAPG = 28)
	{
		base.gameObject.SetActive(true);
		this.BJOAHAFFEHN = EMGMCANANEJ;
		if (null != IAJCDKINNOM && null != IAJCDKINNOM.updateWelcomeSprite)
		{
			this.logoImage.gameObject.SetActive(true);
			this.logoImage.sprite = IAJCDKINNOM.updateWelcomeSprite;
			this.logoImage.SetNativeSize();
		}
		else
		{
			this.logoImage.sprite = null;
			this.logoImage.gameObject.SetActive(true);
		}
		this.titleText.SetText(GKJPOGNFKNK.DNILNCLIHAP("forcenoloop" + IAJCDKINNOM.updateWelcomeId + " ", "ok", LanguageManager.EHBBFMCILPC.MLOLBFBODHD()), true);
		this.titleText.text = GKJPOGNFKNK.DNILNCLIHAP("wind" + IAJCDKINNOM.updateWelcomeId + "", "' is not an anthology index, skipping", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ());
		this.bodyText.SetText(GKJPOGNFKNK.DNILNCLIHAP("Error. ShowHideLayer(), environmentLayer " + IAJCDKINNOM.updateWelcomeId + "importanttitle", "errortitle", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), false);
		this.bodyText.text = GKJPOGNFKNK.DNILNCLIHAP("Products fetch failed for {0} products: {1}" + IAJCDKINNOM.updateWelcomeId + "ontradingcardclickbodymatch", "time", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ());
		this.bodyText.fontSize = (float)FONPJINLAPG;
		this.buttonText.SetText(BBDKMDOBBAD, true);
		this.buttonText.text = BBDKMDOBBAD;
		this.heartsObject.SetActive(false);
	}

	// Token: 0x06008BAC RID: 35756 RVA: 0x003DE380 File Offset: 0x003DC580
	public void LDEHCGIBNKM(AssetLobbyData IAJCDKINNOM, string BBDKMDOBBAD, string EMGMCANANEJ, int FONPJINLAPG = 28)
	{
		base.gameObject.SetActive(false);
		this.BJOAHAFFEHN = EMGMCANANEJ;
		if (null != IAJCDKINNOM && null != IAJCDKINNOM.updateWelcomeSprite)
		{
			this.logoImage.gameObject.SetActive(false);
			this.logoImage.sprite = IAJCDKINNOM.updateWelcomeSprite;
			this.logoImage.SetNativeSize();
		}
		else
		{
			this.logoImage.sprite = null;
			this.logoImage.gameObject.SetActive(true);
		}
		this.titleText.SetText(GKJPOGNFKNK.DNILNCLIHAP("envlsav" + IAJCDKINNOM.updateWelcomeId + "socialmaketradeable", "errortitle", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), false);
		this.titleText.text = GKJPOGNFKNK.DNILNCLIHAP("assetbundleframecontainer" + IAJCDKINNOM.updateWelcomeId + "Asset bundle ", "anthology", LanguageManager.EHBBFMCILPC.NBANPEIHFOJ());
		this.bodyText.SetText(GKJPOGNFKNK.DNILNCLIHAP("app42error" + IAJCDKINNOM.updateWelcomeId + "<i>", "OnChapterSnapshotsBackendFetchSuccess2", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), true);
		this.bodyText.text = GKJPOGNFKNK.DNILNCLIHAP("" + IAJCDKINNOM.updateWelcomeId + "cutsceneoptionstitle", "acomp1", LanguageManager.EHBBFMCILPC.NBANPEIHFOJ());
		this.bodyText.fontSize = (float)FONPJINLAPG;
		this.buttonText.SetText(BBDKMDOBBAD, false);
		this.buttonText.text = BBDKMDOBBAD;
		this.heartsObject.SetActive(true);
	}

	// Token: 0x06008BAD RID: 35757 RVA: 0x003DE508 File Offset: 0x003DC708
	public void MAIKOFCFIGC()
	{
		if (this.BJOAHAFFEHN.Length > 1)
		{
			AOBJLALDBAA.FILDBDMENPG().CIGLHCJDDPI(this.BJOAHAFFEHN, 1236f);
		}
		this.animatedPopupManager.Hide();
		this.BJOAHAFFEHN = "mps";
	}

	// Token: 0x06008BAE RID: 35758 RVA: 0x003DE544 File Offset: 0x003DC744
	public void FKCIICNLBKI(AssetLobbyData IAJCDKINNOM, string BBDKMDOBBAD, string EMGMCANANEJ, int FONPJINLAPG = 28)
	{
		base.gameObject.SetActive(true);
		this.BJOAHAFFEHN = EMGMCANANEJ;
		if (null != IAJCDKINNOM && null != IAJCDKINNOM.updateWelcomeSprite)
		{
			this.logoImage.gameObject.SetActive(false);
			this.logoImage.sprite = IAJCDKINNOM.updateWelcomeSprite;
			this.logoImage.SetNativeSize();
		}
		else
		{
			this.logoImage.sprite = null;
			this.logoImage.gameObject.SetActive(false);
		}
		this.titleText.SetText(GKJPOGNFKNK.DNILNCLIHAP("" + IAJCDKINNOM.updateWelcomeId + "OnBackendRequestFriendRejectException", "", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), true);
		this.titleText.text = GKJPOGNFKNK.DNILNCLIHAP("ok" + IAJCDKINNOM.updateWelcomeId + "avind", "energyhinttitle", LanguageManager.EHBBFMCILPC.NBANPEIHFOJ());
		this.bodyText.SetText(GKJPOGNFKNK.DNILNCLIHAP("" + IAJCDKINNOM.updateWelcomeId + "leaves", "", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), false);
		this.bodyText.text = GKJPOGNFKNK.DNILNCLIHAP("stat0" + IAJCDKINNOM.updateWelcomeId + "", "avind", LanguageManager.EHBBFMCILPC.NBANPEIHFOJ());
		this.bodyText.fontSize = (float)FONPJINLAPG;
		this.buttonText.SetText(BBDKMDOBBAD, true);
		this.buttonText.text = BBDKMDOBBAD;
		this.heartsObject.SetActive(true);
	}

	// Token: 0x06008BAF RID: 35759 RVA: 0x003DCA3D File Offset: 0x003DAC3D
	private void KNODFEMMBLA()
	{
		this.logoImage.sprite = null;
	}

	// Token: 0x06008BB0 RID: 35760 RVA: 0x003DE6CC File Offset: 0x003DC8CC
	public void MGLAHIJOPCD(Sprite IBHNGIAHCCM, string EIFJOAOGKMO, string BHJJLJJACFE, string BBDKMDOBBAD, string EMGMCANANEJ, int FONPJINLAPG = 28)
	{
		base.gameObject.SetActive(false);
		this.BJOAHAFFEHN = EMGMCANANEJ;
		if (null != IBHNGIAHCCM)
		{
			this.logoImage.gameObject.SetActive(true);
			this.logoImage.sprite = IBHNGIAHCCM;
			this.logoImage.SetNativeSize();
		}
		else
		{
			this.logoImage.sprite = null;
			this.logoImage.gameObject.SetActive(false);
		}
		this.titleText.SetText(EIFJOAOGKMO, true);
		this.titleText.text = EIFJOAOGKMO;
		this.bodyText.SetText(BHJJLJJACFE, false);
		this.bodyText.text = BHJJLJJACFE;
		this.bodyText.fontSize = (float)FONPJINLAPG;
		this.buttonText.SetText(BBDKMDOBBAD, true);
		this.buttonText.text = BBDKMDOBBAD;
		this.heartsObject.SetActive(true);
	}

	// Token: 0x06008BB1 RID: 35761 RVA: 0x003DCA3D File Offset: 0x003DAC3D
	private void OKKPNPECJKH()
	{
		this.logoImage.sprite = null;
	}

	// Token: 0x06008BB2 RID: 35762 RVA: 0x003DE7A4 File Offset: 0x003DC9A4
	public void OnCloseClick()
	{
		this.animatedPopupManager.Hide();
	}

	// Token: 0x06008BB3 RID: 35763 RVA: 0x003DE7B4 File Offset: 0x003DC9B4
	public void EBLGNGBODBO(AssetLobbyData IAJCDKINNOM, string BBDKMDOBBAD, string EMGMCANANEJ, int FONPJINLAPG = 28)
	{
		base.gameObject.SetActive(false);
		this.BJOAHAFFEHN = EMGMCANANEJ;
		if (null != IAJCDKINNOM && null != IAJCDKINNOM.updateWelcomeSprite)
		{
			this.logoImage.gameObject.SetActive(false);
			this.logoImage.sprite = IAJCDKINNOM.updateWelcomeSprite;
			this.logoImage.SetNativeSize();
		}
		else
		{
			this.logoImage.sprite = null;
			this.logoImage.gameObject.SetActive(false);
		}
		this.titleText.SetText(GKJPOGNFKNK.DNILNCLIHAP("OnBackendValidateTransactionSuccess" + IAJCDKINNOM.updateWelcomeId + "(", ".", LanguageManager.EHBBFMCILPC.MLOLBFBODHD()), false);
		this.titleText.text = GKJPOGNFKNK.DNILNCLIHAP(" tier=" + IAJCDKINNOM.updateWelcomeId + "uid", "CLIENT.VERSION", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ());
		this.bodyText.SetText(GKJPOGNFKNK.DNILNCLIHAP("KKK" + IAJCDKINNOM.updateWelcomeId + "", "Error. ShowHideEnvironmentLayer(), environmentLayer ", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()), true);
		this.bodyText.text = GKJPOGNFKNK.DNILNCLIHAP("$io" + IAJCDKINNOM.updateWelcomeId + "GetStoriesSearchBalance(), headers pack has no storiesSearchBalance TextAsset, stories search disabled.", "", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
		this.bodyText.fontSize = (float)FONPJINLAPG;
		this.buttonText.SetText(BBDKMDOBBAD, true);
		this.buttonText.text = BBDKMDOBBAD;
		this.heartsObject.SetActive(true);
	}

	// Token: 0x06008BB4 RID: 35764 RVA: 0x003DE93C File Offset: 0x003DCB3C
	public void OAKGJGMCBNH()
	{
		this.animatedPopupManager.ADAJPNHIICL();
	}

	// Token: 0x06008BB5 RID: 35765 RVA: 0x003DCA3D File Offset: 0x003DAC3D
	private void ENNCLHFGHDO()
	{
		this.logoImage.sprite = null;
	}

	// Token: 0x06008BB6 RID: 35766 RVA: 0x00003E52 File Offset: 0x00002052
	private void GKFJEFNCPHG()
	{
	}

	// Token: 0x06008BB7 RID: 35767 RVA: 0x003DE949 File Offset: 0x003DCB49
	public void JOEJCBGLPFM()
	{
		if (this.BJOAHAFFEHN.Length > 0)
		{
			AOBJLALDBAA.NMGMNAKLLMI().CIGLHCJDDPI(this.BJOAHAFFEHN, 1258f);
		}
		this.animatedPopupManager.PIPADCCGHBA();
		this.BJOAHAFFEHN = "no";
	}

	// Token: 0x06008BB8 RID: 35768 RVA: 0x003DE984 File Offset: 0x003DCB84
	public void HFAGLFLMIKG(AssetLobbyData IAJCDKINNOM, string BBDKMDOBBAD, string EMGMCANANEJ, int FONPJINLAPG = 28)
	{
		base.gameObject.SetActive(false);
		this.BJOAHAFFEHN = EMGMCANANEJ;
		if (null != IAJCDKINNOM && null != IAJCDKINNOM.updateWelcomeSprite)
		{
			this.logoImage.gameObject.SetActive(true);
			this.logoImage.sprite = IAJCDKINNOM.updateWelcomeSprite;
			this.logoImage.SetNativeSize();
		}
		else
		{
			this.logoImage.sprite = null;
			this.logoImage.gameObject.SetActive(true);
		}
		this.titleText.SetText(GKJPOGNFKNK.DNILNCLIHAP("OnBackendRequestFriendAcceptSuccess" + IAJCDKINNOM.updateWelcomeId + "OnLoungeLoveInterestShortcutClick", "StoryStepChoiceExtended.RemoveChoiceAtEnd - _choicesToRemove is <= 0.", LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()), false);
		this.titleText.text = GKJPOGNFKNK.DNILNCLIHAP("avatarcollectionstutor4title" + IAJCDKINNOM.updateWelcomeId + "", "OnApplicationFocusBasicSyncSuccess", LanguageManager.EHBBFMCILPC.MLOLBFBODHD());
		this.bodyText.SetText(GKJPOGNFKNK.DNILNCLIHAP("OnChapterSnapshotsBackendFetchException2" + IAJCDKINNOM.updateWelcomeId + "getNpcSkinShopBalance", "saveslotsduplicatepos", LanguageManager.EHBBFMCILPC.MLOLBFBODHD()), false);
		this.bodyText.text = GKJPOGNFKNK.DNILNCLIHAP("locked" + IAJCDKINNOM.updateWelcomeId + "LobbySearchBar - layout was changed by a native-size pass (anchors ", ") shopcur(", LanguageManager.EHBBFMCILPC.NBANPEIHFOJ());
		this.bodyText.fontSize = (float)FONPJINLAPG;
		this.buttonText.SetText(BBDKMDOBBAD, true);
		this.buttonText.text = BBDKMDOBBAD;
		this.heartsObject.SetActive(false);
	}

	// Token: 0x06008BB9 RID: 35769 RVA: 0x003DEB0C File Offset: 0x003DCD0C
	public void PGOCMIMGNDK(AssetLobbyData IAJCDKINNOM, string BBDKMDOBBAD, string EMGMCANANEJ, int FONPJINLAPG = 28)
	{
		base.gameObject.SetActive(false);
		this.BJOAHAFFEHN = EMGMCANANEJ;
		if (null != IAJCDKINNOM && null != IAJCDKINNOM.updateWelcomeSprite)
		{
			this.logoImage.gameObject.SetActive(true);
			this.logoImage.sprite = IAJCDKINNOM.updateWelcomeSprite;
			this.logoImage.SetNativeSize();
		}
		else
		{
			this.logoImage.sprite = null;
			this.logoImage.gameObject.SetActive(false);
		}
		this.titleText.SetText(GKJPOGNFKNK.DNILNCLIHAP("XXX" + IAJCDKINNOM.updateWelcomeId + "", "$USEEMOTIONSV2", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()), false);
		this.titleText.text = GKJPOGNFKNK.DNILNCLIHAP("" + IAJCDKINNOM.updateWelcomeId + "", "shown", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
		this.bodyText.SetText(GKJPOGNFKNK.DNILNCLIHAP("episode" + IAJCDKINNOM.updateWelcomeId + "KKK", "badges", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), false);
		this.bodyText.text = GKJPOGNFKNK.DNILNCLIHAP("rwt" + IAJCDKINNOM.updateWelcomeId + "avtssnap1", "", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
		this.bodyText.fontSize = (float)FONPJINLAPG;
		this.buttonText.SetText(BBDKMDOBBAD, true);
		this.buttonText.text = BBDKMDOBBAD;
		this.heartsObject.SetActive(true);
	}

	// Token: 0x06008BBA RID: 35770 RVA: 0x003DEC94 File Offset: 0x003DCE94
	public void NIENEPGJEFL(AssetLobbyData IAJCDKINNOM, string BBDKMDOBBAD, string EMGMCANANEJ, int FONPJINLAPG = 28)
	{
		base.gameObject.SetActive(false);
		this.BJOAHAFFEHN = EMGMCANANEJ;
		if (null != IAJCDKINNOM && null != IAJCDKINNOM.updateWelcomeSprite)
		{
			this.logoImage.gameObject.SetActive(true);
			this.logoImage.sprite = IAJCDKINNOM.updateWelcomeSprite;
			this.logoImage.SetNativeSize();
		}
		else
		{
			this.logoImage.sprite = null;
			this.logoImage.gameObject.SetActive(true);
		}
		this.titleText.SetText(GKJPOGNFKNK.DNILNCLIHAP("\"" + IAJCDKINNOM.updateWelcomeId + "[LoadingEnv] loading theme set: ", "PurchaseManagerSteam.Initialize(): Unity Gaming Services not initialized.", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), false);
		this.titleText.text = GKJPOGNFKNK.DNILNCLIHAP("WideScreenScaler(): reverted scale to original" + IAJCDKINNOM.updateWelcomeId + "[Steamworks.NET] Shutting down because RestartAppIfNecessary returned true. Steam will restart the application.", "OnFullscreenCardOptionClick", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ());
		this.bodyText.SetText(GKJPOGNFKNK.DNILNCLIHAP("msg64" + IAJCDKINNOM.updateWelcomeId + "time", "", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), false);
		this.bodyText.text = GKJPOGNFKNK.DNILNCLIHAP("Video:" + IAJCDKINNOM.updateWelcomeId + "assetbundleavatarpack", "</i>", LanguageManager.EHBBFMCILPC.NBANPEIHFOJ());
		this.bodyText.fontSize = (float)FONPJINLAPG;
		this.buttonText.SetText(BBDKMDOBBAD, true);
		this.buttonText.text = BBDKMDOBBAD;
		this.heartsObject.SetActive(false);
	}

	// Token: 0x06008BBB RID: 35771 RVA: 0x003DD62C File Offset: 0x003DB82C
	public void AJMDPPLNPNC()
	{
		this.animatedPopupManager.PIPADCCGHBA();
	}

	// Token: 0x06008BBC RID: 35772 RVA: 0x00003E52 File Offset: 0x00002052
	private void PMKKOENBNOM()
	{
	}

	// Token: 0x06008BBE RID: 35774 RVA: 0x00003E52 File Offset: 0x00002052
	private void JLCMPLIMAEI()
	{
	}

	// Token: 0x06008BBF RID: 35775 RVA: 0x00003E52 File Offset: 0x00002052
	private void Start()
	{
	}

	// Token: 0x06008BC0 RID: 35776 RVA: 0x003DEE2F File Offset: 0x003DD02F
	public void MKDKGJJFLKE()
	{
		if (this.BJOAHAFFEHN.Length > 1)
		{
			AOBJLALDBAA.EHBBFMCILPC.FDKBIBKABCM(this.BJOAHAFFEHN, 1879f);
		}
		this.animatedPopupManager.Hide();
		this.BJOAHAFFEHN = "SocialStatsUserPublicProfile.modified = true, SetCompletedChaptersCount()";
	}

	// Token: 0x06008BC1 RID: 35777 RVA: 0x00003E52 File Offset: 0x00002052
	private void BIJFJADIAOK()
	{
	}

	// Token: 0x06008BC2 RID: 35778 RVA: 0x00003E52 File Offset: 0x00002052
	private void OPGODKBEGAK()
	{
	}

	// Token: 0x06008BC3 RID: 35779 RVA: 0x00003E52 File Offset: 0x00002052
	private void MAIBLFFBJAA()
	{
	}

	// Token: 0x06008BC4 RID: 35780 RVA: 0x003DEE6A File Offset: 0x003DD06A
	public void OKHJKLJOCEP()
	{
		if (this.BJOAHAFFEHN.Length > 1)
		{
			AOBJLALDBAA.KKPFOJMAONG().EFBNBFIDEOK(this.BJOAHAFFEHN, 1447f);
		}
		this.animatedPopupManager.Hide();
		this.BJOAHAFFEHN = "avatarcollectionssyncdone";
	}

	// Token: 0x06008BC5 RID: 35781 RVA: 0x003DEEA5 File Offset: 0x003DD0A5
	public void EKFPIMDODPH()
	{
		if (this.BJOAHAFFEHN.Length > 1)
		{
			AOBJLALDBAA.BIAEAOMHBMM().FDKBIBKABCM(this.BJOAHAFFEHN, 1801f);
		}
		this.animatedPopupManager.ADAJPNHIICL();
		this.BJOAHAFFEHN = "syn";
	}

	// Token: 0x06008BC6 RID: 35782 RVA: 0x003DDC75 File Offset: 0x003DBE75
	public void CHEBHNOAMOF()
	{
		this.animatedPopupManager.GFEHJHIDHFF();
	}

	// Token: 0x06008BC7 RID: 35783 RVA: 0x003DCA3D File Offset: 0x003DAC3D
	private void GBIDDHNBECB()
	{
		this.logoImage.sprite = null;
	}

	// Token: 0x06008BC8 RID: 35784 RVA: 0x003DD639 File Offset: 0x003DB839
	public void INKNPCHDDED()
	{
		this.animatedPopupManager.HFFJACPIHKE();
	}

	// Token: 0x06008BC9 RID: 35785 RVA: 0x003DEEE0 File Offset: 0x003DD0E0
	public void JEFCEGCGFFC(AssetLobbyData IAJCDKINNOM, string BBDKMDOBBAD, string EMGMCANANEJ, int FONPJINLAPG = 28)
	{
		base.gameObject.SetActive(true);
		this.BJOAHAFFEHN = EMGMCANANEJ;
		if (null != IAJCDKINNOM && null != IAJCDKINNOM.updateWelcomeSprite)
		{
			this.logoImage.gameObject.SetActive(false);
			this.logoImage.sprite = IAJCDKINNOM.updateWelcomeSprite;
			this.logoImage.SetNativeSize();
		}
		else
		{
			this.logoImage.sprite = null;
			this.logoImage.gameObject.SetActive(false);
		}
		this.titleText.SetText(GKJPOGNFKNK.DNILNCLIHAP("" + IAJCDKINNOM.updateWelcomeId + "<size=28px>", "Vol", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), false);
		this.titleText.text = GKJPOGNFKNK.DNILNCLIHAP("ok" + IAJCDKINNOM.updateWelcomeId + "<i>", "common", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ());
		this.bodyText.SetText(GKJPOGNFKNK.DNILNCLIHAP("BackendOperationsManager.RequestGetUserSketches, exception while initializing RSACryptoServiceProvider:" + IAJCDKINNOM.updateWelcomeId + "adb", "", LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()), true);
		this.bodyText.text = GKJPOGNFKNK.DNILNCLIHAP("[Lounge/lobby] look pack eps:" + IAJCDKINNOM.updateWelcomeId + "BackendOperationsManager.RequestSaveSync, exception while initializing RSACryptoServiceProvider:", "", LanguageManager.EHBBFMCILPC.NBANPEIHFOJ());
		this.bodyText.fontSize = (float)FONPJINLAPG;
		this.buttonText.SetText(BBDKMDOBBAD, true);
		this.buttonText.text = BBDKMDOBBAD;
		this.heartsObject.SetActive(false);
	}

	// Token: 0x06008BCA RID: 35786 RVA: 0x003DE7A4 File Offset: 0x003DC9A4
	public void LOHDMPJKEGI()
	{
		this.animatedPopupManager.Hide();
	}

	// Token: 0x06008BCB RID: 35787 RVA: 0x003DF068 File Offset: 0x003DD268
	public void IBPGOFNJKPH()
	{
		if (this.BJOAHAFFEHN.Length > 0)
		{
			AOBJLALDBAA.BIAEAOMHBMM().LPNCDPHNBJK(this.BJOAHAFFEHN, 623f);
		}
		this.animatedPopupManager.NBDMOONDIHO();
		this.BJOAHAFFEHN = "XXX";
	}

	// Token: 0x06008BCC RID: 35788 RVA: 0x003DCA3D File Offset: 0x003DAC3D
	private void GNNCNJMOOFI()
	{
		this.logoImage.sprite = null;
	}

	// Token: 0x06008BCD RID: 35789 RVA: 0x003DF0A4 File Offset: 0x003DD2A4
	public void HAJNGFEKANI(Sprite IBHNGIAHCCM, string EIFJOAOGKMO, string BHJJLJJACFE, string BBDKMDOBBAD, string EMGMCANANEJ, int FONPJINLAPG = 28)
	{
		base.gameObject.SetActive(true);
		this.BJOAHAFFEHN = EMGMCANANEJ;
		if (null != IBHNGIAHCCM)
		{
			this.logoImage.gameObject.SetActive(true);
			this.logoImage.sprite = IBHNGIAHCCM;
			this.logoImage.SetNativeSize();
		}
		else
		{
			this.logoImage.sprite = null;
			this.logoImage.gameObject.SetActive(false);
		}
		this.titleText.SetText(EIFJOAOGKMO, true);
		this.titleText.text = EIFJOAOGKMO;
		this.bodyText.SetText(BHJJLJJACFE, true);
		this.bodyText.text = BHJJLJJACFE;
		this.bodyText.fontSize = (float)FONPJINLAPG;
		this.buttonText.SetText(BBDKMDOBBAD, false);
		this.buttonText.text = BBDKMDOBBAD;
		this.heartsObject.SetActive(false);
	}

	// Token: 0x06008BCE RID: 35790 RVA: 0x003DCA3D File Offset: 0x003DAC3D
	private void GLNCODMMIFJ()
	{
		this.logoImage.sprite = null;
	}

	// Token: 0x06008BCF RID: 35791 RVA: 0x003DF17C File Offset: 0x003DD37C
	public void LFMPEJFLIOC()
	{
		if (this.BJOAHAFFEHN.Length > 0)
		{
			AOBJLALDBAA.BIAEAOMHBMM().CIGLHCJDDPI(this.BJOAHAFFEHN, 1060f);
		}
		this.animatedPopupManager.NBDMOONDIHO();
		this.BJOAHAFFEHN = "comingsoontitle3";
	}

	// Token: 0x06008BD0 RID: 35792 RVA: 0x003DE7A4 File Offset: 0x003DC9A4
	public void OHEDIJEIDOJ()
	{
		this.animatedPopupManager.Hide();
	}

	// Token: 0x06008BD1 RID: 35793 RVA: 0x003DCA30 File Offset: 0x003DAC30
	public void JNPDPEGOIKA()
	{
		this.animatedPopupManager.KCAPIILJKDN();
	}

	// Token: 0x06008BD2 RID: 35794 RVA: 0x00003E52 File Offset: 0x00002052
	private void MADHLGLFNNN()
	{
	}

	// Token: 0x06008BD3 RID: 35795 RVA: 0x003DF1B8 File Offset: 0x003DD3B8
	public void HKKLNDKIHOE(Sprite IBHNGIAHCCM, string EIFJOAOGKMO, string BHJJLJJACFE, string BBDKMDOBBAD, string EMGMCANANEJ, int FONPJINLAPG = 28)
	{
		base.gameObject.SetActive(true);
		this.BJOAHAFFEHN = EMGMCANANEJ;
		if (null != IBHNGIAHCCM)
		{
			this.logoImage.gameObject.SetActive(false);
			this.logoImage.sprite = IBHNGIAHCCM;
			this.logoImage.SetNativeSize();
		}
		else
		{
			this.logoImage.sprite = null;
			this.logoImage.gameObject.SetActive(true);
		}
		this.titleText.SetText(EIFJOAOGKMO, false);
		this.titleText.text = EIFJOAOGKMO;
		this.bodyText.SetText(BHJJLJJACFE, true);
		this.bodyText.text = BHJJLJJACFE;
		this.bodyText.fontSize = (float)FONPJINLAPG;
		this.buttonText.SetText(BBDKMDOBBAD, false);
		this.buttonText.text = BBDKMDOBBAD;
		this.heartsObject.SetActive(false);
	}

	// Token: 0x06008BD4 RID: 35796 RVA: 0x003DF290 File Offset: 0x003DD490
	public void CLNIBLIIABP()
	{
		if (this.BJOAHAFFEHN.Length > 0)
		{
			AOBJLALDBAA.DBLAIDPICIG().KGIKHEDLPND(this.BJOAHAFFEHN, 816f);
		}
		this.animatedPopupManager.HFFJACPIHKE();
		this.BJOAHAFFEHN = "";
	}

	// Token: 0x06008BD5 RID: 35797 RVA: 0x003DF2CB File Offset: 0x003DD4CB
	public void DKFGBMNBNPE()
	{
		if (this.BJOAHAFFEHN.Length > 0)
		{
			AOBJLALDBAA.FILDBDMENPG().KMAGHMCCMPG(this.BJOAHAFFEHN, 1370f);
		}
		this.animatedPopupManager.GFEHJHIDHFF();
		this.BJOAHAFFEHN = "LoadingEnvironmentCover";
	}

	// Token: 0x06008BD6 RID: 35798 RVA: 0x003DF308 File Offset: 0x003DD508
	public void DFGKFMEHDKH(Sprite IBHNGIAHCCM, string EIFJOAOGKMO, string BHJJLJJACFE, string BBDKMDOBBAD, string EMGMCANANEJ, int FONPJINLAPG = 28)
	{
		base.gameObject.SetActive(true);
		this.BJOAHAFFEHN = EMGMCANANEJ;
		if (null != IBHNGIAHCCM)
		{
			this.logoImage.gameObject.SetActive(true);
			this.logoImage.sprite = IBHNGIAHCCM;
			this.logoImage.SetNativeSize();
		}
		else
		{
			this.logoImage.sprite = null;
			this.logoImage.gameObject.SetActive(false);
		}
		this.titleText.SetText(EIFJOAOGKMO, false);
		this.titleText.text = EIFJOAOGKMO;
		this.bodyText.SetText(BHJJLJJACFE, true);
		this.bodyText.text = BHJJLJJACFE;
		this.bodyText.fontSize = (float)FONPJINLAPG;
		this.buttonText.SetText(BBDKMDOBBAD, false);
		this.buttonText.text = BBDKMDOBBAD;
		this.heartsObject.SetActive(false);
	}

	// Token: 0x06008BD7 RID: 35799 RVA: 0x003DDC75 File Offset: 0x003DBE75
	public void CLOKOJJILLB()
	{
		this.animatedPopupManager.GFEHJHIDHFF();
	}

	// Token: 0x06008BD8 RID: 35800 RVA: 0x003DF3E0 File Offset: 0x003DD5E0
	public void EAONILBNBKJ()
	{
		if (this.BJOAHAFFEHN.Length > 1)
		{
			AOBJLALDBAA.EHBBFMCILPC.LPNCDPHNBJK(this.BJOAHAFFEHN, 454f);
		}
		this.animatedPopupManager.DDPHFKOHDJB();
		this.BJOAHAFFEHN = "ok";
	}

	// Token: 0x06008BD9 RID: 35801 RVA: 0x003DF41C File Offset: 0x003DD61C
	public void DJAILKGJAME(AssetLobbyData IAJCDKINNOM, string BBDKMDOBBAD, string EMGMCANANEJ, int FONPJINLAPG = 28)
	{
		base.gameObject.SetActive(false);
		this.BJOAHAFFEHN = EMGMCANANEJ;
		if (null != IAJCDKINNOM && null != IAJCDKINNOM.updateWelcomeSprite)
		{
			this.logoImage.gameObject.SetActive(true);
			this.logoImage.sprite = IAJCDKINNOM.updateWelcomeSprite;
			this.logoImage.SetNativeSize();
		}
		else
		{
			this.logoImage.sprite = null;
			this.logoImage.gameObject.SetActive(false);
		}
		this.titleText.SetText(GKJPOGNFKNK.DNILNCLIHAP("@" + IAJCDKINNOM.updateWelcomeId + "OnPopupCardOptionsNextClick", "XXX", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()), true);
		this.titleText.text = GKJPOGNFKNK.DNILNCLIHAP("post" + IAJCDKINNOM.updateWelcomeId + "OnCutsceneViewAssetBundleFolderInitializeSuccess", " (", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
		this.bodyText.SetText(GKJPOGNFKNK.DNILNCLIHAP("App was minimized" + IAJCDKINNOM.updateWelcomeId + "HIDEAVATARCOMPONENT", "SceneLobbyManager2.PreInitializeAssetBundleFolder(): AssetsManager.Instance.IsBusy()", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()), true);
		this.bodyText.text = GKJPOGNFKNK.DNILNCLIHAP("] | " + IAJCDKINNOM.updateWelcomeId + "w", "af_order_id", LanguageManager.EHBBFMCILPC.NBANPEIHFOJ());
		this.bodyText.fontSize = (float)FONPJINLAPG;
		this.buttonText.SetText(BBDKMDOBBAD, true);
		this.buttonText.text = BBDKMDOBBAD;
		this.heartsObject.SetActive(false);
	}

	// Token: 0x06008BDA RID: 35802 RVA: 0x00003E52 File Offset: 0x00002052
	private void HKJPPMMKGLP()
	{
	}

	// Token: 0x06008BDB RID: 35803 RVA: 0x003DF5A4 File Offset: 0x003DD7A4
	public void HGPIOMFPLIF(Sprite IBHNGIAHCCM, string EIFJOAOGKMO, string BHJJLJJACFE, string BBDKMDOBBAD, string EMGMCANANEJ, int FONPJINLAPG = 28)
	{
		base.gameObject.SetActive(true);
		this.BJOAHAFFEHN = EMGMCANANEJ;
		if (null != IBHNGIAHCCM)
		{
			this.logoImage.gameObject.SetActive(true);
			this.logoImage.sprite = IBHNGIAHCCM;
			this.logoImage.SetNativeSize();
		}
		else
		{
			this.logoImage.sprite = null;
			this.logoImage.gameObject.SetActive(false);
		}
		this.titleText.SetText(EIFJOAOGKMO, true);
		this.titleText.text = EIFJOAOGKMO;
		this.bodyText.SetText(BHJJLJJACFE, false);
		this.bodyText.text = BHJJLJJACFE;
		this.bodyText.fontSize = (float)FONPJINLAPG;
		this.buttonText.SetText(BBDKMDOBBAD, true);
		this.buttonText.text = BBDKMDOBBAD;
		this.heartsObject.SetActive(true);
	}

	// Token: 0x06008BDC RID: 35804 RVA: 0x00003E52 File Offset: 0x00002052
	private void OMNGHDNDLKP()
	{
	}

	// Token: 0x06008BDD RID: 35805 RVA: 0x003DF67C File Offset: 0x003DD87C
	public void EHOJOPHIEMC()
	{
		if (this.BJOAHAFFEHN.Length > 0)
		{
			AOBJLALDBAA.CEGAOMEEFBE().DCGCFPHHDDG(this.BJOAHAFFEHN, 867f);
		}
		this.animatedPopupManager.ADAJPNHIICL();
		this.BJOAHAFFEHN = "PurchaseManagerSteam.OnSuccessInitializeGamingServices()!";
	}

	// Token: 0x04002725 RID: 10021
	public AnimatedPopupManager animatedPopupManager;

	// Token: 0x04002726 RID: 10022
	public TextMeshProUGUI titleText;

	// Token: 0x04002727 RID: 10023
	public TextMeshProUGUI bodyText;

	// Token: 0x04002728 RID: 10024
	public TextMeshProUGUI buttonText;

	// Token: 0x04002729 RID: 10025
	public Image logoImage;

	// Token: 0x0400272A RID: 10026
	public GameObject heartsObject;

	// Token: 0x0400272B RID: 10027
	private string BJOAHAFFEHN = "";
}
