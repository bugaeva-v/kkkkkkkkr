using System;
using System.Collections.Generic;

namespace NSubstitute.Core
{
	// Token: 0x02000097 RID: 151
	public interface IQueryResults
	{
		// Token: 0x0600022D RID: 557
		IEnumerable<ICall> MatchingCallsInOrder();

		// Token: 0x0600022E RID: 558
		IEnumerable<CallSpecAndTarget> QuerySpecification();
	}
}
