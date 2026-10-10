using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000A4 RID: 164
	[NullableContext(1)]
	[Nullable(0)]
	internal class StoreConnectUseCaseFactory
	{
		// Token: 0x060002BA RID: 698 RVA: 0x00006E0C File Offset: 0x0000500C
		public IStoreConnectUseCase CreateUseCase(IStoreWrapper storeWrapper, IRetryService retryService)
		{
			IRetryPolicy retryPolicyOnDisconnect = StoreConnectUseCaseFactory.CreateRetryPolicy(storeWrapper.name);
			return new StoreConnectUseCase(storeWrapper.instance, retryService, retryPolicyOnDisconnect);
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00006E32 File Offset: 0x00005032
		private static IRetryPolicy CreateRetryPolicy(string storeName)
		{
			if (storeName == "GooglePlay")
			{
				return new MaximumNumberOfAttemptsRetryPolicy(3);
			}
			return new NoRetriesPolicy();
		}
	}
}
