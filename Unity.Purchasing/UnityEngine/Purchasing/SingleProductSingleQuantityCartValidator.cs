using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000030 RID: 48
	public class SingleProductSingleQuantityCartValidator : AggregateCartValidator
	{
		// Token: 0x060000CB RID: 203 RVA: 0x00003524 File Offset: 0x00001724
		public SingleProductSingleQuantityCartValidator() : base(new ICartValidator[]
		{
			new NonNullCartValidator(),
			new SingleProductCartValidator(),
			new SingleQuantityCartValidator()
		})
		{
		}
	}
}
