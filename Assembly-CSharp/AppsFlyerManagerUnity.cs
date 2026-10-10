using System;
using System.Collections;
using System.Collections.Generic;
using AppsFlyerSDK;
using UnityEngine;

// Token: 0x02000493 RID: 1171
public class AppsFlyerManagerUnity : MonoBehaviour, KIFIHJOKMID
{
	// Token: 0x06008E04 RID: 36356 RVA: 0x003ECDD6 File Offset: 0x003EAFD6
	public void IFGOFMPKIEL(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("continue", GCFILGFLALC);
	}

	// Token: 0x06008E05 RID: 36357 RVA: 0x003ECDE3 File Offset: 0x003EAFE3
	public void ENOIGHPJGEH(string KKHKGOOKHMI)
	{
		AppsFlyer.AFLog("", KKHKGOOKHMI);
		AppsFlyer.CallbackStringToDictionary(KKHKGOOKHMI);
	}

	// Token: 0x06008E06 RID: 36358 RVA: 0x003ECDF7 File Offset: 0x003EAFF7
	public void DPLMGFONKAB(string DEFIPMJKIKA, Dictionary<string, object> CDMNCPMIDJP)
	{
		AppsFlyer.sendEvent(DEFIPMJKIKA, DPGJIJGOCIC.IJLCJPLGGFM(CDMNCPMIDJP));
	}

	// Token: 0x06008E07 RID: 36359 RVA: 0x003ECE05 File Offset: 0x003EB005
	private void BHDHJLIBHCJ()
	{
		base.StartCoroutine(this.FMFKJJAKBON());
	}

	// Token: 0x06008E08 RID: 36360 RVA: 0x003ECE14 File Offset: 0x003EB014
	public void MOLCNEPPDJD(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("XXX", GCFILGFLALC);
	}

	// Token: 0x06008E09 RID: 36361 RVA: 0x003ECDF7 File Offset: 0x003EAFF7
	public void KFPFFKGPBBL(string DEFIPMJKIKA, Dictionary<string, object> CDMNCPMIDJP)
	{
		AppsFlyer.sendEvent(DEFIPMJKIKA, DPGJIJGOCIC.IJLCJPLGGFM(CDMNCPMIDJP));
	}

	// Token: 0x06008E0A RID: 36362 RVA: 0x003ECE21 File Offset: 0x003EB021
	public void BOFBBCHHNOH(string DEFIPMJKIKA, Dictionary<string, object> CDMNCPMIDJP)
	{
		AppsFlyer.sendEvent(DEFIPMJKIKA, DPGJIJGOCIC.IILEEDNNPEN(CDMNCPMIDJP));
	}

	// Token: 0x06008E0B RID: 36363 RVA: 0x000693D6 File Offset: 0x000675D6
	private void APLBAENGMJH()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06008E0C RID: 36364 RVA: 0x003ECE2F File Offset: 0x003EB02F
	public void onConversionDataSuccess(string HMCMJBKOIKA)
	{
		AppsFlyer.AFLog("onConversionDataSuccess", HMCMJBKOIKA);
		AppsFlyer.CallbackStringToDictionary(HMCMJBKOIKA);
	}

	// Token: 0x06008E0D RID: 36365 RVA: 0x003ECDF7 File Offset: 0x003EAFF7
	public void CPJAMHFAKEH(string DEFIPMJKIKA, Dictionary<string, object> CDMNCPMIDJP)
	{
		AppsFlyer.sendEvent(DEFIPMJKIKA, DPGJIJGOCIC.IJLCJPLGGFM(CDMNCPMIDJP));
	}

	// Token: 0x06008E0E RID: 36366 RVA: 0x003ECE43 File Offset: 0x003EB043
	public void KPELKPNMIEF(string KKHKGOOKHMI)
	{
		AppsFlyer.AFLog("OnLoungePremiumChoicesHistoryException", KKHKGOOKHMI);
		AppsFlyer.CallbackStringToDictionary(KKHKGOOKHMI);
	}

	// Token: 0x06008E0F RID: 36367 RVA: 0x000693D6 File Offset: 0x000675D6
	private void KLGLFKMIAPP()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06008E10 RID: 36368 RVA: 0x000693D6 File Offset: 0x000675D6
	private void Awake()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06008E11 RID: 36369 RVA: 0x003ECE57 File Offset: 0x003EB057
	public void DCEHFOFGCGM(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("", GCFILGFLALC);
	}

	// Token: 0x06008E12 RID: 36370 RVA: 0x003ECE64 File Offset: 0x003EB064
	public void MLGBMKIGFKI(string HMCMJBKOIKA)
	{
		AppsFlyer.AFLog("StorySaveBody.HasAvatarComponentWardrobe(), unsupported wardrobe index:", HMCMJBKOIKA);
		AppsFlyer.CallbackStringToDictionary(HMCMJBKOIKA);
	}

