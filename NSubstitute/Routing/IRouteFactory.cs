using System;
using System.Runtime.CompilerServices;
using NSubstitute.Core;
using NSubstitute.ReceivedExtensions;

namespace NSubstitute.Routing
{
	// Token: 0x0200001A RID: 26
	public interface IRouteFactory
	{
		// Token: 0x0600006A RID: 106
		IRoute CallQuery(ISubstituteState state);

		// Token: 0x0600006B RID: 107
		IRoute CheckReceivedCalls(ISubstituteState state, MatchArgs matchArgs, Quantity requiredQuantity);

		// Token: 0x0600006C RID: 108
		IRoute DoWhenCalled(ISubstituteState state, Action<CallInfo> doAction, MatchArgs matchArgs);

		// Token: 0x0600006D RID: 109
		IRoute DoNotCallBase(ISubstituteState state, MatchArgs matchArgs);

		// Token: 0x0600006E RID: 110
		IRoute CallBase(ISubstituteState state, MatchArgs matchArgs);

		// Token: 0x0600006F RID: 111
		IRoute RaiseEvent(ISubstituteState state, [Nullable(new byte[]
		{
			0,
			0,
			0,
			2
		})] Func<ICall, object[]> getEventArguments);

		// Token: 0x06000070 RID: 112
		IRoute RecordCallSpecification(ISubstituteState state);

		// Token: 0x06000071 RID: 113
		IRoute RecordReplay(ISubstituteState state);
	}
}
