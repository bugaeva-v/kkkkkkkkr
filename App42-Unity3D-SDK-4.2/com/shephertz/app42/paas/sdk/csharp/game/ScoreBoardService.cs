using System;
using System.Collections.Generic;
using System.Text;
using com.shephertz.app42.paas.sdk.csharp.connection;
using com.shephertz.app42.paas.sdk.csharp.util;
using SimpleJSON;

namespace com.shephertz.app42.paas.sdk.csharp.game
{
	// Token: 0x02000098 RID: 152
	public class ScoreBoardService : App42Service
	{
		// Token: 0x06000634 RID: 1588 RVA: 0x00025C3B File Offset: 0x00023E3B
		public ScoreBoardService(string apiKey, string secretKey)
		{
			this.apiKey = apiKey;
			this.secretKey = secretKey;
			this.version = "1.0";
			this.resource = "game/scoreboard";
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x00025C68 File Offset: 0x00023E68
		public void SaveUserScore(string gameName, string gameUserName, double gameScore, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(gameName, "Game Name");
			Util.ThrowExceptionIfNullOrBlank(gameUserName, "User Name");
			Util.ThrowExceptionIfNullOrBlank(gameScore, "Game Score");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("\"value\":" + gameScore + ",");
			stringBuilder.Append("\"userName\":\"" + gameUserName + "\"");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"name\":\"" + gameName + "\",");
			stringBuilder2.Append("\"scores\":{\"score\":{" + stringBuilder.ToString() + "}");
			StringBuilder stringBuilder3 = new StringBuilder();
			stringBuilder3.Append("{\"app42\":{\"game\":").Append(stringBuilder2.ToString()).Append("}}}}");
			dictionary.Add("body", stringBuilder3.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource;
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder3.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x00025DC0 File Offset: 0x00023FC0
		public void GetScoresByUser(string gameName, string userName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(gameName, "Game Name");
			Util.ThrowExceptionIfNullOrBlank(userName, "User Name");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("name", gameName);
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
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x00025E94 File Offset: 0x00024094
		public void GetHighestScoreByUser(string gameName, string userName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(gameName, "Game Name");
			Util.ThrowExceptionIfNullOrBlank(userName, "User Name");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("name", gameName);
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
				userName,
				"/highest"
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x00025F74 File Offset: 0x00024174
		public void GetLowestScoreByUser(string gameName, string userName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(gameName, "Game Name");
			Util.ThrowExceptionIfNullOrBlank(userName, "User Name");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("name", gameName);
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
				userName,
				"/lowest"
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x00026054 File Offset: 0x00024254
		public void GetTopRankings(string gameName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(gameName, "Game Name");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("name", gameName);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/",
				gameName,
				"/ranking"
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x0002610C File Offset: 0x0002430C
		public void GetAverageScoreByUser(string gameName, string userName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(gameName, "Game Name");
			Util.ThrowExceptionIfNullOrBlank(userName, "User Name");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("name", gameName);
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
				userName,
				"/average"
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x000261EC File Offset: 0x000243EC
		public void GetTopRankings(string gameName, DateTime startDate, DateTime endDate, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(gameName, "Game Name");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			string utcformattedTimestamp = Util.GetUTCFormattedTimestamp(startDate);
			string utcformattedTimestamp2 = Util.GetUTCFormattedTimestamp(endDate);
			dictionary.Add("name", gameName);
			dictionary.Add("startDate", utcformattedTimestamp);
			dictionary.Add("endDate", utcformattedTimestamp2);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/",
				gameName,
				"/ranking/",
				utcformattedTimestamp,
				"/",
				utcformattedTimestamp2
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x000262E8 File Offset: 0x000244E8
		public void GetLastScoreByUser(string gameName, string userName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(gameName, "Game Name");
			Util.ThrowExceptionIfNullOrBlank(userName, "User Name");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("name", gameName);
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
				userName,
				"/lastscore"
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x000263C8 File Offset: 0x000245C8
		public void GetTopRankingsByGroup(string gameName, IList<string> userList, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(gameName, "Game Name");
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
			dictionary.Add("name", gameName);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/",
				gameName,
				"/group"
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x000264D8 File Offset: 0x000246D8
		public void GetTopNRankings(string gameName, int max, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(gameName, "Game Name");
			Util.ThrowExceptionIfNullOrBlank(max, "Max");
			Util.ValidateMax(max);
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("name", gameName);
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
				"/ranking/",
				max
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x000265C8 File Offset: 0x000247C8
		public void GetUserRanking(string gameName, string userName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(gameName, "Game Name");
			Util.ThrowExceptionIfNullOrBlank(userName, "User Name");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("name", gameName);
			dictionary.Add("userName", userName ?? "");
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
				userName,
				"/ranking"
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x000266B0 File Offset: 0x000248B0
		public void GetLastGameScore(string userName, App42CallBack callBack)
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
				"/",
				userName,
				"/lastgame"
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x00026768 File Offset: 0x00024968
		public void GetTopNRankers(string gameName, int max, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(gameName, "Game Name");
			Util.ThrowExceptionIfNullOrBlank(max, "Max");
			Util.ValidateMax(max);
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("name", gameName);
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
				"/rankers/",
				max
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x00026858 File Offset: 0x00024A58
		public void GetTopNRankers(string gameName, DateTime startDate, DateTime endDate, int max, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(gameName, "Game Name");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			string utcformattedTimestamp = Util.GetUTCFormattedTimestamp(startDate);
			string utcformattedTimestamp2 = Util.GetUTCFormattedTimestamp(endDate);
			dictionary.Add("name", gameName);
			dictionary.Add("startDate", utcformattedTimestamp);
			dictionary.Add("endDate", utcformattedTimestamp2);
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
				"/rankers/",
				utcformattedTimestamp,
				"/",
				utcformattedTimestamp2,
				"/",
				max
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x00026980 File Offset: 0x00024B80
		public void GetTopNRankersByGroup(string gameName, IList<string> userList, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(gameName, "Game Name");
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
			dictionary.Add("name", gameName);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/",
				gameName,
				"/rankers/group"
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x00026A90 File Offset: 0x00024C90
		public void EditScoreValueById(string scoreId, double gameScore, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(scoreId, "ScoreId");
			Util.ThrowExceptionIfNullOrBlank(gameScore, "GameScore");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			StringBuilder stringBuilder2 = new StringBuilder();
			StringBuilder stringBuilder3 = new StringBuilder();
			stringBuilder3.Append("{\"value\":" + gameScore + ",");
			stringBuilder3.Append("\"scoreId\":\"" + scoreId + "\"}");
			stringBuilder2.Append("{\"score\":" + stringBuilder3 + "}");
			stringBuilder.Append("{\"scores\":" + stringBuilder2 + "}");
			StringBuilder stringBuilder4 = new StringBuilder();
			stringBuilder4.Append("{\"app42\":{\"game\":").Append(stringBuilder.ToString()).Append("}}");
			dictionary.Add("body", stringBuilder4.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/editscore";
			RESTConnectorWWW.GetInstance().ExecutePut(url, paramsDics, stringBuilder4.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x00026BE4 File Offset: 0x00024DE4
		public void GetTopRankersFromBuddyGroup(string gameName, string userName, string ownerName, string groupName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(callBack, "callBack");
			Util.ThrowExceptionIfNullOrBlank(gameName, "Game Name");
			Util.ThrowExceptionIfNullOrBlank(userName, "User Name");
			Util.ThrowExceptionIfNullOrBlank(ownerName, "Owner Name");
			Util.ThrowExceptionIfNullOrBlank(groupName, "Group Name");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("name", gameName);
			dictionary.Add("userName", userName);
			dictionary.Add("ownerName", ownerName);
			dictionary.Add("groupName", groupName);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/",
				gameName,
				"/rankers/",
				userName,
				"/group/",
				ownerName,
				"/",
				groupName
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x00026D18 File Offset: 0x00024F18
		public void GetTopNRankersFromFacebook(string gameName, string fbAccessToken, int max, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(gameName, "Game Name");
			Util.ThrowExceptionIfNullOrBlank(fbAccessToken, "fbAccessToken");
			Util.ValidateMax(max);
			base.SetFbAccessToken(fbAccessToken);
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("name", gameName);
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
				"/rankers/facebook/",
				max
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x00026E0C File Offset: 0x0002500C
		public void GetTopNRankersFromFacebook(string gameName, string fbAccessToken, DateTime startDate, DateTime endDate, int max, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(gameName, "Game Name");
			Util.ThrowExceptionIfNullOrBlank(fbAccessToken, "fbAccessToken");
			Util.ThrowExceptionIfNullOrBlank(startDate, "startDate");
			Util.ThrowExceptionIfNullOrBlank(endDate, "endDate");
			Util.ValidateMax(max);
			base.SetFbAccessToken(fbAccessToken);
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			string utcformattedTimestamp = Util.GetUTCFormattedTimestamp(startDate);
			string utcformattedTimestamp2 = Util.GetUTCFormattedTimestamp(endDate);
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("name", gameName);
			dictionary.Add("startDate", utcformattedTimestamp);
			dictionary.Add("endDate", utcformattedTimestamp2);
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
				"/rankers/facebook/",
				utcformattedTimestamp,
				"/",
				utcformattedTimestamp2,
				"/",
				max
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x00026F70 File Offset: 0x00025170
		public void GetTopNTargetRankers(string gameName, int max, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(gameName, "Game Name");
			Util.ThrowExceptionIfNullOrBlank(max, "Max");
			Util.ValidateMax(max);
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("name", gameName);
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
				"/targetedrankers/",
				max
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x00027060 File Offset: 0x00025260
		public void GetUsersWithScoreRange(string gameName, double minScore, double maxScore, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(gameName, "Game Name");
			Util.ThrowExceptionIfNullOrBlank(minScore, "Minimum Score Value");
			Util.ThrowExceptionIfNullOrBlank(maxScore, "Maximum Score Value");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("name", gameName);
			dictionary.Add("minScore", string.Concat(minScore));
			dictionary.Add("maxScore", string.Concat(maxScore));
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new object[]
			{
				this.version,
				"/",
				this.resource,
				"/",
				gameName,
				"/range/",
				minScore,
				"/",
				maxScore
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x00027183 File Offset: 0x00025383
		public void AddJSONObject(string collectionName, Dictionary<string, object> obj)
		{
			this.dbName = App42API.GetDbName();
			this.collectionName = collectionName;
			this.jsonObject = Util.ConvertDictionaryToJson(obj);
		}
	}
}
