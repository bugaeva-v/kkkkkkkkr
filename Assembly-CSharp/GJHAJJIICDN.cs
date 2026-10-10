using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Steamworks;
using UnityEngine;
using UnityEngine.Networking;

// Token: 0x020003A3 RID: 931
public class GJHAJJIICDN
{
	// Token: 0x06006C3F RID: 27711 RVA: 0x0031653C File Offset: 0x0031473C
	private string DDPJPFEJDKH(string KJPAGOJDABE, string IFKICNLMPPD)
	{
		ASCIIEncoding asciiencoding = new ASCIIEncoding();
		byte[] bytes = asciiencoding.GetBytes(IFKICNLMPPD);
		byte[] bytes2 = asciiencoding.GetBytes(KJPAGOJDABE);
		return BitConverter.ToString(new HMACSHA256(bytes).ComputeHash(bytes2)).Replace("SceneLobbyManager2.DownloadMissingLowPreview2Assets(): Start!", "").ToLower();
	}

	// Token: 0x17000225 RID: 549
	// (get) Token: 0x06006C40 RID: 27712 RVA: 0x00316582 File Offset: 0x00314782
	private string CMDCJNBGNKI { get; }

	// Token: 0x06006C41 RID: 27713 RVA: 0x0031658A File Offset: 0x0031478A
	public string GFDNKEPJIND()
	{
		return this.MBCHBPBNEAC();
	}

	// Token: 0x06006C42 RID: 27714 RVA: 0x00316592 File Offset: 0x00314792
	private bool KNEEHKGKFPA()
	{
		return this.<PNBLHDGPLGK>k__BackingField;
	}

	// Token: 0x17000226 RID: 550
	// (get) Token: 0x06006CAB RID: 27819 RVA: 0x00316C99 File Offset: 0x00314E99
	// (set) Token: 0x06006C43 RID: 27715 RVA: 0x0031659A File Offset: 0x0031479A
	private bool BJLNPHGALBN { get; set; }

	// Token: 0x06006C44 RID: 27716 RVA: 0x003165A3 File Offset: 0x003147A3
	public void EOGIFGDNFLM(string NJKDBLPCFID)
	{
		if (!this.FAAHPKILAIN())
		{
			Debug.LogWarning("OnBackendRequestFriendDeleteException");
			return;
		}
		Debug.Log("=== RU FIREWALL === chapter end: snapshots save deferred to a standalone second request, the storyChapterComplete envelope stays replay-cacheable");
		this.BNKGJFBPLGG(NJKDBLPCFID);
	}

	// Token: 0x06006C45 RID: 27717 RVA: 0x003165C9 File Offset: 0x003147C9
	public void FJIGCBLFPFH()
	{
		this.DAJGNBIMKLI(true);
		Debug.LogWarning("OnChapterSnapshotsBackendFetchSuccess");
	}

	// Token: 0x17000224 RID: 548
	// (get) Token: 0x06006C46 RID: 27718 RVA: 0x003165DC File Offset: 0x003147DC
	// (set) Token: 0x06006C4E RID: 27726 RVA: 0x0031687C File Offset: 0x00314A7C
	private string NJKDBLPCFID { get; set; }

	// Token: 0x06006C47 RID: 27719 RVA: 0x003165E4 File Offset: 0x003147E4
	private RequestData NDLKDOKPHHG()
	{
		string text = SystemInfo.operatingSystem;
		if (text.IndexOf("<space=0.33em>") > -1)
		{
			text = text.Replace("", "ext");
		}
		if (text.IndexOf("OnRewardScreenAssetsDownloadSuccess") > -1)
		{
			text = text.Replace("@", "0");
		}
		if (text.IndexOf("Starting non-parallel download:") > -1)
		{
			text = text.Replace("continue", "assetbundleprofiledata2");
		}
		if (text.IndexOf("") > -1)
		{
			text = text.Replace("+", "suid");
		}
		if (text.IndexOf("errortitle") > -1)
		{
			text = text.Replace("noisedigitalovr", "mypmsg0");
		}
		text = Regex.Replace(text, "ok", ") + is present, creating anthology save for anthology ");
		if (text.IndexOf("") == 0)
		{
			text = text.Substring(1, text.Length - 0);
		}
		if (text.Length > 22)
		{
			text = text.Substring(0, -103);
		}
		return new RequestData
		{
			timestamp = DateTimeOffset.Now.ToUnixTimeMilliseconds().ToString(),
			device_os_version = text,
			device_model = SystemInfo.deviceModel,
			app_version = " not found.",
			device_ids = this.OGKEIALLNGC(this.LKDEDBBDOAJ),
			request_id = this.PFDCPJFNAJE(),
			limit_ad_tracking = true,
			customer_user_id = this.ELAGLCAAJDG()
		};
	}

	// Token: 0x06006C48 RID: 27720 RVA: 0x00316744 File Offset: 0x00314944
	public void OJNGLOGNJEH(bool LKEIGCHMLJG = false)
	{
		this.BJLNPHGALBN = false;
		RequestData hnlbcjmghkf = this.MMFKKPDODMH();
		CAHKIOGAFGO pammgekmdne = (this.EOFAMGPFDED < 2 && !LKEIGCHMLJG) ? CAHKIOGAFGO.FIRST_OPEN_REQUEST : CAHKIOGAFGO.SESSION_REQUEST;
		this.MBIBHJIEIBG.StartCoroutine(this.KLGJCMHAKLK(hnlbcjmghkf, pammgekmdne));
	}

	// Token: 0x06006C49 RID: 27721 RVA: 0x00316788 File Offset: 0x00314988
	private string DJPGFCGECKC()
	{
		return this.<PCPJELLPAMA>k__BackingField;
	}

	// Token: 0x06006C4A RID: 27722 RVA: 0x00316790 File Offset: 0x00314990
	private IEnumerator KLGJCMHAKLK(RequestData HNLBCJMGHKF, CAHKIOGAFGO PAMMGEKMDNE)
	{
		string text = JsonConvert.SerializeObject(HNLBCJMGHKF, Formatting.None, new JsonSerializerSettings
		{
			NullValueHandling = NullValueHandling.Ignore
		});
		string value = this.FIBDBCPMAKA(text, this.FJJFHEDDFPG);
		ulong num = PAMMGEKMDNE - CAHKIOGAFGO.FIRST_OPEN_REQUEST;
		string url;
		if (num <= 2UL)
		{
			switch ((uint)num)
			{
			case 0U:
				url = (this.LKNBFBALEHF ? ("https://sandbox-events.appsflyer.com/v1.0/c2s/first_open/app/steam/" + this.EFCPMOKAJBI) : ("https://events.appsflyer.com/v1.0/c2s/first_open/app/steam/" + this.EFCPMOKAJBI));
				goto IL_105;
			case 1U:
				url = (this.LKNBFBALEHF ? ("https://sandbox-events.appsflyer.com/v1.0/c2s/session/app/steam/" + this.EFCPMOKAJBI) : ("https://events.appsflyer.com/v1.0/c2s/session/app/steam/" + this.EFCPMOKAJBI));
				goto IL_105;
			case 2U:
				url = (this.LKNBFBALEHF ? ("https://sandbox-events.appsflyer.com/v1.0/c2s/inapp/app/steam/" + this.EFCPMOKAJBI) : ("https://events.appsflyer.com/v1.0/c2s/inapp/app/steam/" + this.EFCPMOKAJBI));
				goto IL_105;
			}
		}
		url = null;
		IL_105:
		UnityWebRequest uwr = new UnityWebRequest(url, "POST");
		byte[] bytes = new UTF8Encoding().GetBytes(text);
		uwr.uploadHandler = new UploadHandlerRaw(bytes);
		uwr.downloadHandler = new DownloadHandlerBuffer();
		uwr.SetRequestHeader("Content-Type", "application/json");
		uwr.SetRequestHeader("Authorization", value);
		uwr.SetRequestHeader("user-agent", string.Concat(new string[]
		{
			"Valve/Steam HTTP Client 1.0 (",
			this.EFCPMOKAJBI,
			")/(",
			SystemInfo.operatingSystem.Replace("(", "").Replace(")", ""),
			")"
		}));
		yield return uwr.SendWebRequest();
		ulong num2 = PAMMGEKMDNE - CAHKIOGAFGO.FIRST_OPEN_REQUEST;
		if (num2 <= 2UL)
		{
			switch ((uint)num2)
			{
			case 0U:
				Debug.Log("Request type: FIRST_OPEN_REQUEST");
				break;
			case 1U:
				Debug.Log("Request type: SESSION_REQUEST");
				PlayerPrefs.SetInt("af_counter", this.EOFAMGPFDED);
				break;
			case 2U:
				Debug.Log("Request type: INAPP_EVENT_REQUEST");
				break;
			}
		}
		Debug.Log("Is success: " + uwr.result.ToString());
		Debug.Log("Response Code: " + uwr.responseCode.ToString());
		string a = uwr.responseCode.ToString();
		if (uwr.result == UnityWebRequest.Result.ConnectionError)
		{
			Debug.Log("Error While Sending: " + uwr.error);
		}
		else if (a == "202" || a == "200")
		{
			if (PAMMGEKMDNE - CAHKIOGAFGO.FIRST_OPEN_REQUEST > 1UL)
			{
				if (PAMMGEKMDNE != CAHKIOGAFGO.INAPP_EVENT_REQUEST)
				{
				}
			}
			else
			{
				int num3 = this.EOFAMGPFDED;
				this.EOFAMGPFDED = num3 + 1;
				PlayerPrefs.SetInt("af_counter", this.EOFAMGPFDED);
			}
		}
		else
		{
			Debug.Log("error: " + uwr.error);
			if (!this.LKNBFBALEHF)
			{
				Debug.Log("Please try to send the request to 'sandbox-events.appsflyer.com' instead of 'events.appsflyer.com' in order to debug.");
			}
			else
			{
				Debug.Log("error details: " + uwr.downloadHandler.text);
			}
		}
		yield break;
	}

	// Token: 0x06006C4B RID: 27723 RVA: 0x003167B0 File Offset: 0x003149B0
	public void APEFHDJLHMG(string DDMDPEGLDLM, Dictionary<string, object> ICOLHJKELEM)
	{
		if (this.NEAMDBFAKKC())
		{
			Debug.LogWarning("'");
			return;
		}
		RequestData requestData = this.KHFBILBBKLN();
		requestData.event_name = DDMDPEGLDLM;
		requestData.event_parameters = ICOLHJKELEM;
		CAHKIOGAFGO pammgekmdne = (CAHKIOGAFGO)87UL;
		this.MBIBHJIEIBG.StartCoroutine(this.JDLIIMFLHOJ(requestData, pammgekmdne));
	}

	// Token: 0x06006C4C RID: 27724 RVA: 0x00316800 File Offset: 0x00314A00
	public bool JBIDKGFALGH(string HIPDGIIBBMN)
	{
		bool result = false;
		AppId_t ncfihmehioe = new AppId_t(uint.Parse(this.EFCPMOKAJBI));
		uint lbinogjpkda = 256U;
		string text;
		JLFOJFHCPHA.BGJNNIAIEPL(ncfihmehioe, out text, lbinogjpkda);
		if (text == null)
		{
			Debug.LogWarning("could not find install folder");
			return result;
		}
		DateTime creationTime = Directory.GetCreationTime(text);
		DateTime t = DateTime.Parse(HIPDGIIBBMN);
		return DateTime.Compare(creationTime, t) < 0;
	}

