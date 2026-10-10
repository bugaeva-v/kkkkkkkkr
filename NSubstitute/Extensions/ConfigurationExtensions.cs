using System;
using NSubstitute.Core;
using NSubstitute.Exceptions;
using NSubstitute.Routing;

namespace NSubstitute.Extensions
{
	// Token: 0x02000047 RID: 71
	public static class ConfigurationExtensions
	{
		// Token: 0x06000105 RID: 261 RVA: 0x00004790 File Offset: 0x00002990
		public static T Configure<T>(this T substitute) where T : class
		{
			if (substitute == null)
			{
				throw new NullSubstituteReferenceException();
			}
			ISubstitutionContext substitutionContext = SubstitutionContext.Current;
			ICallRouter callRouterFor = substitutionContext.GetCallRouterFor(substitute);
			substitutionContext.ThreadContext.SetNextRoute(callRouterFor, new Func<ISubstituteState, IRoute>(substitutionContext.RouteFactory.RecordCallSpecification));
			return substitute;
		}
	}
}
