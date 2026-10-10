using System;
using System.Collections.Generic;
using SimpleJSON;

namespace com.shephertz.app42.paas.sdk.csharp.recommend
{
	// Token: 0x0200008E RID: 142
	public class RecommenderResponseBuilder : App42ResponseBuilder
	{
		// Token: 0x060005BB RID: 1467 RVA: 0x00020610 File Offset: 0x0001E810
		public Recommender BuildResponse(string json)
		{
			IList<Recommender.RecommendedItem> recommendedItemList = new List<Recommender.RecommendedItem>();
			Recommender recommender = new Recommender();
			recommender.SetRecommendedItemList(recommendedItemList);
			recommender.SetStrResponse(json);
			App42Log.Console("json" + json);
			JSONNode jsonnode = JSONNode.Parse(json);
			JSONNode jsonnode2 = (JSONObject)jsonnode["app42"];
			JSONNode jsonnode3 = (JSONObject)jsonnode2["response"];
			recommender.SetResponseSuccess(bool.Parse(jsonnode3["success"]));
			recommender.SetTotalRecords(base.GetTotalRecords(json));
			JSONNode jsonnode4 = (JSONObject)jsonnode3["recommender"];
			if (jsonnode4 == null)
			{
				return recommender;
			}
			base.BuildObjectFromJSONTree(recommender, jsonnode4);
			if (jsonnode4["recommended"] == null)
			{
				return recommender;
			}
			if (jsonnode4["recommended"] is JSONObject)
			{
				JSONNode jsonObj = (JSONObject)jsonnode4["recommended"];
				Recommender.RecommendedItem obj = new Recommender.RecommendedItem(recommender);
				base.BuildObjectFromJSONTree(obj, jsonObj);
			}
			else
			{
				JSONArray jsonarray = (JSONArray)jsonnode4["recommended"];
				for (int i = 0; i < jsonarray.Count; i++)
				{
					JSONNode jsonObj2 = (JSONObject)jsonarray[i];
					Recommender.RecommendedItem obj2 = new Recommender.RecommendedItem(recommender);
					base.BuildObjectFromJSONTree(obj2, jsonObj2);
				}
			}
			return recommender;
		}
	}
}
