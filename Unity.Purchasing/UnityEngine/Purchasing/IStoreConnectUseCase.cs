using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000098 RID: 152
	[NullableContext(1)]
	internal interface IStoreConnectUseCase
	{
		// Token: 0x06000287 RID: 647
		Task Connect();

		// Token: 0x06000288 RID: 648
		void SetStoreReconnectionRetryPolicyOnDisconnection(IRetryPolicy retryPolicy);

		// Token: 0x1400002E RID: 46
		// (add) Token: 0x06000289 RID: 649
		// (remove) Token: 0x0600028A RID: 650
		[Nullable(new byte[]
		{
			2,
			1
		})]
		event Action<StoreConnectionFailureDescription> OnStoreDisconnection;
	}
}
