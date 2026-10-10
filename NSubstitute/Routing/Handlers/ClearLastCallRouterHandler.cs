using System;
using NSubstitute.Core;

namespace NSubstitute.Routing.Handlers
{
	// Token: 0x02000020 RID: 32
	public class ClearLastCallRouterHandler : ICallHandler
	{
		// Token: 0x06000085 RID: 133 RVA: 0x00003387 File Offset: 0x00001587
		public ClearLastCallRouterHandler(IThreadLocalContext threadContext)
		{
			this._threadContext = threadContext;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00003396 File Offset: 0x00001596
		public RouteAction Handle(ICall call)
		{
			this._threadContext.ClearLastCallRouter();
			return RouteAction.Continue();
		}

		// Token: 0x04000025 RID: 37
		private readonly IThreadLocalContext _threadContext;
	}
}
