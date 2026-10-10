using System;

namespace NSubstitute.Core
{
	// Token: 0x02000089 RID: 137
	public interface ICallSpecificationFactory
	{
		// Token: 0x0600020D RID: 525
		ICallSpecification CreateFrom(ICall call, MatchArgs matchArgs);
	}
}
