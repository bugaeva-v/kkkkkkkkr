using System;
using NSubstitute.Core;
using NSubstitute.Exceptions;

namespace NSubstitute.Routing.Handlers
{
	// Token: 0x02000023 RID: 35
	public class DoNotCallBaseForCallHandler : ICallHandler
	{
		// Token: 0x0600008B RID: 139 RVA: 0x000033EB File Offset: 0x000015EB
		public DoNotCallBaseForCallHandler(ICallSpecificationFactory callSpecificationFactory, ICallBaseConfiguration callBaseConfig, MatchArgs matchArgs)
		{
			this._callSpecificationFactory = callSpecificationFactory;
			this._callBaseConfig = callBaseConfig;
			this._matchArgs = matchArgs;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00003408 File Offset: 0x00001608
		public RouteAction Handle(ICall call)
		{
			if (!call.CanCallBase)
			{
				throw CouldNotConfigureCallBaseException.ForSingleCall();
			}
			ICallSpecification callSpecification = this._callSpecificationFactory.CreateFrom(call, this._matchArgs);
			this._callBaseConfig.Exclude(callSpecification);
			return RouteAction.Continue();
		}

		// Token: 0x04000028 RID: 40
		private readonly ICallSpecificationFactory _callSpecificationFactory;

		// Token: 0x04000029 RID: 41
		private readonly ICallBaseConfiguration _callBaseConfig;

		// Token: 0x0400002A RID: 42
		private readonly MatchArgs _matchArgs;
	}
}
