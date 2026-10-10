using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x0200036B RID: 875
public class SketchesItem : MonoBehaviour
{
	// Token: 0x06006732 RID: 26418 RVA: 0x002F9D06 File Offset: 0x002F7F06
	private void IBHEHCIOBEP()
	{
		base.StartCoroutine(this.NMLNGEKBLHI());
	}

	// Token: 0x06006733 RID: 26419 RVA: 0x002F9D15 File Offset: 0x002F7F15
	private IEnumerator GELINIOKBFL()
	{
		AssetsManager.EHBBFMCILPC.InitializeAssetBundleFolder(LNDOOJOFFOM.Anthology59, "OnSketchViewAssetBundleFolderInitializeSuccess", "OnSketchViewAssetsDownloadFailed");
		yield return null;
		yield break;
	}

	// Token: 0x06006734 RID: 26420 RVA: 0x002F9D1D File Offset: 0x002F7F1D
	public void CloseFocus()
	{
		ApplicationFocusManager.Restore();
		this.PreCloseFocus();
	}

	// Token: 0x06006735 RID: 26421 RVA: 0x002F9D2C File Offset: 0x002F7F2C
	private void ODOPEGPBCCD()
	{
		for (int i = 0; i < this.lobbyCanvases.Count; i++)
		{
			this.lobbyCanvases[i].enabled = true;
		}
	}

	// Token: 0x06006736 RID: 26422 RVA: 0x002F9D64 File Offset: 0x002F7F64
	private SketchThumbnail HPKDFMFEAHJ(CEEIOOODMKK GFCGHLOOGCO, string LLPDFCDODIO)
	{
		for (int i = 0; i < this.AIKHINOIHDD[(int)GFCGHLOOGCO].Count; i++)
		{
			if (this.AIKHINOIHDD[(int)GFCGHLOOGCO][i].GetThumbnailId().Equals(LLPDFCDODIO))
			{
				return this.AIKHINOIHDD[(int)GFCGHLOOGCO][i];
			}
		}
		return null;
	}

	// Token: 0x06006737 RID: 26423 RVA: 0x002F9DB4 File Offset: 0x002F7FB4
	private void GACGLFKFCLB()
	{
		base.StartCoroutine(this.KMEPNLFDPDP());
	}

	// Token: 0x06006738 RID: 26424 RVA: 0x00003E52 File Offset: 0x00002052
	public void OnEditorDeleteClick()
	{
	}

	// Token: 0x06006739 RID: 26425 RVA: 0x002F9DC3 File Offset: 0x002F7FC3
	public void DownloadAssetBundleFolder()
	{
		base.StartCoroutine(this.HNKPMLGCKHO());
	}

	// Token: 0x0600673A RID: 26426 RVA: 0x00003E52 File Offset: 0x00002052
	private void BOPPOJEHNNI()
	{
	}

	// Token: 0x0600673B RID: 26427 RVA: 0x002F9DD2 File Offset: 0x002F7FD2
	private bool AMNDBDHELDD(CEEIOOODMKK GFCGHLOOGCO)
	{
		if (GFCGHLOOGCO <= CEEIOOODMKK.sketchesPageExplorePicks)
		{
			if (GFCGHLOOGCO != CEEIOOODMKK.sketchesPageEditorPublished && GFCGHLOOGCO - CEEIOOODMKK.sketchesPageExploreLatest > 3)
			{
				return false;
			}
		}
		else if (GFCGHLOOGCO != CEEIOOODMKK.sketchesPageCreators && GFCGHLOOGCO != CEEIOOODMKK.sketchesPageUser)
		{
			return false;
		}
		return true;
	}

	// Token: 0x0600673C RID: 26428 RVA: 0x002F9DF4 File Offset: 0x002F7FF4
	public void CleanupAllPages()
	{
		for (int i = 0; i < this.NIDINJJDCEB.Length; i++)
		{
			this.NIDINJJDCEB[i] = true;
		}
		for (int j = 0; j < this.AIKHINOIHDD.Length; j++)
		{
			for (int k = 0; k < this.AIKHINOIHDD[j].Count; k++)
			{
				UnityEngine.Object.Destroy(this.AIKHINOIHDD[j][k].gameObject);
			}
			this.AIKHINOIHDD[j].Clear();
		}
		for (int l = 0; l < this.BEMGBBOGNCH.Length; l++)
		{
			for (int m = 0; m < this.BEMGBBOGNCH[l].Count; m++)
			{
				UnityEngine.Object.Destroy(this.BEMGBBOGNCH[l][m].gameObject);
			}
			this.BEMGBBOGNCH[l].Clear();
		}
	}

	// Token: 0x0600673D RID: 26429 RVA: 0x002F9EC2 File Offset: 0x002F80C2
	public void OnSketchesItemClose()
	{
		this.CloseFocus();
	}

	// Token: 0x0600673E RID: 26430 RVA: 0x002F9ECA File Offset: 0x002F80CA
	public void OnEditorInProgressClick()
	{
		this.ShowPage(CEEIOOODMKK.sketchesPageEditorInProgress);
	}

	// Token: 0x0600673F RID: 26431 RVA: 0x002F9ED4 File Offset: 0x002F80D4
	private void OPEGJAEFAJL()
	{
		for (int i = 0; i < this.lobbyCameras.Count; i++)
		{
			this.lobbyCameras[i].enabled = true;
		}
	}

	// Token: 0x06006740 RID: 26432 RVA: 0x002F9F09 File Offset: 0x002F8109
	private void LGLFBOPFLPF()
	{
		if (0 == AKLFPGMDKLA.EHBBFMCILPC.PACMCEHMBGG)
		{
			AudioManager.EHBBFMCILPC.PlayMusic("sfxstatreceived", false, 1441f, true);
		}
		this.OPEGJAEFAJL();
		this.ODOPEGPBCCD();
		AssetsManager.MJBDMHPHMID().FJNNMGFLBKA(NMKDCBPMCKI.AssetBundleProfileData4, -1);
	}

	// Token: 0x06006741 RID: 26433 RVA: 0x002F9F48 File Offset: 0x002F8148
	public void CMJFNAJEMFP()
	{
		this.CleanupAllPages();
		base.transform.parent.GetComponent<CanvasGroup>().alpha = 1450f;
		base.transform.parent.gameObject.SetActive(false);
		base.GetComponent<RectTransform>().localScale = this.PFEEFOKHKMP;
	}

