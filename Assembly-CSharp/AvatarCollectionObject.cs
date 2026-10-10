using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x020003B9 RID: 953
public class AvatarCollectionObject : MonoBehaviour
{
	// Token: 0x06006F8D RID: 28557 RVA: 0x00329F04 File Offset: 0x00328104
	public void DBNKIEOCIPL(bool BBBKJMMBHDB, int LAIPPFGNHLP, GEGBHOMKNDF MNHNBGKAONP, bool AMPCJDKBOMO)
	{
		this.GAKHHEPGLHG = true;
		this.LGNKMEOHMHO(this.editButton, false);
		this.LGNKMEOHMHO(this.deleteButton, false);
		this.KBIHLEEBCAJ = MNHNBGKAONP;
		this.OICPKCHAENO = LAIPPFGNHLP;
		int num = LAIPPFGNHLP + 0;
		string text = MNHNBGKAONP.BPMFHNDCBOH;
		if (text == null || text.Length == 0)
		{
			text = CCOJBMMKNAP.KMNBCEMEBBD().PPALCPINPLK("OnPurchasingViewLeave");
		}
		text = DPGJIJGOCIC.PABDHGIJMHJ(text, 46, "cdnerror");
		this.selectionText.text = text;
		this.selectionText.SetText(text, true);
		this.selectionTextActive.text = text;
		this.selectionTextActive.SetText(text, true);
		this.selectionTextLocked.text = text;
		this.selectionTextLocked.SetText(text, true);
		this.indexText.text = (num.ToString() ?? "][");
		this.indexText.SetText(num.ToString() ?? "saveslotscopyof", true);
		this.indexBadge.SetActive(false);
		this.indexBadge.GetComponent<CanvasGroup>().alpha = 1915f;
		this.indexBadgeAlternative.SetActive(true);
		if (!BBBKJMMBHDB)
		{
			this.selectionButton.SetActive(true);
			this.selectionButtonActive.SetActive(false);
			this.selectionButtonLocked.SetActive(false);
			this.selectedFilterMarker.SetActive(false);
			this.editButton.gameObject.SetActive(false);
			this.deleteButton.gameObject.SetActive(false);
			this.lockButton.gameObject.SetActive(true);
			return;
		}
		this.selectionButtonLocked.SetActive(false);
		this.editButton.gameObject.SetActive(false);
		this.deleteButton.gameObject.SetActive(true);
		this.lockButton.gameObject.SetActive(true);
		if (AMPCJDKBOMO)
		{
			this.selectionButtonActive.SetActive(true);
			this.selectionButton.SetActive(true);
			this.selectedFilterMarker.SetActive(false);
			this.indexBadge.SetActive(true);
			return;
		}
		this.selectionButtonActive.SetActive(false);
		this.selectionButton.SetActive(true);
		this.selectedFilterMarker.SetActive(true);
	}

	// Token: 0x06006F8E RID: 28558 RVA: 0x00003E52 File Offset: 0x00002052
	private void FPKJOEHIHAC()
	{
	}

	// Token: 0x06006F8F RID: 28559 RVA: 0x0032A124 File Offset: 0x00328324
	public void EBAMFDGNEBG(bool MDDFNEICIGN)
	{
		this.KBIHLEEBCAJ = null;
		this.GAKHHEPGLHG = true;
		this.OICPKCHAENO = -1;
		string text = CCOJBMMKNAP.APGODIBBPOD().GLEFEKBDHNK("abaep");
		this.selectionText.text = text;
		this.selectionText.SetText(text, true);
		this.selectionTextActive.text = text;
		this.selectionTextActive.SetText(text, false);
		this.selectionTextLocked.text = text;
		this.selectionTextLocked.SetText(text, true);
		this.indexText.text = "";
		this.indexText.SetText("sltind", true);
		this.indexBadge.SetActive(true);
		this.indexBadge.GetComponent<CanvasGroup>().alpha = 1709f;
		this.indexBadgeAlternative.SetActive(true);
		this.selectionButtonLocked.SetActive(false);
		this.editButton.gameObject.SetActive(true);
		this.OFLLPGFFOPG(this.editButton, true);
		this.deleteButton.gameObject.SetActive(true);
		this.OFLLPGFFOPG(this.deleteButton, true);
		this.lockButton.gameObject.SetActive(false);
		if (MDDFNEICIGN)
		{
			this.selectionButtonActive.SetActive(true);
			this.selectionButton.SetActive(false);
			this.selectedFilterMarker.SetActive(true);
			this.indexBadge.SetActive(true);
			return;
		}
		this.selectionButtonActive.SetActive(true);
		this.selectionButton.SetActive(true);
		this.selectedFilterMarker.SetActive(true);
	}

