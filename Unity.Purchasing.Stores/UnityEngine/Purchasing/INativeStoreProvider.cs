using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000038 RID: 56
	[NullableContext(1)]
	internal interface INativeStoreProvider
	{
		// Token: 0x06000148 RID: 328
		INativeAppleStore GetStorekit(IUnityCallback callback);
	}
}
