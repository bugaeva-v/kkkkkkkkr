using System;
using System.Collections.Generic;
using SimpleJSON;

namespace com.shephertz.app42.paas.sdk.csharp.shopping
{
	// Token: 0x02000038 RID: 56
	public class CatalogueResponseBuilder : App42ResponseBuilder
	{
		// Token: 0x06000235 RID: 565 RVA: 0x0000C0A4 File Offset: 0x0000A2A4
		public Catalogue BuildResponse(string response)
		{
			JSONNode serviceJSONObject = base.GetServiceJSONObject("catalogues", response);
			if (serviceJSONObject == null)
			{
				Catalogue catalogue = new Catalogue();
				catalogue.SetStrResponse(response);
				catalogue.SetResponseSuccess(base.IsResponseSuccess(response));
				catalogue.SetTotalRecords(base.GetTotalRecords(response));
				return catalogue;
			}
			JSONNode catalogueJSONObj = (JSONObject)serviceJSONObject["catalogue"];
			Catalogue catalogue2 = this.BuildCatalogueObject(catalogueJSONObj);
			catalogue2.SetStrResponse(response);
			catalogue2.SetResponseSuccess(base.IsResponseSuccess(response));
			return catalogue2;
		}

		// Token: 0x06000236 RID: 566 RVA: 0x0000C120 File Offset: 0x0000A320
		public IList<Catalogue> BuildArrayResponse(string response)
		{
			JSONNode serviceJSONObject = base.GetServiceJSONObject("catalogues", response);
			IList<Catalogue> list = new List<Catalogue>();
			if (serviceJSONObject["catalogue"] != null && serviceJSONObject["catalogue"] is JSONObject)
			{
				JSONNode jsonObj = (JSONObject)serviceJSONObject["catalogue"];
				Catalogue catalogue = new Catalogue();
				catalogue.SetStrResponse(response);
				catalogue.SetResponseSuccess(base.IsResponseSuccess(response));
				base.BuildObjectFromJSONTree(catalogue, jsonObj);
				list.Add(catalogue);
			}
			else
			{
				JSONArray jsonarray = (JSONArray)serviceJSONObject["catalogue"];
				for (int i = 0; i < jsonarray.Count; i++)
				{
					JSONNode catalogueJSONObj = (JSONObject)jsonarray[i];
					Catalogue catalogue2 = this.BuildCatalogueObject(catalogueJSONObj);
					catalogue2.SetStrResponse(response);
					catalogue2.SetResponseSuccess(base.IsResponseSuccess(response));
					list.Add(catalogue2);
				}
			}
			return list;
		}

		// Token: 0x06000237 RID: 567 RVA: 0x0000C204 File Offset: 0x0000A404
		private Catalogue BuildCatalogueObject(JSONNode catalogueJSONObj)
		{
			Catalogue catalogue = new Catalogue();
			base.BuildObjectFromJSONTree(catalogue, catalogueJSONObj);
			if (catalogueJSONObj["categories"] != null && catalogueJSONObj["categories"]["category"] != null)
			{
				if (catalogueJSONObj["categories"]["category"] is JSONObject)
				{
					JSONNode jsonnode = (JSONObject)catalogueJSONObj["categories"]["category"];
					Catalogue.Category category = new Catalogue.Category(catalogue);
					base.BuildObjectFromJSONTree(category, jsonnode);
					if (jsonnode["items"] != null && jsonnode["items"]["item"] != null)
					{
						if (jsonnode["items"]["item"] is JSONObject)
						{
							JSONNode jsonObj = (JSONObject)jsonnode["items"]["item"];
							Catalogue.Category.Item obj = new Catalogue.Category.Item(category);
							base.BuildObjectFromJSONTree(obj, jsonObj);
						}
						else
						{
							JSONArray jsonarray = (JSONArray)jsonnode["items"]["item"];
							for (int i = 0; i < jsonarray.Count; i++)
							{
								JSONNode jsonObj2 = (JSONObject)jsonarray[i];
								Catalogue.Category.Item obj2 = new Catalogue.Category.Item(category);
								base.BuildObjectFromJSONTree(obj2, jsonObj2);
							}
						}
					}
				}
				else
				{
					JSONArray jsonarray2 = (JSONArray)catalogueJSONObj["categories"]["category"];
					for (int j = 0; j < jsonarray2.Count; j++)
					{
						JSONNode jsonnode2 = (JSONObject)jsonarray2[j];
						Catalogue.Category category2 = new Catalogue.Category(catalogue);
						base.BuildObjectFromJSONTree(category2, jsonnode2);
						if (jsonnode2["items"] != null && jsonnode2["items"]["item"] != null)
						{
							if (jsonnode2["items"]["item"] is JSONObject)
							{
								JSONNode jsonObj3 = (JSONObject)jsonnode2["items"]["item"];
								Catalogue.Category.Item obj3 = new Catalogue.Category.Item(category2);
								base.BuildObjectFromJSONTree(obj3, jsonObj3);
							}
							else
							{
								JSONArray jsonarray3 = (JSONArray)jsonnode2["items"]["item"];
								for (int k = 0; k < jsonarray3.Count; k++)
								{
									JSONNode jsonObj4 = (JSONObject)jsonarray3[k];
									Catalogue.Category.Item obj4 = new Catalogue.Category.Item(category2);
									base.BuildObjectFromJSONTree(obj4, jsonObj4);
								}
							}
						}
					}
				}
			}
			return catalogue;
		}
	}
}
