using System;
using System.Collections.Generic;
using System.Reflection;
using SimpleJSON;

namespace com.shephertz.app42.paas.sdk.csharp
{
	// Token: 0x02000005 RID: 5
	public class App42ResponseBuilder
	{
		// Token: 0x06000017 RID: 23 RVA: 0x00002128 File Offset: 0x00000328
		public void BuildObjectFromJSONTree(object obj, JSONNode jsonObj)
		{
			JSONNode jsonnode = (JSONObject)jsonObj;
			foreach (KeyValuePair<string, JSONNode> keyValuePair in jsonnode)
			{
				string key = keyValuePair.Key;
				FieldInfo field = obj.GetType().GetField(key);
				if (field != null)
				{
					if (field.FieldType.FullName.Equals("System.String"))
					{
						if (jsonObj[key] is JSONObject)
						{
							field.SetValue(obj, jsonObj[key].ToString() ?? "");
						}
						else
						{
							field.SetValue(obj, jsonObj[key] ?? "");
						}
					}
					if (field.FieldType.FullName.Equals("System.DateTime"))
					{
						string text = jsonObj[key] ?? "";
						if (!text.Equals("") && !text.Equals("null"))
						{
							DateTime dateTime = Convert.ToDateTime(jsonObj[key] ?? "");
							field.SetValue(obj, dateTime);
						}
					}
					if (field.FieldType.FullName.Equals("System.Boolean"))
					{
						field.SetValue(obj, Convert.ToBoolean(jsonObj[key] ?? ""));
					}
					if (field.FieldType.FullName.Equals("System.Double"))
					{
						string text2 = jsonObj[key] ?? "";
						if (!text2.Equals("null") && !text2.Trim().Equals(""))
						{
							field.SetValue(obj, Convert.ToDouble(jsonObj[key] ?? ""));
						}
					}
					if (field.FieldType.FullName.Equals("System.int"))
					{
						field.SetValue(obj, Convert.ToInt32(jsonObj[key] ?? ""));
					}
					if (field.FieldType.FullName.Equals("System.Int64"))
					{
						field.SetValue(obj, Convert.ToInt64(jsonObj[key] ?? ""));
					}
				}
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002378 File Offset: 0x00000578
		public JSONNode GetServiceJSONObject(string serviceName, string json)
		{
			JSONNode jsonnode = JSONNode.Parse(json);
			return (JSONObject)jsonnode["app42"]["response"][serviceName];
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000023B0 File Offset: 0x000005B0
		public bool IsResponseSuccess(string json)
		{
			JSONNode jsonnode = JSONNode.Parse(json);
			JSONNode jsonnode2 = (JSONObject)jsonnode["app42"]["response"];
			return jsonnode2["success"].AsBool;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000023F0 File Offset: 0x000005F0
		public int GetTotalRecords(string json)
		{
			int result = -1;
			JSONNode jsonnode = JSONNode.Parse(json);
			JSONNode jsonnode2 = (JSONObject)jsonnode["app42"];
			JSONNode jsonnode3 = (JSONObject)jsonnode2["response"];
			if (jsonnode3["totalRecords"] != null)
			{
				JSONNode jsonnode4 = (JSONObject)jsonnode3["totalRecords"];
				result = jsonnode4.AsInt;
			}
			return result;
		}
	}
}
