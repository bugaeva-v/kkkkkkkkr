using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000049 RID: 73
	[NullableContext(1)]
	[Nullable(0)]
	public class CartItem
	{
		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000135 RID: 309 RVA: 0x00003940 File Offset: 0x00001B40
		public Product Product { get; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000136 RID: 310 RVA: 0x00003948 File Offset: 0x00001B48
		public int Quantity { get; }

		// Token: 0x06000137 RID: 311 RVA: 0x00003950 File Offset: 0x00001B50
		public CartItem(Product product) : this(product, 1)
		{
		}

		// Token: 0x06000138 RID: 312 RVA: 0x0000395A File Offset: 0x00001B5A
		internal CartItem(Product product, int quantity)
		{
			if (((product != null) ? product.definition : null) == null)
			{
				throw new InvalidCartItemException("A cart item product and product definition must not be null.");
			}
			this.Product = product;
			this.Quantity = quantity;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00003989 File Offset: 0x00001B89
		public static implicit operator CartItem(Product product)
		{
			return new CartItem(product);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00003991 File Offset: 0x00001B91
		public override int GetHashCode()
		{
			return this.Product.GetHashCode();
		}

		// Token: 0x0600013B RID: 315 RVA: 0x000039A0 File Offset: 0x00001BA0
		public override bool Equals(object obj)
		{
			CartItem cartItem = obj as CartItem;
			return cartItem != null && this.Product.Equals(cartItem.Product);
		}
	}
}
