using System;

namespace com.shephertz.app42.paas.sdk.csharp
{
	// Token: 0x0200001C RID: 28
	public class App42LimitException : App42Exception
	{
		// Token: 0x0600011D RID: 285 RVA: 0x00005E35 File Offset: 0x00004035
		public App42LimitException(string message) : base(message)
		{
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00005E3E File Offset: 0x0000403E
		public App42LimitException(string message, int httpErrorCode, int appErrorCode) : base(message, httpErrorCode, appErrorCode)
		{
			this.httpErrorCode = httpErrorCode;
			this.appErrorCode = appErrorCode;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00005E57 File Offset: 0x00004057
		public new void SetHttpErrorCode(int httpErrorCode)
		{
			this.httpErrorCode = httpErrorCode;
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00005E60 File Offset: 0x00004060
		public new int GetHttpErrorCode()
		{
			return this.httpErrorCode;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00005E68 File Offset: 0x00004068
		public new void SetAppErrorCode(int appErrorCode)
		{
			this.appErrorCode = appErrorCode;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00005E71 File Offset: 0x00004071
		public new int GetAppErrorCode()
		{
			return this.appErrorCode;
		}

		// Token: 0x0400006D RID: 109
		private int httpErrorCode;

		// Token: 0x0400006E RID: 110
		private int appErrorCode;
	}
}
