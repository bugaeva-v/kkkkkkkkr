using System;
using NSubstitute.Core;
using NSubstitute.Exceptions;

namespace NSubstitute.Routing.Handlers
{
	// Token: 0x0200001E RID: 30
	public class CallBaseForCallHandler : ICallHandler
	{
		// Token: 0x06000081 RID: 129 RVA: 0x0000325C File Offset: 0x0000145C
		public CallBaseForCallHandler(ICallSpecificationFactory callSpecificationFactory, ICallBaseConfiguration callBaseConfig, MatchArgs matchArgs)
		{
			this._callSpecificationFactory = callSpecificationFactory;
			this._callBaseConfig = callBaseConfig;
			this._matchArgs = matchArgs;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000327C File Offset: 0x0000147C
		public RouteAction Handle(ICall call)
		{
			if (!call.CanCallBase)
			{
				throw CouldNotConfigureCallBaseException.ForSingleCall();
			}
			ICallSpecification callSpecification = this._callSpecificationFactory.CreateFrom(call, this._matchArgs);
			this._callBaseConfig.Include(callSpecification);
			return RouteAction.Continue();
		}

		// Token: 0x0400001D RID: 29
		private readonly ICallSpecificationFactory _callSpecificationFactory;

		// Token: 0x0400001E RID: 30
		private readonly ICallBaseConfiguration _callBaseConfig;

		// Token: 0x0400001F RID: 31
		private readonly MatchArgs _matchArgs;
	}
}
