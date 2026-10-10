using System;
using System.Collections.Generic;
using System.Reflection;
using NSubstitute.Core.Arguments;

namespace NSubstitute.Core
{
	// Token: 0x02000071 RID: 113
	public class CallSpecificationFactory : ICallSpecificationFactory
	{
		// Token: 0x060001AF RID: 431 RVA: 0x000060A0 File Offset: 0x000042A0
		public CallSpecificationFactory(IArgumentSpecificationsFactory argumentSpecificationsFactory)
		{
			this._argumentSpecificationsFactory = argumentSpecificationsFactory;
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x000060B0 File Offset: 0x000042B0
		public ICallSpecification CreateFrom(ICall call, MatchArgs matchArgs)
		{
			MethodInfo methodInfo = call.GetMethodInfo();
			IList<IArgumentSpecification> argumentSpecifications = call.GetArgumentSpecifications();
			object[] originalArguments = call.GetOriginalArguments();
			IParameterInfo[] parameterInfos = call.GetParameterInfos();
			IEnumerable<IArgumentSpecification> argumentSpecifications2 = this._argumentSpecificationsFactory.Create(argumentSpecifications, originalArguments, parameterInfos, methodInfo, matchArgs);
			return new CallSpecification(methodInfo, argumentSpecifications2);
		}

		// Token: 0x0400008D RID: 141
		private readonly IArgumentSpecificationsFactory _argumentSpecificationsFactory;
	}
}
