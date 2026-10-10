using System;
using System.Collections.Generic;
using SimpleJSON;

namespace com.shephertz.app42.paas.sdk.csharp.log
{
	// Token: 0x02000079 RID: 121
	public class LogResponseBuilder : App42ResponseBuilder
	{
		// Token: 0x060004F2 RID: 1266 RVA: 0x00019860 File Offset: 0x00017A60
		public Log BuildResponse(string json)
		{
			Log log = new Log();
			IList<Log.Message> messageList = new List<Log.Message>();
			log.SetMessageList(messageList);
			log.SetStrResponse(json);
			JSONNode jsonnode = JSONNode.Parse(json);
			JSONNode jsonnode2 = (JSONObject)jsonnode["app42"];
			JSONNode jsonnode3 = (JSONObject)jsonnode2["response"];
			log.SetResponseSuccess(bool.Parse(jsonnode3["success"]));
			log.SetTotalRecords(base.GetTotalRecords(json));
			JSONNode jsonnode4 = (JSONObject)jsonnode3["logs"];
			if (jsonnode4 == null)
			{
				return log;
			}
			if (jsonnode4["log"] != null && jsonnode4["log"] is JSONObject)
			{
				JSONNode jsonObj = (JSONObject)jsonnode4["log"];
				Log.Message obj = new Log.Message(log);
				base.BuildObjectFromJSONTree(obj, jsonObj);
			}
			else
			{
				JSONArray jsonarray = (JSONArray)jsonnode4["log"];
				for (int i = 0; i < jsonarray.Count; i++)
				{
					JSONNode jsonObj2 = (JSONObject)jsonarray[i];
					Log.Message obj2 = new Log.Message(log);
					base.BuildObjectFromJSONTree(obj2, jsonObj2);
				}
			}
			return log;
		}
	}
}
