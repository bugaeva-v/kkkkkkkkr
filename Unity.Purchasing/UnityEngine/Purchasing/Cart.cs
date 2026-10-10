using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000048 RID: 72
	[NullableContext(1)]
	[Nullable(0)]
	public class Cart : ICart
	{
		// Token: 0x0600012F RID: 303 RVA: 0x00003831 File Offset: 0x00001A31
		public Cart(CartItem cartItem)
		{
			this.m_CartItems.Add(cartItem);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00003854 File Offset: 0x00001A54
		public IReadOnlyList<CartItem> Items()
		{
			IReadOnlyList<CartItem> result;
			if ((result = this.m_CachedItemsList) == null)
			{
				result = (this.m_CachedItemsList = this.m_CartItems.ToList<CartItem>());
			}
			return result;
		}

		// Token: 0x06000131 RID: 305 RVA: 0x0000387F File Offset: 0x00001A7F
		public void AddItem(CartItem item)
		{
			if (this.m_CartItems.Add(item))
			{
				this.m_CachedItemsList = null;
			}
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00003896 File Offset: 0x00001A96
		public void RemoveItem(CartItem item)
		{
			if (this.m_CartItems.Remove(item))
			{
				this.m_CachedItemsList = null;
			}
		}

		// Token: 0x06000133 RID: 307 RVA: 0x000038B0 File Offset: 0x00001AB0
		public override bool Equals(object obj)
		{
			if (this == obj)
			{
				return true;
			}
			Cart cart = obj as Cart;
			return cart != null && this.m_CartItems.SetEquals(cart.m_CartItems);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x000038E0 File Offset: 0x00001AE0
		public override int GetHashCode()
		{
			int num = 17;
			foreach (CartItem cartItem in this.m_CartItems)
			{
				num ^= ((cartItem != null) ? cartItem.GetHashCode() : 0);
			}
			return num;
		}

		// Token: 0x04000039 RID: 57
		private readonly HashSet<CartItem> m_CartItems = new HashSet<CartItem>();

		// Token: 0x0400003A RID: 58
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private IReadOnlyList<CartItem> m_CachedItemsList;
	}
}