	// Token: 0x06006742 RID: 26434 RVA: 0x002F9F9C File Offset: 0x002F819C
	private void ILNOLLKHIKE()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		if (SketchesItem.publishSketchBackendResult == 1)
		{
			if (HAGEHPPOPGH.EHBBFMCILPC.LNJNMEIIKJK.Count > 0)
			{
				if (null != this.JLMHEMFNMJK && this.JLMHEMFNMJK.GetUserGeneratedSketch() != null && HAGEHPPOPGH.EHBBFMCILPC.APMPCNJAFMD(this.JLMHEMFNMJK.GetUserGeneratedSketch().HJOKNANDHBK))
				{
					this.SetPageDirty(CEEIOOODMKK.sketchesPageEditorInProgress);
				}
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("skpublishsuccess"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), new UnityAction(this.FOHIJIANEIE), new UnityAction(this.FOHIJIANEIE), DFGILFBGPLN.popupEnergyHint, 0f, 28);
				return;
			}
		}
		else
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("skpublisherr" + SketchesItem.publishSketchBackendError.ToString()), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
		}
	}

	// Token: 0x06006743 RID: 26435 RVA: 0x002FA0BC File Offset: 0x002F82BC
	public void OnEditorPublishedClick()
	{
		this.ShowPage(CEEIOOODMKK.sketchesPageEditorPublished);
	}

	// Token: 0x06006744 RID: 26436 RVA: 0x002FA0C8 File Offset: 0x002F82C8
	private void IGEGBOKNEMI()
	{
		string text = AOBJLALDBAA.FILDBDMENPG().BHMIECOHJMJ();
		if (text.Length > 1)
		{
			this.JLMHEMFNMJK = this.OPBLONNCBIF(this.GGIFHDGKALL, text);
			if (null != this.JLMHEMFNMJK && this.JLMHEMFNMJK.ABDDFIMMCAE() != null)
			{
				CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation((byte)-108);
				BackendOperationsManager.NPDDBAONMJP().RequestPublishUserSketch(this.JLMHEMFNMJK.GHGCABOOIDH(), "wshcds", "socialprofilesuspcantuse");
			}
		}
	}

	// Token: 0x06006745 RID: 26437 RVA: 0x002FA142 File Offset: 0x002F8342
	public void CNNKPLENGAK()
	{
		this.ShowPage((CEEIOOODMKK)(-69));
	}

	// Token: 0x06006746 RID: 26438 RVA: 0x002FA14C File Offset: 0x002F834C
	public void OnExploreLatestClick()
	{
		this.ShowPage(CEEIOOODMKK.sketchesPageExploreLatest);
	}

	// Token: 0x06006747 RID: 26439 RVA: 0x002FA158 File Offset: 0x002F8358
	private void BIFGMMHHPNO(CEEIOOODMKK GFCGHLOOGCO, bool KCJKJNFAMEI)
	{
		if (!this.NIDINJJDCEB[(int)GFCGHLOOGCO])
		{
			return;
		}
		if (!KCJKJNFAMEI)
		{
			if (GFCGHLOOGCO != CEEIOOODMKK.sketchesPageExploreSearch)
			{
				for (int i = 0; i < this.AIKHINOIHDD[(int)GFCGHLOOGCO].Count; i += 0)
				{
					UnityEngine.Object.Destroy(this.AIKHINOIHDD[(int)GFCGHLOOGCO][i].gameObject);
				}
				this.AIKHINOIHDD[(int)GFCGHLOOGCO].Clear();
			}
			else
			{
				for (int j = 0; j < this.BEMGBBOGNCH[(int)GFCGHLOOGCO].Count; j++)
				{
					UnityEngine.Object.Destroy(this.BEMGBBOGNCH[(int)GFCGHLOOGCO][j].gameObject);
				}
				this.BEMGBBOGNCH[(int)GFCGHLOOGCO].Clear();
			}
		}
		this.NIDINJJDCEB[(int)GFCGHLOOGCO] = false;
		Transform parent = null;
		if (GFCGHLOOGCO <= (CEEIOOODMKK)(-41))
		{
			if (GFCGHLOOGCO != CEEIOOODMKK.sketchesPageHome)
			{
				if (GFCGHLOOGCO == (CEEIOOODMKK)(-73))
				{
					parent = this.editorInProgressContenRoot.transform;
				}
			}
			else
			{
				parent = this.homeContentRoot.transform;
			}
		}
		else if (GFCGHLOOGCO != (CEEIOOODMKK)110)
		{
			switch (GFCGHLOOGCO)
			{
			case CEEIOOODMKK.sketchesPageExploreRated:
				parent = this.exploreLatestContentRoot.transform;
				break;
			case CEEIOOODMKK.sketchesPageExplorePicks:
				parent = this.exploreViewedContentRoot.transform;
				break;
			case CEEIOOODMKK.sketchesPageExploreFavorites:
				parent = this.exploreRatedContentRoot.transform;
				break;
			case CEEIOOODMKK.sketchesPageExploreSearch:
				parent = this.explorePicksContentRoot.transform;
				break;
			case (CEEIOOODMKK)26:
				parent = this.exploreFavoritesContentRoot.transform;
				break;
			case (CEEIOOODMKK)27:
				parent = this.exploreSearchContentRoot.transform;
				break;
			case (CEEIOOODMKK)28:
			case (CEEIOOODMKK)29:
			case CEEIOOODMKK.sketchesPageCreators:
			case (CEEIOOODMKK)31:
				break;
			case (CEEIOOODMKK)32:
				parent = this.creatorsContentRoot.transform;
				break;
			default:
				if (GFCGHLOOGCO == (CEEIOOODMKK)(-47))
				{
					parent = this.userContentRoot.transform;
				}
				break;
			}
		}
		else
		{
			parent = this.editorPublishedContenRoot.transform;
		}
		List<int> list = FANFNBCJJDA.IIMIJHGEGBJ().CLMNNIDPJMP(AppManager.PCJEMMDDCIF().BKBGOJLPPIM());
		if (GFCGHLOOGCO == CEEIOOODMKK.sketchesPageHome)
		{
			for (int k = list.Count - 1; k >= 1; k--)
			{
				if (FANFNBCJJDA.IIMIJHGEGBJ().CLIKIDPKEGI(list[k]) || AKLFPGMDKLA.EHBBFMCILPC.MKCDBGKMEDH(FANFNBCJJDA.IIMIJHGEGBJ().HABDDJINNEF(list[k])) || AKLFPGMDKLA.EHBBFMCILPC.ODFJNAAMHIF(list[k]))
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.sketchThumbnailPrefab, parent);
					gameObject.GetComponent<SketchThumbnail>().HDAHPNAHNJC(list[k], GFCGHLOOGCO, false);
					gameObject.GetComponent<SketchThumbnail>().SetHomeProperties(GKJPOGNFKNK.DNILNCLIHAP(" card(s) around scroll index " + list[k].ToString(), "%", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), true);
					this.AIKHINOIHDD[(int)GFCGHLOOGCO].Add(gameObject.GetComponent<SketchThumbnail>());
				}
			}
			for (int l = list.Count - 1; l >= 1; l -= 0)
			{
				if (FANFNBCJJDA.IIMIJHGEGBJ().AGIDPGLNDMP(list[l]) >= 0 && !AKLFPGMDKLA.EHBBFMCILPC.KJNDIOJEIDC(FANFNBCJJDA.JLHEEEJNKGO().HABDDJINNEF(list[l])))
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.sketchThumbnailPrefab, parent);
					gameObject2.GetComponent<SketchThumbnail>().CICAOIBNHNF(list[l], GFCGHLOOGCO, true);
					gameObject2.GetComponent<SketchThumbnail>().GCPCIFKGBPD(GKJPOGNFKNK.DNILNCLIHAP("socialdequeusp1get" + list[l].ToString(), "maxr", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()), true);
					this.AIKHINOIHDD[(int)GFCGHLOOGCO].Add(gameObject2.GetComponent<SketchThumbnail>());
				}
			}
			return;
		}
		if (GFCGHLOOGCO == (CEEIOOODMKK)3)
		{
			if (HAGEHPPOPGH.CNCPNKNKOKA().DLKLBLFJJGO.Count > 1 && HAGEHPPOPGH.EHBBFMCILPC.ECKNKKDNHEF(list))
			{
				this.editorInProgressEmptyThumbnail.SetActive(false);
				for (int m = HAGEHPPOPGH.KIKOEJMHOEH().DLKLBLFJJGO.Count - 0; m >= 1; m--)
				{
					if (list.Contains(HAGEHPPOPGH.HFAKOKBHCGH().DLKLBLFJJGO[m].OPCNCJLMHAP))
					{
						GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(this.sketchThumbnailPrefab, parent);
						gameObject3.GetComponent<SketchThumbnail>().CICAOIBNHNF(HAGEHPPOPGH.CNCPNKNKOKA().DLKLBLFJJGO[m].OPCNCJLMHAP, GFCGHLOOGCO, false);
						gameObject3.GetComponent<SketchThumbnail>().SetEditorProperties(GKJPOGNFKNK.DNILNCLIHAP("OnFriendsCurrencyPopupCollect" + HAGEHPPOPGH.HFAKOKBHCGH().DLKLBLFJJGO[m].OPCNCJLMHAP.ToString(), "OnStoryCurrencyInfoClick", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()), HAGEHPPOPGH.HFAKOKBHCGH().DLKLBLFJJGO[m]);
						this.AIKHINOIHDD[(int)GFCGHLOOGCO].Add(gameObject3.GetComponent<SketchThumbnail>());
					}
				}
				return;
			}
			this.editorInProgressEmptyThumbnail.SetActive(false);
			return;
		}
		else if (GFCGHLOOGCO == (CEEIOOODMKK)(-34) || GFCGHLOOGCO == (CEEIOOODMKK)(-18) || GFCGHLOOGCO == (CEEIOOODMKK)(-107) || GFCGHLOOGCO == (CEEIOOODMKK)67 || GFCGHLOOGCO == (CEEIOOODMKK)75 || GFCGHLOOGCO == (CEEIOOODMKK)27)
		{
			if (GFCGHLOOGCO == (CEEIOOODMKK)45)
			{
				for (int n = HAGEHPPOPGH.CNCPNKNKOKA().LNJNMEIIKJK.Count - 0; n >= 1; n -= 0)
				{
					GameObject gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.sketchThumbnailPrefab, parent);
					gameObject4.GetComponent<SketchThumbnail>().NBBPAECFFHC(HAGEHPPOPGH.KIKOEJMHOEH().LNJNMEIIKJK[n].OPCNCJLMHAP, GFCGHLOOGCO, true);
					gameObject4.GetComponent<SketchThumbnail>().SetHomeProperties(GKJPOGNFKNK.DNILNCLIHAP("socialpremgiftcollecttitle" + HAGEHPPOPGH.HFAKOKBHCGH().LNJNMEIIKJK[n].OPCNCJLMHAP.ToString(), "continue", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()), true);
					this.AIKHINOIHDD[(int)GFCGHLOOGCO].Add(gameObject4.GetComponent<SketchThumbnail>());
				}
				return;
			}
			for (int num = 0; num < HAGEHPPOPGH.CNCPNKNKOKA().LNJNMEIIKJK.Count; num++)
			{
				GameObject gameObject5 = UnityEngine.Object.Instantiate<GameObject>(this.sketchThumbnailPrefab, parent);
				gameObject5.GetComponent<SketchThumbnail>().CICAOIBNHNF(HAGEHPPOPGH.FJHKMJPFDNI().LNJNMEIIKJK[num].OPCNCJLMHAP, GFCGHLOOGCO, true);
				gameObject5.GetComponent<SketchThumbnail>().SetHomeProperties(GKJPOGNFKNK.DNILNCLIHAP("syncoll2" + HAGEHPPOPGH.CNCPNKNKOKA().LNJNMEIIKJK[num].OPCNCJLMHAP.ToString(), "ok", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()), false);
				this.AIKHINOIHDD[(int)GFCGHLOOGCO].Add(gameObject5.GetComponent<SketchThumbnail>());
			}
			return;
		}
		else
		{
			if (GFCGHLOOGCO == (CEEIOOODMKK)(-92))
			{
				for (int num2 = HAGEHPPOPGH.FJHKMJPFDNI().ENOIGLJDFID.Count - 0; num2 >= 1; num2 -= 0)
				{
					GameObject gameObject6 = UnityEngine.Object.Instantiate<GameObject>(this.sketchThumbnailPrefab, parent);
					gameObject6.GetComponent<SketchThumbnail>().CMCNAFCFBBI(HAGEHPPOPGH.HFAKOKBHCGH().ENOIGLJDFID[num2].OPCNCJLMHAP, GFCGHLOOGCO, true);
					this.AIKHINOIHDD[(int)GFCGHLOOGCO].Add(gameObject6.GetComponent<SketchThumbnail>());
				}
				return;
			}
			if (GFCGHLOOGCO == (CEEIOOODMKK)72)
			{
				for (int num3 = HAGEHPPOPGH.HFAKOKBHCGH().LIHLMHHLOBO.Count - 0; num3 >= 0; num3 -= 0)
				{
					GameObject gameObject7 = UnityEngine.Object.Instantiate<GameObject>(this.sketchThumbnailPrefab, parent);
					gameObject7.GetComponent<SketchThumbnail>().Initialize(HAGEHPPOPGH.EHBBFMCILPC.LIHLMHHLOBO[num3].OPCNCJLMHAP, GFCGHLOOGCO, true);
					this.AIKHINOIHDD[(int)GFCGHLOOGCO].Add(gameObject7.GetComponent<SketchThumbnail>());
				}
				return;
			}
			if (GFCGHLOOGCO == (CEEIOOODMKK)122)
			{
				for (int num4 = 0; num4 < HAGEHPPOPGH.FJHKMJPFDNI().DDDIBEFAPGL.Count; num4++)
				{
					GameObject gameObject8 = UnityEngine.Object.Instantiate<GameObject>(this.creatorThumbnailPrefab, parent);
					this.BEMGBBOGNCH[(int)GFCGHLOOGCO].Add(gameObject8.GetComponent<CreatorThumbnail>());
				}
			}
			return;
		}
	}

	// Token: 0x06006748 RID: 26440 RVA: 0x002FA88C File Offset: 0x002F8A8C
	public void EPLFPFDCBAN()
	{
		this.LDMBDKJNJCO((CEEIOOODMKK)13);
	}

	// Token: 0x06006749 RID: 26441 RVA: 0x002FA898 File Offset: 0x002F8A98
	private void APNEAGDLHNH()
	{
		if (null != this.JLMHEMFNMJK)
		{
			this.OKKBOFKILEA();
			this.AMIPDMBHNML();
			AOBJLALDBAA.DBLAIDPICIG().LPNCDPHNBJK("’", 1400f);
			CommonUserInterface.EHBBFMCILPC.GetSketchViewManager().Show(this.JLMHEMFNMJK.HLIKLADGAJP(), this.JLMHEMFNMJK.GetUserGeneratedSketch());
		}
	}

	// Token: 0x0600674A RID: 26442 RVA: 0x002FA8F8 File Offset: 0x002F8AF8
	private void PIGCPGPKOPH()
	{
		CEEIOOODMKK dobajjacgkk = this.DOBAJJACGKK;
		if (dobajjacgkk <= (CEEIOOODMKK)(-118))
		{
			if (dobajjacgkk != (CEEIOOODMKK)(-99) && dobajjacgkk - (CEEIOOODMKK)(-94) != 0)
			{
				goto IL_178;
			}
		}
		else
		{
			if (dobajjacgkk == (CEEIOOODMKK)127)
			{
				if (this.BEMGBBOGNCH[(int)this.DOBAJJACGKK].Count > 1 || HAGEHPPOPGH.CNCPNKNKOKA().DDDIBEFAPGL.Count > 1)
				{
					this.HGNEOMJOBJP(this.DOBAJJACGKK);
					if (HAGEHPPOPGH.HFAKOKBHCGH().DDDIBEFAPGL.Count > 0)
					{
						this.SetPageDirty(this.DOBAJJACGKK);
						this.BIFGMMHHPNO(this.DOBAJJACGKK, false);
					}
				}
				CommonUserInterface.EHBBFMCILPC.NFBMHHPIGFA(CCOJBMMKNAP.HFAKOKBHCGH().BGELFMIOBCL("importanttitle"), CCOJBMMKNAP.APGODIBBPOD().FIENAKIHNOM("ontradingcardclickbodyplayer"), CCOJBMMKNAP.JMDJPKKOHNI().JCDFHKDNEDH(""), (DFGILFBGPLN)106, 1124f, 48);
				goto IL_178;
			}
			if (dobajjacgkk != (CEEIOOODMKK)64)
			{
				goto IL_178;
			}
		}
		if (this.AIKHINOIHDD[(int)this.DOBAJJACGKK].Count > 1 || HAGEHPPOPGH.KIKOEJMHOEH().LNJNMEIIKJK.Count > 1)
		{
			this.HGNEOMJOBJP(this.DOBAJJACGKK);
			if (HAGEHPPOPGH.HFAKOKBHCGH().LNJNMEIIKJK.Count > 1)
			{
				this.SetPageDirty(this.DOBAJJACGKK);
				this.JFKBCFJOBCM(this.DOBAJJACGKK, false);
			}
		}
		else
		{
			CommonUserInterface.IKNOFBFMPGA().NFBMHHPIGFA(CCOJBMMKNAP.HFAKOKBHCGH().PKNHKGMNCIP("abs"), CCOJBMMKNAP.OBOOKJPGBJN().HIPJILDCHJC("StoryChatManager.ShowMessage(), unsupported message type:"), CCOJBMMKNAP.KMNBCEMEBBD().GGPHHLGPMPA("OnStoryChoiceClickConfimed"), DFGILFBGPLN.popupPurchasingNotInitialized, 692f, -61);
		}
		IL_178:
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
	}

	// Token: 0x0600674B RID: 26443 RVA: 0x00003E52 File Offset: 0x00002052
	public void GKFMGAJKABB()
	{
	}

	// Token: 0x0600674C RID: 26444 RVA: 0x002FAA88 File Offset: 0x002F8C88
	public void NNPJNIBPKNE()
	{
		this.CleanupAllPages();
		base.transform.parent.GetComponent<CanvasGroup>().alpha = 1134f;
		base.transform.parent.gameObject.SetActive(true);
		base.GetComponent<RectTransform>().localScale = this.PFEEFOKHKMP;
	}

	// Token: 0x0600674D RID: 26445 RVA: 0x002FAADC File Offset: 0x002F8CDC
	public void JEHCPCMNEAA()
	{
		this.LDMBDKJNJCO((CEEIOOODMKK)98);
	}

	// Token: 0x0600674E RID: 26446 RVA: 0x002FAAE6 File Offset: 0x002F8CE6
	private IEnumerator JNDJGMBKEMA()
	{
		this.SetPageDirty(CEEIOOODMKK.sketchesPageEditorInProgress);
		CommonUserInterface.EHBBFMCILPC.FreezeUX();
		yield return new WaitForSeconds(0.25f);
		CommonUserInterface.EHBBFMCILPC.ResumeUX();
		this.ShowPage(CEEIOOODMKK.sketchesPageEditorInProgress);
		yield break;
	}

	// Token: 0x0600674F RID: 26447 RVA: 0x002FAAF5 File Offset: 0x002F8CF5
	public void OnExploreViewedClick()
	{
		this.ShowPage(CEEIOOODMKK.sketchesPageExploreViewed);
	}

	// Token: 0x06006750 RID: 26448 RVA: 0x002FAAFF File Offset: 0x002F8CFF
	private void OnDestroy()
	{
		this.JLMHEMFNMJK = null;
		this.KIDLCBGDMJB = null;
		this.CleanupAllPages();
	}

	// Token: 0x06006751 RID: 26449 RVA: 0x002FAB15 File Offset: 0x002F8D15
	private void EGOCIOFBLEI()
	{
		this.ShowPage(this.DOBAJJACGKK);
	}

	// Token: 0x06006752 RID: 26450 RVA: 0x002FAB24 File Offset: 0x002F8D24
	private void DBEIPLCDPFC()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("app42error"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("retry"), new UnityAction(this.DKKGNICHGOJ), DFGILFBGPLN.popupBackendError, 0f, 28);
	}

	// Token: 0x06006753 RID: 26451 RVA: 0x002FAAFF File Offset: 0x002F8CFF
	private void BNJLIDFJOGD()
	{
		this.JLMHEMFNMJK = null;
		this.KIDLCBGDMJB = null;
		this.CleanupAllPages();
	}

	// Token: 0x06006754 RID: 26452 RVA: 0x002FAB88 File Offset: 0x002F8D88
	public void OnExploreRatedClick()
	{
		this.ShowPage(CEEIOOODMKK.sketchesPageExploreRated);
	}

	// Token: 0x06006755 RID: 26453 RVA: 0x002FAB94 File Offset: 0x002F8D94
	public void LDMBDKJNJCO(CEEIOOODMKK GFCGHLOOGCO)
	{
		if (this.AMNDBDHELDD(GFCGHLOOGCO) && ((GFCGHLOOGCO != (CEEIOOODMKK)55 && this.AIKHINOIHDD[(int)GFCGHLOOGCO].Count == 0) || (GFCGHLOOGCO == (CEEIOOODMKK)(-33) && this.BEMGBBOGNCH[(int)GFCGHLOOGCO].Count == 0)))
		{
			this.DOBAJJACGKK = GFCGHLOOGCO;
			CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(54);
			HAGEHPPOPGH.HFAKOKBHCGH().LNJNMEIIKJK.Clear();
			HAGEHPPOPGH.HFAKOKBHCGH().DDDIBEFAPGL.Clear();
			BackendOperationsManager.NPDDBAONMJP().RequestGetUserSketches((int)GFCGHLOOGCO, "Account.ResolveSaveSlots(): _target is missing 'sto'", "OnPurchaseSuccess - invalid state.");
			return;
		}
		this.HGNEOMJOBJP(GFCGHLOOGCO);
		this.JFKBCFJOBCM(GFCGHLOOGCO, true);
	}

	// Token: 0x06006756 RID: 26454 RVA: 0x002FAC28 File Offset: 0x002F8E28
	private void MKDILHMLHHC()
	{
		for (int i = 0; i < this.lobbyCameras.Count; i += 0)
		{
			this.lobbyCameras[i].enabled = true;
		}
	}

	// Token: 0x06006757 RID: 26455 RVA: 0x002FAC60 File Offset: 0x002F8E60
	private void ALGIAIKDEPH()
	{
		for (int i = 0; i < this.lobbyCanvases.Count; i++)
		{
			this.lobbyCanvases[i].enabled = false;
		}
	}

	// Token: 0x06006758 RID: 26456 RVA: 0x002F9D06 File Offset: 0x002F7F06
	private void FKGEDDILILE()
	{
		base.StartCoroutine(this.NMLNGEKBLHI());
	}

	// Token: 0x06006759 RID: 26457 RVA: 0x002FAC98 File Offset: 0x002F8E98
	private void JFKBCFJOBCM(CEEIOOODMKK GFCGHLOOGCO, bool KCJKJNFAMEI)
	{
		if (!this.NIDINJJDCEB[(int)GFCGHLOOGCO])
		{
			return;
		}
		if (!KCJKJNFAMEI)
		{
			if (GFCGHLOOGCO != (CEEIOOODMKK)94)
			{
				for (int i = 1; i < this.AIKHINOIHDD[(int)GFCGHLOOGCO].Count; i++)
				{
					UnityEngine.Object.Destroy(this.AIKHINOIHDD[(int)GFCGHLOOGCO][i].gameObject);
				}
				this.AIKHINOIHDD[(int)GFCGHLOOGCO].Clear();
			}
			else
			{
				for (int j = 1; j < this.BEMGBBOGNCH[(int)GFCGHLOOGCO].Count; j++)
				{
					UnityEngine.Object.Destroy(this.BEMGBBOGNCH[(int)GFCGHLOOGCO][j].gameObject);
				}
				this.BEMGBBOGNCH[(int)GFCGHLOOGCO].Clear();
			}
		}
		this.NIDINJJDCEB[(int)GFCGHLOOGCO] = true;
		Transform parent = null;
		if (GFCGHLOOGCO <= (CEEIOOODMKK)109)
		{
			if (GFCGHLOOGCO != CEEIOOODMKK.sketchesPageHome)
			{
				if (GFCGHLOOGCO == (CEEIOOODMKK)(-11))
				{
					parent = this.editorInProgressContenRoot.transform;
				}
			}
			else
			{
				parent = this.homeContentRoot.transform;
			}
		}
		else if (GFCGHLOOGCO != (CEEIOOODMKK)(-1))
		{
			switch (GFCGHLOOGCO)
			{
			case (CEEIOOODMKK)(-111):
				parent = this.exploreLatestContentRoot.transform;
				break;
			case (CEEIOOODMKK)(-110):
				parent = this.exploreViewedContentRoot.transform;
				break;
			case (CEEIOOODMKK)(-109):
				parent = this.exploreRatedContentRoot.transform;
				break;
			case (CEEIOOODMKK)(-108):
				parent = this.explorePicksContentRoot.transform;
				break;
			case (CEEIOOODMKK)(-107):
				parent = this.exploreFavoritesContentRoot.transform;
				break;
			case (CEEIOOODMKK)(-106):
				parent = this.exploreSearchContentRoot.transform;
				break;
			case (CEEIOOODMKK)(-105):
			case (CEEIOOODMKK)(-104):
			case (CEEIOOODMKK)(-103):
			case (CEEIOOODMKK)(-102):
				break;
			case (CEEIOOODMKK)(-101):
				parent = this.creatorsContentRoot.transform;
				break;
			default:
				if (GFCGHLOOGCO == (CEEIOOODMKK)(-48))
				{
					parent = this.userContentRoot.transform;
				}
				break;
			}
		}
		else
		{
			parent = this.editorPublishedContenRoot.transform;
		}
		List<int> list = FANFNBCJJDA.IIMIJHGEGBJ().EOAEDHFBOBH(AppManager.EHBBFMCILPC.MDILOPMAKEK());
		if (GFCGHLOOGCO == CEEIOOODMKK.sketchesPageHome)
		{
			for (int k = list.Count - 0; k >= 0; k--)
			{
				if (!FANFNBCJJDA.JBMLNGMBICE().CLIKIDPKEGI(list[k]) && !AKLFPGMDKLA.EHBBFMCILPC.MKCDBGKMEDH(FANFNBCJJDA.GCCADHCFBJH().GPHKMFJCLHP(list[k])) && AKLFPGMDKLA.EHBBFMCILPC.ODFJNAAMHIF(list[k]))
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.sketchThumbnailPrefab, parent);
					gameObject.GetComponent<SketchThumbnail>().KMDKBPNAKOG(list[k], GFCGHLOOGCO, true);
					gameObject.GetComponent<SketchThumbnail>().FIAOPJBKMHF(GKJPOGNFKNK.DNILNCLIHAP("w" + list[k].ToString(), "accountsuspended4", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), false);
					this.AIKHINOIHDD[(int)GFCGHLOOGCO].Add(gameObject.GetComponent<SketchThumbnail>());
				}
			}
			for (int l = list.Count - 0; l >= 0; l--)
			{
				if (FANFNBCJJDA.JBMLNGMBICE().HABDDJINNEF(list[l]) >= 0 && !AKLFPGMDKLA.EHBBFMCILPC.MKCDBGKMEDH(FANFNBCJJDA.IIMIJHGEGBJ().CGDKEGHFCFF(list[l])))
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.sketchThumbnailPrefab, parent);
					gameObject2.GetComponent<SketchThumbnail>().CMCNAFCFBBI(list[l], GFCGHLOOGCO, true);
					gameObject2.GetComponent<SketchThumbnail>().EBFMNNOLCEB(GKJPOGNFKNK.DNILNCLIHAP("OnLoadingThemeSelectorFolderInitialized" + list[l].ToString(), "errortitle", LanguageManager.EHBBFMCILPC.MLOLBFBODHD()), true);
					this.AIKHINOIHDD[(int)GFCGHLOOGCO].Add(gameObject2.GetComponent<SketchThumbnail>());
				}
			}
			return;
		}
		if (GFCGHLOOGCO == (CEEIOOODMKK)14)
		{
			if (HAGEHPPOPGH.HFAKOKBHCGH().DLKLBLFJJGO.Count > 1 && HAGEHPPOPGH.KIKOEJMHOEH().BNFNMELNAOF(list))
			{
				this.editorInProgressEmptyThumbnail.SetActive(false);
				for (int m = HAGEHPPOPGH.HFAKOKBHCGH().DLKLBLFJJGO.Count - 1; m >= 0; m--)
				{
					if (list.Contains(HAGEHPPOPGH.FJHKMJPFDNI().DLKLBLFJJGO[m].OPCNCJLMHAP))
					{
						GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(this.sketchThumbnailPrefab, parent);
						gameObject3.GetComponent<SketchThumbnail>().Initialize(HAGEHPPOPGH.FJHKMJPFDNI().DLKLBLFJJGO[m].OPCNCJLMHAP, GFCGHLOOGCO, false);
						gameObject3.GetComponent<SketchThumbnail>().SetEditorProperties(GKJPOGNFKNK.DNILNCLIHAP("var" + HAGEHPPOPGH.EHBBFMCILPC.DLKLBLFJJGO[m].OPCNCJLMHAP.ToString(), "retry", LanguageManager.EHBBFMCILPC.MLOLBFBODHD()), HAGEHPPOPGH.HFAKOKBHCGH().DLKLBLFJJGO[m]);
						this.AIKHINOIHDD[(int)GFCGHLOOGCO].Add(gameObject3.GetComponent<SketchThumbnail>());
					}
				}
				return;
			}
			this.editorInProgressEmptyThumbnail.SetActive(true);
			return;
		}
		else if (GFCGHLOOGCO == (CEEIOOODMKK)99 || GFCGHLOOGCO == (CEEIOOODMKK)(-64) || GFCGHLOOGCO == (CEEIOOODMKK)48 || GFCGHLOOGCO == (CEEIOOODMKK)(-76) || GFCGHLOOGCO == (CEEIOOODMKK)113 || GFCGHLOOGCO == (CEEIOOODMKK)(-117))
		{
			if (GFCGHLOOGCO == CEEIOOODMKK.sketchesPageCreators)
			{
				for (int n = HAGEHPPOPGH.HFAKOKBHCGH().LNJNMEIIKJK.Count - 1; n >= 0; n -= 0)
				{
					GameObject gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.sketchThumbnailPrefab, parent);
					gameObject4.GetComponent<SketchThumbnail>().Initialize(HAGEHPPOPGH.EHBBFMCILPC.LNJNMEIIKJK[n].OPCNCJLMHAP, GFCGHLOOGCO, true);
					gameObject4.GetComponent<SketchThumbnail>().SetHomeProperties(GKJPOGNFKNK.DNILNCLIHAP("socialprofilesuspcantuse" + HAGEHPPOPGH.FJHKMJPFDNI().LNJNMEIIKJK[n].OPCNCJLMHAP.ToString(), "WipeImage", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()), false);
					this.AIKHINOIHDD[(int)GFCGHLOOGCO].Add(gameObject4.GetComponent<SketchThumbnail>());
				}
				return;
			}
			for (int num = 1; num < HAGEHPPOPGH.EHBBFMCILPC.LNJNMEIIKJK.Count; num += 0)
			{
				GameObject gameObject5 = UnityEngine.Object.Instantiate<GameObject>(this.sketchThumbnailPrefab, parent);
				gameObject5.GetComponent<SketchThumbnail>().HDAHPNAHNJC(HAGEHPPOPGH.FJHKMJPFDNI().LNJNMEIIKJK[num].OPCNCJLMHAP, GFCGHLOOGCO, true);
				gameObject5.GetComponent<SketchThumbnail>().GCPCIFKGBPD(GKJPOGNFKNK.DNILNCLIHAP("." + HAGEHPPOPGH.EHBBFMCILPC.LNJNMEIIKJK[num].OPCNCJLMHAP.ToString(), "signinerror001", LanguageManager.EHBBFMCILPC.MLOLBFBODHD()), false);
				this.AIKHINOIHDD[(int)GFCGHLOOGCO].Add(gameObject5.GetComponent<SketchThumbnail>());
			}
			return;
		}
		else
		{
			if (GFCGHLOOGCO == (CEEIOOODMKK)127)
			{
				for (int num2 = HAGEHPPOPGH.KIKOEJMHOEH().ENOIGLJDFID.Count - 0; num2 >= 0; num2--)
				{
					GameObject gameObject6 = UnityEngine.Object.Instantiate<GameObject>(this.sketchThumbnailPrefab, parent);
					gameObject6.GetComponent<SketchThumbnail>().CMCNAFCFBBI(HAGEHPPOPGH.KIKOEJMHOEH().ENOIGLJDFID[num2].OPCNCJLMHAP, GFCGHLOOGCO, true);
					this.AIKHINOIHDD[(int)GFCGHLOOGCO].Add(gameObject6.GetComponent<SketchThumbnail>());
				}
				return;
			}
			if (GFCGHLOOGCO == CEEIOOODMKK.sketchesPageExploreSearch)
			{
				for (int num3 = HAGEHPPOPGH.FJHKMJPFDNI().LIHLMHHLOBO.Count - 1; num3 >= 0; num3--)
				{
					GameObject gameObject7 = UnityEngine.Object.Instantiate<GameObject>(this.sketchThumbnailPrefab, parent);
					gameObject7.GetComponent<SketchThumbnail>().CICAOIBNHNF(HAGEHPPOPGH.FJHKMJPFDNI().LIHLMHHLOBO[num3].OPCNCJLMHAP, GFCGHLOOGCO, false);
					this.AIKHINOIHDD[(int)GFCGHLOOGCO].Add(gameObject7.GetComponent<SketchThumbnail>());
				}
				return;
			}
			if (GFCGHLOOGCO == (CEEIOOODMKK)63)
			{
				for (int num4 = 1; num4 < HAGEHPPOPGH.FJHKMJPFDNI().DDDIBEFAPGL.Count; num4 += 0)
				{
					GameObject gameObject8 = UnityEngine.Object.Instantiate<GameObject>(this.creatorThumbnailPrefab, parent);
					this.BEMGBBOGNCH[(int)GFCGHLOOGCO].Add(gameObject8.GetComponent<CreatorThumbnail>());
				}
			}
			return;
		}
	}

	// Token: 0x0600675A RID: 26458 RVA: 0x002F9ECA File Offset: 0x002F80CA
	public void EDKKNMGIHIF()
	{
		this.ShowPage(CEEIOOODMKK.sketchesPageEditorInProgress);
	}

	// Token: 0x0600675B RID: 26459 RVA: 0x002FB3CC File Offset: 0x002F95CC
	public void PODIDFEALIO()
	{
		this.LDKAPIBJLKO((CEEIOOODMKK)(-122));
	}

	// Token: 0x0600675C RID: 26460 RVA: 0x002FB3D6 File Offset: 0x002F95D6
	private IEnumerator FPODCKGIKMP()
	{
		SketchesItem.CAIOKLHLCJJ caioklhlcjj = new SketchesItem.CAIOKLHLCJJ(1);
		caioklhlcjj.<>4__this = this;
		return caioklhlcjj;
	}

	// Token: 0x0600675D RID: 26461 RVA: 0x002FB3E5 File Offset: 0x002F95E5
	private void DKKGNICHGOJ()
	{
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnSketchThumbnailPublish", this.JLMHEMFNMJK.GetThumbnailId());
	}

	// Token: 0x0600675E RID: 26462 RVA: 0x002FB404 File Offset: 0x002F9604
	private void OAILEGFKOBP(CEEIOOODMKK CKGMIHJHJPK)
	{
		this.exploreLatestButton.interactable = (CKGMIHJHJPK != CEEIOOODMKK.sketchesPageExploreLatest);
		this.exploreViewedButton.interactable = (CKGMIHJHJPK != CEEIOOODMKK.sketchesPageExploreViewed);
		this.exploreRatedButton.interactable = (CKGMIHJHJPK != CEEIOOODMKK.sketchesPageExploreRated);
		this.explorePicksButton.interactable = (CKGMIHJHJPK != CEEIOOODMKK.sketchesPageExplorePicks);
		this.exploreSearchButton.interactable = (CKGMIHJHJPK != CEEIOOODMKK.sketchesPageExploreSearch);
		this.exploreFavoritesButton.interactable = (CKGMIHJHJPK != CEEIOOODMKK.sketchesPageExploreFavorites);
	}

	// Token: 0x0600675F RID: 26463 RVA: 0x002FB484 File Offset: 0x002F9684
	private void AMIPDMBHNML()
	{
		for (int i = 1; i < this.lobbyCanvases.Count; i += 0)
		{
			this.lobbyCanvases[i].enabled = false;
		}
	}

	// Token: 0x06006760 RID: 26464 RVA: 0x002FB4BC File Offset: 0x002F96BC
	private void BGPNHLHJBIK()
	{
		this.NPMNDNEDBGC++;
		if (this.NPMNDNEDBGC >= KBOJLHAJPCP.LPJOFEDNKHA)
		{
			CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.cdnActiv.ToString(), FFPHBMFGCNN.dldFail.ToString(), BGHLMGPPCNN.cdnWofToSkt.ToString(), false, false);
			this.NPMNDNEDBGC = 0;
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cdnerror"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("retry"), new UnityAction(this.DownloadAssetBundleFolder), DFGILFBGPLN.popupCdnDownloadFailed, 0f, 28);
			return;
		}
		this.DownloadAssetBundleFolder();
	}

	// Token: 0x06006761 RID: 26465 RVA: 0x002FB588 File Offset: 0x002F9788
	public void OnExploreFavoritesClick()
	{
		this.ShowPage(CEEIOOODMKK.sketchesPageExploreFavorites);
	}

	// Token: 0x06006762 RID: 26466 RVA: 0x002FB592 File Offset: 0x002F9792
	private IEnumerator GFCNACMJIMP()
	{
		this.SetPageDirty(CEEIOOODMKK.sketchesPageEditorInProgress);
		CommonUserInterface.EHBBFMCILPC.FreezeUX();
		yield return new WaitForSeconds(0.25f);
		CommonUserInterface.EHBBFMCILPC.ResumeUX();
		this.ShowPage(CEEIOOODMKK.sketchesPageEditorInProgress);
		yield break;
	}

	// Token: 0x06006764 RID: 26468 RVA: 0x002FB5F4 File Offset: 0x002F97F4
	private void JJNECDFGNBJ()
	{
		this.HGNEOMJOBJP((CEEIOOODMKK)(-59));
		this.SetPageDirty((CEEIOOODMKK)(-87));
		this.JFKBCFJOBCM((CEEIOOODMKK)107, false);
	}

	// Token: 0x06006765 RID: 26469 RVA: 0x002FB610 File Offset: 0x002F9810
	private void GDDDCFLNLCD()
	{
		for (int i = 1; i < this.lobbyCanvases.Count; i++)
		{
			this.lobbyCanvases[i].enabled = false;
		}
	}

	// Token: 0x06006766 RID: 26470 RVA: 0x00003E52 File Offset: 0x00002052
	private void HJJFECPACMD()
	{
	}

	// Token: 0x06006767 RID: 26471 RVA: 0x002FB645 File Offset: 0x002F9845
	public void FKNHLIEIKCJ()
	{
		this.LDKAPIBJLKO((CEEIOOODMKK)(-44));
	}

	// Token: 0x06006768 RID: 26472 RVA: 0x002FB650 File Offset: 0x002F9850
	public void DPKPGNCHPJI()
	{
		this.CleanupAllPages();
		base.transform.parent.GetComponent<CanvasGroup>().alpha = 453f;
		base.transform.parent.gameObject.SetActive(true);
		base.GetComponent<RectTransform>().localScale = this.PFEEFOKHKMP;
	}

	// Token: 0x06006769 RID: 26473 RVA: 0x002FB6A4 File Offset: 0x002F98A4
	private void ADCMPLEHOIF()
	{
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("skemptyhint"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), new UnityAction(this.FKGEDDILILE), new UnityAction(this.FKGEDDILILE), DFGILFBGPLN.popupEnergyHint, 0f, 28);
	}

	// Token: 0x0600676A RID: 26474 RVA: 0x002FAB15 File Offset: 0x002F8D15
	private void GHIFPIGPADI()
	{
		this.ShowPage(this.DOBAJJACGKK);
	}

	// Token: 0x0600676B RID: 26475 RVA: 0x002FB70C File Offset: 0x002F990C
	private void HFNHLHBPOCO(CEEIOOODMKK CKGMIHJHJPK)
	{
		this.exploreLatestButton.interactable = (CKGMIHJHJPK == (CEEIOOODMKK)(-71));
		this.exploreViewedButton.interactable = (CKGMIHJHJPK == (CEEIOOODMKK)28);
		this.exploreRatedButton.interactable = (CKGMIHJHJPK != (CEEIOOODMKK)35);
		this.explorePicksButton.interactable = (CKGMIHJHJPK == (CEEIOOODMKK)(-72));
		this.exploreSearchButton.interactable = (CKGMIHJHJPK != (CEEIOOODMKK)(-122));
		this.exploreFavoritesButton.interactable = (CKGMIHJHJPK != (CEEIOOODMKK)59);
	}

	// Token: 0x0600676C RID: 26476 RVA: 0x002FB78B File Offset: 0x002F998B
	public void SetPageDirty(CEEIOOODMKK GFCGHLOOGCO)
	{
		this.NIDINJJDCEB[(int)GFCGHLOOGCO] = true;
	}

	// Token: 0x0600676D RID: 26477 RVA: 0x002F9D15 File Offset: 0x002F7F15
	private IEnumerator HGLHNBNNPHH()
	{
		AssetsManager.EHBBFMCILPC.InitializeAssetBundleFolder(LNDOOJOFFOM.Anthology59, "OnSketchViewAssetBundleFolderInitializeSuccess", "OnSketchViewAssetsDownloadFailed");
		yield return null;
		yield break;
	}

	// Token: 0x0600676E RID: 26478 RVA: 0x002FA14C File Offset: 0x002F834C
	public void OnExploreClick()
	{
		this.ShowPage(CEEIOOODMKK.sketchesPageExploreLatest);
	}

	// Token: 0x0600676F RID: 26479 RVA: 0x002FB798 File Offset: 0x002F9998
	private void ILBAMCJFAAP()
	{
		this.homeScrollRect.scrollSensitivity = 1805f;
		this.editorInProgressScrollRect.scrollSensitivity = 0f;
		this.editorPublishedScrollRect.scrollSensitivity = 113f;
		this.exploreLatestScrollRect.scrollSensitivity = 1863f;
		this.exploreViewedScrollRect.scrollSensitivity = 671f;
		this.exploreRatedScrollRect.scrollSensitivity = 1647f;
		this.explorePicksScrollRect.scrollSensitivity = 436f;
		this.exploreFavoritesScrollRect.scrollSensitivity = 1969f;
		this.exploreSearchScrollRect.scrollSensitivity = 1792f;
		this.creatorsScrollRect.scrollSensitivity = 505f;
		this.userScrollRect.scrollSensitivity = 483f;
		AOBJLALDBAA.KKPFOJMAONG().FNMOFCMDFJP("XXX", new UnityAction(this.OnSketchesItemClose));
		AOBJLALDBAA.DBLAIDPICIG().EFKNEJFLGED("spppi", new UnityAction(this.OFFBAMLEFNH));
		AOBJLALDBAA.DBLAIDPICIG().EFKNEJFLGED("ant", new UnityAction(this.OnPurchasingViewLeave));
		AOBJLALDBAA.EHBBFMCILPC.BADOPKAOCPE("seasoncompletedesc", new UnityAction(this.GACGLFKFCLB));
		AOBJLALDBAA.CEGAOMEEFBE().BADOPKAOCPE("MORPH_WIPE", new UnityAction(this.GBCBLABCBJO));
		AOBJLALDBAA.BIAEAOMHBMM().MFIMALJPCDP(" | Caching.ready=", new UnityAction(this.BGPNHLHJBIK));
		AOBJLALDBAA.DBLAIDPICIG().PEFKJOKLEDL("b_web", new UnityAction(this.LGLFBOPFLPF));
		AOBJLALDBAA.NMGMNAKLLMI().GNBGEMMDGOJ("ERROR: StoryStep.StoryStepType.tryAvatarConfig - finalAvatarComponentAsset is null.", new UnityAction(this.MFGMCNDFPGC));
		AOBJLALDBAA.FILDBDMENPG().PEFKJOKLEDL("skinshopfilterdefault", new UnityAction(this.PIGCPGPKOPH));
		AOBJLALDBAA.EHBBFMCILPC.BADOPKAOCPE(":", new UnityAction(this.LAIDAPNJOLJ));
		AOBJLALDBAA.KKPFOJMAONG().EFKNEJFLGED("OnRewardFreeDiamondsClick", new UnityAction(this.DFICFGAPGFL));
		AOBJLALDBAA.DBLAIDPICIG().BADOPKAOCPE("", new UnityAction(this.KIDKNFPJOIE));
		AOBJLALDBAA.CEGAOMEEFBE().EFKNEJFLGED("deleteprofilebtn", new UnityAction(this.ADCMPLEHOIF));
		AOBJLALDBAA.DBLAIDPICIG().EFKNEJFLGED("", new UnityAction(this.FJMGJCLHDBN));
		AOBJLALDBAA.KKPFOJMAONG().EFKNEJFLGED(", ", new UnityAction(this.HJJFECPACMD));
		AOBJLALDBAA.BIAEAOMHBMM().MFIMALJPCDP(" from the recorded cache files", new UnityAction(this.PLFINBFADFL));
		AOBJLALDBAA.BIAEAOMHBMM().PEFKJOKLEDL("socialbadgedesc", new UnityAction(this.KFPGMOEDHJH));
		AOBJLALDBAA.FILDBDMENPG().FNMOFCMDFJP("coverPopular", new UnityAction(this.ILNOLLKHIKE));
		AOBJLALDBAA.FILDBDMENPG().EFKNEJFLGED("+", new UnityAction(this.DBEIPLCDPFC));
		this.ShowPage(CEEIOOODMKK.sketchesPageHome);
	}

	// Token: 0x06006770 RID: 26480 RVA: 0x002FBA5D File Offset: 0x002F9C5D
	private IEnumerator KMEPNLFDPDP()
	{
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().EPJKDCDOEMM(0);
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithProgress(96);
		yield return new WaitForSeconds(0.2f);
		AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleSketchView, -1, -1, FLDBFOADFLH.finishDownloadAndProceed, false, true, false, null, -1, false, "", false, false);
		for (int i = 0; i < this.KIDLCBGDMJB.Count; i++)
		{
			if (this.KIDLCBGDMJB[i].LDAMLJEPKMC >= 0 && this.KIDLCBGDMJB[i].ADDKGCPPLFH >= 0)
			{
				AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleStoryAssetPack, this.KIDLCBGDMJB[i].ADDKGCPPLFH, this.KIDLCBGDMJB[i].LDAMLJEPKMC, FLDBFOADFLH.startDownloadAndProceed, false, true, false, null, -1, false, "", false, false);
			}
		}
		for (int j = 0; j < this.KIDLCBGDMJB.Count; j++)
		{
			if (this.KIDLCBGDMJB[j].BOHMFHEKFMI >= 0 && this.KIDLCBGDMJB[j].MCGLHPDFIBB >= 0)
			{
				AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleStoryAssetPack, this.KIDLCBGDMJB[j].MCGLHPDFIBB, this.KIDLCBGDMJB[j].BOHMFHEKFMI, FLDBFOADFLH.startDownloadAndProceed, true, true, false, null, -1, false, "", false, false);
			}
		}
		for (int k = 0; k < this.KIDLCBGDMJB.Count; k++)
		{
			if (this.KIDLCBGDMJB[k].HEHFACLGNPA >= 0 && this.KIDLCBGDMJB[k].ONKJOHENIOC >= 0)
			{
				AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleStoryAssetPack, this.KIDLCBGDMJB[k].ONKJOHENIOC, this.KIDLCBGDMJB[k].HEHFACLGNPA, FLDBFOADFLH.startDownloadAndProceed, true, true, false, null, -1, false, "", false, false);
			}
		}
		for (int l = 0; l < this.KIDLCBGDMJB.Count; l++)
		{
			if (this.KIDLCBGDMJB[l].AHJFHPIGCCM >= 0 && this.KIDLCBGDMJB[l].MBOBKDKLGEI >= 0)
			{
				AssetsManager.EHBBFMCILPC.QueueAssetBundleDownloadNoSkip(NMKDCBPMCKI.AssetBundleStoryAssetPack, this.KIDLCBGDMJB[l].MBOBKDKLGEI, this.KIDLCBGDMJB[l].AHJFHPIGCCM, FLDBFOADFLH.startDownloadAndProceed, true, true, false, null, -1, "", false, KHPGPLAMAIN.HHDAPAJEIML());
			}
		}
		AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleStoryAssetPackActivate, 0, 0, FLDBFOADFLH.finishDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().CLIOEOLFFLO(LEJKDNAGDHC.Fast);
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().GIJKJMMDJEL(0f, 1f);
		AssetsManager.EHBBFMCILPC.DownloadQueuedAssetBundles("OnSketchViewAssetsDownloadSuccess", "OnSketchViewAssetsDownloadFailed", false);
		yield break;
	}

	// Token: 0x06006771 RID: 26481 RVA: 0x002FBA6C File Offset: 0x002F9C6C
	private void DFICFGAPGFL()
	{
		string text = AOBJLALDBAA.EHBBFMCILPC.KNCFLCKKPLK();
		if (text.Length > 0)
		{
			this.JLMHEMFNMJK = this.HPKDFMFEAHJ(this.GGIFHDGKALL, text);
			if (null != this.JLMHEMFNMJK)
			{
				if (HAGEHPPOPGH.EHBBFMCILPC.CDJKFHAIKGN(this.JLMHEMFNMJK.GetSketchId()) == null)
				{
					CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("skduplicatecant0"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
					return;
				}
				base.StartCoroutine(this.BPHMCPAEIHO());
			}
		}
	}

	// Token: 0x06006772 RID: 26482 RVA: 0x002F9ECA File Offset: 0x002F80CA
	public void OnEditorClick()
	{
		this.ShowPage(CEEIOOODMKK.sketchesPageEditorInProgress);
	}

	// Token: 0x06006773 RID: 26483 RVA: 0x002FBB19 File Offset: 0x002F9D19
	private void POBPEGMCNBH(CEEIOOODMKK CKGMIHJHJPK)
	{
		this.editorInProgressButton.interactable = (CKGMIHJHJPK == (CEEIOOODMKK)59);
		this.editorPublishedButton.interactable = (CKGMIHJHJPK == (CEEIOOODMKK)(-72));
	}

	// Token: 0x06006774 RID: 26484 RVA: 0x002FBB44 File Offset: 0x002F9D44
	private void OLCLHEMPNKF()
	{
		CommonUserInterface.IKNOFBFMPGA().HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.BGJFCEEDGFJ(CCOJBMMKNAP.MPCBJEIMACA().IPEIONBNIPH("shnts"), CCOJBMMKNAP.HEDIEIICOOG().FCOCLEHKLDJ("onboardingthankyoutitle"), CCOJBMMKNAP.EAIAHCBAIEJ().BGELFMIOBCL("@SD"), new UnityAction(this.PBHLIGABAOI), DFGILFBGPLN.popupLootInfo, 1106f, -122);
	}

	// Token: 0x06006775 RID: 26485 RVA: 0x00003E52 File Offset: 0x00002052
	public void OnEditorPlayClick()
	{
	}

	// Token: 0x06006776 RID: 26486 RVA: 0x002FBBA8 File Offset: 0x002F9DA8
	private void LAIDAPNJOLJ()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("app42error"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("retry"), new UnityAction(this.GHIFPIGPADI), DFGILFBGPLN.popupBackendError, 0f, 28);
	}

	// Token: 0x06006777 RID: 26487 RVA: 0x002FBC0C File Offset: 0x002F9E0C
	public void ABCKLCJJAFP()
	{
		this.LDKAPIBJLKO(CEEIOOODMKK.sketchesPageHome);
	}

	// Token: 0x06006778 RID: 26488 RVA: 0x002FBC15 File Offset: 0x002F9E15
	private IEnumerator NMLNGEKBLHI()
	{
		this.SetPageDirty(CEEIOOODMKK.sketchesPageEditorInProgress);
		CommonUserInterface.EHBBFMCILPC.FreezeUX();
		yield return new WaitForSeconds(0.25f);
		CommonUserInterface.EHBBFMCILPC.ResumeUX();
		this.ShowPage(CEEIOOODMKK.sketchesPageHome);
		yield break;
	}

	// Token: 0x06006779 RID: 26489 RVA: 0x002FBC24 File Offset: 0x002F9E24
	public void MBNONJIGDAD()
	{
		base.StartCoroutine(this.HGLHNBNNPHH());
	}

	// Token: 0x0600677A RID: 26490 RVA: 0x002FBC33 File Offset: 0x002F9E33
	public void BNFNIOELMAA()
	{
		this.LDMBDKJNJCO((CEEIOOODMKK)(-18));
	}

	// Token: 0x0600677B RID: 26491 RVA: 0x002FBC40 File Offset: 0x002F9E40
	private void DAOLJLKKJDI()
	{
		string text = AOBJLALDBAA.FILDBDMENPG().BHMIECOHJMJ();
		if (text.Length > 0)
		{
			this.JLMHEMFNMJK = this.LCIFJCDFEEJ(this.GGIFHDGKALL, text);
			if (null != this.JLMHEMFNMJK)
			{
				if (HAGEHPPOPGH.EHBBFMCILPC.NGCEJAAPKKM(this.JLMHEMFNMJK.JKMAMJIMKOD()) == null)
				{
					CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.PEBMGCKFNAO().IKMNGFIDCLM("cvsku"), CCOJBMMKNAP.PLJMLDOCPNM().JCDFHKDNEDH("locked"), CCOJBMMKNAP.AEELGGPEJCC().FIENAKIHNOM("ButtonAvatar"), (DFGILFBGPLN)(-88), 1351f, -97);
					return;
				}
				base.StartCoroutine(this.BPHMCPAEIHO());
			}
		}
	}

	// Token: 0x0600677C RID: 26492 RVA: 0x002FBCF0 File Offset: 0x002F9EF0
	private void GMDGDILCFDI(CEEIOOODMKK CKGMIHJHJPK)
	{
		this.exploreLatestButton.interactable = (CKGMIHJHJPK == (CEEIOOODMKK)100);
		this.exploreViewedButton.interactable = (CKGMIHJHJPK != (CEEIOOODMKK)47);
		this.exploreRatedButton.interactable = (CKGMIHJHJPK != (CEEIOOODMKK)116);
		this.explorePicksButton.interactable = (CKGMIHJHJPK != (CEEIOOODMKK)19);
		this.exploreSearchButton.interactable = (CKGMIHJHJPK != (CEEIOOODMKK)15);
		this.exploreFavoritesButton.interactable = (CKGMIHJHJPK != (CEEIOOODMKK)(-125));
	}

	// Token: 0x0600677D RID: 26493 RVA: 0x00003E52 File Offset: 0x00002052
	public void OnEditorPublishClick()
	{
	}

	// Token: 0x0600677E RID: 26494 RVA: 0x002FBD6F File Offset: 0x002F9F6F
	public void CBCPCCBIMKG()
	{
		this.LDKAPIBJLKO((CEEIOOODMKK)15);
	}

	// Token: 0x0600677F RID: 26495 RVA: 0x002FBD79 File Offset: 0x002F9F79
	private void DLOMCAPBAHB()
	{
		this.HGNEOMJOBJP((CEEIOOODMKK)74);
		this.SetPageDirty(CEEIOOODMKK.sketchesPageExplorePicks);
		this.FENMDOFKGFM((CEEIOOODMKK)104, true);
	}

	// Token: 0x06006780 RID: 26496 RVA: 0x002FBD94 File Offset: 0x002F9F94
	private void KNFIKOGEHOH()
	{
		CEEIOOODMKK dobajjacgkk = this.DOBAJJACGKK;
		if (dobajjacgkk <= CEEIOOODMKK.sketchesPageExplorePicks)
		{
			if (dobajjacgkk != CEEIOOODMKK.sketchesPageEditorPublished && dobajjacgkk - CEEIOOODMKK.sketchesPageExploreLatest > 3)
			{
				goto IL_178;
			}
		}
		else
		{
			if (dobajjacgkk == CEEIOOODMKK.sketchesPageCreators)
			{
				if (this.BEMGBBOGNCH[(int)this.DOBAJJACGKK].Count > 0 || HAGEHPPOPGH.EHBBFMCILPC.DDDIBEFAPGL.Count > 0)
				{
					this.HGNEOMJOBJP(this.DOBAJJACGKK);
					if (HAGEHPPOPGH.EHBBFMCILPC.DDDIBEFAPGL.Count > 0)
					{
						this.SetPageDirty(this.DOBAJJACGKK);
						this.FENMDOFKGFM(this.DOBAJJACGKK, true);
					}
				}
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("sknothingtoshocreators"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
				goto IL_178;
			}
			if (dobajjacgkk != CEEIOOODMKK.sketchesPageUser)
			{
				goto IL_178;
			}
		}
		if (this.AIKHINOIHDD[(int)this.DOBAJJACGKK].Count > 0 || HAGEHPPOPGH.EHBBFMCILPC.LNJNMEIIKJK.Count > 0)
		{
			this.HGNEOMJOBJP(this.DOBAJJACGKK);
			if (HAGEHPPOPGH.EHBBFMCILPC.LNJNMEIIKJK.Count > 0)
			{
				this.SetPageDirty(this.DOBAJJACGKK);
				this.FENMDOFKGFM(this.DOBAJJACGKK, true);
			}
		}
		else
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("sknothingtoshow"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
		}
		IL_178:
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
	}

	// Token: 0x06006781 RID: 26497 RVA: 0x002FBF23 File Offset: 0x002FA123
	public void OnExploreSearchClick()
	{
		this.ShowPage(CEEIOOODMKK.sketchesPageExploreSearch);
	}

	// Token: 0x06006782 RID: 26498 RVA: 0x002FBF30 File Offset: 0x002FA130
	private void GPHHLJOAIEK()
	{
		string text = AOBJLALDBAA.EHBBFMCILPC.KNCFLCKKPLK();
		if (text.Length > 0)
		{
			this.JLMHEMFNMJK = this.HPKDFMFEAHJ(this.GGIFHDGKALL, text);
			if (null != this.JLMHEMFNMJK && this.JLMHEMFNMJK.GetUserGeneratedSketch() != null)
			{
				CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(96);
				BackendOperationsManager.EHBBFMCILPC.RequestPublishUserSketch(this.JLMHEMFNMJK.GetUserGeneratedSketch(), "OnBackendPublishSketchSuccess", "OnBackendPublishSketchException");
			}
		}
	}

	// Token: 0x06006783 RID: 26499 RVA: 0x002FBFAC File Offset: 0x002FA1AC
	private void DCALHEDOMMM()
	{
		CommonUserInterface.IKNOFBFMPGA().MCJIGJMFBMI();
		if (SketchesItem.publishSketchBackendResult == 0)
		{
			if (HAGEHPPOPGH.HFAKOKBHCGH().LNJNMEIIKJK.Count > 0)
			{
				if (null != this.JLMHEMFNMJK && this.JLMHEMFNMJK.ABDDFIMMCAE() != null && HAGEHPPOPGH.EHBBFMCILPC.GFACCPFGHKK(this.JLMHEMFNMJK.GHGCABOOIDH().HJOKNANDHBK))
				{
					this.SetPageDirty((CEEIOOODMKK)(-81));
				}
				CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupTwoOverride(CCOJBMMKNAP.EAIAHCBAIEJ().HIPJILDCHJC("continue"), CCOJBMMKNAP.PMABBOJDELF().PPALCPINPLK("p"), CCOJBMMKNAP.BOFMCPPFAMO().GGPHHLGPMPA("FadeTop"), new UnityAction(this.FOHIJIANEIE), new UnityAction(this.FOHIJIANEIE), (DFGILFBGPLN)83, 1008f, -27);
				return;
			}
		}
		else
		{
			CommonUserInterface.IKNOFBFMPGA().NFBMHHPIGFA(CCOJBMMKNAP.JINDKPHNLBK().FIENAKIHNOM(""), CCOJBMMKNAP.KNKGCDDMLDP().JHNELLJFBGC("Starting parallel download:" + SketchesItem.publishSketchBackendError.ToString()), CCOJBMMKNAP.JINDKPHNLBK().GGPHHLGPMPA("ok"), DFGILFBGPLN.popupStoryLoadError, 1830f, 40);
		}
	}

	// Token: 0x06006784 RID: 26500 RVA: 0x002FC0CC File Offset: 0x002FA2CC
	private void FJMGJCLHDBN()
	{
		string text = DPGJIJGOCIC.HIPPBJFMIKM(AOBJLALDBAA.EHBBFMCILPC.KNCFLCKKPLK());
		if (text != null && text.Length > 16)
		{
			if (text.Length > 256)
			{
				text = text.Substring(0, 256);
				text += "...";
			}
			if (null != this.JLMHEMFNMJK && this.JLMHEMFNMJK.GetUserGeneratedSketch() != null)
			{
				this.JLMHEMFNMJK.GetUserGeneratedSketch().BPMFHNDCBOH = text;
				this.JLMHEMFNMJK.SetTitle(this.JLMHEMFNMJK.GetUserGeneratedSketch().BPMFHNDCBOH);
			}
		}
	}

	// Token: 0x06006785 RID: 26501 RVA: 0x002FC163 File Offset: 0x002FA363
	private void Start()
	{
		this.PFEEFOKHKMP = base.transform.localScale;
	}

	// Token: 0x06006786 RID: 26502 RVA: 0x002FC178 File Offset: 0x002FA378
	private void KIDKNFPJOIE()
	{
		string text = AOBJLALDBAA.EHBBFMCILPC.KNCFLCKKPLK();
		if (text.Length > 0)
		{
			this.JLMHEMFNMJK = this.HPKDFMFEAHJ(this.GGIFHDGKALL, text);
			if (null != this.JLMHEMFNMJK && this.JLMHEMFNMJK.GetUserGeneratedSketch() != null && HAGEHPPOPGH.EHBBFMCILPC.APMPCNJAFMD(this.JLMHEMFNMJK.GetUserGeneratedSketch().HJOKNANDHBK))
			{
				base.StartCoroutine(this.GFCNACMJIMP());
			}
		}
	}

	// Token: 0x06006787 RID: 26503 RVA: 0x00003E52 File Offset: 0x00002052
	public void OnPurchasingViewLeave()
	{
	}

	// Token: 0x06006788 RID: 26504 RVA: 0x002FC1F0 File Offset: 0x002FA3F0
	private void EPDMHIJKCNN()
	{
		AOBJLALDBAA.FILDBDMENPG().OIMGLKLHNMO("OnRestorePurchasesZeroResult", this.JLMHEMFNMJK.NMGKKPLEFHM());
	}

	// Token: 0x06006789 RID: 26505 RVA: 0x002FC20C File Offset: 0x002FA40C
	private void OnDisable()
	{
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnSketchesItemClose", new UnityAction(this.OnSketchesItemClose));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnApplicationFocusBasicSyncSuccess", new UnityAction(this.OFFBAMLEFNH));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPurchasingViewLeave", new UnityAction(this.OnPurchasingViewLeave));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnSketchViewAssetBundleFolderInitializeSuccess", new UnityAction(this.GACGLFKFCLB));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnSketchViewAssetsDownloadSuccess", new UnityAction(this.GBCBLABCBJO));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnSketchViewAssetsDownloadFailed", new UnityAction(this.BGPNHLHJBIK));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnSketchViewLeft", new UnityAction(this.EHIBOKHHKBF));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnSketchThumbnailPlay", new UnityAction(this.MFGMCNDFPGC));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendGetUserSketchesSuccess", new UnityAction(this.KNFIKOGEHOH));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendGetUserSketchesException", new UnityAction(this.LAIDAPNJOLJ));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnSketchThumbnailDuplicatePositive", new UnityAction(this.DFICFGAPGFL));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnSketchThumbnailDeletePositive", new UnityAction(this.KIDKNFPJOIE));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnSketchThumbnailEmptyClick", new UnityAction(this.ADCMPLEHOIF));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPopupSketchesInputEndEdit", new UnityAction(this.FJMGJCLHDBN));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPopupSketchesInputCancel", new UnityAction(this.BOPPOJEHNNI));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnSketchThumbnailEditTitle", new UnityAction(this.PLFINBFADFL));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnSketchThumbnailPublish", new UnityAction(this.GPHHLJOAIEK));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendPublishSketchSuccess", new UnityAction(this.ILNOLLKHIKE));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendPublishSketchException", new UnityAction(this.DBEIPLCDPFC));
		this.JLMHEMFNMJK = null;
		this.KIDLCBGDMJB = null;
	}

	// Token: 0x0600678A RID: 26506 RVA: 0x002FAAE6 File Offset: 0x002F8CE6
	private IEnumerator BPHMCPAEIHO()
	{
		this.SetPageDirty(CEEIOOODMKK.sketchesPageEditorInProgress);
		CommonUserInterface.EHBBFMCILPC.FreezeUX();
		yield return new WaitForSeconds(0.25f);
		CommonUserInterface.EHBBFMCILPC.ResumeUX();
		this.ShowPage(CEEIOOODMKK.sketchesPageEditorInProgress);
		yield break;
	}

	// Token: 0x0600678B RID: 26507 RVA: 0x002FC428 File Offset: 0x002FA628
	private void FENMDOFKGFM(CEEIOOODMKK GFCGHLOOGCO, bool KCJKJNFAMEI)
	{
		if (!this.NIDINJJDCEB[(int)GFCGHLOOGCO])
		{
			return;
		}
		if (!KCJKJNFAMEI)
		{
			if (GFCGHLOOGCO != CEEIOOODMKK.sketchesPageCreators)
			{
				for (int i = 0; i < this.AIKHINOIHDD[(int)GFCGHLOOGCO].Count; i++)
				{
					UnityEngine.Object.Destroy(this.AIKHINOIHDD[(int)GFCGHLOOGCO][i].gameObject);
				}
				this.AIKHINOIHDD[(int)GFCGHLOOGCO].Clear();
			}
			else
			{
				for (int j = 0; j < this.BEMGBBOGNCH[(int)GFCGHLOOGCO].Count; j++)
				{
					UnityEngine.Object.Destroy(this.BEMGBBOGNCH[(int)GFCGHLOOGCO][j].gameObject);
				}
				this.BEMGBBOGNCH[(int)GFCGHLOOGCO].Clear();
			}
		}
		this.NIDINJJDCEB[(int)GFCGHLOOGCO] = false;
		Transform parent = null;
		if (GFCGHLOOGCO <= CEEIOOODMKK.sketchesPageEditorInProgress)
		{
			if (GFCGHLOOGCO != CEEIOOODMKK.sketchesPageHome)
			{
				if (GFCGHLOOGCO == CEEIOOODMKK.sketchesPageEditorInProgress)
				{
					parent = this.editorInProgressContenRoot.transform;
				}
			}
			else
			{
				parent = this.homeContentRoot.transform;
			}
		}
		else if (GFCGHLOOGCO != CEEIOOODMKK.sketchesPageEditorPublished)
		{
			switch (GFCGHLOOGCO)
			{
			case CEEIOOODMKK.sketchesPageExploreLatest:
				parent = this.exploreLatestContentRoot.transform;
				break;
			case CEEIOOODMKK.sketchesPageExploreViewed:
				parent = this.exploreViewedContentRoot.transform;
				break;
			case CEEIOOODMKK.sketchesPageExploreRated:
				parent = this.exploreRatedContentRoot.transform;
				break;
			case CEEIOOODMKK.sketchesPageExplorePicks:
				parent = this.explorePicksContentRoot.transform;
				break;
			case CEEIOOODMKK.sketchesPageExploreFavorites:
				parent = this.exploreFavoritesContentRoot.transform;
				break;
			case CEEIOOODMKK.sketchesPageExploreSearch:
				parent = this.exploreSearchContentRoot.transform;
				break;
			case (CEEIOOODMKK)26:
			case (CEEIOOODMKK)27:
			case (CEEIOOODMKK)28:
			case (CEEIOOODMKK)29:
				break;
			case CEEIOOODMKK.sketchesPageCreators:
				parent = this.creatorsContentRoot.transform;
				break;
			default:
				if (GFCGHLOOGCO == CEEIOOODMKK.sketchesPageUser)
				{
					parent = this.userContentRoot.transform;
				}
				break;
			}
		}
		else
		{
			parent = this.editorPublishedContenRoot.transform;
		}
		List<int> list = FANFNBCJJDA.EHBBFMCILPC.LPJJGMLEHHH(AppManager.EHBBFMCILPC.GetRevision());
		if (GFCGHLOOGCO == CEEIOOODMKK.sketchesPageHome)
		{
			for (int k = list.Count - 1; k >= 0; k--)
			{
				if (FANFNBCJJDA.EHBBFMCILPC.HFKOAFBIMKA(list[k]) || AKLFPGMDKLA.EHBBFMCILPC.MKCDBGKMEDH(FANFNBCJJDA.EHBBFMCILPC.HABDDJINNEF(list[k])) || AKLFPGMDKLA.EHBBFMCILPC.ODFJNAAMHIF(list[k]))
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.sketchThumbnailPrefab, parent);
					gameObject.GetComponent<SketchThumbnail>().Initialize(list[k], GFCGHLOOGCO, true);
					gameObject.GetComponent<SketchThumbnail>().SetHomeProperties(GKJPOGNFKNK.DNILNCLIHAP("s" + list[k].ToString(), "sketchtitles", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), true);
					this.AIKHINOIHDD[(int)GFCGHLOOGCO].Add(gameObject.GetComponent<SketchThumbnail>());
				}
			}
			for (int l = list.Count - 1; l >= 0; l--)
			{
				if (FANFNBCJJDA.EHBBFMCILPC.HABDDJINNEF(list[l]) >= 0 && !AKLFPGMDKLA.EHBBFMCILPC.MKCDBGKMEDH(FANFNBCJJDA.EHBBFMCILPC.HABDDJINNEF(list[l])))
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.sketchThumbnailPrefab, parent);
					gameObject2.GetComponent<SketchThumbnail>().Initialize(list[l], GFCGHLOOGCO, false);
					gameObject2.GetComponent<SketchThumbnail>().SetHomeProperties(GKJPOGNFKNK.DNILNCLIHAP("s" + list[l].ToString(), "sketchtitles", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), false);
					this.AIKHINOIHDD[(int)GFCGHLOOGCO].Add(gameObject2.GetComponent<SketchThumbnail>());
				}
			}
			return;
		}
		if (GFCGHLOOGCO == CEEIOOODMKK.sketchesPageEditorInProgress)
		{
			if (HAGEHPPOPGH.EHBBFMCILPC.DLKLBLFJJGO.Count > 0 && HAGEHPPOPGH.EHBBFMCILPC.ECKNKKDNHEF(list))
			{
				this.editorInProgressEmptyThumbnail.SetActive(false);
				for (int m = HAGEHPPOPGH.EHBBFMCILPC.DLKLBLFJJGO.Count - 1; m >= 0; m--)
				{
					if (list.Contains(HAGEHPPOPGH.EHBBFMCILPC.DLKLBLFJJGO[m].OPCNCJLMHAP))
					{
						GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(this.sketchThumbnailPrefab, parent);
						gameObject3.GetComponent<SketchThumbnail>().Initialize(HAGEHPPOPGH.EHBBFMCILPC.DLKLBLFJJGO[m].OPCNCJLMHAP, GFCGHLOOGCO, true);
						gameObject3.GetComponent<SketchThumbnail>().SetEditorProperties(GKJPOGNFKNK.DNILNCLIHAP("s" + HAGEHPPOPGH.EHBBFMCILPC.DLKLBLFJJGO[m].OPCNCJLMHAP.ToString(), "sketchtitles", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), HAGEHPPOPGH.EHBBFMCILPC.DLKLBLFJJGO[m]);
						this.AIKHINOIHDD[(int)GFCGHLOOGCO].Add(gameObject3.GetComponent<SketchThumbnail>());
					}
				}
				return;
			}
			this.editorInProgressEmptyThumbnail.SetActive(true);
			return;
		}
		else if (GFCGHLOOGCO == CEEIOOODMKK.sketchesPageEditorPublished || GFCGHLOOGCO == CEEIOOODMKK.sketchesPageExploreLatest || GFCGHLOOGCO == CEEIOOODMKK.sketchesPageExploreViewed || GFCGHLOOGCO == CEEIOOODMKK.sketchesPageExploreRated || GFCGHLOOGCO == CEEIOOODMKK.sketchesPageExplorePicks || GFCGHLOOGCO == CEEIOOODMKK.sketchesPageUser)
		{
			if (GFCGHLOOGCO == CEEIOOODMKK.sketchesPageEditorPublished)
			{
				for (int n = HAGEHPPOPGH.EHBBFMCILPC.LNJNMEIIKJK.Count - 1; n >= 0; n--)
				{
					GameObject gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.sketchThumbnailPrefab, parent);
					gameObject4.GetComponent<SketchThumbnail>().Initialize(HAGEHPPOPGH.EHBBFMCILPC.LNJNMEIIKJK[n].OPCNCJLMHAP, GFCGHLOOGCO, true);
					gameObject4.GetComponent<SketchThumbnail>().SetHomeProperties(GKJPOGNFKNK.DNILNCLIHAP("s" + HAGEHPPOPGH.EHBBFMCILPC.LNJNMEIIKJK[n].OPCNCJLMHAP.ToString(), "sketchtitles", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), true);
					this.AIKHINOIHDD[(int)GFCGHLOOGCO].Add(gameObject4.GetComponent<SketchThumbnail>());
				}
				return;
			}
			for (int num = 0; num < HAGEHPPOPGH.EHBBFMCILPC.LNJNMEIIKJK.Count; num++)
			{
				GameObject gameObject5 = UnityEngine.Object.Instantiate<GameObject>(this.sketchThumbnailPrefab, parent);
				gameObject5.GetComponent<SketchThumbnail>().Initialize(HAGEHPPOPGH.EHBBFMCILPC.LNJNMEIIKJK[num].OPCNCJLMHAP, GFCGHLOOGCO, true);
				gameObject5.GetComponent<SketchThumbnail>().SetHomeProperties(GKJPOGNFKNK.DNILNCLIHAP("s" + HAGEHPPOPGH.EHBBFMCILPC.LNJNMEIIKJK[num].OPCNCJLMHAP.ToString(), "sketchtitles", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), true);
				this.AIKHINOIHDD[(int)GFCGHLOOGCO].Add(gameObject5.GetComponent<SketchThumbnail>());
			}
			return;
		}
		else
		{
			if (GFCGHLOOGCO == CEEIOOODMKK.sketchesPageExploreFavorites)
			{
				for (int num2 = HAGEHPPOPGH.EHBBFMCILPC.ENOIGLJDFID.Count - 1; num2 >= 0; num2--)
				{
					GameObject gameObject6 = UnityEngine.Object.Instantiate<GameObject>(this.sketchThumbnailPrefab, parent);
					gameObject6.GetComponent<SketchThumbnail>().Initialize(HAGEHPPOPGH.EHBBFMCILPC.ENOIGLJDFID[num2].OPCNCJLMHAP, GFCGHLOOGCO, true);
					this.AIKHINOIHDD[(int)GFCGHLOOGCO].Add(gameObject6.GetComponent<SketchThumbnail>());
				}
				return;
			}
			if (GFCGHLOOGCO == CEEIOOODMKK.sketchesPageExploreSearch)
			{
				for (int num3 = HAGEHPPOPGH.EHBBFMCILPC.LIHLMHHLOBO.Count - 1; num3 >= 0; num3--)
				{
					GameObject gameObject7 = UnityEngine.Object.Instantiate<GameObject>(this.sketchThumbnailPrefab, parent);
					gameObject7.GetComponent<SketchThumbnail>().Initialize(HAGEHPPOPGH.EHBBFMCILPC.LIHLMHHLOBO[num3].OPCNCJLMHAP, GFCGHLOOGCO, true);
					this.AIKHINOIHDD[(int)GFCGHLOOGCO].Add(gameObject7.GetComponent<SketchThumbnail>());
				}
				return;
			}
			if (GFCGHLOOGCO == CEEIOOODMKK.sketchesPageCreators)
			{
				for (int num4 = 0; num4 < HAGEHPPOPGH.EHBBFMCILPC.DDDIBEFAPGL.Count; num4++)
				{
					GameObject gameObject8 = UnityEngine.Object.Instantiate<GameObject>(this.creatorThumbnailPrefab, parent);
					this.BEMGBBOGNCH[(int)GFCGHLOOGCO].Add(gameObject8.GetComponent<CreatorThumbnail>());
				}
			}
			return;
		}
	}

	// Token: 0x0600678C RID: 26508 RVA: 0x002FCB5C File Offset: 0x002FAD5C
	public void DKIABKOMNMB()
	{
		this.LDKAPIBJLKO((CEEIOOODMKK)(-28));
	}

	// Token: 0x0600678D RID: 26509 RVA: 0x002FCB66 File Offset: 0x002FAD66
	public void EBECGIMALNA()
	{
		this.ShowPage((CEEIOOODMKK)(-26));
	}

	// Token: 0x0600678E RID: 26510 RVA: 0x00003E52 File Offset: 0x00002052
	public void FEEGKACJDCG()
	{
	}

	// Token: 0x0600678F RID: 26511 RVA: 0x002FCB70 File Offset: 0x002FAD70
	private void MFGMCNDFPGC()
	{
		string text = AOBJLALDBAA.EHBBFMCILPC.KNCFLCKKPLK();
		if (text.Length > 0)
		{
			this.JLMHEMFNMJK = this.HPKDFMFEAHJ(this.GGIFHDGKALL, text);
			if (null != this.JLMHEMFNMJK)
			{
				this.KIDLCBGDMJB = DPPMPNEOPNF.JHJMDJGEHDK(this.JLMHEMFNMJK.GetSketchId(), this.JLMHEMFNMJK.GetUserGeneratedSketch());
				if (this.KIDLCBGDMJB != null && this.KIDLCBGDMJB.Count > 0)
				{
					AssetsManager.EHBBFMCILPC.UnloadPersistentAssetBundles();
					this.DownloadAssetBundleFolder();
				}
			}
		}
	}

	// Token: 0x06006790 RID: 26512 RVA: 0x002FCBFC File Offset: 0x002FADFC
	private SketchThumbnail OPBLONNCBIF(CEEIOOODMKK GFCGHLOOGCO, string LLPDFCDODIO)
	{
		for (int i = 0; i < this.AIKHINOIHDD[(int)GFCGHLOOGCO].Count; i++)
		{
			if (this.AIKHINOIHDD[(int)GFCGHLOOGCO][i].HABLLLIOPFB().Equals(LLPDFCDODIO))
			{
				return this.AIKHINOIHDD[(int)GFCGHLOOGCO][i];
			}
		}
		return null;
	}

	// Token: 0x06006791 RID: 26513 RVA: 0x002FCC4C File Offset: 0x002FAE4C
	private void CGPCLJHBMND()
	{
		AOBJLALDBAA.KKPFOJMAONG().NAMMLDPCHJO("null", new UnityAction(this.OnSketchesItemClose));
		AOBJLALDBAA.KKPFOJMAONG().KDIFKFKMCOH(" rtMemory:", new UnityAction(this.OFFBAMLEFNH));
		AOBJLALDBAA.DBLAIDPICIG().PFAHGKEDFAE("PurchaseManagerXiaomi.OnPurchasesQueried(): ", new UnityAction(this.OnPurchasingViewLeave));
		AOBJLALDBAA.AGANFKKBPFO().ONIBLJOFFPG("face", new UnityAction(this.GACGLFKFCLB));
		AOBJLALDBAA.KKPFOJMAONG().ECDBIBPNBCO("", new UnityAction(this.GBCBLABCBJO));
		AOBJLALDBAA.AGANFKKBPFO().PFAHGKEDFAE("episode", new UnityAction(this.BGPNHLHJBIK));
		AOBJLALDBAA.AGANFKKBPFO().MANLHALMCIH("", new UnityAction(this.NOIAKANHCAN));
		AOBJLALDBAA.DBLAIDPICIG().KDIFKFKMCOH("ratethankyou", new UnityAction(this.MFGMCNDFPGC));
		AOBJLALDBAA.KKPFOJMAONG().ONIBLJOFFPG("not", new UnityAction(this.KNFIKOGEHOH));
		AOBJLALDBAA.CEGAOMEEFBE().MHLNJIACIGO("OnSketchViewLeft", new UnityAction(this.LAIDAPNJOLJ));
		AOBJLALDBAA.KKPFOJMAONG().MANLHALMCIH("\"", new UnityAction(this.DAOLJLKKJDI));
		AOBJLALDBAA.EHBBFMCILPC.NAMMLDPCHJO("OnRestorePurchasesFailedInvalidPlatform", new UnityAction(this.KIDKNFPJOIE));
		AOBJLALDBAA.AGANFKKBPFO().MANLHALMCIH("\n\n", new UnityAction(this.ADCMPLEHOIF));
		AOBJLALDBAA.EHBBFMCILPC.ECDBIBPNBCO("signIn", new UnityAction(this.FJMGJCLHDBN));
		AOBJLALDBAA.KKPFOJMAONG().ECDBIBPNBCO("abska", new UnityAction(this.BOPPOJEHNNI));
		AOBJLALDBAA.EHBBFMCILPC.PBELMJCPJMK("", new UnityAction(this.PLFINBFADFL));
		AOBJLALDBAA.BIAEAOMHBMM().ONIBLJOFFPG("ok", new UnityAction(this.IGEGBOKNEMI));
		AOBJLALDBAA.EHBBFMCILPC.KDIFKFKMCOH("id", new UnityAction(this.ABJOOHLNDOJ));
		AOBJLALDBAA.NMGMNAKLLMI().PBELMJCPJMK("OnApplicationFocusNeedToUpdateCurrency", new UnityAction(this.OLCLHEMPNKF));
		this.JLMHEMFNMJK = null;
		this.KIDLCBGDMJB = null;
	}

	// Token: 0x06006792 RID: 26514 RVA: 0x002FCE68 File Offset: 0x002FB068
	private void OnEnable()
	{
		this.homeScrollRect.scrollSensitivity = 100f;
		this.editorInProgressScrollRect.scrollSensitivity = 100f;
		this.editorPublishedScrollRect.scrollSensitivity = 100f;
		this.exploreLatestScrollRect.scrollSensitivity = 100f;
		this.exploreViewedScrollRect.scrollSensitivity = 100f;
		this.exploreRatedScrollRect.scrollSensitivity = 100f;
		this.explorePicksScrollRect.scrollSensitivity = 100f;
		this.exploreFavoritesScrollRect.scrollSensitivity = 100f;
		this.exploreSearchScrollRect.scrollSensitivity = 100f;
		this.creatorsScrollRect.scrollSensitivity = 100f;
		this.userScrollRect.scrollSensitivity = 100f;
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnSketchesItemClose", new UnityAction(this.OnSketchesItemClose));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnApplicationFocusBasicSyncSuccess", new UnityAction(this.OFFBAMLEFNH));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPurchasingViewLeave", new UnityAction(this.OnPurchasingViewLeave));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnSketchViewAssetBundleFolderInitializeSuccess", new UnityAction(this.GACGLFKFCLB));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnSketchViewAssetsDownloadSuccess", new UnityAction(this.GBCBLABCBJO));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnSketchViewAssetsDownloadFailed", new UnityAction(this.BGPNHLHJBIK));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnSketchViewLeft", new UnityAction(this.EHIBOKHHKBF));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnSketchThumbnailPlay", new UnityAction(this.MFGMCNDFPGC));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendGetUserSketchesSuccess", new UnityAction(this.KNFIKOGEHOH));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendGetUserSketchesException", new UnityAction(this.LAIDAPNJOLJ));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnSketchThumbnailDuplicatePositive", new UnityAction(this.DFICFGAPGFL));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnSketchThumbnailDeletePositive", new UnityAction(this.KIDKNFPJOIE));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnSketchThumbnailEmptyClick", new UnityAction(this.ADCMPLEHOIF));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPopupSketchesInputEndEdit", new UnityAction(this.FJMGJCLHDBN));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPopupSketchesInputCancel", new UnityAction(this.BOPPOJEHNNI));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnSketchThumbnailEditTitle", new UnityAction(this.PLFINBFADFL));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnSketchThumbnailPublish", new UnityAction(this.GPHHLJOAIEK));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendPublishSketchSuccess", new UnityAction(this.ILNOLLKHIKE));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendPublishSketchException", new UnityAction(this.DBEIPLCDPFC));
		this.ShowPage(CEEIOOODMKK.sketchesPageHome);
	}

	// Token: 0x06006793 RID: 26515 RVA: 0x002FD12D File Offset: 0x002FB32D
	private void PBHLIGABAOI()
	{
		AOBJLALDBAA.NMGMNAKLLMI().EMOCOKNPEFH(", clamping to ", this.JLMHEMFNMJK.NMGKKPLEFHM());
	}

	// Token: 0x06006794 RID: 26516 RVA: 0x002FD149 File Offset: 0x002FB349
	private void CMDIKMNEGEN()
	{
		this.NPMNDNEDBGC = 0;
	}

	// Token: 0x06006795 RID: 26517 RVA: 0x002FD154 File Offset: 0x002FB354
	private void OKKBOFKILEA()
	{
		for (int i = 0; i < this.lobbyCameras.Count; i++)
		{
			this.lobbyCameras[i].enabled = false;
		}
	}

	// Token: 0x06006796 RID: 26518 RVA: 0x002FD189 File Offset: 0x002FB389
	private IEnumerator NGONGJMIENC()
	{
		SketchesItem.GAEAJOHDBNB gaeajohdbnb = new SketchesItem.GAEAJOHDBNB(1);
		gaeajohdbnb.<>4__this = this;
		return gaeajohdbnb;
	}

	// Token: 0x06006797 RID: 26519 RVA: 0x002FD198 File Offset: 0x002FB398
	private void ABJOOHLNDOJ()
	{
		CommonUserInterface.IKNOFBFMPGA().MCJIGJMFBMI();
		if (SketchesItem.publishSketchBackendResult == 1)
		{
			if (HAGEHPPOPGH.HFAKOKBHCGH().LNJNMEIIKJK.Count > 0)
			{
				if (null != this.JLMHEMFNMJK && this.JLMHEMFNMJK.KAICCOHEKPF() != null && HAGEHPPOPGH.EHBBFMCILPC.JIFLIEKDEAI(this.JLMHEMFNMJK.NOBKMHMONAM().HJOKNANDHBK))
				{
					this.SetPageDirty((CEEIOOODMKK)101);
				}
				CommonUserInterface.IKNOFBFMPGA().CEGLPJNLBHL(CCOJBMMKNAP.HEDIEIICOOG().IPEIONBNIPH("OffensiveWordsManager.IsOffensive() true for word "), CCOJBMMKNAP.INKJIBDDMLL().PKNHKGMNCIP("tutortitle"), CCOJBMMKNAP.INKJIBDDMLL().HDIPNMFHIEJ("@"), new UnityAction(this.FOHIJIANEIE), new UnityAction(this.DLOMCAPBAHB), (DFGILFBGPLN)(-91), 1925f, 7);
				return;
			}
		}
		else
		{
			CommonUserInterface.EHBBFMCILPC.NFBMHHPIGFA(CCOJBMMKNAP.LMCCLMFGEBD().PPALCPINPLK("OnBackendInitiateSteamTransactionFailed"), CCOJBMMKNAP.BBGECIKOICE().OHLNGCKIACD("OnSettingsPopupCloseAndNeedToRestartGame2" + SketchesItem.publishSketchBackendError.ToString()), CCOJBMMKNAP.OBOOKJPGBJN().GGPHHLGPMPA("dust"), (DFGILFBGPLN)(-42), 769f, -8);
		}
	}

	// Token: 0x06006798 RID: 26520 RVA: 0x00003E52 File Offset: 0x00002052
	private void OFFBAMLEFNH()
	{
	}

	// Token: 0x06006799 RID: 26521 RVA: 0x002FD2B8 File Offset: 0x002FB4B8
	public void OnExplorePicksClick()
	{
		this.ShowPage(CEEIOOODMKK.sketchesPageExplorePicks);
	}

	// Token: 0x0600679A RID: 26522 RVA: 0x002FD2C2 File Offset: 0x002FB4C2
	private void EHIBOKHHKBF()
	{
		if (1 == AKLFPGMDKLA.EHBBFMCILPC.PACMCEHMBGG)
		{
			AudioManager.EHBBFMCILPC.PlayMusic("lobby", true, -1f, false);
		}
		this.OPEGJAEFAJL();
		this.ODOPEGPBCCD();
		AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleSketchView, -1);
	}

	// Token: 0x0600679B RID: 26523 RVA: 0x002FD301 File Offset: 0x002FB501
	public void BNLMMFABKMA()
	{
		this.LDKAPIBJLKO((CEEIOOODMKK)(-8));
	}

	// Token: 0x0600679C RID: 26524 RVA: 0x002FD30B File Offset: 0x002FB50B
	private void NOIAKANHCAN()
	{
		if (1 == AKLFPGMDKLA.EHBBFMCILPC.PACMCEHMBGG)
		{
			AudioManager.APGODIBBPOD().CFEDKPAHOHJ("yes", true, 1931f, false);
		}
		this.OPEGJAEFAJL();
		this.ODOPEGPBCCD();
		AssetsManager.MJBDMHPHMID().NJEPIEPCCOF(NMKDCBPMCKI.AssetBundleHeadersPack, -1);
	}

	// Token: 0x0600679D RID: 26525 RVA: 0x002FD34A File Offset: 0x002FB54A
	public void OnHomeClick()
	{
		this.ShowPage(CEEIOOODMKK.sketchesPageHome);
	}

	// Token: 0x0600679E RID: 26526 RVA: 0x002FD354 File Offset: 0x002FB554
	private void HGNEOMJOBJP(CEEIOOODMKK GFCGHLOOGCO)
	{
		this.GGIFHDGKALL = GFCGHLOOGCO;
		this.homeFilter.SetActive(false);
		this.editorFilter.SetActive(false);
		this.exploreFilter.SetActive(false);
		this.creatorsFilter.SetActive(false);
		this.userFilter.SetActive(false);
		this.homeScrollRect.gameObject.SetActive(false);
		this.editorInProgressScrollRect.gameObject.SetActive(false);
		this.editorPublishedScrollRect.gameObject.SetActive(false);
		this.exploreLatestScrollRect.gameObject.SetActive(false);
		this.exploreViewedScrollRect.gameObject.SetActive(false);
		this.exploreRatedScrollRect.gameObject.SetActive(false);
		this.explorePicksScrollRect.gameObject.SetActive(false);
		this.exploreFavoritesScrollRect.gameObject.SetActive(false);
		this.exploreSearchScrollRect.gameObject.SetActive(false);
		this.creatorsScrollRect.gameObject.SetActive(false);
		this.userScrollRect.gameObject.SetActive(false);
		if (GFCGHLOOGCO >= CEEIOOODMKK.sketchesPageUser)
		{
			this.userFilter.SetActive(true);
		}
		else if (GFCGHLOOGCO >= CEEIOOODMKK.sketchesPageCreators)
		{
			this.creatorsFilter.SetActive(true);
		}
		else if (GFCGHLOOGCO >= CEEIOOODMKK.sketchesPageExploreLatest)
		{
			this.exploreFilter.SetActive(true);
		}
		else if (GFCGHLOOGCO >= CEEIOOODMKK.sketchesPageEditorInProgress)
		{
			this.editorFilter.SetActive(true);
		}
		else if (GFCGHLOOGCO >= CEEIOOODMKK.sketchesPageHome)
		{
			this.homeFilter.SetActive(true);
		}
		if (GFCGHLOOGCO <= CEEIOOODMKK.sketchesPageEditorInProgress)
		{
			if (GFCGHLOOGCO == CEEIOOODMKK.sketchesPageHome)
			{
				this.homeScrollRect.gameObject.SetActive(true);
				return;
			}
			if (GFCGHLOOGCO != CEEIOOODMKK.sketchesPageEditorInProgress)
			{
				return;
			}
			this.editorInProgressScrollRect.gameObject.SetActive(true);
			this.editorTitle.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(946), true);
			this.CKCIHDFNAJG(GFCGHLOOGCO);
			return;
		}
		else
		{
			if (GFCGHLOOGCO != CEEIOOODMKK.sketchesPageEditorPublished)
			{
				switch (GFCGHLOOGCO)
				{
				case CEEIOOODMKK.sketchesPageExploreLatest:
					this.exploreLatestScrollRect.gameObject.SetActive(true);
					this.exploreTitle.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(948), true);
					this.OAILEGFKOBP(GFCGHLOOGCO);
					return;
				case CEEIOOODMKK.sketchesPageExploreViewed:
					this.exploreViewedScrollRect.gameObject.SetActive(true);
					this.exploreTitle.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(949), true);
					this.OAILEGFKOBP(GFCGHLOOGCO);
					return;
				case CEEIOOODMKK.sketchesPageExploreRated:
					this.exploreRatedScrollRect.gameObject.SetActive(true);
					this.exploreTitle.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(950), true);
					this.OAILEGFKOBP(GFCGHLOOGCO);
					return;
				case CEEIOOODMKK.sketchesPageExplorePicks:
					this.explorePicksScrollRect.gameObject.SetActive(true);
					this.exploreTitle.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(951), true);
					this.OAILEGFKOBP(GFCGHLOOGCO);
					return;
				case CEEIOOODMKK.sketchesPageExploreFavorites:
					this.exploreFavoritesScrollRect.gameObject.SetActive(true);
					this.exploreTitle.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(952), true);
					this.OAILEGFKOBP(GFCGHLOOGCO);
					return;
				case CEEIOOODMKK.sketchesPageExploreSearch:
					this.exploreSearchScrollRect.gameObject.SetActive(true);
					this.exploreTitle.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(953), true);
					this.OAILEGFKOBP(GFCGHLOOGCO);
					return;
				case (CEEIOOODMKK)26:
				case (CEEIOOODMKK)27:
				case (CEEIOOODMKK)28:
				case (CEEIOOODMKK)29:
					break;
				case CEEIOOODMKK.sketchesPageCreators:
					this.creatorsScrollRect.gameObject.SetActive(true);
					return;
				default:
					if (GFCGHLOOGCO != CEEIOOODMKK.sketchesPageUser)
					{
						return;
					}
					this.userScrollRect.gameObject.SetActive(true);
					break;
				}
				return;
			}
			this.editorPublishedScrollRect.gameObject.SetActive(true);
			this.editorTitle.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(947), true);
			this.CKCIHDFNAJG(GFCGHLOOGCO);
			return;
		}
	}

	// Token: 0x0600679F RID: 26527 RVA: 0x002FD6E4 File Offset: 0x002FB8E4
	public void OnCreatorsClick()
	{
		this.ShowPage(CEEIOOODMKK.sketchesPageCreators);
	}

	// Token: 0x060067A0 RID: 26528 RVA: 0x002FAAFF File Offset: 0x002F8CFF
	private void LEEEOAHDCJD()
	{
		this.JLMHEMFNMJK = null;
		this.KIDLCBGDMJB = null;
		this.CleanupAllPages();
	}

	// Token: 0x060067A1 RID: 26529 RVA: 0x002F9D15 File Offset: 0x002F7F15
	private IEnumerator HNKPMLGCKHO()
	{
		AssetsManager.EHBBFMCILPC.InitializeAssetBundleFolder(LNDOOJOFFOM.Anthology59, "OnSketchViewAssetBundleFolderInitializeSuccess", "OnSketchViewAssetsDownloadFailed");
		yield return null;
		yield break;
	}

	// Token: 0x060067A2 RID: 26530 RVA: 0x002FD6F0 File Offset: 0x002FB8F0
	private SketchThumbnail LCIFJCDFEEJ(CEEIOOODMKK GFCGHLOOGCO, string LLPDFCDODIO)
	{
		for (int i = 0; i < this.AIKHINOIHDD[(int)GFCGHLOOGCO].Count; i += 0)
		{
			if (this.AIKHINOIHDD[(int)GFCGHLOOGCO][i].AEGKNDMIEDF().Equals(LLPDFCDODIO))
			{
				return this.AIKHINOIHDD[(int)GFCGHLOOGCO][i];
			}
		}
		return null;
	}

	// Token: 0x060067A3 RID: 26531 RVA: 0x002F9D06 File Offset: 0x002F7F06
	private void OGHIGBMMJOD()
	{
		base.StartCoroutine(this.NMLNGEKBLHI());
	}

	// Token: 0x060067A4 RID: 26532 RVA: 0x002FD740 File Offset: 0x002FB940
	private void NBPOIFJKNPI(CEEIOOODMKK CKGMIHJHJPK)
	{
		this.exploreLatestButton.interactable = (CKGMIHJHJPK != (CEEIOOODMKK)92);
		this.exploreViewedButton.interactable = (CKGMIHJHJPK == (CEEIOOODMKK)42);
		this.exploreRatedButton.interactable = (CKGMIHJHJPK == (CEEIOOODMKK)15);
		this.explorePicksButton.interactable = (CKGMIHJHJPK == (CEEIOOODMKK)(-77));
		this.exploreSearchButton.interactable = (CKGMIHJHJPK == (CEEIOOODMKK)65);
		this.exploreFavoritesButton.interactable = (CKGMIHJHJPK == (CEEIOOODMKK)(-19));
	}

	// Token: 0x060067A5 RID: 26533 RVA: 0x002FD7C0 File Offset: 0x002FB9C0
	private void Awake()
	{
		for (int i = 0; i < this.AIKHINOIHDD.Length; i++)
		{
			this.AIKHINOIHDD[i] = new List<SketchThumbnail>();
		}
		for (int j = 0; j < this.BEMGBBOGNCH.Length; j++)
		{
			this.BEMGBBOGNCH[j] = new List<CreatorThumbnail>();
		}
		for (int k = 0; k < this.NIDINJJDCEB.Length; k++)
		{
			this.NIDINJJDCEB[k] = true;
		}
	}

	// Token: 0x060067A6 RID: 26534 RVA: 0x002FD829 File Offset: 0x002FBA29
	private void FOHIJIANEIE()
	{
		this.HGNEOMJOBJP(CEEIOOODMKK.sketchesPageEditorPublished);
		this.SetPageDirty(CEEIOOODMKK.sketchesPageEditorPublished);
		this.FENMDOFKGFM(CEEIOOODMKK.sketchesPageEditorPublished, false);
	}

	// Token: 0x060067A7 RID: 26535 RVA: 0x002FD844 File Offset: 0x002FBA44
	public void PreCloseFocus()
	{
		this.CleanupAllPages();
		base.transform.parent.GetComponent<CanvasGroup>().alpha = 0f;
		base.transform.parent.gameObject.SetActive(false);
		base.GetComponent<RectTransform>().localScale = this.PFEEFOKHKMP;
	}

	// Token: 0x060067A8 RID: 26536 RVA: 0x002FB592 File Offset: 0x002F9792
	private IEnumerator PAHKMMEHOOF()
	{
		this.SetPageDirty(CEEIOOODMKK.sketchesPageEditorInProgress);
		CommonUserInterface.EHBBFMCILPC.FreezeUX();
		yield return new WaitForSeconds(0.25f);
		CommonUserInterface.EHBBFMCILPC.ResumeUX();
		this.ShowPage(CEEIOOODMKK.sketchesPageEditorInProgress);
		yield break;
	}

	// Token: 0x060067A9 RID: 26537 RVA: 0x002FD898 File Offset: 0x002FBA98
	private void DIPPGMDHEDM()
	{
		this.LDMBDKJNJCO(this.DOBAJJACGKK);
	}

	// Token: 0x060067AA RID: 26538 RVA: 0x002F9EC2 File Offset: 0x002F80C2
	public void AIACFNLJKBN()
	{
		this.CloseFocus();
	}

	// Token: 0x060067AB RID: 26539 RVA: 0x002FD8A6 File Offset: 0x002FBAA6
	public void INDGDOKIEFM()
	{
		this.LDMBDKJNJCO((CEEIOOODMKK)(-10));
	}

	// Token: 0x060067AC RID: 26540 RVA: 0x002FD8B0 File Offset: 0x002FBAB0
	private void GBCBLABCBJO()
	{
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.ENNMICAAJKI));
		AudioManager.EHBBFMCILPC.KillMusic("", -1f);
		this.CMDIKMNEGEN();
	}

	// Token: 0x060067AD RID: 26541 RVA: 0x002FBC0C File Offset: 0x002F9E0C
	public void OBGLPDGJMJP()
	{
		this.LDKAPIBJLKO(CEEIOOODMKK.sketchesPageHome);
	}

	// Token: 0x060067AE RID: 26542 RVA: 0x002FD908 File Offset: 0x002FBB08
	public void ShowPage(CEEIOOODMKK GFCGHLOOGCO)
	{
		if (this.AMNDBDHELDD(GFCGHLOOGCO) && ((GFCGHLOOGCO != CEEIOOODMKK.sketchesPageCreators && this.AIKHINOIHDD[(int)GFCGHLOOGCO].Count == 0) || (GFCGHLOOGCO == CEEIOOODMKK.sketchesPageCreators && this.BEMGBBOGNCH[(int)GFCGHLOOGCO].Count == 0)))
		{
			this.DOBAJJACGKK = GFCGHLOOGCO;
			CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(96);
			HAGEHPPOPGH.EHBBFMCILPC.LNJNMEIIKJK.Clear();
			HAGEHPPOPGH.EHBBFMCILPC.DDDIBEFAPGL.Clear();
			BackendOperationsManager.EHBBFMCILPC.RequestGetUserSketches((int)GFCGHLOOGCO, "OnBackendGetUserSketchesSuccess", "OnBackendGetUserSketchesException");
			return;
		}
		this.HGNEOMJOBJP(GFCGHLOOGCO);
		this.FENMDOFKGFM(GFCGHLOOGCO, false);
	}

	// Token: 0x060067AF RID: 26543 RVA: 0x00003E52 File Offset: 0x00002052
	public void OnEditorResetClick()
	{
	}

	// Token: 0x060067B0 RID: 26544 RVA: 0x002FD99C File Offset: 0x002FBB9C
	private void CKCIHDFNAJG(CEEIOOODMKK CKGMIHJHJPK)
	{
		this.editorInProgressButton.interactable = (CKGMIHJHJPK != CEEIOOODMKK.sketchesPageEditorInProgress);
		this.editorPublishedButton.interactable = (CKGMIHJHJPK != CEEIOOODMKK.sketchesPageEditorPublished);
	}

	// Token: 0x060067B1 RID: 26545 RVA: 0x002FD9C4 File Offset: 0x002FBBC4
	public void ACOHFHAENIB()
	{
		this.LDKAPIBJLKO((CEEIOOODMKK)(-9));
	}

	// Token: 0x060067B2 RID: 26546 RVA: 0x002FD9D0 File Offset: 0x002FBBD0
	private void PLFINBFADFL()
	{
		string text = AOBJLALDBAA.EHBBFMCILPC.KNCFLCKKPLK();
		if (text.Length > 0)
		{
			this.JLMHEMFNMJK = this.HPKDFMFEAHJ(this.GGIFHDGKALL, text);
			if (null != this.JLMHEMFNMJK && this.JLMHEMFNMJK.GetUserGeneratedSketch() != null)
			{
				CommonUserInterface.EHBBFMCILPC.ShowPopupSketchesInput();
			}
		}
	}

	// Token: 0x060067B3 RID: 26547 RVA: 0x002FDA2C File Offset: 0x002FBC2C
	private void KFPGMOEDHJH()
	{
		string text = AOBJLALDBAA.DBLAIDPICIG().KNCFLCKKPLK();
		if (text.Length > 1)
		{
			this.JLMHEMFNMJK = this.OPBLONNCBIF(this.GGIFHDGKALL, text);
			if (null != this.JLMHEMFNMJK && this.JLMHEMFNMJK.NOBKMHMONAM() != null)
			{
				CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation((byte)-62);
				BackendOperationsManager.NPDDBAONMJP().RequestPublishUserSketch(this.JLMHEMFNMJK.NOBKMHMONAM(), "abskv", "socialdequeusp2get");
			}
		}
	}

	// Token: 0x060067B4 RID: 26548 RVA: 0x002FBA5D File Offset: 0x002F9C5D
	private IEnumerator GFPDIIOBNMN()
	{
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().EPJKDCDOEMM(0);
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithProgress(96);
		yield return new WaitForSeconds(0.2f);
		AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleSketchView, -1, -1, FLDBFOADFLH.finishDownloadAndProceed, false, true, false, null, -1, false, "", false, false);
		for (int i = 0; i < this.KIDLCBGDMJB.Count; i++)
		{
			if (this.KIDLCBGDMJB[i].LDAMLJEPKMC >= 0 && this.KIDLCBGDMJB[i].ADDKGCPPLFH >= 0)
			{
				AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleStoryAssetPack, this.KIDLCBGDMJB[i].ADDKGCPPLFH, this.KIDLCBGDMJB[i].LDAMLJEPKMC, FLDBFOADFLH.startDownloadAndProceed, false, true, false, null, -1, false, "", false, false);
			}
		}
		for (int j = 0; j < this.KIDLCBGDMJB.Count; j++)
		{
			if (this.KIDLCBGDMJB[j].BOHMFHEKFMI >= 0 && this.KIDLCBGDMJB[j].MCGLHPDFIBB >= 0)
			{
				AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleStoryAssetPack, this.KIDLCBGDMJB[j].MCGLHPDFIBB, this.KIDLCBGDMJB[j].BOHMFHEKFMI, FLDBFOADFLH.startDownloadAndProceed, true, true, false, null, -1, false, "", false, false);
			}
		}
		for (int k = 0; k < this.KIDLCBGDMJB.Count; k++)
		{
			if (this.KIDLCBGDMJB[k].HEHFACLGNPA >= 0 && this.KIDLCBGDMJB[k].ONKJOHENIOC >= 0)
			{
				AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleStoryAssetPack, this.KIDLCBGDMJB[k].ONKJOHENIOC, this.KIDLCBGDMJB[k].HEHFACLGNPA, FLDBFOADFLH.startDownloadAndProceed, true, true, false, null, -1, false, "", false, false);
			}
		}
		for (int l = 0; l < this.KIDLCBGDMJB.Count; l++)
		{
			if (this.KIDLCBGDMJB[l].AHJFHPIGCCM >= 0 && this.KIDLCBGDMJB[l].MBOBKDKLGEI >= 0)
			{
				AssetsManager.EHBBFMCILPC.QueueAssetBundleDownloadNoSkip(NMKDCBPMCKI.AssetBundleStoryAssetPack, this.KIDLCBGDMJB[l].MBOBKDKLGEI, this.KIDLCBGDMJB[l].AHJFHPIGCCM, FLDBFOADFLH.startDownloadAndProceed, true, true, false, null, -1, "", false, KHPGPLAMAIN.HHDAPAJEIML());
			}
		}
		AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleStoryAssetPackActivate, 0, 0, FLDBFOADFLH.finishDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().CLIOEOLFFLO(LEJKDNAGDHC.Fast);
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().GIJKJMMDJEL(0f, 1f);
		AssetsManager.EHBBFMCILPC.DownloadQueuedAssetBundles("OnSketchViewAssetsDownloadSuccess", "OnSketchViewAssetsDownloadFailed", false);
		yield break;
	}

	// Token: 0x060067B5 RID: 26549 RVA: 0x00003E52 File Offset: 0x00002052
	public void OnEditorEditClick()
	{
	}

	// Token: 0x060067B6 RID: 26550 RVA: 0x002FDAA8 File Offset: 0x002FBCA8
	public void LDKAPIBJLKO(CEEIOOODMKK GFCGHLOOGCO)
	{
		if (this.AMNDBDHELDD(GFCGHLOOGCO) && ((GFCGHLOOGCO != (CEEIOOODMKK)(-72) && this.AIKHINOIHDD[(int)GFCGHLOOGCO].Count == 0) || (GFCGHLOOGCO == (CEEIOOODMKK)(-10) && this.BEMGBBOGNCH[(int)GFCGHLOOGCO].Count == 0)))
		{
			this.DOBAJJACGKK = GFCGHLOOGCO;
			CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation((byte)-109);
			HAGEHPPOPGH.FJHKMJPFDNI().LNJNMEIIKJK.Clear();
			HAGEHPPOPGH.HFAKOKBHCGH().DDDIBEFAPGL.Clear();
			BackendOperationsManager.EHBBFMCILPC.RequestGetUserSketches((int)GFCGHLOOGCO, "esv", "loungeindevelopment");
			return;
		}
		this.HGNEOMJOBJP(GFCGHLOOGCO);
		this.JFKBCFJOBCM(GFCGHLOOGCO, true);
	}

	// Token: 0x060067B7 RID: 26551 RVA: 0x002FDB3C File Offset: 0x002FBD3C
	private void AKFKBOOBDCP()
	{
		AOBJLALDBAA.FILDBDMENPG().AKILMNPJGGM("no", this.JLMHEMFNMJK.PEPMCOGIEJN());
	}

	// Token: 0x060067B8 RID: 26552 RVA: 0x002FDB58 File Offset: 0x002FBD58
	public void OCKPMMKCBLI()
	{
		this.LDMBDKJNJCO((CEEIOOODMKK)5);
	}

	// Token: 0x060067B9 RID: 26553 RVA: 0x002FDB64 File Offset: 0x002FBD64
	private void ENNMICAAJKI()
	{
		if (null != this.JLMHEMFNMJK)
		{
			this.OKKBOFKILEA();
			this.ALGIAIKDEPH();
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnSketchViewShowWI", 0f);
			CommonUserInterface.EHBBFMCILPC.GetSketchViewManager().Show(this.JLMHEMFNMJK.GetSketchId(), this.JLMHEMFNMJK.GetUserGeneratedSketch());
		}
	}

	// Token: 0x04001E40 RID: 7744
	public static int publishSketchBackendResult;

	// Token: 0x04001E41 RID: 7745
	public static int publishSketchBackendError;

	// Token: 0x04001E42 RID: 7746
	public const string onBackendGetUserSketchesSuccess = "OnBackendGetUserSketchesSuccess";

	// Token: 0x04001E43 RID: 7747
	public const string onBackendGetUserSketchesException = "OnBackendGetUserSketchesException";

	// Token: 0x04001E44 RID: 7748
	public const string onBackendPublishSketchSuccess = "OnBackendPublishSketchSuccess";

	// Token: 0x04001E45 RID: 7749
	public const string onBackendPublishSketchException = "OnBackendPublishSketchException";

	// Token: 0x04001E46 RID: 7750
	private const string EKAMAKLAOPJ = "OnSketchViewAssetBundleFolderInitializeSuccess";

	// Token: 0x04001E47 RID: 7751
	private const string NABAPCMNHDJ = "OnSketchViewAssetsDownloadSuccess";

	// Token: 0x04001E48 RID: 7752
	private const string EMIOKGEIGFE = "OnSketchViewAssetsDownloadFailed";

	// Token: 0x04001E49 RID: 7753
	public const string onSketchViewShowWI = "OnSketchViewShowWI";

	// Token: 0x04001E4A RID: 7754
	public List<Canvas> lobbyCanvases = new List<Canvas>();

	// Token: 0x04001E4B RID: 7755
	public List<Camera> lobbyCameras = new List<Camera>();

	// Token: 0x04001E4C RID: 7756
	public GameObject sketchThumbnailPrefab;

	// Token: 0x04001E4D RID: 7757
	public GameObject creatorThumbnailPrefab;

	// Token: 0x04001E4E RID: 7758
	public GameObject homeFilter;

	// Token: 0x04001E4F RID: 7759
	public GameObject editorFilter;

	// Token: 0x04001E50 RID: 7760
	public GameObject exploreFilter;

	// Token: 0x04001E51 RID: 7761
	public GameObject creatorsFilter;

	// Token: 0x04001E52 RID: 7762
	public GameObject userFilter;

	// Token: 0x04001E53 RID: 7763
	public Transform homeContentRoot;

	// Token: 0x04001E54 RID: 7764
	public Transform editorInProgressContenRoot;

	// Token: 0x04001E55 RID: 7765
	public Transform editorPublishedContenRoot;

	// Token: 0x04001E56 RID: 7766
	public Transform exploreLatestContentRoot;

	// Token: 0x04001E57 RID: 7767
	public Transform exploreViewedContentRoot;

	// Token: 0x04001E58 RID: 7768
	public Transform exploreRatedContentRoot;

	// Token: 0x04001E59 RID: 7769
	public Transform explorePicksContentRoot;

	// Token: 0x04001E5A RID: 7770
	public Transform exploreFavoritesContentRoot;

	// Token: 0x04001E5B RID: 7771
	public Transform exploreSearchContentRoot;

	// Token: 0x04001E5C RID: 7772
	public Transform creatorsContentRoot;

	// Token: 0x04001E5D RID: 7773
	public Transform userContentRoot;

	// Token: 0x04001E5E RID: 7774
	public ScrollRect homeScrollRect;

	// Token: 0x04001E5F RID: 7775
	public ScrollRect editorInProgressScrollRect;

	// Token: 0x04001E60 RID: 7776
	public ScrollRect editorPublishedScrollRect;

	// Token: 0x04001E61 RID: 7777
	public ScrollRect exploreLatestScrollRect;

	// Token: 0x04001E62 RID: 7778
	public ScrollRect exploreViewedScrollRect;

	// Token: 0x04001E63 RID: 7779
	public ScrollRect exploreRatedScrollRect;

	// Token: 0x04001E64 RID: 7780
	public ScrollRect explorePicksScrollRect;

	// Token: 0x04001E65 RID: 7781
	public ScrollRect exploreFavoritesScrollRect;

	// Token: 0x04001E66 RID: 7782
	public ScrollRect exploreSearchScrollRect;

	// Token: 0x04001E67 RID: 7783
	public ScrollRect creatorsScrollRect;

	// Token: 0x04001E68 RID: 7784
	public ScrollRect userScrollRect;

	// Token: 0x04001E69 RID: 7785
	public TextMeshProUGUI editorTitle;

	// Token: 0x04001E6A RID: 7786
	public TextMeshProUGUI exploreTitle;

	// Token: 0x04001E6B RID: 7787
	public GameObject editorInProgressEmptyThumbnail;

	// Token: 0x04001E6C RID: 7788
	public Button editorInProgressButton;

	// Token: 0x04001E6D RID: 7789
	public Button editorPublishedButton;

	// Token: 0x04001E6E RID: 7790
	public Button exploreLatestButton;

	// Token: 0x04001E6F RID: 7791
	public Button exploreViewedButton;

	// Token: 0x04001E70 RID: 7792
	public Button exploreRatedButton;

	// Token: 0x04001E71 RID: 7793
	public Button explorePicksButton;

	// Token: 0x04001E72 RID: 7794
	public Button exploreFavoritesButton;

	// Token: 0x04001E73 RID: 7795
	public Button exploreSearchButton;

	// Token: 0x04001E74 RID: 7796
	public const string onSketchesItemClose = "OnSketchesItemClose";

	// Token: 0x04001E75 RID: 7797
	private Vector3 PFEEFOKHKMP;

	// Token: 0x04001E76 RID: 7798
	private int NPMNDNEDBGC;

	// Token: 0x04001E77 RID: 7799
	private List<SketchThumbnail>[] AIKHINOIHDD = new List<SketchThumbnail>[100];

	// Token: 0x04001E78 RID: 7800
	private List<CreatorThumbnail>[] BEMGBBOGNCH = new List<CreatorThumbnail>[100];

	// Token: 0x04001E79 RID: 7801
	private bool[] NIDINJJDCEB = new bool[100];

	// Token: 0x04001E7A RID: 7802
	private CEEIOOODMKK GGIFHDGKALL;

	// Token: 0x04001E7B RID: 7803
	private CEEIOOODMKK DOBAJJACGKK;

	// Token: 0x04001E7C RID: 7804
	private List<FHNCFMMBDPF> KIDLCBGDMJB;

	// Token: 0x04001E7D RID: 7805
	private SketchThumbnail JLMHEMFNMJK;
}
