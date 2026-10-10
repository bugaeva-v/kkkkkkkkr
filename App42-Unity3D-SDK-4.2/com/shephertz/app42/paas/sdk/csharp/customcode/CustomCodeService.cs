using System;
using System.Collections.Generic;
using com.shephertz.app42.paas.sdk.csharp.connection;
using com.shephertz.app42.paas.sdk.csharp.util;
using SimpleJSON;

namespace com.shephertz.app42.paas.sdk.csharp.customcode
{
	// Token: 0x0200003B RID: 59
	public class CustomCodeService : App42Service
	{
		// Token: 0x06000256 RID: 598 RVA: 0x0000D2EB File Offset: 0x0000B4EB
		public CustomCodeService(string apiKey, string secretKey)
		{
			this.apiKey = apiKey;
			this.secretKey = secretKey;
			this.version = "1.0";
			this.resource = "customcode";
		}

		// Token: 0x06000257 RID: 599 RVA: 0x0000D318 File Offset: 0x0000B518
		public void RunJavaCode(string name, JSONObject jsonBody, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(name, "name");
			string text;
			if (jsonBody == null)
			{
				text = "{\"customCodeIsNull\":\"true\"}";
			}
			else
			{
				text = jsonBody.ToString();
			}
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			App42Log.Console(" Json String : " + text);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/run/java/" + name;
			RESTConnectorWWW.GetInstance().ExecuteCustomCode(url, paramsDics, text, dictionary, dictionary2, callBack);
		}
	}
}
