using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200009B RID: 155
	internal class StoreConnectionStateService : IStoreConnectionStateService
	{
		// Token: 0x0600028E RID: 654 RVA: 0x00006898 File Offset: 0x00004A98
		public StoreConnectionStateService()
		{
			this.m_StoreConnectionState = new ConnectionState?(ConnectionState.Unavailable);
		}

		// Token: 0x0600028F RID: 655 RVA: 0x000068AC File Offset: 0x00004AAC
		public ConnectionState GetConnectionState()
		{
			ConnectionState? storeConnectionState = this.m_StoreConnectionState;
			if (storeConnectionState == null)
			{
				return ConnectionState.Unavailable;
			}
			return storeConnectionState.GetValueOrDefault();
		}

		// Token: 0x06000290 RID: 656 RVA: 0x000068D2 File Offset: 0x00004AD2
		public void SetConnectionState(ConnectionState connectionState)
		{
			this.m_StoreConnectionState = new ConnectionState?(connectionState);
		}

		// Token: 0x040000CD RID: 205
		private ConnectionState? m_StoreConnectionState;
	}
}
