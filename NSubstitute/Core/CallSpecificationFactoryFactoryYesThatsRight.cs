using System;
using NSubstitute.Core.DependencyInjection;

namespace NSubstitute.Core
{
	// Token: 0x02000072 RID: 114
	public static class CallSpecificationFactoryFactoryYesThatsRight
	{
		// Token: 0x060001B1 RID: 433 RVA: 0x000060F3 File Offset: 0x000042F3
		[Obsolete("This factory is deprecated and will be removed in future versions of the product. Please use 'SubstitutionContext.Current.CallSpecificationFactory' instead. Use NSubstituteDefaultFactory services if you need to activate a new instance.")]
		public static ICallSpecificationFactory CreateCallSpecFactory()
		{
			return NSubstituteDefaultFactory.DefaultContainer.Resolve<ICallSpecificationFactory>();
		}
	}
}
