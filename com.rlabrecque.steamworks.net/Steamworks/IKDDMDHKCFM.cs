using System;

namespace Steamworks
{
	// Token: 0x02000011 RID: 17
	[Flags]
	public enum IKDDMDHKCFM
	{
		// Token: 0x0400006B RID: 107
		k_EMarketNotAllowedReason_None = 0,
		// Token: 0x0400006C RID: 108
		k_EMarketNotAllowedReason_TemporaryFailure = 1,
		// Token: 0x0400006D RID: 109
		k_EMarketNotAllowedReason_AccountDisabled = 2,
		// Token: 0x0400006E RID: 110
		k_EMarketNotAllowedReason_AccountLockedDown = 4,
		// Token: 0x0400006F RID: 111
		k_EMarketNotAllowedReason_AccountLimited = 8,
		// Token: 0x04000070 RID: 112
		k_EMarketNotAllowedReason_TradeBanned = 16,
		// Token: 0x04000071 RID: 113
		k_EMarketNotAllowedReason_AccountNotTrusted = 32,
		// Token: 0x04000072 RID: 114
		k_EMarketNotAllowedReason_SteamGuardNotEnabled = 64,
		// Token: 0x04000073 RID: 115
		k_EMarketNotAllowedReason_SteamGuardOnlyRecentlyEnabled = 128,
		// Token: 0x04000074 RID: 116
		k_EMarketNotAllowedReason_RecentPasswordReset = 256,
		// Token: 0x04000075 RID: 117
		k_EMarketNotAllowedReason_NewPaymentMethod = 512,
		// Token: 0x04000076 RID: 118
		k_EMarketNotAllowedReason_InvalidCookie = 1024,
		// Token: 0x04000077 RID: 119
		k_EMarketNotAllowedReason_UsingNewDevice = 2048,
		// Token: 0x04000078 RID: 120
		k_EMarketNotAllowedReason_RecentSelfRefund = 4096,
		// Token: 0x04000079 RID: 121
		k_EMarketNotAllowedReason_NewPaymentMethodCannotBeVerified = 8192,
		// Token: 0x0400007A RID: 122
		k_EMarketNotAllowedReason_NoRecentPurchases = 16384,
		// Token: 0x0400007B RID: 123
		k_EMarketNotAllowedReason_AcceptedWalletGift = 32768
	}
}
