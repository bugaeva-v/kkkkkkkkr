using System;

namespace NSubstitute.Exceptions
{
	// Token: 0x02000059 RID: 89
	public class NotASubstituteException : SubstituteException
	{
		// Token: 0x06000126 RID: 294 RVA: 0x00004C5B File Offset: 0x00002E5B
		public NotASubstituteException() : base("NSubstitute extension methods like .Received() can only be called on objects created using Substitute.For<T>() and related methods.")
		{
		}

		// Token: 0x04000065 RID: 101
		private const string Explanation = "NSubstitute extension methods like .Received() can only be called on objects created using Substitute.For<T>() and related methods.";
	}
}
