using System;
using System.Collections.Generic;
using SimpleJSON;

namespace com.shephertz.app42.paas.sdk.csharp.geo
{
	// Token: 0x02000052 RID: 82
	public class GeoResponseBuilder : App42ResponseBuilder
	{
		// Token: 0x0600030C RID: 780 RVA: 0x00010BDC File Offset: 0x0000EDDC
		public Geo BuildResponse(string json)
		{
			Geo geo = new Geo();
			IList<Geo.Point> pointList = new List<Geo.Point>();
			geo.SetPointList(pointList);
			geo.SetStrResponse(json);
			JSONNode jsonnode = JSONNode.Parse(json);
			JSONNode jsonnode2 = (JSONObject)jsonnode["app42"];
			JSONNode jsonnode3 = (JSONObject)jsonnode2["response"];
			geo.SetResponseSuccess(bool.Parse(jsonnode3["success"]));
			geo.SetTotalRecords(base.GetTotalRecords(json));
			JSONNode jsonnode4 = (JSONObject)jsonnode3["geo"]["storage"];
			if (jsonnode4 == null)
			{
				return geo;
			}
			App42Log.Console("jsonObjGeoStorage" + jsonnode4);
			base.BuildObjectFromJSONTree(geo, jsonnode4);
			if (jsonnode4["points"] == null)
			{
				return geo;
			}
			this.BuildInternalObj(geo, jsonnode4);
			return geo;
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00010CC0 File Offset: 0x0000EEC0
		public IList<Geo> BuildArrayResponse(string json)
		{
			IList<Geo> list = new List<Geo>();
			JSONNode jsonnode = JSONNode.Parse(json);
			JSONNode jsonnode2 = (JSONObject)jsonnode["app42"];
			JSONNode jsonnode3 = (JSONObject)jsonnode2["response"];
			JSONNode jsonnode4 = (JSONObject)jsonnode3["geo"];
			if (jsonnode4["storage"] != null && jsonnode4["storage"] is JSONObject)
			{
				jsonnode4 = (JSONObject)jsonnode4["storage"];
				Geo geo = new Geo();
				IList<Geo.Point> pointList = new List<Geo.Point>();
				geo.SetPointList(pointList);
				geo.SetStrResponse(json);
				geo.SetResponseSuccess(bool.Parse(jsonnode3["success"]));
				base.BuildObjectFromJSONTree(geo, jsonnode4);
				list.Add(geo);
				if (jsonnode4["points"] != null)
				{
					this.BuildInternalObj(geo, jsonnode4);
				}
			}
			else
			{
				JSONArray jsonarray = (JSONArray)jsonnode4["storage"];
				for (int i = 0; i < jsonarray.Count; i++)
				{
					JSONNode jsonnode5 = (JSONObject)jsonarray[i];
					Geo geo2 = new Geo();
					IList<Geo.Point> pointList2 = new List<Geo.Point>();
					geo2.SetPointList(pointList2);
					geo2.SetStrResponse(json);
					geo2.SetResponseSuccess(bool.Parse(jsonnode3["success"]));
					base.BuildObjectFromJSONTree(geo2, jsonnode5);
					list.Add(geo2);
					if (jsonnode5["points"] != null)
					{
						this.BuildInternalObj(geo2, jsonnode5);
					}
				}
			}
			return list;
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00010E70 File Offset: 0x0000F070
		private Geo BuildInternalObj(Geo geoObj, JSONNode jsonObjGeoStorage)
		{
			JSONNode jsonnode = (JSONObject)jsonObjGeoStorage["points"];
			if (jsonnode["point"] == null)
			{
				return geoObj;
			}
			if (jsonnode["point"] != null && jsonnode["point"] is JSONObject)
			{
				JSONNode jsonObj = (JSONObject)jsonnode["point"];
				Geo.Point obj = new Geo.Point(geoObj);
				base.BuildObjectFromJSONTree(obj, jsonObj);
			}
			else
			{
				JSONArray jsonarray = (JSONArray)jsonnode["point"];
				for (int i = 0; i < jsonarray.Count; i++)
				{
					JSONNode jsonObj2 = (JSONObject)jsonarray[i];
					Geo.Point obj2 = new Geo.Point(geoObj);
					base.BuildObjectFromJSONTree(obj2, jsonObj2);
				}
			}
			return geoObj;
		}
	}
}
