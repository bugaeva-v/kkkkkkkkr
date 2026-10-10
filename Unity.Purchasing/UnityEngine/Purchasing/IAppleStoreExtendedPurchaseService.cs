using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200002A RID: 42
	[NullableContext(2)]
	public interface IAppleStoreExtendedPurchaseService : IPurchaseServiceExtension
	{
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060000B4 RID: 180
		// (set) Token: 0x060000B5 RID: 181
		bool simulateAskToBuy { get; set; }

		// Token: 0x060000B6 RID: 182
		void PresentCodeRedemptionSheet();

		// Token: 0x060000B7 RID: 183
		void ContinuePromotionalPurchases();

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060000B8 RID: 184
		[Obsolete]
		string appReceipt { get; }

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x060000B9 RID: 185
		// (remove) Token: 0x060000BA RID: 186
		[Nullable(new byte[]
		{
			2,
			1
		})]
		event Action<string> OnEntitlementRevoked;

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x060000BB RID: 187
		// (remove) Token: 0x060000BC RID: 188
		[Nullable(new byte[]
		{
			2,
			1
		})]
		event Action<Product> OnPromotionalPurchaseIntercepted;

		// Token: 0x060000BD RID: 189
		[NullableContext(1)]
		[Obsolete]
		void RefreshAppReceipt(Action<string> successCallback, Action<string> errorCallback);

		// Token: 0x060000BE RID: 190
		[Obsolete]
		void SetRefreshAppReceipt(bool refreshAppReceipt);
	}
}
