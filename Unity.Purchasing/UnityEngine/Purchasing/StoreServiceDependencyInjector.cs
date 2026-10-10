using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200009F RID: 159
	[NullableContext(1)]
	[Nullable(0)]
	internal class StoreServiceDependencyInjector
	{
		// Token: 0x060002A2 RID: 674 RVA: 0x00006A9F File Offset: 0x00004C9F
		internal StoreServiceDependencyInjector(IStoreWrapper storeWrapper, [Nullable(2)] IRetryPolicy retryPolicy)
		{
			this.m_RetryPolicy = retryPolicy;
			this.m_Store = storeWrapper;
			this.m_ServiceFactoryManager = StoreServiceFactoryManager.Instance();
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00006AC0 File Offset: 0x00004CC0
		internal IStoreService CreateStoreService()
		{
			return this.m_ServiceFactoryManager.GetServiceFactory().Create(this.m_Store, this.m_RetryPolicy);
		}

		// Token: 0x040000D4 RID: 212
		[Nullable(2)]
		private readonly IRetryPolicy m_RetryPolicy;

		// Token: 0x040000D5 RID: 213
		private readonly IStoreWrapper m_Store;

		// Token: 0x040000D6 RID: 214
		private IStoreServiceFactoryManager m_ServiceFactoryManager;
	}
}
