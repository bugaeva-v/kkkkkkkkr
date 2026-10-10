using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200002B RID: 43
	[NullableContext(1)]
	[Nullable(0)]
	public class AggregateCartValidator : ICartValidator
	{
		// Token: 0x060000BF RID: 191 RVA: 0x0000334D File Offset: 0x0000154D
		public AggregateCartValidator(List<ICartValidator> cartValidators)
		{
			this.m_CartValidators = cartValidators;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000335C File Offset: 0x0000155C
		public AggregateCartValidator(params ICartValidator[] cartValidators)
		{
			this.m_CartValidators = new List<ICartValidator>(cartValidators);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00003370 File Offset: 0x00001570
		public void Validate(ICart cart)
		{
			foreach (ICartValidator cartValidator in this.m_CartValidators)
			{
				cartValidator.Validate(cart);
			}
		}

		// Token: 0x0400002F RID: 47
		private readonly List<ICartValidator> m_CartValidators;
	}
}
