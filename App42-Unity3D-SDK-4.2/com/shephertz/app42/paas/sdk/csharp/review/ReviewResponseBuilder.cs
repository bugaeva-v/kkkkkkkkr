using System;
using System.Collections.Generic;
using SimpleJSON;

namespace com.shephertz.app42.paas.sdk.csharp.review
{
	// Token: 0x02000093 RID: 147
	public class ReviewResponseBuilder : App42ResponseBuilder
	{
		// Token: 0x06000600 RID: 1536 RVA: 0x00023E00 File Offset: 0x00022000
		public Review BuildResponse(string json)
		{
			JSONNode serviceJSONObject = base.GetServiceJSONObject("reviews", json);
			if (serviceJSONObject == null)
			{
				Review review = new Review();
				review.SetStrResponse(json);
				review.SetResponseSuccess(base.IsResponseSuccess(json));
				review.SetTotalRecords(base.GetTotalRecords(json));
				return review;
			}
			JSONNode jsonObj = (JSONObject)serviceJSONObject["review"];
			Review review2 = new Review();
			review2.SetStrResponse(json);
			review2.SetResponseSuccess(base.IsResponseSuccess(json));
			base.BuildObjectFromJSONTree(review2, jsonObj);
			return review2;
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x00023E80 File Offset: 0x00022080
		public IList<Review> BuildArrayResponse(string json)
		{
			IList<Review> list = new List<Review>();
			JSONNode serviceJSONObject = base.GetServiceJSONObject("reviews", json);
			if (serviceJSONObject["review"] != null && serviceJSONObject["review"] is JSONObject)
			{
				JSONNode jsonObj = (JSONObject)serviceJSONObject["review"];
				Review review = new Review();
				review.SetStrResponse(json);
				review.SetResponseSuccess(base.IsResponseSuccess(json));
				base.BuildObjectFromJSONTree(review, jsonObj);
				list.Add(review);
			}
			else
			{
				JSONArray jsonarray = (JSONArray)serviceJSONObject["review"];
				for (int i = 0; i < jsonarray.Count; i++)
				{
					JSONNode jsonObj2 = (JSONObject)jsonarray[i];
					Review review2 = new Review();
					review2.SetStrResponse(json);
					review2.SetResponseSuccess(base.IsResponseSuccess(json));
					base.BuildObjectFromJSONTree(review2, jsonObj2);
					list.Add(review2);
				}
			}
			return list;
		}
	}
}
