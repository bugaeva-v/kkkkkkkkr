using System;
using System.Collections.Generic;
using System.Text;
using com.shephertz.app42.paas.sdk.csharp.connection;
using com.shephertz.app42.paas.sdk.csharp.util;
using SimpleJSON;

namespace com.shephertz.app42.paas.sdk.csharp.reward
{
	// Token: 0x02000097 RID: 151
	public class RewardService : App42Service
	{
		// Token: 0x06000627 RID: 1575 RVA: 0x0002505E File Offset: 0x0002325E
		public RewardService(string apiKey, string secretKey)
		{
			this.apiKey = apiKey;
			this.secretKey = secretKey;
			this.version = "1.0";
			this.resource = "game/reward";
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x0002508C File Offset: 0x0002328C
		public void CreateReward(string rewardName, string rewardDescription, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(rewardName, "Reward Name");
			Util.ThrowExceptionIfNullOrBlank(rewardDescription, "Reward Description");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"name\":\"" + rewardName + "\",");
			stringBuilder.Append("\"description\":\"" + rewardDescription + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"rewards\":{\"reward\":").Append(stringBuilder.ToString()).Append("}}}}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource;
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x00025190 File Offset: 0x00023390
		public void GetAllRewards(App42CallBack callBack)
		{
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource;
			dictionary2.Add("isArray", "true");
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x00025214 File Offset: 0x00023414
		public void GetRewardByName(string rewardName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(rewardName, "Reward Name");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("name", rewardName);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/",
				rewardName
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x000252C4 File Offset: 0x000234C4
		public void EarnRewards(string gameName, string gameUserName, string rewardName, double rewardPoints, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(gameName, "Game Name");
			Util.ThrowExceptionIfNullOrBlank(gameUserName, "User Name");
			Util.ThrowExceptionIfNullOrBlank(rewardName, "Reward Name");
			Util.ThrowExceptionIfNullOrBlank(rewardPoints, "Reward Points");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"gameName\":\"" + gameName + "\",");
			stringBuilder.Append("\"userName\":\"" + gameUserName + "\",");
			stringBuilder.Append("\"name\":\"" + rewardName + "\",");
			stringBuilder.Append("\"points\":" + rewardPoints + "}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"rewards\":{\"reward\":").Append(stringBuilder.ToString()).Append("}}}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/earn";
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x00025420 File Offset: 0x00023620
		public void RedeemRewards(string gameName, string gameUserName, string rewardName, double rewardPoints, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(gameName, "Game Name");
			Util.ThrowExceptionIfNullOrBlank(gameUserName, "User Name");
			Util.ThrowExceptionIfNullOrBlank(rewardName, "Reward Name");
			Util.ThrowExceptionIfNullOrBlank(rewardPoints, "Reward Points");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"gameName\":\"" + gameName + "\",");
			stringBuilder.Append("\"userName\":\"" + gameUserName + "\",");
			stringBuilder.Append("\"name\":\"" + rewardName + "\",");
			stringBuilder.Append("\"points\":" + rewardPoints + "}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"rewards\":{\"reward\":").Append(stringBuilder.ToString()).Append("}}}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/redeem";
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x0002557C File Offset: 0x0002377C
		public void GetGameRewardPointsForUser(string gameName, string userName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(gameName, "Game Name");
			Util.ThrowExceptionIfNullOrBlank(userName, "User Name");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("gameName", gameName);
			dictionary.Add("userName", userName);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/",
				gameName,
				"/",
				userName
			});
			dictionary2.Add("isArray", "true");
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x00025660 File Offset: 0x00023860
		public void GetAllRewards(int max, int offset, App42CallBack callBack)
		{
			Util.ValidateMax(max);
			Util.ThrowExceptionIfNullOrBlank(max, "Max");
			Util.ThrowExceptionIfNullOrBlank(offset, "Offset");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("max", string.Concat(max));
			dictionary.Add("offset", string.Concat(offset));
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new object[]
			{
				this.version,
				"/",
				this.resource,
				"/paging/",
				max,
				"/",
				offset
			});
			dictionary2.Add("isArray", "true");
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x00025774 File Offset: 0x00023974
		public void GetAllRewardsCount(App42CallBack callBack)
		{
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/count";
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x000257F0 File Offset: 0x000239F0
		public void GetTopNRewardEarners(string gameName, string rewardName, int max, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(gameName, "Game Name");
			Util.ThrowExceptionIfNullOrBlank(rewardName, "Reward Name");
			Util.ThrowExceptionIfNullOrBlank(max, "Max");
			Util.ValidateMax(max);
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("gameName", gameName);
			dictionary.Add("rewardName", rewardName);
			dictionary.Add("max", string.Concat(max));
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new object[]
			{
				this.version,
				"/",
				this.resource,
				"/",
				gameName,
				"/",
				rewardName,
				"/",
				max
			});
			dictionary2.Add("isArray", "true");
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x00025918 File Offset: 0x00023B18
		public void GetAllRewardsByUser(string userName, string rewardName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "User Name");
			Util.ThrowExceptionIfNullOrBlank(rewardName, "Reward Name");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("userName", userName);
			dictionary.Add("rewardName", rewardName);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/",
				userName,
				"/points/",
				rewardName
			});
			dictionary2.Add("isArray", "true");
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x000259FC File Offset: 0x00023BFC
		public void GetTopNRewardEarnersByGroup(string gameName, string rewardName, IList<string> userList, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(gameName, "Game Name");
			Util.ThrowExceptionIfNullOrBlank(rewardName, "Reward Name");
			Util.ThrowExceptionIfNullOrBlank(userList, "UserList");
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			JSONArray jsonarray = new JSONArray();
			for (int i = 0; i < userList.Count; i++)
			{
				string text = userList[i];
				jsonarray.Add(text.ToString());
			}
			dictionary.Add("userList", jsonarray.ToString());
			Dictionary<string, string> paramsDics = new Dictionary<string, string>(dictionary);
			dictionary.Add("gameName", gameName);
			dictionary.Add("rewardName", rewardName);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/",
				gameName,
				"/",
				rewardName,
				"/group/points"
			});
			dictionary2.Add("isArray", "true");
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x00025B40 File Offset: 0x00023D40
		public void GetUserRankingOnReward(string gameName, string rewardName, string userName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(gameName, "Game Name");
			Util.ThrowExceptionIfNullOrBlank(rewardName, "Reward Name");
			Util.ThrowExceptionIfNullOrBlank(userName, "userName");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("gameName", gameName);
			dictionary.Add("rewardName", rewardName);
			dictionary.Add("userName", userName);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/",
				gameName,
				"/",
				rewardName,
				"/rank/",
				userName
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}
	}
}
