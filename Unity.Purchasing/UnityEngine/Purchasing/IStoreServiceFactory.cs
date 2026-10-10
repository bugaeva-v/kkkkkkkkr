using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000094 RID: 148
	[NullableContext(1)]
	internal interface IStoreServiceFactory
	{
		// Token: 0x0600027F RID: 639
		void RegisterNewService(string name, Func<IStoreService> createFunction);

		// Token: 0x06000280 RID: 640
		void RegisterNewExtendedService(string name, Func<IStoreService, ExtensibleStoreService> createFunction);

		// Token: 0x06000281 RID: 641
		IStoreService Create(IStoreWrapper store, [Nullable(2)] IRetryPolicy retryPolicy);
	}
}
