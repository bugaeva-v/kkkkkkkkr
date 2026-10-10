using System;
using UnityEngine;

namespace Unity.Services.LevelPlay
{
	// Token: 0x0200002C RID: 44
	internal class LevelPlayAutoInitializer
	{
		// Token: 0x0600023D RID: 573 RVA: 0x00005FCB File Offset: 0x000041CB
		[RuntimeInitializeOnLoadMethod]
		private static void Initialize()
		{
			LevelPlayAutoInitializer.InitializeWithSettings(Resources.Load<LevelPlayMediationSettings>("LevelPlayMediationSettings"));
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00005FDC File Offset: 0x000041DC
		internal static void InitializeWithSettings(LevelPlayMediationSettings developerSettings)
		{
			if (developerSettings == null)
			{
				return;
			}
			string text = null;
			if (developerSettings.EnableIronsourceSDKInitAPI)
			{
				if (string.IsNullOrEmpty(text))
				{
					LevelPlayLogger.LogWarning("LevelPlay SDK cannot initialize without AppKey");
				}
				else
				{
					LevelPlay.PluginVersion += (LevelPlay.PluginVersion.Contains("-r") ? "i" : "-i");
					LevelPlay.Init(text, null);
				}
			}
			if (developerSettings.EnableAdapterDebug)
			{
				LevelPlay.SetAdaptersDebug(true);
			}
			if (developerSettings.EnableIntegrationHelper)
			{
				LevelPlay.ValidateIntegration();
			}
		}
	}
}
