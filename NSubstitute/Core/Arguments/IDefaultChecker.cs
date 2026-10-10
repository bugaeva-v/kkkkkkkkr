using System;
using System.Runtime.CompilerServices;

namespace NSubstitute.Core.Arguments
{
	// Token: 0x020000DD RID: 221
	public interface IDefaultChecker
	{
		// Token: 0x0600039A RID: 922
		bool IsDefault([Nullable(2)] object value, Type forType);
	}
}
