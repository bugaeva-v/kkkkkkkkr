using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using NSubstitute.Core.Arguments;
using NSubstitute.Routing;

namespace NSubstitute.Core
{
	// Token: 0x020000A4 RID: 164
	public interface IThreadLocalContext
	{
		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600026C RID: 620
		IPendingSpecification PendingSpecification { get; }

		// Token: 0x0600026D RID: 621
		void SetLastCallRouter(ICallRouter callRouter);

		// Token: 0x0600026E RID: 622
		void ClearLastCallRouter();

		// Token: 0x0600026F RID: 623
		ConfiguredCall LastCallShouldReturn(IReturn value, MatchArgs matchArgs);

		// Token: 0x06000270 RID: 624
		void SetNextRoute(ICallRouter callRouter, Func<ISubstituteState, IRoute> nextRouteFactory);

		// Token: 0x06000271 RID: 625
		[return: Nullable(new byte[]
		{
			2,
			0,
			0
		})]
		Func<ISubstituteState, IRoute> UseNextRoute(ICallRouter callRouter);

		// Token: 0x06000272 RID: 626
		void EnqueueArgumentSpecification(IArgumentSpecification spec);

		// Token: 0x06000273 RID: 627
		IList<IArgumentSpecification> DequeueAllArgumentSpecifications();

		// Token: 0x06000274 RID: 628
		void SetPendingRaisingEventArgumentsFactory([Nullable(new byte[]
		{
			0,
			0,
			0,
			2
		})] Func<ICall, object[]> getArguments);

		// Token: 0x06000275 RID: 629
		[return: Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		Func<ICall, object[]> UsePendingRaisingEventArgumentsFactory();

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000276 RID: 630
		bool IsQuerying { get; }

		// Token: 0x06000277 RID: 631
		void RunInQueryContext(Action calls, IQuery query);

		// Token: 0x06000278 RID: 632
		void RegisterInContextQuery(ICall call);
	}
}
