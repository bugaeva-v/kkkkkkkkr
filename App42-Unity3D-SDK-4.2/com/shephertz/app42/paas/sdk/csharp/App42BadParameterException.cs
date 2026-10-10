using System;

namespace com.shephertz.app42.paas.sdk.csharp
{
	// Token: 0x02000014 RID: 20
	public class App42BadParameterException : App42Exception
	{
		// Token: 0x060000D5 RID: 213 RVA: 0x00004D9C File Offset: 0x00002F9C
		public App42BadParameterException(string message) : base(message)
		{
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00004DA5 File Offset: 0x00002FA5
		public App42BadParameterException(string message, int httpErrorCode, int appErrorCode) : base(message, httpErrorCode, appErrorCode)
		{
			this.httpErrorCode = httpErrorCode;
			this.appErrorCode = appErrorCode;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00004DBE File Offset: 0x00002FBE
		public new void SetHttpErrorCode(int httpErrorCode)
		{
			this.httpErrorCode = httpErrorCode;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00004DC7 File Offset: 0x00002FC7
		public new int GetHttpErrorCode()
		{
			return this.httpErrorCode;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00004DCF File Offset: 0x00002FCF
		public new void SetAppErrorCode(int appErrorCode)
		{
			this.appErrorCode = appErrorCode;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00004DD8 File Offset: 0x00002FD8
		public new int GetAppErrorCode()
		{
			return this.appErrorCode;
		}

		// Token: 0x04000048 RID: 72
		private int httpErrorCode;

		// Token: 0x04000049 RID: 73
		private int appErrorCode;
	}
}
