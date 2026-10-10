using System;
using AppsFlyerSDK;
using UnityEngine;

// Token: 0x02000018 RID: 24
public class AppsFlyerObjectScript : MonoBehaviour, KIFIHJOKMID
{
	// Token: 0x060002B8 RID: 696 RVA: 0x000095F4 File Offset: 0x000077F4
	public void EFEPOKPFCGM(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("is_deferred", GCFILGFLALC);
	}

	// Token: 0x060002B9 RID: 697 RVA: 0x00009601 File Offset: 0x00007801
	public void DBFCDOFHBBJ(string HMCMJBKOIKA)
	{
		AppsFlyer.AFLog("deep_link_value", HMCMJBKOIKA);
		AppsFlyer.CallbackStringToDictionary(HMCMJBKOIKA);
	}

	// Token: 0x060002BA RID: 698 RVA: 0x00009615 File Offset: 0x00007815
	public void onConversionDataSuccess(string HMCMJBKOIKA)
	{
		AppsFlyer.AFLog("didReceiveConversionData", HMCMJBKOIKA);
		AppsFlyer.CallbackStringToDictionary(HMCMJBKOIKA);
	}

	// Token: 0x060002BB RID: 699 RVA: 0x00009629 File Offset: 0x00007829
	public void LNHOHILBLBP(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("null", GCFILGFLALC);
	}

	// Token: 0x060002BC RID: 700 RVA: 0x00009636 File Offset: 0x00007836
	public void JMONECLOMJP(string KKHKGOOKHMI)
	{
		AppsFlyer.AFLog("click_http_referrer", KKHKGOOKHMI);
		AppsFlyer.CallbackStringToDictionary(KKHKGOOKHMI);
	}

	// Token: 0x060002BD RID: 701 RVA: 0x00009615 File Offset: 0x00007815
	public void LHHEGPKJOCM(string KKHKGOOKHMI)
	{
		AppsFlyer.AFLog("didReceiveConversionData", KKHKGOOKHMI);
		AppsFlyer.CallbackStringToDictionary(KKHKGOOKHMI);
	}

	// Token: 0x060002BE RID: 702 RVA: 0x0000964A File Offset: 0x0000784A
	public void ANNOOHLCNDK(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("onAppOpenAttribution", GCFILGFLALC);
	}

	// Token: 0x060002BF RID: 703 RVA: 0x00009657 File Offset: 0x00007857
	public void DGJOBFGALCJ(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("parseRequestCallback", GCFILGFLALC);
	}

	// Token: 0x060002C0 RID: 704 RVA: 0x00009664 File Offset: 0x00007864
	public void onConversionDataFail(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("didReceiveConversionDataWithError", GCFILGFLALC);
	}

	// Token: 0x060002C1 RID: 705 RVA: 0x00009671 File Offset: 0x00007871
	public void DJEKLCECPKH(string KKHKGOOKHMI)
	{
		AppsFlyer.AFLog("af_sub4", KKHKGOOKHMI);
		AppsFlyer.CallbackStringToDictionary(KKHKGOOKHMI);
	}

	// Token: 0x060002C2 RID: 706 RVA: 0x00009685 File Offset: 0x00007885
	public void FMADGINAFCH(string KKHKGOOKHMI)
	{
		AppsFlyer.AFLog("", KKHKGOOKHMI);
		AppsFlyer.CallbackStringToDictionary(KKHKGOOKHMI);
	}

	// Token: 0x060002C3 RID: 707 RVA: 0x00009699 File Offset: 0x00007899
	private void BKNNEAAEGKF()
	{
		AppsFlyer.setIsDebug(this.isDebug);
		AppsFlyer.initSDK(this.devKey, this.appID, this.getConversionData ? this : null);
		AppsFlyer.startSDK();
	}

	// Token: 0x060002C4 RID: 708 RVA: 0x000021BB File Offset: 0x000003BB
	private void HJKLMIHPEOB()
	{
	}

	// Token: 0x060002C5 RID: 709 RVA: 0x000021BB File Offset: 0x000003BB
	private void CDGCBAKKPDI()
	{
	}

	// Token: 0x060002C6 RID: 710 RVA: 0x000096C8 File Offset: 0x000078C8
	public void BHNHKIFKFFA(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("af_sub4", GCFILGFLALC);
	}

	// Token: 0x060002C7 RID: 711 RVA: 0x000021BB File Offset: 0x000003BB
	private void PLLIOMMMOED()
	{
	}

	// Token: 0x060002C8 RID: 712 RVA: 0x00009601 File Offset: 0x00007801
	public void LBLFLPKCEDF(string KKHKGOOKHMI)
	{
		AppsFlyer.AFLog("deep_link_value", KKHKGOOKHMI);
		AppsFlyer.CallbackStringToDictionary(KKHKGOOKHMI);
	}

	// Token: 0x060002C9 RID: 713 RVA: 0x000096D5 File Offset: 0x000078D5
	public void IOOFNFDKLAH(string KKHKGOOKHMI)
	{
		AppsFlyer.AFLog("campaign_id", KKHKGOOKHMI);
		AppsFlyer.CallbackStringToDictionary(KKHKGOOKHMI);
	}

	// Token: 0x060002CA RID: 714 RVA: 0x000096E9 File Offset: 0x000078E9
	public void IFBECIDDFGG(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("", GCFILGFLALC);
	}

