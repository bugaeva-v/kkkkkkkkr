using System;

namespace com.shephertz.app42.paas.sdk.csharp
{
	// Token: 0x0200003A RID: 58
	public class Config
	{
		// Token: 0x06000246 RID: 582 RVA: 0x0000D134 File Offset: 0x0000B334
		private Config()
		{
			this.baseURL = "https://api.shephertz.com/cloud/";
			this.eventBaseURL = "https://analytics.shephertz.com/cloud/";
			this.customCodeURL = "https://customcode.shephertz.com/";
			this.fbOAuthURL = "https://api.shephertz.com/facebook/OAuth/";
			App42Log.Console("Configuration Properties " + this.baseURL);
		}

		// Token: 0x06000247 RID: 583 RVA: 0x0000D1A9 File Offset: 0x0000B3A9
		public static Config GetInstance()
		{
			if (Config.config == null)
			{
				Config.config = new Config();
			}
			return Config.config;
		}

		// Token: 0x06000248 RID: 584 RVA: 0x0000D1C4 File Offset: 0x0000B3C4
		public void SetFbOAuthURL(string protocol, string host, int port)
		{
			this.fbOAuthURL = string.Concat(new object[]
			{
				protocol,
				host,
				":",
				port,
				"/App42_API_SERVER/facebook/OAuth/"
			});
		}

		// Token: 0x06000249 RID: 585 RVA: 0x0000D205 File Offset: 0x0000B405
		public string GetFbOAuthURL()
		{
			return this.fbOAuthURL;
		}

		// Token: 0x0600024A RID: 586 RVA: 0x0000D210 File Offset: 0x0000B410
		public void SetBaseURL(string protocol, string host, int port)
		{
			this.baseURL = string.Concat(new object[]
			{
				protocol,
				host,
				":",
				port,
				this.serverName
			});
		}

		// Token: 0x0600024B RID: 587 RVA: 0x0000D254 File Offset: 0x0000B454
		public void SetEventBaseURL(string protocol, string host, int port)
		{
			this.eventBaseURL = string.Concat(new object[]
			{
				protocol,
				host,
				":",
				port,
				this.serverName
			});
		}

		// Token: 0x0600024C RID: 588 RVA: 0x0000D296 File Offset: 0x0000B496
		public void SetBaseURL(string url)
		{
			this.baseURL = url;
		}

		// Token: 0x0600024D RID: 589 RVA: 0x0000D29F File Offset: 0x0000B49F
		public string GetBaseURL()
		{
			return this.baseURL;
		}

		// Token: 0x0600024E RID: 590 RVA: 0x0000D2A7 File Offset: 0x0000B4A7
		public void SetEventBaseURL(string url)
		{
			this.eventBaseURL = url;
		}

		// Token: 0x0600024F RID: 591 RVA: 0x0000D2B0 File Offset: 0x0000B4B0
		public string GetEventBaseURL()
		{
			return this.eventBaseURL;
		}

		// Token: 0x06000250 RID: 592 RVA: 0x0000D2B8 File Offset: 0x0000B4B8
		public void SetContentType(string contentType)
		{
			this.contentType = contentType;
		}

		// Token: 0x06000251 RID: 593 RVA: 0x0000D2C1 File Offset: 0x0000B4C1
		public string GetContentType()
		{
			return this.contentType;
		}

		// Token: 0x06000252 RID: 594 RVA: 0x0000D2C9 File Offset: 0x0000B4C9
		public void SetAccept(string accept)
		{
			this.accept = accept;
		}

		// Token: 0x06000253 RID: 595 RVA: 0x0000D2D2 File Offset: 0x0000B4D2
		public string GetAccept()
		{
			return this.accept;
		}

		// Token: 0x06000254 RID: 596 RVA: 0x0000D2DA File Offset: 0x0000B4DA
		public string GetCustomCodeURL()
		{
			return this.customCodeURL;
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0000D2E2 File Offset: 0x0000B4E2
		public void SetCustomCodeURL(string customCodeURL)
		{
			this.customCodeURL = customCodeURL;
		}

		// Token: 0x040000C0 RID: 192
		private static Config config;

		// Token: 0x040000C1 RID: 193
		private string baseURL;

		// Token: 0x040000C2 RID: 194
		private string eventBaseURL;

		// Token: 0x040000C3 RID: 195
		private string serverName = "/App42_API_SERVER/cloud/";

		// Token: 0x040000C4 RID: 196
		private string contentType = "application/json";

		// Token: 0x040000C5 RID: 197
		private string accept = "application/json";

		// Token: 0x040000C6 RID: 198
		private string customCodeURL;

		// Token: 0x040000C7 RID: 199
		private string fbOAuthURL;
	}
}
