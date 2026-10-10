using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200004B RID: 75
	[NullableContext(1)]
	[Nullable(0)]
	public class ConfirmedOrder : Order
	{
		// Token: 0x0600013F RID: 319 RVA: 0x000039F0 File Offset: 0x00001BF0
		public ConfirmedOrder(ICart cart, IOrderInfo info) : base(cart, info)
		{
			info.PurchasedProductInfo = this.FillPurchasedProductInfo();
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00003A08 File Offset: 0x00001C08
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
