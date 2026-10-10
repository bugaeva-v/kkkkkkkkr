using System;
using UnityEngine.Purchasing;
using UnityEngine.Purchasing.Extension;

namespace Purchasing.Extension
{
	// Token: 0x02000006 RID: 6
	internal abstract class InternalStore : Store, IInternalStore, IStore
	{
		// Token: 0x06000008 RID: 8 RVA: 0x000021B8 File Offset: 0x000003B8
		protected InternalStore()
		{
			this.StoreConnectionStateService = new StoreConnectionStateService();
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000021CB File Offset: 0x000003CB
		public ConnectionState GetStoreConnectionState()
		{
			return this.StoreConnectionStateService.GetConnectionState();
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000021D8 File Offset: 0x000003D8
		public void SetStoreConnectionState(ConnectionState connectionState)
		{
			this.StoreConnectionStateService.SetConnectionState(connectionState);
		}

		// Token: 0x04000003 RID: 3
		internal IStoreConnectionStateService StoreConnectionStateService;
	}
}
