using System;
using System.Runtime.CompilerServices;

namespace NSubstitute.Core.Arguments
{
	// Token: 0x020000DB RID: 219
	public interface IArgumentSpecificationFactory
	{
		// Token: 0x06000398 RID: 920
		IArgumentSpecification Create([Nullable(2)] object argument, IParameterInfo parameterInfo, ISuppliedArgumentSpecifications suppliedArgumentSpecifications);
	}
}
