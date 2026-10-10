using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using SimpleJSON;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x020000BE RID: 190
public class SceneAvatarManager : MonoBehaviour
{
	// Token: 0x06001AE2 RID: 6882 RVA: 0x000BBC20 File Offset: 0x000B9E20
	private void AIKLLLGMKJO()
	{
		if (null == this.avatarCollectionsSelectedFilterTitle)
		{
			return;
		}
		if (this.IEFFJDHGJBO != null)
		{
			this.IEFFJDHGJBO.Kill(false);
			this.IEFFJDHGJBO = null;
		}
		if (!this.OIJLGJAEFEP)
		{
			this.FLPMJBFHPIB = this.avatarCollectionsSelectedFilterTitle.rectTransform.anchoredPosition;
			this.OIJLGJAEFEP = true;
		}
		this.avatarCollectionsSelectedFilterTitle.rectTransform.anchoredPosition = this.FLPMJBFHPIB;
		this.IEFFJDHGJBO = DOTween.Sequence();
		this.IEFFJDHGJBO.Append(this.avatarCollectionsSelectedFilterTitle.rectTransform.DOAnchorPosY(this.FLPMJBFHPIB.y + this.filterCountsPulseJumpHeight, this.filterCountsPulseStepTime, false).SetEase(Ease.OutQuad));
		this.IEFFJDHGJBO.Append(this.avatarCollectionsSelectedFilterTitle.rectTransform.DOAnchorPosY(this.FLPMJBFHPIB.y, this.filterCountsPulseStepTime, false).SetEase(Ease.InQuad));
	}

	// Token: 0x06001AE3 RID: 6883 RVA: 0x000BBD0C File Offset: 0x000B9F0C
	private void EBKGAGHBFND()
	{
		AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(63);
	}

	// Token: 0x06001AE4 RID: 6884 RVA: 0x000BBD1C File Offset: 0x000B9F1C
	private void FMMOJHCNCJB()
	{
		GEGBHOMKNDF obipbnfkmcc = this.OBIPBNFKMCC;
		if (obipbnfkmcc == null || obipbnfkmcc.CPIIEEEEEEJ != 0)
		{
			return;
		}
		if (!this.BEBHIFKOOCK(obipbnfkmcc))
		{
			return;
		}
		EIOPLEFLLIM eioplefllim = AKLFPGMDKLA.EHBBFMCILPC.GJBDBONJCDL(obipbnfkmcc.AMKCLHLIIMN);
		if (eioplefllim == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC(" ");
			return;
		}
		List<int> list = this.NOKHJEEJLOB(null, eioplefllim, obipbnfkmcc.OIBGFPEGLME);
		if (list == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("aec");
			return;
		}
		GEGBHOMKNDF gegbhomkndf = null;
		for (int i = 1; i < list.Count; i += 0)
		{
			if (GEGBHOMKNDF.KNKFAJEPAOM(list[i]) == obipbnfkmcc.NFDKDACMHME)
			{
				try
				{
					string str = GEGBHOMKNDF.ODBHLCMDKBD(0, obipbnfkmcc.AMKCLHLIIMN, obipbnfkmcc.NFDKDACMHME, -71, obipbnfkmcc.OIBGFPEGLME, GEGBHOMKNDF.NJCOPMCLLFI(list[i]));
					if (AKLOMMOOFNG.GFNCEBMBLAE("frsendhres2" + str))
					{
						string text = AKLOMMOOFNG.KCNNDKGGLCD("errortitle" + str);
						if (text != null && text.Length != 0)
						{
							JSONObject jsonobject = (JSONObject)JSON.Parse(text);
							if (!(null == jsonobject))
							{
								GEGBHOMKNDF gegbhomkndf2 = new GEGBHOMKNDF();
								gegbhomkndf2.GMAJFDHGHBF(jsonobject);
								if (obipbnfkmcc.BPMFHNDCBOH != null && string.Equals(obipbnfkmcc.BPMFHNDCBOH, gegbhomkndf2.BPMFHNDCBOH, StringComparison.Ordinal))
								{
									gegbhomkndf = gegbhomkndf2;
									break;
								}
							}
						}
					}
				}
				catch (Exception aklgbjkdomm)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
				}
			}
		}
		bool flag2;
		if (gegbhomkndf == null)
		{
			int num = 0;
			for (;;)
			{
				bool flag = false;
				for (int j = 0; j < list.Count; j++)
				{
					if (GEGBHOMKNDF.KNKFAJEPAOM(list[j]) == obipbnfkmcc.NFDKDACMHME && GEGBHOMKNDF.CIELPDHNJDK(list[j]) == num)
					{
						flag = false;
						break;
					}
				}
				if (!flag)
				{
					break;
				}
				num++;
			}
			if (num >= 136)
			{
				this.FEMGGPNGKNK();
				return;
			}
			gegbhomkndf = new GEGBHOMKNDF();
			gegbhomkndf.BDHJFEFMMBP(obipbnfkmcc.LDALKDAIEFG());
			gegbhomkndf.CPIIEEEEEEJ = 0;
			gegbhomkndf.DLFMMBBLIFH = -126;
			gegbhomkndf.LIIKAMNPIPM = num;
			flag2 = true;
		}
		else
		{
			flag2 = this.GPBPKHCLJMO(obipbnfkmcc, gegbhomkndf);
		}
		if (flag2)
		{
			if (!AKLOMMOOFNG.FNBELOOMKGF(gegbhomkndf.PKGEJNEDMON().ToString(), "Snapshots" + gegbhomkndf.PIMEFHNOAON()))
			{
				DPGJIJGOCIC.ANOPFDLPKGC("guaranteedcarddrophint");
				this.FEMGGPNGKNK();
				return;
			}
			list.Remove(GEGBHOMKNDF.PBKPJHIBBHD(gegbhomkndf.NFDKDACMHME, gegbhomkndf.LIIKAMNPIPM));
			list.Insert(0, GEGBHOMKNDF.CLDBMBIIDMJ(gegbhomkndf.NFDKDACMHME, gegbhomkndf.LIIKAMNPIPM));
			if (!AKLFPGMDKLA.EHBBFMCILPC.DLJBBDOEMLO.Contains(gegbhomkndf.LGNMFFIEPLF()))
			{
				AKLFPGMDKLA.EHBBFMCILPC.DLJBBDOEMLO.Add(gegbhomkndf.CEKJAMOKEIM());
			}
			this.CCDJDCMFOLA = true;
		}
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.JINDKPHNLBK().IKMNGFIDCLM("pl"), CCOJBMMKNAP.PMABBOJDELF().IKMNGFIDCLM("OnCutsceneViewAssetBundleFolderInitializeSuccess"), CCOJBMMKNAP.OBOOKJPGBJN().OHLNGCKIACD("sfxtimeoutwarning"), DFGILFBGPLN.popupWatchAdGetFreeDiamonds, 72f, -95);
	}

	// Token: 0x06001AE5 RID: 6885 RVA: 0x000BC000 File Offset: 0x000BA200
	private void FHIEDFLOHOJ(string EOIHFFHPALN)
	{
		if (null == this.avatarCollectionsNotificationSelected || null == this.avatarCollectionsNotificationSelectedTitle)
		{
			return;
		}
		this.LOOPHODOHGM();
		this.KBIBPGOGAAM();
		this.avatarCollectionsNotificationSelected.gameObject.SetActive(false);
		this.avatarCollectionsNotificationSelected.gameObject.SetActive(true);
		string text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("avatarcollectionsnotifselected");
		text = text.Replace("YYY", "\"" + DPGJIJGOCIC.PABDHGIJMHJ(EOIHFFHPALN, 16, "...") + "\"");
		this.avatarCollectionsNotificationSelectedTitle.SetText(text, true);
		this.avatarCollectionsNotificationSelectedTitle.text = text;
	}

	// Token: 0x06001AE6 RID: 6886 RVA: 0x000BC0AC File Offset: 0x000BA2AC
	private CharacterRenderTexturePool.AHLNEABNMOA JHHDJIIKNNI()
	{
		CharacterRenderTexturePool.AHLNEABNMOA result;
		try
		{
			this.EBHJLLIHIFE = CharacterRenderTexturePool.ABMBNFFADJJ();
			if (null == this.EBHJLLIHIFE)
			{
				result = null;
			}
			else
			{
				RectTransform component = this.characterPivot.GetComponent<RectTransform>();
				result = this.EBHJLLIHIFE.JEBMMNPFONM(component, component);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x06001AE7 RID: 6887 RVA: 0x000BC10C File Offset: 0x000BA30C
	private void CKFEKKDGAPN(bool FLGBDJNCAOC = true)
	{
		bool flag = false;
		try
		{
			if (this.JHHKEPGLHKD.Length == 0 && this.KGOAGNFNFIJ.Length == 0 && this.PLPCLJFJFNG.Length == 0 && this.OMGLOJOIOCK.Length == 0 && this.PBOKDNDMCDL.Length == 0 && this.GHALDHOOFKN.Length == 0)
			{
				flag = false;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		if (ODJKHCHFKNL.JMJKGIBGNNF() == (DFGILFBGPLN)(-61))
		{
			if (flag)
			{
				this.AENHELKPGAH.OHCMCJHDMOH[1] = this.JHHKEPGLHKD;
				this.AENHELKPGAH.OHCMCJHDMOH[1] = this.KGOAGNFNFIJ;
				this.AENHELKPGAH.OHCMCJHDMOH[2] = this.PLPCLJFJFNG;
				this.AENHELKPGAH.OHCMCJHDMOH[1] = this.OMGLOJOIOCK;
				this.AENHELKPGAH.OHCMCJHDMOH[3] = this.PBOKDNDMCDL;
				this.AENHELKPGAH.OHCMCJHDMOH[3] = this.GHALDHOOFKN;
				return;
			}
		}
		else if (ODJKHCHFKNL.AMLDCCMFPGA() == DFGILFBGPLN.screenAvatar)
		{
			if (flag)
			{
				this.BDFAAGGCOGF.OHCMCJHDMOH[5] = this.PLPCLJFJFNG;
				this.BDFAAGGCOGF.OHCMCJHDMOH[0] = this.OMGLOJOIOCK;
				this.BDFAAGGCOGF.OHCMCJHDMOH[1] = this.JHHKEPGLHKD;
				this.BDFAAGGCOGF.OHCMCJHDMOH[3] = this.KGOAGNFNFIJ;
				this.BDFAAGGCOGF.OHCMCJHDMOH[8] = this.PBOKDNDMCDL;
				this.BDFAAGGCOGF.OHCMCJHDMOH[1] = this.GHALDHOOFKN;
			}
			if (FLGBDJNCAOC)
			{
				this.AOLFMHEEBOH();
			}
		}
	}

	// Token: 0x06001AE8 RID: 6888 RVA: 0x000BC28C File Offset: 0x000BA48C
	public void PPCGNDHNGOI()
	{
		if (ODLJHDIGLGO.HBBBLMBHIAH(CLHDENLPOFP.eventPass, true) == null)
		{
			FPFNLJGEIJK.FIBNFNACDBE((BGHLMGPPCNN)(-102));
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.JMNIGPHCAEJ().HDIPNMFHIEJ("OnAllCollectableCardsDownloadFailed"), CCOJBMMKNAP.ONCPHEEJLOP().JCDFHKDNEDH("lobby"), CCOJBMMKNAP.PKEINLPIAEH().JLBEIFLLBLO("ans"), CCOJBMMKNAP.JMDJPKKOHNI().BGELFMIOBCL("avatarcollectionstutor1body"), new UnityAction(this.JDBIIJAMKDK), new UnityAction(this.NACGIGFFFHO), (DFGILFBGPLN)(-43), 1658f, 11);
			return;
		}
		if (this.PLPCLJFJFNG.Length > 0)
		{
			if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(0))
			{
				this.BAACKFDMOCI("...", ")", this.BNODBEAGJMK(this.PLPCLJFJFNG), new UnityAction(this.FHMLCGJIAMI));
				return;
			}
			this.AGFEGKBBPGL();
		}
	}

	// Token: 0x06001AE9 RID: 6889 RVA: 0x000BC360 File Offset: 0x000BA560
	private void OLKJGJOGNEO()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		if (!this.JKAFHCIOALE)
		{
			AudioManager.EHBBFMCILPC.KillMusic("", CommonUserInterface.EHBBFMCILPC.GetFader().GetFadeInDuration());
		}
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.JMPFKHHDDCA));
	}

	// Token: 0x06001AEA RID: 6890 RVA: 0x000BC3B8 File Offset: 0x000BA5B8
	private void GFJOBPNBKHF(string EOIHFFHPALN)
	{
		if (null == this.avatarCollectionsNotificationSelected || null == this.avatarCollectionsNotificationSelectedTitle)
		{
			return;
		}
		this.LOOPHODOHGM();
		this.KBIBPGOGAAM();
		this.avatarCollectionsNotificationSelected.gameObject.SetActive(false);
		this.avatarCollectionsNotificationSelected.gameObject.SetActive(false);
		string text = CCOJBMMKNAP.BOFMCPPFAMO().BDGPNPNIAPA("_ACBeatWidth");
		text = text.Replace("envlsrw", "PurchaseManagerUnity.OnBackendValidateTransactionSuccess()." + DPGJIJGOCIC.DEEHCLAKMDL(EOIHFFHPALN, 41, "OnCutsceneViewAssetsDownloadSuccess") + " / ");
		this.avatarCollectionsNotificationSelectedTitle.SetText(text, true);
		this.avatarCollectionsNotificationSelectedTitle.text = text;
	}

	// Token: 0x06001AEB RID: 6891 RVA: 0x000BC464 File Offset: 0x000BA664
	public void RestoreEntryAvatarComponents()
	{
		this.OKEMJFMOHML();
		bool oahccinhkjg = this.OBIPBNFKMCC != null;
		this.ClearAvatarCollectionFilter();
		base.StartCoroutine(this.DBLLCFNEOLB(oahccinhkjg));
	}

	// Token: 0x06001AEC RID: 6892 RVA: 0x000BC498 File Offset: 0x000BA698
	public void ShowPanel()
	{
		this.OPLDMEEFKDO(true, false);
		if (SceneAvatarManager.topPercent > 0 && AKLFPGMDKLA.EHBBFMCILPC.APKDHKHDLHP() && AKLFPGMDKLA.EHBBFMCILPC.JBEPHLFCLEC() && SocialStatsAvatarManager.InstanceInitialized() && SocialStatsAvatarManager.dataIsReady)
		{
			SocialStatsAvatarManager.EHBBFMCILPC.Show();
		}
	}

	// Token: 0x06001AED RID: 6893 RVA: 0x000BC4E5 File Offset: 0x000BA6E5
	private void MDOLCCMKHCK()
	{
		this.IKABLPHJEBH = 3;
		PopupAvatarCollectionsInput.extraData = -1;
		CommonUserInterface.EHBBFMCILPC.ShowPopupAvatarCollectionsInput(this.GCLOFGOFBBG);
	}

	// Token: 0x06001AEE RID: 6894 RVA: 0x000BC504 File Offset: 0x000BA704
	private void OEBELKGLAEH()
	{
		AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(7);
		this.LAEANFAPAAF();
	}

	// Token: 0x06001AEF RID: 6895 RVA: 0x000BC518 File Offset: 0x000BA718
	private int NMMGPDFMBCO(int KFCMLNPLAHK)
	{
		int num = 0;
		List<GEGBHOMKNDF> list = this.JNFMMJEKNFL(KFCMLNPLAHK);
		if (list != null)
		{
			for (;;)
			{
				bool flag = false;
				for (int i = 1; i < list.Count; i++)
				{
					if (list[i].NFDKDACMHME == this.MEOJCKOJNJJ() && list[i].LIIKAMNPIPM == num)
					{
						flag = false;
						break;
					}
				}
				if (!flag)
				{
					break;
				}
				num++;
			}
		}
		return num;
	}

	// Token: 0x06001AF0 RID: 6896 RVA: 0x000BC578 File Offset: 0x000BA778
	private void NBFPLJNKIAK(string ICHCLOEFLIM, string EOIHFFHPALN)
	{
		if (null == this.avatarCollectionsNotificationAlreadyAdded || null == this.avatarCollectionsNotificationAlreadyAddedTitle)
		{
			return;
		}
		this.LOOPHODOHGM();
		this.KBIBPGOGAAM();
		this.avatarCollectionsNotificationAlreadyAdded.gameObject.SetActive(false);
		this.avatarCollectionsNotificationAlreadyAdded.gameObject.SetActive(true);
		string text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("avatarcollectionsnotifalreadyadded");
		text = text.Replace("XXX", "\"" + DPGJIJGOCIC.PABDHGIJMHJ(ICHCLOEFLIM, 16, "...") + "\"");
		text = text.Replace("YYY", "\"" + DPGJIJGOCIC.PABDHGIJMHJ(EOIHFFHPALN, 16, "...") + "\"");
		this.avatarCollectionsNotificationAlreadyAddedTitle.SetText(text, true);
		this.avatarCollectionsNotificationAlreadyAddedTitle.text = text;
	}

	// Token: 0x06001AF1 RID: 6897 RVA: 0x000BC64C File Offset: 0x000BA84C
	public void Show(List<string> KDIJCJIEGCA, List<string> FEPGEEBECEJ, List<string> PMINLEAMOHE, List<string> FCDBBNHALIG, GameObject OEMHLLBEAKP, bool GPCOCBLFGOL, bool KBGGKKHEMJF, bool FEKNJFMNJGD, bool PCMEHCCFICO)
	{
		this.CGIIOMEMOLI();
		SceneAvatarManager.topPercent = -1;
		this.HOLNOAJDAAA = false;
		this.CDIFMMOJDHA = false;
		this.NLEOIGECPED();
		ApplicationFocusManager.Deactivate();
		if (this.cameraUI2 != null && this.cameraUI2VFXBack != null)
		{
			if (PCMEHCCFICO)
			{
				this.cameraUI2.gameObject.SetActive(false);
				this.cameraUI2VFXBack.gameObject.SetActive(true);
			}
			else
			{
				this.cameraUI2.gameObject.SetActive(true);
				this.cameraUI2VFXBack.gameObject.SetActive(false);
			}
		}
		this.NPDBOIIBOJM = true;
		this.LPBFAGDJKIH = GKJPOGNFKNK.BDEJIINKEHH(AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI);
		if (null == this.LPBFAGDJKIH)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("Show() failed - anthologyHeader is null.");
			return;
		}
		PlayerCharacterManager.SetCurrentAnthologyIndex(this.LPBFAGDJKIH.index);
		this.NDFACHLEJLJ = DHGFCJGJFOB.KPHNADKJHMJ;
		DHGFCJGJFOB.KPHNADKJHMJ = this.LPBFAGDJKIH;
		DHGFCJGJFOB.DFAPCBCDHAO = "";
		DHGFCJGJFOB.NAIGDNDPHNC = "";
		this.DBPFFNEGKDF = FEKNJFMNJGD;
		if (ODJKHCHFKNL.MGFOCBPGJJA() == DFGILFBGPLN.screenStory)
		{
			this.ILOHEHDHLGO();
		}
		this.HLBIEIAFBFK();
		this.JKAFHCIOALE = KBGGKKHEMJF;
		if (GPCOCBLFGOL)
		{
			this.JBEIKNPJGBC = 0;
			this.buttonDiscardHeader.interactable = true;
			this.buttonDiscardPanel.interactable = true;
			this.buttonDiscardPanel.image.color = new Color(1f, 1f, 1f, 1f);
			base.Invoke("KBBPBKJEFCJ", 1f);
		}
		else
		{
			this.JBEIKNPJGBC = this.buttonPositiveOffsetWhenNegativeIsHidden;
			this.buttonDiscardHeader.interactable = false;
			this.buttonDiscardPanel.interactable = false;
			this.buttonDiscardPanel.image.color = new Color(1f, 1f, 1f, 0f);
		}
		this.HCMMNOJFABH = false;
		this.OPLDMEEFKDO(true, false);
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeOut(null);
		this.LADDIEIMNGH = OEMHLLBEAKP;
		base.gameObject.SetActive(true);
		if (null != this.LADDIEIMNGH)
		{
			this.FFHNHAFPEBB = this.LADDIEIMNGH.transform.parent;
			this.OLNGBFLEEFE = this.LADDIEIMNGH.activeSelf;
			this.LADDIEIMNGH.transform.SetParent(this.environmentsPivot.transform, false);
			this.LADDIEIMNGH.SetActive(true);
			this.defaultEnvironment.SetActive(false);
		}
		else if (this.defaultEnvironmentCustomWardrobe != null && this.defaultEnvironmentCustomWardrobe.Count > 1)
		{
			this.defaultEnvironment.SetActive(false);
			this.NFPGMHCGPLM();
		}
		else
		{
			this.defaultEnvironment.SetActive(true);
		}
		this.DHHKIDLPAHE();
		this.GKGKNOOGBDL();
		this.JEPNKHKDOOC();
		this.HDHDFOGGDPI = FEPGEEBECEJ;
		this.LCIBPNMBEHD = KDIJCJIEGCA;
		this.FJFLMGBOKON = PMINLEAMOHE;
		this.AEMFLGKFGCP = FCDBBNHALIG;
		this.OFGGIFEGKGK();
		this.content.SetActive(true);
		this.LCJMIADIKFC(false, false, 1);
		this.NBJKIONNPKP();
		SocialStatsAvatarManager.dataIsReady = false;
		if (ODJKHCHFKNL.MGFOCBPGJJA() == DFGILFBGPLN.screenLobby)
		{
			if (AKLFPGMDKLA.EHBBFMCILPC.JBEPHLFCLEC() && !KDCJJBLGCBH.EHBBFMCILPC.DJHCAFAEILH() && !KDCJJBLGCBH.EHBBFMCILPC.AECCPAKNHIO())
			{
				AKLFPGMDKLA.EHBBFMCILPC.KBKOLEJEEGH();
				bool flag = false;
				if (this.LPBFAGDJKIH.syncWithPrequel && this.LPBFAGDJKIH.prequelIndex >= 0 && this.LPBFAGDJKIH.completedStoryIndexRequirement >= 0)
				{
					flag = true;
				}
				if (!flag)
				{
					BackendOperationsManager.EHBBFMCILPC.RequestGetSocialStatsAvatar(this.LPBFAGDJKIH.index, AKLFPGMDKLA.EHBBFMCILPC.LMGMHHLLOFN(this.LPBFAGDJKIH.index).EFPDNIBOAJG(), SceneAvatarManager.onSocialStatsAvatarScreenSuccess, SceneAvatarManager.onSocialStatsAvatarScreenException);
				}
			}
			if (this.defaultEnvironmentCustomWardrobe != null && this.defaultEnvironmentCustomWardrobe.Count > 1)
			{
				if (null != this.buttonWardrobeLeft)
				{
					this.buttonWardrobeLeft.SetActive(true);
				}
				if (null != this.buttonWardrobeRight)
				{
					this.buttonWardrobeRight.SetActive(true);
				}
			}
		}
		else
		{
			if (null != this.buttonWardrobeLeft)
			{
				this.buttonWardrobeLeft.SetActive(false);
			}
			if (null != this.buttonWardrobeRight)
			{
				this.buttonWardrobeRight.SetActive(false);
			}
		}
		this.CABLKLGBAHA(this.MJKFKHFGNJC());
		if (this.PCJHDKFDOLB() || !this.OIPPNLDGBPG())
		{
			this.DeactivateAvatarCollectionsInterface();
			return;
		}
		this.ResetAvatarCollectionsInterface();
	}

	// Token: 0x06001AF2 RID: 6898 RVA: 0x000BCAA0 File Offset: 0x000BACA0
	private bool HGELFNOKNGO()
	{
		if (ODLJHDIGLGO.HOEABAEGHLG(CLHDENLPOFP.eventPass) == null)
		{
			return true;
		}
		JSONArray jsonarray = AKLFPGMDKLA.EHBBFMCILPC.KKMCNPJNGNL(-56);
		if (jsonarray.Count > 1)
		{
			CommonUserInterface.EHBBFMCILPC.KLEJAGLPCNM(CCOJBMMKNAP.BBGECIKOICE().PKNHKGMNCIP("compr"), (byte)-12);
			BackendOperationsManager.NPDDBAONMJP().FAMKALIFKBD();
			BackendOperationsManager.NPDDBAONMJP().FIPLJKPGNGA();
			BackendOperationsManager.NPDDBAONMJP().PNPNKJNDHNA(jsonarray, SceneAvatarManager.onAvatarCollectionsBackendSyncSuccess, SceneAvatarManager.onAvatarCollectionsBackendSyncException);
			this.CCDJDCMFOLA = false;
			return true;
		}
		if (this.CCDJDCMFOLA)
		{
			this.CCDJDCMFOLA = true;
			CommonUserInterface.IKNOFBFMPGA().KLEJAGLPCNM(CCOJBMMKNAP.HFAKOKBHCGH().PPALCPINPLK(""), 119);
			BackendOperationsManager.NPDDBAONMJP().QueueRequestSaveChapterSnapshots();
			BackendOperationsManager.EHBBFMCILPC.RequestSaveSync(SceneAvatarManager.onAvatarCollectionsBackendSyncSuccess, SceneAvatarManager.onAvatarCollectionsBackendSyncException);
			return true;
		}
		return true;
	}

	// Token: 0x06001AF3 RID: 6899 RVA: 0x000BCB68 File Offset: 0x000BAD68
	private void FGGNEKKBPFM()
	{
		this.KDCIBIABJBK();
		this.FOPNADOFECH.DOKill(false);
		if (this.HACNEIFDKAO != null)
		{
			this.HACNEIFDKAO.Kill(false);
			this.HACNEIFDKAO = null;
		}
		if (this.IEFFJDHGJBO != null)
		{
			this.IEFFJDHGJBO.Kill(false);
			this.IEFFJDHGJBO = null;
		}
	}

	// Token: 0x06001AF4 RID: 6900 RVA: 0x000BCBC0 File Offset: 0x000BADC0
	private void IDNANEBJACO(int MEFKFOHCOHK)
	{
		if (null != this.EBHJLLIHIFE && this.GMOGLALJAOP[MEFKFOHCOHK] != null)
		{
			this.EBHJLLIHIFE.ReleaseSlot(this.GMOGLALJAOP[MEFKFOHCOHK]);
		}
		this.GMOGLALJAOP[MEFKFOHCOHK] = null;
		this.PKKHHJFMFBK[MEFKFOHCOHK] = null;
	}

	// Token: 0x06001AF5 RID: 6901 RVA: 0x000BCC1C File Offset: 0x000BAE1C
	private void BOFONBKMNBP(GameObject JFKDEMMNEGP, bool ILDBACOAHEJ)
	{
		if (null == JFKDEMMNEGP)
		{
			return;
		}
		Graphic component = JFKDEMMNEGP.GetComponent<Graphic>();
		if (null == component)
		{
			return;
		}
		Color color = component.color;
		if (ILDBACOAHEJ)
		{
			color.a = 0.5f;
		}
		else
		{
			color.a = 1f;
		}
		component.color = color;
	}

	// Token: 0x06001AF6 RID: 6902 RVA: 0x000BCC70 File Offset: 0x000BAE70
	private void NLEOIGECPED()
	{
		if (null != this.FPOGOGNGDLE)
		{
			if (null != this.OMHKHHFGEHO)
			{
				this.OMHKHHFGEHO.DOKill(false);
			}
			UnityEngine.Object.Destroy(this.FPOGOGNGDLE);
		}
		this.FPOGOGNGDLE = null;
		this.OMHKHHFGEHO = null;
	}

	// Token: 0x06001AF7 RID: 6903 RVA: 0x000BCCC0 File Offset: 0x000BAEC0
	public void AddFaceToAvatarCollection()
	{
		if (ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass, true) == null)
		{
			FPFNLJGEIJK.FIBNFNACDBE(BGHLMGPPCNN.subAvColl);
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("avatarcollectionssubrequiredtitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("avatarcollectionssubrequired1"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("no"), new UnityAction(this.PMIEIFKANGO), new UnityAction(this.GFMFGEEFCDG), DFGILFBGPLN.popupSignInQuestion, 0f, 28);
			return;
		}
		if (this.KGOAGNFNFIJ.Length > 0)
		{
			if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(64))
			{
				this.BAACKFDMOCI("avatarcollectionstutor1title", "avatarcollectionstutor1body", this.BNODBEAGJMK(this.KGOAGNFNFIJ), new UnityAction(this.NLFKFJICMNE));
				return;
			}
			this.CAAMGFJMPDF();
		}
	}

	// Token: 0x06001AF8 RID: 6904 RVA: 0x000BCD94 File Offset: 0x000BAF94
	private bool PCJHDKFDOLB()
	{
		return (this.LCIBPNMBEHD != null && this.LCIBPNMBEHD.Count > 0) || (this.HDHDFOGGDPI != null && this.HDHDFOGGDPI.Count > 0) || (this.FJFLMGBOKON != null && this.FJFLMGBOKON.Count > 0) || (this.AEMFLGKFGCP != null && this.AEMFLGKFGCP.Count > 0);
	}

	// Token: 0x06001AF9 RID: 6905 RVA: 0x000BCE04 File Offset: 0x000BB004
	private void CHPCJCILKNH()
	{
		try
		{
			if (!this.HOLNOAJDAAA && !(null != this.FPOGOGNGDLE) && this.NPDBOIIBOJM)
			{
				if (this.GMMCDODLDBK() && this.AOMKKLCFBCA(true))
				{
					if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(73))
					{
						if (KDCJJBLGCBH.EHBBFMCILPC == null || !KDCJJBLGCBH.EHBBFMCILPC.INCKJPOBAKM())
						{
							AssetFrameContainer assetFrameContainer = GKJPOGNFKNK.GHCKGGNNMNI(0);
							if (null == assetFrameContainer || !assetFrameContainer.KJMHMOKAHFM() || null == assetFrameContainer.frames[0])
							{
								DPGJIJGOCIC.ADFCDFHBDAF("Swipe tutorial frame container not available, tutorial skipped:" + 0.ToString());
							}
							else if (!(null == this.slidingPanel) && !(null == this.slidingPanel.transform.parent))
							{
								Transform parent = this.slidingPanel.transform.parent;
								this.FPOGOGNGDLE = new GameObject("SwipeTutorial", new Type[]
								{
									typeof(RectTransform)
								});
								this.FPOGOGNGDLE.transform.SetParent(parent, false);
								this.FPOGOGNGDLE.layer = parent.gameObject.layer;
								this.FPOGOGNGDLE.transform.SetAsLastSibling();
								RectTransform component = this.FPOGOGNGDLE.GetComponent<RectTransform>();
								component.anchorMin = new Vector2(0.5f, 0.5f);
								component.anchorMax = new Vector2(0.5f, 0.5f);
								component.pivot = new Vector2(0.5f, 0.5f);
								component.anchoredPosition = Vector2.zero;
								Image image = this.FPOGOGNGDLE.AddComponent<Image>();
								image.raycastTarget = false;
								image.sprite = assetFrameContainer.frames[0];
								image.color = Color.white;
								image.SetNativeSize();
								this.OMHKHHFGEHO = this.FPOGOGNGDLE.AddComponent<CanvasGroup>();
								this.OMHKHHFGEHO.alpha = 0f;
								this.OMHKHHFGEHO.blocksRaycasts = false;
								this.OMHKHHFGEHO.interactable = false;
								ImageFrameAnimation imageFrameAnimation = this.FPOGOGNGDLE.AddComponent<ImageFrameAnimation>();
								imageFrameAnimation.framesSD = assetFrameContainer.frames.ToArray();
								imageFrameAnimation.frameChangeInterval = 0.05f;
								imageFrameAnimation.isLooped = true;
								this.OMHKHHFGEHO.DOFade(1f, 0.35f);
								AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(73);
								DPGJIJGOCIC.NFIDPOMCNLP("Swipe tutorial shown, frames:" + assetFrameContainer.frames.Count.ToString());
							}
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06001AFA RID: 6906 RVA: 0x000BD0AC File Offset: 0x000BB2AC
	private void OHGCGFMHFEB()
	{
		try
		{
			if (!this.HCMMNOJFABH && this.PKKHHJFMFBK.Count != 0)
			{
				CharacterRenderTexturePool.AHLNEABNMOA ahlneabnmoa = this.GMOGLALJAOP[this.PKKHHJFMFBK.Count - 1];
				if (ahlneabnmoa != null && !(null == ahlneabnmoa.AJDMCHIOJAK) && ahlneabnmoa.AJDMCHIOJAK.alpha > 0.99f)
				{
					AssetCustomEffects assetCustomEffects = DHGFCJGJFOB.ONMBOOEBFIB();
					if (null != assetCustomEffects)
					{
						DHGFCJGJFOB.IDNJIDPNFAE(ahlneabnmoa, assetCustomEffects, false);
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06001AFB RID: 6907 RVA: 0x000BD140 File Offset: 0x000BB340
	private void ADHPAMGNHCK(string BCCIHAGLIOH)
	{
		if (this.AJKNDFMMDDO(KFIHMMIGPLO.clothes, this.PLPCLJFJFNG, BCCIHAGLIOH))
		{
			this.MPOCLECLHDE.Clear();
			this.JBBDBBBLOHC.Clear();
			if (this.MKODGAPBOFH)
			{
				this.MPOCLECLHDE.Add(KFIHMMIGPLO.clothes);
				this.JBBDBBBLOHC.Add(this.PLPCLJFJFNG);
				this.IAKIBKAJHHC(GKJPOGNFKNK.DNILNCLIHAP(this.PLPCLJFJFNG, "avatarstitle" + this.LPBFAGDJKIH.CKACBBGHJGI().ToString(), LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), BCCIHAGLIOH);
			}
			else
			{
				this.IMFNIHKNKPM = null;
				this.NBFPLJNKIAK(GKJPOGNFKNK.DNILNCLIHAP(this.PLPCLJFJFNG, "avatarstitle" + this.LPBFAGDJKIH.CKACBBGHJGI().ToString(), LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), BCCIHAGLIOH);
			}
		}
		this.GIICKOCBEMB();
	}

	// Token: 0x06001AFC RID: 6908 RVA: 0x000BD21C File Offset: 0x000BB41C
	public void DestroyUnusedAvatarPackAssets()
	{
		if (null == this.LPBFAGDJKIH)
		{
			return;
		}
		if (ODJKHCHFKNL.MGFOCBPGJJA() == DFGILFBGPLN.screenStory)
		{
			ApplicationFocusManager.Deactivate();
			for (int i = 0; i < this.LPBFAGDJKIH.avatarScreenAvatarPacks.Count; i++)
			{
				if (!AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.AIJLBJLPOLJ(this.LPBFAGDJKIH.avatarScreenAvatarPacks[i], 0) && !this.NJAAOCMPKCD.PHCAGLECBFC(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).DHONIOBOLEL.DDEDAHCFHJN(), this.LPBFAGDJKIH.avatarScreenAvatarPacks[i]) && !AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.IEKMADFOKBP(this.LPBFAGDJKIH.avatarScreenAvatarPacks[i], 0) && !AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FGKCBOGMLCB(this.LPBFAGDJKIH.avatarScreenAvatarPacks[i], 0))
				{
					AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleAvatarPack, this.LPBFAGDJKIH.avatarScreenAvatarPacks[i]);
				}
			}
			for (int j = 0; j < this.LPBFAGDJKIH.avatarScreenAvatarPacks1.Count; j++)
			{
				if (!AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.AIJLBJLPOLJ(this.LPBFAGDJKIH.avatarScreenAvatarPacks1[j], 1) && !this.NJAAOCMPKCD.PHCAGLECBFC(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).DHONIOBOLEL.DDEDAHCFHJN(), this.LPBFAGDJKIH.avatarScreenAvatarPacks1[j]) && !AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.IEKMADFOKBP(this.LPBFAGDJKIH.avatarScreenAvatarPacks1[j], 1) && !AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FGKCBOGMLCB(this.LPBFAGDJKIH.avatarScreenAvatarPacks1[j], 1))
				{
					AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleAvatarPack, this.LPBFAGDJKIH.avatarScreenAvatarPacks1[j]);
				}
			}
			for (int k = 0; k < this.LPBFAGDJKIH.avatarScreenAvatarPacks2.Count; k++)
			{
				if (!AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.AIJLBJLPOLJ(this.LPBFAGDJKIH.avatarScreenAvatarPacks2[k], 2) && !this.NJAAOCMPKCD.PHCAGLECBFC(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).DHONIOBOLEL.DDEDAHCFHJN(), this.LPBFAGDJKIH.avatarScreenAvatarPacks2[k]) && !AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.IEKMADFOKBP(this.LPBFAGDJKIH.avatarScreenAvatarPacks2[k], 2) && !AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FGKCBOGMLCB(this.LPBFAGDJKIH.avatarScreenAvatarPacks2[k], 2))
				{
					AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleAvatarPack, this.LPBFAGDJKIH.avatarScreenAvatarPacks2[k]);
				}
			}
			for (int l = 0; l < AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GNHBHIALAAH.Count; l++)
			{
				if (!AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.IEKMADFOKBP(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GNHBHIALAAH[l], 0) && !AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FGKCBOGMLCB(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GNHBHIALAAH[l], 0) && !this.NJAAOCMPKCD.PHCAGLECBFC(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).DHONIOBOLEL.DDEDAHCFHJN(), AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GNHBHIALAAH[l]) && !this.LPBFAGDJKIH.CCGKCGFCNLL(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GNHBHIALAAH[l], 0) && !this.LPBFAGDJKIH.KJJPBAGCLOI(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GNHBHIALAAH[l], 0))
				{
					AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleAvatarPack, AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GNHBHIALAAH[l]);
					DPGJIJGOCIC.NFIDPOMCNLP("Avatar pack has been destroyed:" + AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GNHBHIALAAH[l].ToString());
				}
				else
				{
					DPGJIJGOCIC.ADFCDFHBDAF("Avatar pack has been kept:" + AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GNHBHIALAAH[l].ToString());
				}
			}
			for (int m = 0; m < AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.JAJJFPNIBGI.Count; m++)
			{
				if (!AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.IEKMADFOKBP(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.JAJJFPNIBGI[m], 1) && !AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FGKCBOGMLCB(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.JAJJFPNIBGI[m], 1) && !this.NJAAOCMPKCD.PHCAGLECBFC(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).DHONIOBOLEL.DDEDAHCFHJN(), AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.JAJJFPNIBGI[m]) && !this.LPBFAGDJKIH.CCGKCGFCNLL(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.JAJJFPNIBGI[m], 1) && !this.LPBFAGDJKIH.KJJPBAGCLOI(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.JAJJFPNIBGI[m], 1))
				{
					AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleAvatarPack, AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.JAJJFPNIBGI[m]);
					DPGJIJGOCIC.NFIDPOMCNLP("Avatar pack has been destroyed:" + AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.JAJJFPNIBGI[m].ToString());
				}
				else
				{
					DPGJIJGOCIC.ADFCDFHBDAF("Avatar pack has been kept:" + AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.JAJJFPNIBGI[m].ToString());
				}
			}
			for (int n = 0; n < AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FCOLLNPADDA.Count; n++)
			{
				if (!AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.IEKMADFOKBP(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FCOLLNPADDA[n], 2) && !AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FGKCBOGMLCB(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FCOLLNPADDA[n], 2) && !this.NJAAOCMPKCD.PHCAGLECBFC(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).DHONIOBOLEL.DDEDAHCFHJN(), AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FCOLLNPADDA[n]) && !this.LPBFAGDJKIH.CCGKCGFCNLL(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FCOLLNPADDA[n], 2) && !this.LPBFAGDJKIH.KJJPBAGCLOI(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FCOLLNPADDA[n], 2))
				{
					AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleAvatarPack, AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FCOLLNPADDA[n]);
					DPGJIJGOCIC.NFIDPOMCNLP("Avatar pack has been destroyed:" + AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FCOLLNPADDA[n].ToString());
				}
				else
				{
					DPGJIJGOCIC.ADFCDFHBDAF("Avatar pack has been kept:" + AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FCOLLNPADDA[n].ToString());
				}
			}
			for (int num = 0; num < this.LPBFAGDJKIH.avatarScreenAvatarExtensionPacks.Count; num++)
			{
				if (!this.NJAAOCMPKCD.MFNODJIFMON(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).DHONIOBOLEL.DDEDAHCFHJN(), this.LPBFAGDJKIH.avatarScreenAvatarExtensionPacks[num]))
				{
					AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleAvatarExtensionPack, this.LPBFAGDJKIH.avatarScreenAvatarExtensionPacks[num]);
				}
			}
		}
		else if (ODJKHCHFKNL.MGFOCBPGJJA() == DFGILFBGPLN.screenLobby)
		{
			ApplicationFocusManager.Activate();
			for (int num2 = 0; num2 < this.LPBFAGDJKIH.avatarScreenAvatarPacks.Count; num2++)
			{
				AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleAvatarPack, this.LPBFAGDJKIH.avatarScreenAvatarPacks[num2]);
			}
			for (int num3 = 0; num3 < this.LPBFAGDJKIH.avatarScreenAvatarPacks1.Count; num3++)
			{
				AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleAvatarPack, this.LPBFAGDJKIH.avatarScreenAvatarPacks1[num3]);
			}
			for (int num4 = 0; num4 < this.LPBFAGDJKIH.avatarScreenAvatarPacks2.Count; num4++)
			{
				AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleAvatarPack, this.LPBFAGDJKIH.avatarScreenAvatarPacks2[num4]);
			}
			for (int num5 = 0; num5 < this.LPBFAGDJKIH.avatarScreenAvatarExtensionPacks.Count; num5++)
			{
				AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleAvatarExtensionPack, this.LPBFAGDJKIH.avatarScreenAvatarExtensionPacks[num5]);
			}
		}
		GC.Collect();
		Resources.UnloadUnusedAssets();
	}

	// Token: 0x06001AFD RID: 6909 RVA: 0x000BDBDC File Offset: 0x000BBDDC
	private void GBHGMDIGCPC()
	{
		this.FJPEKHGINLE(this.avatarCollectionsNotificationAdd);
		this.FJPEKHGINLE(this.avatarCollectionsNotificationUndo);
		this.FJPEKHGINLE(this.avatarCollectionsNotificationAlreadyAdded);
		this.FJPEKHGINLE(this.avatarCollectionsNotificationDeleted);
		this.FJPEKHGINLE(this.avatarCollectionsNotificationSelected);
		this.FJPEKHGINLE(this.avatarCollectionsNotificationUnselected);
	}

	// Token: 0x06001AFE RID: 6910 RVA: 0x000BDC34 File Offset: 0x000BBE34
	private void KDKDNGDDEMH(bool FLGBDJNCAOC = true)
	{
		bool flag = true;
		try
		{
			if (this.JHHKEPGLHKD.Length == 0 && this.KGOAGNFNFIJ.Length == 0 && this.PLPCLJFJFNG.Length == 0 && this.OMGLOJOIOCK.Length == 0 && this.PBOKDNDMCDL.Length == 0 && this.GHALDHOOFKN.Length == 0)
			{
				flag = false;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		if (ODJKHCHFKNL.MGFOCBPGJJA() == DFGILFBGPLN.screenLobby)
		{
			if (flag)
			{
				this.AENHELKPGAH.OHCMCJHDMOH[0] = this.JHHKEPGLHKD;
				this.AENHELKPGAH.OHCMCJHDMOH[3] = this.KGOAGNFNFIJ;
				this.AENHELKPGAH.OHCMCJHDMOH[2] = this.PLPCLJFJFNG;
				this.AENHELKPGAH.OHCMCJHDMOH[1] = this.OMGLOJOIOCK;
				this.AENHELKPGAH.OHCMCJHDMOH[4] = this.PBOKDNDMCDL;
				this.AENHELKPGAH.OHCMCJHDMOH[5] = this.GHALDHOOFKN;
				return;
			}
		}
		else if (ODJKHCHFKNL.MGFOCBPGJJA() == DFGILFBGPLN.screenStory)
		{
			if (flag)
			{
				this.BDFAAGGCOGF.OHCMCJHDMOH[2] = this.PLPCLJFJFNG;
				this.BDFAAGGCOGF.OHCMCJHDMOH[1] = this.OMGLOJOIOCK;
				this.BDFAAGGCOGF.OHCMCJHDMOH[0] = this.JHHKEPGLHKD;
				this.BDFAAGGCOGF.OHCMCJHDMOH[3] = this.KGOAGNFNFIJ;
				this.BDFAAGGCOGF.OHCMCJHDMOH[4] = this.PBOKDNDMCDL;
				this.BDFAAGGCOGF.OHCMCJHDMOH[5] = this.GHALDHOOFKN;
			}
			if (FLGBDJNCAOC)
			{
				this.JMAPFIHFKCA();
			}
		}
	}

	// Token: 0x06001AFF RID: 6911 RVA: 0x000BDDB4 File Offset: 0x000BBFB4
	private void LLMPAPDBHEL()
	{
		this.LPEAMOKELOJ();
	}

	// Token: 0x06001B00 RID: 6912 RVA: 0x000BDDBC File Offset: 0x000BBFBC
	private void FHMLCGJIAMI()
	{
		AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(66);
		this.AGFEGKBBPGL();
	}

	// Token: 0x06001B01 RID: 6913 RVA: 0x000BDDD0 File Offset: 0x000BBFD0
	private void KBIBPGOGAAM()
	{
		if (null != this.storyInterfaceHeaderManager)
		{
			this.storyInterfaceHeaderManager.Hide();
		}
	}

	// Token: 0x06001B02 RID: 6914 RVA: 0x000BDDEC File Offset: 0x000BBFEC
	private CanvasGroup DLKBHNBAJKD(int MEFKFOHCOHK)
	{
		if (this.GMOGLALJAOP[MEFKFOHCOHK] != null)
		{
			return this.GMOGLALJAOP[MEFKFOHCOHK].AJDMCHIOJAK;
		}
		if (null == this.PKKHHJFMFBK[MEFKFOHCOHK])
		{
			return null;
		}
		return this.PKKHHJFMFBK[MEFKFOHCOHK].GetComponent<CanvasGroup>();
	}

	// Token: 0x06001B03 RID: 6915 RVA: 0x000BDE40 File Offset: 0x000BC040
	private void DMEKFCGCGMM()
	{
		AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(67);
		this.MDOLCCMKHCK();
	}

	// Token: 0x06001B04 RID: 6916 RVA: 0x000BDE54 File Offset: 0x000BC054
	private void NJIHCJGLIAM()
	{
		this.HCMMNOJFABH = true;
		for (int i = 0; i < this.PKKHHJFMFBK.Count; i++)
		{
			if (this.GMOGLALJAOP[i] != null)
			{
				if (null != this.GMOGLALJAOP[i].AJDMCHIOJAK && this.GMOGLALJAOP[i].AJDMCHIOJAK.alpha < 1274f && !DOTween.IsTweening(this.GMOGLALJAOP[i].AJDMCHIOJAK, true))
				{
					this.IDNANEBJACO(i);
				}
			}
			else if (null != this.PKKHHJFMFBK[i] && this.PKKHHJFMFBK[i].gameObject.activeSelf && this.PKKHHJFMFBK[i].GetComponent<CanvasGroup>().alpha < 994f && !DOTween.IsTweening(this.PKKHHJFMFBK[i].GetComponent<CanvasGroup>(), false))
			{
				this.PKKHHJFMFBK[i].gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x06001B05 RID: 6917 RVA: 0x000BDF6C File Offset: 0x000BC16C
	private void EDMBLBKNONC()
	{
		if (this.IMFNIHKNKPM == null || this.JBBDBBBLOHC.Count == 0)
		{
			return;
		}
		bool flag = false;
		int num = 1;
		while (num < this.JBBDBBBLOHC.Count && num < this.MPOCLECLHDE.Count)
		{
			if (this.IMFNIHKNKPM.NJHGMFCNGHC(this.MPOCLECLHDE[num], this.JBBDBBBLOHC[num]))
			{
				flag = true;
			}
			num += 0;
		}
		if (flag)
		{
			if (this.IMFNIHKNKPM.OOJIBNEPGIN() == 0)
			{
				this.LMLGIAOCPNJ(this.IMFNIHKNKPM, false);
				this.IMFNIHKNKPM = null;
			}
			else
			{
				if (AKLOMMOOFNG.FNBELOOMKGF(this.IMFNIHKNKPM.FGKDDIJMAMP().ToString(), "Vignette tube scale" + this.IMFNIHKNKPM.NENMEJBNDGJ()) && !AKLFPGMDKLA.EHBBFMCILPC.DLJBBDOEMLO.Contains(this.IMFNIHKNKPM.PLIKGHACBLI()))
				{
					AKLFPGMDKLA.EHBBFMCILPC.DLJBBDOEMLO.Add(this.IMFNIHKNKPM.FOCIIHHNAOG());
				}
				if (this.OBIPBNFKMCC == this.IMFNIHKNKPM)
				{
					this.CKNANNPFALO(false, 0);
				}
			}
		}
		this.MPOCLECLHDE.Clear();
		this.JBBDBBBLOHC.Clear();
		this.IMFNIHKNKPM = null;
		this.LOOPHODOHGM();
		this.KBIBPGOGAAM();
		this.avatarCollectionsNotificationUndo.gameObject.SetActive(false);
		this.avatarCollectionsNotificationUndo.gameObject.SetActive(true);
		string text = CCOJBMMKNAP.OEPENBHJAHO().IKMNGFIDCLM("envlhrw");
		text = text.Replace("ach", "OnPopupPasswordInputEndEdit" + this.BNDFODLCCEF + "energyhinttitle");
		text = text.Replace("AdsManagerLP: There needs to be one active AdsManagerLP script on a GameObject in your scene.", "OnStorySplashManagerAssetsDownloadSuccess" + this.CEFHEGIGMGK + "p");
		this.avatarCollectionsNotificationUndoTitle.SetText(text, true);
		this.avatarCollectionsNotificationUndoTitle.text = text;
	}

	// Token: 0x06001B06 RID: 6918 RVA: 0x000BE133 File Offset: 0x000BC333
	private void KPNPGAJINMI()
	{
		AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(69);
		this.LAEANFAPAAF();
	}

	// Token: 0x06001B07 RID: 6919 RVA: 0x000BE147 File Offset: 0x000BC347
	private void JMPFKHHDDCA()
	{
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC(SceneAvatarManager.onAvatarScreenLeft, 0f);
		base.StartCoroutine(this.MANHBDFGCIH());
	}

	// Token: 0x06001B08 RID: 6920 RVA: 0x000BE16A File Offset: 0x000BC36A
	public void OnFilterHairClick()
	{
		this.LAIAPMIBFCK(KFIHMMIGPLO.hair);
	}

	// Token: 0x06001B09 RID: 6921 RVA: 0x000BE173 File Offset: 0x000BC373
	private float HGPNBLEBAGH()
	{
		if (null != this.LPBFAGDJKIH && this.LPBFAGDJKIH.HGIIJABNDCD(1) != null && this.wardrobeScrollCustomFadeInTime > 0f)
		{
			return this.wardrobeScrollCustomFadeInTime;
		}
		return -1f;
	}

	// Token: 0x06001B0A RID: 6922 RVA: 0x000BE1AC File Offset: 0x000BC3AC
	private string MKFHKAGIFBP(GEGBHOMKNDF MNHNBGKAONP)
	{
		string text = MNHNBGKAONP.BPMFHNDCBOH;
		if (text == null || text.Length == 0)
		{
			List<GEGBHOMKNDF> list = this.JNFMMJEKNFL(MNHNBGKAONP.OIBGFPEGLME);
			int num = 0;
			if (list != null)
			{
				num = list.IndexOf(MNHNBGKAONP) + 1;
			}
			text = num.ToString();
		}
		return text;
	}

	// Token: 0x06001B0B RID: 6923 RVA: 0x000BE1F0 File Offset: 0x000BC3F0
	private void OLEBILDKJLG()
	{
		this.IKABLPHJEBH = 8;
		PopupAvatarCollectionsInput.extraData = -1;
		CommonUserInterface.EHBBFMCILPC.ShowPopupAvatarCollectionsInput(this.GCLOFGOFBBG);
	}

	// Token: 0x06001B0C RID: 6924 RVA: 0x000BE20F File Offset: 0x000BC40F
	private void FBCNBIKBIAE()
	{
		AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(65);
		this.PHIJKKKIHEN();
	}

	// Token: 0x06001B0D RID: 6925 RVA: 0x000BE223 File Offset: 0x000BC423
	private int MEOJCKOJNJJ()
	{
		if (this.AIEEANFPMOO())
		{
			return 0;
		}
		return this.NFDKDACMHME;
	}

	// Token: 0x06001B0E RID: 6926 RVA: 0x000BE238 File Offset: 0x000BC438
	private void OPLDMEEFKDO(bool CHOBEDPLLOG, bool KGGEOFDMJPN = false)
	{
		if (KGGEOFDMJPN)
		{
			if (CHOBEDPLLOG && this.slidingPanelButtonHide.gameObject.activeSelf)
			{
				return;
			}
			if (!CHOBEDPLLOG && this.slidingPanelButtonShow.gameObject.activeSelf)
			{
				return;
			}
		}
		float num = 0f;
		try
		{
			if (NarrowScreenScaler.ScreenIsTooNarrow(850f))
			{
				float num2 = Mathf.Clamp01(Mathf.Clamp01(NBDLBFJOEGN.LAIDCKNIOIN() - 2.25f) / 0.3499999f);
				num = (float)this.slidingPanelTranslationAmountNarrowY * num2;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		if (CHOBEDPLLOG)
		{
			this.KCFHNKOPDBL(true);
			if (null != this.avatarCollectionsFadeManager)
			{
				this.avatarCollectionsFadeManager.Show();
			}
			this.slidingPanelButtonShow.gameObject.SetActive(false);
			this.slidingPanelButtonHide.gameObject.SetActive(true);
			this.slidingPanelButtonHide.interactable = false;
			this.FOPNADOFECH.OGOFACPLOGO((float)((int)this.OIPMEGJLIDC.x), (float)((int)this.OIPMEGJLIDC.y) - num - (float)this.slidingPanelTranslationAmountY * NarrowScreenScaler.CalculateNewScaleUtil(850f, IMBLFHMKMAD.aspectRatio225));
			this.FOPNADOFECH.DOAnchorPos(this.OIPMEGJLIDC, 0.5f, false).SetEase(Ease.OutSine).OnComplete(new TweenCallback(this.DKHPGMJOENF));
			return;
		}
		if (null != this.avatarCollectionsFadeManager)
		{
			this.avatarCollectionsFadeManager.Hide();
		}
		this.slidingPanelButtonShow.gameObject.SetActive(true);
		this.slidingPanelButtonHide.gameObject.SetActive(false);
		this.slidingPanelButtonShow.interactable = false;
		this.FOPNADOFECH.OGOFACPLOGO((int)this.OIPMEGJLIDC.x, (int)this.OIPMEGJLIDC.y);
		this.FOPNADOFECH.DOAnchorPos(this.OIPMEGJLIDC - new Vector2(0f, num + (float)this.slidingPanelTranslationAmountY * NarrowScreenScaler.CalculateNewScaleUtil(850f, IMBLFHMKMAD.aspectRatio225)), 0.5f, false).SetEase(Ease.OutSine).OnComplete(new TweenCallback(this.DDNMMPIJLNK));
	}

	// Token: 0x06001B0F RID: 6927 RVA: 0x000BE44C File Offset: 0x000BC64C
	public void Hide()
	{
		this.NLEOIGECPED();
		if (DHGFCJGJFOB.KPHNADKJHMJ == this.LPBFAGDJKIH)
		{
			DHGFCJGJFOB.KPHNADKJHMJ = this.NDFACHLEJLJ;
		}
		this.NDFACHLEJLJ = null;
		if (null != this.imageEffects)
		{
			this.imageEffects.HideAllEffectsWithTag("");
			this.imageEffects.HideAllEffectsWithTag("blur");
		}
		this.content.SetActive(false);
		base.gameObject.SetActive(false);
	}

	// Token: 0x06001B10 RID: 6928 RVA: 0x000BE4CC File Offset: 0x000BC6CC
	private void HJEJGAHOFOL()
	{
		this.KGOAGNFNFIJ = ">";
		this.JHHKEPGLHKD = "$STOPSFX";
		this.PLPCLJFJFNG = "OnPopupCardOptionsNextClick";
		this.OMGLOJOIOCK = "Starting non-parallel download:";
		this.PBOKDNDMCDL = ">";
		this.GHALDHOOFKN = "skinshopfilterbystory";
	}

	// Token: 0x06001B11 RID: 6929 RVA: 0x000BE51C File Offset: 0x000BC71C
	private void ECNCPOBPHGC()
	{
		this.CABLKLGBAHA(this.AENHELKPGAH);
		this.CABLKLGBAHA(this.BDFAAGGCOGF);
		if (DHGFCJGJFOB.KPHNADKJHMJ == this.LPBFAGDJKIH)
		{
			DHGFCJGJFOB.KPHNADKJHMJ = this.NDFACHLEJLJ;
		}
		this.NDFACHLEJLJ = null;
		this.content.SetActive(false);
		base.gameObject.SetActive(false);
	}

	// Token: 0x06001B12 RID: 6930 RVA: 0x000BE580 File Offset: 0x000BC780
	public void HMBBCKDHEOC()
	{
		if (this.HCMMNOJFABH)
		{
			return;
		}
		this.BIMCBFHNLAP();
		if (ODJKHCHFKNL.BPACMBJPODI() != DFGILFBGPLN.screenHub && null != this.LPBFAGDJKIH)
		{
			EIOPLEFLLIM eioplefllim = AKLFPGMDKLA.EHBBFMCILPC.GJBDBONJCDL(this.LPBFAGDJKIH.index);
			if (eioplefllim != null)
			{
				eioplefllim.OIBGFPEGLME++;
				if (eioplefllim.OIBGFPEGLME > this.defaultEnvironmentCustomWardrobe.Count - 0)
				{
					eioplefllim.OIBGFPEGLME = 0;
				}
				CommonUserInterface.IKNOFBFMPGA().GetFader().FadeInWithCustomFader(this.HGPNBLEBAGH(), new TweenCallback(this.FHMDIKJKKAB));
			}
		}
	}

	// Token: 0x06001B13 RID: 6931 RVA: 0x000BE616 File Offset: 0x000BC816
	private void ABAANDNGAJD()
	{
		this.IKABLPHJEBH = 4;
		PopupAvatarCollectionsInput.extraData = -1;
		CommonUserInterface.EHBBFMCILPC.ShowPopupAvatarCollectionsInput(this.GCLOFGOFBBG);
	}

	// Token: 0x06001B14 RID: 6932 RVA: 0x000BE635 File Offset: 0x000BC835
	private int CHBPAHCHABB(PLFDAJJHMKO BAOKJBJIFBH)
	{
		if (BAOKJBJIFBH != null)
		{
			return BAOKJBJIFBH.POJAPLKAJEF;
		}
		return 10;
	}

	// Token: 0x06001B15 RID: 6933 RVA: 0x000BE644 File Offset: 0x000BC844
	private void CDCAJEIHDKF()
	{
		if (PopupAvatarCollectionsInput.extraData >= 0)
		{
			return;
		}
		if (this.IKABLPHJEBH < 1)
		{
			return;
		}
		int ikablphjebh = this.IKABLPHJEBH;
		this.IKABLPHJEBH = -1;
		string text = DPGJIJGOCIC.HIPPBJFMIKM(AOBJLALDBAA.KKPFOJMAONG().MJPPCFDMCFH());
		if (text == null || text.Length == 0)
		{
			text = CCOJBMMKNAP.HFAKOKBHCGH().PGKBCNBAOJN("id");
		}
		if (text.Length > 80)
		{
			text = text.Substring(1, 2);
		}
		this.GCLOFGOFBBG = text;
		if (ikablphjebh == 0)
		{
			this.GNNJLGAOBDH(text);
			return;
		}
		if (ikablphjebh == 0)
		{
			this.NHCMKODLEOB(text);
			return;
		}
		if (ikablphjebh == 4)
		{
			this.ADHPAMGNHCK(text);
			return;
		}
		if (ikablphjebh == 8)
		{
			this.HOKMHLFKHPK(text);
			return;
		}
		if (ikablphjebh == 7)
		{
			this.MJMOCGBDJGI(text);
		}
	}

	// Token: 0x06001B16 RID: 6934 RVA: 0x000BE6F4 File Offset: 0x000BC8F4
	private int NOEOAPNNCOF(int KFCMLNPLAHK)
	{
		int num = 0;
		List<GEGBHOMKNDF> list = this.JNFMMJEKNFL(KFCMLNPLAHK);
		if (list != null)
		{
			for (;;)
			{
				bool flag = false;
				for (int i = 0; i < list.Count; i += 0)
				{
					if (list[i].NFDKDACMHME == this.MEOJCKOJNJJ() && list[i].LIIKAMNPIPM == num)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					break;
				}
				num++;
			}
		}
		return num;
	}

	// Token: 0x06001B17 RID: 6935 RVA: 0x000BE754 File Offset: 0x000BC954
	private void FHMDIKJKKAB()
	{
		if (!this.OIPPNLDGBPG())
		{
			this.DeactivateAvatarCollectionsInterface();
		}
		else
		{
			this.ResetAvatarCollectionsInterface();
		}
		this.NFPGMHCGPLM();
		this.LKDMBOKHLHG();
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeOutWithCustomFader(this.DLOMPONJAMN(), new TweenCallback(this.ANCNHHADCON));
	}

	// Token: 0x06001B18 RID: 6936 RVA: 0x000BE7A4 File Offset: 0x000BC9A4
	public void PDCGGELGJKM()
	{
		this.OKEMJFMOHML();
		CommonUserInterface.EHBBFMCILPC.FCICLHHAGJD();
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(85))
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverrideWithCloseOverride(CCOJBMMKNAP.LMCCLMFGEBD().OHLNGCKIACD(""), CCOJBMMKNAP.EAIAHCBAIEJ().JLBEIFLLBLO("a"), CCOJBMMKNAP.PEBMGCKFNAO().FCOCLEHKLDJ("Asset bundles "), new UnityAction(this.ICPDPBAKINE), new UnityAction(this.ICPDPBAKINE), (DFGILFBGPLN)(-19), 1029f, -90);
		}
	}

	// Token: 0x06001B19 RID: 6937 RVA: 0x000BE828 File Offset: 0x000BCA28
	private void BNAOKBANHPP()
	{
		if (!this.OIPPNLDGBPG())
		{
			this.JJMGPOOBPEC();
		}
		else
		{
			this.ResetAvatarCollectionsInterface();
		}
		this.NFPGMHCGPLM();
		this.LKDMBOKHLHG();
		CommonUserInterface.IKNOFBFMPGA().GetFader().HAKHLNMPEIN(this.DLOMPONJAMN(), new TweenCallback(this.ANCNHHADCON));
	}

	// Token: 0x06001B1A RID: 6938 RVA: 0x000BE878 File Offset: 0x000BCA78
	private void ACDKICAEHCG()
	{
		if (null == this.avatarCollectionsHeader)
		{
			return;
		}
		GameObject gameObject = this.avatarCollectionsHeaderHiddenUnselected;
		if (this.OBIPBNFKMCC != null)
		{
			gameObject = this.avatarCollectionsHeaderHiddenSelected;
		}
		if (null == gameObject)
		{
			return;
		}
		Image component = this.avatarCollectionsHeader.GetComponent<Image>();
		Image component2 = gameObject.GetComponent<Image>();
		if (null == component || null == component2)
		{
			return;
		}
		component.sprite = component2.sprite;
	}

	// Token: 0x06001B1B RID: 6939 RVA: 0x000BE8E8 File Offset: 0x000BCAE8
	private void OKOGJGPBJDC()
	{
		if (ODJKHCHFKNL.MGFOCBPGJJA() == DFGILFBGPLN.screenLobby)
		{
			this.ECJPDFEHLCO();
			this.NFDKDACMHME = this.IFMCBGGOOEA;
			this.FGGCPAKJKOH = GKJPOGNFKNK.LHEKMIIKFGC(this.AENHELKPGAH.OHCMCJHDMOH[0], KFIHMMIGPLO.body, CFNCBCLEGBC.none, this.NJAAOCMPKCD, this.LPBFAGDJKIH, null, this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.MCGPBKHFJKL());
			this.KFGELOAKHGC = GKJPOGNFKNK.LHEKMIIKFGC(this.AENHELKPGAH.OHCMCJHDMOH[2], KFIHMMIGPLO.clothes, CFNCBCLEGBC.none, this.NJAAOCMPKCD, this.LPBFAGDJKIH, this.CHMCMOHKJOM(), this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.MCGPBKHFJKL());
			this.HFKIIFEHGID = GKJPOGNFKNK.LHEKMIIKFGC(this.AENHELKPGAH.OHCMCJHDMOH[1], KFIHMMIGPLO.hair, CFNCBCLEGBC.none, this.NJAAOCMPKCD, this.LPBFAGDJKIH, this.PGEPFBNCMII(), this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.MCGPBKHFJKL());
			this.IOCLNEFCDNI = GKJPOGNFKNK.LHEKMIIKFGC(this.AENHELKPGAH.OHCMCJHDMOH[3], KFIHMMIGPLO.face, CFNCBCLEGBC.none, this.NJAAOCMPKCD, this.LPBFAGDJKIH, this.JDJLBMMNOPP(), this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.MCGPBKHFJKL());
			this.AIHJMLIDEKJ = GKJPOGNFKNK.LHEKMIIKFGC(this.AENHELKPGAH.OHCMCJHDMOH[4], KFIHMMIGPLO.trinket, CFNCBCLEGBC.none, this.NJAAOCMPKCD, this.LPBFAGDJKIH, this.CMPNMJHBLAL(), this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.MCGPBKHFJKL());
			this.INHNCPCOJEN = GKJPOGNFKNK.LHEKMIIKFGC(this.AENHELKPGAH.OHCMCJHDMOH[5], KFIHMMIGPLO.overlay, CFNCBCLEGBC.none, this.NJAAOCMPKCD, this.LPBFAGDJKIH, this.AEMFLGKFGCP, this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.MCGPBKHFJKL());
		}
		else if (ODJKHCHFKNL.MGFOCBPGJJA() == DFGILFBGPLN.screenStory)
		{
			this.BDFAAGGCOGF = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OHODCBKFNGJ();
			this.NFDKDACMHME = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OJCPKGCLEPD();
			this.NJAAOCMPKCD = GKJPOGNFKNK.CDCEFHLNNEC(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).DHONIOBOLEL.GGICIBLJIKI);
			this.FGGCPAKJKOH = GKJPOGNFKNK.LHEKMIIKFGC(this.BDFAAGGCOGF.OHCMCJHDMOH[0], KFIHMMIGPLO.body, CFNCBCLEGBC.none, this.NJAAOCMPKCD, this.LPBFAGDJKIH, null, this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.MCGPBKHFJKL());
			this.HFKIIFEHGID = GKJPOGNFKNK.LHEKMIIKFGC(this.BDFAAGGCOGF.OHCMCJHDMOH[1], KFIHMMIGPLO.hair, CFNCBCLEGBC.none, this.NJAAOCMPKCD, this.LPBFAGDJKIH, this.PGEPFBNCMII(), this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.MCGPBKHFJKL());
			this.IOCLNEFCDNI = GKJPOGNFKNK.LHEKMIIKFGC(this.BDFAAGGCOGF.OHCMCJHDMOH[3], KFIHMMIGPLO.face, CFNCBCLEGBC.none, this.NJAAOCMPKCD, this.LPBFAGDJKIH, this.JDJLBMMNOPP(), this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.MCGPBKHFJKL());
			this.KFGELOAKHGC = GKJPOGNFKNK.LHEKMIIKFGC(this.BDFAAGGCOGF.OHCMCJHDMOH[2], KFIHMMIGPLO.clothes, CFNCBCLEGBC.none, this.NJAAOCMPKCD, this.LPBFAGDJKIH, this.CHMCMOHKJOM(), this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.MCGPBKHFJKL());
			this.AIHJMLIDEKJ = GKJPOGNFKNK.LHEKMIIKFGC(this.BDFAAGGCOGF.OHCMCJHDMOH[4], KFIHMMIGPLO.trinket, CFNCBCLEGBC.none, this.NJAAOCMPKCD, this.LPBFAGDJKIH, this.CMPNMJHBLAL(), this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.MCGPBKHFJKL());
			this.INHNCPCOJEN = GKJPOGNFKNK.LHEKMIIKFGC(this.BDFAAGGCOGF.OHCMCJHDMOH[5], KFIHMMIGPLO.overlay, CFNCBCLEGBC.none, this.NJAAOCMPKCD, this.LPBFAGDJKIH, this.AEMFLGKFGCP, this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.MCGPBKHFJKL());
		}
		if (null == this.KFGELOAKHGC)
		{
			this.KFGELOAKHGC = GKJPOGNFKNK.LHEKMIIKFGC("", KFIHMMIGPLO.clothes, CFNCBCLEGBC.none, this.NJAAOCMPKCD, this.LPBFAGDJKIH, this.CHMCMOHKJOM(), this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.MCGPBKHFJKL());
		}
		if (null == this.AIHJMLIDEKJ)
		{
			this.AIHJMLIDEKJ = GKJPOGNFKNK.LHEKMIIKFGC("", KFIHMMIGPLO.trinket, CFNCBCLEGBC.none, this.NJAAOCMPKCD, this.LPBFAGDJKIH, this.CMPNMJHBLAL(), this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.MCGPBKHFJKL());
		}
		if (null == this.INHNCPCOJEN)
		{
			this.INHNCPCOJEN = GKJPOGNFKNK.LHEKMIIKFGC("", KFIHMMIGPLO.overlay, CFNCBCLEGBC.none, this.NJAAOCMPKCD, this.LPBFAGDJKIH, this.AEMFLGKFGCP, this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.MCGPBKHFJKL());
		}
		if (null == this.HFKIIFEHGID)
		{
			this.HFKIIFEHGID = GKJPOGNFKNK.LHEKMIIKFGC("", KFIHMMIGPLO.hair, CFNCBCLEGBC.none, this.NJAAOCMPKCD, this.LPBFAGDJKIH, this.PGEPFBNCMII(), this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.MCGPBKHFJKL());
		}
		if (null == this.FGGCPAKJKOH)
		{
			this.FGGCPAKJKOH = GKJPOGNFKNK.LHEKMIIKFGC("", KFIHMMIGPLO.body, CFNCBCLEGBC.none, this.NJAAOCMPKCD, this.LPBFAGDJKIH, null, this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.MCGPBKHFJKL());
		}
		if (null == this.IOCLNEFCDNI)
		{
			this.IOCLNEFCDNI = GKJPOGNFKNK.LHEKMIIKFGC("", KFIHMMIGPLO.face, CFNCBCLEGBC.none, this.NJAAOCMPKCD, this.LPBFAGDJKIH, this.JDJLBMMNOPP(), this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.MCGPBKHFJKL());
		}
		this.filterFaceCountText.SetText(GKJPOGNFKNK.DAHEEOCOJBH(KFIHMMIGPLO.face, this.NJAAOCMPKCD, this.LPBFAGDJKIH, this.JDJLBMMNOPP(), this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.MCGPBKHFJKL()).ToString(), true);
		this.filterHairCountText.SetText(GKJPOGNFKNK.DAHEEOCOJBH(KFIHMMIGPLO.hair, this.NJAAOCMPKCD, this.LPBFAGDJKIH, this.PGEPFBNCMII(), this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.MCGPBKHFJKL()).ToString(), true);
		this.filterClothesCountText.SetText(GKJPOGNFKNK.DAHEEOCOJBH(KFIHMMIGPLO.clothes, this.NJAAOCMPKCD, this.LPBFAGDJKIH, this.CHMCMOHKJOM(), this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.MCGPBKHFJKL()).ToString(), true);
		int num = GKJPOGNFKNK.DAHEEOCOJBH(KFIHMMIGPLO.trinket, this.NJAAOCMPKCD, this.LPBFAGDJKIH, this.CMPNMJHBLAL(), this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.MCGPBKHFJKL()) - 1;
		if (num > 0)
		{
			this.filterTrinketsCountText.SetText(num.ToString(), true);
			return;
		}
		this.filterTrinketsCountText.SetText("", true);
	}

	// Token: 0x06001B1C RID: 6940 RVA: 0x000BEF80 File Offset: 0x000BD180
	private void FJPEKHGINLE(QuietNotificationManager BKKDNELPFOO)
	{
		if (null == BKKDNELPFOO)
		{
			return;
		}
		AvatarCollectionsNotificationDismissOnClick avatarCollectionsNotificationDismissOnClick = BKKDNELPFOO.gameObject.GetComponent<AvatarCollectionsNotificationDismissOnClick>();
		if (null == avatarCollectionsNotificationDismissOnClick)
		{
			avatarCollectionsNotificationDismissOnClick = BKKDNELPFOO.gameObject.AddComponent<AvatarCollectionsNotificationDismissOnClick>();
		}
		avatarCollectionsNotificationDismissOnClick.sceneAvatarManager = this;
	}

	// Token: 0x06001B1D RID: 6941 RVA: 0x000BEFC0 File Offset: 0x000BD1C0
	private void IMPIIDELPIB()
	{
		if (this.BEEEALFJHFG())
		{
			if (null != this.imageEffects)
			{
				this.imageEffects.ODJNJHCNMFG("OnApplicationFocusBasicSyncSuccess");
				this.imageEffects.ODJNJHCNMFG("de");
				return;
			}
		}
		else if (null != this.imageEffects)
		{
			this.imageEffects.MPPOKGDIMMG("_GrainOpacity");
			this.imageEffects.FEFDOKKPLLE("\"");
		}
	}

	// Token: 0x06001B1E RID: 6942 RVA: 0x000BF034 File Offset: 0x000BD234
	private void BIMCBFHNLAP()
	{
		float num = this.HGPNBLEBAGH();
		if (num > 0f)
		{
			AudioManager.EHBBFMCILPC.KillMusic("", num * KDCJJBLGCBH.EHBBFMCILPC.CJOCPJLIILE());
		}
		else
		{
			AudioManager.EHBBFMCILPC.KillMusic("", CommonUserInterface.EHBBFMCILPC.GetFader().GetFadeInDuration());
		}
		this.OPLDMEEFKDO(false, true);
		this.KDKDNGDDEMH(true);
		DOLBFGIPPOG dolbfgippog = this.MJKFKHFGNJC();
		if (dolbfgippog != null)
		{
			dolbfgippog.AOOGOANDIGP = null;
		}
		if (this.LPBFAGDJKIH.HGIIJABNDCD(1) != null)
		{
			CommonUserInterface.EHBBFMCILPC.GetFader().SetCustomFader(GKJPOGNFKNK.PBGGBOADBPJ(this.LPBFAGDJKIH.HGIIJABNDCD(1).assetIndex), this.LPBFAGDJKIH.HGIIJABNDCD(1));
		}
	}

	// Token: 0x06001B1F RID: 6943 RVA: 0x000BF0EC File Offset: 0x000BD2EC
	public AssetAvatarComponent BAKFNKAHIFK(bool PAEDAKPCJDG, KFIHMMIGPLO PBKAAIONJOB)
	{
		switch (PBKAAIONJOB)
		{
		case KFIHMMIGPLO.body:
		{
			AssetAvatarComponent assetAvatarComponent = GKJPOGNFKNK.LHEKMIIKFGC(this.JHHKEPGLHKD, KFIHMMIGPLO.body, CFNCBCLEGBC.none, this.NJAAOCMPKCD, this.LPBFAGDJKIH, null, this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.MCGPBKHFJKL());
			if (PAEDAKPCJDG)
			{
				this.FGGCPAKJKOH = assetAvatarComponent;
				this.HHMHDEPFMBL(this.FGGCPAKJKOH, this.HFKIIFEHGID, this.KFGELOAKHGC, this.IOCLNEFCDNI, this.AIHJMLIDEKJ, this.INHNCPCOJEN, true, 1, false);
			}
			return assetAvatarComponent;
		}
		case KFIHMMIGPLO.hair:
		{
			AssetAvatarComponent assetAvatarComponent = GKJPOGNFKNK.LHEKMIIKFGC(this.OMGLOJOIOCK, KFIHMMIGPLO.body, CFNCBCLEGBC.none, this.NJAAOCMPKCD, this.LPBFAGDJKIH, this.PGEPFBNCMII(), this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.MCGPBKHFJKL());
			if (PAEDAKPCJDG)
			{
				this.HFKIIFEHGID = assetAvatarComponent;
				this.HHMHDEPFMBL(this.FGGCPAKJKOH, this.HFKIIFEHGID, this.KFGELOAKHGC, this.IOCLNEFCDNI, this.AIHJMLIDEKJ, this.INHNCPCOJEN, true, 0, false);
			}
			return assetAvatarComponent;
		}
		case KFIHMMIGPLO.clothes:
		{
			AssetAvatarComponent assetAvatarComponent = GKJPOGNFKNK.LHEKMIIKFGC(this.PLPCLJFJFNG, KFIHMMIGPLO.hair, CFNCBCLEGBC.next, this.NJAAOCMPKCD, this.LPBFAGDJKIH, this.MLKCMFAIHOD(), this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.MCGPBKHFJKL());
			if (PAEDAKPCJDG)
			{
				this.KFGELOAKHGC = assetAvatarComponent;
				this.HHMHDEPFMBL(this.FGGCPAKJKOH, this.HFKIIFEHGID, this.KFGELOAKHGC, this.IOCLNEFCDNI, this.AIHJMLIDEKJ, this.INHNCPCOJEN, true, 0, false);
			}
			return assetAvatarComponent;
		}
		case KFIHMMIGPLO.face:
		{
			AssetAvatarComponent assetAvatarComponent = GKJPOGNFKNK.LHEKMIIKFGC(this.KGOAGNFNFIJ, KFIHMMIGPLO.trinket, CFNCBCLEGBC.none, this.NJAAOCMPKCD, this.LPBFAGDJKIH, this.BHDGICBBEKF(), this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.MCGPBKHFJKL());
			if (PAEDAKPCJDG)
			{
				this.IOCLNEFCDNI = assetAvatarComponent;
				if (null != this.IOCLNEFCDNI && this.IOCLNEFCDNI.parents.Count > 1)
				{
					AssetAvatarComponent assetAvatarComponent2 = GKJPOGNFKNK.LHEKMIIKFGC(this.IOCLNEFCDNI.parents[0], KFIHMMIGPLO.hair, CFNCBCLEGBC.none, this.NJAAOCMPKCD, this.LPBFAGDJKIH, null, this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.MCGPBKHFJKL());
					if (null != assetAvatarComponent2)
					{
						this.FGGCPAKJKOH = assetAvatarComponent2;
					}
				}
				this.HHMHDEPFMBL(this.FGGCPAKJKOH, this.HFKIIFEHGID, this.KFGELOAKHGC, this.IOCLNEFCDNI, this.AIHJMLIDEKJ, this.INHNCPCOJEN, true, 0, true);
			}
			return assetAvatarComponent;
		}
		case KFIHMMIGPLO.trinket:
		{
			AssetAvatarComponent assetAvatarComponent = GKJPOGNFKNK.LHEKMIIKFGC(this.PBOKDNDMCDL, KFIHMMIGPLO.body, CFNCBCLEGBC.next, this.NJAAOCMPKCD, this.LPBFAGDJKIH, this.CKILFGDBPAI(), this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.AHEPDLIMMJD());
			if (PAEDAKPCJDG)
			{
				this.AIHJMLIDEKJ = assetAvatarComponent;
				this.HHMHDEPFMBL(this.FGGCPAKJKOH, this.HFKIIFEHGID, this.KFGELOAKHGC, this.IOCLNEFCDNI, this.AIHJMLIDEKJ, this.INHNCPCOJEN, false, 0, true);
			}
			return assetAvatarComponent;
		}
		case KFIHMMIGPLO.overlay:
		{
			AssetAvatarComponent assetAvatarComponent = GKJPOGNFKNK.LHEKMIIKFGC(this.GHALDHOOFKN, (KFIHMMIGPLO)7, CFNCBCLEGBC.none, this.NJAAOCMPKCD, this.LPBFAGDJKIH, this.AEMFLGKFGCP, this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.AHEPDLIMMJD());
			if (PAEDAKPCJDG)
			{
				this.INHNCPCOJEN = assetAvatarComponent;
				this.HHMHDEPFMBL(this.FGGCPAKJKOH, this.HFKIIFEHGID, this.KFGELOAKHGC, this.IOCLNEFCDNI, this.AIHJMLIDEKJ, this.INHNCPCOJEN, true, -1, true);
			}
			return assetAvatarComponent;
		}
		default:
			return null;
		}
	}

	// Token: 0x06001B20 RID: 6944 RVA: 0x000BF430 File Offset: 0x000BD630
	private int MCGPBKHFJKL()
	{
		if (this.LCOKEPGNEKI != null)
		{
			return this.LCOKEPGNEKI.index;
		}
		return 0;
	}

	// Token: 0x06001B21 RID: 6945 RVA: 0x000BF448 File Offset: 0x000BD648
	private void ENGAPKPIIFL()
	{
		if (this.OBIPBNFKMCC == null)
		{
			return;
		}
		DOLBFGIPPOG dolbfgippog = this.MJKFKHFGNJC();
		if (dolbfgippog == null)
		{
			return;
		}
		JSONArray jsonarray = this.OBIPBNFKMCC.PKIDFPBKPIF(KFIHMMIGPLO.face);
		if (null != jsonarray && this.JHJCOADNIKG != null)
		{
			for (int i = 0; i < jsonarray.Count; i++)
			{
				string text = jsonarray[i].Value;
				if (text != null && text.Length != 0)
				{
					string text2 = null;
					if (text.Contains(";"))
					{
						text2 = text.Substring(text.IndexOf(";") + 1);
						text = text.Substring(0, text.IndexOf(";"));
					}
					if (this.JHJCOADNIKG.Contains(text))
					{
						if (text2 != null && text2.Length > 0)
						{
							if (null == GKJPOGNFKNK.LHEKMIIKFGC(text2, KFIHMMIGPLO.body, CFNCBCLEGBC.none, this.NJAAOCMPKCD, this.LPBFAGDJKIH, null, this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.MCGPBKHFJKL()))
							{
								goto IL_109;
							}
							dolbfgippog.OHCMCJHDMOH[0] = text2;
						}
						dolbfgippog.OHCMCJHDMOH[3] = text;
						break;
					}
				}
				IL_109:;
			}
		}
		string text3 = this.INNGMFOFLHL(KFIHMMIGPLO.hair, this.GPMCPFBGOJA);
		if (text3 != null)
		{
			dolbfgippog.OHCMCJHDMOH[1] = text3;
		}
		string text4 = this.INNGMFOFLHL(KFIHMMIGPLO.clothes, this.OMNBGHBFMAM);
		if (text4 != null)
		{
			dolbfgippog.OHCMCJHDMOH[2] = text4;
		}
		string text5 = this.INNGMFOFLHL(KFIHMMIGPLO.trinket, this.DOENPCEJHJG);
		if (text5 != null)
		{
			dolbfgippog.OHCMCJHDMOH[4] = text5;
		}
	}

	// Token: 0x06001B22 RID: 6946 RVA: 0x000BF5C4 File Offset: 0x000BD7C4
	private bool BEBHIFKOOCK(GEGBHOMKNDF JKEMNKLPHFO)
	{
		if (JKEMNKLPHFO == null)
		{
			return false;
		}
		if (this.AIEEANFPMOO())
		{
			return true;
		}
		if (null != this.LPBFAGDJKIH && this.LPBFAGDJKIH.ignoreAvatarFilterForLobby)
		{
			return true;
		}
		EIOPLEFLLIM eioplefllim = AKLFPGMDKLA.EHBBFMCILPC.GJBDBONJCDL(JKEMNKLPHFO.AMKCLHLIIMN);
		if (eioplefllim == null)
		{
			return false;
		}
		int num = eioplefllim.JIFBEHADGOD(JKEMNKLPHFO.OIBGFPEGLME);
		if (num == JKEMNKLPHFO.NFDKDACMHME)
		{
			return true;
		}
		if (null != this.LPBFAGDJKIH && this.LPBFAGDJKIH.customAvatarFilteringOptions != null)
		{
			for (int i = 0; i < this.LPBFAGDJKIH.customAvatarFilteringOptions.Count; i++)
			{
				if (this.LPBFAGDJKIH.customAvatarFilteringOptions[i].avatarFilter == num && this.LPBFAGDJKIH.customAvatarFilteringOptions[i].applyInsideLobby && this.LPBFAGDJKIH.customAvatarFilteringOptions[i].targetedAvatarFilters != null && this.LPBFAGDJKIH.customAvatarFilteringOptions[i].targetedAvatarFilters.Contains(JKEMNKLPHFO.NFDKDACMHME))
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06001B23 RID: 6947 RVA: 0x000BF6D9 File Offset: 0x000BD8D9
	private List<string> PGEPFBNCMII()
	{
		if (this.GPMCPFBGOJA != null)
		{
			return this.GPMCPFBGOJA;
		}
		return this.HDHDFOGGDPI;
	}

	// Token: 0x06001B24 RID: 6948 RVA: 0x000BF6F0 File Offset: 0x000BD8F0
	private DOLBFGIPPOG MJKFKHFGNJC()
	{
		if (ODJKHCHFKNL.MGFOCBPGJJA() == DFGILFBGPLN.screenLobby)
		{
			return this.AENHELKPGAH;
		}
		if (ODJKHCHFKNL.MGFOCBPGJJA() == DFGILFBGPLN.screenStory)
		{
			return this.BDFAAGGCOGF;
		}
		return null;
	}

	// Token: 0x06001B25 RID: 6949 RVA: 0x000BF714 File Offset: 0x000BD914
	private bool DMKCIHNGMCE()
	{
		int num;
		if (PlayerPrefs.HasKey(""))
		{
			num = PlayerPrefs.GetInt("v");
		}
		else
		{
			num = 0;
		}
		return num != 0 || NBDLBFJOEGN.PBGJNKFFGGO();
	}

	// Token: 0x06001B26 RID: 6950 RVA: 0x000BF74C File Offset: 0x000BD94C
	private void GIICKOCBEMB()
	{
		if (!this.MIFMLOLGCEN)
		{
			return;
		}
		this.MIFMLOLGCEN = false;
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("avatarcollectionsnoroom"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupSignInQuestion, 0.1f, 28);
	}

	// Token: 0x06001B27 RID: 6951 RVA: 0x000BF7AA File Offset: 0x000BD9AA
	private IEnumerator DEMIIEHPNIH()
	{
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(96);
		yield return new WaitForSeconds(0.5f);
		FacebookManager.EHBBFMCILPC.InitializeFacebookManager();
		int num;
		for (int i = 0; i < 6; i = num + 1)
		{
			if (!FacebookManager.EHBBFMCILPC.IsFacebookManagerInitialized())
			{
				yield return new WaitForSeconds(0.5f);
			}
			num = i;
		}
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.ShowSettings(false, this.LPBFAGDJKIH.enablePostEffects, false);
		yield break;
	}

	// Token: 0x06001B28 RID: 6952 RVA: 0x000BF7BC File Offset: 0x000BD9BC
	private void NEBGIAJNCLA()
	{
		try
		{
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			Vector2 vector = Vector2.zero;
			if (Input.touchCount > 0)
			{
				Touch touch = Input.GetTouch(0);
				vector = touch.position;
				if (touch.phase == TouchPhase.Began)
				{
					flag = true;
				}
				else if (touch.phase == TouchPhase.Ended)
				{
					flag2 = true;
				}
				else if (touch.phase == TouchPhase.Canceled)
				{
					flag3 = true;
				}
				if (Input.touchCount > 1)
				{
					flag3 = true;
				}
			}
			else
			{
				vector = Input.mousePosition;
				if (Input.GetMouseButtonDown(0))
				{
					flag = true;
				}
				else if (Input.GetMouseButtonUp(0))
				{
					flag2 = true;
				}
			}
			if (flag3)
			{
				this.CDIFMMOJDHA = false;
			}
			else if (flag)
			{
				this.CDIFMMOJDHA = (this.AOMKKLCFBCA(false) && !this.HGJGDBDFBBK(vector));
				this.GJMOJNPJKGB = vector;
				this.KAAECELIKNM = Time.unscaledTime;
			}
			else if (flag2 && this.CDIFMMOJDHA)
			{
				this.CDIFMMOJDHA = false;
				if (this.AOMKKLCFBCA(true))
				{
					if (Time.unscaledTime - this.KAAECELIKNM <= 0.8f)
					{
						Vector2 vector2 = vector - this.GJMOJNPJKGB;
						if (Mathf.Abs(vector2.x) >= (float)Screen.width * 0.12f)
						{
							if (Mathf.Abs(vector2.x) >= Mathf.Abs(vector2.y) * 1.5f)
							{
								this.KCFHNKOPDBL(true);
								this.AANAAIKPNPC = Time.frameCount;
								if (vector2.x < 0f)
								{
									this.PreviousAssetOfComponentType();
								}
								else
								{
									this.NextAssetOfComponentType();
								}
							}
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06001B29 RID: 6953 RVA: 0x000BF964 File Offset: 0x000BDB64
	private void DKHPGMJOENF()
	{
		this.slidingPanelButtonHide.interactable = true;
	}

	// Token: 0x06001B2A RID: 6954 RVA: 0x000BF974 File Offset: 0x000BDB74
	private void EDMBMPHADBA()
	{
		this.EIACFOPLLPL(this.buttonClearAvatarCollectionFilter, this.OBIPBNFKMCC != null);
		this.EIACFOPLLPL(this.buttonAddFaceToAvatarCollection, this.OBIPBNFKMCC == null);
		this.EIACFOPLLPL(this.buttonAddHairToAvatarCollection, this.OBIPBNFKMCC == null);
		this.EIACFOPLLPL(this.buttonAddClothesToAvatarCollection, this.OBIPBNFKMCC == null);
		this.EIACFOPLLPL(this.buttonAddTrinketToAvatarCollection, this.OBIPBNFKMCC == null);
		this.EIACFOPLLPL(this.buttonAddAllToAvatarCollection, this.OBIPBNFKMCC == null);
		this.BOFONBKMNBP(this.avatarCollectionsPanel, this.OBIPBNFKMCC != null);
		this.BOFONBKMNBP(this.textButtonAddAllToAvatarCollection, this.OBIPBNFKMCC != null);
		if (null != this.buttonSyncAvatarCollection)
		{
			this.buttonSyncAvatarCollection.SetActive(this.OBIPBNFKMCC != null && this.OBIPBNFKMCC.CPIIEEEEEEJ == 0 && this.BEBHIFKOOCK(this.OBIPBNFKMCC));
		}
		this.ACDKICAEHCG();
	}

	// Token: 0x06001B2B RID: 6955 RVA: 0x000BFA6C File Offset: 0x000BDC6C
	public void BKKDLPNOLEE()
	{
		if (ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass, false) == null)
		{
			FPFNLJGEIJK.FIBNFNACDBE(BGHLMGPPCNN.cdnLbyToLng);
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.EAIAHCBAIEJ().OHLNGCKIACD("hacomp2"), CCOJBMMKNAP.GIOAFDDKKHI().PGKBCNBAOJN("a"), CCOJBMMKNAP.EAIAHCBAIEJ().OHLNGCKIACD("ImageBack"), CCOJBMMKNAP.KFDLFGHBPLP().BGELFMIOBCL("$"), new UnityAction(this.PMIEIFKANGO), new UnityAction(this.LEAOOJJMFMJ), (DFGILFBGPLN)114, 1903f, -93);
			return;
		}
		if (this.OMGLOJOIOCK.Length > 1)
		{
			if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(-81))
			{
				this.BAACKFDMOCI("ok", "top", this.BNODBEAGJMK(this.OMGLOJOIOCK), new UnityAction(this.FBCNBIKBIAE));
				return;
			}
			this.PHIJKKKIHEN();
		}
	}

	// Token: 0x06001B2C RID: 6956 RVA: 0x000BFB3F File Offset: 0x000BDD3F
	private void KBBPBKJEFCJ()
	{
		if (null != this.storyInterfaceHeaderManager)
		{
			this.storyInterfaceHeaderManager.Show(0f);
		}
	}

	// Token: 0x06001B2D RID: 6957 RVA: 0x000BFB60 File Offset: 0x000BDD60
	private void ADLBEINKHME()
	{
		if (ODJKHCHFKNL.PPCJPELDBBL() != DFGILFBGPLN.screenPurchasing)
		{
			return;
		}
		if (null != this.cameraUI2 && null != this.cameraUI2VFXBack)
		{
			if (this.DAOONBHLIEM)
			{
				this.cameraUI2VFXBack.gameObject.SetActive(false);
			}
			else
			{
				this.cameraUI2.gameObject.SetActive(false);
			}
		}
		for (int i = 1; i < this.ENJGBKCFEEK.Count; i++)
		{
			if (null != this.ENJGBKCFEEK[i])
			{
				this.ENJGBKCFEEK[i].enabled = true;
			}
		}
		this.ENJGBKCFEEK.Clear();
		if (PassesItem.reopenOnPurchasingScreenLeft)
		{
			this.HBPLGJFPFKM();
		}
	}

	// Token: 0x06001B2E RID: 6958 RVA: 0x000BFC14 File Offset: 0x000BDE14
	public void AddClothesToAvatarCollection()
	{
		if (ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass, true) == null)
		{
			FPFNLJGEIJK.FIBNFNACDBE(BGHLMGPPCNN.subAvColl);
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("avatarcollectionssubrequiredtitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("avatarcollectionssubrequired1"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("no"), new UnityAction(this.PMIEIFKANGO), new UnityAction(this.GFMFGEEFCDG), DFGILFBGPLN.popupSignInQuestion, 0f, 28);
			return;
		}
		if (this.PLPCLJFJFNG.Length > 0)
		{
			if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(66))
			{
				this.BAACKFDMOCI("avatarcollectionstutor3title", "avatarcollectionstutor3body", this.BNODBEAGJMK(this.PLPCLJFJFNG), new UnityAction(this.FHMLCGJIAMI));
				return;
			}
			this.AGFEGKBBPGL();
		}
	}

	// Token: 0x06001B2F RID: 6959 RVA: 0x000BFCE8 File Offset: 0x000BDEE8
	public void CBGPDAPOPIG()
	{
		if (ODLJHDIGLGO.KJIAJJOCMOD(CLHDENLPOFP.gamePass, true) == null)
		{
			FPFNLJGEIJK.FIBNFNACDBE((BGHLMGPPCNN)(-101));
			CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.CEGAOMEEFBE().BDGPNPNIAPA("OnBackendGetDefaultBundlesException"), CCOJBMMKNAP.KNKGCDDMLDP().BGELFMIOBCL("trialmode"), CCOJBMMKNAP.MLFAGAAJJEM().OHLNGCKIACD(""), CCOJBMMKNAP.EAIAHCBAIEJ().DNILNCLIHAP("importanttitle"), new UnityAction(this.JDBIIJAMKDK), new UnityAction(this.GFMFGEEFCDG), DFGILFBGPLN.screenLoadingStory, 1836f, -26);
			return;
		}
		if (this.KGOAGNFNFIJ.Length > 1)
		{
			if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(105))
			{
				this.BAACKFDMOCI("OnApplicationFocusNeedToUpdateCurrency", "OnAvatarCollectionEdit", this.BNODBEAGJMK(this.KGOAGNFNFIJ), new UnityAction(this.NMNABPFCGBI));
				return;
			}
			this.FMHEDLHMGOF();
		}
	}

	// Token: 0x06001B30 RID: 6960 RVA: 0x000BFDBC File Offset: 0x000BDFBC
	private CustomWardrobeSettings ABLMFABKBCA()
	{
		try
		{
			if (null != this.LPBFAGDJKIH && this.LPBFAGDJKIH.HNKINNNFKEO())
			{
				EIOPLEFLLIM eioplefllim = AKLFPGMDKLA.EHBBFMCILPC.GJBDBONJCDL(this.LPBFAGDJKIH.index);
				if (eioplefllim != null && eioplefllim.OIBGFPEGLME < this.LPBFAGDJKIH.customWardrobeSettings.Count)
				{
					return this.LPBFAGDJKIH.customWardrobeSettings[eioplefllim.OIBGFPEGLME];
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return null;
	}

	// Token: 0x06001B31 RID: 6961 RVA: 0x000BFE4C File Offset: 0x000BE04C
	public List<GEGBHOMKNDF> GetAvatarCollectionsForCurrentWardrobe()
	{
		return this.JNFMMJEKNFL(this.MCGPBKHFJKL());
	}

	// Token: 0x06001B32 RID: 6962 RVA: 0x000BFE5C File Offset: 0x000BE05C
	private void FEJPPIMDCEH(bool CMBLHPIHNIE)
	{
		this.HOLNOAJDAAA = false;
		this.CDIFMMOJDHA = true;
		this.KCFHNKOPDBL(true);
		this.OKEMJFMOHML();
		try
		{
			if (ODJKHCHFKNL.ACJAOJAJGKC() != DFGILFBGPLN.screenStory)
			{
				LobbyTopMatchSelectorManager.InitializeInstance();
				if (LobbyTopMatchSelectorManager.BPDPLBFDKDL())
				{
					LobbyTopMatchSelectorManager.MJBDMHPHMID().HCFNNOMIEOB(true);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		if (CMBLHPIHNIE)
		{
			base.StartCoroutine(this.OJFMCMLEJKL(1354f));
			return;
		}
		base.StartCoroutine(this.OJFMCMLEJKL(1979f));
	}

	// Token: 0x06001B33 RID: 6963 RVA: 0x000BFEE4 File Offset: 0x000BE0E4
	private void EIACFOPLLPL(GameObject BBDKMDOBBAD, bool JNHHHLGIHIO)
	{
		if (null == BBDKMDOBBAD)
		{
			return;
		}
		CanvasGroup canvasGroup = BBDKMDOBBAD.GetComponent<CanvasGroup>();
		if (null == canvasGroup)
		{
			canvasGroup = BBDKMDOBBAD.AddComponent<CanvasGroup>();
		}
		if (JNHHHLGIHIO)
		{
			canvasGroup.alpha = 1f;
			canvasGroup.interactable = true;
			canvasGroup.blocksRaycasts = true;
			return;
		}
		canvasGroup.alpha = 1f;
		canvasGroup.interactable = false;
		canvasGroup.blocksRaycasts = false;
	}

	// Token: 0x06001B34 RID: 6964 RVA: 0x000BFF48 File Offset: 0x000BE148
	private void HHKFKDNOFAN(PLFDAJJHMKO BAOKJBJIFBH, EIOPLEFLLIM LNFEBCFCBHG, int KFCMLNPLAHK, int KIDHBAMJGDO)
	{
		if (BAOKJBJIFBH != null)
		{
			if (KFCMLNPLAHK == 0)
			{
				BAOKJBJIFBH.NCAMFPGMCIG.KAKPOCFHGCC = KIDHBAMJGDO;
				return;
			}
			if (KFCMLNPLAHK == 1)
			{
				BAOKJBJIFBH.NCAMFPGMCIG.JFBCFLININB = KIDHBAMJGDO;
				return;
			}
			if (KFCMLNPLAHK == 2)
			{
				BAOKJBJIFBH.NCAMFPGMCIG.GEGFLAPCGAI = KIDHBAMJGDO;
				return;
			}
		}
		else if (LNFEBCFCBHG != null)
		{
			if (KFCMLNPLAHK == 0)
			{
				LNFEBCFCBHG.KAKPOCFHGCC = KIDHBAMJGDO;
				return;
			}
			if (KFCMLNPLAHK == 1)
			{
				LNFEBCFCBHG.JFBCFLININB = KIDHBAMJGDO;
				return;
			}
			if (KFCMLNPLAHK == 2)
			{
				LNFEBCFCBHG.GEGFLAPCGAI = KIDHBAMJGDO;
			}
		}
	}

	// Token: 0x06001B35 RID: 6965 RVA: 0x000BFFB8 File Offset: 0x000BE1B8
	private int KAEJBBIFKLJ(int KFCMLNPLAHK)
	{
		int num = 0;
		List<GEGBHOMKNDF> list = this.JNFMMJEKNFL(KFCMLNPLAHK);
		if (list != null)
		{
			for (;;)
			{
				bool flag = true;
				for (int i = 0; i < list.Count; i++)
				{
					if (list[i].NFDKDACMHME == this.AMGMMJEKIEN() && list[i].LIIKAMNPIPM == num)
					{
						flag = false;
						break;
					}
				}
				if (!flag)
				{
					break;
				}
				num++;
			}
		}
		return num;
	}

	// Token: 0x06001B36 RID: 6966 RVA: 0x0005F01E File Offset: 0x0005D21E
	private void HBPLGJFPFKM()
	{
		CommonUserInterface.EHBBFMCILPC.ShowGamePasses();
	}

	// Token: 0x06001B37 RID: 6967 RVA: 0x000C0018 File Offset: 0x000BE218
	public void DeleteAvatarCollection(GEGBHOMKNDF MNHNBGKAONP, bool KOMIECCDPFE = false)
	{
		if (MNHNBGKAONP == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("SceneAvatarManager.DeleteAvatarCollection(): null == _avatarCollection");
			return;
		}
		string eoihffhpaln = this.MKFHKAGIFBP(MNHNBGKAONP);
		EIOPLEFLLIM eioplefllim = AKLFPGMDKLA.EHBBFMCILPC.GJBDBONJCDL(MNHNBGKAONP.AMKCLHLIIMN);
		PLFDAJJHMKO plfdajjhmko = null;
		if (MNHNBGKAONP.CPIIEEEEEEJ == 0)
		{
			plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1);
		}
		if (eioplefllim == null || (MNHNBGKAONP.CPIIEEEEEEJ == 0 && plfdajjhmko == null))
		{
			DPGJIJGOCIC.ANOPFDLPKGC("SceneAvatarManager.DeleteAvatarCollection(): save not available");
			return;
		}
		List<GEGBHOMKNDF> list = this.JNFMMJEKNFL(MNHNBGKAONP.OIBGFPEGLME);
		if (list != null)
		{
			list.Remove(MNHNBGKAONP);
		}
		List<int> list2 = this.AMPJNPMDBFP(plfdajjhmko, eioplefllim, MNHNBGKAONP.OIBGFPEGLME);
		if (list2 != null)
		{
			list2.Remove(GEGBHOMKNDF.FDLPOILBMNF(MNHNBGKAONP.NFDKDACMHME, MNHNBGKAONP.LIIKAMNPIPM));
		}
		AKLFPGMDKLA.EHBBFMCILPC.DLJBBDOEMLO.Remove(MNHNBGKAONP.NENMEJBNDGJ());
		this.CCDJDCMFOLA = true;
		if (this.OBIPBNFKMCC == MNHNBGKAONP)
		{
			this.ClearAvatarCollectionFilter();
			this.JJAFCPIPKCP(false, 1);
		}
		if (KOMIECCDPFE)
		{
			this.DAFBAEAFAAB(eoihffhpaln);
		}
	}

	// Token: 0x06001B38 RID: 6968 RVA: 0x000C00FE File Offset: 0x000BE2FE
	private void PMIEIFKANGO()
	{
		FPFNLJGEIJK.FANFNCNAKEF();
		this.HBPLGJFPFKM();
	}

	// Token: 0x06001B39 RID: 6969 RVA: 0x000C010C File Offset: 0x000BE30C
	public void GFPEOLBGECB()
	{
		this.OKEMJFMOHML();
		bool oahccinhkjg = this.OBIPBNFKMCC != null;
		this.HOKCEPGPGKH();
		base.StartCoroutine(this.LKJIPGJDGCA(oahccinhkjg));
	}

	// Token: 0x06001B3A RID: 6970 RVA: 0x000C0140 File Offset: 0x000BE340
	public void KJGKIHMLOPP()
	{
		if (ODLJHDIGLGO.AIPKCLIPENE(CLHDENLPOFP.gamePass, true) == null)
		{
			FPFNLJGEIJK.FIBNFNACDBE((BGHLMGPPCNN)(-128));
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.NIOJNOFGIJO().JHNELLJFBGC("$AVATARCONFIG"), CCOJBMMKNAP.DLGLFACMHPG().PPALCPINPLK("no"), CCOJBMMKNAP.KNKGCDDMLDP().JHNELLJFBGC("yes"), CCOJBMMKNAP.DBFFFOMCLKM().PKNHKGMNCIP("emotion"), new UnityAction(this.PMIEIFKANGO), new UnityAction(this.NACGIGFFFHO), (DFGILFBGPLN)(-70), 507f, -104);
			return;
		}
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(97))
		{
			this.BAACKFDMOCI("lsn", "yes", "", new UnityAction(this.ONDMMPKECMM));
			return;
		}
		this.ABAANDNGAJD();
	}

	// Token: 0x06001B3B RID: 6971 RVA: 0x000C0200 File Offset: 0x000BE400
	private void HMFLDHMHFML()
	{
		GEGBHOMKNDF obipbnfkmcc = this.OBIPBNFKMCC;
		if (obipbnfkmcc == null || obipbnfkmcc.CPIIEEEEEEJ != 0)
		{
			return;
		}
		if (!this.BEBHIFKOOCK(obipbnfkmcc))
		{
			return;
		}
		EIOPLEFLLIM eioplefllim = AKLFPGMDKLA.EHBBFMCILPC.GJBDBONJCDL(obipbnfkmcc.AMKCLHLIIMN);
		if (eioplefllim == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("SceneAvatarManager.SyncSelectedAvatarCollectionToAnthology(): anthology save not available");
			return;
		}
		List<int> list = this.AMPJNPMDBFP(null, eioplefllim, obipbnfkmcc.OIBGFPEGLME);
		if (list == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("SceneAvatarManager.SyncSelectedAvatarCollectionToAnthology(): anthology indices list not available");
			return;
		}
		GEGBHOMKNDF gegbhomkndf = null;
		for (int i = 0; i < list.Count; i++)
		{
			if (GEGBHOMKNDF.KNKFAJEPAOM(list[i]) == obipbnfkmcc.NFDKDACMHME)
			{
				try
				{
					string str = GEGBHOMKNDF.NENMEJBNDGJ(1, obipbnfkmcc.AMKCLHLIIMN, obipbnfkmcc.NFDKDACMHME, 10, obipbnfkmcc.OIBGFPEGLME, GEGBHOMKNDF.IHIABMJMDHE(list[i]));
					if (AKLOMMOOFNG.CLCGKMNEICM("Collections/" + str))
					{
						string text = AKLOMMOOFNG.DJGJKOOOFEA("Collections/" + str);
						if (text != null && text.Length != 0)
						{
							JSONObject jsonobject = (JSONObject)JSON.Parse(text);
							if (!(null == jsonobject))
							{
								GEGBHOMKNDF gegbhomkndf2 = new GEGBHOMKNDF();
								gegbhomkndf2.FGJPKGLOGNC(jsonobject);
								if (obipbnfkmcc.BPMFHNDCBOH != null && string.Equals(obipbnfkmcc.BPMFHNDCBOH, gegbhomkndf2.BPMFHNDCBOH, StringComparison.OrdinalIgnoreCase))
								{
									gegbhomkndf = gegbhomkndf2;
									break;
								}
							}
						}
					}
				}
				catch (Exception aklgbjkdomm)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
				}
			}
		}
		bool flag2;
		if (gegbhomkndf == null)
		{
			int num = 0;
			for (;;)
			{
				bool flag = false;
				for (int j = 0; j < list.Count; j++)
				{
					if (GEGBHOMKNDF.KNKFAJEPAOM(list[j]) == obipbnfkmcc.NFDKDACMHME && GEGBHOMKNDF.IHIABMJMDHE(list[j]) == num)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					break;
				}
				num++;
			}
			if (num >= 150)
			{
				this.FEMGGPNGKNK();
				return;
			}
			gegbhomkndf = new GEGBHOMKNDF();
			gegbhomkndf.FGJPKGLOGNC(obipbnfkmcc.BNMFBKNEMIF());
			gegbhomkndf.CPIIEEEEEEJ = 1;
			gegbhomkndf.DLFMMBBLIFH = 10;
			gegbhomkndf.LIIKAMNPIPM = num;
			flag2 = true;
		}
		else
		{
			flag2 = this.GPBPKHCLJMO(obipbnfkmcc, gegbhomkndf);
		}
		if (flag2)
		{
			if (!AKLOMMOOFNG.BIKILBLOEKD(gegbhomkndf.BNMFBKNEMIF().ToString(), "Collections/" + gegbhomkndf.NENMEJBNDGJ()))
			{
				DPGJIJGOCIC.ANOPFDLPKGC("SceneAvatarManager.SyncSelectedAvatarCollectionToAnthology(): collection file write failed");
				this.FEMGGPNGKNK();
				return;
			}
			list.Remove(GEGBHOMKNDF.FDLPOILBMNF(gegbhomkndf.NFDKDACMHME, gegbhomkndf.LIIKAMNPIPM));
			list.Insert(0, GEGBHOMKNDF.FDLPOILBMNF(gegbhomkndf.NFDKDACMHME, gegbhomkndf.LIIKAMNPIPM));
			if (!AKLFPGMDKLA.EHBBFMCILPC.DLJBBDOEMLO.Contains(gegbhomkndf.NENMEJBNDGJ()))
			{
				AKLFPGMDKLA.EHBBFMCILPC.DLJBBDOEMLO.Add(gegbhomkndf.NENMEJBNDGJ());
			}
			this.CCDJDCMFOLA = true;
		}
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("congratstitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("avatarcollectionssyncdone"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("continue"), DFGILFBGPLN.popupSignInQuestion, 0.1f, 28);
	}

	// Token: 0x06001B3C RID: 6972 RVA: 0x000C04E4 File Offset: 0x000BE6E4
	private void CPADABMIIGA()
	{
		if (!NarrowScreenScaler.ScreenIsTooNarrow(960f))
		{
			return;
		}
		float num = Mathf.Clamp01((NBDLBFJOEGN.LAIDCKNIOIN() - 2f) / 0.33299994f);
		this.KKFFOJEPFOL(this.avatarCollectionsPanel, this.avatarCollectionsPanelNarrowOffsetX * num, this.avatarCollectionsPanelNarrowOffsetY * num, Mathf.Lerp(1f, this.avatarCollectionsPanelNarrowDownscale, num));
		this.KKFFOJEPFOL(this.avatarCollectionsButton, this.avatarCollectionsButtonNarrowOffsetX * num, this.avatarCollectionsButtonNarrowOffsetY * num, Mathf.Lerp(1f, this.avatarCollectionsButtonNarrowDownscale, num));
	}

	// Token: 0x06001B3D RID: 6973 RVA: 0x000C0570 File Offset: 0x000BE770
	public void RenameAvatarCollection(GEGBHOMKNDF MNHNBGKAONP, string CBMKDPLMJDN)
	{
		if (MNHNBGKAONP == null || CBMKDPLMJDN == null || CBMKDPLMJDN.Length == 0)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("SceneAvatarManager.RenameAvatarCollection(): invalid collection or title");
			return;
		}
		MNHNBGKAONP.BPMFHNDCBOH = CBMKDPLMJDN;
		if (AKLOMMOOFNG.BIKILBLOEKD(MNHNBGKAONP.BNMFBKNEMIF().ToString(), "Collections/" + MNHNBGKAONP.NENMEJBNDGJ()) && !AKLFPGMDKLA.EHBBFMCILPC.DLJBBDOEMLO.Contains(MNHNBGKAONP.NENMEJBNDGJ()))
		{
			AKLFPGMDKLA.EHBBFMCILPC.DLJBBDOEMLO.Add(MNHNBGKAONP.NENMEJBNDGJ());
		}
		if (this.OBIPBNFKMCC == MNHNBGKAONP)
		{
			this.EAFLMHHPHAD();
		}
	}

	// Token: 0x06001B3E RID: 6974 RVA: 0x000C05FA File Offset: 0x000BE7FA
	private void DJDPMKCBGGA()
	{
		this.IKABLPHJEBH = 0;
		PopupAvatarCollectionsInput.extraData = -1;
		CommonUserInterface.EHBBFMCILPC.ShowPopupAvatarCollectionsInput(this.GCLOFGOFBBG);
	}

	// Token: 0x06001B3F RID: 6975 RVA: 0x000C061C File Offset: 0x000BE81C
	private void IAIIODBDKHK()
	{
		if (ODJKHCHFKNL.LEMILALILKP() != DFGILFBGPLN.screenAvatar)
		{
			return;
		}
		if (null != this.cameraUI2 && null != this.cameraUI2VFXBack)
		{
			if (this.DAOONBHLIEM)
			{
				this.cameraUI2VFXBack.gameObject.SetActive(true);
			}
			else
			{
				this.cameraUI2.gameObject.SetActive(true);
			}
		}
		for (int i = 0; i < this.ENJGBKCFEEK.Count; i++)
		{
			if (null != this.ENJGBKCFEEK[i])
			{
				this.ENJGBKCFEEK[i].enabled = true;
			}
		}
		this.ENJGBKCFEEK.Clear();
		if (PassesItem.reopenOnPurchasingScreenLeft)
		{
			this.HBPLGJFPFKM();
		}
	}

	// Token: 0x06001B40 RID: 6976 RVA: 0x000C06CE File Offset: 0x000BE8CE
	public void UnselectSelectedAvatarCollectionFilter()
	{
		if (this.OBIPBNFKMCC == null)
		{
			return;
		}
		this.ClearAvatarCollectionFilter();
		this.JJAFCPIPKCP(false, -1);
		this.JNOGJAHLCND();
	}

	// Token: 0x06001B41 RID: 6977 RVA: 0x000C06ED File Offset: 0x000BE8ED
	private List<string> MLKCMFAIHOD()
	{
		if (this.OMNBGHBFMAM != null)
		{
			return this.OMNBGHBFMAM;
		}
		return this.LCIBPNMBEHD;
	}

	// Token: 0x06001B42 RID: 6978 RVA: 0x000C0704 File Offset: 0x000BE904
	private bool DBFJFPCKOIJ(CharacterRenderTexturePool.AHLNEABNMOA IGBMMAHEIEK, int FJHJKKIBHBD)
	{
		bool result;
		try
		{
			this.JKCAMKMBEEH = 1f;
			if (IGBMMAHEIEK == null)
			{
				result = false;
			}
			else
			{
				AssetCustomEffects assetCustomEffects = DHGFCJGJFOB.FDABGEGNDFO(null);
				if (null == assetCustomEffects)
				{
					result = false;
				}
				else if (this.PKKHHJFMFBK.Count == 0)
				{
					result = false;
				}
				else
				{
					CharacterRenderTexturePool.AHLNEABNMOA ahlneabnmoa = this.GMOGLALJAOP[this.PKKHHJFMFBK.Count - 1];
					if (ahlneabnmoa == null || ahlneabnmoa == IGBMMAHEIEK || null == ahlneabnmoa.AJDMCHIOJAK || ahlneabnmoa.AJDMCHIOJAK.alpha <= 0.99f)
					{
						result = false;
					}
					else
					{
						float bjopegbaejf = DHGFCJGJFOB.BCIIGJGCAFA(assetCustomEffects);
						if (DHGFCJGJFOB.DCJIOGJAACI(ahlneabnmoa, IGBMMAHEIEK, assetCustomEffects, FJHJKKIBHBD, new TweenCallback(this.MFINPJIGCBH)))
						{
							this.HCMMNOJFABH = true;
							this.BJOPEGBAEJF = bjopegbaejf;
							this.JKCAMKMBEEH = Mathf.Max(assetCustomEffects.animationScaleImpact, 0f);
							result = true;
						}
						else
						{
							result = false;
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x06001B43 RID: 6979 RVA: 0x000C07FC File Offset: 0x000BE9FC
	private void CAAMGFJMPDF()
	{
		this.IKABLPHJEBH = 1;
		PopupAvatarCollectionsInput.extraData = -1;
		CommonUserInterface.EHBBFMCILPC.ShowPopupAvatarCollectionsInput(this.GCLOFGOFBBG);
	}

	// Token: 0x06001B44 RID: 6980 RVA: 0x000C081C File Offset: 0x000BEA1C
	private void FDIJFIAHBPL()
	{
		if (SceneAvatarManager.topPercent > 0 && AKLFPGMDKLA.EHBBFMCILPC.APKDHKHDLHP() && AKLFPGMDKLA.EHBBFMCILPC.JBEPHLFCLEC())
		{
			SocialStatsAvatarManager.dataIsReady = true;
			if (SocialStatsAvatarManager.InstanceInitialized())
			{
				SocialStatsAvatarManager.EHBBFMCILPC.InitializeSocialStats(SceneAvatarManager.topPercent);
				SocialStatsAvatarManager.EHBBFMCILPC.Show();
				return;
			}
		}
		else
		{
			SocialStatsAvatarManager.dataIsReady = false;
		}
	}

	// Token: 0x06001B45 RID: 6981 RVA: 0x000C0876 File Offset: 0x000BEA76
	private void OMJIAFNEGGM(GEGBHOMKNDF MNHNBGKAONP)
	{
		this.JJAFCPIPKCP(true, 1);
		this.FHIEDFLOHOJ(this.MKFHKAGIFBP(MNHNBGKAONP));
	}

	// Token: 0x06001B46 RID: 6982 RVA: 0x000C0890 File Offset: 0x000BEA90
	private List<int> NOKHJEEJLOB(PLFDAJJHMKO BAOKJBJIFBH, EIOPLEFLLIM LNFEBCFCBHG, int KFCMLNPLAHK)
	{
		if (BAOKJBJIFBH != null)
		{
			if (KFCMLNPLAHK == 0)
			{
				return BAOKJBJIFBH.NCAMFPGMCIG.PNBPEAFMKAC;
			}
			if (KFCMLNPLAHK == 1)
			{
				return BAOKJBJIFBH.NCAMFPGMCIG.DMKOGCBMHKA;
			}
			if (KFCMLNPLAHK == 2)
			{
				return BAOKJBJIFBH.NCAMFPGMCIG.NGJDCAEMEJO;
			}
		}
		else if (LNFEBCFCBHG != null)
		{
			if (KFCMLNPLAHK == 0)
			{
				return LNFEBCFCBHG.PNBPEAFMKAC;
			}
			if (KFCMLNPLAHK == 1)
			{
				return LNFEBCFCBHG.DMKOGCBMHKA;
			}
			if (KFCMLNPLAHK == 8)
			{
				return LNFEBCFCBHG.NGJDCAEMEJO;
			}
		}
		return null;
	}

	// Token: 0x06001B47 RID: 6983 RVA: 0x000C08F4 File Offset: 0x000BEAF4
	private void DMLOCJDINOF()
	{
		this.componentDesc.SetText(" to bundle index:", true);
		this.componentTitle.SetText(" scored)", false);
		switch (this.IDIJBMFFCGA)
		{
		case KFIHMMIGPLO.body:
			if (null != this.FGGCPAKJKOH)
			{
				this.componentTitle.SetText(GKJPOGNFKNK.DNILNCLIHAP(this.FGGCPAKJKOH.id, "tdgcds" + this.LPBFAGDJKIH.CKACBBGHJGI().ToString(), LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()), true);
			}
			else
			{
				DPGJIJGOCIC.ANOPFDLPKGC("importanttitle");
			}
			break;
		case KFIHMMIGPLO.hair:
			if (null != this.HFKIIFEHGID)
			{
				this.componentTitle.SetText(GKJPOGNFKNK.DNILNCLIHAP(this.HFKIIFEHGID.id, " (" + this.LPBFAGDJKIH.CKACBBGHJGI().ToString(), LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()), false);
			}
			else
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Asset bundle load operation failed during parallel mode.");
			}
			break;
		case KFIHMMIGPLO.clothes:
			if (null != this.KFGELOAKHGC)
			{
				this.componentTitle.SetText(GKJPOGNFKNK.DNILNCLIHAP(this.KFGELOAKHGC.id, "profilechars" + this.LPBFAGDJKIH.CKACBBGHJGI().ToString(), LanguageManager.EHBBFMCILPC.MLOLBFBODHD()), false);
			}
			else
			{
				DPGJIJGOCIC.ANOPFDLPKGC("аеиоуыэюяьъ");
			}
			break;
		case KFIHMMIGPLO.face:
			if (null != this.IOCLNEFCDNI)
			{
				this.componentTitle.SetText(GKJPOGNFKNK.DNILNCLIHAP(this.IOCLNEFCDNI.id, "ok" + this.LPBFAGDJKIH.CKACBBGHJGI().ToString(), LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()), false);
			}
			else
			{
				DPGJIJGOCIC.ANOPFDLPKGC("OnCaptersSnapshotsGamePassSubscribeNegative");
			}
			break;
		case KFIHMMIGPLO.trinket:
			if (null != this.AIHJMLIDEKJ)
			{
				this.componentTitle.SetText(GKJPOGNFKNK.DNILNCLIHAP(this.AIHJMLIDEKJ.id, "" + this.LPBFAGDJKIH.CKACBBGHJGI().ToString(), LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()), false);
			}
			else
			{
				DPGJIJGOCIC.ANOPFDLPKGC("socialremovetradeable");
			}
			break;
		}
		this.componentDesc.SetText("OnPopupSaveSlotInputEndEdit", false);
		if (null != this.panelButtonPositiveOffset && null != this.panelButtonNegativeOffsets)
		{
			if (this.componentDesc.text.Length == 0)
			{
				this.panelButtonPositiveOffset.LDBJICDAFOB((float)this.JBEIKNPJGBC, (float)this.bottomButtonsOffsetIfNoDescription);
				this.panelButtonNegativeOffsets.BDBDIMGAAKA(397f, (float)this.bottomButtonsOffsetIfNoDescription);
				return;
			}
			this.panelButtonPositiveOffset.SetOffset((float)this.JBEIKNPJGBC, 794f);
			this.panelButtonNegativeOffsets.BOGNPJPGCGP(1161f, 520f);
		}
	}

	// Token: 0x06001B48 RID: 6984 RVA: 0x000C0BD0 File Offset: 0x000BEDD0
	private string BNODBEAGJMK(string IDFPEPDPIMK)
	{
		return GKJPOGNFKNK.DNILNCLIHAP(IDFPEPDPIMK, "avatarstitle" + this.LPBFAGDJKIH.CKACBBGHJGI().ToString(), LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
	}

	// Token: 0x06001B49 RID: 6985 RVA: 0x000C0C0A File Offset: 0x000BEE0A
	public GEGBHOMKNDF OOEAEPLMNBJ()
	{
		return this.OBIPBNFKMCC;
	}

	// Token: 0x06001B4A RID: 6986 RVA: 0x000C0C14 File Offset: 0x000BEE14
	private string INNGMFOFLHL(KFIHMMIGPLO ALOAHOAEHKL, List<string> GNCONPHDBIB)
	{
		if (this.OBIPBNFKMCC == null || GNCONPHDBIB == null)
		{
			return null;
		}
		JSONArray jsonarray = this.OBIPBNFKMCC.PKIDFPBKPIF(ALOAHOAEHKL);
		if (null == jsonarray)
		{
			return null;
		}
		for (int i = 0; i < jsonarray.Count; i++)
		{
			string value = jsonarray[i].Value;
			if (value != null && value.Length > 0 && GNCONPHDBIB.Contains(value))
			{
				return value;
			}
		}
		return null;
	}

	// Token: 0x06001B4B RID: 6987 RVA: 0x000C0C7C File Offset: 0x000BEE7C
	private void MCCDKCGKKFI()
	{
		if (SceneAvatarManager.topPercent > 1 && AKLFPGMDKLA.EHBBFMCILPC.APKDHKHDLHP() && AKLFPGMDKLA.EHBBFMCILPC.JBEPHLFCLEC())
		{
			SocialStatsAvatarManager.dataIsReady = true;
		}
	}

	// Token: 0x06001B4C RID: 6988 RVA: 0x000C0CA4 File Offset: 0x000BEEA4
	private List<string> CMPNMJHBLAL()
	{
		if (this.DOENPCEJHJG != null)
		{
			return this.DOENPCEJHJG;
		}
		return this.FJFLMGBOKON;
	}

	// Token: 0x06001B4D RID: 6989 RVA: 0x000C0CBB File Offset: 0x000BEEBB
	private List<GEGBHOMKNDF> JNFMMJEKNFL(int KFCMLNPLAHK)
	{
		if (KFCMLNPLAHK == 0)
		{
			return this.PKENONODGJK;
		}
		if (KFCMLNPLAHK == 1)
		{
			return this.LBGFDEIBEFO;
		}
		if (KFCMLNPLAHK == 2)
		{
			return this.PEBPGEAGPKN;
		}
		return null;
	}

	// Token: 0x06001B4E RID: 6990 RVA: 0x000C0CE0 File Offset: 0x000BEEE0
	public void KCBNMJDNJEM()
	{
		DOLBFGIPPOG dolbfgippog = this.MJKFKHFGNJC();
		if (dolbfgippog != null && dolbfgippog.AOOGOANDIGP != null)
		{
			int num = 1;
			while (num < dolbfgippog.OHCMCJHDMOH.Length && num < dolbfgippog.AOOGOANDIGP.Length)
			{
				dolbfgippog.OHCMCJHDMOH[num] = dolbfgippog.AOOGOANDIGP[num];
				num++;
			}
			dolbfgippog.AOOGOANDIGP = null;
			this.HOKCEPGPGKH();
		}
		this.OKOGJGPBJDC();
		this.HHMHDEPFMBL(this.FGGCPAKJKOH, this.HFKIIFEHGID, this.KFGELOAKHGC, this.IOCLNEFCDNI, this.AIHJMLIDEKJ, this.INHNCPCOJEN, true, -1, false);
		bool flag = false;
		try
		{
			if (this.JHHKEPGLHKD.Length == 0 && this.KGOAGNFNFIJ.Length == 0 && this.PLPCLJFJFNG.Length == 0 && this.OMGLOJOIOCK.Length == 0 && this.PBOKDNDMCDL.Length == 0 && this.GHALDHOOFKN.Length == 0)
			{
				flag = true;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		if (ODJKHCHFKNL.IAJKCFLOEAJ() == DFGILFBGPLN.screenStory)
		{
			if (flag)
			{
				this.BDFAAGGCOGF.OHCMCJHDMOH[4] = this.PLPCLJFJFNG;
				this.BDFAAGGCOGF.OHCMCJHDMOH[0] = this.OMGLOJOIOCK;
				this.BDFAAGGCOGF.OHCMCJHDMOH[0] = this.JHHKEPGLHKD;
				this.BDFAAGGCOGF.OHCMCJHDMOH[3] = this.KGOAGNFNFIJ;
				this.BDFAAGGCOGF.OHCMCJHDMOH[1] = this.PBOKDNDMCDL;
				this.BDFAAGGCOGF.OHCMCJHDMOH[2] = this.GHALDHOOFKN;
			}
			this.AOLFMHEEBOH();
		}
		AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
		this.FJEFLFPEDOA(true);
		if (null != this.storyInterfaceHeaderManager)
		{
			this.storyInterfaceHeaderManager.Hide();
		}
	}

	// Token: 0x06001B4F RID: 6991 RVA: 0x000C0E88 File Offset: 0x000BF088
	private void EGOLPEEADLJ()
	{
		if (null != this.avatarCollectionsNotificationAdd)
		{
			this.avatarCollectionsNotificationAdd.gameObject.SetActive(false);
		}
		if (null != this.avatarCollectionsNotificationUndo)
		{
			this.avatarCollectionsNotificationUndo.gameObject.SetActive(false);
		}
		if (null != this.avatarCollectionsNotificationAlreadyAdded)
		{
			this.avatarCollectionsNotificationAlreadyAdded.gameObject.SetActive(false);
		}
		if (null != this.avatarCollectionsNotificationDeleted)
		{
			this.avatarCollectionsNotificationDeleted.gameObject.SetActive(false);
		}
		if (null != this.avatarCollectionsNotificationSelected)
		{
			this.avatarCollectionsNotificationSelected.gameObject.SetActive(false);
		}
		if (null != this.avatarCollectionsNotificationUnselected)
		{
			this.avatarCollectionsNotificationUnselected.gameObject.SetActive(false);
		}
	}

	// Token: 0x06001B50 RID: 6992 RVA: 0x000C0F50 File Offset: 0x000BF150
	public void JJCGAFNBBBO()
	{
		this.OKEMJFMOHML();
		bool oahccinhkjg = this.OBIPBNFKMCC != null;
		this.HOKCEPGPGKH();
		base.StartCoroutine(this.FKBEDNLICDM(oahccinhkjg));
	}

	// Token: 0x06001B51 RID: 6993 RVA: 0x000C05FA File Offset: 0x000BE7FA
	private void FMHEDLHMGOF()
	{
		this.IKABLPHJEBH = 0;
		PopupAvatarCollectionsInput.extraData = -1;
		CommonUserInterface.EHBBFMCILPC.ShowPopupAvatarCollectionsInput(this.GCLOFGOFBBG);
	}

	// Token: 0x06001B53 RID: 6995 RVA: 0x000C0FE9 File Offset: 0x000BF1E9
	private void DILPHBIDIPA()
	{
		if (null != this.storyInterfaceHeaderManager)
		{
			this.storyInterfaceHeaderManager.Show(137f);
		}
	}

	// Token: 0x06001B54 RID: 6996 RVA: 0x000C100C File Offset: 0x000BF20C
	private void ANLHHMBINOJ()
	{
		for (int i = 0; i < this.PKKHHJFMFBK.Count; i++)
		{
			if (this.GMOGLALJAOP[i] != null)
			{
				this.IDNANEBJACO(i);
			}
			else if (null != this.PKKHHJFMFBK[i])
			{
				this.PKKHHJFMFBK[i].gameObject.SetActive(false);
				this.PKKHHJFMFBK[i].GetComponent<CanvasGroup>().DOKill(false);
				this.PKKHHJFMFBK[i].GetComponent<RectTransform>().DOKill(false);
				this.PKKHHJFMFBK[i].DOKill(false);
				UnityEngine.Object.Destroy(this.PKKHHJFMFBK[i].gameObject);
			}
		}
		this.PKKHHJFMFBK.Clear();
		this.GMOGLALJAOP.Clear();
	}

	// Token: 0x06001B55 RID: 6997 RVA: 0x000C00FE File Offset: 0x000BE2FE
	private void JDBIIJAMKDK()
	{
		FPFNLJGEIJK.FANFNCNAKEF();
		this.HBPLGJFPFKM();
	}

	// Token: 0x06001B56 RID: 6998 RVA: 0x000C10EC File Offset: 0x000BF2EC
	public void ProcessBackendGetAvatarCollectionsResponse(JSONArray DNDPBCPKPCD)
	{
		if (ODJKHCHFKNL.LEMILALILKP() != DFGILFBGPLN.screenAvatar)
		{
			this.DBLGHLDMFBE = false;
			return;
		}
		if (null == DNDPBCPKPCD)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("SceneAvatarManager.ProcessBackendGetAvatarCollectionsResponse(): null == _backendAvatarCollections");
			return;
		}
		try
		{
			EIOPLEFLLIM lnfebcfcbhg = AKLFPGMDKLA.EHBBFMCILPC.GJBDBONJCDL(this.LPBFAGDJKIH.index);
			PLFDAJJHMKO baokjbjifbh = null;
			if (ODJKHCHFKNL.MGFOCBPGJJA() == DFGILFBGPLN.screenStory)
			{
				baokjbjifbh = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1);
			}
			bool flag = true;
			for (int i = 0; i < DNDPBCPKPCD.Count; i++)
			{
				JSONObject asObject = DNDPBCPKPCD[i].AsObject;
				if (null != asObject)
				{
					if (asObject["ias"] == null || asObject["aind"] == null || asObject["avind"] == null || asObject["sltind"] == null || asObject["wind"] == null || asObject["cind"] == null)
					{
						DPGJIJGOCIC.ANOPFDLPKGC("SceneAvatarManager.ProcessBackendGetAvatarCollectionsResponse(): entry is missing scope fields, skipping");
					}
					else
					{
						GEGBHOMKNDF gegbhomkndf = new GEGBHOMKNDF();
						gegbhomkndf.FGJPKGLOGNC(asObject);
						if (!AKLFPGMDKLA.EHBBFMCILPC.DLJBBDOEMLO.Contains(gegbhomkndf.NENMEJBNDGJ()) && !AKLOMMOOFNG.BIKILBLOEKD(asObject.ToString(), "Collections/" + gegbhomkndf.NENMEJBNDGJ()))
						{
							flag = false;
							DPGJIJGOCIC.ANOPFDLPKGC("SceneAvatarManager.ProcessBackendGetAvatarCollectionsResponse(): failed writing " + gegbhomkndf.NENMEJBNDGJ());
						}
					}
				}
			}
			if (flag)
			{
				this.HHKFKDNOFAN(baokjbjifbh, lnfebcfcbhg, this.MCGPBKHFJKL(), 1);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06001B57 RID: 6999 RVA: 0x000C1298 File Offset: 0x000BF498
	public void AddHairToAvatarCollection()
	{
		if (ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass, true) == null)
		{
			FPFNLJGEIJK.FIBNFNACDBE(BGHLMGPPCNN.subAvColl);
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("avatarcollectionssubrequiredtitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("avatarcollectionssubrequired1"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("no"), new UnityAction(this.PMIEIFKANGO), new UnityAction(this.GFMFGEEFCDG), DFGILFBGPLN.popupSignInQuestion, 0f, 28);
			return;
		}
		if (this.OMGLOJOIOCK.Length > 0)
		{
			if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(65))
			{
				this.BAACKFDMOCI("avatarcollectionstutor2title", "avatarcollectionstutor2body", this.BNODBEAGJMK(this.OMGLOJOIOCK), new UnityAction(this.FBCNBIKBIAE));
				return;
			}
			this.PHIJKKKIHEN();
		}
	}

	// Token: 0x06001B58 RID: 7000 RVA: 0x000C136C File Offset: 0x000BF56C
	private void CDJMNPJOAHB()
	{
		this.KGOAGNFNFIJ = "asf0";
		this.JHHKEPGLHKD = "UpdateGameModeOnOffState";
		this.PLPCLJFJFNG = "_NoiseTex";
		this.OMGLOJOIOCK = "sia";
		this.PBOKDNDMCDL = "Audio asset bundle loading skipped due to low end device specs:";
		this.GHALDHOOFKN = "OnSettingsPopupCloseAndNeedToRestartGame2";
	}

	// Token: 0x06001B59 RID: 7001 RVA: 0x000C13BB File Offset: 0x000BF5BB
	public void KKAAHADMHGB(GEGBHOMKNDF MNHNBGKAONP)
	{
		this.OBIPBNFKMCC = MNHNBGKAONP;
		this.EAFLMHHPHAD();
		this.OHNNDKNICBL(MNHNBGKAONP);
	}

	// Token: 0x06001B5A RID: 7002 RVA: 0x000C13D4 File Offset: 0x000BF5D4
	public void OpenAvatarCollectionsManagementPopup()
	{
		this.OKEMJFMOHML();
		CommonUserInterface.EHBBFMCILPC.ShowAvatarCollectionsItem();
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(71))
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverrideWithCloseOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("avatarcollectionstutor8title"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("avatarcollectionstutor8body"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("continue"), new UnityAction(this.BHHPCAFODMA), new UnityAction(this.BHHPCAFODMA), DFGILFBGPLN.popupSignInQuestion, 0.5f, 28);
		}
	}

	// Token: 0x06001B5B RID: 7003 RVA: 0x000C1458 File Offset: 0x000BF658
	public void AddAllToAvatarCollection()
	{
		if (ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass, true) == null)
		{
			FPFNLJGEIJK.FIBNFNACDBE(BGHLMGPPCNN.subAvColl);
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("avatarcollectionssubrequiredtitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("avatarcollectionssubrequired1"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("no"), new UnityAction(this.PMIEIFKANGO), new UnityAction(this.GFMFGEEFCDG), DFGILFBGPLN.popupSignInQuestion, 0f, 28);
			return;
		}
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(68))
		{
			this.BAACKFDMOCI("avatarcollectionstutor5title", "avatarcollectionstutor5body", "", new UnityAction(this.JPGLBDEPKHM));
			return;
		}
		this.ABAANDNGAJD();
	}

	// Token: 0x06001B5C RID: 7004 RVA: 0x000C1516 File Offset: 0x000BF716
	public void SelectAvatarCollectionFilterFromPopup(GEGBHOMKNDF MNHNBGKAONP)
	{
		this.OBIPBNFKMCC = MNHNBGKAONP;
		this.EAFLMHHPHAD();
		base.StartCoroutine(this.ANGJNNHHALK(MNHNBGKAONP));
	}

	// Token: 0x06001B5D RID: 7005 RVA: 0x000C1533 File Offset: 0x000BF733
	private void ANCNHHADCON()
	{
		if (this.LPBFAGDJKIH.MHJMNIHFFEN())
		{
			CommonUserInterface.EHBBFMCILPC.GetFader().SetCustomFader(null, null);
		}
	}

	// Token: 0x06001B5E RID: 7006 RVA: 0x000C1554 File Offset: 0x000BF754
	private List<int> GKGLHNACFNE()
	{
		List<int> list = new List<int>();
		list.Add(this.MEOJCKOJNJJ());
		if (!this.AIEEANFPMOO() && null != this.LPBFAGDJKIH && this.LPBFAGDJKIH.customAvatarFilteringOptions != null)
		{
			for (int i = 0; i < this.LPBFAGDJKIH.customAvatarFilteringOptions.Count; i++)
			{
				if (this.LPBFAGDJKIH.customAvatarFilteringOptions[i].avatarFilter == this.NFDKDACMHME && ((null != this.NJAAOCMPKCD && this.LPBFAGDJKIH.customAvatarFilteringOptions[i].applyInsideStory) || (null == this.NJAAOCMPKCD && this.LPBFAGDJKIH.customAvatarFilteringOptions[i].applyInsideLobby)) && this.LPBFAGDJKIH.customAvatarFilteringOptions[i].targetedAvatarFilters != null)
				{
					for (int j = 0; j < this.LPBFAGDJKIH.customAvatarFilteringOptions[i].targetedAvatarFilters.Count; j++)
					{
						if (!list.Contains(this.LPBFAGDJKIH.customAvatarFilteringOptions[i].targetedAvatarFilters[j]))
						{
							list.Add(this.LPBFAGDJKIH.customAvatarFilteringOptions[i].targetedAvatarFilters[j]);
						}
					}
				}
			}
		}
		return list;
	}

	// Token: 0x06001B5F RID: 7007 RVA: 0x000C16B8 File Offset: 0x000BF8B8
	private void DDFEHCKPBHD(string EOIHFFHPALN)
	{
		if (null == this.avatarCollectionsNotificationDeleted || null == this.avatarCollectionsNotificationDeletedTitle)
		{
			return;
		}
		this.LOOPHODOHGM();
		this.KBIBPGOGAAM();
		this.avatarCollectionsNotificationDeleted.gameObject.SetActive(true);
		this.avatarCollectionsNotificationDeleted.gameObject.SetActive(false);
		string text = CCOJBMMKNAP.CEGAOMEEFBE().HHLECNIFHCO("favcut");
		text = text.Replace("OnPopupProfileUIDInputCancel", "face" + DPGJIJGOCIC.PABDHGIJMHJ(EOIHFFHPALN, -62, "Bars count") + "XXX");
		this.avatarCollectionsNotificationDeletedTitle.SetText(text, false);
		this.avatarCollectionsNotificationDeletedTitle.text = text;
	}

	// Token: 0x06001B60 RID: 7008 RVA: 0x000C1764 File Offset: 0x000BF964
	private void FEMGGPNGKNK()
	{
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("avatarcollectionssyncfull"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupSignInQuestion, 0.1f, 28);
	}

	// Token: 0x06001B61 RID: 7009 RVA: 0x000C17B4 File Offset: 0x000BF9B4
	private void LPEAMOKELOJ()
	{
		this.componentDesc.SetText("", true);
		this.componentTitle.SetText("", true);
		switch (this.IDIJBMFFCGA)
		{
		case KFIHMMIGPLO.body:
			if (null != this.FGGCPAKJKOH)
			{
				this.componentTitle.SetText(GKJPOGNFKNK.DNILNCLIHAP(this.FGGCPAKJKOH.id, "avatarstitle" + this.LPBFAGDJKIH.CKACBBGHJGI().ToString(), LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), true);
			}
			else
			{
				DPGJIJGOCIC.ANOPFDLPKGC("UpdateComponentTitleDesc() failed - AssetAvatarComponentType.body is null.");
			}
			break;
		case KFIHMMIGPLO.hair:
			if (null != this.HFKIIFEHGID)
			{
				this.componentTitle.SetText(GKJPOGNFKNK.DNILNCLIHAP(this.HFKIIFEHGID.id, "avatarstitle" + this.LPBFAGDJKIH.CKACBBGHJGI().ToString(), LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), true);
			}
			else
			{
				DPGJIJGOCIC.ANOPFDLPKGC("UpdateComponentTitleDesc() failed - AssetAvatarComponentType.hair is null.");
			}
			break;
		case KFIHMMIGPLO.clothes:
			if (null != this.KFGELOAKHGC)
			{
				this.componentTitle.SetText(GKJPOGNFKNK.DNILNCLIHAP(this.KFGELOAKHGC.id, "avatarstitle" + this.LPBFAGDJKIH.CKACBBGHJGI().ToString(), LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), true);
			}
			else
			{
				DPGJIJGOCIC.ANOPFDLPKGC("UpdateComponentTitleDesc() failed - AssetAvatarComponentType.clothes is null.");
			}
			break;
		case KFIHMMIGPLO.face:
			if (null != this.IOCLNEFCDNI)
			{
				this.componentTitle.SetText(GKJPOGNFKNK.DNILNCLIHAP(this.IOCLNEFCDNI.id, "avatarstitle" + this.LPBFAGDJKIH.CKACBBGHJGI().ToString(), LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), true);
			}
			else
			{
				DPGJIJGOCIC.ANOPFDLPKGC("UpdateComponentTitleDesc() failed - AssetAvatarComponentType.face is null.");
			}
			break;
		case KFIHMMIGPLO.trinket:
			if (null != this.AIHJMLIDEKJ)
			{
				this.componentTitle.SetText(GKJPOGNFKNK.DNILNCLIHAP(this.AIHJMLIDEKJ.id, "avatarstitle" + this.LPBFAGDJKIH.CKACBBGHJGI().ToString(), LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), true);
			}
			else
			{
				DPGJIJGOCIC.ANOPFDLPKGC("UpdateComponentTitleDesc() failed - AssetAvatarComponentType.trinket is null.");
			}
			break;
		}
		this.componentDesc.SetText("", true);
		if (null != this.panelButtonPositiveOffset && null != this.panelButtonNegativeOffsets)
		{
			if (this.componentDesc.text.Length == 0)
			{
				this.panelButtonPositiveOffset.SetOffset((float)this.JBEIKNPJGBC, (float)this.bottomButtonsOffsetIfNoDescription);
				this.panelButtonNegativeOffsets.SetOffset(0f, (float)this.bottomButtonsOffsetIfNoDescription);
				return;
			}
			this.panelButtonPositiveOffset.SetOffset((float)this.JBEIKNPJGBC, 0f);
			this.panelButtonNegativeOffsets.SetOffset(0f, 0f);
		}
	}

	// Token: 0x06001B62 RID: 7010 RVA: 0x000BF7AA File Offset: 0x000BD9AA
	private IEnumerator BGIFMFHNMBI()
	{
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(96);
		yield return new WaitForSeconds(0.5f);
		FacebookManager.EHBBFMCILPC.InitializeFacebookManager();
		int num;
		for (i = 0; i < 6; i = num + 1)
		{
			if (!FacebookManager.EHBBFMCILPC.IsFacebookManagerInitialized())
			{
				yield return new WaitForSeconds(0.5f);
			}
			num = i;
		}
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.ShowSettings(false, this.LPBFAGDJKIH.enablePostEffects, false);
		yield break;
	}

	// Token: 0x06001B63 RID: 7011 RVA: 0x000C1A90 File Offset: 0x000BFC90
	private void KFGPOOAJJBJ(bool BMKLNILMGAG, int FJHJKKIBHBD, AssetAvatarComponent BHJJLJJACFE, AssetAvatarComponent CKEPDOEPKCA, AssetAvatarComponent KMEDBGBKABG, AssetAvatarComponent JKCCFILIICG, AssetAvatarComponent GIEOBIFBPPF, AssetAvatarComponent PHDIGHLMIKL, EBFHKCOGJLB AIAAMALDKHG)
	{
		CharacterRenderTexturePool.AHLNEABNMOA ahlneabnmoa = this.OELALBBMILL();
		try
		{
			this.IFAFJAOJEJC(ahlneabnmoa, BMKLNILMGAG, FJHJKKIBHBD, BHJJLJJACFE, CKEPDOEPKCA, KMEDBGBKABG, JKCCFILIICG, GIEOBIFBPPF, PHDIGHLMIKL, AIAAMALDKHG);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			if (null != this.EBHJLLIHIFE && ahlneabnmoa != null && !this.GMOGLALJAOP.Contains(ahlneabnmoa))
			{
				this.EBHJLLIHIFE.ReleaseSlot(ahlneabnmoa);
			}
			throw;
		}
	}

	// Token: 0x06001B64 RID: 7012 RVA: 0x000C1B00 File Offset: 0x000BFD00
	public void HideAvatarCollectionsInterface()
	{
		if (null == this.avatarCollectionsButton || null == this.avatarCollectionsPanel)
		{
			return;
		}
		this.avatarCollectionsButton.SetActive(true);
		this.avatarCollectionsPanel.SetActive(false);
		this.FOLKEPENPML(false);
	}

	// Token: 0x06001B65 RID: 7013 RVA: 0x000C1B3E File Offset: 0x000BFD3E
	public void JJMGPOOBPEC()
	{
		if (null != this.avatarCollectionsButton && null != this.avatarCollectionsPanel)
		{
			this.avatarCollectionsButton.SetActive(true);
			this.avatarCollectionsPanel.SetActive(false);
			this.FOLKEPENPML(true);
		}
	}

	// Token: 0x06001B66 RID: 7014 RVA: 0x000C1B7B File Offset: 0x000BFD7B
	private void OHNNDKNICBL(GEGBHOMKNDF MNHNBGKAONP)
	{
		this.JJAFCPIPKCP(true, 1);
		this.ABLDIKHBDNM(this.GJKMBGFHDKH(MNHNBGKAONP));
	}

	// Token: 0x06001B67 RID: 7015 RVA: 0x00003E52 File Offset: 0x00002052
	private void DIKLHMMGALB()
	{
	}

	// Token: 0x06001B68 RID: 7016 RVA: 0x00003E52 File Offset: 0x00002052
	private void EFHBBBIPELI()
	{
	}

	// Token: 0x06001B69 RID: 7017 RVA: 0x000C1B94 File Offset: 0x000BFD94
	private int COLIIPCGCAG(PLFDAJJHMKO BAOKJBJIFBH, EIOPLEFLLIM LNFEBCFCBHG, int KFCMLNPLAHK)
	{
		if (BAOKJBJIFBH != null)
		{
			if (KFCMLNPLAHK == 0)
			{
				return BAOKJBJIFBH.NCAMFPGMCIG.KAKPOCFHGCC;
			}
			if (KFCMLNPLAHK == 1)
			{
				return BAOKJBJIFBH.NCAMFPGMCIG.JFBCFLININB;
			}
			if (KFCMLNPLAHK == 2)
			{
				return BAOKJBJIFBH.NCAMFPGMCIG.GEGFLAPCGAI;
			}
		}
		else if (LNFEBCFCBHG != null)
		{
			if (KFCMLNPLAHK == 0)
			{
				return LNFEBCFCBHG.KAKPOCFHGCC;
			}
			if (KFCMLNPLAHK == 1)
			{
				return LNFEBCFCBHG.JFBCFLININB;
			}
			if (KFCMLNPLAHK == 2)
			{
				return LNFEBCFCBHG.GEGFLAPCGAI;
			}
		}
		return 1;
	}

	// Token: 0x06001B6A RID: 7018 RVA: 0x000C1BF8 File Offset: 0x000BFDF8
	private void JNOGJAHLCND()
	{
		if (null == this.avatarCollectionsNotificationUnselected || null == this.avatarCollectionsNotificationUnselectedTitle)
		{
			return;
		}
		this.LOOPHODOHGM();
		this.KBIBPGOGAAM();
		this.avatarCollectionsNotificationUnselected.gameObject.SetActive(false);
		this.avatarCollectionsNotificationUnselected.gameObject.SetActive(true);
		string text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("avatarcollectionsnotifunselected");
		this.avatarCollectionsNotificationUnselectedTitle.SetText(text, true);
		this.avatarCollectionsNotificationUnselectedTitle.text = text;
	}

	// Token: 0x06001B6B RID: 7019 RVA: 0x000C1C7C File Offset: 0x000BFE7C
	public void LMLGIAOCPNJ(GEGBHOMKNDF MNHNBGKAONP, bool KOMIECCDPFE = false)
	{
		if (MNHNBGKAONP == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("teal");
			return;
		}
		string eoihffhpaln = this.MKFHKAGIFBP(MNHNBGKAONP);
		EIOPLEFLLIM eioplefllim = AKLFPGMDKLA.EHBBFMCILPC.AMAMNOFLPGM(MNHNBGKAONP.AMKCLHLIIMN);
		PLFDAJJHMKO plfdajjhmko = null;
		if (MNHNBGKAONP.CPIIEEEEEEJ == 0)
		{
			plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1);
		}
		if (eioplefllim == null || (MNHNBGKAONP.CPIIEEEEEEJ == 0 && plfdajjhmko == null))
		{
			DPGJIJGOCIC.ANOPFDLPKGC("loungechoosetitle");
			return;
		}
		List<GEGBHOMKNDF> list = this.JNFMMJEKNFL(MNHNBGKAONP.OIBGFPEGLME);
		if (list != null)
		{
			list.Remove(MNHNBGKAONP);
		}
		List<int> list2 = this.AMPJNPMDBFP(plfdajjhmko, eioplefllim, MNHNBGKAONP.OIBGFPEGLME);
		if (list2 != null)
		{
			list2.Remove(GEGBHOMKNDF.GAPELMEPKBD(MNHNBGKAONP.NFDKDACMHME, MNHNBGKAONP.LIIKAMNPIPM));
		}
		AKLFPGMDKLA.EHBBFMCILPC.DLJBBDOEMLO.Remove(MNHNBGKAONP.PLIKGHACBLI());
		this.CCDJDCMFOLA = true;
		if (this.OBIPBNFKMCC == MNHNBGKAONP)
		{
			this.HOKCEPGPGKH();
			this.JJAFCPIPKCP(false, 0);
		}
		if (KOMIECCDPFE)
		{
			this.DDFEHCKPBHD(eoihffhpaln);
		}
	}

	// Token: 0x06001B6C RID: 7020 RVA: 0x000C1D64 File Offset: 0x000BFF64
	public void PNKCOHCKDKJ()
	{
		this.OKEMJFMOHML();
		bool oahccinhkjg = this.OBIPBNFKMCC != null;
		this.ClearAvatarCollectionFilter();
		base.StartCoroutine(this.FKBEDNLICDM(oahccinhkjg));
	}

	// Token: 0x06001B6D RID: 7021 RVA: 0x000C1D98 File Offset: 0x000BFF98
	private void FIIMDIKHIHG()
	{
		ODJKHCHFKNL.KJCJKFBCPFK(DFGILFBGPLN.screenPurchasing);
		AOBJLALDBAA.EHBBFMCILPC.EFKNEJFLGED("#", new UnityAction(this.LLMPAPDBHEL));
		AOBJLALDBAA.DBLAIDPICIG().FNMOFCMDFJP("$e1jp", new UnityAction(this.HLBIEIAFBFK));
		AOBJLALDBAA.AGANFKKBPFO().GNBGEMMDGOJ("OnStoryCurrencyInfoClick", new UnityAction(this.ECNCPOBPHGC));
		AOBJLALDBAA.DBLAIDPICIG().FNMOFCMDFJP("", new UnityAction(this.LLNENMOMNKP));
		AOBJLALDBAA.KKPFOJMAONG().MFIMALJPCDP("〉", new UnityAction(this.NFCDJBPAFEI));
		AOBJLALDBAA.KKPFOJMAONG().PEFKJOKLEDL(SceneAvatarManager.onSocialStatsAvatarScreenSuccess, new UnityAction(this.FDIJFIAHBPL));
		AOBJLALDBAA.AGANFKKBPFO().EFKNEJFLGED(SceneAvatarManager.onSocialStatsAvatarScreenException, new UnityAction(this.KMCGCJPEJKO));
		AOBJLALDBAA.EHBBFMCILPC.PEFKJOKLEDL(SceneAvatarManager.onAvatarCollectionsBackendFetchSuccess, new UnityAction(this.DKODFAGILIC));
		AOBJLALDBAA.BIAEAOMHBMM().PEFKJOKLEDL(SceneAvatarManager.onAvatarCollectionsBackendFetchException, new UnityAction(this.JFCKJMMONBG));
		AOBJLALDBAA.KKPFOJMAONG().FNMOFCMDFJP(SceneAvatarManager.onAvatarCollectionsBackendSyncSuccess, new UnityAction(this.BJDKLCHEPEN));
		AOBJLALDBAA.DBLAIDPICIG().GNBGEMMDGOJ(SceneAvatarManager.onAvatarCollectionsBackendSyncException, new UnityAction(this.DJGDOHHKEDO));
		AOBJLALDBAA.DBLAIDPICIG().PEFKJOKLEDL("<size=80%><i>", new UnityAction(this.OnSocialModeChanged));
		AOBJLALDBAA.AGANFKKBPFO().FNMOFCMDFJP("OnChapterSnapshotRestoreExecute", new UnityAction(this.CDCAJEIHDKF));
		AOBJLALDBAA.FILDBDMENPG().PEFKJOKLEDL(" scenario=", new UnityAction(this.IKFCLPAMPCD));
		AOBJLALDBAA.DBLAIDPICIG().BADOPKAOCPE("skinshopinfotimeddiscount", new UnityAction(this.LMJGOIINBIC));
		AOBJLALDBAA.EHBBFMCILPC.FNMOFCMDFJP("trope", new UnityAction(this.IAIIODBDKHK));
	}

	// Token: 0x06001B6E RID: 7022 RVA: 0x000C1F5C File Offset: 0x000C015C
	public void AddTrinketToAvatarCollection()
	{
		if (ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass, true) == null)
		{
			FPFNLJGEIJK.FIBNFNACDBE(BGHLMGPPCNN.subAvColl);
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("avatarcollectionssubrequiredtitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("avatarcollectionssubrequired1"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("no"), new UnityAction(this.PMIEIFKANGO), new UnityAction(this.GFMFGEEFCDG), DFGILFBGPLN.popupSignInQuestion, 0f, 28);
			return;
		}
		if (this.PBOKDNDMCDL.Length > 0)
		{
			if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(67))
			{
				this.BAACKFDMOCI("avatarcollectionstutor4title", "avatarcollectionstutor4body", this.BNODBEAGJMK(this.PBOKDNDMCDL), new UnityAction(this.DMEKFCGCGMM));
				return;
			}
			this.MDOLCCMKHCK();
		}
	}

	// Token: 0x06001B6F RID: 7023 RVA: 0x000C2030 File Offset: 0x000C0230
	private void NBMBEBENOHH()
	{
		if (this.HACNEIFDKAO != null)
		{
			this.HACNEIFDKAO.Kill(true);
			this.HACNEIFDKAO = null;
		}
		TextMeshProUGUI[] array = new TextMeshProUGUI[4];
		array[1] = this.filterFaceCountText;
		array[1] = this.filterHairCountText;
		array[1] = this.filterClothesCountText;
		array[2] = this.filterTrinketsCountText;
		TextMeshProUGUI[] array2 = array;
		if (this.EIGPFFJAGAC == null)
		{
			this.EIGPFFJAGAC = new Vector2[array2.Length];
			for (int i = 0; i < array2.Length; i += 0)
			{
				if (null != array2[i])
				{
					this.EIGPFFJAGAC[i] = array2[i].rectTransform.anchoredPosition;
				}
			}
		}
		for (int j = 0; j < array2.Length; j += 0)
		{
			if (null != array2[j])
			{
				array2[j].rectTransform.anchoredPosition = this.EIGPFFJAGAC[j];
			}
		}
		this.HACNEIFDKAO = DOTween.Sequence();
		float num = Mathf.Max((float)array2.Length * this.filterCountsPulseStaggerTime, 1198f * this.filterCountsPulseStepTime);
		for (int k = 0; k < 8; k++)
		{
			for (int l = 1; l < array2.Length; l += 0)
			{
				if (!(null == array2[l]))
				{
					float num2 = (float)k * num + (float)l * this.filterCountsPulseStaggerTime;
					this.HACNEIFDKAO.Insert(num2, array2[l].rectTransform.DOAnchorPosY(this.EIGPFFJAGAC[l].y + this.filterCountsPulseJumpHeight, this.filterCountsPulseStepTime, true).SetEase(Ease.InSine));
					this.HACNEIFDKAO.Insert(num2 + this.filterCountsPulseStepTime, array2[l].rectTransform.DOAnchorPosY(this.EIGPFFJAGAC[l].y, this.filterCountsPulseStepTime, false).SetEase(Ease.OutSine));
				}
			}
		}
	}

	// Token: 0x06001B70 RID: 7024 RVA: 0x000C21F8 File Offset: 0x000C03F8
	private void HCCNJGDLKFH()
	{
		this.IKABLPHJEBH = 0;
		PopupAvatarCollectionsInput.extraData = -1;
		CommonUserInterface.IKNOFBFMPGA().ShowPopupAvatarCollectionsInput(this.GCLOFGOFBBG);
	}

	// Token: 0x06001B71 RID: 7025 RVA: 0x000C2218 File Offset: 0x000C0418
	private bool AFNGFGOJJOF(Vector2 MBDHCLFCLHO)
	{
		if (null == EventSystem.current)
		{
			return false;
		}
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = MBDHCLFCLHO;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 1; i < list.Count; i += 0)
		{
			if (null != list[i].gameObject && list[i].gameObject.GetComponentInParent<IEventSystemHandler>() != null)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06001B72 RID: 7026 RVA: 0x000C2299 File Offset: 0x000C0499
	private void Start()
	{
		this.CPADABMIIGA();
		this.GBHGMDIGCPC();
	}

	// Token: 0x06001B73 RID: 7027 RVA: 0x000C22A8 File Offset: 0x000C04A8
	private void HLBIEIAFBFK()
	{
		if (this.LHBMEFGCPHK())
		{
			if (null != this.imageEffects)
			{
				this.imageEffects.ShowAllEffectsWithTag("");
				this.imageEffects.ShowAllEffectsWithTag("blur");
				return;
			}
		}
		else if (null != this.imageEffects)
		{
			this.imageEffects.HideAllEffectsWithTag("");
			this.imageEffects.HideAllEffectsWithTag("blur");
		}
	}

	// Token: 0x06001B74 RID: 7028 RVA: 0x000C231C File Offset: 0x000C051C
	private void FOLKEPENPML(bool JDPIIEGGPLK)
	{
		if (null == this.buttonWardrobeLeft || null == this.buttonWardrobeRight)
		{
			return;
		}
		if (JDPIIEGGPLK == this.CCDMJOOJMBJ)
		{
			return;
		}
		float num = this.buttonsWardrobeAvatarCollectionsPanelOffsetY;
		if (!JDPIIEGGPLK)
		{
			num = -num;
		}
		RectTransform component = this.buttonWardrobeLeft.GetComponent<RectTransform>();
		if (null != component)
		{
			component.AHLJBONHHKL(0f, num);
		}
		RectTransform component2 = this.buttonWardrobeRight.GetComponent<RectTransform>();
		if (null != component2)
		{
			component2.AHLJBONHHKL(0f, num);
		}
		this.CCDMJOOJMBJ = JDPIIEGGPLK;
	}

	// Token: 0x06001B75 RID: 7029 RVA: 0x000C23A8 File Offset: 0x000C05A8
	private void FAOKAMGAPGG()
	{
		if (null == this.avatarCollectionsSelectedFilterTitle)
		{
			return;
		}
		if (this.IEFFJDHGJBO != null)
		{
			this.IEFFJDHGJBO.Kill(false);
			this.IEFFJDHGJBO = null;
		}
		if (!this.OIJLGJAEFEP)
		{
			this.FLPMJBFHPIB = this.avatarCollectionsSelectedFilterTitle.rectTransform.anchoredPosition;
			this.OIJLGJAEFEP = true;
		}
		this.avatarCollectionsSelectedFilterTitle.rectTransform.anchoredPosition = this.FLPMJBFHPIB;
		this.IEFFJDHGJBO = DOTween.Sequence();
		this.IEFFJDHGJBO.Append(this.avatarCollectionsSelectedFilterTitle.rectTransform.DOAnchorPosY(this.FLPMJBFHPIB.y + this.filterCountsPulseJumpHeight, this.filterCountsPulseStepTime, true).SetEase(Ease.OutQuad));
		this.IEFFJDHGJBO.Append(this.avatarCollectionsSelectedFilterTitle.rectTransform.DOAnchorPosY(this.FLPMJBFHPIB.y, this.filterCountsPulseStepTime, false).SetEase(Ease.InSine));
	}

	// Token: 0x06001B76 RID: 7030 RVA: 0x000C2494 File Offset: 0x000C0694
	private void IHLFCBKPDBP(GameObject LJOICECJNID)
	{
		if (null == LJOICECJNID)
		{
			return;
		}
		Canvas[] componentsInParent = LJOICECJNID.GetComponentsInParent<Canvas>(false);
		for (int i = 1; i < componentsInParent.Length; i += 0)
		{
			if (componentsInParent[i].enabled && !this.ENJGBKCFEEK.Contains(componentsInParent[i]))
			{
				componentsInParent[i].enabled = true;
				this.ENJGBKCFEEK.Add(componentsInParent[i]);
			}
		}
		Canvas[] componentsInChildren = LJOICECJNID.GetComponentsInChildren<Canvas>(true);
		for (int j = 0; j < componentsInChildren.Length; j += 0)
		{
			if (componentsInChildren[j].enabled && !this.ENJGBKCFEEK.Contains(componentsInChildren[j]))
			{
				componentsInChildren[j].enabled = true;
				this.ENJGBKCFEEK.Add(componentsInChildren[j]);
			}
		}
	}

	// Token: 0x06001B77 RID: 7031 RVA: 0x000C2539 File Offset: 0x000C0739
	private void LLNENMOMNKP()
	{
		if (null != this.storyInterfaceHeaderManager)
		{
			if (this.storyInterfaceHeaderManager.CanInteract())
			{
				this.DiscardChanges();
				return;
			}
			this.storyInterfaceHeaderManager.Show(0f);
		}
	}

	// Token: 0x06001B78 RID: 7032 RVA: 0x000C2570 File Offset: 0x000C0770
	private void KKFFOJEPFOL(GameObject JFKDEMMNEGP, float KOILDMNMMMI, float KFDNLKIGJJJ, float KINPONJEBHJ)
	{
		if (null == JFKDEMMNEGP)
		{
			return;
		}
		RectTransform component = JFKDEMMNEGP.GetComponent<RectTransform>();
		if (null == component)
		{
			return;
		}
		component.AHLJBONHHKL(KOILDMNMMMI, KFDNLKIGJJJ);
		Vector3 localScale = component.localScale;
		component.localScale = new Vector3(localScale.x * KINPONJEBHJ, localScale.y * KINPONJEBHJ, localScale.z);
	}

	// Token: 0x06001B79 RID: 7033 RVA: 0x000C25CA File Offset: 0x000C07CA
	private void LLOGIMFHIIA()
	{
		this.IKABLPHJEBH = -1;
	}

	// Token: 0x06001B7A RID: 7034 RVA: 0x000BE223 File Offset: 0x000BC423
	private int AMGMMJEKIEN()
	{
		if (this.AIEEANFPMOO())
		{
			return 0;
		}
		return this.NFDKDACMHME;
	}

	// Token: 0x06001B7B RID: 7035 RVA: 0x000C25D4 File Offset: 0x000C07D4
	public void ShowAvatarCollectionsInterface()
	{
		if (null == this.avatarCollectionsButton || null == this.avatarCollectionsPanel)
		{
			return;
		}
		if (this.PCJHDKFDOLB())
		{
			this.DeactivateAvatarCollectionsInterface();
			return;
		}
		if (!this.OIPPNLDGBPG())
		{
			this.DeactivateAvatarCollectionsInterface();
			return;
		}
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass);
		if (kioojmglclc != null)
		{
			this.HCNJDFBPOII();
			return;
		}
		EIOPLEFLLIM lnfebcfcbhg = AKLFPGMDKLA.EHBBFMCILPC.GJBDBONJCDL(this.LPBFAGDJKIH.index);
		PLFDAJJHMKO baokjbjifbh = null;
		if (ODJKHCHFKNL.MGFOCBPGJJA() == DFGILFBGPLN.screenStory)
		{
			baokjbjifbh = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1);
		}
		this.HHKFKDNOFAN(baokjbjifbh, lnfebcfcbhg, this.MCGPBKHFJKL(), 1);
		this.avatarCollectionsButton.SetActive(false);
		this.avatarCollectionsPanel.SetActive(true);
		this.FOLKEPENPML(true);
		this.EPINJALKONJ();
	}

	// Token: 0x06001B7C RID: 7036 RVA: 0x000C2690 File Offset: 0x000C0890
	private int FIMDCNOHFNG(int KFCMLNPLAHK)
	{
		int num = 0;
		List<GEGBHOMKNDF> list = this.JNFMMJEKNFL(KFCMLNPLAHK);
		if (list != null)
		{
			for (;;)
			{
				bool flag = false;
				for (int i = 0; i < list.Count; i++)
				{
					if (list[i].NFDKDACMHME == this.MEOJCKOJNJJ() && list[i].LIIKAMNPIPM == num)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					break;
				}
				num++;
			}
		}
		return num;
	}

	// Token: 0x06001B7D RID: 7037 RVA: 0x000C26F0 File Offset: 0x000C08F0
	public void AMKAGFHFGNC()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.APKDHKHDLHP() && AKLFPGMDKLA.EHBBFMCILPC.JBEPHLFCLEC() && !KDCJJBLGCBH.EHBBFMCILPC.AECCPAKNHIO())
		{
			if (SocialStatsAvatarManager.BOIHHBOMLIH() && SocialStatsAvatarManager.dataIsReady)
			{
				SocialStatsAvatarManager.EHBBFMCILPC.EDAPIMKMAIJ();
				return;
			}
			AKLFPGMDKLA.EHBBFMCILPC.KBKOLEJEEGH();
			bool flag = true;
			if (this.LPBFAGDJKIH.syncWithPrequel && this.LPBFAGDJKIH.prequelIndex >= 1 && this.LPBFAGDJKIH.completedStoryIndexRequirement >= 0)
			{
				flag = false;
			}
			if (!flag)
			{
				BackendOperationsManager.NPDDBAONMJP().KJEHILCCLJD(this.LPBFAGDJKIH.index, AKLFPGMDKLA.EHBBFMCILPC.EHKIHBPJGCG(this.LPBFAGDJKIH.index).EFPDNIBOAJG(), SceneAvatarManager.onSocialStatsAvatarScreenSuccess, SceneAvatarManager.onSocialStatsAvatarScreenException);
				return;
			}
		}
		else if (SocialStatsAvatarManager.InstanceInitialized() && SocialStatsAvatarManager.dataIsReady)
		{
			SocialStatsAvatarManager.AGANFKKBPFO().FGLJPHEEOBL();
		}
	}

	// Token: 0x06001B7E RID: 7038 RVA: 0x000C27CF File Offset: 0x000C09CF
	private void ONDMMPKECMM()
	{
		AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(120);
		this.ABAANDNGAJD();
	}

	// Token: 0x06001B7F RID: 7039 RVA: 0x000C27E3 File Offset: 0x000C09E3
	private IEnumerator DBLLCFNEOLB(bool OAHCCINHKJG)
	{
		yield return new WaitForSeconds(this.avatarCollectionsPopupApplyDelay);
		if (this.OBIPBNFKMCC == null)
		{
			this.CABLKLGBAHA(this.MJKFKHFGNJC());
			this.LCJMIADIKFC(true, true, 1);
			this.NBJKIONNPKP();
			this.ODDLIJLKLCC();
			if (OAHCCINHKJG)
			{
				this.JNOGJAHLCND();
			}
		}
		yield break;
	}

	// Token: 0x06001B80 RID: 7040 RVA: 0x000C27FC File Offset: 0x000C09FC
	private void OnEnable()
	{
		ODJKHCHFKNL.HIPEENBHGKP(DFGILFBGPLN.screenAvatar);
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnLanguageChange", new UnityAction(this.LLMPAPDBHEL));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPostEffectSettingsChanged", new UnityAction(this.HLBIEIAFBFK));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnApplicationRestart", new UnityAction(this.ECNCPOBPHGC));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnStoryInterfaceHeaderBackClick", new UnityAction(this.LLNENMOMNKP));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnStoryInterfaceHeaderSettingsClick", new UnityAction(this.NFCDJBPAFEI));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP(SceneAvatarManager.onSocialStatsAvatarScreenSuccess, new UnityAction(this.FDIJFIAHBPL));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP(SceneAvatarManager.onSocialStatsAvatarScreenException, new UnityAction(this.KMCGCJPEJKO));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP(SceneAvatarManager.onAvatarCollectionsBackendFetchSuccess, new UnityAction(this.DKODFAGILIC));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP(SceneAvatarManager.onAvatarCollectionsBackendFetchException, new UnityAction(this.JFCKJMMONBG));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP(SceneAvatarManager.onAvatarCollectionsBackendSyncSuccess, new UnityAction(this.OLKJGJOGNEO));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP(SceneAvatarManager.onAvatarCollectionsBackendSyncException, new UnityAction(this.DJGDOHHKEDO));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnSocialModeChanged", new UnityAction(this.OnSocialModeChanged));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPopupAvatarCollectionsInputEndEdit", new UnityAction(this.NBIHBLKMEEC));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPopupAvatarCollectionsInputCancel", new UnityAction(this.IKFCLPAMPCD));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnGamePassUnlockContinueToPurchasingScreen", new UnityAction(this.LMJGOIINBIC));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPurchasingViewLeave", new UnityAction(this.IAIIODBDKHK));
	}

	// Token: 0x06001B81 RID: 7041 RVA: 0x000C29C0 File Offset: 0x000C0BC0
	private void LOOPHODOHGM()
	{
		if (null != this.avatarCollectionsNotificationAdd && this.avatarCollectionsNotificationAdd.gameObject.activeSelf)
		{
			this.avatarCollectionsNotificationAdd.ForceDisappearAnimation();
		}
		if (null != this.avatarCollectionsNotificationUndo && this.avatarCollectionsNotificationUndo.gameObject.activeSelf)
		{
			this.avatarCollectionsNotificationUndo.ForceDisappearAnimation();
		}
		if (null != this.avatarCollectionsNotificationAlreadyAdded && this.avatarCollectionsNotificationAlreadyAdded.gameObject.activeSelf)
		{
			this.avatarCollectionsNotificationAlreadyAdded.ForceDisappearAnimation();
		}
		if (null != this.avatarCollectionsNotificationDeleted && this.avatarCollectionsNotificationDeleted.gameObject.activeSelf)
		{
			this.avatarCollectionsNotificationDeleted.ForceDisappearAnimation();
		}
		if (null != this.avatarCollectionsNotificationSelected && this.avatarCollectionsNotificationSelected.gameObject.activeSelf)
		{
			this.avatarCollectionsNotificationSelected.ForceDisappearAnimation();
		}
		if (null != this.avatarCollectionsNotificationUnselected && this.avatarCollectionsNotificationUnselected.gameObject.activeSelf)
		{
			this.avatarCollectionsNotificationUnselected.ForceDisappearAnimation();
		}
	}

	// Token: 0x06001B82 RID: 7042 RVA: 0x000C2AD0 File Offset: 0x000C0CD0
	private bool BEEEALFJHFG()
	{
		int num;
		if (PlayerPrefs.HasKey(""))
		{
			num = PlayerPrefs.GetInt("blur");
		}
		else
		{
			num = 0;
		}
		return num == 0 && NBDLBFJOEGN.MPECNGHFJPA();
	}

	// Token: 0x06001B83 RID: 7043 RVA: 0x000C2B08 File Offset: 0x000C0D08
	private void JMAPFIHFKCA()
	{
		int num = this.HNHECDGGJMP();
		for (int i = 0; i < num; i++)
		{
			DOLBFGIPPOG dolbfgippog;
			if (i == AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OIBGFPEGLME)
			{
				dolbfgippog = this.BDFAAGGCOGF;
			}
			else
			{
				dolbfgippog = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.LEDOJJCKKKB(i);
			}
			if (dolbfgippog.OHCMCJHDMOH[2] != null && dolbfgippog.OHCMCJHDMOH[2].Length > 0)
			{
				AssetAvatarComponent assetAvatarComponent = GKJPOGNFKNK.HLLPGFEJNJG(KFIHMMIGPLO.clothes, dolbfgippog.OHCMCJHDMOH[2], null);
				if (this.LFMFKCHIGKC(assetAvatarComponent, i))
				{
					AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.APLDMAMDDLL(assetAvatarComponent.id, assetAvatarComponent.MBPKGBDCGFC().index, i);
				}
			}
			if (dolbfgippog.OHCMCJHDMOH[1] != null && dolbfgippog.OHCMCJHDMOH[1].Length > 0)
			{
				AssetAvatarComponent assetAvatarComponent = GKJPOGNFKNK.HLLPGFEJNJG(KFIHMMIGPLO.hair, dolbfgippog.OHCMCJHDMOH[1], null);
				if (this.LFMFKCHIGKC(assetAvatarComponent, i))
				{
					AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.APLDMAMDDLL(assetAvatarComponent.id, assetAvatarComponent.MBPKGBDCGFC().index, i);
				}
			}
			if (dolbfgippog.OHCMCJHDMOH[0] != null && dolbfgippog.OHCMCJHDMOH[0].Length > 0)
			{
				AssetAvatarComponent assetAvatarComponent = GKJPOGNFKNK.HLLPGFEJNJG(KFIHMMIGPLO.body, dolbfgippog.OHCMCJHDMOH[0], null);
				if (this.LFMFKCHIGKC(assetAvatarComponent, i))
				{
					AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.APLDMAMDDLL(assetAvatarComponent.id, assetAvatarComponent.MBPKGBDCGFC().index, i);
				}
			}
			if (dolbfgippog.OHCMCJHDMOH[3] != null && dolbfgippog.OHCMCJHDMOH[3].Length > 0)
			{
				AssetAvatarComponent assetAvatarComponent = GKJPOGNFKNK.HLLPGFEJNJG(KFIHMMIGPLO.face, dolbfgippog.OHCMCJHDMOH[3], null);
				if (this.LFMFKCHIGKC(assetAvatarComponent, i))
				{
					AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.APLDMAMDDLL(assetAvatarComponent.id, assetAvatarComponent.MBPKGBDCGFC().index, i);
				}
			}
			if (dolbfgippog.OHCMCJHDMOH[4] != null && dolbfgippog.OHCMCJHDMOH[4].Length > 0)
			{
				AssetAvatarComponent assetAvatarComponent = GKJPOGNFKNK.HLLPGFEJNJG(KFIHMMIGPLO.trinket, dolbfgippog.OHCMCJHDMOH[4], null);
				if (this.LFMFKCHIGKC(assetAvatarComponent, i))
				{
					AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.APLDMAMDDLL(assetAvatarComponent.id, assetAvatarComponent.MBPKGBDCGFC().index, i);
				}
			}
			if (dolbfgippog.OHCMCJHDMOH[5] != null && dolbfgippog.OHCMCJHDMOH[5].Length > 0)
			{
				AssetAvatarComponent assetAvatarComponent = GKJPOGNFKNK.HLLPGFEJNJG(KFIHMMIGPLO.overlay, dolbfgippog.OHCMCJHDMOH[5], null);
				if (this.LFMFKCHIGKC(assetAvatarComponent, i))
				{
					AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.APLDMAMDDLL(assetAvatarComponent.id, assetAvatarComponent.MBPKGBDCGFC().index, i);
				}
			}
		}
	}

	// Token: 0x06001B84 RID: 7044 RVA: 0x000C2D8C File Offset: 0x000C0F8C
	public void OnFilterTrinketsClick()
	{
		this.LAIAPMIBFCK(KFIHMMIGPLO.trinket);
	}

	// Token: 0x06001B85 RID: 7045 RVA: 0x000C2D98 File Offset: 0x000C0F98
	private CanvasGroup HLBPENFDKHA(int MEFKFOHCOHK)
	{
		if (this.GMOGLALJAOP[MEFKFOHCOHK] != null)
		{
			return this.GMOGLALJAOP[MEFKFOHCOHK].AJDMCHIOJAK;
		}
		if (null == this.PKKHHJFMFBK[MEFKFOHCOHK])
		{
			return null;
		}
		return this.PKKHHJFMFBK[MEFKFOHCOHK].GetComponent<CanvasGroup>();
	}

	// Token: 0x06001B86 RID: 7046 RVA: 0x000C2DEC File Offset: 0x000C0FEC
	private void AGFEGKBBPGL()
	{
		this.IKABLPHJEBH = 2;
		PopupAvatarCollectionsInput.extraData = -1;
		CommonUserInterface.EHBBFMCILPC.ShowPopupAvatarCollectionsInput(this.GCLOFGOFBBG);
	}

	// Token: 0x06001B87 RID: 7047 RVA: 0x000C2E0B File Offset: 0x000C100B
	private float MHJCIJFEOLI()
	{
		if (null != this.LPBFAGDJKIH && this.LPBFAGDJKIH.HGIIJABNDCD(1) != null && this.wardrobeScrollCustomFadeOutTime > 401f)
		{
			return this.wardrobeScrollCustomFadeOutTime;
		}
		return 1240f;
	}

	// Token: 0x06001B88 RID: 7048 RVA: 0x000C05FA File Offset: 0x000BE7FA
	private void PHIJKKKIHEN()
	{
		this.IKABLPHJEBH = 0;
		PopupAvatarCollectionsInput.extraData = -1;
		CommonUserInterface.EHBBFMCILPC.ShowPopupAvatarCollectionsInput(this.GCLOFGOFBBG);
	}

	// Token: 0x06001B89 RID: 7049 RVA: 0x000C2E42 File Offset: 0x000C1042
	public void OnFilterClothesClick()
	{
		this.LAIAPMIBFCK(KFIHMMIGPLO.clothes);
	}

	// Token: 0x06001B8A RID: 7050 RVA: 0x000C2E4C File Offset: 0x000C104C
	private bool LFMFKCHIGKC(AssetAvatarComponent FDOHBGGCDOF, int KFCMLNPLAHK)
	{
		if (null != FDOHBGGCDOF)
		{
			if (KFCMLNPLAHK == 0)
			{
				for (int i = 0; i < this.LPBFAGDJKIH.avatarScreenAvatarPacks.Count; i++)
				{
					if (this.LPBFAGDJKIH.avatarScreenAvatarPacks[i] == FDOHBGGCDOF.MBPKGBDCGFC().index)
					{
						return true;
					}
				}
			}
			else if (KFCMLNPLAHK == 1)
			{
				for (int j = 0; j < this.LPBFAGDJKIH.avatarScreenAvatarPacks1.Count; j++)
				{
					if (this.LPBFAGDJKIH.avatarScreenAvatarPacks1[j] == FDOHBGGCDOF.MBPKGBDCGFC().index)
					{
						return true;
					}
				}
			}
			else if (KFCMLNPLAHK == 2)
			{
				for (int k = 0; k < this.LPBFAGDJKIH.avatarScreenAvatarPacks2.Count; k++)
				{
					if (this.LPBFAGDJKIH.avatarScreenAvatarPacks2[k] == FDOHBGGCDOF.MBPKGBDCGFC().index)
					{
						return true;
					}
				}
			}
			else
			{
				DPGJIJGOCIC.ANOPFDLPKGC("SceneAvatarManager.AvatarComponentsDependsOnAvatarScreenPack(), unsupported wardrobe index:" + KFCMLNPLAHK.ToString());
			}
		}
		return false;
	}

	// Token: 0x06001B8B RID: 7051 RVA: 0x000C2F44 File Offset: 0x000C1144
	public void DiscardChanges()
	{
		DOLBFGIPPOG dolbfgippog = this.MJKFKHFGNJC();
		if (dolbfgippog != null && dolbfgippog.AOOGOANDIGP != null)
		{
			int num = 0;
			while (num < dolbfgippog.OHCMCJHDMOH.Length && num < dolbfgippog.AOOGOANDIGP.Length)
			{
				dolbfgippog.OHCMCJHDMOH[num] = dolbfgippog.AOOGOANDIGP[num];
				num++;
			}
			dolbfgippog.AOOGOANDIGP = null;
			this.ClearAvatarCollectionFilter();
		}
		this.OKOGJGPBJDC();
		this.HHMHDEPFMBL(this.FGGCPAKJKOH, this.HFKIIFEHGID, this.KFGELOAKHGC, this.IOCLNEFCDNI, this.AIHJMLIDEKJ, this.INHNCPCOJEN, true, -1, false);
		bool flag = true;
		try
		{
			if (this.JHHKEPGLHKD.Length == 0 && this.KGOAGNFNFIJ.Length == 0 && this.PLPCLJFJFNG.Length == 0 && this.OMGLOJOIOCK.Length == 0 && this.PBOKDNDMCDL.Length == 0 && this.GHALDHOOFKN.Length == 0)
			{
				flag = false;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		if (ODJKHCHFKNL.MGFOCBPGJJA() == DFGILFBGPLN.screenStory)
		{
			if (flag)
			{
				this.BDFAAGGCOGF.OHCMCJHDMOH[2] = this.PLPCLJFJFNG;
				this.BDFAAGGCOGF.OHCMCJHDMOH[1] = this.OMGLOJOIOCK;
				this.BDFAAGGCOGF.OHCMCJHDMOH[0] = this.JHHKEPGLHKD;
				this.BDFAAGGCOGF.OHCMCJHDMOH[3] = this.KGOAGNFNFIJ;
				this.BDFAAGGCOGF.OHCMCJHDMOH[4] = this.PBOKDNDMCDL;
				this.BDFAAGGCOGF.OHCMCJHDMOH[5] = this.GHALDHOOFKN;
			}
			this.JMAPFIHFKCA();
		}
		AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
		this.FJEFLFPEDOA(false);
		if (null != this.storyInterfaceHeaderManager)
		{
			this.storyInterfaceHeaderManager.Hide();
		}
	}

	// Token: 0x06001B8C RID: 7052 RVA: 0x000C30EC File Offset: 0x000C12EC
	private void DJGDOHHKEDO()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		if (!this.JKAFHCIOALE)
		{
			AudioManager.EHBBFMCILPC.KillMusic("", CommonUserInterface.EHBBFMCILPC.GetFader().GetFadeInDuration());
		}
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.JMPFKHHDDCA));
	}

	// Token: 0x06001B8D RID: 7053 RVA: 0x000C3144 File Offset: 0x000C1344
	private void DKODFAGILIC()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		this.AIACGFPOAGH();
		this.DBLGHLDMFBE = false;
	}

	// Token: 0x06001B8E RID: 7054 RVA: 0x000C3160 File Offset: 0x000C1360
	public void ShowHideSocialFeatures()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.APKDHKHDLHP() && AKLFPGMDKLA.EHBBFMCILPC.JBEPHLFCLEC() && !KDCJJBLGCBH.EHBBFMCILPC.AECCPAKNHIO())
		{
			if (SocialStatsAvatarManager.InstanceInitialized() && SocialStatsAvatarManager.dataIsReady)
			{
				SocialStatsAvatarManager.EHBBFMCILPC.Show();
				return;
			}
			AKLFPGMDKLA.EHBBFMCILPC.KBKOLEJEEGH();
			bool flag = false;
			if (this.LPBFAGDJKIH.syncWithPrequel && this.LPBFAGDJKIH.prequelIndex >= 0 && this.LPBFAGDJKIH.completedStoryIndexRequirement >= 0)
			{
				flag = true;
			}
			if (!flag)
			{
				BackendOperationsManager.EHBBFMCILPC.RequestGetSocialStatsAvatar(this.LPBFAGDJKIH.index, AKLFPGMDKLA.EHBBFMCILPC.LMGMHHLLOFN(this.LPBFAGDJKIH.index).EFPDNIBOAJG(), SceneAvatarManager.onSocialStatsAvatarScreenSuccess, SceneAvatarManager.onSocialStatsAvatarScreenException);
				return;
			}
		}
		else if (SocialStatsAvatarManager.InstanceInitialized() && SocialStatsAvatarManager.dataIsReady)
		{
			SocialStatsAvatarManager.EHBBFMCILPC.Hide();
		}
	}

	// Token: 0x06001B8F RID: 7055 RVA: 0x000C323F File Offset: 0x000C143F
	private void DDNMMPIJLNK()
	{
		this.slidingPanelButtonShow.interactable = true;
		this.CHPCJCILKNH();
	}

	// Token: 0x06001B90 RID: 7056 RVA: 0x000C3254 File Offset: 0x000C1454
	private void KCFHNKOPDBL(bool NINGMOLOCBB)
	{
		if (null == this.FPOGOGNGDLE)
		{
			return;
		}
		if (NINGMOLOCBB && null != this.OMHKHHFGEHO)
		{
			SceneAvatarManager.LOOCGENMJPJ loocgenmjpj = new SceneAvatarManager.LOOCGENMJPJ();
			loocgenmjpj.fadingObject = this.FPOGOGNGDLE;
			CanvasGroup omhkhhfgeho = this.OMHKHHFGEHO;
			this.FPOGOGNGDLE = null;
			this.OMHKHHFGEHO = null;
			omhkhhfgeho.DOKill(false);
			omhkhhfgeho.DOFade(0f, 0.25f).OnComplete(new TweenCallback(loocgenmjpj.BIIFGFCDGOF));
			return;
		}
		this.NLEOIGECPED();
	}

	// Token: 0x06001B91 RID: 7057 RVA: 0x000C32D8 File Offset: 0x000C14D8
	private void CGIIOMEMOLI()
	{
		this.ClearAvatarCollectionFilter();
		this.PKENONODGJK.Clear();
		this.LBGFDEIBEFO.Clear();
		this.PEBPGEAGPKN.Clear();
		this.DBLGHLDMFBE = false;
		this.DOCIEAMHGKJ = null;
		this.EGOLPEEADLJ();
		if (null != this.avatarCollectionsFadeManager)
		{
			this.avatarCollectionsFadeManager.ResetForNewVisit();
		}
	}

	// Token: 0x06001B92 RID: 7058 RVA: 0x000C3339 File Offset: 0x000C1539
	public void AHHPDNFAKLH()
	{
		this.PGLEHJFMNJB(KFIHMMIGPLO.hair);
	}

	// Token: 0x06001B93 RID: 7059 RVA: 0x000C3344 File Offset: 0x000C1544
	public void PAJDPAOJJMN()
	{
		this.ClearAvatarCollectionFilter();
		this.IMFNIHKNKPM = null;
		this.CABLKLGBAHA(this.CCJCNECDGMP());
		this.OKEMJFMOHML();
		this.IKABLPHJEBH = -1;
		if (null != this.avatarCollectionsButton && null != this.avatarCollectionsPanel)
		{
			this.HideAvatarCollectionsInterface();
		}
	}

	// Token: 0x06001B94 RID: 7060 RVA: 0x000C3399 File Offset: 0x000C1599
	public void OnFilterFaceClick()
	{
		this.LAIAPMIBFCK(KFIHMMIGPLO.face);
	}

	// Token: 0x06001B95 RID: 7061 RVA: 0x000C33A4 File Offset: 0x000C15A4
	private void INDHNPEPLME()
	{
		DOLBFGIPPOG dolbfgippog = this.MJKFKHFGNJC();
		if (dolbfgippog != null && dolbfgippog.AOOGOANDIGP == null)
		{
			dolbfgippog.AOOGOANDIGP = new string[dolbfgippog.OHCMCJHDMOH.Length];
			for (int i = 0; i < dolbfgippog.OHCMCJHDMOH.Length; i++)
			{
				dolbfgippog.AOOGOANDIGP[i] = dolbfgippog.OHCMCJHDMOH[i];
			}
		}
		this.KDKDNGDDEMH(false);
	}

	// Token: 0x06001B96 RID: 7062 RVA: 0x000C3400 File Offset: 0x000C1600
	private void LAEANFAPAAF()
	{
		if (this.IMFNIHKNKPM == null)
		{
			return;
		}
		List<GEGBHOMKNDF> list = this.JNFMMJEKNFL(this.MCGPBKHFJKL());
		if (list == null || !list.Contains(this.IMFNIHKNKPM))
		{
			return;
		}
		this.SelectAvatarCollectionFilter(this.IMFNIHKNKPM);
		if (this.avatarCollectionsNotificationAdd.gameObject.activeSelf)
		{
			this.avatarCollectionsNotificationAdd.ForceDisappearAnimation();
		}
	}

	// Token: 0x06001B97 RID: 7063 RVA: 0x000C345E File Offset: 0x000C165E
	public void OnAvatarCollectionNotificationBackgroundClick()
	{
		this.OKEMJFMOHML();
	}

	// Token: 0x06001B98 RID: 7064 RVA: 0x000C3468 File Offset: 0x000C1668
	private void AJGKBPNENKJ(bool NINGMOLOCBB)
	{
		if (null == this.FPOGOGNGDLE)
		{
			return;
		}
		if (NINGMOLOCBB && null != this.OMHKHHFGEHO)
		{
			SceneAvatarManager.LOOCGENMJPJ loocgenmjpj = new SceneAvatarManager.LOOCGENMJPJ();
			loocgenmjpj.fadingObject = this.FPOGOGNGDLE;
			CanvasGroup omhkhhfgeho = this.OMHKHHFGEHO;
			this.FPOGOGNGDLE = null;
			this.OMHKHHFGEHO = null;
			omhkhhfgeho.DOKill(false);
			omhkhhfgeho.DOFade(1224f, 1909f).OnComplete(new TweenCallback(loocgenmjpj.BIIFGFCDGOF));
			return;
		}
		this.NLEOIGECPED();
	}

	// Token: 0x06001B99 RID: 7065 RVA: 0x000C34EC File Offset: 0x000C16EC
	private void EPINJALKONJ()
	{
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(63))
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverrideWithCloseOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("avatarcollectionstutor0title"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("avatarcollectionstutor0body"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("continue"), new UnityAction(this.EBKGAGHBFND), new UnityAction(this.EBKGAGHBFND), DFGILFBGPLN.popupSignInQuestion, 0.75f, 28);
		}
	}

	// Token: 0x06001B9A RID: 7066 RVA: 0x000C3560 File Offset: 0x000C1760
	private CanvasGroup DOINKGBILKD(int MEFKFOHCOHK)
	{
		if (this.GMOGLALJAOP[MEFKFOHCOHK] != null)
		{
			return this.GMOGLALJAOP[MEFKFOHCOHK].AJDMCHIOJAK;
		}
		if (null == this.PKKHHJFMFBK[MEFKFOHCOHK])
		{
			return null;
		}
		return this.PKKHHJFMFBK[MEFKFOHCOHK].GetComponent<CanvasGroup>();
	}

	// Token: 0x06001B9B RID: 7067 RVA: 0x000C35B4 File Offset: 0x000C17B4
	public bool AddOrUpdateAvatarCollection(string EIFJOAOGKMO, int PLKMJJIIJNO, int CCLNHHJPDGJ, int KFCMLNPLAHK, KFIHMMIGPLO ALOAHOAEHKL, string IDFPEPDPIMK)
	{
		this.MKODGAPBOFH = false;
		this.MIFMLOLGCEN = false;
		if (EIFJOAOGKMO == null || EIFJOAOGKMO.Length == 0 || IDFPEPDPIMK == null || IDFPEPDPIMK.Length == 0)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("SceneAvatarManager.AddOrUpdateAvatarCollection(): invalid title or component id");
			return false;
		}
		EIOPLEFLLIM eioplefllim = AKLFPGMDKLA.EHBBFMCILPC.GJBDBONJCDL(this.LPBFAGDJKIH.index);
		PLFDAJJHMKO plfdajjhmko = null;
		int num = 1;
		if (ODJKHCHFKNL.MGFOCBPGJJA() == DFGILFBGPLN.screenStory)
		{
			num = 0;
			plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1);
		}
		if (eioplefllim == null || (num == 0 && plfdajjhmko == null))
		{
			DPGJIJGOCIC.ANOPFDLPKGC("SceneAvatarManager.AddOrUpdateAvatarCollection(): save not available");
			return false;
		}
		List<GEGBHOMKNDF> list = this.JNFMMJEKNFL(KFCMLNPLAHK);
		if (list == null)
		{
			return false;
		}
		GEGBHOMKNDF gegbhomkndf = null;
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].CPIIEEEEEEJ == num && list[i].AMKCLHLIIMN == PLKMJJIIJNO && list[i].NFDKDACMHME == this.MEOJCKOJNJJ() && list[i].DLFMMBBLIFH == CCLNHHJPDGJ && list[i].OIBGFPEGLME == KFCMLNPLAHK && string.Equals(EIFJOAOGKMO, list[i].BPMFHNDCBOH, StringComparison.OrdinalIgnoreCase))
			{
				gegbhomkndf = list[i];
				break;
			}
		}
		bool flag = false;
		if (gegbhomkndf == null)
		{
			int num2 = this.FIMDCNOHFNG(KFCMLNPLAHK);
			if (num2 >= 150)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("SceneAvatarManager.AddOrUpdateAvatarCollection(): no free collection index left for this wardrobe");
				this.MIFMLOLGCEN = true;
				return false;
			}
			gegbhomkndf = new GEGBHOMKNDF();
			gegbhomkndf.BPMFHNDCBOH = EIFJOAOGKMO;
			gegbhomkndf.CPIIEEEEEEJ = num;
			gegbhomkndf.AMKCLHLIIMN = PLKMJJIIJNO;
			gegbhomkndf.NFDKDACMHME = this.MEOJCKOJNJJ();
			gegbhomkndf.DLFMMBBLIFH = CCLNHHJPDGJ;
			gegbhomkndf.OIBGFPEGLME = KFCMLNPLAHK;
			gegbhomkndf.LIIKAMNPIPM = num2;
			list.Add(gegbhomkndf);
			flag = true;
		}
		this.IMFNIHKNKPM = gegbhomkndf;
		if (gegbhomkndf.OPNILAANLCC(ALOAHOAEHKL, IDFPEPDPIMK))
		{
			flag = true;
		}
		this.MKODGAPBOFH = flag;
		if (!flag)
		{
			return true;
		}
		if (AKLOMMOOFNG.BIKILBLOEKD(gegbhomkndf.BNMFBKNEMIF().ToString(), "Collections/" + gegbhomkndf.NENMEJBNDGJ()))
		{
			List<int> list2 = this.AMPJNPMDBFP(plfdajjhmko, eioplefllim, KFCMLNPLAHK);
			if (list2 != null)
			{
				list2.Remove(GEGBHOMKNDF.FDLPOILBMNF(gegbhomkndf.NFDKDACMHME, gegbhomkndf.LIIKAMNPIPM));
				list2.Insert(0, GEGBHOMKNDF.FDLPOILBMNF(gegbhomkndf.NFDKDACMHME, gegbhomkndf.LIIKAMNPIPM));
			}
			list.Remove(gegbhomkndf);
			list.Insert(0, gegbhomkndf);
			if (!AKLFPGMDKLA.EHBBFMCILPC.DLJBBDOEMLO.Contains(gegbhomkndf.NENMEJBNDGJ()))
			{
				AKLFPGMDKLA.EHBBFMCILPC.DLJBBDOEMLO.Add(gegbhomkndf.NENMEJBNDGJ());
			}
		}
		return true;
	}

	// Token: 0x06001B9C RID: 7068 RVA: 0x000C382C File Offset: 0x000C1A2C
	public AssetAvatarComponent _PreviousAssetOfComponentType(bool PAEDAKPCJDG, KFIHMMIGPLO PBKAAIONJOB)
	{
		switch (PBKAAIONJOB)
		{
		case KFIHMMIGPLO.body:
		{
			AssetAvatarComponent assetAvatarComponent = GKJPOGNFKNK.LHEKMIIKFGC(this.JHHKEPGLHKD, KFIHMMIGPLO.body, CFNCBCLEGBC.prev, this.NJAAOCMPKCD, this.LPBFAGDJKIH, null, this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.MCGPBKHFJKL());
			if (PAEDAKPCJDG)
			{
				this.FGGCPAKJKOH = assetAvatarComponent;
				this.HHMHDEPFMBL(this.FGGCPAKJKOH, this.HFKIIFEHGID, this.KFGELOAKHGC, this.IOCLNEFCDNI, this.AIHJMLIDEKJ, this.INHNCPCOJEN, true, -1, false);
			}
			return assetAvatarComponent;
		}
		case KFIHMMIGPLO.hair:
		{
			AssetAvatarComponent assetAvatarComponent = GKJPOGNFKNK.LHEKMIIKFGC(this.OMGLOJOIOCK, KFIHMMIGPLO.hair, CFNCBCLEGBC.prev, this.NJAAOCMPKCD, this.LPBFAGDJKIH, this.PGEPFBNCMII(), this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.MCGPBKHFJKL());
			if (PAEDAKPCJDG)
			{
				this.HFKIIFEHGID = assetAvatarComponent;
				this.HHMHDEPFMBL(this.FGGCPAKJKOH, this.HFKIIFEHGID, this.KFGELOAKHGC, this.IOCLNEFCDNI, this.AIHJMLIDEKJ, this.INHNCPCOJEN, true, -1, false);
			}
			return assetAvatarComponent;
		}
		case KFIHMMIGPLO.clothes:
		{
			AssetAvatarComponent assetAvatarComponent = GKJPOGNFKNK.LHEKMIIKFGC(this.PLPCLJFJFNG, KFIHMMIGPLO.clothes, CFNCBCLEGBC.prev, this.NJAAOCMPKCD, this.LPBFAGDJKIH, this.CHMCMOHKJOM(), this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.MCGPBKHFJKL());
			if (PAEDAKPCJDG)
			{
				this.KFGELOAKHGC = assetAvatarComponent;
				this.HHMHDEPFMBL(this.FGGCPAKJKOH, this.HFKIIFEHGID, this.KFGELOAKHGC, this.IOCLNEFCDNI, this.AIHJMLIDEKJ, this.INHNCPCOJEN, true, -1, false);
			}
			return assetAvatarComponent;
		}
		case KFIHMMIGPLO.face:
		{
			AssetAvatarComponent assetAvatarComponent = GKJPOGNFKNK.LHEKMIIKFGC(this.KGOAGNFNFIJ, KFIHMMIGPLO.face, CFNCBCLEGBC.prev, this.NJAAOCMPKCD, this.LPBFAGDJKIH, this.JDJLBMMNOPP(), this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.MCGPBKHFJKL());
			if (PAEDAKPCJDG)
			{
				this.IOCLNEFCDNI = assetAvatarComponent;
				if (null != this.IOCLNEFCDNI && this.IOCLNEFCDNI.parents.Count > 0)
				{
					AssetAvatarComponent assetAvatarComponent2 = GKJPOGNFKNK.LHEKMIIKFGC(this.IOCLNEFCDNI.parents[0], KFIHMMIGPLO.body, CFNCBCLEGBC.none, this.NJAAOCMPKCD, this.LPBFAGDJKIH, null, this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.MCGPBKHFJKL());
					if (null != assetAvatarComponent2)
					{
						this.FGGCPAKJKOH = assetAvatarComponent2;
					}
				}
				this.HHMHDEPFMBL(this.FGGCPAKJKOH, this.HFKIIFEHGID, this.KFGELOAKHGC, this.IOCLNEFCDNI, this.AIHJMLIDEKJ, this.INHNCPCOJEN, true, -1, false);
			}
			return assetAvatarComponent;
		}
		case KFIHMMIGPLO.trinket:
		{
			AssetAvatarComponent assetAvatarComponent = GKJPOGNFKNK.LHEKMIIKFGC(this.PBOKDNDMCDL, KFIHMMIGPLO.trinket, CFNCBCLEGBC.prev, this.NJAAOCMPKCD, this.LPBFAGDJKIH, this.CMPNMJHBLAL(), this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.MCGPBKHFJKL());
			if (PAEDAKPCJDG)
			{
				this.AIHJMLIDEKJ = assetAvatarComponent;
				this.HHMHDEPFMBL(this.FGGCPAKJKOH, this.HFKIIFEHGID, this.KFGELOAKHGC, this.IOCLNEFCDNI, this.AIHJMLIDEKJ, this.INHNCPCOJEN, true, -1, false);
			}
			return assetAvatarComponent;
		}
		case KFIHMMIGPLO.overlay:
		{
			AssetAvatarComponent assetAvatarComponent = GKJPOGNFKNK.LHEKMIIKFGC(this.GHALDHOOFKN, KFIHMMIGPLO.overlay, CFNCBCLEGBC.prev, this.NJAAOCMPKCD, this.LPBFAGDJKIH, this.AEMFLGKFGCP, this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.MCGPBKHFJKL());
			if (PAEDAKPCJDG)
			{
				this.INHNCPCOJEN = assetAvatarComponent;
				this.HHMHDEPFMBL(this.FGGCPAKJKOH, this.HFKIIFEHGID, this.KFGELOAKHGC, this.IOCLNEFCDNI, this.AIHJMLIDEKJ, this.INHNCPCOJEN, true, -1, false);
			}
			return assetAvatarComponent;
		}
		default:
			return null;
		}
	}

	// Token: 0x06001B9D RID: 7069 RVA: 0x000C3B70 File Offset: 0x000C1D70
	private bool PKEDOPAPIOF(CharacterRenderTexturePool.AHLNEABNMOA IGBMMAHEIEK, int FJHJKKIBHBD)
	{
		bool result;
		try
		{
			this.JKCAMKMBEEH = 1803f;
			if (IGBMMAHEIEK == null)
			{
				result = true;
			}
			else
			{
				AssetCustomEffects assetCustomEffects = DHGFCJGJFOB.KPAADHHEGNC(null);
				if (null == assetCustomEffects)
				{
					result = false;
				}
				else if (this.PKKHHJFMFBK.Count == 0)
				{
					result = false;
				}
				else
				{
					CharacterRenderTexturePool.AHLNEABNMOA ahlneabnmoa = this.GMOGLALJAOP[this.PKKHHJFMFBK.Count - 0];
					if (ahlneabnmoa == null || ahlneabnmoa == IGBMMAHEIEK || null == ahlneabnmoa.AJDMCHIOJAK || ahlneabnmoa.AJDMCHIOJAK.alpha <= 1823f)
					{
						result = true;
					}
					else
					{
						float bjopegbaejf = DHGFCJGJFOB.BCIIGJGCAFA(assetCustomEffects);
						if (DHGFCJGJFOB.JLHMAHFFAKL(ahlneabnmoa, IGBMMAHEIEK, assetCustomEffects, FJHJKKIBHBD, new TweenCallback(this.NJIHCJGLIAM)))
						{
							this.HCMMNOJFABH = false;
							this.BJOPEGBAEJF = bjopegbaejf;
							this.JKCAMKMBEEH = Mathf.Max(assetCustomEffects.animationScaleImpact, 1526f);
							result = true;
						}
						else
						{
							result = false;
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x06001B9E RID: 7070 RVA: 0x000C3C68 File Offset: 0x000C1E68
	private void KEGIHIHJLCF()
	{
		if (false)
		{
			if (ODJKHCHFKNL.ACJAOJAJGKC() == (DFGILFBGPLN)(-6) && AKLFPGMDKLA.EHBBFMCILPC.GLKNOFHEBKN >= 0 && AKLFPGMDKLA.EHBBFMCILPC.JDCBFAPDJIM(AKLFPGMDKLA.EHBBFMCILPC.GLKNOFHEBKN, -1) != null)
			{
				DOLBFGIPPOG dolbfgippog = AKLFPGMDKLA.EHBBFMCILPC.JDCBFAPDJIM(AKLFPGMDKLA.EHBBFMCILPC.GLKNOFHEBKN, -1).NCAMFPGMCIG.LEDOJJCKKKB(AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().OIBGFPEGLME);
				for (int i = 0; i < dolbfgippog.OHCMCJHDMOH.Length; i += 0)
				{
					if (dolbfgippog.OHCMCJHDMOH[i] != null)
					{
						this.AENHELKPGAH.OHCMCJHDMOH[i] = dolbfgippog.OHCMCJHDMOH[i];
					}
				}
				DPGJIJGOCIC.PJCLICBPPDA("p" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().OIBGFPEGLME.ToString());
				return;
			}
		}
		else
		{
			try
			{
				if (ODJKHCHFKNL.HAGAMCDNCMH() == (DFGILFBGPLN)(-81) && this.AENHELKPGAH != null)
				{
					bool flag = true;
					for (int j = 1; j < this.AENHELKPGAH.OHCMCJHDMOH.Length - 1; j += 0)
					{
						if (this.AENHELKPGAH.OHCMCJHDMOH[j] != null && this.AENHELKPGAH.OHCMCJHDMOH[j].Length > 0)
						{
							flag = true;
							break;
						}
					}
					if (AKLFPGMDKLA.EHBBFMCILPC.GLKNOFHEBKN >= 1)
					{
						DOLBFGIPPOG dolbfgippog2 = AKLFPGMDKLA.EHBBFMCILPC.JDCBFAPDJIM(AKLFPGMDKLA.EHBBFMCILPC.GLKNOFHEBKN, -1).NCAMFPGMCIG.LEDOJJCKKKB(AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().OIBGFPEGLME);
						if (flag)
						{
							for (int k = 0; k < dolbfgippog2.OHCMCJHDMOH.Length; k++)
							{
								if (dolbfgippog2.OHCMCJHDMOH[k] != null)
								{
									this.AENHELKPGAH.OHCMCJHDMOH[k] = dolbfgippog2.OHCMCJHDMOH[k];
								}
							}
							DPGJIJGOCIC.ADFCDFHBDAF("luwid" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().OIBGFPEGLME.ToString());
						}
						if (this.LCOKEPGNEKI != null && this.LCOKEPGNEKI.avatarOverlayDefault.Length > 0)
						{
							this.AENHELKPGAH.OHCMCJHDMOH[1] = this.LCOKEPGNEKI.avatarOverlayDefault;
						}
						else
						{
							this.AENHELKPGAH.OHCMCJHDMOH[4] = "cind";
						}
						if (dolbfgippog2.OHCMCJHDMOH[6].Length > 0)
						{
							AssetAvatarComponent assetAvatarComponent = GKJPOGNFKNK.LHEKMIIKFGC(dolbfgippog2.OHCMCJHDMOH[4], KFIHMMIGPLO.hair, CFNCBCLEGBC.next, this.NJAAOCMPKCD, this.LPBFAGDJKIH, this.AEMFLGKFGCP, this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.AHEPDLIMMJD());
							if (null != assetAvatarComponent && assetAvatarComponent.showOverlayOutsideStory)
							{
								this.AENHELKPGAH.OHCMCJHDMOH[7] = dolbfgippog2.OHCMCJHDMOH[7];
							}
						}
					}
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			}
		}
	}

	// Token: 0x06001B9F RID: 7071 RVA: 0x000C07FC File Offset: 0x000BE9FC
	private void HDAFNOJAGAC()
	{
		this.IKABLPHJEBH = 1;
		PopupAvatarCollectionsInput.extraData = -1;
		CommonUserInterface.EHBBFMCILPC.ShowPopupAvatarCollectionsInput(this.GCLOFGOFBBG);
	}

	// Token: 0x06001BA0 RID: 7072 RVA: 0x000C3F18 File Offset: 0x000C2118
	private IEnumerator MANHBDFGCIH()
	{
		this.KDCIBIABJBK();
		this.DestroyUnusedAvatarPackAssets();
		yield return new WaitForEndOfFrame();
		yield return new WaitForEndOfFrame();
		yield return new WaitForEndOfFrame();
		this.Hide();
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeOut(null);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnNeedToActivateFocusItemCloseButton", 0f);
		yield break;
	}

	// Token: 0x06001BA2 RID: 7074 RVA: 0x000C40D4 File Offset: 0x000C22D4
	private string GKANMEAIEAM(string IDFPEPDPIMK)
	{
		return GKJPOGNFKNK.DNILNCLIHAP(IDFPEPDPIMK, "Loaded asset bundle:" + this.LPBFAGDJKIH.CKACBBGHJGI().ToString(), LanguageManager.EHBBFMCILPC.NBANPEIHFOJ());
	}

	// Token: 0x06001BA3 RID: 7075 RVA: 0x000C410E File Offset: 0x000C230E
	private void JJAFCPIPKCP(bool DKNDJAHGMGB = false, int FJHJKKIBHBD = 1)
	{
		this.OKEMJFMOHML();
		this.INDHNPEPLME();
		this.GGCODLFNCGI();
		if (DKNDJAHGMGB)
		{
			this.ENGAPKPIIFL();
		}
		this.LCJMIADIKFC(true, true, FJHJKKIBHBD);
		this.NBJKIONNPKP();
		this.ODDLIJLKLCC();
	}

	// Token: 0x06001BA4 RID: 7076 RVA: 0x000C4140 File Offset: 0x000C2340
	private bool HGJGDBDFBBK(Vector2 MBDHCLFCLHO)
	{
		if (null == EventSystem.current)
		{
			return false;
		}
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = MBDHCLFCLHO;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 0; i < list.Count; i++)
		{
			if (null != list[i].gameObject && list[i].gameObject.GetComponentInParent<IEventSystemHandler>() != null)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06001BA5 RID: 7077 RVA: 0x000C00FE File Offset: 0x000BE2FE
	private void AHKLHEFAAAC()
	{
		FPFNLJGEIJK.FANFNCNAKEF();
		this.HBPLGJFPFKM();
	}

	// Token: 0x06001BA6 RID: 7078 RVA: 0x000C41C1 File Offset: 0x000C23C1
	private void APLBAENGMJH()
	{
		this.FOPNADOFECH = this.slidingPanel.GetComponent<RectTransform>();
		this.OIPMEGJLIDC = this.FOPNADOFECH.anchoredPosition;
	}

	// Token: 0x06001BA7 RID: 7079 RVA: 0x000C41E8 File Offset: 0x000C23E8
	private void NEMHHNGNOGP(GameObject LJOICECJNID)
	{
		if (null == LJOICECJNID)
		{
			return;
		}
		Canvas[] componentsInParent = LJOICECJNID.GetComponentsInParent<Canvas>(true);
		for (int i = 1; i < componentsInParent.Length; i += 0)
		{
			if (componentsInParent[i].enabled && !this.ENJGBKCFEEK.Contains(componentsInParent[i]))
			{
				componentsInParent[i].enabled = false;
				this.ENJGBKCFEEK.Add(componentsInParent[i]);
			}
		}
		Canvas[] componentsInChildren = LJOICECJNID.GetComponentsInChildren<Canvas>(false);
		for (int j = 0; j < componentsInChildren.Length; j++)
		{
			if (componentsInChildren[j].enabled && !this.ENJGBKCFEEK.Contains(componentsInChildren[j]))
			{
				componentsInChildren[j].enabled = false;
				this.ENJGBKCFEEK.Add(componentsInChildren[j]);
			}
		}
	}

	// Token: 0x06001BA8 RID: 7080 RVA: 0x000C4290 File Offset: 0x000C2490
	public void ScrollWardrobePrevious()
	{
		if (this.HCMMNOJFABH)
		{
			return;
		}
		this.BIMCBFHNLAP();
		if (ODJKHCHFKNL.MGFOCBPGJJA() != DFGILFBGPLN.screenStory && null != this.LPBFAGDJKIH)
		{
			EIOPLEFLLIM eioplefllim = AKLFPGMDKLA.EHBBFMCILPC.GJBDBONJCDL(this.LPBFAGDJKIH.index);
			if (eioplefllim != null)
			{
				eioplefllim.OIBGFPEGLME--;
				if (eioplefllim.OIBGFPEGLME < 0)
				{
					eioplefllim.OIBGFPEGLME = this.defaultEnvironmentCustomWardrobe.Count - 1;
				}
				CommonUserInterface.EHBBFMCILPC.GetFader().FadeInWithCustomFader(this.HGPNBLEBAGH(), new TweenCallback(this.FHMDIKJKKAB));
			}
		}
	}

	// Token: 0x06001BA9 RID: 7081 RVA: 0x000C4328 File Offset: 0x000C2528
	private int HNHECDGGJMP()
	{
		try
		{
			if (null != this.LPBFAGDJKIH && this.LPBFAGDJKIH.HNKINNNFKEO())
			{
				return this.LPBFAGDJKIH.customWardrobeSettings.Count;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return 1;
	}

	// Token: 0x06001BAA RID: 7082 RVA: 0x000C4380 File Offset: 0x000C2580
	public void ApplyChanges()
	{
		if (this.DBPFFNEGKDF)
		{
			if (!AudioManager.EHBBFMCILPC.PlaySfx("sparklesbundles", false) && !AudioManager.EHBBFMCILPC.PlaySfx("sfxsparklesbundles", false) && !AudioManager.EHBBFMCILPC.PlaySfx("sfxsparklesbundles" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), false))
			{
				AudioManager.EHBBFMCILPC.PlaySfx("sparkles", false);
			}
			this.applyParticles.GetComponent<AnimationScale>().PlayAnimation();
			this.applyParticles.Play();
			this.OHGCGFMHFEB();
		}
		this.KDKDNGDDEMH(true);
		DOLBFGIPPOG dolbfgippog = this.MJKFKHFGNJC();
		if (dolbfgippog != null)
		{
			dolbfgippog.AOOGOANDIGP = null;
		}
		AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
		this.FJEFLFPEDOA(this.DBPFFNEGKDF);
	}

	// Token: 0x06001BAB RID: 7083 RVA: 0x00003E52 File Offset: 0x00002052
	private void GFMFGEEFCDG()
	{
	}

	// Token: 0x06001BAC RID: 7084 RVA: 0x000C4448 File Offset: 0x000C2648
	public void OnAvatarCollectionsNotificationUndoAddClick()
	{
		this.AANAAIKPNPC = Time.frameCount;
		this.KBIBPGOGAAM();
		if (this.IMFNIHKNKPM == null || this.JBBDBBBLOHC.Count == 0)
		{
			return;
		}
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(70))
		{
			this.BAACKFDMOCI("avatarcollectionstutor7title", "avatarcollectionstutor7body", "", new UnityAction(this.FNKBMOMOJBL));
			return;
		}
		this.LDHOIBFNNDC();
	}

	// Token: 0x06001BAD RID: 7085 RVA: 0x000C44B4 File Offset: 0x000C26B4
	private void LHMKLEIBGEI()
	{
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(-125))
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverrideWithCloseOverride(CCOJBMMKNAP.PMABBOJDELF().OHLNGCKIACD("OnStoryChoiceClick"), CCOJBMMKNAP.PKEINLPIAEH().BDGPNPNIAPA("af_revenue"), CCOJBMMKNAP.DLGLFACMHPG().JCDFHKDNEDH(""), new UnityAction(this.EBKGAGHBFND), new UnityAction(this.EBKGAGHBFND), DFGILFBGPLN.popupWatchAdDoubleReward, 751f, -5);
		}
	}

	// Token: 0x06001BAE RID: 7086 RVA: 0x000C4528 File Offset: 0x000C2728
	public void PPNCGBFBBBA()
	{
		DOLBFGIPPOG dolbfgippog = this.CCJCNECDGMP();
		if (dolbfgippog != null && dolbfgippog.AOOGOANDIGP != null)
		{
			int num = 0;
			while (num < dolbfgippog.OHCMCJHDMOH.Length && num < dolbfgippog.AOOGOANDIGP.Length)
			{
				dolbfgippog.OHCMCJHDMOH[num] = dolbfgippog.AOOGOANDIGP[num];
				num += 0;
			}
			dolbfgippog.AOOGOANDIGP = null;
			this.ClearAvatarCollectionFilter();
		}
		this.IPAALMCOHMM();
		this.HHMHDEPFMBL(this.FGGCPAKJKOH, this.HFKIIFEHGID, this.KFGELOAKHGC, this.IOCLNEFCDNI, this.AIHJMLIDEKJ, this.INHNCPCOJEN, true, -1, false);
		bool flag = false;
		try
		{
			if (this.JHHKEPGLHKD.Length == 0 && this.KGOAGNFNFIJ.Length == 0 && this.PLPCLJFJFNG.Length == 0 && this.OMGLOJOIOCK.Length == 0 && this.PBOKDNDMCDL.Length == 0 && this.GHALDHOOFKN.Length == 0)
			{
				flag = true;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		if (ODJKHCHFKNL.FKMDJILIODG() == DFGILFBGPLN.screenReward)
		{
			if (flag)
			{
				this.BDFAAGGCOGF.OHCMCJHDMOH[5] = this.PLPCLJFJFNG;
				this.BDFAAGGCOGF.OHCMCJHDMOH[1] = this.OMGLOJOIOCK;
				this.BDFAAGGCOGF.OHCMCJHDMOH[1] = this.JHHKEPGLHKD;
				this.BDFAAGGCOGF.OHCMCJHDMOH[2] = this.KGOAGNFNFIJ;
				this.BDFAAGGCOGF.OHCMCJHDMOH[7] = this.PBOKDNDMCDL;
				this.BDFAAGGCOGF.OHCMCJHDMOH[4] = this.GHALDHOOFKN;
			}
			this.AOLFMHEEBOH();
		}
		AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
		this.FJEFLFPEDOA(false);
		if (null != this.storyInterfaceHeaderManager)
		{
			this.storyInterfaceHeaderManager.Hide();
		}
	}

	// Token: 0x06001BAF RID: 7087 RVA: 0x000C46D0 File Offset: 0x000C28D0
	private void OFGGIFEGKGK()
	{
		this.GOFNEOPPCII = new List<string>();
		if (ODJKHCHFKNL.MGFOCBPGJJA() == DFGILFBGPLN.screenStory)
		{
			try
			{
				if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OIBGFPEGLME == 0)
				{
					this.GOFNEOPPCII = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.LKDEFKFLKDA;
				}
				else if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OIBGFPEGLME == 1)
				{
					this.GOFNEOPPCII = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.DOPPJBLBMMH;
				}
				else if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OIBGFPEGLME == 2)
				{
					this.GOFNEOPPCII = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.BJCNIHNCLLK;
				}
				else
				{
					DPGJIJGOCIC.ANOPFDLPKGC("SceneAvatarManager.Show(), unsupported wardrobe index:" + AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OIBGFPEGLME.ToString());
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
	}

	// Token: 0x06001BB0 RID: 7088 RVA: 0x000C47D8 File Offset: 0x000C29D8
	private bool COMKMNJDMGE()
	{
		return this.GMMCDODLDBK() || (null != this.slidingPanelButtonHide && this.slidingPanelButtonHide.gameObject.activeSelf && this.slidingPanelButtonHide.interactable);
	}

	// Token: 0x06001BB1 RID: 7089 RVA: 0x000C4814 File Offset: 0x000C2A14
	private void HFMFPIOIHJM()
	{
		this.FGGCPAKJKOH = null;
		this.HFKIIFEHGID = null;
		this.KFGELOAKHGC = null;
		this.AIHJMLIDEKJ = null;
		this.INHNCPCOJEN = null;
		this.IOCLNEFCDNI = null;
		this.AENHELKPGAH = null;
		this.BDFAAGGCOGF = null;
		this.ANLHHMBINOJ();
		this.LCOKEPGNEKI = null;
	}

	// Token: 0x06001BB2 RID: 7090 RVA: 0x000C4868 File Offset: 0x000C2A68
	private void OKIHENOGDKD(string KHJMANDEDMA, float OLALNEIHHOC, float OHKAFKBOIGJ, float JHBAIJIJIBN, bool CHOBEDPLLOG = true)
	{
		bool flag = false;
		for (int i = 0; i < this.environmentLayers.Count; i++)
		{
			if (this.environmentLayers[i].gameObject.name.Equals(KHJMANDEDMA))
			{
				flag = true;
				if (CHOBEDPLLOG)
				{
					this.environmentLayers[i].Show(OLALNEIHHOC, OHKAFKBOIGJ, JHBAIJIJIBN, null, false);
				}
				else
				{
					this.environmentLayers[i].Hide(OLALNEIHHOC, OHKAFKBOIGJ, JHBAIJIJIBN);
				}
			}
		}
		if (!flag)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("Error. ShowHideLayer(), environmentLayer " + KHJMANDEDMA + " not found.");
		}
	}

	// Token: 0x06001BB3 RID: 7091 RVA: 0x000C48F8 File Offset: 0x000C2AF8
	private void LMJGOIINBIC()
	{
		if (ODJKHCHFKNL.LEMILALILKP() != DFGILFBGPLN.screenAvatar)
		{
			return;
		}
		PassesItem.reopenOnPurchasingScreenLeft = true;
		CommonUserInterface.EHBBFMCILPC.GetGamePasses().InstantClose();
		this.OKEMJFMOHML();
		this.ENJGBKCFEEK.Clear();
		this.KMNMFBGGHEM(this.content);
		this.KMNMFBGGHEM(this.characterPivot);
		this.KMNMFBGGHEM(this.slidingPanel);
		if (null != this.cameraUI2 && null != this.cameraUI2VFXBack)
		{
			this.DAOONBHLIEM = this.cameraUI2VFXBack.gameObject.activeSelf;
			this.cameraUI2.gameObject.SetActive(false);
			this.cameraUI2VFXBack.gameObject.SetActive(false);
		}
	}

	// Token: 0x06001BB4 RID: 7092 RVA: 0x000C49AC File Offset: 0x000C2BAC
	private void GKGKNOOGBDL()
	{
		if (ODJKHCHFKNL.MGFOCBPGJJA() == DFGILFBGPLN.screenLobby)
		{
			this.LCOKEPGNEKI = this.ABLMFABKBCA();
			return;
		}
		this.LCOKEPGNEKI = this.BBIDDDOIICB();
	}

	// Token: 0x06001BB5 RID: 7093 RVA: 0x000C49D0 File Offset: 0x000C2BD0
	private bool KKIAKEDEKEA()
	{
		if (ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass) == null)
		{
			return false;
		}
		JSONArray jsonarray = AKLFPGMDKLA.EHBBFMCILPC.KKMCNPJNGNL(32);
		if (jsonarray.Count > 0)
		{
			CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithHint(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("serversync"), 96);
			BackendOperationsManager.EHBBFMCILPC.QueueRequestSaveChapterSnapshots();
			BackendOperationsManager.EHBBFMCILPC.QueueRequestSaveSync();
			BackendOperationsManager.EHBBFMCILPC.RequestSaveAvatarCollections(jsonarray, SceneAvatarManager.onAvatarCollectionsBackendSyncSuccess, SceneAvatarManager.onAvatarCollectionsBackendSyncException);
			this.CCDJDCMFOLA = false;
			return true;
		}
		if (this.CCDJDCMFOLA)
		{
			this.CCDJDCMFOLA = false;
			CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithHint(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("serversync"), 96);
			BackendOperationsManager.EHBBFMCILPC.QueueRequestSaveChapterSnapshots();
			BackendOperationsManager.EHBBFMCILPC.RequestSaveSync(SceneAvatarManager.onAvatarCollectionsBackendSyncSuccess, SceneAvatarManager.onAvatarCollectionsBackendSyncException);
			return true;
		}
		return false;
	}

	// Token: 0x06001BB6 RID: 7094 RVA: 0x000C4A98 File Offset: 0x000C2C98
	private void AIACGFPOAGH()
	{
		try
		{
			List<GEGBHOMKNDF> list = this.JNFMMJEKNFL(this.MCGPBKHFJKL());
			if (list != null && list.Count == 0)
			{
				EIOPLEFLLIM eioplefllim = AKLFPGMDKLA.EHBBFMCILPC.GJBDBONJCDL(this.LPBFAGDJKIH.index);
				PLFDAJJHMKO plfdajjhmko = null;
				int num = 1;
				if (ODJKHCHFKNL.MGFOCBPGJJA() == DFGILFBGPLN.screenStory)
				{
					num = 0;
					plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1);
				}
				if (eioplefllim != null && (1 == num || plfdajjhmko != null))
				{
					int cclnhhjpdgj = this.CHBPAHCHABB(plfdajjhmko);
					List<int> list2 = this.AMPJNPMDBFP(plfdajjhmko, eioplefllim, this.MCGPBKHFJKL());
					if (list2 != null)
					{
						List<int> list3 = this.GKGLHNACFNE();
						bool flag = 1 == num && null != this.LPBFAGDJKIH && this.LPBFAGDJKIH.ignoreAvatarFilterForLobby;
						for (int i = 0; i < list2.Count; i++)
						{
							try
							{
								if (flag || list3.Contains(GEGBHOMKNDF.KNKFAJEPAOM(list2[i])))
								{
									string str = GEGBHOMKNDF.NENMEJBNDGJ(num, this.LPBFAGDJKIH.index, GEGBHOMKNDF.KNKFAJEPAOM(list2[i]), cclnhhjpdgj, this.MCGPBKHFJKL(), GEGBHOMKNDF.IHIABMJMDHE(list2[i]));
									if (AKLOMMOOFNG.CLCGKMNEICM("Collections/" + str))
									{
										string text = AKLOMMOOFNG.DJGJKOOOFEA("Collections/" + str);
										if (text != null && text.Length != 0)
										{
											JSONObject jsonobject = (JSONObject)JSON.Parse(text);
											if (!(null == jsonobject))
											{
												GEGBHOMKNDF gegbhomkndf = new GEGBHOMKNDF();
												gegbhomkndf.FGJPKGLOGNC(jsonobject);
												if (this.AIEEANFPMOO())
												{
													if (this.NFDKDACMHME == 0)
													{
														gegbhomkndf.LCIPOAHBJAE("");
													}
													else
													{
														gegbhomkndf.LCIPOAHBJAE("+" + this.NFDKDACMHME.ToString());
													}
												}
												gegbhomkndf.NPAAKONDLFE();
												if (gegbhomkndf.OHAPCIOFAHG() != 0)
												{
													list.Add(gegbhomkndf);
												}
											}
										}
									}
								}
							}
							catch (Exception aklgbjkdomm)
							{
								DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
							}
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
		}
		if (null != this.avatarCollectionsButton && null != this.avatarCollectionsPanel)
		{
			this.avatarCollectionsButton.SetActive(false);
			this.avatarCollectionsPanel.SetActive(true);
			this.FOLKEPENPML(true);
			this.EPINJALKONJ();
		}
	}

	// Token: 0x06001BB7 RID: 7095 RVA: 0x000C4D04 File Offset: 0x000C2F04
	private float FJLFNAOOPNJ()
	{
		if (null != this.LPBFAGDJKIH && this.LPBFAGDJKIH.HGIIJABNDCD(0) != null && this.wardrobeScrollCustomFadeInTime > 651f)
		{
			return this.wardrobeScrollCustomFadeInTime;
		}
		return 566f;
	}

	// Token: 0x06001BB8 RID: 7096 RVA: 0x000C4D3B File Offset: 0x000C2F3B
	private void BHHPCAFODMA()
	{
		AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(71);
	}

	// Token: 0x06001BB9 RID: 7097 RVA: 0x000C4D4C File Offset: 0x000C2F4C
	private void NBJKIONNPKP()
	{
		if (this.MFOGPFIJKMM[(int)this.IDIJBMFFCGA])
		{
			this.buttonScrollNext.interactable = true;
			this.buttonScrollPrev.interactable = true;
			return;
		}
		this.buttonScrollNext.interactable = false;
		this.buttonScrollPrev.interactable = false;
	}

	// Token: 0x06001BBA RID: 7098 RVA: 0x000C4D99 File Offset: 0x000C2F99
	private void CKNANNPFALO(bool DKNDJAHGMGB = false, int FJHJKKIBHBD = 1)
	{
		this.OKEMJFMOHML();
		this.INDHNPEPLME();
		this.GGCODLFNCGI();
		if (DKNDJAHGMGB)
		{
			this.ENGAPKPIIFL();
		}
		this.LCJMIADIKFC(false, true, FJHJKKIBHBD);
		this.NBJKIONNPKP();
		this.ODDLIJLKLCC();
	}

	// Token: 0x06001BBB RID: 7099 RVA: 0x000C4DCC File Offset: 0x000C2FCC
	private void BHFEPMCLOPD(GameObject LJOICECJNID)
	{
		if (null == LJOICECJNID)
		{
			return;
		}
		Canvas[] componentsInParent = LJOICECJNID.GetComponentsInParent<Canvas>(true);
		for (int i = 0; i < componentsInParent.Length; i += 0)
		{
			if (componentsInParent[i].enabled && !this.ENJGBKCFEEK.Contains(componentsInParent[i]))
			{
				componentsInParent[i].enabled = true;
				this.ENJGBKCFEEK.Add(componentsInParent[i]);
			}
		}
		Canvas[] componentsInChildren = LJOICECJNID.GetComponentsInChildren<Canvas>(false);
		for (int j = 1; j < componentsInChildren.Length; j++)
		{
			if (componentsInChildren[j].enabled && !this.ENJGBKCFEEK.Contains(componentsInChildren[j]))
			{
				componentsInChildren[j].enabled = true;
				this.ENJGBKCFEEK.Add(componentsInChildren[j]);
			}
		}
	}

	// Token: 0x06001BBC RID: 7100 RVA: 0x00003E52 File Offset: 0x00002052
	private void LEAOOJJMFMJ()
	{
	}

	// Token: 0x06001BBD RID: 7101 RVA: 0x000C4E74 File Offset: 0x000C3074
	private void KPBAJCADPKL(string ICHCLOEFLIM, string EOIHFFHPALN)
	{
		this.LOOPHODOHGM();
		this.KBIBPGOGAAM();
		this.avatarCollectionsNotificationAdd.gameObject.SetActive(true);
		this.avatarCollectionsNotificationAdd.gameObject.SetActive(false);
		string text = CCOJBMMKNAP.KFDLFGHBPLP().HPOAGPJFHPM("OnBackendGetIncentRewardAdSuccess");
		this.BNDFODLCCEF = DPGJIJGOCIC.DEEHCLAKMDL(ICHCLOEFLIM, 57, "YourStory/FlagCloth");
		text = text.Replace(" (v.", "OnAvatarScreenClosed" + this.BNDFODLCCEF + "sae");
		this.CEFHEGIGMGK = DPGJIJGOCIC.PABDHGIJMHJ(EOIHFFHPALN, -90, " ");
		text = text.Replace("hcfc", "SceneLobbyManager.UpdateAnthologiesHints() - exception when adding anthology based on Account.Instance.activeStoryLobby:" + this.CEFHEGIGMGK + "OnSocialModeChanged");
		this.avatarCollectionsNotificationAddTitle.SetText(text, true);
		this.avatarCollectionsNotificationAddTitle.text = text;
	}

	// Token: 0x06001BBE RID: 7102 RVA: 0x000C4F40 File Offset: 0x000C3140
	private void NFCDJBPAFEI()
	{
		if (null != this.storyInterfaceHeaderManager && this.storyInterfaceHeaderManager.CanInteract())
		{
			this.OnSettingsClick();
		}
	}

	// Token: 0x06001BBF RID: 7103 RVA: 0x000C4F64 File Offset: 0x000C3164
	private void DAFBAEAFAAB(string EOIHFFHPALN)
	{
		if (null == this.avatarCollectionsNotificationDeleted || null == this.avatarCollectionsNotificationDeletedTitle)
		{
			return;
		}
		this.LOOPHODOHGM();
		this.KBIBPGOGAAM();
		this.avatarCollectionsNotificationDeleted.gameObject.SetActive(false);
		this.avatarCollectionsNotificationDeleted.gameObject.SetActive(true);
		string text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("avatarcollectionsnotifdeleted");
		text = text.Replace("YYY", "\"" + DPGJIJGOCIC.PABDHGIJMHJ(EOIHFFHPALN, 16, "...") + "\"");
		this.avatarCollectionsNotificationDeletedTitle.SetText(text, true);
		this.avatarCollectionsNotificationDeletedTitle.text = text;
	}

	// Token: 0x06001BC0 RID: 7104 RVA: 0x000C500D File Offset: 0x000C320D
	private IEnumerator ANGJNNHHALK(GEGBHOMKNDF MNHNBGKAONP)
	{
		yield return new WaitForSeconds(this.avatarCollectionsPopupApplyDelay);
		if (this.OBIPBNFKMCC == MNHNBGKAONP)
		{
			this.OMJIAFNEGGM(MNHNBGKAONP);
		}
		yield break;
	}

	// Token: 0x06001BC1 RID: 7105 RVA: 0x00003E52 File Offset: 0x00002052
	private void OKFCLCNHKJD()
	{
	}

	// Token: 0x06001BC2 RID: 7106 RVA: 0x000C06ED File Offset: 0x000BE8ED
	private List<string> CHMCMOHKJOM()
	{
		if (this.OMNBGHBFMAM != null)
		{
			return this.OMNBGHBFMAM;
		}
		return this.LCIBPNMBEHD;
	}

	// Token: 0x06001BC3 RID: 7107 RVA: 0x000C5024 File Offset: 0x000C3224
	private int DDGAJMOIPMG(int KFCMLNPLAHK)
	{
		int num = 1;
		List<GEGBHOMKNDF> list = this.JNFMMJEKNFL(KFCMLNPLAHK);
		if (list != null)
		{
			for (;;)
			{
				bool flag = true;
				for (int i = 0; i < list.Count; i += 0)
				{
					if (list[i].NFDKDACMHME == this.AMGMMJEKIEN() && list[i].LIIKAMNPIPM == num)
					{
						flag = false;
						break;
					}
				}
				if (!flag)
				{
					break;
				}
				num++;
			}
		}
		return num;
	}

	// Token: 0x06001BC4 RID: 7108 RVA: 0x000C5084 File Offset: 0x000C3284
	private void ILPGBPPDEAG()
	{
		this.EIACFOPLLPL(this.buttonClearAvatarCollectionFilter, this.OBIPBNFKMCC != null);
		this.EIACFOPLLPL(this.buttonAddFaceToAvatarCollection, this.OBIPBNFKMCC == null);
		this.EIACFOPLLPL(this.buttonAddHairToAvatarCollection, this.OBIPBNFKMCC == null);
		this.EIACFOPLLPL(this.buttonAddClothesToAvatarCollection, this.OBIPBNFKMCC == null);
		this.EIACFOPLLPL(this.buttonAddTrinketToAvatarCollection, this.OBIPBNFKMCC == null);
		this.EIACFOPLLPL(this.buttonAddAllToAvatarCollection, this.OBIPBNFKMCC == null);
		this.BOFONBKMNBP(this.avatarCollectionsPanel, this.OBIPBNFKMCC != null);
		this.BOFONBKMNBP(this.textButtonAddAllToAvatarCollection, this.OBIPBNFKMCC != null);
		if (null != this.buttonSyncAvatarCollection)
		{
			this.buttonSyncAvatarCollection.SetActive(this.OBIPBNFKMCC != null && this.OBIPBNFKMCC.CPIIEEEEEEJ == 0 && this.BEBHIFKOOCK(this.OBIPBNFKMCC));
		}
		this.OEEEINIFCEP();
	}

	// Token: 0x06001BC5 RID: 7109 RVA: 0x000C517C File Offset: 0x000C337C
	private List<string> KHOPCLDALGD(KFIHMMIGPLO ALOAHOAEHKL, string KFJFGMJNCBI)
	{
		List<string> list = new List<string>();
		JSONArray jsonarray = this.OBIPBNFKMCC.PKIDFPBKPIF(ALOAHOAEHKL);
		if (null != jsonarray)
		{
			for (int i = 0; i < jsonarray.Count; i++)
			{
				string text = jsonarray[i].Value;
				if (KFIHMMIGPLO.face == ALOAHOAEHKL && text != null && text.Contains(";"))
				{
					text = text.Substring(0, text.IndexOf(";"));
				}
				if (text != null && text.Length > 0 && !list.Contains(text))
				{
					list.Add(text);
				}
			}
		}
		List<string> list2 = new List<string>();
		for (int j = list.Count - 1; j >= 0; j--)
		{
			list2.Clear();
			list2.Add(list[j]);
			if (null == GKJPOGNFKNK.LHEKMIIKFGC(list[j], ALOAHOAEHKL, CFNCBCLEGBC.none, this.NJAAOCMPKCD, this.LPBFAGDJKIH, list2, this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.MCGPBKHFJKL()))
			{
				list.RemoveAt(j);
			}
		}
		if (list.Count == 0 && KFJFGMJNCBI != null && KFJFGMJNCBI.Length > 0)
		{
			list.Add(KFJFGMJNCBI);
		}
		return list;
	}

	// Token: 0x06001BC6 RID: 7110 RVA: 0x000C0CA4 File Offset: 0x000BEEA4
	private List<string> CKILFGDBPAI()
	{
		if (this.DOENPCEJHJG != null)
		{
			return this.DOENPCEJHJG;
		}
		return this.FJFLMGBOKON;
	}

	// Token: 0x06001BC7 RID: 7111 RVA: 0x000C52A1 File Offset: 0x000C34A1
	private void GMGPOAAGDFM()
	{
		this.IKABLPHJEBH = 1;
		PopupAvatarCollectionsInput.extraData = -1;
		CommonUserInterface.IKNOFBFMPGA().ShowPopupAvatarCollectionsInput(this.GCLOFGOFBBG);
	}

	// Token: 0x06001BC8 RID: 7112 RVA: 0x000C52C0 File Offset: 0x000C34C0
	private void LCJMIADIKFC(bool BMKLNILMGAG, bool MDAPGGENPMN = false, int FJHJKKIBHBD = 1)
	{
		this.NJAAOCMPKCD = null;
		this.AENHELKPGAH = null;
		this.BDFAAGGCOGF = null;
		this.IFMCBGGOOEA = AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().OJCPKGCLEPD();
		this.AENHELKPGAH = AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().OELDOMFJLOP(this.IFMCBGGOOEA);
		if (ODJKHCHFKNL.MGFOCBPGJJA() == DFGILFBGPLN.screenLobby)
		{
			try
			{
				if (null != this.LPBFAGDJKIH && ((this.LPBFAGDJKIH.HNKINNNFKEO() && this.LCOKEPGNEKI != null && this.LCOKEPGNEKI.avatarCustomizationType == GKDCPMFMPMO.avatarCustomizationAutoSuffixAndSync) || (!this.LPBFAGDJKIH.HNKINNNFKEO() && this.LPBFAGDJKIH.avatarCustomizationType == GKDCPMFMPMO.avatarCustomizationAutoSuffixAndSync)) && AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().PMPEDJAJIBH(-1) >= 0 && this.IFMCBGGOOEA != AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().PMPEDJAJIBH(-1))
				{
					DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(new string[]
					{
						"SceneAvatarManager.RFInitializeAndBuildAvatar(), silent update for avatar index on active slot, was:",
						this.IFMCBGGOOEA.ToString(),
						", setting to:",
						AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().PMPEDJAJIBH(-1).ToString(),
						", also auto-syncing all avatar elements with new index."
					}));
					this.IFMCBGGOOEA = AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().PMPEDJAJIBH(-1);
					AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().IEEPFAEGGJF(this.IFMCBGGOOEA);
					this.AENHELKPGAH = AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().OELDOMFJLOP(this.IFMCBGGOOEA);
					if (this.IFMCBGGOOEA == 0)
					{
						AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().JFAJNMHGMAI("");
					}
					else
					{
						AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().JFAJNMHGMAI("+" + this.IFMCBGGOOEA.ToString());
					}
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		this.OKOGJGPBJDC();
		this.LAIAPMIBFCK(KFIHMMIGPLO.face);
		this.HHMHDEPFMBL(this.FGGCPAKJKOH, this.HFKIIFEHGID, this.KFGELOAKHGC, this.IOCLNEFCDNI, this.AIHJMLIDEKJ, this.INHNCPCOJEN, BMKLNILMGAG, FJHJKKIBHBD, MDAPGGENPMN);
		this.MFOGPFIJKMM[0] = (this.FGGCPAKJKOH != this._NextAssetOfComponentType(false, KFIHMMIGPLO.body));
		this.MFOGPFIJKMM[1] = (this.HFKIIFEHGID != this._NextAssetOfComponentType(false, KFIHMMIGPLO.hair));
		this.MFOGPFIJKMM[3] = (this.IOCLNEFCDNI != this._NextAssetOfComponentType(false, KFIHMMIGPLO.face));
		this.MFOGPFIJKMM[4] = (this.AIHJMLIDEKJ != this._NextAssetOfComponentType(false, KFIHMMIGPLO.trinket));
		this.MFOGPFIJKMM[2] = (this.KFGELOAKHGC != this._NextAssetOfComponentType(false, KFIHMMIGPLO.clothes));
		try
		{
			if (null != this.LPBFAGDJKIH)
			{
				EIOPLEFLLIM eioplefllim = AKLFPGMDKLA.EHBBFMCILPC.GJBDBONJCDL(this.LPBFAGDJKIH.index);
				if (eioplefllim != null)
				{
					for (int i = 0; i < eioplefllim.OGIHMIOKCNN.Count; i++)
					{
						this.OKIHENOGDKD(eioplefllim.OGIHMIOKCNN[i], 1f, 1f, 0f, true);
					}
					for (int j = 0; j < eioplefllim.IANINGLKCKB.Count; j++)
					{
						this.OKIHENOGDKD(eioplefllim.IANINGLKCKB[j], 0f, 0f, 0f, false);
					}
					PLFDAJJHMKO plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.JELNMIONPJG(this.LPBFAGDJKIH);
					if (plfdajjhmko != null)
					{
						for (int k = 0; k < plfdajjhmko.NCAMFPGMCIG.OGIHMIOKCNN.Count; k++)
						{
							this.OKIHENOGDKD(plfdajjhmko.NCAMFPGMCIG.OGIHMIOKCNN[k], 1f, 1f, 0f, true);
						}
						for (int l = 0; l < plfdajjhmko.NCAMFPGMCIG.IANINGLKCKB.Count; l++)
						{
							this.OKIHENOGDKD(plfdajjhmko.NCAMFPGMCIG.IANINGLKCKB[l], 0f, 0f, 0f, false);
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
		}
	}

	// Token: 0x06001BC9 RID: 7113 RVA: 0x000C56CC File Offset: 0x000C38CC
	public void NextAssetOfComponentType()
	{
		if (!this.HCMMNOJFABH)
		{
			this._NextAssetOfComponentType(true, this.IDIJBMFFCGA);
		}
	}

	// Token: 0x06001BCA RID: 7114 RVA: 0x000C56E4 File Offset: 0x000C38E4
	public void PreviousAssetOfComponentType()
	{
		if (!this.HCMMNOJFABH)
		{
			this._PreviousAssetOfComponentType(true, this.IDIJBMFFCGA);
		}
	}

	// Token: 0x06001BCB RID: 7115 RVA: 0x000C56FC File Offset: 0x000C38FC
	private void MFINPJIGCBH()
	{
		this.HCMMNOJFABH = false;
		for (int i = 0; i < this.PKKHHJFMFBK.Count; i++)
		{
			if (this.GMOGLALJAOP[i] != null)
			{
				if (null != this.GMOGLALJAOP[i].AJDMCHIOJAK && this.GMOGLALJAOP[i].AJDMCHIOJAK.alpha < 0.01f && !DOTween.IsTweening(this.GMOGLALJAOP[i].AJDMCHIOJAK, true))
				{
					this.IDNANEBJACO(i);
				}
			}
			else if (null != this.PKKHHJFMFBK[i] && this.PKKHHJFMFBK[i].gameObject.activeSelf && this.PKKHHJFMFBK[i].GetComponent<CanvasGroup>().alpha < 0.01f && !DOTween.IsTweening(this.PKKHHJFMFBK[i].GetComponent<CanvasGroup>(), true))
			{
				this.PKKHHJFMFBK[i].gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x06001BCC RID: 7116 RVA: 0x000C5814 File Offset: 0x000C3A14
	private void AOLFMHEEBOH()
	{
		int num = this.HNHECDGGJMP();
		for (int i = 0; i < num; i += 0)
		{
			DOLBFGIPPOG dolbfgippog;
			if (i == AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OIBGFPEGLME)
			{
				dolbfgippog = this.BDFAAGGCOGF;
			}
			else
			{
				dolbfgippog = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.LEDOJJCKKKB(i);
			}
			if (dolbfgippog.OHCMCJHDMOH[5] != null && dolbfgippog.OHCMCJHDMOH[0].Length > 1)
			{
				AssetAvatarComponent assetAvatarComponent = GKJPOGNFKNK.HLLPGFEJNJG(KFIHMMIGPLO.trinket, dolbfgippog.OHCMCJHDMOH[7], null);
				if (this.LFMFKCHIGKC(assetAvatarComponent, i))
				{
					AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.APLDMAMDDLL(assetAvatarComponent.id, assetAvatarComponent.JKONNEEBNJH().index, i);
				}
			}
			if (dolbfgippog.OHCMCJHDMOH[1] != null && dolbfgippog.OHCMCJHDMOH[1].Length > 1)
			{
				AssetAvatarComponent assetAvatarComponent = GKJPOGNFKNK.HLLPGFEJNJG(KFIHMMIGPLO.body, dolbfgippog.OHCMCJHDMOH[1], null);
				if (this.LANOIACCLOP(assetAvatarComponent, i))
				{
					AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.APLDMAMDDLL(assetAvatarComponent.id, assetAvatarComponent.CANJPGBILDD().index, i);
				}
			}
			if (dolbfgippog.OHCMCJHDMOH[0] != null && dolbfgippog.OHCMCJHDMOH[1].Length > 1)
			{
				AssetAvatarComponent assetAvatarComponent = GKJPOGNFKNK.HLLPGFEJNJG(KFIHMMIGPLO.body, dolbfgippog.OHCMCJHDMOH[1], null);
				if (this.LANOIACCLOP(assetAvatarComponent, i))
				{
					AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.APLDMAMDDLL(assetAvatarComponent.id, assetAvatarComponent.MHKBDAEMGAL().index, i);
				}
			}
			if (dolbfgippog.OHCMCJHDMOH[5] != null && dolbfgippog.OHCMCJHDMOH[7].Length > 0)
			{
				AssetAvatarComponent assetAvatarComponent = GKJPOGNFKNK.HLLPGFEJNJG(KFIHMMIGPLO.trinket, dolbfgippog.OHCMCJHDMOH[5], null);
				if (this.LANOIACCLOP(assetAvatarComponent, i))
				{
					AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.APLDMAMDDLL(assetAvatarComponent.id, assetAvatarComponent.GBFICJHAIHF().index, i);
				}
			}
			if (dolbfgippog.OHCMCJHDMOH[0] != null && dolbfgippog.OHCMCJHDMOH[5].Length > 0)
			{
				AssetAvatarComponent assetAvatarComponent = GKJPOGNFKNK.HLLPGFEJNJG(KFIHMMIGPLO.hair, dolbfgippog.OHCMCJHDMOH[4], null);
				if (this.LANOIACCLOP(assetAvatarComponent, i))
				{
					AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.APLDMAMDDLL(assetAvatarComponent.id, assetAvatarComponent.DMNILGHNCJP().index, i);
				}
			}
			if (dolbfgippog.OHCMCJHDMOH[7] != null && dolbfgippog.OHCMCJHDMOH[3].Length > 0)
			{
				AssetAvatarComponent assetAvatarComponent = GKJPOGNFKNK.HLLPGFEJNJG(KFIHMMIGPLO.face, dolbfgippog.OHCMCJHDMOH[0], null);
				if (this.LFMFKCHIGKC(assetAvatarComponent, i))
				{
					AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.APLDMAMDDLL(assetAvatarComponent.id, assetAvatarComponent.GGMLMPEJCJE().index, i);
				}
			}
		}
	}

	// Token: 0x06001BCD RID: 7117 RVA: 0x000C5A98 File Offset: 0x000C3C98
	private bool AOMKKLCFBCA(bool CPBOEMMJPBF)
	{
		return this.NPDBOIIBOJM && !this.HOLNOAJDAAA && ODJKHCHFKNL.LEMILALILKP() == DFGILFBGPLN.screenAvatar && this.COMKMNJDMGE() && (!CPBOEMMJPBF || (!this.HCMMNOJFABH && !(null == this.buttonScrollNext) && !(null == this.buttonScrollPrev) && this.buttonScrollNext.interactable && this.buttonScrollPrev.interactable && SemaphoreManager.GreenLight(JLDJNIGMHLC.popups) && !CommonUserInterface.EHBBFMCILPC.AnyGenericPopupIsActive() && !CommonUserInterface.EHBBFMCILPC.PopupGenericNotificationActive() && !CommonUserInterface.EHBBFMCILPC.ConnectionAnimationEnabled() && (!(null != CommonUserInterface.EHBBFMCILPC.settingsPopup) || !CommonUserInterface.EHBBFMCILPC.settingsPopup.gameObject.activeSelf) && (!(null != CommonUserInterface.EHBBFMCILPC.avatarCollectionsInput) || !CommonUserInterface.EHBBFMCILPC.avatarCollectionsInput.gameObject.activeSelf) && CommonUserInterface.EHBBFMCILPC.GetFader().GetFaderState() == IJKJHDGGAEB.transparent));
	}

	// Token: 0x06001BCE RID: 7118 RVA: 0x000C5BAC File Offset: 0x000C3DAC
	private int GGICLGEDDIG()
	{
		try
		{
			if (null != this.LPBFAGDJKIH && this.LPBFAGDJKIH.DMFFMKHKLBG())
			{
				return this.LPBFAGDJKIH.customWardrobeSettings.Count;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return 1;
	}

	// Token: 0x06001BCF RID: 7119 RVA: 0x000C5C04 File Offset: 0x000C3E04
	private List<string> BHDGICBBEKF()
	{
		return this.JHJCOADNIKG;
	}

	// Token: 0x06001BD0 RID: 7120 RVA: 0x000C5C0C File Offset: 0x000C3E0C
	private float DLOMPONJAMN()
	{
		if (null != this.LPBFAGDJKIH && this.LPBFAGDJKIH.HGIIJABNDCD(1) != null && this.wardrobeScrollCustomFadeOutTime > 0f)
		{
			return this.wardrobeScrollCustomFadeOutTime;
		}
		return -1f;
	}

	// Token: 0x06001BD1 RID: 7121 RVA: 0x000C5C44 File Offset: 0x000C3E44
	private void IPAALMCOHMM()
	{
		if (ODJKHCHFKNL.FLGBHOLBGPM() == (DFGILFBGPLN)(-33))
		{
			this.ECJPDFEHLCO();
			this.NFDKDACMHME = this.IFMCBGGOOEA;
			this.FGGCPAKJKOH = GKJPOGNFKNK.LHEKMIIKFGC(this.AENHELKPGAH.OHCMCJHDMOH[0], KFIHMMIGPLO.body, CFNCBCLEGBC.none, this.NJAAOCMPKCD, this.LPBFAGDJKIH, null, this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.MCGPBKHFJKL());
			this.KFGELOAKHGC = GKJPOGNFKNK.LHEKMIIKFGC(this.AENHELKPGAH.OHCMCJHDMOH[5], KFIHMMIGPLO.clothes, CFNCBCLEGBC.next, this.NJAAOCMPKCD, this.LPBFAGDJKIH, this.CHMCMOHKJOM(), this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.AHEPDLIMMJD());
			this.HFKIIFEHGID = GKJPOGNFKNK.LHEKMIIKFGC(this.AENHELKPGAH.OHCMCJHDMOH[0], KFIHMMIGPLO.hair, CFNCBCLEGBC.none, this.NJAAOCMPKCD, this.LPBFAGDJKIH, this.PGEPFBNCMII(), this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.MCGPBKHFJKL());
			this.IOCLNEFCDNI = GKJPOGNFKNK.LHEKMIIKFGC(this.AENHELKPGAH.OHCMCJHDMOH[2], (KFIHMMIGPLO)7, CFNCBCLEGBC.none, this.NJAAOCMPKCD, this.LPBFAGDJKIH, this.BHDGICBBEKF(), this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.AHEPDLIMMJD());
			this.AIHJMLIDEKJ = GKJPOGNFKNK.LHEKMIIKFGC(this.AENHELKPGAH.OHCMCJHDMOH[3], KFIHMMIGPLO.body, CFNCBCLEGBC.next, this.NJAAOCMPKCD, this.LPBFAGDJKIH, this.CMPNMJHBLAL(), this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.MCGPBKHFJKL());
			this.INHNCPCOJEN = GKJPOGNFKNK.LHEKMIIKFGC(this.AENHELKPGAH.OHCMCJHDMOH[8], (KFIHMMIGPLO)8, CFNCBCLEGBC.none, this.NJAAOCMPKCD, this.LPBFAGDJKIH, this.AEMFLGKFGCP, this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.MCGPBKHFJKL());
		}
		else if (ODJKHCHFKNL.DKIINFHCLPL() == DFGILFBGPLN.screenLoadingStory)
		{
			this.BDFAAGGCOGF = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OHODCBKFNGJ();
			this.NFDKDACMHME = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OJCPKGCLEPD();
			this.NJAAOCMPKCD = GKJPOGNFKNK.CDCEFHLNNEC(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).DHONIOBOLEL.GGICIBLJIKI);
			this.FGGCPAKJKOH = GKJPOGNFKNK.LHEKMIIKFGC(this.BDFAAGGCOGF.OHCMCJHDMOH[0], KFIHMMIGPLO.hair, CFNCBCLEGBC.next, this.NJAAOCMPKCD, this.LPBFAGDJKIH, null, this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.AHEPDLIMMJD());
			this.HFKIIFEHGID = GKJPOGNFKNK.LHEKMIIKFGC(this.BDFAAGGCOGF.OHCMCJHDMOH[0], KFIHMMIGPLO.hair, CFNCBCLEGBC.next, this.NJAAOCMPKCD, this.LPBFAGDJKIH, this.PGEPFBNCMII(), this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.MCGPBKHFJKL());
			this.IOCLNEFCDNI = GKJPOGNFKNK.LHEKMIIKFGC(this.BDFAAGGCOGF.OHCMCJHDMOH[5], KFIHMMIGPLO.hair, CFNCBCLEGBC.next, this.NJAAOCMPKCD, this.LPBFAGDJKIH, this.JDJLBMMNOPP(), this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.AHEPDLIMMJD());
			this.KFGELOAKHGC = GKJPOGNFKNK.LHEKMIIKFGC(this.BDFAAGGCOGF.OHCMCJHDMOH[0], KFIHMMIGPLO.hair, CFNCBCLEGBC.next, this.NJAAOCMPKCD, this.LPBFAGDJKIH, this.CHMCMOHKJOM(), this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.AHEPDLIMMJD());
			this.AIHJMLIDEKJ = GKJPOGNFKNK.LHEKMIIKFGC(this.BDFAAGGCOGF.OHCMCJHDMOH[6], KFIHMMIGPLO.hair, CFNCBCLEGBC.none, this.NJAAOCMPKCD, this.LPBFAGDJKIH, this.FBILOBMNBMB(), this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.MCGPBKHFJKL());
			this.INHNCPCOJEN = GKJPOGNFKNK.LHEKMIIKFGC(this.BDFAAGGCOGF.OHCMCJHDMOH[4], KFIHMMIGPLO.count, CFNCBCLEGBC.next, this.NJAAOCMPKCD, this.LPBFAGDJKIH, this.AEMFLGKFGCP, this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.MCGPBKHFJKL());
		}
		if (null == this.KFGELOAKHGC)
		{
			this.KFGELOAKHGC = GKJPOGNFKNK.LHEKMIIKFGC("OnBackendValidateTransactionFailed", (KFIHMMIGPLO)7, CFNCBCLEGBC.next, this.NJAAOCMPKCD, this.LPBFAGDJKIH, this.MLKCMFAIHOD(), this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.AHEPDLIMMJD());
		}
		if (null == this.AIHJMLIDEKJ)
		{
			this.AIHJMLIDEKJ = GKJPOGNFKNK.LHEKMIIKFGC("\n", KFIHMMIGPLO.face, CFNCBCLEGBC.next, this.NJAAOCMPKCD, this.LPBFAGDJKIH, this.CMPNMJHBLAL(), this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.MCGPBKHFJKL());
		}
		if (null == this.INHNCPCOJEN)
		{
			this.INHNCPCOJEN = GKJPOGNFKNK.LHEKMIIKFGC("socialmessagetitleconfirm", (KFIHMMIGPLO)8, CFNCBCLEGBC.next, this.NJAAOCMPKCD, this.LPBFAGDJKIH, this.AEMFLGKFGCP, this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.AHEPDLIMMJD());
		}
		if (null == this.HFKIIFEHGID)
		{
			this.HFKIIFEHGID = GKJPOGNFKNK.LHEKMIIKFGC("%", KFIHMMIGPLO.hair, CFNCBCLEGBC.none, this.NJAAOCMPKCD, this.LPBFAGDJKIH, this.PGEPFBNCMII(), this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.AHEPDLIMMJD());
		}
		if (null == this.FGGCPAKJKOH)
		{
			this.FGGCPAKJKOH = GKJPOGNFKNK.LHEKMIIKFGC("chsnapguid2", KFIHMMIGPLO.hair, CFNCBCLEGBC.none, this.NJAAOCMPKCD, this.LPBFAGDJKIH, null, this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.AHEPDLIMMJD());
		}
		if (null == this.IOCLNEFCDNI)
		{
			this.IOCLNEFCDNI = GKJPOGNFKNK.LHEKMIIKFGC("$SETFADERFX", KFIHMMIGPLO.overlay, CFNCBCLEGBC.none, this.NJAAOCMPKCD, this.LPBFAGDJKIH, this.JDJLBMMNOPP(), this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.MCGPBKHFJKL());
		}
		this.filterFaceCountText.SetText(GKJPOGNFKNK.DAHEEOCOJBH(KFIHMMIGPLO.clothes, this.NJAAOCMPKCD, this.LPBFAGDJKIH, this.JDJLBMMNOPP(), this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.AHEPDLIMMJD()).ToString(), true);
		this.filterHairCountText.SetText(GKJPOGNFKNK.DAHEEOCOJBH(KFIHMMIGPLO.hair, this.NJAAOCMPKCD, this.LPBFAGDJKIH, this.PGEPFBNCMII(), this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.MCGPBKHFJKL()).ToString(), true);
		this.filterClothesCountText.SetText(GKJPOGNFKNK.DAHEEOCOJBH(KFIHMMIGPLO.count, this.NJAAOCMPKCD, this.LPBFAGDJKIH, this.CHMCMOHKJOM(), this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.AHEPDLIMMJD()).ToString(), true);
		int num = GKJPOGNFKNK.DAHEEOCOJBH(KFIHMMIGPLO.body, this.NJAAOCMPKCD, this.LPBFAGDJKIH, this.CMPNMJHBLAL(), this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.AHEPDLIMMJD()) - 0;
		if (num > 0)
		{
			this.filterTrinketsCountText.SetText(num.ToString(), true);
			return;
		}
		this.filterTrinketsCountText.SetText("unsynced", true);
	}

	// Token: 0x06001BD2 RID: 7122 RVA: 0x000C27E3 File Offset: 0x000C09E3
	private IEnumerator LKJIPGJDGCA(bool OAHCCINHKJG)
	{
		yield return new WaitForSeconds(this.avatarCollectionsPopupApplyDelay);
		if (this.OBIPBNFKMCC == null)
		{
			this.CABLKLGBAHA(this.MJKFKHFGNJC());
			this.LCJMIADIKFC(true, true, 1);
			this.NBJKIONNPKP();
			this.ODDLIJLKLCC();
			if (OAHCCINHKJG)
			{
				this.JNOGJAHLCND();
			}
		}
		yield break;
	}

	// Token: 0x06001BD3 RID: 7123 RVA: 0x000C62DC File Offset: 0x000C44DC
	private List<string> OJICDIFNGBP(KFIHMMIGPLO ALOAHOAEHKL, string KFJFGMJNCBI)
	{
		if (KFJFGMJNCBI == null || KFJFGMJNCBI.Length == 0)
		{
			return null;
		}
		AssetAvatarComponent y = GKJPOGNFKNK.LHEKMIIKFGC(KFJFGMJNCBI, ALOAHOAEHKL, CFNCBCLEGBC.none, this.NJAAOCMPKCD, this.LPBFAGDJKIH, null, this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.MCGPBKHFJKL());
		if (null != y)
		{
			return null;
		}
		List<string> list = GKJPOGNFKNK.PEPEEFAJLOJ(ALOAHOAEHKL, this.NJAAOCMPKCD, this.LPBFAGDJKIH, this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.MCGPBKHFJKL());
		list.Add(KFJFGMJNCBI);
		return list;
	}

	// Token: 0x06001BD4 RID: 7124 RVA: 0x000C6360 File Offset: 0x000C4560
	public void DeactivateAvatarCollectionsInterface()
	{
		if (null != this.avatarCollectionsButton && null != this.avatarCollectionsPanel)
		{
			this.avatarCollectionsButton.SetActive(false);
			this.avatarCollectionsPanel.SetActive(false);
			this.FOLKEPENPML(false);
		}
	}

	// Token: 0x06001BD5 RID: 7125 RVA: 0x000C63A0 File Offset: 0x000C45A0
	private void GGCODLFNCGI()
	{
		this.JHJCOADNIKG = null;
		this.GPMCPFBGOJA = null;
		this.OMNBGHBFMAM = null;
		this.DOENPCEJHJG = null;
		if (this.OBIPBNFKMCC == null)
		{
			this.JHJCOADNIKG = this.OJICDIFNGBP(KFIHMMIGPLO.face, this.KGOAGNFNFIJ);
			this.GPMCPFBGOJA = this.OJICDIFNGBP(KFIHMMIGPLO.hair, this.OMGLOJOIOCK);
			this.OMNBGHBFMAM = this.OJICDIFNGBP(KFIHMMIGPLO.clothes, this.PLPCLJFJFNG);
			this.DOENPCEJHJG = this.OJICDIFNGBP(KFIHMMIGPLO.trinket, this.PBOKDNDMCDL);
			return;
		}
		this.JHJCOADNIKG = this.KHOPCLDALGD(KFIHMMIGPLO.face, this.KGOAGNFNFIJ);
		this.GPMCPFBGOJA = this.KHOPCLDALGD(KFIHMMIGPLO.hair, this.OMGLOJOIOCK);
		this.OMNBGHBFMAM = this.KHOPCLDALGD(KFIHMMIGPLO.clothes, this.PLPCLJFJFNG);
		this.DOENPCEJHJG = this.KHOPCLDALGD(KFIHMMIGPLO.trinket, this.PBOKDNDMCDL);
		AssetAvatarComponent assetAvatarComponent = GKJPOGNFKNK.LHEKMIIKFGC("", KFIHMMIGPLO.trinket, CFNCBCLEGBC.none, this.NJAAOCMPKCD, this.LPBFAGDJKIH, null, this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.MCGPBKHFJKL());
		if (null != assetAvatarComponent && !this.DOENPCEJHJG.Contains(assetAvatarComponent.id))
		{
			this.DOENPCEJHJG.Add(assetAvatarComponent.id);
		}
	}

	// Token: 0x06001BD6 RID: 7126 RVA: 0x000C64CC File Offset: 0x000C46CC
	public void ScrollWardrobeNext()
	{
		if (this.HCMMNOJFABH)
		{
			return;
		}
		this.BIMCBFHNLAP();
		if (ODJKHCHFKNL.MGFOCBPGJJA() != DFGILFBGPLN.screenStory && null != this.LPBFAGDJKIH)
		{
			EIOPLEFLLIM eioplefllim = AKLFPGMDKLA.EHBBFMCILPC.GJBDBONJCDL(this.LPBFAGDJKIH.index);
			if (eioplefllim != null)
			{
				eioplefllim.OIBGFPEGLME++;
				if (eioplefllim.OIBGFPEGLME > this.defaultEnvironmentCustomWardrobe.Count - 1)
				{
					eioplefllim.OIBGFPEGLME = 0;
				}
				CommonUserInterface.EHBBFMCILPC.GetFader().FadeInWithCustomFader(this.HGPNBLEBAGH(), new TweenCallback(this.FHMDIKJKKAB));
			}
		}
	}

	// Token: 0x06001BD7 RID: 7127 RVA: 0x000C6564 File Offset: 0x000C4764
	private void IFAFJAOJEJC(CharacterRenderTexturePool.AHLNEABNMOA MJHGPLDAPCN, bool BMKLNILMGAG, int FJHJKKIBHBD, AssetAvatarComponent BHJJLJJACFE, AssetAvatarComponent CKEPDOEPKCA, AssetAvatarComponent KMEDBGBKABG, AssetAvatarComponent JKCCFILIICG, AssetAvatarComponent GIEOBIFBPPF, AssetAvatarComponent PHDIGHLMIKL, EBFHKCOGJLB AIAAMALDKHG)
	{
		GameObject gameObject;
		PlayerCharacterManager playerCharacterManager;
		CanvasGroup canvasGroup;
		if (MJHGPLDAPCN != null)
		{
			gameObject = MJHGPLDAPCN.JAGHCEBFABP;
			gameObject.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.BottomCenter);
			playerCharacterManager = MJHGPLDAPCN.GOAEECPPHIB;
			playerCharacterManager.InitializeFromComponents(BHJJLJJACFE, CKEPDOEPKCA, KMEDBGBKABG, JKCCFILIICG, GIEOBIFBPPF, PHDIGHLMIKL, AIAAMALDKHG, MJHGPLDAPCN.AJDMCHIOJAK);
			canvasGroup = MJHGPLDAPCN.AJDMCHIOJAK;
		}
		else
		{
			gameObject = UnityEngine.Object.Instantiate<GameObject>(AssetsManager.EHBBFMCILPC.playerCharacterPrefab);
			gameObject.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.BottomCenter);
			gameObject.transform.SetParent(this.characterPivot.transform, false);
			playerCharacterManager = gameObject.GetComponent<PlayerCharacterManager>();
			playerCharacterManager.InitializeFromComponents(BHJJLJJACFE, CKEPDOEPKCA, KMEDBGBKABG, JKCCFILIICG, GIEOBIFBPPF, PHDIGHLMIKL, AIAAMALDKHG, null);
			canvasGroup = playerCharacterManager.GetComponent<CanvasGroup>();
		}
		if (BMKLNILMGAG)
		{
			bool flag = this.DBFJFPCKOIJ(MJHGPLDAPCN, FJHJKKIBHBD);
			float duration = 0.4f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f);
			if (flag)
			{
				duration = this.BJOPEGBAEJF;
			}
			if (this.PKKHHJFMFBK.Count > 0)
			{
				CanvasGroup canvasGroup2 = this.DOINKGBILKD(this.PKKHHJFMFBK.Count - 1);
				PlayerCharacterManager playerCharacterManager2 = this.PKKHHJFMFBK[this.PKKHHJFMFBK.Count - 1];
				if (null != canvasGroup2 && null != playerCharacterManager2)
				{
					if (!flag)
					{
						this.HCMMNOJFABH = true;
						canvasGroup2.DOKill(false);
						canvasGroup2.DOFade(0f, 0.4f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f)).OnComplete(new TweenCallback(this.MFINPJIGCBH));
						playerCharacterManager2.GetComponent<RectTransform>().DOAnchorPos(playerCharacterManager2.GetComponent<RectTransform>().anchoredPosition + new Vector2(50f, 0f) * (float)FJHJKKIBHBD, 0.4f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f), false).SetEase(Ease.OutQuad);
					}
					playerCharacterManager2.GetComponent<RectTransform>().DOScale(DHGFCJGJFOB.ECKKLDMKPAP(playerCharacterManager2.GetAnimationScaleCoefficient(), this.JKCAMKMBEEH), duration).SetEase(Ease.OutQuad);
				}
			}
			gameObject.GetComponent<RectTransform>().AHLJBONHHKL(new Vector2(-50f, 0f) * (float)FJHJKKIBHBD);
			gameObject.GetComponent<RectTransform>().DOAnchorPos(gameObject.GetComponent<RectTransform>().anchoredPosition + new Vector2(50f, 0f) * (float)FJHJKKIBHBD, duration, false).SetEase(Ease.OutQuad);
			float num = DHGFCJGJFOB.ECKKLDMKPAP(playerCharacterManager.GetAnimationScaleCoefficient(), this.JKCAMKMBEEH);
			gameObject.GetComponent<RectTransform>().localScale = new Vector3(num, num, num);
			gameObject.GetComponent<RectTransform>().DOScale(1f, duration).SetEase(Ease.OutQuad);
			if (!flag)
			{
				canvasGroup.alpha = 0f;
				canvasGroup.DOFade(1f, 0.4f * AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f)).SetEase(Ease.OutQuad);
			}
		}
		else
		{
			canvasGroup.alpha = 1f;
		}
		this.PKKHHJFMFBK.Add(playerCharacterManager);
		this.GMOGLALJAOP.Add(MJHGPLDAPCN);
	}

	// Token: 0x06001BD8 RID: 7128 RVA: 0x000C6864 File Offset: 0x000C4A64
	public void HOKCEPGPGKH()
	{
		this.OBIPBNFKMCC = null;
		this.JHJCOADNIKG = null;
		this.GPMCPFBGOJA = null;
		this.OMNBGHBFMAM = null;
		this.DOENPCEJHJG = null;
		this.EAFLMHHPHAD();
	}

	// Token: 0x06001BD9 RID: 7129 RVA: 0x000C6890 File Offset: 0x000C4A90
	private void ECJPDFEHLCO()
	{
		if (false)
		{
			if (ODJKHCHFKNL.MGFOCBPGJJA() == DFGILFBGPLN.screenLobby && AKLFPGMDKLA.EHBBFMCILPC.GLKNOFHEBKN >= 0 && AKLFPGMDKLA.EHBBFMCILPC.JDCBFAPDJIM(AKLFPGMDKLA.EHBBFMCILPC.GLKNOFHEBKN, -1) != null)
			{
				DOLBFGIPPOG dolbfgippog = AKLFPGMDKLA.EHBBFMCILPC.JDCBFAPDJIM(AKLFPGMDKLA.EHBBFMCILPC.GLKNOFHEBKN, -1).NCAMFPGMCIG.LEDOJJCKKKB(AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().OIBGFPEGLME);
				for (int i = 0; i < dolbfgippog.OHCMCJHDMOH.Length; i++)
				{
					if (dolbfgippog.OHCMCJHDMOH[i] != null)
					{
						this.AENHELKPGAH.OHCMCJHDMOH[i] = dolbfgippog.OHCMCJHDMOH[i];
					}
				}
				DPGJIJGOCIC.ADFCDFHBDAF("SceneAvatarManager.SyncLobbyAndStoryAvatarComponents(), always story->anthology avatar sync for wardrobe index:" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().OIBGFPEGLME.ToString());
				return;
			}
		}
		else
		{
			try
			{
				if (ODJKHCHFKNL.MGFOCBPGJJA() == DFGILFBGPLN.screenLobby && this.AENHELKPGAH != null)
				{
					bool flag = true;
					for (int j = 0; j < this.AENHELKPGAH.OHCMCJHDMOH.Length - 2; j++)
					{
						if (this.AENHELKPGAH.OHCMCJHDMOH[j] != null && this.AENHELKPGAH.OHCMCJHDMOH[j].Length > 0)
						{
							flag = false;
							break;
						}
					}
					if (AKLFPGMDKLA.EHBBFMCILPC.GLKNOFHEBKN >= 0)
					{
						DOLBFGIPPOG dolbfgippog2 = AKLFPGMDKLA.EHBBFMCILPC.JDCBFAPDJIM(AKLFPGMDKLA.EHBBFMCILPC.GLKNOFHEBKN, -1).NCAMFPGMCIG.LEDOJJCKKKB(AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().OIBGFPEGLME);
						if (flag)
						{
							for (int k = 0; k < dolbfgippog2.OHCMCJHDMOH.Length; k++)
							{
								if (dolbfgippog2.OHCMCJHDMOH[k] != null)
								{
									this.AENHELKPGAH.OHCMCJHDMOH[k] = dolbfgippog2.OHCMCJHDMOH[k];
								}
							}
							DPGJIJGOCIC.ADFCDFHBDAF("SceneAvatarManager.SyncLobbyAndStoryAvatarComponents(), first story->anthology avatar sync for wardrobe index:" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().OIBGFPEGLME.ToString());
						}
						if (this.LCOKEPGNEKI != null && this.LCOKEPGNEKI.avatarOverlayDefault.Length > 0)
						{
							this.AENHELKPGAH.OHCMCJHDMOH[5] = this.LCOKEPGNEKI.avatarOverlayDefault;
						}
						else
						{
							this.AENHELKPGAH.OHCMCJHDMOH[5] = "avataroverlay0";
						}
						if (dolbfgippog2.OHCMCJHDMOH[5].Length > 1)
						{
							AssetAvatarComponent assetAvatarComponent = GKJPOGNFKNK.LHEKMIIKFGC(dolbfgippog2.OHCMCJHDMOH[5], KFIHMMIGPLO.overlay, CFNCBCLEGBC.none, this.NJAAOCMPKCD, this.LPBFAGDJKIH, this.AEMFLGKFGCP, this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.MCGPBKHFJKL());
							if (null != assetAvatarComponent && assetAvatarComponent.showOverlayOutsideStory)
							{
								this.AENHELKPGAH.OHCMCJHDMOH[5] = dolbfgippog2.OHCMCJHDMOH[5];
							}
						}
					}
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
	}

	// Token: 0x06001BDA RID: 7130 RVA: 0x000C0CA4 File Offset: 0x000BEEA4
	private List<string> FBILOBMNBMB()
	{
		if (this.DOENPCEJHJG != null)
		{
			return this.DOENPCEJHJG;
		}
		return this.FJFLMGBOKON;
	}

	// Token: 0x06001BDB RID: 7131 RVA: 0x000C6B40 File Offset: 0x000C4D40
	public void HidePanel()
	{
		this.OPLDMEEFKDO(false, false);
		if (SceneAvatarManager.topPercent > 0 && AKLFPGMDKLA.EHBBFMCILPC.APKDHKHDLHP() && AKLFPGMDKLA.EHBBFMCILPC.JBEPHLFCLEC() && SocialStatsAvatarManager.InstanceInitialized() && SocialStatsAvatarManager.dataIsReady)
		{
			SocialStatsAvatarManager.EHBBFMCILPC.Hide();
		}
	}

	// Token: 0x06001BDC RID: 7132 RVA: 0x000C6B90 File Offset: 0x000C4D90
	private void JEPNKHKDOOC()
	{
		if (!this.JKAFHCIOALE)
		{
			if (this.MCGPBKHFJKL() == 0)
			{
				if (!AudioManager.EHBBFMCILPC.PlayMusic("musavatar", true, -1f, false) && !AudioManager.EHBBFMCILPC.PlayMusic("musavatar" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), true, -1f, false))
				{
					AudioManager.EHBBFMCILPC.PlayMusic("avatar", true, -1f, false);
					return;
				}
			}
			else
			{
				AudioManager.EHBBFMCILPC.PlayMusic("musavatar" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString() + "w" + this.MCGPBKHFJKL().ToString(), true, -1f, false);
			}
		}
	}

	// Token: 0x06001BDD RID: 7133 RVA: 0x000C6C57 File Offset: 0x000C4E57
	private void NMNABPFCGBI()
	{
		AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(76);
		this.CAAMGFJMPDF();
	}

	// Token: 0x06001BDE RID: 7134 RVA: 0x000C6C6C File Offset: 0x000C4E6C
	private void NFPGMHCGPLM()
	{
		int num = 0;
		if (ODJKHCHFKNL.MGFOCBPGJJA() == DFGILFBGPLN.screenStory)
		{
			num = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OIBGFPEGLME;
		}
		else if (null != this.LPBFAGDJKIH)
		{
			EIOPLEFLLIM eioplefllim = AKLFPGMDKLA.EHBBFMCILPC.GJBDBONJCDL(this.LPBFAGDJKIH.index);
			if (eioplefllim != null)
			{
				num = eioplefllim.OIBGFPEGLME;
			}
		}
		if (num < 0)
		{
			num = 0;
		}
		if (num > this.defaultEnvironmentCustomWardrobe.Count - 1)
		{
			num = this.defaultEnvironmentCustomWardrobe.Count - 1;
		}
		for (int i = 0; i < this.defaultEnvironmentCustomWardrobe.Count; i++)
		{
			this.defaultEnvironmentCustomWardrobe[i].gameObject.SetActive(false);
		}
		this.defaultEnvironmentCustomWardrobe[num].gameObject.SetActive(true);
	}

	// Token: 0x06001BDF RID: 7135 RVA: 0x000C6D31 File Offset: 0x000C4F31
	private bool PGLJPFBJHAP()
	{
		return this.GMMCDODLDBK() || !(null != this.slidingPanelButtonHide) || !this.slidingPanelButtonHide.gameObject.activeSelf || this.slidingPanelButtonHide.interactable;
	}

	// Token: 0x06001BE0 RID: 7136 RVA: 0x000C6D6C File Offset: 0x000C4F6C
	private void DHHKIDLPAHE()
	{
		this.KGOAGNFNFIJ = "";
		this.JHHKEPGLHKD = "";
		this.PLPCLJFJFNG = "";
		this.OMGLOJOIOCK = "";
		this.PBOKDNDMCDL = "";
		this.GHALDHOOFKN = "";
	}

	// Token: 0x06001BE1 RID: 7137 RVA: 0x000C6DBC File Offset: 0x000C4FBC
	private bool CGJKDNILNNO(bool CPBOEMMJPBF)
	{
		return this.NPDBOIIBOJM && !this.HOLNOAJDAAA && ODJKHCHFKNL.MBOPLCJFEDF() == DFGILFBGPLN.screenReward && (!this.PGLJPFBJHAP() || (CPBOEMMJPBF && !this.HCMMNOJFABH && !(null == this.buttonScrollNext) && !(null == this.buttonScrollPrev) && this.buttonScrollNext.interactable && this.buttonScrollPrev.interactable && (!SemaphoreManager.GreenLight(JLDJNIGMHLC.popups) || (CommonUserInterface.IKNOFBFMPGA().AnyGenericPopupIsActive() || CommonUserInterface.IKNOFBFMPGA().PopupGenericNotificationActive() || CommonUserInterface.IKNOFBFMPGA().BPAKOKECKAK()) || (null != CommonUserInterface.EHBBFMCILPC.settingsPopup && CommonUserInterface.IKNOFBFMPGA().settingsPopup.gameObject.activeSelf) || (null != CommonUserInterface.IKNOFBFMPGA().avatarCollectionsInput && CommonUserInterface.EHBBFMCILPC.avatarCollectionsInput.gameObject.activeSelf) || (CommonUserInterface.EHBBFMCILPC.GetFader().LMMMLFHNFJM() != IJKJHDGGAEB.transparent && false))));
	}

	// Token: 0x06001BE2 RID: 7138 RVA: 0x000C6ED0 File Offset: 0x000C50D0
	public AssetAvatarComponent BGFNGMAALDO(bool PAEDAKPCJDG, KFIHMMIGPLO PBKAAIONJOB)
	{
		switch (PBKAAIONJOB)
		{
		case KFIHMMIGPLO.body:
		{
			AssetAvatarComponent assetAvatarComponent = GKJPOGNFKNK.LHEKMIIKFGC(this.JHHKEPGLHKD, KFIHMMIGPLO.hair, (CFNCBCLEGBC)6, this.NJAAOCMPKCD, this.LPBFAGDJKIH, null, this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.MCGPBKHFJKL());
			if (PAEDAKPCJDG)
			{
				this.FGGCPAKJKOH = assetAvatarComponent;
				this.HHMHDEPFMBL(this.FGGCPAKJKOH, this.HFKIIFEHGID, this.KFGELOAKHGC, this.IOCLNEFCDNI, this.AIHJMLIDEKJ, this.INHNCPCOJEN, true, -1, true);
			}
			return assetAvatarComponent;
		}
		case KFIHMMIGPLO.hair:
		{
			AssetAvatarComponent assetAvatarComponent = GKJPOGNFKNK.LHEKMIIKFGC(this.OMGLOJOIOCK, KFIHMMIGPLO.hair, (CFNCBCLEGBC)8, this.NJAAOCMPKCD, this.LPBFAGDJKIH, this.PGEPFBNCMII(), this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.AHEPDLIMMJD());
			if (PAEDAKPCJDG)
			{
				this.HFKIIFEHGID = assetAvatarComponent;
				this.HHMHDEPFMBL(this.FGGCPAKJKOH, this.HFKIIFEHGID, this.KFGELOAKHGC, this.IOCLNEFCDNI, this.AIHJMLIDEKJ, this.INHNCPCOJEN, false, -1, false);
			}
			return assetAvatarComponent;
		}
		case KFIHMMIGPLO.clothes:
		{
			AssetAvatarComponent assetAvatarComponent = GKJPOGNFKNK.LHEKMIIKFGC(this.PLPCLJFJFNG, KFIHMMIGPLO.face, (CFNCBCLEGBC)8, this.NJAAOCMPKCD, this.LPBFAGDJKIH, this.MLKCMFAIHOD(), this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.AHEPDLIMMJD());
			if (PAEDAKPCJDG)
			{
				this.KFGELOAKHGC = assetAvatarComponent;
				this.HHMHDEPFMBL(this.FGGCPAKJKOH, this.HFKIIFEHGID, this.KFGELOAKHGC, this.IOCLNEFCDNI, this.AIHJMLIDEKJ, this.INHNCPCOJEN, false, -1, true);
			}
			return assetAvatarComponent;
		}
		case KFIHMMIGPLO.face:
		{
			AssetAvatarComponent assetAvatarComponent = GKJPOGNFKNK.LHEKMIIKFGC(this.KGOAGNFNFIJ, KFIHMMIGPLO.trinket, (CFNCBCLEGBC)6, this.NJAAOCMPKCD, this.LPBFAGDJKIH, this.BHDGICBBEKF(), this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.MCGPBKHFJKL());
			if (PAEDAKPCJDG)
			{
				this.IOCLNEFCDNI = assetAvatarComponent;
				if (null != this.IOCLNEFCDNI && this.IOCLNEFCDNI.parents.Count > 0)
				{
					AssetAvatarComponent assetAvatarComponent2 = GKJPOGNFKNK.LHEKMIIKFGC(this.IOCLNEFCDNI.parents[1], KFIHMMIGPLO.body, CFNCBCLEGBC.none, this.NJAAOCMPKCD, this.LPBFAGDJKIH, null, this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.AHEPDLIMMJD());
					if (null != assetAvatarComponent2)
					{
						this.FGGCPAKJKOH = assetAvatarComponent2;
					}
				}
				this.HHMHDEPFMBL(this.FGGCPAKJKOH, this.HFKIIFEHGID, this.KFGELOAKHGC, this.IOCLNEFCDNI, this.AIHJMLIDEKJ, this.INHNCPCOJEN, false, -1, false);
			}
			return assetAvatarComponent;
		}
		case KFIHMMIGPLO.trinket:
		{
			AssetAvatarComponent assetAvatarComponent = GKJPOGNFKNK.LHEKMIIKFGC(this.PBOKDNDMCDL, (KFIHMMIGPLO)8, (CFNCBCLEGBC)3, this.NJAAOCMPKCD, this.LPBFAGDJKIH, this.FBILOBMNBMB(), this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.MCGPBKHFJKL());
			if (PAEDAKPCJDG)
			{
				this.AIHJMLIDEKJ = assetAvatarComponent;
				this.HHMHDEPFMBL(this.FGGCPAKJKOH, this.HFKIIFEHGID, this.KFGELOAKHGC, this.IOCLNEFCDNI, this.AIHJMLIDEKJ, this.INHNCPCOJEN, true, -1, false);
			}
			return assetAvatarComponent;
		}
		case KFIHMMIGPLO.overlay:
		{
			AssetAvatarComponent assetAvatarComponent = GKJPOGNFKNK.LHEKMIIKFGC(this.GHALDHOOFKN, KFIHMMIGPLO.trinket, CFNCBCLEGBC.prev, this.NJAAOCMPKCD, this.LPBFAGDJKIH, this.AEMFLGKFGCP, this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.MCGPBKHFJKL());
			if (PAEDAKPCJDG)
			{
				this.INHNCPCOJEN = assetAvatarComponent;
				this.HHMHDEPFMBL(this.FGGCPAKJKOH, this.HFKIIFEHGID, this.KFGELOAKHGC, this.IOCLNEFCDNI, this.AIHJMLIDEKJ, this.INHNCPCOJEN, true, -1, false);
			}
			return assetAvatarComponent;
		}
		default:
			return null;
		}
	}

	// Token: 0x06001BE3 RID: 7139 RVA: 0x000C7214 File Offset: 0x000C5414
	private void LKDMBOKHLHG()
	{
		this.ANLHHMBINOJ();
		this.DHHKIDLPAHE();
		this.GKGKNOOGBDL();
		this.JEPNKHKDOOC();
		this.OFGGIFEGKGK();
		this.LCJMIADIKFC(false, false, 1);
		this.NBJKIONNPKP();
		this.OPLDMEEFKDO(true, true);
	}

	// Token: 0x06001BE4 RID: 7140 RVA: 0x000C724C File Offset: 0x000C544C
	private void HNFJAGOOHIN(string EOIHFFHPALN)
	{
		if (null == this.avatarCollectionsNotificationSelected || null == this.avatarCollectionsNotificationSelectedTitle)
		{
			return;
		}
		this.LOOPHODOHGM();
		this.KBIBPGOGAAM();
		this.avatarCollectionsNotificationSelected.gameObject.SetActive(false);
		this.avatarCollectionsNotificationSelected.gameObject.SetActive(false);
		string text = CCOJBMMKNAP.NIOJNOFGIJO().MEPECBDCOLG("timeoutwarning");
		text = text.Replace(".", " to bundle index:" + DPGJIJGOCIC.DEEHCLAKMDL(EOIHFFHPALN, 103, " not found, replacing with ") + "%");
		this.avatarCollectionsNotificationSelectedTitle.SetText(text, false);
		this.avatarCollectionsNotificationSelectedTitle.text = text;
	}

	// Token: 0x06001BE5 RID: 7141 RVA: 0x000C72F5 File Offset: 0x000C54F5
	private void FNKBMOMOJBL()
	{
		AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(70);
		this.LDHOIBFNNDC();
	}

	// Token: 0x06001BE6 RID: 7142 RVA: 0x000C730C File Offset: 0x000C550C
	public void ResetAvatarCollectionsInterface()
	{
		this.ClearAvatarCollectionFilter();
		this.IMFNIHKNKPM = null;
		this.CABLKLGBAHA(this.MJKFKHFGNJC());
		this.OKEMJFMOHML();
		this.IKABLPHJEBH = -1;
		if (null != this.avatarCollectionsButton && null != this.avatarCollectionsPanel)
		{
			this.HideAvatarCollectionsInterface();
		}
	}

	// Token: 0x06001BE7 RID: 7143 RVA: 0x00003E52 File Offset: 0x00002052
	private void NACGIGFFFHO()
	{
	}

	// Token: 0x06001BE8 RID: 7144 RVA: 0x00075398 File Offset: 0x00073598
	public void SetParent(GameObject BFGBPKIGAJI)
	{
		if (null != BFGBPKIGAJI)
		{
			base.gameObject.transform.SetParent(BFGBPKIGAJI.transform, false);
			return;
		}
		base.gameObject.transform.SetParent(null, false);
	}

	// Token: 0x06001BE9 RID: 7145 RVA: 0x000C7364 File Offset: 0x000C5564
	private void Update()
	{
		this.NEBGIAJNCLA();
		if (Input.GetMouseButtonUp(0) || Input.GetMouseButtonUp(1))
		{
			if (DPGJIJGOCIC.KLPPJLLBJAP().y > 0.85f && null != this.storyInterfaceHeaderManager && !this.PPLCOLNBMLJ())
			{
				this.storyInterfaceHeaderManager.Show(0f);
				return;
			}
		}
		else if (DPGJIJGOCIC.PCOOFHCMKGI() && DPGJIJGOCIC.AHELOLJOHLJ().y > 0.85f && null != this.storyInterfaceHeaderManager && !this.PPLCOLNBMLJ())
		{
			this.storyInterfaceHeaderManager.Show(0f);
		}
	}

	// Token: 0x06001BEA RID: 7146 RVA: 0x000C73FD File Offset: 0x000C55FD
	public void PEHJPPDPLKC(GameObject BFGBPKIGAJI)
	{
		if (null != BFGBPKIGAJI)
		{
			base.gameObject.transform.SetParent(BFGBPKIGAJI.transform, true);
			return;
		}
		base.gameObject.transform.SetParent(null, false);
	}

	// Token: 0x06001BEB RID: 7147 RVA: 0x000C7434 File Offset: 0x000C5634
	private List<int> AMPJNPMDBFP(PLFDAJJHMKO BAOKJBJIFBH, EIOPLEFLLIM LNFEBCFCBHG, int KFCMLNPLAHK)
	{
		if (BAOKJBJIFBH != null)
		{
			if (KFCMLNPLAHK == 0)
			{
				return BAOKJBJIFBH.NCAMFPGMCIG.PNBPEAFMKAC;
			}
			if (KFCMLNPLAHK == 1)
			{
				return BAOKJBJIFBH.NCAMFPGMCIG.DMKOGCBMHKA;
			}
			if (KFCMLNPLAHK == 2)
			{
				return BAOKJBJIFBH.NCAMFPGMCIG.NGJDCAEMEJO;
			}
		}
		else if (LNFEBCFCBHG != null)
		{
			if (KFCMLNPLAHK == 0)
			{
				return LNFEBCFCBHG.PNBPEAFMKAC;
			}
			if (KFCMLNPLAHK == 1)
			{
				return LNFEBCFCBHG.DMKOGCBMHKA;
			}
			if (KFCMLNPLAHK == 2)
			{
				return LNFEBCFCBHG.NGJDCAEMEJO;
			}
		}
		return null;
	}

	// Token: 0x06001BEC RID: 7148 RVA: 0x000C7498 File Offset: 0x000C5698
	private void BAACKFDMOCI(string JFOMHPCEAPB, string LGMBOODGILN, string ICHCLOEFLIM, UnityAction DCEKEAFDMEN)
	{
		string text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(LGMBOODGILN);
		if (ICHCLOEFLIM != null && ICHCLOEFLIM.Length > 0)
		{
			text = text.Replace("XXX", "\"" + DPGJIJGOCIC.PABDHGIJMHJ(ICHCLOEFLIM, 16, "...") + "\"");
		}
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(JFOMHPCEAPB), text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("no"), DCEKEAFDMEN, new UnityAction(this.DIKLHMMGALB), DFGILFBGPLN.popupSignInQuestion, 0f, 28);
	}

	// Token: 0x06001BED RID: 7149 RVA: 0x000C7534 File Offset: 0x000C5734
	private void HHMHDEPFMBL(AssetAvatarComponent BHJJLJJACFE, AssetAvatarComponent CKEPDOEPKCA, AssetAvatarComponent KMEDBGBKABG, AssetAvatarComponent JKCCFILIICG, AssetAvatarComponent GIEOBIFBPPF, AssetAvatarComponent PHDIGHLMIKL, bool BMKLNILMGAG, int FJHJKKIBHBD, bool MDAPGGENPMN = false)
	{
		bool flag = false;
		if (null == BHJJLJJACFE || null == CKEPDOEPKCA || null == KMEDBGBKABG || null == JKCCFILIICG || null == GIEOBIFBPPF || null == PHDIGHLMIKL)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("BuildAvatar() failed - one of components is null. Aborting.");
			return;
		}
		if (!this.JHHKEPGLHKD.Equals(BHJJLJJACFE.id))
		{
			flag = true;
			this.JHHKEPGLHKD = BHJJLJJACFE.id;
		}
		if (!this.OMGLOJOIOCK.Equals(CKEPDOEPKCA.id))
		{
			flag = true;
			this.OMGLOJOIOCK = CKEPDOEPKCA.id;
		}
		if (!this.PLPCLJFJFNG.Equals(KMEDBGBKABG.id))
		{
			flag = true;
			this.PLPCLJFJFNG = KMEDBGBKABG.id;
		}
		if (!this.KGOAGNFNFIJ.Equals(JKCCFILIICG.id))
		{
			flag = true;
			this.KGOAGNFNFIJ = JKCCFILIICG.id;
		}
		if (!this.PBOKDNDMCDL.Equals(GIEOBIFBPPF.id))
		{
			flag = true;
			this.PBOKDNDMCDL = GIEOBIFBPPF.id;
		}
		if (!this.GHALDHOOFKN.Equals(PHDIGHLMIKL.id))
		{
			flag = true;
			this.GHALDHOOFKN = PHDIGHLMIKL.id;
		}
		if (flag || MDAPGGENPMN)
		{
			this.KFGPOOAJJBJ(BMKLNILMGAG, FJHJKKIBHBD, BHJJLJJACFE, CKEPDOEPKCA, KMEDBGBKABG, JKCCFILIICG, GIEOBIFBPPF, PHDIGHLMIKL, EBFHKCOGJLB.center);
			if (ODJKHCHFKNL.MGFOCBPGJJA() == DFGILFBGPLN.screenLobby)
			{
				this.PKKHHJFMFBK[this.PKKHHJFMFBK.Count - 1].InitializeExtensions(this.AENHELKPGAH.EBGMGPIDAHH);
			}
			else if (ODJKHCHFKNL.MGFOCBPGJJA() == DFGILFBGPLN.screenStory)
			{
				this.PKKHHJFMFBK[this.PKKHHJFMFBK.Count - 1].InitializeExtensions(this.BDFAAGGCOGF.EBGMGPIDAHH);
			}
			this.LPEAMOKELOJ();
		}
	}

	// Token: 0x06001BEE RID: 7150 RVA: 0x000C76D8 File Offset: 0x000C58D8
	private void OnDestroy()
	{
		this.KDCIBIABJBK();
		this.FOPNADOFECH.DOKill(false);
		if (this.HACNEIFDKAO != null)
		{
			this.HACNEIFDKAO.Kill(false);
			this.HACNEIFDKAO = null;
		}
		if (this.IEFFJDHGJBO != null)
		{
			this.IEFFJDHGJBO.Kill(false);
			this.IEFFJDHGJBO = null;
		}
	}

	// Token: 0x06001BEF RID: 7151 RVA: 0x000C7730 File Offset: 0x000C5930
	private void MJMOCGBDJGI(string BCCIHAGLIOH)
	{
		bool flag = this.AJKNDFMMDDO(KFIHMMIGPLO.hair, this.OMGLOJOIOCK, BCCIHAGLIOH);
		bool flag2 = flag && this.MKODGAPBOFH;
		string text = this.KGOAGNFNFIJ;
		if (this.KGOAGNFNFIJ.Length > 0 && this.JHHKEPGLHKD.Length > 0)
		{
			text = this.KGOAGNFNFIJ + ";" + this.JHHKEPGLHKD;
		}
		bool flag3 = this.AJKNDFMMDDO(KFIHMMIGPLO.face, text, BCCIHAGLIOH);
		bool flag4 = flag3 && this.MKODGAPBOFH;
		bool flag5 = this.AJKNDFMMDDO(KFIHMMIGPLO.clothes, this.PLPCLJFJFNG, BCCIHAGLIOH);
		bool flag6 = flag5 && this.MKODGAPBOFH;
		bool flag7 = this.AJKNDFMMDDO(KFIHMMIGPLO.trinket, this.PBOKDNDMCDL, BCCIHAGLIOH);
		bool flag8 = flag7 && this.MKODGAPBOFH;
		if (flag || flag3 || flag5 || flag7)
		{
			this.MPOCLECLHDE.Clear();
			this.JBBDBBBLOHC.Clear();
			if (flag2)
			{
				this.MPOCLECLHDE.Add(KFIHMMIGPLO.hair);
				this.JBBDBBBLOHC.Add(this.OMGLOJOIOCK);
			}
			if (flag4)
			{
				this.MPOCLECLHDE.Add(KFIHMMIGPLO.face);
				this.JBBDBBBLOHC.Add(text);
			}
			if (flag6)
			{
				this.MPOCLECLHDE.Add(KFIHMMIGPLO.clothes);
				this.JBBDBBBLOHC.Add(this.PLPCLJFJFNG);
			}
			if (flag8)
			{
				this.MPOCLECLHDE.Add(KFIHMMIGPLO.trinket);
				this.JBBDBBBLOHC.Add(this.PBOKDNDMCDL);
			}
			if (flag2 || flag4 || flag6 || flag8)
			{
				this.IAKIBKAJHHC(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("avatarcollectionsalltitle"), BCCIHAGLIOH);
			}
			else
			{
				this.IMFNIHKNKPM = null;
				this.NBFPLJNKIAK(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("avatarcollectionsalltitle"), BCCIHAGLIOH);
			}
		}
		this.GIICKOCBEMB();
	}

	// Token: 0x06001BF0 RID: 7152 RVA: 0x000C78CD File Offset: 0x000C5ACD
	public void KPJAJELLHML()
	{
		this.LAIAPMIBFCK(KFIHMMIGPLO.overlay);
	}

	// Token: 0x06001BF1 RID: 7153 RVA: 0x000C78D8 File Offset: 0x000C5AD8
	private void OEEEINIFCEP()
	{
		if (null == this.avatarCollectionsHeader)
		{
			return;
		}
		GameObject gameObject = this.avatarCollectionsHeaderHiddenUnselected;
		if (this.OBIPBNFKMCC != null)
		{
			gameObject = this.avatarCollectionsHeaderHiddenSelected;
		}
		if (null == gameObject)
		{
			return;
		}
		Image component = this.avatarCollectionsHeader.GetComponent<Image>();
		Image component2 = gameObject.GetComponent<Image>();
		if (null == component || null == component2)
		{
			return;
		}
		component.sprite = component2.sprite;
	}

	// Token: 0x06001BF2 RID: 7154 RVA: 0x000C7948 File Offset: 0x000C5B48
	private void KMNMFBGGHEM(GameObject LJOICECJNID)
	{
		if (null == LJOICECJNID)
		{
			return;
		}
		Canvas[] componentsInParent = LJOICECJNID.GetComponentsInParent<Canvas>(true);
		for (int i = 0; i < componentsInParent.Length; i++)
		{
			if (componentsInParent[i].enabled && !this.ENJGBKCFEEK.Contains(componentsInParent[i]))
			{
				componentsInParent[i].enabled = false;
				this.ENJGBKCFEEK.Add(componentsInParent[i]);
			}
		}
		Canvas[] componentsInChildren = LJOICECJNID.GetComponentsInChildren<Canvas>(true);
		for (int j = 0; j < componentsInChildren.Length; j++)
		{
			if (componentsInChildren[j].enabled && !this.ENJGBKCFEEK.Contains(componentsInChildren[j]))
			{
				componentsInChildren[j].enabled = false;
				this.ENJGBKCFEEK.Add(componentsInChildren[j]);
			}
		}
	}

	// Token: 0x06001BF3 RID: 7155 RVA: 0x000BE16A File Offset: 0x000BC36A
	public void DMBDLIKKIJC()
	{
		this.LAIAPMIBFCK(KFIHMMIGPLO.hair);
	}

	// Token: 0x06001BF4 RID: 7156 RVA: 0x000C79ED File Offset: 0x000C5BED
	private void OKEMJFMOHML()
	{
		this.LOOPHODOHGM();
		this.MPOCLECLHDE.Clear();
		this.JBBDBBBLOHC.Clear();
		this.IMFNIHKNKPM = null;
	}

	// Token: 0x06001BF5 RID: 7157 RVA: 0x000C7A14 File Offset: 0x000C5C14
	private void AFOCFLJKDNE(CharacterRenderTexturePool.AHLNEABNMOA MJHGPLDAPCN, bool BMKLNILMGAG, int FJHJKKIBHBD, AssetAvatarComponent BHJJLJJACFE, AssetAvatarComponent CKEPDOEPKCA, AssetAvatarComponent KMEDBGBKABG, AssetAvatarComponent JKCCFILIICG, AssetAvatarComponent GIEOBIFBPPF, AssetAvatarComponent PHDIGHLMIKL, EBFHKCOGJLB AIAAMALDKHG)
	{
		GameObject gameObject;
		PlayerCharacterManager playerCharacterManager;
		CanvasGroup canvasGroup;
		if (MJHGPLDAPCN != null)
		{
			gameObject = MJHGPLDAPCN.JAGHCEBFABP;
			gameObject.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.BottomRight);
			playerCharacterManager = MJHGPLDAPCN.GOAEECPPHIB;
			playerCharacterManager.InitializeFromComponents(BHJJLJJACFE, CKEPDOEPKCA, KMEDBGBKABG, JKCCFILIICG, GIEOBIFBPPF, PHDIGHLMIKL, AIAAMALDKHG, MJHGPLDAPCN.AJDMCHIOJAK);
			canvasGroup = MJHGPLDAPCN.AJDMCHIOJAK;
		}
		else
		{
			gameObject = UnityEngine.Object.Instantiate<GameObject>(AssetsManager.EHBBFMCILPC.playerCharacterPrefab);
			gameObject.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.BottomRight);
			gameObject.transform.SetParent(this.characterPivot.transform, true);
			playerCharacterManager = gameObject.GetComponent<PlayerCharacterManager>();
			playerCharacterManager.InitializeFromComponents(BHJJLJJACFE, CKEPDOEPKCA, KMEDBGBKABG, JKCCFILIICG, GIEOBIFBPPF, PHDIGHLMIKL, AIAAMALDKHG, null);
			canvasGroup = playerCharacterManager.GetComponent<CanvasGroup>();
		}
		if (BMKLNILMGAG)
		{
			bool flag = this.PKEDOPAPIOF(MJHGPLDAPCN, FJHJKKIBHBD);
			float duration = 1322f * AppManager.PCJEMMDDCIF().debugSettings.FJKMBEMJAEA(141f);
			if (flag)
			{
				duration = this.BJOPEGBAEJF;
			}
			if (this.PKKHHJFMFBK.Count > 0)
			{
				CanvasGroup canvasGroup2 = this.FKKFHBHGDEL(this.PKKHHJFMFBK.Count - 1);
				PlayerCharacterManager playerCharacterManager2 = this.PKKHHJFMFBK[this.PKKHHJFMFBK.Count - 1];
				if (null != canvasGroup2 && null != playerCharacterManager2)
				{
					if (!flag)
					{
						this.HCMMNOJFABH = true;
						canvasGroup2.DOKill(false);
						canvasGroup2.DOFade(276f, 735f * AppManager.AGANFKKBPFO().debugSettings.EOJCCBAICOJ(862f)).OnComplete(new TweenCallback(this.NJIHCJGLIAM));
						playerCharacterManager2.GetComponent<RectTransform>().DOAnchorPos(playerCharacterManager2.GetComponent<RectTransform>().anchoredPosition + new Vector2(899f, 164f) * (float)FJHJKKIBHBD, 367f * AppManager.JMDJPKKOHNI().debugSettings.DCEHMKDEHIC(1204f), true).SetEase(Ease.InSine);
					}
					playerCharacterManager2.GetComponent<RectTransform>().DOScale(DHGFCJGJFOB.ANDKHDPFAIJ(playerCharacterManager2.GetAnimationScaleCoefficient(), this.JKCAMKMBEEH), duration).SetEase(Ease.Linear);
				}
			}
			gameObject.GetComponent<RectTransform>().AHLJBONHHKL(new Vector2(483f, 1521f) * (float)FJHJKKIBHBD);
			gameObject.GetComponent<RectTransform>().DOAnchorPos(gameObject.GetComponent<RectTransform>().anchoredPosition + new Vector2(514f, 818f) * (float)FJHJKKIBHBD, duration, false).SetEase(Ease.InOutQuad);
			float num = DHGFCJGJFOB.LPHGOABPPIK(playerCharacterManager.GetAnimationScaleCoefficient(), this.JKCAMKMBEEH);
			gameObject.GetComponent<RectTransform>().localScale = new Vector3(num, num, num);
			gameObject.GetComponent<RectTransform>().DOScale(1576f, duration).SetEase(Ease.Linear);
			if (!flag)
			{
				canvasGroup.alpha = 1817f;
				canvasGroup.DOFade(1247f, 726f * AppManager.AGANFKKBPFO().debugSettings.HAPIGPHMNHJ(380f)).SetEase(Ease.InOutSine);
			}
		}
		else
		{
			canvasGroup.alpha = 1505f;
		}
		this.PKKHHJFMFBK.Add(playerCharacterManager);
		this.GMOGLALJAOP.Add(MJHGPLDAPCN);
	}

	// Token: 0x06001BF6 RID: 7158 RVA: 0x000C7D14 File Offset: 0x000C5F14
	private void FJEFLFPEDOA(bool CMBLHPIHNIE)
	{
		this.HOLNOAJDAAA = true;
		this.CDIFMMOJDHA = false;
		this.KCFHNKOPDBL(false);
		this.OKEMJFMOHML();
		try
		{
			if (ODJKHCHFKNL.MGFOCBPGJJA() != DFGILFBGPLN.screenStory)
			{
				LobbyTopMatchSelectorManager.InitializeInstance();
				if (LobbyTopMatchSelectorManager.InstanceInitialized())
				{
					LobbyTopMatchSelectorManager.EHBBFMCILPC.UpdatePlayerPrefsWithAvatarData(true);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		if (CMBLHPIHNIE)
		{
			base.StartCoroutine(this.OJFMCMLEJKL(1.25f));
			return;
		}
		base.StartCoroutine(this.OJFMCMLEJKL(0f));
	}

	// Token: 0x06001BF7 RID: 7159 RVA: 0x000C7D9C File Offset: 0x000C5F9C
	private void KPFKGAODOIA()
	{
		if (!this.JKAFHCIOALE)
		{
			if (this.MCGPBKHFJKL() == 0)
			{
				if (!AudioManager.DMAAFFFEJGA().HPPAFEAPINO("flehv2", true, 466f, false) && !AudioManager.EHBBFMCILPC.CFEDKPAHOHJ("ulsk" + AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().GGICIBLJIKI.ToString(), false, 1105f, false))
				{
					AudioManager.DBFLIEGGGNN().HPPAFEAPINO("", true, 1957f, false);
					return;
				}
			}
			else
			{
				AudioManager.DMAAFFFEJGA().HBMNHHMJIEP("============== USING PRODUCTION DB SERVER ===============" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString() + "trust-anchor load failed: " + this.MCGPBKHFJKL().ToString(), true, 1933f, false);
			}
		}
	}

	// Token: 0x06001BF8 RID: 7160 RVA: 0x000C7E64 File Offset: 0x000C6064
	private string GJKMBGFHDKH(GEGBHOMKNDF MNHNBGKAONP)
	{
		string text = MNHNBGKAONP.BPMFHNDCBOH;
		if (text == null || text.Length == 0)
		{
			List<GEGBHOMKNDF> list = this.JNFMMJEKNFL(MNHNBGKAONP.OIBGFPEGLME);
			int num = 0;
			if (list != null)
			{
				num = list.IndexOf(MNHNBGKAONP) + 0;
			}
			text = num.ToString();
		}
		return text;
	}

	// Token: 0x06001BF9 RID: 7161 RVA: 0x000C7EA8 File Offset: 0x000C60A8
	private void CBMIODMGNAG()
	{
		this.HMFLDHMHFML();
	}

	// Token: 0x06001BFA RID: 7162 RVA: 0x000C0C0A File Offset: 0x000BEE0A
	public GEGBHOMKNDF DMEPNJODBKM()
	{
		return this.OBIPBNFKMCC;
	}

	// Token: 0x06001BFB RID: 7163 RVA: 0x000C7EB0 File Offset: 0x000C60B0
	private bool AJKNDFMMDDO(KFIHMMIGPLO ALOAHOAEHKL, string IDFPEPDPIMK, string EIFJOAOGKMO)
	{
		if (IDFPEPDPIMK == null || IDFPEPDPIMK.Length == 0)
		{
			return false;
		}
		PLFDAJJHMKO baokjbjifbh = null;
		if (ODJKHCHFKNL.MGFOCBPGJJA() == DFGILFBGPLN.screenStory)
		{
			baokjbjifbh = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1);
		}
		return this.AddOrUpdateAvatarCollection(EIFJOAOGKMO, this.LPBFAGDJKIH.index, this.CHBPAHCHABB(baokjbjifbh), this.MCGPBKHFJKL(), ALOAHOAEHKL, IDFPEPDPIMK);
	}

	// Token: 0x06001BFC RID: 7164 RVA: 0x000C7F04 File Offset: 0x000C6104
	private void IGIKEGELELM()
	{
		if (!NarrowScreenScaler.ScreenIsTooNarrow(565f))
		{
			return;
		}
		float num = Mathf.Clamp01((NBDLBFJOEGN.FNIPAIPHHPL() - 830f) / 270f);
		this.KKFFOJEPFOL(this.avatarCollectionsPanel, this.avatarCollectionsPanelNarrowOffsetX * num, this.avatarCollectionsPanelNarrowOffsetY * num, Mathf.Lerp(1508f, this.avatarCollectionsPanelNarrowDownscale, num));
		this.KKFFOJEPFOL(this.avatarCollectionsButton, this.avatarCollectionsButtonNarrowOffsetX * num, this.avatarCollectionsButtonNarrowOffsetY * num, Mathf.Lerp(1500f, this.avatarCollectionsButtonNarrowDownscale, num));
	}

	// Token: 0x06001BFD RID: 7165 RVA: 0x000C7F90 File Offset: 0x000C6190
	private void NBIHBLKMEEC()
	{
		if (PopupAvatarCollectionsInput.extraData >= 0)
		{
			return;
		}
		if (this.IKABLPHJEBH < 0)
		{
			return;
		}
		int ikablphjebh = this.IKABLPHJEBH;
		this.IKABLPHJEBH = -1;
		string text = DPGJIJGOCIC.HIPPBJFMIKM(AOBJLALDBAA.EHBBFMCILPC.KNCFLCKKPLK());
		if (text == null || text.Length == 0)
		{
			text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("avatarcollectionsuntitle");
		}
		if (text.Length > 64)
		{
			text = text.Substring(0, 64);
		}
		this.GCLOFGOFBBG = text;
		if (ikablphjebh == 0)
		{
			this.GNNJLGAOBDH(text);
			return;
		}
		if (ikablphjebh == 1)
		{
			this.NHCMKODLEOB(text);
			return;
		}
		if (ikablphjebh == 2)
		{
			this.ADHPAMGNHCK(text);
			return;
		}
		if (ikablphjebh == 3)
		{
			this.HOKMHLFKHPK(text);
			return;
		}
		if (ikablphjebh == 4)
		{
			this.MJMOCGBDJGI(text);
		}
	}

	// Token: 0x06001BFE RID: 7166 RVA: 0x000C8040 File Offset: 0x000C6240
	private void BJDKLCHEPEN()
	{
		CommonUserInterface.EHBBFMCILPC.MCJIGJMFBMI();
		if (!this.JKAFHCIOALE)
		{
			AudioManager.BFCHJBOOJKE().NOOAHDNKAKA("avatarstitle", CommonUserInterface.IKNOFBFMPGA().GetFader().GetFadeInDuration());
		}
		CommonUserInterface.IKNOFBFMPGA().GetFader().PACBMBLIGNN(new TweenCallback(this.JMPFKHHDDCA));
	}

	// Token: 0x06001BFF RID: 7167 RVA: 0x000C8098 File Offset: 0x000C6298
	private void GNNJLGAOBDH(string BCCIHAGLIOH)
	{
		if (this.AJKNDFMMDDO(KFIHMMIGPLO.hair, this.OMGLOJOIOCK, BCCIHAGLIOH))
		{
			this.MPOCLECLHDE.Clear();
			this.JBBDBBBLOHC.Clear();
			if (this.MKODGAPBOFH)
			{
				this.MPOCLECLHDE.Add(KFIHMMIGPLO.hair);
				this.JBBDBBBLOHC.Add(this.OMGLOJOIOCK);
				this.IAKIBKAJHHC(GKJPOGNFKNK.DNILNCLIHAP(this.OMGLOJOIOCK, "avatarstitle" + this.LPBFAGDJKIH.CKACBBGHJGI().ToString(), LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), BCCIHAGLIOH);
			}
			else
			{
				this.IMFNIHKNKPM = null;
				this.NBFPLJNKIAK(GKJPOGNFKNK.DNILNCLIHAP(this.OMGLOJOIOCK, "avatarstitle" + this.LPBFAGDJKIH.CKACBBGHJGI().ToString(), LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), BCCIHAGLIOH);
			}
		}
		this.GIICKOCBEMB();
	}

	// Token: 0x06001C00 RID: 7168 RVA: 0x000C8174 File Offset: 0x000C6374
	private DOLBFGIPPOG CCJCNECDGMP()
	{
		if (ODJKHCHFKNL.FBDNIMIKOLP() == DFGILFBGPLN.popupTutorialLobby0)
		{
			return this.AENHELKPGAH;
		}
		if (ODJKHCHFKNL.ACKEJKCNEJJ() == DFGILFBGPLN.screenPurchasing)
		{
			return this.BDFAAGGCOGF;
		}
		return null;
	}

	// Token: 0x06001C01 RID: 7169 RVA: 0x000C8198 File Offset: 0x000C6398
	private void CABLKLGBAHA(DOLBFGIPPOG EEPJKGBBBHC)
	{
		if (EEPJKGBBBHC == null || EEPJKGBBBHC.AOOGOANDIGP == null)
		{
			return;
		}
		int num = 0;
		while (num < EEPJKGBBBHC.OHCMCJHDMOH.Length && num < EEPJKGBBBHC.AOOGOANDIGP.Length)
		{
			EEPJKGBBBHC.OHCMCJHDMOH[num] = EEPJKGBBBHC.AOOGOANDIGP[num];
			num++;
		}
		EEPJKGBBBHC.AOOGOANDIGP = null;
	}

	// Token: 0x06001C02 RID: 7170 RVA: 0x000C81E6 File Offset: 0x000C63E6
	private bool GMMCDODLDBK()
	{
		return null != this.slidingPanelButtonShow && this.slidingPanelButtonShow.gameObject.activeSelf && this.slidingPanelButtonShow.interactable;
	}

	// Token: 0x06001C03 RID: 7171 RVA: 0x000C8215 File Offset: 0x000C6415
	private void NLFKFJICMNE()
	{
		AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(64);
		this.CAAMGFJMPDF();
	}

	// Token: 0x06001C04 RID: 7172 RVA: 0x000C822C File Offset: 0x000C642C
	private bool LANOIACCLOP(AssetAvatarComponent FDOHBGGCDOF, int KFCMLNPLAHK)
	{
		if (null != FDOHBGGCDOF)
		{
			if (KFCMLNPLAHK == 0)
			{
				for (int i = 1; i < this.LPBFAGDJKIH.avatarScreenAvatarPacks.Count; i += 0)
				{
					if (this.LPBFAGDJKIH.avatarScreenAvatarPacks[i] == FDOHBGGCDOF.DMNILGHNCJP().index)
					{
						return true;
					}
				}
			}
			else if (KFCMLNPLAHK == 0)
			{
				for (int j = 1; j < this.LPBFAGDJKIH.avatarScreenAvatarPacks1.Count; j += 0)
				{
					if (this.LPBFAGDJKIH.avatarScreenAvatarPacks1[j] == FDOHBGGCDOF.DMNILGHNCJP().index)
					{
						return false;
					}
				}
			}
			else if (KFCMLNPLAHK == 1)
			{
				for (int k = 0; k < this.LPBFAGDJKIH.avatarScreenAvatarPacks2.Count; k += 0)
				{
					if (this.LPBFAGDJKIH.avatarScreenAvatarPacks2[k] == FDOHBGGCDOF.JKONNEEBNJH().index)
					{
						return true;
					}
				}
			}
			else
			{
				DPGJIJGOCIC.ANOPFDLPKGC("" + KFCMLNPLAHK.ToString());
			}
		}
		return true;
	}

	// Token: 0x06001C05 RID: 7173 RVA: 0x000C8324 File Offset: 0x000C6524
	private void ODDLIJLKLCC()
	{
		if (this.HACNEIFDKAO != null)
		{
			this.HACNEIFDKAO.Kill(false);
			this.HACNEIFDKAO = null;
		}
		TextMeshProUGUI[] array = new TextMeshProUGUI[]
		{
			this.filterFaceCountText,
			this.filterHairCountText,
			this.filterClothesCountText,
			this.filterTrinketsCountText
		};
		if (this.EIGPFFJAGAC == null)
		{
			this.EIGPFFJAGAC = new Vector2[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				if (null != array[i])
				{
					this.EIGPFFJAGAC[i] = array[i].rectTransform.anchoredPosition;
				}
			}
		}
		for (int j = 0; j < array.Length; j++)
		{
			if (null != array[j])
			{
				array[j].rectTransform.anchoredPosition = this.EIGPFFJAGAC[j];
			}
		}
		this.HACNEIFDKAO = DOTween.Sequence();
		float num = Mathf.Max((float)array.Length * this.filterCountsPulseStaggerTime, 2f * this.filterCountsPulseStepTime);
		for (int k = 0; k < 2; k++)
		{
			for (int l = 0; l < array.Length; l++)
			{
				if (!(null == array[l]))
				{
					float num2 = (float)k * num + (float)l * this.filterCountsPulseStaggerTime;
					this.HACNEIFDKAO.Insert(num2, array[l].rectTransform.DOAnchorPosY(this.EIGPFFJAGAC[l].y + this.filterCountsPulseJumpHeight, this.filterCountsPulseStepTime, false).SetEase(Ease.OutQuad));
					this.HACNEIFDKAO.Insert(num2 + this.filterCountsPulseStepTime, array[l].rectTransform.DOAnchorPosY(this.EIGPFFJAGAC[l].y, this.filterCountsPulseStepTime, false).SetEase(Ease.InQuad));
				}
			}
		}
	}

	// Token: 0x06001C06 RID: 7174 RVA: 0x000C5C04 File Offset: 0x000C3E04
	private List<string> JDJLBMMNOPP()
	{
		return this.JHJCOADNIKG;
	}

	// Token: 0x06001C07 RID: 7175 RVA: 0x00003E52 File Offset: 0x00002052
	private void KGPDMFEKHGJ()
	{
	}

	// Token: 0x06001C08 RID: 7176 RVA: 0x000C84EC File Offset: 0x000C66EC
	private void HCNJDFBPOII()
	{
		EIOPLEFLLIM eioplefllim = AKLFPGMDKLA.EHBBFMCILPC.GJBDBONJCDL(this.LPBFAGDJKIH.index);
		PLFDAJJHMKO plfdajjhmko = null;
		JSONArray jsonarray = new JSONArray();
		int num = 1;
		if (ODJKHCHFKNL.MGFOCBPGJJA() == DFGILFBGPLN.screenStory)
		{
			num = 0;
			plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1);
		}
		if (eioplefllim == null || (num == 0 && plfdajjhmko == null))
		{
			DPGJIJGOCIC.ANOPFDLPKGC("SceneAvatarManager.FetchAvatarCollectionsFromBackend(): save not available");
			this.AIACGFPOAGH();
			return;
		}
		if (this.COLIIPCGCAG(plfdajjhmko, eioplefllim, this.MCGPBKHFJKL()) == 0)
		{
			List<int> list = this.AMPJNPMDBFP(plfdajjhmko, eioplefllim, this.MCGPBKHFJKL());
			if (list != null)
			{
				List<int> list2 = new List<int>(list);
				list2.Sort();
				for (int i = 0; i < list2.Count; i++)
				{
					jsonarray.Add(list2[i]);
				}
			}
			if (jsonarray.Count > 0)
			{
				this.DBLGHLDMFBE = true;
			}
			else
			{
				this.HHKFKDNOFAN(plfdajjhmko, eioplefllim, this.MCGPBKHFJKL(), 1);
			}
		}
		if (this.DBLGHLDMFBE)
		{
			CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithHint(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("serversync"), 96);
			BackendOperationsManager.EHBBFMCILPC.RequestGetAvatarCollections(num, this.LPBFAGDJKIH.index, this.CHBPAHCHABB(plfdajjhmko), this.MCGPBKHFJKL(), jsonarray, SceneAvatarManager.onAvatarCollectionsBackendFetchSuccess, SceneAvatarManager.onAvatarCollectionsBackendFetchException);
			return;
		}
		this.AIACGFPOAGH();
	}

	// Token: 0x06001C09 RID: 7177 RVA: 0x000C8620 File Offset: 0x000C6820
	public void SelectAvatarCollectionFilter(GEGBHOMKNDF MNHNBGKAONP)
	{
		this.OBIPBNFKMCC = MNHNBGKAONP;
		this.EAFLMHHPHAD();
		this.OMJIAFNEGGM(MNHNBGKAONP);
	}

	// Token: 0x06001C0A RID: 7178 RVA: 0x000C8638 File Offset: 0x000C6838
	private void EAFLMHHPHAD()
	{
		this.EDMBMPHADBA();
		if (null == this.avatarCollectionsSelectedFilterTitle)
		{
			return;
		}
		string text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("avatarcollectionsentrytitle");
		if (this.OBIPBNFKMCC != null)
		{
			text = DPGJIJGOCIC.PABDHGIJMHJ(this.OBIPBNFKMCC.BPMFHNDCBOH, 16, "...");
		}
		bool flag = this.DOCIEAMHGKJ != null && !text.Equals(this.DOCIEAMHGKJ);
		this.DOCIEAMHGKJ = text;
		this.avatarCollectionsSelectedFilterTitle.SetText(text, true);
		this.avatarCollectionsSelectedFilterTitle.text = text;
		if (flag)
		{
			this.AIKLLLGMKJO();
		}
	}

	// Token: 0x06001C0B RID: 7179 RVA: 0x000C86CC File Offset: 0x000C68CC
	private bool PPLCOLNBMLJ()
	{
		return Time.frameCount - this.AANAAIKPNPC == 0;
	}

	// Token: 0x06001C0C RID: 7180 RVA: 0x000C86DD File Offset: 0x000C68DD
	public void OnSettingsClick()
	{
		if (FacebookManager.EHBBFMCILPC.IsFacebookManagerInitialized())
		{
			CommonUserInterface.EHBBFMCILPC.ShowSettings(false, this.LPBFAGDJKIH.enablePostEffects, false);
			return;
		}
		base.StartCoroutine(this.DEMIIEHPNIH());
	}

	// Token: 0x06001C0D RID: 7181 RVA: 0x000C1516 File Offset: 0x000BF716
	public void CFEBLJOCIKD(GEGBHOMKNDF MNHNBGKAONP)
	{
		this.OBIPBNFKMCC = MNHNBGKAONP;
		this.EAFLMHHPHAD();
		base.StartCoroutine(this.ANGJNNHHALK(MNHNBGKAONP));
	}

	// Token: 0x06001C0E RID: 7182 RVA: 0x000C8710 File Offset: 0x000C6910
	private void LAIAPMIBFCK(KFIHMMIGPLO PBKAAIONJOB)
	{
		if (PBKAAIONJOB != KFIHMMIGPLO.overlay)
		{
			for (int i = 1; i < 6; i++)
			{
				if (PBKAAIONJOB != (KFIHMMIGPLO)i && i != 5)
				{
					this.filters[i - 1].sprite = this.filtersOffSD[i - 1];
				}
			}
			this.filters[PBKAAIONJOB - KFIHMMIGPLO.hair].sprite = this.filtersOnSD[PBKAAIONJOB - KFIHMMIGPLO.hair];
			this.IDIJBMFFCGA = PBKAAIONJOB;
			this.LPEAMOKELOJ();
			this.NBJKIONNPKP();
		}
	}

	// Token: 0x06001C0F RID: 7183 RVA: 0x000C878A File Offset: 0x000C698A
	private void JPGLBDEPKHM()
	{
		AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(68);
		this.ABAANDNGAJD();
	}

	// Token: 0x06001C10 RID: 7184 RVA: 0x000C87A0 File Offset: 0x000C69A0
	private void JHFOKEIKEPO()
	{
		if (false)
		{
			if (ODJKHCHFKNL.FBDNIMIKOLP() == (DFGILFBGPLN)(-119) && AKLFPGMDKLA.EHBBFMCILPC.GLKNOFHEBKN >= 1 && AKLFPGMDKLA.EHBBFMCILPC.JDCBFAPDJIM(AKLFPGMDKLA.EHBBFMCILPC.GLKNOFHEBKN, -1) != null)
			{
				DOLBFGIPPOG dolbfgippog = AKLFPGMDKLA.EHBBFMCILPC.JDCBFAPDJIM(AKLFPGMDKLA.EHBBFMCILPC.GLKNOFHEBKN, -1).NCAMFPGMCIG.LEDOJJCKKKB(AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().OIBGFPEGLME);
				for (int i = 0; i < dolbfgippog.OHCMCJHDMOH.Length; i++)
				{
					if (dolbfgippog.OHCMCJHDMOH[i] != null)
					{
						this.AENHELKPGAH.OHCMCJHDMOH[i] = dolbfgippog.OHCMCJHDMOH[i];
					}
				}
				DPGJIJGOCIC.PJCLICBPPDA("NEWSAVE: Warning: Missing anthology save data, yet story save data (" + AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().OIBGFPEGLME.ToString());
				return;
			}
		}
		else
		{
			try
			{
				if (ODJKHCHFKNL.GENOHKPLJLL() == (DFGILFBGPLN)89 && this.AENHELKPGAH != null)
				{
					bool flag = true;
					for (int j = 0; j < this.AENHELKPGAH.OHCMCJHDMOH.Length - 7; j += 0)
					{
						if (this.AENHELKPGAH.OHCMCJHDMOH[j] != null && this.AENHELKPGAH.OHCMCJHDMOH[j].Length > 1)
						{
							flag = true;
							break;
						}
					}
					if (AKLFPGMDKLA.EHBBFMCILPC.GLKNOFHEBKN >= 1)
					{
						DOLBFGIPPOG dolbfgippog2 = AKLFPGMDKLA.EHBBFMCILPC.JDCBFAPDJIM(AKLFPGMDKLA.EHBBFMCILPC.GLKNOFHEBKN, -1).NCAMFPGMCIG.LEDOJJCKKKB(AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().OIBGFPEGLME);
						if (flag)
						{
							for (int k = 1; k < dolbfgippog2.OHCMCJHDMOH.Length; k++)
							{
								if (dolbfgippog2.OHCMCJHDMOH[k] != null)
								{
									this.AENHELKPGAH.OHCMCJHDMOH[k] = dolbfgippog2.OHCMCJHDMOH[k];
								}
							}
							DPGJIJGOCIC.ADFCDFHBDAF("" + AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().OIBGFPEGLME.ToString());
						}
						if (this.LCOKEPGNEKI != null && this.LCOKEPGNEKI.avatarOverlayDefault.Length > 1)
						{
							this.AENHELKPGAH.OHCMCJHDMOH[6] = this.LCOKEPGNEKI.avatarOverlayDefault;
						}
						else
						{
							this.AENHELKPGAH.OHCMCJHDMOH[7] = "socialgiftreceviedfromtitle";
						}
						if (dolbfgippog2.OHCMCJHDMOH[3].Length > 0)
						{
							AssetAvatarComponent assetAvatarComponent = GKJPOGNFKNK.LHEKMIIKFGC(dolbfgippog2.OHCMCJHDMOH[0], KFIHMMIGPLO.trinket, CFNCBCLEGBC.none, this.NJAAOCMPKCD, this.LPBFAGDJKIH, this.AEMFLGKFGCP, this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.AHEPDLIMMJD());
							if (null != assetAvatarComponent && assetAvatarComponent.showOverlayOutsideStory)
							{
								this.AENHELKPGAH.OHCMCJHDMOH[2] = dolbfgippog2.OHCMCJHDMOH[1];
							}
						}
					}
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
	}

	// Token: 0x06001C11 RID: 7185 RVA: 0x000C8A50 File Offset: 0x000C6C50
	private CustomWardrobeSettings BBIDDDOIICB()
	{
		try
		{
			if (null != this.LPBFAGDJKIH && this.LPBFAGDJKIH.HNKINNNFKEO() && AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OIBGFPEGLME < this.LPBFAGDJKIH.customWardrobeSettings.Count)
			{
				return this.LPBFAGDJKIH.customWardrobeSettings[AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OIBGFPEGLME];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return null;
	}

	// Token: 0x06001C12 RID: 7186 RVA: 0x000C8AE4 File Offset: 0x000C6CE4
	private void ICPDPBAKINE()
	{
		AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(84);
	}

	// Token: 0x06001C13 RID: 7187 RVA: 0x000C8AF4 File Offset: 0x000C6CF4
	private bool OIPPNLDGBPG()
	{
		if (!KDCJJBLGCBH.EHBBFMCILPC.KNEHCPMJJBE())
		{
			return false;
		}
		FBIJKLKEIIN fbijklkeiin = null;
		if (null != AssetsManager.EHBBFMCILPC && null != AssetsManager.EHBBFMCILPC.lobbyDataAsset && null != AssetsManager.EHBBFMCILPC.lobbyDataAsset.avatarCollectionsSettingsBalance)
		{
			fbijklkeiin = AssetsManager.EHBBFMCILPC.lobbyDataAsset.EGEJBBGOJNN().LNKBEBFCCCJ(this.LPBFAGDJKIH.index);
		}
		return fbijklkeiin != null && fbijklkeiin.HPFDOLFAPNM();
	}

	// Token: 0x06001C14 RID: 7188 RVA: 0x000C8B78 File Offset: 0x000C6D78
	public void PDAHHIDMJAC()
	{
		if (this.HCMMNOJFABH)
		{
			return;
		}
		this.BIMCBFHNLAP();
		if (ODJKHCHFKNL.FKMDJILIODG() != DFGILFBGPLN.screenLoading && null != this.LPBFAGDJKIH)
		{
			EIOPLEFLLIM eioplefllim = AKLFPGMDKLA.EHBBFMCILPC.AMAMNOFLPGM(this.LPBFAGDJKIH.index);
			if (eioplefllim != null)
			{
				eioplefllim.OIBGFPEGLME--;
				if (eioplefllim.OIBGFPEGLME < 1)
				{
					eioplefllim.OIBGFPEGLME = this.defaultEnvironmentCustomWardrobe.Count - 1;
				}
				CommonUserInterface.IKNOFBFMPGA().GetFader().FadeInWithCustomFader(this.HGPNBLEBAGH(), new TweenCallback(this.BNAOKBANHPP));
			}
		}
	}

	// Token: 0x06001C15 RID: 7189 RVA: 0x000C8C10 File Offset: 0x000C6E10
	public void KOMJAHCCLOC(JSONArray DNDPBCPKPCD)
	{
		if (ODJKHCHFKNL.BBBJIGCHMCG() != DFGILFBGPLN.screenLoading)
		{
			this.DBLGHLDMFBE = true;
			return;
		}
		if (null == DNDPBCPKPCD)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("ok");
			return;
		}
		try
		{
			EIOPLEFLLIM lnfebcfcbhg = AKLFPGMDKLA.EHBBFMCILPC.AMAMNOFLPGM(this.LPBFAGDJKIH.index);
			PLFDAJJHMKO baokjbjifbh = null;
			if (ODJKHCHFKNL.HAGAMCDNCMH() == DFGILFBGPLN.screenHub)
			{
				baokjbjifbh = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1);
			}
			bool flag = true;
			for (int i = 0; i < DNDPBCPKPCD.Count; i += 0)
			{
				JSONObject asObject = DNDPBCPKPCD[i].AsObject;
				if (null != asObject)
				{
					if (asObject["restartChapterOrStory"] == null || asObject["OnStoryChoiceClick"] == null || asObject["avind"] == null || asObject["errortitle"] == null || asObject["PurchaseManagerUnity.OnPurchasesFetched(): "] == null || asObject["actsh"] == null)
					{
						DPGJIJGOCIC.ANOPFDLPKGC("sssku");
					}
					else
					{
						GEGBHOMKNDF gegbhomkndf = new GEGBHOMKNDF();
						gegbhomkndf.FGJPKGLOGNC(asObject);
						if (!AKLFPGMDKLA.EHBBFMCILPC.DLJBBDOEMLO.Contains(gegbhomkndf.LGNMFFIEPLF()) && !AKLOMMOOFNG.LCEKKMPGPKM(asObject.ToString(), "debugMessage" + gegbhomkndf.CEKJAMOKEIM()))
						{
							flag = false;
							DPGJIJGOCIC.ANOPFDLPKGC("SceneAvatarManager.SyncSelectedAvatarCollectionToAnthology(): anthology save not available" + gegbhomkndf.NENMEJBNDGJ());
						}
					}
				}
			}
			if (flag)
			{
				this.HHKFKDNOFAN(baokjbjifbh, lnfebcfcbhg, this.MCGPBKHFJKL(), 1);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06001C16 RID: 7190 RVA: 0x000C8DBC File Offset: 0x000C6FBC
	private void NHCMKODLEOB(string BCCIHAGLIOH)
	{
		string text = this.KGOAGNFNFIJ;
		if (this.KGOAGNFNFIJ.Length > 0 && this.JHHKEPGLHKD.Length > 0)
		{
			text = this.KGOAGNFNFIJ + ";" + this.JHHKEPGLHKD;
		}
		if (this.AJKNDFMMDDO(KFIHMMIGPLO.face, text, BCCIHAGLIOH))
		{
			this.MPOCLECLHDE.Clear();
			this.JBBDBBBLOHC.Clear();
			if (this.MKODGAPBOFH)
			{
				this.MPOCLECLHDE.Add(KFIHMMIGPLO.face);
				this.JBBDBBBLOHC.Add(text);
				this.IAKIBKAJHHC(GKJPOGNFKNK.DNILNCLIHAP(this.KGOAGNFNFIJ, "avatarstitle" + this.LPBFAGDJKIH.CKACBBGHJGI().ToString(), LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), BCCIHAGLIOH);
			}
			else
			{
				this.IMFNIHKNKPM = null;
				this.NBFPLJNKIAK(GKJPOGNFKNK.DNILNCLIHAP(this.KGOAGNFNFIJ, "avatarstitle" + this.LPBFAGDJKIH.CKACBBGHJGI().ToString(), LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), BCCIHAGLIOH);
			}
		}
		this.GIICKOCBEMB();
	}

	// Token: 0x06001C17 RID: 7191 RVA: 0x000C8EC8 File Offset: 0x000C70C8
	private void HOKMHLFKHPK(string BCCIHAGLIOH)
	{
		if (this.AJKNDFMMDDO(KFIHMMIGPLO.trinket, this.PBOKDNDMCDL, BCCIHAGLIOH))
		{
			this.MPOCLECLHDE.Clear();
			this.JBBDBBBLOHC.Clear();
			if (this.MKODGAPBOFH)
			{
				this.MPOCLECLHDE.Add(KFIHMMIGPLO.trinket);
				this.JBBDBBBLOHC.Add(this.PBOKDNDMCDL);
				this.IAKIBKAJHHC(GKJPOGNFKNK.DNILNCLIHAP(this.PBOKDNDMCDL, "avatarstitle" + this.LPBFAGDJKIH.CKACBBGHJGI().ToString(), LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), BCCIHAGLIOH);
			}
			else
			{
				this.IMFNIHKNKPM = null;
				this.NBFPLJNKIAK(GKJPOGNFKNK.DNILNCLIHAP(this.PBOKDNDMCDL, "avatarstitle" + this.LPBFAGDJKIH.CKACBBGHJGI().ToString(), LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), BCCIHAGLIOH);
			}
		}
		this.GIICKOCBEMB();
	}

	// Token: 0x06001C18 RID: 7192 RVA: 0x000C8FA4 File Offset: 0x000C71A4
	private void LDHOIBFNNDC()
	{
		if (this.IMFNIHKNKPM == null || this.JBBDBBBLOHC.Count == 0)
		{
			return;
		}
		bool flag = false;
		int num = 0;
		while (num < this.JBBDBBBLOHC.Count && num < this.MPOCLECLHDE.Count)
		{
			if (this.IMFNIHKNKPM.IOBKLNEEPLH(this.MPOCLECLHDE[num], this.JBBDBBBLOHC[num]))
			{
				flag = true;
			}
			num++;
		}
		if (flag)
		{
			if (this.IMFNIHKNKPM.OHAPCIOFAHG() == 0)
			{
				this.DeleteAvatarCollection(this.IMFNIHKNKPM, false);
				this.IMFNIHKNKPM = null;
			}
			else
			{
				if (AKLOMMOOFNG.BIKILBLOEKD(this.IMFNIHKNKPM.BNMFBKNEMIF().ToString(), "Collections/" + this.IMFNIHKNKPM.NENMEJBNDGJ()) && !AKLFPGMDKLA.EHBBFMCILPC.DLJBBDOEMLO.Contains(this.IMFNIHKNKPM.NENMEJBNDGJ()))
				{
					AKLFPGMDKLA.EHBBFMCILPC.DLJBBDOEMLO.Add(this.IMFNIHKNKPM.NENMEJBNDGJ());
				}
				if (this.OBIPBNFKMCC == this.IMFNIHKNKPM)
				{
					this.JJAFCPIPKCP(false, 1);
				}
			}
		}
		this.MPOCLECLHDE.Clear();
		this.JBBDBBBLOHC.Clear();
		this.IMFNIHKNKPM = null;
		this.LOOPHODOHGM();
		this.KBIBPGOGAAM();
		this.avatarCollectionsNotificationUndo.gameObject.SetActive(false);
		this.avatarCollectionsNotificationUndo.gameObject.SetActive(true);
		string text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("avatarcollectionsundotitle");
		text = text.Replace("XXX", "\"" + this.BNDFODLCCEF + "\"");
		text = text.Replace("YYY", "\"" + this.CEFHEGIGMGK + "\"");
		this.avatarCollectionsNotificationUndoTitle.SetText(text, true);
		this.avatarCollectionsNotificationUndoTitle.text = text;
	}

	// Token: 0x06001C19 RID: 7193 RVA: 0x000C916C File Offset: 0x000C736C
	private void OnDisable()
	{
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnLanguageChange", new UnityAction(this.LLMPAPDBHEL));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPostEffectSettingsChanged", new UnityAction(this.HLBIEIAFBFK));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnApplicationRestart", new UnityAction(this.ECNCPOBPHGC));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnStoryInterfaceHeaderBackClick", new UnityAction(this.LLNENMOMNKP));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnStoryInterfaceHeaderSettingsClick", new UnityAction(this.NFCDJBPAFEI));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH(SceneAvatarManager.onSocialStatsAvatarScreenSuccess, new UnityAction(this.FDIJFIAHBPL));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH(SceneAvatarManager.onSocialStatsAvatarScreenException, new UnityAction(this.KMCGCJPEJKO));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH(SceneAvatarManager.onAvatarCollectionsBackendFetchSuccess, new UnityAction(this.DKODFAGILIC));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH(SceneAvatarManager.onAvatarCollectionsBackendFetchException, new UnityAction(this.JFCKJMMONBG));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH(SceneAvatarManager.onAvatarCollectionsBackendSyncSuccess, new UnityAction(this.OLKJGJOGNEO));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH(SceneAvatarManager.onAvatarCollectionsBackendSyncException, new UnityAction(this.DJGDOHHKEDO));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnSocialModeChanged", new UnityAction(this.OnSocialModeChanged));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPopupAvatarCollectionsInputEndEdit", new UnityAction(this.NBIHBLKMEEC));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPopupAvatarCollectionsInputCancel", new UnityAction(this.IKFCLPAMPCD));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnGamePassUnlockContinueToPurchasingScreen", new UnityAction(this.LMJGOIINBIC));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPurchasingViewLeave", new UnityAction(this.IAIIODBDKHK));
		if (this.NPDBOIIBOJM)
		{
			if (null != this.LADDIEIMNGH)
			{
				this.LADDIEIMNGH.transform.SetParent(this.FFHNHAFPEBB, false);
				this.LADDIEIMNGH.SetActive(this.OLNGBFLEEFE);
				this.FFHNHAFPEBB = null;
				this.LADDIEIMNGH = null;
			}
			if (ODJKHCHFKNL.MGFOCBPGJJA() == DFGILFBGPLN.screenStory)
			{
				AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnAvatarScreenClosed", 0f);
			}
		}
		ODJKHCHFKNL.GFEOFIABBKM();
		this.NPDBOIIBOJM = false;
	}

	// Token: 0x06001C1A RID: 7194 RVA: 0x000C93A0 File Offset: 0x000C75A0
	private void ABLDIKHBDNM(string EOIHFFHPALN)
	{
		if (null == this.avatarCollectionsNotificationSelected || null == this.avatarCollectionsNotificationSelectedTitle)
		{
			return;
		}
		this.LOOPHODOHGM();
		this.KBIBPGOGAAM();
		this.avatarCollectionsNotificationSelected.gameObject.SetActive(true);
		this.avatarCollectionsNotificationSelected.gameObject.SetActive(false);
		string text = CCOJBMMKNAP.NIOJNOFGIJO().HDIPNMFHIEJ("0");
		text = text.Replace("cid", "serversync" + DPGJIJGOCIC.DEEHCLAKMDL(EOIHFFHPALN, 120, "OnBackendUpgradeToGiftCardException") + "a");
		this.avatarCollectionsNotificationSelectedTitle.SetText(text, true);
		this.avatarCollectionsNotificationSelectedTitle.text = text;
	}

	// Token: 0x06001C1B RID: 7195 RVA: 0x000C944C File Offset: 0x000C764C
	public void LHJNONBCEEM()
	{
		this.NLEOIGECPED();
		if (DHGFCJGJFOB.KPHNADKJHMJ == this.LPBFAGDJKIH)
		{
			DHGFCJGJFOB.KPHNADKJHMJ = this.NDFACHLEJLJ;
		}
		this.NDFACHLEJLJ = null;
		if (null != this.imageEffects)
		{
			this.imageEffects.MGEKEDODMPM("Asset bundle load operation failed during parallel mode.");
			this.imageEffects.MPPOKGDIMMG("signinsuccess");
		}
		this.content.SetActive(false);
		base.gameObject.SetActive(false);
	}

	// Token: 0x06001C1C RID: 7196 RVA: 0x000C94CC File Offset: 0x000C76CC
	public void ALJAFJJHLAA()
	{
		this.OKEMJFMOHML();
		CommonUserInterface.IKNOFBFMPGA().PLNOMHKNKEB();
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(-15))
		{
			CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupOneOverrideWithCloseOverride(CCOJBMMKNAP.JMNIGPHCAEJ().HHLECNIFHCO("retry"), CCOJBMMKNAP.HJGDLOOHNLO().MEPECBDCOLG("@"), CCOJBMMKNAP.JINDKPHNLBK().HPOAGPJFHPM("Account.DuplicateStorySave(), could not parse the serialized source save, story:"), new UnityAction(this.BHHPCAFODMA), new UnityAction(this.BHHPCAFODMA), (DFGILFBGPLN)88, 207f, -6);
		}
	}

	// Token: 0x06001C1D RID: 7197 RVA: 0x000C9550 File Offset: 0x000C7750
	public void OnAvatarCollectionsNotificationSelectFilterClick()
	{
		this.AANAAIKPNPC = Time.frameCount;
		this.KBIBPGOGAAM();
		if (this.IMFNIHKNKPM == null)
		{
			return;
		}
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(69))
		{
			this.BAACKFDMOCI("avatarcollectionstutor6title", "avatarcollectionstutor6body", "", new UnityAction(this.KPNPGAJINMI));
			return;
		}
		this.LAEANFAPAAF();
	}

	// Token: 0x06001C1E RID: 7198 RVA: 0x000C95B0 File Offset: 0x000C77B0
	private void AAMLMFHFDHL()
	{
		for (int i = 1; i < this.PKKHHJFMFBK.Count; i++)
		{
			if (this.GMOGLALJAOP[i] != null)
			{
				this.IDNANEBJACO(i);
			}
			else if (null != this.PKKHHJFMFBK[i])
			{
				this.PKKHHJFMFBK[i].gameObject.SetActive(false);
				this.PKKHHJFMFBK[i].GetComponent<CanvasGroup>().DOKill(false);
				this.PKKHHJFMFBK[i].GetComponent<RectTransform>().DOKill(false);
				this.PKKHHJFMFBK[i].DOKill(true);
				UnityEngine.Object.Destroy(this.PKKHHJFMFBK[i].gameObject);
			}
		}
		this.PKKHHJFMFBK.Clear();
		this.GMOGLALJAOP.Clear();
	}

	// Token: 0x06001C1F RID: 7199 RVA: 0x000C9690 File Offset: 0x000C7890
	private void ODILEKGAKLI()
	{
		this.NEBGIAJNCLA();
		if (Input.GetMouseButtonUp(0) || Input.GetMouseButtonUp(1))
		{
			if (DPGJIJGOCIC.JMDNLAMNGPI().y > 724f && null != this.storyInterfaceHeaderManager && !this.PPLCOLNBMLJ())
			{
				this.storyInterfaceHeaderManager.Show(216f);
				return;
			}
		}
		else if (DPGJIJGOCIC.MEDGDBAOPIL() && DPGJIJGOCIC.AHELOLJOHLJ().y > 67f && null != this.storyInterfaceHeaderManager && !this.PPLCOLNBMLJ())
		{
			this.storyInterfaceHeaderManager.Show(500f);
		}
	}

	// Token: 0x06001C20 RID: 7200 RVA: 0x000C972C File Offset: 0x000C792C
	private bool LHBMEFGCPHK()
	{
		int num;
		if (PlayerPrefs.HasKey("post"))
		{
			num = PlayerPrefs.GetInt("post");
		}
		else
		{
			num = 1;
		}
		return num == 1 && NBDLBFJOEGN.LHBMEFGCPHK();
	}

	// Token: 0x06001C21 RID: 7201 RVA: 0x000C9761 File Offset: 0x000C7961
	public void OnSocialModeChanged()
	{
		this.ShowHideSocialFeatures();
	}

	// Token: 0x06001C22 RID: 7202 RVA: 0x000C9769 File Offset: 0x000C7969
	private float DHPNPKNHGIP()
	{
		if (null != this.LPBFAGDJKIH && this.LPBFAGDJKIH.HGIIJABNDCD(1) != null && this.wardrobeScrollCustomFadeInTime > 1471f)
		{
			return this.wardrobeScrollCustomFadeInTime;
		}
		return 41f;
	}

	// Token: 0x06001C23 RID: 7203 RVA: 0x000C1516 File Offset: 0x000BF716
	public void PIKFLOLPCOH(GEGBHOMKNDF MNHNBGKAONP)
	{
		this.OBIPBNFKMCC = MNHNBGKAONP;
		this.EAFLMHHPHAD();
		base.StartCoroutine(this.ANGJNNHHALK(MNHNBGKAONP));
	}

	// Token: 0x06001C24 RID: 7204 RVA: 0x000C97A0 File Offset: 0x000C79A0
	private CharacterRenderTexturePool.AHLNEABNMOA OELALBBMILL()
	{
		CharacterRenderTexturePool.AHLNEABNMOA result;
		try
		{
			this.EBHJLLIHIFE = CharacterRenderTexturePool.GetOrCreate();
			if (null == this.EBHJLLIHIFE)
			{
				result = null;
			}
			else
			{
				RectTransform component = this.characterPivot.GetComponent<RectTransform>();
				result = this.EBHJLLIHIFE.AcquirePlayerCharacter(component, component);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x06001C25 RID: 7205 RVA: 0x000C25CA File Offset: 0x000C07CA
	private void IKFCLPAMPCD()
	{
		this.IKABLPHJEBH = -1;
	}

	// Token: 0x06001C26 RID: 7206 RVA: 0x000C25CA File Offset: 0x000C07CA
	private void KEEOKLGJFBG()
	{
		this.IKABLPHJEBH = -1;
	}

	// Token: 0x06001C27 RID: 7207 RVA: 0x000C6864 File Offset: 0x000C4A64
	public void ClearAvatarCollectionFilter()
	{
		this.OBIPBNFKMCC = null;
		this.JHJCOADNIKG = null;
		this.GPMCPFBGOJA = null;
		this.OMNBGHBFMAM = null;
		this.DOENPCEJHJG = null;
		this.EAFLMHHPHAD();
	}

	// Token: 0x06001C28 RID: 7208 RVA: 0x000C9800 File Offset: 0x000C7A00
	private bool AIEEANFPMOO()
	{
		return !(null == this.LPBFAGDJKIH) && ((this.LPBFAGDJKIH.HNKINNNFKEO() && this.LCOKEPGNEKI != null && this.LCOKEPGNEKI.avatarCustomizationType == GKDCPMFMPMO.avatarCustomizationAutoSuffixAndSync) || (!this.LPBFAGDJKIH.HNKINNNFKEO() && this.LPBFAGDJKIH.avatarCustomizationType == GKDCPMFMPMO.avatarCustomizationAutoSuffixAndSync));
	}

	// Token: 0x06001C29 RID: 7209 RVA: 0x000C9860 File Offset: 0x000C7A60
	public AssetAvatarComponent _NextAssetOfComponentType(bool PAEDAKPCJDG, KFIHMMIGPLO PBKAAIONJOB)
	{
		switch (PBKAAIONJOB)
		{
		case KFIHMMIGPLO.body:
		{
			AssetAvatarComponent assetAvatarComponent = GKJPOGNFKNK.LHEKMIIKFGC(this.JHHKEPGLHKD, KFIHMMIGPLO.body, CFNCBCLEGBC.next, this.NJAAOCMPKCD, this.LPBFAGDJKIH, null, this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.MCGPBKHFJKL());
			if (PAEDAKPCJDG)
			{
				this.FGGCPAKJKOH = assetAvatarComponent;
				this.HHMHDEPFMBL(this.FGGCPAKJKOH, this.HFKIIFEHGID, this.KFGELOAKHGC, this.IOCLNEFCDNI, this.AIHJMLIDEKJ, this.INHNCPCOJEN, true, 1, false);
			}
			return assetAvatarComponent;
		}
		case KFIHMMIGPLO.hair:
		{
			AssetAvatarComponent assetAvatarComponent = GKJPOGNFKNK.LHEKMIIKFGC(this.OMGLOJOIOCK, KFIHMMIGPLO.hair, CFNCBCLEGBC.next, this.NJAAOCMPKCD, this.LPBFAGDJKIH, this.PGEPFBNCMII(), this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.MCGPBKHFJKL());
			if (PAEDAKPCJDG)
			{
				this.HFKIIFEHGID = assetAvatarComponent;
				this.HHMHDEPFMBL(this.FGGCPAKJKOH, this.HFKIIFEHGID, this.KFGELOAKHGC, this.IOCLNEFCDNI, this.AIHJMLIDEKJ, this.INHNCPCOJEN, true, 1, false);
			}
			return assetAvatarComponent;
		}
		case KFIHMMIGPLO.clothes:
		{
			AssetAvatarComponent assetAvatarComponent = GKJPOGNFKNK.LHEKMIIKFGC(this.PLPCLJFJFNG, KFIHMMIGPLO.clothes, CFNCBCLEGBC.next, this.NJAAOCMPKCD, this.LPBFAGDJKIH, this.CHMCMOHKJOM(), this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.MCGPBKHFJKL());
			if (PAEDAKPCJDG)
			{
				this.KFGELOAKHGC = assetAvatarComponent;
				this.HHMHDEPFMBL(this.FGGCPAKJKOH, this.HFKIIFEHGID, this.KFGELOAKHGC, this.IOCLNEFCDNI, this.AIHJMLIDEKJ, this.INHNCPCOJEN, true, 1, false);
			}
			return assetAvatarComponent;
		}
		case KFIHMMIGPLO.face:
		{
			AssetAvatarComponent assetAvatarComponent = GKJPOGNFKNK.LHEKMIIKFGC(this.KGOAGNFNFIJ, KFIHMMIGPLO.face, CFNCBCLEGBC.next, this.NJAAOCMPKCD, this.LPBFAGDJKIH, this.JDJLBMMNOPP(), this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.MCGPBKHFJKL());
			if (PAEDAKPCJDG)
			{
				this.IOCLNEFCDNI = assetAvatarComponent;
				if (null != this.IOCLNEFCDNI && this.IOCLNEFCDNI.parents.Count > 0)
				{
					AssetAvatarComponent assetAvatarComponent2 = GKJPOGNFKNK.LHEKMIIKFGC(this.IOCLNEFCDNI.parents[0], KFIHMMIGPLO.body, CFNCBCLEGBC.none, this.NJAAOCMPKCD, this.LPBFAGDJKIH, null, this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.MCGPBKHFJKL());
					if (null != assetAvatarComponent2)
					{
						this.FGGCPAKJKOH = assetAvatarComponent2;
					}
				}
				this.HHMHDEPFMBL(this.FGGCPAKJKOH, this.HFKIIFEHGID, this.KFGELOAKHGC, this.IOCLNEFCDNI, this.AIHJMLIDEKJ, this.INHNCPCOJEN, true, 1, false);
			}
			return assetAvatarComponent;
		}
		case KFIHMMIGPLO.trinket:
		{
			AssetAvatarComponent assetAvatarComponent = GKJPOGNFKNK.LHEKMIIKFGC(this.PBOKDNDMCDL, KFIHMMIGPLO.trinket, CFNCBCLEGBC.next, this.NJAAOCMPKCD, this.LPBFAGDJKIH, this.CMPNMJHBLAL(), this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.MCGPBKHFJKL());
			if (PAEDAKPCJDG)
			{
				this.AIHJMLIDEKJ = assetAvatarComponent;
				this.HHMHDEPFMBL(this.FGGCPAKJKOH, this.HFKIIFEHGID, this.KFGELOAKHGC, this.IOCLNEFCDNI, this.AIHJMLIDEKJ, this.INHNCPCOJEN, true, 1, false);
			}
			return assetAvatarComponent;
		}
		case KFIHMMIGPLO.overlay:
		{
			AssetAvatarComponent assetAvatarComponent = GKJPOGNFKNK.LHEKMIIKFGC(this.GHALDHOOFKN, KFIHMMIGPLO.overlay, CFNCBCLEGBC.next, this.NJAAOCMPKCD, this.LPBFAGDJKIH, this.AEMFLGKFGCP, this.NFDKDACMHME, this.GOFNEOPPCII, this.LCOKEPGNEKI, this.MCGPBKHFJKL());
			if (PAEDAKPCJDG)
			{
				this.INHNCPCOJEN = assetAvatarComponent;
				this.HHMHDEPFMBL(this.FGGCPAKJKOH, this.HFKIIFEHGID, this.KFGELOAKHGC, this.IOCLNEFCDNI, this.AIHJMLIDEKJ, this.INHNCPCOJEN, true, -1, false);
			}
			return assetAvatarComponent;
		}
		default:
			return null;
		}
	}

	// Token: 0x06001C2A RID: 7210 RVA: 0x000C0C0A File Offset: 0x000BEE0A
	public GEGBHOMKNDF GetSelectedAvatarCollectionFilter()
	{
		return this.OBIPBNFKMCC;
	}

	// Token: 0x06001C2B RID: 7211 RVA: 0x000C9BA4 File Offset: 0x000C7DA4
	private void ILOHEHDHLGO()
	{
		for (int i = 0; i < this.LPBFAGDJKIH.avatarScreenAvatarPacks.Count; i++)
		{
			AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.IJGAJDKBIJH(this.LPBFAGDJKIH.avatarScreenAvatarPacks[i], 0);
		}
		for (int j = 0; j < this.LPBFAGDJKIH.avatarScreenAvatarPacks1.Count; j++)
		{
			AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.IJGAJDKBIJH(this.LPBFAGDJKIH.avatarScreenAvatarPacks1[j], 1);
		}
		for (int k = 0; k < this.LPBFAGDJKIH.avatarScreenAvatarPacks2.Count; k++)
		{
			AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.IJGAJDKBIJH(this.LPBFAGDJKIH.avatarScreenAvatarPacks2[k], 2);
		}
	}

	// Token: 0x06001C2C RID: 7212 RVA: 0x000C9C78 File Offset: 0x000C7E78
	private CustomWardrobeSettings CELCBDNIDNH()
	{
		try
		{
			if (null != this.LPBFAGDJKIH && this.LPBFAGDJKIH.LNGFPBFCIDC())
			{
				EIOPLEFLLIM eioplefllim = AKLFPGMDKLA.EHBBFMCILPC.GJBDBONJCDL(this.LPBFAGDJKIH.index);
				if (eioplefllim != null && eioplefllim.OIBGFPEGLME < this.LPBFAGDJKIH.customWardrobeSettings.Count)
				{
					return this.LPBFAGDJKIH.customWardrobeSettings[eioplefllim.OIBGFPEGLME];
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return null;
	}

	// Token: 0x06001C2D RID: 7213 RVA: 0x000C9D08 File Offset: 0x000C7F08
	private void KDCIBIABJBK()
	{
		this.FGGCPAKJKOH = null;
		this.HFKIIFEHGID = null;
		this.KFGELOAKHGC = null;
		this.AIHJMLIDEKJ = null;
		this.INHNCPCOJEN = null;
		this.IOCLNEFCDNI = null;
		this.AENHELKPGAH = null;
		this.BDFAAGGCOGF = null;
		this.ANLHHMBINOJ();
		this.LCOKEPGNEKI = null;
	}

	// Token: 0x06001C2E RID: 7214 RVA: 0x000693D6 File Offset: 0x000675D6
	public void DontDestroyOnLoad()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06001C2F RID: 7215 RVA: 0x000C9D5C File Offset: 0x000C7F5C
	private void EFBDBPNKCAF()
	{
		for (int i = 1; i < this.PKKHHJFMFBK.Count; i += 0)
		{
			if (this.GMOGLALJAOP[i] != null)
			{
				this.IDNANEBJACO(i);
			}
			else if (null != this.PKKHHJFMFBK[i])
			{
				this.PKKHHJFMFBK[i].gameObject.SetActive(true);
				this.PKKHHJFMFBK[i].GetComponent<CanvasGroup>().DOKill(false);
				this.PKKHHJFMFBK[i].GetComponent<RectTransform>().DOKill(false);
				this.PKKHHJFMFBK[i].DOKill(false);
				UnityEngine.Object.Destroy(this.PKKHHJFMFBK[i].gameObject);
			}
		}
		this.PKKHHJFMFBK.Clear();
		this.GMOGLALJAOP.Clear();
	}

	// Token: 0x06001C30 RID: 7216 RVA: 0x000C9E3C File Offset: 0x000C803C
	private bool GPBPKHCLJMO(GEGBHOMKNDF CCIAGBPILGF, GEGBHOMKNDF JFKDEMMNEGP)
	{
		bool result = false;
		KFIHMMIGPLO[] array = new KFIHMMIGPLO[]
		{
			KFIHMMIGPLO.face,
			KFIHMMIGPLO.hair,
			KFIHMMIGPLO.clothes,
			KFIHMMIGPLO.trinket
		};
		for (int i = 0; i < array.Length; i++)
		{
			JSONArray jsonarray = CCIAGBPILGF.PKIDFPBKPIF(array[i]);
			if (null != jsonarray)
			{
				for (int j = 0; j < jsonarray.Count; j++)
				{
					if (JFKDEMMNEGP.OPNILAANLCC(array[i], jsonarray[j].Value))
					{
						result = true;
					}
				}
			}
			JSONArray jsonarray2 = CCIAGBPILGF.ICDEKDNMLBE(array[i]);
			if (null != jsonarray2)
			{
				for (int k = 0; k < jsonarray2.Count; k++)
				{
					if (JFKDEMMNEGP.OPNILAANLCC(array[i], jsonarray2[k].Value))
					{
						result = true;
					}
				}
			}
		}
		return result;
	}

	// Token: 0x06001C31 RID: 7217 RVA: 0x000C9EFC File Offset: 0x000C80FC
	public void OnAvatarCollectionsButtonSyncClick()
	{
		if (this.OBIPBNFKMCC == null)
		{
			return;
		}
		if (this.OBIPBNFKMCC.CPIIEEEEEEJ != 0)
		{
			return;
		}
		string text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("avatarcollectionssyncbody");
		text = text.Replace("XXX", "\"" + DPGJIJGOCIC.PABDHGIJMHJ(this.MKFHKAGIFBP(this.OBIPBNFKMCC), 16, "...") + "\"");
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("avatarcollectionssynctitle"), text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("no"), new UnityAction(this.CBMIODMGNAG), new UnityAction(this.KGPDMFEKHGJ), DFGILFBGPLN.popupSignInQuestion, 0f, 28);
	}

	// Token: 0x06001C32 RID: 7218 RVA: 0x000C9FBD File Offset: 0x000C81BD
	private IEnumerator OJFMCMLEJKL(float BICHMDEIFKI)
	{
		this.OPLDMEEFKDO(false, true);
		if (SceneAvatarManager.topPercent > 0 && AKLFPGMDKLA.EHBBFMCILPC.APKDHKHDLHP() && AKLFPGMDKLA.EHBBFMCILPC.JBEPHLFCLEC() && SocialStatsAvatarManager.InstanceInitialized() && SocialStatsAvatarManager.dataIsReady)
		{
			SocialStatsAvatarManager.EHBBFMCILPC.Hide();
		}
		yield return new WaitForSeconds(BICHMDEIFKI);
		if (!this.KKIAKEDEKEA())
		{
			if (!this.JKAFHCIOALE)
			{
				AudioManager.EHBBFMCILPC.KillMusic("", CommonUserInterface.EHBBFMCILPC.GetFader().GetFadeInDuration());
			}
			CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.JMPFKHHDDCA));
		}
		yield break;
	}

	// Token: 0x06001C33 RID: 7219 RVA: 0x000C9FD4 File Offset: 0x000C81D4
	private void IAKIBKAJHHC(string ICHCLOEFLIM, string EOIHFFHPALN)
	{
		this.LOOPHODOHGM();
		this.KBIBPGOGAAM();
		this.avatarCollectionsNotificationAdd.gameObject.SetActive(false);
		this.avatarCollectionsNotificationAdd.gameObject.SetActive(true);
		string text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("avatarcollectionsaddtitle");
		this.BNDFODLCCEF = DPGJIJGOCIC.PABDHGIJMHJ(ICHCLOEFLIM, 16, "...");
		text = text.Replace("XXX", "\"" + this.BNDFODLCCEF + "\"");
		this.CEFHEGIGMGK = DPGJIJGOCIC.PABDHGIJMHJ(EOIHFFHPALN, 16, "...");
		text = text.Replace("YYY", "\"" + this.CEFHEGIGMGK + "\"");
		this.avatarCollectionsNotificationAddTitle.SetText(text, true);
		this.avatarCollectionsNotificationAddTitle.text = text;
	}

	// Token: 0x06001C34 RID: 7220 RVA: 0x000CA0A0 File Offset: 0x000C82A0
	private int AHEPDLIMMJD()
	{
		if (this.LCOKEPGNEKI != null)
		{
			return this.LCOKEPGNEKI.index;
		}
		return 1;
	}

	// Token: 0x06001C35 RID: 7221 RVA: 0x000CA0B7 File Offset: 0x000C82B7
	private void KMCGCJPEJKO()
	{
		if (SceneAvatarManager.topPercent > 0 && AKLFPGMDKLA.EHBBFMCILPC.APKDHKHDLHP() && AKLFPGMDKLA.EHBBFMCILPC.JBEPHLFCLEC())
		{
			SocialStatsAvatarManager.dataIsReady = false;
		}
	}

	// Token: 0x06001C36 RID: 7222 RVA: 0x000CA0E0 File Offset: 0x000C82E0
	private CanvasGroup FKKFHBHGDEL(int MEFKFOHCOHK)
	{
		if (this.GMOGLALJAOP[MEFKFOHCOHK] != null)
		{
			return this.GMOGLALJAOP[MEFKFOHCOHK].AJDMCHIOJAK;
		}
		if (null == this.PKKHHJFMFBK[MEFKFOHCOHK])
		{
			return null;
		}
		return this.PKKHHJFMFBK[MEFKFOHCOHK].GetComponent<CanvasGroup>();
	}

	// Token: 0x06001C37 RID: 7223 RVA: 0x000CA134 File Offset: 0x000C8334
	private IEnumerator FKBEDNLICDM(bool OAHCCINHKJG)
	{
		SceneAvatarManager.EALIJJNCALA ealijjncala = new SceneAvatarManager.EALIJJNCALA(1);
		ealijjncala.<>4__this = this;
		ealijjncala._announceUnselected = OAHCCINHKJG;
		return ealijjncala;
	}

	// Token: 0x06001C38 RID: 7224 RVA: 0x000CA14C File Offset: 0x000C834C
	private CharacterRenderTexturePool.AHLNEABNMOA DECIGMACCEI()
	{
		CharacterRenderTexturePool.AHLNEABNMOA result;
		try
		{
			this.EBHJLLIHIFE = CharacterRenderTexturePool.ABMBNFFADJJ();
			if (null == this.EBHJLLIHIFE)
			{
				result = null;
			}
			else
			{
				RectTransform component = this.characterPivot.GetComponent<RectTransform>();
				result = this.EBHJLLIHIFE.AcquirePlayerCharacter(component, component);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x06001C39 RID: 7225 RVA: 0x000CA1AC File Offset: 0x000C83AC
	private void OMKJLEECAAI(GameObject LJOICECJNID)
	{
		if (null == LJOICECJNID)
		{
			return;
		}
		Canvas[] componentsInParent = LJOICECJNID.GetComponentsInParent<Canvas>(false);
		for (int i = 0; i < componentsInParent.Length; i++)
		{
			if (componentsInParent[i].enabled && !this.ENJGBKCFEEK.Contains(componentsInParent[i]))
			{
				componentsInParent[i].enabled = false;
				this.ENJGBKCFEEK.Add(componentsInParent[i]);
			}
		}
		Canvas[] componentsInChildren = LJOICECJNID.GetComponentsInChildren<Canvas>(true);
		for (int j = 1; j < componentsInChildren.Length; j++)
		{
			if (componentsInChildren[j].enabled && !this.ENJGBKCFEEK.Contains(componentsInChildren[j]))
			{
				componentsInChildren[j].enabled = true;
				this.ENJGBKCFEEK.Add(componentsInChildren[j]);
			}
		}
	}

	// Token: 0x06001C3A RID: 7226 RVA: 0x000CA254 File Offset: 0x000C8454
	private void EBFALBLMLMG()
	{
		if (null == this.avatarCollectionsSelectedFilterTitle)
		{
			return;
		}
		if (this.IEFFJDHGJBO != null)
		{
			this.IEFFJDHGJBO.Kill(false);
			this.IEFFJDHGJBO = null;
		}
		if (!this.OIJLGJAEFEP)
		{
			this.FLPMJBFHPIB = this.avatarCollectionsSelectedFilterTitle.rectTransform.anchoredPosition;
			this.OIJLGJAEFEP = false;
		}
		this.avatarCollectionsSelectedFilterTitle.rectTransform.anchoredPosition = this.FLPMJBFHPIB;
		this.IEFFJDHGJBO = DOTween.Sequence();
		this.IEFFJDHGJBO.Append(this.avatarCollectionsSelectedFilterTitle.rectTransform.DOAnchorPosY(this.FLPMJBFHPIB.y + this.filterCountsPulseJumpHeight, this.filterCountsPulseStepTime, false).SetEase(Ease.InSine));
		this.IEFFJDHGJBO.Append(this.avatarCollectionsSelectedFilterTitle.rectTransform.DOAnchorPosY(this.FLPMJBFHPIB.y, this.filterCountsPulseStepTime, true).SetEase(Ease.InOutSine));
	}

	// Token: 0x06001C3B RID: 7227 RVA: 0x000C41C1 File Offset: 0x000C23C1
	private void Awake()
	{
		this.FOPNADOFECH = this.slidingPanel.GetComponent<RectTransform>();
		this.OIPMEGJLIDC = this.FOPNADOFECH.anchoredPosition;
	}

	// Token: 0x06001C3C RID: 7228 RVA: 0x000CA340 File Offset: 0x000C8540
	private void JFCKJMMONBG()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("app42error") + " (" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD + ")", CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("retry"), new UnityAction(this.HCNJDFBPOII), new UnityAction(this.OKFCLCNHKJD), DFGILFBGPLN.popupBackendError, 0f, 28);
		this.DBLGHLDMFBE = false;
	}

	// Token: 0x06001C3D RID: 7229 RVA: 0x000CA3D0 File Offset: 0x000C85D0
	private void PGLEHJFMNJB(KFIHMMIGPLO PBKAAIONJOB)
	{
		if (PBKAAIONJOB != (KFIHMMIGPLO)8)
		{
			for (int i = 0; i < 6; i++)
			{
				if (PBKAAIONJOB != (KFIHMMIGPLO)i && i != 3)
				{
					this.filters[i - 1].sprite = this.filtersOffSD[i - 0];
				}
			}
			this.filters[PBKAAIONJOB - KFIHMMIGPLO.hair].sprite = this.filtersOnSD[PBKAAIONJOB - KFIHMMIGPLO.body];
			this.IDIJBMFFCGA = PBKAAIONJOB;
			this.LPEAMOKELOJ();
			this.NBJKIONNPKP();
		}
	}

	// Token: 0x040007AA RID: 1962
	public static int topPercent = -1;

	// Token: 0x040007AB RID: 1963
	public static int topPercentDifference = 0;

	// Token: 0x040007AC RID: 1964
	public static int topPercentActiveStory = -1;

	// Token: 0x040007AD RID: 1965
	public static string onAvatarScreenLeft = "OnAvatarScreenLeft";

	// Token: 0x040007AE RID: 1966
	public static string onSocialStatsAvatarScreenSuccess = "OnSocialStatsAvatarScreenSuccess";

	// Token: 0x040007AF RID: 1967
	public static string onSocialStatsAvatarScreenException = "OnSocialStatsAvatarScreenException";

	// Token: 0x040007B0 RID: 1968
	public static string onAvatarCollectionsBackendFetchSuccess = "OnAvatarCollectionsBackendFetchSuccess";

	// Token: 0x040007B1 RID: 1969
	public static string onAvatarCollectionsBackendFetchException = "OnAvatarCollectionsBackendFetchException";

	// Token: 0x040007B2 RID: 1970
	public static string onAvatarCollectionsBackendSyncSuccess = "OnAvatarCollectionsBackendSyncSuccess";

	// Token: 0x040007B3 RID: 1971
	public static string onAvatarCollectionsBackendSyncException = "OnAvatarCollectionsBackendSyncException";

	// Token: 0x040007B4 RID: 1972
	public int buttonPositiveOffsetWhenNegativeIsHidden = 80;

	// Token: 0x040007B5 RID: 1973
	public Camera cameraUI2;

	// Token: 0x040007B6 RID: 1974
	public Camera cameraUI2VFXBack;

	// Token: 0x040007B7 RID: 1975
	public AssetAnthologyAvatarHeader header;

	// Token: 0x040007B8 RID: 1976
	public GameObject content;

	// Token: 0x040007B9 RID: 1977
	public ParticleSystem applyParticles;

	// Token: 0x040007BA RID: 1978
	public TextMeshProUGUI filterFaceCountText;

	// Token: 0x040007BB RID: 1979
	public TextMeshProUGUI filterHairCountText;

	// Token: 0x040007BC RID: 1980
	public TextMeshProUGUI filterClothesCountText;

	// Token: 0x040007BD RID: 1981
	public TextMeshProUGUI filterTrinketsCountText;

	// Token: 0x040007BE RID: 1982
	public TextMeshProUGUI filterOverlaysCountText;

	// Token: 0x040007BF RID: 1983
	public Button buttonDiscardPanel;

	// Token: 0x040007C0 RID: 1984
	public Button buttonDiscardHeader;

	// Token: 0x040007C1 RID: 1985
	public Button buttonScrollNext;

	// Token: 0x040007C2 RID: 1986
	public Button buttonScrollPrev;

	// Token: 0x040007C3 RID: 1987
	public List<Image> filters;

	// Token: 0x040007C4 RID: 1988
	public List<Sprite> filtersOnSD;

	// Token: 0x040007C5 RID: 1989
	public List<Sprite> filtersOffSD;

	// Token: 0x040007C6 RID: 1990
	public GameObject slidingPanel;

	// Token: 0x040007C7 RID: 1991
	public Button slidingPanelButtonShow;

	// Token: 0x040007C8 RID: 1992
	public Button slidingPanelButtonHide;

	// Token: 0x040007C9 RID: 1993
	public TextMeshProUGUI componentDesc;

	// Token: 0x040007CA RID: 1994
	public TextMeshProUGUI componentTitle;

	// Token: 0x040007CB RID: 1995
	public GameObject characterPivot;

	// Token: 0x040007CC RID: 1996
	public GameObject environmentsPivot;

	// Token: 0x040007CD RID: 1997
	public GameObject defaultEnvironment;

	// Token: 0x040007CE RID: 1998
	public List<GameObject> defaultEnvironmentCustomWardrobe;

	// Token: 0x040007CF RID: 1999
	public RectTransformOffsetManager panelButtonPositiveOffset;

	// Token: 0x040007D0 RID: 2000
	public RectTransformOffsetManager panelButtonNegativeOffsets;

	// Token: 0x040007D1 RID: 2001
	public int slidingPanelTranslationAmountY = 412;

	// Token: 0x040007D2 RID: 2002
	public int slidingPanelTranslationAmountNarrowY = 3;

	// Token: 0x040007D3 RID: 2003
	public int bottomButtonsOffsetIfNoDescription = 20;

	// Token: 0x040007D4 RID: 2004
	public StoryInterfaceHeaderManager storyInterfaceHeaderManager;

	// Token: 0x040007D5 RID: 2005
	public ImageEffectsSelector imageEffects;

	// Token: 0x040007D6 RID: 2006
	public List<StoryEnvironmentLayerManager> environmentLayers = new List<StoryEnvironmentLayerManager>();

	// Token: 0x040007D7 RID: 2007
	public GameObject buttonWardrobeLeft;

	// Token: 0x040007D8 RID: 2008
	public GameObject buttonWardrobeRight;

	// Token: 0x040007D9 RID: 2009
	public GameObject avatarCollectionsButton;

	// Token: 0x040007DA RID: 2010
	public GameObject avatarCollectionsPanel;

	// Token: 0x040007DB RID: 2011
	public QuietNotificationManager avatarCollectionsNotificationUnselected;

	// Token: 0x040007DC RID: 2012
	public TextMeshProUGUI avatarCollectionsNotificationUnselectedTitle;

	// Token: 0x040007DD RID: 2013
	public QuietNotificationManager avatarCollectionsNotificationSelected;

	// Token: 0x040007DE RID: 2014
	public TextMeshProUGUI avatarCollectionsNotificationSelectedTitle;

	// Token: 0x040007DF RID: 2015
	public QuietNotificationManager avatarCollectionsNotificationDeleted;

	// Token: 0x040007E0 RID: 2016
	public TextMeshProUGUI avatarCollectionsNotificationDeletedTitle;

	// Token: 0x040007E1 RID: 2017
	public QuietNotificationManager avatarCollectionsNotificationAlreadyAdded;

	// Token: 0x040007E2 RID: 2018
	public TextMeshProUGUI avatarCollectionsNotificationAlreadyAddedTitle;

	// Token: 0x040007E3 RID: 2019
	public QuietNotificationManager avatarCollectionsNotificationAdd;

	// Token: 0x040007E4 RID: 2020
	public TextMeshProUGUI avatarCollectionsNotificationAddTitle;

	// Token: 0x040007E5 RID: 2021
	public QuietNotificationManager avatarCollectionsNotificationUndo;

	// Token: 0x040007E6 RID: 2022
	public TextMeshProUGUI avatarCollectionsNotificationUndoTitle;

	// Token: 0x040007E7 RID: 2023
	public TextMeshProUGUI avatarCollectionsSelectedFilterTitle;

	// Token: 0x040007E8 RID: 2024
	public GameObject buttonClearAvatarCollectionFilter;

	// Token: 0x040007E9 RID: 2025
	public GameObject buttonAddFaceToAvatarCollection;

	// Token: 0x040007EA RID: 2026
	public GameObject buttonAddHairToAvatarCollection;

	// Token: 0x040007EB RID: 2027
	public GameObject buttonAddClothesToAvatarCollection;

	// Token: 0x040007EC RID: 2028
	public GameObject buttonAddTrinketToAvatarCollection;

	// Token: 0x040007ED RID: 2029
	public GameObject buttonAddAllToAvatarCollection;

	// Token: 0x040007EE RID: 2030
	public GameObject textButtonAddAllToAvatarCollection;

	// Token: 0x040007EF RID: 2031
	public GameObject avatarCollectionsHeader;

	// Token: 0x040007F0 RID: 2032
	public GameObject avatarCollectionsHeaderHiddenSelected;

	// Token: 0x040007F1 RID: 2033
	public GameObject avatarCollectionsHeaderHiddenUnselected;

	// Token: 0x040007F2 RID: 2034
	public GameObject buttonSyncAvatarCollection;

	// Token: 0x040007F3 RID: 2035
	public AvatarCollectionsFadeManager avatarCollectionsFadeManager;

	// Token: 0x040007F4 RID: 2036
	public float avatarCollectionsPanelNarrowOffsetX;

	// Token: 0x040007F5 RID: 2037
	public float avatarCollectionsPanelNarrowOffsetY;

	// Token: 0x040007F6 RID: 2038
	public float avatarCollectionsPanelNarrowDownscale = 1f;

	// Token: 0x040007F7 RID: 2039
	public float avatarCollectionsButtonNarrowOffsetX;

	// Token: 0x040007F8 RID: 2040
	public float avatarCollectionsButtonNarrowOffsetY;

	// Token: 0x040007F9 RID: 2041
	public float avatarCollectionsButtonNarrowDownscale = 1f;

	// Token: 0x040007FA RID: 2042
	public float buttonsWardrobeAvatarCollectionsPanelOffsetY;

	// Token: 0x040007FB RID: 2043
	public float avatarCollectionsPopupApplyDelay = 0.45f;

	// Token: 0x040007FC RID: 2044
	public float filterCountsPulseJumpHeight = 12f;

	// Token: 0x040007FD RID: 2045
	public float filterCountsPulseStepTime = 0.12f;

	// Token: 0x040007FE RID: 2046
	public float filterCountsPulseStaggerTime = 0.06f;

	// Token: 0x040007FF RID: 2047
	public float wardrobeScrollCustomFadeInTime = -1f;

	// Token: 0x04000800 RID: 2048
	public float wardrobeScrollCustomFadeOutTime = -1f;

	// Token: 0x04000801 RID: 2049
	private string KGOAGNFNFIJ = "";

	// Token: 0x04000802 RID: 2050
	private string JHHKEPGLHKD = "";

	// Token: 0x04000803 RID: 2051
	private string PLPCLJFJFNG = "";

	// Token: 0x04000804 RID: 2052
	private string OMGLOJOIOCK = "";

	// Token: 0x04000805 RID: 2053
	private string PBOKDNDMCDL = "";

	// Token: 0x04000806 RID: 2054
	private string GHALDHOOFKN = "";

	// Token: 0x04000807 RID: 2055
	private AssetAvatarComponent FGGCPAKJKOH;

	// Token: 0x04000808 RID: 2056
	private AssetAvatarComponent HFKIIFEHGID;

	// Token: 0x04000809 RID: 2057
	private AssetAvatarComponent KFGELOAKHGC;

	// Token: 0x0400080A RID: 2058
	private AssetAvatarComponent AIHJMLIDEKJ;

	// Token: 0x0400080B RID: 2059
	private AssetAvatarComponent INHNCPCOJEN;

	// Token: 0x0400080C RID: 2060
	private AssetAvatarComponent IOCLNEFCDNI;

	// Token: 0x0400080D RID: 2061
	private KFIHMMIGPLO IDIJBMFFCGA = KFIHMMIGPLO.face;

	// Token: 0x0400080E RID: 2062
	private List<PlayerCharacterManager> PKKHHJFMFBK = new List<PlayerCharacterManager>();

	// Token: 0x0400080F RID: 2063
	private List<CharacterRenderTexturePool.AHLNEABNMOA> GMOGLALJAOP = new List<CharacterRenderTexturePool.AHLNEABNMOA>();

	// Token: 0x04000810 RID: 2064
	private CharacterRenderTexturePool EBHJLLIHIFE;

	// Token: 0x04000811 RID: 2065
	private AssetStoryHeader NJAAOCMPKCD;

	// Token: 0x04000812 RID: 2066
	private AssetAnthologyHeader LPBFAGDJKIH;

	// Token: 0x04000813 RID: 2067
	private List<string> HDHDFOGGDPI;

	// Token: 0x04000814 RID: 2068
	private List<string> FJFLMGBOKON;

	// Token: 0x04000815 RID: 2069
	private List<string> AEMFLGKFGCP;

	// Token: 0x04000816 RID: 2070
	private List<string> LCIBPNMBEHD;

	// Token: 0x04000817 RID: 2071
	private GameObject LADDIEIMNGH;

	// Token: 0x04000818 RID: 2072
	private Transform FFHNHAFPEBB;

	// Token: 0x04000819 RID: 2073
	private bool OLNGBFLEEFE;

	// Token: 0x0400081A RID: 2074
	private DOLBFGIPPOG AENHELKPGAH;

	// Token: 0x0400081B RID: 2075
	private DOLBFGIPPOG BDFAAGGCOGF;

	// Token: 0x0400081C RID: 2076
	private int IFMCBGGOOEA;

	// Token: 0x0400081D RID: 2077
	private int NFDKDACMHME;

	// Token: 0x0400081E RID: 2078
	private Vector2 OIPMEGJLIDC;

	// Token: 0x0400081F RID: 2079
	private RectTransform FOPNADOFECH;

	// Token: 0x04000820 RID: 2080
	private bool[] MFOGPFIJKMM = new bool[6];

	// Token: 0x04000821 RID: 2081
	private bool HCMMNOJFABH;

	// Token: 0x04000822 RID: 2082
	public const int wardrobeCustomFaderIndex = 1;

	// Token: 0x04000823 RID: 2083
	public const int swipeTutorialFrameContainerIndex = 0;

	// Token: 0x04000824 RID: 2084
	public const int swipeTutorialStepIndex = 73;

	// Token: 0x04000825 RID: 2085
	private const float LMOGKFFGPEM = 0.05f;

	// Token: 0x04000826 RID: 2086
	private const float LMPLACLFFOC = 0.12f;

	// Token: 0x04000827 RID: 2087
	private const float MIPCNHPHMHH = 0.8f;

	// Token: 0x04000828 RID: 2088
	private const float JMJPFCDBFNO = 1.5f;

	// Token: 0x04000829 RID: 2089
	private bool CDIFMMOJDHA;

	// Token: 0x0400082A RID: 2090
	private Vector2 GJMOJNPJKGB = Vector2.zero;

	// Token: 0x0400082B RID: 2091
	private float KAAECELIKNM;

	// Token: 0x0400082C RID: 2092
	private bool HOLNOAJDAAA;

	// Token: 0x0400082D RID: 2093
	private GameObject FPOGOGNGDLE;

	// Token: 0x0400082E RID: 2094
	private CanvasGroup OMHKHHFGEHO;

	// Token: 0x0400082F RID: 2095
	private float BJOPEGBAEJF = 0.4f;

	// Token: 0x04000830 RID: 2096
	private float JKCAMKMBEEH = 1f;

	// Token: 0x04000831 RID: 2097
	private AssetAnthologyHeader NDFACHLEJLJ;

	// Token: 0x04000832 RID: 2098
	private bool JKAFHCIOALE;

	// Token: 0x04000833 RID: 2099
	private bool DBPFFNEGKDF;

	// Token: 0x04000834 RID: 2100
	private bool NPDBOIIBOJM;

	// Token: 0x04000835 RID: 2101
	private int JBEIKNPJGBC;

	// Token: 0x04000836 RID: 2102
	private List<string> GOFNEOPPCII = new List<string>();

	// Token: 0x04000837 RID: 2103
	private CustomWardrobeSettings LCOKEPGNEKI;

	// Token: 0x04000838 RID: 2104
	private List<GEGBHOMKNDF> PKENONODGJK = new List<GEGBHOMKNDF>();

	// Token: 0x04000839 RID: 2105
	private List<GEGBHOMKNDF> LBGFDEIBEFO = new List<GEGBHOMKNDF>();

	// Token: 0x0400083A RID: 2106
	private List<GEGBHOMKNDF> PEBPGEAGPKN = new List<GEGBHOMKNDF>();

	// Token: 0x0400083B RID: 2107
	private bool DBLGHLDMFBE;

	// Token: 0x0400083C RID: 2108
	private GEGBHOMKNDF OBIPBNFKMCC;

	// Token: 0x0400083D RID: 2109
	private GEGBHOMKNDF IMFNIHKNKPM;

	// Token: 0x0400083E RID: 2110
	private bool MKODGAPBOFH;

	// Token: 0x0400083F RID: 2111
	private bool MIFMLOLGCEN;

	// Token: 0x04000840 RID: 2112
	private bool CCDJDCMFOLA;

	// Token: 0x04000841 RID: 2113
	private bool CCDMJOOJMBJ;

	// Token: 0x04000842 RID: 2114
	private int AANAAIKPNPC = -10;

	// Token: 0x04000843 RID: 2115
	private Sequence HACNEIFDKAO;

	// Token: 0x04000844 RID: 2116
	private Vector2[] EIGPFFJAGAC;

	// Token: 0x04000845 RID: 2117
	private Sequence IEFFJDHGJBO;

	// Token: 0x04000846 RID: 2118
	private Vector2 FLPMJBFHPIB = Vector2.zero;

	// Token: 0x04000847 RID: 2119
	private bool OIJLGJAEFEP;

	// Token: 0x04000848 RID: 2120
	private string DOCIEAMHGKJ;

	// Token: 0x04000849 RID: 2121
	private List<KFIHMMIGPLO> MPOCLECLHDE = new List<KFIHMMIGPLO>();

	// Token: 0x0400084A RID: 2122
	private List<string> JBBDBBBLOHC = new List<string>();

	// Token: 0x0400084B RID: 2123
	private int IKABLPHJEBH = -1;

	// Token: 0x0400084C RID: 2124
	private string GCLOFGOFBBG = "";

	// Token: 0x0400084D RID: 2125
	private List<string> JHJCOADNIKG;

	// Token: 0x0400084E RID: 2126
	private List<string> GPMCPFBGOJA;

	// Token: 0x0400084F RID: 2127
	private List<string> OMNBGHBFMAM;

	// Token: 0x04000850 RID: 2128
	private List<string> DOENPCEJHJG;

	// Token: 0x04000851 RID: 2129
	private bool DAOONBHLIEM;

	// Token: 0x04000852 RID: 2130
	private List<Canvas> ENJGBKCFEEK = new List<Canvas>();

	// Token: 0x04000853 RID: 2131
	private string BNDFODLCCEF = "";

	// Token: 0x04000854 RID: 2132
	private string CEFHEGIGMGK = "";

	// Token: 0x020000C2 RID: 194
	[CompilerGenerated]
	private sealed class LOOCGENMJPJ
	{
		// Token: 0x06001C50 RID: 7248 RVA: 0x000CA70C File Offset: 0x000C890C
		internal void BIIFGFCDGOF()
		{
			if (null != this.fadingObject)
			{
				UnityEngine.Object.Destroy(this.fadingObject);
			}
		}

		// Token: 0x04000860 RID: 2144
		public GameObject fadingObject;
	}
}
