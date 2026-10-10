using System;
using NSubstitute.Routing;

namespace NSubstitute.Core
{
	// Token: 0x0200006D RID: 109
	public class CallRouterFactory : ICallRouterFactory
	{
		// Token: 0x06000196 RID: 406 RVA: 0x00005CBA File Offset: 0x00003EBA
		public CallRouterFactory(IThreadLocalContext threadLocalContext, IRouteFactory routeFactory)
		{
			this._threadLocalContext = threadLocalContext;
			this._routeFactory = routeFactory;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00005CD0 File Offset: 0x00003ED0
		public ICallRouter Create(ISubstituteState substituteState, bool canConfigureBaseCalls)
		{
			RouteFactoryCacheWrapper routeFactory = new RouteFactoryCacheWrapper(this._routeFactory);
			return new CallRouter(substituteState, this._threadLocalContext, routeFactory, canConfigureBaseCalls);
		}

		// Token: 0x04000087 RID: 135
		private readonly IThreadLocalContext _threadLocalContext;

		// Token: 0x04000088 RID: 136
		private readonly IRouteFactory _routeFactory;
	}
}
