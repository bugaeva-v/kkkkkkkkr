using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200008E RID: 142
	internal interface IStoreConnectionStateService
	{
		// Token: 0x06000273 RID: 627
		ConnectionState GetConnectionState();

		// Token: 0x06000274 RID: 628
		void SetConnectionState(ConnectionState connectionState);
	}
}
