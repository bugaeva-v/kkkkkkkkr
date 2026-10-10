using System;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000022 RID: 34
public class LobbyRewardsPopover : MonoBehaviour
{
	// Token: 0x060004D1 RID: 1233 RVA: 0x0001FE8E File Offset: 0x0001E08E
	public bool IsOpen()
	{
		return base.gameObject.activeSelf;
	}

	// Token: 0x060004D2 RID: 1234 RVA: 0x0001FE9C File Offset: 0x0001E09C
	public void CBAGDMNJHOD()
	{
		try
		{
			if (base.gameObject.activeSelf)
			{
				this.JIEPMODHKLH();
				if (null != this.panelGroup)
				{
					this.LENGAFMIMAH = this.panelGroup.DOFade(623f, 962f).SetEase(Ease.Unset).OnComplete(new TweenCallback(this.DJOIJKEEPBH));
				}
				else
				{
					this.DJOIJKEEPBH();
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060004D3 RID: 1235 RVA: 0x0001FF20 File Offset: 0x0001E120
	public void OnCatcherClick()
	{
		if (null != CommonUserInterface.EHBBFMCILPC && CommonUserInterface.EHBBFMCILPC.AnyGenericPopupIsActive())
		{
			return;
		}
		this.Hide();
	}

	// Token: 0x060004D4 RID: 1236 RVA: 0x0001FF42 File Offset: 0x0001E142
	public void OnRewardsRowClick()
	{
		if (null == this.lobby)
		{
			return;
		}
		this.Hide();
		this.lobby.OnRewardsButtonClick();
	}

	// Token: 0x060004D5 RID: 1237 RVA: 0x0001FF64 File Offset: 0x0001E164
	public void FHNAHADIDND()
	{
		if (base.gameObject.activeSelf)
		{
			this.CBAGDMNJHOD();
			return;
		}
		this.AKHDMIEEEHF();
	}

	// Token: 0x060004D6 RID: 1238 RVA: 0x0001FF80 File Offset: 0x0001E180
	private void GLLDFBGBLCM()
	{
		try
		{
			this.DPLKKJEBHMN();
			this.EMHCFFODJDB();
			this.IAAMIDGFBNL();
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060004D7 RID: 1239 RVA: 0x0001FFB8 File Offset: 0x0001E1B8
	public void Toggle()
	{
		if (base.gameObject.activeSelf)
		{
			this.Hide();
			return;
		}
		this.Show();
	}

	// Token: 0x060004D8 RID: 1240 RVA: 0x0001FFD4 File Offset: 0x0001E1D4
	private void BEGLDGPPOHG()
	{
		try
		{
			this.DPLKKJEBHMN();
			this.EMHCFFODJDB();
			this.IAAMIDGFBNL();
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060004D9 RID: 1241 RVA: 0x0002000C File Offset: 0x0001E20C
	public void OnAdRowClick()
	{
		if (null == this.lobby)
		{
			return;
		}
		bool kkbooejhoob = this.KKBOOEJHOOB;
		this.Hide();
		if (kkbooejhoob)
		{
			this.lobby.OnFreeDiamondsClickNotAvaiable();
			return;
		}
		this.lobby.OnFreeDiamondsClick();
	}

	// Token: 0x060004DA RID: 1242 RVA: 0x00020044 File Offset: 0x0001E244
	public void Show()
	{
		try
		{
			this.JIEPMODHKLH();
			base.gameObject.SetActive(true);
			if (null != this.quitBackListener)
			{
				this.quitBackListener.SetActiveLocal(false);
			}
			this.FCLKEALGCDI();
			this.LKDLCABKEGF = DNPIKPDMKKI.MCOMGMOACEM(LJLAENEAOIM.liveOfferCardsVolSale);
			this.GAPNDDFLJKH = 1f;
			if (null != this.lobby)
			{
				this.EAMKALAMNOH = this.lobby.GetIncentAdRewardText();
			}
			this.OHOBACDEOGC();
			this.IECEPFHAGJG();
			this.GLLDFBGBLCM();
			if (null != this.panelGroup)
			{
				this.panelGroup.alpha = 0f;
				this.LENGAFMIMAH = this.panelGroup.DOFade(1f, 0.16f).SetEase(Ease.OutQuad);
			}
			if (null != this.panel)
			{
				this.panel.anchoredPosition = new Vector2(this.panel.anchoredPosition.x, this.AOFMCJDBONK - 14f);
				this.BPNDGPCGLPO = this.panel.DOAnchorPosY(this.AOFMCJDBONK, 0.18f, false).SetEase(Ease.OutCubic);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060004DB RID: 1243 RVA: 0x00020190 File Offset: 0x0001E390
	private void IAAMIDGFBNL()
	{
		if (null == this.shadow || null == this.panel)
		{
			return;
		}
		this.shadow.anchoredPosition = new Vector2(this.panel.anchoredPosition.x + 12f, this.panel.anchoredPosition.y - 12f - 3f);
		this.shadow.sizeDelta = new Vector2(this.panel.rect.width + 24f, this.panel.rect.height + 24f);
	}

	// Token: 0x060004DC RID: 1244 RVA: 0x00020240 File Offset: 0x0001E440
	private void AJNBEANDJJD(TextMeshProUGUI EIFJOAOGKMO, string DIMBCOBNMAM)
	{
		if (null == EIFJOAOGKMO)
		{
			return;
		}
		if (EIFJOAOGKMO.text == DIMBCOBNMAM)
		{
			return;
		}
		EIFJOAOGKMO.enableAutoSizing = false;
		EIFJOAOGKMO.SetText(DIMBCOBNMAM, true);
		float num = 18f;
		float num2 = 15f;
		EIFJOAOGKMO.fontSize = num;
		float width = EIFJOAOGKMO.rectTransform.rect.width;
		while (num > num2 && EIFJOAOGKMO.preferredWidth > width)
		{
			num -= 1f;
			EIFJOAOGKMO.fontSize = num;
		}
	}

	// Token: 0x060004DD RID: 1245 RVA: 0x000202BA File Offset: 0x0001E4BA
	private void FCOHHCJPMIN()
	{
		if (null != this.quitBackListener)
		{
			this.quitBackListener.SetActiveLocal(true);
		}
	}

	// Token: 0x060004DE RID: 1246 RVA: 0x000202D8 File Offset: 0x0001E4D8
	public void AKHDMIEEEHF()
	{
		try
		{
			this.JIEPMODHKLH();
			base.gameObject.SetActive(false);
			if (null != this.quitBackListener)
			{
				this.quitBackListener.GMCJBLPFOJG(false);
			}
			this.FCLKEALGCDI();
			this.LKDLCABKEGF = DNPIKPDMKKI.LNLACJOGCIM(LJLAENEAOIM.liveOfferPass);
			this.GAPNDDFLJKH = 1131f;
			if (null != this.lobby)
			{
				this.EAMKALAMNOH = this.lobby.GetIncentAdRewardText();
			}
			this.OHOBACDEOGC();
			this.IECEPFHAGJG();
			this.CHPGNCJCNBI();
			if (null != this.panelGroup)
			{
				this.panelGroup.alpha = 233f;
				this.LENGAFMIMAH = this.panelGroup.DOFade(1437f, 1773f).SetEase(Ease.Unset);
			}
			if (null != this.panel)
			{
				this.panel.anchoredPosition = new Vector2(this.panel.anchoredPosition.x, this.AOFMCJDBONK - 732f);
				this.BPNDGPCGLPO = this.panel.DOAnchorPosY(this.AOFMCJDBONK, 903f, true).SetEase((Ease)(-8));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060004DF RID: 1247 RVA: 0x00020424 File Offset: 0x0001E624
	public void FEBNMBNOIKA()
	{
		try
		{
			if (base.gameObject.activeSelf)
			{
				this.JIEPMODHKLH();
				if (null != this.panelGroup)
				{
					this.LENGAFMIMAH = this.panelGroup.DOFade(959f, 1642f).SetEase(Ease.OutSine).OnComplete(new TweenCallback(this.HideImmediate));
				}
				else
				{
					this.DJOIJKEEPBH();
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060004E0 RID: 1248 RVA: 0x000204A8 File Offset: 0x0001E6A8
	private void IECEPFHAGJG()
	{
		this.AJNBEANDJJD(this.adTitle, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(542));
		this.AJNBEANDJJD(this.rewardsTitle, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(815));
		if (null != this.rewardsSubtitle)
		{
			this.rewardsSubtitle.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(1285), true);
		}
	}

	// Token: 0x060004E1 RID: 1249 RVA: 0x00020514 File Offset: 0x0001E714
	public void EEOOEDKIBKA()
	{
		try
		{
			if (base.gameObject.activeSelf)
			{
				this.JIEPMODHKLH();
				if (null != this.panelGroup)
				{
					this.LENGAFMIMAH = this.panelGroup.DOFade(762f, 1883f).SetEase(Ease.Linear).OnComplete(new TweenCallback(this.HideImmediate));
				}
				else
				{
					this.DJOIJKEEPBH();
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060004E2 RID: 1250 RVA: 0x00020598 File Offset: 0x0001E798
	public void HideImmediate()
	{
		try
		{
			this.JIEPMODHKLH();
			this.FCOHHCJPMIN();
			if (null != this.panel && this.LMGDKDJFGHJ)
			{
				this.panel.anchoredPosition = new Vector2(this.panel.anchoredPosition.x, this.AOFMCJDBONK);
			}
			base.gameObject.SetActive(false);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060004E3 RID: 1251 RVA: 0x00020614 File Offset: 0x0001E814
	public void DJOIJKEEPBH()
	{
		try
		{
			this.JIEPMODHKLH();
			this.FCOHHCJPMIN();
			if (null != this.panel && this.LMGDKDJFGHJ)
			{
				this.panel.anchoredPosition = new Vector2(this.panel.anchoredPosition.x, this.AOFMCJDBONK);
			}
			base.gameObject.SetActive(false);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060004E4 RID: 1252 RVA: 0x00020690 File Offset: 0x0001E890
	private void KNEOGAFILPE()
	{
		this.GLLDFBGBLCM();
	}

	// Token: 0x060004E5 RID: 1253 RVA: 0x00020698 File Offset: 0x0001E898
	private void LOPLLEMGJFC(TextMeshProUGUI DIMBCOBNMAM, string KIDHBAMJGDO)
	{
		if (null == DIMBCOBNMAM)
		{
			return;
		}
		if (DIMBCOBNMAM.text == KIDHBAMJGDO)
		{
			return;
		}
		DIMBCOBNMAM.SetText(KIDHBAMJGDO, true);
	}

	// Token: 0x060004E6 RID: 1254 RVA: 0x000206BB File Offset: 0x0001E8BB
	private void OnDisable()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		this.JIEPMODHKLH();
		this.FCOHHCJPMIN();
	}

	// Token: 0x060004E7 RID: 1255 RVA: 0x000206D4 File Offset: 0x0001E8D4
	private void DPLKKJEBHMN()
	{
		if (null == this.adRow)
		{
			return;
		}
		if (!KHPGPLAMAIN.ENNJIMIGCKE())
		{
			this.adRow.SetActive(false);
			return;
		}
		this.adRow.SetActive(true);
		this.KKBOOEJHOOB = true;
		if (null != this.lobby && null != this.lobby.notificationFreeDiamonds && this.lobby.notificationFreeDiamonds.activeSelf)
		{
			this.KKBOOEJHOOB = false;
		}
		if (!KHPGPLAMAIN.NGPOHAPMMAI())
		{
			this.KKBOOEJHOOB = true;
		}
		int num = 0;
		if (AKLFPGMDKLA.EHBBFMCILPC != null)
		{
			num = AKLFPGMDKLA.EHBBFMCILPC.KCFMAEFDGPK;
		}
		float alpha = 1f;
		float alpha2 = 1f;
		string kidhbamjgdo;
		if (this.KKBOOEJHOOB)
		{
			alpha = 0.5f;
			alpha2 = 0.6f;
			kidhbamjgdo = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(1284);
		}
		else if (num > 0)
		{
			alpha = 0.7f;
			kidhbamjgdo = DPGJIJGOCIC.DMENNJGBMBH(RewardOption.hardAdFireTime);
		}
		else
		{
			kidhbamjgdo = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(1283);
		}
		if (null != this.adRowGroup)
		{
			this.adRowGroup.alpha = alpha;
		}
		if (null != this.adPillGroup)
		{
			this.adPillGroup.alpha = alpha2;
		}
		this.LOPLLEMGJFC(this.adSubtitle, kidhbamjgdo);
		this.LOPLLEMGJFC(this.adPillText, this.EAMKALAMNOH);
	}

	// Token: 0x060004E8 RID: 1256 RVA: 0x0001FE8E File Offset: 0x0001E08E
	public bool JBBHHBAOJMM()
	{
		return base.gameObject.activeSelf;
	}

	// Token: 0x060004EA RID: 1258 RVA: 0x00020838 File Offset: 0x0001EA38
	private void CHPGNCJCNBI()
	{
		try
		{
			this.DPLKKJEBHMN();
			this.EMHCFFODJDB();
			this.LHGLDNDBNEB();
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060004EB RID: 1259 RVA: 0x00020870 File Offset: 0x0001EA70
	private void LHGLDNDBNEB()
	{
		if (null == this.shadow || null == this.panel)
		{
			return;
		}
		this.shadow.anchoredPosition = new Vector2(this.panel.anchoredPosition.x + 1607f, this.panel.anchoredPosition.y - 1522f - 224f);
		this.shadow.sizeDelta = new Vector2(this.panel.rect.width + 993f, this.panel.rect.height + 291f);
	}

	// Token: 0x060004EC RID: 1260 RVA: 0x0002091E File Offset: 0x0001EB1E
	private void JIEPMODHKLH()
	{
		if (this.LENGAFMIMAH != null)
		{
			this.LENGAFMIMAH.Kill(false);
			this.LENGAFMIMAH = null;
		}
		if (this.BPNDGPCGLPO != null)
		{
			this.BPNDGPCGLPO.Kill(false);
			this.BPNDGPCGLPO = null;
		}
	}

	// Token: 0x060004ED RID: 1261 RVA: 0x00020958 File Offset: 0x0001EB58
	private void EMHCFFODJDB()
	{
		if (null == this.saleRow)
		{
			return;
		}
		this.GAPNDDFLJKH -= Time.deltaTime;
		if (this.LKDLCABKEGF != null && this.LKDLCABKEGF.ONMADEIOOKN == null)
		{
			this.GAPNDDFLJKH = 0f;
		}
		if (this.GAPNDDFLJKH <= 0f)
		{
			this.GAPNDDFLJKH = 1f;
			this.LKDLCABKEGF = DNPIKPDMKKI.MCOMGMOACEM(LJLAENEAOIM.liveOfferCardsVolSale);
		}
		this.LHEJJHNLBAI = false;
		if (this.LKDLCABKEGF != null && this.LKDLCABKEGF.ONMADEIOOKN != null && this.LKDLCABKEGF.ONMADEIOOKN.ODHBINFKIPL() > 60f)
		{
			this.LHEJJHNLBAI = true;
		}
		string text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(1286);
		if (this.LHEJJHNLBAI)
		{
			text = text.Replace("{n}", (this.LKDLCABKEGF.OLNJMJMNBCN() + 1).ToString() ?? "");
			this.LOPLLEMGJFC(this.saleSubtitle, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(1287).Replace("{time}", DPGJIJGOCIC.LCOMEDGJNMP((int)this.LKDLCABKEGF.ONMADEIOOKN.ODHBINFKIPL(), true, false)));
			this.LOPLLEMGJFC(this.salePillText, "-" + this.LKDLCABKEGF.KEJCIIFAJCA().ToString() + "%");
			if (null != this.salePill)
			{
				this.salePill.SetActive(true);
			}
			if (null != this.saleRowButton)
			{
				this.saleRowButton.interactable = true;
			}
			if (null != this.saleRowGroup)
			{
				this.saleRowGroup.alpha = 1f;
			}
		}
		else
		{
			int num = text.IndexOf(" • ", StringComparison.Ordinal);
			if (num > 0)
			{
				text = text.Substring(0, num);
			}
			this.LOPLLEMGJFC(this.saleSubtitle, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(1288));
			if (null != this.salePill)
			{
				this.salePill.SetActive(false);
			}
			if (null != this.saleRowButton)
			{
				this.saleRowButton.interactable = false;
			}
			if (null != this.saleRowGroup)
			{
				this.saleRowGroup.alpha = 0.5f;
			}
		}
		this.AJNBEANDJJD(this.saleTitle, text);
	}

	// Token: 0x060004EE RID: 1262 RVA: 0x00020BA4 File Offset: 0x0001EDA4
	public void OHHFFMMMMAC()
	{
		try
		{
			if (base.gameObject.activeSelf)
			{
				this.JIEPMODHKLH();
				if (null != this.panelGroup)
				{
					this.LENGAFMIMAH = this.panelGroup.DOFade(1881f, 55f).SetEase(Ease.InCubic).OnComplete(new TweenCallback(this.HideImmediate));
				}
				else
				{
					this.DJOIJKEEPBH();
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060004EF RID: 1263 RVA: 0x00020698 File Offset: 0x0001E898
	private void ENKCGOBFJFI(TextMeshProUGUI DIMBCOBNMAM, string KIDHBAMJGDO)
	{
		if (null == DIMBCOBNMAM)
		{
			return;
		}
		if (DIMBCOBNMAM.text == KIDHBAMJGDO)
		{
			return;
		}
		DIMBCOBNMAM.SetText(KIDHBAMJGDO, true);
	}

	// Token: 0x060004F0 RID: 1264 RVA: 0x00020C28 File Offset: 0x0001EE28
	private void HHNCGIFKBHI()
	{
		this.AJNBEANDJJD(this.adTitle, CCOJBMMKNAP.PKEINLPIAEH().LOCMDIBOJKE(41));
		this.AJNBEANDJJD(this.rewardsTitle, CCOJBMMKNAP.PLJMLDOCPNM().GMLHKCGNMIO(100));
		if (null != this.rewardsSubtitle)
		{
			this.rewardsSubtitle.SetText(CCOJBMMKNAP.PEBMGCKFNAO().CKJCKPMBNCA(-174), false);
		}
	}

	// Token: 0x060004F1 RID: 1265 RVA: 0x00020C94 File Offset: 0x0001EE94
	public void DADBLKBIEOK()
	{
		if (null == this.lobby)
		{
			return;
		}
		bool kkbooejhoob = this.KKBOOEJHOOB;
		this.CBAGDMNJHOD();
		if (kkbooejhoob)
		{
			this.lobby.OnFreeDiamondsClickNotAvaiable();
			return;
		}
		this.lobby.OnFreeDiamondsClick();
	}

	// Token: 0x060004F2 RID: 1266 RVA: 0x00020CCC File Offset: 0x0001EECC
	private void OHOBACDEOGC()
	{
		try
		{
			if (!(null == this.saleGemImage) && !(null == AssetsManager.EHBBFMCILPC) && !(null == AssetsManager.EHBBFMCILPC.lobbyDataAsset))
			{
				Sprite sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.DCJKIDEJOAB(2);
				if (null != sprite)
				{
					this.saleGemImage.sprite = sprite;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060004F3 RID: 1267 RVA: 0x00020D48 File Offset: 0x0001EF48
	public void Hide()
	{
		try
		{
			if (base.gameObject.activeSelf)
			{
				this.JIEPMODHKLH();
				if (null != this.panelGroup)
				{
					this.LENGAFMIMAH = this.panelGroup.DOFade(0f, 0.12f).SetEase(Ease.OutQuad).OnComplete(new TweenCallback(this.HideImmediate));
				}
				else
				{
					this.HideImmediate();
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060004F4 RID: 1268 RVA: 0x000206BB File Offset: 0x0001E8BB
	private void GJMIHJNBPEB()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		this.JIEPMODHKLH();
		this.FCOHHCJPMIN();
	}

	// Token: 0x060004F5 RID: 1269 RVA: 0x00020690 File Offset: 0x0001E890
	private void Update()
	{
		this.GLLDFBGBLCM();
	}

	// Token: 0x060004F6 RID: 1270 RVA: 0x00020DCC File Offset: 0x0001EFCC
	private void FCLKEALGCDI()
	{
		if (this.LMGDKDJFGHJ || null == this.panel)
		{
			return;
		}
		this.AOFMCJDBONK = this.panel.anchoredPosition.y;
		this.LMGDKDJFGHJ = true;
	}

	// Token: 0x060004F7 RID: 1271 RVA: 0x00020E02 File Offset: 0x0001F002
	public void OnSaleRowClick()
	{
		if (null == this.lobby || this.LKDLCABKEGF == null || !this.LHEJJHNLBAI)
		{
			return;
		}
		this.Hide();
		this.lobby.OnCardsVolSaleClick();
	}

	// Token: 0x0400013A RID: 314
	public const int textIndexAdSubtitle = 1283;

	// Token: 0x0400013B RID: 315
	public const int textIndexAdNone = 1284;

	// Token: 0x0400013C RID: 316
	public const int textIndexRewardsSubtitle = 1285;

	// Token: 0x0400013D RID: 317
	public const int textIndexSaleTitle = 1286;

	// Token: 0x0400013E RID: 318
	public const int textIndexSaleEnds = 1287;

	// Token: 0x0400013F RID: 319
	public const int textIndexSaleNone = 1288;

	// Token: 0x04000140 RID: 320
	public const int textIndexWatchAd = 542;

	// Token: 0x04000141 RID: 321
	public const int textIndexRewards = 815;

	// Token: 0x04000142 RID: 322
	public const int saleRowRaritySpriteIndex = 2;

	// Token: 0x04000143 RID: 323
	public const float titleFontSize = 18f;

	// Token: 0x04000144 RID: 324
	public const float titleFontSizeMin = 15f;

	// Token: 0x04000145 RID: 325
	private const string OKFGEBMPEJO = " • ";

	// Token: 0x04000146 RID: 326
	private const float INCIEDEMIIO = 60f;

	// Token: 0x04000147 RID: 327
	public SceneLobbyManager2 lobby;

	// Token: 0x04000148 RID: 328
	public RectTransform panel;

	// Token: 0x04000149 RID: 329
	public CanvasGroup panelGroup;

	// Token: 0x0400014A RID: 330
	public GameObject catcher;

	// Token: 0x0400014B RID: 331
	public RectTransform shadow;

	// Token: 0x0400014C RID: 332
	public SystemBackButtonManager quitBackListener;

	// Token: 0x0400014D RID: 333
	public GameObject adRow;

	// Token: 0x0400014E RID: 334
	public CanvasGroup adRowGroup;

	// Token: 0x0400014F RID: 335
	public TextMeshProUGUI adTitle;

	// Token: 0x04000150 RID: 336
	public TextMeshProUGUI adSubtitle;

	// Token: 0x04000151 RID: 337
	public GameObject adPill;

	// Token: 0x04000152 RID: 338
	public TextMeshProUGUI adPillText;

	// Token: 0x04000153 RID: 339
	public CanvasGroup adPillGroup;

	// Token: 0x04000154 RID: 340
	public Button rewardsRowButton;

	// Token: 0x04000155 RID: 341
	public TextMeshProUGUI rewardsTitle;

	// Token: 0x04000156 RID: 342
	public TextMeshProUGUI rewardsSubtitle;

	// Token: 0x04000157 RID: 343
	public GameObject saleRow;

	// Token: 0x04000158 RID: 344
	public Button saleRowButton;

	// Token: 0x04000159 RID: 345
	public CanvasGroup saleRowGroup;

	// Token: 0x0400015A RID: 346
	public TextMeshProUGUI saleTitle;

	// Token: 0x0400015B RID: 347
	public TextMeshProUGUI saleSubtitle;

	// Token: 0x0400015C RID: 348
	public GameObject salePill;

	// Token: 0x0400015D RID: 349
	public TextMeshProUGUI salePillText;

	// Token: 0x0400015E RID: 350
	public Image saleGemImage;

	// Token: 0x0400015F RID: 351
	private GDOKLFCLLIK LKDLCABKEGF;

	// Token: 0x04000160 RID: 352
	private float GAPNDDFLJKH;

	// Token: 0x04000161 RID: 353
	private bool KKBOOEJHOOB;

	// Token: 0x04000162 RID: 354
	private bool LHEJJHNLBAI;

	// Token: 0x04000163 RID: 355
	private string EAMKALAMNOH = "";

	// Token: 0x04000164 RID: 356
	private Tweener LENGAFMIMAH;

	// Token: 0x04000165 RID: 357
	private Tweener BPNDGPCGLPO;

	// Token: 0x04000166 RID: 358
	private float AOFMCJDBONK;

	// Token: 0x04000167 RID: 359
	private bool LMGDKDJFGHJ;

	// Token: 0x04000168 RID: 360
	private const float COOHDGOJHIL = 0.16f;

	// Token: 0x04000169 RID: 361
	private const float EEDBLFNOMFJ = 0.18f;

	// Token: 0x0400016A RID: 362
	private const float HFFPNFJFGGI = 14f;

	// Token: 0x0400016B RID: 363
	private const float MFKPLIMPLDJ = 0.12f;

	// Token: 0x0400016C RID: 364
	private const float CALFLFMOKAJ = 0.7f;

	// Token: 0x0400016D RID: 365
	private const float BMOBOGJMHAK = 0.5f;

	// Token: 0x0400016E RID: 366
	private const float CBIFAFFBPFH = 0.6f;

	// Token: 0x0400016F RID: 367
	private const float IFOKJJOOIFC = 1f;

	// Token: 0x04000170 RID: 368
	private const float MPABEPAFGPM = 12f;

	// Token: 0x04000171 RID: 369
	private const float MNLCFAHIAFP = 3f;
}
