using System;
using System.Collections.Generic;
using System.Reflection;

namespace NSubstitute.Core
{
	// Token: 0x02000091 RID: 145
	public interface IMethodInfoFormatter
	{
		// Token: 0x0600021E RID: 542
		bool CanFormat(MethodInfo methodInfo);

		// Token: 0x0600021F RID: 543
		string Format(MethodInfo methodInfo, IEnumerable<string> formattedArguments);
	}
}
