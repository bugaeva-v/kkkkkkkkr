using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using DG.Tweening;
using SimpleJSON;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x020002DA RID: 730
public class ContentFriendsPage : MonoBehaviour
{
	// Token: 0x060059D1 RID: 22993 RVA: 0x00287C60 File Offset: 0x00285E60
	private int KDNPGGPJFPC(PMEPALPCEAF ALCIFDBJPPB, ProfileItem2 PCCCLLPKDEF, bool DIBJILIHANI = false)
	{
		this.NCKAIHJMALG = this.HIMEBOFBOEE(this.IJPMLEKMGMA, false);
		this.EMNPICIEEOJ = this.NCKAIHJMALG.Count;
		if (this.EMNPICIEEOJ != 0)
		{
			this.contentFriendsTitle.SetActive(true);
			this.contentFriendsTransform.gameObject.SetActive(true);
			for (int i = 0; i < this.NCKAIHJMALG.Count; i++)
			{
				if (i == this.AAMCCHHBPIJ)
				{
					this.HPIKNGJNPGO(ALCIFDBJPPB, PCCCLLPKDEF, i);
					break;
				}
				this.HPIKNGJNPGO(ALCIFDBJPPB, PCCCLLPKDEF, i);
			}
		}
		return this.EMNPICIEEOJ;
	}

	// Token: 0x060059D2 RID: 22994 RVA: 0x00287CF4 File Offset: 0x00285EF4
	private GameObject CBEINFHEEDD(PMEPALPCEAF ALCIFDBJPPB, ProfileItem2 PCCCLLPKDEF, int PIHMAANLAEM)
	{
		ContentFriendsPage.ECGAMGIIIOE ecgamgiiioe = new ContentFriendsPage.ECGAMGIIIOE();
		ecgamgiiioe.profileItem2 = PCCCLLPKDEF;
		ecgamgiiioe.sortedIncomingFriend = this.NDGNLILNKAB[PIHMAANLAEM];
		ecgamgiiioe.incomingFriendGO = UnityEngine.Object.Instantiate<GameObject>(this.friendItem, this.contentIncomingFriendsTransform);
		ecgamgiiioe.incomingFriendGO.GetComponent<ContentFriendItem>().COCLEMFDEHK(ALCIFDBJPPB, ecgamgiiioe.sortedIncomingFriend, this.ONKONHLJKPG);
		ecgamgiiioe.incomingFriendGO.GetComponent<ContentFriendItem>().showFriendRequestOptionsButton.onClick.AddListener(new UnityAction(ecgamgiiioe.DBNOJBJBDEN));
		ecgamgiiioe.incomingFriendGO.GetComponent<ContentFriendItem>().openCustomProfileButton.onClick.AddListener(new UnityAction(ecgamgiiioe.NDPIDAFCBPH));
		this.MBKKFNGBBEK = PIHMAANLAEM;
		this.KMCDKKHBCCH = ecgamgiiioe.incomingFriendGO;
		return ecgamgiiioe.incomingFriendGO;
	}

	// Token: 0x060059D3 RID: 22995 RVA: 0x00287DB9 File Offset: 0x00285FB9
	public void OnFriendsDataUpdateSuccess()
	{
		this.PopulateContentFriends(this.IJPMLEKMGMA, this.PCCCLLPKDEF);
	}

