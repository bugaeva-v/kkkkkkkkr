using System;
using System.Collections.Generic;
using System.Text;
using com.shephertz.app42.paas.sdk.csharp.connection;
using com.shephertz.app42.paas.sdk.csharp.util;

namespace com.shephertz.app42.paas.sdk.csharp.message
{
	// Token: 0x0200008B RID: 139
	public class QueueService : App42Service
	{
		// Token: 0x060005A4 RID: 1444 RVA: 0x0001FCC5 File Offset: 0x0001DEC5
		public QueueService(string apiKey, string secretKey)
		{
			this.apiKey = apiKey;
			this.secretKey = secretKey;
			this.version = "1.0";
			this.resource = "queue";
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x0001FCFC File Offset: 0x0001DEFC
		public void CreatePullQueue(string queueName, string queueDescription, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(queueName, "Queue Name");
			Util.ThrowExceptionIfNullOrBlank(queueDescription, "Queue Description");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("type", "pull");
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"name\":\"" + queueName + "\",");
			stringBuilder.Append("\"description\":\"" + queueDescription + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"queue\":").Append(stringBuilder.ToString()).Append("}}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/pull";
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x0001FE14 File Offset: 0x0001E014
		public void DeletePullQueue(string queueName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(queueName, "Queue Name");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("type", "pull");
			dictionary.Add("queueName", queueName);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/pull/",
				queueName
			});
			RESTConnectorWWW.GetInstance().ExecuteDelete(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x0001FED4 File Offset: 0x0001E0D4
		public void PurgePullQueue(string queueName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(queueName, "Queue Name");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("queueName", queueName);
			dictionary.Add("type", "pull");
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/pull/purge/",
				queueName
			});
			RESTConnectorWWW.GetInstance().ExecuteDelete(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x0001FF94 File Offset: 0x0001E194
		public void PendingMessages(string queueName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(queueName, "Queue Name");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("queueName", queueName);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/pending/",
				queueName
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x00020044 File Offset: 0x0001E244
		public void GetMessages(string queueName, long receiveTimeOut, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(queueName, "Queue Name");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("queueName", queueName);
			dictionary.Add("receiveTimeOut", string.Concat(receiveTimeOut));
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new object[]
			{
				this.version,
				"/",
				this.resource,
				"/messages/",
				queueName,
				"/",
				receiveTimeOut
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x0002011C File Offset: 0x0001E31C
		public void SendMessage(string queueName, string msg, long exp, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(queueName, "Queue Name");
			Util.ThrowExceptionIfNullOrBlank(msg, "Message");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("queueName", queueName);
			StringBuilder stringBuilder = new StringBuilder();
			if (msg.Contains("{"))
			{
				if (msg.IndexOf("{") > -1)
				{
					stringBuilder.Append("{\"message\":" + msg + ",");
				}
			}
			else
			{
				stringBuilder.Append("{\"message\":\"" + msg + "\",");
			}
			stringBuilder.Append("\"expiration\":" + exp + "}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"payLoad\":").Append(stringBuilder.ToString()).Append("}}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.messageResource,
				"/",
				queueName
			});
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x0002028C File Offset: 0x0001E48C
		public void ReceiveMessage(string queueName, long receiveTimeOut, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(queueName, "Queue Name");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("queueName", queueName);
			dictionary.Add("receiveTimeOut", string.Concat(receiveTimeOut));
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new object[]
			{
				this.version,
				"/",
				this.messageResource,
				"/",
				queueName,
				"/",
				receiveTimeOut
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x00020364 File Offset: 0x0001E564
		public void ReceiveMessageByCorrelationId(string queueName, long receiveTimeOut, string correlationId, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(queueName, "Queue Name");
			Util.ThrowExceptionIfNullOrBlank(correlationId, "Correlation Id");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("queueName", queueName);
			dictionary.Add("receiveTimeOut", string.Concat(receiveTimeOut));
			dictionary.Add("correlationId", correlationId ?? "");
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new object[]
			{
				this.version,
				"/",
				this.messageResource,
				"/",
				queueName,
				"/",
				receiveTimeOut,
				"/",
				correlationId
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x0002046C File Offset: 0x0001E66C
		public void RemoveMessage(string queueName, string messageId, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(queueName, "Queue Name");
			Util.ThrowExceptionIfNullOrBlank(messageId, "Message Id");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("queueName", queueName);
			dictionary.Add("messageId", messageId);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.messageResource,
				"/",
				queueName,
				"/",
				messageId
			});
			RESTConnectorWWW.GetInstance().ExecuteDelete(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x0400025C RID: 604
		private string messageResource = "message";
	}
}