	// Token: 0x06008E13 RID: 36371 RVA: 0x003ECE78 File Offset: 0x003EB078
	public void HCIICMGFDNL(string KKHKGOOKHMI)
	{
		AppsFlyer.AFLog("Cached, app42 reponse received, not dispatched:", KKHKGOOKHMI);
		AppsFlyer.CallbackStringToDictionary(KKHKGOOKHMI);
	}

	// Token: 0x06008E14 RID: 36372 RVA: 0x003ECE8C File Offset: 0x003EB08C
	public void onAppOpenAttribution(string KKHKGOOKHMI)
	{
		AppsFlyer.AFLog("onAppOpenAttribution", KKHKGOOKHMI);
		AppsFlyer.CallbackStringToDictionary(KKHKGOOKHMI);
	}

	// Token: 0x06008E15 RID: 36373 RVA: 0x003ECEA0 File Offset: 0x003EB0A0
	public void onAppOpenAttributionFailure(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("onAppOpenAttributionFailure", GCFILGFLALC);
	}

	// Token: 0x06008E16 RID: 36374 RVA: 0x003ECE21 File Offset: 0x003EB021
	public void SendEvent(string DEFIPMJKIKA, Dictionary<string, object> CDMNCPMIDJP)
	{
		AppsFlyer.sendEvent(DEFIPMJKIKA, DPGJIJGOCIC.IILEEDNNPEN(CDMNCPMIDJP));
	}

	// Token: 0x06008E17 RID: 36375 RVA: 0x000693D6 File Offset: 0x000675D6
	private void GNHDCIGPFOH()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06008E18 RID: 36376 RVA: 0x003ECDE3 File Offset: 0x003EAFE3
	public void IAJJHKMEJDB(string HMCMJBKOIKA)
	{
		AppsFlyer.AFLog("", HMCMJBKOIKA);
		AppsFlyer.CallbackStringToDictionary(HMCMJBKOIKA);
	}

	// Token: 0x06008E19 RID: 36377 RVA: 0x003ECEAD File Offset: 0x003EB0AD
	public void MLCMGOHJAKD(string KKHKGOOKHMI)
	{
		AppsFlyer.AFLog(" <i>", KKHKGOOKHMI);
		AppsFlyer.CallbackStringToDictionary(KKHKGOOKHMI);
	}

	// Token: 0x06008E1A RID: 36378 RVA: 0x003ECE21 File Offset: 0x003EB021
	public void GNKKPICOIOE(string DEFIPMJKIKA, Dictionary<string, object> CDMNCPMIDJP)
	{
		AppsFlyer.sendEvent(DEFIPMJKIKA, DPGJIJGOCIC.IILEEDNNPEN(CDMNCPMIDJP));
	}

	// Token: 0x06008E1B RID: 36379 RVA: 0x003ECDF7 File Offset: 0x003EAFF7
	public void MBHHCCOPFCM(string DEFIPMJKIKA, Dictionary<string, object> CDMNCPMIDJP)
	{
		AppsFlyer.sendEvent(DEFIPMJKIKA, DPGJIJGOCIC.IJLCJPLGGFM(CDMNCPMIDJP));
	}

	// Token: 0x06008E1D RID: 36381 RVA: 0x003ECEC1 File Offset: 0x003EB0C1
	public void PCJBOMBHEBP(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("\n\n", GCFILGFLALC);
	}

	// Token: 0x06008E1E RID: 36382 RVA: 0x000693D6 File Offset: 0x000675D6
	private void IABDONMCMPM()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06008E1F RID: 36383 RVA: 0x003ECECE File Offset: 0x003EB0CE
	private IEnumerator HKKOEGMKPMF()
	{
		return new AppsFlyerManagerUnity.IPHNILLKMIA(1);
	}

	// Token: 0x06008E20 RID: 36384 RVA: 0x003ECED6 File Offset: 0x003EB0D6
	public void EIPEHHMFEKO(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("FranchisesHub.Populate() - ", GCFILGFLALC);
	}

	// Token: 0x06008E21 RID: 36385 RVA: 0x000693D6 File Offset: 0x000675D6
	private void AMNBHDNALGO()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06008E22 RID: 36386 RVA: 0x003ECE21 File Offset: 0x003EB021
	public void GKEEOBBCJGN(string DEFIPMJKIKA, Dictionary<string, object> CDMNCPMIDJP)
	{
		AppsFlyer.sendEvent(DEFIPMJKIKA, DPGJIJGOCIC.IILEEDNNPEN(CDMNCPMIDJP));
	}

	// Token: 0x06008E23 RID: 36387 RVA: 0x003ECEE3 File Offset: 0x003EB0E3
	public void CIIDFDCNDCK(string HMCMJBKOIKA)
	{
		AppsFlyer.AFLog("itemstitle", HMCMJBKOIKA);
		AppsFlyer.CallbackStringToDictionary(HMCMJBKOIKA);
	}

	// Token: 0x06008E24 RID: 36388 RVA: 0x003ECEF7 File Offset: 0x003EB0F7
	private IEnumerator FMFKJJAKBON()
	{
		while (!AppTrackingTransparency.CanStartIDFADependantSDKs())
		{
			yield return new WaitForEndOfFrame();
		}
		AppsFlyer.setIsDebug(false);
		AppsFlyer.startSDK();
		yield break;
	}

