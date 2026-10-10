using System;

namespace com.shephertz.app42.paas.sdk.csharp
{
	// Token: 0x02000021 RID: 33
	public class App42SecurityException : App42Exception
	{
		// Token: 0x0600013E RID: 318 RVA: 0x00006B6C File Offset: 0x00004D6C
		public App42SecurityException(string message) : base(message)
		{
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00006B75 File Offset: 0x00004D75
		public App42SecurityException(string message, int httpErrorCode, int appErrorCode) : base(message, httpErrorCode, appErrorCode)
		{
			this.httpErrorCode = httpErrorCode;
			this.appErrorCode = appErrorCode;
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00006B8E File Offset: 0x00004D8E
		public new void SetHttpErrorCode(int httpErrorCode)
		{
			this.httpErrorCode = httpErrorCode;
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00006B97 File Offset: 0x00004D97
		public new int GetHttpErrorCode()
		{
			return this.httpErrorCode;
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00006B9F File Offset: 0x00004D9F
		public new void SetAppErrorCode(int appErrorCode)
		{
			this.appErrorCode = appErrorCode;
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00006BA8 File Offset: 0x00004DA8
		public new int GetAppErrorCode()
		{
			return this.appErrorCode;
		}

		// Token: 0x04000076 RID: 118
		private int httpErrorCode;

		// Token: 0x04000077 RID: 119
		private int appErrorCode;
	}
}