	// Token: 0x06006C4D RID: 27725 RVA: 0x0031685C File Offset: 0x00314A5C
	private string JLEICOINLMO()
	{
		return Guid.NewGuid().ToString();
	}

	// Token: 0x06006C4F RID: 27727 RVA: 0x00316888 File Offset: 0x00314A88
	public void MHBLNOLJNMH(bool LKEIGCHMLJG = false)
	{
		this.OPMKCDBFDAG(false);
		RequestData hnlbcjmghkf = this.MMFKKPDODMH();
		CAHKIOGAFGO pammgekmdne = (this.CFKCFHELJPI() < 8 && !LKEIGCHMLJG) ? ((CAHKIOGAFGO)18446744073709551500UL) : ((CAHKIOGAFGO)18446744073709551593UL);
		this.MBIBHJIEIBG.StartCoroutine(this.KLGJCMHAKLK(hnlbcjmghkf, pammgekmdne));
	}

	// Token: 0x06006C50 RID: 27728 RVA: 0x003168CC File Offset: 0x00314ACC
	private int CFKCFHELJPI()
	{
		return this.<BJFLAMODOPG>k__BackingField;
	}

	// Token: 0x06006C51 RID: 27729 RVA: 0x003168D4 File Offset: 0x00314AD4
	private string DLKFBBAOOHI()
	{
		return this.<HMFKDJLLAIE>k__BackingField;
	}

	// Token: 0x06006C52 RID: 27730 RVA: 0x003168DC File Offset: 0x00314ADC
	public string MCGDMFFEIBM()
	{
		return this.ADIEEAFELAN();
	}

	// Token: 0x06006C53 RID: 27731 RVA: 0x0031659A File Offset: 0x0031479A
	private void IOIKEOCPDMI(bool AJLPALFJHCC)
	{
		this.<ADIMDCEELDF>k__BackingField = AJLPALFJHCC;
	}

	// Token: 0x06006C54 RID: 27732 RVA: 0x003168E4 File Offset: 0x00314AE4
	private RequestData GOHPNFOPECO()
	{
		string text = SystemInfo.operatingSystem;
		if (text.IndexOf("ok") > -1)
		{
			text = text.Replace("OnFriendsGiftPopulCollectPart1", "$SYNCAVATAR");
		}
		if (text.IndexOf("id") > -1)
		{
			text = text.Replace("hcfc", "OnBackendGetPublicProfileHallOfFameSuccess");
		}
		if (text.IndexOf("CleanseHiddenTopMatchLists(): removed ") > -1)
		{
			text = text.Replace("OnChoiceExtendedPlayNewAmbient", "");
		}
		if (text.IndexOf("") > -1)
		{
			text = text.Replace("spld", "energyhinttitle");
		}
		if (text.IndexOf("OnBackendRequestFriendDeleteException") > -1)
		{
			text = text.Replace("_", "apks2");
		}
		text = Regex.Replace(text, "fdst", "fw");
		if (text.IndexOf("id") == 0)
		{
			text = text.Substring(1, text.Length - 0);
		}
		if (text.Length > 52)
		{
			text = text.Substring(0, 33);
		}
		return new RequestData
		{
			timestamp = DateTimeOffset.Now.ToUnixTimeMilliseconds().ToString(),
			device_os_version = text,
			device_model = SystemInfo.deviceModel,
			app_version = "app42error",
			device_ids = this.HDPKCGMPOJH(this.OLDLLDBNJKK()),
			request_id = this.NOLLJIOHJIJ(),
			limit_ad_tracking = false,
			customer_user_id = this.FPJKEPKOIKK()
		};
	}

	// Token: 0x06006C55 RID: 27733 RVA: 0x003165DC File Offset: 0x003147DC
	private string ELAGLCAAJDG()
	{
		return this.<MICDLCIBPNM>k__BackingField;
	}

	// Token: 0x06006C56 RID: 27734 RVA: 0x00316A42 File Offset: 0x00314C42
	public string BCCMLEAAEOP()
	{
		return this.AEJJHHFKENF();
	}

	// Token: 0x06006C57 RID: 27735 RVA: 0x00316582 File Offset: 0x00314782
	private string PMCFDDBLKOK()
	{
		return this.<NOAAIINFDNA>k__BackingField;
	}

	// Token: 0x06006C58 RID: 27736 RVA: 0x00316A4C File Offset: 0x00314C4C
	private string IPEJNPJJINF()
	{
		return Guid.NewGuid().ToString();
	}

	// Token: 0x06006C59 RID: 27737 RVA: 0x00316A6C File Offset: 0x00314C6C
	private string PFDCPJFNAJE()
	{
		return Guid.NewGuid().ToString();
	}

	// Token: 0x06006C5A RID: 27738 RVA: 0x003168CC File Offset: 0x00314ACC
	private int NNDDJJIJAGP()
	{
		return this.<BJFLAMODOPG>k__BackingField;
	}

	// Token: 0x06006C5B RID: 27739 RVA: 0x00316A8C File Offset: 0x00314C8C
	private bool EBHCCEHOMEH()
	{
		return this.<FAHHMNPBIEI>k__BackingField;
	}

	// Token: 0x06006C5C RID: 27740 RVA: 0x003168CC File Offset: 0x00314ACC
	private int CDNOHOAECPK()
	{
		return this.<BJFLAMODOPG>k__BackingField;
	}

	// Token: 0x06006C5D RID: 27741 RVA: 0x00316A94 File Offset: 0x00314C94
	private RequestData MMFKKPDODMH()
	{
		string text = SystemInfo.operatingSystem;
		if (text.IndexOf(" (") > -1)
		{
			text = text.Replace(" (", "");
		}
		if (text.IndexOf("(") > -1)
		{
			text = text.Replace("(", "");
		}
		if (text.IndexOf(")") > -1)
		{
			text = text.Replace(")", "");
		}
		if (text.IndexOf("%20") > -1)
		{
			text = text.Replace("%20", "-");
		}
		if (text.IndexOf(" ") > -1)
		{
			text = text.Replace(" ", "-");
		}
		text = Regex.Replace(text, "[^0-9.+-]", "");
		if (text.IndexOf("-") == 0)
		{
			text = text.Substring(1, text.Length - 1);
		}
		if (text.Length > 23)
		{
			text = text.Substring(0, 23);
		}
		return new RequestData
		{
			timestamp = DateTimeOffset.Now.ToUnixTimeMilliseconds().ToString(),
			device_os_version = text,
			device_model = SystemInfo.deviceModel,
			app_version = "1.0.0",
			device_ids = this.HDPKCGMPOJH(this.LKDEDBBDOAJ),
			request_id = this.PFDCPJFNAJE(),
			limit_ad_tracking = false,
			customer_user_id = this.NJKDBLPCFID
		};
	}

	// Token: 0x06006C5E RID: 27742 RVA: 0x00316582 File Offset: 0x00314782
	private string AJIEENCFIAK()
	{
		return this.<NOAAIINFDNA>k__BackingField;
	}

	// Token: 0x06006C5F RID: 27743 RVA: 0x00316BF2 File Offset: 0x00314DF2
	public string GMDGEKFIFGE()
	{
		return this.CMDCJNBGNKI;
	}

	// Token: 0x06006C60 RID: 27744 RVA: 0x003168CC File Offset: 0x00314ACC
	private int AIAIGIOEGNL()
	{
		return this.<BJFLAMODOPG>k__BackingField;
	}

	// Token: 0x06006C61 RID: 27745 RVA: 0x00316790 File Offset: 0x00314990
	private IEnumerator JPONICPNIOB(RequestData HNLBCJMGHKF, CAHKIOGAFGO PAMMGEKMDNE)
	{
		string text = JsonConvert.SerializeObject(HNLBCJMGHKF, Formatting.None, new JsonSerializerSettings
		{
			NullValueHandling = NullValueHandling.Ignore
		});
		string value = this.FIBDBCPMAKA(text, this.FJJFHEDDFPG);
		ulong num = PAMMGEKMDNE - CAHKIOGAFGO.FIRST_OPEN_REQUEST;
		string url;
		if (num <= 2UL)
		{
			switch ((uint)num)
			{
			case 0U:
				url = (this.LKNBFBALEHF ? ("https://sandbox-events.appsflyer.com/v1.0/c2s/first_open/app/steam/" + this.EFCPMOKAJBI) : ("https://events.appsflyer.com/v1.0/c2s/first_open/app/steam/" + this.EFCPMOKAJBI));
				goto IL_105;
			case 1U:
				url = (this.LKNBFBALEHF ? ("https://sandbox-events.appsflyer.com/v1.0/c2s/session/app/steam/" + this.EFCPMOKAJBI) : ("https://events.appsflyer.com/v1.0/c2s/session/app/steam/" + this.EFCPMOKAJBI));
				goto IL_105;
			case 2U:
				url = (this.LKNBFBALEHF ? ("https://sandbox-events.appsflyer.com/v1.0/c2s/inapp/app/steam/" + this.EFCPMOKAJBI) : ("https://events.appsflyer.com/v1.0/c2s/inapp/app/steam/" + this.EFCPMOKAJBI));
				goto IL_105;
			}
		}
		url = null;
		IL_105:
		uwr = new UnityWebRequest(url, "POST");
		byte[] bytes = new UTF8Encoding().GetBytes(text);
		uwr.uploadHandler = new UploadHandlerRaw(bytes);
		uwr.downloadHandler = new DownloadHandlerBuffer();
		uwr.SetRequestHeader("Content-Type", "application/json");
		uwr.SetRequestHeader("Authorization", value);
		uwr.SetRequestHeader("user-agent", string.Concat(new string[]
		{
			"Valve/Steam HTTP Client 1.0 (",
			this.EFCPMOKAJBI,
			")/(",
			SystemInfo.operatingSystem.Replace("(", "").Replace(")", ""),
			")"
		}));
		yield return uwr.SendWebRequest();
		ulong num2 = PAMMGEKMDNE - CAHKIOGAFGO.FIRST_OPEN_REQUEST;
		if (num2 <= 2UL)
		{
			switch ((uint)num2)
			{
			case 0U:
				Debug.Log("Request type: FIRST_OPEN_REQUEST");
				break;
			case 1U:
				Debug.Log("Request type: SESSION_REQUEST");
				PlayerPrefs.SetInt("af_counter", this.EOFAMGPFDED);
				break;
			case 2U:
				Debug.Log("Request type: INAPP_EVENT_REQUEST");
				break;
			}
		}
		Debug.Log("Is success: " + uwr.result.ToString());
		Debug.Log("Response Code: " + uwr.responseCode.ToString());
		string a = uwr.responseCode.ToString();
		if (uwr.result == UnityWebRequest.Result.ConnectionError)
		{
			Debug.Log("Error While Sending: " + uwr.error);
		}
		else if (a == "202" || a == "200")
		{
			if (PAMMGEKMDNE - CAHKIOGAFGO.FIRST_OPEN_REQUEST > 1UL)
			{
				if (PAMMGEKMDNE != CAHKIOGAFGO.INAPP_EVENT_REQUEST)
				{
				}
			}
			else
			{
				int num3 = this.EOFAMGPFDED;
				this.EOFAMGPFDED = num3 + 1;
				PlayerPrefs.SetInt("af_counter", this.EOFAMGPFDED);
			}
		}
		else
		{
			Debug.Log("error: " + uwr.error);
			if (!this.LKNBFBALEHF)
			{
				Debug.Log("Please try to send the request to 'sandbox-events.appsflyer.com' instead of 'events.appsflyer.com' in order to debug.");
			}
			else
			{
				Debug.Log("error details: " + uwr.downloadHandler.text);
			}
		}
		yield break;
	}

