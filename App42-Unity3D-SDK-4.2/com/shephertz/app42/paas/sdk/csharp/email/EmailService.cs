using System;
using System.Collections.Generic;
using System.Text;
using com.shephertz.app42.paas.sdk.csharp.connection;
using com.shephertz.app42.paas.sdk.csharp.util;

namespace com.shephertz.app42.paas.sdk.csharp.email
{
	// Token: 0x02000040 RID: 64
	public class EmailService : App42Service
	{
		// Token: 0x06000272 RID: 626 RVA: 0x0000D689 File Offset: 0x0000B889
		public EmailService(string apiKey, string secretKey)
		{
			this.apiKey = apiKey;
			this.secretKey = secretKey;
			this.version = "1.0";
			this.resource = "email";
		}

		// Token: 0x06000273 RID: 627 RVA: 0x0000D6B8 File Offset: 0x0000B8B8
		public void CreateMailConfiguration(string emailHost, long emailPort, string mailId, string emailPassword, bool isSSL, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(emailHost, "Host");
			Util.ThrowExceptionIfNullOrBlank(emailPort, "Port");
			Util.ThrowExceptionIfNullOrBlank(mailId, "Email Id");
			Util.ThrowExceptionIfEmailNotValid(mailId, "Email Id");
			Util.ThrowExceptionIfNullOrBlank(emailPassword, "Password");
			Util.ThrowExceptionIfNullOrBlank(isSSL, "isSSL");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"host\":\"" + emailHost + "\",");
			stringBuilder.Append("\"port\":" + emailPort + ",");
			stringBuilder.Append("\"emailId\":\"" + mailId + "\",");
			stringBuilder.Append("\"password\":\"" + emailPassword + "\",");
			stringBuilder.Append("\"ssl\":" + isSSL + "}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"email\":").Append(stringBuilder.ToString()).Append("}}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/configuration";
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x06000274 RID: 628 RVA: 0x0000D850 File Offset: 0x0000BA50
		public void RemoveEmailConfiguration(string emailId, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(emailId, "Email Id");
			Util.ThrowExceptionIfEmailNotValid(emailId, "Email Id");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("emailId", emailId);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/configuration/",
				emailId
			});
			RESTConnectorWWW.GetInstance().ExecuteDelete(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000275 RID: 629 RVA: 0x0000D90C File Offset: 0x0000BB0C
		public void GetEmailConfigurations(App42CallBack callBack)
		{
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/configuration";
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000276 RID: 630 RVA: 0x0000D988 File Offset: 0x0000BB88
		public void SendMail(string sendTo, string sendSubject, string sendMsg, string fromEmail, string emailMime, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(sendTo, "Send To");
			Util.ThrowExceptionIfNullOrBlank(sendSubject, "Send Subject");
			Util.ThrowExceptionIfNullOrBlank(sendMsg, "Send Message");
			Util.ThrowExceptionIfNullOrBlank(fromEmail, "From Email");
			Util.ThrowExceptionIfNullOrBlank(emailMime, "emailMime");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"to\":\"" + sendTo + "\",");
			stringBuilder.Append("\"subject\":\"" + sendSubject + "\",");
			stringBuilder.Append("\"emailId\":\"" + fromEmail + "\",");
			stringBuilder.Append("\"msg\":\"" + sendMsg + "\",");
			stringBuilder.Append("\"mimeType\":\"" + emailMime + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"email\":").Append(stringBuilder.ToString()).Append("}}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource;
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}
	}
}
