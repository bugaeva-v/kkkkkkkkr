using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000106 RID: 262
	internal static class ProductTypeExtensions
	{
		// Token: 0x060004E0 RID: 1248 RVA: 0x0000B4A8 File Offset: 0x000096A8
		internal static ProductType ToProductType(this string productType)
		{
			if (productType == "Auto-Renewable Subscription" || productType == "Non-Renewing Subscription")
			{
				return ProductType.Subscription;
			}
			if (productType == "Non-Consumable")
			{
				return ProductType.NonConsumable;
			}
			if (!(productType == "Consumable"))
			{
				throw new ArgumentException("Unrecognized productType " + productType);
			}
			return ProductType.Consumable;
		}
	}
}
