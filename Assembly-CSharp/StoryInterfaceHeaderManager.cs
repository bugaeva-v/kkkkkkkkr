using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityStandardAssets.ImageEffects;

// Token: 0x0200005B RID: 91
public class StoryInterfaceHeaderManager : MonoBehaviour
{
	// Token: 0x06000CDC RID: 3292 RVA: 0x0005CE4C File Offset: 0x0005B04C
	public void KIECAMIABIE(string DIMBCOBNMAM)
	{
		if (null == this.textCurrencies)
		{
			return;
		}
		bool flag = DIMBCOBNMAM == null || DIMBCOBNMAM.Length > 0;
		if (null != this.currenciesParent)
		{
			this.currenciesParent.SetActive(flag);
		}
		else
		{
			this.textCurrencies.gameObject.SetActive(flag);
		}
		if (flag)
		{
			this.textCurrencies.SetText(DIMBCOBNMAM, false);
		}
	}

	// Token: 0x06000CDD RID: 3293 RVA: 0x0005CEB8 File Offset: 0x0005B0B8
	public bool OHHFFMMMMAC()
	{
		if (!base.gameObject.activeSelf)
		{
			AOBJLALDBAA.AGANFKKBPFO().DCGCFPHHDDG("OnBackendGetUserSketchesSuccess", 1125f);
			return true;
		}
		this.BAMHPOCKBML();
		if (this.NOJPGANKFDP != null)
		{
			AOBJLALDBAA.NMGMNAKLLMI().KMAGHMCCMPG("+", 1511f);
			return true;
		}
		if (null != this.PANMNKKODPC && this.PANMNKKODPC.alpha < 837f && this.LFCIBEEKAPP == null)
		{
			AOBJLALDBAA.FILDBDMENPG().LPNCDPHNBJK("mins", 1456f);
			return false;
		}
		if (this.LFCIBEEKAPP != null)
		{
			base.StopCoroutine(this.LFCIBEEKAPP);
			this.LFCIBEEKAPP = null;
		}
		this.NOJPGANKFDP = base.StartCoroutine(this.MPCGAMEDJGB());
		return true;
	}

	// Token: 0x06000CDE RID: 3294 RVA: 0x0005CF78 File Offset: 0x0005B178
	public void HideInterfaceUndoButton()
	{
		if (null != this.KEFIFKNOBHN)
		{
			this.KEFIFKNOBHN.HideButton();
		}
	}

