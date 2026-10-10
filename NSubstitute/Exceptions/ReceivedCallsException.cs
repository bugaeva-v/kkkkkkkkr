using System;

namespace NSubstitute.Exceptions
{
	// Token: 0x0200005C RID: 92
	public class ReceivedCallsException : SubstituteException
	{
		// Token: 0x06000129 RID: 297 RVA: 0x00004C7D File Offset: 0x00002E7D
		public ReceivedCallsException()
		{
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00004C85 File Offset: 0x00002E85
		public ReceivedCallsException(string message) : base(message)
		{
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00004C8E File Offset: 0x00002E8E
		public ReceivedCallsException(string message, Exception innerException) : base(message, innerException)
		{
		}
	}
}
