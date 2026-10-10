using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using App42Json;
using com.shephertz.app42.paas.sdk.csharp.util;
using SimpleJSON;
using UnityEngine;

namespace com.shephertz.app42.paas.sdk.csharp.connection
{
	// Token: 0x0200001F RID: 31
	internal class App42OfflineHandler : MonoBehaviour
	{
		// Token: 0x06000131 RID: 305 RVA: 0x00005F00 File Offset: 0x00004100
		internal static App42OfflineHandler GetInstance()
		{
			if (App42OfflineHandler.applicationIsQuitting)
			{
				App42Log.Console("[Singleton] Instance already destroyed on application quit. Won't create again - returning null.");
				return null;
			}
			App42OfflineHandler result;
			lock (App42OfflineHandler.lockString)
			{
				if (App42OfflineHandler.instance == null)
				{
					GameObject gameObject = new GameObject("App42OfflineHandler");
					App42OfflineHandler.instance = gameObject.AddComponent<App42OfflineHandler>();
					Object.DontDestroyOnLoad(gameObject);
					result = App42OfflineHandler.instance;
				}
				else
				{
					result = App42OfflineHandler.instance;
				}
			}
			return result;
		}

		// Token: 0x06000132 RID: 306 RVA: 0x000061E8 File Offset: 0x000043E8
		internal IEnumerator ProcessPendingRequests(string counterKey)
		{
			App42Log.Console("Checking Pending Requests In LocalStorage...");
			if (PlayerPrefs.HasKey(counterKey) && PlayerPrefs.GetInt(counterKey) > 0 && !App42OfflineHandler.isRequestsExecuting)
			{
				App42OfflineHandler.isRequestsExecuting = true;
				int requestCounts = PlayerPrefs.GetInt(counterKey);
				for (int i = requestCounts; i >= 1; i--)
				{
					App42Log.Console("Fetching Request : " + i);
					yield return new WaitForSeconds(3f);
					if (PlayerPrefs.HasKey("KEY_OFFLINE_REQ_" + i))
					{
						this.BuildOfflineRequests("KEY_OFFLINE_REQ_" + i, counterKey);
					}
					else if (PlayerPrefs.HasKey("KEY_BACKLOG_REQ_" + i))
					{
						this.BuildOfflineRequests("KEY_BACKLOG_REQ_" + i, counterKey);
					}
					else
					{
						App42Log.Console("Completed request : " + i);
						yield return i;
					}
					yield return null;
				}
				PlayerPrefs.DeleteKey(counterKey);
				App42OfflineHandler.isRequestsExecuting = false;
			}
			else if (PlayerPrefs.HasKey("KEY_BACKLOG_REQ_COUNTER") && PlayerPrefs.GetInt("KEY_BACKLOG_REQ_COUNTER") > 0 && !App42OfflineHandler.isRequestsExecuting)
			{
				App42Log.Console("Failed Requests Found :: " + PlayerPrefs.GetInt("KEY_BACKLOG_REQ_COUNTER") + " :: Processing Again.. :: ");
				base.StartCoroutine(this.ProcessPendingRequests("KEY_BACKLOG_REQ_COUNTER"));
			}
			else
			{
				App42Log.Console("All Requests Completed Gracefully !");
			}
			yield break;
		}

