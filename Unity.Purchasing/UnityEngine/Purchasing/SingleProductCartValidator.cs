using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200002F RID: 47
	public class SingleProductCartValidator : ICartValidator
	{
		// Token: 0x060000C9 RID: 201 RVA: 0x00003501 File Offset: 0x00001701
		[NullableContext(1)]
		public void Validate(ICart cart)
		{
			if (cart.Items().Count<CartItem>() != 1)
			{
				throw new InvalidCartException("Cart must contain 1 cart item.");
			}
		}
	}
}