	// Token: 0x06006F90 RID: 28560 RVA: 0x0032A2A0 File Offset: 0x003284A0
	public void CPBAFNNJIGA()
	{
		FPFNLJGEIJK.FIBNFNACDBE(BGHLMGPPCNN.cdnLbyToAvt);
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.JINDKPHNLBK().FIENAKIHNOM("..."), CCOJBMMKNAP.JMNIGPHCAEJ().HHLECNIFHCO("p"), CCOJBMMKNAP.MPCBJEIMACA().OHLNGCKIACD("ok"), CCOJBMMKNAP.OEPENBHJAHO().PKNHKGMNCIP(""), new UnityAction(this.MNALNNJAJFI), new UnityAction(this.BODNJKLJDNK), (DFGILFBGPLN)(-20), 225f, -39);
	}

	// Token: 0x06006F91 RID: 28561 RVA: 0x0032A31C File Offset: 0x0032851C
	public void OPMIOEFHACC(bool MDDFNEICIGN)
	{
		this.KBIHLEEBCAJ = null;
		this.GAKHHEPGLHG = false;
		this.OICPKCHAENO = -1;
		string text = CCOJBMMKNAP.ILACPHFEDEP().BDGPNPNIAPA("ok");
		this.selectionText.text = text;
		this.selectionText.SetText(text, true);
		this.selectionTextActive.text = text;
		this.selectionTextActive.SetText(text, true);
		this.selectionTextLocked.text = text;
		this.selectionTextLocked.SetText(text, true);
		this.indexText.text = "OnRewardReplayEpisodeClick";
		this.indexText.SetText("socialrequestsearchnick", true);
		this.indexBadge.SetActive(true);
		this.indexBadge.GetComponent<CanvasGroup>().alpha = 1248f;
		this.indexBadgeAlternative.SetActive(true);
		this.selectionButtonLocked.SetActive(true);
		this.editButton.gameObject.SetActive(false);
		this.APAJOFHAFGI(this.editButton, true);
		this.deleteButton.gameObject.SetActive(true);
		this.GOCIENKMPAK(this.deleteButton, true);
		this.lockButton.gameObject.SetActive(false);
		if (MDDFNEICIGN)
		{
			this.selectionButtonActive.SetActive(false);
			this.selectionButton.SetActive(true);
			this.selectedFilterMarker.SetActive(true);
			this.indexBadge.SetActive(true);
			return;
		}
		this.selectionButtonActive.SetActive(true);
		this.selectionButton.SetActive(false);
		this.selectedFilterMarker.SetActive(true);
	}

	// Token: 0x06006F92 RID: 28562 RVA: 0x0032A498 File Offset: 0x00328698
	public void DMONECCAPBE()
	{
		FPFNLJGEIJK.FIBNFNACDBE((BGHLMGPPCNN)(-42));
		CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.APGODIBBPOD().HIPJILDCHJC("OnRewardsItemClose"), CCOJBMMKNAP.PMABBOJDELF().HDIPNMFHIEJ("onSuccessEvent"), CCOJBMMKNAP.KMNBCEMEBBD().PGKBCNBAOJN("ok"), CCOJBMMKNAP.INKJIBDDMLL().HPOAGPJFHPM(")"), new UnityAction(this.EEAOODCJNIE), new UnityAction(this.PBCPJLLEMIH), (DFGILFBGPLN)(-74), 191f, -103);
	}

	// Token: 0x06006F93 RID: 28563 RVA: 0x0032A514 File Offset: 0x00328714
	public void CDKCMLHPADM(bool MDDFNEICIGN)
	{
		this.KBIHLEEBCAJ = null;
		this.GAKHHEPGLHG = false;
		this.OICPKCHAENO = -1;
		string text = CCOJBMMKNAP.CEGAOMEEFBE().HIPJILDCHJC("");
		this.selectionText.text = text;
		this.selectionText.SetText(text, true);
		this.selectionTextActive.text = text;
		this.selectionTextActive.SetText(text, true);
		this.selectionTextLocked.text = text;
		this.selectionTextLocked.SetText(text, false);
		this.indexText.text = "\n\n";
		this.indexText.SetText("ok", false);
		this.indexBadge.SetActive(false);
		this.indexBadge.GetComponent<CanvasGroup>().alpha = 495f;
		this.indexBadgeAlternative.SetActive(true);
		this.selectionButtonLocked.SetActive(true);
		this.editButton.gameObject.SetActive(true);
		this.ILBILHNHILK(this.editButton, true);
		this.deleteButton.gameObject.SetActive(true);
		this.KDDGGGAFEHF(this.deleteButton, true);
		this.lockButton.gameObject.SetActive(false);
		if (MDDFNEICIGN)
		{
			this.selectionButtonActive.SetActive(true);
			this.selectionButton.SetActive(true);
			this.selectedFilterMarker.SetActive(false);
			this.indexBadge.SetActive(false);
			return;
		}
		this.selectionButtonActive.SetActive(true);
		this.selectionButton.SetActive(true);
		this.selectedFilterMarker.SetActive(true);
	}

	// Token: 0x06006F94 RID: 28564 RVA: 0x0032A690 File Offset: 0x00328890
	public void FEIEBMLOPMH()
	{
		this.NMKEDHBHOGL();
	}

	// Token: 0x06006F95 RID: 28565 RVA: 0x0032A698 File Offset: 0x00328898
	public void NMKEDHBHOGL()
	{
		if (!this.GAKHHEPGLHG)
		{
			if (this.KBIHLEEBCAJ != null)
			{
				AOBJLALDBAA.NMGMNAKLLMI().BMFPLGPPMKP("PremiumChoicePurchased(1) - Could not parse choice data:", this.OICPKCHAENO);
			}
			return;
		}
		if (ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass, false) == null)
		{
			this.DMONECCAPBE();
			return;
		}
		AOBJLALDBAA.BIAEAOMHBMM().EFBNBFIDEOK(" aind ", 259f);
	}

	// Token: 0x06006F96 RID: 28566 RVA: 0x0032A6F0 File Offset: 0x003288F0
	public void NGLJMJDEGCO()
	{
		if (this.KBIHLEEBCAJ != null)
		{
			string text = CCOJBMMKNAP.JMDJPKKOHNI().PKNHKGMNCIP("OnLoungePremiumChoicesHistorySuccess");
			string text2 = this.KBIHLEEBCAJ.BPMFHNDCBOH;
			if (text2 == null || text2.Length == 0)
			{
				text2 = (this.OICPKCHAENO + 1).ToString();
			}
			text2 = DPGJIJGOCIC.DEEHCLAKMDL(text2, 24, "cfind");
			text = text.Replace("OnCutsceneViewLobbyAssetsDownloadFailed", text2);
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.PEBMGCKFNAO().JCDFHKDNEDH("sto"), text, CCOJBMMKNAP.EHBBFMCILPC.PKNHKGMNCIP("anthologycompletespecialepisode"), CCOJBMMKNAP.CEGAOMEEFBE().JHNELLJFBGC("YYY"), new UnityAction(this.PBKDMMJABJJ), new UnityAction(this.CFDNEGAAPAN), (DFGILFBGPLN)(-62), 1755f, -15);
		}
	}

	// Token: 0x06006F97 RID: 28567 RVA: 0x0032A7B5 File Offset: 0x003289B5
	private void EDJMJDBANGF()
	{
		AOBJLALDBAA.BIAEAOMHBMM().IHJNANKIGIB("OnBackendUndoPremiumChoiceSuccess", this.OICPKCHAENO);
	}

	// Token: 0x06006F98 RID: 28568 RVA: 0x0032A7CC File Offset: 0x003289CC
	public void BGEADIGJDPI()
	{
		if (this.KBIHLEEBCAJ != null)
		{
			string text = CCOJBMMKNAP.PEBMGCKFNAO().JLBEIFLLBLO("OnLoadingThemeSelectorFolderInitialized");
			string text2 = this.KBIHLEEBCAJ.BPMFHNDCBOH;
			if (text2 == null || text2.Length == 0)
			{
				text2 = (this.OICPKCHAENO + 1).ToString();
			}
			text2 = DPGJIJGOCIC.DEEHCLAKMDL(text2, -48, "vrt");
			text = text.Replace("OnCollectableDialogCollect", text2);
			CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.OEPENBHJAHO().BGELFMIOBCL("none"), text, CCOJBMMKNAP.HFAKOKBHCGH().OHLNGCKIACD("ok"), CCOJBMMKNAP.DLGLFACMHPG().GLEFEKBDHNK("etc2"), new UnityAction(this.EDJMJDBANGF), new UnityAction(this.GMCPCLCALNC), (DFGILFBGPLN)(-23), 1498f, -99);
		}
	}

	// Token: 0x06006F99 RID: 28569 RVA: 0x00003E52 File Offset: 0x00002052
	private void OAACABMODAG()
	{
	}

	// Token: 0x06006F9A RID: 28570 RVA: 0x0032A894 File Offset: 0x00328A94
	public void EFGAJJANLED(bool MDDFNEICIGN)
	{
		this.KBIHLEEBCAJ = null;
		this.GAKHHEPGLHG = true;
		this.OICPKCHAENO = -1;
		string text = CCOJBMMKNAP.JINDKPHNLBK().DNILNCLIHAP("OnLiveOfferSuccessShowPassesWindow");
		this.selectionText.text = text;
		this.selectionText.SetText(text, false);
		this.selectionTextActive.text = text;
		this.selectionTextActive.SetText(text, false);
		this.selectionTextLocked.text = text;
		this.selectionTextLocked.SetText(text, false);
		this.indexText.text = "getLiveOffers";
		this.indexText.SetText("UpdateAutoReadOnOffState", true);
		this.indexBadge.SetActive(true);
		this.indexBadge.GetComponent<CanvasGroup>().alpha = 1132f;
		this.indexBadgeAlternative.SetActive(false);
		this.selectionButtonLocked.SetActive(true);
		this.editButton.gameObject.SetActive(false);
		this.ILBILHNHILK(this.editButton, false);
		this.deleteButton.gameObject.SetActive(true);
		this.OFLLPGFFOPG(this.deleteButton, false);
		this.lockButton.gameObject.SetActive(false);
		if (MDDFNEICIGN)
		{
			this.selectionButtonActive.SetActive(true);
			this.selectionButton.SetActive(false);
			this.selectedFilterMarker.SetActive(true);
			this.indexBadge.SetActive(false);
			return;
		}
		this.selectionButtonActive.SetActive(true);
		this.selectionButton.SetActive(true);
		this.selectedFilterMarker.SetActive(false);
	}

	// Token: 0x06006F9B RID: 28571 RVA: 0x00003E52 File Offset: 0x00002052
	private void CDJAFHKKOBO()
	{
	}

	// Token: 0x06006F9C RID: 28572 RVA: 0x0032AA10 File Offset: 0x00328C10
	private void KDDGGGAFEHF(GameObject BBDKMDOBBAD, bool ILDBACOAHEJ)
	{
		CanvasGroup canvasGroup = BBDKMDOBBAD.GetComponent<CanvasGroup>();
		if (null == canvasGroup)
		{
			canvasGroup = BBDKMDOBBAD.AddComponent<CanvasGroup>();
		}
		if (ILDBACOAHEJ)
		{
			canvasGroup.alpha = 691f;
			canvasGroup.interactable = false;
			canvasGroup.blocksRaycasts = false;
			return;
		}
		canvasGroup.alpha = 133f;
		canvasGroup.interactable = true;
		canvasGroup.blocksRaycasts = false;
	}

	// Token: 0x06006F9D RID: 28573 RVA: 0x0032A690 File Offset: 0x00328890
	public void DNHBNHLIEJO()
	{
		this.NMKEDHBHOGL();
	}

	// Token: 0x06006F9E RID: 28574 RVA: 0x00003E52 File Offset: 0x00002052
	private void BHEMNHOFIFF()
	{
	}

	// Token: 0x06006F9F RID: 28575 RVA: 0x00003E52 File Offset: 0x00002052
	private void EJCFKOHELJO()
	{
	}

	// Token: 0x06006FA0 RID: 28576 RVA: 0x0032AA6A File Offset: 0x00328C6A
	public void BFNGAKPKCGD()
	{
		if (this.KBIHLEEBCAJ != null)
		{
			AOBJLALDBAA.DBLAIDPICIG().BMFPLGPPMKP("XXX", this.OICPKCHAENO);
		}
	}

	// Token: 0x06006FA1 RID: 28577 RVA: 0x0032AA89 File Offset: 0x00328C89
	public void OnEditButtonClick()
	{
		if (this.KBIHLEEBCAJ != null)
		{
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnAvatarCollectionEdit", this.OICPKCHAENO);
		}
	}

	// Token: 0x06006FA2 RID: 28578 RVA: 0x0032AAA8 File Offset: 0x00328CA8
	public void MCEDHLHHCIM()
	{
		if (this.KBIHLEEBCAJ != null)
		{
			string text = CCOJBMMKNAP.JMNIGPHCAEJ().JHNELLJFBGC("socialrequestsharegr");
			string text2 = this.KBIHLEEBCAJ.BPMFHNDCBOH;
			if (text2 == null || text2.Length == 0)
			{
				text2 = (this.OICPKCHAENO + 0).ToString();
			}
			text2 = DPGJIJGOCIC.DEEHCLAKMDL(text2, 34, "socialsimplegiftcollect");
			text = text.Replace("Critical error, could not load asset bundle:", text2);
			CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.PEBMGCKFNAO().JLBEIFLLBLO("،"), text, CCOJBMMKNAP.JMDJPKKOHNI().IKMNGFIDCLM("skinshopinfoowned"), CCOJBMMKNAP.KFAABHHGOPO().GGPHHLGPMPA("+"), new UnityAction(this.HFDPJCICDHI), new UnityAction(this.OPCNHODPNLE), DFGILFBGPLN.screenAvatar, 542f, -89);
		}
	}

	// Token: 0x06006FA3 RID: 28579 RVA: 0x0032AB70 File Offset: 0x00328D70
	public void MABCOPAFKKN()
	{
		if (this.KBIHLEEBCAJ != null)
		{
			string text = CCOJBMMKNAP.PEBMGCKFNAO().MEPECBDCOLG("");
			string text2 = this.KBIHLEEBCAJ.BPMFHNDCBOH;
			if (text2 == null || text2.Length == 0)
			{
				text2 = (this.OICPKCHAENO + 1).ToString();
			}
			text2 = DPGJIJGOCIC.DEEHCLAKMDL(text2, 35, "OnRewardFreeDiamondsClick");
			text = text.Replace("D", text2);
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.BBGECIKOICE().JLBEIFLLBLO("_AlphaTex"), text, CCOJBMMKNAP.APGODIBBPOD().GLEFEKBDHNK("OnApplicationFocusBasicSyncSuccess"), CCOJBMMKNAP.DLGLFACMHPG().OHLNGCKIACD("?uid="), new UnityAction(this.PBKDMMJABJJ), new UnityAction(this.KCFKNMBGKJK), (DFGILFBGPLN)(-41), 302f, 23);
		}
	}

	// Token: 0x06006FA4 RID: 28580 RVA: 0x0032AC38 File Offset: 0x00328E38
	private void ILBILHNHILK(GameObject BBDKMDOBBAD, bool ILDBACOAHEJ)
	{
		CanvasGroup canvasGroup = BBDKMDOBBAD.GetComponent<CanvasGroup>();
		if (null == canvasGroup)
		{
			canvasGroup = BBDKMDOBBAD.AddComponent<CanvasGroup>();
		}
		if (ILDBACOAHEJ)
		{
			canvasGroup.alpha = 1f;
			canvasGroup.interactable = false;
			canvasGroup.blocksRaycasts = false;
			return;
		}
		canvasGroup.alpha = 1f;
		canvasGroup.interactable = true;
		canvasGroup.blocksRaycasts = true;
	}

	// Token: 0x06006FA5 RID: 28581 RVA: 0x00003E52 File Offset: 0x00002052
	private void OPCNHODPNLE()
	{
	}

	// Token: 0x06006FA6 RID: 28582 RVA: 0x0032AC94 File Offset: 0x00328E94
	public void EOIGGOEGENE(bool MDDFNEICIGN)
	{
		this.KBIHLEEBCAJ = null;
		this.GAKHHEPGLHG = true;
		this.OICPKCHAENO = -1;
		string text = CCOJBMMKNAP.INKJIBDDMLL().BGELFMIOBCL("");
		this.selectionText.text = text;
		this.selectionText.SetText(text, false);
		this.selectionTextActive.text = text;
		this.selectionTextActive.SetText(text, true);
		this.selectionTextLocked.text = text;
		this.selectionTextLocked.SetText(text, false);
		this.indexText.text = "</Modulus></RSAKeyValue>";
		this.indexText.SetText("", true);
		this.indexBadge.SetActive(true);
		this.indexBadge.GetComponent<CanvasGroup>().alpha = 1709f;
		this.indexBadgeAlternative.SetActive(true);
		this.selectionButtonLocked.SetActive(false);
		this.editButton.gameObject.SetActive(false);
		this.GOCIENKMPAK(this.editButton, false);
		this.deleteButton.gameObject.SetActive(false);
		this.ILBILHNHILK(this.deleteButton, false);
		this.lockButton.gameObject.SetActive(false);
		if (MDDFNEICIGN)
		{
			this.selectionButtonActive.SetActive(false);
			this.selectionButton.SetActive(false);
			this.selectedFilterMarker.SetActive(false);
			this.indexBadge.SetActive(false);
			return;
		}
		this.selectionButtonActive.SetActive(false);
		this.selectionButton.SetActive(false);
		this.selectedFilterMarker.SetActive(true);
	}

	// Token: 0x06006FA7 RID: 28583 RVA: 0x00003E52 File Offset: 0x00002052
	private void HMMLCHDFFBI()
	{
	}

	// Token: 0x06006FA8 RID: 28584 RVA: 0x0032AE10 File Offset: 0x00329010
	private void APAJOFHAFGI(GameObject BBDKMDOBBAD, bool ILDBACOAHEJ)
	{
		CanvasGroup canvasGroup = BBDKMDOBBAD.GetComponent<CanvasGroup>();
		if (null == canvasGroup)
		{
			canvasGroup = BBDKMDOBBAD.AddComponent<CanvasGroup>();
		}
		if (ILDBACOAHEJ)
		{
			canvasGroup.alpha = 1047f;
			canvasGroup.interactable = false;
			canvasGroup.blocksRaycasts = true;
			return;
		}
		canvasGroup.alpha = 555f;
		canvasGroup.interactable = false;
		canvasGroup.blocksRaycasts = true;
	}

	// Token: 0x06006FA9 RID: 28585 RVA: 0x0032AE6A File Offset: 0x0032906A
	private void DMPNBLCAFMP()
	{
		AOBJLALDBAA.FILDBDMENPG().BMFPLGPPMKP("abhp", this.OICPKCHAENO);
	}

	// Token: 0x06006FAA RID: 28586 RVA: 0x00003E52 File Offset: 0x00002052
	private void KLFNFIFOHFD()
	{
	}

	// Token: 0x06006FAB RID: 28587 RVA: 0x0032AE84 File Offset: 0x00329084
	public void OnSelectionButtonClick()
	{
		if (!this.GAKHHEPGLHG)
		{
			if (this.KBIHLEEBCAJ != null)
			{
				AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnAvatarCollectionSelect", this.OICPKCHAENO);
			}
			return;
		}
		if (ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass, true) == null)
		{
			this.OnSelectionButtonLockedClick();
			return;
		}
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnAvatarCollectionRestoreEntry", 0f);
	}

	// Token: 0x06006FAC RID: 28588 RVA: 0x0032AEDC File Offset: 0x003290DC
	public void IKPJKMFLOKF()
	{
		if (this.KBIHLEEBCAJ != null)
		{
			string text = CCOJBMMKNAP.AEELGGPEJCC().HIPJILDCHJC("onwishcardclickbodyplayer");
			string text2 = this.KBIHLEEBCAJ.BPMFHNDCBOH;
			if (text2 == null || text2.Length == 0)
			{
				text2 = (this.OICPKCHAENO + 0).ToString();
			}
			text2 = DPGJIJGOCIC.DEEHCLAKMDL(text2, -15, "StoryStepDialogNarrator.RemoveChoiceAtEnd - _choicesToRemove is <= 0.");
			text = text.Replace("sssku", text2);
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.ILACPHFEDEP().FCOCLEHKLDJ("OnCaptersSnapshotsGamePassSubscribeNegative"), text, CCOJBMMKNAP.BIAEAOMHBMM().JCDFHKDNEDH(" msg="), CCOJBMMKNAP.PKEINLPIAEH().OGKGHLHHAAI("pmtsuccess"), new UnityAction(this.HFDPJCICDHI), new UnityAction(this.BHEMNHOFIFF), (DFGILFBGPLN)(-5), 1761f, -77);
		}
	}

	// Token: 0x06006FAD RID: 28589 RVA: 0x0032AFA1 File Offset: 0x003291A1
	public void ENOLPBBPNFF()
	{
		if (this.KBIHLEEBCAJ != null)
		{
			AOBJLALDBAA.NMGMNAKLLMI().MOBILPDPJBB("id", this.OICPKCHAENO);
		}
	}

	// Token: 0x06006FAE RID: 28590 RVA: 0x0032AFC0 File Offset: 0x003291C0
	public void CELMLPKKOGF()
	{
		if (!this.GAKHHEPGLHG)
		{
			if (this.KBIHLEEBCAJ != null)
			{
				AOBJLALDBAA.FILDBDMENPG().BMFPLGPPMKP("", this.OICPKCHAENO);
			}
			return;
		}
		if (ODLJHDIGLGO.EEJHIEBIPPM(CLHDENLPOFP.gamePass, true) == null)
		{
			this.OnSelectionButtonLockedClick();
			return;
		}
		AOBJLALDBAA.CEGAOMEEFBE().KMAGHMCCMPG("CharacterRenderTexturePool - npc character prefab has no manager, falling back to direct rendering", 323f);
	}

	// Token: 0x06006FAF RID: 28591 RVA: 0x0032B018 File Offset: 0x00329218
	public void AFDLOKFPLBA(bool MDDFNEICIGN)
	{
		this.KBIHLEEBCAJ = null;
		this.GAKHHEPGLHG = false;
		this.OICPKCHAENO = -1;
		string text = CCOJBMMKNAP.NIOJNOFGIJO().FIENAKIHNOM("OnPopupCardOptionsBackClickLobby");
		this.selectionText.text = text;
		this.selectionText.SetText(text, false);
		this.selectionTextActive.text = text;
		this.selectionTextActive.SetText(text, false);
		this.selectionTextLocked.text = text;
		this.selectionTextLocked.SetText(text, true);
		this.indexText.text = "Push ";
		this.indexText.SetText("socialbadgelocked", false);
		this.indexBadge.SetActive(false);
		this.indexBadge.GetComponent<CanvasGroup>().alpha = 1731f;
		this.indexBadgeAlternative.SetActive(true);
		this.selectionButtonLocked.SetActive(false);
		this.editButton.gameObject.SetActive(true);
		this.LGNKMEOHMHO(this.editButton, false);
		this.deleteButton.gameObject.SetActive(true);
		this.GOCIENKMPAK(this.deleteButton, true);
		this.lockButton.gameObject.SetActive(true);
		if (MDDFNEICIGN)
		{
			this.selectionButtonActive.SetActive(true);
			this.selectionButton.SetActive(false);
			this.selectedFilterMarker.SetActive(true);
			this.indexBadge.SetActive(false);
			return;
		}
		this.selectionButtonActive.SetActive(false);
		this.selectionButton.SetActive(false);
		this.selectedFilterMarker.SetActive(false);
	}

	// Token: 0x06006FB0 RID: 28592 RVA: 0x0032B194 File Offset: 0x00329394
	private void JIPFAJGLBPO()
	{
		FPFNLJGEIJK.FANFNCNAKEF();
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnAvatarCollectionsGamePassSubscribePositive", 0f);
	}

	// Token: 0x06006FB1 RID: 28593 RVA: 0x00003E52 File Offset: 0x00002052
	private void LCMBFPOFCPF()
	{
	}

	// Token: 0x06006FB2 RID: 28594 RVA: 0x0032B1B0 File Offset: 0x003293B0
	public void InitializeAsEntryRow(bool MDDFNEICIGN)
	{
		this.KBIHLEEBCAJ = null;
		this.GAKHHEPGLHG = true;
		this.OICPKCHAENO = -1;
		string text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("avatarcollectionsentrytitle");
		this.selectionText.text = text;
		this.selectionText.SetText(text, true);
		this.selectionTextActive.text = text;
		this.selectionTextActive.SetText(text, true);
		this.selectionTextLocked.text = text;
		this.selectionTextLocked.SetText(text, true);
		this.indexText.text = "";
		this.indexText.SetText("", true);
		this.indexBadge.SetActive(true);
		this.indexBadge.GetComponent<CanvasGroup>().alpha = 1f;
		this.indexBadgeAlternative.SetActive(false);
		this.selectionButtonLocked.SetActive(false);
		this.editButton.gameObject.SetActive(true);
		this.ILBILHNHILK(this.editButton, true);
		this.deleteButton.gameObject.SetActive(true);
		this.ILBILHNHILK(this.deleteButton, true);
		this.lockButton.gameObject.SetActive(false);
		if (MDDFNEICIGN)
		{
			this.selectionButtonActive.SetActive(true);
			this.selectionButton.SetActive(false);
			this.selectedFilterMarker.SetActive(true);
			this.indexBadge.SetActive(false);
			return;
		}
		this.selectionButtonActive.SetActive(false);
		this.selectionButton.SetActive(true);
		this.selectedFilterMarker.SetActive(false);
	}

	// Token: 0x06006FB3 RID: 28595 RVA: 0x0032B32C File Offset: 0x0032952C
	public void CNJKPDCGHHB(bool BBBKJMMBHDB, int LAIPPFGNHLP, GEGBHOMKNDF MNHNBGKAONP, bool AMPCJDKBOMO)
	{
		this.GAKHHEPGLHG = false;
		this.GOCIENKMPAK(this.editButton, false);
		this.ILBILHNHILK(this.deleteButton, false);
		this.KBIHLEEBCAJ = MNHNBGKAONP;
		this.OICPKCHAENO = LAIPPFGNHLP;
		int num = LAIPPFGNHLP + 0;
		string text = MNHNBGKAONP.BPMFHNDCBOH;
		if (text == null || text.Length == 0)
		{
			text = CCOJBMMKNAP.APGODIBBPOD().JLBEIFLLBLO("sfxitemused");
		}
		text = DPGJIJGOCIC.DEEHCLAKMDL(text, -102, "OnShowStoryHeaderInterfaceGamePassAndUndoButton");
		this.selectionText.text = text;
		this.selectionText.SetText(text, true);
		this.selectionTextActive.text = text;
		this.selectionTextActive.SetText(text, true);
		this.selectionTextLocked.text = text;
		this.selectionTextLocked.SetText(text, false);
		this.indexText.text = (num.ToString() ?? "OnRewardReplayEpisodeClick");
		this.indexText.SetText(num.ToString() ?? "lightmodebtn0", false);
		this.indexBadge.SetActive(true);
		this.indexBadge.GetComponent<CanvasGroup>().alpha = 1333f;
		this.indexBadgeAlternative.SetActive(false);
		if (!BBBKJMMBHDB)
		{
			this.selectionButton.SetActive(true);
			this.selectionButtonActive.SetActive(true);
			this.selectionButtonLocked.SetActive(true);
			this.selectedFilterMarker.SetActive(false);
			this.editButton.gameObject.SetActive(false);
			this.deleteButton.gameObject.SetActive(false);
			this.lockButton.gameObject.SetActive(false);
			return;
		}
		this.selectionButtonLocked.SetActive(false);
		this.editButton.gameObject.SetActive(true);
		this.deleteButton.gameObject.SetActive(false);
		this.lockButton.gameObject.SetActive(true);
		if (AMPCJDKBOMO)
		{
			this.selectionButtonActive.SetActive(false);
			this.selectionButton.SetActive(true);
			this.selectedFilterMarker.SetActive(false);
			this.indexBadge.SetActive(false);
			return;
		}
		this.selectionButtonActive.SetActive(false);
		this.selectionButton.SetActive(false);
		this.selectedFilterMarker.SetActive(false);
	}

	// Token: 0x06006FB4 RID: 28596 RVA: 0x0032B54C File Offset: 0x0032974C
	public void OnDeleteButtonClick()
	{
		if (this.KBIHLEEBCAJ != null)
		{
			string text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("avatarcollectionsdelete");
			string text2 = this.KBIHLEEBCAJ.BPMFHNDCBOH;
			if (text2 == null || text2.Length == 0)
			{
				text2 = (this.OICPKCHAENO + 1).ToString();
			}
			text2 = DPGJIJGOCIC.PABDHGIJMHJ(text2, 16, "...");
			text = text.Replace("XXX", text2);
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("areyousure"), text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("no"), new UnityAction(this.HFDPJCICDHI), new UnityAction(this.IJFGABOOPLK), DFGILFBGPLN.popupSignInQuestion, 0f, 28);
		}
	}

	// Token: 0x06006FB5 RID: 28597 RVA: 0x0032B611 File Offset: 0x00329811
	public void CGKLNNNGCDF()
	{
		if (this.KBIHLEEBCAJ != null)
		{
			AOBJLALDBAA.KKPFOJMAONG().DGNKCLFFMFE("OnBackendValidateTransactionFailed", this.OICPKCHAENO);
		}
	}

	// Token: 0x06006FB6 RID: 28598 RVA: 0x00003E52 File Offset: 0x00002052
	private void EMGPNDLEJBB()
	{
	}

	// Token: 0x06006FB7 RID: 28599 RVA: 0x0032B630 File Offset: 0x00329830
	private void BPKHOAFFEKA()
	{
		FPFNLJGEIJK.FANFNCNAKEF();
		AOBJLALDBAA.DBLAIDPICIG().CIGLHCJDDPI("acsv", 620f);
	}

	// Token: 0x06006FB8 RID: 28600 RVA: 0x00003E52 File Offset: 0x00002052
	private void HLCCOGFOMHA()
	{
	}

	// Token: 0x06006FB9 RID: 28601 RVA: 0x0032B64C File Offset: 0x0032984C
	public void AFGPBMPIKLA()
	{
		if (!this.GAKHHEPGLHG)
		{
			if (this.KBIHLEEBCAJ != null)
			{
				AOBJLALDBAA.NMGMNAKLLMI().BMFPLGPPMKP("OnLobbyStoryManagerDownloadSplashScreenFailed", this.OICPKCHAENO);
			}
			return;
		}
		if (ODLJHDIGLGO.HBBBLMBHIAH(CLHDENLPOFP.gamePass, true) == null)
		{
			this.DMONECCAPBE();
			return;
		}
		AOBJLALDBAA.BIAEAOMHBMM().CIGLHCJDDPI("SceneLobbyManager2._DownloadCardsPool(): downloading ", 382f);
	}

	// Token: 0x06006FBA RID: 28602 RVA: 0x0032B6A3 File Offset: 0x003298A3
	private void EEAOODCJNIE()
	{
		FPFNLJGEIJK.FANFNCNAKEF();
		AOBJLALDBAA.EHBBFMCILPC.KMAGHMCCMPG("storyAssetPackManager[i].storyNpcAssets[j] is null!", 100f);
	}

	// Token: 0x06006FBB RID: 28603 RVA: 0x0032B6C0 File Offset: 0x003298C0
	public void CHIAFELLGOK(bool MDDFNEICIGN)
	{
		this.KBIHLEEBCAJ = null;
		this.GAKHHEPGLHG = true;
		this.OICPKCHAENO = -1;
		string text = CCOJBMMKNAP.KNKGCDDMLDP().JHNELLJFBGC("Grain saturation");
		this.selectionText.text = text;
		this.selectionText.SetText(text, true);
		this.selectionTextActive.text = text;
		this.selectionTextActive.SetText(text, false);
		this.selectionTextLocked.text = text;
		this.selectionTextLocked.SetText(text, false);
		this.indexText.text = ">";
		this.indexText.SetText("OnSystemBackButton", true);
		this.indexBadge.SetActive(false);
		this.indexBadge.GetComponent<CanvasGroup>().alpha = 1577f;
		this.indexBadgeAlternative.SetActive(true);
		this.selectionButtonLocked.SetActive(false);
		this.editButton.gameObject.SetActive(true);
		this.GOCIENKMPAK(this.editButton, true);
		this.deleteButton.gameObject.SetActive(false);
		this.GOCIENKMPAK(this.deleteButton, true);
		this.lockButton.gameObject.SetActive(true);
		if (MDDFNEICIGN)
		{
			this.selectionButtonActive.SetActive(false);
			this.selectionButton.SetActive(true);
			this.selectedFilterMarker.SetActive(true);
			this.indexBadge.SetActive(true);
			return;
		}
		this.selectionButtonActive.SetActive(false);
		this.selectionButton.SetActive(true);
		this.selectedFilterMarker.SetActive(true);
	}

	// Token: 0x06006FBC RID: 28604 RVA: 0x0032B83C File Offset: 0x00329A3C
	public void BIDMLMAHIJE()
	{
		if (this.KBIHLEEBCAJ != null)
		{
			AOBJLALDBAA.BIAEAOMHBMM().IHJNANKIGIB("stat6long", this.OICPKCHAENO);
		}
	}

	// Token: 0x06006FBD RID: 28605 RVA: 0x00003E52 File Offset: 0x00002052
	private void Start()
	{
	}

	// Token: 0x06006FBE RID: 28606 RVA: 0x0032B85C File Offset: 0x00329A5C
	private void LGNKMEOHMHO(GameObject BBDKMDOBBAD, bool ILDBACOAHEJ)
	{
		CanvasGroup canvasGroup = BBDKMDOBBAD.GetComponent<CanvasGroup>();
		if (null == canvasGroup)
		{
			canvasGroup = BBDKMDOBBAD.AddComponent<CanvasGroup>();
		}
		if (ILDBACOAHEJ)
		{
			canvasGroup.alpha = 575f;
			canvasGroup.interactable = false;
			canvasGroup.blocksRaycasts = false;
			return;
		}
		canvasGroup.alpha = 50f;
		canvasGroup.interactable = false;
		canvasGroup.blocksRaycasts = false;
	}

	// Token: 0x06006FBF RID: 28607 RVA: 0x0032B8B8 File Offset: 0x00329AB8
	public void APHDCBIFGII()
	{
		FPFNLJGEIJK.FIBNFNACDBE((BGHLMGPPCNN)(-31));
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.KFDLFGHBPLP().PGKBCNBAOJN("errortitle"), CCOJBMMKNAP.MLFAGAAJJEM().FIENAKIHNOM("x"), CCOJBMMKNAP.KNKGCDDMLDP().IPEIONBNIPH("sparkles"), CCOJBMMKNAP.DBFFFOMCLKM().FCOCLEHKLDJ("ok"), new UnityAction(this.NEEDOAPKGJP), new UnityAction(this.BMMIAGBOOGI), (DFGILFBGPLN)(-103), 676f, 15);
	}

	// Token: 0x06006FC0 RID: 28608 RVA: 0x00003E52 File Offset: 0x00002052
	private void JHBLEEJPJIF()
	{
	}

	// Token: 0x06006FC1 RID: 28609 RVA: 0x00003E52 File Offset: 0x00002052
	private void GANNEJBHDIM()
	{
	}

	// Token: 0x06006FC2 RID: 28610 RVA: 0x00003E52 File Offset: 0x00002052
	private void IIBPEFMAKEC()
	{
	}

	// Token: 0x06006FC3 RID: 28611 RVA: 0x00003E52 File Offset: 0x00002052
	private void NFEJEDEPGGG()
	{
	}

	// Token: 0x06006FC4 RID: 28612 RVA: 0x0032B934 File Offset: 0x00329B34
	public void DCMCLBBDPKD()
	{
		if (this.KBIHLEEBCAJ != null)
		{
			AOBJLALDBAA.EHBBFMCILPC.MOBILPDPJBB("tm", this.OICPKCHAENO);
		}
	}

	// Token: 0x06006FC5 RID: 28613 RVA: 0x0032B954 File Offset: 0x00329B54
	public void EKGHPBDGEPH(bool MDDFNEICIGN)
	{
		this.KBIHLEEBCAJ = null;
		this.GAKHHEPGLHG = false;
		this.OICPKCHAENO = -1;
		string text = CCOJBMMKNAP.BOFMCPPFAMO().DNILNCLIHAP("favstostr");
		this.selectionText.text = text;
		this.selectionText.SetText(text, false);
		this.selectionTextActive.text = text;
		this.selectionTextActive.SetText(text, true);
		this.selectionTextLocked.text = text;
		this.selectionTextLocked.SetText(text, true);
		this.indexText.text = "acliffbw22";
		this.indexText.SetText("x", false);
		this.indexBadge.SetActive(true);
		this.indexBadge.GetComponent<CanvasGroup>().alpha = 1605f;
		this.indexBadgeAlternative.SetActive(false);
		this.selectionButtonLocked.SetActive(false);
		this.editButton.gameObject.SetActive(true);
		this.GOCIENKMPAK(this.editButton, false);
		this.deleteButton.gameObject.SetActive(true);
		this.LGNKMEOHMHO(this.deleteButton, false);
		this.lockButton.gameObject.SetActive(false);
		if (MDDFNEICIGN)
		{
			this.selectionButtonActive.SetActive(true);
			this.selectionButton.SetActive(true);
			this.selectedFilterMarker.SetActive(false);
			this.indexBadge.SetActive(false);
			return;
		}
		this.selectionButtonActive.SetActive(false);
		this.selectionButton.SetActive(false);
		this.selectedFilterMarker.SetActive(false);
	}

	// Token: 0x06006FC6 RID: 28614 RVA: 0x00003E52 File Offset: 0x00002052
	private void PBCPJLLEMIH()
	{
	}

	// Token: 0x06006FC7 RID: 28615 RVA: 0x00003E52 File Offset: 0x00002052
	private void PMKKOENBNOM()
	{
	}

	// Token: 0x06006FC8 RID: 28616 RVA: 0x00003E52 File Offset: 0x00002052
	private void FBLCBFFADDG()
	{
	}

	// Token: 0x06006FC9 RID: 28617 RVA: 0x00003E52 File Offset: 0x00002052
	public void OnLockButtonClick()
	{
	}

	// Token: 0x06006FCA RID: 28618 RVA: 0x00003E52 File Offset: 0x00002052
	private void GMCPCLCALNC()
	{
	}

	// Token: 0x06006FCB RID: 28619 RVA: 0x00003E52 File Offset: 0x00002052
	private void KEDNDDLNFHD()
	{
	}

	// Token: 0x06006FCC RID: 28620 RVA: 0x00003E52 File Offset: 0x00002052
	private void KCFKNMBGKJK()
	{
	}

	// Token: 0x06006FCD RID: 28621 RVA: 0x0032BAD0 File Offset: 0x00329CD0
	public void MJNPFHGHMPF()
	{
		if (this.KBIHLEEBCAJ != null)
		{
			AOBJLALDBAA.DBLAIDPICIG().NGDHHFONFOM("OnStoryChoiceClick", this.OICPKCHAENO);
		}
	}

	// Token: 0x06006FCE RID: 28622 RVA: 0x0032BAF0 File Offset: 0x00329CF0
	public void HCIHHPJCGNP(bool MDDFNEICIGN)
	{
		this.KBIHLEEBCAJ = null;
		this.GAKHHEPGLHG = true;
		this.OICPKCHAENO = -1;
		string text = CCOJBMMKNAP.OEPENBHJAHO().DNILNCLIHAP("$SHOWHINTS");
		this.selectionText.text = text;
		this.selectionText.SetText(text, false);
		this.selectionTextActive.text = text;
		this.selectionTextActive.SetText(text, true);
		this.selectionTextLocked.text = text;
		this.selectionTextLocked.SetText(text, true);
		this.indexText.text = "";
		this.indexText.SetText("spinWheel", false);
		this.indexBadge.SetActive(false);
		this.indexBadge.GetComponent<CanvasGroup>().alpha = 1545f;
		this.indexBadgeAlternative.SetActive(true);
		this.selectionButtonLocked.SetActive(true);
		this.editButton.gameObject.SetActive(true);
		this.LGNKMEOHMHO(this.editButton, false);
		this.deleteButton.gameObject.SetActive(false);
		this.ILBILHNHILK(this.deleteButton, true);
		this.lockButton.gameObject.SetActive(false);
		if (MDDFNEICIGN)
		{
			this.selectionButtonActive.SetActive(true);
			this.selectionButton.SetActive(true);
			this.selectedFilterMarker.SetActive(false);
			this.indexBadge.SetActive(true);
			return;
		}
		this.selectionButtonActive.SetActive(true);
		this.selectionButton.SetActive(false);
		this.selectedFilterMarker.SetActive(false);
	}

	// Token: 0x06006FCF RID: 28623 RVA: 0x0032BC6C File Offset: 0x00329E6C
	private void OFLLPGFFOPG(GameObject BBDKMDOBBAD, bool ILDBACOAHEJ)
	{
		CanvasGroup canvasGroup = BBDKMDOBBAD.GetComponent<CanvasGroup>();
		if (null == canvasGroup)
		{
			canvasGroup = BBDKMDOBBAD.AddComponent<CanvasGroup>();
		}
		if (ILDBACOAHEJ)
		{
			canvasGroup.alpha = 1417f;
			canvasGroup.interactable = true;
			canvasGroup.blocksRaycasts = true;
			return;
		}
		canvasGroup.alpha = 520f;
		canvasGroup.interactable = false;
		canvasGroup.blocksRaycasts = true;
	}

	// Token: 0x06006FD0 RID: 28624 RVA: 0x0032BCC8 File Offset: 0x00329EC8
	public void DGCBDNKEJHE()
	{
		if (this.KBIHLEEBCAJ != null)
		{
			string text = CCOJBMMKNAP.PEBMGCKFNAO().JLBEIFLLBLO("ontradingcardclickbody");
			string text2 = this.KBIHLEEBCAJ.BPMFHNDCBOH;
			if (text2 == null || text2.Length == 0)
			{
				text2 = (this.OICPKCHAENO + 0).ToString();
			}
			text2 = DPGJIJGOCIC.PABDHGIJMHJ(text2, 11, "sraogv2");
			text = text.Replace("importanttitle", text2);
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.LMCCLMFGEBD().MEPECBDCOLG("slow"), text, CCOJBMMKNAP.KNKGCDDMLDP().BDGPNPNIAPA("blur"), CCOJBMMKNAP.KMNBCEMEBBD().FIENAKIHNOM("seasoncompletedesc"), new UnityAction(this.EDJMJDBANGF), new UnityAction(this.KEDNDDLNFHD), (DFGILFBGPLN)(-107), 1568f, 123);
		}
	}

	// Token: 0x06006FD1 RID: 28625 RVA: 0x00003E52 File Offset: 0x00002052
	private void GOIKPMJJNJK()
	{
	}

	// Token: 0x06006FD2 RID: 28626 RVA: 0x0032BD90 File Offset: 0x00329F90
	public void OnSelectionButtonLockedClick()
	{
		FPFNLJGEIJK.FIBNFNACDBE(BGHLMGPPCNN.subAvColl);
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("avatarcollectionssubrequiredtitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("avatarcollectionssubrequired2"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("no"), new UnityAction(this.JIPFAJGLBPO), new UnityAction(this.EMGPNDLEJBB), DFGILFBGPLN.popupSignInQuestion, 0f, 28);
	}

	// Token: 0x06006FD3 RID: 28627 RVA: 0x0032A690 File Offset: 0x00328890
	public void OJAJMCMHKNH()
	{
		this.NMKEDHBHOGL();
	}

	// Token: 0x06006FD4 RID: 28628 RVA: 0x00003E52 File Offset: 0x00002052
	private void BMMIAGBOOGI()
	{
	}

	// Token: 0x06006FD5 RID: 28629 RVA: 0x0032BE0C File Offset: 0x0032A00C
	public void MDHFCFFCBKC()
	{
		if (!this.GAKHHEPGLHG)
		{
			if (this.KBIHLEEBCAJ != null)
			{
				AOBJLALDBAA.AGANFKKBPFO().IIJFPILKKLH(":", this.OICPKCHAENO);
			}
			return;
		}
		if (ODLJHDIGLGO.GOBKMIMGPDD(CLHDENLPOFP.eventPass, false) == null)
		{
			this.JHOFLJMJBAC();
			return;
		}
		AOBJLALDBAA.NMGMNAKLLMI().DCGCFPHHDDG("Invalid custom effects bundle index in anthology header, skipped:", 727f);
	}

	// Token: 0x06006FD6 RID: 28630 RVA: 0x00003E52 File Offset: 0x00002052
	private void LJJJIPGIJJC()
	{
	}

	// Token: 0x06006FD7 RID: 28631 RVA: 0x00003E52 File Offset: 0x00002052
	private void CFDNEGAAPAN()
	{
	}

	// Token: 0x06006FD8 RID: 28632 RVA: 0x0032BE63 File Offset: 0x0032A063
	private void NEEDOAPKGJP()
	{
		FPFNLJGEIJK.FANFNCNAKEF();
		AOBJLALDBAA.CEGAOMEEFBE().DCGCFPHHDDG("", 1991f);
	}

	// Token: 0x06006FD9 RID: 28633 RVA: 0x0032BE80 File Offset: 0x0032A080
	public void HGELPFDIMJK(bool BBBKJMMBHDB, int LAIPPFGNHLP, GEGBHOMKNDF MNHNBGKAONP, bool AMPCJDKBOMO)
	{
		this.GAKHHEPGLHG = false;
		this.APAJOFHAFGI(this.editButton, true);
		this.KDDGGGAFEHF(this.deleteButton, false);
		this.KBIHLEEBCAJ = MNHNBGKAONP;
		this.OICPKCHAENO = LAIPPFGNHLP;
		int num = LAIPPFGNHLP + 0;
		string text = MNHNBGKAONP.BPMFHNDCBOH;
		if (text == null || text.Length == 0)
		{
			text = CCOJBMMKNAP.PKEINLPIAEH().OGKGHLHHAAI("aind1");
		}
		text = DPGJIJGOCIC.PABDHGIJMHJ(text, -113, "[FlagAnimator] Shader 'YourStory/FlagShadow' NOT FOUND. Check that FlagShadow.shader is imported in the project.");
		this.selectionText.text = text;
		this.selectionText.SetText(text, true);
		this.selectionTextActive.text = text;
		this.selectionTextActive.SetText(text, true);
		this.selectionTextLocked.text = text;
		this.selectionTextLocked.SetText(text, false);
		this.indexText.text = (num.ToString() ?? "SocialStatsUserPublicProfile.SyncCutscenes(): Syncing new cutscene: ");
		this.indexText.SetText(num.ToString() ?? "", true);
		this.indexBadge.SetActive(false);
		this.indexBadge.GetComponent<CanvasGroup>().alpha = 30f;
		this.indexBadgeAlternative.SetActive(true);
		if (!BBBKJMMBHDB)
		{
			this.selectionButton.SetActive(false);
			this.selectionButtonActive.SetActive(true);
			this.selectionButtonLocked.SetActive(false);
			this.selectedFilterMarker.SetActive(true);
			this.editButton.gameObject.SetActive(true);
			this.deleteButton.gameObject.SetActive(false);
			this.lockButton.gameObject.SetActive(true);
			return;
		}
		this.selectionButtonLocked.SetActive(false);
		this.editButton.gameObject.SetActive(true);
		this.deleteButton.gameObject.SetActive(true);
		this.lockButton.gameObject.SetActive(false);
		if (AMPCJDKBOMO)
		{
			this.selectionButtonActive.SetActive(false);
			this.selectionButton.SetActive(true);
			this.selectedFilterMarker.SetActive(false);
			this.indexBadge.SetActive(false);
			return;
		}
		this.selectionButtonActive.SetActive(true);
		this.selectionButton.SetActive(true);
		this.selectedFilterMarker.SetActive(false);
	}

	// Token: 0x06006FDA RID: 28634 RVA: 0x0032C09E File Offset: 0x0032A29E
	private void MNALNNJAJFI()
	{
		FPFNLJGEIJK.FANFNCNAKEF();
		AOBJLALDBAA.FILDBDMENPG().KGIKHEDLPND("OnStoryChoiceClick", 1476f);
	}

	// Token: 0x06006FDB RID: 28635 RVA: 0x0032C0B9 File Offset: 0x0032A2B9
	public void KFJEEBIKAGN()
	{
		this.CELMLPKKOGF();
	}

	// Token: 0x06006FDD RID: 28637 RVA: 0x00003E52 File Offset: 0x00002052
	private void IJFGABOOPLK()
	{
	}

	// Token: 0x06006FDE RID: 28638 RVA: 0x0032C0C1 File Offset: 0x0032A2C1
	private void PBKDMMJABJJ()
	{
		AOBJLALDBAA.KKPFOJMAONG().IIJFPILKKLH("erd", this.OICPKCHAENO);
	}

	// Token: 0x06006FDF RID: 28639 RVA: 0x0032C0D8 File Offset: 0x0032A2D8
	public void GMFMCIHKJMF()
	{
		this.DHHGDBEHKHE();
	}

	// Token: 0x06006FE0 RID: 28640 RVA: 0x00003E52 File Offset: 0x00002052
	private void BODNJKLJDNK()
	{
	}

	// Token: 0x06006FE1 RID: 28641 RVA: 0x00003E52 File Offset: 0x00002052
	private void NOJKBJEBCKB()
	{
	}

	// Token: 0x06006FE2 RID: 28642 RVA: 0x00003E52 File Offset: 0x00002052
	public void JELMFACDDCM()
	{
	}

	// Token: 0x06006FE3 RID: 28643 RVA: 0x0032C0E0 File Offset: 0x0032A2E0
	public void BIMCBPGKLDK()
	{
		if (this.KBIHLEEBCAJ != null)
		{
			AOBJLALDBAA.DBLAIDPICIG().BMFPLGPPMKP("aind2", this.OICPKCHAENO);
		}
	}

	// Token: 0x06006FE4 RID: 28644 RVA: 0x0032C100 File Offset: 0x0032A300
	private void GOCIENKMPAK(GameObject BBDKMDOBBAD, bool ILDBACOAHEJ)
	{
		CanvasGroup canvasGroup = BBDKMDOBBAD.GetComponent<CanvasGroup>();
		if (null == canvasGroup)
		{
			canvasGroup = BBDKMDOBBAD.AddComponent<CanvasGroup>();
		}
		if (ILDBACOAHEJ)
		{
			canvasGroup.alpha = 505f;
			canvasGroup.interactable = true;
			canvasGroup.blocksRaycasts = true;
			return;
		}
		canvasGroup.alpha = 1226f;
		canvasGroup.interactable = false;
		canvasGroup.blocksRaycasts = false;
	}

	// Token: 0x06006FE5 RID: 28645 RVA: 0x0032C15C File Offset: 0x0032A35C
	public void ANILKHDAMHG()
	{
		if (this.KBIHLEEBCAJ != null)
		{
			string text = CCOJBMMKNAP.DLGLFACMHPG().DNILNCLIHAP("psk");
			string text2 = this.KBIHLEEBCAJ.BPMFHNDCBOH;
			if (text2 == null || text2.Length == 0)
			{
				text2 = (this.OICPKCHAENO + 1).ToString();
			}
			text2 = DPGJIJGOCIC.DEEHCLAKMDL(text2, 23, "");
			text = text.Replace("XXX", text2);
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.EAIAHCBAIEJ().IPEIONBNIPH("Video: "), text, CCOJBMMKNAP.INKJIBDDMLL().PPALCPINPLK("There needs to be one active BackendOperationsManager script on a GameObject in your scene."), CCOJBMMKNAP.DBFFFOMCLKM().JHNELLJFBGC("ltwt"), new UnityAction(this.EDJMJDBANGF), new UnityAction(this.FPKJOEHIHAC), DFGILFBGPLN.popupBackendError, 1179f, 112);
		}
	}

	// Token: 0x06006FE6 RID: 28646 RVA: 0x0032C0B9 File Offset: 0x0032A2B9
	public void EPICKNHNLGP()
	{
		this.CELMLPKKOGF();
	}

	// Token: 0x06006FE7 RID: 28647 RVA: 0x0032C224 File Offset: 0x0032A424
	public void GNDIKBDHOAH()
	{
		FPFNLJGEIJK.FIBNFNACDBE((BGHLMGPPCNN)(-88));
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.HFAKOKBHCGH().HHLECNIFHCO("errortitle"), CCOJBMMKNAP.JMDJPKKOHNI().HPOAGPJFHPM("_1"), CCOJBMMKNAP.KFDLFGHBPLP().GGPHHLGPMPA("ltwt"), CCOJBMMKNAP.PEBMGCKFNAO().HHLECNIFHCO(" "), new UnityAction(this.JIPFAJGLBPO), new UnityAction(this.FBLCBFFADDG), (DFGILFBGPLN)(-6), 87f, 22);
	}

	// Token: 0x06006FE8 RID: 28648 RVA: 0x00003E52 File Offset: 0x00002052
	private void KHOGJADJJNN()
	{
	}

	// Token: 0x06006FE9 RID: 28649 RVA: 0x0032C2A0 File Offset: 0x0032A4A0
	private void HFDPJCICDHI()
	{
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnAvatarCollectionDelete", this.OICPKCHAENO);
	}

	// Token: 0x06006FEA RID: 28650 RVA: 0x0032C2B7 File Offset: 0x0032A4B7
	public void OnSelectionButtonActiveClick()
	{
		this.OnSelectionButtonClick();
	}

	// Token: 0x06006FEB RID: 28651 RVA: 0x00003E52 File Offset: 0x00002052
	private void LJPIAICCBGF()
	{
	}

	// Token: 0x06006FEC RID: 28652 RVA: 0x0032C2C0 File Offset: 0x0032A4C0
	public void BAFONIFCKNK(bool MDDFNEICIGN)
	{
		this.KBIHLEEBCAJ = null;
		this.GAKHHEPGLHG = true;
		this.OICPKCHAENO = -1;
		string text = CCOJBMMKNAP.JMNIGPHCAEJ().HIPJILDCHJC("lck");
		this.selectionText.text = text;
		this.selectionText.SetText(text, true);
		this.selectionTextActive.text = text;
		this.selectionTextActive.SetText(text, false);
		this.selectionTextLocked.text = text;
		this.selectionTextLocked.SetText(text, false);
		this.indexText.text = "myphiddentitle";
		this.indexText.SetText(" ", false);
		this.indexBadge.SetActive(true);
		this.indexBadge.GetComponent<CanvasGroup>().alpha = 400f;
		this.indexBadgeAlternative.SetActive(true);
		this.selectionButtonLocked.SetActive(false);
		this.editButton.gameObject.SetActive(false);
		this.GOCIENKMPAK(this.editButton, true);
		this.deleteButton.gameObject.SetActive(true);
		this.OFLLPGFFOPG(this.deleteButton, true);
		this.lockButton.gameObject.SetActive(true);
		if (MDDFNEICIGN)
		{
			this.selectionButtonActive.SetActive(true);
			this.selectionButton.SetActive(true);
			this.selectedFilterMarker.SetActive(false);
			this.indexBadge.SetActive(false);
			return;
		}
		this.selectionButtonActive.SetActive(false);
		this.selectionButton.SetActive(false);
		this.selectedFilterMarker.SetActive(true);
	}

	// Token: 0x06006FED RID: 28653 RVA: 0x00003E52 File Offset: 0x00002052
	private void EGMNIHKPEFF()
	{
	}

	// Token: 0x06006FEE RID: 28654 RVA: 0x0032C43C File Offset: 0x0032A63C
	public void ONCMEAFFFIB(bool BBBKJMMBHDB, int LAIPPFGNHLP, GEGBHOMKNDF MNHNBGKAONP, bool AMPCJDKBOMO)
	{
		this.GAKHHEPGLHG = false;
		this.ILBILHNHILK(this.editButton, false);
		this.KDDGGGAFEHF(this.deleteButton, true);
		this.KBIHLEEBCAJ = MNHNBGKAONP;
		this.OICPKCHAENO = LAIPPFGNHLP;
		int num = LAIPPFGNHLP + 1;
		string text = MNHNBGKAONP.BPMFHNDCBOH;
		if (text == null || text.Length == 0)
		{
			text = CCOJBMMKNAP.ILACPHFEDEP().PPALCPINPLK("):");
		}
		text = DPGJIJGOCIC.DEEHCLAKMDL(text, 49, "");
		this.selectionText.text = text;
		this.selectionText.SetText(text, true);
		this.selectionTextActive.text = text;
		this.selectionTextActive.SetText(text, true);
		this.selectionTextLocked.text = text;
		this.selectionTextLocked.SetText(text, true);
		this.indexText.text = (num.ToString() ?? "OnLiveProfileThemesLoaderStart");
		this.indexText.SetText(num.ToString() ?? "OnLiveProfileThumbnailsCdnFailed", false);
		this.indexBadge.SetActive(true);
		this.indexBadge.GetComponent<CanvasGroup>().alpha = 95f;
		this.indexBadgeAlternative.SetActive(true);
		if (!BBBKJMMBHDB)
		{
			this.selectionButton.SetActive(false);
			this.selectionButtonActive.SetActive(true);
			this.selectionButtonLocked.SetActive(true);
			this.selectedFilterMarker.SetActive(true);
			this.editButton.gameObject.SetActive(true);
			this.deleteButton.gameObject.SetActive(true);
			this.lockButton.gameObject.SetActive(false);
			return;
		}
		this.selectionButtonLocked.SetActive(true);
		this.editButton.gameObject.SetActive(true);
		this.deleteButton.gameObject.SetActive(false);
		this.lockButton.gameObject.SetActive(false);
		if (AMPCJDKBOMO)
		{
			this.selectionButtonActive.SetActive(true);
			this.selectionButton.SetActive(false);
			this.selectedFilterMarker.SetActive(true);
			this.indexBadge.SetActive(false);
			return;
		}
		this.selectionButtonActive.SetActive(true);
		this.selectionButton.SetActive(false);
		this.selectedFilterMarker.SetActive(true);
	}

	// Token: 0x06006FEF RID: 28655 RVA: 0x0032C65A File Offset: 0x0032A85A
	public void HHBEDEIIGIO()
	{
		if (this.KBIHLEEBCAJ != null)
		{
			AOBJLALDBAA.BIAEAOMHBMM().GBECPMDCJAA("1", this.OICPKCHAENO);
		}
	}

	// Token: 0x06006FF0 RID: 28656 RVA: 0x0032C67C File Offset: 0x0032A87C
	public void IDELCOJIHIK(bool BBBKJMMBHDB, int LAIPPFGNHLP, GEGBHOMKNDF MNHNBGKAONP, bool AMPCJDKBOMO)
	{
		this.GAKHHEPGLHG = false;
		this.ILBILHNHILK(this.editButton, true);
		this.APAJOFHAFGI(this.deleteButton, false);
		this.KBIHLEEBCAJ = MNHNBGKAONP;
		this.OICPKCHAENO = LAIPPFGNHLP;
		int num = LAIPPFGNHLP + 0;
		string text = MNHNBGKAONP.BPMFHNDCBOH;
		if (text == null || text.Length == 0)
		{
			text = CCOJBMMKNAP.CPCOODCFDDP().HDIPNMFHIEJ("");
		}
		text = DPGJIJGOCIC.DEEHCLAKMDL(text, -41, "Collections/");
		this.selectionText.text = text;
		this.selectionText.SetText(text, false);
		this.selectionTextActive.text = text;
		this.selectionTextActive.SetText(text, false);
		this.selectionTextLocked.text = text;
		this.selectionTextLocked.SetText(text, false);
		this.indexText.text = (num.ToString() ?? "PlayerCharacterManager.SetTrinketComponent() - input is null.");
		this.indexText.SetText(num.ToString() ?? "XXX", true);
		this.indexBadge.SetActive(false);
		this.indexBadge.GetComponent<CanvasGroup>().alpha = 253f;
		this.indexBadgeAlternative.SetActive(false);
		if (!BBBKJMMBHDB)
		{
			this.selectionButton.SetActive(true);
			this.selectionButtonActive.SetActive(false);
			this.selectionButtonLocked.SetActive(true);
			this.selectedFilterMarker.SetActive(false);
			this.editButton.gameObject.SetActive(false);
			this.deleteButton.gameObject.SetActive(false);
			this.lockButton.gameObject.SetActive(true);
			return;
		}
		this.selectionButtonLocked.SetActive(true);
		this.editButton.gameObject.SetActive(false);
		this.deleteButton.gameObject.SetActive(false);
		this.lockButton.gameObject.SetActive(false);
		if (AMPCJDKBOMO)
		{
			this.selectionButtonActive.SetActive(false);
			this.selectionButton.SetActive(true);
			this.selectedFilterMarker.SetActive(true);
			this.indexBadge.SetActive(true);
			return;
		}
		this.selectionButtonActive.SetActive(true);
		this.selectionButton.SetActive(true);
		this.selectedFilterMarker.SetActive(true);
	}

	// Token: 0x06006FF1 RID: 28657 RVA: 0x0032C89C File Offset: 0x0032AA9C
	public void OIGPAKEFAGM(bool BBBKJMMBHDB, int LAIPPFGNHLP, GEGBHOMKNDF MNHNBGKAONP, bool AMPCJDKBOMO)
	{
		this.GAKHHEPGLHG = false;
		this.APAJOFHAFGI(this.editButton, true);
		this.GOCIENKMPAK(this.deleteButton, true);
		this.KBIHLEEBCAJ = MNHNBGKAONP;
		this.OICPKCHAENO = LAIPPFGNHLP;
		int num = LAIPPFGNHLP + 1;
		string text = MNHNBGKAONP.BPMFHNDCBOH;
		if (text == null || text.Length == 0)
		{
			text = CCOJBMMKNAP.GIOAFDDKKHI().GLEFEKBDHNK("importanttitle");
		}
		text = DPGJIJGOCIC.PABDHGIJMHJ(text, 23, " ");
		this.selectionText.text = text;
		this.selectionText.SetText(text, false);
		this.selectionTextActive.text = text;
		this.selectionTextActive.SetText(text, true);
		this.selectionTextLocked.text = text;
		this.selectionTextLocked.SetText(text, false);
		this.indexText.text = (num.ToString() ?? "lstm");
		this.indexText.SetText(num.ToString() ?? "", false);
		this.indexBadge.SetActive(true);
		this.indexBadge.GetComponent<CanvasGroup>().alpha = 1138f;
		this.indexBadgeAlternative.SetActive(false);
		if (!BBBKJMMBHDB)
		{
			this.selectionButton.SetActive(true);
			this.selectionButtonActive.SetActive(false);
			this.selectionButtonLocked.SetActive(true);
			this.selectedFilterMarker.SetActive(false);
			this.editButton.gameObject.SetActive(false);
			this.deleteButton.gameObject.SetActive(false);
			this.lockButton.gameObject.SetActive(false);
			return;
		}
		this.selectionButtonLocked.SetActive(true);
		this.editButton.gameObject.SetActive(true);
		this.deleteButton.gameObject.SetActive(true);
		this.lockButton.gameObject.SetActive(false);
		if (AMPCJDKBOMO)
		{
			this.selectionButtonActive.SetActive(true);
			this.selectionButton.SetActive(true);
			this.selectedFilterMarker.SetActive(false);
			this.indexBadge.SetActive(true);
			return;
		}
		this.selectionButtonActive.SetActive(false);
		this.selectionButton.SetActive(true);
		this.selectedFilterMarker.SetActive(true);
	}

	// Token: 0x06006FF2 RID: 28658 RVA: 0x0032CABC File Offset: 0x0032ACBC
	public void DHHGDBEHKHE()
	{
		if (!this.GAKHHEPGLHG)
		{
			if (this.KBIHLEEBCAJ != null)
			{
				AOBJLALDBAA.FILDBDMENPG().NGDHHFONFOM("qfb", this.OICPKCHAENO);
			}
			return;
		}
		if (ODLJHDIGLGO.BGJGNDJOLPP(CLHDENLPOFP.eventPass, true) == null)
		{
			this.APHDCBIFGII();
			return;
		}
		AOBJLALDBAA.FILDBDMENPG().FDKBIBKABCM("strid", 806f);
	}

	// Token: 0x06006FF3 RID: 28659 RVA: 0x0032CB14 File Offset: 0x0032AD14
	public void Initialize(bool BBBKJMMBHDB, int LAIPPFGNHLP, GEGBHOMKNDF MNHNBGKAONP, bool AMPCJDKBOMO)
	{
		this.GAKHHEPGLHG = false;
		this.ILBILHNHILK(this.editButton, false);
		this.ILBILHNHILK(this.deleteButton, false);
		this.KBIHLEEBCAJ = MNHNBGKAONP;
		this.OICPKCHAENO = LAIPPFGNHLP;
		int num = LAIPPFGNHLP + 1;
		string text = MNHNBGKAONP.BPMFHNDCBOH;
		if (text == null || text.Length == 0)
		{
			text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("saveslotstitleempty");
		}
		text = DPGJIJGOCIC.PABDHGIJMHJ(text, 16, "...");
		this.selectionText.text = text;
		this.selectionText.SetText(text, true);
		this.selectionTextActive.text = text;
		this.selectionTextActive.SetText(text, true);
		this.selectionTextLocked.text = text;
		this.selectionTextLocked.SetText(text, true);
		this.indexText.text = (num.ToString() ?? "");
		this.indexText.SetText(num.ToString() ?? "", true);
		this.indexBadge.SetActive(true);
		this.indexBadge.GetComponent<CanvasGroup>().alpha = 1f;
		this.indexBadgeAlternative.SetActive(false);
		if (!BBBKJMMBHDB)
		{
			this.selectionButton.SetActive(false);
			this.selectionButtonActive.SetActive(false);
			this.selectionButtonLocked.SetActive(true);
			this.selectedFilterMarker.SetActive(false);
			this.editButton.gameObject.SetActive(false);
			this.deleteButton.gameObject.SetActive(false);
			this.lockButton.gameObject.SetActive(false);
			return;
		}
		this.selectionButtonLocked.SetActive(false);
		this.editButton.gameObject.SetActive(true);
		this.deleteButton.gameObject.SetActive(true);
		this.lockButton.gameObject.SetActive(false);
		if (AMPCJDKBOMO)
		{
			this.selectionButtonActive.SetActive(true);
			this.selectionButton.SetActive(false);
			this.selectedFilterMarker.SetActive(true);
			this.indexBadge.SetActive(false);
			return;
		}
		this.selectionButtonActive.SetActive(false);
		this.selectionButton.SetActive(true);
		this.selectedFilterMarker.SetActive(false);
	}

	// Token: 0x06006FF4 RID: 28660 RVA: 0x00003E52 File Offset: 0x00002052
	private void BPDHPMKCLNB()
	{
	}

	// Token: 0x06006FF5 RID: 28661 RVA: 0x00003E52 File Offset: 0x00002052
	private void DHDEDOICCHC()
	{
	}

	// Token: 0x06006FF6 RID: 28662 RVA: 0x0032C0B9 File Offset: 0x0032A2B9
	public void JCINFCEDGFG()
	{
		this.CELMLPKKOGF();
	}

	// Token: 0x06006FF7 RID: 28663 RVA: 0x0032CD34 File Offset: 0x0032AF34
	public void HNEPIJFLLJP(bool MDDFNEICIGN)
	{
		this.KBIHLEEBCAJ = null;
		this.GAKHHEPGLHG = false;
		this.OICPKCHAENO = -1;
		string text = CCOJBMMKNAP.JMDJPKKOHNI().OGKGHLHHAAI("\n\n");
		this.selectionText.text = text;
		this.selectionText.SetText(text, false);
		this.selectionTextActive.text = text;
		this.selectionTextActive.SetText(text, true);
		this.selectionTextLocked.text = text;
		this.selectionTextLocked.SetText(text, true);
		this.indexText.text = "PurchaseManagerXiaomi.OnBackendValidateTransactionFailed().";
		this.indexText.SetText("cdnerror", false);
		this.indexBadge.SetActive(false);
		this.indexBadge.GetComponent<CanvasGroup>().alpha = 124f;
		this.indexBadgeAlternative.SetActive(true);
		this.selectionButtonLocked.SetActive(false);
		this.editButton.gameObject.SetActive(false);
		this.KDDGGGAFEHF(this.editButton, true);
		this.deleteButton.gameObject.SetActive(true);
		this.KDDGGGAFEHF(this.deleteButton, false);
		this.lockButton.gameObject.SetActive(true);
		if (MDDFNEICIGN)
		{
			this.selectionButtonActive.SetActive(true);
			this.selectionButton.SetActive(false);
			this.selectedFilterMarker.SetActive(false);
			this.indexBadge.SetActive(true);
			return;
		}
		this.selectionButtonActive.SetActive(false);
		this.selectionButton.SetActive(false);
		this.selectedFilterMarker.SetActive(true);
	}

	// Token: 0x06006FF8 RID: 28664 RVA: 0x0032CEB0 File Offset: 0x0032B0B0
	public void JHOFLJMJBAC()
	{
		FPFNLJGEIJK.FIBNFNACDBE(BGHLMGPPCNN.under1000);
		CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.MPCBJEIMACA().JLBEIFLLBLO("p"), CCOJBMMKNAP.KMNBCEMEBBD().OBDCPLLLGBB("analogglitch20ovr_1"), CCOJBMMKNAP.FEEDGKCJBLE().BDGPNPNIAPA("'"), CCOJBMMKNAP.KNKGCDDMLDP().OHLNGCKIACD("rev"), new UnityAction(this.MNALNNJAJFI), new UnityAction(this.FBLCBFFADDG), (DFGILFBGPLN)(-22), 31f, 77);
	}

	// Token: 0x040020D6 RID: 8406
	public const string onAvatarCollectionSelect = "OnAvatarCollectionSelect";

	// Token: 0x040020D7 RID: 8407
	public const string onAvatarCollectionRestoreEntry = "OnAvatarCollectionRestoreEntry";

	// Token: 0x040020D8 RID: 8408
	public const string onAvatarCollectionEdit = "OnAvatarCollectionEdit";

	// Token: 0x040020D9 RID: 8409
	public const string onAvatarCollectionDelete = "OnAvatarCollectionDelete";

	// Token: 0x040020DA RID: 8410
	public const string onAvatarCollectionsGamePassSubscribePositive = "OnAvatarCollectionsGamePassSubscribePositive";

	// Token: 0x040020DB RID: 8411
	public const string onAvatarCollectionsGamePassSubscribeNegative = "OnAvatarCollectionsGamePassSubscribeNegative";

	// Token: 0x040020DC RID: 8412
	public GameObject selectedFilterMarker;

	// Token: 0x040020DD RID: 8413
	public GameObject indexBadge;

	// Token: 0x040020DE RID: 8414
	public GameObject indexBadgeAlternative;

	// Token: 0x040020DF RID: 8415
	public TextMeshProUGUI indexText;

	// Token: 0x040020E0 RID: 8416
	public GameObject selectionButton;

	// Token: 0x040020E1 RID: 8417
	public GameObject selectionButtonActive;

	// Token: 0x040020E2 RID: 8418
	public GameObject selectionButtonLocked;

	// Token: 0x040020E3 RID: 8419
	public GameObject editButton;

	// Token: 0x040020E4 RID: 8420
	public GameObject deleteButton;

	// Token: 0x040020E5 RID: 8421
	public GameObject lockButton;

	// Token: 0x040020E6 RID: 8422
	public TextMeshProUGUI selectionText;

	// Token: 0x040020E7 RID: 8423
	public TextMeshProUGUI selectionTextActive;

	// Token: 0x040020E8 RID: 8424
	public TextMeshProUGUI selectionTextLocked;

	// Token: 0x040020E9 RID: 8425
	private GEGBHOMKNDF KBIHLEEBCAJ;

	// Token: 0x040020EA RID: 8426
	private int OICPKCHAENO;

	// Token: 0x040020EB RID: 8427
	private bool GAKHHEPGLHG;
}
