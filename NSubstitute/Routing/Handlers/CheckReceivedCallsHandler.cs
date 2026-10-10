using System;
using System.Collections.Generic;
using System.Linq;
using NSubstitute.Core;
using NSubstitute.ReceivedExtensions;

namespace NSubstitute.Routing.Handlers
{
	// Token: 0x0200001F RID: 31
	public class CheckReceivedCallsHandler : ICallHandler
	{
		// Token: 0x06000083 RID: 131 RVA: 0x000032BB File Offset: 0x000014BB
		public CheckReceivedCallsHandler(ICallCollection receivedCalls, ICallSpecificationFactory callSpecificationFactory, IReceivedCallsExceptionThrower exceptionThrower, MatchArgs matchArgs, Quantity requiredQuantity)
		{
			this._receivedCalls = receivedCalls;
			this._callSpecificationFactory = callSpecificationFactory;
			this._exceptionThrower = exceptionThrower;
			this._matchArgs = matchArgs;
			this._requiredQuantity = requiredQuantity;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000032E8 File Offset: 0x000014E8
		public RouteAction Handle(ICall call)
		{
			ICallSpecification callSpecification = this._callSpecificationFactory.CreateFrom(call, this._matchArgs);
			ICallSpecification @object = this._callSpecificationFactory.CreateFrom(call, MatchArgs.Any);
			List<ICall> source = this._receivedCalls.AllCalls().ToList<ICall>();
			List<ICall> list = source.Where(new Func<ICall, bool>(callSpecification.IsSatisfiedBy)).ToList<ICall>();
			if (!this._requiredQuantity.Matches<ICall>(list))
			{
				IEnumerable<ICall> nonMatchingCalls = source.Where(new Func<ICall, bool>(@object.IsSatisfiedBy)).Except(list);
				this._exceptionThrower.Throw(callSpecification, list, nonMatchingCalls, this._requiredQuantity);
			}
			return RouteAction.Continue();
		}

		// Token: 0x04000020 RID: 32
		private readonly ICallCollection _receivedCalls;

		// Token: 0x04000021 RID: 33
		private readonly ICallSpecificationFactory _callSpecificationFactory;

		// Token: 0x04000022 RID: 34
		private readonly IReceivedCallsExceptionThrower _exceptionThrower;

		// Token: 0x04000023 RID: 35
		private readonly MatchArgs _matchArgs;

		// Token: 0x04000024 RID: 36
		private readonly Quantity _requiredQuantity;
	}
}
