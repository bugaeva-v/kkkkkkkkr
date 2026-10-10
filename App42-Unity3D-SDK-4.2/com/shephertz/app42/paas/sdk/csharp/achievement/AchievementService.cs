using System;
using System.Collections.Generic;
using System.Text;
using com.shephertz.app42.paas.sdk.csharp.connection;
using com.shephertz.app42.paas.sdk.csharp.util;

namespace com.shephertz.app42.paas.sdk.csharp.achievement
{
	// Token: 0x0200000B RID: 11
	public class AchievementService : App42Service
	{
		// Token: 0x06000053 RID: 83 RVA: 0x00003257 File Offset: 0x00001457
		public AchievementService(string apiKey, string secretKey)
		{
			this.apiKey = apiKey;
			this.secretKey = secretKey;
			this.version = "1.0";
			this.resource = "achievement";
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00003284 File Offset: 0x00001484
		public void CreateAchievement(string achievementName, string description, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(achievementName, "Achievement Name");
			Util.ThrowExceptionIfNullOrBlank(description, "description");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"name\":\"" + achievementName + "\",");
			stringBuilder.Append("\"description\":\"" + description + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"achievement\":").Append(stringBuilder.ToString()).Append("}}");
			App42Log.Console(" Json String : " + stringBuilder2.ToString());
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource;
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000033A0 File Offset: 0x000015A0
		public void EarnAchievement(string userName, string achievementName, string gameName, string description, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "userName");
			Util.ThrowExceptionIfNullOrBlank(achievementName, "Achievement Name");
			Util.ThrowExceptionIfNullOrBlank(gameName, "gameName");
			Util.ThrowExceptionIfNullOrBlank(description, "description");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"userName\":\"" + userName + "\",");
			stringBuilder.Append("\"name\":\"" + achievementName + "\",");
			stringBuilder.Append("\"gameName\":\"" + gameName + "\",");
			stringBuilder.Append("\"description\":\"" + description + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"achievement\":").Append(stringBuilder.ToString()).Append("}}");
			App42Log.Console(" Json String : " + stringBuilder2.ToString());
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/earn";
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00003508 File Offset: 0x00001708
		public void GetAllAchievementsForUser(string userName, App42CallBack callBack)
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

		// Token: 0x06000057 RID: 87 RVA: 0x000035C8 File Offset: 0x000017C8
		public void GetAllAchievementsForUserInGame(string userName, string gameName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "userName");
			Util.ThrowExceptionIfNullOrBlank(gameName, "gameName");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("userName", userName);
			dictionary.Add("gameName", gameName);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			dictionary2.Add("isArray", "true");
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/",
				userName,
				"/",
				gameName
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000036AC File Offset: 0x000018AC
		public void GetAllAchievements(App42CallBack callBack)
		{
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/all";
			dictionary2.Add("isArray", "true");
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00003738 File Offset: 0x00001938
		public void GetAchievementByName(string achievementName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(achievementName, "Achievement Name");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("achievementName", achievementName);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/achievementName/",
				achievementName
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000037E8 File Offset: 0x000019E8
		public void GetUsersAchievement(string achievementName, string gameName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(achievementName, "Achievement Name");
			Util.ThrowExceptionIfNullOrBlank(gameName, "gameName");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("achievementName", achievementName);
			dictionary.Add("game", gameName);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			dictionary2.Add("isArray", "true");
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/users/",
				achievementName,
				"/",
				gameName
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000038CC File Offset: 0x00001ACC
		public void DeleteUserAchievement(string gameName, string achievementName, string userName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(gameName, "GameName");
			Util.ThrowExceptionIfNullOrBlank(userName, "UserName");
			Util.ThrowExceptionIfNullOrBlank(achievementName, "AchievementName");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("gameName", gameName);
			dictionary.Add("achievementName", achievementName);
			dictionary.Add("userName", userName);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/deleteAchievement/",
				gameName,
				"/",
				achievementName,
				"/",
				userName
			});
			RESTConnectorWWW.GetInstance().ExecuteDelete(url, paramsDics, dictionary, dictionary2, callBack);
		}
	}
}
