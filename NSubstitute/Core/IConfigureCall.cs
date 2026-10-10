using System;

namespace NSubstitute.Core
{
	// Token: 0x0200008A RID: 138
	public interface IConfigureCall
	{
		// Token: 0x0600020E RID: 526
		ConfiguredCall SetResultForLastCall(IReturn valueToReturn, MatchArgs matchArgs, PendingSpecificationInfo pendingSpecInfo);

		// Token: 0x0600020F RID: 527
		void SetResultForCall(ICall call, IReturn valueToReturn, MatchArgs matchArgs);
	}
}
