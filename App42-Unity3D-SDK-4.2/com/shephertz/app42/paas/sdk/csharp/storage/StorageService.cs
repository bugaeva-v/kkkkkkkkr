using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using com.shephertz.app42.paas.sdk.csharp.connection;
using com.shephertz.app42.paas.sdk.csharp.util;
using CSharpAssemble;
using SimpleJSON;

namespace com.shephertz.app42.paas.sdk.csharp.storage
{
	// Token: 0x020000B9 RID: 185
	public class StorageService : App42Service
	{
		// Token: 0x060007D2 RID: 2002 RVA: 0x0002C60B File Offset: 0x0002A80B
		public StorageService(string apiKey, string secretKey)
		{
			this.apiKey = apiKey;
			this.secretKey = secretKey;
			this.version = "1.0";
			this.resource = "storage";
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x0002C638 File Offset: 0x0002A838
		public void InsertJSONDocument(string dbName, string collectionName, string json, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(dbName, "DataBaseName");
			Util.ThrowExceptionIfNullOrBlank(collectionName, "CollectionName");
			Util.ThrowExceptionIfNullOrBlank(json, "Json");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("dbName", dbName);
			dictionary.Add("collectionName", collectionName);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"jsonDoc\":" + json);
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"storage\":").Append(stringBuilder.ToString()).Append("}}}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/insert/dbName/",
				dbName,
				"/collectionName/",
				collectionName
			});
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x0002C774 File Offset: 0x0002A974
		public void InsertJSONDocument(string dbName, string collectionName, JSONObject json, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(dbName, "DataBaseName");
			Util.ThrowExceptionIfNullOrBlank(collectionName, "CollectionName");
			Util.ThrowExceptionIfNullOrBlank(json, "Json");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("dbName", dbName);
			dictionary.Add("collectionName", collectionName);
			JSONObject jsonobject = new JSONObject();
			jsonobject.Add("jsonDoc", json);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"app42\":{\"storage\":").Append(jsonobject.ToString()).Append("}}");
			dictionary.Add("body", stringBuilder.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/insert/dbName/",
				dbName,
				"/collectionName/",
				collectionName
			});
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x0002C8AC File Offset: 0x0002AAAC
		public void InsertJSONDocument(string dbName, string collectionName, Dictionary<string, object> json, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(dbName, "DataBaseName");
			Util.ThrowExceptionIfNullOrBlank(collectionName, "CollectionName");
			Util.ThrowExceptionIfNullOrBlank(json, "Json");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("dbName", dbName);
			dictionary.Add("collectionName", collectionName);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"app42\":{\"storage\":{\"jsonDoc\":").Append(Util.ConvertDictionaryToJson(json)).Append("}}}");
			dictionary.Add("body", stringBuilder.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/insert/dbName/",
				dbName,
				"/collectionName/",
				collectionName
			});
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x0002C9D0 File Offset: 0x0002ABD0
		public void FindAllDocuments(string dbName, string collectionName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(dbName, "DataBaseName");
			Util.ThrowExceptionIfNullOrBlank(collectionName, "CollectionName");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("dbName", dbName);
			dictionary.Add("collectionName", collectionName);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/findAll/dbName/",
				dbName,
				"/collectionName/",
				collectionName
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x0002CAA4 File Offset: 0x0002ACA4
		public void FindAllCollections(string dbName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(dbName, "DataBaseName");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("dbName", dbName);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/findCollections/dbName/",
				dbName
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x0002CB54 File Offset: 0x0002AD54
		public void FindDocumentById(string dbName, string collectionName, string docId, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(dbName, "DataBaseName");
			Util.ThrowExceptionIfNullOrBlank(collectionName, "CollectionName");
			Util.ThrowExceptionIfNullOrBlank(docId, "DocumentId");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("dbName", dbName);
			dictionary.Add("collectionName", collectionName);
			dictionary.Add("docId", docId);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/findDocById/dbName/",
				dbName,
				"/collectionName/",
				collectionName,
				"/docId/",
				docId
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x0002CC50 File Offset: 0x0002AE50
		public void FindDocumentByKeyValue(string dbName, string collectionName, string key, string value, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(dbName, "DataBaseName");
			Util.ThrowExceptionIfNullOrBlank(collectionName, "CollectionName");
			Util.ThrowExceptionIfNullOrBlank(key, "Key");
			Util.ThrowExceptionIfNullOrBlank(value, "Value");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("dbName", dbName);
			dictionary.Add("collectionName", collectionName);
			dictionary.Add("key", key);
			dictionary.Add("value", value);
			string value2 = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value2);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/findDocByKV/dbName/",
				dbName,
				"/collectionName/",
				collectionName,
				"/",
				key,
				"/",
				value
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x0002CD78 File Offset: 0x0002AF78
		public void UpdateDocumentByKeyValue(string dbName, string collectionName, string key, string value, string newJsonDoc, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(dbName, "DataBaseName");
			Util.ThrowExceptionIfNullOrBlank(collectionName, "CollectionName");
			Util.ThrowExceptionIfNullOrBlank(key, "Key");
			Util.ThrowExceptionIfNullOrBlank(value, "Value");
			Util.ThrowExceptionIfNullOrBlank(newJsonDoc, "NewJsonDocument");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("dbName", dbName);
			dictionary.Add("collectionName", collectionName);
			dictionary.Add("key", key);
			dictionary.Add("value", value);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"jsonDoc\":" + newJsonDoc + "}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"storage\":").Append(stringBuilder.ToString()).Append("}}");
			App42Log.Console(" Json String : " + stringBuilder2.ToString());
			dictionary.Add("body", stringBuilder2.ToString());
			string value2 = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value2);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/update/dbName/",
				dbName,
				"/collectionName/",
				collectionName,
				"/",
				key,
				"/",
				value
			});
			RESTConnectorWWW.GetInstance().ExecutePut(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x0002CF24 File Offset: 0x0002B124
		public void UpdateDocumentByDocId(string dbName, string collectionName, string docId, string newJsonDoc, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(dbName, "DataBaseName");
			Util.ThrowExceptionIfNullOrBlank(collectionName, "CollectionName");
			Util.ThrowExceptionIfNullOrBlank(docId, "DocId");
			Util.ThrowExceptionIfNullOrBlank(newJsonDoc, "NewJsonDocument");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("dbName", dbName);
			dictionary.Add("collectionName", collectionName);
			dictionary.Add("docId", docId);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"jsonDoc\":" + newJsonDoc + "}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"storage\":").Append(stringBuilder.ToString()).Append("}}");
			App42Log.Console(" Json String : " + stringBuilder2.ToString());
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/updateByDocId/dbName/",
				dbName,
				"/collectionName/",
				collectionName,
				"/docId/",
				docId
			});
			RESTConnectorWWW.GetInstance().ExecutePut(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x0002D0A4 File Offset: 0x0002B2A4
		public void DeleteDocumentById(string dbName, string collectionName, string docId, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(dbName, "DataBaseName");
			Util.ThrowExceptionIfNullOrBlank(collectionName, "CollectionName");
			Util.ThrowExceptionIfNullOrBlank(docId, "DocumentId");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("dbName", dbName);
			dictionary.Add("collectionName", collectionName);
			dictionary.Add("docId", docId);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/deleteDocById/dbName/",
				dbName,
				"/collectionName/",
				collectionName,
				"/docId/",
				docId
			});
			RESTConnectorWWW.GetInstance().ExecuteDelete(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x0002D1A0 File Offset: 0x0002B3A0
		public void DeleteDocumentsByKeyValue(string dbName, string collectionName, string key, object value, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(dbName, "DataBaseName");
			Util.ThrowExceptionIfNullOrBlank(collectionName, "CollectionName");
			Util.ThrowExceptionIfNullOrBlank(key, "Key");
			Util.ThrowExceptionIfNullOrBlank(value, "value");
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			Dictionary<string, string> dictionary2 = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
			dictionary3 = base.Merge(dictionary2, obj);
			string value2;
			if (value.GetType().FullName.Equals("System.String"))
			{
				value2 = "{\"key\":\"" + value + "\"}";
			}
			else
			{
				value2 = "{\"key\":" + value + "}";
			}
			dictionary2.Add("value", value2);
			dictionary.Add("value", value2);
			dictionary2.Add("dbName", dbName);
			dictionary2.Add("collectionName", collectionName);
			dictionary2.Add("key", key);
			string value3 = Util.Sign(this.secretKey, dictionary2);
			dictionary3.Add("signature", value3);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/deletebykey/dbName/",
				dbName,
				"/collectionName/",
				collectionName,
				"/",
				key
			});
			RESTConnectorWWW.GetInstance().ExecuteDelete(url, dictionary, dictionary2, dictionary3, callBack);
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x0002D304 File Offset: 0x0002B504
		public void DeleteAllDocuments(string dbName, string collectionName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(dbName, "DataBaseName");
			Util.ThrowExceptionIfNullOrBlank(collectionName, "CollectionName");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("dbName", dbName);
			dictionary.Add("collectionName", collectionName);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/deleteAll/dbName/",
				dbName,
				"/collectionName/",
				collectionName
			});
			RESTConnectorWWW.GetInstance().ExecuteDelete(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x0002D3D8 File Offset: 0x0002B5D8
		public void FindDocumentByKeyValue(string dbName, string collectionName, string key, object value, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(dbName, "DataBaseName");
			Util.ThrowExceptionIfNullOrBlank(collectionName, "CollectionName");
			Util.ThrowExceptionIfNullOrBlank(key, "Key");
			Util.ThrowExceptionIfNullOrBlank(value, "Value");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("dbName", dbName);
			dictionary.Add("collectionName", collectionName);
			dictionary.Add("key", key);
			dictionary.Add("value", string.Concat(value));
			string value2 = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value2);
			string url = string.Concat(new object[]
			{
				this.version,
				"/",
				this.resource,
				"/findDocByKV/dbName/",
				dbName,
				"/collectionName/",
				collectionName,
				"/",
				key,
				"/",
				value
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x0002D504 File Offset: 0x0002B704
		public void FindDocumentsByQuery(string dbName, string collectionName, Query query, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(dbName, "DataBaseName");
			Util.ThrowExceptionIfNullOrBlank(collectionName, "CollectionName");
			Util.ThrowExceptionIfNullOrBlank(query, "query");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("jsonQuery", query.GetStr());
			dictionary.Add("dbName", dbName);
			dictionary.Add("collectionName", collectionName);
			dictionary2.Add("jsonQuery", query.GetStr());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/findDocsByQuery/dbName/",
				dbName,
				"/collectionName/",
				collectionName
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x0002D608 File Offset: 0x0002B808
		public void FindDocumentsByQueryWithPaging(string dbName, string collectionName, Query query, int max, int offset, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(dbName, "DataBaseName");
			Util.ThrowExceptionIfNullOrBlank(collectionName, "CollectionName");
			Util.ThrowExceptionIfNullOrBlank(query, "query");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("jsonQuery", query.GetStr());
			dictionary.Add("dbName", dbName);
			dictionary.Add("collectionName", collectionName);
			dictionary.Add("max", string.Concat(max));
			dictionary.Add("offset", string.Concat(offset));
			dictionary2.Add("jsonQuery", query.GetStr());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new object[]
			{
				this.version,
				"/",
				this.resource,
				"/findDocsByQuery/dbName/",
				dbName,
				"/collectionName/",
				collectionName,
				"/",
				max,
				"/",
				offset
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x0002D764 File Offset: 0x0002B964
		public void FindDocsWithQueryPagingOrderBy(string dbName, string collectionName, Query query, int max, int offset, string orderByKey, string type, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(dbName, "DataBaseName");
			Util.ThrowExceptionIfNullOrBlank(collectionName, "CollectionName");
			Util.ThrowExceptionIfNullOrBlank(query, "query");
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			Dictionary<string, string> dictionary2 = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
			dictionary3 = base.Merge(dictionary2, obj);
			dictionary2.Add("jsonQuery", query.GetStr());
			if (orderByKey != null)
			{
				dictionary.Add("orderByKey", orderByKey);
			}
			if (type != null)
			{
				dictionary.Add("orderByType", type);
			}
			dictionary3.Add("jsonQuery", query.GetStr());
			dictionary2.Add("dbName", dbName);
			dictionary2.Add("collectionName", collectionName);
			dictionary2.Add("max", string.Concat(max));
			dictionary2.Add("offset", string.Concat(offset));
			string value = Util.Sign(this.secretKey, dictionary2);
			dictionary3.Add("signature", value);
			string url = string.Concat(new object[]
			{
				this.version,
				"/",
				this.resource,
				"/findDocsByQuery/dbName/",
				dbName,
				"/collectionName/",
				collectionName,
				"/",
				max,
				"/",
				offset
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, dictionary, dictionary2, dictionary3, callBack);
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x0002D8E4 File Offset: 0x0002BAE4
		public void GrantAccessOnDoc(string dbName, string collectionName, string docId, HashSet<ACL> aclList, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(dbName, "DataBaseName");
			Util.ThrowExceptionIfNullOrBlank(collectionName, "CollectionName");
			Util.ThrowExceptionIfNullOrBlank(aclList, "aclList");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("dbName", dbName);
			dictionary.Add("collectionName", collectionName);
			dictionary.Add("docId", docId);
			JSONArray jsonarray = new JSONArray();
			foreach (ACL acl in aclList)
			{
				jsonarray.Add(acl.GetJSONObject());
			}
			JSONObject jsonobject = new JSONObject();
			jsonobject.Add("acls", "{\"acl\":" + jsonarray.ToString() + "}");
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"app42\":{\"storage\":").Append(jsonobject.ToString()).Append("}}");
			dictionary.Add("body", stringBuilder.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/grantAccessOnDoc/",
				UrlEncoder.UrlEncode(dbName),
				"/",
				UrlEncoder.UrlEncode(collectionName),
				"/",
				UrlEncoder.UrlEncode(docId)
			});
			RESTConnectorWWW.GetInstance().ExecutePut(url, paramsDics, stringBuilder.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x0002DAB4 File Offset: 0x0002BCB4
		public void RevokeAccessOnDoc(string dbName, string collectionName, string docId, HashSet<ACL> aclList, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(dbName, "DataBaseName");
			Util.ThrowExceptionIfNullOrBlank(collectionName, "CollectionName");
			Util.ThrowExceptionIfNullOrBlank(aclList, "acl");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("dbName", dbName);
			dictionary.Add("collectionName", collectionName);
			dictionary.Add("docId", docId);
			JSONArray jsonarray = new JSONArray();
			foreach (ACL acl in aclList)
			{
				jsonarray.Add(acl.GetJSONObject());
			}
			JSONObject jsonobject = new JSONObject();
			jsonobject.Add("acls", "{\"acl\":" + jsonarray.ToString() + "}");
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"app42\":{\"storage\":").Append(jsonobject.ToString()).Append("}}");
			dictionary.Add("body", stringBuilder.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/revokeAccessOnDoc/",
				UrlEncoder.UrlEncode(dbName),
				"/",
				UrlEncoder.UrlEncode(collectionName),
				"/",
				UrlEncoder.UrlEncode(docId)
			});
			RESTConnectorWWW.GetInstance().ExecutePut(url, paramsDics, stringBuilder.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x0002DC84 File Offset: 0x0002BE84
		public void FindDocumentsByLocation(string dbName, string collectionName, GeoQuery query, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(dbName, "DataBaseName");
			Util.ThrowExceptionIfNullOrBlank(collectionName, "CollectionName");
			Util.ThrowExceptionIfNullOrBlank(query, "query");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("jsonQuery", query.GetStr());
			dictionary.Add("dbName", dbName);
			dictionary.Add("collectionName", collectionName);
			dictionary2.Add("jsonQuery", query.GetStr());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/findDocsBylocation/dbName/",
				dbName,
				"/collectionName/",
				collectionName
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x0002DD88 File Offset: 0x0002BF88
		public void FindAllDocumentsCount(string dbName, string collectionName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(dbName, "DataBaseName");
			Util.ThrowExceptionIfNullOrBlank(collectionName, "CollectionName");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("dbName", dbName);
			dictionary.Add("collectionName", collectionName);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/findAll/count/dbName/",
				dbName,
				"/collectionName/",
				collectionName
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x0002DE8C File Offset: 0x0002C08C
		public void InsertJsonDocUsingMap(string dbName, string collectionName, Dictionary<string, string> map, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(callBack, "callBack");
			Thread thread = new Thread(delegate()
			{
				this.InsertJsonDocUsingMap(dbName, collectionName, map, callBack);
			});
			thread.Start();
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x0002DEEC File Offset: 0x0002C0EC
		public void MapReduce(string dbName, string collectionName, string mapFunction, string reduceFunction, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(dbName, "DataBaseName");
			Util.ThrowExceptionIfNullOrBlank(collectionName, "CollectionName");
			Util.ThrowExceptionIfNullOrBlank(mapFunction, "MapFunction");
			Util.ThrowExceptionIfNullOrBlank(reduceFunction, "ReduceFunction");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("dbName", dbName);
			dictionary.Add("collectionName", collectionName);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"map\":\"" + mapFunction + "\",");
			stringBuilder.Append("\"reduce\":\"" + reduceFunction + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"storage\":").Append(stringBuilder.ToString()).Append("}}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/mapReduce/dbName/",
				dbName,
				"/collectionName/",
				collectionName
			});
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x0002E054 File Offset: 0x0002C254
		private string GetJsonFromMap(Dictionary<string, string> map)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{");
			if (map != null && map.Count != 0)
			{
				ICollection<string> keys = map.Keys;
				int num = 0;
				int count = keys.Count;
				foreach (string text in keys)
				{
					num++;
					string text2 = map[text];
					App42Log.Console("VALUE" + text2);
					stringBuilder.Append(string.Concat(new string[]
					{
						"\"",
						text,
						"\":\"",
						text2,
						"\""
					}));
					if (count > 1 && num != count)
					{
						stringBuilder.Append(",");
					}
				}
			}
			stringBuilder.Append("}");
			return stringBuilder.ToString();
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x0002E1A8 File Offset: 0x0002C3A8
		private void GetJsonFromMap(Dictionary<string, string> map, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(callBack, "callBack");
			Thread thread = new Thread(delegate()
			{
				try
				{
					string jsonFromMap = this.GetJsonFromMap(map);
					callBack.OnSuccess(jsonFromMap);
				}
				catch (App42Exception ex)
				{
					callBack.OnException(ex);
				}
			});
			thread.Start();
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x0002E1F8 File Offset: 0x0002C3F8
		public void FindAllDocuments(string dbName, string collectionName, int max, int offset, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(callBack, "callBack");
			Util.ThrowExceptionIfNullOrBlank(dbName, "DataBaseName");
			Util.ThrowExceptionIfNullOrBlank(collectionName, "CollectionName");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("dbName", dbName);
			dictionary.Add("collectionName", collectionName);
			dictionary.Add("max", string.Concat(max));
			dictionary.Add("offset", string.Concat(offset));
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new object[]
			{
				this.version,
				"/",
				this.resource,
				"/findAll/dbName/",
				dbName,
				"/collectionName/",
				collectionName,
				"/",
				max,
				"/",
				offset
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x0002E330 File Offset: 0x0002C530
		public void UpdateDocumentByKeyValue(string dbName, string collectionName, string key, string value, Dictionary<string, object> newJsonDoc, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(dbName, "DataBaseName");
			Util.ThrowExceptionIfNullOrBlank(collectionName, "CollectionName");
			Util.ThrowExceptionIfNullOrBlank(key, "Key");
			Util.ThrowExceptionIfNullOrBlank(value, "Value");
			Util.ThrowExceptionIfNullOrBlank(newJsonDoc, "NewJsonDocument");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("dbName", dbName);
			dictionary.Add("collectionName", collectionName);
			dictionary.Add("key", key);
			dictionary.Add("value", value);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"app42\":{\"storage\":{\"jsonDoc\":").Append(Util.ConvertDictionaryToJson(newJsonDoc)).Append("}}}");
			App42Log.Console(" Json String : " + stringBuilder.ToString());
			dictionary.Add("body", stringBuilder.ToString());
			string value2 = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value2);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/update/dbName/",
				dbName,
				"/collectionName/",
				collectionName,
				"/",
				key,
				"/",
				value
			});
			RESTConnectorWWW.GetInstance().ExecutePut(url, paramsDics, stringBuilder.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x0002E4BC File Offset: 0x0002C6BC
		public void UpdateDocumentByDocId(string dbName, string collectionName, string docId, Dictionary<string, object> newJsonDoc, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(dbName, "DataBaseName");
			Util.ThrowExceptionIfNullOrBlank(collectionName, "CollectionName");
			Util.ThrowExceptionIfNullOrBlank(docId, "DocId");
			Util.ThrowExceptionIfNullOrBlank(newJsonDoc, "NewJsonDocument");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("dbName", dbName);
			dictionary.Add("collectionName", collectionName);
			dictionary.Add("docId", docId);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"app42\":{\"storage\":{\"jsonDoc\":").Append(Util.ConvertDictionaryToJson(newJsonDoc)).Append("}}}");
			dictionary.Add("body", stringBuilder.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/updateByDocId/dbName/",
				dbName,
				"/collectionName/",
				collectionName,
				"/docId/",
				docId
			});
			RESTConnectorWWW.GetInstance().ExecutePut(url, paramsDics, stringBuilder.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x0002E608 File Offset: 0x0002C808
		public void SaveOrUpdateDocumentByKeyValue(string dbName, string collectionName, string key, string value, string newJsonDoc, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(dbName, "DataBaseName");
			Util.ThrowExceptionIfNullOrBlank(collectionName, "CollectionName");
			Util.ThrowExceptionIfNullOrBlank(key, "Key");
			Util.ThrowExceptionIfNullOrBlank(value, "Value");
			Util.ThrowExceptionIfNullOrBlank(newJsonDoc, "NewJsonDocument");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("dbName", dbName);
			dictionary.Add("collectionName", collectionName);
			dictionary.Add("key", key);
			dictionary.Add("value", value);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"jsonDoc\":" + newJsonDoc);
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"storage\":").Append(stringBuilder.ToString()).Append("}}}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value2 = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value2);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/saveorupdate/dbName/",
				dbName,
				"/collectionName/",
				collectionName,
				"/",
				key,
				"/",
				value
			});
			RESTConnectorWWW.GetInstance().ExecutePut(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x0002E798 File Offset: 0x0002C998
		public void SaveOrUpdateDocumentByKeyValue(string dbName, string collectionName, string key, string value, Dictionary<string, object> newJsonDoc, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(dbName, "DataBaseName");
			Util.ThrowExceptionIfNullOrBlank(collectionName, "CollectionName");
			Util.ThrowExceptionIfNullOrBlank(key, "Key");
			Util.ThrowExceptionIfNullOrBlank(value, "Value");
			Util.ThrowExceptionIfNullOrBlank(newJsonDoc, "NewJsonDocument");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("dbName", dbName);
			dictionary.Add("collectionName", collectionName);
			dictionary.Add("key", key);
			dictionary.Add("value", value);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"app42\":{\"storage\":{\"jsonDoc\":").Append(Util.ConvertDictionaryToJson(newJsonDoc)).Append("}}}");
			dictionary.Add("body", stringBuilder.ToString());
			string value2 = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value2);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/saveorupdate/dbName/",
				dbName,
				"/collectionName/",
				collectionName,
				"/",
				key,
				"/",
				value
			});
			RESTConnectorWWW.GetInstance().ExecutePut(url, paramsDics, stringBuilder.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x0002E90C File Offset: 0x0002CB0C
		public void UpdateDocumentByQuery(string dbName, string collectionName, Query query, string newJsonDoc, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(dbName, "DataBaseName");
			Util.ThrowExceptionIfNullOrBlank(collectionName, "CollectionName");
			Util.ThrowExceptionIfNullOrBlank(newJsonDoc, "NewJsonDocument");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("dbName", dbName);
			dictionary.Add("collectionName", collectionName);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"jsonQuery\":" + query.GetStr() + ",");
			stringBuilder.Append("\"jsonDoc\":\"" + newJsonDoc + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"storage\":").Append(stringBuilder.ToString()).Append("}}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/updateDocsByQuery/dbName/",
				dbName,
				"/collectionName/",
				collectionName
			});
			RESTConnectorWWW.GetInstance().ExecutePut(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x0002EA6C File Offset: 0x0002CC6C
		public void UpdateDocumentByQuery(string dbName, string collectionName, Query query, Dictionary<string, object> newJsonDoc, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(dbName, "DataBaseName");
			Util.ThrowExceptionIfNullOrBlank(collectionName, "CollectionName");
			Util.ThrowExceptionIfNullOrBlank(newJsonDoc, "NewJsonDocument");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("dbName", dbName);
			dictionary.Add("collectionName", collectionName);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"app42\":{\"storage\":{\"jsonQuery\":").Append(query.GetStr()).Append(",\"jsonDoc\":").Append(Util.ConvertDictionaryToJson(newJsonDoc)).Append("}}}");
			dictionary.Add("body", stringBuilder.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/updateDocsByQuery/dbName/",
				dbName,
				"/collectionName/",
				collectionName
			});
			RESTConnectorWWW.GetInstance().ExecutePut(url, paramsDics, stringBuilder.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x0002EBA4 File Offset: 0x0002CDA4
		public void AddOrUpdateKeys(string dbName, string collectionName, string docId, string keys, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(dbName, "DataBaseName");
			Util.ThrowExceptionIfNullOrBlank(collectionName, "CollectionName");
			Util.ThrowExceptionIfNullOrBlank(docId, "DocId");
			Util.ThrowExceptionIfNullOrBlank(keys, "keys");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("dbName", dbName);
			dictionary.Add("collectionName", collectionName);
			dictionary.Add("docId", docId);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"jsonDoc\":" + keys);
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"storage\":").Append(stringBuilder.ToString()).Append("}}}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/updateKeysByDocId/dbName/",
				dbName,
				"/collectionName/",
				collectionName,
				"/docId/",
				docId
			});
			RESTConnectorWWW.GetInstance().ExecutePut(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x0002ED08 File Offset: 0x0002CF08
		public void AddOrUpdateKeys(string dbName, string collectionName, string docId, Dictionary<string, object> keys, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(dbName, "DataBaseName");
			Util.ThrowExceptionIfNullOrBlank(collectionName, "CollectionName");
			Util.ThrowExceptionIfNullOrBlank(docId, "DocId");
			Util.ThrowExceptionIfNullOrBlank(keys, "keys");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("dbName", dbName);
			dictionary.Add("collectionName", collectionName);
			dictionary.Add("docId", docId);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"app42\":{\"storage\":{\"jsonDoc\":").Append(Util.ConvertDictionaryToJson(keys)).Append("}}}");
			App42Log.Console(" Json String : " + stringBuilder.ToString());
			dictionary.Add("body", stringBuilder.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/updateKeysByDocId/dbName/",
				dbName,
				"/collectionName/",
				collectionName,
				"/docId/",
				docId
			});
			RESTConnectorWWW.GetInstance().ExecutePut(url, paramsDics, stringBuilder.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x0002EE68 File Offset: 0x0002D068
		public void AddAttachmentToDocs(string dbName, string collectionName, string docId, App42File file, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(dbName, "DataBaseName");
			Util.ThrowExceptionIfNullOrBlank(collectionName, "CollectionName");
			Util.ThrowExceptionIfNullOrBlank(docId, "docId");
			Dictionary<string, string> queryParams = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("dbName", dbName);
			dictionary.Add("collectionName", collectionName);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
			if (file.GetFileType() == null)
			{
				dictionary3.Add("type", "OTHER");
			}
			else
			{
				dictionary3.Add("type", file.GetFileType() ?? "");
			}
			if (file.GetName() == null)
			{
				dictionary3.Add("name", "Default");
			}
			else
			{
				dictionary3.Add("name", file.GetName());
			}
			dictionary3.Add("docId", docId);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/updatewithattachment/dbName/",
				dbName,
				"/collectionName/",
				collectionName
			});
			RESTConnectorWWW.GetInstance().ExecuteMultipart("attachment", file.GetFileInputStream(), queryParams, dictionary3, dictionary, dictionary2, url, Config.GetInstance().GetAccept(), callBack);
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x0002EFDC File Offset: 0x0002D1DC
		public void InsertJSONDocument(string dbName, string collectionName, string json, App42File file, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(dbName, "DataBaseName");
			Util.ThrowExceptionIfNullOrBlank(collectionName, "CollectionName");
			Util.ThrowExceptionIfNullOrBlank(json, "Json");
			Dictionary<string, string> queryParams = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("dbName", dbName);
			dictionary.Add("collectionName", collectionName);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
			if (file.GetFileType() == null)
			{
				dictionary3.Add("type", "OTHER");
			}
			else
			{
				dictionary3.Add("type", file.GetFileType() ?? "");
			}
			if (file.GetName() == null)
			{
				dictionary3.Add("name", "Default");
			}
			else
			{
				dictionary3.Add("name", file.GetName());
			}
			dictionary3.Add("jsonDoc", json);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/insertwithattachment/dbName/",
				dbName,
				"/collectionName/",
				collectionName
			});
			RESTConnectorWWW.GetInstance().ExecuteMultipart("attachment", file.GetFileInputStream(), queryParams, dictionary3, dictionary, dictionary2, url, Config.GetInstance().GetAccept(), callBack);
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x0002F150 File Offset: 0x0002D350
		public void InsertJSONDocument(string dbName, string collectionName, Dictionary<string, object> json, App42File file, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(dbName, "DataBaseName");
			Util.ThrowExceptionIfNullOrBlank(collectionName, "CollectionName");
			Util.ThrowExceptionIfNullOrBlank(json, "Json");
			if (file.GetName().IndexOf('.') == -1)
			{
				Util.ThrowExceptionIfNotValidExtension(file.GetName(), "File Name");
				return;
			}
			Dictionary<string, string> queryParams = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("dbName", dbName);
			dictionary.Add("collectionName", collectionName);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
			if (file.GetFileType() == null)
			{
				dictionary3.Add("type", "OTHER");
			}
			else
			{
				dictionary3.Add("type", file.GetFileType() ?? "");
			}
			if (file.GetName() == null)
			{
				dictionary3.Add("name", "Default");
			}
			else
			{
				dictionary3.Add("name", file.GetName());
			}
			StringBuilder stringBuilder = new StringBuilder();
			StringBuilder stringBuilder2 = new StringBuilder("{\"jsonDoc\":");
			foreach (KeyValuePair<string, object> keyValuePair in json)
			{
				Util.ThrowExceptionIfNull(keyValuePair.Value, "Value");
				stringBuilder.Append(string.Concat(new object[]
				{
					'"',
					keyValuePair.Key,
					'"',
					":"
				}));
				if (keyValuePair.Value is string)
				{
					stringBuilder.Append(string.Concat(new object[]
					{
						'"',
						keyValuePair.Value.ToString(),
						'"',
						","
					}));
				}
				else
				{
					stringBuilder.Append(keyValuePair.Value + ",");
				}
			}
			int startIndex = stringBuilder.ToString().LastIndexOf(",");
			stringBuilder.Remove(startIndex, 1);
			stringBuilder2.Append("{" + stringBuilder.ToString() + "}}");
			dictionary3.Add("jsonDoc", stringBuilder2.ToString());
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/insertwithattachment/dbName/",
				dbName,
				"/collectionName/",
				collectionName
			});
			RESTConnectorWWW.GetInstance().ExecuteMultipart("attachment", file.GetFileInputStream(), queryParams, dictionary3, dictionary, dictionary2, url, Config.GetInstance().GetAccept(), callBack);
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x0002F440 File Offset: 0x0002D640
		public void GetCountByQuery(string dbName, string collectionName, Query query, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(dbName, "DataBaseName");
			Util.ThrowExceptionIfNullOrBlank(collectionName, "CollectionName");
			Util.ThrowExceptionIfNullOrBlank(query, "query");
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			Dictionary<string, string> dictionary2 = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
			dictionary3 = base.Merge(dictionary2, obj);
			dictionary2.Add("dbName", dbName);
			dictionary2.Add("collectionName", collectionName);
			dictionary2.Add("jsonQuery", query.GetStr());
			dictionary.Add("jsonQuery", query.GetStr());
			string value = Util.Sign(this.secretKey, dictionary2);
			dictionary3.Add("signature", value);
			dictionary3.Add("isArray", "CountRequest");
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/findDocsByQuery/dbName/",
				dbName,
				"/collectionName/",
				collectionName
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, dictionary, dictionary2, dictionary3, callBack);
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x0002F554 File Offset: 0x0002D754
		public void IncrementKeyByDocId(string dbName, string collectionName, string docId, string key, double value, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(dbName, "DataBaseName");
			Util.ThrowExceptionIfNullOrBlank(collectionName, "CollectionName");
			Util.ThrowExceptionIfNullOrBlank(docId, "DocId");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("dbName", dbName);
			dictionary.Add("collectionName", collectionName);
			dictionary.Add("docId", docId);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(string.Concat(new object[]
			{
				"{\"key\":\"",
				key,
				"\", \"value\":",
				value,
				"}"
			}));
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"storage\":").Append(stringBuilder.ToString()).Append("}}");
			App42Log.Console(" Json String : " + stringBuilder2.ToString());
			dictionary.Add("body", stringBuilder2.ToString());
			string value2 = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value2);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/increment/dbName/",
				dbName,
				"/collectionName/",
				collectionName,
				"/docId/",
				docId
			});
			RESTConnectorWWW.GetInstance().ExecutePut(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}
	}
}