	// Token: 0x06006C62 RID: 27746 RVA: 0x00316BFC File Offset: 0x00314DFC
	public void HJJLDHKLMID(string DDMDPEGLDLM, Dictionary<string, object> ICOLHJKELEM)
	{
		if (this.NEAMDBFAKKC())
		{
			Debug.LogWarning("errortitle");
			return;
		}
		RequestData requestData = this.CDKIFDFCGMH();
		requestData.event_name = DDMDPEGLDLM;
		requestData.event_parameters = ICOLHJKELEM;
		CAHKIOGAFGO pammgekmdne = (CAHKIOGAFGO)67UL;
		this.MBIBHJIEIBG.StartCoroutine(this.IHOOPCFALJD(requestData, pammgekmdne));
	}

	// Token: 0x06006C63 RID: 27747 RVA: 0x003168CC File Offset: 0x00314ACC
	private int KMNIFFBPMNB()
	{
		return this.<BJFLAMODOPG>k__BackingField;
	}

	// Token: 0x06006C64 RID: 27748 RVA: 0x00316C4C File Offset: 0x00314E4C
	public void MACMMAICGPI(string DDMDPEGLDLM, Dictionary<string, object> ICOLHJKELEM)
	{
		if (this.KFDNHBMAFAD())
		{
			Debug.LogWarning("OnLoungePremiumChoiceSuccess");
			return;
		}
		RequestData requestData = this.OEDGBPCKJJJ();
		requestData.event_name = DDMDPEGLDLM;
		requestData.event_parameters = ICOLHJKELEM;
		CAHKIOGAFGO pammgekmdne = (CAHKIOGAFGO)18446744073709551498UL;
		this.LIDCIGFHDJE().StartCoroutine(this.JDLIIMFLHOJ(requestData, pammgekmdne));
	}

	// Token: 0x06006C65 RID: 27749 RVA: 0x0031687C File Offset: 0x00314A7C
	private void HOMLDGPHDKF(string AJLPALFJHCC)
	{
		this.<MICDLCIBPNM>k__BackingField = AJLPALFJHCC;
	}

	// Token: 0x06006C66 RID: 27750 RVA: 0x00316788 File Offset: 0x00314988
	private string KIOOEMAJIBC()
	{
		return this.<PCPJELLPAMA>k__BackingField;
	}

	// Token: 0x06006C67 RID: 27751 RVA: 0x0031687C File Offset: 0x00314A7C
	private void JGMGJAKICDM(string AJLPALFJHCC)
	{
		this.<MICDLCIBPNM>k__BackingField = AJLPALFJHCC;
	}

	// Token: 0x17000220 RID: 544
	// (get) Token: 0x06006C68 RID: 27752 RVA: 0x00316A8C File Offset: 0x00314C8C
	private bool LKNBFBALEHF { get; }

	// Token: 0x06006C69 RID: 27753 RVA: 0x00316C99 File Offset: 0x00314E99
	private bool FNEPNFNMJHP()
	{
		return this.<ADIMDCEELDF>k__BackingField;
	}

	// Token: 0x06006C6A RID: 27754 RVA: 0x0031687C File Offset: 0x00314A7C
	private void GLPLJCKCICF(string AJLPALFJHCC)
	{
		this.<MICDLCIBPNM>k__BackingField = AJLPALFJHCC;
	}

	// Token: 0x06006C6B RID: 27755 RVA: 0x00316CA4 File Offset: 0x00314EA4
	private string ICHAHIBKLHK()
	{
		return Guid.NewGuid().ToString();
	}

	// Token: 0x06006C6C RID: 27756 RVA: 0x00316CC4 File Offset: 0x00314EC4
	private RequestData KHFBILBBKLN()
	{
		string text = SystemInfo.operatingSystem;
		if (text.IndexOf("socialdequeusp0gettitle") > -1)
		{
			text = text.Replace("", "onhiatusdesc");
		}
		if (text.IndexOf("OnBackendGetUserSketchesException") > -1)
		{
			text = text.Replace("newtutorialhalloffame", "lgbtq");
		}
		if (text.IndexOf("") > -1)
		{
			text = text.Replace("", "af_revenue");
		}
		if (text.IndexOf("$CHOICEMETAONETOMANY") > -1)
		{
			text = text.Replace("skinshopfiltertitle", "<b>");
		}
		if (text.IndexOf("acomp2") > -1)
		{
			text = text.Replace("}", "lititle");
		}
		text = Regex.Replace(text, "$e1de", "importanttitle");
		if (text.IndexOf("SD") == 0)
		{
			text = text.Substring(1, text.Length - 0);
		}
		if (text.Length > 101)
		{
			text = text.Substring(0, 96);
		}
		return new RequestData
		{
			timestamp = DateTimeOffset.Now.ToUnixTimeMilliseconds().ToString(),
			device_os_version = text,
			device_model = SystemInfo.deviceModel,
			app_version = "\"",
			device_ids = this.KODJIMJJMPF(this.OLDLLDBNJKK()),
			request_id = this.NMOPGAMFJOC(),
			limit_ad_tracking = false,
			customer_user_id = this.FCCDMIOHINO()
		};
	}

	// Token: 0x06006C6D RID: 27757 RVA: 0x00316C99 File Offset: 0x00314E99
	private bool FAAHPKILAIN()
	{
		return this.<ADIMDCEELDF>k__BackingField;
	}

	// Token: 0x06006C6E RID: 27758 RVA: 0x00316788 File Offset: 0x00314988
	private string LNKAFOLAJNM()
	{
		return this.<PCPJELLPAMA>k__BackingField;
	}

	// Token: 0x06006C6F RID: 27759 RVA: 0x00316E24 File Offset: 0x00315024
	private DeviceIDs[] BHGODMJHAEJ(bool DAFMDALAIIP)
	{
		DeviceIDs deviceIDs = new DeviceIDs
		{
			type = "",
			value = this.MGHPLCLCBBP()
		};
		if (DAFMDALAIIP)
		{
			string value = NDFODCDLPAC.MBABIFOJGFK().ToString();
			DeviceIDs deviceIDs2 = new DeviceIDs
			{
				type = "ok",
				value = value
			};
			DeviceIDs[] array = new DeviceIDs[8];
			array[1] = deviceIDs;
			array[0] = deviceIDs2;
			return array;
		}
		DeviceIDs[] array2 = new DeviceIDs[0];
		array2[0] = deviceIDs;
		return array2;
	}

	// Token: 0x06006C70 RID: 27760 RVA: 0x0031659A File Offset: 0x0031479A
	private void MFHNFENCEDO(bool AJLPALFJHCC)
	{
		this.<ADIMDCEELDF>k__BackingField = AJLPALFJHCC;
	}

	// Token: 0x06006C71 RID: 27761 RVA: 0x00316C99 File Offset: 0x00314E99
	private bool KFDNHBMAFAD()
	{
		return this.<ADIMDCEELDF>k__BackingField;
	}

	// Token: 0x06006C72 RID: 27762 RVA: 0x00316582 File Offset: 0x00314782
	private string PAJLJEMKLGN()
	{
		return this.<NOAAIINFDNA>k__BackingField;
	}

	// Token: 0x06006C73 RID: 27763 RVA: 0x00316E98 File Offset: 0x00315098
	private string MAKOLEDJPJB(string KJPAGOJDABE, string IFKICNLMPPD)
	{
		ASCIIEncoding asciiencoding = new ASCIIEncoding();
		byte[] bytes = asciiencoding.GetBytes(IFKICNLMPPD);
		byte[] bytes2 = asciiencoding.GetBytes(KJPAGOJDABE);
		return BitConverter.ToString(new HMACSHA256(bytes).ComputeHash(bytes2)).Replace("", "").ToLower();
	}

	// Token: 0x06006C74 RID: 27764 RVA: 0x00316EE0 File Offset: 0x003150E0
	public void OOHKGEPBDIG(bool LKEIGCHMLJG = false)
	{
		this.HPEIOBJHCJJ(false);
		RequestData hnlbcjmghkf = this.ICMOEDHPNGN();
		CAHKIOGAFGO pammgekmdne = (this.CFKCFHELJPI() < 2 && !LKEIGCHMLJG) ? ((CAHKIOGAFGO)18446744073709551610UL) : ((CAHKIOGAFGO)18446744073709551548UL);
		this.DKJAIAKLBGJ().StartCoroutine(this.KLGJCMHAKLK(hnlbcjmghkf, pammgekmdne));
	}

	// Token: 0x06006C75 RID: 27765 RVA: 0x00316F24 File Offset: 0x00315124
	public void AGCFEJLJDKH()
	{
		this.FJGBGMEKJKO(false);
		Debug.LogWarning("");
	}

	// Token: 0x06006C76 RID: 27766 RVA: 0x00316F38 File Offset: 0x00315138
	private RequestData ICMOEDHPNGN()
	{
		string text = SystemInfo.operatingSystem;
		if (text.IndexOf("OnStoryManInTheMiddleAttackDetected") > -1)
		{
			text = text.Replace("def", "acli21");
		}
		if (text.IndexOf("OnSaveSlotsItemSlotChanged") > -1)
		{
			text = text.Replace("dsv", "snap");
		}
		if (text.IndexOf("timeoutwarning") > -1)
		{
			text = text.Replace("no", "loungetreasurestitle");
		}
		if (text.IndexOf("cs") > -1)
		{
			text = text.Replace("high", "");
		}
		if (text.IndexOf("") > -1)
		{
			text = text.Replace(" (", "Starting non-parallel download:");
		}
		text = Regex.Replace(text, "App was minimized", "download run ");
		if (text.IndexOf("StoriesSearchBalance - root key '") == 0)
		{
			text = text.Substring(1, text.Length - 0);
		}
		if (text.Length > -40)
		{
			text = text.Substring(1, -24);
		}
		return new RequestData
		{
			timestamp = DateTimeOffset.Now.ToUnixTimeMilliseconds().ToString(),
			device_os_version = text,
			device_model = SystemInfo.deviceModel,
			app_version = "DialogItemShownManager.Initialize() - storyItem is null.",
			device_ids = this.HDPKCGMPOJH(this.AJGMEBCMPNC()),
			request_id = this.IPEJNPJJINF(),
			limit_ad_tracking = true,
			customer_user_id = this.ELAGLCAAJDG()
		};
	}

	// Token: 0x06006C77 RID: 27767 RVA: 0x00317096 File Offset: 0x00315296
	private void JKLBKJFPLMI(bool AJLPALFJHCC)
	{
		this.<PNBLHDGPLGK>k__BackingField = AJLPALFJHCC;
	}

