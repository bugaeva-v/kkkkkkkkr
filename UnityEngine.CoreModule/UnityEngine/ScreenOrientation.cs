using System;

namespace UnityEngine
{
	// Token: 0x02000179 RID: 377
	public enum ScreenOrientation
	{
		// Token: 0x040004D0 RID: 1232
		[Obsolete("Enum member Unknown has been deprecated.", false)]
		Unknown,
		// Token: 0x040004D1 RID: 1233
		[Obsolete("Use LandscapeLeft instead (UnityUpgradable) -> LandscapeLeft", true)]
		Landscape = 3,
		// Token: 0x040004D2 RID: 1234
		Portrait = 1,
		// Token: 0x040004D3 RID: 1235
		PortraitUpsideDown,
		// Token: 0x040004D4 RID: 1236
		LandscapeLeft,
		// Token: 0x040004D5 RID: 1237
		LandscapeRight,
		// Token: 0x040004D6 RID: 1238
		AutoRotation
	}
}
