using System;

namespace Firebase.Platform
{
	// Token: 0x0200000F RID: 15
	internal interface IFirebaseAppPlatform
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000049 RID: 73
		object AppObject { get; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600004A RID: 74
		string Name { get; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600004B RID: 75
		Uri DatabaseUrl { get; }
	}
}
