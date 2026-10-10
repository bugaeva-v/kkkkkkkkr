using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200009D RID: 157
	[NullableContext(2)]
	[Nullable(0)]
	internal class StoreService : IStoreService
	{
		// Token: 0x06000297 RID: 663 RVA: 0x000069C6 File Offset: 0x00004BC6
		[NullableContext(1)]
		internal StoreService(IStoreConnectUseCase connectUseCase)
		{
			this.m_StoreConnectUseCase = connectUseCase;
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000298 RID: 664 RVA: 0x000069D5 File Offset: 0x00004BD5
		public IAppleStoreExtendedService Apple
		{
			get
			{
				return this as IAppleStoreExtendedService;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000299 RID: 665 RVA: 0x000069DD File Offset: 0x00004BDD
		public IGooglePlayStoreExtendedService Google
		{
			get
			{
				return this as IGooglePlayStoreExtendedService;
			}
		}

		// Token: 0x0600029A RID: 666 RVA: 0x000069E5 File Offset: 0x00004BE5
		[NullableContext(1)]
		public Task Connect()
		{
			return this.m_StoreConnectUseCase.Connect();
		}

		// Token: 0x0600029B RID: 667 RVA: 0x000069F2 File Offset: 0x00004BF2
		public void SetStoreReconnectionRetryPolicyOnDisconnection(IRetryPolicy retryPolicy)
		{
			this.m_StoreConnectUseCase.SetStoreReconnectionRetryPolicyOnDisconnection(retryPolicy ?? new NoRetriesPolicy());
		}

		// Token: 0x1400002F RID: 47
		// (add) Token: 0x0600029C RID: 668 RVA: 0x00006A09 File Offset: 0x00004C09
		// (remove) Token: 0x0600029D RID: 669 RVA: 0x00006A17 File Offset: 0x00004C17
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public event Action<StoreConnectionFailureDescription> OnStoreDisconnected
		{
			add
			{
				this.m_StoreConnectUseCase.OnStoreDisconnection += value;
			}
			remove
			{
				this.m_StoreConnectUseCase.OnStoreDisconnection -= value;
			}
		}

		// Token: 0x040000D1 RID: 209
		[Nullable(1)]
		private readonly IStoreConnectUseCase m_StoreConnectUseCase;
	}
}
