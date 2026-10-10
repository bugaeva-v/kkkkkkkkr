using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using NSubstitute.Core.Arguments;

namespace NSubstitute.Core
{
	// Token: 0x02000080 RID: 128
	public interface ICallFactory
	{
		// Token: 0x060001F3 RID: 499
		ICall Create(MethodInfo methodInfo, [Nullable(new byte[]
		{
			0,
			2
		})] object[] arguments, object target, IList<IArgumentSpecification> argumentSpecifications, [Nullable(new byte[]
		{
			2,
			0
		})] Func<object> baseMethod);

		// Token: 0x060001F4 RID: 500
		ICall Create(MethodInfo methodInfo, [Nullable(new byte[]
		{
			0,
			2
		})] object[] getterArgs, object target, IList<IArgumentSpecification> getArgumentSpecifications);
	}
}
