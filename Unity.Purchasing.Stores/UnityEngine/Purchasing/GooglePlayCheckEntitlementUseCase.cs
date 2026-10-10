using System;
using System.Runtime.CompilerServices;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000013 RID: 19
	internal class GooglePlayCheckEntitlementUseCase : IGooglePlayCheckEntitlementUseCase
	{
		// Token: 0x0600003A RID: 58 RVA: 0x000029EE File Offset: 0x00000BEE
		[Preserve]
		internal GooglePlayCheckEntitlementUseCase(IGoogleQueryPurchasesUseCase googleQueryPurchasesUseCase)
		{
			this.m_GoogleQueryPurchasesUseCase = googleQueryPurchasesUseCase;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002A00 File Offset: 0x00000C00
		public void CheckEntitlement(ProductDefinition product, Action<ProductDefinition, EntitlementStatus> onEntitlementChecked)
		{
			GooglePlayCheckEntitlementUseCase.<CheckEntitlement>d__2 <CheckEntitlement>d__;
			<CheckEntitlement>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<CheckEntitlement>d__.<>4__this = this;
			<CheckEntitlement>d__.product = product;
			<CheckEntitlement>d__.onEntitlementChecked = onEntitlementChecked;
			<CheckEntitlement>d__.<>1__state = -1;
			<CheckEntitlement>d__.<>t__builder.Start<GooglePlayCheckEntitlementUseCase.<CheckEntitlement>d__2>(ref <CheckEntitlement>d__);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002A47 File Offset: 0x00000C47
		private static Func<IGooglePurchase, bool> PurchaseToCheckForEntitlement(ProductDefinition product)
		{
			return (IGooglePurchase purchase) => purchase != null && purchase.sku == product.storeSpecificId && purchase.IsPurchased();
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002A60 File Offset: 0x00000C60
		private static EntitlementStatus DetermineEntitlementStatus(IGooglePurchase purchase, ProductType type)
		{
			if (purchase == null)
			{
				return EntitlementStatus.NotEntitled;
			}
			if (type == ProductType.Consumable)
			{
				return EntitlementStatus.EntitledUntilConsumed;
			}
			if (!purchase.IsAcknowledged())
			{
				return EntitlementStatus.EntitledButNotFinished;
			}
			return EntitlementStatus.FullyEntitled;
		}

		// Token: 0x04000019 RID: 25
		private readonly IGoogleQueryPurchasesUseCase m_GoogleQueryPurchasesUseCase;
	}
}
