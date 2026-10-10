using System;
using System.Collections;
using System.Collections.Generic;
using SimpleJSON;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x02000062 RID: 98
public class FocusItem : MonoBehaviour
{
	// Token: 0x06000D81 RID: 3457 RVA: 0x0006108F File Offset: 0x0005F28F
	private void DNANKPMNMIF()
	{
		if (this.thumbnail.gameObject.GetComponent<ImageFrameAnimation>() != null)
		{
			this.thumbnail.GetComponent<ImageFrameAnimation>().framesSD = null;
		}
	}

	// Token: 0x06000D82 RID: 3458 RVA: 0x000610BA File Offset: 0x0005F2BA
	public NDHKFLHAFNA GetAnthologyHint()
	{
		return this.NDIPGHMNCCF;
	}

	// Token: 0x06000D83 RID: 3459 RVA: 0x000610C2 File Offset: 0x0005F2C2
	private void BAMHACBFGDK()
	{
		this.closeButton.interactable = true;
		ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass, true);
	}

	// Token: 0x06000D84 RID: 3460 RVA: 0x000610D8 File Offset: 0x0005F2D8
	private void OJAICJOANNG()
	{
		this.closeButton.interactable = false;
	}

	// Token: 0x06000D85 RID: 3461 RVA: 0x000610E8 File Offset: 0x0005F2E8
	public void RefreshAnthologyHint(NDHKFLHAFNA BGBNAKAPJIL, Sprite BIIMLMBELDP)
	{
		try
		{
			this.NDIPGHMNCCF = BGBNAKAPJIL;
			if (null != this.itemTagIcon && null != BIIMLMBELDP)
			{
				this.itemTagIcon.sprite = BIIMLMBELDP;
			}
			this.OnLanguageChange();
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000D86 RID: 3462 RVA: 0x00061140 File Offset: 0x0005F340
	public void GFONEIAINIL(NDHKFLHAFNA BGBNAKAPJIL, Sprite BIIMLMBELDP)
	{
		try
		{
			this.NDIPGHMNCCF = BGBNAKAPJIL;
			if (null != this.itemTagIcon && null != BIIMLMBELDP)
			{
				this.itemTagIcon.sprite = BIIMLMBELDP;
			}
			this.OnLanguageChange();
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06000D87 RID: 3463 RVA: 0x00061198 File Offset: 0x0005F398
	private void CGGOJEPOOON()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		this.DECFOPMOPHA();
	}

	// Token: 0x06000D88 RID: 3464 RVA: 0x000610D8 File Offset: 0x0005F2D8
	private void CMHOMCLCJGI()
	{
		this.closeButton.interactable = false;
	}

	// Token: 0x06000D89 RID: 3465 RVA: 0x000611AC File Offset: 0x0005F3AC
	private void Update()
	{
		if (LiveEventsManager.EHBBFMCILPC.LiveEventActive(EGMCEPOABBF.liveEventFreeStory, GKJPOGNFKNK.BKBCNMEHGFA(this.AMKCLHLIIMN), -1))
		{
			if (null != this.freePlayModeObj && !this.freePlayModeObj.gameObject.activeSelf)
			{
				this.freePlayModeObj.gameObject.SetActive(true);
			}
		}
		else if (null != this.freePlayModeObj && this.freePlayModeObj.gameObject.activeSelf)
		{
			this.freePlayModeObj.gameObject.SetActive(false);
		}
		if (this.OJOONOFEIMG && !this.HJBMNLBOEAL && !this.GMLKPEHPCHB && this.FNJJIPNFCMK.ONMADEIOOKN.ODHBINFKIPL() < 1f)
		{
			this.GMLKPEHPCHB = true;
			this.tagTimerEnd.gameObject.SetActive(true);
			this.tagTimerDynamicText.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("eventended"), true);
		}
		if (KDCJJBLGCBH.EHBBFMCILPC.DLJGJOCJIED())
		{
			this.HideMiniLoadingAnimation();
			return;
		}
		if (!(null != this.NPMBHDLIDFC))
		{
			this.HideMiniLoadingAnimation();
			return;
		}
		if (!GKJPOGNFKNK.KJFNIHOAOKE(this.NPMBHDLIDFC))
		{
			this.HideMiniLoadingAnimation();
			return;
		}
		AssetAnthologyPreview2 assetAnthologyPreview = GKJPOGNFKNK.OGKPKBLFGMJ(this.NPMBHDLIDFC.index);
		if (null != assetAnthologyPreview && assetAnthologyPreview != this.NPMBHDLIDFC)
		{
			this.NPMBHDLIDFC = assetAnthologyPreview;
			this.thumbnail.sprite = this.NPMBHDLIDFC.CFHFGGICGIL()[0];
			if (this.thumbnail.gameObject.GetComponent<ImageFrameAnimation>() != null)
			{
				UnityEngine.Object.Destroy(this.thumbnail.gameObject.GetComponent<ImageFrameAnimation>());
			}
			this.thumbnail.gameObject.AddComponent<ImageFrameAnimation>();
			this.thumbnail.GetComponent<ImageFrameAnimation>().frameChangeInterval = this.NPMBHDLIDFC.frameChangeInterval;
			this.thumbnail.GetComponent<ImageFrameAnimation>().framesSD = this.NPMBHDLIDFC.CFHFGGICGIL().ToArray();
			if (this.NPMBHDLIDFC.pauseFrame >= 0)
			{
				this.thumbnail.GetComponent<ImageFrameAnimation>().pauseFrame = this.NPMBHDLIDFC.pauseFrame;
				this.thumbnail.GetComponent<ImageFrameAnimation>().pauseTime = this.NPMBHDLIDFC.pauseTime;
			}
			else
			{
				this.thumbnail.GetComponent<ImageFrameAnimation>().pauseFrame = -1;
				this.thumbnail.GetComponent<ImageFrameAnimation>().pauseTime = 0f;
			}
			this.thumbnail.GetComponent<ImageFrameAnimation>().reverseDirection = this.NPMBHDLIDFC.reverseDirection;
			this.logo.sprite = this.NPMBHDLIDFC.logo;
			this.logo.SetNativeSize();
			this.logo.rectTransform.anchoredPosition = new Vector2(this.logo.rectTransform.anchoredPosition.x + (float)this.NPMBHDLIDFC.logoOffsetX, (float)this.NPMBHDLIDFC.logoOffsetY);
			this.logo.rectTransform.localScale = new Vector3(this.NPMBHDLIDFC.logoScaleFactor, this.NPMBHDLIDFC.logoScaleFactor, this.NPMBHDLIDFC.logoScaleFactor) * 1.08f;
			this.HideMiniLoadingAnimation();
			return;
		}
		this.ShowMiniLoadingAnimation();
	}

	// Token: 0x06000D8A RID: 3466 RVA: 0x000614DC File Offset: 0x0005F6DC
	private void AMMCOLDGOAK()
	{
		this.closeButton.interactable = true;
		this.chapterSnapshotsItem.CloseFocus();
	}

	// Token: 0x06000D8B RID: 3467 RVA: 0x000614F8 File Offset: 0x0005F6F8
	private void LGAGMPFBPMP(bool OJOONOFEIMG, PLFDAJJHMKO OJJLCOAEFCC, EIOPLEFLLIM KFIKFODICCB, int MPHLJCKDJLH, int OLKMHHNMDLP)
	{
		this.JPIBLAOGEIJ++;
		if (OJOONOFEIMG)
		{
			if (this.FNJJIPNFCMK.KONDFFEKAND == EGMCEPOABBF.liveEventFreeStory || this.FNJJIPNFCMK.KONDFFEKAND == EGMCEPOABBF.liveEventBonusStory)
			{
				float y = -318.4f;
				int num = 145;
				this.playButtonCard.GetComponent<RectTransform>().anchoredPosition = new Vector2(this.playButtonCard.GetComponent<RectTransform>().anchoredPosition.x, y);
				this.cardObjects.GetComponent<RectTransform>().anchoredPosition = new Vector2(this.cardObjects.GetComponent<RectTransform>().anchoredPosition.x, (float)num);
				this.playButtonCard.SetActive(true);
			}
			else
			{
				float y2 = -328.4f;
				int num2 = 135;
				this.playButtonCard.GetComponent<RectTransform>().anchoredPosition = new Vector2(this.playButtonCard.GetComponent<RectTransform>().anchoredPosition.x, y2);
				this.cardObjects.GetComponent<RectTransform>().anchoredPosition = new Vector2(this.cardObjects.GetComponent<RectTransform>().anchoredPosition.x, (float)num2);
				this.playButtonCard.SetActive(false);
			}
			this.cardObjects.SetActive(true);
			this.description.gameObject.SetActive(false);
			this.tagEpisodeCount.SetActive(false);
			this.tagEpisodeCountButton.SetActive(false);
			this.episode.gameObject.SetActive(false);
			this.season.gameObject.SetActive(false);
			this.playButton.SetActive(false);
			this.restartButton.SetActive(false);
			this.avatarButton.SetActive(false);
			this.saveSlotsButton.SetActive(false);
			return;
		}
		this.cardObjects.SetActive(false);
		this.playButtonCard.SetActive(false);
		this.description.gameObject.SetActive(true);
		this.tagHint.SetActive(true);
		this.tagEpisodeCount.SetActive(true);
		this.tagEpisodeCountButton.SetActive(true);
		this.episode.gameObject.SetActive(true);
		this.season.gameObject.SetActive(true);
		this.playButton.SetActive(true);
		this.restartButton.SetActive(true);
		this.avatarButton.SetActive(true);
		this.saveSlotsButton.SetActive(true);
		try
		{
			if (this.JPIBLAOGEIJ == 1)
			{
				if (OJJLCOAEFCC != null && MPHLJCKDJLH % 5 == 0 && OLKMHHNMDLP == 0 && OJJLCOAEFCC.DHONIOBOLEL.JBDPAJMOEGA())
				{
					this.avatarButton.SetActive(false);
					this.saveSlotsButton.SetActive(false);
				}
				if (KFIKFODICCB != null && KFIKFODICCB.NLCJBMHKHCB() && KFIKFODICCB.ILOKBAPEJPK == 0 && !AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(25))
				{
					this.saveSlotsButton.SetActive(false);
				}
				else
				{
					this.saveSlotsButton.SetActive(true);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		this.ENKNAEJPDKF();
	}

	// Token: 0x06000D8C RID: 3468 RVA: 0x000617D4 File Offset: 0x0005F9D4
	public void ShowChapterSnapshots(bool JJAKPMDJNIA)
	{
		if (JJAKPMDJNIA)
		{
			this.DECFOPMOPHA();
			return;
		}
		EIOPLEFLLIM eioplefllim = AKLFPGMDKLA.EHBBFMCILPC.GJBDBONJCDL(this.currentAnthologyIndex);
		bool flag = false;
		if (eioplefllim != null && eioplefllim.EPEOKHOBOBL[eioplefllim.ILOKBAPEJPK] == 0)
		{
			AssetAnthologyHeader assetAnthologyHeader = GKJPOGNFKNK.BDEJIINKEHH(this.currentAnthologyIndex);
			JSONArray jsonarray = new JSONArray();
			for (int i = 0; i < assetAnthologyHeader.maxStories; i++)
			{
				if (i <= eioplefllim.EGHHCFFLPCP(-1) && i < assetAnthologyHeader.availableStories.Count)
				{
					PLFDAJJHMKO plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.PKNIPLDMJGG(assetAnthologyHeader.availableStories[i], -1);
					if (plfdajjhmko != null)
					{
						for (int j = 0; j < plfdajjhmko.KIHACLLJMDH.Count; j++)
						{
							jsonarray.Add(i * 50 + plfdajjhmko.KIHACLLJMDH[j]);
						}
					}
				}
			}
			if (jsonarray.Count > 0)
			{
				flag = true;
				CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithHint(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("serversync"), 96);
				BackendOperationsManager.EHBBFMCILPC.RequestGetChapterSnapshots(this.currentAnthologyIndex, eioplefllim.ILOKBAPEJPK, jsonarray, "OnChapterSnapshotsBackendFetchSuccess", "OnChapterSnapshotsBackendFetchException");
			}
			else
			{
				eioplefllim.EPEOKHOBOBL[eioplefllim.ILOKBAPEJPK] = 1;
				this.DECFOPMOPHA();
			}
		}
		if (!flag)
		{
			this.DECFOPMOPHA();
		}
	}

	// Token: 0x06000D8D RID: 3469 RVA: 0x00061918 File Offset: 0x0005FB18
	public void OnSaveSlotsClick()
	{
		try
		{
			this.closeButton.interactable = false;
			this.saveSlotsFade.SetActive(true);
			this.saveSlotsItem.InitializeSlots(this.currentAnthologyIndex);
			base.StartCoroutine(this.FINPCOMDIFD(this.saveSlotsFade, this.saveSlotsItem.gameObject, 0.1f, true));
			if (AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(25) && this.LNKEFNINAFJ(AKLFPGMDKLA.EHBBFMCILPC.GJBDBONJCDL(this.currentAnthologyIndex)))
			{
				this.saveSlotsItem.ShowExpiredPassHint();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000D8E RID: 3470 RVA: 0x000619BC File Offset: 0x0005FBBC
	public bool LoungeAvailableForFocusedAnthology()
	{
		FJLGCKNOJMJ fjlgcknojmj = null;
		try
		{
			if (this.AMKCLHLIIMN >= 0 && null != AssetsManager.EHBBFMCILPC && null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				fjlgcknojmj = AssetsManager.EHBBFMCILPC.lobbyDataAsset.MFMJHIFAOHE().ELDKHHGLNBK(this.AMKCLHLIIMN);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			fjlgcknojmj = null;
		}
		if (fjlgcknojmj != null && !KDCJJBLGCBH.EHBBFMCILPC.NJFAOIDGFGC())
		{
			fjlgcknojmj = null;
		}
		return fjlgcknojmj != null && fjlgcknojmj.PPACJFFFBFB;
	}

	// Token: 0x06000D8F RID: 3471 RVA: 0x00061A48 File Offset: 0x0005FC48
	private void DECFOPMOPHA()
	{
		try
		{
			this.closeButton.interactable = false;
			this.chapterSnapshotsFade.SetActive(true);
			this.chapterSnapshotsItem.InitializeSnapshots(this.currentAnthologyIndex);
			base.StartCoroutine(this.FINPCOMDIFD(this.chapterSnapshotsFade, this.chapterSnapshotsItem.gameObject, 0.1f, true));
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000D90 RID: 3472 RVA: 0x00061ABC File Offset: 0x0005FCBC
	public void OnRelasedChaptersCountClick()
	{
		if (this.tagEpisodeCount.activeSelf)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), string.Concat(new string[]
			{
				CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("releasedchapterscount"),
				" ",
				this.LGIECOAIEFN.ToString(),
				"/",
				this.DGODOICGJJC.ToString()
			}), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupComingSoon, 0f, 28);
		}
	}

	// Token: 0x06000D91 RID: 3473 RVA: 0x00061B51 File Offset: 0x0005FD51
	public void ShowMiniLoadingAnimation()
	{
		if (!this.miniLoadingAnimation.activeSelf)
		{
			this.miniLoadingAnimation.SetActive(true);
		}
	}

	// Token: 0x06000D92 RID: 3474 RVA: 0x00061B6C File Offset: 0x0005FD6C
	private IEnumerator FINPCOMDIFD(GameObject FLPKFNLNLHN, GameObject NAFPJPEHMDG, float IBOPEKIFJDH, bool FPMJCJPMGME)
	{
		float currentTime = 0f;
		RectTransform focusItemRectTransform = NAFPJPEHMDG.GetComponent<RectTransform>();
		Vector3 startScale = focusItemRectTransform.localScale;
		while (currentTime <= IBOPEKIFJDH)
		{
			currentTime += Time.deltaTime;
			float t = currentTime / IBOPEKIFJDH;
			if (FPMJCJPMGME)
			{
				FLPKFNLNLHN.GetComponent<CanvasGroup>().alpha = Mathf.Lerp(0f, 1f, t);
			}
			focusItemRectTransform.localScale = Vector3.Lerp(startScale, NarrowScreenScaler.CalculateNewScaleUtil(new Vector3(1f, 1f, 1f), 822f, IMBLFHMKMAD.doNotOverride), t);
			yield return null;
		}
		yield break;
	}

	// Token: 0x06000D93 RID: 3475 RVA: 0x00061B91 File Offset: 0x0005FD91
	private void GCNNLOLBPAE()
	{
		this.closeButton.interactable = true;
		this.chapterSnapshotsItem.CloseFocus();
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnRestartChapterUpsellGetPassPositive", 0.1f);
		this.CloseFocus();
	}

	// Token: 0x06000D94 RID: 3476 RVA: 0x00061BC4 File Offset: 0x0005FDC4
	private void GMKELJMLKHD()
	{
		if (!SaveSlotsItem.slotChanged)
		{
			if (SaveSlotsItem.slotDeleted || SaveSlotsItem.slotEdited || SaveSlotsItem.slotDuplicated)
			{
				AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
				CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithHint(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("serversync"), 96);
				BackendOperationsManager.EHBBFMCILPC.QueueRequestSaveChapterSnapshots();
				BackendOperationsManager.EHBBFMCILPC.QueueRequestSaveAvatarCollections();
				BackendOperationsManager.EHBBFMCILPC.RequestSaveSync("OnSaveSyncAnyResultFocusItem", "OnSaveSyncAnyResultFocusItem");
				SaveSlotsItem.slotDeleted = false;
				SaveSlotsItem.slotEdited = false;
				SaveSlotsItem.slotChanged = false;
				SaveSlotsItem.slotDuplicated = false;
			}
			this.PMOFGOJCBBA();
		}
		this.closeButton.interactable = true;
	}

	// Token: 0x06000D95 RID: 3477 RVA: 0x00061C68 File Offset: 0x0005FE68
	public void OnFavoritesDeactivate()
	{
		this.favoritesActiveAnim.SetActive(false);
		this.EOMMOLEBPLE(false);
		if (AKLFPGMDKLA.EHBBFMCILPC.GJBDBONJCDL(this.currentAnthologyIndex) != null)
		{
			AKLFPGMDKLA.EHBBFMCILPC.GJBDBONJCDL(this.currentAnthologyIndex).EHGPKIGKPLI = 0;
		}
	}

	// Token: 0x06000D96 RID: 3478 RVA: 0x00061CA5 File Offset: 0x0005FEA5
	public void OpenLounge()
	{
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnLobbyLoungeOpenRequested", 0f);
	}

	// Token: 0x06000D97 RID: 3479 RVA: 0x00061CBC File Offset: 0x0005FEBC
	private void ENKNAEJPDKF()
	{
		try
		{
			if (null == this.avatarButtonIcon && null != this.avatarButton)
			{
				Transform transform = this.avatarButton.transform.Find("Icon");
				if (null != transform)
				{
					this.avatarButtonIcon = transform.GetComponent<Image>();
				}
			}
			if (null == this.avatarButtonIcon)
			{
				DPGJIJGOCIC.ADFCDFHBDAF("FocusItem.UpdateAvatarButtonIcon(): avatarButtonIcon not wired and no \"Icon\" child under avatarButton - the lounge glyph cannot be shown");
				this.GNLNJKKDCIK = false;
			}
			else
			{
				RectTransform component = this.avatarButtonIcon.GetComponent<RectTransform>();
				if (!this.NKNJKFKMFOO)
				{
					this.KIDHIOADHHJ = this.avatarButtonIcon.sprite;
					this.CNOAKJODOEO = component.sizeDelta;
					this.PHDBJACBPGC = component.anchoredPosition;
					this.NKNJKFKMFOO = true;
				}
				bool flag = this.LoungeAvailableForFocusedAnthology();
				if (flag)
				{
					Sprite sprite = FocusItem.MFLNJFCDGMN("focusavatarloungeicon");
					if (null == sprite)
					{
						DPGJIJGOCIC.ADFCDFHBDAF("FocusItem.UpdateAvatarButtonIcon(): lounge glyph resource missing - focusavatarloungeicon");
						flag = false;
					}
					else
					{
						this.avatarButtonIcon.sprite = sprite;
						component.sizeDelta = this.avatarButton.GetComponent<RectTransform>().sizeDelta;
						component.anchoredPosition = Vector2.zero;
					}
				}
				if (!flag)
				{
					Sprite sprite2 = null;
					if (null != this.KIDHIOADHHJ && this.KIDHIOADHHJ.name.Contains("@"))
					{
						sprite2 = FocusItem.MFLNJFCDGMN(this.KIDHIOADHHJ.name.Split('@', StringSplitOptions.None)[0]);
					}
					this.avatarButtonIcon.sprite = ((null != sprite2) ? sprite2 : this.KIDHIOADHHJ);
					component.sizeDelta = this.CNOAKJODOEO;
					component.anchoredPosition = this.PHDBJACBPGC;
				}
				this.GNLNJKKDCIK = flag;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			this.GNLNJKKDCIK = false;
		}
	}

	// Token: 0x06000D98 RID: 3480 RVA: 0x00061B51 File Offset: 0x0005FD51
	public void HFDMMDEOLMF()
	{
		if (!this.miniLoadingAnimation.activeSelf)
		{
			this.miniLoadingAnimation.SetActive(true);
		}
	}

	// Token: 0x06000D99 RID: 3481 RVA: 0x00061E84 File Offset: 0x00060084
	private void KIECJHFKPJH()
	{
		CommonUserInterface.EHBBFMCILPC.MCJIGJMFBMI();
	}

	// Token: 0x06000D9A RID: 3482 RVA: 0x0006108F File Offset: 0x0005F28F
	private void OnDestroy()
	{
		if (this.thumbnail.gameObject.GetComponent<ImageFrameAnimation>() != null)
		{
			this.thumbnail.GetComponent<ImageFrameAnimation>().framesSD = null;
		}
	}

	// Token: 0x06000D9B RID: 3483 RVA: 0x00061E90 File Offset: 0x00060090
	private void PMOFGOJCBBA()
	{
		try
		{
			this.saveSlotsButtonExpiredExclamation.SetActive(this.LNKEFNINAFJ(AKLFPGMDKLA.EHBBFMCILPC.GJBDBONJCDL(this.currentAnthologyIndex)));
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000D9C RID: 3484 RVA: 0x00061ED8 File Offset: 0x000600D8
	private void BNBEIJBGBLA()
	{
		Canvas.ForceUpdateCanvases();
		try
		{
			if (this.description.text.Length > 0 && this.description.textInfo != null)
			{
				int characterCount = this.description.textInfo.characterCount;
				string text = this.description.text;
				int length = this.description.text.Length;
				string text2 = "...";
				if (length > characterCount)
				{
					text = text.Remove(characterCount - text2.Length);
					int num = text2.Length + 1;
					while (char.IsPunctuation(text[characterCount - num]) || char.IsWhiteSpace(text[characterCount - num]))
					{
						text = text.Remove(characterCount - num);
						num++;
					}
					text += text2;
					this.description.text = text;
					this.description.SetText(text, true);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000D9D RID: 3485 RVA: 0x00061FC8 File Offset: 0x000601C8
	private bool LNKEFNINAFJ(EIOPLEFLLIM LNFEBCFCBHG)
	{
		if (LNFEBCFCBHG == null)
		{
			return false;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.NCPPKEGJPKC())
		{
			return false;
		}
		if (ODLJHDIGLGO.BCGIONNIFIA(KHBLFKIDHPH.goldGamePass) == null && !AKLFPGMDKLA.EHBBFMCILPC.IKHJPEIPEGE(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG(1), true))
		{
			return false;
		}
		int num = GKJPOGNFKNK.BKBCNMEHGFA(LNFEBCFCBHG.GGICIBLJIKI);
		if (num < 0)
		{
			return false;
		}
		int num2 = KDCJJBLGCBH.EHBBFMCILPC.PFPMHHCGPJG();
		while (num2 < KDCJJBLGCBH.EHBBFMCILPC.NNPAJKNNFCP() && num2 < 10)
		{
			if (num2 != LNFEBCFCBHG.ILOKBAPEJPK)
			{
				PLFDAJJHMKO plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.PKNIPLDMJGG(num, num2);
				if (plfdajjhmko != null && !plfdajjhmko.DHONIOBOLEL.JBDPAJMOEGA())
				{
					return true;
				}
			}
			num2++;
		}
		return false;
	}

	// Token: 0x06000D9E RID: 3486 RVA: 0x00062068 File Offset: 0x00060268
	private void Start()
	{
		this.PFEEFOKHKMP = base.transform.localScale;
		try
		{
			this.KLFEKJICBKK = this.logo.rectTransform.anchoredPosition;
		}
		catch (Exception aklgbjkdomm)
		{
			this.KLFEKJICBKK = new Vector3(0f, 0f, 0f);
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000D9F RID: 3487 RVA: 0x000620D4 File Offset: 0x000602D4
	private void OnEnable()
	{
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnSaveSyncAnyResultFocusItem", new UnityAction(this.HPJNNEIGLBO));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnSaveSlotsItemClose", new UnityAction(this.GMKELJMLKHD));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnChapterSnapshotsItemClose", new UnityAction(this.BAMHACBFGDK));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnNeedToActivateFocusItemCloseButton", new UnityAction(this.AJPJPBOLOLJ));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnNeedToDeactivateFocusItemCloseButton", new UnityAction(this.OJAICJOANNG));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnChapterSnapshotsBackendFetchSuccess", new UnityAction(this.CGGOJEPOOON));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnChapterSnapshotsBackendFetchException", new UnityAction(this.DBFLCFHHOFN));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnCaptersSnapshotsGamePassSubscribePositive", new UnityAction(this.GCNNLOLBPAE));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnCaptersSnapshotsGamePassSubscribeNegative", new UnityAction(this.AMMCOLDGOAK));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnSaveSlotsExpiredPassSubscribePositive", new UnityAction(this.OAFGCDEKBCK));
		this.statsParent.SetActive(false);
		if (null != this.genresObject)
		{
			this.genresObject.SetActive(false);
			this.genresObjectSpace.SetActive(false);
		}
		this.focusFadeVerticalLayoutGroup.padding.top = (int)(-20f * (1f - KHPGPLAMAIN.PPCIFCGLKJD(0f, 1.5f)));
		if (null != this.innerShadow)
		{
			this.innerShadow.GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
		}
	}

	// Token: 0x06000DA0 RID: 3488 RVA: 0x00062284 File Offset: 0x00060484
	public void CloseFocus()
	{
		this.uiHeader.SetParent(this.uiHeaderParent);
		this.settingsButtonHeader.SetActive(true);
		base.transform.parent.GetComponent<CanvasGroup>().alpha = 0f;
		base.transform.parent.gameObject.SetActive(false);
		base.GetComponent<RectTransform>().localScale = this.PFEEFOKHKMP;
		this.playingIconTag.gameObject.SetActive(false);
		this.tagHint.gameObject.SetActive(false);
		this.tagTimerEnd.gameObject.SetActive(false);
		this.GMLKPEHPCHB = false;
		FocusItem.isFocusOpened = false;
	}

	// Token: 0x06000DA1 RID: 3489 RVA: 0x0006232F File Offset: 0x0006052F
	public bool AvatarButtonOffersLounge()
	{
		return this.GNLNJKKDCIK && this.LoungeAvailableForFocusedAnthology();
	}

	// Token: 0x06000DA2 RID: 3490 RVA: 0x00062344 File Offset: 0x00060544
	public void UpdateCardContent(OKAFAHMOFII FNJJIPNFCMK, AssetLiveEventContent NBKNFJNIDKC)
	{
		this.favoritesActiveAnim.SetActive(false);
		this.favoritesInactive.SetActive(false);
		this.favoritesActive.SetActive(false);
		this.FNJJIPNFCMK = FNJJIPNFCMK;
		this.OJOONOFEIMG = true;
		this.LGAGMPFBPMP(this.OJOONOFEIMG, null, null, 0, 0);
		this.uiHeader.SetParent(this.uiHeaderFocus);
		this.settingsButtonHeader.SetActive(false);
		this.thumbnail.sprite = NBKNFJNIDKC.thumbnailLargeFramesBack[0];
		if (this.thumbnail.gameObject.GetComponent<ImageFrameAnimation>() == null)
		{
			this.thumbnail.gameObject.AddComponent<ImageFrameAnimation>();
			this.thumbnail.GetComponent<ImageFrameAnimation>().frameChangeInterval = NBKNFJNIDKC.frameChangeInterval;
			this.thumbnail.GetComponent<ImageFrameAnimation>().framesSD = NBKNFJNIDKC.thumbnailLargeFramesBack.ToArray();
			this.thumbnail.GetComponent<ImageFrameAnimation>().isLooped = !NBKNFJNIDKC.disableBackAnimationLoop;
		}
		else
		{
			this.thumbnail.GetComponent<ImageFrameAnimation>().frameChangeInterval = NBKNFJNIDKC.frameChangeInterval;
			this.thumbnail.GetComponent<ImageFrameAnimation>().framesSD = NBKNFJNIDKC.thumbnailLargeFramesBack.ToArray();
			this.thumbnail.GetComponent<ImageFrameAnimation>().isLooped = !NBKNFJNIDKC.disableBackAnimationLoop;
		}
		if (null == NBKNFJNIDKC.logoBackOptional)
		{
			this.logo.sprite = NBKNFJNIDKC.logo;
			this.logo.SetNativeSize();
			int num = 0;
			int num2 = 0;
			if (NBKNFJNIDKC.customLanguageLogoOffset != null)
			{
				for (int i = 0; i < NBKNFJNIDKC.customLanguageLogoOffset.Count; i++)
				{
					if (NBKNFJNIDKC.customLanguageLogoOffset[i].language.Equals(LanguageManager.EHBBFMCILPC.GetSelectedLanguage().ToString()))
					{
						num = NBKNFJNIDKC.customLanguageLogoOffset[i].logoOffsetX;
						num2 = NBKNFJNIDKC.customLanguageLogoOffset[i].logoOffsetY;
						break;
					}
				}
			}
			this.logo.rectTransform.anchoredPosition = new Vector2((float)(NBKNFJNIDKC.logoOffsetX + num), (float)(NBKNFJNIDKC.logoOffsetY + num2));
			this.logo.rectTransform.localScale = new Vector3(NBKNFJNIDKC.logoScaleFactor, NBKNFJNIDKC.logoScaleFactor, NBKNFJNIDKC.logoScaleFactor) * 1.08f;
		}
		else
		{
			this.logo.sprite = NBKNFJNIDKC.logoBackOptional;
			this.logo.SetNativeSize();
			this.logo.rectTransform.anchoredPosition = new Vector2((float)NBKNFJNIDKC.logoBackOptionalOffsetX, (float)NBKNFJNIDKC.logoBackOptionalOffsetY);
			this.logo.rectTransform.localScale = new Vector3(NBKNFJNIDKC.logoBackOptionalScaleFactor, NBKNFJNIDKC.logoBackOptionalScaleFactor, NBKNFJNIDKC.logoBackOptionalScaleFactor) * 1.08f;
		}
		this.cardDescription.color = NBKNFJNIDKC.textColor;
		if (null != this.innerShadow)
		{
			this.innerShadow.GetComponent<Image>().color = new Color(1f, 1f, 1f, NBKNFJNIDKC.innerShadowBackAlpha);
		}
		this.OnLanguageChange();
		switch (FNJJIPNFCMK.KONDFFEKAND)
		{
		case EGMCEPOABBF.liveEventMessage:
			this.HJBMNLBOEAL = true;
			return;
		case EGMCEPOABBF.liveEventFreeTea:
			this.HJBMNLBOEAL = false;
			return;
		case EGMCEPOABBF.liveEventFreeDiamonds:
			this.HJBMNLBOEAL = false;
			return;
		case EGMCEPOABBF.liveEventFreeStory:
			this.HJBMNLBOEAL = false;
			return;
		case EGMCEPOABBF.liveEventBonusStory:
			this.HJBMNLBOEAL = false;
			return;
		case EGMCEPOABBF.liveEventFreeAvatar:
			this.HJBMNLBOEAL = false;
			return;
		default:
			return;
		}
	}

	// Token: 0x06000DA3 RID: 3491 RVA: 0x0006269C File Offset: 0x0006089C
	private void EHBJOHMNJFH()
	{
		AOBJLALDBAA.KKPFOJMAONG().GNBGEMMDGOJ("upgcds", new UnityAction(this.HPJNNEIGLBO));
		AOBJLALDBAA.BIAEAOMHBMM().EFKNEJFLGED("", new UnityAction(this.GMKELJMLKHD));
		AOBJLALDBAA.KKPFOJMAONG().BADOPKAOCPE("$ENVFADEDST", new UnityAction(this.BAMHACBFGDK));
		AOBJLALDBAA.EHBBFMCILPC.BADOPKAOCPE("SocialStatsUserPublicProfile.modified = true, RenameCutscene()", new UnityAction(this.AJPJPBOLOLJ));
		AOBJLALDBAA.EHBBFMCILPC.PEFKJOKLEDL("OnStoryChoiceClick", new UnityAction(this.CMHOMCLCJGI));
		AOBJLALDBAA.AGANFKKBPFO().EFKNEJFLGED("sfxchatnotification", new UnityAction(this.CGGOJEPOOON));
		AOBJLALDBAA.BIAEAOMHBMM().FNMOFCMDFJP("apks", new UnityAction(this.DBFLCFHHOFN));
		AOBJLALDBAA.FILDBDMENPG().MFIMALJPCDP("continue", new UnityAction(this.GCNNLOLBPAE));
		AOBJLALDBAA.NMGMNAKLLMI().FNMOFCMDFJP("lititle", new UnityAction(this.AMMCOLDGOAK));
		AOBJLALDBAA.NMGMNAKLLMI().GNBGEMMDGOJ("XXX", new UnityAction(this.OAFGCDEKBCK));
		this.statsParent.SetActive(false);
		if (null != this.genresObject)
		{
			this.genresObject.SetActive(true);
			this.genresObjectSpace.SetActive(false);
		}
		this.focusFadeVerticalLayoutGroup.padding.top = (int)(203f * (220f - KHPGPLAMAIN.KDGFOIAHFMP(1218f, 547f)));
		if (null != this.innerShadow)
		{
			this.innerShadow.GetComponent<Image>().color = new Color(1574f, 600f, 818f, 475f);
		}
	}

	// Token: 0x06000DA4 RID: 3492 RVA: 0x0006284C File Offset: 0x00060A4C
	private void OMKAIJIGHLJ()
	{
		try
		{
			this.closeButton.interactable = true;
			this.chapterSnapshotsFade.SetActive(true);
			this.chapterSnapshotsItem.FPNPLEBJLOO(this.currentAnthologyIndex);
			base.StartCoroutine(this.FINPCOMDIFD(this.chapterSnapshotsFade, this.chapterSnapshotsItem.gameObject, 686f, false));
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06000DA5 RID: 3493 RVA: 0x000628C0 File Offset: 0x00060AC0
	private void OnDisable()
	{
		this.JPIBLAOGEIJ = 0;
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnSaveSyncAnyResultFocusItem", new UnityAction(this.HPJNNEIGLBO));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnSaveSlotsItemClose", new UnityAction(this.GMKELJMLKHD));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnChapterSnapshotsItemClose", new UnityAction(this.BAMHACBFGDK));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnNeedToActivateFocusItemCloseButton", new UnityAction(this.AJPJPBOLOLJ));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnNeedToDeactivateFocusItemCloseButton", new UnityAction(this.OJAICJOANNG));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnChapterSnapshotsBackendFetchSuccess", new UnityAction(this.CGGOJEPOOON));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnChapterSnapshotsBackendFetchException", new UnityAction(this.DBFLCFHHOFN));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnCaptersSnapshotsGamePassSubscribePositive", new UnityAction(this.GCNNLOLBPAE));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnCaptersSnapshotsGamePassSubscribeNegative", new UnityAction(this.AMMCOLDGOAK));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnSaveSlotsExpiredPassSubscribePositive", new UnityAction(this.OAFGCDEKBCK));
		this.statsParent.SetActive(false);
		if (null != this.genresObject)
		{
			this.genresObject.SetActive(false);
			this.genresObjectSpace.SetActive(false);
		}
		this.tagEpisodeCount.SetActive(false);
	}

	// Token: 0x06000DA6 RID: 3494 RVA: 0x00062A20 File Offset: 0x00060C20
	public void OnLanguageChange()
	{
		if (this.OJOONOFEIMG)
		{
			this.cardDescription.SetText(GKJPOGNFKNK.DNILNCLIHAP("liveeventcontent" + this.FNJJIPNFCMK.MHLOFNCHELC.ToString(), "liveeventsdesc", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), true);
			if (this.GMLKPEHPCHB)
			{
				this.tagTimerDynamicText.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("eventended"), true);
				return;
			}
		}
		else
		{
			this.playingIconTag.gameObject.SetActive(false);
			if (this.NDIPGHMNCCF != NDHKFLHAFNA.hintInDevelopment && this.NDIPGHMNCCF != NDHKFLHAFNA.hintOnHiatus && this.NDIPGHMNCCF != NDHKFLHAFNA.hintDiscontinued && this.NDIPGHMNCCF != NDHKFLHAFNA.hintCompleted && this.NDIPGHMNCCF != NDHKFLHAFNA.hintPlayAgain)
			{
				this.playingIconTag.gameObject.SetActive(true);
				this.itemTagText.text = this.BIBKFNMPHIK.ToString() + "%";
				this.itemTagText.SetText(this.BIBKFNMPHIK.ToString() + "%", true);
			}
			else
			{
				this.itemTagText.text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(this.NDIPGHMNCCF.ToString());
				this.itemTagText.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(this.NDIPGHMNCCF.ToString()), true);
				if (this.NDIPGHMNCCF == NDHKFLHAFNA.hintPlayAgain)
				{
					this.itemTagText.text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(NDHKFLHAFNA.hintCompleted.ToString());
					this.itemTagText.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(NDHKFLHAFNA.hintCompleted.ToString()), true);
				}
			}
			if (this.LMAPHMHIMKI)
			{
				this.episode.gameObject.SetActive(false);
				AssetStoryHeader assetStoryHeader = GKJPOGNFKNK.CDCEFHLNNEC(this.DCHHFIEFEBK);
				if (assetStoryHeader.doNotShowStats)
				{
					this.season.gameObject.SetActive(true);
				}
				else
				{
					this.season.gameObject.SetActive(false);
				}
				if (this.DGODOICGJJC == 1)
				{
					this.description.text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("seasoncompletedescspecialepisode");
					this.description.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("seasoncompletedescspecialepisode"), true);
					this.season.text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(assetStoryHeader.customEpisodeAndSeasonInfoStringId);
					this.season.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(assetStoryHeader.customEpisodeAndSeasonInfoStringId), true);
				}
				else
				{
					AssetAnthology assetAnthology = GKJPOGNFKNK.LDFIAOCJEOJ(this.currentAnthologyIndex);
					bool flag = false;
					if (null != assetAnthology && assetAnthology.header.maxStories == 1)
					{
						flag = true;
					}
					if (flag)
					{
						this.description.text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("volcompletedesc");
						this.description.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("volcompletedesc"), true);
					}
					else
					{
						this.description.text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("seasoncompletedesc");
						this.description.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("seasoncompletedesc"), true);
					}
					this.season.text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("anthologycompletetitle");
					this.season.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("anthologycompletetitle"), true);
				}
			}
			else
			{
				this.episode.gameObject.SetActive(true);
				this.season.gameObject.SetActive(true);
				this.episode.text = "";
				this.episode.SetText("", true);
				AssetStoryHeader assetStoryHeader2 = GKJPOGNFKNK.CDCEFHLNNEC(this.DCHHFIEFEBK);
				AssetAnthology assetAnthology2 = GKJPOGNFKNK.LDFIAOCJEOJ(this.currentAnthologyIndex);
				if (null != assetStoryHeader2 && assetStoryHeader2.customEpisodeAndSeasonInfoStringId != null && assetStoryHeader2.customEpisodeAndSeasonInfoStringId.Length > 0)
				{
					this.season.text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(assetStoryHeader2.customEpisodeAndSeasonInfoStringId);
					this.season.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(assetStoryHeader2.customEpisodeAndSeasonInfoStringId), true);
				}
				else
				{
					bool flag2 = false;
					if (null != assetAnthology2 && assetAnthology2.header.maxStories == 1)
					{
						flag2 = true;
					}
					if (flag2)
					{
						this.season.text = string.Concat(new string[]
						{
							CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("episode"),
							" ",
							(this.MICMIKNOOEC + 1).ToString(),
							"/",
							this.JKEOGHJHNHP.ToString()
						});
						this.season.SetText(string.Concat(new string[]
						{
							CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("episode"),
							" ",
							(this.MICMIKNOOEC + 1).ToString(),
							"/",
							this.JKEOGHJHNHP.ToString()
						}), true);
					}
					else
					{
						this.season.text = string.Concat(new string[]
						{
							CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("episode"),
							" ",
							(this.MICMIKNOOEC + 1).ToString(),
							"/",
							this.JKEOGHJHNHP.ToString(),
							" (",
							CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("seasonshort"),
							" ",
							(this.MIBPOIDDBAD + 1).ToString(),
							")"
						});
						this.season.SetText(string.Concat(new string[]
						{
							CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("episode"),
							" ",
							(this.MICMIKNOOEC + 1).ToString(),
							"/",
							this.JKEOGHJHNHP.ToString(),
							" (",
							CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("seasonshort"),
							" ",
							(this.MIBPOIDDBAD + 1).ToString(),
							")"
						}), true);
					}
				}
				string text;
				if (this.MICMIKNOOEC == 0 && this.MIBPOIDDBAD == 0)
				{
					text = GKJPOGNFKNK.DNILNCLIHAP("anthology" + this.currentAnthologyIndex.ToString(), "anthologiesdesc", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
				}
				else
				{
					text = GKJPOGNFKNK.HPAHOEOKEBB("story" + this.DCHHFIEFEBK.ToString() + "chapter" + this.MICMIKNOOEC.ToString(), "chaptersdesc" + this.currentAnthologyIndex.ToString(), LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
				}
				if (text != null && !text.EndsWith("_not_found"))
				{
					this.description.text = text;
					this.description.SetText(text, true);
				}
				if (null != assetAnthology2 && null != this.genresObject)
				{
					IJLJDFKJIJM ijljdfkjijm = HKLPEDKJGFC.BBEPEBHNNGE(assetAnthology2.header.index);
					bool flag3 = false;
					string[] agpmobfclfk = null;
					if (SceneLobbyManager2.TryGetFocusCardWords(assetAnthology2.header.index, out agpmobfclfk))
					{
						string text2 = SceneLobbyManager2.BuildSharedPitchLine(agpmobfclfk, (ijljdfkjijm == null) ? "" : ijljdfkjijm.DHBGMKIFBMB);
						this.genresText.text = text2;
						this.genresText.SetText(text2, true);
						flag3 = true;
					}
					string hhnggfljaij = null;
					string fbdpelcokop = null;
					if (!flag3 && SceneLobbyManager2.TryGetSharedCardPitch(assetAnthology2.header.index, out hhnggfljaij, out fbdpelcokop))
					{
						string text3 = SceneLobbyManager2.BuildSharedPitchLine(hhnggfljaij, fbdpelcokop, (ijljdfkjijm == null) ? "" : ijljdfkjijm.DHBGMKIFBMB);
						this.genresText.text = text3;
						this.genresText.SetText(text3, true);
						flag3 = true;
					}
					if (!flag3 && ijljdfkjijm != null)
					{
						string text4 = "";
						if (ijljdfkjijm.DHBGMKIFBMB.Length > 0)
						{
							text4 = ijljdfkjijm.DHBGMKIFBMB;
						}
						List<string> list = new List<string>();
						list.Add(ijljdfkjijm.MGDAFCPCOFH.ToString());
						list.Add(ijljdfkjijm.HLEHGFIIEJN.ToString());
						list.Add(ijljdfkjijm.BFJKEJLJAIH.ToString());
						list.Remove(JBBNEEHANHL.filterNone.ToString());
						list.Remove(JBBNEEHANHL.filterNone.ToString());
						list.Remove(JBBNEEHANHL.filterNone.ToString());
						if (list.Count == 3)
						{
							list.RemoveAt(2);
						}
						string text5 = "";
						for (int i = 0; i < list.Count; i++)
						{
							text5 += CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(list[i]);
							if (i != list.Count - 1)
							{
								text5 += " • ";
							}
						}
						if (text4.Length > 0)
						{
							text5 = text5 + " • " + text4;
						}
						this.genresText.text = text5;
						this.genresText.SetText(text5, true);
					}
				}
			}
			this.BNBEIJBGBLA();
		}
	}

	// Token: 0x06000DA7 RID: 3495 RVA: 0x00063348 File Offset: 0x00061548
	private static Sprite MFLNJFCDGMN(string EFHBINLOJOI)
	{
		Sprite sprite = null;
		if (NBDLBFJOEGN.PBLDJNHHEPL())
		{
			sprite = Resources.Load<Sprite>(EFHBINLOJOI + "@HD");
		}
		if (null == sprite)
		{
			sprite = Resources.Load<Sprite>(EFHBINLOJOI + "@SD");
		}
		return sprite;
	}

	// Token: 0x06000DA8 RID: 3496 RVA: 0x0006338A File Offset: 0x0006158A
	private void EOMMOLEBPLE(bool DLMCOJMGDPH)
	{
		if (DLMCOJMGDPH)
		{
			this.favoritesInactive.SetActive(false);
			this.favoritesActive.SetActive(true);
			return;
		}
		this.favoritesInactive.SetActive(true);
		this.favoritesActive.SetActive(false);
	}

	// Token: 0x06000DA9 RID: 3497 RVA: 0x000633C0 File Offset: 0x000615C0
	private void HPJNNEIGLBO()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
	}

	// Token: 0x06000DAA RID: 3498 RVA: 0x000633CC File Offset: 0x000615CC
	public void OnFavoritesActivate()
	{
		this.favoritesActiveAnim.SetActive(true);
		this.EOMMOLEBPLE(true);
		if (AKLFPGMDKLA.EHBBFMCILPC.GJBDBONJCDL(this.currentAnthologyIndex) != null)
		{
			AKLFPGMDKLA.EHBBFMCILPC.GJBDBONJCDL(this.currentAnthologyIndex).EHGPKIGKPLI = 1;
			if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(7))
			{
				AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(7);
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("tutfavoritesbody"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("continue"), DFGILFBGPLN.popupTools, 0.5f, 28);
			}
		}
	}

	// Token: 0x06000DAB RID: 3499 RVA: 0x0006346D File Offset: 0x0006166D
	private void HNDBBKMAFDB()
	{
		CommonUserInterface.IKNOFBFMPGA().MCJIGJMFBMI();
		this.OMKAIJIGHLJ();
	}

	// Token: 0x06000DAC RID: 3500 RVA: 0x00063480 File Offset: 0x00061680
	private void CICGEOGMDNL()
	{
		Canvas.ForceUpdateCanvases();
		try
		{
			if (this.description.text.Length > 0 && this.description.textInfo != null)
			{
				int characterCount = this.description.textInfo.characterCount;
				string text = this.description.text;
				int length = this.description.text.Length;
				string text2 = ":";
				if (length > characterCount)
				{
					text = text.Remove(characterCount - text2.Length);
					int num = text2.Length + 0;
					while (char.IsPunctuation(text[characterCount - num]) || char.IsWhiteSpace(text[characterCount - num]))
					{
						text = text.Remove(characterCount - num);
						num += 0;
					}
					text += text2;
					this.description.text = text;
					this.description.SetText(text, false);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06000DAD RID: 3501 RVA: 0x00063570 File Offset: 0x00061770
	private void DBFLCFHHOFN()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnRestartChapterUpsellGetPassNegative", 0.1f);
	}

	// Token: 0x06000DAE RID: 3502 RVA: 0x00063590 File Offset: 0x00061790
	private void OAFGCDEKBCK()
	{
		this.closeButton.interactable = true;
		this.saveSlotsItem.CloseFocus();
		this.GMKELJMLKHD();
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnRestartChapterUpsellGetPassPositive", 0.1f);
		this.CloseFocus();
	}

	// Token: 0x06000DAF RID: 3503 RVA: 0x000635CC File Offset: 0x000617CC
	public void NHKALIJEEIL(bool JJAKPMDJNIA)
	{
		if (JJAKPMDJNIA)
		{
			this.OMKAIJIGHLJ();
			return;
		}
		EIOPLEFLLIM eioplefllim = AKLFPGMDKLA.EHBBFMCILPC.AMAMNOFLPGM(this.currentAnthologyIndex);
		bool flag = false;
		if (eioplefllim != null && eioplefllim.EPEOKHOBOBL[eioplefllim.ILOKBAPEJPK] == 0)
		{
			AssetAnthologyHeader assetAnthologyHeader = GKJPOGNFKNK.BDEJIINKEHH(this.currentAnthologyIndex);
			JSONArray jsonarray = new JSONArray();
			for (int i = 1; i < assetAnthologyHeader.maxStories; i++)
			{
				if (i <= eioplefllim.EGHHCFFLPCP(-1) && i < assetAnthologyHeader.availableStories.Count)
				{
					PLFDAJJHMKO plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.PKNIPLDMJGG(assetAnthologyHeader.availableStories[i], -1);
					if (plfdajjhmko != null)
					{
						for (int j = 1; j < plfdajjhmko.KIHACLLJMDH.Count; j++)
						{
							jsonarray.Add(i * -18 + plfdajjhmko.KIHACLLJMDH[j]);
						}
					}
				}
			}
			if (jsonarray.Count > 0)
			{
				flag = false;
				CommonUserInterface.EHBBFMCILPC.KLEJAGLPCNM(CCOJBMMKNAP.KFDLFGHBPLP().HIPJILDCHJC("loungeplayfirst"), (byte)-128);
				BackendOperationsManager.EHBBFMCILPC.RequestGetChapterSnapshots(this.currentAnthologyIndex, eioplefllim.ILOKBAPEJPK, jsonarray, "rsl", "mussplash");
			}
			else
			{
				eioplefllim.EPEOKHOBOBL[eioplefllim.ILOKBAPEJPK] = 1;
				this.OMKAIJIGHLJ();
			}
		}
		if (!flag)
		{
			this.DECFOPMOPHA();
		}
	}

	// Token: 0x06000DB0 RID: 3504 RVA: 0x0006370F File Offset: 0x0006190F
	public void BDPJJLILHMB()
	{
		if (!this.miniLoadingAnimation.activeSelf)
		{
			this.miniLoadingAnimation.SetActive(false);
		}
	}

	// Token: 0x06000DB1 RID: 3505 RVA: 0x0006372C File Offset: 0x0006192C
	public void UpdateContent(AssetAnthologyPreview2 NBKNFJNIDKC, PLFDAJJHMKO GKHNIMJJLJL, NDHKFLHAFNA NDIPGHMNCCF, Sprite CPPJFAJHMHL, Sprite IPPMDFBAOEB, Sprite KOFILDLJHCL, Sprite ODCGFKIMELE, int MICMIKNOOEC, int MIBPOIDDBAD, int BIBKFNMPHIK, int DCHHFIEFEBK, int AHFGCHIBCID, bool LMAPHMHIMKI, int LGIECOAIEFN, int DGODOICGJJC, JBBNEEHANHL GLOCCAIDHJC)
	{
		this.NPMBHDLIDFC = NBKNFJNIDKC;
		if (null != this.innerShadow)
		{
			this.innerShadow.GetComponent<Image>().color = new Color(1f, 1f, 1f, NBKNFJNIDKC.innerShadowBackAlpha);
		}
		this.AMKCLHLIIMN = NBKNFJNIDKC.index;
		this.OJOONOFEIMG = false;
		this.tagHint.gameObject.SetActive(true);
		EIOPLEFLLIM kfikfodiccb = AKLFPGMDKLA.EHBBFMCILPC.LMGMHHLLOFN(AHFGCHIBCID);
		this.LGAGMPFBPMP(this.OJOONOFEIMG, GKHNIMJJLJL, kfikfodiccb, MIBPOIDDBAD, MICMIKNOOEC);
		this.uiHeader.SetParent(this.uiHeaderFocus);
		this.settingsButtonHeader.SetActive(false);
		this.filterIcon.sprite = this.filterSprites[(int)GLOCCAIDHJC];
		this.filterIcon.SetNativeSize();
		AssetStoryHeader assetStoryHeader = GKJPOGNFKNK.CDCEFHLNNEC(DCHHFIEFEBK);
		this.JKEOGHJHNHP = assetStoryHeader.totalChaptersCount;
		if (CommonUserInterface.EHBBFMCILPC.GetStoryRestartPopup().RestartOptionsAvailable(assetStoryHeader, GKHNIMJJLJL, MICMIKNOOEC, assetStoryHeader.index))
		{
			this.restartButton.SetActive(true);
		}
		else
		{
			this.restartButton.SetActive(false);
		}
		this.itemTagIcon.gameObject.SetActive(true);
		this.itemTagText.gameObject.SetActive(true);
		this.NDIPGHMNCCF = NDIPGHMNCCF;
		if (NDIPGHMNCCF != NDHKFLHAFNA.hintInDevelopment)
		{
			if (NDIPGHMNCCF != NDHKFLHAFNA.hintCompleted)
			{
				switch (NDIPGHMNCCF)
				{
				case NDHKFLHAFNA.hintPlayAgain:
					this.itemTagIcon.sprite = KOFILDLJHCL;
					goto IL_1D8;
				case NDHKFLHAFNA.hintOnHiatus:
					this.itemTagIcon.sprite = ODCGFKIMELE;
					goto IL_1D8;
				case NDHKFLHAFNA.hintDiscontinued:
					this.itemTagIcon.sprite = ODCGFKIMELE;
					goto IL_1D8;
				}
				this.itemTagIcon.sprite = CPPJFAJHMHL;
				if (assetStoryHeader.totalChaptersCount == 1)
				{
					this.itemTagIcon.gameObject.SetActive(false);
					this.itemTagText.gameObject.SetActive(false);
				}
			}
			else
			{
				this.itemTagIcon.sprite = KOFILDLJHCL;
			}
		}
		else
		{
			this.itemTagIcon.sprite = IPPMDFBAOEB;
		}
		IL_1D8:
		this.MICMIKNOOEC = MICMIKNOOEC;
		this.MIBPOIDDBAD = MIBPOIDDBAD;
		this.BIBKFNMPHIK = BIBKFNMPHIK;
		if (this.BIBKFNMPHIK == 100)
		{
			this.BIBKFNMPHIK = 99;
		}
		this.DCHHFIEFEBK = DCHHFIEFEBK;
		this.currentAnthologyIndex = AHFGCHIBCID;
		this.LMAPHMHIMKI = LMAPHMHIMKI;
		this.LGIECOAIEFN = LGIECOAIEFN;
		this.DGODOICGJJC = DGODOICGJJC;
		this.favoritesActiveAnim.SetActive(false);
		if (AKLFPGMDKLA.EHBBFMCILPC.GJBDBONJCDL(AHFGCHIBCID) != null)
		{
			this.EOMMOLEBPLE(AKLFPGMDKLA.EHBBFMCILPC.GJBDBONJCDL(AHFGCHIBCID).EHGPKIGKPLI > 0);
			int num = AKLFPGMDKLA.EHBBFMCILPC.GJBDBONJCDL(AHFGCHIBCID).ILOKBAPEJPK + 1;
			this.saveSlotsButtonInfoText.text = (num.ToString() ?? "");
			this.saveSlotsButtonInfoText.SetText(num.ToString() ?? "", true);
			this.PMOFGOJCBBA();
		}
		else
		{
			this.EOMMOLEBPLE(false);
			try
			{
				this.saveSlotsButtonExpiredExclamation.SetActive(false);
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		this.thumbnail.sprite = NBKNFJNIDKC.CFHFGGICGIL()[0];
		if (this.thumbnail.gameObject.GetComponent<ImageFrameAnimation>() == null)
		{
			this.thumbnail.gameObject.AddComponent<ImageFrameAnimation>();
			this.thumbnail.GetComponent<ImageFrameAnimation>().frameChangeInterval = NBKNFJNIDKC.frameChangeInterval;
			this.thumbnail.GetComponent<ImageFrameAnimation>().framesSD = NBKNFJNIDKC.CFHFGGICGIL().ToArray();
		}
		else
		{
			this.thumbnail.GetComponent<ImageFrameAnimation>().frameChangeInterval = NBKNFJNIDKC.frameChangeInterval;
			this.thumbnail.GetComponent<ImageFrameAnimation>().framesSD = NBKNFJNIDKC.CFHFGGICGIL().ToArray();
		}
		if (NBKNFJNIDKC.pauseFrame >= 0)
		{
			this.thumbnail.GetComponent<ImageFrameAnimation>().pauseFrame = NBKNFJNIDKC.pauseFrame;
			this.thumbnail.GetComponent<ImageFrameAnimation>().pauseTime = NBKNFJNIDKC.pauseTime;
		}
		else
		{
			this.thumbnail.GetComponent<ImageFrameAnimation>().pauseFrame = -1;
			this.thumbnail.GetComponent<ImageFrameAnimation>().pauseTime = 0f;
		}
		this.thumbnail.GetComponent<ImageFrameAnimation>().reverseDirection = NBKNFJNIDKC.reverseDirection;
		this.logo.sprite = NBKNFJNIDKC.logo;
		this.logo.SetNativeSize();
		this.logo.rectTransform.anchoredPosition = new Vector2(this.KLFEKJICBKK.x + (float)NBKNFJNIDKC.logoOffsetX, (float)NBKNFJNIDKC.logoOffsetY);
		this.logo.rectTransform.localScale = new Vector3(NBKNFJNIDKC.logoScaleFactor, NBKNFJNIDKC.logoScaleFactor, NBKNFJNIDKC.logoScaleFactor) * 1.08f;
		this.OnLanguageChange();
		bool flag = assetStoryHeader.totalChaptersCount == 1 && assetStoryHeader.syncWithPrequel;
		if ((MICMIKNOOEC == 0 && MIBPOIDDBAD == 0 && !flag) || assetStoryHeader.doNotShowStats)
		{
			this.statsParent.SetActive(false);
			if (null != this.genresObject)
			{
				this.genresObject.SetActive(true);
				this.genresObjectSpace.SetActive(true);
			}
		}
		else
		{
			for (int i = 0; i < this.statIcons.Count; i++)
			{
				this.statIcons[i].gameObject.SetActive(false);
				this.textIcons[i].gameObject.SetActive(false);
			}
			if (NBKNFJNIDKC.statIcons.Count > 0)
			{
				this.statsParent.SetActive(true);
				if (null != this.genresObject)
				{
					this.genresObject.SetActive(false);
					this.genresObjectSpace.SetActive(false);
				}
				AssetAnthologyHeader assetAnthologyHeader = GKJPOGNFKNK.BDEJIINKEHH(AHFGCHIBCID);
				PLFDAJJHMKO plfdajjhmko = null;
				if (DCHHFIEFEBK % 5 != 0 && MICMIKNOOEC == 0)
				{
					plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.PKNIPLDMJGG(DCHHFIEFEBK - 1, -1);
				}
				int num2 = 0;
				int num3 = 0;
				for (int j = 0; j < NBKNFJNIDKC.statIcons.Count; j++)
				{
					if (j >= assetAnthologyHeader.inkStatVariablesMinStory.Count || j >= assetAnthologyHeader.inkStatVariablesMinChapter.Count || (DCHHFIEFEBK >= assetAnthologyHeader.inkStatVariablesMinStory[j] && (DCHHFIEFEBK != assetAnthologyHeader.inkStatVariablesMinStory[j] || GKHNIMJJLJL.DHONIOBOLEL.LKIKEHFANBO[0] >= assetAnthologyHeader.inkStatVariablesMinChapter[j])))
					{
						num3++;
					}
				}
				for (int k = 0; k < NBKNFJNIDKC.statIcons.Count; k++)
				{
					if (k < assetAnthologyHeader.inkStatVariablesMinStory.Count && k < assetAnthologyHeader.inkStatVariablesMinChapter.Count && (DCHHFIEFEBK < assetAnthologyHeader.inkStatVariablesMinStory[k] || (DCHHFIEFEBK == assetAnthologyHeader.inkStatVariablesMinStory[k] && GKHNIMJJLJL.DHONIOBOLEL.LKIKEHFANBO[0] < assetAnthologyHeader.inkStatVariablesMinChapter[k])))
					{
						this.statIcons[k].gameObject.SetActive(false);
					}
					else
					{
						this.statIcons[k].gameObject.SetActive(true);
						this.statIcons[k].sprite = NBKNFJNIDKC.statIcons[k];
						this.statIcons[k].SetNativeSize();
						this.statIcons[k].preserveAspect = true;
						this.textIcons[k].gameObject.SetActive(true);
						if (num3 == 6)
						{
							this.statIcons[k].gameObject.transform.localScale = new Vector3(0.9f, 0.9f, 0.9f);
							this.statsParentHorizontalLayout.spacing = 5f;
							this.textIcons[k].fontSize = 22f;
						}
						else if (num3 == 7)
						{
							this.statIcons[k].gameObject.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);
							this.statsParentHorizontalLayout.spacing = 2f;
							this.textIcons[k].fontSize = 20f;
						}
						else
						{
							this.statIcons[k].gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
							this.statsParentHorizontalLayout.spacing = 8f;
							this.textIcons[k].fontSize = 24f;
						}
						string text = assetAnthologyHeader.inkStatVariables[k];
						int num4 = 0;
						string text2;
						if (plfdajjhmko != null)
						{
							text2 = plfdajjhmko.NCAMFPGMCIG.MPMJOPGMNPB(ref text);
						}
						else
						{
							text2 = GKHNIMJJLJL.NCAMFPGMCIG.MPMJOPGMNPB(ref text);
						}
						if (text2 == null)
						{
							num4 = 0;
						}
						else
						{
							try
							{
								num4 = int.Parse(text2);
							}
							catch (Exception aklgbjkdomm2)
							{
								DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
							}
						}
						try
						{
							if (GKHNIMJJLJL.DHONIOBOLEL.OCNJEMGDOGL())
							{
								num4 += GKHNIMJJLJL.NCAMFPGMCIG.GAHPMLBCFJJ((CHEEGEJNIDB)k);
							}
						}
						catch (Exception aklgbjkdomm3)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
						}
						num2 += num4;
						this.textIcons[k].text = num4.ToString();
						this.textIcons[k].SetText(num4.ToString(), true);
					}
				}
				if (MICMIKNOOEC == 0 && MIBPOIDDBAD == 0 && flag && (num2 == 0 || GKHNIMJJLJL.DHONIOBOLEL.JBDPAJMOEGA()))
				{
					this.statsParent.SetActive(false);
					if (null != this.genresObject)
					{
						this.genresObject.SetActive(true);
						this.genresObjectSpace.SetActive(true);
					}
				}
			}
		}
		this.tagEpisodeCountText.text = LGIECOAIEFN.ToString() + "/" + DGODOICGJJC.ToString();
		this.tagEpisodeCountText.SetText(LGIECOAIEFN.ToString() + "/" + DGODOICGJJC.ToString(), true);
		if (LGIECOAIEFN >= DGODOICGJJC)
		{
			this.tagEpisodeCount.SetActive(false);
		}
		else
		{
			this.tagEpisodeCount.SetActive(true);
		}
		if (GKHNIMJJLJL.DHONIOBOLEL.JBDPAJMOEGA() && MIBPOIDDBAD % 5 == 0)
		{
			this.tagEpisodeCount.SetActive(false);
		}
		if (NDIPGHMNCCF != NDHKFLHAFNA.hintCompleted)
		{
			if (NDIPGHMNCCF == NDHKFLHAFNA.hintPlayAgain)
			{
				this.tagEpisodeCount.SetActive(false);
			}
		}
		else
		{
			this.tagEpisodeCount.SetActive(false);
		}
		this.tagEpisodeCount.SetActive(false);
		if (null != this.freePlayModeObj)
		{
			this.freePlayModeObj.gameObject.SetActive(false);
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(17) && SceneAvatarManager.topPercentDifference != 0)
		{
			int topPercentActiveStory = SceneAvatarManager.topPercentActiveStory;
			int glknofhebkn = AKLFPGMDKLA.EHBBFMCILPC.GLKNOFHEBKN;
		}
		SceneAvatarManager.topPercentDifference = 0;
	}

	// Token: 0x06000DB2 RID: 3506 RVA: 0x00064198 File Offset: 0x00062398
	private void AJPJPBOLOLJ()
	{
		this.closeButton.interactable = true;
	}

	// Token: 0x06000DB3 RID: 3507 RVA: 0x000641A6 File Offset: 0x000623A6
	public void HideMiniLoadingAnimation()
	{
		if (this.miniLoadingAnimation.activeSelf)
		{
			this.miniLoadingAnimation.SetActive(false);
		}
	}

	// Token: 0x06000DB5 RID: 3509 RVA: 0x000641EA File Offset: 0x000623EA
	private void JOFANPBEGJB()
	{
		this.closeButton.interactable = false;
		this.chapterSnapshotsItem.JGHMFBCGIBA();
	}

	// Token: 0x06000DB6 RID: 3510 RVA: 0x00064204 File Offset: 0x00062404
	private void NEKHLHGBMBP()
	{
		this.JPIBLAOGEIJ = 0;
		AOBJLALDBAA.DBLAIDPICIG().KDIFKFKMCOH("/", new UnityAction(this.HPJNNEIGLBO));
		AOBJLALDBAA.DBLAIDPICIG().KDIFKFKMCOH("drs2", new UnityAction(this.GMKELJMLKHD));
		AOBJLALDBAA.FILDBDMENPG().ONIBLJOFFPG("", new UnityAction(this.BAMHACBFGDK));
		AOBJLALDBAA.NMGMNAKLLMI().NAMMLDPCHJO("sutta", new UnityAction(this.AJPJPBOLOLJ));
		AOBJLALDBAA.KKPFOJMAONG().ECDBIBPNBCO("storyloaderr1", new UnityAction(this.CMHOMCLCJGI));
		AOBJLALDBAA.KKPFOJMAONG().NAMMLDPCHJO("gpsasli", new UnityAction(this.HNDBBKMAFDB));
		AOBJLALDBAA.DBLAIDPICIG().PFAHGKEDFAE("", new UnityAction(this.DBFLCFHHOFN));
		AOBJLALDBAA.BIAEAOMHBMM().ONIBLJOFFPG("Critical error, could not load asset bundle:", new UnityAction(this.GCNNLOLBPAE));
		AOBJLALDBAA.DBLAIDPICIG().KDIFKFKMCOH("layervideo", new UnityAction(this.AMMCOLDGOAK));
		AOBJLALDBAA.CEGAOMEEFBE().POLEDPIKODD("OnSaveSlotsItemSlotChanged", new UnityAction(this.OAFGCDEKBCK));
		this.statsParent.SetActive(false);
		if (null != this.genresObject)
		{
			this.genresObject.SetActive(false);
			this.genresObjectSpace.SetActive(true);
		}
		this.tagEpisodeCount.SetActive(true);
	}

	// Token: 0x04000471 RID: 1137
	public const string onNeedToDeactivateFocusItemCloseButton = "OnNeedToDeactivateFocusItemCloseButton";

	// Token: 0x04000472 RID: 1138
	public const string onNeedToActivateFocusItemCloseButton = "OnNeedToActivateFocusItemCloseButton";

	// Token: 0x04000473 RID: 1139
	public const string onSaveSyncAnyResultFocusItem = "OnSaveSyncAnyResultFocusItem";

	// Token: 0x04000474 RID: 1140
	public const string onRestartChapterUpsellGetPassPositive = "OnRestartChapterUpsellGetPassPositive";

	// Token: 0x04000475 RID: 1141
	public const string onRestartChapterUpsellGetPassNegative = "OnRestartChapterUpsellGetPassNegative";

	// Token: 0x04000476 RID: 1142
	public const string onChapterSnapshotsBackendFetchSuccess = "OnChapterSnapshotsBackendFetchSuccess";

	// Token: 0x04000477 RID: 1143
	public const string onChapterSnapshotsBackendFetchException = "OnChapterSnapshotsBackendFetchException";

	// Token: 0x04000478 RID: 1144
	public Image thumbnail;

	// Token: 0x04000479 RID: 1145
	public Image logo;

	// Token: 0x0400047A RID: 1146
	public Image playingIconTag;

	// Token: 0x0400047B RID: 1147
	public Image itemTagIcon;

	// Token: 0x0400047C RID: 1148
	public TextMeshProUGUI itemTagText;

	// Token: 0x0400047D RID: 1149
	public TextMeshProUGUI episode;

	// Token: 0x0400047E RID: 1150
	public TextMeshProUGUI season;

	// Token: 0x0400047F RID: 1151
	public TextMeshProUGUI description;

	// Token: 0x04000480 RID: 1152
	public Transform uiHeader;

	// Token: 0x04000481 RID: 1153
	public GameObject settingsButtonHeader;

	// Token: 0x04000482 RID: 1154
	public Transform uiHeaderParent;

	// Token: 0x04000483 RID: 1155
	public Transform uiHeaderFocus;

	// Token: 0x04000484 RID: 1156
	public VerticalLayoutGroup focusFadeVerticalLayoutGroup;

	// Token: 0x04000485 RID: 1157
	public List<Image> statIcons;

	// Token: 0x04000486 RID: 1158
	public List<TextMeshProUGUI> textIcons;

	// Token: 0x04000487 RID: 1159
	public GameObject statsParent;

	// Token: 0x04000488 RID: 1160
	public HorizontalLayoutGroup statsParentHorizontalLayout;

	// Token: 0x04000489 RID: 1161
	public GameObject genresObject;

	// Token: 0x0400048A RID: 1162
	public TextMeshProUGUI genresText;

	// Token: 0x0400048B RID: 1163
	public GameObject genresObjectSpace;

	// Token: 0x0400048C RID: 1164
	public GameObject playButton;

	// Token: 0x0400048D RID: 1165
	public GameObject playButtonCard;

	// Token: 0x0400048E RID: 1166
	public GameObject tagHint;

	// Token: 0x0400048F RID: 1167
	public GameObject restartButton;

	// Token: 0x04000490 RID: 1168
	public GameObject avatarButton;

	// Token: 0x04000491 RID: 1169
	public GameObject tagEpisodeCount;

	// Token: 0x04000492 RID: 1170
	public GameObject tagEpisodeCountButton;

	// Token: 0x04000493 RID: 1171
	public TextMeshProUGUI tagEpisodeCountText;

	// Token: 0x04000494 RID: 1172
	public GameObject filterTag;

	// Token: 0x04000495 RID: 1173
	public Image filterIcon;

	// Token: 0x04000496 RID: 1174
	public Sprite[] filterSprites;

	// Token: 0x04000497 RID: 1175
	public GameObject innerShadow;

	// Token: 0x04000498 RID: 1176
	public GameObject freePlayModeObj;

	// Token: 0x04000499 RID: 1177
	public GameObject favoritesInactive;

	// Token: 0x0400049A RID: 1178
	public GameObject favoritesActive;

	// Token: 0x0400049B RID: 1179
	public GameObject favoritesActiveAnim;

	// Token: 0x0400049C RID: 1180
	[Header("Card Fields")]
	public TextMeshProUGUI cardDescription;

	// Token: 0x0400049D RID: 1181
	public GameObject cardObjects;

	// Token: 0x0400049E RID: 1182
	public GameObject tagTimerEnd;

	// Token: 0x0400049F RID: 1183
	public TextMeshProUGUI tagTimerDynamicText;

	// Token: 0x040004A0 RID: 1184
	public GameObject saveSlotsButton;

	// Token: 0x040004A1 RID: 1185
	public TextMeshProUGUI saveSlotsButtonInfoText;

	// Token: 0x040004A2 RID: 1186
	public GameObject saveSlotsButtonExpiredExclamation;

	// Token: 0x040004A3 RID: 1187
	public GameObject saveSlotsFade;

	// Token: 0x040004A4 RID: 1188
	public SaveSlotsItem saveSlotsItem;

	// Token: 0x040004A5 RID: 1189
	public GameObject chapterSnapshotsFade;

	// Token: 0x040004A6 RID: 1190
	public ChapterSnapshotsItem chapterSnapshotsItem;

	// Token: 0x040004A7 RID: 1191
	public Button closeButton;

	// Token: 0x040004A8 RID: 1192
	public GameObject miniLoadingAnimation;

	// Token: 0x040004A9 RID: 1193
	[Header("Lounge")]
	public Image avatarButtonIcon;

	// Token: 0x040004AA RID: 1194
	public const string avatarLoungeIconResourceName = "focusavatarloungeicon";

	// Token: 0x040004AB RID: 1195
	private Sprite KIDHIOADHHJ;

	// Token: 0x040004AC RID: 1196
	private Vector2 CNOAKJODOEO;

	// Token: 0x040004AD RID: 1197
	private Vector2 PHDBJACBPGC;

	// Token: 0x040004AE RID: 1198
	private bool NKNJKFKMFOO;

	// Token: 0x040004AF RID: 1199
	private bool GNLNJKKDCIK;

	// Token: 0x040004B0 RID: 1200
	private Vector3 KLFEKJICBKK = new Vector3(0f, 0f, 0f);

	// Token: 0x040004B1 RID: 1201
	private Vector3 PFEEFOKHKMP;

	// Token: 0x040004B2 RID: 1202
	private NDHKFLHAFNA NDIPGHMNCCF;

	// Token: 0x040004B3 RID: 1203
	private int MICMIKNOOEC;

	// Token: 0x040004B4 RID: 1204
	private int JKEOGHJHNHP;

	// Token: 0x040004B5 RID: 1205
	private int MIBPOIDDBAD;

	// Token: 0x040004B6 RID: 1206
	private int BIBKFNMPHIK;

	// Token: 0x040004B7 RID: 1207
	private int DCHHFIEFEBK;

	// Token: 0x040004B8 RID: 1208
	[HideInInspector]
	public int currentAnthologyIndex;

	// Token: 0x040004B9 RID: 1209
	private bool LMAPHMHIMKI;

	// Token: 0x040004BA RID: 1210
	private int LGIECOAIEFN;

	// Token: 0x040004BB RID: 1211
	private int DGODOICGJJC;

	// Token: 0x040004BC RID: 1212
	private bool OJOONOFEIMG;

	// Token: 0x040004BD RID: 1213
	private OKAFAHMOFII FNJJIPNFCMK;

	// Token: 0x040004BE RID: 1214
	private bool GMLKPEHPCHB;

	// Token: 0x040004BF RID: 1215
	private bool HJBMNLBOEAL;

	// Token: 0x040004C0 RID: 1216
	private int AMKCLHLIIMN = -1;

	// Token: 0x040004C1 RID: 1217
	private const int HBAAAHBKMGP = -20;

	// Token: 0x040004C2 RID: 1218
	public static bool isFocusOpened;

	// Token: 0x040004C3 RID: 1219
	private AssetAnthologyPreview2 NPMBHDLIDFC;

	// Token: 0x040004C4 RID: 1220
	private int JPIBLAOGEIJ;
}
