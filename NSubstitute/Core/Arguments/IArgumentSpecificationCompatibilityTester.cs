using System;
using System.Runtime.CompilerServices;

namespace NSubstitute.Core.Arguments
{
	// Token: 0x020000DA RID: 218
	public interface IArgumentSpecificationCompatibilityTester
	{
		// Token: 0x06000397 RID: 919
		bool IsSpecificationCompatible(IArgumentSpecification specification, [Nullable(2)] object argumentValue, Type argumentType);
	}
}
