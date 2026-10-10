using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using NSubstitute.Routing;

namespace NSubstitute.Core
{
	// Token: 0x02000084 RID: 132
	public interface ICallRouter
	{
		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060001FA RID: 506
		// (set) Token: 0x060001FB RID: 507
		bool CallBaseByDefault { get; set; }

		// Token: 0x060001FC RID: 508
		ConfiguredCall LastCallShouldReturn(IReturn returnValue, MatchArgs matchArgs, PendingSpecificationInfo pendingSpecInfo);

		// Token: 0x060001FD RID: 509
		[return: Nullable(2)]
		object Route(ICall call);

		// Token: 0x060001FE RID: 510
		IEnumerable<ICall> ReceivedCalls();

		// Token: 0x060001FF RID: 511
		[Obsolete("This method is deprecated and will be removed in future versions of the product. Please use IThreadLocalContext.SetNextRoute method instead.")]
		void SetRoute(Func<ISubstituteState, IRoute> getRoute);

		// Token: 0x06000200 RID: 512
		void SetReturnForType(Type type, IReturn returnValue);

		// Token: 0x06000201 RID: 513
		void RegisterCustomCallHandlerFactory(CallHandlerFactory factory);

		// Token: 0x06000202 RID: 514
		void Clear(ClearOptions clear);
	}
}
