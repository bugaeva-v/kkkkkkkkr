using System;

namespace Firebase
{
	// Token: 0x02000004 RID: 4
	public sealed class FirebaseException : Exception
	{
		// Token: 0x06000014 RID: 20 RVA: 0x00002264 File Offset: 0x00000464
		public FirebaseException()
		{
			this.ErrorCode = 0;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002276 File Offset: 0x00000476
		public FirebaseException(int errorCode)
		{
			this.ErrorCode = errorCode;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002288 File Offset: 0x00000488
		public FirebaseException(int errorCode, string message) : base(message)
		{
			this.ErrorCode = errorCode;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x0000229B File Offset: 0x0000049B
		public FirebaseException(int errorCode, string message, Exception inner) : base(message, inner)
		{
			this.ErrorCode = errorCode;
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000018 RID: 24 RVA: 0x000022AF File Offset: 0x000004AF
		// (set) Token: 0x06000019 RID: 25 RVA: 0x000022B7 File Offset: 0x000004B7
		public int ErrorCode { get; private set; }
	}
}
