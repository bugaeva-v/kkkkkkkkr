using System;
using System.Runtime.CompilerServices;

namespace NSubstitute.Core
{
	// Token: 0x0200008D RID: 141
	public interface IDefaultForType
	{
		// Token: 0x06000216 RID: 534
		[return: Nullable(2)]
		object GetDefaultFor(Type type);
	}
}
