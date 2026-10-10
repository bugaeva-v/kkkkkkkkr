using System;

namespace NSubstitute.Exceptions
{
	// Token: 0x02000055 RID: 85
	public class CouldNotSetReturnDueToNoLastCallException : CouldNotSetReturnException
	{
		// Token: 0x06000121 RID: 289 RVA: 0x00004BAF File Offset: 0x00002DAF
		public CouldNotSetReturnDueToNoLastCallException() : base("Could not find a call to return from.")
		{
		}
	}
}
