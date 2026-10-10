using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200008C RID: 140
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class ExtensibleStoreService : IStoreService
	{
		// Token: 0x0600026A RID: 618 RVA: 0x00006812 File Offset: 0x00004A12
		[NullableContext(1)]
		protected ExtensibleStoreService(IStoreService baseStoreService)
		{
			this.m_BaseInternalStoreService = baseStoreService;
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600026B RID: 619 RVA: 0x00006821 File Offset: 0x00004A21
		public virtual IAppleStoreExtendedService Apple
		{
			get
			{
				return this.m_BaseInternalStoreService.Apple;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600026C RID: 620 RVA: 0x0000682E File Offset: 0x00004A2E
		public virtual IGooglePlayStoreExtendedService Google
		{
			get
			{
				return this.m_BaseInternalStoreService.Google;
			}
		}

		// Token: 0x0600026D RID: 621 RVA: 0x0000683B File Offset: 0x00004A3B
		[NullableContext(1)]
		public virtual Task Connect()
		{
			return this.m_BaseInternalStoreService.Connect();
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00006848 File Offset: 0x00004A48
		public virtual void SetStoreReconnectionRetryPolicyOnDisconnection(IRetryPolicy retryPolicy)
		{
			this.m_BaseInternalStoreService.SetStoreReconnectionRetryPolicyOnDisconnection(retryPolicy);
		}

		// Token: 0x1400002C RID: 44
		// (add) Token: 0x0600026F RID: 623 RVA: 0x00006856 File Offset: 0x00004A56
		// (remove) Token: 0x06000270 RID: 624 RVA: 0x00006864 File Offset: 0x00004A64
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public event Action<StoreConnectionFailureDescription> OnStoreDisconnected
		{
			add
			{
				this.m_BaseInternalStoreService.OnStoreDisconnected += value;
			}
			remove
			{
				this.m_BaseInternalStoreService.OnStoreDisconnected -= value;
			}
		}

		// Token: 0x040000C4 RID: 196
		[Nullable(1)]
		private IStoreService m_BaseInternalStoreService;
	}
}
