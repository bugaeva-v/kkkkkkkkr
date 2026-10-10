using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020004C8 RID: 1224
public class ContentHallOfFameItem : MonoBehaviour
{
	// Token: 0x0600931B RID: 37659 RVA: 0x0040F3D8 File Offset: 0x0040D5D8
	private void EDLLAIFCKDP()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 4)
		{
			return;
		}
		this.isVisible = this.EDAELBKJONL();
		this.containerToHide.SetActive(this.isVisible);
	}

	// Token: 0x0600931C RID: 37660 RVA: 0x0040F428 File Offset: 0x0040D628
	private void LOLCNLFKJCC()
	{
		JDMAEBPEIBE.MNADABECONL(this.profileImage);
		this.profileImage.sprite = null;
		if (this.BAPAGHLFADF != null)
		{
			UnityEngine.Object.Destroy(this.BAPAGHLFADF);
		}
		this.profileButton.onClick.RemoveAllListeners();
		this.historicalRankButton.onClick.RemoveAllListeners();
	}

	// Token: 0x0600931D RID: 37661 RVA: 0x0040F488 File Offset: 0x0040D688
	private void MBAJBIPOFCB()
	{
		JDMAEBPEIBE.LMFBLLCKBFG(this.profileImage);
		this.profileImage.sprite = null;
		if (this.BAPAGHLFADF != null)
		{
			UnityEngine.Object.Destroy(this.BAPAGHLFADF);
		}
		this.profileButton.onClick.RemoveAllListeners();
		this.historicalRankButton.onClick.RemoveAllListeners();
	}

	// Token: 0x0600931E RID: 37662 RVA: 0x0040F4E8 File Offset: 0x0040D6E8
	private bool NNELPFOLMED()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentHallOfFameItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentHallOfFameItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x0600931F RID: 37663 RVA: 0x0040F544 File Offset: 0x0040D744
	private void JAIDEFDDAIB()
	{
		JDMAEBPEIBE.BIGKGBBKHNJ(this.profileImage);
		this.profileImage.sprite = null;
		if (this.BAPAGHLFADF != null)
		{
			UnityEngine.Object.Destroy(this.BAPAGHLFADF);
		}
		this.profileButton.onClick.RemoveAllListeners();
		this.historicalRankButton.onClick.RemoveAllListeners();
	}

	// Token: 0x06009320 RID: 37664 RVA: 0x0040F5A4 File Offset: 0x0040D7A4
	private void HJJNEACAIMF()
	{
		if (ContentHallOfFameItem.LHFFFMJIFDM != 382f)
		{
			return;
		}
		Vector3[] array = new Vector3[3];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ContentHallOfFameItem.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x06009321 RID: 37665 RVA: 0x0040F5F8 File Offset: 0x0040D7F8
	private bool DJKPAKLAHFE()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentHallOfFameItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentHallOfFameItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x06009322 RID: 37666 RVA: 0x0040F654 File Offset: 0x0040D854
	private void EBDLBINPKGD()
	{
		if (ContentHallOfFameItem.LHFFFMJIFDM != 1287f)
		{
			return;
		}
		Vector3[] array = new Vector3[1];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ContentHallOfFameItem.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x06009323 RID: 37667 RVA: 0x0040F6A8 File Offset: 0x0040D8A8
	private void PMLPALOKNNM()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 1)
		{
			return;
		}
		this.isVisible = this.OMLAJCPEFMM();
		this.containerToHide.SetActive(this.isVisible);
	}

	// Token: 0x06009324 RID: 37668 RVA: 0x0040F6F8 File Offset: 0x0040D8F8
	private void DMEEIPBHABJ()
	{
		if (ContentHallOfFameItem.LHFFFMJIFDM != 1256f)
		{
			return;
		}
		Vector3[] array = new Vector3[0];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ContentHallOfFameItem.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x06009325 RID: 37669 RVA: 0x0040F74C File Offset: 0x0040D94C
	private void HHKODCMDAHD()
	{
		JDMAEBPEIBE.FOCLHGGNKJP(this.profileImage);
		this.profileImage.sprite = null;
		if (this.BAPAGHLFADF != null)
		{
			UnityEngine.Object.Destroy(this.BAPAGHLFADF);
		}
		this.profileButton.onClick.RemoveAllListeners();
		this.historicalRankButton.onClick.RemoveAllListeners();
	}

	// Token: 0x06009326 RID: 37670 RVA: 0x0040F7AC File Offset: 0x0040D9AC
	private void MDBDJPIGPPI()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 4)
		{
			return;
		}
		this.isVisible = this.HJCPHEOABCG();
		this.containerToHide.SetActive(this.isVisible);
	}

	// Token: 0x06009327 RID: 37671 RVA: 0x0040F7FC File Offset: 0x0040D9FC
	public void MKHLAACHHPP(PMEPALPCEAF AEDICCFAKOM)
	{
		string hjejjgafham = AEDICCFAKOM.PGJBIPFBMAN();
		this.BAPAGHLFADF = this.profileImage.GetComponent<ImageFrameAnimation>();
		int num = AssetProfileData.OMPPDKODFAI(hjejjgafham);
		if (num >= 0)
		{
			JDMAEBPEIBE.FPDLNEHJAGB(this.profileImage, num);
			this.BAPAGHLFADF = this.profileImage.GetComponent<ImageFrameAnimation>();
			return;
		}
		JDMAEBPEIBE.GFFAPCMJCFD(this.profileImage);
		if (this.BAPAGHLFADF != null)
		{
			this.BAPAGHLFADF.enabled = false;
		}
		this.profileImage.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.NFOFFLDJDEI(AEDICCFAKOM.PGJBIPFBMAN());
	}

	// Token: 0x06009328 RID: 37672 RVA: 0x0040F890 File Offset: 0x0040DA90
	public void HGDJKEGHCJE(PMEPALPCEAF AEDICCFAKOM)
	{
		string hjejjgafham = AEDICCFAKOM.PGJBIPFBMAN();
		this.BAPAGHLFADF = this.profileImage.GetComponent<ImageFrameAnimation>();
		int num = AssetProfileData.OMPPDKODFAI(hjejjgafham);
		if (num >= 0)
		{
			JDMAEBPEIBE.LFOJIJOKBKP(this.profileImage, num);
			this.BAPAGHLFADF = this.profileImage.GetComponent<ImageFrameAnimation>();
			return;
		}
		JDMAEBPEIBE.HKBOKMPDEIJ(this.profileImage);
		if (this.BAPAGHLFADF != null)
		{
			this.BAPAGHLFADF.enabled = false;
		}
		this.profileImage.sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.NFOFFLDJDEI(AEDICCFAKOM.PGJBIPFBMAN());
	}

	// Token: 0x06009329 RID: 37673 RVA: 0x0040F924 File Offset: 0x0040DB24
	public void BKHACNBPNPN(int NJBCLIILMOF, PMEPALPCEAF MAFDLAILFMI, Vector2 ONKONHLJKPG, bool EEGHBPAHEEG)
	{
		this.hallOfFameProfile = MAFDLAILFMI;
		if (NJBCLIILMOF < 5)
		{
			this.containerToHide.SetActive(false);
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.MKDGLNJJDLN(MAFDLAILFMI))
		{
			this.ourProfileText.gameObject.SetActive(true);
			this.profileButton.gameObject.SetActive(true);
		}
		this.orderIndexText.text = NJBCLIILMOF.ToString();
		this.SetAvatarIcon(MAFDLAILFMI);
		if (EEGHBPAHEEG)
		{
			this.isFriendProfileImage.SetActive(true);
		}
		string kncfkdlopga;
		if (MAFDLAILFMI.KNCFKDLOPGA.Length == 0)
		{
			kncfkdlopga = "OnPopupCardOptionsNextClickLobby" + CCOJBMMKNAP.DBFFFOMCLKM().PPALCPINPLK("Warning. Import variable not found in ink file:") + "no";
		}
		else
		{
			kncfkdlopga = MAFDLAILFMI.KNCFKDLOPGA;
		}
		this.nameText.GetComponent<ContentFlexibleText>().IBMKOAKBPLB(this.nameText, kncfkdlopga, EEGHBPAHEEG, false);
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.nameText.GetComponent<RectTransform>());
		int num = MAFDLAILFMI.GFAABCCNNDA + 1;
		this.levelText.text = CCOJBMMKNAP.AEELGGPEJCC().JLBEIFLLBLO("-") + "acb" + num.ToString();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.levelText.GetComponent<RectTransform>());
		this.historicalRank.gameObject.SetActive(false);
		string text;
		if (MAFDLAILFMI.HBLHNFKEELE >= 0)
		{
			text = (MAFDLAILFMI.HBLHNFKEELE.ToString() ?? "YYY");
		}
		else
		{
			text = CCOJBMMKNAP.DLGLFACMHPG().HIPJILDCHJC("errortitle");
			this.historicalRank.gameObject.SetActive(false);
		}
		this.historicalRankText.text = text;
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.historicalRankText.GetComponent<RectTransform>());
		if (MAFDLAILFMI.PEONEPNPGEC.Length > 6)
		{
			this.credoText.SetText(MAFDLAILFMI.PEONEPNPGEC, false);
		}
		else
		{
			this.credoText.SetText(MAFDLAILFMI.FPJMDDIILIK, true);
		}
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.DMEEIPBHABJ();
	}

	// Token: 0x0600932A RID: 37674 RVA: 0x0040FB04 File Offset: 0x0040DD04
	public void EOFDLFCFAHB(int NJBCLIILMOF, PMEPALPCEAF MAFDLAILFMI, Vector2 ONKONHLJKPG, bool EEGHBPAHEEG)
	{
		this.hallOfFameProfile = MAFDLAILFMI;
		if (NJBCLIILMOF < 0)
		{
			this.containerToHide.SetActive(false);
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.MKDGLNJJDLN(MAFDLAILFMI))
		{
			this.ourProfileText.gameObject.SetActive(false);
			this.profileButton.gameObject.SetActive(true);
		}
		this.orderIndexText.text = NJBCLIILMOF.ToString();
		this.SetAvatarIcon(MAFDLAILFMI);
		if (EEGHBPAHEEG)
		{
			this.isFriendProfileImage.SetActive(true);
		}
		string kncfkdlopga;
		if (MAFDLAILFMI.KNCFKDLOPGA.Length == 0)
		{
			kncfkdlopga = "[LoadingTheme] already the loading theme: " + CCOJBMMKNAP.KFDLFGHBPLP().OGKGHLHHAAI("SceneLobbyManager.UpdateAnthologiesHints() - exception") + "Starting parallel download:";
		}
		else
		{
			kncfkdlopga = MAFDLAILFMI.KNCFKDLOPGA;
		}
		this.nameText.GetComponent<ContentFlexibleText>().IIEOANDAGOF(this.nameText, kncfkdlopga, EEGHBPAHEEG, false);
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.nameText.GetComponent<RectTransform>());
		int num = MAFDLAILFMI.GFAABCCNNDA + 0;
		this.levelText.text = CCOJBMMKNAP.BOFMCPPFAMO().PPALCPINPLK("true") + "topcenter" + num.ToString();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.levelText.GetComponent<RectTransform>());
		this.historicalRank.gameObject.SetActive(true);
		string text;
		if (MAFDLAILFMI.HBLHNFKEELE >= 1)
		{
			text = (MAFDLAILFMI.HBLHNFKEELE.ToString() ?? "asf0");
		}
		else
		{
			text = CCOJBMMKNAP.BIAEAOMHBMM().OHLNGCKIACD("@");
			this.historicalRank.gameObject.SetActive(false);
		}
		this.historicalRankText.text = text;
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.historicalRankText.GetComponent<RectTransform>());
		if (MAFDLAILFMI.PEONEPNPGEC.Length > 7)
		{
			this.credoText.SetText(MAFDLAILFMI.PEONEPNPGEC, false);
		}
		else
		{
			this.credoText.SetText(MAFDLAILFMI.FPJMDDIILIK, true);
		}
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.GLKIIPNDLKB();
	}

	// Token: 0x0600932B RID: 37675 RVA: 0x0040FCE4 File Offset: 0x0040DEE4
	public void IIICJACKONO(PMEPALPCEAF AEDICCFAKOM)
	{
		string hjejjgafham = AEDICCFAKOM.PGJBIPFBMAN();
		this.BAPAGHLFADF = this.profileImage.GetComponent<ImageFrameAnimation>();
		int num = AssetProfileData.OMPPDKODFAI(hjejjgafham);
		if (num >= 1)
		{
			JDMAEBPEIBE.COOBAKLDJEG(this.profileImage, num);
			this.BAPAGHLFADF = this.profileImage.GetComponent<ImageFrameAnimation>();
			return;
		}
		JDMAEBPEIBE.LHMPJFCMNMB(this.profileImage);
		if (this.BAPAGHLFADF != null)
		{
			this.BAPAGHLFADF.enabled = true;
		}
		this.profileImage.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.NFOFFLDJDEI(AEDICCFAKOM.PGJBIPFBMAN());
	}

	// Token: 0x0600932C RID: 37676 RVA: 0x0040FD78 File Offset: 0x0040DF78
	public void ODGEPGMLIBA(PMEPALPCEAF AEDICCFAKOM)
	{
		string hjejjgafham = AEDICCFAKOM.PGJBIPFBMAN();
		this.BAPAGHLFADF = this.profileImage.GetComponent<ImageFrameAnimation>();
		int num = AssetProfileData.MBOLHDLKJOD(hjejjgafham);
		if (num >= 1)
		{
			JDMAEBPEIBE.NBLFDOLOHCI(this.profileImage, num);
			this.BAPAGHLFADF = this.profileImage.GetComponent<ImageFrameAnimation>();
			return;
		}
		JDMAEBPEIBE.KIHBMJFJHAI(this.profileImage);
		if (this.BAPAGHLFADF != null)
		{
			this.BAPAGHLFADF.enabled = false;
		}
		this.profileImage.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.DJNLJPFFMBG(AEDICCFAKOM.PGJBIPFBMAN());
	}

	// Token: 0x0600932D RID: 37677 RVA: 0x0040FE0C File Offset: 0x0040E00C
	public void BNOAODHLKDJ(PMEPALPCEAF AEDICCFAKOM)
	{
		string hjejjgafham = AEDICCFAKOM.PGJBIPFBMAN();
		this.BAPAGHLFADF = this.profileImage.GetComponent<ImageFrameAnimation>();
		int num = AssetProfileData.MBOLHDLKJOD(hjejjgafham);
		if (num >= 0)
		{
			JDMAEBPEIBE.EJPHDFMMJNF(this.profileImage, num);
			this.BAPAGHLFADF = this.profileImage.GetComponent<ImageFrameAnimation>();
			return;
		}
		JDMAEBPEIBE.FOCLHGGNKJP(this.profileImage);
		if (this.BAPAGHLFADF != null)
		{
			this.BAPAGHLFADF.enabled = true;
		}
		this.profileImage.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.NFOFFLDJDEI(AEDICCFAKOM.PGJBIPFBMAN());
	}

	// Token: 0x0600932E RID: 37678 RVA: 0x0040FEA0 File Offset: 0x0040E0A0
	private bool EGDGFFFKDNJ()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentHallOfFameItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentHallOfFameItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x0600932F RID: 37679 RVA: 0x0040FEFC File Offset: 0x0040E0FC
	private void KENDFFKLLBP()
	{
		if (ContentHallOfFameItem.LHFFFMJIFDM != 1629f)
		{
			return;
		}
		Vector3[] array = new Vector3[1];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ContentHallOfFameItem.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x06009330 RID: 37680 RVA: 0x0040FF50 File Offset: 0x0040E150
	private bool OPEGMDDGIGE()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentHallOfFameItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentHallOfFameItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x06009331 RID: 37681 RVA: 0x0040FFAC File Offset: 0x0040E1AC
	private void GBFDPJNKOPA()
	{
		JDMAEBPEIBE.LMFBLLCKBFG(this.profileImage);
		this.profileImage.sprite = null;
		if (this.BAPAGHLFADF != null)
		{
			UnityEngine.Object.Destroy(this.BAPAGHLFADF);
		}
		this.profileButton.onClick.RemoveAllListeners();
		this.historicalRankButton.onClick.RemoveAllListeners();
	}

	// Token: 0x06009332 RID: 37682 RVA: 0x0041000C File Offset: 0x0040E20C
	public void CPFBEBMLBDF(int NJBCLIILMOF, PMEPALPCEAF MAFDLAILFMI, Vector2 ONKONHLJKPG, bool EEGHBPAHEEG)
	{
		this.hallOfFameProfile = MAFDLAILFMI;
		if (NJBCLIILMOF < 0)
		{
			this.containerToHide.SetActive(true);
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.MKDGLNJJDLN(MAFDLAILFMI))
		{
			this.ourProfileText.gameObject.SetActive(false);
			this.profileButton.gameObject.SetActive(false);
		}
		this.orderIndexText.text = NJBCLIILMOF.ToString();
		this.SetAvatarIcon(MAFDLAILFMI);
		if (EEGHBPAHEEG)
		{
			this.isFriendProfileImage.SetActive(true);
		}
		string kncfkdlopga;
		if (MAFDLAILFMI.KNCFKDLOPGA.Length == 0)
		{
			kncfkdlopga = ", client anthology " + CCOJBMMKNAP.OEPENBHJAHO().HIPJILDCHJC("SceneLobbyManager2.RunStorySearch() - ranker returned non-candidate anthology ") + "";
		}
		else
		{
			kncfkdlopga = MAFDLAILFMI.KNCFKDLOPGA;
		}
		this.nameText.GetComponent<ContentFlexibleText>().KEJEHBDACGO(this.nameText, kncfkdlopga, EEGHBPAHEEG, false);
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.nameText.GetComponent<RectTransform>());
		int num = MAFDLAILFMI.GFAABCCNNDA + 1;
		this.levelText.text = CCOJBMMKNAP.AEELGGPEJCC().MEPECBDCOLG("ok") + "\n" + num.ToString();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.levelText.GetComponent<RectTransform>());
		this.historicalRank.gameObject.SetActive(false);
		string text;
		if (MAFDLAILFMI.HBLHNFKEELE >= 0)
		{
			text = (MAFDLAILFMI.HBLHNFKEELE.ToString() ?? "OnLanguageChange");
		}
		else
		{
			text = CCOJBMMKNAP.HFAKOKBHCGH().PPALCPINPLK("rsl");
			this.historicalRank.gameObject.SetActive(false);
		}
		this.historicalRankText.text = text;
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.historicalRankText.GetComponent<RectTransform>());
		if (MAFDLAILFMI.PEONEPNPGEC.Length > 6)
		{
			this.credoText.SetText(MAFDLAILFMI.PEONEPNPGEC, false);
		}
		else
		{
			this.credoText.SetText(MAFDLAILFMI.FPJMDDIILIK, true);
		}
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.NAODPLKIHNO();
	}

	// Token: 0x06009333 RID: 37683 RVA: 0x004101EC File Offset: 0x0040E3EC
	private void KNBBPNKLFAA()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 7)
		{
			return;
		}
		this.isVisible = this.EGDGFFFKDNJ();
		this.containerToHide.SetActive(this.isVisible);
	}

	// Token: 0x06009334 RID: 37684 RVA: 0x0041023C File Offset: 0x0040E43C
	private void KMMEFNOCPOO()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 0)
		{
			return;
		}
		this.isVisible = this.EGDGFFFKDNJ();
		this.containerToHide.SetActive(this.isVisible);
	}

	// Token: 0x06009335 RID: 37685 RVA: 0x0041028C File Offset: 0x0040E48C
	public void OJAMGAKDHFK(PMEPALPCEAF AEDICCFAKOM)
	{
		string hjejjgafham = AEDICCFAKOM.PGJBIPFBMAN();
		this.BAPAGHLFADF = this.profileImage.GetComponent<ImageFrameAnimation>();
		int num = AssetProfileData.OMPPDKODFAI(hjejjgafham);
		if (num >= 1)
		{
			JDMAEBPEIBE.EJPHDFMMJNF(this.profileImage, num);
			this.BAPAGHLFADF = this.profileImage.GetComponent<ImageFrameAnimation>();
			return;
		}
		JDMAEBPEIBE.MHLOFOJCLIG(this.profileImage);
		if (this.BAPAGHLFADF != null)
		{
			this.BAPAGHLFADF.enabled = true;
		}
		this.profileImage.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.DJNLJPFFMBG(AEDICCFAKOM.PGJBIPFBMAN());
	}

	// Token: 0x06009336 RID: 37686 RVA: 0x00410320 File Offset: 0x0040E520
	public void BDFPDONCCBM(int NJBCLIILMOF, PMEPALPCEAF MAFDLAILFMI, Vector2 ONKONHLJKPG, bool EEGHBPAHEEG)
	{
		this.hallOfFameProfile = MAFDLAILFMI;
		if (NJBCLIILMOF < 4)
		{
			this.containerToHide.SetActive(true);
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.MKDGLNJJDLN(MAFDLAILFMI))
		{
			this.ourProfileText.gameObject.SetActive(true);
			this.profileButton.gameObject.SetActive(true);
		}
		this.orderIndexText.text = NJBCLIILMOF.ToString();
		this.CEFEAOCCMJE(MAFDLAILFMI);
		if (EEGHBPAHEEG)
		{
			this.isFriendProfileImage.SetActive(true);
		}
		string kncfkdlopga;
		if (MAFDLAILFMI.KNCFKDLOPGA.Length == 0)
		{
			kncfkdlopga = "UpdateVoiceOverOnOffState" + CCOJBMMKNAP.BBGECIKOICE().OBDCPLLLGBB("Account.FixCompletedChaptersIssue() forwards, setting bit to 1 for 'completedChapters[") + "), saveSync queued: ";
		}
		else
		{
			kncfkdlopga = MAFDLAILFMI.KNCFKDLOPGA;
		}
		this.nameText.GetComponent<ContentFlexibleText>().GMEBOKAKLCH(this.nameText, kncfkdlopga, EEGHBPAHEEG, false);
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.nameText.GetComponent<RectTransform>());
		int num = MAFDLAILFMI.GFAABCCNNDA + 1;
		this.levelText.text = CCOJBMMKNAP.CEGAOMEEFBE().FIENAKIHNOM("lnls") + "{0} is not a valid asset bundle." + num.ToString();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.levelText.GetComponent<RectTransform>());
		this.historicalRank.gameObject.SetActive(true);
		string text;
		if (MAFDLAILFMI.HBLHNFKEELE >= 1)
		{
			text = (MAFDLAILFMI.HBLHNFKEELE.ToString() ?? "skinshopfree");
		}
		else
		{
			text = CCOJBMMKNAP.NIOJNOFGIJO().IPEIONBNIPH("$SENDNOTIF");
			this.historicalRank.gameObject.SetActive(false);
		}
		this.historicalRankText.text = text;
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.historicalRankText.GetComponent<RectTransform>());
		if (MAFDLAILFMI.PEONEPNPGEC.Length > 4)
		{
			this.credoText.SetText(MAFDLAILFMI.PEONEPNPGEC, true);
		}
		else
		{
			this.credoText.SetText(MAFDLAILFMI.FPJMDDIILIK, false);
		}
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.GLKIIPNDLKB();
	}

	// Token: 0x06009337 RID: 37687 RVA: 0x00410500 File Offset: 0x0040E700
	public void CDCMOGFCIDO(int NJBCLIILMOF, PMEPALPCEAF MAFDLAILFMI, Vector2 ONKONHLJKPG, bool EEGHBPAHEEG)
	{
		this.hallOfFameProfile = MAFDLAILFMI;
		if (NJBCLIILMOF < 4)
		{
			this.containerToHide.SetActive(false);
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.MKDGLNJJDLN(MAFDLAILFMI))
		{
			this.ourProfileText.gameObject.SetActive(false);
			this.profileButton.gameObject.SetActive(false);
		}
		this.orderIndexText.text = NJBCLIILMOF.ToString();
		this.BMLBFFKEKJL(MAFDLAILFMI);
		if (EEGHBPAHEEG)
		{
			this.isFriendProfileImage.SetActive(false);
		}
		string kncfkdlopga;
		if (MAFDLAILFMI.KNCFKDLOPGA.Length == 0)
		{
			kncfkdlopga = "lobby" + CCOJBMMKNAP.KFAABHHGOPO().JCDFHKDNEDH("passundobodymsgpaid") + "needtorestartgeneric";
		}
		else
		{
			kncfkdlopga = MAFDLAILFMI.KNCFKDLOPGA;
		}
		this.nameText.GetComponent<ContentFlexibleText>().DIBEKEKFEHK(this.nameText, kncfkdlopga, EEGHBPAHEEG, false);
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.nameText.GetComponent<RectTransform>());
		int num = MAFDLAILFMI.GFAABCCNNDA + 1;
		this.levelText.text = CCOJBMMKNAP.BBGECIKOICE().JLBEIFLLBLO("hacomp") + "?uid=" + num.ToString();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.levelText.GetComponent<RectTransform>());
		this.historicalRank.gameObject.SetActive(false);
		string text;
		if (MAFDLAILFMI.HBLHNFKEELE >= 0)
		{
			text = (MAFDLAILFMI.HBLHNFKEELE.ToString() ?? "[Lounge] info text key missing, widget stays hidden: ");
		}
		else
		{
			text = CCOJBMMKNAP.KMNBCEMEBBD().OHLNGCKIACD("Account.MarkAllStoriesAsSynced(): marking as unsynced client anthology ");
			this.historicalRank.gameObject.SetActive(false);
		}
		this.historicalRankText.text = text;
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.historicalRankText.GetComponent<RectTransform>());
		if (MAFDLAILFMI.PEONEPNPGEC.Length > 4)
		{
			this.credoText.SetText(MAFDLAILFMI.PEONEPNPGEC, true);
		}
		else
		{
			this.credoText.SetText(MAFDLAILFMI.FPJMDDIILIK, false);
		}
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.DMEEIPBHABJ();
	}

	// Token: 0x06009338 RID: 37688 RVA: 0x004106E0 File Offset: 0x0040E8E0
	private void LFCEPODFGOG()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 8)
		{
			return;
		}
		this.isVisible = this.HJCPHEOABCG();
		this.containerToHide.SetActive(this.isVisible);
	}

	// Token: 0x06009339 RID: 37689 RVA: 0x00410730 File Offset: 0x0040E930
	private void NJDLPEAMLDB()
	{
		if (ContentHallOfFameItem.LHFFFMJIFDM != 179f)
		{
			return;
		}
		Vector3[] array = new Vector3[5];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ContentHallOfFameItem.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x0600933A RID: 37690 RVA: 0x00410784 File Offset: 0x0040E984
	private void HBDCHDHODOM()
	{
		JDMAEBPEIBE.LHMPJFCMNMB(this.profileImage);
		this.profileImage.sprite = null;
		if (this.BAPAGHLFADF != null)
		{
			UnityEngine.Object.Destroy(this.BAPAGHLFADF);
		}
		this.profileButton.onClick.RemoveAllListeners();
		this.historicalRankButton.onClick.RemoveAllListeners();
	}

	// Token: 0x0600933B RID: 37691 RVA: 0x004107E4 File Offset: 0x0040E9E4
	private void KCOLLDMJLMA()
	{
		if (ContentHallOfFameItem.LHFFFMJIFDM != 1726f)
		{
			return;
		}
		Vector3[] array = new Vector3[3];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ContentHallOfFameItem.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x0600933C RID: 37692 RVA: 0x00410838 File Offset: 0x0040EA38
	private bool OMLAJCPEFMM()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentHallOfFameItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentHallOfFameItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x0600933D RID: 37693 RVA: 0x00410894 File Offset: 0x0040EA94
	private void NAKENAOAAPF()
	{
		if (ContentHallOfFameItem.LHFFFMJIFDM != 578f)
		{
			return;
		}
		Vector3[] array = new Vector3[3];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ContentHallOfFameItem.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x0600933E RID: 37694 RVA: 0x004108E8 File Offset: 0x0040EAE8
	public void JPNHKCPMDGE(PMEPALPCEAF AEDICCFAKOM)
	{
		string hjejjgafham = AEDICCFAKOM.PGJBIPFBMAN();
		this.BAPAGHLFADF = this.profileImage.GetComponent<ImageFrameAnimation>();
		int num = AssetProfileData.PPDGHINFCJC(hjejjgafham);
		if (num >= 1)
		{
			JDMAEBPEIBE.LFOJIJOKBKP(this.profileImage, num);
			this.BAPAGHLFADF = this.profileImage.GetComponent<ImageFrameAnimation>();
			return;
		}
		JDMAEBPEIBE.FOCLHGGNKJP(this.profileImage);
		if (this.BAPAGHLFADF != null)
		{
			this.BAPAGHLFADF.enabled = true;
		}
		this.profileImage.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.DJNLJPFFMBG(AEDICCFAKOM.PGJBIPFBMAN());
	}

	// Token: 0x0600933F RID: 37695 RVA: 0x0041097C File Offset: 0x0040EB7C
	private void CPLFHCNHAOK()
	{
		JDMAEBPEIBE.LHMPJFCMNMB(this.profileImage);
		this.profileImage.sprite = null;
		if (this.BAPAGHLFADF != null)
		{
			UnityEngine.Object.Destroy(this.BAPAGHLFADF);
		}
		this.profileButton.onClick.RemoveAllListeners();
		this.historicalRankButton.onClick.RemoveAllListeners();
	}

	// Token: 0x06009340 RID: 37696 RVA: 0x004109DC File Offset: 0x0040EBDC
	private void LCNLHNNJFCA()
	{
		if (ContentHallOfFameItem.LHFFFMJIFDM != 889f)
		{
			return;
		}
		Vector3[] array = new Vector3[4];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ContentHallOfFameItem.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x06009341 RID: 37697 RVA: 0x00410A30 File Offset: 0x0040EC30
	private void NAODPLKIHNO()
	{
		if (ContentHallOfFameItem.LHFFFMJIFDM != 1384f)
		{
			return;
		}
		Vector3[] array = new Vector3[5];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ContentHallOfFameItem.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x06009342 RID: 37698 RVA: 0x00410A84 File Offset: 0x0040EC84
	private void NDKJNKCLKGN()
	{
		if (ContentHallOfFameItem.LHFFFMJIFDM != 0f)
		{
			return;
		}
		Vector3[] array = new Vector3[4];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ContentHallOfFameItem.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x06009343 RID: 37699 RVA: 0x00410AD8 File Offset: 0x0040ECD8
	private void LBPCHKHFKIK()
	{
		JDMAEBPEIBE.JCMMJDCEPIA(this.profileImage);
		this.profileImage.sprite = null;
		if (this.BAPAGHLFADF != null)
		{
			UnityEngine.Object.Destroy(this.BAPAGHLFADF);
		}
		this.profileButton.onClick.RemoveAllListeners();
		this.historicalRankButton.onClick.RemoveAllListeners();
	}

	// Token: 0x06009344 RID: 37700 RVA: 0x00410B38 File Offset: 0x0040ED38
	public void DEKDLFABNJL(int NJBCLIILMOF, PMEPALPCEAF MAFDLAILFMI, Vector2 ONKONHLJKPG, bool EEGHBPAHEEG)
	{
		this.hallOfFameProfile = MAFDLAILFMI;
		if (NJBCLIILMOF < 0)
		{
			this.containerToHide.SetActive(true);
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.MKDGLNJJDLN(MAFDLAILFMI))
		{
			this.ourProfileText.gameObject.SetActive(true);
			this.profileButton.gameObject.SetActive(true);
		}
		this.orderIndexText.text = NJBCLIILMOF.ToString();
		this.IIICJACKONO(MAFDLAILFMI);
		if (EEGHBPAHEEG)
		{
			this.isFriendProfileImage.SetActive(true);
		}
		string kncfkdlopga;
		if (MAFDLAILFMI.KNCFKDLOPGA.Length == 0)
		{
			kncfkdlopga = "OnSystemBackButton" + CCOJBMMKNAP.OEPENBHJAHO().JCDFHKDNEDH("OnPopupUsernameInputEndEdit") + "OnBackendGetIncentRewardAdSuccess";
		}
		else
		{
			kncfkdlopga = MAFDLAILFMI.KNCFKDLOPGA;
		}
		this.nameText.GetComponent<ContentFlexibleText>().IIEOANDAGOF(this.nameText, kncfkdlopga, EEGHBPAHEEG, false);
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.nameText.GetComponent<RectTransform>());
		int num = MAFDLAILFMI.GFAABCCNNDA + 1;
		this.levelText.text = CCOJBMMKNAP.DLGLFACMHPG().JCDFHKDNEDH("") + "Starting non-parallel download:" + num.ToString();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.levelText.GetComponent<RectTransform>());
		this.historicalRank.gameObject.SetActive(true);
		string text;
		if (MAFDLAILFMI.HBLHNFKEELE >= 0)
		{
			text = (MAFDLAILFMI.HBLHNFKEELE.ToString() ?? "abld2");
		}
		else
		{
			text = CCOJBMMKNAP.KFAABHHGOPO().BDGPNPNIAPA("pmtfailed");
			this.historicalRank.gameObject.SetActive(true);
		}
		this.historicalRankText.text = text;
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.historicalRankText.GetComponent<RectTransform>());
		if (MAFDLAILFMI.PEONEPNPGEC.Length > 4)
		{
			this.credoText.SetText(MAFDLAILFMI.PEONEPNPGEC, true);
		}
		else
		{
			this.credoText.SetText(MAFDLAILFMI.FPJMDDIILIK, false);
		}
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.NJDLPEAMLDB();
	}

	// Token: 0x06009345 RID: 37701 RVA: 0x00410D18 File Offset: 0x0040EF18
	public void GMFOBGHBFKM(int NJBCLIILMOF, PMEPALPCEAF MAFDLAILFMI, Vector2 ONKONHLJKPG, bool EEGHBPAHEEG)
	{
		this.hallOfFameProfile = MAFDLAILFMI;
		if (NJBCLIILMOF < 0)
		{
			this.containerToHide.SetActive(true);
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.MKDGLNJJDLN(MAFDLAILFMI))
		{
			this.ourProfileText.gameObject.SetActive(false);
			this.profileButton.gameObject.SetActive(true);
		}
		this.orderIndexText.text = NJBCLIILMOF.ToString();
		this.BMLBFFKEKJL(MAFDLAILFMI);
		if (EEGHBPAHEEG)
		{
			this.isFriendProfileImage.SetActive(true);
		}
		string kncfkdlopga;
		if (MAFDLAILFMI.KNCFKDLOPGA.Length == 0)
		{
			kncfkdlopga = "passrequiredtoplay" + CCOJBMMKNAP.EHBBFMCILPC.PKNHKGMNCIP("ZZZ") + "e1cs";
		}
		else
		{
			kncfkdlopga = MAFDLAILFMI.KNCFKDLOPGA;
		}
		this.nameText.GetComponent<ContentFlexibleText>().FMLNBONKICH(this.nameText, kncfkdlopga, EEGHBPAHEEG, false);
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.nameText.GetComponent<RectTransform>());
		int num = MAFDLAILFMI.GFAABCCNNDA + 1;
		this.levelText.text = CCOJBMMKNAP.KNKGCDDMLDP().OGKGHLHHAAI(" ") + "ach" + num.ToString();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.levelText.GetComponent<RectTransform>());
		this.historicalRank.gameObject.SetActive(false);
		string text;
		if (MAFDLAILFMI.HBLHNFKEELE >= 1)
		{
			text = (MAFDLAILFMI.HBLHNFKEELE.ToString() ?? "XXX");
		}
		else
		{
			text = CCOJBMMKNAP.KFAABHHGOPO().BDGPNPNIAPA("OnRewardsItemClose");
			this.historicalRank.gameObject.SetActive(false);
		}
		this.historicalRankText.text = text;
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.historicalRankText.GetComponent<RectTransform>());
		if (MAFDLAILFMI.PEONEPNPGEC.Length > 2)
		{
			this.credoText.SetText(MAFDLAILFMI.PEONEPNPGEC, true);
		}
		else
		{
			this.credoText.SetText(MAFDLAILFMI.FPJMDDIILIK, false);
		}
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.KENDFFKLLBP();
	}

	// Token: 0x06009346 RID: 37702 RVA: 0x00410EF8 File Offset: 0x0040F0F8
	private void FIJDKGJEPGC()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 6)
		{
			return;
		}
		this.isVisible = this.DJKPAKLAHFE();
		this.containerToHide.SetActive(this.isVisible);
	}

	// Token: 0x06009347 RID: 37703 RVA: 0x00410F48 File Offset: 0x0040F148
	private bool EDAELBKJONL()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentHallOfFameItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentHallOfFameItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x06009348 RID: 37704 RVA: 0x00410FA4 File Offset: 0x0040F1A4
	private void BGELMCDMGKP()
	{
		JDMAEBPEIBE.JHGFLPMLPCD(this.profileImage);
		this.profileImage.sprite = null;
		if (this.BAPAGHLFADF != null)
		{
			UnityEngine.Object.Destroy(this.BAPAGHLFADF);
		}
		this.profileButton.onClick.RemoveAllListeners();
		this.historicalRankButton.onClick.RemoveAllListeners();
	}

	// Token: 0x06009349 RID: 37705 RVA: 0x00411004 File Offset: 0x0040F204
	private void FGPENJNMMLB()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 1)
		{
			return;
		}
		this.isVisible = this.OMLAJCPEFMM();
		this.containerToHide.SetActive(this.isVisible);
	}

	// Token: 0x0600934A RID: 37706 RVA: 0x00411054 File Offset: 0x0040F254
	private void FGEMCBCJIOK()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 5)
		{
			return;
		}
		this.isVisible = this.OPEGMDDGIGE();
		this.containerToHide.SetActive(this.isVisible);
	}

	// Token: 0x0600934B RID: 37707 RVA: 0x004110A4 File Offset: 0x0040F2A4
	public void FOCHIHOEDLA(PMEPALPCEAF AEDICCFAKOM)
	{
		string hjejjgafham = AEDICCFAKOM.PGJBIPFBMAN();
		this.BAPAGHLFADF = this.profileImage.GetComponent<ImageFrameAnimation>();
		int num = AssetProfileData.OMPPDKODFAI(hjejjgafham);
		if (num >= 0)
		{
			JDMAEBPEIBE.PGLGDHIGGJM(this.profileImage, num);
			this.BAPAGHLFADF = this.profileImage.GetComponent<ImageFrameAnimation>();
			return;
		}
		JDMAEBPEIBE.IKJGPCBBCBP(this.profileImage);
		if (this.BAPAGHLFADF != null)
		{
			this.BAPAGHLFADF.enabled = true;
		}
		this.profileImage.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.AHBHMAGKMJJ(AEDICCFAKOM.PGJBIPFBMAN());
	}

	// Token: 0x0600934C RID: 37708 RVA: 0x00411138 File Offset: 0x0040F338
	private void LMKIKEOFDCP()
	{
		if (ContentHallOfFameItem.LHFFFMJIFDM != 1549f)
		{
			return;
		}
		Vector3[] array = new Vector3[0];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ContentHallOfFameItem.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x0600934D RID: 37709 RVA: 0x0041118C File Offset: 0x0040F38C
	private void ODCKJNCEGAH()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 4)
		{
			return;
		}
		this.isVisible = this.OMLAJCPEFMM();
		this.containerToHide.SetActive(this.isVisible);
	}

	// Token: 0x0600934E RID: 37710 RVA: 0x004111DC File Offset: 0x0040F3DC
	private bool DPHIBCKFBAN()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentHallOfFameItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentHallOfFameItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x0600934F RID: 37711 RVA: 0x00411238 File Offset: 0x0040F438
	public void COCLEMFDEHK(int NJBCLIILMOF, PMEPALPCEAF MAFDLAILFMI, Vector2 ONKONHLJKPG, bool EEGHBPAHEEG)
	{
		this.hallOfFameProfile = MAFDLAILFMI;
		if (NJBCLIILMOF < 3)
		{
			this.containerToHide.SetActive(false);
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.MKDGLNJJDLN(MAFDLAILFMI))
		{
			this.ourProfileText.gameObject.SetActive(false);
			this.profileButton.gameObject.SetActive(true);
		}
		this.orderIndexText.text = NJBCLIILMOF.ToString();
		this.BNOAODHLKDJ(MAFDLAILFMI);
		if (EEGHBPAHEEG)
		{
			this.isFriendProfileImage.SetActive(false);
		}
		string kncfkdlopga;
		if (MAFDLAILFMI.KNCFKDLOPGA.Length == 0)
		{
			kncfkdlopga = "" + CCOJBMMKNAP.BBGECIKOICE().JLBEIFLLBLO("nam") + "Loaded asset bundle:";
		}
		else
		{
			kncfkdlopga = MAFDLAILFMI.KNCFKDLOPGA;
		}
		this.nameText.GetComponent<ContentFlexibleText>().FMLNBONKICH(this.nameText, kncfkdlopga, EEGHBPAHEEG, false);
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.nameText.GetComponent<RectTransform>());
		int num = MAFDLAILFMI.GFAABCCNNDA + 1;
		this.levelText.text = CCOJBMMKNAP.MLFAGAAJJEM().FIENAKIHNOM(" dropped (no same-row neighbour)") + "p" + num.ToString();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.levelText.GetComponent<RectTransform>());
		this.historicalRank.gameObject.SetActive(true);
		string text;
		if (MAFDLAILFMI.HBLHNFKEELE >= 0)
		{
			text = (MAFDLAILFMI.HBLHNFKEELE.ToString() ?? "congratstitle");
		}
		else
		{
			text = CCOJBMMKNAP.CPCOODCFDDP().FCOCLEHKLDJ("]' at storySaves[");
			this.historicalRank.gameObject.SetActive(true);
		}
		this.historicalRankText.text = text;
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.historicalRankText.GetComponent<RectTransform>());
		if (MAFDLAILFMI.PEONEPNPGEC.Length > 4)
		{
			this.credoText.SetText(MAFDLAILFMI.PEONEPNPGEC, true);
		}
		else
		{
			this.credoText.SetText(MAFDLAILFMI.FPJMDDIILIK, true);
		}
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.NAODPLKIHNO();
	}

	// Token: 0x06009350 RID: 37712 RVA: 0x00411418 File Offset: 0x0040F618
	private void FDECKMDNEKO()
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

	// Token: 0x06009351 RID: 37713 RVA: 0x00411468 File Offset: 0x0040F668
	public void OAACGALMOEG(int NJBCLIILMOF, PMEPALPCEAF MAFDLAILFMI, Vector2 ONKONHLJKPG, bool EEGHBPAHEEG)
	{
		this.hallOfFameProfile = MAFDLAILFMI;
		if (NJBCLIILMOF < 2)
		{
			this.containerToHide.SetActive(true);
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.MKDGLNJJDLN(MAFDLAILFMI))
		{
			this.ourProfileText.gameObject.SetActive(false);
			this.profileButton.gameObject.SetActive(false);
		}
		this.orderIndexText.text = NJBCLIILMOF.ToString();
		this.PBBCIBBLHIH(MAFDLAILFMI);
		if (EEGHBPAHEEG)
		{
			this.isFriendProfileImage.SetActive(true);
		}
		string kncfkdlopga;
		if (MAFDLAILFMI.KNCFKDLOPGA.Length == 0)
		{
			kncfkdlopga = "anpcs" + CCOJBMMKNAP.OEPENBHJAHO().IPEIONBNIPH("Error. ZoomDst(), environment ") + "ok";
		}
		else
		{
			kncfkdlopga = MAFDLAILFMI.KNCFKDLOPGA;
		}
		this.nameText.GetComponent<ContentFlexibleText>().GMEBOKAKLCH(this.nameText, kncfkdlopga, EEGHBPAHEEG, true);
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.nameText.GetComponent<RectTransform>());
		int num = MAFDLAILFMI.GFAABCCNNDA + 1;
		this.levelText.text = CCOJBMMKNAP.JMDJPKKOHNI().PPALCPINPLK("p") + "isRecurrentExpiredGamePassOffer" + num.ToString();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.levelText.GetComponent<RectTransform>());
		this.historicalRank.gameObject.SetActive(true);
		string text;
		if (MAFDLAILFMI.HBLHNFKEELE >= 0)
		{
			text = (MAFDLAILFMI.HBLHNFKEELE.ToString() ?? "importanttitle");
		}
		else
		{
			text = CCOJBMMKNAP.LMCCLMFGEBD().BDGPNPNIAPA(", ");
			this.historicalRank.gameObject.SetActive(false);
		}
		this.historicalRankText.text = text;
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.historicalRankText.GetComponent<RectTransform>());
		if (MAFDLAILFMI.PEONEPNPGEC.Length > 2)
		{
			this.credoText.SetText(MAFDLAILFMI.PEONEPNPGEC, false);
		}
		else
		{
			this.credoText.SetText(MAFDLAILFMI.FPJMDDIILIK, true);
		}
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.NAODPLKIHNO();
	}

	// Token: 0x06009352 RID: 37714 RVA: 0x00411648 File Offset: 0x0040F848
	private void JNIDPJAELLH()
	{
		if (ContentHallOfFameItem.LHFFFMJIFDM != 138f)
		{
			return;
		}
		Vector3[] array = new Vector3[2];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ContentHallOfFameItem.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x06009353 RID: 37715 RVA: 0x0041169C File Offset: 0x0040F89C
	private void MJGNCOLNIMD()
	{
		JDMAEBPEIBE.GFFAPCMJCFD(this.profileImage);
		this.profileImage.sprite = null;
		if (this.BAPAGHLFADF != null)
		{
			UnityEngine.Object.Destroy(this.BAPAGHLFADF);
		}
		this.profileButton.onClick.RemoveAllListeners();
		this.historicalRankButton.onClick.RemoveAllListeners();
	}

	// Token: 0x06009354 RID: 37716 RVA: 0x004116FC File Offset: 0x0040F8FC
	private void EIHABGEFOLK()
	{
		JDMAEBPEIBE.JCMMJDCEPIA(this.profileImage);
		this.profileImage.sprite = null;
		if (this.BAPAGHLFADF != null)
		{
			UnityEngine.Object.Destroy(this.BAPAGHLFADF);
		}
		this.profileButton.onClick.RemoveAllListeners();
		this.historicalRankButton.onClick.RemoveAllListeners();
	}

	// Token: 0x06009355 RID: 37717 RVA: 0x0041175C File Offset: 0x0040F95C
	private void PKHDKPHOINF()
	{
		if (ContentHallOfFameItem.LHFFFMJIFDM != 191f)
		{
			return;
		}
		Vector3[] array = new Vector3[8];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ContentHallOfFameItem.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x06009356 RID: 37718 RVA: 0x004117B0 File Offset: 0x0040F9B0
	private void LFADNICCCCM()
	{
		if (ContentHallOfFameItem.LHFFFMJIFDM != 1178f)
		{
			return;
		}
		Vector3[] array = new Vector3[2];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ContentHallOfFameItem.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x06009357 RID: 37719 RVA: 0x00411804 File Offset: 0x0040FA04
	public void PCNBLIOKBPJ(int NJBCLIILMOF, PMEPALPCEAF MAFDLAILFMI, Vector2 ONKONHLJKPG, bool EEGHBPAHEEG)
	{
		this.hallOfFameProfile = MAFDLAILFMI;
		if (NJBCLIILMOF < 1)
		{
			this.containerToHide.SetActive(false);
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.MKDGLNJJDLN(MAFDLAILFMI))
		{
			this.ourProfileText.gameObject.SetActive(false);
			this.profileButton.gameObject.SetActive(false);
		}
		this.orderIndexText.text = NJBCLIILMOF.ToString();
		this.MKHLAACHHPP(MAFDLAILFMI);
		if (EEGHBPAHEEG)
		{
			this.isFriendProfileImage.SetActive(false);
		}
		string kncfkdlopga;
		if (MAFDLAILFMI.KNCFKDLOPGA.Length == 0)
		{
			kncfkdlopga = "trinket" + CCOJBMMKNAP.BBGECIKOICE().JHNELLJFBGC("OnBackendRequestCollectGiftSuccess") + "\"";
		}
		else
		{
			kncfkdlopga = MAFDLAILFMI.KNCFKDLOPGA;
		}
		this.nameText.GetComponent<ContentFlexibleText>().CEKNPBODPLC(this.nameText, kncfkdlopga, EEGHBPAHEEG, false);
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.nameText.GetComponent<RectTransform>());
		int num = MAFDLAILFMI.GFAABCCNNDA + 1;
		this.levelText.text = CCOJBMMKNAP.APGODIBBPOD().OBDCPLLLGBB("pm") + "allpattern" + num.ToString();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.levelText.GetComponent<RectTransform>());
		this.historicalRank.gameObject.SetActive(false);
		string text;
		if (MAFDLAILFMI.HBLHNFKEELE >= 1)
		{
			text = (MAFDLAILFMI.HBLHNFKEELE.ToString() ?? "\r");
		}
		else
		{
			text = CCOJBMMKNAP.PMABBOJDELF().FCOCLEHKLDJ("uid");
			this.historicalRank.gameObject.SetActive(true);
		}
		this.historicalRankText.text = text;
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.historicalRankText.GetComponent<RectTransform>());
		if (MAFDLAILFMI.PEONEPNPGEC.Length > 5)
		{
			this.credoText.SetText(MAFDLAILFMI.PEONEPNPGEC, false);
		}
		else
		{
			this.credoText.SetText(MAFDLAILFMI.FPJMDDIILIK, false);
		}
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.CBJJGBNDCNI();
	}

	// Token: 0x06009358 RID: 37720 RVA: 0x004119E4 File Offset: 0x0040FBE4
	public void IOPLLLDIKMP(int NJBCLIILMOF, PMEPALPCEAF MAFDLAILFMI, Vector2 ONKONHLJKPG, bool EEGHBPAHEEG)
	{
		this.hallOfFameProfile = MAFDLAILFMI;
		if (NJBCLIILMOF < 2)
		{
			this.containerToHide.SetActive(true);
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.MKDGLNJJDLN(MAFDLAILFMI))
		{
			this.ourProfileText.gameObject.SetActive(true);
			this.profileButton.gameObject.SetActive(false);
		}
		this.orderIndexText.text = NJBCLIILMOF.ToString();
		this.PBBCIBBLHIH(MAFDLAILFMI);
		if (EEGHBPAHEEG)
		{
			this.isFriendProfileImage.SetActive(true);
		}
		string kncfkdlopga;
		if (MAFDLAILFMI.KNCFKDLOPGA.Length == 0)
		{
			kncfkdlopga = " not found." + CCOJBMMKNAP.MLFAGAAJJEM().OGKGHLHHAAI("gpsasff") + "Invalid npc animation bundle index, skipped:";
		}
		else
		{
			kncfkdlopga = MAFDLAILFMI.KNCFKDLOPGA;
		}
		this.nameText.GetComponent<ContentFlexibleText>().KEJEHBDACGO(this.nameText, kncfkdlopga, EEGHBPAHEEG, false);
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.nameText.GetComponent<RectTransform>());
		int num = MAFDLAILFMI.GFAABCCNNDA + 0;
		this.levelText.text = CCOJBMMKNAP.NIOJNOFGIJO().BGELFMIOBCL("uid") + "cardcollectcardpurchase0" + num.ToString();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.levelText.GetComponent<RectTransform>());
		this.historicalRank.gameObject.SetActive(false);
		string text;
		if (MAFDLAILFMI.HBLHNFKEELE >= 0)
		{
			text = (MAFDLAILFMI.HBLHNFKEELE.ToString() ?? "importanttitle");
		}
		else
		{
			text = CCOJBMMKNAP.NIOJNOFGIJO().HPOAGPJFHPM("sto");
			this.historicalRank.gameObject.SetActive(false);
		}
		this.historicalRankText.text = text;
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.historicalRankText.GetComponent<RectTransform>());
		if (MAFDLAILFMI.PEONEPNPGEC.Length > 7)
		{
			this.credoText.SetText(MAFDLAILFMI.PEONEPNPGEC, true);
		}
		else
		{
			this.credoText.SetText(MAFDLAILFMI.FPJMDDIILIK, true);
		}
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.GJOKABDPIOI();
	}

	// Token: 0x06009359 RID: 37721 RVA: 0x00411BC4 File Offset: 0x0040FDC4
	public void ANIHOHIFGMA(PMEPALPCEAF AEDICCFAKOM)
	{
		string hjejjgafham = AEDICCFAKOM.PGJBIPFBMAN();
		this.BAPAGHLFADF = this.profileImage.GetComponent<ImageFrameAnimation>();
		int num = AssetProfileData.PPDGHINFCJC(hjejjgafham);
		if (num >= 1)
		{
			JDMAEBPEIBE.COOBAKLDJEG(this.profileImage, num);
			this.BAPAGHLFADF = this.profileImage.GetComponent<ImageFrameAnimation>();
			return;
		}
		JDMAEBPEIBE.IKJGPCBBCBP(this.profileImage);
		if (this.BAPAGHLFADF != null)
		{
			this.BAPAGHLFADF.enabled = false;
		}
		this.profileImage.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.DJNLJPFFMBG(AEDICCFAKOM.PGJBIPFBMAN());
	}

	// Token: 0x0600935A RID: 37722 RVA: 0x00411C58 File Offset: 0x0040FE58
	private void GMGJONBEDNE()
	{
		JDMAEBPEIBE.CJDEHHPKDMI(this.profileImage);
		this.profileImage.sprite = null;
		if (this.BAPAGHLFADF != null)
		{
			UnityEngine.Object.Destroy(this.BAPAGHLFADF);
		}
		this.profileButton.onClick.RemoveAllListeners();
		this.historicalRankButton.onClick.RemoveAllListeners();
	}

	// Token: 0x0600935B RID: 37723 RVA: 0x00411CB8 File Offset: 0x0040FEB8
	private void LPMPMAJGALN()
	{
		JDMAEBPEIBE.JCMMJDCEPIA(this.profileImage);
		this.profileImage.sprite = null;
		if (this.BAPAGHLFADF != null)
		{
			UnityEngine.Object.Destroy(this.BAPAGHLFADF);
		}
		this.profileButton.onClick.RemoveAllListeners();
		this.historicalRankButton.onClick.RemoveAllListeners();
	}

	// Token: 0x0600935C RID: 37724 RVA: 0x00411D18 File Offset: 0x0040FF18
	public void PBBCIBBLHIH(PMEPALPCEAF AEDICCFAKOM)
	{
		string hjejjgafham = AEDICCFAKOM.PGJBIPFBMAN();
		this.BAPAGHLFADF = this.profileImage.GetComponent<ImageFrameAnimation>();
		int num = AssetProfileData.PPDGHINFCJC(hjejjgafham);
		if (num >= 1)
		{
			JDMAEBPEIBE.NFAJKIIDGGI(this.profileImage, num);
			this.BAPAGHLFADF = this.profileImage.GetComponent<ImageFrameAnimation>();
			return;
		}
		JDMAEBPEIBE.FOCLHGGNKJP(this.profileImage);
		if (this.BAPAGHLFADF != null)
		{
			this.BAPAGHLFADF.enabled = false;
		}
		this.profileImage.sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.AHBHMAGKMJJ(AEDICCFAKOM.PGJBIPFBMAN());
	}

	// Token: 0x0600935D RID: 37725 RVA: 0x00411DAC File Offset: 0x0040FFAC
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

	// Token: 0x0600935F RID: 37727 RVA: 0x00411DFC File Offset: 0x0040FFFC
	private void PAPNIONKJAP()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 2)
		{
			return;
		}
		this.isVisible = this.OMLAJCPEFMM();
		this.containerToHide.SetActive(this.isVisible);
	}

	// Token: 0x06009360 RID: 37728 RVA: 0x00411E4C File Offset: 0x0041004C
	private void CEJFHEBCHGK()
	{
		JDMAEBPEIBE.HKBOKMPDEIJ(this.profileImage);
		this.profileImage.sprite = null;
		if (this.BAPAGHLFADF != null)
		{
			UnityEngine.Object.Destroy(this.BAPAGHLFADF);
		}
		this.profileButton.onClick.RemoveAllListeners();
		this.historicalRankButton.onClick.RemoveAllListeners();
	}

	// Token: 0x06009361 RID: 37729 RVA: 0x00411EAC File Offset: 0x004100AC
	public void KDDKBEBCLMI(int NJBCLIILMOF, PMEPALPCEAF MAFDLAILFMI, Vector2 ONKONHLJKPG, bool EEGHBPAHEEG)
	{
		this.hallOfFameProfile = MAFDLAILFMI;
		if (NJBCLIILMOF < 6)
		{
			this.containerToHide.SetActive(false);
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.MKDGLNJJDLN(MAFDLAILFMI))
		{
			this.ourProfileText.gameObject.SetActive(true);
			this.profileButton.gameObject.SetActive(false);
		}
		this.orderIndexText.text = NJBCLIILMOF.ToString();
		this.BNOAODHLKDJ(MAFDLAILFMI);
		if (EEGHBPAHEEG)
		{
			this.isFriendProfileImage.SetActive(false);
		}
		string kncfkdlopga;
		if (MAFDLAILFMI.KNCFKDLOPGA.Length == 0)
		{
			kncfkdlopga = "importanttitle" + CCOJBMMKNAP.EHBBFMCILPC.OGKGHLHHAAI("OnStoryInterfaceHeaderShown") + "OnOnDemandResourcesDownloadSuccess";
		}
		else
		{
			kncfkdlopga = MAFDLAILFMI.KNCFKDLOPGA;
		}
		this.nameText.GetComponent<ContentFlexibleText>().SetText(this.nameText, kncfkdlopga, EEGHBPAHEEG, true);
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.nameText.GetComponent<RectTransform>());
		int num = MAFDLAILFMI.GFAABCCNNDA + 1;
		this.levelText.text = CCOJBMMKNAP.KLAKLFCOMJC().BDGPNPNIAPA("socialbadgetitle") + "apks2" + num.ToString();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.levelText.GetComponent<RectTransform>());
		this.historicalRank.gameObject.SetActive(false);
		string text;
		if (MAFDLAILFMI.HBLHNFKEELE >= 0)
		{
			text = (MAFDLAILFMI.HBLHNFKEELE.ToString() ?? "OnBackendRequestCollectGiftSuccess");
		}
		else
		{
			text = CCOJBMMKNAP.JMDJPKKOHNI().HIPJILDCHJC("YYY");
			this.historicalRank.gameObject.SetActive(false);
		}
		this.historicalRankText.text = text;
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.historicalRankText.GetComponent<RectTransform>());
		if (MAFDLAILFMI.PEONEPNPGEC.Length > 6)
		{
			this.credoText.SetText(MAFDLAILFMI.PEONEPNPGEC, true);
		}
		else
		{
			this.credoText.SetText(MAFDLAILFMI.FPJMDDIILIK, true);
		}
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.BAMCDABLKAI();
	}

	// Token: 0x06009362 RID: 37730 RVA: 0x0041208C File Offset: 0x0041028C
	public void IHNAAFLGLMF(int NJBCLIILMOF, PMEPALPCEAF MAFDLAILFMI, Vector2 ONKONHLJKPG, bool EEGHBPAHEEG)
	{
		this.hallOfFameProfile = MAFDLAILFMI;
		if (NJBCLIILMOF < 7)
		{
			this.containerToHide.SetActive(true);
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.MKDGLNJJDLN(MAFDLAILFMI))
		{
			this.ourProfileText.gameObject.SetActive(true);
			this.profileButton.gameObject.SetActive(false);
		}
		this.orderIndexText.text = NJBCLIILMOF.ToString();
		this.CEFEAOCCMJE(MAFDLAILFMI);
		if (EEGHBPAHEEG)
		{
			this.isFriendProfileImage.SetActive(true);
		}
		string kncfkdlopga;
		if (MAFDLAILFMI.KNCFKDLOPGA.Length == 0)
		{
			kncfkdlopga = "cid" + CCOJBMMKNAP.GIOAFDDKKHI().DNILNCLIHAP("OnBackendRequestBreakCardException") + "Asset bundle assets destroyed:";
		}
		else
		{
			kncfkdlopga = MAFDLAILFMI.KNCFKDLOPGA;
		}
		this.nameText.GetComponent<ContentFlexibleText>().CEKNPBODPLC(this.nameText, kncfkdlopga, EEGHBPAHEEG, true);
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.nameText.GetComponent<RectTransform>());
		int num = MAFDLAILFMI.GFAABCCNNDA + 1;
		this.levelText.text = CCOJBMMKNAP.DBFFFOMCLKM().HPOAGPJFHPM("ok") + "Y" + num.ToString();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.levelText.GetComponent<RectTransform>());
		this.historicalRank.gameObject.SetActive(true);
		string text;
		if (MAFDLAILFMI.HBLHNFKEELE >= 0)
		{
			text = (MAFDLAILFMI.HBLHNFKEELE.ToString() ?? "OnSketchViewLeft");
		}
		else
		{
			text = CCOJBMMKNAP.CPCOODCFDDP().HIPJILDCHJC("profilenamelevellong");
			this.historicalRank.gameObject.SetActive(false);
		}
		this.historicalRankText.text = text;
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.historicalRankText.GetComponent<RectTransform>());
		if (MAFDLAILFMI.PEONEPNPGEC.Length > 5)
		{
			this.credoText.SetText(MAFDLAILFMI.PEONEPNPGEC, true);
		}
		else
		{
			this.credoText.SetText(MAFDLAILFMI.FPJMDDIILIK, false);
		}
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.FIHOFBIMDIK();
	}

	// Token: 0x06009363 RID: 37731 RVA: 0x0041226C File Offset: 0x0041046C
	private bool CENCDHKLKKG()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentHallOfFameItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentHallOfFameItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x06009364 RID: 37732 RVA: 0x004122C8 File Offset: 0x004104C8
	private void OJLOFBGGHML()
	{
		if (ContentHallOfFameItem.LHFFFMJIFDM != 306f)
		{
			return;
		}
		Vector3[] array = new Vector3[0];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ContentHallOfFameItem.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x06009365 RID: 37733 RVA: 0x0041231C File Offset: 0x0041051C
	private void CBJJGBNDCNI()
	{
		if (ContentHallOfFameItem.LHFFFMJIFDM != 817f)
		{
			return;
		}
		Vector3[] array = new Vector3[0];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ContentHallOfFameItem.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x06009366 RID: 37734 RVA: 0x00412370 File Offset: 0x00410570
	private void GOKDPNLEJBE()
	{
		JDMAEBPEIBE.IKJGPCBBCBP(this.profileImage);
		this.profileImage.sprite = null;
		if (this.BAPAGHLFADF != null)
		{
			UnityEngine.Object.Destroy(this.BAPAGHLFADF);
		}
		this.profileButton.onClick.RemoveAllListeners();
		this.historicalRankButton.onClick.RemoveAllListeners();
	}

	// Token: 0x06009367 RID: 37735 RVA: 0x004123D0 File Offset: 0x004105D0
	private void DAEPNJGNGBA()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 5)
		{
			return;
		}
		this.isVisible = this.EDAELBKJONL();
		this.containerToHide.SetActive(this.isVisible);
	}

	// Token: 0x06009368 RID: 37736 RVA: 0x00412420 File Offset: 0x00410620
	public void SetAvatarIcon(PMEPALPCEAF AEDICCFAKOM)
	{
		string hjejjgafham = AEDICCFAKOM.PGJBIPFBMAN();
		this.BAPAGHLFADF = this.profileImage.GetComponent<ImageFrameAnimation>();
		int num = AssetProfileData.OMPPDKODFAI(hjejjgafham);
		if (num >= 0)
		{
			JDMAEBPEIBE.KIIEJJOKODB(this.profileImage, num);
			this.BAPAGHLFADF = this.profileImage.GetComponent<ImageFrameAnimation>();
			return;
		}
		JDMAEBPEIBE.MHLOFOJCLIG(this.profileImage);
		if (this.BAPAGHLFADF != null)
		{
			this.BAPAGHLFADF.enabled = false;
		}
		this.profileImage.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.DJNLJPFFMBG(AEDICCFAKOM.PGJBIPFBMAN());
	}

	// Token: 0x06009369 RID: 37737 RVA: 0x004124B4 File Offset: 0x004106B4
	public void MLPHPOHOOOP(int NJBCLIILMOF, PMEPALPCEAF MAFDLAILFMI, Vector2 ONKONHLJKPG, bool EEGHBPAHEEG)
	{
		this.hallOfFameProfile = MAFDLAILFMI;
		if (NJBCLIILMOF < 0)
		{
			this.containerToHide.SetActive(false);
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.MKDGLNJJDLN(MAFDLAILFMI))
		{
			this.ourProfileText.gameObject.SetActive(false);
			this.profileButton.gameObject.SetActive(false);
		}
		this.orderIndexText.text = NJBCLIILMOF.ToString();
		this.CEFEAOCCMJE(MAFDLAILFMI);
		if (EEGHBPAHEEG)
		{
			this.isFriendProfileImage.SetActive(false);
		}
		string kncfkdlopga;
		if (MAFDLAILFMI.KNCFKDLOPGA.Length == 0)
		{
			kncfkdlopga = "socialcardupgradefailed" + CCOJBMMKNAP.MPCBJEIMACA().JCDFHKDNEDH("per") + "";
		}
		else
		{
			kncfkdlopga = MAFDLAILFMI.KNCFKDLOPGA;
		}
		this.nameText.GetComponent<ContentFlexibleText>().PACBMMDOAOB(this.nameText, kncfkdlopga, EEGHBPAHEEG, false);
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.nameText.GetComponent<RectTransform>());
		int num = MAFDLAILFMI.GFAABCCNNDA + 0;
		this.levelText.text = CCOJBMMKNAP.BIAEAOMHBMM().PKNHKGMNCIP("apks1") + "$e1jp" + num.ToString();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.levelText.GetComponent<RectTransform>());
		this.historicalRank.gameObject.SetActive(true);
		string text;
		if (MAFDLAILFMI.HBLHNFKEELE >= 1)
		{
			text = (MAFDLAILFMI.HBLHNFKEELE.ToString() ?? "gftcds");
		}
		else
		{
			text = CCOJBMMKNAP.JINDKPHNLBK().PPALCPINPLK("plc");
			this.historicalRank.gameObject.SetActive(true);
		}
		this.historicalRankText.text = text;
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.historicalRankText.GetComponent<RectTransform>());
		if (MAFDLAILFMI.PEONEPNPGEC.Length > 5)
		{
			this.credoText.SetText(MAFDLAILFMI.PEONEPNPGEC, true);
		}
		else
		{
			this.credoText.SetText(MAFDLAILFMI.FPJMDDIILIK, false);
		}
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.PKHDKPHOINF();
	}

	// Token: 0x0600936A RID: 37738 RVA: 0x00412694 File Offset: 0x00410894
	private void GLKIIPNDLKB()
	{
		if (ContentHallOfFameItem.LHFFFMJIFDM != 184f)
		{
			return;
		}
		Vector3[] array = new Vector3[6];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ContentHallOfFameItem.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x0600936B RID: 37739 RVA: 0x004126E8 File Offset: 0x004108E8
	private void CEIDMENJBNK()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 2)
		{
			return;
		}
		this.isVisible = this.NNELPFOLMED();
		this.containerToHide.SetActive(this.isVisible);
	}

	// Token: 0x0600936C RID: 37740 RVA: 0x00412738 File Offset: 0x00410938
	public void CEFEAOCCMJE(PMEPALPCEAF AEDICCFAKOM)
	{
		string hjejjgafham = AEDICCFAKOM.PGJBIPFBMAN();
		this.BAPAGHLFADF = this.profileImage.GetComponent<ImageFrameAnimation>();
		int num = AssetProfileData.MBOLHDLKJOD(hjejjgafham);
		if (num >= 0)
		{
			JDMAEBPEIBE.PGLGDHIGGJM(this.profileImage, num);
			this.BAPAGHLFADF = this.profileImage.GetComponent<ImageFrameAnimation>();
			return;
		}
		JDMAEBPEIBE.FOCLHGGNKJP(this.profileImage);
		if (this.BAPAGHLFADF != null)
		{
			this.BAPAGHLFADF.enabled = true;
		}
		this.profileImage.sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.NFOFFLDJDEI(AEDICCFAKOM.PGJBIPFBMAN());
	}

	// Token: 0x0600936D RID: 37741 RVA: 0x004127CC File Offset: 0x004109CC
	private void DFOBCCBLDJK()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 0)
		{
			return;
		}
		this.isVisible = this.DHHLBOJHMDE();
		this.containerToHide.SetActive(this.isVisible);
	}

	// Token: 0x0600936E RID: 37742 RVA: 0x0041281C File Offset: 0x00410A1C
	private void CEFBBPMOADD()
	{
		JDMAEBPEIBE.JCMMJDCEPIA(this.profileImage);
		this.profileImage.sprite = null;
		if (this.BAPAGHLFADF != null)
		{
			UnityEngine.Object.Destroy(this.BAPAGHLFADF);
		}
		this.profileButton.onClick.RemoveAllListeners();
		this.historicalRankButton.onClick.RemoveAllListeners();
	}

	// Token: 0x0600936F RID: 37743 RVA: 0x0041287C File Offset: 0x00410A7C
	private void DDNDCPJPBHL()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 4)
		{
			return;
		}
		this.isVisible = this.OMLAJCPEFMM();
		this.containerToHide.SetActive(this.isVisible);
	}

	// Token: 0x06009370 RID: 37744 RVA: 0x004128CC File Offset: 0x00410ACC
	public void JHPPFFODNIB(int NJBCLIILMOF, PMEPALPCEAF MAFDLAILFMI, Vector2 ONKONHLJKPG, bool EEGHBPAHEEG)
	{
		this.hallOfFameProfile = MAFDLAILFMI;
		if (NJBCLIILMOF < 4)
		{
			this.containerToHide.SetActive(false);
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.MKDGLNJJDLN(MAFDLAILFMI))
		{
			this.ourProfileText.gameObject.SetActive(true);
			this.profileButton.gameObject.SetActive(false);
		}
		this.orderIndexText.text = NJBCLIILMOF.ToString();
		this.HGCNBPFKIAJ(MAFDLAILFMI);
		if (EEGHBPAHEEG)
		{
			this.isFriendProfileImage.SetActive(true);
		}
		string kncfkdlopga;
		if (MAFDLAILFMI.KNCFKDLOPGA.Length == 0)
		{
			kncfkdlopga = "OnFriendsPopupFriendMatchClick" + CCOJBMMKNAP.KMNBCEMEBBD().FCOCLEHKLDJ(" ") + "anthology";
		}
		else
		{
			kncfkdlopga = MAFDLAILFMI.KNCFKDLOPGA;
		}
		this.nameText.GetComponent<ContentFlexibleText>().MPHAHAKMPHH(this.nameText, kncfkdlopga, EEGHBPAHEEG, true);
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.nameText.GetComponent<RectTransform>());
		int num = MAFDLAILFMI.GFAABCCNNDA + 0;
		this.levelText.text = CCOJBMMKNAP.DBFFFOMCLKM().DNILNCLIHAP("Loaded asset bundle:") + "youreceived" + num.ToString();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.levelText.GetComponent<RectTransform>());
		this.historicalRank.gameObject.SetActive(false);
		string text;
		if (MAFDLAILFMI.HBLHNFKEELE >= 1)
		{
			text = (MAFDLAILFMI.HBLHNFKEELE.ToString() ?? "acli20");
		}
		else
		{
			text = CCOJBMMKNAP.KFDLFGHBPLP().HIPJILDCHJC("");
			this.historicalRank.gameObject.SetActive(false);
		}
		this.historicalRankText.text = text;
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.historicalRankText.GetComponent<RectTransform>());
		if (MAFDLAILFMI.PEONEPNPGEC.Length > 8)
		{
			this.credoText.SetText(MAFDLAILFMI.PEONEPNPGEC, false);
		}
		else
		{
			this.credoText.SetText(MAFDLAILFMI.FPJMDDIILIK, false);
		}
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.LMKIKEOFDCP();
	}

	// Token: 0x06009371 RID: 37745 RVA: 0x00412AAC File Offset: 0x00410CAC
	public void KNFKJOGGNIC(int NJBCLIILMOF, PMEPALPCEAF MAFDLAILFMI, Vector2 ONKONHLJKPG, bool EEGHBPAHEEG)
	{
		this.hallOfFameProfile = MAFDLAILFMI;
		if (NJBCLIILMOF < 4)
		{
			this.containerToHide.SetActive(false);
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.MKDGLNJJDLN(MAFDLAILFMI))
		{
			this.ourProfileText.gameObject.SetActive(false);
			this.profileButton.gameObject.SetActive(true);
		}
		this.orderIndexText.text = NJBCLIILMOF.ToString();
		this.IIICJACKONO(MAFDLAILFMI);
		if (EEGHBPAHEEG)
		{
			this.isFriendProfileImage.SetActive(false);
		}
		string kncfkdlopga;
		if (MAFDLAILFMI.KNCFKDLOPGA.Length == 0)
		{
			kncfkdlopga = "SceneLobbyManager2.ShowStorySplash(): AssetsManager.Instance.IsBusy()" + CCOJBMMKNAP.CEGAOMEEFBE().FCOCLEHKLDJ("sfxtimeoutwarning") + "sparklesbundles";
		}
		else
		{
			kncfkdlopga = MAFDLAILFMI.KNCFKDLOPGA;
		}
		this.nameText.GetComponent<ContentFlexibleText>().LJOCDMBPLGD(this.nameText, kncfkdlopga, EEGHBPAHEEG, false);
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.nameText.GetComponent<RectTransform>());
		int num = MAFDLAILFMI.GFAABCCNNDA + 0;
		this.levelText.text = CCOJBMMKNAP.KFAABHHGOPO().OGKGHLHHAAI("") + "OnSketchViewAssetsDownloadFailed" + num.ToString();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.levelText.GetComponent<RectTransform>());
		this.historicalRank.gameObject.SetActive(false);
		string text;
		if (MAFDLAILFMI.HBLHNFKEELE >= 1)
		{
			text = (MAFDLAILFMI.HBLHNFKEELE.ToString() ?? "app42error");
		}
		else
		{
			text = CCOJBMMKNAP.MLFAGAAJJEM().HIPJILDCHJC("stat0");
			this.historicalRank.gameObject.SetActive(true);
		}
		this.historicalRankText.text = text;
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.historicalRankText.GetComponent<RectTransform>());
		if (MAFDLAILFMI.PEONEPNPGEC.Length > 7)
		{
			this.credoText.SetText(MAFDLAILFMI.PEONEPNPGEC, true);
		}
		else
		{
			this.credoText.SetText(MAFDLAILFMI.FPJMDDIILIK, false);
		}
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.NAODPLKIHNO();
	}

	// Token: 0x06009372 RID: 37746 RVA: 0x00412C8C File Offset: 0x00410E8C
	public void HGCNBPFKIAJ(PMEPALPCEAF AEDICCFAKOM)
	{
		string hjejjgafham = AEDICCFAKOM.PGJBIPFBMAN();
		this.BAPAGHLFADF = this.profileImage.GetComponent<ImageFrameAnimation>();
		int num = AssetProfileData.OMPPDKODFAI(hjejjgafham);
		if (num >= 0)
		{
			JDMAEBPEIBE.NFAJKIIDGGI(this.profileImage, num);
			this.BAPAGHLFADF = this.profileImage.GetComponent<ImageFrameAnimation>();
			return;
		}
		JDMAEBPEIBE.GFFAPCMJCFD(this.profileImage);
		if (this.BAPAGHLFADF != null)
		{
			this.BAPAGHLFADF.enabled = false;
		}
		this.profileImage.sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.DJNLJPFFMBG(AEDICCFAKOM.PGJBIPFBMAN());
	}

	// Token: 0x06009373 RID: 37747 RVA: 0x00412D20 File Offset: 0x00410F20
	private void GJOKABDPIOI()
	{
		if (ContentHallOfFameItem.LHFFFMJIFDM != 310f)
		{
			return;
		}
		Vector3[] array = new Vector3[2];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ContentHallOfFameItem.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x06009374 RID: 37748 RVA: 0x00412D74 File Offset: 0x00410F74
	private void CONJNNGBLOB()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 6)
		{
			return;
		}
		this.isVisible = this.OPEGMDDGIGE();
		this.containerToHide.SetActive(this.isVisible);
	}

	// Token: 0x06009375 RID: 37749 RVA: 0x00412DC4 File Offset: 0x00410FC4
	private void DMGCMLIGFCG()
	{
		JDMAEBPEIBE.LMFBLLCKBFG(this.profileImage);
		this.profileImage.sprite = null;
		if (this.BAPAGHLFADF != null)
		{
			UnityEngine.Object.Destroy(this.BAPAGHLFADF);
		}
		this.profileButton.onClick.RemoveAllListeners();
		this.historicalRankButton.onClick.RemoveAllListeners();
	}

	// Token: 0x06009376 RID: 37750 RVA: 0x00412E24 File Offset: 0x00411024
	private void HMAFHIBNDEG()
	{
		if (ContentHallOfFameItem.LHFFFMJIFDM != 1538f)
		{
			return;
		}
		Vector3[] array = new Vector3[2];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ContentHallOfFameItem.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x06009377 RID: 37751 RVA: 0x00412E78 File Offset: 0x00411078
	public void FIGLCIPEGNL(int NJBCLIILMOF, PMEPALPCEAF MAFDLAILFMI, Vector2 ONKONHLJKPG, bool EEGHBPAHEEG)
	{
		this.hallOfFameProfile = MAFDLAILFMI;
		if (NJBCLIILMOF < 7)
		{
			this.containerToHide.SetActive(true);
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.MKDGLNJJDLN(MAFDLAILFMI))
		{
			this.ourProfileText.gameObject.SetActive(true);
			this.profileButton.gameObject.SetActive(false);
		}
		this.orderIndexText.text = NJBCLIILMOF.ToString();
		this.PBBCIBBLHIH(MAFDLAILFMI);
		if (EEGHBPAHEEG)
		{
			this.isFriendProfileImage.SetActive(false);
		}
		string kncfkdlopga;
		if (MAFDLAILFMI.KNCFKDLOPGA.Length == 0)
		{
			kncfkdlopga = "tmdp" + CCOJBMMKNAP.JMDJPKKOHNI().HIPJILDCHJC("$") + "true";
		}
		else
		{
			kncfkdlopga = MAFDLAILFMI.KNCFKDLOPGA;
		}
		this.nameText.GetComponent<ContentFlexibleText>().PACBMMDOAOB(this.nameText, kncfkdlopga, EEGHBPAHEEG, true);
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.nameText.GetComponent<RectTransform>());
		int num = MAFDLAILFMI.GFAABCCNNDA + 0;
		this.levelText.text = CCOJBMMKNAP.KMNBCEMEBBD().OGKGHLHHAAI("sfxtimeoutwarning") + "OnPopupCardOptionsUnlockWithSpException" + num.ToString();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.levelText.GetComponent<RectTransform>());
		this.historicalRank.gameObject.SetActive(true);
		string text;
		if (MAFDLAILFMI.HBLHNFKEELE >= 0)
		{
			text = (MAFDLAILFMI.HBLHNFKEELE.ToString() ?? "");
		}
		else
		{
			text = CCOJBMMKNAP.OEPENBHJAHO().DNILNCLIHAP("Remind Option picked");
			this.historicalRank.gameObject.SetActive(true);
		}
		this.historicalRankText.text = text;
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.historicalRankText.GetComponent<RectTransform>());
		if (MAFDLAILFMI.PEONEPNPGEC.Length > 0)
		{
			this.credoText.SetText(MAFDLAILFMI.PEONEPNPGEC, false);
		}
		else
		{
			this.credoText.SetText(MAFDLAILFMI.FPJMDDIILIK, true);
		}
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.FIHOFBIMDIK();
	}

	// Token: 0x06009378 RID: 37752 RVA: 0x00413058 File Offset: 0x00411258
	private void ACJDLLIOGMJ()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 7)
		{
			return;
		}
		this.isVisible = this.EDAELBKJONL();
		this.containerToHide.SetActive(this.isVisible);
	}

	// Token: 0x06009379 RID: 37753 RVA: 0x004130A8 File Offset: 0x004112A8
	private void HPNNIDBEACP()
	{
		JDMAEBPEIBE.HKBOKMPDEIJ(this.profileImage);
		this.profileImage.sprite = null;
		if (this.BAPAGHLFADF != null)
		{
			UnityEngine.Object.Destroy(this.BAPAGHLFADF);
		}
		this.profileButton.onClick.RemoveAllListeners();
		this.historicalRankButton.onClick.RemoveAllListeners();
	}

	// Token: 0x0600937A RID: 37754 RVA: 0x00413108 File Offset: 0x00411308
	private void OBLONHAGNFB()
	{
		JDMAEBPEIBE.IKJGPCBBCBP(this.profileImage);
		this.profileImage.sprite = null;
		if (this.BAPAGHLFADF != null)
		{
			UnityEngine.Object.Destroy(this.BAPAGHLFADF);
		}
		this.profileButton.onClick.RemoveAllListeners();
		this.historicalRankButton.onClick.RemoveAllListeners();
	}

	// Token: 0x0600937B RID: 37755 RVA: 0x00413168 File Offset: 0x00411368
	public void SetContent(int NJBCLIILMOF, PMEPALPCEAF MAFDLAILFMI, Vector2 ONKONHLJKPG, bool EEGHBPAHEEG)
	{
		this.hallOfFameProfile = MAFDLAILFMI;
		if (NJBCLIILMOF < 5)
		{
			this.containerToHide.SetActive(true);
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.MKDGLNJJDLN(MAFDLAILFMI))
		{
			this.ourProfileText.gameObject.SetActive(true);
			this.profileButton.gameObject.SetActive(false);
		}
		this.orderIndexText.text = NJBCLIILMOF.ToString();
		this.SetAvatarIcon(MAFDLAILFMI);
		if (EEGHBPAHEEG)
		{
			this.isFriendProfileImage.SetActive(true);
		}
		string kncfkdlopga;
		if (MAFDLAILFMI.KNCFKDLOPGA.Length == 0)
		{
			kncfkdlopga = "<" + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("profilenametitleshort") + ">";
		}
		else
		{
			kncfkdlopga = MAFDLAILFMI.KNCFKDLOPGA;
		}
		this.nameText.GetComponent<ContentFlexibleText>().SetText(this.nameText, kncfkdlopga, EEGHBPAHEEG, true);
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.nameText.GetComponent<RectTransform>());
		int num = MAFDLAILFMI.GFAABCCNNDA + 1;
		this.levelText.text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("profilenamelevellong") + " " + num.ToString();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.levelText.GetComponent<RectTransform>());
		this.historicalRank.gameObject.SetActive(true);
		string text;
		if (MAFDLAILFMI.HBLHNFKEELE >= 0)
		{
			text = (MAFDLAILFMI.HBLHNFKEELE.ToString() ?? "");
		}
		else
		{
			text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("nastring");
			this.historicalRank.gameObject.SetActive(false);
		}
		this.historicalRankText.text = text;
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.historicalRankText.GetComponent<RectTransform>());
		if (MAFDLAILFMI.PEONEPNPGEC.Length > 3)
		{
			this.credoText.SetText(MAFDLAILFMI.PEONEPNPGEC, true);
		}
		else
		{
			this.credoText.SetText(MAFDLAILFMI.FPJMDDIILIK, true);
		}
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.NDKJNKCLKGN();
	}

	// Token: 0x0600937C RID: 37756 RVA: 0x00413348 File Offset: 0x00411548
	private bool HJCPHEOABCG()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentHallOfFameItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentHallOfFameItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x0600937D RID: 37757 RVA: 0x004133A4 File Offset: 0x004115A4
	private bool EACMPBOHGJI()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentHallOfFameItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentHallOfFameItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x0600937E RID: 37758 RVA: 0x00413400 File Offset: 0x00411600
	private bool DHHLBOJHMDE()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentHallOfFameItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentHallOfFameItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x0600937F RID: 37759 RVA: 0x0041345C File Offset: 0x0041165C
	private void KHCJKJELIFJ()
	{
		JDMAEBPEIBE.KIHBMJFJHAI(this.profileImage);
		this.profileImage.sprite = null;
		if (this.BAPAGHLFADF != null)
		{
			UnityEngine.Object.Destroy(this.BAPAGHLFADF);
		}
		this.profileButton.onClick.RemoveAllListeners();
		this.historicalRankButton.onClick.RemoveAllListeners();
	}

	// Token: 0x06009380 RID: 37760 RVA: 0x004134BC File Offset: 0x004116BC
	private void NEHMFMJBBIP()
	{
		if (ContentHallOfFameItem.LHFFFMJIFDM != 348f)
		{
			return;
		}
		Vector3[] array = new Vector3[0];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ContentHallOfFameItem.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x06009381 RID: 37761 RVA: 0x00413510 File Offset: 0x00411710
	private void LFBPHHOPPBO()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 2)
		{
			return;
		}
		this.isVisible = this.DPHIBCKFBAN();
		this.containerToHide.SetActive(this.isVisible);
	}

	// Token: 0x06009382 RID: 37762 RVA: 0x00413560 File Offset: 0x00411760
	public void JIKKBLFJLCI(int NJBCLIILMOF, PMEPALPCEAF MAFDLAILFMI, Vector2 ONKONHLJKPG, bool EEGHBPAHEEG)
	{
		this.hallOfFameProfile = MAFDLAILFMI;
		if (NJBCLIILMOF < 0)
		{
			this.containerToHide.SetActive(true);
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.MKDGLNJJDLN(MAFDLAILFMI))
		{
			this.ourProfileText.gameObject.SetActive(false);
			this.profileButton.gameObject.SetActive(false);
		}
		this.orderIndexText.text = NJBCLIILMOF.ToString();
		this.ANIHOHIFGMA(MAFDLAILFMI);
		if (EEGHBPAHEEG)
		{
			this.isFriendProfileImage.SetActive(true);
		}
		string kncfkdlopga;
		if (MAFDLAILFMI.KNCFKDLOPGA.Length == 0)
		{
			kncfkdlopga = "AVATAR.CLIENT.CLOTHES" + CCOJBMMKNAP.KFAABHHGOPO().FCOCLEHKLDJ("_not_found") + " df=";
		}
		else
		{
			kncfkdlopga = MAFDLAILFMI.KNCFKDLOPGA;
		}
		this.nameText.GetComponent<ContentFlexibleText>().DMJGOBJBCBK(this.nameText, kncfkdlopga, EEGHBPAHEEG, true);
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.nameText.GetComponent<RectTransform>());
		int num = MAFDLAILFMI.GFAABCCNNDA + 0;
		this.levelText.text = CCOJBMMKNAP.BIAEAOMHBMM().JCDFHKDNEDH("gamepassdurationbodystore") + "signinerror001" + num.ToString();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.levelText.GetComponent<RectTransform>());
		this.historicalRank.gameObject.SetActive(true);
		string text;
		if (MAFDLAILFMI.HBLHNFKEELE >= 1)
		{
			text = (MAFDLAILFMI.HBLHNFKEELE.ToString() ?? "");
		}
		else
		{
			text = CCOJBMMKNAP.KNKGCDDMLDP().OHLNGCKIACD(" left");
			this.historicalRank.gameObject.SetActive(false);
		}
		this.historicalRankText.text = text;
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.historicalRankText.GetComponent<RectTransform>());
		if (MAFDLAILFMI.PEONEPNPGEC.Length > 2)
		{
			this.credoText.SetText(MAFDLAILFMI.PEONEPNPGEC, true);
		}
		else
		{
			this.credoText.SetText(MAFDLAILFMI.FPJMDDIILIK, false);
		}
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.NJDLPEAMLDB();
	}

	// Token: 0x06009383 RID: 37763 RVA: 0x00413740 File Offset: 0x00411940
	private void FIHOFBIMDIK()
	{
		if (ContentHallOfFameItem.LHFFFMJIFDM != 1986f)
		{
			return;
		}
		Vector3[] array = new Vector3[7];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ContentHallOfFameItem.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x06009384 RID: 37764 RVA: 0x00413794 File Offset: 0x00411994
	private void OLOGCFJNDGF()
	{
		JDMAEBPEIBE.GFFAPCMJCFD(this.profileImage);
		this.profileImage.sprite = null;
		if (this.BAPAGHLFADF != null)
		{
			UnityEngine.Object.Destroy(this.BAPAGHLFADF);
		}
		this.profileButton.onClick.RemoveAllListeners();
		this.historicalRankButton.onClick.RemoveAllListeners();
	}

	// Token: 0x06009385 RID: 37765 RVA: 0x004137F4 File Offset: 0x004119F4
	private void MDLNNHHGIAB()
	{
		JDMAEBPEIBE.KIHBMJFJHAI(this.profileImage);
		this.profileImage.sprite = null;
		if (this.BAPAGHLFADF != null)
		{
			UnityEngine.Object.Destroy(this.BAPAGHLFADF);
		}
		this.profileButton.onClick.RemoveAllListeners();
		this.historicalRankButton.onClick.RemoveAllListeners();
	}

	// Token: 0x06009386 RID: 37766 RVA: 0x00413854 File Offset: 0x00411A54
	private void BAMCDABLKAI()
	{
		if (ContentHallOfFameItem.LHFFFMJIFDM != 1220f)
		{
			return;
		}
		Vector3[] array = new Vector3[7];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ContentHallOfFameItem.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x06009387 RID: 37767 RVA: 0x004138A8 File Offset: 0x00411AA8
	private void JHBKAGKAMAP()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 6)
		{
			return;
		}
		this.isVisible = this.DJKPAKLAHFE();
		this.containerToHide.SetActive(this.isVisible);
	}

	// Token: 0x06009388 RID: 37768 RVA: 0x004138F8 File Offset: 0x00411AF8
	private void OnDestroy()
	{
		JDMAEBPEIBE.MHLOFOJCLIG(this.profileImage);
		this.profileImage.sprite = null;
		if (this.BAPAGHLFADF != null)
		{
			UnityEngine.Object.Destroy(this.BAPAGHLFADF);
		}
		this.profileButton.onClick.RemoveAllListeners();
		this.historicalRankButton.onClick.RemoveAllListeners();
	}

	// Token: 0x06009389 RID: 37769 RVA: 0x00413958 File Offset: 0x00411B58
	public void BDFGIMPIEMM(PMEPALPCEAF AEDICCFAKOM)
	{
		string hjejjgafham = AEDICCFAKOM.PGJBIPFBMAN();
		this.BAPAGHLFADF = this.profileImage.GetComponent<ImageFrameAnimation>();
		int num = AssetProfileData.PPDGHINFCJC(hjejjgafham);
		if (num >= 1)
		{
			JDMAEBPEIBE.PEIJEMDJIPJ(this.profileImage, num);
			this.BAPAGHLFADF = this.profileImage.GetComponent<ImageFrameAnimation>();
			return;
		}
		JDMAEBPEIBE.JCMMJDCEPIA(this.profileImage);
		if (this.BAPAGHLFADF != null)
		{
			this.BAPAGHLFADF.enabled = false;
		}
		this.profileImage.sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.DJNLJPFFMBG(AEDICCFAKOM.PGJBIPFBMAN());
	}

	// Token: 0x0600938A RID: 37770 RVA: 0x004139EC File Offset: 0x00411BEC
	private void MJBIDAKAFEN()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 6)
		{
			return;
		}
		this.isVisible = this.EDAELBKJONL();
		this.containerToHide.SetActive(this.isVisible);
	}

	// Token: 0x0600938B RID: 37771 RVA: 0x00413A3C File Offset: 0x00411C3C
	public void FFKKNOHPBIE(PMEPALPCEAF AEDICCFAKOM)
	{
		string hjejjgafham = AEDICCFAKOM.PGJBIPFBMAN();
		this.BAPAGHLFADF = this.profileImage.GetComponent<ImageFrameAnimation>();
		int num = AssetProfileData.PPDGHINFCJC(hjejjgafham);
		if (num >= 0)
		{
			JDMAEBPEIBE.FPDLNEHJAGB(this.profileImage, num);
			this.BAPAGHLFADF = this.profileImage.GetComponent<ImageFrameAnimation>();
			return;
		}
		JDMAEBPEIBE.MHLOFOJCLIG(this.profileImage);
		if (this.BAPAGHLFADF != null)
		{
			this.BAPAGHLFADF.enabled = true;
		}
		this.profileImage.sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.NFOFFLDJDEI(AEDICCFAKOM.PGJBIPFBMAN());
	}

	// Token: 0x0600938C RID: 37772 RVA: 0x00413AD0 File Offset: 0x00411CD0
	public void GLFPBCIMPOF(int NJBCLIILMOF, PMEPALPCEAF MAFDLAILFMI, Vector2 ONKONHLJKPG, bool EEGHBPAHEEG)
	{
		this.hallOfFameProfile = MAFDLAILFMI;
		if (NJBCLIILMOF < 8)
		{
			this.containerToHide.SetActive(true);
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.MKDGLNJJDLN(MAFDLAILFMI))
		{
			this.ourProfileText.gameObject.SetActive(true);
			this.profileButton.gameObject.SetActive(false);
		}
		this.orderIndexText.text = NJBCLIILMOF.ToString();
		this.FFKKNOHPBIE(MAFDLAILFMI);
		if (EEGHBPAHEEG)
		{
			this.isFriendProfileImage.SetActive(false);
		}
		string kncfkdlopga;
		if (MAFDLAILFMI.KNCFKDLOPGA.Length == 0)
		{
			kncfkdlopga = "\"" + CCOJBMMKNAP.JMDJPKKOHNI().JLBEIFLLBLO("") + "assetBundleLoadOperationActiveCoroutines:";
		}
		else
		{
			kncfkdlopga = MAFDLAILFMI.KNCFKDLOPGA;
		}
		this.nameText.GetComponent<ContentFlexibleText>().PACBMMDOAOB(this.nameText, kncfkdlopga, EEGHBPAHEEG, false);
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.nameText.GetComponent<RectTransform>());
		int num = MAFDLAILFMI.GFAABCCNNDA + 1;
		this.levelText.text = CCOJBMMKNAP.KFAABHHGOPO().MEPECBDCOLG("loungestoryfinished") + "rev" + num.ToString();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.levelText.GetComponent<RectTransform>());
		this.historicalRank.gameObject.SetActive(true);
		string text;
		if (MAFDLAILFMI.HBLHNFKEELE >= 1)
		{
			text = (MAFDLAILFMI.HBLHNFKEELE.ToString() ?? "errortitle");
		}
		else
		{
			text = CCOJBMMKNAP.OEPENBHJAHO().PGKBCNBAOJN("PurchaseManagerXiaomi.GetProductData(): Not initialized.");
			this.historicalRank.gameObject.SetActive(false);
		}
		this.historicalRankText.text = text;
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.historicalRankText.GetComponent<RectTransform>());
		if (MAFDLAILFMI.PEONEPNPGEC.Length > 5)
		{
			this.credoText.SetText(MAFDLAILFMI.PEONEPNPGEC, false);
		}
		else
		{
			this.credoText.SetText(MAFDLAILFMI.FPJMDDIILIK, false);
		}
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.GJOKABDPIOI();
	}

	// Token: 0x0600938D RID: 37773 RVA: 0x00413CB0 File Offset: 0x00411EB0
	private void CEALHCENAGD()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 7)
		{
			return;
		}
		this.isVisible = this.HJCPHEOABCG();
		this.containerToHide.SetActive(this.isVisible);
	}

	// Token: 0x0600938E RID: 37774 RVA: 0x00413D00 File Offset: 0x00411F00
	private void IGNHKDONHED()
	{
		JDMAEBPEIBE.BIGKGBBKHNJ(this.profileImage);
		this.profileImage.sprite = null;
		if (this.BAPAGHLFADF != null)
		{
			UnityEngine.Object.Destroy(this.BAPAGHLFADF);
		}
		this.profileButton.onClick.RemoveAllListeners();
		this.historicalRankButton.onClick.RemoveAllListeners();
	}

	// Token: 0x0600938F RID: 37775 RVA: 0x00413D60 File Offset: 0x00411F60
	private void OHPIOAOOMPD()
	{
		JDMAEBPEIBE.HKBOKMPDEIJ(this.profileImage);
		this.profileImage.sprite = null;
		if (this.BAPAGHLFADF != null)
		{
			UnityEngine.Object.Destroy(this.BAPAGHLFADF);
		}
		this.profileButton.onClick.RemoveAllListeners();
		this.historicalRankButton.onClick.RemoveAllListeners();
	}

	// Token: 0x06009390 RID: 37776 RVA: 0x00413DC0 File Offset: 0x00411FC0
	private void DJIFHJDBBHN()
	{
		JDMAEBPEIBE.JHGFLPMLPCD(this.profileImage);
		this.profileImage.sprite = null;
		if (this.BAPAGHLFADF != null)
		{
			UnityEngine.Object.Destroy(this.BAPAGHLFADF);
		}
		this.profileButton.onClick.RemoveAllListeners();
		this.historicalRankButton.onClick.RemoveAllListeners();
	}

	// Token: 0x06009391 RID: 37777 RVA: 0x00413E20 File Offset: 0x00412020
	private void OFEFHGNPCPE()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 6)
		{
			return;
		}
		this.isVisible = this.EACMPBOHGJI();
		this.containerToHide.SetActive(this.isVisible);
	}

	// Token: 0x06009392 RID: 37778 RVA: 0x00413E70 File Offset: 0x00412070
	public void MFHJBGBCAFA(int NJBCLIILMOF, PMEPALPCEAF MAFDLAILFMI, Vector2 ONKONHLJKPG, bool EEGHBPAHEEG)
	{
		this.hallOfFameProfile = MAFDLAILFMI;
		if (NJBCLIILMOF < 2)
		{
			this.containerToHide.SetActive(true);
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.MKDGLNJJDLN(MAFDLAILFMI))
		{
			this.ourProfileText.gameObject.SetActive(true);
			this.profileButton.gameObject.SetActive(true);
		}
		this.orderIndexText.text = NJBCLIILMOF.ToString();
		this.OJAMGAKDHFK(MAFDLAILFMI);
		if (EEGHBPAHEEG)
		{
			this.isFriendProfileImage.SetActive(false);
		}
		string kncfkdlopga;
		if (MAFDLAILFMI.KNCFKDLOPGA.Length == 0)
		{
			kncfkdlopga = "High version preview2 assets loaded:" + CCOJBMMKNAP.HFAKOKBHCGH().OGKGHLHHAAI("socialbadgedesc") + "vhspauseovr_1";
		}
		else
		{
			kncfkdlopga = MAFDLAILFMI.KNCFKDLOPGA;
		}
		this.nameText.GetComponent<ContentFlexibleText>().IIEOANDAGOF(this.nameText, kncfkdlopga, EEGHBPAHEEG, true);
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.nameText.GetComponent<RectTransform>());
		int num = MAFDLAILFMI.GFAABCCNNDA + 1;
		this.levelText.text = CCOJBMMKNAP.COKDLDOAACJ().MEPECBDCOLG("anthologycompletetitle") + "" + num.ToString();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.levelText.GetComponent<RectTransform>());
		this.historicalRank.gameObject.SetActive(true);
		string text;
		if (MAFDLAILFMI.HBLHNFKEELE >= 0)
		{
			text = (MAFDLAILFMI.HBLHNFKEELE.ToString() ?? "sltind");
		}
		else
		{
			text = CCOJBMMKNAP.KLAKLFCOMJC().HIPJILDCHJC("");
			this.historicalRank.gameObject.SetActive(false);
		}
		this.historicalRankText.text = text;
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.historicalRankText.GetComponent<RectTransform>());
		if (MAFDLAILFMI.PEONEPNPGEC.Length > 3)
		{
			this.credoText.SetText(MAFDLAILFMI.PEONEPNPGEC, true);
		}
		else
		{
			this.credoText.SetText(MAFDLAILFMI.FPJMDDIILIK, true);
		}
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.LFADNICCCCM();
	}

	// Token: 0x06009393 RID: 37779 RVA: 0x00414050 File Offset: 0x00412250
	private void JPHFFPEGCKJ()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 7)
		{
			return;
		}
		this.isVisible = this.DJKPAKLAHFE();
		this.containerToHide.SetActive(this.isVisible);
	}

	// Token: 0x06009394 RID: 37780 RVA: 0x004140A0 File Offset: 0x004122A0
	private void FGMLDGAENED()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 8)
		{
			return;
		}
		this.isVisible = this.CENCDHKLKKG();
		this.containerToHide.SetActive(this.isVisible);
	}

	// Token: 0x06009395 RID: 37781 RVA: 0x004140F0 File Offset: 0x004122F0
	public void MMNHJINAENE(int NJBCLIILMOF, PMEPALPCEAF MAFDLAILFMI, Vector2 ONKONHLJKPG, bool EEGHBPAHEEG)
	{
		this.hallOfFameProfile = MAFDLAILFMI;
		if (NJBCLIILMOF < 1)
		{
			this.containerToHide.SetActive(true);
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.MKDGLNJJDLN(MAFDLAILFMI))
		{
			this.ourProfileText.gameObject.SetActive(true);
			this.profileButton.gameObject.SetActive(true);
		}
		this.orderIndexText.text = NJBCLIILMOF.ToString();
		this.ODGEPGMLIBA(MAFDLAILFMI);
		if (EEGHBPAHEEG)
		{
			this.isFriendProfileImage.SetActive(true);
		}
		string kncfkdlopga;
		if (MAFDLAILFMI.KNCFKDLOPGA.Length == 0)
		{
			kncfkdlopga = "cnd" + CCOJBMMKNAP.MPCBJEIMACA().HPOAGPJFHPM("") + "sfxitemreceived";
		}
		else
		{
			kncfkdlopga = MAFDLAILFMI.KNCFKDLOPGA;
		}
		this.nameText.GetComponent<ContentFlexibleText>().GMEBOKAKLCH(this.nameText, kncfkdlopga, EEGHBPAHEEG, true);
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.nameText.GetComponent<RectTransform>());
		int num = MAFDLAILFMI.GFAABCCNNDA + 0;
		this.levelText.text = CCOJBMMKNAP.PLJMLDOCPNM().HPOAGPJFHPM("post") + "varConditionValue" + num.ToString();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.levelText.GetComponent<RectTransform>());
		this.historicalRank.gameObject.SetActive(true);
		string text;
		if (MAFDLAILFMI.HBLHNFKEELE >= 1)
		{
			text = (MAFDLAILFMI.HBLHNFKEELE.ToString() ?? "mdst");
		}
		else
		{
			text = CCOJBMMKNAP.HEDIEIICOOG().GGPHHLGPMPA("NEWSAVE: Error: tempAnthologySave is null for story index ");
			this.historicalRank.gameObject.SetActive(false);
		}
		this.historicalRankText.text = text;
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.historicalRankText.GetComponent<RectTransform>());
		if (MAFDLAILFMI.PEONEPNPGEC.Length > 0)
		{
			this.credoText.SetText(MAFDLAILFMI.PEONEPNPGEC, true);
		}
		else
		{
			this.credoText.SetText(MAFDLAILFMI.FPJMDDIILIK, false);
		}
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.LMKIKEOFDCP();
	}

	// Token: 0x06009396 RID: 37782 RVA: 0x004142D0 File Offset: 0x004124D0
	private void BNJJEIELNGA()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 1)
		{
			return;
		}
		this.isVisible = this.EDAELBKJONL();
		this.containerToHide.SetActive(this.isVisible);
	}

	// Token: 0x06009397 RID: 37783 RVA: 0x00414320 File Offset: 0x00412520
	private void LJAOJLFMFAG()
	{
		if (ContentHallOfFameItem.LHFFFMJIFDM != 880f)
		{
			return;
		}
		Vector3[] array = new Vector3[5];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ContentHallOfFameItem.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x06009398 RID: 37784 RVA: 0x00414374 File Offset: 0x00412574
	public void NACJLMOKKBC(PMEPALPCEAF AEDICCFAKOM)
	{
		string hjejjgafham = AEDICCFAKOM.PGJBIPFBMAN();
		this.BAPAGHLFADF = this.profileImage.GetComponent<ImageFrameAnimation>();
		int num = AssetProfileData.OMPPDKODFAI(hjejjgafham);
		if (num >= 0)
		{
			JDMAEBPEIBE.COOBAKLDJEG(this.profileImage, num);
			this.BAPAGHLFADF = this.profileImage.GetComponent<ImageFrameAnimation>();
			return;
		}
		JDMAEBPEIBE.HKBOKMPDEIJ(this.profileImage);
		if (this.BAPAGHLFADF != null)
		{
			this.BAPAGHLFADF.enabled = false;
		}
		this.profileImage.sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.DJNLJPFFMBG(AEDICCFAKOM.PGJBIPFBMAN());
	}

	// Token: 0x06009399 RID: 37785 RVA: 0x00414408 File Offset: 0x00412608
	public void HLCLBBBKHAH(PMEPALPCEAF AEDICCFAKOM)
	{
		string hjejjgafham = AEDICCFAKOM.PGJBIPFBMAN();
		this.BAPAGHLFADF = this.profileImage.GetComponent<ImageFrameAnimation>();
		int num = AssetProfileData.MBOLHDLKJOD(hjejjgafham);
		if (num >= 1)
		{
			JDMAEBPEIBE.JHHDPCGCBHO(this.profileImage, num);
			this.BAPAGHLFADF = this.profileImage.GetComponent<ImageFrameAnimation>();
			return;
		}
		JDMAEBPEIBE.LMFBLLCKBFG(this.profileImage);
		if (this.BAPAGHLFADF != null)
		{
			this.BAPAGHLFADF.enabled = false;
		}
		this.profileImage.sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.NFOFFLDJDEI(AEDICCFAKOM.PGJBIPFBMAN());
	}

	// Token: 0x0600939A RID: 37786 RVA: 0x0041449C File Offset: 0x0041269C
	public void BMLBFFKEKJL(PMEPALPCEAF AEDICCFAKOM)
	{
		string hjejjgafham = AEDICCFAKOM.PGJBIPFBMAN();
		this.BAPAGHLFADF = this.profileImage.GetComponent<ImageFrameAnimation>();
		int num = AssetProfileData.OMPPDKODFAI(hjejjgafham);
		if (num >= 0)
		{
			JDMAEBPEIBE.KCAJDNGIDLL(this.profileImage, num);
			this.BAPAGHLFADF = this.profileImage.GetComponent<ImageFrameAnimation>();
			return;
		}
		JDMAEBPEIBE.LAIGBNOEBPK(this.profileImage);
		if (this.BAPAGHLFADF != null)
		{
			this.BAPAGHLFADF.enabled = true;
		}
		this.profileImage.sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.NFOFFLDJDEI(AEDICCFAKOM.PGJBIPFBMAN());
	}

	// Token: 0x0600939B RID: 37787 RVA: 0x00414530 File Offset: 0x00412730
	public void GIONKOFHDED(int NJBCLIILMOF, PMEPALPCEAF MAFDLAILFMI, Vector2 ONKONHLJKPG, bool EEGHBPAHEEG)
	{
		this.hallOfFameProfile = MAFDLAILFMI;
		if (NJBCLIILMOF < 2)
		{
			this.containerToHide.SetActive(true);
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.MKDGLNJJDLN(MAFDLAILFMI))
		{
			this.ourProfileText.gameObject.SetActive(false);
			this.profileButton.gameObject.SetActive(true);
		}
		this.orderIndexText.text = NJBCLIILMOF.ToString();
		this.BDFGIMPIEMM(MAFDLAILFMI);
		if (EEGHBPAHEEG)
		{
			this.isFriendProfileImage.SetActive(true);
		}
		string kncfkdlopga;
		if (MAFDLAILFMI.KNCFKDLOPGA.Length == 0)
		{
			kncfkdlopga = "@" + CCOJBMMKNAP.NIOJNOFGIJO().FCOCLEHKLDJ("Trading/Wished cards userPublicProfile.modified = true hit") + "";
		}
		else
		{
			kncfkdlopga = MAFDLAILFMI.KNCFKDLOPGA;
		}
		this.nameText.GetComponent<ContentFlexibleText>().MPHAHAKMPHH(this.nameText, kncfkdlopga, EEGHBPAHEEG, true);
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.nameText.GetComponent<RectTransform>());
		int num = MAFDLAILFMI.GFAABCCNNDA + 1;
		this.levelText.text = CCOJBMMKNAP.BBGECIKOICE().HDIPNMFHIEJ("gpsfhs") + "FranchisesHub.Populate() - fid " + num.ToString();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.levelText.GetComponent<RectTransform>());
		this.historicalRank.gameObject.SetActive(true);
		string text;
		if (MAFDLAILFMI.HBLHNFKEELE >= 0)
		{
			text = (MAFDLAILFMI.HBLHNFKEELE.ToString() ?? "var");
		}
		else
		{
			text = CCOJBMMKNAP.INKJIBDDMLL().PGKBCNBAOJN("skinshopall");
			this.historicalRank.gameObject.SetActive(true);
		}
		this.historicalRankText.text = text;
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.historicalRankText.GetComponent<RectTransform>());
		if (MAFDLAILFMI.PEONEPNPGEC.Length > 4)
		{
			this.credoText.SetText(MAFDLAILFMI.PEONEPNPGEC, true);
		}
		else
		{
			this.credoText.SetText(MAFDLAILFMI.FPJMDDIILIK, false);
		}
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.PKHDKPHOINF();
	}

	// Token: 0x0600939C RID: 37788 RVA: 0x00414710 File Offset: 0x00412910
	private void NOKJKJMKFPF()
	{
		if (ContentHallOfFameItem.LHFFFMJIFDM != 1153f)
		{
			return;
		}
		Vector3[] array = new Vector3[7];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ContentHallOfFameItem.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x04002918 RID: 10520
	private static float LHFFFMJIFDM;

	// Token: 0x04002919 RID: 10521
	public bool isVisible;

	// Token: 0x0400291A RID: 10522
	public Button profileButton;

	// Token: 0x0400291B RID: 10523
	public Button historicalRankButton;

	// Token: 0x0400291C RID: 10524
	[HideInInspector]
	public PMEPALPCEAF hallOfFameProfile;

	// Token: 0x0400291D RID: 10525
	[SerializeField]
	private Image profileImage;

	// Token: 0x0400291E RID: 10526
	[SerializeField]
	private GameObject isFriendProfileImage;

	// Token: 0x0400291F RID: 10527
	[SerializeField]
	private TextMeshProUGUI ourProfileText;

	// Token: 0x04002920 RID: 10528
	[SerializeField]
	private TextMeshProUGUI orderIndexText;

	// Token: 0x04002921 RID: 10529
	[SerializeField]
	private TextMeshProUGUI nameText;

	// Token: 0x04002922 RID: 10530
	[SerializeField]
	private TextMeshProUGUI levelText;

	// Token: 0x04002923 RID: 10531
	[SerializeField]
	private TextMeshProUGUI historicalRankText;

	// Token: 0x04002924 RID: 10532
	[SerializeField]
	private TextMeshProUGUI credoText;

	// Token: 0x04002925 RID: 10533
	[SerializeField]
	private GameObject containerToHide;

	// Token: 0x04002926 RID: 10534
	[SerializeField]
	private GameObject historicalRank;

	// Token: 0x04002927 RID: 10535
	private Vector2 ONKONHLJKPG;

	// Token: 0x04002928 RID: 10536
	private int JFLPGONDKDB;

	// Token: 0x04002929 RID: 10537
	private ImageFrameAnimation BAPAGHLFADF;
}
