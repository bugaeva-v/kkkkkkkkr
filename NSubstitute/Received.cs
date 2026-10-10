using System;
using NSubstitute.Core;
using NSubstitute.Core.SequenceChecking;

namespace NSubstitute
{
	// Token: 0x02000016 RID: 22
	public class Received
	{
		// Token: 0x0600003F RID: 63 RVA: 0x00002740 File Offset: 0x00000940
		public static void InOrder(Action calls)
		{
			Query query = new Query(SubstitutionContext.Current.CallSpecificationFactory);
			SubstitutionContext.Current.ThreadContext.RunInQueryContext(calls, query);
			new SequenceInOrderAssertion().Assert(query.Result());
		}
	}
}
