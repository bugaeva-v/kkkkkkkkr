using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using com.shephertz.app42.paas.sdk.csharp.abTest;
using com.shephertz.app42.paas.sdk.csharp.achievement;
using com.shephertz.app42.paas.sdk.csharp.avatar;
using com.shephertz.app42.paas.sdk.csharp.bravoboard;
using com.shephertz.app42.paas.sdk.csharp.buddy;
using com.shephertz.app42.paas.sdk.csharp.email;
using com.shephertz.app42.paas.sdk.csharp.gallery;
using com.shephertz.app42.paas.sdk.csharp.game;
using com.shephertz.app42.paas.sdk.csharp.geo;
using com.shephertz.app42.paas.sdk.csharp.gift;
using com.shephertz.app42.paas.sdk.csharp.imageProcessor;
using com.shephertz.app42.paas.sdk.csharp.log;
using com.shephertz.app42.paas.sdk.csharp.message;
using com.shephertz.app42.paas.sdk.csharp.pushNotification;
using com.shephertz.app42.paas.sdk.csharp.recommend;
using com.shephertz.app42.paas.sdk.csharp.review;
using com.shephertz.app42.paas.sdk.csharp.reward;
using com.shephertz.app42.paas.sdk.csharp.session;
using com.shephertz.app42.paas.sdk.csharp.shopping;
using com.shephertz.app42.paas.sdk.csharp.social;
using com.shephertz.app42.paas.sdk.csharp.storage;
using com.shephertz.app42.paas.sdk.csharp.timer;
using com.shephertz.app42.paas.sdk.csharp.upload;
using com.shephertz.app42.paas.sdk.csharp.user;
using CSharpAssemble;
using SimpleJSON;
using UnityEngine;

