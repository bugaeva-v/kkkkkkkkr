using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using com.shephertz.app42.paas.sdk.csharp.connection;
using com.shephertz.app42.paas.sdk.csharp.util;
using SimpleJSON;
using UnityEngine;

namespace com.shephertz.app42.paas.sdk.csharp.app42Event
{
	// Token: 0x02000041 RID: 65
	public class EventService : App42Service
	{
		// Token: 0x06000277 RID: 631 RVA: 0x0000DAF9 File Offset: 0x0000BCF9
		public EventService(string apiKey, string secretKey)
		{
			this.resource = "event";
			this.apiKey = apiKey;
			this.secretKey = secretKey;
			this.version = "1.0";
			EventServiceUtils.SetOrGetLoggedInUser();
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0000DB2A File Offset: 0x0000BD2A
		internal static int IncrementCounter()
		{
			return Interlocked.Increment(ref EventService.counter);
		}

		// Token: 0x06000279 RID: 633 RVA: 0x0000DB36 File Offset: 0x0000BD36
		internal static void DecrementCounter()
		{
			Interlocked.Decrement(ref EventService.counter);
		}

		// Token: 0x0600027A RID: 634 RVA: 0x0000DB43 File Offset: 0x0000BD43
		public void TrackEvent(string eventName, Dictionary<string, object> properties, App42CallBack callBack)
		{
			if (!App42API.unlockEventService)
			{
				Debug.LogWarning(EventService.errorMessage);
				return;
			}
			this.TrackEventInternal(eventName, properties, new EventServiceUtils(callBack));
		}

		// Token: 0x0600027B RID: 635 RVA: 0x0000DB68 File Offset: 0x0000BD68
		internal void TrackEventInternal(string eventName, Dictionary<string, object> properties, App42CallBack callBack)
		{
			eventName = eventName.ToUpper();
			Util.ThrowExceptionIfNullOrBlank(eventName, "Event Name");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"eventName\":\"" + eventName + "\",");
			stringBuilder.Append("\"methodName\":\"_TRACKEVENT_\",");
			stringBuilder.Append("\"app42_lastCommunicatedAt\":\"" + this.CkeckLocal("app42_" + eventName) + "\",");
			if (!this.CkeckLocal("_lastUserUpdatedOn" + App42API.loggedInUser).Equals(""))
			{
				stringBuilder.Append("\"app42_userUpdatedOn\":\"" + this.CkeckLocal("_lastUserUpdatedOn" + App42API.loggedInUser) + "\",");
			}
			stringBuilder.Append("\"superProperties\":" + this.GetDefaultDeviceProps() + ",");
			if (!this.GetOldInstallProperties().Equals("\"\""))
			{
				stringBuilder.Append("\"installProperties\":" + this.GetOldInstallProperties() + ",");
			}
			stringBuilder.Append("\"userProperties\":" + Util.ConvertDictionaryToJson(properties) + "}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"event\":").Append(stringBuilder.ToString()).Append("}}");
			App42Log.Console(" Json String : " + stringBuilder2.ToString());
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource;
			RESTConnectorWWW.GetInstance().ExecuteEventPost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x0600027C RID: 636 RVA: 0x0000DD51 File Offset: 0x0000BF51
		public void StartActivity(string activityName, Dictionary<string, object> properties, App42CallBack callBack)
		{
			if (!App42API.unlockEventService)
			{
				Debug.LogWarning(EventService.errorMessage);
				return;
			}
			this.StartActivityInternal(activityName, properties, new EventServiceUtils(callBack));
		}

		// Token: 0x0600027D RID: 637 RVA: 0x0000DD74 File Offset: 0x0000BF74
		internal void StartActivityInternal(string activityName, Dictionary<string, object> properties, App42CallBack callBack)
		{
			activityName = activityName.ToUpper();
			Util.ThrowExceptionIfNullOrBlank(activityName, "Activity Name");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"eventName\":\"" + activityName + "\",");
			stringBuilder.Append("\"methodName\":\"_STARTEVENT_\",");
			stringBuilder.Append("\"action\":\"START\",");
			stringBuilder.Append("\"app42_lastCommunicatedAt\":\"" + this.CkeckLastCommAt("app42_end_" + activityName, "app42_start_" + activityName) + "\",");
			if (!this.CkeckLocal("_lastUserUpdatedOn" + App42API.loggedInUser).Equals(""))
			{
				stringBuilder.Append("\"app42_userUpdatedOn\":\"" + this.CkeckLocal("_lastUserUpdatedOn" + App42API.loggedInUser) + "\",");
			}
			stringBuilder.Append("\"superProperties\":" + this.GetDefaultDeviceProps() + ",");
			if (!this.GetOldInstallProperties().Equals("\"\""))
			{
				stringBuilder.Append("\"installProperties\":" + this.GetOldInstallProperties() + ",");
			}
			stringBuilder.Append("\"userProperties\":" + Util.ConvertDictionaryToJson(properties) + "}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"event\":").Append(stringBuilder.ToString()).Append("}}");
			App42Log.Console(" Json String : " + stringBuilder2.ToString());
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/session";
			RESTConnectorWWW.GetInstance().ExecuteEventPost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x0600027E RID: 638 RVA: 0x0000DF7A File Offset: 0x0000C17A
		public void EndActivity(string activityName, Dictionary<string, object> properties, App42CallBack callBack)
		{
			if (!App42API.unlockEventService)
			{
				Debug.LogWarning(EventService.errorMessage);
				return;
			}
			this.EndActivityInternal(activityName, properties, new EventServiceUtils(callBack));
		}

		// Token: 0x0600027F RID: 639 RVA: 0x0000DF9C File Offset: 0x0000C19C
		internal void EndActivityInternal(string activityName, Dictionary<string, object> properties, App42CallBack callBack)
		{
			activityName = activityName.ToUpper();
			if (this.CkeckLocal("app42_start_" + activityName).Equals(""))
			{
				EventService.IncrementCounter();
				callBack.OnException(new App42Exception("Activity with the name [ " + activityName + " ] Is Already Ended"));
				return;
			}
			Util.ThrowExceptionIfNullOrBlank(activityName, "Activity Name");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"eventName\":\"" + activityName + "\",");
			stringBuilder.Append("\"methodName\":\"_ENDEVENT_\",");
			stringBuilder.Append("\"action\":\"END\",");
			stringBuilder.Append("\"app42_lastCommunicatedAt\":\"" + this.CkeckLocal("app42_start_" + activityName) + "\",");
			if (!this.CkeckLocal("_lastUserUpdatedOn" + App42API.loggedInUser).Equals(""))
			{
				stringBuilder.Append("\"app42_userUpdatedOn\":\"" + this.CkeckLocal("_lastUserUpdatedOn" + App42API.loggedInUser) + "\",");
			}
			stringBuilder.Append("\"superProperties\":" + this.GetDefaultDeviceProps() + ",");
			if (!this.GetOldInstallProperties().Equals("\"\""))
			{
				stringBuilder.Append("\"installProperties\":" + this.GetOldInstallProperties() + ",");
			}
			stringBuilder.Append("\"userProperties\":" + Util.ConvertDictionaryToJson(properties) + "}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"event\":").Append(stringBuilder.ToString()).Append("}}");
			App42Log.Console(" Json String : " + stringBuilder2.ToString());
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/session";
			RESTConnectorWWW.GetInstance().ExecuteEventPost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0000E1D8 File Offset: 0x0000C3D8
		public void SetLoggedInUserProperties(Dictionary<string, object> properties, App42CallBack callBack)
		{
			if (!App42API.unlockEventService)
			{
				Debug.LogWarning(EventService.errorMessage);
				return;
			}
			Util.ThrowExceptionIfNullOrBlank(properties, "Properties");
			Local.Save("_newInstallProps", Util.ConvertDictionaryToJson(properties));
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"app42_installAt\":\"" + this.CkeckLocal("_InstalledOn") + "\",");
			stringBuilder.Append("\"installProperties\":" + Util.ConvertDictionaryToJson(properties) + "}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"event\":").Append(stringBuilder.ToString()).Append("}}");
			App42Log.Console(" Json String : " + stringBuilder2.ToString());
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/userproperties";
			RESTConnectorWWW.GetInstance().ExecuteEventPost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, new EventResponse(callBack));
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0000E324 File Offset: 0x0000C524
		public void UpdateLoggedInUserProperties(Dictionary<string, object> properties, App42CallBack callBack)
		{
			if (!App42API.unlockEventService)
			{
				Debug.LogWarning(EventService.errorMessage);
				return;
			}
			Util.ThrowExceptionIfNullOrBlank(properties, "Properties");
			Local.Save("_newInstallProps", Util.ConvertDictionaryToJson(properties));
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"installProperties\":" + Util.ConvertDictionaryToJson(properties) + ",");
			stringBuilder.Append("\"app42_lastCommunicatedAt\":\"" + this.CkeckLocal("_lastCommAt_Super") + "\",");
			stringBuilder.Append("\"app42_installAt\":\"" + this.CkeckLocal("_InstalledOn") + "\",");
			stringBuilder.Append("\"app42_userUpdatedOn\":\"" + this.CkeckLocal("_lastUserUpdatedOn" + App42API.loggedInUser) + "\",");
			stringBuilder.Append("\"oldProperties\":" + this.GetOldInstallProperties() + "}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"event\":").Append(stringBuilder.ToString()).Append("}}");
			App42Log.Console(" Json String : " + stringBuilder2.ToString());
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/updateuserproperties";
			RESTConnectorWWW.GetInstance().ExecuteEventPost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, new EventResponse(callBack));
		}

		// Token: 0x06000282 RID: 642 RVA: 0x0000E4D8 File Offset: 0x0000C6D8
		internal void GetLoggedInUserProperties(App42CallBack callBack)
		{
			if (!App42API.unlockEventService)
			{
				Debug.LogWarning(EventService.errorMessage);
				return;
			}
			Local.Save("_newInstallProps", "\"\"");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"installProperties\":\"\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"event\":").Append(stringBuilder.ToString()).Append("}}");
			App42Log.Console(" Json String : " + stringBuilder2.ToString());
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/userproperties";
			RESTConnectorWWW.GetInstance().ExecuteEventPost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x06000283 RID: 643 RVA: 0x0000E5E0 File Offset: 0x0000C7E0
		public void GetConfig(App42CallBack callBack)
		{
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource;
			RESTConnectorWWW.GetInstance().ExecuteEventGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000284 RID: 644 RVA: 0x0000E654 File Offset: 0x0000C854
		public void IsAvailable(IList<string> campaignList, App42CallBack callBack)
		{
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			JSONArray jsonarray = new JSONArray();
			for (int i = 0; i < campaignList.Count; i++)
			{
				string text = campaignList[i];
				jsonarray.Add(text.ToString());
			}
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("\"campaigns\":{\"campaign\":" + jsonarray.ToString() + "}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{").Append(stringBuilder.ToString()).Append("}}");
			App42Log.Console(" Json String : " + stringBuilder2.ToString());
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/isAvailable";
			RESTConnectorWWW.GetInstance().ExecuteEventPost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x06000285 RID: 645 RVA: 0x0000E784 File Offset: 0x0000C984
		private string GetOldInstallProperties()
		{
			string result;
			if (Local.HasKey("_oldInstallProps" + App42API.loggedInUser))
			{
				result = Local.Fetch("_oldInstallProps" + App42API.loggedInUser);
			}
			else
			{
				result = "\"\"";
			}
			return result;
		}

		// Token: 0x06000286 RID: 646 RVA: 0x0000E7CC File Offset: 0x0000C9CC
		private string GetDefaultDeviceProps()
		{
			string text;
			if (Local.HasKey("DeviceInfo"))
			{
				EventServiceUtils.UpdateDeviceStatus(new Dictionary<string, object>
				{
					{
						"app42_counter",
						EventService.IncrementCounter()
					}
				});
				text = Local.Fetch("DeviceInfo");
			}
			else
			{
				text = EventServiceUtils.GenerateProperties();
				Local.Save("DeviceInfo", text);
			}
			return text;
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0000E82C File Offset: 0x0000CA2C
		private string CkeckLocal(string key)
		{
			string result;
			if (Local.HasKey(key))
			{
				result = Local.Fetch(key);
			}
			else
			{
				result = "";
			}
			return result;
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0000E858 File Offset: 0x0000CA58
		private string CkeckLastCommAt(string key1, string key2)
		{
			string result;
			if (Local.HasKey(key1))
			{
				result = Local.Fetch(key1);
			}
			else if (Local.HasKey(key2))
			{
				result = Local.Fetch(key2);
			}
			else
			{
				result = "";
			}
			return result;
		}

		// Token: 0x040000D3 RID: 211
		private static string errorMessage = "ERROR IN ACCESSING EVENT SERVICE CLASS :: Set App42API.EnableEventService True To Access EventService Members.";

		// Token: 0x040000D4 RID: 212
		internal static int counter = 0;
	}
}
