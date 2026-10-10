using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x02000003 RID: 3
public class ContentHallOfFamePage : MonoBehaviour
{
	// Token: 0x06000044 RID: 68 RVA: 0x00002DCC File Offset: 0x00000FCC
	private bool NLNDLABPGKH()
	{
		return ContentHallOfFamePage.hallOfFameCollectionOffsetBackend == 0;
	}

	// Token: 0x06000045 RID: 69 RVA: 0x00002DD6 File Offset: 0x00000FD6
	private void BHGOKICGBKO()
	{
		AOBJLALDBAA.FILDBDMENPG().PFAHGKEDFAE("Starting non-parallel download:", new UnityAction(this.DFNOLOINMKA));
		AOBJLALDBAA.BIAEAOMHBMM().PFAHGKEDFAE("HD", new UnityAction(this.GCPNCMKMKKD));
	}

	// Token: 0x06000046 RID: 70 RVA: 0x00002E0E File Offset: 0x0000100E
	public void ContinueToPopulateHallOfFameItems(Vector2 BNNFJDJACJA)
	{
		if (!this.AFKNFOBGPBN && this.NLBAKOPGDIP != null && this.NLBAKOPGDIP.GetComponent<ContentHallOfFameItem>().isVisible)
		{
			this.AFKNFOBGPBN = true;
			if (!this.LNIIAKNDCPO())
			{
				this.PONBPGPNPCG();
			}
		}
	}

	// Token: 0x06000047 RID: 71 RVA: 0x00002E4D File Offset: 0x0000104D
	private void AAGKOINJGOL()
	{
		AOBJLALDBAA.BIAEAOMHBMM().MFIMALJPCDP("", new UnityAction(this.ANCJGGNDGOL));
		AOBJLALDBAA.BIAEAOMHBMM().BADOPKAOCPE("sckv2", new UnityAction(this.LIIONBOLDFA));
	}

