using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200005B RID: 91
	[NullableContext(1)]
	[Nullable(0)]
	public class PendingOrder : Order
	{
		// Token: 0x06000181 RID: 385 RVA: 0x00003D1F File Offset: 0x00001F1F
		public PendingOrder(ICart cart, IOrderInfo info) : base(cart, info)
		{
			info.PurchasedProductInfo = this.FillPurchasedProductInfo();
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00003D38 File Offset: 0x00001F38
		private List<IPurchasedProductInfo> FillPurchasedProductInfo()
		{
			List<IPurchasedProductInfo> list = new List<IPurchasedProductInfo>();
			IReadOnlyList<CartItem> readOnlyList = base.CartOrdered.Items();
			object obj;
			if (readOnlyList == null)
			{
				obj = null;
			}
			else
			{
				CartItem cartItem = readOnlyList.FirstOrDefault<CartItem>();
				obj = ((cartItem != null) ? cartItem.Product.definition : null);
			}
			object obj2 = obj;
			string text = (obj2 != null) ? obj2.storeSpecificId : null;
			ProductType? productType = (obj2 != null) ? new ProductType?(obj2.type) : null;
			if (text != null)
			{
				list.Add(new PurchasedProductInfo(text, base.Info.Receipt, productType ?? ProductType.Unknown));
			}
			return list;
		}
	}
}
