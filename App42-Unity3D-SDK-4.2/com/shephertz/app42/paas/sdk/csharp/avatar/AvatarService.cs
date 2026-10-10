using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using com.shephertz.app42.paas.sdk.csharp.connection;
using com.shephertz.app42.paas.sdk.csharp.util;

namespace com.shephertz.app42.paas.sdk.csharp.avatar
{
	// Token: 0x02000025 RID: 37
	public class AvatarService : App42Service
	{
		// Token: 0x0600015A RID: 346 RVA: 0x00006E02 File Offset: 0x00005002
		public AvatarService(string apiKey, string secretKey)
		{
			this.apiKey = apiKey;
			this.secretKey = secretKey;
			this.version = "1.0";
			this.resource = "avatar";
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00006E30 File Offset: 0x00005030
		public void CreateAvatar(string avatarName, string userName, string filePath, string description, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "userName");
			Util.ThrowExceptionIfNullOrBlank(filePath, "Filepath");
			Util.ThrowExceptionIfNullOrBlank(avatarName, "avatarName");
			Util.ThrowExceptionIfNullOrBlank(description, "description");
			Dictionary<string, string> queryParams = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
			dictionary3.Add("avatarName", avatarName);
			dictionary3.Add("userName", userName);
			dictionary3.Add("description", description);
			foreach (KeyValuePair<string, string> keyValuePair in dictionary3)
			{
				dictionary.Add(keyValuePair.Key, keyValuePair.Value);
			}
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/file/",
				userName
			});
			RESTConnectorWWW.GetInstance().ExecuteMultipart("createAvatar", filePath, queryParams, dictionary3, dictionary, dictionary2, url, Config.GetInstance().GetAccept(), callBack);
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00006F88 File Offset: 0x00005188
		public void CreateAvatar(string avatarName, string userName, Stream inputStream, string description, string extension, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "userName");
			Util.ThrowExceptionIfNullOrBlank(inputStream, "inputStream");
			Util.ThrowExceptionIfNullOrBlank(avatarName, "avatarName");
			Util.ThrowExceptionIfNullOrBlank(description, "description");
			Dictionary<string, string> queryParams = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
			dictionary3.Add("avatarName", avatarName + "." + extension);
			dictionary3.Add("userName", userName);
			dictionary3.Add("description", description);
			foreach (KeyValuePair<string, string> keyValuePair in dictionary3)
			{
				dictionary.Add(keyValuePair.Key, keyValuePair.Value);
			}
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/file/",
				userName
			});
			RESTConnectorWWW.GetInstance().ExecuteMultipart("createAvatar", inputStream, queryParams, dictionary3, dictionary, dictionary2, url, Config.GetInstance().GetAccept(), callBack);
		}

		// Token: 0x0600015D RID: 349 RVA: 0x000070EC File Offset: 0x000052EC
		public void GetAvatarByName(string avatarName, string userName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "userName");
			Util.ThrowExceptionIfNullOrBlank(avatarName, "avatarName");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("avatarName", avatarName);
			dictionary.Add("userName", userName);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/",
				userName,
				"/",
				avatarName
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x0600015E RID: 350 RVA: 0x000071C0 File Offset: 0x000053C0
		public void GetAllAvatars(string userName, App42CallBack callBack)
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
			dictionary2.Add("isArray", "true");
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/",
				userName
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00007280 File Offset: 0x00005480
		public void GetCurrentAvatar(string userName, App42CallBack callBack)
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
				"/current/",
				userName
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00007330 File Offset: 0x00005530
		public void ChangeCurrentAvatar(string userName, string avatarName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "userName");
			Util.ThrowExceptionIfNullOrBlank(avatarName, "avatarName");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"userName\":\"" + userName + "\",");
			stringBuilder.Append("\"avatarName\":\"" + avatarName + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"avatar\":").Append(stringBuilder.ToString()).Append("}}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource;
			RESTConnectorWWW.GetInstance().ExecutePut(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00007434 File Offset: 0x00005634
		public void CreateAvatarFromFacebook(string avatarName, string userName, string accessToken, string description, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(avatarName, "avatarName");
			Util.ThrowExceptionIfNullOrBlank(userName, "userName");
			Util.ThrowExceptionIfNullOrBlank(accessToken, "accessToken");
			Util.ThrowExceptionIfNullOrBlank(description, "description");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"userName\":\"" + userName + "\",");
			stringBuilder.Append("\"avatarName\":\"" + avatarName + "\",");
			stringBuilder.Append("\"accessToken\":\"" + accessToken + "\",");
			stringBuilder.Append("\"description\":\"" + description + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"avatar\":").Append(stringBuilder.ToString()).Append("}}");
			App42Log.Console(" Json String : " + stringBuilder2.ToString());
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/facebook";
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x06000162 RID: 354 RVA: 0x0000759C File Offset: 0x0000579C
		public void CreateAvatarFromWebURL(string avatarName, string userName, string webUrl, string description, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(avatarName, "Avatar Name");
			Util.ThrowExceptionIfNullOrBlank(userName, "User Name");
			Util.ThrowExceptionIfNullOrBlank(description, "Description");
			Util.ThrowExceptionIfNullOrBlank(webUrl, "WebUrl");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"userName\":\"" + userName + "\",");
			stringBuilder.Append("\"avatarName\":\"" + avatarName + "\",");
			stringBuilder.Append("\"webUrl\":\"" + webUrl + "\",");
			stringBuilder.Append("\"description\":\"" + description + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"avatar\":").Append(stringBuilder.ToString()).Append("}}");
			App42Log.Console(" Json String : " + stringBuilder2.ToString());
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/weburl";
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00007704 File Offset: 0x00005904
		public void DeleteAllAvatars(string userName, App42CallBack callBack)
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
				"/deleteAllAvatars/userName/",
				userName
			});
			RESTConnectorWWW.GetInstance().ExecuteDelete(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000164 RID: 356 RVA: 0x000077B4 File Offset: 0x000059B4
		public void DeleteAvatarByName(string userName, string avatarName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "UserName");
			Util.ThrowExceptionIfNullOrBlank(avatarName, "AvatarName");
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			Dictionary<string, string> dictionary2 = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
			dictionary3 = base.Merge(dictionary2, obj);
			dictionary2.Add("userName", userName);
			dictionary.Add("avatarName", avatarName);
			string value = Util.Sign(this.secretKey, dictionary2);
			dictionary3.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/deleteAvatar/userName/",
				userName
			});
			RESTConnectorWWW.GetInstance().ExecuteDelete(url, dictionary, dictionary2, dictionary3, callBack);
		}

		// Token: 0x06000165 RID: 357 RVA: 0x0000787C File Offset: 0x00005A7C
		public void UpdateAvatar(string avatarName, string userName, string newAvatarName, string description, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "userName");
			Util.ThrowExceptionIfNullOrBlank(avatarName, "avatarName");
			Util.ThrowExceptionIfNullOrBlank(newAvatarName, "newAvatarName");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"userName\":\"" + userName + "\",");
			stringBuilder.Append("\"avatarName\":\"" + avatarName + "\",");
			stringBuilder.Append("\"newAvatarName\":\"" + newAvatarName + "\",");
			stringBuilder.Append("\"newDescription\":\"" + description + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"avatar\":").Append(stringBuilder.ToString()).Append("}}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/edit";
			RESTConnectorWWW.GetInstance().ExecutePut(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}
	}
}
