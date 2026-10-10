using System;
using DG.Tweening;
using TMPro;
using UnityEngine;

// Token: 0x020001B7 RID: 439
public class PopupRemoveAdsManager : MonoBehaviour
{
	// Token: 0x060035FC RID: 13820 RVA: 0x0016A278 File Offset: 0x00168478
	public void GKJHLGICBKI()
	{
		FirebaseAnalyticsManager.ANCEKPONIFI().LKONPEEDKNF(false, AGEHCPDNBFD.rqst.ToString(), FFPHBMFGCNN.reqCback2.ToString(), BGHLMGPPCNN.cdnLbyLoadPt2.ToString(), true, true);
		AOBJLALDBAA.BIAEAOMHBMM().CIGLHCJDDPI("OnAllCollectableCardsDownloadSuccess", 1458f);
		this.animatedPopupManager.HFFJACPIHKE();
	}

	// Token: 0x060035FD RID: 13821 RVA: 0x0016A2DE File Offset: 0x001684DE
	private void MLPAJKEBDCC()
	{
		AOBJLALDBAA.FILDBDMENPG().CIGLHCJDDPI("UpdateComponentTitleDesc() failed - AssetAvatarComponentType.body is null.", 1864f);
		CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().ShowAndPurchaseProduct(PopupRemoveAdsManager.removeAdsProductId, false);
	}

	// Token: 0x060035FE RID: 13822 RVA: 0x00003E52 File Offset: 0x00002052
	private void HKJPPMMKGLP()
	{
	}

	// Token: 0x060035FF RID: 13823 RVA: 0x0016A30C File Offset: 0x0016850C
	public void IBFILMHHHEN()
	{
		PurchaseManagerBridge.IDMLJFBNHML().CMAKHBMINLG().Initialize();
		FirebaseAnalyticsManager.HJGDLOOHNLO().LMCJKLHOHJC(false, AGEHCPDNBFD.rqst.ToString(), FFPHBMFGCNN.reqFailSem.ToString(), BGHLMGPPCNN.mntOfferShow.ToString(), true, false);
		this.animatedPopupManager.ADAJPNHIICL();
		CommonUserInterface.IKNOFBFMPGA().GetFader().BJIGLKGLAKM(new TweenCallback(this.MOFIFHCEFAE));
	}

	// Token: 0x06003601 RID: 13825 RVA: 0x00003E52 File Offset: 0x00002052
	private void ODOOIGEDLKB()
	{
	}

	// Token: 0x06003602 RID: 13826 RVA: 0x00003E52 File Offset: 0x00002052
	private void OHPNGFAIGEM()
	{
	}

