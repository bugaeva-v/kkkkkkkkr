using System;

namespace com.shephertz.app42.paas.sdk.csharp
{
	// Token: 0x02000013 RID: 19
	public class App42Exception : SystemException
	{
		// Token: 0x060000CD RID: 205 RVA: 0x00004D42 File Offset: 0x00002F42
		public App42Exception(string message) : base(message)
		{
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00004D4B File Offset: 0x00002F4B
		public App42Exception(string message, int httpErrorCode, int appErrorCode) : base(message)
		{
			this.httpErrorCode = httpErrorCode;
			this.appErrorCode = appErrorCode;
			this.message = message;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00004D69 File Offset: 0x00002F69
		public void SetHttpErrorCode(int httpErrorCode)
		{
			this.httpErrorCode = httpErrorCode;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00004D72 File Offset: 0x00002F72
		public int GetHttpErrorCode()
		{
			return this.httpErrorCode;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00004D7A File Offset: 0x00002F7A
		public void SetAppErrorCode(int appErrorCode)
		{
			this.appErrorCode = appErrorCode;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00004D83 File Offset: 0x00002F83
		public int GetAppErrorCode()
		{
			return this.appErrorCode;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00004D8B File Offset: 0x00002F8B
		public void SetMessage(string message)
		{
			this.message = message;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00004D94 File Offset: 0x00002F94
		public string GetMessage()
		{
			return this.message;
		}

		// Token: 0x04000045 RID: 69
		private int httpErrorCode;

		// Token: 0x04000046 RID: 70
		private int appErrorCode;

		// Token: 0x04000047 RID: 71
		private string message;
	}
}
