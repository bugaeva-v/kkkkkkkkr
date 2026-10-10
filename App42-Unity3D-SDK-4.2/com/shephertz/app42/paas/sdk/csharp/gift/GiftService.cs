using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using com.shephertz.app42.paas.sdk.csharp.connection;
using com.shephertz.app42.paas.sdk.csharp.util;
using SimpleJSON;

namespace com.shephertz.app42.paas.sdk.csharp.gift
{
	// Token: 0x02000058 RID: 88
	public class GiftService : App42Service
	{
		// Token: 0x06000344 RID: 836 RVA: 0x00011DE7 File Offset: 0x0000FFE7
		public GiftService(string apiKey, string secretKey)
		{
			this.apiKey = apiKey;
			this.secretKey = secretKey;
			this.version = "1.0";
			this.resource = "gift";
		}

		// Token: 0x06000345 RID: 837 RVA: 0x00011E14 File Offset: 0x00010014
		public void CreateGift(string giftName, string icon, string displayName, string description, string tag, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(giftName, "Gift Name");
			Util.ThrowExceptionIfNullOrBlank(icon, "Icon");
			Util.ThrowExceptionIfNullOrBlank(displayName, "Display Name");
			Util.ThrowExceptionIfNullOrBlank(tag, "Tag");
			Util.ThrowExceptionIfNullOrBlank(description, "Description");
			Dictionary<string, string> queryParams = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
			dictionary3.Add("name", giftName);
			dictionary3.Add("displayName", displayName);
			dictionary3.Add("description", description);
			dictionary3.Add("tag", tag);
			foreach (KeyValuePair<string, string> keyValuePair in dictionary3)
			{
				dictionary.Add(keyValuePair.Key, keyValuePair.Value);
			}
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource;
			RESTConnectorWWW.GetInstance().ExecuteMultipart("uploadFile", icon, queryParams, dictionary3, dictionary, dictionary2, url, Config.GetInstance().GetAccept(), callBack);
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00011F64 File Offset: 0x00010164
		public void CreateGift(string giftName, Stream icon, string displayName, string description, string tag, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(giftName, "Gift Name");
			Util.ThrowExceptionIfNullOrBlank(icon, "Icon");
			Util.ThrowExceptionIfNullOrBlank(displayName, "Display Name");
			Util.ThrowExceptionIfNullOrBlank(tag, "Tag");
			Util.ThrowExceptionIfNullOrBlank(description, "Description");
			Dictionary<string, string> queryParams = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
			dictionary3.Add("name", giftName);
			dictionary3.Add("displayName", displayName);
			dictionary3.Add("description", description);
			dictionary3.Add("tag", tag);
			foreach (KeyValuePair<string, string> keyValuePair in dictionary3)
			{
				dictionary.Add(keyValuePair.Key, keyValuePair.Value);
			}
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource;
			RESTConnectorWWW.GetInstance().ExecuteMultipart("uploadFile", icon, queryParams, dictionary3, dictionary, dictionary2, url, Config.GetInstance().GetAccept(), callBack);
		}

		// Token: 0x06000347 RID: 839 RVA: 0x000120B4 File Offset: 0x000102B4
		public void GetAllGifts(App42CallBack callBack)
		{
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/all";
			dictionary2.Add("isArray", "true");
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00012140 File Offset: 0x00010340
		public void GetGiftByName(string name, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(name, "Gift Name");
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

		// Token: 0x06000349 RID: 841 RVA: 0x000121F0 File Offset: 0x000103F0
		public void GetGiftsByTag(string tagName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(tagName, "Tag Name");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("tagName", tagName);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/tag/",
				tagName
			});
			dictionary2.Add("isArray", "true");
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x0600034A RID: 842 RVA: 0x000122B0 File Offset: 0x000104B0
		public void DeleteGiftByName(string name, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(name, "Gift Name");
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

		// Token: 0x0600034B RID: 843 RVA: 0x00012360 File Offset: 0x00010560
		public void SendGift(string name, string sender, IList<string> recipients, string message, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(name, "Giftname");
			Util.ThrowExceptionIfNullOrBlank(sender, "Sender");
			Util.ThrowExceptionIfNullOrBlank(recipients, "Recipients");
			Util.ThrowExceptionIfNullOrBlank(message, "Message");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"name\":\"" + name + "\",");
			stringBuilder.Append("\"sender\":\"" + sender + "\",");
			stringBuilder.Append("\"expiry\":\"" + Util.GetUTCFormattedTimestamp() + "\",");
			stringBuilder.Append("\"message\":\"" + message + "\",");
			JSONArray jsonarray = new JSONArray();
			for (int i = 0; i < recipients.Count; i++)
			{
				string text = recipients[i];
				jsonarray.Add(text.ToString());
			}
			stringBuilder.Append("\"recipient\":" + jsonarray.ToString() + "}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"gift\":").Append(stringBuilder.ToString()).Append("}}");
			App42Log.Console(" Json String : " + stringBuilder2.ToString());
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/send";
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00012524 File Offset: 0x00010724
		public void RequestGift(string name, string sender, IList<string> recipients, string message, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(name, "Giftname");
			Util.ThrowExceptionIfNullOrBlank(sender, "Sender");
			Util.ThrowExceptionIfNullOrBlank(recipients, "Recipients");
			Util.ThrowExceptionIfNullOrBlank(message, "Message");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"name\":\"" + name + "\",");
			stringBuilder.Append("\"sender\":\"" + sender + "\",");
			stringBuilder.Append("\"expiry\":\"" + Util.GetUTCFormattedTimestamp() + "\",");
			stringBuilder.Append("\"message\":\"" + message + "\",");
			JSONArray jsonarray = new JSONArray();
			for (int i = 0; i < recipients.Count; i++)
			{
				string text = recipients[i];
				jsonarray.Add(text.ToString());
			}
			stringBuilder.Append("\"recipient\":" + jsonarray.ToString() + "}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"gift\":").Append(stringBuilder.ToString()).Append("}}");
			App42Log.Console(" Json String : " + stringBuilder2.ToString());
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/request";
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x0600034D RID: 845 RVA: 0x000126E8 File Offset: 0x000108E8
		public void GetGiftRequest(string name, string userName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(name, "Gift Name");
			Util.ThrowExceptionIfNullOrBlank(userName, "User Name");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("name", name);
			dictionary.Add("userName", userName);
			dictionary.Add("requestType", "WISHREQUEST");
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/giftrequest/",
				name,
				"/",
				userName,
				"/type/WISHREQUEST"
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x0600034E RID: 846 RVA: 0x000127D8 File Offset: 0x000109D8
		public void DistributeGifts(string name, IList<string> recipients, int counts, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(name, "Giftname");
			Util.ThrowExceptionIfNullOrBlank(counts, "counts");
			Util.ThrowExceptionIfNullOrBlank(recipients, "recipients");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"name\":\"" + name + "\",");
			stringBuilder.Append("\"counts\":\"" + counts + "\",");
			stringBuilder.Append("\"expiry\":\"" + Util.GetUTCFormattedTimestamp() + "\",");
			JSONArray jsonarray = new JSONArray();
			for (int i = 0; i < recipients.Count; i++)
			{
				string text = recipients[i];
				jsonarray.Add(text.ToString());
			}
			stringBuilder.Append("\"recipient\":" + jsonarray.ToString() + "}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"gift\":").Append(stringBuilder.ToString()).Append("}}");
			App42Log.Console(" Json String : " + stringBuilder2.ToString());
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/sendtousers";
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00012980 File Offset: 0x00010B80
		public void GetGiftCount(string name, string userName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(name, "Giftname");
			Util.ThrowExceptionIfNullOrBlank(userName, "UserName");
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
				"/giftrequest/",
				name,
				"/",
				userName
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00012A54 File Offset: 0x00010C54
		public void AcceptGiftRequest(string requestId, string recipient, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(requestId, "RequestId");
			Util.ThrowExceptionIfNullOrBlank(recipient, "Recipient");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"requestId\":\"" + requestId + "\",");
			stringBuilder.Append("\"recipient\":\"" + recipient + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"gift\":").Append(stringBuilder.ToString()).Append("}}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/giftRequestAccpeted";
			RESTConnectorWWW.GetInstance().ExecutePut(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00012B5C File Offset: 0x00010D5C
		public void RejectGiftRequest(string requestId, string recipient, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(recipient, "Recipient");
			Util.ThrowExceptionIfNullOrBlank(requestId, "RequestId");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("requestId", requestId);
			dictionary.Add("recipient", recipient);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/rejectedGift/requestId/",
				requestId,
				"/recipient/",
				recipient
			});
			RESTConnectorWWW.GetInstance().ExecuteDelete(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00012C30 File Offset: 0x00010E30
		public void RemoveGift(string requestId, string recipient, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(recipient, "Recipient");
			Util.ThrowExceptionIfNullOrBlank(requestId, "RequestId");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("requestId", requestId);
			dictionary.Add("recipient", recipient);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/removeGift/requestId/",
				requestId,
				"/recipient/",
				recipient
			});
			RESTConnectorWWW.GetInstance().ExecuteDelete(url, paramsDics, dictionary, dictionary2, callBack);
		}
	}
}
