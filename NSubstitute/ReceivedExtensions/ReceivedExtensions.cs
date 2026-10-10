using System;
using NSubstitute.Core;
using NSubstitute.Exceptions;

namespace NSubstitute.ReceivedExtensions
{
	// Token: 0x02000044 RID: 68
	public static class ReceivedExtensions
	{
		// Token: 0x060000F5 RID: 245 RVA: 0x00004570 File Offset: 0x00002770
		public static T Received<T>(this T substitute, Quantity requiredQuantity)
		{
			if (substitute == null)
			{
				throw new NullSubstituteReferenceException();
			}
			ISubstitutionContext context = SubstitutionContext.Current;
			ICallRouter callRouterFor = context.GetCallRouterFor(substitute);
			context.ThreadContext.SetNextRoute(callRouterFor, (ISubstituteState x) => context.RouteFactory.CheckReceivedCalls(x, MatchArgs.AsSpecifiedInCall, requiredQuantity));
			return substitute;
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x000045D4 File Offset: 0x000027D4
		public static T ReceivedWithAnyArgs<T>(this T substitute, Quantity requiredQuantity)
		{
			if (substitute == null)
			{
				throw new NullSubstituteReferenceException();
			}
			ISubstitutionContext context = SubstitutionContext.Current;
			ICallRouter callRouterFor = context.GetCallRouterFor(substitute);
			context.ThreadContext.SetNextRoute(callRouterFor, (ISubstituteState x) => context.RouteFactory.CheckReceivedCalls(x, MatchArgs.Any, requiredQuantity));
			return substitute;
		}
	}
}
