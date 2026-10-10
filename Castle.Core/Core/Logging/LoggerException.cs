using System;
using System.Runtime.Serialization;

namespace Castle.Core.Logging
{
	// Token: 0x020000D6 RID: 214
	[Serializable]
	public class LoggerException : Exception
	{
		// Token: 0x0600059E RID: 1438 RVA: 0x000114A8 File Offset: 0x0000F6A8
		public LoggerException()
		{
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x000114B0 File Offset: 0x0000F6B0
		public LoggerException(string message) : base(message)
		{
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x000114B9 File Offset: 0x0000F6B9
		public LoggerException(string message, Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x000114C3 File Offset: 0x0000F6C3
		protected LoggerException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
