using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000090 RID: 144
	[NullableContext(1)]
	internal interface IStoreManager
	{
		// Token: 0x06000277 RID: 631
		IStoreWrapper GetStore(string name);
	}
}