	// Token: 0x060002CB RID: 715 RVA: 0x000096F6 File Offset: 0x000078F6
	public void PEECJBKHEIC(string HMCMJBKOIKA)
	{
		AppsFlyer.AFLog("\\\"", HMCMJBKOIKA);
		AppsFlyer.CallbackStringToDictionary(HMCMJBKOIKA);
	}

	// Token: 0x060002CC RID: 716 RVA: 0x0000970A File Offset: 0x0000790A
	public void IGDDLAEHIPH(string KKHKGOOKHMI)
	{
		AppsFlyer.AFLog("true", KKHKGOOKHMI);
		AppsFlyer.CallbackStringToDictionary(KKHKGOOKHMI);
	}

	// Token: 0x060002CD RID: 717 RVA: 0x0000971E File Offset: 0x0000791E
	public void JGIKNMNCEEN(string KKHKGOOKHMI)
	{
		AppsFlyer.AFLog("af_sub1", KKHKGOOKHMI);
		AppsFlyer.CallbackStringToDictionary(KKHKGOOKHMI);
	}

	// Token: 0x060002CE RID: 718 RVA: 0x00009732 File Offset: 0x00007932
	public void IJPAPCNEJBL(string HMCMJBKOIKA)
	{
		AppsFlyer.AFLog("onAppOpenAttributionFailure", HMCMJBKOIKA);
		AppsFlyer.CallbackStringToDictionary(HMCMJBKOIKA);
	}

	// Token: 0x060002CF RID: 719 RVA: 0x00009746 File Offset: 0x00007946
	public void EJJOGPBBNFA(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("\\b", GCFILGFLALC);
	}

	// Token: 0x060002D0 RID: 720 RVA: 0x00009753 File Offset: 0x00007953
	public void OLJEKFCIBBN(string KKHKGOOKHMI)
	{
		AppsFlyer.AFLog("null", KKHKGOOKHMI);
		AppsFlyer.CallbackStringToDictionary(KKHKGOOKHMI);
	}

	// Token: 0x060002D1 RID: 721 RVA: 0x00009767 File Offset: 0x00007967
	private void GOCGNPBBCIO()
	{
		AppsFlyer.setIsDebug(this.isDebug);
		AppsFlyer.HBIKMPMCEFE(this.devKey, this.appID, this.getConversionData ? this : null);
		AppsFlyer.startSDK();
	}

	// Token: 0x060002D2 RID: 722 RVA: 0x000021BB File Offset: 0x000003BB
	private void GELCDPOJGLP()
	{
	}

	// Token: 0x060002D3 RID: 723 RVA: 0x00009699 File Offset: 0x00007899
	private void PHKAJIMNFNK()
	{
		AppsFlyer.setIsDebug(this.isDebug);
		AppsFlyer.initSDK(this.devKey, this.appID, this.getConversionData ? this : null);
		AppsFlyer.startSDK();
	}

	// Token: 0x060002D4 RID: 724 RVA: 0x00009796 File Offset: 0x00007996
	public void KHELCAJKGKI(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("false", GCFILGFLALC);
	}

	// Token: 0x060002D5 RID: 725 RVA: 0x000021BB File Offset: 0x000003BB
	private void HBCBNLMJPEO()
	{
	}

	// Token: 0x060002D6 RID: 726 RVA: 0x000097A3 File Offset: 0x000079A3
	public void AIIHGCDCMOK(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("AppsFlyer_Unity_v{0} {1} called with {2}", GCFILGFLALC);
	}

	// Token: 0x060002D7 RID: 727 RVA: 0x000097B0 File Offset: 0x000079B0
	public void EMHPHGBCEKL(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("DeepLinkEventsArgs.isDeferred", GCFILGFLALC);
	}

	// Token: 0x060002D8 RID: 728 RVA: 0x000097BD File Offset: 0x000079BD
	public void KMMBBNLOFPE(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("af_sub1", GCFILGFLALC);
	}

	// Token: 0x060002D9 RID: 729 RVA: 0x000097CA File Offset: 0x000079CA
	public void FDKMFMOLPEP(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("R", GCFILGFLALC);
	}

	// Token: 0x060002DA RID: 730 RVA: 0x000021BB File Offset: 0x000003BB
	private void OFEFHGNPCPE()
	{
	}

	// Token: 0x060002DB RID: 731 RVA: 0x000021BB File Offset: 0x000003BB
	private void EFAGOEOLNID()
	{
	}

	// Token: 0x060002DC RID: 732 RVA: 0x0000970A File Offset: 0x0000790A
	public void FMEBDFIBMMK(string KKHKGOOKHMI)
	{
		AppsFlyer.AFLog("true", KKHKGOOKHMI);
		AppsFlyer.CallbackStringToDictionary(KKHKGOOKHMI);
	}

	// Token: 0x060002DD RID: 733 RVA: 0x000097D7 File Offset: 0x000079D7
	public void MFIBCCAPMOC(string HMCMJBKOIKA)
	{
		AppsFlyer.AFLog("\\f", HMCMJBKOIKA);
		AppsFlyer.CallbackStringToDictionary(HMCMJBKOIKA);
	}

