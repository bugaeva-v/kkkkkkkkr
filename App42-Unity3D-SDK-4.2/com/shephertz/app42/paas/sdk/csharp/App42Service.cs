using System;
using System.Collections.Generic;
using com.shephertz.app42.paas.sdk.csharp.storage;
using com.shephertz.app42.paas.sdk.csharp.util;
using SimpleJSON;

namespace com.shephertz.app42.paas.sdk.csharp
{
	// Token: 0x02000007 RID: 7
	public class App42Service
	{
		// Token: 0x0600001F RID: 31 RVA: 0x000024EF File Offset: 0x000006EF
		public void SetQuery(string collectionName, Query metaInfoQuery)
		{
			if (metaInfoQuery == null)
			{
				this.dbName = App42API.GetDbName();
				this.collectionName = collectionName;
				return;
			}
			this.dbName = App42API.GetDbName();
			this.collectionName = collectionName;
			this.query = metaInfoQuery.GetStr();
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002525 File Offset: 0x00000725
		public string GetEvent()
		{
			return this.Event;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x0000252D File Offset: 0x0000072D
		public void SetEvent(string Event)
		{
			this.Event = Event;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002536 File Offset: 0x00000736
		public string GetOrderByDescending()
		{
			return this.orderByDescending;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x0000253E File Offset: 0x0000073E
		public void SetOrderByDescending(string orderByDescending)
		{
			this.orderByDescending = orderByDescending;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002547 File Offset: 0x00000747
		public Dictionary<string, string> GetOtherMetaHeaders()
		{
			return this.otherMetaHeaders;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000254F File Offset: 0x0000074F
		public void SetOtherMetaHeaders(Dictionary<string, string> otherMetaHeaders)
		{
			this.otherMetaHeaders = otherMetaHeaders;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002558 File Offset: 0x00000758
		public string GetOrderByAscending()
		{
			return this.orderByAscending;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002560 File Offset: 0x00000760
		public void setOrderByAscending(string orderByAscending)
		{
			this.orderByAscending = orderByAscending;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002569 File Offset: 0x00000769
		public HashSet<ACL> GetAclList()
		{
			return this.aclList;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002571 File Offset: 0x00000771
		public void SetAclList(HashSet<ACL> aclList)
		{
			this.aclList = aclList;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0000257A File Offset: 0x0000077A
		public HashSet<string> GetSelectKeys()
		{
			return this.selectKeys;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002582 File Offset: 0x00000782
		public void SetSelectKeys(HashSet<string> selectKeys)
		{
			this.selectKeys = selectKeys;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0000258C File Offset: 0x0000078C
		public Dictionary<string, string> PopulateSignParams()
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			dictionary.Add("apiKey", this.apiKey);
			dictionary.Add("version", this.version);
			if (this.fbAccessToken != null)
			{
				dictionary.Add("fbAccessToken", this.fbAccessToken);
			}
			else if (this.sessionId != null)
			{
				dictionary.Add("sessionId", this.sessionId);
			}
			else if (this.fbAccessToken == null && App42API.GetFBAccsssToken() != null && !App42API.GetFBAccsssToken().Equals(""))
			{
				dictionary.Add("fbAccessToken", App42API.GetFBAccsssToken());
			}
			else if (this.sessionId == null && App42API.GetUserSessionId() != null && !App42API.GetUserSessionId().Equals(""))
			{
				dictionary.Add("sessionId", App42API.GetUserSessionId());
			}
			if (this.adminKey != null)
			{
				dictionary.Add("adminKey", this.adminKey);
			}
			dictionary.Add("timeStamp", Util.GetUTCFormattedTimestamp());
			return dictionary;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002683 File Offset: 0x00000883
		public string GetSessionId()
		{
			return this.sessionId;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0000268B File Offset: 0x0000088B
		public void SetSessionId(string sessionId)
		{
			Util.ThrowExceptionIfNullOrBlank(sessionId, "sessionId");
			this.sessionId = sessionId;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x0000269F File Offset: 0x0000089F
		public GeoTag GetGeoTag()
		{
			return this.geoTag;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000026A7 File Offset: 0x000008A7
		public void SetGeoTag(GeoTag geoTag)
		{
			Util.ThrowExceptionIfNullOrBlank(geoTag, "geoTag");
			this.geoTag = geoTag;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000026BB File Offset: 0x000008BB
		public string GetAdminKey()
		{
			return this.adminKey;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000026C3 File Offset: 0x000008C3
		public void SetAdminKey(string adminKey)
		{
			Util.ThrowExceptionIfNullOrBlank(adminKey, "adminKey");
			this.adminKey = adminKey;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000026D7 File Offset: 0x000008D7
		public int GetPageOffset()
		{
			return this.pageOffset;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000026DF File Offset: 0x000008DF
		public void SetPageOffset(int pageOffset)
		{
			this.pageOffset = pageOffset;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000026E8 File Offset: 0x000008E8
		public int GetPageMaxRecords()
		{
			return this.pageMaxRecords;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000026F0 File Offset: 0x000008F0
		public void SetPageMaxRecords(int pageMaxRecords)
		{
			this.pageMaxRecords = pageMaxRecords;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000026F9 File Offset: 0x000008F9
		public string GetFbAccessToken()
		{
			return this.fbAccessToken;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002701 File Offset: 0x00000901
		public void SetFbAccessToken(string fbAccessToken)
		{
			this.fbAccessToken = fbAccessToken;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x0000270C File Offset: 0x0000090C
		public Dictionary<string, string> PopulateMetaHeaderParams()
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			if ((long)this.pageOffset != -1L)
			{
				dictionary.Add("offset", string.Concat(this.pageOffset));
			}
			if (this.pageMaxRecords != -1)
			{
				dictionary.Add("max", string.Concat(this.pageMaxRecords));
			}
			this.SetACLHeader(dictionary);
			if (this.geoTag != null)
			{
				dictionary.Add("geoTag", this.geoTag.GetJSONObject().ToString());
			}
			if (this.selectKeys.Count > 0)
			{
				JSONObject jsonobject = new JSONObject();
				foreach (string aKey in this.selectKeys)
				{
					jsonobject.Add(aKey, (float)long.Parse("1"));
				}
				dictionary.Add("selectKeys", jsonobject.ToString());
			}
			dictionary.Add("SDKName", "Unity");
			if (App42API.GetInstallationId() != null && !App42API.GetInstallationId().Equals(""))
			{
				dictionary.Add("deviceId", App42API.GetInstallationId());
			}
			if (this.Event != null && !this.Event.Equals(""))
			{
				dictionary.Add("event", this.Event);
			}
			if (this.query != null && !this.query.Equals(""))
			{
				dictionary.Add("metaQuery", this.query);
			}
			if (this.jsonObject != null && !this.jsonObject.Equals(""))
			{
				dictionary.Add("jsonObject", this.jsonObject);
			}
			if (this.dbName != null && !this.dbName.Equals("") && this.collectionName != null && !this.collectionName.Equals(""))
			{
				JSONObject jsonobject2 = new JSONObject();
				jsonobject2.Add("dbName", this.dbName);
				jsonobject2.Add("collectionName", this.collectionName);
				dictionary.Add("dbCredentials", jsonobject2.ToString());
			}
			if (App42API.GetLoggedInUser() != null && !App42API.GetLoggedInUser().Equals(""))
			{
				dictionary.Add("loggedInUser", App42API.GetLoggedInUser());
			}
			if (this.otherMetaHeaders.Count > 0)
			{
				ICollection<string> keys = this.otherMetaHeaders.Keys;
				foreach (string text in keys)
				{
					string text2 = this.otherMetaHeaders[text];
					if (text != null && !text.Equals("") && text2 != null && !text2.Equals(""))
					{
						dictionary.Add(text, text2);
					}
				}
			}
			dictionary.Add("resource", this.resource);
			return dictionary;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002A08 File Offset: 0x00000C08
		private void SetACLHeader(Dictionary<string, string> paramsDics)
		{
			if (this.aclList.Count > 0)
			{
				JSONArray jsonObj = this.GetJsonObj(this.aclList);
				paramsDics.Add("dataACL", jsonObj.ToString());
				return;
			}
			if (App42API.defaultACL.Count > 0)
			{
				JSONArray jsonObj2 = this.GetJsonObj(App42API.defaultACL);
				paramsDics.Add("dataACL", jsonObj2.ToString());
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002A6C File Offset: 0x00000C6C
		private JSONArray GetJsonObj(HashSet<ACL> aclList)
		{
			JSONArray jsonarray = new JSONArray();
			foreach (ACL acl in aclList)
			{
				JSONObject jsonobject = new JSONObject();
				jsonobject.Add(acl.user, acl.permission);
				jsonarray.Add(jsonobject);
			}
			return jsonarray;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002AE0 File Offset: 0x00000CE0
		public Dictionary<string, string> Merge(Dictionary<string, string> obj1, Dictionary<string, string> obj2)
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			foreach (KeyValuePair<string, string> keyValuePair in obj1)
			{
				dictionary.Add(keyValuePair.Key, keyValuePair.Value);
			}
			foreach (KeyValuePair<string, string> keyValuePair2 in obj2)
			{
				dictionary.Add(keyValuePair2.Key, keyValuePair2.Value);
			}
			return dictionary;
		}

		// Token: 0x0400000A RID: 10
		public string apiKey;

		// Token: 0x0400000B RID: 11
		public string version;

		// Token: 0x0400000C RID: 12
		public string resource;

		// Token: 0x0400000D RID: 13
		public string sessionId;

		// Token: 0x0400000E RID: 14
		public string adminKey;

		// Token: 0x0400000F RID: 15
		public GeoTag geoTag;

		// Token: 0x04000010 RID: 16
		public string secretKey;

		// Token: 0x04000011 RID: 17
		public int pageOffset = -1;

		// Token: 0x04000012 RID: 18
		public int pageMaxRecords = -1;

		// Token: 0x04000013 RID: 19
		public string fbAccessToken;

		// Token: 0x04000014 RID: 20
		public string orderByDescending;

		// Token: 0x04000015 RID: 21
		public HashSet<ACL> dataACL;

		// Token: 0x04000016 RID: 22
		public string orderByAscending;

		// Token: 0x04000017 RID: 23
		public Dictionary<string, string> otherMetaHeaders = new Dictionary<string, string>();

		// Token: 0x04000018 RID: 24
		public string Event;

		// Token: 0x04000019 RID: 25
		protected string dbName;

		// Token: 0x0400001A RID: 26
		protected string collectionName;

		// Token: 0x0400001B RID: 27
		protected string query;

		// Token: 0x0400001C RID: 28
		protected string jsonObject;

		// Token: 0x0400001D RID: 29
		private HashSet<string> selectKeys = new HashSet<string>();

		// Token: 0x0400001E RID: 30
		private HashSet<ACL> aclList = new HashSet<ACL>();
	}
}
