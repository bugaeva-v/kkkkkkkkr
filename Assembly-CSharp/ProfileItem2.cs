using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using DG.Tweening;
using SimpleJSON;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x02000499 RID: 1177
public class ProfileItem2 : MonoBehaviour
{
	// Token: 0x06008EB8 RID: 36536 RVA: 0x003EF454 File Offset: 0x003ED654
	public void OnReportProfileClick()
	{
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("myprreporttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("myprreportbody"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("myprreportbtnyes"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("myprreportbtnno"), new UnityAction(this.OnReportProfilePositive), new UnityAction(this.OnReportProfileNegative), DFGILFBGPLN.popupQuitConfirm, 0f, 28);
	}

	// Token: 0x06008EB9 RID: 36537 RVA: 0x003EF4CC File Offset: 0x003ED6CC
	private void AFIIHKLKFND(PMEPALPCEAF FOKFGMIEEDB)
	{
		ProfileItem2.expandBadgesByDefault = false;
		Transform transform = this.badges.transform;
		List<Sprite> list = FOKFGMIEEDB.JMJOEHHFJGC(FOKFGMIEEDB.GIFPFPOPEJN);
		if (list.Count != 0)
		{
			foreach (object obj in this.badges.transform)
			{
				Transform transform2 = (Transform)obj;
				transform2.GetComponent<Button>().onClick.RemoveAllListeners();
				transform2.gameObject.SetActive(true);
			}
			for (int i = 0; i < list.Count; i += 0)
			{
				if (i < this.badges.transform.childCount)
				{
					ProfileItem2.AMJLGCFIOJF amjlgcfiojf = new ProfileItem2.AMJLGCFIOJF();
					amjlgcfiojf.<>4__this = this;
					Transform child = this.badges.transform.GetChild(i);
					child.gameObject.SetActive(false);
					amjlgcfiojf.sprite = list[i];
					child.GetComponent<ContentBadgeItem>().imageThumb.sprite = amjlgcfiojf.sprite;
					child.GetComponent<Button>().onClick.AddListener(new UnityAction(amjlgcfiojf.HLNPBBABIJH));
				}
			}
		}
		this.badgesExpandButton.onClick.RemoveAllListeners();
		this.badgesExpandButton.GetComponent<AnimationPress>().enabled = true;
		this.badgesExpandButton.GetComponent<Button>().enabled = true;
		this.badgesHiddenTextDropDown.color = new Color(111f, 1384f, 573f, 393f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(transform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentMainTransform.GetComponent<RectTransform>());
	}

	// Token: 0x06008EBA RID: 36538 RVA: 0x003EF678 File Offset: 0x003ED878
	private void BPLLCMDACEH()
	{
		this.CCONAGOEAAN(true);
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithHint(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("hintloading"), 96);
		ContentHallOfFamePage.hallOfFameCollectionOffsetBackend = -1;
		ProfileItem2.selectedHallOfFameLanguageFilter = 0;
		BackendOperationsManager.EHBBFMCILPC.RequestGetHallOfFame(ContentHallOfFamePage.hallOfFameCollectionOffsetBackend, KBOJLHAJPCP.ALAPIFMKGAF, "OnBackendGetPublicProfileHallOfFameSuccess", "OnBackendGetPublicProfileHallOfFameException");
	}

	// Token: 0x06008EBB RID: 36539 RVA: 0x003EF6D1 File Offset: 0x003ED8D1
	private IEnumerator AHCJLIDNFNF()
	{
		while (JGLMNGOLBIG.EHBBFMCILPC.ENDDKMPKINP() > 0)
		{
			yield return new WaitForSeconds(0.5f);
			while (CommonUserInterface.EHBBFMCILPC.AnyGenericPopupIsActive() || CommonUserInterface.EHBBFMCILPC.PopupGenericNotificationActive() || CommonUserInterface.EHBBFMCILPC.ConnectionAnimationEnabled())
			{
				yield return new WaitForSeconds(0.2f);
			}
			AGNOEOKAFHL agnoeokafhl = JGLMNGOLBIG.EHBBFMCILPC.KHGKNDLGKPD();
			if (agnoeokafhl != null)
			{
				this.GKDADKEFCNL = true;
				CommonUserInterface.EHBBFMCILPC.ShowPopupGenericNotification(agnoeokafhl, "OnProfileMessageClosed");
			}
			yield return new WaitForSeconds(0.2f);
			while (this.GKDADKEFCNL)
			{
				yield return new WaitForSeconds(0.2f);
			}
			yield return new WaitForSeconds(0.2f);
		}
		this.JOCNEKNFKPF = null;
		this.GKDADKEFCNL = false;
		yield break;
	}

	// Token: 0x06008EBC RID: 36540 RVA: 0x003EF6E0 File Offset: 0x003ED8E0
	private void CIBLFLKBIEN()
	{
		if (this.LEJIJOAOEBK != null && this.LEJIJOAOEBK.EEBMPDNLJGD.Length > 1)
		{
			CommonUserInterface.EHBBFMCILPC.ShowPopupProfileMessageInput(1);
		}
	}

	// Token: 0x06008EBD RID: 36541 RVA: 0x003EF708 File Offset: 0x003ED908
	public void OnPopupCardOptionsBackClick()
	{
		this.PGGPPCINLMB = "";
		LobbyUserInterface.EHBBFMCILPC.GetPopupCardOptions().FlipVerticalAnimatedPopupManagerAnimationsScale();
		this.ShowCardOptionsOrDownload();
	}

	// Token: 0x06008EBE RID: 36542 RVA: 0x003EF72C File Offset: 0x003ED92C
	public void OnSendGiftByUID()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.GNLNPMPJPEC())
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialprivatenogiftcardsend"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
			return;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.LAKHGAPCKBC)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialprofilesuspcantuse"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
			return;
		}
		if (LJNMIPMNOKF.EHBBFMCILPC.JDDHHIOIAOJ() == 0)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("giftcardsstockempty"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
			return;
		}
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(28))
		{
			AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(28);
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("newtutorialgifts"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("continue"), new UnityAction(this.FLHACKGHHLK), DFGILFBGPLN.popupTools, 0f, 28);
			return;
		}
		this.FLHACKGHHLK();
	}

	// Token: 0x06008EBF RID: 36543 RVA: 0x003EF896 File Offset: 0x003EDA96
	private void KONHHCKPCLI()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		if (this.LEJIJOAOEBK != null && null != this.MHKKGOCMIJI)
		{
			this.GGJEBMBLBNJ();
		}
	}

	// Token: 0x06008EC0 RID: 36544 RVA: 0x003EF8C0 File Offset: 0x003EDAC0
	private void ODOPEGPBCCD()
	{
		for (int i = 0; i < this.lobbyCanvases.Count; i++)
		{
			this.lobbyCanvases[i].enabled = true;
		}
	}

	// Token: 0x06008EC1 RID: 36545 RVA: 0x003EF8F8 File Offset: 0x003EDAF8
	private void FLICPGFNMFB(PMEPALPCEAF FOKFGMIEEDB)
	{
		Vector2 onkonhljkpg = this.CalculateViewportUpDownMargins(this.wishedCardScrollView);
		List<int> list = FOKFGMIEEDB.FOHIEAJECHA();
		List<int> list2 = FOKFGMIEEDB.FCCNNMOIMGC();
		int num = AssetsManager.EHBBFMCILPC.profileDataAsset2.publicProfileCards.Count;
		if (num > LJNMIPMNOKF.EHBBFMCILPC.EEFHKIEPFBB())
		{
			num = LJNMIPMNOKF.EHBBFMCILPC.EEFHKIEPFBB();
		}
		new List<int>();
		for (int i = 0; i < num; i++)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.cardItem, this.contentWishedCardsPageTransform);
			bool deoilfbcncm = list.Contains(i);
			gameObject.GetComponent<ContentCardItem>().SetContent(i, FOKFGMIEEDB.GIFPFPOPEJN, onkonhljkpg, true, deoilfbcncm);
			gameObject.GetComponent<ContentCardItem>().onCardPressButton.onClick.AddListener(new UnityAction(this.IGGGPBKMMGH));
			if (list2.Contains(i))
			{
				gameObject.GetComponent<ContentCardItem>().onCardPressButton.GetComponent<AnimationPress>().enabled = false;
				gameObject.GetComponent<ContentCardItem>().canvasGroup.interactable = false;
				gameObject.GetComponent<ContentCardItem>().canvasGroup.alpha = 0.3f;
			}
		}
		this.UpdateHeaderStatus(FFIAHOPJJJG.Card);
	}

	// Token: 0x06008EC2 RID: 36546 RVA: 0x003EFA14 File Offset: 0x003EDC14
	private void LACBBDKFIPC(GameObject PHLJNFHEEIB)
	{
		if (PHLJNFHEEIB.name == this.contentCharactersPage.name)
		{
			this.IJPMLEKMGMA.HFOONKBBIKD();
			foreach (object obj in this.contentCharactersTransform)
			{
				((Transform)obj).GetComponent<ContentGridItem>().MAKEJIFOJCB();
			}
			this.UpdateHeaderStatus(FFIAHOPJJJG.Char);
		}
		if (PHLJNFHEEIB.name == this.contentStoriesPage.name)
		{
			this.IJPMLEKMGMA.GEJDNEOIHAE();
			foreach (object obj2 in this.contentStoriesTransform)
			{
				((Transform)obj2).GetComponent<ContentGridItem>().IILJLBBEJHO();
			}
			this.UpdateHeaderStatus(FFIAHOPJJJG.Story);
		}
		if (PHLJNFHEEIB.name == this.contentCutscenesPage.name)
		{
			this.IJPMLEKMGMA.GPCDLDEHOMP();
			foreach (object obj3 in this.contentCutscenesTransform)
			{
				ContentCusceneSmallItem[] componentsInChildren = ((Transform)obj3).GetComponentsInChildren<ContentCusceneSmallItem>();
				for (int i = 0; i < componentsInChildren.Length; i += 0)
				{
					componentsInChildren[i].LJHDHBIAHMO();
				}
			}
		}
		if (PHLJNFHEEIB.name == this.contentWishedCardsPage.name)
		{
			AKLFPGMDKLA.EHBBFMCILPC.NAKGMGBDKEE();
			foreach (object obj4 in this.contentWishedCardsPageTransform)
			{
				((Transform)obj4).GetComponent<ContentCardItem>().AFIEOLMAMCC();
			}
			this.UpdateHeaderStatus(FFIAHOPJJJG.Avatar);
		}
	}

	// Token: 0x06008EC3 RID: 36547 RVA: 0x003EFC00 File Offset: 0x003EDE00
	[CompilerGenerated]
	private void NLFKPKJJADF()
	{
		this.FadeIn(this.contentStoriesPage);
	}

	// Token: 0x06008EC4 RID: 36548 RVA: 0x003EFC10 File Offset: 0x003EDE10
	public void JLGABCGPKON()
	{
		if (this.IJPMLEKMGMA.GIFPFPOPEJN && this.IJPMLEKMGMA.LMFCFHMJIFN.Length > 0)
		{
			this.IJPMLEKMGMA.MCMIMNEJJHK -= 0;
			AKLFPGMDKLA.EHBBFMCILPC.MLEBKAIHGIO = "file://";
			this.avatarHeader.likesText.text = (this.IJPMLEKMGMA.MCMIMNEJJHK.ToString() ?? "OnOnDemandResourcesDownloadSuccess");
			this.avatarHeader.likeButton.gameObject.SetActive(true);
			this.avatarHeader.alreadyLikedButton.gameObject.SetActive(true);
		}
	}

	// Token: 0x06008EC5 RID: 36549 RVA: 0x003EFCB8 File Offset: 0x003EDEB8
	public void PreCloseFocus()
	{
		base.transform.parent.GetComponent<CanvasGroup>().alpha = 0f;
		base.transform.parent.gameObject.SetActive(false);
		base.GetComponent<RectTransform>().localScale = this.PFEEFOKHKMP;
	}

	// Token: 0x06008EC6 RID: 36550 RVA: 0x003EFD08 File Offset: 0x003EDF08
	public static JSONObject GetDefaultOperationsJsonObject(int GEJFIBJMJLD, bool FMGCKEOLJOD)
	{
		JSONObject jsonobject = new JSONObject();
		jsonobject.Add("fgupp", GEJFIBJMJLD);
		if (FMGCKEOLJOD)
		{
			jsonobject.Add("sshrpp", 1);
		}
		else
		{
			jsonobject.Add("sshrpp", 0);
		}
		return jsonobject;
	}

	// Token: 0x06008EC7 RID: 36551 RVA: 0x003EFD54 File Offset: 0x003EDF54
	private void BLIMDDDPJGM()
	{
		int bopaaipgbca = this.BOPAAIPGBCA;
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.EHBBFMCILPC.PDJKPFLHFLO(KDCJJBLGCBH.EHBBFMCILPC.HOBCAABBDLC(GDJPPKAMIFL.EHBBFMCILPC.NDJDOAPFCLH(bopaaipgbca)));
		if (ocbiopoeenj != null)
		{
			ProductThumbnailManager.lastAccessedProductWebLink = ocbiopoeenj.MBLAIKOOCFH() + "?uid=" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		}
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru && GeoLocationManager.IsRussia() && KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA())
		{
			CommonUserInterface.EHBBFMCILPC.GetFader().FadeOut(null);
			this.PurchaseCardUpgradeWeb();
			return;
		}
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnCardUpgradeContinueToPurchasingScreen", 0f);
		CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().ShowAndPurchaseProduct(KDCJJBLGCBH.EHBBFMCILPC.HOBCAABBDLC(GDJPPKAMIFL.EHBBFMCILPC.NDJDOAPFCLH(bopaaipgbca)), true);
	}

	// Token: 0x06008EC8 RID: 36552 RVA: 0x003EFE1A File Offset: 0x003EE01A
	public void OnNeedToUpdateIncomingGiftsSection()
	{
		AKLFPGMDKLA.EHBBFMCILPC.CIPCINKGILF = true;
		this.contentFriendsPage.UpdateIncommingGifts(this.IJPMLEKMGMA);
	}

	// Token: 0x06008EC9 RID: 36553 RVA: 0x003EFE38 File Offset: 0x003EE038
	public void OnNeedToCheckForEmptyFriendsPage()
	{
		if (this.IJPMLEKMGMA.JNNBNNDOGIM.IIMLLCPLKKJ.Count == 0 && this.IJPMLEKMGMA.JNNBNNDOGIM.KODOBGDHBFI.Count == 0 && this.IJPMLEKMGMA.JNNBNNDOGIM.HGKONIOKMEH() == 0 && this.IJPMLEKMGMA.JNNBNNDOGIM.GBNDFAFONBK() == 0 && this.IJPMLEKMGMA.FCCNNMOIMGC().Count == 0)
		{
			this.activePageType = AMMHDNONFHM.MyProfile;
			this.FadeOut(this.contentFriendsPage.gameObject);
		}
	}

	// Token: 0x06008ECA RID: 36554 RVA: 0x003EFEC1 File Offset: 0x003EE0C1
	private void GFCODPAIEIA()
	{
		this.ViewCutscene(this.PDPJFCHINPN);
	}

	// Token: 0x06008ECB RID: 36555 RVA: 0x003EFED0 File Offset: 0x003EE0D0
	public void OnOfflineHeaderClick()
	{
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("mypofflinebody"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
	}

	// Token: 0x06008ECC RID: 36556 RVA: 0x003EFF1E File Offset: 0x003EE11E
	private void GNBGLOAMALH()
	{
		AKLFPGMDKLA.EHBBFMCILPC.PFCCNPIPPPO();
		this.BJBKFJEAALB(this.IJPMLEKMGMA);
	}

	// Token: 0x06008ECD RID: 36557 RVA: 0x003EFF38 File Offset: 0x003EE138
	public void OnBackendRequestSendGiftCardSuccess()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		LobbyUserInterface.EHBBFMCILPC.ShowLetterDisappearAnimation("");
		int num = 2;
		AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA = true;
		if (AKLFPGMDKLA.EHBBFMCILPC.ELAGGOHBOOA["frsendhres"] != null)
		{
			num = AKLFPGMDKLA.EHBBFMCILPC.ELAGGOHBOOA["frsendhres"].AsInt;
		}
		int num2 = -1;
		if (AKLFPGMDKLA.EHBBFMCILPC.ELAGGOHBOOA["frsendhres2"] != null)
		{
			num2 = AKLFPGMDKLA.EHBBFMCILPC.ELAGGOHBOOA["frsendhres2"].AsInt;
		}
		if (num2 >= 0)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialrequestsharegr" + num2.ToString()), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), new UnityAction(this.IGNJLJIKCHI), new UnityAction(this.IGNJLJIKCHI), DFGILFBGPLN.popupEnergyHint, 0f, 28);
		}
		else if (num < 10)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("congratstitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialrequestsharegr" + num.ToString()), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
			IOGOGMEJCIK.EHBBFMCILPC.JMGGPPMDBGJ(2);
			IOGOGMEJCIK.EHBBFMCILPC.KOHINGHLPDM();
			IOGOGMEJCIK.EHBBFMCILPC.EGFKMLPLMFA();
			this.LEJIJOAOEBK = null;
			this.MHKKGOCMIJI = null;
		}
		else
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialrequestsharegr" + num.ToString()), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), new UnityAction(this.IGNJLJIKCHI), new UnityAction(this.IGNJLJIKCHI), DFGILFBGPLN.popupEnergyHint, 0f, 28);
		}
		this.OnNeedToUpdateCollectedCardsSection();
		this.OnNeedToUpdatedBadgesSection();
		LobbyUserInterface.EHBBFMCILPC.GetPopupCardOptions().ResetCustomMessageToFriend();
		this.KEIKGFKANOL = "";
		this.PGGPPCINLMB = "";
	}

	// Token: 0x06008ECF RID: 36559 RVA: 0x003F0200 File Offset: 0x003EE400
	private void BJLDDFCFIOH()
	{
		if (this.LEJIJOAOEBK != null && this.LEJIJOAOEBK.EEBMPDNLJGD.Length > 0)
		{
			CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(96);
			JSONObject dmimkkciaph = null;
			if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null && AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA)
			{
				dmimkkciaph = AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.BNMFBKNEMIF();
				DPGJIJGOCIC.NFIDPOMCNLP("SocialStatsUserPublicProfile.modified = false, OnFriendsPopupManagerRejectClick()");
				AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA = false;
			}
			JSONObject defaultOperationsJsonObject = ProfileItem2.GetDefaultOperationsJsonObject(0, true);
			defaultOperationsJsonObject.Add("frrjctpid", this.LEJIJOAOEBK.EEBMPDNLJGD);
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.socFriend.ToString(), FFPHBMFGCNN.frReject.ToString(), "", false, false);
			AKLFPGMDKLA.EHBBFMCILPC.CIPCINKGILF = true;
			BackendOperationsManager.EHBBFMCILPC.RequestGetUserPublicProfile(false, dmimkkciaph, defaultOperationsJsonObject, "OnBackendRequestFriendRejectSuccess", "OnBackendRequestFriendRejectException", false);
		}
	}

	// Token: 0x06008ED0 RID: 36560 RVA: 0x003F02FC File Offset: 0x003EE4FC
	private void IOKBKOJBFEI()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		int num = 1;
		if (AKLFPGMDKLA.EHBBFMCILPC.ELAGGOHBOOA["fruidres"] != null)
		{
			num = AKLFPGMDKLA.EHBBFMCILPC.ELAGGOHBOOA["fruidres"].AsInt;
		}
		int num2 = -1;
		if (AKLFPGMDKLA.EHBBFMCILPC.ELAGGOHBOOA["fruidres2"] != null)
		{
			num2 = AKLFPGMDKLA.EHBBFMCILPC.ELAGGOHBOOA["fruidres2"].AsInt;
		}
		if (num2 >= 0)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialfriendrequestfailed" + num2.ToString()), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
			return;
		}
		if (1 == num)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialrequestfriendconfirm"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
			return;
		}
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialrequestfriendfail"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
	}

	// Token: 0x06008ED1 RID: 36561 RVA: 0x003F045C File Offset: 0x003EE65C
	private void EANGIJLLIMO()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		if (ProfileItem2.upgradeToGiftCardResult == 1)
		{
			this.OnNeedToUpdateCollectedCardsSection();
			this.JNCCHOJOBJB();
			this.GNBGLOAMALH();
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("congratstitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialcardupgradesuccess"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("open"), new UnityAction(this.OHJHGOCPMIC), new UnityAction(this.CIDAFAOAPAE), DFGILFBGPLN.popupTools, 0f, 28);
			return;
		}
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialcardupgradefailed"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("continue"), DFGILFBGPLN.popupBackendError, 0f, 28);
	}

	// Token: 0x06008ED2 RID: 36562 RVA: 0x003F0528 File Offset: 0x003EE728
	private void NCHJKBNNHMB()
	{
		int bopaaipgbca = this.BOPAAIPGBCA;
		AKLFPGMDKLA.EHBBFMCILPC.OMLIGNDEADA(bopaaipgbca);
		AKLFPGMDKLA.EHBBFMCILPC.CIPCINKGILF = true;
		this.JNCCHOJOBJB();
		this.KMKNCDNLLHK();
	}

	// Token: 0x06008ED3 RID: 36563 RVA: 0x003F0560 File Offset: 0x003EE760
	private void FEBOLKHMHPK()
	{
		for (int i = 0; i < this.lobbyCanvases.Count; i += 0)
		{
			this.lobbyCanvases[i].enabled = true;
		}
	}

	// Token: 0x06008ED4 RID: 36564 RVA: 0x003F0598 File Offset: 0x003EE798
	private void HOFMFHELJBE()
	{
		int num = KDCJJBLGCBH.EHBBFMCILPC.KLEBNDJIOPB(AKLFPGMDKLA.EHBBFMCILPC.AFKCCPIMDJH());
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null && AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.JNNBNNDOGIM.MKABKEDMLMI() < num)
		{
			this.NKIGKELPFOP();
			return;
		}
		if (!AKLFPGMDKLA.EHBBFMCILPC.AFKCCPIMDJH())
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("friendsmaxlimitdefault"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
			return;
		}
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("friendsmaxlimitdefaultfp"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
	}

	// Token: 0x06008ED5 RID: 36565 RVA: 0x003F0674 File Offset: 0x003EE874
	private void BGEPCDAIGLF()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		try
		{
			if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null && AKLFPGMDKLA.EHBBFMCILPC.CLDBILNPMCN != null)
			{
				AKLFPGMDKLA.EHBBFMCILPC.CLDBILNPMCN.ACCOJOHJPGH(AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		if (this.BMMEPHKOLAO == 0)
		{
			this.UpdateContent(AKLFPGMDKLA.EHBBFMCILPC.CLDBILNPMCN, AMMHDNONFHM.HallOfFameProfile);
			this.FadeOut(this.contentHallOfFamePage.gameObject);
			return;
		}
		if (this.BMMEPHKOLAO == 1)
		{
			this.UpdateContent(AKLFPGMDKLA.EHBBFMCILPC.CLDBILNPMCN, AMMHDNONFHM.FriendProfile);
			this.FadeOut(this.contentFriendsPage.gameObject);
		}
	}

	// Token: 0x06008ED6 RID: 36566 RVA: 0x003F072C File Offset: 0x003EE92C
	private void LALGACIHKOC()
	{
		PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager().Initialize();
		this.LEBIMELAHBC = true;
		int bopaaipgbca = this.BOPAAIPGBCA;
		int lmcedchdiib = GDJPPKAMIFL.EHBBFMCILPC.NDJDOAPFCLH(bopaaipgbca);
		if (AKLFPGMDKLA.EHBBFMCILPC.PNAICOHCMAK(lmcedchdiib))
		{
			this.ExecuteCardUpgradeBackendRequest();
			return;
		}
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru && GeoLocationManager.IsRussia() && KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA())
		{
			this.PurchaseCardUpgradeWeb();
			return;
		}
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.BLIMDDDPJGM));
	}

	// Token: 0x06008ED7 RID: 36567 RVA: 0x003F07B8 File Offset: 0x003EE9B8
	public void OnNeedToUpdateCollectedCardsSection()
	{
		AKLFPGMDKLA.EHBBFMCILPC.CIPCINKGILF = true;
		this.BJNHFGMJHBK();
	}

	// Token: 0x06008ED8 RID: 36568 RVA: 0x003F07CB File Offset: 0x003EE9CB
	public void ShowProfileMessages()
	{
		if (JGLMNGOLBIG.EHBBFMCILPC.ENDDKMPKINP() > 0)
		{
			this.JOCNEKNFKPF = base.StartCoroutine(this.AHCJLIDNFNF());
		}
	}

	// Token: 0x06008ED9 RID: 36569 RVA: 0x003F07EC File Offset: 0x003EE9EC
	public void OnNeedToUpdatedBadgesSection()
	{
		AKLFPGMDKLA.EHBBFMCILPC.CIPCINKGILF = true;
		if (1 == AKLFPGMDKLA.EHBBFMCILPC.KLPBIGJBOBE)
		{
			IOGOGMEJCIK.EHBBFMCILPC.JMGGPPMDBGJ(0);
		}
		IOGOGMEJCIK.EHBBFMCILPC.OMBPAPJDAKK();
		IOGOGMEJCIK.EHBBFMCILPC.KOHINGHLPDM();
		IOGOGMEJCIK.EHBBFMCILPC.EGFKMLPLMFA();
		this.HAMCABNPPHP(this.IJPMLEKMGMA);
	}

	// Token: 0x06008EDA RID: 36570 RVA: 0x003F0848 File Offset: 0x003EEA48
	private void OPEGJAEFAJL()
	{
		for (int i = 0; i < this.lobbyCameras.Count; i++)
		{
			this.lobbyCameras[i].enabled = true;
		}
	}

	// Token: 0x06008EDB RID: 36571 RVA: 0x003F0880 File Offset: 0x003EEA80
	public void OnCardBreakPositive()
	{
		if (this.BOPAAIPGBCA >= 0 && LJNMIPMNOKF.EHBBFMCILPC.KMDBNEFCPOH(this.BOPAAIPGBCA) != null && LJNMIPMNOKF.EHBBFMCILPC.KMDBNEFCPOH(this.BOPAAIPGBCA).ENCCLBLHJMC > 0)
		{
			CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(96);
			BackendOperationsManager.EHBBFMCILPC.RequestBreakCard("OnBackendRequestBreakCardSuccess", "OnBackendRequestBreakCardException", this.BOPAAIPGBCA);
		}
	}

	// Token: 0x06008EDC RID: 36572 RVA: 0x00003E52 File Offset: 0x00002052
	private void GJEFAOMBDBL()
	{
	}

	// Token: 0x06008EDD RID: 36573 RVA: 0x003F08E8 File Offset: 0x003EEAE8
	public void OnAnthologyAchievementClick(string JJJGEOBAMDI)
	{
		if (JJJGEOBAMDI.StartsWith("achiev"))
		{
			JJJGEOBAMDI = JJJGEOBAMDI.Replace("achiev", "");
		}
		string str = GKJPOGNFKNK.DNILNCLIHAP("anthology" + this.GetAnthologyIndexFromAchievementId(JJJGEOBAMDI).ToString(), "anthologiestitle", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
		string str2 = GKJPOGNFKNK.DNILNCLIHAP(JJJGEOBAMDI, "achievdesc", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
		string eempglhpkjg = GKJPOGNFKNK.DNILNCLIHAP(JJJGEOBAMDI, "achievtitle", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(eempglhpkjg, "<i>" + str + ":</i> " + str2, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupQuitConfirm, 0f, 28);
	}

	// Token: 0x06008EDE RID: 36574 RVA: 0x003F09A4 File Offset: 0x003EEBA4
	private void HGMFGPNMEDL()
	{
		this.NPMNDNEDBGC++;
		if (this.NPMNDNEDBGC >= KBOJLHAJPCP.LPJOFEDNKHA)
		{
			CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.cdnActiv.ToString(), FFPHBMFGCNN.dldFail.ToString(), BGHLMGPPCNN.cdnPrfToCut.ToString(), false, false);
			this.NPMNDNEDBGC = 0;
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cdnerror"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("retry"), new UnityAction(this.DownloadAssetBundleFolder), DFGILFBGPLN.popupCdnDownloadFailed, 0f, 28);
			return;
		}
		this.DownloadAssetBundleFolder();
	}

	// Token: 0x06008EDF RID: 36575 RVA: 0x003F0A70 File Offset: 0x003EEC70
	private void IDEJMCAMIIA()
	{
		this.OKKBOFKILEA();
		this.ALGIAIKDEPH();
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnCutsceneViewShow", 0f);
		CommonUserInterface.EHBBFMCILPC.GetCutsceneViewManager().Show(this.BMODBEEEABE);
	}

	// Token: 0x06008EE0 RID: 36576 RVA: 0x003F0AA8 File Offset: 0x003EECA8
	private void ECOFOJBOOPF()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("app42error"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupBackendError, 0f, 28);
	}

	// Token: 0x06008EE1 RID: 36577 RVA: 0x003F0B00 File Offset: 0x003EED00
	private void CIDAFAOAPAE()
	{
		LJNMIPMNOKF.EHBBFMCILPC.KNAEAJPDGKB(GCFLILHCOEI.cardsFilterNone, -1, -1);
		LJNMIPMNOKF.EHBBFMCILPC.AMCFJAMHKHN(this.GKBMOLFNBOH);
	}

	// Token: 0x06008EE2 RID: 36578 RVA: 0x003F0B20 File Offset: 0x003EED20
	public void OnFriendsPageBackButtonClick()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.CIPCINKGILF || AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC == null)
		{
			this.OnProfileClick();
			return;
		}
		this.UpdateContent(AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC, AMMHDNONFHM.MyProfile);
		this.FadeOut(this.contentFriendsPage.gameObject);
	}

	// Token: 0x06008EE3 RID: 36579 RVA: 0x003F0B6E File Offset: 0x003EED6E
	private void JNCCHOJOBJB()
	{
		AKLFPGMDKLA.EHBBFMCILPC.JADCONHBJGM();
		this.KMPHJNAEECD(this.IJPMLEKMGMA);
	}

	// Token: 0x06008EE4 RID: 36580 RVA: 0x003F0B88 File Offset: 0x003EED88
	public void OnFriendRequestClick()
	{
		int num = KDCJJBLGCBH.EHBBFMCILPC.KLEBNDJIOPB(AKLFPGMDKLA.EHBBFMCILPC.AFKCCPIMDJH());
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null && AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.JNNBNNDOGIM.MKABKEDMLMI() < num)
		{
			if (this.IJPMLEKMGMA.EEBMPDNLJGD.Equals(AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.EEBMPDNLJGD))
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialrequestwarnyou"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
				return;
			}
			if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.JNNBNNDOGIM.BCPOHPEJLGB(this.IJPMLEKMGMA) || AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.JNNBNNDOGIM.GOLABDHOFOD(this.IJPMLEKMGMA))
			{
				string text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialfriendrequestfailedxxx");
				string str;
				if (this.IJPMLEKMGMA.KNCFKDLOPGA.Length == 0)
				{
					str = "<" + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("profilenametitleshort") + ">";
				}
				else
				{
					str = this.IJPMLEKMGMA.KNCFKDLOPGA;
				}
				text = text.Replace("XXX", "<i>" + str + "</i>");
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
				return;
			}
			string text2 = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialrequestfriend");
			string str2;
			if (this.IJPMLEKMGMA.KNCFKDLOPGA.Length == 0)
			{
				str2 = "<" + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("profilenametitleshort") + ">";
			}
			else
			{
				str2 = this.IJPMLEKMGMA.KNCFKDLOPGA;
			}
			text2 = text2.Replace("XXX", "<i>" + str2 + "</i>");
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), text2, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("no"), new UnityAction(this.ENGNNMHPIIK), new UnityAction(this.PIGIPMPJOJC), DFGILFBGPLN.popupQuitConfirm, 0f, 28);
			return;
		}
		else
		{
			if (!AKLFPGMDKLA.EHBBFMCILPC.AFKCCPIMDJH())
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("friendsmaxlimitdefault"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
				return;
			}
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("friendsmaxlimitdefaultfp"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
			return;
		}
	}

	// Token: 0x06008EE5 RID: 36581 RVA: 0x003F0E78 File Offset: 0x003EF078
	private void ODAIFMLAFIK()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		if (this.LEJIJOAOEBK != null && null != this.MHKKGOCMIJI)
		{
			this.LEJIJOAOEBK.NGACBBJKKGN(ProfileItem2.backendMessagingHistoryJSONArrayResponse);
			this.FadeIn(this.contentChatPage.gameObject);
		}
	}

	// Token: 0x06008EE6 RID: 36582 RVA: 0x003F0EC6 File Offset: 0x003EF0C6
	public void OnCutsceneRenameClick(GameObject KLOKNEBHDHC)
	{
		CommonUserInterface.EHBBFMCILPC.ShowPopupProfileSaveCutsceneInput();
		this.OEEDMOKBDNC = KLOKNEBHDHC;
	}

	// Token: 0x06008EE7 RID: 36583 RVA: 0x003F0EDC File Offset: 0x003EF0DC
	public void OnHallOfFameClick()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.GNLNPMPJPEC())
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialprivatenohalloffame"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
			return;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.LAKHGAPCKBC)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialprofilesuspcantuse"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
			return;
		}
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(26))
		{
			AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(26);
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("newtutorialhalloffame"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("continue"), new UnityAction(this.BPLLCMDACEH), DFGILFBGPLN.popupTools, 0f, 28);
			return;
		}
		this.BPLLCMDACEH();
	}

	// Token: 0x06008EE8 RID: 36584 RVA: 0x003F0FF8 File Offset: 0x003EF1F8
	public void OnSuspendedHeaderClick()
	{
		if (this.IJPMLEKMGMA.GIFPFPOPEJN)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("mypsuspendedbody2"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
			return;
		}
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("mypsuspendedbody"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
	}

	// Token: 0x06008EE9 RID: 36585 RVA: 0x003F1098 File Offset: 0x003EF298
	private void IJBIDMGDOPI()
	{
		this.sp0Text.text = AKLFPGMDKLA.EHBBFMCILPC.OJNBAMPGBLJ.GALKFKBPLCK().ToString();
		this.sp1Text.text = AKLFPGMDKLA.EHBBFMCILPC.DOFKEHNPCIJ.GALKFKBPLCK().ToString();
		this.sp2Text.text = AKLFPGMDKLA.EHBBFMCILPC.PBEPCNFADAA.GALKFKBPLCK().ToString();
	}

	// Token: 0x06008EEA RID: 36586 RVA: 0x003F110C File Offset: 0x003EF30C
	private void PDDFDJNGKIO()
	{
		List<int> list = this.IJPMLEKMGMA.FOHIEAJECHA();
		for (int i = 0; i < this.contentWishedCardsPageTransform.childCount; i++)
		{
			ContentCardItem component = this.contentWishedCardsPageTransform.GetChild(i).GetComponent<ContentCardItem>();
			component.ResetItem();
			if (list.Contains(component.cardId))
			{
				component.SelectItem();
			}
		}
		this.UpdateHeaderStatus(FFIAHOPJJJG.Card);
	}

	// Token: 0x06008EEB RID: 36587 RVA: 0x003F1170 File Offset: 0x003EF370
	public void OnContinueToSendSimpleMessagePositive()
	{
		if (this.LEJIJOAOEBK != null && this.LEJIJOAOEBK.EEBMPDNLJGD.Length > 0)
		{
			CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithHint(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialmessagesending"), 0);
			LobbyUserInterface.EHBBFMCILPC.ShowLetterAppearAnimation(true, "");
			JSONObject dmimkkciaph = null;
			if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null && AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA)
			{
				dmimkkciaph = AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.BNMFBKNEMIF();
				DPGJIJGOCIC.NFIDPOMCNLP("SocialStatsUserPublicProfile.modified = false, OnContinueToSendSimpleMessagePositive()");
				AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA = false;
			}
			JSONObject defaultOperationsJsonObject = ProfileItem2.GetDefaultOperationsJsonObject(0, true);
			defaultOperationsJsonObject.Add("frsmpid", this.LEJIJOAOEBK.EEBMPDNLJGD);
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.socFriend.ToString(), FFPHBMFGCNN.frSendMsg.ToString(), "", false, false);
			if (this.KEIKGFKANOL.Length > 0)
			{
				defaultOperationsJsonObject.Add("frsmmsg64", DPGJIJGOCIC.FAIFJDPENOP(this.KEIKGFKANOL));
			}
			else
			{
				defaultOperationsJsonObject.Add("frsmmsg64", DPGJIJGOCIC.FAIFJDPENOP("Error."));
			}
			AKLFPGMDKLA.EHBBFMCILPC.CIPCINKGILF = true;
			BackendOperationsManager.EHBBFMCILPC.QueueBasicSync();
			BackendOperationsManager.EHBBFMCILPC.RequestGetUserPublicProfile(false, dmimkkciaph, defaultOperationsJsonObject, "OnBackendRequestSendMessageSuccess", "OnBackendRequestSendMessageException", false);
		}
	}

	// Token: 0x06008EEC RID: 36588 RVA: 0x003F12D8 File Offset: 0x003EF4D8
	private void PLPNHKPAMJO()
	{
		int bopaaipgbca = this.BOPAAIPGBCA;
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("areyousure"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialwouldyouliketounwishcard"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("no"), new UnityAction(this.DIEJPDHOGGN), new UnityAction(this.OnGenericDoNothing), DFGILFBGPLN.popupQuitConfirm, 0.15f, 28);
	}

	// Token: 0x06008EED RID: 36589 RVA: 0x003F1354 File Offset: 0x003EF554
	private void FMNPOBDLDBO()
	{
		if (LJNMIPMNOKF.EHBBFMCILPC.JDDHHIOIAOJ() == 0)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("giftcardsstockempty"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
			return;
		}
		if (this.LEJIJOAOEBK != null && this.LEJIJOAOEBK.EEBMPDNLJGD.Length > 0)
		{
			this.EPNOBCLPJJO = HKPBEDBPHNJ.sendGiftCardByProfileId;
			if (LJNMIPMNOKF.EHBBFMCILPC.COCEMBDEKIP() != GCFLILHCOEI.cardsFilterNone)
			{
				LJNMIPMNOKF.EHBBFMCILPC.KNAEAJPDGKB(GCFLILHCOEI.cardsFilterNone, -1, -1);
			}
			this.ShowCardOptionsOrDownload();
		}
	}

	// Token: 0x06008EEE RID: 36590 RVA: 0x003F13F0 File Offset: 0x003EF5F0
	public void OnReportProfilePositive()
	{
		this.avatarHeader.reportButton.SetActive(false);
		this.avatarHeader.reportedIcon.SetActive(true);
		if (this.IJPMLEKMGMA.GIFPFPOPEJN && this.IJPMLEKMGMA.LMFCFHMJIFN.Length > 0)
		{
			AKLFPGMDKLA.EHBBFMCILPC.KAOAFBOEPFD = this.IJPMLEKMGMA.LMFCFHMJIFN;
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("myprreportdonebody"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0.25f, 28);
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.socActiv.ToString(), FFPHBMFGCNN.socReport.ToString(), LanguageManager.EHBBFMCILPC.GetSelectedLanguage().ToString(), false, false);
		}
	}

	// Token: 0x06008EEF RID: 36591 RVA: 0x003F14E0 File Offset: 0x003EF6E0
	private void PJLOGGMOIDE()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("app42error"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupBackendError, 0f, 28);
		this.MarkAsModified();
	}

	// Token: 0x06008EF0 RID: 36592 RVA: 0x003F153E File Offset: 0x003EF73E
	private void GMCKFHPECBK()
	{
		this.CAPOPEIGMOB = null;
		this.HHOHNKNPNGB = false;
	}

	// Token: 0x06008EF1 RID: 36593 RVA: 0x003F1550 File Offset: 0x003EF750
	private void IPHIGLDCBAB()
	{
		try
		{
			if (!HBKMKCBPJDI.EPCONONIJIF(this.PDPJFCHINPN))
			{
				HBKMKCBPJDI.DCNHMFBGFIJ(new UnityAction(this.JDGKEADKALN), new UnityAction(this.OnGenericDoNothing));
			}
			else
			{
				GOCBEOKKPDL.KDNNJKMHMCE(this.PDPJFCHINPN);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06008EF2 RID: 36594 RVA: 0x003F15B0 File Offset: 0x003EF7B0
	private void OAAODBKAMCN()
	{
		int num = KDCJJBLGCBH.EHBBFMCILPC.KLEBNDJIOPB(AKLFPGMDKLA.EHBBFMCILPC.AFKCCPIMDJH());
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null && AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.JNNBNNDOGIM.MKABKEDMLMI() < num)
		{
			if (this.LEJIJOAOEBK != null && this.LEJIJOAOEBK.EEBMPDNLJGD.Length > 0)
			{
				CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(96);
				JSONObject dmimkkciaph = null;
				if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null && AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA)
				{
					dmimkkciaph = AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.BNMFBKNEMIF();
					DPGJIJGOCIC.NFIDPOMCNLP("SocialStatsUserPublicProfile.modified = false, OnFriendsPopupManagerAcceptClick()");
					AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA = false;
				}
				JSONObject defaultOperationsJsonObject = ProfileItem2.GetDefaultOperationsJsonObject(0, true);
				defaultOperationsJsonObject.Add("fraccpid", this.LEJIJOAOEBK.EEBMPDNLJGD);
				FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.socFriend.ToString(), FFPHBMFGCNN.frAccept.ToString(), "", false, false);
				AKLFPGMDKLA.EHBBFMCILPC.CIPCINKGILF = true;
				BackendOperationsManager.EHBBFMCILPC.RequestGetUserPublicProfile(false, dmimkkciaph, defaultOperationsJsonObject, "OnBackendRequestFriendAcceptSuccess", "OnBackendRequestFriendAcceptException", false);
				return;
			}
		}
		else
		{
			if (!AKLFPGMDKLA.EHBBFMCILPC.AFKCCPIMDJH())
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("friendsmaxlimitdefault"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
				return;
			}
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("friendsmaxlimitdefaultfp"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
		}
	}

	// Token: 0x06008EF3 RID: 36595 RVA: 0x003F177C File Offset: 0x003EF97C
	public void PostMessageInput()
	{
		if (CommonUserInterface.EHBBFMCILPC.GetPopupProfileMessageInput().GetFlag() != 0)
		{
			this.PGGPPCINLMB = this.KEIKGFKANOL;
			LobbyUserInterface.EHBBFMCILPC.GetPopupCardOptions().UpdateMessage(this.KEIKGFKANOL);
			return;
		}
		if (this.KEIKGFKANOL.Length > 0)
		{
			this.OnContinueToSendSimpleMessage();
			return;
		}
		this.LEJIJOAOEBK = null;
		this.MHKKGOCMIJI = null;
	}

	// Token: 0x06008EF4 RID: 36596 RVA: 0x003F17E0 File Offset: 0x003EF9E0
	public string GetCollectedBadgesNoteText(List<Sprite> KONFPALEBAO)
	{
		if (this.IJPMLEKMGMA != null)
		{
			int num = 0;
			for (int i = 0; i < KONFPALEBAO.Count; i++)
			{
				if (null != KONFPALEBAO[i] && !KONFPALEBAO[i].name.Contains("locked"))
				{
					num++;
				}
			}
			string text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("collectedcardsstats").Replace("XXX", num.ToString() ?? "");
			int count = KONFPALEBAO.Count;
			return text.Replace("YYY", count.ToString() ?? "") + " (" + ((int)Math.Round((double)num / (double)count * 100.0)).ToString() + "%)";
		}
		return "n/a";
	}

	// Token: 0x06008EF5 RID: 36597 RVA: 0x003F18B2 File Offset: 0x003EFAB2
	public void OnApplicationFocusBasicSyncStart()
	{
		LobbyUserInterface.EHBBFMCILPC.GetPopupCardOptions().IsActive();
	}

	// Token: 0x06008EF6 RID: 36598 RVA: 0x00003E52 File Offset: 0x00002052
	public void ShowCollectedGifts()
	{
	}

	// Token: 0x06008EF7 RID: 36599 RVA: 0x003F18C4 File Offset: 0x003EFAC4
	private void KDNPGGPJFPC(PMEPALPCEAF FOKFGMIEEDB)
	{
		if (FOKFGMIEEDB.GIFPFPOPEJN)
		{
			this.friendsTitle.SetActive(false);
			this.friends.SetActive(false);
			this.noFriends.SetActive(false);
			return;
		}
		this.friendsTitle.SetActive(true);
		if (!FOKFGMIEEDB.JNNBNNDOGIM.FACIFBONANM())
		{
			this.friends.SetActive(false);
			this.noFriends.SetActive(true);
			this.friendsActivityText.text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialfriendintro");
			this.friendsActivityText.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialfriendintro"), true);
			return;
		}
		this.friends.SetActive(true);
		this.noFriends.SetActive(false);
		if (FOKFGMIEEDB.JNNBNNDOGIM.GLPOGLBGKIF() == 0)
		{
			this.friendsActivityText.text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialfriendintro");
			this.friendsActivityText.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialfriendintro"), true);
			this.friendsEventsCountText.transform.parent.gameObject.SetActive(false);
			return;
		}
		this.friendsActivityText.text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialfriendevents");
		this.friendsActivityText.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialfriendevents"), true);
		this.friendsEventsCountText.transform.parent.gameObject.SetActive(true);
		this.friendsEventsCountText.text = FOKFGMIEEDB.JNNBNNDOGIM.GLPOGLBGKIF().ToString();
	}

	// Token: 0x06008EF8 RID: 36600 RVA: 0x003F1A4C File Offset: 0x003EFC4C
	public void CollectIncomingGifts()
	{
		this.OMBEJHJDJKG = base.StartCoroutine(this.BJGBFJBACIG());
	}

	// Token: 0x06008EF9 RID: 36601 RVA: 0x003F1A60 File Offset: 0x003EFC60
	private void LBFDDEFKCJN()
	{
		if (this.APMHINNLFBN)
		{
			this.closeButton.SetActiveLocal(true);
			this.closeButton.gameObject.SetActive(true);
		}
		this.closeButtonCutscenes.SetActiveLocal(true);
		if (1 == AKLFPGMDKLA.EHBBFMCILPC.PACMCEHMBGG)
		{
			AudioManager.EHBBFMCILPC.PlayMusic("lobby", true, -1f, false);
		}
		this.OPEGJAEFAJL();
		this.ODOPEGPBCCD();
		AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleCutsceneView, -1);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnLiveProfileThemesLoaderStart", 0f);
		this.OnPopupCardOptionsReopen();
	}

	// Token: 0x06008EFA RID: 36602 RVA: 0x003F1AF8 File Offset: 0x003EFCF8
	private void OKKBOFKILEA()
	{
		for (int i = 0; i < this.lobbyCameras.Count; i++)
		{
			this.lobbyCameras[i].enabled = false;
		}
	}

	// Token: 0x06008EFB RID: 36603 RVA: 0x00003E52 File Offset: 0x00002052
	private void KPGDEGJGIMB()
	{
	}

	// Token: 0x06008EFC RID: 36604 RVA: 0x003F1B30 File Offset: 0x003EFD30
	public void OnAchievementClick(FHAJAGIMLLJ KMAGPDLKMDA)
	{
		if (KMAGPDLKMDA != null)
		{
			string eempglhpkjg = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialachievtitletype" + KMAGPDLKMDA.MAOJHOAAIBA.ToString());
			string text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialachievtypedesc") + "\n\n";
			int num = 0;
			for (int i = 0; i < KMAGPDLKMDA.DGJPAOJEAEE.Count; i++)
			{
				if (KMAGPDLKMDA.DGJPAOJEAEE[i].GHCGBLBCHAE > 0 && KMAGPDLKMDA.DGJPAOJEAEE[i].GHCGBLBCHAE < 101)
				{
					if (num > 0)
					{
						text += ", ";
					}
					string text2 = GKJPOGNFKNK.DNILNCLIHAP("anthology" + KMAGPDLKMDA.DGJPAOJEAEE[i].AMKCLHLIIMN.ToString(), "anthologiestitle", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
					if (num == 0)
					{
						text = string.Concat(new string[]
						{
							text,
							text2,
							" (",
							CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialtop").ToLowerInvariant(),
							" ",
							KMAGPDLKMDA.DGJPAOJEAEE[i].GHCGBLBCHAE.ToString(),
							"%)"
						});
					}
					else
					{
						text = string.Concat(new string[]
						{
							text,
							text2,
							" (",
							KMAGPDLKMDA.DGJPAOJEAEE[i].GHCGBLBCHAE.ToString(),
							"%)"
						});
					}
					num++;
				}
			}
			if (num > 0)
			{
				text += ".";
			}
			if (num > 64)
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(eempglhpkjg, text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupQuitConfirm, 0f, 16);
				return;
			}
			if (num > 56)
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(eempglhpkjg, text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupQuitConfirm, 0f, 17);
				return;
			}
			if (num > 48)
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(eempglhpkjg, text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupQuitConfirm, 0f, 18);
				return;
			}
			if (num > 40)
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(eempglhpkjg, text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupQuitConfirm, 0f, 19);
				return;
			}
			if (num > 32)
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(eempglhpkjg, text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupQuitConfirm, 0f, 20);
				return;
			}
			if (num > 24)
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(eempglhpkjg, text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupQuitConfirm, 0f, 22);
				return;
			}
			if (num > 16)
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(eempglhpkjg, text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupQuitConfirm, 0f, 25);
				return;
			}
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(eempglhpkjg, text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupQuitConfirm, 0f, 28);
		}
	}

	// Token: 0x06008EFD RID: 36605 RVA: 0x003F1E16 File Offset: 0x003F0016
	private IEnumerator FOKBBGOFHLG()
	{
		LobbyUserInterface.EHBBFMCILPC.ShowLetterDisappearAnimation("");
		yield return new WaitForSeconds(0.25f);
		this.showingCardGiftAnimation = false;
		this.ShowCardOptionsOrDownload();
		yield break;
	}

	// Token: 0x06008EFE RID: 36606 RVA: 0x003F1E25 File Offset: 0x003F0025
	private void JHDEJHKGEHF()
	{
		CommonUserInterface.EHBBFMCILPC.ShowPopupProfileMessageInput(1);
	}

	// Token: 0x06008EFF RID: 36607 RVA: 0x003F1E32 File Offset: 0x003F0032
	private IEnumerator NBKMFHDIBPK()
	{
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().EPJKDCDOEMM(0);
		if (this.EPNOBCLPJJO == HKPBEDBPHNJ.viewGiftCardAsIncomingGift)
		{
			CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithHint("", 0);
		}
		else
		{
			CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithProgress(96);
		}
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnLiveProfileThemesLoaderStop", 0f);
		while (AssetsManager.EHBBFMCILPC.IsBusy())
		{
			yield return new WaitForSeconds(0.05f);
		}
		yield return new WaitForSeconds(0.2f);
		List<CLGFGOHBCGJ> list = LJNMIPMNOKF.EHBBFMCILPC.AOOPMDIBAFP();
		for (int i = 0; i < list.Count; i++)
		{
			int mefkfohcohk = list[i].CCMDLENEDGJ;
			int num = GKJPOGNFKNK.IDKIIANDMPM(list[i].CCMDLENEDGJ);
			if (num >= 0)
			{
				mefkfohcohk = num;
			}
			AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleCollectableCard, mefkfohcohk, -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
		}
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().CLIOEOLFFLO(LEJKDNAGDHC.Fast);
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().GIJKJMMDJEL(0f, 1f);
		AssetsManager.EHBBFMCILPC.DownloadQueuedAssetBundles("OnAllCollectableCardsDownloadSuccess", "OnAllCollectableCardsDownloadFailed", false);
		yield break;
	}

	// Token: 0x06008F00 RID: 36608 RVA: 0x003F1E44 File Offset: 0x003F0044
	private void IMHNNOAIOOI()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("app42error"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupBackendError, 0f, 28);
		this.LEJIJOAOEBK = null;
		this.MHKKGOCMIJI = null;
		this.MarkAsModified();
	}

	// Token: 0x06008F01 RID: 36609 RVA: 0x003F1EB0 File Offset: 0x003F00B0
	public void OnCardClickFromFriends(int LLLCDMNPKFI)
	{
		this.OnCardClickFromMyProfile(LLLCDMNPKFI);
	}

	// Token: 0x06008F02 RID: 36610 RVA: 0x003F1EBC File Offset: 0x003F00BC
	public void OnHallOfFameHistoricalRankClick(PMEPALPCEAF ELFKNBOCEPJ)
	{
		string text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("halloffameoriginalpositioninfo");
		text = text.Replace("XXX", "<i>" + ELFKNBOCEPJ.KNCFKDLOPGA + "</i>");
		string str;
		if (ELFKNBOCEPJ.HBLHNFKEELE >= 0)
		{
			str = (ELFKNBOCEPJ.HBLHNFKEELE.ToString() ?? "");
		}
		else
		{
			str = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("nastring");
		}
		text = text.Replace("YYY", "<i>" + str + "</i>");
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
	}

	// Token: 0x06008F03 RID: 36611 RVA: 0x003F1F80 File Offset: 0x003F0180
	public void FKINHICHJPO()
	{
		AKLFPGMDKLA.EHBBFMCILPC.CIPCINKGILF = false;
		if (1 == AKLFPGMDKLA.EHBBFMCILPC.KLPBIGJBOBE)
		{
			IOGOGMEJCIK.PMABBOJDELF().COALGEOJBAG(0);
		}
		IOGOGMEJCIK.CPAMCGKKHOJ().MKBJDGHOODP();
		IOGOGMEJCIK.EHBBFMCILPC.AINIAAKMBPG();
		IOGOGMEJCIK.AIMHGPFPKND().EJOEJPDEDNO();
		this.HAMCABNPPHP(this.IJPMLEKMGMA);
	}

	// Token: 0x06008F04 RID: 36612 RVA: 0x003F1FDC File Offset: 0x003F01DC
	private void BBHBGBGEPBD(PMEPALPCEAF FOKFGMIEEDB)
	{
		Vector2 onkonhljkpg = this.CalculateViewportUpDownMargins(this.storiesScrollView);
		List<Transform> list = new List<Transform>();
		foreach (Sprite ibhngiahccm in AssetsManager.EHBBFMCILPC.profileDataLocalizedAsset.publicProfileStories)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentStoriesTransform);
			list.Add(gameObject.transform);
			gameObject.GetComponent<ContentGridItem>().SetContent(FOKFGMIEEDB, ibhngiahccm, FFIAHOPJJJG.Story, onkonhljkpg, list);
			gameObject.GetComponent<ContentGridItem>().gridButton.onClick.AddListener(new UnityAction(this.HKAKEJMJIPI));
		}
		this.UpdateHeaderStatus(FFIAHOPJJJG.Story);
	}

	// Token: 0x06008F05 RID: 36613 RVA: 0x003F20A0 File Offset: 0x003F02A0
	public void OnPublicProfileCredoEdit()
	{
		CommonUserInterface.EHBBFMCILPC.ShowPopupProfileCredoInput();
	}

	// Token: 0x06008F06 RID: 36614 RVA: 0x003F20AC File Offset: 0x003F02AC
	private IEnumerator HNKPMLGCKHO()
	{
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnLiveProfileThemesLoaderStop", 0f);
		while (AssetsManager.EHBBFMCILPC.IsBusy())
		{
			yield return new WaitForSeconds(0.05f);
		}
		AssetsManager.EHBBFMCILPC.InitializeAssetBundleFolder((LNDOOJOFFOM)this.BMODBEEEABE.FJFEPNKBELL, "OnCutsceneViewAssetBundleFolderInitializeSuccess", "OnCutsceneViewAssetsDownloadFailed");
		yield return null;
		yield break;
	}

	// Token: 0x06008F07 RID: 36615 RVA: 0x003F20BB File Offset: 0x003F02BB
	private void DFLGMBLNECK()
	{
		if (!this.IJPMLEKMGMA.GIFPFPOPEJN)
		{
			this.editRCPlayButton.SetActive(true);
			this.editCredoButton.SetActive(true);
			return;
		}
		this.editRCPlayButton.SetActive(false);
		this.editCredoButton.SetActive(false);
	}

	// Token: 0x06008F08 RID: 36616 RVA: 0x003F20FC File Offset: 0x003F02FC
	public void SetCloseButtonByPageType()
	{
		if (this.activePageType == AMMHDNONFHM.MyProfile || this.activePageType == AMMHDNONFHM.RandomProfile)
		{
			this.closeButton.SetActiveLocal(true);
			this.closeButton.gameObject.SetActive(true);
			this.APMHINNLFBN = true;
			return;
		}
		this.closeButton.SetActiveLocal(false);
		this.closeButton.gameObject.SetActive(false);
		this.APMHINNLFBN = false;
	}

	// Token: 0x06008F09 RID: 36617 RVA: 0x003F2163 File Offset: 0x003F0363
	public void OnReportProfileNegative()
	{
		if (this.IJPMLEKMGMA.GIFPFPOPEJN && this.IJPMLEKMGMA.LMFCFHMJIFN.Length > 0)
		{
			AKLFPGMDKLA.EHBBFMCILPC.KAOAFBOEPFD = "";
		}
	}

	// Token: 0x06008F0A RID: 36618 RVA: 0x003F2194 File Offset: 0x003F0394
	private IEnumerator ICNHLKBOIGD(Transform HAEJKAFFHFL)
	{
		yield return new WaitForEndOfFrame();
		HAEJKAFFHFL.GetComponent<HorizontalLayoutGroup>().enabled = true;
		yield break;
	}

	// Token: 0x06008F0B RID: 36619 RVA: 0x003F21A3 File Offset: 0x003F03A3
	private void AEBPHGJGDFA()
	{
		CommonUserInterface.EHBBFMCILPC.ShowPopupProfileUIDInput(3);
	}

	// Token: 0x06008F0C RID: 36620 RVA: 0x003F21B0 File Offset: 0x003F03B0
	private void NGKDOFIKCKB()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("app42error"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupBackendError, 0f, 28);
		this.MarkAsModified();
	}

	// Token: 0x06008F0D RID: 36621 RVA: 0x003F2210 File Offset: 0x003F0410
	private void CCONAGOEAAN(bool NNHMICAFNBO)
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null && (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA || AKLFPGMDKLA.EHBBFMCILPC.BNOHIAEGOMI() > (double)KDCJJBLGCBH.EHBBFMCILPC.BCJPLCIFNIF()))
		{
			if (!NNHMICAFNBO)
			{
				BackendOperationsManager.EHBBFMCILPC.QueueRequestSaveChapterSnapshots();
				BackendOperationsManager.EHBBFMCILPC.QueueRequestSaveAvatarCollections();
				BackendOperationsManager.EHBBFMCILPC.QueueRequestSaveSync();
				CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithHint(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("hintsaving"), 96);
				if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA)
				{
					DPGJIJGOCIC.ADFCDFHBDAF("RequestGetUserPublicProfile(): Account.Instance.userPublicProfile.modified");
				}
				else
				{
					DPGJIJGOCIC.ADFCDFHBDAF("RequestGetUserPublicProfile(): timer hit: " + AKLFPGMDKLA.EHBBFMCILPC.BNOHIAEGOMI().ToString());
				}
			}
			else if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA)
			{
				DPGJIJGOCIC.ADFCDFHBDAF("RequestGetUserPublicProfile(queued): Account.Instance.userPublicProfile.modified");
			}
			else
			{
				DPGJIJGOCIC.ADFCDFHBDAF("RequestGetUserPublicProfile(queued): timer hit: " + AKLFPGMDKLA.EHBBFMCILPC.BNOHIAEGOMI().ToString());
			}
			BackendOperationsManager.EHBBFMCILPC.RequestGetUserPublicProfile(false, AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.BNMFBKNEMIF(), null, "OnBackendSavePublicProfileSuccess", "OnBackendSavePublicProfileException", NNHMICAFNBO);
			AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA = false;
			AKLFPGMDKLA.EHBBFMCILPC.HOBAOJMIPBC();
			return;
		}
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnBackendSavePublicProfileSuccess", 0f);
	}

	// Token: 0x06008F0E RID: 36622 RVA: 0x003F2368 File Offset: 0x003F0568
	private void OIDGPBKMLIO()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		if (ProfileItem2.breakCardsResult > 0)
		{
			string text = "";
			for (int i = 0; i < 3; i++)
			{
				if (ProfileItem2.breakCardSpecialCurrenciesReward[i] > 0)
				{
					if (i == 0)
					{
						text = text + ProfileItem2.breakCardSpecialCurrenciesReward[i].ToString() + KBOJLHAJPCP.GJHKGBCLGIJ;
					}
					else if (i == 1)
					{
						text = text + " " + ProfileItem2.breakCardSpecialCurrenciesReward[i].ToString() + KBOJLHAJPCP.KGMFKFPBFBJ;
					}
					else if (i == 2)
					{
						text = text + " " + ProfileItem2.breakCardSpecialCurrenciesReward[i].ToString() + KBOJLHAJPCP.AENKOIILEFO;
					}
				}
			}
			string text2 = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cardbreaksuccessbody");
			text2 = text2 + "\n\n<align=\"center\"><size=120%>" + text;
			if (this.BOPAAIPGBCA >= 0 && LJNMIPMNOKF.EHBBFMCILPC.KMDBNEFCPOH(this.BOPAAIPGBCA) != null)
			{
				text2 = text2 + "\n\n<align=\"center\"><size=100%><alpha=#88>" + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cardcollectecdopyleft").Replace("XXX", LJNMIPMNOKF.EHBBFMCILPC.KMDBNEFCPOH(this.BOPAAIPGBCA).ENCCLBLHJMC.ToString() ?? "");
			}
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("congratstitle"), text2, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("collect"), new UnityAction(this.EGJDPHGJJNL), new UnityAction(this.EGJDPHGJJNL), DFGILFBGPLN.popupEnergyHint, 0f, 28);
			ProfileItem2.breakCardSpecialCurrenciesReward.Clear();
			LJNMIPMNOKF.EHBBFMCILPC.DENIEGBICKJ();
			this.IJBIDMGDOPI();
			this.OnNeedToUpdateCollectedCardsSection();
			if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.FCCNNMOIMGC().Count == 0)
			{
				AKLFPGMDKLA.EHBBFMCILPC.NAKGMGBDKEE();
				AKLFPGMDKLA.EHBBFMCILPC.BPLCLNIJDHE();
			}
			this.JNCCHOJOBJB();
			this.GNBGLOAMALH();
			AKLFPGMDKLA.EHBBFMCILPC.CIPCINKGILF = true;
		}
		ProfileItem2.breakCardsResult = 0;
	}

	// Token: 0x06008F0F RID: 36623 RVA: 0x003F2558 File Offset: 0x003F0758
	public void OnBackendRequestSendGiftCardException()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		LobbyUserInterface.EHBBFMCILPC.ShowLetterDisappearAnimation("");
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("app42error"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), new UnityAction(this.IGNJLJIKCHI), new UnityAction(this.IGNJLJIKCHI), DFGILFBGPLN.popupBackendError, 0f, 28);
		LobbyUserInterface.EHBBFMCILPC.GetPopupCardOptions().ResetCustomMessageToFriend();
		this.KEIKGFKANOL = "";
		this.PGGPPCINLMB = "";
		this.MarkAsModified();
	}

	// Token: 0x06008F10 RID: 36624 RVA: 0x003F2604 File Offset: 0x003F0804
	private void JHNEGAHMMHM(string HAPADEOFKBP)
	{
		try
		{
			if (HAPADEOFKBP.Contains("+"))
			{
				int num = int.Parse(DPGJIJGOCIC.NLGJAJDKIGH(HAPADEOFKBP.Substring(0, HAPADEOFKBP.IndexOf("+"))));
				string dpjinbcgngn = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("randomprofclickcut").Replace("XXX", "<i>" + GKJPOGNFKNK.DNILNCLIHAP("anthology" + num.ToString(), "anthologiestitle", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()) + "</i>");
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), dpjinbcgngn, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06008F11 RID: 36625 RVA: 0x003F26D8 File Offset: 0x003F08D8
	public void FadeIn(GameObject GBEENCLCAJL)
	{
		if (GBEENCLCAJL.name == this.contentFriendsPage.gameObject.name)
		{
			if (AKLFPGMDKLA.EHBBFMCILPC.GNLNPMPJPEC())
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialprivatenofriendsuse"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
				return;
			}
			if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.LAKHGAPCKBC)
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialprofilesuspcantuse"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
				return;
			}
		}
		bool flag = false;
		if (GBEENCLCAJL.name == this.contentCutscenesPage.name && (this.IJPMLEKMGMA.MBDLEGCAHLH() == 0 || flag))
		{
			this.ShowZeroCutscenesMessage();
			return;
		}
		this.JBAICDJCAIB(GBEENCLCAJL);
		GBEENCLCAJL.SetActive(true);
		GBEENCLCAJL.GetComponent<CanvasGroup>().DOFade(this.JHGJFGECNPL, this.AKCEKJFIGJH).SetEase(this.HNJCFFHCDCC);
		GBEENCLCAJL.GetComponent<CanvasGroup>().interactable = true;
		GBEENCLCAJL.GetComponent<CanvasGroup>().blocksRaycasts = true;
		if (GBEENCLCAJL.name == this.contentAvatarPage.gameObject.name)
		{
			this.contentAvatarPage.PopulateContentAvatar(this.IJPMLEKMGMA, this);
		}
		if (GBEENCLCAJL.name == this.contentCharactersPage.name)
		{
			this.NACKICNAKDI(this.IJPMLEKMGMA);
		}
		if (GBEENCLCAJL.name == this.contentStoriesPage.name)
		{
			this.BBHBGBGEPBD(this.IJPMLEKMGMA);
		}
		if (GBEENCLCAJL.name == this.contentCutscenesPage.name)
		{
			this.KMBMOJNJBFJ(this.IJPMLEKMGMA);
		}
		if (GBEENCLCAJL.name == this.contentAnthologyAchievementsPage.name)
		{
			this.CDKFEEAKCOH(this.IJPMLEKMGMA);
		}
		if (GBEENCLCAJL.name == this.contentHallOfFamePage.gameObject.name)
		{
			if (this.activePageType == AMMHDNONFHM.HallOfFameProfile)
			{
				return;
			}
			this.activePageType = AMMHDNONFHM.HallOfFamePage;
			this.contentHallOfFamePage.PopulateContentHallOfFame(this);
		}
		if (GBEENCLCAJL.name == this.contentFriendsPage.gameObject.name)
		{
			this.activePageType = AMMHDNONFHM.FriendsPage;
			this.contentFriendsPage.PopulateContentFriends(AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC, this);
			this.ConsumeIncomingFriendLetters();
		}
		if (GBEENCLCAJL.name == this.contentWishedCardsPage.name)
		{
			this.INAHNIMEBOF();
			this.FLICPGFNMFB(this.IJPMLEKMGMA);
		}
		if (GBEENCLCAJL.name == this.contentChatPage.gameObject.name)
		{
			this.contentChatPage.PopulateContentChatPage(this.IJPMLEKMGMA, this.LEJIJOAOEBK);
		}
		this.closeButton.SetActiveLocal(false);
		this.closeButton.gameObject.SetActive(false);
		this.closeButtonCutscenes.SetActiveLocal(true);
		this.APMHINNLFBN = false;
	}

	// Token: 0x06008F12 RID: 36626 RVA: 0x003F29EC File Offset: 0x003F0BEC
	private void MIIKAKGPGNC()
	{
		CommonUserInterface.EHBBFMCILPC.MCJIGJMFBMI();
		if (ProfileItem2.upgradeToGiftCardResult == 1)
		{
			this.OnNeedToUpdateCollectedCardsSection();
			this.JNCCHOJOBJB();
			this.GNBGLOAMALH();
			CommonUserInterface.IKNOFBFMPGA().CEGLPJNLBHL(CCOJBMMKNAP.OEPENBHJAHO().HPOAGPJFHPM("yes"), CCOJBMMKNAP.EHBBFMCILPC.OGKGHLHHAAI("errortitle"), CCOJBMMKNAP.DBFFFOMCLKM().FIENAKIHNOM("ind"), new UnityAction(this.OHJHGOCPMIC), new UnityAction(this.CIDAFAOAPAE), (DFGILFBGPLN)(-13), 122f, -15);
			return;
		}
		CommonUserInterface.IKNOFBFMPGA().NFBMHHPIGFA(CCOJBMMKNAP.JMDJPKKOHNI().IPEIONBNIPH(""), CCOJBMMKNAP.PEBMGCKFNAO().FIENAKIHNOM("OnRestorePurchasesFailedUnknown"), CCOJBMMKNAP.ONCPHEEJLOP().OBDCPLLLGBB("shnts"), (DFGILFBGPLN)(-53), 1599f, -101);
	}

	// Token: 0x06008F13 RID: 36627 RVA: 0x003F2AB8 File Offset: 0x003F0CB8
	private void ECABAFFFEHD()
	{
		if (this.FGDEGMOLIDB && !LJNMIPMNOKF.IKNOFBFMPGA().PDLDAIOBEAB())
		{
			DPGJIJGOCIC.ANOPFDLPKGC("socialprofilesuspcantuse");
			this.OAJDBPJBABO();
			return;
		}
		this.FGDEGMOLIDB = false;
		AOBJLALDBAA.NMGMNAKLLMI().EGELHPJBAIC("OnWheelOfFortuneClick", 1409f);
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		CommonUserInterface.IKNOFBFMPGA().MCJIGJMFBMI();
		this.CMDIKMNEGEN();
		this.ShowCardOptionsOrDownload();
	}

	// Token: 0x06008F14 RID: 36628 RVA: 0x003F2B25 File Offset: 0x003F0D25
	private IEnumerator JMNBFBCLKLH()
	{
		while (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.JNNBNNDOGIM.EOCDHHBEKMF() > 0)
		{
			yield return new WaitForSeconds(0.5f);
			while (CommonUserInterface.EHBBFMCILPC.AnyGenericPopupIsActive() || LobbyUserInterface.EHBBFMCILPC.FriendsLetterPopupActive() || CommonUserInterface.EHBBFMCILPC.ConnectionAnimationEnabled())
			{
				yield return new WaitForSeconds(0.2f);
			}
			this.PEDAMIKCMKH = AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.JNNBNNDOGIM.OCEDALILCBL();
			if (this.PEDAMIKCMKH != null && this.PEDAMIKCMKH.BONNGONEJBO != null && this.PEDAMIKCMKH.BONNGONEJBO.Length > 0)
			{
				this.PKOEGOPHOIH = true;
				LobbyUserInterface.EHBBFMCILPC.ShowLetterReceivedAnimation(true, this.PEDAMIKCMKH.BONNGONEJBO, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("continue"), AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC, this.PEDAMIKCMKH, "OnFriendsMessageConsume");
			}
			yield return new WaitForSeconds(0.2f);
			while (this.PKOEGOPHOIH)
			{
				yield return new WaitForSeconds(0.2f);
			}
			yield return new WaitForSeconds(0.2f);
		}
		this.PFFIIOHPJCA = null;
		this.PKOEGOPHOIH = false;
		this.PEDAMIKCMKH = null;
		this.OnNeedToCheckForEmptyFriendsPage();
		yield break;
	}

	// Token: 0x06008F15 RID: 36629 RVA: 0x003F2B34 File Offset: 0x003F0D34
	public void OnPublicProfileNicknameEdit()
	{
		CommonUserInterface.EHBBFMCILPC.ShowPopupProfileNickNameInput();
	}

	// Token: 0x06008F16 RID: 36630 RVA: 0x003F2B40 File Offset: 0x003F0D40
	private void MGDJJIPNPHH()
	{
		if (this.PEDAMIKCMKH != null && this.PEDAMIKCMKH.BONNGONEJBO != null && this.PEDAMIKCMKH.BONNGONEJBO.Length > 0)
		{
			CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(96);
			JSONObject dmimkkciaph = null;
			if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null && AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA)
			{
				dmimkkciaph = AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.BNMFBKNEMIF();
				DPGJIJGOCIC.NFIDPOMCNLP("SocialStatsUserPublicProfile.modified = false, OnFriendsMessageConsume()");
				AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA = false;
			}
			JSONObject defaultOperationsJsonObject = ProfileItem2.GetDefaultOperationsJsonObject(0, true);
			defaultOperationsJsonObject.Add("frcmpid", this.PEDAMIKCMKH.EEBMPDNLJGD);
			defaultOperationsJsonObject.Add("frcmpidsuid", this.PEDAMIKCMKH.MIOEBKPPEHO);
			AKLFPGMDKLA.EHBBFMCILPC.CIPCINKGILF = true;
			BackendOperationsManager.EHBBFMCILPC.QueueBasicSync();
			BackendOperationsManager.EHBBFMCILPC.RequestGetUserPublicProfile(false, dmimkkciaph, defaultOperationsJsonObject, "OnBackendRequestConsumeMessageSuccess", "OnBackendRequestConsumeMessageException", false);
		}
	}

	// Token: 0x06008F17 RID: 36631 RVA: 0x003F2C40 File Offset: 0x003F0E40
	public void OnAddFirstFriend()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.GNLNPMPJPEC())
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialprivatenofriendsadd"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
			return;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.LAKHGAPCKBC)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialprofilesuspcantuse"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
			return;
		}
		this.OnAddFriendByUID();
	}

	// Token: 0x06008F18 RID: 36632 RVA: 0x003F2CF4 File Offset: 0x003F0EF4
	private void OCPPLJAPKAI()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("app42error"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupBackendError, 0f, 28);
		this.LEJIJOAOEBK = null;
		this.MHKKGOCMIJI = null;
		this.MarkAsModified();
	}

	// Token: 0x06008F19 RID: 36633 RVA: 0x003F2D60 File Offset: 0x003F0F60
	private void PNNJJBKJOGJ()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("app42error"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("retry"), new UnityAction(this.BPLLCMDACEH), DFGILFBGPLN.popupBackendError, 0f, 28);
		this.MarkAsModified();
	}

	// Token: 0x06008F1A RID: 36634 RVA: 0x003F2DCC File Offset: 0x003F0FCC
	private void NJJCAKEGPJG(PMEPALPCEAF FOKFGMIEEDB)
	{
		foreach (object obj in this.favoriteStories.transform)
		{
			((Transform)obj).gameObject.SetActive(false);
		}
		if (FOKFGMIEEDB.CFDOLDIADOP().Count != 0)
		{
			this.titleFavoriteStories.SetActive(true);
			this.favoriteStories.SetActive(true);
			this.noFavoriteStories.SetActive(false);
			for (int i = 0; i < FOKFGMIEEDB.CFDOLDIADOP().Count; i++)
			{
				if (i < this.favoriteStories.transform.childCount)
				{
					ProfileItem2.OKPDIJGNNKK okpdijgnnkk = new ProfileItem2.OKPDIJGNNKK();
					okpdijgnnkk.<>4__this = this;
					Transform child = this.favoriteStories.transform.GetChild(i);
					child.gameObject.SetActive(true);
					int index = FOKFGMIEEDB.CFDOLDIADOP().Count - 1 - i;
					okpdijgnnkk.sprite = AssetsManager.EHBBFMCILPC.profileDataLocalizedAsset.IGOCHGKDHAF(FOKFGMIEEDB.CFDOLDIADOP()[index]);
					child.GetComponent<ContentFavoriteItem>().imageThumb.sprite = okpdijgnnkk.sprite;
					Button component = child.GetComponent<Button>();
					component.onClick.RemoveAllListeners();
					if (!this.IJPMLEKMGMA.GIFPFPOPEJN)
					{
						component.onClick.AddListener(new UnityAction(this.NLFKPKJJADF));
					}
					else
					{
						component.onClick.AddListener(new UnityAction(okpdijgnnkk.EDPKNJPKFGE));
					}
				}
			}
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.favoriteStories.GetComponent<RectTransform>());
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentMainTransform.GetComponent<RectTransform>());
			return;
		}
		if (FOKFGMIEEDB.GIFPFPOPEJN)
		{
			this.titleFavoriteStories.SetActive(false);
			this.noFavoriteStories.SetActive(false);
			this.favoriteStories.SetActive(false);
			return;
		}
		this.titleFavoriteStories.SetActive(true);
		this.noFavoriteStories.SetActive(true);
		this.favoriteStories.SetActive(false);
	}

	// Token: 0x06008F1B RID: 36635 RVA: 0x003F2FCC File Offset: 0x003F11CC
	private void KMPHJNAEECD(PMEPALPCEAF FOKFGMIEEDB)
	{
		Transform transform = this.tradingCards.transform;
		while (transform.childCount > 0)
		{
			UnityEngine.Object.DestroyImmediate(transform.GetChild(0).gameObject);
		}
		Vector2 onkonhljkpg = this.CalculateViewportUpDownMargins(this.mainScrollView);
		List<int> list = AKLFPGMDKLA.EHBBFMCILPC.NDINEHGFPNN(FOKFGMIEEDB);
		List<int> list2 = FOKFGMIEEDB.MHOAOIMAPIJ();
		if (list2.Count != 0)
		{
			this.titleTradingCards.SetActive(true);
			this.tradingCards.SetActive(true);
			using (List<int>.Enumerator enumerator = list2.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					ProfileItem2.CJKJBHCMAFA cjkjbhcmafa = new ProfileItem2.CJKJBHCMAFA();
					cjkjbhcmafa.<>4__this = this;
					cjkjbhcmafa.id = enumerator.Current;
					ContentCardItem component = UnityEngine.Object.Instantiate<GameObject>(this.cardItem, transform).GetComponent<ContentCardItem>();
					component.SetContent(cjkjbhcmafa.id, FOKFGMIEEDB.GIFPFPOPEJN, onkonhljkpg, false, false);
					component.onCardPressButton.onClick.AddListener(new UnityAction(cjkjbhcmafa.EKHOEHLNPME));
					if (FOKFGMIEEDB.GIFPFPOPEJN && !AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.EEBMPDNLJGD.Equals(FOKFGMIEEDB.EEBMPDNLJGD) && list.Contains(cjkjbhcmafa.id))
					{
						component.tradingFrameAnimation.gameObject.SetActive(true);
						component.tradingFrameAnimation.framesSD = AssetsManager.EHBBFMCILPC.profileDataAsset3.tradeMatchSprites.ToArray();
					}
				}
				goto IL_177;
			}
		}
		this.titleTradingCards.SetActive(false);
		this.tradingCards.SetActive(false);
		IL_177:
		LayoutRebuilder.ForceRebuildLayoutImmediate(transform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentMainTransform.GetComponent<RectTransform>());
	}

	// Token: 0x06008F1D RID: 36637 RVA: 0x003F31BC File Offset: 0x003F13BC
	private void EBDNNEJFEPB()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("app42error"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupBackendError, 0f, 28);
		this.LEJIJOAOEBK = null;
		this.MHKKGOCMIJI = null;
		this.PNPEHMLHDPO = null;
		this.HHOHNKNPNGB = false;
		if (this.OMBEJHJDJKG != null)
		{
			base.StopCoroutine(this.OMBEJHJDJKG);
		}
		this.OMBEJHJDJKG = null;
		this.showingCardGiftAnimation = false;
		LobbyUserInterface.EHBBFMCILPC.GetPopupCardOptions().ResetCustomMessageToFriend();
		this.PGGPPCINLMB = "";
		this.KEIKGFKANOL = "";
		this.MarkAsModified();
	}

	// Token: 0x06008F1E RID: 36638 RVA: 0x003F327D File Offset: 0x003F147D
	private IEnumerator HCAHEOPANBC(int HILOIJENNPF)
	{
		this.FGDEGMOLIDB = true;
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().EPJKDCDOEMM(0);
		if (this.EPNOBCLPJJO == HKPBEDBPHNJ.viewGiftCardAsIncomingGift)
		{
			CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithHint("", 0);
		}
		else
		{
			CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithProgress(96);
		}
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnLiveProfileThemesLoaderStop", 0f);
		while (AssetsManager.EHBBFMCILPC.IsBusy())
		{
			yield return new WaitForSeconds(0.05f);
		}
		yield return new WaitForSeconds(0.2f);
		List<CLGFGOHBCGJ> poolCards = LJNMIPMNOKF.EHBBFMCILPC.PBFNFGOPBDD(HILOIJENNPF);
		if (poolCards.Count == 0)
		{
			DPGJIJGOCIC.NFIDPOMCNLP("ProfileItem2._DownloadCardsPool(): nothing to download around scroll index " + LJNMIPMNOKF.EHBBFMCILPC.MHBBGCGFFCG().ToString());
			this.ShowCardOptionsOrDownload();
			yield break;
		}
		int num = KDCJJBLGCBH.EHBBFMCILPC.HCBECFNMNKN();
		if (num > 0 && num < HILOIJENNPF)
		{
			num = HILOIJENNPF;
		}
		int num2 = LJNMIPMNOKF.EHBBFMCILPC.KELCPLOLNHD(num);
		if (num2 > 0)
		{
			DPGJIJGOCIC.NFIDPOMCNLP("ProfileItem2._DownloadCardsPool(): released " + num2.ToString() + " far card(s), unloading unused assets");
			yield return null;
			yield return Resources.UnloadUnusedAssets();
		}
		while (AssetsManager.EHBBFMCILPC.IsBusy())
		{
			yield return new WaitForSeconds(0.05f);
		}
		DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(new string[]
		{
			"ProfileItem2._DownloadCardsPool(): downloading ",
			poolCards.Count.ToString(),
			" card(s) around scroll index ",
			LJNMIPMNOKF.EHBBFMCILPC.MHBBGCGFFCG().ToString(),
			", direction ",
			LJNMIPMNOKF.EHBBFMCILPC.LCJPIFHBLLN().ToString()
		}));
		for (int i = 0; i < poolCards.Count; i++)
		{
			int mefkfohcohk = poolCards[i].CCMDLENEDGJ;
			int num3 = GKJPOGNFKNK.IDKIIANDMPM(poolCards[i].CCMDLENEDGJ);
			if (num3 >= 0)
			{
				mefkfohcohk = num3;
			}
			AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleCollectableCard, mefkfohcohk, -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
		}
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().CLIOEOLFFLO(LEJKDNAGDHC.Fast);
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().GIJKJMMDJEL(0f, 1f);
		AssetsManager.EHBBFMCILPC.DownloadQueuedAssetBundles("OnAllCollectableCardsDownloadSuccess", "OnAllCollectableCardsDownloadFailed", false);
		yield break;
	}

	// Token: 0x06008F1F RID: 36639 RVA: 0x003F3294 File Offset: 0x003F1494
	private void CACMLMNBBOA()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		if (AKLFPGMDKLA.EHBBFMCILPC.AONCINPNHDD.Count == 0)
		{
			CommonUserInterface.IKNOFBFMPGA().NFBMHHPIGFA(CCOJBMMKNAP.HFAKOKBHCGH().BGELFMIOBCL("[LoadingEnv] direct cache files of "), CCOJBMMKNAP.DLGLFACMHPG().DNILNCLIHAP("propoff"), CCOJBMMKNAP.MPCBJEIMACA().HHLECNIFHCO("energyhinttitle"), (DFGILFBGPLN)116, 650f, 33);
			return;
		}
		this.ShowHallOfFame();
	}

	// Token: 0x06008F20 RID: 36640 RVA: 0x003F3304 File Offset: 0x003F1504
	private void MGFBNEAFIKF(PMEPALPCEAF FOKFGMIEEDB)
	{
		ProfileItem2.expandBadgesByDefault = true;
		Transform transform = this.badges.transform;
		List<Sprite> list = FOKFGMIEEDB.JMJOEHHFJGC(FOKFGMIEEDB.GIFPFPOPEJN);
		if (list.Count != 0)
		{
			foreach (object obj in this.badges.transform)
			{
				Transform transform2 = (Transform)obj;
				transform2.GetComponent<Button>().onClick.RemoveAllListeners();
				transform2.gameObject.SetActive(false);
			}
			for (int i = 0; i < list.Count; i++)
			{
				if (i < this.badges.transform.childCount)
				{
					ProfileItem2.AMJLGCFIOJF amjlgcfiojf = new ProfileItem2.AMJLGCFIOJF();
					amjlgcfiojf.<>4__this = this;
					Transform child = this.badges.transform.GetChild(i);
					child.gameObject.SetActive(true);
					amjlgcfiojf.sprite = list[i];
					child.GetComponent<ContentBadgeItem>().imageThumb.sprite = amjlgcfiojf.sprite;
					child.GetComponent<Button>().onClick.AddListener(new UnityAction(amjlgcfiojf.HLNPBBABIJH));
				}
			}
		}
		this.badgesExpandButton.onClick.RemoveAllListeners();
		this.badgesExpandButton.GetComponent<AnimationPress>().enabled = false;
		this.badgesExpandButton.GetComponent<Button>().enabled = false;
		this.badgesHiddenTextDropDown.color = new Color(1f, 1f, 1f, 0.25f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(transform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentMainTransform.GetComponent<RectTransform>());
	}

	// Token: 0x06008F21 RID: 36641 RVA: 0x003F34B0 File Offset: 0x003F16B0
	private void MBKOJNIJGLA()
	{
		try
		{
			if (!GOCBEOKKPDL.JHIDJNFGJBI(this.PDPJFCHINPN))
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cardoptionsloadingthemevideo"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0.15f, 28);
			}
			else
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("areyousure"), HBKMKCBPJDI.INPBNGMJOHC(), HBKMKCBPJDI.JDBMIIKHEMK(), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("no"), new UnityAction(this.IPHIGLDCBAB), new UnityAction(this.OnGenericDoNothing), DFGILFBGPLN.popupQuitConfirm, 0.15f, 28);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06008F22 RID: 36642 RVA: 0x003F357C File Offset: 0x003F177C
	private void CMCBNFNOLBF()
	{
		int bopaaipgbca = this.BOPAAIPGBCA;
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.BIAEAOMHBMM().HPOAGPJFHPM("spark"), CCOJBMMKNAP.KFAABHHGOPO().BDGPNPNIAPA("PurchaseManagerSteam.CompletePurchase(): Pending product purchase confirmed."), CCOJBMMKNAP.KNKGCDDMLDP().FCOCLEHKLDJ("OnBackendUpdateFriendsDataException"), CCOJBMMKNAP.PMABBOJDELF().JHNELLJFBGC("Critical error, could not load asset bundle:"), new UnityAction(this.DIEJPDHOGGN), new UnityAction(this.OnGenericDoNothing), (DFGILFBGPLN)(-128), 1380f, -94);
	}

	// Token: 0x06008F23 RID: 36643 RVA: 0x003F35F8 File Offset: 0x003F17F8
	private void FHAJFICFLBG(PMEPALPCEAF FOKFGMIEEDB)
	{
		ProfileItem2.MKFJNJFDLOM mkfjnjfdlom = new ProfileItem2.MKFJNJFDLOM();
		mkfjnjfdlom.<>4__this = this;
		mkfjnjfdlom._profile = FOKFGMIEEDB;
		this.cardsHidden.SetActive(false);
		Transform transform = this.cards.transform;
		while (transform.childCount > 0)
		{
			UnityEngine.Object.DestroyImmediate(transform.GetChild(0).gameObject);
		}
		this.cardsHiddenTextDropDown.color = new Color(1f, 1f, 1f, 1f);
		Vector2 onkonhljkpg = this.CalculateViewportUpDownMargins(this.mainScrollView);
		List<int> list = mkfjnjfdlom._profile.FCCNNMOIMGC();
		if (list.Count != 0)
		{
			this.titleCards.SetActive(true);
			this.cards.SetActive(true);
			for (int i = 0; i < list.Count; i++)
			{
				ProfileItem2.HJGACLMFJNO hjgaclmfjno = new ProfileItem2.HJGACLMFJNO();
				hjgaclmfjno.CS$<>8__locals1 = mkfjnjfdlom;
				if (i == this.maxShownItems && !ProfileItem2.expandCollectedCardsByDefault)
				{
					this.cardsHidden.SetActive(true);
					string collectedCardsNoteText = this.GetCollectedCardsNoteText();
					this.cardsHiddenText.SetText(collectedCardsNoteText, true);
					this.cardsHiddenText.text = collectedCardsNoteText;
					this.cardsExpandButton.GetComponent<AnimationPress>().enabled = true;
					this.cardsExpandButton.GetComponent<Button>().enabled = true;
					this.cardsExpandButton.onClick.RemoveAllListeners();
					UnityEvent onClick = this.cardsExpandButton.onClick;
					UnityAction call;
					if ((call = hjgaclmfjno.CS$<>8__locals1.<>9__1) == null)
					{
						call = (hjgaclmfjno.CS$<>8__locals1.<>9__1 = new UnityAction(hjgaclmfjno.CS$<>8__locals1.HIBBFPMGPCD));
					}
					onClick.AddListener(call);
					break;
				}
				hjgaclmfjno.id = list[i];
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.cardItem, transform);
				gameObject.GetComponent<ContentCardItem>().SetContent(hjgaclmfjno.id, hjgaclmfjno.CS$<>8__locals1._profile.GIFPFPOPEJN, onkonhljkpg, false, false);
				gameObject.GetComponent<ContentCardItem>().onCardPressButton.onClick.AddListener(new UnityAction(hjgaclmfjno.HLEEDGJHHCG));
			}
			if (list.Count >= this.maxShownItems && ProfileItem2.expandCollectedCardsByDefault)
			{
				this.cardsHidden.SetActive(true);
				string collectedCardsNoteText2 = this.GetCollectedCardsNoteText();
				this.cardsHiddenText.SetText(collectedCardsNoteText2, true);
				this.cardsHiddenText.text = collectedCardsNoteText2;
				this.cardsExpandButton.onClick.RemoveAllListeners();
				this.cardsExpandButton.GetComponent<AnimationPress>().enabled = false;
				this.cardsExpandButton.GetComponent<Button>().enabled = false;
				this.cardsHiddenTextDropDown.color = new Color(1f, 1f, 1f, 0.25f);
			}
		}
		else
		{
			this.titleCards.SetActive(false);
			this.cards.SetActive(false);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(transform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentMainTransform.GetComponent<RectTransform>());
	}

	// Token: 0x06008F24 RID: 36644 RVA: 0x00003E52 File Offset: 0x00002052
	private void BPBKGDNAGHL()
	{
	}

	// Token: 0x06008F25 RID: 36645 RVA: 0x003F38CC File Offset: 0x003F1ACC
	private void ADBHDBOAGHG()
	{
		if (this.LEJIJOAOEBK != null && this.LEJIJOAOEBK.EEBMPDNLJGD.Length > 0)
		{
			string eempglhpkjg = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialfriendmatchtitle").Replace("XXX", this.LEJIJOAOEBK.OFOIECEHOCN.ToString() + "%");
			string text;
			if (this.LEJIJOAOEBK.OFOIECEHOCN == 0 || this.LEJIJOAOEBK.CIKCGDECCMM.Count == 0)
			{
				text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialfriendmatchinfo1");
			}
			else
			{
				text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialfriendmatchinfo0") + "\n\n";
			}
			int num = 0;
			for (int i = 0; i < this.LEJIJOAOEBK.CIKCGDECCMM.Count; i++)
			{
				if (num > 0)
				{
					text += ", ";
				}
				string str = GKJPOGNFKNK.DNILNCLIHAP("anthology" + this.LEJIJOAOEBK.CIKCGDECCMM[i].ToString(), "anthologiestitle", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
				text += str;
				num++;
			}
			if (num > 0)
			{
				text += ".";
			}
			if (num > 48)
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(eempglhpkjg, text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupQuitConfirm, 0f, 13);
			}
			else if (num > 40)
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(eempglhpkjg, text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupQuitConfirm, 0f, 16);
			}
			else if (num > 32)
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(eempglhpkjg, text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupQuitConfirm, 0f, 19);
			}
			else if (num > 24)
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(eempglhpkjg, text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupQuitConfirm, 0f, 22);
			}
			else if (num > 16)
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(eempglhpkjg, text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupQuitConfirm, 0f, 25);
			}
			else
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(eempglhpkjg, text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupQuitConfirm, 0f, 28);
			}
		}
		this.LEJIJOAOEBK = null;
		this.MHKKGOCMIJI = null;
	}

	// Token: 0x06008F26 RID: 36646 RVA: 0x003F3B14 File Offset: 0x003F1D14
	private void KBDAHECFAJM()
	{
		if (this.FGDEGMOLIDB && !LJNMIPMNOKF.EHBBFMCILPC.IHOIGNLKNDA())
		{
			DPGJIJGOCIC.ANOPFDLPKGC("ProfileItem2.OnAllCollectableCardsDownloadSuccess(): the pool ended but the scroll index card is still not resident");
			this.OAJDBPJBABO();
			return;
		}
		this.FGDEGMOLIDB = false;
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnLiveProfileThemesLoaderStart", 0f);
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		this.CMDIKMNEGEN();
		this.ShowCardOptionsOrDownload();
	}

	// Token: 0x06008F27 RID: 36647 RVA: 0x003F3B81 File Offset: 0x003F1D81
	private void NFNBFHKBACB()
	{
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(36))
		{
			AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(36);
			this.FBEEAPGBKBL();
			return;
		}
		this.FBEEAPGBKBL();
	}

	// Token: 0x06008F28 RID: 36648 RVA: 0x003F3BAC File Offset: 0x003F1DAC
	public void ConfirmClearFavorites(GameObject IACFDHCDEME)
	{
		ProfileItem2.PAOHHKHKLLF paohhkhkllf = new ProfileItem2.PAOHHKHKLLF();
		paohhkhkllf.<>4__this = this;
		paohhkhkllf.gameObject = IACFDHCDEME;
		if (paohhkhkllf.gameObject.name == this.contentWishedCardsPage.name)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("areyousure"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("clearwishedchardsbody"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("no"), new UnityAction(paohhkhkllf.FKIPHHGIFHE), new UnityAction(this.DDAPKKMDGHN), DFGILFBGPLN.popupQuitConfirm, 0f, 28);
			return;
		}
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("areyousure"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("clearfavbody"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("no"), new UnityAction(paohhkhkllf.MGCIGOLBHJJ), new UnityAction(this.DDAPKKMDGHN), DFGILFBGPLN.popupQuitConfirm, 0f, 28);
	}

	// Token: 0x06008F29 RID: 36649 RVA: 0x003F3CBC File Offset: 0x003F1EBC
	private void JDGKEADKALN()
	{
		try
		{
			HBKMKCBPJDI.NCCEKKBFOBJ();
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06008F2A RID: 36650 RVA: 0x00003E52 File Offset: 0x00002052
	private void PCLAMCPKJGE()
	{
	}

	// Token: 0x06008F2B RID: 36651 RVA: 0x003F3CE8 File Offset: 0x003F1EE8
	private void EGBJEEJMCFB()
	{
		this.IGNJLJIKCHI();
	}

	// Token: 0x06008F2C RID: 36652 RVA: 0x003F3CF0 File Offset: 0x003F1EF0
	private void GHGKHLGNDKI()
	{
		for (int i = 0; i < this.blurredPreviews.Count; i++)
		{
			this.blurredPreviews[i].sprite = null;
			this.blurredPreviews[i].color = new Color(1f, 1f, 1f, 1f);
			this.blurredPreviews[i].gameObject.SetActive(false);
		}
		for (int j = 0; j < this.gradientsBottom.Count; j++)
		{
			this.gradientsBottom[j].color = new Color(1f, 1f, 1f, this.gradientsBottom[j].color.a);
		}
		for (int k = 0; k < this.gradientsTop.Count; k++)
		{
			this.gradientsTop[k].color = new Color(1f, 1f, 1f, this.gradientsTop[k].color.a);
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OJKHMNEIGPF == HGCFJKCOKPM.dark)
		{
			try
			{
				Color color = new Color(1f, 1f, 1f, 1f);
				Color color2 = new Color(1f, 1f, 1f, 1f);
				for (int l = 0; l < this.blurredPreviews.Count; l++)
				{
					this.blurredPreviews[l].gameObject.SetActive(true);
				}
				if (null != this.JOBMFPFIMHM)
				{
					UnityEngine.Object.Destroy(this.JOBMFPFIMHM);
				}
				this.JOBMFPFIMHM = DPGJIJGOCIC.PJFBIMFLEHP(AssetsManager.EHBBFMCILPC.profileDataAsset.DJNLJPFFMBG(this.IJPMLEKMGMA.PGJBIPFBMAN()), 2, 16, ref color);
				for (int m = 0; m < this.blurredPreviews.Count; m++)
				{
					this.blurredPreviews[m].sprite = this.JOBMFPFIMHM;
				}
				float num = color.r;
				if (color.g < num)
				{
					num = color.g;
				}
				if (color.b < num)
				{
					num = color.b;
				}
				float num2 = 1f / num;
				color2.r = color.r * num2 * 0.5f;
				color2.g = color.g * num2 * 0.5f;
				color2.b = color.b * num2 * 0.5f;
				float num3 = (color2.r + color2.g + color2.b) / 3f;
				if (num3 > 0.375f)
				{
					float num4 = num3 / 0.375f;
					color2.r /= num4;
					color2.g /= num4;
					color2.b /= num4;
				}
				color2.a = 0.375f;
				for (int n = 0; n < this.blurredPreviews.Count; n++)
				{
					this.blurredPreviews[n].color = color2;
				}
				color2 *= 1.6f;
				for (int num5 = 0; num5 < this.gradientsTop.Count; num5++)
				{
					color2.a = this.gradientsTop[num5].color.a;
					this.gradientsTop[num5].color = color2;
				}
				for (int num6 = 0; num6 < this.gradientsBottom.Count; num6++)
				{
					color2.a = this.gradientsBottom[num6].color.a;
					this.gradientsBottom[num6].color = color2;
				}
			}
			catch (Exception aklgbjkdomm)
			{
				for (int num7 = 0; num7 < this.blurredPreviews.Count; num7++)
				{
					this.blurredPreviews[num7].sprite = null;
					this.blurredPreviews[num7].color = new Color(1f, 1f, 1f, 1f);
					this.blurredPreviews[num7].gameObject.SetActive(false);
				}
				for (int num8 = 0; num8 < this.gradientsBottom.Count; num8++)
				{
					this.gradientsBottom[num8].color = new Color(1f, 1f, 1f, this.gradientsBottom[num8].color.a);
				}
				for (int num9 = 0; num9 < this.gradientsTop.Count; num9++)
				{
					this.gradientsTop[num9].color = new Color(1f, 1f, 1f, this.gradientsTop[num9].color.a);
				}
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
	}

	// Token: 0x06008F2D RID: 36653 RVA: 0x003F41FC File Offset: 0x003F23FC
	private void OLODCPEPPLH()
	{
		this.LEBIMELAHBC = false;
		int bopaaipgbca = this.BOPAAIPGBCA;
		string text = string.Concat(new string[]
		{
			"<align=\"center\"><alpha=#88>",
			CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialcardvolinfonotev2").Replace("XXX", GDJPPKAMIFL.EHBBFMCILPC.DKHIPEPOEFF(bopaaipgbca) ?? "").Replace("YYY", "<i>" + GKJPOGNFKNK.DNILNCLIHAP(bopaaipgbca, "cardschar", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()) + "</i>").Replace("ZZZ", "<i>" + GKJPOGNFKNK.DNILNCLIHAP("anthology" + LJNMIPMNOKF.EHBBFMCILPC.KMDBNEFCPOH(bopaaipgbca).AMKCLHLIIMN.ToString(), "anthologiestitle", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()) + "</i>"),
			"<alpha=#FF><align=\"left\">\n\n<i>",
			GDJPPKAMIFL.EHBBFMCILPC.IOFAJAJFMOI(bopaaipgbca),
			"</i>"
		});
		if (this.IJPMLEKMGMA.GIFPFPOPEJN)
		{
			string eempglhpkjg = GDJPPKAMIFL.EHBBFMCILPC.KCMKJBHBCGC(bopaaipgbca);
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(eempglhpkjg, text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
			return;
		}
		text = text + "\n\n" + this.JCGKPCKNAKF(bopaaipgbca);
		string eempglhpkjg2 = GDJPPKAMIFL.EHBBFMCILPC.KCMKJBHBCGC(bopaaipgbca);
		string text2 = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialcollectedcardbreakv2");
		if (LJNMIPMNOKF.EHBBFMCILPC.KMDBNEFCPOH(bopaaipgbca).ENCCLBLHJMC > 0 && (LJNMIPMNOKF.EHBBFMCILPC.KMDBNEFCPOH(bopaaipgbca).HFLPLGMJNOI > 0 || LJNMIPMNOKF.EHBBFMCILPC.JLBLFIEFFFI(bopaaipgbca)))
		{
			if (LJNMIPMNOKF.EHBBFMCILPC.KMDBNEFCPOH(bopaaipgbca).HFLPLGMJNOI > 0)
			{
				if (AKLFPGMDKLA.EHBBFMCILPC.PHFJHKELAAA(bopaaipgbca))
				{
					CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithFourButtonsInside(eempglhpkjg2, text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialcollectedcardopenv2"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cardoptionssendasgift"), text2, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialremovetradeable"), new UnityAction(this.OnCardViewAsCollectedClick), new UnityAction(this.OnCardViewClickFromMyProfile), new UnityAction(this.OnBreakCardClick), new UnityAction(this.CJKFKPMDEFD), new UnityAction(this.OnGenericDoNothing), DFGILFBGPLN.popupEnergyHint, 0f, 28);
				}
				else
				{
					CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithFourButtonsInside(eempglhpkjg2, text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialcollectedcardopenv2"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cardoptionssendasgift"), text2, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialmaketradeable"), new UnityAction(this.OnCardViewAsCollectedClick), new UnityAction(this.OnCardViewClickFromMyProfile), new UnityAction(this.OnBreakCardClick), new UnityAction(this.DAEHGLPOIBD), new UnityAction(this.OnGenericDoNothing), DFGILFBGPLN.popupEnergyHint, 0f, 28);
				}
			}
			else
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithFourButtonsInside(eempglhpkjg2, text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialcollectedcardopenv2"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cardoptionssendasgift"), text2, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialmaketradeable"), new UnityAction(this.OnCardViewAsCollectedClick), new UnityAction(this.OnCardViewClickFromMyProfile), new UnityAction(this.OnBreakCardClick), new UnityAction(this.GLEMNIJOPCE), new UnityAction(this.OnGenericDoNothing), DFGILFBGPLN.popupEnergyHint, 0f, 28);
			}
		}
		else if (LJNMIPMNOKF.EHBBFMCILPC.KMDBNEFCPOH(bopaaipgbca).ENCCLBLHJMC > 0)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithFourButtonsInside(eempglhpkjg2, text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialcollectedcardopenv2"), text2, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialmakegiftcard"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialmaketradeable"), new UnityAction(this.OnCardViewAsCollectedClick), new UnityAction(this.OnBreakCardClick), new UnityAction(this.NFNBFHKBACB), new UnityAction(this.GLEMNIJOPCE), new UnityAction(this.OnGenericDoNothing), DFGILFBGPLN.popupEnergyHint, 0f, 28);
		}
		else if (LJNMIPMNOKF.EHBBFMCILPC.KMDBNEFCPOH(bopaaipgbca).HFLPLGMJNOI > 0 || LJNMIPMNOKF.EHBBFMCILPC.JLBLFIEFFFI(bopaaipgbca))
		{
			if (LJNMIPMNOKF.EHBBFMCILPC.KMDBNEFCPOH(bopaaipgbca).HFLPLGMJNOI > 0)
			{
				if (AKLFPGMDKLA.EHBBFMCILPC.PHFJHKELAAA(bopaaipgbca))
				{
					CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithThreeButtonsInside(eempglhpkjg2, text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialcollectedcardopenv2"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cardoptionssendasgift"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialremovetradeable"), new UnityAction(this.OnCardViewAsCollectedClick), new UnityAction(this.OnCardViewClickFromMyProfile), new UnityAction(this.CJKFKPMDEFD), new UnityAction(this.OnGenericDoNothing), DFGILFBGPLN.popupEnergyHint, 0f, 28);
				}
				else
				{
					CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithThreeButtonsInside(eempglhpkjg2, text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialcollectedcardopenv2"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cardoptionssendasgift"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialmaketradeable"), new UnityAction(this.OnCardViewAsCollectedClick), new UnityAction(this.OnCardViewClickFromMyProfile), new UnityAction(this.DAEHGLPOIBD), new UnityAction(this.OnGenericDoNothing), DFGILFBGPLN.popupEnergyHint, 0f, 28);
				}
			}
			else
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtonsAndCloseOverride(eempglhpkjg2, text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialcollectedcardopenv2"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cardoptionssendasgift"), new UnityAction(this.OnCardViewAsCollectedClick), new UnityAction(this.OnCardViewClickFromMyProfile), new UnityAction(this.OnGenericDoNothing), DFGILFBGPLN.popupEnergyHint, 0f, 28);
			}
		}
		else
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(eempglhpkjg2, text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialcollectedcardopenv2"), new UnityAction(this.OnCardViewAsCollectedClick), new UnityAction(this.OnGenericDoNothing), DFGILFBGPLN.popupEnergyHint, 0f, 28);
		}
		this.GKBMOLFNBOH = bopaaipgbca;
	}

	// Token: 0x06008F2E RID: 36654 RVA: 0x003F47CC File Offset: 0x003F29CC
	private void KMBMOJNJBFJ(PMEPALPCEAF FOKFGMIEEDB)
	{
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		foreach (BNFCLKNDBLO bnfclkndblo in FOKFGMIEEDB.IPILOAEGBMD())
		{
			if (dictionary.ContainsKey(bnfclkndblo.AMKCLHLIIMN))
			{
				Dictionary<int, int> dictionary2 = dictionary;
				int amkclhliimn = bnfclkndblo.AMKCLHLIIMN;
				int num = dictionary2[amkclhliimn];
				dictionary2[amkclhliimn] = num + 1;
			}
			else
			{
				dictionary.Add(bnfclkndblo.AMKCLHLIIMN, 1);
			}
		}
		RectTransform viewport = this.cutscenesScrollView.GetComponent<ScrollRect>().viewport;
		foreach (KeyValuePair<int, int> keyValuePair in dictionary)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.cutsceneItem, this.contentCutscenesTransform);
			ValueTuple<int, int, PMEPALPCEAF, UnityAction<GameObject>, UnityAction<BNFCLKNDBLO, GameObject, GameObject>, UnityAction<BNFCLKNDBLO>, UnityAction, ValueTuple<RectTransform, bool>> content = new ValueTuple<int, int, PMEPALPCEAF, UnityAction<GameObject>, UnityAction<BNFCLKNDBLO, GameObject, GameObject>, UnityAction<BNFCLKNDBLO>, UnityAction, ValueTuple<RectTransform, bool>>(keyValuePair.Key, keyValuePair.Value, FOKFGMIEEDB, new UnityAction<GameObject>(this.OnCutsceneRenameClick), new UnityAction<BNFCLKNDBLO, GameObject, GameObject>(this.ConfirmCutsceneDelete), new UnityAction<BNFCLKNDBLO>(this.OnCutsceneClick), new UnityAction(this.AOKJHPAKJFJ), new ValueTuple<RectTransform, bool>(viewport, FOKFGMIEEDB.AMBKNMKIDPH(keyValuePair.Key)));
			gameObject.GetComponent<ContentCutsceneItem>().SetContent(content);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentCutscenesTransform.GetComponent<RectTransform>());
		this.AOKJHPAKJFJ();
	}

	// Token: 0x06008F2F RID: 36655 RVA: 0x003F4934 File Offset: 0x003F2B34
	private void Start()
	{
		this.PFEEFOKHKMP = base.transform.localScale;
	}

	// Token: 0x06008F30 RID: 36656 RVA: 0x003F4948 File Offset: 0x003F2B48
	private void EKIOCPPHBCP()
	{
		string text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("mypachievtitle");
		text = text.Replace("XXX", this.IJPMLEKMGMA.PEBKLGDBGHC().Count.ToString() ?? "");
		text = text.Replace("YYY", GKJPOGNFKNK.EALDMCLPMPH(AssetsManager.EHBBFMCILPC.profileDataAsset.JHFNENEICGB(), true).Count.ToString() ?? "");
		this.contentAnthologyAchievementsHeaderStatus.SetText(text, true);
		this.contentAnthologyAchievementsHeaderStatus.text = text;
		base.StartCoroutine(this.ICNHLKBOIGD(this.contentAnthologyAchievementsHeaderStatus.transform));
	}

	// Token: 0x06008F31 RID: 36657 RVA: 0x003F49FA File Offset: 0x003F2BFA
	private void GPCAMDKPLPM()
	{
		this.LEBIMELAHBC = false;
	}

	// Token: 0x06008F32 RID: 36658 RVA: 0x003F4A03 File Offset: 0x003F2C03
	private IEnumerator KPJNBMLJBMP()
	{
		yield return new WaitForEndOfFrame();
		yield return new WaitForSeconds(0.1f);
		this.ExecuteCardUpgradeBackendRequest();
		yield break;
	}

	// Token: 0x06008F33 RID: 36659 RVA: 0x003F4A14 File Offset: 0x003F2C14
	private void BOKGAFLFDDF(GameObject PHLJNFHEEIB)
	{
		if (PHLJNFHEEIB.name == this.contentCharactersPage.name)
		{
			this.IJPMLEKMGMA.HFOONKBBIKD();
			foreach (object obj in this.contentCharactersTransform)
			{
				((Transform)obj).GetComponent<ContentGridItem>().IILJLBBEJHO();
			}
			this.UpdateHeaderStatus(FFIAHOPJJJG.Avatar);
		}
		if (PHLJNFHEEIB.name == this.contentStoriesPage.name)
		{
			this.IJPMLEKMGMA.ODIAOMJMCPA();
			foreach (object obj2 in this.contentStoriesTransform)
			{
				((Transform)obj2).GetComponent<ContentGridItem>().ODBJIONMODC();
			}
			this.UpdateHeaderStatus((FFIAHOPJJJG)8);
		}
		if (PHLJNFHEEIB.name == this.contentCutscenesPage.name)
		{
			this.IJPMLEKMGMA.GPCDLDEHOMP();
			foreach (object obj3 in this.contentCutscenesTransform)
			{
				ContentCusceneSmallItem[] componentsInChildren = ((Transform)obj3).GetComponentsInChildren<ContentCusceneSmallItem>();
				for (int i = 0; i < componentsInChildren.Length; i += 0)
				{
					componentsInChildren[i].LJHDHBIAHMO();
				}
			}
		}
		if (PHLJNFHEEIB.name == this.contentWishedCardsPage.name)
		{
			AKLFPGMDKLA.EHBBFMCILPC.NAKGMGBDKEE();
			foreach (object obj4 in this.contentWishedCardsPageTransform)
			{
				((Transform)obj4).GetComponent<ContentCardItem>().FCDKFGJHJNL();
			}
			this.UpdateHeaderStatus((FFIAHOPJJJG)6);
		}
	}

	// Token: 0x06008F34 RID: 36660 RVA: 0x003F4C00 File Offset: 0x003F2E00
	private void MBINJIMBJAG()
	{
		if (this.CAPOPEIGMOB != null && this.CAPOPEIGMOB.EEBMPDNLJGD.Length > 0)
		{
			this.OnAddFriendByProfileId(this.CAPOPEIGMOB.EEBMPDNLJGD);
		}
		this.CAPOPEIGMOB = null;
		this.HHOHNKNPNGB = false;
	}

	// Token: 0x06008F35 RID: 36661 RVA: 0x003F4C3C File Offset: 0x003F2E3C
	private void HIODKHCOJOE()
	{
		this.FGDEGMOLIDB = false;
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnLiveProfileThemesLoaderStart", 0f);
		if (this.EPNOBCLPJJO == HKPBEDBPHNJ.viewGiftCardAsIncomingGift)
		{
			LobbyUserInterface.EHBBFMCILPC.ShowLetterDisappearAnimation("");
			this.LEJIJOAOEBK = null;
			this.MHKKGOCMIJI = null;
			this.PNPEHMLHDPO = null;
			this.HHOHNKNPNGB = false;
			if (this.OMBEJHJDJKG != null)
			{
				base.StopCoroutine(this.OMBEJHJDJKG);
			}
			this.OMBEJHJDJKG = null;
			this.showingCardGiftAnimation = false;
		}
	}

	// Token: 0x06008F36 RID: 36662 RVA: 0x003F4CBC File Offset: 0x003F2EBC
	public void OnBackendRequestSendMessageException()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		LobbyUserInterface.EHBBFMCILPC.ShowLetterDisappearAnimation("");
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("app42error"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupBackendError, 0f, 28);
		this.KEIKGFKANOL = "";
		LobbyUserInterface.EHBBFMCILPC.GetPopupCardOptions().ResetCustomMessageToFriend();
		this.PGGPPCINLMB = "";
		this.MarkAsModified();
	}

	// Token: 0x06008F37 RID: 36663 RVA: 0x003F4D4E File Offset: 0x003F2F4E
	private void ECGBHIJADOF(PMEPALPCEAF BFDCEGGAMOP)
	{
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(96);
		BackendOperationsManager.EHBBFMCILPC.RequestGetMessagingHistory(BFDCEGGAMOP.EEBMPDNLJGD, "OnBackendGetFriendMessagingHistorySuccess", "OnBackendGetFriendMessagingHistoryException");
	}

	// Token: 0x06008F38 RID: 36664 RVA: 0x003F4D76 File Offset: 0x003F2F76
	public void OnGetMoreCardsClick()
	{
		this.OnSendGiftByUID();
	}

	// Token: 0x06008F39 RID: 36665 RVA: 0x003F4D80 File Offset: 0x003F2F80
	private void JLNCLPODEOF()
	{
		if (this.CAPOPEIGMOB == null || this.CAPOPEIGMOB.EEBMPDNLJGD.Length <= 0)
		{
			this.HHOHNKNPNGB = false;
			return;
		}
		if (!AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.JNNBNNDOGIM.BCPOHPEJLGB(this.CAPOPEIGMOB) && !AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.JNNBNNDOGIM.GOLABDHOFOD(this.CAPOPEIGMOB))
		{
			string text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialgiftcollectinfodone2");
			string str;
			if (this.CAPOPEIGMOB.KNCFKDLOPGA.Length == 0)
			{
				str = "<" + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("profilenametitleshort") + ">";
			}
			else
			{
				str = this.CAPOPEIGMOB.KNCFKDLOPGA;
			}
			text = text.Replace("XXX", "<i>" + str + "</i>");
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtonsAndCloseOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("no"), new UnityAction(this.MBINJIMBJAG), new UnityAction(this.GMCKFHPECBK), new UnityAction(this.GMCKFHPECBK), DFGILFBGPLN.popupQuitConfirm, 0f, 28);
			return;
		}
		this.HHOHNKNPNGB = false;
	}

	// Token: 0x06008F3A RID: 36666 RVA: 0x003F4ED4 File Offset: 0x003F30D4
	private void BOBAKOMGFLO()
	{
		LobbyUserInterface.EHBBFMCILPC.GetPopupCardOptions().ResetCustomMessageToFriend();
		this.PGGPPCINLMB = "";
		this.KEIKGFKANOL = "";
		this.LEJIJOAOEBK = AKLFPGMDKLA.EHBBFMCILPC.CLDBILNPMCN;
		this.EPNOBCLPJJO = HKPBEDBPHNJ.sendGiftCardByProfileId;
		if (LJNMIPMNOKF.EHBBFMCILPC.COCEMBDEKIP() != GCFLILHCOEI.cardsFilterNone)
		{
			LJNMIPMNOKF.EHBBFMCILPC.KNAEAJPDGKB(GCFLILHCOEI.cardsFilterNone, -1, -1);
		}
		this.ShowCardOptionsOrDownload();
	}

	// Token: 0x06008F3B RID: 36667 RVA: 0x003F4F3C File Offset: 0x003F313C
	public void OnPublicProfileLoveEdit()
	{
		CommonUserInterface.EHBBFMCILPC.ShowPopupProfileLoveInput();
	}

	// Token: 0x06008F3C RID: 36668 RVA: 0x00003E52 File Offset: 0x00002052
	private void DDAPKKMDGHN()
	{
	}

	// Token: 0x06008F3D RID: 36669 RVA: 0x003F4F48 File Offset: 0x003F3148
	public void UpdateHeaderStatus(FFIAHOPJJJG OBKCKGHFMDN)
	{
		if (OBKCKGHFMDN == FFIAHOPJJJG.Avatar)
		{
			int num = 1;
			int num2 = this.contentAvatarPage.contentGridAvatarTransform.childCount + this.contentAvatarPage.contentGridAvatarFramesTransform.childCount;
			string text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("mypnotif0");
			text = text.Replace("XXX", num.ToString() ?? "");
			text = text.Replace("YYY", num2.ToString() ?? "");
			this.contentAvatarHeaderStatus.SetText(text, true);
			this.contentAvatarHeaderStatus.text = text;
			base.StartCoroutine(this.ICNHLKBOIGD(this.contentAvatarHeaderStatus.transform));
		}
		if (OBKCKGHFMDN == FFIAHOPJJJG.Char)
		{
			int num3 = 0;
			using (IEnumerator enumerator = this.contentCharactersTransform.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (((Transform)enumerator.Current).GetComponent<ContentGridItem>().isSelected)
					{
						num3++;
					}
				}
			}
			int childCount = this.contentCharactersTransform.childCount;
			string text2 = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("mypnotif0");
			text2 = text2.Replace("XXX", num3.ToString() ?? "");
			text2 = text2.Replace("YYY", childCount.ToString() ?? "");
			this.contentCharactersHeaderStatus.SetText(text2, true);
			this.contentCharactersHeaderStatus.text = text2;
			base.StartCoroutine(this.ICNHLKBOIGD(this.contentCharactersHeaderStatus.transform));
		}
		if (OBKCKGHFMDN == FFIAHOPJJJG.Story)
		{
			int num4 = 0;
			using (IEnumerator enumerator = this.contentStoriesTransform.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (((Transform)enumerator.Current).GetComponent<ContentGridItem>().isSelected)
					{
						num4++;
					}
				}
			}
			int childCount2 = this.contentStoriesTransform.childCount;
			string text3 = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("mypnotif0");
			text3 = text3.Replace("XXX", num4.ToString() ?? "");
			text3 = text3.Replace("YYY", childCount2.ToString() ?? "");
			this.contentStoriesHeaderStatus.SetText(text3, true);
			this.contentStoriesHeaderStatus.text = text3;
			base.StartCoroutine(this.ICNHLKBOIGD(this.contentStoriesHeaderStatus.transform));
		}
		if (OBKCKGHFMDN == FFIAHOPJJJG.Card)
		{
			int count = this.IJPMLEKMGMA.FOHIEAJECHA().Count;
			int num5 = AssetsManager.EHBBFMCILPC.profileDataAsset2.publicProfileCards.Count;
			if (num5 > LJNMIPMNOKF.EHBBFMCILPC.EEFHKIEPFBB())
			{
				num5 = LJNMIPMNOKF.EHBBFMCILPC.EEFHKIEPFBB();
			}
			string text4 = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("mypnotif0");
			text4 = text4.Replace("XXX", count.ToString() ?? "");
			text4 = text4.Replace("YYY", num5.ToString() ?? "");
			this.contentWishedCardsHeaderStatus.SetText(text4, true);
			this.contentWishedCardsHeaderStatus.text = text4;
			this.contentWishedCardsHeaderStatus.ForceMeshUpdate(false, false);
		}
	}

	// Token: 0x06008F3E RID: 36670 RVA: 0x003F5298 File Offset: 0x003F3498
	private void GKFFJLCPLFA()
	{
		if (this.LEJIJOAOEBK != null && this.LEJIJOAOEBK.EEBMPDNLJGD.Length > 0)
		{
			CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(96);
			JSONObject dmimkkciaph = null;
			if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null && AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA)
			{
				dmimkkciaph = AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.BNMFBKNEMIF();
				DPGJIJGOCIC.NFIDPOMCNLP("SocialStatsUserPublicProfile.modified = false, OnFriendsPopupDeleteClick()");
				AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA = false;
			}
			JSONObject defaultOperationsJsonObject = ProfileItem2.GetDefaultOperationsJsonObject(0, true);
			defaultOperationsJsonObject.Add("frdelpid", this.LEJIJOAOEBK.EEBMPDNLJGD);
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.socFriend.ToString(), FFPHBMFGCNN.frDelete.ToString(), "", false, false);
			AKLFPGMDKLA.EHBBFMCILPC.CIPCINKGILF = true;
			BackendOperationsManager.EHBBFMCILPC.RequestGetUserPublicProfile(false, dmimkkciaph, defaultOperationsJsonObject, "OnBackendRequestFriendDeleteSuccess", "OnBackendRequestFriendDeleteException", false);
		}
	}

	// Token: 0x06008F3F RID: 36671 RVA: 0x003F5393 File Offset: 0x003F3593
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

	// Token: 0x06008F40 RID: 36672 RVA: 0x003F2B25 File Offset: 0x003F0D25
	private IEnumerator GACKMMNIOCD()
	{
		while (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.JNNBNNDOGIM.EOCDHHBEKMF() > 0)
		{
			yield return new WaitForSeconds(0.5f);
			while (CommonUserInterface.EHBBFMCILPC.AnyGenericPopupIsActive() || LobbyUserInterface.EHBBFMCILPC.FriendsLetterPopupActive() || CommonUserInterface.EHBBFMCILPC.ConnectionAnimationEnabled())
			{
				yield return new WaitForSeconds(0.2f);
			}
			this.PEDAMIKCMKH = AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.JNNBNNDOGIM.OCEDALILCBL();
			if (this.PEDAMIKCMKH != null && this.PEDAMIKCMKH.BONNGONEJBO != null && this.PEDAMIKCMKH.BONNGONEJBO.Length > 0)
			{
				this.PKOEGOPHOIH = true;
				LobbyUserInterface.EHBBFMCILPC.ShowLetterReceivedAnimation(true, this.PEDAMIKCMKH.BONNGONEJBO, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("continue"), AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC, this.PEDAMIKCMKH, "OnFriendsMessageConsume");
			}
			yield return new WaitForSeconds(0.2f);
			while (this.PKOEGOPHOIH)
			{
				yield return new WaitForSeconds(0.2f);
			}
			yield return new WaitForSeconds(0.2f);
		}
		this.PFFIIOHPJCA = null;
		this.PKOEGOPHOIH = false;
		this.PEDAMIKCMKH = null;
		this.OnNeedToCheckForEmptyFriendsPage();
		yield break;
	}

	// Token: 0x06008F41 RID: 36673 RVA: 0x003F53A2 File Offset: 0x003F35A2
	public void OnContinueToSendSimpleMessageNegative()
	{
		this.KEIKGFKANOL = "";
		LobbyUserInterface.EHBBFMCILPC.GetPopupCardOptions().ResetCustomMessageToFriend();
		this.PGGPPCINLMB = "";
	}

	// Token: 0x06008F42 RID: 36674 RVA: 0x003F53C9 File Offset: 0x003F35C9
	public void OnFriendsMessageHistorySendMessageClick()
	{
		this.FadeOut(this.contentChatPage.gameObject);
		this.GGJEBMBLBNJ();
	}

	// Token: 0x06008F43 RID: 36675 RVA: 0x003F53E2 File Offset: 0x003F35E2
	public void OnCardViewAsCollectedClick()
	{
		this.EPNOBCLPJJO = HKPBEDBPHNJ.viewGiftCardAsCollected;
		LJNMIPMNOKF.EHBBFMCILPC.KNAEAJPDGKB(GCFLILHCOEI.cardsFilterCollected, -1, -1);
		LJNMIPMNOKF.EHBBFMCILPC.AMCFJAMHKHN(this.GKBMOLFNBOH);
		this.ShowCardOptionsOrDownload();
	}

	// Token: 0x06008F44 RID: 36676 RVA: 0x003F5410 File Offset: 0x003F3610
	private void LLONDLALLKB()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		if (AKLFPGMDKLA.EHBBFMCILPC.AONCINPNHDD.Count == 0)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialhalloffamemissing"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
			return;
		}
		this.ShowHallOfFame();
	}

	// Token: 0x06008F45 RID: 36677 RVA: 0x003F5480 File Offset: 0x003F3680
	private void ALGIAIKDEPH()
	{
		for (int i = 0; i < this.lobbyCanvases.Count; i++)
		{
			this.lobbyCanvases[i].enabled = false;
		}
	}

	// Token: 0x06008F46 RID: 36678 RVA: 0x003F54B8 File Offset: 0x003F36B8
	private void BGALHLGAKEI()
	{
		string text = DPGJIJGOCIC.HIPPBJFMIKM(AOBJLALDBAA.EHBBFMCILPC.KNCFLCKKPLK());
		if (text != null && text.Length > 0)
		{
			if (text.Length > 256)
			{
				text = text.Substring(0, 256);
				text += "...";
			}
			this.IJPMLEKMGMA.FPJMDDIILIK = text;
		}
		else
		{
			this.IJPMLEKMGMA.FPJMDDIILIK = "";
		}
		this.UpdateLoveText(true);
	}

	// Token: 0x06008F47 RID: 36679 RVA: 0x003F552C File Offset: 0x003F372C
	private void DIEJPDHOGGN()
	{
		int bopaaipgbca = this.BOPAAIPGBCA;
		AKLFPGMDKLA.EHBBFMCILPC.DAFPKEKPIDH(bopaaipgbca);
		AKLFPGMDKLA.EHBBFMCILPC.CIPCINKGILF = true;
		this.GNBGLOAMALH();
	}

	// Token: 0x06008F48 RID: 36680 RVA: 0x003F555C File Offset: 0x003F375C
	[CompilerGenerated]
	private void BMDBFGJIOAD()
	{
		this.FadeIn(this.contentCharactersPage);
	}

	// Token: 0x06008F49 RID: 36681 RVA: 0x003F556A File Offset: 0x003F376A
	private void DHCDEGCINPO()
	{
		this.IJBIDMGDOPI();
		this.BJNHFGMJHBK();
		this.GNBGLOAMALH();
		base.StartCoroutine(this.GLBNDFFMKFB());
	}

	// Token: 0x06008F4A RID: 36682 RVA: 0x003F558C File Offset: 0x003F378C
	private void PDMPEDKAEIM()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		bool dflfeapnhcp = this.IJPMLEKMGMA.JNNBNNDOGIM.BIAFAHAIPLA(this.LEJIJOAOEBK);
		base.StartCoroutine(this.contentFriendsPage.RefreshContentFriendsOnAcceptFriend(this.MHKKGOCMIJI, this.LEJIJOAOEBK, dflfeapnhcp));
		this.LEJIJOAOEBK = null;
		this.MHKKGOCMIJI = null;
		this.IJPMLEKMGMA.CHCBHLIBGFA = true;
	}

	// Token: 0x06008F4B RID: 36683 RVA: 0x003F55F3 File Offset: 0x003F37F3
	private void NFBDHMFOGPH()
	{
		CommonUserInterface.EHBBFMCILPC.ShowPopupProfileUIDInput(1);
	}

	// Token: 0x06008F4C RID: 36684 RVA: 0x003F5600 File Offset: 0x003F3800
	private void OMDFILALEDO(string HAPADEOFKBP)
	{
		try
		{
			int num = int.Parse(DPGJIJGOCIC.NLGJAJDKIGH(HAPADEOFKBP));
			string dpjinbcgngn = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("randomprofclickchar1").Replace("XXX", "<i>" + GKJPOGNFKNK.DNILNCLIHAP("anthology" + num.ToString(), "anthologiestitle", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()) + "</i>").Replace("YYY", "<i>" + GKJPOGNFKNK.DNILNCLIHAP(HAPADEOFKBP, "profilechars", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()) + "</i>");
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), dpjinbcgngn, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06008F4D RID: 36685 RVA: 0x003F56E4 File Offset: 0x003F38E4
	private void NACKICNAKDI(PMEPALPCEAF FOKFGMIEEDB)
	{
		Vector2 onkonhljkpg = this.CalculateViewportUpDownMargins(this.charactersScrollView);
		List<Transform> list = new List<Transform>();
		foreach (Sprite ibhngiahccm in AssetsManager.EHBBFMCILPC.profileDataAsset.OMCNJKDDHOD())
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentCharactersTransform);
			list.Add(gameObject.transform);
			gameObject.GetComponent<ContentGridItem>().SetContent(FOKFGMIEEDB, ibhngiahccm, FFIAHOPJJJG.Char, onkonhljkpg, list);
			gameObject.GetComponent<ContentGridItem>().gridButton.onClick.AddListener(new UnityAction(this.DKOHGMFBAHP));
		}
		this.UpdateHeaderStatus(FFIAHOPJJJG.Char);
	}

	// Token: 0x06008F4E RID: 36686 RVA: 0x003F57A8 File Offset: 0x003F39A8
	public void DownloadAssetBundleFolder()
	{
		base.StartCoroutine(this.HNKPMLGCKHO());
	}

	// Token: 0x06008F4F RID: 36687 RVA: 0x003F57B8 File Offset: 0x003F39B8
	public void OnAddFriendByProfileId(string JEDGAJJNIPD)
	{
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(96);
		JSONObject dmimkkciaph = null;
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null && AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA)
		{
			dmimkkciaph = AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.BNMFBKNEMIF();
			DPGJIJGOCIC.NFIDPOMCNLP("SocialStatsUserPublicProfile.modified = false, OnAddFriendByProfileId()");
			AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA = false;
		}
		JSONObject defaultOperationsJsonObject = ProfileItem2.GetDefaultOperationsJsonObject(0, true);
		defaultOperationsJsonObject.Add("frpid", JEDGAJJNIPD);
		FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.socFriend.ToString(), FFPHBMFGCNN.frRequest.ToString(), "", false, false);
		FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.socFriend.ToString(), FFPHBMFGCNN.frRequestPID.ToString(), "", false, false);
		AKLFPGMDKLA.EHBBFMCILPC.CIPCINKGILF = true;
		BackendOperationsManager.EHBBFMCILPC.RequestGetUserPublicProfile(false, dmimkkciaph, defaultOperationsJsonObject, "OnBackendAddFriendByUIDSuccess", "OnBackendAddFriendByUIDException", false);
	}

	// Token: 0x06008F50 RID: 36688 RVA: 0x003F58BC File Offset: 0x003F3ABC
	private void ENGNNMHPIIK()
	{
		if (this.IJPMLEKMGMA.GIFPFPOPEJN && this.IJPMLEKMGMA.EEBMPDNLJGD.Length > 0)
		{
			this.OnAddFriendByProfileId(this.IJPMLEKMGMA.EEBMPDNLJGD);
			this.avatarHeader.addFriendButton.gameObject.SetActive(false);
		}
	}

	// Token: 0x06008F51 RID: 36689 RVA: 0x003F5910 File Offset: 0x003F3B10
	public string GetCardUpgradeLocalizedCostData()
	{
		int bopaaipgbca = this.BOPAAIPGBCA;
		OBHDGKFFICI productData = PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager().GetProductData(KDCJJBLGCBH.EHBBFMCILPC.HOBCAABBDLC(GDJPPKAMIFL.EHBBFMCILPC.NDJDOAPFCLH(bopaaipgbca)));
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.EHBBFMCILPC.PDJKPFLHFLO(KDCJJBLGCBH.EHBBFMCILPC.HOBCAABBDLC(GDJPPKAMIFL.EHBBFMCILPC.NDJDOAPFCLH(bopaaipgbca)));
		if (productData == null || ocbiopoeenj == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("ProfileItem2.GetCardUpgradeLocalizedCostData() - productData is null.");
			return "";
		}
		if (ocbiopoeenj.OKGPIEEOKBM())
		{
			return ocbiopoeenj.FNJCEPLEPBH();
		}
		return "USD " + ocbiopoeenj.DMODNDCLGEJ;
	}

	// Token: 0x06008F52 RID: 36690 RVA: 0x003F59A0 File Offset: 0x003F3BA0
	private void ECJMCJIKHFB()
	{
		if (this.LEJIJOAOEBK != null && null != this.MHKKGOCMIJI)
		{
			if (!AKLFPGMDKLA.EHBBFMCILPC.AFKCCPIMDJH() && AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(41))
			{
				if (AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(45))
				{
					AKLFPGMDKLA.EHBBFMCILPC.IJMCBDIKMAB(41);
					AKLFPGMDKLA.EHBBFMCILPC.IJMCBDIKMAB(42);
					AKLFPGMDKLA.EHBBFMCILPC.IJMCBDIKMAB(43);
					AKLFPGMDKLA.EHBBFMCILPC.IJMCBDIKMAB(44);
					AKLFPGMDKLA.EHBBFMCILPC.IJMCBDIKMAB(45);
				}
				else if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(42))
				{
					AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(42);
				}
				else if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(43))
				{
					AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(43);
				}
				else if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(44))
				{
					AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(44);
				}
				else if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(45))
				{
					AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(45);
				}
				this.GGJEBMBLBNJ();
				return;
			}
			if (this.LEJIJOAOEBK.MEFKGPLPEBL())
			{
				this.FadeIn(this.contentChatPage.gameObject);
				return;
			}
			this.ECGBHIJADOF(this.LEJIJOAOEBK);
		}
	}

	// Token: 0x06008F53 RID: 36691 RVA: 0x003F5AD5 File Offset: 0x003F3CD5
	private void IJJKDIAGJKD()
	{
		if (CommonUserInterface.EHBBFMCILPC.GetPopupProfileMessageInput().GetFlag() == 1)
		{
			this.KEIKGFKANOL = "";
			LobbyUserInterface.EHBBFMCILPC.GetPopupCardOptions().UpdateMessage(this.KEIKGFKANOL);
		}
	}

	// Token: 0x06008F54 RID: 36692 RVA: 0x003F5B0C File Offset: 0x003F3D0C
	private void NCOGHCHLKLL()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		this.IJPMLEKMGMA.JNNBNNDOGIM.LDIBFCOOFGD(this.LEJIJOAOEBK);
		this.IJPMLEKMGMA.CHCBHLIBGFA = true;
		this.contentFriendsPage.RefreshContentFriendsOnRejectFriend(this.MHKKGOCMIJI);
		this.LEJIJOAOEBK = null;
		this.MHKKGOCMIJI = null;
		this.OnNeedToCheckForEmptyFriendsPage();
	}

	// Token: 0x06008F55 RID: 36693 RVA: 0x003F5B6A File Offset: 0x003F3D6A
	private void OHJHGOCPMIC()
	{
		LJNMIPMNOKF.EHBBFMCILPC.KNAEAJPDGKB(GCFLILHCOEI.cardsFilterNone, -1, -1);
		LJNMIPMNOKF.EHBBFMCILPC.AMCFJAMHKHN(this.GKBMOLFNBOH);
		this.OnCardClickFromMyProfile(this.GKBMOLFNBOH);
	}

	// Token: 0x06008F56 RID: 36694 RVA: 0x003F5B98 File Offset: 0x003F3D98
	public void ConfirmCutsceneDelete(BNFCLKNDBLO EHCCKGCLNGI, GameObject LHGHFFIPBPN, GameObject IGJELOAEIAK)
	{
		ProfileItem2.FCDIJCKPKCC fcdijckpkcc = new ProfileItem2.FCDIJCKPKCC();
		fcdijckpkcc.<>4__this = this;
		fcdijckpkcc.cutscene = EHCCKGCLNGI;
		fcdijckpkcc.smallItemCutscene = LHGHFFIPBPN;
		fcdijckpkcc.mainCutsceneAnthology = IGJELOAEIAK;
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("areyousure"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("mypmsg0"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("no"), new UnityAction(fcdijckpkcc.PFBCPHFIMCE), new UnityAction(this.BPBKGDNAGHL), DFGILFBGPLN.popupQuitConfirm, 0f, 28);
	}

	// Token: 0x06008F57 RID: 36695 RVA: 0x003F5C30 File Offset: 0x003F3E30
	private void OCGJHAPFJOE()
	{
		string text = DPGJIJGOCIC.HIPPBJFMIKM(AOBJLALDBAA.EHBBFMCILPC.KNCFLCKKPLK());
		if (text != null && text.Length > 0)
		{
			if (text.Length > 256)
			{
				text = text.Substring(0, 256);
				text += "...";
			}
			this.KEIKGFKANOL = text;
		}
		else
		{
			this.KEIKGFKANOL = "";
		}
		this.PostMessageInput();
	}

	// Token: 0x06008F58 RID: 36696 RVA: 0x003F5C9C File Offset: 0x003F3E9C
	public bool AlreadyLiked()
	{
		return this.IJPMLEKMGMA.GIFPFPOPEJN && AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null && (this.IJPMLEKMGMA.LMFCFHMJIFN.Equals(AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.LMFCFHMJIFN) || this.IJPMLEKMGMA.PMOIEJLHFFF(AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.LMFCFHMJIFN));
	}

	// Token: 0x06008F59 RID: 36697 RVA: 0x00003E52 File Offset: 0x00002052
	private void EPNKEMJEOHP()
	{
	}

	// Token: 0x06008F5A RID: 36698 RVA: 0x003F4934 File Offset: 0x003F2B34
	private void DDMCLNDOHCK()
	{
		this.PFEEFOKHKMP = base.transform.localScale;
	}

	// Token: 0x06008F5B RID: 36699 RVA: 0x003F5D04 File Offset: 0x003F3F04
	private void KHCKGMELKLH(PMEPALPCEAF FOKFGMIEEDB)
	{
		this.cardsHiddenTextDropDown.color = new Color(1f, 1f, 1f, 0.25f);
		ProfileItem2.expandCollectedCardsByDefault = true;
		Vector2 onkonhljkpg = this.CalculateViewportUpDownMargins(this.mainScrollView);
		Transform transform = this.cards.transform;
		List<int> list = FOKFGMIEEDB.FCCNNMOIMGC();
		for (int i = this.maxShownItems; i < list.Count; i++)
		{
			ProfileItem2.EPHEOAALAGE epheoaalage = new ProfileItem2.EPHEOAALAGE();
			epheoaalage.<>4__this = this;
			epheoaalage.id = list[i];
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.cardItem, transform);
			gameObject.GetComponent<ContentCardItem>().SetContent(epheoaalage.id, FOKFGMIEEDB.GIFPFPOPEJN, onkonhljkpg, false, false);
			gameObject.GetComponent<ContentCardItem>().onCardPressButton.onClick.AddListener(new UnityAction(epheoaalage.CHPODNKCCJN));
		}
		this.cardsExpandButton.onClick.RemoveAllListeners();
		this.cardsExpandButton.GetComponent<AnimationPress>().enabled = false;
		this.cardsExpandButton.GetComponent<Button>().enabled = false;
		LayoutRebuilder.ForceRebuildLayoutImmediate(transform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentMainTransform.GetComponent<RectTransform>());
	}

	// Token: 0x06008F5C RID: 36700 RVA: 0x003F5E24 File Offset: 0x003F4024
	public void OnApplicationFocusBasicSyncSuccess()
	{
		if (!this.IJPMLEKMGMA.GIFPFPOPEJN)
		{
			this.BJNHFGMJHBK();
			this.OnNeedToUpdatedBadgesSection();
			base.StartCoroutine(this.KPJNBMLJBMP());
		}
	}

	// Token: 0x06008F5D RID: 36701 RVA: 0x003F5E4C File Offset: 0x003F404C
	private void CJKFKPMDEFD()
	{
		int bopaaipgbca = this.BOPAAIPGBCA;
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("areyousure"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialwouldyouliketountradecard"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("no"), new UnityAction(this.DEGAPOBAOGH), new UnityAction(this.NBJPCDIJOCH), DFGILFBGPLN.popupQuitConfirm, 0.15f, 28);
	}

	// Token: 0x06008F5E RID: 36702 RVA: 0x003F5EC8 File Offset: 0x003F40C8
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
		if (this.PGGPPCINLMB.Length > 0)
		{
			bnfclkndblo.PGEKNGNHANN = this.PGGPPCINLMB;
		}
		else
		{
			bnfclkndblo.PGEKNGNHANN = clgfgohbcgj.APMIAIEKIHD;
		}
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

	// Token: 0x06008F5F RID: 36703 RVA: 0x003F6012 File Offset: 0x003F4212
	private IEnumerator GLBNDFFMKFB()
	{
		yield return new WaitForSeconds(0.5f);
		this.OnPopupCardOptionsReopen();
		AKLFPGMDKLA.EHBBFMCILPC.CIPCINKGILF = true;
		yield break;
	}

	// Token: 0x06008F60 RID: 36704 RVA: 0x003F6024 File Offset: 0x003F4224
	private void OnDisable()
	{
		SceneLobbyManager2.doNotUpdatePercent = false;
		ProfileItem2.profileWindowActive = false;
		JDMAEBPEIBE.IJHHMHAEKKE();
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnLiveProfileThemesLoaderStop", 0f);
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnCutsceneViewLeft", new UnityAction(this.LBFDDEFKCJN));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnCutsceneViewAssetBundleFolderInitializeSuccess", new UnityAction(this.KEGGANEJLBG));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnCutsceneViewAssetsDownloadSuccess", new UnityAction(this.FDPBIPDPDEP));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnCutsceneViewAssetsDownloadFailed", new UnityAction(this.HGMFGPNMEDL));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPopupProfileNicknameInputEndEdit", new UnityAction(this.BELKKDHEKKF));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPopupProfileNicknameInputCancel", new UnityAction(this.PCLAMCPKJGE));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPopupProfileLoveInputEndEdit", new UnityAction(this.BGALHLGAKEI));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPopupProfileLoveInputCancel", new UnityAction(this.JIGJBOGFKAF));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPopupProfileCredoInputEndEdit", new UnityAction(this.HOALPJPEOGP));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPopupProfileCredoInputCancel", new UnityAction(this.GJEFAOMBDBL));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendGetPublicProfileProfileItemSuccess", new UnityAction(this.OnBackendGetPublicProfileProfileItemSuccess));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendGetPublicProfileProfileItemException", new UnityAction(this.OnBackendGetPublicProfileProfileItemException));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendGetPublicProfileHallOfFameSuccess", new UnityAction(this.LLONDLALLKB));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendGetPublicProfileHallOfFameException", new UnityAction(this.PNNJJBKJOGJ));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPopupProfileSaveCutsceneInputCancel", new UnityAction(this.NFOGAJKHADD));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPopupProfileSaveCutsceneInputEndEdit", new UnityAction(this.IKFCJJIMBIJ));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPopupProfileUIDInputEndEdit", new UnityAction(this.ONHHONKJGPL));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPopupProfileUIDInputCancel", new UnityAction(this.DLLKOJCKDAD));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendAddFriendByUIDSuccess", new UnityAction(this.IOKBKOJBFEI));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendAddFriendByUIDException", new UnityAction(this.PJLOGGMOIDE));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendRequestCustomProfileSuccess", new UnityAction(this.BGEPCDAIGLF));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendRequestCustomProfileException", new UnityAction(this.NGKDOFIKCKB));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnFriendsPopupManagerAcceptClick", new UnityAction(this.OAAODBKAMCN));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnFriendsPopupManagerRejectClick", new UnityAction(this.BJLDDFCFIOH));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnFriendsPopupSendPremClick", new UnityAction(this.FMNPOBDLDBO));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnFriendsPopupSendSimpleClick", new UnityAction(this.BLFFOEGNAMJ));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnFriendsPopupAddToFavClick", new UnityAction(this.FEEHPCDHKOO));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnFriendsPopupRemovFromFavClick", new UnityAction(this.OPOBHBCMLLK));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnFriendsPopupFriendMatchClick", new UnityAction(this.ADBHDBOAGHG));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnFriendsPopupDeleteClick", new UnityAction(this.GKFFJLCPLFA));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendRequestFriendRejectSuccess", new UnityAction(this.NCOGHCHLKLL));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendRequestFriendRejectException", new UnityAction(this.IMHNNOAIOOI));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendRequestFriendAcceptSuccess", new UnityAction(this.PDMPEDKAEIM));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendRequestFriendAcceptException", new UnityAction(this.NAPLEHDCPNG));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendRequestFriendDeleteSuccess", new UnityAction(this.MBGLDPKFHDM));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendRequestFriendDeleteException", new UnityAction(this.OCPPLJAPKAI));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendRequestShareHardSuccess", new UnityAction(this.CIONFFFABCA));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendRequestShareHardException", new UnityAction(this.LCLBKJFBJBE));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnFriendsCurrencyPopupCollect", new UnityAction(this.NDPEFOGALEC));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendRequestCollectGiftSuccess", new UnityAction(this.HEJLBMMJLHH));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendRequestCollectGiftException", new UnityAction(this.EBDNNEJFEPB));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnAllCollectableCardsDownloadSuccess", new UnityAction(this.KBDAHECFAJM));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnAllCollectableCardsDownloadFailed", new UnityAction(this.OAJDBPJBABO));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnProfileMessageClosed", new UnityAction(this.OnProfileMessageClosed));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnFriendsPopupSendMessageClick", new UnityAction(this.GGJEBMBLBNJ));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("onFriendsPopupOpenMessageHistory", new UnityAction(this.ECJMCJIKHFB));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPopupProfileMessageInputEndEdit", new UnityAction(this.OCGJHAPFJOE));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPopupProfileMessageInputCancel", new UnityAction(this.IJJKDIAGJKD));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendRequestSendMessageException", new UnityAction(this.OnBackendRequestSendMessageException));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendRequestSendMessageSuccess", new UnityAction(this.OnBackendRequestSendMessageSuccess));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnContinueToSendSimpleMessage", new UnityAction(this.OnContinueToSendSimpleMessage));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnFriendsMessageConsume", new UnityAction(this.MGDJJIPNPHH));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendRequestConsumeMessageSuccess", new UnityAction(this.PJPDBBFDCFD));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendRequestConsumeMessageException", new UnityAction(this.ICIHCCKPOJJ));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPopupCardOptionsBackClick", new UnityAction(this.OnPopupCardOptionsBackClick));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPopupCardOptionsNextClick", new UnityAction(this.OnPopupCardOptionsNextClick));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPurchasingViewLeave", new UnityAction(this.OnPurchasingViewLeave));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnApplicationFocusBasicSyncSuccess", new UnityAction(this.OnApplicationFocusBasicSyncSuccess));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnFullscreenCardOptionClick", new UnityAction(this.ViewCardCutscene));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPopupCardOptionsSendGiftClick", new UnityAction(this.GACONMKBMCM));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendRequestSendGiftCardSuccess", new UnityAction(this.OnBackendRequestSendGiftCardSuccess));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendRequestSendGiftCardException", new UnityAction(this.OnBackendRequestSendGiftCardException));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnFriendsGiftPopulCollectPart1", new UnityAction(this.AHDMHAAMDAA));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnFriendsGiftPopulCollectPart2", new UnityAction(this.EGBEPEIEJGL));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPopupCardOptionsEditClick", new UnityAction(this.JHDEJHKGEHF));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("onPopupCardOptionsCloseClick", new UnityAction(this.FDPIFKHEEKP));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnApplicationFocusBasicSyncStart", new UnityAction(this.OnApplicationFocusBasicSyncStart));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPopupCardOptionsUnlockWithSpSuccessContinue", new UnityAction(this.DHCDEGCINPO));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendRequestBreakCardSuccess", new UnityAction(this.OIDGPBKMLIO));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendRequestBreakCardException", new UnityAction(this.HPJHPFEEFJI));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendUpgradeToGiftCardSuccess", new UnityAction(this.EANGIJLLIMO));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendUpgradeToGiftCardException", new UnityAction(this.ECOFOJBOOPF));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendGetFriendMessagingHistorySuccess", new UnityAction(this.ODAIFMLAFIK));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendGetFriendMessagingHistoryException", new UnityAction(this.KONHHCKPCLI));
	}

	// Token: 0x06008F61 RID: 36705 RVA: 0x003F6824 File Offset: 0x003F4A24
	[CompilerGenerated]
	private void DKOHGMFBAHP()
	{
		this.UpdateHeaderStatus(FFIAHOPJJJG.Char);
	}

	// Token: 0x06008F62 RID: 36706 RVA: 0x003F6830 File Offset: 0x003F4A30
	public void OnSendGiftByProfileId()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.GNLNPMPJPEC())
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialprivatenogiftcardsend"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
			return;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.LAKHGAPCKBC)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialprofilesuspcantuse"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
			return;
		}
		if (LJNMIPMNOKF.EHBBFMCILPC.JDDHHIOIAOJ() == 0)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("giftcardsstockempty"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
			return;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.CLDBILNPMCN == null || AKLFPGMDKLA.EHBBFMCILPC.CLDBILNPMCN.EEBMPDNLJGD.Length <= 0)
		{
			this.OnSendGiftByUID();
			return;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.CLDBILNPMCN.EEBMPDNLJGD.Equals(AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.EEBMPDNLJGD))
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialrequestwarnyou2"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
			return;
		}
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(28))
		{
			AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(28);
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("newtutorialgifts"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("continue"), new UnityAction(this.BOBAKOMGFLO), DFGILFBGPLN.popupTools, 0f, 28);
			return;
		}
		this.BOBAKOMGFLO();
	}

	// Token: 0x06008F63 RID: 36707 RVA: 0x003F6A34 File Offset: 0x003F4C34
	public void UpdateLoveText(bool DBNGCAGAGNP)
	{
		this.iRCPlayTitle.SetActive(true);
		this.iRCPlayMsg.SetActive(true);
		if (this.IJPMLEKMGMA.FPJMDDIILIK.Length != 0)
		{
			this.loveText.SetText(this.IJPMLEKMGMA.FPJMDDIILIK, true);
			this.loveText.text = this.IJPMLEKMGMA.FPJMDDIILIK;
			this.loveText.GetComponent<CanvasGroup>().alpha = 1f;
			if (DBNGCAGAGNP)
			{
				DPGJIJGOCIC.NFIDPOMCNLP("SocialStatsUserPublicProfile.modified = true, UpdateLoveText()");
				this.IJPMLEKMGMA.CHCBHLIBGFA = true;
				FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.socActiv.ToString(), FFPHBMFGCNN.socEdit.ToString(), BGHLMGPPCNN.socEditLove.ToString(), false, false);
			}
			return;
		}
		if (this.IJPMLEKMGMA.GIFPFPOPEJN)
		{
			this.iRCPlayTitle.SetActive(false);
			this.iRCPlayMsg.SetActive(false);
			return;
		}
		this.loveText.SetText("<" + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("profileiplayrclong") + ">", true);
		this.loveText.text = "<" + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("profileiplayrclong") + ">";
		this.loveText.GetComponent<CanvasGroup>().alpha = 0.75f;
	}

	// Token: 0x06008F64 RID: 36708 RVA: 0x003F6B95 File Offset: 0x003F4D95
	public void PopulateHeaderContent(PMEPALPCEAF FOKFGMIEEDB)
	{
		this.IJPMLEKMGMA = FOKFGMIEEDB;
		this.avatarHeader.UpdateHeaderContent(FOKFGMIEEDB, this);
	}

	// Token: 0x06008F65 RID: 36709 RVA: 0x003F6BAC File Offset: 0x003F4DAC
	private void BJBKFJEAALB(PMEPALPCEAF FOKFGMIEEDB)
	{
		if (FOKFGMIEEDB.FCCNNMOIMGC().Count == 0)
		{
			this.titleWishedCards.SetActive(false);
			this.noWishedCards.SetActive(false);
			this.wishedCards.SetActive(false);
			return;
		}
		Transform transform = this.wishedCards.transform;
		while (transform.childCount > 0)
		{
			UnityEngine.Object.DestroyImmediate(transform.GetChild(0).gameObject);
		}
		Vector2 onkonhljkpg = this.CalculateViewportUpDownMargins(this.mainScrollView);
		List<int> list = AKLFPGMDKLA.EHBBFMCILPC.NDINEHGFPNN(FOKFGMIEEDB);
		List<int> list2 = FOKFGMIEEDB.FOHIEAJECHA();
		if (list2.Count != 0)
		{
			this.titleWishedCards.SetActive(true);
			this.noWishedCards.SetActive(false);
			this.wishedCards.SetActive(true);
			using (List<int>.Enumerator enumerator = list2.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					ProfileItem2.NEKICFCBOKH nekicfcbokh = new ProfileItem2.NEKICFCBOKH();
					nekicfcbokh.<>4__this = this;
					nekicfcbokh.id = enumerator.Current;
					ContentCardItem component = UnityEngine.Object.Instantiate<GameObject>(this.cardItem, transform).GetComponent<ContentCardItem>();
					component.SetContent(nekicfcbokh.id, FOKFGMIEEDB.GIFPFPOPEJN, onkonhljkpg, false, false);
					component.onCardPressButton.onClick.AddListener(new UnityAction(nekicfcbokh.NAEIHOEPENC));
					if (FOKFGMIEEDB.GIFPFPOPEJN && !AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.EEBMPDNLJGD.Equals(FOKFGMIEEDB.EEBMPDNLJGD) && list.Contains(nekicfcbokh.id))
					{
						component.tradingFrameAnimation.gameObject.SetActive(true);
						component.tradingFrameAnimation.framesSD = AssetsManager.EHBBFMCILPC.profileDataAsset3.tradeMatchSprites.ToArray();
					}
				}
				goto IL_1EF;
			}
		}
		if (FOKFGMIEEDB.GIFPFPOPEJN)
		{
			this.titleWishedCards.SetActive(false);
			this.wishedCards.SetActive(false);
			this.noWishedCards.SetActive(false);
		}
		else
		{
			this.titleWishedCards.SetActive(true);
			this.wishedCards.SetActive(false);
			this.noWishedCards.SetActive(true);
		}
		IL_1EF:
		LayoutRebuilder.ForceRebuildLayoutImmediate(transform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentMainTransform.GetComponent<RectTransform>());
	}

	// Token: 0x06008F66 RID: 36710 RVA: 0x003F6DD4 File Offset: 0x003F4FD4
	public void ShowHallOfFame()
	{
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(32) && AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.JECGGDNKBID())
		{
			AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(32);
			AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(34);
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("halloffamecongrats"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("continue"), new UnityAction(this.MGJODPCIHAE), new UnityAction(this.MGJODPCIHAE), DFGILFBGPLN.popupTools, 0.75f, 28);
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.socFriend.ToString(), FFPHBMFGCNN.frReachHof.ToString(), "", false, false);
		}
		else if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(34))
		{
			AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(34);
			this.MGJODPCIHAE();
		}
		FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.socFriend.ToString(), FFPHBMFGCNN.frAccHoff.ToString(), "", false, false);
		this.FadeIn(this.contentHallOfFamePage.gameObject);
	}

	// Token: 0x06008F67 RID: 36711 RVA: 0x003F6F10 File Offset: 0x003F5110
	public void OnHallOfFamePageBackButtonClick()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.CIPCINKGILF || AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC == null)
		{
			this.OnProfileClick();
		}
		else
		{
			this.UpdateContent(AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC, AMMHDNONFHM.MyProfile);
			this.FadeOut(this.contentHallOfFamePage.gameObject);
		}
		this.contentHallOfFamePage.verticalNormalizedPositionHallOfFameScroll = 1f;
	}

	// Token: 0x06008F68 RID: 36712 RVA: 0x003F6F70 File Offset: 0x003F5170
	private void ALAGMFINDJI()
	{
		int bopaaipgbca = this.BOPAAIPGBCA;
		AKLFPGMDKLA.EHBBFMCILPC.IENJEMJFOFI(bopaaipgbca);
		AKLFPGMDKLA.EHBBFMCILPC.CIPCINKGILF = false;
		this.JNCCHOJOBJB();
	}

	// Token: 0x06008F69 RID: 36713 RVA: 0x00003E52 File Offset: 0x00002052
	private void OAJLLPMMOKI()
	{
	}

	// Token: 0x06008F6A RID: 36714 RVA: 0x003F6FA0 File Offset: 0x003F51A0
	private void FLHACKGHHLK()
	{
		LobbyUserInterface.EHBBFMCILPC.GetPopupCardOptions().ResetCustomMessageToFriend();
		this.PGGPPCINLMB = "";
		this.KEIKGFKANOL = "";
		this.LEJIJOAOEBK = null;
		this.EPNOBCLPJJO = HKPBEDBPHNJ.sendGiftCardByUserId;
		if (LJNMIPMNOKF.EHBBFMCILPC.COCEMBDEKIP() != GCFLILHCOEI.cardsFilterNone)
		{
			LJNMIPMNOKF.EHBBFMCILPC.KNAEAJPDGKB(GCFLILHCOEI.cardsFilterNone, -1, -1);
		}
		this.ShowCardOptionsOrDownload();
	}

	// Token: 0x06008F6B RID: 36715 RVA: 0x003F7000 File Offset: 0x003F5200
	private void ICIHCCKPOJJ()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("app42error"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupBackendError, 0f, 28);
		this.PEDAMIKCMKH = null;
		this.PKOEGOPHOIH = false;
		if (this.PFFIIOHPJCA != null)
		{
			base.StopCoroutine(this.PFFIIOHPJCA);
		}
		this.PFFIIOHPJCA = null;
		this.MarkAsModified();
	}

	// Token: 0x06008F6C RID: 36716 RVA: 0x00003E52 File Offset: 0x00002052
	public void OnGenericDoNothing()
	{
	}

	// Token: 0x06008F6D RID: 36717 RVA: 0x003F7087 File Offset: 0x003F5287
	private void ECJFBOCMCIL(string HAPADEOFKBP)
	{
		this.OMDFILALEDO(HAPADEOFKBP);
	}

	// Token: 0x06008F6E RID: 36718 RVA: 0x003F7090 File Offset: 0x003F5290
	public void CloseFocus()
	{
		this.PreCloseFocus();
		this.CCONAGOEAAN(false);
	}

	// Token: 0x06008F6F RID: 36719 RVA: 0x003F70A0 File Offset: 0x003F52A0
	public Vector2 CalculateViewportUpDownMargins(Transform EENFFCGAJOF)
	{
		RectTransform viewport = EENFFCGAJOF.GetComponent<ScrollRect>().viewport;
		Vector3[] array = new Vector3[4];
		viewport.GetWorldCorners(array);
		Vector3 vector = array[0];
		return new Vector2(array[1].y, vector.y);
	}

	// Token: 0x06008F70 RID: 36720 RVA: 0x003F70E4 File Offset: 0x003F52E4
	private void AMPEDMLBPIM(GameObject PHLJNFHEEIB)
	{
		if (PHLJNFHEEIB.name == this.contentCharactersPage.name)
		{
			this.IJPMLEKMGMA.HFOONKBBIKD();
			foreach (object obj in this.contentCharactersTransform)
			{
				((Transform)obj).GetComponent<ContentGridItem>().ResetItem();
			}
			this.UpdateHeaderStatus(FFIAHOPJJJG.Char);
		}
		if (PHLJNFHEEIB.name == this.contentStoriesPage.name)
		{
			this.IJPMLEKMGMA.GEJDNEOIHAE();
			foreach (object obj2 in this.contentStoriesTransform)
			{
				((Transform)obj2).GetComponent<ContentGridItem>().ResetItem();
			}
			this.UpdateHeaderStatus(FFIAHOPJJJG.Story);
		}
		if (PHLJNFHEEIB.name == this.contentCutscenesPage.name)
		{
			this.IJPMLEKMGMA.GPCDLDEHOMP();
			foreach (object obj3 in this.contentCutscenesTransform)
			{
				ContentCusceneSmallItem[] componentsInChildren = ((Transform)obj3).GetComponentsInChildren<ContentCusceneSmallItem>();
				for (int i = 0; i < componentsInChildren.Length; i++)
				{
					componentsInChildren[i].ResetItem();
				}
			}
		}
		if (PHLJNFHEEIB.name == this.contentWishedCardsPage.name)
		{
			AKLFPGMDKLA.EHBBFMCILPC.NAKGMGBDKEE();
			foreach (object obj4 in this.contentWishedCardsPageTransform)
			{
				((Transform)obj4).GetComponent<ContentCardItem>().ResetItem();
			}
			this.UpdateHeaderStatus(FFIAHOPJJJG.Card);
		}
	}

	// Token: 0x06008F71 RID: 36721 RVA: 0x003F72D0 File Offset: 0x003F54D0
	private void DMELLKDBPHP()
	{
		this.OnFriendRequestClick();
	}

	// Token: 0x06008F72 RID: 36722 RVA: 0x003F72D8 File Offset: 0x003F54D8
	private void CNEOGNDIJDD()
	{
		CommonUserInterface.IKNOFBFMPGA().MCJIGJMFBMI();
		if (this.PNPEHMLHDPO != null && this.PNPEHMLHDPO.IFEEIAPMIML != null && this.PNPEHMLHDPO.IFEEIAPMIML.CCMDLENEDGJ >= 1)
		{
			this.CAPOPEIGMOB = this.PNPEHMLHDPO;
			this.IJPMLEKMGMA.JNNBNNDOGIM.KOCCNIAPFFH(this.PNPEHMLHDPO);
			CommonUserInterface.IKNOFBFMPGA().CEGLPJNLBHL(CCOJBMMKNAP.KMNBCEMEBBD().HIPJILDCHJC(", "), CCOJBMMKNAP.CPCOODCFDDP().GLEFEKBDHNK("focuswardrobeavatar"), CCOJBMMKNAP.LMCCLMFGEBD().OHLNGCKIACD(","), new UnityAction(this.JLNCLPODEOF), new UnityAction(this.JLNCLPODEOF), DFGILFBGPLN.screenTransitionFromLobby, 1693f, -45);
		}
		else
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.INKJIBDDMLL().OGKGHLHHAAI(", dropped"), CCOJBMMKNAP.BIAEAOMHBMM().HPOAGPJFHPM("lsenvreg"), CCOJBMMKNAP.BOFMCPPFAMO().IPEIONBNIPH("<i>"), (DFGILFBGPLN)(-119), 1117f, -54);
			this.HHOHNKNPNGB = false;
		}
		this.LEJIJOAOEBK = null;
		this.MHKKGOCMIJI = null;
		this.PNPEHMLHDPO = null;
		this.FKINHICHJPO();
		this.OnNeedToUpdateIncomingGiftsSection();
		this.OnNeedToUpdateCollectedCardsSection();
		this.OnNeedToUpdateCollectedGiftsSection();
		LobbyUserInterface.OEPENBHJAHO().EMBHDJBPOKL().ResetCustomMessageToFriend();
		this.PGGPPCINLMB = "abpdl";
		this.KEIKGFKANOL = "importanttitle";
	}

	// Token: 0x06008F73 RID: 36723 RVA: 0x003F7434 File Offset: 0x003F5634
	private void MBGLDPKFHDM()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		this.IJPMLEKMGMA.JNNBNNDOGIM.IMPMPCGHAJH(this.LEJIJOAOEBK);
		this.IJPMLEKMGMA.CHCBHLIBGFA = true;
		this.contentFriendsPage.RefreshContentFriendsOnDeleteFriend(this.MHKKGOCMIJI);
		this.LEJIJOAOEBK = null;
		this.MHKKGOCMIJI = null;
		this.OnNeedToCheckForEmptyFriendsPage();
	}

	// Token: 0x06008F74 RID: 36724 RVA: 0x003F7494 File Offset: 0x003F5694
	private void NFADOBNPMGA()
	{
		for (int i = 1; i < this.lobbyCanvases.Count; i += 0)
		{
			this.lobbyCanvases[i].enabled = true;
		}
	}

	// Token: 0x06008F75 RID: 36725 RVA: 0x003F74CC File Offset: 0x003F56CC
	private void BELKKDHEKKF()
	{
		string text = DPGJIJGOCIC.HIPPBJFMIKM(AOBJLALDBAA.EHBBFMCILPC.KNCFLCKKPLK());
		if (text != null && text.Length > 0)
		{
			if (text.Length > 24)
			{
				text = text.Substring(0, 24);
				text += "...";
			}
			this.IJPMLEKMGMA.KNCFKDLOPGA = text;
		}
		else
		{
			this.IJPMLEKMGMA.KNCFKDLOPGA = "";
		}
		this.avatarHeader.UpdateNickNameText(true);
	}

	// Token: 0x06008F76 RID: 36726 RVA: 0x003F7540 File Offset: 0x003F5740
	public void UpdateCredoText(bool DBNGCAGAGNP)
	{
		this.credoTitle.SetActive(true);
		this.credoMsg.SetActive(true);
		if (this.IJPMLEKMGMA.PEONEPNPGEC.Length != 0)
		{
			this.credoText.SetText(this.IJPMLEKMGMA.PEONEPNPGEC, true);
			this.credoText.text = this.IJPMLEKMGMA.PEONEPNPGEC;
			this.credoText.GetComponent<CanvasGroup>().alpha = 1f;
			if (DBNGCAGAGNP)
			{
				DPGJIJGOCIC.NFIDPOMCNLP("SocialStatsUserPublicProfile.modified = true, UpdateCredoText()");
				this.IJPMLEKMGMA.CHCBHLIBGFA = true;
				FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.socActiv.ToString(), FFPHBMFGCNN.socEdit.ToString(), BGHLMGPPCNN.socEditCredo.ToString(), false, false);
			}
			return;
		}
		if (this.IJPMLEKMGMA.GIFPFPOPEJN)
		{
			this.credoTitle.SetActive(false);
			this.credoMsg.SetActive(false);
			return;
		}
		this.credoText.SetText("<" + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("profilemycredolong") + ">", true);
		this.credoText.text = "<" + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("profilemycredolong") + ">";
		this.credoText.GetComponent<CanvasGroup>().alpha = 0.75f;
	}

	// Token: 0x06008F77 RID: 36727 RVA: 0x003F76A1 File Offset: 0x003F58A1
	[CompilerGenerated]
	private void IGGGPBKMMGH()
	{
		this.PDDFDJNGKIO();
	}

	// Token: 0x06008F78 RID: 36728 RVA: 0x003F76A9 File Offset: 0x003F58A9
	private void KEGGANEJLBG()
	{
		base.StartCoroutine(this.LDEGJJJAOOM());
	}

	// Token: 0x06008F79 RID: 36729 RVA: 0x003F76B8 File Offset: 0x003F58B8
	private void KMKNCDNLLHK()
	{
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(39))
		{
			AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(39);
			float num = 60f;
			float endValue = -this.titleTradingCards.GetComponent<RectTransform>().localPosition.y - num;
			this.contentMainTransform.GetComponent<RectTransform>().DOLocalMoveY(endValue, 1f, false);
		}
	}

	// Token: 0x06008F7A RID: 36730 RVA: 0x003F7718 File Offset: 0x003F5918
	public void CDBKJPCOAKO()
	{
		string finoaaokiic = "socialbadge";
		int num = KDCJJBLGCBH.EHBBFMCILPC.OFKOCAGJLMP();
		bool flag;
		if (num > 1)
		{
			flag = LJNMIPMNOKF.KMNBCEMEBBD().DFCJFLEGKOD();
		}
		else
		{
			flag = GKJPOGNFKNK.CEHOHNOKLIK(LJNMIPMNOKF.EHBBFMCILPC.HLMALDJNLGP());
		}
		if (!flag)
		{
			if (this.FGDEGMOLIDB)
			{
				this.FGDEGMOLIDB = true;
				CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
				CommonUserInterface.IKNOFBFMPGA().HideConnectingAnimation();
				this.CMDIKMNEGEN();
				AOBJLALDBAA.BIAEAOMHBMM().EFBNBFIDEOK("\n\n", 1678f);
			}
			if (this.EPNOBCLPJJO == HKPBEDBPHNJ.purchaseCardLobby)
			{
				if (this.showingCardGiftAnimation)
				{
					base.StartCoroutine(this.FOKBBGOFHLG());
					return;
				}
				if (this.PNPEHMLHDPO != null && this.PNPEHMLHDPO.IFEEIAPMIML != null && this.PNPEHMLHDPO.IFEEIAPMIML.CCMDLENEDGJ >= 0)
				{
					LJNMIPMNOKF.KMNBCEMEBBD().IFBCIHLAFBH(this.PNPEHMLHDPO.IFEEIAPMIML.CCMDLENEDGJ);
					if (this.PNPEHMLHDPO.IFEEIAPMIML.BONNGONEJBO != null && this.PNPEHMLHDPO.IFEEIAPMIML.BONNGONEJBO.Length > 1)
					{
						finoaaokiic = (this.PGGPPCINLMB = this.PNPEHMLHDPO.IFEEIAPMIML.BONNGONEJBO);
					}
				}
				AOBJLALDBAA.KKPFOJMAONG().EFBNBFIDEOK("?uid=", 1807f);
			}
			LobbyUserInterface.FILDBDMENPG().LAFMGAJMOJB(LJNMIPMNOKF.EHBBFMCILPC.FNENBDGBOFF(), this.LEJIJOAOEBK, this.EPNOBCLPJJO, finoaaokiic, null);
			return;
		}
		if (num > 0)
		{
			base.StartCoroutine(this.HCAHEOPANBC(num));
			return;
		}
		base.StartCoroutine(this.NBKMFHDIBPK());
	}

	// Token: 0x06008F7B RID: 36731 RVA: 0x003F789C File Offset: 0x003F5A9C
	public string GetCollectedCardsNoteText()
	{
		if (this.IJPMLEKMGMA != null)
		{
			string text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("collectedcardsstats");
			int count = this.IJPMLEKMGMA.FCCNNMOIMGC().Count;
			string text2 = text.Replace("XXX", count.ToString() ?? "");
			int num = GDJPPKAMIFL.EHBBFMCILPC.KCPFGMJNMLE();
			return text2.Replace("YYY", num.ToString() ?? "") + " (" + ((int)Math.Round((double)count / (double)num * 100.0)).ToString() + "%)";
		}
		return "n/a";
	}

	// Token: 0x06008F7C RID: 36732 RVA: 0x003F7948 File Offset: 0x003F5B48
	private void JBAICDJCAIB(GameObject AMLHEIOIAKD)
	{
		if (AMLHEIOIAKD.name == this.contentAvatarPage.gameObject.name)
		{
			while (this.contentAvatarPage.contentGridAvatarTransform.childCount > 0)
			{
				UnityEngine.Object.DestroyImmediate(this.contentAvatarPage.contentGridAvatarTransform.GetChild(0).gameObject);
			}
			while (this.contentAvatarPage.contentGridAvatarFramesTransform.childCount > 1)
			{
				UnityEngine.Object.DestroyImmediate(this.contentAvatarPage.contentGridAvatarFramesTransform.GetChild(0).gameObject);
			}
		}
		while (this.contentCharactersTransform.childCount > 0)
		{
			UnityEngine.Object.DestroyImmediate(this.contentCharactersTransform.GetChild(0).gameObject);
		}
		while (this.contentStoriesTransform.childCount > 0)
		{
			UnityEngine.Object.DestroyImmediate(this.contentStoriesTransform.GetChild(0).gameObject);
		}
		while (this.contentCutscenesTransform.childCount > 0)
		{
			UnityEngine.Object.DestroyImmediate(this.contentCutscenesTransform.GetChild(0).gameObject);
		}
		while (this.contentAnthologyAchievementsTransform.childCount > 0)
		{
			UnityEngine.Object.DestroyImmediate(this.contentAnthologyAchievementsTransform.GetChild(0).gameObject);
		}
		while (this.contentWishedCardsPageTransform.childCount > 0)
		{
			UnityEngine.Object.DestroyImmediate(this.contentWishedCardsPageTransform.GetChild(0).gameObject);
		}
		while (this.contentChatPage.contentChatTransform.childCount > 0)
		{
			UnityEngine.Object.DestroyImmediate(this.contentChatPage.contentChatTransform.GetChild(0).gameObject);
		}
		if (AMLHEIOIAKD.name == this.contentHallOfFamePage.gameObject.name)
		{
			if (this.activePageType == AMMHDNONFHM.HallOfFameProfile)
			{
				return;
			}
			while (this.contentHallOfFamePage.contentHallOfFameItemsTransform.childCount > 0)
			{
				UnityEngine.Object.DestroyImmediate(this.contentHallOfFamePage.contentHallOfFameItemsTransform.GetChild(0).gameObject);
			}
		}
	}

	// Token: 0x06008F7D RID: 36733 RVA: 0x003F7B18 File Offset: 0x003F5D18
	public void ShowZeroCutscenesMessage()
	{
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("mypzerocutscenes"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
	}

	// Token: 0x06008F7E RID: 36734 RVA: 0x003F7B68 File Offset: 0x003F5D68
	private void KEFGAJBOJPF(PMEPALPCEAF FOKFGMIEEDB)
	{
		this.avatarHeader.SetAvatarIcon(FOKFGMIEEDB);
		this.MEMHMNODKIG(FOKFGMIEEDB);
		this.FOELBHPJKFK(FOKFGMIEEDB);
		this.NJJCAKEGPJG(FOKFGMIEEDB);
		this.BJBKFJEAALB(FOKFGMIEEDB);
		AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.JNNBNNDOGIM.ACCOJOHJPGH(FOKFGMIEEDB);
		this.GHGKHLGNDKI();
	}

	// Token: 0x06008F7F RID: 36735 RVA: 0x003F7BB8 File Offset: 0x003F5DB8
	public void OnContinueToSendSimpleMessage()
	{
		if (this.LEJIJOAOEBK != null && this.LEJIJOAOEBK.EEBMPDNLJGD.Length > 0)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialmessagetitleconfirm"), "<i>" + this.KEIKGFKANOL + "</i>", CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialmessagebuttonconfirm"), new UnityAction(this.OnContinueToSendSimpleMessagePositive), new UnityAction(this.OnContinueToSendSimpleMessageNegative), DFGILFBGPLN.popupQuitConfirm, 0f, 28);
		}
	}

	// Token: 0x06008F80 RID: 36736 RVA: 0x003F7C3F File Offset: 0x003F5E3F
	private void Update()
	{
		JDMAEBPEIBE.LHPOKHEHGFA();
	}

	// Token: 0x06008F81 RID: 36737 RVA: 0x003F7C48 File Offset: 0x003F5E48
	private void CIONFFFABCA()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		int num = 1;
		AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA = true;
		if (AKLFPGMDKLA.EHBBFMCILPC.ELAGGOHBOOA["frsendhres"] != null)
		{
			num = AKLFPGMDKLA.EHBBFMCILPC.ELAGGOHBOOA["frsendhres"].AsInt;
		}
		int num2 = -1;
		if (AKLFPGMDKLA.EHBBFMCILPC.ELAGGOHBOOA["frsendhres2"] != null)
		{
			num2 = AKLFPGMDKLA.EHBBFMCILPC.ELAGGOHBOOA["frsendhres2"].AsInt;
		}
		if (num2 >= 0)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialrequestsharegr" + num2.ToString()), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
		}
		else if (num < 10)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("congratstitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialrequestsharegr" + num.ToString()), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
			IOGOGMEJCIK.EHBBFMCILPC.JMGGPPMDBGJ(2);
			IOGOGMEJCIK.EHBBFMCILPC.KOHINGHLPDM();
			IOGOGMEJCIK.EHBBFMCILPC.EGFKMLPLMFA();
		}
		else
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialrequestsharegr" + num.ToString()), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
		}
		this.LEJIJOAOEBK = null;
		this.MHKKGOCMIJI = null;
		this.OnNeedToUpdatedBadgesSection();
	}

	// Token: 0x06008F82 RID: 36738 RVA: 0x003F7E0C File Offset: 0x003F600C
	private void OJDENJMNNDM(PMEPALPCEAF FOKFGMIEEDB)
	{
		if (GKJPOGNFKNK.PMGJPHEPHPG(AssetsManager.EHBBFMCILPC.profileDataAsset.JHFNENEICGB()))
		{
			this.viewAnthologyAchievementsButton.SetActive(true);
		}
		else
		{
			this.viewAnthologyAchievementsButton.SetActive(false);
		}
		this.anthologyAchievementsHiddenDropDown.color = new Color(1f, 1f, 1f, 1f);
		if (FOKFGMIEEDB.PEBKLGDBGHC().Count != 0)
		{
			Transform transform = this.anthologyAchievements.transform;
			while (transform.transform.childCount > 0)
			{
				UnityEngine.Object.DestroyImmediate(transform.transform.GetChild(0).gameObject);
			}
			this.anthologyAchievementsTitle.SetActive(true);
			this.anthologyAchievements.SetActive(true);
			this.noAnthologyAchievements.SetActive(false);
			this.anthologyAchievementsHidden.SetActive(false);
			int num = 0;
			List<string> list = FOKFGMIEEDB.PEBKLGDBGHC();
			for (int i = list.Count - 1; i >= 0; i--)
			{
				ProfileItem2.LHJBOGNCIDL lhjbogncidl = new ProfileItem2.LHJBOGNCIDL();
				lhjbogncidl.<>4__this = this;
				if (num == this.maxShownItems)
				{
					this.anthologyAchievementsHidden.SetActive(true);
					string text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("mypachievtitle");
					int count = this.IJPMLEKMGMA.PEBKLGDBGHC().Count;
					text = text.Replace("XXX", count.ToString() ?? "");
					int count2 = GKJPOGNFKNK.EALDMCLPMPH(AssetsManager.EHBBFMCILPC.profileDataAsset.JHFNENEICGB(), true).Count;
					text = text.Replace("YYY", count2.ToString() ?? "");
					text = text + " (" + ((int)Math.Round((double)count / (double)count2 * 100.0)).ToString() + "%)";
					this.anthologyAchievementsHiddenText.SetText(text, true);
					this.anthologyAchievementsHiddenText.text = text;
					this.anthologyAchievementsExpandButton.GetComponent<AnimationPress>().enabled = true;
					this.anthologyAchievementsExpandButton.GetComponent<Button>().enabled = true;
					this.anthologyAchievementsExpandButton.onClick.RemoveListener(new UnityAction(this.PBAHOEGHHHN));
					this.anthologyAchievementsExpandButton.onClick.AddListener(new UnityAction(this.PBAHOEGHHHN));
					break;
				}
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.anthologyAchievementItem, transform);
				lhjbogncidl.achievementId = list[i];
				gameObject.GetComponent<ContentAnthologyAchievementsItem>().SetContent(lhjbogncidl.achievementId);
				gameObject.GetComponent<Button>().onClick.AddListener(new UnityAction(lhjbogncidl.HGHOIEKPKBM));
				num++;
			}
			base.StartCoroutine(this.LHNMEHHAPAO(transform.GetComponent<RectTransform>()));
			base.StartCoroutine(this.LHNMEHHAPAO(this.contentMainTransform.GetComponent<RectTransform>()));
			return;
		}
		if (FOKFGMIEEDB.GIFPFPOPEJN)
		{
			this.anthologyAchievementsTitle.SetActive(false);
			this.anthologyAchievements.SetActive(false);
			this.noAnthologyAchievements.SetActive(false);
		}
		else
		{
			this.anthologyAchievementsTitle.SetActive(true);
			this.anthologyAchievements.SetActive(false);
			this.noAnthologyAchievements.SetActive(true);
		}
		this.anthologyAchievementsHidden.SetActive(false);
	}

	// Token: 0x06008F83 RID: 36739 RVA: 0x003F8124 File Offset: 0x003F6324
	private void HAMCABNPPHP(PMEPALPCEAF FOKFGMIEEDB)
	{
		ProfileItem2.OAHCJEPIPEJ oahcjepipej = new ProfileItem2.OAHCJEPIPEJ();
		oahcjepipej.<>4__this = this;
		oahcjepipej._profile = FOKFGMIEEDB;
		List<Sprite> list = oahcjepipej._profile.JMJOEHHFJGC(oahcjepipej._profile.GIFPFPOPEJN);
		if (list.Count != 0)
		{
			this.badgesHidden.SetActive(true);
			string collectedBadgesNoteText = this.GetCollectedBadgesNoteText(list);
			this.badgesHiddenText.SetText(collectedBadgesNoteText, true);
			this.badgesHiddenText.text = collectedBadgesNoteText;
			foreach (object obj in this.badges.transform)
			{
				Transform transform = (Transform)obj;
				transform.GetComponent<Button>().onClick.RemoveAllListeners();
				transform.gameObject.SetActive(false);
			}
			this.titleBadges.SetActive(true);
			this.badges.SetActive(true);
			for (int i = 0; i < list.Count; i++)
			{
				if (i < this.badges.transform.childCount)
				{
					ProfileItem2.HFNLOONJECP hfnloonjecp = new ProfileItem2.HFNLOONJECP();
					hfnloonjecp.CS$<>8__locals1 = oahcjepipej;
					Transform child = this.badges.transform.GetChild(i);
					child.gameObject.SetActive(true);
					hfnloonjecp.sprite = list[i];
					child.GetComponent<ContentBadgeItem>().imageThumb.sprite = hfnloonjecp.sprite;
					child.GetComponent<Button>().onClick.AddListener(new UnityAction(hfnloonjecp.NGDJFKGJDJM));
				}
				if (!ProfileItem2.expandBadgesByDefault && i >= this.maxShownBadgesItems - 1)
				{
					break;
				}
			}
		}
		else
		{
			this.badgesHidden.SetActive(false);
			this.titleBadges.SetActive(false);
			this.badges.SetActive(false);
		}
		this.badgesExpandButton.onClick.RemoveAllListeners();
		if (!ProfileItem2.expandBadgesByDefault)
		{
			this.badgesExpandButton.GetComponent<AnimationPress>().enabled = true;
			this.badgesExpandButton.GetComponent<Button>().enabled = true;
			this.badgesExpandButton.onClick.AddListener(new UnityAction(oahcjepipej.DBFHIONAMEI));
			this.badgesHiddenTextDropDown.color = new Color(1f, 1f, 1f, 1f);
			return;
		}
		this.badgesExpandButton.GetComponent<AnimationPress>().enabled = false;
		this.badgesExpandButton.GetComponent<Button>().enabled = false;
		this.badgesHiddenTextDropDown.color = new Color(1f, 1f, 1f, 0.25f);
	}

	// Token: 0x06008F84 RID: 36740 RVA: 0x003F83AC File Offset: 0x003F65AC
	private void OnEnable()
	{
		ProfileItem2.profileWindowActive = true;
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnLiveProfileThemesLoaderStart", 0f);
		this.mainScrollView.GetComponent<ScrollRect>().scrollSensitivity = 100f;
		this.charactersScrollView.GetComponent<ScrollRect>().scrollSensitivity = 100f;
		this.storiesScrollView.GetComponent<ScrollRect>().scrollSensitivity = 100f;
		this.cutscenesScrollView.GetComponent<ScrollRect>().scrollSensitivity = 100f;
		this.contentHallOfFamePage.hallOfFameScrollView.GetComponent<ScrollRect>().scrollSensitivity = 100f;
		this.wishedCardScrollView.GetComponent<ScrollRect>().scrollSensitivity = 100f;
		this.contentAvatarPage.avatarScrollView.GetComponent<ScrollRect>().scrollSensitivity = 100f;
		this.contentFriendsPage.friendsScrollView.GetComponent<ScrollRect>().scrollSensitivity = 100f;
		this.contentChatPage.chatScrollView.GetComponent<ScrollRect>().scrollSensitivity = 100f;
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnCutsceneViewLeft", new UnityAction(this.LBFDDEFKCJN));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnCutsceneViewAssetBundleFolderInitializeSuccess", new UnityAction(this.KEGGANEJLBG));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnCutsceneViewAssetsDownloadSuccess", new UnityAction(this.FDPBIPDPDEP));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnCutsceneViewAssetsDownloadFailed", new UnityAction(this.HGMFGPNMEDL));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPopupProfileNicknameInputEndEdit", new UnityAction(this.BELKKDHEKKF));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPopupProfileNicknameInputCancel", new UnityAction(this.PCLAMCPKJGE));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPopupProfileLoveInputEndEdit", new UnityAction(this.BGALHLGAKEI));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPopupProfileLoveInputCancel", new UnityAction(this.JIGJBOGFKAF));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPopupProfileCredoInputEndEdit", new UnityAction(this.HOALPJPEOGP));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPopupProfileCredoInputCancel", new UnityAction(this.GJEFAOMBDBL));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendGetPublicProfileProfileItemSuccess", new UnityAction(this.OnBackendGetPublicProfileProfileItemSuccess));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendGetPublicProfileProfileItemException", new UnityAction(this.OnBackendGetPublicProfileProfileItemException));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendGetPublicProfileHallOfFameSuccess", new UnityAction(this.LLONDLALLKB));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendGetPublicProfileHallOfFameException", new UnityAction(this.PNNJJBKJOGJ));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPopupProfileSaveCutsceneInputCancel", new UnityAction(this.NFOGAJKHADD));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPopupProfileSaveCutsceneInputEndEdit", new UnityAction(this.IKFCJJIMBIJ));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPopupProfileUIDInputEndEdit", new UnityAction(this.ONHHONKJGPL));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPopupProfileUIDInputCancel", new UnityAction(this.DLLKOJCKDAD));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendAddFriendByUIDSuccess", new UnityAction(this.IOKBKOJBFEI));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendAddFriendByUIDException", new UnityAction(this.PJLOGGMOIDE));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendRequestCustomProfileSuccess", new UnityAction(this.BGEPCDAIGLF));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendRequestCustomProfileException", new UnityAction(this.NGKDOFIKCKB));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnFriendsPopupManagerAcceptClick", new UnityAction(this.OAAODBKAMCN));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnFriendsPopupManagerRejectClick", new UnityAction(this.BJLDDFCFIOH));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnFriendsPopupSendPremClick", new UnityAction(this.FMNPOBDLDBO));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnFriendsPopupSendSimpleClick", new UnityAction(this.BLFFOEGNAMJ));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnFriendsPopupAddToFavClick", new UnityAction(this.FEEHPCDHKOO));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnFriendsPopupRemovFromFavClick", new UnityAction(this.OPOBHBCMLLK));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnFriendsPopupFriendMatchClick", new UnityAction(this.ADBHDBOAGHG));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnFriendsPopupDeleteClick", new UnityAction(this.GKFFJLCPLFA));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendRequestFriendRejectSuccess", new UnityAction(this.NCOGHCHLKLL));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendRequestFriendRejectException", new UnityAction(this.IMHNNOAIOOI));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendRequestFriendAcceptSuccess", new UnityAction(this.PDMPEDKAEIM));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendRequestFriendAcceptException", new UnityAction(this.NAPLEHDCPNG));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendRequestFriendDeleteSuccess", new UnityAction(this.MBGLDPKFHDM));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendRequestFriendDeleteException", new UnityAction(this.OCPPLJAPKAI));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendRequestShareHardSuccess", new UnityAction(this.CIONFFFABCA));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendRequestShareHardException", new UnityAction(this.LCLBKJFBJBE));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnFriendsCurrencyPopupCollect", new UnityAction(this.NDPEFOGALEC));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendRequestCollectGiftSuccess", new UnityAction(this.HEJLBMMJLHH));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendRequestCollectGiftException", new UnityAction(this.EBDNNEJFEPB));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnAllCollectableCardsDownloadSuccess", new UnityAction(this.KBDAHECFAJM));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnAllCollectableCardsDownloadFailed", new UnityAction(this.OAJDBPJBABO));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnProfileMessageClosed", new UnityAction(this.OnProfileMessageClosed));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnFriendsPopupSendMessageClick", new UnityAction(this.GGJEBMBLBNJ));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("onFriendsPopupOpenMessageHistory", new UnityAction(this.ECJMCJIKHFB));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPopupProfileMessageInputEndEdit", new UnityAction(this.OCGJHAPFJOE));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPopupProfileMessageInputCancel", new UnityAction(this.IJJKDIAGJKD));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendRequestSendMessageException", new UnityAction(this.OnBackendRequestSendMessageException));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendRequestSendMessageSuccess", new UnityAction(this.OnBackendRequestSendMessageSuccess));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnContinueToSendSimpleMessage", new UnityAction(this.OnContinueToSendSimpleMessage));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnFriendsMessageConsume", new UnityAction(this.MGDJJIPNPHH));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendRequestConsumeMessageSuccess", new UnityAction(this.PJPDBBFDCFD));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendRequestConsumeMessageException", new UnityAction(this.ICIHCCKPOJJ));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPopupCardOptionsBackClick", new UnityAction(this.OnPopupCardOptionsBackClick));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPopupCardOptionsNextClick", new UnityAction(this.OnPopupCardOptionsNextClick));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPurchasingViewLeave", new UnityAction(this.OnPurchasingViewLeave));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnApplicationFocusBasicSyncSuccess", new UnityAction(this.OnApplicationFocusBasicSyncSuccess));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnFullscreenCardOptionClick", new UnityAction(this.ViewCardCutscene));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPopupCardOptionsSendGiftClick", new UnityAction(this.GACONMKBMCM));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendRequestSendGiftCardSuccess", new UnityAction(this.OnBackendRequestSendGiftCardSuccess));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendRequestSendGiftCardException", new UnityAction(this.OnBackendRequestSendGiftCardException));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnFriendsGiftPopulCollectPart1", new UnityAction(this.AHDMHAAMDAA));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnFriendsGiftPopulCollectPart2", new UnityAction(this.EGBEPEIEJGL));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPopupCardOptionsEditClick", new UnityAction(this.JHDEJHKGEHF));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("onPopupCardOptionsCloseClick", new UnityAction(this.FDPIFKHEEKP));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnApplicationFocusBasicSyncStart", new UnityAction(this.OnApplicationFocusBasicSyncStart));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPopupCardOptionsUnlockWithSpSuccessContinue", new UnityAction(this.DHCDEGCINPO));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendRequestBreakCardSuccess", new UnityAction(this.OIDGPBKMLIO));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendRequestBreakCardException", new UnityAction(this.HPJHPFEEFJI));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendUpgradeToGiftCardSuccess", new UnityAction(this.EANGIJLLIMO));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendUpgradeToGiftCardException", new UnityAction(this.ECOFOJBOOPF));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendGetFriendMessagingHistorySuccess", new UnityAction(this.ODAIFMLAFIK));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendGetFriendMessagingHistoryException", new UnityAction(this.KONHHCKPCLI));
	}

	// Token: 0x06008F85 RID: 36741 RVA: 0x003F8C74 File Offset: 0x003F6E74
	public void OnWishedCardClickFromMyProfile(int LLLCDMNPKFI)
	{
		this.BOPAAIPGBCA = LLLCDMNPKFI;
		string str = "<align=\"center\"><alpha=#88>" + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialcardvolinfonotev2").Replace("XXX", GDJPPKAMIFL.EHBBFMCILPC.DKHIPEPOEFF(LLLCDMNPKFI) ?? "").Replace("YYY", "<i>" + GKJPOGNFKNK.DNILNCLIHAP(LLLCDMNPKFI, "cardschar", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()) + "</i>").Replace("ZZZ", "<i>" + GKJPOGNFKNK.DNILNCLIHAP("anthology" + LJNMIPMNOKF.EHBBFMCILPC.KMDBNEFCPOH(LLLCDMNPKFI).AMKCLHLIIMN.ToString(), "anthologiestitle", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()) + "</i>") + "<alpha=#FF><align=\"left\">";
		if (this.IJPMLEKMGMA.GIFPFPOPEJN && !this.IJPMLEKMGMA.EEBMPDNLJGD.Equals(AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.EEBMPDNLJGD))
		{
			string eempglhpkjg = GDJPPKAMIFL.EHBBFMCILPC.KCMKJBHBCGC(LLLCDMNPKFI);
			string str2;
			if (this.IJPMLEKMGMA.KNCFKDLOPGA.Length == 0)
			{
				str2 = "<" + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("profilenametitleshort") + ">";
			}
			else
			{
				str2 = this.IJPMLEKMGMA.KNCFKDLOPGA;
			}
			if (AKLFPGMDKLA.EHBBFMCILPC.NDINEHGFPNN(this.IJPMLEKMGMA).Contains(LLLCDMNPKFI))
			{
				if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.JNNBNNDOGIM.BCPOHPEJLGB(this.IJPMLEKMGMA))
				{
					CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtonsAndCloseOverride(eempglhpkjg, str + "\n\n" + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("onwishcardclickbodymatch").Replace("XXX", "<i>" + str2 + "</i>"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("tradewishcardoption2"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("tradewishcardoption1"), new UnityAction(this.JEJKDFHFKIC), new UnityAction(this.IIMNPHNGDCI), new UnityAction(this.GJNDBHEOMHD), DFGILFBGPLN.popupEnergyHint, 0f, 28);
					return;
				}
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtonsAndCloseOverride(eempglhpkjg, str + "\n\n" + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("onwishcardclickbodymatch").Replace("XXX", "<i>" + str2 + "</i>"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("tradewishcardoption0"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("tradewishcardoption1"), new UnityAction(this.DMELLKDBPHP), new UnityAction(this.IIMNPHNGDCI), new UnityAction(this.GJNDBHEOMHD), DFGILFBGPLN.popupEnergyHint, 0f, 28);
				return;
			}
			else if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.JNNBNNDOGIM.BCPOHPEJLGB(this.IJPMLEKMGMA))
			{
				if (AKLFPGMDKLA.EHBBFMCILPC.FMDLELFEOFP(LLLCDMNPKFI))
				{
					CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtonsAndCloseOverride(eempglhpkjg, str + "\n\n" + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("onwishcardclickbody").Replace("XXX", "<i>" + str2 + "</i>"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("tradewishcardoption2"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("tradewishcardoption1"), new UnityAction(this.JEJKDFHFKIC), new UnityAction(this.IIMNPHNGDCI), new UnityAction(this.GJNDBHEOMHD), DFGILFBGPLN.popupEnergyHint, 0f, 28);
					return;
				}
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(eempglhpkjg, str + "\n\n" + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("onwishcardclickbody").Replace("XXX", "<i>" + str2 + "</i>"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("tradewishcardoption2"), new UnityAction(this.JEJKDFHFKIC), new UnityAction(this.GJNDBHEOMHD), DFGILFBGPLN.popupEnergyHint, 0f, 28);
				return;
			}
			else
			{
				if (AKLFPGMDKLA.EHBBFMCILPC.FMDLELFEOFP(LLLCDMNPKFI))
				{
					CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtonsAndCloseOverride(eempglhpkjg, str + "\n\n" + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("onwishcardclickbody").Replace("XXX", "<i>" + str2 + "</i>"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("tradewishcardoption0"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("tradewishcardoption1"), new UnityAction(this.DMELLKDBPHP), new UnityAction(this.IIMNPHNGDCI), new UnityAction(this.GJNDBHEOMHD), DFGILFBGPLN.popupEnergyHint, 0f, 28);
					return;
				}
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(eempglhpkjg, str + "\n\n" + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("onwishcardclickbody").Replace("XXX", "<i>" + str2 + "</i>"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("tradewishcardoption0"), new UnityAction(this.DMELLKDBPHP), new UnityAction(this.GJNDBHEOMHD), DFGILFBGPLN.popupEnergyHint, 0f, 28);
				return;
			}
		}
		else
		{
			string eempglhpkjg2 = GDJPPKAMIFL.EHBBFMCILPC.KCMKJBHBCGC(LLLCDMNPKFI);
			if (!this.IJPMLEKMGMA.GIFPFPOPEJN)
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(eempglhpkjg2, str + "\n\n" + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("onwishcardclickbodyplayer"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialremovewishedcard"), new UnityAction(this.PLPNHKPAMJO), new UnityAction(this.OnGenericDoNothing), DFGILFBGPLN.popupEnergyHint, 0f, 28);
				return;
			}
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(eempglhpkjg2, str + "\n\n" + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("onwishcardclickbodyplayer"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
			return;
		}
	}

	// Token: 0x06008F86 RID: 36742 RVA: 0x003F9203 File Offset: 0x003F7403
	public void OnNeedToUpdateCollectedGiftsSection()
	{
		AKLFPGMDKLA.EHBBFMCILPC.CIPCINKGILF = true;
		this.contentFriendsPage.UpdateReceivedGifts(this.IJPMLEKMGMA);
	}

	// Token: 0x06008F87 RID: 36743 RVA: 0x003F9224 File Offset: 0x003F7424
	public void PurchaseCardUpgradeWeb()
	{
		int bopaaipgbca = this.BOPAAIPGBCA;
		OBHDGKFFICI productData = PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager().GetProductData(KDCJJBLGCBH.EHBBFMCILPC.HOBCAABBDLC(GDJPPKAMIFL.EHBBFMCILPC.NDJDOAPFCLH(bopaaipgbca)));
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.EHBBFMCILPC.PDJKPFLHFLO(KDCJJBLGCBH.EHBBFMCILPC.HOBCAABBDLC(GDJPPKAMIFL.EHBBFMCILPC.NDJDOAPFCLH(bopaaipgbca)));
		if (productData != null && ocbiopoeenj != null)
		{
			CommonUserInterface.EHBBFMCILPC.ShowPopupOnlineResources(ocbiopoeenj.MBLAIKOOCFH() + "?uid=" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 2);
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("ProfileItem2.PurchaseCardUpgradeWeb(): productData or productBalanceData is null");
		this.LEBIMELAHBC = false;
	}

	// Token: 0x06008F88 RID: 36744 RVA: 0x003F92BC File Offset: 0x003F74BC
	public void OHIPEMEDILB(string JEDGAJJNIPD)
	{
		CommonUserInterface.IKNOFBFMPGA().ShowConnectingAnimation((byte)-88);
		JSONObject dmimkkciaph = null;
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null && AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA)
		{
			dmimkkciaph = AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.BNMFBKNEMIF();
			DPGJIJGOCIC.NFIDPOMCNLP("OnPopupPromoCodesReadInputEndEdit");
			AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA = false;
		}
		JSONObject defaultOperationsJsonObject = ProfileItem2.GetDefaultOperationsJsonObject(0, true);
		defaultOperationsJsonObject.Add("Error. ShowEnvironment(), environment ", JEDGAJJNIPD);
		FirebaseAnalyticsManager.JMDJBFAEHBM().LMCJKLHOHJC(true, AGEHCPDNBFD.issueRepCdn.ToString(), FFPHBMFGCNN.ram.ToString(), "", true, false);
		FirebaseAnalyticsManager.EHBBFMCILPC.JIAAMJPKOCE(true, ((AGEHCPDNBFD)125).ToString(), ((FFPHBMFGCNN)89).ToString(), "<i>", false, false);
		AKLFPGMDKLA.EHBBFMCILPC.CIPCINKGILF = true;
		BackendOperationsManager.NPDDBAONMJP().RequestGetUserPublicProfile(false, dmimkkciaph, defaultOperationsJsonObject, "\"", "OnFriendsCurrencyPopupCollect", true);
	}

	// Token: 0x06008F89 RID: 36745 RVA: 0x003F93BE File Offset: 0x003F75BE
	private void BJNHFGMJHBK()
	{
		this.contentFriendsPage.PopulateCardsOnFriends(this.IJPMLEKMGMA, this);
		this.FHAJFICFLBG(this.IJPMLEKMGMA);
	}

	// Token: 0x06008F8A RID: 36746 RVA: 0x003F93E0 File Offset: 0x003F75E0
	private void LCLBKJFBJBE()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("app42error"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupBackendError, 0f, 28);
		this.LEJIJOAOEBK = null;
		this.MHKKGOCMIJI = null;
		this.MarkAsModified();
	}

	// Token: 0x06008F8B RID: 36747 RVA: 0x003F944C File Offset: 0x003F764C
	[CompilerGenerated]
	private void HKAKEJMJIPI()
	{
		this.UpdateHeaderStatus(FFIAHOPJJJG.Story);
	}

	// Token: 0x06008F8C RID: 36748 RVA: 0x003F9458 File Offset: 0x003F7658
	public void OnCutsceneClick(BNFCLKNDBLO CIBKELALAHF)
	{
		try
		{
			if (CIBKELALAHF != null)
			{
				if (this.IJPMLEKMGMA == null || this.IJPMLEKMGMA.GIFPFPOPEJN || KDCJJBLGCBH.EHBBFMCILPC.AMHJKMPIPGK() || KHPGPLAMAIN.EJCNHEBIOJF())
				{
					this.ViewCutscene(CIBKELALAHF);
				}
				else
				{
					this.PDPJFCHINPN = CIBKELALAHF;
					string text = (CIBKELALAHF.PGEKNGNHANN == null) ? "" : CIBKELALAHF.PGEKNGNHANN.Trim();
					string text2 = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cutsceneoptionsbody");
					if (text.Length == 0)
					{
						text2 = text2.Replace(" XXX", "").Replace("XXX", "");
					}
					else
					{
						text2 = text2.Replace("XXX", "<i>" + text + "</i>");
					}
					CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtonsAndCloseOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cutsceneoptionstitle"), text2, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cutsceneoptionsview"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cardoptionsloadingtheme"), new UnityAction(this.GFCODPAIEIA), new UnityAction(this.MBKOJNIJGLA), new UnityAction(this.OnGenericDoNothing), DFGILFBGPLN.popupEnergyHint, 0f, 28);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06008F8D RID: 36749 RVA: 0x003F95A4 File Offset: 0x003F77A4
	public void OnCardViewClickFromMyProfile()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.GNLNPMPJPEC())
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialprivatenogiftcardsend"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
			return;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.LAKHGAPCKBC)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialprofilesuspcantuse"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
			return;
		}
		if (LJNMIPMNOKF.EHBBFMCILPC.COCEMBDEKIP() != GCFLILHCOEI.cardsFilterNone)
		{
			LJNMIPMNOKF.EHBBFMCILPC.KNAEAJPDGKB(GCFLILHCOEI.cardsFilterNone, -1, -1);
		}
		this.EPNOBCLPJJO = HKPBEDBPHNJ.sendGiftCardByUserId;
		LJNMIPMNOKF.EHBBFMCILPC.AMCFJAMHKHN(this.GKBMOLFNBOH);
		this.ShowCardOptionsOrDownload();
	}

	// Token: 0x06008F8E RID: 36750 RVA: 0x003F9688 File Offset: 0x003F7888
	private void FDPIFKHEEKP()
	{
		this.KEIKGFKANOL = "";
		this.PGGPPCINLMB = "";
	}

	// Token: 0x06008F8F RID: 36751 RVA: 0x003F96A0 File Offset: 0x003F78A0
	private void INAHNIMEBOF()
	{
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(37))
		{
			AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(37);
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("newtutorialwishedcards"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("continue"), DFGILFBGPLN.popupTools, 0.75f, 28);
		}
	}

	// Token: 0x06008F90 RID: 36752 RVA: 0x003F9708 File Offset: 0x003F7908
	public void UnhideAllTopMatchItems(bool BDFHENEFGKI = false)
	{
		this.IJPMLEKMGMA.FIMCPPIBHPM(BDFHENEFGKI);
		if (BDFHENEFGKI)
		{
			if (this.IJPMLEKMGMA.GIFPFPOPEJN)
			{
				this.topMatchOngoingHiddenRandom.SetActive(false);
			}
			else
			{
				this.topMatchOngoingHidden.SetActive(false);
			}
			this.topMatchOngoingItemsParent.GetComponent<GridLayoutGroup>().padding.bottom = 15;
			this.HFNBHGNFIGB(this.IJPMLEKMGMA, this.titleTopMatchOngoing, this.topMatchOngoingItemsParent, BDFHENEFGKI, true);
			return;
		}
		if (this.IJPMLEKMGMA.GIFPFPOPEJN)
		{
			this.topMatchHiddenRandom.SetActive(false);
		}
		else
		{
			this.topMatchHidden.SetActive(false);
		}
		this.topMatchItemsParent.GetComponent<GridLayoutGroup>().padding.bottom = 15;
		this.HFNBHGNFIGB(this.IJPMLEKMGMA, this.titleTopMatch, this.topMatchItemsParent, BDFHENEFGKI, true);
	}

	// Token: 0x06008F91 RID: 36753 RVA: 0x003F97D8 File Offset: 0x003F79D8
	private void AOLHMMGALPJ(PMEPALPCEAF FOKFGMIEEDB)
	{
		if (FOKFGMIEEDB.LAKHGAPCKBC && !FOKFGMIEEDB.GIFPFPOPEJN)
		{
			this.editCredoButton.SetActive(false);
			this.editRCPlayButton.SetActive(false);
			this.editButtons.ForEach(new Action<Button>(ProfileItem2.<>c.<>9.FPINNANJHPK));
		}
	}

	// Token: 0x06008F92 RID: 36754 RVA: 0x003F9838 File Offset: 0x003F7A38
	public void ShowCardOptionsOrDownload()
	{
		string finoaaokiic = "";
		int num = KDCJJBLGCBH.EHBBFMCILPC.OFKOCAGJLMP();
		bool flag;
		if (num > 0)
		{
			flag = !LJNMIPMNOKF.EHBBFMCILPC.IHOIGNLKNDA();
		}
		else
		{
			flag = !GKJPOGNFKNK.CEHOHNOKLIK(LJNMIPMNOKF.EHBBFMCILPC.AOOPMDIBAFP());
		}
		if (!flag)
		{
			if (this.FGDEGMOLIDB)
			{
				this.FGDEGMOLIDB = false;
				CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
				CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
				this.CMDIKMNEGEN();
				AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnLiveProfileThemesLoaderStart", 0f);
			}
			if (this.EPNOBCLPJJO == HKPBEDBPHNJ.viewGiftCardAsIncomingGift)
			{
				if (this.showingCardGiftAnimation)
				{
					base.StartCoroutine(this.FOKBBGOFHLG());
					return;
				}
				if (this.PNPEHMLHDPO != null && this.PNPEHMLHDPO.IFEEIAPMIML != null && this.PNPEHMLHDPO.IFEEIAPMIML.CCMDLENEDGJ >= 0)
				{
					LJNMIPMNOKF.EHBBFMCILPC.AMCFJAMHKHN(this.PNPEHMLHDPO.IFEEIAPMIML.CCMDLENEDGJ);
					if (this.PNPEHMLHDPO.IFEEIAPMIML.BONNGONEJBO != null && this.PNPEHMLHDPO.IFEEIAPMIML.BONNGONEJBO.Length > 0)
					{
						finoaaokiic = (this.PGGPPCINLMB = this.PNPEHMLHDPO.IFEEIAPMIML.BONNGONEJBO);
					}
				}
				AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnLobbyStartFireworksEffectAutoHide", 0f);
			}
			LobbyUserInterface.EHBBFMCILPC.ShowPopupCardOptions(LJNMIPMNOKF.EHBBFMCILPC.EBBLJMHNDKK(), this.LEJIJOAOEBK, this.EPNOBCLPJJO, finoaaokiic, null);
			return;
		}
		if (num > 0)
		{
			base.StartCoroutine(this.HCAHEOPANBC(num));
			return;
		}
		base.StartCoroutine(this.NBKMFHDIBPK());
	}

	// Token: 0x06008F93 RID: 36755 RVA: 0x003F99BC File Offset: 0x003F7BBC
	private void CDKFEEAKCOH(PMEPALPCEAF FOKFGMIEEDB)
	{
		Vector2 onkonhljkpg = this.CalculateViewportUpDownMargins(this.anthologyAchievementsScrollView);
		using (List<Sprite>.Enumerator enumerator = GKJPOGNFKNK.EALDMCLPMPH(AssetsManager.EHBBFMCILPC.profileDataAsset.JHFNENEICGB(), true).GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				ProfileItem2.PDENALLIHKI pdenallihki = new ProfileItem2.PDENALLIHKI();
				pdenallihki.<>4__this = this;
				pdenallihki.sprite = enumerator.Current;
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.anthologyAchievementGridItem, this.contentAnthologyAchievementsTransform);
				gameObject.GetComponent<ContentAnthologyAchievementGridItem>().SetContent(FOKFGMIEEDB, pdenallihki.sprite, onkonhljkpg);
				gameObject.GetComponent<ContentAnthologyAchievementGridItem>().gridButton.onClick.AddListener(new UnityAction(pdenallihki.IPKDHJGJIGF));
			}
		}
		this.EKIOCPPHBCP();
	}

	// Token: 0x06008F94 RID: 36756 RVA: 0x003F9A80 File Offset: 0x003F7C80
	private IEnumerator BOBCGFGHBBH()
	{
		this.EPNOBCLPJJO = HKPBEDBPHNJ.viewGiftCardAsIncomingGift;
		if (this.PNPEHMLHDPO != null && this.PNPEHMLHDPO.IFEEIAPMIML != null && this.PNPEHMLHDPO.IFEEIAPMIML.CCMDLENEDGJ >= 0)
		{
			LJNMIPMNOKF.EHBBFMCILPC.KNAEAJPDGKB(GCFLILHCOEI.cardsFilterCollected, this.PNPEHMLHDPO.IFEEIAPMIML.CCMDLENEDGJ, -1);
			LJNMIPMNOKF.EHBBFMCILPC.CFBFLFGBLFE(this.PNPEHMLHDPO.IFEEIAPMIML.CCMDLENEDGJ);
		}
		else
		{
			LJNMIPMNOKF.EHBBFMCILPC.KNAEAJPDGKB(GCFLILHCOEI.cardsFilterNone, -1, -1);
		}
		LobbyUserInterface.EHBBFMCILPC.ShowLetterAppearAnimation(false, "");
		yield return new WaitForSeconds(1f);
		this.ShowCardOptionsOrDownload();
		yield break;
	}

	// Token: 0x06008F95 RID: 36757 RVA: 0x003EF708 File Offset: 0x003ED908
	public void OnPopupCardOptionsNextClick()
	{
		this.PGGPPCINLMB = "";
		LobbyUserInterface.EHBBFMCILPC.GetPopupCardOptions().FlipVerticalAnimatedPopupManagerAnimationsScale();
		this.ShowCardOptionsOrDownload();
	}

	// Token: 0x06008F96 RID: 36758 RVA: 0x003F9A90 File Offset: 0x003F7C90
	public void OnBadgeClick2()
	{
		try
		{
			string text = this.JLPOBLKCIEL;
			bool flag = false;
			if (text.Contains("locked"))
			{
				flag = true;
				text = text.Replace("locked", "");
			}
			if (text.Length > 14)
			{
				text = text.Substring(0, 12);
			}
			int num = 0;
			try
			{
				num = int.Parse(text.Replace("socialbadge", ""));
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
			string text2;
			if (flag && !this.IJPMLEKMGMA.GIFPFPOPEJN)
			{
				if (num >= 100 && num <= 199)
				{
					text2 = "<align=\"center\"><i><alpha=#88>" + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialbadgelocked") + "</i><align=\"left\"><alpha=#FF>\n\n" + GKJPOGNFKNK.DNILNCLIHAP(text.Replace("socialbadge", "socialbadgedesc"), "badges", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
				}
				else
				{
					text2 = "<align=\"center\"><i><alpha=#88>" + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialbadgelocked") + "</i><align=\"left\"><alpha=#FF>\n\n" + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(text.Replace("socialbadge", "socialbadgedesc"));
				}
			}
			else if (num >= 100 && num <= 199)
			{
				text2 = GKJPOGNFKNK.DNILNCLIHAP(text.Replace("socialbadge", "socialbadgedesc"), "badges", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
			}
			else
			{
				text2 = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(text.Replace("socialbadge", "socialbadgedesc"));
			}
			string text3;
			if (num >= 100 && num <= 199)
			{
				text3 = GKJPOGNFKNK.DNILNCLIHAP(text.Replace("socialbadge", "socialbadgetitle"), "badges", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
			}
			else
			{
				text3 = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(text.Replace("socialbadge", "socialbadgetitle"));
			}
			if (num == 0 || num == 9 || num == 10)
			{
				text2 = text2.Replace("XXX", KDCJJBLGCBH.EHBBFMCILPC.DONFPMKHKLP(num).ToString() ?? "");
			}
			if (num != 1)
			{
				if (flag && !this.IJPMLEKMGMA.GIFPFPOPEJN)
				{
					float num2 = 0f;
					int num3 = -1;
					if (num == 0)
					{
						num2 = (float)AKLFPGMDKLA.EHBBFMCILPC.ECPKIEMGLNN;
						num3 = (int)Mathf.Ceil(num2 / (float)KDCJJBLGCBH.EHBBFMCILPC.DONFPMKHKLP(num) * 100f);
					}
					else if (num == 9)
					{
						num2 = (float)this.IJPMLEKMGMA.DBJMOAOBHKE;
						num3 = (int)Mathf.Ceil(num2 / (float)KDCJJBLGCBH.EHBBFMCILPC.DONFPMKHKLP(num) * 100f);
					}
					else if (num == 10)
					{
						num2 = (float)AKLFPGMDKLA.EHBBFMCILPC.ECPKIEMGLNN;
						num3 = (int)Mathf.Ceil(num2 / (float)KDCJJBLGCBH.EHBBFMCILPC.DONFPMKHKLP(num) * 100f);
					}
					else if (num == 3 || num == 4 || num == 5 || num == 6 || num == 7 || num == 8 || (num >= 100 && num < 200))
					{
						num3 = IOGOGMEJCIK.EHBBFMCILPC.LOLOPPHMKND(num);
					}
					if (num3 >= 0)
					{
						num3 = Math.Clamp(num3, 0, 100);
						text3 = text3 + " (" + num3.ToString() + "%)";
					}
					if (num == 0 || num == 9 || num == 10)
					{
						if (num2 < (float)KDCJJBLGCBH.EHBBFMCILPC.DONFPMKHKLP(num))
						{
							if (num3 >= 100)
							{
							}
						}
					}
				}
			}
			else
			{
				text3 = text3.Replace("XXX", this.IJPMLEKMGMA.DELPFFPOEJJ.ToString() ?? "");
			}
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(text3, text2, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
		}
	}

	// Token: 0x06008F97 RID: 36759 RVA: 0x003F9E58 File Offset: 0x003F8058
	public void OnSpecialCurrencyClick(int LIFFJBHKNBK)
	{
		this.PGBNCMDDDBL = LIFFJBHKNBK;
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(30))
		{
			AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(30);
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("newtutorialtreasures"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("continue"), new UnityAction(this.OnSpecialCurrencyClick2), DFGILFBGPLN.popupTools, 0f, 28);
			return;
		}
		this.OnSpecialCurrencyClick2();
	}

	// Token: 0x06008F98 RID: 36760 RVA: 0x003F9EDC File Offset: 0x003F80DC
	private void OAJDBPJBABO()
	{
		if (this.FGDEGMOLIDB && LJNMIPMNOKF.EHBBFMCILPC.IHOIGNLKNDA())
		{
			DPGJIJGOCIC.ADFCDFHBDAF("ProfileItem2.OnAllCollectableCardsDownloadFailed(): the pool run failed but the scroll index card is resident, showing");
			this.ShowCardOptionsOrDownload();
			return;
		}
		this.NPMNDNEDBGC++;
		if (this.NPMNDNEDBGC >= KBOJLHAJPCP.LPJOFEDNKHA)
		{
			CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
			CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.cdnActiv.ToString(), FFPHBMFGCNN.dldFail.ToString(), BGHLMGPPCNN.cdnPrfToCrd.ToString(), false, false);
			this.NPMNDNEDBGC = 0;
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cdnerror"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("retry"), new UnityAction(this.ShowCardOptionsOrDownload), new UnityAction(this.HIODKHCOJOE), DFGILFBGPLN.popupCdnDownloadFailed, 0f, 28);
			return;
		}
		this.ShowCardOptionsOrDownload();
	}

	// Token: 0x06008F99 RID: 36761 RVA: 0x003F9FE4 File Offset: 0x003F81E4
	public void OnShuffleClick()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.GNLNPMPJPEC())
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialprivatenorandom"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
			return;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.LAKHGAPCKBC)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialprofilesuspcantuse"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
			return;
		}
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(18))
		{
			AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(18);
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("randomprofilewhatis"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("continue"), new UnityAction(this.OnShuffleClick), DFGILFBGPLN.popupTools, 0f, 28);
			return;
		}
		this.NEDAFKKJGGK = true;
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(96);
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null && (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA || AKLFPGMDKLA.EHBBFMCILPC.BNOHIAEGOMI() > (double)KDCJJBLGCBH.EHBBFMCILPC.BCJPLCIFNIF()))
		{
			if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA)
			{
				DPGJIJGOCIC.ADFCDFHBDAF("RequestGetUserPublicProfile(): Account.Instance.userPublicProfile.modified");
			}
			else
			{
				DPGJIJGOCIC.ADFCDFHBDAF("RequestGetUserPublicProfile(): timer hit: " + AKLFPGMDKLA.EHBBFMCILPC.BNOHIAEGOMI().ToString());
			}
			BackendOperationsManager.EHBBFMCILPC.RequestGetUserPublicProfile(true, AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.BNMFBKNEMIF(), null, "OnBackendGetPublicProfileProfileItemSuccess", "OnBackendGetPublicProfileProfileItemException", false);
			AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA = false;
			AKLFPGMDKLA.EHBBFMCILPC.HOBAOJMIPBC();
			return;
		}
		BackendOperationsManager.EHBBFMCILPC.RequestGetUserPublicProfile(true, null, null, "OnBackendGetPublicProfileProfileItemSuccess", "OnBackendGetPublicProfileProfileItemException", false);
	}

	// Token: 0x06008F9A RID: 36762 RVA: 0x003FA1DB File Offset: 0x003F83DB
	private void EGBEPEIEJGL()
	{
		this.NDPEFOGALEC();
	}

	// Token: 0x06008F9B RID: 36763 RVA: 0x00003E52 File Offset: 0x00002052
	public void OnFriendsRefreshClick()
	{
	}

	// Token: 0x06008F9C RID: 36764 RVA: 0x003FA1E4 File Offset: 0x003F83E4
	public void OnBackendRequestSendMessageSuccess()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		LobbyUserInterface.EHBBFMCILPC.ShowLetterDisappearAnimation("");
		this.KEIKGFKANOL = "";
		LobbyUserInterface.EHBBFMCILPC.GetPopupCardOptions().ResetCustomMessageToFriend();
		this.PGGPPCINLMB = "";
		int num = -1;
		if (AKLFPGMDKLA.EHBBFMCILPC.ELAGGOHBOOA["frsendhres2"] != null)
		{
			num = AKLFPGMDKLA.EHBBFMCILPC.ELAGGOHBOOA["frsendhres2"].AsInt;
		}
		if (num >= 0)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialrequestsharegr" + num.ToString()), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.ELAGGOHBOOA["msh"] != null && this.LEJIJOAOEBK != null)
		{
			this.LEJIJOAOEBK.NGACBBJKKGN(AKLFPGMDKLA.EHBBFMCILPC.ELAGGOHBOOA["msh"].AsArray);
		}
	}

	// Token: 0x06008F9D RID: 36765 RVA: 0x003FA300 File Offset: 0x003F8500
	private void NAPLEHDCPNG()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("app42error"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupBackendError, 0f, 28);
		this.LEJIJOAOEBK = null;
		this.MHKKGOCMIJI = null;
		this.MarkAsModified();
	}

	// Token: 0x06008F9E RID: 36766 RVA: 0x00003E52 File Offset: 0x00002052
	private void NAJAOICJGKN()
	{
	}

	// Token: 0x06008F9F RID: 36767 RVA: 0x003FA36C File Offset: 0x003F856C
	public void OnContinueToSendPremGiftPositive()
	{
		if ((this.LEJIJOAOEBK != null && this.LEJIJOAOEBK.EEBMPDNLJGD.Length > 0) || LJNMIPMNOKF.EHBBFMCILPC.EBBLJMHNDKK().BJHMPPGDGOO.Length > 0)
		{
			CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithHint(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialmessagesending"), 0);
			LobbyUserInterface.EHBBFMCILPC.ShowLetterAppearAnimation(true, "");
			JSONObject dmimkkciaph = null;
			if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null && AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA)
			{
				dmimkkciaph = AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.BNMFBKNEMIF();
				DPGJIJGOCIC.NFIDPOMCNLP("SocialStatsUserPublicProfile.modified = false, OnContinueToSendPremGiftPositive()");
				AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA = false;
			}
			JSONObject defaultOperationsJsonObject = ProfileItem2.GetDefaultOperationsJsonObject(0, true);
			if (this.LEJIJOAOEBK != null && this.LEJIJOAOEBK.EEBMPDNLJGD.Length > 0)
			{
				defaultOperationsJsonObject.Add("frsgcpid", this.LEJIJOAOEBK.EEBMPDNLJGD);
			}
			else if (LJNMIPMNOKF.EHBBFMCILPC.EBBLJMHNDKK().FMJEOOFGLEE.Length > 0)
			{
				defaultOperationsJsonObject.Add("frsgcnick", LJNMIPMNOKF.EHBBFMCILPC.EBBLJMHNDKK().FMJEOOFGLEE);
			}
			else
			{
				defaultOperationsJsonObject.Add("frsgcuid", LJNMIPMNOKF.EHBBFMCILPC.EBBLJMHNDKK().BJHMPPGDGOO);
			}
			if (this.KEIKGFKANOL.Length > 0)
			{
				defaultOperationsJsonObject.Add("frsgcmsg64", DPGJIJGOCIC.FAIFJDPENOP(this.KEIKGFKANOL));
			}
			defaultOperationsJsonObject.Add("frsgccid", LJNMIPMNOKF.EHBBFMCILPC.EBBLJMHNDKK().CCMDLENEDGJ);
			AKLFPGMDKLA.EHBBFMCILPC.CIPCINKGILF = true;
			BackendOperationsManager.EHBBFMCILPC.QueueBasicSync();
			BackendOperationsManager.EHBBFMCILPC.RequestGetUserPublicProfile(false, dmimkkciaph, defaultOperationsJsonObject, "OnBackendRequestSendGiftCardSuccess", "OnBackendRequestSendGiftCardException", false);
		}
	}

	// Token: 0x06008FA0 RID: 36768 RVA: 0x003FA530 File Offset: 0x003F8730
	private void IDECGKLDAII(PMEPALPCEAF FOKFGMIEEDB)
	{
		ProfileItem2.OAHCJEPIPEJ oahcjepipej = new ProfileItem2.OAHCJEPIPEJ();
		oahcjepipej.<>4__this = this;
		oahcjepipej._profile = FOKFGMIEEDB;
		List<Sprite> list = oahcjepipej._profile.JMJOEHHFJGC(oahcjepipej._profile.GIFPFPOPEJN);
		if (list.Count != 0)
		{
			this.badgesHidden.SetActive(true);
			string collectedBadgesNoteText = this.GetCollectedBadgesNoteText(list);
			this.badgesHiddenText.SetText(collectedBadgesNoteText, true);
			this.badgesHiddenText.text = collectedBadgesNoteText;
			foreach (object obj in this.badges.transform)
			{
				Transform transform = (Transform)obj;
				transform.GetComponent<Button>().onClick.RemoveAllListeners();
				transform.gameObject.SetActive(false);
			}
			this.titleBadges.SetActive(false);
			this.badges.SetActive(true);
			for (int i = 0; i < list.Count; i++)
			{
				if (i < this.badges.transform.childCount)
				{
					ProfileItem2.HFNLOONJECP hfnloonjecp = new ProfileItem2.HFNLOONJECP();
					hfnloonjecp.CS$<>8__locals1 = oahcjepipej;
					Transform child = this.badges.transform.GetChild(i);
					child.gameObject.SetActive(true);
					hfnloonjecp.sprite = list[i];
					child.GetComponent<ContentBadgeItem>().imageThumb.sprite = hfnloonjecp.sprite;
					child.GetComponent<Button>().onClick.AddListener(new UnityAction(hfnloonjecp.NGDJFKGJDJM));
				}
				if (!ProfileItem2.expandBadgesByDefault && i >= this.maxShownBadgesItems - 1)
				{
					break;
				}
			}
		}
		else
		{
			this.badgesHidden.SetActive(true);
			this.titleBadges.SetActive(true);
			this.badges.SetActive(false);
		}
		this.badgesExpandButton.onClick.RemoveAllListeners();
		if (!ProfileItem2.expandBadgesByDefault)
		{
			this.badgesExpandButton.GetComponent<AnimationPress>().enabled = false;
			this.badgesExpandButton.GetComponent<Button>().enabled = false;
			this.badgesExpandButton.onClick.AddListener(new UnityAction(oahcjepipej.DBFHIONAMEI));
			this.badgesHiddenTextDropDown.color = new Color(1944f, 1445f, 1188f, 713f);
			return;
		}
		this.badgesExpandButton.GetComponent<AnimationPress>().enabled = true;
		this.badgesExpandButton.GetComponent<Button>().enabled = false;
		this.badgesHiddenTextDropDown.color = new Color(1425f, 315f, 110f, 450f);
	}

	// Token: 0x06008FA1 RID: 36769 RVA: 0x003FA7B8 File Offset: 0x003F89B8
	private void AHDMHAAMDAA()
	{
		if (this.PNPEHMLHDPO != null && this.PNPEHMLHDPO.EEBMPDNLJGD.Length > 0)
		{
			this.LEJIJOAOEBK = this.PNPEHMLHDPO;
			this.showingCardGiftAnimation = true;
			base.StartCoroutine(this.BOBCGFGHBBH());
		}
	}

	// Token: 0x06008FA2 RID: 36770 RVA: 0x003FA7F8 File Offset: 0x003F89F8
	private void AOKJHPAKJFJ()
	{
		string text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("mypnotif0");
		text = text.Replace("XXX", this.IJPMLEKMGMA.IJDGJJCKHAH().Count.ToString() ?? "");
		text = text.Replace("YYY", this.IJPMLEKMGMA.IPILOAEGBMD().Count.ToString() ?? "");
		this.contentCutscenesHeaderStatus.SetText(text, true);
		this.contentCutscenesHeaderStatus.text = text;
	}

	// Token: 0x06008FA3 RID: 36771 RVA: 0x003FA888 File Offset: 0x003F8A88
	public void MarkAsModified()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null)
		{
			AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA = true;
			AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.IDPMKIAAIFN = true;
			DPGJIJGOCIC.ANOPFDLPKGC("ProfileItem.MarkAsModified() - marking user profile as modified.");
		}
	}

	// Token: 0x06008FA4 RID: 36772 RVA: 0x003FA8C0 File Offset: 0x003F8AC0
	public void OnProfileClick()
	{
		this.activePageType = AMMHDNONFHM.MyProfile;
		JSONObject dmimkkciaph = null;
		JSONObject ailjhedfjgk = null;
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null && (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA || AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.IDPMKIAAIFN))
		{
			dmimkkciaph = AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.BNMFBKNEMIF();
			ailjhedfjgk = ProfileItem2.GetDefaultOperationsJsonObject(1, true);
			AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA = false;
			AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.IDPMKIAAIFN = false;
		}
		AKLFPGMDKLA.EHBBFMCILPC.LGFDPCALDAF();
		this.NEDAFKKJGGK = false;
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC == null)
		{
			CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(96);
			BackendOperationsManager.EHBBFMCILPC.RequestGetUserPublicProfile(false, dmimkkciaph, ailjhedfjgk, "OnBackendGetPublicProfileProfileItemSuccess", "OnBackendGetPublicProfileProfileItemException", false);
			return;
		}
		this.UpdateContent(AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC, AMMHDNONFHM.MyProfile);
		base.GetComponent<RectTransform>().localScale = new Vector3(1.1f, 1.1f, 1.1f);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnNeedToRestartProfileItemAnimation", 0f);
		this.mainScrollView.GetComponent<ScrollRect>().verticalNormalizedPosition = 1f;
	}

	// Token: 0x06008FA5 RID: 36773 RVA: 0x003FA9DC File Offset: 0x003F8BDC
	public void Unlike()
	{
		if (this.IJPMLEKMGMA.GIFPFPOPEJN && this.IJPMLEKMGMA.LMFCFHMJIFN.Length > 0)
		{
			this.IJPMLEKMGMA.MCMIMNEJJHK--;
			AKLFPGMDKLA.EHBBFMCILPC.MLEBKAIHGIO = "";
			this.avatarHeader.likesText.text = (this.IJPMLEKMGMA.MCMIMNEJJHK.ToString() ?? "");
			this.avatarHeader.likeButton.gameObject.SetActive(true);
			this.avatarHeader.alreadyLikedButton.gameObject.SetActive(false);
		}
	}

	// Token: 0x06008FA6 RID: 36774 RVA: 0x003FAA83 File Offset: 0x003F8C83
	private void GGJEBMBLBNJ()
	{
		if (this.LEJIJOAOEBK != null && this.LEJIJOAOEBK.EEBMPDNLJGD.Length > 0)
		{
			CommonUserInterface.EHBBFMCILPC.ShowPopupProfileMessageInput(0);
		}
	}

	// Token: 0x06008FA7 RID: 36775 RVA: 0x003F3CE8 File Offset: 0x003F1EE8
	public void OnContinueToSendPremGiftNegative()
	{
		this.IGNJLJIKCHI();
	}

	// Token: 0x06008FA8 RID: 36776 RVA: 0x003FAAAC File Offset: 0x003F8CAC
	private void HPJHPFEEFJI()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("app42error"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupBackendError, 0f, 28);
	}

	// Token: 0x06008FA9 RID: 36777 RVA: 0x003FAB04 File Offset: 0x003F8D04
	private void PDBFJOMMIJP()
	{
		if (this.LEJIJOAOEBK != null && this.LEJIJOAOEBK.EEBMPDNLJGD.Length > 0)
		{
			CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(96);
			JSONObject dmimkkciaph = null;
			if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null && AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA)
			{
				dmimkkciaph = AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.BNMFBKNEMIF();
				DPGJIJGOCIC.NFIDPOMCNLP("SocialStatsUserPublicProfile.modified = false, OnFriendsPopupManagerRejectClick()");
				AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA = false;
			}
			JSONObject defaultOperationsJsonObject = ProfileItem2.GetDefaultOperationsJsonObject(0, true);
			defaultOperationsJsonObject.Add("frsendh", this.LEJIJOAOEBK.EEBMPDNLJGD);
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.socFriend.ToString(), FFPHBMFGCNN.frSendGems.ToString(), "", false, false);
			AKLFPGMDKLA.EHBBFMCILPC.CIPCINKGILF = true;
			BackendOperationsManager.EHBBFMCILPC.QueueBasicSync();
			BackendOperationsManager.EHBBFMCILPC.RequestGetUserPublicProfile(false, dmimkkciaph, defaultOperationsJsonObject, "OnBackendRequestShareHardSuccess", "OnBackendRequestShareHardException", false);
		}
	}

	// Token: 0x06008FAA RID: 36778 RVA: 0x003FAC09 File Offset: 0x003F8E09
	public void OpenCustomProfileFromHallOfFame(PMEPALPCEAF MAFDLAILFMI)
	{
		this.contentHallOfFamePage.verticalNormalizedPositionHallOfFameScroll = this.contentHallOfFamePage.hallOfFameScrollView.GetComponent<ScrollRect>().verticalNormalizedPosition;
		AKLFPGMDKLA.EHBBFMCILPC.CLDBILNPMCN = MAFDLAILFMI;
		this.BMMEPHKOLAO = 0;
		this.RequestCustomProfile(MAFDLAILFMI);
	}

	// Token: 0x06008FAB RID: 36779 RVA: 0x003FAC44 File Offset: 0x003F8E44
	private void JEJKDFHFKIC()
	{
		this.LEJIJOAOEBK = this.IJPMLEKMGMA;
		this.GGJEBMBLBNJ();
	}

	// Token: 0x06008FAC RID: 36780 RVA: 0x003FAC58 File Offset: 0x003F8E58
	public void OnBackendGetPublicProfileProfileItemException()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC == null && AKLFPGMDKLA.EHBBFMCILPC.OEONCFGBLIF != null)
		{
			AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC = AKLFPGMDKLA.EHBBFMCILPC.OEONCFGBLIF;
			DPGJIJGOCIC.ANOPFDLPKGC("ProfileItem.OnBackendGetPublicProfileProfileItemException() - Account.Instance.userPublicProfile is null, replacing with temp copy");
		}
		if (this.NEDAFKKJGGK)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("app42error"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("retry"), new UnityAction(this.OnShuffleClick), DFGILFBGPLN.popupBackendError, 0f, 28);
		}
		else
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("app42error"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("retry"), new UnityAction(this.OnProfileClick), DFGILFBGPLN.popupBackendError, 0f, 28);
		}
		this.MarkAsModified();
	}

	// Token: 0x06008FAD RID: 36781 RVA: 0x003FAD4F File Offset: 0x003F8F4F
	public void OnPurchasingViewLeave()
	{
		this.OnPopupCardOptionsReopen();
		if (!this.IJPMLEKMGMA.GIFPFPOPEJN)
		{
			this.BJNHFGMJHBK();
			this.OnNeedToUpdatedBadgesSection();
			this.ExecuteCardUpgradeBackendRequest();
		}
		ApplicationFocusManager.EHBBFMCILPC.ForceBasicSync();
	}

	// Token: 0x06008FAE RID: 36782 RVA: 0x003FAD80 File Offset: 0x003F8F80
	private void DEGAPOBAOGH()
	{
		int bopaaipgbca = this.BOPAAIPGBCA;
		AKLFPGMDKLA.EHBBFMCILPC.IENJEMJFOFI(bopaaipgbca);
		AKLFPGMDKLA.EHBBFMCILPC.CIPCINKGILF = true;
		this.JNCCHOJOBJB();
	}

	// Token: 0x06008FAF RID: 36783 RVA: 0x003FADB0 File Offset: 0x003F8FB0
	private string NIABDGGBDFI(int LLLCDMNPKFI)
	{
		return CCOJBMMKNAP.MLFAGAAJJEM().FIENAKIHNOM("").Replace("energyhinttitle", CCOJBMMKNAP.DLGLFACMHPG().LHCIIEMHGAI(17 + GDJPPKAMIFL.IGJAMEGBDBG().BFNABELHMLB(LLLCDMNPKFI)) + KBOJLHAJPCP.FIOEKALDNPB[GDJPPKAMIFL.NKJBCCNGIDP().MAPKDKPEMJI(LLLCDMNPKFI)]).Replace("nomorediamonds", LJNMIPMNOKF.EHBBFMCILPC.IDDLPADHANK(LLLCDMNPKFI).HFLPLGMJNOI.ToString() + KBOJLHAJPCP.HLGAIGGHMNF).Replace("OnBackendGetPublicProfileException", LJNMIPMNOKF.NLDDLLEKNFD().PKNBMDKLJJK(LLLCDMNPKFI).ENCCLBLHJMC.ToString() + KBOJLHAJPCP.PLFMGKIEAOP);
	}

	// Token: 0x06008FB0 RID: 36784 RVA: 0x003FAE5C File Offset: 0x003F905C
	private string JCGKPCKNAKF(int LLLCDMNPKFI)
	{
		return CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialcardhintoncopiesv2").Replace("YYY", CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(750 + GDJPPKAMIFL.EHBBFMCILPC.NDJDOAPFCLH(LLLCDMNPKFI)) + KBOJLHAJPCP.FIOEKALDNPB[GDJPPKAMIFL.EHBBFMCILPC.NDJDOAPFCLH(LLLCDMNPKFI)]).Replace("WWW", LJNMIPMNOKF.EHBBFMCILPC.KMDBNEFCPOH(LLLCDMNPKFI).HFLPLGMJNOI.ToString() + KBOJLHAJPCP.HLGAIGGHMNF).Replace("QQQ", LJNMIPMNOKF.EHBBFMCILPC.KMDBNEFCPOH(LLLCDMNPKFI).ENCCLBLHJMC.ToString() + KBOJLHAJPCP.PLFMGKIEAOP);
	}

	// Token: 0x06008FB1 RID: 36785 RVA: 0x003FAF08 File Offset: 0x003F9108
	public void RequestCustomProfile(PMEPALPCEAF BFDCEGGAMOP)
	{
		if (BFDCEGGAMOP != null && BFDCEGGAMOP.EEBMPDNLJGD.Length > 0)
		{
			CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(96);
			JSONObject dmimkkciaph = null;
			if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null && AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA)
			{
				dmimkkciaph = AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.BNMFBKNEMIF();
				DPGJIJGOCIC.NFIDPOMCNLP("SocialStatsUserPublicProfile.modified = false, RequestCustomProfile()");
				AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA = false;
			}
			JSONObject defaultOperationsJsonObject = ProfileItem2.GetDefaultOperationsJsonObject(0, true);
			defaultOperationsJsonObject.Add("cuspid", BFDCEGGAMOP.EEBMPDNLJGD);
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.socFriend.ToString(), FFPHBMFGCNN.frView.ToString(), "", false, false);
			AKLFPGMDKLA.EHBBFMCILPC.CIPCINKGILF = true;
			BackendOperationsManager.EHBBFMCILPC.RequestGetUserPublicProfile(true, dmimkkciaph, defaultOperationsJsonObject, "OnBackendRequestCustomProfileSuccess", "OnBackendRequestCustomProfileException", false);
		}
	}

	// Token: 0x06008FB2 RID: 36786 RVA: 0x003FAFF4 File Offset: 0x003F91F4
	private void JOFHJGANKHO(PMEPALPCEAF AEDICCFAKOM, bool BDFHENEFGKI)
	{
		if (!AEDICCFAKOM.GIFPFPOPEJN)
		{
			this.topMatchOngoingHiddenRandom.SetActive(false);
			this.topMatchHiddenRandom.SetActive(false);
			if (AEDICCFAKOM.AFICLHMOBFA(BDFHENEFGKI) > 0)
			{
				if (BDFHENEFGKI)
				{
					if (this.topMatchOngoingItemsParent.transform.childCount == 0)
					{
						this.topMatchOngoingItemsParent.GetComponent<GridLayoutGroup>().padding.bottom = 15;
					}
					else
					{
						this.topMatchOngoingItemsParent.GetComponent<GridLayoutGroup>().padding.bottom = 15;
					}
					this.topMatchOngoingHidden.SetActive(true);
					this.topMatchOngoingHiddenText.text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("myphiddentitle") + " " + AEDICCFAKOM.AFICLHMOBFA(BDFHENEFGKI).ToString();
				}
				else
				{
					if (this.topMatchItemsParent.transform.childCount == 0)
					{
						this.topMatchItemsParent.GetComponent<GridLayoutGroup>().padding.bottom = 15;
					}
					else
					{
						this.topMatchItemsParent.GetComponent<GridLayoutGroup>().padding.bottom = 15;
					}
					this.topMatchHidden.SetActive(true);
					this.topMatchHiddenText.text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("myphiddentitle") + " " + AEDICCFAKOM.AFICLHMOBFA(BDFHENEFGKI).ToString();
				}
			}
			else if (BDFHENEFGKI)
			{
				this.topMatchOngoingHidden.SetActive(false);
			}
			else
			{
				this.topMatchHidden.SetActive(false);
			}
			if (AEDICCFAKOM.LAKHGAPCKBC)
			{
				if (BDFHENEFGKI)
				{
					this.topMatchOngoingHidden.SetActive(false);
					return;
				}
				this.topMatchHidden.SetActive(false);
				return;
			}
		}
		else
		{
			this.topMatchOngoingHidden.SetActive(false);
			this.topMatchHidden.SetActive(false);
			if (AEDICCFAKOM.AFICLHMOBFA(BDFHENEFGKI) > 0)
			{
				if (BDFHENEFGKI)
				{
					if (this.topMatchOngoingItemsParent.transform.childCount == 0)
					{
						this.topMatchOngoingItemsParent.GetComponent<GridLayoutGroup>().padding.bottom = 15;
					}
					else
					{
						this.topMatchOngoingItemsParent.GetComponent<GridLayoutGroup>().padding.bottom = 15;
					}
					this.topMatchOngoingHiddenRandom.SetActive(true);
					this.topMatchOngoingHiddenTextRandom.text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("myphiddentitle2").Replace("XXX", AEDICCFAKOM.AFICLHMOBFA(BDFHENEFGKI).ToString() ?? "");
				}
				else
				{
					if (this.topMatchItemsParent.transform.childCount == 0)
					{
						this.topMatchItemsParent.GetComponent<GridLayoutGroup>().padding.bottom = 15;
					}
					else
					{
						this.topMatchItemsParent.GetComponent<GridLayoutGroup>().padding.bottom = 15;
					}
					this.topMatchHiddenRandom.SetActive(true);
					this.topMatchHiddenTextRandom.text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("myphiddentitle2").Replace("XXX", AEDICCFAKOM.AFICLHMOBFA(BDFHENEFGKI).ToString() ?? "");
				}
			}
			else if (BDFHENEFGKI)
			{
				this.topMatchOngoingHiddenRandom.SetActive(false);
			}
			else
			{
				this.topMatchHiddenRandom.SetActive(false);
			}
			if (AEDICCFAKOM.LAKHGAPCKBC)
			{
				if (BDFHENEFGKI)
				{
					this.topMatchOngoingHiddenRandom.SetActive(false);
					return;
				}
				this.topMatchHiddenRandom.SetActive(false);
			}
		}
	}

	// Token: 0x06008FB3 RID: 36787 RVA: 0x003FB30C File Offset: 0x003F950C
	public void OnProfileMessageClosed()
	{
		this.GKDADKEFCNL = false;
	}

	// Token: 0x06008FB4 RID: 36788 RVA: 0x003FB318 File Offset: 0x003F9518
	public void OnBreakCardClick()
	{
		if (this.BOPAAIPGBCA >= 0 && LJNMIPMNOKF.EHBBFMCILPC.KMDBNEFCPOH(this.BOPAAIPGBCA) != null && LJNMIPMNOKF.EHBBFMCILPC.KMDBNEFCPOH(this.BOPAAIPGBCA).ENCCLBLHJMC > 0)
		{
			int bopaaipgbca = this.BOPAAIPGBCA;
			string dpjinbcgngn = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cardbreakconfirmationbody").Replace("XXX", "<b>" + KDCJJBLGCBH.EHBBFMCILPC.KLLNHFMMBLL(LJNMIPMNOKF.EHBBFMCILPC.KMDBNEFCPOH(this.BOPAAIPGBCA).IPICGONHLAM).ToString() + "</b>");
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("areyousure"), dpjinbcgngn, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialcollectedcardbreakv2"), new UnityAction(this.OnCardBreakPositive), new UnityAction(this.OnGenericDoNothing), DFGILFBGPLN.popupEnergyHint, 0.15f, 28);
		}
	}

	// Token: 0x06008FB5 RID: 36789 RVA: 0x003FB403 File Offset: 0x003F9603
	public void OpenCustomProfileFromFriends(PMEPALPCEAF BFDCEGGAMOP)
	{
		this.BMMEPHKOLAO = 1;
		this.RequestCustomProfile(BFDCEGGAMOP);
	}

	// Token: 0x06008FB6 RID: 36790 RVA: 0x003FB413 File Offset: 0x003F9613
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

	// Token: 0x06008FB7 RID: 36791 RVA: 0x003FB440 File Offset: 0x003F9640
	public void Like()
	{
		if (this.IJPMLEKMGMA.GIFPFPOPEJN && this.IJPMLEKMGMA.LMFCFHMJIFN.Length > 0)
		{
			this.IJPMLEKMGMA.MCMIMNEJJHK++;
			AKLFPGMDKLA.EHBBFMCILPC.MLEBKAIHGIO = this.IJPMLEKMGMA.LMFCFHMJIFN;
			this.avatarHeader.likesText.text = (this.IJPMLEKMGMA.MCMIMNEJJHK.ToString() ?? "");
			this.avatarHeader.likeButton.gameObject.SetActive(false);
			this.avatarHeader.alreadyLikedButton.gameObject.SetActive(true);
		}
	}

	// Token: 0x06008FB8 RID: 36792 RVA: 0x003FB4ED File Offset: 0x003F96ED
	private void CMDIKMNEGEN()
	{
		this.NPMNDNEDBGC = 0;
	}

	// Token: 0x06008FB9 RID: 36793 RVA: 0x003FB4F8 File Offset: 0x003F96F8
	public void OnCardClickFromMyProfile(int LLLCDMNPKFI)
	{
		this.BOPAAIPGBCA = LLLCDMNPKFI;
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(31))
		{
			AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(31);
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("newtutorialcollectablecards"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("continue"), new UnityAction(this.OLODCPEPPLH), DFGILFBGPLN.popupTools, 0f, 28);
			return;
		}
		this.OLODCPEPPLH();
	}

	// Token: 0x06008FBA RID: 36794 RVA: 0x00003E52 File Offset: 0x00002052
	private void LBHCPIIOHEJ()
	{
	}

	// Token: 0x06008FBB RID: 36795 RVA: 0x00003E52 File Offset: 0x00002052
	private void PIGIPMPJOJC()
	{
	}

	// Token: 0x06008FBC RID: 36796 RVA: 0x003FB57C File Offset: 0x003F977C
	private void HFNBHGNFIGB(PMEPALPCEAF AEDICCFAKOM, GameObject BPMFHNDCBOH, GameObject NNJKKDEOBKP, bool BDFHENEFGKI = false, bool GPMMJPLHHAD = false)
	{
		ProfileItem2.FDCBCKMNMEL fdcbckmnmel = new ProfileItem2.FDCBCKMNMEL();
		fdcbckmnmel.<>4__this = this;
		fdcbckmnmel.profile = AEDICCFAKOM;
		fdcbckmnmel._isOngoing = BDFHENEFGKI;
		if (GPMMJPLHHAD)
		{
			if (!fdcbckmnmel.profile.GIFPFPOPEJN)
			{
				for (int i = 0; i < NNJKKDEOBKP.transform.childCount; i++)
				{
					Transform child = NNJKKDEOBKP.transform.GetChild(i);
					if (!child.gameObject.activeSelf)
					{
						child.gameObject.SetActive(true);
						child.GetComponent<ContentTopMatchItem>().ResetOnUnhide();
					}
				}
			}
		}
		else
		{
			if (fdcbckmnmel._isOngoing)
			{
				this.KJFPPIKKFEN.Clear();
			}
			else
			{
				this.CMCDBMPPHID.Clear();
			}
			while (NNJKKDEOBKP.transform.childCount > 0)
			{
				UnityEngine.Object.DestroyImmediate(NNJKKDEOBKP.transform.GetChild(0).gameObject);
			}
		}
		BPMFHNDCBOH.SetActive(false);
		NNJKKDEOBKP.SetActive(false);
		List<IMMKFHKEEBF> list = new List<IMMKFHKEEBF>();
		if (fdcbckmnmel._isOngoing)
		{
			list = fdcbckmnmel.profile.CLFAOIPBLCA();
		}
		else
		{
			list = fdcbckmnmel.profile.ALBFAIPPLLA();
		}
		if (list.Count != 0)
		{
			Vector2 onkonhljkpg = this.CalculateViewportUpDownMargins(this.mainScrollView);
			BPMFHNDCBOH.SetActive(true);
			NNJKKDEOBKP.SetActive(true);
			if (!fdcbckmnmel.profile.MJANECGKMGF(fdcbckmnmel._isOngoing) && fdcbckmnmel.profile.GIFPFPOPEJN)
			{
				BPMFHNDCBOH.SetActive(false);
				NNJKKDEOBKP.SetActive(false);
			}
			int num = 0;
			for (int j = 0; j < list.Count; j++)
			{
				ProfileItem2.GKHMJOAFKPB gkhmjoafkpb = new ProfileItem2.GKHMJOAFKPB();
				gkhmjoafkpb.CS$<>8__locals1 = fdcbckmnmel;
				gkhmjoafkpb.myProfileTopMatchEntry = list[j];
				if (!gkhmjoafkpb.CS$<>8__locals1.profile.OHKBNAJEJGD(gkhmjoafkpb.myProfileTopMatchEntry, gkhmjoafkpb.CS$<>8__locals1._isOngoing))
				{
					ProfileItem2.IEBPEDEFJMI iebpedefjmi = new ProfileItem2.IEBPEDEFJMI();
					iebpedefjmi.CS$<>8__locals2 = gkhmjoafkpb;
					if (GPMMJPLHHAD)
					{
						if (iebpedefjmi.CS$<>8__locals2.CS$<>8__locals1._isOngoing)
						{
							if (this.KJFPPIKKFEN.Contains(iebpedefjmi.CS$<>8__locals2.myProfileTopMatchEntry.DKDECIHBGJE()))
							{
								num++;
								goto IL_344;
							}
						}
						else if (this.CMCDBMPPHID.Contains(iebpedefjmi.CS$<>8__locals2.myProfileTopMatchEntry.DKDECIHBGJE()))
						{
							num++;
							goto IL_344;
						}
					}
					iebpedefjmi.item = UnityEngine.Object.Instantiate<GameObject>(this.topMatchItem, NNJKKDEOBKP.transform);
					iebpedefjmi.item.GetComponent<ContentTopMatchItem>().SetContent(iebpedefjmi.CS$<>8__locals2.myProfileTopMatchEntry, onkonhljkpg, iebpedefjmi.CS$<>8__locals2.CS$<>8__locals1.profile, new UnityAction(iebpedefjmi.DMBLINEEPHL), new UnityAction(iebpedefjmi.CS$<>8__locals2.PHGPLGABBNL));
					if (iebpedefjmi.CS$<>8__locals2.CS$<>8__locals1._isOngoing)
					{
						this.KJFPPIKKFEN.Add(iebpedefjmi.CS$<>8__locals2.myProfileTopMatchEntry.DKDECIHBGJE());
					}
					else
					{
						this.CMCDBMPPHID.Add(iebpedefjmi.CS$<>8__locals2.myProfileTopMatchEntry.DKDECIHBGJE());
					}
					if (!iebpedefjmi.CS$<>8__locals2.CS$<>8__locals1.profile.GIFPFPOPEJN)
					{
						Button hide = iebpedefjmi.item.GetComponent<ContentTopMatchItem>().hide;
						hide.onClick.AddListener(new UnityAction(iebpedefjmi.CS$<>8__locals2.ONMENIEKHJN));
						hide.onClick.AddListener(new UnityAction(iebpedefjmi.EMLHKOOFAOI));
						if (GPMMJPLHHAD)
						{
							iebpedefjmi.item.transform.SetSiblingIndex(num);
							num++;
						}
					}
				}
				IL_344:;
			}
			if (!fdcbckmnmel.profile.GIFPFPOPEJN && GPMMJPLHHAD)
			{
				this.GJFOKPKABCB(NNJKKDEOBKP.transform);
			}
			this.JOFHJGANKHO(fdcbckmnmel.profile, fdcbckmnmel._isOngoing);
			LayoutRebuilder.ForceRebuildLayoutImmediate(NNJKKDEOBKP.GetComponent<RectTransform>());
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentMainTransform.GetComponent<RectTransform>());
			return;
		}
		if (!fdcbckmnmel.profile.GIFPFPOPEJN)
		{
			this.topMatchOngoingHiddenRandom.SetActive(false);
			this.topMatchHiddenRandom.SetActive(false);
			if (fdcbckmnmel._isOngoing)
			{
				this.topMatchOngoingHidden.SetActive(false);
			}
			else
			{
				this.topMatchHidden.SetActive(false);
			}
		}
		else
		{
			this.topMatchOngoingHidden.SetActive(false);
			this.topMatchHidden.SetActive(false);
			if (fdcbckmnmel._isOngoing)
			{
				this.topMatchOngoingHiddenRandom.SetActive(false);
			}
			else
			{
				this.topMatchHiddenRandom.SetActive(false);
			}
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(NNJKKDEOBKP.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentMainTransform.GetComponent<RectTransform>());
	}

	// Token: 0x06008FBD RID: 36797 RVA: 0x003FB9CB File Offset: 0x003F9BCB
	private void PJPDBBFDCFD()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		this.PEDAMIKCMKH = null;
		this.PKOEGOPHOIH = false;
	}

	// Token: 0x06008FBE RID: 36798 RVA: 0x003FB9E8 File Offset: 0x003F9BE8
	public void OnAddFriendByUID()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.GNLNPMPJPEC())
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialprivatenofriendsadd"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
			return;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.LAKHGAPCKBC)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialprofilesuspcantuse"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
			return;
		}
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(29))
		{
			AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(29);
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("newtutorialfriends"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("continue"), new UnityAction(this.HOFMFHELJBE), DFGILFBGPLN.popupTools, 0f, 28);
			return;
		}
		this.HOFMFHELJBE();
	}

	// Token: 0x06008FBF RID: 36799 RVA: 0x003FBB04 File Offset: 0x003F9D04
	private void DAEHGLPOIBD()
	{
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(35))
		{
			AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(35);
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("newtutorialaddtorading"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("continue"), new UnityAction(this.AHPEJPFBHAI), DFGILFBGPLN.popupTools, 0.15f, 28);
			return;
		}
		this.AHPEJPFBHAI();
	}

	// Token: 0x06008FC0 RID: 36800 RVA: 0x003FBB7F File Offset: 0x003F9D7F
	private void MGJODPCIHAE()
	{
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnLobbyStartFireworksEffectAutoHide", 0f);
	}

	// Token: 0x06008FC1 RID: 36801 RVA: 0x003FBB98 File Offset: 0x003F9D98
	private void CLMMOBKOJKO()
	{
		string text = DPGJIJGOCIC.HIPPBJFMIKM(AOBJLALDBAA.EHBBFMCILPC.CLCKLHEDEBJ());
		if (text != null && text.Length > 1)
		{
			if (text.Length > 199)
			{
				text = text.Substring(1, -30);
				text += "sckv2";
			}
			this.IJPMLEKMGMA.FPJMDDIILIK = text;
		}
		else
		{
			this.IJPMLEKMGMA.FPJMDDIILIK = "OnPurchasingViewLeave";
		}
		this.UpdateLoveText(true);
	}

	// Token: 0x06008FC2 RID: 36802 RVA: 0x00003E52 File Offset: 0x00002052
	private void NBJPCDIJOCH()
	{
	}

	// Token: 0x06008FC3 RID: 36803 RVA: 0x003FBC0C File Offset: 0x003F9E0C
	private void OPOBHBCMLLK()
	{
		AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.JNNBNNDOGIM.NCGOKNFIPKN(this.LEJIJOAOEBK);
		this.MHKKGOCMIJI.GetComponent<ContentFriendItem>().UpdateContent(false);
		this.contentFriendsPage.SetSiblingIndexInSortedFriendsList(this.IJPMLEKMGMA, this.LEJIJOAOEBK, this.MHKKGOCMIJI);
		AKLFPGMDKLA.EHBBFMCILPC.CIPCINKGILF = true;
		this.LEJIJOAOEBK = null;
		this.MHKKGOCMIJI = null;
	}

	// Token: 0x06008FC4 RID: 36804 RVA: 0x003FBC7C File Offset: 0x003F9E7C
	private void MEMHMNODKIG(PMEPALPCEAF FOKFGMIEEDB)
	{
		foreach (object obj in this.favoriteCutscenes.transform)
		{
			((Transform)obj).gameObject.SetActive(false);
		}
		if (FOKFGMIEEDB.ACMJMCLJPKC().Count != 0)
		{
			this.titleFavoriteCutscenes.SetActive(true);
			this.favoriteCutscenes.SetActive(true);
			this.noFavoriteCutscenes.SetActive(false);
			List<string> list = FOKFGMIEEDB.IJDGJJCKHAH();
			List<string> list2 = FOKFGMIEEDB.ACMJMCLJPKC();
			for (int i = 0; i < list.Count; i++)
			{
				if (i < this.favoriteCutscenes.transform.childCount)
				{
					ProfileItem2.BJLGILLKIEG bjlgillkieg = new ProfileItem2.BJLGILLKIEG();
					bjlgillkieg.<>4__this = this;
					bjlgillkieg.uniqueId = list[i];
					string pgkcdnkemoe = "";
					if (i < list2.Count)
					{
						pgkcdnkemoe = list2[i];
					}
					bjlgillkieg.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.CJEEKHDPLLI(pgkcdnkemoe);
					Transform child = this.favoriteCutscenes.transform.GetChild(i);
					child.gameObject.SetActive(true);
					child.GetComponent<ContentFavoriteItem>().imageThumb.sprite = bjlgillkieg.sprite;
					bjlgillkieg.cutscene = this.IJPMLEKMGMA.IPILOAEGBMD().Find(new Predicate<BNFCLKNDBLO>(bjlgillkieg.HAPDOCGFHNK));
					child.GetComponent<Button>();
					child.GetComponent<Button>().onClick.RemoveAllListeners();
					if (!this.IJPMLEKMGMA.GIFPFPOPEJN)
					{
						child.GetComponent<Button>().onClick.AddListener(new UnityAction(bjlgillkieg.DPOILBPHLJM));
					}
					else
					{
						child.GetComponent<Button>().onClick.AddListener(new UnityAction(bjlgillkieg.GFJGAFCKLBP));
					}
				}
			}
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.favoriteCutscenes.GetComponent<RectTransform>());
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentMainTransform.GetComponent<RectTransform>());
			return;
		}
		if (FOKFGMIEEDB.GIFPFPOPEJN)
		{
			this.titleFavoriteCutscenes.SetActive(false);
			this.noFavoriteCutscenes.SetActive(false);
			this.favoriteCutscenes.SetActive(false);
			return;
		}
		this.titleFavoriteCutscenes.SetActive(true);
		this.noFavoriteCutscenes.SetActive(true);
		this.favoriteCutscenes.SetActive(false);
	}

	// Token: 0x06008FC5 RID: 36805 RVA: 0x003FBED8 File Offset: 0x003FA0D8
	private void FOOEEAKCONK()
	{
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtonsAndCloseOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialbtngiftprem"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("newuseraddrequest3"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("newuseraddrequest1"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("newuseraddrequest2"), new UnityAction(this.NFBDHMFOGPH), new UnityAction(this.AEBPHGJGDFA), new UnityAction(this.EGBJEEJMCFB), DFGILFBGPLN.popupQuitConfirm, 0f, 28);
	}

	// Token: 0x06008FC6 RID: 36806 RVA: 0x003FBF5C File Offset: 0x003FA15C
	public void ExecuteCardUpgradeBackendRequest()
	{
		if (this.LEBIMELAHBC)
		{
			this.LEBIMELAHBC = false;
			int bopaaipgbca = this.BOPAAIPGBCA;
			int lmcedchdiib = GDJPPKAMIFL.EHBBFMCILPC.NDJDOAPFCLH(bopaaipgbca);
			if (AKLFPGMDKLA.EHBBFMCILPC.PNAICOHCMAK(lmcedchdiib))
			{
				CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(32);
				BackendOperationsManager.EHBBFMCILPC.RequestUpgradeToGiftCard("OnBackendUpgradeToGiftCardSuccess", "OnBackendUpgradeToGiftCardException", bopaaipgbca);
				return;
			}
		}
		else
		{
			this.JNCCHOJOBJB();
			this.GNBGLOAMALH();
		}
	}

	// Token: 0x06008FC7 RID: 36807 RVA: 0x003FBFC6 File Offset: 0x003FA1C6
	private IEnumerator LHNMEHHAPAO(RectTransform DGAAFGDHHHJ)
	{
		yield return new WaitForEndOfFrame();
		LayoutRebuilder.ForceRebuildLayoutImmediate(DGAAFGDHHHJ);
		yield break;
	}

	// Token: 0x06008FC8 RID: 36808 RVA: 0x003FBFD5 File Offset: 0x003FA1D5
	private void EPFKNCBELMK()
	{
		CommonUserInterface.EHBBFMCILPC.ShowPopupProfileUIDInput(0);
	}

	// Token: 0x06008FC9 RID: 36809 RVA: 0x003FBFE4 File Offset: 0x003FA1E4
	public void OnBackendGetPublicProfileProfileItemSuccess()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		if (this.NEDAFKKJGGK && AKLFPGMDKLA.EHBBFMCILPC.CLDBILNPMCN != null)
		{
			try
			{
				if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null && AKLFPGMDKLA.EHBBFMCILPC.CLDBILNPMCN != null)
				{
					AKLFPGMDKLA.EHBBFMCILPC.CLDBILNPMCN.ACCOJOHJPGH(AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC);
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
			this.UpdateContent(AKLFPGMDKLA.EHBBFMCILPC.CLDBILNPMCN, AMMHDNONFHM.RandomProfile);
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.socActiv.ToString(), FFPHBMFGCNN.socShuffle.ToString(), "", false, false);
		}
		else if (!this.NEDAFKKJGGK && AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null)
		{
			this.UpdateContent(AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC, AMMHDNONFHM.MyProfile);
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("ProfileItem.OnBackendGetPublicProfileProfileItemSuccess() - both profiles are null!");
		}
		this.contentHallOfFamePage.gameObject.SetActive(false);
		this.contentFriendsPage.gameObject.SetActive(false);
		base.GetComponent<RectTransform>().localScale = new Vector3(1.05f, 1.05f, 1.05f);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnNeedToRestartProfileItemAnimation", 0f);
		this.NEDAFKKJGGK = false;
		this.mainScrollView.GetComponent<ScrollRect>().verticalNormalizedPosition = 1f;
	}

	// Token: 0x06008FCA RID: 36810 RVA: 0x003FC144 File Offset: 0x003FA344
	private void AHPEJPFBHAI()
	{
		int bopaaipgbca = this.BOPAAIPGBCA;
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("areyousure"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialwouldyouliketotradecard"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("no"), new UnityAction(this.NCHJKBNNHMB), new UnityAction(this.OAJLLPMMOKI), DFGILFBGPLN.popupQuitConfirm, 0.15f, 28);
	}

	// Token: 0x06008FCB RID: 36811 RVA: 0x003FC1C0 File Offset: 0x003FA3C0
	private void BLFFOEGNAMJ()
	{
		if (this.LEJIJOAOEBK != null && this.LEJIJOAOEBK.EEBMPDNLJGD.Length > 0)
		{
			string text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialrequestsharegbody");
			string str;
			if (this.LEJIJOAOEBK.KNCFKDLOPGA.Length == 0)
			{
				str = "<" + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("profilenametitleshort") + ">";
			}
			else
			{
				str = this.LEJIJOAOEBK.KNCFKDLOPGA;
			}
			text = text.Replace("XXX", "<i>" + str + "</i>");
			text = text.Replace("YYY", KDCJJBLGCBH.EHBBFMCILPC.MNPDCPDPICO(AKLFPGMDKLA.EHBBFMCILPC.AFKCCPIMDJH()).ToString() + KBOJLHAJPCP.BGMADCKNKAD);
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("areyousure"), text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("no"), new UnityAction(this.PDBFJOMMIJP), new UnityAction(this.EPNKEMJEOHP), DFGILFBGPLN.popupQuitConfirm, 0f, 28);
		}
	}

	// Token: 0x06008FCC RID: 36812 RVA: 0x003FC2EC File Offset: 0x003FA4EC
	public void FadeOut(GameObject PHLJNFHEEIB)
	{
		ProfileItem2.PIKEJAKFJCF pikejakfjcf = new ProfileItem2.PIKEJAKFJCF();
		pikejakfjcf._gameObject = PHLJNFHEEIB;
		if (pikejakfjcf._gameObject.name == this.contentAvatarPage.gameObject.name || pikejakfjcf._gameObject.name == this.contentCharactersPage.name || pikejakfjcf._gameObject.name == this.contentStoriesPage.name || pikejakfjcf._gameObject.name == this.contentCutscenesPage.name || pikejakfjcf._gameObject.name == this.contentWishedCardsPage.name)
		{
			this.KEFGAJBOJPF(this.IJPMLEKMGMA);
		}
		if (pikejakfjcf._gameObject.name == this.contentFriendsPage.name && this.activePageType == AMMHDNONFHM.MyProfile)
		{
			int num = this.IJPMLEKMGMA.JNNBNNDOGIM.GLPOGLBGKIF();
			if (num == 0)
			{
				this.KDNPGGPJFPC(this.IJPMLEKMGMA);
			}
			else
			{
				this.friendsEventsCountText.text = num.ToString();
			}
		}
		pikejakfjcf._gameObject.GetComponent<CanvasGroup>().DOFade(this.AODLOLBDFDB, this.AKCEKJFIGJH).SetEase(this.HNJCFFHCDCC).OnComplete(new TweenCallback(pikejakfjcf.NIILMOHFHNL));
		pikejakfjcf._gameObject.GetComponent<CanvasGroup>().interactable = false;
		pikejakfjcf._gameObject.GetComponent<CanvasGroup>().blocksRaycasts = false;
		this.SetCloseButtonByPageType();
	}

	// Token: 0x06008FCD RID: 36813 RVA: 0x00003E52 File Offset: 0x00002052
	private void NFOGAJKHADD()
	{
	}

	// Token: 0x06008FCE RID: 36814 RVA: 0x003FC464 File Offset: 0x003FA664
	private void FBEEAPGBKBL()
	{
		this.LEBIMELAHBC = false;
		int bopaaipgbca = this.BOPAAIPGBCA;
		string text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialcreategiftcardbutton");
		string text2;
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(38))
		{
			AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(38);
			text2 = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialcreategiftcardbody");
		}
		else
		{
			text2 = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialcreategiftcardbodysmall");
		}
		int num = GDJPPKAMIFL.EHBBFMCILPC.BBJPJDLNEPA(bopaaipgbca);
		int num2 = GDJPPKAMIFL.EHBBFMCILPC.LPPCDGGOLEN(bopaaipgbca);
		if (num > 0)
		{
			text2 = text2.Replace("XXX", KBOJLHAJPCP.BGMADCKNKAD + num.ToString());
		}
		else
		{
			text2 = text2.Replace("XXX", KBOJLHAJPCP.APPEMCMGFJI + num2.ToString());
		}
		text = text.Replace("XXX", this.GetCardUpgradeLocalizedCostData());
		int lmcedchdiib = GDJPPKAMIFL.EHBBFMCILPC.NDJDOAPFCLH(bopaaipgbca);
		if (AKLFPGMDKLA.EHBBFMCILPC.PNAICOHCMAK(lmcedchdiib))
		{
			text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialcreategiftcardbuttonv2");
		}
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialcreategiftcardtitle"), text2, text, new UnityAction(this.LALGACIHKOC), new UnityAction(this.GPCAMDKPLPM), DFGILFBGPLN.popupQuitConfirm, 0.15f, 28);
	}

	// Token: 0x06008FCF RID: 36815 RVA: 0x00003E52 File Offset: 0x00002052
	private void JIGJBOGFKAF()
	{
	}

	// Token: 0x06008FD0 RID: 36816 RVA: 0x003FC5A4 File Offset: 0x003FA7A4
	public void OnBadgeClick(string HCLOBPBEIHL)
	{
		this.JLPOBLKCIEL = HCLOBPBEIHL;
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(27))
		{
			AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(27);
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("newtutorialbadges"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("continue"), new UnityAction(this.OnBadgeClick2), DFGILFBGPLN.popupTools, 0f, 28);
			return;
		}
		this.OnBadgeClick2();
	}

	// Token: 0x06008FD1 RID: 36817 RVA: 0x003FC628 File Offset: 0x003FA828
	private void FEEHPCDHKOO()
	{
		AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.JNNBNNDOGIM.MGHBGJFFONA(this.LEJIJOAOEBK);
		this.MHKKGOCMIJI.GetComponent<ContentFriendItem>().UpdateContent(true);
		this.contentFriendsPage.SetSiblingIndexInSortedFriendsList(this.IJPMLEKMGMA, this.LEJIJOAOEBK, this.MHKKGOCMIJI);
		AKLFPGMDKLA.EHBBFMCILPC.CIPCINKGILF = true;
		AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA = true;
		this.LEJIJOAOEBK = null;
		this.MHKKGOCMIJI = null;
	}

	// Token: 0x06008FD2 RID: 36818 RVA: 0x003FC6A8 File Offset: 0x003FA8A8
	private void NKIGKELPFOP()
	{
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtonsAndCloseOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("newuseraddrequest0"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("newuseraddrequest3"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("newuseraddrequest1"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("newuseraddrequest2"), new UnityAction(this.EPFKNCBELMK), new UnityAction(this.NHPIIKKJILL), new UnityAction(this.LBHCPIIOHEJ), DFGILFBGPLN.popupQuitConfirm, 0f, 28);
	}

	// Token: 0x06008FD3 RID: 36819 RVA: 0x003FC72C File Offset: 0x003FA92C
	public void OnTradingCardClickFromMyProfile(int LLLCDMNPKFI)
	{
		this.BOPAAIPGBCA = LLLCDMNPKFI;
		string str = "<align=\"center\"><alpha=#88>" + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialcardvolinfonotev2").Replace("XXX", GDJPPKAMIFL.EHBBFMCILPC.DKHIPEPOEFF(LLLCDMNPKFI) ?? "").Replace("YYY", "<i>" + GKJPOGNFKNK.DNILNCLIHAP(LLLCDMNPKFI, "cardschar", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()) + "</i>").Replace("ZZZ", "<i>" + GKJPOGNFKNK.DNILNCLIHAP("anthology" + LJNMIPMNOKF.EHBBFMCILPC.KMDBNEFCPOH(LLLCDMNPKFI).AMKCLHLIIMN.ToString(), "anthologiestitle", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()) + "</i>") + "<alpha=#FF><align=\"left\">";
		if (this.IJPMLEKMGMA.GIFPFPOPEJN && !this.IJPMLEKMGMA.EEBMPDNLJGD.Equals(AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.EEBMPDNLJGD))
		{
			string eempglhpkjg = GDJPPKAMIFL.EHBBFMCILPC.KCMKJBHBCGC(LLLCDMNPKFI);
			string str2;
			if (this.IJPMLEKMGMA.KNCFKDLOPGA.Length == 0)
			{
				str2 = "<" + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("profilenametitleshort") + ">";
			}
			else
			{
				str2 = this.IJPMLEKMGMA.KNCFKDLOPGA;
			}
			if (AKLFPGMDKLA.EHBBFMCILPC.NDINEHGFPNN(this.IJPMLEKMGMA).Contains(LLLCDMNPKFI))
			{
				if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.JNNBNNDOGIM.BCPOHPEJLGB(this.IJPMLEKMGMA))
				{
					CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(eempglhpkjg, str + "\n\n" + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ontradingcardclickbodymatch").Replace("XXX", "<i>" + str2 + "</i>"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("tradewishcardoption2"), new UnityAction(this.JEJKDFHFKIC), new UnityAction(this.GJNDBHEOMHD), DFGILFBGPLN.popupEnergyHint, 0f, 28);
					return;
				}
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(eempglhpkjg, str + "\n\n" + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ontradingcardclickbodymatch").Replace("XXX", "<i>" + str2 + "</i>"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("tradewishcardoption0"), new UnityAction(this.DMELLKDBPHP), new UnityAction(this.GJNDBHEOMHD), DFGILFBGPLN.popupEnergyHint, 0f, 28);
				return;
			}
			else
			{
				if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.JNNBNNDOGIM.BCPOHPEJLGB(this.IJPMLEKMGMA))
				{
					CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(eempglhpkjg, str + "\n\n" + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ontradingcardclickbody").Replace("XXX", "<i>" + str2 + "</i>"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("tradewishcardoption2"), new UnityAction(this.JEJKDFHFKIC), new UnityAction(this.GJNDBHEOMHD), DFGILFBGPLN.popupEnergyHint, 0f, 28);
					return;
				}
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(eempglhpkjg, str + "\n\n" + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ontradingcardclickbody").Replace("XXX", "<i>" + str2 + "</i>"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("tradewishcardoption0"), new UnityAction(this.DMELLKDBPHP), new UnityAction(this.GJNDBHEOMHD), DFGILFBGPLN.popupEnergyHint, 0f, 28);
				return;
			}
		}
		else
		{
			string eempglhpkjg2 = GDJPPKAMIFL.EHBBFMCILPC.KCMKJBHBCGC(LLLCDMNPKFI);
			if (!this.IJPMLEKMGMA.GIFPFPOPEJN)
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(eempglhpkjg2, str + "\n\n" + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ontradingcardclickbodyplayer"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialremovetradeable"), new UnityAction(this.CJKFKPMDEFD), new UnityAction(this.OnGenericDoNothing), DFGILFBGPLN.popupEnergyHint, 0f, 28);
				return;
			}
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(eempglhpkjg2, str + "\n\n" + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ontradingcardclickbodyplayer"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
			return;
		}
	}

	// Token: 0x06008FD4 RID: 36820 RVA: 0x003FCB48 File Offset: 0x003FAD48
	public void OnSpecialCurrencyClick2()
	{
		int pgbncmdddbl = this.PGBNCMDDDBL;
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("specialcurrencytitle" + pgbncmdddbl.ToString()), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("specialcurrencydesc" + pgbncmdddbl.ToString()), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
	}

	// Token: 0x06008FD5 RID: 36821 RVA: 0x003FCBB5 File Offset: 0x003FADB5
	private void IIMNPHNGDCI()
	{
		this.GKBMOLFNBOH = this.BOPAAIPGBCA;
		if (LJNMIPMNOKF.EHBBFMCILPC.COCEMBDEKIP() != GCFLILHCOEI.cardsFilterNone)
		{
			LJNMIPMNOKF.EHBBFMCILPC.KNAEAJPDGKB(GCFLILHCOEI.cardsFilterNone, -1, -1);
		}
		LJNMIPMNOKF.EHBBFMCILPC.AMCFJAMHKHN(this.GKBMOLFNBOH);
		this.OnSendGiftByProfileId();
	}

	// Token: 0x06008FD6 RID: 36822 RVA: 0x003FCBF4 File Offset: 0x003FADF4
	private void ICENGKAIDMP(Transform GCDFHHCDCIB)
	{
		foreach (object obj in this.topMatchOngoingItemsParent.transform)
		{
			Transform transform = (Transform)obj;
			if (transform != GCDFHHCDCIB)
			{
				transform.GetComponent<ContentTopMatchItem>().UpdateHideState();
			}
		}
		foreach (object obj2 in this.topMatchItemsParent.transform)
		{
			Transform transform2 = (Transform)obj2;
			if (transform2 != GCDFHHCDCIB)
			{
				transform2.GetComponent<ContentTopMatchItem>().UpdateHideState();
			}
		}
	}

	// Token: 0x06008FD7 RID: 36823 RVA: 0x003FCCBC File Offset: 0x003FAEBC
	public void ShowFriendOptions(PMEPALPCEAF BFDCEGGAMOP, GameObject DBCLCBLGBED)
	{
		this.LEJIJOAOEBK = BFDCEGGAMOP;
		this.MHKKGOCMIJI = DBCLCBLGBED;
		if (!AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.JNNBNNDOGIM.BCPOHPEJLGB(BFDCEGGAMOP) || AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.JNNBNNDOGIM.GOLABDHOFOD(BFDCEGGAMOP))
		{
			LobbyUserInterface.EHBBFMCILPC.ShowFriendsPopup(BFDCEGGAMOP, true, true, false, false, false, false, false, false, false);
			return;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.JNNBNNDOGIM.FNDNDILCFNN(BFDCEGGAMOP))
		{
			LobbyUserInterface.EHBBFMCILPC.ShowFriendsPopup(BFDCEGGAMOP, false, false, true, true, false, true, true, true, true);
			return;
		}
		LobbyUserInterface.EHBBFMCILPC.ShowFriendsPopup(BFDCEGGAMOP, false, false, true, true, true, false, true, true, true);
	}

	// Token: 0x06008FD8 RID: 36824 RVA: 0x003FCD5C File Offset: 0x003FAF5C
	private void NDPEFOGALEC()
	{
		if (this.PNPEHMLHDPO != null && this.PNPEHMLHDPO.EEBMPDNLJGD.Length > 0)
		{
			CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(96);
			JSONObject dmimkkciaph = null;
			if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null && AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA)
			{
				dmimkkciaph = AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.BNMFBKNEMIF();
				DPGJIJGOCIC.NFIDPOMCNLP("SocialStatsUserPublicProfile.modified = false, OnFriendsCurrencyPopupCollect()");
				AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA = false;
			}
			JSONObject defaultOperationsJsonObject = ProfileItem2.GetDefaultOperationsJsonObject(0, true);
			defaultOperationsJsonObject.Add("frcgft", this.PNPEHMLHDPO.EEBMPDNLJGD);
			defaultOperationsJsonObject.Add("frcgftsuid", this.PNPEHMLHDPO.MIOEBKPPEHO);
			AKLFPGMDKLA.EHBBFMCILPC.CIPCINKGILF = true;
			BackendOperationsManager.EHBBFMCILPC.QueueBasicSync();
			BackendOperationsManager.EHBBFMCILPC.RequestGetUserPublicProfile(false, dmimkkciaph, defaultOperationsJsonObject, "OnBackendRequestCollectGiftSuccess", "OnBackendRequestCollectGiftException", false);
		}
	}

	// Token: 0x06008FD9 RID: 36825 RVA: 0x003FCE4C File Offset: 0x003FB04C
	private void BICBOMKBJAE(string HAPADEOFKBP)
	{
		try
		{
			int num = int.Parse(DPGJIJGOCIC.NLGJAJDKIGH(HAPADEOFKBP));
			string dpjinbcgngn = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("randomprofclickanth").Replace("XXX", "<i>" + GKJPOGNFKNK.DNILNCLIHAP("anthology" + num.ToString(), "anthologiestitle", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()) + "</i>");
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), dpjinbcgngn, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06008FDA RID: 36826 RVA: 0x003FCF00 File Offset: 0x003FB100
	private void IKFCJJIMBIJ()
	{
		string text = DPGJIJGOCIC.HIPPBJFMIKM(AOBJLALDBAA.EHBBFMCILPC.KNCFLCKKPLK());
		if (text != null && text.Length > 0)
		{
			ContentCusceneSmallItem component = this.OEEDMOKBDNC.GetComponent<ContentCusceneSmallItem>();
			this.IJPMLEKMGMA.GFFMGEEMKBP(component.BMCOOGNFAEJ.IAGMLHAEOJI, text);
			component.RenameCutscene();
		}
	}

	// Token: 0x06008FDB RID: 36827 RVA: 0x003FCF54 File Offset: 0x003FB154
	public void ConsumeIncomingFriendLetters()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.JNNBNNDOGIM.EOCDHHBEKMF() > 0)
		{
			this.PFFIIOHPJCA = base.StartCoroutine(this.JMNBFBCLKLH());
			return;
		}
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(29))
		{
			AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(29);
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("newtutorialfriends"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("continue"), DFGILFBGPLN.popupTools, 0f, 28);
		}
	}

	// Token: 0x06008FDC RID: 36828 RVA: 0x003FCFE8 File Offset: 0x003FB1E8
	private void GLEMNIJOPCE()
	{
		int bopaaipgbca = this.BOPAAIPGBCA;
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialtradegiftcardmissingtitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialtradegiftcardmissingbody"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("no"), new UnityAction(this.NFNBFHKBACB), new UnityAction(this.KPGDEGJGIMB), DFGILFBGPLN.popupQuitConfirm, 0.15f, 28);
	}

	// Token: 0x06008FDD RID: 36829 RVA: 0x003FD064 File Offset: 0x003FB264
	private void GJFOKPKABCB(Transform PCNJLOJEAJI)
	{
		int num = 0;
		for (int i = 0; i < PCNJLOJEAJI.childCount; i++)
		{
			Transform child = PCNJLOJEAJI.GetChild(i);
			if (child.gameObject.activeSelf)
			{
				child.GetComponent<ContentTopMatchItem>().ResetIndexOrder(num);
				num++;
			}
		}
	}

	// Token: 0x06008FDE RID: 36830 RVA: 0x003FD0AC File Offset: 0x003FB2AC
	private void HOALPJPEOGP()
	{
		string text = DPGJIJGOCIC.HIPPBJFMIKM(AOBJLALDBAA.EHBBFMCILPC.KNCFLCKKPLK());
		if (text != null && text.Length > 0)
		{
			if (text.Length > 256)
			{
				text = text.Substring(0, 256);
				text += "...";
			}
			this.IJPMLEKMGMA.PEONEPNPGEC = text;
		}
		else
		{
			this.IJPMLEKMGMA.PEONEPNPGEC = "";
		}
		this.UpdateCredoText(true);
	}

	// Token: 0x06008FDF RID: 36831 RVA: 0x003FD120 File Offset: 0x003FB320
	private void EGJDPHGJJNL()
	{
		this.OnNeedToCheckForEmptyFriendsPage();
	}

	// Token: 0x06008FE0 RID: 36832 RVA: 0x003FD128 File Offset: 0x003FB328
	private void AJCIPPBNMIG(GameObject IACFDHCDEME, PMEPALPCEAF AEDICCFAKOM, bool BDFHENEFGKI = false)
	{
		IACFDHCDEME.SetActive(false);
		this.JOFHJGANKHO(AEDICCFAKOM, BDFHENEFGKI);
		if (BDFHENEFGKI)
		{
			this.GJFOKPKABCB(this.topMatchOngoingItemsParent.transform);
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.topMatchOngoingItemsParent.GetComponent<RectTransform>());
		}
		else
		{
			this.GJFOKPKABCB(this.topMatchItemsParent.transform);
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.topMatchItemsParent.GetComponent<RectTransform>());
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentMainTransform.GetComponent<RectTransform>());
	}

	// Token: 0x06008FE1 RID: 36833 RVA: 0x003FD19C File Offset: 0x003FB39C
	private void FOELBHPJKFK(PMEPALPCEAF FOKFGMIEEDB)
	{
		foreach (object obj in this.favoriteChars.transform)
		{
			((Transform)obj).gameObject.SetActive(false);
		}
		if (FOKFGMIEEDB.FJHCBIPBEBG().Count != 0)
		{
			this.titleFavoriteChars.SetActive(true);
			this.favoriteChars.SetActive(true);
			this.noFavoriteChars.SetActive(false);
			for (int i = 0; i < FOKFGMIEEDB.FJHCBIPBEBG().Count; i++)
			{
				if (i < this.favoriteChars.transform.childCount)
				{
					ProfileItem2.KNHOPMKDBFD knhopmkdbfd = new ProfileItem2.KNHOPMKDBFD();
					knhopmkdbfd.<>4__this = this;
					int index = FOKFGMIEEDB.FJHCBIPBEBG().Count - 1 - i;
					knhopmkdbfd.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.HGFILJAIPEO(FOKFGMIEEDB.FJHCBIPBEBG()[index], false);
					Transform child = this.favoriteChars.transform.GetChild(i);
					child.gameObject.SetActive(true);
					child.GetComponent<ContentFavoriteItem>().imageThumb.sprite = knhopmkdbfd.sprite;
					Button component = child.GetComponent<Button>();
					component.onClick.RemoveAllListeners();
					if (!this.IJPMLEKMGMA.GIFPFPOPEJN)
					{
						component.onClick.AddListener(new UnityAction(this.BMDBFGJIOAD));
					}
					else
					{
						component.onClick.AddListener(new UnityAction(knhopmkdbfd.PJGGEDPHPBL));
					}
				}
			}
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.favoriteChars.GetComponent<RectTransform>());
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentMainTransform.GetComponent<RectTransform>());
			return;
		}
		if (FOKFGMIEEDB.GIFPFPOPEJN)
		{
			this.titleFavoriteChars.SetActive(false);
			this.noFavoriteChars.SetActive(false);
			this.favoriteChars.SetActive(false);
			return;
		}
		this.titleFavoriteChars.SetActive(true);
		this.noFavoriteChars.SetActive(true);
		this.favoriteChars.SetActive(false);
	}

	// Token: 0x06008FE2 RID: 36834 RVA: 0x003FD39C File Offset: 0x003FB59C
	private void IHPJCEAHALA(PMEPALPCEAF FOKFGMIEEDB)
	{
		foreach (object obj in this.achievements.transform)
		{
			((Transform)obj).gameObject.SetActive(false);
		}
		if (FOKFGMIEEDB.LLEOFPEHNJA().Count != 0)
		{
			this.achievementsTitle.SetActive(true);
			this.achievements.SetActive(true);
			List<FHAJAGIMLLJ> list = FOKFGMIEEDB.LLEOFPEHNJA();
			for (int i = 0; i < list.Count; i++)
			{
				if (i < this.achievements.transform.childCount)
				{
					ProfileItem2.MMBICHECIDA mmbichecida = new ProfileItem2.MMBICHECIDA();
					mmbichecida.<>4__this = this;
					Transform child = this.achievements.transform.GetChild(i);
					child.gameObject.SetActive(true);
					mmbichecida.profileAchievement = list[i];
					child.GetComponent<ContentAchievementItem>().SetContent(mmbichecida.profileAchievement);
					child.GetComponent<Button>().onClick.AddListener(new UnityAction(mmbichecida.HJNAHNHNCNF));
				}
			}
			return;
		}
		this.achievementsTitle.SetActive(false);
		this.achievements.SetActive(false);
	}

	// Token: 0x06008FE3 RID: 36835 RVA: 0x003FD4D4 File Offset: 0x003FB6D4
	private void FDPBIPDPDEP()
	{
		this.closeButton.SetActiveLocal(false);
		this.closeButtonCutscenes.SetActiveLocal(false);
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.IDEJMCAMIIA));
		AudioManager.EHBBFMCILPC.KillMusic("", -1f);
		this.CMDIKMNEGEN();
	}

	// Token: 0x06008FE4 RID: 36836 RVA: 0x003FD544 File Offset: 0x003FB744
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

	// Token: 0x06008FE5 RID: 36837 RVA: 0x003FD5C0 File Offset: 0x003FB7C0
	private void LMGNABBMMJP(AMMHDNONFHM ONAFEIGEEEI)
	{
		this.myProfileFooter.SetActive(false);
		this.randomFooter.SetActive(false);
		this.hallOfFameFooter.SetActive(false);
		this.friendFooter.SetActive(false);
		switch (ONAFEIGEEEI)
		{
		case AMMHDNONFHM.MyProfile:
			this.myProfileFooter.SetActive(true);
			return;
		case AMMHDNONFHM.RandomProfile:
			this.randomFooter.SetActive(true);
			return;
		case AMMHDNONFHM.HallOfFamePage:
		case AMMHDNONFHM.FriendsPage:
			break;
		case AMMHDNONFHM.HallOfFameProfile:
			this.hallOfFameFooter.SetActive(true);
			return;
		case AMMHDNONFHM.FriendProfile:
			this.friendFooter.SetActive(true);
			break;
		default:
			return;
		}
	}

	// Token: 0x06008FE6 RID: 36838 RVA: 0x003FD650 File Offset: 0x003FB850
	private void HEJLBMMJLHH()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		if (this.PNPEHMLHDPO != null && this.PNPEHMLHDPO.IFEEIAPMIML != null && this.PNPEHMLHDPO.IFEEIAPMIML.CCMDLENEDGJ >= 0)
		{
			this.CAPOPEIGMOB = this.PNPEHMLHDPO;
			this.IJPMLEKMGMA.JNNBNNDOGIM.KOCCNIAPFFH(this.PNPEHMLHDPO);
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("congratstitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialgiftcollectinfodone1"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("continue"), new UnityAction(this.JLNCLPODEOF), new UnityAction(this.JLNCLPODEOF), DFGILFBGPLN.popupBonusUnlock, 0f, 28);
		}
		else
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("congratstitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialgiftcollectinfodone"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("continue"), DFGILFBGPLN.popupBonusUnlock, 0f, 28);
			this.HHOHNKNPNGB = false;
		}
		this.LEJIJOAOEBK = null;
		this.MHKKGOCMIJI = null;
		this.PNPEHMLHDPO = null;
		this.OnNeedToUpdatedBadgesSection();
		this.OnNeedToUpdateIncomingGiftsSection();
		this.OnNeedToUpdateCollectedCardsSection();
		this.OnNeedToUpdateCollectedGiftsSection();
		LobbyUserInterface.EHBBFMCILPC.GetPopupCardOptions().ResetCustomMessageToFriend();
		this.PGGPPCINLMB = "";
		this.KEIKGFKANOL = "";
	}

	// Token: 0x06008FE7 RID: 36839 RVA: 0x003FD7AC File Offset: 0x003FB9AC
	public void UpdateContent(PMEPALPCEAF FOKFGMIEEDB, AMMHDNONFHM ONAFEIGEEEI)
	{
		this.LEBIMELAHBC = false;
		if (!FOKFGMIEEDB.GIFPFPOPEJN)
		{
			AKLFPGMDKLA.EHBBFMCILPC.JADCONHBJGM();
			AKLFPGMDKLA.EHBBFMCILPC.PFCCNPIPPPO();
		}
		this.APMHINNLFBN = true;
		this.IJPMLEKMGMA = FOKFGMIEEDB;
		this.activePageType = ONAFEIGEEEI;
		if (this.IJPMLEKMGMA.BDILKANCEEC || this.IJPMLEKMGMA.HOICLELFLOE.Equals(""))
		{
			this.IJPMLEKMGMA.CHGABDFMBJO(AssetsManager.EHBBFMCILPC.profileDataAsset.OHINOIHEBEP().name);
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.GNLNPMPJPEC() || (FOKFGMIEEDB.LAKHGAPCKBC && !FOKFGMIEEDB.GIFPFPOPEJN))
		{
			this.mainGradientBottom.SetActive(false);
			this.mainGradientBottom1.SetActive(true);
			this.mainScrollViewPort.PAFMBDCAPBL(-30f);
		}
		else
		{
			this.mainGradientBottom.SetActive(true);
			this.mainGradientBottom1.SetActive(false);
			this.mainScrollViewPort.PAFMBDCAPBL(0f);
		}
		if (!this.IJPMLEKMGMA.GIFPFPOPEJN)
		{
			this.ShowProfileMessages();
			this.IJPMLEKMGMA.JBNIADKCJJO(AKLFPGMDKLA.EHBBFMCILPC.OFNHOICCBAM);
			for (int i = 0; i < this.editButtons.Count; i++)
			{
				this.editButtons[i].gameObject.SetActive(true);
			}
			if (FOKFGMIEEDB.HKDBHDBGIHG != AKLFPGMDKLA.EHBBFMCILPC.LINADLBCHJC().Count || FOKFGMIEEDB.AKFNGLGEIFG != AKLFPGMDKLA.EHBBFMCILPC.MHFFFOBMPAK().Count || FOKFGMIEEDB.LCCKJBPOJIM != AKLFPGMDKLA.EHBBFMCILPC.FKJEAIALJMC().Count)
			{
				this.IJPMLEKMGMA.HKDBHDBGIHG = AKLFPGMDKLA.EHBBFMCILPC.LINADLBCHJC().Count;
				this.IJPMLEKMGMA.AKFNGLGEIFG = AKLFPGMDKLA.EHBBFMCILPC.MHFFFOBMPAK().Count;
				this.IJPMLEKMGMA.LCCKJBPOJIM = AKLFPGMDKLA.EHBBFMCILPC.FKJEAIALJMC().Count;
				DPGJIJGOCIC.NFIDPOMCNLP("SocialStatsUserPublicProfile.modified = true, UpdateContent()");
				this.IJPMLEKMGMA.CHCBHLIBGFA = true;
			}
			this.getMoreCardsButtonMainPage.gameObject.SetActive(true);
		}
		else
		{
			for (int j = 0; j < this.editButtons.Count; j++)
			{
				this.editButtons[j].gameObject.SetActive(false);
			}
			this.getMoreCardsButtonMainPage.gameObject.SetActive(false);
		}
		this.BMODBEEEABE = null;
		this.PopulateHeaderContent(FOKFGMIEEDB);
		this.DFLGMBLNECK();
		this.KDNPGGPJFPC(FOKFGMIEEDB);
		this.FHAJFICFLBG(FOKFGMIEEDB);
		this.BJBKFJEAALB(FOKFGMIEEDB);
		this.KMPHJNAEECD(FOKFGMIEEDB);
		this.HAMCABNPPHP(FOKFGMIEEDB);
		this.IHPJCEAHALA(FOKFGMIEEDB);
		this.OJDENJMNNDM(FOKFGMIEEDB);
		this.MEMHMNODKIG(FOKFGMIEEDB);
		this.FOELBHPJKFK(FOKFGMIEEDB);
		this.NJJCAKEGPJG(FOKFGMIEEDB);
		this.HFNBHGNFIGB(FOKFGMIEEDB, this.titleTopMatch, this.topMatchItemsParent, false, false);
		this.HFNBHGNFIGB(FOKFGMIEEDB, this.titleTopMatchOngoing, this.topMatchOngoingItemsParent, true, false);
		this.GHGKHLGNDKI();
		if (FOKFGMIEEDB.GIFPFPOPEJN)
		{
			this.titleCoins.SetActive(false);
			this.coins.SetActive(false);
			this.purchaseCards.SetActive(false);
		}
		else
		{
			this.titleCoins.SetActive(true);
			this.coins.SetActive(true);
			this.sp0Text.text = AKLFPGMDKLA.EHBBFMCILPC.OJNBAMPGBLJ.GALKFKBPLCK().ToString();
			this.sp1Text.text = AKLFPGMDKLA.EHBBFMCILPC.DOFKEHNPCIJ.GALKFKBPLCK().ToString();
			this.sp2Text.text = AKLFPGMDKLA.EHBBFMCILPC.PBEPCNFADAA.GALKFKBPLCK().ToString();
			this.purchaseCards.SetActive(AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.FCCNNMOIMGC().Count > 0 && KDCJJBLGCBH.EHBBFMCILPC.AGOODMGFCCI());
		}
		this.completedStories.SetText(this.IJPMLEKMGMA.HKDBHDBGIHG.ToString() ?? "", true);
		this.ongoingStories.SetText(this.IJPMLEKMGMA.AKFNGLGEIFG.ToString() ?? "", true);
		this.notStartedStories.SetText(this.IJPMLEKMGMA.LCCKJBPOJIM.ToString() ?? "", true);
		this.completedStories.text = (this.IJPMLEKMGMA.HKDBHDBGIHG.ToString() ?? "");
		this.ongoingStories.text = (this.IJPMLEKMGMA.AKFNGLGEIFG.ToString() ?? "");
		this.notStartedStories.text = (this.IJPMLEKMGMA.LCCKJBPOJIM.ToString() ?? "");
		if (!this.IJPMLEKMGMA.GIFPFPOPEJN)
		{
			this.totalChapters.SetText(AKLFPGMDKLA.EHBBFMCILPC.GEPFALMBONM().ToString() ?? "", true);
			this.totalChapters.text = (AKLFPGMDKLA.EHBBFMCILPC.GEPFALMBONM().ToString() ?? "");
			this.IJPMLEKMGMA.GFJPFDNJHNG(AKLFPGMDKLA.EHBBFMCILPC.GEPFALMBONM());
		}
		else if (this.IJPMLEKMGMA.DIEPFILJNKG == 0)
		{
			this.totalChapters.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("nastring"), true);
			this.totalChapters.text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("nastring");
		}
		else
		{
			this.totalChapters.SetText(this.IJPMLEKMGMA.DIEPFILJNKG.ToString() ?? "", true);
			this.totalChapters.text = (this.IJPMLEKMGMA.DIEPFILJNKG.ToString() ?? "");
		}
		if (this.IJPMLEKMGMA.DBJMOAOBHKE < 0)
		{
			this.daysStrike.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("nastring"), true);
			this.daysStrike.text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("nastring");
			this.creationDate.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("nastring"), true);
			this.creationDate.text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("nastring");
		}
		else
		{
			this.daysStrike.SetText(this.IJPMLEKMGMA.DBJMOAOBHKE.ToString() ?? "", true);
			this.daysStrike.text = (this.IJPMLEKMGMA.DBJMOAOBHKE.ToString() ?? "");
			this.creationDate.SetText(this.IJPMLEKMGMA.PIJJLPGNKBI ?? "", true);
			this.creationDate.text = (this.IJPMLEKMGMA.PIJJLPGNKBI ?? "");
		}
		this.avatarHeader.UpdateNickNameText(false);
		this.UpdateCredoText(false);
		this.UpdateLoveText(false);
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(21))
		{
			this.mainScrollView.GetComponent<ScrollRect>().verticalNormalizedPosition = 0f;
			this.mainScrollView.GetComponent<ScrollRect>().DOVerticalNormalizedPos(1f, 1.5f, false).OnComplete(new TweenCallback(ProfileItem2.<>c.<>9.OMNPOBHLJPN));
		}
		else
		{
			this.mainScrollView.GetComponent<ScrollRect>().verticalNormalizedPosition = 1f;
		}
		this.AOLHMMGALPJ(FOKFGMIEEDB);
		this.LMGNABBMMJP(this.activePageType);
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentMainTransform.GetComponent<RectTransform>());
	}

	// Token: 0x06008FE8 RID: 36840 RVA: 0x003FDEF4 File Offset: 0x003FC0F4
	private void PBAHOEGHHHN()
	{
		this.anthologyAchievementsHiddenDropDown.color = new Color(1f, 1f, 1f, 0.25f);
		Transform transform = this.anthologyAchievements.transform;
		List<string> list = this.IJPMLEKMGMA.PEBKLGDBGHC();
		for (int i = list.Count - this.maxShownItems - 1; i >= 0; i--)
		{
			ProfileItem2.CNHECPNLJKB cnhecpnljkb = new ProfileItem2.CNHECPNLJKB();
			cnhecpnljkb.<>4__this = this;
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.anthologyAchievementItem, transform);
			cnhecpnljkb.achievementId = list[i];
			gameObject.GetComponent<ContentAnthologyAchievementsItem>().SetContent(cnhecpnljkb.achievementId);
			gameObject.GetComponent<Button>().onClick.AddListener(new UnityAction(cnhecpnljkb.MBLKFKBCINB));
		}
		this.anthologyAchievementsExpandButton.onClick.RemoveListener(new UnityAction(this.PBAHOEGHHHN));
		this.anthologyAchievementsExpandButton.GetComponent<AnimationPress>().enabled = false;
		this.anthologyAchievementsExpandButton.GetComponent<Button>().enabled = false;
		LayoutRebuilder.ForceRebuildLayoutImmediate(transform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentMainTransform.GetComponent<RectTransform>());
	}

	// Token: 0x06008FE9 RID: 36841 RVA: 0x003FE004 File Offset: 0x003FC204
	private void ONHHONKJGPL()
	{
		string text = DPGJIJGOCIC.HIPPBJFMIKM(AOBJLALDBAA.EHBBFMCILPC.KNCFLCKKPLK());
		bool flag = false;
		if (text != null && text.Length > 0)
		{
			if (CommonUserInterface.EHBBFMCILPC.GetPopupProfileUIDInput().GetFlag() < 2)
			{
				if (text.Length >= 24)
				{
					text = text.Substring(0, 24);
					if (CommonUserInterface.EHBBFMCILPC.GetPopupProfileUIDInput().GetFlag() == 0)
					{
						if (text.Equals(AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD))
						{
							CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialrequestwarnyou"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0.25f, 28);
						}
						else
						{
							CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(96);
							JSONObject dmimkkciaph = null;
							if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null && AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA)
							{
								dmimkkciaph = AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.BNMFBKNEMIF();
								DPGJIJGOCIC.NFIDPOMCNLP("SocialStatsUserPublicProfile.modified = false, OnPopupProfileUIDInputEndEdit()");
								AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA = false;
							}
							JSONObject defaultOperationsJsonObject = ProfileItem2.GetDefaultOperationsJsonObject(0, true);
							defaultOperationsJsonObject.Add("fruid", text);
							FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.socFriend.ToString(), FFPHBMFGCNN.frRequest.ToString(), "", false, false);
							FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.socFriend.ToString(), FFPHBMFGCNN.frRequestUID.ToString(), "", false, false);
							AKLFPGMDKLA.EHBBFMCILPC.CIPCINKGILF = true;
							BackendOperationsManager.EHBBFMCILPC.RequestGetUserPublicProfile(false, dmimkkciaph, defaultOperationsJsonObject, "OnBackendAddFriendByUIDSuccess", "OnBackendAddFriendByUIDException", false);
						}
					}
					else if (text.Equals(AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD))
					{
						CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialrequestwarnyou2"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), new UnityAction(this.IGNJLJIKCHI), new UnityAction(this.IGNJLJIKCHI), DFGILFBGPLN.popupEnergyHint, 0.25f, 28);
					}
					else
					{
						LJNMIPMNOKF.EHBBFMCILPC.EBBLJMHNDKK().BJHMPPGDGOO = text;
						LJNMIPMNOKF.EHBBFMCILPC.EBBLJMHNDKK().FMJEOOFGLEE = "";
						this.GACONMKBMCM();
					}
				}
				else
				{
					flag = true;
				}
			}
			else if (CommonUserInterface.EHBBFMCILPC.GetPopupProfileUIDInput().GetFlag() == 2)
			{
				if (text.Equals(AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.KNCFKDLOPGA))
				{
					CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialrequestwarnyou"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0.25f, 28);
				}
				else
				{
					CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(96);
					JSONObject dmimkkciaph2 = null;
					if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null && AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA)
					{
						dmimkkciaph2 = AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.BNMFBKNEMIF();
						DPGJIJGOCIC.NFIDPOMCNLP("SocialStatsUserPublicProfile.modified = false, OnPopupProfileUIDInputEndEdit()");
						AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA = false;
					}
					JSONObject defaultOperationsJsonObject2 = ProfileItem2.GetDefaultOperationsJsonObject(0, true);
					defaultOperationsJsonObject2.Add("frnick", Convert.ToBase64String(Encoding.UTF8.GetBytes(text.ToLowerInvariant())));
					FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.socFriend.ToString(), FFPHBMFGCNN.frRequest.ToString(), "", false, false);
					FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.socFriend.ToString(), FFPHBMFGCNN.frRequestNick.ToString(), "", false, false);
					AKLFPGMDKLA.EHBBFMCILPC.CIPCINKGILF = true;
					BackendOperationsManager.EHBBFMCILPC.RequestGetUserPublicProfile(false, dmimkkciaph2, defaultOperationsJsonObject2, "OnBackendAddFriendByUIDSuccess", "OnBackendAddFriendByUIDException", false);
				}
			}
			else if (text.Equals(AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.KNCFKDLOPGA))
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialrequestwarnyou2"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0.25f, 28);
			}
			else
			{
				LJNMIPMNOKF.EHBBFMCILPC.EBBLJMHNDKK().BJHMPPGDGOO = text;
				LJNMIPMNOKF.EHBBFMCILPC.EBBLJMHNDKK().FMJEOOFGLEE = Convert.ToBase64String(Encoding.UTF8.GetBytes(text.ToLowerInvariant()));
				this.GACONMKBMCM();
			}
		}
		else
		{
			flag = true;
		}
		if (flag)
		{
			if (CommonUserInterface.EHBBFMCILPC.GetPopupProfileUIDInput().GetFlag() == 0)
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialenteruseridmalformed"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0.25f, 28);
				return;
			}
			if (CommonUserInterface.EHBBFMCILPC.GetPopupProfileUIDInput().GetFlag() == 1)
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialenteruseridmalformed"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), new UnityAction(this.IGNJLJIKCHI), new UnityAction(this.IGNJLJIKCHI), DFGILFBGPLN.popupEnergyHint, 0.25f, 28);
				return;
			}
			if (CommonUserInterface.EHBBFMCILPC.GetPopupProfileUIDInput().GetFlag() == 2)
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialenteruseridmalformed2"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0.25f, 28);
				return;
			}
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialenteruseridmalformed2"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), new UnityAction(this.IGNJLJIKCHI), new UnityAction(this.IGNJLJIKCHI), DFGILFBGPLN.popupEnergyHint, 0.25f, 28);
		}
	}

	// Token: 0x06008FEA RID: 36842 RVA: 0x003FE608 File Offset: 0x003FC808
	private void GACONMKBMCM()
	{
		this.LEJIJOAOEBK = LJNMIPMNOKF.EHBBFMCILPC.EBBLJMHNDKK().HEDNLIPLMBL;
		if ((this.LEJIJOAOEBK != null && this.LEJIJOAOEBK.EEBMPDNLJGD.Length > 0) || LJNMIPMNOKF.EHBBFMCILPC.EBBLJMHNDKK().BJHMPPGDGOO.Length > 0)
		{
			string text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialsendgiftprembody");
			if (this.LEJIJOAOEBK != null)
			{
				string str;
				if (this.LEJIJOAOEBK.KNCFKDLOPGA.Length == 0)
				{
					str = "<" + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("profilenametitleshort") + ">";
				}
				else
				{
					str = this.LEJIJOAOEBK.KNCFKDLOPGA;
				}
				text = text.Replace("YYY", "<i>" + str + "</i>");
			}
			else if (LJNMIPMNOKF.EHBBFMCILPC.EBBLJMHNDKK().FMJEOOFGLEE.Length > 0)
			{
				text = text.Replace("YYY", "<i>" + LJNMIPMNOKF.EHBBFMCILPC.EBBLJMHNDKK().BJHMPPGDGOO + "</i>");
			}
			else
			{
				text = text.Replace("YYY", "<i>" + AKLFPGMDKLA.EHBBFMCILPC.OMMACPBIHDN(LJNMIPMNOKF.EHBBFMCILPC.EBBLJMHNDKK().BJHMPPGDGOO) + "</i>");
			}
			text = text.Replace("XXX", "<i>" + GDJPPKAMIFL.EHBBFMCILPC.KCMKJBHBCGC(LJNMIPMNOKF.EHBBFMCILPC.EBBLJMHNDKK().CCMDLENEDGJ) + "</i>");
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("areyousure"), text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("no"), new UnityAction(this.OnContinueToSendPremGiftPositive), new UnityAction(this.OnContinueToSendPremGiftNegative), DFGILFBGPLN.popupQuitConfirm, 0.25f, 28);
			return;
		}
		this.FOOEEAKCONK();
	}

	// Token: 0x06008FEB RID: 36843 RVA: 0x003FE7E8 File Offset: 0x003FC9E8
	private void OnDestroy()
	{
		this.avatarHeader.avatarImageThumb.sprite = null;
		for (int i = 0; i < this.blurredPreviews.Count; i++)
		{
			this.blurredPreviews[i].sprite = null;
		}
		if (null != this.JOBMFPFIMHM)
		{
			UnityEngine.Object.Destroy(this.JOBMFPFIMHM);
			this.JOBMFPFIMHM = null;
		}
		if (this.OMBEJHJDJKG != null)
		{
			base.StopCoroutine(this.OMBEJHJDJKG);
		}
		this.OMBEJHJDJKG = null;
		if (this.JOCNEKNFKPF != null)
		{
			base.StopCoroutine(this.JOCNEKNFKPF);
		}
		this.JOCNEKNFKPF = null;
		if (this.PFFIIOHPJCA != null)
		{
			base.StopCoroutine(this.PFFIIOHPJCA);
		}
		this.PFFIIOHPJCA = null;
	}

	// Token: 0x06008FEC RID: 36844 RVA: 0x003FE89F File Offset: 0x003FCA9F
	private void IGNJLJIKCHI()
	{
		PopupCardOptions.reopenCardOptionsFlag = true;
		this.OnPopupCardOptionsReopen();
	}

	// Token: 0x06008FED RID: 36845 RVA: 0x003FE8B0 File Offset: 0x003FCAB0
	public void OnFriendsMessageHistoryBackButtonClick()
	{
		this.FadeOut(this.contentChatPage.gameObject);
		if (!ContentChatPage.showingUpgradeToFriendsPlus && this.LEJIJOAOEBK != null && null != this.MHKKGOCMIJI)
		{
			this.ShowFriendOptions(this.LEJIJOAOEBK, this.MHKKGOCMIJI);
		}
		ContentChatPage.showingUpgradeToFriendsPlus = false;
	}

	// Token: 0x06008FEE RID: 36846 RVA: 0x003FE903 File Offset: 0x003FCB03
	private IEnumerator BJGBFJBACIG()
	{
		while (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.JNNBNNDOGIM.HGKONIOKMEH() > 0)
		{
			while (CommonUserInterface.EHBBFMCILPC.AnyGenericPopupIsActive() || LobbyUserInterface.EHBBFMCILPC.FriendsCurrencyPopupActive() || CommonUserInterface.EHBBFMCILPC.ConnectionAnimationEnabled())
			{
				yield return new WaitForSeconds(0.2f);
			}
			this.PNPEHMLHDPO = AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.JNNBNNDOGIM.JLMMKKADJPG();
			if (this.PNPEHMLHDPO != null && this.PNPEHMLHDPO.IFEEIAPMIML != null)
			{
				this.HHOHNKNPNGB = true;
				if (this.PNPEHMLHDPO.IFEEIAPMIML.DGPKGMHEHOF == 0)
				{
					LobbyUserInterface.EHBBFMCILPC.ShowFriendsCurrencyReceivedPopup(this.PNPEHMLHDPO);
				}
				else
				{
					LobbyUserInterface.EHBBFMCILPC.ShowFriendsGiftReceivedPopup(this.PNPEHMLHDPO);
				}
			}
			yield return new WaitForSeconds(0.2f);
			while (this.HHOHNKNPNGB)
			{
				yield return new WaitForSeconds(0.2f);
			}
			yield return new WaitForSeconds(0.2f);
		}
		this.OMBEJHJDJKG = null;
		this.HHOHNKNPNGB = false;
		this.PNPEHMLHDPO = null;
		this.OnNeedToCheckForEmptyFriendsPage();
		yield break;
	}

	// Token: 0x06008FEF RID: 36847 RVA: 0x003FE912 File Offset: 0x003FCB12
	private void NHPIIKKJILL()
	{
		CommonUserInterface.EHBBFMCILPC.ShowPopupProfileUIDInput(2);
	}

	// Token: 0x06008FF0 RID: 36848 RVA: 0x003FE920 File Offset: 0x003FCB20
	public int GetAnthologyIndexFromAchievementId(string JJJGEOBAMDI)
	{
		if (JJJGEOBAMDI.StartsWith("achiev"))
		{
			JJJGEOBAMDI = JJJGEOBAMDI.Replace("achiev", "");
		}
		int result = 0;
		try
		{
			result = int.Parse(JJJGEOBAMDI.Substring(0, JJJGEOBAMDI.IndexOf("id")).Replace("a", ""));
		}
		catch (Exception aklgbjkdomm)
		{
			result = 0;
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return result;
	}

	// Token: 0x06008FF1 RID: 36849 RVA: 0x003FE994 File Offset: 0x003FCB94
	private void CCELCEOOHJP()
	{
		this.CAPOPEIGMOB = null;
		this.HHOHNKNPNGB = true;
	}

	// Token: 0x06008FF2 RID: 36850 RVA: 0x003FE9A4 File Offset: 0x003FCBA4
	private void ECCDOMHPPFP(GameObject IACFDHCDEME, PMEPALPCEAF AEDICCFAKOM, bool BDFHENEFGKI = false)
	{
		IACFDHCDEME.SetActive(true);
		this.JOFHJGANKHO(AEDICCFAKOM, BDFHENEFGKI);
		if (BDFHENEFGKI)
		{
			this.GJFOKPKABCB(this.topMatchOngoingItemsParent.transform);
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.topMatchOngoingItemsParent.GetComponent<RectTransform>());
		}
		else
		{
			this.GJFOKPKABCB(this.topMatchItemsParent.transform);
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.topMatchItemsParent.GetComponent<RectTransform>());
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentMainTransform.GetComponent<RectTransform>());
	}

	// Token: 0x06008FF3 RID: 36851 RVA: 0x003FEA18 File Offset: 0x003FCC18
	public void GKNJMEODFPF()
	{
		CommonUserInterface.IKNOFBFMPGA().MCJIGJMFBMI();
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC == null && AKLFPGMDKLA.EHBBFMCILPC.OEONCFGBLIF != null)
		{
			AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC = AKLFPGMDKLA.EHBBFMCILPC.OEONCFGBLIF;
			DPGJIJGOCIC.ANOPFDLPKGC("aindas");
		}
		if (this.NEDAFKKJGGK)
		{
			CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupOneOverride(CCOJBMMKNAP.KNKGCDDMLDP().HIPJILDCHJC(")"), CCOJBMMKNAP.KFDLFGHBPLP().IPEIONBNIPH("liveeventcontent"), CCOJBMMKNAP.HEDIEIICOOG().OBDCPLLLGBB("REMOVEAVATARCOMPONENT"), new UnityAction(this.OnShuffleClick), (DFGILFBGPLN)(-67), 1190f, 111);
		}
		else
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.AEELGGPEJCC().IPEIONBNIPH("yes"), CCOJBMMKNAP.KLAKLFCOMJC().HHLECNIFHCO("OnEmailSubscribeSuccess"), CCOJBMMKNAP.PKEINLPIAEH().FCOCLEHKLDJ("signinerror001"), new UnityAction(this.OnProfileClick), (DFGILFBGPLN)(-120), 374f, -53);
		}
		this.MarkAsModified();
	}

	// Token: 0x06008FF4 RID: 36852 RVA: 0x00003E52 File Offset: 0x00002052
	private void GJNDBHEOMHD()
	{
	}

	// Token: 0x06008FF5 RID: 36853 RVA: 0x003FEB0F File Offset: 0x003FCD0F
	private void DLLKOJCKDAD()
	{
		if (CommonUserInterface.EHBBFMCILPC.GetPopupProfileUIDInput().GetFlag() != 0 && CommonUserInterface.EHBBFMCILPC.GetPopupProfileUIDInput().GetFlag() != 2)
		{
			this.IGNJLJIKCHI();
		}
	}

	// Token: 0x06008FF6 RID: 36854 RVA: 0x003FEB3C File Offset: 0x003FCD3C
	private void KJJLNHHFLGC(BNFCLKNDBLO EHCCKGCLNGI, GameObject LHGHFFIPBPN, GameObject IGJELOAEIAK)
	{
		ProfileItem2.GANFHPDNPIF ganfhpdnpif = new ProfileItem2.GANFHPDNPIF();
		ganfhpdnpif.cutscene = EHCCKGCLNGI;
		this.IJPMLEKMGMA.LEFMIMINNKO(ganfhpdnpif.cutscene.IAGMLHAEOJI);
		this.IJPMLEKMGMA.HKGOBAPMPFJ(ganfhpdnpif.cutscene.IAGMLHAEOJI);
		if (false || this.IJPMLEKMGMA.IPILOAEGBMD().Count == 0)
		{
			UnityEngine.Object.Destroy(IGJELOAEIAK);
			IGJELOAEIAK.GetComponent<ContentCutsceneItem>().UpdateCutsceneCountOnRemove();
			IGJELOAEIAK.GetComponent<ContentCutsceneItem>().UpdateFavCutsceneCount();
			this.FadeOut(this.contentCutscenesPage);
			return;
		}
		if (!true || !this.IJPMLEKMGMA.IPILOAEGBMD().Exists(new Predicate<BNFCLKNDBLO>(ganfhpdnpif.OLEENIECKPI)))
		{
			UnityEngine.Object.Destroy(IGJELOAEIAK);
			return;
		}
		UnityEngine.Object.Destroy(LHGHFFIPBPN);
		IGJELOAEIAK.GetComponent<ContentCutsceneItem>().UpdateCutsceneCountOnRemove();
		IGJELOAEIAK.GetComponent<ContentCutsceneItem>().UpdateFavCutsceneCount();
		base.StartCoroutine(this.LHNMEHHAPAO(this.cutscenesScrollView.GetComponent<RectTransform>()));
		base.StartCoroutine(this.LHNMEHHAPAO(IGJELOAEIAK.GetComponent<RectTransform>()));
	}

	// Token: 0x040027A6 RID: 10150
	private readonly Ease HNJCFFHCDCC = Ease.OutQuad;

	// Token: 0x040027A7 RID: 10151
	private readonly float AKCEKJFIGJH = 0.5f;

	// Token: 0x040027A8 RID: 10152
	private readonly float JHGJFGECNPL = 1f;

	// Token: 0x040027A9 RID: 10153
	private readonly float AODLOLBDFDB;

	// Token: 0x040027AA RID: 10154
	[Header("Header")]
	public ContentHeader avatarHeader;

	// Token: 0x040027AB RID: 10155
	[Header("Messages")]
	[SerializeField]
	private GameObject iRCPlayTitle;

	// Token: 0x040027AC RID: 10156
	[SerializeField]
	private GameObject iRCPlayMsg;

	// Token: 0x040027AD RID: 10157
	[SerializeField]
	private GameObject editRCPlayButton;

	// Token: 0x040027AE RID: 10158
	[SerializeField]
	private GameObject credoTitle;

	// Token: 0x040027AF RID: 10159
	[SerializeField]
	private GameObject credoMsg;

	// Token: 0x040027B0 RID: 10160
	[SerializeField]
	private GameObject editCredoButton;

	// Token: 0x040027B1 RID: 10161
	[SerializeField]
	[Header("Friends")]
	private GameObject friendsTitle;

	// Token: 0x040027B2 RID: 10162
	[SerializeField]
	private GameObject noFriends;

	// Token: 0x040027B3 RID: 10163
	[SerializeField]
	private GameObject friends;

	// Token: 0x040027B4 RID: 10164
	[SerializeField]
	private TextMeshProUGUI friendsEventsCountText;

	// Token: 0x040027B5 RID: 10165
	[Header("Achievements")]
	[SerializeField]
	private GameObject achievementsTitle;

	// Token: 0x040027B6 RID: 10166
	[SerializeField]
	private GameObject achievements;

	// Token: 0x040027B7 RID: 10167
	[SerializeField]
	private GameObject anthologyAchievementsTitle;

	// Token: 0x040027B8 RID: 10168
	[SerializeField]
	private GameObject anthologyAchievements;

	// Token: 0x040027B9 RID: 10169
	[SerializeField]
	private GameObject noAnthologyAchievements;

	// Token: 0x040027BA RID: 10170
	[SerializeField]
	private GameObject anthologyAchievementsHidden;

	// Token: 0x040027BB RID: 10171
	[SerializeField]
	private Image anthologyAchievementsHiddenDropDown;

	// Token: 0x040027BC RID: 10172
	[SerializeField]
	private TextMeshProUGUI anthologyAchievementsHiddenText;

	// Token: 0x040027BD RID: 10173
	[SerializeField]
	private Button anthologyAchievementsExpandButton;

	// Token: 0x040027BE RID: 10174
	[SerializeField]
	[Header("Cards")]
	private GameObject titleCards;

	// Token: 0x040027BF RID: 10175
	[SerializeField]
	private GameObject cards;

	// Token: 0x040027C0 RID: 10176
	[SerializeField]
	private GameObject cardsHidden;

	// Token: 0x040027C1 RID: 10177
	[SerializeField]
	private TextMeshProUGUI cardsHiddenText;

	// Token: 0x040027C2 RID: 10178
	[SerializeField]
	private Image cardsHiddenTextDropDown;

	// Token: 0x040027C3 RID: 10179
	[SerializeField]
	private Button cardsExpandButton;

	// Token: 0x040027C4 RID: 10180
	[Header("WishedCards")]
	[SerializeField]
	private GameObject titleWishedCards;

	// Token: 0x040027C5 RID: 10181
	[SerializeField]
	private GameObject wishedCards;

	// Token: 0x040027C6 RID: 10182
	[SerializeField]
	private GameObject noWishedCards;

	// Token: 0x040027C7 RID: 10183
	[Header("TradingCards")]
	[SerializeField]
	private GameObject titleTradingCards;

	// Token: 0x040027C8 RID: 10184
	[SerializeField]
	private GameObject tradingCards;

	// Token: 0x040027C9 RID: 10185
	[Header("Badges")]
	[SerializeField]
	private GameObject titleBadges;

	// Token: 0x040027CA RID: 10186
	[SerializeField]
	private GameObject badges;

	// Token: 0x040027CB RID: 10187
	[SerializeField]
	private GameObject badgesHidden;

	// Token: 0x040027CC RID: 10188
	[SerializeField]
	private TextMeshProUGUI badgesHiddenText;

	// Token: 0x040027CD RID: 10189
	[SerializeField]
	private Image badgesHiddenTextDropDown;

	// Token: 0x040027CE RID: 10190
	[SerializeField]
	private Button badgesExpandButton;

	// Token: 0x040027CF RID: 10191
	[SerializeField]
	[Header("Coins")]
	private GameObject titleCoins;

	// Token: 0x040027D0 RID: 10192
	[SerializeField]
	private GameObject coins;

	// Token: 0x040027D1 RID: 10193
	[SerializeField]
	private TextMeshProUGUI sp0Text;

	// Token: 0x040027D2 RID: 10194
	[SerializeField]
	private TextMeshProUGUI sp1Text;

	// Token: 0x040027D3 RID: 10195
	[SerializeField]
	private TextMeshProUGUI sp2Text;

	// Token: 0x040027D4 RID: 10196
	[SerializeField]
	[Header("Purchase cards")]
	private GameObject purchaseCards;

	// Token: 0x040027D5 RID: 10197
	[Header("Favorite Items")]
	[SerializeField]
	private GameObject titleFavoriteCutscenes;

	// Token: 0x040027D6 RID: 10198
	[SerializeField]
	private GameObject favoriteCutscenes;

	// Token: 0x040027D7 RID: 10199
	[SerializeField]
	private GameObject noFavoriteCutscenes;

	// Token: 0x040027D8 RID: 10200
	[SerializeField]
	private GameObject titleFavoriteChars;

	// Token: 0x040027D9 RID: 10201
	[SerializeField]
	private GameObject favoriteChars;

	// Token: 0x040027DA RID: 10202
	[SerializeField]
	private GameObject noFavoriteChars;

	// Token: 0x040027DB RID: 10203
	[SerializeField]
	private GameObject titleFavoriteStories;

	// Token: 0x040027DC RID: 10204
	[SerializeField]
	private GameObject favoriteStories;

	// Token: 0x040027DD RID: 10205
	[SerializeField]
	private GameObject noFavoriteStories;

	// Token: 0x040027DE RID: 10206
	[Header("Top Match")]
	[SerializeField]
	private GameObject titleTopMatch;

	// Token: 0x040027DF RID: 10207
	[SerializeField]
	private GameObject topMatchItemsParent;

	// Token: 0x040027E0 RID: 10208
	[SerializeField]
	private GameObject topMatchHidden;

	// Token: 0x040027E1 RID: 10209
	[SerializeField]
	private TextMeshProUGUI topMatchHiddenText;

	// Token: 0x040027E2 RID: 10210
	[SerializeField]
	private GameObject topMatchHiddenRandom;

	// Token: 0x040027E3 RID: 10211
	[SerializeField]
	private TextMeshProUGUI topMatchHiddenTextRandom;

	// Token: 0x040027E4 RID: 10212
	[SerializeField]
	private GameObject titleTopMatchOngoing;

	// Token: 0x040027E5 RID: 10213
	[SerializeField]
	private GameObject topMatchOngoingItemsParent;

	// Token: 0x040027E6 RID: 10214
	[SerializeField]
	private GameObject topMatchOngoingHidden;

	// Token: 0x040027E7 RID: 10215
	[SerializeField]
	private TextMeshProUGUI topMatchOngoingHiddenText;

	// Token: 0x040027E8 RID: 10216
	[SerializeField]
	private GameObject topMatchOngoingHiddenRandom;

	// Token: 0x040027E9 RID: 10217
	[SerializeField]
	private TextMeshProUGUI topMatchOngoingHiddenTextRandom;

	// Token: 0x040027EA RID: 10218
	[Header("Content Transforms")]
	[SerializeField]
	private Transform contentMainTransform;

	// Token: 0x040027EB RID: 10219
	[SerializeField]
	private TextMeshProUGUI contentAvatarHeaderStatus;

	// Token: 0x040027EC RID: 10220
	[SerializeField]
	private Transform contentCharactersTransform;

	// Token: 0x040027ED RID: 10221
	[SerializeField]
	private TextMeshProUGUI contentCharactersHeaderStatus;

	// Token: 0x040027EE RID: 10222
	[SerializeField]
	private Transform contentStoriesTransform;

	// Token: 0x040027EF RID: 10223
	[SerializeField]
	private TextMeshProUGUI contentStoriesHeaderStatus;

	// Token: 0x040027F0 RID: 10224
	[SerializeField]
	private Transform contentCutscenesTransform;

	// Token: 0x040027F1 RID: 10225
	[SerializeField]
	private TextMeshProUGUI contentCutscenesHeaderStatus;

	// Token: 0x040027F2 RID: 10226
	[SerializeField]
	private Transform contentAnthologyAchievementsTransform;

	// Token: 0x040027F3 RID: 10227
	[SerializeField]
	private TextMeshProUGUI contentAnthologyAchievementsHeaderStatus;

	// Token: 0x040027F4 RID: 10228
	[SerializeField]
	private Transform contentWishedCardsPageTransform;

	// Token: 0x040027F5 RID: 10229
	[SerializeField]
	private TextMeshProUGUI contentWishedCardsHeaderStatus;

	// Token: 0x040027F6 RID: 10230
	[Header("Content Pages")]
	[SerializeField]
	private GameObject contentMainPage;

	// Token: 0x040027F7 RID: 10231
	[SerializeField]
	private ContentFriendsPage contentFriendsPage;

	// Token: 0x040027F8 RID: 10232
	[SerializeField]
	private ContentHallOfFamePage contentHallOfFamePage;

	// Token: 0x040027F9 RID: 10233
	[SerializeField]
	private ContentChatPage contentChatPage;

	// Token: 0x040027FA RID: 10234
	[SerializeField]
	private ContentAvatarPage contentAvatarPage;

	// Token: 0x040027FB RID: 10235
	[SerializeField]
	private GameObject contentCharactersPage;

	// Token: 0x040027FC RID: 10236
	[SerializeField]
	private GameObject contentStoriesPage;

	// Token: 0x040027FD RID: 10237
	[SerializeField]
	private GameObject contentCutscenesPage;

	// Token: 0x040027FE RID: 10238
	[SerializeField]
	private GameObject contentAnthologyAchievementsPage;

	// Token: 0x040027FF RID: 10239
	[SerializeField]
	private GameObject contentWishedCardsPage;

	// Token: 0x04002800 RID: 10240
	[Header("Prefabs")]
	[SerializeField]
	private GameObject gridItem;

	// Token: 0x04002801 RID: 10241
	[SerializeField]
	private GameObject anthologyAchievementGridItem;

	// Token: 0x04002802 RID: 10242
	[SerializeField]
	private GameObject cutsceneItem;

	// Token: 0x04002803 RID: 10243
	[SerializeField]
	private GameObject cutsceneItemSmall;

	// Token: 0x04002804 RID: 10244
	[SerializeField]
	private GameObject topMatchItem;

	// Token: 0x04002805 RID: 10245
	[SerializeField]
	private GameObject anthologyAchievementItem;

	// Token: 0x04002806 RID: 10246
	[SerializeField]
	private GameObject cardItem;

	// Token: 0x04002807 RID: 10247
	[Header("Scroll Views")]
	[SerializeField]
	private Transform mainScrollView;

	// Token: 0x04002808 RID: 10248
	[SerializeField]
	private Transform charactersScrollView;

	// Token: 0x04002809 RID: 10249
	[SerializeField]
	private Transform storiesScrollView;

	// Token: 0x0400280A RID: 10250
	[SerializeField]
	private Transform cutscenesScrollView;

	// Token: 0x0400280B RID: 10251
	[SerializeField]
	private Transform anthologyAchievementsScrollView;

	// Token: 0x0400280C RID: 10252
	[SerializeField]
	private Transform wishedCardScrollView;

	// Token: 0x0400280D RID: 10253
	[Header("Footer")]
	[SerializeField]
	private GameObject myProfileFooter;

	// Token: 0x0400280E RID: 10254
	[SerializeField]
	private GameObject randomFooter;

	// Token: 0x0400280F RID: 10255
	[SerializeField]
	private GameObject hallOfFameFooter;

	// Token: 0x04002810 RID: 10256
	[SerializeField]
	private GameObject friendFooter;

	// Token: 0x04002811 RID: 10257
	[HideInInspector]
	public AMMHDNONFHM activePageType;

	// Token: 0x04002812 RID: 10258
	[HideInInspector]
	public int maxShownItems = 18;

	// Token: 0x04002813 RID: 10259
	private GameObject OEEDMOKBDNC;

	// Token: 0x04002814 RID: 10260
	private PMEPALPCEAF IJPMLEKMGMA;

	// Token: 0x04002815 RID: 10261
	private Vector3 PFEEFOKHKMP;

	// Token: 0x04002816 RID: 10262
	public const string onBackendUpgradeToGiftCardSuccess = "OnBackendUpgradeToGiftCardSuccess";

	// Token: 0x04002817 RID: 10263
	public const string onBackendUpgradeToGiftCardException = "OnBackendUpgradeToGiftCardException";

	// Token: 0x04002818 RID: 10264
	public const string onBackendGetPublicProfileProfileItemSuccess = "OnBackendGetPublicProfileProfileItemSuccess";

	// Token: 0x04002819 RID: 10265
	public const string onBackendGetPublicProfileProfileItemException = "OnBackendGetPublicProfileProfileItemException";

	// Token: 0x0400281A RID: 10266
	public const string onBackendGetPublicProfileHallOfFameSuccess = "OnBackendGetPublicProfileHallOfFameSuccess";

	// Token: 0x0400281B RID: 10267
	public const string onBackendGetPublicProfileHallOfFameException = "OnBackendGetPublicProfileHallOfFameException";

	// Token: 0x0400281C RID: 10268
	public const string onBackendAddFriendByUIDSuccess = "OnBackendAddFriendByUIDSuccess";

	// Token: 0x0400281D RID: 10269
	public const string onBackendAddFriendByUIDException = "OnBackendAddFriendByUIDException";

	// Token: 0x0400281E RID: 10270
	public const string onBackendRequestCustomProfileSuccess = "OnBackendRequestCustomProfileSuccess";

	// Token: 0x0400281F RID: 10271
	public const string onBackendRequestCustomProfileException = "OnBackendRequestCustomProfileException";

	// Token: 0x04002820 RID: 10272
	public const string onBackendRequestFriendRejectSuccess = "OnBackendRequestFriendRejectSuccess";

	// Token: 0x04002821 RID: 10273
	public const string onBackendRequestFriendRejectException = "OnBackendRequestFriendRejectException";

	// Token: 0x04002822 RID: 10274
	public const string onBackendRequestFriendAcceptSuccess = "OnBackendRequestFriendAcceptSuccess";

	// Token: 0x04002823 RID: 10275
	public const string onBackendRequestFriendAcceptException = "OnBackendRequestFriendAcceptException";

	// Token: 0x04002824 RID: 10276
	public const string onBackendRequestFriendDeleteSuccess = "OnBackendRequestFriendDeleteSuccess";

	// Token: 0x04002825 RID: 10277
	public const string onBackendRequestFriendDeleteException = "OnBackendRequestFriendDeleteException";

	// Token: 0x04002826 RID: 10278
	public const string onBackendRequestShareHardSuccess = "OnBackendRequestShareHardSuccess";

	// Token: 0x04002827 RID: 10279
	public const string onBackendRequestShareHardException = "OnBackendRequestShareHardException";

	// Token: 0x04002828 RID: 10280
	public const string onBackendRequestCollectGiftSuccess = "OnBackendRequestCollectGiftSuccess";

	// Token: 0x04002829 RID: 10281
	public const string onBackendRequestCollectGiftException = "OnBackendRequestCollectGiftException";

	// Token: 0x0400282A RID: 10282
	public const string onCutsceneViewShow = "OnCutsceneViewShow";

	// Token: 0x0400282B RID: 10283
	public const string onFriendsCurrencyPopupCollect = "OnFriendsCurrencyPopupCollect";

	// Token: 0x0400282C RID: 10284
	public const string onFriendsGiftPopulCollectPart1 = "OnFriendsGiftPopulCollectPart1";

	// Token: 0x0400282D RID: 10285
	public const string onProfileMessageClosed = "OnProfileMessageClosed";

	// Token: 0x0400282E RID: 10286
	public const string onContinueToSendSimpleMessage = "OnContinueToSendSimpleMessage";

	// Token: 0x0400282F RID: 10287
	public const string onBackendRequestSendMessageSuccess = "OnBackendRequestSendMessageSuccess";

	// Token: 0x04002830 RID: 10288
	public const string onBackendRequestSendMessageException = "OnBackendRequestSendMessageException";

	// Token: 0x04002831 RID: 10289
	public const string onFriendsMessageConsume = "OnFriendsMessageConsume";

	// Token: 0x04002832 RID: 10290
	public const string onBackendRequestConsumeMessageSuccess = "OnBackendRequestConsumeMessageSuccess";

	// Token: 0x04002833 RID: 10291
	public const string onBackendRequestConsumeMessageException = "OnBackendRequestConsumeMessageException";

	// Token: 0x04002834 RID: 10292
	public const string onBackendRequestSendGiftCardSuccess = "OnBackendRequestSendGiftCardSuccess";

	// Token: 0x04002835 RID: 10293
	public const string onBackendRequestSendGiftCardException = "OnBackendRequestSendGiftCardException";

	// Token: 0x04002836 RID: 10294
	public const string onFriendsGiftPopulCollectPart2 = "OnFriendsGiftPopulCollectPart2";

	// Token: 0x04002837 RID: 10295
	public const string onBackendRequestBreakCardSuccess = "OnBackendRequestBreakCardSuccess";

	// Token: 0x04002838 RID: 10296
	public const string onBackendRequestBreakCardException = "OnBackendRequestBreakCardException";

	// Token: 0x04002839 RID: 10297
	public const string onCardUpgradeContinueToPurchasingScreen = "OnCardUpgradeContinueToPurchasingScreen";

	// Token: 0x0400283A RID: 10298
	public const string onBackendGetFriendMessagingHistorySuccess = "OnBackendGetFriendMessagingHistorySuccess";

	// Token: 0x0400283B RID: 10299
	public const string onBackendGetFriendMessagingHistoryException = "OnBackendGetFriendMessagingHistoryException";

	// Token: 0x0400283C RID: 10300
	public List<Image> blurredPreviews;

	// Token: 0x0400283D RID: 10301
	public List<Image> gradientsTop;

	// Token: 0x0400283E RID: 10302
	public List<Image> gradientsBottom;

	// Token: 0x0400283F RID: 10303
	public GameObject mainGradientBottom;

	// Token: 0x04002840 RID: 10304
	public GameObject mainGradientBottom1;

	// Token: 0x04002841 RID: 10305
	public RectTransform mainScrollViewPort;

	// Token: 0x04002842 RID: 10306
	public List<Canvas> lobbyCanvases = new List<Canvas>();

	// Token: 0x04002843 RID: 10307
	public List<Camera> lobbyCameras = new List<Camera>();

	// Token: 0x04002844 RID: 10308
	public TextMeshProUGUI credoText;

	// Token: 0x04002845 RID: 10309
	public TextMeshProUGUI loveText;

	// Token: 0x04002846 RID: 10310
	public TextMeshProUGUI completedStories;

	// Token: 0x04002847 RID: 10311
	public TextMeshProUGUI ongoingStories;

	// Token: 0x04002848 RID: 10312
	public TextMeshProUGUI notStartedStories;

	// Token: 0x04002849 RID: 10313
	public TextMeshProUGUI daysStrike;

	// Token: 0x0400284A RID: 10314
	public TextMeshProUGUI totalChapters;

	// Token: 0x0400284B RID: 10315
	public TextMeshProUGUI creationDate;

	// Token: 0x0400284C RID: 10316
	public TextMeshProUGUI friendsActivityText;

	// Token: 0x0400284D RID: 10317
	public List<Button> editButtons;

	// Token: 0x0400284E RID: 10318
	public SystemBackButtonManager closeButton;

	// Token: 0x0400284F RID: 10319
	public SystemBackButtonManager closeButtonCutscenes;

	// Token: 0x04002850 RID: 10320
	public GameObject viewAnthologyAchievementsButton;

	// Token: 0x04002851 RID: 10321
	public GameObject getMoreCardsButtonMainPage;

	// Token: 0x04002852 RID: 10322
	private BNFCLKNDBLO BMODBEEEABE;

	// Token: 0x04002853 RID: 10323
	private const string JJMNCIKONOM = "OnCutsceneViewAssetBundleFolderInitializeSuccess";

	// Token: 0x04002854 RID: 10324
	private const string IGGENJIOFFH = "OnCutsceneViewAssetsDownloadSuccess";

	// Token: 0x04002855 RID: 10325
	private const string DCFCMEIGOKC = "OnCutsceneViewAssetsDownloadFailed";

	// Token: 0x04002856 RID: 10326
	private const string PBICPKIPJMJ = "OnAllCollectableCardsDownloadSuccess";

	// Token: 0x04002857 RID: 10327
	private const string NAIGDEKIDHA = "OnAllCollectableCardsDownloadFailed";

	// Token: 0x04002858 RID: 10328
	private int NPMNDNEDBGC;

	// Token: 0x04002859 RID: 10329
	private Sprite JOBMFPFIMHM;

	// Token: 0x0400285A RID: 10330
	private bool NEDAFKKJGGK;

	// Token: 0x0400285B RID: 10331
	private bool APMHINNLFBN = true;

	// Token: 0x0400285C RID: 10332
	private int BMMEPHKOLAO;

	// Token: 0x0400285D RID: 10333
	private PMEPALPCEAF LEJIJOAOEBK;

	// Token: 0x0400285E RID: 10334
	private GameObject MHKKGOCMIJI;

	// Token: 0x0400285F RID: 10335
	private bool HHOHNKNPNGB;

	// Token: 0x04002860 RID: 10336
	private bool PKOEGOPHOIH;

	// Token: 0x04002861 RID: 10337
	private bool GKDADKEFCNL;

	// Token: 0x04002862 RID: 10338
	private PMEPALPCEAF PNPEHMLHDPO;

	// Token: 0x04002863 RID: 10339
	private PMEPALPCEAF CAPOPEIGMOB;

	// Token: 0x04002864 RID: 10340
	private PMEPALPCEAF PEDAMIKCMKH;

	// Token: 0x04002865 RID: 10341
	private Coroutine OMBEJHJDJKG;

	// Token: 0x04002866 RID: 10342
	private Coroutine PFFIIOHPJCA;

	// Token: 0x04002867 RID: 10343
	private Coroutine JOCNEKNFKPF;

	// Token: 0x04002868 RID: 10344
	private HKPBEDBPHNJ EPNOBCLPJJO;

	// Token: 0x04002869 RID: 10345
	private string KEIKGFKANOL = "";

	// Token: 0x0400286A RID: 10346
	public static bool profileWindowActive = false;

	// Token: 0x0400286B RID: 10347
	public const string onLiveProfileThemesLoaderStart = "OnLiveProfileThemesLoaderStart";

	// Token: 0x0400286C RID: 10348
	public const string onLiveProfileThemesLoaderStop = "OnLiveProfileThemesLoaderStop";

	// Token: 0x0400286D RID: 10349
	public bool showingCardGiftAnimation;

	// Token: 0x0400286E RID: 10350
	private int GKBMOLFNBOH;

	// Token: 0x0400286F RID: 10351
	private bool FGDEGMOLIDB;

	// Token: 0x04002870 RID: 10352
	private string JLPOBLKCIEL = "";

	// Token: 0x04002871 RID: 10353
	private int PGBNCMDDDBL;

	// Token: 0x04002872 RID: 10354
	private int BOPAAIPGBCA = -1;

	// Token: 0x04002873 RID: 10355
	private string PGGPPCINLMB = "";

	// Token: 0x04002874 RID: 10356
	public static int unlockCardWithSpecialCurrencyResult = 0;

	// Token: 0x04002875 RID: 10357
	public static int upgradeToGiftCardResult = 0;

	// Token: 0x04002876 RID: 10358
	public static int breakCardsResult = 0;

	// Token: 0x04002877 RID: 10359
	public static List<int> breakCardSpecialCurrenciesReward = new List<int>();

	// Token: 0x04002878 RID: 10360
	public static bool expandCollectedCardsByDefault = false;

	// Token: 0x04002879 RID: 10361
	private bool LEBIMELAHBC;

	// Token: 0x0400287A RID: 10362
	public static int selectedHallOfFameLanguageFilter = 0;

	// Token: 0x0400287B RID: 10363
	public static JSONArray backendMessagingHistoryJSONArrayResponse = new JSONArray();

	// Token: 0x0400287C RID: 10364
	public static bool expandBadgesByDefault = false;

	// Token: 0x0400287D RID: 10365
	public int maxShownBadgesItems = 12;

	// Token: 0x0400287E RID: 10366
	private List<string> CMCDBMPPHID = new List<string>();

	// Token: 0x0400287F RID: 10367
	private List<string> KJFPPIKKFEN = new List<string>();

	// Token: 0x04002880 RID: 10368
	private BNFCLKNDBLO PDPJFCHINPN;

	// Token: 0x0200049D RID: 1181
	[CompilerGenerated]
	private sealed class PIKEJAKFJCF
	{
		// Token: 0x06009008 RID: 36872 RVA: 0x003FEEB8 File Offset: 0x003FD0B8
		internal void NIILMOHFHNL()
		{
			this._gameObject.SetActive(false);
		}

		// Token: 0x0400288A RID: 10378
		public GameObject _gameObject;
	}

	// Token: 0x0200049F RID: 1183
	[CompilerGenerated]
	private sealed class PDENALLIHKI
	{
		// Token: 0x06009010 RID: 36880 RVA: 0x003FEF31 File Offset: 0x003FD131
		internal void IPKDHJGJIGF()
		{
			this.<>4__this.OnAnthologyAchievementClick(this.sprite.name);
		}

		// Token: 0x0400288E RID: 10382
		public Sprite sprite;

		// Token: 0x0400288F RID: 10383
		public ProfileItem2 <>4__this;
	}

	// Token: 0x020004A0 RID: 1184
	[CompilerGenerated]
	private sealed class BJLGILLKIEG
	{
		// Token: 0x06009011 RID: 36881 RVA: 0x003FEF49 File Offset: 0x003FD149
		internal bool HAPDOCGFHNK(BNFCLKNDBLO c)
		{
			return c.IAGMLHAEOJI == this.uniqueId;
		}

		// Token: 0x06009013 RID: 36883 RVA: 0x003FEF5C File Offset: 0x003FD15C
		internal void GFJGAFCKLBP()
		{
			this.<>4__this.JHNEGAHMMHM(this.sprite.name);
		}

		// Token: 0x06009014 RID: 36884 RVA: 0x003FEF74 File Offset: 0x003FD174
		internal void DPOILBPHLJM()
		{
			this.<>4__this.OnCutsceneClick(this.cutscene);
		}

		// Token: 0x04002890 RID: 10384
		public string uniqueId;

		// Token: 0x04002891 RID: 10385
		public BNFCLKNDBLO cutscene;

		// Token: 0x04002892 RID: 10386
		public Sprite sprite;

		// Token: 0x04002893 RID: 10387
		public ProfileItem2 <>4__this;
	}

	// Token: 0x020004A1 RID: 1185
	[CompilerGenerated]
	private sealed class KNHOPMKDBFD
	{
		// Token: 0x06009015 RID: 36885 RVA: 0x003FEF87 File Offset: 0x003FD187
		internal void PJGGEDPHPBL()
		{
			this.<>4__this.OMDFILALEDO(this.sprite.name);
		}

		// Token: 0x04002894 RID: 10388
		public Sprite sprite;

		// Token: 0x04002895 RID: 10389
		public ProfileItem2 <>4__this;
	}

	// Token: 0x020004A2 RID: 1186
	[CompilerGenerated]
	private sealed class OKPDIJGNNKK
	{
		// Token: 0x06009017 RID: 36887 RVA: 0x003FEF9F File Offset: 0x003FD19F
		internal void EDPKNJPKFGE()
		{
			this.<>4__this.BICBOMKBJAE(this.sprite.name);
		}

		// Token: 0x04002896 RID: 10390
		public Sprite sprite;

		// Token: 0x04002897 RID: 10391
		public ProfileItem2 <>4__this;
	}

	// Token: 0x020004A3 RID: 1187
	[CompilerGenerated]
	private sealed class FDCBCKMNMEL
	{
		// Token: 0x04002898 RID: 10392
		public ProfileItem2 <>4__this;

		// Token: 0x04002899 RID: 10393
		public PMEPALPCEAF profile;

		// Token: 0x0400289A RID: 10394
		public bool _isOngoing;
	}

	// Token: 0x020004A4 RID: 1188
	[CompilerGenerated]
	private sealed class GKHMJOAFKPB
	{
		// Token: 0x0600901B RID: 36891 RVA: 0x003FEFB7 File Offset: 0x003FD1B7
		internal void ONMENIEKHJN()
		{
			this.CS$<>8__locals1.profile.ABHJFNLICDO(this.myProfileTopMatchEntry, this.CS$<>8__locals1._isOngoing);
		}

		// Token: 0x0600901C RID: 36892 RVA: 0x003FEFDA File Offset: 0x003FD1DA
		internal void PHGPLGABBNL()
		{
			this.CS$<>8__locals1.<>4__this.ECJFBOCMCIL(this.myProfileTopMatchEntry.PFFCLABCNHI);
		}

		// Token: 0x0400289B RID: 10395
		public IMMKFHKEEBF myProfileTopMatchEntry;

		// Token: 0x0400289C RID: 10396
		public ProfileItem2.FDCBCKMNMEL CS$<>8__locals1;
	}

	// Token: 0x020004A5 RID: 1189
	[CompilerGenerated]
	private sealed class IEBPEDEFJMI
	{
		// Token: 0x0600901D RID: 36893 RVA: 0x003FEFF7 File Offset: 0x003FD1F7
		internal void EMLHKOOFAOI()
		{
			this.CS$<>8__locals2.CS$<>8__locals1.<>4__this.AJCIPPBNMIG(this.item, this.CS$<>8__locals2.CS$<>8__locals1.profile, this.CS$<>8__locals2.CS$<>8__locals1._isOngoing);
		}

		// Token: 0x0600901E RID: 36894 RVA: 0x003FF034 File Offset: 0x003FD234
		internal void DMBLINEEPHL()
		{
			this.CS$<>8__locals2.CS$<>8__locals1.<>4__this.ICENGKAIDMP(this.item.transform);
		}

		// Token: 0x0400289D RID: 10397
		public GameObject item;

		// Token: 0x0400289E RID: 10398
		public ProfileItem2.GKHMJOAFKPB CS$<>8__locals2;
	}

	// Token: 0x020004A6 RID: 1190
	[CompilerGenerated]
	private sealed class OAHCJEPIPEJ
	{
		// Token: 0x06009021 RID: 36897 RVA: 0x003FF056 File Offset: 0x003FD256
		internal void DBFHIONAMEI()
		{
			this.<>4__this.MGFBNEAFIKF(this._profile);
		}

		// Token: 0x0400289F RID: 10399
		public ProfileItem2 <>4__this;

		// Token: 0x040028A0 RID: 10400
		public PMEPALPCEAF _profile;
	}

	// Token: 0x020004A7 RID: 1191
	[CompilerGenerated]
	private sealed class HFNLOONJECP
	{
		// Token: 0x06009023 RID: 36899 RVA: 0x003FF069 File Offset: 0x003FD269
		internal void NGDJFKGJDJM()
		{
			this.CS$<>8__locals1.<>4__this.OnBadgeClick(this.sprite.name);
		}

		// Token: 0x040028A1 RID: 10401
		public Sprite sprite;

		// Token: 0x040028A2 RID: 10402
		public ProfileItem2.OAHCJEPIPEJ CS$<>8__locals1;
	}

	// Token: 0x020004A8 RID: 1192
	[CompilerGenerated]
	private sealed class AMJLGCFIOJF
	{
		// Token: 0x06009024 RID: 36900 RVA: 0x003FF086 File Offset: 0x003FD286
		internal void HLNPBBABIJH()
		{
			this.<>4__this.OnBadgeClick(this.sprite.name);
		}

		// Token: 0x040028A3 RID: 10403
		public Sprite sprite;

		// Token: 0x040028A4 RID: 10404
		public ProfileItem2 <>4__this;
	}

	// Token: 0x020004A9 RID: 1193
	[CompilerGenerated]
	private sealed class MKFJNJFDLOM
	{
		// Token: 0x06009027 RID: 36903 RVA: 0x003FF09E File Offset: 0x003FD29E
		internal void HIBBFPMGPCD()
		{
			this.<>4__this.KHCKGMELKLH(this._profile);
		}

		// Token: 0x040028A5 RID: 10405
		public ProfileItem2 <>4__this;

		// Token: 0x040028A6 RID: 10406
		public PMEPALPCEAF _profile;

		// Token: 0x040028A7 RID: 10407
		public UnityAction <>9__1;
	}

	// Token: 0x020004AA RID: 1194
	[CompilerGenerated]
	private sealed class HJGACLMFJNO
	{
		// Token: 0x06009028 RID: 36904 RVA: 0x003FF0B1 File Offset: 0x003FD2B1
		internal void HLEEDGJHHCG()
		{
			this.CS$<>8__locals1.<>4__this.OnCardClickFromMyProfile(this.id);
		}

		// Token: 0x040028A8 RID: 10408
		public int id;

		// Token: 0x040028A9 RID: 10409
		public ProfileItem2.MKFJNJFDLOM CS$<>8__locals1;
	}

	// Token: 0x020004AB RID: 1195
	[CompilerGenerated]
	private sealed class EPHEOAALAGE
	{
		// Token: 0x0600902B RID: 36907 RVA: 0x003FF0C9 File Offset: 0x003FD2C9
		internal void CHPODNKCCJN()
		{
			this.<>4__this.OnCardClickFromMyProfile(this.id);
		}

		// Token: 0x040028AA RID: 10410
		public int id;

		// Token: 0x040028AB RID: 10411
		public ProfileItem2 <>4__this;
	}

	// Token: 0x020004AC RID: 1196
	[CompilerGenerated]
	private sealed class NEKICFCBOKH
	{
		// Token: 0x0600902C RID: 36908 RVA: 0x003FF0DC File Offset: 0x003FD2DC
		internal void NAEIHOEPENC()
		{
			this.<>4__this.OnWishedCardClickFromMyProfile(this.id);
		}

		// Token: 0x040028AC RID: 10412
		public int id;

		// Token: 0x040028AD RID: 10413
		public ProfileItem2 <>4__this;
	}

	// Token: 0x020004AD RID: 1197
	[CompilerGenerated]
	private sealed class CJKJBHCMAFA
	{
		// Token: 0x0600902E RID: 36910 RVA: 0x003FF0EF File Offset: 0x003FD2EF
		internal void EKHOEHLNPME()
		{
			this.<>4__this.OnTradingCardClickFromMyProfile(this.id);
		}

		// Token: 0x040028AE RID: 10414
		public int id;

		// Token: 0x040028AF RID: 10415
		public ProfileItem2 <>4__this;
	}

	// Token: 0x020004AE RID: 1198
	[CompilerGenerated]
	private sealed class MMBICHECIDA
	{
		// Token: 0x06009030 RID: 36912 RVA: 0x003FF102 File Offset: 0x003FD302
		internal void HJNAHNHNCNF()
		{
			this.<>4__this.OnAchievementClick(this.profileAchievement);
		}

		// Token: 0x040028B0 RID: 10416
		public FHAJAGIMLLJ profileAchievement;

		// Token: 0x040028B1 RID: 10417
		public ProfileItem2 <>4__this;
	}

	// Token: 0x020004AF RID: 1199
	[CompilerGenerated]
	private sealed class LHJBOGNCIDL
	{
		// Token: 0x06009033 RID: 36915 RVA: 0x003FF115 File Offset: 0x003FD315
		internal void HGHOIEKPKBM()
		{
			this.<>4__this.OnAnthologyAchievementClick(this.achievementId);
		}

		// Token: 0x040028B2 RID: 10418
		public string achievementId;

		// Token: 0x040028B3 RID: 10419
		public ProfileItem2 <>4__this;
	}

	// Token: 0x020004B0 RID: 1200
	[CompilerGenerated]
	private sealed class CNHECPNLJKB
	{
		// Token: 0x06009035 RID: 36917 RVA: 0x003FF128 File Offset: 0x003FD328
		internal void MBLKFKBCINB()
		{
			this.<>4__this.OnAnthologyAchievementClick(this.achievementId);
		}

		// Token: 0x040028B4 RID: 10420
		public string achievementId;

		// Token: 0x040028B5 RID: 10421
		public ProfileItem2 <>4__this;
	}

	// Token: 0x020004B6 RID: 1206
	[CompilerGenerated]
	private sealed class FCDIJCKPKCC
	{
		// Token: 0x06009054 RID: 36948 RVA: 0x003FF658 File Offset: 0x003FD858
		internal void PFBCPHFIMCE()
		{
			this.<>4__this.KJJLNHHFLGC(this.cutscene, this.smallItemCutscene, this.mainCutsceneAnthology);
		}

		// Token: 0x040028C5 RID: 10437
		public ProfileItem2 <>4__this;

		// Token: 0x040028C6 RID: 10438
		public BNFCLKNDBLO cutscene;

		// Token: 0x040028C7 RID: 10439
		public GameObject smallItemCutscene;

		// Token: 0x040028C8 RID: 10440
		public GameObject mainCutsceneAnthology;
	}

	// Token: 0x020004B7 RID: 1207
	[CompilerGenerated]
	private sealed class GANFHPDNPIF
	{
		// Token: 0x06009056 RID: 36950 RVA: 0x003FF677 File Offset: 0x003FD877
		internal bool OLEENIECKPI(BNFCLKNDBLO c)
		{
			return c.AMKCLHLIIMN == this.cutscene.AMKCLHLIIMN;
		}

		// Token: 0x040028C9 RID: 10441
		public BNFCLKNDBLO cutscene;
	}

	// Token: 0x020004B9 RID: 1209
	[CompilerGenerated]
	private sealed class PAOHHKHKLLF
	{
		// Token: 0x0600905E RID: 36958 RVA: 0x003FF6EF File Offset: 0x003FD8EF
		internal void FKIPHHGIFHE()
		{
			this.<>4__this.AMPEDMLBPIM(this.gameObject);
		}

		// Token: 0x06009060 RID: 36960 RVA: 0x003FF6EF File Offset: 0x003FD8EF
		internal void MGCIGOLBHJJ()
		{
			this.<>4__this.AMPEDMLBPIM(this.gameObject);
		}

		// Token: 0x040028CD RID: 10445
		public ProfileItem2 <>4__this;

		// Token: 0x040028CE RID: 10446
		public GameObject gameObject;
	}
}
