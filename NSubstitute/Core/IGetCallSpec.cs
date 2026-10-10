using System;

namespace NSubstitute.Core
{
	// Token: 0x02000090 RID: 144
	public interface IGetCallSpec
	{
		// Token: 0x0600021B RID: 539
		ICallSpecification FromPendingSpecification(MatchArgs matchArgs, PendingSpecificationInfo pendingSpecInfo);

		// Token: 0x0600021C RID: 540
		ICallSpecification FromExistingSpec(ICallSpecification spec, MatchArgs matchArgs);

		// Token: 0x0600021D RID: 541
		ICallSpecification FromCall(ICall call, MatchArgs matchArgs);
	}
}
