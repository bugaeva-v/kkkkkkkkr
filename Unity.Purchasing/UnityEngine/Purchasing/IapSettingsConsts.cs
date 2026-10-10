using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000E0 RID: 224
	internal static class IapSettingsConsts
	{
		// Token: 0x040001C1 RID: 449
		internal const string StagingPath = "https://staging.services.unity.com";

		// Token: 0x040001C2 RID: 450
		internal const string ProductionPath = "https://services.unity.com";

		// Token: 0x040001C3 RID: 451
		internal const string ApiPath = "/api/iap-settings/v1";

		// Token: 0x040001C4 RID: 452
		internal const string SettingsEndpoint = "/projects/{0}/settings";

		// Token: 0x040001C5 RID: 453
		internal const string AuthorizationHeaderValue = "Bearer {0}";

		// Token: 0x040001C6 RID: 454
		internal const string XClientIdHeader = "unity-dashboard";
	}
}
