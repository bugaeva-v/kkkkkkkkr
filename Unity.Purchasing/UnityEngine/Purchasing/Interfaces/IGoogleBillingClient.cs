using System;
using System.Collections.Generic;
using UnityEngine.Purchasing.Models;

namespace UnityEngine.Purchasing.Interfaces
{
	// Token: 0x02000124 RID: 292
	internal interface IGoogleBillingClient
	{
		// Token: 0x0600051A RID: 1306
		void StartConnection(IBillingClientStateListener billingClientStateListener);

		// Token: 0x0600051B RID: 1307
		void EndConnection();

		// Token: 0x0600051C RID: 1308
		bool IsReady();

		// Token: 0x0600051D RID: 1309
		GoogleBillingConnectionState GetConnectionState();

		// Token: 0x0600051E RID: 1310
		void QueryPurchasesAsync(string skuType, Action<IGoogleBillingResult, IEnumerable<AndroidJavaObject>> onQueryPurchasesResponse);

		// Token: 0x0600051F RID: 1311
		void QueryProductDetailsAsync(List<string> skus, string type, Action<IGoogleBillingResult, List<AndroidJavaObject>> onProductDetailsResponseAction);

		// Token: 0x06000520 RID: 1312
		AndroidJavaObject LaunchBillingFlow(AndroidJavaObject productDetails, string oldPurchaseToken, GooglePlayReplacementMode? replacementMode);

		// Token: 0x06000521 RID: 1313
		void ConsumeAsync(string purchaseToken, Action<IGoogleBillingResult> onConsume);

		// Token: 0x06000522 RID: 1314
		void AcknowledgePurchase(string purchaseToken, Action<IGoogleBillingResult> onAcknowledge);

		// Token: 0x06000523 RID: 1315
		void SetObfuscationAccountId(string obfuscationAccountId);

		// Token: 0x06000524 RID: 1316
		void SetObfuscationProfileId(string obfuscationProfileId);
	}
}
