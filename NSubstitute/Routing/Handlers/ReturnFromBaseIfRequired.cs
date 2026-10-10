using System;
using NSubstitute.Core;

namespace NSubstitute.Routing.Handlers
{
	// Token: 0x0200002E RID: 46
	public class ReturnFromBaseIfRequired : ICallHandler
	{
		// Token: 0x060000A8 RID: 168 RVA: 0x000039A7 File Offset: 0x00001BA7
		public ReturnFromBaseIfRequired(ICallBaseConfiguration config)
		{
			this._config = config;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x000039B8 File Offset: 0x00001BB8
		public RouteAction Handle(ICall call)
		{
			if (this._config.ShouldCallBase(call))
			{
				return call.TryCallBase().Fold<RouteAction>(new Func<RouteAction>(RouteAction.Continue), new Func<object, RouteAction>(RouteAction.Return));
			}
			return RouteAction.Continue();
		}

		// Token: 0x04000040 RID: 64
		private readonly ICallBaseConfiguration _config;
	}
}