	// Token: 0x06003603 RID: 13827 RVA: 0x0016A394 File Offset: 0x00168594
	public void LIKHHKBBFBG()
	{
		FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.rqst.ToString(), FFPHBMFGCNN.reqCback2.ToString(), BGHLMGPPCNN.cdnLbyLoadPt1.ToString(), true, false);
		OBHDGKFFICI productData = PurchaseManagerBridge.IDMLJFBNHML().CMJKNNFMCBM().GetProductData(PopupRemoveAdsManager.removeAdsProductId);
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.CAAKHBIFGMG().PDJKPFLHFLO(PopupRemoveAdsManager.removeAdsProductId);
		if (productData != null && ocbiopoeenj != null)
		{
			this.titleText.SetText(CCOJBMMKNAP.MLFAGAAJJEM().DNILNCLIHAP(")") + "_SwitchingNoise" + ocbiopoeenj.DMODNDCLGEJ, false);
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("apks2");
		}
		base.gameObject.SetActive(true);
	}

	// Token: 0x06003604 RID: 13828 RVA: 0x0016A44C File Offset: 0x0016864C
	public void IKNFIKJFANA()
	{
		FirebaseAnalyticsManager.HJGDLOOHNLO().LMCJKLHOHJC(false, AGEHCPDNBFD.mntActiv.ToString(), FFPHBMFGCNN.reqCback2.ToString(), BGHLMGPPCNN.cdnLbyLoadPt1.ToString(), false, true);
		AOBJLALDBAA.BIAEAOMHBMM().FDKBIBKABCM("ok", 1164f);
		this.animatedPopupManager.Hide();
	}

	// Token: 0x06003605 RID: 13829 RVA: 0x0016A4B4 File Offset: 0x001686B4
	public void BDCLHHDKBCP()
	{
		FirebaseAnalyticsManager.HJGDLOOHNLO().LogEvent(true, AGEHCPDNBFD.rqst.ToString(), FFPHBMFGCNN.reqFailSem.ToString(), BGHLMGPPCNN.mntOfferCont.ToString(), true, false);
		OBHDGKFFICI productData = PurchaseManagerBridge.FJHKMJPFDNI().GetPurchaseManager().GetProductData(PopupRemoveAdsManager.removeAdsProductId);
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.AGANFKKBPFO().IJLAPHFKPMH(PopupRemoveAdsManager.removeAdsProductId);
		if (productData != null && ocbiopoeenj != null)
		{
			this.titleText.SetText(CCOJBMMKNAP.CEGAOMEEFBE().JHNELLJFBGC("YYY") + "Npc animation asset index mismatch, correcting " + ocbiopoeenj.DMODNDCLGEJ, false);
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("OnAvatarScreenAssetsDownloadFailed");
		}
		base.gameObject.SetActive(false);
	}

	// Token: 0x06003606 RID: 13830 RVA: 0x0016A56A File Offset: 0x0016876A
	private void MOFIFHCEFAE()
	{
		AOBJLALDBAA.BIAEAOMHBMM().LPNCDPHNBJK("wind", 370f);
		CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().ShowAndPurchaseProduct(PopupRemoveAdsManager.removeAdsProductId, false);
	}

	// Token: 0x06003607 RID: 13831 RVA: 0x0016A598 File Offset: 0x00168798
	public void MBKCINPJKML()
	{
		FirebaseAnalyticsManager.JMDJBFAEHBM().LKONPEEDKNF(true, AGEHCPDNBFD.mntActiv.ToString(), FFPHBMFGCNN.reqInfnt.ToString(), BGHLMGPPCNN.cdnLbyLoadPt1.ToString(), false, true);
		OBHDGKFFICI productData = PurchaseManagerBridge.GIPAKOPBBEO().DIOJHOIFIIH().GetProductData(PopupRemoveAdsManager.removeAdsProductId);
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.NACPAKLINNH().ICBJCNKKGPJ(PopupRemoveAdsManager.removeAdsProductId);
		if (productData != null && ocbiopoeenj != null)
		{
			this.titleText.SetText(CCOJBMMKNAP.OBOOKJPGBJN().HHLECNIFHCO("<alpha=#C0>") + "areyousure" + ocbiopoeenj.DMODNDCLGEJ, true);
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC(" ");
		}
		base.gameObject.SetActive(false);
	}

	// Token: 0x06003608 RID: 13832 RVA: 0x00003E52 File Offset: 0x00002052
	private void MIMOJFLJLFO()
	{
	}

	// Token: 0x06003609 RID: 13833 RVA: 0x0016A650 File Offset: 0x00168850
	public void GEEGLNIKKME()
	{
		FirebaseAnalyticsManager.DMAAFFFEJGA().LMCJKLHOHJC(true, AGEHCPDNBFD.mntActiv.ToString(), FFPHBMFGCNN.dldStart.ToString(), BGHLMGPPCNN.mntOfferClose.ToString(), true, true);
		OBHDGKFFICI productData = PurchaseManagerBridge.IGJAMEGBDBG().CMJKNNFMCBM().GetProductData(PopupRemoveAdsManager.removeAdsProductId);
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.KBNLANLMNCN().HLGBFOMMJFE(PopupRemoveAdsManager.removeAdsProductId);
		if (productData != null && ocbiopoeenj != null)
		{
			this.titleText.SetText(CCOJBMMKNAP.KFDLFGHBPLP().HIPJILDCHJC(" : ") + "energyhinttitle" + ocbiopoeenj.DMODNDCLGEJ, false);
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("Optional frame container bundle failed to load, continuing without it:");
		}
		base.gameObject.SetActive(true);
	}

	// Token: 0x0600360A RID: 13834 RVA: 0x0016A708 File Offset: 0x00168908
	public void KOOKJAHBICJ()
	{
		FirebaseAnalyticsManager.EHBBFMCILPC.JIAAMJPKOCE(true, AGEHCPDNBFD.mntActiv.ToString(), FFPHBMFGCNN.mntRemAds.ToString(), BGHLMGPPCNN.mntRemAdsShow.ToString(), false, false);
		OBHDGKFFICI productData = PurchaseManagerBridge.GIPAKOPBBEO().DINNJAONAIF().GetProductData(PopupRemoveAdsManager.removeAdsProductId);
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.GIOAFDDKKHI().DCCLKMCBPPJ(PopupRemoveAdsManager.removeAdsProductId);
		if (productData != null && ocbiopoeenj != null)
		{
			this.titleText.SetText(CCOJBMMKNAP.KLAKLFCOMJC().GLEFEKBDHNK("OnPostEffectSettingsChanged") + "' for " + ocbiopoeenj.DMODNDCLGEJ, true);
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC(" ");
		}
		base.gameObject.SetActive(false);
	}

	// Token: 0x0600360B RID: 13835 RVA: 0x0016A7BE File Offset: 0x001689BE
	private void HNPKIODHFDH()
	{
		AOBJLALDBAA.AGANFKKBPFO().KMAGHMCCMPG("apb", 1226f);
		CommonUserInterface.IKNOFBFMPGA().GetPurchasingViewManager().CGDKCOLDBGD(PopupRemoveAdsManager.removeAdsProductId, false);
	}

	// Token: 0x0600360C RID: 13836 RVA: 0x0016A7EC File Offset: 0x001689EC
	public void GBMBIFHCPDC()
	{
		FirebaseAnalyticsManager.JMDJBFAEHBM().JIAAMJPKOCE(true, AGEHCPDNBFD.mntActiv.ToString(), FFPHBMFGCNN.reqInfnt.ToString(), BGHLMGPPCNN.cdnLbyLoadPt1.ToString(), false, true);
		AOBJLALDBAA.CEGAOMEEFBE().FDKBIBKABCM("sfxchatnotification", 1565f);
		this.animatedPopupManager.DDPHFKOHDJB();
	}

	// Token: 0x0600360D RID: 13837 RVA: 0x0016A854 File Offset: 0x00168A54
	public void OnCloseClick()
	{
		FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.mntActiv.ToString(), FFPHBMFGCNN.mntRemAds.ToString(), BGHLMGPPCNN.mntRemAdsClose.ToString(), false, false);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnPopupRemoveAdsManagerDismissed", 0f);
		this.animatedPopupManager.Hide();
	}

	// Token: 0x0600360E RID: 13838 RVA: 0x00003E52 File Offset: 0x00002052
	private void EAKEDEEHEDD()
	{
	}

	// Token: 0x0600360F RID: 13839 RVA: 0x0016A8BC File Offset: 0x00168ABC
	public void CAEBMIAJCIB()
	{
		PurchaseManagerBridge.LMCCLMFGEBD().DIOJHOIFIIH().Initialize();
		FirebaseAnalyticsManager.JMDJBFAEHBM().LKONPEEDKNF(false, AGEHCPDNBFD.rqst.ToString(), FFPHBMFGCNN.reqInfnt.ToString(), BGHLMGPPCNN.mntRemAdsCont.ToString(), true, true);
		this.animatedPopupManager.Hide();
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.HNPKIODHFDH));
	}

	// Token: 0x06003610 RID: 13840 RVA: 0x0016A938 File Offset: 0x00168B38
	public void MBBFEMDPNPB()
	{
		FirebaseAnalyticsManager.HJGDLOOHNLO().LMCJKLHOHJC(true, AGEHCPDNBFD.mntActiv.ToString(), FFPHBMFGCNN.mntOffer.ToString(), BGHLMGPPCNN.cdnLbyLoadPt1.ToString(), true, true);
		AOBJLALDBAA.KKPFOJMAONG().KMAGHMCCMPG("OnFriendsPopupManagerAcceptClick", 1547f);
		this.animatedPopupManager.LHNKFOKBBCP();
	}

	// Token: 0x06003611 RID: 13841 RVA: 0x0016A9A0 File Offset: 0x00168BA0
	public void FGHKCMKDGJK()
	{
		FirebaseAnalyticsManager.COKDLDOAACJ().LogEvent(false, AGEHCPDNBFD.mntActiv.ToString(), FFPHBMFGCNN.mntOffer.ToString(), BGHLMGPPCNN.mntRemAdsShow.ToString(), false, false);
		AOBJLALDBAA.BIAEAOMHBMM().FDKBIBKABCM("OnPurchaseSuccess - invalid state.", 1772f);
		this.animatedPopupManager.HFFJACPIHKE();
	}

	// Token: 0x06003612 RID: 13842 RVA: 0x0016AA08 File Offset: 0x00168C08
	public void OnRemoveAdsClick()
	{
		PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager().Initialize();
		FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.mntActiv.ToString(), FFPHBMFGCNN.mntRemAds.ToString(), BGHLMGPPCNN.mntRemAdsCont.ToString(), false, false);
		this.animatedPopupManager.Hide();
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.KGCIJEMABKP));
	}

	// Token: 0x06003613 RID: 13843 RVA: 0x0016AA84 File Offset: 0x00168C84
	private void PNLFCNEOFMO()
	{
		AOBJLALDBAA.CEGAOMEEFBE().DCGCFPHHDDG("apks2", 1607f);
		CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().ShowAndPurchaseProduct(PopupRemoveAdsManager.removeAdsProductId, true);
	}

	// Token: 0x06003614 RID: 13844 RVA: 0x00003E52 File Offset: 0x00002052
	private void LMPBLJPPCKO()
	{
	}

	// Token: 0x06003615 RID: 13845 RVA: 0x0016AAB0 File Offset: 0x00168CB0
	public void KOHIJKHJABJ()
	{
		PurchaseManagerBridge.FJHKMJPFDNI().MGMDKEJBEPP().Initialize();
		FirebaseAnalyticsManager.HJGDLOOHNLO().LogEvent(true, AGEHCPDNBFD.rqst.ToString(), FFPHBMFGCNN.mntOffer.ToString(), BGHLMGPPCNN.mntOfferCont.ToString(), true, true);
		this.animatedPopupManager.NBDMOONDIHO();
		CommonUserInterface.EHBBFMCILPC.GetFader().PACBMBLIGNN(new TweenCallback(this.HNPKIODHFDH));
	}

	// Token: 0x06003616 RID: 13846 RVA: 0x0016AB2C File Offset: 0x00168D2C
	private void JJKLOHBFJAJ()
	{
		AOBJLALDBAA.BIAEAOMHBMM().FDKBIBKABCM("snaprew", 1526f);
		CommonUserInterface.IKNOFBFMPGA().GetPurchasingViewManager().ShowAndPurchaseProduct(PopupRemoveAdsManager.removeAdsProductId, false);
	}

	// Token: 0x06003617 RID: 13847 RVA: 0x0016AB58 File Offset: 0x00168D58
	public void IDHIPLFECDN()
	{
		FirebaseAnalyticsManager.JMDJBFAEHBM().LKONPEEDKNF(true, AGEHCPDNBFD.mntActiv.ToString(), FFPHBMFGCNN.reqExcRpt.ToString(), BGHLMGPPCNN.cdnLbyLoad.ToString(), false, true);
		OBHDGKFFICI productData = PurchaseManagerBridge.KMNBCEMEBBD().MGMDKEJBEPP().GetProductData(PopupRemoveAdsManager.removeAdsProductId);
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.GIOAFDDKKHI().FCPIJEEMHEA(PopupRemoveAdsManager.removeAdsProductId);
		if (productData != null && ocbiopoeenj != null)
		{
			this.titleText.SetText(CCOJBMMKNAP.KNKGCDDMLDP().JHNELLJFBGC("PurchaseManagerUnity.CompletePurchase(): _order is null, can happen when restoring purchases.") + "story" + ocbiopoeenj.DMODNDCLGEJ, false);
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("OnRewardSubsequentEpisodeClick");
		}
		base.gameObject.SetActive(false);
	}

	// Token: 0x06003618 RID: 13848 RVA: 0x0016AC0E File Offset: 0x00168E0E
	private void BHEELONLPAB()
	{
		AOBJLALDBAA.CEGAOMEEFBE().CIGLHCJDDPI("<alpha=#FF><align=\"left\">\n\n<i>", 1025f);
		CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().CGDKCOLDBGD(PopupRemoveAdsManager.removeAdsProductId, true);
	}

	// Token: 0x06003619 RID: 13849 RVA: 0x0016AC39 File Offset: 0x00168E39
	private void MCICCIFJKGC()
	{
		AOBJLALDBAA.DBLAIDPICIG().KGIKHEDLPND("aindas", 739f);
		CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().ShowAndPurchaseProduct(PopupRemoveAdsManager.removeAdsProductId, false);
	}

	// Token: 0x0600361A RID: 13850 RVA: 0x0016AC64 File Offset: 0x00168E64
	public void MPGOEKBHHHH()
	{
		PurchaseManagerBridge.FJHKMJPFDNI().MGMDKEJBEPP().Initialize();
		FirebaseAnalyticsManager.HJGDLOOHNLO().LKONPEEDKNF(false, AGEHCPDNBFD.mntActiv.ToString(), FFPHBMFGCNN.dldStart.ToString(), BGHLMGPPCNN.mntRemAdsClose.ToString(), false, false);
		this.animatedPopupManager.LHNKFOKBBCP();
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.MCICCIFJKGC));
	}

	// Token: 0x0600361B RID: 13851 RVA: 0x0016ACE0 File Offset: 0x00168EE0
	public void AKHDMIEEEHF()
	{
		FirebaseAnalyticsManager.JMDJBFAEHBM().LogEvent(false, AGEHCPDNBFD.mntActiv.ToString(), FFPHBMFGCNN.reqInfnt.ToString(), BGHLMGPPCNN.mntOfferCont.ToString(), true, false);
		OBHDGKFFICI productData = PurchaseManagerBridge.EHBBFMCILPC.MGMDKEJBEPP().GetProductData(PopupRemoveAdsManager.removeAdsProductId);
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.FILDBDMENPG().ICBJCNKKGPJ(PopupRemoveAdsManager.removeAdsProductId);
		if (productData != null && ocbiopoeenj != null)
		{
			this.titleText.SetText(CCOJBMMKNAP.PKEINLPIAEH().OGKGHLHHAAI("h") + "oldvhs_2" + ocbiopoeenj.DMODNDCLGEJ, true);
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("OnRewardsItemClose");
		}
		base.gameObject.SetActive(false);
	}

	// Token: 0x0600361C RID: 13852 RVA: 0x0016AD96 File Offset: 0x00168F96
	private void LPJPCOEBOHF()
	{
		AOBJLALDBAA.FILDBDMENPG().LPNCDPHNBJK("yes", 943f);
		CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().ShowAndPurchaseProduct(PopupRemoveAdsManager.removeAdsProductId, true);
	}

	// Token: 0x0600361D RID: 13853 RVA: 0x0016ADC4 File Offset: 0x00168FC4
	public void KFPBLICOBBG()
	{
		FirebaseAnalyticsManager.EHBBFMCILPC.JIAAMJPKOCE(true, AGEHCPDNBFD.rqst.ToString(), FFPHBMFGCNN.reqExcRpt.ToString(), BGHLMGPPCNN.mntOfferClose.ToString(), false, true);
		AOBJLALDBAA.CEGAOMEEFBE().EFBNBFIDEOK("p", 533f);
		this.animatedPopupManager.LHNKFOKBBCP();
	}

	// Token: 0x0600361E RID: 13854 RVA: 0x0016AE2C File Offset: 0x0016902C
	public void OJIPABNEOIE()
	{
		FirebaseAnalyticsManager.DMAAFFFEJGA().LMCJKLHOHJC(true, AGEHCPDNBFD.mntActiv.ToString(), FFPHBMFGCNN.reqInfnt.ToString(), BGHLMGPPCNN.mntRemAdsClose.ToString(), false, false);
		AOBJLALDBAA.FILDBDMENPG().EGELHPJBAIC("$SHOWLOGO", 114f);
		this.animatedPopupManager.GLIAGHMNMMP();
	}

	// Token: 0x0600361F RID: 13855 RVA: 0x00003E52 File Offset: 0x00002052
	private void OMNGHDNDLKP()
	{
	}

	// Token: 0x06003620 RID: 13856 RVA: 0x0016AE94 File Offset: 0x00169094
	public void MLANIKPFIMA()
	{
		FirebaseAnalyticsManager.JMDJBFAEHBM().LKONPEEDKNF(true, AGEHCPDNBFD.mntActiv.ToString(), FFPHBMFGCNN.reqCback2.ToString(), BGHLMGPPCNN.mntRemAdsClose.ToString(), false, false);
		OBHDGKFFICI productData = PurchaseManagerBridge.FJHKMJPFDNI().DIOJHOIFIIH().GetProductData(PopupRemoveAdsManager.removeAdsProductId);
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.JLEOPAOEFGP().HLGBFOMMJFE(PopupRemoveAdsManager.removeAdsProductId);
		if (productData != null && ocbiopoeenj != null)
		{
			this.titleText.SetText(CCOJBMMKNAP.AEELGGPEJCC().JLBEIFLLBLO("af_order_id") + "apb" + ocbiopoeenj.DMODNDCLGEJ, false);
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("skuAuto");
		}
		base.gameObject.SetActive(false);
	}

	// Token: 0x06003621 RID: 13857 RVA: 0x00003E52 File Offset: 0x00002052
	private void JFEKHEIGPJD()
	{
	}

	// Token: 0x06003622 RID: 13858 RVA: 0x0016AF4C File Offset: 0x0016914C
	public void FPKGCIFFEKG()
	{
		FirebaseAnalyticsManager.JMDJBFAEHBM().JIAAMJPKOCE(true, AGEHCPDNBFD.mntActiv.ToString(), FFPHBMFGCNN.reqExc.ToString(), BGHLMGPPCNN.cdnLbyLoad.ToString(), true, true);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC(" : content size ", 1860f);
		this.animatedPopupManager.GFEHJHIDHFF();
	}

	// Token: 0x06003623 RID: 13859 RVA: 0x0016AFB4 File Offset: 0x001691B4
	public void BPOBIDIADCC()
	{
		FirebaseAnalyticsManager.COKDLDOAACJ().JIAAMJPKOCE(true, AGEHCPDNBFD.mntActiv.ToString(), FFPHBMFGCNN.reqCback1.ToString(), BGHLMGPPCNN.cdnLbyLoadPt2.ToString(), false, true);
		AOBJLALDBAA.NMGMNAKLLMI().KGIKHEDLPND("h", 1542f);
		this.animatedPopupManager.ADAJPNHIICL();
	}

	// Token: 0x06003624 RID: 13860 RVA: 0x0016B01C File Offset: 0x0016921C
	public void MOLFJIOCFIC()
	{
		FirebaseAnalyticsManager.DMAAFFFEJGA().LKONPEEDKNF(false, AGEHCPDNBFD.rqst.ToString(), FFPHBMFGCNN.reqExc.ToString(), BGHLMGPPCNN.cdnLbyLoadPt2.ToString(), true, true);
		OBHDGKFFICI productData = PurchaseManagerBridge.KMNBCEMEBBD().DOMEKEJELKB().GetProductData(PopupRemoveAdsManager.removeAdsProductId);
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.OBOOKJPGBJN().DOOPGOIBFAN(PopupRemoveAdsManager.removeAdsProductId);
		if (productData != null && ocbiopoeenj != null)
		{
			this.titleText.SetText(CCOJBMMKNAP.APGODIBBPOD().JHNELLJFBGC("Error deserializing JSON. Unknown tag: ") + "id" + ocbiopoeenj.DMODNDCLGEJ, true);
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("");
		}
		base.gameObject.SetActive(true);
	}

	// Token: 0x06003625 RID: 13861 RVA: 0x00003E52 File Offset: 0x00002052
	private void PABLFIJDFAD()
	{
	}

	// Token: 0x06003626 RID: 13862 RVA: 0x0016B0D4 File Offset: 0x001692D4
	public void EGBLACINBOA()
	{
		PurchaseManagerBridge.IGJAMEGBDBG().DIOJHOIFIIH().Initialize();
		FirebaseAnalyticsManager.JMDJBFAEHBM().LKONPEEDKNF(false, AGEHCPDNBFD.rqst.ToString(), FFPHBMFGCNN.mntOffer.ToString(), BGHLMGPPCNN.cdnLbyLoadPt1.ToString(), true, true);
		this.animatedPopupManager.NBDMOONDIHO();
		CommonUserInterface.IKNOFBFMPGA().GetFader().BJIGLKGLAKM(new TweenCallback(this.FDEHOKEPDPE));
	}

	// Token: 0x06003627 RID: 13863 RVA: 0x0016B150 File Offset: 0x00169350
	private void HNCKBIGLOLF()
	{
		AOBJLALDBAA.BIAEAOMHBMM().FDKBIBKABCM("importanttitle", 378f);
		CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().ShowAndPurchaseProduct(PopupRemoveAdsManager.removeAdsProductId, false);
	}

	// Token: 0x06003628 RID: 13864 RVA: 0x0016B17B File Offset: 0x0016937B
	private void LKJCGOPAFMN()
	{
		AOBJLALDBAA.CEGAOMEEFBE().EFBNBFIDEOK("pipeline start", 1134f);
		CommonUserInterface.IKNOFBFMPGA().GetPurchasingViewManager().ShowAndPurchaseProduct(PopupRemoveAdsManager.removeAdsProductId, false);
	}

	// Token: 0x06003629 RID: 13865 RVA: 0x00003E52 File Offset: 0x00002052
	private void IMCHEPFNANC()
	{
	}

	// Token: 0x0600362A RID: 13866 RVA: 0x0016B1A8 File Offset: 0x001693A8
	public void ACHIELEBCCO()
	{
		PurchaseManagerBridge.LMCCLMFGEBD().MGMDKEJBEPP().Initialize();
		FirebaseAnalyticsManager.HJGDLOOHNLO().LogEvent(false, AGEHCPDNBFD.rqst.ToString(), FFPHBMFGCNN.mntOffer.ToString(), BGHLMGPPCNN.cdnLbyLoadPt2.ToString(), false, true);
		this.animatedPopupManager.OHHFFMMMMAC();
		CommonUserInterface.EHBBFMCILPC.GetFader().PACBMBLIGNN(new TweenCallback(this.FDEHOKEPDPE));
	}

	// Token: 0x0600362B RID: 13867 RVA: 0x0016B224 File Offset: 0x00169424
	private void FDEHOKEPDPE()
	{
		AOBJLALDBAA.DBLAIDPICIG().FDKBIBKABCM(" ", 1099f);
		CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().ShowAndPurchaseProduct(PopupRemoveAdsManager.removeAdsProductId, false);
	}

	// Token: 0x0600362C RID: 13868 RVA: 0x0016B250 File Offset: 0x00169450
	public void AIEDJEMEAKC()
	{
		FirebaseAnalyticsManager.ANCEKPONIFI().AAIABAKHLAH(false, AGEHCPDNBFD.rqst.ToString(), FFPHBMFGCNN.mntOffer.ToString(), BGHLMGPPCNN.mntRemAdsShow.ToString(), true, false);
		OBHDGKFFICI productData = PurchaseManagerBridge.OOGPALHPNGM().CMAKHBMINLG().GetProductData(PopupRemoveAdsManager.removeAdsProductId);
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.BBGECIKOICE().LIGHNGCMJJL(PopupRemoveAdsManager.removeAdsProductId);
		if (productData != null && ocbiopoeenj != null)
		{
			this.titleText.SetText(CCOJBMMKNAP.JMNIGPHCAEJ().OBDCPLLLGBB("OnUserpassLoginFailed") + "newtutorialfriends" + ocbiopoeenj.DMODNDCLGEJ, false);
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("gamepassdurationbody");
		}
		base.gameObject.SetActive(false);
	}

	// Token: 0x0600362D RID: 13869 RVA: 0x0016B308 File Offset: 0x00169508
	public void GLFNFLLAJLN()
	{
		FirebaseAnalyticsManager.HJGDLOOHNLO().LKONPEEDKNF(true, AGEHCPDNBFD.rqst.ToString(), FFPHBMFGCNN.reqInfnt.ToString(), BGHLMGPPCNN.mntOfferShow.ToString(), false, false);
		AOBJLALDBAA.AGANFKKBPFO().LPNCDPHNBJK("avts1", 1352f);
		this.animatedPopupManager.NBDMOONDIHO();
	}

	// Token: 0x0600362E RID: 13870 RVA: 0x0016B370 File Offset: 0x00169570
	public void AJMDPPLNPNC()
	{
		FirebaseAnalyticsManager.DMAAFFFEJGA().LMCJKLHOHJC(false, AGEHCPDNBFD.mntActiv.ToString(), FFPHBMFGCNN.reqCback1.ToString(), BGHLMGPPCNN.cdnLbyLoadPt2.ToString(), true, true);
		AOBJLALDBAA.FILDBDMENPG().FDKBIBKABCM("p", 1693f);
		this.animatedPopupManager.HFFJACPIHKE();
	}

	// Token: 0x0600362F RID: 13871 RVA: 0x00003E52 File Offset: 0x00002052
	private void OKBABBBHMIP()
	{
	}

	// Token: 0x06003630 RID: 13872 RVA: 0x0016B3D8 File Offset: 0x001695D8
	public void JPBDDFHKCFE()
	{
		FirebaseAnalyticsManager.COKDLDOAACJ().AAIABAKHLAH(true, AGEHCPDNBFD.rqst.ToString(), FFPHBMFGCNN.mntOffer.ToString(), BGHLMGPPCNN.cdnLbyLoad.ToString(), false, false);
		OBHDGKFFICI productData = PurchaseManagerBridge.EHBBFMCILPC.CMAKHBMINLG().GetProductData(PopupRemoveAdsManager.removeAdsProductId);
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.APGODIBBPOD().HBLMGBCMBHN(PopupRemoveAdsManager.removeAdsProductId);
		if (productData != null && ocbiopoeenj != null)
		{
			this.titleText.SetText(CCOJBMMKNAP.EAIAHCBAIEJ().JLBEIFLLBLO("ibd") + "OnAccountSignInSuccess" + ocbiopoeenj.DMODNDCLGEJ, false);
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("Hardware not support Image Effects. '{0}' disabled.");
		}
		base.gameObject.SetActive(false);
	}

	// Token: 0x06003631 RID: 13873 RVA: 0x0016B490 File Offset: 0x00169690
	public void ICMNLOPCLGG()
	{
		FirebaseAnalyticsManager.EHBBFMCILPC.AAIABAKHLAH(false, AGEHCPDNBFD.rqst.ToString(), FFPHBMFGCNN.reqFailSem.ToString(), BGHLMGPPCNN.mntOfferCont.ToString(), false, false);
		OBHDGKFFICI productData = PurchaseManagerBridge.LMCCLMFGEBD().CMAKHBMINLG().GetProductData(PopupRemoveAdsManager.removeAdsProductId);
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.APGODIBBPOD().PCBGLNFIPPK(PopupRemoveAdsManager.removeAdsProductId);
		if (productData != null && ocbiopoeenj != null)
		{
			this.titleText.SetText(CCOJBMMKNAP.INKJIBDDMLL().HDIPNMFHIEJ("onhiatustitle") + "importanttitle" + ocbiopoeenj.DMODNDCLGEJ, true);
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("our");
		}
		base.gameObject.SetActive(false);
	}

	// Token: 0x06003633 RID: 13875 RVA: 0x00003E52 File Offset: 0x00002052
	private void AMLICNPKJNO()
	{
	}

	// Token: 0x06003634 RID: 13876 RVA: 0x0016B548 File Offset: 0x00169748
	public void JDCKODOCELM()
	{
		PurchaseManagerBridge.IDMLJFBNHML().JNNBFLDOOHM().Initialize();
		FirebaseAnalyticsManager.EHBBFMCILPC.JIAAMJPKOCE(true, AGEHCPDNBFD.rqst.ToString(), FFPHBMFGCNN.reqInfnt.ToString(), BGHLMGPPCNN.cdnLbyLoadPt1.ToString(), false, false);
		this.animatedPopupManager.HFFJACPIHKE();
		CommonUserInterface.IKNOFBFMPGA().GetFader().FadeIn(new TweenCallback(this.LKJCGOPAFMN));
	}

	// Token: 0x06003635 RID: 13877 RVA: 0x0016B5C4 File Offset: 0x001697C4
	public void IHCHPDNKHCD()
	{
		PurchaseManagerBridge.FJHKMJPFDNI().CMJKNNFMCBM().Initialize();
		FirebaseAnalyticsManager.EHBBFMCILPC.LKONPEEDKNF(false, AGEHCPDNBFD.mntActiv.ToString(), FFPHBMFGCNN.reqExcRpt.ToString(), BGHLMGPPCNN.mntRemAdsShow.ToString(), true, false);
		this.animatedPopupManager.HFFJACPIHKE();
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.PNLFCNEOFMO));
	}

	// Token: 0x06003636 RID: 13878 RVA: 0x0016B640 File Offset: 0x00169840
	public void CJOGGICCCKA()
	{
		FirebaseAnalyticsManager.DMAAFFFEJGA().LogEvent(false, AGEHCPDNBFD.rqst.ToString(), FFPHBMFGCNN.reqExc.ToString(), BGHLMGPPCNN.cdnLbyLoadPt2.ToString(), false, true);
		OBHDGKFFICI productData = PurchaseManagerBridge.GIPAKOPBBEO().PFPKMDAJDBA().GetProductData(PopupRemoveAdsManager.removeAdsProductId);
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.KBNLANLMNCN().IJLAPHFKPMH(PopupRemoveAdsManager.removeAdsProductId);
		if (productData != null && ocbiopoeenj != null)
		{
			this.titleText.SetText(CCOJBMMKNAP.KLAKLFCOMJC().FIENAKIHNOM("MonitorAndKillInfiniteRequest() can kill ") + "areyousurerestartnotea" + ocbiopoeenj.DMODNDCLGEJ, false);
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("abpd2");
		}
		base.gameObject.SetActive(true);
	}

	// Token: 0x06003637 RID: 13879 RVA: 0x0016B6F6 File Offset: 0x001698F6
	private void EIJFKCEIPOJ()
	{
		AOBJLALDBAA.EHBBFMCILPC.CIGLHCJDDPI(" • ", 169f);
		CommonUserInterface.IKNOFBFMPGA().GetPurchasingViewManager().ShowAndPurchaseProduct(PopupRemoveAdsManager.removeAdsProductId, true);
	}

	// Token: 0x06003638 RID: 13880 RVA: 0x0016B724 File Offset: 0x00169924
	public void KLFNFDELJJN()
	{
		FirebaseAnalyticsManager.ANCEKPONIFI().AAIABAKHLAH(false, AGEHCPDNBFD.mntActiv.ToString(), FFPHBMFGCNN.mntRemAds.ToString(), BGHLMGPPCNN.mntOfferCont.ToString(), true, false);
		OBHDGKFFICI productData = PurchaseManagerBridge.OOGPALHPNGM().GetPurchaseManager().GetProductData(PopupRemoveAdsManager.removeAdsProductId);
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.APGODIBBPOD().FHDEDNGLNKI(PopupRemoveAdsManager.removeAdsProductId);
		if (productData != null && ocbiopoeenj != null)
		{
			this.titleText.SetText(CCOJBMMKNAP.GIOAFDDKKHI().FIENAKIHNOM("") + "" + ocbiopoeenj.DMODNDCLGEJ, true);
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("stat1long");
		}
		base.gameObject.SetActive(true);
	}

	// Token: 0x06003639 RID: 13881 RVA: 0x0016B7DC File Offset: 0x001699DC
	public void OLBIHJPHCON()
	{
		PurchaseManagerBridge.GIPAKOPBBEO().DOMEKEJELKB().Initialize();
		FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(true, AGEHCPDNBFD.mntActiv.ToString(), FFPHBMFGCNN.mntOffer.ToString(), BGHLMGPPCNN.cdnLbyLoadPt2.ToString(), true, false);
		this.animatedPopupManager.KCAPIILJKDN();
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.PNLFCNEOFMO));
	}

	// Token: 0x0600363A RID: 13882 RVA: 0x0016B858 File Offset: 0x00169A58
	public void CIICNHOCGKG()
	{
		PurchaseManagerBridge.KMNBCEMEBBD().FDIIEFGBEAG().Initialize();
		FirebaseAnalyticsManager.JMDJBFAEHBM().JIAAMJPKOCE(false, AGEHCPDNBFD.rqst.ToString(), FFPHBMFGCNN.reqFailSem.ToString(), BGHLMGPPCNN.cdnLbyLoadPt2.ToString(), true, true);
		this.animatedPopupManager.OJNDEJNLMFE();
		CommonUserInterface.EHBBFMCILPC.GetFader().BJIGLKGLAKM(new TweenCallback(this.EIJFKCEIPOJ));
	}

	// Token: 0x0600363B RID: 13883 RVA: 0x0016B8D4 File Offset: 0x00169AD4
	public void KFLFFOPPNEO()
	{
		FirebaseAnalyticsManager.COKDLDOAACJ().LMCJKLHOHJC(true, AGEHCPDNBFD.mntActiv.ToString(), FFPHBMFGCNN.reqExc.ToString(), BGHLMGPPCNN.mntRemAdsClose.ToString(), false, false);
		OBHDGKFFICI productData = PurchaseManagerBridge.FJHKMJPFDNI().CMJKNNFMCBM().GetProductData(PopupRemoveAdsManager.removeAdsProductId);
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.PMABBOJDELF().FCPIJEEMHEA(PopupRemoveAdsManager.removeAdsProductId);
		if (productData != null && ocbiopoeenj != null)
		{
			this.titleText.SetText(CCOJBMMKNAP.NIOJNOFGIJO().GLEFEKBDHNK("OnLiveOfferSuccessShowPassesWindow") + "importanttitle" + ocbiopoeenj.DMODNDCLGEJ, true);
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("SceneLobbyManager2.CollectFilteredAinds() - search result ");
		}
		base.gameObject.SetActive(false);
	}

	// Token: 0x0600363C RID: 13884 RVA: 0x0016B98C File Offset: 0x00169B8C
	public void GBEFHHKCCCE()
	{
		FirebaseAnalyticsManager.DEALKJPEMMH().JIAAMJPKOCE(false, AGEHCPDNBFD.rqst.ToString(), FFPHBMFGCNN.reqFailSem.ToString(), BGHLMGPPCNN.mntOfferCont.ToString(), true, false);
		OBHDGKFFICI productData = PurchaseManagerBridge.EHBBFMCILPC.DOMEKEJELKB().GetProductData(PopupRemoveAdsManager.removeAdsProductId);
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.GIOAFDDKKHI().FHDEDNGLNKI(PopupRemoveAdsManager.removeAdsProductId);
		if (productData != null && ocbiopoeenj != null)
		{
			this.titleText.SetText(CCOJBMMKNAP.NIOJNOFGIJO().FCOCLEHKLDJ("NEWSAVE: Error: totalPersistentFound (") + "OnRestorePurchasesFailedInvalidPlatform" + ocbiopoeenj.DMODNDCLGEJ, true);
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("musreward");
		}
		base.gameObject.SetActive(false);
	}

	// Token: 0x0600363D RID: 13885 RVA: 0x0016BA44 File Offset: 0x00169C44
	public void JNPDPEGOIKA()
	{
		FirebaseAnalyticsManager.DMAAFFFEJGA().AAIABAKHLAH(true, AGEHCPDNBFD.mntActiv.ToString(), FFPHBMFGCNN.mntOffer.ToString(), BGHLMGPPCNN.cdnLbyLoad.ToString(), false, true);
		AOBJLALDBAA.FILDBDMENPG().EFBNBFIDEOK("XXX", 1982f);
		this.animatedPopupManager.KCAPIILJKDN();
	}

	// Token: 0x0600363E RID: 13886 RVA: 0x00003E52 File Offset: 0x00002052
	private void NGCHDKEEPOG()
	{
	}

	// Token: 0x0600363F RID: 13887 RVA: 0x0016BAAC File Offset: 0x00169CAC
	public void GMGJDDFDIAD()
	{
		FirebaseAnalyticsManager.HJGDLOOHNLO().LMCJKLHOHJC(false, AGEHCPDNBFD.mntActiv.ToString(), FFPHBMFGCNN.mntOffer.ToString(), BGHLMGPPCNN.mntOfferCont.ToString(), true, false);
		AOBJLALDBAA.FILDBDMENPG().DCGCFPHHDDG("", 396f);
		this.animatedPopupManager.FJAAHFFLGFF();
	}

	// Token: 0x06003640 RID: 13888 RVA: 0x0016BB14 File Offset: 0x00169D14
	public void BJJPDCOPGOG()
	{
		FirebaseAnalyticsManager.COKDLDOAACJ().LKONPEEDKNF(true, AGEHCPDNBFD.rqst.ToString(), FFPHBMFGCNN.reqInfnt.ToString(), BGHLMGPPCNN.cdnLbyLoadPt2.ToString(), false, true);
		AOBJLALDBAA.KKPFOJMAONG().LPNCDPHNBJK(" ", 210f);
		this.animatedPopupManager.Hide();
	}

	// Token: 0x06003641 RID: 13889 RVA: 0x0016BB7C File Offset: 0x00169D7C
	public void Show()
	{
		FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.mntActiv.ToString(), FFPHBMFGCNN.mntRemAds.ToString(), BGHLMGPPCNN.mntRemAdsShow.ToString(), false, false);
		OBHDGKFFICI productData = PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager().GetProductData(PopupRemoveAdsManager.removeAdsProductId);
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.EHBBFMCILPC.PDJKPFLHFLO(PopupRemoveAdsManager.removeAdsProductId);
		if (productData != null && ocbiopoeenj != null)
		{
			this.titleText.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("paytitle") + " USD " + ocbiopoeenj.DMODNDCLGEJ, true);
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("PopupRemoveAdsManager.Show() - productData is null.");
		}
		base.gameObject.SetActive(true);
	}

	// Token: 0x06003642 RID: 13890 RVA: 0x00003E52 File Offset: 0x00002052
	private void FDOPMEKNMEA()
	{
	}

	// Token: 0x06003643 RID: 13891 RVA: 0x00003E52 File Offset: 0x00002052
	private void CJPNMBNKLOO()
	{
	}

	// Token: 0x06003644 RID: 13892 RVA: 0x00003E52 File Offset: 0x00002052
	private void NDKAFCKLNBL()
	{
	}

	// Token: 0x06003645 RID: 13893 RVA: 0x0016BC34 File Offset: 0x00169E34
	public void EABCHINHJKB()
	{
		PurchaseManagerBridge.EHBBFMCILPC.FDIIEFGBEAG().Initialize();
		FirebaseAnalyticsManager.HJGDLOOHNLO().LogEvent(true, AGEHCPDNBFD.mntActiv.ToString(), FFPHBMFGCNN.reqFailSem.ToString(), BGHLMGPPCNN.cdnLbyLoadPt2.ToString(), false, true);
		this.animatedPopupManager.KCAPIILJKDN();
		CommonUserInterface.IKNOFBFMPGA().GetFader().FadeIn(new TweenCallback(this.MCICCIFJKGC));
	}

	// Token: 0x06003646 RID: 13894 RVA: 0x00003E52 File Offset: 0x00002052
	private void NCLALOLOIGP()
	{
	}

	// Token: 0x06003647 RID: 13895 RVA: 0x0016BCB0 File Offset: 0x00169EB0
	public void PCBCNGIDLMH()
	{
		FirebaseAnalyticsManager.JMDJBFAEHBM().AAIABAKHLAH(true, AGEHCPDNBFD.mntActiv.ToString(), FFPHBMFGCNN.reqExcRpt.ToString(), BGHLMGPPCNN.cdnLbyLoadPt1.ToString(), true, false);
		OBHDGKFFICI productData = PurchaseManagerBridge.EHBBFMCILPC.DOMEKEJELKB().GetProductData(PopupRemoveAdsManager.removeAdsProductId);
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.FILDBDMENPG().HCHKAOGEPMG(PopupRemoveAdsManager.removeAdsProductId);
		if (productData != null && ocbiopoeenj != null)
		{
			this.titleText.SetText(CCOJBMMKNAP.FEEDGKCJBLE().GGPHHLGPMPA("aind") + "" + ocbiopoeenj.DMODNDCLGEJ, false);
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("-");
		}
		base.gameObject.SetActive(true);
	}

	// Token: 0x06003648 RID: 13896 RVA: 0x0016BD68 File Offset: 0x00169F68
	public void LEAMMPMJMPH()
	{
		PurchaseManagerBridge.FJHKMJPFDNI().GetPurchaseManager().Initialize();
		FirebaseAnalyticsManager.JMDJBFAEHBM().LKONPEEDKNF(true, AGEHCPDNBFD.mntActiv.ToString(), FFPHBMFGCNN.reqCback1.ToString(), BGHLMGPPCNN.mntRemAdsCont.ToString(), false, false);
		this.animatedPopupManager.OHHFFMMMMAC();
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.LKJCGOPAFMN));
	}

	// Token: 0x06003649 RID: 13897 RVA: 0x00003E52 File Offset: 0x00002052
	private void Start()
	{
	}

	// Token: 0x0600364A RID: 13898 RVA: 0x0016BDE4 File Offset: 0x00169FE4
	public void OFMCOFFGBPP()
	{
		FirebaseAnalyticsManager.DEALKJPEMMH().AAIABAKHLAH(false, AGEHCPDNBFD.rqst.ToString(), FFPHBMFGCNN.mntRemAds.ToString(), BGHLMGPPCNN.cdnLbyLoad.ToString(), false, true);
		AOBJLALDBAA.KKPFOJMAONG().CIGLHCJDDPI("OnBackendGetDropChancesException", 209f);
		this.animatedPopupManager.PIPADCCGHBA();
	}

	// Token: 0x0600364B RID: 13899 RVA: 0x0016BE4C File Offset: 0x0016A04C
	public void CIIJDOELKBJ()
	{
		FirebaseAnalyticsManager.ANCEKPONIFI().LKONPEEDKNF(true, AGEHCPDNBFD.rqst.ToString(), FFPHBMFGCNN.mntRemAds.ToString(), BGHLMGPPCNN.cdnLbyLoadPt2.ToString(), false, false);
		OBHDGKFFICI productData = PurchaseManagerBridge.OOGPALHPNGM().DOMEKEJELKB().GetProductData(PopupRemoveAdsManager.removeAdsProductId);
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.GIOAFDDKKHI().FHDEDNGLNKI(PopupRemoveAdsManager.removeAdsProductId);
		if (productData != null && ocbiopoeenj != null)
		{
			this.titleText.SetText(CCOJBMMKNAP.COKDLDOAACJ().OBDCPLLLGBB("") + "OnStoryInterfaceFastForwardActivate" + ocbiopoeenj.DMODNDCLGEJ, false);
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("CLIENT.POSTEFFECTS.NOISEDIGITAL");
		}
		base.gameObject.SetActive(true);
	}

	// Token: 0x0600364C RID: 13900 RVA: 0x0016BF04 File Offset: 0x0016A104
	public void FLHIEFMJAMO()
	{
		PurchaseManagerBridge.IGJAMEGBDBG().CMAKHBMINLG().Initialize();
		FirebaseAnalyticsManager.JMDJBFAEHBM().LMCJKLHOHJC(false, AGEHCPDNBFD.mntActiv.ToString(), FFPHBMFGCNN.reqFailSem.ToString(), BGHLMGPPCNN.cdnLbyLoad.ToString(), false, false);
		this.animatedPopupManager.Hide();
		CommonUserInterface.IKNOFBFMPGA().GetFader().PACBMBLIGNN(new TweenCallback(this.MOFIFHCEFAE));
	}

	// Token: 0x0600364D RID: 13901 RVA: 0x0016BF80 File Offset: 0x0016A180
	private void ILGIHIKLIGO()
	{
		AOBJLALDBAA.EHBBFMCILPC.CIGLHCJDDPI("", 1929f);
		CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().ShowAndPurchaseProduct(PopupRemoveAdsManager.removeAdsProductId, false);
	}

	// Token: 0x0600364E RID: 13902 RVA: 0x0016BFAC File Offset: 0x0016A1AC
	public void IIDJNJPDDIN()
	{
		FirebaseAnalyticsManager.JMDJBFAEHBM().AAIABAKHLAH(true, AGEHCPDNBFD.rqst.ToString(), FFPHBMFGCNN.reqCback1.ToString(), BGHLMGPPCNN.mntRemAdsCont.ToString(), false, false);
		AOBJLALDBAA.FILDBDMENPG().LPNCDPHNBJK("docid", 1003f);
		this.animatedPopupManager.OJNDEJNLMFE();
	}

	// Token: 0x0600364F RID: 13903 RVA: 0x0016C014 File Offset: 0x0016A214
	public void AOONCMMGFFG()
	{
		FirebaseAnalyticsManager.HJGDLOOHNLO().LMCJKLHOHJC(true, AGEHCPDNBFD.rqst.ToString(), FFPHBMFGCNN.reqFailSem.ToString(), BGHLMGPPCNN.cdnLbyLoad.ToString(), true, false);
		AOBJLALDBAA.AGANFKKBPFO().LPNCDPHNBJK("loungeindevelopment", 631f);
		this.animatedPopupManager.KCAPIILJKDN();
	}

	// Token: 0x06003650 RID: 13904 RVA: 0x0016C07A File Offset: 0x0016A27A
	private void KGCIJEMABKP()
	{
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnPopupRemoveAdsManagerContinueToPurchasingScreen", 0f);
		CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().ShowAndPurchaseProduct(PopupRemoveAdsManager.removeAdsProductId, true);
	}

	// Token: 0x06003651 RID: 13905 RVA: 0x0016C0A8 File Offset: 0x0016A2A8
	public void DDBJMNMBFED()
	{
		FirebaseAnalyticsManager.COKDLDOAACJ().AAIABAKHLAH(false, AGEHCPDNBFD.rqst.ToString(), FFPHBMFGCNN.reqCback1.ToString(), BGHLMGPPCNN.mntOfferShow.ToString(), false, true);
		AOBJLALDBAA.BIAEAOMHBMM().LPNCDPHNBJK("UpdateStatsOnOffState", 34f);
		this.animatedPopupManager.NBDMOONDIHO();
	}

	// Token: 0x06003652 RID: 13906 RVA: 0x0016C110 File Offset: 0x0016A310
	public void DGMEHPMHAJN()
	{
		FirebaseAnalyticsManager.HJGDLOOHNLO().AAIABAKHLAH(true, AGEHCPDNBFD.rqst.ToString(), FFPHBMFGCNN.reqExc.ToString(), BGHLMGPPCNN.mntRemAdsShow.ToString(), true, true);
		AOBJLALDBAA.EHBBFMCILPC.LPNCDPHNBJK("p", 185f);
		this.animatedPopupManager.GLIAGHMNMMP();
	}

	// Token: 0x06003653 RID: 13907 RVA: 0x0016C178 File Offset: 0x0016A378
	public void FOGMIPAJBAN()
	{
		PurchaseManagerBridge.GIPAKOPBBEO().PFPKMDAJDBA().Initialize();
		FirebaseAnalyticsManager.DEALKJPEMMH().JIAAMJPKOCE(false, AGEHCPDNBFD.mntActiv.ToString(), FFPHBMFGCNN.mntRemAds.ToString(), BGHLMGPPCNN.mntRemAdsShow.ToString(), false, false);
		this.animatedPopupManager.KCAPIILJKDN();
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.KGCIJEMABKP));
	}

	// Token: 0x06003654 RID: 13908 RVA: 0x0016C1F4 File Offset: 0x0016A3F4
	public void DLGLHCHLDLE()
	{
		FirebaseAnalyticsManager.ANCEKPONIFI().LogEvent(false, AGEHCPDNBFD.rqst.ToString(), FFPHBMFGCNN.reqExc.ToString(), BGHLMGPPCNN.mntRemAdsShow.ToString(), false, false);
		OBHDGKFFICI productData = PurchaseManagerBridge.KMNBCEMEBBD().PFPKMDAJDBA().GetProductData(PopupRemoveAdsManager.removeAdsProductId);
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.APGODIBBPOD().ICBJCNKKGPJ(PopupRemoveAdsManager.removeAdsProductId);
		if (productData != null && ocbiopoeenj != null)
		{
			this.titleText.SetText(CCOJBMMKNAP.ONCPHEEJLOP().JLBEIFLLBLO("tradewishcardoption0") + "Starting parallel download:" + ocbiopoeenj.DMODNDCLGEJ, true);
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("UpdatePostOnOffState");
		}
		base.gameObject.SetActive(true);
	}

	// Token: 0x04001015 RID: 4117
	public const string onPopupRemoveAdsManagerDismissed = "OnPopupRemoveAdsManagerDismissed";

	// Token: 0x04001016 RID: 4118
	public const string onPopupRemoveAdsManagerContinueToPurchasingScreen = "OnPopupRemoveAdsManagerContinueToPurchasingScreen";

	// Token: 0x04001017 RID: 4119
	public static string removeAdsProductId = "sails_remove_ads";

	// Token: 0x04001018 RID: 4120
	public TextMeshProUGUI titleText;

	// Token: 0x04001019 RID: 4121
	public AnimatedPopupManager animatedPopupManager;
}
