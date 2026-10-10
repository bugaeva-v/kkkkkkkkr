using System;
using System.Collections.Generic;

namespace UnityEngine.Purchasing.Interfaces
{
	// Token: 0x0200005B RID: 91
	internal interface IGooglePurchaseBuilder
	{
		// Token: 0x06000236 RID: 566
		IEnumerable<IGooglePurchase> BuildPurchases(IEnumerable<AndroidJavaObject> purchases);
	}
}
