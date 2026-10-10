using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using SimpleJSON;

namespace com.shephertz.app42.paas.sdk.csharp.storage
{
	// Token: 0x020000B7 RID: 183
	public class StorageResponseBuilder : App42ResponseBuilder
	{
		// Token: 0x060007C8 RID: 1992 RVA: 0x0002BE58 File Offset: 0x0002A058
		public Storage BuildResponse(string json)
		{
			Storage storage = new Storage();
			IList<Storage.JSONDocument> jsonDocList = new List<Storage.JSONDocument>();
			storage.SetJsonDocList(jsonDocList);
			storage.SetStrResponse(json);
			JSONNode jsonnode = JSONNode.Parse(json);
			JSONNode jsonnode2 = (JSONObject)jsonnode["app42"];
			JSONNode jsonnode3 = (JSONObject)jsonnode2["response"];
			storage.SetResponseSuccess(base.IsResponseSuccess(json));
			storage.SetTotalRecords(base.GetTotalRecords(json));
			if (jsonnode3["storage"] == null)
			{
				return storage;
			}
			JSONNode jsonnode4 = (JSONObject)jsonnode3["storage"];
			base.BuildObjectFromJSONTree(storage, jsonnode4);
			if (jsonnode4["jsonDoc"] == null)
			{
				return storage;
			}
			if (jsonnode4["jsonDoc"] != null && jsonnode4["jsonDoc"] is JSONObject)
			{
				JSONNode jsonnode5 = (JSONObject)jsonnode4["jsonDoc"];
				Storage.JSONDocument jsondocument = new Storage.JSONDocument(storage);
				this.BuildJsonDocument(jsondocument, jsonnode5);
				if (jsonnode5["_files"] != null)
				{
					if (jsonnode5["_files"] != null && jsonnode5["_files"] is JSONObject)
					{
						JSONNode jsonObj = (JSONObject)jsonnode5["_files"];
						App42File app42File = new App42File();
						base.BuildObjectFromJSONTree(app42File, jsonObj);
						jsondocument.fileList.Add(app42File);
					}
					else
					{
						JSONArray jsonarray = (JSONArray)jsonnode5["_files"];
						for (int i = 0; i < jsonarray.Count; i++)
						{
							JSONNode jsonObj2 = (JSONObject)jsonarray[i];
							App42File app42File2 = new App42File();
							base.BuildObjectFromJSONTree(app42File2, jsonObj2);
							jsondocument.fileList.Add(app42File2);
						}
					}
				}
			}
			else
			{
				JSONArray jsonarray2 = (JSONArray)jsonnode4["jsonDoc"];
				for (int j = 0; j < jsonarray2.Count; j++)
				{
					JSONNode jsonnode6 = (JSONObject)jsonarray2[j];
					Storage.JSONDocument jsondocument2 = new Storage.JSONDocument(storage);
					this.BuildJsonDocument(jsondocument2, jsonnode6);
					if (jsonnode6["_files"] != null)
					{
						if (jsonnode6["_files"] != null && jsonnode6["_files"] is JSONObject)
						{
							JSONNode jsonObj3 = (JSONObject)jsonnode6["_files"];
							App42File app42File3 = new App42File();
							base.BuildObjectFromJSONTree(app42File3, jsonObj3);
							jsondocument2.fileList.Add(app42File3);
						}
						else
						{
							JSONArray jsonarray3 = (JSONArray)jsonnode6["_files"];
							for (int k = 0; k < jsonarray3.Count; k++)
							{
								JSONNode jsonObj4 = (JSONObject)jsonarray3[k];
								App42File app42File4 = new App42File();
								base.BuildObjectFromJSONTree(app42File4, jsonObj4);
								jsondocument2.fileList.Add(app42File4);
							}
						}
					}
				}
			}
			return storage;
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x0002C16C File Offset: 0x0002A36C
		private void BuildJsonDocument(Storage.JSONDocument document, JSONNode jsonObjDoc)
		{
			if (jsonObjDoc["loc"] != null && jsonObjDoc["loc"] is JSONArray)
			{
				JSONArray jsonarray = (JSONArray)jsonObjDoc["loc"];
				for (int i = 0; i < jsonarray.Count; i++)
				{
					if (jsonarray.Count == 2)
					{
						GeoTag geoTag = new GeoTag();
						geoTag.SetLat(jsonarray[0].AsDouble);
						geoTag.SetLng(jsonarray[1].AsDouble);
						document.SetLocation(geoTag);
						jsonObjDoc.Remove("loc");
					}
				}
			}
			if ((jsonObjDoc["_$createdAt"] ?? "") != null)
			{
				string createdAt = jsonObjDoc["_$createdAt"] ?? "";
				document.SetCreatedAt(createdAt);
				jsonObjDoc.Remove("_$createdAt");
				document.SetJsonDoc(jsonObjDoc.ToString());
			}
			if ((jsonObjDoc["_$event"] ?? "") != null)
			{
				string @event = jsonObjDoc["_$event"] ?? "";
				document.SetEvent(@event);
				jsonObjDoc.Remove("_$event");
				document.SetJsonDoc(jsonObjDoc.ToString());
			}
			if ((jsonObjDoc["_$updatedAt"] ?? "") != null)
			{
				string updatedAt = jsonObjDoc["_$updatedAt"] ?? "";
				document.SetUpdatedAt(updatedAt);
				jsonObjDoc.Remove("_$updatedAt");
				document.SetJsonDoc(jsonObjDoc.ToString());
			}
			if (jsonObjDoc["_id"] != null)
			{
				JSONNode jsonnode = (JSONObject)jsonObjDoc["_id"];
				string docId = jsonnode["$oid"] ?? "";
				document.SetDocId(docId);
				jsonObjDoc.Remove("_id");
				document.SetJsonDoc(jsonObjDoc.ToString());
			}
			if (jsonObjDoc["_$acl"] != null)
			{
				HashSet<ACL> hashSet = new HashSet<ACL>();
				document.SetAclList(hashSet);
				if (jsonObjDoc["_$acl"] is JSONArray)
				{
					JSONArray jsonarray2 = (JSONArray)jsonObjDoc["_$acl"];
					for (int j = 0; j < jsonarray2.Count; j++)
					{
						if (jsonarray2[j] is JSONObject)
						{
							JSONNode jsonnode2 = (JSONObject)jsonarray2[j];
							ACL acl = new ACL();
							string permission = jsonnode2[(from p in jsonObjDoc.GetType().GetProperties()
							select p.Name).ToList<string>()[0]] ?? "";
							acl.SetUser((from p in jsonObjDoc.GetType().GetProperties()
							select p.Name).ToList<string>()[0]);
							acl.SetPermission(permission);
							hashSet.Add(acl);
						}
					}
				}
				else
				{
					JSONNode jsonnode3 = (JSONObject)jsonObjDoc["_$acl"];
					ACL acl2 = new ACL();
					string permission2 = jsonnode3[(from p in jsonObjDoc.GetType().GetProperties()
					select p.Name).ToList<string>()[0]] ?? "";
					acl2.SetUser((from p in jsonObjDoc.GetType().GetProperties()
					select p.Name).ToList<string>()[0]);
					acl2.SetPermission(permission2);
					hashSet.Add(acl2);
				}
			}
			if (jsonObjDoc["_$owner"] != null)
			{
				JSONNode jsonnode4 = (JSONObject)jsonObjDoc["_$owner"];
				string owner = jsonnode4["owner"] ?? "";
				document.SetOwner(owner);
				jsonObjDoc.Remove("_$owner");
				document.SetJsonDoc(jsonObjDoc.ToString());
			}
			document.SetJsonDoc(jsonObjDoc.ToString());
		}
	}
}
