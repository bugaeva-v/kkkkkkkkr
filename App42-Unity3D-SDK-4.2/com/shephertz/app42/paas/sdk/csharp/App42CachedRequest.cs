using System;
using System.Collections.Generic;
using System.Text;
using com.shephertz.app42.paas.sdk.csharp.util;

namespace com.shephertz.app42.paas.sdk.csharp
{
	// Token: 0x02000015 RID: 21
	internal class App42CachedRequest
	{
		// Token: 0x060000DB RID: 219 RVA: 0x00004DE0 File Offset: 0x00002FE0
		internal App42CachedRequest()
		{
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00004DFE File Offset: 0x00002FFE
		internal App42CachedRequest(string methodType, string targetUrl, Dictionary<string, string> headerParams, string bodyMessage)
		{
			this.bodyMessage = bodyMessage;
			this.headerParams = headerParams;
			this.targetUrl = targetUrl;
			this.methodType = methodType;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00004E3C File Offset: 0x0000303C
		internal App42CachedRequest(string methodType, string targetUrl, Dictionary<string, string> signParams, Dictionary<string, string> headerParams, string bodyMessage, string secretKey)
		{
			this.bodyMessage = bodyMessage;
			this.headerParams = headerParams;
			this.targetUrl = targetUrl;
			this.methodType = methodType;
			this.signParams = signParams;
			this.secretKey = secretKey;
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00004E92 File Offset: 0x00003092
		internal string GetMethodType()
		{
			return this.methodType;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00004E9A File Offset: 0x0000309A
		internal void SetMethodType(string methodType)
		{
			this.methodType = methodType;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00004EA3 File Offset: 0x000030A3
		internal string GetTargetUrl()
		{
			return this.targetUrl;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00004EAB File Offset: 0x000030AB
		internal void SetTargetUrl(string targetUrl)
		{
			this.targetUrl = targetUrl;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00004EB4 File Offset: 0x000030B4
		internal Dictionary<string, string> GetHeaderParams()
		{
			return this.headerParams;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00004EBC File Offset: 0x000030BC
		public void SetHeaderParams(Dictionary<string, string> headerParams)
		{
			this.headerParams = headerParams;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00004EC5 File Offset: 0x000030C5
		internal string GetBodyMessage()
		{
			return this.bodyMessage;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00004ECD File Offset: 0x000030CD
		internal void SetBodyMessage(string bodyMessage)
		{
			this.bodyMessage = bodyMessage;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00004ED8 File Offset: 0x000030D8
		internal new string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			try
			{
				stringBuilder.Append("{\"targetUrl\":\"" + this.targetUrl + "\",");
				if (!string.IsNullOrEmpty(this.bodyMessage))
				{
					stringBuilder.Append("\"bodyMessage\":" + this.bodyMessage + ",");
				}
				stringBuilder.Append("\"secretKey\":\"" + this.secretKey + "\",");
				stringBuilder.Append("\"headerParams\":" + this.ProcessFormat(this.headerParams) + ",");
				stringBuilder.Append("\"methodType\":\"" + this.methodType + "\",");
				stringBuilder.Append("\"signParams\":" + this.ProcessFormat(this.signParams) + ",");
				stringBuilder.Append("\"offlineRequestTime\":\"" + Util.GetUTCFormattedTimestamp() + "\"}");
			}
			catch (Exception arg)
			{
				App42Log.Console("Exception : " + arg);
				return "";
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00004FFC File Offset: 0x000031FC
		private string ProcessFormat(Dictionary<string, string> paramsToProcess)
		{
			string result;
			try
			{
				StringBuilder stringBuilder = new StringBuilder("{");
				foreach (KeyValuePair<string, string> keyValuePair in paramsToProcess)
				{
					stringBuilder.Append(string.Concat(new object[]
					{
						'"',
						keyValuePair.Key,
						'"',
						":"
					}));
					if (keyValuePair.Value != null)
					{
						if (keyValuePair.Key.Equals("body") || keyValuePair.Key.Equals("geoTag") || keyValuePair.Key.Equals("metaQuery") || (keyValuePair.Key.Equals("jsonObject") | keyValuePair.Key.Equals("dbCredentials")))
						{
							stringBuilder.Append(keyValuePair.Value + ",");
						}
						else
						{
							stringBuilder.Append(string.Concat(new object[]
							{
								'"',
								keyValuePair.Value.ToString(),
								'"',
								","
							}));
						}
					}
					else
					{
						stringBuilder.Append(keyValuePair.Value + ",");
					}
				}
				int startIndex = stringBuilder.ToString().LastIndexOf(",");
				stringBuilder.Remove(startIndex, 1);
				result = stringBuilder.ToString() + "}";
			}
			catch (ArgumentException ex)
			{
				throw new App42Exception(ex.ToString());
			}
			return result;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x000051DC File Offset: 0x000033DC
		public Dictionary<string, string> GetSignParams()
		{
			return this.signParams;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x000051E4 File Offset: 0x000033E4
		public void SetSignParams(Dictionary<string, string> signParams)
		{
			this.signParams = signParams;
		}

		// Token: 0x0400004A RID: 74
		private string methodType;

		// Token: 0x0400004B RID: 75
		private string targetUrl;

		// Token: 0x0400004C RID: 76
		private Dictionary<string, string> headerParams = new Dictionary<string, string>();

		// Token: 0x0400004D RID: 77
		private Dictionary<string, string> signParams = new Dictionary<string, string>();

		// Token: 0x0400004E RID: 78
		private string bodyMessage;

		// Token: 0x0400004F RID: 79
		private string secretKey;
	}
}
