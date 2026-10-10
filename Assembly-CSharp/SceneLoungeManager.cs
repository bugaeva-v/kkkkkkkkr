using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using DG.Tweening;
using SimpleJSON;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityStandardAssets.ImageEffects;

// Token: 0x0200016B RID: 363
public class SceneLoungeManager : MonoBehaviour
{
	// Token: 0x06002E1E RID: 11806 RVA: 0x0013C920 File Offset: 0x0013AB20
	public void OnLoungeCurrencyInfoButtonClick()
	{
		if (ODJKHCHFKNL.LEMILALILKP() != DFGILFBGPLN.screenLounge || this.JHNHJPOKJEF)
		{
			return;
		}
		string text = SceneLoungeManager.JLJCHODGBBK("loungetreasuresbody", "specialcurrencyblocktitle");
		text = text.Replace("{sp0}", SceneLoungeManager.EADLKFBBGEH(0)).Replace("{sp1}", SceneLoungeManager.EADLKFBBGEH(1)).Replace("{sp2}", SceneLoungeManager.EADLKFBBGEH(2));
		string text2 = SceneLoungeManager.DANIHEJMMJO();
		if (text2.Length > 0)
		{
			text = text + "\n\n" + SceneLoungeManager.JLJCHODGBBK("loungetokensyouhave", "loungetreasuresyouhave").Replace("{tk}", text2).Replace("{sp}", text2);
		}
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(SceneLoungeManager.JLJCHODGBBK("loungetreasurestitle", "specialcurrencyblocktitle"), text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupSignInQuestion, 0f, 28);
	}

	// Token: 0x06002E1F RID: 11807 RVA: 0x0013C9F4 File Offset: 0x0013ABF4
	private int IBIOOEOJIGL()
	{
		if (this.OFGDGIJNDKL == null)
		{
			return 0;
		}
		if (this.OFGDGIJNDKL.LJFCMJJFCOI.Count > 24)
		{
			return 24;
		}
		return this.OFGDGIJNDKL.LJFCMJJFCOI.Count;
	}

	// Token: 0x06002E20 RID: 11808 RVA: 0x0013CA27 File Offset: 0x0013AC27
	private void CCIBCIFFDOO()
	{
		this.FOPJOMKFBNP = Time.frameCount;
		this.NEFEJOLALAN();
		if (null != this.storyInterfaceHeaderManager)
		{
			this.storyInterfaceHeaderManager.Hide();
		}
	}

	// Token: 0x06002E21 RID: 11809 RVA: 0x0013CA54 File Offset: 0x0013AC54
	private void PHKFKFBEMEH(ref GameObject KFLHPNHJKKD)
	{
		if (null != KFLHPNHJKKD)
		{
			KFLHPNHJKKD.SetActive(false);
			KFLHPNHJKKD = null;
		}
	}

	// Token: 0x06002E22 RID: 11810 RVA: 0x0013CA6C File Offset: 0x0013AC6C
	private void ECNCPOBPHGC()
	{
		this.GLEKHLGJGLI();
		this.FINPJIGDFME();
		if (null != this.loungeExtra)
		{
			this.loungeExtra.SetActive(false);
		}
		if (null != this.loungeHeaderBlur)
		{
			this.loungeHeaderBlur.enabled = false;
		}
		CharacterRenderTexturePool.SetCharacterBandBlur(this.loungeHeaderBlur, false);
		if (null != AssetsManager.EHBBFMCILPC && AssetsManager.EHBBFMCILPC.lobbyLoungeNpcAssets != null)
		{
			AssetsManager.EHBBFMCILPC.lobbyLoungeNpcAssets.Clear();
		}
		SceneLoungeManager.JKPMFPPGMKB = null;
		SceneLoungeManager.OLNLCJEOMDD = null;
		SceneLoungeManager.BKIDGKFEIEH = false;
		SceneLoungeManager.FLGAKNHHPHI = false;
		SceneLoungeManager.GMJBFAHDDAK = false;
		if (DHGFCJGJFOB.KPHNADKJHMJ == this.LPBFAGDJKIH)
		{
			DHGFCJGJFOB.KPHNADKJHMJ = this.NDFACHLEJLJ;
			DHGFCJGJFOB.DFAPCBCDHAO = this.PEGONJGOGBA;
			DHGFCJGJFOB.NAIGDNDPHNC = this.ENGFBODBGJE;
		}
		this.NDFACHLEJLJ = null;
		this.PEGONJGOGBA = "";
		this.ENGFBODBGJE = "";
		this.content.SetActive(false);
		base.gameObject.SetActive(false);
	}

	// Token: 0x06002E23 RID: 11811 RVA: 0x0013CB73 File Offset: 0x0013AD73
	public static void SetPendingLoungeMode(bool GMCNHOACOJP, bool AGMPHFNAFEB)
	{
		SceneLoungeManager.BKIDGKFEIEH = GMCNHOACOJP;
		SceneLoungeManager.FLGAKNHHPHI = AGMPHFNAFEB;
	}

	// Token: 0x06002E24 RID: 11812 RVA: 0x0013CB81 File Offset: 0x0013AD81
	private void IJFNJELABIG()
	{
		this.GLEKHLGJGLI();
		if (null != this.loungeExtra)
		{
			this.loungeExtra.SetActive(false);
		}
	}

	// Token: 0x06002E25 RID: 11813 RVA: 0x0013CBA3 File Offset: 0x0013ADA3
	private IEnumerator OKIBMCFBBMD(string PHEPKKPGMLB, float BICHMDEIFKI)
	{
		yield return new WaitForSeconds(BICHMDEIFKI);
		this.KBKBOHICPBL = null;
		if (ODJKHCHFKNL.LEMILALILKP() != DFGILFBGPLN.screenLounge)
		{
			yield break;
		}
		this.GPPHIJIPDKO(PHEPKKPGMLB);
		yield break;
	}

	// Token: 0x06002E26 RID: 11814 RVA: 0x0013CBC0 File Offset: 0x0013ADC0
	private void LMJGOIINBIC()
	{
		if (ODJKHCHFKNL.LEMILALILKP() != DFGILFBGPLN.screenLounge)
		{
			return;
		}
		PassesItem.reopenOnPurchasingScreenLeft = true;
		CommonUserInterface.EHBBFMCILPC.GetGamePasses().InstantClose();
		this.CBJDJHCFLND();
	}

