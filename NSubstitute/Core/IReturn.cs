using System;
using System.Runtime.CompilerServices;

namespace NSubstitute.Core
{
	// Token: 0x0200009A RID: 154
	public interface IReturn
	{
		// Token: 0x06000233 RID: 563
		[return: Nullable(2)]
		object ReturnFor(CallInfo info);

		// Token: 0x06000234 RID: 564
		[NullableContext(2)]
		Type TypeOrNull();

		// Token: 0x06000235 RID: 565
		bool CanBeAssignedTo(Type t);
	}
}
