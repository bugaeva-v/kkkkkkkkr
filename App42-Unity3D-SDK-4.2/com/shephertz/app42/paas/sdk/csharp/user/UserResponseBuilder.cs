using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using com.shephertz.app42.paas.sdk.csharp.storage;
using SimpleJSON;

namespace com.shephertz.app42.paas.sdk.csharp.user
{
	// Token: 0x020000C7 RID: 199
	public class UserResponseBuilder : App42ResponseBuilder
	{
		// Token: 0x06000897 RID: 2199 RVA: 0x000322BC File Offset: 0x000304BC
		public User BuildResponse(string json)
		{
			JSONNode serviceJSONObject = base.GetServiceJSONObject("users", json);
			if (serviceJSONObject == null)
			{
				User user = new User();
				user.SetStrResponse(json);
				user.SetResponseSuccess(base.IsResponseSuccess(json));
				user.SetTotalRecords(base.GetTotalRecords(json));
				return user;
			}
			JSONNode userJSONObj = (JSONObject)serviceJSONObject["user"];
			User user2 = this.BuildUserObject(userJSONObj);
			user2.SetStrResponse(json);
			user2.SetResponseSuccess(base.IsResponseSuccess(json));
			return user2;
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x00032338 File Offset: 0x00030538
		private User BuildUserObject(JSONNode userJSONObj)
		{
			User user = new User();
			base.BuildObjectFromJSONTree(user, userJSONObj);
			if (userJSONObj["profile"] != null)
			{
				JSONNode jsonObj = (JSONObject)userJSONObj["profile"];
				User.Profile obj = new User.Profile(user);
				base.BuildObjectFromJSONTree(obj, jsonObj);
			}
			if (userJSONObj["role"] != null)
			{
				IList<string> list = new List<string>();
				if (userJSONObj["role"] is JSONArray)
				{
					JSONArray jsonarray = (JSONArray)userJSONObj["role"];
					for (int i = 0; i < jsonarray.Count; i++)
					{
						list.Add(jsonarray[i]);
					}
				}
				else
				{
					list.Add(userJSONObj["role"]);
				}
				user.SetRoleList(list);
			}
			if (userJSONObj["jsonDoc"] == null)
			{
				return user;
			}
			if (userJSONObj["jsonDoc"] != null && userJSONObj["jsonDoc"] is JSONObject)
			{
				JSONNode jsonObjDoc = (JSONObject)userJSONObj["jsonDoc"];
				User.JSONDocument document = new User.JSONDocument(user);
				this.BuildJsonDocument(document, jsonObjDoc);
			}
			else
			{
				JSONArray jsonarray2 = (JSONArray)userJSONObj["jsonDoc"];
				for (int j = 0; j < jsonarray2.Count; j++)
				{
					JSONNode jsonObjDoc2 = (JSONObject)jsonarray2[j];
					User.JSONDocument document2 = new User.JSONDocument(user);
					this.BuildJsonDocument(document2, jsonObjDoc2);
				}
			}
			return user;
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x000324D8 File Offset: 0x000306D8
		private void BuildJsonDocument(User.JSONDocument document, JSONNode jsonObjDoc)
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
			if (jsonObjDoc["_$createdAt"] != null)
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
			if (jsonObjDoc["_$updatedAt"] != null)
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

		// Token: 0x0600089A RID: 2202 RVA: 0x00032924 File Offset: 0x00030B24
		public IList<User> BuildArrayResponse(string json)
		{
			JSONNode serviceJSONObject = base.GetServiceJSONObject("users", json);
			IList<User> list = new List<User>();
			if (serviceJSONObject["user"] is JSONArray)
			{
				JSONArray jsonarray = (JSONArray)serviceJSONObject["user"];
				for (int i = 0; i < jsonarray.Count; i++)
				{
					JSONNode jsonnode = (JSONObject)jsonarray[i];
					User user = this.BuildUserObject(jsonnode);
					base.BuildObjectFromJSONTree(user, jsonnode);
					user.SetStrResponse(json);
					user.SetResponseSuccess(base.IsResponseSuccess(json));
					list.Add(user);
				}
			}
			else
			{
				JSONNode userJSONObj = (JSONObject)serviceJSONObject["user"];
				User user2 = this.BuildUserObject(userJSONObj);
				user2.SetStrResponse(json);
				user2.SetResponseSuccess(base.IsResponseSuccess(json));
				list.Add(user2);
			}
			return list;
		}
	}
}
