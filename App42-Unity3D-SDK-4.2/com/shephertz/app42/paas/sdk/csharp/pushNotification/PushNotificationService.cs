using System;
using System.Collections.Generic;
using System.Text;
using com.shephertz.app42.paas.sdk.csharp.connection;
using com.shephertz.app42.paas.sdk.csharp.storage;
using com.shephertz.app42.paas.sdk.csharp.util;
using SimpleJSON;

namespace com.shephertz.app42.paas.sdk.csharp.pushNotification
{
	// Token: 0x02000083 RID: 131
	public class PushNotificationService : App42Service
	{
		// Token: 0x0600055D RID: 1373 RVA: 0x0001C9BE File Offset: 0x0001ABBE
		public PushNotificationService(string apiKey, string secretKey)
		{
			this.apiKey = apiKey;
			this.secretKey = secretKey;
			this.version = "1.0";
			this.resource = "push";
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x0001C9EC File Offset: 0x0001ABEC
		public void StoreDeviceToken(string Username, string deviceToken, string deviceType, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(Username, "Username");
			Util.ThrowExceptionIfNullOrBlank(deviceToken, "deviceToken");
			Util.ThrowExceptionIfNullOrBlank(deviceType, "deviceType");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"userName\":\"" + Username + "\",");
			stringBuilder.Append("\"deviceToken\":\"" + deviceToken + "\",");
			stringBuilder.Append("\"type\":\"" + deviceType + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"push\":").Append(stringBuilder.ToString()).Append("}}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/storeDeviceToken/",
				Username
			});
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x0001CB38 File Offset: 0x0001AD38
		public void CreateChannelForApp(string channel, string description, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(channel, "Channel Name");
			Util.ThrowExceptionIfNullOrBlank(description, "Description");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"name\":\"" + channel + "\",");
			stringBuilder.Append("\"description\":\"" + description + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"push\":{\"channel\":").Append(stringBuilder.ToString()).Append("}}}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/createAppChannel";
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x0001CC40 File Offset: 0x0001AE40
		public void SubscribeToChannel(string channel, string userName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(channel, "Channel Name");
			Util.ThrowExceptionIfNullOrBlank(userName, "userName");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"userName\":\"" + userName + "\",");
			stringBuilder.Append("\"name\":\"" + channel + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"push\":{\"channel\":").Append(stringBuilder.ToString()).Append("}}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/subscribeToChannel/",
				userName
			});
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x0001CD68 File Offset: 0x0001AF68
		public void UnsubscribeFromChannel(string channel, string userName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "Username");
			Util.ThrowExceptionIfNullOrBlank(channel, "channel");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"userName\":\"" + userName + "\",");
			stringBuilder.Append("\"name\":\"" + channel + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"push\":{\"channel\":").Append(stringBuilder.ToString()).Append("}}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/unsubscribeToChannel/",
				userName
			});
			RESTConnectorWWW.GetInstance().ExecutePut(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x0001CE90 File Offset: 0x0001B090
		public void SendPushMessageToChannel(string channel, string message, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(channel, "channel");
			Util.ThrowExceptionIfNullOrBlank(message, "message");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			if (Util.CheckIfJSONString(message))
			{
				stringBuilder.Append("{\"payload\":" + message + ",");
			}
			else
			{
				stringBuilder.Append("{\"payload\":\"" + message + "\",");
			}
			stringBuilder.Append("\"channel\":\"" + channel + "\",");
			stringBuilder.Append("\"expiry\":\"" + Util.GetUTCFormattedTimestamp() + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"push\":{\"message\":").Append(stringBuilder.ToString()).Append("}}}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/sendPushMessageToChannel/",
				channel
			});
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x0001CFF8 File Offset: 0x0001B1F8
		public void SendPushMessageToAll(string message, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(message, "message");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			if (Util.CheckIfJSONString(message))
			{
				stringBuilder.Append("{\"payload\":" + message + ",");
			}
			else
			{
				stringBuilder.Append("{\"payload\":\"" + message + "\",");
			}
			stringBuilder.Append("\"expiry\":\"" + Util.GetUTCFormattedTimestamp() + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"push\":{\"message\":").Append(stringBuilder.ToString()).Append("}}}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/sendPushMessageToAll";
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x0001D11C File Offset: 0x0001B31C
		public void SendPushMessageToAllByType(string message, string type, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(message, "message");
			Util.ThrowExceptionIfNullOrBlank(type, "type");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			if (Util.CheckIfJSONString(message))
			{
				stringBuilder.Append("{\"payload\":" + message + ",");
			}
			else
			{
				stringBuilder.Append("{\"payload\":\"" + message + "\",");
			}
			stringBuilder.Append("\"type\":\"" + type + "\",");
			stringBuilder.Append("\"expiry\":\"" + Util.GetUTCFormattedTimestamp() + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"push\":{\"message\":").Append(stringBuilder.ToString()).Append("}}}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/sendMessageToAllByType";
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x0001D264 File Offset: 0x0001B464
		public void SendPushMessageToUser(string username, string message, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(username, "Username");
			Util.ThrowExceptionIfNullOrBlank(message, "message");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			if (Util.CheckIfJSONString(message))
			{
				stringBuilder.Append("{\"payload\":" + message + ",");
			}
			else
			{
				stringBuilder.Append("{\"payload\":\"" + message + "\",");
			}
			stringBuilder.Append("\"userName\":\"" + username + "\",");
			stringBuilder.Append("\"expiry\":\"" + Util.GetUTCFormattedTimestamp() + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"push\":{\"message\":").Append(stringBuilder.ToString()).Append("}}}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/sendMessage/",
				username
			});
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x0001D3CC File Offset: 0x0001B5CC
		public void UnsubscribeDeviceToChannel(string userName, string channelName, string deviceToken, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "Username");
			Util.ThrowExceptionIfNullOrBlank(deviceToken, "deviceToken");
			Util.ThrowExceptionIfNullOrBlank(channelName, "channelName");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"userName\":\"" + userName + "\",");
			stringBuilder.Append("\"channelName\":\"" + channelName + "\",");
			stringBuilder.Append("\"deviceToken\":\"" + deviceToken + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"push\":").Append(stringBuilder.ToString()).Append("}}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/unsubscribeDeviceToChannel";
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x0001D4F8 File Offset: 0x0001B6F8
		public void SubscribeToChannel(string userName, string channelName, string deviceToken, string deviceType, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "Username");
			Util.ThrowExceptionIfNullOrBlank(channelName, "channelName");
			Util.ThrowExceptionIfNullOrBlank(deviceToken, "deviceToken");
			Util.ThrowExceptionIfNullOrBlank(deviceType, "deviceType");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"userName\":\"" + userName + "\",");
			stringBuilder.Append("\"channelName\":\"" + channelName + "\",");
			stringBuilder.Append("\"deviceToken\":\"" + deviceToken + "\",");
			stringBuilder.Append("\"type\":\"" + deviceType + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"push\":").Append(stringBuilder.ToString()).Append("}}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/subscribeDeviceToChannel";
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x0001D64C File Offset: 0x0001B84C
		public void DeleteDeviceToken(string userName, string deviceToken, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "Username");
			Util.ThrowExceptionIfNullOrBlank(deviceToken, "deviceToken");
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			Dictionary<string, string> dictionary2 = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
			dictionary3 = base.Merge(dictionary2, obj);
			dictionary2.Add("userName", userName);
			dictionary2.Add("deviceToken", deviceToken);
			dictionary.Add("userName", userName);
			dictionary.Add("deviceToken", deviceToken);
			string value = Util.Sign(this.secretKey, dictionary2);
			dictionary3.Add("signature", value);
			string url = this.version + "/" + this.resource;
			RESTConnectorWWW.GetInstance().ExecuteDelete(url, dictionary, dictionary2, dictionary3, callBack);
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x0001D708 File Offset: 0x0001B908
		public void SendPushMessageToGroup(string message, IList<string> userList, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(message, "message");
			Util.ThrowExceptionIfNullOrBlank(userList, "userList");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			if (Util.CheckIfJSONString(message))
			{
				stringBuilder.Append("{\"payload\":" + message + ",");
			}
			else
			{
				stringBuilder.Append("{\"payload\":\"" + message + "\",");
			}
			stringBuilder.Append("\"expiry\":\"" + Util.GetUTCFormattedTimestamp() + "\",");
			JSONArray jsonarray = new JSONArray();
			for (int i = 0; i < userList.Count; i++)
			{
				string text = userList[i];
				jsonarray.Add(text.ToString());
			}
			stringBuilder.Append("\"users\":{\"user\":" + jsonarray.ToString() + "}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"push\":{\"message\":").Append(stringBuilder.ToString()).Append("}}}}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/sendPushMessageToGroup";
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x0001D890 File Offset: 0x0001BA90
		public void SendPushToTargetUsers(string message, string dbName, string collectionName, Query query, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(message, "message");
			Util.ThrowExceptionIfNullOrBlank(query, "query");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			if (Util.CheckIfJSONString(message))
			{
				stringBuilder.Append("{\"payload\":" + message + ",");
			}
			else
			{
				stringBuilder.Append("{\"payload\":\"" + message + "\",");
			}
			stringBuilder.Append("\"expiry\":\"" + Util.GetUTCFormattedTimestamp() + "\",");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"push\":{\"message\":").Append(stringBuilder.ToString()).Append("}}}}");
			dictionary.Add("body", stringBuilder2.ToString());
			dictionary.Add("jsonQuery", query.GetStr());
			dictionary2.Add("jsonQuery", query.GetStr());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/sendTargetPush/",
				dbName,
				"/",
				collectionName
			});
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x0001DA14 File Offset: 0x0001BC14
		public void SendMessageToInActiveUsers(DateTime startDate, DateTime endDate, string message, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(startDate, "startDate");
			Util.ThrowExceptionIfNullOrBlank(endDate, "endDate");
			Util.ThrowExceptionIfNullOrBlank(message, "message");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			string utcformattedTimestamp = Util.GetUTCFormattedTimestamp(startDate);
			string utcformattedTimestamp2 = Util.GetUTCFormattedTimestamp(endDate);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"startDate\":\"" + utcformattedTimestamp + "\",");
			stringBuilder.Append("\"endDate\":\"" + utcformattedTimestamp2 + "\",");
			if (Util.CheckIfJSONString(message))
			{
				stringBuilder.Append("\"payload\":" + message + ",");
			}
			else
			{
				stringBuilder.Append("\"payload\":\"" + message + "\",");
			}
			stringBuilder.Append("\"expiry\":\"" + Util.GetUTCFormattedTimestamp() + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"push\":{\"message\":").Append(stringBuilder.ToString()).Append("}}}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/sendMessageToInActiveUsers";
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x0001DB9C File Offset: 0x0001BD9C
		public void ScheduleMessageToUser(string username, string message, DateTime expiryDate, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(username, "username");
			Util.ThrowExceptionIfNullOrBlank(expiryDate, "expiryDate");
			Util.ThrowExceptionIfNullOrBlank(message, "message");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"userName\":\"" + username + "\",");
			if (Util.CheckIfJSONString(message))
			{
				stringBuilder.Append("\"payload\":" + message + ",");
			}
			else
			{
				stringBuilder.Append("\"payload\":\"" + message + "\",");
			}
			stringBuilder.Append("\"expiry\":\"" + Util.GetUTCFormattedTimestamp(expiryDate) + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"push\":{\"message\":").Append(stringBuilder.ToString()).Append("}}}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/sendMessage/",
				username
			});
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x0001DD14 File Offset: 0x0001BF14
		public void UnSubscribeDevice(string userName, string deviceToken, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "Username");
			Util.ThrowExceptionIfNullOrBlank(deviceToken, "deviceToken");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"userName\":\"" + userName + "\",");
			stringBuilder.Append("\"deviceToken\":\"" + deviceToken + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"push\":").Append(stringBuilder.ToString()).Append("}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/unsubscribeDevice";
			RESTConnectorWWW.GetInstance().ExecutePut(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x0001DE1C File Offset: 0x0001C01C
		public void ReSubscribeDevice(string userName, string deviceToken, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "Username");
			Util.ThrowExceptionIfNullOrBlank(deviceToken, "deviceToken");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"userName\":\"" + userName + "\",");
			stringBuilder.Append("\"deviceToken\":\"" + deviceToken + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"push\":").Append(stringBuilder.ToString()).Append("}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/reSubscribeDevice";
			RESTConnectorWWW.GetInstance().ExecutePut(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x0001DF24 File Offset: 0x0001C124
		public void DeleteAllDevices(string userName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "UserName");
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			Dictionary<string, string> dictionary2 = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
			dictionary3 = base.Merge(dictionary2, obj);
			dictionary2.Add("userName", userName);
			dictionary.Add("userName", userName);
			string value = Util.Sign(this.secretKey, dictionary2);
			dictionary3.Add("signature", value);
			string url = this.version + "/" + this.resource + "/deleteAll";
			RESTConnectorWWW.GetInstance().ExecuteDelete(url, dictionary, dictionary2, dictionary3, callBack);
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x0001DFC0 File Offset: 0x0001C1C0
		public void SendPushMessageToDevice(string username, string deviceId, string message, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(username, "Username");
			Util.ThrowExceptionIfNullOrBlank(message, "message");
			Util.ThrowExceptionIfNullOrBlank(deviceId, "deviceId");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"userName\":\"" + username + "\",");
			if (Util.CheckIfJSONString(message))
			{
				stringBuilder.Append("\"payload\":" + message + ",");
			}
			else
			{
				stringBuilder.Append("\"payload\":\"" + message + "\",");
			}
			stringBuilder.Append("\"deviceId\":\"" + deviceId + "\",");
			stringBuilder.Append("\"expiry\":\"" + Util.GetUTCFormattedTimestamp() + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"push\":{\"message\":").Append(stringBuilder.ToString()).Append("}}}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/sendMessageToDevice/",
				username
			});
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x0001E14C File Offset: 0x0001C34C
		public void UpdatePushBadgeforDevice(string userName, string deviceToken, int badges, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "Username");
			Util.ThrowExceptionIfNullOrBlank(deviceToken, "deviceToken");
			Util.ThrowExceptionIfNullOrBlank(badges, "badges");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"userName\":\"" + userName + "\",");
			stringBuilder.Append("\"deviceToken\":\"" + deviceToken + "\",");
			stringBuilder.Append("\"increment\":\"" + badges + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"push\":").Append(stringBuilder.ToString()).Append("}}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/resetPushBadgeforDevice";
			RESTConnectorWWW.GetInstance().ExecutePut(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x0001E284 File Offset: 0x0001C484
		public void UpdatePushBadgeforUser(string userName, int badges, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "Username");
			Util.ThrowExceptionIfNullOrBlank(badges, "badges");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"userName\":\"" + userName + "\",");
			stringBuilder.Append("\"increment\":\"" + badges + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"push\":").Append(stringBuilder.ToString()).Append("}}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/resetPushBadgeforUser";
			RESTConnectorWWW.GetInstance().ExecutePut(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x0001E398 File Offset: 0x0001C598
		public void ClearAllBadgeCount(string userName, string deviceToken, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "Username");
			Util.ThrowExceptionIfNullOrBlank(deviceToken, "deviceToken");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"userName\":\"" + userName + "\",");
			stringBuilder.Append("\"deviceToken\":\"" + deviceToken + "\",");
			stringBuilder.Append("\"increment\":" + 0 + "}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"push\":").Append(stringBuilder.ToString()).Append("}}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/resetPushBadgeforDevice";
			RESTConnectorWWW.GetInstance().ExecutePut(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x0001E4C0 File Offset: 0x0001C6C0
		public void DeleteChannel(string channelName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(channelName, "channelName");
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			Dictionary<string, string> dictionary2 = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
			dictionary3 = base.Merge(dictionary2, obj);
			dictionary2.Add("channelName", channelName);
			dictionary.Add("channelName", channelName);
			string value = Util.Sign(this.secretKey, dictionary2);
			dictionary3.Add("signature", value);
			string url = this.version + "/" + this.resource + "/deleteChannel";
			RESTConnectorWWW.GetInstance().ExecuteDelete(url, dictionary, dictionary2, dictionary3, callBack);
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x0001E55C File Offset: 0x0001C75C
		public void GetChannelUsersCount(string channelName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(channelName, "channelName");
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			Dictionary<string, string> dictionary2 = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
			dictionary3 = base.Merge(dictionary2, obj);
			dictionary2.Add("channelName", channelName);
			dictionary.Add("channelName", channelName);
			string value = Util.Sign(this.secretKey, dictionary2);
			string url = this.version + "/" + this.resource + "/count/channel";
			dictionary3.Add("signature", value);
			RESTConnectorWWW.GetInstance().ExecuteGet(url, dictionary, dictionary2, dictionary3, callBack);
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x0001E5F8 File Offset: 0x0001C7F8
		public void GetChannelUsers(string channelName, int max, int offset, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(channelName, "channelName");
			Util.ValidateMax(max);
			Util.ThrowExceptionIfNullOrBlank(max, "Max");
			Util.ThrowExceptionIfNullOrBlank(offset, "Offset");
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			Dictionary<string, string> dictionary2 = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
			dictionary3 = base.Merge(dictionary2, obj);
			dictionary2.Add("channelName", channelName);
			dictionary.Add("channelName", channelName);
			dictionary2.Add("max", string.Concat(max));
			dictionary2.Add("offset", string.Concat(offset));
			string value = Util.Sign(this.secretKey, dictionary2);
			dictionary3.Add("signature", value);
			string url = string.Concat(new object[]
			{
				this.version,
				"/",
				this.resource,
				"/channel/",
				max,
				"/",
				offset
			});
			dictionary3.Add("isArray", "true");
			RESTConnectorWWW.GetInstance().ExecuteGet(url, dictionary, dictionary2, dictionary3, callBack);
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x0001E730 File Offset: 0x0001C930
		public void GetUserSubscribedChannelsCount(string userName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "userName");
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			Dictionary<string, string> dictionary2 = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
			dictionary3 = base.Merge(dictionary2, obj);
			dictionary2.Add("userName", userName);
			dictionary.Add("userName", userName);
			string value = Util.Sign(this.secretKey, dictionary2);
			string url = this.version + "/" + this.resource + "/count/userchannels";
			dictionary3.Add("signature", value);
			RESTConnectorWWW.GetInstance().ExecuteGet(url, dictionary, dictionary2, dictionary3, callBack);
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x0001E7CC File Offset: 0x0001C9CC
		public void GetUserSubscribedChannels(string userName, int max, int offset, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "userName");
			Util.ValidateMax(max);
			Util.ThrowExceptionIfNullOrBlank(max, "Max");
			Util.ThrowExceptionIfNullOrBlank(offset, "Offset");
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			Dictionary<string, string> dictionary2 = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
			dictionary3 = base.Merge(dictionary2, obj);
			dictionary2.Add("userName", userName);
			dictionary.Add("userName", userName);
			dictionary2.Add("max", string.Concat(max));
			dictionary2.Add("offset", string.Concat(offset));
			string value = Util.Sign(this.secretKey, dictionary2);
			dictionary3.Add("signature", value);
			string url = string.Concat(new object[]
			{
				this.version,
				"/",
				this.resource,
				"/userchannels/",
				max,
				"/",
				offset
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, dictionary, dictionary2, dictionary3, callBack);
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x0001E8F4 File Offset: 0x0001CAF4
		public void GetAllDevicesOfUser(string userName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "userName");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("userName", userName);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/getAllDevices/",
				userName
			});
			dictionary2.Add("isArray", "true");
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x0001E9B4 File Offset: 0x0001CBB4
		public void SendPushMessageToAppGroup(string username, string message, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(username, "Username");
			Util.ThrowExceptionIfNullOrBlank(message, "message");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"userName\":\"" + username + "\",");
			if (Util.CheckIfJSONString(message))
			{
				stringBuilder.Append("\"payload\":" + message + ",");
			}
			else
			{
				stringBuilder.Append("\"payload\":\"" + message + "\",");
			}
			stringBuilder.Append("\"expiry\":\"" + Util.GetUTCFormattedTimestamp() + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"push\":{\"message\":").Append(stringBuilder.ToString()).Append("}}}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/sendMessageToAppGroup/",
				username
			});
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x0001EB1C File Offset: 0x0001CD1C
		public void SendPushTileMessageToUser(string userName, Tile tile, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "UserName");
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"title\":\"" + tile.GetTitle() + "\",");
			stringBuilder.Append("\"count\":\"" + tile.GetCount() + "\",");
			stringBuilder.Append("\"backgroundImage\":\"" + tile.GetBackgroundImage() + "\",");
			stringBuilder.Append("\"backBackgroundImage\":\"" + tile.GetBackBackgroundImage() + "\",");
			stringBuilder.Append("\"backTitle\":\"" + tile.GetBackTitle() + "\",");
			stringBuilder.Append("\"backContent\":\"" + tile.GetBackContent() + "\",");
			stringBuilder.Append("\"expiry\":\"" + Util.GetUTCFormattedTimestamp() + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"tile\":").Append(stringBuilder.ToString()).Append("}");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder3 = new StringBuilder();
			stringBuilder3.Append("{\"userName\":\"" + userName + "\",");
			stringBuilder3.Append("\"payload\":" + stringBuilder2.ToString() + ",");
			stringBuilder3.Append("\"expiry\":\"" + Util.GetUTCFormattedTimestamp() + "\"}");
			StringBuilder stringBuilder4 = new StringBuilder();
			stringBuilder4.Append("{\"app42\":{\"push\":{\"message\":").Append(stringBuilder3.ToString()).Append("}}}");
			dictionary.Add("body", stringBuilder4.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/sendMessage/",
				userName
			});
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder4.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x0001ED50 File Offset: 0x0001CF50
		public void TrackPush(App42CallBack callBack)
		{
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"eventName\":\"PUSH_OPEN\",");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"push\":").Append(stringBuilder.ToString()).Append("}}}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/trackPush";
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x0001EE20 File Offset: 0x0001D020
		public void TrackPushOpened(Dictionary<string, object> paramsJson, App42CallBack callBack)
		{
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			if (paramsJson.ContainsKey("app42_campaignName"))
			{
				stringBuilder.Append("{\"app42_campaignName\":\"" + paramsJson["app42_campaignName"] + "\",");
			}
			else
			{
				stringBuilder.Append("{\"app42_campaignName\":\"\",");
			}
			if (paramsJson.ContainsKey("app42_source"))
			{
				stringBuilder.Append("\"app42_source\":\"" + paramsJson["app42_source"] + "\",");
			}
			else
			{
				stringBuilder.Append("\"app42_source\":\"\",");
			}
			if (paramsJson.ContainsKey("app42_message_id"))
			{
				stringBuilder.Append("\"app42_message_id\":\"" + paramsJson["app42_message_id"] + "\",");
			}
			else
			{
				stringBuilder.Append("\"app42_message_id\":\"\",");
			}
			if (paramsJson.ContainsKey("app42_campId"))
			{
				stringBuilder.Append("\"app42_campId\":" + paramsJson["app42_campId"] + "}");
			}
			else
			{
				stringBuilder.Append("\"app42_campId\":" + 0 + "}");
			}
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"push\":").Append(stringBuilder.ToString()).Append("}}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/trackPushOpened";
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x0001EFEC File Offset: 0x0001D1EC
		public void TrackPushDelivered(Dictionary<string, object> paramsJson, App42CallBack callBack)
		{
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			if (paramsJson.ContainsKey("app42_campaignName"))
			{
				stringBuilder.Append("{\"app42_campaignName\":\"" + paramsJson["app42_campaignName"] + "\",");
			}
			else
			{
				stringBuilder.Append("{\"app42_campaignName\":\"\",");
			}
			if (paramsJson.ContainsKey("app42_source"))
			{
				stringBuilder.Append("\"app42_source\":\"" + paramsJson["app42_source"] + "\",");
			}
			else
			{
				stringBuilder.Append("\"app42_source\":\"\",");
			}
			if (paramsJson.ContainsKey("app42_message_id"))
			{
				stringBuilder.Append("\"app42_message_id\":\"" + paramsJson["app42_message_id"] + "\",");
			}
			else
			{
				stringBuilder.Append("\"app42_message_id\":\"\",");
			}
			if (paramsJson.ContainsKey("app42_campId"))
			{
				stringBuilder.Append("\"app42_campId\":" + paramsJson["app42_campId"] + "}");
			}
			else
			{
				stringBuilder.Append("\"app42_campId\":" + 0 + "}");
			}
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"push\":").Append(stringBuilder.ToString()).Append("}}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/trackPushDelivered";
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}
	}
}
