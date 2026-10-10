using System;
using SimpleJSON;

namespace com.shephertz.app42.paas.sdk.csharp.social
{
	// Token: 0x020000B3 RID: 179
	public class SocialResponseBuilder : App42ResponseBuilder
	{
		// Token: 0x06000794 RID: 1940 RVA: 0x0002A130 File Offset: 0x00028330
		public Social BuildResponse(string json)
		{
			JSONNode serviceJSONObject = base.GetServiceJSONObject("social", json);
			if (serviceJSONObject == null)
			{
				Social social = new Social();
				social.SetStrResponse(json);
				social.SetResponseSuccess(base.IsResponseSuccess(json));
				social.SetTotalRecords(base.GetTotalRecords(json));
				return social;
			}
			Social social2 = new Social();
			social2.SetStrResponse(json);
			social2.SetResponseSuccess(base.IsResponseSuccess(json));
			base.BuildObjectFromJSONTree(social2, serviceJSONObject);
			if (serviceJSONObject["friends"] != null)
			{
				if (serviceJSONObject["friends"] is JSONObject)
				{
					JSONNode jsonObj = (JSONObject)serviceJSONObject["friends"];
					Social.Friends obj = new Social.Friends(social2);
					base.BuildObjectFromJSONTree(obj, jsonObj);
				}
				else
				{
					JSONArray jsonarray = (JSONArray)serviceJSONObject["friends"];
					for (int i = 0; i < jsonarray.Count; i++)
					{
						JSONNode jsonObj2 = (JSONObject)jsonarray[i];
						Social.Friends obj2 = new Social.Friends(social2);
						base.BuildObjectFromJSONTree(obj2, jsonObj2);
					}
				}
			}
			if (serviceJSONObject["me"] != null && serviceJSONObject["me"] is JSONObject)
			{
				JSONNode jsonObj3 = (JSONObject)serviceJSONObject["me"];
				Social.FacebookProfile obj3 = new Social.FacebookProfile(social2);
				base.BuildObjectFromJSONTree(obj3, jsonObj3);
			}
			if (serviceJSONObject["facebookProfile"] != null && serviceJSONObject["facebookProfile"] is JSONObject)
			{
				JSONNode jsonObj4 = (JSONObject)serviceJSONObject["facebookProfile"];
				Social.FacebookProfile obj4 = new Social.FacebookProfile(social2);
				base.BuildObjectFromJSONTree(obj4, jsonObj4);
			}
			if (serviceJSONObject["profile"] != null)
			{
				if (serviceJSONObject["profile"] is JSONObject)
				{
					JSONNode jsonObj5 = (JSONObject)serviceJSONObject["profile"];
					Social.PublicProfile obj5 = new Social.PublicProfile(social2);
					base.BuildObjectFromJSONTree(obj5, jsonObj5);
				}
				else
				{
					JSONArray jsonarray2 = (JSONArray)serviceJSONObject["profile"];
					for (int j = 0; j < jsonarray2.Count; j++)
					{
						JSONObject jsonObj6 = (JSONObject)jsonarray2[j];
						Social.PublicProfile obj6 = new Social.PublicProfile(social2);
						base.BuildObjectFromJSONTree(obj6, jsonObj6);
					}
				}
			}
			return social2;
		}
	}
}
