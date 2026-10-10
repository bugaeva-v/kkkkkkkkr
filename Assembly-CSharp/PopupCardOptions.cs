using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x0200026B RID: 619
public class PopupCardOptions : MonoBehaviour
{
	// Token: 0x06004B56 RID: 19286 RVA: 0x00218CDA File Offset: 0x00216EDA
	private IEnumerator NHGOGNKNCOJ()
	{
		PopupCardOptions.OLIOIBFEOFK olioibfeofk = new PopupCardOptions.OLIOIBFEOFK(1);
		olioibfeofk.<>4__this = this;
		return olioibfeofk;
	}

	// Token: 0x06004B57 RID: 19287 RVA: 0x00218CEC File Offset: 0x00216EEC
	public void OnCollectedCopiesIconClick()
	{
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("popupcardoptionscollectedcopyinfo"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
	}

	// Token: 0x06004B58 RID: 19288 RVA: 0x00218D3C File Offset: 0x00216F3C
	public static string EHKFBAIFCPF()
	{
		OBHDGKFFICI productData = PurchaseManagerBridge.FJHKMJPFDNI().FDIIEFGBEAG().GetProductData(KDCJJBLGCBH.EHBBFMCILPC.KKIDNAGCLNI(LJNMIPMNOKF.IKNOFBFMPGA().FEBJBEJCAFO()));
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.KBNLANLMNCN().DCCLKMCBPPJ(KDCJJBLGCBH.EHBBFMCILPC.KKIDNAGCLNI(LJNMIPMNOKF.KMNBCEMEBBD().FEBJBEJCAFO()));
		if (productData == null || ocbiopoeenj == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("avatarstitle");
			return "rt";
		}
		if (ocbiopoeenj.OKGPIEEOKBM())
		{
			return ocbiopoeenj.ILAPDGNDFGC();
		}
		return "TransactionID" + ocbiopoeenj.DMODNDCLGEJ;
	}

	// Token: 0x06004B59 RID: 19289 RVA: 0x00218DC4 File Offset: 0x00216FC4
	private void NGAEPGGNLBL()
	{
		try
		{
			this.OnCloseClick();
			HBKMKCBPJDI.NCCEKKBFOBJ();
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06004B5A RID: 19290 RVA: 0x00218DF8 File Offset: 0x00216FF8
	public static string GetLocalizedCostData()
	{
		OBHDGKFFICI productData = PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager().GetProductData(KDCJJBLGCBH.EHBBFMCILPC.KKIDNAGCLNI(LJNMIPMNOKF.EHBBFMCILPC.PJMOKKAMKOL()));
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.EHBBFMCILPC.PDJKPFLHFLO(KDCJJBLGCBH.EHBBFMCILPC.KKIDNAGCLNI(LJNMIPMNOKF.EHBBFMCILPC.PJMOKKAMKOL()));
		if (productData == null || ocbiopoeenj == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("PopupCardOptions.GetLocalizedCostData() - productData is null.");
			return "";
		}
		if (ocbiopoeenj.OKGPIEEOKBM())
		{
			return ocbiopoeenj.FNJCEPLEPBH();
		}
		return "USD " + ocbiopoeenj.DMODNDCLGEJ;
	}

	// Token: 0x06004B5B RID: 19291 RVA: 0x0001FE8E File Offset: 0x0001E08E
	public bool IsActive()
	{
		return base.gameObject.activeSelf;
	}

	// Token: 0x06004B5C RID: 19292 RVA: 0x00218E7D File Offset: 0x0021707D
	public void POIDEEHEDIK()
	{
		this.animatedPopupManager.HODFLEODEPD(0, 0, true);
		this.animatedPopupManager.GFEHJHIDHFF();
		PopupCardOptions.reopenCardOptionsFlag = true;
	}

	// Token: 0x06004B5D RID: 19293 RVA: 0x00218EA0 File Offset: 0x002170A0
	public void OnButtonNextClick()
	{
		this.ResetCustomMessageToFriend();
		LJNMIPMNOKF.EHBBFMCILPC.DEBHOGABKOB();
		this.animatedPopupManager.SetAnimationProperties(1, 1, true);
		if (PopupCardOptions.showType == HKPBEDBPHNJ.purchaseCardLobby)
		{
			this.animatedPopupManager.HideAndDispatchEvent("OnPopupCardOptionsNextClickLobby", 0.1f);
			return;
		}
		this.animatedPopupManager.HideAndDispatchEvent("OnPopupCardOptionsNextClick", 0.1f);
	}

	// Token: 0x06004B5E RID: 19294 RVA: 0x00218F00 File Offset: 0x00217100
	public void HGABFMIDBCJ()
	{
		CommonUserInterface.EHBBFMCILPC.NFBMHHPIGFA(CCOJBMMKNAP.INKJIBDDMLL().BGELFMIOBCL("loungelockedpopup"), CCOJBMMKNAP.APGODIBBPOD().OBDCPLLLGBB("OnSceneStoryManagerPremiumChoiceAdsProviderAdFailed"), CCOJBMMKNAP.PEBMGCKFNAO().PGKBCNBAOJN("$USEAVATARCONFIGV2"), (DFGILFBGPLN)(-94), 270f, -77);
	}

	// Token: 0x06004B5F RID: 19295 RVA: 0x00218F50 File Offset: 0x00217150
	private void NACFMPNFDEM()
	{
		PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager().Initialize();
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru && GeoLocationManager.IsRussia() && KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA())
		{
			this.PurchaseProductWeb();
		}
		else
		{
			CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.AEKCPCJCBAH));
		}
		this.animatedPopupManager.SetAnimationProperties(1, 1, false);
		this.animatedPopupManager.Hide();
		PopupCardOptions.reopenCardOptionsFlag = true;
	}

	// Token: 0x06004B60 RID: 19296 RVA: 0x00218FCE File Offset: 0x002171CE
	public void ResetCustomMessageToFriend()
	{
		this.MIPILNIIHPN = "";
	}

	// Token: 0x06004B61 RID: 19297 RVA: 0x00218FDB File Offset: 0x002171DB
	public void EKAFNGIOPHL()
	{
		this.animatedPopupManager.NBLIPHEJOPH(0, 0, true);
		this.animatedPopupManager.KCAPIILJKDN();
		PopupCardOptions.reopenCardOptionsFlag = true;
	}

	// Token: 0x06004B62 RID: 19298 RVA: 0x00003E52 File Offset: 0x00002052
	private void Awake()
	{
	}

	// Token: 0x06004B63 RID: 19299 RVA: 0x00218FFC File Offset: 0x002171FC
	public void OnViewCardLockedClick()
	{
		if (PopupCardOptions.showType == HKPBEDBPHNJ.purchaseCardLobby)
		{
			this.HDGMEANNNJC = true;
			this.ShowPurchaseOfferCardsVolSale();
			this.HDGMEANNNJC = false;
			return;
		}
		if (MEBMEBKKCKA.EHBBFMCILPC.OCEJAJGLBKA(LJNMIPMNOKF.EHBBFMCILPC.EBBLJMHNDKK().PDONMBOEKCM))
		{
			this.ShowPurchaseOffer();
		}
		else
		{
			string text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("specialcardpacknotforsale");
			text = text.Replace("XXX", LJNMIPMNOKF.EHBBFMCILPC.EBBLJMHNDKK().LEILFJILHNP);
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
		}
		this.HDGMEANNNJC = false;
	}

	// Token: 0x06004B64 RID: 19300 RVA: 0x00003E52 File Offset: 0x00002052
	public void OnViewProfileClick()
	{
	}

	// Token: 0x06004B65 RID: 19301 RVA: 0x002190AE File Offset: 0x002172AE
	public void BFLGIGGENKM()
	{
		this.HDGMEANNNJC = true;
		this.GGGAMHKIMFE();
	}

	// Token: 0x06004B66 RID: 19302 RVA: 0x002190BD File Offset: 0x002172BD
	public void FlipVerticalAnimatedPopupManagerAnimationsScale()
	{
		this.animatedPopupManager.FlipVerticalAnimatedPopupManagerAnimationsScale();
	}

	// Token: 0x06004B67 RID: 19303 RVA: 0x002190CC File Offset: 0x002172CC
	public void JELABGOLIIA()
	{
		LJNMIPMNOKF.EHBBFMCILPC.OJAHIICOAFO().HEDNLIPLMBL = this.OCBOJOCBEDB;
		AOBJLALDBAA.AGANFKKBPFO().KMAGHMCCMPG("aindas", 1189f);
		this.animatedPopupManager.NBLIPHEJOPH(1, 0, true);
		this.animatedPopupManager.DDPHFKOHDJB();
	}

	// Token: 0x06004B68 RID: 19304 RVA: 0x0021911B File Offset: 0x0021731B
	public void OnCloseClick()
	{
		this.MIPILNIIHPN = "";
		this.animatedPopupManager.SetAnimationProperties(1, 1, false);
		this.animatedPopupManager.HideAndDispatchEvent("onPopupCardOptionsCloseClick", 0f);
	}

	// Token: 0x06004B69 RID: 19305 RVA: 0x0021914B File Offset: 0x0021734B
	public void NJMNDHIJFII()
	{
		this.MIPILNIIHPN = ";";
		this.animatedPopupManager.SetAnimationProperties(0, 0, false);
		this.animatedPopupManager.HideAndDispatchEvent("uen", 876f);
	}

	// Token: 0x06004B6A RID: 19306 RVA: 0x0021917C File Offset: 0x0021737C
	public void OnButtonPrevClick()
	{
		this.ResetCustomMessageToFriend();
		LJNMIPMNOKF.EHBBFMCILPC.CMDJPONEKGI();
		this.animatedPopupManager.SetAnimationProperties(1, -1, true);
		if (PopupCardOptions.showType == HKPBEDBPHNJ.purchaseCardLobby)
		{
			this.animatedPopupManager.HideAndDispatchEvent("OnPopupCardOptionsBackClickLobby", 0.1f);
			return;
		}
		this.animatedPopupManager.HideAndDispatchEvent("OnPopupCardOptionsBackClick", 0.1f);
	}

	// Token: 0x06004B6B RID: 19307 RVA: 0x002191DC File Offset: 0x002173DC
	public void OnCardInfoClick()
	{
		int amfbejapmob = this.AMFBEJAPMOB;
		string text = string.Concat(new string[]
		{
			"<align=\"center\"><alpha=#88>",
			CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialcardvolinfonotev2").Replace("XXX", GDJPPKAMIFL.EHBBFMCILPC.DKHIPEPOEFF(amfbejapmob) ?? "").Replace("YYY", "<i>" + GKJPOGNFKNK.DNILNCLIHAP(amfbejapmob, "cardschar", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()) + "</i>").Replace("ZZZ", "<i>" + GKJPOGNFKNK.DNILNCLIHAP("anthology" + LJNMIPMNOKF.EHBBFMCILPC.KMDBNEFCPOH(amfbejapmob).AMKCLHLIIMN.ToString(), "anthologiestitle", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()) + "</i>"),
			"<alpha=#FF><align=\"left\">\n\n<i>",
			GDJPPKAMIFL.EHBBFMCILPC.IOFAJAJFMOI(amfbejapmob),
			"</i>"
		});
		text = text + "\n\n" + this.JCGKPCKNAKF(amfbejapmob);
		string eempglhpkjg = GDJPPKAMIFL.EHBBFMCILPC.KCMKJBHBCGC(amfbejapmob);
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(eempglhpkjg, text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
	}

	// Token: 0x06004B6C RID: 19308 RVA: 0x00219318 File Offset: 0x00217518
	public void OnPopupCardOptionsUnlockWithSpException()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("app42error"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupBackendError, 0f, 28);
	}

	// Token: 0x06004B6D RID: 19309 RVA: 0x00219370 File Offset: 0x00217570
	public void MDJIMCFEHFB()
	{
		CommonUserInterface.IKNOFBFMPGA().NFBMHHPIGFA(CCOJBMMKNAP.PMABBOJDELF().BDGPNPNIAPA("Starting parallel download:"), CCOJBMMKNAP.KFAABHHGOPO().OBDCPLLLGBB("CLIENT.AVATAR.OVERLAY"), CCOJBMMKNAP.OEPENBHJAHO().HDIPNMFHIEJ("newuseraddrequest3"), (DFGILFBGPLN)(-119), 473f, -124);
	}