		// Token: 0x06000133 RID: 307 RVA: 0x0000620C File Offset: 0x0000440C
		internal void BuildOfflineRequests(string requestKey, string counterKey)
		{
			string @string = PlayerPrefs.GetString(requestKey);
			try
			{
				App42Log.Console("Processing Offline Request : " + requestKey + " ::: " + @string);
				JsonData jsonData = JsonMapper.ToObject(@string);
				string uri = (string)jsonData["targetUrl"];
				string text = jsonData["bodyMessage"].ToJson();
				string secretKey = (string)jsonData["secretKey"];
				string requestParams = jsonData["signParams"].ToJson();
				string requestParams2 = jsonData["headerParams"].ToJson();
				Dictionary<string, string> paramsFromString = App42OfflineHandler.GetParamsFromString(requestParams2);
				Dictionary<string, string> paramsFromString2 = App42OfflineHandler.GetParamsFromString(requestParams);
				paramsFromString2.Remove("body");
				paramsFromString2.Add("body", text);
				paramsFromString2.Remove("timeStamp");
				paramsFromString2.Add("timeStamp", Util.GetUTCFormattedTimestamp());
				string value = Util.Sign(secretKey, paramsFromString2);
				paramsFromString.Remove("signature");
				paramsFromString.Add("signature", value);
				paramsFromString.Remove("timeStamp");
				paramsFromString.Add("timeStamp", paramsFromString2["timeStamp"]);
				if (!paramsFromString.ContainsKey("fromCache"))
				{
					paramsFromString.Add("fromCache", "true");
				}
				string text2 = (string)jsonData["offlineRequestTime"];
				App42Log.Console("offlineRequestTime :::: " + text2);
				if (!paramsFromString.ContainsKey("offlineRequestTime"))
				{
					paramsFromString.Add("offlineRequestTime", text2);
				}
				App42Log.Console("Executing Offline Request...");
				base.StartCoroutine(this.WaitForRequest(uri, App42OfflineHandler.GetBytesFromString(text), paramsFromString2, paramsFromString));
				PlayerPrefs.DeleteKey(requestKey);
				App42Log.Console(counterKey + " Before : " + PlayerPrefs.GetInt(counterKey));
				PlayerPrefs.SetInt(counterKey, PlayerPrefs.GetInt(counterKey) - 1);
				App42Log.Console(counterKey + " After : " + PlayerPrefs.GetInt(counterKey));
			}
			catch (Exception arg)
			{
				App42Log.Console("Exception When Processing the Request ::: " + arg);
				App42Log.Console("Exception When Processing the Request ::: " + requestKey + " ::: " + @string);
			}
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00006440 File Offset: 0x00004640
		internal bool SaveFailedRequest(string url, byte[] body, Dictionary<string, string> signParams, Dictionary<string, string> headers, string keyForRequest, string keyForCounter)
		{
			if (headers["Custom-Headers"].Equals("POST") || headers["Custom-Headers"].Equals("PUT"))
			{
				if (PlayerPrefs.HasKey(keyForCounter))
				{
					App42Log.Console("Saving request for :: " + headers["Custom-Headers"]);
					int maxRequests = App42API.GetMaxRequests();
					int num = PlayerPrefs.GetInt(keyForCounter);
					if (num < maxRequests)
					{
						num++;
						PlayerPrefs.SetInt(keyForCounter, num);
					}
					else
					{
						PlayerPrefs.DeleteKey(keyForRequest + 1);
						for (int i = 2; i <= num; i++)
						{
							string @string = PlayerPrefs.GetString(keyForRequest + i);
							PlayerPrefs.SetString(keyForRequest + (i - 1), @string);
						}
					}
				}
				else
				{
					App42Log.Console("First Time Saving request for :: " + headers["Custom-Headers"]);
					PlayerPrefs.SetInt(keyForCounter, 1);
				}
				string string2 = Encoding.UTF8.GetString(body, 0, body.Length);
				App42CachedRequest app42CachedRequest = new App42CachedRequest(headers["Custom-Headers"], url, signParams, headers, string2, App42API.app42SecretKey);
				App42Log.Console(string.Concat(new object[]
				{
					"Saving To OffLineStorage :::::::::: ",
					keyForRequest,
					PlayerPrefs.GetInt(keyForCounter),
					" ::::: ",
					app42CachedRequest.ToString()
				}));
				PlayerPrefs.SetString(keyForRequest + PlayerPrefs.GetInt(keyForCounter), app42CachedRequest.ToString());
				PlayerPrefs.Save();
			}
			else
			{
				App42Log.Console("DELETE OR GET REQUEST. NOT SAVING IN OFFLINE STORAGE.");
			}
			return true;
		}

		// Token: 0x06000135 RID: 309 RVA: 0x000065DC File Offset: 0x000047DC
		internal void BuildResponseForOfflineRequest(byte[] body, App42CallBack callBack)
		{
			string strResponse = "";
			string @string = Encoding.UTF8.GetString(body, 0, body.Length);
			JSONNode jsonnode = (JSONObject)JSON.Parse(@string);
			JSONNode jsonnode2 = jsonnode["app42"]["event"];
			if (jsonnode2 != null)
			{
				string text = jsonnode2["methodName"];
				string text2 = jsonnode2["eventName"];
				if (!string.IsNullOrEmpty(text))
				{
					if (text.Equals("_STARTEVENT_"))
					{
						strResponse = string.Concat(new string[]
						{
							"{\"app42\":{\"response\":{\"success\":true,\"event\":{\"lastCommunicatedAt\":\"",
							Util.GetUTCFormattedTimestamp(),
							"\",\"name\":\"",
							text2,
							"\",\"type\":\"SESSION START\"}}}}"
						});
					}
					else if (text.Equals("_ENDEVENT_"))
					{
						strResponse = string.Concat(new string[]
						{
							"{\"app42\":{\"response\":{\"success\":true,\"event\":{\"lastCommunicatedAt\":\"",
							Util.GetUTCFormattedTimestamp(),
							"\",\"name\":\"",
							text2,
							"\",\"type\":\"SESSION END\"}}}}"
						});
					}
					else if (text.Equals("_TRACKEVENT_"))
					{
						strResponse = string.Concat(new string[]
						{
							"{\"app42\":{\"response\":{\"success\":true,\"event\":{\"lastCommunicatedAt\":\"",
							Util.GetUTCFormattedTimestamp(),
							"\",\"name\":\"",
							text2,
							"\",\"type\":\"EVENT\"}}}}"
						});
					}
				}
				else
				{
					strResponse = "{\"app42\":{\"response\":{\"success\":true,\"offlineCached\":true}}}";
				}
			}
			else
			{
				strResponse = "{\"app42\":{\"response\":{\"success\":true,\"offlineCached\":true}}}";
			}
			App42OfflineResponse app42OfflineResponse = new App42OfflineResponse();
			app42OfflineResponse.SetStrResponse(strResponse);
			app42OfflineResponse.SetResponseSuccess(true);
			callBack.OnSuccess(app42OfflineResponse);
		}

		// Token: 0x06000136 RID: 310 RVA: 0x0000676C File Offset: 0x0000496C
		private static Dictionary<string, string> GetParamsFromString(string requestParams)
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			App42JObject app42JObject = new App42JObject(requestParams);
			ArrayList keys = app42JObject.keys;
			foreach (object obj in keys)
			{
				string text = (string)obj;
				if (app42JObject.GetField(text).ToString().StartsWith("{"))
				{
					dictionary.Add(text, app42JObject.GetField(text).ToString());
				}
				else
				{
					dictionary.Add(text, app42JObject.GetField(text).str);
				}
			}
			return dictionary;
		}

