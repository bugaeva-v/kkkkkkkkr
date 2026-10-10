using System;
using System.Collections.Generic;
using NSubstitute.Core.Arguments;
using NSubstitute.Proxies.CastleDynamicProxy;
using NSubstitute.Routing;
using NSubstitute.Routing.AutoValues;

namespace NSubstitute.Core.DependencyInjection
{
	// Token: 0x020000C9 RID: 201
	public static class NSubstituteDefaultFactory
	{
		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600034E RID: 846 RVA: 0x000086F4 File Offset: 0x000068F4
		public static INSubContainer DefaultContainer { get; } = NSubstituteDefaultFactory.CreateDefaultContainer();

		// Token: 0x0600034F RID: 847 RVA: 0x000086FB File Offset: 0x000068FB
		public static ISubstitutionContext CreateSubstitutionContext()
		{
			return NSubstituteDefaultFactory.DefaultContainer.Resolve<ISubstitutionContext>();
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00008708 File Offset: 0x00006908
		private static INSubContainer CreateDefaultContainer()
		{
			return new NSubContainer().RegisterSingleton<SequenceNumberGenerator, SequenceNumberGenerator>().RegisterPerScope<IThreadLocalContext, ThreadLocalContext>().RegisterPerScope((INSubResolver r) => new ArgumentSpecificationDequeue(new Func<IList<IArgumentSpecification>>(r.Resolve<IThreadLocalContext>().DequeueAllArgumentSpecifications))).RegisterPerScope<ICallSpecificationFactory, CallSpecificationFactory>().RegisterPerScope<IArgumentSpecificationFactory, ArgumentSpecificationFactory>().RegisterPerScope<IArgumentSpecificationsFactory, ArgumentSpecificationsFactory>().RegisterPerScope<ISuppliedArgumentSpecificationsFactory, SuppliedArgumentSpecificationsFactory>().RegisterPerScope<IArgumentSpecificationCompatibilityTester, ArgumentSpecificationCompatibilityTester>().RegisterPerScope<IDefaultChecker, DefaultChecker>().RegisterPerScope<IDefaultForType, DefaultForType>().RegisterPerScope<IRouteFactory, RouteFactory>().RegisterPerScope<ICallInfoFactory, CallInfoFactory>().RegisterPerScope<IAutoValueProvidersFactory, AutoValueProvidersFactory>().RegisterPerScope<ISubstituteStateFactory, SubstituteStateFactory>().RegisterPerScope<ICallRouterFactory, CallRouterFactory>().RegisterPerScope<ISubstituteFactory, SubstituteFactory>().RegisterPerScope<ICallRouterResolver, CallRouterResolver>().RegisterPerScope<ISubstitutionContext, SubstitutionContext>().RegisterPerScope<IProxyFactory, CastleDynamicProxyFactory>().RegisterPerScope<ICallFactory, CallFactory>().RegisterPerScope<IPropertyHelper, PropertyHelper>().RegisterSingleton<IReceivedCallsExceptionThrower, ReceivedCallsExceptionThrower>();
		}
	}
}
