using System;
using System.Runtime.CompilerServices;

namespace NSubstitute.Core.Arguments
{
	// Token: 0x020000D7 RID: 215
	[NullableContext(2)]
	public interface IArgumentMatcher
	{
		// Token: 0x0600038E RID: 910
		bool IsSatisfiedBy(object argument);
	}
}