		// Token: 0x06000137 RID: 311 RVA: 0x000068D0 File Offset: 0x00004AD0
		internal IEnumerator WaitForRequest(string uri, byte[] body, Dictionary<string, string> signParams, Dictionary<string, string> headers)
		{
			App42Log.Console("Waiting For Next Offline Request...");
			IEnumerator e = this.ExecutePendingRequest(uri, body, signParams, headers);
			while (e.MoveNext())
			{
				object obj = e.Current;
				yield return obj;
			}
			yield break;
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00006AE0 File Offset: 0x00004CE0
		private IEnumerator ExecutePendingRequest(string url, byte[] body, Dictionary<string, string> signParams, Dictionary<string, string> headers)
		{
			WWW www = new WWW(url, body, headers);
			float elapsedTime = 0f;
			while (!www.isDone)
			{
				elapsedTime += Time.deltaTime;
				if (elapsedTime >= 100f)
				{
					break;
				}
				yield return null;
			}
			if (www.isDone)
			{
				App42Log.Console("WWW Request Completed");
				if (www.responseHeaders.ContainsKey("MESSAGE"))
				{
					App42Log.Console(" >>>===EXCEPTION MESSAGE===>>> " + www.responseHeaders["MESSAGE"].ToString());
				}
				else if (!string.IsNullOrEmpty(www.error))
				{
					App42Log.Console("ERROR :::::: " + www.error);
					App42OfflineHandler.GetInstance().SaveFailedRequest(url, body, signParams, headers, "KEY_BACKLOG_REQ_", "KEY_BACKLOG_REQ_COUNTER");
				}
				else
				{
					App42Log.Console("RESPONSE :::::: " + www.text);
				}
			}
			else
			{
				App42Log.Console("WWW Request Failed Again");
				App42OfflineHandler.GetInstance().SaveFailedRequest(url, body, signParams, headers, "KEY_BACKLOG_REQ_", "KEY_BACKLOG_REQ_COUNTER");
			}
			yield break;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00006B1C File Offset: 0x00004D1C
		private static byte[] GetBytesFromString(string str)
		{
			return Encoding.UTF8.GetBytes(str);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00006B36 File Offset: 0x00004D36
		private void OnDestroy()
		{
			App42OfflineHandler.applicationIsQuitting = true;
		}

		// Token: 0x04000072 RID: 114
		private static App42OfflineHandler instance = null;

		// Token: 0x04000073 RID: 115
		private static string lockString = "lock";

		// Token: 0x04000074 RID: 116
		private static bool applicationIsQuitting = false;

		// Token: 0x04000075 RID: 117
		private static bool isRequestsExecuting = false;
	}
}
