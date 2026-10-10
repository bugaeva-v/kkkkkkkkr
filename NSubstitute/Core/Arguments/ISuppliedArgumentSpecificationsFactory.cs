using System;
using System.Collections.Generic;

namespace NSubstitute.Core.Arguments
{
	// Token: 0x020000DF RID: 223
	public interface ISuppliedArgumentSpecificationsFactory
	{
		// Token: 0x0600039F RID: 927
		ISuppliedArgumentSpecifications Create(IEnumerable<IArgumentSpecification> argumentSpecifications);
	}
}