	// Token: 0x06000048 RID: 72 RVA: 0x00002E88 File Offset: 0x00001088
	private void LHIHFFEJJFP()
	{
		foreach (ContentHallOfFameItem contentHallOfFameItem in this.KDNOGHLDIGN)
		{
			if (ProfileItem2.selectedHallOfFameLanguageFilter == 0)
			{
				contentHallOfFameItem.gameObject.SetActive(true);
				this.NLBAKOPGDIP = contentHallOfFameItem.gameObject;
			}
			if (ProfileItem2.selectedHallOfFameLanguageFilter == 1)
			{
				if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() != contentHallOfFameItem.hallOfFameProfile.ICCJIBMFNLD)
				{
					contentHallOfFameItem.gameObject.SetActive(false);
				}
				if (contentHallOfFameItem.gameObject.activeSelf)
				{
					this.NLBAKOPGDIP = contentHallOfFameItem.gameObject;
				}
			}
		}
	}

	// Token: 0x06000049 RID: 73 RVA: 0x00002F38 File Offset: 0x00001138
	private void AAKDPLPPLMC()
	{
		AOBJLALDBAA.DBLAIDPICIG().FNMOFCMDFJP("importanttitle", new UnityAction(this.DPAGLIKDJGM));
		AOBJLALDBAA.AGANFKKBPFO().EFKNEJFLGED("forcenoloop", new UnityAction(this.LIIONBOLDFA));
	}

	// Token: 0x0600004A RID: 74 RVA: 0x00002F70 File Offset: 0x00001170
	public void NFGOACIAEAO(Vector2 BNNFJDJACJA)
	{
		if (!this.AFKNFOBGPBN && this.NLBAKOPGDIP != null && this.NLBAKOPGDIP.GetComponent<ContentHallOfFameItem>().isVisible)
		{
			this.AFKNFOBGPBN = true;
			if (!this.JBDKCCHAIEA())
			{
				this.MMOEBKFLMMG();
			}
		}
	}

	// Token: 0x0600004B RID: 75 RVA: 0x00002FB0 File Offset: 0x000011B0
	public void SetActiveFilter(int GMDHIGOBEPM)
	{
		for (int i = 0; i < this.languageFilters.transform.childCount; i++)
		{
			this.languageFilters.transform.GetChild(i).transform.GetChild(0).gameObject.SetActive(false);
			this.languageFilters.transform.GetChild(i).transform.GetChild(1).gameObject.SetActive(false);
			if (i == GMDHIGOBEPM)
			{
				this.languageFilters.transform.GetChild(i).transform.GetChild(1).gameObject.SetActive(true);
			}
			else
			{
				this.languageFilters.transform.GetChild(i).transform.GetChild(0).gameObject.SetActive(true);
			}
		}
		ProfileItem2.selectedHallOfFameLanguageFilter = GMDHIGOBEPM;
		this.LHIHFFEJJFP();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentHallOfFameItemsTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentHallOfFameItemsTransform.parent.GetComponent<RectTransform>());
	}

	// Token: 0x0600004C RID: 76 RVA: 0x000030B1 File Offset: 0x000012B1
	private IEnumerator BLCIECIMJLG()
	{
		ContentHallOfFamePage.LGKDJKBPJIG lgkdjkbpjig = new ContentHallOfFamePage.LGKDJKBPJIG(1);
		lgkdjkbpjig.<>4__this = this;
		return lgkdjkbpjig;
	}

	// Token: 0x0600004D RID: 77 RVA: 0x000030B1 File Offset: 0x000012B1
	private IEnumerator AHBLPLJCFKP()
	{
		ContentHallOfFamePage.LGKDJKBPJIG lgkdjkbpjig = new ContentHallOfFamePage.LGKDJKBPJIG(1);
		lgkdjkbpjig.<>4__this = this;
		return lgkdjkbpjig;
	}

	// Token: 0x0600004E RID: 78 RVA: 0x000030C0 File Offset: 0x000012C0
	private void DPAGLIKDJGM()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		this.BFHOGGBDOHF();
	}

	// Token: 0x0600004F RID: 79 RVA: 0x000030D2 File Offset: 0x000012D2
	private void OnEnable()
	{
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendGetPublicProfileHallOfFameMoreSuccess", new UnityAction(this.DFNOLOINMKA));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendGetPublicProfileHallOfFameMoreException", new UnityAction(this.GCPNCMKMKKD));
	}

	// Token: 0x06000050 RID: 80 RVA: 0x0000310A File Offset: 0x0000130A
	private void MKHKBPAJNCM()
	{
		CommonUserInterface.IKNOFBFMPGA().MCJIGJMFBMI();
		this.EOGOFLOINGO();
	}

	// Token: 0x06000051 RID: 81 RVA: 0x0000311C File Offset: 0x0000131C
	public void PopulateContentHallOfFame(ProfileItem2 PCCCLLPKDEF)
	{
		ContentHallOfFamePage.HHDLJLKHOGF hhdljlkhogf = new ContentHallOfFamePage.HHDLJLKHOGF();
		hhdljlkhogf.profileItem2 = PCCCLLPKDEF;
		this.notificationPanel.SetActive(AKLFPGMDKLA.EHBBFMCILPC.PMEOLNDOBIH());
		this.AFKNFOBGPBN = false;
		this.hallOfFameScrollView.GetComponent<ScrollRect>().onValueChanged.AddListener(new UnityAction<Vector2>(this.ContinueToPopulateHallOfFameItems));
		this.PCCCLLPKDEF = hhdljlkhogf.profileItem2;
		this.KDNOGHLDIGN.Clear();
		this.FLDLNLOBOKG = 0;
		Vector2 onkonhljkpg = hhdljlkhogf.profileItem2.CalculateViewportUpDownMargins(this.hallOfFameScrollView);
		using (List<PMEPALPCEAF>.Enumerator enumerator = AKLFPGMDKLA.EHBBFMCILPC.AONCINPNHDD.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				ContentHallOfFamePage.HFJNLONCMBO hfjnloncmbo = new ContentHallOfFamePage.HFJNLONCMBO();
				hfjnloncmbo.CS$<>8__locals1 = hhdljlkhogf;
				hfjnloncmbo.hallOfFameProfile = enumerator.Current;
				this.FLDLNLOBOKG++;
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.hallOfFameItem, this.contentHallOfFameItemsTransform);
				bool eeghbpaheeg = AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.JNNBNNDOGIM.BCPOHPEJLGB(hfjnloncmbo.hallOfFameProfile);
				ContentHallOfFameItem component = gameObject.GetComponent<ContentHallOfFameItem>();
				component.SetContent(this.FLDLNLOBOKG, hfjnloncmbo.hallOfFameProfile, onkonhljkpg, eeghbpaheeg);
				component.profileButton.onClick.AddListener(new UnityAction(hfjnloncmbo.KADBBDHIIDN));
				component.historicalRankButton.onClick.AddListener(new UnityAction(hfjnloncmbo.OLAGMLPBGJF));
				this.KDNOGHLDIGN.Add(component);
				this.NLBAKOPGDIP = component.gameObject;
			}
		}
		bool active = AKLFPGMDKLA.EHBBFMCILPC.IILPKLDAJFK(LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
		this.languageFilters.SetActive(active);
		this.SetActiveFilter(ProfileItem2.selectedHallOfFameLanguageFilter);
		this.secondFilter.text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("language" + ((int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage()).ToString());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.secondFilter.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.languageFilters.GetComponent<RectTransform>());
		this.languageFilters.GetComponent<HorizontalLayoutGroup>().SetLayoutHorizontal();
		this.hallOfFameScrollView.GetComponent<ScrollRect>().verticalNormalizedPosition = this.verticalNormalizedPositionHallOfFameScroll;
	}

	// Token: 0x06000052 RID: 82 RVA: 0x00003358 File Offset: 0x00001558
	private void FEBLAJDOJHJ()
	{
		if (!this.NLNDLABPGKH())
		{
			CommonUserInterface.IKNOFBFMPGA().ShowConnectingAnimationWithHint(CCOJBMMKNAP.INKJIBDDMLL().FIENAKIHNOM(" components from body "), 92);
			BackendOperationsManager.NPDDBAONMJP().RequestGetHallOfFame(ContentHallOfFamePage.hallOfFameCollectionOffsetBackend, KBOJLHAJPCP.ALAPIFMKGAF, "post", "...");
		}
	}

	// Token: 0x06000053 RID: 83 RVA: 0x000033A6 File Offset: 0x000015A6
	private void GCPNCMKMKKD()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		ContentHallOfFamePage.hallOfFameCollectionOffsetBackend = 0;
		this.BFHOGGBDOHF();
	}

	// Token: 0x06000054 RID: 84 RVA: 0x000033BE File Offset: 0x000015BE
	private void FPLEDIFFMOB()
	{
		CommonUserInterface.IKNOFBFMPGA().HideConnectingAnimation();
		this.EOGOFLOINGO();
	}

	// Token: 0x06000055 RID: 85 RVA: 0x000033D0 File Offset: 0x000015D0
	private void PONBPGPNPCG()
	{
		if (!this.LNIIAKNDCPO())
		{
			CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithHint(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("hintloading"), 96);
			BackendOperationsManager.EHBBFMCILPC.RequestGetHallOfFame(ContentHallOfFamePage.hallOfFameCollectionOffsetBackend, KBOJLHAJPCP.ALAPIFMKGAF, "OnBackendGetPublicProfileHallOfFameMoreSuccess", "OnBackendGetPublicProfileHallOfFameMoreException");
		}
	}

	// Token: 0x06000056 RID: 86 RVA: 0x0000341E File Offset: 0x0000161E
	public void LNLANBPJNCH(Vector2 BNNFJDJACJA)
	{
		if (!this.AFKNFOBGPBN && this.NLBAKOPGDIP != null && this.NLBAKOPGDIP.GetComponent<ContentHallOfFameItem>().isVisible)
		{
			this.AFKNFOBGPBN = false;
			if (!this.LNIIAKNDCPO())
			{
				this.GENENBKKOHG();
			}
		}
	}

	// Token: 0x06000057 RID: 87 RVA: 0x00003460 File Offset: 0x00001660
	private void GENENBKKOHG()
	{
		if (!this.LNIIAKNDCPO())
		{
			CommonUserInterface.IKNOFBFMPGA().KLEJAGLPCNM(CCOJBMMKNAP.COKDLDOAACJ().IKMNGFIDCLM("XXX"), (byte)-86);
			BackendOperationsManager.EHBBFMCILPC.RequestGetHallOfFame(ContentHallOfFamePage.hallOfFameCollectionOffsetBackend, KBOJLHAJPCP.ALAPIFMKGAF, "lsenvattempt", "0.##");
		}
	}

	// Token: 0x06000059 RID: 89 RVA: 0x00002DCC File Offset: 0x00000FCC
	private bool LNIIAKNDCPO()
	{
		return ContentHallOfFamePage.hallOfFameCollectionOffsetBackend == 0;
	}

	// Token: 0x0600005A RID: 90 RVA: 0x000034B6 File Offset: 0x000016B6
	public void ShowLiveAvatars()
	{
		this.backHallOfFameButton.onClick.Invoke();
		this.openAvatarButton.onClick.Invoke();
	}

	// Token: 0x0600005B RID: 91 RVA: 0x000034D8 File Offset: 0x000016D8
	private bool JBDKCCHAIEA()
	{
		return ContentHallOfFamePage.hallOfFameCollectionOffsetBackend == 1;
	}

	// Token: 0x0600005C RID: 92 RVA: 0x000034B6 File Offset: 0x000016B6
	public void CMCAMDCHOKC()
	{
		this.backHallOfFameButton.onClick.Invoke();
		this.openAvatarButton.onClick.Invoke();
	}

	// Token: 0x0600005D RID: 93 RVA: 0x000034E4 File Offset: 0x000016E4
	private void MMOEBKFLMMG()
	{
		if (!this.NLNDLABPGKH())
		{
			CommonUserInterface.IKNOFBFMPGA().KLEJAGLPCNM(CCOJBMMKNAP.ILACPHFEDEP().DNILNCLIHAP(", size "), 75);
			BackendOperationsManager.NPDDBAONMJP().RequestGetHallOfFame(ContentHallOfFamePage.hallOfFameCollectionOffsetBackend, KBOJLHAJPCP.ALAPIFMKGAF, "OnGooglePlayServicesLoginSuccess", "envlsrw");
		}
	}

	// Token: 0x0600005E RID: 94 RVA: 0x00003532 File Offset: 0x00001732
	private void CCNFPNFDNDP()
	{
		AOBJLALDBAA.KKPFOJMAONG().MHLNJIACIGO("aind", new UnityAction(this.ANCJGGNDGOL));
		AOBJLALDBAA.AGANFKKBPFO().PBELMJCPJMK(", because it's hierarchy is already as needed:", new UnityAction(this.LIIONBOLDFA));
	}

	// Token: 0x06000060 RID: 96 RVA: 0x00003588 File Offset: 0x00001788
	private void GBIDDHNBECB()
	{
		AOBJLALDBAA.AGANFKKBPFO().ONIBLJOFFPG("ok", new UnityAction(this.ANCJGGNDGOL));
		AOBJLALDBAA.FILDBDMENPG().MANLHALMCIH("W", new UnityAction(this.GCPNCMKMKKD));
	}

	// Token: 0x06000061 RID: 97 RVA: 0x000030C0 File Offset: 0x000012C0
	private void DFNOLOINMKA()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		this.BFHOGGBDOHF();
	}

	// Token: 0x06000062 RID: 98 RVA: 0x000035C0 File Offset: 0x000017C0
	private void ADGMKCPHKDM()
	{
		foreach (ContentHallOfFameItem contentHallOfFameItem in this.KDNOGHLDIGN)
		{
			if (ProfileItem2.selectedHallOfFameLanguageFilter == 0)
			{
				contentHallOfFameItem.gameObject.SetActive(false);
				this.NLBAKOPGDIP = contentHallOfFameItem.gameObject;
			}
			if (ProfileItem2.selectedHallOfFameLanguageFilter == 0)
			{
				if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() != contentHallOfFameItem.hallOfFameProfile.ICCJIBMFNLD)
				{
					contentHallOfFameItem.gameObject.SetActive(true);
				}
				if (contentHallOfFameItem.gameObject.activeSelf)
				{
					this.NLBAKOPGDIP = contentHallOfFameItem.gameObject;
				}
			}
		}
	}

	// Token: 0x06000063 RID: 99 RVA: 0x00002DCC File Offset: 0x00000FCC
	private bool KPOADIOIDBH()
	{
		return ContentHallOfFamePage.hallOfFameCollectionOffsetBackend == 0;
	}

	// Token: 0x06000064 RID: 100 RVA: 0x000034B6 File Offset: 0x000016B6
	public void IPCNJIFEEOB()
	{
		this.backHallOfFameButton.onClick.Invoke();
		this.openAvatarButton.onClick.Invoke();
	}

	// Token: 0x06000065 RID: 101 RVA: 0x00003670 File Offset: 0x00001870
	private IEnumerator HBGLBMLNGPC()
	{
		Vector2 onkonhljkpg = this.PCCCLLPKDEF.CalculateViewportUpDownMargins(this.hallOfFameScrollView);
		List<PMEPALPCEAF> aoncinpnhdd = AKLFPGMDKLA.EHBBFMCILPC.AONCINPNHDD;
		for (int i = 0; i < aoncinpnhdd.Count; i++)
		{
			ContentHallOfFamePage.OIECACFDNIH oiecacfdnih = new ContentHallOfFamePage.OIECACFDNIH();
			oiecacfdnih.<>4__this = this;
			this.FLDLNLOBOKG++;
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.hallOfFameItem, this.contentHallOfFameItemsTransform);
			oiecacfdnih.hallOfFameProfile = aoncinpnhdd[i];
			bool eeghbpaheeg = AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.JNNBNNDOGIM.BCPOHPEJLGB(oiecacfdnih.hallOfFameProfile);
			ContentHallOfFameItem component = gameObject.GetComponent<ContentHallOfFameItem>();
			component.SetContent(this.FLDLNLOBOKG, oiecacfdnih.hallOfFameProfile, onkonhljkpg, eeghbpaheeg);
			component.profileButton.onClick.AddListener(new UnityAction(oiecacfdnih.FDGDBJIFPBC));
			component.historicalRankButton.onClick.AddListener(new UnityAction(oiecacfdnih.HMJGBAKNIKF));
			this.KDNOGHLDIGN.Add(component);
		}
		this.SetActiveFilter(ProfileItem2.selectedHallOfFameLanguageFilter);
		yield return null;
		this.AFKNFOBGPBN = false;
		yield break;
	}

	// Token: 0x06000066 RID: 102 RVA: 0x0000367F File Offset: 0x0000187F
	public void HINFAJBLMOE(Vector2 BNNFJDJACJA)
	{
		if (!this.AFKNFOBGPBN && this.NLBAKOPGDIP != null && this.NLBAKOPGDIP.GetComponent<ContentHallOfFameItem>().isVisible)
		{
			this.AFKNFOBGPBN = false;
			if (!this.NLNDLABPGKH())
			{
				this.PONBPGPNPCG();
			}
		}
	}

	// Token: 0x06000067 RID: 103 RVA: 0x000036C0 File Offset: 0x000018C0
	public void JBDECCOBPPE(ProfileItem2 PCCCLLPKDEF)
	{
		ContentHallOfFamePage.HHDLJLKHOGF hhdljlkhogf = new ContentHallOfFamePage.HHDLJLKHOGF();
		hhdljlkhogf.profileItem2 = PCCCLLPKDEF;
		this.notificationPanel.SetActive(AKLFPGMDKLA.EHBBFMCILPC.PMEOLNDOBIH());
		this.AFKNFOBGPBN = false;
		this.hallOfFameScrollView.GetComponent<ScrollRect>().onValueChanged.AddListener(new UnityAction<Vector2>(this.HINFAJBLMOE));
		this.PCCCLLPKDEF = hhdljlkhogf.profileItem2;
		this.KDNOGHLDIGN.Clear();
		this.FLDLNLOBOKG = 1;
		Vector2 onkonhljkpg = hhdljlkhogf.profileItem2.CalculateViewportUpDownMargins(this.hallOfFameScrollView);
		using (List<PMEPALPCEAF>.Enumerator enumerator = AKLFPGMDKLA.EHBBFMCILPC.AONCINPNHDD.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				ContentHallOfFamePage.HFJNLONCMBO hfjnloncmbo = new ContentHallOfFamePage.HFJNLONCMBO();
				hfjnloncmbo.CS$<>8__locals1 = hhdljlkhogf;
				hfjnloncmbo.hallOfFameProfile = enumerator.Current;
				this.FLDLNLOBOKG++;
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.hallOfFameItem, this.contentHallOfFameItemsTransform);
				bool eeghbpaheeg = AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.JNNBNNDOGIM.EJACENIHDDC(hfjnloncmbo.hallOfFameProfile);
				ContentHallOfFameItem component = gameObject.GetComponent<ContentHallOfFameItem>();
				component.MFHJBGBCAFA(this.FLDLNLOBOKG, hfjnloncmbo.hallOfFameProfile, onkonhljkpg, eeghbpaheeg);
				component.profileButton.onClick.AddListener(new UnityAction(hfjnloncmbo.KADBBDHIIDN));
				component.historicalRankButton.onClick.AddListener(new UnityAction(hfjnloncmbo.OLAGMLPBGJF));
				this.KDNOGHLDIGN.Add(component);
				this.NLBAKOPGDIP = component.gameObject;
			}
		}
		bool active = AKLFPGMDKLA.EHBBFMCILPC.IILPKLDAJFK(LanguageManager.EHBBFMCILPC.MLOLBFBODHD());
		this.languageFilters.SetActive(active);
		this.SetActiveFilter(ProfileItem2.selectedHallOfFameLanguageFilter);
		this.secondFilter.text = CCOJBMMKNAP.HFAKOKBHCGH().BDGPNPNIAPA("bdgsspr" + ((int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage()).ToString());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.secondFilter.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.languageFilters.GetComponent<RectTransform>());
		this.languageFilters.GetComponent<HorizontalLayoutGroup>().SetLayoutHorizontal();
		this.hallOfFameScrollView.GetComponent<ScrollRect>().verticalNormalizedPosition = this.verticalNormalizedPositionHallOfFameScroll;
	}

	// Token: 0x06000068 RID: 104 RVA: 0x000038FC File Offset: 0x00001AFC
	private void ANCJGGNDGOL()
	{
		CommonUserInterface.IKNOFBFMPGA().MCJIGJMFBMI();
		this.BFHOGGBDOHF();
	}

	// Token: 0x06000069 RID: 105 RVA: 0x000034B6 File Offset: 0x000016B6
	public void ILAHPKALFLB()
	{
		this.backHallOfFameButton.onClick.Invoke();
		this.openAvatarButton.onClick.Invoke();
	}

	// Token: 0x0600006A RID: 106 RVA: 0x00002F70 File Offset: 0x00001170
	public void OAGPHFHAKAJ(Vector2 BNNFJDJACJA)
	{
		if (!this.AFKNFOBGPBN && this.NLBAKOPGDIP != null && this.NLBAKOPGDIP.GetComponent<ContentHallOfFameItem>().isVisible)
		{
			this.AFKNFOBGPBN = true;
			if (!this.JBDKCCHAIEA())
			{
				this.MMOEBKFLMMG();
			}
		}
	}

	// Token: 0x0600006B RID: 107 RVA: 0x00003670 File Offset: 0x00001870
	private IEnumerator LPFCGDNCBJF()
	{
		Vector2 onkonhljkpg = this.PCCCLLPKDEF.CalculateViewportUpDownMargins(this.hallOfFameScrollView);
		List<PMEPALPCEAF> aoncinpnhdd = AKLFPGMDKLA.EHBBFMCILPC.AONCINPNHDD;
		for (int i = 0; i < aoncinpnhdd.Count; i++)
		{
			ContentHallOfFamePage.OIECACFDNIH oiecacfdnih = new ContentHallOfFamePage.OIECACFDNIH();
			oiecacfdnih.<>4__this = this;
			this.FLDLNLOBOKG++;
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.hallOfFameItem, this.contentHallOfFameItemsTransform);
			oiecacfdnih.hallOfFameProfile = aoncinpnhdd[i];
			bool eeghbpaheeg = AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.JNNBNNDOGIM.BCPOHPEJLGB(oiecacfdnih.hallOfFameProfile);
			ContentHallOfFameItem component = gameObject.GetComponent<ContentHallOfFameItem>();
			component.SetContent(this.FLDLNLOBOKG, oiecacfdnih.hallOfFameProfile, onkonhljkpg, eeghbpaheeg);
			component.profileButton.onClick.AddListener(new UnityAction(oiecacfdnih.FDGDBJIFPBC));
			component.historicalRankButton.onClick.AddListener(new UnityAction(oiecacfdnih.HMJGBAKNIKF));
			this.KDNOGHLDIGN.Add(component);
		}
		this.SetActiveFilter(ProfileItem2.selectedHallOfFameLanguageFilter);
		yield return null;
		this.AFKNFOBGPBN = false;
		yield break;
	}

	// Token: 0x0600006C RID: 108 RVA: 0x0000390E File Offset: 0x00001B0E
	private void KGOLCABMKDG()
	{
		base.StartCoroutine(this.LPFCGDNCBJF());
	}

	// Token: 0x0600006D RID: 109 RVA: 0x00003670 File Offset: 0x00001870
	private IEnumerator MEMEPGJJMPH()
	{
		Vector2 onkonhljkpg = this.PCCCLLPKDEF.CalculateViewportUpDownMargins(this.hallOfFameScrollView);
		List<PMEPALPCEAF> aoncinpnhdd = AKLFPGMDKLA.EHBBFMCILPC.AONCINPNHDD;
		for (int i = 0; i < aoncinpnhdd.Count; i++)
		{
			ContentHallOfFamePage.OIECACFDNIH oiecacfdnih = new ContentHallOfFamePage.OIECACFDNIH();
			oiecacfdnih.<>4__this = this;
			this.FLDLNLOBOKG++;
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.hallOfFameItem, this.contentHallOfFameItemsTransform);
			oiecacfdnih.hallOfFameProfile = aoncinpnhdd[i];
			bool eeghbpaheeg = AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.JNNBNNDOGIM.BCPOHPEJLGB(oiecacfdnih.hallOfFameProfile);
			ContentHallOfFameItem component = gameObject.GetComponent<ContentHallOfFameItem>();
			component.SetContent(this.FLDLNLOBOKG, oiecacfdnih.hallOfFameProfile, onkonhljkpg, eeghbpaheeg);
			component.profileButton.onClick.AddListener(new UnityAction(oiecacfdnih.FDGDBJIFPBC));
			component.historicalRankButton.onClick.AddListener(new UnityAction(oiecacfdnih.HMJGBAKNIKF));
			this.KDNOGHLDIGN.Add(component);
		}
		this.SetActiveFilter(ProfileItem2.selectedHallOfFameLanguageFilter);
		yield return null;
		this.AFKNFOBGPBN = false;
		yield break;
	}

	// Token: 0x0600006E RID: 110 RVA: 0x000034B6 File Offset: 0x000016B6
	public void MOEAFBBEHHN()
	{
		this.backHallOfFameButton.onClick.Invoke();
		this.openAvatarButton.onClick.Invoke();
	}

	// Token: 0x0600006F RID: 111 RVA: 0x0000391D File Offset: 0x00001B1D
	public void NGKCBFKHNCI(Vector2 BNNFJDJACJA)
	{
		if (!this.AFKNFOBGPBN && this.NLBAKOPGDIP != null && this.NLBAKOPGDIP.GetComponent<ContentHallOfFameItem>().isVisible)
		{
			this.AFKNFOBGPBN = true;
			if (!this.LNIIAKNDCPO())
			{
				this.FEBLAJDOJHJ();
			}
		}
	}

	// Token: 0x06000070 RID: 112 RVA: 0x0000390E File Offset: 0x00001B0E
	private void EOGOFLOINGO()
	{
		base.StartCoroutine(this.LPFCGDNCBJF());
	}

	// Token: 0x06000071 RID: 113 RVA: 0x0000390E File Offset: 0x00001B0E
	private void BFHOGGBDOHF()
	{
		base.StartCoroutine(this.LPFCGDNCBJF());
	}

	// Token: 0x06000072 RID: 114 RVA: 0x00002DCC File Offset: 0x00000FCC
	private bool CMEEMMJPCIE()
	{
		return ContentHallOfFamePage.hallOfFameCollectionOffsetBackend == 0;
	}

	// Token: 0x06000073 RID: 115 RVA: 0x0000395C File Offset: 0x00001B5C
	public void IALADNFOHBJ(int GMDHIGOBEPM)
	{
		for (int i = 0; i < this.languageFilters.transform.childCount; i += 0)
		{
			this.languageFilters.transform.GetChild(i).transform.GetChild(1).gameObject.SetActive(true);
			this.languageFilters.transform.GetChild(i).transform.GetChild(1).gameObject.SetActive(false);
			if (i == GMDHIGOBEPM)
			{
				this.languageFilters.transform.GetChild(i).transform.GetChild(0).gameObject.SetActive(false);
			}
			else
			{
				this.languageFilters.transform.GetChild(i).transform.GetChild(1).gameObject.SetActive(true);
			}
		}
		ProfileItem2.selectedHallOfFameLanguageFilter = GMDHIGOBEPM;
		this.ANGDJEFPAEB();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentHallOfFameItemsTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentHallOfFameItemsTransform.parent.GetComponent<RectTransform>());
	}

	// Token: 0x06000074 RID: 116 RVA: 0x00003A5D File Offset: 0x00001C5D
	private void LIIONBOLDFA()
	{
		CommonUserInterface.IKNOFBFMPGA().HideConnectingAnimation();
		ContentHallOfFamePage.hallOfFameCollectionOffsetBackend = 0;
		this.KGOLCABMKDG();
	}

	// Token: 0x06000075 RID: 117 RVA: 0x000034B6 File Offset: 0x000016B6
	public void MJGMAOONKJG()
	{
		this.backHallOfFameButton.onClick.Invoke();
		this.openAvatarButton.onClick.Invoke();
	}

	// Token: 0x06000076 RID: 118 RVA: 0x00003A78 File Offset: 0x00001C78
	private void ANGDJEFPAEB()
	{
		foreach (ContentHallOfFameItem contentHallOfFameItem in this.KDNOGHLDIGN)
		{
			if (ProfileItem2.selectedHallOfFameLanguageFilter == 0)
			{
				contentHallOfFameItem.gameObject.SetActive(true);
				this.NLBAKOPGDIP = contentHallOfFameItem.gameObject;
			}
			if (ProfileItem2.selectedHallOfFameLanguageFilter == 1)
			{
				if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() != contentHallOfFameItem.hallOfFameProfile.ICCJIBMFNLD)
				{
					contentHallOfFameItem.gameObject.SetActive(false);
				}
				if (contentHallOfFameItem.gameObject.activeSelf)
				{
					this.NLBAKOPGDIP = contentHallOfFameItem.gameObject;
				}
			}
		}
	}

	// Token: 0x06000077 RID: 119 RVA: 0x00003B28 File Offset: 0x00001D28
	public void MGCILBBDHCI(ProfileItem2 PCCCLLPKDEF)
	{
		ContentHallOfFamePage.HHDLJLKHOGF hhdljlkhogf = new ContentHallOfFamePage.HHDLJLKHOGF();
		hhdljlkhogf.profileItem2 = PCCCLLPKDEF;
		this.notificationPanel.SetActive(AKLFPGMDKLA.EHBBFMCILPC.PMEOLNDOBIH());
		this.AFKNFOBGPBN = true;
		this.hallOfFameScrollView.GetComponent<ScrollRect>().onValueChanged.AddListener(new UnityAction<Vector2>(this.OAGPHFHAKAJ));
		this.PCCCLLPKDEF = hhdljlkhogf.profileItem2;
		this.KDNOGHLDIGN.Clear();
		this.FLDLNLOBOKG = 1;
		Vector2 onkonhljkpg = hhdljlkhogf.profileItem2.CalculateViewportUpDownMargins(this.hallOfFameScrollView);
		using (List<PMEPALPCEAF>.Enumerator enumerator = AKLFPGMDKLA.EHBBFMCILPC.AONCINPNHDD.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				ContentHallOfFamePage.HFJNLONCMBO hfjnloncmbo = new ContentHallOfFamePage.HFJNLONCMBO();
				hfjnloncmbo.CS$<>8__locals1 = hhdljlkhogf;
				hfjnloncmbo.hallOfFameProfile = enumerator.Current;
				this.FLDLNLOBOKG++;
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.hallOfFameItem, this.contentHallOfFameItemsTransform);
				bool eeghbpaheeg = AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.JNNBNNDOGIM.BCPOHPEJLGB(hfjnloncmbo.hallOfFameProfile);
				ContentHallOfFameItem component = gameObject.GetComponent<ContentHallOfFameItem>();
				component.CPFBEBMLBDF(this.FLDLNLOBOKG, hfjnloncmbo.hallOfFameProfile, onkonhljkpg, eeghbpaheeg);
				component.profileButton.onClick.AddListener(new UnityAction(hfjnloncmbo.KADBBDHIIDN));
				component.historicalRankButton.onClick.AddListener(new UnityAction(hfjnloncmbo.OLAGMLPBGJF));
				this.KDNOGHLDIGN.Add(component);
				this.NLBAKOPGDIP = component.gameObject;
			}
		}
		bool active = AKLFPGMDKLA.EHBBFMCILPC.IILPKLDAJFK(LanguageManager.EHBBFMCILPC.NBANPEIHFOJ());
		this.languageFilters.SetActive(active);
		this.SetActiveFilter(ProfileItem2.selectedHallOfFameLanguageFilter);
		this.secondFilter.text = CCOJBMMKNAP.KMNBCEMEBBD().PPALCPINPLK("$USEVIDEOV2" + ((int)LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()).ToString());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.secondFilter.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.languageFilters.GetComponent<RectTransform>());
		this.languageFilters.GetComponent<HorizontalLayoutGroup>().SetLayoutHorizontal();
		this.hallOfFameScrollView.GetComponent<ScrollRect>().verticalNormalizedPosition = this.verticalNormalizedPositionHallOfFameScroll;
	}

	// Token: 0x06000078 RID: 120 RVA: 0x00003D64 File Offset: 0x00001F64
	public void DEBMFCMLNBG(Vector2 BNNFJDJACJA)
	{
		if (!this.AFKNFOBGPBN && this.NLBAKOPGDIP != null && this.NLBAKOPGDIP.GetComponent<ContentHallOfFameItem>().isVisible)
		{
			this.AFKNFOBGPBN = true;
			if (!this.KPOADIOIDBH())
			{
				this.FEBLAJDOJHJ();
			}
		}
	}

	// Token: 0x06000079 RID: 121 RVA: 0x00003DA3 File Offset: 0x00001FA3
	private void OnDisable()
	{
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendGetPublicProfileHallOfFameMoreSuccess", new UnityAction(this.DFNOLOINMKA));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendGetPublicProfileHallOfFameMoreException", new UnityAction(this.GCPNCMKMKKD));
	}

	// Token: 0x04000004 RID: 4
	[HideInInspector]
	public float verticalNormalizedPositionHallOfFameScroll = 1f;

	// Token: 0x04000005 RID: 5
	public Transform contentHallOfFameItemsTransform;

	// Token: 0x04000006 RID: 6
	public Transform hallOfFameScrollView;

	// Token: 0x04000007 RID: 7
	[SerializeField]
	private GameObject hallOfFameItem;

	// Token: 0x04000008 RID: 8
	[SerializeField]
	private GameObject notificationPanel;

	// Token: 0x04000009 RID: 9
	[SerializeField]
	private GameObject languageFilters;

	// Token: 0x0400000A RID: 10
	[SerializeField]
	private TextMeshProUGUI secondFilter;

	// Token: 0x0400000B RID: 11
	[SerializeField]
	private Button backHallOfFameButton;

	// Token: 0x0400000C RID: 12
	[SerializeField]
	private Button openAvatarButton;

	// Token: 0x0400000D RID: 13
	private List<ContentHallOfFameItem> KDNOGHLDIGN = new List<ContentHallOfFameItem>();

	// Token: 0x0400000E RID: 14
	public static int hallOfFameCollectionOffsetBackend = -1;

	// Token: 0x0400000F RID: 15
	public const string onBackendGetPublicProfileHallOfFameMoreSuccess = "OnBackendGetPublicProfileHallOfFameMoreSuccess";

	// Token: 0x04000010 RID: 16
	public const string onBackendGetPublicProfileHallOfFameMoreException = "OnBackendGetPublicProfileHallOfFameMoreException";

	// Token: 0x04000011 RID: 17
	private ProfileItem2 PCCCLLPKDEF;

	// Token: 0x04000012 RID: 18
	private int FLDLNLOBOKG;

	// Token: 0x04000013 RID: 19
	private GameObject NLBAKOPGDIP;

	// Token: 0x04000014 RID: 20
	private bool AFKNFOBGPBN;

	// Token: 0x02000004 RID: 4
	[CompilerGenerated]
	private sealed class HHDLJLKHOGF
	{
		// Token: 0x04000015 RID: 21
		public ProfileItem2 profileItem2;
	}

	// Token: 0x02000005 RID: 5
	[CompilerGenerated]
	private sealed class HFJNLONCMBO
	{
		// Token: 0x0600007B RID: 123 RVA: 0x00003DE3 File Offset: 0x00001FE3
		internal void KADBBDHIIDN()
		{
			this.CS$<>8__locals1.profileItem2.OpenCustomProfileFromHallOfFame(this.hallOfFameProfile);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00003DFB File Offset: 0x00001FFB
		internal void OLAGMLPBGJF()
		{
			this.CS$<>8__locals1.profileItem2.OnHallOfFameHistoricalRankClick(this.hallOfFameProfile);
		}

		// Token: 0x04000016 RID: 22
		public PMEPALPCEAF hallOfFameProfile;

		// Token: 0x04000017 RID: 23
		public ContentHallOfFamePage.HHDLJLKHOGF CS$<>8__locals1;
	}

	// Token: 0x02000006 RID: 6
	[CompilerGenerated]
	private sealed class OIECACFDNIH
	{
		// Token: 0x0600007E RID: 126 RVA: 0x00003E13 File Offset: 0x00002013
		internal void HMJGBAKNIKF()
		{
			this.<>4__this.PCCCLLPKDEF.OnHallOfFameHistoricalRankClick(this.hallOfFameProfile);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00003E2B File Offset: 0x0000202B
		internal void FDGDBJIFPBC()
		{
			this.<>4__this.PCCCLLPKDEF.OpenCustomProfileFromHallOfFame(this.hallOfFameProfile);
		}

		// Token: 0x04000018 RID: 24
		public PMEPALPCEAF hallOfFameProfile;

		// Token: 0x04000019 RID: 25
		public ContentHallOfFamePage <>4__this;
	}
}