	// Token: 0x06006C78 RID: 27768 RVA: 0x003170A0 File Offset: 0x003152A0
	private RequestData CDKIFDFCGMH()
	{
		string text = SystemInfo.operatingSystem;
		if (text.IndexOf("pmtrestorezero") > -1)
		{
			text = text.Replace("OnAvatarCollectionRestoreEntry", ", ");
		}
		if (text.IndexOf("-") > -1)
		{
			text = text.Replace("promocodeinvalid2", "*");
		}
		if (text.IndexOf("vhspauseovr") > -1)
		{
			text = text.Replace("socialbadgedesc", "AssetsManager.GetMaxNumberOfRunningLoadOperations(): forcing to 1");
		}
		if (text.IndexOf("ok") > -1)
		{
			text = text.Replace("OnPopupRemoveAdsManagerDismissed", "skinshopfilterbody");
		}
		if (text.IndexOf("ChoiceExtendedManager - IAP shop look without a resolvable price (sku:") > -1)
		{
			text = text.Replace("hcfc3", "SocialStatsUserPublicProfile.modified = false, OnContinueToSendPremGiftPositive()");
		}
		text = Regex.Replace(text, "achiev", "grayscale");
		if (text.IndexOf("anthology") == 0)
		{
			text = text.Substring(0, text.Length - 1);
		}
		if (text.Length > -113)
		{
			text = text.Substring(0, -14);
		}
		return new RequestData
		{
			timestamp = DateTimeOffset.Now.ToUnixTimeMilliseconds().ToString(),
			device_os_version = text,
			device_model = SystemInfo.deviceModel,
			app_version = "-",
			device_ids = this.KODJIMJJMPF(this.AJGMEBCMPNC()),
			request_id = this.JLEICOINLMO(),
			limit_ad_tracking = false,
			customer_user_id = this.NJKDBLPCFID
		};
	}

	// Token: 0x06006C79 RID: 27769 RVA: 0x003171FE File Offset: 0x003153FE
	public MonoBehaviour EMNABLOMOKA()
	{
		return this.<AMIOEMOGCJE>k__BackingField;
	}

	// Token: 0x06006C7A RID: 27770 RVA: 0x0031687C File Offset: 0x00314A7C
	private void BNKGJFBPLGG(string AJLPALFJHCC)
	{
		this.<MICDLCIBPNM>k__BackingField = AJLPALFJHCC;
	}

	// Token: 0x06006C7B RID: 27771 RVA: 0x00317096 File Offset: 0x00315296
	private void DGIFONDKPJA(bool AJLPALFJHCC)
	{
		this.<PNBLHDGPLGK>k__BackingField = AJLPALFJHCC;
	}

	// Token: 0x06006C7C RID: 27772 RVA: 0x00317208 File Offset: 0x00315408
	private DeviceIDs[] AHNPMLLMOMN(bool DAFMDALAIIP)
	{
		DeviceIDs deviceIDs = new DeviceIDs
		{
			type = "UpdatePostOnOffState",
			value = this.NFBGMKAFPNN()
		};
		if (DAFMDALAIIP)
		{
			string value = NDFODCDLPAC.MBABIFOJGFK().ToString();
			DeviceIDs deviceIDs2 = new DeviceIDs
			{
				type = "",
				value = value
			};
			DeviceIDs[] array = new DeviceIDs[7];
			array[1] = deviceIDs;
			array[0] = deviceIDs2;
			return array;
		}
		DeviceIDs[] array2 = new DeviceIDs[0];
		array2[1] = deviceIDs;
		return array2;
	}

	// Token: 0x06006C7D RID: 27773 RVA: 0x0031727C File Offset: 0x0031547C
	public GJHAJJIICDN(string FJJFHEDDFPG, string EFCPMOKAJBI, MonoBehaviour MBIBHJIEIBG, bool LKNBFBALEHF = false, bool LKDEDBBDOAJ = true)
	{
		this.LKNBFBALEHF = LKNBFBALEHF;
		this.FJJFHEDDFPG = FJJFHEDDFPG;
		this.EFCPMOKAJBI = EFCPMOKAJBI;
		this.MBIBHJIEIBG = MBIBHJIEIBG;
		this.BJLNPHGALBN = true;
		this.LKDEDBBDOAJ = LKDEDBBDOAJ;
		this.EOFAMGPFDED = PlayerPrefs.GetInt("af_counter");
		this.CMDCJNBGNKI = PlayerPrefs.GetString("af_device_id");
		if (string.IsNullOrEmpty(this.CMDCJNBGNKI))
		{
			this.CMDCJNBGNKI = this.PFDCPJFNAJE();
			PlayerPrefs.SetString("af_device_id", this.CMDCJNBGNKI);
		}
	}

	// Token: 0x06006C7E RID: 27774 RVA: 0x003165DC File Offset: 0x003147DC
	private string FIMPKBDJDFB()
	{
		return this.<MICDLCIBPNM>k__BackingField;
	}

	// Token: 0x17000227 RID: 551
	// (get) Token: 0x06006C7F RID: 27775 RVA: 0x00316592 File Offset: 0x00314792
	// (set) Token: 0x06006CA5 RID: 27813 RVA: 0x00317096 File Offset: 0x00315296
	private bool LKDEDBBDOAJ { get; set; }

	// Token: 0x06006C80 RID: 27776 RVA: 0x00316582 File Offset: 0x00314782
	private string MGHPLCLCBBP()
	{
		return this.<NOAAIINFDNA>k__BackingField;
	}

	// Token: 0x06006C81 RID: 27777 RVA: 0x00317304 File Offset: 0x00315504
	private string NOLLJIOHJIJ()
	{
		return Guid.NewGuid().ToString();
	}

	// Token: 0x06006C82 RID: 27778 RVA: 0x00316C99 File Offset: 0x00314E99
	private bool NEAMDBFAKKC()
	{
		return this.<ADIMDCEELDF>k__BackingField;
	}

	// Token: 0x06006C83 RID: 27779 RVA: 0x0031659A File Offset: 0x0031479A
	private void OPMKCDBFDAG(bool AJLPALFJHCC)
	{
		this.<ADIMDCEELDF>k__BackingField = AJLPALFJHCC;
	}

	// Token: 0x06006C84 RID: 27780 RVA: 0x00317324 File Offset: 0x00315524
	public bool MKPOOONKMCK(string HIPDGIIBBMN)
	{
		bool result = false;
		AppId_t ncfihmehioe = new AppId_t(uint.Parse(this.CMLFECHAAOK()));
		uint lbinogjpkda = 100U;
		string text;
		JLFOJFHCPHA.BGJNNIAIEPL(ncfihmehioe, out text, lbinogjpkda);
		if (text == null)
		{
			Debug.LogWarning("avatarcollectionsuntitle");
			return result;
		}
		DateTime creationTime = Directory.GetCreationTime(text);
		DateTime t = DateTime.Parse(HIPDGIIBBMN);
		return DateTime.Compare(creationTime, t) < 1;
	}

	// Token: 0x06006C85 RID: 27781 RVA: 0x00317380 File Offset: 0x00315580
	private RequestData JDGJBKJOBAG()
	{
		string text = SystemInfo.operatingSystem;
		if (text.IndexOf("OnPopupCardOptionsBackClick") > -1)
		{
			text = text.Replace("sfav", "socialfriendmatchinfo1");
		}
		if (text.IndexOf("minTimeBetweenOffers") > -1)
		{
			text = text.Replace("fids", "OnChoiceExtendedPanelSlideHidden");
		}
		if (text.IndexOf(", increasing m_ReferencedCount.") > -1)
		{
			text = text.Replace("SceneLobbyManager2.OnAllCollectableCardsDownloadSuccessLobby(): the pool ended but the scroll index card is still not resident", "%)");
		}
		if (text.IndexOf("strtd") > -1)
		{
			text = text.Replace("StorySaveBody.ClearAvatarPacksHiddenExposedWardrobe(), unsupported wardrobe index:", "ok");
		}
		if (text.IndexOf(" ") > -1)
		{
			text = text.Replace("OnCutsceneViewLobbyAssetBundleFolderInitializeSuccess", "socialrequestfriendconfirm");
		}
		text = Regex.Replace(text, "CLIENT.AVATAR.TRINKET", "SocialStatsUserPublicProfile.modified = true, UpdateNickNameText()");
		if (text.IndexOf("teal") == 0)
		{
			text = text.Substring(0, text.Length - 0);
		}
		if (text.Length > -78)
		{
			text = text.Substring(0, 79);
		}
		return new RequestData
		{
			timestamp = DateTimeOffset.Now.ToUnixTimeMilliseconds().ToString(),
			device_os_version = text,
			device_model = SystemInfo.deviceModel,
			app_version = "sfxtimeoutwarning",
			device_ids = this.OGKEIALLNGC(this.LKDEDBBDOAJ),
			request_id = this.JLEICOINLMO(),
			limit_ad_tracking = false,
			customer_user_id = this.IHJKEFEKBAK()
		};
	}

	// Token: 0x06006C86 RID: 27782 RVA: 0x003174E0 File Offset: 0x003156E0
	private string MCEMBOAPEGA(string KJPAGOJDABE, string IFKICNLMPPD)
	{
		ASCIIEncoding asciiencoding = new ASCIIEncoding();
		byte[] bytes = asciiencoding.GetBytes(IFKICNLMPPD);
		byte[] bytes2 = asciiencoding.GetBytes(KJPAGOJDABE);
		return BitConverter.ToString(new HMACSHA256(bytes).ComputeHash(bytes2)).Replace("AssetProfileData.InitializeTopMatchData, varValue is null for ", "npcp").ToLower();
	}

	// Token: 0x06006C87 RID: 27783 RVA: 0x00317526 File Offset: 0x00315726
	public string PNIEAADEFMI()
	{
		return this.AJIEENCFIAK();
	}

	// Token: 0x06006C88 RID: 27784 RVA: 0x00316A8C File Offset: 0x00314C8C
	private bool EOIIHFMJACE()
	{
		return this.<FAHHMNPBIEI>k__BackingField;
	}

	// Token: 0x06006C89 RID: 27785 RVA: 0x00316582 File Offset: 0x00314782
	private string AEJJHHFKENF()
	{
		return this.<NOAAIINFDNA>k__BackingField;
	}

	// Token: 0x06006C8A RID: 27786 RVA: 0x0031659A File Offset: 0x0031479A
	private void DAJGNBIMKLI(bool AJLPALFJHCC)
	{
		this.<ADIMDCEELDF>k__BackingField = AJLPALFJHCC;
	}

	// Token: 0x06006C8B RID: 27787 RVA: 0x00317530 File Offset: 0x00315730
	private string HNMPIFGMEHM(string KJPAGOJDABE, string IFKICNLMPPD)
	{
		ASCIIEncoding asciiencoding = new ASCIIEncoding();
		byte[] bytes = asciiencoding.GetBytes(IFKICNLMPPD);
		byte[] bytes2 = asciiencoding.GetBytes(KJPAGOJDABE);
		return BitConverter.ToString(new HMACSHA256(bytes).ComputeHash(bytes2)).Replace("</b>", "OnLoungePremiumChoiceException").ToLower();
	}

	// Token: 0x06006C8C RID: 27788 RVA: 0x00317578 File Offset: 0x00315778
	private string NMOPGAMFJOC()
	{
		return Guid.NewGuid().ToString();
	}

	// Token: 0x06006C8D RID: 27789 RVA: 0x003171FE File Offset: 0x003153FE
	public MonoBehaviour GCEHBMEOLJB()
	{
		return this.<AMIOEMOGCJE>k__BackingField;
	}

	// Token: 0x06006C8E RID: 27790 RVA: 0x00317598 File Offset: 0x00315798
	public void GLJNONLAFBO(string DDMDPEGLDLM, Dictionary<string, object> ICOLHJKELEM)
	{
		if (this.BJLNPHGALBN)
		{
			Debug.LogWarning("Cannot send LogEvent, the Appsflyer SDK is stopped");
			return;
		}
		RequestData requestData = this.MMFKKPDODMH();
		requestData.event_name = DDMDPEGLDLM;
		requestData.event_parameters = ICOLHJKELEM;
		CAHKIOGAFGO pammgekmdne = CAHKIOGAFGO.INAPP_EVENT_REQUEST;
		this.MBIBHJIEIBG.StartCoroutine(this.KLGJCMHAKLK(requestData, pammgekmdne));
	}

