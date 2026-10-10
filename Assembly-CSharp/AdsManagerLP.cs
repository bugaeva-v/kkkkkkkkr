using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Services.LevelPlay;
using UnityEngine;

// Token: 0x0200006A RID: 106
public class AdsManagerLP : MonoBehaviour
{
	// Token: 0x06000E62 RID: 3682 RVA: 0x00003E52 File Offset: 0x00002052
	public void BBABADJCPDA(string MOGFACOEMBE, string IOHMBPHDJIC, string PBMIJOGPGHJ)
	{
	}

	// Token: 0x06000E63 RID: 3683 RVA: 0x00068FEB File Offset: 0x000671EB
	private void DAMBBPMHJKJ(LevelPlayConfiguration HEMCDIDKEPA)
	{
		DPGJIJGOCIC.CMGOAFDBAOH(",");
		this.EABNFONAMGM = false;
		this.DNMJMCOFICG();
	}

	// Token: 0x06000E64 RID: 3684 RVA: 0x00069004 File Offset: 0x00067204
	private void JJFELKBFMPK(LevelPlayAdInfo OLEHBMFCNJP)
	{
		DPGJIJGOCIC.NFIDPOMCNLP("");
		this.FLJNHHAPOHP = true;
		AudioListener.pause = true;
	}

	// Token: 0x06000E65 RID: 3685 RVA: 0x0006901D File Offset: 0x0006721D
	private void PJMDKPOPMDK(LevelPlayAdError GCFILGFLALC)
	{
		DPGJIJGOCIC.ANOPFDLPKGC("AdsManagerLP: Received RewardedVideoOnAdLoadFailedEvent");
	}

	// Token: 0x06000E66 RID: 3686 RVA: 0x00069029 File Offset: 0x00067229
	private void NPJDGDLBJAI(LevelPlayInitError GCFILGFLALC)
	{
		DPGJIJGOCIC.ANOPFDLPKGC("_web");
	}

	// Token: 0x06000E67 RID: 3687 RVA: 0x00069035 File Offset: 0x00067235
	private void GANODBFCANG(LevelPlayAdInfo OLEHBMFCNJP, LevelPlayAdError GCFILGFLALC)
	{
		DPGJIJGOCIC.ANOPFDLPKGC("favstostr2");
		base.StartCoroutine(this.MPFJCBLJMNN(OLEHBMFCNJP));
	}

	// Token: 0x06000E68 RID: 3688 RVA: 0x0006904F File Offset: 0x0006724F
	public void IGNCGFDLIMD()
	{
		if (this.NKECCKCDLBL != null && !this.NKECCKCDLBL.IsAdReady())
		{
			DPGJIJGOCIC.CMGOAFDBAOH("@");
			this.NKECCKCDLBL.LoadAd();
		}
	}

	// Token: 0x06000E69 RID: 3689 RVA: 0x0006907B File Offset: 0x0006727B
	private void OnApplicationFocus(bool IBELFEBCBMK)
	{
		if (IBELFEBCBMK && !this.FLJNHHAPOHP && AudioListener.pause)
		{
			DPGJIJGOCIC.NFIDPOMCNLP("AdsManagerLP: OnApplicationFocus() restoring paused audio");
			AudioListener.pause = false;
		}
	}

	// Token: 0x06000E6A RID: 3690 RVA: 0x0006909F File Offset: 0x0006729F
	private void HDAJBOMGFAI(LevelPlayAdInfo OLEHBMFCNJP, LevelPlayReward AJOEAFELLHO)
	{
		DPGJIJGOCIC.CMGOAFDBAOH("sd");
		this.NDMPCCGECML = 1;
	}

	// Token: 0x06000E6B RID: 3691 RVA: 0x000690B2 File Offset: 0x000672B2
	private void OOBOONHEAGF(LevelPlayConfiguration HEMCDIDKEPA)
	{
		DPGJIJGOCIC.NFIDPOMCNLP("dev");
		this.EABNFONAMGM = false;
		this.DNMJMCOFICG();
	}

