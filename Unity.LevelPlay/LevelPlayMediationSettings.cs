using System;
using System.IO;
using UnityEngine;

// Token: 0x02000002 RID: 2
[HelpURL("https://docs.unity.com/grow/levelplay/sdk/unity/developer-tools/")]
public class LevelPlayMediationSettings : ScriptableObject
{
	// Token: 0x04000001 RID: 1
	public static readonly string s_LevelPlaySettingsAssetPath = Path.Combine("Assets/LevelPlay/Resources", "LevelPlayMediationSettings.asset");

	// Token: 0x04000002 RID: 2
	[Header("Automatic Initialization")]
	[Tooltip("Enable this flag and enter App Keys below to automatically initialize your LevelPlay app.")]
	public bool EnableIronsourceSDKInitAPI;

	// Token: 0x04000003 RID: 3
	public string AndroidAppKey = string.Empty;

	// Token: 0x04000004 RID: 4
	public string IOSAppKey = string.Empty;

	// Token: 0x04000005 RID: 5
	[Header("Google Play Services Settings")]
	[Tooltip("Add Google Play Services normal permission for API level 31 (Android 12)")]
	public bool DeclareAD_IDPermission;

	// Token: 0x04000006 RID: 6
	[Header("Project Features")]
	public bool EnableAdapterDebug;

	// Token: 0x04000007 RID: 7
	public bool EnableIntegrationHelper;
}
