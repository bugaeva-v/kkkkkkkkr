using System;
using System.Collections.Generic;
using UnityEngine.Purchasing.Models;

namespace UnityEngine.Purchasing.Interfaces
{
	// Token: 0x02000062 RID: 98
	internal interface IProductDetailsQueryResponse
	{
		// Token: 0x06000249 RID: 585
		void AddResponse(IGoogleBillingResult billingResult, IEnumerable<AndroidJavaObject> productDetails);

		// Token: 0x0600024A RID: 586
		List<AndroidJavaObject> ProductDetails();

		// Token: 0x0600024B RID: 587
		bool IsRecoverable();

		// Token: 0x0600024C RID: 588
		GoogleBillingResponseCode GetRecoverableBillingResponseCode();
	}
}
