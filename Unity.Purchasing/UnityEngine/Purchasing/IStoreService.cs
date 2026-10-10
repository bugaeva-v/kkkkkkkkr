using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000092 RID: 146
	[NullableContext(2)]
	public interface IStoreService
	{
		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000279 RID: 633
		IAppleStoreExtendedService Apple { get; }

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600027A RID: 634
		IGooglePlayStoreExtendedService Google { get; }

		// Token: 0x0600027B RID: 635
		[NullableContext(1)]
		Task Connect();

		// Token: 0x0600027C RID: 636
		void SetStoreReconnectionRetryPolicyOnDisconnection(IRetryPolicy retryPolicy);

		// Token: 0x1400002D RID: 45
		// (add) Token: 0x0600027D RID: 637
		// (remove) Token: 0x0600027E RID: 638
		[Nullable(new byte[]
		{
			2,
			1
		})]
		event Action<StoreConnectionFailureDescription> OnStoreDisconnected;
	}
}
