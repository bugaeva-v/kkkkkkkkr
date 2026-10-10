using System;
using NSubstitute.Core;

namespace NSubstitute.Routing.Handlers
{
	// Token: 0x0200002B RID: 43
	public class ReturnConfiguredResultHandler : ICallHandler
	{
		// Token: 0x060000A0 RID: 160 RVA: 0x000038AE File Offset: 0x00001AAE
		public ReturnConfiguredResultHandler(ICallResults callResults)
		{
			this._callResults = callResults;
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x000038C0 File Offset: 0x00001AC0
		public RouteAction Handle(ICall call)
		{
			object value;
			if (this._callResults.TryGetResult(call, out value))
			{
				return RouteAction.Return(value);
			}
			return RouteAction.Continue();
		}

		// Token: 0x0400003C RID: 60
		private readonly ICallResults _callResults;
	}
}
