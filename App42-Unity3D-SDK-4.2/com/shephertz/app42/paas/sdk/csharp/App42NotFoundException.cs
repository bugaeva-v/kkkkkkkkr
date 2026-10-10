using System;

namespace com.shephertz.app42.paas.sdk.csharp
{
	// Token: 0x0200001E RID: 30
	public class App42NotFoundException : App42Exception
	{
		// Token: 0x0600012B RID: 299 RVA: 0x00005EB9 File Offset: 0x000040B9
		public App42NotFoundException(string message) : base(message)
		{
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00005EC2 File Offset: 0x000040C2
		public App42NotFoundException(string message, int httpErrorCode, int appErrorCode) : base(message, httpErrorCode, appErrorCode)
		{
			this.httpErrorCode = httpErrorCode;
			this.appErrorCode = appErrorCode;
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00005EDB File Offset: 0x000040DB
		public new void SetHttpErrorCode(int httpErrorCode)
		{
			this.httpErrorCode = httpErrorCode;
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00005EE4 File Offset: 0x000040E4
		public new int GetHttpErrorCode()
		{
			return this.httpErrorCode;
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00005EEC File Offset: 0x000040EC
		public new void SetAppErrorCode(int appErrorCode)
		{
			this.appErrorCode = appErrorCode;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00005EF5 File Offset: 0x000040F5
		public new int GetAppErrorCode()
		{
			return this.appErrorCode;
		}

		// Token: 0x04000070 RID: 112
		private int httpErrorCode;

		// Token: 0x04000071 RID: 113
		private int appErrorCode;
	}
}
