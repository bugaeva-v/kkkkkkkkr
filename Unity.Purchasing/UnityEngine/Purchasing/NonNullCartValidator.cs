using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200002E RID: 46
	public class NonNullCartValidator : ICartValidator
	{
		// Token: 0x060000C7 RID: 199 RVA: 0x00003494 File Offset: 0x00001694
		[NullableContext(1)]
		public void Validate(ICart cart)
		{
			if (cart == null)
			{
				throw new InvalidCartException("Cart cannot be null.");
			}
			if (cart.Items() == null)
			{
				throw new InvalidCartException("Cart items cannot be null.");
			}
			if (cart.Items().Any(delegate(CartItem cartItem)
			{
				object obj;
				if (cartItem == null)
				{
					obj = null;
				}
				else
				{
					Product product = cartItem.Product;
					obj = ((product != null) ? product.definition : null);
				}
				return obj == null;
			}))
			{
				throw new InvalidCartItemException("Cart cannot contain null items or products.");
			}
		}
	}
}
