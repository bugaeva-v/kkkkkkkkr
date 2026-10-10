using System;
using System.Runtime.CompilerServices;

namespace NSubstitute.Core
{
	// Token: 0x02000093 RID: 147
	public interface IPendingSpecification
	{
		// Token: 0x06000224 RID: 548
		bool HasPendingCallSpecInfo();

		// Token: 0x06000225 RID: 549
		[NullableContext(2)]
		PendingSpecificationInfo UseCallSpecInfo();

		// Token: 0x06000226 RID: 550
		void SetCallSpecification(ICallSpecification callSpecification);

		// Token: 0x06000227 RID: 551
		void SetLastCall(ICall lastCall);

		// Token: 0x06000228 RID: 552
		void Clear();
	}
}
