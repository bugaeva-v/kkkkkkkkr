using System;
using System.Collections.Generic;
using System.Reflection;
using NSubstitute.Core.Arguments;

namespace NSubstitute.Core
{
	// Token: 0x0200007B RID: 123
	public interface IArgumentSpecificationDequeue
	{
		// Token: 0x060001D8 RID: 472
		[Obsolete("This method is deprecated and will be removed in future versions of product.")]
		IList<IArgumentSpecification> DequeueAllArgumentSpecificationsForMethod(MethodInfo methodInfo);

		// Token: 0x060001D9 RID: 473
		IList<IArgumentSpecification> DequeueAllArgumentSpecificationsForMethod(int parametersCount);
	}
}
