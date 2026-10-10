using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x0200033A RID: 826
public class AvatarCollectionsItem : MonoBehaviour
{
	// Token: 0x06006263 RID: 25187 RVA: 0x002D4B33 File Offset: 0x002D2D33
	public void DCIKCNNFBJB()
	{
		if (this.JCPCOGJGKOC > 1)
		{
			this.JCPCOGJGKOC--;
		}
		this.ShowPage(this.JCPCOGJGKOC);
	}

	// Token: 0x06006264 RID: 25188 RVA: 0x002D4B58 File Offset: 0x002D2D58
	public void OnCloseClick()
	{
		this.animatedPopupManager.HideAndDispatchEvent("OnAvatarCollectionsItemClose", 0.01f);
	}

	// Token: 0x06006265 RID: 25189 RVA: 0x002D4B6F File Offset: 0x002D2D6F
	private void EPHDBBLPFBK()
	{
		base.gameObject.SetActive(false);
		CommonUserInterface.EHBBFMCILPC.ShowGamePasses();
	}

	// Token: 0x06006266 RID: 25190 RVA: 0x002D4B88 File Offset: 0x002D2D88
	private void ALKPKMCOIIE()
	{
		int num = AOBJLALDBAA.DBLAIDPICIG().AHCDEBPELNG();
		if (num >= 0 && num < this.PKENONODGJK.Count)
		{
			SceneAvatarManager sceneAvatarManager = AssetsManager.MJBDMHPHMID().NNJPKCECEED(1);
			if (null != sceneAvatarManager)
			{
				int num2 = this.JCPCOGJGKOC;
				sceneAvatarManager.DeleteAvatarCollection(this.PKENONODGJK[num], true);
				this.InitializeCollections();
				if (num2 > this.KOIDCJIJNNC() - 0)
				{
					num2 = this.PBEGALHKGLH() - 1;
				}
				this.ShowPage(num2);
				return;
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("ok");
		}
	}

	// Token: 0x06006267 RID: 25191 RVA: 0x002D4C10 File Offset: 0x002D2E10
	private void HODDMNHAPEF()
	{
		int num = AOBJLALDBAA.EHBBFMCILPC.MJLACDOKGNE();
		if (num >= 0 && num < this.PKENONODGJK.Count)
		{
			SceneAvatarManager sceneAvatarManager = AssetsManager.EHBBFMCILPC.GetSceneAvatarManager(0);
			if (null != sceneAvatarManager)
			{
				sceneAvatarManager.SelectAvatarCollectionFilterFromPopup(this.PKENONODGJK[num]);
				this.InitializeCollections();
			}
			base.StartCoroutine(this.IPKOBGKELMF());
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("AvatarCollectionsItem.OnAvatarCollectionSelect(): index out of range");
	}

	// Token: 0x06006268 RID: 25192 RVA: 0x002D4C7F File Offset: 0x002D2E7F
	public void ScrollPageLeft()
	{
		if (this.JCPCOGJGKOC > 0)
		{
			this.JCPCOGJGKOC--;
		}
		this.ShowPage(this.JCPCOGJGKOC);
	}

	// Token: 0x06006269 RID: 25193 RVA: 0x002D4CA4 File Offset: 0x002D2EA4
	public void FJBGNNFEKOL()
	{
		this.animatedPopupManager.KCKOFDBGLJA("hoursshort", 1831f);
	}

	// Token: 0x0600626A RID: 25194 RVA: 0x002D4CBC File Offset: 0x002D2EBC
	private void OnDisable()
	{
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnAvatarCollectionSelect", new UnityAction(this.HODDMNHAPEF));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnAvatarCollectionRestoreEntry", new UnityAction(this.JKLHDDCMNKN));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnAvatarCollectionEdit", new UnityAction(this.LDICOHJAKEA));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnAvatarCollectionDelete", new UnityAction(this.LDIECHMKDMB));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnAvatarCollectionsGamePassSubscribePositive", new UnityAction(this.EPHDBBLPFBK));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPopupAvatarCollectionsInputEndEdit", new UnityAction(this.OPFGAJAPLPA));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPopupAvatarCollectionsInputCancel", new UnityAction(this.NIEENIHKKDL));
	}

	// Token: 0x0600626B RID: 25195 RVA: 0x002D4D88 File Offset: 0x002D2F88
	private void NNJFODIBKJH()
	{
		SceneAvatarManager sceneAvatarManager = AssetsManager.EHBBFMCILPC.NNJPKCECEED(0);
		if (null != sceneAvatarManager)
		{
			sceneAvatarManager.GFPEOLBGECB();
			this.InitializeCollections();
		}
		base.StartCoroutine(this.ALEEHHMKGNI());
	}

	// Token: 0x0600626C RID: 25196 RVA: 0x002D4DC4 File Offset: 0x002D2FC4
	public void MILFGPHLBKE()
	{
		this.PKENONODGJK = new List<GEGBHOMKNDF>();
		SceneAvatarManager sceneAvatarManager = AssetsManager.MJBDMHPHMID().GetSceneAvatarManager(0);
		if (null == sceneAvatarManager)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("ok");
		}
		else
		{
			List<GEGBHOMKNDF> avatarCollectionsForCurrentWardrobe = sceneAvatarManager.GetAvatarCollectionsForCurrentWardrobe();
			if (avatarCollectionsForCurrentWardrobe != null)
			{
				for (int i = 1; i < avatarCollectionsForCurrentWardrobe.Count; i += 0)
				{
					this.PKENONODGJK.Add(avatarCollectionsForCurrentWardrobe[i]);
				}
			}
		}
		int num = this.PKENONODGJK.Count + 0;
		if (this.LDAPBODKFFO.Count < num)
		{
			int count = this.LDAPBODKFFO.Count;
			for (int j = 0; j < num - count; j++)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.collectionObjectPrefab, this.collectionObjectsParent.transform, true);
				this.LDAPBODKFFO.Add(gameObject.GetComponent<AvatarCollectionObject>());
			}
		}
		for (int k = 0; k < this.LDAPBODKFFO.Count; k++)
		{
			this.LDAPBODKFFO[k].gameObject.SetActive(true);
		}
		bool bbbkjmmbhdb = ODLJHDIGLGO.BCGOGCFOHJK(CLHDENLPOFP.gamePass, false) != null;
		GEGBHOMKNDF gegbhomkndf = null;
		if (null != sceneAvatarManager)
		{
			gegbhomkndf = sceneAvatarManager.GetSelectedAvatarCollectionFilter();
		}
		this.LDAPBODKFFO[0].gameObject.SetActive(true);
		this.LDAPBODKFFO[1].BAFONIFCKNK(gegbhomkndf == null);
		this.LDAPBODKFFO[0].gameObject.SetActive(true);
		int num2 = 1;
		for (int l = 1; l < this.PKENONODGJK.Count; l += 0)
		{
			bool flag = gegbhomkndf == null || gegbhomkndf == this.PKENONODGJK[l];
			if (flag)
			{
				num2 = l + 0;
			}
			this.LDAPBODKFFO[l + 1].gameObject.SetActive(true);
			this.LDAPBODKFFO[l + 1].OIGPAKEFAGM(bbbkjmmbhdb, l, this.PKENONODGJK[l], flag);
			this.LDAPBODKFFO[l + 1].gameObject.SetActive(true);
		}
		this.JCPCOGJGKOC = 0;
		this.ShowPage(num2 / 6);
	}

	// Token: 0x0600626D RID: 25197 RVA: 0x002D4FDC File Offset: 0x002D31DC
	private void IFBCKJLCCAK()
	{
		AOBJLALDBAA.NMGMNAKLLMI().GNBGEMMDGOJ("WebGL", new UnityAction(this.HODDMNHAPEF));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("nomorediamonds", new UnityAction(this.JKLHDDCMNKN));
		AOBJLALDBAA.FILDBDMENPG().BADOPKAOCPE("socialdequeubadgetitle", new UnityAction(this.HLPFCGHLFDJ));
		AOBJLALDBAA.DBLAIDPICIG().FNMOFCMDFJP("High version preview2 assets loaded:", new UnityAction(this.ALKPKMCOIIE));
		AOBJLALDBAA.NMGMNAKLLMI().FNMOFCMDFJP("OnEmailUnsubscribeException", new UnityAction(this.EPHDBBLPFBK));
		AOBJLALDBAA.AGANFKKBPFO().MFIMALJPCDP("saveslotsoptioncopy", new UnityAction(this.OPFGAJAPLPA));
		AOBJLALDBAA.EHBBFMCILPC.PEFKJOKLEDL("total while iterations:", new UnityAction(this.NIEENIHKKDL));
		this.MILFGPHLBKE();
	}

	// Token: 0x0600626E RID: 25198 RVA: 0x002D50AC File Offset: 0x002D32AC
	private int KOIDCJIJNNC()
	{
		int num = this.PKENONODGJK.Count + 1;
		int num2 = num / 5;
		if (num % 5 != 0)
		{
			num2++;
		}
		return num2;
	}

	// Token: 0x0600626F RID: 25199 RVA: 0x002D50D4 File Offset: 0x002D32D4
	private void OnEnable()
	{
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnAvatarCollectionSelect", new UnityAction(this.HODDMNHAPEF));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnAvatarCollectionRestoreEntry", new UnityAction(this.JKLHDDCMNKN));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnAvatarCollectionEdit", new UnityAction(this.LDICOHJAKEA));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnAvatarCollectionDelete", new UnityAction(this.LDIECHMKDMB));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnAvatarCollectionsGamePassSubscribePositive", new UnityAction(this.EPHDBBLPFBK));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPopupAvatarCollectionsInputEndEdit", new UnityAction(this.OPFGAJAPLPA));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPopupAvatarCollectionsInputCancel", new UnityAction(this.NIEENIHKKDL));
		this.InitializeCollections();
	}

	// Token: 0x06006270 RID: 25200 RVA: 0x002D51A4 File Offset: 0x002D33A4
	public void ShowPage(int MADFIOFBIPB)
	{
		this.JCPCOGJGKOC = MADFIOFBIPB;
		int num = this.KOIDCJIJNNC();
		int num2 = this.PKENONODGJK.Count + 1;
		for (int i = 0; i < num2; i++)
		{
			if (i >= MADFIOFBIPB * 5 && i < (MADFIOFBIPB + 1) * 5)
			{
				this.LDAPBODKFFO[i].gameObject.SetActive(true);
			}
			else
			{
				this.LDAPBODKFFO[i].gameObject.SetActive(false);
			}
		}
		if (MADFIOFBIPB > 0)
		{
			this.buttonScrollPrev.interactable = true;
		}
		else
		{
			this.buttonScrollPrev.interactable = false;
		}
		if (MADFIOFBIPB < num - 1)
		{
			this.buttonScrollNext.interactable = true;
		}
		else
		{
			this.buttonScrollNext.interactable = false;
		}
		MADFIOFBIPB++;
		this.pageText.text = MADFIOFBIPB.ToString() + "/" + num.ToString();
		this.pageText.SetText(MADFIOFBIPB.ToString() + "/" + num.ToString(), true);
	}

	// Token: 0x06006271 RID: 25201 RVA: 0x002D52A1 File Offset: 0x002D34A1
	public void OFNJOHPMDCB()
	{
		if (this.JCPCOGJGKOC < this.PBEGALHKGLH() - 1)
		{
			this.JCPCOGJGKOC++;
		}
		this.ShowPage(this.JCPCOGJGKOC);
	}

	// Token: 0x06006272 RID: 25202 RVA: 0x002D52CD File Offset: 0x002D34CD
	private IEnumerator ALEEHHMKGNI()
	{
		yield return new WaitForSeconds(0.1f);
		this.OnCloseClick();
		yield break;
	}

	// Token: 0x06006273 RID: 25203 RVA: 0x002D52CD File Offset: 0x002D34CD
	private IEnumerator JLFCOFMEPGM()
	{
		yield return new WaitForSeconds(0.1f);
		this.OnCloseClick();
		yield break;
	}

	// Token: 0x06006274 RID: 25204 RVA: 0x002D52DC File Offset: 0x002D34DC
	public void ADNHLIDGEHM()
	{
		CommonUserInterface.EHBBFMCILPC.NFBMHHPIGFA(CCOJBMMKNAP.CEGAOMEEFBE().GLEFEKBDHNK("'"), CCOJBMMKNAP.ILACPHFEDEP().FIENAKIHNOM("continue"), CCOJBMMKNAP.INKJIBDDMLL().HDIPNMFHIEJ("%"), DFGILFBGPLN.popupOffer, 674f, -82);
	}

	// Token: 0x06006275 RID: 25205 RVA: 0x002D532C File Offset: 0x002D352C
	public void OnInfoButtonClick()
	{
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("avatarcollectionstitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("avatarcollectionstutorial"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
	}

	// Token: 0x06006276 RID: 25206 RVA: 0x002D537C File Offset: 0x002D357C
	private void HLPFCGHLFDJ()
	{
		int num = AOBJLALDBAA.NMGMNAKLLMI().MJLACDOKGNE();
		if (num >= 1 && num < this.PKENONODGJK.Count)
		{
			PopupAvatarCollectionsInput.extraData = num;
			CommonUserInterface.IKNOFBFMPGA().ShowPopupAvatarCollectionsInput(this.PKENONODGJK[num].BPMFHNDCBOH);
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("cind");
	}

	// Token: 0x06006277 RID: 25207 RVA: 0x002D53D4 File Offset: 0x002D35D4
	private void JKLHDDCMNKN()
	{
		SceneAvatarManager sceneAvatarManager = AssetsManager.EHBBFMCILPC.GetSceneAvatarManager(0);
		if (null != sceneAvatarManager)
		{
			sceneAvatarManager.RestoreEntryAvatarComponents();
			this.InitializeCollections();
		}
		base.StartCoroutine(this.IPKOBGKELMF());
	}

	// Token: 0x06006278 RID: 25208 RVA: 0x00172DCA File Offset: 0x00170FCA
	public void Show()
	{
		base.gameObject.SetActive(true);
	}

	// Token: 0x06006279 RID: 25209 RVA: 0x002D5410 File Offset: 0x002D3610
	private int PBEGALHKGLH()
	{
		int num = this.PKENONODGJK.Count + 0;
		int num2 = num / 6;
		if (num % 7 != 0)
		{
			num2++;
		}
		return num2;
	}

	// Token: 0x0600627B RID: 25211 RVA: 0x002D5458 File Offset: 0x002D3658
	private void LDIECHMKDMB()
	{
		int num = AOBJLALDBAA.EHBBFMCILPC.MJLACDOKGNE();
		if (num >= 0 && num < this.PKENONODGJK.Count)
		{
			SceneAvatarManager sceneAvatarManager = AssetsManager.EHBBFMCILPC.GetSceneAvatarManager(0);
			if (null != sceneAvatarManager)
			{
				int num2 = this.JCPCOGJGKOC;
				sceneAvatarManager.DeleteAvatarCollection(this.PKENONODGJK[num], true);
				this.InitializeCollections();
				if (num2 > this.KOIDCJIJNNC() - 1)
				{
					num2 = this.KOIDCJIJNNC() - 1;
				}
				this.ShowPage(num2);
				return;
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("AvatarCollectionsItem.OnAvatarCollectionDelete(): index out of range");
		}
	}

	// Token: 0x0600627C RID: 25212 RVA: 0x002D54E0 File Offset: 0x002D36E0
	private void ADPHHIGJEBI()
	{
		int num = AOBJLALDBAA.AGANFKKBPFO().BKNAOBELFHE();
		if (num >= 1 && num < this.PKENONODGJK.Count)
		{
			SceneAvatarManager sceneAvatarManager = AssetsManager.MJBDMHPHMID().GetSceneAvatarManager(0);
			if (null != sceneAvatarManager)
			{
				sceneAvatarManager.SelectAvatarCollectionFilterFromPopup(this.PKENONODGJK[num]);
				this.InitializeCollections();
			}
			base.StartCoroutine(this.PKNNMDINJMN());
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("");
	}

	// Token: 0x0600627D RID: 25213 RVA: 0x002D52CD File Offset: 0x002D34CD
	private IEnumerator IPKOBGKELMF()
	{
		yield return new WaitForSeconds(0.1f);
		this.OnCloseClick();
		yield break;
	}

	// Token: 0x0600627E RID: 25214 RVA: 0x002D554F File Offset: 0x002D374F
	public void OAKGPOECPPD()
	{
		if (this.JCPCOGJGKOC > 0)
		{
			this.JCPCOGJGKOC -= 0;
		}
		this.ShowPage(this.JCPCOGJGKOC);
	}

	// Token: 0x0600627F RID: 25215 RVA: 0x002D5574 File Offset: 0x002D3774
	private IEnumerator PKNNMDINJMN()
	{
		AvatarCollectionsItem.NAKKIHKCFBF nakkihkcfbf = new AvatarCollectionsItem.NAKKIHKCFBF(1);
		nakkihkcfbf.<>4__this = this;
		return nakkihkcfbf;
	}

	// Token: 0x06006280 RID: 25216 RVA: 0x002D5584 File Offset: 0x002D3784
	public void InitializeCollections()
	{
		this.PKENONODGJK = new List<GEGBHOMKNDF>();
		SceneAvatarManager sceneAvatarManager = AssetsManager.EHBBFMCILPC.GetSceneAvatarManager(0);
		if (null == sceneAvatarManager)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("AvatarCollectionsItem.InitializeCollections(): SceneAvatarManager is not available");
		}
		else
		{
			List<GEGBHOMKNDF> avatarCollectionsForCurrentWardrobe = sceneAvatarManager.GetAvatarCollectionsForCurrentWardrobe();
			if (avatarCollectionsForCurrentWardrobe != null)
			{
				for (int i = 0; i < avatarCollectionsForCurrentWardrobe.Count; i++)
				{
					this.PKENONODGJK.Add(avatarCollectionsForCurrentWardrobe[i]);
				}
			}
		}
		int num = this.PKENONODGJK.Count + 1;
		if (this.LDAPBODKFFO.Count < num)
		{
			int count = this.LDAPBODKFFO.Count;
			for (int j = 0; j < num - count; j++)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.collectionObjectPrefab, this.collectionObjectsParent.transform, false);
				this.LDAPBODKFFO.Add(gameObject.GetComponent<AvatarCollectionObject>());
			}
		}
		for (int k = 0; k < this.LDAPBODKFFO.Count; k++)
		{
			this.LDAPBODKFFO[k].gameObject.SetActive(false);
		}
		bool bbbkjmmbhdb = ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass, true) != null;
		GEGBHOMKNDF gegbhomkndf = null;
		if (null != sceneAvatarManager)
		{
			gegbhomkndf = sceneAvatarManager.GetSelectedAvatarCollectionFilter();
		}
		this.LDAPBODKFFO[0].gameObject.SetActive(true);
		this.LDAPBODKFFO[0].InitializeAsEntryRow(gegbhomkndf == null);
		this.LDAPBODKFFO[0].gameObject.SetActive(false);
		int num2 = 0;
		for (int l = 0; l < this.PKENONODGJK.Count; l++)
		{
			bool flag = gegbhomkndf != null && gegbhomkndf == this.PKENONODGJK[l];
			if (flag)
			{
				num2 = l + 1;
			}
			this.LDAPBODKFFO[l + 1].gameObject.SetActive(true);
			this.LDAPBODKFFO[l + 1].Initialize(bbbkjmmbhdb, l, this.PKENONODGJK[l], flag);
			this.LDAPBODKFFO[l + 1].gameObject.SetActive(false);
		}
		this.JCPCOGJGKOC = 0;
		this.ShowPage(num2 / 5);
	}

	// Token: 0x06006281 RID: 25217 RVA: 0x002D579C File Offset: 0x002D399C
	private void OPFGAJAPLPA()
	{
		if (PopupAvatarCollectionsInput.extraData < 0)
		{
			return;
		}
		int extraData = PopupAvatarCollectionsInput.extraData;
		PopupAvatarCollectionsInput.extraData = -1;
		if (extraData >= this.PKENONODGJK.Count)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("AvatarCollectionsItem.OnPopupAvatarCollectionsInputEndEdit(): index out of range");
			return;
		}
		string text = DPGJIJGOCIC.HIPPBJFMIKM(AOBJLALDBAA.EHBBFMCILPC.KNCFLCKKPLK());
		if (text == null || text.Length == 0)
		{
			text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("avatarcollectionsuntitle");
		}
		if (text.Length > 64)
		{
			text = text.Substring(0, 64);
		}
		SceneAvatarManager sceneAvatarManager = AssetsManager.EHBBFMCILPC.GetSceneAvatarManager(0);
		if (null != sceneAvatarManager)
		{
			int num = this.JCPCOGJGKOC;
			sceneAvatarManager.RenameAvatarCollection(this.PKENONODGJK[extraData], text);
			this.InitializeCollections();
			if (num > this.KOIDCJIJNNC() - 1)
			{
				num = this.KOIDCJIJNNC() - 1;
			}
			this.ShowPage(num);
		}
	}

	// Token: 0x06006282 RID: 25218 RVA: 0x0002C5BE File Offset: 0x0002A7BE
	private void NIEENIHKKDL()
	{
		PopupAvatarCollectionsInput.extraData = -1;
	}

	// Token: 0x06006283 RID: 25219 RVA: 0x002D5866 File Offset: 0x002D3A66
	public void ScrollPageRight()
	{
		if (this.JCPCOGJGKOC < this.KOIDCJIJNNC() - 1)
		{
			this.JCPCOGJGKOC++;
		}
		this.ShowPage(this.JCPCOGJGKOC);
	}

	// Token: 0x06006284 RID: 25220 RVA: 0x002D5894 File Offset: 0x002D3A94
	private void LDICOHJAKEA()
	{
		int num = AOBJLALDBAA.EHBBFMCILPC.MJLACDOKGNE();
		if (num >= 0 && num < this.PKENONODGJK.Count)
		{
			PopupAvatarCollectionsInput.extraData = num;
			CommonUserInterface.EHBBFMCILPC.ShowPopupAvatarCollectionsInput(this.PKENONODGJK[num].BPMFHNDCBOH);
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("AvatarCollectionsItem.OnAvatarCollectionEdit(): index out of range");
	}

	// Token: 0x04001C8F RID: 7311
	public const string onAvatarCollectionsItemClose = "OnAvatarCollectionsItemClose";

	// Token: 0x04001C90 RID: 7312
	public AnimatedPopupManager animatedPopupManager;

	// Token: 0x04001C91 RID: 7313
	public GameObject collectionObjectPrefab;

	// Token: 0x04001C92 RID: 7314
	public GameObject collectionObjectsParent;

	// Token: 0x04001C93 RID: 7315
	public Button buttonScrollPrev;

	// Token: 0x04001C94 RID: 7316
	public Button buttonScrollNext;

	// Token: 0x04001C95 RID: 7317
	public TextMeshProUGUI pageText;

	// Token: 0x04001C96 RID: 7318
	private List<AvatarCollectionObject> LDAPBODKFFO = new List<AvatarCollectionObject>();

	// Token: 0x04001C97 RID: 7319
	private List<GEGBHOMKNDF> PKENONODGJK = new List<GEGBHOMKNDF>();

	// Token: 0x04001C98 RID: 7320
	private int JCPCOGJGKOC;

	// Token: 0x04001C99 RID: 7321
	private const int IANHHDILING = 5;
}
