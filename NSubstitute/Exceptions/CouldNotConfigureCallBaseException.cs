using System;

namespace NSubstitute.Exceptions
{
	// Token: 0x02000052 RID: 82
	public class CouldNotConfigureCallBaseException : SubstituteException
	{
		// Token: 0x0600011C RID: 284 RVA: 0x00004B6E File Offset: 0x00002D6E
		internal static CouldNotConfigureCallBaseException ForSingleCall()
		{
			return new CouldNotConfigureCallBaseException("Cannot configure the base method call as base method implementation is missing. You can call base method only if you create a class substitute and the method is not abstract.");
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00004B7A File Offset: 0x00002D7A
		internal static CouldNotConfigureCallBaseException ForAllCalls()
		{
			return new CouldNotConfigureCallBaseException("Base method calls can be configured for a class substitute only, as otherwise base implementation does not exist.");
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00004B86 File Offset: 0x00002D86
		public CouldNotConfigureCallBaseException(string message) : base(message)
		{
		}

		// Token: 0x04000061 RID: 97
		private const string CannotConfigureSingleCallMessage = "Cannot configure the base method call as base method implementation is missing. You can call base method only if you create a class substitute and the method is not abstract.";

		// Token: 0x04000062 RID: 98
		private const string CannotConfigureAllCallsMessage = "Base method calls can be configured for a class substitute only, as otherwise base implementation does not exist.";
	}
}
