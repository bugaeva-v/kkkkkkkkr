using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000FE RID: 254
	[NullableContext(1)]
	[Nullable(0)]
	public static class DefaultStoreHelper
	{
		// Token: 0x060004B7 RID: 1207 RVA: 0x0000A37E File Offset: 0x0000857E
		public static void OverrideDefaultStoreName(string newDefaultStoreName)
		{
			DefaultStoreHelper.s_DefaultCustomStoreOverrideName = newDefaultStoreName;
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x0000A386 File Offset: 0x00008586
		public static string GetDefaultStoreName()
		{
			if (!string.IsNullOrEmpty(DefaultStoreHelper.s_DefaultCustomStoreOverrideName))
			{
				return DefaultStoreHelper.s_DefaultCustomStoreOverrideName;
			}
			return DefaultStoreHelper.GetBuiltInDefaultStoreName();
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x0000A3A0 File Offset: 0x000085A0
		private static string GetBuiltInDefaultStoreName()
		{
			RuntimePlatform platform = Application.platform;
			if (platform <= RuntimePlatform.IPhonePlayer)
			{
				if (platform == RuntimePlatform.OSXPlayer)
				{
					return "MacAppStore";
				}
				if (platform != RuntimePlatform.IPhonePlayer)
				{
					goto IL_32;
				}
			}
			else
			{
				if (platform == RuntimePlatform.Android)
				{
					return SelectedAndroidStoreHelper.GetSelectedAndroidStoreName();
				}
				if (platform != RuntimePlatform.tvOS)
				{
					goto IL_32;
				}
			}
			return "AppleAppStore";
			IL_32:
			return "fake";
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x0000A3E4 File Offset: 0x000085E4
		internal static AppStore GetDefaultBuiltInAppStore()
		{
			RuntimePlatform platform = Application.platform;
			if (platform <= RuntimePlatform.IPhonePlayer)
			{
				if (platform == RuntimePlatform.OSXPlayer)
				{
					return AppStore.MacAppStore;
				}
				if (platform != RuntimePlatform.IPhonePlayer)
				{
					return AppStore.fake;
				}
			}
			else
			{
				if (platform == RuntimePlatform.Android)
				{
					return SelectedAndroidStoreHelper.GetSelectedAndroidStore();
				}
				if (platform != RuntimePlatform.tvOS)
				{
					return AppStore.fake;
				}
			}
			return AppStore.AppleAppStore;
		}

		// Token: 0x04000204 RID: 516
		private static string s_DefaultCustomStoreOverrideName = string.Empty;
	}
}