	// Token: 0x060002DE RID: 734 RVA: 0x0000970A File Offset: 0x0000790A
	public void ABIKMMDDOFN(string KKHKGOOKHMI)
	{
		AppsFlyer.AFLog("true", KKHKGOOKHMI);
		AppsFlyer.CallbackStringToDictionary(KKHKGOOKHMI);
	}

	// Token: 0x060002DF RID: 735 RVA: 0x000021BB File Offset: 0x000003BB
	private void EBKJPEHJLDE()
	{
	}

	// Token: 0x060002E0 RID: 736 RVA: 0x000096E9 File Offset: 0x000078E9
	public void AGPJDGJKJMN(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("", GCFILGFLALC);
	}

	// Token: 0x060002E1 RID: 737 RVA: 0x00009699 File Offset: 0x00007899
	private void BLEFIJPAJMJ()
	{
		AppsFlyer.setIsDebug(this.isDebug);
		AppsFlyer.initSDK(this.devKey, this.appID, this.getConversionData ? this : null);
		AppsFlyer.startSDK();
	}

	// Token: 0x060002E2 RID: 738 RVA: 0x00009629 File Offset: 0x00007829
	public void ODOAEKGBINC(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("null", GCFILGFLALC);
	}

	// Token: 0x060002E3 RID: 739 RVA: 0x000097A3 File Offset: 0x000079A3
	public void JKBDAHKOPEP(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("AppsFlyer_Unity_v{0} {1} called with {2}", GCFILGFLALC);
	}

	// Token: 0x060002E4 RID: 740 RVA: 0x00009753 File Offset: 0x00007953
	public void FNIDCLFJCFP(string HMCMJBKOIKA)
	{
		AppsFlyer.AFLog("null", HMCMJBKOIKA);
		AppsFlyer.CallbackStringToDictionary(HMCMJBKOIKA);
	}

	// Token: 0x060002E5 RID: 741 RVA: 0x000021BB File Offset: 0x000003BB
	private void OLLAKHEPFBN()
	{
	}

	// Token: 0x060002E6 RID: 742 RVA: 0x000021BB File Offset: 0x000003BB
	private void GKGJIGJCPFK()
	{
	}

	// Token: 0x060002E7 RID: 743 RVA: 0x000095F4 File Offset: 0x000077F4
	public void AKJHOPKAIOP(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("is_deferred", GCFILGFLALC);
	}

	// Token: 0x060002E8 RID: 744 RVA: 0x000021BB File Offset: 0x000003BB
	private void GAGKLKHJGPO()
	{
	}

	// Token: 0x060002E9 RID: 745 RVA: 0x00009732 File Offset: 0x00007932
	public void GEDCMNBKOPI(string HMCMJBKOIKA)
	{
		AppsFlyer.AFLog("onAppOpenAttributionFailure", HMCMJBKOIKA);
		AppsFlyer.CallbackStringToDictionary(HMCMJBKOIKA);
	}

	// Token: 0x060002EA RID: 746 RVA: 0x000097EB File Offset: 0x000079EB
	public void IJCPLODGKBH(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("campaign", GCFILGFLALC);
	}

	// Token: 0x060002EB RID: 747 RVA: 0x000097F8 File Offset: 0x000079F8
	public void JCHKOELINLN(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("{}[],:\"", GCFILGFLALC);
	}

	// Token: 0x060002EC RID: 748 RVA: 0x00009767 File Offset: 0x00007967
	private void LMPBLJPPCKO()
	{
		AppsFlyer.setIsDebug(this.isDebug);
		AppsFlyer.HBIKMPMCEFE(this.devKey, this.appID, this.getConversionData ? this : null);
		AppsFlyer.startSDK();
	}

	// Token: 0x060002ED RID: 749 RVA: 0x00009805 File Offset: 0x00007A05
	public void CHNJBAKDONK(string KKHKGOOKHMI)
	{
		AppsFlyer.AFLog("{0} Exception caught.", KKHKGOOKHMI);
		AppsFlyer.CallbackStringToDictionary(KKHKGOOKHMI);
	}

	// Token: 0x060002EE RID: 750 RVA: 0x00009767 File Offset: 0x00007967
	private void JIJOFPBPBFP()
	{
		AppsFlyer.setIsDebug(this.isDebug);
		AppsFlyer.HBIKMPMCEFE(this.devKey, this.appID, this.getConversionData ? this : null);
		AppsFlyer.startSDK();
	}

	// Token: 0x060002EF RID: 751 RVA: 0x00009819 File Offset: 0x00007A19
	public void FGMMFHHKIJO(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("\\t", GCFILGFLALC);
	}

	// Token: 0x060002F0 RID: 752 RVA: 0x00009826 File Offset: 0x00007A26
	public void NMLPBNCEBPO(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("\\r", GCFILGFLALC);
	}

	// Token: 0x060002F1 RID: 753 RVA: 0x00009629 File Offset: 0x00007829
	public void COLLPGBOIFH(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("null", GCFILGFLALC);
	}

	// Token: 0x060002F2 RID: 754 RVA: 0x00009833 File Offset: 0x00007A33
	public void BGFKCBOMHAG(string KKHKGOOKHMI)
	{
		AppsFlyer.AFLog("onAppOpenAttribution", KKHKGOOKHMI);
		AppsFlyer.CallbackStringToDictionary(KKHKGOOKHMI);
	}

