using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.Models;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing.Utils
{
	// Token: 0x0200004E RID: 78
	internal class GooglePurchaseBuilder : IGooglePurchaseBuilder
	{
		// Token: 0x060001E8 RID: 488 RVA: 0x00007E75 File Offset: 0x00006075
		[Preserve]
		internal GooglePurchaseBuilder(IGoogleCachedQueryProductDetailsService cachedQueryProductDetailsService, ILogger logger)
		{
			this.m_CachedQueryProductDetailsService = cachedQueryProductDetailsService;
			this.m_Logger = logger;
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00007E8B File Offset: 0x0000608B
		public IEnumerable<IGooglePurchase> BuildPurchases(IEnumerable<AndroidJavaObject> purchases)
		{
			return purchases.Select(new Func<AndroidJavaObject, IGooglePurchase>(this.BuildPurchase)).IgnoreExceptions(new Action<ArgumentException>(this.LogWarningForException)).ToList<IGooglePurchase>();
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00007EB5 File Offset: 0x000060B5
		private void LogWarningForException(Exception exception)
		{
			this.m_Logger.LogIAPWarning(exception.Message);
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00007EC8 File Offset: 0x000060C8
		public IGooglePurchase BuildPurchase(AndroidJavaObject purchase)
		{
			IEnumerable<AndroidJavaObject> cachedQueriedProducts = this.m_CachedQueryProductDetailsService.GetCachedQueriedProducts();
			IGooglePurchase result;
			using (AndroidJavaObject androidJavaObject = purchase.Call<AndroidJavaObject>("getProducts", Array.Empty<object>()))
			{
				IEnumerable<string> skus = androidJavaObject.Enumerate<string>();
				try
				{
					IEnumerable<AndroidJavaObject> productDetailsEnum = GooglePurchaseBuilder.TryFindAllProductDetails(skus, cachedQueriedProducts);
					result = new GooglePurchase(purchase, productDetailsEnum);
				}
				catch (InvalidOperationException)
				{
					string text = purchase.Call<string>("getOrderId", Array.Empty<object>());
					string text2 = purchase.Call<string>("getPurchaseToken", Array.Empty<object>());
					throw new ArgumentException(string.Concat(new string[]
					{
						"Unable to process purchase with order id: ",
						text,
						" and purchase token: ",
						text2,
						" because the product details associated with the purchased products were not found."
					}));
				}
			}
			return result;
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00007F8C File Offset: 0x0000618C
		private static IEnumerable<AndroidJavaObject> TryFindAllProductDetails(IEnumerable<string> skus, IEnumerable<AndroidJavaObject> productDetails)
		{
			return from sku in skus
			select productDetails.First((AndroidJavaObject productDetail) => sku == productDetail.Call<string>("getProductId", Array.Empty<object>()));
		}

		// Token: 0x040000C2 RID: 194
		private readonly IGoogleCachedQueryProductDetailsService m_CachedQueryProductDetailsService;

		// Token: 0x040000C3 RID: 195
		private readonly ILogger m_Logger;
	}
}