	// Token: 0x06000CDF RID: 3295 RVA: 0x0005CF94 File Offset: 0x0005B194
	public void UpdateGamePassOptions(bool HCLABIKKENF, bool KEEFNDBMOCB, bool JGHIDMONOBL)
	{
		if (this.prefabVersion == 1)
		{
			return;
		}
		if (HCLABIKKENF)
		{
			this.JFAEJFAJEGP = (AKLFPGMDKLA.EHBBFMCILPC.MEDFMIPBDFD == 1);
			this.CAKPNECIJNA = (AKLFPGMDKLA.EHBBFMCILPC.AJLAADOFOLH == 1);
			if (this.JFAEJFAJEGP)
			{
				this.CAKPNECIJNA = false;
			}
			this.MPNCAPPPEHN = (this.BLLCLBOEDEK || AKLFPGMDKLA.EHBBFMCILPC.EKHACLPEIBJ == 1);
			this.BILONLBLEFL = (AKLFPGMDKLA.EHBBFMCILPC.IHMLBGPJKDO == 1);
		}
		if (ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass, true) == null)
		{
			this.JFAEJFAJEGP = false;
			this.CAKPNECIJNA = false;
		}
		if (KEEFNDBMOCB)
		{
			this.settingsButton.SetState(HGJINNBJPKJ.idle);
			if (this.JFAEJFAJEGP)
			{
				this.fastForwardButton.SetState(HGJINNBJPKJ.selected);
			}
			else
			{
				this.fastForwardButton.SetState(HGJINNBJPKJ.idle);
			}
			if (this.MPNCAPPPEHN)
			{
				this.loveInterestsButton.SetState(HGJINNBJPKJ.selected);
			}
			else
			{
				this.loveInterestsButton.SetState(HGJINNBJPKJ.idle);
			}
			if (this.BILONLBLEFL)
			{
				this.statsButton.SetState(HGJINNBJPKJ.selected);
			}
			else
			{
				this.statsButton.SetState(HGJINNBJPKJ.idle);
			}
			this.rewindButton.SetState(HGJINNBJPKJ.idle);
			if (this.CAKPNECIJNA)
			{
				this.autoReadButton.SetState(HGJINNBJPKJ.selected);
			}
			else
			{
				this.autoReadButton.SetState(HGJINNBJPKJ.idle);
			}
			FJLGCKNOJMJ fjlgcknojmj = null;
			if (null != AssetsManager.EHBBFMCILPC && null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				fjlgcknojmj = AssetsManager.EHBBFMCILPC.lobbyDataAsset.MFMJHIFAOHE().ELDKHHGLNBK(StoryInterfaceHeaderManager.anthologyIndex);
			}
			if (fjlgcknojmj != null && !KDCJJBLGCBH.EHBBFMCILPC.NJFAOIDGFGC())
			{
				fjlgcknojmj = null;
			}
			if (fjlgcknojmj != null && fjlgcknojmj.PPACJFFFBFB && SceneStoryManager.AnyLoungeCharacterInActiveWardrobe())
			{
				this.wardrobeButton.SetState(HGJINNBJPKJ.idle);
				this.UpdateWardrobeNewLooksDisc(true);
			}
			else
			{
				this.wardrobeButton.SetState(HGJINNBJPKJ.unavailable);
				this.UpdateWardrobeNewLooksDisc(false);
			}
		}
		if (JGHIDMONOBL)
		{
			this.BLLHDCHOGJD();
			this.DIPEJAPBMHH();
			this.IPIOELOIGHF();
			this.AHNLGNMJMGL();
		}
		if (null != this.optionsParent)
		{
			if (null == this.NOLDFGGJPEK)
			{
				this.NOLDFGGJPEK = this.optionsParent.GetComponent<CanvasGroup>();
			}
			base.StartCoroutine(this.LHNMEHHAPAO(this.optionsParent.transform.parent.GetComponent<RectTransform>()));
			return;
		}
		GameObject gameObject = this.loveInterestsParent;
		if (null == gameObject)
		{
			gameObject = this.loveInterestsParent2;
		}
		if (null != gameObject)
		{
			base.StartCoroutine(this.LHNMEHHAPAO(gameObject.transform.parent.GetComponent<RectTransform>()));
		}
	}

	// Token: 0x06000CE0 RID: 3296 RVA: 0x0005D204 File Offset: 0x0005B404
	public void OnGamePassUndosClick()
	{
		if (null != this.OEJDFGDLOKA && null != this.PANMNKKODPC && (this.OEJDFGDLOKA.alpha < 0.9f || this.PANMNKKODPC.alpha < 0.9f))
		{
			return;
		}
		this.HHODFMEPEAI();
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass);
		if (null != this.gamePassParent && kioojmglclc != null)
		{
			if (kioojmglclc.ALFGPLALKCN())
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("passhintundo"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupStoryLoadError, 0f, 28);
				return;
			}
			FPFNLJGEIJK.FIBNFNACDBE(BGHLMGPPCNN.subHint);
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("passhintinactivesub"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("no"), new UnityAction(this.PMIEIFKANGO), new UnityAction(this.GFMFGEEFCDG), DFGILFBGPLN.popupSignInQuestion, 0f, 28);
		}
	}

	// Token: 0x06000CE1 RID: 3297 RVA: 0x0005D32F File Offset: 0x0005B52F
	public void MCDOPHMNHNO()
	{
		if (null != this.imageProgressParent)
		{
			this.imageProgressParent.SetActive(true);
		}
	}

	// Token: 0x06000CE2 RID: 3298 RVA: 0x0005D34B File Offset: 0x0005B54B
	public bool IsShowingOrVisible()
	{
		return this.LFCIBEEKAPP != null || this.IsVisible();
	}

	// Token: 0x06000CE3 RID: 3299 RVA: 0x0005D360 File Offset: 0x0005B560
	private void DIPEJAPBMHH()
	{
		if (this.prefabVersion == 1)
		{
			return;
		}
		if (null != this.loveInterestsParent)
		{
			this.loveInterestsParent.gameObject.SetActive(false);
		}
		if (null != this.loveInterestsParent2)
		{
			this.loveInterestsParent2.gameObject.SetActive(false);
		}
		GameObject gameObject = this.loveInterestsParent;
		List<StoryInterfaceLoveInterestManager> list = this.loveInterests;
		this.AEFMHHIMKFC = 0;
		int num = 0;
		if (this.GKHNIMJJLJL != null)
		{
			for (int i = 0; i < this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL.Count; i++)
			{
				if (this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[i].PPACJFFFBFB == 1)
				{
					this.AEFMHHIMKFC++;
					if (this.DMAGKGIMPEB(this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[i].PFFCLABCNHI))
					{
						num++;
					}
				}
			}
		}
		if (this.AEFMHHIMKFC <= 4 && this.loungeLoveInterestSpriteFilter == null)
		{
			gameObject = this.loveInterestsParent2;
			list = this.loveInterests2;
		}
		if (null != gameObject)
		{
			try
			{
				if (this.MPNCAPPPEHN && (this.loungeLoveInterestSpriteFilter == null || num > 0))
				{
					gameObject.SetActive(true);
					if (this.GKHNIMJJLJL != null)
					{
						int num2 = 0;
						for (int j = 0; j < this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL.Count; j++)
						{
							if (j < list.Count)
							{
								list[j].orderNumberText.text = (num2 + 1).ToString();
								list[j].percentText.text = this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[j].PHIEEHJCHAK.ToString() + "%";
								if (null == list[j].thumbnailImage.sprite && null != AssetsManager.EHBBFMCILPC.profileDataAsset)
								{
									list[j].thumbnailImage.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.HGFILJAIPEO(this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[j].PFFCLABCNHI, true);
								}
								if (this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[j].MJKICDJIFIP == 0)
								{
									list[j].lockedHeart.SetActive(true);
								}
								else
								{
									list[j].lockedHeart.SetActive(false);
								}
								if (this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[j].MJKICDJIFIP == 1)
								{
									list[j].unlockedHeart.SetActive(true);
								}
								else
								{
									list[j].unlockedHeart.SetActive(false);
								}
								bool flag = this.loungeLoveInterestSpriteFilter != null;
								if (this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[j].KDODAAICNDO < 0 && !flag)
								{
									list[j].arrowDown.SetActive(true);
								}
								else
								{
									list[j].arrowDown.SetActive(false);
								}
								if (this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[j].KDODAAICNDO > 0 && !flag)
								{
									list[j].arrowUp.SetActive(true);
								}
								else
								{
									list[j].arrowUp.SetActive(false);
								}
								bool flag2 = false;
								if (this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[j].PPACJFFFBFB == 0 || flag2 || (this.loungeLoveInterestSpriteFilter != null && this.loungeLoveInterestSpriteFilterHidesOthers && !this.DMAGKGIMPEB(this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[j].PFFCLABCNHI)))
								{
									list[j].gameObject.SetActive(false);
								}
								else
								{
									list[j].gameObject.SetActive(true);
									if (this.loungeLoveInterestSpriteFilter != null)
									{
										if (null != list[j].lockedHeart)
										{
											list[j].lockedHeart.SetActive(false);
										}
										if (null != list[j].unlockedHeart)
										{
											list[j].unlockedHeart.SetActive(false);
										}
										if (null != list[j].orderNumberText)
										{
											list[j].orderNumberText.gameObject.SetActive(false);
										}
										if (null != list[j].percentText && null != list[j].percentText.transform.parent && list[j].percentText.transform.parent.gameObject != list[j].gameObject)
										{
											list[j].percentText.transform.parent.gameObject.SetActive(false);
										}
										if (null != list[j].loungeLooksCountParent)
										{
											int num3 = this.MMNGDKLHANO(this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[j].PFFCLABCNHI);
											if (num3 > 0)
											{
												list[j].loungeLooksCountParent.SetActive(true);
												if (null != list[j].loungeLooksCountText)
												{
													list[j].loungeLooksCountText.text = num3.ToString();
												}
											}
											else
											{
												list[j].loungeLooksCountParent.SetActive(false);
											}
										}
									}
									num2++;
								}
							}
						}
					}
				}
				else
				{
					gameObject.SetActive(false);
				}
			}
			catch (Exception aklgbjkdomm)
			{
				gameObject.SetActive(false);
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
	}

	// Token: 0x06000CE4 RID: 3300 RVA: 0x0005D930 File Offset: 0x0005BB30
	public void OnGamePassOptionsTopMatchesClick()
	{
		if (null != this.NOLDFGGJPEK && null != this.PANMNKKODPC && (this.NOLDFGGJPEK.alpha < 0.9f || this.PANMNKKODPC.alpha < 0.9f))
		{
			return;
		}
		if (this.prefabVersion == 1)
		{
			return;
		}
		this.HHODFMEPEAI();
		this.MPNCAPPPEHN = !this.MPNCAPPPEHN;
		this.DIPEJAPBMHH();
		this.BMLHEAMOOLN(54);
		if (null != this.optionsParent)
		{
			base.StartCoroutine(this.LHNMEHHAPAO(this.optionsParent.transform.parent.GetComponent<RectTransform>()));
		}
		this.UpdateGamePassOptions(false, true, false);
	}

	// Token: 0x06000CE5 RID: 3301 RVA: 0x0005D9E4 File Offset: 0x0005BBE4
	public void OnShopClick()
	{
		if (this.DPNFENJDCEO)
		{
			return;
		}
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryInterfaceHeaderShopClick", 0f);
	}

	// Token: 0x06000CE7 RID: 3303 RVA: 0x0005DA67 File Offset: 0x0005BC67
	public bool CanInteract()
	{
		return null != this.PANMNKKODPC && (double)this.PANMNKKODPC.alpha > 0.9;
	}

	// Token: 0x06000CE8 RID: 3304 RVA: 0x0005DA90 File Offset: 0x0005BC90
	public bool GamePassParentVisible()
	{
		return this.LHJPAIDMPOJ;
	}

	// Token: 0x06000CE9 RID: 3305 RVA: 0x0005DA98 File Offset: 0x0005BC98
	private void GAEKGJEDFHG()
	{
		try
		{
			this.FNPPBICAOPG();
			KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass);
			if (null != this.gamePassParent && kioojmglclc != null)
			{
				this.premGamePassActive.SetActive(false);
				this.goldGamePassActive.SetActive(false);
				this.premGamePassInactive.SetActive(false);
				this.goldGamePassInactive.SetActive(false);
				if (kioojmglclc.ALFGPLALKCN())
				{
					if (kioojmglclc.LIFPODJAPIA() == KHBLFKIDHPH.premiumGamePass)
					{
						this.premGamePassActive.SetActive(true);
					}
					else
					{
						this.goldGamePassActive.SetActive(true);
					}
					if (!AssetsManager.EHBBFMCILPC.IsBusy() && !App42Manager.EHBBFMCILPC.IsBusy() && (float)kioojmglclc.FHHLFACIIDF() <= 0.001f && (float)kioojmglclc.FOIOENCOCEE() > 1f)
					{
						BackendOperationsManager.EHBBFMCILPC.ForceRefreshExpiredSubscriptions();
						CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationTopWithHint(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("serversync"), 128);
						BackendOperationsManager.EHBBFMCILPC.RequestBasicSync("OnApplicationFocusBasicSyncSuccess", "OnApplicationFocusBasicSyncEcxeption", false);
					}
					this.OBABJMAPBKB = true;
				}
				else
				{
					if (kioojmglclc.LIFPODJAPIA() == KHBLFKIDHPH.premiumGamePass)
					{
						this.premGamePassInactive.SetActive(true);
					}
					else
					{
						this.goldGamePassInactive.SetActive(true);
					}
					kioojmglclc.HIAFKCFIEKJ();
					if (this.OBABJMAPBKB)
					{
						AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnGamePassExpire", 0f);
					}
					this.OBABJMAPBKB = false;
				}
				this.gamePassChoicesText.GetComponent<AnimationTextIncrement>().Set(kioojmglclc.COEFNFJMBDG - kioojmglclc.COLHPJFMNJJ, -1f, 0f);
				this.gamePassDiscountText.GetComponent<AnimationTextIncrement>().Set(kioojmglclc.HEGNAMGJLNP - kioojmglclc.ANNOCALAODF, -1f, 0f);
				this.gamePassUndoText.GetComponent<AnimationTextIncrement>().Set(kioojmglclc.HCBEGPENNLN - kioojmglclc.JEKGPMFGAFK, -1f, 0f);
				if (kioojmglclc.ALFGPLALKCN() && null != this.KEFIFKNOBHN)
				{
					this.KEFIFKNOBHN.SetText(kioojmglclc.HCBEGPENNLN, kioojmglclc.ALFGPLALKCN());
				}
				else if (null != this.KEFIFKNOBHN)
				{
					this.KEFIFKNOBHN.SetText(0, kioojmglclc.ALFGPLALKCN());
				}
				if (LiveEventsManager.EHBBFMCILPC.LiveEventActive(EGMCEPOABBF.liveEventFreeDiamonds, -1, -1) || LiveEventsManager.EHBBFMCILPC.LiveEventActive(EGMCEPOABBF.liveEventFreeStory, StoryInterfaceHeaderManager.storyIndex, -1) || LiveEventsManager.EHBBFMCILPC.LiveEventActive(EGMCEPOABBF.liveEventFreeAvatar, -1, -1))
				{
					this.gamePassEvent.GetComponent<CanvasGroup>().alpha = 1f;
				}
				else
				{
					this.gamePassEvent.GetComponent<CanvasGroup>().alpha = 0.25f;
				}
				this.gamePassChoiceState.gameObject.SetActive(false);
				if (kioojmglclc.COEFNFJMBDG == 0)
				{
					this.gamePassChoices.GetComponent<CanvasGroup>().alpha = 0.25f;
					this.gamePassDiscount.GetComponent<CanvasGroup>().alpha = 1f;
					this.gamePassUndo.GetComponent<CanvasGroup>().alpha = 1f;
				}
				else
				{
					this.gamePassChoices.GetComponent<CanvasGroup>().alpha = 1f;
					this.gamePassDiscount.GetComponent<CanvasGroup>().alpha = 0.25f;
				}
				if (kioojmglclc.HCBEGPENNLN == 0)
				{
					this.gamePassUndo.GetComponent<CanvasGroup>().alpha = 0.25f;
				}
				else
				{
					this.gamePassUndo.GetComponent<CanvasGroup>().alpha = 1f;
				}
				if (kioojmglclc.HEGNAMGJLNP == 0)
				{
					this.gamePassDiscount.GetComponent<CanvasGroup>().alpha = 0.25f;
				}
				if (AKLFPGMDKLA.EHBBFMCILPC.MDPMKICGGIJ == 1 && kioojmglclc.HEGNAMGJLNP > 0)
				{
					this.gamePassChoices.GetComponent<CanvasGroup>().alpha = 0.25f;
					this.gamePassDiscount.GetComponent<CanvasGroup>().alpha = 1f;
				}
				if (kioojmglclc.COLHPJFMNJJ != 0 || kioojmglclc.ANNOCALAODF != 0 || kioojmglclc.JEKGPMFGAFK != 0)
				{
					if (this.NGFAMMBEDKI != null)
					{
						base.StopCoroutine(this.NGFAMMBEDKI);
					}
					try
					{
						this.NGFAMMBEDKI = base.StartCoroutine(this.ABAMBEDNJOJ());
					}
					catch (Exception aklgbjkdomm)
					{
						DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
					}
				}
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
		}
	}

	// Token: 0x06000CEA RID: 3306 RVA: 0x0005DEA8 File Offset: 0x0005C0A8
	private void GJMIHJNBPEB()
	{
		AOBJLALDBAA.AGANFKKBPFO().KDIFKFKMCOH("areyousurerestartepbody0new", new UnityAction(this.OnApplicationFocusBasicSyncSuccess));
	}

	// Token: 0x06000CEB RID: 3307 RVA: 0x0005DEC5 File Offset: 0x0005C0C5
	public void OnAvatarClick()
	{
		if (this.DPNFENJDCEO)
		{
			return;
		}
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryInterfaceHeaderAvatarClick", 0f);
	}

	// Token: 0x06000CEC RID: 3308 RVA: 0x0005DEE4 File Offset: 0x0005C0E4
	private IEnumerator ABAMBEDNJOJ()
	{
		yield return new WaitForSeconds(0.5f);
		KIOOJMGLCLC highestOrderPass = ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass, true);
		if (null != this.gamePassParent && highestOrderPass != null && highestOrderPass.BMOEBDLJINE())
		{
			this.gamePassChoicesText.GetComponent<AnimationTextIncrement>().Set(highestOrderPass.COEFNFJMBDG, 0f, 0f);
			this.gamePassDiscountText.GetComponent<AnimationTextIncrement>().Set(highestOrderPass.HEGNAMGJLNP, 0f, 0f);
			this.gamePassUndoText.GetComponent<AnimationTextIncrement>().Set(highestOrderPass.HCBEGPENNLN, 0f, 0f);
			if (highestOrderPass.COLHPJFMNJJ != 0)
			{
				if (highestOrderPass.COLHPJFMNJJ > 0)
				{
					this.gamePassChoicesVisualChangePos.SetActive(true);
				}
				else
				{
					this.gamePassChoicesVisualChangeNeg.SetActive(true);
				}
			}
			if (highestOrderPass.ANNOCALAODF != 0)
			{
				if (highestOrderPass.ANNOCALAODF > 0)
				{
					this.gamePassDiscountVisualChangePos.SetActive(true);
				}
				else
				{
					this.gamePassDiscountVisualChangeNeg.SetActive(true);
				}
			}
			if (highestOrderPass.JEKGPMFGAFK != 0)
			{
				if (highestOrderPass.JEKGPMFGAFK > 0)
				{
					this.gamePassUndoVisualChangePos.SetActive(true);
				}
				else
				{
					this.gamePassUndoVisualChangeNeg.SetActive(true);
				}
			}
			yield return new WaitForSeconds(1f);
			this.gamePassChoicesVisualChangePos.SetActive(false);
			this.gamePassChoicesVisualChangeNeg.SetActive(false);
			this.gamePassDiscountVisualChangePos.SetActive(false);
			this.gamePassDiscountVisualChangeNeg.SetActive(false);
			this.gamePassUndoVisualChangePos.SetActive(false);
			this.gamePassUndoVisualChangeNeg.SetActive(false);
			highestOrderPass.BDDEAMFPHEF();
		}
		this.NGFAMMBEDKI = null;
		yield break;
	}

	// Token: 0x06000CED RID: 3309 RVA: 0x0005D32F File Offset: 0x0005B52F
	public void OHAGBPJMNDI()
	{
		if (null != this.imageProgressParent)
		{
			this.imageProgressParent.SetActive(true);
		}
	}

	// Token: 0x06000CEE RID: 3310 RVA: 0x0005DEF3 File Offset: 0x0005C0F3
	private void HHODFMEPEAI()
	{
		this.LLKJBKBBFJO = 6f;
	}

	// Token: 0x06000CEF RID: 3311 RVA: 0x0005DF00 File Offset: 0x0005C100
	private void PMIEIFKANGO()
	{
		FPFNLJGEIJK.FANFNCNAKEF();
		this.HBPLGJFPFKM();
	}

	// Token: 0x06000CF0 RID: 3312 RVA: 0x0005DF0D File Offset: 0x0005C10D
	public void LMLMBINLJHM()
	{
		if (null != this.KEFIFKNOBHN)
		{
			this.KEFIFKNOBHN.PFLPFJKEEDG();
		}
	}

	// Token: 0x06000CF1 RID: 3313 RVA: 0x0005DF28 File Offset: 0x0005C128
	private IEnumerator GACBCOCNEPL()
	{
		yield return new WaitForSeconds(0.1f);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryInterfaceHeaderShown", 0f);
		if (null != this.otherParent)
		{
			this.otherParent.SetActive(true);
		}
		if (null != this.gamePassParent && ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass) != null)
		{
			this.gamePassParent.SetActive(true);
			this.GAEKGJEDFHG();
		}
		else if (null != this.gamePassParent)
		{
			this.gamePassParent.SetActive(false);
		}
		if (null != this.optionsParent)
		{
			this.optionsParent.SetActive(true);
		}
		if (this.APJOBILCHHF)
		{
			this.UpdateGamePassOptions(true, true, true);
			this.APJOBILCHHF = false;
		}
		else
		{
			this.UpdateGamePassOptions(false, true, true);
		}
		this.NOJPGANKFDP = null;
		if (null != this.JNIDFGCGGMF)
		{
			this.JNIDFGCGGMF.SetDirection(false);
			this.JNIDFGCGGMF.PlayAnimation(false);
		}
		this.HHODFMEPEAI();
		while (this.LLKJBKBBFJO > 0f)
		{
			while (StoryInterfaceHeaderManager.modalDialogActive)
			{
				yield return new WaitForEndOfFrame();
			}
			this.LLKJBKBBFJO -= Time.deltaTime;
			yield return new WaitForEndOfFrame();
		}
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryInterfaceHeaderHideComplete", 0f);
		if (null != this.JNIDFGCGGMF)
		{
			this.JNIDFGCGGMF.SetDirection(true);
			this.JNIDFGCGGMF.PlayAnimation(false);
		}
		this.LFCIBEEKAPP = null;
		yield break;
	}

	// Token: 0x06000CF2 RID: 3314 RVA: 0x0005DF38 File Offset: 0x0005C138
	private void BLLHDCHOGJD()
	{
		if (this.prefabVersion == 1)
		{
			return;
		}
		if (null != this.statsParent && null != this.statsParent2)
		{
			try
			{
				if (this.BILONLBLEFL)
				{
					if (this.GFIKBJKDMIC != null && this.HDLPCMDOECJ != null)
					{
						int num = -1;
						if (this.GFIKBJKDMIC.Length == 5)
						{
							num = 3;
						}
						else if (this.GFIKBJKDMIC.Length > 5)
						{
							num = 4;
						}
						this.statsParent.SetActive(true);
						for (int i = 0; i < this.GFIKBJKDMIC.Length; i++)
						{
							if (i < this.statsIcons.Count && i < this.statsTexts.Count && i < this.HDLPCMDOECJ.Count && i - num < this.statsIcons2.Count && i - num < this.statsTexts2.Count)
							{
								if (i == num)
								{
									this.statsParent2.SetActive(true);
								}
								if (num < 0 || i < num)
								{
									this.statsIcons[i].gameObject.SetActive(true);
									this.statsIcons[i].sprite = this.HDLPCMDOECJ[i];
									this.statsIcons[i].SetNativeSize();
									this.statsIcons[i].preserveAspect = true;
									this.statsTexts[i].gameObject.SetActive(true);
									this.statsTexts[i].text = (DPGJIJGOCIC.AMAFLPDPBOO(this.GFIKBJKDMIC[i].GALKFKBPLCK(), LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru) ?? "");
									this.statsTexts[i].SetText(DPGJIJGOCIC.AMAFLPDPBOO(this.GFIKBJKDMIC[i].GALKFKBPLCK(), LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru) ?? "", true);
								}
								else
								{
									this.statsIcons2[i - num].gameObject.SetActive(true);
									this.statsIcons2[i - num].sprite = this.HDLPCMDOECJ[i];
									this.statsIcons2[i - num].SetNativeSize();
									this.statsIcons2[i - num].preserveAspect = true;
									this.statsTexts2[i - num].gameObject.SetActive(true);
									this.statsTexts2[i - num].text = (DPGJIJGOCIC.AMAFLPDPBOO(this.GFIKBJKDMIC[i].GALKFKBPLCK(), LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru) ?? "");
									this.statsTexts2[i - num].SetText(DPGJIJGOCIC.AMAFLPDPBOO(this.GFIKBJKDMIC[i].GALKFKBPLCK(), LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru) ?? "", true);
								}
							}
						}
					}
				}
				else
				{
					this.statsParent.SetActive(false);
					this.statsParent2.SetActive(false);
				}
			}
			catch (Exception aklgbjkdomm)
			{
				this.statsParent.SetActive(false);
				this.statsParent2.SetActive(false);
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
	}

	// Token: 0x06000CF3 RID: 3315 RVA: 0x0005E278 File Offset: 0x0005C478
	public void ForceLoveInterestsSection()
	{
		this.BLLCLBOEDEK = true;
		this.MPNCAPPPEHN = true;
	}

	// Token: 0x06000CF4 RID: 3316 RVA: 0x0005E288 File Offset: 0x0005C488
	public void OnGamePassEventClick()
	{
		if (null != this.OEJDFGDLOKA && null != this.PANMNKKODPC && (this.OEJDFGDLOKA.alpha < 0.9f || this.PANMNKKODPC.alpha < 0.9f))
		{
			return;
		}
		this.HHODFMEPEAI();
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass);
		if (null != this.gamePassParent && kioojmglclc != null)
		{
			if (kioojmglclc.ALFGPLALKCN())
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("passhintevent"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupStoryLoadError, 0f, 28);
				return;
			}
			FPFNLJGEIJK.FIBNFNACDBE(BGHLMGPPCNN.subHint);
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("passhintinactivesub"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("no"), new UnityAction(this.PMIEIFKANGO), new UnityAction(this.GFMFGEEFCDG), DFGILFBGPLN.popupSignInQuestion, 0f, 28);
		}
	}

	// Token: 0x06000CF5 RID: 3317 RVA: 0x0005E3B3 File Offset: 0x0005C5B3
	private void Start()
	{
		this.BAMHPOCKBML();
	}

	// Token: 0x06000CF6 RID: 3318 RVA: 0x0005E3BB File Offset: 0x0005C5BB
	public void MKAFLFCIPKA(LDLLJFOJCDF[] AIIEPMPDLMM, List<Sprite> NEDFFHHECOB)
	{
		this.GFIKBJKDMIC = AIIEPMPDLMM;
		this.HDLPCMDOECJ = NEDFFHHECOB;
	}

	// Token: 0x06000CF7 RID: 3319 RVA: 0x0005E3CB File Offset: 0x0005C5CB
	public void ShowInterfaceUndoButton()
	{
		if (null != this.KEFIFKNOBHN)
		{
			this.KEFIFKNOBHN.ShowButton();
		}
	}

	// Token: 0x06000CF8 RID: 3320 RVA: 0x0005E3E8 File Offset: 0x0005C5E8
	private void MAHLINEFBLK()
	{
		if (this.prefabVersion == 0)
		{
			return;
		}
		if (null != this.loveInterestsParent)
		{
			this.loveInterestsParent.gameObject.SetActive(true);
		}
		if (null != this.loveInterestsParent2)
		{
			this.loveInterestsParent2.gameObject.SetActive(true);
		}
		GameObject gameObject = this.loveInterestsParent;
		List<StoryInterfaceLoveInterestManager> list = this.loveInterests;
		this.AEFMHHIMKFC = 1;
		int num = 1;
		if (this.GKHNIMJJLJL != null)
		{
			for (int i = 0; i < this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL.Count; i += 0)
			{
				if (this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[i].PPACJFFFBFB == 0)
				{
					this.AEFMHHIMKFC++;
					if (this.DMAGKGIMPEB(this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[i].PFFCLABCNHI))
					{
						num += 0;
					}
				}
			}
		}
		if (this.AEFMHHIMKFC <= 7 && this.loungeLoveInterestSpriteFilter == null)
		{
			gameObject = this.loveInterestsParent2;
			list = this.loveInterests2;
		}
		if (null != gameObject)
		{
			try
			{
				if (this.MPNCAPPPEHN && (this.loungeLoveInterestSpriteFilter == null || num > 1))
				{
					gameObject.SetActive(false);
					if (this.GKHNIMJJLJL != null)
					{
						int num2 = 1;
						for (int j = 1; j < this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL.Count; j += 0)
						{
							if (j < list.Count)
							{
								list[j].orderNumberText.text = (num2 + 1).ToString();
								list[j].percentText.text = this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[j].PHIEEHJCHAK.ToString() + "saveslotsoptioncopy";
								if (null == list[j].thumbnailImage.sprite && null != AssetsManager.MJBDMHPHMID().profileDataAsset)
								{
									list[j].thumbnailImage.sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.HGFILJAIPEO(this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[j].PFFCLABCNHI, true);
								}
								if (this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[j].MJKICDJIFIP == 0)
								{
									list[j].lockedHeart.SetActive(true);
								}
								else
								{
									list[j].lockedHeart.SetActive(true);
								}
								if (this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[j].MJKICDJIFIP == 1)
								{
									list[j].unlockedHeart.SetActive(true);
								}
								else
								{
									list[j].unlockedHeart.SetActive(true);
								}
								bool flag = this.loungeLoveInterestSpriteFilter != null;
								if (this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[j].KDODAAICNDO < 1 && !flag)
								{
									list[j].arrowDown.SetActive(false);
								}
								else
								{
									list[j].arrowDown.SetActive(false);
								}
								if (this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[j].KDODAAICNDO > 0 && !flag)
								{
									list[j].arrowUp.SetActive(true);
								}
								else
								{
									list[j].arrowUp.SetActive(false);
								}
								bool flag2 = false;
								if (this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[j].PPACJFFFBFB == 1 || flag2 || (this.loungeLoveInterestSpriteFilter != null && this.loungeLoveInterestSpriteFilterHidesOthers && !this.DMAGKGIMPEB(this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[j].PFFCLABCNHI)))
								{
									list[j].gameObject.SetActive(true);
								}
								else
								{
									list[j].gameObject.SetActive(false);
									if (this.loungeLoveInterestSpriteFilter != null)
									{
										if (null != list[j].lockedHeart)
										{
											list[j].lockedHeart.SetActive(false);
										}
										if (null != list[j].unlockedHeart)
										{
											list[j].unlockedHeart.SetActive(true);
										}
										if (null != list[j].orderNumberText)
										{
											list[j].orderNumberText.gameObject.SetActive(true);
										}
										if (null != list[j].percentText && null != list[j].percentText.transform.parent && list[j].percentText.transform.parent.gameObject != list[j].gameObject)
										{
											list[j].percentText.transform.parent.gameObject.SetActive(true);
										}
										if (null != list[j].loungeLooksCountParent)
										{
											int num3 = this.MMNGDKLHANO(this.GKHNIMJJLJL.NCAMFPGMCIG.FKDMPMKBCBL[j].PFFCLABCNHI);
											if (num3 > 1)
											{
												list[j].loungeLooksCountParent.SetActive(false);
												if (null != list[j].loungeLooksCountText)
												{
													list[j].loungeLooksCountText.text = num3.ToString();
												}
											}
											else
											{
												list[j].loungeLooksCountParent.SetActive(false);
											}
										}
									}
									num2 += 0;
								}
							}
						}
					}
				}
				else
				{
					gameObject.SetActive(false);
				}
			}
			catch (Exception aklgbjkdomm)
			{
				gameObject.SetActive(true);
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
	}

	// Token: 0x06000CF9 RID: 3321 RVA: 0x00003E52 File Offset: 0x00002052
	private void GFMFGEEFCDG()
	{
	}

	// Token: 0x06000CFA RID: 3322 RVA: 0x0005E9B8 File Offset: 0x0005CBB8
	private void OnDisable()
	{
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnApplicationFocusBasicSyncSuccess", new UnityAction(this.OnApplicationFocusBasicSyncSuccess));
	}

	// Token: 0x06000CFB RID: 3323 RVA: 0x0005E9D5 File Offset: 0x0005CBD5
	private void AHNLGNMJMGL()
	{
		if (this.prefabVersion == 1)
		{
			return;
		}
		if (this.CAKPNECIJNA)
		{
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryInterfaceHeaderAutoReadEnable", 0f);
			return;
		}
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryInterfaceHeaderAutoReadDisable", 0f);
	}

	// Token: 0x06000CFC RID: 3324 RVA: 0x0005EA12 File Offset: 0x0005CC12
	private void OnEnable()
	{
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnApplicationFocusBasicSyncSuccess", new UnityAction(this.OnApplicationFocusBasicSyncSuccess));
	}

	// Token: 0x06000CFD RID: 3325 RVA: 0x0005EA30 File Offset: 0x0005CC30
	private void FNPPBICAOPG()
	{
		try
		{
			if (!this.NHJKNFODOLE && null != this.gamePassParent && ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass) != null)
			{
				if (null != this.progressImage && this.prefabVersion == 1)
				{
					this.progressImage.GetComponent<RectTransform>().AHLJBONHHKL(0, -89);
				}
				this.OEJDFGDLOKA = this.gamePassParent.GetComponent<CanvasGroup>();
				this.LHJPAIDMPOJ = true;
				this.NHJKNFODOLE = true;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		if (!this.HONPHFEAEKD)
		{
			try
			{
				if (null != this.gamePassInterfaceUndoButtonPrefab)
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.gamePassInterfaceUndoButtonPrefab, base.gameObject.transform.parent.transform.parent.transform, false);
					base.gameObject.transform.parent.transform.parent.gameObject.GetComponent<RectTransform>();
					RectTransform component = gameObject.GetComponent<RectTransform>();
					component.anchorMin = new Vector2(1f, 1f);
					component.anchorMax = new Vector2(1f, 1f);
					component.pivot = new Vector2(1f, 1f);
					component.anchoredPosition = Vector2.zero;
					this.KEFIFKNOBHN = gameObject.GetComponent<StoryInterfaceChoiceUndo>();
					this.HONPHFEAEKD = true;
				}
			}
			catch (Exception aklgbjkdomm2)
			{
				this.KEFIFKNOBHN = null;
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
			}
		}
	}

	// Token: 0x06000CFE RID: 3326 RVA: 0x0005EBA8 File Offset: 0x0005CDA8
	private void IPIOELOIGHF()
	{
		if (this.prefabVersion == 1)
		{
			return;
		}
		if (this.JFAEJFAJEGP)
		{
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryInterfaceHeaderFastForwardEnable", 0f);
			return;
		}
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryInterfaceHeaderFastForwardDisable", 0f);
	}

	// Token: 0x06000CFF RID: 3327 RVA: 0x0005EBE5 File Offset: 0x0005CDE5
	public void RefreshGamePass()
	{
		this.GAEKGJEDFHG();
	}

	// Token: 0x06000D00 RID: 3328 RVA: 0x0005EBF0 File Offset: 0x0005CDF0
	public void LLGNKBIJOOG()
	{
		if (null != this.OEJDFGDLOKA && null != this.PANMNKKODPC && (this.OEJDFGDLOKA.alpha < 1240f || this.PANMNKKODPC.alpha < 273f))
		{
			return;
		}
		this.HHODFMEPEAI();
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.POCMDCOEABL(CLHDENLPOFP.gamePass);
		if (null != this.gamePassParent && kioojmglclc != null)
		{
			if (kioojmglclc.FAAEIDEIPGB())
			{
				CommonUserInterface.IKNOFBFMPGA().ShowGenericPopup(CCOJBMMKNAP.KMNBCEMEBBD().FCOCLEHKLDJ(" "), CCOJBMMKNAP.CEGAOMEEFBE().PPALCPINPLK("+"), CCOJBMMKNAP.KLAKLFCOMJC().HPOAGPJFHPM("generalBalance"), (DFGILFBGPLN)(-19), 269f, -59);
				return;
			}
			FPFNLJGEIJK.FIBNFNACDBE((BGHLMGPPCNN)(-15));
			CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.GIOAFDDKKHI().JLBEIFLLBLO("-"), CCOJBMMKNAP.ILACPHFEDEP().FIENAKIHNOM("achiev"), CCOJBMMKNAP.COKDLDOAACJ().IPEIONBNIPH(">"), CCOJBMMKNAP.PMABBOJDELF().GLEFEKBDHNK("ok"), new UnityAction(this.PMIEIFKANGO), new UnityAction(this.GFMFGEEFCDG), (DFGILFBGPLN)(-12), 308f, -40);
		}
	}

	// Token: 0x06000D01 RID: 3329 RVA: 0x0005ED1B File Offset: 0x0005CF1B
	public void OnApplicationFocusBasicSyncSuccess()
	{
		this.GAEKGJEDFHG();
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnGamePassRefillSuccess", 0f);
	}

	// Token: 0x06000D02 RID: 3330 RVA: 0x0005ED38 File Offset: 0x0005CF38
	public void LPEJAPFALKL()
	{
		try
		{
			if (this.prefabVersion != 1)
			{
				KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.POCMDCOEABL(CLHDENLPOFP.eventPass);
				if (kioojmglclc != null)
				{
					if (kioojmglclc.FAAEIDEIPGB() && AKLFPGMDKLA.EHBBFMCILPC.MEDFMIPBDFD == 1)
					{
						this.JFAEJFAJEGP = (AKLFPGMDKLA.EHBBFMCILPC.MEDFMIPBDFD == 1);
						this.IPIOELOIGHF();
					}
					else if (kioojmglclc.ALFGPLALKCN() && AKLFPGMDKLA.EHBBFMCILPC.AJLAADOFOLH == 1)
					{
						this.CAKPNECIJNA = (AKLFPGMDKLA.EHBBFMCILPC.AJLAADOFOLH == 1);
						this.AHNLGNMJMGL();
					}
					if (null != this.KEFIFKNOBHN)
					{
						if (kioojmglclc.GILNCHJJKJL())
						{
							this.KEFIFKNOBHN.JCBICBLFKKJ(kioojmglclc.HCBEGPENNLN, kioojmglclc.FAAEIDEIPGB());
						}
						else
						{
							this.KEFIFKNOBHN.GKHKIJMHJOE(1, kioojmglclc.GILNCHJJKJL());
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

	// Token: 0x06000D03 RID: 3331 RVA: 0x0005EE18 File Offset: 0x0005D018
	private IEnumerator KBFGDHGMMMF(int NLMCDLDKFMA)
	{
		yield return new WaitForSeconds(1f);
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(NLMCDLDKFMA))
		{
			this.HHODFMEPEAI();
			AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(NLMCDLDKFMA);
			string dpjinbcgngn = "";
			if (NLMCDLDKFMA == 53)
			{
				dpjinbcgngn = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("gpfastforwardtutorial");
			}
			else if (NLMCDLDKFMA == 54)
			{
				dpjinbcgngn = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("gptompatchestutorial");
			}
			else if (NLMCDLDKFMA == 55)
			{
				dpjinbcgngn = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("gpstatstutorial");
			}
			else if (NLMCDLDKFMA == 72)
			{
				dpjinbcgngn = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("gpautoreadtutorial");
			}
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), dpjinbcgngn, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupStoryLoadError, 0f, 28);
		}
		yield break;
	}

	// Token: 0x06000D04 RID: 3332 RVA: 0x0005EE30 File Offset: 0x0005D030
	public void OnGamePassOptionsSettingsClick()
	{
		if (null != this.NOLDFGGJPEK && null != this.PANMNKKODPC && (this.NOLDFGGJPEK.alpha < 0.9f || this.PANMNKKODPC.alpha < 0.9f))
		{
			return;
		}
		if (this.prefabVersion == 1)
		{
			return;
		}
		this.HHODFMEPEAI();
		CommonUserInterface.EHBBFMCILPC.ShowGamePassSettings();
		this.UpdateGamePassOptions(false, true, false);
	}

	// Token: 0x06000D05 RID: 3333 RVA: 0x0005EE18 File Offset: 0x0005D018
	private IEnumerator PJEKICGNJHD(int NLMCDLDKFMA)
	{
		yield return new WaitForSeconds(1f);
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(NLMCDLDKFMA))
		{
			this.HHODFMEPEAI();
			AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(NLMCDLDKFMA);
			string dpjinbcgngn = "";
			if (NLMCDLDKFMA == 53)
			{
				dpjinbcgngn = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("gpfastforwardtutorial");
			}
			else if (NLMCDLDKFMA == 54)
			{
				dpjinbcgngn = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("gptompatchestutorial");
			}
			else if (NLMCDLDKFMA == 55)
			{
				dpjinbcgngn = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("gpstatstutorial");
			}
			else if (NLMCDLDKFMA == 72)
			{
				dpjinbcgngn = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("gpautoreadtutorial");
			}
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), dpjinbcgngn, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupStoryLoadError, 0f, 28);
		}
		yield break;
	}

	// Token: 0x06000D06 RID: 3334 RVA: 0x0005EEA4 File Offset: 0x0005D0A4
	public void OLMKMGELAFI()
	{
		if (null != this.OEJDFGDLOKA && null != this.PANMNKKODPC && (this.OEJDFGDLOKA.alpha < 1860f || this.PANMNKKODPC.alpha < 831f))
		{
			return;
		}
		this.HHODFMEPEAI();
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.JOACGOLGGNH(CLHDENLPOFP.eventPass);
		if (null != this.gamePassParent && kioojmglclc != null)
		{
			if (kioojmglclc.GILNCHJJKJL())
			{
				string text = CCOJBMMKNAP.EHBBFMCILPC.BGELFMIOBCL("");
				text = text.Replace("There are no story splash managers!", DPGJIJGOCIC.FCICBOLGHDA(kioojmglclc.MJGADKGJCKC(), true, false) ?? "OnCollectableDialogUsed");
				text = text.Replace("OnAllCollectableCardsDownloadFailed", DPGJIJGOCIC.LMLGDPDIGAI(kioojmglclc.LIPCEMCDPID(), true, true) ?? "focuswardrobebody");
				CommonUserInterface.IKNOFBFMPGA().NFBMHHPIGFA(CCOJBMMKNAP.HFAKOKBHCGH().PGKBCNBAOJN("OnLiveProfileThemesLoaderStart"), text, CCOJBMMKNAP.BFHKGNBFHCH().GLEFEKBDHNK("abcp"), (DFGILFBGPLN)92, 762f, 37);
				return;
			}
			FPFNLJGEIJK.FIBNFNACDBE((BGHLMGPPCNN)(-24));
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.PLJMLDOCPNM().JLBEIFLLBLO(" "), CCOJBMMKNAP.KNKGCDDMLDP().HHLECNIFHCO("<align=\"center\"><i><alpha=#88>"), CCOJBMMKNAP.PEBMGCKFNAO().HPOAGPJFHPM("p"), CCOJBMMKNAP.MLFAGAAJJEM().PPALCPINPLK("SceneLobbyManager2.OnLiveProfileThumbnailsCdnSuccess(): resident="), new UnityAction(this.PMIEIFKANGO), new UnityAction(this.GFMFGEEFCDG), (DFGILFBGPLN)(-54), 350f, -85);
		}
	}

	// Token: 0x06000D07 RID: 3335 RVA: 0x0005F01E File Offset: 0x0005D21E
	private void HBPLGJFPFKM()
	{
		CommonUserInterface.EHBBFMCILPC.ShowGamePasses();
	}

	// Token: 0x06000D08 RID: 3336 RVA: 0x0005F02A File Offset: 0x0005D22A
	private void CCNFPNFDNDP()
	{
		AOBJLALDBAA.CEGAOMEEFBE().PFAHGKEDFAE("YYY", new UnityAction(this.OnApplicationFocusBasicSyncSuccess));
	}

	// Token: 0x06000D09 RID: 3337 RVA: 0x0005F047 File Offset: 0x0005D247
	public void CAHFOLOOIFJ(PLFDAJJHMKO BAOKJBJIFBH)
	{
		this.GKHNIMJJLJL = BAOKJBJIFBH;
	}

	// Token: 0x06000D0A RID: 3338 RVA: 0x0005F050 File Offset: 0x0005D250
	public void OnSettingsClick()
	{
		if (this.DPNFENJDCEO)
		{
			return;
		}
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryInterfaceHeaderSettingsClick", 0f);
	}

	// Token: 0x06000D0B RID: 3339 RVA: 0x0005F070 File Offset: 0x0005D270
	public bool Hide()
	{
		if (!base.gameObject.activeSelf)
		{
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryInterfaceHeaderHideComplete", 0f);
			return false;
		}
		this.BAMHPOCKBML();
		if (this.NOJPGANKFDP != null)
		{
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryInterfaceHeaderHideComplete", 0f);
			return false;
		}
		if (null != this.PANMNKKODPC && this.PANMNKKODPC.alpha < 0.01f && this.LFCIBEEKAPP == null)
		{
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryInterfaceHeaderHideComplete", 0f);
			return false;
		}
		if (this.LFCIBEEKAPP != null)
		{
			base.StopCoroutine(this.LFCIBEEKAPP);
			this.LFCIBEEKAPP = null;
		}
		this.NOJPGANKFDP = base.StartCoroutine(this.MPCGAMEDJGB());
		return true;
	}

	// Token: 0x06000D0C RID: 3340 RVA: 0x0005F130 File Offset: 0x0005D330
	public void OnGamePassIconClick()
	{
		if (null != this.OEJDFGDLOKA && null != this.PANMNKKODPC && (this.OEJDFGDLOKA.alpha < 0.9f || this.PANMNKKODPC.alpha < 0.9f))
		{
			return;
		}
		this.HHODFMEPEAI();
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass);
		if (null != this.gamePassParent && kioojmglclc != null)
		{
			if (kioojmglclc.ALFGPLALKCN())
			{
				string text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("passhintactivesub");
				text = text.Replace("XXX", DPGJIJGOCIC.LCOMEDGJNMP(kioojmglclc.FHHLFACIIDF(), false, true) ?? "");
				text = text.Replace("YYY", DPGJIJGOCIC.LCOMEDGJNMP(kioojmglclc.FOIOENCOCEE(), true, true) ?? "");
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupStoryLoadError, 0f, 28);
				return;
			}
			FPFNLJGEIJK.FIBNFNACDBE(BGHLMGPPCNN.subHint);
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("passhintinactivesub"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("no"), new UnityAction(this.PMIEIFKANGO), new UnityAction(this.GFMFGEEFCDG), DFGILFBGPLN.popupSignInQuestion, 0f, 28);
		}
	}

	// Token: 0x06000D0D RID: 3341 RVA: 0x0005F2AC File Offset: 0x0005D4AC
	private void OnDestroy()
	{
		this.GFIKBJKDMIC = null;
		this.HDLPCMDOECJ = null;
		if (this.LFCIBEEKAPP != null)
		{
			base.StopCoroutine(this.LFCIBEEKAPP);
		}
		if (this.NOJPGANKFDP != null)
		{
			base.StopCoroutine(this.NOJPGANKFDP);
		}
		if (this.NGFAMMBEDKI != null)
		{
			base.StopCoroutine(this.NGFAMMBEDKI);
		}
		this.LFCIBEEKAPP = null;
		this.NOJPGANKFDP = null;
		this.NGFAMMBEDKI = null;
	}

	// Token: 0x06000D0E RID: 3342 RVA: 0x0005F318 File Offset: 0x0005D518
	public void ACOFGKCNHBE()
	{
		if (null != this.imageProgressParent)
		{
			this.imageProgressParent.SetActive(false);
		}
	}

	// Token: 0x06000D0F RID: 3343 RVA: 0x0005F334 File Offset: 0x0005D534
	public void OnGamePassOptionsRewindClick()
	{
		if (null != this.NOLDFGGJPEK && null != this.PANMNKKODPC && (this.NOLDFGGJPEK.alpha < 0.9f || this.PANMNKKODPC.alpha < 0.9f))
		{
			return;
		}
		if (this.prefabVersion == 1)
		{
			return;
		}
		this.HHODFMEPEAI();
		if (ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass, true) == null)
		{
			FPFNLJGEIJK.FIBNFNACDBE(BGHLMGPPCNN.subRewind);
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("rewindsubrequired"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("no"), new UnityAction(this.PMIEIFKANGO), new UnityAction(this.GFMFGEEFCDG), DFGILFBGPLN.popupSignInQuestion, 0f, 28);
			return;
		}
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryInterfaceHeaderRewindClick", 0f);
	}

	// Token: 0x06000D10 RID: 3344 RVA: 0x0005F421 File Offset: 0x0005D621
	public void OnBackClick()
	{
		if (this.DPNFENJDCEO)
		{
			return;
		}
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryInterfaceHeaderBackClick", 0f);
	}

	// Token: 0x06000D11 RID: 3345 RVA: 0x0005F440 File Offset: 0x0005D640
	private int MMNGDKLHANO(string HAPADEOFKBP)
	{
		if (this.loungeLoveInterestSpriteFilter == null || this.loungeLoveInterestSpriteFilterCounts == null || HAPADEOFKBP == null)
		{
			return 0;
		}
		int num = 0;
		while (num < this.loungeLoveInterestSpriteFilter.Count && num < this.loungeLoveInterestSpriteFilterCounts.Count)
		{
			if (this.loungeLoveInterestSpriteFilter[num].Equals(HAPADEOFKBP))
			{
				return this.loungeLoveInterestSpriteFilterCounts[num];
			}
			num++;
		}
		return 0;
	}

	// Token: 0x06000D12 RID: 3346 RVA: 0x0005F4A8 File Offset: 0x0005D6A8
	public void SetLoungeCurrenciesText(string DIMBCOBNMAM)
	{
		if (null == this.textCurrencies)
		{
			return;
		}
		bool flag = DIMBCOBNMAM != null && DIMBCOBNMAM.Length > 0;
		if (null != this.currenciesParent)
		{
			this.currenciesParent.SetActive(flag);
		}
		else
		{
			this.textCurrencies.gameObject.SetActive(flag);
		}
		if (flag)
		{
			this.textCurrencies.SetText(DIMBCOBNMAM, true);
		}
	}

	// Token: 0x06000D13 RID: 3347 RVA: 0x0005F514 File Offset: 0x0005D714
	public void OnGamePassOptionsWardrobeClick()
	{
		if (null != this.NOLDFGGJPEK && null != this.PANMNKKODPC && (this.NOLDFGGJPEK.alpha < 0.9f || this.PANMNKKODPC.alpha < 0.9f))
		{
			return;
		}
		if (this.prefabVersion == 1)
		{
			return;
		}
		FJLGCKNOJMJ fjlgcknojmj = null;
		if (null != AssetsManager.EHBBFMCILPC && null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
		{
			fjlgcknojmj = AssetsManager.EHBBFMCILPC.lobbyDataAsset.MFMJHIFAOHE().ELDKHHGLNBK(StoryInterfaceHeaderManager.anthologyIndex);
		}
		if (fjlgcknojmj != null && !KDCJJBLGCBH.EHBBFMCILPC.NJFAOIDGFGC())
		{
			fjlgcknojmj = null;
		}
		if (fjlgcknojmj != null && fjlgcknojmj.PPACJFFFBFB && SceneStoryManager.AnyLoungeCharacterInActiveWardrobe())
		{
			this.HHODFMEPEAI();
			this.UpdateGamePassOptions(false, true, false);
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnNeedToOpenLoveInterestsLounge", 0f);
			return;
		}
		if (fjlgcknojmj == null || !fjlgcknojmj.PPACJFFFBFB)
		{
			this.HHODFMEPEAI();
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("comingsoontitle3"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("loungeindevelopment"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupStoryLoadError, 0f, 28);
			this.UpdateGamePassOptions(false, true, false);
			return;
		}
		this.HHODFMEPEAI();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("loungenotavailable"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupStoryLoadError, 0f, 28);
		this.UpdateGamePassOptions(false, true, false);
	}

	// Token: 0x06000D14 RID: 3348 RVA: 0x0005F69A File Offset: 0x0005D89A
	public void FLCIHDPNIKC()
	{
		this.GAEKGJEDFHG();
		AOBJLALDBAA.FILDBDMENPG().EGELHPJBAIC(", index:", 1381f);
	}

	// Token: 0x06000D15 RID: 3349 RVA: 0x0005F6B8 File Offset: 0x0005D8B8
	private void Update()
	{
		if (null != this.PANMNKKODPC)
		{
			float num = this.PANMNKKODPC.alpha;
			if (num <= 0.01f)
			{
				num = 0f;
			}
			else
			{
				num = 1f;
			}
			if (this.prefabVersion == 1)
			{
				if (null != this.KEFIFKNOBHN && this.KEFIFKNOBHN.buttonAction.activeSelf && NBDLBFJOEGN.LAIDCKNIOIN() > 1.4444444f)
				{
					if (this.NHJKNFODOLE)
					{
						this.KEFIFKNOBHN.OffsetVertical(num, -230f);
					}
					else
					{
						this.KEFIFKNOBHN.OffsetVertical(num, -141f);
					}
				}
				if (this.LFCIBEEKAPP != null || this.PANMNKKODPC.alpha > 0.01f)
				{
					BlurOptimized.verticalOffsetForRenderTargetMorphGradient = 0.5f;
				}
			}
			else
			{
				this.KKGIFMKLMDM = -210;
				if (this.NHJKNFODOLE)
				{
					this.KKGIFMKLMDM -= 89;
				}
				if (null != this.statsParent && this.statsParent.activeSelf)
				{
					this.KKGIFMKLMDM -= 74;
				}
				if (null != this.statsParent2 && this.statsParent2.activeSelf)
				{
					this.KKGIFMKLMDM -= 74;
				}
				if ((null != this.loveInterestsParent && this.loveInterestsParent.activeSelf) || (null != this.loveInterestsParent2 && this.loveInterestsParent2.activeSelf))
				{
					this.KKGIFMKLMDM -= 121;
					if (this.AEFMHHIMKFC > 5)
					{
						this.KKGIFMKLMDM -= this.AEFMHHIMKFC / 5 * 121;
					}
				}
				if (null != this.KEFIFKNOBHN && this.KEFIFKNOBHN.buttonAction.activeSelf && NBDLBFJOEGN.LAIDCKNIOIN() > 1.4444444f)
				{
					this.KEFIFKNOBHN.OffsetVertical(num, (float)this.KKGIFMKLMDM);
				}
				this.EDCJODKDNPG = Mathf.Clamp01((float)Mathf.Abs(this.KKGIFMKLMDM) / 1366f) + 0.2f;
				if (this.LFCIBEEKAPP != null || this.PANMNKKODPC.alpha > 0.01f)
				{
					BlurOptimized.verticalOffsetForRenderTargetMorphGradient = this.EDCJODKDNPG;
				}
			}
		}
		if (this.prefabVersion > 1)
		{
			if (null != this.NOLDFGGJPEK && (this.NOLDFGGJPEK.alpha < 0.9f || this.PANMNKKODPC.alpha < 0.9f))
			{
				if (null != this.loveInterestsParentCanvasGroup && null != this.loveInterestsParent && this.loveInterestsParent.activeSelf)
				{
					this.loveInterestsParentCanvasGroup.interactable = false;
				}
				if (null != this.loveInterestsParentCanvasGroup2 && null != this.loveInterestsParent2 && this.loveInterestsParent2.activeSelf)
				{
					this.loveInterestsParentCanvasGroup2.interactable = false;
				}
				if (null != this.statsParentCanvasGroup && null != this.statsParent && this.statsParent.activeSelf)
				{
					this.statsParentCanvasGroup.interactable = false;
				}
				if (null != this.statsParentCanvasGroup2 && null != this.statsParent2 && this.statsParent2.activeSelf)
				{
					this.statsParentCanvasGroup2.interactable = false;
					return;
				}
			}
			else
			{
				if (null != this.loveInterestsParentCanvasGroup && null != this.loveInterestsParent && this.loveInterestsParent.activeSelf)
				{
					this.loveInterestsParentCanvasGroup.interactable = true;
				}
				if (null != this.loveInterestsParentCanvasGroup2 && null != this.loveInterestsParent2 && this.loveInterestsParent2.activeSelf)
				{
					this.loveInterestsParentCanvasGroup2.interactable = true;
				}
				if (null != this.statsParentCanvasGroup && null != this.statsParent && this.statsParent.activeSelf)
				{
					this.statsParentCanvasGroup.interactable = true;
				}
				if (null != this.statsParentCanvasGroup2 && null != this.statsParent2 && this.statsParent2.activeSelf)
				{
					this.statsParentCanvasGroup2.interactable = true;
				}
			}
		}
	}

	// Token: 0x06000D16 RID: 3350 RVA: 0x0005FAE4 File Offset: 0x0005DCE4
	public void UpdateWardrobeNewLooksDisc(bool FLKLLLNENKG)
	{
		if (null == this.wardrobeNewLooksDisc)
		{
			return;
		}
		int num = 0;
		try
		{
			if (FLKLLLNENKG)
			{
				num = NIDOKPOOIHH.ALLBOOMIFNM(StoryInterfaceHeaderManager.anthologyIndex, AKLFPGMDKLA.EHBBFMCILPC.NBMLMNGHOPP());
			}
			if (num > 0 && null != this.wardrobeNewLooksText)
			{
				this.wardrobeNewLooksText.SetText(Mathf.Min(num, 99).ToString() ?? "", true);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			num = 0;
		}
		this.wardrobeNewLooksDisc.SetActive(num > 0);
	}

	// Token: 0x06000D17 RID: 3351 RVA: 0x0005FB7C File Offset: 0x0005DD7C
	public void OnGamePassDiscountClick()
	{
		if (null != this.OEJDFGDLOKA && null != this.PANMNKKODPC && (this.OEJDFGDLOKA.alpha < 0.9f || this.PANMNKKODPC.alpha < 0.9f))
		{
			return;
		}
		this.HHODFMEPEAI();
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass);
		if (null != this.gamePassParent && kioojmglclc != null)
		{
			if (kioojmglclc.ALFGPLALKCN())
			{
				string text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("passhintdiscount");
				text = text.Replace("XXX", KDCJJBLGCBH.EHBBFMCILPC.AAGICPKFIKC(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG(kioojmglclc.LLLJOBODOAL), DAMCJCDKOJK.gpbpEndDiscount, 1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString() + "%");
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupStoryLoadError, 0f, 28);
				return;
			}
			FPFNLJGEIJK.FIBNFNACDBE(BGHLMGPPCNN.subHint);
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("passhintinactivesub"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("no"), new UnityAction(this.PMIEIFKANGO), new UnityAction(this.GFMFGEEFCDG), DFGILFBGPLN.popupSignInQuestion, 0f, 28);
		}
	}

	// Token: 0x06000D18 RID: 3352 RVA: 0x0005FCF2 File Offset: 0x0005DEF2
	public bool IsPaused()
	{
		return this.DPNFENJDCEO;
	}

	// Token: 0x06000D19 RID: 3353 RVA: 0x0005FCFC File Offset: 0x0005DEFC
	private void BAMHPOCKBML()
	{
		if (this.JIEPCIDINEH)
		{
			return;
		}
		this.JIEPCIDINEH = true;
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 0f;
		}
		this.JNIDFGCGGMF = base.gameObject.GetComponent<AnimationCanvasGroupAlpha>();
		try
		{
			GameObject gameObject = DPGJIJGOCIC.OCHAFIFOBOD(base.gameObject, "ButtonBack");
			if (null != gameObject)
			{
				gameObject.AddComponent<SystemBackButtonManager>();
				gameObject.GetComponent<SystemBackButtonManager>().checkAgainstSemaphoreTag = JLDJNIGMHLC.popups;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000D1A RID: 3354 RVA: 0x0005FDA0 File Offset: 0x0005DFA0
	public bool IsVisible()
	{
		return !(null != this.PANMNKKODPC) || this.PANMNKKODPC.alpha >= 0.1f;
	}

	// Token: 0x06000D1B RID: 3355 RVA: 0x0005FCF2 File Offset: 0x0005DEF2
	public bool EHLFLGKONOM()
	{
		return this.DPNFENJDCEO;
	}

	// Token: 0x06000D1C RID: 3356 RVA: 0x0005FDC5 File Offset: 0x0005DFC5
	private IEnumerator MPCGAMEDJGB()
	{
		yield return new WaitForSeconds(0.1f);
		this.LFCIBEEKAPP = null;
		if (null != this.JNIDFGCGGMF && null != this.PANMNKKODPC && this.PANMNKKODPC.alpha > 0f)
		{
			this.JNIDFGCGGMF.SetDirection(true);
			this.JNIDFGCGGMF.PlayAnimation(false);
		}
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryInterfaceHeaderHideComplete", 0f);
		yield return new WaitForSeconds(1f);
		if (null != this.gamePassParent)
		{
			ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass);
		}
		this.NOJPGANKFDP = null;
		yield break;
	}

	// Token: 0x06000D1D RID: 3357 RVA: 0x0005FDD4 File Offset: 0x0005DFD4
	private void PIECFIJCGEH()
	{
		if (this.prefabVersion == 0)
		{
			return;
		}
		if (this.CAKPNECIJNA)
		{
			AOBJLALDBAA.EHBBFMCILPC.EFBNBFIDEOK("\"", 1078f);
			return;
		}
		AOBJLALDBAA.EHBBFMCILPC.EFBNBFIDEOK("{", 426f);
	}

	// Token: 0x06000D1E RID: 3358 RVA: 0x0005FE11 File Offset: 0x0005E011
	public void ResumeEvents()
	{
		this.DPNFENJDCEO = false;
	}

	// Token: 0x06000D1F RID: 3359 RVA: 0x0005FE1A File Offset: 0x0005E01A
	public void POFFMICMDDC()
	{
		this.DPNFENJDCEO = true;
	}

	// Token: 0x06000D20 RID: 3360 RVA: 0x0005FE24 File Offset: 0x0005E024
	private void Awake()
	{
		if (null != this.currenciesParent)
		{
			this.currenciesParent.SetActive(false);
		}
		else if (null != this.textCurrencies)
		{
			this.textCurrencies.gameObject.SetActive(false);
		}
		try
		{
			if (null != this.progressImage && this.prefabVersion == 1)
			{
				this.progressImage.GetComponent<RectTransform>().AHLJBONHHKL(-18, 0);
			}
			this.FNPPBICAOPG();
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000D21 RID: 3361 RVA: 0x0005F047 File Offset: 0x0005D247
	public void SetCurrentStorySave(PLFDAJJHMKO BAOKJBJIFBH)
	{
		this.GKHNIMJJLJL = BAOKJBJIFBH;
	}

	// Token: 0x06000D22 RID: 3362 RVA: 0x0005E3BB File Offset: 0x0005C5BB
	public void UpdateStatsData(LDLLJFOJCDF[] AIIEPMPDLMM, List<Sprite> NEDFFHHECOB)
	{
		this.GFIKBJKDMIC = AIIEPMPDLMM;
		this.HDLPCMDOECJ = NEDFFHHECOB;
	}

	// Token: 0x06000D23 RID: 3363 RVA: 0x0005FE1A File Offset: 0x0005E01A
	public void PauseEvents()
	{
		this.DPNFENJDCEO = true;
	}

	// Token: 0x06000D24 RID: 3364 RVA: 0x0005FEB8 File Offset: 0x0005E0B8
	public void OnGamePassOptionsFastForwardClick()
	{
		if (null != this.NOLDFGGJPEK && null != this.PANMNKKODPC && (this.NOLDFGGJPEK.alpha < 0.9f || this.PANMNKKODPC.alpha < 0.9f))
		{
			return;
		}
		if (this.prefabVersion == 1)
		{
			return;
		}
		this.HHODFMEPEAI();
		if (ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass, true) == null)
		{
			FPFNLJGEIJK.FIBNFNACDBE(BGHLMGPPCNN.subFwd);
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("gpforwardsubrequired"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("no"), new UnityAction(this.PMIEIFKANGO), new UnityAction(this.GFMFGEEFCDG), DFGILFBGPLN.popupSignInQuestion, 0f, 28);
		}
		else
		{
			this.JFAEJFAJEGP = !this.JFAEJFAJEGP;
			if (this.JFAEJFAJEGP && this.CAKPNECIJNA)
			{
				this.CAKPNECIJNA = false;
				this.AHNLGNMJMGL();
			}
			this.IPIOELOIGHF();
			this.BMLHEAMOOLN(53);
			if (null != this.optionsParent)
			{
				base.StartCoroutine(this.LHNMEHHAPAO(this.optionsParent.transform.parent.GetComponent<RectTransform>()));
			}
		}
		this.UpdateGamePassOptions(false, true, false);
	}

	// Token: 0x06000D25 RID: 3365 RVA: 0x00060005 File Offset: 0x0005E205
	private IEnumerator LHNMEHHAPAO(RectTransform DGAAFGDHHHJ)
	{
		yield return new WaitForEndOfFrame();
		LayoutRebuilder.ForceRebuildLayoutImmediate(DGAAFGDHHHJ);
		yield break;
	}

	// Token: 0x06000D26 RID: 3366 RVA: 0x0005D32F File Offset: 0x0005B52F
	public void FNDBHPHMMJA()
	{
		if (null != this.imageProgressParent)
		{
			this.imageProgressParent.SetActive(true);
		}
	}

	// Token: 0x06000D27 RID: 3367 RVA: 0x00060014 File Offset: 0x0005E214
	public void OnGamePassChoicesClick()
	{
		if (null != this.OEJDFGDLOKA && null != this.PANMNKKODPC && (this.OEJDFGDLOKA.alpha < 0.9f || this.PANMNKKODPC.alpha < 0.9f))
		{
			return;
		}
		this.HHODFMEPEAI();
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass);
		if (null != this.gamePassParent && kioojmglclc != null)
		{
			if (kioojmglclc.ALFGPLALKCN())
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("passhintchoices"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupStoryLoadError, 0f, 28);
				return;
			}
			FPFNLJGEIJK.FIBNFNACDBE(BGHLMGPPCNN.subHint);
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("passhintinactivesub"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("no"), new UnityAction(this.PMIEIFKANGO), new UnityAction(this.GFMFGEEFCDG), DFGILFBGPLN.popupSignInQuestion, 0f, 28);
		}
	}

	// Token: 0x06000D28 RID: 3368 RVA: 0x00060140 File Offset: 0x0005E340
	public void OnGamePassOptionsStatsClick()
	{
		if (null != this.NOLDFGGJPEK && null != this.PANMNKKODPC && (this.NOLDFGGJPEK.alpha < 0.9f || this.PANMNKKODPC.alpha < 0.9f))
		{
			return;
		}
		if (this.prefabVersion == 1)
		{
			return;
		}
		this.HHODFMEPEAI();
		this.BILONLBLEFL = !this.BILONLBLEFL;
		this.BLLHDCHOGJD();
		this.BMLHEAMOOLN(55);
		if (null != this.optionsParent)
		{
			base.StartCoroutine(this.LHNMEHHAPAO(this.optionsParent.transform.parent.GetComponent<RectTransform>()));
		}
		this.UpdateGamePassOptions(false, true, false);
	}

	// Token: 0x06000D29 RID: 3369 RVA: 0x0005F01E File Offset: 0x0005D21E
	private void IDMHLICAGKG()
	{
		CommonUserInterface.EHBBFMCILPC.ShowGamePasses();
	}

	// Token: 0x06000D2A RID: 3370 RVA: 0x000601F4 File Offset: 0x0005E3F4
	public bool FBBNDAJBJMG()
	{
		return null != this.PANMNKKODPC && this.PANMNKKODPC.alpha < 992f && false;
	}

	// Token: 0x06000D2B RID: 3371 RVA: 0x0006021C File Offset: 0x0005E41C
	public void OpenLoungeForLoveInterestSprite(string HAPADEOFKBP)
	{
		try
		{
			if (this.prefabVersion != 1)
			{
				SceneLoungeManager.SetPendingLoungeCharacter(SceneLoungeManager.GetLoungeCharacterOidForSprite(HAPADEOFKBP));
				FJLGCKNOJMJ fjlgcknojmj = null;
				if (null != AssetsManager.EHBBFMCILPC && null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
				{
					fjlgcknojmj = AssetsManager.EHBBFMCILPC.lobbyDataAsset.MFMJHIFAOHE().ELDKHHGLNBK(StoryInterfaceHeaderManager.anthologyIndex);
				}
				if (fjlgcknojmj != null && !KDCJJBLGCBH.EHBBFMCILPC.NJFAOIDGFGC())
				{
					fjlgcknojmj = null;
				}
				if (fjlgcknojmj != null && fjlgcknojmj.PPACJFFFBFB && SceneStoryManager.AnyLoungeCharacterInActiveWardrobe())
				{
					this.HHODFMEPEAI();
					this.UpdateGamePassOptions(false, true, false);
					AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnNeedToOpenLoveInterestsLounge", 0f);
				}
				else if (fjlgcknojmj == null || !fjlgcknojmj.PPACJFFFBFB)
				{
					SceneLoungeManager.SetPendingLoungeCharacter(null);
					this.HHODFMEPEAI();
					CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("comingsoontitle3"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("loungeindevelopment"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupStoryLoadError, 0f, 28);
					this.UpdateGamePassOptions(false, true, false);
				}
				else
				{
					SceneLoungeManager.SetPendingLoungeCharacter(null);
					this.HHODFMEPEAI();
					CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("loungenotavailable"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupStoryLoadError, 0f, 28);
					this.UpdateGamePassOptions(false, true, false);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000D2C RID: 3372 RVA: 0x000603A8 File Offset: 0x0005E5A8
	public void PrewarmComponents()
	{
		try
		{
			if (this.prefabVersion != 1)
			{
				KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass);
				if (kioojmglclc != null)
				{
					if (kioojmglclc.ALFGPLALKCN() && AKLFPGMDKLA.EHBBFMCILPC.MEDFMIPBDFD == 1)
					{
						this.JFAEJFAJEGP = (AKLFPGMDKLA.EHBBFMCILPC.MEDFMIPBDFD == 1);
						this.IPIOELOIGHF();
					}
					else if (kioojmglclc.ALFGPLALKCN() && AKLFPGMDKLA.EHBBFMCILPC.AJLAADOFOLH == 1)
					{
						this.CAKPNECIJNA = (AKLFPGMDKLA.EHBBFMCILPC.AJLAADOFOLH == 1);
						this.AHNLGNMJMGL();
					}
					if (null != this.KEFIFKNOBHN)
					{
						if (kioojmglclc.ALFGPLALKCN())
						{
							this.KEFIFKNOBHN.SetText(kioojmglclc.HCBEGPENNLN, kioojmglclc.ALFGPLALKCN());
						}
						else
						{
							this.KEFIFKNOBHN.SetText(0, kioojmglclc.ALFGPLALKCN());
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

	// Token: 0x06000D2D RID: 3373 RVA: 0x00060488 File Offset: 0x0005E688
	public bool EHPFCDFFMIM()
	{
		return this.LFCIBEEKAPP == null && this.FBBNDAJBJMG();
	}

	// Token: 0x06000D2E RID: 3374 RVA: 0x0006049C File Offset: 0x0005E69C
	public void Show(float JFCAINFOEHJ = 0f)
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		this.BAMHPOCKBML();
		try
		{
			if (null != this.progressText)
			{
				JFCAINFOEHJ = Mathf.Clamp(JFCAINFOEHJ, 0f, 1f);
				int num = (int)(JFCAINFOEHJ * 102f);
				if (num > 100)
				{
					num = 100;
				}
				if (JFCAINFOEHJ <= 1E-05f)
				{
					this.progressText.gameObject.SetActive(false);
				}
				else
				{
					this.progressText.gameObject.SetActive(true);
					this.progressText.text = num.ToString() + "%";
					this.progressText.SetText(num.ToString() + "%", true);
				}
				if (null != this.progressImage)
				{
					this.progressImage.SetActive(this.progressText.gameObject.activeSelf);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		if (this.LFCIBEEKAPP != null)
		{
			this.GAEKGJEDFHG();
			return;
		}
		if (null != this.PANMNKKODPC && this.PANMNKKODPC.alpha > 0.01f && this.NOJPGANKFDP == null)
		{
			return;
		}
		if (this.NOJPGANKFDP != null)
		{
			base.StopCoroutine(this.NOJPGANKFDP);
			this.NOJPGANKFDP = null;
		}
		this.LFCIBEEKAPP = base.StartCoroutine(this.GACBCOCNEPL());
	}

	// Token: 0x06000D2F RID: 3375 RVA: 0x00060600 File Offset: 0x0005E800
	private void BMLHEAMOOLN(int NLMCDLDKFMA)
	{
		base.StartCoroutine(this.KBFGDHGMMMF(NLMCDLDKFMA));
	}

	// Token: 0x06000D30 RID: 3376 RVA: 0x00060610 File Offset: 0x0005E810
	public void OnGamePassOptionsAutoReadClick()
	{
		if (null != this.NOLDFGGJPEK && null != this.PANMNKKODPC && (this.NOLDFGGJPEK.alpha < 0.9f || this.PANMNKKODPC.alpha < 0.9f))
		{
			return;
		}
		if (this.prefabVersion == 1)
		{
			return;
		}
		this.HHODFMEPEAI();
		if (ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass, true) == null)
		{
			FPFNLJGEIJK.FIBNFNACDBE(BGHLMGPPCNN.subAuto);
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("gpautoreadsubrequired"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("no"), new UnityAction(this.PMIEIFKANGO), new UnityAction(this.GFMFGEEFCDG), DFGILFBGPLN.popupSignInQuestion, 0f, 28);
		}
		else
		{
			this.CAKPNECIJNA = !this.CAKPNECIJNA;
			if (this.CAKPNECIJNA && this.JFAEJFAJEGP)
			{
				this.JFAEJFAJEGP = false;
				this.IPIOELOIGHF();
			}
			this.AHNLGNMJMGL();
			this.BMLHEAMOOLN(72);
			if (null != this.optionsParent)
			{
				base.StartCoroutine(this.LHNMEHHAPAO(this.optionsParent.transform.parent.GetComponent<RectTransform>()));
			}
		}
		this.UpdateGamePassOptions(false, true, false);
	}

	// Token: 0x06000D31 RID: 3377 RVA: 0x00060760 File Offset: 0x0005E960
	public void OnGamePassChoiceStateClick()
	{
		if (null != this.OEJDFGDLOKA && null != this.PANMNKKODPC && (this.OEJDFGDLOKA.alpha < 0.9f || this.PANMNKKODPC.alpha < 0.9f))
		{
			return;
		}
		this.HHODFMEPEAI();
	}

	// Token: 0x06000D32 RID: 3378 RVA: 0x000607B4 File Offset: 0x0005E9B4
	public bool IsTouchInside(bool ILCNGGNKPDK)
	{
		return (!(null != this.otherParent) || this.otherParent.activeSelf) && ((null != this.gamePassParent && this.gamePassParent.activeSelf && DPGJIJGOCIC.DIMKKLMJMLI(this.gamePassParent, ILCNGGNKPDK)) || (null != this.optionsParent && this.optionsParent.activeSelf && DPGJIJGOCIC.DIMKKLMJMLI(this.optionsParent, ILCNGGNKPDK)) || (null != this.loveInterestsParent && this.loveInterestsParent.activeSelf && DPGJIJGOCIC.DIMKKLMJMLI(this.loveInterestsParent, ILCNGGNKPDK)) || (null != this.loveInterestsParent2 && this.loveInterestsParent2.activeSelf && DPGJIJGOCIC.DIMKKLMJMLI(this.loveInterestsParent2, ILCNGGNKPDK)) || (null != this.statsParent && this.statsParent.activeSelf && DPGJIJGOCIC.DIMKKLMJMLI(this.statsParent, ILCNGGNKPDK)) || (null != this.statsParent2 && this.statsParent2.activeSelf && DPGJIJGOCIC.DIMKKLMJMLI(this.statsParent2, ILCNGGNKPDK)));
	}

	// Token: 0x06000D33 RID: 3379 RVA: 0x000608E4 File Offset: 0x0005EAE4
	private bool DMAGKGIMPEB(string HAPADEOFKBP)
	{
		if (this.loungeLoveInterestSpriteFilter == null)
		{
			return true;
		}
		if (HAPADEOFKBP == null)
		{
			return false;
		}
		for (int i = 0; i < this.loungeLoveInterestSpriteFilter.Count; i++)
		{
			if (this.loungeLoveInterestSpriteFilter[i].Equals(HAPADEOFKBP))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000D34 RID: 3380 RVA: 0x0005F318 File Offset: 0x0005D518
	public void HideProgressForLounge()
	{
		if (null != this.imageProgressParent)
		{
			this.imageProgressParent.SetActive(false);
		}
	}

	// Token: 0x040003FC RID: 1020
	public const string onStoryInterfaceHeaderFastForwardEnable = "OnStoryInterfaceHeaderFastForwardEnable";

	// Token: 0x040003FD RID: 1021
	public const string onStoryInterfaceHeaderFastForwardDisable = "OnStoryInterfaceHeaderFastForwardDisable";

	// Token: 0x040003FE RID: 1022
	public const string onStoryInterfaceHeaderAutoReadEnable = "OnStoryInterfaceHeaderAutoReadEnable";

	// Token: 0x040003FF RID: 1023
	public const string onStoryInterfaceHeaderAutoReadDisable = "OnStoryInterfaceHeaderAutoReadDisable";

	// Token: 0x04000400 RID: 1024
	public const string onStoryInterfaceHeaderShowStart = "OnStoryInterfaceHeaderShowStart";

	// Token: 0x04000401 RID: 1025
	public const string onStoryInterfaceHeaderHideComplete = "OnStoryInterfaceHeaderHideComplete";

	// Token: 0x04000402 RID: 1026
	public const string onStoryInterfaceHeaderBackClick = "OnStoryInterfaceHeaderBackClick";

	// Token: 0x04000403 RID: 1027
	public const string onStoryInterfaceHeaderShopClick = "OnStoryInterfaceHeaderShopClick";

	// Token: 0x04000404 RID: 1028
	public const string onStoryInterfaceHeaderAvatarClick = "OnStoryInterfaceHeaderAvatarClick";

	// Token: 0x04000405 RID: 1029
	public const string onStoryInterfaceHeaderSettingsClick = "OnStoryInterfaceHeaderSettingsClick";

	// Token: 0x04000406 RID: 1030
	public const string onStoryInterfaceHeaderShown = "OnStoryInterfaceHeaderShown";

	// Token: 0x04000407 RID: 1031
	public const string onStoryInterfaceHeaderRewindClick = "OnStoryInterfaceHeaderRewindClick";

	// Token: 0x04000408 RID: 1032
	public const string onGamePassRefillSuccess = "OnGamePassRefillSuccess";

	// Token: 0x04000409 RID: 1033
	public const string onGamePassExpire = "OnGamePassExpire";

	// Token: 0x0400040A RID: 1034
	public static int storyIndex;

	// Token: 0x0400040B RID: 1035
	public static int anthologyIndex;

	// Token: 0x0400040C RID: 1036
	public static bool modalDialogActive;

	// Token: 0x0400040D RID: 1037
	public int prefabVersion = 1;

	// Token: 0x0400040E RID: 1038
	public TextMeshProUGUI progressText;

	// Token: 0x0400040F RID: 1039
	public GameObject progressImage;

	// Token: 0x04000410 RID: 1040
	public GameObject gamePassParent;

	// Token: 0x04000411 RID: 1041
	public GameObject premGamePassActive;

	// Token: 0x04000412 RID: 1042
	public GameObject premGamePassInactive;

	// Token: 0x04000413 RID: 1043
	public GameObject goldGamePassActive;

	// Token: 0x04000414 RID: 1044
	public GameObject goldGamePassInactive;

	// Token: 0x04000415 RID: 1045
	public GameObject gamePassChoices;

	// Token: 0x04000416 RID: 1046
	public TextMeshProUGUI gamePassChoicesText;

	// Token: 0x04000417 RID: 1047
	public GameObject gamePassChoicesVisualChangePos;

	// Token: 0x04000418 RID: 1048
	public GameObject gamePassChoicesVisualChangeNeg;

	// Token: 0x04000419 RID: 1049
	public GameObject gamePassDiscount;

	// Token: 0x0400041A RID: 1050
	public TextMeshProUGUI gamePassDiscountText;

	// Token: 0x0400041B RID: 1051
	public GameObject gamePassDiscountVisualChangePos;

	// Token: 0x0400041C RID: 1052
	public GameObject gamePassDiscountVisualChangeNeg;

	// Token: 0x0400041D RID: 1053
	public GameObject gamePassUndo;

	// Token: 0x0400041E RID: 1054
	public TextMeshProUGUI gamePassUndoText;

	// Token: 0x0400041F RID: 1055
	public GameObject gamePassUndoVisualChangePos;

	// Token: 0x04000420 RID: 1056
	public GameObject gamePassUndoVisualChangeNeg;

	// Token: 0x04000421 RID: 1057
	public GameObject gamePassEvent;

	// Token: 0x04000422 RID: 1058
	public GameObject gamePassChoiceState;

	// Token: 0x04000423 RID: 1059
	public GameObject gamePassInterfaceUndoButtonPrefab;

	// Token: 0x04000424 RID: 1060
	public GameObject otherParent;

	// Token: 0x04000425 RID: 1061
	public GameObject optionsParent;

	// Token: 0x04000426 RID: 1062
	public GameObject loveInterestsParent;

	// Token: 0x04000427 RID: 1063
	public GameObject loveInterestsParent2;

	// Token: 0x04000428 RID: 1064
	public GameObject statsParent;

	// Token: 0x04000429 RID: 1065
	public GameObject statsParent2;

	// Token: 0x0400042A RID: 1066
	public CanvasGroup loveInterestsParentCanvasGroup;

	// Token: 0x0400042B RID: 1067
	public CanvasGroup loveInterestsParentCanvasGroup2;

	// Token: 0x0400042C RID: 1068
	public CanvasGroup statsParentCanvasGroup;

	// Token: 0x0400042D RID: 1069
	public CanvasGroup statsParentCanvasGroup2;

	// Token: 0x0400042E RID: 1070
	public List<StoryInterfaceLoveInterestManager> loveInterests = new List<StoryInterfaceLoveInterestManager>();

	// Token: 0x0400042F RID: 1071
	public List<StoryInterfaceLoveInterestManager> loveInterests2 = new List<StoryInterfaceLoveInterestManager>();

	// Token: 0x04000430 RID: 1072
	public List<Image> statsIcons = new List<Image>();

	// Token: 0x04000431 RID: 1073
	public List<Image> statsIcons2 = new List<Image>();

	// Token: 0x04000432 RID: 1074
	public List<TextMeshProUGUI> statsTexts = new List<TextMeshProUGUI>();

	// Token: 0x04000433 RID: 1075
	public List<TextMeshProUGUI> statsTexts2 = new List<TextMeshProUGUI>();

	// Token: 0x04000434 RID: 1076
	public VariableVisualStateManager settingsButton;

	// Token: 0x04000435 RID: 1077
	public VariableVisualStateManager fastForwardButton;

	// Token: 0x04000436 RID: 1078
	public VariableVisualStateManager autoReadButton;

	// Token: 0x04000437 RID: 1079
	public VariableVisualStateManager loveInterestsButton;

	// Token: 0x04000438 RID: 1080
	public VariableVisualStateManager wardrobeButton;

	// Token: 0x04000439 RID: 1081
	public GameObject wardrobeNewLooksDisc;

	// Token: 0x0400043A RID: 1082
	public TextMeshProUGUI wardrobeNewLooksText;

	// Token: 0x0400043B RID: 1083
	public VariableVisualStateManager statsButton;

	// Token: 0x0400043C RID: 1084
	public VariableVisualStateManager rewindButton;

	// Token: 0x0400043D RID: 1085
	public TextMeshProUGUI textCurrencies;

	// Token: 0x0400043E RID: 1086
	public GameObject currenciesParent;

	// Token: 0x0400043F RID: 1087
	public GameObject imageProgressParent;

	// Token: 0x04000440 RID: 1088
	private CanvasGroup PANMNKKODPC;

	// Token: 0x04000441 RID: 1089
	private CanvasGroup OEJDFGDLOKA;

	// Token: 0x04000442 RID: 1090
	private CanvasGroup NOLDFGGJPEK;

	// Token: 0x04000443 RID: 1091
	private AnimationCanvasGroupAlpha JNIDFGCGGMF;

	// Token: 0x04000444 RID: 1092
	private Coroutine LFCIBEEKAPP;

	// Token: 0x04000445 RID: 1093
	private Coroutine NOJPGANKFDP;

	// Token: 0x04000446 RID: 1094
	private Coroutine NGFAMMBEDKI;

	// Token: 0x04000447 RID: 1095
	private bool JIEPCIDINEH;

	// Token: 0x04000448 RID: 1096
	private bool DPNFENJDCEO;

	// Token: 0x04000449 RID: 1097
	private bool LHJPAIDMPOJ;

	// Token: 0x0400044A RID: 1098
	private bool NHJKNFODOLE;

	// Token: 0x0400044B RID: 1099
	private bool HONPHFEAEKD;

	// Token: 0x0400044C RID: 1100
	private StoryInterfaceChoiceUndo KEFIFKNOBHN;

	// Token: 0x0400044D RID: 1101
	private bool OBABJMAPBKB;

	// Token: 0x0400044E RID: 1102
	private PLFDAJJHMKO GKHNIMJJLJL;

	// Token: 0x0400044F RID: 1103
	private LDLLJFOJCDF[] GFIKBJKDMIC;

	// Token: 0x04000450 RID: 1104
	private List<Sprite> HDLPCMDOECJ;

	// Token: 0x04000451 RID: 1105
	private bool BILONLBLEFL;

	// Token: 0x04000452 RID: 1106
	private bool JFAEJFAJEGP;

	// Token: 0x04000453 RID: 1107
	private bool MPNCAPPPEHN;

	// Token: 0x04000454 RID: 1108
	private bool BLLCLBOEDEK;

	// Token: 0x04000455 RID: 1109
	[NonSerialized]
	public List<string> loungeLoveInterestSpriteFilter;

	// Token: 0x04000456 RID: 1110
	[NonSerialized]
	public List<int> loungeLoveInterestSpriteFilterCounts;

	// Token: 0x04000457 RID: 1111
	[NonSerialized]
	public bool loungeLoveInterestSpriteFilterHidesOthers;

	// Token: 0x04000458 RID: 1112
	private bool CAKPNECIJNA;

	// Token: 0x04000459 RID: 1113
	private bool APJOBILCHHF = true;

	// Token: 0x0400045A RID: 1114
	private int KKGIFMKLMDM;

	// Token: 0x0400045B RID: 1115
	private float LLKJBKBBFJO;

	// Token: 0x0400045C RID: 1116
	private int AEFMHHIMKFC;

	// Token: 0x0400045D RID: 1117
	private float EDCJODKDNPG;
}