	// Token: 0x060002F3 RID: 755 RVA: 0x00009699 File Offset: 0x00007899
	private void GKMBPHPJAAP()
	{
		AppsFlyer.setIsDebug(this.isDebug);
		AppsFlyer.initSDK(this.devKey, this.appID, this.getConversionData ? this : null);
		AppsFlyer.startSDK();
	}

	// Token: 0x060002F4 RID: 756 RVA: 0x00009847 File Offset: 0x00007A47
	public void AODHHMDJDLO(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("media_source", GCFILGFLALC);
	}

	// Token: 0x060002F5 RID: 757 RVA: 0x000021BB File Offset: 0x000003BB
	private void CEIDMENJBNK()
	{
	}

	// Token: 0x060002F7 RID: 759 RVA: 0x00009854 File Offset: 0x00007A54
	public void PGDKODEKMJM(string HMCMJBKOIKA)
	{
		AppsFlyer.AFLog("\\u", HMCMJBKOIKA);
		AppsFlyer.CallbackStringToDictionary(HMCMJBKOIKA);
	}

	// Token: 0x060002F8 RID: 760 RVA: 0x00009868 File Offset: 0x00007A68
	public void CKGMGAKMGHF(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("true", GCFILGFLALC);
	}

	// Token: 0x060002F9 RID: 761 RVA: 0x00009875 File Offset: 0x00007A75
	public void AGNPENDFAMG(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("campaign_id", GCFILGFLALC);
	}

	// Token: 0x060002FA RID: 762 RVA: 0x00009882 File Offset: 0x00007A82
	public void CHLNNPKMEHO(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("af_sub2", GCFILGFLALC);
	}

	// Token: 0x060002FB RID: 763 RVA: 0x000021BB File Offset: 0x000003BB
	private void DDNDCPJPBHL()
	{
	}

	// Token: 0x060002FC RID: 764 RVA: 0x0000988F File Offset: 0x00007A8F
	public void NDGEJNLELOP(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("errorDescription", GCFILGFLALC);
	}

	// Token: 0x060002FD RID: 765 RVA: 0x00009699 File Offset: 0x00007899
	private void GKFJEFNCPHG()
	{
		AppsFlyer.setIsDebug(this.isDebug);
		AppsFlyer.initSDK(this.devKey, this.appID, this.getConversionData ? this : null);
		AppsFlyer.startSDK();
	}

	// Token: 0x060002FE RID: 766 RVA: 0x00009767 File Offset: 0x00007967
	private void PKMPOFOOGFK()
	{
		AppsFlyer.setIsDebug(this.isDebug);
		AppsFlyer.HBIKMPMCEFE(this.devKey, this.appID, this.getConversionData ? this : null);
		AppsFlyer.startSDK();
	}

	// Token: 0x060002FF RID: 767 RVA: 0x0000989C File Offset: 0x00007A9C
	public void EIPEHHMFEKO(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("statusCode", GCFILGFLALC);
	}

	// Token: 0x06000300 RID: 768 RVA: 0x000098A9 File Offset: 0x00007AA9
	public void IFGOFMPKIEL(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("deep_link_value", GCFILGFLALC);
	}

	// Token: 0x06000301 RID: 769 RVA: 0x00009685 File Offset: 0x00007885
	public void LGCOOMOMFFJ(string KKHKGOOKHMI)
	{
		AppsFlyer.AFLog("", KKHKGOOKHMI);
		AppsFlyer.CallbackStringToDictionary(KKHKGOOKHMI);
	}

	// Token: 0x06000302 RID: 770 RVA: 0x000021BB File Offset: 0x000003BB
	private void FDECKMDNEKO()
	{
	}

	// Token: 0x06000303 RID: 771 RVA: 0x00009699 File Offset: 0x00007899
	private void PAMMAEGAIDP()
	{
		AppsFlyer.setIsDebug(this.isDebug);
		AppsFlyer.initSDK(this.devKey, this.appID, this.getConversionData ? this : null);
		AppsFlyer.startSDK();
	}

	// Token: 0x06000304 RID: 772 RVA: 0x000021BB File Offset: 0x000003BB
	private void Update()
	{
	}

	// Token: 0x06000305 RID: 773 RVA: 0x00009699 File Offset: 0x00007899
	private void BHDHJLIBHCJ()
	{
		AppsFlyer.setIsDebug(this.isDebug);
		AppsFlyer.initSDK(this.devKey, this.appID, this.getConversionData ? this : null);
		AppsFlyer.startSDK();
	}

	// Token: 0x06000306 RID: 774 RVA: 0x000098B6 File Offset: 0x00007AB6
	public void DLNPHGJFJMK(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("\\\\", GCFILGFLALC);
	}

	// Token: 0x06000307 RID: 775 RVA: 0x000021BB File Offset: 0x000003BB
	private void DAEPNJGNGBA()
	{
	}

	// Token: 0x06000308 RID: 776 RVA: 0x000096C8 File Offset: 0x000078C8
	public void GJJMOFPACFO(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("af_sub4", GCFILGFLALC);
	}

	// Token: 0x06000309 RID: 777 RVA: 0x000097CA File Offset: 0x000079CA
	public void IPAGPDGNLFL(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("R", GCFILGFLALC);
	}