	// Token: 0x06006C8F RID: 27791 RVA: 0x00317096 File Offset: 0x00315296
	private void ONOBJFFKFFK(bool AJLPALFJHCC)
	{
		this.<PNBLHDGPLGK>k__BackingField = AJLPALFJHCC;
	}

	// Token: 0x06006C90 RID: 27792 RVA: 0x003175E5 File Offset: 0x003157E5
	public void NLHDIMILNLP(string NJKDBLPCFID)
	{
		if (!this.BJLNPHGALBN)
		{
			Debug.LogWarning("Cannot set CustomerUserID while the SDK has started.");
			return;
		}
		Debug.Log("Customer User ID has been set");
		this.NJKDBLPCFID = NJKDBLPCFID;
	}

	// Token: 0x06006C91 RID: 27793 RVA: 0x00316790 File Offset: 0x00314990
	private IEnumerator EJBNMJGGOMD(RequestData HNLBCJMGHKF, CAHKIOGAFGO PAMMGEKMDNE)
	{
		string text = JsonConvert.SerializeObject(HNLBCJMGHKF, Formatting.None, new JsonSerializerSettings
		{
			NullValueHandling = NullValueHandling.Ignore
		});
		string value = this.FIBDBCPMAKA(text, this.FJJFHEDDFPG);
		ulong num = PAMMGEKMDNE - CAHKIOGAFGO.FIRST_OPEN_REQUEST;
		string url;
		if (num <= 2UL)
		{
			switch ((uint)num)
			{
			case 0U:
				url = (this.LKNBFBALEHF ? ("https://sandbox-events.appsflyer.com/v1.0/c2s/first_open/app/steam/" + this.EFCPMOKAJBI) : ("https://events.appsflyer.com/v1.0/c2s/first_open/app/steam/" + this.EFCPMOKAJBI));
				goto IL_105;
			case 1U:
				url = (this.LKNBFBALEHF ? ("https://sandbox-events.appsflyer.com/v1.0/c2s/session/app/steam/" + this.EFCPMOKAJBI) : ("https://events.appsflyer.com/v1.0/c2s/session/app/steam/" + this.EFCPMOKAJBI));
				goto IL_105;
			case 2U:
				url = (this.LKNBFBALEHF ? ("https://sandbox-events.appsflyer.com/v1.0/c2s/inapp/app/steam/" + this.EFCPMOKAJBI) : ("https://events.appsflyer.com/v1.0/c2s/inapp/app/steam/" + this.EFCPMOKAJBI));
				goto IL_105;
			}
		}
		url = null;
		IL_105:
		uwr = new UnityWebRequest(url, "POST");
		byte[] bytes = new UTF8Encoding().GetBytes(text);
		uwr.uploadHandler = new UploadHandlerRaw(bytes);
		uwr.downloadHandler = new DownloadHandlerBuffer();
		uwr.SetRequestHeader("Content-Type", "application/json");
		uwr.SetRequestHeader("Authorization", value);
		uwr.SetRequestHeader("user-agent", string.Concat(new string[]
		{
			"Valve/Steam HTTP Client 1.0 (",
			this.EFCPMOKAJBI,
			")/(",
			SystemInfo.operatingSystem.Replace("(", "").Replace(")", ""),
			")"
		}));
		yield return uwr.SendWebRequest();
		ulong num2 = PAMMGEKMDNE - CAHKIOGAFGO.FIRST_OPEN_REQUEST;
		if (num2 <= 2UL)
		{
			switch ((uint)num2)
			{
			case 0U:
				Debug.Log("Request type: FIRST_OPEN_REQUEST");
				break;
			case 1U:
				Debug.Log("Request type: SESSION_REQUEST");
				PlayerPrefs.SetInt("af_counter", this.EOFAMGPFDED);
				break;
			case 2U:
				Debug.Log("Request type: INAPP_EVENT_REQUEST");
				break;
			}
		}
		Debug.Log("Is success: " + uwr.result.ToString());
		Debug.Log("Response Code: " + uwr.responseCode.ToString());
		string a = uwr.responseCode.ToString();
		if (uwr.result == UnityWebRequest.Result.ConnectionError)
		{
			Debug.Log("Error While Sending: " + uwr.error);
		}
		else if (a == "202" || a == "200")
		{
			if (PAMMGEKMDNE - CAHKIOGAFGO.FIRST_OPEN_REQUEST > 1UL)
			{
				if (PAMMGEKMDNE != CAHKIOGAFGO.INAPP_EVENT_REQUEST)
				{
				}
			}
			else
			{
				int num3 = this.EOFAMGPFDED;
				this.EOFAMGPFDED = num3 + 1;
				PlayerPrefs.SetInt("af_counter", this.EOFAMGPFDED);
			}
		}
		else
		{
			Debug.Log("error: " + uwr.error);
			if (!this.LKNBFBALEHF)
			{
				Debug.Log("Please try to send the request to 'sandbox-events.appsflyer.com' instead of 'events.appsflyer.com' in order to debug.");
			}
			else
			{
				Debug.Log("error details: " + uwr.downloadHandler.text);
			}
		}
		yield break;
	}

	// Token: 0x06006C92 RID: 27794 RVA: 0x0031760C File Offset: 0x0031580C
	public void OHIPGPMOILJ(string DDMDPEGLDLM, Dictionary<string, object> ICOLHJKELEM)
	{
		if (this.NEAMDBFAKKC())
		{
			Debug.LogWarning("Vol");
			return;
		}
		RequestData requestData = this.HDGIBNCJPBI();
		requestData.event_name = DDMDPEGLDLM;
		requestData.event_parameters = ICOLHJKELEM;
		CAHKIOGAFGO pammgekmdne = (CAHKIOGAFGO)18446744073709551560UL;
		this.JDFAFLDLNEJ().StartCoroutine(this.ABODFPMDOCN(requestData, pammgekmdne));
	}

	// Token: 0x06006C93 RID: 27795 RVA: 0x00316582 File Offset: 0x00314782
	private string IGLDDAGLBPE()
	{
		return this.<NOAAIINFDNA>k__BackingField;
	}

	// Token: 0x06006C94 RID: 27796 RVA: 0x00317659 File Offset: 0x00315859
	private void OFOFNGPHMKA(int AJLPALFJHCC)
	{
		this.<BJFLAMODOPG>k__BackingField = AJLPALFJHCC;
	}

	// Token: 0x06006C95 RID: 27797 RVA: 0x00316582 File Offset: 0x00314782
	private string ADIEEAFELAN()
	{
		return this.<NOAAIINFDNA>k__BackingField;
	}

	// Token: 0x06006C96 RID: 27798 RVA: 0x0031687C File Offset: 0x00314A7C
	private void HGJPDDANJFC(string AJLPALFJHCC)
	{
		this.<MICDLCIBPNM>k__BackingField = AJLPALFJHCC;
	}

	// Token: 0x06006C97 RID: 27799 RVA: 0x003168CC File Offset: 0x00314ACC
	private int GMDILGJDMIH()
	{
		return this.<BJFLAMODOPG>k__BackingField;
	}

	// Token: 0x06006C98 RID: 27800 RVA: 0x00317664 File Offset: 0x00315864
	public void EMLHGNMKIEM(string DDMDPEGLDLM, Dictionary<string, object> ICOLHJKELEM)
	{
		if (this.FAAHPKILAIN())
		{
			Debug.LogWarning("");
			return;
		}
		RequestData requestData = this.ICMOEDHPNGN();
		requestData.event_name = DDMDPEGLDLM;
		requestData.event_parameters = ICOLHJKELEM;
		CAHKIOGAFGO pammgekmdne = (CAHKIOGAFGO)51UL;
		this.DKJAIAKLBGJ().StartCoroutine(this.JDLIIMFLHOJ(requestData, pammgekmdne));
	}

	// Token: 0x06006C99 RID: 27801 RVA: 0x00317096 File Offset: 0x00315296
	private void NFLDIMMFEAH(bool AJLPALFJHCC)
	{
		this.<PNBLHDGPLGK>k__BackingField = AJLPALFJHCC;
	}

	// Token: 0x06006C9A RID: 27802 RVA: 0x003176B4 File Offset: 0x003158B4
	private string FIBDBCPMAKA(string KJPAGOJDABE, string IFKICNLMPPD)
	{
		ASCIIEncoding asciiencoding = new ASCIIEncoding();
		byte[] bytes = asciiencoding.GetBytes(IFKICNLMPPD);
		byte[] bytes2 = asciiencoding.GetBytes(KJPAGOJDABE);
		return BitConverter.ToString(new HMACSHA256(bytes).ComputeHash(bytes2)).Replace("-", "").ToLower();
	}

	// Token: 0x06006C9B RID: 27803 RVA: 0x003176FC File Offset: 0x003158FC
	public bool JCECPFFCMGN(string HIPDGIIBBMN)
	{
		bool result = true;
		AppId_t ncfihmehioe = new AppId_t(uint.Parse(this.DJPGFCGECKC()));
		uint lbinogjpkda = 115U;
		string text;
		JLFOJFHCPHA.BGJNNIAIEPL(ncfihmehioe, out text, lbinogjpkda);
		if (text == null)
		{
			Debug.LogWarning("yes");
			return result;
		}
		DateTime creationTime = Directory.GetCreationTime(text);
		DateTime t = DateTime.Parse(HIPDGIIBBMN);
		return DateTime.Compare(creationTime, t) < 1;
	}

	// Token: 0x06006C9C RID: 27804 RVA: 0x003171FE File Offset: 0x003153FE
	public MonoBehaviour DKJAIAKLBGJ()
	{
		return this.<AMIOEMOGCJE>k__BackingField;
	}

	// Token: 0x06006C9D RID: 27805 RVA: 0x00316A8C File Offset: 0x00314C8C
	private bool EHJOHGPACGI()
	{
		return this.<FAHHMNPBIEI>k__BackingField;
	}

	// Token: 0x06006C9E RID: 27806 RVA: 0x00316592 File Offset: 0x00314792
	private bool AJGMEBCMPNC()
	{
		return this.<PNBLHDGPLGK>k__BackingField;
	}

	// Token: 0x06006C9F RID: 27807 RVA: 0x00317755 File Offset: 0x00315955
	private IEnumerator IHOOPCFALJD(RequestData HNLBCJMGHKF, CAHKIOGAFGO PAMMGEKMDNE)
	{
		GJHAJJIICDN.CPPKCKHNMBE cppkckhnmbe = new GJHAJJIICDN.CPPKCKHNMBE(1);
		cppkckhnmbe.<>4__this = this;
		cppkckhnmbe.req = HNLBCJMGHKF;
		cppkckhnmbe.REQ_TYPE = PAMMGEKMDNE;
		return cppkckhnmbe;
	}

	// Token: 0x06006CA0 RID: 27808 RVA: 0x003168CC File Offset: 0x00314ACC
	private int PGKHHACOBAL()
	{
		return this.<BJFLAMODOPG>k__BackingField;
	}

