using System;

namespace Firebase
{
	// Token: 0x02000002 RID: 2
	public sealed class AppOptions : IDisposable
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public AppOptions()
		{
		}

		// Token: 0x06000002 RID: 2 RVA: 0x0000205A File Offset: 0x0000025A
		public void Dispose()
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000003 RID: 3 RVA: 0x0000205D File Offset: 0x0000025D
		// (set) Token: 0x06000004 RID: 4 RVA: 0x00002065 File Offset: 0x00000265
		public Uri DatabaseUrl { get; set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000005 RID: 5 RVA: 0x0000206E File Offset: 0x0000026E
		// (set) Token: 0x06000006 RID: 6 RVA: 0x00002076 File Offset: 0x00000276
		public string AppId { get; set; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000007 RID: 7 RVA: 0x0000207F File Offset: 0x0000027F
		// (set) Token: 0x06000008 RID: 8 RVA: 0x00002087 File Offset: 0x00000287
		public string ApiKey { get; set; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00002090 File Offset: 0x00000290
		// (set) Token: 0x0600000A RID: 10 RVA: 0x00002098 File Offset: 0x00000298
		public string MessageSenderId { get; set; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000B RID: 11 RVA: 0x000020A1 File Offset: 0x000002A1
		// (set) Token: 0x0600000C RID: 12 RVA: 0x000020A9 File Offset: 0x000002A9
		public string StorageBucket { get; set; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000D RID: 13 RVA: 0x000020B2 File Offset: 0x000002B2
		// (set) Token: 0x0600000E RID: 14 RVA: 0x000020BA File Offset: 0x000002BA
		public string ProjectId { get; set; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000F RID: 15 RVA: 0x000020C3 File Offset: 0x000002C3
		// (set) Token: 0x06000010 RID: 16 RVA: 0x000020CB File Offset: 0x000002CB
		internal string PackageName { get; set; }

		// Token: 0x06000011 RID: 17 RVA: 0x000020D4 File Offset: 0x000002D4
		public static AppOptions LoadFromJsonConfig(string json_config)
		{
			AppOptionsInternal appOptionsInternal = AppUtil.AppOptionsLoadFromJsonConfig(json_config);
			bool flag = appOptionsInternal == null;
			AppOptions result;
			if (flag)
			{
				result = null;
			}
			else
			{
				result = new AppOptions(appOptionsInternal);
			}
			return result;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002100 File Offset: 0x00000300
		internal AppOptions(AppOptionsInternal other)
		{
			this.DatabaseUrl = other.DatabaseUrl;
			this.AppId = other.AppId;
			this.ApiKey = other.ApiKey;
			this.MessageSenderId = other.MessageSenderId;
			this.StorageBucket = other.StorageBucket;
			this.ProjectId = other.ProjectId;
			this.PackageName = other.PackageName;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002170 File Offset: 0x00000370
		internal AppOptionsInternal ConvertToInternal()
		{
			AppOptionsInternal appOptionsInternal = new AppOptionsInternal();
			appOptionsInternal.DatabaseUrl = this.DatabaseUrl;
			bool flag = !string.IsNullOrEmpty(this.AppId);
			if (flag)
			{
				appOptionsInternal.AppId = this.AppId;
			}
			bool flag2 = !string.IsNullOrEmpty(this.ApiKey);
			if (flag2)
			{
				appOptionsInternal.ApiKey = this.ApiKey;
			}
			bool flag3 = !string.IsNullOrEmpty(this.MessageSenderId);
			if (flag3)
			{
				appOptionsInternal.MessageSenderId = this.MessageSenderId;
			}
			bool flag4 = !string.IsNullOrEmpty(this.StorageBucket);
			if (flag4)
			{
				appOptionsInternal.StorageBucket = this.StorageBucket;
			}
			bool flag5 = !string.IsNullOrEmpty(this.ProjectId);
			if (flag5)
			{
				appOptionsInternal.ProjectId = this.ProjectId;
			}
			bool flag6 = !string.IsNullOrEmpty(this.PackageName);
			if (flag6)
			{
				appOptionsInternal.PackageName = this.PackageName;
			}
			return appOptionsInternal;
		}
	}
}
