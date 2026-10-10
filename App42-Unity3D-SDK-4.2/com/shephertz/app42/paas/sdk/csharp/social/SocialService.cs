using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using com.shephertz.app42.paas.sdk.csharp.connection;
using com.shephertz.app42.paas.sdk.csharp.util;
using SimpleJSON;
using UnityEngine;

namespace com.shephertz.app42.paas.sdk.csharp.social
{
	// Token: 0x020000B4 RID: 180
	public class SocialService : App42Service
	{
		// Token: 0x06000796 RID: 1942 RVA: 0x0002A368 File Offset: 0x00028568
		public SocialService(string apiKey, string secretKey)
		{
			this.apiKey = apiKey;
			this.secretKey = secretKey;
			this.version = "1.0";
			this.resource = "social";
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x0002A3B8 File Offset: 0x000285B8
		public void LinkUserFacebookAccount(string userName, string accessToken, string appId, string appSecret, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "userName");
			Util.ThrowExceptionIfNullOrBlank(appId, "appId");
			Util.ThrowExceptionIfNullOrBlank(appSecret, "appSecret");
			Util.ThrowExceptionIfNullOrBlank(accessToken, "accessToken");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"userName\":\"" + userName + "\",");
			stringBuilder.Append("\"accessToken\":\"" + accessToken + "\",");
			stringBuilder.Append("\"appId\":\"" + appId + "\",");
			stringBuilder.Append("\"appSecret\":\"" + appSecret + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"social\":").Append(stringBuilder.ToString()).Append("}}");
			App42Log.Console(" Json String : " + stringBuilder2.ToString());
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/facebook/linkuser";
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x0002A520 File Offset: 0x00028720
		public void LinkUserFacebookAccount(string userName, string accessToken, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "userName");
			Util.ThrowExceptionIfNullOrBlank(accessToken, "accessToken");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"userName\":\"" + userName + "\",");
			stringBuilder.Append("\"accessToken\":\"" + accessToken + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"social\":").Append(stringBuilder.ToString()).Append("}}");
			App42Log.Console(" Json String : " + stringBuilder2.ToString());
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/facebook/linkuser/accesscredentials";
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x0002A640 File Offset: 0x00028840
		public void UpdateFacebookStatus(string userName, string status, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "userName");
			Util.ThrowExceptionIfNullOrBlank(status, "status");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"userName\":\"" + userName + "\",");
			stringBuilder.Append("\"status\":\"" + status + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"social\":").Append(stringBuilder.ToString()).Append("}}");
			App42Log.Console(" Json String : " + stringBuilder2.ToString());
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/facebook/updatestatus";
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x0002A760 File Offset: 0x00028960
		public void LinkUserTwitterAccount(string userName, string accessToken, string accessTokenSecret, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "userName");
			Util.ThrowExceptionIfNullOrBlank(accessToken, "accessToken");
			Util.ThrowExceptionIfNullOrBlank(accessTokenSecret, "accessTokenSecret");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"userName\":\"" + userName + "\",");
			stringBuilder.Append("\"accessToken\":\"" + accessToken + "\",");
			stringBuilder.Append("\"accessTokenSecret\":\"" + accessTokenSecret + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"social\":").Append(stringBuilder.ToString()).Append("}}");
			App42Log.Console(" Json String : " + stringBuilder2.ToString());
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/twitter/linkuser/accesscredentials";
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x0002A8A4 File Offset: 0x00028AA4
		public void LinkUserTwitterAccount(string userName, string accessToken, string accessTokenSecret, string consumerKey, string consumerSecret, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "userName");
			Util.ThrowExceptionIfNullOrBlank(consumerKey, "consumerKey");
			Util.ThrowExceptionIfNullOrBlank(consumerSecret, "consumerSecret");
			Util.ThrowExceptionIfNullOrBlank(accessToken, "accessToken");
			Util.ThrowExceptionIfNullOrBlank(accessTokenSecret, "accessTokenSecret");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"userName\":\"" + userName + "\",");
			stringBuilder.Append("\"consumerKey\":\"" + consumerKey + "\",");
			stringBuilder.Append("\"consumerSecret\":\"" + consumerSecret + "\",");
			stringBuilder.Append("\"accessToken\":\"" + accessToken + "\",");
			stringBuilder.Append("\"accessTokenSecret\":\"" + accessTokenSecret + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"social\":").Append(stringBuilder.ToString()).Append("}}");
			App42Log.Console(" Json String : " + stringBuilder2.ToString());
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/twitter/linkuser";
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x0002AA30 File Offset: 0x00028C30
		public void UpdateTwitterStatus(string userName, string status, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "userName");
			Util.ThrowExceptionIfNullOrBlank(status, "status");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"userName\":\"" + userName + "\",");
			stringBuilder.Append("\"status\":\"" + status + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"social\":").Append(stringBuilder.ToString()).Append("}}");
			App42Log.Console(" Json String : " + stringBuilder2.ToString());
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/twitter/updatestatus";
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x0002AB50 File Offset: 0x00028D50
		public void LinkUserLinkedInAccount(string userName, string accessToken, string accessTokenSecret, string apiKey, string secretKey, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "userName");
			Util.ThrowExceptionIfNullOrBlank(accessToken, "accessToken");
			Util.ThrowExceptionIfNullOrBlank(accessTokenSecret, "accessTokenSecret");
			Util.ThrowExceptionIfNullOrBlank(apiKey, "apiKey");
			Util.ThrowExceptionIfNullOrBlank(secretKey, "secretKey");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"userName\":\"" + userName + "\",");
			stringBuilder.Append("\"apiKey\":\"" + apiKey + "\",");
			stringBuilder.Append("\"secretKey\":\"" + secretKey + "\",");
			stringBuilder.Append("\"accessToken\":\"" + accessToken + "\",");
			stringBuilder.Append("\"accessTokenSecret\":\"" + accessTokenSecret + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"social\":").Append(stringBuilder.ToString()).Append("}}");
			App42Log.Console(" Json String : " + stringBuilder2.ToString());
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/linkedin/linkuser";
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x0002ACDC File Offset: 0x00028EDC
		public void LinkUserLinkedInAccount(string userName, string accessToken, string accessTokenSecret, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "userName");
			Util.ThrowExceptionIfNullOrBlank(accessToken, "accessToken");
			Util.ThrowExceptionIfNullOrBlank(accessTokenSecret, "accessTokenSecret");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"userName\":\"" + userName + "\",");
			stringBuilder.Append("\"accessToken\":\"" + accessToken + "\",");
			stringBuilder.Append("\"accessTokenSecret\":\"" + accessTokenSecret + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"social\":").Append(stringBuilder.ToString()).Append("}}");
			App42Log.Console(" Json String : " + stringBuilder2.ToString());
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/linkedin/linkuser/accesscredentials";
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x0002AE20 File Offset: 0x00029020
		public void UpdateLinkedInStatus(string userName, string status, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "userName");
			Util.ThrowExceptionIfNullOrBlank(status, "status");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"userName\":\"" + userName + "\",");
			stringBuilder.Append("\"status\":\"" + status + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"social\":").Append(stringBuilder.ToString()).Append("}}");
			App42Log.Console(" Json String : " + stringBuilder2.ToString());
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/linkedin/updatestatus";
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x0002AF40 File Offset: 0x00029140
		public void UpdateSocialStatusForAll(string userName, string status, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "userName");
			Util.ThrowExceptionIfNullOrBlank(status, "status");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"userName\":\"" + userName + "\",");
			stringBuilder.Append("\"status\":\"" + status + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"social\":").Append(stringBuilder.ToString()).Append("}}");
			App42Log.Console(" Json String : " + stringBuilder2.ToString());
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/social/updatestatus/all";
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x0002B060 File Offset: 0x00029260
		public void GetFacebookFriendsFromLinkUser(string userName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "UserName");
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
				"/facebook/friends/",
				userName
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x0002B110 File Offset: 0x00029310
		public void GetFacebookFriendsFromAccessToken(string accessToken, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(accessToken, "AccessToken");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("accessToken", accessToken);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/facebook/friends/OAuth/",
				accessToken
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x0002B1C0 File Offset: 0x000293C0
		public void FacebookLinkPost(string accessToken, string link, string message, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(accessToken, "Access Token");
			Util.ThrowExceptionIfNullOrBlank(link, "Link");
			Util.ThrowExceptionIfNullOrBlank(message, "Message");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"link\":\"" + link + "\",");
			stringBuilder.Append("\"accessToken\":\"" + accessToken + "\",");
			stringBuilder.Append("\"message\":\"" + message + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"social\":").Append(stringBuilder.ToString()).Append("}}");
			App42Log.Console(" Json String : " + stringBuilder2.ToString());
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/facebook/publishstream";
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x0002B304 File Offset: 0x00029504
		public void FacebookLinkPostWithCustomThumbnail(string accessToken, string link, string message, string pictureUrl, string name, string description, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(accessToken, "Access Token");
			Util.ThrowExceptionIfNullOrBlank(link, "Link");
			Util.ThrowExceptionIfNullOrBlank(message, "Message");
			Util.ThrowExceptionIfNullOrBlank(pictureUrl, "PictureUrl");
			Util.ThrowExceptionIfNullOrBlank(name, "File Name");
			Util.ThrowExceptionIfNullOrBlank(description, "Description");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"link\":\"" + link + "\",");
			stringBuilder.Append("\"accessToken\":\"" + accessToken + "\",");
			stringBuilder.Append("\"message\":\"" + message + "\",");
			stringBuilder.Append("\"picture\":\"" + pictureUrl + "\",");
			stringBuilder.Append("\"name\":\"" + name + "\",");
			stringBuilder.Append("\"description\":\"" + description + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"social\":").Append(stringBuilder.ToString()).Append("}}");
			App42Log.Console(" Json String : " + stringBuilder2.ToString());
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/facebook/publishstream";
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x0002B4B8 File Offset: 0x000296B8
		public void GetFacebookProfile(string accessToken, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(accessToken, "AccessToken");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("accessToken", accessToken);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/facebook/me/OAuth/",
				accessToken
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x0002B568 File Offset: 0x00029768
		public void GetFacebookProfilesFromIds(IList<string> facebookIds, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(facebookIds, "Facebook Ids");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			JSONArray jsonarray = new JSONArray();
			for (int i = 0; i < facebookIds.Count; i++)
			{
				string text = facebookIds[i];
				jsonarray.Add(text.ToString());
			}
			dictionary2.Add("userList", jsonarray.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/facebook/ids";
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x0002B638 File Offset: 0x00029838
		public void FacebookPublishStream(string accessToken, string name, string filePath, string message, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(accessToken, "Access Token");
			Util.ThrowExceptionIfNullOrBlank(name, "File Name");
			Util.ThrowExceptionIfNullOrBlank(filePath, "Filepath");
			Util.ThrowExceptionIfNullOrBlank(message, "Message");
			Dictionary<string, string> queryParams = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
			dictionary3.Add("name", name);
			dictionary3.Add("accessToken", accessToken);
			dictionary3.Add("message", message);
			foreach (KeyValuePair<string, string> keyValuePair in dictionary3)
			{
				dictionary.Add(keyValuePair.Key, keyValuePair.Value);
			}
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/facebook/wallpost";
			RESTConnectorWWW.GetInstance().ExecuteMultipart("uploadFile", filePath, queryParams, dictionary3, dictionary, dictionary2, url, Config.GetInstance().GetAccept(), callBack);
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x0002B770 File Offset: 0x00029970
		public void FacebookPublishStream(string accessToken, string name, Stream inputStream, string message, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(accessToken, "Access Token");
			Util.ThrowExceptionIfNullOrBlank(name, "File Name");
			Util.ThrowExceptionIfNullOrBlank(inputStream, "InputStream");
			Util.ThrowExceptionIfNullOrBlank(message, "Message");
			Dictionary<string, string> queryParams = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
			dictionary3.Add("name", name);
			dictionary3.Add("accessToken", accessToken);
			dictionary3.Add("message", message);
			foreach (KeyValuePair<string, string> keyValuePair in dictionary3)
			{
				dictionary.Add(keyValuePair.Key, keyValuePair.Value);
			}
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/facebook/wallpost";
			RESTConnectorWWW.GetInstance().ExecuteMultipart("uploadFile", inputStream, queryParams, dictionary3, dictionary, dictionary2, url, Config.GetInstance().GetAccept(), callBack);
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x0002B8A8 File Offset: 0x00029AA8
		public void DoFBOAuthAndGetToken(string fbAppID, string[] permission, bool inviteRequest, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(fbAppID, "fbAppID");
			try
			{
				string str = DateTime.Now.ToString("yyyyMMddHHmmss");
				string text = str + FacebookService.GetRandomHexString(this.RANDOM_LENGTH);
				App42Log.Console("Starting OAuth for " + text);
				Dictionary<string, string> dictionary = base.PopulateSignParams();
				Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
				Dictionary<string, string> headerParams = new Dictionary<string, string>();
				headerParams = base.Merge(dictionary, obj);
				dictionary.Add("sessionToken", text ?? "");
				dictionary.Add("appRequest", string.Concat(inviteRequest));
				string str2 = Util.Sign(this.secretKey, dictionary);
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append("{\"apiKey\":\"" + this.apiKey + "\",");
				stringBuilder.Append("\"version\":\"" + this.version + "\",");
				stringBuilder.Append("\"timeStamp\":\"" + dictionary["timeStamp"] + "\",");
				stringBuilder.Append("\"sessionToken\":\"" + text + "\",");
				stringBuilder.Append("\"appRequest\":\"" + inviteRequest + "\",");
				stringBuilder.Append("\"signature\":\"" + str2 + "\"}");
				StringBuilder stringBuilder2 = new StringBuilder();
				stringBuilder2.Append("{\"app42\":").Append(stringBuilder.ToString()).Append("}");
				string text2 = Uri.EscapeDataString(stringBuilder2.ToString());
				App42Log.Console("Body For OAUTH :: " + text2);
				string text3 = this.fbOAuthURL + "?&response_type=code";
				if (permission != null && permission.Length > 0)
				{
					StringBuilder stringBuilder3 = new StringBuilder("&scope=");
					for (int i = 0; i < permission.Length; i++)
					{
						if (permission[i] != null && !permission[i].ToString().Equals(""))
						{
							FacebookService.CheckPermissions(permission[i]);
						}
						stringBuilder3.Append(permission[i]);
						if (i != permission.Length - 1)
						{
							stringBuilder3.Append(',');
						}
					}
					text3 += stringBuilder3.ToString();
				}
				if (!SocialService.isFBOAuthRunning)
				{
					this.fbService = new FacebookService(callBack);
					this.HandlePlatformRequest(fbAppID, text2, text3, headerParams, dictionary, text, inviteRequest, this.fbService);
				}
			}
			catch (App42Exception ex)
			{
				SocialService.isFBOAuthRunning = false;
				SocialService.isStoppedFBOAuth = true;
				callBack.OnException(ex);
			}
			catch (Exception ex2)
			{
				SocialService.isFBOAuthRunning = false;
				SocialService.isStoppedFBOAuth = true;
				callBack.OnException(ex2);
			}
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x0002BB68 File Offset: 0x00029D68
		public void HandlePlatformRequest(string fbAppID, string stateStr, string returnToURI, Dictionary<string, string> headerParams, Dictionary<string, string> signParams, string sessionToken, bool inviteRequest, FacebookService callBack)
		{
			App42Log.Console(": Initiating Platform Request :");
			string text = string.Concat(new string[]
			{
				"http://m.facebook.com/dialog/oauth/?display=touch&client_id=",
				fbAppID,
				"&state=",
				stateStr,
				"&redirect_uri=",
				returnToURI
			});
			App42Log.Console("FB OAuth URL : " + text);
			Application.OpenURL(text);
			callBack.counter = 1;
			SocialService.isFBOAuthRunning = true;
			SocialService.isStoppedFBOAuth = false;
			Dictionary<string, string> dictionary = new Dictionary<string, string>(signParams);
			string text2 = string.Concat(5);
			if (signParams.ContainsKey("timeOutInSeconds"))
			{
				signParams.Remove("timeOutInSeconds");
			}
			signParams.Add("timeOutInSeconds", text2);
			string text3 = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/facebook/getFeaturePhoneAccessToken/",
				sessionToken,
				"/",
				text2
			});
			if (signParams.ContainsKey("appRequest"))
			{
				signParams.Remove("appRequest");
			}
			string value = Util.Sign(this.secretKey, signParams);
			if (headerParams.ContainsKey("signature"))
			{
				headerParams.Remove("signature");
			}
			headerParams.Add("signature", value);
			callBack.SetParams("resourceURL", text3);
			callBack.SetParams("queryParams", dictionary);
			callBack.SetParams("headerParams", headerParams);
			RESTConnectorWWW.GetInstance().ExecuteFBOAuth(text3, dictionary, signParams, headerParams, callBack);
		}

		// Token: 0x040002C4 RID: 708
		private int RANDOM_LENGTH = 10;

		// Token: 0x040002C5 RID: 709
		public static bool isStopRequestFBOAuth = false;

		// Token: 0x040002C6 RID: 710
		public static bool isStoppedFBOAuth = true;

		// Token: 0x040002C7 RID: 711
		public static bool isFBOAuthRunning = false;

		// Token: 0x040002C8 RID: 712
		public static int MAX_ACCESSTOKEN_ATTEMPT = 30;

		// Token: 0x040002C9 RID: 713
		public static int WAIT_TIME = 3;

		// Token: 0x040002CA RID: 714
		private string fbOAuthURL = Config.GetInstance().GetFbOAuthURL();

		// Token: 0x040002CB RID: 715
		private FacebookService fbService;
	}
}