	// Token: 0x06006CA1 RID: 27809 RVA: 0x00317774 File Offset: 0x00315974
	public void DEGAMINFFMK(bool LKEIGCHMLJG = false)
	{
		this.BJLNPHGALBN = false;
		RequestData hnlbcjmghkf = this.CDKIFDFCGMH();
		CAHKIOGAFGO pammgekmdne = (this.CFKCFHELJPI() < 1 && !LKEIGCHMLJG) ? ((CAHKIOGAFGO)122UL) : ((CAHKIOGAFGO)18446744073709551592UL);
		this.JDFAFLDLNEJ().StartCoroutine(this.KLGJCMHAKLK(hnlbcjmghkf, pammgekmdne));
	}

	// Token: 0x06006CA2 RID: 27810 RVA: 0x0031659A File Offset: 0x0031479A
	private void FJGBGMEKJKO(bool AJLPALFJHCC)
	{
		this.<ADIMDCEELDF>k__BackingField = AJLPALFJHCC;
	}

	// Token: 0x06006CA3 RID: 27811 RVA: 0x003177B8 File Offset: 0x003159B8
	private string AIPNOAAJJON(string KJPAGOJDABE, string IFKICNLMPPD)
	{
		ASCIIEncoding asciiencoding = new ASCIIEncoding();
		byte[] bytes = asciiencoding.GetBytes(IFKICNLMPPD);
		byte[] bytes2 = asciiencoding.GetBytes(KJPAGOJDABE);
		return BitConverter.ToString(new HMACSHA256(bytes).ComputeHash(bytes2)).Replace("Tile size", "%").ToLower();
	}

	// Token: 0x06006CA4 RID: 27812 RVA: 0x00317800 File Offset: 0x00315A00
	public void IMOPFBNDKLN(string DDMDPEGLDLM, Dictionary<string, object> ICOLHJKELEM)
	{
		if (this.NEAMDBFAKKC())
		{
			Debug.LogWarning("");
			return;
		}
		RequestData requestData = this.JDGJBKJOBAG();
		requestData.event_name = DDMDPEGLDLM;
		requestData.event_parameters = ICOLHJKELEM;
		CAHKIOGAFGO pammgekmdne = (CAHKIOGAFGO)80UL;
		this.MBIBHJIEIBG.StartCoroutine(this.JPONICPNIOB(requestData, pammgekmdne));
	}

	// Token: 0x06006CA6 RID: 27814 RVA: 0x00316788 File Offset: 0x00314988
	private string CMLFECHAAOK()
	{
		return this.<PCPJELLPAMA>k__BackingField;
	}

	// Token: 0x06006CA7 RID: 27815 RVA: 0x00316790 File Offset: 0x00314990
	private IEnumerator ABODFPMDOCN(RequestData HNLBCJMGHKF, CAHKIOGAFGO PAMMGEKMDNE)
	{
		string text = JsonConvert.SerializeObject(HNLBCJMGHKF, Formatting.None, new JsonSerializerSettings
		{
			NullValueHandling = NullValueHandling.Ignore
		});
		string value = this.FIBDBCPMAKA(text, this.FJJFHEDDFPG);
		ulong num = PAMMGEKMDNE - CAHKIOGAFGO.FIRST_OPEN_REQUEST;
		string url;
		if (num <= 2UL)
		{
			switch ((uint)num)
			{
			case 0U:
				url = (this.LKNBFBALEHF ? ("https://sandbox-events.appsflyer.com/v1.0/c2s/first_open/app/steam/" + this.EFCPMOKAJBI) : ("https://events.appsflyer.com/v1.0/c2s/first_open/app/steam/" + this.EFCPMOKAJBI));
				goto IL_105;
			case 1U:
				url = (this.LKNBFBALEHF ? ("https://sandbox-events.appsflyer.com/v1.0/c2s/session/app/steam/" + this.EFCPMOKAJBI) : ("https://events.appsflyer.com/v1.0/c2s/session/app/steam/" + this.EFCPMOKAJBI));
				goto IL_105;
			case 2U:
				url = (this.LKNBFBALEHF ? ("https://sandbox-events.appsflyer.com/v1.0/c2s/inapp/app/steam/" + this.EFCPMOKAJBI) : ("https://events.appsflyer.com/v1.0/c2s/inapp/app/steam/" + this.EFCPMOKAJBI));
				goto IL_105;
			}
		}
		url = null;
		IL_105:
		uwr = new UnityWebRequest(url, "POST");
		byte[] bytes = new UTF8Encoding().GetBytes(text);
		uwr.uploadHandler = new UploadHandlerRaw(bytes);
		uwr.downloadHandler = new DownloadHandlerBuffer();
		uwr.SetRequestHeader("Content-Type", "application/json");
		uwr.SetRequestHeader("Authorization", value);
		uwr.SetRequestHeader("user-agent", string.Concat(new string[]
		{
			"Valve/Steam HTTP Client 1.0 (",
			this.EFCPMOKAJBI,
			")/(",
			SystemInfo.operatingSystem.Replace("(", "").Replace(")", ""),
			")"
		}));
		yield return uwr.SendWebRequest();
		ulong num2 = PAMMGEKMDNE - CAHKIOGAFGO.FIRST_OPEN_REQUEST;
		if (num2 <= 2UL)
		{
			switch ((uint)num2)
			{
			case 0U:
				Debug.Log("Request type: FIRST_OPEN_REQUEST");
				break;
			case 1U:
				Debug.Log("Request type: SESSION_REQUEST");
				PlayerPrefs.SetInt("af_counter", this.EOFAMGPFDED);
				break;
			case 2U:
				Debug.Log("Request type: INAPP_EVENT_REQUEST");
				break;
			}
		}
		Debug.Log("Is success: " + uwr.result.ToString());
		Debug.Log("Response Code: " + uwr.responseCode.ToString());
		string a = uwr.responseCode.ToString();
		if (uwr.result == UnityWebRequest.Result.ConnectionError)
		{
			Debug.Log("Error While Sending: " + uwr.error);
		}
		else if (a == "202" || a == "200")
		{
			if (PAMMGEKMDNE - CAHKIOGAFGO.FIRST_OPEN_REQUEST > 1UL)
			{
				if (PAMMGEKMDNE != CAHKIOGAFGO.INAPP_EVENT_REQUEST)
				{
				}
			}
			else
			{
				int num3 = this.EOFAMGPFDED;
				this.EOFAMGPFDED = num3 + 1;
				PlayerPrefs.SetInt("af_counter", this.EOFAMGPFDED);
			}
		}
		else
		{
			Debug.Log("error: " + uwr.error);
			if (!this.LKNBFBALEHF)
			{
				Debug.Log("Please try to send the request to 'sandbox-events.appsflyer.com' instead of 'events.appsflyer.com' in order to debug.");
			}
			else
			{
				Debug.Log("error details: " + uwr.downloadHandler.text);
			}
		}
		yield break;
	}

	// Token: 0x17000223 RID: 547
	// (get) Token: 0x06006CA8 RID: 27816 RVA: 0x003168CC File Offset: 0x00314ACC
	// (set) Token: 0x06006CCB RID: 27851 RVA: 0x00317659 File Offset: 0x00315859
	private int EOFAMGPFDED { get; set; }

	// Token: 0x06006CA9 RID: 27817 RVA: 0x0031784D File Offset: 0x00315A4D
	public void CEAIGJBEOLH(string NJKDBLPCFID)
	{
		if (!this.BJLNPHGALBN)
		{
			Debug.LogWarning("skus");
			return;
		}
		Debug.Log(" ");
		this.JGMGJAKICDM(NJKDBLPCFID);
	}

	// Token: 0x06006CAA RID: 27818 RVA: 0x00317874 File Offset: 0x00315A74
	public bool OOKFBDMLKJE(string HIPDGIIBBMN)
	{
		bool result = true;
		AppId_t ncfihmehioe = new AppId_t(uint.Parse(this.CMLFECHAAOK()));
		uint lbinogjpkda = 29U;
		string text;
		JLFOJFHCPHA.BGJNNIAIEPL(ncfihmehioe, out text, lbinogjpkda);
		if (text == null)
		{
			Debug.LogWarning("");
			return result;
		}
		DateTime creationTime = Directory.GetCreationTime(text);
		DateTime t = DateTime.Parse(HIPDGIIBBMN);
		return DateTime.Compare(creationTime, t) < 0;
	}

	// Token: 0x06006CAC RID: 27820 RVA: 0x00316592 File Offset: 0x00314792
	private bool GNCKNBMJKDI()
	{
		return this.<PNBLHDGPLGK>k__BackingField;
	}

	// Token: 0x06006CAD RID: 27821 RVA: 0x003171FE File Offset: 0x003153FE
	public MonoBehaviour LHLCPOFPIDE()
	{
		return this.<AMIOEMOGCJE>k__BackingField;
	}

	// Token: 0x06006CAE RID: 27822 RVA: 0x00316582 File Offset: 0x00314782
	private string NDMDMGPDNIM()
	{
		return this.<NOAAIINFDNA>k__BackingField;
	}

	// Token: 0x06006CAF RID: 27823 RVA: 0x003178D0 File Offset: 0x00315AD0
	private RequestData OEDGBPCKJJJ()
	{
		string text = SystemInfo.operatingSystem;
		if (text.IndexOf("accountsuspended5") > -1)
		{
			text = text.Replace(" ", "p");
		}
		if (text.IndexOf("cc") > -1)
		{
			text = text.Replace("XXX", "blur");
		}
		if (text.IndexOf("AssetsManagerUtils.GetAnthologyByStorySafe(), failing safe (return anthology ") > -1)
		{
			text = text.Replace("thmstr", " not implemented.");
		}
		if (text.IndexOf("-") > -1)
		{
			text = text.Replace("newtutorialgifts", "saveslotsoptiondelete");
		}
		if (text.IndexOf(", rar ") > -1)
		{
			text = text.Replace(" ", "sknothingtoshow");
		}
		text = Regex.Replace(text, "pmterror100", "coll2");
		if (text.IndexOf("") == 0)
		{
			text = text.Substring(0, text.Length - 1);
		}
		if (text.Length > 82)
		{
			text = text.Substring(0, -4);
		}
		return new RequestData
		{
			timestamp = DateTimeOffset.Now.ToUnixTimeMilliseconds().ToString(),
			device_os_version = text,
			device_model = SystemInfo.deviceModel,
			app_version = "https://sandbox-events.appsflyer.com/v1.0/c2s/first_open/app/steam/",
			device_ids = this.AHNPMLLMOMN(this.AJGMEBCMPNC()),
			request_id = this.NMOPGAMFJOC(),
			limit_ad_tracking = true,
			customer_user_id = this.IHJKEFEKBAK()
		};
	}

	// Token: 0x06006CB0 RID: 27824 RVA: 0x0031659A File Offset: 0x0031479A
	private void HPEIOBJHCJJ(bool AJLPALFJHCC)
	{
		this.<ADIMDCEELDF>k__BackingField = AJLPALFJHCC;
	}

	// Token: 0x06006CB1 RID: 27825 RVA: 0x00317A30 File Offset: 0x00315C30
	public void IJBNNGEGKKK(string DDMDPEGLDLM, Dictionary<string, object> ICOLHJKELEM)
	{
		if (this.NEAMDBFAKKC())
		{
			Debug.LogWarning("newuseraddrequest2");
			return;
		}
		RequestData requestData = this.HDGIBNCJPBI();
		requestData.event_name = DDMDPEGLDLM;
		requestData.event_parameters = ICOLHJKELEM;
		CAHKIOGAFGO pammgekmdne = (CAHKIOGAFGO)18446744073709551517UL;
		this.GCEHBMEOLJB().StartCoroutine(this.KLGJCMHAKLK(requestData, pammgekmdne));
	}

