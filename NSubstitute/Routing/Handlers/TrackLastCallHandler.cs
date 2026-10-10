using System;
using NSubstitute.Core;

namespace NSubstitute.Routing.Handlers
{
	// Token: 0x02000032 RID: 50
	public class TrackLastCallHandler : ICallHandler
	{
		// Token: 0x060000B0 RID: 176 RVA: 0x00003B23 File Offset: 0x00001D23
		public TrackLastCallHandler(IPendingSpecification pendingSpecification)
		{
			this._pendingSpecification = pendingSpecification;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00003B32 File Offset: 0x00001D32
		public RouteAction Handle(ICall call)
		{
			this._pendingSpecification.SetLastCall(call);
			return RouteAction.Continue();
		}

		// Token: 0x04000047 RID: 71
		private readonly IPendingSpecification _pendingSpecification;
	}
}