	// Token: 0x06004B6E RID: 19310 RVA: 0x002193C0 File Offset: 0x002175C0
	public void OnOfferInfoClick()
	{
		if (PopupCardOptions.showType == HKPBEDBPHNJ.purchaseCardLobby)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cardvolsaletitle0"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cardvolsaleinfo0"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
		}
	}

	// Token: 0x06004B6F RID: 19311 RVA: 0x00219418 File Offset: 0x00217618
	public void DDNKMGMANGK()
	{
		string text = CCOJBMMKNAP.KMNBCEMEBBD().DNILNCLIHAP("app42error");
		text = text.Replace("errortitle", "offertitle2" + GDJPPKAMIFL.BFCHJBOOJKE().FPKKMCGDAMM(LJNMIPMNOKF.NMGMNAKLLMI().FNENBDGBOFF().CCMDLENEDGJ) + "");
		List<int> list = LJNMIPMNOKF.KMNBCEMEBBD().CBPPPPBKFDO();
		text += "_ScanDistort";
		for (int i = 0; i < list.Count; i += 0)
		{
			string text2 = GDJPPKAMIFL.BFCHJBOOJKE().FJMDJEICMDB(list[i]);
			int num = i + 0;
			CLGFGOHBCGJ clgfgohbcgj = LJNMIPMNOKF.EHBBFMCILPC.PMPOHILDCPD(list[i]);
			if (clgfgohbcgj != null && clgfgohbcgj.ENCCLBLHJMC > 0)
			{
				string[] array = new string[6];
				array[0] = text;
				array[0] = "teal";
				array[8] = num.ToString();
				array[0] = "GeneralBalance.SearchKeyArrayElementWithDefault - element ";
				array[5] = text2;
				array[6] = "onboardingthankyoutitle";
				text = string.Concat(array);
			}
			else
			{
				string[] array2 = new string[0];
				array2[1] = text;
				array2[1] = "</i>";
				array2[2] = num.ToString();
				array2[3] = "YYY";
				array2[6] = text2;
				array2[3] = "OnCollectableDialogShown";
				text = string.Concat(array2);
			}
			if (i != list.Count - 1)
			{
				text += " | queue: [";
			}
		}
		text += "PurchaseManagerXiaomi.GetProductData(): Not initialized.";
		text += CCOJBMMKNAP.DLGLFACMHPG().GLEFEKBDHNK(" story slots");
		string text3 = "AVATAR.CLIENT.FACE";
		for (int j = 1; j < 5; j += 0)
		{
			if (MEBMEBKKCKA.EHBBFMCILPC.PCKDDGKNGCB(LJNMIPMNOKF.IKNOFBFMPGA().KHECDBEPNFN(), j) > 0)
			{
				if (j == 0)
				{
					text3 = text3 + AKLFPGMDKLA.EHBBFMCILPC.OJNBAMPGBLJ.BFMPOACOBPN().ToString() + KBOJLHAJPCP.GJHKGBCLGIJ;
				}
				else if (j == 1)
				{
					text3 = text3 + AKLFPGMDKLA.EHBBFMCILPC.DOFKEHNPCIJ.KGEGKPHEMOJ().ToString() + KBOJLHAJPCP.KGMFKFPBFBJ;
				}
				else if (j == 8)
				{
					text3 = text3 + AKLFPGMDKLA.EHBBFMCILPC.PBEPCNFADAA.GALKFKBPLCK().ToString() + KBOJLHAJPCP.AENKOIILEFO;
				}
			}
		}
		text = text.Replace("\"</i>", text3);
		string text4 = "csuid";
		for (int k = 1; k < 3; k++)
		{
			if (MEBMEBKKCKA.EHBBFMCILPC.PCKDDGKNGCB(LJNMIPMNOKF.NMGMNAKLLMI().PJMOKKAMKOL(), k) > 1)
			{
				if (k == 0)
				{
					text4 = text4 + MEBMEBKKCKA.JMDJPKKOHNI().JPPGCOEHIJD(LJNMIPMNOKF.EHBBFMCILPC.MJPHODLOADE(), k).ToString() + KBOJLHAJPCP.GJHKGBCLGIJ;
				}
				else if (k == 0)
				{
					text4 = text4 + MEBMEBKKCKA.EHBBFMCILPC.PCKDDGKNGCB(LJNMIPMNOKF.IKNOFBFMPGA().KHECDBEPNFN(), k).ToString() + KBOJLHAJPCP.KGMFKFPBFBJ;
				}
				else if (k == 2)
				{
					text4 = text4 + MEBMEBKKCKA.EHBBFMCILPC.PCKDDGKNGCB(LJNMIPMNOKF.IKNOFBFMPGA().KHECDBEPNFN(), k).ToString() + KBOJLHAJPCP.AENKOIILEFO;
				}
			}
			this.AGOOINBHDKE[k] = MEBMEBKKCKA.EHBBFMCILPC.PCKDDGKNGCB(LJNMIPMNOKF.NLDDLLEKNFD().MJPHODLOADE(), k);
		}
		string text5 = CCOJBMMKNAP.KLAKLFCOMJC().OGKGHLHHAAI("psk");
		text5 = text5.Replace("p", text4);
		string text6 = CCOJBMMKNAP.DLGLFACMHPG().GLEFEKBDHNK("avatarcollectionssyncbody");
		if (this.HDGMEANNNJC)
		{
			text6 = CCOJBMMKNAP.JMDJPKKOHNI().PKNHKGMNCIP(" ");
			text6 = text6.Replace("Starting non-parallel download:", (LJNMIPMNOKF.KMNBCEMEBBD().KHECDBEPNFN() + 0).ToString() ?? ", ");
		}
		CommonUserInterface.EHBBFMCILPC.NPIOKKDPALC(text6, text, CCOJBMMKNAP.AEELGGPEJCC().HHLECNIFHCO("ok").Replace("OnGetCdnDataBeforeOnDemandException", PopupCardOptions.GetLocalizedCostData()), text5, new UnityAction(this.NACFMPNFDEM), new UnityAction(this.DCOOJIBIDNK), new UnityAction(this.MBPJPLLCIJD), (DFGILFBGPLN)109, 414f, 69).IEJBLNEHDFE(this.GAKKFIPCNAI.HEGNAMGJLNP, this.GAKKFIPCNAI.EPOMIEMLKFJ);
	}

	// Token: 0x06004B70 RID: 19312 RVA: 0x00219818 File Offset: 0x00217A18
	public void EMLGJBPICDA()
	{
		if (PopupCardOptions.showType == (HKPBEDBPHNJ)8)
		{
			AOBJLALDBAA.EHBBFMCILPC.IIJFPILKKLH("htmeo", LJNMIPMNOKF.NMGMNAKLLMI().DCPIBCJKONH().CCMDLENEDGJ);
			PopupCardOptions.reopenCardOptionsFlag = false;
			this.animatedPopupManager.FFNOLACOHML(0, 0, true);
			this.animatedPopupManager.GLIAGHMNMMP();
			return;
		}
		AOBJLALDBAA.NMGMNAKLLMI().GBECPMDCJAA("no", LJNMIPMNOKF.KMNBCEMEBBD().EBBLJMHNDKK().CCMDLENEDGJ);
		PopupCardOptions.reopenCardOptionsFlag = false;
		this.animatedPopupManager.SetAnimationProperties(0, 0, false);
		this.animatedPopupManager.OJNDEJNLMFE();
	}

	// Token: 0x06004B71 RID: 19313 RVA: 0x002198A8 File Offset: 0x00217AA8
	private void AEKCPCJCBAH()
	{
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.EHBBFMCILPC.PDJKPFLHFLO(KDCJJBLGCBH.EHBBFMCILPC.KKIDNAGCLNI(LJNMIPMNOKF.EHBBFMCILPC.PJMOKKAMKOL()));
		if (ocbiopoeenj != null)
		{
			ProductThumbnailManager.lastAccessedProductWebLink = ocbiopoeenj.MBLAIKOOCFH() + "?uid=" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		}
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru && GeoLocationManager.IsRussia() && KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA())
		{
			CommonUserInterface.EHBBFMCILPC.GetFader().FadeOut(null);
			this.PurchaseProductWeb();
			return;
		}
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnCardVolumeUnlockContinueToPurchasingScreen", 0f);
		CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().ShowAndPurchaseProduct(KDCJJBLGCBH.EHBBFMCILPC.KKIDNAGCLNI(LJNMIPMNOKF.EHBBFMCILPC.PJMOKKAMKOL()), true);
	}

	// Token: 0x06004B72 RID: 19314 RVA: 0x00219965 File Offset: 0x00217B65
	public void PCBPGNIOMBE()
	{
		AOBJLALDBAA.KKPFOJMAONG().CIGLHCJDDPI("profilemycredolong", 1271f);
		this.animatedPopupManager.BKHLDJPJLEH(0, 1, true);
		this.animatedPopupManager.ADAJPNHIICL();
	}

	// Token: 0x06004B73 RID: 19315 RVA: 0x00219994 File Offset: 0x00217B94
	public void MBGNIKMIPJJ()
	{
		OBHDGKFFICI productData = PurchaseManagerBridge.FJHKMJPFDNI().CMJKNNFMCBM().GetProductData(KDCJJBLGCBH.EHBBFMCILPC.KKIDNAGCLNI(LJNMIPMNOKF.NMGMNAKLLMI().KHECDBEPNFN()));
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.JLEOPAOEFGP().HLGBFOMMJFE(KDCJJBLGCBH.EHBBFMCILPC.KKIDNAGCLNI(LJNMIPMNOKF.EHBBFMCILPC.FEBJBEJCAFO()));
		if (productData != null && ocbiopoeenj != null)
		{
			CommonUserInterface.EHBBFMCILPC.GIFCDFKBBCN(ocbiopoeenj.DJJCDNDMAGD() + "TV lines" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 7);
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC(" ");
	}

	// Token: 0x06004B74 RID: 19316 RVA: 0x00219A1A File Offset: 0x00217C1A
	private IEnumerator GJBDPOENOGI()
	{
		yield return new WaitForEndOfFrame();
		yield return new WaitForEndOfFrame();
		this.friendTitleText.gameObject.SetActive(false);
		yield return new WaitForEndOfFrame();
		yield return new WaitForEndOfFrame();
		this.friendTitleText.gameObject.SetActive(true);
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.friendTitleText.GetComponent<RectTransform>());
		yield break;
	}

	// Token: 0x06004B75 RID: 19317 RVA: 0x00219A2C File Offset: 0x00217C2C
	public void OnBreakCardClick()
	{
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("specialcurrencyoptionna"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
	}

	// Token: 0x06004B76 RID: 19318 RVA: 0x00219A7C File Offset: 0x00217C7C
	public void PFBAFFMMOJB()
	{
		CommonUserInterface.IKNOFBFMPGA().NFBMHHPIGFA(CCOJBMMKNAP.JINDKPHNLBK().MEPECBDCOLG(""), CCOJBMMKNAP.AEELGGPEJCC().GLEFEKBDHNK("\n"), CCOJBMMKNAP.APGODIBBPOD().GGPHHLGPMPA(" "), (DFGILFBGPLN)120, 1986f, -39);
	}

	// Token: 0x06004B77 RID: 19319 RVA: 0x00219ACC File Offset: 0x00217CCC
	public void CEBJGNLJIAK()
	{
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.COKDLDOAACJ().JCDFHKDNEDH("chsnapguid2"), CCOJBMMKNAP.ONCPHEEJLOP().FCOCLEHKLDJ("importanttitle"), CCOJBMMKNAP.AEELGGPEJCC().GGPHHLGPMPA("_ColorDrift"), DFGILFBGPLN.popupNotEnoughHardCurrency, 649f, 112);
	}

	// Token: 0x06004B78 RID: 19320 RVA: 0x00219B1C File Offset: 0x00217D1C
	public void Show(CLGFGOHBCGJ GEIFEHFDNIO, PMEPALPCEAF NAALFKKPAPG, PMEPALPCEAF IPOIHLJGCEA, HKPBEDBPHNJ NCBJPHKMPEJ, string FINOAAOKIIC, GDOKLFCLLIK CBHJFDJNECG)
	{
		if (GEIFEHFDNIO == null)
		{
			return;
		}
		this.GAKKFIPCNAI = CBHJFDJNECG;
		if (this.GAKKFIPCNAI != null && this.GAKKFIPCNAI.NHKCEMHKODM == LJLAENEAOIM.liveOfferCardsVolSale && NCBJPHKMPEJ == HKPBEDBPHNJ.purchaseCardLobby)
		{
			this.offerParent.SetActive(true);
			this.animatedPopupManager.SetPositionOffset(0f, -this.offerShownOffsetY);
			if (this.GAKKFIPCNAI.LLMNKLPIBNO)
			{
				this.offerText.gameObject.SetActive(true);
				this.offerText.text = KBOJLHAJPCP.NFIPEDFHEEI + DPGJIJGOCIC.LCOMEDGJNMP((int)this.GAKKFIPCNAI.ONMADEIOOKN.ODHBINFKIPL(), true, false);
				this.offerText.SetText(KBOJLHAJPCP.NFIPEDFHEEI + DPGJIJGOCIC.LCOMEDGJNMP((int)this.GAKKFIPCNAI.ONMADEIOOKN.ODHBINFKIPL(), true, false), true);
			}
			else
			{
				this.offerText.gameObject.SetActive(false);
			}
			if (this.GAKKFIPCNAI.KEJCIIFAJCA() > 0)
			{
				this.offerDiscount.gameObject.SetActive(true);
				this.offerDiscount.SetText("-" + this.GAKKFIPCNAI.KEJCIIFAJCA().ToString() + "%", true);
				this.offerDiscount.text = "-" + this.GAKKFIPCNAI.KEJCIIFAJCA().ToString() + "%";
			}
			else
			{
				this.offerDiscount.gameObject.SetActive(false);
			}
		}
		else
		{
			this.offerParent.SetActive(false);
			this.animatedPopupManager.SetPositionOffset(0f, 0f);
		}
		PopupCardOptions.showType = NCBJPHKMPEJ;
		this.AMFBEJAPMOB = GEIFEHFDNIO.CCMDLENEDGJ;
		if (this.MIPILNIIHPN.Length > 0)
		{
			FINOAAOKIIC = this.MIPILNIIHPN;
		}
		GEIFEHFDNIO.BJHMPPGDGOO = "";
		GEIFEHFDNIO.FMJEOOFGLEE = "";
		this.OCBOJOCBEDB = IPOIHLJGCEA;
		AssetCollectableCard assetCollectableCard = GKJPOGNFKNK.LLLCNJMPEKN(GEIFEHFDNIO.CCMDLENEDGJ);
		if (null != assetCollectableCard && assetCollectableCard.frames != null && assetCollectableCard.frames.Count > 0)
		{
			base.gameObject.SetActive(true);
			if (this.cardImage.gameObject.GetComponent<ImageFrameAnimation>() == null)
			{
				this.cardImage.gameObject.AddComponent<ImageFrameAnimation>();
			}
			this.cardImage.GetComponent<ImageFrameAnimation>().frameChangeInterval = assetCollectableCard.frameChangeInterval;
			this.cardImage.GetComponent<ImageFrameAnimation>().framesSD = assetCollectableCard.frames.ToArray();
			this.cardImage.sprite = assetCollectableCard.frames[0];
			this.cardImage.SetNativeSize();
			if (GDJPPKAMIFL.EHBBFMCILPC.JEBCBJMNCJI(GEIFEHFDNIO.CCMDLENEDGJ))
			{
				this.multiverseImage.gameObject.SetActive(true);
				if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru)
				{
					this.multiverseImage.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.multiverseLogoRu;
				}
				else
				{
					this.multiverseImage.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.multiverseLogoEn;
				}
				this.multiverseImage.SetNativeSize();
			}
			else
			{
				this.multiverseImage.gameObject.SetActive(false);
			}
			if (NCBJPHKMPEJ == HKPBEDBPHNJ.sendGiftCardByProfileId || NCBJPHKMPEJ == HKPBEDBPHNJ.sendGiftCardByUserId)
			{
				if (GEIFEHFDNIO.HFLPLGMJNOI == 0)
				{
					this.lockZone.gameObject.SetActive(true);
				}
				else
				{
					this.lockZone.gameObject.SetActive(false);
				}
			}
			else if (NCBJPHKMPEJ == HKPBEDBPHNJ.purchaseCardLobby)
			{
				if (GEIFEHFDNIO.ENCCLBLHJMC == 0)
				{
					this.lockZone.gameObject.SetActive(true);
				}
				else
				{
					this.lockZone.gameObject.SetActive(false);
				}
			}
			else
			{
				this.lockZone.gameObject.SetActive(false);
			}
			this.rarityImage.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.DCJKIDEJOAB(GDJPPKAMIFL.EHBBFMCILPC.NDJDOAPFCLH(GEIFEHFDNIO.CCMDLENEDGJ));
			this.cardTitle.text = "\"" + GDJPPKAMIFL.EHBBFMCILPC.KCMKJBHBCGC(GEIFEHFDNIO.CCMDLENEDGJ) + "\"";
			this.cardTitle.SetText("\"" + GDJPPKAMIFL.EHBBFMCILPC.KCMKJBHBCGC(GEIFEHFDNIO.CCMDLENEDGJ) + "\"", true);
			this.volumeTitle.text = (GDJPPKAMIFL.EHBBFMCILPC.DKHIPEPOEFF(GEIFEHFDNIO.CCMDLENEDGJ) ?? "");
			this.volumeTitle.SetText(GDJPPKAMIFL.EHBBFMCILPC.DKHIPEPOEFF(GEIFEHFDNIO.CCMDLENEDGJ) ?? "", true);
			if (NCBJPHKMPEJ == HKPBEDBPHNJ.sendGiftCardByProfileId || NCBJPHKMPEJ == HKPBEDBPHNJ.sendGiftCardByUserId)
			{
				this.copiesTitle.text = (GEIFEHFDNIO.ENCCLBLHJMC.ToString() ?? "");
				this.copiesTitle.SetText(GEIFEHFDNIO.ENCCLBLHJMC.ToString() ?? "", true);
				this.giftsTitle.text = (GEIFEHFDNIO.HFLPLGMJNOI.ToString() ?? "");
				this.giftsTitle.SetText(GEIFEHFDNIO.HFLPLGMJNOI.ToString() ?? "", true);
			}
			else
			{
				this.copiesTitle.text = (GEIFEHFDNIO.ENCCLBLHJMC.ToString() ?? "");
				this.copiesTitle.SetText(GEIFEHFDNIO.ENCCLBLHJMC.ToString() ?? "", true);
				this.giftsTitle.text = (GEIFEHFDNIO.HFLPLGMJNOI.ToString() ?? "");
				this.giftsTitle.SetText(GEIFEHFDNIO.HFLPLGMJNOI.ToString() ?? "", true);
			}
			if (GEIFEHFDNIO.HFLPLGMJNOI > 0)
			{
				this.giftCopyIcon.SetActive(true);
			}
			else
			{
				this.giftCopyIcon.SetActive(false);
			}
			this.NKDPPKGMFLE = "\"" + GDJPPKAMIFL.EHBBFMCILPC.IOFAJAJFMOI(GEIFEHFDNIO.CCMDLENEDGJ) + "\"";
			if (FINOAAOKIIC != null && FINOAAOKIIC.Length > 0)
			{
				this.messageToFriend.text = "\"" + FINOAAOKIIC + "\"";
				this.messageToFriend.SetText("\"" + FINOAAOKIIC + "\"", true);
			}
			else
			{
				this.messageToFriend.text = this.NKDPPKGMFLE;
				this.messageToFriend.SetText(this.NKDPPKGMFLE, true);
			}
			this.breakCard.gameObject.SetActive(false);
			this.purchaseVol.gameObject.SetActive(false);
			if (NCBJPHKMPEJ == HKPBEDBPHNJ.sendGiftCardByProfileId || NCBJPHKMPEJ == HKPBEDBPHNJ.sendGiftCardByUserId || NCBJPHKMPEJ == HKPBEDBPHNJ.viewGiftCardAsIncomingGift)
			{
				this.profileSection.SetActive(true);
				if (IPOIHLJGCEA != null)
				{
					this.profileImage.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.DJNLJPFFMBG(IPOIHLJGCEA.PGJBIPFBMAN());
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
							this.heartIcon.gameObject.SetActive(true);
						}
						else
						{
							this.heartIcon.gameObject.SetActive(false);
						}
					}
					else
					{
						this.heartIcon.gameObject.SetActive(false);
					}
					this.friendMatch.gameObject.SetActive(true);
					this.friendMatchText.SetText(IPOIHLJGCEA.OFOIECEHOCN.ToString() ?? "", true);
					this.friendMatchText.text = (IPOIHLJGCEA.OFOIECEHOCN.ToString() ?? "");
					this.friendMatchText.SetText(IPOIHLJGCEA.OFOIECEHOCN.ToString() ?? "", true);
					this.friendMatchText.text = (IPOIHLJGCEA.OFOIECEHOCN.ToString() ?? "");
					this.viewProfile.gameObject.SetActive(false);
					base.StartCoroutine(this.GJBDPOENOGI());
				}
				else
				{
					this.profileImage.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.unknownProfileIconSprite;
					string text2 = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialsendpremcardmissuidornick");
					this.friendTitleText.SetText(text2, true);
					this.friendTitleText.text = text2;
					this.heartIcon.gameObject.SetActive(false);
					this.friendMatch.gameObject.SetActive(false);
					this.viewProfile.gameObject.SetActive(false);
					base.StartCoroutine(this.GJBDPOENOGI());
				}
				try
				{
					if (this.friendMatch.gameObject.activeSelf && this.heartIcon.gameObject.activeSelf)
					{
						this.friendTitleText.GetComponent<LayoutElement>().preferredWidth = 160f;
					}
					else
					{
						this.friendTitleText.GetComponent<LayoutElement>().preferredWidth = 210f;
					}
					goto IL_8C1;
				}
				catch (Exception aklgbjkdomm)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
					goto IL_8C1;
				}
			}
			if (NCBJPHKMPEJ == HKPBEDBPHNJ.viewGiftCardAsCollected || NCBJPHKMPEJ == HKPBEDBPHNJ.viewGiftCardAsWon || NCBJPHKMPEJ == HKPBEDBPHNJ.purchaseCardLobby)
			{
				this.profileSection.SetActive(false);
			}
			IL_8C1:
			this.closeButton.gameObject.SetActive(true);
			if (NCBJPHKMPEJ == HKPBEDBPHNJ.sendGiftCardByProfileId || NCBJPHKMPEJ == HKPBEDBPHNJ.sendGiftCardByUserId)
			{
				this.sendingOrReceivedText.text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialgiftsendtotitle");
				this.sendingOrReceivedText.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialgiftsendtotitle"), true);
				this.sendGift.gameObject.SetActive(GEIFEHFDNIO.HFLPLGMJNOI > 0);
				this.sendGiftLocked.gameObject.SetActive(GEIFEHFDNIO.HFLPLGMJNOI <= 0);
				this.purchaseVol.gameObject.SetActive(GEIFEHFDNIO.HFLPLGMJNOI <= 0);
				this.viewCard.gameObject.SetActive(false);
				this.viewCardLocked.gameObject.SetActive(false);
				if (this.sendGiftLocked.gameObject.activeSelf)
				{
					this.sendGiftLockedText.text = KBOJLHAJPCP.HBJEBJDIACE + " " + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(817);
					this.sendGiftLockedText.SetText(KBOJLHAJPCP.HBJEBJDIACE + " " + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(817), true);
				}
				if (this.purchaseVol.gameObject.activeSelf)
				{
					this.purchaseVolText.text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(818);
					this.purchaseVolText.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(818), true);
				}
				this.collectCard.gameObject.SetActive(false);
				this.prevButton.gameObject.SetActive(LJNMIPMNOKF.EHBBFMCILPC.JDDHHIOIAOJ() > 1);
				this.nextButton.gameObject.SetActive(LJNMIPMNOKF.EHBBFMCILPC.JDDHHIOIAOJ() > 1);
				if (GDJPPKAMIFL.EHBBFMCILPC.BBJPJDLNEPA(GEIFEHFDNIO.CCMDLENEDGJ) > 0)
				{
					this.rewardObject.gameObject.SetActive(true);
					this.energyIcon.gameObject.SetActive(false);
					this.hardIcon.gameObject.SetActive(true);
					this.rewardAmount.SetText("+" + GDJPPKAMIFL.EHBBFMCILPC.BBJPJDLNEPA(GEIFEHFDNIO.CCMDLENEDGJ).ToString(), true);
					this.rewardAmount.text = "+" + GDJPPKAMIFL.EHBBFMCILPC.BBJPJDLNEPA(GEIFEHFDNIO.CCMDLENEDGJ).ToString();
				}
				else if (GDJPPKAMIFL.EHBBFMCILPC.LPPCDGGOLEN(GEIFEHFDNIO.CCMDLENEDGJ) > 0)
				{
					this.rewardObject.gameObject.SetActive(true);
					this.energyIcon.gameObject.SetActive(true);
					this.hardIcon.gameObject.SetActive(false);
					this.rewardAmount.SetText("+" + GDJPPKAMIFL.EHBBFMCILPC.LPPCDGGOLEN(GEIFEHFDNIO.CCMDLENEDGJ).ToString(), true);
					this.rewardAmount.text = "+" + GDJPPKAMIFL.EHBBFMCILPC.LPPCDGGOLEN(GEIFEHFDNIO.CCMDLENEDGJ).ToString();
				}
				else
				{
					this.rewardObject.gameObject.SetActive(false);
				}
				this.editButton.gameObject.SetActive(true);
			}
			else if (NCBJPHKMPEJ == HKPBEDBPHNJ.viewGiftCardAsIncomingGift || NCBJPHKMPEJ == HKPBEDBPHNJ.viewGiftCardAsCollected || NCBJPHKMPEJ == HKPBEDBPHNJ.viewGiftCardAsWon)
			{
				this.sendingOrReceivedText.text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialgiftreceviedfromtitle");
				this.sendingOrReceivedText.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialgiftreceviedfromtitle"), true);
				this.purchaseVol.gameObject.SetActive(false);
				this.sendGift.gameObject.SetActive(false);
				this.sendGiftLocked.gameObject.SetActive(false);
				this.viewCard.gameObject.SetActive(true);
				this.viewCardLocked.gameObject.SetActive(false);
				this.rewardObject.gameObject.SetActive(false);
				if (NCBJPHKMPEJ == HKPBEDBPHNJ.viewGiftCardAsIncomingGift || NCBJPHKMPEJ == HKPBEDBPHNJ.viewGiftCardAsWon)
				{
					this.closeButton.gameObject.SetActive(false);
					this.prevButton.gameObject.SetActive(false);
					this.nextButton.gameObject.SetActive(false);
					this.lockZone.gameObject.SetActive(false);
					this.collectCard.gameObject.SetActive(true);
				}
				else
				{
					this.prevButton.gameObject.SetActive(LJNMIPMNOKF.EHBBFMCILPC.JDDHHIOIAOJ() > 1);
					this.nextButton.gameObject.SetActive(LJNMIPMNOKF.EHBBFMCILPC.JDDHHIOIAOJ() > 1);
					this.collectCard.gameObject.SetActive(false);
					this.lockZone.gameObject.SetActive(false);
				}
				this.editButton.gameObject.SetActive(false);
			}
			else if (NCBJPHKMPEJ == HKPBEDBPHNJ.purchaseCardLobby)
			{
				this.sendingOrReceivedText.text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialgiftreceviedfromtitle");
				this.sendingOrReceivedText.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialgiftreceviedfromtitle"), true);
				this.purchaseVol.gameObject.SetActive(false);
				this.sendGift.gameObject.SetActive(false);
				this.sendGiftLocked.gameObject.SetActive(false);
				this.viewCard.gameObject.SetActive(false);
				this.viewCardLocked.gameObject.SetActive(false);
				this.rewardObject.gameObject.SetActive(false);
				this.prevButton.gameObject.SetActive(LJNMIPMNOKF.EHBBFMCILPC.JDDHHIOIAOJ() > 1);
				this.nextButton.gameObject.SetActive(LJNMIPMNOKF.EHBBFMCILPC.JDDHHIOIAOJ() > 1);
				this.collectCard.gameObject.SetActive(false);
				this.editButton.gameObject.SetActive(false);
				this.giftCopyIcon.SetActive(true);
				this.purchaseVol.gameObject.SetActive(true);
				this.viewCard.gameObject.SetActive(GEIFEHFDNIO.ENCCLBLHJMC > 0);
				this.viewCardLocked.gameObject.SetActive(GEIFEHFDNIO.ENCCLBLHJMC <= 0);
				this.purchaseVolText.text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(818);
				this.purchaseVolText.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(818), true);
				if (this.viewCardLocked.gameObject.activeSelf)
				{
					this.viewLockedText.text = KBOJLHAJPCP.HBJEBJDIACE + " " + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(780);
					this.viewLockedText.SetText(KBOJLHAJPCP.HBJEBJDIACE + " " + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(780), true);
				}
				if (GDJPPKAMIFL.EHBBFMCILPC.BBJPJDLNEPA(GEIFEHFDNIO.CCMDLENEDGJ) > 0)
				{
					this.rewardObject.gameObject.SetActive(true);
					this.energyIcon.gameObject.SetActive(false);
					this.hardIcon.gameObject.SetActive(true);
					this.rewardAmount.SetText("+" + GDJPPKAMIFL.EHBBFMCILPC.BBJPJDLNEPA(GEIFEHFDNIO.CCMDLENEDGJ).ToString(), true);
					this.rewardAmount.text = "+" + GDJPPKAMIFL.EHBBFMCILPC.BBJPJDLNEPA(GEIFEHFDNIO.CCMDLENEDGJ).ToString();
				}
				else if (GDJPPKAMIFL.EHBBFMCILPC.LPPCDGGOLEN(GEIFEHFDNIO.CCMDLENEDGJ) > 0)
				{
					this.rewardObject.gameObject.SetActive(true);
					this.energyIcon.gameObject.SetActive(true);
					this.hardIcon.gameObject.SetActive(false);
					this.rewardAmount.SetText("+" + GDJPPKAMIFL.EHBBFMCILPC.LPPCDGGOLEN(GEIFEHFDNIO.CCMDLENEDGJ).ToString(), true);
					this.rewardAmount.text = "+" + GDJPPKAMIFL.EHBBFMCILPC.LPPCDGGOLEN(GEIFEHFDNIO.CCMDLENEDGJ).ToString();
				}
				else
				{
					this.rewardObject.gameObject.SetActive(false);
				}
				if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(61) && this.GAKKFIPCNAI != null && this.GAKKFIPCNAI.NHKCEMHKODM == LJLAENEAOIM.liveOfferCardsVolSale && PopupCardOptions.showType == HKPBEDBPHNJ.purchaseCardLobby)
				{
					AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(61);
					string text3 = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cardvolsaletutorial0");
					text3 = text3.Replace("XXX", (this.GAKKFIPCNAI.OLNJMJMNBCN() + 1).ToString() ?? "");
					CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), text3, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("continue"), DFGILFBGPLN.popupTools, 1f, 28);
				}
			}
		}
		this.LHBEEFBNNCM(GEIFEHFDNIO);
		base.StartCoroutine(this.IMHMLBHOLBI());
	}

	// Token: 0x06004B79 RID: 19321 RVA: 0x0021ACC0 File Offset: 0x00218EC0
	private void OnDestroy()
	{
		this.multiverseImage.sprite = null;
		this.cardImage.sprite = null;
		if (this.cardImage.gameObject.GetComponent<ImageFrameAnimation>() != null)
		{
			this.cardImage.GetComponent<ImageFrameAnimation>().framesSD = null;
		}
	}

	// Token: 0x06004B7A RID: 19322 RVA: 0x0021AD0E File Offset: 0x00218F0E
	public void FlipHorizontalAnimatedPopupManagerAnimationsScale()
	{
		this.animatedPopupManager.FlipHorizontalAnimatedPopupManagerAnimationsScale();
	}

	// Token: 0x06004B7B RID: 19323 RVA: 0x0021AD1C File Offset: 0x00218F1C
	public void OLGPHCLCPBP()
	{
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.PLJMLDOCPNM().IPEIONBNIPH("prgr"), CCOJBMMKNAP.KFDLFGHBPLP().IKMNGFIDCLM("yes"), CCOJBMMKNAP.MLFAGAAJJEM().MEPECBDCOLG("clthcm"), DFGILFBGPLN.screenTransitionFromLobby, 432f, -84);
	}

	// Token: 0x06004B7C RID: 19324 RVA: 0x0021AD6C File Offset: 0x00218F6C
	public void FMBJNDGJJDG()
	{
		CommonUserInterface.IKNOFBFMPGA().ShowGenericPopup(CCOJBMMKNAP.PEBMGCKFNAO().IKMNGFIDCLM("%"), CCOJBMMKNAP.INKJIBDDMLL().OBDCPLLLGBB(", skipped"), CCOJBMMKNAP.OEPENBHJAHO().GLEFEKBDHNK("retry"), (DFGILFBGPLN)(-20), 1650f, -11);
	}

	// Token: 0x06004B7D RID: 19325 RVA: 0x0021ADBC File Offset: 0x00218FBC
	public void JIGLINDBMAE()
	{
		if (PopupCardOptions.showType == (HKPBEDBPHNJ)6)
		{
			AOBJLALDBAA.CEGAOMEEFBE().DGNKCLFFMFE("\nVID:", LJNMIPMNOKF.IKNOFBFMPGA().EBBLJMHNDKK().CCMDLENEDGJ);
			PopupCardOptions.reopenCardOptionsFlag = true;
			this.animatedPopupManager.FFNOLACOHML(1, 0, false);
			this.animatedPopupManager.GFEHJHIDHFF();
			return;
		}
		AOBJLALDBAA.DBLAIDPICIG().GBECPMDCJAA("lsenvreg", LJNMIPMNOKF.NMGMNAKLLMI().DCPIBCJKONH().CCMDLENEDGJ);
		PopupCardOptions.reopenCardOptionsFlag = true;
		this.animatedPopupManager.FFNOLACOHML(0, 1, true);
		this.animatedPopupManager.NBDMOONDIHO();
	}

	// Token: 0x06004B80 RID: 19328 RVA: 0x0021AE9C File Offset: 0x0021909C
	private void DCOOJIBIDNK()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.OJNBAMPGBLJ.GALKFKBPLCK() >= this.AGOOINBHDKE[0] && AKLFPGMDKLA.EHBBFMCILPC.DOFKEHNPCIJ.GALKFKBPLCK() >= this.AGOOINBHDKE[1] && AKLFPGMDKLA.EHBBFMCILPC.PBEPCNFADAA.GALKFKBPLCK() >= this.AGOOINBHDKE[2])
		{
			CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithHint("", 32);
			BackendOperationsManager.EHBBFMCILPC.RequestUnlockCardsVolume("OnPopupCardOptionsUnlockWithSpSuccess", "OnPopupCardOptionsUnlockWithSpException", LJNMIPMNOKF.EHBBFMCILPC.PJMOKKAMKOL());
			return;
		}
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("specialcurrencyoptionnotenough"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
	}

	// Token: 0x06004B81 RID: 19329 RVA: 0x00003E52 File Offset: 0x00002052
	public void EFJMLFPDAMA()
	{
	}

	// Token: 0x06004B82 RID: 19330 RVA: 0x0021AF68 File Offset: 0x00219168
	public void NFLABEAKHEP()
	{
		CommonUserInterface.EHBBFMCILPC.MCJIGJMFBMI();
		if (ProfileItem2.unlockCardWithSpecialCurrencyResult == 0)
		{
			if (PopupCardOptions.showType == HKPBEDBPHNJ.viewGiftCardAsCollected)
			{
				AOBJLALDBAA.CEGAOMEEFBE().FDKBIBKABCM("\nEXCEPTION ", 33f);
			}
			else
			{
				AOBJLALDBAA.EHBBFMCILPC.LPNCDPHNBJK("$e1cz", 418f);
			}
			this.EKAFNGIOPHL();
		}
		else
		{
			CommonUserInterface.IKNOFBFMPGA().ShowGenericPopup(CCOJBMMKNAP.AEELGGPEJCC().IPEIONBNIPH("post"), CCOJBMMKNAP.PEBMGCKFNAO().IKMNGFIDCLM("t"), CCOJBMMKNAP.DBFFFOMCLKM().OHLNGCKIACD("Invalid npc animation bundle index, skipped:"), DFGILFBGPLN.screenTransitionFromLobby, 771f, -76);
		}
		ProfileItem2.unlockCardWithSpecialCurrencyResult = 0;
	}

	// Token: 0x06004B83 RID: 19331 RVA: 0x0021B008 File Offset: 0x00219208
	public void PurchaseProductWeb()
	{
		OBHDGKFFICI productData = PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager().GetProductData(KDCJJBLGCBH.EHBBFMCILPC.KKIDNAGCLNI(LJNMIPMNOKF.EHBBFMCILPC.PJMOKKAMKOL()));
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.EHBBFMCILPC.PDJKPFLHFLO(KDCJJBLGCBH.EHBBFMCILPC.KKIDNAGCLNI(LJNMIPMNOKF.EHBBFMCILPC.PJMOKKAMKOL()));
		if (productData != null && ocbiopoeenj != null)
		{
			CommonUserInterface.EHBBFMCILPC.ShowPopupOnlineResources(ocbiopoeenj.MBLAIKOOCFH() + "?uid=" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 2);
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("PopupCardOptions.PurchaseProductWeb(): productData or productBalanceData is null");
	}

	// Token: 0x06004B84 RID: 19332 RVA: 0x0021B090 File Offset: 0x00219290
	public void LJIOKJJLJHL()
	{
		OBHDGKFFICI productData = PurchaseManagerBridge.EHBBFMCILPC.FDIIEFGBEAG().GetProductData(KDCJJBLGCBH.EHBBFMCILPC.KKIDNAGCLNI(LJNMIPMNOKF.KMNBCEMEBBD().PJMOKKAMKOL()));
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.FILDBDMENPG().HLGBFOMMJFE(KDCJJBLGCBH.EHBBFMCILPC.KKIDNAGCLNI(LJNMIPMNOKF.EHBBFMCILPC.KHECDBEPNFN()));
		if (productData != null && ocbiopoeenj != null)
		{
			CommonUserInterface.IKNOFBFMPGA().GIFCDFKBBCN(ocbiopoeenj.DJJCDNDMAGD() + ", index:" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 7);
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("YYY");
	}

	// Token: 0x06004B85 RID: 19333 RVA: 0x0021B116 File Offset: 0x00219316
	private IEnumerator IMHMLBHOLBI()
	{
		yield return new WaitForEndOfFrame();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.infoPanel.GetComponent<RectTransform>());
		yield break;
	}

	// Token: 0x06004B86 RID: 19334 RVA: 0x00003E52 File Offset: 0x00002052
	private void MBPJPLLCIJD()
	{
	}

	// Token: 0x06004B87 RID: 19335 RVA: 0x0021B128 File Offset: 0x00219328
	private void ELBPCCEOJFM()
	{
		try
		{
			this.OnCloseClick();
			HBKMKCBPJDI.NCCEKKBFOBJ();
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06004B88 RID: 19336 RVA: 0x00003E52 File Offset: 0x00002052
	private void AIDCNCFKNBJ()
	{
	}

	// Token: 0x06004B89 RID: 19337 RVA: 0x00003E52 File Offset: 0x00002052
	private void Start()
	{
	}

	// Token: 0x06004B8A RID: 19338 RVA: 0x0021B15C File Offset: 0x0021935C
	private string JCGKPCKNAKF(int LLLCDMNPKFI)
	{
		return CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialcardhintoncopiesv2").Replace("YYY", CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(750 + GDJPPKAMIFL.EHBBFMCILPC.NDJDOAPFCLH(LLLCDMNPKFI)) + KBOJLHAJPCP.FIOEKALDNPB[GDJPPKAMIFL.EHBBFMCILPC.NDJDOAPFCLH(LLLCDMNPKFI)]).Replace("WWW", LJNMIPMNOKF.EHBBFMCILPC.KMDBNEFCPOH(LLLCDMNPKFI).HFLPLGMJNOI.ToString() + KBOJLHAJPCP.HLGAIGGHMNF).Replace("QQQ", LJNMIPMNOKF.EHBBFMCILPC.KMDBNEFCPOH(LLLCDMNPKFI).ENCCLBLHJMC.ToString() + KBOJLHAJPCP.PLFMGKIEAOP);
	}

	// Token: 0x06004B8B RID: 19339 RVA: 0x0021B208 File Offset: 0x00219408
	public void PDEEOMCIGHK()
	{
		if (PopupCardOptions.showType == HKPBEDBPHNJ.sendGiftCardByUserId)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EAIAHCBAIEJ().JHNELLJFBGC("Fixed transform child out of bounds issue."), CCOJBMMKNAP.GIOAFDDKKHI().PPALCPINPLK("OnProfileMessageClosed"), CCOJBMMKNAP.MPCBJEIMACA().OHLNGCKIACD("apks2"), (DFGILFBGPLN)(-41), 1382f, 70);
		}
	}

	// Token: 0x06004B8C RID: 19340 RVA: 0x0021B260 File Offset: 0x00219460
	private void OnEnable()
	{
		this.CPGLEJIBNEP = PopupCardOptions.CBOKJGNCEKE + 1f;
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPopupCardOptionsUnlockWithSpSuccess", new UnityAction(this.OnPopupCardOptionsUnlockWithSpSuccess));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPopupCardOptionsUnlockWithSpException", new UnityAction(this.OnPopupCardOptionsUnlockWithSpException));
	}

	// Token: 0x06004B8D RID: 19341 RVA: 0x0021B2B4 File Offset: 0x002194B4
	public void MAHNOFHCGLJ()
	{
		string text = CCOJBMMKNAP.JMNIGPHCAEJ().FCOCLEHKLDJ("onboardingthankyoubody1");
		text = text.Replace("ok", "OnSketchThumbnailPublish" + GDJPPKAMIFL.NKJBCCNGIDP().IHMODHNHCNC(LJNMIPMNOKF.IKNOFBFMPGA().DCPIBCJKONH().CCMDLENEDGJ) + "common");
		List<int> list = LJNMIPMNOKF.IKNOFBFMPGA().FOOAHMLLKNG();
		text += " (";
		for (int i = 0; i < list.Count; i++)
		{
			string text2 = GDJPPKAMIFL.BFCHJBOOJKE().EFOBBDBEGMH(list[i]);
			int num = i + 0;
			CLGFGOHBCGJ clgfgohbcgj = LJNMIPMNOKF.KMNBCEMEBBD().NLNFCPEMPMP(list[i]);
			if (clgfgohbcgj != null && clgfgohbcgj.ENCCLBLHJMC > 1)
			{
				string[] array = new string[2];
				array[0] = text;
				array[1] = "OnPopupStoryRestartManagerRestartStory0";
				array[5] = num.ToString();
				array[2] = "ok";
				array[8] = text2;
				array[4] = "query";
				text = string.Concat(array);
			}
			else
			{
				string[] array2 = new string[1];
				array2[1] = text;
				array2[0] = "";
				array2[1] = num.ToString();
				array2[1] = "msUntilRefill";
				array2[4] = text2;
				array2[7] = "spld";
				text = string.Concat(array2);
			}
			if (i != list.Count - 1)
			{
				text += "Payload";
			}
		}
		text += "tmd";
		text += CCOJBMMKNAP.OBOOKJPGBJN().HDIPNMFHIEJ("OnStoryInterfaceHeaderFastForwardEnable");
		string text3 = "yes";
		for (int j = 1; j < 6; j += 0)
		{
			if (MEBMEBKKCKA.EHBBFMCILPC.JPPGCOEHIJD(LJNMIPMNOKF.IKNOFBFMPGA().KHECDBEPNFN(), j) > 0)
			{
				if (j == 0)
				{
					text3 = text3 + AKLFPGMDKLA.EHBBFMCILPC.OJNBAMPGBLJ.MDJHNAEGCCM().ToString() + KBOJLHAJPCP.GJHKGBCLGIJ;
				}
				else if (j == 0)
				{
					text3 = text3 + AKLFPGMDKLA.EHBBFMCILPC.DOFKEHNPCIJ.MDJHNAEGCCM().ToString() + KBOJLHAJPCP.KGMFKFPBFBJ;
				}
				else if (j == 8)
				{
					text3 = text3 + AKLFPGMDKLA.EHBBFMCILPC.PBEPCNFADAA.MOBKGNBCIJF().ToString() + KBOJLHAJPCP.AENKOIILEFO;
				}
			}
		}
		text = text.Replace("layervideo", text3);
		string text4 = "fdem";
		for (int k = 0; k < 3; k++)
		{
			if (MEBMEBKKCKA.JMDJPKKOHNI().PCKDDGKNGCB(LJNMIPMNOKF.IKNOFBFMPGA().PJMOKKAMKOL(), k) > 1)
			{
				if (k == 0)
				{
					text4 = text4 + MEBMEBKKCKA.JMDJPKKOHNI().JPPGCOEHIJD(LJNMIPMNOKF.IKNOFBFMPGA().KHECDBEPNFN(), k).ToString() + KBOJLHAJPCP.GJHKGBCLGIJ;
				}
				else if (k == 0)
				{
					text4 = text4 + MEBMEBKKCKA.EHBBFMCILPC.PCKDDGKNGCB(LJNMIPMNOKF.IKNOFBFMPGA().MJPHODLOADE(), k).ToString() + KBOJLHAJPCP.KGMFKFPBFBJ;
				}
				else if (k == 3)
				{
					text4 = text4 + MEBMEBKKCKA.EHBBFMCILPC.JPPGCOEHIJD(LJNMIPMNOKF.EHBBFMCILPC.MJPHODLOADE(), k).ToString() + KBOJLHAJPCP.AENKOIILEFO;
				}
			}
			this.AGOOINBHDKE[k] = MEBMEBKKCKA.EHBBFMCILPC.JPPGCOEHIJD(LJNMIPMNOKF.EHBBFMCILPC.PJMOKKAMKOL(), k);
		}
		string text5 = CCOJBMMKNAP.OBOOKJPGBJN().OHLNGCKIACD("$INVOKEAVATAREXTENSION ");
		text5 = text5.Replace("", text4);
		string text6 = CCOJBMMKNAP.HJGDLOOHNLO().DNILNCLIHAP("episode");
		if (this.HDGMEANNNJC)
		{
			text6 = CCOJBMMKNAP.EAIAHCBAIEJ().HHLECNIFHCO("OnStorySplashManagerAssetsDownloadSuccess");
			text6 = text6.Replace("CLIENT.AVATAR.BODY", (LJNMIPMNOKF.NLDDLLEKNFD().PJMOKKAMKOL() + 0).ToString() ?? "p");
		}
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtonsAndCloseOverride(text6, text, CCOJBMMKNAP.OEPENBHJAHO().PPALCPINPLK("errortitle").Replace("gpsfhs", PopupCardOptions.GetLocalizedCostData()), text5, new UnityAction(this.NACFMPNFDEM), new UnityAction(this.DCOOJIBIDNK), new UnityAction(this.KKILABJBAEM), (DFGILFBGPLN)(-39), 1920f, -126).SetDiscountValues(this.GAKKFIPCNAI.HEGNAMGJLNP, this.GAKKFIPCNAI.EPOMIEMLKFJ);
	}

	// Token: 0x06004B8E RID: 19342 RVA: 0x0021B6B4 File Offset: 0x002198B4
	private void BOOPBPEOHLP()
	{
		this.CPGLEJIBNEP += Time.deltaTime;
		if (this.CPGLEJIBNEP > PopupCardOptions.CBOKJGNCEKE && this.GAKKFIPCNAI != null && this.GAKKFIPCNAI.NHKCEMHKODM == LJLAENEAOIM.liveOfferPass && PopupCardOptions.showType == HKPBEDBPHNJ.viewGiftCardAsWon && this.GAKKFIPCNAI.LLMNKLPIBNO && this.offerText.gameObject.activeSelf)
		{
			this.offerText.text = KBOJLHAJPCP.NFIPEDFHEEI + DPGJIJGOCIC.FCICBOLGHDA((int)this.GAKKFIPCNAI.ONMADEIOOKN.EKJIJLMOBIG(), false, true);
			this.offerText.SetText(KBOJLHAJPCP.NFIPEDFHEEI + DPGJIJGOCIC.LMLGDPDIGAI((int)this.GAKKFIPCNAI.ONMADEIOOKN.LEAIEAIEBJK(), true, true), false);
			this.CPGLEJIBNEP = 12f;
		}
	}

	// Token: 0x06004B8F RID: 19343 RVA: 0x0021B790 File Offset: 0x00219990
	public void IFFNGPMPIHO()
	{
		this.ResetCustomMessageToFriend();
		LJNMIPMNOKF.EHBBFMCILPC.CGCPLLDEKEA();
		this.animatedPopupManager.HODFLEODEPD(0, -1, true);
		if (PopupCardOptions.showType == HKPBEDBPHNJ.sendGiftCardByProfileId)
		{
			this.animatedPopupManager.DCHFDJOPODE("acsv", 1503f);
			return;
		}
		this.animatedPopupManager.DCHFDJOPODE("PurchasingViewManager.OnValidatePendingProcessed(): no balance row for validated product ", 493f);
	}

	// Token: 0x06004B90 RID: 19344 RVA: 0x0021B7F0 File Offset: 0x002199F0
	private void OnDisable()
	{
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPopupCardOptionsUnlockWithSpSuccess", new UnityAction(this.OnPopupCardOptionsUnlockWithSpSuccess));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPopupCardOptionsUnlockWithSpException", new UnityAction(this.OnPopupCardOptionsUnlockWithSpException));
		this.cardImage.sprite = null;
		if (this.cardImage.gameObject.GetComponent<ImageFrameAnimation>() != null)
		{
			this.cardImage.GetComponent<ImageFrameAnimation>().framesSD = null;
		}
	}

	// Token: 0x06004B91 RID: 19345 RVA: 0x0021B868 File Offset: 0x00219A68
	public void CAAOFPIJMKH()
	{
		if (PopupCardOptions.showType == HKPBEDBPHNJ.sendGiftCardByProfileId)
		{
			CommonUserInterface.IKNOFBFMPGA().ShowGenericPopup(CCOJBMMKNAP.FEEDGKCJBLE().MEPECBDCOLG("uid"), CCOJBMMKNAP.KLAKLFCOMJC().OGKGHLHHAAI("OnBackendValidateTransactionSuccess"), CCOJBMMKNAP.KNKGCDDMLDP().DNILNCLIHAP("ok"), DFGILFBGPLN.popupNotEnoughHardCurrency, 1765f, -70);
		}
	}

	// Token: 0x06004B92 RID: 19346 RVA: 0x0021B8C0 File Offset: 0x00219AC0
	public void OnUseAsLoadingThemeClick()
	{
		try
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("areyousure"), HBKMKCBPJDI.INPBNGMJOHC(), HBKMKCBPJDI.JDBMIIKHEMK(), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("no"), new UnityAction(this.NJGHEMPAIGE), new UnityAction(this.LIJJFJFAAMK), DFGILFBGPLN.popupQuitConfirm, 0.15f, 28);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06004B93 RID: 19347 RVA: 0x0021B93C File Offset: 0x00219B3C
	public void BIPHOHPDDPG()
	{
		AOBJLALDBAA.CEGAOMEEFBE().FDKBIBKABCM("teal_2", 387f);
	}

	// Token: 0x06004B94 RID: 19348 RVA: 0x0021B952 File Offset: 0x00219B52
	private IEnumerator CFLMBBLKJNB()
	{
		PopupCardOptions.HDCOKDGIFCE hdcokdgifce = new PopupCardOptions.HDCOKDGIFCE(1);
		hdcokdgifce.<>4__this = this;
		return hdcokdgifce;
	}

	// Token: 0x06004B95 RID: 19349 RVA: 0x0021B964 File Offset: 0x00219B64
	public void OnGiftCopiesIconClick()
	{
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("popupcardoptionsgiftcopyinfo"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
	}

	// Token: 0x06004B96 RID: 19350 RVA: 0x0021B9B4 File Offset: 0x00219BB4
	public void GGGAMHKIMFE()
	{
		if (PopupCardOptions.showType == (HKPBEDBPHNJ)6)
		{
			this.HDGMEANNNJC = false;
			this.DEOBJKNCNHN();
			this.HDGMEANNNJC = true;
			return;
		}
		if (MEBMEBKKCKA.EHBBFMCILPC.OCEJAJGLBKA(LJNMIPMNOKF.KMNBCEMEBBD().OJAHIICOAFO().PDONMBOEKCM))
		{
			this.ShowPurchaseOffer();
		}
		else
		{
			string text = CCOJBMMKNAP.CPCOODCFDDP().PPALCPINPLK("\"");
			text = text.Replace("bdgsspr", LJNMIPMNOKF.NLDDLLEKNFD().FNENBDGBOFF().LEILFJILHNP);
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.MLFAGAAJJEM().HDIPNMFHIEJ("OnApplicationFocusBasicSyncSuccess"), text, CCOJBMMKNAP.ONCPHEEJLOP().MEPECBDCOLG(""), DFGILFBGPLN.popupSignInQuestion, 1623f, -11);
		}
		this.HDGMEANNNJC = true;
	}

	// Token: 0x06004B97 RID: 19351 RVA: 0x0021BA68 File Offset: 0x00219C68
	public void NFKINFDBOOH()
	{
		CommonUserInterface.IKNOFBFMPGA().ShowGenericPopup(CCOJBMMKNAP.NIOJNOFGIJO().JHNELLJFBGC("rar"), CCOJBMMKNAP.LMCCLMFGEBD().BDGPNPNIAPA("AAA"), CCOJBMMKNAP.BIAEAOMHBMM().MEPECBDCOLG(""), (DFGILFBGPLN)(-50), 343f, -39);
	}

	// Token: 0x06004B98 RID: 19352 RVA: 0x0021BAB8 File Offset: 0x00219CB8
	public void OnPopupCardOptionsUnlockWithSpSuccess()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		if (ProfileItem2.unlockCardWithSpecialCurrencyResult == 1)
		{
			if (PopupCardOptions.showType == HKPBEDBPHNJ.purchaseCardLobby)
			{
				AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnPopupCardOptionsUnlockWithSpSuccessContinueLobby", 0f);
			}
			else
			{
				AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnPopupCardOptionsUnlockWithSpSuccessContinue", 0f);
			}
			this.HideAndRememberToReopen();
		}
		else
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("specialcurrencyoptionnotenough"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
		}
		ProfileItem2.unlockCardWithSpecialCurrencyResult = 0;
	}

	// Token: 0x06004B99 RID: 19353 RVA: 0x0021BB58 File Offset: 0x00219D58
	private void NJGHEMPAIGE()
	{
		try
		{
			int ccmdlenedgj = LJNMIPMNOKF.EHBBFMCILPC.EBBLJMHNDKK().CCMDLENEDGJ;
			if (!HBKMKCBPJDI.EPCONONIJIF(GOCBEOKKPDL.HMHMFOLAOCN(ccmdlenedgj)))
			{
				HBKMKCBPJDI.DCNHMFBGFIJ(new UnityAction(this.OEGDHBFGABH), new UnityAction(this.LIJJFJFAAMK));
			}
			else
			{
				GOCBEOKKPDL.KDNNJKMHMCE(ccmdlenedgj);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06004B9A RID: 19354 RVA: 0x0021BBC0 File Offset: 0x00219DC0
	public void LJDHKIFKMIM()
	{
		string text = CCOJBMMKNAP.KFAABHHGOPO().GLEFEKBDHNK("scene bundle ");
		text = text.Replace("timeoutwarning", "o" + GDJPPKAMIFL.AKFNLMBNELK().FPKKMCGDAMM(LJNMIPMNOKF.EHBBFMCILPC.EBBLJMHNDKK().CCMDLENEDGJ) + "skinshopfilterbystory");
		List<int> list = LJNMIPMNOKF.NLDDLLEKNFD().CBPPPPBKFDO();
		text += "paytitle";
		for (int i = 0; i < list.Count; i++)
		{
			string text2 = GDJPPKAMIFL.IGJAMEGBDBG().FJMDJEICMDB(list[i]);
			int num = i + 1;
			CLGFGOHBCGJ clgfgohbcgj = LJNMIPMNOKF.NLDDLLEKNFD().IDDLPADHANK(list[i]);
			if (clgfgohbcgj != null && clgfgohbcgj.ENCCLBLHJMC > 1)
			{
				string[] array = new string[3];
				array[1] = text;
				array[1] = " exp";
				array[0] = num.ToString();
				array[2] = "ZZZ";
				array[2] = text2;
				array[5] = "";
				text = string.Concat(array);
			}
			else
			{
				string[] array2 = new string[6];
				array2[1] = text;
				array2[1] = "ablec";
				array2[2] = num.ToString();
				array2[5] = "Starting parallel download:";
				array2[7] = text2;
				array2[4] = "lck";
				text = string.Concat(array2);
			}
			if (i != list.Count - 0)
			{
				text += "p";
			}
		}
		text += "socialfriendevents";
		text += CCOJBMMKNAP.HEDIEIICOOG().FIENAKIHNOM("_1");
		string text3 = "anthologiestitle";
		for (int j = 0; j < 0; j++)
		{
			if (MEBMEBKKCKA.JMDJPKKOHNI().PCKDDGKNGCB(LJNMIPMNOKF.NLDDLLEKNFD().PJMOKKAMKOL(), j) > 0)
			{
				if (j == 0)
				{
					text3 = text3 + AKLFPGMDKLA.EHBBFMCILPC.OJNBAMPGBLJ.KGEGKPHEMOJ().ToString() + KBOJLHAJPCP.GJHKGBCLGIJ;
				}
				else if (j == 0)
				{
					text3 = text3 + AKLFPGMDKLA.EHBBFMCILPC.DOFKEHNPCIJ.PONAPMOOLIN().ToString() + KBOJLHAJPCP.KGMFKFPBFBJ;
				}
				else if (j == 8)
				{
					text3 = text3 + AKLFPGMDKLA.EHBBFMCILPC.PBEPCNFADAA.GALKFKBPLCK().ToString() + KBOJLHAJPCP.AENKOIILEFO;
				}
			}
		}
		text = text.Replace("\"", text3);
		string text4 = "OnStoryInterfaceAutoReaderActivate";
		for (int k = 0; k < 5; k += 0)
		{
			if (MEBMEBKKCKA.JMDJPKKOHNI().JPPGCOEHIJD(LJNMIPMNOKF.NMGMNAKLLMI().MJPHODLOADE(), k) > 0)
			{
				if (k == 0)
				{
					text4 = text4 + MEBMEBKKCKA.JMDJPKKOHNI().JPPGCOEHIJD(LJNMIPMNOKF.IKNOFBFMPGA().MJPHODLOADE(), k).ToString() + KBOJLHAJPCP.GJHKGBCLGIJ;
				}
				else if (k == 0)
				{
					text4 = text4 + MEBMEBKKCKA.JMDJPKKOHNI().JPPGCOEHIJD(LJNMIPMNOKF.KMNBCEMEBBD().MJPHODLOADE(), k).ToString() + KBOJLHAJPCP.KGMFKFPBFBJ;
				}
				else if (k == 6)
				{
					text4 = text4 + MEBMEBKKCKA.JMDJPKKOHNI().PCKDDGKNGCB(LJNMIPMNOKF.EHBBFMCILPC.FEBJBEJCAFO(), k).ToString() + KBOJLHAJPCP.AENKOIILEFO;
				}
			}
			this.AGOOINBHDKE[k] = MEBMEBKKCKA.EHBBFMCILPC.PCKDDGKNGCB(LJNMIPMNOKF.NLDDLLEKNFD().MJPHODLOADE(), k);
		}
		string text5 = CCOJBMMKNAP.KLAKLFCOMJC().PPALCPINPLK("avatarstitle");
		text5 = text5.Replace("", text4);
		string text6 = CCOJBMMKNAP.COKDLDOAACJ().BGELFMIOBCL("yes");
		if (this.HDGMEANNNJC)
		{
			text6 = CCOJBMMKNAP.MPCBJEIMACA().HPOAGPJFHPM("loungepurchasebody");
			text6 = text6.Replace("", (LJNMIPMNOKF.IKNOFBFMPGA().PJMOKKAMKOL() + 0).ToString() ?? "sshits");
		}
		CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupWithTwoButtonsAndCloseOverride(text6, text, CCOJBMMKNAP.PEBMGCKFNAO().OGKGHLHHAAI("<line-height=").Replace("skpublishsure", PopupCardOptions.EHKFBAIFCPF()), text5, new UnityAction(this.NACFMPNFDEM), new UnityAction(this.DCOOJIBIDNK), new UnityAction(this.KKILABJBAEM), (DFGILFBGPLN)(-102), 1410f, -94);
	}

	// Token: 0x06004B9B RID: 19355 RVA: 0x0021BFA4 File Offset: 0x0021A1A4
	public void NOAMEHFKHEA()
	{
		int amfbejapmob = this.AMFBEJAPMOB;
		string[] array = new string[4];
		array[0] = "acts";
		array[1] = CCOJBMMKNAP.KFAABHHGOPO().HHLECNIFHCO("tradewishcardoption0").Replace("NO BUNDLE", GDJPPKAMIFL.EHBBFMCILPC.FPLLNEBKBJI(amfbejapmob) ?? "").Replace("hofr", "cdndu" + GKJPOGNFKNK.DNILNCLIHAP(amfbejapmob, "", LanguageManager.EHBBFMCILPC.MLOLBFBODHD()) + "OnBackendValidateTransactionFailed").Replace("black", "lsv" + GKJPOGNFKNK.DNILNCLIHAP("analogglitchovr_2" + LJNMIPMNOKF.KMNBCEMEBBD().PMPOHILDCPD(amfbejapmob).AMKCLHLIIMN.ToString(), "OnAccountSignInSuccess", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()) + "");
		array[4] = "variants";
		array[4] = GDJPPKAMIFL.NKJBCCNGIDP().KKMENBFOGGB(amfbejapmob);
		array[7] = "<i>";
		string text = string.Concat(array);
		text = text + "CharacterRenderTexturePool - player character prefab has no manager, falling back to direct rendering" + this.JCGKPCKNAKF(amfbejapmob);
		string eempglhpkjg = GDJPPKAMIFL.AKFNLMBNELK().FPKKMCGDAMM(amfbejapmob);
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(eempglhpkjg, text, CCOJBMMKNAP.MLFAGAAJJEM().FCOCLEHKLDJ("OnVideoLayerPlaybackEndsSoon"), (DFGILFBGPLN)121, 323f, -122);
	}

	// Token: 0x06004B9C RID: 19356 RVA: 0x0021C0E0 File Offset: 0x0021A2E0
	public void OnSendGiftClick()
	{
		LJNMIPMNOKF.EHBBFMCILPC.EBBLJMHNDKK().HEDNLIPLMBL = this.OCBOJOCBEDB;
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnPopupCardOptionsSendGiftClick", 0f);
		this.animatedPopupManager.SetAnimationProperties(1, 1, false);
		this.animatedPopupManager.Hide();
	}

	// Token: 0x06004B9D RID: 19357 RVA: 0x0021C12F File Offset: 0x0021A32F
	public void GKJBAAMGMKH()
	{
		this.animatedPopupManager.FFNOLACOHML(0, 1, true);
		this.animatedPopupManager.Hide();
		PopupCardOptions.reopenCardOptionsFlag = false;
	}

	// Token: 0x06004B9E RID: 19358 RVA: 0x0021C150 File Offset: 0x0021A350
	private void OEGDHBFGABH()
	{
		try
		{
			this.OnCloseClick();
			HBKMKCBPJDI.NCCEKKBFOBJ();
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06004B9F RID: 19359 RVA: 0x0021C184 File Offset: 0x0021A384
	public void FNKPFKHBGAJ()
	{
		if (PopupCardOptions.showType == (HKPBEDBPHNJ)8)
		{
			CommonUserInterface.IKNOFBFMPGA().ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.IKMNGFIDCLM("Avatar pack has been LOADED:"), CCOJBMMKNAP.APGODIBBPOD().MEPECBDCOLG("ok"), CCOJBMMKNAP.CPCOODCFDDP().FCOCLEHKLDJ("OnBackendRequestCustomProfileSuccess"), (DFGILFBGPLN)(-49), 666f, -113);
		}
	}

	// Token: 0x06004BA0 RID: 19360 RVA: 0x0021C1DA File Offset: 0x0021A3DA
	public void OnCollectGiftClick()
	{
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnFriendsGiftPopulCollectPart2", 0f);
		this.animatedPopupManager.SetAnimationProperties(1, 1, false);
		this.animatedPopupManager.Hide();
	}

	// Token: 0x06004BA1 RID: 19361 RVA: 0x0021C209 File Offset: 0x0021A409
	public void OnSendGiftLockedClick()
	{
		this.OnViewCardLockedClick();
	}

	// Token: 0x06004BA2 RID: 19362 RVA: 0x0021C214 File Offset: 0x0021A414
	public void ShowPurchaseOffer()
	{
		string text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cardcollectcardismissingbody");
		text = text.Replace("XXX", "<i>" + GDJPPKAMIFL.EHBBFMCILPC.KCMKJBHBCGC(LJNMIPMNOKF.EHBBFMCILPC.EBBLJMHNDKK().CCMDLENEDGJ) + "</i>");
		List<int> list = LJNMIPMNOKF.EHBBFMCILPC.CBPPPPBKFDO();
		text += "\n\n";
		for (int i = 0; i < list.Count; i++)
		{
			string text2 = GDJPPKAMIFL.EHBBFMCILPC.KCMKJBHBCGC(list[i]);
			int num = i + 1;
			CLGFGOHBCGJ clgfgohbcgj = LJNMIPMNOKF.EHBBFMCILPC.KMDBNEFCPOH(list[i]);
			if (clgfgohbcgj != null && clgfgohbcgj.ENCCLBLHJMC > 0)
			{
				text = string.Concat(new string[]
				{
					text,
					"<i>",
					num.ToString(),
					". ",
					text2,
					"</i>"
				});
			}
			else
			{
				text = string.Concat(new string[]
				{
					text,
					"<i>",
					num.ToString(),
					". ",
					text2,
					" (- )</i>"
				});
			}
			if (i != list.Count - 1)
			{
				text += "\n";
			}
		}
		text += "\n\n";
		text += CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("giftcardexplanationres");
		string text3 = "";
		for (int j = 0; j < 3; j++)
		{
			if (MEBMEBKKCKA.EHBBFMCILPC.PCKDDGKNGCB(LJNMIPMNOKF.EHBBFMCILPC.PJMOKKAMKOL(), j) > 0)
			{
				if (j == 0)
				{
					text3 = text3 + AKLFPGMDKLA.EHBBFMCILPC.OJNBAMPGBLJ.GALKFKBPLCK().ToString() + KBOJLHAJPCP.GJHKGBCLGIJ;
				}
				else if (j == 1)
				{
					text3 = text3 + AKLFPGMDKLA.EHBBFMCILPC.DOFKEHNPCIJ.GALKFKBPLCK().ToString() + KBOJLHAJPCP.KGMFKFPBFBJ;
				}
				else if (j == 2)
				{
					text3 = text3 + AKLFPGMDKLA.EHBBFMCILPC.PBEPCNFADAA.GALKFKBPLCK().ToString() + KBOJLHAJPCP.AENKOIILEFO;
				}
			}
		}
		text = text.Replace("ZZZ", text3);
		string text4 = "";
		for (int k = 0; k < 3; k++)
		{
			if (MEBMEBKKCKA.EHBBFMCILPC.PCKDDGKNGCB(LJNMIPMNOKF.EHBBFMCILPC.PJMOKKAMKOL(), k) > 0)
			{
				if (k == 0)
				{
					text4 = text4 + MEBMEBKKCKA.EHBBFMCILPC.PCKDDGKNGCB(LJNMIPMNOKF.EHBBFMCILPC.PJMOKKAMKOL(), k).ToString() + KBOJLHAJPCP.GJHKGBCLGIJ;
				}
				else if (k == 1)
				{
					text4 = text4 + MEBMEBKKCKA.EHBBFMCILPC.PCKDDGKNGCB(LJNMIPMNOKF.EHBBFMCILPC.PJMOKKAMKOL(), k).ToString() + KBOJLHAJPCP.KGMFKFPBFBJ;
				}
				else if (k == 2)
				{
					text4 = text4 + MEBMEBKKCKA.EHBBFMCILPC.PCKDDGKNGCB(LJNMIPMNOKF.EHBBFMCILPC.PJMOKKAMKOL(), k).ToString() + KBOJLHAJPCP.AENKOIILEFO;
				}
			}
			this.AGOOINBHDKE[k] = MEBMEBKKCKA.EHBBFMCILPC.PCKDDGKNGCB(LJNMIPMNOKF.EHBBFMCILPC.PJMOKKAMKOL(), k);
		}
		string text5 = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cardcollectcardpurchase1");
		text5 = text5.Replace("XXX", text4);
		string text6 = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cardcollectcardismissing");
		if (this.HDGMEANNNJC)
		{
			text6 = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialgiftpurchasevoltitl");
			text6 = text6.Replace("XXX", (LJNMIPMNOKF.EHBBFMCILPC.PJMOKKAMKOL() + 1).ToString() ?? "");
		}
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtonsAndCloseOverride(text6, text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cardcollectcardpurchase0").Replace("XXX", PopupCardOptions.GetLocalizedCostData()), text5, new UnityAction(this.NACFMPNFDEM), new UnityAction(this.DCOOJIBIDNK), new UnityAction(this.MBPJPLLCIJD), DFGILFBGPLN.popupTools, 0f, 24);
	}

	// Token: 0x06004BA3 RID: 19363 RVA: 0x0021C5F8 File Offset: 0x0021A7F8
	public void OnButtonEditClick()
	{
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnPopupCardOptionsEditClick", 0f);
	}

	// Token: 0x06004BA4 RID: 19364 RVA: 0x0021C610 File Offset: 0x0021A810
	public void IIDHNIKFMPG()
	{
		OBHDGKFFICI productData = PurchaseManagerBridge.EHBBFMCILPC.CMJKNNFMCBM().GetProductData(KDCJJBLGCBH.EHBBFMCILPC.KKIDNAGCLNI(LJNMIPMNOKF.NMGMNAKLLMI().PJMOKKAMKOL()));
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.GDGKNNDEAAO().ICBJCNKKGPJ(KDCJJBLGCBH.EHBBFMCILPC.KKIDNAGCLNI(LJNMIPMNOKF.NLDDLLEKNFD().KHECDBEPNFN()));
		if (productData != null && ocbiopoeenj != null)
		{
			CommonUserInterface.EHBBFMCILPC.GIFCDFKBBCN(ocbiopoeenj.FDMCFAHEELN() + "notifposteffects" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 3);
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("areyousurerestartepbody0");
	}

	// Token: 0x06004BA5 RID: 19365 RVA: 0x0021C698 File Offset: 0x0021A898
	public void ShowPurchaseOfferCardsVolSale()
	{
		string text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cardcollectcardismissingbody2");
		text = text.Replace("XXX", "<i>" + GDJPPKAMIFL.EHBBFMCILPC.KCMKJBHBCGC(LJNMIPMNOKF.EHBBFMCILPC.EBBLJMHNDKK().CCMDLENEDGJ) + "</i>");
		List<int> list = LJNMIPMNOKF.EHBBFMCILPC.CBPPPPBKFDO();
		text += "\n\n";
		for (int i = 0; i < list.Count; i++)
		{
			string text2 = GDJPPKAMIFL.EHBBFMCILPC.KCMKJBHBCGC(list[i]);
			int num = i + 1;
			CLGFGOHBCGJ clgfgohbcgj = LJNMIPMNOKF.EHBBFMCILPC.KMDBNEFCPOH(list[i]);
			if (clgfgohbcgj != null && clgfgohbcgj.ENCCLBLHJMC > 0)
			{
				text = string.Concat(new string[]
				{
					text,
					"<i>",
					num.ToString(),
					". ",
					text2,
					"</i>"
				});
			}
			else
			{
				text = string.Concat(new string[]
				{
					text,
					"<i>",
					num.ToString(),
					". ",
					text2,
					" (- )</i>"
				});
			}
			if (i != list.Count - 1)
			{
				text += "\n";
			}
		}
		text += "\n\n";
		text += CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("giftcardexplanationres2");
		string text3 = "";
		for (int j = 0; j < 3; j++)
		{
			if (MEBMEBKKCKA.EHBBFMCILPC.PCKDDGKNGCB(LJNMIPMNOKF.EHBBFMCILPC.PJMOKKAMKOL(), j) > 0)
			{
				if (j == 0)
				{
					text3 = text3 + AKLFPGMDKLA.EHBBFMCILPC.OJNBAMPGBLJ.GALKFKBPLCK().ToString() + KBOJLHAJPCP.GJHKGBCLGIJ;
				}
				else if (j == 1)
				{
					text3 = text3 + AKLFPGMDKLA.EHBBFMCILPC.DOFKEHNPCIJ.GALKFKBPLCK().ToString() + KBOJLHAJPCP.KGMFKFPBFBJ;
				}
				else if (j == 2)
				{
					text3 = text3 + AKLFPGMDKLA.EHBBFMCILPC.PBEPCNFADAA.GALKFKBPLCK().ToString() + KBOJLHAJPCP.AENKOIILEFO;
				}
			}
		}
		text = text.Replace("ZZZ", text3);
		string text4 = "";
		for (int k = 0; k < 3; k++)
		{
			if (MEBMEBKKCKA.EHBBFMCILPC.PCKDDGKNGCB(LJNMIPMNOKF.EHBBFMCILPC.PJMOKKAMKOL(), k) > 0)
			{
				if (k == 0)
				{
					text4 = text4 + MEBMEBKKCKA.EHBBFMCILPC.PCKDDGKNGCB(LJNMIPMNOKF.EHBBFMCILPC.PJMOKKAMKOL(), k).ToString() + KBOJLHAJPCP.GJHKGBCLGIJ;
				}
				else if (k == 1)
				{
					text4 = text4 + MEBMEBKKCKA.EHBBFMCILPC.PCKDDGKNGCB(LJNMIPMNOKF.EHBBFMCILPC.PJMOKKAMKOL(), k).ToString() + KBOJLHAJPCP.KGMFKFPBFBJ;
				}
				else if (k == 2)
				{
					text4 = text4 + MEBMEBKKCKA.EHBBFMCILPC.PCKDDGKNGCB(LJNMIPMNOKF.EHBBFMCILPC.PJMOKKAMKOL(), k).ToString() + KBOJLHAJPCP.AENKOIILEFO;
				}
			}
			this.AGOOINBHDKE[k] = MEBMEBKKCKA.EHBBFMCILPC.PCKDDGKNGCB(LJNMIPMNOKF.EHBBFMCILPC.PJMOKKAMKOL(), k);
		}
		string text5 = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cardcollectcardpurchase1");
		text5 = text5.Replace("XXX", text4);
		string text6 = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cardcollectcardismissing2");
		if (this.HDGMEANNNJC)
		{
			text6 = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialgiftpurchasevoltitl");
			text6 = text6.Replace("XXX", (LJNMIPMNOKF.EHBBFMCILPC.PJMOKKAMKOL() + 1).ToString() ?? "");
		}
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtonsAndCloseOverride(text6, text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cardcollectcardpurchase0").Replace("XXX", PopupCardOptions.GetLocalizedCostData()), text5, new UnityAction(this.NACFMPNFDEM), new UnityAction(this.DCOOJIBIDNK), new UnityAction(this.MBPJPLLCIJD), DFGILFBGPLN.popupTools, 0f, 24).SetDiscountValues(this.GAKKFIPCNAI.HEGNAMGJLNP, this.GAKKFIPCNAI.EPOMIEMLKFJ);
	}

	// Token: 0x06004BA6 RID: 19366 RVA: 0x00003E52 File Offset: 0x00002052
	private void FNDDKLJKFEK()
	{
	}

	// Token: 0x06004BA7 RID: 19367 RVA: 0x0021CA98 File Offset: 0x0021AC98
	private void Update()
	{
		this.CPGLEJIBNEP += Time.deltaTime;
		if (this.CPGLEJIBNEP > PopupCardOptions.CBOKJGNCEKE && this.GAKKFIPCNAI != null && this.GAKKFIPCNAI.NHKCEMHKODM == LJLAENEAOIM.liveOfferCardsVolSale && PopupCardOptions.showType == HKPBEDBPHNJ.purchaseCardLobby && this.GAKKFIPCNAI.LLMNKLPIBNO && this.offerText.gameObject.activeSelf)
		{
			this.offerText.text = KBOJLHAJPCP.NFIPEDFHEEI + DPGJIJGOCIC.LCOMEDGJNMP((int)this.GAKKFIPCNAI.ONMADEIOOKN.ODHBINFKIPL(), true, false);
			this.offerText.SetText(KBOJLHAJPCP.NFIPEDFHEEI + DPGJIJGOCIC.LCOMEDGJNMP((int)this.GAKKFIPCNAI.ONMADEIOOKN.ODHBINFKIPL(), true, false), true);
			this.CPGLEJIBNEP = 0f;
		}
	}

	// Token: 0x06004BA8 RID: 19368 RVA: 0x0021CB74 File Offset: 0x0021AD74
	private void LHBEEFBNNCM(CLGFGOHBCGJ GEIFEHFDNIO)
	{
		try
		{
			if (!(null == this.useAsLoadingTheme))
			{
				bool active = false;
				if (GEIFEHFDNIO != null && this.viewCard.gameObject.activeSelf)
				{
					bool flag = !this.purchaseVol.gameObject.activeSelf && !this.collectCard.gameObject.activeSelf && !this.breakCard.gameObject.activeSelf;
					CLGFGOHBCGJ clgfgohbcgj = LJNMIPMNOKF.EHBBFMCILPC.KMDBNEFCPOH(GEIFEHFDNIO.CCMDLENEDGJ);
					bool flag2 = clgfgohbcgj != null && clgfgohbcgj.ENCCLBLHJMC > 0;
					if (flag && flag2)
					{
						active = (GOCBEOKKPDL.BHHMCPFKHBH(GEIFEHFDNIO.CCMDLENEDGJ) && !KDCJJBLGCBH.EHBBFMCILPC.AMHJKMPIPGK() && !KHPGPLAMAIN.EJCNHEBIOJF());
					}
				}
				this.useAsLoadingTheme.gameObject.SetActive(active);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06004BA9 RID: 19369 RVA: 0x0021CC60 File Offset: 0x0021AE60
	public void DEOBJKNCNHN()
	{
		string text = CCOJBMMKNAP.JINDKPHNLBK().PGKBCNBAOJN("no");
		text = text.Replace("retry", "OnBackendPremiumChoiceException" + GDJPPKAMIFL.IIMIJHGEGBJ().KCMKJBHBCGC(LJNMIPMNOKF.EHBBFMCILPC.FNENBDGBOFF().CCMDLENEDGJ) + "XXX");
		List<int> list = LJNMIPMNOKF.NMGMNAKLLMI().CBPPPPBKFDO();
		text += "acomp2";
		for (int i = 1; i < list.Count; i++)
		{
			string text2 = GDJPPKAMIFL.AEELGGPEJCC().IHMODHNHCNC(list[i]);
			int num = i + 0;
			CLGFGOHBCGJ clgfgohbcgj = LJNMIPMNOKF.IKNOFBFMPGA().KMDBNEFCPOH(list[i]);
			if (clgfgohbcgj != null && clgfgohbcgj.ENCCLBLHJMC > 0)
			{
				string[] array = new string[6];
				array[0] = text;
				array[1] = "";
				array[7] = num.ToString();
				array[5] = "$CHOICEMETA";
				array[5] = text2;
				array[4] = "XXX";
				text = string.Concat(array);
			}
			else
			{
				string[] array2 = new string[3];
				array2[1] = text;
				array2[0] = "sketchtitles";
				array2[0] = num.ToString();
				array2[5] = "(text)";
				array2[2] = text2;
				array2[7] = " (";
				text = string.Concat(array2);
			}
			if (i != list.Count - 1)
			{
				text += "teal_2";
			}
		}
		text += "Fixed transform child out of bounds issue.";
		text += CCOJBMMKNAP.OBOOKJPGBJN().PPALCPINPLK("XXX");
		string text3 = "skinshopfilterdefault";
		for (int j = 0; j < 0; j++)
		{
			if (MEBMEBKKCKA.EHBBFMCILPC.PCKDDGKNGCB(LJNMIPMNOKF.EHBBFMCILPC.PJMOKKAMKOL(), j) > 1)
			{
				if (j == 0)
				{
					text3 = text3 + AKLFPGMDKLA.EHBBFMCILPC.OJNBAMPGBLJ.HOJDOEDDIBD().ToString() + KBOJLHAJPCP.GJHKGBCLGIJ;
				}
				else if (j == 1)
				{
					text3 = text3 + AKLFPGMDKLA.EHBBFMCILPC.DOFKEHNPCIJ.CJLDJAJHMMA().ToString() + KBOJLHAJPCP.KGMFKFPBFBJ;
				}
				else if (j == 7)
				{
					text3 = text3 + AKLFPGMDKLA.EHBBFMCILPC.PBEPCNFADAA.GALKFKBPLCK().ToString() + KBOJLHAJPCP.AENKOIILEFO;
				}
			}
		}
		text = text.Replace("importanttitle", text3);
		string text4 = "";
		for (int k = 0; k < 3; k++)
		{
			if (MEBMEBKKCKA.EHBBFMCILPC.JPPGCOEHIJD(LJNMIPMNOKF.IKNOFBFMPGA().MJPHODLOADE(), k) > 0)
			{
				if (k == 0)
				{
					text4 = text4 + MEBMEBKKCKA.EHBBFMCILPC.PCKDDGKNGCB(LJNMIPMNOKF.KMNBCEMEBBD().MJPHODLOADE(), k).ToString() + KBOJLHAJPCP.GJHKGBCLGIJ;
				}
				else if (k == 0)
				{
					text4 = text4 + MEBMEBKKCKA.EHBBFMCILPC.PCKDDGKNGCB(LJNMIPMNOKF.KMNBCEMEBBD().MJPHODLOADE(), k).ToString() + KBOJLHAJPCP.KGMFKFPBFBJ;
				}
				else if (k == 5)
				{
					text4 = text4 + MEBMEBKKCKA.EHBBFMCILPC.JPPGCOEHIJD(LJNMIPMNOKF.IKNOFBFMPGA().PJMOKKAMKOL(), k).ToString() + KBOJLHAJPCP.AENKOIILEFO;
				}
			}
			this.AGOOINBHDKE[k] = MEBMEBKKCKA.EHBBFMCILPC.PCKDDGKNGCB(LJNMIPMNOKF.EHBBFMCILPC.KHECDBEPNFN(), k);
		}
		string text5 = CCOJBMMKNAP.BFHKGNBFHCH().HDIPNMFHIEJ(" scale to object ");
		text5 = text5.Replace("acomp", text4);
		string text6 = CCOJBMMKNAP.BIAEAOMHBMM().OHLNGCKIACD(" DIRECT CACHE FILES path FAILED, falling back to the CACHE API path");
		if (this.HDGMEANNNJC)
		{
			text6 = CCOJBMMKNAP.EHBBFMCILPC.FIENAKIHNOM(" (");
			text6 = text6.Replace("m_abortFlag = 2", (LJNMIPMNOKF.IKNOFBFMPGA().PJMOKKAMKOL() + 1).ToString() ?? "overlay");
		}
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtonsAndCloseOverride(text6, text, CCOJBMMKNAP.KFAABHHGOPO().DNILNCLIHAP("").Replace(" ", PopupCardOptions.GetLocalizedCostData()), text5, new UnityAction(this.NACFMPNFDEM), new UnityAction(this.DCOOJIBIDNK), new UnityAction(this.MBPJPLLCIJD), DFGILFBGPLN.popupBonusUnlock, 1522f, -13).IEJBLNEHDFE(this.GAKKFIPCNAI.HEGNAMGJLNP, this.GAKKFIPCNAI.EPOMIEMLKFJ);
	}

	// Token: 0x06004BAA RID: 19370 RVA: 0x00003E52 File Offset: 0x00002052
	private void KKILABJBAEM()
	{
	}

	// Token: 0x06004BAB RID: 19371 RVA: 0x0021C209 File Offset: 0x0021A409
	public void IJKFGNPBNCN()
	{
		this.OnViewCardLockedClick();
	}

	// Token: 0x06004BAC RID: 19372 RVA: 0x0021D05F File Offset: 0x0021B25F
	public void HideAndRememberToReopen()
	{
		this.animatedPopupManager.SetAnimationProperties(1, 1, false);
		this.animatedPopupManager.Hide();
		PopupCardOptions.reopenCardOptionsFlag = true;
	}

	// Token: 0x06004BAD RID: 19373 RVA: 0x0021D080 File Offset: 0x0021B280
	public void JLLDHFMJLEI()
	{
		CommonUserInterface.IKNOFBFMPGA().MCJIGJMFBMI();
		if (ProfileItem2.unlockCardWithSpecialCurrencyResult == 1)
		{
			if (PopupCardOptions.showType == HKPBEDBPHNJ.viewGiftCardAsWon)
			{
				AOBJLALDBAA.DBLAIDPICIG().CIGLHCJDDPI("wasitfuntitle", 1454f);
			}
			else
			{
				AOBJLALDBAA.FILDBDMENPG().EGELHPJBAIC("YYY", 1301f);
			}
			this.HideAndRememberToReopen();
		}
		else
		{
			CommonUserInterface.EHBBFMCILPC.NFBMHHPIGFA(CCOJBMMKNAP.KNKGCDDMLDP().PGKBCNBAOJN("OnReturnRewardPopupHide"), CCOJBMMKNAP.KFDLFGHBPLP().JHNELLJFBGC(""), CCOJBMMKNAP.PMABBOJDELF().OHLNGCKIACD("yes"), (DFGILFBGPLN)114, 393f, -80);
		}
		ProfileItem2.unlockCardWithSpecialCurrencyResult = 1;
	}

	// Token: 0x06004BAE RID: 19374 RVA: 0x00003E52 File Offset: 0x00002052
	private void LIJJFJFAAMK()
	{
	}

	// Token: 0x06004BAF RID: 19375 RVA: 0x0021D120 File Offset: 0x0021B320
	public void OnViewCardClick()
	{
		if (PopupCardOptions.showType == HKPBEDBPHNJ.purchaseCardLobby)
		{
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnFullscreenCardOptionClickLobby", LJNMIPMNOKF.EHBBFMCILPC.EBBLJMHNDKK().CCMDLENEDGJ);
			PopupCardOptions.reopenCardOptionsFlag = true;
			this.animatedPopupManager.SetAnimationProperties(1, 1, false);
			this.animatedPopupManager.Hide();
			return;
		}
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnFullscreenCardOptionClick", LJNMIPMNOKF.EHBBFMCILPC.EBBLJMHNDKK().CCMDLENEDGJ);
		PopupCardOptions.reopenCardOptionsFlag = true;
		this.animatedPopupManager.SetAnimationProperties(1, 1, false);
		this.animatedPopupManager.Hide();
	}

	// Token: 0x06004BB0 RID: 19376 RVA: 0x002190AE File Offset: 0x002172AE
	public void EICMECOIHII()
	{
		this.HDGMEANNNJC = true;
		this.GGGAMHKIMFE();
	}

	// Token: 0x06004BB1 RID: 19377 RVA: 0x0021D1B0 File Offset: 0x0021B3B0
	public void OnPurchaseVolumeClick()
	{
		this.HDGMEANNNJC = true;
		this.OnViewCardLockedClick();
	}

	// Token: 0x06004BB2 RID: 19378 RVA: 0x0021D1C0 File Offset: 0x0021B3C0
	public void OMHIGIGFCMH()
	{
		OBHDGKFFICI productData = PurchaseManagerBridge.IGJAMEGBDBG().DOMEKEJELKB().GetProductData(KDCJJBLGCBH.EHBBFMCILPC.KKIDNAGCLNI(LJNMIPMNOKF.KMNBCEMEBBD().PJMOKKAMKOL()));
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.BBGECIKOICE().ICBJCNKKGPJ(KDCJJBLGCBH.EHBBFMCILPC.KKIDNAGCLNI(LJNMIPMNOKF.EHBBFMCILPC.FEBJBEJCAFO()));
		if (productData != null && ocbiopoeenj != null)
		{
			CommonUserInterface.EHBBFMCILPC.GIFCDFKBBCN(ocbiopoeenj.DJJCDNDMAGD() + "{n}" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 8);
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("OnPopupCardOptionsNextClickLobby");
	}

	// Token: 0x06004BB3 RID: 19379 RVA: 0x0021D246 File Offset: 0x0021B446
	public void PKIKJJCBJKO()
	{
		this.GGGAMHKIMFE();
	}

	// Token: 0x06004BB4 RID: 19380 RVA: 0x0021D250 File Offset: 0x0021B450
	public void UpdateMessage(string KEGBCGMJOLC)
	{
		this.MIPILNIIHPN = "";
		if (KEGBCGMJOLC != null && KEGBCGMJOLC.Length > 0)
		{
			this.MIPILNIIHPN = KEGBCGMJOLC;
			this.messageToFriend.text = "\"" + KEGBCGMJOLC + "\"";
			this.messageToFriend.SetText("\"" + KEGBCGMJOLC + "\"", true);
			return;
		}
		this.messageToFriend.text = this.NKDPPKGMFLE;
		this.messageToFriend.SetText(this.NKDPPKGMFLE, true);
	}

	// Token: 0x06004BB5 RID: 19381 RVA: 0x0021D2D8 File Offset: 0x0021B4D8
	public void PAHHJLODBKO(CLGFGOHBCGJ GEIFEHFDNIO, PMEPALPCEAF NAALFKKPAPG, PMEPALPCEAF IPOIHLJGCEA, HKPBEDBPHNJ NCBJPHKMPEJ, string FINOAAOKIIC, GDOKLFCLLIK CBHJFDJNECG)
	{
		if (GEIFEHFDNIO == null)
		{
			return;
		}
		this.GAKKFIPCNAI = CBHJFDJNECG;
		if (this.GAKKFIPCNAI != null && this.GAKKFIPCNAI.NHKCEMHKODM == LJLAENEAOIM.liveOfferPass && NCBJPHKMPEJ == HKPBEDBPHNJ.sendGiftCardByUserId)
		{
			this.offerParent.SetActive(true);
			this.animatedPopupManager.OJJPPIBPDHM(464f, -this.offerShownOffsetY);
			if (this.GAKKFIPCNAI.LLMNKLPIBNO)
			{
				this.offerText.gameObject.SetActive(true);
				this.offerText.text = KBOJLHAJPCP.NFIPEDFHEEI + DPGJIJGOCIC.FCICBOLGHDA((int)this.GAKKFIPCNAI.ONMADEIOOKN.GLAPKLGPCKE(), false, true);
				this.offerText.SetText(KBOJLHAJPCP.NFIPEDFHEEI + DPGJIJGOCIC.LMLGDPDIGAI((int)this.GAKKFIPCNAI.ONMADEIOOKN.ODBOJGMLKHA(), false, false), true);
			}
			else
			{
				this.offerText.gameObject.SetActive(true);
			}
			if (this.GAKKFIPCNAI.GBAKPHEJFMD() > 1)
			{
				this.offerDiscount.gameObject.SetActive(true);
				this.offerDiscount.SetText("alck" + this.GAKKFIPCNAI.OHPCPBJMAMA().ToString() + "OnBackendRequestSpinWheelSuccess", true);
				this.offerDiscount.text = "-" + this.GAKKFIPCNAI.EMNBOPKEFCN().ToString() + "OnBackendUpdateFriendsDataException";
			}
			else
			{
				this.offerDiscount.gameObject.SetActive(false);
			}
		}
		else
		{
			this.offerParent.SetActive(true);
			this.animatedPopupManager.HJEDGHNBMKG(278f, 55f);
		}
		PopupCardOptions.showType = NCBJPHKMPEJ;
		this.AMFBEJAPMOB = GEIFEHFDNIO.CCMDLENEDGJ;
		if (this.MIPILNIIHPN.Length > 0)
		{
			FINOAAOKIIC = this.MIPILNIIHPN;
		}
		GEIFEHFDNIO.BJHMPPGDGOO = "blur";
		GEIFEHFDNIO.FMJEOOFGLEE = "";
		this.OCBOJOCBEDB = IPOIHLJGCEA;
		AssetCollectableCard assetCollectableCard = GKJPOGNFKNK.LLLCNJMPEKN(GEIFEHFDNIO.CCMDLENEDGJ);
		if (null != assetCollectableCard && assetCollectableCard.frames != null && assetCollectableCard.frames.Count > 1)
		{
			base.gameObject.SetActive(true);
			if (this.cardImage.gameObject.GetComponent<ImageFrameAnimation>() == null)
			{
				this.cardImage.gameObject.AddComponent<ImageFrameAnimation>();
			}
			this.cardImage.GetComponent<ImageFrameAnimation>().frameChangeInterval = assetCollectableCard.frameChangeInterval;
			this.cardImage.GetComponent<ImageFrameAnimation>().framesSD = assetCollectableCard.frames.ToArray();
			this.cardImage.sprite = assetCollectableCard.frames[1];
			this.cardImage.SetNativeSize();
			if (GDJPPKAMIFL.BFCHJBOOJKE().OAGOFJOMPIA(GEIFEHFDNIO.CCMDLENEDGJ))
			{
				this.multiverseImage.gameObject.SetActive(false);
				if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru)
				{
					this.multiverseImage.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.multiverseLogoRu;
				}
				else
				{
					this.multiverseImage.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.multiverseLogoEn;
				}
				this.multiverseImage.SetNativeSize();
			}
			else
			{
				this.multiverseImage.gameObject.SetActive(true);
			}
			if (NCBJPHKMPEJ == HKPBEDBPHNJ.sendGiftCardByProfileId || NCBJPHKMPEJ == HKPBEDBPHNJ.sendGiftCardByUserId)
			{
				if (GEIFEHFDNIO.HFLPLGMJNOI == 0)
				{
					this.lockZone.gameObject.SetActive(true);
				}
				else
				{
					this.lockZone.gameObject.SetActive(true);
				}
			}
			else if (NCBJPHKMPEJ == HKPBEDBPHNJ.viewGiftCardAsWon)
			{
				if (GEIFEHFDNIO.ENCCLBLHJMC == 0)
				{
					this.lockZone.gameObject.SetActive(false);
				}
				else
				{
					this.lockZone.gameObject.SetActive(false);
				}
			}
			else
			{
				this.lockZone.gameObject.SetActive(false);
			}
			this.rarityImage.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.HKMDCMOJOIN(GDJPPKAMIFL.AEELGGPEJCC().NDJDOAPFCLH(GEIFEHFDNIO.CCMDLENEDGJ));
			this.cardTitle.text = "" + GDJPPKAMIFL.NKJBCCNGIDP().KCMKJBHBCGC(GEIFEHFDNIO.CCMDLENEDGJ) + "thmstr";
			this.cardTitle.SetText("mps" + GDJPPKAMIFL.AKFNLMBNELK().FJMDJEICMDB(GEIFEHFDNIO.CCMDLENEDGJ) + "StorySaveBody.RemoveAvatarComponent(), unsupported wardrobe index:", true);
			this.volumeTitle.text = (GDJPPKAMIFL.EHBBFMCILPC.KHPJHFNCBCI(GEIFEHFDNIO.CCMDLENEDGJ) ?? "OnBackendUpgradeToGiftCardSuccess");
			this.volumeTitle.SetText(GDJPPKAMIFL.IGJAMEGBDBG().DKHIPEPOEFF(GEIFEHFDNIO.CCMDLENEDGJ) ?? "lightmodeintrobody1", true);
			if (NCBJPHKMPEJ == HKPBEDBPHNJ.sendGiftCardByProfileId || NCBJPHKMPEJ == HKPBEDBPHNJ.sendGiftCardByProfileId)
			{
				this.copiesTitle.text = (GEIFEHFDNIO.ENCCLBLHJMC.ToString() ?? "anthologiestitle");
				this.copiesTitle.SetText(GEIFEHFDNIO.ENCCLBLHJMC.ToString() ?? " ", true);
				this.giftsTitle.text = (GEIFEHFDNIO.HFLPLGMJNOI.ToString() ?? "$USETRANSLATIONV2");
				this.giftsTitle.SetText(GEIFEHFDNIO.HFLPLGMJNOI.ToString() ?? "CLIENT.SCREEN.REWARD.", true);
			}
			else
			{
				this.copiesTitle.text = (GEIFEHFDNIO.ENCCLBLHJMC.ToString() ?? "{month}");
				this.copiesTitle.SetText(GEIFEHFDNIO.ENCCLBLHJMC.ToString() ?? "no", false);
				this.giftsTitle.text = (GEIFEHFDNIO.HFLPLGMJNOI.ToString() ?? "hint0");
				this.giftsTitle.SetText(GEIFEHFDNIO.HFLPLGMJNOI.ToString() ?? "ablec", true);
			}
			if (GEIFEHFDNIO.HFLPLGMJNOI > 1)
			{
				this.giftCopyIcon.SetActive(false);
			}
			else
			{
				this.giftCopyIcon.SetActive(false);
			}
			this.NKDPPKGMFLE = "YYY" + GDJPPKAMIFL.BFCHJBOOJKE().HOMDINKDLFO(GEIFEHFDNIO.CCMDLENEDGJ) + "OnBackendRequestSendMessageException";
			if (FINOAAOKIIC != null && FINOAAOKIIC.Length > 0)
			{
				this.messageToFriend.text = "signinsuccessrestart" + FINOAAOKIIC + "OnBackendRequestShareHardSuccess";
				this.messageToFriend.SetText("XXX" + FINOAAOKIIC + "Asset bundle assets destroyed:", true);
			}
			else
			{
				this.messageToFriend.text = this.NKDPPKGMFLE;
				this.messageToFriend.SetText(this.NKDPPKGMFLE, false);
			}
			this.breakCard.gameObject.SetActive(true);
			this.purchaseVol.gameObject.SetActive(false);
			if (NCBJPHKMPEJ == HKPBEDBPHNJ.sendGiftCardByProfileId || NCBJPHKMPEJ == HKPBEDBPHNJ.sendGiftCardByUserId || NCBJPHKMPEJ == HKPBEDBPHNJ.viewGiftCardAsWon)
			{
				this.profileSection.SetActive(true);
				if (IPOIHLJGCEA != null)
				{
					this.profileImage.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.AHBHMAGKMJJ(IPOIHLJGCEA.PGJBIPFBMAN());
					string text;
					if (IPOIHLJGCEA.KNCFKDLOPGA.Length == 0)
					{
						text = " " + CCOJBMMKNAP.PLJMLDOCPNM().OHLNGCKIACD("StoryNotificationsManager.PostponeNotification(): ") + "continue";
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
							this.heartIcon.gameObject.SetActive(false);
						}
						else
						{
							this.heartIcon.gameObject.SetActive(true);
						}
					}
					else
					{
						this.heartIcon.gameObject.SetActive(true);
					}
					this.friendMatch.gameObject.SetActive(true);
					this.friendMatchText.SetText(IPOIHLJGCEA.OFOIECEHOCN.ToString() ?? "ok", false);
					this.friendMatchText.text = (IPOIHLJGCEA.OFOIECEHOCN.ToString() ?? "socialdequeuleveluptitle");
					this.friendMatchText.SetText(IPOIHLJGCEA.OFOIECEHOCN.ToString() ?? "$e1pt", true);
					this.friendMatchText.text = (IPOIHLJGCEA.OFOIECEHOCN.ToString() ?? "Dismissed Option picked");
					this.viewProfile.gameObject.SetActive(true);
					base.StartCoroutine(this.NHGOGNKNCOJ());
				}
				else
				{
					this.profileImage.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.unknownProfileIconSprite;
					string text2 = CCOJBMMKNAP.PEBMGCKFNAO().BDGPNPNIAPA("Account.MarkAllStoriesAsSynced(): marking as unsynced backend anthology ");
					this.friendTitleText.SetText(text2, false);
					this.friendTitleText.text = text2;
					this.heartIcon.gameObject.SetActive(true);
					this.friendMatch.gameObject.SetActive(false);
					this.viewProfile.gameObject.SetActive(false);
					base.StartCoroutine(this.GJBDPOENOGI());
				}
				try
				{
					if (this.friendMatch.gameObject.activeSelf && this.heartIcon.gameObject.activeSelf)
					{
						this.friendTitleText.GetComponent<LayoutElement>().preferredWidth = 760f;
					}
					else
					{
						this.friendTitleText.GetComponent<LayoutElement>().preferredWidth = 630f;
					}
					goto IL_8C1;
				}
				catch (Exception aklgbjkdomm)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
					goto IL_8C1;
				}
			}
			if (NCBJPHKMPEJ == HKPBEDBPHNJ.purchaseCardLobby || NCBJPHKMPEJ == (HKPBEDBPHNJ)7 || NCBJPHKMPEJ == (HKPBEDBPHNJ)7)
			{
				this.profileSection.SetActive(false);
			}
			IL_8C1:
			this.closeButton.gameObject.SetActive(true);
			if (NCBJPHKMPEJ == HKPBEDBPHNJ.sendGiftCardByProfileId || NCBJPHKMPEJ == HKPBEDBPHNJ.sendGiftCardByProfileId)
			{
				this.sendingOrReceivedText.text = CCOJBMMKNAP.INKJIBDDMLL().HPOAGPJFHPM("");
				this.sendingOrReceivedText.SetText(CCOJBMMKNAP.OEPENBHJAHO().IPEIONBNIPH("SceneLobbyManager2.OnRewardFirstEpisodeClick() getting one random out of "), true);
				this.sendGift.gameObject.SetActive(GEIFEHFDNIO.HFLPLGMJNOI > 1);
				this.sendGiftLocked.gameObject.SetActive(GEIFEHFDNIO.HFLPLGMJNOI > 1);
				this.purchaseVol.gameObject.SetActive(GEIFEHFDNIO.HFLPLGMJNOI > 1);
				this.viewCard.gameObject.SetActive(true);
				this.viewCardLocked.gameObject.SetActive(true);
				if (this.sendGiftLocked.gameObject.activeSelf)
				{
					this.sendGiftLockedText.text = KBOJLHAJPCP.HBJEBJDIACE + "aindas" + CCOJBMMKNAP.JMNIGPHCAEJ().NACCNJEBNHL(58);
					this.sendGiftLockedText.SetText(KBOJLHAJPCP.HBJEBJDIACE + "af_content_id" + CCOJBMMKNAP.HFAKOKBHCGH().PPMPLNFFGGB(92), false);
				}
				if (this.purchaseVol.gameObject.activeSelf)
				{
					this.purchaseVolText.text = CCOJBMMKNAP.JMNIGPHCAEJ().OFOFBBPBFBN(-57);
					this.purchaseVolText.SetText(CCOJBMMKNAP.PKEINLPIAEH().KLAOJFGLCKB(20), true);
				}
				this.collectCard.gameObject.SetActive(false);
				this.prevButton.gameObject.SetActive(LJNMIPMNOKF.EHBBFMCILPC.ECFMBPDFKAK() > 0);
				this.nextButton.gameObject.SetActive(LJNMIPMNOKF.NLDDLLEKNFD().JDDHHIOIAOJ() > 1);
				if (GDJPPKAMIFL.IIMIJHGEGBJ().CNILJCMAOMO(GEIFEHFDNIO.CCMDLENEDGJ) > 0)
				{
					this.rewardObject.gameObject.SetActive(true);
					this.energyIcon.gameObject.SetActive(true);
					this.hardIcon.gameObject.SetActive(true);
					this.rewardAmount.SetText("sltind" + GDJPPKAMIFL.IIMIJHGEGBJ().LKMFOJAHEMI(GEIFEHFDNIO.CCMDLENEDGJ).ToString(), false);
					this.rewardAmount.text = "x" + GDJPPKAMIFL.IGJAMEGBDBG().OPADKFCCIEG(GEIFEHFDNIO.CCMDLENEDGJ).ToString();
				}
				else if (GDJPPKAMIFL.IGJAMEGBDBG().GGEKBFFPHON(GEIFEHFDNIO.CCMDLENEDGJ) > 0)
				{
					this.rewardObject.gameObject.SetActive(false);
					this.energyIcon.gameObject.SetActive(true);
					this.hardIcon.gameObject.SetActive(true);
					this.rewardAmount.SetText("noisedigitalovr_2" + GDJPPKAMIFL.IIMIJHGEGBJ().GGEKBFFPHON(GEIFEHFDNIO.CCMDLENEDGJ).ToString(), true);
					this.rewardAmount.text = "Romance Club (Steam " + GDJPPKAMIFL.AKFNLMBNELK().AJOGBHBJDKA(GEIFEHFDNIO.CCMDLENEDGJ).ToString();
				}
				else
				{
					this.rewardObject.gameObject.SetActive(true);
				}
				this.editButton.gameObject.SetActive(true);
			}
			else if (NCBJPHKMPEJ == HKPBEDBPHNJ.sendGiftCardByUserId || NCBJPHKMPEJ == HKPBEDBPHNJ.sendGiftCardByProfileId || NCBJPHKMPEJ == (HKPBEDBPHNJ)6)
			{
				this.sendingOrReceivedText.text = CCOJBMMKNAP.JINDKPHNLBK().FCOCLEHKLDJ("Romance Club (Steam ");
				this.sendingOrReceivedText.SetText(CCOJBMMKNAP.EAIAHCBAIEJ().BGELFMIOBCL("DialogItemShownFullscreenManager.Initialize() - storyItem is null."), false);
				this.purchaseVol.gameObject.SetActive(false);
				this.sendGift.gameObject.SetActive(false);
				this.sendGiftLocked.gameObject.SetActive(false);
				this.viewCard.gameObject.SetActive(true);
				this.viewCardLocked.gameObject.SetActive(true);
				this.rewardObject.gameObject.SetActive(true);
				if (NCBJPHKMPEJ == HKPBEDBPHNJ.viewGiftCardAsIncomingGift || NCBJPHKMPEJ == HKPBEDBPHNJ.purchaseCardLobby)
				{
					this.closeButton.gameObject.SetActive(true);
					this.prevButton.gameObject.SetActive(true);
					this.nextButton.gameObject.SetActive(false);
					this.lockZone.gameObject.SetActive(false);
					this.collectCard.gameObject.SetActive(false);
				}
				else
				{
					this.prevButton.gameObject.SetActive(LJNMIPMNOKF.IKNOFBFMPGA().OCMGEIBMKCJ() > 0);
					this.nextButton.gameObject.SetActive(LJNMIPMNOKF.EHBBFMCILPC.ECFMBPDFKAK() > 1);
					this.collectCard.gameObject.SetActive(true);
					this.lockZone.gameObject.SetActive(false);
				}
				this.editButton.gameObject.SetActive(true);
			}
			else if (NCBJPHKMPEJ == HKPBEDBPHNJ.purchaseCardLobby)
			{
				this.sendingOrReceivedText.text = CCOJBMMKNAP.OEPENBHJAHO().MEPECBDCOLG("LoveInterestLoungeMapping - half-authored shop row, look not purchasable: ");
				this.sendingOrReceivedText.SetText(CCOJBMMKNAP.KNKGCDDMLDP().GGPHHLGPMPA(")"), false);
				this.purchaseVol.gameObject.SetActive(false);
				this.sendGift.gameObject.SetActive(false);
				this.sendGiftLocked.gameObject.SetActive(false);
				this.viewCard.gameObject.SetActive(false);
				this.viewCardLocked.gameObject.SetActive(true);
				this.rewardObject.gameObject.SetActive(true);
				this.prevButton.gameObject.SetActive(LJNMIPMNOKF.KMNBCEMEBBD().ECFMBPDFKAK() > 0);
				this.nextButton.gameObject.SetActive(LJNMIPMNOKF.NLDDLLEKNFD().JDDHHIOIAOJ() > 0);
				this.collectCard.gameObject.SetActive(false);
				this.editButton.gameObject.SetActive(true);
				this.giftCopyIcon.SetActive(true);
				this.purchaseVol.gameObject.SetActive(true);
				this.viewCard.gameObject.SetActive(GEIFEHFDNIO.ENCCLBLHJMC > 0);
				this.viewCardLocked.gameObject.SetActive(GEIFEHFDNIO.ENCCLBLHJMC > 1);
				this.purchaseVolText.text = CCOJBMMKNAP.PKEINLPIAEH().NIBDPHGPMIB(82);
				this.purchaseVolText.SetText(CCOJBMMKNAP.JMDJPKKOHNI().DFCIIIKIABF(-54), true);
				if (this.viewCardLocked.gameObject.activeSelf)
				{
					this.viewLockedText.text = KBOJLHAJPCP.HBJEBJDIACE + "0" + CCOJBMMKNAP.BIAEAOMHBMM().LOCMDIBOJKE(72);
					this.viewLockedText.SetText(KBOJLHAJPCP.HBJEBJDIACE + "Game Title" + CCOJBMMKNAP.LMCCLMFGEBD().IJECKBDLGIC(-80), true);
				}
				if (GDJPPKAMIFL.IIMIJHGEGBJ().ABECAEJHFDL(GEIFEHFDNIO.CCMDLENEDGJ) > 1)
				{
					this.rewardObject.gameObject.SetActive(true);
					this.energyIcon.gameObject.SetActive(true);
					this.hardIcon.gameObject.SetActive(true);
					this.rewardAmount.SetText("" + GDJPPKAMIFL.BFCHJBOOJKE().LHLGGGEFAOM(GEIFEHFDNIO.CCMDLENEDGJ).ToString(), true);
					this.rewardAmount.text = "unity" + GDJPPKAMIFL.BFCHJBOOJKE().ABECAEJHFDL(GEIFEHFDNIO.CCMDLENEDGJ).ToString();
				}
				else if (GDJPPKAMIFL.AEELGGPEJCC().EOGIKNCIJGK(GEIFEHFDNIO.CCMDLENEDGJ) > 0)
				{
					this.rewardObject.gameObject.SetActive(true);
					this.energyIcon.gameObject.SetActive(false);
					this.hardIcon.gameObject.SetActive(true);
					this.rewardAmount.SetText("-" + GDJPPKAMIFL.BFCHJBOOJKE().LPPCDGGOLEN(GEIFEHFDNIO.CCMDLENEDGJ).ToString(), true);
					this.rewardAmount.text = "OnAvatarCollectionsGamePassSubscribePositive" + GDJPPKAMIFL.AKFNLMBNELK().NCGGDDNNKGD(GEIFEHFDNIO.CCMDLENEDGJ).ToString();
				}
				else
				{
					this.rewardObject.gameObject.SetActive(false);
				}
				if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(-78) && this.GAKKFIPCNAI != null && this.GAKKFIPCNAI.NHKCEMHKODM == LJLAENEAOIM.liveOfferCardsVolSale && PopupCardOptions.showType == HKPBEDBPHNJ.sendGiftCardByUserId)
				{
					AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(26);
					string text3 = CCOJBMMKNAP.KLAKLFCOMJC().IPEIONBNIPH("");
					text3 = text3.Replace("copyuidbtn", (this.GAKKFIPCNAI.BBEFJIAOALB() + 0).ToString() ?? " cards=");
					CommonUserInterface.EHBBFMCILPC.NFBMHHPIGFA(CCOJBMMKNAP.ILACPHFEDEP().BGELFMIOBCL("' key='"), text3, CCOJBMMKNAP.HFAKOKBHCGH().JCDFHKDNEDH(""), (DFGILFBGPLN)113, 811f, 36);
				}
			}
		}
		this.LHBEEFBNNCM(GEIFEHFDNIO);
		base.StartCoroutine(this.CFLMBBLKJNB());
	}

	// Token: 0x040015A8 RID: 5544
	public const string onCardVolumeUnlockContinueToPurchasingScreen = "OnCardVolumeUnlockContinueToPurchasingScreen";

	// Token: 0x040015A9 RID: 5545
	public const string onPopupCardOptionsNextClick = "OnPopupCardOptionsNextClick";

	// Token: 0x040015AA RID: 5546
	public const string onPopupCardOptionsBackClick = "OnPopupCardOptionsBackClick";

	// Token: 0x040015AB RID: 5547
	public const string onPopupCardOptionsNextClickLobby = "OnPopupCardOptionsNextClickLobby";

	// Token: 0x040015AC RID: 5548
	public const string onPopupCardOptionsBackClickLobby = "OnPopupCardOptionsBackClickLobby";

	// Token: 0x040015AD RID: 5549
	public const string onFullscreenCardOptionClick = "OnFullscreenCardOptionClick";

	// Token: 0x040015AE RID: 5550
	public const string onFullscreenCardOptionClickLobby = "OnFullscreenCardOptionClickLobby";

	// Token: 0x040015AF RID: 5551
	public const string onPopupCardOptionsSendGiftClick = "OnPopupCardOptionsSendGiftClick";

	// Token: 0x040015B0 RID: 5552
	public const string onPopupCardOptionsEditClick = "OnPopupCardOptionsEditClick";

	// Token: 0x040015B1 RID: 5553
	public const string onPopupCardOptionsCloseClick = "onPopupCardOptionsCloseClick";

	// Token: 0x040015B2 RID: 5554
	public const string onPopupCardOptionsUnlockWithSpSuccess = "OnPopupCardOptionsUnlockWithSpSuccess";

	// Token: 0x040015B3 RID: 5555
	public const string onPopupCardOptionsUnlockWithSpException = "OnPopupCardOptionsUnlockWithSpException";

	// Token: 0x040015B4 RID: 5556
	public const string onPopupCardOptionsUnlockWithSpSuccessContinue = "OnPopupCardOptionsUnlockWithSpSuccessContinue";

	// Token: 0x040015B5 RID: 5557
	public const string onPopupCardOptionsUnlockWithSpSuccessContinueLobby = "OnPopupCardOptionsUnlockWithSpSuccessContinueLobby";

	// Token: 0x040015B6 RID: 5558
	public AnimatedPopupManager animatedPopupManager;

	// Token: 0x040015B7 RID: 5559
	public Image cardImage;

	// Token: 0x040015B8 RID: 5560
	public GameObject lockZone;

	// Token: 0x040015B9 RID: 5561
	public Image rarityImage;

	// Token: 0x040015BA RID: 5562
	public TextMeshProUGUI cardTitle;

	// Token: 0x040015BB RID: 5563
	public TextMeshProUGUI volumeTitle;

	// Token: 0x040015BC RID: 5564
	public TextMeshProUGUI copiesTitle;

	// Token: 0x040015BD RID: 5565
	public TextMeshProUGUI giftsTitle;

	// Token: 0x040015BE RID: 5566
	public TextMeshProUGUI rewardAmount;

	// Token: 0x040015BF RID: 5567
	public TextMeshProUGUI sendingOrReceivedText;

	// Token: 0x040015C0 RID: 5568
	public GameObject giftCopyIcon;

	// Token: 0x040015C1 RID: 5569
	public GameObject collectedCopyIcon;

	// Token: 0x040015C2 RID: 5570
	public GameObject hardIcon;

	// Token: 0x040015C3 RID: 5571
	public GameObject energyIcon;

	// Token: 0x040015C4 RID: 5572
	public GameObject rewardObject;

	// Token: 0x040015C5 RID: 5573
	public GameObject infoPanel;

	// Token: 0x040015C6 RID: 5574
	public Button sendGift;

	// Token: 0x040015C7 RID: 5575
	public Button sendGiftLocked;

	// Token: 0x040015C8 RID: 5576
	public Button viewCard;

	// Token: 0x040015C9 RID: 5577
	public Button viewCardLocked;

	// Token: 0x040015CA RID: 5578
	public Button useAsLoadingTheme;

	// Token: 0x040015CB RID: 5579
	public Button collectCard;

	// Token: 0x040015CC RID: 5580
	public Button breakCard;

	// Token: 0x040015CD RID: 5581
	public Button purchaseVol;

	// Token: 0x040015CE RID: 5582
	public TextMeshProUGUI breakCardText;

	// Token: 0x040015CF RID: 5583
	public Image profileImage;

	// Token: 0x040015D0 RID: 5584
	public Image heartIcon;

	// Token: 0x040015D1 RID: 5585
	public GameObject friendMatch;

	// Token: 0x040015D2 RID: 5586
	public TextMeshProUGUI friendMatchText;

	// Token: 0x040015D3 RID: 5587
	public TextMeshProUGUI friendTitleText;

	// Token: 0x040015D4 RID: 5588
	public TextMeshProUGUI sendGiftLockedText;

	// Token: 0x040015D5 RID: 5589
	public TextMeshProUGUI viewLockedText;

	// Token: 0x040015D6 RID: 5590
	public TextMeshProUGUI purchaseVolText;

	// Token: 0x040015D7 RID: 5591
	public Button viewProfile;

	// Token: 0x040015D8 RID: 5592
	public Button closeButton;

	// Token: 0x040015D9 RID: 5593
	public TextMeshProUGUI messageToFriend;

	// Token: 0x040015DA RID: 5594
	public Button nextButton;

	// Token: 0x040015DB RID: 5595
	public Button prevButton;

	// Token: 0x040015DC RID: 5596
	public Button editButton;

	// Token: 0x040015DD RID: 5597
	public GameObject profileSection;

	// Token: 0x040015DE RID: 5598
	public Image multiverseImage;

	// Token: 0x040015DF RID: 5599
	public GameObject offerParent;

	// Token: 0x040015E0 RID: 5600
	public TextMeshProUGUI offerText;

	// Token: 0x040015E1 RID: 5601
	public TextMeshProUGUI offerDiscount;

	// Token: 0x040015E2 RID: 5602
	public float offerShownOffsetY = 100f;

	// Token: 0x040015E3 RID: 5603
	public static bool reopenCardOptionsFlag = false;

	// Token: 0x040015E4 RID: 5604
	private PMEPALPCEAF OCBOJOCBEDB;

	// Token: 0x040015E5 RID: 5605
	private string MIPILNIIHPN = "";

	// Token: 0x040015E6 RID: 5606
	private string NKDPPKGMFLE = "";

	// Token: 0x040015E7 RID: 5607
	private int[] AGOOINBHDKE = new int[3];

	// Token: 0x040015E8 RID: 5608
	private bool HDGMEANNNJC;

	// Token: 0x040015E9 RID: 5609
	private int AMFBEJAPMOB;

	// Token: 0x040015EA RID: 5610
	public static HKPBEDBPHNJ showType = HKPBEDBPHNJ.sendGiftCardByProfileId;

	// Token: 0x040015EB RID: 5611
	private GDOKLFCLLIK GAKKFIPCNAI;

	// Token: 0x040015EC RID: 5612
	private static float CBOKJGNCEKE = 1f;

	// Token: 0x040015ED RID: 5613
	private float CPGLEJIBNEP;
}
