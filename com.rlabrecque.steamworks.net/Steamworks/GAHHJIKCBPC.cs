using System;

namespace Steamworks
{
	// Token: 0x02000177 RID: 375
	[Flags]
	public enum GAHHJIKCBPC
	{
		// Token: 0x040008F9 RID: 2297
		k_EItemStateNone = 0,
		// Token: 0x040008FA RID: 2298
		k_EItemStateSubscribed = 1,
		// Token: 0x040008FB RID: 2299
		k_EItemStateLegacyItem = 2,
		// Token: 0x040008FC RID: 2300
		k_EItemStateInstalled = 4,
		// Token: 0x040008FD RID: 2301
		k_EItemStateNeedsUpdate = 8,
		// Token: 0x040008FE RID: 2302
		k_EItemStateDownloading = 16,
		// Token: 0x040008FF RID: 2303
		k_EItemStateDownloadPending = 32
	}
}
