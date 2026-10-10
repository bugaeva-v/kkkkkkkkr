using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000BD RID: 189
	internal class AppleConfiguration : IAppleConfiguration, IStoreConfiguration
	{
		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600036C RID: 876 RVA: 0x000085BE File Offset: 0x000067BE
		public string appReceipt
		{
			get
			{
				IAppleStoreExtendedPurchaseService apple = UnityIAPServices.DefaultPurchase().Apple;
				if (apple == null)
				{
					return null;
				}
				return apple.appReceipt;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600036D RID: 877 RVA: 0x000085D5 File Offset: 0x000067D5
		public bool canMakePayments
		{
			get
			{
				IAppleStoreExtendedService apple = UnityIAPServices.DefaultStore().Apple;
				bool flag;
				if (apple == null)
				{
					flag = false;
				}
				else
				{
					bool canMakePayments = apple.canMakePayments;
					flag = true;
				}
				return flag && UnityIAPServices.DefaultStore().Apple.canMakePayments;
			}
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00008604 File Offset: 0x00006804
		public void SetApplePromotionalPurchaseInterceptorCallback(Action<Product> callback)
		{
			IAppleStoreExtendedPurchaseService apple = UnityIAPServices.DefaultPurchase().Apple;
			if (apple != null)
			{
				apple.OnPromotionalPurchaseIntercepted += callback;
			}
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00008628 File Offset: 0x00006828
		public void SetEntitlementsRevokedListener(Action<List<Product>> callback)
		{
			IAppleStoreExtendedPurchaseService apple = UnityIAPServices.DefaultPurchase().Apple;
			if (apple != null)
			{
				apple.OnEntitlementRevoked += delegate(string productIds)
				{
					IEnumerable<Product> enumerable = from product in UnityIAPServices.DefaultProduct().GetProducts()
					where productIds.Contains(product.definition.storeSpecificId)
					select product;
					Action<List<Product>> callback2 = callback;
					if (callback2 == null)
					{
						return;
					}
					callback2((List<Product>)enumerable);
				};
			}
		}
	}
}
