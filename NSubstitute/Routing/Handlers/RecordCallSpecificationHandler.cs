using System;
using System.Linq;
using NSubstitute.Core;
using NSubstitute.Core.Arguments;

namespace NSubstitute.Routing.Handlers
{
	// Token: 0x02000028 RID: 40
	public class RecordCallSpecificationHandler : ICallHandler
	{
		// Token: 0x0600009B RID: 155 RVA: 0x00003755 File Offset: 0x00001955
		public RecordCallSpecificationHandler(IPendingSpecification pendingCallSpecification, ICallSpecificationFactory callSpecificationFactory, ICallActions callActions)
		{
			this._pendingCallSpecification = pendingCallSpecification;
			this._callSpecificationFactory = callSpecificationFactory;
			this._callActions = callActions;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00003774 File Offset: 0x00001974
		public RouteAction Handle(ICall call)
		{
			ICallSpecification callSpecification = this._callSpecificationFactory.CreateFrom(call, MatchArgs.AsSpecifiedInCall);
			this._pendingCallSpecification.SetCallSpecification(callSpecification);
			if (call.GetArgumentSpecifications().Any((IArgumentSpecification x) => x.HasAction))
			{
				this._callActions.Add(callSpecification);
			}
			return RouteAction.Continue();
		}

		// Token: 0x04000032 RID: 50
		private readonly IPendingSpecification _pendingCallSpecification;

		// Token: 0x04000033 RID: 51
		private readonly ICallSpecificationFactory _callSpecificationFactory;

		// Token: 0x04000034 RID: 52
		private readonly ICallActions _callActions;
	}
}
