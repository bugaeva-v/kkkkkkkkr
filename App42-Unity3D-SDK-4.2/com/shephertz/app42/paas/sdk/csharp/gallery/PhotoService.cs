using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using com.shephertz.app42.paas.sdk.csharp.connection;
using com.shephertz.app42.paas.sdk.csharp.util;
using SimpleJSON;

namespace com.shephertz.app42.paas.sdk.csharp.gallery
{
	// Token: 0x0200007C RID: 124
	public class PhotoService : App42Service
	{
		// Token: 0x06000510 RID: 1296 RVA: 0x0001B1FD File Offset: 0x000193FD
		public PhotoService(string apiKey, string secretKey)
		{
			this.apiKey = apiKey;
			this.secretKey = secretKey;
			this.version = "1.0";
			this.resource = "gallery";
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x0001B22C File Offset: 0x0001942C
		public void AddPhoto(string userName, string albumName, string photoName, string photoDescription, string path, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "User Name");
			Util.ThrowExceptionIfNullOrBlank(albumName, "Album Name");
			Util.ThrowExceptionIfNullOrBlank(photoName, "Photo Name");
			Util.ThrowExceptionIfNullOrBlank(photoDescription, "Description");
			Util.ThrowExceptionIfNullOrBlank(path, "Path");
			Dictionary<string, string> queryParams = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
			dictionary3.Add("userName", userName);
			dictionary3.Add("albumName", albumName);
			dictionary3.Add("name", photoName);
			dictionary3.Add("description", photoDescription);
			dictionary.Add("userName", userName);
			dictionary.Add("albumName", albumName);
			dictionary.Add("name", photoName);
			dictionary.Add("description", photoDescription);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/",
				userName
			});
			RESTConnectorWWW.GetInstance().ExecuteMultipart("imageFile", path, queryParams, dictionary3, dictionary, dictionary2, url, Config.GetInstance().GetAccept(), callBack);
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x0001B380 File Offset: 0x00019580
		public void AddPhoto(string userName, string albumName, string photoName, string photoDescription, Stream inputStream, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "User Name");
			Util.ThrowExceptionIfNullOrBlank(albumName, "Album Name");
			Util.ThrowExceptionIfNullOrBlank(photoName, "Photo Name");
			Util.ThrowExceptionIfNullOrBlank(photoDescription, "Description");
			Util.ThrowExceptionIfNullOrBlank(inputStream, "InputStream");
			Dictionary<string, string> queryParams = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
			dictionary3.Add("userName", userName);
			dictionary3.Add("albumName", albumName);
			dictionary3.Add("name", photoName);
			dictionary3.Add("description", photoDescription);
			dictionary.Add("userName", userName);
			dictionary.Add("albumName", albumName);
			dictionary.Add("name", photoName);
			dictionary.Add("description", photoDescription);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/",
				userName
			});
			RESTConnectorWWW.GetInstance().ExecuteMultipart("imageFile", inputStream, queryParams, dictionary3, dictionary, dictionary2, url, Config.GetInstance().GetAccept(), callBack);
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x0001B4D4 File Offset: 0x000196D4
		public void AddTagToPhoto(string userName, string albumName, string photoName, IList<string> tagList, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "User Name");
			Util.ThrowExceptionIfNullOrBlank(albumName, "Album Name");
			Util.ThrowExceptionIfNullOrBlank(photoName, "Photo Name");
			Util.ThrowExceptionIfNullOrBlank(tagList, "TagList");
			if (tagList.Count == 0)
			{
				throw new App42Exception("TagList cannot be empty.Please add the name to be tagged");
			}
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"userName\":\"" + userName + "\",");
			stringBuilder.Append("\"albumName\":\"" + albumName + "\",");
			stringBuilder.Append("\"photoName\":\"" + photoName + "\",");
			JSONArray jsonarray = new JSONArray();
			for (int i = 0; i < tagList.Count; i++)
			{
				string text = tagList[i];
				jsonarray.Add(text.ToString());
			}
			stringBuilder.Append("\"tags\":{\"tag\":" + jsonarray.ToString() + "}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"photo\":").Append(stringBuilder.ToString()).Append("}}}");
			App42Log.Console(" Json String : " + stringBuilder2.ToString());
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/tag";
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x0001B690 File Offset: 0x00019890
		public void GetPhotos(string userName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "User Name");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("userName", userName);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/",
				userName
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x0001B740 File Offset: 0x00019940
		public void GetTaggedPhotos(string userName, string tag, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "User Name");
			Util.ThrowExceptionIfNullOrBlank(tag, "Tag");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("userName", userName);
			dictionary.Add("tag", tag);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			dictionary2.Add("isArray", "true");
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/tag/",
				tag,
				"/userName/",
				userName
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x0001B824 File Offset: 0x00019A24
		public void GetPhotosByAlbumName(string userName, string albumName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "User Name");
			Util.ThrowExceptionIfNullOrBlank(albumName, "Album Name");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("userName", userName);
			dictionary.Add("albumName", albumName);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/",
				userName,
				"/",
				albumName
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x0001B8F8 File Offset: 0x00019AF8
		public void GetPhotosByAlbumName(string userName, string albumName, int max, int offset, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "User Name");
			Util.ThrowExceptionIfNullOrBlank(albumName, "Album Name");
			Util.ValidateMax(max);
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("userName", userName);
			dictionary.Add("albumName", albumName);
			dictionary.Add("max", string.Concat(max));
			dictionary.Add("offset", string.Concat(offset));
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new object[]
			{
				this.version,
				"/",
				this.resource,
				"/album/",
				userName,
				"/",
				albumName,
				"/paging/",
				max,
				"/",
				offset
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x0001BA2C File Offset: 0x00019C2C
		public void GetPhotosByAlbumAndPhotoName(string userName, string albumName, string photoName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "User Name");
			Util.ThrowExceptionIfNullOrBlank(albumName, "Album Name");
			Util.ThrowExceptionIfNullOrBlank(photoName, "Photo Name");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("userName", userName);
			dictionary.Add("albumName", albumName);
			dictionary.Add("name", photoName);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/",
				userName,
				"/",
				albumName,
				"/",
				photoName
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x0001BB28 File Offset: 0x00019D28
		public void RemovePhoto(string userName, string albumName, string photoName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "User Name");
			Util.ThrowExceptionIfNullOrBlank(albumName, "Album Name");
			Util.ThrowExceptionIfNullOrBlank(photoName, "Photo Name");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("userName", userName);
			dictionary.Add("albumName", albumName);
			dictionary.Add("name", photoName);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/",
				userName,
				"/",
				albumName,
				"/",
				photoName
			});
			RESTConnectorWWW.GetInstance().ExecuteDelete(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x0001BC24 File Offset: 0x00019E24
		public void GetPhotosCountByAlbumName(string userName, string albumName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "User Name");
			Util.ThrowExceptionIfNullOrBlank(albumName, "Album Name");
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("userName", userName);
			dictionary.Add("albumName", albumName);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/",
				userName,
				"/",
				albumName,
				"/count"
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, dictionary, dictionary, dictionary2, callBack);
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x0001BCFC File Offset: 0x00019EFC
		public void GrantAccess(string albumName, string photoName, string userName, IList<ACL> aclList, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(albumName, "albumName");
			Util.ThrowExceptionIfNullOrBlank(photoName, "photoName");
			Util.ThrowExceptionIfNullOrBlank(userName, "userName");
			Util.ThrowExceptionIfNullOrBlank(aclList, "aclList");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("albumName", albumName);
			dictionary.Add("photoName", photoName);
			dictionary.Add("userName", userName);
			JSONArray jsonarray = new JSONArray();
			for (int i = 0; i < aclList.Count; i++)
			{
				jsonarray.Add(aclList[i].GetJSONObject());
			}
			JSONObject jsonobject = new JSONObject();
			jsonobject.Add("acls", "{\"acl\":" + jsonarray + "}");
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"app42\":{\"photo\":").Append(jsonobject.ToString()).Append("}}");
			dictionary.Add("body", stringBuilder.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/grantAccess/",
				userName,
				"/",
				albumName,
				"/",
				photoName
			});
			RESTConnectorWWW.GetInstance().ExecutePut(url, paramsDics, stringBuilder.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x0001BEA8 File Offset: 0x0001A0A8
		public void RevokeAccess(string albumName, string photoName, string userName, IList<ACL> aclList, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(albumName, "albumName");
			Util.ThrowExceptionIfNullOrBlank(photoName, "photoName");
			Util.ThrowExceptionIfNullOrBlank(userName, "userName");
			Util.ThrowExceptionIfNullOrBlank(aclList, "aclList");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("albumName", albumName);
			dictionary.Add("photoName", photoName);
			dictionary.Add("userName", userName);
			JSONArray jsonarray = new JSONArray();
			for (int i = 0; i < aclList.Count; i++)
			{
				jsonarray.Add(aclList[i].GetJSONObject());
			}
			JSONObject jsonobject = new JSONObject();
			jsonobject.Add("acls", "{\"acl\":" + jsonarray + "}");
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"app42\":{\"photo\":").Append(jsonobject.ToString()).Append("}}");
			dictionary.Add("body", stringBuilder.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/revokeAccess/",
				userName,
				"/",
				albumName,
				"/",
				photoName
			});
			RESTConnectorWWW.GetInstance().ExecutePut(url, paramsDics, stringBuilder.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x0001C054 File Offset: 0x0001A254
		public void UpdatePhoto(string userName, string albumName, string photoName, string photoDescription, string path, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "User Name");
			Util.ThrowExceptionIfNullOrBlank(albumName, "Album Name");
			Util.ThrowExceptionIfNullOrBlank(photoName, "Photo Name");
			Util.ThrowExceptionIfNullOrBlank(photoDescription, "Description");
			Util.ThrowExceptionIfNullOrBlank(path, "Path");
			Dictionary<string, string> queryParams = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
			dictionary3.Add("userName", userName);
			dictionary3.Add("albumName", albumName);
			dictionary3.Add("name", photoName);
			dictionary3.Add("description", photoDescription);
			foreach (KeyValuePair<string, string> keyValuePair in dictionary3)
			{
				dictionary.Add(keyValuePair.Key, keyValuePair.Value);
			}
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				Config.GetInstance().GetBaseURL(),
				this.version,
				"/",
				this.resource,
				"/update/",
				userName
			});
			RESTConnectorWWW.GetInstance().ExecuteMultipart("imageFile", path, queryParams, dictionary3, dictionary, dictionary2, url, Config.GetInstance().GetAccept(), callBack);
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x0001C1D4 File Offset: 0x0001A3D4
		public void UpdatePhoto(string userName, string albumName, string photoName, string photoDescription, Stream inputStream, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "User Name");
			Util.ThrowExceptionIfNullOrBlank(albumName, "Album Name");
			Util.ThrowExceptionIfNullOrBlank(photoName, "Photo Name");
			Util.ThrowExceptionIfNullOrBlank(photoDescription, "Description");
			Util.ThrowExceptionIfNullOrBlank(inputStream, "InputStream");
			Dictionary<string, string> queryParams = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
			dictionary3.Add("userName", userName);
			dictionary3.Add("albumName", albumName);
			dictionary3.Add("name", photoName);
			dictionary3.Add("description", photoDescription);
			foreach (KeyValuePair<string, string> keyValuePair in dictionary3)
			{
				dictionary.Add(keyValuePair.Key, keyValuePair.Value);
			}
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				Config.GetInstance().GetBaseURL(),
				this.version,
				"/",
				this.resource,
				"/update/",
				userName
			});
			RESTConnectorWWW.GetInstance().ExecuteMultipart("imageFile", inputStream, queryParams, dictionary3, dictionary, dictionary2, url, Config.GetInstance().GetAccept(), callBack);
		}
	}
}
