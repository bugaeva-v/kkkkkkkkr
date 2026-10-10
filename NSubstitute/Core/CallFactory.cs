using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using NSubstitute.Core.Arguments;

namespace NSubstitute.Core
{
	// Token: 0x02000067 RID: 103
	public class CallFactory : ICallFactory
	{
		// Token: 0x0600016E RID: 366 RVA: 0x000055A0 File Offset: 0x000037A0
		public ICall Create(MethodInfo methodInfo, [Nullable(new byte[]
		{
			0,
			2
		})] object[] arguments, object target, IList<IArgumentSpecification> argumentSpecifications, [Nullable(new byte[]
		{
			2,
			0
		})] Func<object> baseMethod)
		{
			return new Call(methodInfo, arguments, target, argumentSpecifications, baseMethod);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x000055AE File Offset: 0x000037AE
		public ICall Create(MethodInfo methodInfo, [Nullable(new byte[]
		{
			0,
			2
		})] object[] arguments, object target, IList<IArgumentSpecification> argumentSpecifications)
		{
			return new Call(methodInfo, arguments, target, argumentSpecifications, null);
		}
	}
}
