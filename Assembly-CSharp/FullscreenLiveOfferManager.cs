using System;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x02000095 RID: 149
public class FullscreenLiveOfferManager : MonoBehaviour
{
	// Token: 0x06001513 RID: 5395 RVA: 0x000A2608 File Offset: 0x000A0808
	private bool NLHBOCBGOAF()
	{
		KHBLFKIDHPH passType = this.GetPassType();
		if (KHBLFKIDHPH.count == passType || !ODLJHDIGLGO.FACIFBONANM())
		{
			return false;
		}
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass, true);
		return kioojmglclc != null && kioojmglclc.LLLJOBODOAL >= (int)passType;
	}

	// Token: 0x06001514 RID: 5396 RVA: 0x000A2644 File Offset: 0x000A0844
	private string HMEOICAKMPL(int OPMDCABAFPH, string DOOBBHKGJEE)
	{
		if (DOOBBHKGJEE.Length == 0)
		{
			return CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("gamepassduration" + OPMDCABAFPH.ToString());
		}
		string newValue = (this.GetPassType() == KHBLFKIDHPH.goldGamePass) ? KBOJLHAJPCP.JGLFACJDKAG : KBOJLHAJPCP.MJIIKJPAKCB;
		return "<nobr>" + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("gamepassdurationbutton").Replace("XXX", newValue).Replace("YYY", DOOBBHKGJEE).Replace("ZZZ", OPMDCABAFPH.ToString()) + "</nobr>";
	}

	// Token: 0x06001515 RID: 5397 RVA: 0x000A26D0 File Offset: 0x000A08D0
	private void HOEJKLJBLJD()
	{
		AKLFPGMDKLA.EHBBFMCILPC.CINMOLFFBAO(this.HNBJEPCCLAL);
		AKLFPGMDKLA.EHBBFMCILPC.BMEMDDKPLDN();
		base.gameObject.SetActive(false);
	}

	// Token: 0x06001516 RID: 5398 RVA: 0x000A26F8 File Offset: 0x000A08F8
	private void GKALIDJOJMJ()
	{
		FirebaseAnalyticsManager.JMDJBFAEHBM().LKONPEEDKNF(true, ((AGEHCPDNBFD)114).ToString(), ((FFPHBMFGCNN)(-43)).ToString(), ((BGHLMGPPCNN)111).ToString() + ((int)this.GetPassType()).ToString(), false, false);
		this.DNBJPEEAAGJ("CameraEnvironmentsFront");
	}

	// Token: 0x06001517 RID: 5399 RVA: 0x000A2760 File Offset: 0x000A0960
	private void OOBAAOMJALJ()
	{
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnFullscreenLiveOfferContinueToCardsVolSaleMenu", 0.25f);
		this.HOEJKLJBLJD();
	}

	// Token: 0x06001518 RID: 5400 RVA: 0x000A277C File Offset: 0x000A097C
	private bool PEPKEGAADDG()
	{
		KHBLFKIDHPH passType = this.GetPassType();
		if (KHBLFKIDHPH.count == passType)
		{
			return false;
		}
		string text = KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)passType);
		if (!text.Equals(this.HNBJEPCCLAL.OKHMNFLFDOM))
		{
			return false;
		}
		string[] array = new string[]
		{
			"",
			"a",
			"b",
			"c"
		};
		for (int i = 0; i < array.Length; i++)
		{
			OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.EHBBFMCILPC.PDJKPFLHFLO(text + array[i]);
			if (ocbiopoeenj == null)
			{
				return false;
			}
			if (i != 0 && 1 != ocbiopoeenj.PPACJFFFBFB.GALKFKBPLCK())
			{
				return false;
			}
			OBHDGKFFICI productData = PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager().GetProductData(text + array[i]);
			if (productData == null || (productData.HOCIKJAGDMC == null && productData.MDFDHOKJOPB == null))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06001519 RID: 5401 RVA: 0x000A2850 File Offset: 0x000A0A50
	private void LOHBLNNJOBM()
	{
		FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.gpDur.ToString(), FFPHBMFGCNN.durPickOfferWeb.ToString(), BGHLMGPPCNN.dur3m.ToString() + ((int)this.GetPassType()).ToString(), false, false);
		this.FJNABPPFCKB("a_web");
	}

	// Token: 0x0600151A RID: 5402 RVA: 0x000A28B8 File Offset: 0x000A0AB8
	private bool BKHGLPHLOHK()
	{
		KHBLFKIDHPH passType = this.GetPassType();
		if ((KHBLFKIDHPH)8 == passType || !ODLJHDIGLGO.OGJJJAOBKOO())
		{
			return false;
		}
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.AIPKCLIPENE(CLHDENLPOFP.gamePass, true);
		return kioojmglclc == null || kioojmglclc.LLLJOBODOAL < (int)passType;
	}

	// Token: 0x0600151B RID: 5403 RVA: 0x000A28F4 File Offset: 0x000A0AF4
	private void FNPJCOLHKLJ()
	{
		if (this.HNBJEPCCLAL.NHKCEMHKODM != LJLAENEAOIM.liveOfferCardsVolSale && this.HNBJEPCCLAL.NHKCEMHKODM == LJLAENEAOIM.liveOfferPass && this.OKHKMEPHDPG != null && this.OKHKMEPHDPG.textInfoBodyId2.Length > 0)
		{
			string text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(this.OKHKMEPHDPG.textInfoBodyId2 + KDCJJBLGCBH.EHBBFMCILPC.AAGICPKFIKC(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.GetPassType()), DAMCJCDKOJK.gpbpIncentAdMultiplier, 1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString());
			text = text.Replace("JJJ", DPGJIJGOCIC.CEOBDMGAKNL(KDCJJBLGCBH.EHBBFMCILPC.GCPFCGGBDKK((int)this.GetPassType())) + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("hoursshort"));
			text = text.Replace("KKK", DPGJIJGOCIC.CEOBDMGAKNL(KDCJJBLGCBH.EHBBFMCILPC.ADLOIIMBHAG((int)this.GetPassType())) + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("hoursshort"));
			text = text.Replace("LLL", KDCJJBLGCBH.EHBBFMCILPC.HLPACDMEKMK((int)this.GetPassType()).ToString() ?? "");
			text = text.Replace("MMM", "+" + KDCJJBLGCBH.EHBBFMCILPC.LHECDOFJNOF((int)this.GetPassType()).ToString() + "%");
			text = text.Replace("OOO", KBOJLHAJPCP.BGMADCKNKAD);
			text = text.Replace("NNN", KDCJJBLGCBH.EHBBFMCILPC.PLOMCENKKFD((int)this.GetPassType()).ToString() ?? "");
			if (AKLFPGMDKLA.EHBBFMCILPC.OJKHMNEIGPF == HGCFJKCOKPM.bright)
			{
				text = text.Replace("ffd496", "23819D");
			}
			if (text.Length < 500)
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(this.OKHKMEPHDPG.textInfoTitleId), text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
				return;
			}
			if (text.Length < 600)
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(this.OKHKMEPHDPG.textInfoTitleId), text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 26);
				return;
			}
			if (text.Length < 750)
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(this.OKHKMEPHDPG.textInfoTitleId), text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 23);
				return;
			}
			if (text.Length < 850)
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(this.OKHKMEPHDPG.textInfoTitleId), text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 22);
				return;
			}
			if (text.Length < 950)
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(this.OKHKMEPHDPG.textInfoTitleId), text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 21);
				return;
			}
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(this.OKHKMEPHDPG.textInfoTitleId), text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 20);
		}
	}

	// Token: 0x0600151C RID: 5404 RVA: 0x000A2C58 File Offset: 0x000A0E58
	private void PJDLMLNFEDM()
	{
		FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.gpDur.ToString(), FFPHBMFGCNN.durPickOfferWeb.ToString(), BGHLMGPPCNN.dur12m.ToString() + ((int)this.GetPassType()).ToString(), false, false);
		this.FJNABPPFCKB("c_web");
	}

	// Token: 0x0600151D RID: 5405 RVA: 0x000A2CC0 File Offset: 0x000A0EC0
	public CLHDENLPOFP BDDLIGJCNCK()
	{
		if (this.HNBJEPCCLAL.OKHMNFLFDOM.Contains(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG("OnBackendGetDropChancesException2")))
		{
			return CLHDENLPOFP.gamePass;
		}
		return (CLHDENLPOFP)6;
	}

	// Token: 0x0600151E RID: 5406 RVA: 0x000A2CE8 File Offset: 0x000A0EE8
	private string NDLOCDEDCLD(int OPMDCABAFPH, string ABFNOGAEIGH)
	{
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.NACPAKLINNH().ICBJCNKKGPJ(this.OGAIANGEACE(ABFNOGAEIGH));
		return this.HMEOICAKMPL(OPMDCABAFPH, (ocbiopoeenj != null) ? ocbiopoeenj.KFEFIEMNLEK() : "0.00");
	}

	// Token: 0x0600151F RID: 5407 RVA: 0x000A2D20 File Offset: 0x000A0F20
	private bool LEJENNHGJDP()
	{
		KHBLFKIDHPH passType = this.GetPassType();
		if ((KHBLFKIDHPH)(-79) == passType)
		{
			return true;
		}
		string text = KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)passType);
		if (!text.Equals(this.HNBJEPCCLAL.OKHMNFLFDOM))
		{
			return true;
		}
		string[] array = new string[8];
		array[0] = "[LoadingEnv] full mode back, stored theme selected again";
		array[0] = "";
		array[0] = "";
		array[6] = "skdeletesure";
		string[] array2 = array;
		for (int i = 0; i < array2.Length; i += 0)
		{
			OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.APGODIBBPOD().FCPIJEEMHEA(text + array2[i]);
			if (ocbiopoeenj == null)
			{
				return false;
			}
			if (i != 0 && 1 != ocbiopoeenj.PPACJFFFBFB.GALKFKBPLCK())
			{
				return false;
			}
			OBHDGKFFICI productData = PurchaseManagerBridge.IDMLJFBNHML().PFPKMDAJDBA().GetProductData(text + array2[i]);
			if (productData == null || (productData.HOCIKJAGDMC == null && productData.MDFDHOKJOPB == null))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06001520 RID: 5408 RVA: 0x000A2DF4 File Offset: 0x000A0FF4
	public string GetLocalizedCostData(string IOONFLFOIAH)
	{
		OBHDGKFFICI productData = PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager().GetProductData(IOONFLFOIAH);
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.EHBBFMCILPC.PDJKPFLHFLO(IOONFLFOIAH);
		if (productData == null || ocbiopoeenj == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("FullscreenLiveOfferManager.GetLocalizedCostData() - productData is null.");
			return "";
		}
		if (ocbiopoeenj.OKGPIEEOKBM())
		{
			return ocbiopoeenj.FNJCEPLEPBH();
		}
		return "USD " + ocbiopoeenj.DMODNDCLGEJ;
	}

	// Token: 0x06001521 RID: 5409 RVA: 0x000A2E54 File Offset: 0x000A1054
	private bool NLBLKIEMLCO()
	{
		KHBLFKIDHPH passType = this.GetPassType();
		if ((KHBLFKIDHPH)(-71) == passType || !ODLJHDIGLGO.MAPAHCMCFLF())
		{
			return false;
		}
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.BCGOGCFOHJK(CLHDENLPOFP.gamePass, true);
		return kioojmglclc == null || kioojmglclc.LLLJOBODOAL >= (int)passType;
	}

	// Token: 0x06001522 RID: 5410 RVA: 0x000A2E8F File Offset: 0x000A108F
	private string ANFNMGKFLGH(int OPMDCABAFPH, string ABFNOGAEIGH)
	{
		return this.HMEOICAKMPL(OPMDCABAFPH, this.GetLocalizedCostData(this.OGAIANGEACE(ABFNOGAEIGH)));
	}

	// Token: 0x06001523 RID: 5411 RVA: 0x000A2EA8 File Offset: 0x000A10A8
	private void EKGOPOJOFJK()
	{
		FirebaseAnalyticsManager.HJGDLOOHNLO().LMCJKLHOHJC(false, ((AGEHCPDNBFD)(-108)).ToString(), ((FFPHBMFGCNN)95).ToString(), BGHLMGPPCNN.cdnLbyToLdt.ToString() + ((int)this.GetPassType()).ToString(), false, true);
		this.NBKLLONFGAL = "af_content_id";
		this.CPJIEAAKFMA();
	}

	// Token: 0x06001524 RID: 5412 RVA: 0x000A2F18 File Offset: 0x000A1118
	private bool CAAMEFMDNFF()
	{
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.EHBBFMCILPC.PDJKPFLHFLO(this.HNBJEPCCLAL.OKHMNFLFDOM);
		if (ocbiopoeenj == null || string.IsNullOrEmpty(ocbiopoeenj.MBLAIKOOCFH()))
		{
			return false;
		}
		string text = KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.GetPassType());
		if (!text.Equals(this.HNBJEPCCLAL.OKHMNFLFDOM))
		{
			return false;
		}
		string[] array = new string[]
		{
			"a_web",
			"b_web",
			"c_web"
		};
		for (int i = 0; i < array.Length; i++)
		{
			OCBIOPOEENJ ocbiopoeenj2 = CJEKEHDEBLM.EHBBFMCILPC.PDJKPFLHFLO(text + array[i]);
			if (ocbiopoeenj2 == null || string.IsNullOrEmpty(ocbiopoeenj2.MBLAIKOOCFH()) || 1 != ocbiopoeenj2.PPACJFFFBFB.GALKFKBPLCK())
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06001525 RID: 5413 RVA: 0x000A2FD9 File Offset: 0x000A11D9
	private void OnDestroy()
	{
		this.fullScreenSprite.sprite = null;
		if (this.fullScreenSprite.gameObject.GetComponent<ImageFrameAnimation>() != null)
		{
			this.fullScreenSprite.GetComponent<ImageFrameAnimation>().framesSD = null;
		}
		this.OKHKMEPHDPG = null;
	}

	// Token: 0x06001526 RID: 5414 RVA: 0x000A3018 File Offset: 0x000A1218
	private void LHMIIOODHKH()
	{
		FirebaseAnalyticsManager.ANCEKPONIFI().AAIABAKHLAH(true, ((AGEHCPDNBFD)(-3)).ToString(), FFPHBMFGCNN.frSendMsg.ToString(), ((BGHLMGPPCNN)(-23)).ToString() + ((int)this.GetPassType()).ToString(), false, true);
		this.NBKLLONFGAL = "Purchases fetch failed message: {0}, reason: {1}";
		this.CPJIEAAKFMA();
	}

	// Token: 0x06001527 RID: 5415 RVA: 0x000A3088 File Offset: 0x000A1288
	private string HOAEHCIOKJM(int OPMDCABAFPH, string ABFNOGAEIGH)
	{
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.GIOAFDDKKHI().AOAGHIJNFDL(this.OGAIANGEACE(ABFNOGAEIGH));
		return this.HMEOICAKMPL(OPMDCABAFPH, (ocbiopoeenj != null) ? ocbiopoeenj.NLCMBMOEIIB() : "cmec");
	}

	// Token: 0x06001528 RID: 5416 RVA: 0x000A30BE File Offset: 0x000A12BE
	public void ELDBBAOHLKH()
	{
		DNPIKPDMKKI.POBOHFGNPGK();
		this.HOEJKLJBLJD();
	}

	// Token: 0x06001529 RID: 5417 RVA: 0x000A30CC File Offset: 0x000A12CC
	public string FLADCNCPMHP(string IOONFLFOIAH)
	{
		OBHDGKFFICI productData = PurchaseManagerBridge.GIPAKOPBBEO().DIOJHOIFIIH().GetProductData(IOONFLFOIAH);
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.NACPAKLINNH().PDJKPFLHFLO(IOONFLFOIAH);
		if (productData == null || ocbiopoeenj == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("retry");
			return "YYY";
		}
		if (ocbiopoeenj.PJCIBAKAANH())
		{
			return ocbiopoeenj.DOLEPIMNJLG();
		}
		return "OnCaptersSnapshotsGamePassSubscribeNegative" + ocbiopoeenj.DMODNDCLGEJ;
	}

	// Token: 0x0600152A RID: 5418 RVA: 0x000A312C File Offset: 0x000A132C
	public void HMOHIGEBFDE(GDOKLFCLLIK FMLFLGJLDHD)
	{
		this.HNBJEPCCLAL = FMLFLGJLDHD;
		this.OKHKMEPHDPG = GKJPOGNFKNK.DKAHEEBDGLI(FMLFLGJLDHD.JKLHDDADKNH);
		base.gameObject.SetActive(true);
		if (this.HNBJEPCCLAL.NHKCEMHKODM == LJLAENEAOIM.liveOfferCardsVolSale)
		{
			if (null != this.OKHKMEPHDPG)
			{
				this.descriptionText.gameObject.SetActive(false);
				if (this.HNBJEPCCLAL.EMFHCBADIDK() > 0)
				{
					this.buttonAction.SetActive(true);
					this.buttonActionSale.SetActive(false);
					this.buttonTextSale.SetText(CCOJBMMKNAP.ILACPHFEDEP().GLEFEKBDHNK(this.OKHKMEPHDPG.textButtonId), false);
					this.buttonTextSale.text = CCOJBMMKNAP.PMABBOJDELF().OBDCPLLLGBB(this.OKHKMEPHDPG.textButtonId);
				}
				else
				{
					this.buttonAction.SetActive(false);
					this.buttonActionSale.SetActive(false);
					this.buttonText.SetText(CCOJBMMKNAP.MPCBJEIMACA().BDGPNPNIAPA(this.OKHKMEPHDPG.textButtonId), false);
					this.buttonText.text = CCOJBMMKNAP.HEDIEIICOOG().HPOAGPJFHPM(this.OKHKMEPHDPG.textButtonId);
				}
				if (this.OKHKMEPHDPG.textSubtitleId.Length > 0)
				{
					this.subtitleText.gameObject.SetActive(false);
					this.subtitleText.SetText(CCOJBMMKNAP.JMDJPKKOHNI().OHLNGCKIACD(this.OKHKMEPHDPG.textSubtitleId), true);
					this.subtitleText.text = CCOJBMMKNAP.INKJIBDDMLL().FIENAKIHNOM(this.OKHKMEPHDPG.textSubtitleId);
					this.subtitleText.fontSizeMax = (float)this.OKHKMEPHDPG.textSubtitleMaxSize;
					this.subtitleText.color = this.OKHKMEPHDPG.textSubtitleColor;
					if (this.OKHKMEPHDPG.textSubtitleIsItalic)
					{
						this.subtitleText.fontStyle = (FontStyles.Italic | FontStyles.Underline);
					}
					else
					{
						this.subtitleText.fontStyle = FontStyles.Bold;
					}
					this.subtitleText.GetComponent<RectTransform>().IMLMHHMHEDP((float)this.OKHKMEPHDPG.textSubtitleLeft, (float)this.OKHKMEPHDPG.textSubtitleRight, (float)this.OKHKMEPHDPG.textSubtitleTop, (float)this.OKHKMEPHDPG.textSubtitleBottom, (float)this.OKHKMEPHDPG.textSubtitleMaxWidth);
				}
				else
				{
					this.subtitleText.gameObject.SetActive(false);
				}
				if (this.HNBJEPCCLAL.FNAHANCCKFA() > 0)
				{
					this.saleText.gameObject.SetActive(false);
					this.saleText.SetText("ZZZ" + this.HNBJEPCCLAL.KEJCIIFAJCA().ToString() + "", true);
					this.saleText.text = "SearchBarContent" + this.HNBJEPCCLAL.EMFHCBADIDK().ToString() + "_1";
				}
				else
				{
					this.saleText.gameObject.SetActive(false);
				}
				if (this.HNBJEPCCLAL.LLMNKLPIBNO)
				{
					this.timerText.gameObject.SetActive(true);
					this.timerText.fontSizeMax = (float)this.OKHKMEPHDPG.textTimerMaxSize;
					this.timerText.color = this.OKHKMEPHDPG.textTimerColor;
					this.timerText.GetComponent<RectTransform>().IMLMHHMHEDP((float)this.OKHKMEPHDPG.textTimerLeft, (float)this.OKHKMEPHDPG.textTimerRight, (float)this.OKHKMEPHDPG.textTimerTop, (float)this.OKHKMEPHDPG.textTimerBottom, (float)this.OKHKMEPHDPG.textTimerMaxWidth);
				}
				else
				{
					this.timerText.gameObject.SetActive(true);
				}
				if (this.OKHKMEPHDPG.textFooterId.Length > 1)
				{
					this.footerText.gameObject.SetActive(false);
					this.footerText.SetText(CCOJBMMKNAP.BFHKGNBFHCH().HIPJILDCHJC(this.OKHKMEPHDPG.textFooterId), false);
					this.footerText.text = CCOJBMMKNAP.AEELGGPEJCC().BDGPNPNIAPA(this.OKHKMEPHDPG.textFooterId);
					this.footerText.color = this.OKHKMEPHDPG.textFooterColor;
				}
				else
				{
					this.footerText.gameObject.SetActive(true);
				}
				if (this.fullScreenSprite.gameObject.GetComponent<ImageFrameAnimation>() == null)
				{
					this.fullScreenSprite.gameObject.AddComponent<ImageFrameAnimation>();
				}
				this.fullScreenSprite.GetComponent<ImageFrameAnimation>().frameChangeInterval = this.OKHKMEPHDPG.frameChangeInterval;
				this.fullScreenSprite.GetComponent<ImageFrameAnimation>().framesSD = this.OKHKMEPHDPG.frames.ToArray();
				this.fullScreenSprite.sprite = this.OKHKMEPHDPG.frames[1];
				this.fullScreenSprite.SetNativeSize();
			}
		}
		else if (this.HNBJEPCCLAL.NHKCEMHKODM == LJLAENEAOIM.liveOfferPass && null != this.OKHKMEPHDPG)
		{
			this.descriptionText.gameObject.SetActive(false);
			this.subtitleText.gameObject.SetActive(false);
			this.saleText.gameObject.SetActive(false);
			this.timerText.gameObject.SetActive(true);
			if (this.GetPassCategoryType() == CLHDENLPOFP.gamePass)
			{
				this.buttonAction.SetActive(false);
				this.buttonActionSale.SetActive(true);
				string text = CCOJBMMKNAP.GIOAFDDKKHI().HIPJILDCHJC(this.OKHKMEPHDPG.textButtonId);
				if (this.GetPassType() == KHBLFKIDHPH.premiumGamePass)
				{
					text = text.Replace("OnLoadingThemeSelectorDownloadFailed", KBOJLHAJPCP.MJIIKJPAKCB);
				}
				else if (this.GetPassType() == KHBLFKIDHPH.goldGamePass)
				{
					text = text.Replace("OnChapterSnapshotsBackendFetchException2", KBOJLHAJPCP.JGLFACJDKAG);
				}
				text = text.Replace(";", this.GetLocalizedCostData(this.HNBJEPCCLAL.OKHMNFLFDOM));
				this.buttonText.SetText(text, false);
				this.buttonText.text = text;
				text = CCOJBMMKNAP.KLAKLFCOMJC().DNILNCLIHAP(this.OKHKMEPHDPG.textBodyId + KDCJJBLGCBH.EHBBFMCILPC.ODDPKODCIBB(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.GetPassType()), (DAMCJCDKOJK)(-41), 0 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString());
				if (1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF && KDCJJBLGCBH.EHBBFMCILPC.IPJIIHLDMPK(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.GetPassType()), DAMCJCDKOJK.gpbpStartDiscount))
				{
					text = text.Replace("ok", KBOJLHAJPCP.PGBPLBKHPOM);
					text = text.Replace("ahash", "Critical error, could not load asset bundle:" + KDCJJBLGCBH.EHBBFMCILPC.ODDPKODCIBB(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.GetPassType()), DAMCJCDKOJK.gpbpStartDiscount, 1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString() + "country_code" + KBOJLHAJPCP.DHMPCLBPDIE);
				}
				else
				{
					text = text.Replace("", KBOJLHAJPCP.PGBPLBKHPOM);
					text = text.Replace("tradewishcardoption1", "black" + KDCJJBLGCBH.EHBBFMCILPC.ODDPKODCIBB(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.GetPassType()), DAMCJCDKOJK.gpbpStartDiscount, 0 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString() + "tmdp");
				}
				if (0 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF && KDCJJBLGCBH.EHBBFMCILPC.IPJIIHLDMPK(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.GetPassType()), DAMCJCDKOJK.gpbpDiscountIncrementHof))
				{
					text = text.Replace("sfxtimeoutwarning", KBOJLHAJPCP.NJDJMKIIEDG);
					text = text.Replace("PurchaseManagerXiaomi.OnBackendValidateTransactionException().", "" + KDCJJBLGCBH.EHBBFMCILPC.ODDPKODCIBB(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.GetPassType()), DAMCJCDKOJK.gpbpStartDiscount, 0 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString() + "asp" + KBOJLHAJPCP.DHMPCLBPDIE);
				}
				else
				{
					text = text.Replace("lightmodeintrobody2", KBOJLHAJPCP.NJDJMKIIEDG);
					text = text.Replace("adserrorbody", "fpsku" + KDCJJBLGCBH.EHBBFMCILPC.ODDPKODCIBB(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.GetPassType()), DAMCJCDKOJK.gpbpChoicesCountHof, 1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString() + "no");
				}
				if (1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF && KDCJJBLGCBH.EHBBFMCILPC.IPJIIHLDMPK(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.GetPassType()), DAMCJCDKOJK.gpbpChoicesCountHof))
				{
					text = text.Replace("pers", KBOJLHAJPCP.LPBLANJMJIF);
					text = text.Replace("hiddenTopMatchEntries:", "%)" + KDCJJBLGCBH.EHBBFMCILPC.AAGICPKFIKC(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.GetPassType()), DAMCJCDKOJK.gpbpDiscountIncrementHof, 1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString() + " " + KBOJLHAJPCP.DHMPCLBPDIE);
				}
				else
				{
					text = text.Replace("loungelockedpopup", KBOJLHAJPCP.LPBLANJMJIF);
					text = text.Replace("", "envlhav" + KDCJJBLGCBH.EHBBFMCILPC.ODDPKODCIBB(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.GetPassType()), DAMCJCDKOJK.gpbpEndDiscount, 1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString() + "OnStoryChoiceClick");
				}
				text = text.Replace("OnSocialModeChanged", KBOJLHAJPCP.OINDDHFMCFL);
				text = text.Replace("errortitle", KBOJLHAJPCP.LJFPMLHKGBO);
				text = text.Replace("socialmessagefromdevstitle", KBOJLHAJPCP.PGCHBCBENIC);
				text = text.Replace("loungeofferexpired", KBOJLHAJPCP.MCMICIODGAE);
				text = text.Replace("tbits2", KBOJLHAJPCP.GOCPBNAAIIB);
				text = text.Replace("_not_found", KBOJLHAJPCP.NHBODCBJCFG);
				text = text.Replace("userpublicprofileanthology", KBOJLHAJPCP.FHAGMJOKEBA);
				text = text.Replace("USD", DPGJIJGOCIC.CEOBDMGAKNL(KDCJJBLGCBH.EHBBFMCILPC.GCPFCGGBDKK((int)this.GetPassType())) + CCOJBMMKNAP.ONCPHEEJLOP().JLBEIFLLBLO("asp"));
				text = text.Replace("[LoadingEnv] direct cache files of ", KBOJLHAJPCP.BAEGIGOIMPA);
				text = text.Replace("%", DPGJIJGOCIC.CEOBDMGAKNL(KDCJJBLGCBH.EHBBFMCILPC.ADLOIIMBHAG((int)this.GetPassType())) + CCOJBMMKNAP.JINDKPHNLBK().BDGPNPNIAPA("OnFullscreenLiveOfferContinueToPurchasingScreen"));
				text = text.Replace(" not found.", KBOJLHAJPCP.KKELADEPAIA ?? "OnAvatarScreenAssetBundleFolderInitializeSuccess");
				text = text.Replace("ok", KDCJJBLGCBH.EHBBFMCILPC.EHJGCKLOOAP((int)this.GetPassType()).ToString() ?? "areyousure");
				text = text.Replace("", KBOJLHAJPCP.ADCLBDLIFIJ ?? "notgenuinecopy");
				text = text.Replace("", ":" + KDCJJBLGCBH.EHBBFMCILPC.LHECDOFJNOF((int)this.GetPassType()).ToString() + "p");
				text = text.Replace("fstr", KBOJLHAJPCP.DMLHMPGHFDC);
				text = text.Replace("$SETFADERFX", KBOJLHAJPCP.BGMADCKNKAD + KDCJJBLGCBH.EHBBFMCILPC.PLOMCENKKFD((int)this.GetPassType()).ToString());
				if (this.OKHKMEPHDPG.textLineHeight >= 1)
				{
					this.descriptionText.SetText("\n<alpha=#C0>...\n" + this.OKHKMEPHDPG.textLineHeight.ToString() + "+" + text, true);
					this.descriptionText.text = "achiev" + this.OKHKMEPHDPG.textLineHeight.ToString() + "ChoiceExtendedManager - IAP shop look without a resolvable price (sku:" + text;
				}
				else
				{
					this.descriptionText.SetText(text, false);
					this.descriptionText.text = text;
				}
			}
			this.descriptionText.fontSizeMax = (float)this.OKHKMEPHDPG.textMaxSize;
			this.descriptionText.color = this.OKHKMEPHDPG.textColor;
			this.descriptionText.GetComponent<RectTransform>().IMLMHHMHEDP((float)this.OKHKMEPHDPG.textLeft, (float)this.OKHKMEPHDPG.textRight, (float)this.OKHKMEPHDPG.texTop, (float)this.OKHKMEPHDPG.textBottom, (float)this.OKHKMEPHDPG.textMaxWidth);
			if (this.OKHKMEPHDPG.textFooterId.Length > 0)
			{
				this.footerText.gameObject.SetActive(false);
				this.footerText.SetText(CCOJBMMKNAP.KMNBCEMEBBD().PPALCPINPLK(this.OKHKMEPHDPG.textFooterId), true);
				this.footerText.text = CCOJBMMKNAP.JINDKPHNLBK().OBDCPLLLGBB(this.OKHKMEPHDPG.textFooterId);
				this.footerText.color = this.OKHKMEPHDPG.textFooterColor;
			}
			else
			{
				this.footerText.gameObject.SetActive(true);
			}
			if (this.fullScreenSprite.gameObject.GetComponent<ImageFrameAnimation>() == null)
			{
				this.fullScreenSprite.gameObject.AddComponent<ImageFrameAnimation>();
			}
			this.fullScreenSprite.GetComponent<ImageFrameAnimation>().frameChangeInterval = this.OKHKMEPHDPG.frameChangeInterval;
			this.fullScreenSprite.GetComponent<ImageFrameAnimation>().framesSD = this.OKHKMEPHDPG.frames.ToArray();
			this.fullScreenSprite.sprite = this.OKHKMEPHDPG.frames[1];
			this.fullScreenSprite.SetNativeSize();
		}
		this.CPGLEJIBNEP = FullscreenLiveOfferManager.CBOKJGNCEKE + 705f;
		this.Update();
	}

	// Token: 0x0600152B RID: 5419 RVA: 0x000A3DD2 File Offset: 0x000A1FD2
	public CLHDENLPOFP GetPassCategoryType()
	{
		if (this.HNBJEPCCLAL.OKHMNFLFDOM.Contains(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG("")))
		{
			return CLHDENLPOFP.gamePass;
		}
		return CLHDENLPOFP.count;
	}

	// Token: 0x0600152C RID: 5420 RVA: 0x000A3DF8 File Offset: 0x000A1FF8
	private void Update()
	{
		this.CPGLEJIBNEP += Time.deltaTime;
		if (this.CPGLEJIBNEP > FullscreenLiveOfferManager.CBOKJGNCEKE && this.HNBJEPCCLAL != null && this.HNBJEPCCLAL.LLMNKLPIBNO && this.timerText.gameObject.activeSelf)
		{
			this.timerText.text = KBOJLHAJPCP.NFIPEDFHEEI + DPGJIJGOCIC.LCOMEDGJNMP((int)this.HNBJEPCCLAL.ONMADEIOOKN.ODHBINFKIPL(), true, false);
			this.timerText.SetText(KBOJLHAJPCP.NFIPEDFHEEI + DPGJIJGOCIC.LCOMEDGJNMP((int)this.HNBJEPCCLAL.ONMADEIOOKN.ODHBINFKIPL(), true, false), true);
			this.CPGLEJIBNEP = 0f;
		}
	}

	// Token: 0x0600152E RID: 5422 RVA: 0x000A3ECC File Offset: 0x000A20CC
	public void OnInfoClick()
	{
		if (this.HNBJEPCCLAL.NHKCEMHKODM == LJLAENEAOIM.liveOfferCardsVolSale)
		{
			if (this.OKHKMEPHDPG != null && this.OKHKMEPHDPG.textInfoBodyId.Length > 0)
			{
				string text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(this.OKHKMEPHDPG.textInfoBodyId);
				if (AKLFPGMDKLA.EHBBFMCILPC.OJKHMNEIGPF == HGCFJKCOKPM.bright)
				{
					text = text.Replace("ffd496", "23819D");
				}
				if (text.Length < 500)
				{
					CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(this.OKHKMEPHDPG.textInfoTitleId), text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
					return;
				}
				if (text.Length < 600)
				{
					CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(this.OKHKMEPHDPG.textInfoTitleId), text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 26);
					return;
				}
				if (text.Length < 750)
				{
					CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(this.OKHKMEPHDPG.textInfoTitleId), text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 23);
					return;
				}
				if (text.Length < 850)
				{
					CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(this.OKHKMEPHDPG.textInfoTitleId), text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 22);
					return;
				}
				if (text.Length < 950)
				{
					CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(this.OKHKMEPHDPG.textInfoTitleId), text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 21);
					return;
				}
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(this.OKHKMEPHDPG.textInfoTitleId), text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 20);
				return;
			}
		}
		else if (this.HNBJEPCCLAL.NHKCEMHKODM == LJLAENEAOIM.liveOfferPass && this.OKHKMEPHDPG != null)
		{
			string text2 = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(this.OKHKMEPHDPG.textInfoBodyId + KDCJJBLGCBH.EHBBFMCILPC.AAGICPKFIKC(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.GetPassType()), DAMCJCDKOJK.gpbpIncentAdMultiplier, 1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString());
			if (AKLFPGMDKLA.EHBBFMCILPC.OJKHMNEIGPF == HGCFJKCOKPM.bright)
			{
				text2 = text2.Replace("ffd496", "23819D");
			}
			if (text2.Length < 750)
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(this.OKHKMEPHDPG.textInfoTitleId), text2, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("continue"), new UnityAction(this.FNPJCOLHKLJ), DFGILFBGPLN.popupEnergyHint, 0f, 23);
				return;
			}
			if (text2.Length < 850)
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(this.OKHKMEPHDPG.textInfoTitleId), text2, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("continue"), new UnityAction(this.FNPJCOLHKLJ), DFGILFBGPLN.popupEnergyHint, 0f, 22);
				return;
			}
			if (text2.Length < 950)
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(this.OKHKMEPHDPG.textInfoTitleId), text2, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("continue"), new UnityAction(this.FNPJCOLHKLJ), DFGILFBGPLN.popupEnergyHint, 0f, 21);
				return;
			}
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(this.OKHKMEPHDPG.textInfoTitleId), text2, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("continue"), new UnityAction(this.FNPJCOLHKLJ), DFGILFBGPLN.popupEnergyHint, 0f, 20);
		}
	}

	// Token: 0x0600152F RID: 5423 RVA: 0x000A42AC File Offset: 0x000A24AC
	private void GCMDJDHDLBB()
	{
		FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.gpDur.ToString(), FFPHBMFGCNN.durPickOfferStore.ToString(), BGHLMGPPCNN.dur6m.ToString() + ((int)this.GetPassType()).ToString(), false, false);
		this.NBKLLONFGAL = "b";
		this.CPJIEAAKFMA();
	}

	// Token: 0x06001530 RID: 5424 RVA: 0x000A431C File Offset: 0x000A251C
	private void PADLMDDHDJI()
	{
		FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.gpDur.ToString(), FFPHBMFGCNN.durPickOfferStore.ToString(), BGHLMGPPCNN.dur3m.ToString() + ((int)this.GetPassType()).ToString(), false, false);
		this.NBKLLONFGAL = "a";
		this.CPJIEAAKFMA();
	}

	// Token: 0x06001531 RID: 5425 RVA: 0x000A438A File Offset: 0x000A258A
	private void OnEnable()
	{
		this.CPGLEJIBNEP = FullscreenLiveOfferManager.CBOKJGNCEKE + 1f;
	}

	// Token: 0x06001532 RID: 5426 RVA: 0x000A43A0 File Offset: 0x000A25A0
	private void KJCNEEJJKJH()
	{
		FirebaseAnalyticsManager.ANCEKPONIFI().AAIABAKHLAH(true, ((AGEHCPDNBFD)(-23)).ToString(), ((FFPHBMFGCNN)(-65)).ToString(), BGHLMGPPCNN.vidsup.ToString() + ((int)this.GetPassType()).ToString(), true, true);
		this.DNBJPEEAAGJ("ZZZ");
	}

	// Token: 0x06001533 RID: 5427 RVA: 0x000A4408 File Offset: 0x000A2608
	private void ELLNHGLCELK()
	{
		FirebaseAnalyticsManager.DEALKJPEMMH().LKONPEEDKNF(false, ((AGEHCPDNBFD)(-89)).ToString(), ((FFPHBMFGCNN)(-95)).ToString(), ((BGHLMGPPCNN)122).ToString() + ((int)this.GetPassType()).ToString(), false, false);
		this.NBKLLONFGAL = "acliffbw20";
		this.CPJIEAAKFMA();
	}

	// Token: 0x06001534 RID: 5428 RVA: 0x000A4478 File Offset: 0x000A2678
	public KHBLFKIDHPH GetPassType()
	{
		try
		{
			if (this.HNBJEPCCLAL.OKHMNFLFDOM.Contains(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG("")))
			{
				if (int.Parse(DPGJIJGOCIC.AMACOOGPPEC(this.HNBJEPCCLAL.OKHMNFLFDOM)) == 1)
				{
					return KHBLFKIDHPH.goldGamePass;
				}
				return KHBLFKIDHPH.premiumGamePass;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return KHBLFKIDHPH.count;
	}

	// Token: 0x06001535 RID: 5429 RVA: 0x000A44E4 File Offset: 0x000A26E4
	private bool NDHJCDLGONE()
	{
		KHBLFKIDHPH passType = this.GetPassType();
		if ((KHBLFKIDHPH)51 == passType)
		{
			return false;
		}
		string text = KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)passType);
		if (!text.Equals(this.HNBJEPCCLAL.OKHMNFLFDOM))
		{
			return false;
		}
		string[] array = new string[]
		{
			null,
			"tbits"
		};
		array[0] = "hacomp1";
		array[6] = " ";
		array[6] = "mist";
		string[] array2 = array;
		for (int i = 1; i < array2.Length; i++)
		{
			OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.GDGKNNDEAAO().IJLAPHFKPMH(text + array2[i]);
			if (ocbiopoeenj == null)
			{
				return false;
			}
			if (i != 0 && 0 != ocbiopoeenj.PPACJFFFBFB.PONAPMOOLIN())
			{
				return true;
			}
			OBHDGKFFICI productData = PurchaseManagerBridge.KMNBCEMEBBD().CMJKNNFMCBM().GetProductData(text + array2[i]);
			if (productData == null || (productData.HOCIKJAGDMC == null && productData.MDFDHOKJOPB == null))
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x06001536 RID: 5430 RVA: 0x000A45B8 File Offset: 0x000A27B8
	private void LNKFNPGJNCP()
	{
		this.NBKLLONFGAL = "";
		if (this.JMPGOINDKFJ() && this.PEPKEGAADDG())
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithFourButtonsInside(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("gamepassdurationtitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("gamepassdurationbodystore"), this.ANFNMGKFLGH(1, ""), this.ANFNMGKFLGH(3, "a"), this.ANFNMGKFLGH(6, "b"), this.ANFNMGKFLGH(12, "c"), new UnityAction(this.BDDKEABCJOH), new UnityAction(this.PADLMDDHDJI), new UnityAction(this.GCMDJDHDLBB), new UnityAction(this.OFKCBKKOMMP), null, DFGILFBGPLN.popupGamePassDurationOffer, 0f, 28);
			return;
		}
		this.CPJIEAAKFMA();
	}

	// Token: 0x06001537 RID: 5431 RVA: 0x000A4681 File Offset: 0x000A2881
	private string LCDFMPHDIOL(int OPMDCABAFPH, string ABFNOGAEIGH)
	{
		return this.HMEOICAKMPL(OPMDCABAFPH, this.FLADCNCPMHP(this.OGAIANGEACE(ABFNOGAEIGH)));
	}

	// Token: 0x06001538 RID: 5432 RVA: 0x000A4698 File Offset: 0x000A2898
	private void OFKCBKKOMMP()
	{
		FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.gpDur.ToString(), FFPHBMFGCNN.durPickOfferStore.ToString(), BGHLMGPPCNN.dur12m.ToString() + ((int)this.GetPassType()).ToString(), false, false);
		this.NBKLLONFGAL = "c";
		this.CPJIEAAKFMA();
	}

	// Token: 0x06001539 RID: 5433 RVA: 0x000A4708 File Offset: 0x000A2908
	private void CHBONBGGDOK()
	{
		FirebaseAnalyticsManager.ANCEKPONIFI().LMCJKLHOHJC(false, AGEHCPDNBFD.cdnActiv.ToString(), ((FFPHBMFGCNN)(-26)).ToString(), ((BGHLMGPPCNN)(-56)).ToString() + ((int)this.GetPassType()).ToString(), false, true);
		this.NBKLLONFGAL = "_NoiseTex";
		this.CPJIEAAKFMA();
	}

	// Token: 0x0600153A RID: 5434 RVA: 0x000A2E8F File Offset: 0x000A108F
	private string LIJONDGLCJO(int OPMDCABAFPH, string ABFNOGAEIGH)
	{
		return this.HMEOICAKMPL(OPMDCABAFPH, this.GetLocalizedCostData(this.OGAIANGEACE(ABFNOGAEIGH)));
	}

	// Token: 0x0600153B RID: 5435 RVA: 0x000A4776 File Offset: 0x000A2976
	private bool JMPGOINDKFJ()
	{
		return LanguageManager.EHBBFMCILPC.GetSelectedLanguage() != CEIBHCNNIDC.ru || !GeoLocationManager.IsRussia() || !KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA();
	}

	// Token: 0x0600153C RID: 5436 RVA: 0x000A479C File Offset: 0x000A299C
	private void BDDKEABCJOH()
	{
		FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.gpDur.ToString(), FFPHBMFGCNN.durPickOfferStore.ToString(), BGHLMGPPCNN.dur1m.ToString() + ((int)this.GetPassType()).ToString(), false, false);
		this.NBKLLONFGAL = "";
		this.CPJIEAAKFMA();
	}

	// Token: 0x0600153D RID: 5437 RVA: 0x000A480A File Offset: 0x000A2A0A
	private void HEIFJJPCBEJ()
	{
		AOBJLALDBAA.DBLAIDPICIG().KGIKHEDLPND("OnBackendPremiumChoiceSuccess", 1289f);
		this.HOEJKLJBLJD();
	}

	// Token: 0x0600153E RID: 5438 RVA: 0x00003E52 File Offset: 0x00002052
	private void LMKOJJEFKAF()
	{
	}

	// Token: 0x0600153F RID: 5439 RVA: 0x000A4828 File Offset: 0x000A2A28
	private void CPJIEAAKFMA()
	{
		PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager().Initialize();
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru && GeoLocationManager.IsRussia() && KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA())
		{
			this.PurchaseProductWeb();
			return;
		}
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.AEKCPCJCBAH));
	}

	// Token: 0x06001540 RID: 5440 RVA: 0x000A4888 File Offset: 0x000A2A88
	private void FJNABPPFCKB(string ABFNOGAEIGH)
	{
		string text = this.HNBJEPCCLAL.OKHMNFLFDOM;
		if (!string.IsNullOrEmpty(ABFNOGAEIGH))
		{
			text = KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.GetPassType()) + ABFNOGAEIGH;
		}
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.EHBBFMCILPC.PDJKPFLHFLO(text);
		if (ocbiopoeenj != null)
		{
			string text2 = ocbiopoeenj.MBLAIKOOCFH() + "?uid=" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
			ProductThumbnailManager.lastAccessedProductWebLink = text2;
			CommonUserInterface.EHBBFMCILPC.ShowPopupOnlineResources(text2, 2);
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("FullscreenLiveOfferManager.PurchaseProductWebDuration(): productBalanceData is null for sku '" + text + "'");
		}
		this.HOEJKLJBLJD();
	}

	// Token: 0x06001541 RID: 5441 RVA: 0x000A4919 File Offset: 0x000A2B19
	private string PNMMBDAIJJM()
	{
		if (string.IsNullOrEmpty(this.NBKLLONFGAL))
		{
			return this.HNBJEPCCLAL.OKHMNFLFDOM;
		}
		return KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.GetPassType()) + this.NBKLLONFGAL;
	}

	// Token: 0x06001542 RID: 5442 RVA: 0x000A494F File Offset: 0x000A2B4F
	private bool CABMKGKEMOO()
	{
		return LanguageManager.EHBBFMCILPC.MLOLBFBODHD() != CEIBHCNNIDC.ru || !GeoLocationManager.CELPCHNPBHH() || KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA();
	}

	// Token: 0x06001543 RID: 5443 RVA: 0x00003E52 File Offset: 0x00002052
	private void PIBDCOBGMKC()
	{
	}

	// Token: 0x06001544 RID: 5444 RVA: 0x000A4974 File Offset: 0x000A2B74
	private void HCPEDBFFGEE()
	{
		AOBJLALDBAA.EHBBFMCILPC.DCGCFPHHDDG("<b>", 80f);
		this.HOEJKLJBLJD();
	}

	// Token: 0x06001545 RID: 5445 RVA: 0x000A4990 File Offset: 0x000A2B90
	private void DNBJPEEAAGJ(string ABFNOGAEIGH)
	{
		string text = this.HNBJEPCCLAL.OKHMNFLFDOM;
		if (!string.IsNullOrEmpty(ABFNOGAEIGH))
		{
			text = KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.GetPassType()) + ABFNOGAEIGH;
		}
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.KBNLANLMNCN().FCPIJEEMHEA(text);
		if (ocbiopoeenj != null)
		{
			string text2 = ocbiopoeenj.FDMCFAHEELN() + "}" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
			ProductThumbnailManager.lastAccessedProductWebLink = text2;
			CommonUserInterface.IKNOFBFMPGA().DPJBIGPDLMB(text2, 7);
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("ChapterSnapshotsItem.OnChapterSnapshotRestore(): impossible condition 3" + text + "QueueCustomCode() already contains this request:");
		}
		this.HOEJKLJBLJD();
	}

	// Token: 0x06001546 RID: 5446 RVA: 0x000A4A24 File Offset: 0x000A2C24
	private void AEKCPCJCBAH()
	{
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.EHBBFMCILPC.PDJKPFLHFLO(this.HNBJEPCCLAL.OKHMNFLFDOM);
		if (ocbiopoeenj != null)
		{
			ProductThumbnailManager.lastAccessedProductWebLink = ocbiopoeenj.MBLAIKOOCFH() + "?uid=" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		}
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru && GeoLocationManager.IsRussia() && KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA())
		{
			CommonUserInterface.EHBBFMCILPC.GetFader().FadeOut(null);
			this.PurchaseProductWeb();
		}
		else
		{
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnFullscreenLiveOfferContinueToPurchasingScreen", 0f);
			CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().ShowAndPurchaseProduct(this.PNMMBDAIJJM(), true);
		}
		this.HOEJKLJBLJD();
	}

	// Token: 0x06001547 RID: 5447 RVA: 0x000A4AD4 File Offset: 0x000A2CD4
	private void GCBPPCAFPFD()
	{
		FirebaseAnalyticsManager.HJGDLOOHNLO().AAIABAKHLAH(true, ((AGEHCPDNBFD)(-56)).ToString(), FFPHBMFGCNN.lbyStart.ToString(), BGHLMGPPCNN.d1ChaptStOld.ToString() + ((int)this.GetPassType()).ToString(), true, true);
		this.NBKLLONFGAL = "LLL";
		this.CPJIEAAKFMA();
	}

	// Token: 0x06001548 RID: 5448 RVA: 0x000A4B44 File Offset: 0x000A2D44
	private void FOMJMNCIEAJ()
	{
		FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.gpDur.ToString(), FFPHBMFGCNN.durPickOfferWeb.ToString(), BGHLMGPPCNN.dur1m.ToString() + ((int)this.GetPassType()).ToString(), false, false);
		this.FJNABPPFCKB("");
	}

	// Token: 0x06001549 RID: 5449 RVA: 0x000A4BAC File Offset: 0x000A2DAC
	private string KFLEDODAAPH(int OPMDCABAFPH, string ABFNOGAEIGH)
	{
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.EHBBFMCILPC.PDJKPFLHFLO(this.OGAIANGEACE(ABFNOGAEIGH));
		return this.HMEOICAKMPL(OPMDCABAFPH, (ocbiopoeenj != null) ? ocbiopoeenj.KDPELFOFPBC() : "");
	}

	// Token: 0x0600154A RID: 5450 RVA: 0x000A4BE4 File Offset: 0x000A2DE4
	public string NNEDBGNJHFB(string IOONFLFOIAH)
	{
		OBHDGKFFICI productData = PurchaseManagerBridge.EHBBFMCILPC.JNNBFLDOOHM().GetProductData(IOONFLFOIAH);
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.KBNLANLMNCN().AOAGHIJNFDL(IOONFLFOIAH);
		if (productData == null || ocbiopoeenj == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("lightmodeintrobody2");
			return "OnPopupAvatarCollectionsInputCancel";
		}
		if (ocbiopoeenj.KIOLJNPKOOL())
		{
			return ocbiopoeenj.PKNNPAMOADM();
		}
		return "" + ocbiopoeenj.DMODNDCLGEJ;
	}

	// Token: 0x0600154B RID: 5451 RVA: 0x000A4C43 File Offset: 0x000A2E43
	public void OnCloseClick()
	{
		DNPIKPDMKKI.GFEOFIABBKM();
		this.HOEJKLJBLJD();
	}

	// Token: 0x0600154C RID: 5452 RVA: 0x000A4C50 File Offset: 0x000A2E50
	private string OGAIANGEACE(string ABFNOGAEIGH)
	{
		if (string.IsNullOrEmpty(ABFNOGAEIGH))
		{
			return this.HNBJEPCCLAL.OKHMNFLFDOM;
		}
		return KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.GetPassType()) + ABFNOGAEIGH;
	}

	// Token: 0x0600154E RID: 5454 RVA: 0x000A4C88 File Offset: 0x000A2E88
	private void KKJKIFGBCGI()
	{
		AOBJLALDBAA.AGANFKKBPFO().EFBNBFIDEOK(" cards=", 354f);
		this.HOEJKLJBLJD();
	}

	// Token: 0x0600154F RID: 5455 RVA: 0x000A4CA4 File Offset: 0x000A2EA4
	public void Show(GDOKLFCLLIK FMLFLGJLDHD)
	{
		this.HNBJEPCCLAL = FMLFLGJLDHD;
		this.OKHKMEPHDPG = GKJPOGNFKNK.DKAHEEBDGLI(FMLFLGJLDHD.JKLHDDADKNH);
		base.gameObject.SetActive(true);
		if (this.HNBJEPCCLAL.NHKCEMHKODM == LJLAENEAOIM.liveOfferCardsVolSale)
		{
			if (null != this.OKHKMEPHDPG)
			{
				this.descriptionText.gameObject.SetActive(false);
				if (this.HNBJEPCCLAL.KEJCIIFAJCA() > 0)
				{
					this.buttonAction.SetActive(false);
					this.buttonActionSale.SetActive(true);
					this.buttonTextSale.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(this.OKHKMEPHDPG.textButtonId), true);
					this.buttonTextSale.text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(this.OKHKMEPHDPG.textButtonId);
				}
				else
				{
					this.buttonAction.SetActive(true);
					this.buttonActionSale.SetActive(false);
					this.buttonText.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(this.OKHKMEPHDPG.textButtonId), true);
					this.buttonText.text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(this.OKHKMEPHDPG.textButtonId);
				}
				if (this.OKHKMEPHDPG.textSubtitleId.Length > 0)
				{
					this.subtitleText.gameObject.SetActive(true);
					this.subtitleText.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(this.OKHKMEPHDPG.textSubtitleId), true);
					this.subtitleText.text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(this.OKHKMEPHDPG.textSubtitleId);
					this.subtitleText.fontSizeMax = (float)this.OKHKMEPHDPG.textSubtitleMaxSize;
					this.subtitleText.color = this.OKHKMEPHDPG.textSubtitleColor;
					if (this.OKHKMEPHDPG.textSubtitleIsItalic)
					{
						this.subtitleText.fontStyle = FontStyles.Italic;
					}
					else
					{
						this.subtitleText.fontStyle = FontStyles.Normal;
					}
					this.subtitleText.GetComponent<RectTransform>().IMLMHHMHEDP((float)this.OKHKMEPHDPG.textSubtitleLeft, (float)this.OKHKMEPHDPG.textSubtitleRight, (float)this.OKHKMEPHDPG.textSubtitleTop, (float)this.OKHKMEPHDPG.textSubtitleBottom, (float)this.OKHKMEPHDPG.textSubtitleMaxWidth);
				}
				else
				{
					this.subtitleText.gameObject.SetActive(false);
				}
				if (this.HNBJEPCCLAL.KEJCIIFAJCA() > 0)
				{
					this.saleText.gameObject.SetActive(true);
					this.saleText.SetText("-" + this.HNBJEPCCLAL.KEJCIIFAJCA().ToString() + "%", true);
					this.saleText.text = "-" + this.HNBJEPCCLAL.KEJCIIFAJCA().ToString() + "%";
				}
				else
				{
					this.saleText.gameObject.SetActive(false);
				}
				if (this.HNBJEPCCLAL.LLMNKLPIBNO)
				{
					this.timerText.gameObject.SetActive(true);
					this.timerText.fontSizeMax = (float)this.OKHKMEPHDPG.textTimerMaxSize;
					this.timerText.color = this.OKHKMEPHDPG.textTimerColor;
					this.timerText.GetComponent<RectTransform>().IMLMHHMHEDP((float)this.OKHKMEPHDPG.textTimerLeft, (float)this.OKHKMEPHDPG.textTimerRight, (float)this.OKHKMEPHDPG.textTimerTop, (float)this.OKHKMEPHDPG.textTimerBottom, (float)this.OKHKMEPHDPG.textTimerMaxWidth);
				}
				else
				{
					this.timerText.gameObject.SetActive(false);
				}
				if (this.OKHKMEPHDPG.textFooterId.Length > 0)
				{
					this.footerText.gameObject.SetActive(true);
					this.footerText.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(this.OKHKMEPHDPG.textFooterId), true);
					this.footerText.text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(this.OKHKMEPHDPG.textFooterId);
					this.footerText.color = this.OKHKMEPHDPG.textFooterColor;
				}
				else
				{
					this.footerText.gameObject.SetActive(false);
				}
				if (this.fullScreenSprite.gameObject.GetComponent<ImageFrameAnimation>() == null)
				{
					this.fullScreenSprite.gameObject.AddComponent<ImageFrameAnimation>();
				}
				this.fullScreenSprite.GetComponent<ImageFrameAnimation>().frameChangeInterval = this.OKHKMEPHDPG.frameChangeInterval;
				this.fullScreenSprite.GetComponent<ImageFrameAnimation>().framesSD = this.OKHKMEPHDPG.frames.ToArray();
				this.fullScreenSprite.sprite = this.OKHKMEPHDPG.frames[0];
				this.fullScreenSprite.SetNativeSize();
			}
		}
		else if (this.HNBJEPCCLAL.NHKCEMHKODM == LJLAENEAOIM.liveOfferPass && null != this.OKHKMEPHDPG)
		{
			this.descriptionText.gameObject.SetActive(true);
			this.subtitleText.gameObject.SetActive(false);
			this.saleText.gameObject.SetActive(false);
			this.timerText.gameObject.SetActive(false);
			if (this.GetPassCategoryType() == CLHDENLPOFP.gamePass)
			{
				this.buttonAction.SetActive(true);
				this.buttonActionSale.SetActive(false);
				string text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(this.OKHKMEPHDPG.textButtonId);
				if (this.GetPassType() == KHBLFKIDHPH.premiumGamePass)
				{
					text = text.Replace("XXX", KBOJLHAJPCP.MJIIKJPAKCB);
				}
				else if (this.GetPassType() == KHBLFKIDHPH.goldGamePass)
				{
					text = text.Replace("XXX", KBOJLHAJPCP.JGLFACJDKAG);
				}
				text = text.Replace("YYY", this.GetLocalizedCostData(this.HNBJEPCCLAL.OKHMNFLFDOM));
				this.buttonText.SetText(text, true);
				this.buttonText.text = text;
				text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(this.OKHKMEPHDPG.textBodyId + KDCJJBLGCBH.EHBBFMCILPC.AAGICPKFIKC(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.GetPassType()), DAMCJCDKOJK.gpbpIncentAdMultiplier, 1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString());
				if (1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF && KDCJJBLGCBH.EHBBFMCILPC.IPJIIHLDMPK(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.GetPassType()), DAMCJCDKOJK.gpbpChoicesCount))
				{
					text = text.Replace("AAA", KBOJLHAJPCP.PGBPLBKHPOM);
					text = text.Replace("XXX", "<b>" + KDCJJBLGCBH.EHBBFMCILPC.AAGICPKFIKC(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.GetPassType()), DAMCJCDKOJK.gpbpChoicesCount, 1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString() + "</b>" + KBOJLHAJPCP.DHMPCLBPDIE);
				}
				else
				{
					text = text.Replace("AAA", KBOJLHAJPCP.PGBPLBKHPOM);
					text = text.Replace("XXX", "<b>" + KDCJJBLGCBH.EHBBFMCILPC.AAGICPKFIKC(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.GetPassType()), DAMCJCDKOJK.gpbpChoicesCount, 1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString() + "</b>");
				}
				if (1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF && KDCJJBLGCBH.EHBBFMCILPC.IPJIIHLDMPK(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.GetPassType()), DAMCJCDKOJK.gpbpUndosCount))
				{
					text = text.Replace("BBB", KBOJLHAJPCP.NJDJMKIIEDG);
					text = text.Replace("YYY", "<b>" + KDCJJBLGCBH.EHBBFMCILPC.AAGICPKFIKC(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.GetPassType()), DAMCJCDKOJK.gpbpUndosCount, 1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString() + "</b>" + KBOJLHAJPCP.DHMPCLBPDIE);
				}
				else
				{
					text = text.Replace("BBB", KBOJLHAJPCP.NJDJMKIIEDG);
					text = text.Replace("YYY", "<b>" + KDCJJBLGCBH.EHBBFMCILPC.AAGICPKFIKC(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.GetPassType()), DAMCJCDKOJK.gpbpUndosCount, 1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString() + "</b>");
				}
				if (1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF && KDCJJBLGCBH.EHBBFMCILPC.IPJIIHLDMPK(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.GetPassType()), DAMCJCDKOJK.gpbpEndDiscount))
				{
					text = text.Replace("CCC", KBOJLHAJPCP.LPBLANJMJIF);
					text = text.Replace("ZZZ", "<b>" + KDCJJBLGCBH.EHBBFMCILPC.AAGICPKFIKC(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.GetPassType()), DAMCJCDKOJK.gpbpEndDiscount, 1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString() + "%</b>" + KBOJLHAJPCP.DHMPCLBPDIE);
				}
				else
				{
					text = text.Replace("CCC", KBOJLHAJPCP.LPBLANJMJIF);
					text = text.Replace("ZZZ", "<b>" + KDCJJBLGCBH.EHBBFMCILPC.AAGICPKFIKC(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.GetPassType()), DAMCJCDKOJK.gpbpEndDiscount, 1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString() + "%</b>");
				}
				text = text.Replace("DDD", KBOJLHAJPCP.OINDDHFMCFL);
				text = text.Replace("EEE", KBOJLHAJPCP.LJFPMLHKGBO);
				text = text.Replace("FFF", KBOJLHAJPCP.PGCHBCBENIC);
				text = text.Replace("GGG", KBOJLHAJPCP.MCMICIODGAE);
				text = text.Replace("HHH", KBOJLHAJPCP.GOCPBNAAIIB);
				text = text.Replace("III", KBOJLHAJPCP.NHBODCBJCFG);
				text = text.Replace("JJJ", KBOJLHAJPCP.FHAGMJOKEBA);
				text = text.Replace("KKK", DPGJIJGOCIC.CEOBDMGAKNL(KDCJJBLGCBH.EHBBFMCILPC.GCPFCGGBDKK((int)this.GetPassType())) + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("hoursshort"));
				text = text.Replace("LLL", KBOJLHAJPCP.BAEGIGOIMPA);
				text = text.Replace("MMM", DPGJIJGOCIC.CEOBDMGAKNL(KDCJJBLGCBH.EHBBFMCILPC.ADLOIIMBHAG((int)this.GetPassType())) + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("hoursshort"));
				text = text.Replace("NNN", KBOJLHAJPCP.KKELADEPAIA ?? "");
				text = text.Replace("OOO", KDCJJBLGCBH.EHBBFMCILPC.HLPACDMEKMK((int)this.GetPassType()).ToString() ?? "");
				text = text.Replace("PPP", KBOJLHAJPCP.ADCLBDLIFIJ ?? "");
				text = text.Replace("QQQ", "+" + KDCJJBLGCBH.EHBBFMCILPC.LHECDOFJNOF((int)this.GetPassType()).ToString() + "%");
				text = text.Replace("RRR", KBOJLHAJPCP.DMLHMPGHFDC);
				text = text.Replace("SSS", KBOJLHAJPCP.BGMADCKNKAD + KDCJJBLGCBH.EHBBFMCILPC.PLOMCENKKFD((int)this.GetPassType()).ToString());
				if (this.OKHKMEPHDPG.textLineHeight >= 0)
				{
					this.descriptionText.SetText("<line-height=" + this.OKHKMEPHDPG.textLineHeight.ToString() + "%>" + text, true);
					this.descriptionText.text = "<line-height=" + this.OKHKMEPHDPG.textLineHeight.ToString() + "%>" + text;
				}
				else
				{
					this.descriptionText.SetText(text, true);
					this.descriptionText.text = text;
				}
			}
			this.descriptionText.fontSizeMax = (float)this.OKHKMEPHDPG.textMaxSize;
			this.descriptionText.color = this.OKHKMEPHDPG.textColor;
			this.descriptionText.GetComponent<RectTransform>().IMLMHHMHEDP((float)this.OKHKMEPHDPG.textLeft, (float)this.OKHKMEPHDPG.textRight, (float)this.OKHKMEPHDPG.texTop, (float)this.OKHKMEPHDPG.textBottom, (float)this.OKHKMEPHDPG.textMaxWidth);
			if (this.OKHKMEPHDPG.textFooterId.Length > 0)
			{
				this.footerText.gameObject.SetActive(true);
				this.footerText.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(this.OKHKMEPHDPG.textFooterId), true);
				this.footerText.text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(this.OKHKMEPHDPG.textFooterId);
				this.footerText.color = this.OKHKMEPHDPG.textFooterColor;
			}
			else
			{
				this.footerText.gameObject.SetActive(false);
			}
			if (this.fullScreenSprite.gameObject.GetComponent<ImageFrameAnimation>() == null)
			{
				this.fullScreenSprite.gameObject.AddComponent<ImageFrameAnimation>();
			}
			this.fullScreenSprite.GetComponent<ImageFrameAnimation>().frameChangeInterval = this.OKHKMEPHDPG.frameChangeInterval;
			this.fullScreenSprite.GetComponent<ImageFrameAnimation>().framesSD = this.OKHKMEPHDPG.frames.ToArray();
			this.fullScreenSprite.sprite = this.OKHKMEPHDPG.frames[0];
			this.fullScreenSprite.SetNativeSize();
		}
		this.CPGLEJIBNEP = FullscreenLiveOfferManager.CBOKJGNCEKE + 1f;
		this.Update();
	}

	// Token: 0x06001550 RID: 5456 RVA: 0x000A2FD9 File Offset: 0x000A11D9
	private void OnDisable()
	{
		this.fullScreenSprite.sprite = null;
		if (this.fullScreenSprite.gameObject.GetComponent<ImageFrameAnimation>() != null)
		{
			this.fullScreenSprite.GetComponent<ImageFrameAnimation>().framesSD = null;
		}
		this.OKHKMEPHDPG = null;
	}

	// Token: 0x06001551 RID: 5457 RVA: 0x000A594C File Offset: 0x000A3B4C
	private void KJNLBAEHLEI()
	{
		this.CPGLEJIBNEP += Time.deltaTime;
		if (this.CPGLEJIBNEP > FullscreenLiveOfferManager.CBOKJGNCEKE && this.HNBJEPCCLAL != null && this.HNBJEPCCLAL.LLMNKLPIBNO && this.timerText.gameObject.activeSelf)
		{
			this.timerText.text = KBOJLHAJPCP.NFIPEDFHEEI + DPGJIJGOCIC.LCOMEDGJNMP((int)this.HNBJEPCCLAL.ONMADEIOOKN.ODBOJGMLKHA(), true, false);
			this.timerText.SetText(KBOJLHAJPCP.NFIPEDFHEEI + DPGJIJGOCIC.FCICBOLGHDA((int)this.HNBJEPCCLAL.ONMADEIOOKN.LEAIEAIEBJK(), false, false), false);
			this.CPGLEJIBNEP = 1496f;
		}
	}

	// Token: 0x06001552 RID: 5458 RVA: 0x000A5A0C File Offset: 0x000A3C0C
	private void MFIHOHCHDGE()
	{
		FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.gpDur.ToString(), FFPHBMFGCNN.durPickOfferWeb.ToString(), BGHLMGPPCNN.dur6m.ToString() + ((int)this.GetPassType()).ToString(), false, false);
		this.FJNABPPFCKB("b_web");
	}

	// Token: 0x06001553 RID: 5459 RVA: 0x000A5A74 File Offset: 0x000A3C74
	public void LPEEFKAHCCK()
	{
		if (this.HNBJEPCCLAL.NHKCEMHKODM == LJLAENEAOIM.liveOfferPass)
		{
			this.OOBAAOMJALJ();
			return;
		}
		if (this.HNBJEPCCLAL.NHKCEMHKODM == LJLAENEAOIM.liveOfferPass)
		{
			if (this.BKHGLPHLOHK())
			{
				this.ELDBBAOHLKH();
				CommonUserInterface.EHBBFMCILPC.ShowGamePasses();
				return;
			}
			KHBLFKIDHPH passType = this.GetPassType();
			if ((KHBLFKIDHPH)(-87) != passType && ODLJHDIGLGO.LCEOEHBFJHM())
			{
				KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.KBNEGBIKKNI(CLHDENLPOFP.gamePass, false);
				if (kioojmglclc != null && kioojmglclc.LLLJOBODOAL < (int)passType)
				{
					CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtonsAndCloseOverride(CCOJBMMKNAP.HJGDLOOHNLO().PPALCPINPLK("\n\n"), CCOJBMMKNAP.OBOOKJPGBJN().HPOAGPJFHPM("Development Server URL could not be found."), CCOJBMMKNAP.ILACPHFEDEP().GGPHHLGPMPA("ok"), CCOJBMMKNAP.MPCBJEIMACA().HPOAGPJFHPM("ok"), new UnityAction(this.LNKFNPGJNCP), new UnityAction(this.LMKOJJEFKAF), new UnityAction(this.LMKOJJEFKAF), (DFGILFBGPLN)(-128), 581f, -123);
					return;
				}
			}
			this.LNKFNPGJNCP();
		}
	}

	// Token: 0x06001554 RID: 5460 RVA: 0x000A5B68 File Offset: 0x000A3D68
	public void PurchaseProductWeb()
	{
		if (KHBLFKIDHPH.count != this.GetPassType() && this.CAAMEFMDNFF())
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithFourButtonsInside(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("gamepassdurationtitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("gamepassdurationbody"), this.KFLEDODAAPH(1, ""), this.KFLEDODAAPH(3, "a_web"), this.KFLEDODAAPH(6, "b_web"), this.KFLEDODAAPH(12, "c_web"), new UnityAction(this.FOMJMNCIEAJ), new UnityAction(this.LOHBLNNJOBM), new UnityAction(this.MFIHOHCHDGE), new UnityAction(this.PJDLMLNFEDM), null, DFGILFBGPLN.popupGamePassDurationOffer, 0f, 28);
			return;
		}
		this.FJNABPPFCKB("");
	}

	// Token: 0x06001555 RID: 5461 RVA: 0x00003E52 File Offset: 0x00002052
	private void Start()
	{
	}

	// Token: 0x06001556 RID: 5462 RVA: 0x000A5C30 File Offset: 0x000A3E30
	private void FAHBBGABHDN()
	{
		FirebaseAnalyticsManager.JMDJBFAEHBM().LMCJKLHOHJC(true, ((AGEHCPDNBFD)127).ToString(), ((FFPHBMFGCNN)(-120)).ToString(), BGHLMGPPCNN.d1CdnSt.ToString() + ((int)this.GetPassType()).ToString(), true, false);
		this.DNBJPEEAAGJ("pmterror100");
	}

	// Token: 0x06001557 RID: 5463 RVA: 0x000A5C98 File Offset: 0x000A3E98
	public void OnActionClick()
	{
		if (this.HNBJEPCCLAL.NHKCEMHKODM == LJLAENEAOIM.liveOfferCardsVolSale)
		{
			this.OOBAAOMJALJ();
			return;
		}
		if (this.HNBJEPCCLAL.NHKCEMHKODM == LJLAENEAOIM.liveOfferPass)
		{
			if (this.NLHBOCBGOAF())
			{
				this.OnCloseClick();
				CommonUserInterface.EHBBFMCILPC.ShowGamePasses();
				return;
			}
			KHBLFKIDHPH passType = this.GetPassType();
			if (KHBLFKIDHPH.count != passType && ODLJHDIGLGO.FACIFBONANM())
			{
				KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass, true);
				if (kioojmglclc != null && kioojmglclc.LLLJOBODOAL < (int)passType)
				{
					CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtonsAndCloseOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("passtrytobuyhigherorder"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("no"), new UnityAction(this.LNKFNPGJNCP), new UnityAction(this.LMKOJJEFKAF), new UnityAction(this.LMKOJJEFKAF), DFGILFBGPLN.popupTools, 0f, 28);
					return;
				}
			}
			this.LNKFNPGJNCP();
		}
	}

	// Token: 0x06001558 RID: 5464 RVA: 0x000A5D8C File Offset: 0x000A3F8C
	private bool ECGELCHHBHG()
	{
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.PMABBOJDELF().DOOPGOIBFAN(this.HNBJEPCCLAL.OKHMNFLFDOM);
		if (ocbiopoeenj == null || string.IsNullOrEmpty(ocbiopoeenj.MBLAIKOOCFH()))
		{
			return true;
		}
		string text = KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.GetPassType());
		if (!text.Equals(this.HNBJEPCCLAL.OKHMNFLFDOM))
		{
			return false;
		}
		string[] array = new string[1];
		array[1] = "storyAssetPackManager[i].environmentsFrontList[j] is null!";
		array[0] = " | queue: [";
		array[7] = "[ ";
		string[] array2 = array;
		for (int i = 0; i < array2.Length; i++)
		{
			OCBIOPOEENJ ocbiopoeenj2 = CJEKEHDEBLM.GDGKNNDEAAO().DCCLKMCBPPJ(text + array2[i]);
			if (ocbiopoeenj2 == null || string.IsNullOrEmpty(ocbiopoeenj2.MBLAIKOOCFH()) || 0 != ocbiopoeenj2.PPACJFFFBFB.DPLHPBMJAPJ())
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x04000697 RID: 1687
	public const string onFullscreenLiveOfferContinueToPurchasingScreen = "OnFullscreenLiveOfferContinueToPurchasingScreen";

	// Token: 0x04000698 RID: 1688
	public const string onFullscreenLiveOfferContinueToCardsVolSaleMenu = "OnFullscreenLiveOfferContinueToCardsVolSaleMenu";

	// Token: 0x04000699 RID: 1689
	public Image fullScreenSprite;

	// Token: 0x0400069A RID: 1690
	public TextMeshProUGUI descriptionText;

	// Token: 0x0400069B RID: 1691
	public TextMeshProUGUI buttonText;

	// Token: 0x0400069C RID: 1692
	public TextMeshProUGUI buttonTextSale;

	// Token: 0x0400069D RID: 1693
	public TextMeshProUGUI footerText;

	// Token: 0x0400069E RID: 1694
	public TextMeshProUGUI subtitleText;

	// Token: 0x0400069F RID: 1695
	public TextMeshProUGUI saleText;

	// Token: 0x040006A0 RID: 1696
	public TextMeshProUGUI timerText;

	// Token: 0x040006A1 RID: 1697
	public GameObject buttonAction;

	// Token: 0x040006A2 RID: 1698
	public GameObject buttonActionSale;

	// Token: 0x040006A3 RID: 1699
	private GDOKLFCLLIK HNBJEPCCLAL;

	// Token: 0x040006A4 RID: 1700
	private AssetLiveOfferContent OKHKMEPHDPG;

	// Token: 0x040006A5 RID: 1701
	private static float CBOKJGNCEKE = 1f;

	// Token: 0x040006A6 RID: 1702
	private float CPGLEJIBNEP;

	// Token: 0x040006A7 RID: 1703
	private string NBKLLONFGAL = "";
}
