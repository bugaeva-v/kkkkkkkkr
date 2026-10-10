using System;
using System.Collections.Generic;
using SimpleJSON;

namespace com.shephertz.app42.paas.sdk.csharp.buddy
{
	// Token: 0x0200002D RID: 45
	public class BuddyResponseBuilder : App42ResponseBuilder
	{
		// Token: 0x060001B4 RID: 436 RVA: 0x00008D64 File Offset: 0x00006F64
		public Buddy BuildResponse(string json)
		{
			JSONNode serviceJSONObject = base.GetServiceJSONObject("buddies", json);
			if (serviceJSONObject == null)
			{
				Buddy buddy = new Buddy();
				buddy.SetStrResponse(json);
				buddy.SetResponseSuccess(base.IsResponseSuccess(json));
				buddy.SetTotalRecords(base.GetTotalRecords(json));
				return buddy;
			}
			JSONNode jsonObject = (JSONObject)serviceJSONObject["buddy"];
			Buddy buddy2 = this.BuildBuddyObject(jsonObject);
			buddy2.SetStrResponse(json);
			buddy2.SetResponseSuccess(base.IsResponseSuccess(json));
			return buddy2;
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00008DE0 File Offset: 0x00006FE0
		public Buddy BuildBuddyObject(JSONNode jsonObject)
		{
			Buddy buddy = new Buddy();
			base.BuildObjectFromJSONTree(buddy, jsonObject);
			if (jsonObject["points"] != null && jsonObject["points"]["point"] != null)
			{
				if (jsonObject["points"]["point"] is JSONObject)
				{
					JSONNode jsonObj = (JSONObject)jsonObject["points"]["point"];
					Buddy.Point obj = new Buddy.Point(buddy);
					base.BuildObjectFromJSONTree(obj, jsonObj);
				}
				else
				{
					JSONArray jsonarray = (JSONArray)jsonObject["points"]["point"];
					for (int i = 0; i < jsonarray.Count; i++)
					{
						JSONNode jsonObj2 = (JSONObject)jsonarray[i];
						Buddy.Point obj2 = new Buddy.Point(buddy);
						base.BuildObjectFromJSONTree(obj2, jsonObj2);
					}
				}
			}
			return buddy;
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00008ECC File Offset: 0x000070CC
		public IList<Buddy> BuildArrayResponse(string response)
		{
			JSONNode serviceJSONObject = base.GetServiceJSONObject("buddies", response);
			IList<Buddy> list = new List<Buddy>();
			if (serviceJSONObject["buddy"] is JSONArray)
			{
				JSONArray jsonarray = (JSONArray)serviceJSONObject["buddy"];
				for (int i = 0; i < jsonarray.Count; i++)
				{
					JSONNode jsonObject = (JSONObject)jsonarray[i];
					Buddy buddy = this.BuildBuddyObject(jsonObject);
					buddy.SetStrResponse(response);
					buddy.SetResponseSuccess(base.IsResponseSuccess(response));
					list.Add(buddy);
				}
			}
			else
			{
				JSONNode jsonObject2 = (JSONObject)serviceJSONObject["buddy"];
				Buddy buddy2 = this.BuildBuddyObject(jsonObject2);
				buddy2.SetStrResponse(response);
				buddy2.SetResponseSuccess(base.IsResponseSuccess(response));
				list.Add(buddy2);
			}
			return list;
		}
	}
}
