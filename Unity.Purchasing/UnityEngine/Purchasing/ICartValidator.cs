using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200003B RID: 59
	[NullableContext(1)]
	public interface ICartValidator
	{
		// Token: 0x060000F8 RID: 248
		void Validate(ICart cart);
	}
}
