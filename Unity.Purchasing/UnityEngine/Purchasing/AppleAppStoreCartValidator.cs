using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000029 RID: 41
	internal class AppleAppStoreCartValidator : StoreCartValidator
	{
		// Token: 0x060000B3 RID: 179 RVA: 0x0000333F File Offset: 0x0000153F
		internal AppleAppStoreCartValidator(string storeName) : base(storeName, new SingleProductSingleQuantityCartValidator())
		{
		}
	}
}
