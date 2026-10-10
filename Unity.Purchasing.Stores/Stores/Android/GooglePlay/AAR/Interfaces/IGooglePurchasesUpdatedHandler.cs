using System;
using System.Collections.Generic;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.Models;

namespace Stores.Android.GooglePlay.AAR.Interfaces
{
	// Token: 0x02000005 RID: 5
	internal interface IGooglePurchasesUpdatedHandler
	{
		// Token: 0x06000005 RID: 5
		void HandleUpdatedPurchases(IGoogleBillingResult result, List<IGooglePurchase> purchases);

		// Token: 0x06000006 RID: 6
		void SetProductCache(IProductCache productCache);
	}
}