	// Token: 0x060059D4 RID: 22996 RVA: 0x00287DD0 File Offset: 0x00285FD0
	private void KHCKGMELKLH(PMEPALPCEAF FOKFGMIEEDB)
	{
		ProfileItem2.expandCollectedCardsByDefault = true;
		Vector2 onkonhljkpg = this.PCCCLLPKDEF.CalculateViewportUpDownMargins(this.friendsScrollView);
		Transform transform = this.cards.transform;
		List<int> list = FOKFGMIEEDB.FCCNNMOIMGC();
		for (int i = this.PCCCLLPKDEF.maxShownItems; i < list.Count; i++)
		{
			ContentFriendsPage.JIBFEEODMJA jibfeeodmja = new ContentFriendsPage.JIBFEEODMJA();
			jibfeeodmja.<>4__this = this;
			jibfeeodmja.id = list[i];
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.cardItem, transform);
			gameObject.GetComponent<ContentCardItem>().SetContent(jibfeeodmja.id, FOKFGMIEEDB.GIFPFPOPEJN, onkonhljkpg, false, false);
			gameObject.GetComponent<ContentCardItem>().onCardPressButton.onClick.AddListener(new UnityAction(jibfeeodmja.CHPODNKCCJN));
		}
		this.cardsExpandButton.onClick.RemoveAllListeners();
		this.cardsExpandButton.GetComponent<AnimationPress>().enabled = false;
		this.cardsExpandButton.GetComponent<Button>().enabled = false;
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.cards.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentFriendsSections.GetComponent<RectTransform>());
		this.cardsHiddenTextDropDown.color = new Color(1f, 1f, 1f, 0.25f);
	}

	// Token: 0x060059D5 RID: 22997 RVA: 0x00287F00 File Offset: 0x00286100
	public void BHCCMLJBAGH(PMEPALPCEAF ALCIFDBJPPB, ProfileItem2 PCCCLLPKDEF)
	{
		ContentFriendsPage.MJEFEMJAAIH mjefemjaaih = new ContentFriendsPage.MJEFEMJAAIH();
		mjefemjaaih.<>4__this = this;
		mjefemjaaih.myProfile = ALCIFDBJPPB;
		mjefemjaaih.profileItem2 = PCCCLLPKDEF;
		Vector2 onkonhljkpg = mjefemjaaih.profileItem2.CalculateViewportUpDownMargins(this.friendsScrollView);
		this.cardsHidden.SetActive(true);
		Transform transform = this.cards.transform;
		while (transform.childCount > 0)
		{
			UnityEngine.Object.DestroyImmediate(transform.GetChild(1).gameObject);
		}
		this.cardsHiddenTextDropDown.color = new Color(1074f, 1922f, 1836f, 1723f);
		List<int> list = mjefemjaaih.myProfile.FCCNNMOIMGC();
		if (list.Count != 0)
		{
			this.titleCards.SetActive(true);
			this.cards.SetActive(true);
			for (int i = 1; i < list.Count; i++)
			{
				ContentFriendsPage.OGEDLCCPHDB ogedlccphdb = new ContentFriendsPage.OGEDLCCPHDB();
				ogedlccphdb.CS$<>8__locals1 = mjefemjaaih;
				if (i == ogedlccphdb.CS$<>8__locals1.profileItem2.maxShownItems && !ProfileItem2.expandCollectedCardsByDefault)
				{
					this.cardsHidden.SetActive(false);
					string collectedCardsNoteText = ogedlccphdb.CS$<>8__locals1.profileItem2.GetCollectedCardsNoteText();
					this.cardsHiddenText.SetText(collectedCardsNoteText, true);
					this.cardsHiddenText.text = collectedCardsNoteText;
					this.cardsExpandButton.GetComponent<AnimationPress>().enabled = false;
					this.cardsExpandButton.GetComponent<Button>().enabled = false;
					this.cardsExpandButton.onClick.RemoveAllListeners();
					UnityEvent onClick = this.cardsExpandButton.onClick;
					UnityAction call;
					if ((call = ogedlccphdb.CS$<>8__locals1.<>9__1) == null)
					{
						call = (ogedlccphdb.CS$<>8__locals1.<>9__1 = new UnityAction(ogedlccphdb.CS$<>8__locals1.ELMDNIONNCA));
					}
					onClick.AddListener(call);
					break;
				}
				ogedlccphdb.id = list[i];
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.cardItem, transform);
				gameObject.GetComponent<ContentCardItem>().IPLLLKMPAHE(ogedlccphdb.id, true, onkonhljkpg, true, false);
				gameObject.GetComponent<ContentCardItem>().onCardPressButton.onClick.AddListener(new UnityAction(ogedlccphdb.HEABDNCHIGB));
			}
			if (list.Count >= mjefemjaaih.profileItem2.maxShownItems && ProfileItem2.expandCollectedCardsByDefault)
			{
				this.cardsHidden.SetActive(true);
				string collectedCardsNoteText2 = mjefemjaaih.profileItem2.GetCollectedCardsNoteText();
				this.cardsHiddenText.SetText(collectedCardsNoteText2, false);
				this.cardsHiddenText.text = collectedCardsNoteText2;
				this.cardsExpandButton.onClick.RemoveAllListeners();
				this.cardsExpandButton.GetComponent<AnimationPress>().enabled = true;
				this.cardsExpandButton.GetComponent<Button>().enabled = true;
				this.cardsHiddenTextDropDown.color = new Color(1386f, 780f, 1303f, 1243f);
			}
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.cards.GetComponent<RectTransform>());
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentFriendsSections.GetComponent<RectTransform>());
			return;
		}
		this.titleCards.SetActive(false);
		this.cards.SetActive(false);
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentFriendsSections.GetComponent<RectTransform>());
	}

	// Token: 0x060059D6 RID: 22998 RVA: 0x00288204 File Offset: 0x00286404
	public void PBPIMPHPHCB(Vector2 BNNFJDJACJA)
	{
		if (this.MBKKFNGBBEK < this.FPMGCHMADBD && !this.IANEDCEFMPH && this.KMCDKKHBCCH != null && this.KMCDKKHBCCH.GetComponent<ContentFriendItem>().isVisible)
		{
			this.IANEDCEFMPH = false;
			base.StartCoroutine(this.ELLNICOAOBD());
		}
	}

	// Token: 0x060059D7 RID: 22999 RVA: 0x0028825C File Offset: 0x0028645C
	public void PopulateContentFriends(PMEPALPCEAF ALCIFDBJPPB, ProfileItem2 PCCCLLPKDEF)
	{
		this.JBAICDJCAIB();
		this.IJPMLEKMGMA = ALCIFDBJPPB;
		this.PCCCLLPKDEF = PCCCLLPKDEF;
		this.friendsScrollView.GetComponent<ScrollRect>().verticalNormalizedPosition = 1f;
		this.friendsScrollView.GetComponent<ScrollRect>().onValueChanged.AddListener(new UnityAction<Vector2>(this.ContinueToPopulateIncomingFriends));
		this.friendsScrollView.GetComponent<ScrollRect>().onValueChanged.AddListener(new UnityAction<Vector2>(this.ContinueToPopulateFriends));
		this.ONKONHLJKPG = PCCCLLPKDEF.CalculateViewportUpDownMargins(this.friendsScrollView);
		PCCCLLPKDEF.PopulateHeaderContent(ALCIFDBJPPB);
		this.friendsPlus.SetActive(AKLFPGMDKLA.EHBBFMCILPC.EFMGLPMIPON());
		this.friendsOutOfDate.SetActive(ALCIFDBJPPB.JNNBNNDOGIM.GLAIBIGFBFN());
		this.FBANLLKPEBL(ALCIFDBJPPB, PCCCLLPKDEF);
		this.KDNPGGPJFPC(ALCIFDBJPPB, PCCCLLPKDEF, false);
		this.UpdateIncommingGifts(ALCIFDBJPPB);
		this.UpdateReceivedGifts(ALCIFDBJPPB);
		this.PopulateCardsOnFriends(ALCIFDBJPPB, PCCCLLPKDEF);
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentIncomingFriendsTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentFriendsTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentFriendsSections.GetComponent<RectTransform>());
		this.resetSearchButton.SetActive(false);
	}

	// Token: 0x060059D8 RID: 23000 RVA: 0x0028837C File Offset: 0x0028657C
	private void AEKCPCJCBAH()
	{
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.EHBBFMCILPC.PDJKPFLHFLO(KDCJJBLGCBH.EHBBFMCILPC.DIAIFAMFPBK());
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
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnFriendsPlusUnlockContinueToPurchasingScreen", 0f);
		CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().ShowAndPurchaseProduct(KDCJJBLGCBH.EHBBFMCILPC.DIAIFAMFPBK(), true);
	}

	// Token: 0x060059D9 RID: 23001 RVA: 0x00288428 File Offset: 0x00286628
	public void RefreshContentFriendsOnDeleteFriend(GameObject MPFPIOLDJEL)
	{
		this.NCKAIHJMALG = this.HIMEBOFBOEE(this.IJPMLEKMGMA, false);
		UnityEngine.Object.DestroyImmediate(MPFPIOLDJEL);
		if (this.IJPMLEKMGMA.JNNBNNDOGIM.KODOBGDHBFI.Count == 0)
		{
			this.contentFriendsTitle.SetActive(false);
			this.contentFriendsTransform.gameObject.SetActive(false);
		}
		else
		{
			this.CEFGNLEOLDO = this.contentFriendsTransform.GetChild(this.contentFriendsTransform.childCount - 1).gameObject;
			this.DOHNJHCFFLH = this.CEFGNLEOLDO.transform.GetSiblingIndex();
		}
		this.PCCCLLPKDEF.avatarHeader.UpdateFriendsCount();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentIncomingFriendsTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentFriendsTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentFriendsSections.GetComponent<RectTransform>());
		this.ContinueToPopulateFriends(Vector2.zero);
	}

	// Token: 0x060059DA RID: 23002 RVA: 0x00288508 File Offset: 0x00286708
	private void IKBNDABBFGD()
	{
		AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.JNNBNNDOGIM.GDMLKGHFNAF();
		this.GBGPLOCBFCA();
	}

	// Token: 0x060059DB RID: 23003 RVA: 0x00288524 File Offset: 0x00286724
	public int OAFFLHJMCFI(PMEPALPCEAF ALCIFDBJPPB, PMEPALPCEAF FJICHLAKFIG)
	{
		ContentFriendsPage.KDONEBFCIEE kdonebfciee = new ContentFriendsPage.KDONEBFCIEE();
		kdonebfciee.myProfile = ALCIFDBJPPB;
		kdonebfciee.friend = FJICHLAKFIG;
		return kdonebfciee.myProfile.JNNBNNDOGIM.KODOBGDHBFI.OrderByDescending(new Func<PMEPALPCEAF, bool>(kdonebfciee.AHGNPLCGBPP)).ThenByDescending(new Func<PMEPALPCEAF, int>(ContentFriendsPage.<>c.<>9.JLAIEGELOMN)).ToList<PMEPALPCEAF>().FindIndex(new Predicate<PMEPALPCEAF>(kdonebfciee.GCCOCFDPEEN));
	}

	// Token: 0x060059DC RID: 23004 RVA: 0x002885A0 File Offset: 0x002867A0
	public void IGIDHMNGMOD()
	{
		PurchaseManagerBridge.OOGPALHPNGM().DOMEKEJELKB().Initialize();
		if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.en && GeoLocationManager.NHMHNIFIOCO() && KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA())
		{
			this.ILFHNDFMECM();
			return;
		}
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.KBDILECOEPO));
	}

	// Token: 0x060059DD RID: 23005 RVA: 0x00003E52 File Offset: 0x00002052
	public void OnFriendPlusUpgradeCancel()
	{
	}

	// Token: 0x060059DE RID: 23006 RVA: 0x002885FE File Offset: 0x002867FE
	private void LOLHMPPKGNI()
	{
		AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.JNNBNNDOGIM.GDMLKGHFNAF();
		this.OnFriendsDataUpdateSuccess();
	}

	// Token: 0x060059DF RID: 23007 RVA: 0x0028861A File Offset: 0x0028681A
	private IEnumerator GLGLLBBNGLO()
	{
		FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.socFeatrs.ToString(), FFPHBMFGCNN.profUpdFriends.ToString(), "", false, false);
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithProgress(96);
		AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.JNNBNNDOGIM.CLODNMBHLLI = new JSONArray();
		for (int i = 0; i < AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.JNNBNNDOGIM.KODOBGDHBFI.Count; i += KDCJJBLGCBH.EHBBFMCILPC.FKBONEFEDCC())
		{
			if (i < AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.JNNBNNDOGIM.KODOBGDHBFI.Count)
			{
				JSONArray jsonarray = new JSONArray();
				SceneLobbyManager2.doNotUpdatePercent = true;
				float num = (float)(i + KDCJJBLGCBH.EHBBFMCILPC.FKBONEFEDCC()) / (float)AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.JNNBNNDOGIM.KODOBGDHBFI.Count;
				if (num > 1f)
				{
					num = 1f;
				}
				CommonUserInterface.EHBBFMCILPC.UpdateConnectionAnimationProgress((num * 100f).ToString("0") + "%");
				for (int j = i; j < i + KDCJJBLGCBH.EHBBFMCILPC.FKBONEFEDCC(); j++)
				{
					if (j < AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.JNNBNNDOGIM.KODOBGDHBFI.Count && AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.JNNBNNDOGIM.KODOBGDHBFI[j] != null && AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.JNNBNNDOGIM.KODOBGDHBFI[j].LMFCFHMJIFN.Length > 0)
					{
						jsonarray.Add(AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.JNNBNNDOGIM.KODOBGDHBFI[j].LMFCFHMJIFN);
					}
				}
				if (jsonarray.Count > 0)
				{
					this.HKLHJCIHKHC(jsonarray, i + KDCJJBLGCBH.EHBBFMCILPC.FKBONEFEDCC() >= AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.JNNBNNDOGIM.KODOBGDHBFI.Count);
					while (this.BENGMFLHNCC == 1)
					{
						yield return new WaitForSeconds(0.25f);
					}
					if (this.BENGMFLHNCC == 3)
					{
						this.BENGMFLHNCC = 0;
						CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
						SceneLobbyManager2.doNotUpdatePercent = false;
						if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.JNNBNNDOGIM.CLODNMBHLLI.Count > 0)
						{
							this.LOLHMPPKGNI();
						}
						yield break;
					}
					this.BENGMFLHNCC = 0;
				}
			}
		}
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("friendsoutofdatesuccess"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("continue"), new UnityAction(this.LOLHMPPKGNI), new UnityAction(this.LOLHMPPKGNI), DFGILFBGPLN.popupEnergyHint, 0.25f, 28);
		AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.JNNBNNDOGIM.CPADLCDBKOM = false;
		this.friendsOutOfDate.SetActive(AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.JNNBNNDOGIM.GLAIBIGFBFN());
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		SceneLobbyManager2.doNotUpdatePercent = false;
		yield return null;
		yield break;
	}

	// Token: 0x060059E0 RID: 23008 RVA: 0x0028862C File Offset: 0x0028682C
	private void BCHBLFCAKEJ(PMEPALPCEAF FOKFGMIEEDB)
	{
		ProfileItem2.expandCollectedCardsByDefault = true;
		Vector2 onkonhljkpg = this.PCCCLLPKDEF.CalculateViewportUpDownMargins(this.friendsScrollView);
		Transform transform = this.cards.transform;
		List<int> list = FOKFGMIEEDB.FCCNNMOIMGC();
		for (int i = this.PCCCLLPKDEF.maxShownItems; i < list.Count; i += 0)
		{
			ContentFriendsPage.JIBFEEODMJA jibfeeodmja = new ContentFriendsPage.JIBFEEODMJA();
			jibfeeodmja.<>4__this = this;
			jibfeeodmja.id = list[i];
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.cardItem, transform);
			gameObject.GetComponent<ContentCardItem>().AKEEGPFCOGM(jibfeeodmja.id, FOKFGMIEEDB.GIFPFPOPEJN, onkonhljkpg, false, true);
			gameObject.GetComponent<ContentCardItem>().onCardPressButton.onClick.AddListener(new UnityAction(jibfeeodmja.CHPODNKCCJN));
		}
		this.cardsExpandButton.onClick.RemoveAllListeners();
		this.cardsExpandButton.GetComponent<AnimationPress>().enabled = true;
		this.cardsExpandButton.GetComponent<Button>().enabled = true;
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.cards.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentFriendsSections.GetComponent<RectTransform>());
		this.cardsHiddenTextDropDown.color = new Color(983f, 624f, 1797f, 883f);
	}

	// Token: 0x060059E1 RID: 23009 RVA: 0x0028875B File Offset: 0x0028695B
	public void HANIIMIEHDE()
	{
		this.NCILILLDKHO();
	}

	// Token: 0x060059E2 RID: 23010 RVA: 0x00288764 File Offset: 0x00286964
	private int HLMCJEKEJFP(PMEPALPCEAF ALCIFDBJPPB, ProfileItem2 PCCCLLPKDEF, bool DIBJILIHANI = false)
	{
		this.NCKAIHJMALG = this.HIMEBOFBOEE(this.IJPMLEKMGMA, false);
		this.EMNPICIEEOJ = this.NCKAIHJMALG.Count;
		if (this.EMNPICIEEOJ != 0)
		{
			this.contentFriendsTitle.SetActive(true);
			this.contentFriendsTransform.gameObject.SetActive(false);
			for (int i = 0; i < this.NCKAIHJMALG.Count; i++)
			{
				if (i == this.AAMCCHHBPIJ)
				{
					this.HPIKNGJNPGO(ALCIFDBJPPB, PCCCLLPKDEF, i);
					break;
				}
				this.HPIKNGJNPGO(ALCIFDBJPPB, PCCCLLPKDEF, i);
			}
		}
		return this.EMNPICIEEOJ;
	}

	// Token: 0x060059E3 RID: 23011 RVA: 0x002887F8 File Offset: 0x002869F8
	public void ContinueToPopulateFriends(Vector2 BNNFJDJACJA)
	{
		if (this.DOHNJHCFFLH < this.EMNPICIEEOJ && !this.EDIFMEMEOBG && this.CEFGNLEOLDO != null && this.CEFGNLEOLDO.GetComponent<ContentFriendItem>().isVisible)
		{
			this.EDIFMEMEOBG = true;
			base.StartCoroutine(this.KEEPONCJOBN());
		}
	}

	// Token: 0x060059E4 RID: 23012 RVA: 0x00288850 File Offset: 0x00286A50
	private void OnEnable()
	{
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendUpdateFriendsDataSuccess", new UnityAction(this.HDAPGMJAAEK));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendUpdateFriendsDataException", new UnityAction(this.OPGFAAFKGGL));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPurchasingViewLeave", new UnityAction(this.OnPurchasingViewLeave));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnApplicationFocusBasicSyncSuccess", new UnityAction(this.OnApplicationFocusBasicSyncSuccess));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnFriendPlusUpgradeClick", new UnityAction(this.OnFriendPlusUpgradeClick));
	}

	// Token: 0x060059E5 RID: 23013 RVA: 0x00003E52 File Offset: 0x00002052
	private void LDIPBCLENKK()
	{
	}

	// Token: 0x060059E6 RID: 23014 RVA: 0x002888E4 File Offset: 0x00286AE4
	public void JJPGCMFKNLP(Vector2 BNNFJDJACJA)
	{
		if (this.DOHNJHCFFLH < this.EMNPICIEEOJ && !this.EDIFMEMEOBG && this.CEFGNLEOLDO != null && this.CEFGNLEOLDO.GetComponent<ContentFriendItem>().isVisible)
		{
			this.EDIFMEMEOBG = true;
			base.StartCoroutine(this.KEEPONCJOBN());
		}
	}

	// Token: 0x060059E7 RID: 23015 RVA: 0x0028893B File Offset: 0x00286B3B
	public void OnFriendsPlusUpgradeSuccess()
	{
		this.friendsPlus.SetActive(false);
		this.PCCCLLPKDEF.avatarHeader.friendsPlusIcon.SetActive(true);
	}

	// Token: 0x060059E8 RID: 23016 RVA: 0x00288960 File Offset: 0x00286B60
	private int MKMDEJDCAHH(PMEPALPCEAF ALCIFDBJPPB, ProfileItem2 PCCCLLPKDEF, bool DIBJILIHANI = false)
	{
		this.NCKAIHJMALG = this.HIMEBOFBOEE(this.IJPMLEKMGMA, true);
		this.EMNPICIEEOJ = this.NCKAIHJMALG.Count;
		if (this.EMNPICIEEOJ != 0)
		{
			this.contentFriendsTitle.SetActive(true);
			this.contentFriendsTransform.gameObject.SetActive(true);
			for (int i = 0; i < this.NCKAIHJMALG.Count; i += 0)
			{
				if (i == this.AAMCCHHBPIJ)
				{
					this.OEBOMIACJAK(ALCIFDBJPPB, PCCCLLPKDEF, i);
					break;
				}
				this.HPIKNGJNPGO(ALCIFDBJPPB, PCCCLLPKDEF, i);
			}
		}
		return this.EMNPICIEEOJ;
	}

	// Token: 0x060059E9 RID: 23017 RVA: 0x002889F4 File Offset: 0x00286BF4
	private GameObject HJDDELOOCEL(PMEPALPCEAF ALCIFDBJPPB, ProfileItem2 PCCCLLPKDEF, int PIHMAANLAEM)
	{
		ContentFriendsPage.ECGAMGIIIOE ecgamgiiioe = new ContentFriendsPage.ECGAMGIIIOE();
		ecgamgiiioe.profileItem2 = PCCCLLPKDEF;
		ecgamgiiioe.sortedIncomingFriend = this.NDGNLILNKAB[PIHMAANLAEM];
		ecgamgiiioe.incomingFriendGO = UnityEngine.Object.Instantiate<GameObject>(this.friendItem, this.contentIncomingFriendsTransform);
		ecgamgiiioe.incomingFriendGO.GetComponent<ContentFriendItem>().COCLEMFDEHK(ALCIFDBJPPB, ecgamgiiioe.sortedIncomingFriend, this.ONKONHLJKPG);
		ecgamgiiioe.incomingFriendGO.GetComponent<ContentFriendItem>().showFriendRequestOptionsButton.onClick.AddListener(new UnityAction(ecgamgiiioe.DBNOJBJBDEN));
		ecgamgiiioe.incomingFriendGO.GetComponent<ContentFriendItem>().openCustomProfileButton.onClick.AddListener(new UnityAction(ecgamgiiioe.NDPIDAFCBPH));
		this.MBKKFNGBBEK = PIHMAANLAEM;
		this.KMCDKKHBCCH = ecgamgiiioe.incomingFriendGO;
		return ecgamgiiioe.incomingFriendGO;
	}

	// Token: 0x060059EA RID: 23018 RVA: 0x00288ABC File Offset: 0x00286CBC
	public void OFMPJBCOCHL()
	{
		CommonUserInterface.IKNOFBFMPGA().ShowGenericPopup(CCOJBMMKNAP.PLJMLDOCPNM().JCDFHKDNEDH("acd"), CCOJBMMKNAP.OEPENBHJAHO().IPEIONBNIPH("OnApplicationFocusBasicSyncSuccess"), CCOJBMMKNAP.GIOAFDDKKHI().HHLECNIFHCO("chapterrewindhint1"), DFGILFBGPLN.popupIncentAd2Success, 1367f, -56);
	}

	// Token: 0x060059EB RID: 23019 RVA: 0x00288B0C File Offset: 0x00286D0C
	public static string HLJFDCDAIAE()
	{
		OBHDGKFFICI productData = PurchaseManagerBridge.EHBBFMCILPC.PFPKMDAJDBA().GetProductData(KDCJJBLGCBH.EHBBFMCILPC.DIAIFAMFPBK());
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.NACPAKLINNH().IJLAPHFKPMH(KDCJJBLGCBH.EHBBFMCILPC.DIAIFAMFPBK());
		if (productData == null || ocbiopoeenj == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC(" <i>");
			return "top";
		}
		if (ocbiopoeenj.IMKLGJBEMPH())
		{
			return ocbiopoeenj.PKNNPAMOADM();
		}
		return "" + ocbiopoeenj.DMODNDCLGEJ;
	}

	// Token: 0x060059EC RID: 23020 RVA: 0x00288B80 File Offset: 0x00286D80
	private void HIHEDMNMNFM()
	{
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.EHBBFMCILPC.EPNHMLIJCCM(KDCJJBLGCBH.EHBBFMCILPC.DIAIFAMFPBK());
		if (ocbiopoeenj != null)
		{
			ProductThumbnailManager.lastAccessedProductWebLink = ocbiopoeenj.FDMCFAHEELN() + "lastFilter" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		}
		if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.ru && GeoLocationManager.OOCDLFJKLLI() && KDCJJBLGCBH.EHBBFMCILPC.EAMJBDKCDPA())
		{
			CommonUserInterface.IKNOFBFMPGA().GetFader().CMMAMILHPFP(null);
			this.ILFHNDFMECM();
			return;
		}
		AOBJLALDBAA.NMGMNAKLLMI().LPNCDPHNBJK("dceoiv", 270f);
		CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().ShowAndPurchaseProduct(KDCJJBLGCBH.EHBBFMCILPC.DIAIFAMFPBK(), false);
	}

	// Token: 0x060059ED RID: 23021 RVA: 0x00288C29 File Offset: 0x00286E29
	private IEnumerator GKCHOKKKLMF()
	{
		for (int i = this.MBKKFNGBBEK + 1; i < this.NDGNLILNKAB.Count; i++)
		{
			if (i % this.OGIHGJKAMKD == 0 || i == this.NDGNLILNKAB.Count - 1)
			{
				this.JBNOEHKGHDI(this.IJPMLEKMGMA, this.PCCCLLPKDEF, i);
				break;
			}
			this.JBNOEHKGHDI(this.IJPMLEKMGMA, this.PCCCLLPKDEF, i);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentFriendsTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentFriendsSections.GetComponent<RectTransform>());
		yield return null;
		this.IANEDCEFMPH = false;
		yield break;
	}

	// Token: 0x060059EE RID: 23022 RVA: 0x00288C38 File Offset: 0x00286E38
	public void JLJMLMOHJEC(PMEPALPCEAF ALCIFDBJPPB, ProfileItem2 PCCCLLPKDEF)
	{
		ContentFriendsPage.MJEFEMJAAIH mjefemjaaih = new ContentFriendsPage.MJEFEMJAAIH();
		mjefemjaaih.<>4__this = this;
		mjefemjaaih.myProfile = ALCIFDBJPPB;
		mjefemjaaih.profileItem2 = PCCCLLPKDEF;
		Vector2 onkonhljkpg = mjefemjaaih.profileItem2.CalculateViewportUpDownMargins(this.friendsScrollView);
		this.cardsHidden.SetActive(true);
		Transform transform = this.cards.transform;
		while (transform.childCount > 0)
		{
			UnityEngine.Object.DestroyImmediate(transform.GetChild(1).gameObject);
		}
		this.cardsHiddenTextDropDown.color = new Color(545f, 162f, 1137f, 1647f);
		List<int> list = mjefemjaaih.myProfile.FCCNNMOIMGC();
		if (list.Count != 0)
		{
			this.titleCards.SetActive(true);
			this.cards.SetActive(false);
			for (int i = 0; i < list.Count; i += 0)
			{
				ContentFriendsPage.OGEDLCCPHDB ogedlccphdb = new ContentFriendsPage.OGEDLCCPHDB();
				ogedlccphdb.CS$<>8__locals1 = mjefemjaaih;
				if (i == ogedlccphdb.CS$<>8__locals1.profileItem2.maxShownItems && !ProfileItem2.expandCollectedCardsByDefault)
				{
					this.cardsHidden.SetActive(true);
					string collectedCardsNoteText = ogedlccphdb.CS$<>8__locals1.profileItem2.GetCollectedCardsNoteText();
					this.cardsHiddenText.SetText(collectedCardsNoteText, true);
					this.cardsHiddenText.text = collectedCardsNoteText;
					this.cardsExpandButton.GetComponent<AnimationPress>().enabled = false;
					this.cardsExpandButton.GetComponent<Button>().enabled = true;
					this.cardsExpandButton.onClick.RemoveAllListeners();
					UnityEvent onClick = this.cardsExpandButton.onClick;
					UnityAction call;
					if ((call = ogedlccphdb.CS$<>8__locals1.<>9__1) == null)
					{
						call = (ogedlccphdb.CS$<>8__locals1.<>9__1 = new UnityAction(ogedlccphdb.CS$<>8__locals1.ELMDNIONNCA));
					}
					onClick.AddListener(call);
					break;
				}
				ogedlccphdb.id = list[i];
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.cardItem, transform);
				gameObject.GetComponent<ContentCardItem>().NLIKDFIMLNP(ogedlccphdb.id, true, onkonhljkpg, false, true);
				gameObject.GetComponent<ContentCardItem>().onCardPressButton.onClick.AddListener(new UnityAction(ogedlccphdb.HEABDNCHIGB));
			}
			if (list.Count >= mjefemjaaih.profileItem2.maxShownItems && ProfileItem2.expandCollectedCardsByDefault)
			{
				this.cardsHidden.SetActive(true);
				string collectedCardsNoteText2 = mjefemjaaih.profileItem2.GetCollectedCardsNoteText();
				this.cardsHiddenText.SetText(collectedCardsNoteText2, true);
				this.cardsHiddenText.text = collectedCardsNoteText2;
				this.cardsExpandButton.onClick.RemoveAllListeners();
				this.cardsExpandButton.GetComponent<AnimationPress>().enabled = true;
				this.cardsExpandButton.GetComponent<Button>().enabled = false;
				this.cardsHiddenTextDropDown.color = new Color(1242f, 72f, 416f, 576f);
			}
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.cards.GetComponent<RectTransform>());
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentFriendsSections.GetComponent<RectTransform>());
			return;
		}
		this.titleCards.SetActive(true);
		this.cards.SetActive(false);
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentFriendsSections.GetComponent<RectTransform>());
	}

	// Token: 0x060059EF RID: 23023 RVA: 0x0028893B File Offset: 0x00286B3B
	public void MOGEDBNNMEN()
	{
		this.friendsPlus.SetActive(false);
		this.PCCCLLPKDEF.avatarHeader.friendsPlusIcon.SetActive(true);
	}

	// Token: 0x060059F0 RID: 23024 RVA: 0x00288F3C File Offset: 0x0028713C
	private List<PMEPALPCEAF> MDHNLMFCLNE(PMEPALPCEAF ALCIFDBJPPB, bool DIBJILIHANI = false)
	{
		ContentFriendsPage.CJAIDMOKKGH cjaidmokkgh = new ContentFriendsPage.CJAIDMOKKGH();
		cjaidmokkgh.myProfile = ALCIFDBJPPB;
		List<PMEPALPCEAF> source = new List<PMEPALPCEAF>();
		if (DIBJILIHANI)
		{
			source = cjaidmokkgh.myProfile.JNNBNNDOGIM.DIBJILIHANI;
		}
		else
		{
			source = cjaidmokkgh.myProfile.JNNBNNDOGIM.KODOBGDHBFI;
		}
		return source.OrderByDescending(new Func<PMEPALPCEAF, bool>(cjaidmokkgh.PAIDAKCGIJD)).ThenByDescending(new Func<PMEPALPCEAF, int>(ContentFriendsPage.<>c.<>9.EOECOGBMCLL)).ToList<PMEPALPCEAF>();
	}

	// Token: 0x060059F1 RID: 23025 RVA: 0x00288FC0 File Offset: 0x002871C0
	public void OnFriendPlusUpgradeContinueToUnlock()
	{
		PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager().Initialize();
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru && GeoLocationManager.IsRussia() && KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA())
		{
			this.PurchaseProductWeb();
			return;
		}
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.AEKCPCJCBAH));
	}

	// Token: 0x060059F2 RID: 23026 RVA: 0x00289020 File Offset: 0x00287220
	public void SetSiblingIndexInSortedFriendsList(PMEPALPCEAF ALCIFDBJPPB, PMEPALPCEAF FJICHLAKFIG, GameObject MPFPIOLDJEL)
	{
		int siblingIndexInSortedFriendsList = this.GetSiblingIndexInSortedFriendsList(ALCIFDBJPPB, FJICHLAKFIG);
		MPFPIOLDJEL.transform.SetSiblingIndex(siblingIndexInSortedFriendsList);
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentIncomingFriendsTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentFriendsTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentFriendsSections.GetComponent<RectTransform>());
	}

	// Token: 0x060059F3 RID: 23027 RVA: 0x00289074 File Offset: 0x00287274
	private void EGCNICJKDGP()
	{
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.FILDBDMENPG().HLGBFOMMJFE(KDCJJBLGCBH.EHBBFMCILPC.DIAIFAMFPBK());
		if (ocbiopoeenj != null)
		{
			ProductThumbnailManager.lastAccessedProductWebLink = ocbiopoeenj.MBLAIKOOCFH() + "snapundocostp" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		}
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.en && GeoLocationManager.FDJONIACJKC() && KDCJJBLGCBH.EHBBFMCILPC.EAMJBDKCDPA())
		{
			CommonUserInterface.EHBBFMCILPC.GetFader().GLCPCAHKFOB(null);
			this.CAGLJFHFFKN();
			return;
		}
		AOBJLALDBAA.EHBBFMCILPC.CIGLHCJDDPI("PlayerCharacterManager.SetHairComponent() - input is null.", 264f);
		CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().ShowAndPurchaseProduct(KDCJJBLGCBH.EHBBFMCILPC.DIAIFAMFPBK(), false);
	}

	// Token: 0x060059F4 RID: 23028 RVA: 0x00289120 File Offset: 0x00287320
	public void CAGLJFHFFKN()
	{
		OBHDGKFFICI productData = PurchaseManagerBridge.IDMLJFBNHML().MGMDKEJBEPP().GetProductData(KDCJJBLGCBH.EHBBFMCILPC.DIAIFAMFPBK());
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.CAAKHBIFGMG().DCCLKMCBPPJ(KDCJJBLGCBH.EHBBFMCILPC.DIAIFAMFPBK());
		if (productData != null && ocbiopoeenj != null)
		{
			CommonUserInterface.IKNOFBFMPGA().ShowPopupOnlineResources(ocbiopoeenj.DJJCDNDMAGD() + "envs" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 6);
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("collect");
	}

	// Token: 0x060059F5 RID: 23029 RVA: 0x00289192 File Offset: 0x00287392
	public void DHDMOPBMACG()
	{
		this.ECEELEPIPKL(this.IJPMLEKMGMA, this.PCCCLLPKDEF);
	}

	// Token: 0x060059F6 RID: 23030 RVA: 0x002891A6 File Offset: 0x002873A6
	private List<PMEPALPCEAF> FBGLPBGLDHK(PMEPALPCEAF ALCIFDBJPPB)
	{
		return ALCIFDBJPPB.JNNBNNDOGIM.IIMLLCPLKKJ.OrderByDescending(new Func<PMEPALPCEAF, int>(ContentFriendsPage.<>c.<>9.IDLOHJALGBB)).ToList<PMEPALPCEAF>();
	}

	// Token: 0x060059F7 RID: 23031 RVA: 0x002891DC File Offset: 0x002873DC
	private void MLBFIENAELN()
	{
		this.BENGMFLHNCC = 8;
	}

	// Token: 0x060059F8 RID: 23032 RVA: 0x002891E8 File Offset: 0x002873E8
	public static string IKLIBKCPBPD()
	{
		OBHDGKFFICI productData = PurchaseManagerBridge.KMNBCEMEBBD().DOMEKEJELKB().GetProductData(KDCJJBLGCBH.EHBBFMCILPC.DIAIFAMFPBK());
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.FILDBDMENPG().HBLMGBCMBHN(KDCJJBLGCBH.EHBBFMCILPC.DIAIFAMFPBK());
		if (productData == null || ocbiopoeenj == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("\r");
			return "OnAchievementSyncSuccess";
		}
		if (ocbiopoeenj.OKGPIEEOKBM())
		{
			return ocbiopoeenj.ILAPDGNDFGC();
		}
		return "JJJ" + ocbiopoeenj.DMODNDCLGEJ;
	}

	// Token: 0x060059F9 RID: 23033 RVA: 0x0028925C File Offset: 0x0028745C
	private void IJPIIOECDGL()
	{
		try
		{
			if (null != this.incommingGiftsThumbAnimation)
			{
				this.incommingGiftsThumbAnimation.sprite = null;
				if (null != this.incommingGiftsThumbAnimation.GetComponent<ImageFrameAnimation>())
				{
					this.incommingGiftsThumbAnimation.GetComponent<ImageFrameAnimation>().framesSD = null;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060059FA RID: 23034 RVA: 0x002892C0 File Offset: 0x002874C0
	private IEnumerator DINGFMKPCCO()
	{
		ContentFriendsPage.JHDLBKNNNJO jhdlbknnnjo = new ContentFriendsPage.JHDLBKNNNJO(1);
		jhdlbknnnjo.<>4__this = this;
		return jhdlbknnnjo;
	}

	// Token: 0x060059FB RID: 23035 RVA: 0x00003E52 File Offset: 0x00002052
	private void DLHLMEGMKHA()
	{
	}

	// Token: 0x060059FC RID: 23036 RVA: 0x002892D0 File Offset: 0x002874D0
	public void DMGBKFBGAOH(PMEPALPCEAF ALCIFDBJPPB, ProfileItem2 PCCCLLPKDEF)
	{
		ContentFriendsPage.MJEFEMJAAIH mjefemjaaih = new ContentFriendsPage.MJEFEMJAAIH();
		mjefemjaaih.<>4__this = this;
		mjefemjaaih.myProfile = ALCIFDBJPPB;
		mjefemjaaih.profileItem2 = PCCCLLPKDEF;
		Vector2 onkonhljkpg = mjefemjaaih.profileItem2.CalculateViewportUpDownMargins(this.friendsScrollView);
		this.cardsHidden.SetActive(true);
		Transform transform = this.cards.transform;
		while (transform.childCount > 1)
		{
			UnityEngine.Object.DestroyImmediate(transform.GetChild(0).gameObject);
		}
		this.cardsHiddenTextDropDown.color = new Color(410f, 1503f, 969f, 590f);
		List<int> list = mjefemjaaih.myProfile.FCCNNMOIMGC();
		if (list.Count != 0)
		{
			this.titleCards.SetActive(false);
			this.cards.SetActive(true);
			for (int i = 1; i < list.Count; i += 0)
			{
				ContentFriendsPage.OGEDLCCPHDB ogedlccphdb = new ContentFriendsPage.OGEDLCCPHDB();
				ogedlccphdb.CS$<>8__locals1 = mjefemjaaih;
				if (i == ogedlccphdb.CS$<>8__locals1.profileItem2.maxShownItems && !ProfileItem2.expandCollectedCardsByDefault)
				{
					this.cardsHidden.SetActive(true);
					string collectedCardsNoteText = ogedlccphdb.CS$<>8__locals1.profileItem2.GetCollectedCardsNoteText();
					this.cardsHiddenText.SetText(collectedCardsNoteText, false);
					this.cardsHiddenText.text = collectedCardsNoteText;
					this.cardsExpandButton.GetComponent<AnimationPress>().enabled = true;
					this.cardsExpandButton.GetComponent<Button>().enabled = true;
					this.cardsExpandButton.onClick.RemoveAllListeners();
					UnityEvent onClick = this.cardsExpandButton.onClick;
					UnityAction call;
					if ((call = ogedlccphdb.CS$<>8__locals1.<>9__1) == null)
					{
						call = (ogedlccphdb.CS$<>8__locals1.<>9__1 = new UnityAction(ogedlccphdb.CS$<>8__locals1.ELMDNIONNCA));
					}
					onClick.AddListener(call);
					break;
				}
				ogedlccphdb.id = list[i];
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.cardItem, transform);
				gameObject.GetComponent<ContentCardItem>().IPLLLKMPAHE(ogedlccphdb.id, true, onkonhljkpg, true, true);
				gameObject.GetComponent<ContentCardItem>().onCardPressButton.onClick.AddListener(new UnityAction(ogedlccphdb.HEABDNCHIGB));
			}
			if (list.Count >= mjefemjaaih.profileItem2.maxShownItems && ProfileItem2.expandCollectedCardsByDefault)
			{
				this.cardsHidden.SetActive(false);
				string collectedCardsNoteText2 = mjefemjaaih.profileItem2.GetCollectedCardsNoteText();
				this.cardsHiddenText.SetText(collectedCardsNoteText2, true);
				this.cardsHiddenText.text = collectedCardsNoteText2;
				this.cardsExpandButton.onClick.RemoveAllListeners();
				this.cardsExpandButton.GetComponent<AnimationPress>().enabled = true;
				this.cardsExpandButton.GetComponent<Button>().enabled = false;
				this.cardsHiddenTextDropDown.color = new Color(1666f, 1119f, 669f, 36f);
			}
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.cards.GetComponent<RectTransform>());
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentFriendsSections.GetComponent<RectTransform>());
			return;
		}
		this.titleCards.SetActive(false);
		this.cards.SetActive(true);
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentFriendsSections.GetComponent<RectTransform>());
	}

	// Token: 0x060059FD RID: 23037 RVA: 0x002895D4 File Offset: 0x002877D4
	public void ICHAOBIKOGH()
	{
		this.KMBBFLFLBBG();
	}

	// Token: 0x060059FE RID: 23038 RVA: 0x002895DC File Offset: 0x002877DC
	public void OnFriendPlusUpgradeClick()
	{
		string text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("friendsplusdetailsbody");
		text = text.Replace("XXX", ContentFriendsPage.GetLocalizedCostData());
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("friendsplusdetailstitle"), text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("friendsplusdetailsbtn"), new UnityAction(this.OnFriendPlusUpgradeContinueToUnlock), new UnityAction(this.OnFriendPlusUpgradeCancel), DFGILFBGPLN.popupQuitConfirm, 0.15f, 28);
		ContentChatPage.showingUpgradeToFriendsPlus = false;
	}

	// Token: 0x060059FF RID: 23039 RVA: 0x0028965C File Offset: 0x0028785C
	public void ContinueToPopulateIncomingFriends(Vector2 BNNFJDJACJA)
	{
		if (this.MBKKFNGBBEK < this.FPMGCHMADBD && !this.IANEDCEFMPH && this.KMCDKKHBCCH != null && this.KMCDKKHBCCH.GetComponent<ContentFriendItem>().isVisible)
		{
			this.IANEDCEFMPH = true;
			base.StartCoroutine(this.GKCHOKKKLMF());
		}
	}

	// Token: 0x06005A00 RID: 23040 RVA: 0x002896B3 File Offset: 0x002878B3
	private IEnumerator ELLNICOAOBD()
	{
		ContentFriendsPage.JENABKNNEHM jenabknnehm = new ContentFriendsPage.JENABKNNEHM(1);
		jenabknnehm.<>4__this = this;
		return jenabknnehm;
	}

	// Token: 0x06005A01 RID: 23041 RVA: 0x002896C4 File Offset: 0x002878C4
	private void DNANKPMNMIF()
	{
		try
		{
			if (null != this.incommingGiftsThumbAnimation)
			{
				this.incommingGiftsThumbAnimation.sprite = null;
				if (null != this.incommingGiftsThumbAnimation.GetComponent<ImageFrameAnimation>())
				{
					this.incommingGiftsThumbAnimation.GetComponent<ImageFrameAnimation>().framesSD = null;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06005A02 RID: 23042 RVA: 0x00289728 File Offset: 0x00287928
	private void NKADPEDEEFD()
	{
		AOBJLALDBAA.CEGAOMEEFBE().BADOPKAOCPE("", new UnityAction(this.AAKHENHCIJI));
		AOBJLALDBAA.EHBBFMCILPC.GNBGEMMDGOJ("assetbundlesketchesdata", new UnityAction(this.OPGFAAFKGGL));
		AOBJLALDBAA.NMGMNAKLLMI().BADOPKAOCPE("gft", new UnityAction(this.JCLHBNBNLJH));
		AOBJLALDBAA.FILDBDMENPG().BADOPKAOCPE("", new UnityAction(this.HGDFIKDKCOM));
		AOBJLALDBAA.CEGAOMEEFBE().GNBGEMMDGOJ(", index:", new UnityAction(this.LMBABHPLIOL));
	}

	// Token: 0x06005A04 RID: 23044 RVA: 0x002897D3 File Offset: 0x002879D3
	public void NCILILLDKHO()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.AFKCCPIMDJH())
		{
			this.OPMJNJOMDDK();
		}
	}

	// Token: 0x06005A05 RID: 23045 RVA: 0x002897E8 File Offset: 0x002879E8
	private void FBANLLKPEBL(PMEPALPCEAF ALCIFDBJPPB, ProfileItem2 PCCCLLPKDEF)
	{
		this.NDGNLILNKAB = this.NJBKDCONEOG(ALCIFDBJPPB);
		this.FPMGCHMADBD = this.NDGNLILNKAB.Count;
		if (this.FPMGCHMADBD != 0)
		{
			this.contentIncomingFriendsTitle.SetActive(true);
			this.contentIncomingFriendsTransform.gameObject.SetActive(true);
			for (int i = 0; i < this.NDGNLILNKAB.Count; i++)
			{
				if (i == this.AAMCCHHBPIJ)
				{
					this.JBNOEHKGHDI(ALCIFDBJPPB, PCCCLLPKDEF, i);
					return;
				}
				this.JBNOEHKGHDI(ALCIFDBJPPB, PCCCLLPKDEF, i);
			}
		}
	}

	// Token: 0x06005A06 RID: 23046 RVA: 0x0028986C File Offset: 0x00287A6C
	private void KBDILECOEPO()
	{
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.EHBBFMCILPC.AOAGHIJNFDL(KDCJJBLGCBH.EHBBFMCILPC.DIAIFAMFPBK());
		if (ocbiopoeenj != null)
		{
			ProductThumbnailManager.lastAccessedProductWebLink = ocbiopoeenj.MBLAIKOOCFH() + "OnSaveSlotsItemClose" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		}
		if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.en && GeoLocationManager.FDJONIACJKC() && KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA())
		{
			CommonUserInterface.EHBBFMCILPC.GetFader().IBJEAPGPELH(null);
			this.ILFHNDFMECM();
			return;
		}
		AOBJLALDBAA.KKPFOJMAONG().CIGLHCJDDPI("", 1162f);
		CommonUserInterface.IKNOFBFMPGA().GetPurchasingViewManager().CGDKCOLDBGD(KDCJJBLGCBH.EHBBFMCILPC.DIAIFAMFPBK(), true);
	}

	// Token: 0x06005A07 RID: 23047 RVA: 0x00289918 File Offset: 0x00287B18
	private List<PMEPALPCEAF> HIMEBOFBOEE(PMEPALPCEAF ALCIFDBJPPB, bool DIBJILIHANI = false)
	{
		ContentFriendsPage.CJAIDMOKKGH cjaidmokkgh = new ContentFriendsPage.CJAIDMOKKGH();
		cjaidmokkgh.myProfile = ALCIFDBJPPB;
		List<PMEPALPCEAF> source = new List<PMEPALPCEAF>();
		if (DIBJILIHANI)
		{
			source = cjaidmokkgh.myProfile.JNNBNNDOGIM.DIBJILIHANI;
		}
		else
		{
			source = cjaidmokkgh.myProfile.JNNBNNDOGIM.KODOBGDHBFI;
		}
		return source.OrderByDescending(new Func<PMEPALPCEAF, bool>(cjaidmokkgh.PAIDAKCGIJD)).ThenByDescending(new Func<PMEPALPCEAF, int>(ContentFriendsPage.<>c.<>9.EOECOGBMCLL)).ToList<PMEPALPCEAF>();
	}

	// Token: 0x06005A08 RID: 23048 RVA: 0x0028999C File Offset: 0x00287B9C
	private GameObject HPIKNGJNPGO(PMEPALPCEAF ALCIFDBJPPB, ProfileItem2 PCCCLLPKDEF, int PIHMAANLAEM)
	{
		ContentFriendsPage.HPDENBFIHJE hpdenbfihje = new ContentFriendsPage.HPDENBFIHJE();
		hpdenbfihje.profileItem2 = PCCCLLPKDEF;
		hpdenbfihje.sortedFriend = this.NCKAIHJMALG[PIHMAANLAEM];
		hpdenbfihje.friendGO = UnityEngine.Object.Instantiate<GameObject>(this.friendItem, this.contentFriendsTransform);
		hpdenbfihje.friendGO.GetComponent<ContentFriendItem>().SetContent(ALCIFDBJPPB, hpdenbfihje.sortedFriend, this.ONKONHLJKPG);
		hpdenbfihje.friendGO.GetComponent<ContentFriendItem>().showFriendRequestOptionsButton.onClick.AddListener(new UnityAction(hpdenbfihje.ABAPBEIGLOC));
		hpdenbfihje.friendGO.GetComponent<ContentFriendItem>().openCustomProfileButton.onClick.AddListener(new UnityAction(hpdenbfihje.IMEJKHKPBND));
		this.DOHNJHCFFLH = PIHMAANLAEM;
		this.CEFGNLEOLDO = hpdenbfihje.friendGO;
		return hpdenbfihje.friendGO;
	}

	// Token: 0x06005A09 RID: 23049 RVA: 0x00003E52 File Offset: 0x00002052
	public void HOAEIKPBAED()
	{
	}

	// Token: 0x06005A0A RID: 23050 RVA: 0x00289A64 File Offset: 0x00287C64
	private void PJCAGMOADBK()
	{
		AOBJLALDBAA.EHBBFMCILPC.PEFKJOKLEDL("socialtradegiftcardmissingtitle", new UnityAction(this.MLBFIENAELN));
		AOBJLALDBAA.CEGAOMEEFBE().BADOPKAOCPE("iat2", new UnityAction(this.OPGFAAFKGGL));
		AOBJLALDBAA.EHBBFMCILPC.EFKNEJFLGED("PurchaseManagerUnity.OnPurchasesFetched(): ", new UnityAction(this.OnPurchasingViewLeave));
		AOBJLALDBAA.AGANFKKBPFO().PEFKJOKLEDL("mini", new UnityAction(this.HGDFIKDKCOM));
		AOBJLALDBAA.NMGMNAKLLMI().EFKNEJFLGED("OnLobbyProfileDataCdnFailed", new UnityAction(this.OnFriendPlusUpgradeClick));
	}

	// Token: 0x06005A0B RID: 23051 RVA: 0x00289AF8 File Offset: 0x00287CF8
	public void BPOADGFCMIO(PMEPALPCEAF ALCIFDBJPPB)
	{
		int num = ALCIFDBJPPB.JNNBNNDOGIM.HGKONIOKMEH();
		if (num > 1)
		{
			this.titleIncommingGifts.SetActive(true);
			this.incommingGifts.SetActive(true);
			this.incommingGiftsThumbAnimation.GetComponent<ImageFrameAnimation>().framesSD = AssetsManager.EHBBFMCILPC.profileDataAsset3.smallGiftSprites.ToArray();
			this.incommingGiftsCountText.text = num.ToString();
		}
		else
		{
			this.titleIncommingGifts.SetActive(true);
			this.incommingGifts.SetActive(false);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentFriendsSections.GetComponent<RectTransform>());
	}

	// Token: 0x06005A0C RID: 23052 RVA: 0x00289B90 File Offset: 0x00287D90
	private void AKFBAPCBKDO(PMEPALPCEAF FOKFGMIEEDB)
	{
		ProfileItem2.expandCollectedCardsByDefault = true;
		Vector2 onkonhljkpg = this.PCCCLLPKDEF.CalculateViewportUpDownMargins(this.friendsScrollView);
		Transform transform = this.cards.transform;
		List<int> list = FOKFGMIEEDB.FCCNNMOIMGC();
		for (int i = this.PCCCLLPKDEF.maxShownItems; i < list.Count; i += 0)
		{
			ContentFriendsPage.JIBFEEODMJA jibfeeodmja = new ContentFriendsPage.JIBFEEODMJA();
			jibfeeodmja.<>4__this = this;
			jibfeeodmja.id = list[i];
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.cardItem, transform);
			gameObject.GetComponent<ContentCardItem>().PKFCOOFBMGI(jibfeeodmja.id, FOKFGMIEEDB.GIFPFPOPEJN, onkonhljkpg, false, false);
			gameObject.GetComponent<ContentCardItem>().onCardPressButton.onClick.AddListener(new UnityAction(jibfeeodmja.CHPODNKCCJN));
		}
		this.cardsExpandButton.onClick.RemoveAllListeners();
		this.cardsExpandButton.GetComponent<AnimationPress>().enabled = false;
		this.cardsExpandButton.GetComponent<Button>().enabled = true;
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.cards.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentFriendsSections.GetComponent<RectTransform>());
		this.cardsHiddenTextDropDown.color = new Color(696f, 575f, 1055f, 1503f);
	}

	// Token: 0x06005A0D RID: 23053 RVA: 0x00289CC0 File Offset: 0x00287EC0
	public void KMELLMLPFIA()
	{
		DPGJIJGOCIC.ANOPFDLPKGC("loop");
		while (this.contentFriendsTransform.childCount > 1)
		{
			UnityEngine.Object.DestroyImmediate(this.contentFriendsTransform.GetChild(1).gameObject);
		}
		if (this.KDNPGGPJFPC(this.IJPMLEKMGMA, this.PCCCLLPKDEF, false) > 1)
		{
			this.resetSearchButton.SetActive(false);
			return;
		}
		this.resetSearchButton.SetActive(false);
	}

	// Token: 0x06005A0E RID: 23054 RVA: 0x00289D2C File Offset: 0x00287F2C
	public void OnFriendsSearchClearFilter()
	{
		DPGJIJGOCIC.ANOPFDLPKGC("OnFriendsSearchClearFilter");
		this.IJPMLEKMGMA.JNNBNNDOGIM.DIBJILIHANI.Clear();
		while (this.contentFriendsTransform.childCount > 0)
		{
			UnityEngine.Object.DestroyImmediate(this.contentFriendsTransform.GetChild(0).gameObject);
		}
		this.KDNPGGPJFPC(this.IJPMLEKMGMA, this.PCCCLLPKDEF, false);
		this.resetSearchButton.SetActive(false);
	}

	// Token: 0x06005A0F RID: 23055 RVA: 0x00289DA0 File Offset: 0x00287FA0
	public void ECEELEPIPKL(PMEPALPCEAF ALCIFDBJPPB, ProfileItem2 PCCCLLPKDEF)
	{
		this.EGGIKAOBCOF();
		this.IJPMLEKMGMA = ALCIFDBJPPB;
		this.PCCCLLPKDEF = PCCCLLPKDEF;
		this.friendsScrollView.GetComponent<ScrollRect>().verticalNormalizedPosition = 1424f;
		this.friendsScrollView.GetComponent<ScrollRect>().onValueChanged.AddListener(new UnityAction<Vector2>(this.PACBBCEFJCB));
		this.friendsScrollView.GetComponent<ScrollRect>().onValueChanged.AddListener(new UnityAction<Vector2>(this.ContinueToPopulateFriends));
		this.ONKONHLJKPG = PCCCLLPKDEF.CalculateViewportUpDownMargins(this.friendsScrollView);
		PCCCLLPKDEF.PopulateHeaderContent(ALCIFDBJPPB);
		this.friendsPlus.SetActive(AKLFPGMDKLA.EHBBFMCILPC.EFMGLPMIPON());
		this.friendsOutOfDate.SetActive(ALCIFDBJPPB.JNNBNNDOGIM.GEALHKBDJPC());
		this.FBANLLKPEBL(ALCIFDBJPPB, PCCCLLPKDEF);
		this.MKMDEJDCAHH(ALCIFDBJPPB, PCCCLLPKDEF, false);
		this.UpdateIncommingGifts(ALCIFDBJPPB);
		this.KFADLADDEDB(ALCIFDBJPPB);
		this.BHCCMLJBAGH(ALCIFDBJPPB, PCCCLLPKDEF);
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentIncomingFriendsTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentFriendsTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentFriendsSections.GetComponent<RectTransform>());
		this.resetSearchButton.SetActive(false);
	}

	// Token: 0x06005A10 RID: 23056 RVA: 0x00289EC0 File Offset: 0x002880C0
	public void OMMIEAMHJLJ()
	{
		PurchaseManagerBridge.FJHKMJPFDNI().DOMEKEJELKB().Initialize();
		if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.ru && GeoLocationManager.NHMHNIFIOCO() && KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA())
		{
			this.CAGLJFHFFKN();
			return;
		}
		CommonUserInterface.IKNOFBFMPGA().GetFader().PACBMBLIGNN(new TweenCallback(this.KBDILECOEPO));
	}

	// Token: 0x06005A11 RID: 23057 RVA: 0x00289F20 File Offset: 0x00288120
	public void PopulateCardsOnFriends(PMEPALPCEAF ALCIFDBJPPB, ProfileItem2 PCCCLLPKDEF)
	{
		ContentFriendsPage.MJEFEMJAAIH mjefemjaaih = new ContentFriendsPage.MJEFEMJAAIH();
		mjefemjaaih.<>4__this = this;
		mjefemjaaih.myProfile = ALCIFDBJPPB;
		mjefemjaaih.profileItem2 = PCCCLLPKDEF;
		Vector2 onkonhljkpg = mjefemjaaih.profileItem2.CalculateViewportUpDownMargins(this.friendsScrollView);
		this.cardsHidden.SetActive(false);
		Transform transform = this.cards.transform;
		while (transform.childCount > 0)
		{
			UnityEngine.Object.DestroyImmediate(transform.GetChild(0).gameObject);
		}
		this.cardsHiddenTextDropDown.color = new Color(1f, 1f, 1f, 1f);
		List<int> list = mjefemjaaih.myProfile.FCCNNMOIMGC();
		if (list.Count != 0)
		{
			this.titleCards.SetActive(true);
			this.cards.SetActive(true);
			for (int i = 0; i < list.Count; i++)
			{
				ContentFriendsPage.OGEDLCCPHDB ogedlccphdb = new ContentFriendsPage.OGEDLCCPHDB();
				ogedlccphdb.CS$<>8__locals1 = mjefemjaaih;
				if (i == ogedlccphdb.CS$<>8__locals1.profileItem2.maxShownItems && !ProfileItem2.expandCollectedCardsByDefault)
				{
					this.cardsHidden.SetActive(true);
					string collectedCardsNoteText = ogedlccphdb.CS$<>8__locals1.profileItem2.GetCollectedCardsNoteText();
					this.cardsHiddenText.SetText(collectedCardsNoteText, true);
					this.cardsHiddenText.text = collectedCardsNoteText;
					this.cardsExpandButton.GetComponent<AnimationPress>().enabled = true;
					this.cardsExpandButton.GetComponent<Button>().enabled = true;
					this.cardsExpandButton.onClick.RemoveAllListeners();
					UnityEvent onClick = this.cardsExpandButton.onClick;
					UnityAction call;
					if ((call = ogedlccphdb.CS$<>8__locals1.<>9__1) == null)
					{
						call = (ogedlccphdb.CS$<>8__locals1.<>9__1 = new UnityAction(ogedlccphdb.CS$<>8__locals1.ELMDNIONNCA));
					}
					onClick.AddListener(call);
					break;
				}
				ogedlccphdb.id = list[i];
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.cardItem, transform);
				gameObject.GetComponent<ContentCardItem>().SetContent(ogedlccphdb.id, false, onkonhljkpg, false, false);
				gameObject.GetComponent<ContentCardItem>().onCardPressButton.onClick.AddListener(new UnityAction(ogedlccphdb.HEABDNCHIGB));
			}
			if (list.Count >= mjefemjaaih.profileItem2.maxShownItems && ProfileItem2.expandCollectedCardsByDefault)
			{
				this.cardsHidden.SetActive(true);
				string collectedCardsNoteText2 = mjefemjaaih.profileItem2.GetCollectedCardsNoteText();
				this.cardsHiddenText.SetText(collectedCardsNoteText2, true);
				this.cardsHiddenText.text = collectedCardsNoteText2;
				this.cardsExpandButton.onClick.RemoveAllListeners();
				this.cardsExpandButton.GetComponent<AnimationPress>().enabled = false;
				this.cardsExpandButton.GetComponent<Button>().enabled = false;
				this.cardsHiddenTextDropDown.color = new Color(1f, 1f, 1f, 0.25f);
			}
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.cards.GetComponent<RectTransform>());
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentFriendsSections.GetComponent<RectTransform>());
			return;
		}
		this.titleCards.SetActive(false);
		this.cards.SetActive(false);
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentFriendsSections.GetComponent<RectTransform>());
	}

	// Token: 0x06005A12 RID: 23058 RVA: 0x0028A224 File Offset: 0x00288424
	public void JBLPCEKMMOE(PMEPALPCEAF ALCIFDBJPPB, ProfileItem2 PCCCLLPKDEF)
	{
		ContentFriendsPage.MJEFEMJAAIH mjefemjaaih = new ContentFriendsPage.MJEFEMJAAIH();
		mjefemjaaih.<>4__this = this;
		mjefemjaaih.myProfile = ALCIFDBJPPB;
		mjefemjaaih.profileItem2 = PCCCLLPKDEF;
		Vector2 onkonhljkpg = mjefemjaaih.profileItem2.CalculateViewportUpDownMargins(this.friendsScrollView);
		this.cardsHidden.SetActive(false);
		Transform transform = this.cards.transform;
		while (transform.childCount > 1)
		{
			UnityEngine.Object.DestroyImmediate(transform.GetChild(1).gameObject);
		}
		this.cardsHiddenTextDropDown.color = new Color(353f, 1873f, 775f, 735f);
		List<int> list = mjefemjaaih.myProfile.FCCNNMOIMGC();
		if (list.Count != 0)
		{
			this.titleCards.SetActive(false);
			this.cards.SetActive(true);
			for (int i = 1; i < list.Count; i++)
			{
				ContentFriendsPage.OGEDLCCPHDB ogedlccphdb = new ContentFriendsPage.OGEDLCCPHDB();
				ogedlccphdb.CS$<>8__locals1 = mjefemjaaih;
				if (i == ogedlccphdb.CS$<>8__locals1.profileItem2.maxShownItems && !ProfileItem2.expandCollectedCardsByDefault)
				{
					this.cardsHidden.SetActive(true);
					string collectedCardsNoteText = ogedlccphdb.CS$<>8__locals1.profileItem2.GetCollectedCardsNoteText();
					this.cardsHiddenText.SetText(collectedCardsNoteText, true);
					this.cardsHiddenText.text = collectedCardsNoteText;
					this.cardsExpandButton.GetComponent<AnimationPress>().enabled = true;
					this.cardsExpandButton.GetComponent<Button>().enabled = true;
					this.cardsExpandButton.onClick.RemoveAllListeners();
					UnityEvent onClick = this.cardsExpandButton.onClick;
					UnityAction call;
					if ((call = ogedlccphdb.CS$<>8__locals1.<>9__1) == null)
					{
						call = (ogedlccphdb.CS$<>8__locals1.<>9__1 = new UnityAction(ogedlccphdb.CS$<>8__locals1.ELMDNIONNCA));
					}
					onClick.AddListener(call);
					break;
				}
				ogedlccphdb.id = list[i];
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.cardItem, transform);
				gameObject.GetComponent<ContentCardItem>().KDDLHGMIPBF(ogedlccphdb.id, true, onkonhljkpg, false, false);
				gameObject.GetComponent<ContentCardItem>().onCardPressButton.onClick.AddListener(new UnityAction(ogedlccphdb.HEABDNCHIGB));
			}
			if (list.Count >= mjefemjaaih.profileItem2.maxShownItems && ProfileItem2.expandCollectedCardsByDefault)
			{
				this.cardsHidden.SetActive(true);
				string collectedCardsNoteText2 = mjefemjaaih.profileItem2.GetCollectedCardsNoteText();
				this.cardsHiddenText.SetText(collectedCardsNoteText2, true);
				this.cardsHiddenText.text = collectedCardsNoteText2;
				this.cardsExpandButton.onClick.RemoveAllListeners();
				this.cardsExpandButton.GetComponent<AnimationPress>().enabled = false;
				this.cardsExpandButton.GetComponent<Button>().enabled = true;
				this.cardsHiddenTextDropDown.color = new Color(1968f, 1569f, 1122f, 1123f);
			}
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.cards.GetComponent<RectTransform>());
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentFriendsSections.GetComponent<RectTransform>());
			return;
		}
		this.titleCards.SetActive(true);
		this.cards.SetActive(false);
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentFriendsSections.GetComponent<RectTransform>());
	}

	// Token: 0x06005A13 RID: 23059 RVA: 0x0028A528 File Offset: 0x00288728
	private void PHKLEJIBAHI(JSONArray NPBPCAPPMEL, bool EFNIEHJKNJK)
	{
		this.BENGMFLHNCC = 1;
		BackendOperationsManager.NPDDBAONMJP().GHDGCOHNCGI(NPBPCAPPMEL, EFNIEHJKNJK, " not found, trying to return any achievement sprite or null.", "OnApplicationRestart");
	}

	// Token: 0x06005A14 RID: 23060 RVA: 0x0028A548 File Offset: 0x00288748
	public void UpdateIncommingGifts(PMEPALPCEAF ALCIFDBJPPB)
	{
		int num = ALCIFDBJPPB.JNNBNNDOGIM.HGKONIOKMEH();
		if (num > 0)
		{
			this.titleIncommingGifts.SetActive(true);
			this.incommingGifts.SetActive(true);
			this.incommingGiftsThumbAnimation.GetComponent<ImageFrameAnimation>().framesSD = AssetsManager.EHBBFMCILPC.profileDataAsset3.smallGiftSprites.ToArray();
			this.incommingGiftsCountText.text = num.ToString();
		}
		else
		{
			this.titleIncommingGifts.SetActive(false);
			this.incommingGifts.SetActive(false);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentFriendsSections.GetComponent<RectTransform>());
	}

	// Token: 0x06005A15 RID: 23061 RVA: 0x0028A5E0 File Offset: 0x002887E0
	public void ILFHNDFMECM()
	{
		OBHDGKFFICI productData = PurchaseManagerBridge.EHBBFMCILPC.DIOJHOIFIIH().GetProductData(KDCJJBLGCBH.EHBBFMCILPC.DIAIFAMFPBK());
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.AGANFKKBPFO().PCBGLNFIPPK(KDCJJBLGCBH.EHBBFMCILPC.DIAIFAMFPBK());
		if (productData != null && ocbiopoeenj != null)
		{
			CommonUserInterface.EHBBFMCILPC.GIFCDFKBBCN(ocbiopoeenj.FDMCFAHEELN() + "favcut" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 0);
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("LobbySearchBar - layout was changed by a native-size pass (anchors ");
	}

	// Token: 0x06005A16 RID: 23062 RVA: 0x0028893B File Offset: 0x00286B3B
	public void EGHOCJHNMNF()
	{
		this.friendsPlus.SetActive(false);
		this.PCCCLLPKDEF.avatarHeader.friendsPlusIcon.SetActive(true);
	}

	// Token: 0x06005A17 RID: 23063 RVA: 0x0028A654 File Offset: 0x00288854
	public void KHODLNMCJDK(PMEPALPCEAF ALCIFDBJPPB, ProfileItem2 PCCCLLPKDEF)
	{
		this.EGGIKAOBCOF();
		this.IJPMLEKMGMA = ALCIFDBJPPB;
		this.PCCCLLPKDEF = PCCCLLPKDEF;
		this.friendsScrollView.GetComponent<ScrollRect>().verticalNormalizedPosition = 1881f;
		this.friendsScrollView.GetComponent<ScrollRect>().onValueChanged.AddListener(new UnityAction<Vector2>(this.GEOMFJPIOMP));
		this.friendsScrollView.GetComponent<ScrollRect>().onValueChanged.AddListener(new UnityAction<Vector2>(this.ContinueToPopulateFriends));
		this.ONKONHLJKPG = PCCCLLPKDEF.CalculateViewportUpDownMargins(this.friendsScrollView);
		PCCCLLPKDEF.PopulateHeaderContent(ALCIFDBJPPB);
		this.friendsPlus.SetActive(AKLFPGMDKLA.EHBBFMCILPC.EFMGLPMIPON());
		this.friendsOutOfDate.SetActive(ALCIFDBJPPB.JNNBNNDOGIM.MBLNPAAFCKP());
		this.FBANLLKPEBL(ALCIFDBJPPB, PCCCLLPKDEF);
		this.KHHJMEMMCML(ALCIFDBJPPB, PCCCLLPKDEF, false);
		this.BPOADGFCMIO(ALCIFDBJPPB);
		this.KEOCEHCCEPD(ALCIFDBJPPB);
		this.DMGBKFBGAOH(ALCIFDBJPPB, PCCCLLPKDEF);
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentIncomingFriendsTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentFriendsTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentFriendsSections.GetComponent<RectTransform>());
		this.resetSearchButton.SetActive(false);
	}

	// Token: 0x06005A18 RID: 23064 RVA: 0x0028A774 File Offset: 0x00288974
	public void MPLCMONMFKG(Vector2 BNNFJDJACJA)
	{
		if (this.MBKKFNGBBEK < this.FPMGCHMADBD && !this.IANEDCEFMPH && this.KMCDKKHBCCH != null && this.KMCDKKHBCCH.GetComponent<ContentFriendItem>().isVisible)
		{
			this.IANEDCEFMPH = true;
			base.StartCoroutine(this.GKCHOKKKLMF());
		}
	}

	// Token: 0x06005A19 RID: 23065 RVA: 0x0028A7CC File Offset: 0x002889CC
	private void OPGFAAFKGGL()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		SceneLobbyManager2.doNotUpdatePercent = false;
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("app42error"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupBackendError, 0f, 28);
		this.BENGMFLHNCC = 3;
	}

	// Token: 0x06005A1A RID: 23066 RVA: 0x0028A831 File Offset: 0x00288A31
	public IEnumerator MPJCGLOJNBP(GameObject MHKKGOCMIJI, PMEPALPCEAF LEJIJOAOEBK, bool DFLFEAPNHCP)
	{
		this.NCKAIHJMALG = this.HIMEBOFBOEE(this.IJPMLEKMGMA, false);
		this.NDGNLILNKAB = this.NJBKDCONEOG(this.IJPMLEKMGMA);
		int num = 0;
		if (this.IJPMLEKMGMA.JNNBNNDOGIM.IIMLLCPLKKJ.Count == 0 && this.IJPMLEKMGMA.JNNBNNDOGIM.KODOBGDHBFI.Count == 1)
		{
			num = 1;
		}
		yield return new WaitForSeconds((float)num);
		this.contentFriendsTitle.SetActive(true);
		this.contentFriendsTransform.gameObject.SetActive(true);
		if (DFLFEAPNHCP)
		{
			int siblingIndexInSortedFriendsList = this.GetSiblingIndexInSortedFriendsList(this.IJPMLEKMGMA, LEJIJOAOEBK);
			if (siblingIndexInSortedFriendsList <= this.DOHNJHCFFLH + 1)
			{
				MHKKGOCMIJI.transform.SetParent(this.contentFriendsTransform);
				this.SetSiblingIndexInSortedFriendsList(this.IJPMLEKMGMA, LEJIJOAOEBK, MHKKGOCMIJI);
				if (siblingIndexInSortedFriendsList == this.DOHNJHCFFLH + 1)
				{
					this.DOHNJHCFFLH = siblingIndexInSortedFriendsList;
					this.CEFGNLEOLDO = MHKKGOCMIJI;
				}
			}
			else
			{
				UnityEngine.Object.DestroyImmediate(MHKKGOCMIJI);
			}
		}
		else
		{
			UnityEngine.Object.DestroyImmediate(MHKKGOCMIJI);
		}
		if (this.IJPMLEKMGMA.JNNBNNDOGIM.IIMLLCPLKKJ.Count == 0)
		{
			this.contentIncomingFriendsTitle.SetActive(false);
			this.contentIncomingFriendsTransform.gameObject.SetActive(false);
		}
		else
		{
			this.KMCDKKHBCCH = this.contentIncomingFriendsTransform.GetChild(this.contentIncomingFriendsTransform.childCount - 1).gameObject;
			this.MBKKFNGBBEK = this.KMCDKKHBCCH.transform.GetSiblingIndex();
		}
		this.PCCCLLPKDEF.avatarHeader.UpdateFriendsCount();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentIncomingFriendsTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentFriendsTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentFriendsSections.GetComponent<RectTransform>());
		this.ContinueToPopulateIncomingFriends(Vector2.zero);
		yield break;
	}

	// Token: 0x06005A1B RID: 23067 RVA: 0x0028A855 File Offset: 0x00288A55
	public void KMBBFLFLBBG()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.AFKCCPIMDJH())
		{
			this.MOGEDBNNMEN();
		}
	}

	// Token: 0x06005A1C RID: 23068 RVA: 0x0028A86C File Offset: 0x00288A6C
	public void NLGMNNJJIDG(PMEPALPCEAF ALCIFDBJPPB, ProfileItem2 PCCCLLPKDEF)
	{
		this.JBAICDJCAIB();
		this.IJPMLEKMGMA = ALCIFDBJPPB;
		this.PCCCLLPKDEF = PCCCLLPKDEF;
		this.friendsScrollView.GetComponent<ScrollRect>().verticalNormalizedPosition = 482f;
		this.friendsScrollView.GetComponent<ScrollRect>().onValueChanged.AddListener(new UnityAction<Vector2>(this.MPLCMONMFKG));
		this.friendsScrollView.GetComponent<ScrollRect>().onValueChanged.AddListener(new UnityAction<Vector2>(this.ContinueToPopulateFriends));
		this.ONKONHLJKPG = PCCCLLPKDEF.CalculateViewportUpDownMargins(this.friendsScrollView);
		PCCCLLPKDEF.PopulateHeaderContent(ALCIFDBJPPB);
		this.friendsPlus.SetActive(AKLFPGMDKLA.EHBBFMCILPC.EFMGLPMIPON());
		this.friendsOutOfDate.SetActive(ALCIFDBJPPB.JNNBNNDOGIM.MBLNPAAFCKP());
		this.FBANLLKPEBL(ALCIFDBJPPB, PCCCLLPKDEF);
		this.AJHLOMDDCCJ(ALCIFDBJPPB, PCCCLLPKDEF, false);
		this.UpdateIncommingGifts(ALCIFDBJPPB);
		this.UpdateReceivedGifts(ALCIFDBJPPB);
		this.PMJJLBEPPBP(ALCIFDBJPPB, PCCCLLPKDEF);
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentIncomingFriendsTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentFriendsTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentFriendsSections.GetComponent<RectTransform>());
		this.resetSearchButton.SetActive(false);
	}

	// Token: 0x06005A1D RID: 23069 RVA: 0x0028A98C File Offset: 0x00288B8C
	public void OnPurchasingViewLeave()
	{
		this.CheckForFriendsPlusUpgrade();
	}

	// Token: 0x06005A1E RID: 23070 RVA: 0x0028A994 File Offset: 0x00288B94
	private void NJKJLLPKDNC()
	{
		AOBJLALDBAA.AGANFKKBPFO().FNMOFCMDFJP("OnBackendUpdateFriendsDataException", new UnityAction(this.OODAIJKMDOK));
		AOBJLALDBAA.DBLAIDPICIG().FNMOFCMDFJP("onwishcardclickbody", new UnityAction(this.IFGKMIFOOIP));
		AOBJLALDBAA.NMGMNAKLLMI().MFIMALJPCDP("itemstitle", new UnityAction(this.JCLHBNBNLJH));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP(">", new UnityAction(this.OnApplicationFocusBasicSyncSuccess));
		AOBJLALDBAA.FILDBDMENPG().FNMOFCMDFJP("", new UnityAction(this.OnFriendPlusUpgradeClick));
	}

	// Token: 0x06005A1F RID: 23071 RVA: 0x0028AA28 File Offset: 0x00288C28
	public int GetSiblingIndexInSortedFriendsList(PMEPALPCEAF ALCIFDBJPPB, PMEPALPCEAF FJICHLAKFIG)
	{
		ContentFriendsPage.KDONEBFCIEE kdonebfciee = new ContentFriendsPage.KDONEBFCIEE();
		kdonebfciee.myProfile = ALCIFDBJPPB;
		kdonebfciee.friend = FJICHLAKFIG;
		return kdonebfciee.myProfile.JNNBNNDOGIM.KODOBGDHBFI.OrderByDescending(new Func<PMEPALPCEAF, bool>(kdonebfciee.AHGNPLCGBPP)).ThenByDescending(new Func<PMEPALPCEAF, int>(ContentFriendsPage.<>c.<>9.JLAIEGELOMN)).ToList<PMEPALPCEAF>().FindIndex(new Predicate<PMEPALPCEAF>(kdonebfciee.GCCOCFDPEEN));
	}

	// Token: 0x06005A20 RID: 23072 RVA: 0x0028AAA4 File Offset: 0x00288CA4
	public void PMJJLBEPPBP(PMEPALPCEAF ALCIFDBJPPB, ProfileItem2 PCCCLLPKDEF)
	{
		ContentFriendsPage.MJEFEMJAAIH mjefemjaaih = new ContentFriendsPage.MJEFEMJAAIH();
		mjefemjaaih.<>4__this = this;
		mjefemjaaih.myProfile = ALCIFDBJPPB;
		mjefemjaaih.profileItem2 = PCCCLLPKDEF;
		Vector2 onkonhljkpg = mjefemjaaih.profileItem2.CalculateViewportUpDownMargins(this.friendsScrollView);
		this.cardsHidden.SetActive(true);
		Transform transform = this.cards.transform;
		while (transform.childCount > 1)
		{
			UnityEngine.Object.DestroyImmediate(transform.GetChild(0).gameObject);
		}
		this.cardsHiddenTextDropDown.color = new Color(100f, 62f, 1898f, 1185f);
		List<int> list = mjefemjaaih.myProfile.FCCNNMOIMGC();
		if (list.Count != 0)
		{
			this.titleCards.SetActive(false);
			this.cards.SetActive(true);
			for (int i = 0; i < list.Count; i++)
			{
				ContentFriendsPage.OGEDLCCPHDB ogedlccphdb = new ContentFriendsPage.OGEDLCCPHDB();
				ogedlccphdb.CS$<>8__locals1 = mjefemjaaih;
				if (i == ogedlccphdb.CS$<>8__locals1.profileItem2.maxShownItems && !ProfileItem2.expandCollectedCardsByDefault)
				{
					this.cardsHidden.SetActive(false);
					string collectedCardsNoteText = ogedlccphdb.CS$<>8__locals1.profileItem2.GetCollectedCardsNoteText();
					this.cardsHiddenText.SetText(collectedCardsNoteText, false);
					this.cardsHiddenText.text = collectedCardsNoteText;
					this.cardsExpandButton.GetComponent<AnimationPress>().enabled = false;
					this.cardsExpandButton.GetComponent<Button>().enabled = true;
					this.cardsExpandButton.onClick.RemoveAllListeners();
					UnityEvent onClick = this.cardsExpandButton.onClick;
					UnityAction call;
					if ((call = ogedlccphdb.CS$<>8__locals1.<>9__1) == null)
					{
						call = (ogedlccphdb.CS$<>8__locals1.<>9__1 = new UnityAction(ogedlccphdb.CS$<>8__locals1.ELMDNIONNCA));
					}
					onClick.AddListener(call);
					break;
				}
				ogedlccphdb.id = list[i];
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.cardItem, transform);
				gameObject.GetComponent<ContentCardItem>().CBGIDNBIBAP(ogedlccphdb.id, true, onkonhljkpg, false, false);
				gameObject.GetComponent<ContentCardItem>().onCardPressButton.onClick.AddListener(new UnityAction(ogedlccphdb.HEABDNCHIGB));
			}
			if (list.Count >= mjefemjaaih.profileItem2.maxShownItems && ProfileItem2.expandCollectedCardsByDefault)
			{
				this.cardsHidden.SetActive(true);
				string collectedCardsNoteText2 = mjefemjaaih.profileItem2.GetCollectedCardsNoteText();
				this.cardsHiddenText.SetText(collectedCardsNoteText2, true);
				this.cardsHiddenText.text = collectedCardsNoteText2;
				this.cardsExpandButton.onClick.RemoveAllListeners();
				this.cardsExpandButton.GetComponent<AnimationPress>().enabled = true;
				this.cardsExpandButton.GetComponent<Button>().enabled = true;
				this.cardsHiddenTextDropDown.color = new Color(257f, 725f, 951f, 642f);
			}
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.cards.GetComponent<RectTransform>());
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentFriendsSections.GetComponent<RectTransform>());
			return;
		}
		this.titleCards.SetActive(true);
		this.cards.SetActive(false);
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentFriendsSections.GetComponent<RectTransform>());
	}

	// Token: 0x06005A21 RID: 23073 RVA: 0x002891DC File Offset: 0x002873DC
	private void OODAIJKMDOK()
	{
		this.BENGMFLHNCC = 8;
	}

	// Token: 0x06005A22 RID: 23074 RVA: 0x0028ADA8 File Offset: 0x00288FA8
	private int KHHJMEMMCML(PMEPALPCEAF ALCIFDBJPPB, ProfileItem2 PCCCLLPKDEF, bool DIBJILIHANI = false)
	{
		this.NCKAIHJMALG = this.HIMEBOFBOEE(this.IJPMLEKMGMA, false);
		this.EMNPICIEEOJ = this.NCKAIHJMALG.Count;
		if (this.EMNPICIEEOJ != 0)
		{
			this.contentFriendsTitle.SetActive(true);
			this.contentFriendsTransform.gameObject.SetActive(true);
			for (int i = 1; i < this.NCKAIHJMALG.Count; i += 0)
			{
				if (i == this.AAMCCHHBPIJ)
				{
					this.HPIKNGJNPGO(ALCIFDBJPPB, PCCCLLPKDEF, i);
					break;
				}
				this.JBCJCBCDPDD(ALCIFDBJPPB, PCCCLLPKDEF, i);
			}
		}
		return this.EMNPICIEEOJ;
	}

	// Token: 0x06005A23 RID: 23075 RVA: 0x0028AE39 File Offset: 0x00289039
	private IEnumerator NDHEEFHNBEH()
	{
		ContentFriendsPage.IOGHFJIFOKP ioghfjifokp = new ContentFriendsPage.IOGHFJIFOKP(1);
		ioghfjifokp.<>4__this = this;
		return ioghfjifokp;
	}

	// Token: 0x06005A24 RID: 23076 RVA: 0x0028AE48 File Offset: 0x00289048
	private GameObject JBNOEHKGHDI(PMEPALPCEAF ALCIFDBJPPB, ProfileItem2 PCCCLLPKDEF, int PIHMAANLAEM)
	{
		ContentFriendsPage.ECGAMGIIIOE ecgamgiiioe = new ContentFriendsPage.ECGAMGIIIOE();
		ecgamgiiioe.profileItem2 = PCCCLLPKDEF;
		ecgamgiiioe.sortedIncomingFriend = this.NDGNLILNKAB[PIHMAANLAEM];
		ecgamgiiioe.incomingFriendGO = UnityEngine.Object.Instantiate<GameObject>(this.friendItem, this.contentIncomingFriendsTransform);
		ecgamgiiioe.incomingFriendGO.GetComponent<ContentFriendItem>().SetContent(ALCIFDBJPPB, ecgamgiiioe.sortedIncomingFriend, this.ONKONHLJKPG);
		ecgamgiiioe.incomingFriendGO.GetComponent<ContentFriendItem>().showFriendRequestOptionsButton.onClick.AddListener(new UnityAction(ecgamgiiioe.DBNOJBJBDEN));
		ecgamgiiioe.incomingFriendGO.GetComponent<ContentFriendItem>().openCustomProfileButton.onClick.AddListener(new UnityAction(ecgamgiiioe.NDPIDAFCBPH));
		this.MBKKFNGBBEK = PIHMAANLAEM;
		this.KMCDKKHBCCH = ecgamgiiioe.incomingFriendGO;
		return ecgamgiiioe.incomingFriendGO;
	}

	// Token: 0x06005A25 RID: 23077 RVA: 0x0028A98C File Offset: 0x00288B8C
	public void OnApplicationFocusBasicSyncSuccess()
	{
		this.CheckForFriendsPlusUpgrade();
	}

	// Token: 0x06005A26 RID: 23078 RVA: 0x0028AF10 File Offset: 0x00289110
	private void EGGIKAOBCOF()
	{
		while (this.contentIncomingFriendsTransform.childCount > 1)
		{
			UnityEngine.Object.DestroyImmediate(this.contentIncomingFriendsTransform.GetChild(0).gameObject);
		}
		while (this.contentFriendsTransform.childCount > 1)
		{
			UnityEngine.Object.DestroyImmediate(this.contentFriendsTransform.GetChild(1).gameObject);
		}
		while (this.cards.transform.childCount > 0)
		{
			UnityEngine.Object.DestroyImmediate(this.cards.transform.GetChild(0).gameObject);
		}
	}

	// Token: 0x06005A27 RID: 23079 RVA: 0x0028AF99 File Offset: 0x00289199
	public void GBGPLOCBFCA()
	{
		this.NLGMNNJJIDG(this.IJPMLEKMGMA, this.PCCCLLPKDEF);
	}

	// Token: 0x06005A28 RID: 23080 RVA: 0x0028AFB0 File Offset: 0x002891B0
	public void KEOCEHCCEPD(PMEPALPCEAF ALCIFDBJPPB)
	{
		int num = ALCIFDBJPPB.JNNBNNDOGIM.ILMMFICMALA();
		if (num > 0)
		{
			this.titleReceivedGifts.SetActive(false);
			this.receivedGifts.SetActive(true);
			this.receivedGiftsCountText.text = num.ToString();
		}
		else
		{
			this.titleReceivedGifts.SetActive(false);
			this.receivedGifts.SetActive(false);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentFriendsSections.GetComponent<RectTransform>());
	}

	// Token: 0x06005A29 RID: 23081 RVA: 0x0028B024 File Offset: 0x00289224
	public void LMBABHPLIOL()
	{
		string text = CCOJBMMKNAP.HFAKOKBHCGH().DNILNCLIHAP("OnBackendGetFriendMessagingHistorySuccess");
		text = text.Replace("cnd", ContentFriendsPage.GetLocalizedCostData());
		CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupTwoOverride(CCOJBMMKNAP.JINDKPHNLBK().BGELFMIOBCL("svol"), text, CCOJBMMKNAP.DBFFFOMCLKM().DNILNCLIHAP("ok"), new UnityAction(this.OnFriendPlusUpgradeContinueToUnlock), new UnityAction(this.BKCDMEPKPCM), (DFGILFBGPLN)82, 1032f, -126);
		ContentChatPage.showingUpgradeToFriendsPlus = false;
	}

	// Token: 0x06005A2A RID: 23082 RVA: 0x0028B0A4 File Offset: 0x002892A4
	public void UpdateReceivedGifts(PMEPALPCEAF ALCIFDBJPPB)
	{
		int num = ALCIFDBJPPB.JNNBNNDOGIM.GBNDFAFONBK();
		if (num > 0)
		{
			this.titleReceivedGifts.SetActive(true);
			this.receivedGifts.SetActive(true);
			this.receivedGiftsCountText.text = num.ToString();
		}
		else
		{
			this.titleReceivedGifts.SetActive(false);
			this.receivedGifts.SetActive(false);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentFriendsSections.GetComponent<RectTransform>());
	}

	// Token: 0x06005A2B RID: 23083 RVA: 0x0028B115 File Offset: 0x00289315
	private void AAKHENHCIJI()
	{
		this.BENGMFLHNCC = 1;
	}

	// Token: 0x06005A2C RID: 23084 RVA: 0x0028B120 File Offset: 0x00289320
	private void FNNKONBBDLM(PMEPALPCEAF FOKFGMIEEDB)
	{
		ProfileItem2.expandCollectedCardsByDefault = false;
		Vector2 onkonhljkpg = this.PCCCLLPKDEF.CalculateViewportUpDownMargins(this.friendsScrollView);
		Transform transform = this.cards.transform;
		List<int> list = FOKFGMIEEDB.FCCNNMOIMGC();
		for (int i = this.PCCCLLPKDEF.maxShownItems; i < list.Count; i++)
		{
			ContentFriendsPage.JIBFEEODMJA jibfeeodmja = new ContentFriendsPage.JIBFEEODMJA();
			jibfeeodmja.<>4__this = this;
			jibfeeodmja.id = list[i];
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.cardItem, transform);
			gameObject.GetComponent<ContentCardItem>().FHCPOJJPAKF(jibfeeodmja.id, FOKFGMIEEDB.GIFPFPOPEJN, onkonhljkpg, false, false);
			gameObject.GetComponent<ContentCardItem>().onCardPressButton.onClick.AddListener(new UnityAction(jibfeeodmja.CHPODNKCCJN));
		}
		this.cardsExpandButton.onClick.RemoveAllListeners();
		this.cardsExpandButton.GetComponent<AnimationPress>().enabled = false;
		this.cardsExpandButton.GetComponent<Button>().enabled = false;
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.cards.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentFriendsSections.GetComponent<RectTransform>());
		this.cardsHiddenTextDropDown.color = new Color(380f, 612f, 1196f, 1740f);
	}

	// Token: 0x06005A2D RID: 23085 RVA: 0x0028B250 File Offset: 0x00289450
	public void JLAKFHACENF(PMEPALPCEAF ALCIFDBJPPB, ProfileItem2 PCCCLLPKDEF)
	{
		ContentFriendsPage.MJEFEMJAAIH mjefemjaaih = new ContentFriendsPage.MJEFEMJAAIH();
		mjefemjaaih.<>4__this = this;
		mjefemjaaih.myProfile = ALCIFDBJPPB;
		mjefemjaaih.profileItem2 = PCCCLLPKDEF;
		Vector2 onkonhljkpg = mjefemjaaih.profileItem2.CalculateViewportUpDownMargins(this.friendsScrollView);
		this.cardsHidden.SetActive(false);
		Transform transform = this.cards.transform;
		while (transform.childCount > 0)
		{
			UnityEngine.Object.DestroyImmediate(transform.GetChild(0).gameObject);
		}
		this.cardsHiddenTextDropDown.color = new Color(1270f, 1459f, 610f, 1184f);
		List<int> list = mjefemjaaih.myProfile.FCCNNMOIMGC();
		if (list.Count != 0)
		{
			this.titleCards.SetActive(false);
			this.cards.SetActive(false);
			for (int i = 1; i < list.Count; i++)
			{
				ContentFriendsPage.OGEDLCCPHDB ogedlccphdb = new ContentFriendsPage.OGEDLCCPHDB();
				ogedlccphdb.CS$<>8__locals1 = mjefemjaaih;
				if (i == ogedlccphdb.CS$<>8__locals1.profileItem2.maxShownItems && !ProfileItem2.expandCollectedCardsByDefault)
				{
					this.cardsHidden.SetActive(false);
					string collectedCardsNoteText = ogedlccphdb.CS$<>8__locals1.profileItem2.GetCollectedCardsNoteText();
					this.cardsHiddenText.SetText(collectedCardsNoteText, false);
					this.cardsHiddenText.text = collectedCardsNoteText;
					this.cardsExpandButton.GetComponent<AnimationPress>().enabled = false;
					this.cardsExpandButton.GetComponent<Button>().enabled = true;
					this.cardsExpandButton.onClick.RemoveAllListeners();
					UnityEvent onClick = this.cardsExpandButton.onClick;
					UnityAction call;
					if ((call = ogedlccphdb.CS$<>8__locals1.<>9__1) == null)
					{
						call = (ogedlccphdb.CS$<>8__locals1.<>9__1 = new UnityAction(ogedlccphdb.CS$<>8__locals1.ELMDNIONNCA));
					}
					onClick.AddListener(call);
					break;
				}
				ogedlccphdb.id = list[i];
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.cardItem, transform);
				gameObject.GetComponent<ContentCardItem>().OAACGALMOEG(ogedlccphdb.id, false, onkonhljkpg, true, false);
				gameObject.GetComponent<ContentCardItem>().onCardPressButton.onClick.AddListener(new UnityAction(ogedlccphdb.HEABDNCHIGB));
			}
			if (list.Count >= mjefemjaaih.profileItem2.maxShownItems && ProfileItem2.expandCollectedCardsByDefault)
			{
				this.cardsHidden.SetActive(false);
				string collectedCardsNoteText2 = mjefemjaaih.profileItem2.GetCollectedCardsNoteText();
				this.cardsHiddenText.SetText(collectedCardsNoteText2, false);
				this.cardsHiddenText.text = collectedCardsNoteText2;
				this.cardsExpandButton.onClick.RemoveAllListeners();
				this.cardsExpandButton.GetComponent<AnimationPress>().enabled = true;
				this.cardsExpandButton.GetComponent<Button>().enabled = false;
				this.cardsHiddenTextDropDown.color = new Color(1637f, 932f, 1443f, 1865f);
			}
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.cards.GetComponent<RectTransform>());
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentFriendsSections.GetComponent<RectTransform>());
			return;
		}
		this.titleCards.SetActive(false);
		this.cards.SetActive(false);
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentFriendsSections.GetComponent<RectTransform>());
	}

	// Token: 0x06005A2E RID: 23086 RVA: 0x00003E52 File Offset: 0x00002052
	public void JHHFEMPDLMA()
	{
	}

	// Token: 0x06005A2F RID: 23087 RVA: 0x0028B554 File Offset: 0x00289754
	public void RefreshContentFriendsOnRejectFriend(GameObject MPFPIOLDJEL)
	{
		this.NDGNLILNKAB = this.NJBKDCONEOG(this.IJPMLEKMGMA);
		UnityEngine.Object.DestroyImmediate(MPFPIOLDJEL);
		if (this.IJPMLEKMGMA.JNNBNNDOGIM.IIMLLCPLKKJ.Count == 0)
		{
			this.contentIncomingFriendsTitle.SetActive(false);
			this.contentIncomingFriendsTransform.gameObject.SetActive(false);
		}
		else
		{
			this.KMCDKKHBCCH = this.contentIncomingFriendsTransform.GetChild(this.contentIncomingFriendsTransform.childCount - 1).gameObject;
			this.MBKKFNGBBEK = this.KMCDKKHBCCH.transform.GetSiblingIndex();
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentIncomingFriendsTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentFriendsTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentFriendsSections.GetComponent<RectTransform>());
		this.ContinueToPopulateIncomingFriends(Vector2.zero);
	}

	// Token: 0x06005A30 RID: 23088 RVA: 0x0028B624 File Offset: 0x00289824
	public void GEOMFJPIOMP(Vector2 BNNFJDJACJA)
	{
		if (this.MBKKFNGBBEK < this.FPMGCHMADBD && !this.IANEDCEFMPH && this.KMCDKKHBCCH != null && this.KMCDKKHBCCH.GetComponent<ContentFriendItem>().isVisible)
		{
			this.IANEDCEFMPH = true;
			base.StartCoroutine(this.ELLNICOAOBD());
		}
	}

	// Token: 0x06005A31 RID: 23089 RVA: 0x0028B67C File Offset: 0x0028987C
	private void LDLLCBDGGHN()
	{
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP(" order ", new UnityAction(this.MLBFIENAELN));
		AOBJLALDBAA.FILDBDMENPG().MFIMALJPCDP("", new UnityAction(this.IFGKMIFOOIP));
		AOBJLALDBAA.EHBBFMCILPC.EFKNEJFLGED("Shaders/VideoGlitchCorruptionDigital", new UnityAction(this.OnPurchasingViewLeave));
		AOBJLALDBAA.CEGAOMEEFBE().GNBGEMMDGOJ("Amplitude", new UnityAction(this.HGDFIKDKCOM));
		AOBJLALDBAA.BIAEAOMHBMM().GNBGEMMDGOJ("", new UnityAction(this.OnFriendPlusUpgradeClick));
	}

	// Token: 0x06005A32 RID: 23090 RVA: 0x0028B710 File Offset: 0x00289910
	public void NGNCOJOIDBN(GameObject MPFPIOLDJEL)
	{
		this.NCKAIHJMALG = this.HIMEBOFBOEE(this.IJPMLEKMGMA, true);
		UnityEngine.Object.DestroyImmediate(MPFPIOLDJEL);
		if (this.IJPMLEKMGMA.JNNBNNDOGIM.KODOBGDHBFI.Count == 0)
		{
			this.contentFriendsTitle.SetActive(true);
			this.contentFriendsTransform.gameObject.SetActive(true);
		}
		else
		{
			this.CEFGNLEOLDO = this.contentFriendsTransform.GetChild(this.contentFriendsTransform.childCount - 1).gameObject;
			this.DOHNJHCFFLH = this.CEFGNLEOLDO.transform.GetSiblingIndex();
		}
		this.PCCCLLPKDEF.avatarHeader.HDPBJJONMNK();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentIncomingFriendsTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentFriendsTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentFriendsSections.GetComponent<RectTransform>());
		this.JJPGCMFKNLP(Vector2.zero);
	}

	// Token: 0x06005A33 RID: 23091 RVA: 0x0028B7F0 File Offset: 0x002899F0
	public void CheckForFriendsPlusUpgrade()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.AFKCCPIMDJH())
		{
			this.OnFriendsPlusUpgradeSuccess();
		}
	}

	// Token: 0x06005A34 RID: 23092 RVA: 0x0028B804 File Offset: 0x00289A04
	public void KFADLADDEDB(PMEPALPCEAF ALCIFDBJPPB)
	{
		int num = ALCIFDBJPPB.JNNBNNDOGIM.GBNDFAFONBK();
		if (num > 1)
		{
			this.titleReceivedGifts.SetActive(true);
			this.receivedGifts.SetActive(true);
			this.receivedGiftsCountText.text = num.ToString();
		}
		else
		{
			this.titleReceivedGifts.SetActive(true);
			this.receivedGifts.SetActive(true);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentFriendsSections.GetComponent<RectTransform>());
	}

	// Token: 0x06005A35 RID: 23093 RVA: 0x00288C29 File Offset: 0x00286E29
	private IEnumerator JHLJBFMMFMI()
	{
		for (int i = this.MBKKFNGBBEK + 1; i < this.NDGNLILNKAB.Count; i++)
		{
			if (i % this.OGIHGJKAMKD == 0 || i == this.NDGNLILNKAB.Count - 1)
			{
				this.JBNOEHKGHDI(this.IJPMLEKMGMA, this.PCCCLLPKDEF, i);
				break;
			}
			this.JBNOEHKGHDI(this.IJPMLEKMGMA, this.PCCCLLPKDEF, i);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentFriendsTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentFriendsSections.GetComponent<RectTransform>());
		yield return null;
		this.IANEDCEFMPH = false;
		yield break;
	}

	// Token: 0x06005A36 RID: 23094 RVA: 0x0028B878 File Offset: 0x00289A78
	public void OnUpdateFriendsDataClick()
	{
		this.BENGMFLHNCC = 0;
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("friendsoutofdatetutor"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("no"), new UnityAction(this.BKGGEEBMONN), new UnityAction(this.HPHBOLAIAKG), DFGILFBGPLN.popupQuitConfirm, 0.15f, 28);
	}

	// Token: 0x06005A37 RID: 23095 RVA: 0x0028B8F4 File Offset: 0x00289AF4
	public void OPMJNJOMDDK()
	{
		this.friendsPlus.SetActive(true);
		this.PCCCLLPKDEF.avatarHeader.friendsPlusIcon.SetActive(false);
	}

	// Token: 0x06005A38 RID: 23096 RVA: 0x0028B918 File Offset: 0x00289B18
	public void OnFriendsSearchCardComplete()
	{
		DPGJIJGOCIC.ANOPFDLPKGC("OnFriendsSearchCardComplete");
		while (this.contentFriendsTransform.childCount > 0)
		{
			UnityEngine.Object.DestroyImmediate(this.contentFriendsTransform.GetChild(0).gameObject);
		}
		if (this.KDNPGGPJFPC(this.IJPMLEKMGMA, this.PCCCLLPKDEF, true) > 0)
		{
			this.resetSearchButton.SetActive(true);
			return;
		}
		this.resetSearchButton.SetActive(false);
	}

	// Token: 0x06005A39 RID: 23097 RVA: 0x00003E52 File Offset: 0x00002052
	private void HPHBOLAIAKG()
	{
	}

	// Token: 0x06005A3A RID: 23098 RVA: 0x0028B984 File Offset: 0x00289B84
	public void DHKMAKDMFLF()
	{
		CommonUserInterface.IKNOFBFMPGA().NFBMHHPIGFA(CCOJBMMKNAP.NIOJNOFGIJO().FIENAKIHNOM("socialfriendintro"), CCOJBMMKNAP.AEELGGPEJCC().HPOAGPJFHPM("coddsm"), CCOJBMMKNAP.KLAKLFCOMJC().FCOCLEHKLDJ("OnAccountSignInRequestSuccess"), (DFGILFBGPLN)(-83), 1884f, -121);
	}

	// Token: 0x06005A3B RID: 23099 RVA: 0x0028B9D4 File Offset: 0x00289BD4
	private GameObject MOFLAPIHEEL(PMEPALPCEAF ALCIFDBJPPB, ProfileItem2 PCCCLLPKDEF, int PIHMAANLAEM)
	{
		ContentFriendsPage.ECGAMGIIIOE ecgamgiiioe = new ContentFriendsPage.ECGAMGIIIOE();
		ecgamgiiioe.profileItem2 = PCCCLLPKDEF;
		ecgamgiiioe.sortedIncomingFriend = this.NDGNLILNKAB[PIHMAANLAEM];
		ecgamgiiioe.incomingFriendGO = UnityEngine.Object.Instantiate<GameObject>(this.friendItem, this.contentIncomingFriendsTransform);
		ecgamgiiioe.incomingFriendGO.GetComponent<ContentFriendItem>().COCLEMFDEHK(ALCIFDBJPPB, ecgamgiiioe.sortedIncomingFriend, this.ONKONHLJKPG);
		ecgamgiiioe.incomingFriendGO.GetComponent<ContentFriendItem>().showFriendRequestOptionsButton.onClick.AddListener(new UnityAction(ecgamgiiioe.DBNOJBJBDEN));
		ecgamgiiioe.incomingFriendGO.GetComponent<ContentFriendItem>().openCustomProfileButton.onClick.AddListener(new UnityAction(ecgamgiiioe.NDPIDAFCBPH));
		this.MBKKFNGBBEK = PIHMAANLAEM;
		this.KMCDKKHBCCH = ecgamgiiioe.incomingFriendGO;
		return ecgamgiiioe.incomingFriendGO;
	}

	// Token: 0x06005A3C RID: 23100 RVA: 0x0028BA99 File Offset: 0x00289C99
	private void HKLHJCIHKHC(JSONArray NPBPCAPPMEL, bool EFNIEHJKNJK)
	{
		this.BENGMFLHNCC = 1;
		BackendOperationsManager.EHBBFMCILPC.RequestUpdateUserPublicProfileFriends(NPBPCAPPMEL, EFNIEHJKNJK, "OnBackendUpdateFriendsDataSuccess", "OnBackendUpdateFriendsDataException");
	}

	// Token: 0x06005A3D RID: 23101 RVA: 0x0028BAB8 File Offset: 0x00289CB8
	private void OnDisable()
	{
		this.friendsScrollView.GetComponent<ScrollRect>().onValueChanged.RemoveAllListeners();
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendUpdateFriendsDataSuccess", new UnityAction(this.HDAPGMJAAEK));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendUpdateFriendsDataException", new UnityAction(this.OPGFAAFKGGL));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPurchasingViewLeave", new UnityAction(this.OnPurchasingViewLeave));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnApplicationFocusBasicSyncSuccess", new UnityAction(this.OnApplicationFocusBasicSyncSuccess));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnFriendPlusUpgradeClick", new UnityAction(this.OnFriendPlusUpgradeClick));
	}

	// Token: 0x06005A3E RID: 23102 RVA: 0x0028BB64 File Offset: 0x00289D64
	private void MOHLNGBBIOB()
	{
		try
		{
			if (null != this.incommingGiftsThumbAnimation)
			{
				this.incommingGiftsThumbAnimation.sprite = null;
				if (null != this.incommingGiftsThumbAnimation.GetComponent<ImageFrameAnimation>())
				{
					this.incommingGiftsThumbAnimation.GetComponent<ImageFrameAnimation>().framesSD = null;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06005A3F RID: 23103 RVA: 0x0028BBC8 File Offset: 0x00289DC8
	private void FKAEDFNBODK(PMEPALPCEAF FOKFGMIEEDB)
	{
		ProfileItem2.expandCollectedCardsByDefault = false;
		Vector2 onkonhljkpg = this.PCCCLLPKDEF.CalculateViewportUpDownMargins(this.friendsScrollView);
		Transform transform = this.cards.transform;
		List<int> list = FOKFGMIEEDB.FCCNNMOIMGC();
		for (int i = this.PCCCLLPKDEF.maxShownItems; i < list.Count; i++)
		{
			ContentFriendsPage.JIBFEEODMJA jibfeeodmja = new ContentFriendsPage.JIBFEEODMJA();
			jibfeeodmja.<>4__this = this;
			jibfeeodmja.id = list[i];
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.cardItem, transform);
			gameObject.GetComponent<ContentCardItem>().EOFDLFCFAHB(jibfeeodmja.id, FOKFGMIEEDB.GIFPFPOPEJN, onkonhljkpg, true, false);
			gameObject.GetComponent<ContentCardItem>().onCardPressButton.onClick.AddListener(new UnityAction(jibfeeodmja.CHPODNKCCJN));
		}
		this.cardsExpandButton.onClick.RemoveAllListeners();
		this.cardsExpandButton.GetComponent<AnimationPress>().enabled = false;
		this.cardsExpandButton.GetComponent<Button>().enabled = false;
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.cards.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentFriendsSections.GetComponent<RectTransform>());
		this.cardsHiddenTextDropDown.color = new Color(1866f, 919f, 858f, 649f);
	}

	// Token: 0x06005A40 RID: 23104 RVA: 0x0028BCF8 File Offset: 0x00289EF8
	public void LMAIAEFBAHF()
	{
		DPGJIJGOCIC.ANOPFDLPKGC("OnSketchThumbnailEditTitle");
		this.IJPMLEKMGMA.JNNBNNDOGIM.DIBJILIHANI.Clear();
		while (this.contentFriendsTransform.childCount > 1)
		{
			UnityEngine.Object.DestroyImmediate(this.contentFriendsTransform.GetChild(0).gameObject);
		}
		this.AJHLOMDDCCJ(this.IJPMLEKMGMA, this.PCCCLLPKDEF, false);
		this.resetSearchButton.SetActive(true);
	}

	// Token: 0x06005A41 RID: 23105 RVA: 0x0028A831 File Offset: 0x00288A31
	public IEnumerator FPFCLJFMKFF(GameObject MHKKGOCMIJI, PMEPALPCEAF LEJIJOAOEBK, bool DFLFEAPNHCP)
	{
		this.NCKAIHJMALG = this.HIMEBOFBOEE(this.IJPMLEKMGMA, false);
		this.NDGNLILNKAB = this.NJBKDCONEOG(this.IJPMLEKMGMA);
		int num = 0;
		if (this.IJPMLEKMGMA.JNNBNNDOGIM.IIMLLCPLKKJ.Count == 0 && this.IJPMLEKMGMA.JNNBNNDOGIM.KODOBGDHBFI.Count == 1)
		{
			num = 1;
		}
		yield return new WaitForSeconds((float)num);
		this.contentFriendsTitle.SetActive(true);
		this.contentFriendsTransform.gameObject.SetActive(true);
		if (DFLFEAPNHCP)
		{
			int siblingIndexInSortedFriendsList = this.GetSiblingIndexInSortedFriendsList(this.IJPMLEKMGMA, LEJIJOAOEBK);
			if (siblingIndexInSortedFriendsList <= this.DOHNJHCFFLH + 1)
			{
				MHKKGOCMIJI.transform.SetParent(this.contentFriendsTransform);
				this.SetSiblingIndexInSortedFriendsList(this.IJPMLEKMGMA, LEJIJOAOEBK, MHKKGOCMIJI);
				if (siblingIndexInSortedFriendsList == this.DOHNJHCFFLH + 1)
				{
					this.DOHNJHCFFLH = siblingIndexInSortedFriendsList;
					this.CEFGNLEOLDO = MHKKGOCMIJI;
				}
			}
			else
			{
				UnityEngine.Object.DestroyImmediate(MHKKGOCMIJI);
			}
		}
		else
		{
			UnityEngine.Object.DestroyImmediate(MHKKGOCMIJI);
		}
		if (this.IJPMLEKMGMA.JNNBNNDOGIM.IIMLLCPLKKJ.Count == 0)
		{
			this.contentIncomingFriendsTitle.SetActive(false);
			this.contentIncomingFriendsTransform.gameObject.SetActive(false);
		}
		else
		{
			this.KMCDKKHBCCH = this.contentIncomingFriendsTransform.GetChild(this.contentIncomingFriendsTransform.childCount - 1).gameObject;
			this.MBKKFNGBBEK = this.KMCDKKHBCCH.transform.GetSiblingIndex();
		}
		this.PCCCLLPKDEF.avatarHeader.UpdateFriendsCount();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentIncomingFriendsTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentFriendsTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentFriendsSections.GetComponent<RectTransform>());
		this.ContinueToPopulateIncomingFriends(Vector2.zero);
		yield break;
	}

	// Token: 0x06005A42 RID: 23106 RVA: 0x0028BD6C File Offset: 0x00289F6C
	public void PACBBCEFJCB(Vector2 BNNFJDJACJA)
	{
		if (this.MBKKFNGBBEK < this.FPMGCHMADBD && !this.IANEDCEFMPH && this.KMCDKKHBCCH != null && this.KMCDKKHBCCH.GetComponent<ContentFriendItem>().isVisible)
		{
			this.IANEDCEFMPH = true;
			base.StartCoroutine(this.ELLNICOAOBD());
		}
	}

	// Token: 0x06005A43 RID: 23107 RVA: 0x0028BDC4 File Offset: 0x00289FC4
	public void BCEBPFCDEBF()
	{
		this.BENGMFLHNCC = 0;
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.KLAKLFCOMJC().JLBEIFLLBLO("<b>"), CCOJBMMKNAP.NIOJNOFGIJO().HDIPNMFHIEJ("lsenvattempt"), CCOJBMMKNAP.JMNIGPHCAEJ().BDGPNPNIAPA(""), CCOJBMMKNAP.BBGECIKOICE().MEPECBDCOLG("anthology"), new UnityAction(this.IMGCBIEMGFM), new UnityAction(this.DLHLMEGMKHA), (DFGILFBGPLN)(-65), 524f, -68);
	}

	// Token: 0x06005A44 RID: 23108 RVA: 0x002891A6 File Offset: 0x002873A6
	private List<PMEPALPCEAF> NJBKDCONEOG(PMEPALPCEAF ALCIFDBJPPB)
	{
		return ALCIFDBJPPB.JNNBNNDOGIM.IIMLLCPLKKJ.OrderByDescending(new Func<PMEPALPCEAF, int>(ContentFriendsPage.<>c.<>9.IDLOHJALGBB)).ToList<PMEPALPCEAF>();
	}

	// Token: 0x06005A45 RID: 23109 RVA: 0x0028BE40 File Offset: 0x0028A040
	private void BKGGEEBMONN()
	{
		try
		{
			base.StartCoroutine(this.GLGLLBBNGLO());
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06005A46 RID: 23110 RVA: 0x0028BE74 File Offset: 0x0028A074
	public void AIOENPCDJCK(GameObject MPFPIOLDJEL)
	{
		this.NCKAIHJMALG = this.MDHNLMFCLNE(this.IJPMLEKMGMA, true);
		UnityEngine.Object.DestroyImmediate(MPFPIOLDJEL);
		if (this.IJPMLEKMGMA.JNNBNNDOGIM.KODOBGDHBFI.Count == 0)
		{
			this.contentFriendsTitle.SetActive(false);
			this.contentFriendsTransform.gameObject.SetActive(false);
		}
		else
		{
			this.CEFGNLEOLDO = this.contentFriendsTransform.GetChild(this.contentFriendsTransform.childCount - 1).gameObject;
			this.DOHNJHCFFLH = this.CEFGNLEOLDO.transform.GetSiblingIndex();
		}
		this.PCCCLLPKDEF.avatarHeader.DJEHACCEOGO();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentIncomingFriendsTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentFriendsTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentFriendsSections.GetComponent<RectTransform>());
		this.ContinueToPopulateFriends(Vector2.zero);
	}

	// Token: 0x06005A47 RID: 23111 RVA: 0x0028BF54 File Offset: 0x0028A154
	public void MAONDFAOJNE()
	{
		CommonUserInterface.EHBBFMCILPC.NFBMHHPIGFA(CCOJBMMKNAP.FEEDGKCJBLE().PPALCPINPLK("OnSettingsPopupClose"), CCOJBMMKNAP.JMNIGPHCAEJ().IKMNGFIDCLM(""), CCOJBMMKNAP.FEEDGKCJBLE().HIPJILDCHJC("OnBackendUpdateFriendsDataSuccess"), DFGILFBGPLN.popupInkRevisionMissing, 100f, -113);
	}

	// Token: 0x06005A48 RID: 23112 RVA: 0x0028BFA4 File Offset: 0x0028A1A4
	public void JPOOEJOFBGP()
	{
		DPGJIJGOCIC.ANOPFDLPKGC("dropChancesBalance");
		this.IJPMLEKMGMA.JNNBNNDOGIM.DIBJILIHANI.Clear();
		while (this.contentFriendsTransform.childCount > 1)
		{
			UnityEngine.Object.DestroyImmediate(this.contentFriendsTransform.GetChild(1).gameObject);
		}
		this.HLMCJEKEJFP(this.IJPMLEKMGMA, this.PCCCLLPKDEF, true);
		this.resetSearchButton.SetActive(true);
	}

	// Token: 0x06005A49 RID: 23113 RVA: 0x0028C018 File Offset: 0x0028A218
	private int AJHLOMDDCCJ(PMEPALPCEAF ALCIFDBJPPB, ProfileItem2 PCCCLLPKDEF, bool DIBJILIHANI = false)
	{
		this.NCKAIHJMALG = this.MDHNLMFCLNE(this.IJPMLEKMGMA, true);
		this.EMNPICIEEOJ = this.NCKAIHJMALG.Count;
		if (this.EMNPICIEEOJ != 0)
		{
			this.contentFriendsTitle.SetActive(true);
			this.contentFriendsTransform.gameObject.SetActive(false);
			for (int i = 1; i < this.NCKAIHJMALG.Count; i += 0)
			{
				if (i == this.AAMCCHHBPIJ)
				{
					this.OEBOMIACJAK(ALCIFDBJPPB, PCCCLLPKDEF, i);
					break;
				}
				this.HPIKNGJNPGO(ALCIFDBJPPB, PCCCLLPKDEF, i);
			}
		}
		return this.EMNPICIEEOJ;
	}

	// Token: 0x06005A4A RID: 23114 RVA: 0x00003E52 File Offset: 0x00002052
	private void PHAFJDIGLMO()
	{
	}

	// Token: 0x06005A4B RID: 23115 RVA: 0x0028C0AC File Offset: 0x0028A2AC
	public void GLALPCHAOFG()
	{
		DPGJIJGOCIC.ANOPFDLPKGC("OnPurchasingViewLeave");
		this.IJPMLEKMGMA.JNNBNNDOGIM.DIBJILIHANI.Clear();
		while (this.contentFriendsTransform.childCount > 0)
		{
			UnityEngine.Object.DestroyImmediate(this.contentFriendsTransform.GetChild(0).gameObject);
		}
		this.HLMCJEKEJFP(this.IJPMLEKMGMA, this.PCCCLLPKDEF, true);
		this.resetSearchButton.SetActive(true);
	}

	// Token: 0x06005A4C RID: 23116 RVA: 0x0028C120 File Offset: 0x0028A320
	private void JJIGCFGKFHO()
	{
		AOBJLALDBAA.FILDBDMENPG().EFKNEJFLGED("OnChapterSnapshotsBackendFetchException2", new UnityAction(this.AAKHENHCIJI));
		AOBJLALDBAA.FILDBDMENPG().PEFKJOKLEDL("$USELAYERSV2", new UnityAction(this.OPGFAAFKGGL));
		AOBJLALDBAA.EHBBFMCILPC.BADOPKAOCPE("", new UnityAction(this.ICHAOBIKOGH));
		AOBJLALDBAA.EHBBFMCILPC.PEFKJOKLEDL("<align=\"center\"><alpha=#88>", new UnityAction(this.OnApplicationFocusBasicSyncSuccess));
		AOBJLALDBAA.AGANFKKBPFO().BADOPKAOCPE("", new UnityAction(this.OnFriendPlusUpgradeClick));
	}

	// Token: 0x06005A4D RID: 23117 RVA: 0x0028C1B4 File Offset: 0x0028A3B4
	private void EHMEFAAIPDE()
	{
		AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.JNNBNNDOGIM.NEDDDHJIJID();
		this.OnFriendsDataUpdateSuccess();
	}

	// Token: 0x06005A4E RID: 23118 RVA: 0x0028C1D0 File Offset: 0x0028A3D0
	private void HGCELCKMIOD()
	{
		this.friendsScrollView.GetComponent<ScrollRect>().onValueChanged.RemoveAllListeners();
		AOBJLALDBAA.KKPFOJMAONG().POLEDPIKODD(" ", new UnityAction(this.HDAPGMJAAEK));
		AOBJLALDBAA.NMGMNAKLLMI().MHLNJIACIGO("m_abortFlag = 2", new UnityAction(this.OPGFAAFKGGL));
		AOBJLALDBAA.KKPFOJMAONG().PFAHGKEDFAE("III", new UnityAction(this.HANIIMIEHDE));
		AOBJLALDBAA.AGANFKKBPFO().MHLNJIACIGO(", index:", new UnityAction(this.HGDFIKDKCOM));
		AOBJLALDBAA.AGANFKKBPFO().NAMMLDPCHJO("ERROR: StoryStepChoiceExtended.StoryStepStage.executeChoice.hair: bulk choice index must be > 0.", new UnityAction(this.OnFriendPlusUpgradeClick));
	}

	// Token: 0x06005A4F RID: 23119 RVA: 0x0028C279 File Offset: 0x0028A479
	private void MFFKDIJCCNJ(JSONArray NPBPCAPPMEL, bool EFNIEHJKNJK)
	{
		this.BENGMFLHNCC = 1;
		BackendOperationsManager.EHBBFMCILPC.GHDGCOHNCGI(NPBPCAPPMEL, EFNIEHJKNJK, "OnAccountSignInRequestException", "[LoadingEnv] ");
	}

	// Token: 0x06005A50 RID: 23120 RVA: 0x00003E52 File Offset: 0x00002052
	private void FIDHEEDHEHE()
	{
	}

	// Token: 0x06005A51 RID: 23121 RVA: 0x00003E52 File Offset: 0x00002052
	public void BKCDMEPKPCM()
	{
	}

	// Token: 0x06005A52 RID: 23122 RVA: 0x0028C298 File Offset: 0x0028A498
	private int FAFLFAIAKNP(PMEPALPCEAF ALCIFDBJPPB, ProfileItem2 PCCCLLPKDEF, bool DIBJILIHANI = false)
	{
		this.NCKAIHJMALG = this.MDHNLMFCLNE(this.IJPMLEKMGMA, false);
		this.EMNPICIEEOJ = this.NCKAIHJMALG.Count;
		if (this.EMNPICIEEOJ != 0)
		{
			this.contentFriendsTitle.SetActive(false);
			this.contentFriendsTransform.gameObject.SetActive(true);
			for (int i = 1; i < this.NCKAIHJMALG.Count; i += 0)
			{
				if (i == this.AAMCCHHBPIJ)
				{
					this.JBCJCBCDPDD(ALCIFDBJPPB, PCCCLLPKDEF, i);
					break;
				}
				this.JBCJCBCDPDD(ALCIFDBJPPB, PCCCLLPKDEF, i);
			}
		}
		return this.EMNPICIEEOJ;
	}

	// Token: 0x06005A53 RID: 23123 RVA: 0x00003E52 File Offset: 0x00002052
	public void GJGCGEGMMGJ()
	{
	}

	// Token: 0x06005A54 RID: 23124 RVA: 0x0028C32C File Offset: 0x0028A52C
	public void OnFriendsSearchCardClick()
	{
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("comingsoontitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("friendsplussearchcarddev"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupBackendError, 0f, 28);
	}

	// Token: 0x06005A55 RID: 23125 RVA: 0x0028C37C File Offset: 0x0028A57C
	private GameObject JBCJCBCDPDD(PMEPALPCEAF ALCIFDBJPPB, ProfileItem2 PCCCLLPKDEF, int PIHMAANLAEM)
	{
		ContentFriendsPage.HPDENBFIHJE hpdenbfihje = new ContentFriendsPage.HPDENBFIHJE();
		hpdenbfihje.profileItem2 = PCCCLLPKDEF;
		hpdenbfihje.sortedFriend = this.NCKAIHJMALG[PIHMAANLAEM];
		hpdenbfihje.friendGO = UnityEngine.Object.Instantiate<GameObject>(this.friendItem, this.contentFriendsTransform);
		hpdenbfihje.friendGO.GetComponent<ContentFriendItem>().KABPKMCFAIH(ALCIFDBJPPB, hpdenbfihje.sortedFriend, this.ONKONHLJKPG);
		hpdenbfihje.friendGO.GetComponent<ContentFriendItem>().showFriendRequestOptionsButton.onClick.AddListener(new UnityAction(hpdenbfihje.ABAPBEIGLOC));
		hpdenbfihje.friendGO.GetComponent<ContentFriendItem>().openCustomProfileButton.onClick.AddListener(new UnityAction(hpdenbfihje.IMEJKHKPBND));
		this.DOHNJHCFFLH = PIHMAANLAEM;
		this.CEFGNLEOLDO = hpdenbfihje.friendGO;
		return hpdenbfihje.friendGO;
	}

	// Token: 0x06005A56 RID: 23126 RVA: 0x0028C444 File Offset: 0x0028A644
	public static string GetLocalizedCostData()
	{
		OBHDGKFFICI productData = PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager().GetProductData(KDCJJBLGCBH.EHBBFMCILPC.DIAIFAMFPBK());
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.EHBBFMCILPC.PDJKPFLHFLO(KDCJJBLGCBH.EHBBFMCILPC.DIAIFAMFPBK());
		if (productData == null || ocbiopoeenj == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("ContentFriendsPage.GetLocalizedCostData() - productData is null.");
			return "";
		}
		if (ocbiopoeenj.OKGPIEEOKBM())
		{
			return ocbiopoeenj.FNJCEPLEPBH();
		}
		return "USD " + ocbiopoeenj.DMODNDCLGEJ;
	}

	// Token: 0x06005A57 RID: 23127 RVA: 0x0028C4B8 File Offset: 0x0028A6B8
	public void KEMBANGHNEN()
	{
		CommonUserInterface.EHBBFMCILPC.NFBMHHPIGFA(CCOJBMMKNAP.JMDJPKKOHNI().HIPJILDCHJC("avatarcollectionssubrequired2"), CCOJBMMKNAP.OEPENBHJAHO().IKMNGFIDCLM("randomprofilewhatis"), CCOJBMMKNAP.AEELGGPEJCC().PGKBCNBAOJN(""), (DFGILFBGPLN)(-17), 1118f, -115);
	}

	// Token: 0x06005A58 RID: 23128 RVA: 0x0028C506 File Offset: 0x0028A706
	private void HDAPGMJAAEK()
	{
		this.BENGMFLHNCC = 2;
	}

	// Token: 0x06005A59 RID: 23129 RVA: 0x0028A98C File Offset: 0x00288B8C
	public void JCLHBNBNLJH()
	{
		this.CheckForFriendsPlusUpgrade();
	}

	// Token: 0x06005A5A RID: 23130 RVA: 0x00003E52 File Offset: 0x00002052
	public void ECNHAFLGHNK()
	{
	}

	// Token: 0x06005A5B RID: 23131 RVA: 0x0028C510 File Offset: 0x0028A710
	private void IMGCBIEMGFM()
	{
		try
		{
			base.StartCoroutine(this.NDHEEFHNBEH());
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06005A5C RID: 23132 RVA: 0x0028875B File Offset: 0x0028695B
	public void HGDFIKDKCOM()
	{
		this.NCILILLDKHO();
	}

	// Token: 0x06005A5D RID: 23133 RVA: 0x00003E52 File Offset: 0x00002052
	private void PLFFFJKGDMB()
	{
	}

	// Token: 0x06005A5E RID: 23134 RVA: 0x0028C544 File Offset: 0x0028A744
	public void GAOICIGKMNG()
	{
		this.BENGMFLHNCC = 0;
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.HFAKOKBHCGH().JHNELLJFBGC("OnBackendRequestBreakCardSuccess"), CCOJBMMKNAP.NIOJNOFGIJO().JHNELLJFBGC("Critical error, could not load asset bundle:"), CCOJBMMKNAP.ILACPHFEDEP().FCOCLEHKLDJ(""), CCOJBMMKNAP.ILACPHFEDEP().MEPECBDCOLG("Repeat Notification"), new UnityAction(this.BKGGEEBMONN), new UnityAction(this.LDIPBCLENKK), (DFGILFBGPLN)(-35), 226f, -42);
	}

	// Token: 0x06005A5F RID: 23135 RVA: 0x0028C5C0 File Offset: 0x0028A7C0
	public void JHKBDGBDPOJ()
	{
		DPGJIJGOCIC.ANOPFDLPKGC("OnSpinsUnlockContinueToPurchasingScreen");
		while (this.contentFriendsTransform.childCount > 0)
		{
			UnityEngine.Object.DestroyImmediate(this.contentFriendsTransform.GetChild(1).gameObject);
		}
		if (this.KDNPGGPJFPC(this.IJPMLEKMGMA, this.PCCCLLPKDEF, false) > 0)
		{
			this.resetSearchButton.SetActive(true);
			return;
		}
		this.resetSearchButton.SetActive(true);
	}

	// Token: 0x06005A60 RID: 23136 RVA: 0x0028C62C File Offset: 0x0028A82C
	private void ACHAIJBBHKI()
	{
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.PMABBOJDELF().ICBJCNKKGPJ(KDCJJBLGCBH.EHBBFMCILPC.DIAIFAMFPBK());
		if (ocbiopoeenj != null)
		{
			ProductThumbnailManager.lastAccessedProductWebLink = ocbiopoeenj.MBLAIKOOCFH() + ")" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		}
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru && GeoLocationManager.IsRussia() && KDCJJBLGCBH.EHBBFMCILPC.EAMJBDKCDPA())
		{
			CommonUserInterface.IKNOFBFMPGA().GetFader().IBJEAPGPELH(null);
			this.CAGLJFHFFKN();
			return;
		}
		AOBJLALDBAA.EHBBFMCILPC.FDKBIBKABCM("tm", 1023f);
		CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().ShowAndPurchaseProduct(KDCJJBLGCBH.EHBBFMCILPC.DIAIFAMFPBK(), false);
	}

	// Token: 0x06005A61 RID: 23137 RVA: 0x0028C6D8 File Offset: 0x0028A8D8
	public void DLJICONJJEN(PMEPALPCEAF ALCIFDBJPPB, ProfileItem2 PCCCLLPKDEF)
	{
		this.EGGIKAOBCOF();
		this.IJPMLEKMGMA = ALCIFDBJPPB;
		this.PCCCLLPKDEF = PCCCLLPKDEF;
		this.friendsScrollView.GetComponent<ScrollRect>().verticalNormalizedPosition = 549f;
		this.friendsScrollView.GetComponent<ScrollRect>().onValueChanged.AddListener(new UnityAction<Vector2>(this.GEOMFJPIOMP));
		this.friendsScrollView.GetComponent<ScrollRect>().onValueChanged.AddListener(new UnityAction<Vector2>(this.JJPGCMFKNLP));
		this.ONKONHLJKPG = PCCCLLPKDEF.CalculateViewportUpDownMargins(this.friendsScrollView);
		PCCCLLPKDEF.PopulateHeaderContent(ALCIFDBJPPB);
		this.friendsPlus.SetActive(AKLFPGMDKLA.EHBBFMCILPC.EFMGLPMIPON());
		this.friendsOutOfDate.SetActive(ALCIFDBJPPB.JNNBNNDOGIM.MBLNPAAFCKP());
		this.FBANLLKPEBL(ALCIFDBJPPB, PCCCLLPKDEF);
		this.KHHJMEMMCML(ALCIFDBJPPB, PCCCLLPKDEF, true);
		this.UpdateIncommingGifts(ALCIFDBJPPB);
		this.KEOCEHCCEPD(ALCIFDBJPPB);
		this.PopulateCardsOnFriends(ALCIFDBJPPB, PCCCLLPKDEF);
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentIncomingFriendsTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentFriendsTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentFriendsSections.GetComponent<RectTransform>());
		this.resetSearchButton.SetActive(false);
	}

	// Token: 0x06005A62 RID: 23138 RVA: 0x0028C7F8 File Offset: 0x0028A9F8
	public void MNNDBILFOBN()
	{
		this.DLJICONJJEN(this.IJPMLEKMGMA, this.PCCCLLPKDEF);
	}

	// Token: 0x06005A63 RID: 23139 RVA: 0x0028C80C File Offset: 0x0028AA0C
	private GameObject OEBOMIACJAK(PMEPALPCEAF ALCIFDBJPPB, ProfileItem2 PCCCLLPKDEF, int PIHMAANLAEM)
	{
		ContentFriendsPage.HPDENBFIHJE hpdenbfihje = new ContentFriendsPage.HPDENBFIHJE();
		hpdenbfihje.profileItem2 = PCCCLLPKDEF;
		hpdenbfihje.sortedFriend = this.NCKAIHJMALG[PIHMAANLAEM];
		hpdenbfihje.friendGO = UnityEngine.Object.Instantiate<GameObject>(this.friendItem, this.contentFriendsTransform);
		hpdenbfihje.friendGO.GetComponent<ContentFriendItem>().CJCAIJFFNBE(ALCIFDBJPPB, hpdenbfihje.sortedFriend, this.ONKONHLJKPG);
		hpdenbfihje.friendGO.GetComponent<ContentFriendItem>().showFriendRequestOptionsButton.onClick.AddListener(new UnityAction(hpdenbfihje.ABAPBEIGLOC));
		hpdenbfihje.friendGO.GetComponent<ContentFriendItem>().openCustomProfileButton.onClick.AddListener(new UnityAction(hpdenbfihje.IMEJKHKPBND));
		this.DOHNJHCFFLH = PIHMAANLAEM;
		this.CEFGNLEOLDO = hpdenbfihje.friendGO;
		return hpdenbfihje.friendGO;
	}

	// Token: 0x06005A64 RID: 23140 RVA: 0x0028C8D1 File Offset: 0x0028AAD1
	private IEnumerator KEEPONCJOBN()
	{
		for (int i = this.DOHNJHCFFLH + 1; i < this.NCKAIHJMALG.Count; i++)
		{
			if (i % this.OGIHGJKAMKD == 0 || i == this.NCKAIHJMALG.Count - 1)
			{
				this.HPIKNGJNPGO(this.IJPMLEKMGMA, this.PCCCLLPKDEF, i);
				break;
			}
			this.HPIKNGJNPGO(this.IJPMLEKMGMA, this.PCCCLLPKDEF, i);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentFriendsTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentFriendsSections.GetComponent<RectTransform>());
		yield return null;
		this.EDIFMEMEOBG = false;
		yield break;
	}

	// Token: 0x06005A65 RID: 23141 RVA: 0x00003E52 File Offset: 0x00002052
	public void HDDCOPGNPIF()
	{
	}

	// Token: 0x06005A66 RID: 23142 RVA: 0x0028A831 File Offset: 0x00288A31
	public IEnumerator PELKMEGLNKF(GameObject MHKKGOCMIJI, PMEPALPCEAF LEJIJOAOEBK, bool DFLFEAPNHCP)
	{
		this.NCKAIHJMALG = this.HIMEBOFBOEE(this.IJPMLEKMGMA, false);
		this.NDGNLILNKAB = this.NJBKDCONEOG(this.IJPMLEKMGMA);
		int num = 0;
		if (this.IJPMLEKMGMA.JNNBNNDOGIM.IIMLLCPLKKJ.Count == 0 && this.IJPMLEKMGMA.JNNBNNDOGIM.KODOBGDHBFI.Count == 1)
		{
			num = 1;
		}
		yield return new WaitForSeconds((float)num);
		this.contentFriendsTitle.SetActive(true);
		this.contentFriendsTransform.gameObject.SetActive(true);
		if (DFLFEAPNHCP)
		{
			int siblingIndexInSortedFriendsList = this.GetSiblingIndexInSortedFriendsList(this.IJPMLEKMGMA, LEJIJOAOEBK);
			if (siblingIndexInSortedFriendsList <= this.DOHNJHCFFLH + 1)
			{
				MHKKGOCMIJI.transform.SetParent(this.contentFriendsTransform);
				this.SetSiblingIndexInSortedFriendsList(this.IJPMLEKMGMA, LEJIJOAOEBK, MHKKGOCMIJI);
				if (siblingIndexInSortedFriendsList == this.DOHNJHCFFLH + 1)
				{
					this.DOHNJHCFFLH = siblingIndexInSortedFriendsList;
					this.CEFGNLEOLDO = MHKKGOCMIJI;
				}
			}
			else
			{
				UnityEngine.Object.DestroyImmediate(MHKKGOCMIJI);
			}
		}
		else
		{
			UnityEngine.Object.DestroyImmediate(MHKKGOCMIJI);
		}
		if (this.IJPMLEKMGMA.JNNBNNDOGIM.IIMLLCPLKKJ.Count == 0)
		{
			this.contentIncomingFriendsTitle.SetActive(false);
			this.contentIncomingFriendsTransform.gameObject.SetActive(false);
		}
		else
		{
			this.KMCDKKHBCCH = this.contentIncomingFriendsTransform.GetChild(this.contentIncomingFriendsTransform.childCount - 1).gameObject;
			this.MBKKFNGBBEK = this.KMCDKKHBCCH.transform.GetSiblingIndex();
		}
		this.PCCCLLPKDEF.avatarHeader.UpdateFriendsCount();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentIncomingFriendsTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentFriendsTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentFriendsSections.GetComponent<RectTransform>());
		this.ContinueToPopulateIncomingFriends(Vector2.zero);
		yield break;
	}

	// Token: 0x06005A67 RID: 23143 RVA: 0x0028C8E0 File Offset: 0x0028AAE0
	private void JBAICDJCAIB()
	{
		while (this.contentIncomingFriendsTransform.childCount > 0)
		{
			UnityEngine.Object.DestroyImmediate(this.contentIncomingFriendsTransform.GetChild(0).gameObject);
		}
		while (this.contentFriendsTransform.childCount > 0)
		{
			UnityEngine.Object.DestroyImmediate(this.contentFriendsTransform.GetChild(0).gameObject);
		}
		while (this.cards.transform.childCount > 0)
		{
			UnityEngine.Object.DestroyImmediate(this.cards.transform.GetChild(0).gameObject);
		}
	}

	// Token: 0x06005A68 RID: 23144 RVA: 0x0028C96C File Offset: 0x0028AB6C
	public void FCHCGNPOJDH(Vector2 BNNFJDJACJA)
	{
		if (this.MBKKFNGBBEK < this.FPMGCHMADBD && !this.IANEDCEFMPH && this.KMCDKKHBCCH != null && this.KMCDKKHBCCH.GetComponent<ContentFriendItem>().isVisible)
		{
			this.IANEDCEFMPH = true;
			base.StartCoroutine(this.JHLJBFMMFMI());
		}
	}

	// Token: 0x06005A69 RID: 23145 RVA: 0x0028C9C4 File Offset: 0x0028ABC4
	public void PurchaseProductWeb()
	{
		OBHDGKFFICI productData = PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager().GetProductData(KDCJJBLGCBH.EHBBFMCILPC.DIAIFAMFPBK());
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.EHBBFMCILPC.PDJKPFLHFLO(KDCJJBLGCBH.EHBBFMCILPC.DIAIFAMFPBK());
		if (productData != null && ocbiopoeenj != null)
		{
			CommonUserInterface.EHBBFMCILPC.ShowPopupOnlineResources(ocbiopoeenj.MBLAIKOOCFH() + "?uid=" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 2);
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("ContentFriendsPage.PurchaseProductWeb(): productData or productBalanceData is null");
	}

	// Token: 0x06005A6A RID: 23146 RVA: 0x002891A6 File Offset: 0x002873A6
	private List<PMEPALPCEAF> BGPFFDEPMKI(PMEPALPCEAF ALCIFDBJPPB)
	{
		return ALCIFDBJPPB.JNNBNNDOGIM.IIMLLCPLKKJ.OrderByDescending(new Func<PMEPALPCEAF, int>(ContentFriendsPage.<>c.<>9.IDLOHJALGBB)).ToList<PMEPALPCEAF>();
	}

	// Token: 0x06005A6B RID: 23147 RVA: 0x0028CA38 File Offset: 0x0028AC38
	private void IFGKMIFOOIP()
	{
		CommonUserInterface.IKNOFBFMPGA().MCJIGJMFBMI();
		SceneLobbyManager2.doNotUpdatePercent = false;
		CommonUserInterface.IKNOFBFMPGA().ShowGenericPopup(CCOJBMMKNAP.HEDIEIICOOG().BDGPNPNIAPA("success"), CCOJBMMKNAP.DBFFFOMCLKM().HDIPNMFHIEJ("b_web"), CCOJBMMKNAP.PMABBOJDELF().PGKBCNBAOJN("sid"), (DFGILFBGPLN)(-18), 1027f, 42);
		this.BENGMFLHNCC = 5;
	}

	// Token: 0x06005A6C RID: 23148 RVA: 0x0028A831 File Offset: 0x00288A31
	public IEnumerator RefreshContentFriendsOnAcceptFriend(GameObject MHKKGOCMIJI, PMEPALPCEAF LEJIJOAOEBK, bool DFLFEAPNHCP)
	{
		this.NCKAIHJMALG = this.HIMEBOFBOEE(this.IJPMLEKMGMA, false);
		this.NDGNLILNKAB = this.NJBKDCONEOG(this.IJPMLEKMGMA);
		int num = 0;
		if (this.IJPMLEKMGMA.JNNBNNDOGIM.IIMLLCPLKKJ.Count == 0 && this.IJPMLEKMGMA.JNNBNNDOGIM.KODOBGDHBFI.Count == 1)
		{
			num = 1;
		}
		yield return new WaitForSeconds((float)num);
		this.contentFriendsTitle.SetActive(true);
		this.contentFriendsTransform.gameObject.SetActive(true);
		if (DFLFEAPNHCP)
		{
			int siblingIndexInSortedFriendsList = this.GetSiblingIndexInSortedFriendsList(this.IJPMLEKMGMA, LEJIJOAOEBK);
			if (siblingIndexInSortedFriendsList <= this.DOHNJHCFFLH + 1)
			{
				MHKKGOCMIJI.transform.SetParent(this.contentFriendsTransform);
				this.SetSiblingIndexInSortedFriendsList(this.IJPMLEKMGMA, LEJIJOAOEBK, MHKKGOCMIJI);
				if (siblingIndexInSortedFriendsList == this.DOHNJHCFFLH + 1)
				{
					this.DOHNJHCFFLH = siblingIndexInSortedFriendsList;
					this.CEFGNLEOLDO = MHKKGOCMIJI;
				}
			}
			else
			{
				UnityEngine.Object.DestroyImmediate(MHKKGOCMIJI);
			}
		}
		else
		{
			UnityEngine.Object.DestroyImmediate(MHKKGOCMIJI);
		}
		if (this.IJPMLEKMGMA.JNNBNNDOGIM.IIMLLCPLKKJ.Count == 0)
		{
			this.contentIncomingFriendsTitle.SetActive(false);
			this.contentIncomingFriendsTransform.gameObject.SetActive(false);
		}
		else
		{
			this.KMCDKKHBCCH = this.contentIncomingFriendsTransform.GetChild(this.contentIncomingFriendsTransform.childCount - 1).gameObject;
			this.MBKKFNGBBEK = this.KMCDKKHBCCH.transform.GetSiblingIndex();
		}
		this.PCCCLLPKDEF.avatarHeader.UpdateFriendsCount();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentIncomingFriendsTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentFriendsTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentFriendsSections.GetComponent<RectTransform>());
		this.ContinueToPopulateIncomingFriends(Vector2.zero);
		yield break;
	}

	// Token: 0x06005A6D RID: 23149 RVA: 0x00003E52 File Offset: 0x00002052
	public void BKACJJHOJOO()
	{
	}

	// Token: 0x06005A6E RID: 23150 RVA: 0x0028CAA0 File Offset: 0x0028ACA0
	private void OnDestroy()
	{
		try
		{
			if (null != this.incommingGiftsThumbAnimation)
			{
				this.incommingGiftsThumbAnimation.sprite = null;
				if (null != this.incommingGiftsThumbAnimation.GetComponent<ImageFrameAnimation>())
				{
					this.incommingGiftsThumbAnimation.GetComponent<ImageFrameAnimation>().framesSD = null;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06005A6F RID: 23151 RVA: 0x0028CB04 File Offset: 0x0028AD04
	private void ADKMPPPFKLL(PMEPALPCEAF ALCIFDBJPPB, ProfileItem2 PCCCLLPKDEF)
	{
		this.NDGNLILNKAB = this.NJBKDCONEOG(ALCIFDBJPPB);
		this.FPMGCHMADBD = this.NDGNLILNKAB.Count;
		if (this.FPMGCHMADBD != 0)
		{
			this.contentIncomingFriendsTitle.SetActive(false);
			this.contentIncomingFriendsTransform.gameObject.SetActive(true);
			for (int i = 1; i < this.NDGNLILNKAB.Count; i += 0)
			{
				if (i == this.AAMCCHHBPIJ)
				{
					this.JBNOEHKGHDI(ALCIFDBJPPB, PCCCLLPKDEF, i);
					return;
				}
				this.HJDDELOOCEL(ALCIFDBJPPB, PCCCLLPKDEF, i);
			}
		}
	}

	// Token: 0x04001991 RID: 6545
	public Transform friendsScrollView;

	// Token: 0x04001992 RID: 6546
	[SerializeField]
	private Transform contentFriendsSections;

	// Token: 0x04001993 RID: 6547
	[SerializeField]
	private GameObject friendsPlus;

	// Token: 0x04001994 RID: 6548
	[SerializeField]
	private GameObject friendsOutOfDate;

	// Token: 0x04001995 RID: 6549
	[SerializeField]
	private GameObject titleIncommingGifts;

	// Token: 0x04001996 RID: 6550
	[SerializeField]
	private GameObject incommingGifts;

	// Token: 0x04001997 RID: 6551
	[SerializeField]
	private Image incommingGiftsThumbAnimation;

	// Token: 0x04001998 RID: 6552
	[SerializeField]
	private TextMeshProUGUI incommingGiftsCountText;

	// Token: 0x04001999 RID: 6553
	[SerializeField]
	private GameObject contentIncomingFriendsTitle;

	// Token: 0x0400199A RID: 6554
	[SerializeField]
	private Transform contentIncomingFriendsTransform;

	// Token: 0x0400199B RID: 6555
	[SerializeField]
	private GameObject contentFriendsTitle;

	// Token: 0x0400199C RID: 6556
	[SerializeField]
	private Transform contentFriendsTransform;

	// Token: 0x0400199D RID: 6557
	[SerializeField]
	private GameObject resetSearchButton;

	// Token: 0x0400199E RID: 6558
	[SerializeField]
	private GameObject titleReceivedGifts;

	// Token: 0x0400199F RID: 6559
	[SerializeField]
	private GameObject receivedGifts;

	// Token: 0x040019A0 RID: 6560
	[SerializeField]
	private TextMeshProUGUI receivedGiftsCountText;

	// Token: 0x040019A1 RID: 6561
	[SerializeField]
	private GameObject titleCards;

	// Token: 0x040019A2 RID: 6562
	[SerializeField]
	private GameObject cards;

	// Token: 0x040019A3 RID: 6563
	[SerializeField]
	private GameObject cardsHidden;

	// Token: 0x040019A4 RID: 6564
	[SerializeField]
	private TextMeshProUGUI cardsHiddenText;

	// Token: 0x040019A5 RID: 6565
	[SerializeField]
	private Image cardsHiddenTextDropDown;

	// Token: 0x040019A6 RID: 6566
	[SerializeField]
	private Button cardsExpandButton;

	// Token: 0x040019A7 RID: 6567
	[SerializeField]
	private GameObject friendItem;

	// Token: 0x040019A8 RID: 6568
	[SerializeField]
	private GameObject cardItem;

	// Token: 0x040019A9 RID: 6569
	private PMEPALPCEAF IJPMLEKMGMA;

	// Token: 0x040019AA RID: 6570
	private ProfileItem2 PCCCLLPKDEF;

	// Token: 0x040019AB RID: 6571
	private Vector2 ONKONHLJKPG;

	// Token: 0x040019AC RID: 6572
	private int DOHNJHCFFLH;

	// Token: 0x040019AD RID: 6573
	private GameObject CEFGNLEOLDO;

	// Token: 0x040019AE RID: 6574
	private int MBKKFNGBBEK;

	// Token: 0x040019AF RID: 6575
	private GameObject KMCDKKHBCCH;

	// Token: 0x040019B0 RID: 6576
	private int AAMCCHHBPIJ = 10;

	// Token: 0x040019B1 RID: 6577
	private int OGIHGJKAMKD = 5;

	// Token: 0x040019B2 RID: 6578
	private List<PMEPALPCEAF> NDGNLILNKAB;

	// Token: 0x040019B3 RID: 6579
	private int FPMGCHMADBD;

	// Token: 0x040019B4 RID: 6580
	private List<PMEPALPCEAF> NCKAIHJMALG;

	// Token: 0x040019B5 RID: 6581
	private int EMNPICIEEOJ;

	// Token: 0x040019B6 RID: 6582
	private bool IANEDCEFMPH;

	// Token: 0x040019B7 RID: 6583
	private bool EDIFMEMEOBG;

	// Token: 0x040019B8 RID: 6584
	private int BENGMFLHNCC;

	// Token: 0x040019B9 RID: 6585
	public const string onBackendUpdateFriendsDataSuccess = "OnBackendUpdateFriendsDataSuccess";

	// Token: 0x040019BA RID: 6586
	public const string onBackendUpdateFriendsDataException = "OnBackendUpdateFriendsDataException";

	// Token: 0x040019BB RID: 6587
	public const string onFriendsPlusUnlockContinueToPurchasingScreen = "OnFriendsPlusUnlockContinueToPurchasingScreen";

	// Token: 0x040019BC RID: 6588
	public const string onFriendPlusUpgradeClick = "OnFriendPlusUpgradeClick";

	// Token: 0x020002DC RID: 732
	[CompilerGenerated]
	private sealed class CJAIDMOKKGH
	{
		// Token: 0x06005A75 RID: 23157 RVA: 0x0028CB9C File Offset: 0x0028AD9C
		internal bool PAIDAKCGIJD(PMEPALPCEAF f)
		{
			return this.myProfile.JNNBNNDOGIM.FNDNDILCFNN(f);
		}

		// Token: 0x040019C1 RID: 6593
		public PMEPALPCEAF myProfile;
	}

	// Token: 0x020002DE RID: 734
	[CompilerGenerated]
	private sealed class ECGAMGIIIOE
	{
		// Token: 0x06005A7E RID: 23166 RVA: 0x0028CC96 File Offset: 0x0028AE96
		internal void DBNOJBJBDEN()
		{
			this.profileItem2.ShowFriendOptions(this.sortedIncomingFriend, this.incomingFriendGO);
		}

		// Token: 0x06005A7F RID: 23167 RVA: 0x0028CCAF File Offset: 0x0028AEAF
		internal void NDPIDAFCBPH()
		{
			this.profileItem2.OpenCustomProfileFromFriends(this.sortedIncomingFriend);
		}

		// Token: 0x040019C5 RID: 6597
		public ProfileItem2 profileItem2;

		// Token: 0x040019C6 RID: 6598
		public PMEPALPCEAF sortedIncomingFriend;

		// Token: 0x040019C7 RID: 6599
		public GameObject incomingFriendGO;
	}

	// Token: 0x020002E0 RID: 736
	[CompilerGenerated]
	private sealed class HPDENBFIHJE
	{
		// Token: 0x06005A86 RID: 23174 RVA: 0x0028CDAA File Offset: 0x0028AFAA
		internal void ABAPBEIGLOC()
		{
			this.profileItem2.ShowFriendOptions(this.sortedFriend, this.friendGO);
		}

		// Token: 0x06005A87 RID: 23175 RVA: 0x0028CDC3 File Offset: 0x0028AFC3
		internal void IMEJKHKPBND()
		{
			this.profileItem2.OpenCustomProfileFromFriends(this.sortedFriend);
		}

		// Token: 0x040019CB RID: 6603
		public ProfileItem2 profileItem2;

		// Token: 0x040019CC RID: 6604
		public PMEPALPCEAF sortedFriend;

		// Token: 0x040019CD RID: 6605
		public GameObject friendGO;
	}

	// Token: 0x020002E1 RID: 737
	[CompilerGenerated]
	private sealed class MJEFEMJAAIH
	{
		// Token: 0x06005A89 RID: 23177 RVA: 0x0028CDD6 File Offset: 0x0028AFD6
		internal void ELMDNIONNCA()
		{
			this.<>4__this.KHCKGMELKLH(this.myProfile);
		}

		// Token: 0x040019CE RID: 6606
		public ContentFriendsPage <>4__this;

		// Token: 0x040019CF RID: 6607
		public PMEPALPCEAF myProfile;

		// Token: 0x040019D0 RID: 6608
		public ProfileItem2 profileItem2;

		// Token: 0x040019D1 RID: 6609
		public UnityAction <>9__1;
	}

	// Token: 0x020002E2 RID: 738
	[CompilerGenerated]
	private sealed class OGEDLCCPHDB
	{
		// Token: 0x06005A8B RID: 23179 RVA: 0x0028CDE9 File Offset: 0x0028AFE9
		internal void HEABDNCHIGB()
		{
			this.CS$<>8__locals1.profileItem2.OnCardClickFromFriends(this.id);
		}

		// Token: 0x040019D2 RID: 6610
		public int id;

		// Token: 0x040019D3 RID: 6611
		public ContentFriendsPage.MJEFEMJAAIH CS$<>8__locals1;
	}

	// Token: 0x020002E3 RID: 739
	[CompilerGenerated]
	private sealed class JIBFEEODMJA
	{
		// Token: 0x06005A8E RID: 23182 RVA: 0x0028CE01 File Offset: 0x0028B001
		internal void CHPODNKCCJN()
		{
			this.<>4__this.PCCCLLPKDEF.OnCardClickFromFriends(this.id);
		}

		// Token: 0x040019D4 RID: 6612
		public int id;

		// Token: 0x040019D5 RID: 6613
		public ContentFriendsPage <>4__this;
	}

	// Token: 0x020002E5 RID: 741
	[CompilerGenerated]
	private sealed class KDONEBFCIEE
	{
		// Token: 0x06005A96 RID: 23190 RVA: 0x0028D1C6 File Offset: 0x0028B3C6
		internal bool AHGNPLCGBPP(PMEPALPCEAF f)
		{
			return this.myProfile.JNNBNNDOGIM.FNDNDILCFNN(f);
		}

		// Token: 0x06005A97 RID: 23191 RVA: 0x0028D1D9 File Offset: 0x0028B3D9
		internal bool GCCOCFDPEEN(PMEPALPCEAF item)
		{
			return item == this.friend;
		}

		// Token: 0x040019DA RID: 6618
		public PMEPALPCEAF myProfile;

		// Token: 0x040019DB RID: 6619
		public PMEPALPCEAF friend;
	}
}