	// Token: 0x0600030A RID: 778 RVA: 0x00009767 File Offset: 0x00007967
	private void LLDCFHGMAML()
	{
		AppsFlyer.setIsDebug(this.isDebug);
		AppsFlyer.HBIKMPMCEFE(this.devKey, this.appID, this.getConversionData ? this : null);
		AppsFlyer.startSDK();
	}

	// Token: 0x0600030B RID: 779 RVA: 0x000098C3 File Offset: 0x00007AC3
	public void PNLEJIFBMLL(string KKHKGOOKHMI)
	{
		AppsFlyer.AFLog("didReceiveConversionDataWithError", KKHKGOOKHMI);
		AppsFlyer.CallbackStringToDictionary(KKHKGOOKHMI);
	}

	// Token: 0x0600030C RID: 780 RVA: 0x00009833 File Offset: 0x00007A33
	public void onAppOpenAttribution(string KKHKGOOKHMI)
	{
		AppsFlyer.AFLog("onAppOpenAttribution", KKHKGOOKHMI);
		AppsFlyer.CallbackStringToDictionary(KKHKGOOKHMI);
	}

	// Token: 0x0600030D RID: 781 RVA: 0x000021BB File Offset: 0x000003BB
	private void PPBJHNMGAHH()
	{
	}

	// Token: 0x0600030E RID: 782 RVA: 0x00009601 File Offset: 0x00007801
	public void BPALOLMEECP(string HMCMJBKOIKA)
	{
		AppsFlyer.AFLog("deep_link_value", HMCMJBKOIKA);
		AppsFlyer.CallbackStringToDictionary(HMCMJBKOIKA);
	}

	// Token: 0x0600030F RID: 783 RVA: 0x00009833 File Offset: 0x00007A33
	public void PHFPIGCDCAI(string KKHKGOOKHMI)
	{
		AppsFlyer.AFLog("onAppOpenAttribution", KKHKGOOKHMI);
		AppsFlyer.CallbackStringToDictionary(KKHKGOOKHMI);
	}

	// Token: 0x06000310 RID: 784 RVA: 0x00009767 File Offset: 0x00007967
	private void BNDPGAANPGK()
	{
		AppsFlyer.setIsDebug(this.isDebug);
		AppsFlyer.HBIKMPMCEFE(this.devKey, this.appID, this.getConversionData ? this : null);
		AppsFlyer.startSDK();
	}

	// Token: 0x06000311 RID: 785 RVA: 0x000095F4 File Offset: 0x000077F4
	public void AFBCJCNEOPA(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("is_deferred", GCFILGFLALC);
	}

	// Token: 0x06000312 RID: 786 RVA: 0x00009699 File Offset: 0x00007899
	private void EJDMNAABBNN()
	{
		AppsFlyer.setIsDebug(this.isDebug);
		AppsFlyer.initSDK(this.devKey, this.appID, this.getConversionData ? this : null);
		AppsFlyer.startSDK();
	}

	// Token: 0x06000313 RID: 787 RVA: 0x00009699 File Offset: 0x00007899
	private void IMCHEPFNANC()
	{
		AppsFlyer.setIsDebug(this.isDebug);
		AppsFlyer.initSDK(this.devKey, this.appID, this.getConversionData ? this : null);
		AppsFlyer.startSDK();
	}

	// Token: 0x06000314 RID: 788 RVA: 0x000098D7 File Offset: 0x00007AD7
	public void onAppOpenAttributionFailure(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("onAppOpenAttributionFailure", GCFILGFLALC);
	}

	// Token: 0x06000315 RID: 789 RVA: 0x000098E4 File Offset: 0x00007AE4
	public void NHNBAKBODKD(string HMCMJBKOIKA)
	{
		AppsFlyer.AFLog("errorDescription", HMCMJBKOIKA);
		AppsFlyer.CallbackStringToDictionary(HMCMJBKOIKA);
	}

	// Token: 0x06000316 RID: 790 RVA: 0x000098F8 File Offset: 0x00007AF8
	public void BEOFAMAAJIG(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("{0} Exception caught.", GCFILGFLALC);
	}

	// Token: 0x06000317 RID: 791 RVA: 0x000021BB File Offset: 0x000003BB
	private void NJINDDEAIDA()
	{
	}

	// Token: 0x06000318 RID: 792 RVA: 0x00009868 File Offset: 0x00007A68
	public void EINMLHAMGDK(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("true", GCFILGFLALC);
	}

	// Token: 0x06000319 RID: 793 RVA: 0x000096E9 File Offset: 0x000078E9
	public void MILMBECJKNO(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("", GCFILGFLALC);
	}

	// Token: 0x0600031A RID: 794 RVA: 0x00009875 File Offset: 0x00007A75
	public void CCFNICJDGKL(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("campaign_id", GCFILGFLALC);
	}

	// Token: 0x0600031B RID: 795 RVA: 0x000021BB File Offset: 0x000003BB
	private void BKLLPIBAGGO()
	{
	}

	// Token: 0x0600031C RID: 796 RVA: 0x00009767 File Offset: 0x00007967
	private void OMNGHDNDLKP()
	{
		AppsFlyer.setIsDebug(this.isDebug);
		AppsFlyer.HBIKMPMCEFE(this.devKey, this.appID, this.getConversionData ? this : null);
		AppsFlyer.startSDK();
	}