	// Token: 0x06002E27 RID: 11815 RVA: 0x0013CBE8 File Offset: 0x0013ADE8
	private void CEOEPCIPHEF()
	{
		try
		{
			if (!(null == this.loungeExtraResetButton))
			{
				bool flag = this.PLPKKODECMD().Length > 0;
				this.loungeExtraResetButton.SetActive(flag);
				if (flag)
				{
					Image component = this.loungeExtraResetButton.GetComponent<Image>();
					if (!(null == component))
					{
						Sprite sprite = this.CILDCMPDMJF() ? this.loungeExtraResetSprite1 : this.loungeExtraResetSprite0;
						if (null != sprite)
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

	// Token: 0x06002E28 RID: 11816 RVA: 0x0013CC7C File Offset: 0x0013AE7C
	public void Hide()
	{
		SceneLoungeManager.SetPendingLoungeLook(null);
		this.GLEKHLGJGLI();
		this.FINPJIGDFME();
		if (null != this.loungeExtra)
		{
			this.loungeExtra.SetActive(false);
		}
		if (null != this.loungeHeaderBlur)
		{
			this.loungeHeaderBlur.enabled = false;
		}
		CharacterRenderTexturePool.SetCharacterBandBlur(this.loungeHeaderBlur, false);
		if (null != this.imageEffects)
		{
			this.imageEffects.HideAllEffectsWithTag("");
			this.imageEffects.HideAllEffectsWithTag("blur");
		}
		if (null != this.BPHLDDMNPAI)
		{
			UnityEngine.Object.Destroy(this.BPHLDDMNPAI.gameObject);
			this.BPHLDDMNPAI = null;
		}
		if (DHGFCJGJFOB.KPHNADKJHMJ == this.LPBFAGDJKIH)
		{
			DHGFCJGJFOB.KPHNADKJHMJ = this.NDFACHLEJLJ;
			DHGFCJGJFOB.DFAPCBCDHAO = this.PEGONJGOGBA;
			DHGFCJGJFOB.NAIGDNDPHNC = this.ENGFBODBGJE;
		}
		this.NDFACHLEJLJ = null;
		this.PEGONJGOGBA = "";
		this.ENGFBODBGJE = "";
		this.NPEBMMBADLO = false;
		this.FJIOJFGDGBH = false;
		this.HHNKBNAIGGI = false;
		this.content.SetActive(false);
		base.gameObject.SetActive(false);
	}

	// Token: 0x06002E29 RID: 11817 RVA: 0x0013CDAB File Offset: 0x0013AFAB
	public void OnLoungeShopOrCurrencyInfoClickPart2()
	{
		this.CBJDJHCFLND();
		CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().SetResourcesFilter(JFGBECHLPGI.hardCurrency);
		CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().Show(false);
	}

	// Token: 0x06002E2A RID: 11818 RVA: 0x0013CDD4 File Offset: 0x0013AFD4
	public void Show(bool PCMEHCCFICO = false)
	{
		this.JHNHJPOKJEF = false;
		this.GBDLLBGONAB = -1;
		this.IGAFPNGFMCF = false;
		this.OOCPHDOHGDE = false;
		this.IHANGJHFKCB = false;
		this.FDLBBNKAOPB = false;
		this.LNMEMIDCHMM = false;
		this.HJFAECNJHBE = -1;
		this.NPEBMMBADLO = SceneLoungeManager.BKIDGKFEIEH;
		this.FJIOJFGDGBH = SceneLoungeManager.FLGAKNHHPHI;
		this.HHNKBNAIGGI = SceneLoungeManager.GMJBFAHDDAK;
		SceneLoungeManager.BKIDGKFEIEH = false;
		SceneLoungeManager.FLGAKNHHPHI = false;
		SceneLoungeManager.GMJBFAHDDAK = false;
		if (!this.NPEBMMBADLO)
		{
			NIDOKPOOIHH.GMGPLOLADGB(AKLFPGMDKLA.EHBBFMCILPC.NBMLMNGHOPP());
		}
		if (null != this.loungeHeaderBlur)
		{
			this.loungeHeaderBlur.enabled = false;
		}
		CharacterRenderTexturePool.SetCharacterBandBlur(this.loungeHeaderBlur, false);
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
		this.LPBFAGDJKIH = GKJPOGNFKNK.BDEJIINKEHH(this.loungeAnthologyIndex);
		if (null != this.LPBFAGDJKIH)
		{
			this.NDFACHLEJLJ = DHGFCJGJFOB.KPHNADKJHMJ;
			DHGFCJGJFOB.KPHNADKJHMJ = this.LPBFAGDJKIH;
			this.PEGONJGOGBA = DHGFCJGJFOB.DFAPCBCDHAO;
			DHGFCJGJFOB.DFAPCBCDHAO = this.LPBFAGDJKIH.defaultLoungeChoiceTransition;
			this.ENGFBODBGJE = DHGFCJGJFOB.NAIGDNDPHNC;
			DHGFCJGJFOB.NAIGDNDPHNC = this.LPBFAGDJKIH.defaultLoungeAcknowledgeEffect;
		}
		if (null == this.LPBFAGDJKIH)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("SceneLoungeManager.Show() failed - anthologyHeader is null.");
			return;
		}
		this.HLBIEIAFBFK();
		this.JFNPAPAMDGK();
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeOut(null);
		base.gameObject.SetActive(true);
		base.StartCoroutine(this.HINNFKGAAHE());
		this.IALOMHOIJPH = AssetsManager.EHBBFMCILPC.lobbyDataAsset.MFMJHIFAOHE().ELDKHHGLNBK(this.loungeAnthologyIndex);
		this.OKJDHPBLDCF(true);
		if (this.FEDBGLIOLFK.Count > 0)
		{
			if (this.KCHHNKPHGNN >= this.FEDBGLIOLFK.Count)
			{
				this.KCHHNKPHGNN = 0;
			}
			if (SceneLoungeManager.JKPMFPPGMKB != null)
			{
				for (int i = 0; i < this.FEDBGLIOLFK.Count; i++)
				{
					if (SceneLoungeManager.JKPMFPPGMKB.Equals(this.FEDBGLIOLFK[i].KALBADOPCDN))
					{
						this.KCHHNKPHGNN = i;
						break;
					}
				}
				SceneLoungeManager.JKPMFPPGMKB = null;
			}
			this.OFGDGIJNDKL = this.FEDBGLIOLFK[this.KCHHNKPHGNN];
		}
		SceneLoungeManager.JKPMFPPGMKB = null;
		this.FKGHBCICCPH();
		this.INIPLGHNAEL();
		this.DLMHPEIANCL();
		this.content.SetActive(true);
		if (null != this.loungeExtra)
		{
			this.loungeExtra.SetActive(true);
			this.CEOEPCIPHEF();
			this.BENCCPNJJIM();
		}
		if (null != this.nameParent)
		{
			this.nameParent.SetActive(false);
			this.nameParent.SetActive(true);
		}
		this.FNPJDLCGMAO();
	}

	// Token: 0x06002E2B RID: 11819 RVA: 0x0013D0D1 File Offset: 0x0013B2D1
	public static void SetPendingLoungeLook(string FBKAPCPPNKA)
	{
		SceneLoungeManager.OLNLCJEOMDD = FBKAPCPPNKA;
	}

	// Token: 0x06002E2C RID: 11820 RVA: 0x0013D0DC File Offset: 0x0013B2DC
	private void ABOAPLJBEIN(GameObject HHAHPOLJPBE)
	{
		if (null == HHAHPOLJPBE)
		{
			return;
		}
		AnimationCanvasGroupAlphaClone component = HHAHPOLJPBE.GetComponent<AnimationCanvasGroupAlphaClone>();
		if (null != component)
		{
			component.enabled = false;
		}
		CanvasGroup component2 = HHAHPOLJPBE.GetComponent<CanvasGroup>();
		if (null != component2)
		{
			component2.alpha = 1f;
		}
	}

	// Token: 0x06002E2D RID: 11821 RVA: 0x0013D128 File Offset: 0x0013B328
	private bool DLEBPNAGFPJ(Vector2 LEJEMIBOMFE)
	{
		bool result;
		try
		{
			if (null == this.loungeShopButton || !this.loungeShopButton.activeInHierarchy || !this.ILLNEDFDGOD || this.KLHDJFEDIPM)
			{
				result = false;
			}
			else
			{
				RectTransform component = this.loungeShopButton.GetComponent<RectTransform>();
				if (null == component)
				{
					result = false;
				}
				else
				{
					Canvas componentInParent = this.loungeShopButton.GetComponentInParent<Canvas>();
					Camera cam = (null != componentInParent && componentInParent.renderMode != RenderMode.ScreenSpaceOverlay) ? componentInParent.worldCamera : null;
					result = RectTransformUtility.RectangleContainsScreenPoint(component, LEJEMIBOMFE, cam);
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

	// Token: 0x06002E2E RID: 11822 RVA: 0x0013D1CC File Offset: 0x0013B3CC
	public string ConstructChoiceMeta()
	{
		if (this.OFGDGIJNDKL == null || this.OFGDGIJNDKL.LJFCMJJFCOI.Count == 0)
		{
			return "";
		}
		int num = this.IBIOOEOJIGL();
		if (this.OFGDGIJNDKL.LJFCMJJFCOI.Count > num)
		{
			DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(new string[]
			{
				"[Lounge] character ",
				this.OFGDGIJNDKL.KALBADOPCDN,
				" has ",
				this.OFGDGIJNDKL.LJFCMJJFCOI.Count.ToString(),
				" looks - choice meta capped to ",
				num.ToString()
			}));
		}
		string text = "";
		string text2 = "";
		string text3 = "";
		string text4 = "";
		string text5 = "";
		string text6 = "";
		string text7 = "";
		string text8 = "";
		for (int i = 0; i < num; i++)
		{
			if (i > 0)
			{
				text += ",";
				text2 += ",";
				text3 += ",";
				text4 += ",";
				text5 += ",";
				text6 += ",";
				text7 += ",";
				text8 += ",";
			}
			AFIBCKPKDHB afibckpkdhb = this.OFGDGIJNDKL.LJFCMJJFCOI[i];
			text += afibckpkdhb.BDIHOCKCCBL;
			string text9 = GKJPOGNFKNK.HPAHOEOKEBB(afibckpkdhb.BDIHOCKCCBL, "loungetitles", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
			if (text9 == null || text9.Length == 0 || text9.EndsWith("_not_found"))
			{
				text9 = afibckpkdhb.BDIHOCKCCBL;
			}
			int num2 = afibckpkdhb.CBLPKDDMLBL;
			if (num2 < 0)
			{
				num2 = 0;
			}
			if (num2 >= KBOJLHAJPCP.ANEOABEPFHL.Length)
			{
				num2 = KBOJLHAJPCP.ANEOABEPFHL.Length - 1;
			}
			text9 = "<space=-0.42em>" + KBOJLHAJPCP.ANEOABEPFHL[num2] + "<space=-0.12em>" + text9;
			text9 = text9.Replace(",", "،").Replace("(", "〈").Replace(")", "〉");
			text2 += text9;
			string str = afibckpkdhb.CENMIEOCAMN;
			bool flag = afibckpkdhb.IENEDGACMMK && afibckpkdhb.OBLBNLBFBNI >= 0 && AKLFPGMDKLA.EHBBFMCILPC.OKNDDBOOFPL(afibckpkdhb.OBLBNLBFBNI);
			if (afibckpkdhb.IENEDGACMMK)
			{
				str = "free";
				if (!flag && !SceneLoungeManager.MHOLELNFCOG(afibckpkdhb.PODGFLMDBEC))
				{
					DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(new string[]
					{
						"[Lounge] half-authored shop row (",
						afibckpkdhb.PODGFLMDBEC.ToString(),
						"/",
						afibckpkdhb.LOFFJOKOOKD.ToString(),
						") - not purchasable: ",
						afibckpkdhb.BDIHOCKCCBL
					}));
				}
			}
			text3 += str;
			if (afibckpkdhb.JCJNJNMPPOK != null && afibckpkdhb.JCJNJNMPPOK.Length > 0 && !afibckpkdhb.JCJNJNMPPOK.Equals("none") && afibckpkdhb.ENBBONPKHBC != null && afibckpkdhb.ENBBONPKHBC.Length > 0)
			{
				text4 = text4 + afibckpkdhb.JCJNJNMPPOK + "?" + afibckpkdhb.ENBBONPKHBC;
			}
			else
			{
				text4 += "none";
			}
			if (afibckpkdhb.KEFMKINFOFA)
			{
				text5 += "1";
			}
			else
			{
				text5 += "0";
			}
			string str2 = "none";
			if (afibckpkdhb.IENEDGACMMK && SceneLoungeManager.MHOLELNFCOG(afibckpkdhb.PODGFLMDBEC))
			{
				string str3 = text6;
				int podgflmdbec = (int)afibckpkdhb.PODGFLMDBEC;
				text6 = str3 + podgflmdbec.ToString();
				if (flag && (afibckpkdhb.PODGFLMDBEC == BGDLJKJPOOO.iapOnly || afibckpkdhb.HKLEKGFCMFI != 0))
				{
					str2 = "owned";
				}
				else if (flag)
				{
					str2 = "0";
				}
				else if (afibckpkdhb.PODGFLMDBEC == BGDLJKJPOOO.iapOnly && afibckpkdhb.OBLBNLBFBNI >= 0)
				{
					str2 = KDCJJBLGCBH.EHBBFMCILPC.KHECDLLIOAF(afibckpkdhb.CBLPKDDMLBL);
				}
				else if (afibckpkdhb.OBLBNLBFBNI >= 0)
				{
					str2 = afibckpkdhb.HKLEKGFCMFI.ToString();
				}
			}
			else
			{
				text6 += "-1";
			}
			text7 += str2;
			text8 += ((afibckpkdhb.IENEDGACMMK && SceneLoungeManager.JAIKBANBFDJ(afibckpkdhb) && afibckpkdhb.OBLBNLBFBNI >= 0) ? KDCJJBLGCBH.EHBBFMCILPC.KHECDLLIOAF(afibckpkdhb.CBLPKDDMLBL) : "none");
		}
		return string.Concat(new string[]
		{
			"$CHOICEMETA type(npc) title(",
			SceneLoungeManager.INLLHONLAFF(),
			") asset(",
			text,
			") assettitle(",
			text2,
			") cost(",
			text3,
			") id(",
			text4,
			") requiresubscription(",
			text5,
			") shopcur(",
			text6,
			") shopref(",
			text7,
			") shopsku(",
			text8,
			")"
		});
	}

	// Token: 0x06002E2F RID: 11823 RVA: 0x000693D6 File Offset: 0x000675D6
	public void HPODDFJGAKI()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06002E30 RID: 11824 RVA: 0x0013D6F0 File Offset: 0x0013B8F0
	private void DBIPBCOAEFP(GameObject HHAHPOLJPBE)
	{
		if (null == HHAHPOLJPBE)
		{
			return;
		}
		GridLayoutGroup component = HHAHPOLJPBE.GetComponent<GridLayoutGroup>();
		if (null != component)
		{
			Vector2 spacing = component.spacing;
			spacing.y = -20f;
			component.spacing = spacing;
			component.padding = new RectOffset(component.padding.left, component.padding.right, -1, 2);
		}
	}

	// Token: 0x06002E31 RID: 11825 RVA: 0x0013D754 File Offset: 0x0013B954
	private IEnumerator POFPOFKBNMA()
	{
		yield return new WaitForEndOfFrame();
		yield return new WaitForEndOfFrame();
		yield return new WaitForEndOfFrame();
		this.Hide();
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeOut(null);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnNeedToActivateFocusItemCloseButton", 0f);
		GC.Collect();
		Resources.UnloadUnusedAssets();
		yield break;
	}

	// Token: 0x06002E32 RID: 11826 RVA: 0x0013D764 File Offset: 0x0013B964
	private void EOPDDMFEHBO()
	{
		this.JHNHJPOKJEF = false;
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		if (null != this.storyInterfaceHeaderManager)
		{
			this.EHEFMMIHNCN();
			this.storyInterfaceHeaderManager.Show(0f);
		}
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("app42error") + " (" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD + ")", CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("retry"), new UnityAction(this.OnLoungePremiumChoiceRetry), DFGILFBGPLN.popupBackendError, 0f, 28);
	}

	// Token: 0x06002E33 RID: 11827 RVA: 0x0013D80C File Offset: 0x0013BA0C
	private bool EIAGEIJFDDI()
	{
		return ODJKHCHFKNL.LEMILALILKP() == DFGILFBGPLN.screenLounge && !this.JHNHJPOKJEF && !this.IGAFPNGFMCF && this.OFGDGIJNDKL != null && SemaphoreManager.GreenLight(JLDJNIGMHLC.popups);
	}

	// Token: 0x06002E34 RID: 11828 RVA: 0x0013D838 File Offset: 0x0013BA38
	private void AKLIOPOMGBF()
	{
		this.JHNHJPOKJEF = false;
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		bool flag = SceneStoryManager.premiumChoiceManInTheMiddleAttack != 1 && SceneStoryManager.premiumChoiceBackendOperationResult >= 0 && this.OFGDGIJNDKL != null && this.GBDLLBGONAB >= 0 && this.GBDLLBGONAB < this.OFGDGIJNDKL.LJFCMJJFCOI.Count;
		if (null != this.storyInterfaceHeaderManager && !flag)
		{
			this.EHEFMMIHNCN();
			this.storyInterfaceHeaderManager.Show(0f);
		}
		if (SceneStoryManager.premiumChoiceManInTheMiddleAttack == 1)
		{
			this.GBDLLBGONAB = -1;
			return;
		}
		if (SceneStoryManager.premiumChoiceBackendOperationResult >= 0)
		{
			if (this.OFGDGIJNDKL != null && this.GBDLLBGONAB >= 0 && this.GBDLLBGONAB < this.OFGDGIJNDKL.LJFCMJJFCOI.Count)
			{
				string jcjnjnmppok = this.OFGDGIJNDKL.LJFCMJJFCOI[this.GBDLLBGONAB].JCJNJNMPPOK;
				if (!SceneStoryManager.freePremiumChoicesFallback.Contains(jcjnjnmppok))
				{
					SceneStoryManager.freePremiumChoicesFallback.Add(jcjnjnmppok);
				}
			}
			int gbdllbgonab = this.GBDLLBGONAB;
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnLoungePremiumChoiceExecutedHardBased", 0f);
			this.MDDCBGOCCMA(gbdllbgonab);
			if (gbdllbgonab >= 0 && this.BHNFLFCKHHL != null && this.BHNFLFCKHHL.IPALJDCNBBG != null && gbdllbgonab < this.BHNFLFCKHHL.IPALJDCNBBG.Count)
			{
				this.BHNFLFCKHHL.IPALJDCNBBG[gbdllbgonab] = 0;
			}
			if (gbdllbgonab >= 0 && null != this.BPHLDDMNPAI)
			{
				this.BPHLDDMNPAI.RefreshPremiumChoiceOwnedState(gbdllbgonab);
				this.BPHLDDMNPAI.RefreshShopCostDisplays();
				this.BPHLDDMNPAI.PlayLoungeChoiceConfirmedEffects(true);
				return;
			}
		}
		else
		{
			this.GBDLLBGONAB = -1;
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("holdontitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("nomorediamonds"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), new UnityAction(this.OnLoungeNotEnoughDiamondsGetMore), new UnityAction(this.OnLoungeNotEnoughDiamondsDecline), DFGILFBGPLN.popupNotEnoughHardCurrency, 0f, 28).ShowDiamonds(SceneStoryManager.premiumChoiceBackendOperationResult);
		}
	}

	// Token: 0x06002E35 RID: 11829 RVA: 0x0013DA38 File Offset: 0x0013BC38
	private void HEHJNHGENEA()
	{
		try
		{
			if (!(null == this.BPHLDDMNPAI) && this.OFGDGIJNDKL != null)
			{
				int viewedRemappedChoiceIndex = this.BPHLDDMNPAI.GetViewedRemappedChoiceIndex();
				if (viewedRemappedChoiceIndex >= 0 && viewedRemappedChoiceIndex < this.OFGDGIJNDKL.LJFCMJJFCOI.Count)
				{
					AFIBCKPKDHB afibckpkdhb = this.OFGDGIJNDKL.LJFCMJJFCOI[viewedRemappedChoiceIndex];
					this.GIDECJIDMKN();
					this.JIMDINNDMCJ();
					if (null != this.loungeLockedIcon)
					{
						this.loungeLockedIcon.SetActive(afibckpkdhb.MJLAEJCFCEF);
					}
					if (null != this.loungeInfoUnlockText)
					{
						string text = null;
						if (afibckpkdhb.MJLAEJCFCEF)
						{
							text = this.JPEAFGJAOAA("loungelockedinfo");
						}
						this.loungeInfoUnlockText.gameObject.SetActive(text != null);
						if (text != null)
						{
							this.loungeInfoUnlockText.SetText(this.AOJIGKFMNHJ(text, afibckpkdhb.NLCHIGHHAEC, afibckpkdhb.PKJHDFINDHP), true);
						}
					}
					if (null != this.loungeInfoBonusText)
					{
						string text2 = null;
						if (afibckpkdhb.OLAKHHEICKO >= 0)
						{
							text2 = this.JPEAFGJAOAA("loungebonus" + afibckpkdhb.OLAKHHEICKO.ToString());
						}
						this.loungeInfoBonusText.gameObject.SetActive(text2 != null);
						if (text2 != null)
						{
							this.loungeInfoBonusText.SetText(this.AOJIGKFMNHJ(text2, afibckpkdhb.MDKIKKJNJKK, afibckpkdhb.JNCJNLEAFLG), true);
						}
					}
					if (null != this.loungeInfoLoveInterestText)
					{
						string text3 = null;
						if (afibckpkdhb.PMFNECKIMBG)
						{
							text3 = this.JPEAFGJAOAA("loungelireq");
						}
						this.loungeInfoLoveInterestText.gameObject.SetActive(text3 != null);
						if (text3 != null)
						{
							this.loungeInfoLoveInterestText.SetText(text3, true);
						}
					}
					if (null != this.loungeInfoPanelImage)
					{
						this.loungeInfoPanelImage.enabled = ((null != this.loungeInfoUnlockText && this.loungeInfoUnlockText.gameObject.activeSelf) || (null != this.loungeInfoBonusText && this.loungeInfoBonusText.gameObject.activeSelf));
					}
					if (null != this.loungeInfoPanelImage && null != this.loungeInfoLoveInterestText && this.loungeInfoLoveInterestText.gameObject.activeSelf)
					{
						this.loungeInfoPanelImage.enabled = true;
					}
					this.CEOEPCIPHEF();
					this.BENCCPNJJIM();
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06002E36 RID: 11830 RVA: 0x0013DCA0 File Offset: 0x0013BEA0
	private void OnApplicationFocus(bool MGDCMPCBLPH)
	{
		if (!MGDCMPCBLPH || !this.OOCPHDOHGDE || !this.IGAFPNGFMCF)
		{
			return;
		}
		if (ODJKHCHFKNL.LEMILALILKP() != DFGILFBGPLN.screenLounge)
		{
			return;
		}
		if (AssetsManager.EHBBFMCILPC.IsBusy() || App42Manager.EHBBFMCILPC.IsBusy() || CommonUserInterface.EHBBFMCILPC.ConnectionAnimationEnabled())
		{
			return;
		}
		this.OOCPHDOHGDE = false;
		ApplicationFocusManager.EHBBFMCILPC.ForceBasicSync();
	}

	// Token: 0x06002E37 RID: 11831 RVA: 0x0013DD04 File Offset: 0x0013BF04
	private void OGAPENHPPIA(int MOHKPKNFBLG)
	{
		this.GBDLLBGONAB = MOHKPKNFBLG;
		this.IGAFPNGFMCF = true;
		this.OOCPHDOHGDE = true;
		this.IHANGJHFKCB = true;
		this.JHNHJPOKJEF = false;
		if (null != this.storyInterfaceHeaderManager)
		{
			this.storyInterfaceHeaderManager.OHHFFMMMMAC();
		}
		CommonUserInterface.IKNOFBFMPGA().ShowConnectingAnimation(49);
		bool flag = this.OLEMPGNJDJJ(this.OFGDGIJNDKL.LJFCMJJFCOI[MOHKPKNFBLG]);
		int cooclnadecd = flag ? -1 : this.OFGDGIJNDKL.LJFCMJJFCOI[MOHKPKNFBLG].HKLEKGFCMFI;
		BackendOperationsManager.EHBBFMCILPC.RequestUnlockNpcSkin("ok", "c", this.OFGDGIJNDKL.LJFCMJJFCOI[MOHKPKNFBLG].OBLBNLBFBNI, cooclnadecd, flag ? 0 : 0);
	}

	// Token: 0x06002E38 RID: 11832 RVA: 0x0013DDC1 File Offset: 0x0013BFC1
	private static bool MHOLELNFCOG(BGDLJKJPOOO KCMMNPLNPGL)
	{
		return KCMMNPLNPGL == BGDLJKJPOOO.specialCurrency0 || KCMMNPLNPGL == BGDLJKJPOOO.specialCurrency1 || KCMMNPLNPGL == BGDLJKJPOOO.specialCurrency2 || KCMMNPLNPGL == BGDLJKJPOOO.iapOnly;
	}

	// Token: 0x06002E39 RID: 11833 RVA: 0x00003E52 File Offset: 0x00002052
	private void Awake()
	{
	}

	// Token: 0x06002E3A RID: 11834 RVA: 0x0013DDD4 File Offset: 0x0013BFD4
	private void OGEPLCJBBHA(int MOHKPKNFBLG)
	{
		AFIBCKPKDHB afibckpkdhb = this.OFGDGIJNDKL.LJFCMJJFCOI[MOHKPKNFBLG];
		string text = KDCJJBLGCBH.EHBBFMCILPC.ABGPKNDPNCD(afibckpkdhb.CBLPKDDMLBL);
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.PMABBOJDELF().IJLAPHFKPMH(text);
		if (ocbiopoeenj == null)
		{
			string[] array = new string[]
			{
				null,
				"OnBackendInitiateSteamTransactionException"
			};
			array[0] = text;
			array[8] = "p";
			array[4] = afibckpkdhb.BDIHOCKCCBL;
			array[6] = "adserrorbody";
			DPGJIJGOCIC.ANOPFDLPKGC(string.Concat(array));
			return;
		}
		this.GBDLLBGONAB = MOHKPKNFBLG;
		this.GIGAHKHAGDO = afibckpkdhb.OBLBNLBFBNI;
		this.IGAFPNGFMCF = true;
		this.IHANGJHFKCB = true;
		this.GAFPIBFMAKM = text;
		ProductThumbnailManager.lastAccessedProductWebLink = ocbiopoeenj.FDMCFAHEELN() + "OnStorySplashManagerCdnSuccess" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		if (SceneLoungeManager.LFIMIMECDPE())
		{
			this.OOCPHDOHGDE = true;
			CommonUserInterface.IKNOFBFMPGA().ShowPopupOnlineResources(ocbiopoeenj.BIKJFCLHPBK() + "sksku" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 7);
			return;
		}
		if (null != this.storyInterfaceHeaderManager)
		{
			this.storyInterfaceHeaderManager.OHHFFMMMMAC();
		}
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.OnLoungeSkinStorePurchaseContinue));
	}

	// Token: 0x06002E3B RID: 11835 RVA: 0x0013DEF9 File Offset: 0x0013C0F9
	private void LLHEILLCKCL()
	{
		if (ODJKHCHFKNL.JMCDGLKNCNF() != DFGILFBGPLN.popupNotEnoughStats)
		{
			return;
		}
		this.KLHDJFEDIPM = false;
		if (this.ILLNEDFDGOD)
		{
			this.KGINBPGBJLJ(618f);
		}
	}

	// Token: 0x06002E3C RID: 11836 RVA: 0x0013DF20 File Offset: 0x0013C120
	private static string BPBNKMPJCLH(AFIBCKPKDHB BLACDCEJPFE)
	{
		string result;
		try
		{
			result = ChoiceExtendedManager.GetShopLocalizedPrice(KDCJJBLGCBH.EHBBFMCILPC.KHECDLLIOAF(BLACDCEJPFE.CBLPKDDMLBL));
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = "";
		}
		return result;
	}

	// Token: 0x06002E3D RID: 11837 RVA: 0x0013DF64 File Offset: 0x0013C164
	private List<string> AFBGKDLFBLM()
	{
		List<string> list = new List<string>();
		for (int i = 0; i < this.FEDBGLIOLFK.Count; i++)
		{
			if (this.FEDBGLIOLFK[i] != null && this.FEDBGLIOLFK[i].KALBADOPCDN != null && !list.Contains(this.FEDBGLIOLFK[i].KALBADOPCDN))
			{
				list.Add(this.FEDBGLIOLFK[i].KALBADOPCDN);
			}
		}
		return list;
	}

	// Token: 0x06002E3E RID: 11838 RVA: 0x0013DFE0 File Offset: 0x0013C1E0
	private void EENCPNOHPGO(string OKDNLCOEOIJ)
	{
		if (this.JHNHJPOKJEF)
		{
			return;
		}
		if (this.FEDBGLIOLFK.Count == 0)
		{
			return;
		}
		int num = -1;
		for (int i = 0; i < this.FEDBGLIOLFK.Count; i++)
		{
			if (this.FEDBGLIOLFK[i].KALBADOPCDN.Equals(OKDNLCOEOIJ))
			{
				num = i;
				break;
			}
		}
		if (num < 0)
		{
			return;
		}
		this.GBDLLBGONAB = -1;
		this.IGAFPNGFMCF = false;
		this.KCHHNKPHGNN = num;
		this.EGFOGFNCIKJ = this.OFGDGIJNDKL;
		this.OFGDGIJNDKL = this.FEDBGLIOLFK[this.KCHHNKPHGNN];
		this.LKIDJFJBLGH();
		this.CCIBCIFFDOO();
		this.KPBFHKGIFID();
	}

	// Token: 0x06002E40 RID: 11840 RVA: 0x0013E0BE File Offset: 0x0013C2BE
	private void GPBICDPCHFP()
	{
		this.JNPGJBIMNND();
		this.DLMHPEIANCL();
		this.FNPJDLCGMAO();
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeOut(new TweenCallback(this.KDOMGNHCFAM));
	}

	// Token: 0x06002E41 RID: 11841 RVA: 0x0013E0F0 File Offset: 0x0013C2F0
	public void RemoveSuperMappingForCurrentCharacter()
	{
		if (this.OFGDGIJNDKL == null)
		{
			return;
		}
		string fbkapcppnka = AKLFPGMDKLA.EHBBFMCILPC.NBMLMNGHOPP().NCAMFPGMCIG.GLBDHEKDNDC(this.OFGDGIJNDKL.KALBADOPCDN);
		AKLFPGMDKLA.EHBBFMCILPC.NBMLMNGHOPP().NCAMFPGMCIG.EAHMPCPAMOF(this.OFGDGIJNDKL.KALBADOPCDN);
		AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
		for (int i = 0; i < AssetsManager.EHBBFMCILPC.storyAssets.Count; i++)
		{
			AssetsManager.EHBBFMCILPC.storyAssets[i].ReleaseSuperMappedLookNpcAnimationPacks(fbkapcppnka);
		}
		this.ECDBIPGBIBM("loungeskinremoved", 0.5f);
	}

	// Token: 0x06002E42 RID: 11842 RVA: 0x0013E18F File Offset: 0x0013C38F
	private static bool LFIMIMECDPE()
	{
		return LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru && GeoLocationManager.IsRussia() && KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA();
	}

	// Token: 0x06002E43 RID: 11843 RVA: 0x0013E1B1 File Offset: 0x0013C3B1
	private void JKLAIOPONDF()
	{
		if (ODJKHCHFKNL.LEMILALILKP() != DFGILFBGPLN.screenLounge)
		{
			return;
		}
		this.HEHJNHGENEA();
	}

	// Token: 0x06002E44 RID: 11844 RVA: 0x0013E1C3 File Offset: 0x0013C3C3
	private void EHEFMMIHNCN()
	{
		if (null != this.loungeHeaderBlur)
		{
			this.loungeHeaderBlur.enabled = true;
		}
		CharacterRenderTexturePool.SetCharacterBandBlur(this.loungeHeaderBlur, true);
	}

	// Token: 0x06002E45 RID: 11845 RVA: 0x0013E1EB File Offset: 0x0013C3EB
	private IEnumerator NOJFOHNGHGM()
	{
		yield return new WaitForSeconds(0.75f);
		this.MPBAFMPGJII = null;
		this.CGCBAPIAFAC();
		yield break;
	}

	// Token: 0x06002E46 RID: 11846 RVA: 0x0013E1FC File Offset: 0x0013C3FC
	public void CloseLounge()
	{
		if (this.JHNHJPOKJEF)
		{
			return;
		}
		this.JHNHJPOKJEF = true;
		AudioManager.EHBBFMCILPC.KillMusic("", CommonUserInterface.EHBBFMCILPC.GetFader().GetFadeInDuration());
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.OEIMCIHPHMD));
		if (null != this.storyInterfaceHeaderManager)
		{
			this.storyInterfaceHeaderManager.Hide();
		}
	}

	// Token: 0x06002E48 RID: 11848 RVA: 0x0013E35B File Offset: 0x0013C55B
	private static bool JAIKBANBFDJ(AFIBCKPKDHB BLACDCEJPFE)
	{
		return BLACDCEJPFE != null && BLACDCEJPFE.DENODLCMDAL != null && BLACDCEJPFE.DENODLCMDAL.ECMIHEAHOLL();
	}

	// Token: 0x06002E49 RID: 11849 RVA: 0x0013E378 File Offset: 0x0013C578
	private int HDLLFFAHEKH()
	{
		try
		{
			PLFDAJJHMKO plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.NBMLMNGHOPP();
			if (plfdajjhmko == null || plfdajjhmko.NCAMFPGMCIG.HOHELAOMLGL == null || this.OFGDGIJNDKL == null)
			{
				return -1;
			}
			int num = this.IBIOOEOJIGL();
			for (int i = plfdajjhmko.NCAMFPGMCIG.HOHELAOMLGL.Count - 1; i >= 0; i--)
			{
				for (int j = 0; j < num; j++)
				{
					if (plfdajjhmko.NCAMFPGMCIG.HOHELAOMLGL[i].Equals(this.OFGDGIJNDKL.LJFCMJJFCOI[j].BDIHOCKCCBL))
					{
						return j;
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return -1;
	}

	// Token: 0x06002E4A RID: 11850 RVA: 0x0013E430 File Offset: 0x0013C630
	private void FKGHBCICCPH()
	{
		try
		{
			if (null == this.ONOLLMGCAOK)
			{
				this.ONOLLMGCAOK = this.BLKLDGBGPCC("ButtonPrevNpc");
			}
			if (null == this.IHPHNLDPJIP)
			{
				this.IHPHNLDPJIP = this.BLKLDGBGPCC("ButtonNextNpc");
			}
			bool active = this.FEDBGLIOLFK.Count > 1;
			if (null != this.ONOLLMGCAOK)
			{
				this.ONOLLMGCAOK.SetActive(active);
			}
			if (null != this.IHPHNLDPJIP)
			{
				this.IHPHNLDPJIP.SetActive(active);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06002E4B RID: 11851 RVA: 0x0013E4D8 File Offset: 0x0013C6D8
	private void CGCBAPIAFAC()
	{
		try
		{
			if (!(null == this.loungeExtra))
			{
				if (null == this.HIGMMPJDADP)
				{
					this.HIGMMPJDADP = this.loungeExtra.GetComponent<AnimationCanvasGroupAlpha>();
				}
				if (!(null == this.HIGMMPJDADP))
				{
					this.GHHPEBABMFN();
					this.HIGMMPJDADP.animationTime = 0.5f;
					this.IIJAOCAAMHI(true);
					this.HIGMMPJDADP.SetDirection(false);
					this.HIGMMPJDADP.PlayAnimation(false);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06002E4C RID: 11852 RVA: 0x0013E574 File Offset: 0x0013C774
	public void OnLoungePremiumChoiceRetry()
	{
		if (this.OFGDGIJNDKL != null && this.GBDLLBGONAB >= 0 && this.GBDLLBGONAB < this.OFGDGIJNDKL.LJFCMJJFCOI.Count && this.BHNFLFCKHHL != null && this.GBDLLBGONAB < this.BHNFLFCKHHL.MKPMEKKGEIL.Count)
		{
			AFIBCKPKDHB afibckpkdhb = this.OFGDGIJNDKL.LJFCMJJFCOI[this.GBDLLBGONAB];
			this.JHNHJPOKJEF = true;
			if (null != this.storyInterfaceHeaderManager)
			{
				this.storyInterfaceHeaderManager.Hide();
			}
			CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(96);
			BackendOperationsManager.EHBBFMCILPC.RequestPremiumChoice(this.BHNFLFCKHHL.MKPMEKKGEIL[this.GBDLLBGONAB], afibckpkdhb.NLCHIGHHAEC, afibckpkdhb.PKJHDFINDHP, afibckpkdhb.BDIHOCKCCBL, AKLFPGMDKLA.EHBBFMCILPC.NCOCIAENGJF(AKLFPGMDKLA.EHBBFMCILPC.NBMLMNGHOPP().DHONIOBOLEL.GGICIBLJIKI), false, "OnLoungePremiumChoiceSuccess", "OnLoungePremiumChoiceException", true);
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("OnLoungePremiumChoiceRetry() - invalid situation.");
	}

	// Token: 0x06002E4D RID: 11853 RVA: 0x00003E52 File Offset: 0x00002052
	private void HNBAIHAJECB()
	{
	}

	// Token: 0x06002E4E RID: 11854 RVA: 0x0013E684 File Offset: 0x0013C884
	private void PEIEEJLJHJB()
	{
		this.LKIDJFJBLGH();
		if (null != this.BPHLDDMNPAI)
		{
			UnityEngine.Object.Destroy(this.BPHLDDMNPAI.gameObject);
			this.BPHLDDMNPAI = null;
		}
		if (null == this.extendedChoicePrefab || this.OFGDGIJNDKL == null || this.OFGDGIJNDKL.LJFCMJJFCOI.Count == 0)
		{
			return;
		}
		this.BHNFLFCKHHL = new PMNHKIDIMLM(this.ConstructChoiceMeta());
		this.BOONNHPBKMP(this.BHNFLFCKHHL);
		this.JOOPBLFMOFF = null;
		if (this.BHNFLFCKHHL.IPALJDCNBBG != null)
		{
			this.JOOPBLFMOFF = new List<int>(this.BHNFLFCKHHL.IPALJDCNBBG);
		}
		this.KNHOGPLHCMH = new LHBFJJIJNMI(this.IBIOOEOJIGL());
		this.KNHOGPLHCMH.JMNMOHIKHLB = this.BHNFLFCKHHL;
		this.KNHOGPLHCMH.MPEFKCINMLI();
		string[] array = new string[93];
		string text = CCOJBMMKNAP.INKJIBDDMLL().HPOAGPJFHPM("@");
		array[(int)LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()] = text;
		array[0] = text;
		this.LGFMFJAMNDL(array);
		for (int i = 0; i < this.KNHOGPLHCMH.COEFNFJMBDG.Count; i += 0)
		{
			this.KNHOGPLHCMH.COEFNFJMBDG[i].KIPCNAMEGPD = (string[])array.Clone();
		}
		this.CPNKBDPKGOE(this.BHNFLFCKHHL.BPMFHNDCBOH);
		List<AssetStoryNpc> list = new List<AssetStoryNpc>();
		for (int j = 0; j < this.IBIOOEOJIGL(); j++)
		{
			AssetStoryNpc assetStoryNpc = GKJPOGNFKNK.IAJMHBFGKBA(this.OFGDGIJNDKL.LJFCMJJFCOI[j].BDIHOCKCCBL, "OnLiveProfileThemeDownloadSuccess");
			if (null != assetStoryNpc)
			{
				list.Add(assetStoryNpc);
			}
		}
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.extendedChoicePrefab);
		gameObject.transform.SetParent(this.extendedChoicePivot.transform, false);
		this.JPOHEIPCPHM(gameObject, this.extendedChoicePivot.layer);
		this.extendedChoicePivot.transform.SetAsFirstSibling();
		this.BPHLDDMNPAI = gameObject.GetComponent<ChoiceExtendedManager>();
		this.ACDFDKHMAFA();
		this.BPHLDDMNPAI.SetSwipeToBrowseHostGate(new Func<bool>(this.EIAGEIJFDDI));
		this.BPHLDDMNPAI.SetLoungeShopCostDisplacement(this.loungeShopCostDisplacement);
		this.BPHLDDMNPAI.SetLoungeShopButtonSprites(this.loungeShopButtonSprite, this.loungeShopButtonPressedSprite);
		this.EMOKHOCGNMA = true;
		this.BPHLDDMNPAI.SetLoungeSingleLookTitleExpand(1476f);
		this.BPHLDDMNPAI.SetLoungeLookPreview(false);
		string text2 = this.PLPKKODECMD();
		int num = -1;
		if (SceneLoungeManager.OLNLCJEOMDD != null && SceneLoungeManager.OLNLCJEOMDD.Length > 0)
		{
			for (int k = 0; k < this.IBIOOEOJIGL(); k += 0)
			{
				if (SceneLoungeManager.OLNLCJEOMDD.Equals(this.OFGDGIJNDKL.LJFCMJJFCOI[k].BDIHOCKCCBL))
				{
					num = k;
					break;
				}
			}
			SceneLoungeManager.OLNLCJEOMDD = null;
		}
		if (num < 0 && text2.Length > 1)
		{
			for (int l = 1; l < this.IBIOOEOJIGL(); l += 0)
			{
				if (text2.Equals(this.OFGDGIJNDKL.LJFCMJJFCOI[l].BDIHOCKCCBL))
				{
					num = l;
					break;
				}
			}
		}
		if (num < 1)
		{
			num = this.HDLLFFAHEKH();
		}
		if (num >= 1)
		{
			this.BPHLDDMNPAI.CDBNALOMEPD(num);
		}
		this.BPHLDDMNPAI.GBFEDHPAIBH(this.KNHOGPLHCMH, AKLFPGMDKLA.EHBBFMCILPC.NBMLMNGHOPP(), null, list, null);
		List<int> list2 = new List<int>();
		for (int m = 1; m < this.IBIOOEOJIGL(); m++)
		{
			if (this.OFGDGIJNDKL.LJFCMJJFCOI[m].MJLAEJCFCEF)
			{
				list2.Add(m);
			}
		}
		this.BPHLDDMNPAI.SetLoungePremiumInfoVisibilityRules(list2);
	}

	// Token: 0x06002E4F RID: 11855 RVA: 0x0013EA1C File Offset: 0x0013CC1C
	private void KGINBPGBJLJ(float BICHMDEIFKI = 0f)
	{
		SceneLoungeManager.CEBGHJEIJLA cebghjeijla = new SceneLoungeManager.CEBGHJEIJLA();
		cebghjeijla.canvasGroup = this.ALCDLOONDCI();
		if (null == cebghjeijla.canvasGroup || null == this.loungeShopButton || !this.loungeShopButton.activeSelf || !this.ILLNEDFDGOD || this.KLHDJFEDIPM)
		{
			return;
		}
		cebghjeijla.canvasGroup.DOKill(false);
		cebghjeijla.canvasGroup.DOFade(1f, 0.5f).SetDelay(BICHMDEIFKI).SetEase(Ease.Linear).OnComplete(new TweenCallback(cebghjeijla.FCGBDCNFABK));
	}

	// Token: 0x06002E50 RID: 11856 RVA: 0x0013EAB5 File Offset: 0x0013CCB5
	private void PKLKPMNFIBC()
	{
		if (this.KBKBOHICPBL != null)
		{
			base.StopCoroutine(this.KBKBOHICPBL);
			this.KBKBOHICPBL = null;
		}
	}

	// Token: 0x06002E51 RID: 11857 RVA: 0x0013EAD2 File Offset: 0x0013CCD2
	private float IJLAOBBMKFM()
	{
		if (!NarrowScreenScaler.ScreenIsTooNarrow(960f))
		{
			return 0f;
		}
		return Mathf.Clamp01((NBDLBFJOEGN.LAIDCKNIOIN() - 2f) / 0.33299994f);
	}

	// Token: 0x06002E52 RID: 11858 RVA: 0x0013EAFC File Offset: 0x0013CCFC
	public void SetLoungeCharacters(List<GHMINFEGBGN> BGJOHDEAHPG)
	{
		this.FEDBGLIOLFK = BGJOHDEAHPG;
		this.KCHHNKPHGNN = 0;
		this.OFGDGIJNDKL = null;
		this.EGFOGFNCIKJ = null;
	}

	// Token: 0x06002E53 RID: 11859 RVA: 0x0013EB1C File Offset: 0x0013CD1C
	public static void ShowLoungeTreasuresPopup()
	{
		string text = SceneLoungeManager.JLJCHODGBBK("loungetreasuresbody", "specialcurrencyblocktitle");
		text = text.Replace("{sp0}", SceneLoungeManager.EADLKFBBGEH(0)).Replace("{sp1}", SceneLoungeManager.EADLKFBBGEH(1)).Replace("{sp2}", SceneLoungeManager.EADLKFBBGEH(2));
		string text2 = SceneLoungeManager.DANIHEJMMJO();
		if (text2.Length > 0)
		{
			text = text + "\n\n" + SceneLoungeManager.JLJCHODGBBK("loungetokensyouhave", "loungetreasuresyouhave").Replace("{tk}", text2).Replace("{sp}", text2);
		}
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(SceneLoungeManager.JLJCHODGBBK("loungetreasurestitle", "specialcurrencyblocktitle"), text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupSignInQuestion, 0f, 28);
	}

	// Token: 0x06002E54 RID: 11860 RVA: 0x0013EBE0 File Offset: 0x0013CDE0
	private void OnEnable()
	{
		ODJKHCHFKNL.HIPEENBHGKP(DFGILFBGPLN.screenLounge);
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPostEffectSettingsChanged", new UnityAction(this.HLBIEIAFBFK));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnApplicationRestart", new UnityAction(this.ECNCPOBPHGC));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnStoryInterfaceHeaderBackClick", new UnityAction(this.LLNENMOMNKP));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnStoryInterfaceHeaderSettingsClick", new UnityAction(this.NFCDJBPAFEI));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnStoryInterfaceHeaderShopClick", new UnityAction(this.NEMEBAJLLAO));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnStoryCurrencyInfoClick", new UnityAction(this.POBAACAEFJH));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnStoryChoiceClick", new UnityAction(this.IFHMKEPKEGE));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnLoungePremiumChoiceSuccess", new UnityAction(this.AKLIOPOMGBF));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnLoungePremiumChoiceException", new UnityAction(this.EOPDDMFEHBO));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnLoungeUnlockNpcSkinSuccess", new UnityAction(this.LONGIEBMKIG));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnLoungeUnlockNpcSkinException", new UnityAction(this.KLEHEIFNEIA));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnApplicationFocusBasicSyncSuccess", new UnityAction(this.MPDBGKEMFPF));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnGamePassUnlockContinueToPurchasingScreen", new UnityAction(this.LMJGOIINBIC));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnSkinShopCardSelected", new UnityAction(this.EHKDHDDJHLL));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnSkinShopClose", new UnityAction(this.FBCKCJPPPNE));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnStoryInterfaceHeaderShown", new UnityAction(this.CDJNFHDOMFI));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnStoryInterfaceHeaderHideComplete", new UnityAction(this.NOHMAEJCHLC));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPurchasingViewLeave", new UnityAction(this.IAIIODBDKHK));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendPassResourcesChangedType0", new UnityAction(this.BGECHBHBLBM));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPopupOfferManagerContinueToPurchasingScreen", new UnityAction(this.CPEELJJHCNA));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnLoungeLoveInterestShortcutClick", new UnityAction(this.PKCPHJBMPPH));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnStoryInterfaceHeaderShown", new UnityAction(this.LACMGDNIIDI));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnStoryInterfaceHeaderHideComplete", new UnityAction(this.GKADNDECANG));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnChoiceExtendedPanelSlideShown", new UnityAction(this.LKHJBFDHMHN));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnChoiceExtendedPanelSlideHidden", new UnityAction(this.KMIAPGDBLML));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnChoiceExtendedPanelSlideShownComplete", new UnityAction(this.JGFLGCMHIIK));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnChoiceExtendedViewedChoiceChanged", new UnityAction(this.JKLAIOPONDF));
	}

	// Token: 0x06002E55 RID: 11861 RVA: 0x0013EED0 File Offset: 0x0013D0D0
	private static string EADLKFBBGEH(int MEFKFOHCOHK)
	{
		if (MEFKFOHCOHK == 0)
		{
			return KBOJLHAJPCP.DBCAFJGPECE + AKLFPGMDKLA.EHBBFMCILPC.OJNBAMPGBLJ.GALKFKBPLCK().ToString();
		}
		if (1 == MEFKFOHCOHK)
		{
			return KBOJLHAJPCP.DGMDEJKHKFL + AKLFPGMDKLA.EHBBFMCILPC.DOFKEHNPCIJ.GALKFKBPLCK().ToString();
		}
		return KBOJLHAJPCP.KMEBHIBPPJC + AKLFPGMDKLA.EHBBFMCILPC.PBEPCNFADAA.GALKFKBPLCK().ToString();
	}

	// Token: 0x06002E56 RID: 11862 RVA: 0x0013EF49 File Offset: 0x0013D149
	public void OnLoungeNotEnoughDiamondsGetMore2()
	{
		this.CBJDJHCFLND();
		CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().SetResourcesFilter(JFGBECHLPGI.hardCurrency);
		CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().Show(true);
	}

	// Token: 0x06002E57 RID: 11863 RVA: 0x0013EF74 File Offset: 0x0013D174
	private string JPEAFGJAOAA(string PHEPKKPGMLB)
	{
		string text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(PHEPKKPGMLB);
		if (text == null || text.Length == 0 || text.EndsWith("_not_found"))
		{
			DPGJIJGOCIC.ADFCDFHBDAF("[Lounge] info text key missing, widget stays hidden: " + PHEPKKPGMLB);
			return null;
		}
		return text;
	}

	// Token: 0x06002E58 RID: 11864 RVA: 0x0013EFB8 File Offset: 0x0013D1B8
	private void LKIDJFJBLGH()
	{
		if (null == this.nameText)
		{
			return;
		}
		string text = "";
		try
		{
			if (this.OFGDGIJNDKL != null && this.OFGDGIJNDKL.KALBADOPCDN != null && null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				DMDNKJKEPKO dmdnkjkepko = AssetsManager.EHBBFMCILPC.lobbyDataAsset.MFMJHIFAOHE().DLCFCKOCIGB(this.OFGDGIJNDKL.KALBADOPCDN);
				if (dmdnkjkepko != null && dmdnkjkepko.KMHILDMHJMA != null && dmdnkjkepko.KMHILDMHJMA.Length > 0)
				{
					string text2 = GKJPOGNFKNK.HPAHOEOKEBB(dmdnkjkepko.KMHILDMHJMA, "lititle", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
					if (text2 != null && text2.Length > 0 && !text2.EndsWith("_not_found"))
					{
						text = text2;
					}
				}
			}
			if (text.Length == 0 && this.OFGDGIJNDKL != null && this.OFGDGIJNDKL.KALBADOPCDN != null && null != AssetsManager.EHBBFMCILPC.profileDataAsset)
			{
				JSONArray jsonarray = AssetsManager.EHBBFMCILPC.profileDataAsset.GIOFKDDKAPD();
				if (null != jsonarray)
				{
					for (int i = 0; i < jsonarray.Count; i++)
					{
						JSONObject asObject = jsonarray[i].AsObject;
						string text3 = asObject["oid"];
						if (text3 != null && text3.Replace(" ", "").Equals(this.OFGDGIJNDKL.KALBADOPCDN))
						{
							string text4 = asObject["lititle"];
							if (text4 == null || text4.Replace(" ", "").Length == 0)
							{
								string text5 = asObject["var"];
								string text6 = asObject["ant"];
								text4 = ((text5 != null) ? text5.Replace(" ", "") : "") + ((text6 != null) ? text6.Replace(" ", "") : "");
							}
							if (text4 != null && text4.Replace(" ", "").Length != 0)
							{
								string text7 = GKJPOGNFKNK.HPAHOEOKEBB(text4.Replace(" ", ""), "lititle", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
								if (text7 != null && text7.Length > 0 && !text7.EndsWith("_not_found"))
								{
									text = text7;
									break;
								}
								break;
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
		this.nameText.SetText(text, true);
	}

	// Token: 0x06002E59 RID: 11865 RVA: 0x0013F264 File Offset: 0x0013D464
	private void GHHPEBABMFN()
	{
		if (this.MPBAFMPGJII != null)
		{
			base.StopCoroutine(this.MPBAFMPGJII);
			this.MPBAFMPGJII = null;
		}
	}

	// Token: 0x06002E5A RID: 11866 RVA: 0x0013F284 File Offset: 0x0013D484
	private void JFNPAPAMDGK()
	{
		StoryInterfaceHeaderManager storyInterfaceHeaderManager = this.storyInterfaceHeaderManager;
		try
		{
			if (!this.POFOPOOBAEF && !(null == this.storyInterfaceHeaderManager))
			{
				GameObject gameObject = AssetsManager.EHBBFMCILPC.lobbyDataAsset.storyInterfaceHeaderManagerPrefabV2;
				if (null == gameObject)
				{
					gameObject = AssetsManager.EHBBFMCILPC.lobbyDataAsset.storyInterfaceHeaderManagerPrefab;
				}
				if (!(null == gameObject))
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(gameObject, this.storyInterfaceHeaderManager.gameObject.transform.parent.transform, false);
					this.JPOHEIPCPHM(gameObject2, this.storyInterfaceHeaderManager.gameObject.layer);
					this.storyInterfaceHeaderManager.gameObject.SetActive(false);
					this.storyInterfaceHeaderManager = gameObject2.GetComponent<StoryInterfaceHeaderManager>();
					this.storyInterfaceHeaderManager.gamePassInterfaceUndoButtonPrefab = null;
					this.PHKFKFBEMEH(ref this.storyInterfaceHeaderManager.optionsParent);
					this.PHKFKFBEMEH(ref this.storyInterfaceHeaderManager.statsParent);
					this.PHKFKFBEMEH(ref this.storyInterfaceHeaderManager.statsParent2);
					Transform[] componentsInChildren = gameObject2.GetComponentsInChildren<Transform>(true);
					for (int i = 0; i < componentsInChildren.Length; i++)
					{
						if (componentsInChildren[i].gameObject.name.Equals("ButtonAvatar"))
						{
							Button component = componentsInChildren[i].gameObject.GetComponent<Button>();
							if (null != component)
							{
								component.interactable = false;
							}
						}
					}
					this.POFOPOOBAEF = true;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			if (!this.POFOPOOBAEF && null != storyInterfaceHeaderManager)
			{
				storyInterfaceHeaderManager.gameObject.SetActive(true);
				this.storyInterfaceHeaderManager = storyInterfaceHeaderManager;
				this.POFOPOOBAEF = true;
			}
		}
	}

	// Token: 0x06002E5B RID: 11867 RVA: 0x0013F42C File Offset: 0x0013D62C
	private void AICFJBAJECM()
	{
		if (this.JHNHJPOKJEF)
		{
			return;
		}
		this.CCIBCIFFDOO();
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.BEPGMIFCJAF));
	}

	// Token: 0x06002E5C RID: 11868 RVA: 0x0013F458 File Offset: 0x0013D658
	private void NFEDANNNOFK(int MOHKPKNFBLG)
	{
		AFIBCKPKDHB afibckpkdhb = this.OFGDGIJNDKL.LJFCMJJFCOI[MOHKPKNFBLG];
		string text = KDCJJBLGCBH.EHBBFMCILPC.KHECDLLIOAF(afibckpkdhb.CBLPKDDMLBL);
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.EHBBFMCILPC.PDJKPFLHFLO(text);
		if (ocbiopoeenj == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC(string.Concat(new string[]
			{
				"[Lounge] skin sku unknown to the purchasing balance, purchase ignored: ",
				text,
				" (",
				afibckpkdhb.BDIHOCKCCBL,
				")"
			}));
			return;
		}
		this.GBDLLBGONAB = MOHKPKNFBLG;
		this.GIGAHKHAGDO = afibckpkdhb.OBLBNLBFBNI;
		this.IGAFPNGFMCF = true;
		this.IHANGJHFKCB = false;
		this.GAFPIBFMAKM = text;
		ProductThumbnailManager.lastAccessedProductWebLink = ocbiopoeenj.MBLAIKOOCFH() + "?uid=" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		if (SceneLoungeManager.LFIMIMECDPE())
		{
			this.OOCPHDOHGDE = true;
			CommonUserInterface.EHBBFMCILPC.ShowPopupOnlineResources(ocbiopoeenj.MBLAIKOOCFH() + "?uid=" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD, 2);
			return;
		}
		if (null != this.storyInterfaceHeaderManager)
		{
			this.storyInterfaceHeaderManager.Hide();
		}
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.OnLoungeSkinStorePurchaseContinue));
	}

	// Token: 0x06002E5D RID: 11869 RVA: 0x0013F580 File Offset: 0x0013D780
	private void LACMGDNIIDI()
	{
		if (ODJKHCHFKNL.LEMILALILKP() != DFGILFBGPLN.screenLounge)
		{
			return;
		}
		if (null == this.nameParent || !this.nameParent.activeSelf)
		{
			return;
		}
		CanvasGroup component = this.nameParent.GetComponent<CanvasGroup>();
		AnimationCanvasGroupAlpha component2 = this.nameParent.GetComponent<AnimationCanvasGroupAlpha>();
		if (null != component2)
		{
			component2.enabled = false;
		}
		if (null == component || component.alpha < 0.05f)
		{
			this.nameParent.SetActive(false);
			if (null != component2)
			{
				component2.enabled = true;
			}
			return;
		}
		if (this.HNMOGHGGELK != null)
		{
			base.StopCoroutine(this.HNMOGHGGELK);
		}
		float jcbghbcaiol = 0.375f;
		if (null != component2)
		{
			jcbghbcaiol = component2.animationTime * 0.5f;
		}
		this.HNMOGHGGELK = base.StartCoroutine(this.EMIOFGFANDA(component, component2, jcbghbcaiol));
	}

	// Token: 0x06002E5E RID: 11870 RVA: 0x0013F653 File Offset: 0x0013D853
	private void NPKHGMPNODC(string BBAHLPPFEPO)
	{
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.OHLNGCKIACD("spld"), SceneLoungeManager.JLJCHODGBBK(BBAHLPPFEPO, ""), CCOJBMMKNAP.APGODIBBPOD().HIPJILDCHJC("breakCard"), (DFGILFBGPLN)(-16), 597f, 82);
	}

	// Token: 0x06002E5F RID: 11871 RVA: 0x0013F694 File Offset: 0x0013D894
	private void GPALJLAPPEH()
	{
		try
		{
			this.ABMAGBPBCGE = false;
			if (!(null == this.loungeExtra) && !(null == this.BPHLDDMNPAI) && !(null == this.BPHLDDMNPAI.slidingPanelButtonHide))
			{
				RectTransform component = this.BPHLDDMNPAI.slidingPanelButtonHide.GetComponent<RectTransform>();
				if (!(null == component))
				{
					this.loungeExtra.transform.SetAsLastSibling();
					Vector3[] array = new Vector3[4];
					component.GetWorldCorners(array);
					Vector3 slidingPanelWorldOffsetToRest = this.BPHLDDMNPAI.GetSlidingPanelWorldOffsetToRest();
					float y = (array[0].y + array[2].y) * 0.5f;
					Vector3 position = new Vector3(array[0].x, y, array[0].z) + slidingPanelWorldOffsetToRest;
					Vector3 vector = this.loungeExtra.transform.InverseTransformPoint(position);
					float num = this.IJLAOBBMKFM();
					this.EAMLEJINMDD = Mathf.Lerp(1f, this.loungeExtraNarrowDownscale, num);
					this.BCACBGFHKPC = new Vector2(this.loungeExtraNarrowOffsetX * num, this.loungeExtraNarrowOffsetY * num);
					this.FECODDDOIPB(this.loungeCurrencyInfoButton, vector.x - 48f, vector.y);
					if (null != this.loungeCurrencyInfoButton)
					{
						this.JKIKIAEJKDO = this.loungeCurrencyInfoButton.transform.localPosition;
					}
					float ofmkfjhpgdj = vector.x - 48f - 80f * this.EAMLEJINMDD - 17f;
					this.FECODDDOIPB(this.loungeExtraResetButton, ofmkfjhpgdj, vector.y);
					if (null != this.loungeExtraResetButton)
					{
						this.MLDLPLPLJNH = this.loungeExtraResetButton.transform.localPosition;
					}
					this.ABMAGBPBCGE = true;
					this.CEOEPCIPHEF();
					this.BENCCPNJJIM();
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06002E60 RID: 11872 RVA: 0x0013F898 File Offset: 0x0013DA98
	private void HDKCFBFFLKC(int MOHKPKNFBLG)
	{
		if (MOHKPKNFBLG < 1 || this.OFGDGIJNDKL == null || MOHKPKNFBLG >= this.OFGDGIJNDKL.LJFCMJJFCOI.Count)
		{
			return;
		}
		AFIBCKPKDHB afibckpkdhb = this.OFGDGIJNDKL.LJFCMJJFCOI[MOHKPKNFBLG];
		if (SceneLoungeManager.KGKBPOKPBEP(afibckpkdhb.PODGFLMDBEC).HOJDOEDDIBD() < afibckpkdhb.HKLEKGFCMFI)
		{
			this.KELJIKDEAID(afibckpkdhb.PODGFLMDBEC);
			return;
		}
		this.FDLBBNKAOPB = true;
		this.OGAPENHPPIA(MOHKPKNFBLG);
	}

	// Token: 0x06002E61 RID: 11873 RVA: 0x0013F90A File Offset: 0x0013DB0A
	private int ICCNCOPLMBN(GHMINFEGBGN CMENACFAEGD)
	{
		if (CMENACFAEGD != null && CMENACFAEGD.OIBGFPEGLME >= 1)
		{
			return CMENACFAEGD.OIBGFPEGLME;
		}
		return AKLFPGMDKLA.EHBBFMCILPC.NBMLMNGHOPP().NCAMFPGMCIG.OIBGFPEGLME;
	}

	// Token: 0x06002E62 RID: 11874 RVA: 0x0013F933 File Offset: 0x0013DB33
	public void OnLoungeLookTitleClick()
	{
		this.LAGFBBKENMF();
	}

	// Token: 0x06002E63 RID: 11875 RVA: 0x0013F93B File Offset: 0x0013DB3B
	private static int MPOCKKPLLPA(BGDLJKJPOOO KCMMNPLNPGL)
	{
		if (KCMMNPLNPGL == BGDLJKJPOOO.specialCurrency0)
		{
			return 0;
		}
		if (KCMMNPLNPGL == BGDLJKJPOOO.specialCurrency1)
		{
			return 1;
		}
		if (KCMMNPLNPGL == BGDLJKJPOOO.specialCurrency2)
		{
			return 2;
		}
		return -1;
	}

	// Token: 0x06002E64 RID: 11876 RVA: 0x0013F94F File Offset: 0x0013DB4F
	private void KDOMGNHCFAM()
	{
		if (this.LPBFAGDJKIH.MHJMNIHFFEN())
		{
			CommonUserInterface.EHBBFMCILPC.GetFader().SetCustomFader(null, null);
		}
	}

	// Token: 0x06002E65 RID: 11877 RVA: 0x0013F970 File Offset: 0x0013DB70
	private static bool DCEINPOHIJO(AFIBCKPKDHB BLACDCEJPFE)
	{
		if (BLACDCEJPFE == null || BLACDCEJPFE.DENODLCMDAL == null || BLACDCEJPFE.PODGFLMDBEC == BGDLJKJPOOO.iapOnly || BLACDCEJPFE.PODGFLMDBEC == BGDLJKJPOOO.none)
		{
			return false;
		}
		long celgkakngbg = AKLFPGMDKLA.EHBBFMCILPC.CDNGHFCPPEA();
		int num = BLACDCEJPFE.DENODLCMDAL.NIOGHOKEKDI(celgkakngbg);
		int num2 = BLACDCEJPFE.DENODLCMDAL.BMJIGANCIDG(celgkakngbg);
		if (num == BLACDCEJPFE.HKLEKGFCMFI && num2 == BLACDCEJPFE.CGCLCPOHJEP)
		{
			return false;
		}
		BLACDCEJPFE.HKLEKGFCMFI = num;
		BLACDCEJPFE.CGCLCPOHJEP = num2;
		return true;
	}

	// Token: 0x06002E66 RID: 11878 RVA: 0x0013F9E4 File Offset: 0x0013DBE4
	private void JIMDINNDMCJ()
	{
		if (null == this.loungeInfoPanelImage)
		{
			return;
		}
		this.loungeInfoPanelImage.raycastTarget = true;
		LoungeTapGuard loungeTapGuard = this.loungeInfoPanelImage.GetComponent<LoungeTapGuard>();
		if (null == loungeTapGuard)
		{
			loungeTapGuard = this.loungeInfoPanelImage.gameObject.AddComponent<LoungeTapGuard>();
			loungeTapGuard.onTap = new Action(this.OnLoungeInfoPanelClick);
		}
	}

	// Token: 0x06002E67 RID: 11879 RVA: 0x0013FA44 File Offset: 0x0013DC44
	private void GIDPGHCNHMM(bool JNHHHLGIHIO)
	{
		try
		{
			if (!(null == this.loungeExtra))
			{
				if (null == this.CCMBCGANCDO)
				{
					this.CCMBCGANCDO = this.loungeExtra.GetComponent<CanvasGroup>();
				}
				if (!(null == this.CCMBCGANCDO))
				{
					this.CCMBCGANCDO.blocksRaycasts = JNHHHLGIHIO;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06002E68 RID: 11880 RVA: 0x0013FAB8 File Offset: 0x0013DCB8
	private void BEPGMIFCJAF()
	{
		this.FNPJDLCGMAO();
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeOut(new TweenCallback(this.KDOMGNHCFAM));
	}

	// Token: 0x06002E69 RID: 11881 RVA: 0x0013FADC File Offset: 0x0013DCDC
	private bool EDCODEDHKOG()
	{
		if (null == this.BPHLDDMNPAI || this.OFGDGIJNDKL == null)
		{
			return false;
		}
		int viewedRemappedChoiceIndex = this.BPHLDDMNPAI.GetViewedRemappedChoiceIndex();
		if (viewedRemappedChoiceIndex < 1 || viewedRemappedChoiceIndex >= this.OFGDGIJNDKL.LJFCMJJFCOI.Count)
		{
			return true;
		}
		string text = this.PLPKKODECMD();
		return text.Length > 1 && text.Equals(this.OFGDGIJNDKL.LJFCMJJFCOI[viewedRemappedChoiceIndex].BDIHOCKCCBL);
	}

	// Token: 0x06002E6A RID: 11882 RVA: 0x0013FB54 File Offset: 0x0013DD54
	private void LONGIEBMKIG()
	{
		this.JHNHJPOKJEF = false;
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		this.MCPPJPHIFGE();
		int num = SceneLoungeManager.unlockNpcSkinResult;
		int num2 = SceneLoungeManager.unlockNpcSkinError;
		SceneLoungeManager.unlockNpcSkinResult = 0;
		SceneLoungeManager.unlockNpcSkinError = 0;
		bool flag = num == 1 && this.OFGDGIJNDKL != null && this.GBDLLBGONAB >= 0 && this.GBDLLBGONAB < this.OFGDGIJNDKL.LJFCMJJFCOI.Count;
		if (null != this.storyInterfaceHeaderManager && !flag)
		{
			this.EHEFMMIHNCN();
			this.storyInterfaceHeaderManager.Show(0f);
		}
		if (flag)
		{
			int gbdllbgonab = this.GBDLLBGONAB;
			AFIBCKPKDHB afibckpkdhb = this.OFGDGIJNDKL.LJFCMJJFCOI[gbdllbgonab];
			if (!AKLFPGMDKLA.EHBBFMCILPC.BGMKEDLDMFN.Contains(afibckpkdhb.OBLBNLBFBNI))
			{
				AKLFPGMDKLA.EHBBFMCILPC.BGMKEDLDMFN.Add(afibckpkdhb.OBLBNLBFBNI);
			}
			this.MDDCBGOCCMA(gbdllbgonab);
			if (this.BHNFLFCKHHL != null)
			{
				if (this.BHNFLFCKHHL.IPALJDCNBBG != null && gbdllbgonab < this.BHNFLFCKHHL.IPALJDCNBBG.Count)
				{
					this.BHNFLFCKHHL.IPALJDCNBBG[gbdllbgonab] = 0;
				}
				this.BHNFLFCKHHL.EBNHOAAGCDL(gbdllbgonab);
			}
			if (null != this.BPHLDDMNPAI)
			{
				this.BPHLDDMNPAI.RefreshPremiumChoiceOwnedState(gbdllbgonab);
				this.BPHLDDMNPAI.RefreshShopCostDisplays();
				this.BPHLDDMNPAI.PlayLoungeChoiceConfirmedEffects(true);
			}
			return;
		}
		int gbdllbgonab2 = this.GBDLLBGONAB;
		this.GBDLLBGONAB = -1;
		bool flag2 = this.OFGDGIJNDKL != null && gbdllbgonab2 >= 0 && gbdllbgonab2 < this.OFGDGIJNDKL.LJFCMJJFCOI.Count;
		if (num2 == 6)
		{
			if (flag2)
			{
				this.OFGDGIJNDKL.LJFCMJJFCOI[gbdllbgonab2].DJDEHGFEANC = true;
			}
			this.OANFNDEPNOB("loungeofferexpired");
			return;
		}
		if (num2 == 7)
		{
			if (flag2 && SceneLoungeManager.DCEINPOHIJO(this.OFGDGIJNDKL.LJFCMJJFCOI[gbdllbgonab2]))
			{
				this.AICFJBAJECM();
				return;
			}
			if (flag2)
			{
				this.OFGDGIJNDKL.LJFCMJJFCOI[gbdllbgonab2].DJDEHGFEANC = true;
			}
			this.OANFNDEPNOB("loungepricechanged");
			return;
		}
		else
		{
			if (num2 == 2)
			{
				this.KELJIKDEAID(flag2 ? this.OFGDGIJNDKL.LJFCMJJFCOI[gbdllbgonab2].PODGFLMDBEC : BGDLJKJPOOO.none);
				return;
			}
			if (num2 == 3)
			{
				bool flag3 = flag2 && this.OLEMPGNJDJJ(this.OFGDGIJNDKL.LJFCMJJFCOI[gbdllbgonab2]) && !AKLFPGMDKLA.EHBBFMCILPC.CIAONGKLBEP(this.OFGDGIJNDKL.LJFCMJJFCOI[gbdllbgonab2].CBLPKDDMLBL);
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), flag3 ? SceneLoungeManager.JLJCHODGBBK("loungeskintokenmissing", "loungeskinpurchasepending") : SceneLoungeManager.JLJCHODGBBK("loungeskinpurchasepending", "app42error"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
				if (flag3)
				{
					this.AICFJBAJECM();
				}
				return;
			}
			if (num2 == 4)
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), SceneLoungeManager.JLJCHODGBBK("loungeskinupdaterequired", "outdatedrev"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
				return;
			}
			if (num2 == 5)
			{
				if (flag2)
				{
					this.OFGDGIJNDKL.LJFCMJJFCOI[gbdllbgonab2].DJDEHGFEANC = true;
				}
				this.OANFNDEPNOB("loungeskinunavailable");
				return;
			}
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("app42error") + " (" + num2.ToString() + ")", CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupBackendError, 0f, 28);
			return;
		}
	}

	// Token: 0x06002E6B RID: 11883 RVA: 0x0013FEFC File Offset: 0x0013E0FC
	private void PJKFBCFOBGE(int MOHKPKNFBLG)
	{
		this.GBDLLBGONAB = MOHKPKNFBLG;
		this.IGAFPNGFMCF = false;
		this.OOCPHDOHGDE = false;
		this.IHANGJHFKCB = false;
		this.JHNHJPOKJEF = true;
		if (null != this.storyInterfaceHeaderManager)
		{
			this.storyInterfaceHeaderManager.Hide();
		}
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(96);
		bool flag = this.OLEMPGNJDJJ(this.OFGDGIJNDKL.LJFCMJJFCOI[MOHKPKNFBLG]);
		int cooclnadecd = flag ? -1 : this.OFGDGIJNDKL.LJFCMJJFCOI[MOHKPKNFBLG].HKLEKGFCMFI;
		BackendOperationsManager.EHBBFMCILPC.RequestUnlockNpcSkin("OnLoungeUnlockNpcSkinSuccess", "OnLoungeUnlockNpcSkinException", this.OFGDGIJNDKL.LJFCMJJFCOI[MOHKPKNFBLG].OBLBNLBFBNI, cooclnadecd, flag ? 1 : 0);
	}

	// Token: 0x06002E6C RID: 11884 RVA: 0x0013FFB9 File Offset: 0x0013E1B9
	private void GLEKHLGJGLI()
	{
		this.BDBCLBEKFCI();
		if (null != this.loungeExtraNotificationGeneric)
		{
			this.loungeExtraNotificationGeneric.SetActive(false);
		}
	}

	// Token: 0x06002E6D RID: 11885 RVA: 0x0013FFDB File Offset: 0x0013E1DB
	private void IGLJKADOCJI()
	{
		if (this.JHNHJPOKJEF)
		{
			return;
		}
		this.CCIBCIFFDOO();
		CommonUserInterface.EHBBFMCILPC.GetFader().PACBMBLIGNN(new TweenCallback(this.BEPGMIFCJAF));
	}

	// Token: 0x06002E6E RID: 11886 RVA: 0x00140008 File Offset: 0x0013E208
	private void CEODODIBAMA(int MOHKPKNFBLG)
	{
		if (MOHKPKNFBLG < 1 || this.OFGDGIJNDKL == null || MOHKPKNFBLG >= this.OFGDGIJNDKL.LJFCMJJFCOI.Count)
		{
			this.GBDLLBGONAB = -1;
			return;
		}
		AFIBCKPKDHB afibckpkdhb = this.OFGDGIJNDKL.LJFCMJJFCOI[MOHKPKNFBLG];
		string text = AKLFPGMDKLA.EHBBFMCILPC.NBMLMNGHOPP().NCAMFPGMCIG.GLBDHEKDNDC(this.OFGDGIJNDKL.KALBADOPCDN);
		AKLFPGMDKLA.EHBBFMCILPC.NBMLMNGHOPP().NCAMFPGMCIG.DHNGLOEKKFL(this.OFGDGIJNDKL.KALBADOPCDN, afibckpkdhb.BDIHOCKCCBL);
		AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
		for (int i = 1; i < AssetsManager.EHBBFMCILPC.storyAssets.Count; i++)
		{
			AssetsManager.EHBBFMCILPC.storyAssets[i].PromoteLoungeNpcAssetToChapterLifetime(afibckpkdhb.BDIHOCKCCBL);
			if (text != null && text.Length > 0 && !text.Equals(afibckpkdhb.BDIHOCKCCBL))
			{
				AssetsManager.MJBDMHPHMID().storyAssets[i].ReleaseSuperMappedLookNpcAnimationPacks(text);
			}
		}
		this.GBDLLBGONAB = -1;
		this.IGAFPNGFMCF = true;
		this.ECDBIPGBIBM("saveslotsoptionsbody", 1438f);
		this.CEOEPCIPHEF();
		this.BENCCPNJJIM();
	}

	// Token: 0x06002E6F RID: 11887 RVA: 0x0014012C File Offset: 0x0013E32C
	private void FNPJDLCGMAO()
	{
		this.LKIDJFJBLGH();
		if (null != this.BPHLDDMNPAI)
		{
			UnityEngine.Object.Destroy(this.BPHLDDMNPAI.gameObject);
			this.BPHLDDMNPAI = null;
		}
		if (null == this.extendedChoicePrefab || this.OFGDGIJNDKL == null || this.OFGDGIJNDKL.LJFCMJJFCOI.Count == 0)
		{
			return;
		}
		this.BHNFLFCKHHL = new PMNHKIDIMLM(this.ConstructChoiceMeta());
		this.BOONNHPBKMP(this.BHNFLFCKHHL);
		this.JOOPBLFMOFF = null;
		if (this.BHNFLFCKHHL.IPALJDCNBBG != null)
		{
			this.JOOPBLFMOFF = new List<int>(this.BHNFLFCKHHL.IPALJDCNBBG);
		}
		this.KNHOGPLHCMH = new LHBFJJIJNMI(this.IBIOOEOJIGL());
		this.KNHOGPLHCMH.JMNMOHIKHLB = this.BHNFLFCKHHL;
		this.KNHOGPLHCMH.PKGCGJFFEPM();
		string[] array = new string[32];
		string text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("loungeapplybtn");
		array[(int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage()] = text;
		array[0] = text;
		this.LGFMFJAMNDL(array);
		for (int i = 0; i < this.KNHOGPLHCMH.COEFNFJMBDG.Count; i++)
		{
			this.KNHOGPLHCMH.COEFNFJMBDG[i].KIPCNAMEGPD = (string[])array.Clone();
		}
		this.LGFMFJAMNDL(this.BHNFLFCKHHL.BPMFHNDCBOH);
		List<AssetStoryNpc> list = new List<AssetStoryNpc>();
		for (int j = 0; j < this.IBIOOEOJIGL(); j++)
		{
			AssetStoryNpc assetStoryNpc = GKJPOGNFKNK.IAJMHBFGKBA(this.OFGDGIJNDKL.LJFCMJJFCOI[j].BDIHOCKCCBL, "");
			if (null != assetStoryNpc)
			{
				list.Add(assetStoryNpc);
			}
		}
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.extendedChoicePrefab);
		gameObject.transform.SetParent(this.extendedChoicePivot.transform, false);
		this.JPOHEIPCPHM(gameObject, this.extendedChoicePivot.layer);
		this.extendedChoicePivot.transform.SetAsFirstSibling();
		this.BPHLDDMNPAI = gameObject.GetComponent<ChoiceExtendedManager>();
		this.ACDFDKHMAFA();
		this.BPHLDDMNPAI.SetSwipeToBrowseHostGate(new Func<bool>(this.EIAGEIJFDDI));
		this.BPHLDDMNPAI.SetLoungeShopCostDisplacement(this.loungeShopCostDisplacement);
		this.BPHLDDMNPAI.SetLoungeShopButtonSprites(this.loungeShopButtonSprite, this.loungeShopButtonPressedSprite);
		this.EMOKHOCGNMA = true;
		this.BPHLDDMNPAI.SetLoungeSingleLookTitleExpand(22.76f);
		this.BPHLDDMNPAI.SetLoungeLookPreview(true);
		string text2 = this.PLPKKODECMD();
		int num = -1;
		if (SceneLoungeManager.OLNLCJEOMDD != null && SceneLoungeManager.OLNLCJEOMDD.Length > 0)
		{
			for (int k = 0; k < this.IBIOOEOJIGL(); k++)
			{
				if (SceneLoungeManager.OLNLCJEOMDD.Equals(this.OFGDGIJNDKL.LJFCMJJFCOI[k].BDIHOCKCCBL))
				{
					num = k;
					break;
				}
			}
			SceneLoungeManager.OLNLCJEOMDD = null;
		}
		if (num < 0 && text2.Length > 0)
		{
			for (int l = 0; l < this.IBIOOEOJIGL(); l++)
			{
				if (text2.Equals(this.OFGDGIJNDKL.LJFCMJJFCOI[l].BDIHOCKCCBL))
				{
					num = l;
					break;
				}
			}
		}
		if (num < 0)
		{
			num = this.HDLLFFAHEKH();
		}
		if (num >= 0)
		{
			this.BPHLDDMNPAI.SetInitialChoiceByRemappedIndex(num);
		}
		this.BPHLDDMNPAI.Initialize(this.KNHOGPLHCMH, AKLFPGMDKLA.EHBBFMCILPC.NBMLMNGHOPP(), null, list, null);
		List<int> list2 = new List<int>();
		for (int m = 0; m < this.IBIOOEOJIGL(); m++)
		{
			if (this.OFGDGIJNDKL.LJFCMJJFCOI[m].MJLAEJCFCEF)
			{
				list2.Add(m);
			}
		}
		this.BPHLDDMNPAI.SetLoungePremiumInfoVisibilityRules(list2);
	}

	// Token: 0x06002E70 RID: 11888 RVA: 0x0013F933 File Offset: 0x0013DB33
	public void OnLoungeInfoPanelClick()
	{
		this.LAGFBBKENMF();
	}

	// Token: 0x06002E71 RID: 11889 RVA: 0x001404C4 File Offset: 0x0013E6C4
	private float PCEOBEIGLCD(GameObject MINGLBHFIBN, float OFMKFJHPGDJ, float HAFCALHOOGE)
	{
		if (null == MINGLBHFIBN)
		{
			return OFMKFJHPGDJ;
		}
		RectTransform component = MINGLBHFIBN.GetComponent<RectTransform>();
		if (null == component)
		{
			return OFMKFJHPGDJ;
		}
		component.localScale = new Vector3(this.EAMLEJINMDD, this.EAMLEJINMDD, 222f);
		float num = component.sizeDelta.x * this.EAMLEJINMDD;
		component.localPosition = new Vector3(OFMKFJHPGDJ - num * 463f + this.loungeExtraDisplacement.x + this.BCACBGFHKPC.x, HAFCALHOOGE + this.loungeExtraDisplacement.y + this.BCACBGFHKPC.y, 1003f);
		MINGLBHFIBN.SetActive(true);
		return OFMKFJHPGDJ - num - 141f;
	}

	// Token: 0x06002E72 RID: 11890 RVA: 0x00140577 File Offset: 0x0013E777
	private void NOHMAEJCHLC()
	{
		if (ODJKHCHFKNL.LEMILALILKP() != DFGILFBGPLN.screenLounge)
		{
			return;
		}
		this.KLHDJFEDIPM = false;
		if (this.ILLNEDFDGOD)
		{
			this.KGINBPGBJLJ(0f);
		}
	}

	// Token: 0x06002E73 RID: 11891 RVA: 0x001405A0 File Offset: 0x0013E7A0
	private bool CILDCMPDMJF()
	{
		if (null == this.BPHLDDMNPAI || this.OFGDGIJNDKL == null)
		{
			return false;
		}
		int viewedRemappedChoiceIndex = this.BPHLDDMNPAI.GetViewedRemappedChoiceIndex();
		if (viewedRemappedChoiceIndex < 0 || viewedRemappedChoiceIndex >= this.OFGDGIJNDKL.LJFCMJJFCOI.Count)
		{
			return false;
		}
		string text = this.PLPKKODECMD();
		return text.Length > 0 && text.Equals(this.OFGDGIJNDKL.LJFCMJJFCOI[viewedRemappedChoiceIndex].BDIHOCKCCBL);
	}

	// Token: 0x06002E74 RID: 11892 RVA: 0x00140618 File Offset: 0x0013E818
	private void JNPGJBIMNND()
	{
		if (this.HNMOGHGGELK == null)
		{
			return;
		}
		base.StopCoroutine(this.HNMOGHGGELK);
		this.HNMOGHGGELK = null;
		if (null == this.nameParent)
		{
			return;
		}
		AnimationCanvasGroupAlpha component = this.nameParent.GetComponent<AnimationCanvasGroupAlpha>();
		this.nameParent.SetActive(false);
		if (null != component)
		{
			component.enabled = true;
		}
	}

	// Token: 0x06002E75 RID: 11893 RVA: 0x00140678 File Offset: 0x0013E878
	private CanvasGroup ALCDLOONDCI()
	{
		if (null == this.loungeShopButton)
		{
			return null;
		}
		if (null == this.ILFEBNOCOPK)
		{
			this.ILFEBNOCOPK = this.loungeShopButton.GetComponent<CanvasGroup>();
		}
		return this.ILFEBNOCOPK;
	}

	// Token: 0x06002E76 RID: 11894 RVA: 0x001406B0 File Offset: 0x0013E8B0
	public void OnLoungeResetMappingClick()
	{
		if (ODJKHCHFKNL.LEMILALILKP() != DFGILFBGPLN.screenLounge)
		{
			return;
		}
		if (this.JHNHJPOKJEF)
		{
			return;
		}
		if (this.PLPKKODECMD().Length == 0)
		{
			this.GPPHIJIPDKO("loungenothingtoreset");
			return;
		}
		if (SceneLoungeManager.PBFAFGBGPGI())
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), SceneLoungeManager.JLJCHODGBBK("loungestoryfinished", "specialcurrencyoptionna"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupSignInQuestion, 0f, 28);
			return;
		}
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("areyousure"), SceneLoungeManager.JLJCHODGBBK("loungeresetconfirm", "areyousure"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("no"), new UnityAction(this.DOMMFKCABHC), new UnityAction(this.HNBAIHAJECB), DFGILFBGPLN.popupSignInQuestion, 0f, 28);
	}

	// Token: 0x06002E77 RID: 11895 RVA: 0x0014079A File Offset: 0x0013E99A
	private void ECDBIPGBIBM(string PHEPKKPGMLB, float BICHMDEIFKI)
	{
		this.BDBCLBEKFCI();
		this.KBKBOHICPBL = base.StartCoroutine(this.OKIBMCFBBMD(PHEPKKPGMLB, BICHMDEIFKI));
	}

	// Token: 0x06002E78 RID: 11896 RVA: 0x001407B8 File Offset: 0x0013E9B8
	private void Update()
	{
		if (ODJKHCHFKNL.LEMILALILKP() != DFGILFBGPLN.screenLounge || this.JHNHJPOKJEF || !SemaphoreManager.GreenLight(JLDJNIGMHLC.popups))
		{
			return;
		}
		if (null != this.BPHLDDMNPAI)
		{
			this.BPHLDDMNPAI.UpdateSwipeToBrowse();
			if (ChoiceExtendedManager.SwipeConsumedRelease())
			{
				this.FOPJOMKFBNP = Time.frameCount;
			}
		}
		if (Time.frameCount <= this.FOPJOMKFBNP + 1)
		{
			return;
		}
		if (!Input.GetMouseButtonUp(0) && !Input.GetMouseButtonUp(1))
		{
			if (DPGJIJGOCIC.PCOOFHCMKGI())
			{
				Vector2 vector = DPGJIJGOCIC.AHELOLJOHLJ();
				if (this.DLEBPNAGFPJ(new Vector2(vector.x * (float)Screen.width, vector.y * (float)Screen.height)))
				{
					return;
				}
				this.GMKKHHBHMNP(vector.y, false);
			}
			return;
		}
		if (this.DLEBPNAGFPJ(Input.mousePosition))
		{
			return;
		}
		this.GMKKHHBHMNP(DPGJIJGOCIC.KLPPJLLBJAP().y, true);
	}

	// Token: 0x06002E79 RID: 11897 RVA: 0x00140891 File Offset: 0x0013EA91
	private bool OLEMPGNJDJJ(AFIBCKPKDHB BLACDCEJPFE)
	{
		return BLACDCEJPFE != null && (BLACDCEJPFE.PODGFLMDBEC == BGDLJKJPOOO.iapOnly || (SceneLoungeManager.JAIKBANBFDJ(BLACDCEJPFE) && this.FDLBBNKAOPB));
	}

	// Token: 0x06002E7A RID: 11898 RVA: 0x001408B4 File Offset: 0x0013EAB4
	private bool GGJILABOAMB(int KFCMLNPLAHK)
	{
		try
		{
			if (this.IALOMHOIJPH == null)
			{
				return false;
			}
			ECAPOEGMMIB ecapoegmmib = this.IALOMHOIJPH.HIKFKHDNDHJ(KFCMLNPLAHK);
			if (ecapoegmmib == null || ecapoegmmib.KPPJINFHMIP == null || ecapoegmmib.KPPJINFHMIP.Length == 0)
			{
				return false;
			}
			if (!AudioManager.EHBBFMCILPC.AudioClipAvailable(CCEMAFOMLLK.music, ecapoegmmib.KPPJINFHMIP))
			{
				return false;
			}
			return AudioManager.EHBBFMCILPC.PlayMusic(ecapoegmmib.KPPJINFHMIP, true, -1f, false);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return false;
	}

	// Token: 0x06002E7B RID: 11899 RVA: 0x00140944 File Offset: 0x0013EB44
	private void IIJAOCAAMHI(bool JNHHHLGIHIO)
	{
		try
		{
			if (!(null == this.loungeExtra))
			{
				if (null == this.CCMBCGANCDO)
				{
					this.CCMBCGANCDO = this.loungeExtra.GetComponent<CanvasGroup>();
				}
				if (!(null == this.CCMBCGANCDO))
				{
					this.CCMBCGANCDO.blocksRaycasts = JNHHHLGIHIO;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06002E7C RID: 11900 RVA: 0x001409B8 File Offset: 0x0013EBB8
	private void EJNHFJCFGPI(int MOHKPKNFBLG)
	{
		if (MOHKPKNFBLG < 0 || this.OFGDGIJNDKL == null || MOHKPKNFBLG >= this.OFGDGIJNDKL.LJFCMJJFCOI.Count)
		{
			return;
		}
		AFIBCKPKDHB afibckpkdhb = this.OFGDGIJNDKL.LJFCMJJFCOI[MOHKPKNFBLG];
		if (SceneLoungeManager.KGKBPOKPBEP(afibckpkdhb.PODGFLMDBEC).GALKFKBPLCK() < afibckpkdhb.HKLEKGFCMFI)
		{
			this.KELJIKDEAID(afibckpkdhb.PODGFLMDBEC);
			return;
		}
		this.FDLBBNKAOPB = false;
		this.PJKFBCFOBGE(MOHKPKNFBLG);
	}

	// Token: 0x06002E7D RID: 11901 RVA: 0x00140A2C File Offset: 0x0013EC2C
	private static string INLLHONLAFF()
	{
		string text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("loungechoosetitle");
		if (text == null || text.Length == 0 || text.EndsWith("_not_found"))
		{
			text = "Choose a look";
		}
		return "$en" + text.Replace(",", "،").Replace("(", "〈").Replace(")", "〉");
	}

	// Token: 0x06002E7E RID: 11902 RVA: 0x00140AA0 File Offset: 0x0013ECA0
	private void OnDisable()
	{
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPostEffectSettingsChanged", new UnityAction(this.HLBIEIAFBFK));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnApplicationRestart", new UnityAction(this.ECNCPOBPHGC));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnStoryInterfaceHeaderBackClick", new UnityAction(this.LLNENMOMNKP));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnStoryInterfaceHeaderSettingsClick", new UnityAction(this.NFCDJBPAFEI));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnStoryInterfaceHeaderShopClick", new UnityAction(this.NEMEBAJLLAO));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnStoryCurrencyInfoClick", new UnityAction(this.POBAACAEFJH));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnStoryChoiceClick", new UnityAction(this.IFHMKEPKEGE));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnLoungePremiumChoiceSuccess", new UnityAction(this.AKLIOPOMGBF));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnLoungePremiumChoiceException", new UnityAction(this.EOPDDMFEHBO));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnLoungeUnlockNpcSkinSuccess", new UnityAction(this.LONGIEBMKIG));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnLoungeUnlockNpcSkinException", new UnityAction(this.KLEHEIFNEIA));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnApplicationFocusBasicSyncSuccess", new UnityAction(this.MPDBGKEMFPF));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnGamePassUnlockContinueToPurchasingScreen", new UnityAction(this.LMJGOIINBIC));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnSkinShopCardSelected", new UnityAction(this.EHKDHDDJHLL));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnSkinShopClose", new UnityAction(this.FBCKCJPPPNE));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnStoryInterfaceHeaderShown", new UnityAction(this.CDJNFHDOMFI));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnStoryInterfaceHeaderHideComplete", new UnityAction(this.NOHMAEJCHLC));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPurchasingViewLeave", new UnityAction(this.IAIIODBDKHK));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendPassResourcesChangedType0", new UnityAction(this.BGECHBHBLBM));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPopupOfferManagerContinueToPurchasingScreen", new UnityAction(this.CPEELJJHCNA));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnLoungeLoveInterestShortcutClick", new UnityAction(this.PKCPHJBMPPH));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnStoryInterfaceHeaderShown", new UnityAction(this.LACMGDNIIDI));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnStoryInterfaceHeaderHideComplete", new UnityAction(this.GKADNDECANG));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnChoiceExtendedPanelSlideShown", new UnityAction(this.LKHJBFDHMHN));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnChoiceExtendedPanelSlideHidden", new UnityAction(this.KMIAPGDBLML));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnChoiceExtendedPanelSlideShownComplete", new UnityAction(this.JGFLGCMHIIK));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnChoiceExtendedViewedChoiceChanged", new UnityAction(this.JKLAIOPONDF));
		ODJKHCHFKNL.GFEOFIABBKM();
	}

	// Token: 0x06002E7F RID: 11903 RVA: 0x00140D8C File Offset: 0x0013EF8C
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

	// Token: 0x06002E80 RID: 11904 RVA: 0x00140E00 File Offset: 0x0013F000
	private void KLEHEIFNEIA()
	{
		this.JHNHJPOKJEF = false;
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		if (null != this.storyInterfaceHeaderManager)
		{
			this.EHEFMMIHNCN();
			this.storyInterfaceHeaderManager.Show(0f);
		}
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("app42error") + " (" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD + ")", CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("retry"), new UnityAction(this.OnLoungeUnlockNpcSkinRetry), DFGILFBGPLN.popupBackendError, 0f, 28);
	}

	// Token: 0x06002E81 RID: 11905 RVA: 0x00140EA8 File Offset: 0x0013F0A8
	private void DOMMFKCABHC()
	{
		if (this.PLPKKODECMD().Length == 0)
		{
			return;
		}
		this.RemoveSuperMappingForCurrentCharacter();
		this.CEOEPCIPHEF();
		this.BENCCPNJJIM();
	}

	// Token: 0x06002E82 RID: 11906 RVA: 0x0013EAB5 File Offset: 0x0013CCB5
	private void BDBCLBEKFCI()
	{
		if (this.KBKBOHICPBL != null)
		{
			base.StopCoroutine(this.KBKBOHICPBL);
			this.KBKBOHICPBL = null;
		}
	}

	// Token: 0x06002E83 RID: 11907 RVA: 0x00140ECC File Offset: 0x0013F0CC
	private void OKJDHPBLDCF(bool FOEEIJFHMGG)
	{
		try
		{
			SceneLoungeManager.IHKKNFDFMII ihkknfdfmii = new SceneLoungeManager.IHKKNFDFMII();
			if (!(null == this.loungeShopButton))
			{
				bool flag = false;
				if (null != AssetsManager.EHBBFMCILPC && null != AssetsManager.EHBBFMCILPC.lobbyDataAsset && AssetsManager.EHBBFMCILPC.lobbyDataAsset.PIECGBHMOCB() && KKLFGEHAMMC.EHBBFMCILPC.FACIFBONANM())
				{
					flag = (DHFLKLPKNJG.DCCLCEAJPFL(this.loungeAnthologyIndex, this.AFBGKDLFBLM()).Count > 0);
				}
				if (this.NPEBMMBADLO)
				{
					flag = false;
				}
				this.ILLNEDFDGOD = flag;
				ihkknfdfmii.canvasGroup = this.ALCDLOONDCI();
				if (null != ihkknfdfmii.canvasGroup)
				{
					ihkknfdfmii.canvasGroup.DOKill(false);
				}
				this.loungeShopButton.SetActive(flag);
				if (flag)
				{
					int num = MDDHDDPKFJH.FFFJLJBKCHC(this.loungeAnthologyIndex, this.AFBGKDLFBLM());
					if (null != this.loungeShopNewSkinsDisc)
					{
						this.loungeShopNewSkinsDisc.SetActive(num > 0);
					}
					if (null != this.loungeShopNewSkinsText)
					{
						this.loungeShopNewSkinsText.SetText(Mathf.Min(num, 99).ToString() ?? "", true);
					}
					if (!(null == ihkknfdfmii.canvasGroup))
					{
						if (this.KLHDJFEDIPM)
						{
							ihkknfdfmii.canvasGroup.alpha = 0f;
							ihkknfdfmii.canvasGroup.blocksRaycasts = false;
						}
						else if (FOEEIJFHMGG)
						{
							ihkknfdfmii.canvasGroup.alpha = 0f;
							ihkknfdfmii.canvasGroup.blocksRaycasts = false;
							ihkknfdfmii.canvasGroup.DOFade(1f, 0.5f).SetDelay(0.75f).SetEase(Ease.Linear).OnComplete(new TweenCallback(ihkknfdfmii.EMKDNJBCDAI));
						}
						else
						{
							ihkknfdfmii.canvasGroup.alpha = 1f;
							ihkknfdfmii.canvasGroup.blocksRaycasts = true;
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

	// Token: 0x06002E84 RID: 11908 RVA: 0x001410CC File Offset: 0x0013F2CC
	private void KMIAPGDBLML()
	{
		if (ODJKHCHFKNL.LEMILALILKP() != DFGILFBGPLN.screenLounge)
		{
			return;
		}
		this.GLEKHLGJGLI();
		this.NEFEJOLALAN();
		this.CPPNKGEAMJO(0.25f);
	}

	// Token: 0x06002E85 RID: 11909 RVA: 0x0013F264 File Offset: 0x0013D464
	private void LPDIECAONOI()
	{
		if (this.MPBAFMPGJII != null)
		{
			base.StopCoroutine(this.MPBAFMPGJII);
			this.MPBAFMPGJII = null;
		}
	}

	// Token: 0x06002E86 RID: 11910 RVA: 0x001410F0 File Offset: 0x0013F2F0
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

	// Token: 0x06002E87 RID: 11911 RVA: 0x00141198 File Offset: 0x0013F398
	private void BOONNHPBKMP(PMNHKIDIMLM GAILKDGBMPD)
	{
		try
		{
			int num = 0;
			while (num < this.OFGDGIJNDKL.LJFCMJJFCOI.Count && num < GAILKDGBMPD.IPALJDCNBBG.Count && num < GAILKDGBMPD.KAJNELPPCIJ.Count)
			{
				int num2 = KDCJJBLGCBH.EHBBFMCILPC.LFLFKENLPFO(GAILKDGBMPD.KAJNELPPCIJ[num]);
				if (num2 != 0)
				{
					int[] array = HLDNEMHDEDH.LBNECHFIAHD(this.OFGDGIJNDKL.LJFCMJJFCOI[num].NLCHIGHHAEC, this.OFGDGIJNDKL.LJFCMJJFCOI[num].PKJHDFINDHP);
					int num3 = num2 + array[HLDNEMHDEDH.PACKEBMEEAC(GAILKDGBMPD.KAJNELPPCIJ[num])];
					if (this.OFGDGIJNDKL.LJFCMJJFCOI[num].IENEDGACMMK)
					{
						num3 = num2;
					}
					GAILKDGBMPD.IPALJDCNBBG[num] = num3;
					if (num < GAILKDGBMPD.MKPMEKKGEIL.Count && GAILKDGBMPD.MKPMEKKGEIL[num] != null)
					{
						GAILKDGBMPD.MKPMEKKGEIL[num].OENLLMFNNAL = num3;
					}
				}
				num++;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06002E88 RID: 11912 RVA: 0x001412BC File Offset: 0x0013F4BC
	public void OnLoungeNotEnoughDiamondsGetMore()
	{
		PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager().Initialize();
		if (null != this.storyInterfaceHeaderManager)
		{
			this.storyInterfaceHeaderManager.Hide();
		}
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.OnLoungeNotEnoughDiamondsGetMore2));
	}

	// Token: 0x06002E89 RID: 11913 RVA: 0x00141310 File Offset: 0x0013F510
	public void OnLoungeNotEnoughDiamondsDecline()
	{
		LMHHKDFCKFC lmhhkdfckfc = AKLFPGMDKLA.EHBBFMCILPC.PNLLCLPMIGA();
		if (lmhhkdfckfc != null && PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager().GetProductData(lmhhkdfckfc.DEJCCBNPFEC) != null)
		{
			CommonUserInterface.EHBBFMCILPC.ShowPopupOffer(lmhhkdfckfc.DEJCCBNPFEC, CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().GetProductThumbnailGraphics(lmhhkdfckfc.DEJCCBNPFEC));
		}
	}

	// Token: 0x06002E8A RID: 11914 RVA: 0x00141368 File Offset: 0x0013F568
	private void AJEMBJLBNAM()
	{
		try
		{
			if (!(null == this.loungeExtraNotificationGeneric) && this.loungeExtraNotificationGeneric.activeInHierarchy)
			{
				if (null == this.OMIJCBCDBIC)
				{
					this.OMIJCBCDBIC = this.loungeExtraNotificationGeneric.GetComponent<QuietNotificationManager>();
				}
				if (null != this.OMIJCBCDBIC)
				{
					this.OMIJCBCDBIC.ForceDisappearAnimation();
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06002E8B RID: 11915 RVA: 0x001413E4 File Offset: 0x0013F5E4
	private void LLNENMOMNKP()
	{
		if (ODJKHCHFKNL.LEMILALILKP() != DFGILFBGPLN.screenLounge)
		{
			return;
		}
		if (null != this.storyInterfaceHeaderManager)
		{
			if (this.storyInterfaceHeaderManager.CanInteract())
			{
				this.CloseLounge();
				return;
			}
			this.AJEMBJLBNAM();
			this.EHEFMMIHNCN();
			this.storyInterfaceHeaderManager.Show(0f);
		}
	}

	// Token: 0x06002E8C RID: 11916 RVA: 0x0014143C File Offset: 0x0013F63C
	private void IAIIODBDKHK()
	{
		if (ODJKHCHFKNL.LEMILALILKP() != DFGILFBGPLN.screenLounge)
		{
			return;
		}
		if (!this.FDDBEKJKBOP)
		{
			return;
		}
		this.FDDBEKJKBOP = false;
		for (int i = 0; i < this.BMJAIHFAGKB.Count; i++)
		{
			if (null != this.BMJAIHFAGKB[i])
			{
				this.BMJAIHFAGKB[i].gameObject.SetActive(true);
			}
		}
		this.BMJAIHFAGKB.Clear();
		for (int j = 0; j < this.ENJGBKCFEEK.Count; j++)
		{
			if (null != this.ENJGBKCFEEK[j])
			{
				this.ENJGBKCFEEK[j].enabled = true;
			}
		}
		this.ENJGBKCFEEK.Clear();
		if (null != this.storyInterfaceHeaderManager)
		{
			this.storyInterfaceHeaderManager.ResumeEvents();
		}
		this.MCPPJPHIFGE();
		if (PassesItem.reopenOnPurchasingScreenLeft)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGamePasses();
		}
		if (this.IGAFPNGFMCF)
		{
			ApplicationFocusManager.EHBBFMCILPC.ForceBasicSync();
		}
	}

	// Token: 0x06002E8D RID: 11917 RVA: 0x00141538 File Offset: 0x0013F738
	private string PLPKKODECMD()
	{
		if (this.OFGDGIJNDKL == null)
		{
			return "";
		}
		PLFDAJJHMKO plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.NBMLMNGHOPP();
		if (plfdajjhmko == null)
		{
			return "";
		}
		return plfdajjhmko.NCAMFPGMCIG.GLBDHEKDNDC(this.OFGDGIJNDKL.KALBADOPCDN);
	}

	// Token: 0x06002E8E RID: 11918 RVA: 0x00141580 File Offset: 0x0013F780
	private void LAGFBBKENMF()
	{
		try
		{
			if (ODJKHCHFKNL.LEMILALILKP() == DFGILFBGPLN.screenLounge && !this.JHNHJPOKJEF && !this.IGAFPNGFMCF)
			{
				if (SemaphoreManager.GreenLight(JLDJNIGMHLC.popups))
				{
					AFIBCKPKDHB afibckpkdhb = this.BDIFEAJJKNK();
					if (afibckpkdhb != null)
					{
						HECEJCDAIOJ hecejcdaioj = DHFLKLPKNJG.FEGCAFLOKBC(this.loungeAnthologyIndex, afibckpkdhb.BDIHOCKCCBL);
						if (hecejcdaioj == null)
						{
							hecejcdaioj = DHFLKLPKNJG.EKMGFCLFAHF(this.loungeAnthologyIndex, this.OFGDGIJNDKL.KALBADOPCDN, afibckpkdhb.BDIHOCKCCBL, afibckpkdhb.CBLPKDDMLBL, !afibckpkdhb.MJLAEJCFCEF, afibckpkdhb.NLCHIGHHAEC, afibckpkdhb.PKJHDFINDHP, afibckpkdhb.OLAKHHEICKO, afibckpkdhb.MDKIKKJNJKK, afibckpkdhb.JNCJNLEAFLG, afibckpkdhb.PMFNECKIMBG);
						}
						DHFLKLPKNJG.BBKPPACFGHE(hecejcdaioj);
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06002E8F RID: 11919 RVA: 0x0014164C File Offset: 0x0013F84C
	public void OnLoungeDualPaymentCloseClick()
	{
		this.HJFAECNJHBE = -1;
	}

	// Token: 0x06002E90 RID: 11920 RVA: 0x00141658 File Offset: 0x0013F858
	private float FECODDDOIPB(GameObject MINGLBHFIBN, float OFMKFJHPGDJ, float HAFCALHOOGE)
	{
		if (null == MINGLBHFIBN)
		{
			return OFMKFJHPGDJ;
		}
		RectTransform component = MINGLBHFIBN.GetComponent<RectTransform>();
		if (null == component)
		{
			return OFMKFJHPGDJ;
		}
		component.localScale = new Vector3(this.EAMLEJINMDD, this.EAMLEJINMDD, 1f);
		float num = component.sizeDelta.x * this.EAMLEJINMDD;
		component.localPosition = new Vector3(OFMKFJHPGDJ - num * 0.5f + this.loungeExtraDisplacement.x + this.BCACBGFHKPC.x, HAFCALHOOGE + this.loungeExtraDisplacement.y + this.BCACBGFHKPC.y, 0f);
		MINGLBHFIBN.SetActive(true);
		return OFMKFJHPGDJ - num - 17f;
	}

	// Token: 0x06002E91 RID: 11921 RVA: 0x0014170B File Offset: 0x0013F90B
	private IEnumerator KNOBDAKCBGM()
	{
		yield return new WaitForEndOfFrame();
		this.GPALJLAPPEH();
		yield break;
	}

	// Token: 0x06002E92 RID: 11922 RVA: 0x0014171A File Offset: 0x0013F91A
	private void OEIMCIHPHMD()
	{
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC(SceneLoungeManager.onLoungeScreenLeft, 0f);
		base.StartCoroutine(this.POFPOFKBNMA());
	}

	// Token: 0x06002E93 RID: 11923 RVA: 0x0014173D File Offset: 0x0013F93D
	private IEnumerator LIKHIKOOMIK()
	{
		yield return new WaitForEndOfFrame();
		yield return new WaitForSeconds(0.1f);
		if (this.IGAFPNGFMCF && !this.JHNHJPOKJEF && this.OFGDGIJNDKL != null && this.GBDLLBGONAB >= 0 && this.GBDLLBGONAB < this.OFGDGIJNDKL.LJFCMJJFCOI.Count)
		{
			this.FDLBBNKAOPB = true;
			this.PJKFBCFOBGE(this.GBDLLBGONAB);
		}
		yield break;
	}

	// Token: 0x06002E94 RID: 11924 RVA: 0x0014164C File Offset: 0x0013F84C
	public void HJCIMDDFPOD()
	{
		this.HJFAECNJHBE = -1;
	}

	// Token: 0x06002E95 RID: 11925 RVA: 0x0014174C File Offset: 0x0013F94C
	public static bool HasPendingLoungeCharacter()
	{
		return SceneLoungeManager.JKPMFPPGMKB != null;
	}

	// Token: 0x06002E96 RID: 11926 RVA: 0x00141756 File Offset: 0x0013F956
	private void NFCDJBPAFEI()
	{
		if (ODJKHCHFKNL.LEMILALILKP() != DFGILFBGPLN.screenLounge)
		{
			return;
		}
		if (null != this.storyInterfaceHeaderManager && this.storyInterfaceHeaderManager.CanInteract())
		{
			this.OnSettingsClick();
		}
	}

	// Token: 0x06002E97 RID: 11927 RVA: 0x00141784 File Offset: 0x0013F984
	private void KLEJBPHJOCI()
	{
		if (ODJKHCHFKNL.PJBDPCPNGPB() != (DFGILFBGPLN)(-48))
		{
			return;
		}
		if (null != this.loungeExtra)
		{
			this.loungeExtra.SetActive(false);
			if (this.EMOKHOCGNMA)
			{
				this.EMOKHOCGNMA = false;
				this.AFFIGOHDFJH();
				this.KGINBPGBJLJ(595f);
			}
			else
			{
				this.CGCBAPIAFAC();
				this.KGINBPGBJLJ(724f);
			}
			base.StartCoroutine(this.KNOBDAKCBGM());
		}
	}

	// Token: 0x06002E98 RID: 11928 RVA: 0x001417F5 File Offset: 0x0013F9F5
	public void OnSettingsClick()
	{
		if (FacebookManager.EHBBFMCILPC.IsFacebookManagerInitialized())
		{
			CommonUserInterface.EHBBFMCILPC.ShowSettings(false, this.LPBFAGDJKIH.enablePostEffects, false);
			return;
		}
		base.StartCoroutine(this.DEMIIEHPNIH());
	}

	// Token: 0x06002E99 RID: 11929 RVA: 0x00141828 File Offset: 0x0013FA28
	private void POBAACAEFJH()
	{
		if (ODJKHCHFKNL.LEMILALILKP() != DFGILFBGPLN.screenLounge)
		{
			return;
		}
		if (this.JHNHJPOKJEF)
		{
			return;
		}
		PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager().Initialize();
		if (null != this.storyInterfaceHeaderManager)
		{
			this.storyInterfaceHeaderManager.Hide();
		}
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.OnLoungeShopOrCurrencyInfoClickPart2));
	}

	// Token: 0x06002E9A RID: 11930 RVA: 0x0014188C File Offset: 0x0013FA8C
	private void GIDECJIDMKN()
	{
		try
		{
			if (!(null == this.loungeInfoPanelImage))
			{
				RectTransform rectTransform = this.loungeInfoPanelImage.rectTransform;
				if (!this.CFLLMFBFAIF)
				{
					this.EJKELFOGBAL = rectTransform.anchoredPosition.y;
					this.CFLLMFBFAIF = true;
				}
				rectTransform.anchoredPosition = new Vector2(rectTransform.anchoredPosition.x, this.EJKELFOGBAL + this.loungeInfoOffsetY);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06002E9B RID: 11931 RVA: 0x00141914 File Offset: 0x0013FB14
	private void ANCCPNDOMDC()
	{
		this.JHNHJPOKJEF = true;
		CommonUserInterface.IKNOFBFMPGA().MCJIGJMFBMI();
		if (null != this.storyInterfaceHeaderManager)
		{
			this.EHEFMMIHNCN();
			this.storyInterfaceHeaderManager.Show(564f);
		}
		CommonUserInterface.EHBBFMCILPC.PEBIFCENHAL(CCOJBMMKNAP.JINDKPHNLBK().IPEIONBNIPH("newh"), CCOJBMMKNAP.PEBMGCKFNAO().FCOCLEHKLDJ("tmp") + "storyAssetPackManager[i].environmentsFrontList[j] is null!" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD + "'{0}' shader not found.", CCOJBMMKNAP.JMDJPKKOHNI().OHLNGCKIACD("locked"), new UnityAction(this.OnLoungePremiumChoiceRetry), DFGILFBGPLN.popupSettings, 1421f, -42);
	}

	// Token: 0x06002E9C RID: 11932 RVA: 0x001419BC File Offset: 0x0013FBBC
	private void AFFIGOHDFJH()
	{
		try
		{
			if (!(null == this.loungeExtra))
			{
				if (null == this.HIGMMPJDADP)
				{
					this.HIGMMPJDADP = this.loungeExtra.GetComponent<AnimationCanvasGroupAlpha>();
				}
				if (!(null == this.HIGMMPJDADP))
				{
					this.GHHPEBABMFN();
					if (null == this.CCMBCGANCDO)
					{
						this.CCMBCGANCDO = this.loungeExtra.GetComponent<CanvasGroup>();
					}
					if (null != this.CCMBCGANCDO)
					{
						this.CCMBCGANCDO.DOKill(false);
					}
					this.HIGMMPJDADP.SetDirection(false);
					this.IIJAOCAAMHI(false);
					this.MPBAFMPGJII = base.StartCoroutine(this.NOJFOHNGHGM());
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06002E9D RID: 11933 RVA: 0x00141A8C File Offset: 0x0013FC8C
	private bool EIKJGDCCIFD(int MOHKPKNFBLG)
	{
		try
		{
			if (this.BHNFLFCKHHL == null || this.BHNFLFCKHHL.MKPMEKKGEIL == null || MOHKPKNFBLG < 0 || MOHKPKNFBLG >= this.BHNFLFCKHHL.MKPMEKKGEIL.Count)
			{
				return false;
			}
			return SceneStoryManager.PremiumChoicePurchased(this.BHNFLFCKHHL.MKPMEKKGEIL[MOHKPKNFBLG], this.BHNFLFCKHHL.KMFABKNKFAJ, this.BHNFLFCKHHL.BGIOGOACCBJ);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return false;
	}

	// Token: 0x06002E9E RID: 11934 RVA: 0x00141B14 File Offset: 0x0013FD14
	private IEnumerator JNPOPLPCGMH()
	{
		SceneLoungeManager.BLDCOODJPEP bldcoodjpep = new SceneLoungeManager.BLDCOODJPEP(1);
		bldcoodjpep.<>4__this = this;
		return bldcoodjpep;
	}

	// Token: 0x06002E9F RID: 11935 RVA: 0x00141B23 File Offset: 0x0013FD23
	private void MMFJCBIIFGC()
	{
		if (ODJKHCHFKNL.PPCJPELDBBL() != DFGILFBGPLN.screenLoadingStory)
		{
			return;
		}
		PassesItem.reopenOnPurchasingScreenLeft = false;
		CommonUserInterface.IKNOFBFMPGA().FNJLJKLJONA().InstantClose();
		this.CBJDJHCFLND();
	}

	// Token: 0x06002EA0 RID: 11936 RVA: 0x00141B4C File Offset: 0x0013FD4C
	private static bool PBFAFGBGPGI()
	{
		try
		{
			PLFDAJJHMKO plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.NBMLMNGHOPP();
			if (plfdajjhmko == null)
			{
				return false;
			}
			AssetAnthology assetAnthology = GKJPOGNFKNK.MLDENPHFNPH(plfdajjhmko.DHONIOBOLEL.GGICIBLJIKI, true);
			if (null == assetAnthology || null == assetAnthology.header)
			{
				return false;
			}
			EIOPLEFLLIM eioplefllim = AKLFPGMDKLA.EHBBFMCILPC.GJBDBONJCDL(assetAnthology.header.index);
			return eioplefllim != null && assetAnthology.header.MLGKEPJPICJ(eioplefllim.EGHHCFFLPCP(-1));
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return false;
	}

	// Token: 0x06002EA1 RID: 11937 RVA: 0x00141BE4 File Offset: 0x0013FDE4
	private GameObject BLKLDGBGPCC(string HJEJJGAFHAM)
	{
		if (null == this.extendedChoicePivot || null == this.extendedChoicePivot.transform.parent)
		{
			return null;
		}
		Transform transform = this.extendedChoicePivot.transform.parent.Find(HJEJJGAFHAM);
		if (null == transform)
		{
			return null;
		}
		return transform.gameObject;
	}

	// Token: 0x06002EA2 RID: 11938 RVA: 0x00141C44 File Offset: 0x0013FE44
	private void LJGCKIJCKOO()
	{
		if (null == this.nameText)
		{
			return;
		}
		string text = "gamepassdurationbody";
		try
		{
			if (this.OFGDGIJNDKL != null && this.OFGDGIJNDKL.KALBADOPCDN != null && null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				DMDNKJKEPKO dmdnkjkepko = AssetsManager.EHBBFMCILPC.lobbyDataAsset.HFAOOHKNBPE().DLCFCKOCIGB(this.OFGDGIJNDKL.KALBADOPCDN);
				if (dmdnkjkepko != null && dmdnkjkepko.KMHILDMHJMA != null && dmdnkjkepko.KMHILDMHJMA.Length > 1)
				{
					string text2 = GKJPOGNFKNK.HPAHOEOKEBB(dmdnkjkepko.KMHILDMHJMA, "Starting parallel download:", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
					if (text2 != null && text2.Length > 1 && !text2.EndsWith("app42error"))
					{
						text = text2;
					}
				}
			}
			if (text.Length == 0 && this.OFGDGIJNDKL != null && this.OFGDGIJNDKL.KALBADOPCDN != null && null != AssetsManager.MJBDMHPHMID().profileDataAsset)
			{
				JSONArray jsonarray = AssetsManager.MJBDMHPHMID().profileDataAsset.GIOFKDDKAPD();
				if (null != jsonarray)
				{
					for (int i = 1; i < jsonarray.Count; i += 0)
					{
						JSONObject asObject = jsonarray[i].AsObject;
						string text3 = asObject["OnPopupAvatarCollectionsInputCancel"];
						if (text3 != null && text3.Replace("EnvironmentMorphManager - morph shader not found in Resources:ShaderEnvMorphClient", "OnLiveProfileThumbnailsCdnFailed").Equals(this.OFGDGIJNDKL.KALBADOPCDN))
						{
							string text4 = asObject["OnPopupCardOptionsBackClick"];
							if (text4 == null || text4.Replace("Error. MoveEnvironment(), environment ", "").Length == 0)
							{
								string text5 = asObject["availableAchievementsBalance"];
								string text6 = asObject["longdownloadhint"];
								text4 = ((text5 != null) ? text5.Replace("socialdequeusp2get", "") : " ") + ((text6 != null) ? text6.Replace("drs2", " ") : "favstostr2");
							}
							if (text4 != null && text4.Replace("[LoadingEnv] request failed for ", "nick").Length != 0)
							{
								string text7 = GKJPOGNFKNK.FPNHFACMDGN(text4.Replace("f", "Anthology not ready to be played:"), "fdfrc", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ());
								if (text7 != null && text7.Length > 0 && !text7.EndsWith("chaptersdesc"))
								{
									text = text7;
									break;
								}
								break;
							}
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		this.nameText.SetText(text, false);
	}

	// Token: 0x06002EA3 RID: 11939 RVA: 0x00141EF0 File Offset: 0x001400F0
	public void OnLoungeUnlockNpcSkinRetry()
	{
		if (this.OFGDGIJNDKL != null && this.GBDLLBGONAB >= 0 && this.GBDLLBGONAB < this.OFGDGIJNDKL.LJFCMJJFCOI.Count)
		{
			this.PJKFBCFOBGE(this.GBDLLBGONAB);
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("OnLoungeUnlockNpcSkinRetry() - invalid situation.");
	}

	// Token: 0x06002EA4 RID: 11940 RVA: 0x00141F40 File Offset: 0x00140140
	private AFIBCKPKDHB BDIFEAJJKNK()
	{
		if (null == this.BPHLDDMNPAI || this.OFGDGIJNDKL == null)
		{
			return null;
		}
		int viewedRemappedChoiceIndex = this.BPHLDDMNPAI.GetViewedRemappedChoiceIndex();
		if (viewedRemappedChoiceIndex < 0 || viewedRemappedChoiceIndex >= this.OFGDGIJNDKL.LJFCMJJFCOI.Count)
		{
			return null;
		}
		return this.OFGDGIJNDKL.LJFCMJJFCOI[viewedRemappedChoiceIndex];
	}

	// Token: 0x06002EA5 RID: 11941 RVA: 0x00141F9C File Offset: 0x0014019C
	private void JPOHEIPCPHM(GameObject PHLJNFHEEIB, int GHEMBIDKOIA)
	{
		PHLJNFHEEIB.layer = GHEMBIDKOIA;
		for (int i = 0; i < PHLJNFHEEIB.transform.childCount; i++)
		{
			this.JPOHEIPCPHM(PHLJNFHEEIB.transform.GetChild(i).gameObject, GHEMBIDKOIA);
		}
	}

	// Token: 0x06002EA6 RID: 11942 RVA: 0x00141FDE File Offset: 0x001401DE
	private void NEMEBAJLLAO()
	{
		if (ODJKHCHFKNL.LEMILALILKP() != DFGILFBGPLN.screenLounge)
		{
			return;
		}
		if (null == this.storyInterfaceHeaderManager || !this.storyInterfaceHeaderManager.CanInteract())
		{
			return;
		}
		this.POBAACAEFJH();
	}

	// Token: 0x06002EA7 RID: 11943 RVA: 0x0014200C File Offset: 0x0014020C
	private void EHKDHDDJHLL()
	{
		if (ODJKHCHFKNL.LEMILALILKP() != DFGILFBGPLN.screenLounge)
		{
			return;
		}
		HECEJCDAIOJ lastSelectedEntry = SkinShopItem.lastSelectedEntry;
		SkinShopItem.lastSelectedEntry = null;
		if (lastSelectedEntry == null)
		{
			return;
		}
		CommonUserInterface.EHBBFMCILPC.GetSkinShop().InstantClose();
		this.FOPJOMKFBNP = Time.frameCount;
		SceneLoungeManager.SetPendingLoungeLook(lastSelectedEntry.BDIHOCKCCBL);
		this.EENCPNOHPGO(lastSelectedEntry.KALBADOPCDN);
		if (this.OFGDGIJNDKL == null || !lastSelectedEntry.KALBADOPCDN.Equals(this.OFGDGIJNDKL.KALBADOPCDN))
		{
			SceneLoungeManager.SetPendingLoungeLook(null);
		}
		this.OKJDHPBLDCF(false);
	}

	// Token: 0x06002EA8 RID: 11944 RVA: 0x00003E52 File Offset: 0x00002052
	private void KODFDGNLEOB()
	{
	}

	// Token: 0x06002EA9 RID: 11945 RVA: 0x00142094 File Offset: 0x00140294
	private void BENCCPNJJIM()
	{
		try
		{
			if (!(null == this.loungeCurrencyInfoButton))
			{
				AFIBCKPKDHB afibckpkdhb = this.BDIFEAJJKNK();
				bool active = afibckpkdhb != null && afibckpkdhb.IENEDGACMMK && afibckpkdhb.OBLBNLBFBNI >= 0 && (afibckpkdhb.PODGFLMDBEC == BGDLJKJPOOO.specialCurrency0 || afibckpkdhb.PODGFLMDBEC == BGDLJKJPOOO.specialCurrency1 || afibckpkdhb.PODGFLMDBEC == BGDLJKJPOOO.specialCurrency2) && !AKLFPGMDKLA.EHBBFMCILPC.OKNDDBOOFPL(afibckpkdhb.OBLBNLBFBNI);
				if (this.ABMAGBPBCGE)
				{
					bool flag = null != this.loungeExtraResetButton && this.loungeExtraResetButton.activeSelf;
					this.loungeCurrencyInfoButton.transform.localPosition = (flag ? this.JKIKIAEJKDO : this.MLDLPLPLJNH);
				}
				this.loungeCurrencyInfoButton.SetActive(active);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06002EAA RID: 11946 RVA: 0x0014216C File Offset: 0x0014036C
	private static string JPKBKACGPJO(BGDLJKJPOOO KCMMNPLNPGL)
	{
		if (KCMMNPLNPGL == BGDLJKJPOOO.specialCurrency1)
		{
			return KBOJLHAJPCP.DGMDEJKHKFL;
		}
		if (KCMMNPLNPGL == BGDLJKJPOOO.specialCurrency2)
		{
			return KBOJLHAJPCP.KMEBHIBPPJC;
		}
		return KBOJLHAJPCP.DBCAFJGPECE;
	}

	// Token: 0x06002EAB RID: 11947 RVA: 0x00142188 File Offset: 0x00140388
	public void OnLoungeDualPaymentCurrencyClick()
	{
		int hjfaecnjhbe = this.HJFAECNJHBE;
		this.HJFAECNJHBE = -1;
		this.EJNHFJCFGPI(hjfaecnjhbe);
	}

	// Token: 0x06002EAC RID: 11948 RVA: 0x001421AC File Offset: 0x001403AC
	private void DDNDCPJPBHL()
	{
		if (ODJKHCHFKNL.PCKKHGOABGG() != (DFGILFBGPLN)(-73) || this.JHNHJPOKJEF || !SemaphoreManager.HEDINPGIGDJ(JLDJNIGMHLC.popups))
		{
			return;
		}
		if (null != this.BPHLDDMNPAI)
		{
			this.BPHLDDMNPAI.UpdateSwipeToBrowse();
			if (ChoiceExtendedManager.FHEOALEBAMI())
			{
				this.FOPJOMKFBNP = Time.frameCount;
			}
		}
		if (Time.frameCount <= this.FOPJOMKFBNP + 0)
		{
			return;
		}
		if (!Input.GetMouseButtonUp(0) && !Input.GetMouseButtonUp(1))
		{
			if (DPGJIJGOCIC.MEDGDBAOPIL())
			{
				Vector2 vector = DPGJIJGOCIC.EFJPBDBFEKJ();
				if (this.DLEBPNAGFPJ(new Vector2(vector.x * (float)Screen.width, vector.y * (float)Screen.height)))
				{
					return;
				}
				this.GMKKHHBHMNP(vector.y, true);
			}
			return;
		}
		if (this.DLEBPNAGFPJ(Input.mousePosition))
		{
			return;
		}
		this.GMKKHHBHMNP(DPGJIJGOCIC.KLPPJLLBJAP().y, true);
	}

	// Token: 0x06002EAD RID: 11949 RVA: 0x00142288 File Offset: 0x00140488
	private void PKCPHJBMPPH()
	{
		if (ODJKHCHFKNL.LEMILALILKP() != DFGILFBGPLN.screenLounge)
		{
			return;
		}
		if (null == this.storyInterfaceHeaderManager || !this.storyInterfaceHeaderManager.CanInteract())
		{
			return;
		}
		string text = AOBJLALDBAA.EHBBFMCILPC.KNCFLCKKPLK();
		if (text == null || text.Length == 0)
		{
			return;
		}
		string text2 = "";
		if (null != AssetsManager.EHBBFMCILPC.profileDataAsset)
		{
			text2 = AssetsManager.EHBBFMCILPC.profileDataAsset.CJEPLBMFDKP(text);
		}
		if (text2 == null || text2.Length == 0)
		{
			return;
		}
		this.EENCPNOHPGO(text2);
	}

	// Token: 0x06002EAE RID: 11950 RVA: 0x00142310 File Offset: 0x00140510
	private bool DNAPADOMFBE()
	{
		int num;
		if (PlayerPrefs.HasKey("trsv"))
		{
			num = PlayerPrefs.GetInt("specialcurrencyoptionna");
		}
		else
		{
			num = 1;
		}
		return num != 0 || NBDLBFJOEGN.LHBMEFGCPHK();
	}

	// Token: 0x06002EAF RID: 11951 RVA: 0x00142345 File Offset: 0x00140545
	private static LDLLJFOJCDF KGKBPOKPBEP(BGDLJKJPOOO KCMMNPLNPGL)
	{
		if (KCMMNPLNPGL == BGDLJKJPOOO.specialCurrency1)
		{
			return AKLFPGMDKLA.EHBBFMCILPC.DOFKEHNPCIJ;
		}
		if (KCMMNPLNPGL == BGDLJKJPOOO.specialCurrency2)
		{
			return AKLFPGMDKLA.EHBBFMCILPC.PBEPCNFADAA;
		}
		return AKLFPGMDKLA.EHBBFMCILPC.OJNBAMPGBLJ;
	}

	// Token: 0x06002EB0 RID: 11952 RVA: 0x00142370 File Offset: 0x00140570
	public void ELJIBHAJBCE()
	{
		if (this.JHNHJPOKJEF)
		{
			return;
		}
		if (this.FEDBGLIOLFK.Count == 0)
		{
			return;
		}
		this.KCHHNKPHGNN++;
		if (this.KCHHNKPHGNN >= this.FEDBGLIOLFK.Count)
		{
			this.KCHHNKPHGNN = 0;
		}
		this.EGFOGFNCIKJ = this.OFGDGIJNDKL;
		this.OFGDGIJNDKL = this.FEDBGLIOLFK[this.KCHHNKPHGNN];
		this.CCIBCIFFDOO();
		this.KPBFHKGIFID();
	}

	// Token: 0x06002EB1 RID: 11953 RVA: 0x001423EC File Offset: 0x001405EC
	private void GGDPPKCIHFO(int MOHKPKNFBLG)
	{
		if (MOHKPKNFBLG < 0 || this.OFGDGIJNDKL == null || MOHKPKNFBLG >= this.OFGDGIJNDKL.LJFCMJJFCOI.Count)
		{
			return;
		}
		AFIBCKPKDHB afibckpkdhb = this.OFGDGIJNDKL.LJFCMJJFCOI[MOHKPKNFBLG];
		if (afibckpkdhb.CBLPKDDMLBL < 0)
		{
			DPGJIJGOCIC.ADFCDFHBDAF("[Lounge] IAP shop look without a rarity (rar), purchase ignored: " + afibckpkdhb.BDIHOCKCCBL);
			return;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.CIAONGKLBEP(afibckpkdhb.CBLPKDDMLBL))
		{
			this.PJKFBCFOBGE(MOHKPKNFBLG);
			return;
		}
		if (!this.IGAFPNGFMCF && !this.OOCPHDOHGDE)
		{
			this.NFEDANNNOFK(MOHKPKNFBLG);
			return;
		}
		if (AssetsManager.EHBBFMCILPC.IsBusy() || App42Manager.EHBBFMCILPC.IsBusy() || CommonUserInterface.EHBBFMCILPC.ConnectionAnimationEnabled())
		{
			return;
		}
		this.GBDLLBGONAB = MOHKPKNFBLG;
		this.GIGAHKHAGDO = afibckpkdhb.OBLBNLBFBNI;
		this.IGAFPNGFMCF = true;
		this.OOCPHDOHGDE = false;
		this.IHANGJHFKCB = true;
		ApplicationFocusManager.EHBBFMCILPC.ForceBasicSync();
	}

	// Token: 0x06002EB2 RID: 11954 RVA: 0x001424D3 File Offset: 0x001406D3
	private void CPEELJJHCNA()
	{
		if (ODJKHCHFKNL.LEMILALILKP() != DFGILFBGPLN.screenLounge)
		{
			return;
		}
		this.CBJDJHCFLND();
	}

	// Token: 0x06002EB3 RID: 11955 RVA: 0x001424E8 File Offset: 0x001406E8
	public static string GetLoungeCharacterOidForSprite(string HAPADEOFKBP)
	{
		try
		{
			if (HAPADEOFKBP == null || null == AssetsManager.EHBBFMCILPC || null == AssetsManager.EHBBFMCILPC.profileDataAsset)
			{
				return null;
			}
			JSONArray jsonarray = AssetsManager.EHBBFMCILPC.profileDataAsset.GIOFKDDKAPD();
			if (null == jsonarray)
			{
				return null;
			}
			string value = HAPADEOFKBP.Replace(" ", "");
			int i = 0;
			while (i < jsonarray.Count)
			{
				JSONObject asObject = jsonarray[i].AsObject;
				string text = asObject["sprite"];
				if (text != null && text.Replace(" ", "").Equals(value))
				{
					string text2 = asObject["oid"];
					if (text2 == null || text2.Replace(" ", "").Length == 0)
					{
						return null;
					}
					return text2.Replace(" ", "");
				}
				else
				{
					i++;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return null;
	}

	// Token: 0x06002EB4 RID: 11956 RVA: 0x00142608 File Offset: 0x00140808
	private void KPBFHKGIFID()
	{
		if (this.LPBFAGDJKIH.HGIIJABNDCD(100) != null && !KHPGPLAMAIN.EJCNHEBIOJF() && KHPGPLAMAIN.IBDGNKGIMFI() != IIHCCPLGGHP.lowEnd)
		{
			CommonUserInterface.EHBBFMCILPC.GetFader().SetCustomFader(GKJPOGNFKNK.PBGGBOADBPJ(this.LPBFAGDJKIH.HGIIJABNDCD(100).assetIndex), this.LPBFAGDJKIH.HGIIJABNDCD(100));
		}
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.GPBICDPCHFP));
	}

	// Token: 0x06002EB5 RID: 11957 RVA: 0x00142684 File Offset: 0x00140884
	private void ACDFDKHMAFA()
	{
		if (null == this.BPHLDDMNPAI || null == this.BPHLDDMNPAI.itemTitle)
		{
			return;
		}
		TextMeshProUGUI itemTitle = this.BPHLDDMNPAI.itemTitle;
		itemTitle.raycastTarget = true;
		LoungeTapGuard loungeTapGuard = itemTitle.GetComponent<LoungeTapGuard>();
		if (null == loungeTapGuard)
		{
			loungeTapGuard = itemTitle.gameObject.AddComponent<LoungeTapGuard>();
			loungeTapGuard.onTap = new Action(this.OnLoungeLookTitleClick);
		}
	}

	// Token: 0x06002EB6 RID: 11958 RVA: 0x001426F4 File Offset: 0x001408F4
	private void GHCPKJGGOBM(bool FOEEIJFHMGG)
	{
		try
		{
			SceneLoungeManager.IHKKNFDFMII ihkknfdfmii = new SceneLoungeManager.IHKKNFDFMII();
			if (!(null == this.loungeShopButton))
			{
				bool flag = false;
				if (null != AssetsManager.EHBBFMCILPC && null != AssetsManager.MJBDMHPHMID().lobbyDataAsset && AssetsManager.MJBDMHPHMID().lobbyDataAsset.HOMJHHPEOPL() && KKLFGEHAMMC.FPHICJFMJMJ().BKBKILGDDFK())
				{
					flag = (DHFLKLPKNJG.DCCLCEAJPFL(this.loungeAnthologyIndex, this.AFBGKDLFBLM()).Count > 1);
				}
				if (this.NPEBMMBADLO)
				{
					flag = false;
				}
				this.ILLNEDFDGOD = flag;
				ihkknfdfmii.canvasGroup = this.ALCDLOONDCI();
				if (null != ihkknfdfmii.canvasGroup)
				{
					ihkknfdfmii.canvasGroup.DOKill(false);
				}
				this.loungeShopButton.SetActive(flag);
				if (flag)
				{
					int num = MDDHDDPKFJH.FFFJLJBKCHC(this.loungeAnthologyIndex, this.AFBGKDLFBLM());
					if (null != this.loungeShopNewSkinsDisc)
					{
						this.loungeShopNewSkinsDisc.SetActive(num > 1);
					}
					if (null != this.loungeShopNewSkinsText)
					{
						this.loungeShopNewSkinsText.SetText(Mathf.Min(num, 65).ToString() ?? "</i>", true);
					}
					if (!(null == ihkknfdfmii.canvasGroup))
					{
						if (this.KLHDJFEDIPM)
						{
							ihkknfdfmii.canvasGroup.alpha = 845f;
							ihkknfdfmii.canvasGroup.blocksRaycasts = true;
						}
						else if (FOEEIJFHMGG)
						{
							ihkknfdfmii.canvasGroup.alpha = 805f;
							ihkknfdfmii.canvasGroup.blocksRaycasts = true;
							ihkknfdfmii.canvasGroup.DOFade(1255f, 1653f).SetDelay(13f).SetEase(Ease.Linear).OnComplete(new TweenCallback(ihkknfdfmii.EMKDNJBCDAI));
						}
						else
						{
							ihkknfdfmii.canvasGroup.alpha = 686f;
							ihkknfdfmii.canvasGroup.blocksRaycasts = true;
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

	// Token: 0x06002EB7 RID: 11959 RVA: 0x001428F4 File Offset: 0x00140AF4
	private void OANFNDEPNOB(string BBAHLPPFEPO)
	{
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), SceneLoungeManager.JLJCHODGBBK(BBAHLPPFEPO, "specialcurrencyoptionna"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
	}

	// Token: 0x06002EB8 RID: 11960 RVA: 0x00142934 File Offset: 0x00140B34
	private void CPNKBDPKGOE(string[] DCNCBHJBEMI)
	{
		if (DCNCBHJBEMI == null || DCNCBHJBEMI.Length == 0)
		{
			return;
		}
		string text = DCNCBHJBEMI[1];
		if (text == null || text.Length == 0)
		{
			return;
		}
		for (int i = 0; i < DCNCBHJBEMI.Length; i++)
		{
			if (DCNCBHJBEMI[i] == null || DCNCBHJBEMI[i].Length == 0)
			{
				DCNCBHJBEMI[i] = text;
			}
		}
	}

	// Token: 0x06002EB9 RID: 11961 RVA: 0x0014297A File Offset: 0x00140B7A
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

	// Token: 0x06002EBA RID: 11962 RVA: 0x0014298C File Offset: 0x00140B8C
	private static string JLJCHODGBBK(string MJHGIIEINOE, string CABHBIJCMOM)
	{
		string text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(MJHGIIEINOE);
		if (text == null || text.Length == 0 || text.EndsWith("_not_found"))
		{
			return CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(CABHBIJCMOM);
		}
		return text;
	}

	// Token: 0x06002EBB RID: 11963 RVA: 0x001429CA File Offset: 0x00140BCA
	private void JKILEHPJHLM()
	{
		FPFNLJGEIJK.FANFNCNAKEF();
		CommonUserInterface.EHBBFMCILPC.ShowGamePasses();
	}

	// Token: 0x06002EBC RID: 11964 RVA: 0x001429DB File Offset: 0x00140BDB
	private int JIIFLBNGCLO(GHMINFEGBGN CMENACFAEGD)
	{
		if (CMENACFAEGD != null && CMENACFAEGD.OIBGFPEGLME >= 0)
		{
			return CMENACFAEGD.OIBGFPEGLME;
		}
		return AKLFPGMDKLA.EHBBFMCILPC.NBMLMNGHOPP().NCAMFPGMCIG.OIBGFPEGLME;
	}

	// Token: 0x06002EBD RID: 11965 RVA: 0x00142A04 File Offset: 0x00140C04
	private void GPPHIJIPDKO(string PHEPKKPGMLB)
	{
		try
		{
			if (!(null == this.loungeExtraNotificationGeneric))
			{
				string text = this.JPEAFGJAOAA(PHEPKKPGMLB);
				if (text != null)
				{
					if (null == this.HFGKNDCBGJE)
					{
						Transform transform = this.loungeExtraNotificationGeneric.transform.Find("TextTitle");
						if (null != transform)
						{
							this.HFGKNDCBGJE = transform.GetComponent<TextMeshProUGUI>();
						}
					}
					if (!(null == this.HFGKNDCBGJE))
					{
						if (null != this.storyInterfaceHeaderManager && this.storyInterfaceHeaderManager.IsShowingOrVisible())
						{
							this.storyInterfaceHeaderManager.Hide();
						}
						this.LACMGDNIIDI();
						this.loungeExtraNotificationGeneric.SetActive(false);
						this.HFGKNDCBGJE.SetText(text, true);
						this.loungeExtraNotificationGeneric.SetActive(true);
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06002EBE RID: 11966 RVA: 0x00142AE8 File Offset: 0x00140CE8
	private void LEGFKGLEMLJ()
	{
		FPFNLJGEIJK.FANFNCNAKEF();
		CommonUserInterface.IKNOFBFMPGA().ShowGamePasses();
	}

	// Token: 0x06002EBF RID: 11967 RVA: 0x00142AFC File Offset: 0x00140CFC
	private void KELJIKDEAID(BGDLJKJPOOO KCMMNPLNPGL)
	{
		string text = SceneLoungeManager.JLJCHODGBBK("loungeskinnotenough", "specialcurrencyoptionnotenough");
		int num = SceneLoungeManager.MPOCKKPLLPA(KCMMNPLNPGL);
		if (num >= 0)
		{
			string text2 = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("loungetreasuresyouhave");
			if (text2 != null && text2.Length > 0 && !text2.EndsWith("_not_found"))
			{
				text = text + "\n\n<align=\"center\">" + text2.Replace("{sp}", SceneLoungeManager.EADLKFBBGEH(num)) + "</align>";
			}
		}
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
	}

	// Token: 0x06002EC0 RID: 11968 RVA: 0x00142BA4 File Offset: 0x00140DA4
	private void DLMHPEIANCL()
	{
		if (this.OFGDGIJNDKL == this.EGFOGFNCIKJ)
		{
			return;
		}
		int num = this.JIIFLBNGCLO(this.OFGDGIJNDKL);
		this.defaultEnvironment.SetActive(false);
		if (this.defaultEnvironmentCustomWardrobe != null && this.defaultEnvironmentCustomWardrobe.Count > 0)
		{
			for (int i = 0; i < this.defaultEnvironmentCustomWardrobe.Count; i++)
			{
				this.defaultEnvironmentCustomWardrobe[i].SetActive(false);
			}
			if (this.EGFOGFNCIKJ != null && this.OFGDGIJNDKL != null && this.JIIFLBNGCLO(this.EGFOGFNCIKJ) != num)
			{
				AudioManager.EHBBFMCILPC.KillMusic("", CommonUserInterface.EHBBFMCILPC.GetFader().GetFadeInDuration());
			}
		}
		bool flag = this.GGJILABOAMB(num);
		if (this.defaultEnvironmentCustomWardrobe != null && this.defaultEnvironmentCustomWardrobe.Count > 0 && this.defaultEnvironmentCustomWardrobe.Count > num && num >= 0 && this.BJIMGPHGGIH.Contains(num))
		{
			this.defaultEnvironmentCustomWardrobe[num].SetActive(true);
			if (!flag)
			{
				AudioManager.EHBBFMCILPC.PlayMusic("muslounge" + this.loungeAnthologyIndex.ToString() + "w" + num.ToString(), true, -1f, false);
				return;
			}
		}
		else
		{
			this.defaultEnvironment.SetActive(true);
			if (!flag && !AudioManager.EHBBFMCILPC.PlayMusic("muslounge", true, -1f, false) && !AudioManager.EHBBFMCILPC.PlayMusic("muslounge" + this.loungeAnthologyIndex.ToString(), true, -1f, false))
			{
				AudioManager.EHBBFMCILPC.PlayMusic("lounge", true, -1f, false);
			}
		}
	}

	// Token: 0x06002EC1 RID: 11969 RVA: 0x00142D44 File Offset: 0x00140F44
	private void LKHJBFDHMHN()
	{
		if (ODJKHCHFKNL.LEMILALILKP() != DFGILFBGPLN.screenLounge)
		{
			return;
		}
		if (null != this.loungeExtra)
		{
			this.loungeExtra.SetActive(true);
			if (this.EMOKHOCGNMA)
			{
				this.EMOKHOCGNMA = false;
				this.AFFIGOHDFJH();
				this.KGINBPGBJLJ(0.75f);
			}
			else
			{
				this.CGCBAPIAFAC();
				this.KGINBPGBJLJ(0f);
			}
			base.StartCoroutine(this.KNOBDAKCBGM());
		}
	}

	// Token: 0x06002EC2 RID: 11970 RVA: 0x00142DB5 File Offset: 0x00140FB5
	public static void SetPendingLoungeLoveInterestsStripHidden(bool ELGHGBMJNGH)
	{
		SceneLoungeManager.GMJBFAHDDAK = ELGHGBMJNGH;
	}

	// Token: 0x06002EC3 RID: 11971 RVA: 0x00142DBD File Offset: 0x00140FBD
	private void JGFLGCMHIIK()
	{
		if (ODJKHCHFKNL.LEMILALILKP() != DFGILFBGPLN.screenLounge)
		{
			return;
		}
		this.GPALJLAPPEH();
	}

	// Token: 0x06002EC4 RID: 11972 RVA: 0x00142DCF File Offset: 0x00140FCF
	private void MCPPJPHIFGE()
	{
		if (null == this.storyInterfaceHeaderManager)
		{
			return;
		}
		this.storyInterfaceHeaderManager.SetLoungeCurrenciesText("");
	}

	// Token: 0x06002EC5 RID: 11973 RVA: 0x00142DF0 File Offset: 0x00140FF0
	private void MPDBGKEMFPF()
	{
		if (!this.IGAFPNGFMCF)
		{
			return;
		}
		this.OOCPHDOHGDE = false;
		this.FDLBBNKAOPB = true;
		if (this.OFGDGIJNDKL == null || this.GBDLLBGONAB < 0 || this.GBDLLBGONAB >= this.OFGDGIJNDKL.LJFCMJJFCOI.Count || !this.OLEMPGNJDJJ(this.OFGDGIJNDKL.LJFCMJJFCOI[this.GBDLLBGONAB]) || this.OFGDGIJNDKL.LJFCMJJFCOI[this.GBDLLBGONAB].OBLBNLBFBNI != this.GIGAHKHAGDO)
		{
			this.IGAFPNGFMCF = false;
			this.IHANGJHFKCB = false;
			this.GBDLLBGONAB = -1;
			return;
		}
		AFIBCKPKDHB afibckpkdhb = this.OFGDGIJNDKL.LJFCMJJFCOI[this.GBDLLBGONAB];
		if (!AKLFPGMDKLA.EHBBFMCILPC.CIAONGKLBEP(afibckpkdhb.CBLPKDDMLBL))
		{
			this.IGAFPNGFMCF = false;
			if (this.IHANGJHFKCB)
			{
				this.IHANGJHFKCB = false;
				base.StartCoroutine(this.KAGOFCMCHNF(this.GBDLLBGONAB));
			}
			return;
		}
		this.IHANGJHFKCB = false;
		base.StartCoroutine(this.LIKHIKOOMIK());
	}

	// Token: 0x06002EC6 RID: 11974 RVA: 0x00142F00 File Offset: 0x00141100
	public static void SetPendingLoungeCharacter(string OKDNLCOEOIJ)
	{
		SceneLoungeManager.JKPMFPPGMKB = OKDNLCOEOIJ;
	}

	// Token: 0x06002EC7 RID: 11975 RVA: 0x00142F08 File Offset: 0x00141108
	private static string DANIHEJMMJO()
	{
		StringBuilder stringBuilder = new StringBuilder();
		try
		{
			if (AKLFPGMDKLA.EHBBFMCILPC == null || AKLFPGMDKLA.EHBBFMCILPC.PGGHMMFKCFC == null)
			{
				return "";
			}
			for (int i = 0; i < KBOJLHAJPCP.KACBFPFFJEO.Length; i++)
			{
				int num = 0;
				for (int j = 0; j < AKLFPGMDKLA.EHBBFMCILPC.PGGHMMFKCFC.Count; j++)
				{
					if (AKLFPGMDKLA.EHBBFMCILPC.PGGHMMFKCFC[j] == i)
					{
						num++;
					}
				}
				if (num > 0)
				{
					if (stringBuilder.Length > 0)
					{
						stringBuilder.Append(" ");
					}
					stringBuilder.Append(KBOJLHAJPCP.KACBFPFFJEO[i]);
					stringBuilder.Append("<space=0.0625em>x");
					stringBuilder.Append(num);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06002EC8 RID: 11976 RVA: 0x0013CA54 File Offset: 0x0013AC54
	private void AFIMJLDHLDE(ref GameObject KFLHPNHJKKD)
	{
		if (null != KFLHPNHJKKD)
		{
			KFLHPNHJKKD.SetActive(false);
			KFLHPNHJKKD = null;
		}
	}

	// Token: 0x06002EC9 RID: 11977 RVA: 0x00142FE4 File Offset: 0x001411E4
	private void KOOKNGIIMDO()
	{
		if (this.LPBFAGDJKIH.HGIIJABNDCD(100) != null && !KHPGPLAMAIN.EJCNHEBIOJF() && KHPGPLAMAIN.IBDGNKGIMFI() != IIHCCPLGGHP.lowEnd)
		{
			CommonUserInterface.EHBBFMCILPC.GetFader().SetCustomFader(GKJPOGNFKNK.PBGGBOADBPJ(this.LPBFAGDJKIH.HGIIJABNDCD(100).assetIndex), this.LPBFAGDJKIH.HGIIJABNDCD(100));
		}
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.MLLBAPJOCAN));
	}

	// Token: 0x06002ECA RID: 11978 RVA: 0x00143060 File Offset: 0x00141260
	private void INIPLGHNAEL()
	{
		try
		{
			if (!(null == this.storyInterfaceHeaderManager))
			{
				this.storyInterfaceHeaderManager.SetCurrentStorySave(AKLFPGMDKLA.EHBBFMCILPC.NBMLMNGHOPP());
				this.storyInterfaceHeaderManager.ForceLoveInterestsSection();
				this.MCPPJPHIFGE();
				this.storyInterfaceHeaderManager.HideProgressForLounge();
				this.ABOAPLJBEIN(this.storyInterfaceHeaderManager.loveInterestsParent);
				this.ABOAPLJBEIN(this.storyInterfaceHeaderManager.loveInterestsParent2);
				this.DBIPBCOAEFP(this.storyInterfaceHeaderManager.loveInterestsParent);
				this.DBIPBCOAEFP(this.storyInterfaceHeaderManager.loveInterestsParent2);
				if (null != this.storyInterfaceHeaderManager.loveInterestsParent && null != this.storyInterfaceHeaderManager.loveInterestsParent.transform.parent)
				{
					AnimationTranslation component = this.storyInterfaceHeaderManager.loveInterestsParent.transform.parent.GetComponent<AnimationTranslation>();
					if (null != component)
					{
						component.delayAtStart = 0f;
					}
				}
				if (null != this.storyInterfaceHeaderManager.gamePassParent)
				{
					AnimationCanvasGroupAlpha component2 = this.storyInterfaceHeaderManager.gamePassParent.GetComponent<AnimationCanvasGroupAlpha>();
					if (null != component2)
					{
						component2.delayAtStart = 0f;
					}
				}
				if (this.FJIOJFGDGBH)
				{
					this.storyInterfaceHeaderManager.loungeLoveInterestSpriteFilter = new List<string>();
					this.storyInterfaceHeaderManager.loungeLoveInterestSpriteFilterCounts = new List<int>();
				}
				else if (this.HHNKBNAIGGI)
				{
					this.storyInterfaceHeaderManager.loungeLoveInterestSpriteFilter = new List<string>();
					this.storyInterfaceHeaderManager.loungeLoveInterestSpriteFilterCounts = new List<int>();
				}
				else
				{
					List<string> list = new List<string>();
					List<int> list2 = new List<int>();
					if (null != AssetsManager.EHBBFMCILPC.profileDataAsset)
					{
						JSONArray jsonarray = AssetsManager.EHBBFMCILPC.profileDataAsset.GIOFKDDKAPD();
						if (null != jsonarray)
						{
							for (int i = 0; i < jsonarray.Count; i++)
							{
								JSONObject asObject = jsonarray[i].AsObject;
								string text = asObject["oid"];
								if (text != null && text.Replace(" ", "").Length != 0)
								{
									text = text.Replace(" ", "");
									int j = 0;
									while (j < this.FEDBGLIOLFK.Count)
									{
										if (text.Equals(this.FEDBGLIOLFK[j].KALBADOPCDN))
										{
											string text2 = asObject["sprite"];
											if (text2 != null && text2.Replace(" ", "").Length > 0 && this.FEDBGLIOLFK[j].LJFCMJJFCOI.Count > 0)
											{
												list.Add(text2.Replace(" ", ""));
												int num = this.FEDBGLIOLFK[j].LJFCMJJFCOI.Count;
												if (num > 24)
												{
													num = 24;
												}
												list2.Add(num);
												break;
											}
											break;
										}
										else
										{
											j++;
										}
									}
								}
							}
						}
					}
					this.storyInterfaceHeaderManager.loungeLoveInterestSpriteFilter = list;
					this.storyInterfaceHeaderManager.loungeLoveInterestSpriteFilterCounts = list2;
					this.storyInterfaceHeaderManager.loungeLoveInterestSpriteFilterHidesOthers = true;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06002ECB RID: 11979 RVA: 0x0013E0BE File Offset: 0x0013C2BE
	private void MLLBAPJOCAN()
	{
		this.JNPGJBIMNND();
		this.DLMHPEIANCL();
		this.FNPJDLCGMAO();
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeOut(new TweenCallback(this.KDOMGNHCFAM));
	}

	// Token: 0x06002ECC RID: 11980 RVA: 0x00140678 File Offset: 0x0013E878
	private CanvasGroup CJGBANBKHFL()
	{
		if (null == this.loungeShopButton)
		{
			return null;
		}
		if (null == this.ILFEBNOCOPK)
		{
			this.ILFEBNOCOPK = this.loungeShopButton.GetComponent<CanvasGroup>();
		}
		return this.ILFEBNOCOPK;
	}

	// Token: 0x06002ECD RID: 11981 RVA: 0x001433B4 File Offset: 0x001415B4
	private IEnumerator KAGOFCMCHNF(int MOHKPKNFBLG)
	{
		yield return new WaitForEndOfFrame();
		yield return new WaitForSeconds(0.1f);
		if (!this.JHNHJPOKJEF && this.OFGDGIJNDKL != null && MOHKPKNFBLG >= 0 && MOHKPKNFBLG < this.OFGDGIJNDKL.LJFCMJJFCOI.Count && this.OLEMPGNJDJJ(this.OFGDGIJNDKL.LJFCMJJFCOI[MOHKPKNFBLG]) && ODJKHCHFKNL.LEMILALILKP() == DFGILFBGPLN.screenLounge)
		{
			if (this.LNMEMIDCHMM && SceneLoungeManager.JAIKBANBFDJ(this.OFGDGIJNDKL.LJFCMJJFCOI[MOHKPKNFBLG]))
			{
				this.LNMEMIDCHMM = false;
				this.IKPODNFEMGJ(MOHKPKNFBLG);
			}
			else
			{
				this.NFEDANNNOFK(MOHKPKNFBLG);
			}
		}
		yield break;
	}

	// Token: 0x06002ECE RID: 11982 RVA: 0x001433CC File Offset: 0x001415CC
	private void IFHMKEPKEGE()
	{
		if (ODJKHCHFKNL.LEMILALILKP() != DFGILFBGPLN.screenLounge)
		{
			return;
		}
		if (this.JHNHJPOKJEF)
		{
			return;
		}
		if (this.KNHOGPLHCMH == null || this.OFGDGIJNDKL == null)
		{
			return;
		}
		int num = this.KNHOGPLHCMH.EKOIFOBAHDM();
		if (num < 0 || num >= this.OFGDGIJNDKL.LJFCMJJFCOI.Count)
		{
			return;
		}
		AFIBCKPKDHB afibckpkdhb = this.OFGDGIJNDKL.LJFCMJJFCOI[num];
		if (afibckpkdhb.MJLAEJCFCEF)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(SceneLoungeManager.JLJCHODGBBK("loungelockedtitle", "importanttitle"), this.AOJIGKFMNHJ(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("loungelockedpopup"), afibckpkdhb.NLCHIGHHAEC, afibckpkdhb.PKJHDFINDHP), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupSignInQuestion, 0f, 28);
			return;
		}
		if (SceneLoungeManager.PBFAFGBGPGI())
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), SceneLoungeManager.JLJCHODGBBK("loungestoryfinished", "specialcurrencyoptionna"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupSignInQuestion, 0f, 28);
			return;
		}
		bool flag = this.BHNFLFCKHHL.IPALJDCNBBG != null && num < this.BHNFLFCKHHL.IPALJDCNBBG.Count && this.BHNFLFCKHHL.IPALJDCNBBG[num] > 0;
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass);
		if (this.BHNFLFCKHHL.CKLNCCAGCKE(num, LiveEventsManager.EHBBFMCILPC.LiveEventActive(EGMCEPOABBF.liveEventFreeAvatar, -1, -1)) && (kioojmglclc == null || !kioojmglclc.ALFGPLALKCN()))
		{
			FPFNLJGEIJK.FIBNFNACDBE(BGHLMGPPCNN.subLngLook);
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("passrequiredtoplay"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("no"), new UnityAction(this.JKILEHPJHLM), new UnityAction(this.KODFDGNLEOB), DFGILFBGPLN.popupSignInQuestion, 0f, 28);
			return;
		}
		if (afibckpkdhb.IENEDGACMMK && SceneLoungeManager.MHOLELNFCOG(afibckpkdhb.PODGFLMDBEC) && !AKLFPGMDKLA.EHBBFMCILPC.OKNDDBOOFPL(afibckpkdhb.OBLBNLBFBNI))
		{
			this.IKPODNFEMGJ(num);
			return;
		}
		if (afibckpkdhb.IENEDGACMMK && (afibckpkdhb.OBLBNLBFBNI < 0 || !AKLFPGMDKLA.EHBBFMCILPC.OKNDDBOOFPL(afibckpkdhb.OBLBNLBFBNI)))
		{
			DPGJIJGOCIC.ADFCDFHBDAF("[Lounge] half-authored shop row tapped, not purchasable: " + afibckpkdhb.BDIHOCKCCBL);
			this.OANFNDEPNOB("loungeskinunavailable");
			return;
		}
		if (flag && !this.EIKJGDCCIFD(num) && (kioojmglclc == null || !kioojmglclc.ALFGPLALKCN()))
		{
			FPFNLJGEIJK.FIBNFNACDBE(BGHLMGPPCNN.subLngLook);
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), SceneLoungeManager.JLJCHODGBBK("loungegempassbody", "passrequiredtoplay"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("no"), new UnityAction(this.JKILEHPJHLM), new UnityAction(this.KODFDGNLEOB), DFGILFBGPLN.popupSignInQuestion, 0f, 28);
			return;
		}
		if (flag)
		{
			this.GBDLLBGONAB = num;
			this.JHNHJPOKJEF = true;
			if (null != this.storyInterfaceHeaderManager)
			{
				this.storyInterfaceHeaderManager.Hide();
			}
			CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(96);
			BackendOperationsManager.EHBBFMCILPC.RequestPremiumChoice(this.BHNFLFCKHHL.MKPMEKKGEIL[num], afibckpkdhb.NLCHIGHHAEC, afibckpkdhb.PKJHDFINDHP, afibckpkdhb.BDIHOCKCCBL, AKLFPGMDKLA.EHBBFMCILPC.NCOCIAENGJF(AKLFPGMDKLA.EHBBFMCILPC.NBMLMNGHOPP().DHONIOBOLEL.GGICIBLJIKI), false, "OnLoungePremiumChoiceSuccess", "OnLoungePremiumChoiceException", true);
			return;
		}
		this.MDDCBGOCCMA(num);
		if (null != this.BPHLDDMNPAI)
		{
			bool bjeennhmkfa = this.JOOPBLFMOFF != null && num < this.JOOPBLFMOFF.Count && this.JOOPBLFMOFF[num] > 0;
			this.BPHLDDMNPAI.PlayLoungeChoiceConfirmedEffects(bjeennhmkfa);
		}
	}

	// Token: 0x06002ECF RID: 11983 RVA: 0x00143788 File Offset: 0x00141988
	public void OnLoungeSkinStorePurchaseContinue()
	{
		this.CBJDJHCFLND();
		CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().ShowAndPurchaseProduct(this.GAFPIBFMAKM, true);
	}

	// Token: 0x06002ED0 RID: 11984 RVA: 0x001437A8 File Offset: 0x001419A8
	private void GMKKHHBHMNP(float AGPDIINHHAL, bool ILCNGGNKPDK)
	{
		if (null == this.storyInterfaceHeaderManager)
		{
			return;
		}
		if (AGPDIINHHAL > 0.85f)
		{
			this.AJEMBJLBNAM();
			this.EHEFMMIHNCN();
			this.storyInterfaceHeaderManager.Show(0f);
			return;
		}
		if (this.storyInterfaceHeaderManager.IsVisible() && !this.storyInterfaceHeaderManager.IsTouchInside(ILCNGGNKPDK))
		{
			this.storyInterfaceHeaderManager.Hide();
		}
	}

	// Token: 0x06002ED1 RID: 11985 RVA: 0x00143810 File Offset: 0x00141A10
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

	// Token: 0x06002ED2 RID: 11986 RVA: 0x00143848 File Offset: 0x00141A48
	private void CPPNKGEAMJO(float BICHMDEIFKI = 0f)
	{
		CanvasGroup canvasGroup = this.ALCDLOONDCI();
		if (null == canvasGroup)
		{
			return;
		}
		canvasGroup.DOKill(false);
		canvasGroup.blocksRaycasts = false;
		canvasGroup.DOFade(0f, 0.375f).SetDelay(BICHMDEIFKI).SetEase(Ease.Linear);
	}

	// Token: 0x06002ED3 RID: 11987 RVA: 0x00143892 File Offset: 0x00141A92
	private void BGECHBHBLBM()
	{
		if (ODJKHCHFKNL.LEMILALILKP() != DFGILFBGPLN.screenLounge)
		{
			return;
		}
		if (null != this.storyInterfaceHeaderManager)
		{
			this.storyInterfaceHeaderManager.RefreshGamePass();
		}
		this.MCPPJPHIFGE();
	}

	// Token: 0x06002ED4 RID: 11988 RVA: 0x001438C0 File Offset: 0x00141AC0
	public void JMNKDLFBBIN()
	{
		LMHHKDFCKFC lmhhkdfckfc = AKLFPGMDKLA.EHBBFMCILPC.PNLLCLPMIGA();
		if (lmhhkdfckfc != null && PurchaseManagerBridge.OOGPALHPNGM().JNNBFLDOOHM().GetProductData(lmhhkdfckfc.DEJCCBNPFEC) != null)
		{
			CommonUserInterface.IKNOFBFMPGA().ShowPopupOffer(lmhhkdfckfc.DEJCCBNPFEC, CommonUserInterface.IKNOFBFMPGA().GetPurchasingViewManager().GetProductThumbnailGraphics(lmhhkdfckfc.DEJCCBNPFEC));
		}
	}

	// Token: 0x06002ED5 RID: 11989 RVA: 0x00143917 File Offset: 0x00141B17
	private void FINPJIGDFME()
	{
		this.GHHPEBABMFN();
		this.EMOKHOCGNMA = false;
	}

	// Token: 0x06002ED6 RID: 11990 RVA: 0x00143928 File Offset: 0x00141B28
	public void OnLoungeDualPaymentIapClick()
	{
		int hjfaecnjhbe = this.HJFAECNJHBE;
		this.HJFAECNJHBE = -1;
		this.FDLBBNKAOPB = true;
		this.LNMEMIDCHMM = false;
		this.GGDPPKCIHFO(hjfaecnjhbe);
	}

	// Token: 0x06002ED7 RID: 11991 RVA: 0x00143958 File Offset: 0x00141B58
	private void MDDCBGOCCMA(int MOHKPKNFBLG)
	{
		if (MOHKPKNFBLG < 0 || this.OFGDGIJNDKL == null || MOHKPKNFBLG >= this.OFGDGIJNDKL.LJFCMJJFCOI.Count)
		{
			this.GBDLLBGONAB = -1;
			return;
		}
		AFIBCKPKDHB afibckpkdhb = this.OFGDGIJNDKL.LJFCMJJFCOI[MOHKPKNFBLG];
		string text = AKLFPGMDKLA.EHBBFMCILPC.NBMLMNGHOPP().NCAMFPGMCIG.GLBDHEKDNDC(this.OFGDGIJNDKL.KALBADOPCDN);
		AKLFPGMDKLA.EHBBFMCILPC.NBMLMNGHOPP().NCAMFPGMCIG.DHNGLOEKKFL(this.OFGDGIJNDKL.KALBADOPCDN, afibckpkdhb.BDIHOCKCCBL);
		AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
		for (int i = 0; i < AssetsManager.EHBBFMCILPC.storyAssets.Count; i++)
		{
			AssetsManager.EHBBFMCILPC.storyAssets[i].PromoteLoungeNpcAssetToChapterLifetime(afibckpkdhb.BDIHOCKCCBL);
			if (text != null && text.Length > 0 && !text.Equals(afibckpkdhb.BDIHOCKCCBL))
			{
				AssetsManager.EHBBFMCILPC.storyAssets[i].ReleaseSuperMappedLookNpcAnimationPacks(text);
			}
		}
		this.GBDLLBGONAB = -1;
		this.IGAFPNGFMCF = false;
		this.ECDBIPGBIBM("loungeskinapplied", 0.5f);
		this.CEOEPCIPHEF();
		this.BENCCPNJJIM();
	}

	// Token: 0x06002ED8 RID: 11992 RVA: 0x00143A7C File Offset: 0x00141C7C
	public void OnPreviousCharacterClick()
	{
		if (this.JHNHJPOKJEF)
		{
			return;
		}
		if (this.FEDBGLIOLFK.Count == 0)
		{
			return;
		}
		this.KCHHNKPHGNN--;
		if (this.KCHHNKPHGNN < 0)
		{
			this.KCHHNKPHGNN = this.FEDBGLIOLFK.Count - 1;
		}
		this.EGFOGFNCIKJ = this.OFGDGIJNDKL;
		this.OFGDGIJNDKL = this.FEDBGLIOLFK[this.KCHHNKPHGNN];
		this.CCIBCIFFDOO();
		this.KOOKNGIIMDO();
	}

	// Token: 0x06002ED9 RID: 11993 RVA: 0x00143AFC File Offset: 0x00141CFC
	private void LGFMFJAMNDL(string[] DCNCBHJBEMI)
	{
		if (DCNCBHJBEMI == null || DCNCBHJBEMI.Length == 0)
		{
			return;
		}
		string text = DCNCBHJBEMI[0];
		if (text == null || text.Length == 0)
		{
			return;
		}
		for (int i = 0; i < DCNCBHJBEMI.Length; i++)
		{
			if (DCNCBHJBEMI[i] == null || DCNCBHJBEMI[i].Length == 0)
			{
				DCNCBHJBEMI[i] = text;
			}
		}
	}

	// Token: 0x06002EDA RID: 11994 RVA: 0x00075398 File Offset: 0x00073598
	public void SetParent(GameObject BFGBPKIGAJI)
	{
		if (null != BFGBPKIGAJI)
		{
			base.gameObject.transform.SetParent(BFGBPKIGAJI.transform, false);
			return;
		}
		base.gameObject.transform.SetParent(null, false);
	}

	// Token: 0x06002EDB RID: 11995 RVA: 0x00143B42 File Offset: 0x00141D42
	private void CDJNFHDOMFI()
	{
		if (ODJKHCHFKNL.LEMILALILKP() != DFGILFBGPLN.screenLounge)
		{
			return;
		}
		this.KLHDJFEDIPM = true;
		this.CPPNKGEAMJO(0f);
	}

	// Token: 0x06002EDC RID: 11996 RVA: 0x00143B60 File Offset: 0x00141D60
	public void OnLoungeShopButtonClick()
	{
		if (ODJKHCHFKNL.LEMILALILKP() != DFGILFBGPLN.screenLounge || this.JHNHJPOKJEF || this.NPEBMMBADLO)
		{
			return;
		}
		if (null == AssetsManager.EHBBFMCILPC.lobbyDataAsset || !AssetsManager.EHBBFMCILPC.lobbyDataAsset.PIECGBHMOCB() || !KKLFGEHAMMC.EHBBFMCILPC.FACIFBONANM())
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("featurenotavailable"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupSignInQuestion, 0f, 28);
			return;
		}
		this.FOPJOMKFBNP = Time.frameCount;
		CommonUserInterface.EHBBFMCILPC.ShowSkinShop(this.loungeAnthologyIndex, this.AFBGKDLFBLM());
	}

	// Token: 0x06002EDD RID: 11997 RVA: 0x00143C1C File Offset: 0x00141E1C
	private string AOJIGKFMNHJ(string DIMBCOBNMAM, int NLLCKPCKGOH, int OLKMHHNMDLP)
	{
		int num = 1;
		try
		{
			AssetAnthology assetAnthology = GKJPOGNFKNK.GJAAHGIAPMH(NLLCKPCKGOH);
			if (null != assetAnthology)
			{
				num = assetAnthology.header.CJJOGBNCCCH(NLLCKPCKGOH) + 1;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return DIMBCOBNMAM.Replace("XXX", (OLKMHHNMDLP + 1).ToString() ?? "").Replace("YYY", num.ToString() ?? "");
	}

	// Token: 0x06002EDE RID: 11998 RVA: 0x00003E52 File Offset: 0x00002052
	private void Start()
	{
	}

	// Token: 0x06002EDF RID: 11999 RVA: 0x00143C9C File Offset: 0x00141E9C
	private void GKADNDECANG()
	{
		if (null != this.loungeHeaderBlur)
		{
			this.loungeHeaderBlur.enabled = false;
		}
		CharacterRenderTexturePool.SetCharacterBandBlur(this.loungeHeaderBlur, false);
	}

	// Token: 0x06002EE0 RID: 12000 RVA: 0x00143CC4 File Offset: 0x00141EC4
	private void FBCKCJPPPNE()
	{
		if (ODJKHCHFKNL.LEMILALILKP() != DFGILFBGPLN.screenLounge)
		{
			return;
		}
		this.OKJDHPBLDCF(false);
	}

	// Token: 0x06002EE1 RID: 12001 RVA: 0x00143CD8 File Offset: 0x00141ED8
	private void CBJDJHCFLND()
	{
		this.FDDBEKJKBOP = true;
		if (null != this.storyInterfaceHeaderManager)
		{
			this.storyInterfaceHeaderManager.Hide();
		}
		if (null != this.storyInterfaceHeaderManager)
		{
			this.storyInterfaceHeaderManager.PauseEvents();
		}
		this.ENJGBKCFEEK.Clear();
		this.KMNMFBGGHEM(this.content);
		this.KMNMFBGGHEM(this.extendedChoicePivot);
		this.BMJAIHFAGKB.Clear();
		Camera[] allCameras = Camera.allCameras;
		for (int i = 0; i < allCameras.Length; i++)
		{
			if (null != allCameras[i] && allCameras[i].gameObject.scene == base.gameObject.scene && allCameras[i].gameObject.activeSelf)
			{
				allCameras[i].gameObject.SetActive(false);
				this.BMJAIHFAGKB.Add(allCameras[i]);
			}
		}
	}

	// Token: 0x06002EE2 RID: 12002 RVA: 0x00143DB6 File Offset: 0x00141FB6
	private IEnumerator HINNFKGAAHE()
	{
		yield return new WaitForSeconds(1f);
		if (AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(74))
		{
			yield break;
		}
		if (ODJKHCHFKNL.LEMILALILKP() != DFGILFBGPLN.screenLounge || CommonUserInterface.EHBBFMCILPC.AnyGenericPopupIsActive())
		{
			yield break;
		}
		if (this.JHNHJPOKJEF || !SemaphoreManager.GreenLight(JLDJNIGMHLC.popups))
		{
			yield break;
		}
		AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(74);
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("tutortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("loungetutorbody"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("continue"), DFGILFBGPLN.popupSignInQuestion, 0f, 28);
		yield break;
	}

	// Token: 0x06002EE3 RID: 12003 RVA: 0x00143DC8 File Offset: 0x00141FC8
	private void IKPODNFEMGJ(int MOHKPKNFBLG)
	{
		AFIBCKPKDHB afibckpkdhb = this.OFGDGIJNDKL.LJFCMJJFCOI[MOHKPKNFBLG];
		if (afibckpkdhb.OBLBNLBFBNI < 0)
		{
			DPGJIJGOCIC.ADFCDFHBDAF("[Lounge] shop look without a shop index, purchase ignored: " + afibckpkdhb.BDIHOCKCCBL);
			return;
		}
		if (afibckpkdhb.DJDEHGFEANC || (afibckpkdhb.DENODLCMDAL != null && afibckpkdhb.DENODLCMDAL.PPBPOPEEPDJ(AKLFPGMDKLA.EHBBFMCILPC.CDNGHFCPPEA())))
		{
			afibckpkdhb.DJDEHGFEANC = true;
			this.OANFNDEPNOB("loungeofferexpired");
			return;
		}
		if (afibckpkdhb.PODGFLMDBEC == BGDLJKJPOOO.iapOnly)
		{
			this.FDLBBNKAOPB = false;
			this.LNMEMIDCHMM = false;
			this.GGDPPKCIHFO(MOHKPKNFBLG);
			return;
		}
		if (SceneLoungeManager.JAIKBANBFDJ(afibckpkdhb) && afibckpkdhb.CBLPKDDMLBL >= 0 && AKLFPGMDKLA.EHBBFMCILPC.CIAONGKLBEP(afibckpkdhb.CBLPKDDMLBL) && ((!this.IGAFPNGFMCF && !this.OOCPHDOHGDE) || this.GIGAHKHAGDO != afibckpkdhb.OBLBNLBFBNI))
		{
			this.FDLBBNKAOPB = true;
			this.PJKFBCFOBGE(MOHKPKNFBLG);
			return;
		}
		if (SceneLoungeManager.DCEINPOHIJO(afibckpkdhb))
		{
			this.AICFJBAJECM();
			return;
		}
		if (afibckpkdhb.HKLEKGFCMFI < 0)
		{
			DPGJIJGOCIC.ADFCDFHBDAF("[Lounge] shop look without a price, purchase ignored: " + afibckpkdhb.BDIHOCKCCBL);
			this.OANFNDEPNOB("loungeskinunavailable");
			return;
		}
		if (!SceneLoungeManager.JAIKBANBFDJ(afibckpkdhb))
		{
			this.EJNHFJCFGPI(MOHKPKNFBLG);
			return;
		}
		if ((this.IGAFPNGFMCF || this.OOCPHDOHGDE) && this.GIGAHKHAGDO == afibckpkdhb.OBLBNLBFBNI)
		{
			this.FDLBBNKAOPB = true;
			this.LNMEMIDCHMM = true;
			this.GGDPPKCIHFO(MOHKPKNFBLG);
			return;
		}
		if (afibckpkdhb.CBLPKDDMLBL >= 0 && AKLFPGMDKLA.EHBBFMCILPC.CIAONGKLBEP(afibckpkdhb.CBLPKDDMLBL))
		{
			this.FDLBBNKAOPB = true;
			this.PJKFBCFOBGE(MOHKPKNFBLG);
			return;
		}
		if (CommonUserInterface.EHBBFMCILPC.AnyGenericPopupIsActive())
		{
			return;
		}
		string text = SceneLoungeManager.BPBNKMPJCLH(afibckpkdhb);
		if (text.Length == 0)
		{
			DPGJIJGOCIC.ADFCDFHBDAF("[Lounge] dual-payment look without a resolvable store price, currency method only: " + afibckpkdhb.BDIHOCKCCBL);
			this.EJNHFJCFGPI(MOHKPKNFBLG);
			return;
		}
		this.HJFAECNJHBE = MOHKPKNFBLG;
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtonsAndCloseOverride(SceneLoungeManager.JLJCHODGBBK("loungepurchasetitle", "importanttitle"), SceneLoungeManager.JLJCHODGBBK("loungepurchasebody", "specialcurrencyoptionna"), afibckpkdhb.HKLEKGFCMFI.ToString() + "<space=0.0625em>" + SceneLoungeManager.JPKBKACGPJO(afibckpkdhb.PODGFLMDBEC), text + "<space=0.0625em>" + KBOJLHAJPCP.GOEIBHCAJLM, new UnityAction(this.OnLoungeDualPaymentCurrencyClick), new UnityAction(this.OnLoungeDualPaymentIapClick), new UnityAction(this.OnLoungeDualPaymentCloseClick), DFGILFBGPLN.popupEnergyHint, 0f, 28);
	}

	// Token: 0x06002EE4 RID: 12004 RVA: 0x00144020 File Offset: 0x00142220
	private void CHFBAHEKICB()
	{
		if (ODJKHCHFKNL.AMFKFMHAKIL() != DFGILFBGPLN.screenHub)
		{
			return;
		}
		if (this.JHNHJPOKJEF)
		{
			return;
		}
		if (this.KNHOGPLHCMH == null || this.OFGDGIJNDKL == null)
		{
			return;
		}
		int num = this.KNHOGPLHCMH.EKOIFOBAHDM();
		if (num < 1 || num >= this.OFGDGIJNDKL.LJFCMJJFCOI.Count)
		{
			return;
		}
		AFIBCKPKDHB afibckpkdhb = this.OFGDGIJNDKL.LJFCMJJFCOI[num];
		if (afibckpkdhb.MJLAEJCFCEF)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(SceneLoungeManager.JLJCHODGBBK("fids", "TV dots blend"), this.AOJIGKFMNHJ(CCOJBMMKNAP.COKDLDOAACJ().JCDFHKDNEDH("discontinuedtitle"), afibckpkdhb.NLCHIGHHAEC, afibckpkdhb.PKJHDFINDHP), CCOJBMMKNAP.APGODIBBPOD().IKMNGFIDCLM("(X)"), (DFGILFBGPLN)(-105), 67f, 26);
			return;
		}
		if (SceneLoungeManager.DOOJCOICINL())
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.HFAKOKBHCGH().GGPHHLGPMPA("startsInSeconds"), SceneLoungeManager.JLJCHODGBBK("‘", "stat3long"), CCOJBMMKNAP.PLJMLDOCPNM().GGPHHLGPMPA(""), (DFGILFBGPLN)102, 156f, 45);
			return;
		}
		bool flag = this.BHNFLFCKHHL.IPALJDCNBBG == null || num >= this.BHNFLFCKHHL.IPALJDCNBBG.Count || this.BHNFLFCKHHL.IPALJDCNBBG[num] > 0;
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.DCADGAIHIII(CLHDENLPOFP.gamePass);
		if (this.BHNFLFCKHHL.JBEBPDBMKMP(num, LiveEventsManager.BBGECIKOICE().HLCKJEIFAFM(EGMCEPOABBF.liveEventFreeDiamonds, -1, -1)) && (kioojmglclc == null || !kioojmglclc.OFINCPJNPJC()))
		{
			FPFNLJGEIJK.FIBNFNACDBE(BGHLMGPPCNN.d1SplashCdnSt);
			CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.PMABBOJDELF().GLEFEKBDHNK("aind"), CCOJBMMKNAP.KNKGCDDMLDP().OGKGHLHHAAI(" "), CCOJBMMKNAP.KFAABHHGOPO().PGKBCNBAOJN(""), CCOJBMMKNAP.CPCOODCFDDP().JHNELLJFBGC("congratstitle"), new UnityAction(this.LEGFKGLEMLJ), new UnityAction(this.KODFDGNLEOB), (DFGILFBGPLN)(-16), 1819f, 61);
			return;
		}
		if (afibckpkdhb.IENEDGACMMK && SceneLoungeManager.MHOLELNFCOG(afibckpkdhb.PODGFLMDBEC) && !AKLFPGMDKLA.EHBBFMCILPC.OKNDDBOOFPL(afibckpkdhb.OBLBNLBFBNI))
		{
			this.IKPODNFEMGJ(num);
			return;
		}
		if (afibckpkdhb.IENEDGACMMK && (afibckpkdhb.OBLBNLBFBNI < 1 || !AKLFPGMDKLA.EHBBFMCILPC.OKNDDBOOFPL(afibckpkdhb.OBLBNLBFBNI)))
		{
			DPGJIJGOCIC.PJCLICBPPDA("" + afibckpkdhb.BDIHOCKCCBL);
			this.NPKHGMPNODC("");
			return;
		}
		if (flag && !this.EIKJGDCCIFD(num) && (kioojmglclc == null || !kioojmglclc.ALFGPLALKCN()))
		{
			FPFNLJGEIJK.FIBNFNACDBE(BGHLMGPPCNN.subFwd);
			CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.ILACPHFEDEP().JHNELLJFBGC("Bars count"), SceneLoungeManager.JLJCHODGBBK("OnCutsceneViewLobbyAssetsDownloadSuccess", "acliffbw22"), CCOJBMMKNAP.KMNBCEMEBBD().BGELFMIOBCL("OnPopupCardOptionsUnlockWithSpException"), CCOJBMMKNAP.CPCOODCFDDP().BDGPNPNIAPA("ok"), new UnityAction(this.JKILEHPJHLM), new UnityAction(this.KODFDGNLEOB), (DFGILFBGPLN)(-126), 1509f, 10);
			return;
		}
		if (flag)
		{
			this.GBDLLBGONAB = num;
			this.JHNHJPOKJEF = false;
			if (null != this.storyInterfaceHeaderManager)
			{
				this.storyInterfaceHeaderManager.Hide();
			}
			CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation((byte)-34);
			BackendOperationsManager.NPDDBAONMJP().IHCGBJFHCDO(this.BHNFLFCKHHL.MKPMEKKGEIL[num], afibckpkdhb.NLCHIGHHAEC, afibckpkdhb.PKJHDFINDHP, afibckpkdhb.BDIHOCKCCBL, AKLFPGMDKLA.EHBBFMCILPC.NCOCIAENGJF(AKLFPGMDKLA.EHBBFMCILPC.NBMLMNGHOPP().DHONIOBOLEL.GGICIBLJIKI), false, "(", "PurchaseManagerSteam.OnPurchasePendingProcess(): Product - ", true);
			return;
		}
		this.CEODODIBAMA(num);
		if (null != this.BPHLDDMNPAI)
		{
			bool bjeennhmkfa = this.JOOPBLFMOFF == null || num >= this.JOOPBLFMOFF.Count || this.JOOPBLFMOFF[num] > 1;
			this.BPHLDDMNPAI.PlayLoungeChoiceConfirmedEffects(bjeennhmkfa);
		}
	}

	// Token: 0x06002EE5 RID: 12005 RVA: 0x001443DC File Offset: 0x001425DC
	public void SetLoungeEnvironment(int KFCMLNPLAHK, GameObject IAMJNGLOKEK)
	{
		if (this.defaultEnvironmentCustomWardrobe == null || KFCMLNPLAHK < 0 || KFCMLNPLAHK >= this.defaultEnvironmentCustomWardrobe.Count)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("SceneLoungeManager.SetLoungeEnvironment(), no wardrobe pivot for index:" + KFCMLNPLAHK.ToString());
			UnityEngine.Object.Destroy(IAMJNGLOKEK);
			return;
		}
		GameObject gameObject = this.defaultEnvironmentCustomWardrobe[KFCMLNPLAHK];
		if (!this.BJIMGPHGGIH.Contains(KFCMLNPLAHK))
		{
			this.BJIMGPHGGIH.Add(KFCMLNPLAHK);
		}
		IAMJNGLOKEK.transform.SetParent(gameObject.transform, false);
		this.JPOHEIPCPHM(IAMJNGLOKEK, gameObject.layer);
		IAMJNGLOKEK.SetActive(true);
		Renderer[] componentsInChildren = IAMJNGLOKEK.GetComponentsInChildren<Renderer>(true);
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			int num = componentsInChildren[i].sortingOrder;
			if (num < 0)
			{
				num = 0;
			}
			componentsInChildren[i].sortingOrder = 6 + num;
		}
	}

	// Token: 0x06002EE6 RID: 12006 RVA: 0x001444A0 File Offset: 0x001426A0
	private static bool DOOJCOICINL()
	{
		try
		{
			PLFDAJJHMKO plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.NBMLMNGHOPP();
			if (plfdajjhmko == null)
			{
				return false;
			}
			AssetAnthology assetAnthology = GKJPOGNFKNK.MLDENPHFNPH(plfdajjhmko.DHONIOBOLEL.GGICIBLJIKI, false);
			if (null == assetAnthology || null == assetAnthology.header)
			{
				return true;
			}
			EIOPLEFLLIM eioplefllim = AKLFPGMDKLA.EHBBFMCILPC.GJBDBONJCDL(assetAnthology.header.index);
			return eioplefllim == null || assetAnthology.header.MLGKEPJPICJ(eioplefllim.EOHGNGFHNAP(-1));
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return false;
	}

	// Token: 0x06002EE7 RID: 12007 RVA: 0x000693D6 File Offset: 0x000675D6
	public void DontDestroyOnLoad()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06002EE8 RID: 12008 RVA: 0x00144538 File Offset: 0x00142738
	public void OnNextCharacterClick()
	{
		if (this.JHNHJPOKJEF)
		{
			return;
		}
		if (this.FEDBGLIOLFK.Count == 0)
		{
			return;
		}
		this.KCHHNKPHGNN++;
		if (this.KCHHNKPHGNN >= this.FEDBGLIOLFK.Count)
		{
			this.KCHHNKPHGNN = 0;
		}
		this.EGFOGFNCIKJ = this.OFGDGIJNDKL;
		this.OFGDGIJNDKL = this.FEDBGLIOLFK[this.KCHHNKPHGNN];
		this.CCIBCIFFDOO();
		this.KPBFHKGIFID();
	}

	// Token: 0x06002EE9 RID: 12009 RVA: 0x001445B3 File Offset: 0x001427B3
	private IEnumerator EMIOFGFANDA(CanvasGroup CDFPPHCNOLD, AnimationCanvasGroupAlpha LKBIKEKEONB, float JCBGHBCAIOL)
	{
		float startAlpha = CDFPPHCNOLD.alpha;
		float elapsed = 0f;
		while (elapsed < JCBGHBCAIOL)
		{
			elapsed += Time.deltaTime;
			CDFPPHCNOLD.alpha = Mathf.Lerp(startAlpha, 0f, Mathf.Clamp01(elapsed / JCBGHBCAIOL));
			yield return null;
		}
		CDFPPHCNOLD.alpha = 0f;
		CDFPPHCNOLD.gameObject.SetActive(false);
		if (null != LKBIKEKEONB)
		{
			LKBIKEKEONB.enabled = true;
		}
		this.HNMOGHGGELK = null;
		yield break;
	}

	// Token: 0x06002EEA RID: 12010 RVA: 0x001445D8 File Offset: 0x001427D8
	private void NEFEJOLALAN()
	{
		try
		{
			if (!(null == this.loungeExtra) && this.loungeExtra.activeSelf)
			{
				this.GHHPEBABMFN();
				this.GLEKHLGJGLI();
				this.IIJAOCAAMHI(false);
				if (null == this.CCMBCGANCDO)
				{
					this.CCMBCGANCDO = this.loungeExtra.GetComponent<CanvasGroup>();
				}
				if (null == this.CCMBCGANCDO || this.CCMBCGANCDO.alpha <= 0.01f)
				{
					this.IJFNJELABIG();
				}
				else
				{
					this.CCMBCGANCDO.DOKill(false);
					this.CCMBCGANCDO.DOFade(0f, 0.375f).SetDelay(0.25f).SetEase(Ease.Linear).OnComplete(new TweenCallback(this.IJFNJELABIG));
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x04000E03 RID: 3587
	public static string onLoungeScreenLeft = "OnLoungeScreenLeft";

	// Token: 0x04000E04 RID: 3588
	public const string onLoungePremiumChoiceSuccess = "OnLoungePremiumChoiceSuccess";

	// Token: 0x04000E05 RID: 3589
	public const string onLoungePremiumChoiceExecutedHardBased = "OnLoungePremiumChoiceExecutedHardBased";

	// Token: 0x04000E06 RID: 3590
	public const string onLoungePremiumChoiceException = "OnLoungePremiumChoiceException";

	// Token: 0x04000E07 RID: 3591
	public const string onLoungePremiumChoicesHistorySuccess = "OnLoungePremiumChoicesHistorySuccess";

	// Token: 0x04000E08 RID: 3592
	public const string onLoungePremiumChoicesHistoryException = "OnLoungePremiumChoicesHistoryException";

	// Token: 0x04000E09 RID: 3593
	public const int loungeCustomFaderIndex = 100;

	// Token: 0x04000E0A RID: 3594
	private const string ACCODNJFGFC = "<space=-0.42em>";

	// Token: 0x04000E0B RID: 3595
	private const string PCLLHMOGJLF = "<space=-0.12em>";

	// Token: 0x04000E0C RID: 3596
	public const string onLoungeUnlockNpcSkinSuccess = "OnLoungeUnlockNpcSkinSuccess";

	// Token: 0x04000E0D RID: 3597
	public const string onLoungeUnlockNpcSkinException = "OnLoungeUnlockNpcSkinException";

	// Token: 0x04000E0E RID: 3598
	public static int unlockNpcSkinResult = 0;

	// Token: 0x04000E0F RID: 3599
	public static int unlockNpcSkinError = 0;

	// Token: 0x04000E10 RID: 3600
	private const int FFGKMOFGIPE = 0;

	// Token: 0x04000E11 RID: 3601
	private const int DCFIJGCLLBP = 1;

	// Token: 0x04000E12 RID: 3602
	private const int BMMKLHNDIKD = 2;

	// Token: 0x04000E13 RID: 3603
	private const int MJDDAIOEHJM = 3;

	// Token: 0x04000E14 RID: 3604
	private const int FAIMJHOHMCK = 4;

	// Token: 0x04000E15 RID: 3605
	private const int MDPMIEGBKMK = 5;

	// Token: 0x04000E16 RID: 3606
	private const int MKLBLPKPGCL = 6;

	// Token: 0x04000E17 RID: 3607
	private const int FPCCAILJKGP = 7;

	// Token: 0x04000E18 RID: 3608
	public const string onLoungeLoveInterestShortcutClick = "OnLoungeLoveInterestShortcutClick";

	// Token: 0x04000E19 RID: 3609
	public Camera cameraUI2;

	// Token: 0x04000E1A RID: 3610
	public Camera cameraUI2VFXBack;

	// Token: 0x04000E1B RID: 3611
	public int loungeAnthologyIndex = -1;

	// Token: 0x04000E1C RID: 3612
	public GameObject content;

	// Token: 0x04000E1D RID: 3613
	public GameObject defaultEnvironment;

	// Token: 0x04000E1E RID: 3614
	public List<GameObject> defaultEnvironmentCustomWardrobe;

	// Token: 0x04000E1F RID: 3615
	public StoryInterfaceHeaderManager storyInterfaceHeaderManager;

	// Token: 0x04000E20 RID: 3616
	public ImageEffectsSelector imageEffects;

	// Token: 0x04000E21 RID: 3617
	public BlurOptimized loungeHeaderBlur;

	// Token: 0x04000E22 RID: 3618
	public GameObject loungeExtra;

	// Token: 0x04000E23 RID: 3619
	public GameObject loungeExtraResetButton;

	// Token: 0x04000E24 RID: 3620
	public GameObject loungeShopButton;

	// Token: 0x04000E25 RID: 3621
	public GameObject loungeCurrencyInfoButton;

	// Token: 0x04000E26 RID: 3622
	public GameObject loungeShopNewSkinsDisc;

	// Token: 0x04000E27 RID: 3623
	public TextMeshProUGUI loungeShopNewSkinsText;

	// Token: 0x04000E28 RID: 3624
	public Sprite loungeExtraResetSprite0;

	// Token: 0x04000E29 RID: 3625
	public Sprite loungeExtraResetSprite1;

	// Token: 0x04000E2A RID: 3626
	public Vector2 loungeExtraDisplacement = new Vector2(16f, 32f);

	// Token: 0x04000E2B RID: 3627
	public float loungeExtraNarrowOffsetX = 16f;

	// Token: 0x04000E2C RID: 3628
	public float loungeExtraNarrowOffsetY;

	// Token: 0x04000E2D RID: 3629
	public float loungeExtraNarrowDownscale = 0.92f;

	// Token: 0x04000E2E RID: 3630
	public GameObject loungeExtraNotificationGeneric;

	// Token: 0x04000E2F RID: 3631
	public GameObject loungeLockedIcon;

	// Token: 0x04000E30 RID: 3632
	public TextMeshProUGUI loungeInfoUnlockText;

	// Token: 0x04000E31 RID: 3633
	public TextMeshProUGUI loungeInfoBonusText;

	// Token: 0x04000E32 RID: 3634
	public TextMeshProUGUI loungeInfoLoveInterestText;

	// Token: 0x04000E33 RID: 3635
	public Image loungeInfoPanelImage;

	// Token: 0x04000E34 RID: 3636
	public float loungeInfoOffsetY;

	// Token: 0x04000E35 RID: 3637
	private float EJKELFOGBAL;

	// Token: 0x04000E36 RID: 3638
	private bool CFLLMFBFAIF;

	// Token: 0x04000E37 RID: 3639
	public Vector2 loungeShopCostDisplacement = new Vector2(84f, 0f);

	// Token: 0x04000E38 RID: 3640
	public Sprite loungeShopButtonSprite;

	// Token: 0x04000E39 RID: 3641
	public Sprite loungeShopButtonPressedSprite;

	// Token: 0x04000E3A RID: 3642
	public GameObject nameParent;

	// Token: 0x04000E3B RID: 3643
	public TextMeshProUGUI nameText;

	// Token: 0x04000E3C RID: 3644
	public GameObject extendedChoicePivot;

	// Token: 0x04000E3D RID: 3645
	public GameObject extendedChoicePrefab;

	// Token: 0x04000E3E RID: 3646
	private const float FCNIIOBIIFP = 22.76f;

	// Token: 0x04000E3F RID: 3647
	private AssetAnthologyHeader LPBFAGDJKIH;

	// Token: 0x04000E40 RID: 3648
	private PMNHKIDIMLM BHNFLFCKHHL;

	// Token: 0x04000E41 RID: 3649
	private LHBFJJIJNMI KNHOGPLHCMH;

	// Token: 0x04000E42 RID: 3650
	private List<int> JOOPBLFMOFF;

	// Token: 0x04000E43 RID: 3651
	private ChoiceExtendedManager BPHLDDMNPAI;

	// Token: 0x04000E44 RID: 3652
	private AssetAnthologyHeader NDFACHLEJLJ;

	// Token: 0x04000E45 RID: 3653
	private string PEGONJGOGBA = "";

	// Token: 0x04000E46 RID: 3654
	private string ENGFBODBGJE = "";

	// Token: 0x04000E47 RID: 3655
	private int KCHHNKPHGNN;

	// Token: 0x04000E48 RID: 3656
	private static string JKPMFPPGMKB = null;

	// Token: 0x04000E49 RID: 3657
	private static string OLNLCJEOMDD = null;

	// Token: 0x04000E4A RID: 3658
	private static bool BKIDGKFEIEH = false;

	// Token: 0x04000E4B RID: 3659
	private static bool FLGAKNHHPHI = false;

	// Token: 0x04000E4C RID: 3660
	private static bool GMJBFAHDDAK = false;

	// Token: 0x04000E4D RID: 3661
	private bool NPEBMMBADLO;

	// Token: 0x04000E4E RID: 3662
	private bool FJIOJFGDGBH;

	// Token: 0x04000E4F RID: 3663
	private bool HHNKBNAIGGI;

	// Token: 0x04000E50 RID: 3664
	private FJLGCKNOJMJ IALOMHOIJPH;

	// Token: 0x04000E51 RID: 3665
	private GHMINFEGBGN OFGDGIJNDKL;

	// Token: 0x04000E52 RID: 3666
	private GHMINFEGBGN EGFOGFNCIKJ;

	// Token: 0x04000E53 RID: 3667
	private List<GHMINFEGBGN> FEDBGLIOLFK = new List<GHMINFEGBGN>();

	// Token: 0x04000E54 RID: 3668
	private List<int> BJIMGPHGGIH = new List<int>();

	// Token: 0x04000E55 RID: 3669
	private List<Canvas> ENJGBKCFEEK = new List<Canvas>();

	// Token: 0x04000E56 RID: 3670
	private List<Camera> BMJAIHFAGKB = new List<Camera>();

	// Token: 0x04000E57 RID: 3671
	private bool FDDBEKJKBOP;

	// Token: 0x04000E58 RID: 3672
	private bool POFOPOOBAEF;

	// Token: 0x04000E59 RID: 3673
	public const int loungeTutorialStepIndex = 74;

	// Token: 0x04000E5A RID: 3674
	private const float HFAIHMPPKDC = 1f;

	// Token: 0x04000E5B RID: 3675
	private const float GNGKFFPODLM = -20f;

	// Token: 0x04000E5C RID: 3676
	private const int DOOFODPHHLP = -1;

	// Token: 0x04000E5D RID: 3677
	private const int FEKMIPNKKON = 2;

	// Token: 0x04000E5E RID: 3678
	private Coroutine HNMOGHGGELK;

	// Token: 0x04000E5F RID: 3679
	[NonSerialized]
	private TextMeshProUGUI HFGKNDCBGJE;

	// Token: 0x04000E60 RID: 3680
	[NonSerialized]
	private QuietNotificationManager OMIJCBCDBIC;

	// Token: 0x04000E61 RID: 3681
	private const float HJJBHEDJFFC = 0.5f;

	// Token: 0x04000E62 RID: 3682
	private Coroutine KBKBOHICPBL;

	// Token: 0x04000E63 RID: 3683
	private const float CBJMCNODGAJ = 48f;

	// Token: 0x04000E64 RID: 3684
	private const float EKDBJAHALCF = 17f;

	// Token: 0x04000E65 RID: 3685
	[NonSerialized]
	private AnimationCanvasGroupAlpha HIGMMPJDADP;

	// Token: 0x04000E66 RID: 3686
	private const float JJBCEMGECMC = 0.5f;

	// Token: 0x04000E67 RID: 3687
	private const float EELPLPPOFFM = 0.375f;

	// Token: 0x04000E68 RID: 3688
	private const float GIEIKJENCLC = 0.25f;

	// Token: 0x04000E69 RID: 3689
	private const float BKFKADHJEAO = 0.75f;

	// Token: 0x04000E6A RID: 3690
	private const float LLAPHMBCDIN = 80f;

	// Token: 0x04000E6B RID: 3691
	[NonSerialized]
	private bool EMOKHOCGNMA;

	// Token: 0x04000E6C RID: 3692
	[NonSerialized]
	private Coroutine MPBAFMPGJII;

	// Token: 0x04000E6D RID: 3693
	[NonSerialized]
	private CanvasGroup CCMBCGANCDO;

	// Token: 0x04000E6E RID: 3694
	[NonSerialized]
	private float EAMLEJINMDD = 1f;

	// Token: 0x04000E6F RID: 3695
	[NonSerialized]
	private Vector2 BCACBGFHKPC = Vector2.zero;

	// Token: 0x04000E70 RID: 3696
	private const string KLCJBCABOOF = "ButtonPrevNpc";

	// Token: 0x04000E71 RID: 3697
	private const string KADDOHGPCLB = "ButtonNextNpc";

	// Token: 0x04000E72 RID: 3698
	[NonSerialized]
	private GameObject ONOLLMGCAOK;

	// Token: 0x04000E73 RID: 3699
	[NonSerialized]
	private GameObject IHPHNLDPJIP;

	// Token: 0x04000E74 RID: 3700
	[NonSerialized]
	private CanvasGroup ILFEBNOCOPK;

	// Token: 0x04000E75 RID: 3701
	[NonSerialized]
	private bool ILLNEDFDGOD;

	// Token: 0x04000E76 RID: 3702
	[NonSerialized]
	private bool KLHDJFEDIPM;

	// Token: 0x04000E77 RID: 3703
	private int FOPJOMKFBNP = -1;

	// Token: 0x04000E78 RID: 3704
	private int GBDLLBGONAB = -1;

	// Token: 0x04000E79 RID: 3705
	private bool IGAFPNGFMCF;

	// Token: 0x04000E7A RID: 3706
	private string GAFPIBFMAKM = "";

	// Token: 0x04000E7B RID: 3707
	private int GIGAHKHAGDO = -1;

	// Token: 0x04000E7C RID: 3708
	private bool FDLBBNKAOPB;

	// Token: 0x04000E7D RID: 3709
	private int HJFAECNJHBE = -1;

	// Token: 0x04000E7E RID: 3710
	private bool LNMEMIDCHMM;

	// Token: 0x04000E7F RID: 3711
	private bool OOCPHDOHGDE;

	// Token: 0x04000E80 RID: 3712
	private bool IHANGJHFKCB;

	// Token: 0x04000E81 RID: 3713
	private bool JHNHJPOKJEF;

	// Token: 0x04000E82 RID: 3714
	[NonSerialized]
	private Vector3 JKIKIAEJKDO = Vector3.zero;

	// Token: 0x04000E83 RID: 3715
	[NonSerialized]
	private Vector3 MLDLPLPLJNH = Vector3.zero;

	// Token: 0x04000E84 RID: 3716
	[NonSerialized]
	private bool ABMAGBPBCGE;

	// Token: 0x04000E85 RID: 3717
	private const int HCDKEDENHMN = 24;

	// Token: 0x02000172 RID: 370
	[CompilerGenerated]
	private sealed class IHKKNFDFMII
	{
		// Token: 0x06002F0F RID: 12047 RVA: 0x00144AE1 File Offset: 0x00142CE1
		internal void EMKDNJBCDAI()
		{
			this.canvasGroup.blocksRaycasts = true;
		}

		// Token: 0x04000E9F RID: 3743
		public CanvasGroup canvasGroup;
	}

	// Token: 0x02000173 RID: 371
	[CompilerGenerated]
	private sealed class CEBGHJEIJLA
	{
		// Token: 0x06002F11 RID: 12049 RVA: 0x00144AEF File Offset: 0x00142CEF
		internal void FCGBDCNFABK()
		{
			this.canvasGroup.blocksRaycasts = true;
		}

		// Token: 0x04000EA0 RID: 3744
		public CanvasGroup canvasGroup;
	}
}
