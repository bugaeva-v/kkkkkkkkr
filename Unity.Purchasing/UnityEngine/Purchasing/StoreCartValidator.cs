using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000032 RID: 50
	[NullableContext(1)]
	[Nullable(0)]
	internal class StoreCartValidator : ICartValidator
	{
		// Token: 0x060000CE RID: 206 RVA: 0x0000358B File Offset: 0x0000178B
		public StoreCartValidator(string storeName, ICartValidator cartValidator)
		{
			this.m_StoreName = storeName;
			this.m_CartValidator = cartValidator;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x000035A4 File Offset: 0x000017A4
		public void Validate(ICart cart)
		{
			try
			{
				this.m_CartValidator.Validate(cart);
			}
			catch (IapException ex)
			{
				throw new InvalidCartException(this.m_StoreName + " cart validation: " + ex.Message);
			}
		}

		// Token: 0x04000030 RID: 48
		private readonly string m_StoreName;

		// Token: 0x04000031 RID: 49
		private readonly ICartValidator m_CartValidator;
	}
}
