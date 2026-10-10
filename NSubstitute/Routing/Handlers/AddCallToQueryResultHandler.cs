using System;
using NSubstitute.Core;

namespace NSubstitute.Routing.Handlers
{
	// Token: 0x0200001D RID: 29
	public class AddCallToQueryResultHandler : ICallHandler
	{
		// Token: 0x0600007F RID: 127 RVA: 0x0000323A File Offset: 0x0000143A
		public AddCallToQueryResultHandler(IThreadLocalContext threadContext)
		{
			this._threadContext = threadContext;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00003249 File Offset: 0x00001449
		public RouteAction Handle(ICall call)
		{
			this._threadContext.RegisterInContextQuery(call);
			return RouteAction.Continue();
		}

		// Token: 0x0400001C RID: 28
		private readonly IThreadLocalContext _threadContext;
	}
}
