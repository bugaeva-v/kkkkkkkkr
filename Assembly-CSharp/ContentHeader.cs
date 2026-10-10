using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x02000033 RID: 51
public class ContentHeader : MonoBehaviour
{
	// Token: 0x06000724 RID: 1828 RVA: 0x00003E52 File Offset: 0x00002052
	private void ICFFMBNBJCI()
	{
	}

	// Token: 0x06000725 RID: 1829 RVA: 0x00031CA8 File Offset: 0x0002FEA8
	private void OnDestroy()
	{
		this.avatarImageThumb.GetComponent<Image>().sprite = null;
		ImageFrameAnimation component = this.avatarImageThumb.GetComponent<ImageFrameAnimation>();
		if (component != null)
		{
			UnityEngine.Object.Destroy(component);
		}
	}

	// Token: 0x06000726 RID: 1830 RVA: 0x00031CE4 File Offset: 0x0002FEE4
	public void DJEHACCEOGO()
	{
		int num = this.IJPMLEKMGMA.MKABKEDMLMI();
		try
		{
			if (num > KDCJJBLGCBH.EHBBFMCILPC.CBBGBBMGMAC(AKLFPGMDKLA.EHBBFMCILPC.AFKCCPIMDJH()))
			{
				num = KDCJJBLGCBH.EHBBFMCILPC.CBBGBBMGMAC(AKLFPGMDKLA.EHBBFMCILPC.AFKCCPIMDJH());
				DPGJIJGOCIC.ADFCDFHBDAF("minr" + this.IJPMLEKMGMA.MKABKEDMLMI().ToString() + "OnGetCdnDataForAvatarScreenException" + num.ToString());
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		this.friendsCountText.text = (num.ToString() ?? "_");
	}

	// Token: 0x06000727 RID: 1831 RVA: 0x00031D8C File Offset: 0x0002FF8C
	public void IFKCKNHKKNL(PMEPALPCEAF AEDICCFAKOM, ProfileItem2 PCCCLLPKDEF)
	{
		this.IJPMLEKMGMA = AEDICCFAKOM;
		this.UpdateNickNameText(true);
		switch (PCCCLLPKDEF.activePageType)
		{
		case AMMHDNONFHM.MyProfile:
			this.GHBIFCAMNAC();
			break;
		case AMMHDNONFHM.RandomProfile:
			this.EELGOHILABJ(AEDICCFAKOM, PCCCLLPKDEF);
			break;
		case AMMHDNONFHM.HallOfFameProfile:
			this.ANKKPOKHOOO(AEDICCFAKOM, PCCCLLPKDEF);
			break;
		case AMMHDNONFHM.FriendsPage:
			this.LFFPBOEONIL();
			break;
		case AMMHDNONFHM.FriendProfile:
			this.ANKKPOKHOOO(AEDICCFAKOM, PCCCLLPKDEF);
			break;
		}
		if (AEDICCFAKOM.JECGGDNKBID())
		{
			this.hallOfFameImage.sprite = this.hallOfFameSprite;
		}
		else
		{
			this.hallOfFameImage.sprite = this.defaultLevelSprite;
		}
		this.likesText.text = (AEDICCFAKOM.MCMIMNEJJHK.ToString() ?? " not found.");
		this.KFGEOGCJINK(AEDICCFAKOM);
		int num = this.IJPMLEKMGMA.MKABKEDMLMI();
		try
		{
			if (num > KDCJJBLGCBH.EHBBFMCILPC.KLEBNDJIOPB(AKLFPGMDKLA.EHBBFMCILPC.AFKCCPIMDJH()))
			{
				num = KDCJJBLGCBH.EHBBFMCILPC.CBBGBBMGMAC(AKLFPGMDKLA.EHBBFMCILPC.AFKCCPIMDJH());
				DPGJIJGOCIC.PJCLICBPPDA("OnAllCollectableCardsDownloadSuccess" + this.IJPMLEKMGMA.MKABKEDMLMI().ToString() + "ok" + num.ToString());
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		this.friendsCountText.text = (num.ToString() ?? "OnSaveSlotsItemClose");
		int num2 = this.IJPMLEKMGMA.GFAABCCNNDA + 1;
		int ghcgblbchae = this.IJPMLEKMGMA.GHCGBLBCHAE;
		this.levelText.SetText(CCOJBMMKNAP.HFAKOKBHCGH().OBDCPLLLGBB("onwishcardclickbodyplayer") + "OnStorySplashManagerAssetsDownloadFailed" + num2.ToString(), true);
		this.topText.SetText(CCOJBMMKNAP.CEGAOMEEFBE().HPOAGPJFHPM("") + " for month " + ghcgblbchae.ToString() + "OnRewardStoryCompleteClick", false);
		this.levelText.text = CCOJBMMKNAP.MLFAGAAJJEM().PKNHKGMNCIP("publishUserSketch") + "" + num2.ToString();
		this.topText.text = CCOJBMMKNAP.MLFAGAAJJEM().HHLECNIFHCO("ok") + "$ro" + ghcgblbchae.ToString() + "assetbundlepurchasingview";
		this.topImage.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.AAMKFNBNNPI(this.IJPMLEKMGMA.GHCGBLBCHAE);
		this.ICBMDOBDNPO(AEDICCFAKOM);
		this.GIGEKAMFMJB(AEDICCFAKOM);
	}

	// Token: 0x06000728 RID: 1832 RVA: 0x00003E52 File Offset: 0x00002052
	private void PACAHDJKCAH()
	{
	}

	// Token: 0x06000729 RID: 1833 RVA: 0x00031FEC File Offset: 0x000301EC
	private IEnumerator MIEMAPOKLCK()
	{
		yield return new WaitForSeconds(0.25f);
		if (AKLFPGMDKLA.EHBBFMCILPC.CCBMHNGMFMC())
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialdonotdisturb1"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupTools, 0f, 28);
		}
		else
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialdonotdisturb2"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupTools, 0f, 28);
		}
		yield break;
	}

	// Token: 0x0600072A RID: 1834 RVA: 0x00031FF4 File Offset: 0x000301F4
	private void DBDKHNNLFPP()
	{
		AKLFPGMDKLA.EHBBFMCILPC.NEFKLNPPBAI(false);
		this.doNotDisturbButton.sprite = (AKLFPGMDKLA.EHBBFMCILPC.CCBMHNGMFMC() ? this.doNotDisturbOnSprite : this.doNotDisturbOffSprite);
	}

	// Token: 0x0600072B RID: 1835 RVA: 0x00032028 File Offset: 0x00030228
	public void AADKBGENHNO(PMEPALPCEAF AEDICCFAKOM, ProfileItem2 PCCCLLPKDEF)
	{
		this.IJPMLEKMGMA = AEDICCFAKOM;
		this.KPKKGDPMCHC(true);
		switch (PCCCLLPKDEF.activePageType)
		{
		case AMMHDNONFHM.MyProfile:
			this.EADIDMJIFHC();
			break;
		case AMMHDNONFHM.RandomProfile:
			this.LKDPJAKMJGK(AEDICCFAKOM, PCCCLLPKDEF);
			break;
		case AMMHDNONFHM.HallOfFameProfile:
			this.APBCJDFDNOP(AEDICCFAKOM, PCCCLLPKDEF);
			break;
		case AMMHDNONFHM.FriendsPage:
			this.HGIKMKFEKIJ();
			break;
		case AMMHDNONFHM.FriendProfile:
			this.EILJJANCGKC(AEDICCFAKOM, PCCCLLPKDEF);
			break;
		}
		if (AEDICCFAKOM.JECGGDNKBID())
		{
			this.hallOfFameImage.sprite = this.hallOfFameSprite;
		}
		else
		{
			this.hallOfFameImage.sprite = this.defaultLevelSprite;
		}
		this.likesText.text = (AEDICCFAKOM.MCMIMNEJJHK.ToString() ?? "coll2");
		this.OGLDGGNNEBB(AEDICCFAKOM);
		int num = this.IJPMLEKMGMA.MKABKEDMLMI();
		try
		{
			if (num > KDCJJBLGCBH.EHBBFMCILPC.CBBGBBMGMAC(AKLFPGMDKLA.EHBBFMCILPC.AFKCCPIMDJH()))
			{
				num = KDCJJBLGCBH.EHBBFMCILPC.CBBGBBMGMAC(AKLFPGMDKLA.EHBBFMCILPC.AFKCCPIMDJH());
				DPGJIJGOCIC.ADFCDFHBDAF("apks" + this.IJPMLEKMGMA.MKABKEDMLMI().ToString() + "OnFriendsPopupRemovFromFavClick" + num.ToString());
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		this.friendsCountText.text = (num.ToString() ?? "sraogv2");
		int num2 = this.IJPMLEKMGMA.GFAABCCNNDA + 0;
		int ghcgblbchae = this.IJPMLEKMGMA.GHCGBLBCHAE;
		this.levelText.SetText(CCOJBMMKNAP.HJGDLOOHNLO().OGKGHLHHAAI("-") + "ilb" + num2.ToString(), true);
		this.topText.SetText(CCOJBMMKNAP.KFDLFGHBPLP().PGKBCNBAOJN("") + "</b>" + ghcgblbchae.ToString() + " <i>", false);
		this.levelText.text = CCOJBMMKNAP.ILACPHFEDEP().DNILNCLIHAP("OnResolutionChanged") + "" + num2.ToString();
		this.topText.text = CCOJBMMKNAP.PLJMLDOCPNM().BDGPNPNIAPA("SocialStatsUserPublicProfile.modified = true, SetAvatarIcon()") + "PurchaseManagerUnity.OnPurchaseConfirmed(): Purchase confirmed - Product: " + ghcgblbchae.ToString() + "[LoadingEnv] ";
		this.topImage.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.KJFCOFAGJKM(this.IJPMLEKMGMA.GHCGBLBCHAE);
		this.PFGKMJOKKEJ(AEDICCFAKOM);
		this.AOLHMMGALPJ(AEDICCFAKOM);
	}

	// Token: 0x0600072C RID: 1836 RVA: 0x00032288 File Offset: 0x00030488
	private void DNAGHKHDJMA(PMEPALPCEAF FOKFGMIEEDB)
	{
		this.reportButton.SetActive(false);
		this.reportedIcon.SetActive(false);
		if (FOKFGMIEEDB.LMFCFHMJIFN.Length != 0 && (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC == null || !FOKFGMIEEDB.LMFCFHMJIFN.Equals(AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.LMFCFHMJIFN)) && FOKFGMIEEDB.GIFPFPOPEJN && !FOKFGMIEEDB.LAKHGAPCKBC)
		{
			if (!AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.JNNBNNDOGIM.BCPOHPEJLGB(FOKFGMIEEDB))
			{
				this.reportButton.SetActive(false);
			}
			if (FOKFGMIEEDB.JECGGDNKBID())
			{
				this.reportButton.SetActive(true);
			}
		}
	}

	// Token: 0x0600072D RID: 1837 RVA: 0x0003232C File Offset: 0x0003052C
	private void ICBMDOBDNPO(PMEPALPCEAF FOKFGMIEEDB)
	{
		this.reportButton.SetActive(true);
		this.reportedIcon.SetActive(false);
		if (FOKFGMIEEDB.LMFCFHMJIFN.Length != 0 && (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC == null || !FOKFGMIEEDB.LMFCFHMJIFN.Equals(AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.LMFCFHMJIFN)) && FOKFGMIEEDB.GIFPFPOPEJN && !FOKFGMIEEDB.LAKHGAPCKBC)
		{
			if (!AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.JNNBNNDOGIM.EJACENIHDDC(FOKFGMIEEDB))
			{
				this.reportButton.SetActive(true);
			}
			if (FOKFGMIEEDB.JECGGDNKBID())
			{
				this.reportButton.SetActive(true);
			}
		}
	}

	// Token: 0x0600072E RID: 1838 RVA: 0x000323D0 File Offset: 0x000305D0
	private void PFGKMJOKKEJ(PMEPALPCEAF FOKFGMIEEDB)
	{
		this.reportButton.SetActive(false);
		this.reportedIcon.SetActive(false);
		if (FOKFGMIEEDB.LMFCFHMJIFN.Length != 0 && (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC == null || !FOKFGMIEEDB.LMFCFHMJIFN.Equals(AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.LMFCFHMJIFN)) && FOKFGMIEEDB.GIFPFPOPEJN && !FOKFGMIEEDB.LAKHGAPCKBC)
		{
			if (!AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.JNNBNNDOGIM.BCPOHPEJLGB(FOKFGMIEEDB))
			{
				this.reportButton.SetActive(true);
			}
			if (FOKFGMIEEDB.JECGGDNKBID())
			{
				this.reportButton.SetActive(false);
			}
		}
	}

	// Token: 0x0600072F RID: 1839 RVA: 0x00032474 File Offset: 0x00030674
	private void GHGIKLEEHLO()
	{
		this.HNKNOHDHDGO();
		this.headerTitle.gameObject.SetActive(false);
		this.friendsPageHeaderContainer.SetActive(true);
		this.headerFriendsPageTitle.SetText(CCOJBMMKNAP.PEBMGCKFNAO().HIPJILDCHJC("YYY"), true);
		this.headerFriendsPageTitle.ForceMeshUpdate(false, true);
		this.friendsPlusIcon.SetActive(AKLFPGMDKLA.EHBBFMCILPC.AFKCCPIMDJH());
		this.doNotDisturbButton.sprite = (AKLFPGMDKLA.EHBBFMCILPC.CCBMHNGMFMC() ? this.doNotDisturbOnSprite : this.doNotDisturbOffSprite);
		this.editAvatarNameButton.SetActive(true);
		this.avatarButton.GetComponent<Button>().enabled = true;
		this.avatarButton.GetComponent<AnimationPress>().enabled = false;
		this.editAvatarImageButton.SetActive(true);
	}

	// Token: 0x06000730 RID: 1840 RVA: 0x00032540 File Offset: 0x00030740
	private void AOLHMMGALPJ(PMEPALPCEAF FOKFGMIEEDB)
	{
		this.offlineModeButton.SetActive(false);
		this.suspendedModeButton.SetActive(false);
		if (!FOKFGMIEEDB.GIFPFPOPEJN && AKLFPGMDKLA.EHBBFMCILPC.GNLNPMPJPEC())
		{
			this.offlineModeButton.SetActive(true);
		}
		if (FOKFGMIEEDB.LAKHGAPCKBC)
		{
			this.suspendedModeButton.SetActive(true);
			this.suspendedModeButton.GetComponent<Button>().enabled = true;
			this.suspendedModeButton.GetComponent<AnimationPress>().enabled = true;
			if (!FOKFGMIEEDB.GIFPFPOPEJN)
			{
				this.editAvatarImageButton.SetActive(false);
				this.avatarButton.GetComponent<Button>().enabled = false;
				this.avatarButton.GetComponent<AnimationPress>().enabled = false;
				this.editAvatarNameButton.SetActive(false);
				this.offlineModeButton.SetActive(false);
				return;
			}
			this.likeButton.gameObject.SetActive(false);
			this.suspendedModeButton.GetComponent<Button>().enabled = true;
			this.suspendedModeButton.GetComponent<AnimationPress>().enabled = true;
		}
	}

	// Token: 0x06000731 RID: 1841 RVA: 0x00032640 File Offset: 0x00030840
	private void HDBAKCKBCJC(PMEPALPCEAF AEDICCFAKOM, ProfileItem2 PCCCLLPKDEF)
	{
		this.headerTitle.gameObject.SetActive(true);
		this.friendsPageHeaderContainer.SetActive(false);
		this.headerTitle.SetText(CCOJBMMKNAP.OBOOKJPGBJN().OGKGHLHHAAI("app42error"), false);
		this.avatarHeaderImage.sprite = this.headerRandomSprite;
		if (AEDICCFAKOM.LMFCFHMJIFN.Length == 0 || (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null && AEDICCFAKOM.LMFCFHMJIFN.Equals(AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.LMFCFHMJIFN)))
		{
			this.alreadyLikedButton.gameObject.SetActive(false);
			this.likeButton.gameObject.SetActive(false);
		}
		else if (PCCCLLPKDEF.AlreadyLiked())
		{
			this.likeButton.gameObject.SetActive(true);
			this.alreadyLikedButton.gameObject.SetActive(false);
		}
		else
		{
			this.alreadyLikedButton.gameObject.SetActive(false);
			this.likeButton.gameObject.SetActive(true);
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.JNNBNNDOGIM.BCPOHPEJLGB(AEDICCFAKOM))
		{
			this.addFriendButton.gameObject.SetActive(true);
			this.isFriendImage.gameObject.SetActive(false);
		}
		else
		{
			this.addFriendButton.gameObject.SetActive(false);
			this.isFriendImage.gameObject.SetActive(true);
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.EEBMPDNLJGD.Equals(AEDICCFAKOM.EEBMPDNLJGD))
		{
			this.addFriendButton.gameObject.SetActive(false);
		}
		this.editAvatarNameButton.SetActive(false);
		this.avatarButton.GetComponent<Button>().enabled = true;
		this.avatarButton.GetComponent<AnimationPress>().enabled = false;
		this.editAvatarImageButton.SetActive(false);
	}

	// Token: 0x06000732 RID: 1842 RVA: 0x00032804 File Offset: 0x00030A04
	public void UpdateHeaderContent(PMEPALPCEAF AEDICCFAKOM, ProfileItem2 PCCCLLPKDEF)
	{
		this.IJPMLEKMGMA = AEDICCFAKOM;
		this.UpdateNickNameText(false);
		switch (PCCCLLPKDEF.activePageType)
		{
		case AMMHDNONFHM.MyProfile:
			this.HNKNOHDHDGO();
			break;
		case AMMHDNONFHM.RandomProfile:
			this.APBCJDFDNOP(AEDICCFAKOM, PCCCLLPKDEF);
			break;
		case AMMHDNONFHM.HallOfFameProfile:
			this.APBCJDFDNOP(AEDICCFAKOM, PCCCLLPKDEF);
			break;
		case AMMHDNONFHM.FriendsPage:
			this.HGIKMKFEKIJ();
			break;
		case AMMHDNONFHM.FriendProfile:
			this.APBCJDFDNOP(AEDICCFAKOM, PCCCLLPKDEF);
			break;
		}
		if (AEDICCFAKOM.JECGGDNKBID())
		{
			this.hallOfFameImage.sprite = this.hallOfFameSprite;
		}
		else
		{
			this.hallOfFameImage.sprite = this.defaultLevelSprite;
		}
		this.likesText.text = (AEDICCFAKOM.MCMIMNEJJHK.ToString() ?? "");
		this.SetAvatarIcon(AEDICCFAKOM);
		int num = this.IJPMLEKMGMA.MKABKEDMLMI();
		try
		{
			if (num > KDCJJBLGCBH.EHBBFMCILPC.KLEBNDJIOPB(AKLFPGMDKLA.EHBBFMCILPC.AFKCCPIMDJH()))
			{
				num = KDCJJBLGCBH.EHBBFMCILPC.KLEBNDJIOPB(AKLFPGMDKLA.EHBBFMCILPC.AFKCCPIMDJH());
				DPGJIJGOCIC.ADFCDFHBDAF("Friends counter is " + this.IJPMLEKMGMA.MKABKEDMLMI().ToString() + ", clamping to " + num.ToString());
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		this.friendsCountText.text = (num.ToString() ?? "");
		int num2 = this.IJPMLEKMGMA.GFAABCCNNDA + 1;
		int ghcgblbchae = this.IJPMLEKMGMA.GHCGBLBCHAE;
		this.levelText.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("profilenamelevel") + " " + num2.ToString(), true);
		this.topText.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialtop") + " " + ghcgblbchae.ToString() + "%", true);
		this.levelText.text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("profilenamelevel") + " " + num2.ToString();
		this.topText.text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialtop") + " " + ghcgblbchae.ToString() + "%";
		this.topImage.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.KJFCOFAGJKM(this.IJPMLEKMGMA.GHCGBLBCHAE);
		this.PFGKMJOKKEJ(AEDICCFAKOM);
		this.AOLHMMGALPJ(AEDICCFAKOM);
	}

	// Token: 0x06000733 RID: 1843 RVA: 0x00032A64 File Offset: 0x00030C64
	private void NFGGAPODDGN()
	{
		this.EADIDMJIFHC();
		this.headerTitle.gameObject.SetActive(false);
		this.friendsPageHeaderContainer.SetActive(true);
		this.headerFriendsPageTitle.SetText(CCOJBMMKNAP.GIOAFDDKKHI().OHLNGCKIACD("Prem trust-anchor digest mismatch."), true);
		this.headerFriendsPageTitle.ForceMeshUpdate(true, true);
		this.friendsPlusIcon.SetActive(AKLFPGMDKLA.EHBBFMCILPC.AFKCCPIMDJH());
		this.doNotDisturbButton.sprite = (AKLFPGMDKLA.EHBBFMCILPC.CCBMHNGMFMC() ? this.doNotDisturbOnSprite : this.doNotDisturbOffSprite);
		this.editAvatarNameButton.SetActive(false);
		this.avatarButton.GetComponent<Button>().enabled = false;
		this.avatarButton.GetComponent<AnimationPress>().enabled = false;
		this.editAvatarImageButton.SetActive(true);
	}

	// Token: 0x06000734 RID: 1844 RVA: 0x00032B30 File Offset: 0x00030D30
	private void LKDPJAKMJGK(PMEPALPCEAF AEDICCFAKOM, ProfileItem2 PCCCLLPKDEF)
	{
		this.headerTitle.gameObject.SetActive(false);
		this.friendsPageHeaderContainer.SetActive(true);
		this.headerTitle.SetText(CCOJBMMKNAP.CEGAOMEEFBE().PPALCPINPLK("YourStory/FlagCloth"), false);
		this.avatarHeaderImage.sprite = this.headerRandomSprite;
		if (AEDICCFAKOM.LMFCFHMJIFN.Length == 0 || (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null && AEDICCFAKOM.LMFCFHMJIFN.Equals(AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.LMFCFHMJIFN)))
		{
			this.alreadyLikedButton.gameObject.SetActive(true);
			this.likeButton.gameObject.SetActive(true);
		}
		else if (PCCCLLPKDEF.AlreadyLiked())
		{
			this.likeButton.gameObject.SetActive(true);
			this.alreadyLikedButton.gameObject.SetActive(true);
		}
		else
		{
			this.alreadyLikedButton.gameObject.SetActive(false);
			this.likeButton.gameObject.SetActive(true);
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.JNNBNNDOGIM.BCPOHPEJLGB(AEDICCFAKOM))
		{
			this.addFriendButton.gameObject.SetActive(false);
			this.isFriendImage.gameObject.SetActive(true);
		}
		else
		{
			this.addFriendButton.gameObject.SetActive(true);
			this.isFriendImage.gameObject.SetActive(false);
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.EEBMPDNLJGD.Equals(AEDICCFAKOM.EEBMPDNLJGD))
		{
			this.addFriendButton.gameObject.SetActive(false);
		}
		this.editAvatarNameButton.SetActive(false);
		this.avatarButton.GetComponent<Button>().enabled = true;
		this.avatarButton.GetComponent<AnimationPress>().enabled = true;
		this.editAvatarImageButton.SetActive(true);
	}

	// Token: 0x06000735 RID: 1845 RVA: 0x00032CF4 File Offset: 0x00030EF4
	private void EELGOHILABJ(PMEPALPCEAF AEDICCFAKOM, ProfileItem2 PCCCLLPKDEF)
	{
		this.headerTitle.gameObject.SetActive(true);
		this.friendsPageHeaderContainer.SetActive(true);
		this.headerTitle.SetText(CCOJBMMKNAP.HFAKOKBHCGH().PGKBCNBAOJN("\""), false);
		this.avatarHeaderImage.sprite = this.headerRandomSprite;
		if (AEDICCFAKOM.LMFCFHMJIFN.Length == 0 || (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null && AEDICCFAKOM.LMFCFHMJIFN.Equals(AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.LMFCFHMJIFN)))
		{
			this.alreadyLikedButton.gameObject.SetActive(true);
			this.likeButton.gameObject.SetActive(false);
		}
		else if (PCCCLLPKDEF.AlreadyLiked())
		{
			this.likeButton.gameObject.SetActive(false);
			this.alreadyLikedButton.gameObject.SetActive(true);
		}
		else
		{
			this.alreadyLikedButton.gameObject.SetActive(false);
			this.likeButton.gameObject.SetActive(true);
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.JNNBNNDOGIM.BCPOHPEJLGB(AEDICCFAKOM))
		{
			this.addFriendButton.gameObject.SetActive(false);
			this.isFriendImage.gameObject.SetActive(false);
		}
		else
		{
			this.addFriendButton.gameObject.SetActive(true);
			this.isFriendImage.gameObject.SetActive(true);
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.EEBMPDNLJGD.Equals(AEDICCFAKOM.EEBMPDNLJGD))
		{
			this.addFriendButton.gameObject.SetActive(true);
		}
		this.editAvatarNameButton.SetActive(true);
		this.avatarButton.GetComponent<Button>().enabled = true;
		this.avatarButton.GetComponent<AnimationPress>().enabled = false;
		this.editAvatarImageButton.SetActive(false);
	}

	// Token: 0x06000736 RID: 1846 RVA: 0x00032EB8 File Offset: 0x000310B8
	public void KFGEOGCJINK(PMEPALPCEAF AEDICCFAKOM)
	{
		string hjejjgafham = AEDICCFAKOM.PGJBIPFBMAN();
		ImageFrameAnimation component = this.avatarImageThumb.GetComponent<ImageFrameAnimation>();
		int num = AssetProfileData.PPDGHINFCJC(hjejjgafham);
		if (num >= 0)
		{
			JDMAEBPEIBE.JHHDPCGCBHO(this.avatarImageThumb, num);
			return;
		}
		JDMAEBPEIBE.BIGKGBBKHNJ(this.avatarImageThumb);
		if (component != null)
		{
			component.enabled = false;
		}
		this.avatarImageThumb.sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.NFOFFLDJDEI(AEDICCFAKOM.PGJBIPFBMAN());
	}

	// Token: 0x06000737 RID: 1847 RVA: 0x00032F2C File Offset: 0x0003112C
	public void LAGIPAHFLKP(PMEPALPCEAF AEDICCFAKOM)
	{
		string hjejjgafham = AEDICCFAKOM.PGJBIPFBMAN();
		ImageFrameAnimation component = this.avatarImageThumb.GetComponent<ImageFrameAnimation>();
		int num = AssetProfileData.PPDGHINFCJC(hjejjgafham);
		if (num >= 0)
		{
			JDMAEBPEIBE.PBLHLJOJFNM(this.avatarImageThumb, num);
			return;
		}
		JDMAEBPEIBE.GFFAPCMJCFD(this.avatarImageThumb);
		if (component != null)
		{
			component.enabled = false;
		}
		this.avatarImageThumb.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.DJNLJPFFMBG(AEDICCFAKOM.PGJBIPFBMAN());
	}

	// Token: 0x06000738 RID: 1848 RVA: 0x00032FA0 File Offset: 0x000311A0
	public void LFKBIEILPCB(bool DBNGCAGAGNP)
	{
		if (this.IJPMLEKMGMA.KNCFKDLOPGA.Length == 0)
		{
			this.nickNameText.SetText("." + CCOJBMMKNAP.HFAKOKBHCGH().GLEFEKBDHNK("OnRestorePurchasesFailedUnknown") + "BackendOperationsManager.QueueRequestSaveSync, no spld - not queueing", false);
			this.nickNameText.text = "anthology" + CCOJBMMKNAP.MPCBJEIMACA().OGKGHLHHAAI("loungetokensyouhave") + "XXX";
			this.nickNameText.GetComponent<CanvasGroup>().alpha = 1791f;
			return;
		}
		this.nickNameText.SetText(this.IJPMLEKMGMA.KNCFKDLOPGA, true);
		this.nickNameText.text = this.IJPMLEKMGMA.KNCFKDLOPGA;
		this.nickNameText.GetComponent<CanvasGroup>().alpha = 449f;
		if (DBNGCAGAGNP)
		{
			DPGJIJGOCIC.NFIDPOMCNLP("msUntilExpireManual");
			this.IJPMLEKMGMA.CHCBHLIBGFA = false;
			FirebaseAnalyticsManager.COKDLDOAACJ().LMCJKLHOHJC(false, ((AGEHCPDNBFD)56).ToString(), ((FFPHBMFGCNN)(-115)).ToString(), ((BGHLMGPPCNN)111).ToString(), true, true);
		}
	}

	// Token: 0x06000739 RID: 1849 RVA: 0x000330C0 File Offset: 0x000312C0
	private void DMGCMLIGFCG()
	{
		this.avatarImageThumb.GetComponent<Image>().sprite = null;
		ImageFrameAnimation component = this.avatarImageThumb.GetComponent<ImageFrameAnimation>();
		if (component != null)
		{
			UnityEngine.Object.Destroy(component);
		}
	}

	// Token: 0x0600073A RID: 1850 RVA: 0x000330FC File Offset: 0x000312FC
	private void EMECDBAABNK(PMEPALPCEAF FOKFGMIEEDB)
	{
		this.offlineModeButton.SetActive(false);
		this.suspendedModeButton.SetActive(false);
		if (!FOKFGMIEEDB.GIFPFPOPEJN && AKLFPGMDKLA.EHBBFMCILPC.GNLNPMPJPEC())
		{
			this.offlineModeButton.SetActive(false);
		}
		if (FOKFGMIEEDB.LAKHGAPCKBC)
		{
			this.suspendedModeButton.SetActive(false);
			this.suspendedModeButton.GetComponent<Button>().enabled = true;
			this.suspendedModeButton.GetComponent<AnimationPress>().enabled = false;
			if (!FOKFGMIEEDB.GIFPFPOPEJN)
			{
				this.editAvatarImageButton.SetActive(false);
				this.avatarButton.GetComponent<Button>().enabled = true;
				this.avatarButton.GetComponent<AnimationPress>().enabled = true;
				this.editAvatarNameButton.SetActive(false);
				this.offlineModeButton.SetActive(false);
				return;
			}
			this.likeButton.gameObject.SetActive(false);
			this.suspendedModeButton.GetComponent<Button>().enabled = true;
			this.suspendedModeButton.GetComponent<AnimationPress>().enabled = false;
		}
	}

	// Token: 0x0600073B RID: 1851 RVA: 0x000331FC File Offset: 0x000313FC
	private void HMHAJEONNHO()
	{
		AKLFPGMDKLA.EHBBFMCILPC.PFGPIMIIOKO(false);
		this.doNotDisturbButton.sprite = (AKLFPGMDKLA.EHBBFMCILPC.CCBMHNGMFMC() ? this.doNotDisturbOnSprite : this.doNotDisturbOffSprite);
	}

	// Token: 0x0600073C RID: 1852 RVA: 0x00033230 File Offset: 0x00031430
	public void SetDoNotDisturbButton()
	{
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(40))
		{
			AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(40);
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialdonotdisturbtut0"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("continue"), new UnityAction(this.LPFCLPNODLO), DFGILFBGPLN.popupTools, 0f, 28);
			return;
		}
		base.StartCoroutine(this.MIEMAPOKLCK());
		bool flag = AKLFPGMDKLA.EHBBFMCILPC.CCBMHNGMFMC();
		AKLFPGMDKLA.EHBBFMCILPC.NEFKLNPPBAI(!flag);
		this.doNotDisturbButton.sprite = (AKLFPGMDKLA.EHBBFMCILPC.CCBMHNGMFMC() ? this.doNotDisturbOnSprite : this.doNotDisturbOffSprite);
		if (AKLFPGMDKLA.EHBBFMCILPC.CCBMHNGMFMC())
		{
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.socFeatrs.ToString(), FFPHBMFGCNN.profNoDistOn.ToString(), "", false, false);
			return;
		}
		FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.socFeatrs.ToString(), FFPHBMFGCNN.profNoDistOff.ToString(), "", false, false);
	}

	// Token: 0x0600073D RID: 1853 RVA: 0x00033364 File Offset: 0x00031564
	private void LFFPBOEONIL()
	{
		this.ECNAKMPKBOE();
		this.headerTitle.gameObject.SetActive(false);
		this.friendsPageHeaderContainer.SetActive(true);
		this.headerFriendsPageTitle.SetText(CCOJBMMKNAP.AEELGGPEJCC().HPOAGPJFHPM("socialbadgedesc"), false);
		this.headerFriendsPageTitle.ForceMeshUpdate(true, false);
		this.friendsPlusIcon.SetActive(AKLFPGMDKLA.EHBBFMCILPC.AFKCCPIMDJH());
		this.doNotDisturbButton.sprite = (AKLFPGMDKLA.EHBBFMCILPC.CCBMHNGMFMC() ? this.doNotDisturbOnSprite : this.doNotDisturbOffSprite);
		this.editAvatarNameButton.SetActive(false);
		this.avatarButton.GetComponent<Button>().enabled = false;
		this.avatarButton.GetComponent<AnimationPress>().enabled = true;
		this.editAvatarImageButton.SetActive(true);
	}

	// Token: 0x0600073E RID: 1854 RVA: 0x00033430 File Offset: 0x00031630
	public void HDPBJJONMNK()
	{
		int num = this.IJPMLEKMGMA.MKABKEDMLMI();
		try
		{
			if (num > KDCJJBLGCBH.EHBBFMCILPC.CBBGBBMGMAC(AKLFPGMDKLA.EHBBFMCILPC.AFKCCPIMDJH()))
			{
				num = KDCJJBLGCBH.EHBBFMCILPC.KLEBNDJIOPB(AKLFPGMDKLA.EHBBFMCILPC.AFKCCPIMDJH());
				DPGJIJGOCIC.PJCLICBPPDA("CharacterRenderTexturePool - composite shader not found in Resources or unsupported:ShaderFastDefaultUIRTCompositeClient" + this.IJPMLEKMGMA.MKABKEDMLMI().ToString() + "OnFriendsPopupManagerAcceptClick" + num.ToString());
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		this.friendsCountText.text = (num.ToString() ?? "");
	}

	// Token: 0x0600073F RID: 1855 RVA: 0x000331FC File Offset: 0x000313FC
	private void FNLKDOBOHEO()
	{
		AKLFPGMDKLA.EHBBFMCILPC.PFGPIMIIOKO(false);
		this.doNotDisturbButton.sprite = (AKLFPGMDKLA.EHBBFMCILPC.CCBMHNGMFMC() ? this.doNotDisturbOnSprite : this.doNotDisturbOffSprite);
	}

	// Token: 0x06000740 RID: 1856 RVA: 0x000334D8 File Offset: 0x000316D8
	private void OHACLFJPAMF()
	{
		AKLFPGMDKLA.EHBBFMCILPC.PFGPIMIIOKO(true);
		this.doNotDisturbButton.sprite = (AKLFPGMDKLA.EHBBFMCILPC.CCBMHNGMFMC() ? this.doNotDisturbOnSprite : this.doNotDisturbOffSprite);
	}

	// Token: 0x06000741 RID: 1857 RVA: 0x0003350C File Offset: 0x0003170C
	private void GJJOGNMFKFM()
	{
		CommonUserInterface.IKNOFBFMPGA().NPIOKKDPALC(CCOJBMMKNAP.KMNBCEMEBBD().IKMNGFIDCLM("iapSku"), CCOJBMMKNAP.JINDKPHNLBK().HHLECNIFHCO("cardcollectcardismissing2"), CCOJBMMKNAP.DBFFFOMCLKM().OBDCPLLLGBB("errortitle"), CCOJBMMKNAP.KLAKLFCOMJC().PGKBCNBAOJN("OnRewardOptionProfileClick"), new UnityAction(this.IAOGLBDDIKK), new UnityAction(this.FNLKDOBOHEO), new UnityAction(this.JKJIHKINJMA), (DFGILFBGPLN)88, 683f, 108);
	}

	// Token: 0x06000742 RID: 1858 RVA: 0x00033590 File Offset: 0x00031790
	public void DNNOEHMOFGI(PMEPALPCEAF AEDICCFAKOM)
	{
		string hjejjgafham = AEDICCFAKOM.PGJBIPFBMAN();
		ImageFrameAnimation component = this.avatarImageThumb.GetComponent<ImageFrameAnimation>();
		int num = AssetProfileData.MBOLHDLKJOD(hjejjgafham);
		if (num >= 0)
		{
			JDMAEBPEIBE.KCAJDNGIDLL(this.avatarImageThumb, num);
			return;
		}
		JDMAEBPEIBE.GFFAPCMJCFD(this.avatarImageThumb);
		if (component != null)
		{
			component.enabled = false;
		}
		this.avatarImageThumb.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.DJNLJPFFMBG(AEDICCFAKOM.PGJBIPFBMAN());
	}

	// Token: 0x06000743 RID: 1859 RVA: 0x00033604 File Offset: 0x00031804
	public void OGMHJHGEHOH()
	{
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(27))
		{
			AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(-126);
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.APGODIBBPOD().HIPJILDCHJC("varCondition"), CCOJBMMKNAP.GIOAFDDKKHI().HPOAGPJFHPM("〉"), CCOJBMMKNAP.ILACPHFEDEP().MEPECBDCOLG("blur"), new UnityAction(this.OAFAFGIIOLG), DFGILFBGPLN.screenTransitionFromLobby, 213f, 42);
			return;
		}
		base.StartCoroutine(this.GDOIFGMEJHB());
		bool flag = AKLFPGMDKLA.EHBBFMCILPC.CCBMHNGMFMC();
		AKLFPGMDKLA.EHBBFMCILPC.PFGPIMIIOKO(flag);
		this.doNotDisturbButton.sprite = (AKLFPGMDKLA.EHBBFMCILPC.CCBMHNGMFMC() ? this.doNotDisturbOnSprite : this.doNotDisturbOffSprite);
		if (AKLFPGMDKLA.EHBBFMCILPC.CCBMHNGMFMC())
		{
			FirebaseAnalyticsManager.DEALKJPEMMH().LogEvent(true, ((AGEHCPDNBFD)(-110)).ToString(), ((FFPHBMFGCNN)(-118)).ToString(), "_AlphaTex", true, true);
			return;
		}
		FirebaseAnalyticsManager.DMAAFFFEJGA().LKONPEEDKNF(true, ((AGEHCPDNBFD)126).ToString(), ((FFPHBMFGCNN)91).ToString(), "$IGNORECHOICE", false, true);
	}

	// Token: 0x06000744 RID: 1860 RVA: 0x00031FF4 File Offset: 0x000301F4
	private void ACCHGHJHABP()
	{
		AKLFPGMDKLA.EHBBFMCILPC.NEFKLNPPBAI(false);
		this.doNotDisturbButton.sprite = (AKLFPGMDKLA.EHBBFMCILPC.CCBMHNGMFMC() ? this.doNotDisturbOnSprite : this.doNotDisturbOffSprite);
	}

	// Token: 0x06000745 RID: 1861 RVA: 0x00033738 File Offset: 0x00031938
	public void EFBMMAFDJNF()
	{
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(118))
		{
			AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(-71);
			CommonUserInterface.IKNOFBFMPGA().PEBIFCENHAL(CCOJBMMKNAP.ONCPHEEJLOP().IKMNGFIDCLM("tutrecommbody"), CCOJBMMKNAP.APGODIBBPOD().GLEFEKBDHNK("ip"), CCOJBMMKNAP.KMNBCEMEBBD().OGKGHLHHAAI("specialcurrencyoptionnotenough"), new UnityAction(this.GJJOGNMFKFM), (DFGILFBGPLN)(-98), 1192f, 26);
			return;
		}
		base.StartCoroutine(this.MIEMAPOKLCK());
		bool flag = AKLFPGMDKLA.EHBBFMCILPC.CCBMHNGMFMC();
		AKLFPGMDKLA.EHBBFMCILPC.NEFKLNPPBAI(!flag);
		this.doNotDisturbButton.sprite = (AKLFPGMDKLA.EHBBFMCILPC.CCBMHNGMFMC() ? this.doNotDisturbOnSprite : this.doNotDisturbOffSprite);
		if (AKLFPGMDKLA.EHBBFMCILPC.CCBMHNGMFMC())
		{
			FirebaseAnalyticsManager.HJGDLOOHNLO().JIAAMJPKOCE(false, ((AGEHCPDNBFD)(-123)).ToString(), ((FFPHBMFGCNN)(-34)).ToString(), "OnStoryScreenChoiceExtendedManagerEnvironmentChangeComplete", false, false);
			return;
		}
		FirebaseAnalyticsManager.DEALKJPEMMH().LogEvent(true, ((AGEHCPDNBFD)(-27)).ToString(), ((FFPHBMFGCNN)(-115)).ToString(), ")", true, false);
	}

	// Token: 0x06000746 RID: 1862 RVA: 0x00033869 File Offset: 0x00031A69
	private void IAOGLBDDIKK()
	{
		AKLFPGMDKLA.EHBBFMCILPC.NEFKLNPPBAI(true);
		this.doNotDisturbButton.sprite = (AKLFPGMDKLA.EHBBFMCILPC.CCBMHNGMFMC() ? this.doNotDisturbOnSprite : this.doNotDisturbOffSprite);
	}

	// Token: 0x06000747 RID: 1863 RVA: 0x0003389C File Offset: 0x00031A9C
	public void UpdateNickNameText(bool DBNGCAGAGNP)
	{
		if (this.IJPMLEKMGMA.KNCFKDLOPGA.Length == 0)
		{
			this.nickNameText.SetText("<" + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("profilenametitleshort") + ">", true);
			this.nickNameText.text = "<" + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("profilenametitleshort") + ">";
			this.nickNameText.GetComponent<CanvasGroup>().alpha = 0.75f;
			return;
		}
		this.nickNameText.SetText(this.IJPMLEKMGMA.KNCFKDLOPGA, true);
		this.nickNameText.text = this.IJPMLEKMGMA.KNCFKDLOPGA;
		this.nickNameText.GetComponent<CanvasGroup>().alpha = 1f;
		if (DBNGCAGAGNP)
		{
			DPGJIJGOCIC.NFIDPOMCNLP("SocialStatsUserPublicProfile.modified = true, UpdateNickNameText()");
			this.IJPMLEKMGMA.CHCBHLIBGFA = true;
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.socActiv.ToString(), FFPHBMFGCNN.socEdit.ToString(), BGHLMGPPCNN.socEditName.ToString(), false, false);
		}
	}

