using System;
using System.Runtime.CompilerServices;

namespace NSubstitute.Core.Arguments
{
	// Token: 0x020000D6 RID: 214
	public interface IArgumentFormatter
	{
		// Token: 0x0600038D RID: 909
		string Format([Nullable(2)] object arg, bool highlight);
	}
}
