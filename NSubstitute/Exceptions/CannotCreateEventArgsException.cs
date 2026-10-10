using System;

namespace NSubstitute.Exceptions
{
	// Token: 0x0200004F RID: 79
	public class CannotCreateEventArgsException : SubstituteException
	{
		// Token: 0x06000116 RID: 278 RVA: 0x00004B1B File Offset: 0x00002D1B
		public CannotCreateEventArgsException()
		{
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00004B23 File Offset: 0x00002D23
		public CannotCreateEventArgsException(string message) : base(message)
		{
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00004B2C File Offset: 0x00002D2C
		public CannotCreateEventArgsException(string message, Exception innerException) : base(message, innerException)
		{
		}
	}
}
