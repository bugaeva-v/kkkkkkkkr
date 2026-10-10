using System;
using System.Collections.Generic;
using SimpleJSON;

namespace com.shephertz.app42.paas.sdk.csharp.gallery
{
	// Token: 0x02000010 RID: 16
	public class AlbumResponseBuilder : App42ResponseBuilder
	{
		// Token: 0x06000082 RID: 130 RVA: 0x00003CB8 File Offset: 0x00001EB8
		public Album BuildResponse(string json)
		{
			JSONNode serviceJSONObject = base.GetServiceJSONObject("albums", json);
			if (serviceJSONObject == null)
			{
				Album album = new Album();
				album.SetStrResponse(json);
				album.SetResponseSuccess(base.IsResponseSuccess(json));
				album.SetTotalRecords(base.GetTotalRecords(json));
				return album;
			}
			JSONNode jsonnode = (JSONObject)serviceJSONObject["album"];
			Album album2 = new Album();
			album2.SetStrResponse(json);
			album2.SetResponseSuccess(base.IsResponseSuccess(json));
			base.BuildObjectFromJSONTree(album2, jsonnode);
			object obj = jsonnode["photos"];
			if (obj != null)
			{
				if (jsonnode["photos"]["photo"] != null && jsonnode["photos"]["photo"] is JSONObject)
				{
					Album.Photo photo = new Album.Photo(album2);
					JSONNode jsonnode2 = (JSONObject)jsonnode["photos"]["photo"];
					base.BuildObjectFromJSONTree(photo, jsonnode2);
					photo = this.SetTagList(photo, jsonnode2);
				}
				else if (jsonnode["photos"]["photo"] != null && jsonnode["photos"]["photo"] is JSONArray)
				{
					JSONArray jsonarray = (JSONArray)jsonnode["photos"]["photo"];
					for (int i = 0; i < jsonarray.Count; i++)
					{
						JSONNode jsonnode3 = (JSONObject)jsonarray[i];
						Album.Photo photo2 = new Album.Photo(album2);
						base.BuildObjectFromJSONTree(photo2, jsonnode3);
						photo2 = this.SetTagList(photo2, jsonnode3);
					}
				}
				return album2;
			}
			return album2;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00003E64 File Offset: 0x00002064
		private Album BuildAlbumObject(JSONNode albumsJSONObj)
		{
			Album album = new Album();
			base.BuildObjectFromJSONTree(album, albumsJSONObj);
			if (albumsJSONObj["photos"] != null && albumsJSONObj["photos"]["photo"] != null)
			{
				if (albumsJSONObj["photos"]["photo"] is JSONObject)
				{
					JSONNode jsonnode = (JSONObject)albumsJSONObj["photos"]["photo"];
					Album.Photo photo = new Album.Photo(album);
					base.BuildObjectFromJSONTree(photo, jsonnode);
					photo = this.SetTagList(photo, jsonnode);
				}
				else
				{
					JSONArray jsonarray = (JSONArray)albumsJSONObj["photos"]["photo"];
					for (int i = 0; i < jsonarray.Count; i++)
					{
						JSONNode jsonnode2 = (JSONObject)jsonarray[i];
						Album.Photo photo2 = new Album.Photo(album);
						base.BuildObjectFromJSONTree(photo2, jsonnode2);
						photo2 = this.SetTagList(photo2, jsonnode2);
					}
				}
			}
			return album;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00003F64 File Offset: 0x00002164
		public IList<Album> BuildArrayResponse(string json)
		{
			JSONNode serviceJSONObject = base.GetServiceJSONObject("albums", json);
			IList<Album> list = new List<Album>();
			if (serviceJSONObject["album"] is JSONArray)
			{
				JSONArray jsonarray = (JSONArray)serviceJSONObject["album"];
				for (int i = 0; i < jsonarray.Count; i++)
				{
					JSONNode albumsJSONObj = (JSONObject)jsonarray[i];
					Album album = this.BuildAlbumObject(albumsJSONObj);
					album.SetStrResponse(json);
					album.SetResponseSuccess(base.IsResponseSuccess(json));
					album.SetTotalRecords(base.GetTotalRecords(json));
					list.Add(album);
				}
			}
			else
			{
				JSONNode albumsJSONObj2 = (JSONObject)serviceJSONObject["album"];
				Album album2 = this.BuildAlbumObject(albumsJSONObj2);
				album2.SetStrResponse(json);
				album2.SetResponseSuccess(base.IsResponseSuccess(json));
				album2.SetTotalRecords(base.GetTotalRecords(json));
				list.Add(album2);
			}
			return list;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00004048 File Offset: 0x00002248
		private Album.Photo SetTagList(Album.Photo photoObj, JSONNode photoJsonObj)
		{
			if (photoJsonObj["tags"] != null)
			{
				IList<string> list = new List<string>();
				if (photoJsonObj["tags"] is JSONArray)
				{
					JSONArray jsonarray = (JSONArray)photoJsonObj["tags"];
					for (int i = 0; i < jsonarray.Count; i++)
					{
						list.Add(jsonarray[i].ToString());
					}
				}
				else
				{
					list.Add(photoJsonObj["tags"].ToString());
				}
				photoObj.SetTagList(list);
			}
			return photoObj;
		}
	}
}