	// Token: 0x0600031D RID: 797 RVA: 0x00009699 File Offset: 0x00007899
	private void AMLICNPKJNO()
	{
		AppsFlyer.setIsDebug(this.isDebug);
		AppsFlyer.initSDK(this.devKey, this.appID, this.getConversionData ? this : null);
		AppsFlyer.startSDK();
	}

	// Token: 0x0600031E RID: 798 RVA: 0x00009905 File Offset: 0x00007B05
	public void GLFFBCGDLNM(string HMCMJBKOIKA)
	{
		AppsFlyer.AFLog("false", HMCMJBKOIKA);
		AppsFlyer.CallbackStringToDictionary(HMCMJBKOIKA);
	}

	// Token: 0x0600031F RID: 799 RVA: 0x00009919 File Offset: 0x00007B19
	public void BHLKOINHFHK(string KKHKGOOKHMI)
	{
		AppsFlyer.AFLog("\\r", KKHKGOOKHMI);
		AppsFlyer.CallbackStringToDictionary(KKHKGOOKHMI);
	}

	// Token: 0x06000320 RID: 800 RVA: 0x00009847 File Offset: 0x00007A47
	public void FLINEPLNLOD(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("media_source", GCFILGFLALC);
	}

	// Token: 0x06000321 RID: 801 RVA: 0x00009919 File Offset: 0x00007B19
	public void JFIAMBGFKDP(string HMCMJBKOIKA)
	{
		AppsFlyer.AFLog("\\r", HMCMJBKOIKA);
		AppsFlyer.CallbackStringToDictionary(HMCMJBKOIKA);
	}

	// Token: 0x06000322 RID: 802 RVA: 0x000096E9 File Offset: 0x000078E9
	public void IJKOBINOAFC(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("", GCFILGFLALC);
	}

	// Token: 0x06000323 RID: 803 RVA: 0x00009767 File Offset: 0x00007967
	private void JMCIGCLPJCA()
	{
		AppsFlyer.setIsDebug(this.isDebug);
		AppsFlyer.HBIKMPMCEFE(this.devKey, this.appID, this.getConversionData ? this : null);
		AppsFlyer.startSDK();
	}

	// Token: 0x06000324 RID: 804 RVA: 0x0000992D File Offset: 0x00007B2D
	public void LHLKFEGMDHE(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("\\u", GCFILGFLALC);
	}

	// Token: 0x06000325 RID: 805 RVA: 0x00009671 File Offset: 0x00007871
	public void NMMCIDGCBIL(string KKHKGOOKHMI)
	{
		AppsFlyer.AFLog("af_sub4", KKHKGOOKHMI);
		AppsFlyer.CallbackStringToDictionary(KKHKGOOKHMI);
	}

	// Token: 0x06000326 RID: 806 RVA: 0x00009767 File Offset: 0x00007967
	private void FDFMDEOMJBH()
	{
		AppsFlyer.setIsDebug(this.isDebug);
		AppsFlyer.HBIKMPMCEFE(this.devKey, this.appID, this.getConversionData ? this : null);
		AppsFlyer.startSDK();
	}

	// Token: 0x06000327 RID: 807 RVA: 0x00009699 File Offset: 0x00007899
	private void ILLKGPEICMI()
	{
		AppsFlyer.setIsDebug(this.isDebug);
		AppsFlyer.initSDK(this.devKey, this.appID, this.getConversionData ? this : null);
		AppsFlyer.startSDK();
	}

	// Token: 0x06000328 RID: 808 RVA: 0x00009767 File Offset: 0x00007967
	private void KGMBFKBNDPJ()
	{
		AppsFlyer.setIsDebug(this.isDebug);
		AppsFlyer.HBIKMPMCEFE(this.devKey, this.appID, this.getConversionData ? this : null);
		AppsFlyer.startSDK();
	}

	// Token: 0x06000329 RID: 809 RVA: 0x0000993A File Offset: 0x00007B3A
	public void KOFLIPNEIKN(string HMCMJBKOIKA)
	{
		AppsFlyer.AFLog("af_sub2", HMCMJBKOIKA);
		AppsFlyer.CallbackStringToDictionary(HMCMJBKOIKA);
	}

	// Token: 0x0600032A RID: 810 RVA: 0x000021BB File Offset: 0x000003BB
	private void FIJDKGJEPGC()
	{
	}

	// Token: 0x0600032B RID: 811 RVA: 0x000098B6 File Offset: 0x00007AB6
	public void DDIADJPCHJI(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("\\\\", GCFILGFLALC);
	}

	// Token: 0x0600032C RID: 812 RVA: 0x0000970A File Offset: 0x0000790A
	public void CIIDFDCNDCK(string HMCMJBKOIKA)
	{
		AppsFlyer.AFLog("true", HMCMJBKOIKA);
		AppsFlyer.CallbackStringToDictionary(HMCMJBKOIKA);
	}

	// Token: 0x0600032D RID: 813 RVA: 0x00009767 File Offset: 0x00007967
	private void CEDGALPCOLA()
	{
		AppsFlyer.setIsDebug(this.isDebug);
		AppsFlyer.HBIKMPMCEFE(this.devKey, this.appID, this.getConversionData ? this : null);
		AppsFlyer.startSDK();
	}