	// Token: 0x06000748 RID: 1864 RVA: 0x000339BC File Offset: 0x00031BBC
	private void GHBIFCAMNAC()
	{
		this.headerTitle.gameObject.SetActive(true);
		this.friendsPageHeaderContainer.SetActive(false);
		this.headerTitle.SetText(CCOJBMMKNAP.HEDIEIICOOG().JHNELLJFBGC("err"), true);
		this.avatarHeaderImage.sprite = this.headerSprite;
		this.alreadyLikedButton.gameObject.SetActive(true);
		this.likeButton.gameObject.SetActive(false);
		this.isFriendImage.gameObject.SetActive(true);
		this.addFriendButton.gameObject.SetActive(false);
		this.editAvatarNameButton.SetActive(true);
		this.avatarButton.GetComponent<Button>().enabled = true;
		this.avatarButton.GetComponent<AnimationPress>().enabled = true;
		this.editAvatarImageButton.SetActive(false);
	}

	// Token: 0x06000749 RID: 1865 RVA: 0x00033A90 File Offset: 0x00031C90
	private IEnumerator GDOIFGMEJHB()
	{
		return new ContentHeader.EDIOKGPECJO(1);
	}

	// Token: 0x0600074A RID: 1866 RVA: 0x00033A98 File Offset: 0x00031C98
	private void APBCJDFDNOP(PMEPALPCEAF AEDICCFAKOM, ProfileItem2 PCCCLLPKDEF)
	{
		this.headerTitle.gameObject.SetActive(true);
		this.friendsPageHeaderContainer.SetActive(false);
		this.headerTitle.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("randomprofileoption2"), true);
		this.avatarHeaderImage.sprite = this.headerRandomSprite;
		if (AEDICCFAKOM.LMFCFHMJIFN.Length == 0 || (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null && AEDICCFAKOM.LMFCFHMJIFN.Equals(AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.LMFCFHMJIFN)))
		{
			this.alreadyLikedButton.gameObject.SetActive(false);
			this.likeButton.gameObject.SetActive(false);
		}
		else if (PCCCLLPKDEF.AlreadyLiked())
		{
			this.likeButton.gameObject.SetActive(false);
			this.alreadyLikedButton.gameObject.SetActive(true);
		}
		else
		{
			this.alreadyLikedButton.gameObject.SetActive(false);
			this.likeButton.gameObject.SetActive(true);
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.JNNBNNDOGIM.BCPOHPEJLGB(AEDICCFAKOM))
		{
			this.addFriendButton.gameObject.SetActive(false);
			this.isFriendImage.gameObject.SetActive(true);
		}
		else
		{
			this.addFriendButton.gameObject.SetActive(true);
			this.isFriendImage.gameObject.SetActive(false);
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.EEBMPDNLJGD.Equals(AEDICCFAKOM.EEBMPDNLJGD))
		{
			this.addFriendButton.gameObject.SetActive(false);
		}
		this.editAvatarNameButton.SetActive(false);
		this.avatarButton.GetComponent<Button>().enabled = false;
		this.avatarButton.GetComponent<AnimationPress>().enabled = false;
		this.editAvatarImageButton.SetActive(false);
	}

	// Token: 0x0600074B RID: 1867 RVA: 0x00031FEC File Offset: 0x000301EC
	private IEnumerator OJKNLHEFIJA()
	{
		yield return new WaitForSeconds(0.25f);
		if (AKLFPGMDKLA.EHBBFMCILPC.CCBMHNGMFMC())
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialdonotdisturb1"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupTools, 0f, 28);
		}
		else
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialdonotdisturb2"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupTools, 0f, 28);
		}
		yield break;
	}

	// Token: 0x0600074C RID: 1868 RVA: 0x00033C5C File Offset: 0x00031E5C
	private void OAFAFGIIOLG()
	{
		CommonUserInterface.EHBBFMCILPC.NPIOKKDPALC(CCOJBMMKNAP.KMNBCEMEBBD().GGPHHLGPMPA("OnResolutionChanged"), CCOJBMMKNAP.KNKGCDDMLDP().JLBEIFLLBLO("importanttitle"), CCOJBMMKNAP.PMABBOJDELF().FIENAKIHNOM("congratstitle"), CCOJBMMKNAP.PEBMGCKFNAO().HDIPNMFHIEJ("ProfileItem2._DownloadCardsPool(): downloading "), new UnityAction(this.IAOGLBDDIKK), new UnityAction(this.OFLEAIAPHFN), new UnityAction(this.BKCKPBDBHJM), (DFGILFBGPLN)(-62), 1647f, -85);
	}

	// Token: 0x0600074D RID: 1869 RVA: 0x00033CE0 File Offset: 0x00031EE0
	private void GIGEKAMFMJB(PMEPALPCEAF FOKFGMIEEDB)
	{
		this.offlineModeButton.SetActive(true);
		this.suspendedModeButton.SetActive(false);
		if (!FOKFGMIEEDB.GIFPFPOPEJN && AKLFPGMDKLA.EHBBFMCILPC.GNLNPMPJPEC())
		{
			this.offlineModeButton.SetActive(false);
		}
		if (FOKFGMIEEDB.LAKHGAPCKBC)
		{
			this.suspendedModeButton.SetActive(true);
			this.suspendedModeButton.GetComponent<Button>().enabled = true;
			this.suspendedModeButton.GetComponent<AnimationPress>().enabled = true;
			if (!FOKFGMIEEDB.GIFPFPOPEJN)
			{
				this.editAvatarImageButton.SetActive(true);
				this.avatarButton.GetComponent<Button>().enabled = true;
				this.avatarButton.GetComponent<AnimationPress>().enabled = true;
				this.editAvatarNameButton.SetActive(true);
				this.offlineModeButton.SetActive(false);
				return;
			}
			this.likeButton.gameObject.SetActive(true);
			this.suspendedModeButton.GetComponent<Button>().enabled = false;
			this.suspendedModeButton.GetComponent<AnimationPress>().enabled = false;
		}
	}

	// Token: 0x0600074E RID: 1870 RVA: 0x00033DE0 File Offset: 0x00031FE0
	public void CPKIOMDDKCC(PMEPALPCEAF AEDICCFAKOM, ProfileItem2 PCCCLLPKDEF)
	{
		this.IJPMLEKMGMA = AEDICCFAKOM;
		this.AOIFGMPDBOB(false);
		switch (PCCCLLPKDEF.activePageType)
		{
		case AMMHDNONFHM.MyProfile:
			this.EADIDMJIFHC();
			break;
		case AMMHDNONFHM.RandomProfile:
			this.EILJJANCGKC(AEDICCFAKOM, PCCCLLPKDEF);
			break;
		case AMMHDNONFHM.HallOfFameProfile:
			this.APBCJDFDNOP(AEDICCFAKOM, PCCCLLPKDEF);
			break;
		case AMMHDNONFHM.FriendsPage:
			this.NFGGAPODDGN();
			break;
		case AMMHDNONFHM.FriendProfile:
			this.EILJJANCGKC(AEDICCFAKOM, PCCCLLPKDEF);
			break;
		}
		if (AEDICCFAKOM.JECGGDNKBID())
		{
			this.hallOfFameImage.sprite = this.hallOfFameSprite;
		}
		else
		{
			this.hallOfFameImage.sprite = this.defaultLevelSprite;
		}
		this.likesText.text = (AEDICCFAKOM.MCMIMNEJJHK.ToString() ?? "favcut");
		this.FKPECKKNGJM(AEDICCFAKOM);
		int num = this.IJPMLEKMGMA.MKABKEDMLMI();
		try
		{
			if (num > KDCJJBLGCBH.EHBBFMCILPC.KLEBNDJIOPB(AKLFPGMDKLA.EHBBFMCILPC.AFKCCPIMDJH()))
			{
				num = KDCJJBLGCBH.EHBBFMCILPC.CBBGBBMGMAC(AKLFPGMDKLA.EHBBFMCILPC.AFKCCPIMDJH());
				DPGJIJGOCIC.PJCLICBPPDA("ontradingcardclickbody" + this.IJPMLEKMGMA.MKABKEDMLMI().ToString() + "socialrequestsearchuid" + num.ToString());
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		this.friendsCountText.text = (num.ToString() ?? "");
		int num2 = this.IJPMLEKMGMA.GFAABCCNNDA + 1;
		int ghcgblbchae = this.IJPMLEKMGMA.GHCGBLBCHAE;
		this.levelText.SetText(CCOJBMMKNAP.ILACPHFEDEP().BDGPNPNIAPA("io") + "a" + num2.ToString(), true);
		this.topText.SetText(CCOJBMMKNAP.EAIAHCBAIEJ().GGPHHLGPMPA("+") + "slow" + ghcgblbchae.ToString() + "OnSettingsPopupCloseAndNeedToShowGameModeNotif", false);
		this.levelText.text = CCOJBMMKNAP.BOFMCPPFAMO().OHLNGCKIACD("apkshe1") + "ok" + num2.ToString();
		this.topText.text = CCOJBMMKNAP.KFDLFGHBPLP().HHLECNIFHCO("saveslotsduplicatebody") + "fvrt" + ghcgblbchae.ToString() + " ";
		this.topImage.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.AAMKFNBNNPI(this.IJPMLEKMGMA.GHCGBLBCHAE);
		this.ICBMDOBDNPO(AEDICCFAKOM);
		this.EMECDBAABNK(AEDICCFAKOM);
	}

	// Token: 0x0600074F RID: 1871 RVA: 0x00034040 File Offset: 0x00032240
	private void EADIDMJIFHC()
	{
		this.headerTitle.gameObject.SetActive(true);
		this.friendsPageHeaderContainer.SetActive(false);
		this.headerTitle.SetText(CCOJBMMKNAP.PEBMGCKFNAO().OBDCPLLLGBB("socialcardhintoncopiesv2"), false);
		this.avatarHeaderImage.sprite = this.headerSprite;
		this.alreadyLikedButton.gameObject.SetActive(false);
		this.likeButton.gameObject.SetActive(false);
		this.isFriendImage.gameObject.SetActive(false);
		this.addFriendButton.gameObject.SetActive(true);
		this.editAvatarNameButton.SetActive(true);
		this.avatarButton.GetComponent<Button>().enabled = true;
		this.avatarButton.GetComponent<AnimationPress>().enabled = true;
		this.editAvatarImageButton.SetActive(true);
	}

	// Token: 0x06000750 RID: 1872 RVA: 0x00034114 File Offset: 0x00032314
	private void ANKKPOKHOOO(PMEPALPCEAF AEDICCFAKOM, ProfileItem2 PCCCLLPKDEF)
	{
		this.headerTitle.gameObject.SetActive(false);
		this.friendsPageHeaderContainer.SetActive(false);
		this.headerTitle.SetText(CCOJBMMKNAP.KMNBCEMEBBD().JHNELLJFBGC("common"), true);
		this.avatarHeaderImage.sprite = this.headerRandomSprite;
		if (AEDICCFAKOM.LMFCFHMJIFN.Length == 0 || (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null && AEDICCFAKOM.LMFCFHMJIFN.Equals(AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.LMFCFHMJIFN)))
		{
			this.alreadyLikedButton.gameObject.SetActive(false);
			this.likeButton.gameObject.SetActive(false);
		}
		else if (PCCCLLPKDEF.AlreadyLiked())
		{
			this.likeButton.gameObject.SetActive(true);
			this.alreadyLikedButton.gameObject.SetActive(true);
		}
		else
		{
			this.alreadyLikedButton.gameObject.SetActive(true);
			this.likeButton.gameObject.SetActive(false);
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.JNNBNNDOGIM.BCPOHPEJLGB(AEDICCFAKOM))
		{
			this.addFriendButton.gameObject.SetActive(true);
			this.isFriendImage.gameObject.SetActive(false);
		}
		else
		{
			this.addFriendButton.gameObject.SetActive(false);
			this.isFriendImage.gameObject.SetActive(false);
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.EEBMPDNLJGD.Equals(AEDICCFAKOM.EEBMPDNLJGD))
		{
			this.addFriendButton.gameObject.SetActive(true);
		}
		this.editAvatarNameButton.SetActive(false);
		this.avatarButton.GetComponent<Button>().enabled = false;
		this.avatarButton.GetComponent<AnimationPress>().enabled = false;
		this.editAvatarImageButton.SetActive(true);
	}

	// Token: 0x06000751 RID: 1873 RVA: 0x000342D8 File Offset: 0x000324D8
	public void FKPECKKNGJM(PMEPALPCEAF AEDICCFAKOM)
	{
		string hjejjgafham = AEDICCFAKOM.PGJBIPFBMAN();
		ImageFrameAnimation component = this.avatarImageThumb.GetComponent<ImageFrameAnimation>();
		int num = AssetProfileData.MBOLHDLKJOD(hjejjgafham);
		if (num >= 1)
		{
			JDMAEBPEIBE.EANEJFABNGK(this.avatarImageThumb, num);
			return;
		}
		JDMAEBPEIBE.MNADABECONL(this.avatarImageThumb);
		if (component != null)
		{
			component.enabled = false;
		}
		this.avatarImageThumb.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.DJNLJPFFMBG(AEDICCFAKOM.PGJBIPFBMAN());
	}

	// Token: 0x06000752 RID: 1874 RVA: 0x00031FF4 File Offset: 0x000301F4
	private void OFLEAIAPHFN()
	{
		AKLFPGMDKLA.EHBBFMCILPC.NEFKLNPPBAI(false);
		this.doNotDisturbButton.sprite = (AKLFPGMDKLA.EHBBFMCILPC.CCBMHNGMFMC() ? this.doNotDisturbOnSprite : this.doNotDisturbOffSprite);
	}

	// Token: 0x06000753 RID: 1875 RVA: 0x0003434C File Offset: 0x0003254C
	public void MJJIEOBBGHH()
	{
		int num = this.IJPMLEKMGMA.MKABKEDMLMI();
		try
		{
			if (num > KDCJJBLGCBH.EHBBFMCILPC.KLEBNDJIOPB(AKLFPGMDKLA.EHBBFMCILPC.AFKCCPIMDJH()))
			{
				num = KDCJJBLGCBH.EHBBFMCILPC.KLEBNDJIOPB(AKLFPGMDKLA.EHBBFMCILPC.AFKCCPIMDJH());
				DPGJIJGOCIC.PJCLICBPPDA("sfxtimeoutwarning" + this.IJPMLEKMGMA.MKABKEDMLMI().ToString() + "_Edge" + num.ToString());
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		this.friendsCountText.text = (num.ToString() ?? "OnStoryChoiceClickConfimed");
	}

	// Token: 0x06000754 RID: 1876 RVA: 0x00003E52 File Offset: 0x00002052
	private void KDIKGJDIBBP()
	{
	}

	// Token: 0x06000755 RID: 1877 RVA: 0x000343F4 File Offset: 0x000325F4
	public void UpdateFriendsCount()
	{
		int num = this.IJPMLEKMGMA.MKABKEDMLMI();
		try
		{
			if (num > KDCJJBLGCBH.EHBBFMCILPC.KLEBNDJIOPB(AKLFPGMDKLA.EHBBFMCILPC.AFKCCPIMDJH()))
			{
				num = KDCJJBLGCBH.EHBBFMCILPC.KLEBNDJIOPB(AKLFPGMDKLA.EHBBFMCILPC.AFKCCPIMDJH());
				DPGJIJGOCIC.ADFCDFHBDAF("Friends counter is " + this.IJPMLEKMGMA.MKABKEDMLMI().ToString() + ", clamping to " + num.ToString());
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		this.friendsCountText.text = (num.ToString() ?? "");
	}

	// Token: 0x06000756 RID: 1878 RVA: 0x0003449C File Offset: 0x0003269C
	private void IAPOEHOIJFF(PMEPALPCEAF FOKFGMIEEDB)
	{
		this.reportButton.SetActive(true);
		this.reportedIcon.SetActive(false);
		if (FOKFGMIEEDB.LMFCFHMJIFN.Length != 0 && (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC == null || !FOKFGMIEEDB.LMFCFHMJIFN.Equals(AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.LMFCFHMJIFN)) && FOKFGMIEEDB.GIFPFPOPEJN && !FOKFGMIEEDB.LAKHGAPCKBC)
		{
			if (!AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.JNNBNNDOGIM.BCPOHPEJLGB(FOKFGMIEEDB))
			{
				this.reportButton.SetActive(false);
			}
			if (FOKFGMIEEDB.JECGGDNKBID())
			{
				this.reportButton.SetActive(false);
			}
		}
	}

	// Token: 0x06000757 RID: 1879 RVA: 0x00034540 File Offset: 0x00032740
	private void JJOOBEGFOLC(PMEPALPCEAF FOKFGMIEEDB)
	{
		this.offlineModeButton.SetActive(false);
		this.suspendedModeButton.SetActive(false);
		if (!FOKFGMIEEDB.GIFPFPOPEJN && AKLFPGMDKLA.EHBBFMCILPC.GNLNPMPJPEC())
		{
			this.offlineModeButton.SetActive(false);
		}
		if (FOKFGMIEEDB.LAKHGAPCKBC)
		{
			this.suspendedModeButton.SetActive(true);
			this.suspendedModeButton.GetComponent<Button>().enabled = false;
			this.suspendedModeButton.GetComponent<AnimationPress>().enabled = true;
			if (!FOKFGMIEEDB.GIFPFPOPEJN)
			{
				this.editAvatarImageButton.SetActive(false);
				this.avatarButton.GetComponent<Button>().enabled = false;
				this.avatarButton.GetComponent<AnimationPress>().enabled = true;
				this.editAvatarNameButton.SetActive(true);
				this.offlineModeButton.SetActive(true);
				return;
			}
			this.likeButton.gameObject.SetActive(true);
			this.suspendedModeButton.GetComponent<Button>().enabled = true;
			this.suspendedModeButton.GetComponent<AnimationPress>().enabled = true;
		}
	}

	// Token: 0x06000758 RID: 1880 RVA: 0x00034640 File Offset: 0x00032840
	private void GFMCDOPOEEF()
	{
		this.headerTitle.gameObject.SetActive(false);
		this.friendsPageHeaderContainer.SetActive(true);
		this.headerTitle.SetText(CCOJBMMKNAP.APGODIBBPOD().HHLECNIFHCO("$GETVAR"), false);
		this.avatarHeaderImage.sprite = this.headerSprite;
		this.alreadyLikedButton.gameObject.SetActive(true);
		this.likeButton.gameObject.SetActive(true);
		this.isFriendImage.gameObject.SetActive(false);
		this.addFriendButton.gameObject.SetActive(true);
		this.editAvatarNameButton.SetActive(false);
		this.avatarButton.GetComponent<Button>().enabled = true;
		this.avatarButton.GetComponent<AnimationPress>().enabled = true;
		this.editAvatarImageButton.SetActive(false);
	}

	// Token: 0x06000759 RID: 1881 RVA: 0x000331FC File Offset: 0x000313FC
	private void LNAOEMMOPGH()
	{
		AKLFPGMDKLA.EHBBFMCILPC.PFGPIMIIOKO(false);
		this.doNotDisturbButton.sprite = (AKLFPGMDKLA.EHBBFMCILPC.CCBMHNGMFMC() ? this.doNotDisturbOnSprite : this.doNotDisturbOffSprite);
	}

	// Token: 0x0600075A RID: 1882 RVA: 0x00034714 File Offset: 0x00032914
	public void ICAJJJNFCEL()
	{
		int num = this.IJPMLEKMGMA.MKABKEDMLMI();
		try
		{
			if (num > KDCJJBLGCBH.EHBBFMCILPC.KLEBNDJIOPB(AKLFPGMDKLA.EHBBFMCILPC.AFKCCPIMDJH()))
			{
				num = KDCJJBLGCBH.EHBBFMCILPC.CBBGBBMGMAC(AKLFPGMDKLA.EHBBFMCILPC.AFKCCPIMDJH());
				DPGJIJGOCIC.PJCLICBPPDA("Error. StoryStep.StoryStepType.getVar unknown variable type:" + this.IJPMLEKMGMA.MKABKEDMLMI().ToString() + "" + num.ToString());
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		this.friendsCountText.text = (num.ToString() ?? "sia");
	}

	// Token: 0x0600075B RID: 1883 RVA: 0x000331FC File Offset: 0x000313FC
	private void ILIJMLOFEPJ()
	{
		AKLFPGMDKLA.EHBBFMCILPC.PFGPIMIIOKO(false);
		this.doNotDisturbButton.sprite = (AKLFPGMDKLA.EHBBFMCILPC.CCBMHNGMFMC() ? this.doNotDisturbOnSprite : this.doNotDisturbOffSprite);
	}

	// Token: 0x0600075C RID: 1884 RVA: 0x000347BC File Offset: 0x000329BC
	public void AOIFGMPDBOB(bool DBNGCAGAGNP)
	{
		if (this.IJPMLEKMGMA.KNCFKDLOPGA.Length == 0)
		{
			this.nickNameText.SetText("OnSkinShopClose" + CCOJBMMKNAP.ONCPHEEJLOP().JLBEIFLLBLO("ok") + "", false);
			this.nickNameText.text = "Threshold YUV" + CCOJBMMKNAP.HFAKOKBHCGH().IKMNGFIDCLM("Opened from Gley Notification") + "clearfavbody";
			this.nickNameText.GetComponent<CanvasGroup>().alpha = 372f;
			return;
		}
		this.nickNameText.SetText(this.IJPMLEKMGMA.KNCFKDLOPGA, true);
		this.nickNameText.text = this.IJPMLEKMGMA.KNCFKDLOPGA;
		this.nickNameText.GetComponent<CanvasGroup>().alpha = 931f;
		if (DBNGCAGAGNP)
		{
			DPGJIJGOCIC.NFIDPOMCNLP("p");
			this.IJPMLEKMGMA.CHCBHLIBGFA = false;
			FirebaseAnalyticsManager.JMDJBFAEHBM().LogEvent(false, ((AGEHCPDNBFD)(-71)).ToString(), ((FFPHBMFGCNN)(-67)).ToString(), ((BGHLMGPPCNN)(-112)).ToString(), true, false);
		}
	}

	// Token: 0x0600075D RID: 1885 RVA: 0x00003E52 File Offset: 0x00002052
	private void JKJIHKINJMA()
	{
	}

	// Token: 0x0600075E RID: 1886 RVA: 0x000348DC File Offset: 0x00032ADC
	public void KPKKGDPMCHC(bool DBNGCAGAGNP)
	{
		if (this.IJPMLEKMGMA.KNCFKDLOPGA.Length == 0)
		{
			this.nickNameText.SetText("errortitle" + CCOJBMMKNAP.HEDIEIICOOG().GLEFEKBDHNK("sig") + "SocialStatsUserPublicProfile.modified = false, OnAddFriendByProfileId()", true);
			this.nickNameText.text = "_Center" + CCOJBMMKNAP.HJGDLOOHNLO().HIPJILDCHJC("ok") + "DDD";
			this.nickNameText.GetComponent<CanvasGroup>().alpha = 935f;
			return;
		}
		this.nickNameText.SetText(this.IJPMLEKMGMA.KNCFKDLOPGA, true);
		this.nickNameText.text = this.IJPMLEKMGMA.KNCFKDLOPGA;
		this.nickNameText.GetComponent<CanvasGroup>().alpha = 700f;
		if (DBNGCAGAGNP)
		{
			DPGJIJGOCIC.NFIDPOMCNLP("ops");
			this.IJPMLEKMGMA.CHCBHLIBGFA = true;
			FirebaseAnalyticsManager.JMDJBFAEHBM().LKONPEEDKNF(true, ((AGEHCPDNBFD)(-9)).ToString(), ((FFPHBMFGCNN)103).ToString(), BGHLMGPPCNN.subRewind.ToString(), false, false);
		}
	}

	// Token: 0x0600075F RID: 1887 RVA: 0x00033869 File Offset: 0x00031A69
	private void IGAOIMLPICH()
	{
		AKLFPGMDKLA.EHBBFMCILPC.NEFKLNPPBAI(true);
		this.doNotDisturbButton.sprite = (AKLFPGMDKLA.EHBBFMCILPC.CCBMHNGMFMC() ? this.doNotDisturbOnSprite : this.doNotDisturbOffSprite);
	}

	// Token: 0x06000760 RID: 1888 RVA: 0x00003E52 File Offset: 0x00002052
	private void BKCKPBDBHJM()
	{
	}

	// Token: 0x06000761 RID: 1889 RVA: 0x000334D8 File Offset: 0x000316D8
	private void MFDIBHNGACA()
	{
		AKLFPGMDKLA.EHBBFMCILPC.PFGPIMIIOKO(true);
		this.doNotDisturbButton.sprite = (AKLFPGMDKLA.EHBBFMCILPC.CCBMHNGMFMC() ? this.doNotDisturbOnSprite : this.doNotDisturbOffSprite);
	}

	// Token: 0x06000762 RID: 1890 RVA: 0x00031FF4 File Offset: 0x000301F4
	private void HKKPOAPEGEF()
	{
		AKLFPGMDKLA.EHBBFMCILPC.NEFKLNPPBAI(false);
		this.doNotDisturbButton.sprite = (AKLFPGMDKLA.EHBBFMCILPC.CCBMHNGMFMC() ? this.doNotDisturbOnSprite : this.doNotDisturbOffSprite);
	}

	// Token: 0x06000763 RID: 1891 RVA: 0x000349FC File Offset: 0x00032BFC
	private void OHPJIHEAMLJ()
	{
		this.ECNAKMPKBOE();
		this.headerTitle.gameObject.SetActive(true);
		this.friendsPageHeaderContainer.SetActive(false);
		this.headerFriendsPageTitle.SetText(CCOJBMMKNAP.KFDLFGHBPLP().DNILNCLIHAP("OnStoryInterfaceHeaderSettingsClick"), true);
		this.headerFriendsPageTitle.ForceMeshUpdate(true, true);
		this.friendsPlusIcon.SetActive(AKLFPGMDKLA.EHBBFMCILPC.AFKCCPIMDJH());
		this.doNotDisturbButton.sprite = (AKLFPGMDKLA.EHBBFMCILPC.CCBMHNGMFMC() ? this.doNotDisturbOnSprite : this.doNotDisturbOffSprite);
		this.editAvatarNameButton.SetActive(false);
		this.avatarButton.GetComponent<Button>().enabled = true;
		this.avatarButton.GetComponent<AnimationPress>().enabled = true;
		this.editAvatarImageButton.SetActive(false);
	}

	// Token: 0x06000765 RID: 1893 RVA: 0x00034AC8 File Offset: 0x00032CC8
	private void GEHAGJKFAKG(PMEPALPCEAF AEDICCFAKOM, ProfileItem2 PCCCLLPKDEF)
	{
		this.headerTitle.gameObject.SetActive(true);
		this.friendsPageHeaderContainer.SetActive(true);
		this.headerTitle.SetText(CCOJBMMKNAP.KMNBCEMEBBD().OGKGHLHHAAI("RunCustomCode() blocked by semaphore:"), true);
		this.avatarHeaderImage.sprite = this.headerRandomSprite;
		if (AEDICCFAKOM.LMFCFHMJIFN.Length == 0 || (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null && AEDICCFAKOM.LMFCFHMJIFN.Equals(AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.LMFCFHMJIFN)))
		{
			this.alreadyLikedButton.gameObject.SetActive(true);
			this.likeButton.gameObject.SetActive(false);
		}
		else if (PCCCLLPKDEF.AlreadyLiked())
		{
			this.likeButton.gameObject.SetActive(true);
			this.alreadyLikedButton.gameObject.SetActive(false);
		}
		else
		{
			this.alreadyLikedButton.gameObject.SetActive(true);
			this.likeButton.gameObject.SetActive(true);
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.JNNBNNDOGIM.EJACENIHDDC(AEDICCFAKOM))
		{
			this.addFriendButton.gameObject.SetActive(false);
			this.isFriendImage.gameObject.SetActive(false);
		}
		else
		{
			this.addFriendButton.gameObject.SetActive(false);
			this.isFriendImage.gameObject.SetActive(false);
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.EEBMPDNLJGD.Equals(AEDICCFAKOM.EEBMPDNLJGD))
		{
			this.addFriendButton.gameObject.SetActive(false);
		}
		this.editAvatarNameButton.SetActive(true);
		this.avatarButton.GetComponent<Button>().enabled = true;
		this.avatarButton.GetComponent<AnimationPress>().enabled = false;
		this.editAvatarImageButton.SetActive(true);
	}

	// Token: 0x06000766 RID: 1894 RVA: 0x00034C8C File Offset: 0x00032E8C
	private void KNMDNGALEGH(PMEPALPCEAF FOKFGMIEEDB)
	{
		this.offlineModeButton.SetActive(false);
		this.suspendedModeButton.SetActive(false);
		if (!FOKFGMIEEDB.GIFPFPOPEJN && AKLFPGMDKLA.EHBBFMCILPC.GNLNPMPJPEC())
		{
			this.offlineModeButton.SetActive(false);
		}
		if (FOKFGMIEEDB.LAKHGAPCKBC)
		{
			this.suspendedModeButton.SetActive(true);
			this.suspendedModeButton.GetComponent<Button>().enabled = false;
			this.suspendedModeButton.GetComponent<AnimationPress>().enabled = true;
			if (!FOKFGMIEEDB.GIFPFPOPEJN)
			{
				this.editAvatarImageButton.SetActive(true);
				this.avatarButton.GetComponent<Button>().enabled = true;
				this.avatarButton.GetComponent<AnimationPress>().enabled = false;
				this.editAvatarNameButton.SetActive(false);
				this.offlineModeButton.SetActive(true);
				return;
			}
			this.likeButton.gameObject.SetActive(false);
			this.suspendedModeButton.GetComponent<Button>().enabled = false;
			this.suspendedModeButton.GetComponent<AnimationPress>().enabled = false;
		}
	}

	// Token: 0x06000767 RID: 1895 RVA: 0x00034D8C File Offset: 0x00032F8C
	private void BJCCDNCEIEP(PMEPALPCEAF FOKFGMIEEDB)
	{
		this.reportButton.SetActive(false);
		this.reportedIcon.SetActive(false);
		if (FOKFGMIEEDB.LMFCFHMJIFN.Length != 0 && (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC == null || !FOKFGMIEEDB.LMFCFHMJIFN.Equals(AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.LMFCFHMJIFN)) && FOKFGMIEEDB.GIFPFPOPEJN && !FOKFGMIEEDB.LAKHGAPCKBC)
		{
			if (!AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.JNNBNNDOGIM.EJACENIHDDC(FOKFGMIEEDB))
			{
				this.reportButton.SetActive(false);
			}
			if (FOKFGMIEEDB.JECGGDNKBID())
			{
				this.reportButton.SetActive(false);
			}
		}
	}

	// Token: 0x06000768 RID: 1896 RVA: 0x00034E30 File Offset: 0x00033030
	public void SetAvatarIcon(PMEPALPCEAF AEDICCFAKOM)
	{
		string hjejjgafham = AEDICCFAKOM.PGJBIPFBMAN();
		ImageFrameAnimation component = this.avatarImageThumb.GetComponent<ImageFrameAnimation>();
		int num = AssetProfileData.OMPPDKODFAI(hjejjgafham);
		if (num >= 0)
		{
			JDMAEBPEIBE.KIIEJJOKODB(this.avatarImageThumb, num);
			return;
		}
		JDMAEBPEIBE.MHLOFOJCLIG(this.avatarImageThumb);
		if (component != null)
		{
			component.enabled = false;
		}
		this.avatarImageThumb.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.DJNLJPFFMBG(AEDICCFAKOM.PGJBIPFBMAN());
	}

	// Token: 0x06000769 RID: 1897 RVA: 0x00034EA4 File Offset: 0x000330A4
	private void KMKLPGICCAF()
	{
		CommonUserInterface.IKNOFBFMPGA().NPIOKKDPALC(CCOJBMMKNAP.CEGAOMEEFBE().FCOCLEHKLDJ("OnBackendPremiumChoiceException"), CCOJBMMKNAP.OBOOKJPGBJN().JLBEIFLLBLO("prof"), CCOJBMMKNAP.PMABBOJDELF().HHLECNIFHCO("consumePromoCode"), CCOJBMMKNAP.MPCBJEIMACA().HHLECNIFHCO("<alpha=#C0>"), new UnityAction(this.IAOGLBDDIKK), new UnityAction(this.DBDKHNNLFPP), new UnityAction(this.JKJIHKINJMA), (DFGILFBGPLN)(-85), 252f, -90);
	}

	// Token: 0x0600076A RID: 1898 RVA: 0x00034F28 File Offset: 0x00033128
	private void ECNAKMPKBOE()
	{
		this.headerTitle.gameObject.SetActive(true);
		this.friendsPageHeaderContainer.SetActive(true);
		this.headerTitle.SetText(CCOJBMMKNAP.JINDKPHNLBK().OGKGHLHHAAI("$READINPUT"), false);
		this.avatarHeaderImage.sprite = this.headerSprite;
		this.alreadyLikedButton.gameObject.SetActive(true);
		this.likeButton.gameObject.SetActive(true);
		this.isFriendImage.gameObject.SetActive(false);
		this.addFriendButton.gameObject.SetActive(true);
		this.editAvatarNameButton.SetActive(false);
		this.avatarButton.GetComponent<Button>().enabled = true;
		this.avatarButton.GetComponent<AnimationPress>().enabled = false;
		this.editAvatarImageButton.SetActive(true);
	}

	// Token: 0x0600076B RID: 1899 RVA: 0x00034FFC File Offset: 0x000331FC
	public void OGLDGGNNEBB(PMEPALPCEAF AEDICCFAKOM)
	{
		string hjejjgafham = AEDICCFAKOM.PGJBIPFBMAN();
		ImageFrameAnimation component = this.avatarImageThumb.GetComponent<ImageFrameAnimation>();
		int num = AssetProfileData.MBOLHDLKJOD(hjejjgafham);
		if (num >= 1)
		{
			JDMAEBPEIBE.JHHDPCGCBHO(this.avatarImageThumb, num);
			return;
		}
		JDMAEBPEIBE.CJDEHHPKDMI(this.avatarImageThumb);
		if (component != null)
		{
			component.enabled = false;
		}
		this.avatarImageThumb.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.AHBHMAGKMJJ(AEDICCFAKOM.PGJBIPFBMAN());
	}

	// Token: 0x0600076C RID: 1900 RVA: 0x00035070 File Offset: 0x00033270
	private void EILJJANCGKC(PMEPALPCEAF AEDICCFAKOM, ProfileItem2 PCCCLLPKDEF)
	{
		this.headerTitle.gameObject.SetActive(true);
		this.friendsPageHeaderContainer.SetActive(true);
		this.headerTitle.SetText(CCOJBMMKNAP.AEELGGPEJCC().IPEIONBNIPH(""), true);
		this.avatarHeaderImage.sprite = this.headerRandomSprite;
		if (AEDICCFAKOM.LMFCFHMJIFN.Length == 0 || (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null && AEDICCFAKOM.LMFCFHMJIFN.Equals(AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.LMFCFHMJIFN)))
		{
			this.alreadyLikedButton.gameObject.SetActive(true);
			this.likeButton.gameObject.SetActive(true);
		}
		else if (PCCCLLPKDEF.AlreadyLiked())
		{
			this.likeButton.gameObject.SetActive(true);
			this.alreadyLikedButton.gameObject.SetActive(false);
		}
		else
		{
			this.alreadyLikedButton.gameObject.SetActive(true);
			this.likeButton.gameObject.SetActive(false);
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.JNNBNNDOGIM.EJACENIHDDC(AEDICCFAKOM))
		{
			this.addFriendButton.gameObject.SetActive(true);
			this.isFriendImage.gameObject.SetActive(true);
		}
		else
		{
			this.addFriendButton.gameObject.SetActive(true);
			this.isFriendImage.gameObject.SetActive(false);
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.EEBMPDNLJGD.Equals(AEDICCFAKOM.EEBMPDNLJGD))
		{
			this.addFriendButton.gameObject.SetActive(true);
		}
		this.editAvatarNameButton.SetActive(true);
		this.avatarButton.GetComponent<Button>().enabled = true;
		this.avatarButton.GetComponent<AnimationPress>().enabled = false;
		this.editAvatarImageButton.SetActive(true);
	}

	// Token: 0x0600076D RID: 1901 RVA: 0x00035234 File Offset: 0x00033434
	private void HGIKMKFEKIJ()
	{
		this.HNKNOHDHDGO();
		this.headerTitle.gameObject.SetActive(false);
		this.friendsPageHeaderContainer.SetActive(true);
		this.headerFriendsPageTitle.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("myfriendspagetitle"), true);
		this.headerFriendsPageTitle.ForceMeshUpdate(false, false);
		this.friendsPlusIcon.SetActive(AKLFPGMDKLA.EHBBFMCILPC.AFKCCPIMDJH());
		this.doNotDisturbButton.sprite = (AKLFPGMDKLA.EHBBFMCILPC.CCBMHNGMFMC() ? this.doNotDisturbOnSprite : this.doNotDisturbOffSprite);
		this.editAvatarNameButton.SetActive(false);
		this.avatarButton.GetComponent<Button>().enabled = false;
		this.avatarButton.GetComponent<AnimationPress>().enabled = false;
		this.editAvatarImageButton.SetActive(false);
	}

	// Token: 0x0600076E RID: 1902 RVA: 0x00035300 File Offset: 0x00033500
	private void LPFCLPNODLO()
	{
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtonsAndCloseOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialdonotdisturb0"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("no"), new UnityAction(this.IAOGLBDDIKK), new UnityAction(this.DBDKHNNLFPP), new UnityAction(this.PACAHDJKCAH), DFGILFBGPLN.popupQuitConfirm, 0.25f, 28);
	}

	// Token: 0x0600076F RID: 1903 RVA: 0x00035384 File Offset: 0x00033584
	private void HNKNOHDHDGO()
	{
		this.headerTitle.gameObject.SetActive(true);
		this.friendsPageHeaderContainer.SetActive(false);
		this.headerTitle.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("profileoption"), true);
		this.avatarHeaderImage.sprite = this.headerSprite;
		this.alreadyLikedButton.gameObject.SetActive(false);
		this.likeButton.gameObject.SetActive(false);
		this.isFriendImage.gameObject.SetActive(false);
		this.addFriendButton.gameObject.SetActive(false);
		this.editAvatarNameButton.SetActive(true);
		this.avatarButton.GetComponent<Button>().enabled = true;
		this.avatarButton.GetComponent<AnimationPress>().enabled = true;
		this.editAvatarImageButton.SetActive(true);
	}

	// Token: 0x040001BA RID: 442
	public TextMeshProUGUI headerTitle;

	// Token: 0x040001BB RID: 443
	public TextMeshProUGUI nickNameText;

	// Token: 0x040001BC RID: 444
	public Image avatarHeaderImage;

	// Token: 0x040001BD RID: 445
	public Sprite headerRandomSprite;

	// Token: 0x040001BE RID: 446
	public Sprite headerSprite;

	// Token: 0x040001BF RID: 447
	public Button likeButton;

	// Token: 0x040001C0 RID: 448
	public Button alreadyLikedButton;

	// Token: 0x040001C1 RID: 449
	public TextMeshProUGUI levelText;

	// Token: 0x040001C2 RID: 450
	public TextMeshProUGUI friendsCountText;

	// Token: 0x040001C3 RID: 451
	public TextMeshProUGUI topText;

	// Token: 0x040001C4 RID: 452
	public TextMeshProUGUI likesText;

	// Token: 0x040001C5 RID: 453
	public GameObject offlineModeButton;

	// Token: 0x040001C6 RID: 454
	public GameObject suspendedModeButton;

	// Token: 0x040001C7 RID: 455
	public GameObject reportButton;

	// Token: 0x040001C8 RID: 456
	public GameObject reportedIcon;

	// Token: 0x040001C9 RID: 457
	public Image avatarImageThumb;

	// Token: 0x040001CA RID: 458
	public Button addFriendButton;

	// Token: 0x040001CB RID: 459
	public Image isFriendImage;

	// Token: 0x040001CC RID: 460
	public Image hallOfFameImage;

	// Token: 0x040001CD RID: 461
	public Image topImage;

	// Token: 0x040001CE RID: 462
	public Sprite defaultLevelSprite;

	// Token: 0x040001CF RID: 463
	public Sprite hallOfFameSprite;

	// Token: 0x040001D0 RID: 464
	public GameObject editAvatarNameButton;

	// Token: 0x040001D1 RID: 465
	public GameObject avatarButton;

	// Token: 0x040001D2 RID: 466
	public GameObject editAvatarImageButton;

	// Token: 0x040001D3 RID: 467
	[Header("FriendsPageHeader")]
	public GameObject friendsPageHeaderContainer;

	// Token: 0x040001D4 RID: 468
	public TextMeshProUGUI headerFriendsPageTitle;

	// Token: 0x040001D5 RID: 469
	public GameObject friendsPlusIcon;

	// Token: 0x040001D6 RID: 470
	public Image doNotDisturbButton;

	// Token: 0x040001D7 RID: 471
	public Sprite doNotDisturbOnSprite;

	// Token: 0x040001D8 RID: 472
	public Sprite doNotDisturbOffSprite;

	// Token: 0x040001D9 RID: 473
	private PMEPALPCEAF IJPMLEKMGMA;
}
