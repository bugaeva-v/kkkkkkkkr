using System;
using System.Collections.Generic;
using NSubstitute.Core;

namespace NSubstitute.Routing.AutoValues
{
	// Token: 0x0200003B RID: 59
	public interface IAutoValueProvidersFactory
	{
		// Token: 0x060000D2 RID: 210
		IReadOnlyCollection<IAutoValueProvider> CreateProviders(ISubstituteFactory substituteFactory);
	}
}
