using System;
using System.Collections.Generic;
using NSubstitute.Routing.AutoValues;

namespace NSubstitute.Core
{
	// Token: 0x020000B9 RID: 185
	public class SubstituteStateFactory : ISubstituteStateFactory
	{
		// Token: 0x060002E3 RID: 739 RVA: 0x000077A7 File Offset: 0x000059A7
		public SubstituteStateFactory(ICallSpecificationFactory callSpecificationFactory, ICallInfoFactory callInfoFactory, IAutoValueProvidersFactory autoValueProvidersFactory)
		{
			this._callSpecificationFactory = callSpecificationFactory;
			this._callInfoFactory = callInfoFactory;
			this._autoValueProvidersFactory = autoValueProvidersFactory;
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x000077C4 File Offset: 0x000059C4
		public ISubstituteState Create(ISubstituteFactory substituteFactory)
		{
			IReadOnlyCollection<IAutoValueProvider> autoValueProviders = this._autoValueProvidersFactory.CreateProviders(substituteFactory);
			return new SubstituteState(this._callSpecificationFactory, this._callInfoFactory, autoValueProviders);
		}

		// Token: 0x040000CC RID: 204
		private readonly ICallSpecificationFactory _callSpecificationFactory;

		// Token: 0x040000CD RID: 205
		private readonly ICallInfoFactory _callInfoFactory;

		// Token: 0x040000CE RID: 206
		private readonly IAutoValueProvidersFactory _autoValueProvidersFactory;
	}
}
