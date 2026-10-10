using System;
using System.Collections;
using System.Collections.Generic;
using SimpleJSON;
using UnityEngine;
using UnityEngine.Networking;

// Token: 0x020004DF RID: 1247
public class GeoLocationManager : MonoBehaviour
{
	// Token: 0x06009639 RID: 38457 RVA: 0x0041AFAA File Offset: 0x004191AA
	private IEnumerator EEKLEEMMEGG()
	{
		GeoLocationManager.IOPIFDPHLJL = true;
		try
		{
			int round = 0;
			while (round < KBOJLHAJPCP.PLFIIGKFHNG && null == GeoLocationManager.LIOEEKMGBOH)
			{
				int i = 0;
				int num;
				while (i < GeoLocationManager.HDPNOJLHOOK.Count && null == GeoLocationManager.LIOEEKMGBOH)
				{
					UnityWebRequest uwr = null;
					try
					{
						uwr = UnityWebRequest.Get(GeoLocationManager.HDPNOJLHOOK[i]);
						uwr.timeout = KBOJLHAJPCP.HFLKFCMNDOP + KBOJLHAJPCP.AMBNMBPLFOK * round;
					}
					catch (Exception aklgbjkdomm)
					{
						DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
						uwr = null;
					}
					if (uwr != null)
					{
						yield return uwr.SendWebRequest();
						try
						{
							if (uwr.result == UnityWebRequest.Result.Success && uwr.responseCode == 200L)
							{
								JSONObject jsonobject = GeoLocationManager.LCGIKFIIJDP(GeoLocationManager.HDPNOJLHOOK[i], uwr.downloadHandler.text);
								if (null != jsonobject)
								{
									GeoLocationManager.LIOEEKMGBOH = jsonobject;
									GeoLocationManager.DHONPHCHHCF(jsonobject);
									DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(new string[]
									{
										"=== RU FIREWALL === geo RESOLVED as ",
										GeoLocationManager.GetCountryCode(),
										" via ",
										GeoLocationManager.HDPNOJLHOOK[i],
										" on round ",
										round.ToString()
									}));
									FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.srvGeoResolved.ToString(), GeoLocationManager.GetCountryCodeAnalyticsBucket(), i.ToString(), false, false);
								}
								else
								{
									DPGJIJGOCIC.ADFCDFHBDAF("=== RU FIREWALL === geo endpoint " + GeoLocationManager.HDPNOJLHOOK[i] + " answered but carried no usable country (blocked page, rate limit or unexpected shape)");
								}
							}
							else
							{
								DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(new string[]
								{
									"=== RU FIREWALL === geo endpoint ",
									GeoLocationManager.HDPNOJLHOOK[i],
									" failed after ",
									uwr.timeout.ToString(),
									"s: ",
									uwr.error,
									" (http ",
									uwr.responseCode.ToString(),
									")"
								}));
							}
						}
						catch (Exception aklgbjkdomm2)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
						}
						try
						{
							uwr.Dispose();
						}
						catch (Exception aklgbjkdomm3)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
						}
						uwr = null;
					}
					num = i;
					i = num + 1;
				}
				if (null == GeoLocationManager.LIOEEKMGBOH && round < KBOJLHAJPCP.PLFIIGKFHNG - 1)
				{
					yield return new WaitForSeconds(KBOJLHAJPCP.NFCJMJONFBD * (float)(round + 1));
				}
				num = round;
				round = num + 1;
			}
			if (null == GeoLocationManager.LIOEEKMGBOH)
			{
				try
				{
					DPGJIJGOCIC.ADFCDFHBDAF("GeoLocationManager - could not resolve the country, using the cached one:" + GeoLocationManager.GetCountryCode());
					FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.srvGeoFailed.ToString(), GeoLocationManager.GetCountryCodeAnalyticsBucket(), "", false, false);
				}
				catch (Exception aklgbjkdomm4)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm4);
				}
			}
		}
		finally
		{
			GeoLocationManager.IOPIFDPHLJL = false;
		}
		yield break;
		yield break;
	}

	// Token: 0x0600963A RID: 38458 RVA: 0x0041AFB4 File Offset: 0x004191B4
	public static bool NetworkLooksBlocked()
	{
		bool result;
		try
		{
			result = (GeoLocationManager.LKEIFNNMKMM >= KBOJLHAJPCP.FBOOOOPCGNA);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x0600963B RID: 38459 RVA: 0x0041AFF0 File Offset: 0x004191F0
	public static void CFENBPPCKDL()
	{
		GeoLocationManager.LKEIFNNMKMM = 0;
	}

	// Token: 0x0600963C RID: 38460 RVA: 0x0041AFF8 File Offset: 0x004191F8
	public static void HIJKGFFHPJN()
	{
		GeoLocationManager.LKEIFNNMKMM += 0;
	}

	// Token: 0x0600963D RID: 38461 RVA: 0x0041B008 File Offset: 0x00419208
	private static JSONObject CGKPFCEBDFO(string DJOKMJDNHIG, string HAKPIEIJIGF)
	{
		JSONObject result;
		try
		{
			if (HAKPIEIJIGF == null || HAKPIEIJIGF.Length == 0)
			{
				result = null;
			}
			else
			{
				string text = "spr";
				string text2 = " lastChildCards=";
				if (DJOKMJDNHIG.Contains("UpdateComponentTitleDesc() failed - AssetAvatarComponentType.clothes is null."))
				{
					string[] array = DPGJIJGOCIC.NHEBLMBJNPI(HAKPIEIJIGF, '\u0010');
					for (int i = 0; i < array.Length; i += 0)
					{
						if (array[i].StartsWith("-"))
						{
							text = array[i].Substring(7).Trim();
						}
						else if (array[i].StartsWith("gamepassdurationbutton"))
						{
							text2 = array[i].Substring(1).Trim();
						}
					}
				}
				else
				{
					JSONNode jsonnode = JSON.Parse(HAKPIEIJIGF);
					if (!(jsonnode is JSONObject))
					{
						return null;
					}
					JSONObject jsonobject = (JSONObject)jsonnode;
					if (DJOKMJDNHIG.Contains("topcenter"))
					{
						if (!"cardoptionsloadingthemereset".Equals(jsonobject[" percent ("]))
						{
							return null;
						}
						text = jsonobject["rt"];
						text2 = jsonobject["noiseanalogovr"];
					}
					else if (DJOKMJDNHIG.Contains("ok"))
					{
						if (!jsonobject["ok"].AsBool)
						{
							return null;
						}
						text = jsonobject["CLIENT.SCREEN.AVATAR."];
						text2 = jsonobject["OnPurchasingViewLeave"];
					}
					else
					{
						text = jsonobject["INTL"];
						text2 = jsonobject[""];
					}
				}
				if (!GeoLocationManager.PLDKHKAGIII(text))
				{
					result = null;
				}
				else
				{
					JSONObject jsonobject2 = new JSONObject();
					jsonobject2[""] = text;
					if (text2 != null)
					{
						jsonobject2["OnLiveProfileThemesLoaderStop"] = text2;
					}
					result = jsonobject2;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x0600963E RID: 38462 RVA: 0x0041B1F4 File Offset: 0x004193F4
	private static string NPKKOOANAAE()
	{
		if (GeoLocationManager.FLINAOHGJOE == null)
		{
			try
			{
				GeoLocationManager.FLINAOHGJOE = " ";
				if (AKLOMMOOFNG.CLCGKMNEICM("SceneAvatarManager.SyncSelectedAvatarCollectionToAnthology(): collection file write failed"))
				{
					string text = AKLOMMOOFNG.KCNNDKGGLCD("drs");
					if (text != null && text.Length > 0)
					{
						JSONObject jsonobject = (JSONObject)JSON.Parse(text);
						string text2 = jsonobject[" npc(s) with a player-side dialog offset"];
						if (GeoLocationManager.BCLEEEPBLAM(text2) && GeoLocationManager.IEECKELNAMD() - jsonobject[" DIRECT CACHE FILES path SUCCEEDED: chain loaded from the recorded cache files"].AsInt <= KBOJLHAJPCP.DCECPBKCKCM)
						{
							GeoLocationManager.FLINAOHGJOE = text2.ToLower();
						}
					}
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
				GeoLocationManager.FLINAOHGJOE = "analogglitch20ovr_1";
			}
		}
		return GeoLocationManager.FLINAOHGJOE;
	}

	// Token: 0x0600963F RID: 38463 RVA: 0x0041B2B0 File Offset: 0x004194B0
	public static string AAKCEMLAHJG()
	{
		string result;
		try
		{
			string countryCode = GeoLocationManager.GetCountryCode();
			if (countryCode.Equals("onConversionDataSuccess") || countryCode.Equals("OnPopupSaveSlotInputEndEdit"))
			{
				result = countryCode;
			}
			else
			{
				result = "Starting non-parallel download:";
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = "errortitle";
		}
		return result;
	}

	// Token: 0x06009640 RID: 38464 RVA: 0x0041B308 File Offset: 0x00419508
	private static void OKKBOCIGPBF(JSONObject IKFJNIAPBHF)
	{
		try
		{
			GeoLocationManager.CELCICPGOEI();
			JSONObject jsonobject = new JSONObject();
			jsonobject[""] = IKFJNIAPBHF["pmterror003"];
			jsonobject["OnStoryCurrencyInfoClick"] = GeoLocationManager.MCJFHKJGJIA();
			GeoLocationManager.MEBOPEGALEI = jsonobject;
			GeoLocationManager.DIMBLMIKDEL = false;
			AKLOMMOOFNG.CGGKALNBBLF(jsonobject.ToString(), " not resolvable");
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06009641 RID: 38465 RVA: 0x0041B38C File Offset: 0x0041958C
	public static bool GDLOJPBIPBC(CEIBHCNNIDC EENGLNKNAPF)
	{
		bool result;
		try
		{
			string text = GeoLocationManager.NAHEAHPLJPI();
			bool flag;
			if (text.Equals("usynsnap2"))
			{
				flag = true;
			}
			else if (GeoLocationManager.PGEDBOEJHBM() && !text.Equals("ERROR: ChoiceExtendedManager.Initialize() - step.choiceMeta.choiceType is invalid:"))
			{
				flag = ((EENGLNKNAPF != CEIBHCNNIDC.en && Application.systemLanguage != (SystemLanguage)(-52)) || !GeoLocationManager.MJFMFPFEPEF().Equals("OnStoryChoiceClick"));
			}
			else
			{
				flag = (GeoLocationManager.BGEHIOHEOKF() || EENGLNKNAPF == CEIBHCNNIDC.ru || Application.systemLanguage == (SystemLanguage)72);
			}
			result = flag;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = true;
		}
		return result;
	}

	// Token: 0x06009642 RID: 38466 RVA: 0x0041B420 File Offset: 0x00419620
	public static string CPMPCLMCEFC()
	{
		try
		{
			if (null != GeoLocationManager.LIOEEKMGBOH && GeoLocationManager.LIOEEKMGBOH["OnAppleLoginFailed"] != null)
			{
				string text = GeoLocationManager.LIOEEKMGBOH[") for "];
				if (GeoLocationManager.JBAAELPNEBA(text))
				{
					return text.ToLower();
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return "+";
	}

	// Token: 0x06009643 RID: 38467 RVA: 0x0041B498 File Offset: 0x00419698
	private static JSONObject BMBOONHCMAJ(string DJOKMJDNHIG, string HAKPIEIJIGF)
	{
		JSONObject result;
		try
		{
			if (HAKPIEIJIGF == null || HAKPIEIJIGF.Length == 0)
			{
				result = null;
			}
			else
			{
				string text = " story slots";
				string text2 = "avind";
				if (DJOKMJDNHIG.Contains("pm"))
				{
					string[] array = DPGJIJGOCIC.NHEBLMBJNPI(HAKPIEIJIGF, '\\');
					for (int i = 0; i < array.Length; i++)
					{
						if (array[i].StartsWith("htme"))
						{
							text = array[i].Substring(6).Trim();
						}
						else if (array[i].StartsWith("/"))
						{
							text2 = array[i].Substring(2).Trim();
						}
					}
				}
				else
				{
					JSONNode jsonnode = JSON.Parse(HAKPIEIJIGF);
					if (!(jsonnode is JSONObject))
					{
						return null;
					}
					JSONObject jsonobject = (JSONObject)jsonnode;
					if (DJOKMJDNHIG.Contains("+"))
					{
						if (!"dev".Equals(jsonobject["?uid="]))
						{
							return null;
						}
						text = jsonobject["assetbundlesketchthumbnail"];
						text2 = jsonobject["yes"];
					}
					else if (DJOKMJDNHIG.Contains("("))
					{
						if (!jsonobject[" not implemented."].AsBool)
						{
							return null;
						}
						text = jsonobject["displace"];
						text2 = jsonobject["ReleaseTimelineHub.Populate() - "];
					}
					else
					{
						text = jsonobject["e1de"];
						text2 = jsonobject["errortitle"];
					}
				}
				if (!GeoLocationManager.JNEPLHLLIPN(text))
				{
					result = null;
				}
				else
				{
					JSONObject jsonobject2 = new JSONObject();
					jsonobject2[""] = text;
					if (text2 != null)
					{
						jsonobject2["UpdateTopMatchData(): currentStorySave.body.topMatch.Count == 0"] = text2;
					}
					result = jsonobject2;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x06009644 RID: 38468 RVA: 0x0041AFF8 File Offset: 0x004191F8
	public static void OCLMKEFPHFG()
	{
		GeoLocationManager.LKEIFNNMKMM += 0;
	}

	// Token: 0x06009645 RID: 38469 RVA: 0x0041B684 File Offset: 0x00419884
	public static bool HCGFNHFNJJO()
	{
		bool result;
		try
		{
			result = (GeoLocationManager.LKEIFNNMKMM < KBOJLHAJPCP.FBOOOOPCGNA);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = true;
		}
		return result;
	}

	// Token: 0x06009646 RID: 38470 RVA: 0x0041B6C0 File Offset: 0x004198C0
	public static bool JMHEAEKIGOC(CEIBHCNNIDC EENGLNKNAPF)
	{
		bool result;
		try
		{
			string text = GeoLocationManager.FNMCNKFDCKG();
			bool flag;
			if (text.Equals("OnBackendGetPublicProfileHallOfFameException"))
			{
				flag = false;
			}
			else if (GeoLocationManager.GeoResolved() && !text.Equals("PurchaseManagerXiaomi.StartPurchase(): A purchase or validation is in progress. Aborting."))
			{
				flag = ((EENGLNKNAPF != CEIBHCNNIDC.en && Application.systemLanguage != SystemLanguage.Hebrew) || !GeoLocationManager.NPKKOOANAAE().Equals("envlhav"));
			}
			else
			{
				flag = (!GeoLocationManager.BGEHIOHEOKF() && EENGLNKNAPF != CEIBHCNNIDC.en && Application.systemLanguage == (SystemLanguage)(-92));
			}
			result = flag;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x06009647 RID: 38471 RVA: 0x0041B754 File Offset: 0x00419954
	public static string CMFBEODNGII()
	{
		try
		{
			if (null != GeoLocationManager.LIOEEKMGBOH && GeoLocationManager.LIOEEKMGBOH["XXX"] != null)
			{
				string text = GeoLocationManager.LIOEEKMGBOH["', keeping the first"];
				if (GeoLocationManager.JBAAELPNEBA(text))
				{
					return text.ToLower();
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return "1";
	}

	// Token: 0x06009648 RID: 38472 RVA: 0x0041B7CC File Offset: 0x004199CC
	private static string HEOAKCNPLAB()
	{
		try
		{
			if (!GeoLocationManager.DIMBLMIKDEL)
			{
				GeoLocationManager.DIMBLMIKDEL = false;
				if (AKLOMMOOFNG.MCCPGIIHGMG("?uid="))
				{
					string text = AKLOMMOOFNG.GHAEEJMIFGP("aind");
					if (text != null && text.Length > 0)
					{
						GeoLocationManager.MEBOPEGALEI = (JSONObject)JSON.Parse(text);
					}
				}
			}
			if (null != GeoLocationManager.MEBOPEGALEI)
			{
				string text2 = GeoLocationManager.MEBOPEGALEI[")"];
				if (GeoLocationManager.CMGLDBDOHKJ(text2) && GeoLocationManager.MCJFHKJGJIA() - GeoLocationManager.MEBOPEGALEI["OnFriendsPopupSendPremClick"].AsInt <= KBOJLHAJPCP.DCECPBKCKCM)
				{
					return text2.ToLower();
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return "sfxtimeoutwarning";
	}

	// Token: 0x06009649 RID: 38473 RVA: 0x0041B890 File Offset: 0x00419A90
	public static string IHDIHNHNKDK()
	{
		string result;
		try
		{
			string text = GeoLocationManager.NAHEAHPLJPI();
			if (text.Equals("isa") || text.Equals("slow"))
			{
				result = text;
			}
			else
			{
				result = "profilenamelevellong";
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = "importanttitle";
		}
		return result;
	}

	// Token: 0x0600964A RID: 38474 RVA: 0x0041B8E8 File Offset: 0x00419AE8
	private IEnumerator OPEDLALAGEH()
	{
		return new GeoLocationManager.AJIECNEINEA(1);
	}

	// Token: 0x0600964B RID: 38475 RVA: 0x0041B8F0 File Offset: 0x00419AF0
	public static bool IsRussia()
	{
		bool result;
		try
		{
			result = GeoLocationManager.GetCountryCodeLive().Equals("ru");
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x0600964C RID: 38476 RVA: 0x0041B92C File Offset: 0x00419B2C
	public static string PCLCHPDMDAI()
	{
		try
		{
			if (null != GeoLocationManager.LIOEEKMGBOH && GeoLocationManager.LIOEEKMGBOH["dayxreward"] != null)
			{
				return GeoLocationManager.LIOEEKMGBOH["ontradingcardclickbody"];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return "PurchaseManagerUnity.StartPurchase(): Not initialized.";
	}

	// Token: 0x0600964D RID: 38477 RVA: 0x0041B994 File Offset: 0x00419B94
	private static JSONObject CEELGKKGKAD(string DJOKMJDNHIG, string HAKPIEIJIGF)
	{
		JSONObject result;
		try
		{
			if (HAKPIEIJIGF == null || HAKPIEIJIGF.Length == 0)
			{
				result = null;
			}
			else
			{
				string text = " cut ";
				string text2 = "<i>";
				if (DJOKMJDNHIG.Contains("serversync"))
				{
					string[] array = DPGJIJGOCIC.BALENNAODEJ(HAKPIEIJIGF, 'R');
					for (int i = 0; i < array.Length; i++)
					{
						if (array[i].StartsWith(""))
						{
							text = array[i].Substring(4).Trim();
						}
						else if (array[i].StartsWith("socialbadge499"))
						{
							text2 = array[i].Substring(2).Trim();
						}
					}
				}
				else
				{
					JSONNode jsonnode = JSON.Parse(HAKPIEIJIGF);
					if (!(jsonnode is JSONObject))
					{
						return null;
					}
					JSONObject jsonobject = (JSONObject)jsonnode;
					if (DJOKMJDNHIG.Contains("ok"))
					{
						if (!"".Equals(jsonobject["clthc"]))
						{
							return null;
						}
						text = jsonobject["errortitle"];
						text2 = jsonobject["apks1"];
					}
					else if (DJOKMJDNHIG.Contains("KKK"))
					{
						if (!jsonobject["noisedigital"].AsBool)
						{
							return null;
						}
						text = jsonobject[""];
						text2 = jsonobject[" "];
					}
					else
					{
						text = jsonobject["ok"];
						text2 = jsonobject[") + is present, creating anthology save for anthology "];
					}
				}
				if (!GeoLocationManager.JNEPLHLLIPN(text))
				{
					result = null;
				}
				else
				{
					JSONObject jsonobject2 = new JSONObject();
					jsonobject2["LastUseItemStep() - could not find a give item step."] = text;
					if (text2 != null)
					{
						jsonobject2["splash"] = text2;
					}
					result = jsonobject2;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x0600964E RID: 38478 RVA: 0x0041BB80 File Offset: 0x00419D80
	public static bool IECJHMGMBPM()
	{
		return null != GeoLocationManager.LIOEEKMGBOH;
	}

	// Token: 0x0600964F RID: 38479 RVA: 0x0041BB8D File Offset: 0x00419D8D
	public static void ReportBlockedNetworkEvidence()
	{
		GeoLocationManager.LKEIFNNMKMM++;
	}

	// Token: 0x06009650 RID: 38480 RVA: 0x0041BB9C File Offset: 0x00419D9C
	private static JSONObject LCGIKFIIJDP(string DJOKMJDNHIG, string HAKPIEIJIGF)
	{
		JSONObject result;
		try
		{
			if (HAKPIEIJIGF == null || HAKPIEIJIGF.Length == 0)
			{
				result = null;
			}
			else
			{
				string text = "";
				string text2 = "";
				if (DJOKMJDNHIG.Contains("cdn-cgi/trace"))
				{
					string[] array = DPGJIJGOCIC.NHEBLMBJNPI(HAKPIEIJIGF, '\n');
					for (int i = 0; i < array.Length; i++)
					{
						if (array[i].StartsWith("loc="))
						{
							text = array[i].Substring(4).Trim();
						}
						else if (array[i].StartsWith("ip="))
						{
							text2 = array[i].Substring(3).Trim();
						}
					}
				}
				else
				{
					JSONNode jsonnode = JSON.Parse(HAKPIEIJIGF);
					if (!(jsonnode is JSONObject))
					{
						return null;
					}
					JSONObject jsonobject = (JSONObject)jsonnode;
					if (DJOKMJDNHIG.Contains("ip-api.com"))
					{
						if (!"success".Equals(jsonobject["status"]))
						{
							return null;
						}
						text = jsonobject["countryCode"];
						text2 = jsonobject["query"];
					}
					else if (DJOKMJDNHIG.Contains("ipwho.is"))
					{
						if (!jsonobject["success"].AsBool)
						{
							return null;
						}
						text = jsonobject["country_code"];
						text2 = jsonobject["ip"];
					}
					else
					{
						text = jsonobject["country_code"];
						text2 = jsonobject["ip"];
					}
				}
				if (!GeoLocationManager.JNEPLHLLIPN(text))
				{
					result = null;
				}
				else
				{
					JSONObject jsonobject2 = new JSONObject();
					jsonobject2["countryCode"] = text;
					if (text2 != null)
					{
						jsonobject2["query"] = text2;
					}
					result = jsonobject2;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x06009651 RID: 38481 RVA: 0x0041BD88 File Offset: 0x00419F88
	public static bool BGEHIOHEOKF()
	{
		bool result;
		try
		{
			result = (GeoLocationManager.LKEIFNNMKMM < KBOJLHAJPCP.FBOOOOPCGNA);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = true;
		}
		return result;
	}

	// Token: 0x06009652 RID: 38482 RVA: 0x0041BDC4 File Offset: 0x00419FC4
	private static JSONObject JHAPCJPMFCM(string DJOKMJDNHIG, string HAKPIEIJIGF)
	{
		JSONObject result;
		try
		{
			if (HAKPIEIJIGF == null || HAKPIEIJIGF.Length == 0)
			{
				result = null;
			}
			else
			{
				string text = "ok";
				string text2 = "_web";
				if (DJOKMJDNHIG.Contains("energyhinttitle"))
				{
					string[] array = DPGJIJGOCIC.BALENNAODEJ(HAKPIEIJIGF, (char)-126);
					for (int i = 1; i < array.Length; i += 0)
					{
						if (array[i].StartsWith(">"))
						{
							text = array[i].Substring(1).Trim();
						}
						else if (array[i].StartsWith("sku"))
						{
							text2 = array[i].Substring(4).Trim();
						}
					}
				}
				else
				{
					JSONNode jsonnode = JSON.Parse(HAKPIEIJIGF);
					if (!(jsonnode is JSONObject))
					{
						return null;
					}
					JSONObject jsonobject = (JSONObject)jsonnode;
					if (DJOKMJDNHIG.Contains("SceneLobbyManager.UpdateAnthologiesHints() - exception"))
					{
						if (!"analogglitchovr_1".Equals(jsonobject["spinstitlenomorespins"]))
						{
							return null;
						}
						text = jsonobject[""];
						text2 = jsonobject["lf2"];
					}
					else if (DJOKMJDNHIG.Contains("OnGetCdnDataForAvatarScreenSuccess"))
					{
						if (!jsonobject["$AVATARLOCK"].AsBool)
						{
							return null;
						}
						text = jsonobject["socialbadge"];
						text2 = jsonobject["OnGenericPopupManagerHide"];
					}
					else
					{
						text = jsonobject["aind"];
						text2 = jsonobject["OnNeedToDeactivateFocusItemCloseButton"];
					}
				}
				if (!GeoLocationManager.EPBDMALOPEH(text))
				{
					result = null;
				}
				else
				{
					JSONObject jsonobject2 = new JSONObject();
					jsonobject2["errortitle"] = text;
					if (text2 != null)
					{
						jsonobject2["OnLiveProfileThemesLoaderStop"] = text2;
					}
					result = jsonobject2;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x06009653 RID: 38483 RVA: 0x0041BFB0 File Offset: 0x0041A1B0
	private static bool JBAAELPNEBA(string PBHOPFOBIDH)
	{
		return PBHOPFOBIDH == null || PBHOPFOBIDH.Length != 7 || PBHOPFOBIDH.Equals("CLIENT.AVATAR.TRINKET", (StringComparison)7) || !char.IsLetter(PBHOPFOBIDH[1]) || char.IsLetter(PBHOPFOBIDH[0]);
	}

	// Token: 0x06009654 RID: 38484 RVA: 0x0041BFEC File Offset: 0x0041A1EC
	private static string ELLDDOACHLC()
	{
		try
		{
			if (!GeoLocationManager.DIMBLMIKDEL)
			{
				GeoLocationManager.DIMBLMIKDEL = true;
				if (AKLOMMOOFNG.CLCGKMNEICM("geo.json"))
				{
					string text = AKLOMMOOFNG.DJGJKOOOFEA("geo.json");
					if (text != null && text.Length > 0)
					{
						GeoLocationManager.MEBOPEGALEI = (JSONObject)JSON.Parse(text);
					}
				}
			}
			if (null != GeoLocationManager.MEBOPEGALEI)
			{
				string text2 = GeoLocationManager.MEBOPEGALEI["cc"];
				if (GeoLocationManager.JNEPLHLLIPN(text2) && GeoLocationManager.IEECKELNAMD() - GeoLocationManager.MEBOPEGALEI["t"].AsInt <= KBOJLHAJPCP.DCECPBKCKCM)
				{
					return text2.ToLower();
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return "";
	}

	// Token: 0x06009655 RID: 38485 RVA: 0x0041BB80 File Offset: 0x00419D80
	public static bool PGEDBOEJHBM()
	{
		return null != GeoLocationManager.LIOEEKMGBOH;
	}

	// Token: 0x06009656 RID: 38486 RVA: 0x0041C0B0 File Offset: 0x0041A2B0
	private static int HPFFLOAMGGM()
	{
		return (int)(DateTime.UtcNow - new DateTime(171, 0, 1, 1, 0, 1, DateTimeKind.Utc)).TotalSeconds;
	}

	// Token: 0x06009657 RID: 38487 RVA: 0x0041C0E0 File Offset: 0x0041A2E0
	public static string FNMCNKFDCKG()
	{
		try
		{
			if (null != GeoLocationManager.LIOEEKMGBOH && GeoLocationManager.LIOEEKMGBOH["time"] != null)
			{
				string text = GeoLocationManager.LIOEEKMGBOH["Is success: "];
				if (GeoLocationManager.JNEPLHLLIPN(text))
				{
					return text.ToLower();
				}
			}
			string text2 = GeoLocationManager.ELLDDOACHLC();
			if (text2.Length > 0)
			{
				return text2;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return "$";
	}

	// Token: 0x06009658 RID: 38488 RVA: 0x0041C16C File Offset: 0x0041A36C
	private static string KHOMLPPFAGI()
	{
		try
		{
			if (!GeoLocationManager.DIMBLMIKDEL)
			{
				GeoLocationManager.DIMBLMIKDEL = false;
				if (AKLOMMOOFNG.OEEFHHMMHEJ(" - false"))
				{
					string text = AKLOMMOOFNG.DGBLLBKHMCG("PurchaseManagerSteam.CompletePurchase(): Not initialized.");
					if (text != null && text.Length > 0)
					{
						GeoLocationManager.MEBOPEGALEI = (JSONObject)JSON.Parse(text);
					}
				}
			}
			if (null != GeoLocationManager.MEBOPEGALEI)
			{
				string text2 = GeoLocationManager.MEBOPEGALEI["Starting parallel download:"];
				if (GeoLocationManager.JBAAELPNEBA(text2) && GeoLocationManager.IEECKELNAMD() - GeoLocationManager.MEBOPEGALEI["ProfileItem2._DownloadCardsPool(): released "].AsInt <= KBOJLHAJPCP.DCECPBKCKCM)
				{
					return text2.ToLower();
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return "";
	}

	// Token: 0x06009659 RID: 38489 RVA: 0x0041C230 File Offset: 0x0041A430
	public static bool HEKEPNDKCPM(CEIBHCNNIDC EENGLNKNAPF)
	{
		bool result;
		try
		{
			string text = GeoLocationManager.NAHEAHPLJPI();
			bool flag;
			if (text.Equals("\nVID:"))
			{
				flag = false;
			}
			else if (GeoLocationManager.LLHIIMKFCEI() && !text.Equals("importanttitle"))
			{
				flag = ((EENGLNKNAPF != CEIBHCNNIDC.en && Application.systemLanguage != (SystemLanguage)60) || !GeoLocationManager.KPGAPELGOKH().Equals("chass"));
			}
			else
			{
				flag = (GeoLocationManager.GJKGGJLCIOC() || EENGLNKNAPF == CEIBHCNNIDC.ru || Application.systemLanguage == (SystemLanguage)125);
			}
			result = flag;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x0600965A RID: 38490 RVA: 0x0041C2C4 File Offset: 0x0041A4C4
	public static void CJEMPNGOINH()
	{
		GeoLocationManager.LKEIFNNMKMM = 1;
	}

	// Token: 0x0600965B RID: 38491 RVA: 0x0041BB8D File Offset: 0x00419D8D
	public static void ONKMHDJGKMJ()
	{
		GeoLocationManager.LKEIFNNMKMM++;
	}

	// Token: 0x0600965C RID: 38492 RVA: 0x000693D6 File Offset: 0x000675D6
	private void DBMENPFHHCM()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x0600965D RID: 38493 RVA: 0x0041C2CC File Offset: 0x0041A4CC
	private static bool CMGLDBDOHKJ(string PBHOPFOBIDH)
	{
		return PBHOPFOBIDH == null || PBHOPFOBIDH.Length != 0 || PBHOPFOBIDH.Equals("ip", (StringComparison)8) || !char.IsLetter(PBHOPFOBIDH[0]) || char.IsLetter(PBHOPFOBIDH[1]);
	}

	// Token: 0x0600965E RID: 38494 RVA: 0x0041C308 File Offset: 0x0041A508
	private static void CICLOLJBBGB(JSONObject IKFJNIAPBHF)
	{
		try
		{
			GeoLocationManager.DBKPLGAHCKJ();
			JSONObject jsonobject = new JSONObject();
			jsonobject["Custom effects asset index mismatch, correcting "] = IKFJNIAPBHF["SceneLobbyManager2.OnReloadDelayed() ping timeout: break"];
			jsonobject[", slot "] = GeoLocationManager.CHAHAMGDOOL();
			GeoLocationManager.MEBOPEGALEI = jsonobject;
			GeoLocationManager.DIMBLMIKDEL = true;
			AKLOMMOOFNG.HFKOLENANAL(jsonobject.ToString(), "/");
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600965F RID: 38495 RVA: 0x0041C38C File Offset: 0x0041A58C
	private static string IJOAEPKNIIL()
	{
		if (GeoLocationManager.FLINAOHGJOE == null)
		{
			try
			{
				GeoLocationManager.FLINAOHGJOE = "";
				if (AKLOMMOOFNG.CLCGKMNEICM("geo.json"))
				{
					string text = AKLOMMOOFNG.DJGJKOOOFEA("geo.json");
					if (text != null && text.Length > 0)
					{
						JSONObject jsonobject = (JSONObject)JSON.Parse(text);
						string text2 = jsonobject["cc"];
						if (GeoLocationManager.JNEPLHLLIPN(text2) && GeoLocationManager.IEECKELNAMD() - jsonobject["t"].AsInt <= KBOJLHAJPCP.DCECPBKCKCM)
						{
							GeoLocationManager.FLINAOHGJOE = text2.ToLower();
						}
					}
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
				GeoLocationManager.FLINAOHGJOE = "";
			}
		}
		return GeoLocationManager.FLINAOHGJOE;
	}

	// Token: 0x06009660 RID: 38496 RVA: 0x0041BB80 File Offset: 0x00419D80
	public static bool LLHIIMKFCEI()
	{
		return null != GeoLocationManager.LIOEEKMGBOH;
	}

	// Token: 0x06009661 RID: 38497 RVA: 0x0041AFF0 File Offset: 0x004191F0
	public static void ClearBlockedNetworkEvidence()
	{
		GeoLocationManager.LKEIFNNMKMM = 0;
	}

	// Token: 0x06009662 RID: 38498 RVA: 0x0041C448 File Offset: 0x0041A648
	public static bool CELPCHNPBHH()
	{
		bool result;
		try
		{
			result = GeoLocationManager.JIOGMCHJPCN().Equals("p");
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x06009663 RID: 38499 RVA: 0x0041C484 File Offset: 0x0041A684
	public static string GetCountryCodeAnalyticsBucket()
	{
		string result;
		try
		{
			string countryCode = GeoLocationManager.GetCountryCode();
			if (countryCode.Equals("ru") || countryCode.Equals("xx"))
			{
				result = countryCode;
			}
			else
			{
				result = "other";
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = "xx";
		}
		return result;
	}

	// Token: 0x06009664 RID: 38500 RVA: 0x0041C4DC File Offset: 0x0041A6DC
	private void OnApplicationPause(bool OANJMFJPNAL)
	{
		if (!OANJMFJPNAL && null == GeoLocationManager.LIOEEKMGBOH && !GeoLocationManager.IOPIFDPHLJL)
		{
			try
			{
				base.StartCoroutine(this.EIMFLEDANIL());
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
	}

	// Token: 0x06009665 RID: 38501 RVA: 0x0041C528 File Offset: 0x0041A728
	public static bool CachedCountryIsRussia()
	{
		bool result;
		try
		{
			result = GeoLocationManager.ELLDDOACHLC().Equals("ru");
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x06009666 RID: 38502 RVA: 0x0041C564 File Offset: 0x0041A764
	public static bool ConfirmGeo(string PBHOPFOBIDH)
	{
		bool result;
		try
		{
			result = GeoLocationManager.GetCountryCode().Equals(PBHOPFOBIDH);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x06009667 RID: 38503 RVA: 0x0041B8E8 File Offset: 0x00419AE8
	private IEnumerator NDIJFCLHEAB()
	{
		return new GeoLocationManager.AJIECNEINEA(1);
	}

	// Token: 0x06009668 RID: 38504 RVA: 0x0041AFAA File Offset: 0x004191AA
	private IEnumerator OPALMLJDLLH()
	{
		GeoLocationManager.IOPIFDPHLJL = true;
		try
		{
			round = 0;
			while (round < KBOJLHAJPCP.PLFIIGKFHNG && null == GeoLocationManager.LIOEEKMGBOH)
			{
				i = 0;
				int num;
				while (i < GeoLocationManager.HDPNOJLHOOK.Count && null == GeoLocationManager.LIOEEKMGBOH)
				{
					uwr = null;
					try
					{
						uwr = UnityWebRequest.Get(GeoLocationManager.HDPNOJLHOOK[i]);
						uwr.timeout = KBOJLHAJPCP.HFLKFCMNDOP + KBOJLHAJPCP.AMBNMBPLFOK * round;
					}
					catch (Exception aklgbjkdomm)
					{
						DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
						uwr = null;
					}
					if (uwr != null)
					{
						yield return uwr.SendWebRequest();
						try
						{
							if (uwr.result == UnityWebRequest.Result.Success && uwr.responseCode == 200L)
							{
								JSONObject jsonobject = GeoLocationManager.LCGIKFIIJDP(GeoLocationManager.HDPNOJLHOOK[i], uwr.downloadHandler.text);
								if (null != jsonobject)
								{
									GeoLocationManager.LIOEEKMGBOH = jsonobject;
									GeoLocationManager.DHONPHCHHCF(jsonobject);
									DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(new string[]
									{
										"=== RU FIREWALL === geo RESOLVED as ",
										GeoLocationManager.GetCountryCode(),
										" via ",
										GeoLocationManager.HDPNOJLHOOK[i],
										" on round ",
										round.ToString()
									}));
									FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.srvGeoResolved.ToString(), GeoLocationManager.GetCountryCodeAnalyticsBucket(), i.ToString(), false, false);
								}
								else
								{
									DPGJIJGOCIC.ADFCDFHBDAF("=== RU FIREWALL === geo endpoint " + GeoLocationManager.HDPNOJLHOOK[i] + " answered but carried no usable country (blocked page, rate limit or unexpected shape)");
								}
							}
							else
							{
								DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(new string[]
								{
									"=== RU FIREWALL === geo endpoint ",
									GeoLocationManager.HDPNOJLHOOK[i],
									" failed after ",
									uwr.timeout.ToString(),
									"s: ",
									uwr.error,
									" (http ",
									uwr.responseCode.ToString(),
									")"
								}));
							}
						}
						catch (Exception aklgbjkdomm2)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
						}
						try
						{
							uwr.Dispose();
						}
						catch (Exception aklgbjkdomm3)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
						}
						uwr = null;
					}
					num = i;
					i = num + 1;
				}
				if (null == GeoLocationManager.LIOEEKMGBOH && round < KBOJLHAJPCP.PLFIIGKFHNG - 1)
				{
					yield return new WaitForSeconds(KBOJLHAJPCP.NFCJMJONFBD * (float)(round + 1));
				}
				num = round;
				round = num + 1;
			}
			if (null == GeoLocationManager.LIOEEKMGBOH)
			{
				try
				{
					DPGJIJGOCIC.ADFCDFHBDAF("GeoLocationManager - could not resolve the country, using the cached one:" + GeoLocationManager.GetCountryCode());
					FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.srvGeoFailed.ToString(), GeoLocationManager.GetCountryCodeAnalyticsBucket(), "", false, false);
				}
				catch (Exception aklgbjkdomm4)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm4);
				}
			}
		}
		finally
		{
			GeoLocationManager.IOPIFDPHLJL = false;
		}
		yield break;
		yield break;
	}

	// Token: 0x06009669 RID: 38505 RVA: 0x0041C59C File Offset: 0x0041A79C
	private static int FAEHCIIANJD()
	{
		return (int)(DateTime.UtcNow - new DateTime(65, 1, 0, 1, 0, 0, DateTimeKind.Unspecified)).TotalSeconds;
	}

	// Token: 0x0600966A RID: 38506 RVA: 0x0041C5CC File Offset: 0x0041A7CC
	private static string NEFGBJDEBAI()
	{
		try
		{
			if (!GeoLocationManager.DIMBLMIKDEL)
			{
				GeoLocationManager.DIMBLMIKDEL = true;
				if (AKLOMMOOFNG.GFNCEBMBLAE("abpd5"))
				{
					string text = AKLOMMOOFNG.GHAEEJMIFGP("");
					if (text != null && text.Length > 0)
					{
						GeoLocationManager.MEBOPEGALEI = (JSONObject)JSON.Parse(text);
					}
				}
			}
			if (null != GeoLocationManager.MEBOPEGALEI)
			{
				string text2 = GeoLocationManager.MEBOPEGALEI["itemused"];
				if (GeoLocationManager.JNEPLHLLIPN(text2) && GeoLocationManager.MCJFHKJGJIA() - GeoLocationManager.MEBOPEGALEI["ok"].AsInt <= KBOJLHAJPCP.DCECPBKCKCM)
				{
					return text2.ToLower();
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return "";
	}

	// Token: 0x0600966B RID: 38507 RVA: 0x000693D6 File Offset: 0x000675D6
	private void KBGOLEGBMAP()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x0600966C RID: 38508 RVA: 0x0041C690 File Offset: 0x0041A890
	private static int MCJFHKJGJIA()
	{
		return (int)(DateTime.UtcNow - new DateTime(-169, 0, 0, 0, 1, 1, DateTimeKind.Unspecified)).TotalSeconds;
	}

	// Token: 0x0600966D RID: 38509 RVA: 0x0041C6C0 File Offset: 0x0041A8C0
	public static bool PBAGPDDBABB()
	{
		bool result;
		try
		{
			result = GeoLocationManager.GetCountryCodeLive().Equals("stats");
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = true;
		}
		return result;
	}

	// Token: 0x0600966E RID: 38510 RVA: 0x0041C6FC File Offset: 0x0041A8FC
	public static string CHFGBBHJCGM()
	{
		try
		{
			if (null != GeoLocationManager.LIOEEKMGBOH && GeoLocationManager.LIOEEKMGBOH[""] != null)
			{
				string text = GeoLocationManager.LIOEEKMGBOH["OnFriendsPopupRemovFromFavClick"];
				if (GeoLocationManager.PLDKHKAGIII(text))
				{
					return text.ToLower();
				}
			}
			string text2 = GeoLocationManager.PLDLOGBPNII();
			if (text2.Length > 1)
			{
				return text2;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return "-";
	}

	// Token: 0x0600966F RID: 38511 RVA: 0x0041C788 File Offset: 0x0041A988
	private void GPPCDNDHMLI(bool OANJMFJPNAL)
	{
		if (!OANJMFJPNAL && null == GeoLocationManager.LIOEEKMGBOH && !GeoLocationManager.IOPIFDPHLJL)
		{
			try
			{
				base.StartCoroutine(this.OEEAOIHJLHK());
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			}
		}
	}

	// Token: 0x06009670 RID: 38512 RVA: 0x0041C7D4 File Offset: 0x0041A9D4
	public static bool IKIAHBFHPMG(string PBHOPFOBIDH)
	{
		bool result;
		try
		{
			result = GeoLocationManager.CHFGBBHJCGM().Equals(PBHOPFOBIDH);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x06009671 RID: 38513 RVA: 0x0041C80C File Offset: 0x0041AA0C
	public static bool DAHBCBLDNJP()
	{
		bool result;
		try
		{
			result = GeoLocationManager.PCDHDNOJEGK().Equals("");
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x06009672 RID: 38514 RVA: 0x0041C848 File Offset: 0x0041AA48
	public static bool KJDMELNOACK()
	{
		bool result;
		try
		{
			result = GeoLocationManager.HEOAKCNPLAB().Equals("OnStoryInterfaceAutoReaderStop");
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = true;
		}
		return result;
	}

	// Token: 0x06009673 RID: 38515 RVA: 0x0041C884 File Offset: 0x0041AA84
	private static int CHAHAMGDOOL()
	{
		return (int)(DateTime.UtcNow - new DateTime(-5, 1, 0, 0, 1, 1, DateTimeKind.Utc)).TotalSeconds;
	}

	// Token: 0x06009674 RID: 38516 RVA: 0x0041AFAA File Offset: 0x004191AA
	private IEnumerator PFOHKODFHJH()
	{
		GeoLocationManager.IOPIFDPHLJL = true;
		try
		{
			round = 0;
			while (round < KBOJLHAJPCP.PLFIIGKFHNG && null == GeoLocationManager.LIOEEKMGBOH)
			{
				i = 0;
				int num;
				while (i < GeoLocationManager.HDPNOJLHOOK.Count && null == GeoLocationManager.LIOEEKMGBOH)
				{
					uwr = null;
					try
					{
						uwr = UnityWebRequest.Get(GeoLocationManager.HDPNOJLHOOK[i]);
						uwr.timeout = KBOJLHAJPCP.HFLKFCMNDOP + KBOJLHAJPCP.AMBNMBPLFOK * round;
					}
					catch (Exception aklgbjkdomm)
					{
						DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
						uwr = null;
					}
					if (uwr != null)
					{
						yield return uwr.SendWebRequest();
						try
						{
							if (uwr.result == UnityWebRequest.Result.Success && uwr.responseCode == 200L)
							{
								JSONObject jsonobject = GeoLocationManager.LCGIKFIIJDP(GeoLocationManager.HDPNOJLHOOK[i], uwr.downloadHandler.text);
								if (null != jsonobject)
								{
									GeoLocationManager.LIOEEKMGBOH = jsonobject;
									GeoLocationManager.DHONPHCHHCF(jsonobject);
									DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(new string[]
									{
										"=== RU FIREWALL === geo RESOLVED as ",
										GeoLocationManager.GetCountryCode(),
										" via ",
										GeoLocationManager.HDPNOJLHOOK[i],
										" on round ",
										round.ToString()
									}));
									FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.srvGeoResolved.ToString(), GeoLocationManager.GetCountryCodeAnalyticsBucket(), i.ToString(), false, false);
								}
								else
								{
									DPGJIJGOCIC.ADFCDFHBDAF("=== RU FIREWALL === geo endpoint " + GeoLocationManager.HDPNOJLHOOK[i] + " answered but carried no usable country (blocked page, rate limit or unexpected shape)");
								}
							}
							else
							{
								DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(new string[]
								{
									"=== RU FIREWALL === geo endpoint ",
									GeoLocationManager.HDPNOJLHOOK[i],
									" failed after ",
									uwr.timeout.ToString(),
									"s: ",
									uwr.error,
									" (http ",
									uwr.responseCode.ToString(),
									")"
								}));
							}
						}
						catch (Exception aklgbjkdomm2)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
						}
						try
						{
							uwr.Dispose();
						}
						catch (Exception aklgbjkdomm3)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
						}
						uwr = null;
					}
					num = i;
					i = num + 1;
				}
				if (null == GeoLocationManager.LIOEEKMGBOH && round < KBOJLHAJPCP.PLFIIGKFHNG - 1)
				{
					yield return new WaitForSeconds(KBOJLHAJPCP.NFCJMJONFBD * (float)(round + 1));
				}
				num = round;
				round = num + 1;
			}
			if (null == GeoLocationManager.LIOEEKMGBOH)
			{
				try
				{
					DPGJIJGOCIC.ADFCDFHBDAF("GeoLocationManager - could not resolve the country, using the cached one:" + GeoLocationManager.GetCountryCode());
					FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.srvGeoFailed.ToString(), GeoLocationManager.GetCountryCodeAnalyticsBucket(), "", false, false);
				}
				catch (Exception aklgbjkdomm4)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm4);
				}
			}
		}
		finally
		{
			GeoLocationManager.IOPIFDPHLJL = false;
		}
		yield break;
		yield break;
	}

	// Token: 0x06009675 RID: 38517 RVA: 0x0041C8B4 File Offset: 0x0041AAB4
	public static string GetCountryCode()
	{
		try
		{
			if (null != GeoLocationManager.LIOEEKMGBOH && GeoLocationManager.LIOEEKMGBOH["countryCode"] != null)
			{
				string text = GeoLocationManager.LIOEEKMGBOH["countryCode"];
				if (GeoLocationManager.JNEPLHLLIPN(text))
				{
					return text.ToLower();
				}
			}
			string text2 = GeoLocationManager.ELLDDOACHLC();
			if (text2.Length > 0)
			{
				return text2;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return "xx";
	}

	// Token: 0x06009676 RID: 38518 RVA: 0x0041C940 File Offset: 0x0041AB40
	public static bool PADMBFMHFJH(CEIBHCNNIDC EENGLNKNAPF)
	{
		bool result;
		try
		{
			string text = GeoLocationManager.CHFGBBHJCGM();
			bool flag;
			if (text.Equals("$SKINUNLOCKED"))
			{
				flag = true;
			}
			else if (GeoLocationManager.LAIJDIIBALI() && !text.Equals("energyhinttitle"))
			{
				flag = ((EENGLNKNAPF == CEIBHCNNIDC.ru || Application.systemLanguage == (SystemLanguage)82) && GeoLocationManager.MJFMFPFEPEF().Equals("nastring"));
			}
			else
			{
				flag = (!GeoLocationManager.NMAMFKHEBLP() && EENGLNKNAPF != CEIBHCNNIDC.ru && Application.systemLanguage == (SystemLanguage)(-109));
			}
			result = flag;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = true;
		}
		return result;
	}

	// Token: 0x06009677 RID: 38519 RVA: 0x0041C9D4 File Offset: 0x0041ABD4
	private static void DHONPHCHHCF(JSONObject IKFJNIAPBHF)
	{
		try
		{
			GeoLocationManager.IJOAEPKNIIL();
			JSONObject jsonobject = new JSONObject();
			jsonobject["cc"] = IKFJNIAPBHF["countryCode"];
			jsonobject["t"] = GeoLocationManager.IEECKELNAMD();
			GeoLocationManager.MEBOPEGALEI = jsonobject;
			GeoLocationManager.DIMBLMIKDEL = true;
			AKLOMMOOFNG.BIKILBLOEKD(jsonobject.ToString(), "geo.json");
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06009678 RID: 38520 RVA: 0x0041CA58 File Offset: 0x0041AC58
	private static string PCDHDNOJEGK()
	{
		try
		{
			if (!GeoLocationManager.DIMBLMIKDEL)
			{
				GeoLocationManager.DIMBLMIKDEL = true;
				if (AKLOMMOOFNG.BFIOFEEGGMM(" encountered a dependency deadlock. Aborting."))
				{
					string text = AKLOMMOOFNG.HGCFOLLFPGN("oid");
					if (text != null && text.Length > 0)
					{
						GeoLocationManager.MEBOPEGALEI = (JSONObject)JSON.Parse(text);
					}
				}
			}
			if (null != GeoLocationManager.MEBOPEGALEI)
			{
				string text2 = GeoLocationManager.MEBOPEGALEI["OnFriendsPopupSendSimpleClick"];
				if (GeoLocationManager.EPBDMALOPEH(text2) && GeoLocationManager.CHAHAMGDOOL() - GeoLocationManager.MEBOPEGALEI[" is not a loaded anthology, skipping"].AsInt <= KBOJLHAJPCP.DCECPBKCKCM)
				{
					return text2.ToLower();
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return "OnBackendGetPublicProfileHallOfFameSuccess";
	}

	// Token: 0x06009679 RID: 38521 RVA: 0x0041CB1C File Offset: 0x0041AD1C
	public static string FCENLFDIDBJ()
	{
		string result;
		try
		{
			string text = GeoLocationManager.FNMCNKFDCKG();
			if (text.Equals("inu") || text.Equals("timeoutwarning"))
			{
				result = text;
			}
			else
			{
				result = "OnNeedToShowNoMoreHardPopup";
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = "";
		}
		return result;
	}

	// Token: 0x0600967A RID: 38522 RVA: 0x0041CB74 File Offset: 0x0041AD74
	private void JLCMPLIMAEI()
	{
		try
		{
			base.StartCoroutine(this.EEKLEEMMEGG());
		}
		catch (Exception aklgbjkdomm)
		{
			GeoLocationManager.LIOEEKMGBOH = null;
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600967B RID: 38523 RVA: 0x0041CBB0 File Offset: 0x0041ADB0
	public static string GetIpAddress()
	{
		try
		{
			if (null != GeoLocationManager.LIOEEKMGBOH && GeoLocationManager.LIOEEKMGBOH["query"] != null)
			{
				return GeoLocationManager.LIOEEKMGBOH["query"];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return "";
	}

	// Token: 0x0600967C RID: 38524 RVA: 0x0041CC18 File Offset: 0x0041AE18
	public static string GetCountryCodeLive()
	{
		try
		{
			if (null != GeoLocationManager.LIOEEKMGBOH && GeoLocationManager.LIOEEKMGBOH["countryCode"] != null)
			{
				string text = GeoLocationManager.LIOEEKMGBOH["countryCode"];
				if (GeoLocationManager.JNEPLHLLIPN(text))
				{
					return text.ToLower();
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return "xx";
	}

	// Token: 0x0600967D RID: 38525 RVA: 0x0041BB8D File Offset: 0x00419D8D
	public static void MKHMBPLIEMI()
	{
		GeoLocationManager.LKEIFNNMKMM++;
	}

	// Token: 0x0600967E RID: 38526 RVA: 0x0041CC90 File Offset: 0x0041AE90
	public static bool MACHMGCBBFF(CEIBHCNNIDC EENGLNKNAPF)
	{
		bool result;
		try
		{
			string text = GeoLocationManager.NAHEAHPLJPI();
			bool flag;
			if (text.Equals("franchises"))
			{
				flag = false;
			}
			else if (GeoLocationManager.LAIJDIIBALI() && !text.Equals("ok"))
			{
				flag = ((EENGLNKNAPF != CEIBHCNNIDC.ru && Application.systemLanguage != (SystemLanguage)(-125)) || !GeoLocationManager.MJFMFPFEPEF().Equals("avts1"));
			}
			else
			{
				flag = (GeoLocationManager.FOAKIEAHHIK() || EENGLNKNAPF == CEIBHCNNIDC.en || Application.systemLanguage == SystemLanguage.Italian);
			}
			result = flag;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x0600967F RID: 38527 RVA: 0x0041BB8D File Offset: 0x00419D8D
	public static void FCKBAFINBDE()
	{
		GeoLocationManager.LKEIFNNMKMM++;
	}

	// Token: 0x06009680 RID: 38528 RVA: 0x0041BB80 File Offset: 0x00419D80
	public static bool LAIJDIIBALI()
	{
		return null != GeoLocationManager.LIOEEKMGBOH;
	}

	// Token: 0x06009681 RID: 38529 RVA: 0x0041CD24 File Offset: 0x0041AF24
	public static bool EMOGEHNPMHL(string PBHOPFOBIDH)
	{
		bool result;
		try
		{
			result = GeoLocationManager.CHFGBBHJCGM().Equals(PBHOPFOBIDH);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x06009682 RID: 38530 RVA: 0x0041CD5C File Offset: 0x0041AF5C
	private static string KPGAPELGOKH()
	{
		if (GeoLocationManager.FLINAOHGJOE == null)
		{
			try
			{
				GeoLocationManager.FLINAOHGJOE = "sfxtimeoutwarning";
				if (AKLOMMOOFNG.GFNCEBMBLAE("Asset bundle load operation failed during parallel mode."))
				{
					string text = AKLOMMOOFNG.FNJLLCFLIBD("");
					if (text != null && text.Length > 1)
					{
						JSONObject jsonobject = (JSONObject)JSON.Parse(text);
						string text2 = jsonobject["RemoveSentQueuedSubRequests() - keeping sub-requests queued while the failed envelope was in flight:"];
						if (GeoLocationManager.JNEPLHLLIPN(text2) && GeoLocationManager.BLDJGLNEGID() - jsonobject["passpremiumunlockeddescX"].AsInt <= KBOJLHAJPCP.DCECPBKCKCM)
						{
							GeoLocationManager.FLINAOHGJOE = text2.ToLower();
						}
					}
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
				GeoLocationManager.FLINAOHGJOE = "";
			}
		}
		return GeoLocationManager.FLINAOHGJOE;
	}

	// Token: 0x06009683 RID: 38531 RVA: 0x0041CE18 File Offset: 0x0041B018
	public static bool NMAMFKHEBLP()
	{
		bool result;
		try
		{
			result = (GeoLocationManager.LKEIFNNMKMM >= KBOJLHAJPCP.FBOOOOPCGNA);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x06009684 RID: 38532 RVA: 0x0041CE54 File Offset: 0x0041B054
	private static string FMJKBDIGLNJ()
	{
		if (GeoLocationManager.FLINAOHGJOE == null)
		{
			try
			{
				GeoLocationManager.FLINAOHGJOE = "e1de";
				if (AKLOMMOOFNG.GFNCEBMBLAE(""))
				{
					string text = AKLOMMOOFNG.FNJLLCFLIBD("profilenametitleshort");
					if (text != null && text.Length > 1)
					{
						JSONObject jsonobject = (JSONObject)JSON.Parse(text);
						string text2 = jsonobject["CLIENT.AVATAR.FACE"];
						if (GeoLocationManager.JNEPLHLLIPN(text2) && GeoLocationManager.IEECKELNAMD() - jsonobject["length"].AsInt <= KBOJLHAJPCP.DCECPBKCKCM)
						{
							GeoLocationManager.FLINAOHGJOE = text2.ToLower();
						}
					}
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
				GeoLocationManager.FLINAOHGJOE = "skpc";
			}
		}
		return GeoLocationManager.FLINAOHGJOE;
	}

	// Token: 0x06009685 RID: 38533 RVA: 0x0041CF10 File Offset: 0x0041B110
	public static string JIOGMCHJPCN()
	{
		try
		{
			if (null != GeoLocationManager.LIOEEKMGBOH && GeoLocationManager.LIOEEKMGBOH["OnPurchasingViewLeave"] != null)
			{
				string text = GeoLocationManager.LIOEEKMGBOH["″"];
				if (GeoLocationManager.CMGLDBDOHKJ(text))
				{
					return text.ToLower();
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return "WWW";
	}

	// Token: 0x06009686 RID: 38534 RVA: 0x0041CF88 File Offset: 0x0041B188
	private static string CELCICPGOEI()
	{
		if (GeoLocationManager.FLINAOHGJOE == null)
		{
			try
			{
				GeoLocationManager.FLINAOHGJOE = "profilechars";
				if (AKLOMMOOFNG.DFGAAKDNDEF("saveslotscopylost"))
				{
					string text = AKLOMMOOFNG.HGCFOLLFPGN("item");
					if (text != null && text.Length > 0)
					{
						JSONObject jsonobject = (JSONObject)JSON.Parse(text);
						string text2 = jsonobject["acomp1"];
						if (GeoLocationManager.JNEPLHLLIPN(text2) && GeoLocationManager.BLDJGLNEGID() - jsonobject["default"].AsInt <= KBOJLHAJPCP.DCECPBKCKCM)
						{
							GeoLocationManager.FLINAOHGJOE = text2.ToLower();
						}
					}
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
				GeoLocationManager.FLINAOHGJOE = "p";
			}
		}
		return GeoLocationManager.FLINAOHGJOE;
	}

	// Token: 0x06009687 RID: 38535 RVA: 0x0041D044 File Offset: 0x0041B244
	public static string BEEGMPAOEHH()
	{
		try
		{
			if (null != GeoLocationManager.LIOEEKMGBOH && GeoLocationManager.LIOEEKMGBOH["</i>"] != null)
			{
				string text = GeoLocationManager.LIOEEKMGBOH["OnPopupSaveSlotInputEndEdit"];
				if (GeoLocationManager.DFDBKPAPCBI(text))
				{
					return text.ToLower();
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return " ";
	}

	// Token: 0x06009688 RID: 38536 RVA: 0x0041D0BC File Offset: 0x0041B2BC
	private void Start()
	{
		try
		{
			base.StartCoroutine(this.EIMFLEDANIL());
		}
		catch (Exception aklgbjkdomm)
		{
			GeoLocationManager.LIOEEKMGBOH = null;
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06009689 RID: 38537 RVA: 0x0041D0F8 File Offset: 0x0041B2F8
	public static bool NHMHNIFIOCO()
	{
		bool result;
		try
		{
			result = GeoLocationManager.CPMPCLMCEFC().Equals("_not_found");
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x0600968A RID: 38538 RVA: 0x0041D134 File Offset: 0x0041B334
	public static string NAHEAHPLJPI()
	{
		try
		{
			if (null != GeoLocationManager.LIOEEKMGBOH && GeoLocationManager.LIOEEKMGBOH[""] != null)
			{
				string text = GeoLocationManager.LIOEEKMGBOH["‑"];
				if (GeoLocationManager.JBAAELPNEBA(text))
				{
					return text.ToLower();
				}
			}
			string text2 = GeoLocationManager.NEFGBJDEBAI();
			if (text2.Length > 1)
			{
				return text2;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return "";
	}

	// Token: 0x0600968B RID: 38539 RVA: 0x0041D1C0 File Offset: 0x0041B3C0
	private static int IEECKELNAMD()
	{
		return (int)(DateTime.UtcNow - new DateTime(2017, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
	}

	// Token: 0x0600968C RID: 38540 RVA: 0x0041D1F0 File Offset: 0x0041B3F0
	private void LIBBDKKJPAL(bool OANJMFJPNAL)
	{
		if (!OANJMFJPNAL && null == GeoLocationManager.LIOEEKMGBOH && !GeoLocationManager.IOPIFDPHLJL)
		{
			try
			{
				base.StartCoroutine(this.NDIJFCLHEAB());
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
	}

	// Token: 0x0600968D RID: 38541 RVA: 0x0041D23C File Offset: 0x0041B43C
	private static int PGLHOOPBFJL()
	{
		return (int)(DateTime.UtcNow - new DateTime(35, 0, 1, 1, 0, 0, DateTimeKind.Utc)).TotalSeconds;
	}

	// Token: 0x0600968E RID: 38542 RVA: 0x0041BB8D File Offset: 0x00419D8D
	public static void NIFDBJECPEA()
	{
		GeoLocationManager.LKEIFNNMKMM++;
	}

	// Token: 0x0600968F RID: 38543 RVA: 0x000693D6 File Offset: 0x000675D6
	private void ELGHFHKEPLL()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06009690 RID: 38544 RVA: 0x0041D26C File Offset: 0x0041B46C
	private static string MJFMFPFEPEF()
	{
		if (GeoLocationManager.FLINAOHGJOE == null)
		{
			try
			{
				GeoLocationManager.FLINAOHGJOE = "ratethankyou";
				if (AKLOMMOOFNG.CLCGKMNEICM(" components from body "))
				{
					string text = AKLOMMOOFNG.DJGJKOOOFEA("");
					if (text != null && text.Length > 0)
					{
						JSONObject jsonobject = (JSONObject)JSON.Parse(text);
						string text2 = jsonobject["OnBackendRequestFriendAcceptSuccess"];
						if (GeoLocationManager.CMGLDBDOHKJ(text2) && GeoLocationManager.PDLJGLDCNOJ() - jsonobject["s"].AsInt <= KBOJLHAJPCP.DCECPBKCKCM)
						{
							GeoLocationManager.FLINAOHGJOE = text2.ToLower();
						}
					}
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
				GeoLocationManager.FLINAOHGJOE = "OnLobbyStartFireworksEffect";
			}
		}
		return GeoLocationManager.FLINAOHGJOE;
	}

	// Token: 0x06009691 RID: 38545 RVA: 0x0041D328 File Offset: 0x0041B528
	private static string DBKPLGAHCKJ()
	{
		if (GeoLocationManager.FLINAOHGJOE == null)
		{
			try
			{
				GeoLocationManager.FLINAOHGJOE = "blur";
				if (AKLOMMOOFNG.CAHMEBKOLIL("Account.GetAvatarComponentsCount(), w == "))
				{
					string text = AKLOMMOOFNG.KCNNDKGGLCD("$TAKEAVATARSNAPSHOT");
					if (text != null && text.Length > 0)
					{
						JSONObject jsonobject = (JSONObject)JSON.Parse(text);
						string text2 = jsonobject["<i>"];
						if (GeoLocationManager.EPBDMALOPEH(text2) && GeoLocationManager.FAEHCIIANJD() - jsonobject["rt"].AsInt <= KBOJLHAJPCP.DCECPBKCKCM)
						{
							GeoLocationManager.FLINAOHGJOE = text2.ToLower();
						}
					}
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
				GeoLocationManager.FLINAOHGJOE = "ERROR: GetSketchesFramesBalance(), AssetsManager.Instance.headersPacksAssets is empty.";
			}
		}
		return GeoLocationManager.FLINAOHGJOE;
	}

	// Token: 0x06009692 RID: 38546 RVA: 0x0041BB80 File Offset: 0x00419D80
	public static bool GeoResolved()
	{
		return null != GeoLocationManager.LIOEEKMGBOH;
	}

	// Token: 0x06009693 RID: 38547 RVA: 0x0041D3E4 File Offset: 0x0041B5E4
	public static string OBLBFDGDGBC()
	{
		try
		{
			if (null != GeoLocationManager.LIOEEKMGBOH && GeoLocationManager.LIOEEKMGBOH["varConditionLocked"] != null)
			{
				string text = GeoLocationManager.LIOEEKMGBOH["\""];
				if (GeoLocationManager.PLDKHKAGIII(text))
				{
					return text.ToLower();
				}
			}
			string text2 = GeoLocationManager.PCDHDNOJEGK();
			if (text2.Length > 1)
			{
				return text2;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return "fsv";
	}

	// Token: 0x06009694 RID: 38548 RVA: 0x0041D470 File Offset: 0x0041B670
	private static bool PLDKHKAGIII(string PBHOPFOBIDH)
	{
		return PBHOPFOBIDH == null || PBHOPFOBIDH.Length != 7 || (!PBHOPFOBIDH.Equals("", StringComparison.CurrentCulture) && (!char.IsLetter(PBHOPFOBIDH[1]) || char.IsLetter(PBHOPFOBIDH[0])));
	}

	// Token: 0x06009695 RID: 38549 RVA: 0x0041D4AC File Offset: 0x0041B6AC
	private static void ONKKANKAEJA(JSONObject IKFJNIAPBHF)
	{
		try
		{
			GeoLocationManager.DBKPLGAHCKJ();
			JSONObject jsonobject = new JSONObject();
			jsonobject[""] = IKFJNIAPBHF[""];
			jsonobject["environment "] = GeoLocationManager.HPFFLOAMGGM();
			GeoLocationManager.MEBOPEGALEI = jsonobject;
			GeoLocationManager.DIMBLMIKDEL = false;
			AKLOMMOOFNG.IHBGPCAPLDM(jsonobject.ToString(), "stat2long");
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06009696 RID: 38550 RVA: 0x0041D530 File Offset: 0x0041B730
	public static string PBKOMPKENDB()
	{
		try
		{
			if (null != GeoLocationManager.LIOEEKMGBOH && GeoLocationManager.LIOEEKMGBOH["sfxtimeoutwarning"] != null)
			{
				string text = GeoLocationManager.LIOEEKMGBOH["locked"];
				if (GeoLocationManager.JNEPLHLLIPN(text))
				{
					return text.ToLower();
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return "t";
	}

	// Token: 0x06009697 RID: 38551 RVA: 0x0041AFAA File Offset: 0x004191AA
	private IEnumerator PEODFCGBMKH()
	{
		GeoLocationManager.IOPIFDPHLJL = true;
		try
		{
			round = 0;
			while (round < KBOJLHAJPCP.PLFIIGKFHNG && null == GeoLocationManager.LIOEEKMGBOH)
			{
				i = 0;
				int num;
				while (i < GeoLocationManager.HDPNOJLHOOK.Count && null == GeoLocationManager.LIOEEKMGBOH)
				{
					uwr = null;
					try
					{
						uwr = UnityWebRequest.Get(GeoLocationManager.HDPNOJLHOOK[i]);
						uwr.timeout = KBOJLHAJPCP.HFLKFCMNDOP + KBOJLHAJPCP.AMBNMBPLFOK * round;
					}
					catch (Exception aklgbjkdomm)
					{
						DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
						uwr = null;
					}
					if (uwr != null)
					{
						yield return uwr.SendWebRequest();
						try
						{
							if (uwr.result == UnityWebRequest.Result.Success && uwr.responseCode == 200L)
							{
								JSONObject jsonobject = GeoLocationManager.LCGIKFIIJDP(GeoLocationManager.HDPNOJLHOOK[i], uwr.downloadHandler.text);
								if (null != jsonobject)
								{
									GeoLocationManager.LIOEEKMGBOH = jsonobject;
									GeoLocationManager.DHONPHCHHCF(jsonobject);
									DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(new string[]
									{
										"=== RU FIREWALL === geo RESOLVED as ",
										GeoLocationManager.GetCountryCode(),
										" via ",
										GeoLocationManager.HDPNOJLHOOK[i],
										" on round ",
										round.ToString()
									}));
									FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.srvGeoResolved.ToString(), GeoLocationManager.GetCountryCodeAnalyticsBucket(), i.ToString(), false, false);
								}
								else
								{
									DPGJIJGOCIC.ADFCDFHBDAF("=== RU FIREWALL === geo endpoint " + GeoLocationManager.HDPNOJLHOOK[i] + " answered but carried no usable country (blocked page, rate limit or unexpected shape)");
								}
							}
							else
							{
								DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(new string[]
								{
									"=== RU FIREWALL === geo endpoint ",
									GeoLocationManager.HDPNOJLHOOK[i],
									" failed after ",
									uwr.timeout.ToString(),
									"s: ",
									uwr.error,
									" (http ",
									uwr.responseCode.ToString(),
									")"
								}));
							}
						}
						catch (Exception aklgbjkdomm2)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
						}
						try
						{
							uwr.Dispose();
						}
						catch (Exception aklgbjkdomm3)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
						}
						uwr = null;
					}
					num = i;
					i = num + 1;
				}
				if (null == GeoLocationManager.LIOEEKMGBOH && round < KBOJLHAJPCP.PLFIIGKFHNG - 1)
				{
					yield return new WaitForSeconds(KBOJLHAJPCP.NFCJMJONFBD * (float)(round + 1));
				}
				num = round;
				round = num + 1;
			}
			if (null == GeoLocationManager.LIOEEKMGBOH)
			{
				try
				{
					DPGJIJGOCIC.ADFCDFHBDAF("GeoLocationManager - could not resolve the country, using the cached one:" + GeoLocationManager.GetCountryCode());
					FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.srvGeoFailed.ToString(), GeoLocationManager.GetCountryCodeAnalyticsBucket(), "", false, false);
				}
				catch (Exception aklgbjkdomm4)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm4);
				}
			}
		}
		finally
		{
			GeoLocationManager.IOPIFDPHLJL = false;
		}
		yield break;
		yield break;
	}

	// Token: 0x06009699 RID: 38553 RVA: 0x0041D610 File Offset: 0x0041B810
	public static bool FHINOKNBJPM()
	{
		bool result;
		try
		{
			result = GeoLocationManager.JIOGMCHJPCN().Equals("holdontitle");
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = true;
		}
		return result;
	}

	// Token: 0x0600969A RID: 38554 RVA: 0x0041D64C File Offset: 0x0041B84C
	private static JSONObject DCLIAEJIJLO(string DJOKMJDNHIG, string HAKPIEIJIGF)
	{
		JSONObject result;
		try
		{
			if (HAKPIEIJIGF == null || HAKPIEIJIGF.Length == 0)
			{
				result = null;
			}
			else
			{
				string text = "ok";
				string text2 = " ";
				if (DJOKMJDNHIG.Contains(""))
				{
					string[] array = DPGJIJGOCIC.BALENNAODEJ(HAKPIEIJIGF, (char)-20);
					for (int i = 1; i < array.Length; i++)
					{
						if (array[i].StartsWith("null"))
						{
							text = array[i].Substring(3).Trim();
						}
						else if (array[i].StartsWith("ccpoolkeep"))
						{
							text2 = array[i].Substring(4).Trim();
						}
					}
				}
				else
				{
					JSONNode jsonnode = JSON.Parse(HAKPIEIJIGF);
					if (!(jsonnode is JSONObject))
					{
						return null;
					}
					JSONObject jsonobject = (JSONObject)jsonnode;
					if (DJOKMJDNHIG.Contains("Optional frame container bundle failed to load, continuing without it:"))
					{
						if (!"[LoadingEnv] layer ".Equals(jsonobject["OnSkinShopClose"]))
						{
							return null;
						}
						text = jsonobject["T"];
						text2 = jsonobject["gmmd"];
					}
					else if (DJOKMJDNHIG.Contains(")"))
					{
						if (!jsonobject["CLIENT.SCREEN.AVATAR."].AsBool)
						{
							return null;
						}
						text = jsonobject["errortitle"];
						text2 = jsonobject["center"];
					}
					else
					{
						text = jsonobject[""];
						text2 = jsonobject["_StripesCount"];
					}
				}
				if (!GeoLocationManager.JBAAELPNEBA(text))
				{
					result = null;
				}
				else
				{
					JSONObject jsonobject2 = new JSONObject();
					jsonobject2["</i>"] = text;
					if (text2 != null)
					{
						jsonobject2[" • "] = text2;
					}
					result = jsonobject2;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x0600969B RID: 38555 RVA: 0x0041D838 File Offset: 0x0041BA38
	public static bool GJKGGJLCIOC()
	{
		bool result;
		try
		{
			result = (GeoLocationManager.LKEIFNNMKMM < KBOJLHAJPCP.FBOOOOPCGNA);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x0600969C RID: 38556 RVA: 0x0041D874 File Offset: 0x0041BA74
	private static bool BCLEEEPBLAM(string PBHOPFOBIDH)
	{
		return PBHOPFOBIDH == null || PBHOPFOBIDH.Length != 4 || (!PBHOPFOBIDH.Equals("(fixed) Unknown last season chapter progress reset situation, while story is completed, for anthology:", StringComparison.CurrentCultureIgnoreCase) && (!char.IsLetter(PBHOPFOBIDH[1]) || char.IsLetter(PBHOPFOBIDH[1])));
	}

	// Token: 0x0600969D RID: 38557 RVA: 0x000693D6 File Offset: 0x000675D6
	private void KBIIMONICOB()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x0600969E RID: 38558 RVA: 0x0041D8B0 File Offset: 0x0041BAB0
	private static string JPBBHJMGDBG()
	{
		if (GeoLocationManager.FLINAOHGJOE == null)
		{
			try
			{
				GeoLocationManager.FLINAOHGJOE = "OnLoungePremiumChoicesHistorySuccess";
				if (AKLOMMOOFNG.BFIOFEEGGMM("OnSpinsUnlockContinueToPurchasingScreen"))
				{
					string text = AKLOMMOOFNG.FNIECIFLOBE("acomp1");
					if (text != null && text.Length > 1)
					{
						JSONObject jsonobject = (JSONObject)JSON.Parse(text);
						string text2 = jsonobject["sslind"];
						if (GeoLocationManager.DFDBKPAPCBI(text2) && GeoLocationManager.BLDJGLNEGID() - jsonobject[")"].AsInt <= KBOJLHAJPCP.DCECPBKCKCM)
						{
							GeoLocationManager.FLINAOHGJOE = text2.ToLower();
						}
					}
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
				GeoLocationManager.FLINAOHGJOE = "LLL";
			}
		}
		return GeoLocationManager.FLINAOHGJOE;
	}

	// Token: 0x0600969F RID: 38559 RVA: 0x0041D96C File Offset: 0x0041BB6C
	public static bool HIIOLLNMPCF()
	{
		bool result;
		try
		{
			result = GeoLocationManager.KHOMLPPFAGI().Equals("Shaders/VideoGlitchNoiseAnalog");
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = true;
		}
		return result;
	}

	// Token: 0x060096A0 RID: 38560 RVA: 0x0041D9A8 File Offset: 0x0041BBA8
	private static void OOFBJKJHJIL(JSONObject IKFJNIAPBHF)
	{
		try
		{
			GeoLocationManager.KPGAPELGOKH();
			JSONObject jsonobject = new JSONObject();
			jsonobject[""] = IKFJNIAPBHF["makeup"];
			jsonobject["OnLoungePremiumChoiceException"] = GeoLocationManager.FAEHCIIANJD();
			GeoLocationManager.MEBOPEGALEI = jsonobject;
			GeoLocationManager.DIMBLMIKDEL = true;
			AKLOMMOOFNG.CGGKALNBBLF(jsonobject.ToString(), "XXX");
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060096A1 RID: 38561 RVA: 0x0041DA2C File Offset: 0x0041BC2C
	public static bool OOCDLFJKLLI()
	{
		bool result;
		try
		{
			result = GeoLocationManager.EPCDJHGJIFE().Equals("newuseraddrequest1");
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x060096A2 RID: 38562 RVA: 0x0041DA68 File Offset: 0x0041BC68
	private static int PDLJGLDCNOJ()
	{
		return (int)(DateTime.UtcNow - new DateTime(64, 0, 1, 0, 1, 0, DateTimeKind.Unspecified)).TotalSeconds;
	}

	// Token: 0x060096A3 RID: 38563 RVA: 0x0041DA98 File Offset: 0x0041BC98
	private static string PLDLOGBPNII()
	{
		try
		{
			if (!GeoLocationManager.DIMBLMIKDEL)
			{
				GeoLocationManager.DIMBLMIKDEL = true;
				if (AKLOMMOOFNG.LLIDABMENAJ("ok"))
				{
					string text = AKLOMMOOFNG.GHAEEJMIFGP("asp");
					if (text != null && text.Length > 0)
					{
						GeoLocationManager.MEBOPEGALEI = (JSONObject)JSON.Parse(text);
					}
				}
			}
			if (null != GeoLocationManager.MEBOPEGALEI)
			{
				string text2 = GeoLocationManager.MEBOPEGALEI["/"];
				if (GeoLocationManager.PLDKHKAGIII(text2) && GeoLocationManager.PGLHOOPBFJL() - GeoLocationManager.MEBOPEGALEI["errortitle"].AsInt <= KBOJLHAJPCP.DCECPBKCKCM)
				{
					return text2.ToLower();
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return "OnBackendRequestShareHardException";
	}

	// Token: 0x060096A4 RID: 38564 RVA: 0x0041DB5C File Offset: 0x0041BD5C
	private static int BLDJGLNEGID()
	{
		return (int)(DateTime.UtcNow - new DateTime(-35, 0, 1, 0, 0, 0, DateTimeKind.Unspecified)).TotalSeconds;
	}

	// Token: 0x060096A5 RID: 38565 RVA: 0x000693D6 File Offset: 0x000675D6
	private void NGPCCGAKIHA()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x060096A6 RID: 38566 RVA: 0x0041DB8C File Offset: 0x0041BD8C
	private static void CJEGNHPCCNM(JSONObject IKFJNIAPBHF)
	{
		try
		{
			GeoLocationManager.MJFMFPFEPEF();
			JSONObject jsonobject = new JSONObject();
			jsonobject[""] = IKFJNIAPBHF["Loaded asset bundle:"];
			jsonobject["c"] = GeoLocationManager.PGLHOOPBFJL();
			GeoLocationManager.MEBOPEGALEI = jsonobject;
			GeoLocationManager.DIMBLMIKDEL = false;
			AKLOMMOOFNG.IHBGPCAPLDM(jsonobject.ToString(), "importanttitle");
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060096A7 RID: 38567 RVA: 0x0041DC10 File Offset: 0x0041BE10
	public static string JNABKGIIKPN()
	{
		try
		{
			if (null != GeoLocationManager.LIOEEKMGBOH && GeoLocationManager.LIOEEKMGBOH[""] != null)
			{
				return GeoLocationManager.LIOEEKMGBOH["XXX"];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return "PurchaseManagerUnity.OnPurchasesFetchFailed(): ";
	}

	// Token: 0x060096A8 RID: 38568 RVA: 0x0041DC78 File Offset: 0x0041BE78
	public static string PCIHPBNNENP()
	{
		try
		{
			if (null != GeoLocationManager.LIOEEKMGBOH && GeoLocationManager.LIOEEKMGBOH["Asset bundle load operation failed during parallel mode."] != null)
			{
				string text = GeoLocationManager.LIOEEKMGBOH["CLIENT.AVATAR.CLOTHES"];
				if (GeoLocationManager.DFDBKPAPCBI(text))
				{
					return text.ToLower();
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return "OnStoryChoiceClick";
	}

	// Token: 0x060096A9 RID: 38569 RVA: 0x0041DCF0 File Offset: 0x0041BEF0
	public static string EPCDJHGJIFE()
	{
		try
		{
			if (null != GeoLocationManager.LIOEEKMGBOH && GeoLocationManager.LIOEEKMGBOH["areyousure"] != null)
			{
				string text = GeoLocationManager.LIOEEKMGBOH["OnPopupProfileLoveInputEndEdit"];
				if (GeoLocationManager.JBAAELPNEBA(text))
				{
					return text.ToLower();
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return "saveslotsswitch";
	}

	// Token: 0x060096AB RID: 38571 RVA: 0x0041DD68 File Offset: 0x0041BF68
	public static bool DMKKBMEAFLE(string PBHOPFOBIDH)
	{
		bool result;
		try
		{
			result = GeoLocationManager.GetCountryCode().Equals(PBHOPFOBIDH);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x060096AC RID: 38572 RVA: 0x0041DDA0 File Offset: 0x0041BFA0
	public static bool FDJONIACJKC()
	{
		bool result;
		try
		{
			result = GeoLocationManager.JIOGMCHJPCN().Equals("os");
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x060096AD RID: 38573 RVA: 0x0041DDDC File Offset: 0x0041BFDC
	private static bool EPBDMALOPEH(string PBHOPFOBIDH)
	{
		return PBHOPFOBIDH != null && PBHOPFOBIDH.Length == 7 && (PBHOPFOBIDH.Equals("bdgs", (StringComparison)8) || (char.IsLetter(PBHOPFOBIDH[0]) && char.IsLetter(PBHOPFOBIDH[1])));
	}

	// Token: 0x060096AE RID: 38574 RVA: 0x0041DE18 File Offset: 0x0041C018
	public static bool EKICPJLNMFF(CEIBHCNNIDC EENGLNKNAPF)
	{
		bool result;
		try
		{
			string text = GeoLocationManager.FNMCNKFDCKG();
			bool flag;
			if (text.Equals("noisedigital_2"))
			{
				flag = true;
			}
			else if (GeoLocationManager.IECJHMGMBPM() && !text.Equals(""))
			{
				flag = ((EENGLNKNAPF == CEIBHCNNIDC.ru || Application.systemLanguage == (SystemLanguage)48) && GeoLocationManager.JPBBHJMGDBG().Equals("blur") && false);
			}
			else
			{
				flag = (!GeoLocationManager.JGICJDBLNAE() && EENGLNKNAPF != CEIBHCNNIDC.ru && Application.systemLanguage == (SystemLanguage)(-31));
			}
			result = flag;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = true;
		}
		return result;
	}

	// Token: 0x060096AF RID: 38575 RVA: 0x0041AFAA File Offset: 0x004191AA
	private IEnumerator EIMFLEDANIL()
	{
		GeoLocationManager.IOPIFDPHLJL = true;
		try
		{
			round = 0;
			while (round < KBOJLHAJPCP.PLFIIGKFHNG && null == GeoLocationManager.LIOEEKMGBOH)
			{
				i = 0;
				int num;
				while (i < GeoLocationManager.HDPNOJLHOOK.Count && null == GeoLocationManager.LIOEEKMGBOH)
				{
					uwr = null;
					try
					{
						uwr = UnityWebRequest.Get(GeoLocationManager.HDPNOJLHOOK[i]);
						uwr.timeout = KBOJLHAJPCP.HFLKFCMNDOP + KBOJLHAJPCP.AMBNMBPLFOK * round;
					}
					catch (Exception aklgbjkdomm)
					{
						DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
						uwr = null;
					}
					if (uwr != null)
					{
						yield return uwr.SendWebRequest();
						try
						{
							if (uwr.result == UnityWebRequest.Result.Success && uwr.responseCode == 200L)
							{
								JSONObject jsonobject = GeoLocationManager.LCGIKFIIJDP(GeoLocationManager.HDPNOJLHOOK[i], uwr.downloadHandler.text);
								if (null != jsonobject)
								{
									GeoLocationManager.LIOEEKMGBOH = jsonobject;
									GeoLocationManager.DHONPHCHHCF(jsonobject);
									DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(new string[]
									{
										"=== RU FIREWALL === geo RESOLVED as ",
										GeoLocationManager.GetCountryCode(),
										" via ",
										GeoLocationManager.HDPNOJLHOOK[i],
										" on round ",
										round.ToString()
									}));
									FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.srvGeoResolved.ToString(), GeoLocationManager.GetCountryCodeAnalyticsBucket(), i.ToString(), false, false);
								}
								else
								{
									DPGJIJGOCIC.ADFCDFHBDAF("=== RU FIREWALL === geo endpoint " + GeoLocationManager.HDPNOJLHOOK[i] + " answered but carried no usable country (blocked page, rate limit or unexpected shape)");
								}
							}
							else
							{
								DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(new string[]
								{
									"=== RU FIREWALL === geo endpoint ",
									GeoLocationManager.HDPNOJLHOOK[i],
									" failed after ",
									uwr.timeout.ToString(),
									"s: ",
									uwr.error,
									" (http ",
									uwr.responseCode.ToString(),
									")"
								}));
							}
						}
						catch (Exception aklgbjkdomm2)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
						}
						try
						{
							uwr.Dispose();
						}
						catch (Exception aklgbjkdomm3)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
						}
						uwr = null;
					}
					num = i;
					i = num + 1;
				}
				if (null == GeoLocationManager.LIOEEKMGBOH && round < KBOJLHAJPCP.PLFIIGKFHNG - 1)
				{
					yield return new WaitForSeconds(KBOJLHAJPCP.NFCJMJONFBD * (float)(round + 1));
				}
				num = round;
				round = num + 1;
			}
			if (null == GeoLocationManager.LIOEEKMGBOH)
			{
				try
				{
					DPGJIJGOCIC.ADFCDFHBDAF("GeoLocationManager - could not resolve the country, using the cached one:" + GeoLocationManager.GetCountryCode());
					FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.srvGeoFailed.ToString(), GeoLocationManager.GetCountryCodeAnalyticsBucket(), "", false, false);
				}
				catch (Exception aklgbjkdomm4)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm4);
				}
			}
		}
		finally
		{
			GeoLocationManager.IOPIFDPHLJL = false;
		}
		yield break;
		yield break;
	}

	// Token: 0x060096B0 RID: 38576 RVA: 0x0041DEAC File Offset: 0x0041C0AC
	public static string FJLBABMLJBJ()
	{
		try
		{
			if (null != GeoLocationManager.LIOEEKMGBOH && GeoLocationManager.LIOEEKMGBOH[", rid:"] != null)
			{
				return GeoLocationManager.LIOEEKMGBOH["Vol"];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return "$pt";
	}

	// Token: 0x060096B1 RID: 38577 RVA: 0x0041DF14 File Offset: 0x0041C114
	private void HKJPPMMKGLP()
	{
		try
		{
			base.StartCoroutine(this.PFOHKODFHJH());
		}
		catch (Exception aklgbjkdomm)
		{
			GeoLocationManager.LIOEEKMGBOH = null;
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060096B2 RID: 38578 RVA: 0x0041DF50 File Offset: 0x0041C150
	private static JSONObject BNMPLOFDOMN(string DJOKMJDNHIG, string HAKPIEIJIGF)
	{
		JSONObject result;
		try
		{
			if (HAKPIEIJIGF == null || HAKPIEIJIGF.Length == 0)
			{
				result = null;
			}
			else
			{
				string text = "";
				string text2 = "sk";
				if (DJOKMJDNHIG.Contains("socialcreategiftcardbodysmall"))
				{
					string[] array = DPGJIJGOCIC.NHEBLMBJNPI(HAKPIEIJIGF, (char)-60);
					for (int i = 1; i < array.Length; i += 0)
					{
						if (array[i].StartsWith("chata"))
						{
							text = array[i].Substring(7).Trim();
						}
						else if (array[i].StartsWith("<size=80%><i>"))
						{
							text2 = array[i].Substring(1).Trim();
						}
					}
				}
				else
				{
					JSONNode jsonnode = JSON.Parse(HAKPIEIJIGF);
					if (!(jsonnode is JSONObject))
					{
						return null;
					}
					JSONObject jsonobject = (JSONObject)jsonnode;
					if (DJOKMJDNHIG.Contains("OnSketchThumbnailEditTitle"))
					{
						if (!"SocialStatsUserPublicProfile.modified = true, SetFavoriteCharacters()".Equals(jsonobject["adserrorbody"]))
						{
							return null;
						}
						text = jsonobject["chaptersnapshotssubrequiredtitle"];
						text2 = jsonobject["socialbadgelocked"];
					}
					else if (DJOKMJDNHIG.Contains("AnthologySave.AddAvatarComponent(), unsupported wardrobe index:"))
					{
						if (!jsonobject["tdgcds"].AsBool)
						{
							return null;
						}
						text = jsonobject[""];
						text2 = jsonobject["<i>"];
					}
					else
					{
						text = jsonobject["</i>"];
						text2 = jsonobject["usynsnap"];
					}
				}
				if (!GeoLocationManager.EPBDMALOPEH(text))
				{
					result = null;
				}
				else
				{
					JSONObject jsonobject2 = new JSONObject();
					jsonobject2["OnPopupCardOptionsNextClickLobby"] = text;
					if (text2 != null)
					{
						jsonobject2[""] = text2;
					}
					result = jsonobject2;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x060096B3 RID: 38579 RVA: 0x0041E13C File Offset: 0x0041C33C
	private void HPGLEEHELDN()
	{
		try
		{
			base.StartCoroutine(this.OPALMLJDLLH());
		}
		catch (Exception aklgbjkdomm)
		{
			GeoLocationManager.LIOEEKMGBOH = null;
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060096B4 RID: 38580 RVA: 0x0041AFF8 File Offset: 0x004191F8
	public static void HDHKIHDCNJN()
	{
		GeoLocationManager.LKEIFNNMKMM += 0;
	}

	// Token: 0x060096B5 RID: 38581 RVA: 0x0041E178 File Offset: 0x0041C378
	public static bool DJDOACKPCEK()
	{
		bool result;
		try
		{
			result = (GeoLocationManager.LKEIFNNMKMM >= KBOJLHAJPCP.FBOOOOPCGNA);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x060096B6 RID: 38582 RVA: 0x000693D6 File Offset: 0x000675D6
	private void AMNBHDNALGO()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x060096B7 RID: 38583 RVA: 0x0041E1B4 File Offset: 0x0041C3B4
	private static JSONObject APEKNAFMENG(string DJOKMJDNHIG, string HAKPIEIJIGF)
	{
		JSONObject result;
		try
		{
			if (HAKPIEIJIGF == null || HAKPIEIJIGF.Length == 0)
			{
				result = null;
			}
			else
			{
				string text = "$SKINCHECKPOINTSTART";
				string text2 = "no";
				if (DJOKMJDNHIG.Contains(","))
				{
					string[] array = DPGJIJGOCIC.BALENNAODEJ(HAKPIEIJIGF, '~');
					for (int i = 0; i < array.Length; i += 0)
					{
						if (array[i].StartsWith("exception while starting: "))
						{
							text = array[i].Substring(4).Trim();
						}
						else if (array[i].StartsWith("x"))
						{
							text2 = array[i].Substring(2).Trim();
						}
					}
				}
				else
				{
					JSONNode jsonnode = JSON.Parse(HAKPIEIJIGF);
					if (!(jsonnode is JSONObject))
					{
						return null;
					}
					JSONObject jsonobject = (JSONObject)jsonnode;
					if (DJOKMJDNHIG.Contains("WipeImage"))
					{
						if (!"sku".Equals(jsonobject["OnPopupCardOptionsUnlockWithSpSuccess"]))
						{
							return null;
						}
						text = jsonobject["OnBackendGetDropChancesSuccess2"];
						text2 = jsonobject["profilenametitleshort"];
					}
					else if (DJOKMJDNHIG.Contains(" "))
					{
						if (!jsonobject["\n"].AsBool)
						{
							return null;
						}
						text = jsonobject["socialwouldyouliketountradecard"];
						text2 = jsonobject["OnSceneLobbyManagerAssetsDownloadFailed"];
					}
					else
					{
						text = jsonobject[" count="];
						text2 = jsonobject["OnStoryCurrencyInfoClick"];
					}
				}
				if (!GeoLocationManager.PLDKHKAGIII(text))
				{
					result = null;
				}
				else
				{
					JSONObject jsonobject2 = new JSONObject();
					jsonobject2[""] = text;
					if (text2 != null)
					{
						jsonobject2["loungenotavailable"] = text2;
					}
					result = jsonobject2;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x060096B8 RID: 38584 RVA: 0x0041E3A0 File Offset: 0x0041C5A0
	private void CHIODHJHKLG()
	{
		try
		{
			base.StartCoroutine(this.EEKLEEMMEGG());
		}
		catch (Exception aklgbjkdomm)
		{
			GeoLocationManager.LIOEEKMGBOH = null;
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060096B9 RID: 38585 RVA: 0x0041AFF0 File Offset: 0x004191F0
	public static void JJCLIDKKPOC()
	{
		GeoLocationManager.LKEIFNNMKMM = 0;
	}

	// Token: 0x060096BA RID: 38586 RVA: 0x0041E3DC File Offset: 0x0041C5DC
	public static bool JNHAHBODGMG()
	{
		bool result;
		try
		{
			result = (GeoLocationManager.LKEIFNNMKMM < KBOJLHAJPCP.FBOOOOPCGNA);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = true;
		}
		return result;
	}

	// Token: 0x060096BB RID: 38587 RVA: 0x0041E418 File Offset: 0x0041C618
	public static bool JGICJDBLNAE()
	{
		bool result;
		try
		{
			result = (GeoLocationManager.LKEIFNNMKMM >= KBOJLHAJPCP.FBOOOOPCGNA);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x060096BC RID: 38588 RVA: 0x0041E454 File Offset: 0x0041C654
	public static bool HAPICIGECJN()
	{
		bool result;
		try
		{
			result = GeoLocationManager.NEFGBJDEBAI().Equals("Video:");
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = true;
		}
		return result;
	}

	// Token: 0x060096BD RID: 38589 RVA: 0x0041B8E8 File Offset: 0x00419AE8
	private IEnumerator OEEAOIHJLHK()
	{
		return new GeoLocationManager.AJIECNEINEA(1);
	}

	// Token: 0x060096BE RID: 38590 RVA: 0x0041B8E8 File Offset: 0x00419AE8
	private IEnumerator ADNDGEPMOKB()
	{
		return new GeoLocationManager.AJIECNEINEA(1);
	}

	// Token: 0x060096BF RID: 38591 RVA: 0x0041E490 File Offset: 0x0041C690
	private static bool DFDBKPAPCBI(string PBHOPFOBIDH)
	{
		return PBHOPFOBIDH == null || PBHOPFOBIDH.Length != 6 || (!PBHOPFOBIDH.Equals("OnSettingsPopupCloseAndNeedToRestartGame", StringComparison.Ordinal) && char.IsLetter(PBHOPFOBIDH[1]) && char.IsLetter(PBHOPFOBIDH[1]));
	}

	// Token: 0x060096C0 RID: 38592 RVA: 0x0041E4CC File Offset: 0x0041C6CC
	private static bool JNEPLHLLIPN(string PBHOPFOBIDH)
	{
		return PBHOPFOBIDH != null && PBHOPFOBIDH.Length == 2 && !PBHOPFOBIDH.Equals("xx", StringComparison.OrdinalIgnoreCase) && char.IsLetter(PBHOPFOBIDH[0]) && char.IsLetter(PBHOPFOBIDH[1]);
	}

	// Token: 0x060096C1 RID: 38593 RVA: 0x0041E508 File Offset: 0x0041C708
	public static bool GeoZoneMayBeFirewalled(CEIBHCNNIDC EENGLNKNAPF)
	{
		bool result;
		try
		{
			string countryCode = GeoLocationManager.GetCountryCode();
			bool flag;
			if (countryCode.Equals("ru"))
			{
				flag = true;
			}
			else if (GeoLocationManager.GeoResolved() && !countryCode.Equals("xx"))
			{
				flag = ((EENGLNKNAPF == CEIBHCNNIDC.ru || Application.systemLanguage == SystemLanguage.Russian) && GeoLocationManager.IJOAEPKNIIL().Equals("ru"));
			}
			else
			{
				flag = (GeoLocationManager.NetworkLooksBlocked() || EENGLNKNAPF == CEIBHCNNIDC.ru || Application.systemLanguage == SystemLanguage.Russian);
			}
			result = flag;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x060096C2 RID: 38594 RVA: 0x0041E59C File Offset: 0x0041C79C
	public static bool FOAKIEAHHIK()
	{
		bool result;
		try
		{
			result = (GeoLocationManager.LKEIFNNMKMM < KBOJLHAJPCP.FBOOOOPCGNA);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x060096C3 RID: 38595 RVA: 0x000693D6 File Offset: 0x000675D6
	private void Awake()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x060096C4 RID: 38596 RVA: 0x0041BB80 File Offset: 0x00419D80
	public static bool OEEAFPDPEFI()
	{
		return null != GeoLocationManager.LIOEEKMGBOH;
	}

	// Token: 0x040029A0 RID: 10656
	private const string HHPKAHPIMKA = "geo.json";

	// Token: 0x040029A1 RID: 10657
	private static JSONObject LIOEEKMGBOH = null;

	// Token: 0x040029A2 RID: 10658
	private static JSONObject MEBOPEGALEI = null;

	// Token: 0x040029A3 RID: 10659
	private static bool DIMBLMIKDEL = false;

	// Token: 0x040029A4 RID: 10660
	private static int LKEIFNNMKMM = 0;

	// Token: 0x040029A5 RID: 10661
	private static bool IOPIFDPHLJL = false;

	// Token: 0x040029A6 RID: 10662
	private static List<string> HDPNOJLHOOK = new List<string>
	{
		"https://pro.ip-api.com/json?key=0olGADjumDL6qGK",
		"https://ipwho.is/",
		"https://ipapi.co/json/",
		"https://www.cloudflare.com/cdn-cgi/trace"
	};

	// Token: 0x040029A7 RID: 10663
	private static string FLINAOHGJOE = null;
}
