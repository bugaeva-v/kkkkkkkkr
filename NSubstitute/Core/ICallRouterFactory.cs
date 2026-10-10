using System;

namespace NSubstitute.Core
{
	// Token: 0x02000085 RID: 133
	public interface ICallRouterFactory
	{
		// Token: 0x06000203 RID: 515
		ICallRouter Create(ISubstituteState substituteState, bool canConfigureBaseCalls);
	}
}
