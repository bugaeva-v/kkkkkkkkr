using System;
using NSubstitute.Core;

namespace NSubstitute.Routing.Handlers
{
	// Token: 0x02000021 RID: 33
	public class ClearUnusedCallSpecHandler : ICallHandler
	{
		// Token: 0x06000087 RID: 135 RVA: 0x000033A8 File Offset: 0x000015A8
		public ClearUnusedCallSpecHandler(IPendingSpecification pendingSpecification)
		{
			this._pendingSpecification = pendingSpecification;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000033B7 File Offset: 0x000015B7
		public RouteAction Handle(ICall call)
		{
			this._pendingSpecification.Clear();
			return RouteAction.Continue();
		}

		// Token: 0x04000026 RID: 38
		private readonly IPendingSpecification _pendingSpecification;
	}
}
