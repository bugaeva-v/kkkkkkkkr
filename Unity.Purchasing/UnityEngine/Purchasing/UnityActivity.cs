using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000E2 RID: 226
	internal class UnityActivity
	{
		// Token: 0x06000463 RID: 1123 RVA: 0x0000A274 File Offset: 0x00008474
		private static AndroidJavaClass GetUnityPlayerClass()
		{
			if (UnityActivity.s_UnityPlayerClass == null)
			{
				UnityActivity.s_UnityPlayerClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
			}
			return UnityActivity.s_UnityPlayerClass;
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x0000A291 File Offset: 0x00008491
		internal static AndroidJavaObject GetCurrentActivity()
		{
			return UnityActivity.GetUnityPlayerClass().GetStatic<AndroidJavaObject>("currentActivity");
		}

		// Token: 0x040001C7 RID: 455
		private const string k_AndroidClassName = "com.unity3d.player.UnityPlayer";

		// Token: 0x040001C8 RID: 456
		private static AndroidJavaClass s_UnityPlayerClass;
	}
}
