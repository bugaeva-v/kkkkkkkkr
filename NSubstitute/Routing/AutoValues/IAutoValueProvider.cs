using System;
using System.Runtime.CompilerServices;

namespace NSubstitute.Routing.AutoValues
{
	// Token: 0x0200003A RID: 58
	public interface IAutoValueProvider
	{
		// Token: 0x060000D0 RID: 208
		bool CanProvideValueFor(Type type);

		// Token: 0x060000D1 RID: 209
		[return: Nullable(2)]
		object GetValue(Type type);
	}
}
