using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000D2 RID: 210
	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
	public class StandardPurchasingModule
	{
		// Token: 0x060003EE RID: 1006 RVA: 0x000098BC File Offset: 0x00007ABC
		public static StandardPurchasingModule Instance()
		{
			if (StandardPurchasingModule.instance == null)
			{
				StandardPurchasingModule.instance = new StandardPurchasingModule();
			}
			return StandardPurchasingModule.instance;
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x000098D4 File Offset: 0x00007AD4
		public static StandardPurchasingModule Instance(AppStore androidStore)
		{
			return StandardPurchasingModule.Instance();
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060003F0 RID: 1008 RVA: 0x000098DB File Offset: 0x00007ADB
		// (set) Token: 0x060003F1 RID: 1009 RVA: 0x000098E3 File Offset: 0x00007AE3
		public FakeStoreUIMode useFakeStoreUIMode { get; set; }

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060003F2 RID: 1010 RVA: 0x000098EC File Offset: 0x00007AEC
		// (set) Token: 0x060003F3 RID: 1011 RVA: 0x000098F4 File Offset: 0x00007AF4
		public bool useFakeStoreAlways { get; set; }

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060003F4 RID: 1012 RVA: 0x000098FD File Offset: 0x00007AFD
		public string Version
		{
			get
			{
				return this.k_Version;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060003F5 RID: 1013 RVA: 0x00009905 File Offset: 0x00007B05
		public AppStore appStore
		{
			get
			{
				return DefaultStoreHelper.GetDefaultBuiltInAppStore();
			}
		}

		// Token: 0x04000181 RID: 385
		private static StandardPurchasingModule instance;

		// Token: 0x04000184 RID: 388
		internal readonly string k_Version = "5.0.0";
	}
}
