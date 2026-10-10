using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using app42InAppMessagingListner;
using App42Json;
using SimpleJSON;
using UnityEngine;

namespace com.shephertz.app42.paas.sdk.csharp.app42Event
{
	// Token: 0x02000043 RID: 67
	internal class EventServiceUtils : App42CallBack
	{
		// Token: 0x0600028E RID: 654 RVA: 0x0000EA5F File Offset: 0x0000CC5F
		internal EventServiceUtils(App42CallBack callback)
		{
			this.clientCallback = callback;
		}

		// Token: 0x0600028F RID: 655 RVA: 0x0000EA6E File Offset: 0x0000CC6E
		internal EventServiceUtils()
		{
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0000EA76 File Offset: 0x0000CC76
		internal static void FireInstallEvent(string apiKey, string secretKey)
		{
			if (!Local.HasKey("_InstalledOn"))
			{
				new EventService(apiKey, secretKey).TrackEventInternal("Install", null, new EventServiceUtils());
			}
		}

		// Token: 0x06000291 RID: 657 RVA: 0x0000EA9B File Offset: 0x0000CC9B
		internal static void GetCurrentLoggedInUserProperties(string apiKey, string secretKey)
		{
			new EventService(apiKey, secretKey).GetLoggedInUserProperties(new EventResponse());
		}

		// Token: 0x06000292 RID: 658 RVA: 0x0000EAB0 File Offset: 0x0000CCB0
		internal static string GenerateProperties()
		{
			string operatingSystem = SystemInfo.operatingSystem;
			string value = EventServiceUtils.XmlCharacterWhitelist(operatingSystem);
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary.Add("app42_brand", SystemInfo.deviceName);
			dictionary.Add("app42_os_version", value);
			dictionary.Add("app42_screen_dpi", Screen.dpi);
			dictionary.Add("app42_screen_height", Screen.height);
			dictionary.Add("app42_screen_width", Screen.width);
			dictionary.Add("app42_os", value);
			dictionary.Add("app42_model", SystemInfo.deviceModel);
			dictionary.Add("app42_lastCommunicatedAt", "");
			dictionary.Add("app42_counter", EventService.IncrementCounter());
			EventServiceUtils.deviceProps = dictionary;
			return EventServiceUtils.ConvertDictionaryToJson(dictionary);
		}

		// Token: 0x06000293 RID: 659 RVA: 0x0000EB78 File Offset: 0x0000CD78
		internal static string XmlCharacterWhitelist(string in_string)
		{
			if (in_string == null)
			{
				return null;
			}
			StringBuilder stringBuilder = new StringBuilder();
			foreach (char c in in_string)
			{
				if ((c >= ' ' && c <= '퟿') || (c >= '' && c <= '�') || c == '\t' || c == '\n' || c == '\r')
				{
					stringBuilder.Append(c);
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000294 RID: 660 RVA: 0x0000EBE4 File Offset: 0x0000CDE4
		internal static void UpdateDeviceStatus(Dictionary<string, object> newProps)
		{
			try
			{
				if (Local.HasKey("DeviceInfo") && !string.IsNullOrEmpty(Local.Fetch("DeviceInfo")))
				{
					string str = Local.Fetch("DeviceInfo");
					App42JObject app42JObject = new App42JObject(str);
					ArrayList keys = app42JObject.keys;
					foreach (object obj in keys)
					{
						string text = (string)obj;
						if (!EventServiceUtils.deviceProps.ContainsKey(text))
						{
							if (text.Equals("app42_screen_height") || text.Equals("app42_screen_width") || text.Equals("app42_screen_dpi"))
							{
								EventServiceUtils.deviceProps.Add(text, app42JObject.GetField(text).n);
							}
							else
							{
								EventServiceUtils.deviceProps.Add(text, app42JObject.GetField(text).str);
							}
						}
					}
					foreach (KeyValuePair<string, object> keyValuePair in newProps)
					{
						if (EventServiceUtils.deviceProps.ContainsKey(keyValuePair.Key))
						{
							EventServiceUtils.deviceProps[keyValuePair.Key] = keyValuePair.Value;
						}
						else
						{
							EventServiceUtils.deviceProps.Add(keyValuePair.Key, keyValuePair.Value);
						}
					}
					Local.Save("DeviceInfo", EventServiceUtils.ConvertDictionaryToJson(EventServiceUtils.deviceProps));
				}
				else
				{
					App42Log.Console("Something Went Wrong");
				}
			}
			catch (Exception ex)
			{
				App42Log.Console("Exception When Updating Device Status :: " + ex.ToString());
			}
		}

		// Token: 0x06000295 RID: 661 RVA: 0x0000EDC8 File Offset: 0x0000CFC8
		internal static string ConvertDictionaryToJson(Dictionary<string, object> dict)
		{
			if (dict == null || dict.Count <= 0)
			{
				return "{}";
			}
			string result;
			try
			{
				StringBuilder stringBuilder = new StringBuilder("{");
				foreach (KeyValuePair<string, object> keyValuePair in dict)
				{
					stringBuilder.Append(string.Concat(new object[]
					{
						'"',
						keyValuePair.Key,
						'"',
						":"
					}));
					if (keyValuePair.Value is string)
					{
						stringBuilder.Append(string.Concat(new object[]
						{
							'"',
							keyValuePair.Value.ToString(),
							'"',
							","
						}));
					}
					else
					{
						stringBuilder.Append(keyValuePair.Value + ",");
					}
				}
				int startIndex = stringBuilder.ToString().LastIndexOf(",");
				stringBuilder.Remove(startIndex, 1);
				result = stringBuilder.ToString() + "}";
			}
			catch (ArgumentException ex)
			{
				throw new App42Exception(ex.ToString());
			}
			return result;
		}

		// Token: 0x06000296 RID: 662 RVA: 0x0000EF44 File Offset: 0x0000D144
		internal static void SetOrGetLoggedInUser()
		{
			if (string.IsNullOrEmpty(App42API.loggedInUser))
			{
				App42API.SetLoggedInUser(App42API.installationId);
			}
		}

		// Token: 0x06000297 RID: 663 RVA: 0x0000EF5C File Offset: 0x0000D15C
		public void OnSuccess(object response)
		{
			EventService.DecrementCounter();
			App42Log.Console("Success " + response.ToString());
			JSONNode jsonnode = JSONNode.Parse(response.ToString());
			JSONNode jsonnode2 = (JSONObject)jsonnode["app42"];
			JSONNode jsonnode3 = (JSONObject)jsonnode2["response"]["event"];
			JSONNode jsonnode4 = jsonnode3["name"];
			JSONNode jsonnode5 = jsonnode3["type"];
			JSONNode jsonnode6 = jsonnode3["lastCommunicatedAt"];
			string value = jsonnode4.Value;
			if (jsonnode5.Value.Equals("SESSION END") && Local.HasKey("app42_start_" + value))
			{
				Local.Save("app42_end_" + value, jsonnode6.Value);
				Local.Remove("app42_start_" + value);
			}
			else if (jsonnode5.Value.Equals("SESSION START"))
			{
				Local.Save("app42_start_" + value, jsonnode6.Value);
			}
			else
			{
				Local.Save("app42_" + value, jsonnode6.Value);
			}
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			if (!Local.HasKey("_InstalledOn") && jsonnode5.Value.Equals("EVENT") && value.Equals("INSTALL"))
			{
				Local.Save("_InstalledOn", jsonnode6.Value);
				dictionary.Add("app42_installAt", Local.Fetch("_InstalledOn"));
			}
			dictionary.Add("app42_lastCommunicatedAt", jsonnode6.Value);
			Local.Save("_lastCommAt_Super", jsonnode6.Value);
			EventServiceUtils.UpdateDeviceStatus(dictionary);
			if (this.clientCallback != null)
			{
				string strResponse = "{\"app42\":{\"response\":{\"success\":true}}}";
				App42Response app42Response = new App42Response();
				app42Response.SetStrResponse(strResponse);
				app42Response.SetResponseSuccess(true);
				this.clientCallback.OnSuccess(app42Response);
			}
			if (InAppMessaging.IsInAppMessagingEnabled)
			{
				new EventSender().Send(jsonnode5.Value, value, true);
			}
		}

		// Token: 0x06000298 RID: 664 RVA: 0x0000F154 File Offset: 0x0000D354
		public void OnException(Exception exception1)
		{
			EventService.DecrementCounter();
			if (this.clientCallback != null)
			{
				this.clientCallback.OnException(exception1);
			}
			App42Log.Console("Internal Exception" + exception1.ToString());
		}

		// Token: 0x040000D6 RID: 214
		private App42CallBack clientCallback;

		// Token: 0x040000D7 RID: 215
		private static Dictionary<string, object> deviceProps = new Dictionary<string, object>();
	}
}
