using System;
using System.Collections.Generic;
using System.Text;
using com.shephertz.app42.paas.sdk.csharp.connection;
using com.shephertz.app42.paas.sdk.csharp.util;

namespace com.shephertz.app42.paas.sdk.csharp.log
{
	// Token: 0x0200007A RID: 122
	public class LogService : App42Service
	{
		// Token: 0x060004F4 RID: 1268 RVA: 0x0001999B File Offset: 0x00017B9B
		public LogService(string apiKey, string secretKey)
		{
			this.apiKey = apiKey;
			this.secretKey = secretKey;
			this.version = "1.0";
			this.resource = "log";
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x000199C8 File Offset: 0x00017BC8
		public void Info(string msg, string module, App42CallBack callBack)
		{
			string text = "info";
			Util.ThrowExceptionIfNullOrBlank(msg, "Message");
			Util.ThrowExceptionIfNullOrBlank(module, "App Module");
			Util.ThrowExceptionIfNullOrBlank(text, "Level");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"message\":\"" + msg + "\",");
			stringBuilder.Append("\"appModule\":\"" + module + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"log\":").Append(stringBuilder.ToString()).Append("}}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/",
				text
			});
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x00019B04 File Offset: 0x00017D04
		public void Debug(string msg, string module, App42CallBack callBack)
		{
			string text = "debug";
			Util.ThrowExceptionIfNullOrBlank(msg, "Message");
			Util.ThrowExceptionIfNullOrBlank(module, "App Module");
			Util.ThrowExceptionIfNullOrBlank(text, "Level");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"message\":\"" + msg + "\",");
			stringBuilder.Append("\"appModule\":\"" + module + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"log\":").Append(stringBuilder.ToString()).Append("}}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/",
				text
			});
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x00019C40 File Offset: 0x00017E40
		public void Fatal(string msg, string module, App42CallBack callBack)
		{
			string text = "fatal";
			Util.ThrowExceptionIfNullOrBlank(msg, "Message");
			Util.ThrowExceptionIfNullOrBlank(module, "App Module");
			Util.ThrowExceptionIfNullOrBlank(text, "Level");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"message\":\"" + msg + "\",");
			stringBuilder.Append("\"appModule\":\"" + module + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"log\":").Append(stringBuilder.ToString()).Append("}}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/",
				text
			});
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x00019D7C File Offset: 0x00017F7C
		public void Error(string msg, string module, App42CallBack callBack)
		{
			string text = "error";
			Util.ThrowExceptionIfNullOrBlank(msg, "Message");
			Util.ThrowExceptionIfNullOrBlank(module, "App Module");
			Util.ThrowExceptionIfNullOrBlank(text, "Level");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"message\":\"" + msg + "\",");
			stringBuilder.Append("\"appModule\":\"" + module + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"log\":").Append(stringBuilder.ToString()).Append("}}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/",
				text
			});
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x00019EB8 File Offset: 0x000180B8
		public void FetchLogsByModule(string moduleName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(moduleName, "Module");
			Util.ThrowExceptionIfNullOrBlank(moduleName, "ModuleName");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("moduleName", moduleName);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/module/",
				moduleName
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x00019F74 File Offset: 0x00018174
		public void FetchLogsByModuleAndText(string moduleName, string text, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(moduleName, "Module");
			Util.ThrowExceptionIfNullOrBlank(text, "Text");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("moduleName", moduleName);
			dictionary.Add("text", text);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/module/",
				moduleName,
				"/text/",
				text
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x0001A048 File Offset: 0x00018248
		public void FetchLogsByInfo(App42CallBack callBack)
		{
			string text = "INFO";
			Util.ThrowExceptionIfNullOrBlank(text, "Level");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("type", text);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/type/",
				text
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x0001A104 File Offset: 0x00018304
		public void FetchLogsByDebug(App42CallBack callBack)
		{
			string text = "DEBUG";
			Util.ThrowExceptionIfNullOrBlank(text, "Level");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("type", text);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/type/",
				text
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x0001A1C0 File Offset: 0x000183C0
		public void FetchLogsByError(App42CallBack callBack)
		{
			string text = "ERROR";
			Util.ThrowExceptionIfNullOrBlank(text, "Level");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("type", text);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/type/",
				text
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x0001A27C File Offset: 0x0001847C
		public void FetchLogsByFatal(App42CallBack callBack)
		{
			string text = "FATAL";
			Util.ThrowExceptionIfNullOrBlank(text, "Level");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("type", text);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/type/",
				text
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x0001A338 File Offset: 0x00018538
		public void FetchLogByDateRange(DateTime startDate, DateTime endDate, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(startDate, "Start Date");
			Util.ThrowExceptionIfNullOrBlank(endDate, "End Date");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			string utcformattedTimestamp = Util.GetUTCFormattedTimestamp(startDate);
			string utcformattedTimestamp2 = Util.GetUTCFormattedTimestamp(endDate);
			dictionary.Add("startDate", utcformattedTimestamp);
			dictionary.Add("endDate", utcformattedTimestamp2);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/startDate/",
				utcformattedTimestamp,
				"/endDate/",
				utcformattedTimestamp2
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x0001A42C File Offset: 0x0001862C
		public void FetchLogsByInfo(int max, int offset, App42CallBack callBack)
		{
			string text = "INFO";
			Util.ValidateMax(max);
			Util.ThrowExceptionIfNullOrBlank(text, "Level");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("type", text);
			dictionary.Add("max", string.Concat(max));
			dictionary.Add("offset", string.Concat(offset));
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new object[]
			{
				this.version,
				"/",
				this.resource,
				"/paging/type/",
				text,
				"/",
				max,
				"/",
				offset
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x0001A540 File Offset: 0x00018740
		public void FetchLogsByDebug(int max, int offset, App42CallBack callBack)
		{
			string text = "DEBUG";
			Util.ValidateMax(max);
			Util.ThrowExceptionIfNullOrBlank(text, "Level");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("type", text);
			dictionary.Add("max", string.Concat(max));
			dictionary.Add("offset", string.Concat(offset));
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new object[]
			{
				this.version,
				"/",
				this.resource,
				"/paging/type/",
				text,
				"/",
				max,
				"/",
				offset
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x0001A654 File Offset: 0x00018854
		public void FetchLogsByError(int max, int offset, App42CallBack callBack)
		{
			string text = "ERROR";
			Util.ValidateMax(max);
			Util.ThrowExceptionIfNullOrBlank(text, "Level");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("type", text);
			dictionary.Add("max", string.Concat(max));
			dictionary.Add("offset", string.Concat(offset));
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new object[]
			{
				this.version,
				"/",
				this.resource,
				"/paging/type/",
				text,
				"/",
				max,
				"/",
				offset
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x0001A768 File Offset: 0x00018968
		public void FetchLogsByFatal(int max, int offset, App42CallBack callBack)
		{
			string text = "FATAL";
			Util.ValidateMax(max);
			Util.ThrowExceptionIfNullOrBlank(text, "Level");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("type", text);
			dictionary.Add("max", string.Concat(max));
			dictionary.Add("offset", string.Concat(offset));
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new object[]
			{
				this.version,
				"/",
				this.resource,
				"/paging/type/",
				text,
				"/",
				max,
				"/",
				offset
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x0001A87C File Offset: 0x00018A7C
		public void FetchLogsByModule(string moduleName, int max, int offset, App42CallBack callBack)
		{
			Util.ValidateMax(max);
			Util.ThrowExceptionIfNullOrBlank(moduleName, "ModuleName");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("moduleName", moduleName);
			dictionary.Add("max", string.Concat(max));
			dictionary.Add("offset", string.Concat(offset));
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new object[]
			{
				this.version,
				"/",
				this.resource,
				"/paging/module/",
				moduleName,
				"/",
				max,
				"/",
				offset
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x0001A988 File Offset: 0x00018B88
		public void FetchLogsByModuleAndText(string moduleName, string text, int max, int offset, App42CallBack callBack)
		{
			Util.ValidateMax(max);
			Util.ThrowExceptionIfNullOrBlank(moduleName, "Module");
			Util.ThrowExceptionIfNullOrBlank(text, "Text");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("moduleName", moduleName);
			dictionary.Add("text", text);
			dictionary.Add("max", string.Concat(max));
			dictionary.Add("offset", string.Concat(offset));
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new object[]
			{
				this.version,
				"/",
				this.resource,
				"/paging/module/",
				moduleName,
				"/text/",
				text,
				"/",
				max,
				"/",
				offset
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x0001AABC File Offset: 0x00018CBC
		public void FetchLogByDateRange(DateTime startDate, DateTime endDate, int max, int offset, App42CallBack callBack)
		{
			Util.ValidateMax(max);
			Util.ThrowExceptionIfNullOrBlank(startDate, "Start Date");
			Util.ThrowExceptionIfNullOrBlank(endDate, "End Date");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			string utcformattedTimestamp = Util.GetUTCFormattedTimestamp(startDate);
			string utcformattedTimestamp2 = Util.GetUTCFormattedTimestamp(endDate);
			dictionary.Add("startDate", utcformattedTimestamp);
			dictionary.Add("endDate", utcformattedTimestamp2);
			dictionary.Add("max", string.Concat(max));
			dictionary.Add("offset", string.Concat(offset));
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new object[]
			{
				this.version,
				"/",
				this.resource,
				"/paging/startDate/",
				utcformattedTimestamp,
				"/endDate/",
				utcformattedTimestamp2,
				"/",
				max,
				"/",
				offset
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x0001AC0C File Offset: 0x00018E0C
		public void FetchLogsCountByModule(string moduleName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(moduleName, "Module");
			Util.ThrowExceptionIfNullOrBlank(moduleName, "ModuleName");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("moduleName", moduleName);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/module/",
				moduleName,
				"/count"
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x0001ACD0 File Offset: 0x00018ED0
		public void FetchLogsCountByModuleAndText(string moduleName, string text, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(moduleName, "Module");
			Util.ThrowExceptionIfNullOrBlank(text, "Text");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("moduleName", moduleName);
			dictionary.Add("text", text);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/module/",
				moduleName,
				"/text/",
				text,
				"/count"
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x0001ADB0 File Offset: 0x00018FB0
		public void FetchLogsCountByInfo(App42CallBack callBack)
		{
			string text = "INFO";
			Util.ThrowExceptionIfNullOrBlank(text, "Level");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("type", text);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/type/",
				text,
				"/count"
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x0001AE74 File Offset: 0x00019074
		public void FetchLogsCountByDebug(App42CallBack callBack)
		{
			string text = "DEBUG";
			Util.ThrowExceptionIfNullOrBlank(text, "Level");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("type", text);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/type/",
				text,
				"/count"
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x0001AF38 File Offset: 0x00019138
		public void FetchLogsCountByError(App42CallBack callBack)
		{
			string text = "ERROR";
			Util.ThrowExceptionIfNullOrBlank(text, "Level");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("type", text);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/type/",
				text,
				"/count"
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x0001AFFC File Offset: 0x000191FC
		public void FetchLogsCountByFatal(App42CallBack callBack)
		{
			string text = "FATAL";
			Util.ThrowExceptionIfNullOrBlank(text, "Level");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("type", text);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/type/",
				text,
				"/count"
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x0001B0C0 File Offset: 0x000192C0
		public void FetchLogCountByDateRange(DateTime startDate, DateTime endDate, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(startDate, "Start Date");
			Util.ThrowExceptionIfNullOrBlank(endDate, "End Date");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			string utcformattedTimestamp = Util.GetUTCFormattedTimestamp(startDate);
			string utcformattedTimestamp2 = Util.GetUTCFormattedTimestamp(endDate);
			dictionary.Add("startDate", utcformattedTimestamp);
			dictionary.Add("endDate", utcformattedTimestamp2);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/startDate/",
				utcformattedTimestamp,
				"/endDate/",
				utcformattedTimestamp2,
				"/count"
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x0001B1BB File Offset: 0x000193BB
		public void SetEvent(string moduleName, string eventName, App42CallBack callBack)
		{
			this.Event = eventName;
			Util.ThrowExceptionIfNullOrBlank(eventName, "eventName");
			this.Info("EventMessage", moduleName, callBack);
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x0001B1DC File Offset: 0x000193DC
		public void SetEvent(string eventName, App42CallBack callBack)
		{
			this.Event = eventName;
			Util.ThrowExceptionIfNullOrBlank(eventName, "eventName");
			this.Info(eventName, "_App42_Event", callBack);
		}
	}
}
