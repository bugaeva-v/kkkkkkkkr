using System;
using System.Collections.Generic;
using NSubstitute.ReceivedExtensions;

namespace NSubstitute.Core
{
	// Token: 0x02000098 RID: 152
	public interface IReceivedCallsExceptionThrower
	{
		// Token: 0x0600022F RID: 559
		void Throw(ICallSpecification callSpecification, IEnumerable<ICall> matchingCalls, IEnumerable<ICall> nonMatchingCalls, Quantity requiredQuantity);
	}
}
