using System;
using SimpleJSON;

namespace com.shephertz.app42.paas.sdk.csharp.message
{
	// Token: 0x0200008A RID: 138
	public class QueueResponseBuilder : App42ResponseBuilder
	{
		// Token: 0x060005A2 RID: 1442 RVA: 0x0001FB60 File Offset: 0x0001DD60
		public Queue BuildResponse(string json)
		{
			JSONNode serviceJSONObject = base.GetServiceJSONObject("queues", json);
			JSONNode jsonnode = (JSONObject)serviceJSONObject["queue"];
			Queue queue = new Queue();
			queue.SetStrResponse(json);
			queue.SetResponseSuccess(base.IsResponseSuccess(json));
			base.BuildObjectFromJSONTree(queue, jsonnode);
			object obj = jsonnode["messages"];
			if (obj != null)
			{
				if (jsonnode["messages"]["message"] != null && jsonnode["messages"]["message"] is JSONObject)
				{
					JSONNode jsonObj = (JSONObject)jsonnode["messages"]["message"];
					Queue.Message obj2 = new Queue.Message(queue);
					base.BuildObjectFromJSONTree(obj2, jsonObj);
				}
				else
				{
					if (!(jsonnode["messages"]["message"] != null) || !(jsonnode["messages"]["message"] is JSONArray))
					{
						return queue;
					}
					JSONArray jsonarray = (JSONArray)jsonnode["messages"]["message"];
					for (int i = 0; i < jsonarray.Count; i++)
					{
						JSONNode jsonObj2 = (JSONObject)jsonarray[i];
						Queue.Message obj3 = new Queue.Message(queue);
						base.BuildObjectFromJSONTree(obj3, jsonObj2);
					}
				}
			}
			return queue;
		}
	}
}
