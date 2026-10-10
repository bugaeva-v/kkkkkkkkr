using System;
using System.Collections.Generic;
using SimpleJSON;

namespace com.shephertz.app42.paas.sdk.csharp.session
{
	// Token: 0x0200009D RID: 157
	public class SessionResponseBuilder : App42ResponseBuilder
	{
		// Token: 0x06000684 RID: 1668 RVA: 0x0002795C File Offset: 0x00025B5C
		public Session BuildResponse(string json)
		{
			Session session = new Session();
			IList<Session.Attribute> attributeList = new List<Session.Attribute>();
			session.SetAttributeList(attributeList);
			session.SetStrResponse(json);
			JSONNode jsonnode = JSONNode.Parse(json);
			JSONNode jsonnode2 = (JSONObject)jsonnode["app42"];
			JSONNode jsonnode3 = (JSONObject)jsonnode2["response"];
			session.SetResponseSuccess(bool.Parse(jsonnode3["success"]));
			JSONNode jsonnode4 = (JSONObject)jsonnode3["session"];
			base.BuildObjectFromJSONTree(session, jsonnode4);
			if (jsonnode4["attributes"] == null)
			{
				return session;
			}
			JSONNode jsonnode5 = (JSONObject)jsonnode4["attributes"];
			if (jsonnode5["attribute"] == null)
			{
				return session;
			}
			if (jsonnode5["attribute"] != null && jsonnode5["attribute"] is JSONObject)
			{
				JSONNode jsonObj = (JSONObject)jsonnode5["attribute"];
				Session.Attribute obj = new Session.Attribute(session);
				base.BuildObjectFromJSONTree(obj, jsonObj);
			}
			else
			{
				JSONArray jsonarray = (JSONArray)jsonnode5["attribute"];
				for (int i = 0; i < jsonarray.Count; i++)
				{
					JSONNode jsonObj2 = (JSONObject)jsonarray[i];
					Session.Attribute obj2 = new Session.Attribute(session);
					base.BuildObjectFromJSONTree(obj2, jsonObj2);
				}
			}
			return session;
		}
	}
}