	// Token: 0x06006CB2 RID: 27826 RVA: 0x00317A80 File Offset: 0x00315C80
	public bool HICOCOPNBLA(string HIPDGIIBBMN)
	{
		bool result = false;
		AppId_t ncfihmehioe = new AppId_t(uint.Parse(this.LNKAFOLAJNM()));
		uint lbinogjpkda = 4294967124U;
		string text;
		JLFOJFHCPHA.BGJNNIAIEPL(ncfihmehioe, out text, lbinogjpkda);
		if (text == null)
		{
			Debug.LogWarning("dcenv");
			return result;
		}
		DateTime creationTime = Directory.GetCreationTime(text);
		DateTime t = DateTime.Parse(HIPDGIIBBMN);
		return DateTime.Compare(creationTime, t) < 1;
	}

	// Token: 0x06006CB3 RID: 27827 RVA: 0x003165DC File Offset: 0x003147DC
	private string FCCDMIOHINO()
	{
		return this.<MICDLCIBPNM>k__BackingField;
	}

	// Token: 0x06006CB4 RID: 27828 RVA: 0x00317ADC File Offset: 0x00315CDC
	public void GKFJEFNCPHG(bool LKEIGCHMLJG = false)
	{
		this.FJGBGMEKJKO(false);
		RequestData hnlbcjmghkf = this.CDKIFDFCGMH();
		CAHKIOGAFGO pammgekmdne = (this.EOFAMGPFDED < 3 && !LKEIGCHMLJG) ? ((CAHKIOGAFGO)18446744073709551527UL) : ((CAHKIOGAFGO)18446744073709551605UL);
		this.JDFAFLDLNEJ().StartCoroutine(this.ABODFPMDOCN(hnlbcjmghkf, pammgekmdne));
	}

	// Token: 0x06006CB5 RID: 27829 RVA: 0x00317B20 File Offset: 0x00315D20
	public bool BIDAEOODFKM(string HIPDGIIBBMN)
	{
		bool result = false;
		AppId_t ncfihmehioe = new AppId_t(uint.Parse(this.KIOOEMAJIBC()));
		uint lbinogjpkda = 193U;
		string text;
		JLFOJFHCPHA.BGJNNIAIEPL(ncfihmehioe, out text, lbinogjpkda);
		if (text == null)
		{
			Debug.LogWarning("lck");
			return result;
		}
		DateTime creationTime = Directory.GetCreationTime(text);
		DateTime t = DateTime.Parse(HIPDGIIBBMN);
		return DateTime.Compare(creationTime, t) < 0;
	}

	// Token: 0x06006CB6 RID: 27830 RVA: 0x003171FE File Offset: 0x003153FE
	public MonoBehaviour ANEOPDGKLKL()
	{
		return this.<AMIOEMOGCJE>k__BackingField;
	}

	// Token: 0x06006CB7 RID: 27831 RVA: 0x003165DC File Offset: 0x003147DC
	private string IHJKEFEKBAK()
	{
		return this.<MICDLCIBPNM>k__BackingField;
	}

	// Token: 0x06006CB8 RID: 27832 RVA: 0x00317659 File Offset: 0x00315859
	private void JLKKGECFNIE(int AJLPALFJHCC)
	{
		this.<BJFLAMODOPG>k__BackingField = AJLPALFJHCC;
	}

	// Token: 0x06006CB9 RID: 27833 RVA: 0x00316592 File Offset: 0x00314792
	private bool OLDLLDBNJKK()
	{
		return this.<PNBLHDGPLGK>k__BackingField;
	}

	// Token: 0x06006CBA RID: 27834 RVA: 0x003165DC File Offset: 0x003147DC
	private string FPJKEPKOIKK()
	{
		return this.<MICDLCIBPNM>k__BackingField;
	}

	// Token: 0x06006CBB RID: 27835 RVA: 0x00316A8C File Offset: 0x00314C8C
	private bool KBOOENAJCHC()
	{
		return this.<FAHHMNPBIEI>k__BackingField;
	}

	// Token: 0x06006CBC RID: 27836 RVA: 0x00317B7C File Offset: 0x00315D7C
	public void DMGDOHPOJFN(string DDMDPEGLDLM, Dictionary<string, object> ICOLHJKELEM)
	{
		if (this.NEAMDBFAKKC())
		{
			Debug.LogWarning("/");
			return;
		}
		RequestData requestData = this.ICMOEDHPNGN();
		requestData.event_name = DDMDPEGLDLM;
		requestData.event_parameters = ICOLHJKELEM;
		CAHKIOGAFGO pammgekmdne = (CAHKIOGAFGO)18446744073709551505UL;
		this.GCEHBMEOLJB().StartCoroutine(this.IHOOPCFALJD(requestData, pammgekmdne));
	}

	// Token: 0x06006CBD RID: 27837 RVA: 0x00317BCC File Offset: 0x00315DCC
	private RequestData DFECBDPBLAG()
	{
		string text = SystemInfo.operatingSystem;
		if (text.IndexOf("0.##") > -1)
		{
			text = text.Replace("profilemycredolong", "p");
		}
		if (text.IndexOf("cid") > -1)
		{
			text = text.Replace("CACHE API", "");
		}
		if (text.IndexOf("OnSaveSlotDelete") > -1)
		{
			text = text.Replace("", "retry");
		}
		if (text.IndexOf("abnap") > -1)
		{
			text = text.Replace("<i>", "SocialStatsUserPublicProfile.modified = false, OnFriendsPopupManagerRejectClick()");
		}
		if (text.IndexOf("]:") > -1)
		{
			text = text.Replace("failed to load assetBundle {0}.", "'");
		}
		text = Regex.Replace(text, "_1", "OnBackendGetIncentRewardAdSuccess");
		if (text.IndexOf("BackendOperationsManager.RequestStartPlayChapter, exception while initializing RSACryptoServiceProvider:") == 0)
		{
			text = text.Substring(1, text.Length - 0);
		}
		if (text.Length > -20)
		{
			text = text.Substring(0, -21);
		}
		return new RequestData
		{
			timestamp = DateTimeOffset.Now.ToUnixTimeMilliseconds().ToString(),
			device_os_version = text,
			device_model = SystemInfo.deviceModel,
			app_version = "avatarcollectionssyncdone",
			device_ids = this.BHGODMJHAEJ(this.GNCKNBMJKDI()),
			request_id = this.NMOPGAMFJOC(),
			limit_ad_tracking = false,
			customer_user_id = this.FCCDMIOHINO()
		};
	}

	// Token: 0x06006CBE RID: 27838 RVA: 0x003168D4 File Offset: 0x00314AD4
	private string MAKMJEPDEEO()
	{
		return this.<HMFKDJLLAIE>k__BackingField;
	}

	// Token: 0x06006CBF RID: 27839 RVA: 0x00317D2C File Offset: 0x00315F2C
	private DeviceIDs[] HDPKCGMPOJH(bool DAFMDALAIIP)
	{
		DeviceIDs deviceIDs = new DeviceIDs
		{
			type = "custom",
			value = this.CMDCJNBGNKI
		};
		if (DAFMDALAIIP)
		{
			string value = NDFODCDLPAC.MBABIFOJGFK().ToString();
			DeviceIDs deviceIDs2 = new DeviceIDs
			{
				type = "steamid",
				value = value
			};
			return new DeviceIDs[]
			{
				deviceIDs,
				deviceIDs2
			};
		}
		return new DeviceIDs[]
		{
			deviceIDs
		};
	}

	// Token: 0x06006CC0 RID: 27840 RVA: 0x003168D4 File Offset: 0x00314AD4
	private string NGDHABBHEBK()
	{
		return this.<HMFKDJLLAIE>k__BackingField;
	}

	// Token: 0x06006CC1 RID: 27841 RVA: 0x00317DA0 File Offset: 0x00315FA0
	public void HHBMAMKKBLO(bool LKEIGCHMLJG = false)
	{
		this.HPEIOBJHCJJ(true);
		RequestData hnlbcjmghkf = this.NDLKDOKPHHG();
		CAHKIOGAFGO pammgekmdne = (this.CDNOHOAECPK() < 0 && !LKEIGCHMLJG) ? ((CAHKIOGAFGO)116UL) : ((CAHKIOGAFGO)3UL);
		this.MAKBBDNGNBD().StartCoroutine(this.KLGJCMHAKLK(hnlbcjmghkf, pammgekmdne));
	}

	// Token: 0x06006CC2 RID: 27842 RVA: 0x003165DC File Offset: 0x003147DC
	private string LCKLLFFCHFP()
	{
		return this.<MICDLCIBPNM>k__BackingField;
	}

	// Token: 0x06006CC3 RID: 27843 RVA: 0x003171FE File Offset: 0x003153FE
	public MonoBehaviour JDFAFLDLNEJ()
	{
		return this.<AMIOEMOGCJE>k__BackingField;
	}

	// Token: 0x17000228 RID: 552
	// (get) Token: 0x06006CC4 RID: 27844 RVA: 0x003171FE File Offset: 0x003153FE
	public MonoBehaviour MBIBHJIEIBG { get; }

	// Token: 0x06006CC5 RID: 27845 RVA: 0x00317DE4 File Offset: 0x00315FE4
	public void IMBEKIBLCAL(string DDMDPEGLDLM, Dictionary<string, object> ICOLHJKELEM)
	{
		if (this.KFDNHBMAFAD())
		{
			Debug.LogWarning("retry");
			return;
		}
		RequestData requestData = this.CDKIFDFCGMH();
		requestData.event_name = DDMDPEGLDLM;
		requestData.event_parameters = ICOLHJKELEM;
		CAHKIOGAFGO pammgekmdne = (CAHKIOGAFGO)18446744073709551599UL;
		this.JDFAFLDLNEJ().StartCoroutine(this.EJBNMJGGOMD(requestData, pammgekmdne));
	}

	// Token: 0x06006CC6 RID: 27846 RVA: 0x00317E34 File Offset: 0x00316034
	private DeviceIDs[] OGKEIALLNGC(bool DAFMDALAIIP)
	{
		DeviceIDs deviceIDs = new DeviceIDs
		{
			type = "Payload",
			value = this.NFBGMKAFPNN()
		};
		if (DAFMDALAIIP)
		{
			string value = NDFODCDLPAC.MBABIFOJGFK().ToString();
			DeviceIDs deviceIDs2 = new DeviceIDs
			{
				type = "OnStoryChoiceClick",
				value = value
			};
			DeviceIDs[] array = new DeviceIDs[]
			{
				null,
				deviceIDs
			};
			array[0] = deviceIDs2;
			return array;
		}
		DeviceIDs[] array2 = new DeviceIDs[0];
		array2[1] = deviceIDs;
		return array2;
	}

