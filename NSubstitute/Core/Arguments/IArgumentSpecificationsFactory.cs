using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace NSubstitute.Core.Arguments
{
	// Token: 0x020000DC RID: 220
	public interface IArgumentSpecificationsFactory
	{
		// Token: 0x06000399 RID: 921
		IEnumerable<IArgumentSpecification> Create(IList<IArgumentSpecification> argumentSpecs, [Nullable(new byte[]
		{
			0,
			2
		})] object[] arguments, IParameterInfo[] parameterInfos, MethodInfo methodInfo, MatchArgs matchArgs);
	}
}
