using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200000C RID: 12
	internal class CommonTransactionEventHelper
	{
		// Token: 0x0600001E RID: 30 RVA: 0x00002520 File Offset: 0x00000720
		internal static string GetTransactionName(Product product)
		{
			if (!string.IsNullOrEmpty(product.metadata.localizedTitle))
			{
				return product.metadata.localizedTitle;
			}
			return product.definition.storeSpecificId;
		}
	}
}
