using System;
using NSubstitute.Core;

namespace NSubstitute.Routing.Handlers
{
	// Token: 0x02000022 RID: 34
	public class DoActionsCallHandler : ICallHandler
	{
		// Token: 0x06000089 RID: 137 RVA: 0x000033C9 File Offset: 0x000015C9
		public DoActionsCallHandler(ICallActions callActions)
		{
			this._callActions = callActions;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x000033D8 File Offset: 0x000015D8
		public RouteAction Handle(ICall call)
		{
			this._callActions.InvokeMatchingActions(call);
			return RouteAction.Continue();
		}

		// Token: 0x04000027 RID: 39
		private readonly ICallActions _callActions;
	}
}
