using System;
using System.Collections.Generic;
using SimpleJSON;

namespace com.shephertz.app42.paas.sdk.csharp.pushNotification
{
	// Token: 0x02000081 RID: 129
	public class PushNotificationResponseBuilder : App42ResponseBuilder
	{
		// Token: 0x06000557 RID: 1367 RVA: 0x0001C580 File Offset: 0x0001A780
		public PushNotification BuildResponse(string json)
		{
			JSONNode jsonnode = JSONNode.Parse(json);
			JSONNode jsonnode2 = (JSONObject)jsonnode["app42"];
			JSONNode jsonnode3 = (JSONObject)jsonnode2["response"];
			PushNotification pushNotification = new PushNotification();
			IList<PushNotification.Channel> channelList = new List<PushNotification.Channel>();
			pushNotification.SetChannelList(channelList);
			pushNotification.SetStrResponse(json);
			pushNotification.SetResponseSuccess(base.IsResponseSuccess(json));
			pushNotification.SetTotalRecords(base.GetTotalRecords(json));
			JSONNode jsonnode4 = (JSONObject)jsonnode3["push"];
			if (jsonnode4 == null)
			{
				return pushNotification;
			}
			base.BuildObjectFromJSONTree(pushNotification, jsonnode4);
			if (jsonnode4["channels"] == null)
			{
				return pushNotification;
			}
			JSONNode jsonnode5 = (JSONObject)jsonnode4["channels"];
			if (jsonnode5["channel"] == null)
			{
				return pushNotification;
			}
			if (jsonnode5["channel"] is JSONObject)
			{
				JSONNode jsonObj = (JSONObject)jsonnode5["channel"];
				PushNotification.Channel obj = new PushNotification.Channel(pushNotification);
				base.BuildObjectFromJSONTree(obj, jsonObj);
			}
			else
			{
				JSONArray jsonarray = (JSONArray)jsonnode5["channel"];
				for (int i = 0; i < jsonarray.Count; i++)
				{
					JSONNode jsonObj2 = (JSONObject)jsonarray[i];
					PushNotification.Channel obj2 = new PushNotification.Channel(pushNotification);
					base.BuildObjectFromJSONTree(obj2, jsonObj2);
				}
			}
			return pushNotification;
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x0001C6D8 File Offset: 0x0001A8D8
		public IList<PushNotification> BuildArrayResponse(string json)
		{
			JSONNode jsonnode = JSONNode.Parse(json);
			JSONNode jsonnode2 = (JSONObject)jsonnode["app42"];
			JSONNode jsonnode3 = (JSONObject)jsonnode2["response"];
			IList<PushNotification> list = new List<PushNotification>();
			if (jsonnode3["push"] is JSONArray)
			{
				JSONArray jsonarray = (JSONArray)jsonnode3["push"];
				for (int i = 0; i < jsonarray.Count; i++)
				{
					PushNotification pushNotification = new PushNotification();
					JSONNode jsonnode4 = (JSONObject)jsonarray[i];
					base.BuildObjectFromJSONTree(pushNotification, jsonnode4);
					IList<PushNotification.Channel> channelList = new List<PushNotification.Channel>();
					pushNotification.SetChannelList(channelList);
					JSONNode jsonnode5 = (JSONObject)jsonnode4["channels"];
					if (jsonnode5 != null)
					{
						if (jsonnode5["channel"] is JSONObject)
						{
							JSONNode jsonObj = (JSONObject)jsonnode5["channel"];
							PushNotification.Channel obj = new PushNotification.Channel(pushNotification);
							base.BuildObjectFromJSONTree(obj, jsonObj);
						}
						else
						{
							JSONArray jsonarray2 = (JSONArray)jsonnode5["channel"];
							for (int j = 0; j < jsonarray2.Count; j++)
							{
								JSONNode jsonObj2 = (JSONObject)jsonarray2[j];
								PushNotification.Channel obj2 = new PushNotification.Channel(pushNotification);
								base.BuildObjectFromJSONTree(obj2, jsonObj2);
							}
						}
					}
					pushNotification.SetStrResponse(json);
					pushNotification.SetResponseSuccess(base.IsResponseSuccess(json));
					list.Add(pushNotification);
				}
			}
			else
			{
				PushNotification pushNotification2 = new PushNotification();
				JSONNode jsonnode6 = (JSONObject)jsonnode3["push"];
				base.BuildObjectFromJSONTree(pushNotification2, jsonnode6);
				IList<PushNotification.Channel> channelList2 = new List<PushNotification.Channel>();
				pushNotification2.SetChannelList(channelList2);
				JSONNode jsonnode7 = (JSONObject)jsonnode6["channels"];
				if (jsonnode7 != null)
				{
					if (jsonnode7["channel"] is JSONObject)
					{
						JSONNode jsonObj3 = (JSONObject)jsonnode7["channel"];
						PushNotification.Channel obj3 = new PushNotification.Channel(pushNotification2);
						base.BuildObjectFromJSONTree(obj3, jsonObj3);
					}
					else
					{
						JSONArray jsonarray3 = (JSONArray)jsonnode7["channel"];
						for (int k = 0; k < jsonarray3.Count; k++)
						{
							JSONNode jsonObj4 = (JSONObject)jsonarray3[k];
							PushNotification.Channel obj4 = new PushNotification.Channel(pushNotification2);
							base.BuildObjectFromJSONTree(obj4, jsonObj4);
						}
					}
				}
				pushNotification2.SetStrResponse(json);
				pushNotification2.SetResponseSuccess(base.IsResponseSuccess(json));
				list.Add(pushNotification2);
			}
			return list;
		}
	}
}
