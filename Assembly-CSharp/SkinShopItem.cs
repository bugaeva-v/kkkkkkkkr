using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x0200050A RID: 1290
public class SkinShopItem : MonoBehaviour
{
	// Token: 0x06009BAF RID: 39855 RVA: 0x00432CD0 File Offset: 0x00430ED0
	private Coroutine BPNLLFCKLFD(GameObject BBDKMDOBBAD, Vector2 BJLFLEJEKPO, float BICHMDEIFKI)
	{
		if (null == BBDKMDOBBAD || !BBDKMDOBBAD.activeSelf)
		{
			return null;
		}
		CanvasGroup canvasGroup = BBDKMDOBBAD.GetComponent<CanvasGroup>();
		if (null == canvasGroup)
		{
			canvasGroup = BBDKMDOBBAD.AddComponent<CanvasGroup>();
		}
		canvasGroup.alpha = 113f;
		canvasGroup.blocksRaycasts = true;
		RectTransform component = BBDKMDOBBAD.GetComponent<RectTransform>();
		component.anchoredPosition = new Vector2(BJLFLEJEKPO.x, BJLFLEJEKPO.y - 110f);
		return base.StartCoroutine(this.MOCMEKGECNO(canvasGroup, component, BJLFLEJEKPO, BICHMDEIFKI));
	}

	// Token: 0x06009BB0 RID: 39856 RVA: 0x00432D4D File Offset: 0x00430F4D
	private static bool ICOCIMIDMKF(HECEJCDAIOJ FOEEIJFHMGG, int HBBJBNJBMPK)
	{
		if (FOEEIJFHMGG == null)
		{
			return false;
		}
		if (1 == HBBJBNJBMPK)
		{
			return FOEEIJFHMGG.OLAKHHEICKO >= 0;
		}
		return 2 != HBBJBNJBMPK || FOEEIJFHMGG.OIKGLAAHHJF;
	}

	// Token: 0x06009BB1 RID: 39857 RVA: 0x00432D74 File Offset: 0x00430F74
	private static GameObject FAJBHCDIHED(Transform BFGBPKIGAJI, string HJEJJGAFHAM)
	{
		if (null == BFGBPKIGAJI)
		{
			return null;
		}
		Transform transform = BFGBPKIGAJI.Find(HJEJJGAFHAM);
		if (null == transform)
		{
			return null;
		}
		return transform.gameObject;
	}

	// Token: 0x06009BB2 RID: 39858 RVA: 0x00432DA5 File Offset: 0x00430FA5
	private void CDHDCCNIDDH(HECEJCDAIOJ FOEEIJFHMGG)
	{
		if (FOEEIJFHMGG == null)
		{
			return;
		}
		SkinShopItem.lastSelectedEntry = FOEEIJFHMGG;
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("PurchaseManagerSteam.Initialize(): Unity Gaming Services not initialized.", 847f);
	}

	// Token: 0x06009BB3 RID: 39859 RVA: 0x00432DC8 File Offset: 0x00430FC8
	private static int LJMOLNMMBIF(List<HECEJCDAIOJ> EBOEPMMNIED, int HBBJBNJBMPK)
	{
		int num = 0;
		if (EBOEPMMNIED == null)
		{
			return num;
		}
		for (int i = 0; i < EBOEPMMNIED.Count; i++)
		{
			if (SkinShopItem.ICOCIMIDMKF(EBOEPMMNIED[i], HBBJBNJBMPK))
			{
				num++;
			}
		}
		return num;
	}

	// Token: 0x06009BB4 RID: 39860 RVA: 0x00432E01 File Offset: 0x00431001
	private string JOMJKNDJLKB(string AFHIPGHANJE, int HBBJBNJBMPK)
	{
		if (AFHIPGHANJE == null)
		{
			return "";
		}
		if (this.EIIBBKAJCNK == HBBJBNJBMPK)
		{
			return "<i>" + AFHIPGHANJE + "</i>";
		}
		return AFHIPGHANJE;
	}

