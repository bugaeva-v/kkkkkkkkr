using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200002D RID: 45
	internal class MultipleConsumableQuantityCartValidator : ICartValidator
	{
		// Token: 0x060000C4 RID: 196 RVA: 0x00003400 File Offset: 0x00001600
		[NullableContext(1)]
		public void Validate(ICart cart)
		{
			foreach (CartItem cartItem in cart.Items())
			{
				this.ValidateItem(cartItem);
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00003450 File Offset: 0x00001650
		[NullableContext(1)]
		private void ValidateItem(CartItem cartItem)
		{
			if (cartItem.Product.definition.type == ProductType.Consumable)
			{
				if (cartItem.Quantity <= 0)
				{
					throw new InvalidCartItemException("Consumable product quantity should be greater than 0.");
				}
			}
			else if (cartItem.Quantity != 1)
			{
				throw new InvalidCartItemException("Subscription and non-consumable product quantity should be equal to 1.");
			}
		}
	}
}
