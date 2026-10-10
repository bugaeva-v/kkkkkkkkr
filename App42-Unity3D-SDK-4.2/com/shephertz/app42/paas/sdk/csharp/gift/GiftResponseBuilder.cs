using System;
using System.Collections.Generic;
using SimpleJSON;

namespace com.shephertz.app42.paas.sdk.csharp.gift
{
	// Token: 0x02000057 RID: 87
	public class GiftResponseBuilder : App42ResponseBuilder
	{
		// Token: 0x06000340 RID: 832 RVA: 0x00011BBC File Offset: 0x0000FDBC
		public Gift BuildResponse(string json)
		{
			JSONNode serviceJSONObject = base.GetServiceJSONObject("gifts", json);
			if (serviceJSONObject == null)
			{
				Gift gift = new Gift();
				gift.SetStrResponse(json);
				gift.SetResponseSuccess(base.IsResponseSuccess(json));
				gift.SetTotalRecords(base.GetTotalRecords(json));
				return gift;
			}
			JSONNode giftJSONObj = (JSONObject)serviceJSONObject["gift"];
			Gift gift2 = this.BuildGiftObject(giftJSONObj);
			gift2.SetStrResponse(json);
			gift2.SetResponseSuccess(base.IsResponseSuccess(json));
			return gift2;
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00011C38 File Offset: 0x0000FE38
		private Gift BuildGiftObject(JSONNode giftJSONObj)
		{
			Gift gift = new Gift();
			base.BuildObjectFromJSONTree(gift, giftJSONObj);
			if (giftJSONObj["requests"] != null)
			{
				IList<Gift.Requests> list = new List<Gift.Requests>();
				if (giftJSONObj["requests"] is JSONArray)
				{
					JSONArray jsonarray = (JSONArray)giftJSONObj["requests"];
					for (int i = 0; i < jsonarray.Count; i++)
					{
						JSONNode jsonObj = (JSONObject)jsonarray[i];
						Gift.Requests requests = new Gift.Requests(gift);
						base.BuildObjectFromJSONTree(requests, jsonObj);
						list.Add(requests);
					}
				}
				else
				{
					JSONNode jsonObj2 = (JSONObject)giftJSONObj["requests"];
					Gift.Requests requests2 = new Gift.Requests(gift);
					base.BuildObjectFromJSONTree(requests2, jsonObj2);
					list.Add(requests2);
				}
				gift.SetRequestsList(list);
			}
			return gift;
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00011D04 File Offset: 0x0000FF04
		public IList<Gift> BuildArrayResponse(string json)
		{
			JSONNode serviceJSONObject = base.GetServiceJSONObject("gifts", json);
			IList<Gift> list = new List<Gift>();
			if (serviceJSONObject["gift"] is JSONArray)
			{
				JSONArray jsonarray = (JSONArray)serviceJSONObject["gift"];
				for (int i = 0; i < jsonarray.Count; i++)
				{
					JSONNode jsonnode = (JSONObject)jsonarray[i];
					Gift gift = this.BuildGiftObject(jsonnode);
					gift.SetStrResponse(json);
					gift.SetResponseSuccess(base.IsResponseSuccess(json));
					base.BuildObjectFromJSONTree(gift, jsonnode);
					list.Add(gift);
				}
			}
			else
			{
				JSONNode jsonnode2 = (JSONObject)serviceJSONObject["gift"];
				Gift gift2 = this.BuildGiftObject(jsonnode2);
				gift2.SetStrResponse(json);
				gift2.SetResponseSuccess(base.IsResponseSuccess(json));
				base.BuildObjectFromJSONTree(gift2, jsonnode2);
				list.Add(gift2);
			}
			return list;
		}
	}
}
