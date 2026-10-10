using System;
using System.Runtime.CompilerServices;

namespace NSubstitute.Core
{
	// Token: 0x02000083 RID: 131
	public interface ICallResults
	{
		// Token: 0x060001F7 RID: 503
		void SetResult(ICallSpecification callSpecification, IReturn result);

		// Token: 0x060001F8 RID: 504
		bool TryGetResult(ICall call, [Nullable(2)] out object result);

		// Token: 0x060001F9 RID: 505
		void Clear();
	}
}
