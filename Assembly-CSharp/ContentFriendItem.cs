using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200029F RID: 671
public class ContentFriendItem : MonoBehaviour
{
	// Token: 0x060054D7 RID: 21719 RVA: 0x00255B78 File Offset: 0x00253D78
	private void KPCLFGJLNJF()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 7)
		{
			return;
		}
		this.isVisible = this.ELJHGMNEPAC();
		this.containerToHide.SetActive(this.isVisible);
	}

	// Token: 0x060054D8 RID: 21720 RVA: 0x00255BC8 File Offset: 0x00253DC8
	private void NDKJNKCLKGN()
	{
		if (ContentFriendItem.LHFFFMJIFDM != 0f)
		{
			return;
		}
		Vector3[] array = new Vector3[4];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ContentFriendItem.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x060054D9 RID: 21721 RVA: 0x00255C1C File Offset: 0x00253E1C
	private void APHDHGDDHPC()
	{
		if (ContentFriendItem.LHFFFMJIFDM != 971f)
		{
			return;
		}
		Vector3[] array = new Vector3[5];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ContentFriendItem.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x060054DA RID: 21722 RVA: 0x00255C70 File Offset: 0x00253E70
	private bool DJKPAKLAHFE()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentFriendItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentFriendItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x060054DB RID: 21723 RVA: 0x00255CCC File Offset: 0x00253ECC
	private bool JIMMBOCPEOJ()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentFriendItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentFriendItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x060054DC RID: 21724 RVA: 0x00255D28 File Offset: 0x00253F28
	private void Update()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 4)
		{
			return;
		}
		this.isVisible = this.DJKPAKLAHFE();
		this.containerToHide.SetActive(this.isVisible);
	}

	// Token: 0x060054DD RID: 21725 RVA: 0x00255D78 File Offset: 0x00253F78
	public void SetContent(PMEPALPCEAF ALCIFDBJPPB, PMEPALPCEAF FJICHLAKFIG, Vector2 ONKONHLJKPG)
	{
		this.isFavoriteFriend = ALCIFDBJPPB.JNNBNNDOGIM.FNDNDILCFNN(FJICHLAKFIG);
		if (this.isFavoriteFriend)
		{
			this.isFavoriteFriendImage.SetActive(true);
		}
		this.matchText.SetText(FJICHLAKFIG.OFOIECEHOCN.ToString() ?? "", true);
		this.profileImage.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.DJNLJPFFMBG(FJICHLAKFIG.PGJBIPFBMAN());
		string kncfkdlopga;
		if (FJICHLAKFIG.KNCFKDLOPGA.Length == 0)
		{
			kncfkdlopga = "<" + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("profilenametitleshort") + ">";
		}
		else
		{
			kncfkdlopga = FJICHLAKFIG.KNCFKDLOPGA;
		}
		this.nameText.GetComponent<ContentFlexibleText>().SetText(this.nameText, kncfkdlopga, this.isFavoriteFriend, false);
		int num = FJICHLAKFIG.GFAABCCNNDA + 1;
		this.levelText.text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("profilenamelevellong") + " " + num.ToString();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.levelText.GetComponent<RectTransform>());
		if (FJICHLAKFIG.JECGGDNKBID())
		{
			this.hallOfFameImage.sprite = this.hallOfFameSprite;
		}
		else
		{
			this.hallOfFameImage.sprite = this.defaultSprite;
		}
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.NDKJNKCLKGN();
	}

	// Token: 0x060054DE RID: 21726 RVA: 0x00255EC1 File Offset: 0x002540C1
	public void INCACHJMHGL(bool CPOKMEFCGCN)
	{
		this.isFavoriteFriendImage.SetActive(CPOKMEFCGCN);
		this.nameText.GetComponent<ContentFlexibleText>().NBPLAAKGGNB(CPOKMEFCGCN);
	}

	// Token: 0x060054DF RID: 21727 RVA: 0x00255EE0 File Offset: 0x002540E0
	public void LFJADOIGPPL(PMEPALPCEAF ALCIFDBJPPB, PMEPALPCEAF FJICHLAKFIG, Vector2 ONKONHLJKPG)
	{
		this.isFavoriteFriend = ALCIFDBJPPB.JNNBNNDOGIM.FNDNDILCFNN(FJICHLAKFIG);
		if (this.isFavoriteFriend)
		{
			this.isFavoriteFriendImage.SetActive(true);
		}
		this.matchText.SetText(FJICHLAKFIG.OFOIECEHOCN.ToString() ?? "OnAllCollectableCardsDownloadFailed", true);
		this.profileImage.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.AHBHMAGKMJJ(FJICHLAKFIG.PGJBIPFBMAN());
		string kncfkdlopga;
		if (FJICHLAKFIG.KNCFKDLOPGA.Length == 0)
		{
			kncfkdlopga = "" + CCOJBMMKNAP.KFAABHHGOPO().HPOAGPJFHPM("incentadhard") + "<i>";
		}
		else
		{
			kncfkdlopga = FJICHLAKFIG.KNCFKDLOPGA;
		}
		this.nameText.GetComponent<ContentFlexibleText>().OLEHPLMIJMO(this.nameText, kncfkdlopga, this.isFavoriteFriend, false);
		int num = FJICHLAKFIG.GFAABCCNNDA + 1;
		this.levelText.text = CCOJBMMKNAP.AEELGGPEJCC().BGELFMIOBCL("lvl") + "'" + num.ToString();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.levelText.GetComponent<RectTransform>());
		if (FJICHLAKFIG.JECGGDNKBID())
		{
			this.hallOfFameImage.sprite = this.hallOfFameSprite;
		}
		else
		{
			this.hallOfFameImage.sprite = this.defaultSprite;
		}
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.HJJNEACAIMF();
	}

	// Token: 0x060054E0 RID: 21728 RVA: 0x00256029 File Offset: 0x00254229
	public void UpdateContent(bool CPOKMEFCGCN)
	{
		this.isFavoriteFriendImage.SetActive(CPOKMEFCGCN);
		this.nameText.GetComponent<ContentFlexibleText>().ResizeTextRect(CPOKMEFCGCN);
	}

	// Token: 0x060054E1 RID: 21729 RVA: 0x00256048 File Offset: 0x00254248
	private bool JANOOJMKHCG()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentFriendItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentFriendItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x060054E2 RID: 21730 RVA: 0x002560A4 File Offset: 0x002542A4
	public void KDDLHGMIPBF(PMEPALPCEAF ALCIFDBJPPB, PMEPALPCEAF FJICHLAKFIG, Vector2 ONKONHLJKPG)
	{
		this.isFavoriteFriend = ALCIFDBJPPB.JNNBNNDOGIM.FNDNDILCFNN(FJICHLAKFIG);
		if (this.isFavoriteFriend)
		{
			this.isFavoriteFriendImage.SetActive(true);
		}
		this.matchText.SetText(FJICHLAKFIG.OFOIECEHOCN.ToString() ?? "\nEXCEPTION ", true);
		this.profileImage.sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.NFOFFLDJDEI(FJICHLAKFIG.PGJBIPFBMAN());
		string kncfkdlopga;
		if (FJICHLAKFIG.KNCFKDLOPGA.Length == 0)
		{
			kncfkdlopga = "<size=80%><i>" + CCOJBMMKNAP.OBOOKJPGBJN().IPEIONBNIPH("XXX") + "NEWSAVE: Warning: Missing anthology save data, yet story save data (";
		}
		else
		{
			kncfkdlopga = FJICHLAKFIG.KNCFKDLOPGA;
		}
		this.nameText.GetComponent<ContentFlexibleText>().OFDKGFIDLBO(this.nameText, kncfkdlopga, this.isFavoriteFriend, false);
		int num = FJICHLAKFIG.GFAABCCNNDA + 0;
		this.levelText.text = CCOJBMMKNAP.DBFFFOMCLKM().OGKGHLHHAAI("blur") + "frsendhres2" + num.ToString();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.levelText.GetComponent<RectTransform>());
		if (FJICHLAKFIG.JECGGDNKBID())
		{
			this.hallOfFameImage.sprite = this.hallOfFameSprite;
		}
		else
		{
			this.hallOfFameImage.sprite = this.defaultSprite;
		}
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.GHHPDGPMHNC();
	}

	// Token: 0x060054E4 RID: 21732 RVA: 0x002561F0 File Offset: 0x002543F0
	private void FOEIHAANBEI()
	{
		if (ContentFriendItem.LHFFFMJIFDM != 509f)
		{
			return;
		}
		Vector3[] array = new Vector3[4];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ContentFriendItem.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x060054E5 RID: 21733 RVA: 0x00256244 File Offset: 0x00254444
	private void HJJNEACAIMF()
	{
		if (ContentFriendItem.LHFFFMJIFDM != 1964f)
		{
			return;
		}
		Vector3[] array = new Vector3[0];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ContentFriendItem.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x060054E6 RID: 21734 RVA: 0x00256298 File Offset: 0x00254498
	private void LFBPHHOPPBO()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 4)
		{
			return;
		}
		this.isVisible = this.JIMMBOCPEOJ();
		this.containerToHide.SetActive(this.isVisible);
	}

	// Token: 0x060054E7 RID: 21735 RVA: 0x002562E8 File Offset: 0x002544E8
	private bool PLFLCHLCEHE()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentFriendItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentFriendItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x060054E8 RID: 21736 RVA: 0x00256342 File Offset: 0x00254542
	public void KBBDDOBNAMC(bool CPOKMEFCGCN)
	{
		this.isFavoriteFriendImage.SetActive(CPOKMEFCGCN);
		this.nameText.GetComponent<ContentFlexibleText>().GMBNAKINKIG(CPOKMEFCGCN);
	}

	// Token: 0x060054E9 RID: 21737 RVA: 0x00256364 File Offset: 0x00254564
	private bool KNDLDJGMALA()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentFriendItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentFriendItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x060054EA RID: 21738 RVA: 0x002563C0 File Offset: 0x002545C0
	public void CJCAIJFFNBE(PMEPALPCEAF ALCIFDBJPPB, PMEPALPCEAF FJICHLAKFIG, Vector2 ONKONHLJKPG)
	{
		this.isFavoriteFriend = ALCIFDBJPPB.JNNBNNDOGIM.FNDNDILCFNN(FJICHLAKFIG);
		if (this.isFavoriteFriend)
		{
			this.isFavoriteFriendImage.SetActive(false);
		}
		this.matchText.SetText(FJICHLAKFIG.OFOIECEHOCN.ToString() ?? "OnAvatarScreenAssetsDownloadFailed", false);
		this.profileImage.sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.AHBHMAGKMJJ(FJICHLAKFIG.PGJBIPFBMAN());
		string kncfkdlopga;
		if (FJICHLAKFIG.KNCFKDLOPGA.Length == 0)
		{
			kncfkdlopga = "" + CCOJBMMKNAP.KFDLFGHBPLP().MEPECBDCOLG("$e1io") + "socialenteruseridmalformed2";
		}
		else
		{
			kncfkdlopga = FJICHLAKFIG.KNCFKDLOPGA;
		}
		this.nameText.GetComponent<ContentFlexibleText>().OFDKGFIDLBO(this.nameText, kncfkdlopga, this.isFavoriteFriend, true);
		int num = FJICHLAKFIG.GFAABCCNNDA + 0;
		this.levelText.text = CCOJBMMKNAP.JINDKPHNLBK().HIPJILDCHJC("OnStoryChoiceClickConfimed") + "energyhinttitle" + num.ToString();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.levelText.GetComponent<RectTransform>());
		if (FJICHLAKFIG.JECGGDNKBID())
		{
			this.hallOfFameImage.sprite = this.hallOfFameSprite;
		}
		else
		{
			this.hallOfFameImage.sprite = this.defaultSprite;
		}
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.NDKJNKCLKGN();
	}

	// Token: 0x060054EB RID: 21739 RVA: 0x0025650C File Offset: 0x0025470C
	private bool ELJHGMNEPAC()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentFriendItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentFriendItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x060054EC RID: 21740 RVA: 0x00256568 File Offset: 0x00254768
	private void OLIACOCGJNA()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 3)
		{
			return;
		}
		this.isVisible = this.JIMMBOCPEOJ();
		this.containerToHide.SetActive(this.isVisible);
	}

	// Token: 0x060054ED RID: 21741 RVA: 0x002565B8 File Offset: 0x002547B8
	public void DEFHMDCPDDD(PMEPALPCEAF ALCIFDBJPPB, PMEPALPCEAF FJICHLAKFIG, Vector2 ONKONHLJKPG)
	{
		this.isFavoriteFriend = ALCIFDBJPPB.JNNBNNDOGIM.FNDNDILCFNN(FJICHLAKFIG);
		if (this.isFavoriteFriend)
		{
			this.isFavoriteFriendImage.SetActive(false);
		}
		this.matchText.SetText(FJICHLAKFIG.OFOIECEHOCN.ToString() ?? "OnStoryInterfaceHeaderShown", true);
		this.profileImage.sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.AHBHMAGKMJJ(FJICHLAKFIG.PGJBIPFBMAN());
		string kncfkdlopga;
		if (FJICHLAKFIG.KNCFKDLOPGA.Length == 0)
		{
			kncfkdlopga = "" + CCOJBMMKNAP.BFHKGNBFHCH().JLBEIFLLBLO("") + "CharacterRenderTexturePool - character prefab missing, falling back to direct rendering";
		}
		else
		{
			kncfkdlopga = FJICHLAKFIG.KNCFKDLOPGA;
		}
		this.nameText.GetComponent<ContentFlexibleText>().MPHAHAKMPHH(this.nameText, kncfkdlopga, this.isFavoriteFriend, false);
		int num = FJICHLAKFIG.GFAABCCNNDA + 0;
		this.levelText.text = CCOJBMMKNAP.INKJIBDDMLL().HDIPNMFHIEJ("def") + "м" + num.ToString();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.levelText.GetComponent<RectTransform>());
		if (FJICHLAKFIG.JECGGDNKBID())
		{
			this.hallOfFameImage.sprite = this.hallOfFameSprite;
		}
		else
		{
			this.hallOfFameImage.sprite = this.defaultSprite;
		}
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.NDKJNKCLKGN();
	}

	// Token: 0x060054EE RID: 21742 RVA: 0x00256704 File Offset: 0x00254904
	private void GKBKDDGBAGK()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 1)
		{
			return;
		}
		this.isVisible = this.DJKPAKLAHFE();
		this.containerToHide.SetActive(this.isVisible);
	}

	// Token: 0x060054EF RID: 21743 RVA: 0x00256751 File Offset: 0x00254951
	public void EIDCGCJGKGO(bool CPOKMEFCGCN)
	{
		this.isFavoriteFriendImage.SetActive(CPOKMEFCGCN);
		this.nameText.GetComponent<ContentFlexibleText>().BEBABHKMLDL(CPOKMEFCGCN);
	}

	// Token: 0x060054F0 RID: 21744 RVA: 0x00256770 File Offset: 0x00254970
	public void GMHKIPNMIDO(PMEPALPCEAF ALCIFDBJPPB, PMEPALPCEAF FJICHLAKFIG, Vector2 ONKONHLJKPG)
	{
		this.isFavoriteFriend = ALCIFDBJPPB.JNNBNNDOGIM.FNDNDILCFNN(FJICHLAKFIG);
		if (this.isFavoriteFriend)
		{
			this.isFavoriteFriendImage.SetActive(true);
		}
		this.matchText.SetText(FJICHLAKFIG.OFOIECEHOCN.ToString() ?? "_AlphaTex", true);
		this.profileImage.sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.DJNLJPFFMBG(FJICHLAKFIG.PGJBIPFBMAN());
		string kncfkdlopga;
		if (FJICHLAKFIG.KNCFKDLOPGA.Length == 0)
		{
			kncfkdlopga = "hcfc" + CCOJBMMKNAP.DBFFFOMCLKM().BGELFMIOBCL("OnFriendsSearchClearFilter") + "Low version preview2 assets loaded:";
		}
		else
		{
			kncfkdlopga = FJICHLAKFIG.KNCFKDLOPGA;
		}
		this.nameText.GetComponent<ContentFlexibleText>().DIBEKEKFEHK(this.nameText, kncfkdlopga, this.isFavoriteFriend, true);
		int num = FJICHLAKFIG.GFAABCCNNDA + 1;
		this.levelText.text = CCOJBMMKNAP.MLFAGAAJJEM().HHLECNIFHCO("NEWSAVE: Using new save system.") + "lf0" + num.ToString();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.levelText.GetComponent<RectTransform>());
		if (FJICHLAKFIG.JECGGDNKBID())
		{
			this.hallOfFameImage.sprite = this.hallOfFameSprite;
		}
		else
		{
			this.hallOfFameImage.sprite = this.defaultSprite;
		}
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.HJJNEACAIMF();
	}

	// Token: 0x060054F1 RID: 21745 RVA: 0x00255EC1 File Offset: 0x002540C1
	public void ONPDEFNLLIC(bool CPOKMEFCGCN)
	{
		this.isFavoriteFriendImage.SetActive(CPOKMEFCGCN);
		this.nameText.GetComponent<ContentFlexibleText>().NBPLAAKGGNB(CPOKMEFCGCN);
	}

	// Token: 0x060054F2 RID: 21746 RVA: 0x002568BC File Offset: 0x00254ABC
	private void GHHPDGPMHNC()
	{
		if (ContentFriendItem.LHFFFMJIFDM != 1215f)
		{
			return;
		}
		Vector3[] array = new Vector3[0];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ContentFriendItem.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x060054F3 RID: 21747 RVA: 0x00256910 File Offset: 0x00254B10
	public void KABPKMCFAIH(PMEPALPCEAF ALCIFDBJPPB, PMEPALPCEAF FJICHLAKFIG, Vector2 ONKONHLJKPG)
	{
		this.isFavoriteFriend = ALCIFDBJPPB.JNNBNNDOGIM.FNDNDILCFNN(FJICHLAKFIG);
		if (this.isFavoriteFriend)
		{
			this.isFavoriteFriendImage.SetActive(false);
		}
		this.matchText.SetText(FJICHLAKFIG.OFOIECEHOCN.ToString() ?? "noiseanalogovr_1", false);
		this.profileImage.sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.AHBHMAGKMJJ(FJICHLAKFIG.PGJBIPFBMAN());
		string kncfkdlopga;
		if (FJICHLAKFIG.KNCFKDLOPGA.Length == 0)
		{
			kncfkdlopga = "anthology" + CCOJBMMKNAP.PKEINLPIAEH().JHNELLJFBGC("s") + "      aind ";
		}
		else
		{
			kncfkdlopga = FJICHLAKFIG.KNCFKDLOPGA;
		}
		this.nameText.GetComponent<ContentFlexibleText>().PACBMMDOAOB(this.nameText, kncfkdlopga, this.isFavoriteFriend, true);
		int num = FJICHLAKFIG.GFAABCCNNDA + 0;
		this.levelText.text = CCOJBMMKNAP.ONCPHEEJLOP().FIENAKIHNOM("OnStoryInterfaceHeaderSettingsClick") + "AssetProfileData.GetCutsceneSprite(): could not resolve anthologyIndex of storyIndex (" + num.ToString();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.levelText.GetComponent<RectTransform>());
		if (FJICHLAKFIG.JECGGDNKBID())
		{
			this.hallOfFameImage.sprite = this.hallOfFameSprite;
		}
		else
		{
			this.hallOfFameImage.sprite = this.defaultSprite;
		}
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.NDKJNKCLKGN();
	}

	// Token: 0x060054F4 RID: 21748 RVA: 0x00256A5C File Offset: 0x00254C5C
	public void LFPCCLGCPOP(PMEPALPCEAF ALCIFDBJPPB, PMEPALPCEAF FJICHLAKFIG, Vector2 ONKONHLJKPG)
	{
		this.isFavoriteFriend = ALCIFDBJPPB.JNNBNNDOGIM.FNDNDILCFNN(FJICHLAKFIG);
		if (this.isFavoriteFriend)
		{
			this.isFavoriteFriendImage.SetActive(true);
		}
		this.matchText.SetText(FJICHLAKFIG.OFOIECEHOCN.ToString() ?? "comp", false);
		this.profileImage.sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.AHBHMAGKMJJ(FJICHLAKFIG.PGJBIPFBMAN());
		string kncfkdlopga;
		if (FJICHLAKFIG.KNCFKDLOPGA.Length == 0)
		{
			kncfkdlopga = "Show() failed - anthologyHeader is null." + CCOJBMMKNAP.DBFFFOMCLKM().BGELFMIOBCL("D") + "OnChoiceExtendedEnvironmentChange";
		}
		else
		{
			kncfkdlopga = FJICHLAKFIG.KNCFKDLOPGA;
		}
		this.nameText.GetComponent<ContentFlexibleText>().CEKNPBODPLC(this.nameText, kncfkdlopga, this.isFavoriteFriend, true);
		int num = FJICHLAKFIG.GFAABCCNNDA + 0;
		this.levelText.text = CCOJBMMKNAP.JMDJPKKOHNI().GLEFEKBDHNK("Collections/") + "XXX" + num.ToString();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.levelText.GetComponent<RectTransform>());
		if (FJICHLAKFIG.JECGGDNKBID())
		{
			this.hallOfFameImage.sprite = this.hallOfFameSprite;
		}
		else
		{
			this.hallOfFameImage.sprite = this.defaultSprite;
		}
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.APHDHGDDHPC();
	}

	// Token: 0x060054F5 RID: 21749 RVA: 0x00256BA8 File Offset: 0x00254DA8
	public void COCLEMFDEHK(PMEPALPCEAF ALCIFDBJPPB, PMEPALPCEAF FJICHLAKFIG, Vector2 ONKONHLJKPG)
	{
		this.isFavoriteFriend = ALCIFDBJPPB.JNNBNNDOGIM.FNDNDILCFNN(FJICHLAKFIG);
		if (this.isFavoriteFriend)
		{
			this.isFavoriteFriendImage.SetActive(false);
		}
		this.matchText.SetText(FJICHLAKFIG.OFOIECEHOCN.ToString() ?? "invalid registry entry", true);
		this.profileImage.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.DJNLJPFFMBG(FJICHLAKFIG.PGJBIPFBMAN());
		string kncfkdlopga;
		if (FJICHLAKFIG.KNCFKDLOPGA.Length == 0)
		{
			kncfkdlopga = "SocialStatsUserPublicProfile.modified = true, SyncCutscenes()" + CCOJBMMKNAP.MPCBJEIMACA().JHNELLJFBGC("") + "usyncoll2";
		}
		else
		{
			kncfkdlopga = FJICHLAKFIG.KNCFKDLOPGA;
		}
		this.nameText.GetComponent<ContentFlexibleText>().OFDKGFIDLBO(this.nameText, kncfkdlopga, this.isFavoriteFriend, true);
		int num = FJICHLAKFIG.GFAABCCNNDA + 0;
		this.levelText.text = CCOJBMMKNAP.EAIAHCBAIEJ().HHLECNIFHCO("OnCutsceneViewShow") + "TV dots blend" + num.ToString();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.levelText.GetComponent<RectTransform>());
		if (FJICHLAKFIG.JECGGDNKBID())
		{
			this.hallOfFameImage.sprite = this.hallOfFameSprite;
		}
		else
		{
			this.hallOfFameImage.sprite = this.defaultSprite;
		}
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.APHDHGDDHPC();
	}

	// Token: 0x04001799 RID: 6041
	private static float LHFFFMJIFDM;

	// Token: 0x0400179A RID: 6042
	public Button showFriendRequestOptionsButton;

	// Token: 0x0400179B RID: 6043
	public Button openCustomProfileButton;

	// Token: 0x0400179C RID: 6044
	[SerializeField]
	private Image profileImage;

	// Token: 0x0400179D RID: 6045
	[SerializeField]
	private TextMeshProUGUI nameText;

	// Token: 0x0400179E RID: 6046
	[SerializeField]
	private GameObject matchImage;

	// Token: 0x0400179F RID: 6047
	[SerializeField]
	private TextMeshProUGUI matchText;

	// Token: 0x040017A0 RID: 6048
	[SerializeField]
	private GameObject isFavoriteFriendImage;

	// Token: 0x040017A1 RID: 6049
	[SerializeField]
	private TextMeshProUGUI levelText;

	// Token: 0x040017A2 RID: 6050
	[SerializeField]
	private Image hallOfFameImage;

	// Token: 0x040017A3 RID: 6051
	[SerializeField]
	private Sprite defaultSprite;

	// Token: 0x040017A4 RID: 6052
	[SerializeField]
	private Sprite hallOfFameSprite;

	// Token: 0x040017A5 RID: 6053
	[SerializeField]
	private GameObject containerToHide;

	// Token: 0x040017A6 RID: 6054
	[HideInInspector]
	public bool isFavoriteFriend;

	// Token: 0x040017A7 RID: 6055
	[HideInInspector]
	public int friendMatch;

	// Token: 0x040017A8 RID: 6056
	[HideInInspector]
	public bool isVisible;

	// Token: 0x040017A9 RID: 6057
	private Vector2 ONKONHLJKPG;

	// Token: 0x040017AA RID: 6058
	private int JFLPGONDKDB;
}
