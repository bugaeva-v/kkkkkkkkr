using System;

namespace UnityEngine.Purchasing.Extension
{
	// Token: 0x0200012B RID: 299
	internal interface IInternalStore : IStore
	{
		// Token: 0x06000549 RID: 1353
		ConnectionState GetStoreConnectionState();

		// Token: 0x0600054A RID: 1354
		void SetStoreConnectionState(ConnectionState connectionState);
	}
}
