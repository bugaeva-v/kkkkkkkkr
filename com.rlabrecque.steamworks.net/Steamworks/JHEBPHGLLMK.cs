using System;

namespace Steamworks
{
	// Token: 0x020000BA RID: 186
	public enum JHEBPHGLLMK
	{
		// Token: 0x04000441 RID: 1089
		k_ESteamNetworkingConfig_Invalid,
		// Token: 0x04000442 RID: 1090
		k_ESteamNetworkingConfig_TimeoutInitial = 24,
		// Token: 0x04000443 RID: 1091
		k_ESteamNetworkingConfig_TimeoutConnected,
		// Token: 0x04000444 RID: 1092
		k_ESteamNetworkingConfig_SendBufferSize = 9,
		// Token: 0x04000445 RID: 1093
		k_ESteamNetworkingConfig_ConnectionUserData = 40,
		// Token: 0x04000446 RID: 1094
		k_ESteamNetworkingConfig_SendRateMin = 10,
		// Token: 0x04000447 RID: 1095
		k_ESteamNetworkingConfig_SendRateMax,
		// Token: 0x04000448 RID: 1096
		k_ESteamNetworkingConfig_NagleTime,
		// Token: 0x04000449 RID: 1097
		k_ESteamNetworkingConfig_IP_AllowWithoutAuth = 23,
		// Token: 0x0400044A RID: 1098
		k_ESteamNetworkingConfig_MTU_PacketSize = 32,
		// Token: 0x0400044B RID: 1099
		k_ESteamNetworkingConfig_MTU_DataSize,
		// Token: 0x0400044C RID: 1100
		k_ESteamNetworkingConfig_Unencrypted,
		// Token: 0x0400044D RID: 1101
		k_ESteamNetworkingConfig_SymmetricConnect = 37,
		// Token: 0x0400044E RID: 1102
		k_ESteamNetworkingConfig_LocalVirtualPort,
		// Token: 0x0400044F RID: 1103
		k_ESteamNetworkingConfig_DualWifi_Enable,
		// Token: 0x04000450 RID: 1104
		k_ESteamNetworkingConfig_EnableDiagnosticsUI = 46,
		// Token: 0x04000451 RID: 1105
		k_ESteamNetworkingConfig_FakePacketLoss_Send = 2,
		// Token: 0x04000452 RID: 1106
		k_ESteamNetworkingConfig_FakePacketLoss_Recv,
		// Token: 0x04000453 RID: 1107
		k_ESteamNetworkingConfig_FakePacketLag_Send,
		// Token: 0x04000454 RID: 1108
		k_ESteamNetworkingConfig_FakePacketLag_Recv,
		// Token: 0x04000455 RID: 1109
		k_ESteamNetworkingConfig_FakePacketReorder_Send,
		// Token: 0x04000456 RID: 1110
		k_ESteamNetworkingConfig_FakePacketReorder_Recv,
		// Token: 0x04000457 RID: 1111
		k_ESteamNetworkingConfig_FakePacketReorder_Time,
		// Token: 0x04000458 RID: 1112
		k_ESteamNetworkingConfig_FakePacketDup_Send = 26,
		// Token: 0x04000459 RID: 1113
		k_ESteamNetworkingConfig_FakePacketDup_Recv,
		// Token: 0x0400045A RID: 1114
		k_ESteamNetworkingConfig_FakePacketDup_TimeMax,
		// Token: 0x0400045B RID: 1115
		k_ESteamNetworkingConfig_PacketTraceMaxBytes = 41,
		// Token: 0x0400045C RID: 1116
		k_ESteamNetworkingConfig_FakeRateLimit_Send_Rate,
		// Token: 0x0400045D RID: 1117
		k_ESteamNetworkingConfig_FakeRateLimit_Send_Burst,
		// Token: 0x0400045E RID: 1118
		k_ESteamNetworkingConfig_FakeRateLimit_Recv_Rate,
		// Token: 0x0400045F RID: 1119
		k_ESteamNetworkingConfig_FakeRateLimit_Recv_Burst,
		// Token: 0x04000460 RID: 1120
		k_ESteamNetworkingConfig_Callback_ConnectionStatusChanged = 201,
		// Token: 0x04000461 RID: 1121
		k_ESteamNetworkingConfig_Callback_AuthStatusChanged,
		// Token: 0x04000462 RID: 1122
		k_ESteamNetworkingConfig_Callback_RelayNetworkStatusChanged,
		// Token: 0x04000463 RID: 1123
		k_ESteamNetworkingConfig_Callback_MessagesSessionRequest,
		// Token: 0x04000464 RID: 1124
		k_ESteamNetworkingConfig_Callback_MessagesSessionFailed,
		// Token: 0x04000465 RID: 1125
		k_ESteamNetworkingConfig_Callback_CreateConnectionSignaling,
		// Token: 0x04000466 RID: 1126
		k_ESteamNetworkingConfig_Callback_FakeIPResult,
		// Token: 0x04000467 RID: 1127
		k_ESteamNetworkingConfig_P2P_STUN_ServerList = 103,
		// Token: 0x04000468 RID: 1128
		k_ESteamNetworkingConfig_P2P_Transport_ICE_Enable,
		// Token: 0x04000469 RID: 1129
		k_ESteamNetworkingConfig_P2P_Transport_ICE_Penalty,
		// Token: 0x0400046A RID: 1130
		k_ESteamNetworkingConfig_P2P_Transport_SDR_Penalty,
		// Token: 0x0400046B RID: 1131
		k_ESteamNetworkingConfig_SDRClient_ConsecutitivePingTimeoutsFailInitial = 19,
		// Token: 0x0400046C RID: 1132
		k_ESteamNetworkingConfig_SDRClient_ConsecutitivePingTimeoutsFail,
		// Token: 0x0400046D RID: 1133
		k_ESteamNetworkingConfig_SDRClient_MinPingsBeforePingAccurate,
		// Token: 0x0400046E RID: 1134
		k_ESteamNetworkingConfig_SDRClient_SingleSocket,
		// Token: 0x0400046F RID: 1135
		k_ESteamNetworkingConfig_SDRClient_ForceRelayCluster = 29,
		// Token: 0x04000470 RID: 1136
		k_ESteamNetworkingConfig_SDRClient_DebugTicketAddress,
		// Token: 0x04000471 RID: 1137
		k_ESteamNetworkingConfig_SDRClient_ForceProxyAddr,
		// Token: 0x04000472 RID: 1138
		k_ESteamNetworkingConfig_SDRClient_FakeClusterPing = 36,
		// Token: 0x04000473 RID: 1139
		k_ESteamNetworkingConfig_LogLevel_AckRTT = 13,
		// Token: 0x04000474 RID: 1140
		k_ESteamNetworkingConfig_LogLevel_PacketDecode,
		// Token: 0x04000475 RID: 1141
		k_ESteamNetworkingConfig_LogLevel_Message,
		// Token: 0x04000476 RID: 1142
		k_ESteamNetworkingConfig_LogLevel_PacketGaps,
		// Token: 0x04000477 RID: 1143
		k_ESteamNetworkingConfig_LogLevel_P2PRendezvous,
		// Token: 0x04000478 RID: 1144
		k_ESteamNetworkingConfig_LogLevel_SDRRelayPings,
		// Token: 0x04000479 RID: 1145
		k_ESteamNetworkingConfig_DELETED_EnumerateDevVars = 35,
		// Token: 0x0400047A RID: 1146
		k_ESteamNetworkingConfigValue__Force32Bit = 2147483647
	}
}