namespace com.shephertz.app42.paas.sdk.csharp.connection
{
	// Token: 0x02000091 RID: 145
	public class RESTConnectorWWW : MonoBehaviour
	{
		// Token: 0x060005D2 RID: 1490 RVA: 0x000219E4 File Offset: 0x0001FBE4
		private void init()
		{
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x000219E8 File Offset: 0x0001FBE8
		public static RESTConnectorWWW GetInstance()
		{
			if (RESTConnectorWWW.applicationIsQuitting)
			{
				App42Log.Console("[Singleton] Instance already destroyed on application quit. Won't create again - returning null.");
				return null;
			}
			RESTConnectorWWW result;
			lock (RESTConnectorWWW.lockString)
			{
				if (RESTConnectorWWW.restCon == null)
				{
					App42Log.Console(" GetInstance Null ");
					RESTConnectorWWW.gameObj = new GameObject("RESTConnectorWWW");
					RESTConnectorWWW.restCon = RESTConnectorWWW.gameObj.AddComponent<RESTConnectorWWW>();
					Object.DontDestroyOnLoad(RESTConnectorWWW.gameObj);
					RESTConnectorWWW.restCon.init();
					result = RESTConnectorWWW.restCon;
				}
				else
				{
					App42Log.Console(" GetInstance Not Null ");
					result = RESTConnectorWWW.restCon;
				}
			}
			return result;
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x00021A90 File Offset: 0x0001FC90
		public void OnDestroy()
		{
			RESTConnectorWWW.applicationIsQuitting = true;
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x00021A98 File Offset: 0x0001FC98
		public string ExecuteFBOAuth(string url, Dictionary<string, string> paramsDics, Dictionary<string, string> signParams, Dictionary<string, string> headerParams, App42CallBack callBack)
		{
			string text = this.buildQueryString(paramsDics);
			string text2 = UrlEncoder.UrlEncode(url);
			App42Log.Console("QueryString is :" + text);
			string text3 = Config.GetInstance().GetBaseURL() + text2.Replace("+", "%20").Replace("%2f", "/") + text;
			App42Log.Console("GET URI : " + text3);
			string str = "{\"SDKUsability\" : \"FromUnity\"}";
			string result = null;
			if (!headerParams.ContainsKey("Custom-Headers"))
			{
				headerParams.Add("Custom-Headers", "GET");
			}
			base.StartCoroutine(this.WaitForFBRequest(text3, RESTConnectorWWW.GetBytes(str), signParams, headerParams, callBack));
			return result;
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x00021C30 File Offset: 0x0001FE30
		public IEnumerator WaitForFBRequest(string uri, byte[] body, Dictionary<string, string> signParams, Dictionary<string, string> headers, App42CallBack callBack)
		{
			App42Log.Console("Waiting For Facebook Response...");
			yield return new WaitForSeconds((float)SocialService.WAIT_TIME);
			IEnumerator e = this.Execute(uri, body, signParams, headers, callBack);
			while (e.MoveNext())
			{
				object obj = e.Current;
				yield return obj;
			}
			yield break;
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x00021D34 File Offset: 0x0001FF34
		public IEnumerator WaitForRequest(string uri, byte[] body, Dictionary<string, string> signParams, Dictionary<string, string> headers, App42CallBack callBack)
		{
			App42Log.Console("Waiting For Response...");
			IEnumerator e = this.Execute(uri, body, signParams, headers, callBack);
			while (e.MoveNext())
			{
				object obj = e.Current;
				yield return obj;
			}
			yield break;
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x00021D78 File Offset: 0x0001FF78
		public string ExecuteGet(string url, Dictionary<string, string> paramsDics, Dictionary<string, string> signParams, Dictionary<string, string> headerParams, App42CallBack callBack)
		{
			string text = this.buildQueryString(paramsDics);
			string text2 = UrlEncoder.UrlEncode(url);
			App42Log.Console("QueryString is :" + text);
			string text3 = Config.GetInstance().GetBaseURL() + text2.Replace("+", "%20").Replace("%2f", "/") + text;
			App42Log.Console("GET URI : " + text3);
			string str = "{\"SDKUsability\" : \"FromUnity\"}";
			string result = null;
			if (!headerParams.ContainsKey("Custom-Headers"))
			{
				headerParams.Add("Custom-Headers", "GET");
			}
			base.StartCoroutine(this.WaitForRequest(text3, RESTConnectorWWW.GetBytes(str), signParams, headerParams, callBack));
			return result;
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x00021E28 File Offset: 0x00020028
		public void ExecutePost(string url, Dictionary<string, string> paramsDics, string bodyPayLoad, Dictionary<string, string> signParams, Dictionary<string, string> headerParams, App42CallBack callBack)
		{
			string text = this.buildQueryString(paramsDics);
			string text2 = UrlEncoder.UrlEncode(url);
			App42Log.Console(" QueryString is " + text);
			string text3 = Config.GetInstance().GetBaseURL() + text2.Replace("+", "%20").Replace("%2f", "/") + text;
			App42Log.Console("POST URI : " + text3);
			if (!headerParams.ContainsKey("Custom-Headers"))
			{
				headerParams.Add("Custom-Headers", "POST");
			}
			base.StartCoroutine(this.WaitForRequest(text3, RESTConnectorWWW.GetBytes(bodyPayLoad), signParams, headerParams, callBack));
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x00021ED0 File Offset: 0x000200D0
		public void ExecuteEventPost(string url, Dictionary<string, string> paramsDics, string bodyPayLoad, Dictionary<string, string> signParams, Dictionary<string, string> headerParams, App42CallBack callBack)
		{
			string text = this.buildQueryString(paramsDics);
			string text2 = UrlEncoder.UrlEncode(url);
			App42Log.Console(" QueryString is " + text);
			string text3 = Config.GetInstance().GetEventBaseURL() + text2.Replace("+", "%20").Replace("%2f", "/") + text;
			App42Log.Console("POST URI : " + text3);
			if (!headerParams.ContainsKey("Custom-Headers"))
			{
				headerParams.Add("Custom-Headers", "POST");
			}
			base.StartCoroutine(this.WaitForRequest(text3, RESTConnectorWWW.GetBytes(bodyPayLoad), signParams, headerParams, callBack));
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x00021F78 File Offset: 0x00020178
		public string ExecuteEventGet(string url, Dictionary<string, string> paramsDics, Dictionary<string, string> signParams, Dictionary<string, string> headerParams, App42CallBack callBack)
		{
			string text = this.buildQueryString(paramsDics);
			string text2 = UrlEncoder.UrlEncode(url);
			App42Log.Console("QueryString is :" + text);
			string text3 = Config.GetInstance().GetEventBaseURL() + text2.Replace("+", "%20").Replace("%2f", "/") + text;
			App42Log.Console("GET URI : " + text3);
			string str = "{\"SDKUsability\" : \"FromUnity\"}";
			string result = null;
			if (!headerParams.ContainsKey("Custom-Headers"))
			{
				headerParams.Add("Custom-Headers", "GET");
			}
			base.StartCoroutine(this.WaitForRequest(text3, RESTConnectorWWW.GetBytes(str), signParams, headerParams, callBack));
			return result;
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x00022028 File Offset: 0x00020228
		public void ExecuteMultipart(string name, string filePath, Dictionary<string, string> queryParams, Dictionary<string, string> postParams, Dictionary<string, string> signParams, Dictionary<string, string> headerParams, string url, string accept, App42CallBack callBack)
		{
			WWWForm wwwform = new WWWForm();
			foreach (KeyValuePair<string, string> keyValuePair in postParams)
			{
				wwwform.AddField(keyValuePair.Key, keyValuePair.Value);
			}
			Stream input = new FileStream(filePath, FileMode.Open);
			byte[] contents = RESTConnectorWWW.StreamToByteArray(input);
			string extension = Path.GetExtension(filePath);
			string fileName = Path.GetFileName(filePath);
			wwwform.AddBinaryData(name, contents, fileName + "." + extension, "*");
			Dictionary<string, string> headers = wwwform.headers;
			headers.Add("Accept", accept);
			foreach (KeyValuePair<string, string> keyValuePair2 in headers)
			{
				if (!headerParams.ContainsKey(keyValuePair2.Key.ToString()))
				{
					headerParams.Add(keyValuePair2.Key.ToString(), keyValuePair2.Value.ToString());
				}
			}
			string text = this.buildQueryString(queryParams);
			App42Log.Console(" QueryString is " + text);
			string uri = Config.GetInstance().GetBaseURL() + UrlEncoder.UrlEncode(url).Replace("+", "%20").Replace("%2f", "/") + text;
			if (!headerParams.ContainsKey("Custom-Headers"))
			{
				headerParams.Add("Custom-Headers", "POST");
			}
			base.StartCoroutine(this.WaitForMultipart(uri, wwwform.data, signParams, headerParams, callBack));
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x000221D4 File Offset: 0x000203D4
		public static byte[] StreamToByteArray(Stream input)
		{
			byte[] array = new byte[16384];
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				int count;
				while ((count = input.Read(array, 0, array.Length)) > 0)
				{
					memoryStream.Write(array, 0, count);
				}
				result = memoryStream.ToArray();
			}
			return result;
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x00022234 File Offset: 0x00020434
		public void ExecuteMultipart(string name, Stream stream, Dictionary<string, string> queryParams, Dictionary<string, string> postParams, Dictionary<string, string> signParams, Dictionary<string, string> headerParams, string url, string accept, App42CallBack callBack)
		{
			WWWForm wwwform = new WWWForm();
			foreach (KeyValuePair<string, string> keyValuePair in postParams)
			{
				wwwform.AddField(keyValuePair.Key, keyValuePair.Value);
			}
			FileStream fileStream = stream as FileStream;
			byte[] contents = RESTConnectorWWW.StreamToByteArray(stream);
			string extension = Path.GetExtension(fileStream.Name);
			string name2 = fileStream.Name;
			wwwform.AddBinaryData(name, contents, name2 + "." + extension, "*");
			Dictionary<string, string> headers = wwwform.headers;
			headers.Add("Accept", accept);
			foreach (KeyValuePair<string, string> keyValuePair2 in headers)
			{
				if (!headerParams.ContainsKey(keyValuePair2.Key.ToString()))
				{
					headerParams.Add(keyValuePair2.Key.ToString(), keyValuePair2.Value.ToString());
				}
			}
			string text = this.buildQueryString(queryParams);
			App42Log.Console(" QueryString is " + text);
			string uri = Config.GetInstance().GetBaseURL() + UrlEncoder.UrlEncode(url).Replace("+", "%20").Replace("%2f", "/") + text;
			if (!headerParams.ContainsKey("Custom-Headers"))
			{
				headerParams.Add("Custom-Headers", "POST");
			}
			base.StartCoroutine(this.WaitForMultipart(uri, wwwform.data, signParams, headerParams, callBack));
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x000223E4 File Offset: 0x000205E4
		public void ExecutePut(string url, Dictionary<string, string> paramsDics, string bodyPayLoad, Dictionary<string, string> signParams, Dictionary<string, string> headerParams, App42CallBack callBack)
		{
			string text = this.buildQueryString(paramsDics);
			string text2 = UrlEncoder.UrlEncode(url);
			App42Log.Console(" QueryString is " + text);
			string text3 = Config.GetInstance().GetBaseURL() + text2.Replace("+", "%20").Replace("%2f", "/") + text;
			App42Log.Console("PUT URI : " + text3);
			if (!headerParams.ContainsKey("Custom-Headers"))
			{
				headerParams.Add("Custom-Headers", "PUT");
			}
			base.StartCoroutine(this.WaitForRequest(text3, RESTConnectorWWW.GetBytes(bodyPayLoad), signParams, headerParams, callBack));
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x0002248C File Offset: 0x0002068C
		public void ExecuteDelete(string url, Dictionary<string, string> paramsDics, Dictionary<string, string> signParams, Dictionary<string, string> headerParams, App42CallBack callBack)
		{
			string text = this.buildQueryString(paramsDics);
			string text2 = UrlEncoder.UrlEncode(url);
			App42Log.Console(" QueryString is " + text);
			string text3 = Config.GetInstance().GetBaseURL() + text2.Replace("+", "%20").Replace("%2f", "/") + text;
			App42Log.Console("DELETE URI : " + text3);
			if (!headerParams.ContainsKey("Custom-Headers"))
			{
				headerParams.Add("Custom-Headers", "DELETE");
			}
			string str = "{\"SDKUsability\" : \"FromUnity\"}";
			base.StartCoroutine(this.WaitForRequest(text3, RESTConnectorWWW.GetBytes(str), signParams, headerParams, callBack));
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x00022538 File Offset: 0x00020738
		public void ExecuteCustomCode(string url, Dictionary<string, string> paramsDics, string bodyPayLoad, Dictionary<string, string> signParams, Dictionary<string, string> headerParams, App42CallBack callBack)
		{
			string text = this.buildQueryString(paramsDics);
			string text2 = UrlEncoder.UrlEncode(url);
			App42Log.Console(" QueryString is " + text);
			string text3 = Config.GetInstance().GetCustomCodeURL() + text2.Replace("+", "%20").Replace("%2f", "/") + text;
			App42Log.Console("CustomCodeURL URI : " + text3);
			if (!headerParams.ContainsKey("Custom-Headers"))
			{
				headerParams.Add("Custom-Headers", "POST");
			}
			base.StartCoroutine(this.WaitForRequest(text3, RESTConnectorWWW.GetBytes(bodyPayLoad), signParams, headerParams, callBack));
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x000225E0 File Offset: 0x000207E0
		public string buildQueryString(Dictionary<string, string> queryParams)
		{
			StringBuilder stringBuilder = new StringBuilder("?");
			if (queryParams != null)
			{
				foreach (KeyValuePair<string, string> keyValuePair in queryParams)
				{
					stringBuilder.Append(UrlEncoder.UrlEncode(keyValuePair.Key) + "=" + UrlEncoder.UrlEncode(keyValuePair.Value) + "&");
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x0002266C File Offset: 0x0002086C
		private static byte[] GetBytes(string str)
		{
			return Encoding.UTF8.GetBytes(str);
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x00022686 File Offset: 0x00020886
		private void Awake()
		{
			App42Log.Console(" RESTConnectorWWW :  Awake ");
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x00022B30 File Offset: 0x00020D30
		private IEnumerator Execute(string url, byte[] body, Dictionary<string, string> signParams, Dictionary<string, string> headers, App42CallBack callBack)
		{
			string successValue = null;
			string errorValue = null;
			string unityErrorValue = null;
			string isArray = null;
			string resource = null;
			if (!headers.ContainsKey("Content-Type"))
			{
				headers.Add("Content-Type", Config.GetInstance().GetContentType());
			}
			if (!headers.ContainsKey("Accept"))
			{
				headers.Add("Accept", Config.GetInstance().GetAccept());
			}
			if (headers.ContainsKey("resource"))
			{
				resource = headers["resource"];
				headers.Remove("resource");
			}
			if (headers.ContainsKey("isArray"))
			{
				isArray = headers["isArray"];
				headers.Remove("isArray");
			}
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
			try
			{
				if (www.isDone)
				{
					if (!string.IsNullOrEmpty(www.error))
					{
						if (www.responseHeaders.ContainsKey("MESSAGE"))
						{
							errorValue = www.responseHeaders["MESSAGE"];
							App42Log.Console("errorValue : " + errorValue);
							if (!string.IsNullOrEmpty(errorValue))
							{
								this.HandleException(errorValue, callBack);
							}
						}
						else
						{
							unityErrorValue = www.error;
							App42Log.Console(unityErrorValue);
							App42Log.Console("Offline Storage : " + App42API.offlineStorage);
							if (App42API.offlineStorage && App42API.app42SecretKey != null)
							{
								bool flag = App42OfflineHandler.GetInstance().SaveFailedRequest(url, body, signParams, headers, "KEY_OFFLINE_REQ_", "KEY_REQ_COUNTER");
								if (flag)
								{
									App42OfflineHandler.GetInstance().BuildResponseForOfflineRequest(body, callBack);
								}
							}
							else
							{
								callBack.OnException(new App42Exception("WWW Connection Error :: " + www.error));
							}
						}
					}
					else if (JSONNode.Parse(www.text)["app42Fault"] != null)
					{
						this.HandleException(www.text, callBack);
					}
					else
					{
						App42Log.Console("Success Value : " + www.text);
						successValue = www.text;
						if (string.IsNullOrEmpty(errorValue) && !string.IsNullOrEmpty(successValue))
						{
							if (isArray != null && isArray.Equals("true"))
							{
								this.BuildResponseForArrayService(successValue, callBack, resource);
							}
							else if (isArray != null && isArray.Equals("CountRequest"))
							{
								this.BuildResponseForQueryCount(successValue, callBack, resource);
							}
							else
							{
								this.BuildResponseForObjectService(successValue, callBack, resource);
							}
						}
						else
						{
							App42Log.Console("Something went wrong");
						}
						if (App42API.offlineStorage && App42API.app42SecretKey != null)
						{
							base.StartCoroutine(App42OfflineHandler.GetInstance().ProcessPendingRequests("KEY_REQ_COUNTER"));
						}
					}
				}
				yield break;
			}
			catch (Exception ex)
			{
				callBack.OnException(new App42Exception(ex.ToString()));
				yield break;
			}
			yield break;
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x00022B74 File Offset: 0x00020D74
		private void HandleException(string errorValue, App42CallBack callBack)
		{
			JSONNode jsonnode = JSONNode.Parse(errorValue);
			JSONNode jsonnode2 = (JSONObject)jsonnode["app42Fault"];
			string message = jsonnode2.ToString();
			JSONNode jsonnode3 = (JSONObject)jsonnode["app42Fault"];
			if (jsonnode3 != null)
			{
				string str = jsonnode3["appErrorCode"].ToString();
				string str2 = jsonnode3["httpErrorCode"].ToString();
				App42Log.Console(" errorCodes : " + jsonnode3);
				App42Log.Console(" appErrorCode " + str);
				App42Log.Console(" httpErrorCode " + str2);
				if (errorValue.IndexOf("Bad Request") > -1)
				{
					callBack.OnException(new App42BadParameterException(message, jsonnode3["httpErrorCode"].AsInt, jsonnode3["appErrorCode"].AsInt));
				}
				else if (errorValue.IndexOf("Not Found") > -1)
				{
					callBack.OnException(new App42NotFoundException(message, jsonnode3["httpErrorCode"].AsInt, jsonnode3["appErrorCode"].AsInt));
				}
				else if (errorValue.IndexOf("UnAuthorized") > -1)
				{
					callBack.OnException(new App42SecurityException(message, jsonnode3["httpErrorCode"].AsInt, jsonnode3["appErrorCode"].AsInt));
				}
				else if (errorValue.IndexOf("Request Entity Too Large") > -1)
				{
					callBack.OnException(new App42LimitException(message, jsonnode3["httpErrorCode"].AsInt, jsonnode3["appErrorCode"].AsInt));
				}
				else if (errorValue.IndexOf("Internal Server Error") > -1)
				{
					callBack.OnException(new App42Exception(message, jsonnode3["httpErrorCode"].AsInt, jsonnode3["appErrorCode"].AsInt));
				}
				else
				{
					callBack.OnException(new App42Exception(message));
				}
			}
			else
			{
				callBack.OnException(new App42Exception(message));
			}
			if (App42API.offlineStorage && App42API.app42SecretKey != null)
			{
				base.StartCoroutine(App42OfflineHandler.GetInstance().ProcessPendingRequests("KEY_REQ_COUNTER"));
			}
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x00022D8C File Offset: 0x00020F8C
		private void BuildResponseForQueryCount(string successValue, App42CallBack callBacK, string resource)
		{
			object obj = null;
			App42Log.Console("BuildResponseQueryCount resource : " + resource);
			if (resource.Equals("storage"))
			{
				obj = new StorageResponseBuilder().BuildResponse(successValue);
				if (obj is Storage)
				{
					Storage storage = (Storage)obj;
					if (storage.GetRecordCount() > -1L)
					{
						StringBuilder stringBuilder = new StringBuilder();
						stringBuilder.Append("{\"totalRecords\":" + storage.GetRecordCount() + "}");
						StringBuilder stringBuilder2 = new StringBuilder();
						stringBuilder2.Append("{\"app42\":{\"response\":").Append(stringBuilder.ToString()).Append("}}");
						App42Response app42Response = new App42Response();
						app42Response.SetStrResponse(stringBuilder2.ToString());
						app42Response.SetResponseSuccess(true);
						obj = app42Response;
					}
				}
			}
			callBacK.OnSuccess(obj);
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x00022E54 File Offset: 0x00021054
		private void BuildResponseForObjectService(string successValue, App42CallBack callBacK, string resource)
		{
			App42Log.Console("buildResponseForObjectService resource: " + resource);
			object obj = null;
			if (resource.Equals("user"))
			{
				obj = new UserResponseBuilder().BuildResponse(successValue);
				if (obj is User)
				{
					User user = (User)obj;
					if (user.GetSessionId() != null && !user.GetSessionId().Equals(""))
					{
						App42API.RemoveLocalSession();
						App42API.SetUserSessionId(user.GetSessionId());
						if (user.GetUserName() != null && !user.GetUserName().Equals(""))
						{
							App42API.SetLoggedInUser(user.GetUserName());
						}
					}
				}
			}
			else if (resource.Equals("storage"))
			{
				obj = new StorageResponseBuilder().BuildResponse(successValue);
			}
			else if (resource.Equals("upload"))
			{
				obj = new UploadResponseBuilder().BuildResponse(successValue);
			}
			else if (resource.Equals("game"))
			{
				obj = new GameResponseBuilder().BuildResponse(successValue);
			}
			else if (resource.Equals("game/scoreboard"))
			{
				obj = new GameResponseBuilder().BuildResponse(successValue);
			}
			else if (resource.Equals("game/score"))
			{
				obj = new GameResponseBuilder().BuildResponse(successValue);
			}
			else if (resource.Equals("game/reward"))
			{
				obj = new RewardResponseBuilder().BuildResponse(successValue);
			}
			else if (resource.Equals("push"))
			{
				obj = new PushNotificationResponseBuilder().BuildResponse(successValue);
			}
			else if (resource.Equals("buddy"))
			{
				obj = new BuddyResponseBuilder().BuildResponse(successValue);
			}
			else if (resource.Equals("log"))
			{
				obj = new LogResponseBuilder().BuildResponse(successValue);
			}
			else if (resource.Equals("email"))
			{
				obj = new EmailResponseBuilder().BuildResponse(successValue);
			}
			else if (resource.Equals("session"))
			{
				obj = new SessionResponseBuilder().BuildResponse(successValue);
				if (obj is Session)
				{
					Session session = (Session)obj;
					if (session.GetSessionId() != null && !session.GetSessionId().Equals(""))
					{
						App42API.RemoveLocalSession();
						App42API.SetUserSessionId(session.GetSessionId());
						if (session.GetUserName() != null && !session.GetUserName().Equals(""))
						{
							App42API.SetLoggedInUser(session.GetUserName());
						}
					}
				}
			}
			else if (resource.Equals("review"))
			{
				obj = new ReviewResponseBuilder().BuildResponse(successValue);
			}
			else if (resource.Equals("social"))
			{
				obj = new SocialResponseBuilder().BuildResponse(successValue);
				if (obj is Social)
				{
					Social social = (Social)obj;
					if (social.GetFacebookAccessToken() != null && !social.GetFacebookAccessToken().Equals(""))
					{
						App42API.RemoveLocalSession();
						App42API.SetFBAccsssToken(social.GetFacebookAccessToken());
						if (social.GetUserName() != null && !social.GetUserName().Equals(""))
						{
							App42API.SetLoggedInUser(social.GetUserName());
						}
					}
				}
			}
			else if (resource.Equals("customcode"))
			{
				obj = JSONNode.Parse(successValue);
			}
			else if (resource.Equals("achievement"))
			{
				obj = new AchievementResponseBuilder().BuildResponse(successValue);
			}
			else if (resource.Equals("queue"))
			{
				obj = new QueueResponseBuilder().BuildResponse(successValue);
			}
			else if (resource.Equals("avatar"))
			{
				obj = new AvatarResponseBuilder().BuildResponse(successValue);
			}
			else if (resource.Equals("recommend"))
			{
				obj = new RecommenderResponseBuilder().BuildResponse(successValue);
			}
			else if (resource.Equals("cart"))
			{
				obj = new CartResponseBuilder().BuildResponse(successValue);
			}
			else if (resource.Equals("catalogue"))
			{
				obj = new CatalogueResponseBuilder().BuildResponse(successValue);
			}
			else if (resource.Equals("image"))
			{
				obj = new ImageProcessorResponseBuilder().BuildResponse(successValue);
			}
			else if (resource.Equals("geo"))
			{
				obj = new GeoResponseBuilder().BuildResponse(successValue);
			}
			else if (resource.Equals("gallery"))
			{
				obj = new AlbumResponseBuilder().BuildResponse(successValue);
			}
			else if (resource.Equals("abtest"))
			{
				obj = new ABTestResponseBuilder().BuildResponse(successValue);
			}
			else if (resource.Equals("timer"))
			{
				obj = new TimerResponseBuilder().BuildResponse(successValue);
			}
			else if (resource.Equals("gift"))
			{
				obj = new GiftResponseBuilder().BuildResponse(successValue);
			}
			else if (resource.Equals("bravoboard"))
			{
				obj = new BravoBoardResponseBuilder().BuildResponse(successValue);
			}
			else if (resource.Equals("event"))
			{
				obj = successValue;
			}
			callBacK.OnSuccess(obj);
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x00023304 File Offset: 0x00021504
		private void BuildResponseForArrayService(string successValue, App42CallBack callBacK, string resource)
		{
			App42Log.Console("buildResponseForArrayServiceSevice resource: " + resource);
			object response = null;
			if (resource.Equals("user"))
			{
				response = new UserResponseBuilder().BuildArrayResponse(successValue);
			}
			else if (resource.Equals("game"))
			{
				response = new GameResponseBuilder().BuildArrayResponse(successValue);
			}
			else if (resource.Equals("game/scoreboard"))
			{
				response = new GameResponseBuilder().BuildArrayResponse(successValue);
			}
			else if (resource.Equals("game/score"))
			{
				response = new GameResponseBuilder().BuildArrayResponse(successValue);
			}
			else if (resource.Equals("game/reward"))
			{
				response = new RewardResponseBuilder().BuildArrayRewards(successValue);
			}
			else if (resource.Equals("review"))
			{
				response = new ReviewResponseBuilder().BuildArrayResponse(successValue);
			}
			else if (resource.Equals("buddy"))
			{
				response = new BuddyResponseBuilder().BuildArrayResponse(successValue);
			}
			else if (resource.Equals("achievement"))
			{
				response = new AchievementResponseBuilder().BuildArrayResponse(successValue);
			}
			else if (resource.Equals("avatar"))
			{
				response = new AvatarResponseBuilder().BuildArrayResponse(successValue);
			}
			else if (resource.Equals("cart"))
			{
				response = new CartResponseBuilder().BuildArrayResponse(successValue);
			}
			else if (resource.Equals("catalogue"))
			{
				response = new CatalogueResponseBuilder().BuildArrayResponse(successValue);
			}
			else if (resource.Equals("geo"))
			{
				response = new GeoResponseBuilder().BuildArrayResponse(successValue);
			}
			else if (resource.Equals("gallery"))
			{
				response = new AlbumResponseBuilder().BuildArrayResponse(successValue);
			}
			else if (resource.Equals("gift"))
			{
				response = new GiftResponseBuilder().BuildArrayResponse(successValue);
			}
			else if (resource.Equals("push"))
			{
				response = new PushNotificationResponseBuilder().BuildArrayResponse(successValue);
			}
			else if (resource.Equals("bravoboard"))
			{
				response = new BravoBoardResponseBuilder().BuildArrayResponse(successValue);
			}
			callBacK.OnSuccess(response);
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x000235BC File Offset: 0x000217BC
		public IEnumerator WaitForMultipart(string uri, byte[] formData, Dictionary<string, string> signParams, Dictionary<string, string> headers, App42CallBack callBack)
		{
			App42Log.Console("Calling  : Wait For request callback");
			IEnumerator e = this.ExecuteMultipart(uri, formData, signParams, headers, callBack);
			while (e.MoveNext())
			{
				object obj = e.Current;
				yield return obj;
			}
			yield break;
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x00023C6C File Offset: 0x00021E6C
		private IEnumerator ExecuteMultipart(string url, byte[] formData, Dictionary<string, string> signParams, Dictionary<string, string> headers, App42CallBack callBack)
		{
			string errorValue = null;
			string successValue = null;
			string unityErrorValue = null;
			string resource = null;
			string isArray = null;
			if (headers.ContainsKey("resource"))
			{
				resource = headers["resource"];
				headers.Remove("resource");
			}
			if (headers.ContainsKey("isArray"))
			{
				isArray = headers["isArray"];
				headers.Remove("isArray");
			}
			WWW www = new WWW(url, formData, headers);
			float elapsedTime = 0f;
			while (!www.isDone)
			{
				elapsedTime += Time.deltaTime;
				if (elapsedTime >= 1000f)
				{
					break;
				}
				yield return null;
			}
			if (!www.isDone)
			{
				errorValue = "{'Status':'Not Completed'}";
				if (!string.IsNullOrEmpty(www.error))
				{
					errorValue = www.error;
				}
			}
			else if (!string.IsNullOrEmpty(www.error))
			{
				if (www.error.Equals("Rejected because no crossdomain.xml policy file was found"))
				{
					errorValue = "";
				}
				else if (www.error.Contains("Could not resolve host"))
				{
					errorValue = "";
				}
				else if (www.error.Contains("10053"))
				{
					errorValue = "";
				}
				else if (www.error != null && !www.responseHeaders.ContainsKey("MESSAGE"))
				{
					unityErrorValue = "";
				}
				else
				{
					errorValue = www.responseHeaders["MESSAGE"];
				}
			}
			else
			{
				JSONNode jsonnode = JSONNode.Parse(www.text);
				if (jsonnode["app42Fault"] != null)
				{
					App42Log.Console("errorValue : " + www.responseHeaders["MESSAGE"]);
					errorValue = www.responseHeaders["MESSAGE"];
				}
				else
				{
					App42Log.Console("successValue : " + www.text);
					successValue = www.text;
				}
			}
			if (errorValue == null && successValue != null)
			{
				if (isArray != null && isArray.Equals("true"))
				{
					this.BuildResponseForArrayService(successValue, callBack, resource);
				}
				else
				{
					this.BuildResponseForObjectService(successValue, callBack, resource);
				}
				if (App42API.offlineStorage && App42API.app42SecretKey != null)
				{
					base.StartCoroutine(App42OfflineHandler.GetInstance().ProcessPendingRequests("KEY_REQ_COUNTER"));
				}
			}
			else if (errorValue == "")
			{
				callBack.OnException(new App42Exception("Please check your network connection."));
			}
			else if (unityErrorValue == "")
			{
				callBack.OnException(new App42Exception(www.error));
			}
			else
			{
				JSONNode jsonnode2 = JSONNode.Parse(errorValue);
				JSONNode jsonnode3 = (JSONObject)jsonnode2["app42Fault"];
				string message = jsonnode3.ToString();
				JSONNode jsonnode4 = (JSONObject)jsonnode2["app42Fault"];
				if (jsonnode4 != null)
				{
					string str = jsonnode4["appErrorCode"].ToString();
					string str2 = jsonnode4["httpErrorCode"].ToString();
					App42Log.Console(" appErrorCode " + str);
					App42Log.Console(" httpErrorCode " + str2);
					App42Log.Console(unityErrorValue);
					if (errorValue.IndexOf("Bad Request") > -1)
					{
						callBack.OnException(new App42BadParameterException(message, jsonnode4["httpErrorCode"].AsInt, jsonnode4["appErrorCode"].AsInt));
					}
					else if (errorValue.IndexOf("Not Found") > -1)
					{
						callBack.OnException(new App42NotFoundException(message, jsonnode4["httpErrorCode"].AsInt, jsonnode4["appErrorCode"].AsInt));
					}
					else if (errorValue.IndexOf("UnAuthorized") > -1)
					{
						callBack.OnException(new App42SecurityException(message, jsonnode4["httpErrorCode"].AsInt, jsonnode4["appErrorCode"].AsInt));
					}
					else if (errorValue.IndexOf("Request Entity Too Large") > -1)
					{
						callBack.OnException(new App42LimitException(message, jsonnode4["httpErrorCode"].AsInt, jsonnode4["appErrorCode"].AsInt));
					}
					else if (errorValue.IndexOf("Internal Server Error") > -1)
					{
						callBack.OnException(new App42Exception(message, jsonnode4["httpErrorCode"].AsInt, jsonnode4["appErrorCode"].AsInt));
					}
					else
					{
						callBack.OnException(new App42Exception(message));
					}
					if (App42API.offlineStorage && App42API.app42SecretKey != null)
					{
						base.StartCoroutine(App42OfflineHandler.GetInstance().ProcessPendingRequests("KEY_REQ_COUNTER"));
					}
				}
				else
				{
					callBack.OnException(new App42Exception(message));
				}
			}
			yield break;
		}

		// Token: 0x04000264 RID: 612
		private static RESTConnectorWWW restCon = null;

		// Token: 0x04000265 RID: 613
		private static string lockString = "lock";

		// Token: 0x04000266 RID: 614
		private static bool applicationIsQuitting = false;

		// Token: 0x04000267 RID: 615
		private static GameObject gameObj = null;
	}
}
