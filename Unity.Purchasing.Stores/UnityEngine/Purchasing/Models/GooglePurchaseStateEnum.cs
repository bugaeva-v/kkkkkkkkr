using System;

namespace UnityEngine.Purchasing.Models
{
	// Token: 0x02000056 RID: 86
	internal static class GooglePurchaseStateEnum
	{
		// Token: 0x06000228 RID: 552 RVA: 0x0000920E File Offset: 0x0000740E
		private static AndroidJavaObject GetPurchaseStateJavaObject()
		{
			return new AndroidJavaClass("com.android.billingclient.api.Purchase$PurchaseState");
		}

		// Token: 0x06000229 RID: 553 RVA: 0x0000921C File Offset: 0x0000741C
		internal static int Purchased()
		{
			if (GooglePurchaseStateEnum.s_Purchased == null)
			{
				using (AndroidJavaObject purchaseStateJavaObject = GooglePurchaseStateEnum.GetPurchaseStateJavaObject())
				{
					GooglePurchaseStateEnum.s_Purchased = new int?(purchaseStateJavaObject.GetStatic<int>("PURCHASED"));
				}
			}
			return GooglePurchaseStateEnum.s_Purchased.Value;
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00009278 File Offset: 0x00007478
		internal static int Pending()
		{
			if (GooglePurchaseStateEnum.s_Pending == null)
			{
				using (AndroidJavaObject purchaseStateJavaObject = GooglePurchaseStateEnum.GetPurchaseStateJavaObject())
				{
					GooglePurchaseStateEnum.s_Pending = new int?(purchaseStateJavaObject.GetStatic<int>("PENDING"));
				}
			}
			return GooglePurchaseStateEnum.s_Pending.Value;
		}

		// Token: 0x040000ED RID: 237
		private const string k_AndroidPurchaseStateClassName = "com.android.billingclient.api.Purchase$PurchaseState";

		// Token: 0x040000EE RID: 238
		private static int? s_Purchased;

		// Token: 0x040000EF RID: 239
		private static int? s_Pending;
	}
}
