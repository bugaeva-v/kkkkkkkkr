using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000C7 RID: 199
	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
	public interface IExtensionProvider
	{
		// Token: 0x060003BA RID: 954
		T GetExtension<T>() where T : IStoreExtension;
	}
}
