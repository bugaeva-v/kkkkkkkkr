using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using com.shephertz.app42.paas.sdk.csharp.storage;
using SimpleJSON;

namespace com.shephertz.app42.paas.sdk.csharp.game
{
	// Token: 0x0200004C RID: 76
	public class GameResponseBuilder : App42ResponseBuilder
	{
		// Token: 0x060002DA RID: 730 RVA: 0x0000FCE0 File Offset: 0x0000DEE0
		public Game BuildResponse(string json)
		{
			JSONNode serviceJSONObject = base.GetServiceJSONObject("games", json);
			JSONNode gameJSONObject = (JSONObject)serviceJSONObject["game"];
			Game game = this.BuildGameObject(gameJSONObject);
			game.SetResponseSuccess(base.IsResponseSuccess(json));
			game.SetTotalRecords(base.GetTotalRecords(json));
			game.SetStrResponse(json);
			return game;
		}

		// Token: 0x060002DB RID: 731 RVA: 0x0000FD38 File Offset: 0x0000DF38
		public IList<Game> BuildArrayResponse(string json)
		{
			JSONNode serviceJSONObject = base.GetServiceJSONObject("games", json);
			IList<Game> list = new List<Game>();
			if (serviceJSONObject["game"] != null && serviceJSONObject["game"] is JSONObject)
			{
				JSONNode jsonnode = (JSONObject)serviceJSONObject["game"];
				Game game = this.BuildGameObject(jsonnode);
				base.BuildObjectFromJSONTree(game, jsonnode);
				game.SetResponseSuccess(base.IsResponseSuccess(json));
				game.SetStrResponse(json);
				list.Add(game);
			}
			else
			{
				JSONArray jsonarray = (JSONArray)serviceJSONObject["game"];
				for (int i = 0; i < jsonarray.Count; i++)
				{
					JSONNode gameJSONObject = (JSONObject)jsonarray[i];
					Game game2 = this.BuildGameObject(gameJSONObject);
					game2.SetResponseSuccess(base.IsResponseSuccess(json));
					game2.SetStrResponse(json);
					list.Add(game2);
				}
			}
			return list;
		}

		// Token: 0x060002DC RID: 732 RVA: 0x0000FE1C File Offset: 0x0000E01C
		private Game BuildGameObject(JSONNode gameJSONObject)
		{
			Game game = new Game();
			base.BuildObjectFromJSONTree(game, gameJSONObject);
			if (gameJSONObject["scores"] != null && gameJSONObject["scores"]["score"] != null)
			{
				if (gameJSONObject["scores"]["score"] is JSONObject)
				{
					JSONNode jsonnode = (JSONObject)gameJSONObject["scores"]["score"];
					Game.Score score = new Game.Score(game);
					base.BuildObjectFromJSONTree(score, jsonnode);
					if (jsonnode["facebookProfile"] != null && jsonnode["facebookProfile"] is JSONObject)
					{
						JSONNode jsonObj = (JSONObject)jsonnode["facebookProfile"];
						Game.Score.FacebookProfile obj = new Game.Score.FacebookProfile(score);
						base.BuildObjectFromJSONTree(obj, jsonObj);
					}
					if (jsonnode["jsonDoc"] != null)
					{
						if (jsonnode["jsonDoc"] is JSONObject)
						{
							JSONNode jsonObjDoc = (JSONObject)jsonnode["jsonDoc"];
							MetaResponse.JSONDocument document = new MetaResponse.JSONDocument(score);
							this.BuildJsonDocument(document, jsonObjDoc);
						}
						else
						{
							JSONArray jsonarray = (JSONArray)jsonnode["jsonDoc"];
							for (int i = 0; i < jsonarray.Count; i++)
							{
								JSONNode jsonObjDoc2 = (JSONObject)jsonarray[i];
								MetaResponse.JSONDocument document2 = new MetaResponse.JSONDocument(score);
								this.BuildJsonDocument(document2, jsonObjDoc2);
							}
						}
					}
				}
				else
				{
					JSONArray jsonarray2 = (JSONArray)gameJSONObject["scores"]["score"];
					for (int j = 0; j < jsonarray2.Count; j++)
					{
						JSONNode jsonnode2 = (JSONObject)jsonarray2[j];
						Game.Score score2 = new Game.Score(game);
						base.BuildObjectFromJSONTree(score2, jsonnode2);
						if (jsonnode2["facebookProfile"] != null && jsonnode2["facebookProfile"] is JSONObject)
						{
							JSONNode jsonObj2 = (JSONObject)jsonnode2["facebookProfile"];
							Game.Score.FacebookProfile obj2 = new Game.Score.FacebookProfile(score2);
							base.BuildObjectFromJSONTree(obj2, jsonObj2);
						}
						if (jsonnode2["jsonDoc"] != null)
						{
							if (jsonnode2["jsonDoc"] is JSONObject)
							{
								JSONObject jsonObjDoc3 = (JSONObject)jsonnode2["jsonDoc"];
								MetaResponse.JSONDocument document3 = new MetaResponse.JSONDocument(score2);
								this.BuildJsonDocument(document3, jsonObjDoc3);
							}
							else
							{
								JSONArray jsonarray3 = (JSONArray)jsonnode2["jsonDoc"];
								for (int k = 0; k < jsonarray3.Count; k++)
								{
									JSONNode jsonObjDoc4 = (JSONObject)jsonarray3[k];
									MetaResponse.JSONDocument document4 = new MetaResponse.JSONDocument(score2);
									this.BuildJsonDocument(document4, jsonObjDoc4);
								}
							}
						}
					}
				}
			}
			return game;
		}

		// Token: 0x060002DD RID: 733 RVA: 0x00010104 File Offset: 0x0000E304
		private void BuildJsonDocument(MetaResponse.JSONDocument document, JSONNode jsonObjDoc)
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
			if ((jsonObjDoc["_$event"] ?? "") != null)
			{
				string @event = jsonObjDoc["_$event"] ?? "";
				document.SetEvent(@event);
				jsonObjDoc.Remove("_$event");
				document.SetJsonDoc(jsonObjDoc.ToString());
			}
			if ((jsonObjDoc["_$createdAt"] ?? "") != null)
			{
				string createdAt = jsonObjDoc["_$createdAt"] ?? "";
				document.SetCreatedAt(createdAt);
				jsonObjDoc.Remove("_$createdAt");
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
