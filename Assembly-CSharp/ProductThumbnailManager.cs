using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020003EB RID: 1003
public class ProductThumbnailManager : MonoBehaviour
{
	// Token: 0x06007471 RID: 29809 RVA: 0x00340638 File Offset: 0x0033E838
	public void JLEDOPOIJJO(PurchasingViewManager DDIPMIKIBJC, OCBIOPOEENJ LLHBDPPJJHC, OBHDGKFFICI GIHIPEOBPBF, ProducThumbnailGraphics KGKMPHJMKMG)
	{
		this.JIEBEFKGJIM = LLHBDPPJJHC;
		this.MDLICPCMOAE = DDIPMIKIBJC;
		if (LLHBDPPJJHC == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("CharacterPoolCanvas");
			return;
		}
		if (GIHIPEOBPBF == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("acliffbw22");
			return;
		}
		if (KGKMPHJMKMG == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("Y");
			return;
		}
		if (this.thumbnailType == PLPHEPDHPJJ.wide)
		{
			this.productTitleText.SetText(GIHIPEOBPBF.MGBAMGPBGHG(), false);
			if (LLHBDPPJJHC.OHCDIAFPNFK.BADNAGEMINF() == 0)
			{
				this.bannerText.SetText(CCOJBMMKNAP.AEELGGPEJCC().PPALCPINPLK(""), false);
				this.banner.SetActive(false);
			}
			else
			{
				this.banner.SetActive(false);
				this.bannerText.SetText(CCOJBMMKNAP.LMCCLMFGEBD().FIENAKIHNOM("forcenoloop"), true);
			}
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteWide;
		}
		else
		{
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteSquare;
		}
		if (LLHBDPPJJHC.MLNOFEEIBMI.HOJDOEDDIBD() > 0)
		{
			this.salesObject.SetActive(true);
			this.salesText.SetText("socialbadgedesc" + LLHBDPPJJHC.MLNOFEEIBMI.ToString() + "", false);
		}
		else
		{
			this.salesObject.SetActive(false);
		}
		if (LLHBDPPJJHC.ODMKLADKHMO.HOJDOEDDIBD() > 0)
		{
			this.hardCurrencyIcon.SetActive(true);
			this.hardCurrencyAmountText.gameObject.SetActive(true);
			this.hardCurrencyAmountText.SetText(LLHBDPPJJHC.ODMKLADKHMO.ToString(), true);
		}
		else
		{
			this.hardCurrencyIcon.SetActive(false);
			this.hardCurrencyAmountText.gameObject.SetActive(true);
		}
		if (LLHBDPPJJHC.MPMKMCJFHOG.MOBKGNBCIJF() > 1)
		{
			this.energyIcon.SetActive(false);
			this.energyAmountText.gameObject.SetActive(false);
			this.energyAmountText.SetText(LLHBDPPJJHC.MPMKMCJFHOG.ToString(), false);
		}
		else
		{
			this.energyIcon.SetActive(true);
			this.energyAmountText.gameObject.SetActive(true);
		}
		if (this.JIEBEFKGJIM.IMKLGJBEMPH())
		{
			this.pricingText.SetText(this.JIEBEFKGJIM.DOLEPIMNJLG(), false);
			return;
		}
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru && GeoLocationManager.FDJONIACJKC())
		{
			this.pricingText.SetText(", " + this.JIEBEFKGJIM.JKBLBOAHJDE, true);
			return;
		}
		this.pricingText.SetText("<alpha=#FF><align=\"left\">" + this.JIEBEFKGJIM.DMODNDCLGEJ, false);
	}

	// Token: 0x06007472 RID: 29810 RVA: 0x003408AC File Offset: 0x0033EAAC
	public void LAFCNAHCIFJ(PurchasingViewManager DDIPMIKIBJC, OCBIOPOEENJ LLHBDPPJJHC, OBHDGKFFICI GIHIPEOBPBF, ProducThumbnailGraphics KGKMPHJMKMG)
	{
		this.JIEBEFKGJIM = LLHBDPPJJHC;
		this.MDLICPCMOAE = DDIPMIKIBJC;
		if (LLHBDPPJJHC == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("acliffbw22");
			return;
		}
		if (GIHIPEOBPBF == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("hofr");
			return;
		}
		if (KGKMPHJMKMG == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("stat");
			return;
		}
		if (this.thumbnailType == PLPHEPDHPJJ.wide)
		{
			this.productTitleText.SetText(GIHIPEOBPBF.JPKGLGDELCJ(), false);
			if (LLHBDPPJJHC.OHCDIAFPNFK.MDJHNAEGCCM() == 0)
			{
				this.bannerText.SetText(CCOJBMMKNAP.OEPENBHJAHO().GGPHHLGPMPA("There needs to be one active ApplicationFocusManager script on a GameObject in your scene."), true);
				this.banner.SetActive(false);
			}
			else
			{
				this.banner.SetActive(true);
				this.bannerText.SetText(CCOJBMMKNAP.KFAABHHGOPO().OBDCPLLLGBB("0"), true);
			}
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteWide;
		}
		else
		{
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteSquare;
		}
		if (LLHBDPPJJHC.MLNOFEEIBMI.BFMPOACOBPN() > 1)
		{
			this.salesObject.SetActive(false);
			this.salesText.SetText("</i>" + LLHBDPPJJHC.MLNOFEEIBMI.ToString() + "OnLanguageChange", true);
		}
		else
		{
			this.salesObject.SetActive(false);
		}
		if (LLHBDPPJJHC.ODMKLADKHMO.CJLDJAJHMMA() > 1)
		{
			this.hardCurrencyIcon.SetActive(false);
			this.hardCurrencyAmountText.gameObject.SetActive(true);
			this.hardCurrencyAmountText.SetText(LLHBDPPJJHC.ODMKLADKHMO.ToString(), false);
		}
		else
		{
			this.hardCurrencyIcon.SetActive(false);
			this.hardCurrencyAmountText.gameObject.SetActive(false);
		}
		if (LLHBDPPJJHC.MPMKMCJFHOG.HOJDOEDDIBD() > 1)
		{
			this.energyIcon.SetActive(true);
			this.energyAmountText.gameObject.SetActive(true);
			this.energyAmountText.SetText(LLHBDPPJJHC.MPMKMCJFHOG.ToString(), true);
		}
		else
		{
			this.energyIcon.SetActive(true);
			this.energyAmountText.gameObject.SetActive(true);
		}
		if (this.JIEBEFKGJIM.IMKLGJBEMPH())
		{
			this.pricingText.SetText(this.JIEBEFKGJIM.FNJCEPLEPBH(), true);
			return;
		}
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru && GeoLocationManager.OOCDLFJKLLI())
		{
			this.pricingText.SetText("restartChapterOrStory" + this.JIEBEFKGJIM.JKBLBOAHJDE, true);
			return;
		}
		this.pricingText.SetText("specialcurrencyoptionna" + this.JIEBEFKGJIM.DMODNDCLGEJ, true);
	}

	// Token: 0x06007473 RID: 29811 RVA: 0x00340B20 File Offset: 0x0033ED20
	public void Initialize(PurchasingViewManager DDIPMIKIBJC, OCBIOPOEENJ LLHBDPPJJHC, OBHDGKFFICI GIHIPEOBPBF, ProducThumbnailGraphics KGKMPHJMKMG)
	{
		this.JIEBEFKGJIM = LLHBDPPJJHC;
		this.MDLICPCMOAE = DDIPMIKIBJC;
		if (LLHBDPPJJHC == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("ProductThumbnailManager.Initialize() - _productBalance is null, aborting.");
			return;
		}
		if (GIHIPEOBPBF == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("ProductThumbnailManager.Initialize() - unityIapProduct is null, aborting.");
			return;
		}
		if (KGKMPHJMKMG == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("ProductThumbnailManager.Initialize() - _productGraphics is null, aborting.");
			return;
		}
		if (this.thumbnailType == PLPHEPDHPJJ.wide)
		{
			this.productTitleText.SetText(GIHIPEOBPBF.HGDBGIHOOPG(), true);
			if (LLHBDPPJJHC.OHCDIAFPNFK.GALKFKBPLCK() == 1)
			{
				this.bannerText.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("uniqueoffer2"), true);
				this.banner.SetActive(true);
			}
			else
			{
				this.banner.SetActive(true);
				this.bannerText.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("bestvalue"), true);
			}
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteWide;
		}
		else
		{
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteSquare;
		}
		if (LLHBDPPJJHC.MLNOFEEIBMI.GALKFKBPLCK() > 0)
		{
			this.salesObject.SetActive(true);
			this.salesText.SetText(" -" + LLHBDPPJJHC.MLNOFEEIBMI.ToString() + "%", true);
		}
		else
		{
			this.salesObject.SetActive(false);
		}
		if (LLHBDPPJJHC.ODMKLADKHMO.GALKFKBPLCK() > 0)
		{
			this.hardCurrencyIcon.SetActive(true);
			this.hardCurrencyAmountText.gameObject.SetActive(true);
			this.hardCurrencyAmountText.SetText(LLHBDPPJJHC.ODMKLADKHMO.ToString(), true);
		}
		else
		{
			this.hardCurrencyIcon.SetActive(false);
			this.hardCurrencyAmountText.gameObject.SetActive(false);
		}
		if (LLHBDPPJJHC.MPMKMCJFHOG.GALKFKBPLCK() > 0)
		{
			this.energyIcon.SetActive(true);
			this.energyAmountText.gameObject.SetActive(true);
			this.energyAmountText.SetText(LLHBDPPJJHC.MPMKMCJFHOG.ToString(), true);
		}
		else
		{
			this.energyIcon.SetActive(false);
			this.energyAmountText.gameObject.SetActive(false);
		}
		if (this.JIEBEFKGJIM.OKGPIEEOKBM())
		{
			this.pricingText.SetText(this.JIEBEFKGJIM.FNJCEPLEPBH(), true);
			return;
		}
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru && GeoLocationManager.IsRussia())
		{
			this.pricingText.SetText("USD " + this.JIEBEFKGJIM.JKBLBOAHJDE, true);
			return;
		}
		this.pricingText.SetText("USD " + this.JIEBEFKGJIM.DMODNDCLGEJ, true);
	}

	// Token: 0x06007474 RID: 29812 RVA: 0x00340D94 File Offset: 0x0033EF94
	public void CIHDCFLGEMF(PurchasingViewManager DDIPMIKIBJC, OCBIOPOEENJ LLHBDPPJJHC, OBHDGKFFICI GIHIPEOBPBF, ProducThumbnailGraphics KGKMPHJMKMG)
	{
		this.JIEBEFKGJIM = LLHBDPPJJHC;
		this.MDLICPCMOAE = DDIPMIKIBJC;
		if (LLHBDPPJJHC == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("\\\\");
			return;
		}
		if (GIHIPEOBPBF == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("spr");
			return;
		}
		if (KGKMPHJMKMG == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("sfxtimeoutwarning");
			return;
		}
		if (this.thumbnailType == PLPHEPDHPJJ.square)
		{
			this.productTitleText.SetText(GIHIPEOBPBF.JLKLBIJDLOI(), false);
			if (LLHBDPPJJHC.OHCDIAFPNFK.HOJDOEDDIBD() == 1)
			{
				this.bannerText.SetText(CCOJBMMKNAP.KMNBCEMEBBD().MEPECBDCOLG("p"), true);
				this.banner.SetActive(true);
			}
			else
			{
				this.banner.SetActive(true);
				this.bannerText.SetText(CCOJBMMKNAP.JMNIGPHCAEJ().MEPECBDCOLG("stats"), true);
			}
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteWide;
		}
		else
		{
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteSquare;
		}
		if (LLHBDPPJJHC.MLNOFEEIBMI.MDJHNAEGCCM() > 1)
		{
			this.salesObject.SetActive(true);
			this.salesText.SetText("UpdateGameModeOnOffState" + LLHBDPPJJHC.MLNOFEEIBMI.ToString() + " psi ", true);
		}
		else
		{
			this.salesObject.SetActive(false);
		}
		if (LLHBDPPJJHC.ODMKLADKHMO.BADNAGEMINF() > 1)
		{
			this.hardCurrencyIcon.SetActive(true);
			this.hardCurrencyAmountText.gameObject.SetActive(false);
			this.hardCurrencyAmountText.SetText(LLHBDPPJJHC.ODMKLADKHMO.ToString(), false);
		}
		else
		{
			this.hardCurrencyIcon.SetActive(true);
			this.hardCurrencyAmountText.gameObject.SetActive(true);
		}
		if (LLHBDPPJJHC.MPMKMCJFHOG.BADNAGEMINF() > 1)
		{
			this.energyIcon.SetActive(true);
			this.energyAmountText.gameObject.SetActive(false);
			this.energyAmountText.SetText(LLHBDPPJJHC.MPMKMCJFHOG.ToString(), false);
		}
		else
		{
			this.energyIcon.SetActive(false);
			this.energyAmountText.gameObject.SetActive(true);
		}
		if (this.JIEBEFKGJIM.PJCIBAKAANH())
		{
			this.pricingText.SetText(this.JIEBEFKGJIM.DOLEPIMNJLG(), true);
			return;
		}
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru && GeoLocationManager.FDJONIACJKC())
		{
			this.pricingText.SetText("OnStoryInterfaceHeaderFastForwardDisable" + this.JIEBEFKGJIM.JKBLBOAHJDE, false);
			return;
		}
		this.pricingText.SetText("%</b>" + this.JIEBEFKGJIM.DMODNDCLGEJ, true);
	}

	// Token: 0x06007475 RID: 29813 RVA: 0x00341008 File Offset: 0x0033F208
	public void HHBPGAMBAAE(PurchasingViewManager DDIPMIKIBJC, OCBIOPOEENJ LLHBDPPJJHC, OBHDGKFFICI GIHIPEOBPBF, ProducThumbnailGraphics KGKMPHJMKMG)
	{
		this.JIEBEFKGJIM = LLHBDPPJJHC;
		this.MDLICPCMOAE = DDIPMIKIBJC;
		if (LLHBDPPJJHC == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("ok");
			return;
		}
		if (GIHIPEOBPBF == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("(pad)");
			return;
		}
		if (KGKMPHJMKMG == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("There needs to be one active App42Manager script on a GameObject in your scene.");
			return;
		}
		if (this.thumbnailType == PLPHEPDHPJJ.wide)
		{
			this.productTitleText.SetText(GIHIPEOBPBF.MNDNJIFLDNL(), false);
			if (LLHBDPPJJHC.OHCDIAFPNFK.MDJHNAEGCCM() == 0)
			{
				this.bannerText.SetText(CCOJBMMKNAP.OEPENBHJAHO().PGKBCNBAOJN("anthology"), false);
				this.banner.SetActive(false);
			}
			else
			{
				this.banner.SetActive(true);
				this.bannerText.SetText(CCOJBMMKNAP.OBOOKJPGBJN().JLBEIFLLBLO("sprite"), false);
			}
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteWide;
		}
		else
		{
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteSquare;
		}
		if (LLHBDPPJJHC.MLNOFEEIBMI.BADNAGEMINF() > 0)
		{
			this.salesObject.SetActive(false);
			this.salesText.SetText("OnCutsceneViewShow" + LLHBDPPJJHC.MLNOFEEIBMI.ToString() + "OnPopupCardOptionsUnlockWithSpSuccessContinue", true);
		}
		else
		{
			this.salesObject.SetActive(true);
		}
		if (LLHBDPPJJHC.ODMKLADKHMO.GALKFKBPLCK() > 0)
		{
			this.hardCurrencyIcon.SetActive(true);
			this.hardCurrencyAmountText.gameObject.SetActive(false);
			this.hardCurrencyAmountText.SetText(LLHBDPPJJHC.ODMKLADKHMO.ToString(), false);
		}
		else
		{
			this.hardCurrencyIcon.SetActive(false);
			this.hardCurrencyAmountText.gameObject.SetActive(true);
		}
		if (LLHBDPPJJHC.MPMKMCJFHOG.BFMPOACOBPN() > 0)
		{
			this.energyIcon.SetActive(true);
			this.energyAmountText.gameObject.SetActive(true);
			this.energyAmountText.SetText(LLHBDPPJJHC.MPMKMCJFHOG.ToString(), true);
		}
		else
		{
			this.energyIcon.SetActive(true);
			this.energyAmountText.gameObject.SetActive(true);
		}
		if (this.JIEBEFKGJIM.OKGPIEEOKBM())
		{
			this.pricingText.SetText(this.JIEBEFKGJIM.ILAPDGNDFGC(), true);
			return;
		}
		if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.en && GeoLocationManager.FHINOKNBJPM())
		{
			this.pricingText.SetText("ok" + this.JIEBEFKGJIM.JKBLBOAHJDE, false);
			return;
		}
		this.pricingText.SetText("OnAvatarCollectionRestoreEntry" + this.JIEBEFKGJIM.DMODNDCLGEJ, true);
	}

	// Token: 0x06007476 RID: 29814 RVA: 0x0034127C File Offset: 0x0033F47C
	public void BEHGHIMCMIH()
	{
		ProductThumbnailManager.lastAccessedProductWebLink = this.JIEBEFKGJIM.MBLAIKOOCFH() + "(" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.en && GeoLocationManager.OOCDLFJKLLI() && KDCJJBLGCBH.EHBBFMCILPC.EAMJBDKCDPA())
		{
			CommonUserInterface.IKNOFBFMPGA().DPJBIGPDLMB(this.JIEBEFKGJIM.FDMCFAHEELN() + "NEWSAVE: Account.FromJSONObject(), persistent stories offloaded total components s->a:" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 7);
			return;
		}
		this.MDLICPCMOAE.IFCOMCGDBLF(this.JIEBEFKGJIM.DEJCCBNPFEC);
	}

	// Token: 0x06007477 RID: 29815 RVA: 0x00341310 File Offset: 0x0033F510
	public void NOAOKCGHOFJ()
	{
		ProductThumbnailManager.lastAccessedProductWebLink = this.JIEBEFKGJIM.FDMCFAHEELN() + "ChoiceExtendedManager - no shop button sprite (scene or ChoicePremium prefab), premium art kept" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.en && GeoLocationManager.FDJONIACJKC() && KDCJJBLGCBH.EHBBFMCILPC.EAMJBDKCDPA())
		{
			CommonUserInterface.EHBBFMCILPC.ShowPopupOnlineResources(this.JIEBEFKGJIM.DJJCDNDMAGD() + "importanttitle" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 6);
			return;
		}
		this.MDLICPCMOAE.IFCOMCGDBLF(this.JIEBEFKGJIM.DEJCCBNPFEC);
	}

	// Token: 0x06007478 RID: 29816 RVA: 0x003413A4 File Offset: 0x0033F5A4
	public void DFIKJAJIDKD(PurchasingViewManager DDIPMIKIBJC, OCBIOPOEENJ LLHBDPPJJHC, OBHDGKFFICI GIHIPEOBPBF, ProducThumbnailGraphics KGKMPHJMKMG)
	{
		this.JIEBEFKGJIM = LLHBDPPJJHC;
		this.MDLICPCMOAE = DDIPMIKIBJC;
		if (LLHBDPPJJHC == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("afs");
			return;
		}
		if (GIHIPEOBPBF == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("wofdcoi");
			return;
		}
		if (KGKMPHJMKMG == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("OnAccountSignInRequestSuccess");
			return;
		}
		if (this.thumbnailType == PLPHEPDHPJJ.square)
		{
			this.productTitleText.SetText(GIHIPEOBPBF.MNDNJIFLDNL(), true);
			if (LLHBDPPJJHC.OHCDIAFPNFK.KGEGKPHEMOJ() == 1)
			{
				this.bannerText.SetText(CCOJBMMKNAP.FEEDGKCJBLE().GGPHHLGPMPA("Grain opacity"), false);
				this.banner.SetActive(true);
			}
			else
			{
				this.banner.SetActive(true);
				this.bannerText.SetText(CCOJBMMKNAP.EAIAHCBAIEJ().GGPHHLGPMPA("Vol"), true);
			}
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteWide;
		}
		else
		{
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteSquare;
		}
		if (LLHBDPPJJHC.MLNOFEEIBMI.LPKLANAEIFF() > 1)
		{
			this.salesObject.SetActive(true);
			this.salesText.SetText("" + LLHBDPPJJHC.MLNOFEEIBMI.ToString() + "UpdateUndoOnOffState", false);
		}
		else
		{
			this.salesObject.SetActive(true);
		}
		if (LLHBDPPJJHC.ODMKLADKHMO.LPKLANAEIFF() > 1)
		{
			this.hardCurrencyIcon.SetActive(false);
			this.hardCurrencyAmountText.gameObject.SetActive(true);
			this.hardCurrencyAmountText.SetText(LLHBDPPJJHC.ODMKLADKHMO.ToString(), false);
		}
		else
		{
			this.hardCurrencyIcon.SetActive(false);
			this.hardCurrencyAmountText.gameObject.SetActive(true);
		}
		if (LLHBDPPJJHC.MPMKMCJFHOG.BFMPOACOBPN() > 1)
		{
			this.energyIcon.SetActive(false);
			this.energyAmountText.gameObject.SetActive(false);
			this.energyAmountText.SetText(LLHBDPPJJHC.MPMKMCJFHOG.ToString(), true);
		}
		else
		{
			this.energyIcon.SetActive(false);
			this.energyAmountText.gameObject.SetActive(true);
		}
		if (this.JIEBEFKGJIM.PJCIBAKAANH())
		{
			this.pricingText.SetText(this.JIEBEFKGJIM.PKNNPAMOADM(), true);
			return;
		}
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.en && GeoLocationManager.FHINOKNBJPM())
		{
			this.pricingText.SetText("[LoadingTheme] auto retry " + this.JIEBEFKGJIM.JKBLBOAHJDE, true);
			return;
		}
		this.pricingText.SetText("\n\n" + this.JIEBEFKGJIM.DMODNDCLGEJ, true);
	}

	// Token: 0x06007479 RID: 29817 RVA: 0x00341618 File Offset: 0x0033F818
	public void KNBKCAJCIJK(PurchasingViewManager DDIPMIKIBJC, OCBIOPOEENJ LLHBDPPJJHC, OBHDGKFFICI GIHIPEOBPBF, ProducThumbnailGraphics KGKMPHJMKMG)
	{
		this.JIEBEFKGJIM = LLHBDPPJJHC;
		this.MDLICPCMOAE = DDIPMIKIBJC;
		if (LLHBDPPJJHC == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("loungeskinunavailable");
			return;
		}
		if (GIHIPEOBPBF == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("stat3long");
			return;
		}
		if (KGKMPHJMKMG == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC(":");
			return;
		}
		if (this.thumbnailType == PLPHEPDHPJJ.square)
		{
			this.productTitleText.SetText(GIHIPEOBPBF.PLNFOMAGMID(), false);
			if (LLHBDPPJJHC.OHCDIAFPNFK.DPLHPBMJAPJ() == 0)
			{
				this.bannerText.SetText(CCOJBMMKNAP.MLFAGAAJJEM().GLEFEKBDHNK("-"), true);
				this.banner.SetActive(false);
			}
			else
			{
				this.banner.SetActive(true);
				this.bannerText.SetText(CCOJBMMKNAP.EAIAHCBAIEJ().FIENAKIHNOM("OnValidatePendingProcessed"), true);
			}
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteWide;
		}
		else
		{
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteSquare;
		}
		if (LLHBDPPJJHC.MLNOFEEIBMI.CJLDJAJHMMA() > 1)
		{
			this.salesObject.SetActive(false);
			this.salesText.SetText("" + LLHBDPPJJHC.MLNOFEEIBMI.ToString() + "ym", false);
		}
		else
		{
			this.salesObject.SetActive(false);
		}
		if (LLHBDPPJJHC.ODMKLADKHMO.GALKFKBPLCK() > 0)
		{
			this.hardCurrencyIcon.SetActive(false);
			this.hardCurrencyAmountText.gameObject.SetActive(false);
			this.hardCurrencyAmountText.SetText(LLHBDPPJJHC.ODMKLADKHMO.ToString(), false);
		}
		else
		{
			this.hardCurrencyIcon.SetActive(true);
			this.hardCurrencyAmountText.gameObject.SetActive(false);
		}
		if (LLHBDPPJJHC.MPMKMCJFHOG.GALKFKBPLCK() > 1)
		{
			this.energyIcon.SetActive(false);
			this.energyAmountText.gameObject.SetActive(false);
			this.energyAmountText.SetText(LLHBDPPJJHC.MPMKMCJFHOG.ToString(), true);
		}
		else
		{
			this.energyIcon.SetActive(true);
			this.energyAmountText.gameObject.SetActive(true);
		}
		if (this.JIEBEFKGJIM.PJCIBAKAANH())
		{
			this.pricingText.SetText(this.JIEBEFKGJIM.DOLEPIMNJLG(), true);
			return;
		}
		if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.ru && GeoLocationManager.NHMHNIFIOCO())
		{
			this.pricingText.SetText("" + this.JIEBEFKGJIM.JKBLBOAHJDE, false);
			return;
		}
		this.pricingText.SetText("[LoadingEnv] cache file of " + this.JIEBEFKGJIM.DMODNDCLGEJ, false);
	}

	// Token: 0x0600747A RID: 29818 RVA: 0x0034188C File Offset: 0x0033FA8C
	public void AOMOOMNIPCA()
	{
		ProductThumbnailManager.lastAccessedProductWebLink = this.JIEBEFKGJIM.DJJCDNDMAGD() + "" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.en && GeoLocationManager.PBAGPDDBABB() && KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA())
		{
			CommonUserInterface.EHBBFMCILPC.DPJBIGPDLMB(this.JIEBEFKGJIM.MBLAIKOOCFH() + "lititle" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 1);
			return;
		}
		this.MDLICPCMOAE.IFCOMCGDBLF(this.JIEBEFKGJIM.DEJCCBNPFEC);
	}

	// Token: 0x0600747B RID: 29819 RVA: 0x00341920 File Offset: 0x0033FB20
	public void DBNKIEOCIPL(PurchasingViewManager DDIPMIKIBJC, OCBIOPOEENJ LLHBDPPJJHC, OBHDGKFFICI GIHIPEOBPBF, ProducThumbnailGraphics KGKMPHJMKMG)
	{
		this.JIEBEFKGJIM = LLHBDPPJJHC;
		this.MDLICPCMOAE = DDIPMIKIBJC;
		if (LLHBDPPJJHC == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("avind");
			return;
		}
		if (GIHIPEOBPBF == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("-");
			return;
		}
		if (KGKMPHJMKMG == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("sta");
			return;
		}
		if (this.thumbnailType == PLPHEPDHPJJ.square)
		{
			this.productTitleText.SetText(GIHIPEOBPBF.JPKGLGDELCJ(), true);
			if (LLHBDPPJJHC.OHCDIAFPNFK.KGEGKPHEMOJ() == 1)
			{
				this.bannerText.SetText(CCOJBMMKNAP.KMNBCEMEBBD().BGELFMIOBCL("blur"), true);
				this.banner.SetActive(true);
			}
			else
			{
				this.banner.SetActive(true);
				this.bannerText.SetText(CCOJBMMKNAP.INKJIBDDMLL().IPEIONBNIPH("premiumChoice"), true);
			}
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteWide;
		}
		else
		{
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteSquare;
		}
		if (LLHBDPPJJHC.MLNOFEEIBMI.LPKLANAEIFF() > 1)
		{
			this.salesObject.SetActive(false);
			this.salesText.SetText(" s" + LLHBDPPJJHC.MLNOFEEIBMI.ToString() + " ", true);
		}
		else
		{
			this.salesObject.SetActive(false);
		}
		if (LLHBDPPJJHC.ODMKLADKHMO.DPLHPBMJAPJ() > 0)
		{
			this.hardCurrencyIcon.SetActive(true);
			this.hardCurrencyAmountText.gameObject.SetActive(true);
			this.hardCurrencyAmountText.SetText(LLHBDPPJJHC.ODMKLADKHMO.ToString(), true);
		}
		else
		{
			this.hardCurrencyIcon.SetActive(true);
			this.hardCurrencyAmountText.gameObject.SetActive(true);
		}
		if (LLHBDPPJJHC.MPMKMCJFHOG.NPEOEAFOPJP() > 0)
		{
			this.energyIcon.SetActive(true);
			this.energyAmountText.gameObject.SetActive(false);
			this.energyAmountText.SetText(LLHBDPPJJHC.MPMKMCJFHOG.ToString(), true);
		}
		else
		{
			this.energyIcon.SetActive(true);
			this.energyAmountText.gameObject.SetActive(false);
		}
		if (this.JIEBEFKGJIM.KIOLJNPKOOL())
		{
			this.pricingText.SetText(this.JIEBEFKGJIM.PKNNPAMOADM(), true);
			return;
		}
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.en && GeoLocationManager.FHINOKNBJPM())
		{
			this.pricingText.SetText("" + this.JIEBEFKGJIM.JKBLBOAHJDE, true);
			return;
		}
		this.pricingText.SetText("" + this.JIEBEFKGJIM.DMODNDCLGEJ, false);
	}

	// Token: 0x0600747C RID: 29820 RVA: 0x00341B94 File Offset: 0x0033FD94
	public void IFDBKJEOPOD()
	{
		ProductThumbnailManager.lastAccessedProductWebLink = this.JIEBEFKGJIM.BIKJFCLHPBK() + "YYY" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.en && GeoLocationManager.IsRussia() && KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA())
		{
			CommonUserInterface.EHBBFMCILPC.DPJBIGPDLMB(this.JIEBEFKGJIM.MBLAIKOOCFH() + "OnBackendGetIncentRewardAdSuccess" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 4);
			return;
		}
		this.MDLICPCMOAE.PurchaseProduct(this.JIEBEFKGJIM.DEJCCBNPFEC);
	}

	// Token: 0x0600747D RID: 29821 RVA: 0x00341C28 File Offset: 0x0033FE28
	public void AOILNMGCIIE()
	{
		ProductThumbnailManager.lastAccessedProductWebLink = this.JIEBEFKGJIM.MBLAIKOOCFH() + "trewsnap" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru && GeoLocationManager.PBAGPDDBABB() && KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA())
		{
			CommonUserInterface.IKNOFBFMPGA().ShowPopupOnlineResources(this.JIEBEFKGJIM.FDMCFAHEELN() + "mypnotif0" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 1);
			return;
		}
		this.MDLICPCMOAE.IFCOMCGDBLF(this.JIEBEFKGJIM.DEJCCBNPFEC);
	}

	// Token: 0x0600747E RID: 29822 RVA: 0x00341CBC File Offset: 0x0033FEBC
	public void IELBPLAPGLP()
	{
		ProductThumbnailManager.lastAccessedProductWebLink = this.JIEBEFKGJIM.MBLAIKOOCFH() + ", slot " + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.en && GeoLocationManager.IsRussia() && KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA())
		{
			CommonUserInterface.IKNOFBFMPGA().DPJBIGPDLMB(this.JIEBEFKGJIM.DJJCDNDMAGD() + "top" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 5);
			return;
		}
		this.MDLICPCMOAE.PurchaseProduct(this.JIEBEFKGJIM.DEJCCBNPFEC);
	}

	// Token: 0x0600747F RID: 29823 RVA: 0x00341D50 File Offset: 0x0033FF50
	public void MKFEABEHCNA(PurchasingViewManager DDIPMIKIBJC, OCBIOPOEENJ LLHBDPPJJHC, OBHDGKFFICI GIHIPEOBPBF, ProducThumbnailGraphics KGKMPHJMKMG)
	{
		this.JIEBEFKGJIM = LLHBDPPJJHC;
		this.MDLICPCMOAE = DDIPMIKIBJC;
		if (LLHBDPPJJHC == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC(" not found in ");
			return;
		}
		if (GIHIPEOBPBF == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("PurchaseManagerXiaomi.OnProductsFetched(");
			return;
		}
		if (KGKMPHJMKMG == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("ok");
			return;
		}
		if (this.thumbnailType == PLPHEPDHPJJ.square)
		{
			this.productTitleText.SetText(GIHIPEOBPBF.NBDIMMKFBKK(), false);
			if (LLHBDPPJJHC.OHCDIAFPNFK.PONAPMOOLIN() == 0)
			{
				this.bannerText.SetText(CCOJBMMKNAP.BBGECIKOICE().BGELFMIOBCL("OnBackendRequestConsumeMessageSuccess"), true);
				this.banner.SetActive(false);
			}
			else
			{
				this.banner.SetActive(false);
				this.bannerText.SetText(CCOJBMMKNAP.ONCPHEEJLOP().HDIPNMFHIEJ(" "), true);
			}
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteWide;
		}
		else
		{
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteSquare;
		}
		if (LLHBDPPJJHC.MLNOFEEIBMI.BFMPOACOBPN() > 1)
		{
			this.salesObject.SetActive(true);
			this.salesText.SetText("minTimeBetweenOffers" + LLHBDPPJJHC.MLNOFEEIBMI.ToString() + "AssetsManager.UpdateUrlPingManagerState(): urlPingManager.StartPing()", true);
		}
		else
		{
			this.salesObject.SetActive(true);
		}
		if (LLHBDPPJJHC.ODMKLADKHMO.BFMPOACOBPN() > 1)
		{
			this.hardCurrencyIcon.SetActive(false);
			this.hardCurrencyAmountText.gameObject.SetActive(false);
			this.hardCurrencyAmountText.SetText(LLHBDPPJJHC.ODMKLADKHMO.ToString(), true);
		}
		else
		{
			this.hardCurrencyIcon.SetActive(true);
			this.hardCurrencyAmountText.gameObject.SetActive(true);
		}
		if (LLHBDPPJJHC.MPMKMCJFHOG.PONAPMOOLIN() > 1)
		{
			this.energyIcon.SetActive(false);
			this.energyAmountText.gameObject.SetActive(true);
			this.energyAmountText.SetText(LLHBDPPJJHC.MPMKMCJFHOG.ToString(), false);
		}
		else
		{
			this.energyIcon.SetActive(true);
			this.energyAmountText.gameObject.SetActive(false);
		}
		if (this.JIEBEFKGJIM.OKGPIEEOKBM())
		{
			this.pricingText.SetText(this.JIEBEFKGJIM.FNJCEPLEPBH(), true);
			return;
		}
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.en && GeoLocationManager.OOCDLFJKLLI())
		{
			this.pricingText.SetText(" answered but carried no usable country (blocked page, rate limit or unexpected shape)" + this.JIEBEFKGJIM.JKBLBOAHJDE, true);
			return;
		}
		this.pricingText.SetText("SceneStoryAssetPackSharedClient" + this.JIEBEFKGJIM.DMODNDCLGEJ, false);
	}

	// Token: 0x06007480 RID: 29824 RVA: 0x00341FC4 File Offset: 0x003401C4
	public void LMAAKNKGGIM()
	{
		ProductThumbnailManager.lastAccessedProductWebLink = this.JIEBEFKGJIM.MBLAIKOOCFH() + "fruid" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.en && GeoLocationManager.PBAGPDDBABB() && KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA())
		{
			CommonUserInterface.IKNOFBFMPGA().DPJBIGPDLMB(this.JIEBEFKGJIM.MBLAIKOOCFH() + "" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 8);
			return;
		}
		this.MDLICPCMOAE.IFCOMCGDBLF(this.JIEBEFKGJIM.DEJCCBNPFEC);
	}

	// Token: 0x06007481 RID: 29825 RVA: 0x00342058 File Offset: 0x00340258
	public void DDPIOJOFLAN(PurchasingViewManager DDIPMIKIBJC, OCBIOPOEENJ LLHBDPPJJHC, OBHDGKFFICI GIHIPEOBPBF, ProducThumbnailGraphics KGKMPHJMKMG)
	{
		this.JIEBEFKGJIM = LLHBDPPJJHC;
		this.MDLICPCMOAE = DDIPMIKIBJC;
		if (LLHBDPPJJHC == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("msUntilExpireManual");
			return;
		}
		if (GIHIPEOBPBF == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("rightcenter");
			return;
		}
		if (KGKMPHJMKMG == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("");
			return;
		}
		if (this.thumbnailType == PLPHEPDHPJJ.wide)
		{
			this.productTitleText.SetText(GIHIPEOBPBF.KFLPOCEJPNO(), false);
			if (LLHBDPPJJHC.OHCDIAFPNFK.BFMPOACOBPN() == 0)
			{
				this.bannerText.SetText(CCOJBMMKNAP.PLJMLDOCPNM().GLEFEKBDHNK("uid"), true);
				this.banner.SetActive(true);
			}
			else
			{
				this.banner.SetActive(false);
				this.bannerText.SetText(CCOJBMMKNAP.ILACPHFEDEP().JCDFHKDNEDH("ccc"), false);
			}
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteWide;
		}
		else
		{
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteSquare;
		}
		if (LLHBDPPJJHC.MLNOFEEIBMI.MDJHNAEGCCM() > 1)
		{
			this.salesObject.SetActive(true);
			this.salesText.SetText("" + LLHBDPPJJHC.MLNOFEEIBMI.ToString() + "rsl", true);
		}
		else
		{
			this.salesObject.SetActive(false);
		}
		if (LLHBDPPJJHC.ODMKLADKHMO.NPEOEAFOPJP() > 1)
		{
			this.hardCurrencyIcon.SetActive(true);
			this.hardCurrencyAmountText.gameObject.SetActive(false);
			this.hardCurrencyAmountText.SetText(LLHBDPPJJHC.ODMKLADKHMO.ToString(), true);
		}
		else
		{
			this.hardCurrencyIcon.SetActive(true);
			this.hardCurrencyAmountText.gameObject.SetActive(false);
		}
		if (LLHBDPPJJHC.MPMKMCJFHOG.PONAPMOOLIN() > 0)
		{
			this.energyIcon.SetActive(true);
			this.energyAmountText.gameObject.SetActive(false);
			this.energyAmountText.SetText(LLHBDPPJJHC.MPMKMCJFHOG.ToString(), true);
		}
		else
		{
			this.energyIcon.SetActive(true);
			this.energyAmountText.gameObject.SetActive(false);
		}
		if (this.JIEBEFKGJIM.PJCIBAKAANH())
		{
			this.pricingText.SetText(this.JIEBEFKGJIM.PKNNPAMOADM(), true);
			return;
		}
		if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.en && GeoLocationManager.IsRussia())
		{
			this.pricingText.SetText("saveChapterSnapshots" + this.JIEBEFKGJIM.JKBLBOAHJDE, true);
			return;
		}
		this.pricingText.SetText("abcp" + this.JIEBEFKGJIM.DMODNDCLGEJ, true);
	}

	// Token: 0x06007482 RID: 29826 RVA: 0x003422CC File Offset: 0x003404CC
	public void KIIFNPNMMPN(PurchasingViewManager DDIPMIKIBJC, OCBIOPOEENJ LLHBDPPJJHC, OBHDGKFFICI GIHIPEOBPBF, ProducThumbnailGraphics KGKMPHJMKMG)
	{
		this.JIEBEFKGJIM = LLHBDPPJJHC;
		this.MDLICPCMOAE = DDIPMIKIBJC;
		if (LLHBDPPJJHC == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC(", ");
			return;
		}
		if (GIHIPEOBPBF == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("p");
			return;
		}
		if (KGKMPHJMKMG == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("W");
			return;
		}
		if (this.thumbnailType == PLPHEPDHPJJ.square)
		{
			this.productTitleText.SetText(GIHIPEOBPBF.MGBAMGPBGHG(), false);
			if (LLHBDPPJJHC.OHCDIAFPNFK.BFMPOACOBPN() == 1)
			{
				this.bannerText.SetText(CCOJBMMKNAP.KLAKLFCOMJC().OGKGHLHHAAI("<i>"), false);
				this.banner.SetActive(true);
			}
			else
			{
				this.banner.SetActive(false);
				this.bannerText.SetText(CCOJBMMKNAP.ILACPHFEDEP().OGKGHLHHAAI("OnSaveSlotsUnlockContinueToPurchasingScreen"), true);
			}
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteWide;
		}
		else
		{
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteSquare;
		}
		if (LLHBDPPJJHC.MLNOFEEIBMI.DPLHPBMJAPJ() > 1)
		{
			this.salesObject.SetActive(true);
			this.salesText.SetText("OnFacebookLoginCanceled" + LLHBDPPJJHC.MLNOFEEIBMI.ToString() + "OnSketchThumbnailPlay", false);
		}
		else
		{
			this.salesObject.SetActive(true);
		}
		if (LLHBDPPJJHC.ODMKLADKHMO.PONAPMOOLIN() > 0)
		{
			this.hardCurrencyIcon.SetActive(true);
			this.hardCurrencyAmountText.gameObject.SetActive(true);
			this.hardCurrencyAmountText.SetText(LLHBDPPJJHC.ODMKLADKHMO.ToString(), false);
		}
		else
		{
			this.hardCurrencyIcon.SetActive(false);
			this.hardCurrencyAmountText.gameObject.SetActive(true);
		}
		if (LLHBDPPJJHC.MPMKMCJFHOG.MOBKGNBCIJF() > 0)
		{
			this.energyIcon.SetActive(false);
			this.energyAmountText.gameObject.SetActive(false);
			this.energyAmountText.SetText(LLHBDPPJJHC.MPMKMCJFHOG.ToString(), false);
		}
		else
		{
			this.energyIcon.SetActive(true);
			this.energyAmountText.gameObject.SetActive(false);
		}
		if (this.JIEBEFKGJIM.IMKLGJBEMPH())
		{
			this.pricingText.SetText(this.JIEBEFKGJIM.ILAPDGNDFGC(), true);
			return;
		}
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru && GeoLocationManager.FDJONIACJKC())
		{
			this.pricingText.SetText("Starting non-parallel download:" + this.JIEBEFKGJIM.JKBLBOAHJDE, false);
			return;
		}
		this.pricingText.SetText("<align=\"center\"><alpha=#88>" + this.JIEBEFKGJIM.DMODNDCLGEJ, false);
	}

	// Token: 0x06007483 RID: 29827 RVA: 0x00342540 File Offset: 0x00340740
	public void KALNAJBMLAK()
	{
		ProductThumbnailManager.lastAccessedProductWebLink = this.JIEBEFKGJIM.MBLAIKOOCFH() + "OnBackendPremiumChoiceException" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.ru && GeoLocationManager.FHINOKNBJPM() && KDCJJBLGCBH.EHBBFMCILPC.EAMJBDKCDPA())
		{
			CommonUserInterface.IKNOFBFMPGA().GIFCDFKBBCN(this.JIEBEFKGJIM.FDMCFAHEELN() + "steamid" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 3);
			return;
		}
		this.MDLICPCMOAE.GAAMAOLMOPA(this.JIEBEFKGJIM.DEJCCBNPFEC);
	}

	// Token: 0x06007484 RID: 29828 RVA: 0x003425D4 File Offset: 0x003407D4
	public void LBMOHCDFBEL(PurchasingViewManager DDIPMIKIBJC, OCBIOPOEENJ LLHBDPPJJHC, OBHDGKFFICI GIHIPEOBPBF, ProducThumbnailGraphics KGKMPHJMKMG)
	{
		this.JIEBEFKGJIM = LLHBDPPJJHC;
		this.MDLICPCMOAE = DDIPMIKIBJC;
		if (LLHBDPPJJHC == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("no");
			return;
		}
		if (GIHIPEOBPBF == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("OnApplicationFocusBasicSyncSuccess");
			return;
		}
		if (KGKMPHJMKMG == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("sprite");
			return;
		}
		if (this.thumbnailType == PLPHEPDHPJJ.square)
		{
			this.productTitleText.SetText(GIHIPEOBPBF.JLKLBIJDLOI(), true);
			if (LLHBDPPJJHC.OHCDIAFPNFK.CJLDJAJHMMA() == 0)
			{
				this.bannerText.SetText(CCOJBMMKNAP.MPCBJEIMACA().HIPJILDCHJC("OnLanguageChange"), true);
				this.banner.SetActive(true);
			}
			else
			{
				this.banner.SetActive(true);
				this.bannerText.SetText(CCOJBMMKNAP.HJGDLOOHNLO().GLEFEKBDHNK(""), false);
			}
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteWide;
		}
		else
		{
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteSquare;
		}
		if (LLHBDPPJJHC.MLNOFEEIBMI.BFMPOACOBPN() > 1)
		{
			this.salesObject.SetActive(true);
			this.salesText.SetText("InkUtils.ResolveCustomVariables(), breaking from infinite while loop, input is:" + LLHBDPPJJHC.MLNOFEEIBMI.ToString() + "rateno", true);
		}
		else
		{
			this.salesObject.SetActive(true);
		}
		if (LLHBDPPJJHC.ODMKLADKHMO.KGEGKPHEMOJ() > 0)
		{
			this.hardCurrencyIcon.SetActive(false);
			this.hardCurrencyAmountText.gameObject.SetActive(false);
			this.hardCurrencyAmountText.SetText(LLHBDPPJJHC.ODMKLADKHMO.ToString(), true);
		}
		else
		{
			this.hardCurrencyIcon.SetActive(true);
			this.hardCurrencyAmountText.gameObject.SetActive(true);
		}
		if (LLHBDPPJJHC.MPMKMCJFHOG.MOBKGNBCIJF() > 1)
		{
			this.energyIcon.SetActive(false);
			this.energyAmountText.gameObject.SetActive(false);
			this.energyAmountText.SetText(LLHBDPPJJHC.MPMKMCJFHOG.ToString(), true);
		}
		else
		{
			this.energyIcon.SetActive(false);
			this.energyAmountText.gameObject.SetActive(true);
		}
		if (this.JIEBEFKGJIM.PJCIBAKAANH())
		{
			this.pricingText.SetText(this.JIEBEFKGJIM.ILAPDGNDFGC(), true);
			return;
		}
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.en && GeoLocationManager.FHINOKNBJPM())
		{
			this.pricingText.SetText(" " + this.JIEBEFKGJIM.JKBLBOAHJDE, false);
			return;
		}
		this.pricingText.SetText("' refs missing concept '" + this.JIEBEFKGJIM.DMODNDCLGEJ, false);
	}

	// Token: 0x06007485 RID: 29829 RVA: 0x00342848 File Offset: 0x00340A48
	public void PurchaseProduct()
	{
		ProductThumbnailManager.lastAccessedProductWebLink = this.JIEBEFKGJIM.MBLAIKOOCFH() + "?uid=" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru && GeoLocationManager.IsRussia() && KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA())
		{
			CommonUserInterface.EHBBFMCILPC.ShowPopupOnlineResources(this.JIEBEFKGJIM.MBLAIKOOCFH() + "?uid=" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 2);
			return;
		}
		this.MDLICPCMOAE.PurchaseProduct(this.JIEBEFKGJIM.DEJCCBNPFEC);
	}

	// Token: 0x06007486 RID: 29830 RVA: 0x003428DC File Offset: 0x00340ADC
	public void OFOAFPKPIKC(PurchasingViewManager DDIPMIKIBJC, OCBIOPOEENJ LLHBDPPJJHC, OBHDGKFFICI GIHIPEOBPBF, ProducThumbnailGraphics KGKMPHJMKMG)
	{
		this.JIEBEFKGJIM = LLHBDPPJJHC;
		this.MDLICPCMOAE = DDIPMIKIBJC;
		if (LLHBDPPJJHC == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("</i>");
			return;
		}
		if (GIHIPEOBPBF == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("abouttitle");
			return;
		}
		if (KGKMPHJMKMG == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("Starting parallel download:");
			return;
		}
		if (this.thumbnailType == PLPHEPDHPJJ.square)
		{
			this.productTitleText.SetText(GIHIPEOBPBF.EDGJELLBBFD(), true);
			if (LLHBDPPJJHC.OHCDIAFPNFK.LPKLANAEIFF() == 1)
			{
				this.bannerText.SetText(CCOJBMMKNAP.JMNIGPHCAEJ().DNILNCLIHAP("\""), false);
				this.banner.SetActive(false);
			}
			else
			{
				this.banner.SetActive(false);
				this.bannerText.SetText(CCOJBMMKNAP.GIOAFDDKKHI().FCOCLEHKLDJ("success"), false);
			}
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteWide;
		}
		else
		{
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteSquare;
		}
		if (LLHBDPPJJHC.MLNOFEEIBMI.HOJDOEDDIBD() > 0)
		{
			this.salesObject.SetActive(true);
			this.salesText.SetText("p" + LLHBDPPJJHC.MLNOFEEIBMI.ToString() + "yes", true);
		}
		else
		{
			this.salesObject.SetActive(false);
		}
		if (LLHBDPPJJHC.ODMKLADKHMO.CJLDJAJHMMA() > 1)
		{
			this.hardCurrencyIcon.SetActive(true);
			this.hardCurrencyAmountText.gameObject.SetActive(true);
			this.hardCurrencyAmountText.SetText(LLHBDPPJJHC.ODMKLADKHMO.ToString(), false);
		}
		else
		{
			this.hardCurrencyIcon.SetActive(false);
			this.hardCurrencyAmountText.gameObject.SetActive(true);
		}
		if (LLHBDPPJJHC.MPMKMCJFHOG.KGEGKPHEMOJ() > 1)
		{
			this.energyIcon.SetActive(true);
			this.energyAmountText.gameObject.SetActive(false);
			this.energyAmountText.SetText(LLHBDPPJJHC.MPMKMCJFHOG.ToString(), true);
		}
		else
		{
			this.energyIcon.SetActive(true);
			this.energyAmountText.gameObject.SetActive(true);
		}
		if (this.JIEBEFKGJIM.OKGPIEEOKBM())
		{
			this.pricingText.SetText(this.JIEBEFKGJIM.FNJCEPLEPBH(), true);
			return;
		}
		if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.ru && GeoLocationManager.PBAGPDDBABB())
		{
			this.pricingText.SetText("Critical error. Missing story header!" + this.JIEBEFKGJIM.JKBLBOAHJDE, false);
			return;
		}
		this.pricingText.SetText("releaseTimeline" + this.JIEBEFKGJIM.DMODNDCLGEJ, true);
	}

	// Token: 0x06007487 RID: 29831 RVA: 0x00342B50 File Offset: 0x00340D50
	public void PCHEAMPLEMG()
	{
		ProductThumbnailManager.lastAccessedProductWebLink = this.JIEBEFKGJIM.DJJCDNDMAGD() + "rt" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.en && GeoLocationManager.CELPCHNPBHH() && KDCJJBLGCBH.EHBBFMCILPC.EAMJBDKCDPA())
		{
			CommonUserInterface.EHBBFMCILPC.ShowPopupOnlineResources(this.JIEBEFKGJIM.DJJCDNDMAGD() + "plc" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 8);
			return;
		}
		this.MDLICPCMOAE.GAAMAOLMOPA(this.JIEBEFKGJIM.DEJCCBNPFEC);
	}

	// Token: 0x06007488 RID: 29832 RVA: 0x00342BE4 File Offset: 0x00340DE4
	public void GLIFGDPDMNC(PurchasingViewManager DDIPMIKIBJC, OCBIOPOEENJ LLHBDPPJJHC, OBHDGKFFICI GIHIPEOBPBF, ProducThumbnailGraphics KGKMPHJMKMG)
	{
		this.JIEBEFKGJIM = LLHBDPPJJHC;
		this.MDLICPCMOAE = DDIPMIKIBJC;
		if (LLHBDPPJJHC == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("InitTopMatchDataLocal()");
			return;
		}
		if (GIHIPEOBPBF == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("</i>.");
			return;
		}
		if (KGKMPHJMKMG == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("Request type: FIRST_OPEN_REQUEST");
			return;
		}
		if (this.thumbnailType == PLPHEPDHPJJ.wide)
		{
			this.productTitleText.SetText(GIHIPEOBPBF.CCFCCOCCKMP(), true);
			if (LLHBDPPJJHC.OHCDIAFPNFK.BADNAGEMINF() == 0)
			{
				this.bannerText.SetText(CCOJBMMKNAP.JMDJPKKOHNI().GLEFEKBDHNK("OnStoryInterfaceHeaderShown"), false);
				this.banner.SetActive(false);
			}
			else
			{
				this.banner.SetActive(true);
				this.bannerText.SetText(CCOJBMMKNAP.DLGLFACMHPG().HIPJILDCHJC("OnFriendsCurrencyPopupCollect"), false);
			}
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteWide;
		}
		else
		{
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteSquare;
		}
		if (LLHBDPPJJHC.MLNOFEEIBMI.PONAPMOOLIN() > 0)
		{
			this.salesObject.SetActive(true);
			this.salesText.SetText("fvrt" + LLHBDPPJJHC.MLNOFEEIBMI.ToString() + "per", true);
		}
		else
		{
			this.salesObject.SetActive(false);
		}
		if (LLHBDPPJJHC.ODMKLADKHMO.BFMPOACOBPN() > 0)
		{
			this.hardCurrencyIcon.SetActive(false);
			this.hardCurrencyAmountText.gameObject.SetActive(false);
			this.hardCurrencyAmountText.SetText(LLHBDPPJJHC.ODMKLADKHMO.ToString(), false);
		}
		else
		{
			this.hardCurrencyIcon.SetActive(true);
			this.hardCurrencyAmountText.gameObject.SetActive(true);
		}
		if (LLHBDPPJJHC.MPMKMCJFHOG.KGEGKPHEMOJ() > 0)
		{
			this.energyIcon.SetActive(false);
			this.energyAmountText.gameObject.SetActive(false);
			this.energyAmountText.SetText(LLHBDPPJJHC.MPMKMCJFHOG.ToString(), true);
		}
		else
		{
			this.energyIcon.SetActive(true);
			this.energyAmountText.gameObject.SetActive(false);
		}
		if (this.JIEBEFKGJIM.OKGPIEEOKBM())
		{
			this.pricingText.SetText(this.JIEBEFKGJIM.ILAPDGNDFGC(), true);
			return;
		}
		if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.en && GeoLocationManager.IsRussia())
		{
			this.pricingText.SetText("not" + this.JIEBEFKGJIM.JKBLBOAHJDE, true);
			return;
		}
		this.pricingText.SetText("Back environment has been destroyed according to lounge data:" + this.JIEBEFKGJIM.DMODNDCLGEJ, false);
	}

	// Token: 0x06007489 RID: 29833 RVA: 0x00342E58 File Offset: 0x00341058
	public void APCBKOGALLK(PurchasingViewManager DDIPMIKIBJC, OCBIOPOEENJ LLHBDPPJJHC, OBHDGKFFICI GIHIPEOBPBF, ProducThumbnailGraphics KGKMPHJMKMG)
	{
		this.JIEBEFKGJIM = LLHBDPPJJHC;
		this.MDLICPCMOAE = DDIPMIKIBJC;
		if (LLHBDPPJJHC == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("");
			return;
		}
		if (GIHIPEOBPBF == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("frdelpid");
			return;
		}
		if (KGKMPHJMKMG == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC(")");
			return;
		}
		if (this.thumbnailType == PLPHEPDHPJJ.square)
		{
			this.productTitleText.SetText(GIHIPEOBPBF.NBLJKFPELMC(), false);
			if (LLHBDPPJJHC.OHCDIAFPNFK.BFMPOACOBPN() == 1)
			{
				this.bannerText.SetText(CCOJBMMKNAP.DLGLFACMHPG().PPALCPINPLK("onboardingthankyoutitle"), false);
				this.banner.SetActive(false);
			}
			else
			{
				this.banner.SetActive(true);
				this.bannerText.SetText(CCOJBMMKNAP.COKDLDOAACJ().FIENAKIHNOM("ind"), false);
			}
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteWide;
		}
		else
		{
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteSquare;
		}
		if (LLHBDPPJJHC.MLNOFEEIBMI.PONAPMOOLIN() > 0)
		{
			this.salesObject.SetActive(true);
			this.salesText.SetText("" + LLHBDPPJJHC.MLNOFEEIBMI.ToString() + "Purchases fetch failed message: {0}, reason: {1}", true);
		}
		else
		{
			this.salesObject.SetActive(true);
		}
		if (LLHBDPPJJHC.ODMKLADKHMO.NPEOEAFOPJP() > 0)
		{
			this.hardCurrencyIcon.SetActive(false);
			this.hardCurrencyAmountText.gameObject.SetActive(false);
			this.hardCurrencyAmountText.SetText(LLHBDPPJJHC.ODMKLADKHMO.ToString(), false);
		}
		else
		{
			this.hardCurrencyIcon.SetActive(true);
			this.hardCurrencyAmountText.gameObject.SetActive(false);
		}
		if (LLHBDPPJJHC.MPMKMCJFHOG.HOJDOEDDIBD() > 1)
		{
			this.energyIcon.SetActive(true);
			this.energyAmountText.gameObject.SetActive(false);
			this.energyAmountText.SetText(LLHBDPPJJHC.MPMKMCJFHOG.ToString(), false);
		}
		else
		{
			this.energyIcon.SetActive(false);
			this.energyAmountText.gameObject.SetActive(false);
		}
		if (this.JIEBEFKGJIM.IMKLGJBEMPH())
		{
			this.pricingText.SetText(this.JIEBEFKGJIM.DOLEPIMNJLG(), false);
			return;
		}
		if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.ru && GeoLocationManager.PBAGPDDBABB())
		{
			this.pricingText.SetText("splash" + this.JIEBEFKGJIM.JKBLBOAHJDE, false);
			return;
		}
		this.pricingText.SetText("FlagMesh" + this.JIEBEFKGJIM.DMODNDCLGEJ, true);
	}

	// Token: 0x0600748A RID: 29834 RVA: 0x003430CC File Offset: 0x003412CC
	public void OELJOHCNBGK(PurchasingViewManager DDIPMIKIBJC, OCBIOPOEENJ LLHBDPPJJHC, OBHDGKFFICI GIHIPEOBPBF, ProducThumbnailGraphics KGKMPHJMKMG)
	{
		this.JIEBEFKGJIM = LLHBDPPJJHC;
		this.MDLICPCMOAE = DDIPMIKIBJC;
		if (LLHBDPPJJHC == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("</b>");
			return;
		}
		if (GIHIPEOBPBF == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("OnBackendPremiumChoiceException");
			return;
		}
		if (KGKMPHJMKMG == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("mystoriespattern");
			return;
		}
		if (this.thumbnailType == PLPHEPDHPJJ.square)
		{
			this.productTitleText.SetText(GIHIPEOBPBF.DKFACKEAOAL(), false);
			if (LLHBDPPJJHC.OHCDIAFPNFK.CJLDJAJHMMA() == 0)
			{
				this.bannerText.SetText(CCOJBMMKNAP.HEDIEIICOOG().FCOCLEHKLDJ("assetbundlepurchasingview"), true);
				this.banner.SetActive(true);
			}
			else
			{
				this.banner.SetActive(true);
				this.bannerText.SetText(CCOJBMMKNAP.DBFFFOMCLKM().IKMNGFIDCLM("pass"), true);
			}
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteWide;
		}
		else
		{
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteSquare;
		}
		if (LLHBDPPJJHC.MLNOFEEIBMI.MDJHNAEGCCM() > 0)
		{
			this.salesObject.SetActive(false);
			this.salesText.SetText("importanttitle" + LLHBDPPJJHC.MLNOFEEIBMI.ToString() + "+", true);
		}
		else
		{
			this.salesObject.SetActive(false);
		}
		if (LLHBDPPJJHC.ODMKLADKHMO.MDJHNAEGCCM() > 0)
		{
			this.hardCurrencyIcon.SetActive(true);
			this.hardCurrencyAmountText.gameObject.SetActive(false);
			this.hardCurrencyAmountText.SetText(LLHBDPPJJHC.ODMKLADKHMO.ToString(), true);
		}
		else
		{
			this.hardCurrencyIcon.SetActive(false);
			this.hardCurrencyAmountText.gameObject.SetActive(false);
		}
		if (LLHBDPPJJHC.MPMKMCJFHOG.HOJDOEDDIBD() > 1)
		{
			this.energyIcon.SetActive(false);
			this.energyAmountText.gameObject.SetActive(false);
			this.energyAmountText.SetText(LLHBDPPJJHC.MPMKMCJFHOG.ToString(), true);
		}
		else
		{
			this.energyIcon.SetActive(false);
			this.energyAmountText.gameObject.SetActive(false);
		}
		if (this.JIEBEFKGJIM.OKGPIEEOKBM())
		{
			this.pricingText.SetText(this.JIEBEFKGJIM.FNJCEPLEPBH(), true);
			return;
		}
		if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.ru && GeoLocationManager.FHINOKNBJPM())
		{
			this.pricingText.SetText("lititle" + this.JIEBEFKGJIM.JKBLBOAHJDE, false);
			return;
		}
		this.pricingText.SetText("OnFriendsSearchClearFilter" + this.JIEBEFKGJIM.DMODNDCLGEJ, false);
	}

	// Token: 0x0600748B RID: 29835 RVA: 0x00343340 File Offset: 0x00341540
	public void DFFMNJDFNJG(PurchasingViewManager DDIPMIKIBJC, OCBIOPOEENJ LLHBDPPJJHC, OBHDGKFFICI GIHIPEOBPBF, ProducThumbnailGraphics KGKMPHJMKMG)
	{
		this.JIEBEFKGJIM = LLHBDPPJJHC;
		this.MDLICPCMOAE = DDIPMIKIBJC;
		if (LLHBDPPJJHC == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("OnChoiceExtendedPanelSlideShownComplete");
			return;
		}
		if (GIHIPEOBPBF == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC(" not found, replacing with ");
			return;
		}
		if (KGKMPHJMKMG == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("assetStoryNpcOffsets");
			return;
		}
		if (this.thumbnailType == PLPHEPDHPJJ.wide)
		{
			this.productTitleText.SetText(GIHIPEOBPBF.EDGJELLBBFD(), true);
			if (LLHBDPPJJHC.OHCDIAFPNFK.KGEGKPHEMOJ() == 0)
			{
				this.bannerText.SetText(CCOJBMMKNAP.OEPENBHJAHO().PPALCPINPLK("<b>"), true);
				this.banner.SetActive(true);
			}
			else
			{
				this.banner.SetActive(false);
				this.bannerText.SetText(CCOJBMMKNAP.HEDIEIICOOG().MEPECBDCOLG("drft"), false);
			}
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteWide;
		}
		else
		{
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteSquare;
		}
		if (LLHBDPPJJHC.MLNOFEEIBMI.PONAPMOOLIN() > 0)
		{
			this.salesObject.SetActive(false);
			this.salesText.SetText("OnBackendInitiateSteamTransactionSuccess" + LLHBDPPJJHC.MLNOFEEIBMI.ToString() + "...", false);
		}
		else
		{
			this.salesObject.SetActive(true);
		}
		if (LLHBDPPJJHC.ODMKLADKHMO.BADNAGEMINF() > 0)
		{
			this.hardCurrencyIcon.SetActive(false);
			this.hardCurrencyAmountText.gameObject.SetActive(true);
			this.hardCurrencyAmountText.SetText(LLHBDPPJJHC.ODMKLADKHMO.ToString(), true);
		}
		else
		{
			this.hardCurrencyIcon.SetActive(false);
			this.hardCurrencyAmountText.gameObject.SetActive(false);
		}
		if (LLHBDPPJJHC.MPMKMCJFHOG.PONAPMOOLIN() > 1)
		{
			this.energyIcon.SetActive(false);
			this.energyAmountText.gameObject.SetActive(true);
			this.energyAmountText.SetText(LLHBDPPJJHC.MPMKMCJFHOG.ToString(), false);
		}
		else
		{
			this.energyIcon.SetActive(true);
			this.energyAmountText.gameObject.SetActive(false);
		}
		if (this.JIEBEFKGJIM.OKGPIEEOKBM())
		{
			this.pricingText.SetText(this.JIEBEFKGJIM.FNJCEPLEPBH(), false);
			return;
		}
		if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.en && GeoLocationManager.FDJONIACJKC())
		{
			this.pricingText.SetText("OnBackendValidateTransactionException" + this.JIEBEFKGJIM.JKBLBOAHJDE, true);
			return;
		}
		this.pricingText.SetText("importanttitle" + this.JIEBEFKGJIM.DMODNDCLGEJ, true);
	}

	// Token: 0x0600748C RID: 29836 RVA: 0x003435B4 File Offset: 0x003417B4
	public void HMLDNAIMKJH()
	{
		ProductThumbnailManager.lastAccessedProductWebLink = this.JIEBEFKGJIM.DJJCDNDMAGD() + "Environment layer has been destroyed according to on demand data:" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.ru && GeoLocationManager.NHMHNIFIOCO() && KDCJJBLGCBH.EHBBFMCILPC.EAMJBDKCDPA())
		{
			CommonUserInterface.EHBBFMCILPC.ShowPopupOnlineResources(this.JIEBEFKGJIM.MBLAIKOOCFH() + "wind" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 4);
			return;
		}
		this.MDLICPCMOAE.PurchaseProduct(this.JIEBEFKGJIM.DEJCCBNPFEC);
	}

	// Token: 0x0600748D RID: 29837 RVA: 0x00343648 File Offset: 0x00341848
	public void LAHANHLEILM()
	{
		ProductThumbnailManager.lastAccessedProductWebLink = this.JIEBEFKGJIM.DJJCDNDMAGD() + "per" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.ru && GeoLocationManager.PBAGPDDBABB() && KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA())
		{
			CommonUserInterface.IKNOFBFMPGA().GIFCDFKBBCN(this.JIEBEFKGJIM.MBLAIKOOCFH() + "assetbundleitemanimationpack" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 1);
			return;
		}
		this.MDLICPCMOAE.GAAMAOLMOPA(this.JIEBEFKGJIM.DEJCCBNPFEC);
	}

	// Token: 0x0600748E RID: 29838 RVA: 0x003436DC File Offset: 0x003418DC
	public void NDACAKGFEFP(PurchasingViewManager DDIPMIKIBJC, OCBIOPOEENJ LLHBDPPJJHC, OBHDGKFFICI GIHIPEOBPBF, ProducThumbnailGraphics KGKMPHJMKMG)
	{
		this.JIEBEFKGJIM = LLHBDPPJJHC;
		this.MDLICPCMOAE = DDIPMIKIBJC;
		if (LLHBDPPJJHC == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("OnFullscreenCardOptionClick");
			return;
		}
		if (GIHIPEOBPBF == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("OnPopupProfileSaveCutsceneInputEndEdit");
			return;
		}
		if (KGKMPHJMKMG == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("timeoutwarning");
			return;
		}
		if (this.thumbnailType == PLPHEPDHPJJ.wide)
		{
			this.productTitleText.SetText(GIHIPEOBPBF.EDGJELLBBFD(), false);
			if (LLHBDPPJJHC.OHCDIAFPNFK.LPKLANAEIFF() == 0)
			{
				this.bannerText.SetText(CCOJBMMKNAP.ONCPHEEJLOP().HDIPNMFHIEJ("Starting parallel download:"), false);
				this.banner.SetActive(false);
			}
			else
			{
				this.banner.SetActive(false);
				this.bannerText.SetText(CCOJBMMKNAP.KFAABHHGOPO().MEPECBDCOLG("xx"), false);
			}
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteWide;
		}
		else
		{
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteSquare;
		}
		if (LLHBDPPJJHC.MLNOFEEIBMI.HOJDOEDDIBD() > 1)
		{
			this.salesObject.SetActive(false);
			this.salesText.SetText("sketchtitles" + LLHBDPPJJHC.MLNOFEEIBMI.ToString() + "", true);
		}
		else
		{
			this.salesObject.SetActive(true);
		}
		if (LLHBDPPJJHC.ODMKLADKHMO.DPLHPBMJAPJ() > 1)
		{
			this.hardCurrencyIcon.SetActive(false);
			this.hardCurrencyAmountText.gameObject.SetActive(false);
			this.hardCurrencyAmountText.SetText(LLHBDPPJJHC.ODMKLADKHMO.ToString(), true);
		}
		else
		{
			this.hardCurrencyIcon.SetActive(false);
			this.hardCurrencyAmountText.gameObject.SetActive(true);
		}
		if (LLHBDPPJJHC.MPMKMCJFHOG.GALKFKBPLCK() > 1)
		{
			this.energyIcon.SetActive(true);
			this.energyAmountText.gameObject.SetActive(true);
			this.energyAmountText.SetText(LLHBDPPJJHC.MPMKMCJFHOG.ToString(), true);
		}
		else
		{
			this.energyIcon.SetActive(true);
			this.energyAmountText.gameObject.SetActive(false);
		}
		if (this.JIEBEFKGJIM.OKGPIEEOKBM())
		{
			this.pricingText.SetText(this.JIEBEFKGJIM.DOLEPIMNJLG(), false);
			return;
		}
		if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.en && GeoLocationManager.IsRussia())
		{
			this.pricingText.SetText("[LoadingEnv] " + this.JIEBEFKGJIM.JKBLBOAHJDE, false);
			return;
		}
		this.pricingText.SetText(" (" + this.JIEBEFKGJIM.DMODNDCLGEJ, true);
	}

	// Token: 0x0600748F RID: 29839 RVA: 0x00343950 File Offset: 0x00341B50
	public void JDIAILMECKC(PurchasingViewManager DDIPMIKIBJC, OCBIOPOEENJ LLHBDPPJJHC, OBHDGKFFICI GIHIPEOBPBF, ProducThumbnailGraphics KGKMPHJMKMG)
	{
		this.JIEBEFKGJIM = LLHBDPPJJHC;
		this.MDLICPCMOAE = DDIPMIKIBJC;
		if (LLHBDPPJJHC == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("',PurchaseFailureReason: ");
			return;
		}
		if (GIHIPEOBPBF == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("rewardtitle");
			return;
		}
		if (KGKMPHJMKMG == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("loungetreasuresyouhave");
			return;
		}
		if (this.thumbnailType == PLPHEPDHPJJ.wide)
		{
			this.productTitleText.SetText(GIHIPEOBPBF.MIOAONHIGPA(), true);
			if (LLHBDPPJJHC.OHCDIAFPNFK.PONAPMOOLIN() == 1)
			{
				this.bannerText.SetText(CCOJBMMKNAP.HJGDLOOHNLO().MEPECBDCOLG(""), false);
				this.banner.SetActive(false);
			}
			else
			{
				this.banner.SetActive(true);
				this.bannerText.SetText(CCOJBMMKNAP.DLGLFACMHPG().HDIPNMFHIEJ("StoriesSearchRanker: nothing to search (anthologies "), false);
			}
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteWide;
		}
		else
		{
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteSquare;
		}
		if (LLHBDPPJJHC.MLNOFEEIBMI.NPEOEAFOPJP() > 0)
		{
			this.salesObject.SetActive(true);
			this.salesText.SetText("OnFullscreenLiveOfferContinueToPurchasingScreen" + LLHBDPPJJHC.MLNOFEEIBMI.ToString() + "socialcollectedcardopenv2", true);
		}
		else
		{
			this.salesObject.SetActive(false);
		}
		if (LLHBDPPJJHC.ODMKLADKHMO.BADNAGEMINF() > 0)
		{
			this.hardCurrencyIcon.SetActive(false);
			this.hardCurrencyAmountText.gameObject.SetActive(true);
			this.hardCurrencyAmountText.SetText(LLHBDPPJJHC.ODMKLADKHMO.ToString(), false);
		}
		else
		{
			this.hardCurrencyIcon.SetActive(true);
			this.hardCurrencyAmountText.gameObject.SetActive(true);
		}
		if (LLHBDPPJJHC.MPMKMCJFHOG.CJLDJAJHMMA() > 1)
		{
			this.energyIcon.SetActive(false);
			this.energyAmountText.gameObject.SetActive(true);
			this.energyAmountText.SetText(LLHBDPPJJHC.MPMKMCJFHOG.ToString(), true);
		}
		else
		{
			this.energyIcon.SetActive(false);
			this.energyAmountText.gameObject.SetActive(false);
		}
		if (this.JIEBEFKGJIM.HHALLBOKCJO())
		{
			this.pricingText.SetText(this.JIEBEFKGJIM.FNJCEPLEPBH(), true);
			return;
		}
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.en && GeoLocationManager.FHINOKNBJPM())
		{
			this.pricingText.SetText("shnts" + this.JIEBEFKGJIM.JKBLBOAHJDE, false);
			return;
		}
		this.pricingText.SetText("savetocloudbtn" + this.JIEBEFKGJIM.DMODNDCLGEJ, false);
	}

	// Token: 0x06007490 RID: 29840 RVA: 0x00343BC4 File Offset: 0x00341DC4
	public void CDAMEAIIKMG(PurchasingViewManager DDIPMIKIBJC, OCBIOPOEENJ LLHBDPPJJHC, OBHDGKFFICI GIHIPEOBPBF, ProducThumbnailGraphics KGKMPHJMKMG)
	{
		this.JIEBEFKGJIM = LLHBDPPJJHC;
		this.MDLICPCMOAE = DDIPMIKIBJC;
		if (LLHBDPPJJHC == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("importanttitle");
			return;
		}
		if (GIHIPEOBPBF == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("OnBackendGetIncentRewardAdException");
			return;
		}
		if (KGKMPHJMKMG == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("p");
			return;
		}
		if (this.thumbnailType == PLPHEPDHPJJ.wide)
		{
			this.productTitleText.SetText(GIHIPEOBPBF.IDCKEOKPCHB(), true);
			if (LLHBDPPJJHC.OHCDIAFPNFK.DPLHPBMJAPJ() == 0)
			{
				this.bannerText.SetText(CCOJBMMKNAP.COKDLDOAACJ().JHNELLJFBGC(""), true);
				this.banner.SetActive(true);
			}
			else
			{
				this.banner.SetActive(true);
				this.bannerText.SetText(CCOJBMMKNAP.EAIAHCBAIEJ().FCOCLEHKLDJ("Avatar pack has been SKIPPED:"), true);
			}
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteWide;
		}
		else
		{
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteSquare;
		}
		if (LLHBDPPJJHC.MLNOFEEIBMI.LPKLANAEIFF() > 1)
		{
			this.salesObject.SetActive(false);
			this.salesText.SetText("Asset bundle assets destroyed:" + LLHBDPPJJHC.MLNOFEEIBMI.ToString() + "[Lounge] $SKINAPPLIED: no mapping row with shop index ", true);
		}
		else
		{
			this.salesObject.SetActive(true);
		}
		if (LLHBDPPJJHC.ODMKLADKHMO.GALKFKBPLCK() > 0)
		{
			this.hardCurrencyIcon.SetActive(true);
			this.hardCurrencyAmountText.gameObject.SetActive(true);
			this.hardCurrencyAmountText.SetText(LLHBDPPJJHC.ODMKLADKHMO.ToString(), true);
		}
		else
		{
			this.hardCurrencyIcon.SetActive(true);
			this.hardCurrencyAmountText.gameObject.SetActive(false);
		}
		if (LLHBDPPJJHC.MPMKMCJFHOG.BADNAGEMINF() > 1)
		{
			this.energyIcon.SetActive(true);
			this.energyAmountText.gameObject.SetActive(true);
			this.energyAmountText.SetText(LLHBDPPJJHC.MPMKMCJFHOG.ToString(), false);
		}
		else
		{
			this.energyIcon.SetActive(true);
			this.energyAmountText.gameObject.SetActive(false);
		}
		if (this.JIEBEFKGJIM.HHALLBOKCJO())
		{
			this.pricingText.SetText(this.JIEBEFKGJIM.PKNNPAMOADM(), true);
			return;
		}
		if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.en && GeoLocationManager.NHMHNIFIOCO())
		{
			this.pricingText.SetText("OnSketchViewShowWI" + this.JIEBEFKGJIM.JKBLBOAHJDE, true);
			return;
		}
		this.pricingText.SetText("tutrecommbody" + this.JIEBEFKGJIM.DMODNDCLGEJ, false);
	}

	// Token: 0x06007491 RID: 29841 RVA: 0x00343E38 File Offset: 0x00342038
	public void HJJCIKIJBLN()
	{
		ProductThumbnailManager.lastAccessedProductWebLink = this.JIEBEFKGJIM.FDMCFAHEELN() + "OnGamePassRefillSuccess" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.en && GeoLocationManager.IsRussia() && KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA())
		{
			CommonUserInterface.EHBBFMCILPC.GIFCDFKBBCN(this.JIEBEFKGJIM.FDMCFAHEELN() + "" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 8);
			return;
		}
		this.MDLICPCMOAE.GAAMAOLMOPA(this.JIEBEFKGJIM.DEJCCBNPFEC);
	}

	// Token: 0x06007492 RID: 29842 RVA: 0x00343ECC File Offset: 0x003420CC
	public void ANCCDBCNCFJ()
	{
		ProductThumbnailManager.lastAccessedProductWebLink = this.JIEBEFKGJIM.MBLAIKOOCFH() + "StorySaveBody.GetAvatarsSnapshotsCountWardrobe(), unsupported wardrobe index:" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.en && GeoLocationManager.NHMHNIFIOCO() && KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA())
		{
			CommonUserInterface.IKNOFBFMPGA().GIFCDFKBBCN(this.JIEBEFKGJIM.DJJCDNDMAGD() + "oldvhs" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 6);
			return;
		}
		this.MDLICPCMOAE.IFCOMCGDBLF(this.JIEBEFKGJIM.DEJCCBNPFEC);
	}

	// Token: 0x06007493 RID: 29843 RVA: 0x00343F60 File Offset: 0x00342160
	public void LPJCNKJFKJI(PurchasingViewManager DDIPMIKIBJC, OCBIOPOEENJ LLHBDPPJJHC, OBHDGKFFICI GIHIPEOBPBF, ProducThumbnailGraphics KGKMPHJMKMG)
	{
		this.JIEBEFKGJIM = LLHBDPPJJHC;
		this.MDLICPCMOAE = DDIPMIKIBJC;
		if (LLHBDPPJJHC == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("\n<alpha=#C0>...\n");
			return;
		}
		if (GIHIPEOBPBF == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC(" ");
			return;
		}
		if (KGKMPHJMKMG == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("flip_down");
			return;
		}
		if (this.thumbnailType == PLPHEPDHPJJ.square)
		{
			this.productTitleText.SetText(GIHIPEOBPBF.FIANHBCHALB(), true);
			if (LLHBDPPJJHC.OHCDIAFPNFK.HOJDOEDDIBD() == 0)
			{
				this.bannerText.SetText(CCOJBMMKNAP.KLAKLFCOMJC().JCDFHKDNEDH(""), false);
				this.banner.SetActive(false);
			}
			else
			{
				this.banner.SetActive(false);
				this.bannerText.SetText(CCOJBMMKNAP.PKEINLPIAEH().MEPECBDCOLG("〈"), true);
			}
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteWide;
		}
		else
		{
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteSquare;
		}
		if (LLHBDPPJJHC.MLNOFEEIBMI.MOBKGNBCIJF() > 0)
		{
			this.salesObject.SetActive(true);
			this.salesText.SetText("avatarcollectionstutor0body" + LLHBDPPJJHC.MLNOFEEIBMI.ToString() + "bver", false);
		}
		else
		{
			this.salesObject.SetActive(true);
		}
		if (LLHBDPPJJHC.ODMKLADKHMO.BADNAGEMINF() > 0)
		{
			this.hardCurrencyIcon.SetActive(true);
			this.hardCurrencyAmountText.gameObject.SetActive(false);
			this.hardCurrencyAmountText.SetText(LLHBDPPJJHC.ODMKLADKHMO.ToString(), false);
		}
		else
		{
			this.hardCurrencyIcon.SetActive(true);
			this.hardCurrencyAmountText.gameObject.SetActive(false);
		}
		if (LLHBDPPJJHC.MPMKMCJFHOG.BFMPOACOBPN() > 0)
		{
			this.energyIcon.SetActive(false);
			this.energyAmountText.gameObject.SetActive(true);
			this.energyAmountText.SetText(LLHBDPPJJHC.MPMKMCJFHOG.ToString(), true);
		}
		else
		{
			this.energyIcon.SetActive(true);
			this.energyAmountText.gameObject.SetActive(false);
		}
		if (this.JIEBEFKGJIM.OKGPIEEOKBM())
		{
			this.pricingText.SetText(this.JIEBEFKGJIM.PKNNPAMOADM(), true);
			return;
		}
		if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.en && GeoLocationManager.NHMHNIFIOCO())
		{
			this.pricingText.SetText("sshits" + this.JIEBEFKGJIM.JKBLBOAHJDE, true);
			return;
		}
		this.pricingText.SetText("OnSkinShopCardSelected" + this.JIEBEFKGJIM.DMODNDCLGEJ, true);
	}

	// Token: 0x06007494 RID: 29844 RVA: 0x003441D4 File Offset: 0x003423D4
	public void AJNNDKIIFDN(PurchasingViewManager DDIPMIKIBJC, OCBIOPOEENJ LLHBDPPJJHC, OBHDGKFFICI GIHIPEOBPBF, ProducThumbnailGraphics KGKMPHJMKMG)
	{
		this.JIEBEFKGJIM = LLHBDPPJJHC;
		this.MDLICPCMOAE = DDIPMIKIBJC;
		if (LLHBDPPJJHC == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("OnCutsceneViewAssetsDownloadFailed");
			return;
		}
		if (GIHIPEOBPBF == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("onneedtocompleteanthology");
			return;
		}
		if (KGKMPHJMKMG == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("AvatarCollectionsItem.OnAvatarCollectionSelect(): index out of range");
			return;
		}
		if (this.thumbnailType == PLPHEPDHPJJ.square)
		{
			this.productTitleText.SetText(GIHIPEOBPBF.GOBAACCPNLJ(), true);
			if (LLHBDPPJJHC.OHCDIAFPNFK.KGEGKPHEMOJ() == 1)
			{
				this.bannerText.SetText(CCOJBMMKNAP.HJGDLOOHNLO().PPALCPINPLK(""), false);
				this.banner.SetActive(true);
			}
			else
			{
				this.banner.SetActive(true);
				this.bannerText.SetText(CCOJBMMKNAP.PEBMGCKFNAO().OGKGHLHHAAI(" idf="), false);
			}
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteWide;
		}
		else
		{
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteSquare;
		}
		if (LLHBDPPJJHC.MLNOFEEIBMI.PONAPMOOLIN() > 1)
		{
			this.salesObject.SetActive(true);
			this.salesText.SetText("t" + LLHBDPPJJHC.MLNOFEEIBMI.ToString() + "continue", true);
		}
		else
		{
			this.salesObject.SetActive(false);
		}
		if (LLHBDPPJJHC.ODMKLADKHMO.LPKLANAEIFF() > 0)
		{
			this.hardCurrencyIcon.SetActive(false);
			this.hardCurrencyAmountText.gameObject.SetActive(false);
			this.hardCurrencyAmountText.SetText(LLHBDPPJJHC.ODMKLADKHMO.ToString(), true);
		}
		else
		{
			this.hardCurrencyIcon.SetActive(true);
			this.hardCurrencyAmountText.gameObject.SetActive(true);
		}
		if (LLHBDPPJJHC.MPMKMCJFHOG.BADNAGEMINF() > 0)
		{
			this.energyIcon.SetActive(false);
			this.energyAmountText.gameObject.SetActive(false);
			this.energyAmountText.SetText(LLHBDPPJJHC.MPMKMCJFHOG.ToString(), true);
		}
		else
		{
			this.energyIcon.SetActive(true);
			this.energyAmountText.gameObject.SetActive(true);
		}
		if (this.JIEBEFKGJIM.KIOLJNPKOOL())
		{
			this.pricingText.SetText(this.JIEBEFKGJIM.FNJCEPLEPBH(), false);
			return;
		}
		if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.ru && GeoLocationManager.OOCDLFJKLLI())
		{
			this.pricingText.SetText("=== RU FIREWALL === geo endpoint " + this.JIEBEFKGJIM.JKBLBOAHJDE, true);
			return;
		}
		this.pricingText.SetText("importanttitle" + this.JIEBEFKGJIM.DMODNDCLGEJ, false);
	}

	// Token: 0x06007495 RID: 29845 RVA: 0x00344448 File Offset: 0x00342648
	public void DGAFAPKAKIA(PurchasingViewManager DDIPMIKIBJC, OCBIOPOEENJ LLHBDPPJJHC, OBHDGKFFICI GIHIPEOBPBF, ProducThumbnailGraphics KGKMPHJMKMG)
	{
		this.JIEBEFKGJIM = LLHBDPPJJHC;
		this.MDLICPCMOAE = DDIPMIKIBJC;
		if (LLHBDPPJJHC == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("_BLEND_ADDITIVE");
			return;
		}
		if (GIHIPEOBPBF == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("retry");
			return;
		}
		if (KGKMPHJMKMG == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("Plate");
			return;
		}
		if (this.thumbnailType == PLPHEPDHPJJ.wide)
		{
			this.productTitleText.SetText(GIHIPEOBPBF.HGDBGIHOOPG(), false);
			if (LLHBDPPJJHC.OHCDIAFPNFK.GALKFKBPLCK() == 0)
			{
				this.bannerText.SetText(CCOJBMMKNAP.KMNBCEMEBBD().HHLECNIFHCO("cs"), true);
				this.banner.SetActive(true);
			}
			else
			{
				this.banner.SetActive(false);
				this.bannerText.SetText(CCOJBMMKNAP.PMABBOJDELF().HIPJILDCHJC(""), true);
			}
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteWide;
		}
		else
		{
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteSquare;
		}
		if (LLHBDPPJJHC.MLNOFEEIBMI.DPLHPBMJAPJ() > 0)
		{
			this.salesObject.SetActive(true);
			this.salesText.SetText("" + LLHBDPPJJHC.MLNOFEEIBMI.ToString() + "", true);
		}
		else
		{
			this.salesObject.SetActive(false);
		}
		if (LLHBDPPJJHC.ODMKLADKHMO.LPKLANAEIFF() > 1)
		{
			this.hardCurrencyIcon.SetActive(false);
			this.hardCurrencyAmountText.gameObject.SetActive(false);
			this.hardCurrencyAmountText.SetText(LLHBDPPJJHC.ODMKLADKHMO.ToString(), false);
		}
		else
		{
			this.hardCurrencyIcon.SetActive(false);
			this.hardCurrencyAmountText.gameObject.SetActive(false);
		}
		if (LLHBDPPJJHC.MPMKMCJFHOG.GALKFKBPLCK() > 1)
		{
			this.energyIcon.SetActive(true);
			this.energyAmountText.gameObject.SetActive(true);
			this.energyAmountText.SetText(LLHBDPPJJHC.MPMKMCJFHOG.ToString(), true);
		}
		else
		{
			this.energyIcon.SetActive(false);
			this.energyAmountText.gameObject.SetActive(true);
		}
		if (this.JIEBEFKGJIM.IMKLGJBEMPH())
		{
			this.pricingText.SetText(this.JIEBEFKGJIM.FNJCEPLEPBH(), false);
			return;
		}
		if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.en && GeoLocationManager.FHINOKNBJPM())
		{
			this.pricingText.SetText("OnRewardFreePassPlayStore" + this.JIEBEFKGJIM.JKBLBOAHJDE, false);
			return;
		}
		this.pricingText.SetText("" + this.JIEBEFKGJIM.DMODNDCLGEJ, true);
	}

	// Token: 0x06007496 RID: 29846 RVA: 0x003446BC File Offset: 0x003428BC
	public void JLNJLLJMOEJ()
	{
		ProductThumbnailManager.lastAccessedProductWebLink = this.JIEBEFKGJIM.DJJCDNDMAGD() + "priceCurrencyCode" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.en && GeoLocationManager.FDJONIACJKC() && KDCJJBLGCBH.EHBBFMCILPC.EAMJBDKCDPA())
		{
			CommonUserInterface.IKNOFBFMPGA().DPJBIGPDLMB(this.JIEBEFKGJIM.BIKJFCLHPBK() + "socialprivatenofriendsadd" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 7);
			return;
		}
		this.MDLICPCMOAE.GAAMAOLMOPA(this.JIEBEFKGJIM.DEJCCBNPFEC);
	}

	// Token: 0x06007497 RID: 29847 RVA: 0x00344750 File Offset: 0x00342950
	public void IKAPHFOLGGG()
	{
		ProductThumbnailManager.lastAccessedProductWebLink = this.JIEBEFKGJIM.MBLAIKOOCFH() + "dsec" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.ru && GeoLocationManager.FDJONIACJKC() && KDCJJBLGCBH.EHBBFMCILPC.EAMJBDKCDPA())
		{
			CommonUserInterface.EHBBFMCILPC.ShowPopupOnlineResources(this.JIEBEFKGJIM.MBLAIKOOCFH() + "p" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 1);
			return;
		}
		this.MDLICPCMOAE.GAAMAOLMOPA(this.JIEBEFKGJIM.DEJCCBNPFEC);
	}

	// Token: 0x06007498 RID: 29848 RVA: 0x003447E4 File Offset: 0x003429E4
	public void FDCBDEIMBBF()
	{
		ProductThumbnailManager.lastAccessedProductWebLink = this.JIEBEFKGJIM.MBLAIKOOCFH() + "ilb" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru && GeoLocationManager.NHMHNIFIOCO() && KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA())
		{
			CommonUserInterface.EHBBFMCILPC.ShowPopupOnlineResources(this.JIEBEFKGJIM.BIKJFCLHPBK() + "StoryItemManager.Initialize() - _item is null." + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 1);
			return;
		}
		this.MDLICPCMOAE.IFCOMCGDBLF(this.JIEBEFKGJIM.DEJCCBNPFEC);
	}

	// Token: 0x06007499 RID: 29849 RVA: 0x00344878 File Offset: 0x00342A78
	public void MCOMCHOLOOO(PurchasingViewManager DDIPMIKIBJC, OCBIOPOEENJ LLHBDPPJJHC, OBHDGKFFICI GIHIPEOBPBF, ProducThumbnailGraphics KGKMPHJMKMG)
	{
		this.JIEBEFKGJIM = LLHBDPPJJHC;
		this.MDLICPCMOAE = DDIPMIKIBJC;
		if (LLHBDPPJJHC == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("PurchaseManagerUnity.SetState(). Changing manager state to:");
			return;
		}
		if (GIHIPEOBPBF == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("OnPopupRemoveAdsManagerContinueToPurchasingScreen");
			return;
		}
		if (KGKMPHJMKMG == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("p");
			return;
		}
		if (this.thumbnailType == PLPHEPDHPJJ.square)
		{
			this.productTitleText.SetText(GIHIPEOBPBF.FIANHBCHALB(), true);
			if (LLHBDPPJJHC.OHCDIAFPNFK.PONAPMOOLIN() == 1)
			{
				this.bannerText.SetText(CCOJBMMKNAP.EHBBFMCILPC.PPALCPINPLK("sketchtitles"), false);
				this.banner.SetActive(false);
			}
			else
			{
				this.banner.SetActive(true);
				this.bannerText.SetText(CCOJBMMKNAP.ILACPHFEDEP().IPEIONBNIPH(" barAvailable="), true);
			}
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteWide;
		}
		else
		{
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteSquare;
		}
		if (LLHBDPPJJHC.MLNOFEEIBMI.MOBKGNBCIJF() > 1)
		{
			this.salesObject.SetActive(true);
			this.salesText.SetText("b_web" + LLHBDPPJJHC.MLNOFEEIBMI.ToString() + "Starting non-parallel download:", true);
		}
		else
		{
			this.salesObject.SetActive(true);
		}
		if (LLHBDPPJJHC.ODMKLADKHMO.MDJHNAEGCCM() > 1)
		{
			this.hardCurrencyIcon.SetActive(true);
			this.hardCurrencyAmountText.gameObject.SetActive(true);
			this.hardCurrencyAmountText.SetText(LLHBDPPJJHC.ODMKLADKHMO.ToString(), false);
		}
		else
		{
			this.hardCurrencyIcon.SetActive(true);
			this.hardCurrencyAmountText.gameObject.SetActive(false);
		}
		if (LLHBDPPJJHC.MPMKMCJFHOG.CJLDJAJHMMA() > 1)
		{
			this.energyIcon.SetActive(true);
			this.energyAmountText.gameObject.SetActive(false);
			this.energyAmountText.SetText(LLHBDPPJJHC.MPMKMCJFHOG.ToString(), false);
		}
		else
		{
			this.energyIcon.SetActive(false);
			this.energyAmountText.gameObject.SetActive(false);
		}
		if (this.JIEBEFKGJIM.HHALLBOKCJO())
		{
			this.pricingText.SetText(this.JIEBEFKGJIM.FNJCEPLEPBH(), false);
			return;
		}
		if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.en && GeoLocationManager.NHMHNIFIOCO())
		{
			this.pricingText.SetText("errortitle" + this.JIEBEFKGJIM.JKBLBOAHJDE, true);
			return;
		}
		this.pricingText.SetText("fruidres2" + this.JIEBEFKGJIM.DMODNDCLGEJ, true);
	}

	// Token: 0x0600749A RID: 29850 RVA: 0x00344AEC File Offset: 0x00342CEC
	public void CJFKKHMDKKK(PurchasingViewManager DDIPMIKIBJC, OCBIOPOEENJ LLHBDPPJJHC, OBHDGKFFICI GIHIPEOBPBF, ProducThumbnailGraphics KGKMPHJMKMG)
	{
		this.JIEBEFKGJIM = LLHBDPPJJHC;
		this.MDLICPCMOAE = DDIPMIKIBJC;
		if (LLHBDPPJJHC == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("aind");
			return;
		}
		if (GIHIPEOBPBF == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("ru");
			return;
		}
		if (KGKMPHJMKMG == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC(" ");
			return;
		}
		if (this.thumbnailType == PLPHEPDHPJJ.square)
		{
			this.productTitleText.SetText(GIHIPEOBPBF.FHEGGFAOECB(), false);
			if (LLHBDPPJJHC.OHCDIAFPNFK.NPEOEAFOPJP() == 1)
			{
				this.bannerText.SetText(CCOJBMMKNAP.ILACPHFEDEP().GLEFEKBDHNK("ZZZ"), false);
				this.banner.SetActive(false);
			}
			else
			{
				this.banner.SetActive(false);
				this.bannerText.SetText(CCOJBMMKNAP.ONCPHEEJLOP().PKNHKGMNCIP("acliffbw20"), true);
			}
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteWide;
		}
		else
		{
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteSquare;
		}
		if (LLHBDPPJJHC.MLNOFEEIBMI.BFMPOACOBPN() > 0)
		{
			this.salesObject.SetActive(true);
			this.salesText.SetText("\nENV:" + LLHBDPPJJHC.MLNOFEEIBMI.ToString() + "ok", true);
		}
		else
		{
			this.salesObject.SetActive(false);
		}
		if (LLHBDPPJJHC.ODMKLADKHMO.HOJDOEDDIBD() > 1)
		{
			this.hardCurrencyIcon.SetActive(true);
			this.hardCurrencyAmountText.gameObject.SetActive(true);
			this.hardCurrencyAmountText.SetText(LLHBDPPJJHC.ODMKLADKHMO.ToString(), true);
		}
		else
		{
			this.hardCurrencyIcon.SetActive(false);
			this.hardCurrencyAmountText.gameObject.SetActive(true);
		}
		if (LLHBDPPJJHC.MPMKMCJFHOG.BFMPOACOBPN() > 0)
		{
			this.energyIcon.SetActive(true);
			this.energyAmountText.gameObject.SetActive(false);
			this.energyAmountText.SetText(LLHBDPPJJHC.MPMKMCJFHOG.ToString(), true);
		}
		else
		{
			this.energyIcon.SetActive(true);
			this.energyAmountText.gameObject.SetActive(true);
		}
		if (this.JIEBEFKGJIM.KIOLJNPKOOL())
		{
			this.pricingText.SetText(this.JIEBEFKGJIM.ILAPDGNDFGC(), false);
			return;
		}
		if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.en && GeoLocationManager.FHINOKNBJPM())
		{
			this.pricingText.SetText("tradewishcardoption1" + this.JIEBEFKGJIM.JKBLBOAHJDE, false);
			return;
		}
		this.pricingText.SetText("/" + this.JIEBEFKGJIM.DMODNDCLGEJ, false);
	}

	// Token: 0x0600749B RID: 29851 RVA: 0x00344D60 File Offset: 0x00342F60
	public void BGLIAHEKACL(PurchasingViewManager DDIPMIKIBJC, OCBIOPOEENJ LLHBDPPJJHC, OBHDGKFFICI GIHIPEOBPBF, ProducThumbnailGraphics KGKMPHJMKMG)
	{
		this.JIEBEFKGJIM = LLHBDPPJJHC;
		this.MDLICPCMOAE = DDIPMIKIBJC;
		if (LLHBDPPJJHC == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("ok");
			return;
		}
		if (GIHIPEOBPBF == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("p");
			return;
		}
		if (KGKMPHJMKMG == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("asp");
			return;
		}
		if (this.thumbnailType == PLPHEPDHPJJ.square)
		{
			this.productTitleText.SetText(GIHIPEOBPBF.DCNGKBHDLIK(), false);
			if (LLHBDPPJJHC.OHCDIAFPNFK.MDJHNAEGCCM() == 1)
			{
				this.bannerText.SetText(CCOJBMMKNAP.DLGLFACMHPG().PGKBCNBAOJN("chsnapguid2"), true);
				this.banner.SetActive(false);
			}
			else
			{
				this.banner.SetActive(false);
				this.bannerText.SetText(CCOJBMMKNAP.OEPENBHJAHO().GGPHHLGPMPA("StoryChatManager.ShowMessage(), unsupported message type:"), false);
			}
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteWide;
		}
		else
		{
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteSquare;
		}
		if (LLHBDPPJJHC.MLNOFEEIBMI.PONAPMOOLIN() > 1)
		{
			this.salesObject.SetActive(true);
			this.salesText.SetText("top" + LLHBDPPJJHC.MLNOFEEIBMI.ToString() + "place", true);
		}
		else
		{
			this.salesObject.SetActive(true);
		}
		if (LLHBDPPJJHC.ODMKLADKHMO.BADNAGEMINF() > 1)
		{
			this.hardCurrencyIcon.SetActive(true);
			this.hardCurrencyAmountText.gameObject.SetActive(true);
			this.hardCurrencyAmountText.SetText(LLHBDPPJJHC.ODMKLADKHMO.ToString(), false);
		}
		else
		{
			this.hardCurrencyIcon.SetActive(false);
			this.hardCurrencyAmountText.gameObject.SetActive(true);
		}
		if (LLHBDPPJJHC.MPMKMCJFHOG.HOJDOEDDIBD() > 0)
		{
			this.energyIcon.SetActive(false);
			this.energyAmountText.gameObject.SetActive(false);
			this.energyAmountText.SetText(LLHBDPPJJHC.MPMKMCJFHOG.ToString(), false);
		}
		else
		{
			this.energyIcon.SetActive(false);
			this.energyAmountText.gameObject.SetActive(false);
		}
		if (this.JIEBEFKGJIM.OKGPIEEOKBM())
		{
			this.pricingText.SetText(this.JIEBEFKGJIM.DOLEPIMNJLG(), true);
			return;
		}
		if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.en && GeoLocationManager.CELPCHNPBHH())
		{
			this.pricingText.SetText("XXX" + this.JIEBEFKGJIM.JKBLBOAHJDE, false);
			return;
		}
		this.pricingText.SetText("avatarcollectionsuntitle" + this.JIEBEFKGJIM.DMODNDCLGEJ, true);
	}

	// Token: 0x0600749C RID: 29852 RVA: 0x00344FD4 File Offset: 0x003431D4
	public void JCBMIHMCJBJ()
	{
		ProductThumbnailManager.lastAccessedProductWebLink = this.JIEBEFKGJIM.FDMCFAHEELN() + "per" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.en && GeoLocationManager.NHMHNIFIOCO() && KDCJJBLGCBH.EHBBFMCILPC.EAMJBDKCDPA())
		{
			CommonUserInterface.IKNOFBFMPGA().GIFCDFKBBCN(this.JIEBEFKGJIM.MBLAIKOOCFH() + "_ScanLineJitter" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 3);
			return;
		}
		this.MDLICPCMOAE.GAAMAOLMOPA(this.JIEBEFKGJIM.DEJCCBNPFEC);
	}

	// Token: 0x0600749D RID: 29853 RVA: 0x00345068 File Offset: 0x00343268
	public void IMADGDGPBOB(PurchasingViewManager DDIPMIKIBJC, OCBIOPOEENJ LLHBDPPJJHC, OBHDGKFFICI GIHIPEOBPBF, ProducThumbnailGraphics KGKMPHJMKMG)
	{
		this.JIEBEFKGJIM = LLHBDPPJJHC;
		this.MDLICPCMOAE = DDIPMIKIBJC;
		if (LLHBDPPJJHC == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("itemstitle");
			return;
		}
		if (GIHIPEOBPBF == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("OnLanguageChange");
			return;
		}
		if (KGKMPHJMKMG == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("pid");
			return;
		}
		if (this.thumbnailType == PLPHEPDHPJJ.wide)
		{
			this.productTitleText.SetText(GIHIPEOBPBF.IDCKEOKPCHB(), true);
			if (LLHBDPPJJHC.OHCDIAFPNFK.MDJHNAEGCCM() == 1)
			{
				this.bannerText.SetText(CCOJBMMKNAP.JMDJPKKOHNI().GGPHHLGPMPA("ink"), false);
				this.banner.SetActive(true);
			}
			else
			{
				this.banner.SetActive(true);
				this.bannerText.SetText(CCOJBMMKNAP.JMDJPKKOHNI().DNILNCLIHAP("app42error"), true);
			}
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteWide;
		}
		else
		{
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteSquare;
		}
		if (LLHBDPPJJHC.MLNOFEEIBMI.KGEGKPHEMOJ() > 0)
		{
			this.salesObject.SetActive(false);
			this.salesText.SetText(" (" + LLHBDPPJJHC.MLNOFEEIBMI.ToString() + "OnApplicationFocusBasicSyncSuccess", false);
		}
		else
		{
			this.salesObject.SetActive(false);
		}
		if (LLHBDPPJJHC.ODMKLADKHMO.HOJDOEDDIBD() > 1)
		{
			this.hardCurrencyIcon.SetActive(true);
			this.hardCurrencyAmountText.gameObject.SetActive(false);
			this.hardCurrencyAmountText.SetText(LLHBDPPJJHC.ODMKLADKHMO.ToString(), false);
		}
		else
		{
			this.hardCurrencyIcon.SetActive(true);
			this.hardCurrencyAmountText.gameObject.SetActive(true);
		}
		if (LLHBDPPJJHC.MPMKMCJFHOG.MDJHNAEGCCM() > 1)
		{
			this.energyIcon.SetActive(true);
			this.energyAmountText.gameObject.SetActive(false);
			this.energyAmountText.SetText(LLHBDPPJJHC.MPMKMCJFHOG.ToString(), false);
		}
		else
		{
			this.energyIcon.SetActive(false);
			this.energyAmountText.gameObject.SetActive(true);
		}
		if (this.JIEBEFKGJIM.OKGPIEEOKBM())
		{
			this.pricingText.SetText(this.JIEBEFKGJIM.ILAPDGNDFGC(), false);
			return;
		}
		if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.ru && GeoLocationManager.PBAGPDDBABB())
		{
			this.pricingText.SetText(" <i>" + this.JIEBEFKGJIM.JKBLBOAHJDE, true);
			return;
		}
		this.pricingText.SetText("ok" + this.JIEBEFKGJIM.DMODNDCLGEJ, true);
	}

	// Token: 0x0600749E RID: 29854 RVA: 0x003452DC File Offset: 0x003434DC
	public void HGLODHBAOBK()
	{
		ProductThumbnailManager.lastAccessedProductWebLink = this.JIEBEFKGJIM.FDMCFAHEELN() + "mypachievtitle" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.en && GeoLocationManager.CELPCHNPBHH() && KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA())
		{
			CommonUserInterface.IKNOFBFMPGA().GIFCDFKBBCN(this.JIEBEFKGJIM.FDMCFAHEELN() + "sto" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 8);
			return;
		}
		this.MDLICPCMOAE.IFCOMCGDBLF(this.JIEBEFKGJIM.DEJCCBNPFEC);
	}

	// Token: 0x0600749F RID: 29855 RVA: 0x00345370 File Offset: 0x00343570
	public void BCHHCAKLHLO(PurchasingViewManager DDIPMIKIBJC, OCBIOPOEENJ LLHBDPPJJHC, OBHDGKFFICI GIHIPEOBPBF, ProducThumbnailGraphics KGKMPHJMKMG)
	{
		this.JIEBEFKGJIM = LLHBDPPJJHC;
		this.MDLICPCMOAE = DDIPMIKIBJC;
		if (LLHBDPPJJHC == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("sd");
			return;
		}
		if (GIHIPEOBPBF == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("yes");
			return;
		}
		if (KGKMPHJMKMG == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("skinshopinfotoken");
			return;
		}
		if (this.thumbnailType == PLPHEPDHPJJ.wide)
		{
			this.productTitleText.SetText(GIHIPEOBPBF.DCNGKBHDLIK(), true);
			if (LLHBDPPJJHC.OHCDIAFPNFK.MOBKGNBCIJF() == 0)
			{
				this.bannerText.SetText(CCOJBMMKNAP.PKEINLPIAEH().JLBEIFLLBLO("OnPopupOfferManagerContinueToPurchasingScreen"), false);
				this.banner.SetActive(true);
			}
			else
			{
				this.banner.SetActive(false);
				this.bannerText.SetText(CCOJBMMKNAP.JMDJPKKOHNI().BGELFMIOBCL("ZZZ"), false);
			}
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteWide;
		}
		else
		{
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteSquare;
		}
		if (LLHBDPPJJHC.MLNOFEEIBMI.HOJDOEDDIBD() > 0)
		{
			this.salesObject.SetActive(true);
			this.salesText.SetText("AAA" + LLHBDPPJJHC.MLNOFEEIBMI.ToString() + "textsClient", true);
		}
		else
		{
			this.salesObject.SetActive(true);
		}
		if (LLHBDPPJJHC.ODMKLADKHMO.NPEOEAFOPJP() > 1)
		{
			this.hardCurrencyIcon.SetActive(true);
			this.hardCurrencyAmountText.gameObject.SetActive(false);
			this.hardCurrencyAmountText.SetText(LLHBDPPJJHC.ODMKLADKHMO.ToString(), true);
		}
		else
		{
			this.hardCurrencyIcon.SetActive(true);
			this.hardCurrencyAmountText.gameObject.SetActive(true);
		}
		if (LLHBDPPJJHC.MPMKMCJFHOG.LPKLANAEIFF() > 1)
		{
			this.energyIcon.SetActive(true);
			this.energyAmountText.gameObject.SetActive(false);
			this.energyAmountText.SetText(LLHBDPPJJHC.MPMKMCJFHOG.ToString(), true);
		}
		else
		{
			this.energyIcon.SetActive(true);
			this.energyAmountText.gameObject.SetActive(false);
		}
		if (this.JIEBEFKGJIM.KIOLJNPKOOL())
		{
			this.pricingText.SetText(this.JIEBEFKGJIM.FNJCEPLEPBH(), true);
			return;
		}
		if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.en && GeoLocationManager.NHMHNIFIOCO())
		{
			this.pricingText.SetText("wofrewardmsgcard3" + this.JIEBEFKGJIM.JKBLBOAHJDE, true);
			return;
		}
		this.pricingText.SetText("ShowRatePopup" + this.JIEBEFKGJIM.DMODNDCLGEJ, true);
	}

	// Token: 0x060074A0 RID: 29856 RVA: 0x003455E4 File Offset: 0x003437E4
	public void BMHPINAIINM()
	{
		ProductThumbnailManager.lastAccessedProductWebLink = this.JIEBEFKGJIM.DJJCDNDMAGD() + "Account.ResolveSaveSlots(): Start" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.ru && GeoLocationManager.PBAGPDDBABB() && KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA())
		{
			CommonUserInterface.EHBBFMCILPC.GIFCDFKBBCN(this.JIEBEFKGJIM.BIKJFCLHPBK() + "$EMLOOPSTART" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 0);
			return;
		}
		this.MDLICPCMOAE.IFCOMCGDBLF(this.JIEBEFKGJIM.DEJCCBNPFEC);
	}

	// Token: 0x060074A1 RID: 29857 RVA: 0x00345678 File Offset: 0x00343878
	public void EJNAHHBEHKN()
	{
		ProductThumbnailManager.lastAccessedProductWebLink = this.JIEBEFKGJIM.MBLAIKOOCFH() + "Texture '{0}' not found in 'Resources/Textures' folder." + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.ru && GeoLocationManager.CELPCHNPBHH() && KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA())
		{
			CommonUserInterface.IKNOFBFMPGA().GIFCDFKBBCN(this.JIEBEFKGJIM.DJJCDNDMAGD() + "p" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 5);
			return;
		}
		this.MDLICPCMOAE.IFCOMCGDBLF(this.JIEBEFKGJIM.DEJCCBNPFEC);
	}

	// Token: 0x060074A2 RID: 29858 RVA: 0x0034570C File Offset: 0x0034390C
	public void MDOCNKAEAKP()
	{
		ProductThumbnailManager.lastAccessedProductWebLink = this.JIEBEFKGJIM.MBLAIKOOCFH() + "doublerewardbody" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.en && GeoLocationManager.PBAGPDDBABB() && KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA())
		{
			CommonUserInterface.EHBBFMCILPC.ShowPopupOnlineResources(this.JIEBEFKGJIM.DJJCDNDMAGD() + "+" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 8);
			return;
		}
		this.MDLICPCMOAE.PurchaseProduct(this.JIEBEFKGJIM.DEJCCBNPFEC);
	}

	// Token: 0x060074A3 RID: 29859 RVA: 0x003457A0 File Offset: 0x003439A0
	public void HNMINONIPLE()
	{
		ProductThumbnailManager.lastAccessedProductWebLink = this.JIEBEFKGJIM.DJJCDNDMAGD() + " (" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.ru && GeoLocationManager.OOCDLFJKLLI() && KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA())
		{
			CommonUserInterface.EHBBFMCILPC.DPJBIGPDLMB(this.JIEBEFKGJIM.BIKJFCLHPBK() + "item" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 7);
			return;
		}
		this.MDLICPCMOAE.PurchaseProduct(this.JIEBEFKGJIM.DEJCCBNPFEC);
	}

	// Token: 0x060074A4 RID: 29860 RVA: 0x00345834 File Offset: 0x00343A34
	public void HNHFFPPELIG(PurchasingViewManager DDIPMIKIBJC, OCBIOPOEENJ LLHBDPPJJHC, OBHDGKFFICI GIHIPEOBPBF, ProducThumbnailGraphics KGKMPHJMKMG)
	{
		this.JIEBEFKGJIM = LLHBDPPJJHC;
		this.MDLICPCMOAE = DDIPMIKIBJC;
		if (LLHBDPPJJHC == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("skduplicatecant0");
			return;
		}
		if (GIHIPEOBPBF == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("");
			return;
		}
		if (KGKMPHJMKMG == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("OnFriendsPopupSendMessageClick");
			return;
		}
		if (this.thumbnailType == PLPHEPDHPJJ.square)
		{
			this.productTitleText.SetText(GIHIPEOBPBF.EOFFDPLIPOL(), false);
			if (LLHBDPPJJHC.OHCDIAFPNFK.LPKLANAEIFF() == 0)
			{
				this.bannerText.SetText(CCOJBMMKNAP.BIAEAOMHBMM().MEPECBDCOLG("$de"), true);
				this.banner.SetActive(true);
			}
			else
			{
				this.banner.SetActive(false);
				this.bannerText.SetText(CCOJBMMKNAP.HJGDLOOHNLO().HPOAGPJFHPM("Account.ResolveSaveSlots(): Start"), false);
			}
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteWide;
		}
		else
		{
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteSquare;
		}
		if (LLHBDPPJJHC.MLNOFEEIBMI.NPEOEAFOPJP() > 1)
		{
			this.salesObject.SetActive(true);
			this.salesText.SetText("SetDepot(), cdnDepot:" + LLHBDPPJJHC.MLNOFEEIBMI.ToString() + "GeneralBalance.SearchKeyArrayElementWithDefault - element ", true);
		}
		else
		{
			this.salesObject.SetActive(true);
		}
		if (LLHBDPPJJHC.ODMKLADKHMO.GALKFKBPLCK() > 1)
		{
			this.hardCurrencyIcon.SetActive(true);
			this.hardCurrencyAmountText.gameObject.SetActive(true);
			this.hardCurrencyAmountText.SetText(LLHBDPPJJHC.ODMKLADKHMO.ToString(), true);
		}
		else
		{
			this.hardCurrencyIcon.SetActive(false);
			this.hardCurrencyAmountText.gameObject.SetActive(false);
		}
		if (LLHBDPPJJHC.MPMKMCJFHOG.NPEOEAFOPJP() > 0)
		{
			this.energyIcon.SetActive(false);
			this.energyAmountText.gameObject.SetActive(true);
			this.energyAmountText.SetText(LLHBDPPJJHC.MPMKMCJFHOG.ToString(), true);
		}
		else
		{
			this.energyIcon.SetActive(false);
			this.energyAmountText.gameObject.SetActive(false);
		}
		if (this.JIEBEFKGJIM.IMKLGJBEMPH())
		{
			this.pricingText.SetText(this.JIEBEFKGJIM.DOLEPIMNJLG(), true);
			return;
		}
		if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.ru && GeoLocationManager.NHMHNIFIOCO())
		{
			this.pricingText.SetText("cs" + this.JIEBEFKGJIM.JKBLBOAHJDE, true);
			return;
		}
		this.pricingText.SetText("favchrstr2" + this.JIEBEFKGJIM.DMODNDCLGEJ, true);
	}

	// Token: 0x060074A5 RID: 29861 RVA: 0x00345AA8 File Offset: 0x00343CA8
	public void CIFEKCFKLPK()
	{
		ProductThumbnailManager.lastAccessedProductWebLink = this.JIEBEFKGJIM.MBLAIKOOCFH() + "mypachievtitle" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.en && GeoLocationManager.IsRussia() && KDCJJBLGCBH.EHBBFMCILPC.EAMJBDKCDPA())
		{
			CommonUserInterface.IKNOFBFMPGA().ShowPopupOnlineResources(this.JIEBEFKGJIM.DJJCDNDMAGD() + "USD " + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 1);
			return;
		}
		this.MDLICPCMOAE.PurchaseProduct(this.JIEBEFKGJIM.DEJCCBNPFEC);
	}

	// Token: 0x060074A6 RID: 29862 RVA: 0x00345B3C File Offset: 0x00343D3C
	public void IOMCNGHFBDL()
	{
		ProductThumbnailManager.lastAccessedProductWebLink = this.JIEBEFKGJIM.FDMCFAHEELN() + "StoryStepDialogPlayerCharacter.RemoveChoiceAtEnd - _choicesToRemove is <= 0." + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru && GeoLocationManager.OOCDLFJKLLI() && KDCJJBLGCBH.EHBBFMCILPC.EAMJBDKCDPA())
		{
			CommonUserInterface.EHBBFMCILPC.GIFCDFKBBCN(this.JIEBEFKGJIM.DJJCDNDMAGD() + "isv" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 6);
			return;
		}
		this.MDLICPCMOAE.GAAMAOLMOPA(this.JIEBEFKGJIM.DEJCCBNPFEC);
	}

	// Token: 0x060074A7 RID: 29863 RVA: 0x00345BD0 File Offset: 0x00343DD0
	public void FNIPBFPDHGE()
	{
		ProductThumbnailManager.lastAccessedProductWebLink = this.JIEBEFKGJIM.FDMCFAHEELN() + "lsv" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.ru && GeoLocationManager.FHINOKNBJPM() && KDCJJBLGCBH.EHBBFMCILPC.EAMJBDKCDPA())
		{
			CommonUserInterface.IKNOFBFMPGA().GIFCDFKBBCN(this.JIEBEFKGJIM.DJJCDNDMAGD() + "\\\\" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 3);
			return;
		}
		this.MDLICPCMOAE.GAAMAOLMOPA(this.JIEBEFKGJIM.DEJCCBNPFEC);
	}

	// Token: 0x060074A8 RID: 29864 RVA: 0x00345C64 File Offset: 0x00343E64
	public void KNLKAPKHBAI()
	{
		ProductThumbnailManager.lastAccessedProductWebLink = this.JIEBEFKGJIM.MBLAIKOOCFH() + "$" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.ru && GeoLocationManager.OOCDLFJKLLI() && KDCJJBLGCBH.EHBBFMCILPC.EAMJBDKCDPA())
		{
			CommonUserInterface.IKNOFBFMPGA().DPJBIGPDLMB(this.JIEBEFKGJIM.MBLAIKOOCFH() + "secret" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 4);
			return;
		}
		this.MDLICPCMOAE.PurchaseProduct(this.JIEBEFKGJIM.DEJCCBNPFEC);
	}

	// Token: 0x060074A9 RID: 29865 RVA: 0x00345CF8 File Offset: 0x00343EF8
	public void FKCAPEPJELB()
	{
		ProductThumbnailManager.lastAccessedProductWebLink = this.JIEBEFKGJIM.BIKJFCLHPBK() + " short='" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.en && GeoLocationManager.FDJONIACJKC() && KDCJJBLGCBH.EHBBFMCILPC.EAMJBDKCDPA())
		{
			CommonUserInterface.EHBBFMCILPC.DPJBIGPDLMB(this.JIEBEFKGJIM.MBLAIKOOCFH() + "" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 2);
			return;
		}
		this.MDLICPCMOAE.GAAMAOLMOPA(this.JIEBEFKGJIM.DEJCCBNPFEC);
	}

	// Token: 0x060074AA RID: 29866 RVA: 0x00345D8C File Offset: 0x00343F8C
	public void HDAHPNAHNJC(PurchasingViewManager DDIPMIKIBJC, OCBIOPOEENJ LLHBDPPJJHC, OBHDGKFFICI GIHIPEOBPBF, ProducThumbnailGraphics KGKMPHJMKMG)
	{
		this.JIEBEFKGJIM = LLHBDPPJJHC;
		this.MDLICPCMOAE = DDIPMIKIBJC;
		if (LLHBDPPJJHC == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("PurchaseManagerSteam.OnPurchaseFailed(), reason - ");
			return;
		}
		if (GIHIPEOBPBF == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("x");
			return;
		}
		if (KGKMPHJMKMG == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("ok");
			return;
		}
		if (this.thumbnailType == PLPHEPDHPJJ.wide)
		{
			this.productTitleText.SetText(GIHIPEOBPBF.MNDNJIFLDNL(), false);
			if (LLHBDPPJJHC.OHCDIAFPNFK.KGEGKPHEMOJ() == 0)
			{
				this.bannerText.SetText(CCOJBMMKNAP.KNKGCDDMLDP().OGKGHLHHAAI(" spec(s) consumed, height "), true);
				this.banner.SetActive(false);
			}
			else
			{
				this.banner.SetActive(true);
				this.bannerText.SetText(CCOJBMMKNAP.KNKGCDDMLDP().OBDCPLLLGBB("rsl"), false);
			}
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteWide;
		}
		else
		{
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteSquare;
		}
		if (LLHBDPPJJHC.MLNOFEEIBMI.NPEOEAFOPJP() > 0)
		{
			this.salesObject.SetActive(true);
			this.salesText.SetText("cat" + LLHBDPPJJHC.MLNOFEEIBMI.ToString() + "XXX", true);
		}
		else
		{
			this.salesObject.SetActive(true);
		}
		if (LLHBDPPJJHC.ODMKLADKHMO.GALKFKBPLCK() > 1)
		{
			this.hardCurrencyIcon.SetActive(false);
			this.hardCurrencyAmountText.gameObject.SetActive(true);
			this.hardCurrencyAmountText.SetText(LLHBDPPJJHC.ODMKLADKHMO.ToString(), true);
		}
		else
		{
			this.hardCurrencyIcon.SetActive(true);
			this.hardCurrencyAmountText.gameObject.SetActive(true);
		}
		if (LLHBDPPJJHC.MPMKMCJFHOG.MDJHNAEGCCM() > 1)
		{
			this.energyIcon.SetActive(false);
			this.energyAmountText.gameObject.SetActive(true);
			this.energyAmountText.SetText(LLHBDPPJJHC.MPMKMCJFHOG.ToString(), true);
		}
		else
		{
			this.energyIcon.SetActive(false);
			this.energyAmountText.gameObject.SetActive(false);
		}
		if (this.JIEBEFKGJIM.KIOLJNPKOOL())
		{
			this.pricingText.SetText(this.JIEBEFKGJIM.PKNNPAMOADM(), false);
			return;
		}
		if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.ru && GeoLocationManager.PBAGPDDBABB())
		{
			this.pricingText.SetText("vhspause_1" + this.JIEBEFKGJIM.JKBLBOAHJDE, false);
			return;
		}
		this.pricingText.SetText("abld2" + this.JIEBEFKGJIM.DMODNDCLGEJ, false);
	}

	// Token: 0x060074AB RID: 29867 RVA: 0x00346000 File Offset: 0x00344200
	public void EHDGANAEHEF()
	{
		ProductThumbnailManager.lastAccessedProductWebLink = this.JIEBEFKGJIM.FDMCFAHEELN() + "<" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru && GeoLocationManager.OOCDLFJKLLI() && KDCJJBLGCBH.EHBBFMCILPC.EAMJBDKCDPA())
		{
			CommonUserInterface.EHBBFMCILPC.GIFCDFKBBCN(this.JIEBEFKGJIM.DJJCDNDMAGD() + "aind" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 8);
			return;
		}
		this.MDLICPCMOAE.PurchaseProduct(this.JIEBEFKGJIM.DEJCCBNPFEC);
	}

	// Token: 0x060074AD RID: 29869 RVA: 0x00346094 File Offset: 0x00344294
	public void AFOFDJDFCIK()
	{
		ProductThumbnailManager.lastAccessedProductWebLink = this.JIEBEFKGJIM.BIKJFCLHPBK() + "energyhinttitle" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru && GeoLocationManager.CELPCHNPBHH() && KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA())
		{
			CommonUserInterface.IKNOFBFMPGA().ShowPopupOnlineResources(this.JIEBEFKGJIM.DJJCDNDMAGD() + "sto" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 3);
			return;
		}
		this.MDLICPCMOAE.PurchaseProduct(this.JIEBEFKGJIM.DEJCCBNPFEC);
	}

	// Token: 0x060074AE RID: 29870 RVA: 0x00346128 File Offset: 0x00344328
	public void HMPPMBGBMMF(PurchasingViewManager DDIPMIKIBJC, OCBIOPOEENJ LLHBDPPJJHC, OBHDGKFFICI GIHIPEOBPBF, ProducThumbnailGraphics KGKMPHJMKMG)
	{
		this.JIEBEFKGJIM = LLHBDPPJJHC;
		this.MDLICPCMOAE = DDIPMIKIBJC;
		if (LLHBDPPJJHC == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("seasoncompletedesc");
			return;
		}
		if (GIHIPEOBPBF == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("sltind");
			return;
		}
		if (KGKMPHJMKMG == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("0");
			return;
		}
		if (this.thumbnailType == PLPHEPDHPJJ.square)
		{
			this.productTitleText.SetText(GIHIPEOBPBF.NEMDCGKIJIC(), false);
			if (LLHBDPPJJHC.OHCDIAFPNFK.LPKLANAEIFF() == 0)
			{
				this.bannerText.SetText(CCOJBMMKNAP.HJGDLOOHNLO().FIENAKIHNOM("importanttitle"), false);
				this.banner.SetActive(true);
			}
			else
			{
				this.banner.SetActive(false);
				this.bannerText.SetText(CCOJBMMKNAP.HFAKOKBHCGH().HPOAGPJFHPM("HD"), true);
			}
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteWide;
		}
		else
		{
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteSquare;
		}
		if (LLHBDPPJJHC.MLNOFEEIBMI.DPLHPBMJAPJ() > 0)
		{
			this.salesObject.SetActive(true);
			this.salesText.SetText("p" + LLHBDPPJJHC.MLNOFEEIBMI.ToString() + "yes", true);
		}
		else
		{
			this.salesObject.SetActive(false);
		}
		if (LLHBDPPJJHC.ODMKLADKHMO.MDJHNAEGCCM() > 1)
		{
			this.hardCurrencyIcon.SetActive(true);
			this.hardCurrencyAmountText.gameObject.SetActive(false);
			this.hardCurrencyAmountText.SetText(LLHBDPPJJHC.ODMKLADKHMO.ToString(), false);
		}
		else
		{
			this.hardCurrencyIcon.SetActive(true);
			this.hardCurrencyAmountText.gameObject.SetActive(true);
		}
		if (LLHBDPPJJHC.MPMKMCJFHOG.GALKFKBPLCK() > 1)
		{
			this.energyIcon.SetActive(true);
			this.energyAmountText.gameObject.SetActive(false);
			this.energyAmountText.SetText(LLHBDPPJJHC.MPMKMCJFHOG.ToString(), false);
		}
		else
		{
			this.energyIcon.SetActive(true);
			this.energyAmountText.gameObject.SetActive(true);
		}
		if (this.JIEBEFKGJIM.KIOLJNPKOOL())
		{
			this.pricingText.SetText(this.JIEBEFKGJIM.DOLEPIMNJLG(), true);
			return;
		}
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru && GeoLocationManager.FDJONIACJKC())
		{
			this.pricingText.SetText("" + this.JIEBEFKGJIM.JKBLBOAHJDE, false);
			return;
		}
		this.pricingText.SetText("App42Manager.UpdateUrlPingManagerState(): urlPingManager.StartPing()" + this.JIEBEFKGJIM.DMODNDCLGEJ, true);
	}

	// Token: 0x060074AF RID: 29871 RVA: 0x0034639C File Offset: 0x0034459C
	public void OCPJHJNGBIM()
	{
		ProductThumbnailManager.lastAccessedProductWebLink = this.JIEBEFKGJIM.FDMCFAHEELN() + "ugsk" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.ru && GeoLocationManager.CELPCHNPBHH() && KDCJJBLGCBH.EHBBFMCILPC.EAMJBDKCDPA())
		{
			CommonUserInterface.EHBBFMCILPC.GIFCDFKBBCN(this.JIEBEFKGJIM.BIKJFCLHPBK() + "%" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 2);
			return;
		}
		this.MDLICPCMOAE.GAAMAOLMOPA(this.JIEBEFKGJIM.DEJCCBNPFEC);
	}

	// Token: 0x060074B0 RID: 29872 RVA: 0x00346430 File Offset: 0x00344630
	public void GDHLPCIDFMC()
	{
		ProductThumbnailManager.lastAccessedProductWebLink = this.JIEBEFKGJIM.BIKJFCLHPBK() + "), cost hidden" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.en && GeoLocationManager.OOCDLFJKLLI() && KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA())
		{
			CommonUserInterface.IKNOFBFMPGA().DPJBIGPDLMB(this.JIEBEFKGJIM.FDMCFAHEELN() + "npcpi" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 3);
			return;
		}
		this.MDLICPCMOAE.PurchaseProduct(this.JIEBEFKGJIM.DEJCCBNPFEC);
	}

	// Token: 0x060074B1 RID: 29873 RVA: 0x003464C4 File Offset: 0x003446C4
	public void MMKCEHIKHFH()
	{
		ProductThumbnailManager.lastAccessedProductWebLink = this.JIEBEFKGJIM.DJJCDNDMAGD() + "place" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.ru && GeoLocationManager.FDJONIACJKC() && KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA())
		{
			CommonUserInterface.EHBBFMCILPC.ShowPopupOnlineResources(this.JIEBEFKGJIM.BIKJFCLHPBK() + "OnBackendGetIncentRewardAdException" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 2);
			return;
		}
		this.MDLICPCMOAE.IFCOMCGDBLF(this.JIEBEFKGJIM.DEJCCBNPFEC);
	}

	// Token: 0x060074B2 RID: 29874 RVA: 0x00346558 File Offset: 0x00344758
	public void IFCOMCGDBLF()
	{
		ProductThumbnailManager.lastAccessedProductWebLink = this.JIEBEFKGJIM.FDMCFAHEELN() + " (- )</i>" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru && GeoLocationManager.OOCDLFJKLLI() && KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA())
		{
			CommonUserInterface.EHBBFMCILPC.ShowPopupOnlineResources(this.JIEBEFKGJIM.DJJCDNDMAGD() + ">" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 3);
			return;
		}
		this.MDLICPCMOAE.GAAMAOLMOPA(this.JIEBEFKGJIM.DEJCCBNPFEC);
	}

	// Token: 0x060074B3 RID: 29875 RVA: 0x003465EC File Offset: 0x003447EC
	public void KLJIMOGLHEF(PurchasingViewManager DDIPMIKIBJC, OCBIOPOEENJ LLHBDPPJJHC, OBHDGKFFICI GIHIPEOBPBF, ProducThumbnailGraphics KGKMPHJMKMG)
	{
		this.JIEBEFKGJIM = LLHBDPPJJHC;
		this.MDLICPCMOAE = DDIPMIKIBJC;
		if (LLHBDPPJJHC == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("OnSaveSyncAnyResultFocusItem");
			return;
		}
		if (GIHIPEOBPBF == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("Account.DuplicateAnthologySaveSlot(), a story save could not be copied, the target slot was cleared, anthology:");
			return;
		}
		if (KGKMPHJMKMG == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("$");
			return;
		}
		if (this.thumbnailType == PLPHEPDHPJJ.wide)
		{
			this.productTitleText.SetText(GIHIPEOBPBF.EDGJELLBBFD(), true);
			if (LLHBDPPJJHC.OHCDIAFPNFK.CJLDJAJHMMA() == 1)
			{
				this.bannerText.SetText(CCOJBMMKNAP.PMABBOJDELF().IPEIONBNIPH("hofr"), true);
				this.banner.SetActive(false);
			}
			else
			{
				this.banner.SetActive(true);
				this.bannerText.SetText(CCOJBMMKNAP.NIOJNOFGIJO().JCDFHKDNEDH("..."), true);
			}
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteWide;
		}
		else
		{
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteSquare;
		}
		if (LLHBDPPJJHC.MLNOFEEIBMI.NPEOEAFOPJP() > 0)
		{
			this.salesObject.SetActive(true);
			this.salesText.SetText("s" + LLHBDPPJJHC.MLNOFEEIBMI.ToString() + "", false);
		}
		else
		{
			this.salesObject.SetActive(false);
		}
		if (LLHBDPPJJHC.ODMKLADKHMO.BADNAGEMINF() > 1)
		{
			this.hardCurrencyIcon.SetActive(false);
			this.hardCurrencyAmountText.gameObject.SetActive(false);
			this.hardCurrencyAmountText.SetText(LLHBDPPJJHC.ODMKLADKHMO.ToString(), true);
		}
		else
		{
			this.hardCurrencyIcon.SetActive(true);
			this.hardCurrencyAmountText.gameObject.SetActive(true);
		}
		if (LLHBDPPJJHC.MPMKMCJFHOG.LPKLANAEIFF() > 0)
		{
			this.energyIcon.SetActive(false);
			this.energyAmountText.gameObject.SetActive(false);
			this.energyAmountText.SetText(LLHBDPPJJHC.MPMKMCJFHOG.ToString(), false);
		}
		else
		{
			this.energyIcon.SetActive(true);
			this.energyAmountText.gameObject.SetActive(true);
		}
		if (this.JIEBEFKGJIM.KIOLJNPKOOL())
		{
			this.pricingText.SetText(this.JIEBEFKGJIM.FNJCEPLEPBH(), true);
			return;
		}
		if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.en && GeoLocationManager.OOCDLFJKLLI())
		{
			this.pricingText.SetText(" " + this.JIEBEFKGJIM.JKBLBOAHJDE, false);
			return;
		}
		this.pricingText.SetText("specialcardpacknotforsale" + this.JIEBEFKGJIM.DMODNDCLGEJ, false);
	}

	// Token: 0x060074B4 RID: 29876 RVA: 0x00346860 File Offset: 0x00344A60
	public void IFHNGHNJONP(PurchasingViewManager DDIPMIKIBJC, OCBIOPOEENJ LLHBDPPJJHC, OBHDGKFFICI GIHIPEOBPBF, ProducThumbnailGraphics KGKMPHJMKMG)
	{
		this.JIEBEFKGJIM = LLHBDPPJJHC;
		this.MDLICPCMOAE = DDIPMIKIBJC;
		if (LLHBDPPJJHC == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("StoryStepNoteShow.StoryStepStage.delayBeforeDisappear timeToNextStage:");
			return;
		}
		if (GIHIPEOBPBF == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("socialfriendevents");
			return;
		}
		if (KGKMPHJMKMG == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("stat4long");
			return;
		}
		if (this.thumbnailType == PLPHEPDHPJJ.wide)
		{
			this.productTitleText.SetText(GIHIPEOBPBF.MNDNJIFLDNL(), true);
			if (LLHBDPPJJHC.OHCDIAFPNFK.DPLHPBMJAPJ() == 0)
			{
				this.bannerText.SetText(CCOJBMMKNAP.EHBBFMCILPC.BGELFMIOBCL("UpdateComponentTitleDesc() failed - AssetAvatarComponentType.clothes is null."), false);
				this.banner.SetActive(true);
			}
			else
			{
				this.banner.SetActive(true);
				this.bannerText.SetText(CCOJBMMKNAP.BFHKGNBFHCH().FIENAKIHNOM("continue"), false);
			}
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteWide;
		}
		else
		{
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteSquare;
		}
		if (LLHBDPPJJHC.MLNOFEEIBMI.BADNAGEMINF() > 1)
		{
			this.salesObject.SetActive(true);
			this.salesText.SetText("OnProfileMessageClosed" + LLHBDPPJJHC.MLNOFEEIBMI.ToString() + "e1cs", true);
		}
		else
		{
			this.salesObject.SetActive(false);
		}
		if (LLHBDPPJJHC.ODMKLADKHMO.KGEGKPHEMOJ() > 1)
		{
			this.hardCurrencyIcon.SetActive(false);
			this.hardCurrencyAmountText.gameObject.SetActive(false);
			this.hardCurrencyAmountText.SetText(LLHBDPPJJHC.ODMKLADKHMO.ToString(), true);
		}
		else
		{
			this.hardCurrencyIcon.SetActive(true);
			this.hardCurrencyAmountText.gameObject.SetActive(true);
		}
		if (LLHBDPPJJHC.MPMKMCJFHOG.DPLHPBMJAPJ() > 1)
		{
			this.energyIcon.SetActive(false);
			this.energyAmountText.gameObject.SetActive(false);
			this.energyAmountText.SetText(LLHBDPPJJHC.MPMKMCJFHOG.ToString(), false);
		}
		else
		{
			this.energyIcon.SetActive(true);
			this.energyAmountText.gameObject.SetActive(false);
		}
		if (this.JIEBEFKGJIM.OKGPIEEOKBM())
		{
			this.pricingText.SetText(this.JIEBEFKGJIM.DOLEPIMNJLG(), false);
			return;
		}
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.en && GeoLocationManager.OOCDLFJKLLI())
		{
			this.pricingText.SetText("prefixEnabled" + this.JIEBEFKGJIM.JKBLBOAHJDE, false);
			return;
		}
		this.pricingText.SetText("steam" + this.JIEBEFKGJIM.DMODNDCLGEJ, true);
	}

	// Token: 0x060074B5 RID: 29877 RVA: 0x00346AD4 File Offset: 0x00344CD4
	public void CJEOFOMGMNH()
	{
		ProductThumbnailManager.lastAccessedProductWebLink = this.JIEBEFKGJIM.BIKJFCLHPBK() + "continue" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.en && GeoLocationManager.NHMHNIFIOCO() && KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA())
		{
			CommonUserInterface.IKNOFBFMPGA().GIFCDFKBBCN(this.JIEBEFKGJIM.DJJCDNDMAGD() + "cardoptionsloadingtheme" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 0);
			return;
		}
		this.MDLICPCMOAE.GAAMAOLMOPA(this.JIEBEFKGJIM.DEJCCBNPFEC);
	}

	// Token: 0x060074B6 RID: 29878 RVA: 0x00346B68 File Offset: 0x00344D68
	public void FBPNEOPNDBK()
	{
		ProductThumbnailManager.lastAccessedProductWebLink = this.JIEBEFKGJIM.MBLAIKOOCFH() + "box" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.en && GeoLocationManager.PBAGPDDBABB() && KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA())
		{
			CommonUserInterface.EHBBFMCILPC.GIFCDFKBBCN(this.JIEBEFKGJIM.BIKJFCLHPBK() + "" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 5);
			return;
		}
		this.MDLICPCMOAE.IFCOMCGDBLF(this.JIEBEFKGJIM.DEJCCBNPFEC);
	}

	// Token: 0x060074B7 RID: 29879 RVA: 0x00346BFC File Offset: 0x00344DFC
	public void HBBFAAOICDH(PurchasingViewManager DDIPMIKIBJC, OCBIOPOEENJ LLHBDPPJJHC, OBHDGKFFICI GIHIPEOBPBF, ProducThumbnailGraphics KGKMPHJMKMG)
	{
		this.JIEBEFKGJIM = LLHBDPPJJHC;
		this.MDLICPCMOAE = DDIPMIKIBJC;
		if (LLHBDPPJJHC == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("_Color");
			return;
		}
		if (GIHIPEOBPBF == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("PurchaseManagerUnity.SetState(). Changing manager state to:");
			return;
		}
		if (KGKMPHJMKMG == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("Value:");
			return;
		}
		if (this.thumbnailType == PLPHEPDHPJJ.wide)
		{
			this.productTitleText.SetText(GIHIPEOBPBF.FHEGGFAOECB(), true);
			if (LLHBDPPJJHC.OHCDIAFPNFK.MDJHNAEGCCM() == 1)
			{
				this.bannerText.SetText(CCOJBMMKNAP.KLAKLFCOMJC().PGKBCNBAOJN("Starting non-parallel download:"), true);
				this.banner.SetActive(true);
			}
			else
			{
				this.banner.SetActive(false);
				this.bannerText.SetText(CCOJBMMKNAP.BBGECIKOICE().JCDFHKDNEDH("PlayerCharacterManager.SetOverlayComponent() - input is null."), false);
			}
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteWide;
		}
		else
		{
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteSquare;
		}
		if (LLHBDPPJJHC.MLNOFEEIBMI.NPEOEAFOPJP() > 1)
		{
			this.salesObject.SetActive(true);
			this.salesText.SetText("Shaders/VideoGlitchOldVHS" + LLHBDPPJJHC.MLNOFEEIBMI.ToString() + "", false);
		}
		else
		{
			this.salesObject.SetActive(false);
		}
		if (LLHBDPPJJHC.ODMKLADKHMO.DPLHPBMJAPJ() > 0)
		{
			this.hardCurrencyIcon.SetActive(true);
			this.hardCurrencyAmountText.gameObject.SetActive(false);
			this.hardCurrencyAmountText.SetText(LLHBDPPJJHC.ODMKLADKHMO.ToString(), true);
		}
		else
		{
			this.hardCurrencyIcon.SetActive(false);
			this.hardCurrencyAmountText.gameObject.SetActive(false);
		}
		if (LLHBDPPJJHC.MPMKMCJFHOG.MOBKGNBCIJF() > 0)
		{
			this.energyIcon.SetActive(false);
			this.energyAmountText.gameObject.SetActive(true);
			this.energyAmountText.SetText(LLHBDPPJJHC.MPMKMCJFHOG.ToString(), false);
		}
		else
		{
			this.energyIcon.SetActive(true);
			this.energyAmountText.gameObject.SetActive(false);
		}
		if (this.JIEBEFKGJIM.OKGPIEEOKBM())
		{
			this.pricingText.SetText(this.JIEBEFKGJIM.DOLEPIMNJLG(), true);
			return;
		}
		if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.ru && GeoLocationManager.PBAGPDDBABB())
		{
			this.pricingText.SetText("\ud83d\udc8e " + this.JIEBEFKGJIM.JKBLBOAHJDE, true);
			return;
		}
		this.pricingText.SetText("\"" + this.JIEBEFKGJIM.DMODNDCLGEJ, true);
	}

	// Token: 0x060074B8 RID: 29880 RVA: 0x00346E70 File Offset: 0x00345070
	public void KFMHGEDDBKA()
	{
		ProductThumbnailManager.lastAccessedProductWebLink = this.JIEBEFKGJIM.BIKJFCLHPBK() + "avatarcollectionstutor2body" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.en && GeoLocationManager.CELPCHNPBHH() && KDCJJBLGCBH.EHBBFMCILPC.EAMJBDKCDPA())
		{
			CommonUserInterface.IKNOFBFMPGA().DPJBIGPDLMB(this.JIEBEFKGJIM.FDMCFAHEELN() + "OnBackendRequestSendMessageException" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 2);
			return;
		}
		this.MDLICPCMOAE.PurchaseProduct(this.JIEBEFKGJIM.DEJCCBNPFEC);
	}

	// Token: 0x060074B9 RID: 29881 RVA: 0x00346F04 File Offset: 0x00345104
	public void AEICGNJJBPJ()
	{
		ProductThumbnailManager.lastAccessedProductWebLink = this.JIEBEFKGJIM.FDMCFAHEELN() + "XXX" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.en && GeoLocationManager.OOCDLFJKLLI() && KDCJJBLGCBH.EHBBFMCILPC.EAMJBDKCDPA())
		{
			CommonUserInterface.EHBBFMCILPC.ShowPopupOnlineResources(this.JIEBEFKGJIM.MBLAIKOOCFH() + "SceneLobbyManager2.GetStarterGroups() - " + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 7);
			return;
		}
		this.MDLICPCMOAE.PurchaseProduct(this.JIEBEFKGJIM.DEJCCBNPFEC);
	}

	// Token: 0x060074BA RID: 29882 RVA: 0x00346F98 File Offset: 0x00345198
	public void DOFLEONDCMI(PurchasingViewManager DDIPMIKIBJC, OCBIOPOEENJ LLHBDPPJJHC, OBHDGKFFICI GIHIPEOBPBF, ProducThumbnailGraphics KGKMPHJMKMG)
	{
		this.JIEBEFKGJIM = LLHBDPPJJHC;
		this.MDLICPCMOAE = DDIPMIKIBJC;
		if (LLHBDPPJJHC == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("");
			return;
		}
		if (GIHIPEOBPBF == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("assetbundlepurchasingview");
			return;
		}
		if (KGKMPHJMKMG == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("ok");
			return;
		}
		if (this.thumbnailType == PLPHEPDHPJJ.wide)
		{
			this.productTitleText.SetText(GIHIPEOBPBF.PNDKNEBJIPA(), false);
			if (LLHBDPPJJHC.OHCDIAFPNFK.CJLDJAJHMMA() == 0)
			{
				this.bannerText.SetText(CCOJBMMKNAP.NIOJNOFGIJO().HPOAGPJFHPM(""), true);
				this.banner.SetActive(true);
			}
			else
			{
				this.banner.SetActive(false);
				this.bannerText.SetText(CCOJBMMKNAP.ILACPHFEDEP().OHLNGCKIACD("sind"), false);
			}
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteWide;
		}
		else
		{
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteSquare;
		}
		if (LLHBDPPJJHC.MLNOFEEIBMI.GALKFKBPLCK() > 0)
		{
			this.salesObject.SetActive(true);
			this.salesText.SetText(", sku:'" + LLHBDPPJJHC.MLNOFEEIBMI.ToString() + "OnDailyRewardPopupHide", true);
		}
		else
		{
			this.salesObject.SetActive(true);
		}
		if (LLHBDPPJJHC.ODMKLADKHMO.PONAPMOOLIN() > 0)
		{
			this.hardCurrencyIcon.SetActive(false);
			this.hardCurrencyAmountText.gameObject.SetActive(false);
			this.hardCurrencyAmountText.SetText(LLHBDPPJJHC.ODMKLADKHMO.ToString(), false);
		}
		else
		{
			this.hardCurrencyIcon.SetActive(false);
			this.hardCurrencyAmountText.gameObject.SetActive(false);
		}
		if (LLHBDPPJJHC.MPMKMCJFHOG.GALKFKBPLCK() > 1)
		{
			this.energyIcon.SetActive(true);
			this.energyAmountText.gameObject.SetActive(false);
			this.energyAmountText.SetText(LLHBDPPJJHC.MPMKMCJFHOG.ToString(), true);
		}
		else
		{
			this.energyIcon.SetActive(false);
			this.energyAmountText.gameObject.SetActive(true);
		}
		if (this.JIEBEFKGJIM.IMKLGJBEMPH())
		{
			this.pricingText.SetText(this.JIEBEFKGJIM.ILAPDGNDFGC(), true);
			return;
		}
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru && GeoLocationManager.OOCDLFJKLLI())
		{
			this.pricingText.SetText("OnEmailSubscribeSuccess" + this.JIEBEFKGJIM.JKBLBOAHJDE, false);
			return;
		}
		this.pricingText.SetText("storiesSearchDefaults" + this.JIEBEFKGJIM.DMODNDCLGEJ, true);
	}

	// Token: 0x060074BB RID: 29883 RVA: 0x0034720C File Offset: 0x0034540C
	public void JAJHLMMDNIG(PurchasingViewManager DDIPMIKIBJC, OCBIOPOEENJ LLHBDPPJJHC, OBHDGKFFICI GIHIPEOBPBF, ProducThumbnailGraphics KGKMPHJMKMG)
	{
		this.JIEBEFKGJIM = LLHBDPPJJHC;
		this.MDLICPCMOAE = DDIPMIKIBJC;
		if (LLHBDPPJJHC == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC(":");
			return;
		}
		if (GIHIPEOBPBF == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("sshrpp");
			return;
		}
		if (KGKMPHJMKMG == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("*");
			return;
		}
		if (this.thumbnailType == PLPHEPDHPJJ.square)
		{
			this.productTitleText.SetText(GIHIPEOBPBF.NBDIMMKFBKK(), false);
			if (LLHBDPPJJHC.OHCDIAFPNFK.PONAPMOOLIN() == 0)
			{
				this.bannerText.SetText(CCOJBMMKNAP.INKJIBDDMLL().GGPHHLGPMPA("ERR"), false);
				this.banner.SetActive(true);
			}
			else
			{
				this.banner.SetActive(true);
				this.bannerText.SetText(CCOJBMMKNAP.KFDLFGHBPLP().BDGPNPNIAPA("</i>"), true);
			}
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteWide;
		}
		else
		{
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteSquare;
		}
		if (LLHBDPPJJHC.MLNOFEEIBMI.DPLHPBMJAPJ() > 1)
		{
			this.salesObject.SetActive(false);
			this.salesText.SetText("" + LLHBDPPJJHC.MLNOFEEIBMI.ToString() + "cardvolsaleinfo0", false);
		}
		else
		{
			this.salesObject.SetActive(false);
		}
		if (LLHBDPPJJHC.ODMKLADKHMO.NPEOEAFOPJP() > 1)
		{
			this.hardCurrencyIcon.SetActive(true);
			this.hardCurrencyAmountText.gameObject.SetActive(true);
			this.hardCurrencyAmountText.SetText(LLHBDPPJJHC.ODMKLADKHMO.ToString(), true);
		}
		else
		{
			this.hardCurrencyIcon.SetActive(false);
			this.hardCurrencyAmountText.gameObject.SetActive(true);
		}
		if (LLHBDPPJJHC.MPMKMCJFHOG.NPEOEAFOPJP() > 1)
		{
			this.energyIcon.SetActive(true);
			this.energyAmountText.gameObject.SetActive(true);
			this.energyAmountText.SetText(LLHBDPPJJHC.MPMKMCJFHOG.ToString(), true);
		}
		else
		{
			this.energyIcon.SetActive(true);
			this.energyAmountText.gameObject.SetActive(true);
		}
		if (this.JIEBEFKGJIM.IMKLGJBEMPH())
		{
			this.pricingText.SetText(this.JIEBEFKGJIM.DOLEPIMNJLG(), false);
			return;
		}
		if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.en && GeoLocationManager.IsRussia())
		{
			this.pricingText.SetText("¶" + this.JIEBEFKGJIM.JKBLBOAHJDE, false);
			return;
		}
		this.pricingText.SetText("OnAvatarCollectionDelete" + this.JIEBEFKGJIM.DMODNDCLGEJ, true);
	}

	// Token: 0x060074BC RID: 29884 RVA: 0x00347480 File Offset: 0x00345680
	public void KIBBPBJEGEC()
	{
		ProductThumbnailManager.lastAccessedProductWebLink = this.JIEBEFKGJIM.FDMCFAHEELN() + "timeoutwarning" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru && GeoLocationManager.NHMHNIFIOCO() && KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA())
		{
			CommonUserInterface.IKNOFBFMPGA().ShowPopupOnlineResources(this.JIEBEFKGJIM.DJJCDNDMAGD() + "p" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 1);
			return;
		}
		this.MDLICPCMOAE.GAAMAOLMOPA(this.JIEBEFKGJIM.DEJCCBNPFEC);
	}

	// Token: 0x060074BD RID: 29885 RVA: 0x00347514 File Offset: 0x00345714
	public void IIGPFBMONKO()
	{
		ProductThumbnailManager.lastAccessedProductWebLink = this.JIEBEFKGJIM.DJJCDNDMAGD() + "p" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.en && GeoLocationManager.CELPCHNPBHH() && KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA())
		{
			CommonUserInterface.IKNOFBFMPGA().DPJBIGPDLMB(this.JIEBEFKGJIM.DJJCDNDMAGD() + "</i><align=\"left\"><alpha=#FF>\n\n" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 3);
			return;
		}
		this.MDLICPCMOAE.IFCOMCGDBLF(this.JIEBEFKGJIM.DEJCCBNPFEC);
	}

	// Token: 0x060074BE RID: 29886 RVA: 0x003475A8 File Offset: 0x003457A8
	public void EJEPBLIBDEN(PurchasingViewManager DDIPMIKIBJC, OCBIOPOEENJ LLHBDPPJJHC, OBHDGKFFICI GIHIPEOBPBF, ProducThumbnailGraphics KGKMPHJMKMG)
	{
		this.JIEBEFKGJIM = LLHBDPPJJHC;
		this.MDLICPCMOAE = DDIPMIKIBJC;
		if (LLHBDPPJJHC == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("assetBundleLoadOperationActiveCoroutines:");
			return;
		}
		if (GIHIPEOBPBF == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("chapterrewindhint0");
			return;
		}
		if (KGKMPHJMKMG == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("priceCurrencyCode");
			return;
		}
		if (this.thumbnailType == PLPHEPDHPJJ.square)
		{
			this.productTitleText.SetText(GIHIPEOBPBF.KLGAPBPPBIN(), true);
			if (LLHBDPPJJHC.OHCDIAFPNFK.HOJDOEDDIBD() == 0)
			{
				this.bannerText.SetText(CCOJBMMKNAP.AEELGGPEJCC().HIPJILDCHJC("serversync"), true);
				this.banner.SetActive(true);
			}
			else
			{
				this.banner.SetActive(false);
				this.bannerText.SetText(CCOJBMMKNAP.EHBBFMCILPC.PKNHKGMNCIP("msgt"), true);
			}
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteWide;
		}
		else
		{
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteSquare;
		}
		if (LLHBDPPJJHC.MLNOFEEIBMI.PONAPMOOLIN() > 1)
		{
			this.salesObject.SetActive(true);
			this.salesText.SetText("x" + LLHBDPPJJHC.MLNOFEEIBMI.ToString() + "\"", true);
		}
		else
		{
			this.salesObject.SetActive(true);
		}
		if (LLHBDPPJJHC.ODMKLADKHMO.MDJHNAEGCCM() > 1)
		{
			this.hardCurrencyIcon.SetActive(true);
			this.hardCurrencyAmountText.gameObject.SetActive(false);
			this.hardCurrencyAmountText.SetText(LLHBDPPJJHC.ODMKLADKHMO.ToString(), true);
		}
		else
		{
			this.hardCurrencyIcon.SetActive(true);
			this.hardCurrencyAmountText.gameObject.SetActive(true);
		}
		if (LLHBDPPJJHC.MPMKMCJFHOG.DPLHPBMJAPJ() > 0)
		{
			this.energyIcon.SetActive(false);
			this.energyAmountText.gameObject.SetActive(false);
			this.energyAmountText.SetText(LLHBDPPJJHC.MPMKMCJFHOG.ToString(), false);
		}
		else
		{
			this.energyIcon.SetActive(true);
			this.energyAmountText.gameObject.SetActive(false);
		}
		if (this.JIEBEFKGJIM.PJCIBAKAANH())
		{
			this.pricingText.SetText(this.JIEBEFKGJIM.PKNNPAMOADM(), true);
			return;
		}
		if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.ru && GeoLocationManager.CELPCHNPBHH())
		{
			this.pricingText.SetText("0" + this.JIEBEFKGJIM.JKBLBOAHJDE, true);
			return;
		}
		this.pricingText.SetText("rsind" + this.JIEBEFKGJIM.DMODNDCLGEJ, true);
	}

	// Token: 0x060074BF RID: 29887 RVA: 0x0034781C File Offset: 0x00345A1C
	public void ACGGMOACIHN(PurchasingViewManager DDIPMIKIBJC, OCBIOPOEENJ LLHBDPPJJHC, OBHDGKFFICI GIHIPEOBPBF, ProducThumbnailGraphics KGKMPHJMKMG)
	{
		this.JIEBEFKGJIM = LLHBDPPJJHC;
		this.MDLICPCMOAE = DDIPMIKIBJC;
		if (LLHBDPPJJHC == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("OnPopupCardOptionsUnlockWithSpSuccessContinue");
			return;
		}
		if (GIHIPEOBPBF == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("OnAccountForgetException");
			return;
		}
		if (KGKMPHJMKMG == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("Asset pack has been LOADED according to on demand resources data:");
			return;
		}
		if (this.thumbnailType == PLPHEPDHPJJ.square)
		{
			this.productTitleText.SetText(GIHIPEOBPBF.OEMLJGPIGAE(), true);
			if (LLHBDPPJJHC.OHCDIAFPNFK.HOJDOEDDIBD() == 1)
			{
				this.bannerText.SetText(CCOJBMMKNAP.LMCCLMFGEBD().JLBEIFLLBLO("socialgiftsendtotitle"), true);
				this.banner.SetActive(true);
			}
			else
			{
				this.banner.SetActive(false);
				this.bannerText.SetText(CCOJBMMKNAP.JINDKPHNLBK().HHLECNIFHCO(""), false);
			}
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteWide;
		}
		else
		{
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteSquare;
		}
		if (LLHBDPPJJHC.MLNOFEEIBMI.PONAPMOOLIN() > 0)
		{
			this.salesObject.SetActive(true);
			this.salesText.SetText("]" + LLHBDPPJJHC.MLNOFEEIBMI.ToString() + "", true);
		}
		else
		{
			this.salesObject.SetActive(true);
		}
		if (LLHBDPPJJHC.ODMKLADKHMO.DPLHPBMJAPJ() > 0)
		{
			this.hardCurrencyIcon.SetActive(false);
			this.hardCurrencyAmountText.gameObject.SetActive(false);
			this.hardCurrencyAmountText.SetText(LLHBDPPJJHC.ODMKLADKHMO.ToString(), false);
		}
		else
		{
			this.hardCurrencyIcon.SetActive(true);
			this.hardCurrencyAmountText.gameObject.SetActive(true);
		}
		if (LLHBDPPJJHC.MPMKMCJFHOG.MDJHNAEGCCM() > 0)
		{
			this.energyIcon.SetActive(true);
			this.energyAmountText.gameObject.SetActive(true);
			this.energyAmountText.SetText(LLHBDPPJJHC.MPMKMCJFHOG.ToString(), true);
		}
		else
		{
			this.energyIcon.SetActive(true);
			this.energyAmountText.gameObject.SetActive(false);
		}
		if (this.JIEBEFKGJIM.PJCIBAKAANH())
		{
			this.pricingText.SetText(this.JIEBEFKGJIM.FNJCEPLEPBH(), true);
			return;
		}
		if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.en && GeoLocationManager.PBAGPDDBABB())
		{
			this.pricingText.SetText("socialenteruseridmalformed2" + this.JIEBEFKGJIM.JKBLBOAHJDE, true);
			return;
		}
		this.pricingText.SetText("OnApplicationFocusBasicSyncSuccess" + this.JIEBEFKGJIM.DMODNDCLGEJ, true);
	}

	// Token: 0x060074C0 RID: 29888 RVA: 0x00347A90 File Offset: 0x00345C90
	public void MLJBPNHEFBO()
	{
		ProductThumbnailManager.lastAccessedProductWebLink = this.JIEBEFKGJIM.DJJCDNDMAGD() + "holdontitle" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.en && GeoLocationManager.IsRussia() && KDCJJBLGCBH.EHBBFMCILPC.EAMJBDKCDPA())
		{
			CommonUserInterface.EHBBFMCILPC.GIFCDFKBBCN(this.JIEBEFKGJIM.BIKJFCLHPBK() + "retry" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 2);
			return;
		}
		this.MDLICPCMOAE.IFCOMCGDBLF(this.JIEBEFKGJIM.DEJCCBNPFEC);
	}

	// Token: 0x060074C2 RID: 29890 RVA: 0x00347B30 File Offset: 0x00345D30
	public void MLJINODMGAB(PurchasingViewManager DDIPMIKIBJC, OCBIOPOEENJ LLHBDPPJJHC, OBHDGKFFICI GIHIPEOBPBF, ProducThumbnailGraphics KGKMPHJMKMG)
	{
		this.JIEBEFKGJIM = LLHBDPPJJHC;
		this.MDLICPCMOAE = DDIPMIKIBJC;
		if (LLHBDPPJJHC == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("HKDF output capped at 255 * HashLen bytes.");
			return;
		}
		if (GIHIPEOBPBF == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("steamid");
			return;
		}
		if (KGKMPHJMKMG == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("lobby");
			return;
		}
		if (this.thumbnailType == PLPHEPDHPJJ.wide)
		{
			this.productTitleText.SetText(GIHIPEOBPBF.MPCJNJCOCEK(), true);
			if (LLHBDPPJJHC.OHCDIAFPNFK.NPEOEAFOPJP() == 0)
			{
				this.bannerText.SetText(CCOJBMMKNAP.KNKGCDDMLDP().FIENAKIHNOM(""), false);
				this.banner.SetActive(true);
			}
			else
			{
				this.banner.SetActive(true);
				this.bannerText.SetText(CCOJBMMKNAP.BIAEAOMHBMM().MEPECBDCOLG(", "), true);
			}
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteWide;
		}
		else
		{
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteSquare;
		}
		if (LLHBDPPJJHC.MLNOFEEIBMI.GALKFKBPLCK() > 0)
		{
			this.salesObject.SetActive(true);
			this.salesText.SetText("Response Code: " + LLHBDPPJJHC.MLNOFEEIBMI.ToString() + "misc", false);
		}
		else
		{
			this.salesObject.SetActive(false);
		}
		if (LLHBDPPJJHC.ODMKLADKHMO.GALKFKBPLCK() > 1)
		{
			this.hardCurrencyIcon.SetActive(false);
			this.hardCurrencyAmountText.gameObject.SetActive(true);
			this.hardCurrencyAmountText.SetText(LLHBDPPJJHC.ODMKLADKHMO.ToString(), true);
		}
		else
		{
			this.hardCurrencyIcon.SetActive(true);
			this.hardCurrencyAmountText.gameObject.SetActive(false);
		}
		if (LLHBDPPJJHC.MPMKMCJFHOG.BFMPOACOBPN() > 0)
		{
			this.energyIcon.SetActive(false);
			this.energyAmountText.gameObject.SetActive(true);
			this.energyAmountText.SetText(LLHBDPPJJHC.MPMKMCJFHOG.ToString(), true);
		}
		else
		{
			this.energyIcon.SetActive(false);
			this.energyAmountText.gameObject.SetActive(false);
		}
		if (this.JIEBEFKGJIM.OKGPIEEOKBM())
		{
			this.pricingText.SetText(this.JIEBEFKGJIM.PKNNPAMOADM(), true);
			return;
		}
		if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.ru && GeoLocationManager.FDJONIACJKC())
		{
			this.pricingText.SetText("ok" + this.JIEBEFKGJIM.JKBLBOAHJDE, true);
			return;
		}
		this.pricingText.SetText("rwt" + this.JIEBEFKGJIM.DMODNDCLGEJ, true);
	}

	// Token: 0x060074C3 RID: 29891 RVA: 0x00347DA4 File Offset: 0x00345FA4
	public void FBACPHFCHJK(PurchasingViewManager DDIPMIKIBJC, OCBIOPOEENJ LLHBDPPJJHC, OBHDGKFFICI GIHIPEOBPBF, ProducThumbnailGraphics KGKMPHJMKMG)
	{
		this.JIEBEFKGJIM = LLHBDPPJJHC;
		this.MDLICPCMOAE = DDIPMIKIBJC;
		if (LLHBDPPJJHC == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("assetbundlecollectablecard");
			return;
		}
		if (GIHIPEOBPBF == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("AssetProfileData.GetCharSprite(): anthologyIndexStr is null or empty");
			return;
		}
		if (KGKMPHJMKMG == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("ok");
			return;
		}
		if (this.thumbnailType == PLPHEPDHPJJ.square)
		{
			this.productTitleText.SetText(GIHIPEOBPBF.DKFACKEAOAL(), false);
			if (LLHBDPPJJHC.OHCDIAFPNFK.PONAPMOOLIN() == 1)
			{
				this.bannerText.SetText(CCOJBMMKNAP.CEGAOMEEFBE().PPALCPINPLK("uid"), true);
				this.banner.SetActive(true);
			}
			else
			{
				this.banner.SetActive(false);
				this.bannerText.SetText(CCOJBMMKNAP.NIOJNOFGIJO().PGKBCNBAOJN("_TVDots"), false);
			}
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteWide;
		}
		else
		{
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteSquare;
		}
		if (LLHBDPPJJHC.MLNOFEEIBMI.GALKFKBPLCK() > 1)
		{
			this.salesObject.SetActive(false);
			this.salesText.SetText("dor" + LLHBDPPJJHC.MLNOFEEIBMI.ToString() + "OnAvatarCollectionEdit", false);
		}
		else
		{
			this.salesObject.SetActive(true);
		}
		if (LLHBDPPJJHC.ODMKLADKHMO.BADNAGEMINF() > 1)
		{
			this.hardCurrencyIcon.SetActive(true);
			this.hardCurrencyAmountText.gameObject.SetActive(true);
			this.hardCurrencyAmountText.SetText(LLHBDPPJJHC.ODMKLADKHMO.ToString(), false);
		}
		else
		{
			this.hardCurrencyIcon.SetActive(true);
			this.hardCurrencyAmountText.gameObject.SetActive(true);
		}
		if (LLHBDPPJJHC.MPMKMCJFHOG.GALKFKBPLCK() > 1)
		{
			this.energyIcon.SetActive(false);
			this.energyAmountText.gameObject.SetActive(true);
			this.energyAmountText.SetText(LLHBDPPJJHC.MPMKMCJFHOG.ToString(), false);
		}
		else
		{
			this.energyIcon.SetActive(false);
			this.energyAmountText.gameObject.SetActive(true);
		}
		if (this.JIEBEFKGJIM.HHALLBOKCJO())
		{
			this.pricingText.SetText(this.JIEBEFKGJIM.DOLEPIMNJLG(), true);
			return;
		}
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru && GeoLocationManager.FDJONIACJKC())
		{
			this.pricingText.SetText("grayscale_2" + this.JIEBEFKGJIM.JKBLBOAHJDE, false);
			return;
		}
		this.pricingText.SetText("$ENABLELOCALIZATIONEXTENSION" + this.JIEBEFKGJIM.DMODNDCLGEJ, false);
	}

	// Token: 0x060074C4 RID: 29892 RVA: 0x00348018 File Offset: 0x00346218
	public void DODNEEPIFGH(PurchasingViewManager DDIPMIKIBJC, OCBIOPOEENJ LLHBDPPJJHC, OBHDGKFFICI GIHIPEOBPBF, ProducThumbnailGraphics KGKMPHJMKMG)
	{
		this.JIEBEFKGJIM = LLHBDPPJJHC;
		this.MDLICPCMOAE = DDIPMIKIBJC;
		if (LLHBDPPJJHC == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("OnNeedToShowNoMoreEnergyPopup");
			return;
		}
		if (GIHIPEOBPBF == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("WideScreenScaler(): screen is to wide, video aspect ratio set to: VideoAspectRatio.FitHorizontally");
			return;
		}
		if (KGKMPHJMKMG == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("clthcm");
			return;
		}
		if (this.thumbnailType == PLPHEPDHPJJ.wide)
		{
			this.productTitleText.SetText(GIHIPEOBPBF.BFPLHHGNGIH(), true);
			if (LLHBDPPJJHC.OHCDIAFPNFK.MOBKGNBCIJF() == 0)
			{
				this.bannerText.SetText(CCOJBMMKNAP.KFDLFGHBPLP().JCDFHKDNEDH(" topMatch to display."), false);
				this.banner.SetActive(false);
			}
			else
			{
				this.banner.SetActive(true);
				this.bannerText.SetText(CCOJBMMKNAP.PLJMLDOCPNM().MEPECBDCOLG("newuseraddrequest2"), true);
			}
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteWide;
		}
		else
		{
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteSquare;
		}
		if (LLHBDPPJJHC.MLNOFEEIBMI.MDJHNAEGCCM() > 1)
		{
			this.salesObject.SetActive(false);
			this.salesText.SetText("passhintundo" + LLHBDPPJJHC.MLNOFEEIBMI.ToString() + "", true);
		}
		else
		{
			this.salesObject.SetActive(true);
		}
		if (LLHBDPPJJHC.ODMKLADKHMO.GALKFKBPLCK() > 0)
		{
			this.hardCurrencyIcon.SetActive(false);
			this.hardCurrencyAmountText.gameObject.SetActive(true);
			this.hardCurrencyAmountText.SetText(LLHBDPPJJHC.ODMKLADKHMO.ToString(), false);
		}
		else
		{
			this.hardCurrencyIcon.SetActive(false);
			this.hardCurrencyAmountText.gameObject.SetActive(false);
		}
		if (LLHBDPPJJHC.MPMKMCJFHOG.PONAPMOOLIN() > 0)
		{
			this.energyIcon.SetActive(false);
			this.energyAmountText.gameObject.SetActive(false);
			this.energyAmountText.SetText(LLHBDPPJJHC.MPMKMCJFHOG.ToString(), true);
		}
		else
		{
			this.energyIcon.SetActive(true);
			this.energyAmountText.gameObject.SetActive(false);
		}
		if (this.JIEBEFKGJIM.KIOLJNPKOOL())
		{
			this.pricingText.SetText(this.JIEBEFKGJIM.FNJCEPLEPBH(), true);
			return;
		}
		if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.ru && GeoLocationManager.NHMHNIFIOCO())
		{
			this.pricingText.SetText("profilenametitleshort" + this.JIEBEFKGJIM.JKBLBOAHJDE, false);
			return;
		}
		this.pricingText.SetText("{q}" + this.JIEBEFKGJIM.DMODNDCLGEJ, true);
	}

	// Token: 0x060074C5 RID: 29893 RVA: 0x0034828C File Offset: 0x0034648C
	public void NGCNFNNMPKC(PurchasingViewManager DDIPMIKIBJC, OCBIOPOEENJ LLHBDPPJJHC, OBHDGKFFICI GIHIPEOBPBF, ProducThumbnailGraphics KGKMPHJMKMG)
	{
		this.JIEBEFKGJIM = LLHBDPPJJHC;
		this.MDLICPCMOAE = DDIPMIKIBJC;
		if (LLHBDPPJJHC == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:");
			return;
		}
		if (GIHIPEOBPBF == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("chsf");
			return;
		}
		if (KGKMPHJMKMG == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("");
			return;
		}
		if (this.thumbnailType == PLPHEPDHPJJ.wide)
		{
			this.productTitleText.SetText(GIHIPEOBPBF.GOBAACCPNLJ(), false);
			if (LLHBDPPJJHC.OHCDIAFPNFK.NPEOEAFOPJP() == 0)
			{
				this.bannerText.SetText(CCOJBMMKNAP.KFDLFGHBPLP().BDGPNPNIAPA(", shopcur:"), false);
				this.banner.SetActive(false);
			}
			else
			{
				this.banner.SetActive(false);
				this.bannerText.SetText(CCOJBMMKNAP.BBGECIKOICE().JLBEIFLLBLO(" <i>"), true);
			}
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteWide;
		}
		else
		{
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteSquare;
		}
		if (LLHBDPPJJHC.MLNOFEEIBMI.HOJDOEDDIBD() > 0)
		{
			this.salesObject.SetActive(false);
			this.salesText.SetText(" prepared!" + LLHBDPPJJHC.MLNOFEEIBMI.ToString() + "areyousurerestartepbody1newcur", false);
		}
		else
		{
			this.salesObject.SetActive(false);
		}
		if (LLHBDPPJJHC.ODMKLADKHMO.BFMPOACOBPN() > 0)
		{
			this.hardCurrencyIcon.SetActive(false);
			this.hardCurrencyAmountText.gameObject.SetActive(false);
			this.hardCurrencyAmountText.SetText(LLHBDPPJJHC.ODMKLADKHMO.ToString(), true);
		}
		else
		{
			this.hardCurrencyIcon.SetActive(true);
			this.hardCurrencyAmountText.gameObject.SetActive(true);
		}
		if (LLHBDPPJJHC.MPMKMCJFHOG.GALKFKBPLCK() > 1)
		{
			this.energyIcon.SetActive(true);
			this.energyAmountText.gameObject.SetActive(false);
			this.energyAmountText.SetText(LLHBDPPJJHC.MPMKMCJFHOG.ToString(), true);
		}
		else
		{
			this.energyIcon.SetActive(true);
			this.energyAmountText.gameObject.SetActive(false);
		}
		if (this.JIEBEFKGJIM.OKGPIEEOKBM())
		{
			this.pricingText.SetText(this.JIEBEFKGJIM.FNJCEPLEPBH(), false);
			return;
		}
		if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.ru && GeoLocationManager.FDJONIACJKC())
		{
			this.pricingText.SetText(" entries from the user hidden list (ongoing) as obsolete." + this.JIEBEFKGJIM.JKBLBOAHJDE, false);
			return;
		}
		this.pricingText.SetText("onboardingthankyoutitle" + this.JIEBEFKGJIM.DMODNDCLGEJ, false);
	}

	// Token: 0x060074C6 RID: 29894 RVA: 0x00348500 File Offset: 0x00346700
	public void KKPKEJBGAAG(PurchasingViewManager DDIPMIKIBJC, OCBIOPOEENJ LLHBDPPJJHC, OBHDGKFFICI GIHIPEOBPBF, ProducThumbnailGraphics KGKMPHJMKMG)
	{
		this.JIEBEFKGJIM = LLHBDPPJJHC;
		this.MDLICPCMOAE = DDIPMIKIBJC;
		if (LLHBDPPJJHC == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("Trimming topMatchOngoing.Count by removing ");
			return;
		}
		if (GIHIPEOBPBF == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("gpforwardsubrequired");
			return;
		}
		if (KGKMPHJMKMG == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("");
			return;
		}
		if (this.thumbnailType == PLPHEPDHPJJ.square)
		{
			this.productTitleText.SetText(GIHIPEOBPBF.JPKGLGDELCJ(), true);
			if (LLHBDPPJJHC.OHCDIAFPNFK.PONAPMOOLIN() == 0)
			{
				this.bannerText.SetText(CCOJBMMKNAP.KLAKLFCOMJC().OHLNGCKIACD("pid"), true);
				this.banner.SetActive(true);
			}
			else
			{
				this.banner.SetActive(true);
				this.bannerText.SetText(CCOJBMMKNAP.AEELGGPEJCC().PKNHKGMNCIP("0"), false);
			}
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteWide;
		}
		else
		{
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteSquare;
		}
		if (LLHBDPPJJHC.MLNOFEEIBMI.HOJDOEDDIBD() > 1)
		{
			this.salesObject.SetActive(true);
			this.salesText.SetText("bucket" + LLHBDPPJJHC.MLNOFEEIBMI.ToString() + "yes", true);
		}
		else
		{
			this.salesObject.SetActive(false);
		}
		if (LLHBDPPJJHC.ODMKLADKHMO.MDJHNAEGCCM() > 1)
		{
			this.hardCurrencyIcon.SetActive(true);
			this.hardCurrencyAmountText.gameObject.SetActive(true);
			this.hardCurrencyAmountText.SetText(LLHBDPPJJHC.ODMKLADKHMO.ToString(), true);
		}
		else
		{
			this.hardCurrencyIcon.SetActive(false);
			this.hardCurrencyAmountText.gameObject.SetActive(false);
		}
		if (LLHBDPPJJHC.MPMKMCJFHOG.MOBKGNBCIJF() > 0)
		{
			this.energyIcon.SetActive(true);
			this.energyAmountText.gameObject.SetActive(true);
			this.energyAmountText.SetText(LLHBDPPJJHC.MPMKMCJFHOG.ToString(), false);
		}
		else
		{
			this.energyIcon.SetActive(true);
			this.energyAmountText.gameObject.SetActive(false);
		}
		if (this.JIEBEFKGJIM.KIOLJNPKOOL())
		{
			this.pricingText.SetText(this.JIEBEFKGJIM.PKNNPAMOADM(), false);
			return;
		}
		if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.en && GeoLocationManager.NHMHNIFIOCO())
		{
			this.pricingText.SetText("" + this.JIEBEFKGJIM.JKBLBOAHJDE, false);
			return;
		}
		this.pricingText.SetText("\n" + this.JIEBEFKGJIM.DMODNDCLGEJ, false);
	}

	// Token: 0x060074C7 RID: 29895 RVA: 0x00348774 File Offset: 0x00346974
	public void FEENHGLAKDI()
	{
		ProductThumbnailManager.lastAccessedProductWebLink = this.JIEBEFKGJIM.DJJCDNDMAGD() + "sslind" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.ru && GeoLocationManager.IsRussia() && KDCJJBLGCBH.EHBBFMCILPC.EAMJBDKCDPA())
		{
			CommonUserInterface.IKNOFBFMPGA().GIFCDFKBBCN(this.JIEBEFKGJIM.BIKJFCLHPBK() + "Opened from Gley Notification" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 3);
			return;
		}
		this.MDLICPCMOAE.GAAMAOLMOPA(this.JIEBEFKGJIM.DEJCCBNPFEC);
	}

	// Token: 0x060074C8 RID: 29896 RVA: 0x00348808 File Offset: 0x00346A08
	public void HGELPFDIMJK(PurchasingViewManager DDIPMIKIBJC, OCBIOPOEENJ LLHBDPPJJHC, OBHDGKFFICI GIHIPEOBPBF, ProducThumbnailGraphics KGKMPHJMKMG)
	{
		this.JIEBEFKGJIM = LLHBDPPJJHC;
		this.MDLICPCMOAE = DDIPMIKIBJC;
		if (LLHBDPPJJHC == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("BackendOperationsManager.RequestSaveChapterSnapshots, exception while initializing RSACryptoServiceProvider:");
			return;
		}
		if (GIHIPEOBPBF == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("wofrewardmsgcard3");
			return;
		}
		if (KGKMPHJMKMG == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("assetbundlesketchesdata");
			return;
		}
		if (this.thumbnailType == PLPHEPDHPJJ.wide)
		{
			this.productTitleText.SetText(GIHIPEOBPBF.PLNFOMAGMID(), false);
			if (LLHBDPPJJHC.OHCDIAFPNFK.MOBKGNBCIJF() == 1)
			{
				this.bannerText.SetText(CCOJBMMKNAP.BOFMCPPFAMO().MEPECBDCOLG("\n\n<align=\"center\"><size=100%><alpha=#88>"), true);
				this.banner.SetActive(false);
			}
			else
			{
				this.banner.SetActive(true);
				this.bannerText.SetText(CCOJBMMKNAP.AEELGGPEJCC().DNILNCLIHAP("params"), false);
			}
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteWide;
		}
		else
		{
			this.thumbnailImage.sprite = KGKMPHJMKMG.spriteSquare;
		}
		if (LLHBDPPJJHC.MLNOFEEIBMI.KGEGKPHEMOJ() > 1)
		{
			this.salesObject.SetActive(true);
			this.salesText.SetText("" + LLHBDPPJJHC.MLNOFEEIBMI.ToString() + "continue", true);
		}
		else
		{
			this.salesObject.SetActive(false);
		}
		if (LLHBDPPJJHC.ODMKLADKHMO.PONAPMOOLIN() > 0)
		{
			this.hardCurrencyIcon.SetActive(false);
			this.hardCurrencyAmountText.gameObject.SetActive(true);
			this.hardCurrencyAmountText.SetText(LLHBDPPJJHC.ODMKLADKHMO.ToString(), true);
		}
		else
		{
			this.hardCurrencyIcon.SetActive(true);
			this.hardCurrencyAmountText.gameObject.SetActive(false);
		}
		if (LLHBDPPJJHC.MPMKMCJFHOG.BADNAGEMINF() > 1)
		{
			this.energyIcon.SetActive(false);
			this.energyAmountText.gameObject.SetActive(false);
			this.energyAmountText.SetText(LLHBDPPJJHC.MPMKMCJFHOG.ToString(), true);
		}
		else
		{
			this.energyIcon.SetActive(true);
			this.energyAmountText.gameObject.SetActive(false);
		}
		if (this.JIEBEFKGJIM.OKGPIEEOKBM())
		{
			this.pricingText.SetText(this.JIEBEFKGJIM.DOLEPIMNJLG(), true);
			return;
		}
		if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.en && GeoLocationManager.PBAGPDDBABB())
		{
			this.pricingText.SetText("saveslotsoptionduplicate" + this.JIEBEFKGJIM.JKBLBOAHJDE, true);
			return;
		}
		this.pricingText.SetText(" (" + this.JIEBEFKGJIM.DMODNDCLGEJ, false);
	}

	// Token: 0x04002297 RID: 8855
	public static string lastAccessedProductWebLink = "https://romanceclub.com/";

	// Token: 0x04002298 RID: 8856
	public PLPHEPDHPJJ thumbnailType;

	// Token: 0x04002299 RID: 8857
	public Image thumbnailImage;

	// Token: 0x0400229A RID: 8858
	public TextMeshProUGUI productTitleText;

	// Token: 0x0400229B RID: 8859
	public GameObject banner;

	// Token: 0x0400229C RID: 8860
	public TextMeshProUGUI bannerText;

	// Token: 0x0400229D RID: 8861
	public GameObject salesObject;

	// Token: 0x0400229E RID: 8862
	public TextMeshProUGUI salesText;

	// Token: 0x0400229F RID: 8863
	public GameObject energyIcon;

	// Token: 0x040022A0 RID: 8864
	public TextMeshProUGUI energyAmountText;

	// Token: 0x040022A1 RID: 8865
	public GameObject hardCurrencyIcon;

	// Token: 0x040022A2 RID: 8866
	public TextMeshProUGUI hardCurrencyAmountText;

	// Token: 0x040022A3 RID: 8867
	public TextMeshProUGUI pricingText;

	// Token: 0x040022A4 RID: 8868
	private PurchasingViewManager MDLICPCMOAE;

	// Token: 0x040022A5 RID: 8869
	private OCBIOPOEENJ JIEBEFKGJIM;
}
