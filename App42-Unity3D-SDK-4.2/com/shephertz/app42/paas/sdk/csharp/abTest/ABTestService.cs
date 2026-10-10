using System;
using System.Collections.Generic;
using System.Text;
using com.shephertz.app42.paas.sdk.csharp.connection;
using com.shephertz.app42.paas.sdk.csharp.util;

namespace com.shephertz.app42.paas.sdk.csharp.abTest
{
	// Token: 0x02000008 RID: 8
	public class ABTestService : App42Service
	{
		// Token: 0x0600003E RID: 62 RVA: 0x00002BC7 File Offset: 0x00000DC7
		public ABTestService(string apiKey, string secretKey)
		{
			this.apiKey = apiKey;
			this.secretKey = secretKey;
			this.version = "1.0";
			this.resource = "abtest";
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002BF4 File Offset: 0x00000DF4
		public void GoalAchieved(string testName, string variantName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(testName, "testName");
			Util.ThrowExceptionIfNullOrBlank(variantName, "variantName");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"name\":\"" + testName + "\",");
			stringBuilder.Append("\"variantName\":\"" + variantName + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"abtest\":").Append(stringBuilder.ToString()).Append("}}");
			App42Log.Console(" Json String : " + stringBuilder2.ToString());
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/goal-achieved";
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002D14 File Offset: 0x00000F14
		public void Execute(string testName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(testName, "testName");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"name\":\"" + testName + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"abtest\":").Append(stringBuilder.ToString()).Append("}}");
			App42Log.Console("Json String : " + stringBuilder2.ToString());
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/execute";
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002E10 File Offset: 0x00001010
		public void ExecuteDataDriven(string testName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(testName, "testName");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"name\":\"" + testName + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"abtest\":").Append(stringBuilder.ToString()).Append("}}");
			App42Log.Console(" Json String : " + stringBuilder2.ToString());
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/execute/data-driven";
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002F0C File Offset: 0x0000110C
		public void IsActive(string testName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(testName, "testName");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("testName", testName);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/isActive/",
				testName
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002FBC File Offset: 0x000011BC
		public void GetVariantData(string testName, string variantName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(testName, "testName");
			Util.ThrowExceptionIfNullOrBlank(variantName, "variantName");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("testName", testName);
			dictionary.Add("variantName", variantName);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/get/",
				testName,
				"/variant/",
				variantName
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}
	}
}
