using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine.Purchasing.Security;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000035 RID: 53
	[NullableContext(1)]
	[Nullable(0)]
	internal static class AppleReceiptExtensions
	{
		// Token: 0x0600010B RID: 267 RVA: 0x00004E20 File Offset: 0x00003020
		[NullableContext(2)]
		public static bool HasInAppPurchaseReceipts(this AppleReceipt appleReceipt)
		{
			if (appleReceipt == null)
			{
				return false;
			}
			AppleInAppPurchaseReceipt[] inAppPurchaseReceipts = appleReceipt.inAppPurchaseReceipts;
			int? num = (inAppPurchaseReceipts != null) ? new int?(inAppPurchaseReceipts.Length) : null;
			int num2 = 0;
			return num.GetValueOrDefault() > num2 & num != null;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00004E64 File Offset: 0x00003064
		[return: Nullable(2)]
		public static AppleInAppPurchaseReceipt FindMostRecentReceiptForProduct(this AppleReceipt appleReceipt, string productId)
		{
			AppleInAppPurchaseReceipt[] array = Array.FindAll<AppleInAppPurchaseReceipt>(appleReceipt.inAppPurchaseReceipts, (AppleInAppPurchaseReceipt r) => r.productID == productId);
			Array.Sort<AppleInAppPurchaseReceipt>(array, (AppleInAppPurchaseReceipt b, AppleInAppPurchaseReceipt a) => a.purchaseDate.CompareTo(b.purchaseDate));
			return AppleReceiptExtensions.FirstNonCancelledReceipt(array);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00004EBF File Offset: 0x000030BF
		[return: Nullable(2)]
		private static AppleInAppPurchaseReceipt FirstNonCancelledReceipt(IEnumerable<AppleInAppPurchaseReceipt> receipts)
		{
			return receipts.FirstOrDefault((AppleInAppPurchaseReceipt receipt) => !receipt.IsCancelled());
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00004EE6 File Offset: 0x000030E6
		private static bool IsCancelled(this AppleInAppPurchaseReceipt receipt)
		{
			return receipt.cancellationDate != DateTime.MinValue;
		}
	}
}
