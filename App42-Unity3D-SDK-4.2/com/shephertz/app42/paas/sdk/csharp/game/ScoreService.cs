using System;
using System.Collections.Generic;
using System.Text;
using com.shephertz.app42.paas.sdk.csharp.connection;
using com.shephertz.app42.paas.sdk.csharp.util;

namespace com.shephertz.app42.paas.sdk.csharp.game
{
	// Token: 0x02000099 RID: 153
	public class ScoreService : App42Service
	{
		// Token: 0x0600064B RID: 1611 RVA: 0x000271A3 File Offset: 0x000253A3
		public ScoreService(string apiKey, string secretKey)
		{
			this.apiKey = apiKey;
			this.secretKey = secretKey;
			this.version = "1.0";
			this.resource = "game/score";
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x000271D0 File Offset: 0x000253D0
		public void AddScore(string gameName, string gameUserName, double gameScore, App42CallBack callBack)
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
			stringBuilder.Append("\"value\":\"" + gameScore + "\",");
			stringBuilder.Append("\"userName\":\"" + gameUserName + "\"");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("\"name\":\"" + gameName + "\",");
			stringBuilder2.Append("\"scores\":{\"score\":{" + stringBuilder.ToString() + "}");
			StringBuilder stringBuilder3 = new StringBuilder();
			stringBuilder3.Append("{\"app42\":{\"game\":{").Append(stringBuilder2.ToString()).Append("}}}}");
			dictionary.Add("body", stringBuilder3.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/add";
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder3.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x0002732C File Offset: 0x0002552C
		public void DeductScore(string gameName, string gameUserName, double gameScore, App42CallBack callBack)
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
			string url = this.version + "/" + this.resource + "/deduct";
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder3.ToString(), dictionary, dictionary2, callBack);
		}
	}
}
