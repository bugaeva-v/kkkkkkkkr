using System;
using System.Runtime.CompilerServices;

namespace NSubstitute.Exceptions
{
	// Token: 0x0200005F RID: 95
	public class SubstituteInternalException : SubstituteException
	{
		// Token: 0x06000133 RID: 307 RVA: 0x00004EC4 File Offset: 0x000030C4
		public SubstituteInternalException() : this("")
		{
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00004ED1 File Offset: 0x000030D1
		public SubstituteInternalException(string message) : this(message, null)
		{
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00004EDB File Offset: 0x000030DB
		public SubstituteInternalException(string message, [Nullable(2)] Exception innerException) : base("Please report this exception at https://github.com/nsubstitute/NSubstitute/issues: \n\n" + message, innerException)
		{
		}
	}
}
