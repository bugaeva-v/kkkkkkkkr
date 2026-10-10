using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using NSubstitute.Core.Arguments;
using NSubstitute.Core.DependencyInjection;
using NSubstitute.Routing;

namespace NSubstitute.Core
{
	// Token: 0x020000BA RID: 186
	public class SubstitutionContext : ISubstitutionContext
	{
		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060002E5 RID: 741 RVA: 0x000077F0 File Offset: 0x000059F0
		// (set) Token: 0x060002E6 RID: 742 RVA: 0x000077F7 File Offset: 0x000059F7
		public static ISubstitutionContext Current { get; set; } = NSubstituteDefaultFactory.CreateSubstitutionContext();

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060002E7 RID: 743 RVA: 0x000077FF File Offset: 0x000059FF
		public ISubstituteFactory SubstituteFactory { get; }

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060002E8 RID: 744 RVA: 0x00007807 File Offset: 0x00005A07
		public IRouteFactory RouteFactory { get; }

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060002E9 RID: 745 RVA: 0x0000780F File Offset: 0x00005A0F
		public IThreadLocalContext ThreadContext { get; }

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060002EA RID: 746 RVA: 0x00007817 File Offset: 0x00005A17
		public ICallSpecificationFactory CallSpecificationFactory { get; }

		// Token: 0x060002EC RID: 748 RVA: 0x0000782B File Offset: 0x00005A2B
		public SubstitutionContext(ISubstituteFactory substituteFactory, IRouteFactory routeFactory, ICallSpecificationFactory callSpecificationFactory, IThreadLocalContext threadLocalContext, ICallRouterResolver callRouterResolver, SequenceNumberGenerator sequenceNumberGenerator)
		{
			this.SubstituteFactory = substituteFactory;
			this.RouteFactory = routeFactory;
			this.CallSpecificationFactory = callSpecificationFactory;
			this.ThreadContext = threadLocalContext;
			this._callRouterResolver = callRouterResolver;
			this.SequenceNumberGenerator = sequenceNumberGenerator;
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00007860 File Offset: 0x00005A60
		public ICallRouter GetCallRouterFor(object substitute)
		{
			return this._callRouterResolver.ResolveFor(substitute);
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060002EE RID: 750 RVA: 0x0000786E File Offset: 0x00005A6E
		[Obsolete("This property is obsolete and will be removed in a future version of the product.")]
		public SequenceNumberGenerator SequenceNumberGenerator { get; }

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060002EF RID: 751 RVA: 0x00007876 File Offset: 0x00005A76
		[Obsolete("This property is obsolete and will be removed in a future version of the product. Use the ThreadContext.IsQuerying property instead. For example: SubstitutionContext.Current.ThreadContext.IsQuerying.")]
		public bool IsQuerying
		{
			get
			{
				return this.ThreadContext.IsQuerying;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060002F0 RID: 752 RVA: 0x00007884 File Offset: 0x00005A84
		// (set) Token: 0x060002F1 RID: 753 RVA: 0x000078C0 File Offset: 0x00005AC0
		[Nullable(2)]
		[Obsolete("This property is obsolete and will be removed in a future version of the product. Use the ThreadContext.PendingSpecification property instead. For example: SubstitutionContext.Current.ThreadContext.PendingSpecification.")]
		public PendingSpecificationInfo PendingSpecificationInfo
		{
			[NullableContext(2)]
			get
			{
				if (!this.ThreadContext.PendingSpecification.HasPendingCallSpecInfo())
				{
					return null;
				}
				PendingSpecificationInfo pendingSpecificationInfo = this.ThreadContext.PendingSpecification.UseCallSpecInfo();
				this.PendingSpecificationInfo = pendingSpecificationInfo;
				return pendingSpecificationInfo;
			}
			[NullableContext(2)]
			set
			{
				if (value == null)
				{
					this.ThreadContext.PendingSpecification.Clear();
					return;
				}
				Tuple<ICallSpecification, ICall> tuple = value.Handle<Tuple<ICallSpecification, ICall>>((ICallSpecification spec) => Tuple.Create<ICallSpecification, ICall>(spec, null), (ICall call) => Tuple.Create<ICallSpecification, ICall>(null, call));
				if (tuple.Item1 != null)
				{
					this.ThreadContext.PendingSpecification.SetCallSpecification(tuple.Item1);
					return;
				}
				this.ThreadContext.PendingSpecification.SetLastCall(tuple.Item2);
			}
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x0000795B File Offset: 0x00005B5B
		[Obsolete("This method is obsolete and will be removed in a future version of the product. Use the ThreadContext.LastCallShouldReturn() method instead. For example: SubstitutionContext.Current.ThreadContext.LastCallShouldReturn(...).")]
		public ConfiguredCall LastCallShouldReturn(IReturn value, MatchArgs matchArgs)
		{
			return this.ThreadContext.LastCallShouldReturn(value, matchArgs);
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x0000796A File Offset: 0x00005B6A
		[Obsolete("This method is obsolete and will be removed in a future version of the product. Use the ThreadContext.ClearLastCallRouter() method instead. For example: SubstitutionContext.Current.ThreadContext.ClearLastCallRouter().")]
		public void ClearLastCallRouter()
		{
			this.ThreadContext.ClearLastCallRouter();
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00007977 File Offset: 0x00005B77
		[Obsolete("This method is obsolete and will be removed in a future version of the product. Use the RouteFactory property instead.")]
		public IRouteFactory GetRouteFactory()
		{
			return this.RouteFactory;
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x0000797F File Offset: 0x00005B7F
		[Obsolete("This method is obsolete and will be removed in a future version of the product. Use the ThreadContext.SetLastCallRouter() method instead. For example: SubstitutionContext.Current.ThreadContext.SetLastCallRouter(...).")]
		public void LastCallRouter(ICallRouter callRouter)
		{
			this.ThreadContext.SetLastCallRouter(callRouter);
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x0000798D File Offset: 0x00005B8D
		[Obsolete("This method is obsolete and will be removed in a future version of the product. Use the ThreadContext.EnqueueArgumentSpecification() method instead. For example: SubstitutionContext.Current.ThreadContext.EnqueueArgumentSpecification(...).")]
		public void EnqueueArgumentSpecification(IArgumentSpecification spec)
		{
			this.ThreadContext.EnqueueArgumentSpecification(spec);
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x0000799B File Offset: 0x00005B9B
		[Obsolete("This method is obsolete and will be removed in a future version of the product. Use the ThreadContext.DequeueAllArgumentSpecifications() method instead. For example: SubstitutionContext.Current.ThreadContext.DequeueAllArgumentSpecifications().")]
		public IList<IArgumentSpecification> DequeueAllArgumentSpecifications()
		{
			return this.ThreadContext.DequeueAllArgumentSpecifications();
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x000079A8 File Offset: 0x00005BA8
		[Obsolete("This method is obsolete and will be removed in a future version of the product. Use the ThreadContext.SetPendingRaisingEventArgumentsFactory() method instead. For example: SubstitutionContext.Current.ThreadContext.SetPendingRaisingEventArgumentsFactory(...).")]
		public void RaiseEventForNextCall(Func<ICall, object[]> getArguments)
		{
			this.ThreadContext.SetPendingRaisingEventArgumentsFactory(getArguments);
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x000079B6 File Offset: 0x00005BB6
		[Obsolete("This method is obsolete and will be removed in a future version of the product. Use the ThreadContext.UsePendingRaisingEventArgumentsFactory() method instead. For example: SubstitutionContext.Current.ThreadContext.UsePendingRaisingEventArgumentsFactory().")]
		[return: Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		public Func<ICall, object[]> DequeuePendingRaisingEventArguments()
		{
			return this.ThreadContext.UsePendingRaisingEventArgumentsFactory();
		}

		// Token: 0x060002FA RID: 762 RVA: 0x000079C3 File Offset: 0x00005BC3
		[Obsolete("This method is obsolete and will be removed in a future version of the product. Use the ThreadContext.RegisterInContextQuery() method instead. For example: SubstitutionContext.Current.ThreadContext.RegisterInContextQuery().", true)]
		public void AddToQuery(object target, ICallSpecification callSpecification)
		{
			throw new NotSupportedException("This API was obsolete and is not supported anymore. Please use the ThreadContext.RegisterInContextQuery() method instead. For example: SubstitutionContext.Current.ThreadContext.RegisterInContextQuery().");
		}

		// Token: 0x060002FB RID: 763 RVA: 0x000079D0 File Offset: 0x00005BD0
		[Obsolete("This method is obsolete and will be removed in a future version of the product. Use the ThreadContext.RunInQueryContext() method instead. For example: SubstitutionContext.Current.ThreadContext.RunInQueryContext(...).")]
		public IQueryResults RunQuery(Action calls)
		{
			Query query = new Query(this.CallSpecificationFactory);
			this.ThreadContext.RunInQueryContext(calls, query);
			return query.Result();
		}

		// Token: 0x040000D0 RID: 208
		private readonly ICallRouterResolver _callRouterResolver;
	}
}
