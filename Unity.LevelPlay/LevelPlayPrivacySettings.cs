using System;
using System.Collections.Generic;

namespace Unity.Services.LevelPlay
{
	// Token: 0x02000011 RID: 17
	public static class LevelPlayPrivacySettings
	{
		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x00003B64 File Offset: 0x00001D64
		private static ILevelPlaySdk Sdk
		{
			get
			{
				return LevelPlaySdkProvider.Get();
			}
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00003B6B File Offset: 0x00001D6B
		public static void SetGDPRConsents(Dictionary<string, bool> networkConsents)
		{
			ILevelPlaySdk sdk = LevelPlayPrivacySettings.Sdk;
			if (sdk == null)
			{
				return;
			}
			sdk.SetGDPRConsents(networkConsents);
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00003B7D File Offset: 0x00001D7D
		public static void SetCCPA(bool value)
		{
			ILevelPlaySdk sdk = LevelPlayPrivacySettings.Sdk;
			if (sdk == null)
			{
				return;
			}
			sdk.SetCCPA(value);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00003B8F File Offset: 0x00001D8F
		public static void SetCOPPA(bool value)
		{
			ILevelPlaySdk sdk = LevelPlayPrivacySettings.Sdk;
			if (sdk == null)
			{
				return;
			}
			sdk.SetCOPPA(value);
		}
	}
}