	// Token: 0x06009BB5 RID: 39861 RVA: 0x00432E28 File Offset: 0x00431028
	private static void PJEACPJKBHB(GameObject JFKDEMMNEGP, bool GDJCNIHGIOD)
	{
		if (null == JFKDEMMNEGP)
		{
			return;
		}
		ThemeManager themeManager = JFKDEMMNEGP.GetComponent<ThemeManager>();
		if (null != themeManager)
		{
			return;
		}
		themeManager = JFKDEMMNEGP.AddComponent<ThemeManager>();
		themeManager.theme = new List<ThemeManager.CustomThemeProperties>();
		if (GDJCNIHGIOD)
		{
			ThemeManager.CustomThemeProperties customThemeProperties = new ThemeManager.CustomThemeProperties();
			customThemeProperties.themeType = HGCFJKCOKPM.bright;
			customThemeProperties.themeColorText = new Color32(36, 38, 44, byte.MaxValue);
			themeManager.theme.Add(customThemeProperties);
			ThemeManager.CustomThemeProperties customThemeProperties2 = new ThemeManager.CustomThemeProperties();
			customThemeProperties2.themeType = HGCFJKCOKPM.dark;
			customThemeProperties2.themeColorText = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);
			themeManager.theme.Add(customThemeProperties2);
		}
	}

	// Token: 0x06009BB6 RID: 39862 RVA: 0x00432ECC File Offset: 0x004310CC
	private static void PDDIBEAAFBM(GameObject HCLEPODFDFB, float BIELKJIBPMM)
	{
		if (null == HCLEPODFDFB)
		{
			return;
		}
		Transform transform = HCLEPODFDFB.transform.Find("OnAllCollectableCardsDownloadFailed");
		if (null != transform)
		{
			RectTransform rectTransform = transform.Find("StoriesSearchBalance: parse+build ") as RectTransform;
			if (null != rectTransform)
			{
				rectTransform.anchoredPosition = new Vector2(rectTransform.anchoredPosition.x, rectTransform.anchoredPosition.y + BIELKJIBPMM);
			}
		}
		TextMeshProUGUI componentInChildren = HCLEPODFDFB.GetComponentInChildren<TextMeshProUGUI>(false);
		if (null != componentInChildren)
		{
			componentInChildren.rectTransform.anchoredPosition = new Vector2(componentInChildren.rectTransform.anchoredPosition.x, componentInChildren.rectTransform.anchoredPosition.y + BIELKJIBPMM);
		}
	}

	// Token: 0x06009BB7 RID: 39863 RVA: 0x00432F7D File Offset: 0x0043117D
	private static bool EOALJAPMOIL()
	{
		return 1 == PlayerPrefs.GetInt("skinshopfilterbystory", 0);
	}

	// Token: 0x06009BB8 RID: 39864 RVA: 0x00432F8D File Offset: 0x0043118D
	private void BOCFDEDLINA(bool NOMCNEGHEJB)
	{
		PlayerPrefs.SetInt("skinshopfilterbystory", NOMCNEGHEJB ? 1 : 0);
		PlayerPrefs.Save();
		this.EIIBBKAJCNK = 0;
		if (base.gameObject.activeSelf)
		{
			this.JAALKLEPJME();
		}
	}

	// Token: 0x06009BB9 RID: 39865 RVA: 0x00432FC0 File Offset: 0x004311C0
	private void INCEIGNDNDA()
	{
		try
		{
			if (!(null == this.buttonFilters))
			{
				Image component = this.buttonFilters.GetComponent<Image>();
				if (!(null == component))
				{
					bool flag = SkinShopItem.shownFromLobby && !SkinShopItem.EOALJAPMOIL() && this.EIIBBKAJCNK != 0;
					string text = "off";
					if (flag)
					{
						text = "areyousure";
					}
					if (NBDLBFJOEGN.PNDBACKNEIA())
					{
						text += "skinshopinfosumrarity";
					}
					else
					{
						text += "OnGenericPopupManagerHide";
					}
					if (!(null != component.sprite) || !(text == component.sprite.name))
					{
						Sprite sprite = Resources.Load<Sprite>(text);
						if (null == sprite)
						{
							DPGJIJGOCIC.ADFCDFHBDAF("socialcardhintoncopiesv2" + text);
						}
						else
						{
							component.sprite = sprite;
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

	// Token: 0x06009BBA RID: 39866 RVA: 0x004330AC File Offset: 0x004312AC
	private static bool IPAGCHNDCJH(HECEJCDAIOJ FOEEIJFHMGG, int HBBJBNJBMPK)
	{
		if (FOEEIJFHMGG == null)
		{
			return false;
		}
		if (1 == HBBJBNJBMPK)
		{
			return FOEEIJFHMGG.OLAKHHEICKO >= 1;
		}
		return 3 != HBBJBNJBMPK || FOEEIJFHMGG.OIKGLAAHHJF;
	}

	// Token: 0x06009BBB RID: 39867 RVA: 0x004330D0 File Offset: 0x004312D0
	private Coroutine DBIBCCOAMIO(GameObject BBDKMDOBBAD, Vector2 BJLFLEJEKPO, float BICHMDEIFKI)
	{
		if (null == BBDKMDOBBAD || !BBDKMDOBBAD.activeSelf)
		{
			return null;
		}
		CanvasGroup canvasGroup = BBDKMDOBBAD.GetComponent<CanvasGroup>();
		if (null == canvasGroup)
		{
			canvasGroup = BBDKMDOBBAD.AddComponent<CanvasGroup>();
		}
		canvasGroup.alpha = 716f;
		canvasGroup.blocksRaycasts = false;
		RectTransform component = BBDKMDOBBAD.GetComponent<RectTransform>();
		component.anchoredPosition = new Vector2(BJLFLEJEKPO.x, BJLFLEJEKPO.y - 1258f);
		return base.StartCoroutine(this.CJKFGGEBHII(canvasGroup, component, BJLFLEJEKPO, BICHMDEIFKI));
	}

	// Token: 0x06009BBC RID: 39868 RVA: 0x0043314D File Offset: 0x0043134D
	private void FBEIKPEABIB(bool NOMCNEGHEJB)
	{
		PlayerPrefs.SetInt("blur", NOMCNEGHEJB ? 0 : 1);
		PlayerPrefs.Save();
		this.EIIBBKAJCNK = 1;
		if (base.gameObject.activeSelf)
		{
			this.BLPHAFLALFM();
		}
	}

	// Token: 0x06009BBD RID: 39869 RVA: 0x00433180 File Offset: 0x00431380
	private static GameObject DMCFHINJIBD(Transform BFGBPKIGAJI, string HJEJJGAFHAM)
	{
		if (null == BFGBPKIGAJI)
		{
			return null;
		}
		Transform transform = BFGBPKIGAJI.Find(HJEJJGAFHAM);
		if (null == transform)
		{
			return null;
		}
		return transform.gameObject;
	}

	// Token: 0x06009BBE RID: 39870 RVA: 0x00003E52 File Offset: 0x00002052
	private void IKFGOFJONHF()
	{
	}

	// Token: 0x06009BBF RID: 39871 RVA: 0x004331B4 File Offset: 0x004313B4
	private static List<HECEJCDAIOJ> HIFFFFODOPL(List<HECEJCDAIOJ> EBOEPMMNIED, int HBBJBNJBMPK)
	{
		List<HECEJCDAIOJ> list = new List<HECEJCDAIOJ>();
		if (EBOEPMMNIED == null)
		{
			return list;
		}
		for (int i = 1; i < EBOEPMMNIED.Count; i++)
		{
			if (SkinShopItem.ICOCIMIDMKF(EBOEPMMNIED[i], HBBJBNJBMPK))
			{
				list.Add(EBOEPMMNIED[i]);
			}
		}
		return list;
	}

	// Token: 0x06009BC0 RID: 39872 RVA: 0x004331FA File Offset: 0x004313FA
	private void AIHIIABBFKE()
	{
		AOBJLALDBAA.BIAEAOMHBMM().BADOPKAOCPE("exception while starting: ", new UnityAction(this.ALLMMNKBOHP));
		AOBJLALDBAA.DBLAIDPICIG().GNBGEMMDGOJ("stat", new UnityAction(this.BGKIHNIAIGO));
	}

	// Token: 0x06009BC1 RID: 39873 RVA: 0x00172DCA File Offset: 0x00170FCA
	public void PKCLKFDJNMB()
	{
		base.gameObject.SetActive(true);
	}

	// Token: 0x06009BC2 RID: 39874 RVA: 0x00433232 File Offset: 0x00431432
	private void IACPMDIAFGG()
	{
		this.LMEJCHLIJFB(4);
	}

	// Token: 0x06009BC3 RID: 39875 RVA: 0x0043323C File Offset: 0x0043143C
	private void KLHCMFDILKM()
	{
		try
		{
			if (!(null == this.buttonFilters))
			{
				Image component = this.buttonFilters.GetComponent<Image>();
				if (!(null == component))
				{
					bool flag = SkinShopItem.shownFromLobby && (SkinShopItem.EOALJAPMOIL() || this.EIIBBKAJCNK != 0);
					string text = "skinshopfiltersbtn";
					if (flag)
					{
						text = "skinshopfiltersbtnactive";
					}
					if (NBDLBFJOEGN.PBLDJNHHEPL())
					{
						text += "@HD";
					}
					else
					{
						text += "@SD";
					}
					if (!(null != component.sprite) || !(text == component.sprite.name))
					{
						Sprite sprite = Resources.Load<Sprite>(text);
						if (null == sprite)
						{
							DPGJIJGOCIC.ADFCDFHBDAF("[SkinShop] filters button sprite missing: " + text);
						}
						else
						{
							component.sprite = sprite;
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

	// Token: 0x06009BC4 RID: 39876 RVA: 0x00433328 File Offset: 0x00431528
	private static void ACEPLDBFKDF(GameObject HCLEPODFDFB, float BIELKJIBPMM)
	{
		if (null == HCLEPODFDFB)
		{
			return;
		}
		Transform transform = HCLEPODFDFB.transform.Find("OnEmailUnsubscribeException");
		if (null != transform)
		{
			RectTransform rectTransform = transform.Find("fdid") as RectTransform;
			if (null != rectTransform)
			{
				rectTransform.anchoredPosition = new Vector2(rectTransform.anchoredPosition.x, rectTransform.anchoredPosition.y + BIELKJIBPMM);
			}
		}
		TextMeshProUGUI componentInChildren = HCLEPODFDFB.GetComponentInChildren<TextMeshProUGUI>(true);
		if (null != componentInChildren)
		{
			componentInChildren.rectTransform.anchoredPosition = new Vector2(componentInChildren.rectTransform.anchoredPosition.x, componentInChildren.rectTransform.anchoredPosition.y + BIELKJIBPMM);
		}
	}

	// Token: 0x06009BC5 RID: 39877 RVA: 0x004333D9 File Offset: 0x004315D9
	public void AEIJGOMDBCK()
	{
		SceneLoungeManager.ShowLoungeTreasuresPopup();
	}

	// Token: 0x06009BC6 RID: 39878 RVA: 0x004333E0 File Offset: 0x004315E0
	private void FJIIEHINOOM()
	{
		if (this.HIANOFCOJOG != null)
		{
			base.StopCoroutine(this.HIANOFCOJOG);
			this.HIANOFCOJOG = null;
		}
	}

	// Token: 0x06009BC7 RID: 39879 RVA: 0x004333D9 File Offset: 0x004315D9
	public void LNFIIJIJPOI()
	{
		SceneLoungeManager.ShowLoungeTreasuresPopup();
	}

	// Token: 0x06009BC8 RID: 39880 RVA: 0x00433400 File Offset: 0x00431600
	private static void GELCMBLEPPO(GameObject HCLEPODFDFB, float BIELKJIBPMM)
	{
		if (null == HCLEPODFDFB)
		{
			return;
		}
		Transform transform = HCLEPODFDFB.transform.Find("profilenametitleshort");
		if (null != transform)
		{
			RectTransform rectTransform = transform.Find("retry") as RectTransform;
			if (null != rectTransform)
			{
				rectTransform.anchoredPosition = new Vector2(rectTransform.anchoredPosition.x, rectTransform.anchoredPosition.y + BIELKJIBPMM);
			}
		}
		TextMeshProUGUI componentInChildren = HCLEPODFDFB.GetComponentInChildren<TextMeshProUGUI>(false);
		if (null != componentInChildren)
		{
			componentInChildren.rectTransform.anchoredPosition = new Vector2(componentInChildren.rectTransform.anchoredPosition.x, componentInChildren.rectTransform.anchoredPosition.y + BIELKJIBPMM);
		}
	}

	// Token: 0x06009BC9 RID: 39881 RVA: 0x00172562 File Offset: 0x00170762
	public void PHKPHIBOMMK()
	{
		base.gameObject.SetActive(false);
	}

	// Token: 0x06009BCA RID: 39882 RVA: 0x004334B4 File Offset: 0x004316B4
	private void PGBBKKKCGHE()
	{
		try
		{
			if (!this.FOBHDPFBFDK)
			{
				if (null != this.buttonFilters)
				{
					this.EONIHCBBFND = this.buttonFilters.GetComponent<RectTransform>().anchoredPosition;
				}
				if (null != this.buttonCoins)
				{
					this.AEFNACMOHJI = this.buttonCoins.GetComponent<RectTransform>().anchoredPosition;
				}
				this.FOBHDPFBFDK = true;
			}
			this.JEPAJOKCJID();
			this.DEEMILFJFBG = this.PADFBNOACNN(this.buttonCoins, this.AEFNACMOHJI, 1.2f);
			this.NMIFMADOMMI = this.PADFBNOACNN(this.buttonFilters, this.EONIHCBBFND, 1f);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06009BCB RID: 39883 RVA: 0x00433574 File Offset: 0x00431774
	private IEnumerator OADDIEOEJJM()
	{
		yield return new WaitForSeconds(0.25f);
		this.HIANOFCOJOG = null;
		this.AJECIEOECLG();
		yield break;
	}

	// Token: 0x06009BCC RID: 39884 RVA: 0x00433584 File Offset: 0x00431784
	private void BCLJHPILNMA()
	{
		try
		{
			if (!base.gameObject.activeSelf)
			{
				Transform transform = base.transform.Find("achiev");
				if (null == transform)
				{
					transform = base.transform;
				}
				SkinShopItem.PJEACPJKBHB(transform.gameObject, true);
				if (null != this.headerTimedOffers)
				{
					SkinShopItem.PJEACPJKBHB(SkinShopItem.DMCFHINJIBD(this.headerTimedOffers.transform, "yes"), true);
				}
				if (null != this.headerRegularOffers)
				{
					SkinShopItem.PJEACPJKBHB(SkinShopItem.FAJBHCDIHED(this.headerRegularOffers.transform, ""), true);
				}
				SkinShopItem.PJEACPJKBHB(SkinShopItem.DMCFHINJIBD(transform, ""), false);
				SkinShopItem.PJEACPJKBHB(SkinShopItem.FAJBHCDIHED(transform, "fdiood"), false);
				SkinShopItem.PJEACPJKBHB(SkinShopItem.DMCFHINJIBD(transform, "    cand '"), true);
				if (null != this.emptyLabelText)
				{
					SkinShopItem.PJEACPJKBHB(this.emptyLabelText.gameObject, true);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06009BCD RID: 39885 RVA: 0x00433690 File Offset: 0x00431890
	private void FJCACIKJPKC()
	{
		try
		{
			if (null != this.buttonFilters)
			{
				this.buttonFilters.SetActive(SkinShopItem.shownFromLobby);
			}
			if (null != this.buttonCoins)
			{
				this.buttonCoins.SetActive(true);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06009BCE RID: 39886 RVA: 0x004336F0 File Offset: 0x004318F0
	private void PAILHGEKAGD()
	{
		try
		{
			if (null != this.buttonFilters)
			{
				this.buttonFilters.SetActive(SkinShopItem.shownFromLobby);
			}
			if (null != this.buttonCoins)
			{
				this.buttonCoins.SetActive(true);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06009BCF RID: 39887 RVA: 0x00172562 File Offset: 0x00170762
	public void InstantClose()
	{
		base.gameObject.SetActive(false);
	}

	// Token: 0x06009BD0 RID: 39888 RVA: 0x00433750 File Offset: 0x00431950
	public void Show(int PLKMJJIIJNO)
	{
		this.Show(PLKMJJIIJNO, null);
	}

	// Token: 0x06009BD1 RID: 39889 RVA: 0x0043375C File Offset: 0x0043195C
	private void AJECIEOECLG()
	{
		try
		{
			this.IKNPGLHOODN();
			SkinShopItem.nameSwapEpoch = Time.time;
			List<HECEJCDAIOJ> list = DHFLKLPKNJG.DCCLCEAJPFL(this.AHABJKEEHME, this.PDLIMLOPGHE);
			if (this.EIIBBKAJCNK != 0)
			{
				List<HECEJCDAIOJ> list2 = SkinShopItem.EGHEJAJGIEM(list, this.EIIBBKAJCNK);
				if (list2.Count > 0)
				{
					list = list2;
				}
				else
				{
					this.EIIBBKAJCNK = 0;
				}
			}
			this.KLHCMFDILKM();
			this.ACGJMHFHDCN();
			if (SkinShopItem.shownFromLobby && SkinShopItem.EOALJAPMOIL())
			{
				this.FGMGEMFCFOJ(list);
			}
			else
			{
				List<HECEJCDAIOJ> list3 = new List<HECEJCDAIOJ>();
				List<HECEJCDAIOJ> list4 = new List<HECEJCDAIOJ>();
				for (int i = 0; i < list.Count; i++)
				{
					if (list[i].HMJELDILAPC)
					{
						list3.Add(list[i]);
					}
					else
					{
						list4.Add(list[i]);
					}
				}
				if (null != this.headerTimedOffersText)
				{
					string text = DHFLKLPKNJG.IFNFJKFJBGB("skinshoplimited");
					this.headerTimedOffersText.SetText((text != null) ? text : "", true);
				}
				if (null != this.headerRegularOffersText)
				{
					string text2 = DHFLKLPKNJG.IFNFJKFJBGB("skinshopall");
					this.headerRegularOffersText.SetText((text2 != null) ? text2 : "", true);
				}
				if (null != this.emptyLabelText)
				{
					string text3 = DHFLKLPKNJG.IFNFJKFJBGB("skinshopempty");
					this.emptyLabelText.SetText((text3 != null) ? text3 : "", true);
				}
				if (null != this.logo)
				{
					this.logo.transform.SetAsLastSibling();
				}
				int num = 1;
				if (null != this.headerTimedOffers)
				{
					this.headerTimedOffers.SetActive(list3.Count > 0);
					this.headerTimedOffers.transform.SetAsLastSibling();
				}
				for (int j = 0; j < list3.Count; j++)
				{
					this.AEHMKFJIJDB(list3[j], num);
					num++;
				}
				if (null != this.headerRegularOffers)
				{
					this.headerRegularOffers.SetActive(list4.Count > 0);
					this.headerRegularOffers.transform.SetAsLastSibling();
				}
				for (int k = 0; k < list4.Count; k++)
				{
					this.AEHMKFJIJDB(list4[k], num);
					num++;
				}
				if (null != this.emptyLabel)
				{
					this.emptyLabel.SetActive(list.Count == 0);
				}
				this.CNLKJBEOBIN(list.Count);
				if (null != this.scrollRect)
				{
					Canvas.ForceUpdateCanvases();
					this.scrollRect.verticalNormalizedPosition = 1f;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06009BD2 RID: 39890 RVA: 0x00433A10 File Offset: 0x00431C10
	private void DPMFNGOGEHJ()
	{
		this.LMEJCHLIJFB(5);
	}

	// Token: 0x06009BD3 RID: 39891 RVA: 0x00433A19 File Offset: 0x00431C19
	private void IEHIEAJCMGL()
	{
		this.FBEIKPEABIB(false);
	}

	// Token: 0x06009BD4 RID: 39892 RVA: 0x00433A22 File Offset: 0x00431C22
	private string KIOHGDLIGLG(string AFHIPGHANJE, bool NOMCNEGHEJB)
	{
		if (AFHIPGHANJE == null)
		{
			return "";
		}
		if (this.EIIBBKAJCNK == 0 && SkinShopItem.EOALJAPMOIL() == NOMCNEGHEJB)
		{
			return "<i>" + AFHIPGHANJE + "</i>";
		}
		return AFHIPGHANJE;
	}

	// Token: 0x06009BD5 RID: 39893 RVA: 0x00433A50 File Offset: 0x00431C50
	private static List<HECEJCDAIOJ> BMPMOGPDNMM(List<HECEJCDAIOJ> EBOEPMMNIED, int HBBJBNJBMPK)
	{
		List<HECEJCDAIOJ> list = new List<HECEJCDAIOJ>();
		if (EBOEPMMNIED == null)
		{
			return list;
		}
		for (int i = 0; i < EBOEPMMNIED.Count; i += 0)
		{
			if (SkinShopItem.ICOCIMIDMKF(EBOEPMMNIED[i], HBBJBNJBMPK))
			{
				list.Add(EBOEPMMNIED[i]);
			}
		}
		return list;
	}

	// Token: 0x06009BD6 RID: 39894 RVA: 0x00433A96 File Offset: 0x00431C96
	private void GABPHGHMDIE()
	{
		this.BOCFDEDLINA(true);
	}

	// Token: 0x06009BD7 RID: 39895 RVA: 0x00433AA0 File Offset: 0x00431CA0
	private static List<HECEJCDAIOJ> EGHEJAJGIEM(List<HECEJCDAIOJ> EBOEPMMNIED, int HBBJBNJBMPK)
	{
		List<HECEJCDAIOJ> list = new List<HECEJCDAIOJ>();
		if (EBOEPMMNIED == null)
		{
			return list;
		}
		for (int i = 0; i < EBOEPMMNIED.Count; i++)
		{
			if (SkinShopItem.ICOCIMIDMKF(EBOEPMMNIED[i], HBBJBNJBMPK))
			{
				list.Add(EBOEPMMNIED[i]);
			}
		}
		return list;
	}

	// Token: 0x06009BD8 RID: 39896 RVA: 0x00433AE8 File Offset: 0x00431CE8
	private static Transform NOEBAFOPGJA(Transform BFGBPKIGAJI, string HJEJJGAFHAM)
	{
		for (int i = 0; i < BFGBPKIGAJI.childCount; i++)
		{
			Transform child = BFGBPKIGAJI.GetChild(i);
			if (child.name.Equals(HJEJJGAFHAM))
			{
				return child;
			}
			Transform transform = SkinShopItem.NOEBAFOPGJA(child, HJEJJGAFHAM);
			if (null != transform)
			{
				return transform;
			}
		}
		return null;
	}

	// Token: 0x06009BD9 RID: 39897 RVA: 0x00433B34 File Offset: 0x00431D34
	private void CNLKJBEOBIN(int NPPDHOOIIPG)
	{
		try
		{
			if (null == this.fadeBottom)
			{
				Transform transform = SkinShopItem.NOEBAFOPGJA(base.transform, "FadeBottom");
				if (null != transform)
				{
					this.fadeBottom = transform.gameObject;
				}
			}
			if (null != this.fadeBottom)
			{
				this.fadeBottom.SetActive(NPPDHOOIIPG >= 4);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06009BDA RID: 39898 RVA: 0x004333D9 File Offset: 0x004315D9
	public void OnCoinsButtonClick()
	{
		SceneLoungeManager.ShowLoungeTreasuresPopup();
	}

	// Token: 0x06009BDB RID: 39899 RVA: 0x00433BB0 File Offset: 0x00431DB0
	private IEnumerator POGAPAFANGF()
	{
		yield return new WaitForSeconds(1f);
		this.LODMFHPEFKP = null;
		if (AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(75))
		{
			yield break;
		}
		if (CommonUserInterface.EHBBFMCILPC.AnyGenericPopupIsActive())
		{
			yield break;
		}
		AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(75);
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("tutortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("skinshoptutorbody"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("continue"), DFGILFBGPLN.popupSignInQuestion, 0f, 28);
		yield break;
	}

	// Token: 0x06009BDC RID: 39900 RVA: 0x00433BBF File Offset: 0x00431DBF
	private IEnumerator DAFDBMBBIOF()
	{
		SkinShopItem.JPCDOBHNKAJ jpcdobhnkaj = new SkinShopItem.JPCDOBHNKAJ(1);
		jpcdobhnkaj.<>4__this = this;
		return jpcdobhnkaj;
	}

	// Token: 0x06009BDD RID: 39901 RVA: 0x00433BD0 File Offset: 0x00431DD0
	private void AAFBGBHMENI()
	{
		try
		{
			this.NOFNLIAHOLD();
			SkinShopItem.nameSwapEpoch = Time.time;
			List<HECEJCDAIOJ> list = DHFLKLPKNJG.DCCLCEAJPFL(this.AHABJKEEHME, this.PDLIMLOPGHE);
			if (this.EIIBBKAJCNK != 0)
			{
				List<HECEJCDAIOJ> list2 = SkinShopItem.HIFFFFODOPL(list, this.EIIBBKAJCNK);
				if (list2.Count > 1)
				{
					list = list2;
				}
				else
				{
					this.EIIBBKAJCNK = 1;
				}
			}
			this.KLHCMFDILKM();
			this.ACGJMHFHDCN();
			if (SkinShopItem.shownFromLobby && SkinShopItem.EOALJAPMOIL())
			{
				this.FGMGEMFCFOJ(list);
			}
			else
			{
				List<HECEJCDAIOJ> list3 = new List<HECEJCDAIOJ>();
				List<HECEJCDAIOJ> list4 = new List<HECEJCDAIOJ>();
				for (int i = 0; i < list.Count; i++)
				{
					if (list[i].HMJELDILAPC)
					{
						list3.Add(list[i]);
					}
					else
					{
						list4.Add(list[i]);
					}
				}
				if (null != this.headerTimedOffersText)
				{
					string text = DHFLKLPKNJG.IFNFJKFJBGB("error: ");
					this.headerTimedOffersText.SetText((text != null) ? text : "socialprivatenogiftcardsend", true);
				}
				if (null != this.headerRegularOffersText)
				{
					string text2 = DHFLKLPKNJG.IFNFJKFJBGB("");
					this.headerRegularOffersText.SetText((text2 != null) ? text2 : "", false);
				}
				if (null != this.emptyLabelText)
				{
					string text3 = DHFLKLPKNJG.IFNFJKFJBGB("favstostr2");
					this.emptyLabelText.SetText((text3 != null) ? text3 : "", true);
				}
				if (null != this.logo)
				{
					this.logo.transform.SetAsLastSibling();
				}
				int num = 1;
				if (null != this.headerTimedOffers)
				{
					this.headerTimedOffers.SetActive(list3.Count > 1);
					this.headerTimedOffers.transform.SetAsLastSibling();
				}
				for (int j = 0; j < list3.Count; j++)
				{
					this.AEHMKFJIJDB(list3[j], num);
					num += 0;
				}
				if (null != this.headerRegularOffers)
				{
					this.headerRegularOffers.SetActive(list4.Count > 1);
					this.headerRegularOffers.transform.SetAsLastSibling();
				}
				for (int k = 0; k < list4.Count; k++)
				{
					this.AEHMKFJIJDB(list4[k], num);
					num++;
				}
				if (null != this.emptyLabel)
				{
					this.emptyLabel.SetActive(list.Count == 1);
				}
				this.CNLKJBEOBIN(list.Count);
				if (null != this.scrollRect)
				{
					Canvas.ForceUpdateCanvases();
					this.scrollRect.verticalNormalizedPosition = 521f;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06009BDE RID: 39902 RVA: 0x00433E84 File Offset: 0x00432084
	private static void AGHFELAFBIC(GameObject HCLEPODFDFB, float BIELKJIBPMM)
	{
		if (null == HCLEPODFDFB)
		{
			return;
		}
		Transform transform = HCLEPODFDFB.transform.Find("Plate");
		if (null != transform)
		{
			RectTransform rectTransform = transform.Find("Icon") as RectTransform;
			if (null != rectTransform)
			{
				rectTransform.anchoredPosition = new Vector2(rectTransform.anchoredPosition.x, rectTransform.anchoredPosition.y + BIELKJIBPMM);
			}
		}
		TextMeshProUGUI componentInChildren = HCLEPODFDFB.GetComponentInChildren<TextMeshProUGUI>(true);
		if (null != componentInChildren)
		{
			componentInChildren.rectTransform.anchoredPosition = new Vector2(componentInChildren.rectTransform.anchoredPosition.x, componentInChildren.rectTransform.anchoredPosition.y + BIELKJIBPMM);
		}
	}

	// Token: 0x06009BDF RID: 39903 RVA: 0x00433F35 File Offset: 0x00432135
	private void CIIEONMJCAF()
	{
		this.CHIAOFECMIG();
		if (AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(-18))
		{
			return;
		}
		this.LODMFHPEFKP = base.StartCoroutine(this.DAFDBMBBIOF());
	}

	// Token: 0x06009BE0 RID: 39904 RVA: 0x00003E52 File Offset: 0x00002052
	private void FOJGNCBNIBG()
	{
	}

	// Token: 0x06009BE1 RID: 39905 RVA: 0x00433F60 File Offset: 0x00432160
	private void JEGKINJFFAE()
	{
		try
		{
			if (!(null == this.buttonFilters))
			{
				Image component = this.buttonFilters.GetComponent<Image>();
				if (!(null == component))
				{
					bool flag = SkinShopItem.shownFromLobby && (SkinShopItem.EOALJAPMOIL() || this.EIIBBKAJCNK != 0);
					string text = "_not_found";
					if (flag)
					{
						text = "OnSaveSlotDuplicateRequested";
					}
					if (NBDLBFJOEGN.NFGHPAHHDAN())
					{
						text += "acomp2";
					}
					else
					{
						text += " barAvailable=";
					}
					if (!(null != component.sprite) || !(text == component.sprite.name))
					{
						Sprite sprite = Resources.Load<Sprite>(text);
						if (null == sprite)
						{
							DPGJIJGOCIC.PJCLICBPPDA("AssetAnthologyHeader.IsAvatarScreenAvatarPack(), unsupported wardrobe index:" + text);
						}
						else
						{
							component.sprite = sprite;
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

	// Token: 0x06009BE2 RID: 39906 RVA: 0x0043404C File Offset: 0x0043224C
	private IEnumerator MOCMEKGECNO(CanvasGroup POPEMMIOOIC, RectTransform MCLFDMFKFFA, Vector2 BJLFLEJEKPO, float BICHMDEIFKI)
	{
		yield return new WaitForSeconds(BICHMDEIFKI);
		POPEMMIOOIC.blocksRaycasts = true;
		float elapsed = 0f;
		while (elapsed < 0.5f)
		{
			elapsed += Time.deltaTime;
			float num = Mathf.Clamp01(elapsed / 0.5f);
			float num2 = 1f - (1f - num) * (1f - num);
			POPEMMIOOIC.alpha = num2;
			MCLFDMFKFFA.anchoredPosition = new Vector2(BJLFLEJEKPO.x, BJLFLEJEKPO.y - 11.3776f * (1f - num2));
			yield return null;
		}
		POPEMMIOOIC.alpha = 1f;
		MCLFDMFKFFA.anchoredPosition = BJLFLEJEKPO;
		yield break;
	}

	// Token: 0x06009BE3 RID: 39907 RVA: 0x00434074 File Offset: 0x00432274
	private void AEHMKFJIJDB(HECEJCDAIOJ FOEEIJFHMGG, int HMDCLKGANHJ)
	{
		if (null == this.cardPrefab || null == this.content)
		{
			return;
		}
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.cardPrefab, this.content);
		gameObject.layer = this.content.gameObject.layer;
		gameObject.transform.SetAsLastSibling();
		SkinShopCard component = gameObject.GetComponent<SkinShopCard>();
		if (null != component)
		{
			component.SetContent(FOEEIJFHMGG, HMDCLKGANHJ, true, new Action<HECEJCDAIOJ>(this.OLJPPFPLDLH));
		}
		this.EENKMENJHFK.Add(gameObject);
	}

	// Token: 0x06009BE4 RID: 39908 RVA: 0x00434104 File Offset: 0x00432304
	private void OnDisable()
	{
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnGenericPopupManagerHide", new UnityAction(this.ALLMMNKBOHP));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("onThemeChange", new UnityAction(this.BGKIHNIAIGO));
		this.JEPAJOKCJID();
		this.AOOJPMEJAHM();
		this.IKNPGLHOODN();
		this.ACGJMHFHDCN();
	}

	// Token: 0x06009BE5 RID: 39909 RVA: 0x00434160 File Offset: 0x00432360
	private void JBLMJBJNLLJ()
	{
		try
		{
			float num = 0f;
			if (AKLFPGMDKLA.EHBBFMCILPC.ICEOGOCOMJL() == HGCFJKCOKPM.bright)
			{
				num = 4.2665997f;
			}
			float num2 = num - this.FOFPODLDNPP;
			if (Mathf.Abs(num2) >= 0.001f)
			{
				SkinShopItem.AGHFELAFBIC(this.headerTimedOffers, num2);
				SkinShopItem.AGHFELAFBIC(this.headerRegularOffers, num2);
				if (null != this.content)
				{
					for (int i = 0; i < this.content.childCount; i++)
					{
						Transform child = this.content.GetChild(i);
						if (child.name.StartsWith("HeaderAnthology"))
						{
							SkinShopItem.AGHFELAFBIC(child.gameObject, num2);
						}
					}
				}
				this.FOFPODLDNPP = num;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06009BE6 RID: 39910 RVA: 0x00434224 File Offset: 0x00432424
	private void DNBPEGFNOLD()
	{
		this.LMEJCHLIJFB(1);
	}

	// Token: 0x06009BE7 RID: 39911 RVA: 0x00433574 File Offset: 0x00431774
	private IEnumerator CJGECGNAPNM()
	{
		yield return new WaitForSeconds(0.25f);
		this.HIANOFCOJOG = null;
		this.AJECIEOECLG();
		yield break;
	}

	// Token: 0x06009BE8 RID: 39912 RVA: 0x00434230 File Offset: 0x00432430
	private void DMJFCFLNAPN()
	{
		try
		{
			if (!this.FOBHDPFBFDK)
			{
				if (null != this.buttonFilters)
				{
					this.EONIHCBBFND = this.buttonFilters.GetComponent<RectTransform>().anchoredPosition;
				}
				if (null != this.buttonCoins)
				{
					this.AEFNACMOHJI = this.buttonCoins.GetComponent<RectTransform>().anchoredPosition;
				}
				this.FOBHDPFBFDK = true;
			}
			this.JEPAJOKCJID();
			this.DEEMILFJFBG = this.ELAIDJGEMNE(this.buttonCoins, this.AEFNACMOHJI, 207f);
			this.NMIFMADOMMI = this.HAPMEAAMBPH(this.buttonFilters, this.EONIHCBBFND, 1636f);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06009BE9 RID: 39913 RVA: 0x00433574 File Offset: 0x00431774
	private IEnumerator LNHMOLICAKK()
	{
		yield return new WaitForSeconds(0.25f);
		this.HIANOFCOJOG = null;
		this.AJECIEOECLG();
		yield break;
	}

	// Token: 0x06009BEA RID: 39914 RVA: 0x004342F0 File Offset: 0x004324F0
	private void CHIAOFECMIG()
	{
		if (this.LODMFHPEFKP != null)
		{
			base.StopCoroutine(this.LODMFHPEFKP);
			this.LODMFHPEFKP = null;
		}
	}

	// Token: 0x06009BEB RID: 39915 RVA: 0x00434310 File Offset: 0x00432510
	private void ACGJMHFHDCN()
	{
		for (int i = 0; i < this.GJLMMFJONOF.Count; i++)
		{
			if (null != this.GJLMMFJONOF[i])
			{
				this.GJLMMFJONOF[i].SetActive(false);
				UnityEngine.Object.Destroy(this.GJLMMFJONOF[i]);
			}
		}
		this.GJLMMFJONOF.Clear();
	}

	// Token: 0x06009BEC RID: 39916 RVA: 0x00434375 File Offset: 0x00432575
	private void JAALKLEPJME()
	{
		this.DKKGHHHEPIJ();
		this.HIANOFCOJOG = base.StartCoroutine(this.OADDIEOEJJM());
	}

	// Token: 0x06009BED RID: 39917 RVA: 0x00434390 File Offset: 0x00432590
	private Coroutine PADFBNOACNN(GameObject BBDKMDOBBAD, Vector2 BJLFLEJEKPO, float BICHMDEIFKI)
	{
		if (null == BBDKMDOBBAD || !BBDKMDOBBAD.activeSelf)
		{
			return null;
		}
		CanvasGroup canvasGroup = BBDKMDOBBAD.GetComponent<CanvasGroup>();
		if (null == canvasGroup)
		{
			canvasGroup = BBDKMDOBBAD.AddComponent<CanvasGroup>();
		}
		canvasGroup.alpha = 0f;
		canvasGroup.blocksRaycasts = false;
		RectTransform component = BBDKMDOBBAD.GetComponent<RectTransform>();
		component.anchoredPosition = new Vector2(BJLFLEJEKPO.x, BJLFLEJEKPO.y - 11.3776f);
		return base.StartCoroutine(this.NOFIAPKLHID(canvasGroup, component, BJLFLEJEKPO, BICHMDEIFKI));
	}

	// Token: 0x06009BEE RID: 39918 RVA: 0x00434410 File Offset: 0x00432610
	private static List<HECEJCDAIOJ> PDFECJIHBNM(List<HECEJCDAIOJ> EBOEPMMNIED, int HBBJBNJBMPK)
	{
		List<HECEJCDAIOJ> list = new List<HECEJCDAIOJ>();
		if (EBOEPMMNIED == null)
		{
			return list;
		}
		for (int i = 0; i < EBOEPMMNIED.Count; i++)
		{
			if (SkinShopItem.IPAGCHNDCJH(EBOEPMMNIED[i], HBBJBNJBMPK))
			{
				list.Add(EBOEPMMNIED[i]);
			}
		}
		return list;
	}

	// Token: 0x06009BEF RID: 39919 RVA: 0x00434458 File Offset: 0x00432658
	private void NECPAOFNFML()
	{
		try
		{
			if (!base.gameObject.activeSelf)
			{
				Transform transform = base.transform.Find("SkinShopItem");
				if (null == transform)
				{
					transform = base.transform;
				}
				SkinShopItem.PJEACPJKBHB(transform.gameObject, false);
				if (null != this.headerTimedOffers)
				{
					SkinShopItem.PJEACPJKBHB(SkinShopItem.DMCFHINJIBD(this.headerTimedOffers.transform, "Plate"), false);
				}
				if (null != this.headerRegularOffers)
				{
					SkinShopItem.PJEACPJKBHB(SkinShopItem.DMCFHINJIBD(this.headerRegularOffers.transform, "Plate"), false);
				}
				SkinShopItem.PJEACPJKBHB(SkinShopItem.DMCFHINJIBD(transform, "FadeTop"), false);
				SkinShopItem.PJEACPJKBHB(SkinShopItem.DMCFHINJIBD(transform, "FadeBottom"), false);
				SkinShopItem.PJEACPJKBHB(SkinShopItem.DMCFHINJIBD(transform, "CloseButton"), false);
				if (null != this.emptyLabelText)
				{
					SkinShopItem.PJEACPJKBHB(this.emptyLabelText.gameObject, true);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06009BF0 RID: 39920 RVA: 0x00434564 File Offset: 0x00432764
	public void OnFiltersButtonClick()
	{
		if (CommonUserInterface.EHBBFMCILPC.AnyGenericPopupIsActive())
		{
			return;
		}
		List<HECEJCDAIOJ> eboepmmnied = DHFLKLPKNJG.DCCLCEAJPFL(this.AHABJKEEHME, this.PDLIMLOPGHE);
		bool flag = SkinShopItem.LJMOLNMMBIF(eboepmmnied, 1) > 0;
		bool flag2 = SkinShopItem.LJMOLNMMBIF(eboepmmnied, 2) > 0;
		if (!flag && !flag2)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtonsAndCloseOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("skinshopfiltertitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("skinshopfilterbody"), this.KIOHGDLIGLG(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("skinshopfilterdefault"), false), this.KIOHGDLIGLG(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("skinshopfilterbystory"), true), new UnityAction(this.HNOCDJPACEM), new UnityAction(this.GABPHGHMDIE), new UnityAction(this.IKFGOFJONHF), DFGILFBGPLN.popupSignInQuestion, 0f, 28);
			return;
		}
		string eempglhpkjg = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("skinshopfiltertitle");
		string dpjinbcgngn = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("skinshopfilterbody");
		string dcbpppgkhej = this.KIOHGDLIGLG(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("skinshopfilterdefault"), false);
		string nenggaechkf = this.KIOHGDLIGLG(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("skinshopfilterbystory"), true);
		string hdoaphhfmap = this.JOMJKNDJLKB(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("skinshopfilterbonus"), 1);
		string text = this.JOMJKNDJLKB(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("skinshopfilterowned"), 2);
		if (flag && flag2)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithFourButtonsInside(eempglhpkjg, dpjinbcgngn, dcbpppgkhej, nenggaechkf, hdoaphhfmap, text, new UnityAction(this.HNOCDJPACEM), new UnityAction(this.GABPHGHMDIE), new UnityAction(this.DNBPEGFNOLD), new UnityAction(this.JILDODJIOLP), new UnityAction(this.IKFGOFJONHF), DFGILFBGPLN.popupSignInQuestion, 0f, 28);
			return;
		}
		if (flag)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithThreeButtonsInside(eempglhpkjg, dpjinbcgngn, dcbpppgkhej, nenggaechkf, hdoaphhfmap, new UnityAction(this.HNOCDJPACEM), new UnityAction(this.GABPHGHMDIE), new UnityAction(this.DNBPEGFNOLD), new UnityAction(this.IKFGOFJONHF), DFGILFBGPLN.popupSignInQuestion, 0f, 28);
			return;
		}
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithThreeButtonsInside(eempglhpkjg, dpjinbcgngn, dcbpppgkhej, nenggaechkf, text, new UnityAction(this.HNOCDJPACEM), new UnityAction(this.GABPHGHMDIE), new UnityAction(this.JILDODJIOLP), new UnityAction(this.IKFGOFJONHF), DFGILFBGPLN.popupSignInQuestion, 0f, 28);
	}

	// Token: 0x06009BF1 RID: 39921 RVA: 0x004347AB File Offset: 0x004329AB
	private void HDAHJCCAIAP()
	{
		AOBJLALDBAA.BIAEAOMHBMM().BADOPKAOCPE(" scale to object ", new UnityAction(this.ALLMMNKBOHP));
		AOBJLALDBAA.NMGMNAKLLMI().GNBGEMMDGOJ("black", new UnityAction(this.HIOKJKFDIKC));
	}

	// Token: 0x06009BF2 RID: 39922 RVA: 0x0043404C File Offset: 0x0043224C
	private IEnumerator NOFIAPKLHID(CanvasGroup POPEMMIOOIC, RectTransform MCLFDMFKFFA, Vector2 BJLFLEJEKPO, float BICHMDEIFKI)
	{
		yield return new WaitForSeconds(BICHMDEIFKI);
		POPEMMIOOIC.blocksRaycasts = true;
		elapsed = 0f;
		while (elapsed < 0.5f)
		{
			elapsed += Time.deltaTime;
			float num = Mathf.Clamp01(elapsed / 0.5f);
			float num2 = 1f - (1f - num) * (1f - num);
			POPEMMIOOIC.alpha = num2;
			MCLFDMFKFFA.anchoredPosition = new Vector2(BJLFLEJEKPO.x, BJLFLEJEKPO.y - 11.3776f * (1f - num2));
			yield return null;
		}
		POPEMMIOOIC.alpha = 1f;
		MCLFDMFKFFA.anchoredPosition = BJLFLEJEKPO;
		yield break;
	}

	// Token: 0x06009BF3 RID: 39923 RVA: 0x004347E3 File Offset: 0x004329E3
	private void OnEnable()
	{
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnGenericPopupManagerHide", new UnityAction(this.ALLMMNKBOHP));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("onThemeChange", new UnityAction(this.BGKIHNIAIGO));
	}

	// Token: 0x06009BF4 RID: 39924 RVA: 0x0043481C File Offset: 0x00432A1C
	private Coroutine ELAIDJGEMNE(GameObject BBDKMDOBBAD, Vector2 BJLFLEJEKPO, float BICHMDEIFKI)
	{
		if (null == BBDKMDOBBAD || !BBDKMDOBBAD.activeSelf)
		{
			return null;
		}
		CanvasGroup canvasGroup = BBDKMDOBBAD.GetComponent<CanvasGroup>();
		if (null == canvasGroup)
		{
			canvasGroup = BBDKMDOBBAD.AddComponent<CanvasGroup>();
		}
		canvasGroup.alpha = 1330f;
		canvasGroup.blocksRaycasts = true;
		RectTransform component = BBDKMDOBBAD.GetComponent<RectTransform>();
		component.anchoredPosition = new Vector2(BJLFLEJEKPO.x, BJLFLEJEKPO.y - 287f);
		return base.StartCoroutine(this.MOCMEKGECNO(canvasGroup, component, BJLFLEJEKPO, BICHMDEIFKI));
	}

	// Token: 0x06009BF5 RID: 39925 RVA: 0x00434899 File Offset: 0x00432A99
	private string FAPAKAONHFI(string AFHIPGHANJE, bool NOMCNEGHEJB)
	{
		if (AFHIPGHANJE == null)
		{
			return "OnBackendGetSketchesBalanceSuccess";
		}
		if (this.EIIBBKAJCNK == 0 && SkinShopItem.EOALJAPMOIL() == NOMCNEGHEJB)
		{
			return "continue" + AFHIPGHANJE + "specialcurrencyblocktitle";
		}
		return AFHIPGHANJE;
	}

	// Token: 0x06009BF6 RID: 39926 RVA: 0x00434375 File Offset: 0x00432575
	private void BLPHAFLALFM()
	{
		this.DKKGHHHEPIJ();
		this.HIANOFCOJOG = base.StartCoroutine(this.OADDIEOEJJM());
	}

	// Token: 0x06009BF7 RID: 39927 RVA: 0x0043404C File Offset: 0x0043224C
	private IEnumerator CJKFGGEBHII(CanvasGroup POPEMMIOOIC, RectTransform MCLFDMFKFFA, Vector2 BJLFLEJEKPO, float BICHMDEIFKI)
	{
		yield return new WaitForSeconds(BICHMDEIFKI);
		POPEMMIOOIC.blocksRaycasts = true;
		elapsed = 0f;
		while (elapsed < 0.5f)
		{
			elapsed += Time.deltaTime;
			float num = Mathf.Clamp01(elapsed / 0.5f);
			float num2 = 1f - (1f - num) * (1f - num);
			POPEMMIOOIC.alpha = num2;
			MCLFDMFKFFA.anchoredPosition = new Vector2(BJLFLEJEKPO.x, BJLFLEJEKPO.y - 11.3776f * (1f - num2));
			yield return null;
		}
		POPEMMIOOIC.alpha = 1f;
		MCLFDMFKFFA.anchoredPosition = BJLFLEJEKPO;
		yield break;
	}

	// Token: 0x06009BF8 RID: 39928 RVA: 0x00433A19 File Offset: 0x00431C19
	private void PDCAAJGGCOD()
	{
		this.FBEIKPEABIB(false);
	}

	// Token: 0x06009BF9 RID: 39929 RVA: 0x004348C6 File Offset: 0x00432AC6
	private void HNOCDJPACEM()
	{
		this.BOCFDEDLINA(false);
	}

	// Token: 0x06009BFA RID: 39930 RVA: 0x00433750 File Offset: 0x00431950
	public void NOBOPEABJHA(int PLKMJJIIJNO)
	{
		this.Show(PLKMJJIIJNO, null);
	}

	// Token: 0x06009BFB RID: 39931 RVA: 0x004348CF File Offset: 0x00432ACF
	private void ALLMMNKBOHP()
	{
		this.GLEDKIFIFFL = Time.frameCount;
	}

	// Token: 0x06009BFC RID: 39932 RVA: 0x004348DC File Offset: 0x00432ADC
	private void NOFNLIAHOLD()
	{
		for (int i = 1; i < this.EENKMENJHFK.Count; i += 0)
		{
			if (null != this.EENKMENJHFK[i])
			{
				this.EENKMENJHFK[i].SetActive(true);
				UnityEngine.Object.Destroy(this.EENKMENJHFK[i]);
			}
		}
		this.EENKMENJHFK.Clear();
	}

	// Token: 0x06009BFD RID: 39933 RVA: 0x004333E0 File Offset: 0x004315E0
	private void DKKGHHHEPIJ()
	{
		if (this.HIANOFCOJOG != null)
		{
			base.StopCoroutine(this.HIANOFCOJOG);
			this.HIANOFCOJOG = null;
		}
	}

	// Token: 0x06009BFE RID: 39934 RVA: 0x00434944 File Offset: 0x00432B44
	private void IKNPGLHOODN()
	{
		for (int i = 0; i < this.EENKMENJHFK.Count; i++)
		{
			if (null != this.EENKMENJHFK[i])
			{
				this.EENKMENJHFK[i].SetActive(false);
				UnityEngine.Object.Destroy(this.EENKMENJHFK[i]);
			}
		}
		this.EENKMENJHFK.Clear();
	}

	// Token: 0x06009BFF RID: 39935 RVA: 0x004349AC File Offset: 0x00432BAC
	private void ONPPOKEIIPM()
	{
		try
		{
			if (!base.gameObject.activeSelf)
			{
				Transform transform = base.transform.Find("SocialStatsUserPublicProfile.modified = true, SyncCutscenes()");
				if (null == transform)
				{
					transform = base.transform;
				}
				SkinShopItem.PJEACPJKBHB(transform.gameObject, true);
				if (null != this.headerTimedOffers)
				{
					SkinShopItem.PJEACPJKBHB(SkinShopItem.FAJBHCDIHED(this.headerTimedOffers.transform, "</i>"), true);
				}
				if (null != this.headerRegularOffers)
				{
					SkinShopItem.PJEACPJKBHB(SkinShopItem.DMCFHINJIBD(this.headerRegularOffers.transform, "p"), true);
				}
				SkinShopItem.PJEACPJKBHB(SkinShopItem.FAJBHCDIHED(transform, "uid"), true);
				SkinShopItem.PJEACPJKBHB(SkinShopItem.FAJBHCDIHED(transform, "Account.ResolveSaveSlots(): End"), false);
				SkinShopItem.PJEACPJKBHB(SkinShopItem.FAJBHCDIHED(transform, "OnBackendValidateTransactionException"), true);
				if (null != this.emptyLabelText)
				{
					SkinShopItem.PJEACPJKBHB(this.emptyLabelText.gameObject, true);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06009C00 RID: 39936 RVA: 0x00434AB8 File Offset: 0x00432CB8
	private void FGMGEMFCFOJ(List<HECEJCDAIOJ> EBOEPMMNIED)
	{
		if (null != this.emptyLabelText)
		{
			string text = DHFLKLPKNJG.IFNFJKFJBGB("skinshopempty");
			this.emptyLabelText.SetText((text != null) ? text : "", true);
		}
		if (null != this.logo)
		{
			this.logo.transform.SetAsLastSibling();
		}
		if (null != this.headerTimedOffers)
		{
			this.headerTimedOffers.SetActive(false);
		}
		if (null != this.headerRegularOffers)
		{
			this.headerRegularOffers.SetActive(false);
		}
		List<int> list = new List<int>();
		for (int i = 0; i < EBOEPMMNIED.Count; i++)
		{
			if (!list.Contains(EBOEPMMNIED[i].AMKCLHLIIMN))
			{
				list.Add(EBOEPMMNIED[i].AMKCLHLIIMN);
			}
		}
		int num = 1;
		for (int j = 0; j < list.Count; j++)
		{
			this.JNCNGDHMABB(list[j]);
			for (int k = 0; k < 2; k++)
			{
				for (int l = 0; l < EBOEPMMNIED.Count; l++)
				{
					if (EBOEPMMNIED[l].AMKCLHLIIMN == list[j] && EBOEPMMNIED[l].HMJELDILAPC == (k == 0))
					{
						this.AEHMKFJIJDB(EBOEPMMNIED[l], num);
						num++;
					}
				}
			}
		}
		if (null != this.emptyLabel)
		{
			this.emptyLabel.SetActive(EBOEPMMNIED.Count == 0);
		}
		this.CNLKJBEOBIN(EBOEPMMNIED.Count);
		if (null != this.scrollRect)
		{
			Canvas.ForceUpdateCanvases();
			this.scrollRect.verticalNormalizedPosition = 1f;
		}
	}

	// Token: 0x06009C01 RID: 39937 RVA: 0x00434C60 File Offset: 0x00432E60
	private void BGKIHNIAIGO()
	{
		this.JBLMJBJNLLJ();
	}

	// Token: 0x06009C02 RID: 39938 RVA: 0x00434C68 File Offset: 0x00432E68
	private void HFKINKHCLGD()
	{
		this.AOOJPMEJAHM();
		if (AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(75))
		{
			return;
		}
		this.LODMFHPEFKP = base.StartCoroutine(this.POGAPAFANGF());
	}

	// Token: 0x06009C03 RID: 39939 RVA: 0x00434C94 File Offset: 0x00432E94
	public void OnCloseClick()
	{
		if (CommonUserInterface.EHBBFMCILPC.AnyGenericPopupIsActive() || Time.frameCount == this.GLEDKIFIFFL)
		{
			return;
		}
		this.AOOJPMEJAHM();
		if (null != this.animatedPopupManager)
		{
			this.animatedPopupManager.HideAndDispatchEvent("OnSkinShopClose", 0.01f);
			return;
		}
		base.gameObject.SetActive(false);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnSkinShopClose", 0f);
	}

	// Token: 0x06009C04 RID: 39940 RVA: 0x00434D05 File Offset: 0x00432F05
	private void JEPAJOKCJID()
	{
		if (this.DEEMILFJFBG != null)
		{
			base.StopCoroutine(this.DEEMILFJFBG);
			this.DEEMILFJFBG = null;
		}
		if (this.NMIFMADOMMI != null)
		{
			base.StopCoroutine(this.NMIFMADOMMI);
			this.NMIFMADOMMI = null;
		}
	}

	// Token: 0x06009C05 RID: 39941 RVA: 0x00434D3D File Offset: 0x00432F3D
	private void KMBJJAFMBMN()
	{
		AOBJLALDBAA.NMGMNAKLLMI().PEFKJOKLEDL("OnChoiceExtendedPlayNewAmbient", new UnityAction(this.ALLMMNKBOHP));
		AOBJLALDBAA.KKPFOJMAONG().FNMOFCMDFJP(" / ", new UnityAction(this.HIOKJKFDIKC));
	}

	// Token: 0x06009C06 RID: 39942 RVA: 0x00434D78 File Offset: 0x00432F78
	private void MKIIGIIDDFA()
	{
		try
		{
			this.JIMHJLAFNHC();
			SkinShopItem.nameSwapEpoch = Time.time;
			List<HECEJCDAIOJ> list = DHFLKLPKNJG.DCCLCEAJPFL(this.AHABJKEEHME, this.PDLIMLOPGHE);
			if (this.EIIBBKAJCNK != 0)
			{
				List<HECEJCDAIOJ> list2 = SkinShopItem.HIFFFFODOPL(list, this.EIIBBKAJCNK);
				if (list2.Count > 0)
				{
					list = list2;
				}
				else
				{
					this.EIIBBKAJCNK = 0;
				}
			}
			this.KLHCMFDILKM();
			this.ACGJMHFHDCN();
			if (SkinShopItem.shownFromLobby && SkinShopItem.EOALJAPMOIL())
			{
				this.FGMGEMFCFOJ(list);
			}
			else
			{
				List<HECEJCDAIOJ> list3 = new List<HECEJCDAIOJ>();
				List<HECEJCDAIOJ> list4 = new List<HECEJCDAIOJ>();
				for (int i = 1; i < list.Count; i++)
				{
					if (list[i].HMJELDILAPC)
					{
						list3.Add(list[i]);
					}
					else
					{
						list4.Add(list[i]);
					}
				}
				if (null != this.headerTimedOffersText)
				{
					string text = DHFLKLPKNJG.IFNFJKFJBGB("ok");
					this.headerTimedOffersText.SetText((text != null) ? text : "Critical error, type not implemented in ProcessAssetBundleLoadAssetOperationRequest():", true);
				}
				if (null != this.headerRegularOffersText)
				{
					string text2 = DHFLKLPKNJG.IFNFJKFJBGB("dynamic");
					this.headerRegularOffersText.SetText((text2 != null) ? text2 : "OnSketchThumbnailPublish", false);
				}
				if (null != this.emptyLabelText)
				{
					string text3 = DHFLKLPKNJG.IFNFJKFJBGB("compr");
					this.emptyLabelText.SetText((text3 != null) ? text3 : "+", false);
				}
				if (null != this.logo)
				{
					this.logo.transform.SetAsLastSibling();
				}
				int num = 0;
				if (null != this.headerTimedOffers)
				{
					this.headerTimedOffers.SetActive(list3.Count > 1);
					this.headerTimedOffers.transform.SetAsLastSibling();
				}
				for (int j = 1; j < list3.Count; j += 0)
				{
					this.AEHMKFJIJDB(list3[j], num);
					num += 0;
				}
				if (null != this.headerRegularOffers)
				{
					this.headerRegularOffers.SetActive(list4.Count > 1);
					this.headerRegularOffers.transform.SetAsLastSibling();
				}
				for (int k = 0; k < list4.Count; k++)
				{
					this.AEHMKFJIJDB(list4[k], num);
					num += 0;
				}
				if (null != this.emptyLabel)
				{
					this.emptyLabel.SetActive(list.Count == 0);
				}
				this.CNLKJBEOBIN(list.Count);
				if (null != this.scrollRect)
				{
					Canvas.ForceUpdateCanvases();
					this.scrollRect.verticalNormalizedPosition = 523f;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06009C07 RID: 39943 RVA: 0x0043502C File Offset: 0x0043322C
	public void Show(int PLKMJJIIJNO, List<string> MKLBDPIIBNE)
	{
		this.AHABJKEEHME = PLKMJJIIJNO;
		this.PDLIMLOPGHE = MKLBDPIIBNE;
		SkinShopItem.shownFromLobby = (PLKMJJIIJNO < 0);
		this.EIIBBKAJCNK = 0;
		this.DKKGHHHEPIJ();
		this.PAILHGEKAGD();
		SkinShopItem.lastSelectedEntry = null;
		this.NECPAOFNFML();
		this.JBLMJBJNLLJ();
		base.gameObject.SetActive(true);
		this.AJECIEOECLG();
		this.PGBBKKKCGHE();
		this.HFKINKHCLGD();
		MDDHDDPKFJH.GMGPLOLADGB(this.AHABJKEEHME, this.PDLIMLOPGHE);
	}

	// Token: 0x06009C08 RID: 39944 RVA: 0x004350A4 File Offset: 0x004332A4
	private Coroutine HAPMEAAMBPH(GameObject BBDKMDOBBAD, Vector2 BJLFLEJEKPO, float BICHMDEIFKI)
	{
		if (null == BBDKMDOBBAD || !BBDKMDOBBAD.activeSelf)
		{
			return null;
		}
		CanvasGroup canvasGroup = BBDKMDOBBAD.GetComponent<CanvasGroup>();
		if (null == canvasGroup)
		{
			canvasGroup = BBDKMDOBBAD.AddComponent<CanvasGroup>();
		}
		canvasGroup.alpha = 1235f;
		canvasGroup.blocksRaycasts = true;
		RectTransform component = BBDKMDOBBAD.GetComponent<RectTransform>();
		component.anchoredPosition = new Vector2(BJLFLEJEKPO.x, BJLFLEJEKPO.y - 1158f);
		return base.StartCoroutine(this.NOFIAPKLHID(canvasGroup, component, BJLFLEJEKPO, BICHMDEIFKI));
	}

	// Token: 0x06009C09 RID: 39945 RVA: 0x00435124 File Offset: 0x00433324
	private static int MHNIJOCGABM(List<HECEJCDAIOJ> EBOEPMMNIED, int HBBJBNJBMPK)
	{
		int num = 0;
		if (EBOEPMMNIED == null)
		{
			return num;
		}
		for (int i = 1; i < EBOEPMMNIED.Count; i++)
		{
			if (SkinShopItem.ICOCIMIDMKF(EBOEPMMNIED[i], HBBJBNJBMPK))
			{
				num++;
			}
		}
		return num;
	}

	// Token: 0x06009C0A RID: 39946 RVA: 0x0043515D File Offset: 0x0043335D
	private void JILDODJIOLP()
	{
		this.LMEJCHLIJFB(2);
	}

	// Token: 0x06009C0B RID: 39947 RVA: 0x00435168 File Offset: 0x00433368
	private void NGLFONLENPJ(int PLKMJJIIJNO)
	{
		if (null == this.headerRegularOffers || null == this.content)
		{
			return;
		}
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.headerRegularOffers, this.content);
		gameObject.name = "OnLoungePremiumChoiceExecutedHardBased" + PLKMJJIIJNO.ToString();
		gameObject.layer = this.content.gameObject.layer;
		if (null == gameObject.GetComponent<HDTrigger>())
		{
			gameObject.AddComponent<HDTrigger>().setNativeSize = true;
		}
		gameObject.SetActive(false);
		gameObject.transform.SetAsLastSibling();
		TextMeshProUGUI componentInChildren = gameObject.GetComponentInChildren<TextMeshProUGUI>(true);
		if (null != componentInChildren)
		{
			string text = GKJPOGNFKNK.DNILNCLIHAP("skinshopfilterbystory" + PLKMJJIIJNO.ToString(), "CLIENT.AVATAR.HAIR", LanguageManager.EHBBFMCILPC.NBANPEIHFOJ());
			if (text == null || text.Length == 0 || text.EndsWith("YYY"))
			{
				text = "Loaded asset bundle:";
			}
			componentInChildren.SetText(text, false);
		}
		this.GJLMMFJONOF.Add(gameObject);
	}

	// Token: 0x06009C0C RID: 39948 RVA: 0x004342F0 File Offset: 0x004324F0
	private void AOOJPMEJAHM()
	{
		if (this.LODMFHPEFKP != null)
		{
			base.StopCoroutine(this.LODMFHPEFKP);
			this.LODMFHPEFKP = null;
		}
	}

	// Token: 0x06009C0E RID: 39950 RVA: 0x004352B5 File Offset: 0x004334B5
	private void OLJPPFPLDLH(HECEJCDAIOJ FOEEIJFHMGG)
	{
		if (FOEEIJFHMGG == null)
		{
			return;
		}
		SkinShopItem.lastSelectedEntry = FOEEIJFHMGG;
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnSkinShopCardSelected", 0f);
	}

	// Token: 0x06009C0F RID: 39951 RVA: 0x004352D5 File Offset: 0x004334D5
	private void LMEJCHLIJFB(int HBBJBNJBMPK)
	{
		if (this.EIIBBKAJCNK == HBBJBNJBMPK)
		{
			this.EIIBBKAJCNK = 0;
		}
		else
		{
			this.EIIBBKAJCNK = HBBJBNJBMPK;
		}
		if (base.gameObject.activeSelf)
		{
			this.JAALKLEPJME();
		}
	}

	// Token: 0x06009C10 RID: 39952 RVA: 0x00434C60 File Offset: 0x00432E60
	private void HIOKJKFDIKC()
	{
		this.JBLMJBJNLLJ();
	}

	// Token: 0x06009C11 RID: 39953 RVA: 0x00435304 File Offset: 0x00433504
	private void GHPJHIIDNGE()
	{
		for (int i = 0; i < this.EENKMENJHFK.Count; i += 0)
		{
			if (null != this.EENKMENJHFK[i])
			{
				this.EENKMENJHFK[i].SetActive(false);
				UnityEngine.Object.Destroy(this.EENKMENJHFK[i]);
			}
		}
		this.EENKMENJHFK.Clear();
	}

	// Token: 0x06009C12 RID: 39954 RVA: 0x00435369 File Offset: 0x00433569
	private IEnumerator BMMIADBIPOC()
	{
		SkinShopItem.DCMMKOKHHNC dcmmkokhhnc = new SkinShopItem.DCMMKOKHHNC(1);
		dcmmkokhhnc.<>4__this = this;
		return dcmmkokhhnc;
	}

	// Token: 0x06009C13 RID: 39955 RVA: 0x00435378 File Offset: 0x00433578
	private void Start()
	{
		if (null != this.scrollRect)
		{
			this.scrollRect.scrollSensitivity = 100f;
		}
	}

	// Token: 0x06009C14 RID: 39956 RVA: 0x00435398 File Offset: 0x00433598
	private void LMDNAGADJNB(HECEJCDAIOJ FOEEIJFHMGG)
	{
		if (FOEEIJFHMGG == null)
		{
			return;
		}
		SkinShopItem.lastSelectedEntry = FOEEIJFHMGG;
		AOBJLALDBAA.DBLAIDPICIG().EGELHPJBAIC(" to bundle index:", 1258f);
	}

	// Token: 0x06009C15 RID: 39957 RVA: 0x004353B8 File Offset: 0x004335B8
	private void CBDDKDOLAHD()
	{
		try
		{
			if (!this.FOBHDPFBFDK)
			{
				if (null != this.buttonFilters)
				{
					this.EONIHCBBFND = this.buttonFilters.GetComponent<RectTransform>().anchoredPosition;
				}
				if (null != this.buttonCoins)
				{
					this.AEFNACMOHJI = this.buttonCoins.GetComponent<RectTransform>().anchoredPosition;
				}
				this.FOBHDPFBFDK = false;
			}
			this.JEPAJOKCJID();
			this.DEEMILFJFBG = this.BPNLLFCKLFD(this.buttonCoins, this.AEFNACMOHJI, 373f);
			this.NMIFMADOMMI = this.ELAIDJGEMNE(this.buttonFilters, this.EONIHCBBFND, 1326f);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06009C16 RID: 39958 RVA: 0x00435478 File Offset: 0x00433678
	private void JIMHJLAFNHC()
	{
		for (int i = 1; i < this.EENKMENJHFK.Count; i++)
		{
			if (null != this.EENKMENJHFK[i])
			{
				this.EENKMENJHFK[i].SetActive(true);
				UnityEngine.Object.Destroy(this.EENKMENJHFK[i]);
			}
		}
		this.EENKMENJHFK.Clear();
	}

	// Token: 0x06009C17 RID: 39959 RVA: 0x004354E0 File Offset: 0x004336E0
	private void JNCNGDHMABB(int PLKMJJIIJNO)
	{
		if (null == this.headerRegularOffers || null == this.content)
		{
			return;
		}
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.headerRegularOffers, this.content);
		gameObject.name = "HeaderAnthology" + PLKMJJIIJNO.ToString();
		gameObject.layer = this.content.gameObject.layer;
		if (null == gameObject.GetComponent<HDTrigger>())
		{
			gameObject.AddComponent<HDTrigger>().setNativeSize = false;
		}
		gameObject.SetActive(true);
		gameObject.transform.SetAsLastSibling();
		TextMeshProUGUI componentInChildren = gameObject.GetComponentInChildren<TextMeshProUGUI>(true);
		if (null != componentInChildren)
		{
			string text = GKJPOGNFKNK.DNILNCLIHAP("anthology" + PLKMJJIIJNO.ToString(), "anthologiestitle", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
			if (text == null || text.Length == 0 || text.EndsWith("_not_found"))
			{
				text = "";
			}
			componentInChildren.SetText(text, true);
		}
		this.GJLMMFJONOF.Add(gameObject);
	}

	// Token: 0x04002B19 RID: 11033
	public const string onSkinShopClose = "OnSkinShopClose";

	// Token: 0x04002B1A RID: 11034
	public const string onSkinShopCardSelected = "OnSkinShopCardSelected";

	// Token: 0x04002B1B RID: 11035
	public static HECEJCDAIOJ lastSelectedEntry;

	// Token: 0x04002B1C RID: 11036
	public static bool shownFromLobby;

	// Token: 0x04002B1D RID: 11037
	public AnimatedPopupManager animatedPopupManager;

	// Token: 0x04002B1E RID: 11038
	public ScrollRect scrollRect;

	// Token: 0x04002B1F RID: 11039
	public RectTransform content;

	// Token: 0x04002B20 RID: 11040
	public GameObject cardPrefab;

	// Token: 0x04002B21 RID: 11041
	public GameObject logo;

	// Token: 0x04002B22 RID: 11042
	public GameObject headerTimedOffers;

	// Token: 0x04002B23 RID: 11043
	public TextMeshProUGUI headerTimedOffersText;

	// Token: 0x04002B24 RID: 11044
	public GameObject headerRegularOffers;

	// Token: 0x04002B25 RID: 11045
	public TextMeshProUGUI headerRegularOffersText;

	// Token: 0x04002B26 RID: 11046
	public GameObject emptyLabel;

	// Token: 0x04002B27 RID: 11047
	public TextMeshProUGUI emptyLabelText;

	// Token: 0x04002B28 RID: 11048
	public GameObject fadeBottom;

	// Token: 0x04002B29 RID: 11049
	public GameObject buttonFilters;

	// Token: 0x04002B2A RID: 11050
	public GameObject buttonCoins;

	// Token: 0x04002B2B RID: 11051
	[NonSerialized]
	private int GLEDKIFIFFL = -1;

	// Token: 0x04002B2C RID: 11052
	private const float LLMFBKDJFOI = 1f;

	// Token: 0x04002B2D RID: 11053
	private const float JANCACDAKHP = 1.2f;

	// Token: 0x04002B2E RID: 11054
	private const float GNHMJKONILH = 0.5f;

	// Token: 0x04002B2F RID: 11055
	private const float HOAILEEIJGK = 11.3776f;

	// Token: 0x04002B30 RID: 11056
	private const float ABPCHJFFHLA = 6f;

	// Token: 0x04002B31 RID: 11057
	private const float IDDKDPHBOLH = 4.2665997f;

	// Token: 0x04002B32 RID: 11058
	private float FOFPODLDNPP;

	// Token: 0x04002B33 RID: 11059
	[NonSerialized]
	private Vector2 EONIHCBBFND = Vector2.zero;

	// Token: 0x04002B34 RID: 11060
	[NonSerialized]
	private Vector2 AEFNACMOHJI = Vector2.zero;

	// Token: 0x04002B35 RID: 11061
	[NonSerialized]
	private bool FOBHDPFBFDK;

	// Token: 0x04002B36 RID: 11062
	[NonSerialized]
	private Coroutine NMIFMADOMMI;

	// Token: 0x04002B37 RID: 11063
	[NonSerialized]
	private Coroutine DEEMILFJFBG;

	// Token: 0x04002B38 RID: 11064
	public const int skinShopTutorialStepIndex = 75;

	// Token: 0x04002B39 RID: 11065
	private const float MLEIJPFJOMP = 1f;

	// Token: 0x04002B3A RID: 11066
	[NonSerialized]
	private Coroutine LODMFHPEFKP;

	// Token: 0x04002B3B RID: 11067
	[NonSerialized]
	private List<GameObject> EENKMENJHFK = new List<GameObject>();

	// Token: 0x04002B3C RID: 11068
	private const string MPIOCNPBPJP = "skinshopfilterbystory";

	// Token: 0x04002B3D RID: 11069
	private const int CEEDAHEBMDG = 0;

	// Token: 0x04002B3E RID: 11070
	private const int KMEAIDHIEFE = 1;

	// Token: 0x04002B3F RID: 11071
	private const int COPECNLNFJE = 2;

	// Token: 0x04002B40 RID: 11072
	[NonSerialized]
	private int EIIBBKAJCNK;

	// Token: 0x04002B41 RID: 11073
	private const string PFKEJGOEIJM = "<i>";

	// Token: 0x04002B42 RID: 11074
	private const string PIPDLGDJDCB = "</i>";

	// Token: 0x04002B43 RID: 11075
	private const float JGEDJFNDHKD = 0.25f;

	// Token: 0x04002B44 RID: 11076
	[NonSerialized]
	private Coroutine HIANOFCOJOG;

	// Token: 0x04002B45 RID: 11077
	private const string JGMJDLIJNEJ = "skinshopfiltersbtn";

	// Token: 0x04002B46 RID: 11078
	private const string HHKBBAKELDP = "skinshopfiltersbtnactive";

	// Token: 0x04002B47 RID: 11079
	public static float nameSwapEpoch;

	// Token: 0x04002B48 RID: 11080
	[NonSerialized]
	private List<GameObject> GJLMMFJONOF = new List<GameObject>();

	// Token: 0x04002B49 RID: 11081
	[NonSerialized]
	private int AHABJKEEHME = -1;

	// Token: 0x04002B4A RID: 11082
	[NonSerialized]
	private List<string> PDLIMLOPGHE;

	// Token: 0x04002B4B RID: 11083
	private const int MNDHIJLHDIE = 4;
}
