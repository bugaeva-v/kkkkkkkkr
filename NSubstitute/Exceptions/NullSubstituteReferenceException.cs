using System;

namespace NSubstitute.Exceptions
{
	// Token: 0x0200005B RID: 91
	public class NullSubstituteReferenceException : SubstituteException
	{
		// Token: 0x06000128 RID: 296 RVA: 0x00004C70 File Offset: 0x00002E70
		public NullSubstituteReferenceException() : base("NSubstitute extension methods like .Received() can only be called on non-null objects.")
		{
		}

		// Token: 0x04000066 RID: 102
		private const string Explanation = "NSubstitute extension methods like .Received() can only be called on non-null objects.";
	}
}
