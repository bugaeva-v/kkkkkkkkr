using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000047 RID: 71
	internal class FakeStoreCartValidator : StoreCartValidator
	{
		// Token: 0x060001B6 RID: 438 RVA: 0x000073B4 File Offset: 0x000055B4
		public FakeStoreCartValidator() : base("Fake App Store", new NonNullCartValidator())
		{
		}
	}
}
