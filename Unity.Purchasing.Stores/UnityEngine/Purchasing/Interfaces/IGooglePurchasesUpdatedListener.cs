using System;
using System.Collections.Generic;
using UnityEngine.Purchasing.Models;

namespace UnityEngine.Purchasing.Interfaces
{
	// Token: 0x0200005F RID: 95
	internal interface IGooglePurchasesUpdatedListener
	{
		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000244 RID: 580
		// (remove) Token: 0x06000245 RID: 581
		event Action<IGoogleBillingResult, List<IGooglePurchase>> OnPurchaseUpdated;
	}
}
