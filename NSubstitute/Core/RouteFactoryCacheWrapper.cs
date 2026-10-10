using System;
using System.Runtime.CompilerServices;
using NSubstitute.ReceivedExtensions;
using NSubstitute.Routing;

namespace NSubstitute.Core
{
	// Token: 0x020000B5 RID: 181
	public class RouteFactoryCacheWrapper : IRouteFactory
	{
		// Token: 0x060002C7 RID: 711 RVA: 0x00007458 File Offset: 0x00005658
		public RouteFactoryCacheWrapper(IRouteFactory factory)
		{
			this._factory = factory;
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00007467 File Offset: 0x00005667
		public IRoute RecordReplay(ISubstituteState state)
		{
			if (this._recordReplayCache.State != state)
			{
				this._recordReplayCache = new RouteFactoryCacheWrapper.CachedRoute(this._factory.RecordReplay(state), state);
			}
			return this._recordReplayCache.Route;
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x0000749A File Offset: 0x0000569A
		public IRoute RecordCallSpecification(ISubstituteState state)
		{
			if (this._recordCallSpecificationCache.State != state)
			{
				this._recordCallSpecificationCache = new RouteFactoryCacheWrapper.CachedRoute(this._factory.RecordCallSpecification(state), state);
			}
			return this._recordCallSpecificationCache.Route;
		}

		// Token: 0x060002CA RID: 714 RVA: 0x000074CD File Offset: 0x000056CD
		public IRoute CallQuery(ISubstituteState state)
		{
			return this._factory.CallQuery(state);
		}

		// Token: 0x060002CB RID: 715 RVA: 0x000074DB File Offset: 0x000056DB
		public IRoute CheckReceivedCalls(ISubstituteState state, MatchArgs matchArgs, Quantity requiredQuantity)
		{
			return this._factory.CheckReceivedCalls(state, matchArgs, requiredQuantity);
		}

		// Token: 0x060002CC RID: 716 RVA: 0x000074EB File Offset: 0x000056EB
		public IRoute DoWhenCalled(ISubstituteState state, Action<CallInfo> doAction, MatchArgs matchArgs)
		{
			return this._factory.DoWhenCalled(state, doAction, matchArgs);
		}

		// Token: 0x060002CD RID: 717 RVA: 0x000074FB File Offset: 0x000056FB
		public IRoute DoNotCallBase(ISubstituteState state, MatchArgs matchArgs)
		{
			return this._factory.DoNotCallBase(state, matchArgs);
		}

		// Token: 0x060002CE RID: 718 RVA: 0x0000750A File Offset: 0x0000570A
		public IRoute CallBase(ISubstituteState state, MatchArgs matchArgs)
		{
			return this._factory.CallBase(state, matchArgs);
		}

		// Token: 0x060002CF RID: 719 RVA: 0x00007519 File Offset: 0x00005719
		public IRoute RaiseEvent(ISubstituteState state, [Nullable(new byte[]
		{
			0,
			0,
			0,
			2
		})] Func<ICall, object[]> getEventArguments)
		{
			return this._factory.RaiseEvent(state, getEventArguments);
		}

		// Token: 0x040000BB RID: 187
		private readonly IRouteFactory _factory;

		// Token: 0x040000BC RID: 188
		private RouteFactoryCacheWrapper.CachedRoute _recordReplayCache;

		// Token: 0x040000BD RID: 189
		private RouteFactoryCacheWrapper.CachedRoute _recordCallSpecificationCache;

		// Token: 0x02000130 RID: 304
		private readonly struct CachedRoute
		{
			// Token: 0x060004AC RID: 1196 RVA: 0x0000A1CD File Offset: 0x000083CD
			public CachedRoute(IRoute route, ISubstituteState state)
			{
				this.Route = route;
				this.State = state;
			}

			// Token: 0x04000180 RID: 384
			public readonly IRoute Route;

			// Token: 0x04000181 RID: 385
			public readonly ISubstituteState State;
		}
	}
}
