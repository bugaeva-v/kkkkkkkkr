using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace NSubstitute.Core.Arguments
{
	// Token: 0x020000DE RID: 222
	public interface ISuppliedArgumentSpecifications
	{
		// Token: 0x0600039B RID: 923
		bool AnyFor([Nullable(2)] object argument, Type argumentType);

		// Token: 0x0600039C RID: 924
		bool IsNextFor([Nullable(2)] object argument, Type argumentType);

		// Token: 0x0600039D RID: 925
		IArgumentSpecification Dequeue();

		// Token: 0x0600039E RID: 926
		IEnumerable<IArgumentSpecification> DequeueRemaining();
	}
}
