using System;

namespace Steamworks
{
	// Token: 0x02000060 RID: 96
	public enum IKIMJFHJLMP
	{
		// Token: 0x040002DE RID: 734
		k_ESNetSocketStateInvalid,
		// Token: 0x040002DF RID: 735
		k_ESNetSocketStateConnected,
		// Token: 0x040002E0 RID: 736
		k_ESNetSocketStateInitiated = 10,
		// Token: 0x040002E1 RID: 737
		k_ESNetSocketStateLocalCandidatesFound,
		// Token: 0x040002E2 RID: 738
		k_ESNetSocketStateReceivedRemoteCandidates,
		// Token: 0x040002E3 RID: 739
		k_ESNetSocketStateChallengeHandshake = 15,
		// Token: 0x040002E4 RID: 740
		k_ESNetSocketStateDisconnecting = 21,
		// Token: 0x040002E5 RID: 741
		k_ESNetSocketStateLocalDisconnect,
		// Token: 0x040002E6 RID: 742
		k_ESNetSocketStateTimeoutDuringConnect,
		// Token: 0x040002E7 RID: 743
		k_ESNetSocketStateRemoteEndDisconnected,
		// Token: 0x040002E8 RID: 744
		k_ESNetSocketStateConnectionBroken
	}
}
