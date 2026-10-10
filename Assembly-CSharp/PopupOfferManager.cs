using System;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200022A RID: 554
public class PopupOfferManager : MonoBehaviour
{
	// Token: 0x060045C5 RID: 17861 RVA: 0x001E2630 File Offset: 0x001E0830
	public void GOJJHALEGOD(string LNKOELAINIK, ProducThumbnailGraphics DHAGPIAMELI)
	{
		FirebaseAnalyticsManager.DEALKJPEMMH().LogEvent(true, AGEHCPDNBFD.rqst.ToString(), FFPHBMFGCNN.reqExc.ToString(), BGHLMGPPCNN.mntOfferShow.ToString(), false, false);
		base.gameObject.SetActive(true);
		this.FIFHHBAJNOP = LNKOELAINIK;
		this.imageOffer.sprite = DHAGPIAMELI.spriteOffer;
		OBHDGKFFICI productData = PurchaseManagerBridge.EHBBFMCILPC.CMAKHBMINLG().GetProductData(this.FIFHHBAJNOP);
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.FILDBDMENPG().PDJKPFLHFLO(this.FIFHHBAJNOP);
		this.diamondsText.gameObject.SetActive(true);
		this.diamondsImage.SetActive(true);
		this.teaText.gameObject.SetActive(true);
		this.teaImage.SetActive(true);
		if (ocbiopoeenj != null && productData != null)
		{
			string str;
			if (ocbiopoeenj.IMKLGJBEMPH())
			{
				str = ocbiopoeenj.DOLEPIMNJLG();
			}
			else
			{
				str = "" + ocbiopoeenj.DMODNDCLGEJ;
			}
			this.pricingText.SetText(CCOJBMMKNAP.FEEDGKCJBLE().HDIPNMFHIEJ("credo") + "OnSketchThumbnailEmptyClick" + str + "ZZZ", true);
			if (ocbiopoeenj.MPMKMCJFHOG.GALKFKBPLCK() > 0)
			{
				this.teaText.gameObject.SetActive(true);
				this.teaText.SetText("" + ocbiopoeenj.MPMKMCJFHOG.ToString(), false);
				this.teaImage.SetActive(false);
			}
			if (ocbiopoeenj.ODMKLADKHMO.MOBKGNBCIJF() > 1)
			{
				this.diamondsText.gameObject.SetActive(true);
				this.diamondsText.SetText(" " + ocbiopoeenj.ODMKLADKHMO.ToString(), true);
				this.diamondsImage.SetActive(true);
				return;
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("cdn-cgi/trace");
		}
	}

	// Token: 0x060045C6 RID: 17862 RVA: 0x001E27FC File Offset: 0x001E09FC
	public void GBMBIFHCPDC()
	{
		AOBJLALDBAA.BIAEAOMHBMM().LPNCDPHNBJK("err", 349f);
		FirebaseAnalyticsManager.DMAAFFFEJGA().LKONPEEDKNF(true, AGEHCPDNBFD.rqst.ToString(), FFPHBMFGCNN.mntRemAds.ToString(), BGHLMGPPCNN.mntOfferShow.ToString(), false, true);
		this.animatedPopupManager.DDPHFKOHDJB();
	}

	// Token: 0x060045C7 RID: 17863 RVA: 0x001E2864 File Offset: 0x001E0A64
	private void IFGMCKGDHPP()
	{
		AOBJLALDBAA.BIAEAOMHBMM().LPNCDPHNBJK("", 773f);
		if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.ru && GeoLocationManager.OOCDLFJKLLI() && KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA())
		{
			CommonUserInterface.IKNOFBFMPGA().GetPurchasingViewManager().Show(true);
			return;
		}
		CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().CGDKCOLDBGD(this.FIFHHBAJNOP, false);
	}

