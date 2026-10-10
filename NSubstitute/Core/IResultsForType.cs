using System;
using System.Runtime.CompilerServices;

namespace NSubstitute.Core
{
	// Token: 0x02000099 RID: 153
	public interface IResultsForType
	{
		// Token: 0x06000230 RID: 560
		void SetResult(Type type, IReturn resultToReturn);

		// Token: 0x06000231 RID: 561
		bool TryGetResult(ICall call, [Nullable(2)] out object result);

		// Token: 0x06000232 RID: 562
		void Clear();
	}
}
