using System;

namespace Unity.Services.Core
{
	// Token: 0x0200000C RID: 12
	public class RequestFailedException : Exception
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000026 RID: 38 RVA: 0x0000223C File Offset: 0x0000043C
		public int ErrorCode { get; }

		// Token: 0x06000027 RID: 39 RVA: 0x00002244 File Offset: 0x00000444
		public RequestFailedException(int errorCode, string message) : this(errorCode, message, null)
		{
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000224F File Offset: 0x0000044F
		public RequestFailedException(int errorCode, string message, Exception innerException) : base(message, innerException)
		{
			this.ErrorCode = errorCode;
		}
	}
}
