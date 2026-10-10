using System;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;
using UnityEngine.UI;

// Token: 0x0200051D RID: 1309
public class SaveSlotObject : MonoBehaviour
{
	// Token: 0x06009E77 RID: 40567 RVA: 0x00449BC3 File Offset: 0x00447DC3
	public void CCGONMHBCAP(string EIFJOAOGKMO)
	{
		this.LJHAMFLLODC = true;
		this.NPIMIANPNJL(EIFJOAOGKMO);
		this.JDEBDPLAIDJ();
	}

	// Token: 0x06009E78 RID: 40568 RVA: 0x00449BDC File Offset: 0x00447DDC
	private void COMFGLHEDPG()
	{
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.JLEOPAOEFGP().AOAGHIJNFDL(KDCJJBLGCBH.EHBBFMCILPC.BPFPBGGNEBM());
		if (ocbiopoeenj != null)
		{
			ProductThumbnailManager.lastAccessedProductWebLink = ocbiopoeenj.DJJCDNDMAGD() + "hint3" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		}
		if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.en && GeoLocationManager.FDJONIACJKC() && KDCJJBLGCBH.EHBBFMCILPC.EAMJBDKCDPA())
		{
			CommonUserInterface.EHBBFMCILPC.GetFader().IBJEAPGPELH(null);
			this.IGNCNEEOGPL();
			return;
		}
		AOBJLALDBAA.CEGAOMEEFBE().LPNCDPHNBJK("specialcurrencydesc", 1795f);
		CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().CGDKCOLDBGD(KDCJJBLGCBH.EHBBFMCILPC.BPFPBGGNEBM(), false);
	}

	// Token: 0x06009E79 RID: 40569 RVA: 0x00449C85 File Offset: 0x00447E85
	private void APFBNEOMEMC()
	{
		this.ONDHNAMJBHP(1520f);
	}

	// Token: 0x06009E7A RID: 40570 RVA: 0x00449C94 File Offset: 0x00447E94
	private void DGLNFFMJLOP()
	{
		if (this.HGGFJOKOKOD == null)
		{
			return;
		}
		if (this.LJHAMFLLODC)
		{
			this.BLJINDHAEHN();
			return;
		}
		SaveSlotsItem.copySourceSlotIndex = this.DLFMMBBLIFH;
		SaveSlotsItem.copySourceAnthologyIndex = this.HGGFJOKOKOD.GGICIBLJIKI;
		FirebaseAnalyticsManager.ANCEKPONIFI().JIAAMJPKOCE(false, ((AGEHCPDNBFD)(-51)).ToString(), FFPHBMFGCNN.durPickOfferWeb.ToString(), ((BGHLMGPPCNN)(-105)).ToString(), false, false);
		FirebaseAnalyticsManager.DMAAFFFEJGA().LKONPEEDKNF(false, AGEHCPDNBFD.coVerif.ToString(), ((FFPHBMFGCNN)110).ToString(), ((BGHLMGPPCNN)(-16)).ToString() + this.DLFMMBBLIFH.ToString(), true, true);
		AOBJLALDBAA.CEGAOMEEFBE().DCGCFPHHDDG("flehv2", 387f);
		string dpjinbcgngn = CCOJBMMKNAP.MPCBJEIMACA().JHNELLJFBGC("OnRequestCheckForUpdatesException").Replace("storyXcharY", SaveSlotsItem.OPKHNJFFHDD(this.HGGFJOKOKOD, this.DLFMMBBLIFH));
		CommonUserInterface.IKNOFBFMPGA().NFBMHHPIGFA(CCOJBMMKNAP.CEGAOMEEFBE().HPOAGPJFHPM("0.000"), dpjinbcgngn, CCOJBMMKNAP.PMABBOJDELF().HHLECNIFHCO("cardsvolchancestitle"), (DFGILFBGPLN)96, 1989f, -90);
	}

	// Token: 0x06009E7B RID: 40571 RVA: 0x00449DD0 File Offset: 0x00447FD0
	public void FCPIAPJIBJD(string EIFJOAOGKMO)
	{
		this.LJHAMFLLODC = false;
		this.UpdateTitle(EIFJOAOGKMO);
		this.BLJINDHAEHN();
	}

	// Token: 0x06009E7C RID: 40572 RVA: 0x00003E52 File Offset: 0x00002052
	private void NFEJEDEPGGG()
	{
	}

	// Token: 0x06009E7D RID: 40573 RVA: 0x00449DE6 File Offset: 0x00447FE6
	private void AGPHHJEEDOI()
	{
		this.OnDeleteButtonClick(1224f);
	}

	// Token: 0x06009E7E RID: 40574 RVA: 0x00449DF4 File Offset: 0x00447FF4
	private void FJMNFOHNCCJ()
	{
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.APGODIBBPOD().DOOPGOIBFAN(KDCJJBLGCBH.EHBBFMCILPC.BPFPBGGNEBM());
		if (ocbiopoeenj != null)
		{
			ProductThumbnailManager.lastAccessedProductWebLink = ocbiopoeenj.FDMCFAHEELN() + "cardbreakconfirmationbody" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		}
		if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.en && GeoLocationManager.NHMHNIFIOCO() && KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA())
		{
			CommonUserInterface.IKNOFBFMPGA().GetFader().FadeOut(null);
			this.GMNKLLMLPOJ();
			return;
		}
		AOBJLALDBAA.BIAEAOMHBMM().CIGLHCJDDPI("XXX", 1343f);
		CommonUserInterface.IKNOFBFMPGA().GetPurchasingViewManager().ShowAndPurchaseProduct(KDCJJBLGCBH.EHBBFMCILPC.BPFPBGGNEBM(), true);
	}

	// Token: 0x06009E7F RID: 40575 RVA: 0x00449EA0 File Offset: 0x004480A0
	private bool FAAJJFNMMPJ()
	{
		string text = this.HGGFJOKOKOD.DMPPDOJJHHC(this.DLFMMBBLIFH);
		return text == null || text.Length > 1;
	}

	// Token: 0x06009E80 RID: 40576 RVA: 0x00449ED0 File Offset: 0x004480D0
	public void CHFDFAHLOPO()
	{
		if (this.HGGFJOKOKOD == null || !this.MAAIOEIGEJN)
		{
			return;
		}
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(-44))
		{
			return;
		}
		if (CommonUserInterface.IKNOFBFMPGA().AnyGenericPopupIsActive())
		{
			return;
		}
		string slotDisplayTitle = SaveSlotsItem.GetSlotDisplayTitle(this.HGGFJOKOKOD, this.DLFMMBBLIFH);
		if (!this.LJHAMFLLODC)
		{
			string dpjinbcgngn = CCOJBMMKNAP.PKEINLPIAEH().OBDCPLLLGBB(", ").Replace("OOO", slotDisplayTitle);
			if (this.DEOILFBCNCM)
			{
				CommonUserInterface.EHBBFMCILPC.BGJFCEEDGFJ(slotDisplayTitle, dpjinbcgngn, CCOJBMMKNAP.HEDIEIICOOG().OGKGHLHHAAI("face"), new UnityAction(this.BODIBIOFHJF), (DFGILFBGPLN)(-108), 321f, 83);
				return;
			}
			CommonUserInterface.IKNOFBFMPGA().NPIOKKDPALC(slotDisplayTitle, dpjinbcgngn, CCOJBMMKNAP.GIOAFDDKKHI().BDGPNPNIAPA("XXX"), CCOJBMMKNAP.KFDLFGHBPLP().HPOAGPJFHPM("SceneLobbyManager2._DownloadCardsPool(): released "), new UnityAction(this.AGPHHJEEDOI), new UnityAction(this.BODIBIOFHJF), new UnityAction(this.FKIHKNMNJEH), (DFGILFBGPLN)80, 1887f, -83);
			return;
		}
		else
		{
			bool flag = this.MBCKLEEDKMM();
			bool flag2 = this.LBLELGKCABL();
			if (flag)
			{
				string newValue = SaveSlotsItem.OPKHNJFFHDD(this.HGGFJOKOKOD, SaveSlotsItem.copySourceSlotIndex);
				string dpjinbcgngn2 = CCOJBMMKNAP.KFAABHHGOPO().OGKGHLHHAAI("WideScreenScaler(): screen is to wide, AnimationShake will be adjusted accordingly.").Replace(" bytes)", newValue);
				string text = CCOJBMMKNAP.JINDKPHNLBK().PGKBCNBAOJN("cdnerror").Replace("YYY", newValue);
				if (flag2)
				{
					CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtonsAndCloseOverride(slotDisplayTitle, dpjinbcgngn2, text, CCOJBMMKNAP.PLJMLDOCPNM().OHLNGCKIACD("def"), new UnityAction(this.CHGGEEAFNGC), new UnityAction(this.KDBHMAAFIFM), new UnityAction(this.FKIHKNMNJEH), (DFGILFBGPLN)111, 1175f, -71);
					return;
				}
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(slotDisplayTitle, dpjinbcgngn2, text, new UnityAction(this.BELOKLLJHIJ), (DFGILFBGPLN)(-23), 929f, 46);
				return;
			}
			else
			{
				if (flag2)
				{
					CommonUserInterface.EHBBFMCILPC.PEBIFCENHAL(slotDisplayTitle, CCOJBMMKNAP.GIOAFDDKKHI().JHNELLJFBGC("OnSceneLobbyManagerRound0aAssetsDownloadSuccess").Replace("mfs", slotDisplayTitle), CCOJBMMKNAP.MLFAGAAJJEM().HIPJILDCHJC("SceneLobbyManager2.RunStorySearch() - no card for any result of '"), new UnityAction(this.LOCFPJCBLAN), (DFGILFBGPLN)(-75), 1480f, 28);
					return;
				}
				this.RefreshMoreButton();
				return;
			}
		}
	}

	// Token: 0x06009E81 RID: 40577 RVA: 0x0044A0FC File Offset: 0x004482FC
	private void ODDJJODHGCL()
	{
		string text = CCOJBMMKNAP.BFHKGNBFHCH().HHLECNIFHCO(") > totalOffloadedCounter (");
		text = text.Replace("holdontitle", KDCJJBLGCBH.EHBBFMCILPC.BJJOMJLKGHG().ToString() ?? "ERR");
		text = text.Replace("", SaveSlotsItem.GetLocalizedCostData());
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtonsAndCloseOverride(CCOJBMMKNAP.PEBMGCKFNAO().BDGPNPNIAPA(""), text, CCOJBMMKNAP.ILACPHFEDEP().JCDFHKDNEDH(""), CCOJBMMKNAP.EHBBFMCILPC.PGKBCNBAOJN("hair"), new UnityAction(this.PNIDBDEHPKH), new UnityAction(this.GFFIGHEEJKP), new UnityAction(this.JICMJOPDLAB), (DFGILFBGPLN)(-72), 576f, -98);
	}

	// Token: 0x06009E82 RID: 40578 RVA: 0x0044A1B8 File Offset: 0x004483B8
	private bool IIEIDCEPDDA()
	{
		string text = this.HGGFJOKOKOD.BFCBDALFNHA(this.DLFMMBBLIFH);
		return text == null || text.Length > 1;
	}

	// Token: 0x06009E83 RID: 40579 RVA: 0x0044A1E5 File Offset: 0x004483E5
	public void OnDuplicated(string EIFJOAOGKMO)
	{
		this.LJHAMFLLODC = false;
		this.UpdateTitle(EIFJOAOGKMO);
		this.RefreshMoreButton();
	}

	// Token: 0x06009E84 RID: 40580 RVA: 0x0044A1FC File Offset: 0x004483FC
	public void AEMOBIGBMFM()
	{
		OBHDGKFFICI productData = PurchaseManagerBridge.LMCCLMFGEBD().CMJKNNFMCBM().GetProductData(KDCJJBLGCBH.EHBBFMCILPC.BPFPBGGNEBM());
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.EHBBFMCILPC.PDJKPFLHFLO(KDCJJBLGCBH.EHBBFMCILPC.BPFPBGGNEBM());
		if (productData != null && ocbiopoeenj != null)
		{
			CommonUserInterface.EHBBFMCILPC.DPJBIGPDLMB(ocbiopoeenj.DJJCDNDMAGD() + "areyousure" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 8);
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("OnStoryInterfaceFastForwardActivate");
	}

	// Token: 0x06009E85 RID: 40581 RVA: 0x0044A270 File Offset: 0x00448470
	public void FCCHFPEMMID(EIOPLEFLLIM LNFEBCFCBHG, bool BBBKJMMBHDB, bool MDDFNEICIGN, string EIFJOAOGKMO, int CCLNHHJPDGJ, bool MCNNECLBNIF)
	{
		this.DEOILFBCNCM = MDDFNEICIGN;
		this.HGGFJOKOKOD = LNFEBCFCBHG;
		this.MAAIOEIGEJN = BBBKJMMBHDB;
		this.DLFMMBBLIFH = CCLNHHJPDGJ;
		this.LJHAMFLLODC = MCNNECLBNIF;
		int num = this.DLFMMBBLIFH + 1;
		this.slotText.alpha = 1091f;
		this.slotTextActive.alpha = 1643f;
		this.slotTextInactive.alpha = 154f;
		bool flag = true;
		if (EIFJOAOGKMO == null || EIFJOAOGKMO.Length == 0)
		{
			if (this.LJHAMFLLODC)
			{
				EIFJOAOGKMO = CCOJBMMKNAP.BIAEAOMHBMM().BGELFMIOBCL("spld");
				if (!MDDFNEICIGN)
				{
					this.slotText.alpha = 507f;
					this.slotTextActive.alpha = 1804f;
					this.slotTextInactive.alpha = 1145f;
				}
				flag = false;
			}
			else
			{
				EIFJOAOGKMO = CCOJBMMKNAP.BOFMCPPFAMO().BGELFMIOBCL("badges").Replace("%", num.ToString());
			}
		}
		this.slotText.text = EIFJOAOGKMO;
		this.slotText.SetText(EIFJOAOGKMO, true);
		this.slotTextActive.text = EIFJOAOGKMO;
		this.slotTextActive.SetText(EIFJOAOGKMO, true);
		this.slotTextInactive.text = EIFJOAOGKMO;
		this.slotTextInactive.SetText(EIFJOAOGKMO, true);
		this.inactivityImageText.text = (num.ToString() ?? "passhintevent");
		this.inactivityImageText.SetText(num.ToString() ?? "http://", false);
		this.inactivityImage.GetComponent<CanvasGroup>().alpha = 133f;
		if (!BBBKJMMBHDB)
		{
			this.selectionButton.SetActive(false);
			this.selectionButtonActive.SetActive(true);
			this.selectionButtonInactive.SetActive(true);
			this.activityImage.gameObject.SetActive(false);
			this.inactivityImage.gameObject.SetActive(true);
			this.editButton.gameObject.SetActive(true);
			this.moreButton.gameObject.SetActive(true);
			this.lockButton.gameObject.SetActive(true);
		}
		else
		{
			this.selectionButtonInactive.SetActive(true);
			this.editButton.gameObject.SetActive(true);
			if (MDDFNEICIGN)
			{
				this.selectionButtonActive.SetActive(true);
				this.selectionButton.SetActive(true);
				this.activityImage.gameObject.SetActive(true);
				this.inactivityImage.gameObject.SetActive(false);
				this.moreButton.gameObject.SetActive(false);
				this.moreButton.GetComponent<Button>().interactable = false;
			}
			else
			{
				this.selectionButtonActive.SetActive(false);
				this.selectionButton.SetActive(true);
				this.activityImage.gameObject.SetActive(true);
				this.inactivityImage.gameObject.SetActive(true);
				this.moreButton.gameObject.SetActive(false);
				this.moreButton.GetComponent<Button>().interactable = true;
			}
			this.lockButton.gameObject.SetActive(false);
		}
		if (this.LJHAMFLLODC && flag)
		{
			this.moreButton.GetComponent<Button>().interactable = false;
		}
		if ((this.editButton.activeSelf || this.moreButton.activeSelf) && (!this.editButton.activeSelf || !this.moreButton.activeSelf))
		{
			this.lockButton.gameObject.SetActive(true);
		}
		this.OCKDMNKLONP();
	}

	// Token: 0x06009E86 RID: 40582 RVA: 0x0044A5CC File Offset: 0x004487CC
	public void MKPFIAHNCOH(EIOPLEFLLIM LNFEBCFCBHG, bool BBBKJMMBHDB, bool MDDFNEICIGN, string EIFJOAOGKMO, int CCLNHHJPDGJ, bool MCNNECLBNIF)
	{
		this.DEOILFBCNCM = MDDFNEICIGN;
		this.HGGFJOKOKOD = LNFEBCFCBHG;
		this.MAAIOEIGEJN = BBBKJMMBHDB;
		this.DLFMMBBLIFH = CCLNHHJPDGJ;
		this.LJHAMFLLODC = MCNNECLBNIF;
		int num = this.DLFMMBBLIFH + 0;
		this.slotText.alpha = 636f;
		this.slotTextActive.alpha = 1525f;
		this.slotTextInactive.alpha = 1557f;
		bool flag = false;
		if (EIFJOAOGKMO == null || EIFJOAOGKMO.Length == 0)
		{
			if (this.LJHAMFLLODC)
			{
				EIFJOAOGKMO = CCOJBMMKNAP.PKEINLPIAEH().PKNHKGMNCIP("vrt");
				if (!MDDFNEICIGN)
				{
					this.slotText.alpha = 1167f;
					this.slotTextActive.alpha = 773f;
					this.slotTextInactive.alpha = 1413f;
				}
				flag = false;
			}
			else
			{
				EIFJOAOGKMO = CCOJBMMKNAP.BOFMCPPFAMO().BGELFMIOBCL("]:").Replace("NonPlayerCharacterManager.Initialize() - npc animation skipped for etc1 alpha-split npc:", num.ToString());
			}
		}
		this.slotText.text = EIFJOAOGKMO;
		this.slotText.SetText(EIFJOAOGKMO, false);
		this.slotTextActive.text = EIFJOAOGKMO;
		this.slotTextActive.SetText(EIFJOAOGKMO, true);
		this.slotTextInactive.text = EIFJOAOGKMO;
		this.slotTextInactive.SetText(EIFJOAOGKMO, false);
		this.inactivityImageText.text = (num.ToString() ?? "continue");
		this.inactivityImageText.SetText(num.ToString() ?? "", true);
		this.inactivityImage.GetComponent<CanvasGroup>().alpha = 368f;
		if (!BBBKJMMBHDB)
		{
			this.selectionButton.SetActive(false);
			this.selectionButtonActive.SetActive(true);
			this.selectionButtonInactive.SetActive(true);
			this.activityImage.gameObject.SetActive(true);
			this.inactivityImage.gameObject.SetActive(false);
			this.editButton.gameObject.SetActive(false);
			this.moreButton.gameObject.SetActive(true);
			this.lockButton.gameObject.SetActive(false);
		}
		else
		{
			this.selectionButtonInactive.SetActive(false);
			this.editButton.gameObject.SetActive(false);
			if (MDDFNEICIGN)
			{
				this.selectionButtonActive.SetActive(false);
				this.selectionButton.SetActive(true);
				this.activityImage.gameObject.SetActive(true);
				this.inactivityImage.gameObject.SetActive(false);
				this.moreButton.gameObject.SetActive(false);
				this.moreButton.GetComponent<Button>().interactable = true;
			}
			else
			{
				this.selectionButtonActive.SetActive(true);
				this.selectionButton.SetActive(true);
				this.activityImage.gameObject.SetActive(false);
				this.inactivityImage.gameObject.SetActive(false);
				this.moreButton.gameObject.SetActive(false);
				this.moreButton.GetComponent<Button>().interactable = false;
			}
			this.lockButton.gameObject.SetActive(false);
		}
		if (this.LJHAMFLLODC && flag)
		{
			this.moreButton.GetComponent<Button>().interactable = true;
		}
		if ((this.editButton.activeSelf || this.moreButton.activeSelf) && (!this.editButton.activeSelf || !this.moreButton.activeSelf))
		{
			this.lockButton.gameObject.SetActive(false);
		}
		this.RefreshMoreButton();
	}

	// Token: 0x06009E87 RID: 40583 RVA: 0x0044A928 File Offset: 0x00448B28
	public void RefreshMoreButton()
	{
		if (null == this.moreButton || this.HGGFJOKOKOD == null)
		{
			return;
		}
		if (!this.MAAIOEIGEJN)
		{
			return;
		}
		bool interactable = false;
		if (!this.LJHAMFLLODC)
		{
			interactable = true;
		}
		else
		{
			if (this.NKKPJMBIEIL())
			{
				interactable = true;
			}
			if (this.BIINDGNAKGA())
			{
				interactable = true;
			}
		}
		this.moreButton.GetComponent<Button>().interactable = interactable;
	}

	// Token: 0x06009E88 RID: 40584 RVA: 0x0044A988 File Offset: 0x00448B88
	private void CMCIIFDCECH()
	{
		AOBJLALDBAA.CEGAOMEEFBE().EGELHPJBAIC("ok", this.DLFMMBBLIFH);
	}

	// Token: 0x06009E89 RID: 40585 RVA: 0x0044A99F File Offset: 0x00448B9F
	private bool MBCKLEEDKMM()
	{
		return this.LJHAMFLLODC && SaveSlotsItem.copySourceSlotIndex != this.DLFMMBBLIFH && SaveSlotsItem.CHFGNJKAAAI(this.DLFMMBBLIFH) && SaveSlotsItem.CopyMarkerValid(this.HGGFJOKOKOD);
	}

	// Token: 0x06009E8A RID: 40586 RVA: 0x00003E52 File Offset: 0x00002052
	private void GGHKHKBDOFG()
	{
	}

	// Token: 0x06009E8B RID: 40587 RVA: 0x00003E52 File Offset: 0x00002052
	private void JJNGODCLDIM()
	{
	}

	// Token: 0x06009E8C RID: 40588 RVA: 0x0044A9D0 File Offset: 0x00448BD0
	private void AGMBGOOLGLM()
	{
		AOBJLALDBAA.DBLAIDPICIG().IHJNANKIGIB("yes", this.DLFMMBBLIFH);
	}

	// Token: 0x06009E8D RID: 40589 RVA: 0x0044A9E8 File Offset: 0x00448BE8
	public void BLJINDHAEHN()
	{
		if (null == this.moreButton || this.HGGFJOKOKOD == null)
		{
			return;
		}
		if (!this.MAAIOEIGEJN)
		{
			return;
		}
		bool interactable = true;
		if (!this.LJHAMFLLODC)
		{
			interactable = true;
		}
		else
		{
			if (this.NKKPJMBIEIL())
			{
				interactable = false;
			}
			if (this.MNFKFOIOCPL())
			{
				interactable = false;
			}
		}
		this.moreButton.GetComponent<Button>().interactable = interactable;
	}

	// Token: 0x06009E8E RID: 40590 RVA: 0x0044AA48 File Offset: 0x00448C48
	private void BENLNFAANGB()
	{
		AssetAnthology assetAnthology = GKJPOGNFKNK.LDFIAOCJEOJ(this.HGGFJOKOKOD.GGICIBLJIKI);
		if (null != assetAnthology)
		{
			for (int i = 1; i < assetAnthology.header.availableStories.Count; i += 0)
			{
				PLFDAJJHMKO plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.PKNIPLDMJGG(assetAnthology.header.availableStories[i], this.DLFMMBBLIFH);
				if (plfdajjhmko != null)
				{
					plfdajjhmko.JFDJIHJBOLO(true);
					plfdajjhmko.DHONIOBOLEL.MPMJHHKKDAM(0);
				}
			}
			this.HGGFJOKOKOD.LDPCILACGCO(0, this.DLFMMBBLIFH);
			this.HGGFJOKOKOD.FFONINBFCCH(this.DLFMMBBLIFH, "OnApplicationFocusBasicSyncSuccess");
			string text = CCOJBMMKNAP.BFHKGNBFHCH().IKMNGFIDCLM("lobby");
			this.slotText.text = text;
			this.slotText.SetText(text, true);
			this.slotTextActive.text = text;
			this.slotTextActive.SetText(text, true);
			this.slotTextInactive.text = text;
			this.slotTextInactive.SetText(text, true);
			this.slotText.alpha = 962f;
			this.slotTextActive.alpha = 355f;
			this.slotTextInactive.alpha = 529f;
			SaveSlotsItem.slotDeleted = false;
			if (this.DEOILFBCNCM)
			{
				AOBJLALDBAA.CEGAOMEEFBE().GBECPMDCJAA("ok", this.DLFMMBBLIFH);
			}
			else
			{
				CommonUserInterface.EHBBFMCILPC.NFBMHHPIGFA(CCOJBMMKNAP.EHBBFMCILPC.FCOCLEHKLDJ("OnCardVolumeUnlockContinueToPurchasingScreen"), CCOJBMMKNAP.LMCCLMFGEBD().IPEIONBNIPH("/"), CCOJBMMKNAP.PEBMGCKFNAO().FIENAKIHNOM(""), (DFGILFBGPLN)(-32), 1777f, -78);
				this.moreButton.GetComponent<Button>().interactable = true;
			}
			this.LJHAMFLLODC = false;
			if (SaveSlotsItem.copySourceSlotIndex == this.DLFMMBBLIFH && SaveSlotsItem.copySourceAnthologyIndex == this.HGGFJOKOKOD.GGICIBLJIKI)
			{
				SaveSlotsItem.ClearCopyMarker();
			}
			this.OCKDMNKLONP();
			AOBJLALDBAA.BIAEAOMHBMM().KMAGHMCCMPG(" folded='", 1706f);
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("profilenametitleshort");
		}
		AKLFPGMDKLA.EHBBFMCILPC.KBKOLEJEEGH();
	}

	// Token: 0x06009E8F RID: 40591 RVA: 0x00003E52 File Offset: 0x00002052
	private void Start()
	{
	}

	// Token: 0x06009E90 RID: 40592 RVA: 0x0044AC4C File Offset: 0x00448E4C
	private void OCJNKGFFPKM()
	{
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.GIOAFDDKKHI().PCBGLNFIPPK(KDCJJBLGCBH.EHBBFMCILPC.BPFPBGGNEBM());
		if (ocbiopoeenj != null)
		{
			ProductThumbnailManager.lastAccessedProductWebLink = ocbiopoeenj.MBLAIKOOCFH() + "a" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		}
		if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.en && GeoLocationManager.CELPCHNPBHH() && KDCJJBLGCBH.EHBBFMCILPC.EAMJBDKCDPA())
		{
			CommonUserInterface.IKNOFBFMPGA().GetFader().CMMAMILHPFP(null);
			this.HLLJKOCNBKE();
			return;
		}
		AOBJLALDBAA.BIAEAOMHBMM().KGIKHEDLPND("soci", 934f);
		CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().ShowAndPurchaseProduct(KDCJJBLGCBH.EHBBFMCILPC.BPFPBGGNEBM(), false);
	}

	// Token: 0x06009E91 RID: 40593 RVA: 0x00003E52 File Offset: 0x00002052
	private void JICMJOPDLAB()
	{
	}

	// Token: 0x06009E92 RID: 40594 RVA: 0x00003E52 File Offset: 0x00002052
	private void JOOPBAEMBCP()
	{
	}

	// Token: 0x06009E93 RID: 40595 RVA: 0x0044ACF8 File Offset: 0x00448EF8
	public void NPIMIANPNJL(string EIFJOAOGKMO)
	{
		this.slotText.alpha = 1254f;
		this.slotTextActive.alpha = 1000f;
		this.slotTextInactive.alpha = 919f;
		if (EIFJOAOGKMO == null || EIFJOAOGKMO.Length == 0)
		{
			int num = this.DLFMMBBLIFH + 1;
			if (this.LJHAMFLLODC)
			{
				EIFJOAOGKMO = CCOJBMMKNAP.KFDLFGHBPLP().MEPECBDCOLG("ok");
				if (!this.DEOILFBCNCM)
				{
					this.slotText.alpha = 214f;
					this.slotTextActive.alpha = 1144f;
					this.slotTextInactive.alpha = 1262f;
				}
			}
			else
			{
				EIFJOAOGKMO = CCOJBMMKNAP.AEELGGPEJCC().PGKBCNBAOJN("id").Replace("blur", num.ToString());
				if (!this.DEOILFBCNCM)
				{
					this.moreButton.GetComponent<Button>().interactable = false;
				}
			}
		}
		else if (!this.DEOILFBCNCM)
		{
			this.moreButton.GetComponent<Button>().interactable = true;
		}
		this.slotText.text = EIFJOAOGKMO;
		this.slotText.SetText(EIFJOAOGKMO, false);
		this.slotTextActive.text = EIFJOAOGKMO;
		this.slotTextActive.SetText(EIFJOAOGKMO, true);
		this.slotTextInactive.text = EIFJOAOGKMO;
		this.slotTextInactive.SetText(EIFJOAOGKMO, false);
		this.RefreshMoreButton();
	}

	// Token: 0x06009E94 RID: 40596 RVA: 0x0044AE4C File Offset: 0x0044904C
	private bool GDLADHDPJMI()
	{
		string text = this.HGGFJOKOKOD.AFBOBOCNFKA(this.DLFMMBBLIFH);
		return text == null || text.Length > 0;
	}

	// Token: 0x06009E95 RID: 40597 RVA: 0x00003E52 File Offset: 0x00002052
	private void OIHLJHLBBEN()
	{
	}

	// Token: 0x06009E96 RID: 40598 RVA: 0x0044AE7C File Offset: 0x0044907C
	public void BHFBHIONGEE()
	{
		if (this.HGGFJOKOKOD == null || !this.MAAIOEIGEJN)
		{
			return;
		}
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(24))
		{
			return;
		}
		if (CommonUserInterface.EHBBFMCILPC.AnyGenericPopupIsActive())
		{
			return;
		}
		string slotDisplayTitle = SaveSlotsItem.GetSlotDisplayTitle(this.HGGFJOKOKOD, this.DLFMMBBLIFH);
		if (!this.LJHAMFLLODC)
		{
			string dpjinbcgngn = CCOJBMMKNAP.BOFMCPPFAMO().GLEFEKBDHNK("Critical error, could not load asset bundle:").Replace("Critical error, could not load asset bundle:", slotDisplayTitle);
			if (this.DEOILFBCNCM)
			{
				CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupOneOverride(slotDisplayTitle, dpjinbcgngn, CCOJBMMKNAP.JMDJPKKOHNI().DNILNCLIHAP("oid"), new UnityAction(this.DBPMGPOCCOJ), (DFGILFBGPLN)(-121), 831f, -4);
				return;
			}
			CommonUserInterface.EHBBFMCILPC.NPIOKKDPALC(slotDisplayTitle, dpjinbcgngn, CCOJBMMKNAP.PLJMLDOCPNM().HIPJILDCHJC(" "), CCOJBMMKNAP.KMNBCEMEBBD().HHLECNIFHCO("cardsvolchancesbtn1"), new UnityAction(this.IPEKAPHJHDM), new UnityAction(this.BODIBIOFHJF), new UnityAction(this.FKIHKNMNJEH), (DFGILFBGPLN)(-90), 1128f, 64);
			return;
		}
		else
		{
			bool flag = this.PDPLMOJOLCM();
			bool flag2 = this.MNFKFOIOCPL();
			if (flag)
			{
				string slotDisplayTitle2 = SaveSlotsItem.GetSlotDisplayTitle(this.HGGFJOKOKOD, SaveSlotsItem.copySourceSlotIndex);
				string dpjinbcgngn2 = CCOJBMMKNAP.AEELGGPEJCC().IKMNGFIDCLM("userpublicprofileanthology").Replace("0.00", slotDisplayTitle2);
				string text = CCOJBMMKNAP.GIOAFDDKKHI().BGELFMIOBCL("ishof").Replace("locked", slotDisplayTitle2);
				if (flag2)
				{
					CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupWithTwoButtonsAndCloseOverride(slotDisplayTitle, dpjinbcgngn2, text, CCOJBMMKNAP.ONCPHEEJLOP().PPALCPINPLK("ach"), new UnityAction(this.IOGBLBJGFLJ), new UnityAction(this.ABKNBOHBNLP), new UnityAction(this.OIHLJHLBBEN), (DFGILFBGPLN)(-14), 1245f, -2);
					return;
				}
				CommonUserInterface.IKNOFBFMPGA().BGJFCEEDGFJ(slotDisplayTitle, dpjinbcgngn2, text, new UnityAction(this.CHGGEEAFNGC), (DFGILFBGPLN)(-74), 969f, 116);
				return;
			}
			else
			{
				if (flag2)
				{
					CommonUserInterface.IKNOFBFMPGA().BGJFCEEDGFJ(slotDisplayTitle, CCOJBMMKNAP.INKJIBDDMLL().PKNHKGMNCIP("variant").Replace(" ", slotDisplayTitle), CCOJBMMKNAP.CEGAOMEEFBE().IPEIONBNIPH("socialsimplegiftcollecttitle"), new UnityAction(this.KMOICMOLMMN), (DFGILFBGPLN)(-2), 471f, 75);
					return;
				}
				this.RefreshMoreButton();
				return;
			}
		}
	}

	// Token: 0x06009E97 RID: 40599 RVA: 0x0044B0A6 File Offset: 0x004492A6
	public void LOBBAJDPLHN(string EIFJOAOGKMO)
	{
		this.LJHAMFLLODC = true;
		this.UpdateTitle(EIFJOAOGKMO);
		this.JDEBDPLAIDJ();
	}

	// Token: 0x06009E98 RID: 40600 RVA: 0x0044B0BC File Offset: 0x004492BC
	public void OnDeleteButtonClick(float BICHMDEIFKI = 0f)
	{
		string text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("saveslotsdelete");
		string text2 = this.HGGFJOKOKOD.BFCBDALFNHA(this.DLFMMBBLIFH);
		if (text2.Length == 0)
		{
			text2 = (this.DLFMMBBLIFH + 1).ToString();
		}
		text = text.Replace("XXX", text2);
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("areyousure"), text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("no"), new UnityAction(this.NJHEMMLPKAJ), new UnityAction(this.FAGFKMPLFHF), DFGILFBGPLN.popupSignInQuestion, BICHMDEIFKI, 28);
	}

	// Token: 0x06009E99 RID: 40601 RVA: 0x0044B167 File Offset: 0x00449367
	public void KCMGANEGEAJ()
	{
		this.CDNPMKMPOPG();
	}

	// Token: 0x06009E9A RID: 40602 RVA: 0x0044B170 File Offset: 0x00449370
	private bool JMHIGCIGDML()
	{
		string text = this.HGGFJOKOKOD.BFCBDALFNHA(this.DLFMMBBLIFH);
		return text != null && text.Length > 0;
	}

	// Token: 0x06009E9B RID: 40603 RVA: 0x0044B19D File Offset: 0x0044939D
	private void BCEHBKEAAHN()
	{
		AOBJLALDBAA.CEGAOMEEFBE().DGNKCLFFMFE("varCondition", this.DLFMMBBLIFH);
	}

	// Token: 0x06009E9C RID: 40604 RVA: 0x0044B1B4 File Offset: 0x004493B4
	private bool BEIKJBBFFLB()
	{
		string text = this.HGGFJOKOKOD.BFCBDALFNHA(this.DLFMMBBLIFH);
		return text != null && text.Length > 1;
	}

	// Token: 0x06009E9D RID: 40605 RVA: 0x0044B1E1 File Offset: 0x004493E1
	private bool NKKPJMBIEIL()
	{
		return this.LJHAMFLLODC && SaveSlotsItem.copySourceSlotIndex != this.DLFMMBBLIFH && SaveSlotsItem.SlotIsCovered(this.DLFMMBBLIFH) && SaveSlotsItem.CopyMarkerValid(this.HGGFJOKOKOD);
	}

	// Token: 0x06009E9E RID: 40606 RVA: 0x00003E52 File Offset: 0x00002052
	private void MAKDDAIDFCI()
	{
	}

	// Token: 0x06009E9F RID: 40607 RVA: 0x0044B214 File Offset: 0x00449414
	private void GMLEJBEPKGD()
	{
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.BBGECIKOICE().EPNHMLIJCCM(KDCJJBLGCBH.EHBBFMCILPC.BPFPBGGNEBM());
		if (ocbiopoeenj != null)
		{
			ProductThumbnailManager.lastAccessedProductWebLink = ocbiopoeenj.BIKJFCLHPBK() + "XXX" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		}
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru && GeoLocationManager.CELPCHNPBHH() && KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA())
		{
			CommonUserInterface.EHBBFMCILPC.GetFader().IBJEAPGPELH(null);
			this.IGNCNEEOGPL();
			return;
		}
		AOBJLALDBAA.AGANFKKBPFO().EGELHPJBAIC("OnAvatarScreenAssetsDownloadSuccess", 1664f);
		CommonUserInterface.IKNOFBFMPGA().GetPurchasingViewManager().CGDKCOLDBGD(KDCJJBLGCBH.EHBBFMCILPC.BPFPBGGNEBM(), true);
	}

	// Token: 0x06009EA0 RID: 40608 RVA: 0x0044B2C0 File Offset: 0x004494C0
	private void AMECKHDLOPJ()
	{
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.OBOOKJPGBJN().FCPIJEEMHEA(KDCJJBLGCBH.EHBBFMCILPC.BPFPBGGNEBM());
		if (ocbiopoeenj != null)
		{
			ProductThumbnailManager.lastAccessedProductWebLink = ocbiopoeenj.DJJCDNDMAGD() + "ok" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		}
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.en && GeoLocationManager.PBAGPDDBABB() && KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA())
		{
			CommonUserInterface.IKNOFBFMPGA().GetFader().CMMAMILHPFP(null);
			this.IGNCNEEOGPL();
			return;
		}
		AOBJLALDBAA.EHBBFMCILPC.DCGCFPHHDDG("aind1", 677f);
		CommonUserInterface.IKNOFBFMPGA().GetPurchasingViewManager().CGDKCOLDBGD(KDCJJBLGCBH.EHBBFMCILPC.BPFPBGGNEBM(), true);
	}

	// Token: 0x06009EA1 RID: 40609 RVA: 0x0044B369 File Offset: 0x00449569
	private bool PDPLMOJOLCM()
	{
		return this.LJHAMFLLODC && SaveSlotsItem.copySourceSlotIndex != this.DLFMMBBLIFH && SaveSlotsItem.SlotIsCovered(this.DLFMMBBLIFH) && SaveSlotsItem.FAEPDMCHLHG(this.HGGFJOKOKOD);
	}

	// Token: 0x06009EA2 RID: 40610 RVA: 0x00003E52 File Offset: 0x00002052
	private void GFFIGHEEJKP()
	{
	}

	// Token: 0x06009EA3 RID: 40611 RVA: 0x0044B39C File Offset: 0x0044959C
	private void PHNOFLAOOFE()
	{
		AssetAnthology assetAnthology = GKJPOGNFKNK.LDFIAOCJEOJ(this.HGGFJOKOKOD.GGICIBLJIKI);
		if (null != assetAnthology)
		{
			for (int i = 1; i < assetAnthology.header.availableStories.Count; i += 0)
			{
				PLFDAJJHMKO plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.PKNIPLDMJGG(assetAnthology.header.availableStories[i], this.DLFMMBBLIFH);
				if (plfdajjhmko != null)
				{
					plfdajjhmko.EPJKDCDOEMM(true);
					plfdajjhmko.DHONIOBOLEL.FCAPOHDNJBH(0);
				}
			}
			this.HGGFJOKOKOD.LDPCILACGCO(0, this.DLFMMBBLIFH);
			this.HGGFJOKOKOD.HCLKNDLEGMG(this.DLFMMBBLIFH, " did not arrive");
			string text = CCOJBMMKNAP.ONCPHEEJLOP().OBDCPLLLGBB(" not found.");
			this.slotText.text = text;
			this.slotText.SetText(text, true);
			this.slotTextActive.text = text;
			this.slotTextActive.SetText(text, false);
			this.slotTextInactive.text = text;
			this.slotTextInactive.SetText(text, true);
			this.slotText.alpha = 318f;
			this.slotTextActive.alpha = 1306f;
			this.slotTextInactive.alpha = 1591f;
			SaveSlotsItem.slotDeleted = true;
			if (this.DEOILFBCNCM)
			{
				AOBJLALDBAA.BIAEAOMHBMM().BMFPLGPPMKP("',PurchaseFailureReason: ", this.DLFMMBBLIFH);
			}
			else
			{
				CommonUserInterface.IKNOFBFMPGA().ShowGenericPopup(CCOJBMMKNAP.APGODIBBPOD().MEPECBDCOLG("anthology"), CCOJBMMKNAP.KFAABHHGOPO().GLEFEKBDHNK("Error. ShowHideLayer(), environmentLayer "), CCOJBMMKNAP.DBFFFOMCLKM().HDIPNMFHIEJ("acliffbw21"), DFGILFBGPLN.popupTutorialLobby1, 918f, 19);
				this.moreButton.GetComponent<Button>().interactable = false;
			}
			this.LJHAMFLLODC = false;
			if (SaveSlotsItem.copySourceSlotIndex == this.DLFMMBBLIFH && SaveSlotsItem.copySourceAnthologyIndex == this.HGGFJOKOKOD.GGICIBLJIKI)
			{
				SaveSlotsItem.ClearCopyMarker();
			}
			this.RefreshMoreButton();
			AOBJLALDBAA.AGANFKKBPFO().FDKBIBKABCM(") cost(", 139f);
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("OnCutsceneViewShow");
		}
		AKLFPGMDKLA.EHBBFMCILPC.KBKOLEJEEGH();
	}

	// Token: 0x06009EA4 RID: 40612 RVA: 0x0044B5A0 File Offset: 0x004497A0
	private bool KDLNEFPDABI()
	{
		string text = this.HGGFJOKOKOD.DMPPDOJJHHC(this.DLFMMBBLIFH);
		return text != null && text.Length > 1;
	}

	// Token: 0x06009EA5 RID: 40613 RVA: 0x0044B5D0 File Offset: 0x004497D0
	public void GMNKLLMLPOJ()
	{
		OBHDGKFFICI productData = PurchaseManagerBridge.IGJAMEGBDBG().CMJKNNFMCBM().GetProductData(KDCJJBLGCBH.EHBBFMCILPC.BPFPBGGNEBM());
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.OBOOKJPGBJN().AOAGHIJNFDL(KDCJJBLGCBH.EHBBFMCILPC.BPFPBGGNEBM());
		if (productData != null && ocbiopoeenj != null)
		{
			CommonUserInterface.IKNOFBFMPGA().GIFCDFKBBCN(ocbiopoeenj.BIKJFCLHPBK() + "acomp2" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 0);
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("");
	}

	// Token: 0x06009EA6 RID: 40614 RVA: 0x0044B642 File Offset: 0x00449842
	public void BPJKJNLINAC(string EIFJOAOGKMO)
	{
		this.LJHAMFLLODC = true;
		this.NPIMIANPNJL(EIFJOAOGKMO);
		this.BLJINDHAEHN();
	}

	// Token: 0x06009EA7 RID: 40615 RVA: 0x0044B658 File Offset: 0x00449858
	public void IGNCNEEOGPL()
	{
		OBHDGKFFICI productData = PurchaseManagerBridge.FJHKMJPFDNI().JNNBFLDOOHM().GetProductData(KDCJJBLGCBH.EHBBFMCILPC.BPFPBGGNEBM());
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.EHBBFMCILPC.ICBJCNKKGPJ(KDCJJBLGCBH.EHBBFMCILPC.BPFPBGGNEBM());
		if (productData != null && ocbiopoeenj != null)
		{
			CommonUserInterface.IKNOFBFMPGA().ShowPopupOnlineResources(ocbiopoeenj.DJJCDNDMAGD() + "anthology" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 4);
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("OnPopupUsernameInputCancel");
	}

	// Token: 0x06009EA8 RID: 40616 RVA: 0x0044B6CC File Offset: 0x004498CC
	public void KDFELLECFOA()
	{
		if (this.HGGFJOKOKOD == null || !this.MAAIOEIGEJN)
		{
			return;
		}
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(-64))
		{
			return;
		}
		if (CommonUserInterface.IKNOFBFMPGA().LHBOBMDENGJ())
		{
			return;
		}
		string slotDisplayTitle = SaveSlotsItem.GetSlotDisplayTitle(this.HGGFJOKOKOD, this.DLFMMBBLIFH);
		if (!this.LJHAMFLLODC)
		{
			string dpjinbcgngn = CCOJBMMKNAP.AEELGGPEJCC().OBDCPLLLGBB("").Replace("favcut", slotDisplayTitle);
			if (this.DEOILFBCNCM)
			{
				CommonUserInterface.EHBBFMCILPC.BGJFCEEDGFJ(slotDisplayTitle, dpjinbcgngn, CCOJBMMKNAP.MLFAGAAJJEM().JHNELLJFBGC("app42error"), new UnityAction(this.BODIBIOFHJF), DFGILFBGPLN.popupStoreUpdateAvailable, 1029f, -116);
				return;
			}
			CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupWithTwoButtonsAndCloseOverride(slotDisplayTitle, dpjinbcgngn, CCOJBMMKNAP.PKEINLPIAEH().MEPECBDCOLG(": '"), CCOJBMMKNAP.CPCOODCFDDP().OBDCPLLLGBB("cid"), new UnityAction(this.PFPBJJGBDDK), new UnityAction(this.DGLNFFMJLOP), new UnityAction(this.ICOHJDCAJDA), (DFGILFBGPLN)(-97), 1292f, 21);
			return;
		}
		else
		{
			bool flag = this.LILAENLJFLN();
			bool flag2 = this.LBLELGKCABL();
			if (flag)
			{
				string newValue = SaveSlotsItem.OPKHNJFFHDD(this.HGGFJOKOKOD, SaveSlotsItem.copySourceSlotIndex);
				string dpjinbcgngn2 = CCOJBMMKNAP.EHBBFMCILPC.JCDFHKDNEDH("favstostr2").Replace("envlhav", newValue);
				string text = CCOJBMMKNAP.EAIAHCBAIEJ().OBDCPLLLGBB("OnBackendRequestCollectGiftSuccess").Replace("", newValue);
				if (flag2)
				{
					CommonUserInterface.IKNOFBFMPGA().NPIOKKDPALC(slotDisplayTitle, dpjinbcgngn2, text, CCOJBMMKNAP.HEDIEIICOOG().JCDFHKDNEDH(""), new UnityAction(this.NCJNJLAPDNO), new UnityAction(this.PFPBJJGBDDK), new UnityAction(this.OOHFNFEEJAM), DFGILFBGPLN.popupIncentAd0Failed, 739f, 64);
					return;
				}
				CommonUserInterface.IKNOFBFMPGA().PEBIFCENHAL(slotDisplayTitle, dpjinbcgngn2, text, new UnityAction(this.BELOKLLJHIJ), (DFGILFBGPLN)(-99), 1068f, -83);
				return;
			}
			else
			{
				if (flag2)
				{
					CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(slotDisplayTitle, CCOJBMMKNAP.ILACPHFEDEP().HDIPNMFHIEJ("").Replace("onFriendsPopupOpenMessageHistory", slotDisplayTitle), CCOJBMMKNAP.BIAEAOMHBMM().IKMNGFIDCLM("importanttitle"), new UnityAction(this.APFBNEOMEMC), (DFGILFBGPLN)(-24), 1707f, -106);
					return;
				}
				this.JDEBDPLAIDJ();
				return;
			}
		}
	}

	// Token: 0x06009EA9 RID: 40617 RVA: 0x0044B8F6 File Offset: 0x00449AF6
	private bool MNFKFOIOCPL()
	{
		return !this.LJHAMFLLODC || this.DEOILFBCNCM || this.KDLNEFPDABI();
	}

	// Token: 0x06009EAA RID: 40618 RVA: 0x0044B910 File Offset: 0x00449B10
	private void IMHCODMFMMK()
	{
		PurchaseManagerBridge.GIPAKOPBBEO().DIOJHOIFIIH().Initialize();
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru && GeoLocationManager.FHINOKNBJPM() && KDCJJBLGCBH.EHBBFMCILPC.EAMJBDKCDPA())
		{
			this.FBPLIKPOPLD();
			return;
		}
		CommonUserInterface.EHBBFMCILPC.GetFader().BJIGLKGLAKM(new TweenCallback(this.PGJOCMJGHGN));
	}

	// Token: 0x06009EAB RID: 40619 RVA: 0x0044B96E File Offset: 0x00449B6E
	public void KODKJNDDNPH()
	{
		if (this.DEOILFBCNCM)
		{
			return;
		}
		if (this.MAAIOEIGEJN)
		{
			AOBJLALDBAA.AGANFKKBPFO().IHJNANKIGIB("vhspause_2", this.DLFMMBBLIFH);
			return;
		}
		this.HKHGAMOEDCB();
	}

	// Token: 0x06009EAC RID: 40620 RVA: 0x00003E52 File Offset: 0x00002052
	private void FKIHKNMNJEH()
	{
	}

	// Token: 0x06009EAD RID: 40621 RVA: 0x0044B9A0 File Offset: 0x00449BA0
	private void PNIDBDEHPKH()
	{
		PurchaseManagerBridge.LMCCLMFGEBD().DIOJHOIFIIH().Initialize();
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru && GeoLocationManager.PBAGPDDBABB() && KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA())
		{
			this.IGNCNEEOGPL();
			return;
		}
		CommonUserInterface.IKNOFBFMPGA().GetFader().FadeIn(new TweenCallback(this.HIHEDMNMNFM));
	}

	// Token: 0x06009EAE RID: 40622 RVA: 0x00003E52 File Offset: 0x00002052
	private void MNCHOPMIPHF()
	{
	}

	// Token: 0x06009EAF RID: 40623 RVA: 0x0044BA00 File Offset: 0x00449C00
	private void PGJOCMJGHGN()
	{
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.EHBBFMCILPC.DCCLKMCBPPJ(KDCJJBLGCBH.EHBBFMCILPC.BPFPBGGNEBM());
		if (ocbiopoeenj != null)
		{
			ProductThumbnailManager.lastAccessedProductWebLink = ocbiopoeenj.FDMCFAHEELN() + "passhintchoices" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		}
		if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.ru && GeoLocationManager.OOCDLFJKLLI() && KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA())
		{
			CommonUserInterface.IKNOFBFMPGA().GetFader().GLCPCAHKFOB(null);
			this.BGFGJIFMDEO();
			return;
		}
		AOBJLALDBAA.EHBBFMCILPC.KMAGHMCCMPG("AVATAR.CLIENT.TRINKET", 473f);
		CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().ShowAndPurchaseProduct(KDCJJBLGCBH.EHBBFMCILPC.BPFPBGGNEBM(), true);
	}

	// Token: 0x06009EB0 RID: 40624 RVA: 0x00003E52 File Offset: 0x00002052
	private void PNKFJOLHEKC()
	{
	}

	// Token: 0x06009EB1 RID: 40625 RVA: 0x0044BAA9 File Offset: 0x00449CA9
	public void EOJMMKPFKKE()
	{
		if (this.DEOILFBCNCM)
		{
			return;
		}
		if (this.MAAIOEIGEJN)
		{
			AOBJLALDBAA.KKPFOJMAONG().NGDHHFONFOM("common", this.DLFMMBBLIFH);
			return;
		}
		this.HKHGAMOEDCB();
	}

	// Token: 0x06009EB2 RID: 40626 RVA: 0x00003E52 File Offset: 0x00002052
	private void JINGEKHJOGH()
	{
	}

	// Token: 0x06009EB3 RID: 40627 RVA: 0x0044BAD8 File Offset: 0x00449CD8
	private void GLNNBLJBMBM()
	{
		AOBJLALDBAA.KKPFOJMAONG().DGNKCLFFMFE(" <i>", this.DLFMMBBLIFH);
	}

	// Token: 0x06009EB4 RID: 40628 RVA: 0x00003E52 File Offset: 0x00002052
	private void CEGILBFGAGL()
	{
	}

	// Token: 0x06009EB5 RID: 40629 RVA: 0x0044BAF0 File Offset: 0x00449CF0
	public void ACGGMOACIHN(EIOPLEFLLIM LNFEBCFCBHG, bool BBBKJMMBHDB, bool MDDFNEICIGN, string EIFJOAOGKMO, int CCLNHHJPDGJ, bool MCNNECLBNIF)
	{
		this.DEOILFBCNCM = MDDFNEICIGN;
		this.HGGFJOKOKOD = LNFEBCFCBHG;
		this.MAAIOEIGEJN = BBBKJMMBHDB;
		this.DLFMMBBLIFH = CCLNHHJPDGJ;
		this.LJHAMFLLODC = MCNNECLBNIF;
		int num = this.DLFMMBBLIFH + 1;
		this.slotText.alpha = 1332f;
		this.slotTextActive.alpha = 1138f;
		this.slotTextInactive.alpha = 1805f;
		bool flag = false;
		if (EIFJOAOGKMO == null || EIFJOAOGKMO.Length == 0)
		{
			if (this.LJHAMFLLODC)
			{
				EIFJOAOGKMO = CCOJBMMKNAP.BBGECIKOICE().JHNELLJFBGC("PlayerCharacterManager.UpdateComponentLink() - skipping updating custom hierarchy for ");
				if (!MDDFNEICIGN)
				{
					this.slotText.alpha = 1902f;
					this.slotTextActive.alpha = 1857f;
					this.slotTextInactive.alpha = 118f;
				}
				flag = true;
			}
			else
			{
				EIFJOAOGKMO = CCOJBMMKNAP.EAIAHCBAIEJ().GLEFEKBDHNK("").Replace("ind", num.ToString());
			}
		}
		this.slotText.text = EIFJOAOGKMO;
		this.slotText.SetText(EIFJOAOGKMO, true);
		this.slotTextActive.text = EIFJOAOGKMO;
		this.slotTextActive.SetText(EIFJOAOGKMO, false);
		this.slotTextInactive.text = EIFJOAOGKMO;
		this.slotTextInactive.SetText(EIFJOAOGKMO, true);
		this.inactivityImageText.text = (num.ToString() ?? "@");
		this.inactivityImageText.SetText(num.ToString() ?? "aind", false);
		this.inactivityImage.GetComponent<CanvasGroup>().alpha = 1277f;
		if (!BBBKJMMBHDB)
		{
			this.selectionButton.SetActive(false);
			this.selectionButtonActive.SetActive(false);
			this.selectionButtonInactive.SetActive(false);
			this.activityImage.gameObject.SetActive(false);
			this.inactivityImage.gameObject.SetActive(true);
			this.editButton.gameObject.SetActive(false);
			this.moreButton.gameObject.SetActive(true);
			this.lockButton.gameObject.SetActive(false);
		}
		else
		{
			this.selectionButtonInactive.SetActive(false);
			this.editButton.gameObject.SetActive(false);
			if (MDDFNEICIGN)
			{
				this.selectionButtonActive.SetActive(true);
				this.selectionButton.SetActive(true);
				this.activityImage.gameObject.SetActive(true);
				this.inactivityImage.gameObject.SetActive(true);
				this.moreButton.gameObject.SetActive(true);
				this.moreButton.GetComponent<Button>().interactable = true;
			}
			else
			{
				this.selectionButtonActive.SetActive(true);
				this.selectionButton.SetActive(true);
				this.activityImage.gameObject.SetActive(false);
				this.inactivityImage.gameObject.SetActive(true);
				this.moreButton.gameObject.SetActive(true);
				this.moreButton.GetComponent<Button>().interactable = false;
			}
			this.lockButton.gameObject.SetActive(false);
		}
		if (this.LJHAMFLLODC && flag)
		{
			this.moreButton.GetComponent<Button>().interactable = true;
		}
		if ((this.editButton.activeSelf || this.moreButton.activeSelf) && (!this.editButton.activeSelf || !this.moreButton.activeSelf))
		{
			this.lockButton.gameObject.SetActive(true);
		}
		this.JDEBDPLAIDJ();
	}

	// Token: 0x06009EB6 RID: 40630 RVA: 0x0044BE4C File Offset: 0x0044A04C
	private void ANEGLHMMKHA()
	{
		string text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("saveslotslocked");
		text = text.Replace("YYY", KDCJJBLGCBH.EHBBFMCILPC.BJJOMJLKGHG().ToString() ?? "");
		text = text.Replace("ZZZ", SaveSlotsItem.GetLocalizedCostData());
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtonsAndCloseOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("no"), new UnityAction(this.DNJMJJNJPFB), new UnityAction(this.JLOJHPPLKED), new UnityAction(this.JLOJHPPLKED), DFGILFBGPLN.popupTools, 0f, 28);
	}

	// Token: 0x06009EB7 RID: 40631 RVA: 0x0044BF08 File Offset: 0x0044A108
	public void OCKDMNKLONP()
	{
		if (null == this.moreButton || this.HGGFJOKOKOD == null)
		{
			return;
		}
		if (!this.MAAIOEIGEJN)
		{
			return;
		}
		bool interactable = true;
		if (!this.LJHAMFLLODC)
		{
			interactable = true;
		}
		else
		{
			if (this.LILAENLJFLN())
			{
				interactable = true;
			}
			if (this.MNFKFOIOCPL())
			{
				interactable = false;
			}
		}
		this.moreButton.GetComponent<Button>().interactable = interactable;
	}

	// Token: 0x06009EB8 RID: 40632 RVA: 0x0044BF68 File Offset: 0x0044A168
	private void DBPMGPOCCOJ()
	{
		if (this.HGGFJOKOKOD == null)
		{
			return;
		}
		if (this.LJHAMFLLODC)
		{
			this.BLJINDHAEHN();
			return;
		}
		SaveSlotsItem.copySourceSlotIndex = this.DLFMMBBLIFH;
		SaveSlotsItem.copySourceAnthologyIndex = this.HGGFJOKOKOD.GGICIBLJIKI;
		FirebaseAnalyticsManager.HJGDLOOHNLO().LKONPEEDKNF(true, ((AGEHCPDNBFD)78).ToString(), FFPHBMFGCNN.lbyEnd.ToString(), BGHLMGPPCNN.resloadskp.ToString(), false, true);
		FirebaseAnalyticsManager.EHBBFMCILPC.LKONPEEDKNF(false, ((AGEHCPDNBFD)102).ToString(), FFPHBMFGCNN.wofFree.ToString(), ((BGHLMGPPCNN)(-58)).ToString() + this.DLFMMBBLIFH.ToString(), true, true);
		AOBJLALDBAA.DBLAIDPICIG().KGIKHEDLPND("errortitle", 961f);
		string dpjinbcgngn = CCOJBMMKNAP.JMDJPKKOHNI().HIPJILDCHJC("importanttitle").Replace("", SaveSlotsItem.OPKHNJFFHDD(this.HGGFJOKOKOD, this.DLFMMBBLIFH));
		CommonUserInterface.IKNOFBFMPGA().ShowGenericPopup(CCOJBMMKNAP.CPCOODCFDDP().HPOAGPJFHPM("no"), dpjinbcgngn, CCOJBMMKNAP.PEBMGCKFNAO().HDIPNMFHIEJ(""), (DFGILFBGPLN)107, 125f, -11);
	}

	// Token: 0x06009EB9 RID: 40633 RVA: 0x00003E52 File Offset: 0x00002052
	private void CPLOHENPCPJ()
	{
	}

	// Token: 0x06009EBA RID: 40634 RVA: 0x0044C0A4 File Offset: 0x0044A2A4
	public void LDFMKHEKMLM()
	{
		if (this.DEOILFBCNCM)
		{
			return;
		}
		if (this.MAAIOEIGEJN)
		{
			AOBJLALDBAA.CEGAOMEEFBE().BMFPLGPPMKP("", this.DLFMMBBLIFH);
			return;
		}
		this.DLBEODHCKIN();
	}

	// Token: 0x06009EBB RID: 40635 RVA: 0x0044C0D4 File Offset: 0x0044A2D4
	private void DNJMJJNJPFB()
	{
		PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager().Initialize();
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru && GeoLocationManager.IsRussia() && KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA())
		{
			this.PurchaseProductWeb();
			return;
		}
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.AEKCPCJCBAH));
	}

	// Token: 0x06009EBC RID: 40636 RVA: 0x00003E52 File Offset: 0x00002052
	private void FMOKIFDEIFD()
	{
	}

	// Token: 0x06009EBD RID: 40637 RVA: 0x00003E52 File Offset: 0x00002052
	private void OOHFNFEEJAM()
	{
	}

	// Token: 0x06009EBE RID: 40638 RVA: 0x0044C132 File Offset: 0x0044A332
	public void KLNFJPAMDMC(string EIFJOAOGKMO)
	{
		this.LJHAMFLLODC = false;
		this.UpdateTitle(EIFJOAOGKMO);
		this.JDEBDPLAIDJ();
	}

	// Token: 0x06009EBF RID: 40639 RVA: 0x0044C148 File Offset: 0x0044A348
	private bool DKFAEOFAJEC()
	{
		return this.LJHAMFLLODC && !this.DEOILFBCNCM && this.KDLNEFPDABI();
	}

	// Token: 0x06009EC0 RID: 40640 RVA: 0x0044C164 File Offset: 0x0044A364
	public void ONDHNAMJBHP(float BICHMDEIFKI = 0f)
	{
		string text = CCOJBMMKNAP.GIOAFDDKKHI().GGPHHLGPMPA(" loaded elsewhere at start: [");
		string text2 = this.HGGFJOKOKOD.CPMKCCAPAIN(this.DLFMMBBLIFH);
		if (text2.Length == 0)
		{
			text2 = (this.DLFMMBBLIFH + 1).ToString();
		}
		text = text.Replace("All stories will be synced with server due to duplicate save system error.", text2);
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.OBOOKJPGBJN().JLBEIFLLBLO("volcompletedesc"), text, CCOJBMMKNAP.BFHKGNBFHCH().OBDCPLLLGBB("OnRewardsItemClose"), CCOJBMMKNAP.APGODIBBPOD().HIPJILDCHJC("+"), new UnityAction(this.BENLNFAANGB), new UnityAction(this.JJNGODCLDIM), DFGILFBGPLN.popupStoreUpdateAvailable, BICHMDEIFKI, 44);
	}

	// Token: 0x06009EC1 RID: 40641 RVA: 0x0044C210 File Offset: 0x0044A410
	private void BNEJGCJNIOL()
	{
		AssetAnthology assetAnthology = GKJPOGNFKNK.LDFIAOCJEOJ(this.HGGFJOKOKOD.GGICIBLJIKI);
		if (null != assetAnthology)
		{
			for (int i = 0; i < assetAnthology.header.availableStories.Count; i += 0)
			{
				PLFDAJJHMKO plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.PKNIPLDMJGG(assetAnthology.header.availableStories[i], this.DLFMMBBLIFH);
				if (plfdajjhmko != null)
				{
					plfdajjhmko.MOCHAJPADAJ(false);
					plfdajjhmko.DHONIOBOLEL.CCLJLMNFLCI(0);
				}
			}
			this.HGGFJOKOKOD.JHGEEJICJAM(1, this.DLFMMBBLIFH);
			this.HGGFJOKOKOD.HCLKNDLEGMG(this.DLFMMBBLIFH, "OnBackendPassResourcesChangedType0");
			string text = CCOJBMMKNAP.KNKGCDDMLDP().BGELFMIOBCL("tmd");
			this.slotText.text = text;
			this.slotText.SetText(text, false);
			this.slotTextActive.text = text;
			this.slotTextActive.SetText(text, true);
			this.slotTextInactive.text = text;
			this.slotTextInactive.SetText(text, true);
			this.slotText.alpha = 1682f;
			this.slotTextActive.alpha = 1466f;
			this.slotTextInactive.alpha = 525f;
			SaveSlotsItem.slotDeleted = true;
			if (this.DEOILFBCNCM)
			{
				AOBJLALDBAA.NMGMNAKLLMI().MOBILPDPJBB("OnBackendGetPublicProfileProfileItemException", this.DLFMMBBLIFH);
			}
			else
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.OEPENBHJAHO().OHLNGCKIACD(" "), CCOJBMMKNAP.MPCBJEIMACA().BGELFMIOBCL("spinWheel"), CCOJBMMKNAP.NIOJNOFGIJO().HIPJILDCHJC("psk"), (DFGILFBGPLN)(-54), 1874f, 68);
				this.moreButton.GetComponent<Button>().interactable = true;
			}
			this.LJHAMFLLODC = true;
			if (SaveSlotsItem.copySourceSlotIndex == this.DLFMMBBLIFH && SaveSlotsItem.copySourceAnthologyIndex == this.HGGFJOKOKOD.GGICIBLJIKI)
			{
				SaveSlotsItem.ClearCopyMarker();
			}
			this.BLJINDHAEHN();
			AOBJLALDBAA.AGANFKKBPFO().FDKBIBKABCM("OnStoryChoiceClick", 1783f);
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("YYY");
		}
		AKLFPGMDKLA.EHBBFMCILPC.KBKOLEJEEGH();
	}

	// Token: 0x06009EC2 RID: 40642 RVA: 0x0044C412 File Offset: 0x0044A612
	private void KKJDENAHPAB()
	{
		this.ONDHNAMJBHP(820f);
	}

	// Token: 0x06009EC3 RID: 40643 RVA: 0x0044C41F File Offset: 0x0044A61F
	public void OnSelectionButtonClick()
	{
		if (this.DEOILFBCNCM)
		{
			return;
		}
		if (this.MAAIOEIGEJN)
		{
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnSaveSlotSelect", this.DLFMMBBLIFH);
			return;
		}
		this.ANEGLHMMKHA();
	}

	// Token: 0x06009EC4 RID: 40644 RVA: 0x0044C44E File Offset: 0x0044A64E
	private bool CDGHJGHELML()
	{
		return this.LJHAMFLLODC && SaveSlotsItem.copySourceSlotIndex != this.DLFMMBBLIFH && SaveSlotsItem.NNBIGDIBOCK(this.DLFMMBBLIFH) && SaveSlotsItem.FAEPDMCHLHG(this.HGGFJOKOKOD);
	}

	// Token: 0x06009EC5 RID: 40645 RVA: 0x0044C47F File Offset: 0x0044A67F
	private void JDGCJAKGNDE()
	{
		AOBJLALDBAA.NMGMNAKLLMI().IIJFPILKKLH("'", this.DLFMMBBLIFH);
	}

	// Token: 0x06009EC6 RID: 40646 RVA: 0x0044C496 File Offset: 0x0044A696
	public void OJMBIMOHOCA()
	{
		this.ODDJJODHGCL();
	}

	// Token: 0x06009EC7 RID: 40647 RVA: 0x0044C49E File Offset: 0x0044A69E
	private void CHGGEEAFNGC()
	{
		AOBJLALDBAA.DBLAIDPICIG().DGNKCLFFMFE("\"", this.DLFMMBBLIFH);
	}

	// Token: 0x06009EC8 RID: 40648 RVA: 0x0044C4B8 File Offset: 0x0044A6B8
	private void AEKCPCJCBAH()
	{
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.EHBBFMCILPC.PDJKPFLHFLO(KDCJJBLGCBH.EHBBFMCILPC.BPFPBGGNEBM());
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
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnSaveSlotsUnlockContinueToPurchasingScreen", 0f);
		CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().ShowAndPurchaseProduct(KDCJJBLGCBH.EHBBFMCILPC.BPFPBGGNEBM(), true);
	}

	// Token: 0x06009EC9 RID: 40649 RVA: 0x0044C564 File Offset: 0x0044A764
	public void LJIOKJJLJHL()
	{
		OBHDGKFFICI productData = PurchaseManagerBridge.OOGPALHPNGM().DIOJHOIFIIH().GetProductData(KDCJJBLGCBH.EHBBFMCILPC.BPFPBGGNEBM());
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.PMABBOJDELF().HBLMGBCMBHN(KDCJJBLGCBH.EHBBFMCILPC.BPFPBGGNEBM());
		if (productData != null && ocbiopoeenj != null)
		{
			CommonUserInterface.EHBBFMCILPC.GIFCDFKBBCN(ocbiopoeenj.MBLAIKOOCFH() + "" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 1);
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("disc");
	}

	// Token: 0x06009ECA RID: 40650 RVA: 0x0044C5D8 File Offset: 0x0044A7D8
	public void HLLJKOCNBKE()
	{
		OBHDGKFFICI productData = PurchaseManagerBridge.EHBBFMCILPC.CMJKNNFMCBM().GetProductData(KDCJJBLGCBH.EHBBFMCILPC.BPFPBGGNEBM());
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.AGANFKKBPFO().FHDEDNGLNKI(KDCJJBLGCBH.EHBBFMCILPC.BPFPBGGNEBM());
		if (productData != null && ocbiopoeenj != null)
		{
			CommonUserInterface.IKNOFBFMPGA().DPJBIGPDLMB(ocbiopoeenj.DJJCDNDMAGD() + "credo" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 0);
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("achievtitle");
	}

	// Token: 0x06009ECB RID: 40651 RVA: 0x0044C64C File Offset: 0x0044A84C
	private void BLJNLBILNHF()
	{
		string text = CCOJBMMKNAP.ILACPHFEDEP().IPEIONBNIPH("$");
		text = text.Replace("c", KDCJJBLGCBH.EHBBFMCILPC.CODLPCLDCDF().ToString() ?? "OnStoryInterfaceHeaderFastForwardEnable");
		text = text.Replace("coverYear", SaveSlotsItem.IHHFIHKALED());
		CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupWithTwoButtonsAndCloseOverride(CCOJBMMKNAP.HJGDLOOHNLO().HDIPNMFHIEJ("voiceovervol"), text, CCOJBMMKNAP.PLJMLDOCPNM().GGPHHLGPMPA("OnAccountSignInRequestSuccess"), CCOJBMMKNAP.BIAEAOMHBMM().DNILNCLIHAP("OnEmailSubscribeSuccess"), new UnityAction(this.DNJMJJNJPFB), new UnityAction(this.MAKDDAIDFCI), new UnityAction(this.CPLOHENPCPJ), (DFGILFBGPLN)127, 1532f, 62);
	}

	// Token: 0x06009ECC RID: 40652 RVA: 0x0044C707 File Offset: 0x0044A907
	public void EOKDCDMHOIH(string EIFJOAOGKMO)
	{
		this.LJHAMFLLODC = false;
		this.UpdateTitle(EIFJOAOGKMO);
		this.OCKDMNKLONP();
	}

	// Token: 0x06009ECD RID: 40653 RVA: 0x0044C707 File Offset: 0x0044A907
	public void BKBCNFGBBGE(string EIFJOAOGKMO)
	{
		this.LJHAMFLLODC = false;
		this.UpdateTitle(EIFJOAOGKMO);
		this.OCKDMNKLONP();
	}

	// Token: 0x06009ECE RID: 40654 RVA: 0x00003E52 File Offset: 0x00002052
	private void GADMEEDLADA()
	{
	}

	// Token: 0x06009ECF RID: 40655 RVA: 0x0044C720 File Offset: 0x0044A920
	private void CNMDBJKENPB()
	{
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.NACPAKLINNH().IJLAPHFKPMH(KDCJJBLGCBH.EHBBFMCILPC.BPFPBGGNEBM());
		if (ocbiopoeenj != null)
		{
			ProductThumbnailManager.lastAccessedProductWebLink = ocbiopoeenj.FDMCFAHEELN() + "blur" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		}
		if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.ru && GeoLocationManager.IsRussia() && KDCJJBLGCBH.EHBBFMCILPC.EAMJBDKCDPA())
		{
			CommonUserInterface.EHBBFMCILPC.GetFader().CMMAMILHPFP(null);
			this.GMNKLLMLPOJ();
			return;
		}
		AOBJLALDBAA.CEGAOMEEFBE().KGIKHEDLPND("OnBackendUpgradeToGiftCardException", 803f);
		CommonUserInterface.IKNOFBFMPGA().GetPurchasingViewManager().CGDKCOLDBGD(KDCJJBLGCBH.EHBBFMCILPC.BPFPBGGNEBM(), false);
	}

	// Token: 0x06009ED0 RID: 40656 RVA: 0x0044C7C9 File Offset: 0x0044A9C9
	private void BELOKLLJHIJ()
	{
		AOBJLALDBAA.NMGMNAKLLMI().IHJNANKIGIB("+", this.DLFMMBBLIFH);
	}

	// Token: 0x06009ED1 RID: 40657 RVA: 0x0044C7E0 File Offset: 0x0044A9E0
	private void IEKKGNKMKIN()
	{
		PurchaseManagerBridge.EHBBFMCILPC.CMJKNNFMCBM().Initialize();
		if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.en && GeoLocationManager.PBAGPDDBABB() && KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA())
		{
			this.FBPLIKPOPLD();
			return;
		}
		CommonUserInterface.IKNOFBFMPGA().GetFader().PACBMBLIGNN(new TweenCallback(this.PGJOCMJGHGN));
	}

	// Token: 0x06009ED2 RID: 40658 RVA: 0x00003E52 File Offset: 0x00002052
	private void JOOBEBIBDGO()
	{
	}

	// Token: 0x06009ED3 RID: 40659 RVA: 0x0044C840 File Offset: 0x0044AA40
	private void JHCPEOIFFJM()
	{
		AssetAnthology assetAnthology = GKJPOGNFKNK.LDFIAOCJEOJ(this.HGGFJOKOKOD.GGICIBLJIKI);
		if (null != assetAnthology)
		{
			for (int i = 0; i < assetAnthology.header.availableStories.Count; i++)
			{
				PLFDAJJHMKO plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.PKNIPLDMJGG(assetAnthology.header.availableStories[i], this.DLFMMBBLIFH);
				if (plfdajjhmko != null)
				{
					plfdajjhmko.EPJKDCDOEMM(false);
					plfdajjhmko.DHONIOBOLEL.FCAPOHDNJBH(0);
				}
			}
			this.HGGFJOKOKOD.LDPCILACGCO(0, this.DLFMMBBLIFH);
			this.HGGFJOKOKOD.HCLKNDLEGMG(this.DLFMMBBLIFH, "fvrt");
			string text = CCOJBMMKNAP.HFAKOKBHCGH().IKMNGFIDCLM("OnLobbyStartFireworksEffectAutoHide");
			this.slotText.text = text;
			this.slotText.SetText(text, true);
			this.slotTextActive.text = text;
			this.slotTextActive.SetText(text, false);
			this.slotTextInactive.text = text;
			this.slotTextInactive.SetText(text, false);
			this.slotText.alpha = 1548f;
			this.slotTextActive.alpha = 741f;
			this.slotTextInactive.alpha = 63f;
			SaveSlotsItem.slotDeleted = false;
			if (this.DEOILFBCNCM)
			{
				AOBJLALDBAA.BIAEAOMHBMM().NGDHHFONFOM("ExploreHub.Populate() - row ", this.DLFMMBBLIFH);
			}
			else
			{
				CommonUserInterface.EHBBFMCILPC.NFBMHHPIGFA(CCOJBMMKNAP.BBGECIKOICE().BDGPNPNIAPA(""), CCOJBMMKNAP.ONCPHEEJLOP().HPOAGPJFHPM("apks1"), CCOJBMMKNAP.COKDLDOAACJ().BGELFMIOBCL("fdata"), DFGILFBGPLN.popupTools, 1089f, 123);
				this.moreButton.GetComponent<Button>().interactable = true;
			}
			this.LJHAMFLLODC = true;
			if (SaveSlotsItem.copySourceSlotIndex == this.DLFMMBBLIFH && SaveSlotsItem.copySourceAnthologyIndex == this.HGGFJOKOKOD.GGICIBLJIKI)
			{
				SaveSlotsItem.ClearCopyMarker();
			}
			this.OCKDMNKLONP();
			AOBJLALDBAA.EHBBFMCILPC.KMAGHMCCMPG("", 788f);
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("OnPopupStoryRestartManagerRestartStory3");
		}
		AKLFPGMDKLA.EHBBFMCILPC.KBKOLEJEEGH();
	}

	// Token: 0x06009ED4 RID: 40660 RVA: 0x0044CA42 File Offset: 0x0044AC42
	private bool LBLELGKCABL()
	{
		return this.LJHAMFLLODC && !this.DEOILFBCNCM && this.BEIKJBBFFLB();
	}

	// Token: 0x06009ED5 RID: 40661 RVA: 0x0044CA5C File Offset: 0x0044AC5C
	public void MCOMCHOLOOO(EIOPLEFLLIM LNFEBCFCBHG, bool BBBKJMMBHDB, bool MDDFNEICIGN, string EIFJOAOGKMO, int CCLNHHJPDGJ, bool MCNNECLBNIF)
	{
		this.DEOILFBCNCM = MDDFNEICIGN;
		this.HGGFJOKOKOD = LNFEBCFCBHG;
		this.MAAIOEIGEJN = BBBKJMMBHDB;
		this.DLFMMBBLIFH = CCLNHHJPDGJ;
		this.LJHAMFLLODC = MCNNECLBNIF;
		int num = this.DLFMMBBLIFH + 1;
		this.slotText.alpha = 1968f;
		this.slotTextActive.alpha = 1466f;
		this.slotTextInactive.alpha = 370f;
		bool flag = false;
		if (EIFJOAOGKMO == null || EIFJOAOGKMO.Length == 0)
		{
			if (this.LJHAMFLLODC)
			{
				EIFJOAOGKMO = CCOJBMMKNAP.PEBMGCKFNAO().JCDFHKDNEDH("OnAccountSignInRequestException");
				if (!MDDFNEICIGN)
				{
					this.slotText.alpha = 1293f;
					this.slotTextActive.alpha = 1301f;
					this.slotTextInactive.alpha = 1114f;
				}
				flag = true;
			}
			else
			{
				EIFJOAOGKMO = CCOJBMMKNAP.KNKGCDDMLDP().OGKGHLHHAAI("FilterAnimationScrollMoveSmooth").Replace("socialcollectedcardopenv2", num.ToString());
			}
		}
		this.slotText.text = EIFJOAOGKMO;
		this.slotText.SetText(EIFJOAOGKMO, false);
		this.slotTextActive.text = EIFJOAOGKMO;
		this.slotTextActive.SetText(EIFJOAOGKMO, false);
		this.slotTextInactive.text = EIFJOAOGKMO;
		this.slotTextInactive.SetText(EIFJOAOGKMO, true);
		this.inactivityImageText.text = (num.ToString() ?? "cardstitle");
		this.inactivityImageText.SetText(num.ToString() ?? "aind", false);
		this.inactivityImage.GetComponent<CanvasGroup>().alpha = 1450f;
		if (!BBBKJMMBHDB)
		{
			this.selectionButton.SetActive(false);
			this.selectionButtonActive.SetActive(true);
			this.selectionButtonInactive.SetActive(true);
			this.activityImage.gameObject.SetActive(true);
			this.inactivityImage.gameObject.SetActive(false);
			this.editButton.gameObject.SetActive(false);
			this.moreButton.gameObject.SetActive(true);
			this.lockButton.gameObject.SetActive(true);
		}
		else
		{
			this.selectionButtonInactive.SetActive(false);
			this.editButton.gameObject.SetActive(false);
			if (MDDFNEICIGN)
			{
				this.selectionButtonActive.SetActive(true);
				this.selectionButton.SetActive(false);
				this.activityImage.gameObject.SetActive(true);
				this.inactivityImage.gameObject.SetActive(false);
				this.moreButton.gameObject.SetActive(true);
				this.moreButton.GetComponent<Button>().interactable = false;
			}
			else
			{
				this.selectionButtonActive.SetActive(true);
				this.selectionButton.SetActive(false);
				this.activityImage.gameObject.SetActive(false);
				this.inactivityImage.gameObject.SetActive(false);
				this.moreButton.gameObject.SetActive(true);
				this.moreButton.GetComponent<Button>().interactable = false;
			}
			this.lockButton.gameObject.SetActive(true);
		}
		if (this.LJHAMFLLODC && flag)
		{
			this.moreButton.GetComponent<Button>().interactable = false;
		}
		if ((this.editButton.activeSelf || this.moreButton.activeSelf) && (!this.editButton.activeSelf || !this.moreButton.activeSelf))
		{
			this.lockButton.gameObject.SetActive(true);
		}
		this.JDEBDPLAIDJ();
	}

	// Token: 0x06009ED6 RID: 40662 RVA: 0x0044CDB8 File Offset: 0x0044AFB8
	public void PurchaseProductWeb()
	{
		OBHDGKFFICI productData = PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager().GetProductData(KDCJJBLGCBH.EHBBFMCILPC.BPFPBGGNEBM());
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.EHBBFMCILPC.PDJKPFLHFLO(KDCJJBLGCBH.EHBBFMCILPC.BPFPBGGNEBM());
		if (productData != null && ocbiopoeenj != null)
		{
			CommonUserInterface.EHBBFMCILPC.ShowPopupOnlineResources(ocbiopoeenj.MBLAIKOOCFH() + "?uid=" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 2);
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("SaveSlotObject.PurchaseProductWeb(): productData or productBalanceData is null");
	}

	// Token: 0x06009ED7 RID: 40663 RVA: 0x0044CE2C File Offset: 0x0044B02C
	public void BGFGJIFMDEO()
	{
		OBHDGKFFICI productData = PurchaseManagerBridge.KMNBCEMEBBD().JNNBFLDOOHM().GetProductData(KDCJJBLGCBH.EHBBFMCILPC.BPFPBGGNEBM());
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.JLEOPAOEFGP().HLGBFOMMJFE(KDCJJBLGCBH.EHBBFMCILPC.BPFPBGGNEBM());
		if (productData != null && ocbiopoeenj != null)
		{
			CommonUserInterface.EHBBFMCILPC.DPJBIGPDLMB(ocbiopoeenj.MBLAIKOOCFH() + "ttl" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 4);
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("lightmodebtn0");
	}

	// Token: 0x06009ED8 RID: 40664 RVA: 0x0044CE9E File Offset: 0x0044B09E
	public void PFFIPGDOPNK()
	{
		if (this.DEOILFBCNCM)
		{
			return;
		}
		if (this.MAAIOEIGEJN)
		{
			AOBJLALDBAA.CEGAOMEEFBE().IHJNANKIGIB("ACHIEVEMENTISUNLOCKED", this.DLFMMBBLIFH);
			return;
		}
		this.EGJJPACMCON();
	}

	// Token: 0x06009ED9 RID: 40665 RVA: 0x0044CED0 File Offset: 0x0044B0D0
	private bool CMOKELGDJMN()
	{
		string text = this.HGGFJOKOKOD.DMPPDOJJHHC(this.DLFMMBBLIFH);
		return text != null && text.Length > 0;
	}

	// Token: 0x06009EDA RID: 40666 RVA: 0x0044CF00 File Offset: 0x0044B100
	public void KIDOILDEFEB(EIOPLEFLLIM LNFEBCFCBHG, bool BBBKJMMBHDB, bool MDDFNEICIGN, string EIFJOAOGKMO, int CCLNHHJPDGJ, bool MCNNECLBNIF)
	{
		this.DEOILFBCNCM = MDDFNEICIGN;
		this.HGGFJOKOKOD = LNFEBCFCBHG;
		this.MAAIOEIGEJN = BBBKJMMBHDB;
		this.DLFMMBBLIFH = CCLNHHJPDGJ;
		this.LJHAMFLLODC = MCNNECLBNIF;
		int num = this.DLFMMBBLIFH + 0;
		this.slotText.alpha = 646f;
		this.slotTextActive.alpha = 1343f;
		this.slotTextInactive.alpha = 1547f;
		bool flag = true;
		if (EIFJOAOGKMO == null || EIFJOAOGKMO.Length == 0)
		{
			if (this.LJHAMFLLODC)
			{
				EIFJOAOGKMO = CCOJBMMKNAP.ONCPHEEJLOP().HHLECNIFHCO("env");
				if (!MDDFNEICIGN)
				{
					this.slotText.alpha = 1056f;
					this.slotTextActive.alpha = 1428f;
					this.slotTextInactive.alpha = 352f;
				}
				flag = true;
			}
			else
			{
				EIFJOAOGKMO = CCOJBMMKNAP.PEBMGCKFNAO().FIENAKIHNOM("bv").Replace("sketchLayers", num.ToString());
			}
		}
		this.slotText.text = EIFJOAOGKMO;
		this.slotText.SetText(EIFJOAOGKMO, true);
		this.slotTextActive.text = EIFJOAOGKMO;
		this.slotTextActive.SetText(EIFJOAOGKMO, true);
		this.slotTextInactive.text = EIFJOAOGKMO;
		this.slotTextInactive.SetText(EIFJOAOGKMO, true);
		this.inactivityImageText.text = (num.ToString() ?? "timeoutwarning");
		this.inactivityImageText.SetText(num.ToString() ?? "ad_watch_unity", false);
		this.inactivityImage.GetComponent<CanvasGroup>().alpha = 1756f;
		if (!BBBKJMMBHDB)
		{
			this.selectionButton.SetActive(true);
			this.selectionButtonActive.SetActive(false);
			this.selectionButtonInactive.SetActive(true);
			this.activityImage.gameObject.SetActive(false);
			this.inactivityImage.gameObject.SetActive(false);
			this.editButton.gameObject.SetActive(true);
			this.moreButton.gameObject.SetActive(false);
			this.lockButton.gameObject.SetActive(false);
		}
		else
		{
			this.selectionButtonInactive.SetActive(false);
			this.editButton.gameObject.SetActive(false);
			if (MDDFNEICIGN)
			{
				this.selectionButtonActive.SetActive(true);
				this.selectionButton.SetActive(true);
				this.activityImage.gameObject.SetActive(false);
				this.inactivityImage.gameObject.SetActive(false);
				this.moreButton.gameObject.SetActive(true);
				this.moreButton.GetComponent<Button>().interactable = true;
			}
			else
			{
				this.selectionButtonActive.SetActive(true);
				this.selectionButton.SetActive(true);
				this.activityImage.gameObject.SetActive(false);
				this.inactivityImage.gameObject.SetActive(true);
				this.moreButton.gameObject.SetActive(true);
				this.moreButton.GetComponent<Button>().interactable = false;
			}
			this.lockButton.gameObject.SetActive(true);
		}
		if (this.LJHAMFLLODC && flag)
		{
			this.moreButton.GetComponent<Button>().interactable = false;
		}
		if ((this.editButton.activeSelf || this.moreButton.activeSelf) && (!this.editButton.activeSelf || !this.moreButton.activeSelf))
		{
			this.lockButton.gameObject.SetActive(true);
		}
		this.JDEBDPLAIDJ();
	}

	// Token: 0x06009EDB RID: 40667 RVA: 0x0044D25B File Offset: 0x0044B45B
	public void CILEIGHFGJE(string EIFJOAOGKMO)
	{
		this.LJHAMFLLODC = true;
		this.UpdateTitle(EIFJOAOGKMO);
		this.RefreshMoreButton();
	}

	// Token: 0x06009EDC RID: 40668 RVA: 0x0044D274 File Offset: 0x0044B474
	private void IPHCIPAOAIM()
	{
		AssetAnthology assetAnthology = GKJPOGNFKNK.LDFIAOCJEOJ(this.HGGFJOKOKOD.GGICIBLJIKI);
		if (null != assetAnthology)
		{
			for (int i = 1; i < assetAnthology.header.availableStories.Count; i += 0)
			{
				PLFDAJJHMKO plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.PKNIPLDMJGG(assetAnthology.header.availableStories[i], this.DLFMMBBLIFH);
				if (plfdajjhmko != null)
				{
					plfdajjhmko.JFDJIHJBOLO(true);
					plfdajjhmko.DHONIOBOLEL.OCMODCOLBAP(0);
				}
			}
			this.HGGFJOKOKOD.JHGEEJICJAM(0, this.DLFMMBBLIFH);
			this.HGGFJOKOKOD.NIECONHEJEC(this.DLFMMBBLIFH, "sslind");
			string text = CCOJBMMKNAP.CEGAOMEEFBE().JCDFHKDNEDH("");
			this.slotText.text = text;
			this.slotText.SetText(text, false);
			this.slotTextActive.text = text;
			this.slotTextActive.SetText(text, true);
			this.slotTextInactive.text = text;
			this.slotTextInactive.SetText(text, false);
			this.slotText.alpha = 1631f;
			this.slotTextActive.alpha = 246f;
			this.slotTextInactive.alpha = 1765f;
			SaveSlotsItem.slotDeleted = false;
			if (this.DEOILFBCNCM)
			{
				AOBJLALDBAA.EHBBFMCILPC.IHJNANKIGIB("", this.DLFMMBBLIFH);
			}
			else
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.JMNIGPHCAEJ().PKNHKGMNCIP("OnPopupProfileNicknameInputCancel"), CCOJBMMKNAP.KLAKLFCOMJC().GLEFEKBDHNK("app42error"), CCOJBMMKNAP.FEEDGKCJBLE().JHNELLJFBGC("gptompatchestutorial"), (DFGILFBGPLN)(-79), 1082f, 63);
				this.moreButton.GetComponent<Button>().interactable = true;
			}
			this.LJHAMFLLODC = true;
			if (SaveSlotsItem.copySourceSlotIndex == this.DLFMMBBLIFH && SaveSlotsItem.copySourceAnthologyIndex == this.HGGFJOKOKOD.GGICIBLJIKI)
			{
				SaveSlotsItem.ClearCopyMarker();
			}
			this.JDEBDPLAIDJ();
			AOBJLALDBAA.FILDBDMENPG().EFBNBFIDEOK("p", 1949f);
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("ok");
		}
		AKLFPGMDKLA.EHBBFMCILPC.KBKOLEJEEGH();
	}

	// Token: 0x06009EDD RID: 40669 RVA: 0x0044D478 File Offset: 0x0044B678
	private void BNKAOCLJFOH()
	{
		AssetAnthology assetAnthology = GKJPOGNFKNK.LDFIAOCJEOJ(this.HGGFJOKOKOD.GGICIBLJIKI);
		if (null != assetAnthology)
		{
			for (int i = 1; i < assetAnthology.header.availableStories.Count; i += 0)
			{
				PLFDAJJHMKO plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.PKNIPLDMJGG(assetAnthology.header.availableStories[i], this.DLFMMBBLIFH);
				if (plfdajjhmko != null)
				{
					plfdajjhmko.MOCHAJPADAJ(true);
					plfdajjhmko.DHONIOBOLEL.CCLJLMNFLCI(1);
				}
			}
			this.HGGFJOKOKOD.JHGEEJICJAM(1, this.DLFMMBBLIFH);
			this.HGGFJOKOKOD.NIECONHEJEC(this.DLFMMBBLIFH, "NonPlayerCharacterManager.Initialize() - npcAsset.bodySprite (");
			string text = CCOJBMMKNAP.CEGAOMEEFBE().BGELFMIOBCL("$NOTESHOW body(");
			this.slotText.text = text;
			this.slotText.SetText(text, true);
			this.slotTextActive.text = text;
			this.slotTextActive.SetText(text, false);
			this.slotTextInactive.text = text;
			this.slotTextInactive.SetText(text, false);
			this.slotText.alpha = 119f;
			this.slotTextActive.alpha = 1769f;
			this.slotTextInactive.alpha = 674f;
			SaveSlotsItem.slotDeleted = false;
			if (this.DEOILFBCNCM)
			{
				AOBJLALDBAA.NMGMNAKLLMI().EGELHPJBAIC("scene ", this.DLFMMBBLIFH);
			}
			else
			{
				CommonUserInterface.IKNOFBFMPGA().NFBMHHPIGFA(CCOJBMMKNAP.KMNBCEMEBBD().IKMNGFIDCLM("hidestatinfo"), CCOJBMMKNAP.DLGLFACMHPG().GGPHHLGPMPA("err"), CCOJBMMKNAP.PEBMGCKFNAO().MEPECBDCOLG("،"), (DFGILFBGPLN)109, 790f, 59);
				this.moreButton.GetComponent<Button>().interactable = false;
			}
			this.LJHAMFLLODC = true;
			if (SaveSlotsItem.copySourceSlotIndex == this.DLFMMBBLIFH && SaveSlotsItem.copySourceAnthologyIndex == this.HGGFJOKOKOD.GGICIBLJIKI)
			{
				SaveSlotsItem.ClearCopyMarker();
			}
			this.BLJINDHAEHN();
			AOBJLALDBAA.AGANFKKBPFO().DCGCFPHHDDG("\n", 108f);
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("digitalglitchovr");
		}
		AKLFPGMDKLA.EHBBFMCILPC.KBKOLEJEEGH();
	}

	// Token: 0x06009EDE RID: 40670 RVA: 0x0044D67C File Offset: 0x0044B87C
	public void Initialize(EIOPLEFLLIM LNFEBCFCBHG, bool BBBKJMMBHDB, bool MDDFNEICIGN, string EIFJOAOGKMO, int CCLNHHJPDGJ, bool MCNNECLBNIF)
	{
		this.DEOILFBCNCM = MDDFNEICIGN;
		this.HGGFJOKOKOD = LNFEBCFCBHG;
		this.MAAIOEIGEJN = BBBKJMMBHDB;
		this.DLFMMBBLIFH = CCLNHHJPDGJ;
		this.LJHAMFLLODC = MCNNECLBNIF;
		int num = this.DLFMMBBLIFH + 1;
		this.slotText.alpha = 1f;
		this.slotTextActive.alpha = 1f;
		this.slotTextInactive.alpha = 1f;
		bool flag = false;
		if (EIFJOAOGKMO == null || EIFJOAOGKMO.Length == 0)
		{
			if (this.LJHAMFLLODC)
			{
				EIFJOAOGKMO = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("saveslotstitleempty");
				if (!MDDFNEICIGN)
				{
					this.slotText.alpha = 0.5f;
					this.slotTextActive.alpha = 0.5f;
					this.slotTextInactive.alpha = 0.5f;
				}
				flag = true;
			}
			else
			{
				EIFJOAOGKMO = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("saveslotstitle").Replace("XXX", num.ToString());
			}
		}
		this.slotText.text = EIFJOAOGKMO;
		this.slotText.SetText(EIFJOAOGKMO, true);
		this.slotTextActive.text = EIFJOAOGKMO;
		this.slotTextActive.SetText(EIFJOAOGKMO, true);
		this.slotTextInactive.text = EIFJOAOGKMO;
		this.slotTextInactive.SetText(EIFJOAOGKMO, true);
		this.inactivityImageText.text = (num.ToString() ?? "");
		this.inactivityImageText.SetText(num.ToString() ?? "", true);
		this.inactivityImage.GetComponent<CanvasGroup>().alpha = 0.75f;
		if (!BBBKJMMBHDB)
		{
			this.selectionButton.SetActive(false);
			this.selectionButtonActive.SetActive(false);
			this.selectionButtonInactive.SetActive(true);
			this.activityImage.gameObject.SetActive(false);
			this.inactivityImage.gameObject.SetActive(true);
			this.editButton.gameObject.SetActive(false);
			this.moreButton.gameObject.SetActive(false);
			this.lockButton.gameObject.SetActive(false);
		}
		else
		{
			this.selectionButtonInactive.SetActive(false);
			this.editButton.gameObject.SetActive(true);
			if (MDDFNEICIGN)
			{
				this.selectionButtonActive.SetActive(true);
				this.selectionButton.SetActive(false);
				this.activityImage.gameObject.SetActive(true);
				this.inactivityImage.gameObject.SetActive(false);
				this.moreButton.gameObject.SetActive(true);
				this.moreButton.GetComponent<Button>().interactable = false;
			}
			else
			{
				this.selectionButtonActive.SetActive(false);
				this.selectionButton.SetActive(true);
				this.activityImage.gameObject.SetActive(false);
				this.inactivityImage.gameObject.SetActive(true);
				this.moreButton.gameObject.SetActive(true);
				this.moreButton.GetComponent<Button>().interactable = true;
			}
			this.lockButton.gameObject.SetActive(false);
		}
		if (this.LJHAMFLLODC && flag)
		{
			this.moreButton.GetComponent<Button>().interactable = false;
		}
		if ((this.editButton.activeSelf || this.moreButton.activeSelf) && (!this.editButton.activeSelf || !this.moreButton.activeSelf))
		{
			this.lockButton.gameObject.SetActive(true);
		}
		this.RefreshMoreButton();
	}

	// Token: 0x06009EDF RID: 40671 RVA: 0x00003E52 File Offset: 0x00002052
	private void IJDCBFCKINN()
	{
	}

	// Token: 0x06009EE0 RID: 40672 RVA: 0x0044D9D7 File Offset: 0x0044BBD7
	public void LHEOFCDAOAJ()
	{
		PopupSaveSlotInput.extraData = this.DLFMMBBLIFH;
		CommonUserInterface.IKNOFBFMPGA().EADCJOPEBDM();
	}

	// Token: 0x06009EE1 RID: 40673 RVA: 0x0044D9EE File Offset: 0x0044BBEE
	public void OnEditButtonClick()
	{
		PopupSaveSlotInput.extraData = this.DLFMMBBLIFH;
		CommonUserInterface.EHBBFMCILPC.ShowPopupSaveSlotInput();
	}

	// Token: 0x06009EE2 RID: 40674 RVA: 0x0044DA05 File Offset: 0x0044BC05
	private void ABKNBOHBNLP()
	{
		this.OnDeleteButtonClick(682f);
	}

	// Token: 0x06009EE3 RID: 40675 RVA: 0x0044DA14 File Offset: 0x0044BC14
	public void OnMoreButtonClick()
	{
		if (this.HGGFJOKOKOD == null || !this.MAAIOEIGEJN)
		{
			return;
		}
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(25))
		{
			return;
		}
		if (CommonUserInterface.EHBBFMCILPC.AnyGenericPopupIsActive())
		{
			return;
		}
		string slotDisplayTitle = SaveSlotsItem.GetSlotDisplayTitle(this.HGGFJOKOKOD, this.DLFMMBBLIFH);
		if (!this.LJHAMFLLODC)
		{
			string dpjinbcgngn = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("saveslotsoptionsbody").Replace("XXX", slotDisplayTitle);
			if (this.DEOILFBCNCM)
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(slotDisplayTitle, dpjinbcgngn, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("saveslotsoptioncopy"), new UnityAction(this.BODIBIOFHJF), DFGILFBGPLN.popupTools, 0f, 28);
				return;
			}
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtonsAndCloseOverride(slotDisplayTitle, dpjinbcgngn, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("saveslotsoptiondelete"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("saveslotsoptioncopy"), new UnityAction(this.LOCFPJCBLAN), new UnityAction(this.BODIBIOFHJF), new UnityAction(this.OOHFNFEEJAM), DFGILFBGPLN.popupTools, 0f, 28);
			return;
		}
		else
		{
			bool flag = this.NKKPJMBIEIL();
			bool flag2 = this.BIINDGNAKGA();
			if (flag)
			{
				string slotDisplayTitle2 = SaveSlotsItem.GetSlotDisplayTitle(this.HGGFJOKOKOD, SaveSlotsItem.copySourceSlotIndex);
				string dpjinbcgngn2 = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("saveslotsduplicatebody").Replace("XXX", slotDisplayTitle2);
				string text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("saveslotsoptionduplicate").Replace("XXX", slotDisplayTitle2);
				if (flag2)
				{
					CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtonsAndCloseOverride(slotDisplayTitle, dpjinbcgngn2, text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("saveslotsoptiondelete"), new UnityAction(this.NCJNJLAPDNO), new UnityAction(this.LOCFPJCBLAN), new UnityAction(this.OOHFNFEEJAM), DFGILFBGPLN.popupTools, 0f, 28);
					return;
				}
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(slotDisplayTitle, dpjinbcgngn2, text, new UnityAction(this.NCJNJLAPDNO), DFGILFBGPLN.popupTools, 0f, 28);
				return;
			}
			else
			{
				if (flag2)
				{
					CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(slotDisplayTitle, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("saveslotsoptionsbody").Replace("XXX", slotDisplayTitle), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("saveslotsoptiondelete"), new UnityAction(this.LOCFPJCBLAN), DFGILFBGPLN.popupTools, 0f, 28);
					return;
				}
				this.RefreshMoreButton();
				return;
			}
		}
	}

	// Token: 0x06009EE4 RID: 40676 RVA: 0x0044DC40 File Offset: 0x0044BE40
	private void LNNECLKBHAC()
	{
		if (this.HGGFJOKOKOD == null)
		{
			return;
		}
		if (this.LJHAMFLLODC)
		{
			this.OCKDMNKLONP();
			return;
		}
		SaveSlotsItem.copySourceSlotIndex = this.DLFMMBBLIFH;
		SaveSlotsItem.copySourceAnthologyIndex = this.HGGFJOKOKOD.GGICIBLJIKI;
		FirebaseAnalyticsManager.DEALKJPEMMH().LMCJKLHOHJC(true, ((AGEHCPDNBFD)(-41)).ToString(), FFPHBMFGCNN.reqCback2.ToString(), BGHLMGPPCNN.cdnSplToSty.ToString(), true, true);
		FirebaseAnalyticsManager.COKDLDOAACJ().LMCJKLHOHJC(true, ((AGEHCPDNBFD)125).ToString(), FFPHBMFGCNN.socReport.ToString(), BGHLMGPPCNN.vidnosup.ToString() + this.DLFMMBBLIFH.ToString(), false, false);
		AOBJLALDBAA.EHBBFMCILPC.CIGLHCJDDPI("1", 48f);
		string dpjinbcgngn = CCOJBMMKNAP.BFHKGNBFHCH().IKMNGFIDCLM(" ").Replace("digitalglitchovr_1", SaveSlotsItem.GetSlotDisplayTitle(this.HGGFJOKOKOD, this.DLFMMBBLIFH));
		CommonUserInterface.IKNOFBFMPGA().ShowGenericPopup(CCOJBMMKNAP.FEEDGKCJBLE().DNILNCLIHAP(""), dpjinbcgngn, CCOJBMMKNAP.CPCOODCFDDP().HPOAGPJFHPM("no"), DFGILFBGPLN.popupOutdatedRevision, 784f, 107);
	}

	// Token: 0x06009EE5 RID: 40677 RVA: 0x00003E52 File Offset: 0x00002052
	private void FAGFKMPLFHF()
	{
	}

	// Token: 0x06009EE6 RID: 40678 RVA: 0x0044DD7C File Offset: 0x0044BF7C
	private void PFPBJJGBDDK()
	{
		this.OnDeleteButtonClick(1851f);
	}

	// Token: 0x06009EE7 RID: 40679 RVA: 0x0044DD8C File Offset: 0x0044BF8C
	public void BGHHNEGDMBL()
	{
		if (null == this.moreButton || this.HGGFJOKOKOD == null)
		{
			return;
		}
		if (!this.MAAIOEIGEJN)
		{
			return;
		}
		bool interactable = true;
		if (!this.LJHAMFLLODC)
		{
			interactable = false;
		}
		else
		{
			if (this.PDPLMOJOLCM())
			{
				interactable = false;
			}
			if (this.DKFAEOFAJEC())
			{
				interactable = true;
			}
		}
		this.moreButton.GetComponent<Button>().interactable = interactable;
	}

	// Token: 0x06009EE8 RID: 40680 RVA: 0x0044DDEC File Offset: 0x0044BFEC
	private void AKPLCAJHEKF()
	{
		PurchaseManagerBridge.KMNBCEMEBBD().FDIIEFGBEAG().Initialize();
		if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.en && GeoLocationManager.FDJONIACJKC() && KDCJJBLGCBH.EHBBFMCILPC.EAMJBDKCDPA())
		{
			this.HLLJKOCNBKE();
			return;
		}
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.GMLEJBEPKGD));
	}

	// Token: 0x06009EE9 RID: 40681 RVA: 0x0044DE4C File Offset: 0x0044C04C
	public void FBPLIKPOPLD()
	{
		OBHDGKFFICI productData = PurchaseManagerBridge.FJHKMJPFDNI().MGMDKEJBEPP().GetProductData(KDCJJBLGCBH.EHBBFMCILPC.BPFPBGGNEBM());
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.CAAKHBIFGMG().ICBJCNKKGPJ(KDCJJBLGCBH.EHBBFMCILPC.BPFPBGGNEBM());
		if (productData != null && ocbiopoeenj != null)
		{
			CommonUserInterface.IKNOFBFMPGA().GIFCDFKBBCN(ocbiopoeenj.FDMCFAHEELN() + "$USEDELAYV2" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 2);
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("CLIENT.SCREEN.AVATAR.");
	}

	// Token: 0x06009EEA RID: 40682 RVA: 0x0044DEC0 File Offset: 0x0044C0C0
	private void PEHDNDGOFCA()
	{
		AssetAnthology assetAnthology = GKJPOGNFKNK.LDFIAOCJEOJ(this.HGGFJOKOKOD.GGICIBLJIKI);
		if (null != assetAnthology)
		{
			for (int i = 1; i < assetAnthology.header.availableStories.Count; i += 0)
			{
				PLFDAJJHMKO plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.PKNIPLDMJGG(assetAnthology.header.availableStories[i], this.DLFMMBBLIFH);
				if (plfdajjhmko != null)
				{
					plfdajjhmko.EPJKDCDOEMM(true);
					plfdajjhmko.DHONIOBOLEL.LCJNGLJNCGO(0);
				}
			}
			this.HGGFJOKOKOD.JHGEEJICJAM(0, this.DLFMMBBLIFH);
			this.HGGFJOKOKOD.NIECONHEJEC(this.DLFMMBBLIFH, "CharacterRenderTexturePool");
			string text = CCOJBMMKNAP.KFDLFGHBPLP().MEPECBDCOLG("OnStoryChoiceClick");
			this.slotText.text = text;
			this.slotText.SetText(text, true);
			this.slotTextActive.text = text;
			this.slotTextActive.SetText(text, true);
			this.slotTextInactive.text = text;
			this.slotTextInactive.SetText(text, false);
			this.slotText.alpha = 201f;
			this.slotTextActive.alpha = 1673f;
			this.slotTextInactive.alpha = 521f;
			SaveSlotsItem.slotDeleted = true;
			if (this.DEOILFBCNCM)
			{
				AOBJLALDBAA.EHBBFMCILPC.GBECPMDCJAA("", this.DLFMMBBLIFH);
			}
			else
			{
				CommonUserInterface.IKNOFBFMPGA().NFBMHHPIGFA(CCOJBMMKNAP.PLJMLDOCPNM().MEPECBDCOLG("OnPostEffectSettingsChanged"), CCOJBMMKNAP.JMNIGPHCAEJ().PKNHKGMNCIP("blur"), CCOJBMMKNAP.GIOAFDDKKHI().JLBEIFLLBLO("RequestGetUserPublicProfile(): Account.Instance.userPublicProfile.modified"), (DFGILFBGPLN)(-86), 644f, 55);
				this.moreButton.GetComponent<Button>().interactable = true;
			}
			this.LJHAMFLLODC = false;
			if (SaveSlotsItem.copySourceSlotIndex == this.DLFMMBBLIFH && SaveSlotsItem.copySourceAnthologyIndex == this.HGGFJOKOKOD.GGICIBLJIKI)
			{
				SaveSlotsItem.ClearCopyMarker();
			}
			this.BGHHNEGDMBL();
			AOBJLALDBAA.BIAEAOMHBMM().KMAGHMCCMPG("+", 643f);
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("");
		}
		AKLFPGMDKLA.EHBBFMCILPC.KBKOLEJEEGH();
	}

	// Token: 0x06009EEB RID: 40683 RVA: 0x0044E0C2 File Offset: 0x0044C2C2
	private void IOGBLBJGFLJ()
	{
		AOBJLALDBAA.FILDBDMENPG().GBECPMDCJAA("credo", this.DLFMMBBLIFH);
	}

	// Token: 0x06009EEC RID: 40684 RVA: 0x0044E0D9 File Offset: 0x0044C2D9
	private bool LILAENLJFLN()
	{
		return this.LJHAMFLLODC && SaveSlotsItem.copySourceSlotIndex != this.DLFMMBBLIFH && SaveSlotsItem.CHFGNJKAAAI(this.DLFMMBBLIFH) && SaveSlotsItem.FAEPDMCHLHG(this.HGGFJOKOKOD);
	}

	// Token: 0x06009EED RID: 40685 RVA: 0x00003E52 File Offset: 0x00002052
	private void HMMLCHDFFBI()
	{
	}

	// Token: 0x06009EEE RID: 40686 RVA: 0x0044E10C File Offset: 0x0044C30C
	private void CDNPMKMPOPG()
	{
		string text = CCOJBMMKNAP.BBGECIKOICE().OBDCPLLLGBB("CharacterRenderTexturePool");
		text = text.Replace("", KDCJJBLGCBH.EHBBFMCILPC.CODLPCLDCDF().ToString() ?? "chass");
		text = text.Replace("HD", SaveSlotsItem.IHHFIHKALED());
		CommonUserInterface.EHBBFMCILPC.NPIOKKDPALC(CCOJBMMKNAP.JMNIGPHCAEJ().JCDFHKDNEDH("youreceived"), text, CCOJBMMKNAP.PKEINLPIAEH().BDGPNPNIAPA("'"), CCOJBMMKNAP.OEPENBHJAHO().GLEFEKBDHNK("_ScanLineJitter"), new UnityAction(this.IEKKGNKMKIN), new UnityAction(this.CPLOHENPCPJ), new UnityAction(this.JICMJOPDLAB), (DFGILFBGPLN)127, 1653f, 59);
	}

	// Token: 0x06009EEF RID: 40687 RVA: 0x0044E1C8 File Offset: 0x0044C3C8
	private void EGJJPACMCON()
	{
		string text = CCOJBMMKNAP.HJGDLOOHNLO().IKMNGFIDCLM(", day ");
		text = text.Replace(" ", KDCJJBLGCBH.EHBBFMCILPC.CODLPCLDCDF().ToString() ?? "OnGenericPopupManagerHide");
		text = text.Replace("null", SaveSlotsItem.IHHFIHKALED());
		CommonUserInterface.EHBBFMCILPC.NPIOKKDPALC(CCOJBMMKNAP.ILACPHFEDEP().HPOAGPJFHPM(""), text, CCOJBMMKNAP.KFDLFGHBPLP().IKMNGFIDCLM("yes"), CCOJBMMKNAP.BIAEAOMHBMM().BDGPNPNIAPA("newpattern"), new UnityAction(this.DNJMJJNJPFB), new UnityAction(this.JLOJHPPLKED), new UnityAction(this.CEGILBFGAGL), (DFGILFBGPLN)(-114), 184f, -83);
	}

	// Token: 0x06009EF0 RID: 40688 RVA: 0x0044E284 File Offset: 0x0044C484
	private void HIHEDMNMNFM()
	{
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.NACPAKLINNH().EPNHMLIJCCM(KDCJJBLGCBH.EHBBFMCILPC.BPFPBGGNEBM());
		if (ocbiopoeenj != null)
		{
			ProductThumbnailManager.lastAccessedProductWebLink = ocbiopoeenj.BIKJFCLHPBK() + "lsenvdrop" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		}
		if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.ru && GeoLocationManager.OOCDLFJKLLI() && KDCJJBLGCBH.EHBBFMCILPC.EAMJBDKCDPA())
		{
			CommonUserInterface.EHBBFMCILPC.GetFader().GLCPCAHKFOB(null);
			this.LJIOKJJLJHL();
			return;
		}
		AOBJLALDBAA.NMGMNAKLLMI().LPNCDPHNBJK("BackendOperationsManager.RequestStartPlayChapter, exception while initializing RSACryptoServiceProvider:", 1297f);
		CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().ShowAndPurchaseProduct(KDCJJBLGCBH.EHBBFMCILPC.BPFPBGGNEBM(), false);
	}

	// Token: 0x06009EF1 RID: 40689 RVA: 0x0044E32D File Offset: 0x0044C52D
	public void DDDMBLOBIIC()
	{
		PopupSaveSlotInput.extraData = this.DLFMMBBLIFH;
		CommonUserInterface.IKNOFBFMPGA().ShowPopupSaveSlotInput();
	}

	// Token: 0x06009EF2 RID: 40690 RVA: 0x00003E52 File Offset: 0x00002052
	private void LGAJIIKIHHM()
	{
	}

	// Token: 0x06009EF3 RID: 40691 RVA: 0x0044E344 File Offset: 0x0044C544
	public void CNNKHOPNONC()
	{
		this.EGJJPACMCON();
	}

	// Token: 0x06009EF4 RID: 40692 RVA: 0x00003E52 File Offset: 0x00002052
	private void GOCGNPBBCIO()
	{
	}

	// Token: 0x06009EF5 RID: 40693 RVA: 0x0044E34C File Offset: 0x0044C54C
	public void CMFJCNCPGJF()
	{
		OBHDGKFFICI productData = PurchaseManagerBridge.KMNBCEMEBBD().JNNBFLDOOHM().GetProductData(KDCJJBLGCBH.EHBBFMCILPC.BPFPBGGNEBM());
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.BBGECIKOICE().DCCLKMCBPPJ(KDCJJBLGCBH.EHBBFMCILPC.BPFPBGGNEBM());
		if (productData != null && ocbiopoeenj != null)
		{
			CommonUserInterface.EHBBFMCILPC.GIFCDFKBBCN(ocbiopoeenj.BIKJFCLHPBK() + "environment " + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 1);
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("");
	}

	// Token: 0x06009EF6 RID: 40694 RVA: 0x0044E3BE File Offset: 0x0044C5BE
	private void KMOICMOLMMN()
	{
		this.OnDeleteButtonClick(1865f);
	}

	// Token: 0x06009EF7 RID: 40695 RVA: 0x0044E3CC File Offset: 0x0044C5CC
	public void JDEBDPLAIDJ()
	{
		if (null == this.moreButton || this.HGGFJOKOKOD == null)
		{
			return;
		}
		if (!this.MAAIOEIGEJN)
		{
			return;
		}
		bool interactable = false;
		if (!this.LJHAMFLLODC)
		{
			interactable = true;
		}
		else
		{
			if (this.MBCKLEEDKMM())
			{
				interactable = false;
			}
			if (this.LBLELGKCABL())
			{
				interactable = false;
			}
		}
		this.moreButton.GetComponent<Button>().interactable = interactable;
	}

	// Token: 0x06009EF8 RID: 40696 RVA: 0x00003E52 File Offset: 0x00002052
	private void JLOJHPPLKED()
	{
	}

	// Token: 0x06009EF9 RID: 40697 RVA: 0x0044E42C File Offset: 0x0044C62C
	private bool ACLNMHDJJGN()
	{
		return !this.LJHAMFLLODC || SaveSlotsItem.copySourceSlotIndex == this.DLFMMBBLIFH || !SaveSlotsItem.CHFGNJKAAAI(this.DLFMMBBLIFH) || SaveSlotsItem.FAEPDMCHLHG(this.HGGFJOKOKOD);
	}

	// Token: 0x06009EFA RID: 40698 RVA: 0x0044E45D File Offset: 0x0044C65D
	private void LOCFPJCBLAN()
	{
		this.OnDeleteButtonClick(0.25f);
	}

	// Token: 0x06009EFB RID: 40699 RVA: 0x0044E46C File Offset: 0x0044C66C
	private void BKGFLAOJPJN()
	{
		PurchaseManagerBridge.FJHKMJPFDNI().FDIIEFGBEAG().Initialize();
		if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.ru && GeoLocationManager.OOCDLFJKLLI() && KDCJJBLGCBH.EHBBFMCILPC.EAMJBDKCDPA())
		{
			this.LJIOKJJLJHL();
			return;
		}
		CommonUserInterface.IKNOFBFMPGA().GetFader().BJIGLKGLAKM(new TweenCallback(this.FJMNFOHNCCJ));
	}

	// Token: 0x06009EFC RID: 40700 RVA: 0x0044E4CC File Offset: 0x0044C6CC
	private void DLBEODHCKIN()
	{
		string text = CCOJBMMKNAP.EHBBFMCILPC.JHNELLJFBGC("{n}");
		text = text.Replace("OnPurchasingViewLeave", KDCJJBLGCBH.EHBBFMCILPC.CODLPCLDCDF().ToString() ?? "areyousure");
		text = text.Replace("DEFAULTLANG", SaveSlotsItem.GetLocalizedCostData());
		CommonUserInterface.IKNOFBFMPGA().NPIOKKDPALC(CCOJBMMKNAP.EAIAHCBAIEJ().JHNELLJFBGC("WWW"), text, CCOJBMMKNAP.PMABBOJDELF().HHLECNIFHCO("OnFriendsPopupRemovFromFavClick"), CCOJBMMKNAP.MPCBJEIMACA().FIENAKIHNOM("errortitle"), new UnityAction(this.IMHCODMFMMK), new UnityAction(this.CPLOHENPCPJ), new UnityAction(this.MAKDDAIDFCI), DFGILFBGPLN.popupGamePassDurationOffer, 527f, 104);
	}

	// Token: 0x06009EFD RID: 40701 RVA: 0x0044E588 File Offset: 0x0044C788
	private void BODIBIOFHJF()
	{
		if (this.HGGFJOKOKOD == null)
		{
			return;
		}
		if (this.LJHAMFLLODC)
		{
			this.RefreshMoreButton();
			return;
		}
		SaveSlotsItem.copySourceSlotIndex = this.DLFMMBBLIFH;
		SaveSlotsItem.copySourceAnthologyIndex = this.HGGFJOKOKOD.GGICIBLJIKI;
		FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.saveSlts.ToString(), FFPHBMFGCNN.sltCopy.ToString(), BGHLMGPPCNN.slt.ToString(), false, false);
		FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.saveSlts.ToString(), FFPHBMFGCNN.sltCopy.ToString(), BGHLMGPPCNN.slt.ToString() + this.DLFMMBBLIFH.ToString(), false, false);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnSaveSlotCopyMarked", 0f);
		string dpjinbcgngn = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("saveslotscopymarked").Replace("XXX", SaveSlotsItem.GetSlotDisplayTitle(this.HGGFJOKOKOD, this.DLFMMBBLIFH));
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), dpjinbcgngn, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0.25f, 28);
	}

	// Token: 0x06009EFE RID: 40702 RVA: 0x0044E6C4 File Offset: 0x0044C8C4
	public void JLEDOPOIJJO(EIOPLEFLLIM LNFEBCFCBHG, bool BBBKJMMBHDB, bool MDDFNEICIGN, string EIFJOAOGKMO, int CCLNHHJPDGJ, bool MCNNECLBNIF)
	{
		this.DEOILFBCNCM = MDDFNEICIGN;
		this.HGGFJOKOKOD = LNFEBCFCBHG;
		this.MAAIOEIGEJN = BBBKJMMBHDB;
		this.DLFMMBBLIFH = CCLNHHJPDGJ;
		this.LJHAMFLLODC = MCNNECLBNIF;
		int num = this.DLFMMBBLIFH + 0;
		this.slotText.alpha = 387f;
		this.slotTextActive.alpha = 76f;
		this.slotTextInactive.alpha = 39f;
		bool flag = true;
		if (EIFJOAOGKMO == null || EIFJOAOGKMO.Length == 0)
		{
			if (this.LJHAMFLLODC)
			{
				EIFJOAOGKMO = CCOJBMMKNAP.KFDLFGHBPLP().MEPECBDCOLG("fdiood");
				if (!MDDFNEICIGN)
				{
					this.slotText.alpha = 1531f;
					this.slotTextActive.alpha = 1017f;
					this.slotTextInactive.alpha = 1188f;
				}
				flag = true;
			}
			else
			{
				EIFJOAOGKMO = CCOJBMMKNAP.PEBMGCKFNAO().PKNHKGMNCIP("OnPremiumChoiceExecuted").Replace("", num.ToString());
			}
		}
		this.slotText.text = EIFJOAOGKMO;
		this.slotText.SetText(EIFJOAOGKMO, true);
		this.slotTextActive.text = EIFJOAOGKMO;
		this.slotTextActive.SetText(EIFJOAOGKMO, true);
		this.slotTextInactive.text = EIFJOAOGKMO;
		this.slotTextInactive.SetText(EIFJOAOGKMO, true);
		this.inactivityImageText.text = (num.ToString() ?? "socialcardhintoncopiesv2");
		this.inactivityImageText.SetText(num.ToString() ?? "p", false);
		this.inactivityImage.GetComponent<CanvasGroup>().alpha = 19f;
		if (!BBBKJMMBHDB)
		{
			this.selectionButton.SetActive(false);
			this.selectionButtonActive.SetActive(true);
			this.selectionButtonInactive.SetActive(false);
			this.activityImage.gameObject.SetActive(false);
			this.inactivityImage.gameObject.SetActive(false);
			this.editButton.gameObject.SetActive(true);
			this.moreButton.gameObject.SetActive(true);
			this.lockButton.gameObject.SetActive(false);
		}
		else
		{
			this.selectionButtonInactive.SetActive(true);
			this.editButton.gameObject.SetActive(true);
			if (MDDFNEICIGN)
			{
				this.selectionButtonActive.SetActive(false);
				this.selectionButton.SetActive(false);
				this.activityImage.gameObject.SetActive(false);
				this.inactivityImage.gameObject.SetActive(true);
				this.moreButton.gameObject.SetActive(false);
				this.moreButton.GetComponent<Button>().interactable = true;
			}
			else
			{
				this.selectionButtonActive.SetActive(true);
				this.selectionButton.SetActive(true);
				this.activityImage.gameObject.SetActive(false);
				this.inactivityImage.gameObject.SetActive(true);
				this.moreButton.gameObject.SetActive(true);
				this.moreButton.GetComponent<Button>().interactable = false;
			}
			this.lockButton.gameObject.SetActive(false);
		}
		if (this.LJHAMFLLODC && flag)
		{
			this.moreButton.GetComponent<Button>().interactable = false;
		}
		if ((this.editButton.activeSelf || this.moreButton.activeSelf) && (!this.editButton.activeSelf || !this.moreButton.activeSelf))
		{
			this.lockButton.gameObject.SetActive(false);
		}
		this.RefreshMoreButton();
	}

	// Token: 0x06009F00 RID: 40704 RVA: 0x0044EA30 File Offset: 0x0044CC30
	public void AAEODFLCIMH()
	{
		if (this.HGGFJOKOKOD == null || !this.MAAIOEIGEJN)
		{
			return;
		}
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(50))
		{
			return;
		}
		if (CommonUserInterface.EHBBFMCILPC.LHBOBMDENGJ())
		{
			return;
		}
		string text = SaveSlotsItem.OPKHNJFFHDD(this.HGGFJOKOKOD, this.DLFMMBBLIFH);
		if (!this.LJHAMFLLODC)
		{
			string dpjinbcgngn = CCOJBMMKNAP.BFHKGNBFHCH().HIPJILDCHJC("").Replace("OnEmailUnsubscribeSuccess", text);
			if (this.DEOILFBCNCM)
			{
				CommonUserInterface.IKNOFBFMPGA().BGJFCEEDGFJ(text, dpjinbcgngn, CCOJBMMKNAP.EHBBFMCILPC.GGPHHLGPMPA("OnPopupStoryRestartManagerRestartChapter"), new UnityAction(this.DBPMGPOCCOJ), DFGILFBGPLN.popupBackendErrorStartPlayChapter, 1858f, -63);
				return;
			}
			CommonUserInterface.IKNOFBFMPGA().NPIOKKDPALC(text, dpjinbcgngn, CCOJBMMKNAP.KMNBCEMEBBD().OBDCPLLLGBB(" month row(s)"), CCOJBMMKNAP.KFAABHHGOPO().BDGPNPNIAPA("errortitle"), new UnityAction(this.ABKNBOHBNLP), new UnityAction(this.BODIBIOFHJF), new UnityAction(this.OIHLJHLBBEN), (DFGILFBGPLN)(-49), 1488f, 80);
			return;
		}
		else
		{
			bool flag = this.MBCKLEEDKMM();
			bool flag2 = this.BIINDGNAKGA();
			if (flag)
			{
				string newValue = SaveSlotsItem.OPKHNJFFHDD(this.HGGFJOKOKOD, SaveSlotsItem.copySourceSlotIndex);
				string dpjinbcgngn2 = CCOJBMMKNAP.CPCOODCFDDP().JCDFHKDNEDH("yes").Replace("layervideo", newValue);
				string text2 = CCOJBMMKNAP.PKEINLPIAEH().DNILNCLIHAP("OnPopupProfileCredoInputEndEdit").Replace("pmterror003", newValue);
				if (flag2)
				{
					CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtonsAndCloseOverride(text, dpjinbcgngn2, text2, CCOJBMMKNAP.CPCOODCFDDP().HDIPNMFHIEJ("lksrc"), new UnityAction(this.CMCIIFDCECH), new UnityAction(this.KDBHMAAFIFM), new UnityAction(this.GGHKHKBDOFG), (DFGILFBGPLN)(-105), 1659f, 111);
					return;
				}
				CommonUserInterface.EHBBFMCILPC.PEBIFCENHAL(text, dpjinbcgngn2, text2, new UnityAction(this.JDGCJAKGNDE), (DFGILFBGPLN)82, 1247f, 42);
				return;
			}
			else
			{
				if (flag2)
				{
					CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupOneOverride(text, CCOJBMMKNAP.HJGDLOOHNLO().HHLECNIFHCO("OnBackendUndoPremiumChoiceException").Replace("@", text), CCOJBMMKNAP.OEPENBHJAHO().OBDCPLLLGBB("Account.GetStorySaveUnsafe(), tempAnthologyAsset is null, using default slot index."), new UnityAction(this.KKJDENAHPAB), (DFGILFBGPLN)100, 1745f, 54);
					return;
				}
				this.BGHHNEGDMBL();
				return;
			}
		}
	}

	// Token: 0x06009F01 RID: 40705 RVA: 0x0044EC5A File Offset: 0x0044CE5A
	private void NFFOMAIFPAB()
	{
		AOBJLALDBAA.FILDBDMENPG().DGNKCLFFMFE("' (", this.DLFMMBBLIFH);
	}

	// Token: 0x06009F02 RID: 40706 RVA: 0x0044EC74 File Offset: 0x0044CE74
	private void MABGDMPGAPL()
	{
		AssetAnthology assetAnthology = GKJPOGNFKNK.LDFIAOCJEOJ(this.HGGFJOKOKOD.GGICIBLJIKI);
		if (null != assetAnthology)
		{
			for (int i = 1; i < assetAnthology.header.availableStories.Count; i += 0)
			{
				PLFDAJJHMKO plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.PKNIPLDMJGG(assetAnthology.header.availableStories[i], this.DLFMMBBLIFH);
				if (plfdajjhmko != null)
				{
					plfdajjhmko.MOCHAJPADAJ(false);
					plfdajjhmko.DHONIOBOLEL.JDDCOBAEOMJ(0);
				}
			}
			this.HGGFJOKOKOD.LDPCILACGCO(0, this.DLFMMBBLIFH);
			this.HGGFJOKOKOD.NIECONHEJEC(this.DLFMMBBLIFH, ">");
			string text = CCOJBMMKNAP.ILACPHFEDEP().IKMNGFIDCLM("rtng");
			this.slotText.text = text;
			this.slotText.SetText(text, true);
			this.slotTextActive.text = text;
			this.slotTextActive.SetText(text, false);
			this.slotTextInactive.text = text;
			this.slotTextInactive.SetText(text, false);
			this.slotText.alpha = 1289f;
			this.slotTextActive.alpha = 1897f;
			this.slotTextInactive.alpha = 72f;
			SaveSlotsItem.slotDeleted = false;
			if (this.DEOILFBCNCM)
			{
				AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("gfts", this.DLFMMBBLIFH);
			}
			else
			{
				CommonUserInterface.IKNOFBFMPGA().NFBMHHPIGFA(CCOJBMMKNAP.JMNIGPHCAEJ().OHLNGCKIACD(" "), CCOJBMMKNAP.HFAKOKBHCGH().OGKGHLHHAAI(" already listed by an earlier franchise, skipping"), CCOJBMMKNAP.ONCPHEEJLOP().FIENAKIHNOM("TextRaycastZone"), DFGILFBGPLN.screenHub, 1273f, -123);
				this.moreButton.GetComponent<Button>().interactable = false;
			}
			this.LJHAMFLLODC = true;
			if (SaveSlotsItem.copySourceSlotIndex == this.DLFMMBBLIFH && SaveSlotsItem.copySourceAnthologyIndex == this.HGGFJOKOKOD.GGICIBLJIKI)
			{
				SaveSlotsItem.ClearCopyMarker();
			}
			this.OCKDMNKLONP();
			AOBJLALDBAA.AGANFKKBPFO().EFBNBFIDEOK(" having a percent of ", 1540f);
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("post");
		}
		AKLFPGMDKLA.EHBBFMCILPC.KBKOLEJEEGH();
	}

	// Token: 0x06009F03 RID: 40707 RVA: 0x00003E52 File Offset: 0x00002052
	private void ICOHJDCAJDA()
	{
	}

	// Token: 0x06009F04 RID: 40708 RVA: 0x0044EE78 File Offset: 0x0044D078
	public void UpdateTitle(string EIFJOAOGKMO)
	{
		this.slotText.alpha = 1f;
		this.slotTextActive.alpha = 1f;
		this.slotTextInactive.alpha = 1f;
		if (EIFJOAOGKMO == null || EIFJOAOGKMO.Length == 0)
		{
			int num = this.DLFMMBBLIFH + 1;
			if (this.LJHAMFLLODC)
			{
				EIFJOAOGKMO = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("saveslotstitleempty");
				if (!this.DEOILFBCNCM)
				{
					this.slotText.alpha = 0.5f;
					this.slotTextActive.alpha = 0.5f;
					this.slotTextInactive.alpha = 0.5f;
				}
			}
			else
			{
				EIFJOAOGKMO = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("saveslotstitle").Replace("XXX", num.ToString());
				if (!this.DEOILFBCNCM)
				{
					this.moreButton.GetComponent<Button>().interactable = true;
				}
			}
		}
		else if (!this.DEOILFBCNCM)
		{
			this.moreButton.GetComponent<Button>().interactable = true;
		}
		this.slotText.text = EIFJOAOGKMO;
		this.slotText.SetText(EIFJOAOGKMO, true);
		this.slotTextActive.text = EIFJOAOGKMO;
		this.slotTextActive.SetText(EIFJOAOGKMO, true);
		this.slotTextInactive.text = EIFJOAOGKMO;
		this.slotTextInactive.SetText(EIFJOAOGKMO, true);
		this.RefreshMoreButton();
	}

	// Token: 0x06009F05 RID: 40709 RVA: 0x0044EFC9 File Offset: 0x0044D1C9
	private void KDBHMAAFIFM()
	{
		this.OnDeleteButtonClick(383f);
	}

	// Token: 0x06009F06 RID: 40710 RVA: 0x0044EFD8 File Offset: 0x0044D1D8
	private void AGAACNEAFMC()
	{
		PurchaseManagerBridge.LMCCLMFGEBD().GetPurchaseManager().Initialize();
		if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.en && GeoLocationManager.FDJONIACJKC() && KDCJJBLGCBH.EHBBFMCILPC.EAMJBDKCDPA())
		{
			this.LJIOKJJLJHL();
			return;
		}
		CommonUserInterface.IKNOFBFMPGA().GetFader().FadeIn(new TweenCallback(this.CNMDBJKENPB));
	}

	// Token: 0x06009F07 RID: 40711 RVA: 0x0044F038 File Offset: 0x0044D238
	private bool OCNMMAICOJJ()
	{
		string text = this.HGGFJOKOKOD.BFCBDALFNHA(this.DLFMMBBLIFH);
		return text != null && text.Length > 1;
	}

	// Token: 0x06009F08 RID: 40712 RVA: 0x0044F065 File Offset: 0x0044D265
	private bool BIINDGNAKGA()
	{
		return this.LJHAMFLLODC && !this.DEOILFBCNCM && this.JMHIGCIGDML();
	}

	// Token: 0x06009F09 RID: 40713 RVA: 0x0044F07F File Offset: 0x0044D27F
	public void OnLockButtonClick()
	{
		this.ANEGLHMMKHA();
	}

	// Token: 0x06009F0A RID: 40714 RVA: 0x0044F088 File Offset: 0x0044D288
	private void NJHEMMLPKAJ()
	{
		AssetAnthology assetAnthology = GKJPOGNFKNK.LDFIAOCJEOJ(this.HGGFJOKOKOD.GGICIBLJIKI);
		if (null != assetAnthology)
		{
			for (int i = 0; i < assetAnthology.header.availableStories.Count; i++)
			{
				PLFDAJJHMKO plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.PKNIPLDMJGG(assetAnthology.header.availableStories[i], this.DLFMMBBLIFH);
				if (plfdajjhmko != null)
				{
					plfdajjhmko.EPJKDCDOEMM(true);
					plfdajjhmko.DHONIOBOLEL.NJPFIIDIABG(0);
				}
			}
			this.HGGFJOKOKOD.LDPCILACGCO(0, this.DLFMMBBLIFH);
			this.HGGFJOKOKOD.NIECONHEJEC(this.DLFMMBBLIFH, "");
			string text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("saveslotstitleempty");
			this.slotText.text = text;
			this.slotText.SetText(text, true);
			this.slotTextActive.text = text;
			this.slotTextActive.SetText(text, true);
			this.slotTextInactive.text = text;
			this.slotTextInactive.SetText(text, true);
			this.slotText.alpha = 0.5f;
			this.slotTextActive.alpha = 0.5f;
			this.slotTextInactive.alpha = 0.5f;
			SaveSlotsItem.slotDeleted = true;
			if (this.DEOILFBCNCM)
			{
				AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnSaveSlotDelete", this.DLFMMBBLIFH);
			}
			else
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("saveslotsdeletepos"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0.25f, 28);
				this.moreButton.GetComponent<Button>().interactable = false;
			}
			this.LJHAMFLLODC = true;
			if (SaveSlotsItem.copySourceSlotIndex == this.DLFMMBBLIFH && SaveSlotsItem.copySourceAnthologyIndex == this.HGGFJOKOKOD.GGICIBLJIKI)
			{
				SaveSlotsItem.ClearCopyMarker();
			}
			this.RefreshMoreButton();
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnSaveSlotCopyMarked", 0f);
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("OnDeleteButtonPositive(): currentAnthology is null");
		}
		AKLFPGMDKLA.EHBBFMCILPC.KBKOLEJEEGH();
	}

	// Token: 0x06009F0B RID: 40715 RVA: 0x0044F28C File Offset: 0x0044D48C
	private void HKHGAMOEDCB()
	{
		string text = CCOJBMMKNAP.PKEINLPIAEH().JHNELLJFBGC("sto");
		text = text.Replace("p", KDCJJBLGCBH.EHBBFMCILPC.CODLPCLDCDF().ToString() ?? "abpd3");
		text = text.Replace("WWW", SaveSlotsItem.IHHFIHKALED());
		CommonUserInterface.IKNOFBFMPGA().NPIOKKDPALC(CCOJBMMKNAP.KFAABHHGOPO().IKMNGFIDCLM("OnPurchasingViewLeave"), text, CCOJBMMKNAP.DBFFFOMCLKM().HIPJILDCHJC(" searchCards="), CCOJBMMKNAP.BFHKGNBFHCH().PPALCPINPLK("SaveSlotsItem.GetLocalizedCostData() - productData is null."), new UnityAction(this.AKPLCAJHEKF), new UnityAction(this.MAKDDAIDFCI), new UnityAction(this.CEGILBFGAGL), (DFGILFBGPLN)(-65), 908f, 119);
	}

	// Token: 0x06009F0C RID: 40716 RVA: 0x00449BC3 File Offset: 0x00447DC3
	public void DNLOCLEGLMO(string EIFJOAOGKMO)
	{
		this.LJHAMFLLODC = true;
		this.NPIMIANPNJL(EIFJOAOGKMO);
		this.JDEBDPLAIDJ();
	}

	// Token: 0x06009F0D RID: 40717 RVA: 0x0044F347 File Offset: 0x0044D547
	public void IDJGJOFFKGC(string EIFJOAOGKMO)
	{
		this.LJHAMFLLODC = false;
		this.NPIMIANPNJL(EIFJOAOGKMO);
		this.JDEBDPLAIDJ();
	}

	// Token: 0x06009F0E RID: 40718 RVA: 0x0044F35D File Offset: 0x0044D55D
	private void NCJNJLAPDNO()
	{
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnSaveSlotDuplicateRequested", this.DLFMMBBLIFH);
	}

	// Token: 0x06009F0F RID: 40719 RVA: 0x0044F374 File Offset: 0x0044D574
	public void PAHNLGJPDPL()
	{
		if (this.HGGFJOKOKOD == null || !this.MAAIOEIGEJN)
		{
			return;
		}
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(-42))
		{
			return;
		}
		if (CommonUserInterface.EHBBFMCILPC.AnyGenericPopupIsActive())
		{
			return;
		}
		string slotDisplayTitle = SaveSlotsItem.GetSlotDisplayTitle(this.HGGFJOKOKOD, this.DLFMMBBLIFH);
		if (!this.LJHAMFLLODC)
		{
			string dpjinbcgngn = CCOJBMMKNAP.AEELGGPEJCC().FIENAKIHNOM("iat1").Replace("black", slotDisplayTitle);
			if (this.DEOILFBCNCM)
			{
				CommonUserInterface.IKNOFBFMPGA().BGJFCEEDGFJ(slotDisplayTitle, dpjinbcgngn, CCOJBMMKNAP.ILACPHFEDEP().DNILNCLIHAP("XXX"), new UnityAction(this.DGLNFFMJLOP), (DFGILFBGPLN)111, 75f, 95);
				return;
			}
			CommonUserInterface.EHBBFMCILPC.NPIOKKDPALC(slotDisplayTitle, dpjinbcgngn, CCOJBMMKNAP.BFHKGNBFHCH().JHNELLJFBGC("OnAppleLoginSuccess"), CCOJBMMKNAP.COKDLDOAACJ().PGKBCNBAOJN("_"), new UnityAction(this.LOCFPJCBLAN), new UnityAction(this.DBPMGPOCCOJ), new UnityAction(this.FKIHKNMNJEH), (DFGILFBGPLN)(-111), 296f, 24);
			return;
		}
		else
		{
			bool flag = this.PDPLMOJOLCM();
			bool flag2 = this.LBLELGKCABL();
			if (flag)
			{
				string newValue = SaveSlotsItem.OPKHNJFFHDD(this.HGGFJOKOKOD, SaveSlotsItem.copySourceSlotIndex);
				string dpjinbcgngn2 = CCOJBMMKNAP.FEEDGKCJBLE().OBDCPLLLGBB("Trading/Wished cards userPublicProfile.modified = true hit").Replace("app42error", newValue);
				string text = CCOJBMMKNAP.OBOOKJPGBJN().FCOCLEHKLDJ("SceneLobbyManager2.OnLiveProfileThumbnailsCdnFailed()").Replace("a", newValue);
				if (flag2)
				{
					CommonUserInterface.EHBBFMCILPC.NPIOKKDPALC(slotDisplayTitle, dpjinbcgngn2, text, CCOJBMMKNAP.BBGECIKOICE().FIENAKIHNOM("cardcollectcardismissing"), new UnityAction(this.NCJNJLAPDNO), new UnityAction(this.PFPBJJGBDDK), new UnityAction(this.OIHLJHLBBEN), (DFGILFBGPLN)(-120), 1929f, 4);
					return;
				}
				CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupOneOverride(slotDisplayTitle, dpjinbcgngn2, text, new UnityAction(this.CMCIIFDCECH), (DFGILFBGPLN)127, 809f, 24);
				return;
			}
			else
			{
				if (flag2)
				{
					CommonUserInterface.IKNOFBFMPGA().PEBIFCENHAL(slotDisplayTitle, CCOJBMMKNAP.PKEINLPIAEH().BDGPNPNIAPA("").Replace("[LoadingEnv] ", slotDisplayTitle), CCOJBMMKNAP.MPCBJEIMACA().IKMNGFIDCLM("SetFilteredItemVisibleArea"), new UnityAction(this.IPEKAPHJHDM), (DFGILFBGPLN)(-100), 1887f, 57);
					return;
				}
				this.OCKDMNKLONP();
				return;
			}
		}
	}

	// Token: 0x06009F10 RID: 40720 RVA: 0x0044F59E File Offset: 0x0044D79E
	private void IPEKAPHJHDM()
	{
		this.ONDHNAMJBHP(721f);
	}

	// Token: 0x04002BE4 RID: 11236
	public const string onSaveSlotsUnlockContinueToPurchasingScreen = "OnSaveSlotsUnlockContinueToPurchasingScreen";

	// Token: 0x04002BE5 RID: 11237
	public const string onSaveSlotSelect = "OnSaveSlotSelect";

	// Token: 0x04002BE6 RID: 11238
	public const string onSaveSlotDelete = "OnSaveSlotDelete";

	// Token: 0x04002BE7 RID: 11239
	public const string onSaveSlotCopyMarked = "OnSaveSlotCopyMarked";

	// Token: 0x04002BE8 RID: 11240
	public const string onSaveSlotDuplicateRequested = "OnSaveSlotDuplicateRequested";

	// Token: 0x04002BE9 RID: 11241
	public GameObject activityImage;

	// Token: 0x04002BEA RID: 11242
	public GameObject inactivityImage;

	// Token: 0x04002BEB RID: 11243
	public TextMeshProUGUI inactivityImageText;

	// Token: 0x04002BEC RID: 11244
	public GameObject selectionButton;

	// Token: 0x04002BED RID: 11245
	public GameObject selectionButtonActive;

	// Token: 0x04002BEE RID: 11246
	public GameObject selectionButtonInactive;

	// Token: 0x04002BEF RID: 11247
	public GameObject editButton;

	// Token: 0x04002BF0 RID: 11248
	[FormerlySerializedAs("deleteButton")]
	public GameObject moreButton;

	// Token: 0x04002BF1 RID: 11249
	public GameObject lockButton;

	// Token: 0x04002BF2 RID: 11250
	public TextMeshProUGUI slotText;

	// Token: 0x04002BF3 RID: 11251
	public TextMeshProUGUI slotTextActive;

	// Token: 0x04002BF4 RID: 11252
	public TextMeshProUGUI slotTextInactive;

	// Token: 0x04002BF5 RID: 11253
	private bool MAAIOEIGEJN;

	// Token: 0x04002BF6 RID: 11254
	private bool DEOILFBCNCM;

	// Token: 0x04002BF7 RID: 11255
	private bool LJHAMFLLODC;

	// Token: 0x04002BF8 RID: 11256
	private int DLFMMBBLIFH = -1;

	// Token: 0x04002BF9 RID: 11257
	private EIOPLEFLLIM HGGFJOKOKOD;
}
