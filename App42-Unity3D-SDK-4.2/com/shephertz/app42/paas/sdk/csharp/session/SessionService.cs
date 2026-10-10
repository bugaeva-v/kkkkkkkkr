using System;
using System.Collections.Generic;
using System.Text;
using com.shephertz.app42.paas.sdk.csharp.connection;
using com.shephertz.app42.paas.sdk.csharp.util;

namespace com.shephertz.app42.paas.sdk.csharp.session
{
	// Token: 0x0200009E RID: 158
	public class SessionService : App42Service
	{
		// Token: 0x06000686 RID: 1670 RVA: 0x00027AC6 File Offset: 0x00025CC6
		public SessionService(string apiKey, string secretKey)
		{
			this.apiKey = apiKey;
			this.secretKey = secretKey;
			this.version = "1.0";
			this.resource = "session";
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x00027AF4 File Offset: 0x00025CF4
		public void GetSession(string uName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(uName, "User Name");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"userName\":\"" + uName + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"session\":").Append(stringBuilder.ToString()).Append("}}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource;
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x00027BD4 File Offset: 0x00025DD4
		public void GetSession(string uName, bool isCreate, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(uName, "User Name");
			Util.ThrowExceptionIfNullOrBlank(isCreate, "IsCreate");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"userName\":\"" + uName + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"session\":").Append(stringBuilder.ToString()).Append("}}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new object[]
			{
				this.version,
				"/",
				this.resource,
				"/",
				isCreate
			});
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x00027CF0 File Offset: 0x00025EF0
		public void Invalidate(string sessionId, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(sessionId, "Session Id");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"id\":\"" + sessionId + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"session\":").Append(stringBuilder.ToString()).Append("}}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource;
			App42API.RemoveLocalSession();
			RESTConnectorWWW.GetInstance().ExecutePut(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x00027DD8 File Offset: 0x00025FD8
		public void SetAttribute(string sessionId, string attributeName, string attributeValue, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(sessionId, "Session ID");
			Util.ThrowExceptionIfNullOrBlank(attributeName, "Attribute Name");
			Util.ThrowExceptionIfNullOrBlank(attributeValue, "Attribute Value");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			App42Log.Console("Setting Attribute :: ");
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"name\":\"" + attributeName + "\",");
			stringBuilder.Append("\"value\":\"" + attributeValue + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"session\":").Append(stringBuilder.ToString()).Append("}}");
			dictionary.Add("body", stringBuilder2.ToString());
			if (dictionary.ContainsKey("sessionId"))
			{
				dictionary.Remove("sessionId");
			}
			dictionary.Add("sessionId", sessionId);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/id/",
				sessionId
			});
			App42Log.Console("Calling  RESTConnectorWWW :: ");
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x00027F44 File Offset: 0x00026144
		public void GetAttribute(string sessionId, string attributeName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(sessionId, "Session ID");
			Util.ThrowExceptionIfNullOrBlank(attributeName, "Attribute Name");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			if (dictionary.ContainsKey("sessionId"))
			{
				dictionary.Remove("sessionId");
			}
			dictionary.Add("sessionId", sessionId);
			dictionary.Add("name", attributeName);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/id/",
				sessionId,
				"/",
				attributeName
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x00028034 File Offset: 0x00026234
		public void GetAllAttributes(string sessionId, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(sessionId, "Session Id");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			if (dictionary.ContainsKey("sessionId"))
			{
				dictionary.Remove("sessionId");
			}
			dictionary.Add("sessionId", sessionId);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/id/",
				sessionId
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x000280FC File Offset: 0x000262FC
		public void RemoveAttribute(string session_Id, string attributeName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(session_Id, "Session Id");
			Util.ThrowExceptionIfNullOrBlank(attributeName, "Attribute Name");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			if (dictionary.ContainsKey("sessionId"))
			{
				dictionary.Remove("sessionId");
			}
			dictionary.Add("sessionId", session_Id);
			dictionary.Add("name", attributeName);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/id/",
				session_Id,
				"/",
				attributeName
			});
			RESTConnectorWWW.GetInstance().ExecuteDelete(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x000281E8 File Offset: 0x000263E8
		public void RemoveAllAttributes(string sessionId, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(sessionId, "Session Id");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			if (dictionary.ContainsKey("sessionId"))
			{
				dictionary.Remove("sessionId");
			}
			dictionary.Add("sessionId", sessionId);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/id/",
				sessionId
			});
			RESTConnectorWWW.GetInstance().ExecuteDelete(url, paramsDics, dictionary, dictionary2, callBack);
		}
	}
}
