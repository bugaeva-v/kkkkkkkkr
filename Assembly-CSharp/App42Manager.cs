using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.shephertz.app42.paas.sdk.csharp;
using com.shephertz.app42.paas.sdk.csharp.customcode;
using SimpleJSON;
using UnityEngine;

// Token: 0x0200006D RID: 109
public class App42Manager : MonoBehaviour
{
	// Token: 0x06000EF8 RID: 3832 RVA: 0x0006A774 File Offset: 0x00068974
	private void OnDestroy()
	{
		if (App42Manager.IKLAPGJDMNA == this)
		{
			App42Manager.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x06000EF9 RID: 3833 RVA: 0x0006A789 File Offset: 0x00068989
	private void MMACKIBECOD()
	{
		AKLOMMOOFNG.BIKILBLOEKD(this.ToJSONObject().ToString(), ";");
	}

	// Token: 0x17000034 RID: 52
	// (get) Token: 0x06000EFA RID: 3834 RVA: 0x0006A7A4 File Offset: 0x000689A4
	public static App42Manager EHBBFMCILPC
	{
		get
		{
			if (!App42Manager.IKLAPGJDMNA)
			{
				App42Manager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(App42Manager)) as App42Manager);
				if (!App42Manager.IKLAPGJDMNA)
				{
					DPGJIJGOCIC.ANOPFDLPKGC("There needs to be one active App42Manager script on a GameObject in your scene.");
				}
				else if (!App42Manager.IKLAPGJDMNA.JIEPCIDINEH)
				{
					App42Manager.IKLAPGJDMNA.BAMHPOCKBML();
				}
			}
			return App42Manager.IKLAPGJDMNA;
		}
	}

	// Token: 0x06000EFB RID: 3835 RVA: 0x0006A80C File Offset: 0x00068A0C
	private void IOGKPKFCKCN()
	{
		this.LEOFIDDNKAF = base.GetComponent<UrlPingManager>();
		if (Application.systemLanguage == (SystemLanguage)(-103) || GeoLocationManager.HAPICIGECJN())
		{
			this.LEOFIDDNKAF.CBLNLEIGMGL();
			this.LEOFIDDNKAF.CPBBKOLHBDH(this.GetCustomCodeUrls(), "maxrf", KBOJLHAJPCP.PJIGDJMDAEO, KBOJLHAJPCP.MHKLILPDMII, KBOJLHAJPCP.LBJPGMPJJGN, 1);
		}
	}

