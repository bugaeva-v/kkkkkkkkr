using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000E8 RID: 232
	public enum GooglePlayReplacementMode
	{
		// Token: 0x040001D6 RID: 470
		UnknownReplacementMode,
		// Token: 0x040001D7 RID: 471
		WithTimeProration,
		// Token: 0x040001D8 RID: 472
		ChargeProratedPrice,
		// Token: 0x040001D9 RID: 473
		WithoutProration,
		// Token: 0x040001DA RID: 474
		ChargeFullPrice = 5,
		// Token: 0x040001DB RID: 475
		Deferred
	}
}
