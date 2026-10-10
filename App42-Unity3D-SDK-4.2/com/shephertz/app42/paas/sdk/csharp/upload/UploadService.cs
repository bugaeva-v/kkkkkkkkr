using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using com.shephertz.app42.paas.sdk.csharp.connection;
using com.shephertz.app42.paas.sdk.csharp.util;
using SimpleJSON;

namespace com.shephertz.app42.paas.sdk.csharp.upload
{
	// Token: 0x020000C2 RID: 194
	public class UploadService : App42Service
	{
		// Token: 0x06000834 RID: 2100 RVA: 0x000300D9 File Offset: 0x0002E2D9
		public UploadService(string apiKey, string secretKey)
		{
			this.apiKey = apiKey;
			this.secretKey = secretKey;
			this.version = "1.0";
			this.resource = "upload";
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x00030108 File Offset: 0x0002E308
		public void UploadFile(string name, string filePath, string fileType, string description, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(name, "Name");
			Util.ThrowExceptionIfNullOrBlank(filePath, "Filepath");
			Util.ThrowExceptionIfNullOrBlank(fileType, "FileType");
			Util.ThrowExceptionIfNullOrBlank(description, "Description");
			if (!UploadFileType.IsValidType(fileType))
			{
				throw new App42Exception("Not a valid file type !");
			}
			Dictionary<string, string> queryParams = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
			dictionary3.Add("name", name);
			dictionary3.Add("type", fileType);
			dictionary3.Add("description", description);
			foreach (KeyValuePair<string, string> keyValuePair in dictionary3)
			{
				dictionary.Add(keyValuePair.Key, keyValuePair.Value);
			}
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource;
			RESTConnectorWWW.GetInstance().ExecuteMultipart("uploadFile", filePath, queryParams, dictionary3, dictionary, dictionary2, url, Config.GetInstance().GetAccept(), callBack);
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x00030250 File Offset: 0x0002E450
		public void UploadFile(string name, Stream inputStream, string fileType, string description, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(name, "Name");
			Util.ThrowExceptionIfNullOrBlank(inputStream, "inputStream");
			Util.ThrowExceptionIfNullOrBlank(fileType, "FileType");
			Util.ThrowExceptionIfNullOrBlank(description, "Description");
			Dictionary<string, string> queryParams = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
			dictionary3.Add("name", name);
			dictionary3.Add("type", fileType);
			dictionary3.Add("description", description);
			foreach (KeyValuePair<string, string> keyValuePair in dictionary3)
			{
				dictionary.Add(keyValuePair.Key, keyValuePair.Value);
			}
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource;
			RESTConnectorWWW.GetInstance().ExecuteMultipart("uploadFile", inputStream, queryParams, dictionary3, dictionary, dictionary2, url, Config.GetInstance().GetAccept(), callBack);
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x00030384 File Offset: 0x0002E584
		public void UploadFileForUser(string name, string userName, string filePath, string fileType, string description, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(name, "Name");
			Util.ThrowExceptionIfNullOrBlank(filePath, "Filepath");
			Util.ThrowExceptionIfNullOrBlank(fileType, "FileType");
			Util.ThrowExceptionIfNullOrBlank(userName, "User Name");
			Util.ThrowExceptionIfNullOrBlank(description, "Description");
			if (!UploadFileType.IsValidType(fileType))
			{
				throw new App42Exception("Not a valid file type !");
			}
			Dictionary<string, string> queryParams = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
			dictionary3.Add("name", name);
			dictionary3.Add("userName", userName);
			dictionary3.Add("type", fileType);
			dictionary3.Add("description", description);
			foreach (KeyValuePair<string, string> keyValuePair in dictionary3)
			{
				dictionary.Add(keyValuePair.Key, keyValuePair.Value);
			}
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
			RESTConnectorWWW.GetInstance().ExecuteMultipart("uploadFile", filePath, queryParams, dictionary3, dictionary, dictionary2, url, Config.GetInstance().GetAccept(), callBack);
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x0003050C File Offset: 0x0002E70C
		public void UploadFileForUser(string name, string userName, Stream inputStream, string fileType, string description, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(name, "Name");
			Util.ThrowExceptionIfNullOrBlank(inputStream, "InputStream");
			Util.ThrowExceptionIfNullOrBlank(fileType, "FileType");
			Util.ThrowExceptionIfNullOrBlank(userName, "User Name");
			Util.ThrowExceptionIfNullOrBlank(description, "Description");
			if (!UploadFileType.IsValidType(fileType))
			{
				throw new App42Exception("Not a valid file type !");
			}
			Dictionary<string, string> queryParams = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
			dictionary3.Add("name", name);
			dictionary3.Add("userName", userName);
			dictionary3.Add("type", fileType);
			dictionary3.Add("description", description);
			foreach (KeyValuePair<string, string> keyValuePair in dictionary3)
			{
				dictionary.Add(keyValuePair.Key, keyValuePair.Value);
			}
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
			RESTConnectorWWW.GetInstance().ExecuteMultipart("uploadFile", inputStream, queryParams, dictionary3, dictionary, dictionary2, url, Config.GetInstance().GetAccept(), callBack);
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x00030694 File Offset: 0x0002E894
		public void GetAllFiles(App42CallBack callBack)
		{
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource;
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x00030708 File Offset: 0x0002E908
		public void GetFileByUser(string name, string userName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(name, "Name");
			Util.ThrowExceptionIfNullOrBlank(userName, "User Name");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("name", name);
			dictionary.Add("userName", userName);
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
				name
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x000307DC File Offset: 0x0002E9DC
		public void GetAllFilesByUser(string userName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, " UserName");
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
				"/user/",
				userName
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x0003088C File Offset: 0x0002EA8C
		public void GetFileByName(string name, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(name, "Name");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("name", name);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/",
				name
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x0003093C File Offset: 0x0002EB3C
		public void RemoveFileByUser(string name, string userName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(name, "Name");
			Util.ThrowExceptionIfNullOrBlank(userName, "User Name");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("name", name);
			dictionary.Add("userName", userName);
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
				name
			});
			RESTConnectorWWW.GetInstance().ExecuteDelete(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x00030A10 File Offset: 0x0002EC10
		public void RemoveFileByName(string name, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(name, "Name");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("name", name);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/",
				name
			});
			RESTConnectorWWW.GetInstance().ExecuteDelete(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x00030AC0 File Offset: 0x0002ECC0
		public void RemoveAllFilesByUser(string userName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "User Name");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary.Add("userName", userName);
			dictionary2 = base.Merge(dictionary, obj);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/user/",
				userName
			});
			RESTConnectorWWW.GetInstance().ExecuteDelete(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x00030B70 File Offset: 0x0002ED70
		public void RemoveAllFiles(App42CallBack callBack)
		{
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource;
			RESTConnectorWWW.GetInstance().ExecuteDelete(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x00030BE4 File Offset: 0x0002EDE4
		public void GetFilesByType(string fileType, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(fileType, "FileType");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("type", fileType);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/type/",
				fileType
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x00030C94 File Offset: 0x0002EE94
		public void GetAllFiles(int max, int offset, App42CallBack callBack)
		{
			Util.ValidateMax(max);
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("max", string.Concat(max));
			dictionary.Add("offset", string.Concat(offset));
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new object[]
			{
				this.version,
				"/",
				this.resource,
				"/paging/",
				max,
				"/",
				offset
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x00030D78 File Offset: 0x0002EF78
		public void GetAllFilesByUser(string userName, int max, int offset, App42CallBack callBack)
		{
			Util.ValidateMax(max);
			Util.ThrowExceptionIfNullOrBlank(userName, "User Name");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("userName", userName);
			dictionary.Add("max", string.Concat(max));
			dictionary.Add("offset", string.Concat(offset));
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new object[]
			{
				this.version,
				"/",
				this.resource,
				"/user/",
				userName,
				"/",
				max,
				"/",
				offset
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x00030E84 File Offset: 0x0002F084
		public void GetFilesByType(string uploadFileType, int max, int offset, App42CallBack callBack)
		{
			Util.ValidateMax(max);
			Util.ThrowExceptionIfNullOrBlank(uploadFileType, "uploadFileType");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("type", uploadFileType ?? "");
			dictionary.Add("max", string.Concat(max));
			dictionary.Add("offset", string.Concat(offset));
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new object[]
			{
				this.version,
				"/",
				this.resource,
				"/type/",
				uploadFileType,
				"/",
				max,
				"/",
				offset
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x00030F98 File Offset: 0x0002F198
		public void GetAllFilesCount(App42CallBack callBack)
		{
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/count";
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x00031014 File Offset: 0x0002F214
		public void GetAllFilesCountByUser(string userName, App42CallBack callBack)
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
				"/user/",
				userName,
				"/count"
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x000310CC File Offset: 0x0002F2CC
		public void GetFilesCountByType(string uploadFileType, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(uploadFileType, "uploadFileType");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("type", uploadFileType);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/type/",
				uploadFileType,
				"/count"
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x00031184 File Offset: 0x0002F384
		public void RevokeAccess(string fileName, string userName, HashSet<ACL> aclList, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(fileName, "FileName");
			Util.ThrowExceptionIfNullOrBlank(userName, "UserName");
			Util.ThrowExceptionIfNullOrBlank(aclList, "acl");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("fileName", fileName);
			dictionary.Add("userName", userName);
			JSONArray jsonarray = new JSONArray();
			foreach (ACL acl in aclList)
			{
				jsonarray.Add(acl.GetJSONObject());
			}
			JSONObject jsonobject = new JSONObject();
			jsonobject.Add("acls", "{\"acl\":" + jsonarray.ToString() + "}");
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"app42\":{\"upload\":").Append(jsonobject.ToString()).Append("}}");
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
				fileName
			});
			RESTConnectorWWW.GetInstance().ExecutePut(url, paramsDics, stringBuilder.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x00031328 File Offset: 0x0002F528
		public void GrantAccess(string fileName, string userName, HashSet<ACL> aclList, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(fileName, "FileName");
			Util.ThrowExceptionIfNullOrBlank(userName, "UserName");
			Util.ThrowExceptionIfNullOrBlank(aclList, "acl");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("fileName", fileName);
			dictionary.Add("userName", userName);
			JSONArray jsonarray = new JSONArray();
			foreach (ACL acl in aclList)
			{
				jsonarray.Add(acl.GetJSONObject());
			}
			JSONObject jsonobject = new JSONObject();
			jsonobject.Add("acls", "{\"acl\":" + jsonarray.ToString() + "}");
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"app42\":{\"upload\":").Append(jsonobject.ToString()).Append("}}");
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
				fileName
			});
			RESTConnectorWWW.GetInstance().ExecutePut(url, paramsDics, stringBuilder.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x000314CC File Offset: 0x0002F6CC
		public void UploadFileForGroup(string name, string userName, string ownerName, string groupName, string filePath, string fileType, string description, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(name, "File Name");
			Util.ThrowExceptionIfNullOrBlank(userName, "User Name");
			Util.ThrowExceptionIfNullOrBlank(filePath, "Filepath");
			Util.ThrowExceptionIfNullOrBlank(fileType, "fileType");
			Util.ThrowExceptionIfNullOrBlank(description, "Description");
			Dictionary<string, string> queryParams = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
			dictionary3.Add("name", name);
			dictionary3.Add("userName", userName);
			dictionary3.Add("ownerName", ownerName);
			dictionary3.Add("groupName", groupName);
			dictionary3.Add("type", fileType ?? "");
			dictionary3.Add("description", description);
			foreach (KeyValuePair<string, string> keyValuePair in dictionary3)
			{
				dictionary.Add(keyValuePair.Key, keyValuePair.Value);
			}
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/group/",
				userName
			});
			RESTConnectorWWW.GetInstance().ExecuteMultipart("uploadFile", filePath, queryParams, dictionary3, dictionary, dictionary2, url, Config.GetInstance().GetAccept(), callBack);
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x00031664 File Offset: 0x0002F864
		public void UploadFileForGroup(string name, string userName, string ownerName, string groupName, Stream inputStream, string fileType, string description, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(name, "File Name");
			Util.ThrowExceptionIfNullOrBlank(userName, "User Name");
			Util.ThrowExceptionIfNullOrBlank(inputStream, "InputStream");
			Util.ThrowExceptionIfNullOrBlank(fileType, "fileType");
			Util.ThrowExceptionIfNullOrBlank(description, "Description");
			Dictionary<string, string> queryParams = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
			dictionary3.Add("name", name);
			dictionary3.Add("userName", userName);
			dictionary3.Add("ownerName", ownerName);
			dictionary3.Add("groupName", groupName);
			dictionary3.Add("type", fileType ?? "");
			dictionary3.Add("description", description);
			foreach (KeyValuePair<string, string> keyValuePair in dictionary3)
			{
				dictionary.Add(keyValuePair.Key, keyValuePair.Value);
			}
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/group/",
				userName
			});
			RESTConnectorWWW.GetInstance().ExecuteMultipart("uploadFile", inputStream, queryParams, dictionary3, dictionary, dictionary2, url, Config.GetInstance().GetAccept(), callBack);
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x000317FC File Offset: 0x0002F9FC
		public void UploadFileForFriend(string name, string userName, string buddyName, string filePath, string fileType, string description, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(name, "File Name");
			Util.ThrowExceptionIfNullOrBlank(userName, "User Name");
			Util.ThrowExceptionIfNullOrBlank(filePath, "Filepath");
			Util.ThrowExceptionIfNullOrBlank(fileType, "fileType");
			Util.ThrowExceptionIfNullOrBlank(description, "Description");
			Dictionary<string, string> queryParams = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
			dictionary3.Add("name", name);
			dictionary3.Add("userName", userName);
			dictionary3.Add("buddyName", buddyName);
			dictionary3.Add("type", fileType ?? "");
			dictionary3.Add("description", description);
			foreach (KeyValuePair<string, string> keyValuePair in dictionary3)
			{
				dictionary.Add(keyValuePair.Key, keyValuePair.Value);
			}
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/friend/",
				userName
			});
			RESTConnectorWWW.GetInstance().ExecuteMultipart("uploadFile", filePath, queryParams, dictionary3, dictionary, dictionary2, url, Config.GetInstance().GetAccept(), callBack);
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x00031988 File Offset: 0x0002FB88
		public void UploadFileForFriend(string name, string userName, string buddyName, Stream inputStream, string fileType, string description, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(name, "File Name");
			Util.ThrowExceptionIfNullOrBlank(userName, "User Name");
			Util.ThrowExceptionIfNullOrBlank(inputStream, "InputStream");
			Util.ThrowExceptionIfNullOrBlank(fileType, "fileType");
			Util.ThrowExceptionIfNullOrBlank(description, "Description");
			Dictionary<string, string> queryParams = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
			dictionary3.Add("name", name);
			dictionary3.Add("userName", userName);
			dictionary3.Add("buddyName", buddyName);
			dictionary3.Add("type", fileType ?? "");
			dictionary3.Add("description", description);
			foreach (KeyValuePair<string, string> keyValuePair in dictionary3)
			{
				dictionary.Add(keyValuePair.Key, keyValuePair.Value);
			}
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/friend/",
				userName
			});
			RESTConnectorWWW.GetInstance().ExecuteMultipart("uploadFile", inputStream, queryParams, dictionary3, dictionary, dictionary2, url, Config.GetInstance().GetAccept(), callBack);
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x00031B14 File Offset: 0x0002FD14
		public void UploadFileForFriends(string name, string userName, string filePath, string fileType, string description, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(name, "File Name");
			Util.ThrowExceptionIfNullOrBlank(userName, "User Name");
			Util.ThrowExceptionIfNullOrBlank(filePath, "Filepath");
			Util.ThrowExceptionIfNullOrBlank(fileType, "fileType");
			Util.ThrowExceptionIfNullOrBlank(description, "Description");
			Dictionary<string, string> queryParams = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
			dictionary3.Add("name", name);
			dictionary3.Add("userName", userName);
			dictionary3.Add("type", fileType ?? "");
			dictionary3.Add("description", description);
			foreach (KeyValuePair<string, string> keyValuePair in dictionary3)
			{
				dictionary.Add(keyValuePair.Key, keyValuePair.Value);
			}
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/friendsAll/",
				userName
			});
			RESTConnectorWWW.GetInstance().ExecuteMultipart("uploadFile", filePath, queryParams, dictionary3, dictionary, dictionary2, url, Config.GetInstance().GetAccept(), callBack);
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x00031C90 File Offset: 0x0002FE90
		public void UploadFileForFriends(string name, string userName, Stream inputStream, string fileType, string description, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(name, "File Name");
			Util.ThrowExceptionIfNullOrBlank(userName, "User Name");
			Util.ThrowExceptionIfNullOrBlank(inputStream, "InputStream");
			Util.ThrowExceptionIfNullOrBlank(fileType, "fileType");
			Util.ThrowExceptionIfNullOrBlank(description, "Description");
			Dictionary<string, string> queryParams = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
			dictionary3.Add("name", name);
			dictionary3.Add("userName", userName);
			dictionary3.Add("type", fileType ?? "");
			dictionary3.Add("description", description);
			foreach (KeyValuePair<string, string> keyValuePair in dictionary3)
			{
				dictionary.Add(keyValuePair.Key, keyValuePair.Value);
			}
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/friendsAll/",
				userName
			});
			RESTConnectorWWW.GetInstance().ExecuteMultipart("uploadFile", inputStream, queryParams, dictionary3, dictionary, dictionary2, url, Config.GetInstance().GetAccept(), callBack);
		}
	}
}
