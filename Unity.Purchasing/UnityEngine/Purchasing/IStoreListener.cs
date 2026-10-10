using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000CD RID: 205
	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
	public interface IStoreListener
	{
		// Token: 0x060003CC RID: 972
		void OnInitialized(IStoreController controller, IExtensionProvider extensions);

		// Token: 0x060003CD RID: 973
		[Obsolete]
		void OnInitializeFailed(InitializationFailureReason error);

		// Token: 0x060003CE RID: 974
		void OnInitializeFailed(InitializationFailureReason error, string message = null);

		// Token: 0x060003CF RID: 975
		PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs args);

		// Token: 0x060003D0 RID: 976
		[Obsolete("Use IDetailedStoreListener.OnPurchaseFailed for more detailed callback.", false)]
		void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason);
	}
}