	// Token: 0x06008E25 RID: 36389 RVA: 0x003ECEFF File Offset: 0x003EB0FF
	public void BNGIKIHALGI(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("errortitle", GCFILGFLALC);
	}

	// Token: 0x06008E26 RID: 36390 RVA: 0x003ECEF7 File Offset: 0x003EB0F7
	private IEnumerator FOCGPKDOIBM()
	{
		while (!AppTrackingTransparency.CanStartIDFADependantSDKs())
		{
			yield return new WaitForEndOfFrame();
		}
		AppsFlyer.setIsDebug(false);
		AppsFlyer.startSDK();
		yield break;
	}

	// Token: 0x06008E27 RID: 36391 RVA: 0x003ECE14 File Offset: 0x003EB014
	public void ECFHMLBOPDN(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("XXX", GCFILGFLALC);
	}

	// Token: 0x06008E28 RID: 36392 RVA: 0x000693D6 File Offset: 0x000675D6
	private void LBDIDHDKHGO()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06008E29 RID: 36393 RVA: 0x003ECF0C File Offset: 0x003EB10C
	public void FPFKKNDHHEM(string KKHKGOOKHMI)
	{
		AppsFlyer.AFLog("Sprites/Default", KKHKGOOKHMI);
		AppsFlyer.CallbackStringToDictionary(KKHKGOOKHMI);
	}

	// Token: 0x06008E2A RID: 36394 RVA: 0x003ECF20 File Offset: 0x003EB120
	private void Start()
	{
		base.StartCoroutine(this.FOCGPKDOIBM());
	}

	// Token: 0x06008E2B RID: 36395 RVA: 0x003ECF2F File Offset: 0x003EB12F
	public void IHCFFNFCLDL(string HMCMJBKOIKA)
	{
		AppsFlyer.AFLog("pmtusercancelled", HMCMJBKOIKA);
		AppsFlyer.CallbackStringToDictionary(HMCMJBKOIKA);
	}

	// Token: 0x06008E2C RID: 36396 RVA: 0x003ECE57 File Offset: 0x003EB057
	public void NDGEJNLELOP(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("", GCFILGFLALC);
	}

	// Token: 0x06008E2D RID: 36397 RVA: 0x003ECDF7 File Offset: 0x003EAFF7
	public void GMGNPEFFOIC(string DEFIPMJKIKA, Dictionary<string, object> CDMNCPMIDJP)
	{
		AppsFlyer.sendEvent(DEFIPMJKIKA, DPGJIJGOCIC.IJLCJPLGGFM(CDMNCPMIDJP));
	}

	// Token: 0x06008E2E RID: 36398 RVA: 0x003ECF43 File Offset: 0x003EB143
	public void PKFPODMNKAH(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("p", GCFILGFLALC);
	}

	// Token: 0x06008E2F RID: 36399 RVA: 0x003ECF50 File Offset: 0x003EB150
	public void GIEOJNADDHF(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("eval", GCFILGFLALC);
	}

	// Token: 0x06008E30 RID: 36400 RVA: 0x003ECF5D File Offset: 0x003EB15D
	public void HONGFBABJFO(string KKHKGOOKHMI)
	{
		AppsFlyer.AFLog("errortitle", KKHKGOOKHMI);
		AppsFlyer.CallbackStringToDictionary(KKHKGOOKHMI);
	}

	// Token: 0x06008E31 RID: 36401 RVA: 0x003ECF71 File Offset: 0x003EB171
	public void PAPGKDCKJFJ(string HMCMJBKOIKA)
	{
		AppsFlyer.AFLog("OnLoungeUnlockNpcSkinException", HMCMJBKOIKA);
		AppsFlyer.CallbackStringToDictionary(HMCMJBKOIKA);
	}

	// Token: 0x06008E32 RID: 36402 RVA: 0x003ECF85 File Offset: 0x003EB185
	public void OJICOJHANLN(string DEFIPMJKIKA, Dictionary<string, object> CDMNCPMIDJP)
	{
		AppsFlyer.sendEvent(DEFIPMJKIKA, DPGJIJGOCIC.JFLABHGABEI(CDMNCPMIDJP));
	}

	// Token: 0x06008E33 RID: 36403 RVA: 0x003ECF93 File Offset: 0x003EB193
	public void NIAFJCAEHKB(string KKHKGOOKHMI)
	{
		AppsFlyer.AFLog("YYY", KKHKGOOKHMI);
		AppsFlyer.CallbackStringToDictionary(KKHKGOOKHMI);
	}

	// Token: 0x06008E34 RID: 36404 RVA: 0x003ECFA7 File Offset: 0x003EB1A7
	public void onConversionDataFail(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("onConversionDataFail", GCFILGFLALC);
	}

	// Token: 0x06008E35 RID: 36405 RVA: 0x000693D6 File Offset: 0x000675D6
	private void LIBECOJEBKI()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}
}
