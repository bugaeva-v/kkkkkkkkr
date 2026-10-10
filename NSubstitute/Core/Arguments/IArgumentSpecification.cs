using System;
using System.Runtime.CompilerServices;

namespace NSubstitute.Core.Arguments
{
	// Token: 0x020000D9 RID: 217
	public interface IArgumentSpecification
	{
		// Token: 0x06000390 RID: 912
		[NullableContext(2)]
		bool IsSatisfiedBy(object argument);

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000391 RID: 913
		Type ForType { get; }

		// Token: 0x06000392 RID: 914
		IArgumentSpecification CreateCopyMatchingAnyArgOfType(Type requiredType);

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000393 RID: 915
		bool HasAction { get; }

		// Token: 0x06000394 RID: 916
		[NullableContext(2)]
		void RunAction(object argument);

		// Token: 0x06000395 RID: 917
		string DescribeNonMatch([Nullable(2)] object argument);

		// Token: 0x06000396 RID: 918
		string FormatArgument([Nullable(2)] object argument);
	}
}
