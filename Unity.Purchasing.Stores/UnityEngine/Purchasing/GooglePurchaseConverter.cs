using System;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000024 RID: 36
	[NullableContext(1)]
	[Nullable(0)]
	internal class GooglePurchaseConverter : IGooglePurchaseConverter
	{
		// Token: 0x060000BC RID: 188 RVA: 0x00004422 File Offset: 0x00002622
		[Preserve]
		internal GooglePurchaseConverter(IProductDetailsConverter productDetailsConverter)
		{
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000442C File Offset: 0x0000262C
		public Order CreateOrderFromPurchase(IGooglePurchase purchase, [Nullable(2)] IProductCache productCache)
		{
			ICart cart = this.CreateCartFromPurchase(purchase, productCache);
			GoogleOrderInfo info = new GoogleOrderInfo(purchase.receipt, purchase.purchaseToken, "GooglePlay", purchase.obfuscatedAccountId, purchase.obfuscatedProfileId);
			if (purchase.IsPending())
			{
				return new DeferredOrder(cart, info);
			}
			if (GooglePurchaseConverter.GetProductType(cart) != ProductType.Consumable && purchase.IsAcknowledged())
			{
				return new ConfirmedOrder(cart, info);
			}
			return new PendingOrder(cart, info);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00004494 File Offset: 0x00002694
		private static ProductType GetProductType(ICart cart)
		{
			CartItem cartItem = cart.Items().FirstOrDefault<CartItem>();
			ProductType? productType;
			if (cartItem == null)
			{
				productType = null;
			}
			else
			{
				ProductDefinition definition = cartItem.Product.definition;
				productType = ((definition != null) ? new ProductType?(definition.type) : null);
			}
			ProductType? productType2 = productType;
			if (productType2 == null)
			{
				return ProductType.Unknown;
			}
			return productType2.GetValueOrDefault();
		}

		// Token: 0x060000BF RID: 191 RVA: 0x000044F4 File Offset: 0x000026F4
		public ICart CreateCartFromPurchase(IGooglePurchase purchase, [Nullable(2)] IProductCache productCache)
		{
			Product product = ((productCache != null) ? productCache.Find(purchase.sku) : null) ?? this.DefaultProduct(purchase);
			return new Cart(new Product(product.definition, product.metadata, purchase.receipt)
			{
				transactionID = purchase.purchaseToken
			});
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000454C File Offset: 0x0000274C
		private Product DefaultProduct(IGooglePurchase purchase)
		{
			ProductDescription productDescription = purchase.productDescriptions.FirstOrDefault<ProductDescription>();
			return new Product(new ProductDefinition(purchase.sku, purchase.sku, ProductType.Unknown), (productDescription != null) ? productDescription.metadata : null);
		}
	}
}
