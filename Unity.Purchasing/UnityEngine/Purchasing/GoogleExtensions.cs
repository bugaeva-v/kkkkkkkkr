using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using UnityEngine.Purchasing.Security;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000C5 RID: 197
	internal class GoogleExtensions : IGooglePlayStoreExtensions, IStoreExtension
	{
		// Token: 0x060003A1 RID: 929 RVA: 0x00008BA0 File Offset: 0x00006DA0
		public void RestoreTransactions(Action<bool, string> callback)
		{
			IPurchaseService purchaseService = UnityIAPServices.Purchase("GooglePlay");
			if (purchaseService == null)
			{
				return;
			}
			purchaseService.RestoreTransactions(callback);
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x00008BB7 File Offset: 0x00006DB7
		public void ConfirmSubscriptionPriceChange(string productId, Action<bool> callback)
		{
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x00008BB9 File Offset: 0x00006DB9
		public void UpgradeDowngradeSubscription(string oldSku, string newSku)
		{
			this.UpgradeDowngradeSubscription(oldSku, newSku, GooglePlayProrationMode.ImmediateWithoutProration);
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x00008BC4 File Offset: 0x00006DC4
		public void UpgradeDowngradeSubscription(string oldSku, string newSku, int desiredProrationMode)
		{
			this.UpgradeDowngradeSubscription(oldSku, newSku, (GooglePlayProrationMode)desiredProrationMode);
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x00008BD0 File Offset: 0x00006DD0
		public void UpgradeDowngradeSubscription(string oldSku, string newSku, GooglePlayProrationMode desiredProrationMode)
		{
			IPurchaseService purchaseService = UnityIAPServices.Purchase("GooglePlay");
			IProductService productService = UnityIAPServices.Product("GooglePlay");
			ReadOnlyCollection<Order> purchases = purchaseService.GetPurchases();
			Product oldProduct = null;
			Func<CartItem, bool> <>9__1;
			foreach (Order order in purchases)
			{
				IEnumerable<CartItem> source = order.CartOrdered.Items();
				Func<CartItem, bool> predicate;
				if ((predicate = <>9__1) == null)
				{
					predicate = (<>9__1 = ((CartItem cartItem) => cartItem.Product.definition.storeSpecificId == oldSku));
				}
				CartItem cartItem2 = source.FirstOrDefault(predicate);
				if (cartItem2 != null)
				{
					oldProduct = cartItem2.Product;
					break;
				}
			}
			Product newProduct = productService.GetProducts().FirstOrDefault((Product product) => product.definition.storeSpecificId == newSku);
			IGooglePlayStoreExtendedPurchaseService google = UnityIAPServices.Purchase("GooglePlay").Google;
			if (google == null)
			{
				return;
			}
			google.UpgradeDowngradeSubscription(oldProduct, newProduct, desiredProrationMode);
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x00008CB8 File Offset: 0x00006EB8
		public bool IsPurchasedProductDeferred(Product product)
		{
			IPurchaseService purchaseService = UnityIAPServices.Purchase("GooglePlay");
			Func<CartItem, bool> <>9__1;
			foreach (Order order2 in from order in purchaseService.GetPurchases()
			where order is PendingOrder || order is DeferredOrder
			select order)
			{
				IEnumerable<CartItem> source = order2.CartOrdered.Items();
				Func<CartItem, bool> predicate;
				if ((predicate = <>9__1) == null)
				{
					predicate = (<>9__1 = ((CartItem cartItem) => cartItem.Product.definition.id == product.definition.id));
				}
				if (source.FirstOrDefault(predicate) != null)
				{
					IGooglePlayStoreExtendedPurchaseService google = purchaseService.Google;
					return google != null && google.IsOrderDeferred(order2);
				}
			}
			return false;
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x00008D88 File Offset: 0x00006F88
		public GooglePurchaseState GetPurchaseState(Product product)
		{
			IPurchaseService purchaseService = UnityIAPServices.Purchase("GooglePlay");
			if (purchaseService.Google == null)
			{
				throw new Exception("Google purchase service unavailable");
			}
			Func<CartItem, bool> <>9__0;
			foreach (Order order in purchaseService.GetPurchases())
			{
				IEnumerable<CartItem> source = order.CartOrdered.Items();
				Func<CartItem, bool> predicate;
				if ((predicate = <>9__0) == null)
				{
					predicate = (<>9__0 = ((CartItem cartItem) => cartItem.Product.definition.id == product.definition.id));
				}
				if (source.FirstOrDefault(predicate) != null)
				{
					GooglePurchaseState? purchaseState = purchaseService.Google.GetPurchaseState(order);
					if (purchaseState != null)
					{
						return purchaseState.Value;
					}
				}
			}
			throw new Exception("Product " + product.definition.id + " was not purchased.");
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x00008E78 File Offset: 0x00007078
		public string GetObfuscatedAccountId(Product product)
		{
			IPurchaseService purchaseService = UnityIAPServices.Purchase("GooglePlay");
			if (purchaseService.Google == null)
			{
				return null;
			}
			Func<CartItem, bool> <>9__0;
			foreach (Order order in purchaseService.GetPurchases())
			{
				IEnumerable<CartItem> source = order.CartOrdered.Items();
				Func<CartItem, bool> predicate;
				if ((predicate = <>9__0) == null)
				{
					predicate = (<>9__0 = ((CartItem cartItem) => cartItem.Product.definition.id == product.definition.id));
				}
				if (source.FirstOrDefault(predicate) != null)
				{
					return purchaseService.Google.GetObfuscatedAccountId(order);
				}
			}
			return null;
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00008F28 File Offset: 0x00007128
		public string GetObfuscatedProfileId(Product product)
		{
			IPurchaseService purchaseService = UnityIAPServices.Purchase("GooglePlay");
			if (purchaseService.Google == null)
			{
				return null;
			}
			Func<CartItem, bool> <>9__0;
			foreach (Order order in purchaseService.GetPurchases())
			{
				IEnumerable<CartItem> source = order.CartOrdered.Items();
				Func<CartItem, bool> predicate;
				if ((predicate = <>9__0) == null)
				{
					predicate = (<>9__0 = ((CartItem cartItem) => cartItem.Product.definition.id == product.definition.id));
				}
				if (source.FirstOrDefault(predicate) != null)
				{
					return purchaseService.Google.GetObfuscatedProfileId(order);
				}
			}
			return null;
		}
	}
}
