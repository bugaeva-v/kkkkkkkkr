using System;
using System.Collections.Generic;
using AFMiniJSON;
using UnityEngine;

namespace AppsFlyerSDK
{
	// Token: 0x02000003 RID: 3
	public class AppsFlyer : MonoBehaviour
	{
		// Token: 0x06000014 RID: 20 RVA: 0x00002050 File Offset: 0x00000250
		public static void subscribeForDeepLink()
		{
			if (AppsFlyer.instance != null)
			{
				AppsFlyer.instance.JLNHGAGODCD(AppsFlyer.CallBackObjectName);
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002068 File Offset: 0x00000268
		public static void setDisableNetworkData(bool FICBPGMDCHC)
		{
			if (AppsFlyer.instance != null && AppsFlyer.instance is GJFEGIKFFJF)
			{
				((GJFEGIKFFJF)AppsFlyer.instance).EKGKKOJKNLK(FICBPGMDCHC);
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0000208D File Offset: 0x0000028D
		public static bool isSDKStopped()
		{
			return AppsFlyer.instance != null && AppsFlyer.instance.KPNCKNCPEMO();
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000020A2 File Offset: 0x000002A2
		public static string getOutOfStore()
		{
			if (AppsFlyer.instance != null && AppsFlyer.instance is GJFEGIKFFJF)
			{
				return ((GJFEGIKFFJF)AppsFlyer.instance).FFJPFFFGGCG();
			}
			return string.Empty;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000020CC File Offset: 0x000002CC
		public static void GMOOKKLEMHI(bool KAKHOFAHDLA)
		{
			if (AppsFlyer.instance != null && AppsFlyer.instance is GJFEGIKFFJF)
			{
				((GJFEGIKFFJF)AppsFlyer.instance).KHMKPDPKFIJ(KAKHOFAHDLA);
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000020F1 File Offset: 0x000002F1
		public static void enableTCFDataCollection(bool BEKMLGADBDI)
		{
			if (AppsFlyer.instance != null)
			{
				AppsFlyer.instance.GGBJINIEHBD(BEKMLGADBDI);
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002105 File Offset: 0x00000305
		public static void setIsUpdate(bool GNGLEAJFMMM)
		{
			if (AppsFlyer.instance != null && AppsFlyer.instance is GJFEGIKFFJF)
			{
				((GJFEGIKFFJF)AppsFlyer.instance).GEPCJLKEINE(GNGLEAJFMMM);
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0000212A File Offset: 0x0000032A
		public static void CEKJLHHJMDG(string[] MGCNJCACPOO)
		{
			if (AppsFlyer.instance != null)
			{
				AppsFlyer.instance.ELMAFOKGGMN(MGCNJCACPOO);
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000213E File Offset: 0x0000033E
		public static void CDKDBEDFEFC()
		{
			if (AppsFlyer.instance != null && AppsFlyer.instance is GJFEGIKFFJF)
			{
				((GJFEGIKFFJF)AppsFlyer.instance).APEGIHDHGGB();
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002162 File Offset: 0x00000362
		public static void CBCDAMBHKKL(string GKCIFPHBHEP, string ICKHGADHPMJ, string JOBAGHGMDHC, string FILMADDCNED, Dictionary<string, string> EPONHPGGAOM, MonoBehaviour IACFDHCDEME)
		{
			if (AppsFlyer.instance != null && AppsFlyer.instance is ADBKMNBJNOI)
			{
				((ADBKMNBJNOI)AppsFlyer.instance).BCCGOLNKCJM(GKCIFPHBHEP, ICKHGADHPMJ, JOBAGHGMDHC, FILMADDCNED, EPONHPGGAOM, IACFDHCDEME);
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x0000218E File Offset: 0x0000038E
		public static string FIOPHNMJJNE()
		{
			if (AppsFlyer.instance != null)
			{
				return AppsFlyer.instance.ELNDMKFBKDC();
			}
			return string.Empty;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000021A7 File Offset: 0x000003A7
		public static void GKEFOBEKNDI(long DGEFFOIIMJP)
		{
			if (AppsFlyer.instance != null)
			{
				AppsFlyer.instance.ENCOKNKCDLD(DGEFFOIIMJP);
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000021BB File Offset: 0x000003BB
		public static void setSharingFilterForPartners(params string[] JDLICCDOOHP)
		{
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000021BD File Offset: 0x000003BD
		public static void setShouldCollectDeviceName(bool DJMGKMMEODK)
		{
			if (AppsFlyer.instance != null && AppsFlyer.instance is ADBKMNBJNOI)
			{
				((ADBKMNBJNOI)AppsFlyer.instance).FHCNEMGKKDO(DJMGKMMEODK);
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000021E2 File Offset: 0x000003E2
		public static void setUseUninstallSandbox(bool PKDJBPIKFFF)
		{
			if (AppsFlyer.instance != null && AppsFlyer.instance is ADBKMNBJNOI)
			{
				((ADBKMNBJNOI)AppsFlyer.instance).OPEBEBFPHLG(PKDJBPIKFFF);
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000221F File Offset: 0x0000041F
		public static void ONHBAHIMLPN(string NHHOKJJLNCL)
		{
			if (AppsFlyer.instance != null)
			{
				AppsFlyer.instance.FNANODNLIAE(NHHOKJJLNCL);
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002162 File Offset: 0x00000362
		public static void validateAndSendInAppPurchase(string GKCIFPHBHEP, string ICKHGADHPMJ, string JOBAGHGMDHC, string FILMADDCNED, Dictionary<string, string> EPONHPGGAOM, MonoBehaviour IACFDHCDEME)
		{
			if (AppsFlyer.instance != null && AppsFlyer.instance is ADBKMNBJNOI)
			{
				((ADBKMNBJNOI)AppsFlyer.instance).BCCGOLNKCJM(GKCIFPHBHEP, ICKHGADHPMJ, JOBAGHGMDHC, FILMADDCNED, EPONHPGGAOM, IACFDHCDEME);
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002233 File Offset: 0x00000433
		public static void validateAndSendInAppPurchase(AKGPINNLOHL BPBJMFKCOJG, Dictionary<string, string> JIJMIIANJGB, MonoBehaviour IACFDHCDEME)
		{
			if (AppsFlyer.instance != null && AppsFlyer.instance is ADBKMNBJNOI)
			{
				((ADBKMNBJNOI)AppsFlyer.instance).BCCGOLNKCJM(BPBJMFKCOJG, JIJMIIANJGB, IACFDHCDEME);
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x0000225A File Offset: 0x0000045A
		[Obsolete("Please use setSharingFilterForPartners api")]
		public static void setSharingFilterForAllPartners()
		{
			if (AppsFlyer.instance != null)
			{
				AppsFlyer.instance.CAFCCGMOCFG();
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000226D File Offset: 0x0000046D
		[Obsolete("Please use setSharingFilterForPartners api")]
		public static void setSharingFilter(params string[] JDLICCDOOHP)
		{
			if (AppsFlyer.instance != null)
			{
				AppsFlyer.instance.IPHHGAIFALB(JDLICCDOOHP);
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002281 File Offset: 0x00000481
		public static void CBKLGFPBDPL(string NCFIHMEHIOE, string JILHDLALFFI, Dictionary<string, string> LMCFPFALEEP, MonoBehaviour IACFDHCDEME)
		{
			if (AppsFlyer.instance != null)
			{
				AppsFlyer.instance.ICDGKKEPCMB(NCFIHMEHIOE, JILHDLALFFI, LMCFPFALEEP, IACFDHCDEME);
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002298 File Offset: 0x00000498
		public static void BBCBANMFNHE(string CKOOPLBEFEF)
		{
			if (AppsFlyer.instance != null && AppsFlyer.instance is GJFEGIKFFJF)
			{
				((GJFEGIKFFJF)AppsFlyer.instance).IMHHBNMBNOK(CKOOPLBEFEF);
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600002B RID: 43 RVA: 0x000022BD File Offset: 0x000004BD
		// (remove) Token: 0x0600006C RID: 108 RVA: 0x000027A5 File Offset: 0x000009A5
		public static event EventHandler EHPHMCCCGDL
		{
			add
			{
				AppsFlyer.IIHGKGLPKDC = (EventHandler)Delegate.Combine(AppsFlyer.IIHGKGLPKDC, value);
			}
			remove
			{
				AppsFlyer.IIHGKGLPKDC = (EventHandler)Delegate.Remove(AppsFlyer.IIHGKGLPKDC, value);
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000022D4 File Offset: 0x000004D4
		public static void LJLEOCALLPO(bool HLFIFKJELHD)
		{
			if (AppsFlyer.instance != null && AppsFlyer.instance is ADBKMNBJNOI)
			{
				((ADBKMNBJNOI)AppsFlyer.instance).LKEEPBHMCDO(HLFIFKJELHD);
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000022F9 File Offset: 0x000004F9
		public static void LJEFDIGMFCA(string OEMLCIBMFLG, string EKJMCPMPECM)
		{
			if (AppsFlyer.instance != null)
			{
				AppsFlyer.instance.NHALNOEEGKK(OEMLCIBMFLG, EKJMCPMPECM);
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0000213E File Offset: 0x0000033E
		public static void handlePushNotifications()
		{
			if (AppsFlyer.instance != null && AppsFlyer.instance is GJFEGIKFFJF)
			{
				((GJFEGIKFFJF)AppsFlyer.instance).APEGIHDHGGB();
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x0000230E File Offset: 0x0000050E
		public static void EOPIHEGDKEK(string DBHMNECMIAB)
		{
			if (AppsFlyer.instance != null)
			{
				AppsFlyer.instance.DIAIIACONOL(DBHMNECMIAB);
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002322 File Offset: 0x00000522
		public static void ANEPPAFBOKD(JHFNFEFBENE KNNJFAIOMJH)
		{
			if (AppsFlyer.instance != null)
			{
				AppsFlyer.instance.PDOHPGDBEHH(KNNJFAIOMJH);
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002336 File Offset: 0x00000536
		public static void setResolveDeepLinkURLs(params string[] BKGIBDLEDGE)
		{
			if (AppsFlyer.instance != null)
			{
				AppsFlyer.instance.JNPLPCGEGHJ(BKGIBDLEDGE);
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0000234A File Offset: 0x0000054A
		public static void waitForATTUserAuthorizationWithTimeoutInterval(int JCLAMHGPCIB)
		{
			if (AppsFlyer.instance != null && AppsFlyer.instance is ADBKMNBJNOI)
			{
				((ADBKMNBJNOI)AppsFlyer.instance).PDMENEHJHNC(JCLAMHGPCIB);
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000236F File Offset: 0x0000056F
		public static void setDisableCollectAppleAdSupport(bool FICBPGMDCHC)
		{
			if (AppsFlyer.instance != null && AppsFlyer.instance is ADBKMNBJNOI)
			{
				((ADBKMNBJNOI)AppsFlyer.instance).KFJHKJMIFGH(FICBPGMDCHC);
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0000230E File Offset: 0x0000050E
		public static void setCustomerUserId(string DBHMNECMIAB)
		{
			if (AppsFlyer.instance != null)
			{
				AppsFlyer.instance.DIAIIACONOL(DBHMNECMIAB);
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002394 File Offset: 0x00000594
		public static void handleOpenUrl(string HPIGJNFGNDM, string HODMAIPLMMH, string KEOBMMCBHLH)
		{
			if (AppsFlyer.instance != null && AppsFlyer.instance is ADBKMNBJNOI)
			{
				((ADBKMNBJNOI)AppsFlyer.instance).DMNLKJIAEPG(HPIGJNFGNDM, HODMAIPLMMH, KEOBMMCBHLH);
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000023BB File Offset: 0x000005BB
		public void inAppResponseReceived(string LPHMODJEEBN)
		{
			if (AppsFlyer.IIHGKGLPKDC != null)
			{
				AppsFlyer.IIHGKGLPKDC(null, AppsFlyer.HIBKMKMNCBF(LPHMODJEEBN));
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x0000221F File Offset: 0x0000041F
		public static void NHKALOFIIOI(string NHHOKJJLNCL)
		{
			if (AppsFlyer.instance != null)
			{
				AppsFlyer.instance.FNANODNLIAE(NHHOKJJLNCL);
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000023D5 File Offset: 0x000005D5
		public static void setOutOfStore(string LELICLLHDHG)
		{
			if (AppsFlyer.instance != null && AppsFlyer.instance is GJFEGIKFFJF)
			{
				((GJFEGIKFFJF)AppsFlyer.instance).JEDDKKOOCAG(LELICLLHDHG);
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x0000212A File Offset: 0x0000032A
		public static void addPushNotificationDeepLinkPath(params string[] MGCNJCACPOO)
		{
			if (AppsFlyer.instance != null)
			{
				AppsFlyer.instance.ELMAFOKGGMN(MGCNJCACPOO);
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000023FA File Offset: 0x000005FA
		public static void FOPHMMAEMCE(bool JGIAINMEHKB)
		{
			if (AppsFlyer.instance != null && AppsFlyer.instance is ADBKMNBJNOI)
			{
				((ADBKMNBJNOI)AppsFlyer.instance).EAIEPCPHPMM(JGIAINMEHKB);
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x0000241F File Offset: 0x0000061F
		public static void initSDK(string MHOIIOBIFLD, string NCFIHMEHIOE)
		{
			AppsFlyer.initSDK(MHOIIOBIFLD, NCFIHMEHIOE, null);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002429 File Offset: 0x00000629
		public static void HBIKMPMCEFE(string MHOIIOBIFLD, string NCFIHMEHIOE, MonoBehaviour IACFDHCDEME)
		{
			if (IACFDHCDEME != null)
			{
				AppsFlyer.CallBackObjectName = IACFDHCDEME.name;
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x0000213E File Offset: 0x0000033E
		public static void PFPCLGHKNNI()
		{
			if (AppsFlyer.instance != null && AppsFlyer.instance is GJFEGIKFFJF)
			{
				((GJFEGIKFFJF)AppsFlyer.instance).APEGIHDHGGB();
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x0000243F File Offset: 0x0000063F
		public static void JAFDHDLFFIM(CLHOKHFCLNC FBENALOCONP, string[] FNHJKDAPGEF)
		{
			if (AppsFlyer.instance != null)
			{
				AppsFlyer.instance.LPLNGDANKMC(FBENALOCONP, FNHJKDAPGEF);
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002454 File Offset: 0x00000654
		public static void setDisableCollectIAd(bool HJOIHPAIDBG)
		{
			if (AppsFlyer.instance != null && AppsFlyer.instance is ADBKMNBJNOI)
			{
				((ADBKMNBJNOI)AppsFlyer.instance).PONJJMNLPDC(HJOIHPAIDBG);
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002479 File Offset: 0x00000679
		public static void MOLPGFPJJEC(string JCAMLFOHNHB, string JILHDLALFFI, string BKKDLNMPIBD)
		{
			if (AppsFlyer.instance != null && AppsFlyer.instance is GJFEGIKFFJF)
			{
				((GJFEGIKFFJF)AppsFlyer.instance).MFIDJHKEKFG(JCAMLFOHNHB, JILHDLALFFI, BKKDLNMPIBD);
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000020F1 File Offset: 0x000002F1
		public static void NEGPDFOEHCM(bool BEKMLGADBDI)
		{
			if (AppsFlyer.instance != null)
			{
				AppsFlyer.instance.GGBJINIEHBD(BEKMLGADBDI);
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002298 File Offset: 0x00000498
		public static void setAndroidIdData(string CKOOPLBEFEF)
		{
			if (AppsFlyer.instance != null && AppsFlyer.instance is GJFEGIKFFJF)
			{
				((GJFEGIKFFJF)AppsFlyer.instance).IMHHBNMBNOK(CKOOPLBEFEF);
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x0000230E File Offset: 0x0000050E
		public static void PCBLPPMBHCJ(string DBHMNECMIAB)
		{
			if (AppsFlyer.instance != null)
			{
				AppsFlyer.instance.DIAIIACONOL(DBHMNECMIAB);
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000024A0 File Offset: 0x000006A0
		public static void BICFIGJAJPH(string AMGPFOKINPI)
		{
			if (AppsFlyer.instance != null)
			{
				AppsFlyer.instance.PLHOFELALMK(AMGPFOKINPI);
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000221F File Offset: 0x0000041F
		public static void getConversionData(string NHHOKJJLNCL)
		{
			if (AppsFlyer.instance != null)
			{
				AppsFlyer.instance.FNANODNLIAE(NHHOKJJLNCL);
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000024B4 File Offset: 0x000006B4
		public static void validateAndSendInAppPurchase(GECKOOCNDML BPBJMFKCOJG, Dictionary<string, string> EPONHPGGAOM, MonoBehaviour IACFDHCDEME)
		{
			if (AppsFlyer.instance != null && AppsFlyer.instance is GJFEGIKFFJF)
			{
				((GJFEGIKFFJF)AppsFlyer.instance).BCCGOLNKCJM(BPBJMFKCOJG, EPONHPGGAOM, IACFDHCDEME);
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000024DB File Offset: 0x000006DB
		public static void JPLHMEABKBM(string LKHDBDHCJPN)
		{
			if (AppsFlyer.instance != null)
			{
				AppsFlyer.instance.JFOIAHONCOM(LKHDBDHCJPN);
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000022D4 File Offset: 0x000004D4
		public static void disableSKAdNetwork(bool HLFIFKJELHD)
		{
			if (AppsFlyer.instance != null && AppsFlyer.instance is ADBKMNBJNOI)
			{
				((ADBKMNBJNOI)AppsFlyer.instance).LKEEPBHMCDO(HLFIFKJELHD);
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000024EF File Offset: 0x000006EF
		public static bool isPreInstalledApp()
		{
			return AppsFlyer.instance != null && AppsFlyer.instance is GJFEGIKFFJF && ((GJFEGIKFFJF)AppsFlyer.instance).ICCOFBMGEBG();
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002429 File Offset: 0x00000629
		public static void initSDK(string MHOIIOBIFLD, string NCFIHMEHIOE, MonoBehaviour IACFDHCDEME)
		{
			if (IACFDHCDEME != null)
			{
				AppsFlyer.CallBackObjectName = IACFDHCDEME.name;
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000020F1 File Offset: 0x000002F1
		public static void NKKKCIDBMFN(bool BEKMLGADBDI)
		{
			if (AppsFlyer.instance != null)
			{
				AppsFlyer.instance.GGBJINIEHBD(BEKMLGADBDI);
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002515 File Offset: 0x00000715
		public static Dictionary<string, object> CallbackStringToDictionary(string PPDGGDCAMNB)
		{
			return ALMPEPHNEHO.PBBKDGOECKP(PPDGGDCAMNB) as Dictionary<string, object>;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002522 File Offset: 0x00000722
		public static void setMinTimeBetweenSessions(int AIJFJMKHAOO)
		{
			if (AppsFlyer.instance != null)
			{
				AppsFlyer.instance.LKIPLCPIFCN(AIJFJMKHAOO);
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x0000243F File Offset: 0x0000063F
		public static void setUserEmails(CLHOKHFCLNC FBENALOCONP, params string[] FNHJKDAPGEF)
		{
			if (AppsFlyer.instance != null)
			{
				AppsFlyer.instance.LPLNGDANKMC(FBENALOCONP, FNHJKDAPGEF);
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002536 File Offset: 0x00000736
		public static void registerUninstall(byte[] MNNOCJGNLFF)
		{
			if (AppsFlyer.instance != null && AppsFlyer.instance is ADBKMNBJNOI)
			{
				((ADBKMNBJNOI)AppsFlyer.instance).GMPCMAIFJMJ(MNNOCJGNLFF);
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0000213E File Offset: 0x0000033E
		public static void NMJGAIPJDPH()
		{
			if (AppsFlyer.instance != null && AppsFlyer.instance is GJFEGIKFFJF)
			{
				((GJFEGIKFFJF)AppsFlyer.instance).APEGIHDHGGB();
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000255B File Offset: 0x0000075B
		public static void AFLog(string OIELKMEHKEE, string PPDGGDCAMNB)
		{
			Debug.Log(string.Format("AppsFlyer_Unity_v{0} {1} called with {2}", AppsFlyer.kAppsFlyerPluginVersion, OIELKMEHKEE, PPDGGDCAMNB));
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000218E File Offset: 0x0000038E
		public static string getAppsFlyerId()
		{
			if (AppsFlyer.instance != null)
			{
				return AppsFlyer.instance.ELNDMKFBKDC();
			}
			return string.Empty;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002573 File Offset: 0x00000773
		public static void setAdditionalData(Dictionary<string, string> CJPBKKDHJMN)
		{
			if (AppsFlyer.instance != null)
			{
				AppsFlyer.instance.GCHHBODIGKI(CJPBKKDHJMN);
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002479 File Offset: 0x00000679
		public static void BFFIHBOOOCB(string JCAMLFOHNHB, string JILHDLALFFI, string BKKDLNMPIBD)
		{
			if (AppsFlyer.instance != null && AppsFlyer.instance is GJFEGIKFFJF)
			{
				((GJFEGIKFFJF)AppsFlyer.instance).MFIDJHKEKFG(JCAMLFOHNHB, JILHDLALFFI, BKKDLNMPIBD);
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000024B4 File Offset: 0x000006B4
		public static void MCBKFKIANHI(GECKOOCNDML BPBJMFKCOJG, Dictionary<string, string> EPONHPGGAOM, MonoBehaviour IACFDHCDEME)
		{
			if (AppsFlyer.instance != null && AppsFlyer.instance is GJFEGIKFFJF)
			{
				((GJFEGIKFFJF)AppsFlyer.instance).BCCGOLNKCJM(BPBJMFKCOJG, EPONHPGGAOM, IACFDHCDEME);
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002588 File Offset: 0x00000788
		private static CFBGOLHIJNF HIBKMKMNCBF(string LPHMODJEEBN)
		{
			int liaapdamfnd = 0;
			string nmpoplkihfn = "";
			try
			{
				Dictionary<string, object> dictionary = AppsFlyer.CallbackStringToDictionary(LPHMODJEEBN);
				nmpoplkihfn = (string)(dictionary.ContainsKey("errorDescription") ? dictionary["errorDescription"] : "");
				liaapdamfnd = (int)((long)dictionary["statusCode"]);
			}
			catch (Exception arg)
			{
				AppsFlyer.AFLog("parseRequestCallback", string.Format("{0} Exception caught.", arg));
			}
			return new CFBGOLHIJNF(liaapdamfnd, nmpoplkihfn);
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000057 RID: 87 RVA: 0x0000260C File Offset: 0x0000080C
		// (remove) Token: 0x06000085 RID: 133 RVA: 0x00002628 File Offset: 0x00000828
		public static event EventHandler MDOMDFGPOCO
		{
			add
			{
				AppsFlyer.FLOJEDMHNPL = (EventHandler)Delegate.Combine(AppsFlyer.FLOJEDMHNPL, value);
				AppsFlyer.subscribeForDeepLink();
			}
			remove
			{
				AppsFlyer.FLOJEDMHNPL = (EventHandler)Delegate.Remove(AppsFlyer.FLOJEDMHNPL, value);
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002628 File Offset: 0x00000828
		public static void LFIDMGGMPGD(EventHandler AJLPALFJHCC)
		{
			AppsFlyer.FLOJEDMHNPL = (EventHandler)Delegate.Remove(AppsFlyer.FLOJEDMHNPL, AJLPALFJHCC);
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600007E RID: 126 RVA: 0x000028D8 File Offset: 0x00000AD8
		// (remove) Token: 0x06000059 RID: 89 RVA: 0x0000263F File Offset: 0x0000083F
		public static event EventHandler OJPMABBKHOP
		{
			add
			{
				AppsFlyer.HFLNNMJJIPG = (EventHandler)Delegate.Combine(AppsFlyer.HFLNNMJJIPG, value);
			}
			remove
			{
				AppsFlyer.HFLNNMJJIPG = (EventHandler)Delegate.Remove(AppsFlyer.HFLNNMJJIPG, value);
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002656 File Offset: 0x00000856
		public void requestResponseReceived(string LPHMODJEEBN)
		{
			if (AppsFlyer.HFLNNMJJIPG != null)
			{
				AppsFlyer.HFLNNMJJIPG(null, AppsFlyer.HIBKMKMNCBF(LPHMODJEEBN));
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002670 File Offset: 0x00000870
		public static void stopSDK(bool KPNCKNCPEMO)
		{
			if (AppsFlyer.instance != null)
			{
				AppsFlyer.instance.HAGENJPNIOC(KPNCKNCPEMO);
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002684 File Offset: 0x00000884
		public static void setCustomerIdAndStartSDK(string DBHMNECMIAB)
		{
			if (AppsFlyer.instance != null && AppsFlyer.instance is GJFEGIKFFJF)
			{
				((GJFEGIKFFJF)AppsFlyer.instance).EEEGMJDCMFO(DBHMNECMIAB);
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000021BB File Offset: 0x000003BB
		public static void disableIDFVCollection(bool HLFIFKJELHD)
		{
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000026A9 File Offset: 0x000008A9
		public static void sendEvent(string KDKKHJIHFIF, Dictionary<string, string> NFNJIPAENJN)
		{
			if (AppsFlyer.instance != null)
			{
				AppsFlyer.instance.NDAJINPGPEP(KDKKHJIHFIF, NFNJIPAENJN, AppsFlyer.IIHGKGLPKDC != null, AppsFlyer.CallBackObjectName);
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000026CB File Offset: 0x000008CB
		public static void recordLocation(double BCJPPABFONK, double PLKHCPNAACJ)
		{
			if (AppsFlyer.instance != null)
			{
				AppsFlyer.instance.KFPHEEMACAG(BCJPPABFONK, PLKHCPNAACJ);
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000026E0 File Offset: 0x000008E0
		public static void updateServerUninstallToken(string ENBBONPKHBC)
		{
			if (AppsFlyer.instance != null && AppsFlyer.instance is GJFEGIKFFJF)
			{
				((GJFEGIKFFJF)AppsFlyer.instance).GNEAPGOPHLG(ENBBONPKHBC);
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000225A File Offset: 0x0000045A
		public static void IAIGLMCKLIH()
		{
			if (AppsFlyer.instance != null)
			{
				AppsFlyer.instance.CAFCCGMOCFG();
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002454 File Offset: 0x00000654
		public static void EDDLKLIAPPN(bool HJOIHPAIDBG)
		{
			if (AppsFlyer.instance != null && AppsFlyer.instance is ADBKMNBJNOI)
			{
				((ADBKMNBJNOI)AppsFlyer.instance).PONJJMNLPDC(HJOIHPAIDBG);
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002705 File Offset: 0x00000905
		public static void setDisableAdvertisingIdentifiers(bool FICBPGMDCHC)
		{
			if (AppsFlyer.instance != null && AppsFlyer.instance is GJFEGIKFFJF)
			{
				((GJFEGIKFFJF)AppsFlyer.instance).LBKKIKLNCEF(FICBPGMDCHC);
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000272A File Offset: 0x0000092A
		public static void setPartnerData(string EIFJONCMNIG, Dictionary<string, string> EIDCNKDCIKL)
		{
			if (AppsFlyer.instance != null)
			{
				AppsFlyer.instance.MAKCEBDDPDG(EIFJONCMNIG, EIDCNKDCIKL);
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0000273F File Offset: 0x0000093F
		public static void setIsDebug(bool IFMCGJFMECI)
		{
			if (AppsFlyer.instance != null)
			{
				AppsFlyer.instance.AFFAKMDIPIL(IFMCGJFMECI);
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000275B File Offset: 0x0000095B
		public static void setCollectIMEI(bool KNBMFBAPMJL)
		{
			if (AppsFlyer.instance != null && AppsFlyer.instance is GJFEGIKFFJF)
			{
				((GJFEGIKFFJF)AppsFlyer.instance).MKMFMLMDJNJ(KNBMFBAPMJL);
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000024DB File Offset: 0x000006DB
		public static void setPhoneNumber(string LKHDBDHCJPN)
		{
			if (AppsFlyer.instance != null)
			{
				AppsFlyer.instance.JFOIAHONCOM(LKHDBDHCJPN);
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000023FA File Offset: 0x000005FA
		public static void setUseReceiptValidationSandbox(bool JGIAINMEHKB)
		{
			if (AppsFlyer.instance != null && AppsFlyer.instance is ADBKMNBJNOI)
			{
				((ADBKMNBJNOI)AppsFlyer.instance).EAIEPCPHPMM(JGIAINMEHKB);
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002780 File Offset: 0x00000980
		public static void setCollectOaid(bool KNBMFBAPMJL)
		{
			if (AppsFlyer.instance != null && AppsFlyer.instance is GJFEGIKFFJF)
			{
				((GJFEGIKFFJF)AppsFlyer.instance).NGCPPGEANLL(KNBMFBAPMJL);
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000022F9 File Offset: 0x000004F9
		public static void setHost(string OEMLCIBMFLG, string EKJMCPMPECM)
		{
			if (AppsFlyer.instance != null)
			{
				AppsFlyer.instance.NHALNOEEGKK(OEMLCIBMFLG, EKJMCPMPECM);
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000027BC File Offset: 0x000009BC
		public static void recordCrossPromoteImpression(string NCFIHMEHIOE, string JILHDLALFFI, Dictionary<string, string> BHCIIFICHDN)
		{
			if (AppsFlyer.instance != null)
			{
				AppsFlyer.instance.NIJFNENJOII(NCFIHMEHIOE, JILHDLALFFI, BHCIIFICHDN);
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002479 File Offset: 0x00000679
		public static void setPreinstallAttribution(string JCAMLFOHNHB, string JILHDLALFFI, string BKKDLNMPIBD)
		{
			if (AppsFlyer.instance != null && AppsFlyer.instance is GJFEGIKFFJF)
			{
				((GJFEGIKFFJF)AppsFlyer.instance).MFIDJHKEKFG(JCAMLFOHNHB, JILHDLALFFI, BKKDLNMPIBD);
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002656 File Offset: 0x00000856
		public void EHPLIPBAHJG(string LPHMODJEEBN)
		{
			if (AppsFlyer.HFLNNMJJIPG != null)
			{
				AppsFlyer.HFLNNMJJIPG(null, AppsFlyer.HIBKMKMNCBF(LPHMODJEEBN));
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000027D2 File Offset: 0x000009D2
		public static string getSdkVersion()
		{
			if (AppsFlyer.instance != null)
			{
				return AppsFlyer.instance.CECGBLFEHFP();
			}
			return "";
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002281 File Offset: 0x00000481
		public static void attributeAndOpenStore(string NCFIHMEHIOE, string JILHDLALFFI, Dictionary<string, string> LMCFPFALEEP, MonoBehaviour IACFDHCDEME)
		{
			if (AppsFlyer.instance != null)
			{
				AppsFlyer.instance.ICDGKKEPCMB(NCFIHMEHIOE, JILHDLALFFI, LMCFPFALEEP, IACFDHCDEME);
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000027EB File Offset: 0x000009EB
		public static void setAppInviteOneLinkID(string ICDIFBCGJBB)
		{
			if (AppsFlyer.instance != null)
			{
				AppsFlyer.instance.GDPIMGNPFND(ICDIFBCGJBB);
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000027FF File Offset: 0x000009FF
		public static void setImeiData(string CHBCEKBLPLC)
		{
			if (AppsFlyer.instance != null && AppsFlyer.instance is GJFEGIKFFJF)
			{
				((GJFEGIKFFJF)AppsFlyer.instance).GEOENNDKJIC(CHBCEKBLPLC);
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002322 File Offset: 0x00000522
		public static void setConsentData(JHFNFEFBENE KNNJFAIOMJH)
		{
			if (AppsFlyer.instance != null)
			{
				AppsFlyer.instance.PDOHPGDBEHH(KNNJFAIOMJH);
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002824 File Offset: 0x00000A24
		public void onDeepLinking(string LPHMODJEEBN)
		{
			CHELAOBJCBK e = new CHELAOBJCBK(LPHMODJEEBN);
			if (AppsFlyer.FLOJEDMHNPL != null)
			{
				AppsFlyer.FLOJEDMHNPL(null, e);
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000020CC File Offset: 0x000002CC
		public static void waitForCustomerUserId(bool KAKHOFAHDLA)
		{
			if (AppsFlyer.instance != null && AppsFlyer.instance is GJFEGIKFFJF)
			{
				((GJFEGIKFFJF)AppsFlyer.instance).KHMKPDPKFIJ(KAKHOFAHDLA);
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000024A0 File Offset: 0x000006A0
		public static void setCurrencyCode(string AMGPFOKINPI)
		{
			if (AppsFlyer.instance != null)
			{
				AppsFlyer.instance.PLHOFELALMK(AMGPFOKINPI);
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000026A9 File Offset: 0x000008A9
		public static void FOMAGFBAACL(string KDKKHJIHFIF, Dictionary<string, string> NFNJIPAENJN)
		{
			if (AppsFlyer.instance != null)
			{
				AppsFlyer.instance.NDAJINPGPEP(KDKKHJIHFIF, NFNJIPAENJN, AppsFlyer.IIHGKGLPKDC != null, AppsFlyer.CallBackObjectName);
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000284B File Offset: 0x00000A4B
		public static void validateAndSendInAppPurchase(string BNEMJDGHFKE, string JGNHLAAOFFK, string LCKMHOLFDHH, string ICKHGADHPMJ, string JOBAGHGMDHC, Dictionary<string, string> EPONHPGGAOM, MonoBehaviour IACFDHCDEME)
		{
			if (AppsFlyer.instance != null && AppsFlyer.instance is GJFEGIKFFJF)
			{
				((GJFEGIKFFJF)AppsFlyer.instance).BCCGOLNKCJM(BNEMJDGHFKE, JGNHLAAOFFK, LCKMHOLFDHH, ICKHGADHPMJ, JOBAGHGMDHC, EPONHPGGAOM, IACFDHCDEME);
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000272A File Offset: 0x0000092A
		public static void IOMDDHALBLO(string EIFJONCMNIG, Dictionary<string, string> EIDCNKDCIKL)
		{
			if (AppsFlyer.instance != null)
			{
				AppsFlyer.instance.MAKCEBDDPDG(EIFJONCMNIG, EIDCNKDCIKL);
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00002879 File Offset: 0x00000A79
		public static void startSDK()
		{
			if (AppsFlyer.instance != null)
			{
				AppsFlyer.instance.HBKFCBAAIBI(AppsFlyer.HFLNNMJJIPG != null, AppsFlyer.CallBackObjectName);
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00002899 File Offset: 0x00000A99
		public static string getAttributionId()
		{
			if (AppsFlyer.instance != null && AppsFlyer.instance is GJFEGIKFFJF)
			{
				return ((GJFEGIKFFJF)AppsFlyer.instance).HBGLDFBEDGI();
			}
			return string.Empty;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000028C3 File Offset: 0x00000AC3
		public static void generateUserInviteLink(Dictionary<string, string> BHCIIFICHDN, MonoBehaviour IACFDHCDEME)
		{
			if (AppsFlyer.instance != null)
			{
				AppsFlyer.instance.MNEKIKINNGK(BHCIIFICHDN, IACFDHCDEME);
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00002670 File Offset: 0x00000870
		public static void EPHNKONKHMN(bool KPNCKNCPEMO)
		{
			if (AppsFlyer.instance != null)
			{
				AppsFlyer.instance.HAGENJPNIOC(KPNCKNCPEMO);
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000028EF File Offset: 0x00000AEF
		public static void anonymizeUser(bool KBIFCICNDPA)
		{
			if (AppsFlyer.instance != null)
			{
				AppsFlyer.instance.NDLLHKHKKNJ(KBIFCICNDPA);
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002298 File Offset: 0x00000498
		public static void GIPPOELMJNL(string CKOOPLBEFEF)
		{
			if (AppsFlyer.instance != null && AppsFlyer.instance is GJFEGIKFFJF)
			{
				((GJFEGIKFFJF)AppsFlyer.instance).IMHHBNMBNOK(CKOOPLBEFEF);
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000021A7 File Offset: 0x000003A7
		public static void setDeepLinkTimeout(long DGEFFOIIMJP)
		{
			if (AppsFlyer.instance != null)
			{
				AppsFlyer.instance.ENCOKNKCDLD(DGEFFOIIMJP);
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00002454 File Offset: 0x00000654
		public static void OPPGOFDAPJG(bool HJOIHPAIDBG)
		{
			if (AppsFlyer.instance != null && AppsFlyer.instance is ADBKMNBJNOI)
			{
				((ADBKMNBJNOI)AppsFlyer.instance).PONJJMNLPDC(HJOIHPAIDBG);
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00002903 File Offset: 0x00000B03
		public static void setCollectAndroidID(bool KNBMFBAPMJL)
		{
			if (AppsFlyer.instance != null && AppsFlyer.instance is GJFEGIKFFJF)
			{
				((GJFEGIKFFJF)AppsFlyer.instance).PEDIOLEPINI(KNBMFBAPMJL);
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000026CB File Offset: 0x000008CB
		public static void OHGNFNAAPFD(double BCJPPABFONK, double PLKHCPNAACJ)
		{
			if (AppsFlyer.instance != null)
			{
				AppsFlyer.instance.KFPHEEMACAG(BCJPPABFONK, PLKHCPNAACJ);
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002928 File Offset: 0x00000B28
		public static void setOneLinkCustomDomain(params string[] PLBPFKJMLBD)
		{
			if (AppsFlyer.instance != null)
			{
				AppsFlyer.instance.DEOOOHMAILK(PLBPFKJMLBD);
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000293C File Offset: 0x00000B3C
		public static void setCurrentDeviceLanguage(string ICCJIBMFNLD)
		{
			if (AppsFlyer.instance != null && AppsFlyer.instance is ADBKMNBJNOI)
			{
				((ADBKMNBJNOI)AppsFlyer.instance).AAMALCJDCOA(ICCJIBMFNLD);
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000293C File Offset: 0x00000B3C
		public static void ENELPEIAGJK(string ICCJIBMFNLD)
		{
			if (AppsFlyer.instance != null && AppsFlyer.instance is ADBKMNBJNOI)
			{
				((ADBKMNBJNOI)AppsFlyer.instance).AAMALCJDCOA(ICCJIBMFNLD);
			}
		}

		// Token: 0x04000001 RID: 1
		public static readonly string kAppsFlyerPluginVersion = "6.14.4";

		// Token: 0x04000002 RID: 2
		public static string CallBackObjectName = null;

		// Token: 0x04000003 RID: 3
		private static EventHandler HFLNNMJJIPG;

		// Token: 0x04000004 RID: 4
		private static EventHandler IIHGKGLPKDC;

		// Token: 0x04000005 RID: 5
		private static EventHandler FLOJEDMHNPL;

		// Token: 0x04000006 RID: 6
		public static GLJOLAJPMDG instance = null;

		// Token: 0x02000004 RID: 4
		// (Invoke) Token: 0x0600008B RID: 139
		public delegate void IDKIMNNMKJK(string KJPAGOJDABE);
	}
}
