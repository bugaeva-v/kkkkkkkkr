using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x02000040 RID: 64
public class WheelItem : MonoBehaviour
{
	// Token: 0x060009B7 RID: 2487 RVA: 0x000495C8 File Offset: 0x000477C8
	private void MHMPFANBPOC()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.DJLLDNNIMMK.GALKFKBPLCK() <= 0 && !WheelItem.doubleOddsRequested)
		{
			this.BMBBLOBPPIB();
		}
		else
		{
			this.IECLGFPAGCD();
		}
		this.CJJDNIBFLJL();
	}

	// Token: 0x060009B8 RID: 2488 RVA: 0x000495F8 File Offset: 0x000477F8
	private void LMBJHMBADAF()
	{
		bool flag = true;
		for (int i = 1; i < AKLFPGMDKLA.EHBBFMCILPC.BKADBDBHFCP.Count; i++)
		{
			if (i < KDCJJBLGCBH.EHBBFMCILPC.LDBLDNKPNEN() && AKLFPGMDKLA.EHBBFMCILPC.BKADBDBHFCP[i] > 0)
			{
				flag = false;
			}
		}
		if (!flag)
		{
			this.guaranteedCardDropIconButton.SetActive(true);
			return;
		}
		this.guaranteedCardDropIconButton.SetActive(true);
	}

	// Token: 0x060009B9 RID: 2489 RVA: 0x00049660 File Offset: 0x00047860
	public void OnResourceDropChancesClick(int MBBNGLEIOPA)
	{
		string text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("spinres" + MBBNGLEIOPA.ToString() + "hint");
		text = text.Replace("XXX", AKLFMGKJLJN.EHBBFMCILPC.CFHJCKPIFFD((PEOGABBHPNP)MBBNGLEIOPA, AKLFPGMDKLA.EHBBFMCILPC.DJLLDNNIMMK.GALKFKBPLCK() > 0 || WheelItem.doubleOddsRequested).ToString("F2") + "%");
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupBonusUnlock, 0f, 28);
	}

	// Token: 0x060009BA RID: 2490 RVA: 0x0004970C File Offset: 0x0004790C
	public void PDAGMJMDNHD()
	{
		if (this.LGBIFDPMNIB == this.KFPMMNPNGHG)
		{
			return;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.ABGNIKKFFAC.GALKFKBPLCK() <= 0)
		{
			return;
		}
		this.KFPMMNPNGHG += 0;
		this.spinWheelEventTrigger.enabled = false;
		this.NILDGEGJIHJ(this.spinWheelButton, true);
		AKLFPGMDKLA.EHBBFMCILPC.ABGNIKKFFAC.OOKPACPIDMO();
		this.GMIPGNMGFPJ();
		this.SendSpinWheelBackendRequest();
	}

	// Token: 0x060009BB RID: 2491 RVA: 0x00049780 File Offset: 0x00047980
	private void FJPBIMENNKD()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.DJLLDNNIMMK.GALKFKBPLCK() <= 0 && !WheelItem.doubleOddsRequested)
		{
			this.doubleOddsIconButton.SetActive(false);
			for (int i = 0; i < this.increaseDropChancesIcons.Count; i++)
			{
				this.increaseDropChancesIcons[i].SetActive(false);
			}
			return;
		}
		this.doubleOddsIconButton.SetActive(true);
		for (int j = 0; j < this.increaseDropChancesIcons.Count; j++)
		{
			this.increaseDropChancesIcons[j].SetActive(true);
		}
	}

	// Token: 0x060009BC RID: 2492 RVA: 0x0004980F File Offset: 0x00047A0F
	private void KFLIPKGBOBM()
	{
		this.EAINMDCBPBC();
		this.MHMPFANBPOC();
	}

	// Token: 0x060009BD RID: 2493 RVA: 0x00049820 File Offset: 0x00047A20
	public void OnIncreasedVolDropChancesClick()
	{
		string text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cardsvolchancesbody0");
		List<int> list = LJNMIPMNOKF.EHBBFMCILPC.LKMOMPEACAA(this.KAOPCAJLLPM.OLNJMJMNBCN());
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
		int num2 = this.KAOPCAJLLPM.OLNJMJMNBCN() + 1;
		text += "\n\n";
		text += CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cardsvolchancesbody1");
		text = text.Replace("XXX", num2.ToString() ?? "");
		text = text.Replace("YYY", DPGJIJGOCIC.LCOMEDGJNMP((int)this.KAOPCAJLLPM.ONMADEIOOKN.ODHBINFKIPL(), true, false));
		if (AKLFPGMDKLA.EHBBFMCILPC.COJFECEAKKI == this.KAOPCAJLLPM.OLNJMJMNBCN())
		{
			text = text.Replace("ZZZ", "<color=#40BF4E>" + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cardsvolchancesbtn0") + "</color>");
		}
		else
		{
			text = text.Replace("ZZZ", "<color=#FF7670>" + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cardsvolchancesbtn1") + "</color>");
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OJKHMNEIGPF == HGCFJKCOKPM.bright)
		{
			text = text.Replace("40BF4E", "51B334").Replace("FF7670", "FF5156");
		}
		string eempglhpkjg = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cardsvolchancestitle");
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtonsAndCloseOverride(eempglhpkjg, text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cardsvolchancesbtn0"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cardsvolchancesbtn1"), new UnityAction(this.NPNAGNMBCCC), new UnityAction(this.AHGGAHJBIPE), new UnityAction(this.DNBJGJJOMCI), DFGILFBGPLN.popupTools, 0f, 24);
	}

	// Token: 0x060009BE RID: 2494 RVA: 0x00049AB0 File Offset: 0x00047CB0
	public void OnDoubleCardsOddsClick()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.DJLLDNNIMMK.GALKFKBPLCK() > 0 || WheelItem.doubleOddsRequested)
		{
			return;
		}
		if (KDCJJBLGCBH.EHBBFMCILPC.MCPOIBPFHDE() <= 2)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("areyousure"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("woftutorial1"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("no"), new UnityAction(this.NBJBGHNPLEJ), new UnityAction(this.HKFDBOKFNLB), DFGILFBGPLN.popupTools, 0f, 28);
			return;
		}
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("areyousure"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("woftutorial3"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("no"), new UnityAction(this.NBJBGHNPLEJ), new UnityAction(this.HKFDBOKFNLB), DFGILFBGPLN.popupTools, 0f, 28);
	}

	// Token: 0x060009BF RID: 2495 RVA: 0x00049BB8 File Offset: 0x00047DB8
	public void JEIALICFIOA()
	{
		CommonUserInterface.IKNOFBFMPGA().OJINMMFOCAG();
		BackendOperationsManager.EHBBFMCILPC.RequestSpinWheel(this.KAOPCAJLLPM, "", "XXX");
		if (AKLFPGMDKLA.EHBBFMCILPC.ABGNIKKFFAC.HOJDOEDDIBD() <= KDCJJBLGCBH.EHBBFMCILPC.HLPACDMEKMK(ODLJHDIGLGO.HECMHABJMFO(CLHDENLPOFP.eventPass, true)))
		{
			FirebaseAnalyticsManager.ANCEKPONIFI().AAIABAKHLAH(true, AGEHCPDNBFD.gnrSelect.ToString(), ((FFPHBMFGCNN)122).ToString(), "Loaded asset bundle:", false, false);
			return;
		}
		FirebaseAnalyticsManager.DEALKJPEMMH().JIAAMJPKOCE(false, AGEHCPDNBFD.srvMode.ToString(), ((FFPHBMFGCNN)(-36)).ToString(), "name", false, false);
	}

	// Token: 0x060009C0 RID: 2496 RVA: 0x00049C70 File Offset: 0x00047E70
	private void EGDHPGKNLAM()
	{
		for (int i = 0; i < this.lobbyCanvases.Count; i += 0)
		{
			this.lobbyCanvases[i].enabled = false;
		}
	}

	// Token: 0x060009C1 RID: 2497 RVA: 0x00049CA5 File Offset: 0x00047EA5
	private void IECLGFPAGCD()
	{
		this.FJPBIMENNKD();
		this.PNNIBEGIKDC(this.doubleCardsOddsButton, false);
	}

	// Token: 0x060009C2 RID: 2498 RVA: 0x00049CBA File Offset: 0x00047EBA
	public void FOGJFJMMFEH()
	{
		this.JKBOFKKKJJP();
	}

	// Token: 0x060009C3 RID: 2499 RVA: 0x00049CC4 File Offset: 0x00047EC4
	private void EGBEPEIEJGL()
	{
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("congratstitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("wofcollectcarddone"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("continue"), new UnityAction(this.KFLIPKGBOBM), new UnityAction(this.KFLIPKGBOBM), DFGILFBGPLN.popupBonusUnlock, 0f, 28);
	}

	// Token: 0x060009C4 RID: 2500 RVA: 0x00049D2C File Offset: 0x00047F2C
	public void NGLJEGBCGCD()
	{
		string dpjinbcgngn = CCOJBMMKNAP.ILACPHFEDEP().HPOAGPJFHPM("StorySaveBody.GetAvatarsSnapshotsCountWardrobe(), unsupported wardrobe index:").Replace("var", KDCJJBLGCBH.EHBBFMCILPC.LDBLDNKPNEN().ToString() ?? "rateno");
		CommonUserInterface.IKNOFBFMPGA().NFBMHHPIGFA(CCOJBMMKNAP.EHBBFMCILPC.MEPECBDCOLG("_StripeNoise"), dpjinbcgngn, CCOJBMMKNAP.PMABBOJDELF().IPEIONBNIPH(" "), (DFGILFBGPLN)(-84), 1518f, 103);
	}

	// Token: 0x060009C5 RID: 2501 RVA: 0x00049DA4 File Offset: 0x00047FA4
	private void CJJDNIBFLJL()
	{
		for (int i = 0; i < 10; i++)
		{
			PEOGABBHPNP peogabbhpnp = (PEOGABBHPNP)i;
			float num = AKLFMGKJLJN.EHBBFMCILPC.CFHJCKPIFFD(peogabbhpnp, AKLFPGMDKLA.EHBBFMCILPC.DJLLDNNIMMK.GALKFKBPLCK() > 0 || WheelItem.doubleOddsRequested);
			string text;
			if (num > 5f)
			{
				text = num.ToString("F0") + "%";
			}
			else if (num > 1f)
			{
				text = num.ToString("F1") + "%";
			}
			else
			{
				text = num.ToString("F2") + "%";
			}
			if (peogabbhpnp == PEOGABBHPNP.wofResourcesGems)
			{
				this.wofResourcesGems.text = (text ?? "");
				this.wofResourcesGems.SetText(text ?? "", true);
			}
			else if (peogabbhpnp == PEOGABBHPNP.wofResourcesTea)
			{
				this.wofResourcesTea.text = (text ?? "");
				this.wofResourcesTea.SetText(text ?? "", true);
			}
			else if (peogabbhpnp == PEOGABBHPNP.wofResourcesSp0)
			{
				this.wofResourcesSp0.text = (text ?? "");
				this.wofResourcesSp0.SetText(text ?? "", true);
			}
			else if (peogabbhpnp == PEOGABBHPNP.wofResourcesSp1)
			{
				this.wofResourcesSp1.text = (text ?? "");
				this.wofResourcesSp1.SetText(text ?? "", true);
			}
			else if (peogabbhpnp == PEOGABBHPNP.wofResourcesSp2)
			{
				this.wofResourcesSp2.text = (text ?? "");
				this.wofResourcesSp2.SetText(text ?? "", true);
			}
			else if (peogabbhpnp == PEOGABBHPNP.wofResourcesCard0)
			{
				this.wofResourcesCard0.text = (text ?? "");
				this.wofResourcesCard0.SetText(text ?? "", true);
			}
			else if (peogabbhpnp == PEOGABBHPNP.wofResourcesCard1)
			{
				this.wofResourcesCard1.text = (text ?? "");
				this.wofResourcesCard1.SetText(text ?? "", true);
			}
			else if (peogabbhpnp == PEOGABBHPNP.wofResourcesCard2)
			{
				this.wofResourcesCard2.text = (text ?? "");
				this.wofResourcesCard2.SetText(text ?? "", true);
			}
			else if (peogabbhpnp == PEOGABBHPNP.wofResourcesCard3)
			{
				this.wofResourcesCard3.text = (text ?? "");
				this.wofResourcesCard3.SetText(text ?? "", true);
			}
			else if (peogabbhpnp == PEOGABBHPNP.wofResourcesCard4)
			{
				this.wofResourcesCard4.text = (text ?? "");
				this.wofResourcesCard4.SetText(text ?? "", true);
			}
		}
	}

	// Token: 0x060009C6 RID: 2502 RVA: 0x0004A048 File Offset: 0x00048248
	private void FDPBIPDPDEP()
	{
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.IDEJMCAMIIA));
		AudioManager.EHBBFMCILPC.KillMusic("", -1f);
		this.CMDIKMNEGEN();
	}

	// Token: 0x060009C7 RID: 2503 RVA: 0x0004A0A0 File Offset: 0x000482A0
	private void AKGHCFAMOMH()
	{
		this.KAOPCAJLLPM = DNPIKPDMKKI.MCOMGMOACEM(LJLAENEAOIM.liveOfferCardsVolChances);
		if (this.KAOPCAJLLPM != null && this.KAOPCAJLLPM.ONMADEIOOKN.ODHBINFKIPL() > 60f)
		{
			this.increasedVolDropChances.SetActive(true);
			int num = this.KAOPCAJLLPM.OLNJMJMNBCN() + 1;
			this.increasedVolDropChancesText.text = (num.ToString() ?? "");
			this.increasedVolDropChancesText.SetText(num.ToString() ?? "", true);
			return;
		}
		this.increasedVolDropChances.SetActive(false);
	}

	// Token: 0x060009C8 RID: 2504 RVA: 0x0004A136 File Offset: 0x00048336
	private void NKIDAPCMDBH()
	{
		this.EFDNHBCECGF(0);
	}

	// Token: 0x060009C9 RID: 2505 RVA: 0x0004A140 File Offset: 0x00048340
	private void AHGGAHJBIPE()
	{
		AKLFPGMDKLA.EHBBFMCILPC.COJFECEAKKI = -1;
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cardsvolchancesmsgtitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cardsvolchancesmsgbody"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("continue"), new UnityAction(this.DNBJGJJOMCI), DFGILFBGPLN.popupBackendError, 0.15f, 28);
	}

	// Token: 0x060009CA RID: 2506 RVA: 0x0004A1A5 File Offset: 0x000483A5
	private void Awake()
	{
		this.EKNLABKCIJF();
		this.PHMIBKAJKMB.EPJKDCDOEMM((float)WheelItem.spinsFireTime);
	}

	// Token: 0x060009CB RID: 2507 RVA: 0x0004A1C0 File Offset: 0x000483C0
	private void ODOPEGPBCCD()
	{
		for (int i = 0; i < this.lobbyCanvases.Count; i++)
		{
			this.lobbyCanvases[i].enabled = true;
		}
	}

	// Token: 0x060009CC RID: 2508 RVA: 0x0004A1F5 File Offset: 0x000483F5
	public void CloseFocus()
	{
		this.PreCloseFocus();
	}

	// Token: 0x060009CD RID: 2509 RVA: 0x0004A200 File Offset: 0x00048400
	private void GMIPGNMGFPJ()
	{
		this.spinsText.text = (AKLFPGMDKLA.EHBBFMCILPC.ABGNIKKFFAC.GALKFKBPLCK().ToString() ?? "");
		this.spinsText.SetText(AKLFPGMDKLA.EHBBFMCILPC.ABGNIKKFFAC.GALKFKBPLCK().ToString() ?? "", true);
	}

	// Token: 0x060009CE RID: 2510 RVA: 0x0004A264 File Offset: 0x00048464
	private void LBFDDEFKCJN()
	{
		if (1 == AKLFPGMDKLA.EHBBFMCILPC.PACMCEHMBGG)
		{
			AudioManager.EHBBFMCILPC.PlayMusic("lobby", true, -1f, false);
		}
		this.OPEGJAEFAJL();
		this.ODOPEGPBCCD();
		AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleCutsceneView, -1);
		this.OnPopupCardOptionsReopen();
	}

	// Token: 0x060009CF RID: 2511 RVA: 0x0004A2B4 File Offset: 0x000484B4
	public void OnPopupNotEnoughEnergyOrHardCurrencyDecline()
	{
		LMHHKDFCKFC lmhhkdfckfc = AKLFPGMDKLA.EHBBFMCILPC.PNLLCLPMIGA();
		if (lmhhkdfckfc != null && PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager().GetProductData(lmhhkdfckfc.DEJCCBNPFEC) != null)
		{
			CommonUserInterface.EHBBFMCILPC.ShowPopupOffer(lmhhkdfckfc.DEJCCBNPFEC, CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().GetProductThumbnailGraphics(lmhhkdfckfc.DEJCCBNPFEC));
		}
	}

	// Token: 0x060009D0 RID: 2512 RVA: 0x0004980F File Offset: 0x00047A0F
	private void HIODKHCOJOE()
	{
		this.EAINMDCBPBC();
		this.MHMPFANBPOC();
	}

	// Token: 0x060009D1 RID: 2513 RVA: 0x0004A30B File Offset: 0x0004850B
	private void IGACHKLONEB()
	{
		if (this.PHMIBKAJKMB == null)
		{
			this.PHMIBKAJKMB = FADIGFEOCND.MPPPABFFGKJ(934f);
		}
	}

	// Token: 0x060009D2 RID: 2514 RVA: 0x0004A328 File Offset: 0x00048528
	private void LEJINFEPNPJ()
	{
		this.NPMNDNEDBGC += 0;
		if (this.NPMNDNEDBGC >= KBOJLHAJPCP.LPJOFEDNKHA)
		{
			CommonUserInterface.IKNOFBFMPGA().HideConnectingAnimation();
			FirebaseAnalyticsManager.DMAAFFFEJGA().JIAAMJPKOCE(false, AGEHCPDNBFD.chpActiv.ToString(), ((FFPHBMFGCNN)(-24)).ToString(), BGHLMGPPCNN.under30.ToString(), false, false);
			this.NPMNDNEDBGC = 1;
			CommonUserInterface.IKNOFBFMPGA().BGJFCEEDGFJ(CCOJBMMKNAP.OEPENBHJAHO().FCOCLEHKLDJ(""), CCOJBMMKNAP.HFAKOKBHCGH().IKMNGFIDCLM("lrewsnap"), CCOJBMMKNAP.HFAKOKBHCGH().MEPECBDCOLG(" "), new UnityAction(this.DownloadAssetBundleFolder), (DFGILFBGPLN)(-96), 1713f, 56);
			return;
		}
		this.DownloadAssetBundleFolder();
	}

	// Token: 0x060009D3 RID: 2515 RVA: 0x0004A3F4 File Offset: 0x000485F4
	private void KEGGANEJLBG()
	{
		base.StartCoroutine(this.LDEGJJJAOOM());
	}

	// Token: 0x060009D4 RID: 2516 RVA: 0x0004A403 File Offset: 0x00048603
	private void BBHFNAHFCDJ()
	{
		if (this.PHMIBKAJKMB == null)
		{
			this.PHMIBKAJKMB = FADIGFEOCND.IMEFIJEKFGI(422f);
		}
	}

	// Token: 0x060009D5 RID: 2517 RVA: 0x0004A420 File Offset: 0x00048620
	private void ANPPBMKBDOM()
	{
		this.starsAnimation.enabled = false;
		this.starsAnimation.GetComponent<Image>().DOFade(1352f, 565f).OnComplete(new TweenCallback(this.KMJACHFHGAP));
		this.selectorLightAnimation.gameObject.SetActive(false);
		this.CELEKHKIJIK();
	}

	// Token: 0x060009D6 RID: 2518 RVA: 0x0004A47C File Offset: 0x0004867C
	private void LGMCPCNCHPP(string GHEPCOMJCOC)
	{
		int lllcdmnpkfi = WheelItem.spinWheelCardIndex;
		string text = "<align=\"center\"><alpha=#88>" + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialcardvolinfonote").Replace("XXX", GDJPPKAMIFL.EHBBFMCILPC.DKHIPEPOEFF(lllcdmnpkfi) ?? "") + "<align=\"left\"><alpha=#FF>\n\n" + GHEPCOMJCOC;
		text = text + "\n\n" + this.KEGENPFEPAJ(lllcdmnpkfi);
		GDJPPKAMIFL.EHBBFMCILPC.KCMKJBHBCGC(lllcdmnpkfi);
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("congratstitle"), text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialcollectedcardopenv2"), new UnityAction(this.OnCardViewAsCollectedClick), new UnityAction(this.KFLIPKGBOBM), DFGILFBGPLN.popupEnergyHint, 0f, 28);
	}

	// Token: 0x060009D7 RID: 2519 RVA: 0x0004A540 File Offset: 0x00048740
	private void Start()
	{
		this.PFEEFOKHKMP = base.transform.localScale;
		this.GDIGLAFFJNE();
		this.HJPKJDHKJMO = new Dictionary<PEOGABBHPNP, int>
		{
			{
				PEOGABBHPNP.wofResourcesGems,
				0
			},
			{
				PEOGABBHPNP.wofResourcesSp0,
				1
			},
			{
				PEOGABBHPNP.wofResourcesCard4,
				2
			},
			{
				PEOGABBHPNP.wofResourcesSp2,
				3
			},
			{
				PEOGABBHPNP.wofResourcesCard2,
				4
			},
			{
				PEOGABBHPNP.wofResourcesTea,
				5
			},
			{
				PEOGABBHPNP.wofResourcesSp1,
				6
			},
			{
				PEOGABBHPNP.wofResourcesCard3,
				7
			},
			{
				PEOGABBHPNP.wofResourcesCard0,
				8
			},
			{
				PEOGABBHPNP.wofResourcesCard1,
				9
			}
		};
	}

	// Token: 0x060009D8 RID: 2520 RVA: 0x0004A5C4 File Offset: 0x000487C4
	private void ALGIAIKDEPH()
	{
		for (int i = 0; i < this.lobbyCanvases.Count; i++)
		{
			this.lobbyCanvases[i].enabled = false;
		}
	}

	// Token: 0x060009D9 RID: 2521 RVA: 0x0004A5F9 File Offset: 0x000487F9
	public void OnCardViewAsCollectedClick()
	{
		LJNMIPMNOKF.EHBBFMCILPC.KNAEAJPDGKB(GCFLILHCOEI.cardsFilterCollected, WheelItem.spinWheelCardIndex, -1);
		LJNMIPMNOKF.EHBBFMCILPC.AMCFJAMHKHN(WheelItem.spinWheelCardIndex);
		this.ShowCardOptionsOrDownload();
	}

	// Token: 0x060009DA RID: 2522 RVA: 0x0004A621 File Offset: 0x00048821
	private void EKNLABKCIJF()
	{
		if (this.PHMIBKAJKMB == null)
		{
			this.PHMIBKAJKMB = FADIGFEOCND.IMEFIJEKFGI(1000000f);
		}
	}

	// Token: 0x060009DB RID: 2523 RVA: 0x0004A63C File Offset: 0x0004883C
	public void ViewCutscene(BNFCLKNDBLO CIBKELALAHF)
	{
		if (CIBKELALAHF != null)
		{
			if (CIBKELALAHF.LHNIAKBBPDN() > 0 && !KHPGPLAMAIN.DFJHJCAIFJO())
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("novideosupportmsg"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
				return;
			}
			this.BMODBEEEABE = CIBKELALAHF;
			AssetsManager.EHBBFMCILPC.UnloadPersistentAssetBundles();
			this.DownloadAssetBundleFolder();
		}
	}

	// Token: 0x060009DC RID: 2524 RVA: 0x0004A6B5 File Offset: 0x000488B5
	public void DownloadAssetBundleFolder()
	{
		base.StartCoroutine(this.HNKPMLGCKHO());
	}

	// Token: 0x060009DD RID: 2525 RVA: 0x0004A6C4 File Offset: 0x000488C4
	public void OnSpinsInfoClick()
	{
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("spinsamounthint"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
	}

	// Token: 0x060009DE RID: 2526 RVA: 0x0004A714 File Offset: 0x00048914
	private void FBLJOICAIKD()
	{
		for (int i = 0; i < this.lobbyCameras.Count; i++)
		{
			this.lobbyCameras[i].enabled = true;
		}
	}

	// Token: 0x060009DF RID: 2527 RVA: 0x0004A74C File Offset: 0x0004894C
	private void PNFGCOMCIFB()
	{
		for (int i = 5; i <= 9; i++)
		{
			int num = i - 5;
			List<int> list = GDJPPKAMIFL.EHBBFMCILPC.GLMCBPJAKCL(num);
			if (num == 0)
			{
				this.wofResourcesCard0ActiveNumberImage.SetActive(list.Count > 0);
				this.wofResourcesCard0ActiveNumberText.text = (list.Count.ToString() ?? "");
				this.wofResourcesCard0ActiveNumberText.SetText(list.Count.ToString() ?? "", true);
			}
			else if (num == 1)
			{
				this.wofResourcesCard1ActiveNumberImage.SetActive(list.Count > 0);
				this.wofResourcesCard1ActiveNumberText.text = (list.Count.ToString() ?? "");
				this.wofResourcesCard1ActiveNumberText.SetText(list.Count.ToString() ?? "", true);
			}
			else if (num == 2)
			{
				this.wofResourcesCard2ActiveNumberImage.SetActive(list.Count > 0);
				this.wofResourcesCard2ActiveNumberText.text = (list.Count.ToString() ?? "");
				this.wofResourcesCard2ActiveNumberText.SetText(list.Count.ToString() ?? "", true);
			}
			else if (num == 3)
			{
				this.wofResourcesCard3ActiveNumberImage.SetActive(list.Count > 0);
				this.wofResourcesCard3ActiveNumberText.text = (list.Count.ToString() ?? "");
				this.wofResourcesCard3ActiveNumberText.SetText(list.Count.ToString() ?? "", true);
			}
			else if (num == 4)
			{
				this.wofResourcesCard4ActiveNumberImage.SetActive(list.Count > 0);
				this.wofResourcesCard4ActiveNumberText.text = (list.Count.ToString() ?? "");
				this.wofResourcesCard4ActiveNumberText.SetText(list.Count.ToString() ?? "", true);
			}
		}
	}

	// Token: 0x060009E0 RID: 2528 RVA: 0x0004A95D File Offset: 0x00048B5D
	private IEnumerator HNKPMLGCKHO()
	{
		AssetsManager.EHBBFMCILPC.InitializeAssetBundleFolder((LNDOOJOFFOM)this.BMODBEEEABE.FJFEPNKBELL, "OnCutsceneViewAssetBundleFolderInitializeSuccess", "OnCutsceneViewAssetsDownloadFailed");
		yield return null;
		yield break;
	}

	// Token: 0x060009E1 RID: 2529 RVA: 0x0004A136 File Offset: 0x00048336
	private void KBCPMHKNEGB()
	{
		this.EFDNHBCECGF(0);
	}

	// Token: 0x060009E2 RID: 2530 RVA: 0x0004A96C File Offset: 0x00048B6C
	private void PLCCIKBHNCL(Button EKAPJKKPPGG, bool OJIDGNPCODM)
	{
		ColorBlock colors = EKAPJKKPPGG.colors;
		Color normalColor = colors.normalColor;
		Color disabledColor = colors.disabledColor;
		Image[] componentsInChildren = EKAPJKKPPGG.GetComponentsInChildren<Image>();
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			componentsInChildren[i].color = (OJIDGNPCODM ? normalColor : disabledColor);
		}
		TextMeshProUGUI[] componentsInChildren2 = EKAPJKKPPGG.GetComponentsInChildren<TextMeshProUGUI>();
		for (int i = 1; i < componentsInChildren2.Length; i += 0)
		{
			componentsInChildren2[i].color = (OJIDGNPCODM ? normalColor : disabledColor);
		}
		EKAPJKKPPGG.interactable = OJIDGNPCODM;
	}

	// Token: 0x060009E3 RID: 2531 RVA: 0x0004A9EC File Offset: 0x00048BEC
	private void OPEGJAEFAJL()
	{
		for (int i = 0; i < this.lobbyCameras.Count; i++)
		{
			this.lobbyCameras[i].enabled = true;
		}
	}

	// Token: 0x060009E4 RID: 2532 RVA: 0x0004AA24 File Offset: 0x00048C24
	public void OnSpinWheelButtonPointerUp()
	{
		if (this.LGBIFDPMNIB == this.KFPMMNPNGHG)
		{
			return;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.ABGNIKKFFAC.GALKFKBPLCK() <= 0)
		{
			return;
		}
		this.KFPMMNPNGHG++;
		this.spinWheelEventTrigger.enabled = false;
		this.PNNIBEGIKDC(this.spinWheelButton, false);
		AKLFPGMDKLA.EHBBFMCILPC.ABGNIKKFFAC.LIPFPCFDEAM();
		this.GMIPGNMGFPJ();
		this.SendSpinWheelBackendRequest();
	}

	// Token: 0x060009E5 RID: 2533 RVA: 0x0004AA98 File Offset: 0x00048C98
	private void DHEHOINABCL()
	{
		this.JDPLEJELPNF = true;
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		this.PHMIBKAJKMB.EPJKDCDOEMM((float)WheelItem.spinsFireTime);
		this.GMIPGNMGFPJ();
		if (WheelItem.spinWheelResult > 0)
		{
			this.LDCBHDPIPMG((PEOGABBHPNP)WheelItem.spinWheelReward);
			return;
		}
		this.LDCBHDPIPMG(PEOGABBHPNP.wofResourcesGems);
	}

	// Token: 0x060009E6 RID: 2534 RVA: 0x0004AAE8 File Offset: 0x00048CE8
	public void ViewCardCutscene()
	{
		int lllcdmnpkfi = AOBJLALDBAA.EHBBFMCILPC.MJLACDOKGNE();
		CLGFGOHBCGJ clgfgohbcgj = LJNMIPMNOKF.EHBBFMCILPC.KMDBNEFCPOH(lllcdmnpkfi);
		BNFCLKNDBLO bnfclkndblo = new BNFCLKNDBLO();
		bnfclkndblo.IBFLNCMCKAL = GDJPPKAMIFL.EHBBFMCILPC.KANJCCECECA(lllcdmnpkfi);
		string text = GKJPOGNFKNK.OCOEFCIJGIE(lllcdmnpkfi);
		if (text.Length > 0)
		{
			bnfclkndblo.IBFLNCMCKAL = text;
		}
		bnfclkndblo.FPJPHNLANPG = 2;
		bnfclkndblo.PGEKNGNHANN = clgfgohbcgj.APMIAIEKIHD;
		bnfclkndblo.FONKDFDJFEL = GDJPPKAMIFL.EHBBFMCILPC.EDBFHCLIONI(lllcdmnpkfi);
		bnfclkndblo.AMKCLHLIIMN = GDJPPKAMIFL.EHBBFMCILPC.GJEINLADFKA(lllcdmnpkfi);
		bnfclkndblo.FJFEPNKBELL = bnfclkndblo.AMKCLHLIIMN + 1;
		int num = GDJPPKAMIFL.EHBBFMCILPC.GCDJGGEMDLP(lllcdmnpkfi);
		int num2 = GKJPOGNFKNK.HPMGFDAPLLP(lllcdmnpkfi);
		if (num2 >= 0)
		{
			num = num2;
		}
		bnfclkndblo.CIEHGJMAFKH = "abs" + GDJPPKAMIFL.EHBBFMCILPC.HBKANKMHEMN(lllcdmnpkfi).ToString() + "asp" + num.ToString();
		bnfclkndblo.OEOPLGFENOO = "abs" + GDJPPKAMIFL.EHBBFMCILPC.BIHMLDGDEGP(lllcdmnpkfi).ToString() + "asp" + GDJPPKAMIFL.EHBBFMCILPC.LDKDEPIGOFN(lllcdmnpkfi).ToString();
		bnfclkndblo.CGBHBJPLKIM = clgfgohbcgj;
		this.ViewCutscene(bnfclkndblo);
	}

	// Token: 0x060009E7 RID: 2535 RVA: 0x00003E52 File Offset: 0x00002052
	private void CHEELBDINDH()
	{
	}

	// Token: 0x060009E8 RID: 2536 RVA: 0x0004AC18 File Offset: 0x00048E18
	private void EHNECGHAKOL()
	{
		this.wheelBlurAnimation.SetActive(false);
		float num = (float)(this.HIDJGIMJFML * 36);
		this.wheelAnimation.transform.DORotate(new Vector3(0f, 0f, -num - 360f), 3f, RotateMode.FastBeyond360).SetEase(Ease.OutQuad).OnComplete(new TweenCallback(this.CFOGOHGGBJH));
	}

	// Token: 0x060009E9 RID: 2537 RVA: 0x0004AC84 File Offset: 0x00048E84
	public void ShowCardOptionsOrDownload()
	{
		if (!GKJPOGNFKNK.NAAOKDICGMJ(WheelItem.spinWheelCardIndex))
		{
			base.StartCoroutine(this.FLDAMFANFCL());
			return;
		}
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnLobbyStartFireworksEffectAutoHide", 0f);
		LobbyUserInterface.EHBBFMCILPC.ShowPopupCardOptions(LJNMIPMNOKF.EHBBFMCILPC.EBBLJMHNDKK(), null, HKPBEDBPHNJ.viewGiftCardAsWon, "", null);
	}

	// Token: 0x060009EA RID: 2538 RVA: 0x0004ACDC File Offset: 0x00048EDC
	private string KEGENPFEPAJ(int LLLCDMNPKFI)
	{
		return CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialcardhintoncopiesv2").Replace("YYY", CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(750 + GDJPPKAMIFL.EHBBFMCILPC.NDJDOAPFCLH(LLLCDMNPKFI)) + KBOJLHAJPCP.FIOEKALDNPB[GDJPPKAMIFL.EHBBFMCILPC.NDJDOAPFCLH(LLLCDMNPKFI)]).Replace("WWW", LJNMIPMNOKF.EHBBFMCILPC.KMDBNEFCPOH(LLLCDMNPKFI).HFLPLGMJNOI.ToString() + KBOJLHAJPCP.HLGAIGGHMNF).Replace("QQQ", LJNMIPMNOKF.EHBBFMCILPC.KMDBNEFCPOH(LLLCDMNPKFI).ENCCLBLHJMC.ToString() + KBOJLHAJPCP.PLFMGKIEAOP);
	}

	// Token: 0x060009EB RID: 2539 RVA: 0x0004AD88 File Offset: 0x00048F88
	private void JLGCLBPIACG()
	{
		for (int i = 1; i < this.lobbyCameras.Count; i++)
		{
			this.lobbyCameras[i].enabled = false;
		}
	}

	// Token: 0x060009EC RID: 2540 RVA: 0x0004ADBD File Offset: 0x00048FBD
	private IEnumerator KDBPFGOBDCB()
	{
		return new WheelItem.APPJFLHMEBB(1);
	}

	// Token: 0x060009ED RID: 2541 RVA: 0x0004ADC5 File Offset: 0x00048FC5
	private void LDCBHDPIPMG(PEOGABBHPNP HFKKMPIFGBF)
	{
		this.HIDJGIMJFML = this.HJPKJDHKJMO[HFKKMPIFGBF];
		this.GIKOPFCALGA.Kill(true);
	}

	// Token: 0x060009EE RID: 2542 RVA: 0x0004ADE5 File Offset: 0x00048FE5
	private void OFFBAMLEFNH()
	{
		this.PHMIBKAJKMB.EPJKDCDOEMM((float)WheelItem.spinsFireTime);
		this.GMIPGNMGFPJ();
		this.MHMPFANBPOC();
		this.EAINMDCBPBC();
	}

	// Token: 0x060009EF RID: 2543 RVA: 0x0004AE0C File Offset: 0x0004900C
	private void AEKCPCJCBAH()
	{
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.EHBBFMCILPC.PDJKPFLHFLO(KDCJJBLGCBH.EHBBFMCILPC.DIPIMDKACKM(this.JEKBNMGOLEK));
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
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnSpinsUnlockContinueToPurchasingScreen", 0f);
		CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().ShowAndPurchaseProduct(KDCJJBLGCBH.EHBBFMCILPC.DIPIMDKACKM(this.JEKBNMGOLEK), true);
	}

	// Token: 0x060009F0 RID: 2544 RVA: 0x0004AEC4 File Offset: 0x000490C4
	private void GHPNAFIMKOA()
	{
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("congratstitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("wofrewardmsg1"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("collect"), new UnityAction(this.KFLIPKGBOBM), new UnityAction(this.KFLIPKGBOBM), DFGILFBGPLN.popupBonusUnlock, 0f, 28).ShowLiveAvatar(WheelItem.spinWheelRewardSubcategoryValue);
	}

	// Token: 0x060009F1 RID: 2545 RVA: 0x0004AF34 File Offset: 0x00049134
	private void DJDHOAMAPMO()
	{
		this.LMBJHMBADAF();
		this.JOFENHOACGG();
	}

	// Token: 0x060009F2 RID: 2546 RVA: 0x0004AF44 File Offset: 0x00049144
	private void NPNAGNMBCCC()
	{
		if (this.KAOPCAJLLPM != null)
		{
			AKLFPGMDKLA.EHBBFMCILPC.COJFECEAKKI = this.KAOPCAJLLPM.OLNJMJMNBCN();
		}
		else
		{
			AKLFPGMDKLA.EHBBFMCILPC.COJFECEAKKI = -1;
		}
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cardsvolchancesmsgtitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cardsvolchancesmsgbody"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("continue"), new UnityAction(this.DNBJGJJOMCI), DFGILFBGPLN.popupBackendError, 0.15f, 28);
	}

	// Token: 0x060009F3 RID: 2547 RVA: 0x0004AFC8 File Offset: 0x000491C8
	private void EAINMDCBPBC()
	{
		bool flag = false;
		for (int i = 0; i < AKLFPGMDKLA.EHBBFMCILPC.BKADBDBHFCP.Count; i++)
		{
			if (i < KDCJJBLGCBH.EHBBFMCILPC.MCONOJKMHBE() && AKLFPGMDKLA.EHBBFMCILPC.BKADBDBHFCP[i] > 0)
			{
				flag = true;
			}
		}
		if (!flag)
		{
			this.guaranteedCardDropIconButton.SetActive(false);
			return;
		}
		this.guaranteedCardDropIconButton.SetActive(true);
	}

	// Token: 0x060009F4 RID: 2548 RVA: 0x0004B02F File Offset: 0x0004922F
	private void FHKGILKPHNM()
	{
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		this.CMDIKMNEGEN();
		this.GHPNAFIMKOA();
	}

	// Token: 0x060009F5 RID: 2549 RVA: 0x0004B054 File Offset: 0x00049254
	private void JAIHHKPNDPC()
	{
		this.NPMNDNEDBGC += 0;
		if (this.NPMNDNEDBGC >= KBOJLHAJPCP.LPJOFEDNKHA)
		{
			CommonUserInterface.EHBBFMCILPC.MCJIGJMFBMI();
			CommonUserInterface.IKNOFBFMPGA().HideGenericPopupNoButtons();
			FirebaseAnalyticsManager.ANCEKPONIFI().LogEvent(false, AGEHCPDNBFD.bugRep.ToString(), FFPHBMFGCNN.cdnSigHigh.ToString(), ((BGHLMGPPCNN)(-104)).ToString(), true, true);
			this.NPMNDNEDBGC = 1;
			CommonUserInterface.IKNOFBFMPGA().CEGLPJNLBHL(CCOJBMMKNAP.COKDLDOAACJ().PPALCPINPLK("OnCollectableDialogShown"), CCOJBMMKNAP.HEDIEIICOOG().PGKBCNBAOJN("OnChapterSnapshotsBackendFetchSuccess"), CCOJBMMKNAP.JINDKPHNLBK().OBDCPLLLGBB("NNN"), new UnityAction(this.HBHEGKNIHJD), new UnityAction(this.GHPNAFIMKOA), DFGILFBGPLN.screenCutscene, 1843f, -72);
			return;
		}
		this.HBHEGKNIHJD();
	}

	// Token: 0x060009F6 RID: 2550 RVA: 0x0004B138 File Offset: 0x00049338
	private void JCGDCHMFKCJ()
	{
		this.NPMNDNEDBGC++;
		if (this.NPMNDNEDBGC >= KBOJLHAJPCP.LPJOFEDNKHA)
		{
			CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
			CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.cdnActiv.ToString(), FFPHBMFGCNN.dldFail.ToString(), BGHLMGPPCNN.cdnWofToLpt.ToString(), false, false);
			this.NPMNDNEDBGC = 0;
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cdnerror"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("retry"), new UnityAction(this.EDDGNMCNGNG), new UnityAction(this.GHPNAFIMKOA), DFGILFBGPLN.popupCdnDownloadFailed, 0f, 28);
			return;
		}
		this.EDDGNMCNGNG();
	}

	// Token: 0x060009F7 RID: 2551 RVA: 0x0004B21C File Offset: 0x0004941C
	private void OGCIHMNFDCI()
	{
		this.PMKMDCFFFGA();
		this.CPGLEJIBNEP += Time.deltaTime;
		if (this.CPGLEJIBNEP > WheelItem.CBOKJGNCEKE && this.KAOPCAJLLPM != null && this.increasedVolDropChances.activeSelf && this.KAOPCAJLLPM.ONMADEIOOKN.OGIIHGIBCDF())
		{
			this.increasedVolDropChances.gameObject.SetActive(true);
			this.KAOPCAJLLPM = null;
			this.CPGLEJIBNEP = 919f;
		}
	}

	// Token: 0x060009F8 RID: 2552 RVA: 0x00003E52 File Offset: 0x00002052
	private void MBPJPLLCIJD()
	{
	}

	// Token: 0x060009F9 RID: 2553 RVA: 0x0004B298 File Offset: 0x00049498
	public void OnPopupNotEnoughEnergyOrHardCurrencyGetMore2()
	{
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnSpinsUnlockContinueToPurchasingScreen", 0f);
		CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().Show(true);
	}

	// Token: 0x060009FA RID: 2554 RVA: 0x0004B2C0 File Offset: 0x000494C0
	private void AGANBIOCPNC()
	{
		if (0 == AKLFPGMDKLA.EHBBFMCILPC.PACMCEHMBGG)
		{
			AudioManager.IFDLAMLHKIJ().HPPAFEAPINO("%", true, 70f, false);
		}
		this.OPEGJAEFAJL();
		this.EGDHPGKNLAM();
		AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets((NMKDCBPMCKI)87, -1);
		this.OnPopupCardOptionsReopen();
	}

	// Token: 0x060009FB RID: 2555 RVA: 0x00003E52 File Offset: 0x00002052
	private void HKFDBOKFNLB()
	{
	}

	// Token: 0x060009FC RID: 2556 RVA: 0x0004B310 File Offset: 0x00049510
	private void FMDHMFAPJHL()
	{
		this.EFDNHBCECGF(2);
	}

	// Token: 0x060009FD RID: 2557 RVA: 0x0004B31C File Offset: 0x0004951C
	private void OnDisable()
	{
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendRequestSpinWheelSuccess", new UnityAction(this.DHEHOINABCL));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendRequestSpinWheelException", new UnityAction(this.EKMKDFFLJAO));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnApplicationFocusBasicSyncSuccess", new UnityAction(this.OFFBAMLEFNH));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPurchasingViewLeave", new UnityAction(this.OnPurchasingViewLeave));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnAllCollectableCardsDownloadSuccess", new UnityAction(this.KBDAHECFAJM));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnAllCollectableCardsDownloadFailed", new UnityAction(this.OAJDBPJBABO));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnFullscreenCardOptionClick", new UnityAction(this.ViewCardCutscene));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnCutsceneViewAssetBundleFolderInitializeSuccess", new UnityAction(this.KEGGANEJLBG));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnCutsceneViewAssetsDownloadSuccess", new UnityAction(this.FDPBIPDPDEP));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnCutsceneViewAssetsDownloadFailed", new UnityAction(this.HGMFGPNMEDL));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnCutsceneViewLeft", new UnityAction(this.LBFDDEFKCJN));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnFriendsGiftPopulCollectPart2", new UnityAction(this.EGBEPEIEJGL));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnLiveProfileThemeDownloadSuccess", new UnityAction(this.FHKGILKPHNM));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnLiveProfileThemeDownloadFailed", new UnityAction(this.JCGDCHMFKCJ));
		this.selectorLightAnimation.gameObject.SetActive(false);
	}

	// Token: 0x060009FE RID: 2558 RVA: 0x0004B4B4 File Offset: 0x000496B4
	private void HGMFGPNMEDL()
	{
		this.NPMNDNEDBGC++;
		if (this.NPMNDNEDBGC >= KBOJLHAJPCP.LPJOFEDNKHA)
		{
			CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.cdnActiv.ToString(), FFPHBMFGCNN.dldFail.ToString(), BGHLMGPPCNN.cdnWofToCut.ToString(), false, false);
			this.NPMNDNEDBGC = 0;
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cdnerror"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("retry"), new UnityAction(this.DownloadAssetBundleFolder), DFGILFBGPLN.popupCdnDownloadFailed, 0f, 28);
			return;
		}
		this.DownloadAssetBundleFolder();
	}

	// Token: 0x060009FF RID: 2559 RVA: 0x0004B580 File Offset: 0x00049780
	private void COLKHCMHACP()
	{
		if (GKJPOGNFKNK.AKJCGMFMGMK(WheelItem.spinWheelRewardSubcategoryValue))
		{
			this.GHPNAFIMKOA();
			return;
		}
		base.StartCoroutine(this.MIAAILGJGGO());
	}

	// Token: 0x06000A00 RID: 2560 RVA: 0x0004B5A4 File Offset: 0x000497A4
	private void NBJBGHNPLEJ()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.ODMKLADKHMO.GALKFKBPLCK() < KDCJJBLGCBH.EHBBFMCILPC.KJCFGPMBDJL())
		{
			CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().SetResourcesFilter(JFGBECHLPGI.hardCurrency);
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("holdontitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("nomorediamonds"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), new UnityAction(this.OnPopupNotEnoughEnergyOrHardCurrencyGetMore), new UnityAction(this.OnPopupNotEnoughEnergyOrHardCurrencyDecline), DFGILFBGPLN.popupNotEnoughHardCurrency, 0f, 28);
			return;
		}
		WheelItem.doubleOddsRequested = true;
		AKLFPGMDKLA.EHBBFMCILPC.DJLLDNNIMMK.EKDHFAODNHF(KDCJJBLGCBH.EHBBFMCILPC.LFBPOFBEBAP());
		this.MHMPFANBPOC();
		FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.wofDblOdds.ToString(), FFPHBMFGCNN.wofDblOddsAct.ToString(), "", false, false);
	}

	// Token: 0x06000A01 RID: 2561 RVA: 0x0004B68D File Offset: 0x0004988D
	private void BMBBLOBPPIB()
	{
		this.FJPBIMENNKD();
		this.PNNIBEGIKDC(this.doubleCardsOddsButton, true);
	}

	// Token: 0x06000A02 RID: 2562 RVA: 0x0004B6A4 File Offset: 0x000498A4
	private void CFOGOHGGBJH()
	{
		this.starsAnimation.enabled = false;
		this.starsAnimation.GetComponent<Image>().DOFade(0f, 1f).OnComplete(new TweenCallback(this.KMJACHFHGAP));
		this.selectorLightAnimation.gameObject.SetActive(true);
		this.CELEKHKIJIK();
	}

	// Token: 0x06000A03 RID: 2563 RVA: 0x0004B700 File Offset: 0x00049900
	private void CELEKHKIJIK()
	{
		if (this.JDPLEJELPNF)
		{
			AKLFPGMDKLA.EHBBFMCILPC.CIPCINKGILF = true;
			base.StartCoroutine(this.JLOJDHBAEDH());
			return;
		}
		CommonUserInterface.EHBBFMCILPC.ResumeUX();
	}

	// Token: 0x06000A04 RID: 2564 RVA: 0x0004B730 File Offset: 0x00049930
	public void PurchaseProductWeb()
	{
		OBHDGKFFICI productData = PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager().GetProductData(KDCJJBLGCBH.EHBBFMCILPC.DIPIMDKACKM(this.JEKBNMGOLEK));
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.EHBBFMCILPC.PDJKPFLHFLO(KDCJJBLGCBH.EHBBFMCILPC.DIPIMDKACKM(this.JEKBNMGOLEK));
		if (productData != null && ocbiopoeenj != null)
		{
			CommonUserInterface.EHBBFMCILPC.ShowPopupOnlineResources(ocbiopoeenj.MBLAIKOOCFH() + "?uid=" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 2);
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("WheelItem.PurchaseProductWeb(): productData or productBalanceData is null");
	}

	// Token: 0x06000A05 RID: 2565 RVA: 0x0004B7AE File Offset: 0x000499AE
	private void DNBJGJJOMCI()
	{
		if (this.increasedVolDropChances.activeSelf)
		{
			this.increasedVolDropChances.gameObject.SetActive(false);
			this.increasedVolDropChances.gameObject.SetActive(true);
		}
	}

	// Token: 0x06000A06 RID: 2566 RVA: 0x0004B7E0 File Offset: 0x000499E0
	private void PMKMDCFFFGA()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.ABGNIKKFFAC.GALKFKBPLCK() < KDCJJBLGCBH.EHBBFMCILPC.HLPACDMEKMK(ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass, true)))
		{
			if (!this.timerText.gameObject.activeSelf)
			{
				this.timerText.gameObject.SetActive(true);
			}
			this.timerText.text = DPGJIJGOCIC.DMENNJGBMBH((int)this.PHMIBKAJKMB.ODHBINFKIPL());
			this.timerText.SetText(DPGJIJGOCIC.DMENNJGBMBH((int)this.PHMIBKAJKMB.ODHBINFKIPL()), true);
			if (this.PHMIBKAJKMB.HACBALNLLPP())
			{
				AKLFPGMDKLA.EHBBFMCILPC.ABGNIKKFFAC.IIFIBJDPHFF(1);
				this.GMIPGNMGFPJ();
				if (AKLFPGMDKLA.EHBBFMCILPC.ABGNIKKFFAC.GALKFKBPLCK() < KDCJJBLGCBH.EHBBFMCILPC.HLPACDMEKMK(ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass, true)))
				{
					this.PHMIBKAJKMB.EPJKDCDOEMM((float)KDCJJBLGCBH.EHBBFMCILPC.ADLOIIMBHAG(ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass, true)));
					return;
				}
			}
		}
		else if (this.timerText.gameObject.activeSelf)
		{
			this.timerText.gameObject.SetActive(false);
		}
	}

	// Token: 0x06000A07 RID: 2567 RVA: 0x0004B8F4 File Offset: 0x00049AF4
	private void EKMKDFFLJAO()
	{
		this.JDPLEJELPNF = false;
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("app42error"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupBackendError, 0f, 28);
		this.GMIPGNMGFPJ();
		this.MHMPFANBPOC();
		this.EAINMDCBPBC();
		this.LDCBHDPIPMG(PEOGABBHPNP.wofResourcesGems);
	}

	// Token: 0x06000A08 RID: 2568 RVA: 0x0004B96C File Offset: 0x00049B6C
	private void Update()
	{
		this.PMKMDCFFFGA();
		this.CPGLEJIBNEP += Time.deltaTime;
		if (this.CPGLEJIBNEP > WheelItem.CBOKJGNCEKE && this.KAOPCAJLLPM != null && this.increasedVolDropChances.activeSelf && this.KAOPCAJLLPM.ONMADEIOOKN.HACBALNLLPP())
		{
			this.increasedVolDropChances.gameObject.SetActive(false);
			this.KAOPCAJLLPM = null;
			this.CPGLEJIBNEP = 0f;
		}
	}

	// Token: 0x06000A09 RID: 2569 RVA: 0x0004B9E8 File Offset: 0x00049BE8
	[CompilerGenerated]
	private void KMJACHFHGAP()
	{
		this.starsAnimation.gameObject.SetActive(false);
		this.PNNIBEGIKDC(this.spinWheelButton, true);
		this.spinWheelEventTrigger.enabled = true;
	}

	// Token: 0x06000A0A RID: 2570 RVA: 0x0004BA14 File Offset: 0x00049C14
	private void NILDGEGJIHJ(Button EKAPJKKPPGG, bool OJIDGNPCODM)
	{
		ColorBlock colors = EKAPJKKPPGG.colors;
		Color normalColor = colors.normalColor;
		Color disabledColor = colors.disabledColor;
		Image[] componentsInChildren = EKAPJKKPPGG.GetComponentsInChildren<Image>();
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			componentsInChildren[i].color = (OJIDGNPCODM ? normalColor : disabledColor);
		}
		TextMeshProUGUI[] componentsInChildren2 = EKAPJKKPPGG.GetComponentsInChildren<TextMeshProUGUI>();
		for (int i = 1; i < componentsInChildren2.Length; i += 0)
		{
			componentsInChildren2[i].color = (OJIDGNPCODM ? normalColor : disabledColor);
		}
		EKAPJKKPPGG.interactable = OJIDGNPCODM;
	}

	// Token: 0x06000A0B RID: 2571 RVA: 0x0004BA94 File Offset: 0x00049C94
	public void OnDoubleOddsIconClick()
	{
		string dpjinbcgngn;
		if (KDCJJBLGCBH.EHBBFMCILPC.MCPOIBPFHDE() <= 2)
		{
			dpjinbcgngn = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("spinsdoubleoddshint").Replace("XXX", AKLFPGMDKLA.EHBBFMCILPC.DJLLDNNIMMK.GALKFKBPLCK().ToString() ?? "");
		}
		else
		{
			dpjinbcgngn = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("spinsdoubleoddshint3").Replace("XXX", AKLFPGMDKLA.EHBBFMCILPC.DJLLDNNIMMK.GALKFKBPLCK().ToString() ?? "");
		}
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), dpjinbcgngn, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
	}

	// Token: 0x06000A0C RID: 2572 RVA: 0x0004BB60 File Offset: 0x00049D60
	public void JKBOFKKKJJP()
	{
		base.transform.parent.GetComponent<CanvasGroup>().alpha = 685f;
		base.transform.parent.gameObject.SetActive(false);
		base.GetComponent<RectTransform>().localScale = this.PFEEFOKHKMP;
	}

	// Token: 0x06000A0D RID: 2573 RVA: 0x0004BBB0 File Offset: 0x00049DB0
	public void OnPurchaseSpinsClick()
	{
		string text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("spinsbuttoncustomize");
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.EHBBFMCILPC.PDJKPFLHFLO(KDCJJBLGCBH.EHBBFMCILPC.DIPIMDKACKM(0));
		if (ocbiopoeenj != null)
		{
			text = text.Replace("XXX", ocbiopoeenj.ABGNIKKFFAC.GALKFKBPLCK().ToString() ?? "").Replace("YYY", KBOJLHAJPCP.DEKEONCIDMG).Replace("ZZZ", WheelItem.GetLocalizedCostData(0));
		}
		string text2 = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("spinsbuttoncustomize");
		ocbiopoeenj = CJEKEHDEBLM.EHBBFMCILPC.PDJKPFLHFLO(KDCJJBLGCBH.EHBBFMCILPC.DIPIMDKACKM(1));
		if (ocbiopoeenj != null)
		{
			text2 = text2.Replace("XXX", ocbiopoeenj.ABGNIKKFFAC.GALKFKBPLCK().ToString() ?? "").Replace("YYY", KBOJLHAJPCP.DEKEONCIDMG).Replace("ZZZ", WheelItem.GetLocalizedCostData(1));
		}
		string text3 = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("spinsbuttoncustomize");
		ocbiopoeenj = CJEKEHDEBLM.EHBBFMCILPC.PDJKPFLHFLO(KDCJJBLGCBH.EHBBFMCILPC.DIPIMDKACKM(2));
		if (ocbiopoeenj != null)
		{
			text3 = text3.Replace("XXX", ocbiopoeenj.ABGNIKKFFAC.GALKFKBPLCK().ToString() ?? "").Replace("YYY", KBOJLHAJPCP.DEKEONCIDMG).Replace("ZZZ", WheelItem.GetLocalizedCostData(2));
		}
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithThreeButtonsInside(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("spinstitlenomorespins"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("spinsbodymorespins"), text, text2, text3, new UnityAction(this.KBCPMHKNEGB), new UnityAction(this.NCHJNFKNGKC), new UnityAction(this.FMDHMFAPJHL), new UnityAction(this.MBPJPLLCIJD), DFGILFBGPLN.popupEnergyHint, 0f, 28);
	}

	// Token: 0x06000A0E RID: 2574 RVA: 0x0004BD78 File Offset: 0x00049F78
	private void OnEnable()
	{
		this.CPGLEJIBNEP = WheelItem.CBOKJGNCEKE + 1f;
		this.AKGHCFAMOMH();
		this.PNFGCOMCIFB();
		this.GMIPGNMGFPJ();
		this.MHMPFANBPOC();
		this.EAINMDCBPBC();
		this.doubleCardsOddsText.text = (KDCJJBLGCBH.EHBBFMCILPC.KJCFGPMBDJL().ToString() ?? "");
		this.doubleCardsOddsText.SetText(KDCJJBLGCBH.EHBBFMCILPC.KJCFGPMBDJL().ToString() ?? "", true);
		if (KDCJJBLGCBH.EHBBFMCILPC.MCPOIBPFHDE() <= 2)
		{
			this.doubleCardsOddsTitle.text = (CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("wofbutton1") ?? "");
			this.doubleCardsOddsTitle.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("wofbutton1"), true);
		}
		else
		{
			this.doubleCardsOddsTitle.text = (CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("wofbutton3") ?? "");
			this.doubleCardsOddsTitle.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("wofbutton3"), true);
		}
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendRequestSpinWheelSuccess", new UnityAction(this.DHEHOINABCL));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendRequestSpinWheelException", new UnityAction(this.EKMKDFFLJAO));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnApplicationFocusBasicSyncSuccess", new UnityAction(this.OFFBAMLEFNH));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPurchasingViewLeave", new UnityAction(this.OnPurchasingViewLeave));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnAllCollectableCardsDownloadSuccess", new UnityAction(this.KBDAHECFAJM));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnAllCollectableCardsDownloadFailed", new UnityAction(this.OAJDBPJBABO));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnFullscreenCardOptionClick", new UnityAction(this.ViewCardCutscene));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnCutsceneViewAssetBundleFolderInitializeSuccess", new UnityAction(this.KEGGANEJLBG));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnCutsceneViewAssetsDownloadSuccess", new UnityAction(this.FDPBIPDPDEP));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnCutsceneViewAssetsDownloadFailed", new UnityAction(this.HGMFGPNMEDL));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnCutsceneViewLeft", new UnityAction(this.LBFDDEFKCJN));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnFriendsGiftPopulCollectPart2", new UnityAction(this.EGBEPEIEJGL));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnLiveProfileThemeDownloadSuccess", new UnityAction(this.FHKGILKPHNM));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnLiveProfileThemeDownloadFailed", new UnityAction(this.JCGDCHMFKCJ));
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(33))
		{
			AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(33);
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("woftutorial0"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("continue"), DFGILFBGPLN.popupTools, 0.5f, 28);
			return;
		}
		if (this.KAOPCAJLLPM != null && this.KAOPCAJLLPM.ONMADEIOOKN.ODHBINFKIPL() > 60f && AKLFPGMDKLA.EHBBFMCILPC.KGDHECCPKOP != this.KAOPCAJLLPM.OLNJMJMNBCN())
		{
			CommonUserInterface.EHBBFMCILPC.FreezeUX();
			AKLFPGMDKLA.EHBBFMCILPC.KGDHECCPKOP = this.KAOPCAJLLPM.OLNJMJMNBCN();
			base.StartCoroutine(this.PMGGOFPKIPP());
		}
	}

	// Token: 0x06000A0F RID: 2575 RVA: 0x0004C0C4 File Offset: 0x0004A2C4
	public static string GetLocalizedCostData(int JBEMALFGMAC)
	{
		OBHDGKFFICI productData = PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager().GetProductData(KDCJJBLGCBH.EHBBFMCILPC.DIPIMDKACKM(JBEMALFGMAC));
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.EHBBFMCILPC.PDJKPFLHFLO(KDCJJBLGCBH.EHBBFMCILPC.DIPIMDKACKM(JBEMALFGMAC));
		if (productData == null || ocbiopoeenj == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("WheelItem.GetLocalizedCostData() - productData is null.");
			return "";
		}
		if (ocbiopoeenj.OKGPIEEOKBM())
		{
			return ocbiopoeenj.FNJCEPLEPBH();
		}
		return "USD " + ocbiopoeenj.DMODNDCLGEJ;
	}

	// Token: 0x06000A11 RID: 2577 RVA: 0x0004C16C File Offset: 0x0004A36C
	private void EFDNHBCECGF(int JBEMALFGMAC)
	{
		this.JEKBNMGOLEK = JBEMALFGMAC;
		PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager().Initialize();
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru && GeoLocationManager.IsRussia() && KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA())
		{
			this.PurchaseProductWeb();
			return;
		}
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.AEKCPCJCBAH));
	}

	// Token: 0x06000A12 RID: 2578 RVA: 0x0004C1D1 File Offset: 0x0004A3D1
	private void GDIGLAFFJNE()
	{
		this.starsAnimation.framesSD = AssetsManager.EHBBFMCILPC.profileDataAsset4.wheelStarsSprites.ToArray();
	}

	// Token: 0x06000A13 RID: 2579 RVA: 0x0004C1F2 File Offset: 0x0004A3F2
	private IEnumerator JLOJDHBAEDH()
	{
		yield return new WaitForSeconds(1f);
		CommonUserInterface.EHBBFMCILPC.ResumeUX();
		PEOGABBHPNP peogabbhpnp = (PEOGABBHPNP)WheelItem.spinWheelReward;
		string text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("wofrewardmsg0");
		string text2 = "";
		FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.wofSpinRew.ToString(), peogabbhpnp.ToString(), "", false, false);
		switch (peogabbhpnp)
		{
		case PEOGABBHPNP.wofResourcesGems:
			if (WheelItem.spinWheelRewardSubcategory == 1)
			{
				text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("wofrewardmsg1");
			}
			else
			{
				text = text.Replace("YYY", KBOJLHAJPCP.BGMADCKNKAD).Replace("WWW", KBOJLHAJPCP.BGMADCKNKAD).Replace("XXX", WheelItem.spinWheelAmount.ToString() ?? "").Replace("ZZZ", AKLFPGMDKLA.EHBBFMCILPC.ODMKLADKHMO.GALKFKBPLCK().ToString() ?? "");
			}
			break;
		case PEOGABBHPNP.wofResourcesTea:
			text = text.Replace("YYY", KBOJLHAJPCP.APPEMCMGFJI).Replace("WWW", KBOJLHAJPCP.APPEMCMGFJI).Replace("XXX", WheelItem.spinWheelAmount.ToString() ?? "").Replace("ZZZ", AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.GALKFKBPLCK().ToString() ?? "");
			break;
		case PEOGABBHPNP.wofResourcesSp0:
			text = text.Replace("YYY", KBOJLHAJPCP.GJHKGBCLGIJ).Replace("WWW", KBOJLHAJPCP.GJHKGBCLGIJ).Replace("XXX", WheelItem.spinWheelAmount.ToString() ?? "").Replace("ZZZ", AKLFPGMDKLA.EHBBFMCILPC.OJNBAMPGBLJ.GALKFKBPLCK().ToString() ?? "");
			break;
		case PEOGABBHPNP.wofResourcesSp1:
			text = text.Replace("YYY", KBOJLHAJPCP.KGMFKFPBFBJ).Replace("WWW", KBOJLHAJPCP.KGMFKFPBFBJ).Replace("XXX", WheelItem.spinWheelAmount.ToString() ?? "").Replace("ZZZ", AKLFPGMDKLA.EHBBFMCILPC.DOFKEHNPCIJ.GALKFKBPLCK().ToString() ?? "");
			break;
		case PEOGABBHPNP.wofResourcesSp2:
			text = text.Replace("YYY", KBOJLHAJPCP.AENKOIILEFO).Replace("WWW", KBOJLHAJPCP.AENKOIILEFO).Replace("XXX", WheelItem.spinWheelAmount.ToString() ?? "").Replace("ZZZ", AKLFPGMDKLA.EHBBFMCILPC.PBEPCNFADAA.GALKFKBPLCK().ToString() ?? "");
			break;
		case PEOGABBHPNP.wofResourcesCard0:
			text2 = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("wofrewardmsgcard0");
			break;
		case PEOGABBHPNP.wofResourcesCard1:
			text2 = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("wofrewardmsgcard1");
			break;
		case PEOGABBHPNP.wofResourcesCard2:
			text2 = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("wofrewardmsgcard2");
			break;
		case PEOGABBHPNP.wofResourcesCard3:
			text2 = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("wofrewardmsgcard3");
			break;
		case PEOGABBHPNP.wofResourcesCard4:
			text2 = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("wofrewardmsgcard4");
			break;
		}
		if (text2.Length == 0)
		{
			if (peogabbhpnp == PEOGABBHPNP.wofResourcesGems && WheelItem.spinWheelRewardSubcategory == 1)
			{
				if (!GKJPOGNFKNK.AKJCGMFMGMK(WheelItem.spinWheelRewardSubcategoryValue))
				{
					base.StartCoroutine(this.CHHBMEHFIDJ());
				}
				else
				{
					this.GHPNAFIMKOA();
				}
			}
			else
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("congratstitle"), text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("collect"), new UnityAction(this.KFLIPKGBOBM), new UnityAction(this.KFLIPKGBOBM), DFGILFBGPLN.popupBonusUnlock, 0f, 28);
			}
		}
		else if (WheelItem.spinWheelCardIndex >= 0)
		{
			CLGFGOHBCGJ clgfgohbcgj = LJNMIPMNOKF.EHBBFMCILPC.KMDBNEFCPOH(WheelItem.spinWheelCardIndex);
			if (clgfgohbcgj != null)
			{
				text2 = text2.Replace("XXX", clgfgohbcgj.BPMFHNDCBOH);
				this.LGMCPCNCHPP(text2);
			}
			else
			{
				DPGJIJGOCIC.ANOPFDLPKGC("WheelItem.IssueRewards() - cardDesc is null.");
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("WheelItem.IssueRewards() - spinWheelCardIndex < 0");
		}
		yield break;
	}

	// Token: 0x06000A14 RID: 2580 RVA: 0x0004C204 File Offset: 0x0004A404
	private void GPJPHPHBJGL()
	{
		this.KAOPCAJLLPM = DNPIKPDMKKI.KHFPGNPNGEO(LJLAENEAOIM.liveOfferCardsVolSale);
		if (this.KAOPCAJLLPM != null && this.KAOPCAJLLPM.ONMADEIOOKN.ODBOJGMLKHA() > 806f)
		{
			this.increasedVolDropChances.SetActive(false);
			int num = this.KAOPCAJLLPM.JMHMNKGLAFC() + 1;
			this.increasedVolDropChancesText.text = (num.ToString() ?? "oldvhs");
			this.increasedVolDropChancesText.SetText(num.ToString() ?? ") is null.", true);
			return;
		}
		this.increasedVolDropChances.SetActive(false);
	}

	// Token: 0x06000A15 RID: 2581 RVA: 0x0004C29C File Offset: 0x0004A49C
	private void OAJDBPJBABO()
	{
		this.NPMNDNEDBGC++;
		if (this.NPMNDNEDBGC >= KBOJLHAJPCP.LPJOFEDNKHA)
		{
			CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
			CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.cdnActiv.ToString(), FFPHBMFGCNN.dldFail.ToString(), BGHLMGPPCNN.cdnWofToCrd.ToString(), false, false);
			this.NPMNDNEDBGC = 0;
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cdnerror"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("retry"), new UnityAction(this.ShowCardOptionsOrDownload), new UnityAction(this.HIODKHCOJOE), DFGILFBGPLN.popupCdnDownloadFailed, 0f, 28);
			return;
		}
		this.ShowCardOptionsOrDownload();
	}

	// Token: 0x06000A17 RID: 2583 RVA: 0x0004C3BE File Offset: 0x0004A5BE
	public void OnPurchasingViewLeave()
	{
		this.GMIPGNMGFPJ();
		this.MHMPFANBPOC();
		this.EAINMDCBPBC();
	}

	// Token: 0x06000A18 RID: 2584 RVA: 0x0004C3D2 File Offset: 0x0004A5D2
	public void OnPopupCardOptionsReopen()
	{
		if (PopupCardOptions.reopenCardOptionsFlag)
		{
			PopupCardOptions.reopenCardOptionsFlag = false;
			LJNMIPMNOKF.EHBBFMCILPC.DENIEGBICKJ();
			if (LJNMIPMNOKF.EHBBFMCILPC.JDDHHIOIAOJ() > 0)
			{
				this.ShowCardOptionsOrDownload();
			}
		}
	}

	// Token: 0x06000A19 RID: 2585 RVA: 0x0004C3FE File Offset: 0x0004A5FE
	private void JOFENHOACGG()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.DJLLDNNIMMK.MOBKGNBCIJF() <= 0 && !WheelItem.doubleOddsRequested)
		{
			this.BMBBLOBPPIB();
		}
		else
		{
			this.IECLGFPAGCD();
		}
		this.CJJDNIBFLJL();
	}

	// Token: 0x06000A1A RID: 2586 RVA: 0x0004C42D File Offset: 0x0004A62D
	public void OnPopupNotEnoughEnergyOrHardCurrencyGetMore()
	{
		PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager().Initialize();
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.OnPopupNotEnoughEnergyOrHardCurrencyGetMore2));
	}

	// Token: 0x06000A1B RID: 2587 RVA: 0x0004A136 File Offset: 0x00048336
	private void LGEBJPJLCPI()
	{
		this.EFDNHBCECGF(0);
	}

	// Token: 0x06000A1C RID: 2588 RVA: 0x0004C45C File Offset: 0x0004A65C
	private void FNFLDNADLDP()
	{
		this.CHEELBDINDH();
		this.wheelBlurAnimation.SetActive(true);
		this.starsAnimation.gameObject.SetActive(true);
		this.starsAnimation.enabled = true;
		this.selectorLightAnimation.gameObject.SetActive(false);
		this.GIKOPFCALGA = this.wheelAnimation.transform.DORotate(new Vector3(0f, 0f, -360f), this.EMIBOCJJLCH, RotateMode.FastBeyond360).SetEase(Ease.Linear).SetLoops(-1, LoopType.Incremental).OnKill(new TweenCallback(this.EHNECGHAKOL));
	}

	// Token: 0x06000A1D RID: 2589 RVA: 0x0004C4F8 File Offset: 0x0004A6F8
	private void EDDGNMCNGNG()
	{
		if (GKJPOGNFKNK.AKJCGMFMGMK(WheelItem.spinWheelRewardSubcategoryValue))
		{
			this.GHPNAFIMKOA();
			return;
		}
		base.StartCoroutine(this.CHHBMEHFIDJ());
	}

	// Token: 0x06000A1E RID: 2590 RVA: 0x0004C51C File Offset: 0x0004A71C
	public void PreCloseFocus()
	{
		base.transform.parent.GetComponent<CanvasGroup>().alpha = 0f;
		base.transform.parent.gameObject.SetActive(false);
		base.GetComponent<RectTransform>().localScale = this.PFEEFOKHKMP;
	}

	// Token: 0x06000A1F RID: 2591 RVA: 0x0004C56C File Offset: 0x0004A76C
	private void BOOEHHEIFJI()
	{
		bool flag = false;
		for (int i = 1; i < AKLFPGMDKLA.EHBBFMCILPC.BKADBDBHFCP.Count; i++)
		{
			if (i < KDCJJBLGCBH.EHBBFMCILPC.MCONOJKMHBE() && AKLFPGMDKLA.EHBBFMCILPC.BKADBDBHFCP[i] > 0)
			{
				flag = false;
			}
		}
		if (!flag)
		{
			this.guaranteedCardDropIconButton.SetActive(false);
			return;
		}
		this.guaranteedCardDropIconButton.SetActive(true);
	}

	// Token: 0x06000A20 RID: 2592 RVA: 0x0004C5D3 File Offset: 0x0004A7D3
	private IEnumerator MIAAILGJGGO()
	{
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().EPJKDCDOEMM(0);
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithProgress(96);
		yield return new WaitForSeconds(0.2f);
		while (AssetsManager.EHBBFMCILPC.IsBusy())
		{
			yield return new WaitForSeconds(0.05f);
		}
		AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleLiveProfileTheme, WheelItem.spinWheelRewardSubcategoryValue, -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().CLIOEOLFFLO(LEJKDNAGDHC.Fast);
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().GIJKJMMDJEL(0f, 1f);
		AssetsManager.EHBBFMCILPC.DownloadQueuedAssetBundles("OnLiveProfileThemeDownloadSuccess", "OnLiveProfileThemeDownloadFailed", false);
		yield break;
	}

	// Token: 0x06000A21 RID: 2593 RVA: 0x0004C5DB File Offset: 0x0004A7DB
	private void KBDAHECFAJM()
	{
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		this.CMDIKMNEGEN();
		this.ShowCardOptionsOrDownload();
	}

	// Token: 0x06000A22 RID: 2594 RVA: 0x0004C600 File Offset: 0x0004A800
	private void PNNIBEGIKDC(Button EKAPJKKPPGG, bool OJIDGNPCODM)
	{
		ColorBlock colors = EKAPJKKPPGG.colors;
		Color normalColor = colors.normalColor;
		Color disabledColor = colors.disabledColor;
		Image[] componentsInChildren = EKAPJKKPPGG.GetComponentsInChildren<Image>();
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			componentsInChildren[i].color = (OJIDGNPCODM ? normalColor : disabledColor);
		}
		TextMeshProUGUI[] componentsInChildren2 = EKAPJKKPPGG.GetComponentsInChildren<TextMeshProUGUI>();
		for (int i = 0; i < componentsInChildren2.Length; i++)
		{
			componentsInChildren2[i].color = (OJIDGNPCODM ? normalColor : disabledColor);
		}
		EKAPJKKPPGG.interactable = OJIDGNPCODM;
	}

	// Token: 0x06000A23 RID: 2595 RVA: 0x0004C680 File Offset: 0x0004A880
	private void NCHJNFKNGKC()
	{
		this.EFDNHBCECGF(1);
	}

	// Token: 0x06000A24 RID: 2596 RVA: 0x0004C5D3 File Offset: 0x0004A7D3
	private IEnumerator CHHBMEHFIDJ()
	{
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().EPJKDCDOEMM(0);
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithProgress(96);
		yield return new WaitForSeconds(0.2f);
		while (AssetsManager.EHBBFMCILPC.IsBusy())
		{
			yield return new WaitForSeconds(0.05f);
		}
		AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleLiveProfileTheme, WheelItem.spinWheelRewardSubcategoryValue, -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().CLIOEOLFFLO(LEJKDNAGDHC.Fast);
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().GIJKJMMDJEL(0f, 1f);
		AssetsManager.EHBBFMCILPC.DownloadQueuedAssetBundles("OnLiveProfileThemeDownloadSuccess", "OnLiveProfileThemeDownloadFailed", false);
		yield break;
	}

	// Token: 0x06000A25 RID: 2597 RVA: 0x0004C68C File Offset: 0x0004A88C
	public void JCHJEJOENJN()
	{
		if (!GKJPOGNFKNK.NLGDEEOPJAM(WheelItem.spinWheelCardIndex))
		{
			base.StartCoroutine(this.KDBPFGOBDCB());
			return;
		}
		AOBJLALDBAA.BIAEAOMHBMM().KGIKHEDLPND("", 1200f);
		LobbyUserInterface.EHBBFMCILPC.IIFDOEOBPCD(LJNMIPMNOKF.NMGMNAKLLMI().EBBLJMHNDKK(), null, HKPBEDBPHNJ.purchaseCardLobby, "abnap", null);
	}

	// Token: 0x06000A26 RID: 2598 RVA: 0x0004C6E4 File Offset: 0x0004A8E4
	public void FLBJOAFPPAK()
	{
		if (this.LGBIFDPMNIB == this.KFPMMNPNGHG)
		{
			return;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.ABGNIKKFFAC.PONAPMOOLIN() <= 1)
		{
			return;
		}
		this.KFPMMNPNGHG++;
		this.spinWheelEventTrigger.enabled = true;
		this.PLCCIKBHNCL(this.spinWheelButton, true);
		AKLFPGMDKLA.EHBBFMCILPC.ABGNIKKFFAC.NBPLKLNDCKM();
		this.GMIPGNMGFPJ();
		this.JEIALICFIOA();
	}

	// Token: 0x06000A27 RID: 2599 RVA: 0x00003E52 File Offset: 0x00002052
	public void OnSpinWheelClick()
	{
	}

	// Token: 0x06000A28 RID: 2600 RVA: 0x0004C755 File Offset: 0x0004A955
	private IEnumerator LDEGJJJAOOM()
	{
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().EPJKDCDOEMM(0);
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithProgress(96);
		yield return new WaitForSeconds(0.2f);
		AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleCutsceneView, -1, -1, FLDBFOADFLH.finishDownloadAndProceed, false, true, false, null, -1, false, "", false, false);
		AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleStoryAssetPack, this.BMODBEEEABE.OCPJHLCBIPB(), this.BMODBEEEABE.FECFDDGCPGB(), FLDBFOADFLH.finishDownloadAndProceed, false, true, false, null, -1, false, "", false, false);
		if (this.BMODBEEEABE.BEKNKDKEECD() >= 0 && this.BMODBEEEABE.BMPELDJNGLF() >= 0 && this.BMODBEEEABE.FONKDFDJFEL.Length > 0)
		{
			AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleStoryAssetPack, this.BMODBEEEABE.BEKNKDKEECD(), this.BMODBEEEABE.BMPELDJNGLF(), FLDBFOADFLH.finishDownloadAndProceed, true, true, false, null, -1, false, "", false, false);
		}
		if (this.BMODBEEEABE.EABCCNCDNCI() >= 0 && this.BMODBEEEABE.NIBFBJFMKBG() >= 0 && this.BMODBEEEABE.JLEAIJGBGHL.Length > 0)
		{
			AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleStoryAssetPack, this.BMODBEEEABE.EABCCNCDNCI(), this.BMODBEEEABE.NIBFBJFMKBG(), FLDBFOADFLH.finishDownloadAndProceed, true, true, false, null, -1, false, "", false, false);
		}
		if (this.BMODBEEEABE.OCNMOBKOPIJ() >= 0 && this.BMODBEEEABE.LHNIAKBBPDN() >= 0)
		{
			AssetsManager.EHBBFMCILPC.QueueAssetBundleDownloadNoSkip(NMKDCBPMCKI.AssetBundleStoryAssetPack, this.BMODBEEEABE.OCNMOBKOPIJ(), this.BMODBEEEABE.LHNIAKBBPDN(), FLDBFOADFLH.finishDownloadAndProceed, true, true, false, null, -1, "", false, KHPGPLAMAIN.HHDAPAJEIML());
		}
		AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleStoryAssetPackActivate, 0, 0, FLDBFOADFLH.finishDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().CLIOEOLFFLO(LEJKDNAGDHC.Fast);
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().GIJKJMMDJEL(0f, 1f);
		AssetsManager.EHBBFMCILPC.DownloadQueuedAssetBundles("OnCutsceneViewAssetsDownloadSuccess", "OnCutsceneViewAssetsDownloadFailed", false);
		yield break;
	}

	// Token: 0x06000A29 RID: 2601 RVA: 0x0004C764 File Offset: 0x0004A964
	private void IDEJMCAMIIA()
	{
		this.OKKBOFKILEA();
		this.ALGIAIKDEPH();
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnCutsceneViewShowWI", 0f);
		CommonUserInterface.EHBBFMCILPC.GetCutsceneViewManager().Show(this.BMODBEEEABE);
	}

	// Token: 0x06000A2A RID: 2602 RVA: 0x0004C79C File Offset: 0x0004A99C
	public void SendSpinWheelBackendRequest()
	{
		CommonUserInterface.EHBBFMCILPC.FreezeUX();
		BackendOperationsManager.EHBBFMCILPC.RequestSpinWheel(this.KAOPCAJLLPM, "OnBackendRequestSpinWheelSuccess", "OnBackendRequestSpinWheelException");
		if (AKLFPGMDKLA.EHBBFMCILPC.ABGNIKKFFAC.GALKFKBPLCK() <= KDCJJBLGCBH.EHBBFMCILPC.HLPACDMEKMK(ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass, true)))
		{
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.wofSpin.ToString(), FFPHBMFGCNN.wofFree.ToString(), "", false, false);
			return;
		}
		FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.wofSpin.ToString(), FFPHBMFGCNN.wofPaid.ToString(), "", false, false);
	}

	// Token: 0x06000A2B RID: 2603 RVA: 0x0004A95D File Offset: 0x00048B5D
	private IEnumerator IPEPOIPENKL()
	{
		AssetsManager.EHBBFMCILPC.InitializeAssetBundleFolder((LNDOOJOFFOM)this.BMODBEEEABE.FJFEPNKBELL, "OnCutsceneViewAssetBundleFolderInitializeSuccess", "OnCutsceneViewAssetsDownloadFailed");
		yield return null;
		yield break;
	}

	// Token: 0x06000A2C RID: 2604 RVA: 0x0004C854 File Offset: 0x0004AA54
	private void JECOBHGHNDJ()
	{
		CommonUserInterface.IKNOFBFMPGA().CEGLPJNLBHL(CCOJBMMKNAP.DBFFFOMCLKM().HIPJILDCHJC(" -"), CCOJBMMKNAP.OEPENBHJAHO().PPALCPINPLK("lrewsnap"), CCOJBMMKNAP.EHBBFMCILPC.PPALCPINPLK("deleteprofilebody"), new UnityAction(this.DJDHOAMAPMO), new UnityAction(this.KFLIPKGBOBM), (DFGILFBGPLN)(-2), 1469f, -115);
	}

	// Token: 0x06000A2D RID: 2605 RVA: 0x0004C8BA File Offset: 0x0004AABA
	private void CMDIKMNEGEN()
	{
		this.NPMNDNEDBGC = 0;
	}

	// Token: 0x06000A2E RID: 2606 RVA: 0x0004C8C3 File Offset: 0x0004AAC3
	private IEnumerator PMGGOFPKIPP()
	{
		yield return new WaitForSeconds(1f);
		CommonUserInterface.EHBBFMCILPC.ResumeUX();
		this.OnIncreasedVolDropChancesClick();
		yield break;
	}

	// Token: 0x06000A2F RID: 2607 RVA: 0x0004C8D4 File Offset: 0x0004AAD4
	private void OKKBOFKILEA()
	{
		for (int i = 0; i < this.lobbyCameras.Count; i++)
		{
			this.lobbyCameras[i].enabled = false;
		}
	}

	// Token: 0x06000A30 RID: 2608 RVA: 0x0004C90C File Offset: 0x0004AB0C
	private void NEEAJEKFGOJ()
	{
		this.starsAnimation.enabled = true;
		this.starsAnimation.GetComponent<Image>().DOFade(288f, 1136f).OnComplete(new TweenCallback(this.KMJACHFHGAP));
		this.selectorLightAnimation.gameObject.SetActive(false);
		this.CELEKHKIJIK();
	}

	// Token: 0x06000A31 RID: 2609 RVA: 0x0004C968 File Offset: 0x0004AB68
	public void HKACMLGLJAL(int MBBNGLEIOPA)
	{
		string text = CCOJBMMKNAP.APGODIBBPOD().HIPJILDCHJC("OnSaveSlotDuplicateRequested" + MBBNGLEIOPA.ToString() + ", anthologies ");
		text = text.Replace("coll2", AKLFMGKJLJN.IFDLAMLHKIJ().NFKGNJCHGBD((PEOGABBHPNP)MBBNGLEIOPA, AKLFPGMDKLA.EHBBFMCILPC.DJLLDNNIMMK.DPLHPBMJAPJ() <= 1 && WheelItem.doubleOddsRequested).ToString("firstAnthologyStoryIndexCache.json") + "fdst");
		CommonUserInterface.EHBBFMCILPC.NFBMHHPIGFA(CCOJBMMKNAP.KFAABHHGOPO().FIENAKIHNOM("p"), text, CCOJBMMKNAP.HEDIEIICOOG().PKNHKGMNCIP("OnOnDemandResourcesDownloadSuccess"), (DFGILFBGPLN)(-94), 1503f, -59);
	}

	// Token: 0x06000A32 RID: 2610 RVA: 0x00049CA5 File Offset: 0x00047EA5
	private void FJEIBFKABCH()
	{
		this.FJPBIMENNKD();
		this.PNNIBEGIKDC(this.doubleCardsOddsButton, false);
	}

	// Token: 0x06000A33 RID: 2611 RVA: 0x0004CA14 File Offset: 0x0004AC14
	public void OnGuaranteedCardDropIconClick()
	{
		string dpjinbcgngn = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("guaranteedcarddrophint").Replace("XXX", KDCJJBLGCBH.EHBBFMCILPC.MCONOJKMHBE().ToString() ?? "");
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), dpjinbcgngn, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
	}

	// Token: 0x06000A34 RID: 2612 RVA: 0x0004CA8C File Offset: 0x0004AC8C
	private void OnDestroy()
	{
		try
		{
			FADIGFEOCND.BGMALDJFMKE(this.PHMIBKAJKMB);
			if (null != this.starsAnimation)
			{
				if (null != this.starsAnimation.GetComponent<Image>())
				{
					this.starsAnimation.GetComponent<Image>().sprite = null;
				}
				this.starsAnimation.framesSD = null;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000A35 RID: 2613 RVA: 0x0004CAFC File Offset: 0x0004ACFC
	private void FPGHHLJIFIE()
	{
		this.NPMNDNEDBGC += 0;
		if (this.NPMNDNEDBGC >= KBOJLHAJPCP.LPJOFEDNKHA)
		{
			CommonUserInterface.IKNOFBFMPGA().HideConnectingAnimation();
			CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
			FirebaseAnalyticsManager.EHBBFMCILPC.LMCJKLHOHJC(true, AGEHCPDNBFD.techDef.ToString(), FFPHBMFGCNN.frRequestPID.ToString(), ((BGHLMGPPCNN)(-62)).ToString(), false, false);
			this.NPMNDNEDBGC = 1;
			CommonUserInterface.IKNOFBFMPGA().JJPNFAAPFBI(CCOJBMMKNAP.CEGAOMEEFBE().FIENAKIHNOM("importanttitle"), CCOJBMMKNAP.NIOJNOFGIJO().OHLNGCKIACD("i"), CCOJBMMKNAP.ILACPHFEDEP().PPALCPINPLK("onThemeChange"), new UnityAction(this.ShowCardOptionsOrDownload), new UnityAction(this.HIODKHCOJOE), DFGILFBGPLN.screenStory, 1301f, -29);
			return;
		}
		this.ShowCardOptionsOrDownload();
	}

	// Token: 0x06000A36 RID: 2614 RVA: 0x0004CBDE File Offset: 0x0004ADDE
	public void OnSpinWheelButtonPointerDown()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.ABGNIKKFFAC.GALKFKBPLCK() <= 0)
		{
			this.OnPurchaseSpinsClick();
			return;
		}
		if (this.LGBIFDPMNIB > this.KFPMMNPNGHG)
		{
			return;
		}
		this.LGBIFDPMNIB++;
		this.FNFLDNADLDP();
	}

	// Token: 0x06000A37 RID: 2615 RVA: 0x0004CC1C File Offset: 0x0004AE1C
	private IEnumerator FLDAMFANFCL()
	{
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().EPJKDCDOEMM(0);
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithProgress(96);
		yield return new WaitForSeconds(0.2f);
		int mefkfohcohk = WheelItem.spinWheelCardIndex;
		int num = GKJPOGNFKNK.IDKIIANDMPM(WheelItem.spinWheelCardIndex);
		if (num >= 0)
		{
			mefkfohcohk = num;
		}
		AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleCollectableCard, mefkfohcohk, -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().CLIOEOLFFLO(LEJKDNAGDHC.Fast);
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().GIJKJMMDJEL(0f, 1f);
		AssetsManager.EHBBFMCILPC.DownloadQueuedAssetBundles("OnAllCollectableCardsDownloadSuccess", "OnAllCollectableCardsDownloadFailed", false);
		yield break;
	}

	// Token: 0x06000A38 RID: 2616 RVA: 0x0004B580 File Offset: 0x00049780
	private void HBHEGKNIHJD()
	{
		if (GKJPOGNFKNK.AKJCGMFMGMK(WheelItem.spinWheelRewardSubcategoryValue))
		{
			this.GHPNAFIMKOA();
			return;
		}
		base.StartCoroutine(this.MIAAILGJGGO());
	}

	// Token: 0x040002D2 RID: 722
	[SerializeField]
	private TextMeshProUGUI wofResourcesGems;

	// Token: 0x040002D3 RID: 723
	[SerializeField]
	private TextMeshProUGUI wofResourcesTea;

	// Token: 0x040002D4 RID: 724
	[SerializeField]
	private TextMeshProUGUI wofResourcesSp0;

	// Token: 0x040002D5 RID: 725
	[SerializeField]
	private TextMeshProUGUI wofResourcesSp1;

	// Token: 0x040002D6 RID: 726
	[SerializeField]
	private TextMeshProUGUI wofResourcesSp2;

	// Token: 0x040002D7 RID: 727
	[SerializeField]
	private TextMeshProUGUI wofResourcesCard0;

	// Token: 0x040002D8 RID: 728
	[SerializeField]
	private GameObject wofResourcesCard0ActiveNumberImage;

	// Token: 0x040002D9 RID: 729
	[SerializeField]
	private TextMeshProUGUI wofResourcesCard0ActiveNumberText;

	// Token: 0x040002DA RID: 730
	[SerializeField]
	private TextMeshProUGUI wofResourcesCard1;

	// Token: 0x040002DB RID: 731
	[SerializeField]
	private GameObject wofResourcesCard1ActiveNumberImage;

	// Token: 0x040002DC RID: 732
	[SerializeField]
	private TextMeshProUGUI wofResourcesCard1ActiveNumberText;

	// Token: 0x040002DD RID: 733
	[SerializeField]
	private TextMeshProUGUI wofResourcesCard2;

	// Token: 0x040002DE RID: 734
	[SerializeField]
	private GameObject wofResourcesCard2ActiveNumberImage;

	// Token: 0x040002DF RID: 735
	[SerializeField]
	private TextMeshProUGUI wofResourcesCard2ActiveNumberText;

	// Token: 0x040002E0 RID: 736
	[SerializeField]
	private TextMeshProUGUI wofResourcesCard3;

	// Token: 0x040002E1 RID: 737
	[SerializeField]
	private GameObject wofResourcesCard3ActiveNumberImage;

	// Token: 0x040002E2 RID: 738
	[SerializeField]
	private TextMeshProUGUI wofResourcesCard3ActiveNumberText;

	// Token: 0x040002E3 RID: 739
	[SerializeField]
	private TextMeshProUGUI wofResourcesCard4;

	// Token: 0x040002E4 RID: 740
	[SerializeField]
	private GameObject wofResourcesCard4ActiveNumberImage;

	// Token: 0x040002E5 RID: 741
	[SerializeField]
	private TextMeshProUGUI wofResourcesCard4ActiveNumberText;

	// Token: 0x040002E6 RID: 742
	[SerializeField]
	private TextMeshProUGUI spinsText;

	// Token: 0x040002E7 RID: 743
	[SerializeField]
	private TextMeshProUGUI timerText;

	// Token: 0x040002E8 RID: 744
	[SerializeField]
	private GameObject doubleOddsIconButton;

	// Token: 0x040002E9 RID: 745
	[SerializeField]
	private GameObject wheelAnimation;

	// Token: 0x040002EA RID: 746
	[SerializeField]
	private GameObject wheelBlurAnimation;

	// Token: 0x040002EB RID: 747
	[SerializeField]
	private Image selectorLightAnimation;

	// Token: 0x040002EC RID: 748
	[SerializeField]
	private ImageFrameAnimation starsAnimation;

	// Token: 0x040002ED RID: 749
	[SerializeField]
	private TextMeshProUGUI spinWheelText;

	// Token: 0x040002EE RID: 750
	[SerializeField]
	private Button spinWheelButton;

	// Token: 0x040002EF RID: 751
	[SerializeField]
	private EventTrigger spinWheelEventTrigger;

	// Token: 0x040002F0 RID: 752
	[SerializeField]
	private TextMeshProUGUI doubleCardsOddsText;

	// Token: 0x040002F1 RID: 753
	[SerializeField]
	private Button doubleCardsOddsButton;

	// Token: 0x040002F2 RID: 754
	[SerializeField]
	private GameObject guaranteedCardDropIconButton;

	// Token: 0x040002F3 RID: 755
	[SerializeField]
	private TextMeshProUGUI doubleCardsOddsTitle;

	// Token: 0x040002F4 RID: 756
	[SerializeField]
	private GameObject increasedVolDropChances;

	// Token: 0x040002F5 RID: 757
	[SerializeField]
	private TextMeshProUGUI increasedVolDropChancesText;

	// Token: 0x040002F6 RID: 758
	private int LGBIFDPMNIB;

	// Token: 0x040002F7 RID: 759
	private int KFPMMNPNGHG;

	// Token: 0x040002F8 RID: 760
	private Tween GIKOPFCALGA;

	// Token: 0x040002F9 RID: 761
	private float EMIBOCJJLCH = 0.8f;

	// Token: 0x040002FA RID: 762
	private int HIDJGIMJFML;

	// Token: 0x040002FB RID: 763
	private Dictionary<PEOGABBHPNP, int> HJPKJDHKJMO;

	// Token: 0x040002FC RID: 764
	private Vector3 PFEEFOKHKMP;

	// Token: 0x040002FD RID: 765
	public List<GameObject> increaseDropChancesIcons = new List<GameObject>();

	// Token: 0x040002FE RID: 766
	public List<Canvas> lobbyCanvases = new List<Canvas>();

	// Token: 0x040002FF RID: 767
	public List<Camera> lobbyCameras = new List<Camera>();

	// Token: 0x04000300 RID: 768
	public const string onBackendRequestSpinWheelSuccess = "OnBackendRequestSpinWheelSuccess";

	// Token: 0x04000301 RID: 769
	public const string onBackendRequestSpinWheelException = "OnBackendRequestSpinWheelException";

	// Token: 0x04000302 RID: 770
	public const string onSpinsUnlockContinueToPurchasingScreen = "OnSpinsUnlockContinueToPurchasingScreen";

	// Token: 0x04000303 RID: 771
	private const string PBICPKIPJMJ = "OnAllCollectableCardsDownloadSuccess";

	// Token: 0x04000304 RID: 772
	private const string NAIGDEKIDHA = "OnAllCollectableCardsDownloadFailed";

	// Token: 0x04000305 RID: 773
	private const string JJMNCIKONOM = "OnCutsceneViewAssetBundleFolderInitializeSuccess";

	// Token: 0x04000306 RID: 774
	private const string IGGENJIOFFH = "OnCutsceneViewAssetsDownloadSuccess";

	// Token: 0x04000307 RID: 775
	private const string DCFCMEIGOKC = "OnCutsceneViewAssetsDownloadFailed";

	// Token: 0x04000308 RID: 776
	private const string NCEOHIKOOLO = "OnLiveProfileThemeDownloadSuccess";

	// Token: 0x04000309 RID: 777
	private const string PFIEINJBHLD = "OnLiveProfileThemeDownloadFailed";

	// Token: 0x0400030A RID: 778
	public const string onCutsceneViewShowWI = "OnCutsceneViewShowWI";

	// Token: 0x0400030B RID: 779
	public static int spinWheelResult = 0;

	// Token: 0x0400030C RID: 780
	public static int spinWheelReward = 0;

	// Token: 0x0400030D RID: 781
	public static int spinWheelAmount = 1;

	// Token: 0x0400030E RID: 782
	public static int spinWheelCardIndex = -1;

	// Token: 0x0400030F RID: 783
	public static int spinsFireTime = 1000000;

	// Token: 0x04000310 RID: 784
	public static int spinWheelRewardSubcategory = 0;

	// Token: 0x04000311 RID: 785
	public static int spinWheelRewardSubcategoryValue = 0;

	// Token: 0x04000312 RID: 786
	private FADIGFEOCND PHMIBKAJKMB;

	// Token: 0x04000313 RID: 787
	private int JEKBNMGOLEK;

	// Token: 0x04000314 RID: 788
	public static bool doubleOddsRequested = false;

	// Token: 0x04000315 RID: 789
	private int NPMNDNEDBGC;

	// Token: 0x04000316 RID: 790
	private BNFCLKNDBLO BMODBEEEABE;

	// Token: 0x04000317 RID: 791
	private bool JDPLEJELPNF;

	// Token: 0x04000318 RID: 792
	private GDOKLFCLLIK KAOPCAJLLPM;

	// Token: 0x04000319 RID: 793
	private static float CBOKJGNCEKE = 1f;

	// Token: 0x0400031A RID: 794
	private float CPGLEJIBNEP;
}
