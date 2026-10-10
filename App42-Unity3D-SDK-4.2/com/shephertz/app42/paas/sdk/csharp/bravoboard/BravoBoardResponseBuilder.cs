using System;
using System.Collections.Generic;
using SimpleJSON;

namespace com.shephertz.app42.paas.sdk.csharp.bravoboard
{
	// Token: 0x02000029 RID: 41
	public class BravoBoardResponseBuilder : App42ResponseBuilder
	{
		// Token: 0x0600017F RID: 383 RVA: 0x00007B48 File Offset: 0x00005D48
		public BravoBoard BuildResponse(string json)
		{
			JSONNode serviceJSONObject = base.GetServiceJSONObject("activities", json);
			if (serviceJSONObject == null)
			{
				BravoBoard bravoBoard = new BravoBoard();
				bravoBoard.SetStrResponse(json);
				bravoBoard.SetResponseSuccess(base.IsResponseSuccess(json));
				bravoBoard.SetTotalRecords(base.GetTotalRecords(json));
				return bravoBoard;
			}
			JSONNode bravoJSONObject = (JSONObject)serviceJSONObject["activity"];
			BravoBoard bravoBoard2 = this.BuildBravoObject(bravoJSONObject);
			bravoBoard2.SetStrResponse(json);
			bravoBoard2.SetResponseSuccess(base.IsResponseSuccess(json));
			return bravoBoard2;
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00007BC4 File Offset: 0x00005DC4
		private BravoBoard BuildBravoObject(JSONNode bravoJSONObject)
		{
			BravoBoard bravoBoard = new BravoBoard();
			base.BuildObjectFromJSONTree(bravoBoard, bravoJSONObject);
			if (bravoJSONObject["tags"] != null)
			{
				if (bravoJSONObject["tags"] is JSONObject)
				{
					JSONNode jsonObj = (JSONObject)bravoJSONObject["tags"];
					BravoBoard.Tags obj = new BravoBoard.Tags(bravoBoard);
					base.BuildObjectFromJSONTree(obj, jsonObj);
				}
				else
				{
					JSONArray jsonarray = (JSONArray)bravoJSONObject["tags"];
					for (int i = 0; i < jsonarray.Count; i++)
					{
						JSONNode jsonObj2 = (JSONObject)jsonarray[i];
						BravoBoard.Tags obj2 = new BravoBoard.Tags(bravoBoard);
						base.BuildObjectFromJSONTree(obj2, jsonObj2);
					}
				}
			}
			return bravoBoard;
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00007C70 File Offset: 0x00005E70
		public IList<BravoBoard> BuildArrayResponse(string json)
		{
			IList<BravoBoard> list = new List<BravoBoard>();
			JSONNode serviceJSONObject = base.GetServiceJSONObject("activities", json);
			if (serviceJSONObject["activity"] != null && serviceJSONObject["activity"] is JSONObject)
			{
				JSONNode bravoJSONObject = (JSONObject)serviceJSONObject["activity"];
				BravoBoard bravoBoard = this.BuildBravoObject(bravoJSONObject);
				bravoBoard.SetStrResponse(json);
				bravoBoard.SetResponseSuccess(base.IsResponseSuccess(json));
				list.Add(bravoBoard);
			}
			else
			{
				JSONArray jsonarray = (JSONArray)serviceJSONObject["activity"];
				for (int i = 0; i < jsonarray.Count; i++)
				{
					JSONNode bravoJSONObject2 = (JSONObject)jsonarray[i];
					BravoBoard bravoBoard2 = this.BuildBravoObject(bravoJSONObject2);
					bravoBoard2.SetStrResponse(json);
					bravoBoard2.SetResponseSuccess(base.IsResponseSuccess(json));
					list.Add(bravoBoard2);
				}
			}
			return list;
		}
	}
}
