using System;
using System.Collections.Generic;
using System.Linq;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200002C RID: 44
	internal class DistinctProductsCartValidator : ICartValidator
	{
		// Token: 0x060000C2 RID: 194 RVA: 0x000033C4 File Offset: 0x000015C4
		public void Validate(ICart cart)
		{
			IReadOnlyList<CartItem> source = cart.Items();
			if (source.Distinct<CartItem>().Count<CartItem>() != source.Count<CartItem>())
			{
				throw new InvalidCartException("A cart cannot contain more than one copy of the same product. Use Quantity instead.");
			}
		}
	}
}