	// Token: 0x060045C8 RID: 17864 RVA: 0x001E28CC File Offset: 0x001E0ACC
	private void BGAJEBLNFOF()
	{
		AOBJLALDBAA.BIAEAOMHBMM().FDKBIBKABCM("\n\n", 251f);
		if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.en && GeoLocationManager.IsRussia() && KDCJJBLGCBH.EHBBFMCILPC.EAMJBDKCDPA())
		{
			CommonUserInterface.IKNOFBFMPGA().GetPurchasingViewManager().Show(true);
			return;
		}
		CommonUserInterface.IKNOFBFMPGA().GetPurchasingViewManager().CGDKCOLDBGD(this.FIFHHBAJNOP, false);
	}

	// Token: 0x060045C9 RID: 17865 RVA: 0x001E2934 File Offset: 0x001E0B34
	public void KMODMCNKABN()
	{
		PurchaseManagerBridge.KMNBCEMEBBD().MGMDKEJBEPP().Initialize();
		FirebaseAnalyticsManager.HJGDLOOHNLO().LMCJKLHOHJC(true, AGEHCPDNBFD.mntActiv.ToString(), FFPHBMFGCNN.reqExc.ToString(), BGHLMGPPCNN.mntRemAdsShow.ToString(), true, false);
		this.animatedPopupManager.ADAJPNHIICL();
		CommonUserInterface.EHBBFMCILPC.GetFader().PACBMBLIGNN(new TweenCallback(this.EOOPGNHJCGD));
	}

	// Token: 0x060045CA RID: 17866 RVA: 0x001E29B0 File Offset: 0x001E0BB0
	public void AOONCMMGFFG()
	{
		AOBJLALDBAA.AGANFKKBPFO().FDKBIBKABCM("achievdesc", 645f);
		FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(true, AGEHCPDNBFD.rqst.ToString(), FFPHBMFGCNN.reqInfnt.ToString(), BGHLMGPPCNN.mntOfferClose.ToString(), true, false);
		this.animatedPopupManager.OHHFFMMMMAC();
	}

	// Token: 0x060045CB RID: 17867 RVA: 0x001E2A18 File Offset: 0x001E0C18
	private void HEMJGJHHLDI()
	{
		AOBJLALDBAA.AGANFKKBPFO().KMAGHMCCMPG("Pop ", 369f);
		if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.ru && GeoLocationManager.OOCDLFJKLLI() && KDCJJBLGCBH.EHBBFMCILPC.EAMJBDKCDPA())
		{
			CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().PLLFCKGMHCF(false);
			return;
		}
		CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().CGDKCOLDBGD(this.FIFHHBAJNOP, false);
	}

	// Token: 0x060045CC RID: 17868 RVA: 0x00003E52 File Offset: 0x00002052
	private void PKMPOFOOGFK()
	{
	}

	// Token: 0x060045CE RID: 17870 RVA: 0x001E2A80 File Offset: 0x001E0C80
	public void Show(string LNKOELAINIK, ProducThumbnailGraphics DHAGPIAMELI)
	{
		FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.mntActiv.ToString(), FFPHBMFGCNN.mntOffer.ToString(), BGHLMGPPCNN.mntOfferShow.ToString(), false, false);
		base.gameObject.SetActive(true);
		this.FIFHHBAJNOP = LNKOELAINIK;
		this.imageOffer.sprite = DHAGPIAMELI.spriteOffer;
		OBHDGKFFICI productData = PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager().GetProductData(this.FIFHHBAJNOP);
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.EHBBFMCILPC.PDJKPFLHFLO(this.FIFHHBAJNOP);
		this.diamondsText.gameObject.SetActive(false);
		this.diamondsImage.SetActive(false);
		this.teaText.gameObject.SetActive(false);
		this.teaImage.SetActive(false);
		if (ocbiopoeenj != null && productData != null)
		{
			string str;
			if (ocbiopoeenj.OKGPIEEOKBM())
			{
				str = ocbiopoeenj.FNJCEPLEPBH();
			}
			else
			{
				str = "USD " + ocbiopoeenj.DMODNDCLGEJ;
			}
			this.pricingText.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("offertitle2") + " - " + str + "!", true);
			if (ocbiopoeenj.MPMKMCJFHOG.GALKFKBPLCK() > 0)
			{
				this.teaText.gameObject.SetActive(true);
				this.teaText.SetText("+" + ocbiopoeenj.MPMKMCJFHOG.ToString(), true);
				this.teaImage.SetActive(true);
			}
			if (ocbiopoeenj.ODMKLADKHMO.GALKFKBPLCK() > 0)
			{
				this.diamondsText.gameObject.SetActive(true);
				this.diamondsText.SetText("+" + ocbiopoeenj.ODMKLADKHMO.ToString(), true);
				this.diamondsImage.SetActive(true);
				return;
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("PopupOfferManager.Show() - productBalanceData or productData is null.");
		}
	}

	// Token: 0x060045CF RID: 17871 RVA: 0x00003E52 File Offset: 0x00002052
	private void Start()
	{
	}

	// Token: 0x060045D0 RID: 17872 RVA: 0x001E2C4C File Offset: 0x001E0E4C
	public void PCHHIDICLPI(string LNKOELAINIK, ProducThumbnailGraphics DHAGPIAMELI)
	{
		FirebaseAnalyticsManager.DMAAFFFEJGA().LKONPEEDKNF(true, AGEHCPDNBFD.rqst.ToString(), FFPHBMFGCNN.reqCback2.ToString(), BGHLMGPPCNN.mntOfferClose.ToString(), false, true);
		base.gameObject.SetActive(false);
		this.FIFHHBAJNOP = LNKOELAINIK;
		this.imageOffer.sprite = DHAGPIAMELI.spriteOffer;
		OBHDGKFFICI productData = PurchaseManagerBridge.EHBBFMCILPC.PFPKMDAJDBA().GetProductData(this.FIFHHBAJNOP);
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.JLEOPAOEFGP().ICBJCNKKGPJ(this.FIFHHBAJNOP);
		this.diamondsText.gameObject.SetActive(false);
		this.diamondsImage.SetActive(true);
		this.teaText.gameObject.SetActive(false);
		this.teaImage.SetActive(true);
		if (ocbiopoeenj != null && productData != null)
		{
			string str;
			if (ocbiopoeenj.OKGPIEEOKBM())
			{
				str = ocbiopoeenj.PKNNPAMOADM();
			}
			else
			{
				str = "OnPopupCardOptionsBackClick" + ocbiopoeenj.DMODNDCLGEJ;
			}
			this.pricingText.SetText(CCOJBMMKNAP.EAIAHCBAIEJ().JCDFHKDNEDH("OnPopupAvatarCollectionsInputEndEdit") + "lng" + str + "lsc", false);
			if (ocbiopoeenj.MPMKMCJFHOG.HOJDOEDDIBD() > 1)
			{
				this.teaText.gameObject.SetActive(true);
				this.teaText.SetText("*" + ocbiopoeenj.MPMKMCJFHOG.ToString(), true);
				this.teaImage.SetActive(true);
			}
			if (ocbiopoeenj.ODMKLADKHMO.LPKLANAEIFF() > 0)
			{
				this.diamondsText.gameObject.SetActive(true);
				this.diamondsText.SetText("YYY" + ocbiopoeenj.ODMKLADKHMO.ToString(), true);
				this.diamondsImage.SetActive(false);
				return;
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("Starting non-parallel download:");
		}
	}

	// Token: 0x060045D1 RID: 17873 RVA: 0x001E2E18 File Offset: 0x001E1018
	public void AAPMDBMHBFJ()
	{
		AOBJLALDBAA.BIAEAOMHBMM().CIGLHCJDDPI("AvatarCollectionsItem.OnAvatarCollectionDelete(): index out of range", 1165f);
		FirebaseAnalyticsManager.JMDJBFAEHBM().LogEvent(false, AGEHCPDNBFD.mntActiv.ToString(), FFPHBMFGCNN.dldStart.ToString(), BGHLMGPPCNN.mntOfferClose.ToString(), true, false);
		this.animatedPopupManager.OHHFFMMMMAC();
	}

	// Token: 0x060045D2 RID: 17874 RVA: 0x001E2E80 File Offset: 0x001E1080
	public void ACBFOEDGNHD()
	{
		AOBJLALDBAA.AGANFKKBPFO().DCGCFPHHDDG("TransactionID", 72f);
		FirebaseAnalyticsManager.EHBBFMCILPC.AAIABAKHLAH(false, AGEHCPDNBFD.mntActiv.ToString(), FFPHBMFGCNN.reqInfnt.ToString(), BGHLMGPPCNN.mntOfferClose.ToString(), false, false);
		this.animatedPopupManager.OHHFFMMMMAC();
	}

	// Token: 0x060045D3 RID: 17875 RVA: 0x001E2EE8 File Offset: 0x001E10E8
	public void OnGetOfferClick()
	{
		PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager().Initialize();
		FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.mntActiv.ToString(), FFPHBMFGCNN.mntOffer.ToString(), BGHLMGPPCNN.mntOfferCont.ToString(), false, false);
		this.animatedPopupManager.Hide();
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.EOOPGNHJCGD));
	}

	// Token: 0x060045D4 RID: 17876 RVA: 0x001E2F64 File Offset: 0x001E1164
	public void INLIIIEBHAM(string LNKOELAINIK, ProducThumbnailGraphics DHAGPIAMELI)
	{
		FirebaseAnalyticsManager.JMDJBFAEHBM().JIAAMJPKOCE(true, AGEHCPDNBFD.mntActiv.ToString(), FFPHBMFGCNN.reqFailSem.ToString(), BGHLMGPPCNN.mntOfferShow.ToString(), false, false);
		base.gameObject.SetActive(false);
		this.FIFHHBAJNOP = LNKOELAINIK;
		this.imageOffer.sprite = DHAGPIAMELI.spriteOffer;
		OBHDGKFFICI productData = PurchaseManagerBridge.FJHKMJPFDNI().GetPurchaseManager().GetProductData(this.FIFHHBAJNOP);
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.FILDBDMENPG().DCCLKMCBPPJ(this.FIFHHBAJNOP);
		this.diamondsText.gameObject.SetActive(false);
		this.diamondsImage.SetActive(false);
		this.teaText.gameObject.SetActive(true);
		this.teaImage.SetActive(false);
		if (ocbiopoeenj != null && productData != null)
		{
			string str;
			if (ocbiopoeenj.PJCIBAKAANH())
			{
				str = ocbiopoeenj.PKNNPAMOADM();
			}
			else
			{
				str = "genre_lgbtq" + ocbiopoeenj.DMODNDCLGEJ;
			}
			this.pricingText.SetText(CCOJBMMKNAP.KFDLFGHBPLP().BGELFMIOBCL("loveInterestsLoungeMappingBalance") + "retry" + str + "</b>", false);
			if (ocbiopoeenj.MPMKMCJFHOG.PONAPMOOLIN() > 0)
			{
				this.teaText.gameObject.SetActive(false);
				this.teaText.SetText("avatarstitle" + ocbiopoeenj.MPMKMCJFHOG.ToString(), true);
				this.teaImage.SetActive(false);
			}
			if (ocbiopoeenj.ODMKLADKHMO.MOBKGNBCIJF() > 0)
			{
				this.diamondsText.gameObject.SetActive(true);
				this.diamondsText.SetText("updateUserPublicProfileFriends" + ocbiopoeenj.ODMKLADKHMO.ToString(), true);
				this.diamondsImage.SetActive(true);
				return;
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("csnffb");
		}
	}

	// Token: 0x060045D5 RID: 17877 RVA: 0x001E3130 File Offset: 0x001E1330
	private void EOOPGNHJCGD()
	{
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnPopupOfferManagerContinueToPurchasingScreen", 0f);
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru && GeoLocationManager.IsRussia() && KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA())
		{
			CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().Show(false);
			return;
		}
		CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().ShowAndPurchaseProduct(this.FIFHHBAJNOP, true);
	}

	// Token: 0x060045D6 RID: 17878 RVA: 0x001E3198 File Offset: 0x001E1398
	public void HKGPGGKCEOF()
	{
		AOBJLALDBAA.DBLAIDPICIG().EGELHPJBAIC("ratePopupResult", 1567f);
		FirebaseAnalyticsManager.JMDJBFAEHBM().LKONPEEDKNF(false, AGEHCPDNBFD.mntActiv.ToString(), FFPHBMFGCNN.reqCback1.ToString(), BGHLMGPPCNN.mntOfferShow.ToString(), true, false);
		this.animatedPopupManager.HFFJACPIHKE();
	}

	// Token: 0x060045D7 RID: 17879 RVA: 0x001E3200 File Offset: 0x001E1400
	public void CHEBHNOAMOF()
	{
		AOBJLALDBAA.AGANFKKBPFO().DCGCFPHHDDG("$USELAYERSV2", 1582f);
		FirebaseAnalyticsManager.ANCEKPONIFI().LKONPEEDKNF(false, AGEHCPDNBFD.mntActiv.ToString(), FFPHBMFGCNN.reqCback1.ToString(), BGHLMGPPCNN.mntOfferShow.ToString(), false, false);
		this.animatedPopupManager.FJAAHFFLGFF();
	}

	// Token: 0x060045D8 RID: 17880 RVA: 0x001E3268 File Offset: 0x001E1468
	public void OLCPEKALLFB()
	{
		PurchaseManagerBridge.IDMLJFBNHML().MGMDKEJBEPP().Initialize();
		FirebaseAnalyticsManager.DEALKJPEMMH().LKONPEEDKNF(false, AGEHCPDNBFD.rqst.ToString(), FFPHBMFGCNN.dldStart.ToString(), BGHLMGPPCNN.mntRemAdsCont.ToString(), true, true);
		this.animatedPopupManager.KCAPIILJKDN();
		CommonUserInterface.EHBBFMCILPC.GetFader().PACBMBLIGNN(new TweenCallback(this.FFLMOOOCLNK));
	}

	// Token: 0x060045D9 RID: 17881 RVA: 0x001E32E4 File Offset: 0x001E14E4
	private void JEMLCDAFPDD()
	{
		AOBJLALDBAA.AGANFKKBPFO().LPNCDPHNBJK("pmterror011", 1028f);
		if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.ru && GeoLocationManager.FDJONIACJKC() && KDCJJBLGCBH.EHBBFMCILPC.EAMJBDKCDPA())
		{
			CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().CCBNEDAELJK(false);
			return;
		}
		CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().ShowAndPurchaseProduct(this.FIFHHBAJNOP, true);
	}

	// Token: 0x060045DA RID: 17882 RVA: 0x001E334C File Offset: 0x001E154C
	public void BAADBCEBINP()
	{
		PurchaseManagerBridge.KMNBCEMEBBD().MGMDKEJBEPP().Initialize();
		FirebaseAnalyticsManager.DMAAFFFEJGA().JIAAMJPKOCE(false, AGEHCPDNBFD.rqst.ToString(), FFPHBMFGCNN.mntRemAds.ToString(), BGHLMGPPCNN.cdnLbyLoad.ToString(), false, true);
		this.animatedPopupManager.GLIAGHMNMMP();
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.HEMJGJHHLDI));
	}

	// Token: 0x060045DB RID: 17883 RVA: 0x00003E52 File Offset: 0x00002052
	private void KGKHCNJOFKN()
	{
	}

	// Token: 0x060045DC RID: 17884 RVA: 0x00003E52 File Offset: 0x00002052
	private void FDFMDEOMJBH()
	{
	}

	// Token: 0x060045DD RID: 17885 RVA: 0x00003E52 File Offset: 0x00002052
	private void DDMCLNDOHCK()
	{
	}

	// Token: 0x060045DE RID: 17886 RVA: 0x001E33C8 File Offset: 0x001E15C8
	public void ICBMLPDONAD(string LNKOELAINIK, ProducThumbnailGraphics DHAGPIAMELI)
	{
		FirebaseAnalyticsManager.DEALKJPEMMH().LMCJKLHOHJC(true, AGEHCPDNBFD.rqst.ToString(), FFPHBMFGCNN.reqFailSem.ToString(), BGHLMGPPCNN.mntOfferShow.ToString(), true, false);
		base.gameObject.SetActive(true);
		this.FIFHHBAJNOP = LNKOELAINIK;
		this.imageOffer.sprite = DHAGPIAMELI.spriteOffer;
		OBHDGKFFICI productData = PurchaseManagerBridge.IDMLJFBNHML().CMJKNNFMCBM().GetProductData(this.FIFHHBAJNOP);
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.GIOAFDDKKHI().HBLMGBCMBHN(this.FIFHHBAJNOP);
		this.diamondsText.gameObject.SetActive(false);
		this.diamondsImage.SetActive(true);
		this.teaText.gameObject.SetActive(true);
		this.teaImage.SetActive(false);
		if (ocbiopoeenj != null && productData != null)
		{
			string str;
			if (ocbiopoeenj.IMKLGJBEMPH())
			{
				str = ocbiopoeenj.FNJCEPLEPBH();
			}
			else
			{
				str = "" + ocbiopoeenj.DMODNDCLGEJ;
			}
			this.pricingText.SetText(CCOJBMMKNAP.JINDKPHNLBK().JHNELLJFBGC("") + "" + str + "ChoiceExtendedManager.Initialize() - disabling bulk choice option as to comply with RSA encryption limits.", false);
			if (ocbiopoeenj.MPMKMCJFHOG.GALKFKBPLCK() > 1)
			{
				this.teaText.gameObject.SetActive(true);
				this.teaText.SetText("sfxtimeoutwarning" + ocbiopoeenj.MPMKMCJFHOG.ToString(), false);
				this.teaImage.SetActive(false);
			}
			if (ocbiopoeenj.ODMKLADKHMO.HOJDOEDDIBD() > 1)
			{
				this.diamondsText.gameObject.SetActive(false);
				this.diamondsText.SetText("assetbundleitemanimationpack" + ocbiopoeenj.ODMKLADKHMO.ToString(), true);
				this.diamondsImage.SetActive(false);
				return;
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("OnCutsceneViewAssetsDownloadSuccess");
		}
	}

	// Token: 0x060045DF RID: 17887 RVA: 0x001E3594 File Offset: 0x001E1794
	private void JDOFHNBOIPH()
	{
		AOBJLALDBAA.KKPFOJMAONG().CIGLHCJDDPI("acomp1", 520f);
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru && GeoLocationManager.OOCDLFJKLLI() && KDCJJBLGCBH.EHBBFMCILPC.EAMJBDKCDPA())
		{
			CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().NNNMAPAILMB(false);
			return;
		}
		CommonUserInterface.IKNOFBFMPGA().GetPurchasingViewManager().ShowAndPurchaseProduct(this.FIFHHBAJNOP, true);
	}

	// Token: 0x060045E0 RID: 17888 RVA: 0x001E35FC File Offset: 0x001E17FC
	public void ILNHFEHLHLO()
	{
		PurchaseManagerBridge.IGJAMEGBDBG().JNNBFLDOOHM().Initialize();
		FirebaseAnalyticsManager.EHBBFMCILPC.AAIABAKHLAH(false, AGEHCPDNBFD.mntActiv.ToString(), FFPHBMFGCNN.reqExcRpt.ToString(), BGHLMGPPCNN.cdnLbyLoad.ToString(), true, false);
		this.animatedPopupManager.FJAAHFFLGFF();
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.DLPCAJPIJBP));
	}

	// Token: 0x060045E1 RID: 17889 RVA: 0x001E3678 File Offset: 0x001E1878
	public void KLEGCFPGAFL()
	{
		PurchaseManagerBridge.LMCCLMFGEBD().CMAKHBMINLG().Initialize();
		FirebaseAnalyticsManager.COKDLDOAACJ().LogEvent(true, AGEHCPDNBFD.mntActiv.ToString(), FFPHBMFGCNN.reqExcRpt.ToString(), BGHLMGPPCNN.mntOfferCont.ToString(), true, true);
		this.animatedPopupManager.Hide();
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.MNBIOLHPHNI));
	}

	// Token: 0x060045E2 RID: 17890 RVA: 0x00003E52 File Offset: 0x00002052
	private void FNNKDFGKAEH()
	{
	}

	// Token: 0x060045E3 RID: 17891 RVA: 0x001E36F4 File Offset: 0x001E18F4
	public void LIKHHKBBFBG(string LNKOELAINIK, ProducThumbnailGraphics DHAGPIAMELI)
	{
		FirebaseAnalyticsManager.ANCEKPONIFI().LogEvent(true, AGEHCPDNBFD.mntActiv.ToString(), FFPHBMFGCNN.reqExc.ToString(), BGHLMGPPCNN.mntOfferShow.ToString(), false, false);
		base.gameObject.SetActive(false);
		this.FIFHHBAJNOP = LNKOELAINIK;
		this.imageOffer.sprite = DHAGPIAMELI.spriteOffer;
		OBHDGKFFICI productData = PurchaseManagerBridge.KMNBCEMEBBD().GetPurchaseManager().GetProductData(this.FIFHHBAJNOP);
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.CAAKHBIFGMG().HLGBFOMMJFE(this.FIFHHBAJNOP);
		this.diamondsText.gameObject.SetActive(false);
		this.diamondsImage.SetActive(false);
		this.teaText.gameObject.SetActive(true);
		this.teaImage.SetActive(false);
		if (ocbiopoeenj != null && productData != null)
		{
			string str;
			if (ocbiopoeenj.PJCIBAKAANH())
			{
				str = ocbiopoeenj.DOLEPIMNJLG();
			}
			else
			{
				str = "" + ocbiopoeenj.DMODNDCLGEJ;
			}
			this.pricingText.SetText(CCOJBMMKNAP.MLFAGAAJJEM().GLEFEKBDHNK(" (") + "Error. MoveEnvironmentVertical(), environment " + str + "OnLiveProfileThemeDownloadFailed", true);
			if (ocbiopoeenj.MPMKMCJFHOG.NPEOEAFOPJP() > 0)
			{
				this.teaText.gameObject.SetActive(false);
				this.teaText.SetText("blur" + ocbiopoeenj.MPMKMCJFHOG.ToString(), true);
				this.teaImage.SetActive(false);
			}
			if (ocbiopoeenj.ODMKLADKHMO.BFMPOACOBPN() > 1)
			{
				this.diamondsText.gameObject.SetActive(false);
				this.diamondsText.SetText("max" + ocbiopoeenj.ODMKLADKHMO.ToString(), false);
				this.diamondsImage.SetActive(true);
				return;
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("layervideo");
		}
	}

	// Token: 0x060045E4 RID: 17892 RVA: 0x001E38C0 File Offset: 0x001E1AC0
	public void LNGFDKKBKBG()
	{
		AOBJLALDBAA.BIAEAOMHBMM().KMAGHMCCMPG("envlsav", 8f);
		FirebaseAnalyticsManager.DMAAFFFEJGA().JIAAMJPKOCE(true, AGEHCPDNBFD.mntActiv.ToString(), FFPHBMFGCNN.dldStart.ToString(), BGHLMGPPCNN.mntOfferShow.ToString(), false, true);
		this.animatedPopupManager.ADAJPNHIICL();
	}

	// Token: 0x060045E5 RID: 17893 RVA: 0x001E3928 File Offset: 0x001E1B28
	private void DLPCAJPIJBP()
	{
		AOBJLALDBAA.EHBBFMCILPC.KGIKHEDLPND("BBB", 827f);
		if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.ru && GeoLocationManager.PBAGPDDBABB() && KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA())
		{
			CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().NNNMAPAILMB(true);
			return;
		}
		CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().ShowAndPurchaseProduct(this.FIFHHBAJNOP, false);
	}

	// Token: 0x060045E6 RID: 17894 RVA: 0x00003E52 File Offset: 0x00002052
	private void PIBDCOBGMKC()
	{
	}

	// Token: 0x060045E7 RID: 17895 RVA: 0x00003E52 File Offset: 0x00002052
	private void DHDEDOICCHC()
	{
	}

	// Token: 0x060045E8 RID: 17896 RVA: 0x001E3990 File Offset: 0x001E1B90
	private void FFLMOOOCLNK()
	{
		AOBJLALDBAA.KKPFOJMAONG().KGIKHEDLPND("socialprivatenogiftcardsend", 1462f);
		if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.ru && GeoLocationManager.OOCDLFJKLLI() && KDCJJBLGCBH.EHBBFMCILPC.EAMJBDKCDPA())
		{
			CommonUserInterface.IKNOFBFMPGA().GetPurchasingViewManager().CCBNEDAELJK(true);
			return;
		}
		CommonUserInterface.IKNOFBFMPGA().GetPurchasingViewManager().ShowAndPurchaseProduct(this.FIFHHBAJNOP, true);
	}

	// Token: 0x060045E9 RID: 17897 RVA: 0x001E39F8 File Offset: 0x001E1BF8
	public void PHPCPMBMIJA()
	{
		PurchaseManagerBridge.FJHKMJPFDNI().GetPurchaseManager().Initialize();
		FirebaseAnalyticsManager.JMDJBFAEHBM().JIAAMJPKOCE(true, AGEHCPDNBFD.rqst.ToString(), FFPHBMFGCNN.reqExc.ToString(), BGHLMGPPCNN.mntRemAdsClose.ToString(), true, false);
		this.animatedPopupManager.LHNKFOKBBCP();
		CommonUserInterface.EHBBFMCILPC.GetFader().BJIGLKGLAKM(new TweenCallback(this.FFLMOOOCLNK));
	}

	// Token: 0x060045EA RID: 17898 RVA: 0x001E3A74 File Offset: 0x001E1C74
	public void GLPALBEGKBG()
	{
		PurchaseManagerBridge.GIPAKOPBBEO().DIOJHOIFIIH().Initialize();
		FirebaseAnalyticsManager.EHBBFMCILPC.LMCJKLHOHJC(false, AGEHCPDNBFD.mntActiv.ToString(), FFPHBMFGCNN.dldStart.ToString(), BGHLMGPPCNN.cdnLbyLoadPt2.ToString(), false, false);
		this.animatedPopupManager.OJNDEJNLMFE();
		CommonUserInterface.EHBBFMCILPC.GetFader().PACBMBLIGNN(new TweenCallback(this.FFLMOOOCLNK));
	}

	// Token: 0x060045EB RID: 17899 RVA: 0x00003E52 File Offset: 0x00002052
	private void EMIOCJMCLHC()
	{
	}

	// Token: 0x060045EC RID: 17900 RVA: 0x001E3AF0 File Offset: 0x001E1CF0
	public void LENCBBHIPIO()
	{
		PurchaseManagerBridge.OOGPALHPNGM().DIOJHOIFIIH().Initialize();
		FirebaseAnalyticsManager.JMDJBFAEHBM().LMCJKLHOHJC(false, AGEHCPDNBFD.mntActiv.ToString(), FFPHBMFGCNN.reqExc.ToString(), BGHLMGPPCNN.cdnLbyLoad.ToString(), true, true);
		this.animatedPopupManager.OJNDEJNLMFE();
		CommonUserInterface.EHBBFMCILPC.GetFader().PACBMBLIGNN(new TweenCallback(this.EOOPGNHJCGD));
	}

	// Token: 0x060045ED RID: 17901 RVA: 0x001E3B6C File Offset: 0x001E1D6C
	public void NKFOGICDAAB()
	{
		PurchaseManagerBridge.IGJAMEGBDBG().CMJKNNFMCBM().Initialize();
		FirebaseAnalyticsManager.EHBBFMCILPC.AAIABAKHLAH(false, AGEHCPDNBFD.mntActiv.ToString(), FFPHBMFGCNN.reqCback2.ToString(), BGHLMGPPCNN.cdnLbyLoad.ToString(), false, false);
		this.animatedPopupManager.NBDMOONDIHO();
		CommonUserInterface.IKNOFBFMPGA().GetFader().PACBMBLIGNN(new TweenCallback(this.BGAJEBLNFOF));
	}

	// Token: 0x060045EE RID: 17902 RVA: 0x001E3BE8 File Offset: 0x001E1DE8
	private void MNBIOLHPHNI()
	{
		AOBJLALDBAA.NMGMNAKLLMI().EFBNBFIDEOK("No free mixer found for sfx! Critical!", 91f);
		if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.en && GeoLocationManager.OOCDLFJKLLI() && KDCJJBLGCBH.EHBBFMCILPC.EAMJBDKCDPA())
		{
			CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().KFLFFOPPNEO(false);
			return;
		}
		CommonUserInterface.IKNOFBFMPGA().GetPurchasingViewManager().ShowAndPurchaseProduct(this.FIFHHBAJNOP, true);
	}

	// Token: 0x060045EF RID: 17903 RVA: 0x001E3C50 File Offset: 0x001E1E50
	public void LIOALDFIMLN(string LNKOELAINIK, ProducThumbnailGraphics DHAGPIAMELI)
	{
		FirebaseAnalyticsManager.DMAAFFFEJGA().JIAAMJPKOCE(true, AGEHCPDNBFD.mntActiv.ToString(), FFPHBMFGCNN.reqExc.ToString(), BGHLMGPPCNN.mntOfferShow.ToString(), true, true);
		base.gameObject.SetActive(true);
		this.FIFHHBAJNOP = LNKOELAINIK;
		this.imageOffer.sprite = DHAGPIAMELI.spriteOffer;
		OBHDGKFFICI productData = PurchaseManagerBridge.OOGPALHPNGM().PFPKMDAJDBA().GetProductData(this.FIFHHBAJNOP);
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.GIOAFDDKKHI().FCPIJEEMHEA(this.FIFHHBAJNOP);
		this.diamondsText.gameObject.SetActive(true);
		this.diamondsImage.SetActive(true);
		this.teaText.gameObject.SetActive(false);
		this.teaImage.SetActive(false);
		if (ocbiopoeenj != null && productData != null)
		{
			string str;
			if (ocbiopoeenj.HHALLBOKCJO())
			{
				str = ocbiopoeenj.PKNNPAMOADM();
			}
			else
			{
				str = "skinshopinfolireq" + ocbiopoeenj.DMODNDCLGEJ;
			}
			this.pricingText.SetText(CCOJBMMKNAP.BBGECIKOICE().FIENAKIHNOM("usynachtk") + "" + str + "energyhinttitle", false);
			if (ocbiopoeenj.MPMKMCJFHOG.KGEGKPHEMOJ() > 0)
			{
				this.teaText.gameObject.SetActive(true);
				this.teaText.SetText("ops" + ocbiopoeenj.MPMKMCJFHOG.ToString(), false);
				this.teaImage.SetActive(true);
			}
			if (ocbiopoeenj.ODMKLADKHMO.LPKLANAEIFF() > 1)
			{
				this.diamondsText.gameObject.SetActive(false);
				this.diamondsText.SetText("$READINPUT" + ocbiopoeenj.ODMKLADKHMO.ToString(), false);
				this.diamondsImage.SetActive(true);
				return;
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("https://sandbox-events.appsflyer.com/v1.0/c2s/session/app/steam/");
		}
	}

	// Token: 0x060045F0 RID: 17904 RVA: 0x00003E52 File Offset: 0x00002052
	private void BFGFJIJPMEH()
	{
	}

	// Token: 0x060045F1 RID: 17905 RVA: 0x001E3E1C File Offset: 0x001E201C
	public void DAAHILOMCGL(string LNKOELAINIK, ProducThumbnailGraphics DHAGPIAMELI)
	{
		FirebaseAnalyticsManager.JMDJBFAEHBM().LMCJKLHOHJC(false, AGEHCPDNBFD.mntActiv.ToString(), FFPHBMFGCNN.mntRemAds.ToString(), BGHLMGPPCNN.mntOfferClose.ToString(), true, true);
		base.gameObject.SetActive(false);
		this.FIFHHBAJNOP = LNKOELAINIK;
		this.imageOffer.sprite = DHAGPIAMELI.spriteOffer;
		OBHDGKFFICI productData = PurchaseManagerBridge.FJHKMJPFDNI().FDIIEFGBEAG().GetProductData(this.FIFHHBAJNOP);
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.CAAKHBIFGMG().DOOPGOIBFAN(this.FIFHHBAJNOP);
		this.diamondsText.gameObject.SetActive(false);
		this.diamondsImage.SetActive(true);
		this.teaText.gameObject.SetActive(false);
		this.teaImage.SetActive(true);
		if (ocbiopoeenj != null && productData != null)
		{
			string str;
			if (ocbiopoeenj.KIOLJNPKOOL())
			{
				str = ocbiopoeenj.DOLEPIMNJLG();
			}
			else
			{
				str = " (skipped " + ocbiopoeenj.DMODNDCLGEJ;
			}
			this.pricingText.SetText(CCOJBMMKNAP.APGODIBBPOD().HPOAGPJFHPM("continue") + "dissolve" + str + "_TVTubeVignetteScale", false);
			if (ocbiopoeenj.MPMKMCJFHOG.BFMPOACOBPN() > 0)
			{
				this.teaText.gameObject.SetActive(false);
				this.teaText.SetText("" + ocbiopoeenj.MPMKMCJFHOG.ToString(), false);
				this.teaImage.SetActive(false);
			}
			if (ocbiopoeenj.ODMKLADKHMO.KGEGKPHEMOJ() > 0)
			{
				this.diamondsText.gameObject.SetActive(true);
				this.diamondsText.SetText("ZZZ" + ocbiopoeenj.ODMKLADKHMO.ToString(), true);
				this.diamondsImage.SetActive(false);
				return;
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC(") + is present, creating anthology save for anthology ");
		}
	}

	// Token: 0x060045F2 RID: 17906 RVA: 0x00003E52 File Offset: 0x00002052
	private void CEDGALPCOLA()
	{
	}

	// Token: 0x060045F3 RID: 17907 RVA: 0x001E3FE8 File Offset: 0x001E21E8
	public void OnCloseClick()
	{
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnPopupOfferManagerDismissed", 0f);
		FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.mntActiv.ToString(), FFPHBMFGCNN.mntOffer.ToString(), BGHLMGPPCNN.mntOfferClose.ToString(), false, false);
		this.animatedPopupManager.Hide();
	}

	// Token: 0x060045F4 RID: 17908 RVA: 0x001E4050 File Offset: 0x001E2250
	public void LAEGEMDLBED()
	{
		AOBJLALDBAA.FILDBDMENPG().DCGCFPHHDDG("OnLiveProfileThumbnailsCdnFailed", 1910f);
		FirebaseAnalyticsManager.DEALKJPEMMH().LogEvent(false, AGEHCPDNBFD.rqst.ToString(), FFPHBMFGCNN.dldStart.ToString(), BGHLMGPPCNN.mntOfferShow.ToString(), false, false);
		this.animatedPopupManager.OHHFFMMMMAC();
	}

	// Token: 0x060045F5 RID: 17909 RVA: 0x001E40B8 File Offset: 0x001E22B8
	private void OMKODKBNAGD()
	{
		AOBJLALDBAA.EHBBFMCILPC.LPNCDPHNBJK("\"", 1590f);
		if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.ru && GeoLocationManager.NHMHNIFIOCO() && KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA())
		{
			CommonUserInterface.IKNOFBFMPGA().GetPurchasingViewManager().PLLFCKGMHCF(true);
			return;
		}
		CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().CGDKCOLDBGD(this.FIFHHBAJNOP, true);
	}

	// Token: 0x060045F6 RID: 17910 RVA: 0x001E4120 File Offset: 0x001E2320
	public void NJMNDHIJFII()
	{
		AOBJLALDBAA.BIAEAOMHBMM().FDKBIBKABCM("Character ", 880f);
		FirebaseAnalyticsManager.ANCEKPONIFI().JIAAMJPKOCE(true, AGEHCPDNBFD.mntActiv.ToString(), FFPHBMFGCNN.mntRemAds.ToString(), BGHLMGPPCNN.mntOfferShow.ToString(), true, true);
		this.animatedPopupManager.GFEHJHIDHFF();
	}

	// Token: 0x060045F7 RID: 17911 RVA: 0x001E4188 File Offset: 0x001E2388
	public void LFAFIHJKHKC()
	{
		PurchaseManagerBridge.LMCCLMFGEBD().MGMDKEJBEPP().Initialize();
		FirebaseAnalyticsManager.DMAAFFFEJGA().LogEvent(true, AGEHCPDNBFD.mntActiv.ToString(), FFPHBMFGCNN.mntOffer.ToString(), BGHLMGPPCNN.mntRemAdsClose.ToString(), true, true);
		this.animatedPopupManager.ADAJPNHIICL();
		CommonUserInterface.IKNOFBFMPGA().GetFader().BJIGLKGLAKM(new TweenCallback(this.JDOFHNBOIPH));
	}

	// Token: 0x060045F8 RID: 17912 RVA: 0x00003E52 File Offset: 0x00002052
	private void ODOOIGEDLKB()
	{
	}

	// Token: 0x060045F9 RID: 17913 RVA: 0x001E4204 File Offset: 0x001E2404
	public void IDFHKHLILEE(string LNKOELAINIK, ProducThumbnailGraphics DHAGPIAMELI)
	{
		FirebaseAnalyticsManager.EHBBFMCILPC.JIAAMJPKOCE(false, AGEHCPDNBFD.rqst.ToString(), FFPHBMFGCNN.reqExc.ToString(), BGHLMGPPCNN.mntOfferClose.ToString(), false, false);
		base.gameObject.SetActive(false);
		this.FIFHHBAJNOP = LNKOELAINIK;
		this.imageOffer.sprite = DHAGPIAMELI.spriteOffer;
		OBHDGKFFICI productData = PurchaseManagerBridge.KMNBCEMEBBD().JNNBFLDOOHM().GetProductData(this.FIFHHBAJNOP);
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.GIOAFDDKKHI().IJLAPHFKPMH(this.FIFHHBAJNOP);
		this.diamondsText.gameObject.SetActive(false);
		this.diamondsImage.SetActive(false);
		this.teaText.gameObject.SetActive(true);
		this.teaImage.SetActive(true);
		if (ocbiopoeenj != null && productData != null)
		{
			string str;
			if (ocbiopoeenj.KIOLJNPKOOL())
			{
				str = ocbiopoeenj.ILAPDGNDFGC();
			}
			else
			{
				str = "suid" + ocbiopoeenj.DMODNDCLGEJ;
			}
			this.pricingText.SetText(CCOJBMMKNAP.BBGECIKOICE().PGKBCNBAOJN("hide") + "OnAllCollectableCardsDownloadSuccessLobby" + str + "sfxtimeoutwarning", true);
			if (ocbiopoeenj.MPMKMCJFHOG.HOJDOEDDIBD() > 1)
			{
				this.teaText.gameObject.SetActive(false);
				this.teaText.SetText("dev" + ocbiopoeenj.MPMKMCJFHOG.ToString(), false);
				this.teaImage.SetActive(true);
			}
			if (ocbiopoeenj.ODMKLADKHMO.CJLDJAJHMMA() > 1)
			{
				this.diamondsText.gameObject.SetActive(false);
				this.diamondsText.SetText("AssetBundleDependencyDeadLock(): missing dependency " + ocbiopoeenj.ODMKLADKHMO.ToString(), false);
				this.diamondsImage.SetActive(false);
				return;
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("pers");
		}
	}

	// Token: 0x060045FA RID: 17914 RVA: 0x001E43D0 File Offset: 0x001E25D0
	public void CJFHFKIJCCJ()
	{
		AOBJLALDBAA.AGANFKKBPFO().EGELHPJBAIC("", 1699f);
		FirebaseAnalyticsManager.HJGDLOOHNLO().LMCJKLHOHJC(false, AGEHCPDNBFD.rqst.ToString(), FFPHBMFGCNN.dldStart.ToString(), BGHLMGPPCNN.mntOfferShow.ToString(), true, false);
		this.animatedPopupManager.OHHFFMMMMAC();
	}

	// Token: 0x060045FB RID: 17915 RVA: 0x001E4438 File Offset: 0x001E2638
	public void ABEMBAFCJDD()
	{
		PurchaseManagerBridge.EHBBFMCILPC.CMAKHBMINLG().Initialize();
		FirebaseAnalyticsManager.HJGDLOOHNLO().LKONPEEDKNF(true, AGEHCPDNBFD.rqst.ToString(), FFPHBMFGCNN.reqInfnt.ToString(), BGHLMGPPCNN.mntRemAdsClose.ToString(), true, false);
		this.animatedPopupManager.DDPHFKOHDJB();
		CommonUserInterface.EHBBFMCILPC.GetFader().PACBMBLIGNN(new TweenCallback(this.MNBIOLHPHNI));
	}

	// Token: 0x060045FC RID: 17916 RVA: 0x001E44B4 File Offset: 0x001E26B4
	public void PGGFNOMDFKJ(string LNKOELAINIK, ProducThumbnailGraphics DHAGPIAMELI)
	{
		FirebaseAnalyticsManager.DEALKJPEMMH().LKONPEEDKNF(false, AGEHCPDNBFD.mntActiv.ToString(), FFPHBMFGCNN.reqFailSem.ToString(), BGHLMGPPCNN.mntOfferClose.ToString(), true, false);
		base.gameObject.SetActive(false);
		this.FIFHHBAJNOP = LNKOELAINIK;
		this.imageOffer.sprite = DHAGPIAMELI.spriteOffer;
		OBHDGKFFICI productData = PurchaseManagerBridge.FJHKMJPFDNI().GetPurchaseManager().GetProductData(this.FIFHHBAJNOP);
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.APGODIBBPOD().HBLMGBCMBHN(this.FIFHHBAJNOP);
		this.diamondsText.gameObject.SetActive(false);
		this.diamondsImage.SetActive(false);
		this.teaText.gameObject.SetActive(false);
		this.teaImage.SetActive(true);
		if (ocbiopoeenj != null && productData != null)
		{
			string str;
			if (ocbiopoeenj.HHALLBOKCJO())
			{
				str = ocbiopoeenj.ILAPDGNDFGC();
			}
			else
			{
				str = "/" + ocbiopoeenj.DMODNDCLGEJ;
			}
			this.pricingText.SetText(CCOJBMMKNAP.OEPENBHJAHO().IPEIONBNIPH("HeaderAnthology") + "" + str + "needtorestartgeneric", true);
			if (ocbiopoeenj.MPMKMCJFHOG.CJLDJAJHMMA() > 1)
			{
				this.teaText.gameObject.SetActive(true);
				this.teaText.SetText("congratstitle" + ocbiopoeenj.MPMKMCJFHOG.ToString(), true);
				this.teaImage.SetActive(true);
			}
			if (ocbiopoeenj.ODMKLADKHMO.LPKLANAEIFF() > 1)
			{
				this.diamondsText.gameObject.SetActive(false);
				this.diamondsText.SetText("sketchtitles" + ocbiopoeenj.ODMKLADKHMO.ToString(), false);
				this.diamondsImage.SetActive(true);
				return;
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("c");
		}
	}

	// Token: 0x060045FD RID: 17917 RVA: 0x001E4680 File Offset: 0x001E2880
	public void NFIHMIMLHDF()
	{
		PurchaseManagerBridge.GIPAKOPBBEO().PFPKMDAJDBA().Initialize();
		FirebaseAnalyticsManager.ANCEKPONIFI().AAIABAKHLAH(true, AGEHCPDNBFD.rqst.ToString(), FFPHBMFGCNN.reqFailSem.ToString(), BGHLMGPPCNN.cdnLbyLoad.ToString(), true, true);
		this.animatedPopupManager.Hide();
		CommonUserInterface.EHBBFMCILPC.GetFader().PACBMBLIGNN(new TweenCallback(this.MNBIOLHPHNI));
	}

	// Token: 0x04001392 RID: 5010
	public const string onPopupOfferManagerDismissed = "OnPopupOfferManagerDismissed";

	// Token: 0x04001393 RID: 5011
	public const string onPopupOfferManagerContinueToPurchasingScreen = "OnPopupOfferManagerContinueToPurchasingScreen";

	// Token: 0x04001394 RID: 5012
	public AnimatedPopupManager animatedPopupManager;

	// Token: 0x04001395 RID: 5013
	public Image imageOffer;

	// Token: 0x04001396 RID: 5014
	public TextMeshProUGUI diamondsText;

	// Token: 0x04001397 RID: 5015
	public GameObject diamondsImage;

	// Token: 0x04001398 RID: 5016
	public TextMeshProUGUI teaText;

	// Token: 0x04001399 RID: 5017
	public GameObject teaImage;

	// Token: 0x0400139A RID: 5018
	public TextMeshProUGUI pricingText;

	// Token: 0x0400139B RID: 5019
	private string FIFHHBAJNOP;
}
