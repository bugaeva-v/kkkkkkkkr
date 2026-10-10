using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000FF RID: 255
	internal static class SelectedAndroidStoreHelper
	{
		// Token: 0x060004BC RID: 1212 RVA: 0x0000A428 File Offset: 0x00008628
		internal static string GetSelectedAndroidStoreName()
		{
			if (SelectedAndroidStoreHelper.GetSelectedAndroidStore() == AppStore.GooglePlay)
			{
				return "GooglePlay";
			}
			return "fake";
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x0000A440 File Offset: 0x00008640
		internal static AppStore GetSelectedAndroidStore()
		{
			StoreConfiguration storeConfiguration = SelectedAndroidStoreHelper.LoadStoreConfiguration();
			if (storeConfiguration == null)
			{
				return AppStore.NotSpecified;
			}
			return storeConfiguration.androidStore;
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x0000A460 File Offset: 0x00008660
		private static StoreConfiguration LoadStoreConfiguration()
		{
			TextAsset textAsset = Resources.Load(SelectedAndroidStoreHelper.k_BillingModeFileName) as TextAsset;
			StoreConfiguration result = null;
			if (null != textAsset)
			{
				result = StoreConfiguration.Deserialize(textAsset.text);
			}
			return result;
		}

		// Token: 0x04000205 RID: 517
		private static readonly string k_BillingModeFileName = "BillingMode";
	}
}
