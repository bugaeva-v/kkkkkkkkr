using System;

namespace Steamworks
{
	// Token: 0x02000115 RID: 277
	public enum BALPMDPLGKH
	{
		// Token: 0x0400075B RID: 1883
		k_ESteamNetworkingConnectionState_None,
		// Token: 0x0400075C RID: 1884
		k_ESteamNetworkingConnectionState_Connecting,
		// Token: 0x0400075D RID: 1885
		k_ESteamNetworkingConnectionState_FindingRoute,
		// Token: 0x0400075E RID: 1886
		k_ESteamNetworkingConnectionState_Connected,
		// Token: 0x0400075F RID: 1887
		k_ESteamNetworkingConnectionState_ClosedByPeer,
		// Token: 0x04000760 RID: 1888
		k_ESteamNetworkingConnectionState_ProblemDetectedLocally,
		// Token: 0x04000761 RID: 1889
		k_ESteamNetworkingConnectionState_FinWait = -1,
		// Token: 0x04000762 RID: 1890
		k_ESteamNetworkingConnectionState_Linger = -2,
		// Token: 0x04000763 RID: 1891
		k_ESteamNetworkingConnectionState_Dead = -3,
		// Token: 0x04000764 RID: 1892
		k_ESteamNetworkingConnectionState__Force32Bit = 2147483647
	}
}
