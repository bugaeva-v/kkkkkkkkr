using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000031 RID: 49
	public class SingleQuantityCartValidator : ICartValidator
	{
		// Token: 0x060000CC RID: 204 RVA: 0x0000354A File Offset: 0x0000174A
		[NullableContext(1)]
		public void Validate(ICart cart)
		{
			if (cart.Items().Any((CartItem cartItem) => cartItem.Quantity != 1))
			{
				throw new InvalidCartItemException("Cart item quantity should be equal to 1.");
			}
		}
	}
}
