using System;

namespace com.shephertz.app42.paas.sdk.csharp.pushNotification
{
	// Token: 0x02000082 RID: 130
	public sealed class DeviceType
	{
		// Token: 0x0600055A RID: 1370 RVA: 0x0001C953 File Offset: 0x0001AB53
		public static bool IsValidType(string type)
		{
			return DeviceType.ANDROID.Equals(type) || DeviceType.iOS.Equals(type) || DeviceType.WP7.Equals(type) || DeviceType.NOKIAX.Equals(type);
		}

		// Token: 0x04000241 RID: 577
		public static readonly string ANDROID = "ANDROID";

		// Token: 0x04000242 RID: 578
		public static readonly string iOS = "iOS";

		// Token: 0x04000243 RID: 579
		public static readonly string WP7 = "WP7";

		// Token: 0x04000244 RID: 580
		public static readonly string NOKIAX = "NokiaX";
	}
}
