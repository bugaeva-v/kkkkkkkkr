using System;
using NSubstitute.Core;

namespace NSubstitute.Routing.Handlers
{
	// Token: 0x0200002F RID: 47
	public class ReturnFromCustomHandlers : ICallHandler
	{
		// Token: 0x060000AA RID: 170 RVA: 0x000039FF File Offset: 0x00001BFF
		public ReturnFromCustomHandlers(ICustomHandlers customHandlers)
		{
			this._customHandlers = customHandlers;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00003A10 File Offset: 0x00001C10
		public RouteAction Handle(ICall call)
		{
			if (this._customHandlers.Handlers.Count == 0)
			{
				return RouteAction.Continue();
			}
			foreach (ICallHandler callHandler in this._customHandlers.Handlers)
			{
				RouteAction routeAction = callHandler.Handle(call);
				if (routeAction.HasReturnValue)
				{
					return routeAction;
				}
			}
			return RouteAction.Continue();
		}

		// Token: 0x04000041 RID: 65
		private readonly ICustomHandlers _customHandlers;
	}
}