	// Token: 0x0600032E RID: 814 RVA: 0x00009699 File Offset: 0x00007899
	private void DEGAMINFFMK()
	{
		AppsFlyer.setIsDebug(this.isDebug);
		AppsFlyer.initSDK(this.devKey, this.appID, this.getConversionData ? this : null);
		AppsFlyer.startSDK();
	}

	// Token: 0x0600032F RID: 815 RVA: 0x00009875 File Offset: 0x00007A75
	public void GFBDAGBKBNO(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("campaign_id", GCFILGFLALC);
	}

	// Token: 0x06000330 RID: 816 RVA: 0x000021BB File Offset: 0x000003BB
	private void KODGAJHJLLH()
	{
	}

	// Token: 0x06000331 RID: 817 RVA: 0x00009699 File Offset: 0x00007899
	private void Start()
	{
		AppsFlyer.setIsDebug(this.isDebug);
		AppsFlyer.initSDK(this.devKey, this.appID, this.getConversionData ? this : null);
		AppsFlyer.startSDK();
	}

	// Token: 0x06000332 RID: 818 RVA: 0x0000994E File Offset: 0x00007B4E
	public void BJEEBGKKLLJ(string KKHKGOOKHMI)
	{
		AppsFlyer.AFLog("af_sub5", KKHKGOOKHMI);
		AppsFlyer.CallbackStringToDictionary(KKHKGOOKHMI);
	}

	// Token: 0x06000333 RID: 819 RVA: 0x00009699 File Offset: 0x00007899
	private void PABLFIJDFAD()
	{
		AppsFlyer.setIsDebug(this.isDebug);
		AppsFlyer.initSDK(this.devKey, this.appID, this.getConversionData ? this : null);
		AppsFlyer.startSDK();
	}

	// Token: 0x06000334 RID: 820 RVA: 0x00009699 File Offset: 0x00007899
	private void BDMGHFPMOAG()
	{
		AppsFlyer.setIsDebug(this.isDebug);
		AppsFlyer.initSDK(this.devKey, this.appID, this.getConversionData ? this : null);
		AppsFlyer.startSDK();
	}

	// Token: 0x06000335 RID: 821 RVA: 0x000021BB File Offset: 0x000003BB
	private void LIODPEHCJPG()
	{
	}

	// Token: 0x06000336 RID: 822 RVA: 0x000098E4 File Offset: 0x00007AE4
	public void CGJIOCBKFPH(string KKHKGOOKHMI)
	{
		AppsFlyer.AFLog("errorDescription", KKHKGOOKHMI);
		AppsFlyer.CallbackStringToDictionary(KKHKGOOKHMI);
	}

	// Token: 0x06000337 RID: 823 RVA: 0x00009699 File Offset: 0x00007899
	private void CDGGIMPDMMA()
	{
		AppsFlyer.setIsDebug(this.isDebug);
		AppsFlyer.initSDK(this.devKey, this.appID, this.getConversionData ? this : null);
		AppsFlyer.startSDK();
	}

	// Token: 0x06000338 RID: 824 RVA: 0x000021BB File Offset: 0x000003BB
	private void JMIEGJKLIJA()
	{
	}

	// Token: 0x06000339 RID: 825 RVA: 0x00009767 File Offset: 0x00007967
	private void FEIHEOJPNAK()
	{
		AppsFlyer.setIsDebug(this.isDebug);
		AppsFlyer.HBIKMPMCEFE(this.devKey, this.appID, this.getConversionData ? this : null);
		AppsFlyer.startSDK();
	}

	// Token: 0x0600033A RID: 826 RVA: 0x00009767 File Offset: 0x00007967
	private void DHDEDOICCHC()
	{
		AppsFlyer.setIsDebug(this.isDebug);
		AppsFlyer.HBIKMPMCEFE(this.devKey, this.appID, this.getConversionData ? this : null);
		AppsFlyer.startSDK();
	}

	// Token: 0x0600033B RID: 827 RVA: 0x000021BB File Offset: 0x000003BB
	private void PAPNIONKJAP()
	{
	}

	// Token: 0x0600033C RID: 828 RVA: 0x00009826 File Offset: 0x00007A26
	public void JKPGMIEMOCN(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("\\r", GCFILGFLALC);
	}

	// Token: 0x0600033D RID: 829 RVA: 0x000098F8 File Offset: 0x00007AF8
	public void HFEJAMGDJBE(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("{0} Exception caught.", GCFILGFLALC);
	}

	// Token: 0x0600033E RID: 830 RVA: 0x000095F4 File Offset: 0x000077F4
	public void NLJEKBFMLFG(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("is_deferred", GCFILGFLALC);
	}

	// Token: 0x0600033F RID: 831 RVA: 0x00009962 File Offset: 0x00007B62
	public void DJAJNHOGKGB(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("\\f", GCFILGFLALC);
	}

	// Token: 0x06000340 RID: 832 RVA: 0x000098E4 File Offset: 0x00007AE4
	public void HKCANMIBGBP(string KKHKGOOKHMI)
	{
		AppsFlyer.AFLog("errorDescription", KKHKGOOKHMI);
		AppsFlyer.CallbackStringToDictionary(KKHKGOOKHMI);
	}

	// Token: 0x06000341 RID: 833 RVA: 0x0000996F File Offset: 0x00007B6F
	public void JPKJBLPDMPL(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("click_http_referrer", GCFILGFLALC);
	}

