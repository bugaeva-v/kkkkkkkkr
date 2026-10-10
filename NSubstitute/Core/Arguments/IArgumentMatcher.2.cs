using System;
using System.Runtime.CompilerServices;

namespace NSubstitute.Core.Arguments
{
	// Token: 0x020000D8 RID: 216
	public interface IArgumentMatcher<T>
	{
		// Token: 0x0600038F RID: 911
		[NullableContext(2)]
		bool IsSatisfiedBy(T argument);
	}
}
