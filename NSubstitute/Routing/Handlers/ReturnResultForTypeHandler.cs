using System;
using NSubstitute.Core;

namespace NSubstitute.Routing.Handlers
{
	// Token: 0x02000030 RID: 48
	public class ReturnResultForTypeHandler : ICallHandler
	{
		// Token: 0x060000AC RID: 172 RVA: 0x00003A8C File Offset: 0x00001C8C
		public ReturnResultForTypeHandler(IResultsForType resultsForType)
		{
			this._resultsForType = resultsForType;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00003A9C File Offset: 0x00001C9C
		public RouteAction Handle(ICall call)
		{
			object value;
			if (this._resultsForType.TryGetResult(call, out value))
			{
				return RouteAction.Return(value);
			}
			return RouteAction.Continue();
		}

		// Token: 0x04000042 RID: 66
		private readonly IResultsForType _resultsForType;
	}
}