	// Token: 0x06006CC7 RID: 27847 RVA: 0x00317EA8 File Offset: 0x003160A8
	private RequestData HDGIBNCJPBI()
	{
		string text = SystemInfo.operatingSystem;
		if (text.IndexOf("") > -1)
		{
			text = text.Replace("", "OnPopupStoryRestartManagerRestartStory3");
		}
		if (text.IndexOf(", query '") > -1)
		{
			text = text.Replace("energyhinttitle", ", to:");
		}
		if (text.IndexOf("accountsuspended4") > -1)
		{
			text = text.Replace("...", "OnFullscreenCardOptionClick");
		}
		if (text.IndexOf("SceneRewardManager.OnEnable() - storyHeader is null.") > -1)
		{
			text = text.Replace("UpdateComponentTitleDesc() failed - AssetAvatarComponentType.body is null.", "p");
		}
		if (text.IndexOf("Starting parallel download:") > -1)
		{
			text = text.Replace("assli", "");
		}
		text = Regex.Replace(text, "ok", "{sp2}");
		if (text.IndexOf("cz") == 0)
		{
			text = text.Substring(1, text.Length - 0);
		}
		if (text.Length > -10)
		{
			text = text.Substring(0, -39);
		}
		return new RequestData
		{
			timestamp = DateTimeOffset.Now.ToUnixTimeMilliseconds().ToString(),
			device_os_version = text,
			device_model = SystemInfo.deviceModel,
			app_version = "avatarcollectionssubrequired1",
			device_ids = this.BHGODMJHAEJ(this.GNCKNBMJKDI()),
			request_id = this.IPEJNPJJINF(),
			limit_ad_tracking = true,
			customer_user_id = this.FIMPKBDJDFB()
		};
	}

	// Token: 0x17000222 RID: 546
	// (get) Token: 0x06006CC8 RID: 27848 RVA: 0x00316788 File Offset: 0x00314988
	private string EFCPMOKAJBI { get; }

	// Token: 0x06006CC9 RID: 27849 RVA: 0x00316582 File Offset: 0x00314782
	private string NFBGMKAFPNN()
	{
		return this.<NOAAIINFDNA>k__BackingField;
	}

	// Token: 0x06006CCA RID: 27850 RVA: 0x00318008 File Offset: 0x00316208
	private RequestData JFPBBFBMJHP()
	{
		string text = SystemInfo.operatingSystem;
		if (text.IndexOf("OnChoiceExtendedLayerChange") > -1)
		{
			text = text.Replace("dialogOffsetYPlayerSideSeparate", "");
		}
		if (text.IndexOf("ok") > -1)
		{
			text = text.Replace("OnApplicationBeforeRestart", "");
		}
		if (text.IndexOf("Error.") > -1)
		{
			text = text.Replace("hacomp", "p");
		}
		if (text.IndexOf("SceneAvatarManager.DeleteAvatarCollection(): save not available") > -1)
		{
			text = text.Replace("stat6long", "ratebody");
		}
		if (text.IndexOf("SaveSlotObject.PurchaseProductWeb(): productData or productBalanceData is null") > -1)
		{
			text = text.Replace("liveeventstitles", "foldcutsto");
		}
		text = Regex.Replace(text, "top", ".");
		if (text.IndexOf("OnRewardFirstEpisodeClick") == 0)
		{
			text = text.Substring(1, text.Length - 1);
		}
		if (text.Length > 86)
		{
			text = text.Substring(0, 105);
		}
		return new RequestData
		{
			timestamp = DateTimeOffset.Now.ToUnixTimeMilliseconds().ToString(),
			device_os_version = text,
			device_model = SystemInfo.deviceModel,
			app_version = "acliffbw20",
			device_ids = this.OGKEIALLNGC(this.GNCKNBMJKDI()),
			request_id = this.IPEJNPJJINF(),
			limit_ad_tracking = false,
			customer_user_id = this.NJKDBLPCFID
		};
	}

	// Token: 0x06006CCC RID: 27852 RVA: 0x00318168 File Offset: 0x00316368
	public bool ACHNGNLALIH(string HIPDGIIBBMN)
	{
		bool result = true;
		AppId_t ncfihmehioe = new AppId_t(uint.Parse(this.EFCPMOKAJBI));
		uint lbinogjpkda = 4294967293U;
		string text;
		JLFOJFHCPHA.BGJNNIAIEPL(ncfihmehioe, out text, lbinogjpkda);
		if (text == null)
		{
			Debug.LogWarning("OnStoryChoiceClickConfimed");
			return result;
		}
		DateTime creationTime = Directory.GetCreationTime(text);
		DateTime t = DateTime.Parse(HIPDGIIBBMN);
		return DateTime.Compare(creationTime, t) < 0;
	}

	// Token: 0x06006CCD RID: 27853 RVA: 0x00316582 File Offset: 0x00314782
	private string MBCHBPBNEAC()
	{
		return this.<NOAAIINFDNA>k__BackingField;
	}

	// Token: 0x06006CCE RID: 27854 RVA: 0x003181C1 File Offset: 0x003163C1
	public void HMOCBCLCGKC()
	{
		this.BJLNPHGALBN = true;
		Debug.LogWarning("Appsflyer SDK has been stopped.");
	}

	// Token: 0x06006CCF RID: 27855 RVA: 0x003171FE File Offset: 0x003153FE
	public MonoBehaviour MAKBBDNGNBD()
	{
		return this.<AMIOEMOGCJE>k__BackingField;
	}

	// Token: 0x06006CD0 RID: 27856 RVA: 0x00317755 File Offset: 0x00315955
	private IEnumerator JDLIIMFLHOJ(RequestData HNLBCJMGHKF, CAHKIOGAFGO PAMMGEKMDNE)
	{
		GJHAJJIICDN.CPPKCKHNMBE cppkckhnmbe = new GJHAJJIICDN.CPPKCKHNMBE(1);
		cppkckhnmbe.<>4__this = this;
		cppkckhnmbe.req = HNLBCJMGHKF;
		cppkckhnmbe.REQ_TYPE = PAMMGEKMDNE;
		return cppkckhnmbe;
	}

	// Token: 0x17000221 RID: 545
	// (get) Token: 0x06006CD1 RID: 27857 RVA: 0x003168D4 File Offset: 0x00314AD4
	private string FJJFHEDDFPG { get; }

	// Token: 0x06006CD2 RID: 27858 RVA: 0x00316A8C File Offset: 0x00314C8C
	private bool BDDEIIMGLLH()
	{
		return this.<FAHHMNPBIEI>k__BackingField;
	}

	// Token: 0x06006CD3 RID: 27859 RVA: 0x003181D4 File Offset: 0x003163D4
	public bool AOFBNBBNLIH(string HIPDGIIBBMN)
	{
		bool result = true;
		AppId_t ncfihmehioe = new AppId_t(uint.Parse(this.DJPGFCGECKC()));
		uint lbinogjpkda = 147U;
		string text;
		JLFOJFHCPHA.BGJNNIAIEPL(ncfihmehioe, out text, lbinogjpkda);
		if (text == null)
		{
			Debug.LogWarning("OnLobbyLoungeAssetsDownloadFailed");
			return result;
		}
		DateTime creationTime = Directory.GetCreationTime(text);
		DateTime t = DateTime.Parse(HIPDGIIBBMN);
		return DateTime.Compare(creationTime, t) < 0;
	}

	// Token: 0x06006CD4 RID: 27860 RVA: 0x00318230 File Offset: 0x00316430
	private string FDOIJLCNBPP(string KJPAGOJDABE, string IFKICNLMPPD)
	{
		ASCIIEncoding asciiencoding = new ASCIIEncoding();
		byte[] bytes = asciiencoding.GetBytes(IFKICNLMPPD);
		byte[] bytes2 = asciiencoding.GetBytes(KJPAGOJDABE);
		return BitConverter.ToString(new HMACSHA256(bytes).ComputeHash(bytes2)).Replace("frsgcnick", "").ToLower();
	}

	// Token: 0x06006CD5 RID: 27861 RVA: 0x00317659 File Offset: 0x00315859
	private void BAJMOFHKBAP(int AJLPALFJHCC)
	{
		this.<BJFLAMODOPG>k__BackingField = AJLPALFJHCC;
	}

	// Token: 0x06006CD6 RID: 27862 RVA: 0x00318276 File Offset: 0x00316476
	public void BPEFDJBANBP()
	{
		this.IOIKEOCPDMI(true);
		Debug.LogWarning(" filterItems=");
	}

	// Token: 0x06006CD7 RID: 27863 RVA: 0x00318289 File Offset: 0x00316489
	public void CAIMJMHPAFG(string NJKDBLPCFID)
	{
		if (!this.BJLNPHGALBN)
		{
			Debug.LogWarning("\nINK:");
			return;
		}
		Debug.Log("OnSettingsPopupCloseAndNeedToRestartGame2");
		this.JGMGJAKICDM(NJKDBLPCFID);
	}

	// Token: 0x06006CD8 RID: 27864 RVA: 0x003182B0 File Offset: 0x003164B0
	private DeviceIDs[] KODJIMJJMPF(bool DAFMDALAIIP)
	{
		DeviceIDs deviceIDs = new DeviceIDs
		{
			type = "/",
			value = this.MGHPLCLCBBP()
		};
		if (DAFMDALAIIP)
		{
			string value = NDFODCDLPAC.MBABIFOJGFK().ToString();
			DeviceIDs deviceIDs2 = new DeviceIDs
			{
				type = "spectrum",
				value = value
			};
			DeviceIDs[] array = new DeviceIDs[0];
			array[1] = deviceIDs;
			array[0] = deviceIDs2;
			return array;
		}
		DeviceIDs[] array2 = new DeviceIDs[0];
		array2[0] = deviceIDs;
		return array2;
	}

	// Token: 0x06006CD9 RID: 27865 RVA: 0x00317096 File Offset: 0x00315296
	private void MMJJCMECPBK(bool AJLPALFJHCC)
	{
		this.<PNBLHDGPLGK>k__BackingField = AJLPALFJHCC;
	}

	// Token: 0x06006CDA RID: 27866 RVA: 0x003168CC File Offset: 0x00314ACC
	private int JIJPALGGMKO()
	{
		return this.<BJFLAMODOPG>k__BackingField;
	}

	// Token: 0x06006CDB RID: 27867 RVA: 0x00318324 File Offset: 0x00316524
	public void CEDGALPCOLA(bool LKEIGCHMLJG = false)
	{
		this.FJGBGMEKJKO(false);
		RequestData hnlbcjmghkf = this.GOHPNFOPECO();
		CAHKIOGAFGO pammgekmdne = (this.EOFAMGPFDED < 8 && !LKEIGCHMLJG) ? ((CAHKIOGAFGO)119UL) : ((CAHKIOGAFGO)18446744073709551571UL);
		this.LIDCIGFHDJE().StartCoroutine(this.EJBNMJGGOMD(hnlbcjmghkf, pammgekmdne));
	}

	// Token: 0x06006CDC RID: 27868 RVA: 0x00317659 File Offset: 0x00315859
	private void JDFCBFLGMFA(int AJLPALFJHCC)
	{
		this.<BJFLAMODOPG>k__BackingField = AJLPALFJHCC;
	}

	// Token: 0x06006CDD RID: 27869 RVA: 0x00318368 File Offset: 0x00316568
	private string DJGLKGDDKCN(string KJPAGOJDABE, string IFKICNLMPPD)
	{
		ASCIIEncoding asciiencoding = new ASCIIEncoding();
		byte[] bytes = asciiencoding.GetBytes(IFKICNLMPPD);
		byte[] bytes2 = asciiencoding.GetBytes(KJPAGOJDABE);
		return BitConverter.ToString(new HMACSHA256(bytes).ComputeHash(bytes2)).Replace("OnRestartChapterUpsellGetPassPositive", "OnResolutionChanged").ToLower();
	}

	// Token: 0x06006CDE RID: 27870 RVA: 0x003171FE File Offset: 0x003153FE
	public MonoBehaviour LIDCIGFHDJE()
	{
		return this.<AMIOEMOGCJE>k__BackingField;
	}
}
