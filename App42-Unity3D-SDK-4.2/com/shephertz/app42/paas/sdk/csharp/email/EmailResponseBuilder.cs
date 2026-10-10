using System;
using System.Collections.Generic;
using SimpleJSON;

namespace com.shephertz.app42.paas.sdk.csharp.email
{
	// Token: 0x0200003E RID: 62
	public class EmailResponseBuilder : App42ResponseBuilder
	{
		// Token: 0x0600026D RID: 621 RVA: 0x0000D4EC File Offset: 0x0000B6EC
		public Email BuildResponse(string json)
		{
			JSONNode jsonnode = JSONNode.Parse(json);
			JSONNode jsonnode2 = (JSONObject)jsonnode["app42"];
			JSONNode jsonnode3 = (JSONObject)jsonnode2["response"];
			Email email = new Email();
			IList<Email.Configuration> configList = new List<Email.Configuration>();
			email.SetConfigList(configList);
			email.SetStrResponse(json);
			email.SetResponseSuccess(base.IsResponseSuccess(json));
			email.SetTotalRecords(base.GetTotalRecords(json));
			JSONNode jsonnode4 = (JSONObject)jsonnode3["email"];
			if (jsonnode4 == null)
			{
				return email;
			}
			base.BuildObjectFromJSONTree(email, jsonnode4);
			if (jsonnode4["configurations"] == null)
			{
				return email;
			}
			JSONNode jsonnode5 = (JSONObject)jsonnode4["configurations"];
			if (jsonnode5["config"] == null)
			{
				return email;
			}
			if (jsonnode5["config"] is JSONObject)
			{
				JSONNode jsonObj = (JSONObject)jsonnode5["config"];
				Email.Configuration obj = new Email.Configuration(email);
				base.BuildObjectFromJSONTree(obj, jsonObj);
			}
			else
			{
				JSONArray jsonarray = (JSONArray)jsonnode5["config"];
				for (int i = 0; i < jsonarray.Count; i++)
				{
					JSONNode jsonObj2 = (JSONObject)jsonarray[i];
					Email.Configuration obj2 = new Email.Configuration(email);
					base.BuildObjectFromJSONTree(obj2, jsonObj2);
				}
			}
			return email;
		}
	}
}