	// Token: 0x06000342 RID: 834 RVA: 0x0000997C File Offset: 0x00007B7C
	public void DAADHAEHODJ(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("\\n", GCFILGFLALC);
	}

	// Token: 0x06000343 RID: 835 RVA: 0x00009664 File Offset: 0x00007864
	public void NLAJGLPABGK(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("didReceiveConversionDataWithError", GCFILGFLALC);
	}

	// Token: 0x06000344 RID: 836 RVA: 0x000097A3 File Offset: 0x000079A3
	public void OHHPDLEBCFJ(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("AppsFlyer_Unity_v{0} {1} called with {2}", GCFILGFLALC);
	}

	// Token: 0x06000345 RID: 837 RVA: 0x000021BB File Offset: 0x000003BB
	private void FGPENJNMMLB()
	{
	}

	// Token: 0x06000346 RID: 838 RVA: 0x00009868 File Offset: 0x00007A68
	public void OBBBEMHLAHE(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("true", GCFILGFLALC);
	}

	// Token: 0x06000347 RID: 839 RVA: 0x00009753 File Offset: 0x00007953
	public void GMBIBAAOMDD(string KKHKGOOKHMI)
	{
		AppsFlyer.AFLog("null", KKHKGOOKHMI);
		AppsFlyer.CallbackStringToDictionary(KKHKGOOKHMI);
	}

	// Token: 0x06000348 RID: 840 RVA: 0x000098E4 File Offset: 0x00007AE4
	public void JLFBMAKIGPF(string HMCMJBKOIKA)
	{
		AppsFlyer.AFLog("errorDescription", HMCMJBKOIKA);
		AppsFlyer.CallbackStringToDictionary(HMCMJBKOIKA);
	}

	// Token: 0x06000349 RID: 841 RVA: 0x000021BB File Offset: 0x000003BB
	private void JKAIDMIIHHB()
	{
	}

	// Token: 0x0600034A RID: 842 RVA: 0x00009989 File Offset: 0x00007B89
	public void NPFHNHGNDFI(string HMCMJBKOIKA)
	{
		AppsFlyer.AFLog("parseRequestCallback", HMCMJBKOIKA);
		AppsFlyer.CallbackStringToDictionary(HMCMJBKOIKA);
	}

	// Token: 0x0600034B RID: 843 RVA: 0x000097CA File Offset: 0x000079CA
	public void PDONHECEKNF(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("R", GCFILGFLALC);
	}

	// Token: 0x0600034C RID: 844 RVA: 0x00009699 File Offset: 0x00007899
	private void DEOBBAHAMLD()
	{
		AppsFlyer.setIsDebug(this.isDebug);
		AppsFlyer.initSDK(this.devKey, this.appID, this.getConversionData ? this : null);
		AppsFlyer.startSDK();
	}

	// Token: 0x0600034D RID: 845 RVA: 0x000021BB File Offset: 0x000003BB
	private void GKJGAJOMNKD()
	{
	}

	// Token: 0x0600034E RID: 846 RVA: 0x000021BB File Offset: 0x000003BB
	private void KAKAPJFGDIF()
	{
	}

	// Token: 0x0600034F RID: 847 RVA: 0x00009868 File Offset: 0x00007A68
	public void AODKJNFCKBC(string GCFILGFLALC)
	{
		AppsFlyer.AFLog("true", GCFILGFLALC);
	}

	// Token: 0x06000350 RID: 848 RVA: 0x0000999D File Offset: 0x00007B9D
	public void GEDNAHEOHBL(string KKHKGOOKHMI)
	{
		AppsFlyer.AFLog("\\b", KKHKGOOKHMI);
		AppsFlyer.CallbackStringToDictionary(KKHKGOOKHMI);
	}

	// Token: 0x06000351 RID: 849 RVA: 0x00009699 File Offset: 0x00007899
	private void PMKKOENBNOM()
	{
		AppsFlyer.setIsDebug(this.isDebug);
		AppsFlyer.initSDK(this.devKey, this.appID, this.getConversionData ? this : null);
		AppsFlyer.startSDK();
	}

	// Token: 0x06000352 RID: 850 RVA: 0x00009699 File Offset: 0x00007899
	private void OPGODKBEGAK()
	{
		AppsFlyer.setIsDebug(this.isDebug);
		AppsFlyer.initSDK(this.devKey, this.appID, this.getConversionData ? this : null);
		AppsFlyer.startSDK();
	}

	// Token: 0x06000353 RID: 851 RVA: 0x000099B1 File Offset: 0x00007BB1
	public void KMBFFBIDLEB(string KKHKGOOKHMI)
	{
		AppsFlyer.AFLog("DeepLinkEventsArgs.isDeferred", KKHKGOOKHMI);
		AppsFlyer.CallbackStringToDictionary(KKHKGOOKHMI);
	}

	// Token: 0x04000073 RID: 115
	public string devKey;

	// Token: 0x04000074 RID: 116
	public string appID;

	// Token: 0x04000075 RID: 117
	public string UWPAppID;

	// Token: 0x04000076 RID: 118
	public string macOSAppID;

	// Token: 0x04000077 RID: 119
	public bool isDebug;

	// Token: 0x04000078 RID: 120
	public bool getConversionData;
}
