using System;
using NSubstitute.Core;

namespace NSubstitute.Routing.Handlers
{
	// Token: 0x02000031 RID: 49
	public class SetActionForCallHandler : ICallHandler
	{
		// Token: 0x060000AE RID: 174 RVA: 0x00003AC5 File Offset: 0x00001CC5
		public SetActionForCallHandler(ICallSpecificationFactory callSpecificationFactory, ICallActions callActions, Action<CallInfo> action, MatchArgs matchArgs)
		{
			this._callSpecificationFactory = callSpecificationFactory;
			this._callActions = callActions;
			this._action = action;
			this._matchArgs = matchArgs;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00003AEC File Offset: 0x00001CEC
		public RouteAction Handle(ICall call)
		{
			ICallSpecification callSpecification = this._callSpecificationFactory.CreateFrom(call, this._matchArgs);
			this._callActions.Add(callSpecification, this._action);
			return RouteAction.Continue();
		}

		// Token: 0x04000043 RID: 67
		private readonly ICallSpecificationFactory _callSpecificationFactory;

		// Token: 0x04000044 RID: 68
		private readonly ICallActions _callActions;

		// Token: 0x04000045 RID: 69
		private readonly Action<CallInfo> _action;

		// Token: 0x04000046 RID: 70
		private readonly MatchArgs _matchArgs;
	}
}
