using System;
using System.Collections.Generic;
using System.Threading;
using NSubstitute.Core;
using NSubstitute.Exceptions;

namespace NSubstitute.Routing.AutoValues
{
	// Token: 0x02000039 RID: 57
	public class AutoValueProvidersFactory : IAutoValueProvidersFactory
	{
		// Token: 0x060000CE RID: 206 RVA: 0x00003F58 File Offset: 0x00002158
		public IReadOnlyCollection<IAutoValueProvider> CreateProviders(ISubstituteFactory substituteFactory)
		{
			IAutoValueProvider[] result = null;
			Lazy<IReadOnlyCollection<IAutoValueProvider>> autoValueProviders = new Lazy<IReadOnlyCollection<IAutoValueProvider>>(delegate()
			{
				IAutoValueProvider[] result = result;
				if (result == null)
				{
					throw new SubstituteInternalException("Value was not constructed yet.");
				}
				return result;
			}, LazyThreadSafetyMode.PublicationOnly);
			result = new IAutoValueProvider[]
			{
				new AutoObservableProvider(autoValueProviders),
				new AutoQueryableProvider(),
				new AutoSubstituteProvider(substituteFactory),
				new AutoStringProvider(),
				new AutoArrayProvider(),
				new AutoTaskProvider(autoValueProviders)
			};
			return result;
		}
	}
}