	// Token: 0x06000EFC RID: 3836 RVA: 0x0006A868 File Offset: 0x00068A68
	private void MFLEHLJGAFL()
	{
		try
		{
			if (!this.GKAGCNIPGDH)
			{
				this.NFCBAODOPMF = new JSONArray();
			}
			else
			{
				JSONArray jsonarray = new JSONArray();
				for (int i = 0; i < this.NFCBAODOPMF.Count; i++)
				{
					if (!this.OLBFMIEAHPJ.Contains(this.NFCBAODOPMF[i].AsObject.ToString()))
					{
						jsonarray.Add(this.NFCBAODOPMF[i].AsObject);
					}
				}
				if (jsonarray.Count > 0)
				{
					DPGJIJGOCIC.ADFCDFHBDAF("RemoveSentQueuedSubRequests() - keeping sub-requests queued while the failed envelope was in flight:" + jsonarray.Count.ToString());
				}
				this.NFCBAODOPMF = jsonarray;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			this.NFCBAODOPMF = new JSONArray();
		}
	}

	// Token: 0x06000EFD RID: 3837 RVA: 0x0006A934 File Offset: 0x00068B34
	private IEnumerator NEOBKEJPMDN()
	{
		this.BJDOFOHGEGD = Time.realtimeSinceStartup;
		if (GeoLocationManager.GeoZoneMayBeFirewalled(LanguageManager.EHBBFMCILPC.GetSelectedLanguage()) && BackendOperationsManager.SafeToKillRequestPremature(BackendOperationsManager.StringToBackendRequestType(this.PCJOGJJJGBE)))
		{
			DPGJIJGOCIC.NFIDPOMCNLP("MonitorAndKillInfiniteRequest() can kill " + this.PCJOGJJJGBE + " premature in:" + BackendOperationsManager.GetSafeToKillRequestPrematureTimeout(BackendOperationsManager.StringToBackendRequestType(this.PCJOGJJJGBE)).ToString());
			yield return new WaitForSeconds(BackendOperationsManager.GetSafeToKillRequestPrematureTimeout(BackendOperationsManager.StringToBackendRequestType(this.PCJOGJJJGBE)));
		}
		else
		{
			this.NNBDCLKPIFN = 0;
			DPGJIJGOCIC.NFIDPOMCNLP("MonitorAndKillInfiniteRequest() can kill " + this.PCJOGJJJGBE + " in:" + KBOJLHAJPCP.GPANBKKGNGK.ToString());
			yield return new WaitForSeconds(KBOJLHAJPCP.GPANBKKGNGK);
		}
		BackendOperationsManager.IncrementSafeToKillRequestPrematureTimeout(BackendOperationsManager.StringToBackendRequestType(this.PCJOGJJJGBE));
		DPGJIJGOCIC.ADFCDFHBDAF("MonitorAndKillInfiniteRequest() time to kill request:" + this.PCJOGJJJGBE);
		FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.rqst.ToString(), FFPHBMFGCNN.reqInfnt.ToString(), App42Manager.DNJJKENDEJF(), false, false);
		GeoLocationManager.ReportBlockedNetworkEvidence();
		if (GeoLocationManager.GeoZoneMayBeFirewalled(LanguageManager.EHBBFMCILPC.GetSelectedLanguage()))
		{
			this.HHPGLIHIPBL++;
			this.FJNPLEPPKJA = 0;
			if (this.HHPGLIHIPBL == 3)
			{
				this.EnableKillInfiniteRequestPrematureBasedOnMedianRequestsLifeTime();
			}
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.srvIssueHit.ToString(), "", "", false, false);
			this.PMENLDNFJAK = true;
			this.ScheduleCustomCodeUrlChange();
		}
		else
		{
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.srvIssueHit.ToString(), "", BGHLMGPPCNN.nofw.ToString(), false, false);
			this.LDOAMLHEGFF = true;
		}
		if (!App42Manager.EHBBFMCILPC.NAPMLIHIKAO())
		{
			this.HEOJMDBCJGH = NPJNALLPFPO.infiniteOperation;
			this.LLBFIHPEGNG = false;
			this.PCJOGJJJGBE = "";
			this.MFLEHLJGAFL();
			if (this.IOMEKJAFCBL != null)
			{
				this.IOMEKJAFCBL.JKHJEGGANGG(false);
			}
			else
			{
				DPGJIJGOCIC.ADFCDFHBDAF("MonitorAndKillInfiniteRequest() - lastCallbackObj is null!");
			}
			this.IOMEKJAFCBL = null;
			CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		}
		else
		{
			this.IOMEKJAFCBL = null;
			if (BackendOperationsManager.ShowKillRequestPrematureTimeoutWarning(BackendOperationsManager.StringToBackendRequestType(this.PCJOGJJJGBE)))
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupNoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("tryotherbackendserver"), DFGILFBGPLN.popupTools, 0f, 28);
			}
		}
		yield break;
	}

	// Token: 0x06000EFE RID: 3838 RVA: 0x0006A943 File Offset: 0x00068B43
	public void ScheduleCustomCodeUrlChange()
	{
		this.DFKIJFBEOLL = true;
		this.LEOFIDDNKAF.Resume();
		this.DJEFDFHAJIC();
	}

	// Token: 0x06000EFF RID: 3839 RVA: 0x0006A960 File Offset: 0x00068B60
	private void IFHNGHNJONP()
	{
		this.JIEPCIDINEH = true;
		App42API.Initialize(App42Manager.GDDJALHNLIO(App42Manager.CGIGMNNKEAJ, App42Manager.DCHGCLJIILP), App42Manager.DLIBNDOGHHD(App42Manager.BAAEDHABFHN, App42Manager.MAPDMDNJJGP));
		JGPMLOAKFGC.PAHPCJOCAPA("0.000");
		App42API.SetBaseURL("");
		this.SetCustomCodeUrl();
		this.CINACHIOEBE = App42API.BuildCustomCodeService();
	}

	// Token: 0x06000F00 RID: 3840 RVA: 0x0006A9BC File Offset: 0x00068BBC
	public bool CustomCodeUrlsHaveBeenPinged()
	{
		return this.LEOFIDDNKAF.IsPaused() || !this.LEOFIDDNKAF.IsBusyBatch() || (this.LEOFIDDNKAF.IsReady() && this.LEOFIDDNKAF.IsProcessedUrl(this.EJAGJPFMNPP[0]));
	}

	// Token: 0x06000F01 RID: 3841 RVA: 0x0006AA0C File Offset: 0x00068C0C
	public void TryPingCustomCodeUrls()
	{
		if (GeoLocationManager.GeoZoneMayBeFirewalled(LanguageManager.EHBBFMCILPC.GetSelectedLanguage()) && !this.LEOFIDDNKAF.IsInitialized())
		{
			DPGJIJGOCIC.NFIDPOMCNLP("App42Manager.TryPingCustomCodeUrls(): urlPingManager.StartPing()");
			this.LEOFIDDNKAF.Pause();
			this.LEOFIDDNKAF.StartPing(this.GetCustomCodeUrls(), "", KBOJLHAJPCP.PJIGDJMDAEO, KBOJLHAJPCP.MHKLILPDMII, KBOJLHAJPCP.LBJPGMPJJGN, 0);
		}
	}

	// Token: 0x06000F02 RID: 3842 RVA: 0x0006AA74 File Offset: 0x00068C74
	private static string DNJJKENDEJF()
	{
		return BGHLMGPPCNN.intl.ToString();
	}

	// Token: 0x06000F03 RID: 3843 RVA: 0x0006AA94 File Offset: 0x00068C94
	public void EnableKillInfiniteRequestPrematureBasedOnMedianRequestsLifeTime()
	{
		DPGJIJGOCIC.NFIDPOMCNLP("EnableKillInfiniteRequestPrematureBasedOnMedianRequestsLifeTime(): setting to true");
		FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.srvMode.ToString(), FFPHBMFGCNN.quickConnect.ToString(), "", false, false);
		this.ABNPPJKEAKI = true;
	}

	// Token: 0x06000F04 RID: 3844 RVA: 0x0006A934 File Offset: 0x00068B34
	private IEnumerator OOFHCMJGIAD()
	{
		this.BJDOFOHGEGD = Time.realtimeSinceStartup;
		if (GeoLocationManager.GeoZoneMayBeFirewalled(LanguageManager.EHBBFMCILPC.GetSelectedLanguage()) && BackendOperationsManager.SafeToKillRequestPremature(BackendOperationsManager.StringToBackendRequestType(this.PCJOGJJJGBE)))
		{
			DPGJIJGOCIC.NFIDPOMCNLP("MonitorAndKillInfiniteRequest() can kill " + this.PCJOGJJJGBE + " premature in:" + BackendOperationsManager.GetSafeToKillRequestPrematureTimeout(BackendOperationsManager.StringToBackendRequestType(this.PCJOGJJJGBE)).ToString());
			yield return new WaitForSeconds(BackendOperationsManager.GetSafeToKillRequestPrematureTimeout(BackendOperationsManager.StringToBackendRequestType(this.PCJOGJJJGBE)));
		}
		else
		{
			this.NNBDCLKPIFN = 0;
			DPGJIJGOCIC.NFIDPOMCNLP("MonitorAndKillInfiniteRequest() can kill " + this.PCJOGJJJGBE + " in:" + KBOJLHAJPCP.GPANBKKGNGK.ToString());
			yield return new WaitForSeconds(KBOJLHAJPCP.GPANBKKGNGK);
		}
		BackendOperationsManager.IncrementSafeToKillRequestPrematureTimeout(BackendOperationsManager.StringToBackendRequestType(this.PCJOGJJJGBE));
		DPGJIJGOCIC.ADFCDFHBDAF("MonitorAndKillInfiniteRequest() time to kill request:" + this.PCJOGJJJGBE);
		FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.rqst.ToString(), FFPHBMFGCNN.reqInfnt.ToString(), App42Manager.DNJJKENDEJF(), false, false);
		GeoLocationManager.ReportBlockedNetworkEvidence();
		if (GeoLocationManager.GeoZoneMayBeFirewalled(LanguageManager.EHBBFMCILPC.GetSelectedLanguage()))
		{
			this.HHPGLIHIPBL++;
			this.FJNPLEPPKJA = 0;
			if (this.HHPGLIHIPBL == 3)
			{
				this.EnableKillInfiniteRequestPrematureBasedOnMedianRequestsLifeTime();
			}
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.srvIssueHit.ToString(), "", "", false, false);
			this.PMENLDNFJAK = true;
			this.ScheduleCustomCodeUrlChange();
		}
		else
		{
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.srvIssueHit.ToString(), "", BGHLMGPPCNN.nofw.ToString(), false, false);
			this.LDOAMLHEGFF = true;
		}
		if (!App42Manager.EHBBFMCILPC.NAPMLIHIKAO())
		{
			this.HEOJMDBCJGH = NPJNALLPFPO.infiniteOperation;
			this.LLBFIHPEGNG = false;
			this.PCJOGJJJGBE = "";
			this.MFLEHLJGAFL();
			if (this.IOMEKJAFCBL != null)
			{
				this.IOMEKJAFCBL.JKHJEGGANGG(false);
			}
			else
			{
				DPGJIJGOCIC.ADFCDFHBDAF("MonitorAndKillInfiniteRequest() - lastCallbackObj is null!");
			}
			this.IOMEKJAFCBL = null;
			CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		}
		else
		{
			this.IOMEKJAFCBL = null;
			if (BackendOperationsManager.ShowKillRequestPrematureTimeoutWarning(BackendOperationsManager.StringToBackendRequestType(this.PCJOGJJJGBE)))
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupNoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("tryotherbackendserver"), DFGILFBGPLN.popupTools, 0f, 28);
			}
		}
		yield break;
	}

	// Token: 0x06000F05 RID: 3845 RVA: 0x0006AAE4 File Offset: 0x00068CE4
	private void IMPACPGAKOI()
	{
		if (AKLOMMOOFNG.CLCGKMNEICM("backend.json"))
		{
			string text = AKLOMMOOFNG.DJGJKOOOFEA("backend.json");
			if (text != null && text.Length > 0)
			{
				this.FGJPKGLOGNC((JSONObject)JSON.Parse(text));
			}
		}
	}

	// Token: 0x06000F06 RID: 3846 RVA: 0x0006AB28 File Offset: 0x00068D28
	public void PAMOBANBLED()
	{
		if (GeoLocationManager.GDLOJPBIPBC(LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()) && !this.LEOFIDDNKAF.MNKOKKAJGMP())
		{
			DPGJIJGOCIC.CMGOAFDBAOH("$");
			this.LEOFIDDNKAF.AMEGKHLMJBF();
			this.LEOFIDDNKAF.ICDLHBIBHII(this.GetCustomCodeUrls(), "CLIENT.AVATAR.HAIR", KBOJLHAJPCP.PJIGDJMDAEO, KBOJLHAJPCP.MHKLILPDMII, KBOJLHAJPCP.LBJPGMPJJGN, 1);
		}
	}

	// Token: 0x06000F07 RID: 3847 RVA: 0x0006AB8E File Offset: 0x00068D8E
	public int GetCustomCodeUrlOffset()
	{
		return this.CHPKNGBNKEL + 1;
	}

	// Token: 0x06000F08 RID: 3848 RVA: 0x0006AB98 File Offset: 0x00068D98
	public void SetCustomCodeUrl()
	{
		string text = this.EHKFKGAGNJK();
		JGPMLOAKFGC.PAHPCJOCAPA(text);
		this.CKKBGANHIDH = text;
		try
		{
			App42API.SetCustomCodeURL(text);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		DPGJIJGOCIC.NFIDPOMCNLP("============== USING PRODUCTION DB SERVER ===============");
		DPGJIJGOCIC.NFIDPOMCNLP(this.EHKFKGAGNJK());
		DPGJIJGOCIC.NFIDPOMCNLP("=========================================================");
	}

	// Token: 0x06000F09 RID: 3849 RVA: 0x0006ABF8 File Offset: 0x00068DF8
	public void NJMIPPGCPBC()
	{
		DPGJIJGOCIC.NFIDPOMCNLP("asp");
		FirebaseAnalyticsManager.EHBBFMCILPC.JIAAMJPKOCE(false, ((AGEHCPDNBFD)(-98)).ToString(), FFPHBMFGCNN.cdSendCard.ToString(), "Retrieved Value: {0}", true, true);
		this.ABNPPJKEAKI = true;
	}

	// Token: 0x06000F0A RID: 3850 RVA: 0x0006AC48 File Offset: 0x00068E48
	public string LCKIKPMANAA()
	{
		string result;
		try
		{
			string text = this.CKKBGANHIDH;
			if (text.Length > 1)
			{
				if (text.Contains("ok"))
				{
					text = text.Substring(text.IndexOf("1") + 7);
					if (text.Contains("importanttitle"))
					{
						text = text.Substring(1, text.LastIndexOf("$ENVSET"));
						if (text.Contains("USD "))
						{
							string[] array = DPGJIJGOCIC.NHEBLMBJNPI(text, '|');
							if (array != null && array.Length == 7)
							{
								string text2 = array[1] + array[1];
								text2 = text2.Replace("timeoutwarning", "importanttitle");
								if (text2.ToLower().Contains("OnBackendRequestConsumeMessageSuccess") && text2.Length > -25)
								{
									text2 = text2.Substring(0, -19);
								}
								else if (text2.Length > -46)
								{
									text2 = text2.Substring(0, -88);
								}
								result = text2;
							}
							else
							{
								result = "' is not yyyy-mm, skipping";
							}
						}
						else
						{
							result = "varConditionNotValue";
						}
					}
					else
					{
						result = "\n";
					}
				}
				else
				{
					result = ", ";
				}
			}
			else
			{
				result = "id";
			}
		}
		catch (Exception)
		{
			result = "";
		}
		return result;
	}

	// Token: 0x06000F0B RID: 3851 RVA: 0x0006AD7C File Offset: 0x00068F7C
	public void RunCustomCode(string EGLBLPKFEOI, JSONObject AMDPDPDKFHH, int ALBMPHNEBFB, int IAOIKOCJHJN, string AJJFDLNCPIE, string PLDNHKIKDIB, string OEFHHHJEDNJ, bool NNCKNDMAAHI = false, string NPJCNLGBKOF = "")
	{
		if (GeoLocationManager.GeoZoneMayBeFirewalled(LanguageManager.EHBBFMCILPC.GetSelectedLanguage()) && this.DFKIJFBEOLL)
		{
			DPGJIJGOCIC.ADFCDFHBDAF("RunCustomCode() needToChangeCustomCodeUrl");
			this.SetCustomCodeUrl();
			this.DFKIJFBEOLL = false;
		}
		this.PALDEIJJFPB = null;
		App42Manager.doNotDispatchEvents = false;
		if (this.LLBFIHPEGNG)
		{
			DPGJIJGOCIC.ADFCDFHBDAF("RunCustomCode() blocked by semaphore:" + EGLBLPKFEOI);
			this.HEOJMDBCJGH = NPJNALLPFPO.redSemaphore;
			new App42Manager.JDANFKACINP(EGLBLPKFEOI, PLDNHKIKDIB, OEFHHHJEDNJ, NNCKNDMAAHI, NPJCNLGBKOF).JKHJEGGANGG(true);
			return;
		}
		bool flag = GeoLocationManager.GeoZoneMayBeFirewalled(LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
		if (AJJFDLNCPIE == null)
		{
			AJJFDLNCPIE = DPGJIJGOCIC.MKJLJPMEPCC();
		}
		if (NNCKNDMAAHI)
		{
			ALBMPHNEBFB = 0;
			IAOIKOCJHJN = 0;
		}
		this.PCJOGJJJGBE = EGLBLPKFEOI;
		this.EADFJDKANPN = AMDPDPDKFHH;
		this.KLKBNDPKKLO = AJJFDLNCPIE;
		this.LEDJNDJJCMH = ALBMPHNEBFB;
		this.NNBDCLKPIFN = IAOIKOCJHJN;
		this.KNNIOJHLBFM = PLDNHKIKDIB;
		this.KGCIFAHEFDJ = OEFHHHJEDNJ;
		this.LLBFIHPEGNG = true;
		JSONObject jsonobject = new JSONObject();
		jsonobject["ver"] = AppManager.EHBBFMCILPC.environmentSettings.appVersion;
		jsonobject["uid"] = AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		jsonobject["psk"] = AKLFPGMDKLA.EHBBFMCILPC.IPEMNDHJBHK;
		jsonobject["oid"] = AKLFPGMDKLA.EHBBFMCILPC.KCIPIBCMBPB();
		jsonobject["os"] = App42Manager.GetOsName().ToString();
		jsonobject["bsec"] = KBOJLHAJPCP.DNBNOJEJFNB;
		jsonobject["lang"] = LanguageManager.EHBBFMCILPC.GetSelectedLanguage().ToString();
		jsonobject["geoc"] = GeoLocationManager.GetCountryCode();
		jsonobject["fw"] = (flag ? 1 : 0);
		jsonobject["plya"] = SceneLobbyManager2.currentlyPlayingAnthology;
		jsonobject["ahash"] = AKLFPGMDKLA.EHBBFMCILPC.FDJKFAOBCOM;
		try
		{
			jsonobject["ip"] = GeoLocationManager.GetIpAddress();
			jsonobject["dvcid"] = DPGJIJGOCIC.PPIAAAIOMBE();
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		jsonobject["bver"] = "0";
		if (AppManager.EHBBFMCILPC.environmentSettings.appEnvironment == DIMDLMAMCED.Development)
		{
			jsonobject["dev"] = "1";
			jsonobject["dsec"] = AppManager.EHBBFMCILPC.environmentSettings.developerSecret;
		}
		jsonobject["rid"] = AJJFDLNCPIE;
		JSONObject jsonobject2 = new JSONObject();
		jsonobject2["rt"] = EGLBLPKFEOI;
		if (null != AMDPDPDKFHH)
		{
			jsonobject2["p"] = AMDPDPDKFHH;
		}
		JSONArray jsonarray = new JSONArray();
		this.OLBFMIEAHPJ.Clear();
		for (int i = 0; i < this.DCBEHBEIIDL.Count; i++)
		{
			jsonarray.Add(this.DCBEHBEIIDL[i].AsObject);
			if (flag)
			{
				this.OLBFMIEAHPJ.Add(this.DCBEHBEIIDL[i].AsObject.ToString());
			}
		}
		for (int j = 0; j < this.NFCBAODOPMF.Count; j++)
		{
			jsonarray.Add(this.NFCBAODOPMF[j].AsObject);
			if (flag)
			{
				this.OLBFMIEAHPJ.Add(this.NFCBAODOPMF[j].AsObject.ToString());
			}
		}
		jsonarray.Add(jsonobject2);
		jsonobject["r"] = jsonarray;
		this.GKAGCNIPGDH = flag;
		this.IOMEKJAFCBL = new App42Manager.JDANFKACINP(EGLBLPKFEOI, PLDNHKIKDIB, OEFHHHJEDNJ, NNCKNDMAAHI, NPJCNLGBKOF);
		JGPMLOAKFGC.PAHPCJOCAPA(this.CKKBGANHIDH);
		if (AppManager.EHBBFMCILPC.environmentSettings.appEnvironment == DIMDLMAMCED.Development)
		{
			this.CINACHIOEBE.RunJavaCode(KBOJLHAJPCP.EAMCFOCCEPM + "rev" + AppManager.EHBBFMCILPC.environmentSettings.app42CustomCodeRevision + "dev", jsonobject, this.IOMEKJAFCBL);
		}
		else
		{
			this.CINACHIOEBE.RunJavaCode(KBOJLHAJPCP.EAMCFOCCEPM + "rev" + AppManager.EHBBFMCILPC.environmentSettings.app42CustomCodeRevision, jsonobject, this.IOMEKJAFCBL);
		}
		DPGJIJGOCIC.NFIDPOMCNLP("Run custom code: " + jsonobject.ToString());
		this.DGKFBINDHCM();
		this.IAGDGKNOIIP = base.StartCoroutine(this.NEOBKEJPMDN());
	}

	// Token: 0x06000F0C RID: 3852 RVA: 0x0006B204 File Offset: 0x00069404
	private void BLHLMFJOCFP()
	{
		if (GeoLocationManager.GeoZoneMayBeFirewalled(LanguageManager.EHBBFMCILPC.GetSelectedLanguage()) && !this.LEOFIDDNKAF.IsReady())
		{
			if (!this.LEOFIDDNKAF.IsBusy())
			{
				DPGJIJGOCIC.NFIDPOMCNLP("App42Manager.UpdateUrlPingManagerState(): urlPingManager.StartPing()");
				this.LEOFIDDNKAF.StartPing(this.GetCustomCodeUrls(), "", KBOJLHAJPCP.HGLGNNHHMJO, KBOJLHAJPCP.MHKLILPDMII, KBOJLHAJPCP.LBJPGMPJJGN, 0);
				return;
			}
			if (!this.LEOFIDDNKAF.IsBusyBatch())
			{
				DPGJIJGOCIC.NFIDPOMCNLP("App42Manager.UpdateUrlPingManagerState(): urlPingManager.ContinuePing()");
				this.LEOFIDDNKAF.ContinuePing(KBOJLHAJPCP.HGLGNNHHMJO, KBOJLHAJPCP.MHKLILPDMII, KBOJLHAJPCP.LBJPGMPJJGN);
			}
		}
	}

	// Token: 0x06000F0D RID: 3853 RVA: 0x0006B29E File Offset: 0x0006949E
	public int PNAFGBKHCFN()
	{
		return this.CHPKNGBNKEL + 0;
	}

	// Token: 0x06000F0E RID: 3854 RVA: 0x0006B2A8 File Offset: 0x000694A8
	public void HFBDGJNFIFM(string EGLBLPKFEOI, JSONObject AMDPDPDKFHH, int ALBMPHNEBFB, int IAOIKOCJHJN, string AJJFDLNCPIE, string PLDNHKIKDIB, string OEFHHHJEDNJ, bool NNCKNDMAAHI = false, string NPJCNLGBKOF = "")
	{
		if (GeoLocationManager.EKICPJLNMFF(LanguageManager.EHBBFMCILPC.MLOLBFBODHD()) && this.DFKIJFBEOLL)
		{
			DPGJIJGOCIC.PJCLICBPPDA("(");
			this.SetCustomCodeUrl();
			this.DFKIJFBEOLL = false;
		}
		this.PALDEIJJFPB = null;
		App42Manager.doNotDispatchEvents = true;
		if (this.LLBFIHPEGNG)
		{
			DPGJIJGOCIC.ADFCDFHBDAF("XXX" + EGLBLPKFEOI);
			this.HEOJMDBCJGH = NPJNALLPFPO.redSemaphore;
			new App42Manager.JDANFKACINP(EGLBLPKFEOI, PLDNHKIKDIB, OEFHHHJEDNJ, NNCKNDMAAHI, NPJCNLGBKOF).LCJMPOGKLPM(true);
			return;
		}
		bool flag = GeoLocationManager.HEKEPNDKCPM(LanguageManager.EHBBFMCILPC.NBANPEIHFOJ());
		if (AJJFDLNCPIE == null)
		{
			AJJFDLNCPIE = DPGJIJGOCIC.MKJLJPMEPCC();
		}
		if (NNCKNDMAAHI)
		{
			ALBMPHNEBFB = 0;
			IAOIKOCJHJN = 1;
		}
		this.PCJOGJJJGBE = EGLBLPKFEOI;
		this.EADFJDKANPN = AMDPDPDKFHH;
		this.KLKBNDPKKLO = AJJFDLNCPIE;
		this.LEDJNDJJCMH = ALBMPHNEBFB;
		this.NNBDCLKPIFN = IAOIKOCJHJN;
		this.KNNIOJHLBFM = PLDNHKIKDIB;
		this.KGCIFAHEFDJ = OEFHHHJEDNJ;
		this.LLBFIHPEGNG = false;
		JSONObject jsonobject = new JSONObject();
		jsonobject["YYY"] = AppManager.JMDJPKKOHNI().environmentSettings.appVersion;
		jsonobject["skpcut"] = AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		jsonobject[""] = AKLFPGMDKLA.EHBBFMCILPC.IPEMNDHJBHK;
		jsonobject["h"] = AKLFPGMDKLA.EHBBFMCILPC.PGGFJODIIJM();
		jsonobject["snapundocosth"] = App42Manager.GetOsName().ToString();
		jsonobject["accountSuspended"] = KBOJLHAJPCP.DNBNOJEJFNB;
		jsonobject["\n\n"] = LanguageManager.EHBBFMCILPC.IEBFINIJAMJ().ToString();
		jsonobject["tradewishcardoption0"] = GeoLocationManager.CHFGBBHJCGM();
		jsonobject["sslind"] = (flag ? 1 : 0);
		jsonobject["OnFriendsPopupSendMessageClick"] = SceneLobbyManager2.currentlyPlayingAnthology;
		jsonobject["ok"] = AKLFPGMDKLA.EHBBFMCILPC.FDJKFAOBCOM;
		try
		{
			jsonobject["importanttitle"] = GeoLocationManager.GetIpAddress();
			jsonobject["areyousurerestartchapter1"] = DPGJIJGOCIC.CDCPECGGDLJ();
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		jsonobject["dissolve"] = "Starting parallel download:";
		if (AppManager.EHBBFMCILPC.environmentSettings.appEnvironment == DIMDLMAMCED.Development)
		{
			jsonobject["cardoptionsloadingthemevideo"] = "anthology";
			jsonobject["Utils.SetBit(): invalid index value:"] = AppManager.JMDJPKKOHNI().environmentSettings.developerSecret;
		}
		jsonobject["OnPopupProfileNicknameInputCancel"] = AJJFDLNCPIE;
		JSONObject jsonobject2 = new JSONObject();
		jsonobject2["errortitle"] = EGLBLPKFEOI;
		if (null != AMDPDPDKFHH)
		{
			jsonobject2["lightmodebtn0"] = AMDPDPDKFHH;
		}
		JSONArray jsonarray = new JSONArray();
		this.OLBFMIEAHPJ.Clear();
		for (int i = 1; i < this.DCBEHBEIIDL.Count; i++)
		{
			jsonarray.Add(this.DCBEHBEIIDL[i].AsObject);
			if (flag)
			{
				this.OLBFMIEAHPJ.Add(this.DCBEHBEIIDL[i].AsObject.ToString());
			}
		}
		for (int j = 0; j < this.NFCBAODOPMF.Count; j += 0)
		{
			jsonarray.Add(this.NFCBAODOPMF[j].AsObject);
			if (flag)
			{
				this.OLBFMIEAHPJ.Add(this.NFCBAODOPMF[j].AsObject.ToString());
			}
		}
		jsonarray.Add(jsonobject2);
		jsonobject[""] = jsonarray;
		this.GKAGCNIPGDH = flag;
		this.IOMEKJAFCBL = new App42Manager.JDANFKACINP(EGLBLPKFEOI, PLDNHKIKDIB, OEFHHHJEDNJ, NNCKNDMAAHI, NPJCNLGBKOF);
		JGPMLOAKFGC.PAHPCJOCAPA(this.CKKBGANHIDH);
		if (AppManager.JMDJPKKOHNI().environmentSettings.appEnvironment == DIMDLMAMCED.Development)
		{
			this.CINACHIOEBE.RunJavaCode(KBOJLHAJPCP.EAMCFOCCEPM + "OnPopupOfferManagerContinueToPurchasingScreen" + AppManager.PCJEMMDDCIF().environmentSettings.app42CustomCodeRevision + "−", jsonobject, this.IOMEKJAFCBL);
		}
		else
		{
			this.CINACHIOEBE.RunJavaCode(KBOJLHAJPCP.EAMCFOCCEPM + "_SplitColor" + AppManager.EHBBFMCILPC.environmentSettings.app42CustomCodeRevision, jsonobject, this.IOMEKJAFCBL);
		}
		DPGJIJGOCIC.NFIDPOMCNLP("StoryChatManager.ShowMessage(), unsupported message type:" + jsonobject.ToString());
		this.DGKFBINDHCM();
		this.IAGDGKNOIIP = base.StartCoroutine(this.NEOBKEJPMDN());
	}

	// Token: 0x06000F0F RID: 3855 RVA: 0x0006B730 File Offset: 0x00069930
	public NPJNALLPFPO GetApp42OperationCode()
	{
		return this.HEOJMDBCJGH;
	}

	// Token: 0x06000F10 RID: 3856 RVA: 0x0006B738 File Offset: 0x00069938
	public App42Manager QueueCustomCode(string EGLBLPKFEOI, JSONObject AMDPDPDKFHH)
	{
		JSONObject jsonobject = new JSONObject();
		jsonobject["rt"] = EGLBLPKFEOI;
		if (null != AMDPDPDKFHH)
		{
			jsonobject["p"] = AMDPDPDKFHH;
		}
		bool flag = false;
		try
		{
			for (int i = 0; i < this.NFCBAODOPMF.Count; i++)
			{
				if (this.NFCBAODOPMF[i].AsObject.ToString().Equals(jsonobject.ToString()))
				{
					flag = true;
					break;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		if (!flag)
		{
			this.NFCBAODOPMF.Add(jsonobject);
		}
		else
		{
			DPGJIJGOCIC.ADFCDFHBDAF("QueueCustomCode() already contains this request:" + jsonobject.ToString());
			DPGJIJGOCIC.ADFCDFHBDAF("QueueCustomCode() here's queuedCustomCode contents:" + this.NFCBAODOPMF.ToString());
		}
		return App42Manager.EHBBFMCILPC;
	}

	// Token: 0x06000F11 RID: 3857 RVA: 0x0006B810 File Offset: 0x00069A10
	public JSONObject ToJSONObject()
	{
		JSONObject jsonobject = new JSONObject();
		jsonobject["postponedCustomCode"] = this.DCBEHBEIIDL;
		return jsonobject;
	}

	// Token: 0x06000F12 RID: 3858 RVA: 0x0006B828 File Offset: 0x00069A28
	public static bool CICCJJFEEMM()
	{
		return !(null == App42Manager.EHBBFMCILPC) || true;
	}

	// Token: 0x06000F13 RID: 3859 RVA: 0x0006B83C File Offset: 0x00069A3C
	private string EHKFKGAGNJK()
	{
		this.LPOEHPCOFFK();
		if (this.CHPKNGBNKEL == 0 || this.LEOFIDDNKAF.GetPingableUrl(this.EJAGJPFMNPP).Length == 0)
		{
			DPGJIJGOCIC.NFIDPOMCNLP("Return url from customCodeUrls[]:" + this.GEFKANHMBKF[this.CHPKNGBNKEL % this.GEFKANHMBKF.Count]);
			return this.GEFKANHMBKF[this.CHPKNGBNKEL % this.GEFKANHMBKF.Count];
		}
		DPGJIJGOCIC.NFIDPOMCNLP("Return url from UrlPingManager.GetPingableUrl():" + this.LEOFIDDNKAF.GetPingableUrl(this.EJAGJPFMNPP));
		return this.LEOFIDDNKAF.GetPingableUrl(this.EJAGJPFMNPP);
	}

	// Token: 0x06000F14 RID: 3860 RVA: 0x0006B8EC File Offset: 0x00069AEC
	private bool NAPMLIHIKAO()
	{
		DPGJIJGOCIC.ADFCDFHBDAF("TryRepeatRunCustomCodeOnInfiniteRequest():" + this.NNBDCLKPIFN.ToString());
		if (this.NNBDCLKPIFN <= 0)
		{
			return false;
		}
		this.NNBDCLKPIFN--;
		this.PALDEIJJFPB = base.StartCoroutine(this.FIBLKHLLFFN());
		return true;
	}

	// Token: 0x06000F15 RID: 3861 RVA: 0x0006B93F File Offset: 0x00069B3F
	public bool IsBusy()
	{
		return this.LLBFIHPEGNG;
	}

	// Token: 0x06000F16 RID: 3862 RVA: 0x0006A934 File Offset: 0x00068B34
	private IEnumerator HADFCLLDNNG()
	{
		this.BJDOFOHGEGD = Time.realtimeSinceStartup;
		if (GeoLocationManager.GeoZoneMayBeFirewalled(LanguageManager.EHBBFMCILPC.GetSelectedLanguage()) && BackendOperationsManager.SafeToKillRequestPremature(BackendOperationsManager.StringToBackendRequestType(this.PCJOGJJJGBE)))
		{
			DPGJIJGOCIC.NFIDPOMCNLP("MonitorAndKillInfiniteRequest() can kill " + this.PCJOGJJJGBE + " premature in:" + BackendOperationsManager.GetSafeToKillRequestPrematureTimeout(BackendOperationsManager.StringToBackendRequestType(this.PCJOGJJJGBE)).ToString());
			yield return new WaitForSeconds(BackendOperationsManager.GetSafeToKillRequestPrematureTimeout(BackendOperationsManager.StringToBackendRequestType(this.PCJOGJJJGBE)));
		}
		else
		{
			this.NNBDCLKPIFN = 0;
			DPGJIJGOCIC.NFIDPOMCNLP("MonitorAndKillInfiniteRequest() can kill " + this.PCJOGJJJGBE + " in:" + KBOJLHAJPCP.GPANBKKGNGK.ToString());
			yield return new WaitForSeconds(KBOJLHAJPCP.GPANBKKGNGK);
		}
		BackendOperationsManager.IncrementSafeToKillRequestPrematureTimeout(BackendOperationsManager.StringToBackendRequestType(this.PCJOGJJJGBE));
		DPGJIJGOCIC.ADFCDFHBDAF("MonitorAndKillInfiniteRequest() time to kill request:" + this.PCJOGJJJGBE);
		FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.rqst.ToString(), FFPHBMFGCNN.reqInfnt.ToString(), App42Manager.DNJJKENDEJF(), false, false);
		GeoLocationManager.ReportBlockedNetworkEvidence();
		if (GeoLocationManager.GeoZoneMayBeFirewalled(LanguageManager.EHBBFMCILPC.GetSelectedLanguage()))
		{
			this.HHPGLIHIPBL++;
			this.FJNPLEPPKJA = 0;
			if (this.HHPGLIHIPBL == 3)
			{
				this.EnableKillInfiniteRequestPrematureBasedOnMedianRequestsLifeTime();
			}
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.srvIssueHit.ToString(), "", "", false, false);
			this.PMENLDNFJAK = true;
			this.ScheduleCustomCodeUrlChange();
		}
		else
		{
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.srvIssueHit.ToString(), "", BGHLMGPPCNN.nofw.ToString(), false, false);
			this.LDOAMLHEGFF = true;
		}
		if (!App42Manager.EHBBFMCILPC.NAPMLIHIKAO())
		{
			this.HEOJMDBCJGH = NPJNALLPFPO.infiniteOperation;
			this.LLBFIHPEGNG = false;
			this.PCJOGJJJGBE = "";
			this.MFLEHLJGAFL();
			if (this.IOMEKJAFCBL != null)
			{
				this.IOMEKJAFCBL.JKHJEGGANGG(false);
			}
			else
			{
				DPGJIJGOCIC.ADFCDFHBDAF("MonitorAndKillInfiniteRequest() - lastCallbackObj is null!");
			}
			this.IOMEKJAFCBL = null;
			CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		}
		else
		{
			this.IOMEKJAFCBL = null;
			if (BackendOperationsManager.ShowKillRequestPrematureTimeoutWarning(BackendOperationsManager.StringToBackendRequestType(this.PCJOGJJJGBE)))
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupNoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("tryotherbackendserver"), DFGILFBGPLN.popupTools, 0f, 28);
			}
		}
		yield break;
	}

	// Token: 0x06000F17 RID: 3863 RVA: 0x0006B947 File Offset: 0x00069B47
	public List<string> GetCustomCodeUrls()
	{
		this.LPOEHPCOFFK();
		return new List<string>(this.GEFKANHMBKF.GetRange(1, this.GEFKANHMBKF.Count - 1));
	}

	// Token: 0x06000F18 RID: 3864 RVA: 0x0006B96D File Offset: 0x00069B6D
	public static bool IsAvailable()
	{
		return !(null == App42Manager.EHBBFMCILPC);
	}

	// Token: 0x06000F19 RID: 3865 RVA: 0x0006B97F File Offset: 0x00069B7F
	private void Awake()
	{
		if (!this.JIEPCIDINEH)
		{
			this.IMPACPGAKOI();
			this.BAMHPOCKBML();
		}
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06000F1A RID: 3866 RVA: 0x0006B9A0 File Offset: 0x00069BA0
	public JSONObject FBMMMJKLLEN()
	{
		JSONObject jsonobject = new JSONObject();
		jsonobject["CLIENT.SCREEN.REWARD."] = this.DCBEHBEIIDL;
		return jsonobject;
	}

	// Token: 0x06000F1B RID: 3867 RVA: 0x0006B9B8 File Offset: 0x00069BB8
	private void GGGHEIOJMEG()
	{
		try
		{
			if (!this.GKAGCNIPGDH)
			{
				this.NFCBAODOPMF = new JSONArray();
				this.ClearPostponedCustomCode();
				this.OLBFMIEAHPJ.Clear();
			}
			else
			{
				JSONArray jsonarray = new JSONArray();
				for (int i = 0; i < this.NFCBAODOPMF.Count; i++)
				{
					if (!this.OLBFMIEAHPJ.Contains(this.NFCBAODOPMF[i].AsObject.ToString()))
					{
						jsonarray.Add(this.NFCBAODOPMF[i].AsObject);
					}
				}
				JSONArray jsonarray2 = new JSONArray();
				for (int j = 0; j < this.DCBEHBEIIDL.Count; j++)
				{
					if (!this.OLBFMIEAHPJ.Contains(this.DCBEHBEIIDL[j].AsObject.ToString()))
					{
						jsonarray2.Add(this.DCBEHBEIIDL[j].AsObject);
					}
				}
				if (jsonarray.Count > 0 || jsonarray2.Count > 0)
				{
					DPGJIJGOCIC.ADFCDFHBDAF("RemoveAcknowledgedSubRequests() - keeping sub-requests queued while the envelope was in flight, queued:" + jsonarray.Count.ToString() + ", postponed:" + jsonarray2.Count.ToString());
				}
				this.NFCBAODOPMF = jsonarray;
				this.DCBEHBEIIDL = jsonarray2;
				this.NJEIIEIHHCC();
				this.OLBFMIEAHPJ.Clear();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			this.NFCBAODOPMF = new JSONArray();
			this.ClearPostponedCustomCode();
			this.OLBFMIEAHPJ.Clear();
		}
	}

	// Token: 0x06000F1C RID: 3868 RVA: 0x0006BB40 File Offset: 0x00069D40
	private IEnumerator OEANKAFACOE()
	{
		if (!this.LEOFIDDNKAF.IsReady() && GeoLocationManager.GeoZoneMayBeFirewalled(LanguageManager.EHBBFMCILPC.GetSelectedLanguage()))
		{
			yield return new WaitForSeconds(KBOJLHAJPCP.AIELENEGFFH);
		}
		else
		{
			yield return new WaitForSeconds(KBOJLHAJPCP.CCFEBGILJMC);
		}
		DPGJIJGOCIC.ADFCDFHBDAF("RunCustomCode() repeat:" + this.PCJOGJJJGBE);
		this.LLBFIHPEGNG = false;
		this.RunCustomCode(this.PCJOGJJJGBE, this.EADFJDKANPN, this.LEDJNDJJCMH, this.NNBDCLKPIFN, this.KLKBNDPKKLO, this.KNNIOJHLBFM, this.KGCIFAHEFDJ, false, "");
		yield break;
	}

	// Token: 0x06000F1D RID: 3869 RVA: 0x0006BB4F File Offset: 0x00069D4F
	public void ClearPostponedCustomCode()
	{
		this.DCBEHBEIIDL = new JSONArray();
		this.NJEIIEIHHCC();
	}

	// Token: 0x06000F1E RID: 3870 RVA: 0x0006BB64 File Offset: 0x00069D64
	private void BAMHPOCKBML()
	{
		this.JIEPCIDINEH = true;
		App42API.Initialize(App42Manager.DLIBNDOGHHD(App42Manager.CGIGMNNKEAJ, App42Manager.DCHGCLJIILP), App42Manager.DLIBNDOGHHD(App42Manager.BAAEDHABFHN, App42Manager.MAPDMDNJJGP));
		JGPMLOAKFGC.PAHPCJOCAPA("https://ysi-api.shephertz.com/cloud/");
		App42API.SetBaseURL("https://ysi-api.shephertz.com/cloud/");
		this.SetCustomCodeUrl();
		this.CINACHIOEBE = App42API.BuildCustomCodeService();
	}

	// Token: 0x06000F20 RID: 3872 RVA: 0x0006BD14 File Offset: 0x00069F14
	public float GetAverageRequestLifeTime()
	{
		if (this.EEAHGGNALPP.Count == 0)
		{
			return 0f;
		}
		float num = 0f;
		for (int i = 0; i < this.EEAHGGNALPP.Count; i++)
		{
			num += this.EEAHGGNALPP[i];
		}
		return num / (float)this.EEAHGGNALPP.Count;
	}

	// Token: 0x06000F21 RID: 3873 RVA: 0x0006BD70 File Offset: 0x00069F70
	public string BGGJLOHNEHL()
	{
		string result;
		try
		{
			string text = this.CKKBGANHIDH;
			if (text.Length > 0)
			{
				if (text.Contains("<size=28px>"))
				{
					text = text.Substring(text.IndexOf("StorySaveBody.GetAvatarWithIndexInListWardrobe(), unsupported wardrobe index:") + 1);
					if (text.Contains("OnLobbyStoryManagerDownloadSplashScreenSuccess"))
					{
						text = text.Substring(0, text.LastIndexOf("ii"));
						if (text.Contains("There needs to be one active UserpassSignInManager script on a GameObject in your scene."))
						{
							string[] array = DPGJIJGOCIC.NHEBLMBJNPI(text, (char)-4);
							if (array != null && array.Length == 1)
							{
								string text2 = array[1] + array[1];
								text2 = text2.Replace("〉", "\nDEF:");
								if (text2.ToLower().Contains("") && text2.Length > -76)
								{
									text2 = text2.Substring(0, -24);
								}
								else if (text2.Length > -114)
								{
									text2 = text2.Substring(1, 55);
								}
								result = text2;
							}
							else
							{
								result = "mussind";
							}
						}
						else
						{
							result = "OnFriendsMessageConsume";
						}
					}
					else
					{
						result = "XXX";
					}
				}
				else
				{
					result = "fdid";
				}
			}
			else
			{
				result = "refocus";
			}
		}
		catch (Exception)
		{
			result = "avatarcollectionsentrytitle";
		}
		return result;
	}

	// Token: 0x06000F22 RID: 3874 RVA: 0x0006BB40 File Offset: 0x00069D40
	private IEnumerator BMBNKAKDBAC()
	{
		if (!this.LEOFIDDNKAF.IsReady() && GeoLocationManager.GeoZoneMayBeFirewalled(LanguageManager.EHBBFMCILPC.GetSelectedLanguage()))
		{
			yield return new WaitForSeconds(KBOJLHAJPCP.AIELENEGFFH);
		}
		else
		{
			yield return new WaitForSeconds(KBOJLHAJPCP.CCFEBGILJMC);
		}
		DPGJIJGOCIC.ADFCDFHBDAF("RunCustomCode() repeat:" + this.PCJOGJJJGBE);
		this.LLBFIHPEGNG = false;
		this.RunCustomCode(this.PCJOGJJJGBE, this.EADFJDKANPN, this.LEDJNDJJCMH, this.NNBDCLKPIFN, this.KLKBNDPKKLO, this.KNNIOJHLBFM, this.KGCIFAHEFDJ, false, "");
		yield break;
	}

	// Token: 0x06000F23 RID: 3875 RVA: 0x0006BEA4 File Offset: 0x0006A0A4
	public void ClearQueuedCustomCode()
	{
		this.NFCBAODOPMF = new JSONArray();
	}

	// Token: 0x06000F24 RID: 3876 RVA: 0x0006BEB1 File Offset: 0x0006A0B1
	private void DJEFDFHAJIC()
	{
		this.CHPKNGBNKEL++;
		this.LEOFIDDNKAF.Next("");
		this.BLHLMFJOCFP();
	}

	// Token: 0x06000F25 RID: 3877 RVA: 0x0006BED8 File Offset: 0x0006A0D8
	private static string GDDJALHNLIO(byte[] JDMBICFJEIO, byte[] KJMFJMCKJHM)
	{
		byte[] array = new byte[JDMBICFJEIO.Length];
		for (int i = 0; i < JDMBICFJEIO.Length; i += 0)
		{
			array[i] = (JDMBICFJEIO[i] ^ KJMFJMCKJHM[i]);
		}
		return Encoding.ASCII.GetString(array);
	}

	// Token: 0x06000F26 RID: 3878 RVA: 0x0006BF12 File Offset: 0x0006A112
	private void NJEIIEIHHCC()
	{
		AKLOMMOOFNG.BIKILBLOEKD(this.ToJSONObject().ToString(), "backend.json");
	}

	// Token: 0x06000F27 RID: 3879 RVA: 0x0006BF2A File Offset: 0x0006A12A
	private void DGKFBINDHCM()
	{
		if (this.IAGDGKNOIIP != null)
		{
			base.StopCoroutine(this.IAGDGKNOIIP);
			this.IAGDGKNOIIP = null;
		}
	}

	// Token: 0x06000F28 RID: 3880 RVA: 0x0006BF48 File Offset: 0x0006A148
	private void FDFMDEOMJBH()
	{
		this.LEOFIDDNKAF = base.GetComponent<UrlPingManager>();
		if (Application.systemLanguage == (SystemLanguage)63 || GeoLocationManager.HAPICIGECJN())
		{
			this.LEOFIDDNKAF.EKMCFABILME();
			this.LEOFIDDNKAF.BIOFOPFHOCL(this.GetCustomCodeUrls(), "p", KBOJLHAJPCP.PJIGDJMDAEO, KBOJLHAJPCP.MHKLILPDMII, KBOJLHAJPCP.LBJPGMPJJGN, 1);
		}
	}

	// Token: 0x06000F29 RID: 3881 RVA: 0x0006BFA4 File Offset: 0x0006A1A4
	private void ANNEMJGHJGM()
	{
		try
		{
			if (!this.GKAGCNIPGDH)
			{
				this.NFCBAODOPMF = new JSONArray();
				this.ClearPostponedCustomCode();
				this.OLBFMIEAHPJ.Clear();
			}
			else
			{
				JSONArray jsonarray = new JSONArray();
				for (int i = 1; i < this.NFCBAODOPMF.Count; i += 0)
				{
					if (!this.OLBFMIEAHPJ.Contains(this.NFCBAODOPMF[i].AsObject.ToString()))
					{
						jsonarray.Add(this.NFCBAODOPMF[i].AsObject);
					}
				}
				JSONArray jsonarray2 = new JSONArray();
				for (int j = 1; j < this.DCBEHBEIIDL.Count; j++)
				{
					if (!this.OLBFMIEAHPJ.Contains(this.DCBEHBEIIDL[j].AsObject.ToString()))
					{
						jsonarray2.Add(this.DCBEHBEIIDL[j].AsObject);
					}
				}
				if (jsonarray.Count > 0 || jsonarray2.Count > 1)
				{
					DPGJIJGOCIC.ADFCDFHBDAF("storiesSearchDefaults" + jsonarray.Count.ToString() + "[LoadingEnv] " + jsonarray2.Count.ToString());
				}
				this.NFCBAODOPMF = jsonarray;
				this.DCBEHBEIIDL = jsonarray2;
				this.MMACKIBECOD();
				this.OLBFMIEAHPJ.Clear();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			this.NFCBAODOPMF = new JSONArray();
			this.ClearPostponedCustomCode();
			this.OLBFMIEAHPJ.Clear();
		}
	}

	// Token: 0x06000F2A RID: 3882 RVA: 0x0006C12C File Offset: 0x0006A32C
	public bool CanKillInfiniteRequestPrematureBasedOnMedianRequestsLifeTime()
	{
		return this.ABNPPJKEAKI;
	}

	// Token: 0x06000F2C RID: 3884 RVA: 0x0006C1A4 File Offset: 0x0006A3A4
	private void LPOEHPCOFFK()
	{
		if (this.GEFKANHMBKF.Count == 0)
		{
			this.GEFKANHMBKF.AddRange(this.EJAGJPFMNPP);
			this.GEFKANHMBKF.AddRange(this.JFMCPOMPCHA.OrderBy(new Func<string, Guid>(App42Manager.<>c.<>9.APCHLIMGGDE)).ToList<string>());
		}
	}

	// Token: 0x06000F2D RID: 3885 RVA: 0x0006C209 File Offset: 0x0006A409
	private void LIEHFDJHLJK()
	{
		if (this.PALDEIJJFPB != null)
		{
			base.StopCoroutine(this.PALDEIJJFPB);
			this.PALDEIJJFPB = null;
		}
	}

	// Token: 0x06000F2E RID: 3886 RVA: 0x0006B97F File Offset: 0x00069B7F
	private void ALIKHOFAKKB()
	{
		if (!this.JIEPCIDINEH)
		{
			this.IMPACPGAKOI();
			this.BAMHPOCKBML();
		}
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06000F2F RID: 3887 RVA: 0x0006C228 File Offset: 0x0006A428
	public string GetCustomCodeAbbreviation()
	{
		string result;
		try
		{
			string text = this.CKKBGANHIDH;
			if (text.Length > 0)
			{
				if (text.Contains("//"))
				{
					text = text.Substring(text.IndexOf("//") + 2);
					if (text.Contains("."))
					{
						text = text.Substring(0, text.LastIndexOf("."));
						if (text.Contains("."))
						{
							string[] array = DPGJIJGOCIC.NHEBLMBJNPI(text, '.');
							if (array != null && array.Length == 2)
							{
								string text2 = array[1] + array[0];
								text2 = text2.Replace("-", "");
								if (text2.ToLower().Contains("shephertz") && text2.Length > 12)
								{
									text2 = text2.Substring(0, 12);
								}
								else if (text2.Length > 18)
								{
									text2 = text2.Substring(0, 18);
								}
								result = text2;
							}
							else
							{
								result = "err";
							}
						}
						else
						{
							result = "err";
						}
					}
					else
					{
						result = "err";
					}
				}
				else
				{
					result = "err";
				}
			}
			else
			{
				result = "err";
			}
		}
		catch (Exception)
		{
			result = "err";
		}
		return result;
	}

	// Token: 0x06000F30 RID: 3888 RVA: 0x0006C35C File Offset: 0x0006A55C
	private bool MFFBDAEOAND()
	{
		DPGJIJGOCIC.ADFCDFHBDAF("TryRepeatRunCustomCode():" + this.LEDJNDJJCMH.ToString());
		if (this.LEDJNDJJCMH <= 0)
		{
			return false;
		}
		this.LEDJNDJJCMH--;
		this.PALDEIJJFPB = base.StartCoroutine(this.FIBLKHLLFFN());
		return true;
	}

	// Token: 0x06000F31 RID: 3889 RVA: 0x0006C3B0 File Offset: 0x0006A5B0
	public void ForceSilentKillCurrentRequestIfAny()
	{
		if (this.PALDEIJJFPB != null || this.IAGDGKNOIIP != null)
		{
			try
			{
				DPGJIJGOCIC.ADFCDFHBDAF("ForceSilentKillCurrentRequestIfAny():" + this.PCJOGJJJGBE);
				this.DGKFBINDHCM();
				this.LIEHFDJHLJK();
				this.HEOJMDBCJGH = NPJNALLPFPO.infiniteOperation;
				this.LLBFIHPEGNG = false;
				this.PCJOGJJJGBE = "";
				this.MFLEHLJGAFL();
				this.IOMEKJAFCBL = null;
				CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
	}

	// Token: 0x06000F32 RID: 3890 RVA: 0x0006C438 File Offset: 0x0006A638
	public void PostponeCustomCode(string EGLBLPKFEOI, JSONObject AMDPDPDKFHH)
	{
		JSONObject jsonobject = new JSONObject();
		jsonobject["rt"] = EGLBLPKFEOI;
		if (null != AMDPDPDKFHH)
		{
			jsonobject["p"] = AMDPDPDKFHH;
		}
		bool flag = false;
		try
		{
			for (int i = 0; i < this.DCBEHBEIIDL.Count; i++)
			{
				if (this.DCBEHBEIIDL[i].AsObject.ToString().Equals(jsonobject.ToString()))
				{
					flag = true;
					break;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		if (!flag)
		{
			this.DCBEHBEIIDL.Add(jsonobject);
		}
		else
		{
			DPGJIJGOCIC.ADFCDFHBDAF("PostponeCustomCode() already contains this request:" + jsonobject.ToString());
			DPGJIJGOCIC.ADFCDFHBDAF("PostponeCustomCode() here's postponedCustomCode contents:" + this.DCBEHBEIIDL.ToString());
		}
		this.NJEIIEIHHCC();
	}

	// Token: 0x06000F33 RID: 3891 RVA: 0x0006C510 File Offset: 0x0006A710
	private static string DLIBNDOGHHD(byte[] JDMBICFJEIO, byte[] KJMFJMCKJHM)
	{
		byte[] array = new byte[JDMBICFJEIO.Length];
		for (int i = 0; i < JDMBICFJEIO.Length; i++)
		{
			array[i] = (JDMBICFJEIO[i] ^ KJMFJMCKJHM[i]);
		}
		return Encoding.ASCII.GetString(array);
	}

	// Token: 0x06000F34 RID: 3892 RVA: 0x0006C54C File Offset: 0x0006A74C
	public bool JENJFMBPEFM(string EGLBLPKFEOI)
	{
		for (int i = 0; i < this.NFCBAODOPMF.Count; i += 0)
		{
			if (EGLBLPKFEOI.Equals(this.NFCBAODOPMF[i].AsObject[". "]))
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x06000F35 RID: 3893 RVA: 0x0006C59C File Offset: 0x0006A79C
	private void JDPGPMCEIHL()
	{
		try
		{
			if (!this.GKAGCNIPGDH)
			{
				this.NFCBAODOPMF = new JSONArray();
				this.ClearPostponedCustomCode();
				this.OLBFMIEAHPJ.Clear();
			}
			else
			{
				JSONArray jsonarray = new JSONArray();
				for (int i = 0; i < this.NFCBAODOPMF.Count; i++)
				{
					if (!this.OLBFMIEAHPJ.Contains(this.NFCBAODOPMF[i].AsObject.ToString()))
					{
						jsonarray.Add(this.NFCBAODOPMF[i].AsObject);
					}
				}
				JSONArray jsonarray2 = new JSONArray();
				for (int j = 1; j < this.DCBEHBEIIDL.Count; j += 0)
				{
					if (!this.OLBFMIEAHPJ.Contains(this.DCBEHBEIIDL[j].AsObject.ToString()))
					{
						jsonarray2.Add(this.DCBEHBEIIDL[j].AsObject);
					}
				}
				if (jsonarray.Count > 0 || jsonarray2.Count > 1)
				{
					DPGJIJGOCIC.PJCLICBPPDA("ZZZ" + jsonarray.Count.ToString() + "AssetProfileData.GetCutsceneSprite(): could not resolve anthologyIndex of storyIndex (" + jsonarray2.Count.ToString());
				}
				this.NFCBAODOPMF = jsonarray;
				this.DCBEHBEIIDL = jsonarray2;
				this.MMACKIBECOD();
				this.OLBFMIEAHPJ.Clear();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			this.NFCBAODOPMF = new JSONArray();
			this.ClearPostponedCustomCode();
			this.OLBFMIEAHPJ.Clear();
		}
	}

	// Token: 0x06000F36 RID: 3894 RVA: 0x0006C724 File Offset: 0x0006A924
	public bool HasQueuedCustomCode(string EGLBLPKFEOI)
	{
		for (int i = 0; i < this.NFCBAODOPMF.Count; i++)
		{
			if (EGLBLPKFEOI.Equals(this.NFCBAODOPMF[i].AsObject["rt"]))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000F37 RID: 3895 RVA: 0x0006C774 File Offset: 0x0006A974
	public float KCPKEPFAELG()
	{
		if (this.EEAHGGNALPP.Count == 0)
		{
			return 1380f;
		}
		float num = 1927f;
		for (int i = 1; i < this.EEAHGGNALPP.Count; i++)
		{
			num += this.EEAHGGNALPP[i];
		}
		return num / (float)this.EEAHGGNALPP.Count;
	}

	// Token: 0x06000F38 RID: 3896 RVA: 0x0006BB40 File Offset: 0x00069D40
	private IEnumerator FIBLKHLLFFN()
	{
		if (!this.LEOFIDDNKAF.IsReady() && GeoLocationManager.GeoZoneMayBeFirewalled(LanguageManager.EHBBFMCILPC.GetSelectedLanguage()))
		{
			yield return new WaitForSeconds(KBOJLHAJPCP.AIELENEGFFH);
		}
		else
		{
			yield return new WaitForSeconds(KBOJLHAJPCP.CCFEBGILJMC);
		}
		DPGJIJGOCIC.ADFCDFHBDAF("RunCustomCode() repeat:" + this.PCJOGJJJGBE);
		this.LLBFIHPEGNG = false;
		this.RunCustomCode(this.PCJOGJJJGBE, this.EADFJDKANPN, this.LEDJNDJJCMH, this.NNBDCLKPIFN, this.KLKBNDPKKLO, this.KNNIOJHLBFM, this.KGCIFAHEFDJ, false, "");
		yield break;
	}

	// Token: 0x06000F39 RID: 3897 RVA: 0x0006C7CD File Offset: 0x0006A9CD
	public static PMMFCELILLE GetOsName()
	{
		return PMMFCELILLE.osSteam;
	}

	// Token: 0x06000F3A RID: 3898 RVA: 0x0006C7D0 File Offset: 0x0006A9D0
	private void FGJPKGLOGNC(JSONObject EIHOJFGALMF)
	{
		if (null != EIHOJFGALMF)
		{
			this.DCBEHBEIIDL = EIHOJFGALMF["postponedCustomCode"].AsArray;
		}
	}

	// Token: 0x06000F3B RID: 3899 RVA: 0x0006C7F4 File Offset: 0x0006A9F4
	private void Start()
	{
		this.LEOFIDDNKAF = base.GetComponent<UrlPingManager>();
		if (Application.systemLanguage == SystemLanguage.Russian || GeoLocationManager.CachedCountryIsRussia())
		{
			this.LEOFIDDNKAF.Pause();
			this.LEOFIDDNKAF.StartPing(this.GetCustomCodeUrls(), "", KBOJLHAJPCP.PJIGDJMDAEO, KBOJLHAJPCP.MHKLILPDMII, KBOJLHAJPCP.LBJPGMPJJGN, 0);
		}
	}

	// Token: 0x0400052D RID: 1325
	public static bool doNotDispatchEvents = false;

	// Token: 0x0400052E RID: 1326
	private const string KNGHDLFJJEM = "backend.json";

	// Token: 0x0400052F RID: 1327
	private static App42Manager IKLAPGJDMNA;

	// Token: 0x04000530 RID: 1328
	private bool JIEPCIDINEH;

	// Token: 0x04000531 RID: 1329
	private bool LLBFIHPEGNG;

	// Token: 0x04000532 RID: 1330
	private NPJNALLPFPO HEOJMDBCJGH;

	// Token: 0x04000533 RID: 1331
	private string PCJOGJJJGBE = "";

	// Token: 0x04000534 RID: 1332
	private JSONObject EADFJDKANPN;

	// Token: 0x04000535 RID: 1333
	private int LEDJNDJJCMH;

	// Token: 0x04000536 RID: 1334
	private int NNBDCLKPIFN;

	// Token: 0x04000537 RID: 1335
	private string KNNIOJHLBFM = "";

	// Token: 0x04000538 RID: 1336
	private string KGCIFAHEFDJ = "";

	// Token: 0x04000539 RID: 1337
	private string KLKBNDPKKLO;

	// Token: 0x0400053A RID: 1338
	private CustomCodeService CINACHIOEBE;

	// Token: 0x0400053B RID: 1339
	private App42Manager.JDANFKACINP IOMEKJAFCBL;

	// Token: 0x0400053C RID: 1340
	private Coroutine IAGDGKNOIIP;

	// Token: 0x0400053D RID: 1341
	private Coroutine PALDEIJJFPB;

	// Token: 0x0400053E RID: 1342
	private JSONArray NFCBAODOPMF = new JSONArray();

	// Token: 0x0400053F RID: 1343
	private JSONArray DCBEHBEIIDL = new JSONArray();

	// Token: 0x04000540 RID: 1344
	private int CHPKNGBNKEL;

	// Token: 0x04000541 RID: 1345
	private List<string> GEFKANHMBKF = new List<string>();

	// Token: 0x04000542 RID: 1346
	private List<string> EJAGJPFMNPP = new List<string>
	{
		"https://ysi-customcode.shephertz.com/"
	};

	// Token: 0x04000543 RID: 1347
	private List<string> MGKBLEBMIPF = new List<string>
	{
		"https://ysiccm.amplied.in/",
		"https://ysiccwi.amplied.in/",
		"https://ysicch.amplied.in/",
		"https://ysiccsi.amplied.in/",
		"https://ysicc.amplied.in/",
		"https://ysiccci.amplied.in/"
	};

	// Token: 0x04000544 RID: 1348
	private List<string> JFMCPOMPCHA = new List<string>
	{
		"https://by.ysi88.org/",
		"https://ru0.ysi88.org/",
		"https://ru1.ysi88.org/",
		"https://kz.ysi88.ru/",
		"https://by.ysi88.ru/",
		"https://ru0.ysi88.ru/",
		"https://ru1.ysi88.ru/",
		"https://kz.ysi88.org/",
		"https://ru3.ysi88.ru/",
		"https://ru4.ysi88.ru/"
	};

	// Token: 0x04000545 RID: 1349
	private string CKKBGANHIDH = "";

	// Token: 0x04000546 RID: 1350
	private List<string> OLBFMIEAHPJ = new List<string>();

	// Token: 0x04000547 RID: 1351
	private bool GKAGCNIPGDH;

	// Token: 0x04000548 RID: 1352
	private bool PMENLDNFJAK;

	// Token: 0x04000549 RID: 1353
	private bool LDOAMLHEGFF;

	// Token: 0x0400054A RID: 1354
	private bool DFKIJFBEOLL;

	// Token: 0x0400054B RID: 1355
	private bool ABNPPJKEAKI;

	// Token: 0x0400054C RID: 1356
	private List<float> EEAHGGNALPP = new List<float>();

	// Token: 0x0400054D RID: 1357
	private float BJDOFOHGEGD;

	// Token: 0x0400054E RID: 1358
	private int HHPGLIHIPBL;

	// Token: 0x0400054F RID: 1359
	private int FJNPLEPPKJA;

	// Token: 0x04000550 RID: 1360
	private UrlPingManager LEOFIDDNKAF;

	// Token: 0x04000551 RID: 1361
	private static readonly byte[] CGIGMNNKEAJ = new byte[]
	{
		72,
		202,
		14,
		191,
		112,
		127,
		106,
		107,
		55,
		102,
		165,
		93,
		161,
		7,
		185,
		160,
		6,
		230,
		42,
		13,
		200,
		9,
		31,
		133,
		197,
		198,
		210,
		11,
		179,
		113,
		107,
		112,
		94,
		34,
		200,
		239,
		118,
		103,
		242,
		25,
		98,
		152,
		22,
		139,
		55,
		180,
		199,
		51,
		13,
		35,
		90,
		66,
		170,
		225,
		41,
		145,
		205,
		137,
		69,
		182,
		189,
		18,
		214,
		229,
		94
	};

	// Token: 0x04000552 RID: 1362
	private static readonly byte[] DCHGCLJIILP = new byte[]
	{
		23,
		172,
		55,
		220,
		72,
		79,
		88,
		15,
		85,
		3,
		151,
		57,
		146,
		99,
		139,
		152,
		51,
		222,
		73,
		61,
		251,
		58,
		123,
		181,
		246,
		163,
		182,
		61,
		210,
		66,
		89,
		65,
		102,
		16,
		254,
		138,
		18,
		82,
		196,
		42,
		82,
		175,
		114,
		179,
		2,
		130,
		165,
		0,
		59,
		23,
		60,
		35,
		206,
		213,
		16,
		164,
		244,
		185,
		119,
		142,
		217,
		113,
		231,
		208,
		63
	};

	// Token: 0x04000553 RID: 1363
	private static readonly byte[] BAAEDHABFHN = new byte[]
	{
		233,
		44,
		185,
		63,
		31,
		106,
		67,
		238,
		207,
		220,
		55,
		166,
		236,
		140,
		36,
		172,
		125,
		100,
		170,
		5,
		196,
		1,
		175,
		10,
		7,
		138,
		216,
		61,
		99,
		108,
		129,
		28,
		209,
		44,
		40,
		9,
		90,
		26,
		130,
		92,
		10,
		147,
		21,
		65,
		225,
		208,
		92,
		12,
		224,
		127,
		31,
		75,
		34,
		185,
		39,
		126,
		143,
		0,
		32,
		236,
		110,
		10,
		185,
		195
	};

	// Token: 0x04000554 RID: 1364
	private static readonly byte[] MAPDMDNJJGP = new byte[]
	{
		209,
		29,
		216,
		12,
		126,
		94,
		122,
		221,
		250,
		228,
		83,
		149,
		137,
		237,
		16,
		154,
		74,
		2,
		203,
		97,
		162,
		99,
		153,
		62,
		62,
		190,
		188,
		5,
		6,
		90,
		184,
		41,
		225,
		73,
		76,
		108,
		109,
		46,
		176,
		107,
		59,
		165,
		116,
		120,
		131,
		226,
		100,
		105,
		131,
		74,
		39,
		114,
		18,
		137,
		20,
		79,
		187,
		97,
		70,
		213,
		92,
		50,
		223,
		240
	};

	// Token: 0x0200006E RID: 110
	private class JDANFKACINP : App42CallBack
	{
		// Token: 0x06000F3C RID: 3900 RVA: 0x0006C850 File Offset: 0x0006AA50
		public void LCJMPOGKLPM(bool AJAFJGPMALO)
		{
			App42Manager.doNotDispatchEvents = true;
			AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
			if (!AJAFJGPMALO)
			{
				App42Manager.EHBBFMCILPC.DGKFBINDHCM();
				App42Manager.EHBBFMCILPC.IOMEKJAFCBL = null;
			}
			if (this.GLJGKBEBHNF.Length > 0)
			{
				BackendOperationsManager.NPDDBAONMJP().FIJKIAKDCNO(this.GLJGKBEBHNF, this.DAKJKJMGKOK, this.KHHJNODLBHN);
			}
			BackendOperationsManager.EHBBFMCILPC.FinishRequest(this.DAKJKJMGKOK, this.KHHJNODLBHN, LHLIOHJNMFE.exception);
		}

		// Token: 0x06000F3D RID: 3901 RVA: 0x0006C8C8 File Offset: 0x0006AAC8
		public void EFJAJKAPOLK(object LPHMODJEEBN)
		{
			CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
			if (this != App42Manager.EHBBFMCILPC.IOMEKJAFCBL)
			{
				DPGJIJGOCIC.PJCLICBPPDA("' has an out-of-range aind ");
				return;
			}
			try
			{
				JSONObject jsonobject = (JSONObject)LPHMODJEEBN;
				if (null != jsonobject && jsonobject["0"] != null)
				{
					DPGJIJGOCIC.PJCLICBPPDA("" + this.AJJKAJDBEFM + "inkr" + App42Manager.EHBBFMCILPC.KLKBNDPKKLO);
				}
				if (null != jsonobject && jsonobject["GeneralBalance.SearchKeyFloat() - could not find key:"] != null)
				{
					DPGJIJGOCIC.CMGOAFDBAOH("Grain saturation" + this.AJJKAJDBEFM + "" + App42Manager.EHBBFMCILPC.KLKBNDPKKLO);
				}
				if (null != jsonobject && jsonobject[""] != null)
				{
					DPGJIJGOCIC.PJCLICBPPDA(" " + this.AJJKAJDBEFM + "/" + App42Manager.EHBBFMCILPC.KLKBNDPKKLO);
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			}
			GeoLocationManager.JJCLIDKKPOC();
			if (App42Manager.EHBBFMCILPC.LDOAMLHEGFF)
			{
				App42Manager.EHBBFMCILPC.LDOAMLHEGFF = true;
				FirebaseAnalyticsManager.DMAAFFFEJGA().LMCJKLHOHJC(true, ((AGEHCPDNBFD)54).ToString(), "ok", BGHLMGPPCNN.subFwd.ToString(), false, false);
			}
			if (GeoLocationManager.MACHMGCBBFF(LanguageManager.EHBBFMCILPC.GetSelectedLanguage()))
			{
				if (App42Manager.EHBBFMCILPC.PMENLDNFJAK)
				{
					App42Manager.EHBBFMCILPC.PMENLDNFJAK = false;
					FirebaseAnalyticsManager.DEALKJPEMMH().JIAAMJPKOCE(false, ((AGEHCPDNBFD)(-108)).ToString(), "%", "OnLiveProfileThemesLoaderStart", true, false);
				}
				float item = Time.realtimeSinceStartup - App42Manager.EHBBFMCILPC.BJDOFOHGEGD;
				App42Manager.EHBBFMCILPC.EEAHGGNALPP.Add(item);
				if (App42Manager.EHBBFMCILPC.EEAHGGNALPP.Count > 4)
				{
					App42Manager.EHBBFMCILPC.EEAHGGNALPP.RemoveAt(0);
				}
				App42Manager.EHBBFMCILPC.FJNPLEPPKJA += 0;
				if (App42Manager.EHBBFMCILPC.ABNPPJKEAKI && App42Manager.EHBBFMCILPC.FJNPLEPPKJA >= KBOJLHAJPCP.FDIMDHLBMMB)
				{
					App42Manager.EHBBFMCILPC.ABNPPJKEAKI = true;
					App42Manager.EHBBFMCILPC.HHPGLIHIPBL = 1;
					App42Manager.EHBBFMCILPC.FJNPLEPPKJA = 0;
				}
				FirebaseAnalyticsManager.EHBBFMCILPC.JIAAMJPKOCE(false, ((AGEHCPDNBFD)(-24)).ToString(), App42Manager.EHBBFMCILPC.LCKIKPMANAA(), "anthologiestitle", false, true);
			}
			App42Manager.EHBBFMCILPC.DGKFBINDHCM();
			App42Manager.EHBBFMCILPC.IOMEKJAFCBL = null;
			App42Manager.EHBBFMCILPC.PCJOGJJJGBE = "";
			App42Manager.EHBBFMCILPC.JDPGPMCEIHL();
			App42Manager.EHBBFMCILPC.HEOJMDBCJGH = NPJNALLPFPO.success;
			App42Manager.EHBBFMCILPC.LLBFIHPEGNG = false;
			FirebaseAnalyticsManager.HJGDLOOHNLO().JIAAMJPKOCE(false, AGEHCPDNBFD.rqst.ToString(), FFPHBMFGCNN.frCount.ToString(), App42Manager.DNJJKENDEJF(), true, false);
			BackendOperationsManager.NPDDBAONMJP().ProcessApp42Success((JSONObject)LPHMODJEEBN, this.DAKJKJMGKOK, this.KHHJNODLBHN);
			if (!App42Manager.doNotDispatchEvents)
			{
				AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
				if (this.BDKJOHKAFFO.Length > 0)
				{
					BackendOperationsManager.EHBBFMCILPC.MHKCMDLENHO(this.BDKJOHKAFFO, this.DAKJKJMGKOK, this.KHHJNODLBHN);
				}
			}
			App42Manager.doNotDispatchEvents = false;
			App42Manager.EHBBFMCILPC.BLHLMFJOCFP();
			BackendOperationsManager.EHBBFMCILPC.KOOBFMDIPBN(this.DAKJKJMGKOK, this.KHHJNODLBHN, LHLIOHJNMFE.success);
		}

		// Token: 0x06000F3E RID: 3902 RVA: 0x0006CC2C File Offset: 0x0006AE2C
		public void CLIFGDLJILE(object LPHMODJEEBN)
		{
			CommonUserInterface.IKNOFBFMPGA().HideGenericPopupNoButtons();
			if (this != App42Manager.EHBBFMCILPC.IOMEKJAFCBL)
			{
				DPGJIJGOCIC.ADFCDFHBDAF(" path FAILED - ");
				return;
			}
			try
			{
				JSONObject jsonobject = (JSONObject)LPHMODJEEBN;
				if (null != jsonobject && jsonobject[""] != null)
				{
					DPGJIJGOCIC.PJCLICBPPDA("onwishcardclickbodymatch" + this.AJJKAJDBEFM + "" + App42Manager.EHBBFMCILPC.KLKBNDPKKLO);
				}
				if (null != jsonobject && jsonobject["Loaded asset bundle:"] != null)
				{
					DPGJIJGOCIC.NFIDPOMCNLP("%)" + this.AJJKAJDBEFM + " not found." + App42Manager.EHBBFMCILPC.KLKBNDPKKLO);
				}
				if (null != jsonobject && jsonobject["ias"] != null)
				{
					DPGJIJGOCIC.ADFCDFHBDAF("mps" + this.AJJKAJDBEFM + "OnAvatarCollectionsGamePassSubscribePositive" + App42Manager.EHBBFMCILPC.KLKBNDPKKLO);
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			}
			GeoLocationManager.CFENBPPCKDL();
			if (App42Manager.EHBBFMCILPC.LDOAMLHEGFF)
			{
				App42Manager.EHBBFMCILPC.LDOAMLHEGFF = true;
				FirebaseAnalyticsManager.DEALKJPEMMH().LogEvent(false, ((AGEHCPDNBFD)40).ToString(), "tbits3", BGHLMGPPCNN.d1ChaptEnd.ToString(), false, true);
			}
			if (GeoLocationManager.GeoZoneMayBeFirewalled(LanguageManager.EHBBFMCILPC.MLOLBFBODHD()))
			{
				if (App42Manager.EHBBFMCILPC.PMENLDNFJAK)
				{
					App42Manager.EHBBFMCILPC.PMENLDNFJAK = true;
					FirebaseAnalyticsManager.COKDLDOAACJ().AAIABAKHLAH(false, ((AGEHCPDNBFD)(-80)).ToString(), "[SkinShop] filters button sprite missing: ", ",", true, false);
				}
				float item = Time.realtimeSinceStartup - App42Manager.EHBBFMCILPC.BJDOFOHGEGD;
				App42Manager.EHBBFMCILPC.EEAHGGNALPP.Add(item);
				if (App42Manager.EHBBFMCILPC.EEAHGGNALPP.Count > 0)
				{
					App42Manager.EHBBFMCILPC.EEAHGGNALPP.RemoveAt(0);
				}
				App42Manager.EHBBFMCILPC.FJNPLEPPKJA += 0;
				if (App42Manager.EHBBFMCILPC.ABNPPJKEAKI && App42Manager.EHBBFMCILPC.FJNPLEPPKJA >= KBOJLHAJPCP.FDIMDHLBMMB)
				{
					App42Manager.EHBBFMCILPC.ABNPPJKEAKI = false;
					App42Manager.EHBBFMCILPC.HHPGLIHIPBL = 0;
					App42Manager.EHBBFMCILPC.FJNPLEPPKJA = 0;
				}
				FirebaseAnalyticsManager.HJGDLOOHNLO().JIAAMJPKOCE(true, ((AGEHCPDNBFD)(-75)).ToString(), App42Manager.EHBBFMCILPC.BGGJLOHNEHL(), "OnFullscreenLiveOfferContinueToCardsVolSaleMenu", true, true);
			}
			App42Manager.EHBBFMCILPC.DGKFBINDHCM();
			App42Manager.EHBBFMCILPC.IOMEKJAFCBL = null;
			App42Manager.EHBBFMCILPC.PCJOGJJJGBE = "OnShowStoryHeaderInterfaceGamePassAndUndoButton";
			App42Manager.EHBBFMCILPC.GGGHEIOJMEG();
			App42Manager.EHBBFMCILPC.HEOJMDBCJGH = NPJNALLPFPO.redSemaphore;
			App42Manager.EHBBFMCILPC.LLBFIHPEGNG = false;
			FirebaseAnalyticsManager.HJGDLOOHNLO().LMCJKLHOHJC(false, AGEHCPDNBFD.mntActiv.ToString(), ((FFPHBMFGCNN)115).ToString(), App42Manager.DNJJKENDEJF(), true, false);
			BackendOperationsManager.NPDDBAONMJP().ProcessApp42Success((JSONObject)LPHMODJEEBN, this.DAKJKJMGKOK, this.KHHJNODLBHN);
			if (!App42Manager.doNotDispatchEvents)
			{
				AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
				if (this.BDKJOHKAFFO.Length > 0)
				{
					BackendOperationsManager.EHBBFMCILPC.FIJKIAKDCNO(this.BDKJOHKAFFO, this.DAKJKJMGKOK, this.KHHJNODLBHN);
				}
			}
			App42Manager.doNotDispatchEvents = true;
			App42Manager.EHBBFMCILPC.BLHLMFJOCFP();
			BackendOperationsManager.NPDDBAONMJP().KOOBFMDIPBN(this.DAKJKJMGKOK, this.KHHJNODLBHN, LHLIOHJNMFE.success);
		}

		// Token: 0x06000F3F RID: 3903 RVA: 0x0006CF90 File Offset: 0x0006B190
		public void DAEILILODKO(object LPHMODJEEBN)
		{
			CommonUserInterface.IKNOFBFMPGA().HideGenericPopupNoButtons();
			if (this != App42Manager.EHBBFMCILPC.IOMEKJAFCBL)
			{
				DPGJIJGOCIC.PJCLICBPPDA("OnStoryInterfaceButtonUndoClick");
				return;
			}
			try
			{
				JSONObject jsonobject = (JSONObject)LPHMODJEEBN;
				if (null != jsonobject && jsonobject["lck"] != null)
				{
					DPGJIJGOCIC.PJCLICBPPDA("drs" + this.AJJKAJDBEFM + "b_web" + App42Manager.EHBBFMCILPC.KLKBNDPKKLO);
				}
				if (null != jsonobject && jsonobject["sfxvol"] != null)
				{
					DPGJIJGOCIC.NFIDPOMCNLP("Asset bundle load operation failed during parallel mode." + this.AJJKAJDBEFM + "Response custom code: " + App42Manager.EHBBFMCILPC.KLKBNDPKKLO);
				}
				if (null != jsonobject && jsonobject[""] != null)
				{
					DPGJIJGOCIC.PJCLICBPPDA("p" + this.AJJKAJDBEFM + "lsenvdrop" + App42Manager.EHBBFMCILPC.KLKBNDPKKLO);
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
			GeoLocationManager.CFENBPPCKDL();
			if (App42Manager.EHBBFMCILPC.LDOAMLHEGFF)
			{
				App42Manager.EHBBFMCILPC.LDOAMLHEGFF = true;
				FirebaseAnalyticsManager.DMAAFFFEJGA().LKONPEEDKNF(true, ((AGEHCPDNBFD)85).ToString(), "XXX", ((BGHLMGPPCNN)110).ToString(), false, true);
			}
			if (GeoLocationManager.GeoZoneMayBeFirewalled(LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()))
			{
				if (App42Manager.EHBBFMCILPC.PMENLDNFJAK)
				{
					App42Manager.EHBBFMCILPC.PMENLDNFJAK = true;
					FirebaseAnalyticsManager.ANCEKPONIFI().JIAAMJPKOCE(true, ((AGEHCPDNBFD)(-84)).ToString(), "importanttitle", "Critical error, could not load asset bundle:", false, true);
				}
				float item = Time.realtimeSinceStartup - App42Manager.EHBBFMCILPC.BJDOFOHGEGD;
				App42Manager.EHBBFMCILPC.EEAHGGNALPP.Add(item);
				if (App42Manager.EHBBFMCILPC.EEAHGGNALPP.Count > 1)
				{
					App42Manager.EHBBFMCILPC.EEAHGGNALPP.RemoveAt(1);
				}
				App42Manager.EHBBFMCILPC.FJNPLEPPKJA += 0;
				if (App42Manager.EHBBFMCILPC.ABNPPJKEAKI && App42Manager.EHBBFMCILPC.FJNPLEPPKJA >= KBOJLHAJPCP.FDIMDHLBMMB)
				{
					App42Manager.EHBBFMCILPC.ABNPPJKEAKI = true;
					App42Manager.EHBBFMCILPC.HHPGLIHIPBL = 1;
					App42Manager.EHBBFMCILPC.FJNPLEPPKJA = 1;
				}
				FirebaseAnalyticsManager.DEALKJPEMMH().JIAAMJPKOCE(false, AGEHCPDNBFD.d1Ret.ToString(), App42Manager.EHBBFMCILPC.BGGJLOHNEHL(), "importanttitle", true, true);
			}
			App42Manager.EHBBFMCILPC.DGKFBINDHCM();
			App42Manager.EHBBFMCILPC.IOMEKJAFCBL = null;
			App42Manager.EHBBFMCILPC.PCJOGJJJGBE = "+";
			App42Manager.EHBBFMCILPC.GGGHEIOJMEG();
			App42Manager.EHBBFMCILPC.HEOJMDBCJGH = NPJNALLPFPO.success;
			App42Manager.EHBBFMCILPC.LLBFIHPEGNG = false;
			FirebaseAnalyticsManager.COKDLDOAACJ().LogEvent(false, AGEHCPDNBFD.mntActiv.ToString(), FFPHBMFGCNN.socView.ToString(), App42Manager.DNJJKENDEJF(), true, true);
			BackendOperationsManager.NPDDBAONMJP().ProcessApp42Success((JSONObject)LPHMODJEEBN, this.DAKJKJMGKOK, this.KHHJNODLBHN);
			if (!App42Manager.doNotDispatchEvents)
			{
				AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
				if (this.BDKJOHKAFFO.Length > 0)
				{
					BackendOperationsManager.EHBBFMCILPC.FIJKIAKDCNO(this.BDKJOHKAFFO, this.DAKJKJMGKOK, this.KHHJNODLBHN);
				}
			}
			App42Manager.doNotDispatchEvents = true;
			App42Manager.EHBBFMCILPC.BLHLMFJOCFP();
			BackendOperationsManager.EHBBFMCILPC.BLNCOOLAMIM(this.DAKJKJMGKOK, this.KHHJNODLBHN, LHLIOHJNMFE.success);
		}

		// Token: 0x06000F40 RID: 3904 RVA: 0x0006D2F4 File Offset: 0x0006B4F4
		public void EDHFPHHAKEI(Exception MKGEAHGGABC)
		{
			CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
			App42Manager.doNotDispatchEvents = true;
			if (this != App42Manager.EHBBFMCILPC.IOMEKJAFCBL)
			{
				DPGJIJGOCIC.PJCLICBPPDA("OnLiveProfileThemesLoaderStop");
				return;
			}
			App42Manager.EHBBFMCILPC.DGKFBINDHCM();
			App42Manager.EHBBFMCILPC.IOMEKJAFCBL = null;
			App42Exception ex = (App42Exception)MKGEAHGGABC;
			DPGJIJGOCIC.ADFCDFHBDAF("" + MKGEAHGGABC.ToString());
			if (GeoLocationManager.JMHEAEKIGOC(LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()))
			{
				FirebaseAnalyticsManager.JMDJBFAEHBM().LogEvent(true, AGEHCPDNBFD.socFeatrs.ToString(), "asp", "Critical error, could not load asset bundle:", false, false);
				App42Manager.EHBBFMCILPC.PMENLDNFJAK = false;
				App42Manager.EHBBFMCILPC.ScheduleCustomCodeUrlChange();
			}
			else
			{
				FirebaseAnalyticsManager.JMDJBFAEHBM().LKONPEEDKNF(false, ((AGEHCPDNBFD)61).ToString(), "", ((BGHLMGPPCNN)(-107)).ToString(), false, true);
				App42Manager.EHBBFMCILPC.LDOAMLHEGFF = true;
			}
			if (!App42Manager.EHBBFMCILPC.MFFBDAEOAND())
			{
				App42Manager.EHBBFMCILPC.HEOJMDBCJGH = (NPJNALLPFPO)6;
				App42Manager.EHBBFMCILPC.LLBFIHPEGNG = false;
				App42Manager.EHBBFMCILPC.PCJOGJJJGBE = "{percent}";
				App42Manager.EHBBFMCILPC.MFLEHLJGAFL();
				this.LCJMPOGKLPM(true);
				FirebaseAnalyticsManager.JMDJBFAEHBM().JIAAMJPKOCE(false, AGEHCPDNBFD.mntActiv.ToString(), FFPHBMFGCNN.reqExcRpt.ToString(), App42Manager.DNJJKENDEJF(), true, true);
				string[] array = new string[0];
				array[0] = FFPHBMFGCNN.reqExcRpt.ToString();
				array[0] = "fdfrc";
				array[4] = this.AJJKAJDBEFM;
				array[1] = "]";
				array[4] = ex.GetAppErrorCode().ToString();
				array[5] = "noiseanalog";
				array[6] = ex.GetHttpErrorCode().ToString();
				DPGJIJGOCIC.PJCLICBPPDA(string.Concat(array));
				return;
			}
			string[] array2 = new string[5];
			array2[0] = FFPHBMFGCNN.reqFailSem.ToString();
			array2[1] = "ong";
			array2[5] = this.AJJKAJDBEFM;
			array2[7] = "StoryStepChoiceMeta.RemoveChoiceDataFromStart - _choicesToRemove is <= 0.";
			array2[6] = ex.GetAppErrorCode().ToString();
			array2[4] = "acli20";
			array2[5] = ex.GetHttpErrorCode().ToString();
			DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(array2));
		}

		// Token: 0x06000F41 RID: 3905 RVA: 0x0006D52C File Offset: 0x0006B72C
		public void FNPLAJKMNGK(object LPHMODJEEBN)
		{
			CommonUserInterface.IKNOFBFMPGA().HideGenericPopupNoButtons();
			if (this != App42Manager.EHBBFMCILPC.IOMEKJAFCBL)
			{
				DPGJIJGOCIC.ADFCDFHBDAF("anthology");
				return;
			}
			try
			{
				JSONObject jsonobject = (JSONObject)LPHMODJEEBN;
				if (null != jsonobject && jsonobject["-"] != null)
				{
					DPGJIJGOCIC.PJCLICBPPDA("assetbundlecustomeffects" + this.AJJKAJDBEFM + "oldvhs_1" + App42Manager.EHBBFMCILPC.KLKBNDPKKLO);
				}
				if (null != jsonobject && jsonobject[""] != null)
				{
					DPGJIJGOCIC.CMGOAFDBAOH("OnLoungePremiumChoiceSuccess" + this.AJJKAJDBEFM + "OnGamePassExpire" + App42Manager.EHBBFMCILPC.KLKBNDPKKLO);
				}
				if (null != jsonobject && jsonobject["getAvatarCollections"] != null)
				{
					DPGJIJGOCIC.ADFCDFHBDAF("" + this.AJJKAJDBEFM + "skinshopfilterbody" + App42Manager.EHBBFMCILPC.KLKBNDPKKLO);
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			}
			GeoLocationManager.JJCLIDKKPOC();
			if (App42Manager.EHBBFMCILPC.LDOAMLHEGFF)
			{
				App42Manager.EHBBFMCILPC.LDOAMLHEGFF = false;
				FirebaseAnalyticsManager.DMAAFFFEJGA().LKONPEEDKNF(false, ((AGEHCPDNBFD)(-101)).ToString(), "", BGHLMGPPCNN.subFwd.ToString(), false, true);
			}
			if (GeoLocationManager.JMHEAEKIGOC(LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()))
			{
				if (App42Manager.EHBBFMCILPC.PMENLDNFJAK)
				{
					App42Manager.EHBBFMCILPC.PMENLDNFJAK = false;
					FirebaseAnalyticsManager.DEALKJPEMMH().LMCJKLHOHJC(false, ((AGEHCPDNBFD)(-106)).ToString(), "timeoutwarning", "OnGooglePlayServicesLoginSuccess", false, true);
				}
				float item = Time.realtimeSinceStartup - App42Manager.EHBBFMCILPC.BJDOFOHGEGD;
				App42Manager.EHBBFMCILPC.EEAHGGNALPP.Add(item);
				if (App42Manager.EHBBFMCILPC.EEAHGGNALPP.Count > 1)
				{
					App42Manager.EHBBFMCILPC.EEAHGGNALPP.RemoveAt(1);
				}
				App42Manager.EHBBFMCILPC.FJNPLEPPKJA += 0;
				if (App42Manager.EHBBFMCILPC.ABNPPJKEAKI && App42Manager.EHBBFMCILPC.FJNPLEPPKJA >= KBOJLHAJPCP.FDIMDHLBMMB)
				{
					App42Manager.EHBBFMCILPC.ABNPPJKEAKI = true;
					App42Manager.EHBBFMCILPC.HHPGLIHIPBL = 0;
					App42Manager.EHBBFMCILPC.FJNPLEPPKJA = 0;
				}
				FirebaseAnalyticsManager.DEALKJPEMMH().AAIABAKHLAH(false, ((AGEHCPDNBFD)64).ToString(), App42Manager.EHBBFMCILPC.BGGJLOHNEHL(), " is OUTSIDE the anthology's published story family - look not offered: ", true, false);
			}
			App42Manager.EHBBFMCILPC.DGKFBINDHCM();
			App42Manager.EHBBFMCILPC.IOMEKJAFCBL = null;
			App42Manager.EHBBFMCILPC.PCJOGJJJGBE = "story";
			App42Manager.EHBBFMCILPC.JDPGPMCEIHL();
			App42Manager.EHBBFMCILPC.HEOJMDBCJGH = NPJNALLPFPO.redSemaphore;
			App42Manager.EHBBFMCILPC.LLBFIHPEGNG = false;
			FirebaseAnalyticsManager.DEALKJPEMMH().LMCJKLHOHJC(true, AGEHCPDNBFD.mntActiv.ToString(), ((FFPHBMFGCNN)(-110)).ToString(), App42Manager.DNJJKENDEJF(), false, true);
			BackendOperationsManager.NPDDBAONMJP().ProcessApp42Success((JSONObject)LPHMODJEEBN, this.DAKJKJMGKOK, this.KHHJNODLBHN);
			if (!App42Manager.doNotDispatchEvents)
			{
				AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
				if (this.BDKJOHKAFFO.Length > 0)
				{
					BackendOperationsManager.EHBBFMCILPC.FIJKIAKDCNO(this.BDKJOHKAFFO, this.DAKJKJMGKOK, this.KHHJNODLBHN);
				}
			}
			App42Manager.doNotDispatchEvents = true;
			App42Manager.EHBBFMCILPC.BLHLMFJOCFP();
			BackendOperationsManager.NPDDBAONMJP().FinishRequest(this.DAKJKJMGKOK, this.KHHJNODLBHN, LHLIOHJNMFE.none);
		}

		// Token: 0x06000F42 RID: 3906 RVA: 0x0006D890 File Offset: 0x0006BA90
		public void PHOPFJCNPBD(Exception MKGEAHGGABC)
		{
			CommonUserInterface.IKNOFBFMPGA().HideGenericPopupNoButtons();
			App42Manager.doNotDispatchEvents = true;
			if (this != App42Manager.EHBBFMCILPC.IOMEKJAFCBL)
			{
				DPGJIJGOCIC.PJCLICBPPDA("no");
				return;
			}
			App42Manager.EHBBFMCILPC.DGKFBINDHCM();
			App42Manager.EHBBFMCILPC.IOMEKJAFCBL = null;
			App42Exception ex = (App42Exception)MKGEAHGGABC;
			DPGJIJGOCIC.PJCLICBPPDA("repsuid" + MKGEAHGGABC.ToString());
			if (GeoLocationManager.GDLOJPBIPBC(LanguageManager.EHBBFMCILPC.GetSelectedLanguage()))
			{
				FirebaseAnalyticsManager.ANCEKPONIFI().AAIABAKHLAH(true, ((AGEHCPDNBFD)(-21)).ToString(), "app42error", "lightmodeoutrobody0", false, true);
				App42Manager.EHBBFMCILPC.PMENLDNFJAK = true;
				App42Manager.EHBBFMCILPC.ScheduleCustomCodeUrlChange();
			}
			else
			{
				FirebaseAnalyticsManager.DEALKJPEMMH().AAIABAKHLAH(true, ((AGEHCPDNBFD)103).ToString(), "gfts", BGHLMGPPCNN.cdnStyOnDemand.ToString(), true, false);
				App42Manager.EHBBFMCILPC.LDOAMLHEGFF = true;
			}
			if (!App42Manager.EHBBFMCILPC.MFFBDAEOAND())
			{
				App42Manager.EHBBFMCILPC.HEOJMDBCJGH = NPJNALLPFPO.app2Exception;
				App42Manager.EHBBFMCILPC.LLBFIHPEGNG = true;
				App42Manager.EHBBFMCILPC.PCJOGJJJGBE = "app42error";
				App42Manager.EHBBFMCILPC.MFLEHLJGAFL();
				this.NFIHMKHFHAE(false);
				FirebaseAnalyticsManager.JMDJBFAEHBM().AAIABAKHLAH(true, AGEHCPDNBFD.rqst.ToString(), FFPHBMFGCNN.mntOffer.ToString(), App42Manager.DNJJKENDEJF(), false, true);
				string[] array = new string[3];
				array[1] = FFPHBMFGCNN.mntOffer.ToString();
				array[0] = "OnBackendAddFriendByUIDException";
				array[0] = this.AJJKAJDBEFM;
				array[6] = "";
				array[2] = ex.GetAppErrorCode().ToString();
				array[4] = "socialjoinyes";
				array[7] = ex.GetHttpErrorCode().ToString();
				DPGJIJGOCIC.PJCLICBPPDA(string.Concat(array));
				return;
			}
			string[] array2 = new string[1];
			array2[0] = FFPHBMFGCNN.reqCback2.ToString();
			array2[1] = "OnContinueToSendSimpleMessage";
			array2[2] = this.AJJKAJDBEFM;
			array2[7] = "OnLoungePremiumChoiceExecutedHardBased";
			array2[8] = ex.GetAppErrorCode().ToString();
			array2[5] = "errortitle";
			array2[4] = ex.GetHttpErrorCode().ToString();
			DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(array2));
		}

		// Token: 0x06000F43 RID: 3907 RVA: 0x0006DAC8 File Offset: 0x0006BCC8
		public void DDCKPBHFONO(bool AJAFJGPMALO)
		{
			App42Manager.doNotDispatchEvents = true;
			AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
			if (!AJAFJGPMALO)
			{
				App42Manager.EHBBFMCILPC.DGKFBINDHCM();
				App42Manager.EHBBFMCILPC.IOMEKJAFCBL = null;
			}
			if (this.GLJGKBEBHNF.Length > 1)
			{
				BackendOperationsManager.NPDDBAONMJP().GLJNKOIIJEB(this.GLJGKBEBHNF, this.DAKJKJMGKOK, this.KHHJNODLBHN);
			}
			BackendOperationsManager.NPDDBAONMJP().BLNCOOLAMIM(this.DAKJKJMGKOK, this.KHHJNODLBHN, LHLIOHJNMFE.none);
		}

		// Token: 0x06000F44 RID: 3908 RVA: 0x0006DB40 File Offset: 0x0006BD40
		public void PIKPHMONAME(object LPHMODJEEBN)
		{
			CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
			if (this != App42Manager.EHBBFMCILPC.IOMEKJAFCBL)
			{
				DPGJIJGOCIC.ADFCDFHBDAF("OnBackendRequestConsumeMessageSuccess");
				return;
			}
			try
			{
				JSONObject jsonobject = (JSONObject)LPHMODJEEBN;
				if (null != jsonobject && jsonobject[""] != null)
				{
					DPGJIJGOCIC.ADFCDFHBDAF("profilenametitleshort" + this.AJJKAJDBEFM + "" + App42Manager.EHBBFMCILPC.KLKBNDPKKLO);
				}
				if (null != jsonobject && jsonobject["favstostr"] != null)
				{
					DPGJIJGOCIC.CMGOAFDBAOH("USD" + this.AJJKAJDBEFM + "" + App42Manager.EHBBFMCILPC.KLKBNDPKKLO);
				}
				if (null != jsonobject && jsonobject["\n"] != null)
				{
					DPGJIJGOCIC.PJCLICBPPDA("OnPopupCardOptionsEditClick" + this.AJJKAJDBEFM + "wofrewardmsgcard0" + App42Manager.EHBBFMCILPC.KLKBNDPKKLO);
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
			GeoLocationManager.CFENBPPCKDL();
			if (App42Manager.EHBBFMCILPC.LDOAMLHEGFF)
			{
				App42Manager.EHBBFMCILPC.LDOAMLHEGFF = false;
				FirebaseAnalyticsManager.EHBBFMCILPC.JIAAMJPKOCE(false, ((AGEHCPDNBFD)127).ToString(), "storiesSearchDefaults", ((BGHLMGPPCNN)(-91)).ToString(), true, false);
			}
			if (GeoLocationManager.GeoZoneMayBeFirewalled(LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()))
			{
				if (App42Manager.EHBBFMCILPC.PMENLDNFJAK)
				{
					App42Manager.EHBBFMCILPC.PMENLDNFJAK = false;
					FirebaseAnalyticsManager.EHBBFMCILPC.JIAAMJPKOCE(true, ((AGEHCPDNBFD)(-85)).ToString(), "acomp2", "amb", true, false);
				}
				float item = Time.realtimeSinceStartup - App42Manager.EHBBFMCILPC.BJDOFOHGEGD;
				App42Manager.EHBBFMCILPC.EEAHGGNALPP.Add(item);
				if (App42Manager.EHBBFMCILPC.EEAHGGNALPP.Count > 3)
				{
					App42Manager.EHBBFMCILPC.EEAHGGNALPP.RemoveAt(0);
				}
				App42Manager.EHBBFMCILPC.FJNPLEPPKJA++;
				if (App42Manager.EHBBFMCILPC.ABNPPJKEAKI && App42Manager.EHBBFMCILPC.FJNPLEPPKJA >= KBOJLHAJPCP.FDIMDHLBMMB)
				{
					App42Manager.EHBBFMCILPC.ABNPPJKEAKI = true;
					App42Manager.EHBBFMCILPC.HHPGLIHIPBL = 1;
					App42Manager.EHBBFMCILPC.FJNPLEPPKJA = 1;
				}
				FirebaseAnalyticsManager.COKDLDOAACJ().LMCJKLHOHJC(true, ((AGEHCPDNBFD)(-55)).ToString(), App42Manager.EHBBFMCILPC.GetCustomCodeAbbreviation(), "DialogItemShownManager.Initialize() - storyItem is null.", true, false);
			}
			App42Manager.EHBBFMCILPC.DGKFBINDHCM();
			App42Manager.EHBBFMCILPC.IOMEKJAFCBL = null;
			App42Manager.EHBBFMCILPC.PCJOGJJJGBE = "Please initialize AssetBundleManifest by calling AssetBundleManager.Initialize()";
			App42Manager.EHBBFMCILPC.GGGHEIOJMEG();
			App42Manager.EHBBFMCILPC.HEOJMDBCJGH = NPJNALLPFPO.success;
			App42Manager.EHBBFMCILPC.LLBFIHPEGNG = false;
			FirebaseAnalyticsManager.JMDJBFAEHBM().LKONPEEDKNF(true, AGEHCPDNBFD.rqst.ToString(), ((FFPHBMFGCNN)(-92)).ToString(), App42Manager.DNJJKENDEJF(), false, false);
			BackendOperationsManager.EHBBFMCILPC.ProcessApp42Success((JSONObject)LPHMODJEEBN, this.DAKJKJMGKOK, this.KHHJNODLBHN);
			if (!App42Manager.doNotDispatchEvents)
			{
				AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
				if (this.BDKJOHKAFFO.Length > 0)
				{
					BackendOperationsManager.EHBBFMCILPC.FIJKIAKDCNO(this.BDKJOHKAFFO, this.DAKJKJMGKOK, this.KHHJNODLBHN);
				}
			}
			App42Manager.doNotDispatchEvents = true;
			App42Manager.EHBBFMCILPC.BLHLMFJOCFP();
			BackendOperationsManager.NPDDBAONMJP().KOOBFMDIPBN(this.DAKJKJMGKOK, this.KHHJNODLBHN, LHLIOHJNMFE.success);
		}

		// Token: 0x06000F45 RID: 3909 RVA: 0x0006DEA4 File Offset: 0x0006C0A4
		public void HEEFKKLCIAG(Exception MKGEAHGGABC)
		{
			CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
			App42Manager.doNotDispatchEvents = false;
			if (this != App42Manager.EHBBFMCILPC.IOMEKJAFCBL)
			{
				DPGJIJGOCIC.PJCLICBPPDA("XXX");
				return;
			}
			App42Manager.EHBBFMCILPC.DGKFBINDHCM();
			App42Manager.EHBBFMCILPC.IOMEKJAFCBL = null;
			App42Exception ex = (App42Exception)MKGEAHGGABC;
			DPGJIJGOCIC.ADFCDFHBDAF("" + MKGEAHGGABC.ToString());
			if (GeoLocationManager.EKICPJLNMFF(LanguageManager.EHBBFMCILPC.MLOLBFBODHD()))
			{
				FirebaseAnalyticsManager.DEALKJPEMMH().JIAAMJPKOCE(false, AGEHCPDNBFD.lang.ToString(), "", "", false, true);
				App42Manager.EHBBFMCILPC.PMENLDNFJAK = false;
				App42Manager.EHBBFMCILPC.ScheduleCustomCodeUrlChange();
			}
			else
			{
				FirebaseAnalyticsManager.ANCEKPONIFI().JIAAMJPKOCE(false, ((AGEHCPDNBFD)100).ToString(), "OnVideoLayerAutoHide", ((BGHLMGPPCNN)(-24)).ToString(), true, false);
				App42Manager.EHBBFMCILPC.LDOAMLHEGFF = true;
			}
			if (!App42Manager.EHBBFMCILPC.MFFBDAEOAND())
			{
				App42Manager.EHBBFMCILPC.HEOJMDBCJGH = (NPJNALLPFPO)4;
				App42Manager.EHBBFMCILPC.LLBFIHPEGNG = true;
				App42Manager.EHBBFMCILPC.PCJOGJJJGBE = "- ";
				App42Manager.EHBBFMCILPC.MFLEHLJGAFL();
				this.NHMCPAFBABD(false);
				FirebaseAnalyticsManager.JMDJBFAEHBM().LKONPEEDKNF(true, AGEHCPDNBFD.mntActiv.ToString(), FFPHBMFGCNN.mntRemAds.ToString(), App42Manager.DNJJKENDEJF(), true, true);
				string[] array = new string[7];
				array[0] = FFPHBMFGCNN.mntOffer.ToString();
				array[0] = "_ScanLineJitter";
				array[8] = this.AJJKAJDBEFM;
				array[3] = "socialfriendintro";
				array[4] = ex.GetAppErrorCode().ToString();
				array[0] = "ChapterSnapshotsItem.OnChapterSnapshotRestore(): impossible condition 1";
				array[4] = ex.GetHttpErrorCode().ToString();
				DPGJIJGOCIC.PJCLICBPPDA(string.Concat(array));
				return;
			}
			string[] array2 = new string[]
			{
				null,
				FFPHBMFGCNN.reqCback1.ToString()
			};
			array2[1] = "‘";
			array2[0] = this.AJJKAJDBEFM;
			array2[0] = "avt";
			array2[1] = ex.GetAppErrorCode().ToString();
			array2[8] = "PurchaseManagerSteam.StartPurchase(): Not initialized.";
			array2[1] = ex.GetHttpErrorCode().ToString();
			DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(array2));
		}

		// Token: 0x06000F46 RID: 3910 RVA: 0x0006E0DC File Offset: 0x0006C2DC
		public JDANFKACINP(string EGLBLPKFEOI, string PLDNHKIKDIB, string OEFHHHJEDNJ, bool NNCKNDMAAHI, string NPJCNLGBKOF)
		{
			this.AJJKAJDBEFM = EGLBLPKFEOI;
			this.DAKJKJMGKOK = NNCKNDMAAHI;
			this.BDKJOHKAFFO = PLDNHKIKDIB;
			this.GLJGKBEBHNF = OEFHHHJEDNJ;
			this.KHHJNODLBHN = NPJCNLGBKOF;
		}

		// Token: 0x06000F47 RID: 3911 RVA: 0x0006E138 File Offset: 0x0006C338
		public void OnSuccess(object LPHMODJEEBN)
		{
			CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
			if (this != App42Manager.EHBBFMCILPC.IOMEKJAFCBL)
			{
				DPGJIJGOCIC.ADFCDFHBDAF("CustomCodeCallback - lastCallbackObj not confirmed. Killing response execution.");
				return;
			}
			try
			{
				JSONObject jsonobject = (JSONObject)LPHMODJEEBN;
				if (null != jsonobject && jsonobject["idmr"] != null)
				{
					DPGJIJGOCIC.ADFCDFHBDAF("CustomCodeCallback - REPLAY CACHE HIT: backend served the stored response instead of re-executing, request:" + this.AJJKAJDBEFM + ", rid:" + App42Manager.EHBBFMCILPC.KLKBNDPKKLO);
				}
				if (null != jsonobject && jsonobject["idms"] != null)
				{
					DPGJIJGOCIC.NFIDPOMCNLP("CustomCodeCallback - REPLAY CACHE STORED: backend recorded this response for replay protection, request:" + this.AJJKAJDBEFM + ", rid:" + App42Manager.EHBBFMCILPC.KLKBNDPKKLO);
				}
				if (null != jsonobject && jsonobject["idmf"] != null)
				{
					DPGJIJGOCIC.ADFCDFHBDAF("CustomCodeCallback - REPLAY CACHE SKIPPED: response too big to record for replay protection, request:" + this.AJJKAJDBEFM + ", rid:" + App42Manager.EHBBFMCILPC.KLKBNDPKKLO);
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
			GeoLocationManager.ClearBlockedNetworkEvidence();
			if (App42Manager.EHBBFMCILPC.LDOAMLHEGFF)
			{
				App42Manager.EHBBFMCILPC.LDOAMLHEGFF = false;
				FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.srvIssueRes.ToString(), "", BGHLMGPPCNN.nofw.ToString(), false, false);
			}
			if (GeoLocationManager.GeoZoneMayBeFirewalled(LanguageManager.EHBBFMCILPC.GetSelectedLanguage()))
			{
				if (App42Manager.EHBBFMCILPC.PMENLDNFJAK)
				{
					App42Manager.EHBBFMCILPC.PMENLDNFJAK = false;
					FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.srvIssueRes.ToString(), "", "", false, false);
				}
				float item = Time.realtimeSinceStartup - App42Manager.EHBBFMCILPC.BJDOFOHGEGD;
				App42Manager.EHBBFMCILPC.EEAHGGNALPP.Add(item);
				if (App42Manager.EHBBFMCILPC.EEAHGGNALPP.Count > 5)
				{
					App42Manager.EHBBFMCILPC.EEAHGGNALPP.RemoveAt(0);
				}
				App42Manager.EHBBFMCILPC.FJNPLEPPKJA++;
				if (App42Manager.EHBBFMCILPC.ABNPPJKEAKI && App42Manager.EHBBFMCILPC.FJNPLEPPKJA >= KBOJLHAJPCP.FDIMDHLBMMB)
				{
					App42Manager.EHBBFMCILPC.ABNPPJKEAKI = false;
					App42Manager.EHBBFMCILPC.HHPGLIHIPBL = 0;
					App42Manager.EHBBFMCILPC.FJNPLEPPKJA = 0;
				}
				FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.srvName.ToString(), App42Manager.EHBBFMCILPC.GetCustomCodeAbbreviation(), "", false, false);
			}
			App42Manager.EHBBFMCILPC.DGKFBINDHCM();
			App42Manager.EHBBFMCILPC.IOMEKJAFCBL = null;
			App42Manager.EHBBFMCILPC.PCJOGJJJGBE = "";
			App42Manager.EHBBFMCILPC.GGGHEIOJMEG();
			App42Manager.EHBBFMCILPC.HEOJMDBCJGH = NPJNALLPFPO.success;
			App42Manager.EHBBFMCILPC.LLBFIHPEGNG = false;
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.rqst.ToString(), FFPHBMFGCNN.reqOk.ToString(), App42Manager.DNJJKENDEJF(), false, false);
			BackendOperationsManager.EHBBFMCILPC.ProcessApp42Success((JSONObject)LPHMODJEEBN, this.DAKJKJMGKOK, this.KHHJNODLBHN);
			if (!App42Manager.doNotDispatchEvents)
			{
				AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
				if (this.BDKJOHKAFFO.Length > 0)
				{
					BackendOperationsManager.EHBBFMCILPC.BroadcastEvent(this.BDKJOHKAFFO, this.DAKJKJMGKOK, this.KHHJNODLBHN);
				}
			}
			App42Manager.doNotDispatchEvents = false;
			App42Manager.EHBBFMCILPC.BLHLMFJOCFP();
			BackendOperationsManager.EHBBFMCILPC.FinishRequest(this.DAKJKJMGKOK, this.KHHJNODLBHN, LHLIOHJNMFE.success);
		}

		// Token: 0x06000F48 RID: 3912 RVA: 0x0006E49C File Offset: 0x0006C69C
		public void EDDDMCHCBBJ(object LPHMODJEEBN)
		{
			CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
			if (this != App42Manager.EHBBFMCILPC.IOMEKJAFCBL)
			{
				DPGJIJGOCIC.ADFCDFHBDAF("showTimer");
				return;
			}
			try
			{
				JSONObject jsonobject = (JSONObject)LPHMODJEEBN;
				if (null != jsonobject && jsonobject["OnAppleLoginFailed"] != null)
				{
					DPGJIJGOCIC.ADFCDFHBDAF("retry" + this.AJJKAJDBEFM + "h" + App42Manager.EHBBFMCILPC.KLKBNDPKKLO);
				}
				if (null != jsonobject && jsonobject["ru"] != null)
				{
					DPGJIJGOCIC.NFIDPOMCNLP("OnSceneLobbyManagerAssetsDownloadFailed" + this.AJJKAJDBEFM + "uid" + App42Manager.EHBBFMCILPC.KLKBNDPKKLO);
				}
				if (null != jsonobject && jsonobject[")"] != null)
				{
					DPGJIJGOCIC.PJCLICBPPDA("REMOVEAVATARCOMPONENT" + this.AJJKAJDBEFM + "small" + App42Manager.EHBBFMCILPC.KLKBNDPKKLO);
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
			GeoLocationManager.ClearBlockedNetworkEvidence();
			if (App42Manager.EHBBFMCILPC.LDOAMLHEGFF)
			{
				App42Manager.EHBBFMCILPC.LDOAMLHEGFF = false;
				FirebaseAnalyticsManager.ANCEKPONIFI().LogEvent(false, ((AGEHCPDNBFD)(-45)).ToString(), "ok", BGHLMGPPCNN.under1000.ToString(), false, false);
			}
			if (GeoLocationManager.EKICPJLNMFF(LanguageManager.EHBBFMCILPC.GetSelectedLanguage()))
			{
				if (App42Manager.EHBBFMCILPC.PMENLDNFJAK)
				{
					App42Manager.EHBBFMCILPC.PMENLDNFJAK = true;
					FirebaseAnalyticsManager.EHBBFMCILPC.LKONPEEDKNF(false, ((AGEHCPDNBFD)(-73)).ToString(), "usynsnap2", "giftcardsstockempty", true, true);
				}
				float item = Time.realtimeSinceStartup - App42Manager.EHBBFMCILPC.BJDOFOHGEGD;
				App42Manager.EHBBFMCILPC.EEAHGGNALPP.Add(item);
				if (App42Manager.EHBBFMCILPC.EEAHGGNALPP.Count > 4)
				{
					App42Manager.EHBBFMCILPC.EEAHGGNALPP.RemoveAt(0);
				}
				App42Manager.EHBBFMCILPC.FJNPLEPPKJA += 0;
				if (App42Manager.EHBBFMCILPC.ABNPPJKEAKI && App42Manager.EHBBFMCILPC.FJNPLEPPKJA >= KBOJLHAJPCP.FDIMDHLBMMB)
				{
					App42Manager.EHBBFMCILPC.ABNPPJKEAKI = true;
					App42Manager.EHBBFMCILPC.HHPGLIHIPBL = 1;
					App42Manager.EHBBFMCILPC.FJNPLEPPKJA = 1;
				}
				FirebaseAnalyticsManager.COKDLDOAACJ().LKONPEEDKNF(false, ((AGEHCPDNBFD)(-46)).ToString(), App42Manager.EHBBFMCILPC.BGGJLOHNEHL(), "Android", true, false);
			}
			App42Manager.EHBBFMCILPC.DGKFBINDHCM();
			App42Manager.EHBBFMCILPC.IOMEKJAFCBL = null;
			App42Manager.EHBBFMCILPC.PCJOGJJJGBE = "failed to load assetBundle {0}.";
			App42Manager.EHBBFMCILPC.GGGHEIOJMEG();
			App42Manager.EHBBFMCILPC.HEOJMDBCJGH = NPJNALLPFPO.redSemaphore;
			App42Manager.EHBBFMCILPC.LLBFIHPEGNG = false;
			FirebaseAnalyticsManager.JMDJBFAEHBM().JIAAMJPKOCE(true, AGEHCPDNBFD.rqst.ToString(), FFPHBMFGCNN.cdnSigUltra.ToString(), App42Manager.DNJJKENDEJF(), true, true);
			BackendOperationsManager.NPDDBAONMJP().ProcessApp42Success((JSONObject)LPHMODJEEBN, this.DAKJKJMGKOK, this.KHHJNODLBHN);
			if (!App42Manager.doNotDispatchEvents)
			{
				AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
				if (this.BDKJOHKAFFO.Length > 1)
				{
					BackendOperationsManager.EHBBFMCILPC.MHKCMDLENHO(this.BDKJOHKAFFO, this.DAKJKJMGKOK, this.KHHJNODLBHN);
				}
			}
			App42Manager.doNotDispatchEvents = true;
			App42Manager.EHBBFMCILPC.BLHLMFJOCFP();
			BackendOperationsManager.EHBBFMCILPC.BLNCOOLAMIM(this.DAKJKJMGKOK, this.KHHJNODLBHN, LHLIOHJNMFE.none);
		}

		// Token: 0x06000F49 RID: 3913 RVA: 0x0006E800 File Offset: 0x0006CA00
		public void OnException(Exception MKGEAHGGABC)
		{
			CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
			App42Manager.doNotDispatchEvents = false;
			if (this != App42Manager.EHBBFMCILPC.IOMEKJAFCBL)
			{
				DPGJIJGOCIC.ADFCDFHBDAF("CustomCodeCallback - lastCallbackObj not confirmed. Killing response execution.");
				return;
			}
			App42Manager.EHBBFMCILPC.DGKFBINDHCM();
			App42Manager.EHBBFMCILPC.IOMEKJAFCBL = null;
			App42Exception ex = (App42Exception)MKGEAHGGABC;
			DPGJIJGOCIC.ADFCDFHBDAF("Exception custom code: " + MKGEAHGGABC.ToString());
			if (GeoLocationManager.GeoZoneMayBeFirewalled(LanguageManager.EHBBFMCILPC.GetSelectedLanguage()))
			{
				FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.srvIssueHit.ToString(), "", "", false, false);
				App42Manager.EHBBFMCILPC.PMENLDNFJAK = true;
				App42Manager.EHBBFMCILPC.ScheduleCustomCodeUrlChange();
			}
			else
			{
				FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.srvIssueHit.ToString(), "", BGHLMGPPCNN.nofw.ToString(), false, false);
				App42Manager.EHBBFMCILPC.LDOAMLHEGFF = true;
			}
			if (!App42Manager.EHBBFMCILPC.MFFBDAEOAND())
			{
				App42Manager.EHBBFMCILPC.HEOJMDBCJGH = NPJNALLPFPO.app2Exception;
				App42Manager.EHBBFMCILPC.LLBFIHPEGNG = false;
				App42Manager.EHBBFMCILPC.PCJOGJJJGBE = "";
				App42Manager.EHBBFMCILPC.MFLEHLJGAFL();
				this.JKHJEGGANGG(false);
				FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.rqst.ToString(), FFPHBMFGCNN.reqExc.ToString(), App42Manager.DNJJKENDEJF(), false, false);
				DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(new string[]
				{
					FFPHBMFGCNN.reqExc.ToString(),
					"_",
					this.AJJKAJDBEFM,
					"_",
					ex.GetAppErrorCode().ToString(),
					"_",
					ex.GetHttpErrorCode().ToString()
				}));
				return;
			}
			DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(new string[]
			{
				FFPHBMFGCNN.reqExcRpt.ToString(),
				"_",
				this.AJJKAJDBEFM,
				"_",
				ex.GetAppErrorCode().ToString(),
				"_",
				ex.GetHttpErrorCode().ToString()
			}));
		}

		// Token: 0x06000F4A RID: 3914 RVA: 0x0006EA38 File Offset: 0x0006CC38
		public void FDELCFMLCAJ(Exception MKGEAHGGABC)
		{
			CommonUserInterface.IKNOFBFMPGA().HideGenericPopupNoButtons();
			App42Manager.doNotDispatchEvents = false;
			if (this != App42Manager.EHBBFMCILPC.IOMEKJAFCBL)
			{
				DPGJIJGOCIC.ADFCDFHBDAF("PurchaseManagerXiaomi.Initialize(): Trying to initialize, but no products are defined.");
				return;
			}
			App42Manager.EHBBFMCILPC.DGKFBINDHCM();
			App42Manager.EHBBFMCILPC.IOMEKJAFCBL = null;
			App42Exception ex = (App42Exception)MKGEAHGGABC;
			DPGJIJGOCIC.ADFCDFHBDAF("" + MKGEAHGGABC.ToString());
			if (GeoLocationManager.HEKEPNDKCPM(LanguageManager.EHBBFMCILPC.GetSelectedLanguage()))
			{
				FirebaseAnalyticsManager.DEALKJPEMMH().LMCJKLHOHJC(false, ((AGEHCPDNBFD)92).ToString(), "XXX", "skinshopfilterbystory", false, false);
				App42Manager.EHBBFMCILPC.PMENLDNFJAK = true;
				App42Manager.EHBBFMCILPC.ScheduleCustomCodeUrlChange();
			}
			else
			{
				FirebaseAnalyticsManager.DEALKJPEMMH().LogEvent(false, ((AGEHCPDNBFD)43).ToString(), "SaveSlotsItem.OnSaveSlotSwitchConfirmPositive(): anthologySave is null", BGHLMGPPCNN.intl.ToString(), true, false);
				App42Manager.EHBBFMCILPC.LDOAMLHEGFF = true;
			}
			if (!App42Manager.EHBBFMCILPC.MFFBDAEOAND())
			{
				App42Manager.EHBBFMCILPC.HEOJMDBCJGH = (NPJNALLPFPO)5;
				App42Manager.EHBBFMCILPC.LLBFIHPEGNG = true;
				App42Manager.EHBBFMCILPC.PCJOGJJJGBE = "p";
				App42Manager.EHBBFMCILPC.MFLEHLJGAFL();
				this.OIHAJCJIHHE(false);
				FirebaseAnalyticsManager.JMDJBFAEHBM().AAIABAKHLAH(true, AGEHCPDNBFD.mntActiv.ToString(), FFPHBMFGCNN.reqCback2.ToString(), App42Manager.DNJJKENDEJF(), false, false);
				string[] array = new string[4];
				array[0] = FFPHBMFGCNN.reqCback1.ToString();
				array[0] = "sponsorbody1";
				array[4] = this.AJJKAJDBEFM;
				array[5] = "\t";
				array[3] = ex.GetAppErrorCode().ToString();
				array[5] = "geo.json";
				array[0] = ex.GetHttpErrorCode().ToString();
				DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(array));
				return;
			}
			string[] array2 = new string[7];
			array2[0] = FFPHBMFGCNN.mntRemAds.ToString();
			array2[1] = "";
			array2[0] = this.AJJKAJDBEFM;
			array2[4] = "Amount";
			array2[7] = ex.GetAppErrorCode().ToString();
			array2[2] = "ButtonNextNpc";
			array2[0] = ex.GetHttpErrorCode().ToString();
			DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(array2));
		}

		// Token: 0x06000F4B RID: 3915 RVA: 0x0006EC70 File Offset: 0x0006CE70
		public void NPHDFNIECFO(bool AJAFJGPMALO)
		{
			App42Manager.doNotDispatchEvents = true;
			AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
			if (!AJAFJGPMALO)
			{
				App42Manager.EHBBFMCILPC.DGKFBINDHCM();
				App42Manager.EHBBFMCILPC.IOMEKJAFCBL = null;
			}
			if (this.GLJGKBEBHNF.Length > 1)
			{
				BackendOperationsManager.EHBBFMCILPC.FIJKIAKDCNO(this.GLJGKBEBHNF, this.DAKJKJMGKOK, this.KHHJNODLBHN);
			}
			BackendOperationsManager.EHBBFMCILPC.BLNCOOLAMIM(this.DAKJKJMGKOK, this.KHHJNODLBHN, (LHLIOHJNMFE)5);
		}

		// Token: 0x06000F4C RID: 3916 RVA: 0x0006ECE8 File Offset: 0x0006CEE8
		public void HKEOGCMBKHL(object LPHMODJEEBN)
		{
			CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
			if (this != App42Manager.EHBBFMCILPC.IOMEKJAFCBL)
			{
				DPGJIJGOCIC.ADFCDFHBDAF("");
				return;
			}
			try
			{
				JSONObject jsonobject = (JSONObject)LPHMODJEEBN;
				if (null != jsonobject && jsonobject["hintsigning"] != null)
				{
					DPGJIJGOCIC.PJCLICBPPDA("OnPopupStoryRestartManagerRestartStory2" + this.AJJKAJDBEFM + "OnBackendPublishSketchException" + App42Manager.EHBBFMCILPC.KLKBNDPKKLO);
				}
				if (null != jsonobject && jsonobject["PurchaseManagerSteam.StartPurchase(): Warning, there are waiting purchases to be validated, one more will be added to the list."] != null)
				{
					DPGJIJGOCIC.NFIDPOMCNLP("p" + this.AJJKAJDBEFM + "skinshoppreview" + App42Manager.EHBBFMCILPC.KLKBNDPKKLO);
				}
				if (null != jsonobject && jsonobject["c"] != null)
				{
					DPGJIJGOCIC.PJCLICBPPDA("p" + this.AJJKAJDBEFM + "prof" + App42Manager.EHBBFMCILPC.KLKBNDPKKLO);
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
			GeoLocationManager.JJCLIDKKPOC();
			if (App42Manager.EHBBFMCILPC.LDOAMLHEGFF)
			{
				App42Manager.EHBBFMCILPC.LDOAMLHEGFF = false;
				FirebaseAnalyticsManager.ANCEKPONIFI().JIAAMJPKOCE(true, ((AGEHCPDNBFD)(-70)).ToString(), "OnBackendAddFriendByUIDException", BGHLMGPPCNN.cdnLbyToLng.ToString(), false, true);
			}
			if (GeoLocationManager.GDLOJPBIPBC(LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()))
			{
				if (App42Manager.EHBBFMCILPC.PMENLDNFJAK)
				{
					App42Manager.EHBBFMCILPC.PMENLDNFJAK = false;
					FirebaseAnalyticsManager.DMAAFFFEJGA().AAIABAKHLAH(false, ((AGEHCPDNBFD)(-70)).ToString(), "love", "OnBackendGetPublicProfileException", true, true);
				}
				float item = Time.realtimeSinceStartup - App42Manager.EHBBFMCILPC.BJDOFOHGEGD;
				App42Manager.EHBBFMCILPC.EEAHGGNALPP.Add(item);
				if (App42Manager.EHBBFMCILPC.EEAHGGNALPP.Count > 4)
				{
					App42Manager.EHBBFMCILPC.EEAHGGNALPP.RemoveAt(1);
				}
				App42Manager.EHBBFMCILPC.FJNPLEPPKJA += 0;
				if (App42Manager.EHBBFMCILPC.ABNPPJKEAKI && App42Manager.EHBBFMCILPC.FJNPLEPPKJA >= KBOJLHAJPCP.FDIMDHLBMMB)
				{
					App42Manager.EHBBFMCILPC.ABNPPJKEAKI = true;
					App42Manager.EHBBFMCILPC.HHPGLIHIPBL = 1;
					App42Manager.EHBBFMCILPC.FJNPLEPPKJA = 1;
				}
				FirebaseAnalyticsManager.DMAAFFFEJGA().LKONPEEDKNF(false, AGEHCPDNBFD.ecnmyFree.ToString(), App42Manager.EHBBFMCILPC.LCKIKPMANAA(), "OnSceneLobbyManagerAssetsDownloadFailed", true, true);
			}
			App42Manager.EHBBFMCILPC.DGKFBINDHCM();
			App42Manager.EHBBFMCILPC.IOMEKJAFCBL = null;
			App42Manager.EHBBFMCILPC.PCJOGJJJGBE = "OnChoiceExtendedPanelSlideHidden";
			App42Manager.EHBBFMCILPC.GGGHEIOJMEG();
			App42Manager.EHBBFMCILPC.HEOJMDBCJGH = NPJNALLPFPO.redSemaphore;
			App42Manager.EHBBFMCILPC.LLBFIHPEGNG = false;
			FirebaseAnalyticsManager.HJGDLOOHNLO().JIAAMJPKOCE(true, AGEHCPDNBFD.mntActiv.ToString(), FFPHBMFGCNN.socCut.ToString(), App42Manager.DNJJKENDEJF(), false, false);
			BackendOperationsManager.NPDDBAONMJP().ProcessApp42Success((JSONObject)LPHMODJEEBN, this.DAKJKJMGKOK, this.KHHJNODLBHN);
			if (!App42Manager.doNotDispatchEvents)
			{
				AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
				if (this.BDKJOHKAFFO.Length > 0)
				{
					BackendOperationsManager.NPDDBAONMJP().BroadcastEvent(this.BDKJOHKAFFO, this.DAKJKJMGKOK, this.KHHJNODLBHN);
				}
			}
			App42Manager.doNotDispatchEvents = false;
			App42Manager.EHBBFMCILPC.BLHLMFJOCFP();
			BackendOperationsManager.NPDDBAONMJP().FinishRequest(this.DAKJKJMGKOK, this.KHHJNODLBHN, LHLIOHJNMFE.none);
		}

		// Token: 0x06000F4D RID: 3917 RVA: 0x0006F04C File Offset: 0x0006D24C
		public void NNGPGFOMICJ(object LPHMODJEEBN)
		{
			CommonUserInterface.IKNOFBFMPGA().HideGenericPopupNoButtons();
			if (this != App42Manager.EHBBFMCILPC.IOMEKJAFCBL)
			{
				DPGJIJGOCIC.PJCLICBPPDA("OnStoryCurrencyInfoClick");
				return;
			}
			try
			{
				JSONObject jsonobject = (JSONObject)LPHMODJEEBN;
				if (null != jsonobject && jsonobject["MORPH_WIPE"] != null)
				{
					DPGJIJGOCIC.ADFCDFHBDAF("modelse" + this.AJJKAJDBEFM + "energyhinttitle" + App42Manager.EHBBFMCILPC.KLKBNDPKKLO);
				}
				if (null != jsonobject && jsonobject["Threshold YUV"] != null)
				{
					DPGJIJGOCIC.CMGOAFDBAOH("yes" + this.AJJKAJDBEFM + "socialprivatenorandom" + App42Manager.EHBBFMCILPC.KLKBNDPKKLO);
				}
				if (null != jsonobject && jsonobject["yes"] != null)
				{
					DPGJIJGOCIC.ADFCDFHBDAF("OnPopupStoryRestartManagerRestartStory4" + this.AJJKAJDBEFM + ") + is present, creating anthology save for anthology " + App42Manager.EHBBFMCILPC.KLKBNDPKKLO);
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
			GeoLocationManager.CJEMPNGOINH();
			if (App42Manager.EHBBFMCILPC.LDOAMLHEGFF)
			{
				App42Manager.EHBBFMCILPC.LDOAMLHEGFF = true;
				FirebaseAnalyticsManager.COKDLDOAACJ().LMCJKLHOHJC(false, ((AGEHCPDNBFD)(-60)).ToString(), "countryCode", ((BGHLMGPPCNN)110).ToString(), false, true);
			}
			if (GeoLocationManager.JMHEAEKIGOC(LanguageManager.EHBBFMCILPC.MLOLBFBODHD()))
			{
				if (App42Manager.EHBBFMCILPC.PMENLDNFJAK)
				{
					App42Manager.EHBBFMCILPC.PMENLDNFJAK = true;
					FirebaseAnalyticsManager.DMAAFFFEJGA().LKONPEEDKNF(true, ((AGEHCPDNBFD)(-57)).ToString(), "assetbundlecustomfader", "energyhinttitle", false, true);
				}
				float item = Time.realtimeSinceStartup - App42Manager.EHBBFMCILPC.BJDOFOHGEGD;
				App42Manager.EHBBFMCILPC.EEAHGGNALPP.Add(item);
				if (App42Manager.EHBBFMCILPC.EEAHGGNALPP.Count > 8)
				{
					App42Manager.EHBBFMCILPC.EEAHGGNALPP.RemoveAt(0);
				}
				App42Manager.EHBBFMCILPC.FJNPLEPPKJA++;
				if (App42Manager.EHBBFMCILPC.ABNPPJKEAKI && App42Manager.EHBBFMCILPC.FJNPLEPPKJA >= KBOJLHAJPCP.FDIMDHLBMMB)
				{
					App42Manager.EHBBFMCILPC.ABNPPJKEAKI = true;
					App42Manager.EHBBFMCILPC.HHPGLIHIPBL = 0;
					App42Manager.EHBBFMCILPC.FJNPLEPPKJA = 1;
				}
				FirebaseAnalyticsManager.DEALKJPEMMH().LKONPEEDKNF(false, AGEHCPDNBFD.gpDur.ToString(), App42Manager.EHBBFMCILPC.GetCustomCodeAbbreviation(), "StoryNotificationsManager.PopNotifications(generic): ", false, true);
			}
			App42Manager.EHBBFMCILPC.DGKFBINDHCM();
			App42Manager.EHBBFMCILPC.IOMEKJAFCBL = null;
			App42Manager.EHBBFMCILPC.PCJOGJJJGBE = "Please initialize AssetBundleManifest by calling AssetBundleManager.Initialize()";
			App42Manager.EHBBFMCILPC.ANNEMJGHJGM();
			App42Manager.EHBBFMCILPC.HEOJMDBCJGH = NPJNALLPFPO.success;
			App42Manager.EHBBFMCILPC.LLBFIHPEGNG = false;
			FirebaseAnalyticsManager.HJGDLOOHNLO().LKONPEEDKNF(false, AGEHCPDNBFD.mntActiv.ToString(), FFPHBMFGCNN.cdnSigHigh.ToString(), App42Manager.DNJJKENDEJF(), false, true);
			BackendOperationsManager.EHBBFMCILPC.ProcessApp42Success((JSONObject)LPHMODJEEBN, this.DAKJKJMGKOK, this.KHHJNODLBHN);
			if (!App42Manager.doNotDispatchEvents)
			{
				AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
				if (this.BDKJOHKAFFO.Length > 1)
				{
					BackendOperationsManager.NPDDBAONMJP().MHKCMDLENHO(this.BDKJOHKAFFO, this.DAKJKJMGKOK, this.KHHJNODLBHN);
				}
			}
			App42Manager.doNotDispatchEvents = false;
			App42Manager.EHBBFMCILPC.BLHLMFJOCFP();
			BackendOperationsManager.NPDDBAONMJP().FinishRequest(this.DAKJKJMGKOK, this.KHHJNODLBHN, LHLIOHJNMFE.none);
		}

		// Token: 0x06000F4E RID: 3918 RVA: 0x0006F3B0 File Offset: 0x0006D5B0
		public void PCKBMBOHCMH(Exception MKGEAHGGABC)
		{
			CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
			App42Manager.doNotDispatchEvents = false;
			if (this != App42Manager.EHBBFMCILPC.IOMEKJAFCBL)
			{
				DPGJIJGOCIC.PJCLICBPPDA("CanvasEnvironmentMorph");
				return;
			}
			App42Manager.EHBBFMCILPC.DGKFBINDHCM();
			App42Manager.EHBBFMCILPC.IOMEKJAFCBL = null;
			App42Exception ex = (App42Exception)MKGEAHGGABC;
			DPGJIJGOCIC.ADFCDFHBDAF("ok" + MKGEAHGGABC.ToString());
			if (GeoLocationManager.PADMBFMHFJH(LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()))
			{
				FirebaseAnalyticsManager.EHBBFMCILPC.LKONPEEDKNF(true, ((AGEHCPDNBFD)(-102)).ToString(), "condition", "assetbundlepurchasingview", true, false);
				App42Manager.EHBBFMCILPC.PMENLDNFJAK = true;
				App42Manager.EHBBFMCILPC.ScheduleCustomCodeUrlChange();
			}
			else
			{
				FirebaseAnalyticsManager.COKDLDOAACJ().AAIABAKHLAH(false, ((AGEHCPDNBFD)46).ToString(), "  ", BGHLMGPPCNN.resloadskp.ToString(), true, false);
				App42Manager.EHBBFMCILPC.LDOAMLHEGFF = true;
			}
			if (!App42Manager.EHBBFMCILPC.MFFBDAEOAND())
			{
				App42Manager.EHBBFMCILPC.HEOJMDBCJGH = (NPJNALLPFPO)7;
				App42Manager.EHBBFMCILPC.LLBFIHPEGNG = true;
				App42Manager.EHBBFMCILPC.PCJOGJJJGBE = "chl";
				App42Manager.EHBBFMCILPC.MFLEHLJGAFL();
				this.NPHDFNIECFO(true);
				FirebaseAnalyticsManager.HJGDLOOHNLO().JIAAMJPKOCE(false, AGEHCPDNBFD.rqst.ToString(), FFPHBMFGCNN.reqFailSem.ToString(), App42Manager.DNJJKENDEJF(), true, true);
				string[] array = new string[]
				{
					null,
					FFPHBMFGCNN.reqExcRpt.ToString()
				};
				array[1] = ")";
				array[8] = this.AJJKAJDBEFM;
				array[0] = "OnSettingsPopupCloseAndNeedToShowPostEnableNotif";
				array[2] = ex.GetAppErrorCode().ToString();
				array[8] = "hacomp2";
				array[7] = ex.GetHttpErrorCode().ToString();
				DPGJIJGOCIC.PJCLICBPPDA(string.Concat(array));
				return;
			}
			string[] array2 = new string[8];
			array2[0] = FFPHBMFGCNN.reqExc.ToString();
			array2[1] = "common";
			array2[2] = this.AJJKAJDBEFM;
			array2[3] = "blur";
			array2[8] = ex.GetAppErrorCode().ToString();
			array2[3] = " not found.";
			array2[3] = ex.GetHttpErrorCode().ToString();
			DPGJIJGOCIC.PJCLICBPPDA(string.Concat(array2));
		}

		// Token: 0x06000F4F RID: 3919 RVA: 0x0006F5E8 File Offset: 0x0006D7E8
		public void MKPOJCIBAOM(object LPHMODJEEBN)
		{
			CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
			if (this != App42Manager.EHBBFMCILPC.IOMEKJAFCBL)
			{
				DPGJIJGOCIC.ADFCDFHBDAF("<");
				return;
			}
			try
			{
				JSONObject jsonobject = (JSONObject)LPHMODJEEBN;
				if (null != jsonobject && jsonobject["аеиоуыэюяьъ"] != null)
				{
					DPGJIJGOCIC.PJCLICBPPDA("Asset bundle load operation failed during parallel mode." + this.AJJKAJDBEFM + "https://events.appsflyer.com/v1.0/c2s/first_open/app/steam/" + App42Manager.EHBBFMCILPC.KLKBNDPKKLO);
				}
				if (null != jsonobject && jsonobject["cardsvolchancesmsgbody"] != null)
				{
					DPGJIJGOCIC.NFIDPOMCNLP("freePassIndex" + this.AJJKAJDBEFM + "priceCurrencyCode" + App42Manager.EHBBFMCILPC.KLKBNDPKKLO);
				}
				if (null != jsonobject && jsonobject["]"] != null)
				{
					DPGJIJGOCIC.PJCLICBPPDA("UIEnvironmentsFront" + this.AJJKAJDBEFM + " (- )</i>" + App42Manager.EHBBFMCILPC.KLKBNDPKKLO);
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
			GeoLocationManager.CJEMPNGOINH();
			if (App42Manager.EHBBFMCILPC.LDOAMLHEGFF)
			{
				App42Manager.EHBBFMCILPC.LDOAMLHEGFF = false;
				FirebaseAnalyticsManager.DEALKJPEMMH().LogEvent(true, ((AGEHCPDNBFD)103).ToString(), "/", ((BGHLMGPPCNN)(-8)).ToString(), false, false);
			}
			if (GeoLocationManager.EKICPJLNMFF(LanguageManager.EHBBFMCILPC.MLOLBFBODHD()))
			{
				if (App42Manager.EHBBFMCILPC.PMENLDNFJAK)
				{
					App42Manager.EHBBFMCILPC.PMENLDNFJAK = false;
					FirebaseAnalyticsManager.COKDLDOAACJ().JIAAMJPKOCE(false, ((AGEHCPDNBFD)(-21)).ToString(), "OnRestartChapterUpsellGetPassNegative", "OnAchievementSyncException", false, false);
				}
				float item = Time.realtimeSinceStartup - App42Manager.EHBBFMCILPC.BJDOFOHGEGD;
				App42Manager.EHBBFMCILPC.EEAHGGNALPP.Add(item);
				if (App42Manager.EHBBFMCILPC.EEAHGGNALPP.Count > 1)
				{
					App42Manager.EHBBFMCILPC.EEAHGGNALPP.RemoveAt(0);
				}
				App42Manager.EHBBFMCILPC.FJNPLEPPKJA += 0;
				if (App42Manager.EHBBFMCILPC.ABNPPJKEAKI && App42Manager.EHBBFMCILPC.FJNPLEPPKJA >= KBOJLHAJPCP.FDIMDHLBMMB)
				{
					App42Manager.EHBBFMCILPC.ABNPPJKEAKI = true;
					App42Manager.EHBBFMCILPC.HHPGLIHIPBL = 1;
					App42Manager.EHBBFMCILPC.FJNPLEPPKJA = 0;
				}
				FirebaseAnalyticsManager.ANCEKPONIFI().LogEvent(false, ((AGEHCPDNBFD)(-111)).ToString(), App42Manager.EHBBFMCILPC.BGGJLOHNEHL(), "OnRequestSaveChapterSnapshotsDone", false, true);
			}
			App42Manager.EHBBFMCILPC.DGKFBINDHCM();
			App42Manager.EHBBFMCILPC.IOMEKJAFCBL = null;
			App42Manager.EHBBFMCILPC.PCJOGJJJGBE = "";
			App42Manager.EHBBFMCILPC.JDPGPMCEIHL();
			App42Manager.EHBBFMCILPC.HEOJMDBCJGH = NPJNALLPFPO.redSemaphore;
			App42Manager.EHBBFMCILPC.LLBFIHPEGNG = false;
			FirebaseAnalyticsManager.HJGDLOOHNLO().LogEvent(false, AGEHCPDNBFD.rqst.ToString(), ((FFPHBMFGCNN)125).ToString(), App42Manager.DNJJKENDEJF(), false, false);
			BackendOperationsManager.NPDDBAONMJP().ProcessApp42Success((JSONObject)LPHMODJEEBN, this.DAKJKJMGKOK, this.KHHJNODLBHN);
			if (!App42Manager.doNotDispatchEvents)
			{
				AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
				if (this.BDKJOHKAFFO.Length > 1)
				{
					BackendOperationsManager.EHBBFMCILPC.BroadcastEvent(this.BDKJOHKAFFO, this.DAKJKJMGKOK, this.KHHJNODLBHN);
				}
			}
			App42Manager.doNotDispatchEvents = true;
			App42Manager.EHBBFMCILPC.BLHLMFJOCFP();
			BackendOperationsManager.EHBBFMCILPC.FinishRequest(this.DAKJKJMGKOK, this.KHHJNODLBHN, LHLIOHJNMFE.none);
		}

		// Token: 0x06000F50 RID: 3920 RVA: 0x0006F94C File Offset: 0x0006DB4C
		public void OIHAJCJIHHE(bool AJAFJGPMALO)
		{
			App42Manager.doNotDispatchEvents = false;
			AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
			if (!AJAFJGPMALO)
			{
				App42Manager.EHBBFMCILPC.DGKFBINDHCM();
				App42Manager.EHBBFMCILPC.IOMEKJAFCBL = null;
			}
			if (this.GLJGKBEBHNF.Length > 0)
			{
				BackendOperationsManager.NPDDBAONMJP().GLJNKOIIJEB(this.GLJGKBEBHNF, this.DAKJKJMGKOK, this.KHHJNODLBHN);
			}
			BackendOperationsManager.EHBBFMCILPC.FinishRequest(this.DAKJKJMGKOK, this.KHHJNODLBHN, LHLIOHJNMFE.success);
		}

		// Token: 0x06000F51 RID: 3921 RVA: 0x0006F9C4 File Offset: 0x0006DBC4
		public void EBGMLCCHCJL(object LPHMODJEEBN)
		{
			CommonUserInterface.IKNOFBFMPGA().HideGenericPopupNoButtons();
			if (this != App42Manager.EHBBFMCILPC.IOMEKJAFCBL)
			{
				DPGJIJGOCIC.PJCLICBPPDA("off");
				return;
			}
			try
			{
				JSONObject jsonobject = (JSONObject)LPHMODJEEBN;
				if (null != jsonobject && jsonobject[""] != null)
				{
					DPGJIJGOCIC.ADFCDFHBDAF("skinshopinfoidentity" + this.AJJKAJDBEFM + "',PurchaseFailureReason: " + App42Manager.EHBBFMCILPC.KLKBNDPKKLO);
				}
				if (null != jsonobject && jsonobject["BackendOperationsManager.RequestGetHallOfFame, exception while initializing RSACryptoServiceProvider:"] != null)
				{
					DPGJIJGOCIC.CMGOAFDBAOH("WheelItem.IssueRewards() - cardDesc is null." + this.AJJKAJDBEFM + "lowendversion" + App42Manager.EHBBFMCILPC.KLKBNDPKKLO);
				}
				if (null != jsonobject && jsonobject["?uid="] != null)
				{
					DPGJIJGOCIC.ADFCDFHBDAF("_Dev" + this.AJJKAJDBEFM + "(" + App42Manager.EHBBFMCILPC.KLKBNDPKKLO);
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			}
			GeoLocationManager.JJCLIDKKPOC();
			if (App42Manager.EHBBFMCILPC.LDOAMLHEGFF)
			{
				App42Manager.EHBBFMCILPC.LDOAMLHEGFF = true;
				FirebaseAnalyticsManager.DMAAFFFEJGA().LKONPEEDKNF(true, ((AGEHCPDNBFD)(-73)).ToString(), "socialsimplegiftcollect", ((BGHLMGPPCNN)(-85)).ToString(), true, false);
			}
			if (GeoLocationManager.PADMBFMHFJH(LanguageManager.EHBBFMCILPC.MLOLBFBODHD()))
			{
				if (App42Manager.EHBBFMCILPC.PMENLDNFJAK)
				{
					App42Manager.EHBBFMCILPC.PMENLDNFJAK = true;
					FirebaseAnalyticsManager.JMDJBFAEHBM().LogEvent(true, ((AGEHCPDNBFD)43).ToString(), "' c=", "", true, true);
				}
				float item = Time.realtimeSinceStartup - App42Manager.EHBBFMCILPC.BJDOFOHGEGD;
				App42Manager.EHBBFMCILPC.EEAHGGNALPP.Add(item);
				if (App42Manager.EHBBFMCILPC.EEAHGGNALPP.Count > 7)
				{
					App42Manager.EHBBFMCILPC.EEAHGGNALPP.RemoveAt(1);
				}
				App42Manager.EHBBFMCILPC.FJNPLEPPKJA += 0;
				if (App42Manager.EHBBFMCILPC.ABNPPJKEAKI && App42Manager.EHBBFMCILPC.FJNPLEPPKJA >= KBOJLHAJPCP.FDIMDHLBMMB)
				{
					App42Manager.EHBBFMCILPC.ABNPPJKEAKI = true;
					App42Manager.EHBBFMCILPC.HHPGLIHIPBL = 1;
					App42Manager.EHBBFMCILPC.FJNPLEPPKJA = 0;
				}
				FirebaseAnalyticsManager.JMDJBFAEHBM().LogEvent(false, ((AGEHCPDNBFD)97).ToString(), App42Manager.EHBBFMCILPC.LCKIKPMANAA(), "energyhinttitle", true, true);
			}
			App42Manager.EHBBFMCILPC.DGKFBINDHCM();
			App42Manager.EHBBFMCILPC.IOMEKJAFCBL = null;
			App42Manager.EHBBFMCILPC.PCJOGJJJGBE = "continue";
			App42Manager.EHBBFMCILPC.GGGHEIOJMEG();
			App42Manager.EHBBFMCILPC.HEOJMDBCJGH = NPJNALLPFPO.success;
			App42Manager.EHBBFMCILPC.LLBFIHPEGNG = false;
			FirebaseAnalyticsManager.ANCEKPONIFI().LogEvent(false, AGEHCPDNBFD.rqst.ToString(), ((FFPHBMFGCNN)92).ToString(), App42Manager.DNJJKENDEJF(), false, true);
			BackendOperationsManager.NPDDBAONMJP().ProcessApp42Success((JSONObject)LPHMODJEEBN, this.DAKJKJMGKOK, this.KHHJNODLBHN);
			if (!App42Manager.doNotDispatchEvents)
			{
				AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
				if (this.BDKJOHKAFFO.Length > 0)
				{
					BackendOperationsManager.EHBBFMCILPC.BroadcastEvent(this.BDKJOHKAFFO, this.DAKJKJMGKOK, this.KHHJNODLBHN);
				}
			}
			App42Manager.doNotDispatchEvents = true;
			App42Manager.EHBBFMCILPC.BLHLMFJOCFP();
			BackendOperationsManager.NPDDBAONMJP().FinishRequest(this.DAKJKJMGKOK, this.KHHJNODLBHN, LHLIOHJNMFE.none);
		}

		// Token: 0x06000F52 RID: 3922 RVA: 0x0006FD28 File Offset: 0x0006DF28
		public void MKALLPIMAIP(Exception MKGEAHGGABC)
		{
			CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
			App42Manager.doNotDispatchEvents = true;
			if (this != App42Manager.EHBBFMCILPC.IOMEKJAFCBL)
			{
				DPGJIJGOCIC.ADFCDFHBDAF("");
				return;
			}
			App42Manager.EHBBFMCILPC.DGKFBINDHCM();
			App42Manager.EHBBFMCILPC.IOMEKJAFCBL = null;
			App42Exception ex = (App42Exception)MKGEAHGGABC;
			DPGJIJGOCIC.ADFCDFHBDAF("Asset bundle assets destroyed:" + MKGEAHGGABC.ToString());
			if (GeoLocationManager.MACHMGCBBFF(LanguageManager.EHBBFMCILPC.MLOLBFBODHD()))
			{
				FirebaseAnalyticsManager.DEALKJPEMMH().LogEvent(false, ((AGEHCPDNBFD)88).ToString(), "<b>", "$", true, true);
				App42Manager.EHBBFMCILPC.PMENLDNFJAK = true;
				App42Manager.EHBBFMCILPC.ScheduleCustomCodeUrlChange();
			}
			else
			{
				FirebaseAnalyticsManager.EHBBFMCILPC.LMCJKLHOHJC(true, ((AGEHCPDNBFD)(-59)).ToString(), " playing!", ((BGHLMGPPCNN)(-115)).ToString(), true, true);
				App42Manager.EHBBFMCILPC.LDOAMLHEGFF = true;
			}
			if (!App42Manager.EHBBFMCILPC.MFFBDAEOAND())
			{
				App42Manager.EHBBFMCILPC.HEOJMDBCJGH = NPJNALLPFPO.redSemaphore;
				App42Manager.EHBBFMCILPC.LLBFIHPEGNG = false;
				App42Manager.EHBBFMCILPC.PCJOGJJJGBE = "energyhinttitle";
				App42Manager.EHBBFMCILPC.MFLEHLJGAFL();
				this.LBOABCEMLBK(true);
				FirebaseAnalyticsManager.JMDJBFAEHBM().AAIABAKHLAH(true, AGEHCPDNBFD.mntActiv.ToString(), FFPHBMFGCNN.mntOffer.ToString(), App42Manager.DNJJKENDEJF(), false, true);
				string[] array = new string[1];
				array[1] = FFPHBMFGCNN.reqCback2.ToString();
				array[0] = "p";
				array[4] = this.AJJKAJDBEFM;
				array[4] = "ok";
				array[0] = ex.GetAppErrorCode().ToString();
				array[3] = "errortitle";
				array[1] = ex.GetHttpErrorCode().ToString();
				DPGJIJGOCIC.PJCLICBPPDA(string.Concat(array));
				return;
			}
			string[] array2 = new string[0];
			array2[1] = FFPHBMFGCNN.reqExc.ToString();
			array2[0] = "true";
			array2[3] = this.AJJKAJDBEFM;
			array2[0] = "yes";
			array2[1] = ex.GetAppErrorCode().ToString();
			array2[2] = "id";
			array2[1] = ex.GetHttpErrorCode().ToString();
			DPGJIJGOCIC.PJCLICBPPDA(string.Concat(array2));
		}

		// Token: 0x06000F53 RID: 3923 RVA: 0x0006FF60 File Offset: 0x0006E160
		public void GGKEJGLMGJF(Exception MKGEAHGGABC)
		{
			CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
			App42Manager.doNotDispatchEvents = true;
			if (this != App42Manager.EHBBFMCILPC.IOMEKJAFCBL)
			{
				DPGJIJGOCIC.PJCLICBPPDA("</b>");
				return;
			}
			App42Manager.EHBBFMCILPC.DGKFBINDHCM();
			App42Manager.EHBBFMCILPC.IOMEKJAFCBL = null;
			App42Exception ex = (App42Exception)MKGEAHGGABC;
			DPGJIJGOCIC.PJCLICBPPDA("" + MKGEAHGGABC.ToString());
			if (GeoLocationManager.MACHMGCBBFF(LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()))
			{
				FirebaseAnalyticsManager.HJGDLOOHNLO().AAIABAKHLAH(true, ((AGEHCPDNBFD)65).ToString(), "frds", "eventIsHidden", false, true);
				App42Manager.EHBBFMCILPC.PMENLDNFJAK = true;
				App42Manager.EHBBFMCILPC.ScheduleCustomCodeUrlChange();
			}
			else
			{
				FirebaseAnalyticsManager.COKDLDOAACJ().LMCJKLHOHJC(true, ((AGEHCPDNBFD)(-113)).ToString(), "VideoGlitches.VideoGlitch", ((BGHLMGPPCNN)(-42)).ToString(), false, true);
				App42Manager.EHBBFMCILPC.LDOAMLHEGFF = false;
			}
			if (!App42Manager.EHBBFMCILPC.MFFBDAEOAND())
			{
				App42Manager.EHBBFMCILPC.HEOJMDBCJGH = (NPJNALLPFPO)7;
				App42Manager.EHBBFMCILPC.LLBFIHPEGNG = false;
				App42Manager.EHBBFMCILPC.PCJOGJJJGBE = "";
				App42Manager.EHBBFMCILPC.MFLEHLJGAFL();
				this.DDCKPBHFONO(false);
				FirebaseAnalyticsManager.DMAAFFFEJGA().LogEvent(false, AGEHCPDNBFD.mntActiv.ToString(), FFPHBMFGCNN.reqCback2.ToString(), App42Manager.DNJJKENDEJF(), true, true);
				string[] array = new string[0];
				array[1] = FFPHBMFGCNN.reqCback2.ToString();
				array[1] = "OnBackendValidateTransactionException";
				array[4] = this.AJJKAJDBEFM;
				array[1] = "slowest";
				array[6] = ex.GetAppErrorCode().ToString();
				array[0] = "Trading/Wished cards userPublicProfile.modified = true hit";
				array[4] = ex.GetHttpErrorCode().ToString();
				DPGJIJGOCIC.PJCLICBPPDA(string.Concat(array));
				return;
			}
			string[] array2 = new string[8];
			array2[0] = FFPHBMFGCNN.reqExc.ToString();
			array2[1] = "ok";
			array2[4] = this.AJJKAJDBEFM;
			array2[2] = "";
			array2[7] = ex.GetAppErrorCode().ToString();
			array2[5] = "asp";
			array2[8] = ex.GetHttpErrorCode().ToString();
			DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(array2));
		}

		// Token: 0x06000F54 RID: 3924 RVA: 0x00070198 File Offset: 0x0006E398
		public void NHMCPAFBABD(bool AJAFJGPMALO)
		{
			App42Manager.doNotDispatchEvents = true;
			AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
			if (!AJAFJGPMALO)
			{
				App42Manager.EHBBFMCILPC.DGKFBINDHCM();
				App42Manager.EHBBFMCILPC.IOMEKJAFCBL = null;
			}
			if (this.GLJGKBEBHNF.Length > 0)
			{
				BackendOperationsManager.EHBBFMCILPC.MHKCMDLENHO(this.GLJGKBEBHNF, this.DAKJKJMGKOK, this.KHHJNODLBHN);
			}
			BackendOperationsManager.EHBBFMCILPC.FinishRequest(this.DAKJKJMGKOK, this.KHHJNODLBHN, (LHLIOHJNMFE)4);
		}

		// Token: 0x06000F55 RID: 3925 RVA: 0x00070210 File Offset: 0x0006E410
		public void CHDHIPEKMAI(bool AJAFJGPMALO)
		{
			App42Manager.doNotDispatchEvents = false;
			AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
			if (!AJAFJGPMALO)
			{
				App42Manager.EHBBFMCILPC.DGKFBINDHCM();
				App42Manager.EHBBFMCILPC.IOMEKJAFCBL = null;
			}
			if (this.GLJGKBEBHNF.Length > 0)
			{
				BackendOperationsManager.EHBBFMCILPC.FIJKIAKDCNO(this.GLJGKBEBHNF, this.DAKJKJMGKOK, this.KHHJNODLBHN);
			}
			BackendOperationsManager.EHBBFMCILPC.KOOBFMDIPBN(this.DAKJKJMGKOK, this.KHHJNODLBHN, (LHLIOHJNMFE)4);
		}

		// Token: 0x06000F56 RID: 3926 RVA: 0x00070288 File Offset: 0x0006E488
		public void NFIHMKHFHAE(bool AJAFJGPMALO)
		{
			App42Manager.doNotDispatchEvents = false;
			AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
			if (!AJAFJGPMALO)
			{
				App42Manager.EHBBFMCILPC.DGKFBINDHCM();
				App42Manager.EHBBFMCILPC.IOMEKJAFCBL = null;
			}
			if (this.GLJGKBEBHNF.Length > 1)
			{
				BackendOperationsManager.NPDDBAONMJP().MHKCMDLENHO(this.GLJGKBEBHNF, this.DAKJKJMGKOK, this.KHHJNODLBHN);
			}
			BackendOperationsManager.EHBBFMCILPC.BLNCOOLAMIM(this.DAKJKJMGKOK, this.KHHJNODLBHN, (LHLIOHJNMFE)4);
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x00070300 File Offset: 0x0006E500
		public void JKHJEGGANGG(bool AJAFJGPMALO)
		{
			App42Manager.doNotDispatchEvents = false;
			AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
			if (!AJAFJGPMALO)
			{
				App42Manager.EHBBFMCILPC.DGKFBINDHCM();
				App42Manager.EHBBFMCILPC.IOMEKJAFCBL = null;
			}
			if (this.GLJGKBEBHNF.Length > 0)
			{
				BackendOperationsManager.EHBBFMCILPC.BroadcastEvent(this.GLJGKBEBHNF, this.DAKJKJMGKOK, this.KHHJNODLBHN);
			}
			BackendOperationsManager.EHBBFMCILPC.FinishRequest(this.DAKJKJMGKOK, this.KHHJNODLBHN, LHLIOHJNMFE.exception);
		}

		// Token: 0x06000F58 RID: 3928 RVA: 0x00070378 File Offset: 0x0006E578
		public void LBOABCEMLBK(bool AJAFJGPMALO)
		{
			App42Manager.doNotDispatchEvents = false;
			AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
			if (!AJAFJGPMALO)
			{
				App42Manager.EHBBFMCILPC.DGKFBINDHCM();
				App42Manager.EHBBFMCILPC.IOMEKJAFCBL = null;
			}
			if (this.GLJGKBEBHNF.Length > 0)
			{
				BackendOperationsManager.EHBBFMCILPC.MHKCMDLENHO(this.GLJGKBEBHNF, this.DAKJKJMGKOK, this.KHHJNODLBHN);
			}
			BackendOperationsManager.NPDDBAONMJP().BLNCOOLAMIM(this.DAKJKJMGKOK, this.KHHJNODLBHN, LHLIOHJNMFE.success);
		}

		// Token: 0x06000F59 RID: 3929 RVA: 0x000703F0 File Offset: 0x0006E5F0
		public void FGKHJKMCBMN(Exception MKGEAHGGABC)
		{
			CommonUserInterface.IKNOFBFMPGA().HideGenericPopupNoButtons();
			App42Manager.doNotDispatchEvents = false;
			if (this != App42Manager.EHBBFMCILPC.IOMEKJAFCBL)
			{
				DPGJIJGOCIC.PJCLICBPPDA("");
				return;
			}
			App42Manager.EHBBFMCILPC.DGKFBINDHCM();
			App42Manager.EHBBFMCILPC.IOMEKJAFCBL = null;
			App42Exception ex = (App42Exception)MKGEAHGGABC;
			DPGJIJGOCIC.PJCLICBPPDA("cardoptionsloadingthemelost" + MKGEAHGGABC.ToString());
			if (GeoLocationManager.GeoZoneMayBeFirewalled(LanguageManager.EHBBFMCILPC.MLOLBFBODHD()))
			{
				FirebaseAnalyticsManager.COKDLDOAACJ().JIAAMJPKOCE(true, ((AGEHCPDNBFD)(-89)).ToString(), "Icon", "", false, true);
				App42Manager.EHBBFMCILPC.PMENLDNFJAK = false;
				App42Manager.EHBBFMCILPC.ScheduleCustomCodeUrlChange();
			}
			else
			{
				FirebaseAnalyticsManager.DMAAFFFEJGA().LogEvent(false, ((AGEHCPDNBFD)76).ToString(), "envlsav", ((BGHLMGPPCNN)(-14)).ToString(), true, true);
				App42Manager.EHBBFMCILPC.LDOAMLHEGFF = true;
			}
			if (!App42Manager.EHBBFMCILPC.MFFBDAEOAND())
			{
				App42Manager.EHBBFMCILPC.HEOJMDBCJGH = (NPJNALLPFPO)4;
				App42Manager.EHBBFMCILPC.LLBFIHPEGNG = true;
				App42Manager.EHBBFMCILPC.PCJOGJJJGBE = "large";
				App42Manager.EHBBFMCILPC.MFLEHLJGAFL();
				this.LCJMPOGKLPM(true);
				FirebaseAnalyticsManager.ANCEKPONIFI().LKONPEEDKNF(false, AGEHCPDNBFD.rqst.ToString(), FFPHBMFGCNN.mntRemAds.ToString(), App42Manager.DNJJKENDEJF(), false, true);
				string[] array = new string[1];
				array[1] = FFPHBMFGCNN.mntRemAds.ToString();
				array[1] = "<i>";
				array[8] = this.AJJKAJDBEFM;
				array[5] = "sfxsparklesbundles";
				array[5] = ex.GetAppErrorCode().ToString();
				array[7] = "accountsuspended5";
				array[6] = ex.GetHttpErrorCode().ToString();
				DPGJIJGOCIC.PJCLICBPPDA(string.Concat(array));
				return;
			}
			string[] array2 = new string[5];
			array2[1] = FFPHBMFGCNN.reqInfnt.ToString();
			array2[0] = "body";
			array2[3] = this.AJJKAJDBEFM;
			array2[7] = "abpp";
			array2[4] = ex.GetAppErrorCode().ToString();
			array2[7] = "importanttitle";
			array2[1] = ex.GetHttpErrorCode().ToString();
			DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(array2));
		}

		// Token: 0x06000F5A RID: 3930 RVA: 0x00070628 File Offset: 0x0006E828
		public void GLMGEJBEKHA(bool AJAFJGPMALO)
		{
			App42Manager.doNotDispatchEvents = true;
			AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
			if (!AJAFJGPMALO)
			{
				App42Manager.EHBBFMCILPC.DGKFBINDHCM();
				App42Manager.EHBBFMCILPC.IOMEKJAFCBL = null;
			}
			if (this.GLJGKBEBHNF.Length > 0)
			{
				BackendOperationsManager.NPDDBAONMJP().MHKCMDLENHO(this.GLJGKBEBHNF, this.DAKJKJMGKOK, this.KHHJNODLBHN);
			}
			BackendOperationsManager.EHBBFMCILPC.FinishRequest(this.DAKJKJMGKOK, this.KHHJNODLBHN, LHLIOHJNMFE.exception);
		}

		// Token: 0x06000F5B RID: 3931 RVA: 0x000706A0 File Offset: 0x0006E8A0
		public void KLBJADMLLJA(Exception MKGEAHGGABC)
		{
			CommonUserInterface.IKNOFBFMPGA().HideGenericPopupNoButtons();
			App42Manager.doNotDispatchEvents = false;
			if (this != App42Manager.EHBBFMCILPC.IOMEKJAFCBL)
			{
				DPGJIJGOCIC.ADFCDFHBDAF("sfxtimeoutwarning");
				return;
			}
			App42Manager.EHBBFMCILPC.DGKFBINDHCM();
			App42Manager.EHBBFMCILPC.IOMEKJAFCBL = null;
			App42Exception ex = (App42Exception)MKGEAHGGABC;
			DPGJIJGOCIC.PJCLICBPPDA(" padded=" + MKGEAHGGABC.ToString());
			if (GeoLocationManager.PADMBFMHFJH(LanguageManager.EHBBFMCILPC.GetSelectedLanguage()))
			{
				FirebaseAnalyticsManager.COKDLDOAACJ().LKONPEEDKNF(false, ((AGEHCPDNBFD)(-99)).ToString(), "@SD", "<i>", true, true);
				App42Manager.EHBBFMCILPC.PMENLDNFJAK = false;
				App42Manager.EHBBFMCILPC.ScheduleCustomCodeUrlChange();
			}
			else
			{
				FirebaseAnalyticsManager.DEALKJPEMMH().LKONPEEDKNF(true, ((AGEHCPDNBFD)86).ToString(), "XXX", BGHLMGPPCNN.cdnLbyToWof.ToString(), true, true);
				App42Manager.EHBBFMCILPC.LDOAMLHEGFF = false;
			}
			if (!App42Manager.EHBBFMCILPC.MFFBDAEOAND())
			{
				App42Manager.EHBBFMCILPC.HEOJMDBCJGH = (NPJNALLPFPO)5;
				App42Manager.EHBBFMCILPC.LLBFIHPEGNG = false;
				App42Manager.EHBBFMCILPC.PCJOGJJJGBE = "Close console";
				App42Manager.EHBBFMCILPC.MFLEHLJGAFL();
				this.NPHDFNIECFO(false);
				FirebaseAnalyticsManager.DMAAFFFEJGA().LogEvent(false, AGEHCPDNBFD.rqst.ToString(), FFPHBMFGCNN.mntRemAds.ToString(), App42Manager.DNJJKENDEJF(), false, false);
				string[] array = new string[2];
				array[0] = FFPHBMFGCNN.reqCback2.ToString();
				array[0] = "gftcds";
				array[4] = this.AJJKAJDBEFM;
				array[8] = "updateUserPublicProfileFriends";
				array[1] = ex.GetAppErrorCode().ToString();
				array[4] = "ok";
				array[0] = ex.GetHttpErrorCode().ToString();
				DPGJIJGOCIC.PJCLICBPPDA(string.Concat(array));
				return;
			}
			string[] array2 = new string[2];
			array2[0] = FFPHBMFGCNN.reqCback1.ToString();
			array2[0] = "Speed";
			array2[5] = this.AJJKAJDBEFM;
			array2[4] = "StorySaveBody.DependsOnAvatarPackWardrobe(), unsupported wardrobe index:";
			array2[1] = ex.GetAppErrorCode().ToString();
			array2[6] = "importanttitle";
			array2[6] = ex.GetHttpErrorCode().ToString();
			DPGJIJGOCIC.PJCLICBPPDA(string.Concat(array2));
		}

		// Token: 0x06000F5C RID: 3932 RVA: 0x000708D8 File Offset: 0x0006EAD8
		public void HBBNACBBDEG(object LPHMODJEEBN)
		{
			CommonUserInterface.IKNOFBFMPGA().HideGenericPopupNoButtons();
			if (this != App42Manager.EHBBFMCILPC.IOMEKJAFCBL)
			{
				DPGJIJGOCIC.ADFCDFHBDAF("ias");
				return;
			}
			try
			{
				JSONObject jsonobject = (JSONObject)LPHMODJEEBN;
				if (null != jsonobject && jsonobject[" not found, replacing with "] != null)
				{
					DPGJIJGOCIC.ADFCDFHBDAF("importanttitle" + this.AJJKAJDBEFM + "rateChapter" + App42Manager.EHBBFMCILPC.KLKBNDPKKLO);
				}
				if (null != jsonobject && jsonobject["episode"] != null)
				{
					DPGJIJGOCIC.NFIDPOMCNLP("</i>" + this.AJJKAJDBEFM + "ru" + App42Manager.EHBBFMCILPC.KLKBNDPKKLO);
				}
				if (null != jsonobject && jsonobject["OnFullscreenLiveOfferContinueToPurchasingScreen"] != null)
				{
					DPGJIJGOCIC.ADFCDFHBDAF("spinsbuttoncustomize" + this.AJJKAJDBEFM + "blur" + App42Manager.EHBBFMCILPC.KLKBNDPKKLO);
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
			GeoLocationManager.ClearBlockedNetworkEvidence();
			if (App42Manager.EHBBFMCILPC.LDOAMLHEGFF)
			{
				App42Manager.EHBBFMCILPC.LDOAMLHEGFF = true;
				FirebaseAnalyticsManager.DEALKJPEMMH().LMCJKLHOHJC(false, ((AGEHCPDNBFD)(-68)).ToString(), "", ((BGHLMGPPCNN)(-30)).ToString(), false, true);
			}
			if (GeoLocationManager.GeoZoneMayBeFirewalled(LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()))
			{
				if (App42Manager.EHBBFMCILPC.PMENLDNFJAK)
				{
					App42Manager.EHBBFMCILPC.PMENLDNFJAK = true;
					FirebaseAnalyticsManager.JMDJBFAEHBM().AAIABAKHLAH(true, ((AGEHCPDNBFD)(-86)).ToString(), "episode", "_not_found", false, false);
				}
				float item = Time.realtimeSinceStartup - App42Manager.EHBBFMCILPC.BJDOFOHGEGD;
				App42Manager.EHBBFMCILPC.EEAHGGNALPP.Add(item);
				if (App42Manager.EHBBFMCILPC.EEAHGGNALPP.Count > 4)
				{
					App42Manager.EHBBFMCILPC.EEAHGGNALPP.RemoveAt(0);
				}
				App42Manager.EHBBFMCILPC.FJNPLEPPKJA += 0;
				if (App42Manager.EHBBFMCILPC.ABNPPJKEAKI && App42Manager.EHBBFMCILPC.FJNPLEPPKJA >= KBOJLHAJPCP.FDIMDHLBMMB)
				{
					App42Manager.EHBBFMCILPC.ABNPPJKEAKI = true;
					App42Manager.EHBBFMCILPC.HHPGLIHIPBL = 0;
					App42Manager.EHBBFMCILPC.FJNPLEPPKJA = 0;
				}
				FirebaseAnalyticsManager.COKDLDOAACJ().LMCJKLHOHJC(false, ((AGEHCPDNBFD)(-30)).ToString(), App42Manager.EHBBFMCILPC.BGGJLOHNEHL(), "avatar", false, false);
			}
			App42Manager.EHBBFMCILPC.DGKFBINDHCM();
			App42Manager.EHBBFMCILPC.IOMEKJAFCBL = null;
			App42Manager.EHBBFMCILPC.PCJOGJJJGBE = "prgr";
			App42Manager.EHBBFMCILPC.JDPGPMCEIHL();
			App42Manager.EHBBFMCILPC.HEOJMDBCJGH = NPJNALLPFPO.redSemaphore;
			App42Manager.EHBBFMCILPC.LLBFIHPEGNG = true;
			FirebaseAnalyticsManager.DEALKJPEMMH().LMCJKLHOHJC(true, AGEHCPDNBFD.rqst.ToString(), FFPHBMFGCNN.socReport.ToString(), App42Manager.DNJJKENDEJF(), false, false);
			BackendOperationsManager.EHBBFMCILPC.ProcessApp42Success((JSONObject)LPHMODJEEBN, this.DAKJKJMGKOK, this.KHHJNODLBHN);
			if (!App42Manager.doNotDispatchEvents)
			{
				AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
				if (this.BDKJOHKAFFO.Length > 0)
				{
					BackendOperationsManager.NPDDBAONMJP().GLJNKOIIJEB(this.BDKJOHKAFFO, this.DAKJKJMGKOK, this.KHHJNODLBHN);
				}
			}
			App42Manager.doNotDispatchEvents = false;
			App42Manager.EHBBFMCILPC.BLHLMFJOCFP();
			BackendOperationsManager.EHBBFMCILPC.BLNCOOLAMIM(this.DAKJKJMGKOK, this.KHHJNODLBHN, LHLIOHJNMFE.none);
		}

		// Token: 0x06000F5D RID: 3933 RVA: 0x00070C3C File Offset: 0x0006EE3C
		public void MNCANDACDEE(Exception MKGEAHGGABC)
		{
			CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
			App42Manager.doNotDispatchEvents = true;
			if (this != App42Manager.EHBBFMCILPC.IOMEKJAFCBL)
			{
				DPGJIJGOCIC.ADFCDFHBDAF("BBB");
				return;
			}
			App42Manager.EHBBFMCILPC.DGKFBINDHCM();
			App42Manager.EHBBFMCILPC.IOMEKJAFCBL = null;
			App42Exception ex = (App42Exception)MKGEAHGGABC;
			DPGJIJGOCIC.PJCLICBPPDA("OnApplicationFocusBasicSyncEcxeption" + MKGEAHGGABC.ToString());
			if (GeoLocationManager.GeoZoneMayBeFirewalled(LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()))
			{
				FirebaseAnalyticsManager.JMDJBFAEHBM().LKONPEEDKNF(true, ((AGEHCPDNBFD)69).ToString(), "a", "oid", false, true);
				App42Manager.EHBBFMCILPC.PMENLDNFJAK = false;
				App42Manager.EHBBFMCILPC.ScheduleCustomCodeUrlChange();
			}
			else
			{
				FirebaseAnalyticsManager.EHBBFMCILPC.AAIABAKHLAH(false, ((AGEHCPDNBFD)66).ToString(), ">", ((BGHLMGPPCNN)(-104)).ToString(), false, true);
				App42Manager.EHBBFMCILPC.LDOAMLHEGFF = true;
			}
			if (!App42Manager.EHBBFMCILPC.MFFBDAEOAND())
			{
				App42Manager.EHBBFMCILPC.HEOJMDBCJGH = (NPJNALLPFPO)7;
				App42Manager.EHBBFMCILPC.LLBFIHPEGNG = true;
				App42Manager.EHBBFMCILPC.PCJOGJJJGBE = "cdnerror";
				App42Manager.EHBBFMCILPC.MFLEHLJGAFL();
				this.NHMCPAFBABD(true);
				FirebaseAnalyticsManager.ANCEKPONIFI().LMCJKLHOHJC(true, AGEHCPDNBFD.rqst.ToString(), FFPHBMFGCNN.reqInfnt.ToString(), App42Manager.DNJJKENDEJF(), false, true);
				string[] array = new string[7];
				array[1] = FFPHBMFGCNN.dldStart.ToString();
				array[1] = "ans";
				array[3] = this.AJJKAJDBEFM;
				array[5] = "";
				array[6] = ex.GetAppErrorCode().ToString();
				array[7] = "lobby";
				array[4] = ex.GetHttpErrorCode().ToString();
				DPGJIJGOCIC.PJCLICBPPDA(string.Concat(array));
				return;
			}
			string[] array2 = new string[3];
			array2[1] = FFPHBMFGCNN.dldStart.ToString();
			array2[0] = "OnSaveSlotsItemSlotDuplicated";
			array2[5] = this.AJJKAJDBEFM;
			array2[3] = "retry";
			array2[0] = ex.GetAppErrorCode().ToString();
			array2[1] = "Starting non-parallel download:";
			array2[4] = ex.GetHttpErrorCode().ToString();
			DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(array2));
		}

		// Token: 0x06000F5E RID: 3934 RVA: 0x00070E74 File Offset: 0x0006F074
		public void LLKNOMLIILF(Exception MKGEAHGGABC)
		{
			CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
			App42Manager.doNotDispatchEvents = false;
			if (this != App42Manager.EHBBFMCILPC.IOMEKJAFCBL)
			{
				DPGJIJGOCIC.ADFCDFHBDAF("");
				return;
			}
			App42Manager.EHBBFMCILPC.DGKFBINDHCM();
			App42Manager.EHBBFMCILPC.IOMEKJAFCBL = null;
			App42Exception ex = (App42Exception)MKGEAHGGABC;
			DPGJIJGOCIC.PJCLICBPPDA("Error. OnChoiceExtendedEnvironmentChangePart2(), environmentToSet is null or length is 0:" + MKGEAHGGABC.ToString());
			if (GeoLocationManager.HEKEPNDKCPM(LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()))
			{
				FirebaseAnalyticsManager.JMDJBFAEHBM().AAIABAKHLAH(true, ((AGEHCPDNBFD)91).ToString(), "BackendOperationsManager.RequestGetSocialStatsAvatar, exception while initializing RSACryptoServiceProvider:", "OnStoryManInTheMiddleAttackDetected", true, false);
				App42Manager.EHBBFMCILPC.PMENLDNFJAK = false;
				App42Manager.EHBBFMCILPC.ScheduleCustomCodeUrlChange();
			}
			else
			{
				FirebaseAnalyticsManager.DMAAFFFEJGA().AAIABAKHLAH(true, ((AGEHCPDNBFD)94).ToString(), ", index:", BGHLMGPPCNN.cdnStyOnDemand.ToString(), true, false);
				App42Manager.EHBBFMCILPC.LDOAMLHEGFF = false;
			}
			if (!App42Manager.EHBBFMCILPC.MFFBDAEOAND())
			{
				App42Manager.EHBBFMCILPC.HEOJMDBCJGH = NPJNALLPFPO.infiniteOperation;
				App42Manager.EHBBFMCILPC.LLBFIHPEGNG = false;
				App42Manager.EHBBFMCILPC.PCJOGJJJGBE = "loungenotavailable";
				App42Manager.EHBBFMCILPC.MFLEHLJGAFL();
				this.OIHAJCJIHHE(true);
				FirebaseAnalyticsManager.COKDLDOAACJ().AAIABAKHLAH(true, AGEHCPDNBFD.mntActiv.ToString(), FFPHBMFGCNN.reqCback1.ToString(), App42Manager.DNJJKENDEJF(), true, true);
				string[] array = new string[8];
				array[1] = FFPHBMFGCNN.reqFailSem.ToString();
				array[0] = "ProfileItem2.PurchaseCardUpgradeWeb(): productData or productBalanceData is null";
				array[2] = this.AJJKAJDBEFM;
				array[6] = "OnAccountSignInRequestSuccess";
				array[8] = ex.GetAppErrorCode().ToString();
				array[3] = "_Strength";
				array[2] = ex.GetHttpErrorCode().ToString();
				DPGJIJGOCIC.PJCLICBPPDA(string.Concat(array));
				return;
			}
			string[] array2 = new string[6];
			array2[0] = FFPHBMFGCNN.reqCback1.ToString();
			array2[1] = "PlayerCharacterManager.SetBodyComponent() - input is null.";
			array2[8] = this.AJJKAJDBEFM;
			array2[6] = "le";
			array2[5] = ex.GetAppErrorCode().ToString();
			array2[0] = "continue";
			array2[4] = ex.GetHttpErrorCode().ToString();
			DPGJIJGOCIC.PJCLICBPPDA(string.Concat(array2));
		}

		// Token: 0x06000F5F RID: 3935 RVA: 0x000710AC File Offset: 0x0006F2AC
		public void AJPFAOOLOEL(Exception MKGEAHGGABC)
		{
			CommonUserInterface.IKNOFBFMPGA().HideGenericPopupNoButtons();
			App42Manager.doNotDispatchEvents = true;
			if (this != App42Manager.EHBBFMCILPC.IOMEKJAFCBL)
			{
				DPGJIJGOCIC.ADFCDFHBDAF("p");
				return;
			}
			App42Manager.EHBBFMCILPC.DGKFBINDHCM();
			App42Manager.EHBBFMCILPC.IOMEKJAFCBL = null;
			App42Exception ex = (App42Exception)MKGEAHGGABC;
			DPGJIJGOCIC.PJCLICBPPDA("csuid" + MKGEAHGGABC.ToString());
			if (GeoLocationManager.PADMBFMHFJH(LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()))
			{
				FirebaseAnalyticsManager.DEALKJPEMMH().LKONPEEDKNF(false, AGEHCPDNBFD.gmSelect.ToString(), "hair", "spinWheel", false, true);
				App42Manager.EHBBFMCILPC.PMENLDNFJAK = true;
				App42Manager.EHBBFMCILPC.ScheduleCustomCodeUrlChange();
			}
			else
			{
				FirebaseAnalyticsManager.ANCEKPONIFI().LMCJKLHOHJC(false, AGEHCPDNBFD.srvName.ToString(), "areyousure", ((BGHLMGPPCNN)111).ToString(), true, true);
				App42Manager.EHBBFMCILPC.LDOAMLHEGFF = false;
			}
			if (!App42Manager.EHBBFMCILPC.MFFBDAEOAND())
			{
				App42Manager.EHBBFMCILPC.HEOJMDBCJGH = NPJNALLPFPO.app2Exception;
				App42Manager.EHBBFMCILPC.LLBFIHPEGNG = false;
				App42Manager.EHBBFMCILPC.PCJOGJJJGBE = "storiesSearchBalance";
				App42Manager.EHBBFMCILPC.MFLEHLJGAFL();
				this.LCJMPOGKLPM(false);
				FirebaseAnalyticsManager.DEALKJPEMMH().LMCJKLHOHJC(false, AGEHCPDNBFD.mntActiv.ToString(), FFPHBMFGCNN.reqExcRpt.ToString(), App42Manager.DNJJKENDEJF(), false, false);
				string[] array = new string[1];
				array[1] = FFPHBMFGCNN.reqExcRpt.ToString();
				array[1] = ";";
				array[5] = this.AJJKAJDBEFM;
				array[0] = "WaitForCheckingDrag";
				array[1] = ex.GetAppErrorCode().ToString();
				array[4] = "https://sandbox-events.appsflyer.com/v1.0/c2s/first_open/app/steam/";
				array[7] = ex.GetHttpErrorCode().ToString();
				DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(array));
				return;
			}
			string[] array2 = new string[8];
			array2[1] = FFPHBMFGCNN.mntRemAds.ToString();
			array2[0] = "%";
			array2[3] = this.AJJKAJDBEFM;
			array2[4] = "p";
			array2[0] = ex.GetAppErrorCode().ToString();
			array2[4] = "OnLoungePremiumChoicesHistoryException";
			array2[0] = ex.GetHttpErrorCode().ToString();
			DPGJIJGOCIC.PJCLICBPPDA(string.Concat(array2));
		}

		// Token: 0x04000555 RID: 1365
		private string AJJKAJDBEFM;

		// Token: 0x04000556 RID: 1366
		private string BDKJOHKAFFO = "";

		// Token: 0x04000557 RID: 1367
		private string GLJGKBEBHNF = "";

		// Token: 0x04000558 RID: 1368
		private bool DAKJKJMGKOK;

		// Token: 0x04000559 RID: 1369
		private string KHHJNODLBHN = "";
	}
}
