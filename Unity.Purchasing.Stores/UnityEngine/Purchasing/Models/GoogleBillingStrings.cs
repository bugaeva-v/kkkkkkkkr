using System;

namespace UnityEngine.Purchasing.Models
{
	// Token: 0x02000053 RID: 83
	internal static class GoogleBillingStrings
	{
		// Token: 0x06000215 RID: 533 RVA: 0x00008FCF File Offset: 0x000071CF
		internal static string getWarningMessageMoreThanOneSkuFound(string sku)
		{
			return "More than one SKU found when purchasing SKU " + sku + ". Please verify your Google Play Store in-app product settings.";
		}

		// Token: 0x040000DF RID: 223
		internal const string errorPurchaseStateUnspecified = "PurchaseState is UNSPECIFIED_STATE, no more details exists";

		// Token: 0x040000E0 RID: 224
		internal const string errorUserCancelled = "User cancelled purchase";

		// Token: 0x040000E1 RID: 225
		internal const string errorItemAlreadyOwned = "Item already owned";
	}
}