	// Token: 0x06000E6C RID: 3692 RVA: 0x000690CC File Offset: 0x000672CC
	public static AdsManagerLP AEELGGPEJCC()
	{
		if (!AdsManagerLP.IKLAPGJDMNA)
		{
			AdsManagerLP.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(AdsManagerLP)) as AdsManagerLP);
			if (!AdsManagerLP.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("newuseraddrequest3");
			}
		}
		return AdsManagerLP.IKLAPGJDMNA;
	}

	// Token: 0x06000E6D RID: 3693 RVA: 0x00069119 File Offset: 0x00067319
	private void CPCIAMCMENF(LevelPlayInitError GCFILGFLALC)
	{
		DPGJIJGOCIC.ANOPFDLPKGC("");
	}

	// Token: 0x06000E6E RID: 3694 RVA: 0x00069125 File Offset: 0x00067325
	private IEnumerator FPFMOOPJPGB()
	{
		AdsManagerLP.NFOCPPBLEMI nfocppblemi = new AdsManagerLP.NFOCPPBLEMI(1);
		nfocppblemi.<>4__this = this;
		return nfocppblemi;
	}

	// Token: 0x06000E6F RID: 3695 RVA: 0x00069134 File Offset: 0x00067334
	private void JPPBJKKNIED()
	{
		if (AdsManagerLP.IKLAPGJDMNA == this)
		{
			if (this.NKECCKCDLBL != null)
			{
				this.NKECCKCDLBL.DestroyAd();
			}
			AdsManagerLP.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x06000E70 RID: 3696 RVA: 0x0006915C File Offset: 0x0006735C
	private void KODEPHHHHAJ()
	{
		DPGJIJGOCIC.NFIDPOMCNLP("AdsManagerLP: EnableAds() called");
		this.NKECCKCDLBL = new LevelPlayRewardedAd(IPEBDNGCDBJ.GMJIJHKCLHK, null);
		this.NKECCKCDLBL.OnAdLoadFailed += this.PJMDKPOPMDK;
		this.NKECCKCDLBL.OnAdDisplayed += this.PJMDNAAGAPB;
		this.NKECCKCDLBL.OnAdDisplayFailed += this.DEFNDJOFING;
		this.NKECCKCDLBL.OnAdRewarded += this.MCJNABHEGJJ;
		this.NKECCKCDLBL.OnAdClosed += this.BHNLKJAEOOJ;
		this.RefreshAdUnits();
	}

	// Token: 0x06000E71 RID: 3697 RVA: 0x00069200 File Offset: 0x00067400
	public static AdsManagerLP JOPPNJGEBGC()
	{
		if (!AdsManagerLP.IKLAPGJDMNA)
		{
			AdsManagerLP.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(AdsManagerLP)) as AdsManagerLP);
			if (!AdsManagerLP.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("gpsasst");
			}
		}
		return AdsManagerLP.IKLAPGJDMNA;
	}

	// Token: 0x06000E72 RID: 3698 RVA: 0x0006924D File Offset: 0x0006744D
	public void EAJEFHLPIHE()
	{
		if (this.NKECCKCDLBL != null && !this.NKECCKCDLBL.IsAdReady())
		{
			DPGJIJGOCIC.CMGOAFDBAOH("");
			this.NKECCKCDLBL.LoadAd();
		}
	}

	// Token: 0x06000E73 RID: 3699 RVA: 0x00069279 File Offset: 0x00067479
	private IEnumerator LHFIMCDPCBI(LevelPlayAdInfo OLEHBMFCNJP)
	{
		AdsManagerLP.NLHLHJNCLNO nlhlhjnclno = new AdsManagerLP.NLHLHJNCLNO(1);
		nlhlhjnclno.<>4__this = this;
		nlhlhjnclno.adInfo = OLEHBMFCNJP;
		return nlhlhjnclno;
	}

	// Token: 0x06000E74 RID: 3700 RVA: 0x0006928F File Offset: 0x0006748F
	public void RefreshAdUnits()
	{
		if (this.NKECCKCDLBL != null && !this.NKECCKCDLBL.IsAdReady())
		{
			DPGJIJGOCIC.NFIDPOMCNLP("AdsManagerLP: RefreshAdUnits() called");
			this.NKECCKCDLBL.LoadAd();
		}
	}

	// Token: 0x06000E75 RID: 3701 RVA: 0x000692BB File Offset: 0x000674BB
	private void NHMJILHIJHK(LevelPlayAdError GCFILGFLALC)
	{
		DPGJIJGOCIC.ANOPFDLPKGC("p");
	}

	// Token: 0x06000E76 RID: 3702 RVA: 0x000692C7 File Offset: 0x000674C7
	private void EILCBCCIJCO(LevelPlayAdError GCFILGFLALC)
	{
		DPGJIJGOCIC.ANOPFDLPKGC("ontitle");
	}

	// Token: 0x06000E77 RID: 3703 RVA: 0x000692D4 File Offset: 0x000674D4
	public void EEEIMGKEMKM(string MOGFACOEMBE, string IOHMBPHDJIC, string PBMIJOGPGHJ)
	{
		if (this.EABNFONAMGM && this.NKECCKCDLBL != null)
		{
			DPGJIJGOCIC.CMGOAFDBAOH("CLIENT.AVATAR.BODY");
			this.NDMPCCGECML = 1;
			this.MGABAKDDOIE = MOGFACOEMBE;
			this.HAFPANAODGH = IOHMBPHDJIC;
			this.EFEEHPNJIGL = PBMIJOGPGHJ;
			AudioListener.pause = true;
			ApplicationFocusManager.Deactivate();
			this.NKECCKCDLBL.ShowAd(null);
		}
	}

	// Token: 0x06000E78 RID: 3704 RVA: 0x0006932E File Offset: 0x0006752E
	private void DKJEDOHBJFH(LevelPlayConfiguration HEMCDIDKEPA)
	{
		DPGJIJGOCIC.CMGOAFDBAOH("\"");
		this.EABNFONAMGM = true;
		this.KCHNEIGDLHA();
	}

	// Token: 0x06000E79 RID: 3705 RVA: 0x00069347 File Offset: 0x00067547
	public void GIJFEAFMDML()
	{
		if (this.NKECCKCDLBL != null && !this.NKECCKCDLBL.IsAdReady())
		{
			DPGJIJGOCIC.NFIDPOMCNLP("retry");
			this.NKECCKCDLBL.LoadAd();
		}
	}

	// Token: 0x06000E7A RID: 3706 RVA: 0x00069373 File Offset: 0x00067573
	private void JKBJEOHAOJF(LevelPlayAdInfo OLEHBMFCNJP, LevelPlayAdError GCFILGFLALC)
	{
		DPGJIJGOCIC.ANOPFDLPKGC("OnSaveSyncAnyResultFocusItem");
		base.StartCoroutine(this.ANHIKLNNLPK(OLEHBMFCNJP));
	}

	// Token: 0x06000E7B RID: 3707 RVA: 0x0006938D File Offset: 0x0006758D
	private void IHHPNJEIKIP(LevelPlayInitError GCFILGFLALC)
	{
		DPGJIJGOCIC.ANOPFDLPKGC("sksku");
	}

	// Token: 0x06000E7C RID: 3708 RVA: 0x00069399 File Offset: 0x00067599
	private void IHMDCDAINBE(bool IBELFEBCBMK)
	{
		if (IBELFEBCBMK && !this.FLJNHHAPOHP && AudioListener.pause)
		{
			DPGJIJGOCIC.CMGOAFDBAOH("digitalglitch");
			AudioListener.pause = true;
		}
	}

	// Token: 0x06000E7D RID: 3709 RVA: 0x000693BD File Offset: 0x000675BD
	private void AACJMEMJBKI(LevelPlayConfiguration HEMCDIDKEPA)
	{
		DPGJIJGOCIC.CMGOAFDBAOH("spld");
		this.EABNFONAMGM = false;
		this.OHECGHOLIGO();
	}

	// Token: 0x06000E7E RID: 3710 RVA: 0x000693D6 File Offset: 0x000675D6
	private void Awake()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06000E7F RID: 3711 RVA: 0x000693E3 File Offset: 0x000675E3
	private IEnumerator CHKAMJMGGFH()
	{
		while (!AppTrackingTransparency.CanStartIDFADependantSDKs())
		{
			yield return new WaitForEndOfFrame();
		}
		DPGJIJGOCIC.NFIDPOMCNLP("AdsManagerLP: InitializeDelayed() called");
		LevelPlay.OnInitSuccess += this.GLAOBLJFAFP;
		LevelPlay.OnInitFailed += this.BMAJNNPBMCJ;
		LevelPlay.Init(IPEBDNGCDBJ.OBLILOEHDNC, null);
		yield break;
	}

	// Token: 0x06000E80 RID: 3712 RVA: 0x00003E52 File Offset: 0x00002052
	public void IENMADKNCKD(string MOGFACOEMBE, string IOHMBPHDJIC, string PBMIJOGPGHJ)
	{
	}

	// Token: 0x06000E81 RID: 3713 RVA: 0x000693F2 File Offset: 0x000675F2
	private IEnumerator ANHIKLNNLPK(LevelPlayAdInfo OLEHBMFCNJP)
	{
		this.FLJNHHAPOHP = false;
		AudioListener.pause = false;
		yield return new WaitForEndOfFrame();
		yield return new WaitForEndOfFrame();
		yield return new WaitForEndOfFrame();
		if (this.NDMPCCGECML == 1)
		{
			DPGJIJGOCIC.NFIDPOMCNLP("AdsManagerLP: DispatchEventsOnAdFinish(): onAdsProviderAdSuccess");
			Dictionary<string, object> cdmncpmidjp = new Dictionary<string, object>();
			if (OLEHBMFCNJP.AdNetwork.ToLowerInvariant().Contains("unity"))
			{
				AppsFlyerManagerBridge.EHBBFMCILPC.SendEvent("ad_watch_unity", cdmncpmidjp);
			}
			else if (OLEHBMFCNJP.AdNetwork.ToLowerInvariant().Contains("ironsource"))
			{
				AppsFlyerManagerBridge.EHBBFMCILPC.SendEvent("ad_watch_ironsource", cdmncpmidjp);
			}
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC(this.MGABAKDDOIE, 0f);
		}
		else
		{
			DPGJIJGOCIC.NFIDPOMCNLP("AdsManagerLP: DispatchEventsOnAdFinish(): onAdsProviderAdFailed");
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC(this.EFEEHPNJIGL, 0f);
		}
		ApplicationFocusManager.Restore();
		this.RefreshAdUnits();
		this.MGABAKDDOIE = "";
		this.HAFPANAODGH = "";
		this.EFEEHPNJIGL = "";
		this.NDMPCCGECML = 0;
		yield break;
	}

	// Token: 0x06000E82 RID: 3714 RVA: 0x00069134 File Offset: 0x00067334
	private void JBMBMNAIIHF()
	{
		if (AdsManagerLP.IKLAPGJDMNA == this)
		{
			if (this.NKECCKCDLBL != null)
			{
				this.NKECCKCDLBL.DestroyAd();
			}
			AdsManagerLP.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x06000E83 RID: 3715 RVA: 0x00069408 File Offset: 0x00067608
	public void CLKOIPPIMGP()
	{
		if (this.NKECCKCDLBL != null && !this.NKECCKCDLBL.IsAdReady())
		{
			DPGJIJGOCIC.NFIDPOMCNLP("");
			this.NKECCKCDLBL.LoadAd();
		}
	}

	// Token: 0x06000E84 RID: 3716 RVA: 0x00069434 File Offset: 0x00067634
	public bool MMBBMDNBHJL()
	{
		return this.EABNFONAMGM && this.NKECCKCDLBL != null && this.NKECCKCDLBL.IsAdReady();
	}

	// Token: 0x06000E85 RID: 3717 RVA: 0x00069453 File Offset: 0x00067653
	private void FIFDLLCBHFL(LevelPlayAdInfo OLEHBMFCNJP)
	{
		DPGJIJGOCIC.NFIDPOMCNLP(" ");
		this.FLJNHHAPOHP = false;
		AudioListener.pause = false;
	}

	// Token: 0x06000E86 RID: 3718 RVA: 0x0006946C File Offset: 0x0006766C
	private void KLHOICFFMBI(LevelPlayConfiguration HEMCDIDKEPA)
	{
		DPGJIJGOCIC.CMGOAFDBAOH(")");
		this.EABNFONAMGM = false;
		this.BMFCPBNGMJD();
	}

	// Token: 0x06000E87 RID: 3719 RVA: 0x00069485 File Offset: 0x00067685
	public bool FGBBEBGEBLK()
	{
		return !this.EABNFONAMGM || this.NKECCKCDLBL == null || this.NKECCKCDLBL.IsAdReady();
	}

	// Token: 0x06000E88 RID: 3720 RVA: 0x000694A4 File Offset: 0x000676A4
	private void KJCDIIMFMBD()
	{
		DPGJIJGOCIC.CMGOAFDBAOH("abpd3");
		this.NKECCKCDLBL = new LevelPlayRewardedAd(IPEBDNGCDBJ.GMJIJHKCLHK, null);
		this.NKECCKCDLBL.OnAdLoadFailed += this.OBMALPCGLGF;
		this.NKECCKCDLBL.OnAdDisplayed += this.PJMDNAAGAPB;
		this.NKECCKCDLBL.OnAdDisplayFailed += this.GFGFCCJGCGK;
		this.NKECCKCDLBL.OnAdRewarded += this.BDPHKJJFHBB;
		this.NKECCKCDLBL.OnAdClosed += this.EPLAMKNLHLM;
		this.LLCIFDPJAJF();
	}

	// Token: 0x06000E89 RID: 3721 RVA: 0x00069545 File Offset: 0x00067745
	private void OPOFCGJNPAF(LevelPlayAdError GCFILGFLALC)
	{
		DPGJIJGOCIC.ANOPFDLPKGC("OnStoryInterfaceHeaderHideComplete");
	}

	// Token: 0x06000E8A RID: 3722 RVA: 0x00069551 File Offset: 0x00067751
	private void LANLBHCEGJI(LevelPlayAdInfo OLEHBMFCNJP)
	{
		DPGJIJGOCIC.CMGOAFDBAOH("acts");
		base.StartCoroutine(this.LHFIMCDPCBI(OLEHBMFCNJP));
	}

	// Token: 0x06000E8B RID: 3723 RVA: 0x0006956B File Offset: 0x0006776B
	private void KDGNFFDKNJI(LevelPlayAdError GCFILGFLALC)
	{
		DPGJIJGOCIC.ANOPFDLPKGC("AccountSignInManager.StartSignInLogic() - AccountSignInMethod.token sign in method not supported for auto source, falling back to device id.");
	}

	// Token: 0x06000E8C RID: 3724 RVA: 0x00069577 File Offset: 0x00067777
	public void CEDGALPCOLA()
	{
		if (KHPGPLAMAIN.JPFALCGBPBF())
		{
			base.StartCoroutine(this.CHKAMJMGGFH());
		}
	}

	// Token: 0x06000E8D RID: 3725 RVA: 0x0006958D File Offset: 0x0006778D
	private void EPLAMKNLHLM(LevelPlayAdInfo OLEHBMFCNJP)
	{
		DPGJIJGOCIC.NFIDPOMCNLP("ProductThumbnailManager.Initialize() - unityIapProduct is null, aborting.");
		base.StartCoroutine(this.DFNKLJFJFCI(OLEHBMFCNJP));
	}

	// Token: 0x06000E8E RID: 3726 RVA: 0x00069125 File Offset: 0x00067325
	private IEnumerator BDNCIGGNFGN()
	{
		AdsManagerLP.NFOCPPBLEMI nfocppblemi = new AdsManagerLP.NFOCPPBLEMI(1);
		nfocppblemi.<>4__this = this;
		return nfocppblemi;
	}

	// Token: 0x06000E8F RID: 3727 RVA: 0x000693D6 File Offset: 0x000675D6
	private void JFFNFDKBMGP()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06000E90 RID: 3728 RVA: 0x000695A7 File Offset: 0x000677A7
	private void MCJNABHEGJJ(LevelPlayAdInfo OLEHBMFCNJP, LevelPlayReward AJOEAFELLHO)
	{
		DPGJIJGOCIC.NFIDPOMCNLP("AdsManagerLP: Received RewardedVideoOnAdRewardedEvent");
		this.NDMPCCGECML = 1;
	}

	// Token: 0x06000E91 RID: 3729 RVA: 0x000695BA File Offset: 0x000677BA
	private void GONEAPCNONP(LevelPlayAdInfo OLEHBMFCNJP)
	{
		DPGJIJGOCIC.CMGOAFDBAOH("_AlphaTex");
		base.StartCoroutine(this.GHOELAPHAGI(OLEHBMFCNJP));
	}

	// Token: 0x06000E92 RID: 3730 RVA: 0x000695D4 File Offset: 0x000677D4
	private void LHOKEPDNLFP(LevelPlayConfiguration HEMCDIDKEPA)
	{
		DPGJIJGOCIC.CMGOAFDBAOH("PurchaseManagerUnity.OnBackendValidateTransactionFailed().");
		this.EABNFONAMGM = false;
		this.HNCBPIMNFCA();
	}

	// Token: 0x06000E93 RID: 3731 RVA: 0x00003E52 File Offset: 0x00002052
	public void ShowAdNonRewarded(string MOGFACOEMBE, string IOHMBPHDJIC, string PBMIJOGPGHJ)
	{
	}

	// Token: 0x06000E94 RID: 3732 RVA: 0x000693F2 File Offset: 0x000675F2
	private IEnumerator GHOELAPHAGI(LevelPlayAdInfo OLEHBMFCNJP)
	{
		this.FLJNHHAPOHP = false;
		AudioListener.pause = false;
		yield return new WaitForEndOfFrame();
		yield return new WaitForEndOfFrame();
		yield return new WaitForEndOfFrame();
		if (this.NDMPCCGECML == 1)
		{
			DPGJIJGOCIC.NFIDPOMCNLP("AdsManagerLP: DispatchEventsOnAdFinish(): onAdsProviderAdSuccess");
			Dictionary<string, object> cdmncpmidjp = new Dictionary<string, object>();
			if (OLEHBMFCNJP.AdNetwork.ToLowerInvariant().Contains("unity"))
			{
				AppsFlyerManagerBridge.EHBBFMCILPC.SendEvent("ad_watch_unity", cdmncpmidjp);
			}
			else if (OLEHBMFCNJP.AdNetwork.ToLowerInvariant().Contains("ironsource"))
			{
				AppsFlyerManagerBridge.EHBBFMCILPC.SendEvent("ad_watch_ironsource", cdmncpmidjp);
			}
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC(this.MGABAKDDOIE, 0f);
		}
		else
		{
			DPGJIJGOCIC.NFIDPOMCNLP("AdsManagerLP: DispatchEventsOnAdFinish(): onAdsProviderAdFailed");
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC(this.EFEEHPNJIGL, 0f);
		}
		ApplicationFocusManager.Restore();
		this.RefreshAdUnits();
		this.MGABAKDDOIE = "";
		this.HAFPANAODGH = "";
		this.EFEEHPNJIGL = "";
		this.NDMPCCGECML = 0;
		yield break;
	}

	// Token: 0x06000E95 RID: 3733 RVA: 0x00069134 File Offset: 0x00067334
	private void HKELFCJCJHK()
	{
		if (AdsManagerLP.IKLAPGJDMNA == this)
		{
			if (this.NKECCKCDLBL != null)
			{
				this.NKECCKCDLBL.DestroyAd();
			}
			AdsManagerLP.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x06000E96 RID: 3734 RVA: 0x000695F0 File Offset: 0x000677F0
	private void MHODKPJECAB()
	{
		DPGJIJGOCIC.NFIDPOMCNLP("XXX");
		this.NKECCKCDLBL = new LevelPlayRewardedAd(IPEBDNGCDBJ.GMJIJHKCLHK, null);
		this.NKECCKCDLBL.OnAdLoadFailed += this.NHNGHDNOLLP;
		this.NKECCKCDLBL.OnAdDisplayed += this.AOOENGGJIDD;
		this.NKECCKCDLBL.OnAdDisplayFailed += this.DLDEHECEGBD;
		this.NKECCKCDLBL.OnAdRewarded += this.BFLDGLAJOAH;
		this.NKECCKCDLBL.OnAdClosed += this.GONEAPCNONP;
		this.IGNCGFDLIMD();
	}

	// Token: 0x06000E97 RID: 3735 RVA: 0x00069694 File Offset: 0x00067894
	public void JOCLPAJBJOJ(string MOGFACOEMBE, string IOHMBPHDJIC, string PBMIJOGPGHJ)
	{
		if (this.EABNFONAMGM && this.NKECCKCDLBL != null)
		{
			DPGJIJGOCIC.CMGOAFDBAOH("emailSubscribe");
			this.NDMPCCGECML = 0;
			this.MGABAKDDOIE = MOGFACOEMBE;
			this.HAFPANAODGH = IOHMBPHDJIC;
			this.EFEEHPNJIGL = PBMIJOGPGHJ;
			AudioListener.pause = true;
			ApplicationFocusManager.Deactivate();
			this.NKECCKCDLBL.ShowAd(null);
		}
	}

	// Token: 0x06000E98 RID: 3736 RVA: 0x00003E52 File Offset: 0x00002052
	public void KBFAFGNMKMO(string MOGFACOEMBE, string IOHMBPHDJIC, string PBMIJOGPGHJ)
	{
	}

	// Token: 0x06000E99 RID: 3737 RVA: 0x000696F0 File Offset: 0x000678F0
	public void NOFHIKCIKLP(string MOGFACOEMBE, string IOHMBPHDJIC, string PBMIJOGPGHJ)
	{
		if (this.EABNFONAMGM && this.NKECCKCDLBL != null)
		{
			DPGJIJGOCIC.NFIDPOMCNLP("〉");
			this.NDMPCCGECML = 1;
			this.MGABAKDDOIE = MOGFACOEMBE;
			this.HAFPANAODGH = IOHMBPHDJIC;
			this.EFEEHPNJIGL = PBMIJOGPGHJ;
			AudioListener.pause = false;
			ApplicationFocusManager.Deactivate();
			this.NKECCKCDLBL.ShowAd(null);
		}
	}

	// Token: 0x06000E9A RID: 3738 RVA: 0x0006974C File Offset: 0x0006794C
	public static AdsManagerLP AININGBPKNC()
	{
		if (!AdsManagerLP.IKLAPGJDMNA)
		{
			AdsManagerLP.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(AdsManagerLP)) as AdsManagerLP);
			if (!AdsManagerLP.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("ok");
			}
		}
		return AdsManagerLP.IKLAPGJDMNA;
	}

	// Token: 0x06000E9B RID: 3739 RVA: 0x0006979C File Offset: 0x0006799C
	private void INICHGHBPPK()
	{
		DPGJIJGOCIC.CMGOAFDBAOH("cardsvolchancesmsgtitle");
		this.NKECCKCDLBL = new LevelPlayRewardedAd(IPEBDNGCDBJ.GMJIJHKCLHK, null);
		this.NKECCKCDLBL.OnAdLoadFailed += this.OBMALPCGLGF;
		this.NKECCKCDLBL.OnAdDisplayed += this.FIFDLLCBHFL;
		this.NKECCKCDLBL.OnAdDisplayFailed += this.JKBJEOHAOJF;
		this.NKECCKCDLBL.OnAdRewarded += this.KLLPFJDAFBJ;
		this.NKECCKCDLBL.OnAdClosed += this.EPLAMKNLHLM;
		this.GIJFEAFMDML();
	}

	// Token: 0x06000E9C RID: 3740 RVA: 0x0006983D File Offset: 0x00067A3D
	private void NHNGHDNOLLP(LevelPlayAdError GCFILGFLALC)
	{
		DPGJIJGOCIC.ANOPFDLPKGC("assetbundleliveoffercontent");
	}

	// Token: 0x06000E9D RID: 3741 RVA: 0x00069849 File Offset: 0x00067A49
	private void CFHOENABIMF(LevelPlayAdInfo OLEHBMFCNJP, LevelPlayAdError GCFILGFLALC)
	{
		DPGJIJGOCIC.ANOPFDLPKGC("rt");
		base.StartCoroutine(this.OPBKPGECPLH(OLEHBMFCNJP));
	}

	// Token: 0x06000E9E RID: 3742 RVA: 0x00069863 File Offset: 0x00067A63
	private void BBNAHOAEAOC(bool IBELFEBCBMK)
	{
		if (IBELFEBCBMK && !this.FLJNHHAPOHP && AudioListener.pause)
		{
			DPGJIJGOCIC.NFIDPOMCNLP("ChapterSnapshotsItem.GetLastChapterSnapshotRestoreDesc(): null");
			AudioListener.pause = false;
		}
	}

	// Token: 0x06000E9F RID: 3743 RVA: 0x000693E3 File Offset: 0x000675E3
	private IEnumerator FOCGPKDOIBM()
	{
		while (!AppTrackingTransparency.CanStartIDFADependantSDKs())
		{
			yield return new WaitForEndOfFrame();
		}
		DPGJIJGOCIC.NFIDPOMCNLP("AdsManagerLP: InitializeDelayed() called");
		LevelPlay.OnInitSuccess += this.GLAOBLJFAFP;
		LevelPlay.OnInitFailed += this.BMAJNNPBMCJ;
		LevelPlay.Init(IPEBDNGCDBJ.OBLILOEHDNC, null);
		yield break;
	}

	// Token: 0x06000EA0 RID: 3744 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public bool DEGINHKBOOK()
	{
		return false;
	}

	// Token: 0x06000EA1 RID: 3745 RVA: 0x00069887 File Offset: 0x00067A87
	private void OHANPLEKDFI(LevelPlayConfiguration HEMCDIDKEPA)
	{
		DPGJIJGOCIC.NFIDPOMCNLP("Critical error, could not load asset bundle:");
		this.EABNFONAMGM = true;
		this.GFDKBBCMBCO();
	}

	// Token: 0x06000EA2 RID: 3746 RVA: 0x000698A0 File Offset: 0x00067AA0
	public void MPJJOGLANMF()
	{
		if (this.NKECCKCDLBL != null && !this.NKECCKCDLBL.IsAdReady())
		{
			DPGJIJGOCIC.CMGOAFDBAOH("language");
			this.NKECCKCDLBL.LoadAd();
		}
	}

	// Token: 0x06000EA3 RID: 3747 RVA: 0x00069279 File Offset: 0x00067479
	private IEnumerator FEHHNHACGCM(LevelPlayAdInfo OLEHBMFCNJP)
	{
		AdsManagerLP.NLHLHJNCLNO nlhlhjnclno = new AdsManagerLP.NLHLHJNCLNO(1);
		nlhlhjnclno.<>4__this = this;
		nlhlhjnclno.adInfo = OLEHBMFCNJP;
		return nlhlhjnclno;
	}

	// Token: 0x06000EA4 RID: 3748 RVA: 0x000698CC File Offset: 0x00067ACC
	private void HNFDOIGEBDN(LevelPlayConfiguration HEMCDIDKEPA)
	{
		DPGJIJGOCIC.CMGOAFDBAOH("seasoncomplete");
		this.EABNFONAMGM = false;
		this.MHODKPJECAB();
	}

	// Token: 0x06000EA5 RID: 3749 RVA: 0x000698E8 File Offset: 0x00067AE8
	public static AdsManagerLP OHCOHPNEOEG()
	{
		if (!AdsManagerLP.IKLAPGJDMNA)
		{
			AdsManagerLP.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(AdsManagerLP)) as AdsManagerLP);
			if (!AdsManagerLP.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("hacomp1");
			}
		}
		return AdsManagerLP.IKLAPGJDMNA;
	}

	// Token: 0x06000EA6 RID: 3750 RVA: 0x00069938 File Offset: 0x00067B38
	private void GFDKBBCMBCO()
	{
		DPGJIJGOCIC.NFIDPOMCNLP("OnPopupStoryRestartManagerRestartStory0");
		this.NKECCKCDLBL = new LevelPlayRewardedAd(IPEBDNGCDBJ.GMJIJHKCLHK, null);
		this.NKECCKCDLBL.OnAdLoadFailed += this.KDGNFFDKNJI;
		this.NKECCKCDLBL.OnAdDisplayed += this.AOOENGGJIDD;
		this.NKECCKCDLBL.OnAdDisplayFailed += this.IPDMBFHNMLK;
		this.NKECCKCDLBL.OnAdRewarded += this.HDAJBOMGFAI;
		this.NKECCKCDLBL.OnAdClosed += this.BHNLKJAEOOJ;
		this.RefreshAdUnits();
	}

	// Token: 0x06000EA7 RID: 3751 RVA: 0x000699DC File Offset: 0x00067BDC
	public void IAOKMIGGFGD(string MOGFACOEMBE, string IOHMBPHDJIC, string PBMIJOGPGHJ)
	{
		if (this.EABNFONAMGM && this.NKECCKCDLBL != null)
		{
			DPGJIJGOCIC.CMGOAFDBAOH("digitalglitchovr_1");
			this.NDMPCCGECML = 0;
			this.MGABAKDDOIE = MOGFACOEMBE;
			this.HAFPANAODGH = IOHMBPHDJIC;
			this.EFEEHPNJIGL = PBMIJOGPGHJ;
			AudioListener.pause = true;
			ApplicationFocusManager.HIFHNIPJFNE();
			this.NKECCKCDLBL.ShowAd(null);
		}
	}

	// Token: 0x06000EA8 RID: 3752 RVA: 0x00069A36 File Offset: 0x00067C36
	public void JOOBEBIBDGO()
	{
		if (KHPGPLAMAIN.PNJMABLIHKL())
		{
			base.StartCoroutine(this.CHKAMJMGGFH());
		}
	}

	// Token: 0x06000EA9 RID: 3753 RVA: 0x00069125 File Offset: 0x00067325
	private IEnumerator FFGMNLCLKBG()
	{
		AdsManagerLP.NFOCPPBLEMI nfocppblemi = new AdsManagerLP.NFOCPPBLEMI(1);
		nfocppblemi.<>4__this = this;
		return nfocppblemi;
	}

	// Token: 0x06000EAA RID: 3754 RVA: 0x00069A4C File Offset: 0x00067C4C
	public void EKMLLBJFGOO(string MOGFACOEMBE, string IOHMBPHDJIC, string PBMIJOGPGHJ)
	{
		if (this.EABNFONAMGM && this.NKECCKCDLBL != null)
		{
			DPGJIJGOCIC.NFIDPOMCNLP("OnAllCollectableCardsDownloadFailedLobby");
			this.NDMPCCGECML = 0;
			this.MGABAKDDOIE = MOGFACOEMBE;
			this.HAFPANAODGH = IOHMBPHDJIC;
			this.EFEEHPNJIGL = PBMIJOGPGHJ;
			AudioListener.pause = true;
			ApplicationFocusManager.BNMKAAKCLEA();
			this.NKECCKCDLBL.ShowAd(null);
		}
	}

	// Token: 0x06000EAB RID: 3755 RVA: 0x000693D6 File Offset: 0x000675D6
	private void KBGANABGEMK()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06000EAC RID: 3756 RVA: 0x00069AA6 File Offset: 0x00067CA6
	private void DLDEHECEGBD(LevelPlayAdInfo OLEHBMFCNJP, LevelPlayAdError GCFILGFLALC)
	{
		DPGJIJGOCIC.ANOPFDLPKGC("OnStoryInterfaceHeaderAvatarClick");
		base.StartCoroutine(this.DFNKLJFJFCI(OLEHBMFCNJP));
	}

	// Token: 0x1700002F RID: 47
	// (get) Token: 0x06000EAD RID: 3757 RVA: 0x00069AC0 File Offset: 0x00067CC0
	public static AdsManagerLP EHBBFMCILPC
	{
		get
		{
			if (!AdsManagerLP.IKLAPGJDMNA)
			{
				AdsManagerLP.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(AdsManagerLP)) as AdsManagerLP);
				if (!AdsManagerLP.IKLAPGJDMNA)
				{
					DPGJIJGOCIC.ANOPFDLPKGC("AdsManagerLP: There needs to be one active AdsManagerLP script on a GameObject in your scene.");
				}
			}
			return AdsManagerLP.IKLAPGJDMNA;
		}
	}

	// Token: 0x06000EAE RID: 3758 RVA: 0x00069B0D File Offset: 0x00067D0D
	private void LKHLIFIFJFN(LevelPlayAdInfo OLEHBMFCNJP)
	{
		DPGJIJGOCIC.CMGOAFDBAOH("varCondition");
		this.FLJNHHAPOHP = false;
		AudioListener.pause = false;
	}

	// Token: 0x06000EAF RID: 3759 RVA: 0x00069B26 File Offset: 0x00067D26
	private void GFGFCCJGCGK(LevelPlayAdInfo OLEHBMFCNJP, LevelPlayAdError GCFILGFLALC)
	{
		DPGJIJGOCIC.ANOPFDLPKGC("XXX");
		base.StartCoroutine(this.DFNKLJFJFCI(OLEHBMFCNJP));
	}

	// Token: 0x06000EB0 RID: 3760 RVA: 0x00069B40 File Offset: 0x00067D40
	public static AdsManagerLP OOGPALHPNGM()
	{
		if (!AdsManagerLP.IKLAPGJDMNA)
		{
			AdsManagerLP.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(AdsManagerLP)) as AdsManagerLP);
			if (!AdsManagerLP.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("p");
			}
		}
		return AdsManagerLP.IKLAPGJDMNA;
	}

	// Token: 0x06000EB1 RID: 3761 RVA: 0x00069B8D File Offset: 0x00067D8D
	public void EGMNIHKPEFF()
	{
		if (KHPGPLAMAIN.JPFALCGBPBF())
		{
			base.StartCoroutine(this.AJBDJHEFLLM());
		}
	}

	// Token: 0x06000EB2 RID: 3762 RVA: 0x00069BA3 File Offset: 0x00067DA3
	private void BFLDGLAJOAH(LevelPlayAdInfo OLEHBMFCNJP, LevelPlayReward AJOEAFELLHO)
	{
		DPGJIJGOCIC.NFIDPOMCNLP("OnSettingsPopupCloseAndNeedToRestartGame2");
		this.NDMPCCGECML = 0;
	}

	// Token: 0x06000EB3 RID: 3763 RVA: 0x00003E52 File Offset: 0x00002052
	public void ICGFPPHDHOB(string MOGFACOEMBE, string IOHMBPHDJIC, string PBMIJOGPGHJ)
	{
	}

	// Token: 0x06000EB5 RID: 3765 RVA: 0x00069BE0 File Offset: 0x00067DE0
	private void BMFCPBNGMJD()
	{
		DPGJIJGOCIC.CMGOAFDBAOH("anthologiestitle");
		this.NKECCKCDLBL = new LevelPlayRewardedAd(IPEBDNGCDBJ.GMJIJHKCLHK, null);
		this.NKECCKCDLBL.OnAdLoadFailed += this.NHNGHDNOLLP;
		this.NKECCKCDLBL.OnAdDisplayed += this.PJMDNAAGAPB;
		this.NKECCKCDLBL.OnAdDisplayFailed += this.GFGFCCJGCGK;
		this.NKECCKCDLBL.OnAdRewarded += this.BDPHKJJFHBB;
		this.NKECCKCDLBL.OnAdClosed += this.LANLBHCEGJI;
		this.LLCIFDPJAJF();
	}

	// Token: 0x06000EB6 RID: 3766 RVA: 0x00069C84 File Offset: 0x00067E84
	public void JHKLKPBJAMB(string MOGFACOEMBE, string IOHMBPHDJIC, string PBMIJOGPGHJ)
	{
		if (this.EABNFONAMGM && this.NKECCKCDLBL != null)
		{
			DPGJIJGOCIC.CMGOAFDBAOH("errortitle");
			this.NDMPCCGECML = 1;
			this.MGABAKDDOIE = MOGFACOEMBE;
			this.HAFPANAODGH = IOHMBPHDJIC;
			this.EFEEHPNJIGL = PBMIJOGPGHJ;
			AudioListener.pause = false;
			ApplicationFocusManager.Deactivate();
			this.NKECCKCDLBL.ShowAd(null);
		}
	}

	// Token: 0x06000EB7 RID: 3767 RVA: 0x00069CDE File Offset: 0x00067EDE
	private void DEFNDJOFING(LevelPlayAdInfo OLEHBMFCNJP, LevelPlayAdError GCFILGFLALC)
	{
		DPGJIJGOCIC.ANOPFDLPKGC("AdsManagerLP: Received RewardedVideoOnAdDisplayedFailedEvent");
		base.StartCoroutine(this.DFNKLJFJFCI(OLEHBMFCNJP));
	}

	// Token: 0x06000EB8 RID: 3768 RVA: 0x00069408 File Offset: 0x00067608
	public void LLCIFDPJAJF()
	{
		if (this.NKECCKCDLBL != null && !this.NKECCKCDLBL.IsAdReady())
		{
			DPGJIJGOCIC.NFIDPOMCNLP("");
			this.NKECCKCDLBL.LoadAd();
		}
	}

	// Token: 0x06000EB9 RID: 3769 RVA: 0x00069CF8 File Offset: 0x00067EF8
	private void BMAJNNPBMCJ(LevelPlayInitError GCFILGFLALC)
	{
		DPGJIJGOCIC.ANOPFDLPKGC("AdsManagerLP: Received SdkInitializationFailedEvent");
	}

	// Token: 0x06000EBA RID: 3770 RVA: 0x00069119 File Offset: 0x00067319
	private void JBDOFLMCHJC(LevelPlayInitError GCFILGFLALC)
	{
		DPGJIJGOCIC.ANOPFDLPKGC("");
	}

	// Token: 0x06000EBB RID: 3771 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public bool ILCKKAAGNMK()
	{
		return false;
	}

	// Token: 0x06000EBC RID: 3772 RVA: 0x00069D04 File Offset: 0x00067F04
	private void KBMKEIAFBLA(bool IBELFEBCBMK)
	{
		if (IBELFEBCBMK && !this.FLJNHHAPOHP && AudioListener.pause)
		{
			DPGJIJGOCIC.CMGOAFDBAOH("acliffbw22");
			AudioListener.pause = true;
		}
	}

	// Token: 0x06000EBD RID: 3773 RVA: 0x00069D28 File Offset: 0x00067F28
	public void AEHHFAAPEKD(string MOGFACOEMBE, string IOHMBPHDJIC, string PBMIJOGPGHJ)
	{
		if (this.EABNFONAMGM && this.NKECCKCDLBL != null)
		{
			DPGJIJGOCIC.NFIDPOMCNLP("extd");
			this.NDMPCCGECML = 0;
			this.MGABAKDDOIE = MOGFACOEMBE;
			this.HAFPANAODGH = IOHMBPHDJIC;
			this.EFEEHPNJIGL = PBMIJOGPGHJ;
			AudioListener.pause = true;
			ApplicationFocusManager.Deactivate();
			this.NKECCKCDLBL.ShowAd(null);
		}
	}

	// Token: 0x06000EBE RID: 3774 RVA: 0x00069D82 File Offset: 0x00067F82
	private void COBCOCMAMKH(bool IBELFEBCBMK)
	{
		if (IBELFEBCBMK && !this.FLJNHHAPOHP && AudioListener.pause)
		{
			DPGJIJGOCIC.NFIDPOMCNLP("OnStorySplashManagerAdsProviderAdSuccess");
			AudioListener.pause = true;
		}
	}

	// Token: 0x06000EBF RID: 3775 RVA: 0x00069DA6 File Offset: 0x00067FA6
	private void BHNLKJAEOOJ(LevelPlayAdInfo OLEHBMFCNJP)
	{
		DPGJIJGOCIC.NFIDPOMCNLP("AdsManagerLP: Received RewardedVideoOnAdClosedEvent");
		base.StartCoroutine(this.DFNKLJFJFCI(OLEHBMFCNJP));
	}

	// Token: 0x06000EC0 RID: 3776 RVA: 0x00069DC0 File Offset: 0x00067FC0
	private void DHFPCNFPEAP(LevelPlayAdInfo OLEHBMFCNJP)
	{
		DPGJIJGOCIC.CMGOAFDBAOH("retry");
		this.FLJNHHAPOHP = false;
		AudioListener.pause = true;
	}

	// Token: 0x06000EC1 RID: 3777 RVA: 0x00069B8D File Offset: 0x00067D8D
	public void KLFNFIFOHFD()
	{
		if (KHPGPLAMAIN.JPFALCGBPBF())
		{
			base.StartCoroutine(this.AJBDJHEFLLM());
		}
	}

	// Token: 0x06000EC2 RID: 3778 RVA: 0x00069279 File Offset: 0x00067479
	private IEnumerator MGMLJOICILB(LevelPlayAdInfo OLEHBMFCNJP)
	{
		AdsManagerLP.NLHLHJNCLNO nlhlhjnclno = new AdsManagerLP.NLHLHJNCLNO(1);
		nlhlhjnclno.<>4__this = this;
		nlhlhjnclno.adInfo = OLEHBMFCNJP;
		return nlhlhjnclno;
	}

	// Token: 0x06000EC3 RID: 3779 RVA: 0x000693F2 File Offset: 0x000675F2
	private IEnumerator MPFJCBLJMNN(LevelPlayAdInfo OLEHBMFCNJP)
	{
		this.FLJNHHAPOHP = false;
		AudioListener.pause = false;
		yield return new WaitForEndOfFrame();
		yield return new WaitForEndOfFrame();
		yield return new WaitForEndOfFrame();
		if (this.NDMPCCGECML == 1)
		{
			DPGJIJGOCIC.NFIDPOMCNLP("AdsManagerLP: DispatchEventsOnAdFinish(): onAdsProviderAdSuccess");
			Dictionary<string, object> cdmncpmidjp = new Dictionary<string, object>();
			if (OLEHBMFCNJP.AdNetwork.ToLowerInvariant().Contains("unity"))
			{
				AppsFlyerManagerBridge.EHBBFMCILPC.SendEvent("ad_watch_unity", cdmncpmidjp);
			}
			else if (OLEHBMFCNJP.AdNetwork.ToLowerInvariant().Contains("ironsource"))
			{
				AppsFlyerManagerBridge.EHBBFMCILPC.SendEvent("ad_watch_ironsource", cdmncpmidjp);
			}
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC(this.MGABAKDDOIE, 0f);
		}
		else
		{
			DPGJIJGOCIC.NFIDPOMCNLP("AdsManagerLP: DispatchEventsOnAdFinish(): onAdsProviderAdFailed");
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC(this.EFEEHPNJIGL, 0f);
		}
		ApplicationFocusManager.Restore();
		this.RefreshAdUnits();
		this.MGABAKDDOIE = "";
		this.HAFPANAODGH = "";
		this.EFEEHPNJIGL = "";
		this.NDMPCCGECML = 0;
		yield break;
	}

	// Token: 0x06000EC4 RID: 3780 RVA: 0x00069DDC File Offset: 0x00067FDC
	private void DNMJMCOFICG()
	{
		DPGJIJGOCIC.NFIDPOMCNLP("_Color");
		this.NKECCKCDLBL = new LevelPlayRewardedAd(IPEBDNGCDBJ.GMJIJHKCLHK, null);
		this.NKECCKCDLBL.OnAdLoadFailed += this.CBEDFAMDMKP;
		this.NKECCKCDLBL.OnAdDisplayed += this.DHFPCNFPEAP;
		this.NKECCKCDLBL.OnAdDisplayFailed += this.JKBJEOHAOJF;
		this.NKECCKCDLBL.OnAdRewarded += this.BFLDGLAJOAH;
		this.NKECCKCDLBL.OnAdClosed += this.NDLCJHFFEEO;
		this.IGNCGFDLIMD();
	}

	// Token: 0x06000EC5 RID: 3781 RVA: 0x000693D6 File Offset: 0x000675D6
	private void OGBHEBHMGGH()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06000EC6 RID: 3782 RVA: 0x00069E7D File Offset: 0x0006807D
	private void IDNMMKANDKL(bool IBELFEBCBMK)
	{
		if (IBELFEBCBMK && !this.FLJNHHAPOHP && AudioListener.pause)
		{
			DPGJIJGOCIC.CMGOAFDBAOH("timeoutwarning");
			AudioListener.pause = false;
		}
	}

	// Token: 0x06000EC7 RID: 3783 RVA: 0x00069EA1 File Offset: 0x000680A1
	private void KLLPFJDAFBJ(LevelPlayAdInfo OLEHBMFCNJP, LevelPlayReward AJOEAFELLHO)
	{
		DPGJIJGOCIC.NFIDPOMCNLP("errortitle");
		this.NDMPCCGECML = 1;
	}

	// Token: 0x06000EC8 RID: 3784 RVA: 0x00069EB4 File Offset: 0x000680B4
	private void GLAOBLJFAFP(LevelPlayConfiguration HEMCDIDKEPA)
	{
		DPGJIJGOCIC.NFIDPOMCNLP("AdsManagerLP: Received SdkInitializationCompletedEvent");
		this.EABNFONAMGM = true;
		this.KODEPHHHHAJ();
	}

	// Token: 0x06000EC9 RID: 3785 RVA: 0x00069125 File Offset: 0x00067325
	private IEnumerator EEGKGAIECLI()
	{
		AdsManagerLP.NFOCPPBLEMI nfocppblemi = new AdsManagerLP.NFOCPPBLEMI(1);
		nfocppblemi.<>4__this = this;
		return nfocppblemi;
	}

	// Token: 0x06000ECA RID: 3786 RVA: 0x00069ED0 File Offset: 0x000680D0
	private void HNCBPIMNFCA()
	{
		DPGJIJGOCIC.NFIDPOMCNLP("pmterror009");
		this.NKECCKCDLBL = new LevelPlayRewardedAd(IPEBDNGCDBJ.GMJIJHKCLHK, null);
		this.NKECCKCDLBL.OnAdLoadFailed += this.PJMDKPOPMDK;
		this.NKECCKCDLBL.OnAdDisplayed += this.AOOENGGJIDD;
		this.NKECCKCDLBL.OnAdDisplayFailed += this.CFHOENABIMF;
		this.NKECCKCDLBL.OnAdRewarded += this.HDAJBOMGFAI;
		this.NKECCKCDLBL.OnAdClosed += this.GONEAPCNONP;
		this.GIJFEAFMDML();
	}

	// Token: 0x06000ECB RID: 3787 RVA: 0x00069F71 File Offset: 0x00068171
	private void PPGPFBFHOEK(LevelPlayConfiguration HEMCDIDKEPA)
	{
		DPGJIJGOCIC.NFIDPOMCNLP("congratstitle");
		this.EABNFONAMGM = false;
		this.GFDKBBCMBCO();
	}

	// Token: 0x06000ECC RID: 3788 RVA: 0x00069F8A File Offset: 0x0006818A
	private void OBMALPCGLGF(LevelPlayAdError GCFILGFLALC)
	{
		DPGJIJGOCIC.ANOPFDLPKGC("socialdequeusp1gettitle");
	}

	// Token: 0x06000ECD RID: 3789 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public bool IsReadyNonRewarded()
	{
		return false;
	}

	// Token: 0x06000ECE RID: 3790 RVA: 0x00069F98 File Offset: 0x00068198
	private void CPAAOBBCAMB()
	{
		DPGJIJGOCIC.CMGOAFDBAOH("</i>");
		this.NKECCKCDLBL = new LevelPlayRewardedAd(IPEBDNGCDBJ.GMJIJHKCLHK, null);
		this.NKECCKCDLBL.OnAdLoadFailed += this.KDGNFFDKNJI;
		this.NKECCKCDLBL.OnAdDisplayed += this.FIFDLLCBHFL;
		this.NKECCKCDLBL.OnAdDisplayFailed += this.DEFNDJOFING;
		this.NKECCKCDLBL.OnAdRewarded += this.HDAJBOMGFAI;
		this.NKECCKCDLBL.OnAdClosed += this.LANLBHCEGJI;
		this.GIJFEAFMDML();
	}

	// Token: 0x06000ECF RID: 3791 RVA: 0x0006A039 File Offset: 0x00068239
	public void Start()
	{
		if (KHPGPLAMAIN.NGPOHAPMMAI())
		{
			base.StartCoroutine(this.FOCGPKDOIBM());
		}
	}

	// Token: 0x06000ED0 RID: 3792 RVA: 0x0006A050 File Offset: 0x00068250
	private void OHECGHOLIGO()
	{
		DPGJIJGOCIC.CMGOAFDBAOH("clthc");
		this.NKECCKCDLBL = new LevelPlayRewardedAd(IPEBDNGCDBJ.GMJIJHKCLHK, null);
		this.NKECCKCDLBL.OnAdLoadFailed += this.NHMJILHIJHK;
		this.NKECCKCDLBL.OnAdDisplayed += this.FIFDLLCBHFL;
		this.NKECCKCDLBL.OnAdDisplayFailed += this.CFHOENABIMF;
		this.NKECCKCDLBL.OnAdRewarded += this.MCJNABHEGJJ;
		this.NKECCKCDLBL.OnAdClosed += this.EPLAMKNLHLM;
		this.RefreshAdUnits();
	}

	// Token: 0x06000ED1 RID: 3793 RVA: 0x000693D6 File Offset: 0x000675D6
	private void ANPIDDAIALE()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06000ED2 RID: 3794 RVA: 0x0006A0F1 File Offset: 0x000682F1
	private void IPDMBFHNMLK(LevelPlayAdInfo OLEHBMFCNJP, LevelPlayAdError GCFILGFLALC)
	{
		DPGJIJGOCIC.ANOPFDLPKGC("Asset bundle assets destroyed:");
		base.StartCoroutine(this.MGMLJOICILB(OLEHBMFCNJP));
	}

	// Token: 0x06000ED3 RID: 3795 RVA: 0x0006A10B File Offset: 0x0006830B
	private void IENHHDGJEDO(LevelPlayAdInfo OLEHBMFCNJP, LevelPlayReward AJOEAFELLHO)
	{
		DPGJIJGOCIC.NFIDPOMCNLP("ok");
		this.NDMPCCGECML = 1;
	}

	// Token: 0x06000ED4 RID: 3796 RVA: 0x0006A120 File Offset: 0x00068320
	public void ShowAdRewarded(string MOGFACOEMBE, string IOHMBPHDJIC, string PBMIJOGPGHJ)
	{
		if (this.EABNFONAMGM && this.NKECCKCDLBL != null)
		{
			DPGJIJGOCIC.NFIDPOMCNLP("AdsManagerLP: ShowAdRewarded() called");
			this.NDMPCCGECML = 0;
			this.MGABAKDDOIE = MOGFACOEMBE;
			this.HAFPANAODGH = IOHMBPHDJIC;
			this.EFEEHPNJIGL = PBMIJOGPGHJ;
			AudioListener.pause = false;
			ApplicationFocusManager.Deactivate();
			this.NKECCKCDLBL.ShowAd(null);
		}
	}

	// Token: 0x06000ED5 RID: 3797 RVA: 0x0006A17C File Offset: 0x0006837C
	public void BNLMKBPAFFH(string MOGFACOEMBE, string IOHMBPHDJIC, string PBMIJOGPGHJ)
	{
		if (this.EABNFONAMGM && this.NKECCKCDLBL != null)
		{
			DPGJIJGOCIC.CMGOAFDBAOH("c");
			this.NDMPCCGECML = 0;
			this.MGABAKDDOIE = MOGFACOEMBE;
			this.HAFPANAODGH = IOHMBPHDJIC;
			this.EFEEHPNJIGL = PBMIJOGPGHJ;
			AudioListener.pause = true;
			ApplicationFocusManager.Deactivate();
			this.NKECCKCDLBL.ShowAd(null);
		}
	}

	// Token: 0x06000ED6 RID: 3798 RVA: 0x0006A1D8 File Offset: 0x000683D8
	public void AJDIHOLFGHB(string MOGFACOEMBE, string IOHMBPHDJIC, string PBMIJOGPGHJ)
	{
		if (this.EABNFONAMGM && this.NKECCKCDLBL != null)
		{
			DPGJIJGOCIC.NFIDPOMCNLP("p");
			this.NDMPCCGECML = 0;
			this.MGABAKDDOIE = MOGFACOEMBE;
			this.HAFPANAODGH = IOHMBPHDJIC;
			this.EFEEHPNJIGL = PBMIJOGPGHJ;
			AudioListener.pause = false;
			ApplicationFocusManager.Deactivate();
			this.NKECCKCDLBL.ShowAd(null);
		}
	}

	// Token: 0x06000ED7 RID: 3799 RVA: 0x0006A232 File Offset: 0x00068432
	private void CBEDFAMDMKP(LevelPlayAdError GCFILGFLALC)
	{
		DPGJIJGOCIC.ANOPFDLPKGC("OnNeedToActivateFocusItemCloseButton");
	}

	// Token: 0x06000ED8 RID: 3800 RVA: 0x0006A240 File Offset: 0x00068440
	public void DLNKFEJEDMI(string MOGFACOEMBE, string IOHMBPHDJIC, string PBMIJOGPGHJ)
	{
		if (this.EABNFONAMGM && this.NKECCKCDLBL != null)
		{
			DPGJIJGOCIC.NFIDPOMCNLP("GeneralBalance.SearchKeyFloat() - could not find key:");
			this.NDMPCCGECML = 1;
			this.MGABAKDDOIE = MOGFACOEMBE;
			this.HAFPANAODGH = IOHMBPHDJIC;
			this.EFEEHPNJIGL = PBMIJOGPGHJ;
			AudioListener.pause = true;
			ApplicationFocusManager.Deactivate();
			this.NKECCKCDLBL.ShowAd(null);
		}
	}

	// Token: 0x06000ED9 RID: 3801 RVA: 0x0006A29A File Offset: 0x0006849A
	private void PJMDNAAGAPB(LevelPlayAdInfo OLEHBMFCNJP)
	{
		DPGJIJGOCIC.NFIDPOMCNLP("AdsManagerLP: Received RewardedVideoOnAdDisplayedEvent");
		this.FLJNHHAPOHP = true;
		AudioListener.pause = true;
	}

	// Token: 0x06000EDA RID: 3802 RVA: 0x0006A2B4 File Offset: 0x000684B4
	public static AdsManagerLP NODMIFMPFLK()
	{
		if (!AdsManagerLP.IKLAPGJDMNA)
		{
			AdsManagerLP.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(AdsManagerLP)) as AdsManagerLP);
			if (!AdsManagerLP.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("aind");
			}
		}
		return AdsManagerLP.IKLAPGJDMNA;
	}

	// Token: 0x06000EDB RID: 3803 RVA: 0x0006A304 File Offset: 0x00068504
	private void KCHNEIGDLHA()
	{
		DPGJIJGOCIC.NFIDPOMCNLP("</i>");
		this.NKECCKCDLBL = new LevelPlayRewardedAd(IPEBDNGCDBJ.GMJIJHKCLHK, null);
		this.NKECCKCDLBL.OnAdLoadFailed += this.NHNGHDNOLLP;
		this.NKECCKCDLBL.OnAdDisplayed += this.AOOENGGJIDD;
		this.NKECCKCDLBL.OnAdDisplayFailed += this.GFGFCCJGCGK;
		this.NKECCKCDLBL.OnAdRewarded += this.KLLPFJDAFBJ;
		this.NKECCKCDLBL.OnAdClosed += this.BHNLKJAEOOJ;
		this.MPJJOGLANMF();
	}

	// Token: 0x06000EDC RID: 3804 RVA: 0x000693F2 File Offset: 0x000675F2
	private IEnumerator DFNKLJFJFCI(LevelPlayAdInfo OLEHBMFCNJP)
	{
		this.FLJNHHAPOHP = false;
		AudioListener.pause = false;
		yield return new WaitForEndOfFrame();
		yield return new WaitForEndOfFrame();
		yield return new WaitForEndOfFrame();
		if (this.NDMPCCGECML == 1)
		{
			DPGJIJGOCIC.NFIDPOMCNLP("AdsManagerLP: DispatchEventsOnAdFinish(): onAdsProviderAdSuccess");
			Dictionary<string, object> cdmncpmidjp = new Dictionary<string, object>();
			if (OLEHBMFCNJP.AdNetwork.ToLowerInvariant().Contains("unity"))
			{
				AppsFlyerManagerBridge.EHBBFMCILPC.SendEvent("ad_watch_unity", cdmncpmidjp);
			}
			else if (OLEHBMFCNJP.AdNetwork.ToLowerInvariant().Contains("ironsource"))
			{
				AppsFlyerManagerBridge.EHBBFMCILPC.SendEvent("ad_watch_ironsource", cdmncpmidjp);
			}
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC(this.MGABAKDDOIE, 0f);
		}
		else
		{
			DPGJIJGOCIC.NFIDPOMCNLP("AdsManagerLP: DispatchEventsOnAdFinish(): onAdsProviderAdFailed");
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC(this.EFEEHPNJIGL, 0f);
		}
		ApplicationFocusManager.Restore();
		this.RefreshAdUnits();
		this.MGABAKDDOIE = "";
		this.HAFPANAODGH = "";
		this.EFEEHPNJIGL = "";
		this.NDMPCCGECML = 0;
		yield break;
	}

	// Token: 0x06000EDD RID: 3805 RVA: 0x00069134 File Offset: 0x00067334
	private void OnDestroy()
	{
		if (AdsManagerLP.IKLAPGJDMNA == this)
		{
			if (this.NKECCKCDLBL != null)
			{
				this.NKECCKCDLBL.DestroyAd();
			}
			AdsManagerLP.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x06000EDE RID: 3806 RVA: 0x0006A3A5 File Offset: 0x000685A5
	private void NDLCJHFFEEO(LevelPlayAdInfo OLEHBMFCNJP)
	{
		DPGJIJGOCIC.CMGOAFDBAOH("sk");
		base.StartCoroutine(this.OPBKPGECPLH(OLEHBMFCNJP));
	}

	// Token: 0x06000EDF RID: 3807 RVA: 0x00069125 File Offset: 0x00067325
	private IEnumerator AJBDJHEFLLM()
	{
		AdsManagerLP.NFOCPPBLEMI nfocppblemi = new AdsManagerLP.NFOCPPBLEMI(1);
		nfocppblemi.<>4__this = this;
		return nfocppblemi;
	}

	// Token: 0x06000EE0 RID: 3808 RVA: 0x0006A3C0 File Offset: 0x000685C0
	public void CNJOGFBJMKE(string MOGFACOEMBE, string IOHMBPHDJIC, string PBMIJOGPGHJ)
	{
		if (this.EABNFONAMGM && this.NKECCKCDLBL != null)
		{
			DPGJIJGOCIC.CMGOAFDBAOH("+");
			this.NDMPCCGECML = 0;
			this.MGABAKDDOIE = MOGFACOEMBE;
			this.HAFPANAODGH = IOHMBPHDJIC;
			this.EFEEHPNJIGL = PBMIJOGPGHJ;
			AudioListener.pause = true;
			ApplicationFocusManager.HIFHNIPJFNE();
			this.NKECCKCDLBL.ShowAd(null);
		}
	}

	// Token: 0x06000EE1 RID: 3809 RVA: 0x0006A41A File Offset: 0x0006861A
	private void BDPHKJJFHBB(LevelPlayAdInfo OLEHBMFCNJP, LevelPlayReward AJOEAFELLHO)
	{
		DPGJIJGOCIC.NFIDPOMCNLP("");
		this.NDMPCCGECML = 0;
	}

	// Token: 0x06000EE2 RID: 3810 RVA: 0x0006A42D File Offset: 0x0006862D
	private void IOGEFAPAIDM(LevelPlayAdInfo OLEHBMFCNJP)
	{
		DPGJIJGOCIC.NFIDPOMCNLP("PurchaseManagerSteam.ValidatePendingProducts(): Not initialized.");
		base.StartCoroutine(this.MGMLJOICILB(OLEHBMFCNJP));
	}

	// Token: 0x06000EE3 RID: 3811 RVA: 0x00069434 File Offset: 0x00067634
	public bool IsReadyRewarded()
	{
		return this.EABNFONAMGM && this.NKECCKCDLBL != null && this.NKECCKCDLBL.IsAdReady();
	}

	// Token: 0x06000EE4 RID: 3812 RVA: 0x0006A447 File Offset: 0x00068647
	private void HLNNLDOMECG(LevelPlayAdInfo OLEHBMFCNJP, LevelPlayAdError GCFILGFLALC)
	{
		DPGJIJGOCIC.ANOPFDLPKGC("rsl");
		base.StartCoroutine(this.ANHIKLNNLPK(OLEHBMFCNJP));
	}

	// Token: 0x06000EE5 RID: 3813 RVA: 0x0006A461 File Offset: 0x00068661
	private void NLMOEEADAHG(LevelPlayAdInfo OLEHBMFCNJP)
	{
		DPGJIJGOCIC.NFIDPOMCNLP("profilechars");
		base.StartCoroutine(this.MGMLJOICILB(OLEHBMFCNJP));
	}

	// Token: 0x06000EE6 RID: 3814 RVA: 0x0006A47C File Offset: 0x0006867C
	private void PDMFCFJGHEH()
	{
		DPGJIJGOCIC.NFIDPOMCNLP("Account.MarkAllStoriesAsSynced(): marking as unsynced backend anthology ");
		this.NKECCKCDLBL = new LevelPlayRewardedAd(IPEBDNGCDBJ.GMJIJHKCLHK, null);
		this.NKECCKCDLBL.OnAdLoadFailed += this.OBMALPCGLGF;
		this.NKECCKCDLBL.OnAdDisplayed += this.LKHLIFIFJFN;
		this.NKECCKCDLBL.OnAdDisplayFailed += this.GANODBFCANG;
		this.NKECCKCDLBL.OnAdRewarded += this.KLLPFJDAFBJ;
		this.NKECCKCDLBL.OnAdClosed += this.NDLCJHFFEEO;
		this.EAJEFHLPIHE();
	}

	// Token: 0x06000EE7 RID: 3815 RVA: 0x0006A51D File Offset: 0x0006871D
	private void AOOENGGJIDD(LevelPlayAdInfo OLEHBMFCNJP)
	{
		DPGJIJGOCIC.NFIDPOMCNLP("it");
		this.FLJNHHAPOHP = false;
		AudioListener.pause = true;
	}

	// Token: 0x06000EE8 RID: 3816 RVA: 0x000693F2 File Offset: 0x000675F2
	private IEnumerator OPBKPGECPLH(LevelPlayAdInfo OLEHBMFCNJP)
	{
		this.FLJNHHAPOHP = false;
		AudioListener.pause = false;
		yield return new WaitForEndOfFrame();
		yield return new WaitForEndOfFrame();
		yield return new WaitForEndOfFrame();
		if (this.NDMPCCGECML == 1)
		{
			DPGJIJGOCIC.NFIDPOMCNLP("AdsManagerLP: DispatchEventsOnAdFinish(): onAdsProviderAdSuccess");
			Dictionary<string, object> cdmncpmidjp = new Dictionary<string, object>();
			if (OLEHBMFCNJP.AdNetwork.ToLowerInvariant().Contains("unity"))
			{
				AppsFlyerManagerBridge.EHBBFMCILPC.SendEvent("ad_watch_unity", cdmncpmidjp);
			}
			else if (OLEHBMFCNJP.AdNetwork.ToLowerInvariant().Contains("ironsource"))
			{
				AppsFlyerManagerBridge.EHBBFMCILPC.SendEvent("ad_watch_ironsource", cdmncpmidjp);
			}
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC(this.MGABAKDDOIE, 0f);
		}
		else
		{
			DPGJIJGOCIC.NFIDPOMCNLP("AdsManagerLP: DispatchEventsOnAdFinish(): onAdsProviderAdFailed");
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC(this.EFEEHPNJIGL, 0f);
		}
		ApplicationFocusManager.Restore();
		this.RefreshAdUnits();
		this.MGABAKDDOIE = "";
		this.HAFPANAODGH = "";
		this.EFEEHPNJIGL = "";
		this.NDMPCCGECML = 0;
		yield break;
	}

	// Token: 0x06000EE9 RID: 3817 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public bool BEJDAHNKCKI()
	{
		return false;
	}

	// Token: 0x06000EEA RID: 3818 RVA: 0x00069577 File Offset: 0x00067777
	public void BPDHPMKCLNB()
	{
		if (KHPGPLAMAIN.JPFALCGBPBF())
		{
			base.StartCoroutine(this.CHKAMJMGGFH());
		}
	}

	// Token: 0x06000EEB RID: 3819 RVA: 0x0006A536 File Offset: 0x00068736
	private void LKAOGGENBIB(LevelPlayAdError GCFILGFLALC)
	{
		DPGJIJGOCIC.ANOPFDLPKGC("Starting parallel download:");
	}

	// Token: 0x0400051E RID: 1310
	private LevelPlayRewardedAd NKECCKCDLBL;

	// Token: 0x0400051F RID: 1311
	private bool EABNFONAMGM;

	// Token: 0x04000520 RID: 1312
	private static AdsManagerLP IKLAPGJDMNA;

	// Token: 0x04000521 RID: 1313
	private string MGABAKDDOIE = "";

	// Token: 0x04000522 RID: 1314
	private string HAFPANAODGH = "";

	// Token: 0x04000523 RID: 1315
	private string EFEEHPNJIGL = "";

	// Token: 0x04000524 RID: 1316
	private int NDMPCCGECML;

	// Token: 0x04000525 RID: 1317
	private bool FLJNHHAPOHP;
}
