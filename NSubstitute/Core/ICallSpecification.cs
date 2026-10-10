using System;
using System.Collections.Generic;
using System.Reflection;
using NSubstitute.Core.Arguments;

namespace NSubstitute.Core
{
	// Token: 0x02000088 RID: 136
	public interface ICallSpecification
	{
		// Token: 0x06000206 RID: 518
		bool IsSatisfiedBy(ICall call);

		// Token: 0x06000207 RID: 519
		string Format(ICall call);

		// Token: 0x06000208 RID: 520
		ICallSpecification CreateCopyThatMatchesAnyArguments();

		// Token: 0x06000209 RID: 521
		void InvokePerArgumentActions(CallInfo callInfo);

		// Token: 0x0600020A RID: 522
		IEnumerable<ArgumentMatchInfo> NonMatchingArguments(ICall call);

		// Token: 0x0600020B RID: 523
		MethodInfo GetMethodInfo();

		// Token: 0x0600020C RID: 524
		Type ReturnType();
	}
}
