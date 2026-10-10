using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using NSubstitute.Core.Arguments;
using NSubstitute.Routing;

namespace NSubstitute.Core
{
	// Token: 0x020000A3 RID: 163
	public interface ISubstitutionContext
	{
		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000259 RID: 601
		ISubstituteFactory SubstituteFactory { get; }

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600025A RID: 602
		IRouteFactory RouteFactory { get; }

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600025B RID: 603
		ICallSpecificationFactory CallSpecificationFactory { get; }

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600025C RID: 604
		IThreadLocalContext ThreadContext { get; }

		// Token: 0x0600025D RID: 605
		ICallRouter GetCallRouterFor(object substitute);

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600025E RID: 606
		[Obsolete("This property is obsolete and will be removed in a future version of the product.")]
		SequenceNumberGenerator SequenceNumberGenerator { get; }

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600025F RID: 607
		// (set) Token: 0x06000260 RID: 608
		[Nullable(2)]
		[Obsolete("This property is obsolete and will be removed in a future version of the product. Use the ThreadContext.PendingSpecification property instead. For example: SubstitutionContext.Current.ThreadContext.PendingSpecification.")]
		PendingSpecificationInfo PendingSpecificationInfo { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x06000261 RID: 609
		[Obsolete("This method is obsolete and will be removed in a future version of the product. Use the ThreadContext.LastCallShouldReturn() method instead. For example: SubstitutionContext.Current.ThreadContext.LastCallShouldReturn(...).")]
		ConfiguredCall LastCallShouldReturn(IReturn value, MatchArgs matchArgs);

		// Token: 0x06000262 RID: 610
		[Obsolete("This method is obsolete and will be removed in a future version of the product. Use the ThreadContext.SetLastCallRouter() method instead. For example: SubstitutionContext.Current.ThreadContext.SetLastCallRouter(...).")]
		void LastCallRouter(ICallRouter callRouter);

		// Token: 0x06000263 RID: 611
		[Obsolete("This method is obsolete and will be removed in a future version of the product. Use the ThreadContext.EnqueueArgumentSpecification() method instead. For example: SubstitutionContext.Current.ThreadContext.EnqueueArgumentSpecification(...).")]
		void EnqueueArgumentSpecification(IArgumentSpecification spec);

		// Token: 0x06000264 RID: 612
		[Obsolete("This method is obsolete and will be removed in a future version of the product. Use the ThreadContext.DequeueAllArgumentSpecifications() method instead. For example: SubstitutionContext.Current.ThreadContext.DequeueAllArgumentSpecifications().")]
		IList<IArgumentSpecification> DequeueAllArgumentSpecifications();

		// Token: 0x06000265 RID: 613
		[Obsolete("This method is obsolete and will be removed in a future version of the product. Use the ThreadContext.SetPendingRaisingEventArgumentsFactory() method instead. For example: SubstitutionContext.Current.ThreadContext.SetPendingRaisingEventArgumentsFactory(...).")]
		void RaiseEventForNextCall(Func<ICall, object[]> getArguments);

		// Token: 0x06000266 RID: 614
		[Obsolete("This method is obsolete and will be removed in a future version of the product. Use the ThreadContext.UsePendingRaisingEventArgumentsFactory() method instead. For example: SubstitutionContext.Current.ThreadContext.UsePendingRaisingEventArgumentsFactory().")]
		[return: Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		Func<ICall, object[]> DequeuePendingRaisingEventArguments();

		// Token: 0x06000267 RID: 615
		[Obsolete("This method is obsolete and will be removed in a future version of the product. Use the ThreadContext.RunInQueryContext() method instead. For example: SubstitutionContext.Current.ThreadContext.RunInQueryContext(...).")]
		IQueryResults RunQuery(Action calls);

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000268 RID: 616
		[Obsolete("This property is obsolete and will be removed in a future version of the product. Use the ThreadContext.IsQuerying property instead. For example: SubstitutionContext.Current.ThreadContext.IsQuerying.")]
		bool IsQuerying { get; }

		// Token: 0x06000269 RID: 617
		[Obsolete("This method is obsolete and will be removed in a future version of the product. Use the ThreadContext.RegisterInContextQuery() method instead. For example: SubstitutionContext.Current.ThreadContext.RegisterInContextQuery().", true)]
		void AddToQuery(object target, ICallSpecification callSpecification);

		// Token: 0x0600026A RID: 618
		[Obsolete("This method is obsolete and will be removed in a future version of the product. Use the ThreadContext.ClearLastCallRouter() method instead. For example: SubstitutionContext.Current.ThreadContext.ClearLastCallRouter().")]
		void ClearLastCallRouter();

		// Token: 0x0600026B RID: 619
		[Obsolete("This method is obsolete and will be removed in a future version of the product. Use the RouteFactory property instead.")]
		IRouteFactory GetRouteFactory();
	}
}
