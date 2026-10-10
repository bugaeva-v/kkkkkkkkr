using System;
using System.Runtime.CompilerServices;

namespace NSubstitute.Exceptions
{
	// Token: 0x0200005E RID: 94
	public class SubstituteException : Exception
	{
		// Token: 0x06000130 RID: 304 RVA: 0x00004EA3 File Offset: 0x000030A3
		public SubstituteException() : this("")
		{
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00004EB0 File Offset: 0x000030B0
		public SubstituteException(string message) : this(message, null)
		{
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00004EBA File Offset: 0x000030BA
		public SubstituteException(string message, [Nullable(2)] Exception innerException) : base(message, innerException)
		{
		}
	}
}
