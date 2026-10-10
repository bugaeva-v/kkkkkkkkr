using System;
using System.Threading;
using Firebase.Unity;
using UnityEngine;

namespace Firebase.Platform
{
	// Token: 0x02000012 RID: 18
	internal static class PlatformInformation
	{
		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00002EDC File Offset: 0x000010DC
		internal static bool IsAndroid
		{
			get
			{
				return Application.platform == RuntimePlatform.Android;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00002EF8 File Offset: 0x000010F8
		internal static bool IsIOS
		{
			get
			{
				return Application.platform == RuntimePlatform.IPhonePlayer || Application.platform == RuntimePlatform.tvOS;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600006B RID: 107 RVA: 0x00002F20 File Offset: 0x00001120
		internal static string DefaultConfigLocation
		{
			get
			{
				return FirebaseHandler.RunOnMainThread<string>(() => Application.streamingAssetsPath);
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600006C RID: 108 RVA: 0x00002F58 File Offset: 0x00001158
		internal static SynchronizationContext SynchronizationContext
		{
			get
			{
				return UnitySynchronizationContext.Instance;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00002F70 File Offset: 0x00001170
		internal static float RealtimeSinceStartup
		{
			get
			{
				return Time.realtimeSinceStartup;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600006E RID: 110 RVA: 0x00002F87 File Offset: 0x00001187
		// (set) Token: 0x0600006F RID: 111 RVA: 0x00002F8E File Offset: 0x0000118E
		internal static float RealtimeSinceStartupSafe { get; set; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000070 RID: 112 RVA: 0x00002F98 File Offset: 0x00001198
		internal static string RuntimeName
		{
			get
			{
				return "unity";
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000071 RID: 113 RVA: 0x00002FB0 File Offset: 0x000011B0
		internal static string RuntimeVersion
		{
			get
			{
				bool flag = PlatformInformation.runtimeVersion == null;
				if (flag)
				{
					PlatformInformation.runtimeVersion = FirebaseHandler.RunOnMainThread<string>(() => Application.unityVersion);
				}
				return PlatformInformation.runtimeVersion;
			}
		}

		// Token: 0x04000023 RID: 35
		private static string runtimeVersion;
	}
}
