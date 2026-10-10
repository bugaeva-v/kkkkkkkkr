using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using NSubstitute.Core.Arguments;
using NSubstitute.Exceptions;
using NSubstitute.Routing;

namespace NSubstitute.Core
{
	// Token: 0x020000BB RID: 187
	public class ThreadLocalContext : IThreadLocalContext
	{
		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060002FC RID: 764 RVA: 0x000079FC File Offset: 0x00005BFC
		public IPendingSpecification PendingSpecification { get; }

		// Token: 0x060002FD RID: 765 RVA: 0x00007A04 File Offset: 0x00005C04
		public ThreadLocalContext()
		{
			this._lastCallRouter = new RobustThreadLocal<ICallRouter>();
			this._argumentSpecifications = new RobustThreadLocal<IList<IArgumentSpecification>>(() => new List<IArgumentSpecification>());
			this._getArgumentsForRaisingEvent = new RobustThreadLocal<Func<ICall, object[]>>();
			this._currentQuery = new RobustThreadLocal<IQuery>();
			this._pendingSpecificationInfo = new RobustThreadLocal<ThreadLocalContext.PendingSpecInfoData>();
			this._nextRouteFactory = new RobustThreadLocal<Tuple<ICallRouter, Func<ISubstituteState, IRoute>>>();
			this.PendingSpecification = new ThreadLocalContext.PendingSpecificationWrapper(this._pendingSpecificationInfo);
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00007A89 File Offset: 0x00005C89
		public void SetLastCallRouter(ICallRouter callRouter)
		{
			this._lastCallRouter.Value = callRouter;
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00007A98 File Offset: 0x00005C98
		public ConfiguredCall LastCallShouldReturn(IReturn value, MatchArgs matchArgs)
		{
			ICallRouter value2 = this._lastCallRouter.Value;
			if (value2 == null)
			{
				throw new CouldNotSetReturnDueToNoLastCallException();
			}
			if (!this.PendingSpecification.HasPendingCallSpecInfo())
			{
				throw new CouldNotSetReturnDueToMissingInfoAboutLastCallException();
			}
			if (this._argumentSpecifications.Value.Count > 0)
			{
				this._argumentSpecifications.Value.Clear();
				throw new UnexpectedArgumentMatcherException();
			}
			PendingSpecificationInfo pendingSpecInfo = this.PendingSpecification.UseCallSpecInfo();
			ConfiguredCall result = value2.LastCallShouldReturn(value, matchArgs, pendingSpecInfo);
			this.ClearLastCallRouter();
			return result;
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00007B0F File Offset: 0x00005D0F
		public void SetNextRoute(ICallRouter callRouter, Func<ISubstituteState, IRoute> nextRouteFactory)
		{
			this._nextRouteFactory.Value = Tuple.Create<ICallRouter, Func<ISubstituteState, IRoute>>(callRouter, nextRouteFactory);
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00007B24 File Offset: 0x00005D24
		[return: Nullable(new byte[]
		{
			2,
			0,
			0
		})]
		public Func<ISubstituteState, IRoute> UseNextRoute(ICallRouter callRouter)
		{
			Tuple<ICallRouter, Func<ISubstituteState, IRoute>> value = this._nextRouteFactory.Value;
			if (value != null && callRouter == value.Item1)
			{
				this._nextRouteFactory.Value = null;
				return value.Item2;
			}
			return null;
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00007B5D File Offset: 0x00005D5D
		public void ClearLastCallRouter()
		{
			this._lastCallRouter.Value = null;
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00007B6B File Offset: 0x00005D6B
		public void EnqueueArgumentSpecification(IArgumentSpecification spec)
		{
			IList<IArgumentSpecification> value = this._argumentSpecifications.Value;
			if (value == null)
			{
				throw new SubstituteInternalException("Argument specification queue is null.");
			}
			value.Add(spec);
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00007B8C File Offset: 0x00005D8C
		public IList<IArgumentSpecification> DequeueAllArgumentSpecifications()
		{
			IList<IArgumentSpecification> list = this._argumentSpecifications.Value;
			if (list == null)
			{
				throw new SubstituteInternalException("Argument specification queue is null.");
			}
			if (list.Count == 0)
			{
				list = ThreadLocalContext.EmptySpecifications;
			}
			else
			{
				this._argumentSpecifications.Value = new List<IArgumentSpecification>();
			}
			return list;
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00007BD4 File Offset: 0x00005DD4
		public void SetPendingRaisingEventArgumentsFactory([Nullable(new byte[]
		{
			0,
			0,
			0,
			2
		})] Func<ICall, object[]> getArguments)
		{
			this._getArgumentsForRaisingEvent.Value = getArguments;
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00007BE2 File Offset: 0x00005DE2
		[return: Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		public Func<ICall, object[]> UsePendingRaisingEventArgumentsFactory()
		{
			Func<ICall, object[]> value = this._getArgumentsForRaisingEvent.Value;
			if (value != null)
			{
				this._getArgumentsForRaisingEvent.Value = null;
			}
			return value;
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00007C00 File Offset: 0x00005E00
		public void RunInQueryContext(Action calls, IQuery query)
		{
			this._currentQuery.Value = query;
			try
			{
				calls();
			}
			finally
			{
				this._currentQuery.Value = null;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000308 RID: 776 RVA: 0x00007C40 File Offset: 0x00005E40
		public bool IsQuerying
		{
			get
			{
				return this._currentQuery.Value != null;
			}
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00007C50 File Offset: 0x00005E50
		public void RegisterInContextQuery(ICall call)
		{
			IQuery value = this._currentQuery.Value;
			if (value == null)
			{
				throw new NotRunningAQueryException();
			}
			value.RegisterCall(call);
		}

		// Token: 0x040000D6 RID: 214
		private static readonly IArgumentSpecification[] EmptySpecifications = new IArgumentSpecification[0];

		// Token: 0x040000D7 RID: 215
		[Nullable(new byte[]
		{
			0,
			2
		})]
		private readonly RobustThreadLocal<ICallRouter> _lastCallRouter;

		// Token: 0x040000D8 RID: 216
		private readonly RobustThreadLocal<IList<IArgumentSpecification>> _argumentSpecifications;

		// Token: 0x040000D9 RID: 217
		[Nullable(new byte[]
		{
			0,
			2,
			0,
			0,
			2
		})]
		private readonly RobustThreadLocal<Func<ICall, object[]>> _getArgumentsForRaisingEvent;

		// Token: 0x040000DA RID: 218
		[Nullable(new byte[]
		{
			0,
			2
		})]
		private readonly RobustThreadLocal<IQuery> _currentQuery;

		// Token: 0x040000DB RID: 219
		private readonly RobustThreadLocal<ThreadLocalContext.PendingSpecInfoData> _pendingSpecificationInfo;

		// Token: 0x040000DC RID: 220
		[Nullable(new byte[]
		{
			0,
			2,
			0,
			0,
			0,
			0
		})]
		private readonly RobustThreadLocal<Tuple<ICallRouter, Func<ISubstituteState, IRoute>>> _nextRouteFactory;

		// Token: 0x02000134 RID: 308
		private class PendingSpecificationWrapper : IPendingSpecification
		{
			// Token: 0x060004B7 RID: 1207 RVA: 0x0000A242 File Offset: 0x00008442
			public PendingSpecificationWrapper(RobustThreadLocal<ThreadLocalContext.PendingSpecInfoData> valueHolder)
			{
				this._valueHolder = valueHolder;
			}

			// Token: 0x060004B8 RID: 1208 RVA: 0x0000A254 File Offset: 0x00008454
			public bool HasPendingCallSpecInfo()
			{
				return this._valueHolder.Value.HasValue;
			}

			// Token: 0x060004B9 RID: 1209 RVA: 0x0000A274 File Offset: 0x00008474
			[NullableContext(2)]
			public PendingSpecificationInfo UseCallSpecInfo()
			{
				ThreadLocalContext.PendingSpecInfoData value = this._valueHolder.Value;
				this.Clear();
				return value.ToPendingSpecificationInfo();
			}

			// Token: 0x060004BA RID: 1210 RVA: 0x0000A29A File Offset: 0x0000849A
			public void SetCallSpecification(ICallSpecification callSpecification)
			{
				this._valueHolder.Value = ThreadLocalContext.PendingSpecInfoData.FromCallSpecification(callSpecification);
			}

			// Token: 0x060004BB RID: 1211 RVA: 0x0000A2AD File Offset: 0x000084AD
			public void SetLastCall(ICall lastCall)
			{
				this._valueHolder.Value = ThreadLocalContext.PendingSpecInfoData.FromLastCall(lastCall);
			}

			// Token: 0x060004BC RID: 1212 RVA: 0x0000A2C0 File Offset: 0x000084C0
			public void Clear()
			{
				this._valueHolder.Value = default(ThreadLocalContext.PendingSpecInfoData);
			}

			// Token: 0x04000189 RID: 393
			private readonly RobustThreadLocal<ThreadLocalContext.PendingSpecInfoData> _valueHolder;
		}

		// Token: 0x02000135 RID: 309
		[NullableContext(2)]
		[Nullable(0)]
		private readonly struct PendingSpecInfoData
		{
			// Token: 0x17000068 RID: 104
			// (get) Token: 0x060004BD RID: 1213 RVA: 0x0000A2E1 File Offset: 0x000084E1
			public bool HasValue
			{
				get
				{
					return this._lastCall != null || this._callSpecification != null;
				}
			}

			// Token: 0x060004BE RID: 1214 RVA: 0x0000A2F6 File Offset: 0x000084F6
			private PendingSpecInfoData(ICallSpecification callSpecification, ICall lastCall)
			{
				this._callSpecification = callSpecification;
				this._lastCall = lastCall;
			}

			// Token: 0x060004BF RID: 1215 RVA: 0x0000A306 File Offset: 0x00008506
			public PendingSpecificationInfo ToPendingSpecificationInfo()
			{
				if (this._callSpecification != null)
				{
					return PendingSpecificationInfo.FromCallSpecification(this._callSpecification);
				}
				if (this._lastCall != null)
				{
					return PendingSpecificationInfo.FromLastCall(this._lastCall);
				}
				return null;
			}

			// Token: 0x060004C0 RID: 1216 RVA: 0x0000A331 File Offset: 0x00008531
			[NullableContext(0)]
			public static ThreadLocalContext.PendingSpecInfoData FromLastCall(ICall lastCall)
			{
				return new ThreadLocalContext.PendingSpecInfoData(null, lastCall);
			}

			// Token: 0x060004C1 RID: 1217 RVA: 0x0000A33A File Offset: 0x0000853A
			[NullableContext(0)]
			public static ThreadLocalContext.PendingSpecInfoData FromCallSpecification(ICallSpecification callSpecification)
			{
				return new ThreadLocalContext.PendingSpecInfoData(callSpecification, null);
			}

			// Token: 0x0400018A RID: 394
			private readonly ICallSpecification _callSpecification;

			// Token: 0x0400018B RID: 395
			private readonly ICall _lastCall;
		}
	}
}
